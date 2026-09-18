//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvista
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyvistaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<FinishActionResponse> FinishAction([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyendActionchoice = null, [WorkflowExpression] Func<string> bodyendActiondescription = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/actions/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var endActionObject = new JObject();
            var endActionObjectpropCount = 0;
            if (bodyendActionchoice != null)
            {
                endActionObject["Choice"] = ExpressionConverter.ConvertO(bodyendActionchoice);
                endActionObjectpropCount++;
            }

            if (bodyendActiondescription != null)
            {
                endActionObject["Description"] = ExpressionConverter.ConvertO(bodyendActiondescription);
                endActionObjectpropCount++;
            }

            if (endActionObjectpropCount > 0)
            {
                body["end_action"] = endActionObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FinishActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewAssetsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<bodyassetsInputItem[]> bodyassets = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassets != null)
            {
                body["assets"] = ExpressionConverter.ConvertO(bodyassets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> bodybEFORELOANDEPARTMENTID = null, [WorkflowExpression] Func<string> bodybEFORELOANEMPLOYEEID = null, [WorkflowExpression] Func<string> bodybEFORELOANLOCATIONID = null, [WorkflowExpression] Func<string> bodybILLINGPERIODICITYINMONTH = null, [WorkflowExpression] Func<string> bodybUYBACKVALUE = null, [WorkflowExpression] Func<string> bodybUYBACKVALUECURID = null, [WorkflowExpression] Func<string> bodycATALOGID = null, [WorkflowExpression] Func<string> bodycHARGEBACK = null, [WorkflowExpression] Func<string> bodycHARGEBACKCURID = null, [WorkflowExpression] Func<string> bodycISTATUSID = null, [WorkflowExpression] Func<string> bodycIVERSION = null, [WorkflowExpression] Func<string> bodycMDEFAULTCHANGEID = null, [WorkflowExpression] Func<string> bodycONFIGURATIONID = null, [WorkflowExpression] Func<string> bodycRITICALLEVELID = null, [WorkflowExpression] Func<string> bodydELIVERYDATE = null, [WorkflowExpression] Func<string> bodydELIVERYNUMBER = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodydEPRECIATIONRULEID = null, [WorkflowExpression] Func<string> bodydHARDWAREGUID = null, [WorkflowExpression] Func<string> bodyeMPLOYEEID = null, [WorkflowExpression] Func<string> bodyeNDOFWARANTY = null, [WorkflowExpression] Func<string> bodyeNTRYDATE = null, [WorkflowExpression] Func<string> bodyeSTIMATEDPERCENTAGEUSE = null, [WorkflowExpression] Func<string> bodyeXPECTEDENDLENDDATE = null, [WorkflowExpression] Func<string> bodyeXPECTEDRETURNDATE = null, [WorkflowExpression] Func<string> bodyfALLENTERM = null, [WorkflowExpression] Func<string> bodyfIXEDASSETNUMBER = null, [WorkflowExpression] Func<string> bodyiNITIALSTART = null, [WorkflowExpression] Func<string> bodyiNSTALLATIONDATE = null, [WorkflowExpression] Func<string> bodyiNTERNALDELIVERYDATE = null, [WorkflowExpression] Func<string> bodyiNVOICENUMBER = null, [WorkflowExpression] Func<string> bodyiSDML = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTPHYSICALINVENTORY = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylICENSEVERSION = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodymAINTENANCECOST = null, [WorkflowExpression] Func<string> bodymAINTENANCECOSTCURID = null, [WorkflowExpression] Func<string> bodymAINUSAGEID = null, [WorkflowExpression] Func<string> bodymAXINSTALLS = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOST = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOSTCURID = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTAL = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTALCURID = null, [WorkflowExpression] Func<string> bodymONTHDURATION = null, [WorkflowExpression] Func<string> bodynETWORKIDENTIFIER = null, [WorkflowExpression] Func<string> bodynEXTDEPARTMENTID = null, [WorkflowExpression] Func<string> bodynEXTMAINTENANCEDATE = null, [WorkflowExpression] Func<string> bodynEXTSTATUSID = null, [WorkflowExpression] Func<string> bodynEXTUSERAPPLICATIONDATE = null, [WorkflowExpression] Func<string> bodynEXTUSERID = null, [WorkflowExpression] Func<string> bodynOTICE = null, [WorkflowExpression] Func<string> bodyoRDERDETAILSID = null, [WorkflowExpression] Func<string> bodyoRDERNUMBER = null, [WorkflowExpression] Func<string> bodypIPELINESTATUSID = null, [WorkflowExpression] Func<string> bodypOWERCONSUMPTIONWH = null, [WorkflowExpression] Func<string> bodypROCESSORCOUNT = null, [WorkflowExpression] Func<string> bodypROCESSORSOCKETCOUNT = null, [WorkflowExpression] Func<string> bodypURCHASEDATE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICECURID = null, [WorkflowExpression] Func<string> bodypURCHASERATEID = null, [WorkflowExpression] Func<string> bodyrECYCLEDDATE = null, [WorkflowExpression] Func<string> bodyrECYCLINGPROVIDERID = null, [WorkflowExpression] Func<string> bodyrEFORMNUMBER = null, [WorkflowExpression] Func<string> bodyrEMOVEDDATE = null, [WorkflowExpression] Func<string> bodyrENEWALDECISIONID = null, [WorkflowExpression] Func<string> bodyrENEWALVALUE = null, [WorkflowExpression] Func<string> bodyrENEWALVALUECURID = null, [WorkflowExpression] Func<string> bodyrEPAIREDBYID = null, [WorkflowExpression] Func<string> bodyrESALESVALUE = null, [WorkflowExpression] Func<string> bodysCHEDULEDEND = null, [WorkflowExpression] Func<string> bodysDCATALOGID = null, [WorkflowExpression] Func<string> bodysERIALNUMBER = null, [WorkflowExpression] Func<string> bodysLAID = null, [WorkflowExpression] Func<string> bodysTATUSID = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodytERM = null, [WorkflowExpression] Func<string> bodyuPDATECOVERAGETERM = null, [WorkflowExpression] Func<string> bodywARANTYTYPEID = null, [WorkflowExpression] Func<string> bodyassetLabel = null, [WorkflowExpression] Func<string> bodyassetTag = null, [WorkflowExpression] Func<string> bodyautomaticRenewal = null, [WorkflowExpression] Func<string> bodyavailabilitySlaId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycommentAsset = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybEFORELOANDEPARTMENTID != null)
            {
                body["BEFORE_LOAN_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodybEFORELOANDEPARTMENTID);
                bodypropCount++;
            }

            if (bodybEFORELOANEMPLOYEEID != null)
            {
                body["BEFORE_LOAN_EMPLOYEE_ID"] = ExpressionConverter.ConvertO(bodybEFORELOANEMPLOYEEID);
                bodypropCount++;
            }

            if (bodybEFORELOANLOCATIONID != null)
            {
                body["BEFORE_LOAN_LOCATION_ID"] = ExpressionConverter.ConvertO(bodybEFORELOANLOCATIONID);
                bodypropCount++;
            }

            if (bodybILLINGPERIODICITYINMONTH != null)
            {
                body["BILLING_PERIODICITY_IN_MONTH"] = ExpressionConverter.ConvertO(bodybILLINGPERIODICITYINMONTH);
                bodypropCount++;
            }

            if (bodybUYBACKVALUE != null)
            {
                body["BUY_BACK_VALUE"] = ExpressionConverter.ConvertO(bodybUYBACKVALUE);
                bodypropCount++;
            }

            if (bodybUYBACKVALUECURID != null)
            {
                body["BUY_BACK_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(bodybUYBACKVALUECURID);
                bodypropCount++;
            }

            if (bodycATALOGID != null)
            {
                body["CATALOG_ID"] = ExpressionConverter.ConvertO(bodycATALOGID);
                bodypropCount++;
            }

            if (bodycHARGEBACK != null)
            {
                body["CHARGE_BACK"] = ExpressionConverter.ConvertO(bodycHARGEBACK);
                bodypropCount++;
            }

            if (bodycHARGEBACKCURID != null)
            {
                body["CHARGE_BACK_CUR_ID"] = ExpressionConverter.ConvertO(bodycHARGEBACKCURID);
                bodypropCount++;
            }

            if (bodycISTATUSID != null)
            {
                body["CI_STATUS_ID"] = ExpressionConverter.ConvertO(bodycISTATUSID);
                bodypropCount++;
            }

            if (bodycIVERSION != null)
            {
                body["CI_VERSION"] = ExpressionConverter.ConvertO(bodycIVERSION);
                bodypropCount++;
            }

            if (bodycMDEFAULTCHANGEID != null)
            {
                body["CM_DEFAULT_CHANGE_ID"] = ExpressionConverter.ConvertO(bodycMDEFAULTCHANGEID);
                bodypropCount++;
            }

            if (bodycONFIGURATIONID != null)
            {
                body["CONFIGURATION_ID"] = ExpressionConverter.ConvertO(bodycONFIGURATIONID);
                bodypropCount++;
            }

            if (bodycRITICALLEVELID != null)
            {
                body["CRITICAL_LEVEL_ID"] = ExpressionConverter.ConvertO(bodycRITICALLEVELID);
                bodypropCount++;
            }

            if (bodydELIVERYDATE != null)
            {
                body["DELIVERY_DATE"] = ExpressionConverter.ConvertO(bodydELIVERYDATE);
                bodypropCount++;
            }

            if (bodydELIVERYNUMBER != null)
            {
                body["DELIVERY_NUMBER"] = ExpressionConverter.ConvertO(bodydELIVERYNUMBER);
                bodypropCount++;
            }

            if (bodydEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodydEPARTMENTID);
                bodypropCount++;
            }

            if (bodydEPRECIATIONRULEID != null)
            {
                body["DEPRECIATION_RULE_ID"] = ExpressionConverter.ConvertO(bodydEPRECIATIONRULEID);
                bodypropCount++;
            }

            if (bodydHARDWAREGUID != null)
            {
                body["D_HARDWARE_GUID"] = ExpressionConverter.ConvertO(bodydHARDWAREGUID);
                bodypropCount++;
            }

            if (bodyeMPLOYEEID != null)
            {
                body["EMPLOYEE_ID"] = ExpressionConverter.ConvertO(bodyeMPLOYEEID);
                bodypropCount++;
            }

            if (bodyeNDOFWARANTY != null)
            {
                body["END_OF_WARANTY"] = ExpressionConverter.ConvertO(bodyeNDOFWARANTY);
                bodypropCount++;
            }

            if (bodyeNTRYDATE != null)
            {
                body["ENTRY_DATE"] = ExpressionConverter.ConvertO(bodyeNTRYDATE);
                bodypropCount++;
            }

            if (bodyeSTIMATEDPERCENTAGEUSE != null)
            {
                body["ESTIMATED_PERCENTAGE_USE"] = ExpressionConverter.ConvertO(bodyeSTIMATEDPERCENTAGEUSE);
                bodypropCount++;
            }

            if (bodyeXPECTEDENDLENDDATE != null)
            {
                body["EXPECTED_END_LEND_DATE"] = ExpressionConverter.ConvertO(bodyeXPECTEDENDLENDDATE);
                bodypropCount++;
            }

            if (bodyeXPECTEDRETURNDATE != null)
            {
                body["EXPECTED_RETURN_DATE"] = ExpressionConverter.ConvertO(bodyeXPECTEDRETURNDATE);
                bodypropCount++;
            }

            if (bodyfALLENTERM != null)
            {
                body["FALLEN_TERM"] = ExpressionConverter.ConvertO(bodyfALLENTERM);
                bodypropCount++;
            }

            if (bodyfIXEDASSETNUMBER != null)
            {
                body["FIXED_ASSET_NUMBER"] = ExpressionConverter.ConvertO(bodyfIXEDASSETNUMBER);
                bodypropCount++;
            }

            if (bodyiNITIALSTART != null)
            {
                body["INITIAL_START"] = ExpressionConverter.ConvertO(bodyiNITIALSTART);
                bodypropCount++;
            }

            if (bodyiNSTALLATIONDATE != null)
            {
                body["INSTALLATION_DATE"] = ExpressionConverter.ConvertO(bodyiNSTALLATIONDATE);
                bodypropCount++;
            }

            if (bodyiNTERNALDELIVERYDATE != null)
            {
                body["INTERNAL_DELIVERY_DATE"] = ExpressionConverter.ConvertO(bodyiNTERNALDELIVERYDATE);
                bodypropCount++;
            }

            if (bodyiNVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(bodyiNVOICENUMBER);
                bodypropCount++;
            }

            if (bodyiSDML != null)
            {
                body["IS_DML"] = ExpressionConverter.ConvertO(bodyiSDML);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodylASTPHYSICALINVENTORY != null)
            {
                body["LAST_PHYSICAL_INVENTORY"] = ExpressionConverter.ConvertO(bodylASTPHYSICALINVENTORY);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylICENSEVERSION != null)
            {
                body["LICENSE_VERSION"] = ExpressionConverter.ConvertO(bodylICENSEVERSION);
                bodypropCount++;
            }

            if (bodylOCATIONID != null)
            {
                body["LOCATION_ID"] = ExpressionConverter.ConvertO(bodylOCATIONID);
                bodypropCount++;
            }

            if (bodymAINTENANCECOST != null)
            {
                body["MAINTENANCE_COST"] = ExpressionConverter.ConvertO(bodymAINTENANCECOST);
                bodypropCount++;
            }

            if (bodymAINTENANCECOSTCURID != null)
            {
                body["MAINTENANCE_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodymAINTENANCECOSTCURID);
                bodypropCount++;
            }

            if (bodymAINUSAGEID != null)
            {
                body["MAIN_USAGE_ID"] = ExpressionConverter.ConvertO(bodymAINUSAGEID);
                bodypropCount++;
            }

            if (bodymAXINSTALLS != null)
            {
                body["MAX_INSTALLS"] = ExpressionConverter.ConvertO(bodymAXINSTALLS);
                bodypropCount++;
            }

            if (bodymONTHLYFIXEDCOST != null)
            {
                body["MONTHLY_FIXED_COST"] = ExpressionConverter.ConvertO(bodymONTHLYFIXEDCOST);
                bodypropCount++;
            }

            if (bodymONTHLYFIXEDCOSTCURID != null)
            {
                body["MONTHLY_FIXED_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodymONTHLYFIXEDCOSTCURID);
                bodypropCount++;
            }

            if (bodymONTHLYNETRENTAL != null)
            {
                body["MONTHLY_NET_RENTAL"] = ExpressionConverter.ConvertO(bodymONTHLYNETRENTAL);
                bodypropCount++;
            }

            if (bodymONTHLYNETRENTALCURID != null)
            {
                body["MONTHLY_NET_RENTAL_CUR_ID"] = ExpressionConverter.ConvertO(bodymONTHLYNETRENTALCURID);
                bodypropCount++;
            }

            if (bodymONTHDURATION != null)
            {
                body["MONTH_DURATION"] = ExpressionConverter.ConvertO(bodymONTHDURATION);
                bodypropCount++;
            }

            if (bodynETWORKIDENTIFIER != null)
            {
                body["NETWORK_IDENTIFIER"] = ExpressionConverter.ConvertO(bodynETWORKIDENTIFIER);
                bodypropCount++;
            }

            if (bodynEXTDEPARTMENTID != null)
            {
                body["NEXT_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodynEXTDEPARTMENTID);
                bodypropCount++;
            }

            if (bodynEXTMAINTENANCEDATE != null)
            {
                body["NEXT_MAINTENANCE_DATE"] = ExpressionConverter.ConvertO(bodynEXTMAINTENANCEDATE);
                bodypropCount++;
            }

            if (bodynEXTSTATUSID != null)
            {
                body["NEXT_STATUS_ID"] = ExpressionConverter.ConvertO(bodynEXTSTATUSID);
                bodypropCount++;
            }

            if (bodynEXTUSERAPPLICATIONDATE != null)
            {
                body["NEXT_USER_APPLICATION_DATE"] = ExpressionConverter.ConvertO(bodynEXTUSERAPPLICATIONDATE);
                bodypropCount++;
            }

            if (bodynEXTUSERID != null)
            {
                body["NEXT_USER_ID"] = ExpressionConverter.ConvertO(bodynEXTUSERID);
                bodypropCount++;
            }

            if (bodynOTICE != null)
            {
                body["NOTICE"] = ExpressionConverter.ConvertO(bodynOTICE);
                bodypropCount++;
            }

            if (bodyoRDERDETAILSID != null)
            {
                body["ORDER_DETAILS_ID"] = ExpressionConverter.ConvertO(bodyoRDERDETAILSID);
                bodypropCount++;
            }

            if (bodyoRDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodyoRDERNUMBER);
                bodypropCount++;
            }

            if (bodypIPELINESTATUSID != null)
            {
                body["PIPELINE_STATUS_ID"] = ExpressionConverter.ConvertO(bodypIPELINESTATUSID);
                bodypropCount++;
            }

            if (bodypOWERCONSUMPTIONWH != null)
            {
                body["POWER_CONSUMPTION_WH"] = ExpressionConverter.ConvertO(bodypOWERCONSUMPTIONWH);
                bodypropCount++;
            }

            if (bodypROCESSORCOUNT != null)
            {
                body["PROCESSOR_COUNT"] = ExpressionConverter.ConvertO(bodypROCESSORCOUNT);
                bodypropCount++;
            }

            if (bodypROCESSORSOCKETCOUNT != null)
            {
                body["PROCESSOR_SOCKET_COUNT"] = ExpressionConverter.ConvertO(bodypROCESSORSOCKETCOUNT);
                bodypropCount++;
            }

            if (bodypURCHASEDATE != null)
            {
                body["PURCHASE_DATE"] = ExpressionConverter.ConvertO(bodypURCHASEDATE);
                bodypropCount++;
            }

            if (bodypURCHASEPRICE != null)
            {
                body["PURCHASE_PRICE"] = ExpressionConverter.ConvertO(bodypURCHASEPRICE);
                bodypropCount++;
            }

            if (bodypURCHASEPRICECURID != null)
            {
                body["PURCHASE_PRICE_CUR_ID"] = ExpressionConverter.ConvertO(bodypURCHASEPRICECURID);
                bodypropCount++;
            }

            if (bodypURCHASERATEID != null)
            {
                body["PURCHASE_RATE_ID"] = ExpressionConverter.ConvertO(bodypURCHASERATEID);
                bodypropCount++;
            }

            if (bodyrECYCLEDDATE != null)
            {
                body["RECYCLED_DATE"] = ExpressionConverter.ConvertO(bodyrECYCLEDDATE);
                bodypropCount++;
            }

            if (bodyrECYCLINGPROVIDERID != null)
            {
                body["RECYCLING_PROVIDER_ID"] = ExpressionConverter.ConvertO(bodyrECYCLINGPROVIDERID);
                bodypropCount++;
            }

            if (bodyrEFORMNUMBER != null)
            {
                body["REFORM_NUMBER"] = ExpressionConverter.ConvertO(bodyrEFORMNUMBER);
                bodypropCount++;
            }

            if (bodyrEMOVEDDATE != null)
            {
                body["REMOVED_DATE"] = ExpressionConverter.ConvertO(bodyrEMOVEDDATE);
                bodypropCount++;
            }

            if (bodyrENEWALDECISIONID != null)
            {
                body["RENEWAL_DECISION_ID"] = ExpressionConverter.ConvertO(bodyrENEWALDECISIONID);
                bodypropCount++;
            }

            if (bodyrENEWALVALUE != null)
            {
                body["RENEWAL_VALUE"] = ExpressionConverter.ConvertO(bodyrENEWALVALUE);
                bodypropCount++;
            }

            if (bodyrENEWALVALUECURID != null)
            {
                body["RENEWAL_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(bodyrENEWALVALUECURID);
                bodypropCount++;
            }

            if (bodyrEPAIREDBYID != null)
            {
                body["REPAIRED_BY_ID"] = ExpressionConverter.ConvertO(bodyrEPAIREDBYID);
                bodypropCount++;
            }

            if (bodyrESALESVALUE != null)
            {
                body["RESALES_VALUE"] = ExpressionConverter.ConvertO(bodyrESALESVALUE);
                bodypropCount++;
            }

            if (bodysCHEDULEDEND != null)
            {
                body["SCHEDULED_END"] = ExpressionConverter.ConvertO(bodysCHEDULEDEND);
                bodypropCount++;
            }

            if (bodysDCATALOGID != null)
            {
                body["SD_CATALOG_ID"] = ExpressionConverter.ConvertO(bodysDCATALOGID);
                bodypropCount++;
            }

            if (bodysERIALNUMBER != null)
            {
                body["SERIAL_NUMBER"] = ExpressionConverter.ConvertO(bodysERIALNUMBER);
                bodypropCount++;
            }

            if (bodysLAID != null)
            {
                body["SLA_ID"] = ExpressionConverter.ConvertO(bodysLAID);
                bodypropCount++;
            }

            if (bodysTATUSID != null)
            {
                body["STATUS_ID"] = ExpressionConverter.ConvertO(bodysTATUSID);
                bodypropCount++;
            }

            if (bodysUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(bodysUPPLIERID);
                bodypropCount++;
            }

            if (bodytERM != null)
            {
                body["TERM"] = ExpressionConverter.ConvertO(bodytERM);
                bodypropCount++;
            }

            if (bodyuPDATECOVERAGETERM != null)
            {
                body["UPDATE_COVERAGE_TERM"] = ExpressionConverter.ConvertO(bodyuPDATECOVERAGETERM);
                bodypropCount++;
            }

            if (bodywARANTYTYPEID != null)
            {
                body["WARANTY_TYPE_ID"] = ExpressionConverter.ConvertO(bodywARANTYTYPEID);
                bodypropCount++;
            }

            if (bodyassetLabel != null)
            {
                body["asset_label"] = ExpressionConverter.ConvertO(bodyassetLabel);
                bodypropCount++;
            }

            if (bodyassetTag != null)
            {
                body["asset_tag"] = ExpressionConverter.ConvertO(bodyassetTag);
                bodypropCount++;
            }

            if (bodyautomaticRenewal != null)
            {
                body["automatic_renewal"] = ExpressionConverter.ConvertO(bodyautomaticRenewal);
                bodypropCount++;
            }

            if (bodyavailabilitySlaId != null)
            {
                body["availability_sla_id"] = ExpressionConverter.ConvertO(bodyavailabilitySlaId);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = ExpressionConverter.ConvertO(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["available_field_2"] = ExpressionConverter.ConvertO(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["available_field_3"] = ExpressionConverter.ConvertO(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["available_field_4"] = ExpressionConverter.ConvertO(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["available_field_5"] = ExpressionConverter.ConvertO(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["available_field_6"] = ExpressionConverter.ConvertO(bodyavailableField6);
                bodypropCount++;
            }

            if (bodycommentAsset != null)
            {
                body["comment_asset"] = ExpressionConverter.ConvertO(bodycommentAsset);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string> DeleteAssetLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractRow != null)
            {
                body["Contract_Row"] = ExpressionConverter.ConvertO(bodycontractRow);
                bodypropCount++;
            }

            if (bodymonthlyPayment != null)
            {
                body["Monthly_Payment"] = ExpressionConverter.ConvertO(bodymonthlyPayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractRow != null)
            {
                body["Contract_Row"] = ExpressionConverter.ConvertO(bodycontractRow);
                bodypropCount++;
            }

            if (bodymonthlyPayment != null)
            {
                body["Monthly_Payment"] = ExpressionConverter.ConvertO(bodymonthlyPayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parentAssetId, [WorkflowExpression] Func<string> childAssetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1), ExpressionConverter.ConvertWithUrlEncoding(childAssetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewCatalogAssetsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<ViewCatalogRequestsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests-paths", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewCatalogRequestsPathListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests-paths/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewConfigurationItemsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyrelationTypeID, [WorkflowExpression] Func<string> bodyblocking = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyblocking != null)
            {
                body["Blocking"] = ExpressionConverter.ConvertO(bodyblocking);
                bodypropCount++;
            }

            bodypropCount++;
            body["Relation_Type_ID"] = ExpressionConverter.ConvertO(bodyrelationTypeID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyblocking = null, [WorkflowExpression] Func<string> bodyrelationTypeID = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyblocking != null)
            {
                body["Blocking"] = ExpressionConverter.ConvertO(bodyblocking);
                bodypropCount++;
            }

            if (bodyrelationTypeID != null)
            {
                body["Relation_Type_ID"] = ExpressionConverter.ConvertO(bodyrelationTypeID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/departments", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewEntitiesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> departmentId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(departmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEntityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewEmployeesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<bodyemployeesInputItem[]> bodyemployees = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemployees != null)
            {
                body["employees"] = ExpressionConverter.ConvertO(bodyemployees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> employeeId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> bodyaPPROVEDTOVALIDATE = null, [WorkflowExpression] Func<string> bodyaVAILABILITYSTATUSID = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodybEGINOFCONTRACT = null, [WorkflowExpression] Func<string> bodycELLULARNUMBER = null, [WorkflowExpression] Func<string> bodycHATLOGIN = null, [WorkflowExpression] Func<string> bodycIVILSTATUSID = null, [WorkflowExpression] Func<string> bodycOMMENTEMPLOYEE = null, [WorkflowExpression] Func<string> bodycOSTPERHOUR = null, [WorkflowExpression] Func<string> bodycOSTPERHOURCURID = null, [WorkflowExpression] Func<string> bodydEFAULTCOSTCENTERID = null, [WorkflowExpression] Func<string> bodydELEGATIONFROM = null, [WorkflowExpression] Func<string> bodydELEGATIONID = null, [WorkflowExpression] Func<string> bodydELEGATIONTO = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodyeNDOFCONTRACT = null, [WorkflowExpression] Func<string> bodyeMAIL = null, [WorkflowExpression] Func<string> bodyfAXNUMBER = null, [WorkflowExpression] Func<string> bodyfUNCTIONID = null, [WorkflowExpression] Func<string> bodyiCQNUMBER = null, [WorkflowExpression] Func<string> bodyiDENTIFICATION = null, [WorkflowExpression] Func<string> bodyiSAUTOMATICSTATUS = null, [WorkflowExpression] Func<string> bodyiTCORRESPONDENT = null, [WorkflowExpression] Func<string> bodylANGUAGEID = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTNAME = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodylOGIN = null, [WorkflowExpression] Func<string> bodymANAGERID = null, [WorkflowExpression] Func<string> bodymESSENGERSIGNNAME = null, [WorkflowExpression] Func<string> bodynOTIFICATIONTYPEID = null, [WorkflowExpression] Func<string> bodypASSWDLASTUPDATEUT = null, [WorkflowExpression] Func<string> bodypHONENUMBER = null, [WorkflowExpression] Func<string> bodypICTUREPATH = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodyvALIDATORID = null, [WorkflowExpression] Func<string> bodyvIPLEVELID = null, [WorkflowExpression] Func<string> bodywAVEADDRESS = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaPPROVEDTOVALIDATE != null)
            {
                body["APPROVED_TO_VALIDATE"] = ExpressionConverter.ConvertO(bodyaPPROVEDTOVALIDATE);
                bodypropCount++;
            }

            if (bodyaVAILABILITYSTATUSID != null)
            {
                body["AVAILABILITY_STATUS_ID"] = ExpressionConverter.ConvertO(bodyaVAILABILITYSTATUSID);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(bodyaVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodybEGINOFCONTRACT != null)
            {
                body["BEGIN_OF_CONTRACT"] = ExpressionConverter.ConvertO(bodybEGINOFCONTRACT);
                bodypropCount++;
            }

            if (bodycELLULARNUMBER != null)
            {
                body["CELLULAR_NUMBER"] = ExpressionConverter.ConvertO(bodycELLULARNUMBER);
                bodypropCount++;
            }

            if (bodycHATLOGIN != null)
            {
                body["CHAT_LOGIN"] = ExpressionConverter.ConvertO(bodycHATLOGIN);
                bodypropCount++;
            }

            if (bodycIVILSTATUSID != null)
            {
                body["CIVIL_STATUS_ID"] = ExpressionConverter.ConvertO(bodycIVILSTATUSID);
                bodypropCount++;
            }

            if (bodycOMMENTEMPLOYEE != null)
            {
                body["COMMENT_EMPLOYEE"] = ExpressionConverter.ConvertO(bodycOMMENTEMPLOYEE);
                bodypropCount++;
            }

            if (bodycOSTPERHOUR != null)
            {
                body["COST_PER_HOUR"] = ExpressionConverter.ConvertO(bodycOSTPERHOUR);
                bodypropCount++;
            }

            if (bodycOSTPERHOURCURID != null)
            {
                body["COST_PER_HOUR_CUR_ID"] = ExpressionConverter.ConvertO(bodycOSTPERHOURCURID);
                bodypropCount++;
            }

            if (bodydEFAULTCOSTCENTERID != null)
            {
                body["DEFAULT_COST_CENTER_ID"] = ExpressionConverter.ConvertO(bodydEFAULTCOSTCENTERID);
                bodypropCount++;
            }

            if (bodydELEGATIONFROM != null)
            {
                body["DELEGATION_FROM"] = ExpressionConverter.ConvertO(bodydELEGATIONFROM);
                bodypropCount++;
            }

            if (bodydELEGATIONID != null)
            {
                body["DELEGATION_ID"] = ExpressionConverter.ConvertO(bodydELEGATIONID);
                bodypropCount++;
            }

            if (bodydELEGATIONTO != null)
            {
                body["DELEGATION_TO"] = ExpressionConverter.ConvertO(bodydELEGATIONTO);
                bodypropCount++;
            }

            if (bodydEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodydEPARTMENTID);
                bodypropCount++;
            }

            if (bodyeNDOFCONTRACT != null)
            {
                body["END_OF_CONTRACT"] = ExpressionConverter.ConvertO(bodyeNDOFCONTRACT);
                bodypropCount++;
            }

            if (bodyeMAIL != null)
            {
                body["E_MAIL"] = ExpressionConverter.ConvertO(bodyeMAIL);
                bodypropCount++;
            }

            if (bodyfAXNUMBER != null)
            {
                body["FAX_NUMBER"] = ExpressionConverter.ConvertO(bodyfAXNUMBER);
                bodypropCount++;
            }

            if (bodyfUNCTIONID != null)
            {
                body["FUNCTION_ID"] = ExpressionConverter.ConvertO(bodyfUNCTIONID);
                bodypropCount++;
            }

            if (bodyiCQNUMBER != null)
            {
                body["ICQ_NUMBER"] = ExpressionConverter.ConvertO(bodyiCQNUMBER);
                bodypropCount++;
            }

            if (bodyiDENTIFICATION != null)
            {
                body["IDENTIFICATION"] = ExpressionConverter.ConvertO(bodyiDENTIFICATION);
                bodypropCount++;
            }

            if (bodyiSAUTOMATICSTATUS != null)
            {
                body["IS_AUTOMATIC_STATUS"] = ExpressionConverter.ConvertO(bodyiSAUTOMATICSTATUS);
                bodypropCount++;
            }

            if (bodyiTCORRESPONDENT != null)
            {
                body["IT_CORRESPONDENT"] = ExpressionConverter.ConvertO(bodyiTCORRESPONDENT);
                bodypropCount++;
            }

            if (bodylANGUAGEID != null)
            {
                body["LANGUAGE_ID"] = ExpressionConverter.ConvertO(bodylANGUAGEID);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodylASTNAME != null)
            {
                body["LAST_NAME"] = ExpressionConverter.ConvertO(bodylASTNAME);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylOCATIONID != null)
            {
                body["LOCATION_ID"] = ExpressionConverter.ConvertO(bodylOCATIONID);
                bodypropCount++;
            }

            if (bodylOGIN != null)
            {
                body["LOGIN"] = ExpressionConverter.ConvertO(bodylOGIN);
                bodypropCount++;
            }

            if (bodymANAGERID != null)
            {
                body["MANAGER_ID"] = ExpressionConverter.ConvertO(bodymANAGERID);
                bodypropCount++;
            }

            if (bodymESSENGERSIGNNAME != null)
            {
                body["MESSENGER_SIGN_NAME"] = ExpressionConverter.ConvertO(bodymESSENGERSIGNNAME);
                bodypropCount++;
            }

            if (bodynOTIFICATIONTYPEID != null)
            {
                body["NOTIFICATION_TYPE_ID"] = ExpressionConverter.ConvertO(bodynOTIFICATIONTYPEID);
                bodypropCount++;
            }

            if (bodypASSWDLASTUPDATEUT != null)
            {
                body["PASSWD_LAST_UPDATE_UT"] = ExpressionConverter.ConvertO(bodypASSWDLASTUPDATEUT);
                bodypropCount++;
            }

            if (bodypHONENUMBER != null)
            {
                body["PHONE_NUMBER"] = ExpressionConverter.ConvertO(bodypHONENUMBER);
                bodypropCount++;
            }

            if (bodypICTUREPATH != null)
            {
                body["PICTURE_PATH"] = ExpressionConverter.ConvertO(bodypICTUREPATH);
                bodypropCount++;
            }

            if (bodysUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(bodysUPPLIERID);
                bodypropCount++;
            }

            if (bodyvALIDATORID != null)
            {
                body["VALIDATOR_ID"] = ExpressionConverter.ConvertO(bodyvALIDATORID);
                bodypropCount++;
            }

            if (bodyvIPLEVELID != null)
            {
                body["VIP_LEVEL_ID"] = ExpressionConverter.ConvertO(bodyvIPLEVELID);
                bodypropCount++;
            }

            if (bodywAVEADDRESS != null)
            {
                body["WAVE_ADDRESS"] = ExpressionConverter.ConvertO(bodywAVEADDRESS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/known-problems", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewKnownErrorsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> kpId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/known-problems/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(kpId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewLocationsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> locationId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/manufacturers", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewManufacturerListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> manufacturerId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/manufacturers/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(manufacturerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewRequestsIncidentsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequests != null)
            {
                body["requests"] = ExpressionConverter.ConvertO(bodyrequests);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodyclosedInputItem[]> bodyclosed = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyclosed != null)
            {
                body["closed"] = ExpressionConverter.ConvertO(bodyclosed);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CloseRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyanalyticalChargeId = null, [WorkflowExpression] Func<string> bodyassetId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodybudgetPlanned = null, [WorkflowExpression] Func<string> bodycanBeDuplicated = null, [WorkflowExpression] Func<string> bodyciId = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontinuityPlanId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydelay = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydynamicDetails = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateEnd = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateStart = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodyestimatedNetPrice = null, [WorkflowExpression] Func<string> bodyexpectedDateUt = null, [WorkflowExpression] Func<string> bodyexpectedDuration = null, [WorkflowExpression] Func<string> bodyexpectedEndDateUt = null, [WorkflowExpression] Func<string> bodyexpectedStartDateUt = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyfirstCallResolution = null, [WorkflowExpression] Func<string> bodyhourPerDay = null, [WorkflowExpression] Func<string> bodyimpactId = null, [WorkflowExpression] Func<string> bodyimputationDate = null, [WorkflowExpression] Func<string> bodyisMajorIncident = null, [WorkflowExpression] Func<string> bodyisTemplate = null, [WorkflowExpression] Func<string> bodyknownProblemsId = null, [WorkflowExpression] Func<string> bodylastUpdate = null, [WorkflowExpression] Func<string> bodymark1 = null, [WorkflowExpression] Func<string> bodymark2 = null, [WorkflowExpression] Func<string> bodymaxResolutionDateUt = null, [WorkflowExpression] Func<string> bodymsProjectImportValidationWaiting = null, [WorkflowExpression] Func<string> bodynetPrice = null, [WorkflowExpression] Func<string> bodynetPriceCurId = null, [WorkflowExpression] Func<string> bodyoriginToolId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyowningGroupId = null, [WorkflowExpression] Func<string> bodyplannedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyplannedChangeDateStart = null, [WorkflowExpression] Func<string> bodypmStatusId = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectStartDateUt = null, [WorkflowExpression] Func<string> bodyqty = null, [WorkflowExpression] Func<string> bodyreleaseId = null, [WorkflowExpression] Func<string> bodyrentalNetPrice = null, [WorkflowExpression] Func<string> bodyrentalNetPriceCurId = null, [WorkflowExpression] Func<string> bodyrequestOriginId = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateStart = null, [WorkflowExpression] Func<string> bodyrequestorId = null, [WorkflowExpression] Func<string> bodyrequestorIpAddress = null, [WorkflowExpression] Func<string> bodyrequestorPhone = null, [WorkflowExpression] Func<string> bodyriskAmount = null, [WorkflowExpression] Func<string> bodyriskDescription = null, [WorkflowExpression] Func<string> bodyriskLevelId = null, [WorkflowExpression] Func<string> bodyrootCauseId = null, [WorkflowExpression] Func<string> bodysubmitDateUt = null, [WorkflowExpression] Func<string> bodytimeUsedToSolveRequest = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyanalyticalChargeId != null)
            {
                body["Analytical_Charge_Id"] = ExpressionConverter.ConvertO(bodyanalyticalChargeId);
                bodypropCount++;
            }

            if (bodyassetId != null)
            {
                body["Asset_Id"] = ExpressionConverter.ConvertO(bodyassetId);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["Available_Field_1"] = ExpressionConverter.ConvertO(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["Available_Field_2"] = ExpressionConverter.ConvertO(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["Available_Field_3"] = ExpressionConverter.ConvertO(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["Available_Field_4"] = ExpressionConverter.ConvertO(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["Available_Field_5"] = ExpressionConverter.ConvertO(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["Available_Field_6"] = ExpressionConverter.ConvertO(bodyavailableField6);
                bodypropCount++;
            }

            if (bodybudgetPlanned != null)
            {
                body["Budget_Planned"] = ExpressionConverter.ConvertO(bodybudgetPlanned);
                bodypropCount++;
            }

            if (bodycanBeDuplicated != null)
            {
                body["Can_Be_Duplicated"] = ExpressionConverter.ConvertO(bodycanBeDuplicated);
                bodypropCount++;
            }

            if (bodyciId != null)
            {
                body["Ci_Id"] = ExpressionConverter.ConvertO(bodyciId);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodycontinuityPlanId != null)
            {
                body["Continuity_Plan_Id"] = ExpressionConverter.ConvertO(bodycontinuityPlanId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["Cost_Center_Id"] = ExpressionConverter.ConvertO(bodycostCenterId);
                bodypropCount++;
            }

            if (bodycreationDateUt != null)
            {
                body["Creation_Date_Ut"] = ExpressionConverter.ConvertO(bodycreationDateUt);
                bodypropCount++;
            }

            if (bodydelay != null)
            {
                body["Delay"] = ExpressionConverter.ConvertO(bodydelay);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodydynamicDetails != null)
            {
                body["Dynamic_Details"] = ExpressionConverter.ConvertO(bodydynamicDetails);
                bodypropCount++;
            }

            if (bodyeffectiveChangeDateEnd != null)
            {
                body["Effective_Change_Date_End"] = ExpressionConverter.ConvertO(bodyeffectiveChangeDateEnd);
                bodypropCount++;
            }

            if (bodyeffectiveChangeDateStart != null)
            {
                body["Effective_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyeffectiveChangeDateStart);
                bodypropCount++;
            }

            if (bodyendDateUt != null)
            {
                body["End_Date_Ut"] = ExpressionConverter.ConvertO(bodyendDateUt);
                bodypropCount++;
            }

            if (bodyestimatedNetPrice != null)
            {
                body["Estimated_Net_Price"] = ExpressionConverter.ConvertO(bodyestimatedNetPrice);
                bodypropCount++;
            }

            if (bodyexpectedDateUt != null)
            {
                body["Expected_Date_Ut"] = ExpressionConverter.ConvertO(bodyexpectedDateUt);
                bodypropCount++;
            }

            if (bodyexpectedDuration != null)
            {
                body["Expected_Duration"] = ExpressionConverter.ConvertO(bodyexpectedDuration);
                bodypropCount++;
            }

            if (bodyexpectedEndDateUt != null)
            {
                body["Expected_End_Date_Ut"] = ExpressionConverter.ConvertO(bodyexpectedEndDateUt);
                bodypropCount++;
            }

            if (bodyexpectedStartDateUt != null)
            {
                body["Expected_Start_Date_Ut"] = ExpressionConverter.ConvertO(bodyexpectedStartDateUt);
                bodypropCount++;
            }

            if (bodyexternalReference != null)
            {
                body["External_Reference"] = ExpressionConverter.ConvertO(bodyexternalReference);
                bodypropCount++;
            }

            if (bodyfirstCallResolution != null)
            {
                body["First_Call_Resolution"] = ExpressionConverter.ConvertO(bodyfirstCallResolution);
                bodypropCount++;
            }

            if (bodyhourPerDay != null)
            {
                body["Hour_Per_Day"] = ExpressionConverter.ConvertO(bodyhourPerDay);
                bodypropCount++;
            }

            if (bodyimpactId != null)
            {
                body["Impact_Id"] = ExpressionConverter.ConvertO(bodyimpactId);
                bodypropCount++;
            }

            if (bodyimputationDate != null)
            {
                body["Imputation_Date"] = ExpressionConverter.ConvertO(bodyimputationDate);
                bodypropCount++;
            }

            if (bodyisMajorIncident != null)
            {
                body["Is_Major_Incident"] = ExpressionConverter.ConvertO(bodyisMajorIncident);
                bodypropCount++;
            }

            if (bodyisTemplate != null)
            {
                body["Is_Template"] = ExpressionConverter.ConvertO(bodyisTemplate);
                bodypropCount++;
            }

            if (bodyknownProblemsId != null)
            {
                body["Known_Problems_Id"] = ExpressionConverter.ConvertO(bodyknownProblemsId);
                bodypropCount++;
            }

            if (bodylastUpdate != null)
            {
                body["Last_Update"] = ExpressionConverter.ConvertO(bodylastUpdate);
                bodypropCount++;
            }

            if (bodymark1 != null)
            {
                body["Mark_1"] = ExpressionConverter.ConvertO(bodymark1);
                bodypropCount++;
            }

            if (bodymark2 != null)
            {
                body["Mark_2"] = ExpressionConverter.ConvertO(bodymark2);
                bodypropCount++;
            }

            if (bodymaxResolutionDateUt != null)
            {
                body["Max_Resolution_Date_Ut"] = ExpressionConverter.ConvertO(bodymaxResolutionDateUt);
                bodypropCount++;
            }

            if (bodymsProjectImportValidationWaiting != null)
            {
                body["Ms_Project_Import_Validation_Waiting"] = ExpressionConverter.ConvertO(bodymsProjectImportValidationWaiting);
                bodypropCount++;
            }

            if (bodynetPrice != null)
            {
                body["Net_Price"] = ExpressionConverter.ConvertO(bodynetPrice);
                bodypropCount++;
            }

            if (bodynetPriceCurId != null)
            {
                body["Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(bodynetPriceCurId);
                bodypropCount++;
            }

            if (bodyoriginToolId != null)
            {
                body["Origin_Tool_Id"] = ExpressionConverter.ConvertO(bodyoriginToolId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["Owner_Id"] = ExpressionConverter.ConvertO(bodyownerId);
                bodypropCount++;
            }

            if (bodyowningGroupId != null)
            {
                body["Owning_Group_Id"] = ExpressionConverter.ConvertO(bodyowningGroupId);
                bodypropCount++;
            }

            if (bodyplannedChangeDateEnd != null)
            {
                body["Planned_Change_Date_End"] = ExpressionConverter.ConvertO(bodyplannedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyplannedChangeDateStart != null)
            {
                body["Planned_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyplannedChangeDateStart);
                bodypropCount++;
            }

            if (bodypmStatusId != null)
            {
                body["Pm_Status_Id"] = ExpressionConverter.ConvertO(bodypmStatusId);
                bodypropCount++;
            }

            if (bodyprojectName != null)
            {
                body["Project_Name"] = ExpressionConverter.ConvertO(bodyprojectName);
                bodypropCount++;
            }

            if (bodyprojectStartDateUt != null)
            {
                body["Project_Start_Date_Ut"] = ExpressionConverter.ConvertO(bodyprojectStartDateUt);
                bodypropCount++;
            }

            if (bodyqty != null)
            {
                body["Qty"] = ExpressionConverter.ConvertO(bodyqty);
                bodypropCount++;
            }

            if (bodyreleaseId != null)
            {
                body["Release_Id"] = ExpressionConverter.ConvertO(bodyreleaseId);
                bodypropCount++;
            }

            if (bodyrentalNetPrice != null)
            {
                body["Rental_Net_Price"] = ExpressionConverter.ConvertO(bodyrentalNetPrice);
                bodypropCount++;
            }

            if (bodyrentalNetPriceCurId != null)
            {
                body["Rental_Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(bodyrentalNetPriceCurId);
                bodypropCount++;
            }

            if (bodyrequestOriginId != null)
            {
                body["Request_Origin_Id"] = ExpressionConverter.ConvertO(bodyrequestOriginId);
                bodypropCount++;
            }

            if (bodyrequestedChangeDateEnd != null)
            {
                body["Requested_Change_Date_End"] = ExpressionConverter.ConvertO(bodyrequestedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyrequestedChangeDateStart != null)
            {
                body["Requested_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyrequestedChangeDateStart);
                bodypropCount++;
            }

            if (bodyrequestorId != null)
            {
                body["Requestor_Id"] = ExpressionConverter.ConvertO(bodyrequestorId);
                bodypropCount++;
            }

            if (bodyrequestorIpAddress != null)
            {
                body["Requestor_Ip_Address"] = ExpressionConverter.ConvertO(bodyrequestorIpAddress);
                bodypropCount++;
            }

            if (bodyrequestorPhone != null)
            {
                body["Requestor_Phone"] = ExpressionConverter.ConvertO(bodyrequestorPhone);
                bodypropCount++;
            }

            if (bodyriskAmount != null)
            {
                body["Risk_Amount"] = ExpressionConverter.ConvertO(bodyriskAmount);
                bodypropCount++;
            }

            if (bodyriskDescription != null)
            {
                body["Risk_Description"] = ExpressionConverter.ConvertO(bodyriskDescription);
                bodypropCount++;
            }

            if (bodyriskLevelId != null)
            {
                body["Risk_Level_Id"] = ExpressionConverter.ConvertO(bodyriskLevelId);
                bodypropCount++;
            }

            if (bodyrootCauseId != null)
            {
                body["Root_Cause_Id"] = ExpressionConverter.ConvertO(bodyrootCauseId);
                bodypropCount++;
            }

            if (bodysubmitDateUt != null)
            {
                body["Submit_Date_Ut"] = ExpressionConverter.ConvertO(bodysubmitDateUt);
                bodypropCount++;
            }

            if (bodytimeUsedToSolveRequest != null)
            {
                body["Time_Used_To_Solve_Request"] = ExpressionConverter.ConvertO(bodytimeUsedToSolveRequest);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/comment", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadAndAttachADocumentToARequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<int> bodydoneById = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/restart", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodydoneById != null)
            {
                body["done_by_id"] = ExpressionConverter.ConvertO(bodydoneById);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RestartRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodydoneById = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/suspend", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodydoneById != null)
            {
                body["done_by_id"] = ExpressionConverter.ConvertO(bodydoneById);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SuspendRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IWorkflowAction CreateTask([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyactionTypeId, [WorkflowExpression] Func<string> bodyelapsedTime = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycontractualCost = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodygroupMail = null, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodystartDateUt = null, [WorkflowExpression] Func<string> bodytimeCost = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/tasks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyelapsedTime != null)
            {
                body["Elapsed_Time"] = ExpressionConverter.ConvertO(bodyelapsedTime);
                bodypropCount++;
            }

            bodypropCount++;
            body["action_type_id"] = ExpressionConverter.ConvertO(bodyactionTypeId);
            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = ExpressionConverter.ConvertO(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["available_field_2"] = ExpressionConverter.ConvertO(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["available_field_3"] = ExpressionConverter.ConvertO(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["available_field_4"] = ExpressionConverter.ConvertO(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["available_field_5"] = ExpressionConverter.ConvertO(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["available_field_6"] = ExpressionConverter.ConvertO(bodyavailableField6);
                bodypropCount++;
            }

            if (bodycontractualCost != null)
            {
                body["contractual_cost"] = ExpressionConverter.ConvertO(bodycontractualCost);
                bodypropCount++;
            }

            if (bodycreationDateUt != null)
            {
                body["creation_date_ut"] = ExpressionConverter.ConvertO(bodycreationDateUt);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyendDateUt != null)
            {
                body["end_date_ut"] = ExpressionConverter.ConvertO(bodyendDateUt);
                bodypropCount++;
            }

            if (bodygroupMail != null)
            {
                body["group_mail"] = ExpressionConverter.ConvertO(bodygroupMail);
                bodypropCount++;
            }

            if (bodygroupName != null)
            {
                body["group_name"] = ExpressionConverter.ConvertO(bodygroupName);
                bodypropCount++;
            }

            if (bodystartDateUt != null)
            {
                body["start_date_ut"] = ExpressionConverter.ConvertO(bodystartDateUt);
                bodypropCount++;
            }

            if (bodytimeCost != null)
            {
                body["time_cost"] = ExpressionConverter.ConvertO(bodytimeCost);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/slas", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
            return new ApiConnectionAction<ViewSlasListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> slaId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/slas/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewSlaResponse>(callPayload);
        }
    }

    public class EasyvistaTriggers([ConnectionName] string connectionId)
    {
    }

    public class FinishActionResponse
    {
        public string HREF { get; set; }
    }

    public class ViewAssetsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAssetsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string ASSETLABEL { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("CATALOG_ASSET")]
        public ViewAssetsListResponseRecordsTypeItemCATALOGASSETType CATALOGASSET { get; set; }
        public ViewAssetsListResponseRecordsTypeItemDEPARTMENTType DEPARTMENT { get; set; }
        public ViewAssetsListResponseRecordsTypeItemEMPLOYEEType EMPLOYEE { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string ENDOFWARANTY { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }
        public string HREF { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string INSTALLATIONDATE { get; set; }
        public ViewAssetsListResponseRecordsTypeItemLOCATIONType LOCATION { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PURCHASEDATE { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SERIALNUMBER { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemCATALOGASSETType
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ARTICLEMODEL { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SMBIOSNAME { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemEMPLOYEEType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewAssetsListResponseRecordsTypeItemLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class CreateAssetResponse
    {
        public string HREF { get; set; }
    }

    public class bodyassetsInputItem
    {
        [JsonProperty("Acquisition_Type_ID")]
        public string AcquisitionTypeID { get; set; }

        [JsonProperty("Asset_Tag")]
        public string AssetTag { get; set; }

        [JsonProperty("Catalog_ID")]
        public int CatalogID { get; set; }

        [JsonProperty("Comment_Asset")]
        public string CommentAsset { get; set; }

        [JsonProperty("Configuration_ID")]
        public string ConfigurationID { get; set; }

        [JsonProperty("Delivery_Date")]
        public string DeliveryDate { get; set; }

        [JsonProperty("Department_Code")]
        public string DepartmentCode { get; set; }

        [JsonProperty("Employee_ID")]
        public string EmployeeID { get; set; }

        [JsonProperty("End_of_Waranty")]
        public string EndOfWaranty { get; set; }

        [JsonProperty("Estimated_Percentage_Use")]
        public string EstimatedPercentageUse { get; set; }

        [JsonProperty("Installation_Date")]
        public string InstallationDate { get; set; }

        [JsonProperty("Location_Code")]
        public string LocationCode { get; set; }

        [JsonProperty("Power_Consumption_WH")]
        public string PowerConsumptionWH { get; set; }

        [JsonProperty("Recycling_Provider_ID")]
        public string RecyclingProviderID { get; set; }

        [JsonProperty("Serial_Number")]
        public string SerialNumber { get; set; }

        [JsonProperty("Status_ID")]
        public int StatusID { get; set; }

        [JsonProperty("Waranty_Type_ID")]
        public string WarantyTypeID { get; set; }
    }

    public class ViewAssetResponse
    {
        [JsonProperty("ACQUISITION_TYPE_ID")]
        public string ACQUISITIONTYPEID { get; set; }

        [JsonProperty("ASSET_GUID")]
        public string ASSETGUID { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string ASSETLABEL { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("AUTOMATIC_RENEWAL")]
        public string AUTOMATICRENEWAL { get; set; }

        [JsonProperty("AVAILABILITY_SLA_ID")]
        public string AVAILABILITYSLAID { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_ID")]
        public string BEFORELOANDEPARTMENTID { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_PATH")]
        public string BEFORELOANDEPARTMENTPATH { get; set; }

        [JsonProperty("BEFORE_LOAN_EMPLOYEE_ID")]
        public string BEFORELOANEMPLOYEEID { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_ID")]
        public string BEFORELOANLOCATIONID { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_PATH")]
        public string BEFORELOANLOCATIONPATH { get; set; }

        [JsonProperty("BILLING_PERIODICITY_IN_MONTH")]
        public string BILLINGPERIODICITYINMONTH { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BUDGETID { get; set; }

        [JsonProperty("BUY_BACK_VALUE")]
        public string BUYBACKVALUE { get; set; }

        [JsonProperty("BUY_BACK_VALUE_CUR_ID")]
        public string BUYBACKVALUECURID { get; set; }

        [JsonProperty("CATALOG_ASSET")]
        public ViewAssetResponseCATALOGASSETType CATALOGASSET { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }

        [JsonProperty("CHARGE_BACK")]
        public string CHARGEBACK { get; set; }

        [JsonProperty("CHARGE_BACK_CUR_ID")]
        public string CHARGEBACKCURID { get; set; }

        [JsonProperty("CI_BACKUP_BY_DEFAULT")]
        public string CIBACKUPBYDEFAULT { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CISTATUSID { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CIVERSION { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_ID")]
        public string CMDEFAULTCHANGEID { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_PATH")]
        public string CMDEFAULTCHANGEPATH { get; set; }

        [JsonProperty("COMMENT_ASSET")]
        public ViewAssetResponseCOMMENTASSETType COMMENTASSET { get; set; }

        [JsonProperty("CONFIGURATION_ID")]
        public string CONFIGURATIONID { get; set; }

        [JsonProperty("CONTRACT_TYPE_ID")]
        public string CONTRACTTYPEID { get; set; }

        [JsonProperty("CRITICAL_LEVEL_ID")]
        public string CRITICALLEVELID { get; set; }

        [JsonProperty("DELIVERY_DATE")]
        public string DELIVERYDATE { get; set; }

        [JsonProperty("DELIVERY_NUMBER")]
        public string DELIVERYNUMBER { get; set; }
        public ViewAssetResponseDEPARTMENTType DEPARTMENT { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPRECIATION_RULE_ID")]
        public string DEPRECIATIONRULEID { get; set; }

        [JsonProperty("D_HARDWARE_GUID")]
        public string DHARDWAREGUID { get; set; }
        public ViewAssetResponseEMPLOYEEType EMPLOYEE { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string ENDOFWARANTY { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string ESTIMATEDPERCENTAGEUSE { get; set; }

        [JsonProperty("EXPECTED_END_LEND_DATE")]
        public string EXPECTEDENDLENDDATE { get; set; }

        [JsonProperty("EXPECTED_RETURN_DATE")]
        public string EXPECTEDRETURNDATE { get; set; }

        [JsonProperty("FALLEN_TERM")]
        public string FALLENTERM { get; set; }

        [JsonProperty("FIXED_ASSET_NUMBER")]
        public string FIXEDASSETNUMBER { get; set; }
        public string HREF { get; set; }

        [JsonProperty("INITIAL_START")]
        public string INITIALSTART { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string INSTALLATIONDATE { get; set; }

        [JsonProperty("INTERNAL_DELIVERY_DATE")]
        public string INTERNALDELIVERYDATE { get; set; }

        [JsonProperty("INTERNAL_DISPO")]
        public string INTERNALDISPO { get; set; }

        [JsonProperty("INVENTORY_ID")]
        public string INVENTORYID { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string INVOICENUMBER { get; set; }

        [JsonProperty("IS_CI")]
        public string ISCI { get; set; }

        [JsonProperty("IS_DML")]
        public string ISDML { get; set; }

        [JsonProperty("IS_LOCKED")]
        public string ISLOCKED { get; set; }

        [JsonProperty("IS_SERVICE")]
        public string ISSERVICE { get; set; }

        [JsonProperty("LAST_AUTOMATIC_DISCOVERY")]
        public string LASTAUTOMATICDISCOVERY { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_PAYMENT")]
        public string LASTPAYMENT { get; set; }

        [JsonProperty("LAST_PAYMENT_CUR_ID")]
        public string LASTPAYMENTCURID { get; set; }

        [JsonProperty("LAST_PHYSICAL_INVENTORY")]
        public string LASTPHYSICALINVENTORY { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LICENSE_VERSION")]
        public string LICENSEVERSION { get; set; }
        public ViewAssetResponseLOCATIONType LOCATION { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LOCATIONTOCHECKREQUESTID { get; set; }

        [JsonProperty("MAINTENANCE_COST")]
        public string MAINTENANCECOST { get; set; }

        [JsonProperty("MAINTENANCE_COST_CUR_ID")]
        public string MAINTENANCECOSTCURID { get; set; }

        [JsonProperty("MAIN_USAGE_ID")]
        public string MAINUSAGEID { get; set; }

        [JsonProperty("MAX_INSTALLS")]
        public string MAXINSTALLS { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST")]
        public string MONTHLYFIXEDCOST { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST_CUR_ID")]
        public string MONTHLYFIXEDCOSTCURID { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MONTHLYNETRENTAL { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MONTHLYNETRENTALCURID { get; set; }

        [JsonProperty("MONTH_DURATION")]
        public string MONTHDURATION { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NETWORKIDENTIFIER { get; set; }

        [JsonProperty("NEXT_CI_VERSION")]
        public string NEXTCIVERSION { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_ID")]
        public string NEXTDEPARTMENTID { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_PATH")]
        public string NEXTDEPARTMENTPATH { get; set; }

        [JsonProperty("NEXT_MAINTENANCE_DATE")]
        public string NEXTMAINTENANCEDATE { get; set; }

        [JsonProperty("NEXT_STATUS_ID")]
        public string NEXTSTATUSID { get; set; }

        [JsonProperty("NEXT_USER_APPLICATION_DATE")]
        public string NEXTUSERAPPLICATIONDATE { get; set; }

        [JsonProperty("NEXT_USER_ID")]
        public string NEXTUSERID { get; set; }
        public string NOTICE { get; set; }

        [JsonProperty("ORDER_DETAILS_ID")]
        public string ORDERDETAILSID { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public string ORDERNUMBER { get; set; }

        [JsonProperty("OWNERSHIP_TO_CHECK_REQUEST_ID")]
        public string OWNERSHIPTOCHECKREQUESTID { get; set; }

        [JsonProperty("PACKAGE_PATH")]
        public string PACKAGEPATH { get; set; }

        [JsonProperty("PIPELINE_STATUS_ID")]
        public string PIPELINESTATUSID { get; set; }

        [JsonProperty("POWER_CONSUMPTION_WH")]
        public string POWERCONSUMPTIONWH { get; set; }

        [JsonProperty("PROCESSOR_COUNT")]
        public string PROCESSORCOUNT { get; set; }

        [JsonProperty("PROCESSOR_SOCKET_COUNT")]
        public string PROCESSORSOCKETCOUNT { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string PROJECTID { get; set; }

        [JsonProperty("PROVIDER_ID")]
        public string PROVIDERID { get; set; }

        [JsonProperty("PROVIDER_PATH")]
        public string PROVIDERPATH { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PURCHASEDATE { get; set; }

        [JsonProperty("PURCHASE_PRICE")]
        public string PURCHASEPRICE { get; set; }

        [JsonProperty("PURCHASE_PRICE_CUR_ID")]
        public string PURCHASEPRICECURID { get; set; }

        [JsonProperty("PURCHASE_RATE_ID")]
        public string PURCHASERATEID { get; set; }

        [JsonProperty("RECYCLED_DATE")]
        public string RECYCLEDDATE { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_ID")]
        public string RECYCLINGPROVIDERID { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_PATH")]
        public string RECYCLINGPROVIDERPATH { get; set; }

        [JsonProperty("REFORM_NUMBER")]
        public string REFORMNUMBER { get; set; }

        [JsonProperty("REMOVED_DATE")]
        public string REMOVEDDATE { get; set; }

        [JsonProperty("RENEWAL_DECISION_ID")]
        public string RENEWALDECISIONID { get; set; }

        [JsonProperty("RENEWAL_VALUE")]
        public string RENEWALVALUE { get; set; }

        [JsonProperty("RENEWAL_VALUE_CUR_ID")]
        public string RENEWALVALUECURID { get; set; }

        [JsonProperty("REPAIRED_BY_ID")]
        public string REPAIREDBYID { get; set; }

        [JsonProperty("REPAIRED_BY_PATH")]
        public string REPAIREDBYPATH { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RESALES_VALUE")]
        public string RESALESVALUE { get; set; }

        [JsonProperty("SCHEDULED_END")]
        public string SCHEDULEDEND { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_ID")]
        public string SDDEFAULTINCIDENTID { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_PATH")]
        public string SDDEFAULTINCIDENTPATH { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_ID")]
        public string SDDEFAULTREQUESTID { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_PATH")]
        public string SDDEFAULTREQUESTPATH { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SERIALNUMBER { get; set; }

        [JsonProperty("SERVER_TYPE_ID")]
        public string SERVERTYPEID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SUPPLIERID { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SUPPLIERPATH { get; set; }
        public string TERM { get; set; }

        [JsonProperty("UPDATED_BY_DISCOVERY")]
        public string UPDATEDBYDISCOVERY { get; set; }

        [JsonProperty("UPDATE_COVERAGE_TERM")]
        public string UPDATECOVERAGETERM { get; set; }

        [JsonProperty("WARANTY_TYPE_ID")]
        public string WARANTYTYPEID { get; set; }
        public string XPOS { get; set; }
        public string YPOS { get; set; }
        public string ZPOS { get; set; }
    }

    public class ViewAssetResponseCATALOGASSETType
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ARTICLEMODEL { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SMBIOSNAME { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewAssetResponseCOMMENTASSETType
    {
        public string HREF { get; set; }
    }

    public class ViewAssetResponseDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
    }

    public class ViewAssetResponseEMPLOYEEType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewAssetResponseLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class UpdateAssetResponse
    {
        public string HREF { get; set; }
    }

    public class ViewAssetLinksResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAssetLinksResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewAssetLinksResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("CONTRACT_ROW")]
        public string CONTRACTROW { get; set; }
        public string HREF { get; set; }

        [JsonProperty("MONTHLY_PAYMENT")]
        public string MONTHLYPAYMENT { get; set; }

        [JsonProperty("PARENT_ASSET_ID")]
        public string PARENTASSETID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }
    }

    public class CreateAssetLinkResponse
    {
        public string HREF { get; set; }
    }

    public class UpdateAssetLinkResponse
    {
        public string HREF { get; set; }
    }

    public class ViewAssetLinkResponse
    {
        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("CONTRACT_ROW")]
        public string CONTRACTROW { get; set; }
        public string HREF { get; set; }

        [JsonProperty("MONTHLY_PAYMENT")]
        public string MONTHLYPAYMENT { get; set; }

        [JsonProperty("PARENT_ASSET_ID")]
        public string PARENTASSETID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }
    }

    public class ViewCatalogAssetsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogAssetsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogAssetsListResponseRecordsTypeItem
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ARTICLEMODEL { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }
        public string HREF { get; set; }
        public ViewCatalogAssetsListResponseRecordsTypeItemMANUFACTURERType MANUFACTURER { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SMBIOSNAME { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewCatalogAssetsListResponseRecordsTypeItemMANUFACTURERType
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DISCOVERYNAME { get; set; }
        public string HREF { get; set; }
        public string MANUFACTURER { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string MANUFACTURERID { get; set; }
    }

    public class ViewCatalogAssetResponse
    {
        [JsonProperty("ARTICLE_MODEL")]
        public string ARTICLEMODEL { get; set; }

        [JsonProperty("ARTICLE_MODEL_URL")]
        public string ARTICLEMODELURL { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("CAN_BE_PURCHASED")]
        public string CANBEPURCHASED { get; set; }

        [JsonProperty("CATALOG_GUID")]
        public string CATALOGGUID { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }

        [JsonProperty("CURRENT_LICENSE_VERSION")]
        public string CURRENTLICENSEVERSION { get; set; }

        [JsonProperty("DEFAULT_BUY_BACK_VALUE")]
        public string DEFAULTBUYBACKVALUE { get; set; }

        [JsonProperty("DEFAULT_BUY_BACK_VALUE_CUR_ID")]
        public string DEFAULTBUYBACKVALUECURID { get; set; }

        [JsonProperty("DEFAULT_CHARGE_BACK")]
        public string DEFAULTCHARGEBACK { get; set; }

        [JsonProperty("DEFAULT_CHARGE_BACK_CUR_ID")]
        public string DEFAULTCHARGEBACKCURID { get; set; }

        [JsonProperty("DEFAULT_DISPOSAL_VALUE")]
        public string DEFAULTDISPOSALVALUE { get; set; }

        [JsonProperty("DEFAULT_DISPOSAL_VALUE_CUR_ID")]
        public string DEFAULTDISPOSALVALUECURID { get; set; }

        [JsonProperty("DEFAULT_RENEWAL_VALUE")]
        public string DEFAULTRENEWALVALUE { get; set; }

        [JsonProperty("DEFAULT_RENEWAL_VALUE_CUR_ID")]
        public string DEFAULTRENEWALVALUECURID { get; set; }

        [JsonProperty("DESCRIPTION_EN")]
        public ViewCatalogAssetResponseDESCRIPTIONENType DESCRIPTIONEN { get; set; }

        [JsonProperty("DESCRIPTION_FR")]
        public ViewCatalogAssetResponseDESCRIPTIONFRType DESCRIPTIONFR { get; set; }

        [JsonProperty("DESCRIPTION_GE")]
        public ViewCatalogAssetResponseDESCRIPTIONGEType DESCRIPTIONGE { get; set; }

        [JsonProperty("DESCRIPTION_IT")]
        public ViewCatalogAssetResponseDESCRIPTIONITType DESCRIPTIONIT { get; set; }

        [JsonProperty("DESCRIPTION_L1")]
        public ViewCatalogAssetResponseDESCRIPTIONL1Type DESCRIPTIONL1 { get; set; }

        [JsonProperty("DESCRIPTION_L2")]
        public ViewCatalogAssetResponseDESCRIPTIONL2Type DESCRIPTIONL2 { get; set; }

        [JsonProperty("DESCRIPTION_L3")]
        public ViewCatalogAssetResponseDESCRIPTIONL3Type DESCRIPTIONL3 { get; set; }

        [JsonProperty("DESCRIPTION_L4")]
        public ViewCatalogAssetResponseDESCRIPTIONL4Type DESCRIPTIONL4 { get; set; }

        [JsonProperty("DESCRIPTION_L5")]
        public ViewCatalogAssetResponseDESCRIPTIONL5Type DESCRIPTIONL5 { get; set; }

        [JsonProperty("DESCRIPTION_L6")]
        public ViewCatalogAssetResponseDESCRIPTIONL6Type DESCRIPTIONL6 { get; set; }

        [JsonProperty("DESCRIPTION_PO")]
        public ViewCatalogAssetResponseDESCRIPTIONPOType DESCRIPTIONPO { get; set; }

        [JsonProperty("DESCRIPTION_SP")]
        public ViewCatalogAssetResponseDESCRIPTIONSPType DESCRIPTIONSP { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("END_OF_NEWS")]
        public string ENDOFNEWS { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string ESTIMATEDPERCENTAGEUSE { get; set; }

        [JsonProperty("ESTIMATED_POWER_CONSUMPTION_WH")]
        public string ESTIMATEDPOWERCONSUMPTIONWH { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("INITIAL_STOCK")]
        public string INITIALSTOCK { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LEVEL_VERSION")]
        public string LEVELVERSION { get; set; }

        [JsonProperty("LICENSE_PRICE_PER_SEAT")]
        public string LICENSEPRICEPERSEAT { get; set; }

        [JsonProperty("LICENSE_PRICE_PER_SEAT_CUR_ID")]
        public string LICENSEPRICEPERSEATCURID { get; set; }

        [JsonProperty("LICENSE_PROGRAM")]
        public string LICENSEPROGRAM { get; set; }

        [JsonProperty("MAINTENANCE_DURATION")]
        public string MAINTENANCEDURATION { get; set; }

        [JsonProperty("MANAGED_LICENSE")]
        public string MANAGEDLICENSE { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string MANAGERID { get; set; }
        public ViewCatalogAssetResponseMANUFACTURERType MANUFACTURER { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string MANUFACTURERID { get; set; }

        [JsonProperty("MANUFACTURER_REF")]
        public string MANUFACTURERREF { get; set; }

        [JsonProperty("MANUFACTURER_WARRANTY_DURATION")]
        public string MANUFACTURERWARRANTYDURATION { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MONTHLYNETRENTAL { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MONTHLYNETRENTALCURID { get; set; }

        [JsonProperty("NB_INSTALLS")]
        public string NBINSTALLS { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NETPRICECURID { get; set; }

        [JsonProperty("PERCENT_MAINTENANCE_COST")]
        public string PERCENTMAINTENANCECOST { get; set; }

        [JsonProperty("QTY_PACKAGED")]
        public string QTYPACKAGED { get; set; }

        [JsonProperty("REF_GLPI")]
        public string REFGLPI { get; set; }

        [JsonProperty("REF_LANDESK")]
        public string REFLANDESK { get; set; }

        [JsonProperty("REF_SCCM")]
        public string REFSCCM { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("SMBIOS_NAME")]
        public string SMBIOSNAME { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }

        [JsonProperty("TAX_ID")]
        public string TAXID { get; set; }

        [JsonProperty("TECHNICAL_VALIDATION_REQUIRED")]
        public string TECHNICALVALIDATIONREQUIRED { get; set; }

        [JsonProperty("TITLE_EN")]
        public string TITLEEN { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }

        [JsonProperty("TITLE_GE")]
        public string TITLEGE { get; set; }

        [JsonProperty("TITLE_IT")]
        public string TITLEIT { get; set; }

        [JsonProperty("TITLE_L1")]
        public string TITLEL1 { get; set; }

        [JsonProperty("TITLE_L2")]
        public string TITLEL2 { get; set; }

        [JsonProperty("TITLE_L3")]
        public string TITLEL3 { get; set; }

        [JsonProperty("TITLE_L4")]
        public string TITLEL4 { get; set; }

        [JsonProperty("TITLE_L5")]
        public string TITLEL5 { get; set; }

        [JsonProperty("TITLE_L6")]
        public string TITLEL6 { get; set; }

        [JsonProperty("TITLE_PO")]
        public string TITLEPO { get; set; }

        [JsonProperty("TITLE_SP")]
        public string TITLESP { get; set; }

        [JsonProperty("YEARS_EXPECTED_USAGE")]
        public string YEARSEXPECTEDUSAGE { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONENType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONFRType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONGEType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONITType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL1Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL2Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL3Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL4Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL5Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONL6Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONPOType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseDESCRIPTIONSPType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogAssetResponseMANUFACTURERType
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DISCOVERYNAME { get; set; }
        public string HREF { get; set; }
        public string MANUFACTURER { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string MANUFACTURERID { get; set; }
    }

    public class ViewCatalogRequestsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogRequestsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItem
    {
        [JsonProperty("CATALOG_REQUESTS_PATH")]
        public ViewCatalogRequestsListResponseRecordsTypeItemCATALOGREQUESTSPATHType CATALOGREQUESTSPATH { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }
        public string CODE { get; set; }
        public string HREF { get; set; }
        public ViewCatalogRequestsListResponseRecordsTypeItemMANAGERType MANAGER { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }
        public ViewCatalogRequestsListResponseRecordsTypeItemSLAType SLA { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemCATALOGREQUESTSPATHType
    {
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SDCATALOGPATHFR { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemMANAGERType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewCatalogRequestsListResponseRecordsTypeItemSLAType
    {
        public string DELAY { get; set; }

        [JsonProperty("NAME_FR")]
        public string NAMEFR { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }
    }

    public class ViewCatalogRequestsPathListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewCatalogRequestsPathListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewCatalogRequestsPathListResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SDCATALOGPATHFR { get; set; }
    }

    public class ViewCatalogRequestPathResponse
    {
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH_EN")]
        public string SDCATALOGPATHEN { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SDCATALOGPATHFR { get; set; }

        [JsonProperty("SD_CATALOG_PATH_GE")]
        public string SDCATALOGPATHGE { get; set; }

        [JsonProperty("SD_CATALOG_PATH_IT")]
        public string SDCATALOGPATHIT { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L1")]
        public string SDCATALOGPATHL1 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L2")]
        public string SDCATALOGPATHL2 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L3")]
        public string SDCATALOGPATHL3 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L4")]
        public string SDCATALOGPATHL4 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L5")]
        public string SDCATALOGPATHL5 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_L6")]
        public string SDCATALOGPATHL6 { get; set; }

        [JsonProperty("SD_CATALOG_PATH_PO")]
        public string SDCATALOGPATHPO { get; set; }

        [JsonProperty("SD_CATALOG_PATH_SP")]
        public string SDCATALOGPATHSP { get; set; }
    }

    public class ViewCatalogRequestResponse
    {
        [JsonProperty("ALLOW_GROUP_CHANGE")]
        public string ALLOWGROUPCHANGE { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("CANNOT_BE_ORDERED")]
        public string CANNOTBEORDERED { get; set; }

        [JsonProperty("CAN_BE_PURCHASED")]
        public string CANBEPURCHASED { get; set; }

        [JsonProperty("CATALOG_GUID")]
        public string CATALOGGUID { get; set; }

        [JsonProperty("CATALOG_REQUESTS_PATH")]
        public ViewCatalogRequestResponseCATALOGREQUESTSPATHType CATALOGREQUESTSPATH { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }

        [JsonProperty("CI_MANDATORY")]
        public string CIMANDATORY { get; set; }
        public string CODE { get; set; }

        [JsonProperty("COMMENT_CATALOG")]
        public ViewCatalogRequestResponseCOMMENTCATALOGType COMMENTCATALOG { get; set; }

        [JsonProperty("DEFAULT_REQUEST_BO")]
        public string DEFAULTREQUESTBO { get; set; }

        [JsonProperty("DEFAULT_REQUEST_FO")]
        public string DEFAULTREQUESTFO { get; set; }

        [JsonProperty("DEFAULT_REQUEST_TA")]
        public string DEFAULTREQUESTTA { get; set; }

        [JsonProperty("DEFAULT_URGENCY_ID")]
        public string DEFAULTURGENCYID { get; set; }

        [JsonProperty("DESCRIPTION_EN")]
        public ViewCatalogRequestResponseDESCRIPTIONENType DESCRIPTIONEN { get; set; }

        [JsonProperty("DESCRIPTION_FR")]
        public ViewCatalogRequestResponseDESCRIPTIONFRType DESCRIPTIONFR { get; set; }

        [JsonProperty("DESCRIPTION_GE")]
        public ViewCatalogRequestResponseDESCRIPTIONGEType DESCRIPTIONGE { get; set; }

        [JsonProperty("DESCRIPTION_IT")]
        public ViewCatalogRequestResponseDESCRIPTIONITType DESCRIPTIONIT { get; set; }

        [JsonProperty("DESCRIPTION_L1")]
        public ViewCatalogRequestResponseDESCRIPTIONL1Type DESCRIPTIONL1 { get; set; }

        [JsonProperty("DESCRIPTION_L2")]
        public ViewCatalogRequestResponseDESCRIPTIONL2Type DESCRIPTIONL2 { get; set; }

        [JsonProperty("DESCRIPTION_L3")]
        public ViewCatalogRequestResponseDESCRIPTIONL3Type DESCRIPTIONL3 { get; set; }

        [JsonProperty("DESCRIPTION_L4")]
        public ViewCatalogRequestResponseDESCRIPTIONL4Type DESCRIPTIONL4 { get; set; }

        [JsonProperty("DESCRIPTION_L5")]
        public ViewCatalogRequestResponseDESCRIPTIONL5Type DESCRIPTIONL5 { get; set; }

        [JsonProperty("DESCRIPTION_L6")]
        public ViewCatalogRequestResponseDESCRIPTIONL6Type DESCRIPTIONL6 { get; set; }

        [JsonProperty("DESCRIPTION_PO")]
        public ViewCatalogRequestResponseDESCRIPTIONPOType DESCRIPTIONPO { get; set; }

        [JsonProperty("DESCRIPTION_SP")]
        public ViewCatalogRequestResponseDESCRIPTIONSPType DESCRIPTIONSP { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("END_OF_NEWS")]
        public string ENDOFNEWS { get; set; }

        [JsonProperty("GROUP_ID")]
        public string GROUPID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }
        public ViewCatalogRequestResponseMANAGERType MANAGER { get; set; }

        [JsonProperty("MAX_CALLS")]
        public string MAXCALLS { get; set; }

        [JsonProperty("MAX_QTY")]
        public string MAXQTY { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MONTHLYNETRENTAL { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MONTHLYNETRENTALCURID { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NETPRICECURID { get; set; }

        [JsonProperty("PACKAGE_NAME")]
        public string PACKAGENAME { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }
        public ViewCatalogRequestResponseSLAType SLA { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }

        [JsonProperty("TITLE_EN")]
        public string TITLEEN { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }

        [JsonProperty("TITLE_GE")]
        public string TITLEGE { get; set; }

        [JsonProperty("TITLE_IT")]
        public string TITLEIT { get; set; }

        [JsonProperty("TITLE_L1")]
        public string TITLEL1 { get; set; }

        [JsonProperty("TITLE_L2")]
        public string TITLEL2 { get; set; }

        [JsonProperty("TITLE_L3")]
        public string TITLEL3 { get; set; }

        [JsonProperty("TITLE_L4")]
        public string TITLEL4 { get; set; }

        [JsonProperty("TITLE_L5")]
        public string TITLEL5 { get; set; }

        [JsonProperty("TITLE_L6")]
        public string TITLEL6 { get; set; }

        [JsonProperty("TITLE_PO")]
        public string TITLEPO { get; set; }

        [JsonProperty("TITLE_SP")]
        public string TITLESP { get; set; }

        [JsonProperty("TITLE_URL")]
        public string TITLEURL { get; set; }
    }

    public class ViewCatalogRequestResponseCATALOGREQUESTSPATHType
    {
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH_FR")]
        public string SDCATALOGPATHFR { get; set; }
    }

    public class ViewCatalogRequestResponseCOMMENTCATALOGType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONENType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONFRType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONGEType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONITType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL1Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL2Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL3Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL4Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL5Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONL6Type
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONPOType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseDESCRIPTIONSPType
    {
        public string HREF { get; set; }
    }

    public class ViewCatalogRequestResponseMANAGERType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewCatalogRequestResponseSLAType
    {
        public string DELAY { get; set; }

        [JsonProperty("NAME_FR")]
        public string NAMEFR { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }
    }

    public class ViewConfigurationItemsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewConfigurationItemsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewConfigurationItemsListResponseRecordsTypeItem
    {
        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CISTATUSID { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CIVERSION { get; set; }
        public string HREF { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NETWORKIDENTIFIER { get; set; }
    }

    public class ViewConfigurationItemResponse
    {
        [JsonProperty("ACQUISITION_TYPE_ID")]
        public string ACQUISITIONTYPEID { get; set; }

        [JsonProperty("ASSET_GUID")]
        public string ASSETGUID { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string ASSETLABEL { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("AUTOMATIC_RENEWAL")]
        public string AUTOMATICRENEWAL { get; set; }

        [JsonProperty("AVAILABILITY_SLA_ID")]
        public string AVAILABILITYSLAID { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_ID")]
        public string BEFORELOANDEPARTMENTID { get; set; }

        [JsonProperty("BEFORE_LOAN_DEPARTMENT_PATH")]
        public string BEFORELOANDEPARTMENTPATH { get; set; }

        [JsonProperty("BEFORE_LOAN_EMPLOYEE_ID")]
        public string BEFORELOANEMPLOYEEID { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_ID")]
        public string BEFORELOANLOCATIONID { get; set; }

        [JsonProperty("BEFORE_LOAN_LOCATION_PATH")]
        public string BEFORELOANLOCATIONPATH { get; set; }

        [JsonProperty("BILLING_PERIODICITY_IN_MONTH")]
        public string BILLINGPERIODICITYINMONTH { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BUDGETID { get; set; }

        [JsonProperty("BUY_BACK_VALUE")]
        public string BUYBACKVALUE { get; set; }

        [JsonProperty("BUY_BACK_VALUE_CUR_ID")]
        public string BUYBACKVALUECURID { get; set; }

        [JsonProperty("CATALOG_ID")]
        public string CATALOGID { get; set; }

        [JsonProperty("CHARGE_BACK")]
        public string CHARGEBACK { get; set; }

        [JsonProperty("CHARGE_BACK_CUR_ID")]
        public string CHARGEBACKCURID { get; set; }

        [JsonProperty("CI_BACKUP_BY_DEFAULT")]
        public string CIBACKUPBYDEFAULT { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public string CISTATUSID { get; set; }

        [JsonProperty("CI_VERSION")]
        public string CIVERSION { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_ID")]
        public string CMDEFAULTCHANGEID { get; set; }

        [JsonProperty("CM_DEFAULT_CHANGE_PATH")]
        public string CMDEFAULTCHANGEPATH { get; set; }

        [JsonProperty("COMMENT_ASSET")]
        public ViewConfigurationItemResponseCOMMENTASSETType COMMENTASSET { get; set; }

        [JsonProperty("CONFIGURATION_ID")]
        public string CONFIGURATIONID { get; set; }

        [JsonProperty("CONTRACT_TYPE_ID")]
        public string CONTRACTTYPEID { get; set; }

        [JsonProperty("CRITICAL_LEVEL_ID")]
        public string CRITICALLEVELID { get; set; }

        [JsonProperty("DELIVERY_DATE")]
        public string DELIVERYDATE { get; set; }

        [JsonProperty("DELIVERY_NUMBER")]
        public string DELIVERYNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPRECIATION_RULE_ID")]
        public string DEPRECIATIONRULEID { get; set; }

        [JsonProperty("D_HARDWARE_GUID")]
        public string DHARDWAREGUID { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string ENDOFWARANTY { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("ESTIMATED_PERCENTAGE_USE")]
        public string ESTIMATEDPERCENTAGEUSE { get; set; }

        [JsonProperty("EXPECTED_END_LEND_DATE")]
        public string EXPECTEDENDLENDDATE { get; set; }

        [JsonProperty("EXPECTED_RETURN_DATE")]
        public string EXPECTEDRETURNDATE { get; set; }

        [JsonProperty("FALLEN_TERM")]
        public string FALLENTERM { get; set; }

        [JsonProperty("FIXED_ASSET_NUMBER")]
        public string FIXEDASSETNUMBER { get; set; }
        public string HREF { get; set; }

        [JsonProperty("INITIAL_START")]
        public string INITIALSTART { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string INSTALLATIONDATE { get; set; }

        [JsonProperty("INTERNAL_DELIVERY_DATE")]
        public string INTERNALDELIVERYDATE { get; set; }

        [JsonProperty("INTERNAL_DISPO")]
        public string INTERNALDISPO { get; set; }

        [JsonProperty("INVENTORY_ID")]
        public string INVENTORYID { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string INVOICENUMBER { get; set; }

        [JsonProperty("IS_CI")]
        public string ISCI { get; set; }

        [JsonProperty("IS_DML")]
        public string ISDML { get; set; }

        [JsonProperty("IS_LOCKED")]
        public string ISLOCKED { get; set; }

        [JsonProperty("IS_SERVICE")]
        public string ISSERVICE { get; set; }

        [JsonProperty("LAST_AUTOMATIC_DISCOVERY")]
        public string LASTAUTOMATICDISCOVERY { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_PAYMENT")]
        public string LASTPAYMENT { get; set; }

        [JsonProperty("LAST_PAYMENT_CUR_ID")]
        public string LASTPAYMENTCURID { get; set; }

        [JsonProperty("LAST_PHYSICAL_INVENTORY")]
        public string LASTPHYSICALINVENTORY { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LICENSE_VERSION")]
        public string LICENSEVERSION { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LOCATIONTOCHECKREQUESTID { get; set; }

        [JsonProperty("MAINTENANCE_COST")]
        public string MAINTENANCECOST { get; set; }

        [JsonProperty("MAINTENANCE_COST_CUR_ID")]
        public string MAINTENANCECOSTCURID { get; set; }

        [JsonProperty("MAIN_USAGE_ID")]
        public string MAINUSAGEID { get; set; }

        [JsonProperty("MAX_INSTALLS")]
        public string MAXINSTALLS { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST")]
        public string MONTHLYFIXEDCOST { get; set; }

        [JsonProperty("MONTHLY_FIXED_COST_CUR_ID")]
        public string MONTHLYFIXEDCOSTCURID { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL")]
        public string MONTHLYNETRENTAL { get; set; }

        [JsonProperty("MONTHLY_NET_RENTAL_CUR_ID")]
        public string MONTHLYNETRENTALCURID { get; set; }

        [JsonProperty("MONTH_DURATION")]
        public string MONTHDURATION { get; set; }

        [JsonProperty("NETWORK_IDENTIFIER")]
        public string NETWORKIDENTIFIER { get; set; }

        [JsonProperty("NEXT_CI_VERSION")]
        public string NEXTCIVERSION { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_ID")]
        public string NEXTDEPARTMENTID { get; set; }

        [JsonProperty("NEXT_DEPARTMENT_PATH")]
        public string NEXTDEPARTMENTPATH { get; set; }

        [JsonProperty("NEXT_MAINTENANCE_DATE")]
        public string NEXTMAINTENANCEDATE { get; set; }

        [JsonProperty("NEXT_STATUS_ID")]
        public string NEXTSTATUSID { get; set; }

        [JsonProperty("NEXT_USER_APPLICATION_DATE")]
        public string NEXTUSERAPPLICATIONDATE { get; set; }

        [JsonProperty("NEXT_USER_ID")]
        public string NEXTUSERID { get; set; }
        public string NOTICE { get; set; }

        [JsonProperty("ORDER_DETAILS_ID")]
        public string ORDERDETAILSID { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public string ORDERNUMBER { get; set; }

        [JsonProperty("OWNERSHIP_TO_CHECK_REQUEST_ID")]
        public string OWNERSHIPTOCHECKREQUESTID { get; set; }

        [JsonProperty("PACKAGE_PATH")]
        public string PACKAGEPATH { get; set; }

        [JsonProperty("PIPELINE_STATUS_ID")]
        public string PIPELINESTATUSID { get; set; }

        [JsonProperty("POWER_CONSUMPTION_WH")]
        public string POWERCONSUMPTIONWH { get; set; }

        [JsonProperty("PROCESSOR_COUNT")]
        public string PROCESSORCOUNT { get; set; }

        [JsonProperty("PROCESSOR_SOCKET_COUNT")]
        public string PROCESSORSOCKETCOUNT { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string PROJECTID { get; set; }

        [JsonProperty("PROVIDER_ID")]
        public string PROVIDERID { get; set; }

        [JsonProperty("PROVIDER_PATH")]
        public string PROVIDERPATH { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PURCHASEDATE { get; set; }

        [JsonProperty("PURCHASE_PRICE")]
        public string PURCHASEPRICE { get; set; }

        [JsonProperty("PURCHASE_PRICE_CUR_ID")]
        public string PURCHASEPRICECURID { get; set; }

        [JsonProperty("PURCHASE_RATE_ID")]
        public string PURCHASERATEID { get; set; }

        [JsonProperty("RECYCLED_DATE")]
        public string RECYCLEDDATE { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_ID")]
        public string RECYCLINGPROVIDERID { get; set; }

        [JsonProperty("RECYCLING_PROVIDER_PATH")]
        public string RECYCLINGPROVIDERPATH { get; set; }

        [JsonProperty("REFORM_NUMBER")]
        public string REFORMNUMBER { get; set; }

        [JsonProperty("REMOVED_DATE")]
        public string REMOVEDDATE { get; set; }

        [JsonProperty("RENEWAL_DECISION_ID")]
        public string RENEWALDECISIONID { get; set; }

        [JsonProperty("RENEWAL_VALUE")]
        public string RENEWALVALUE { get; set; }

        [JsonProperty("RENEWAL_VALUE_CUR_ID")]
        public string RENEWALVALUECURID { get; set; }

        [JsonProperty("REPAIRED_BY_ID")]
        public string REPAIREDBYID { get; set; }

        [JsonProperty("REPAIRED_BY_PATH")]
        public string REPAIREDBYPATH { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RESALES_VALUE")]
        public string RESALESVALUE { get; set; }

        [JsonProperty("SCHEDULED_END")]
        public string SCHEDULEDEND { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_ID")]
        public string SDDEFAULTINCIDENTID { get; set; }

        [JsonProperty("SD_DEFAULT_INCIDENT_PATH")]
        public string SDDEFAULTINCIDENTPATH { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_ID")]
        public string SDDEFAULTREQUESTID { get; set; }

        [JsonProperty("SD_DEFAULT_REQUEST_PATH")]
        public string SDDEFAULTREQUESTPATH { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SERIALNUMBER { get; set; }

        [JsonProperty("SERVER_TYPE_ID")]
        public string SERVERTYPEID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SUPPLIERID { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SUPPLIERPATH { get; set; }
        public string TERM { get; set; }

        [JsonProperty("UPDATED_BY_DISCOVERY")]
        public string UPDATEDBYDISCOVERY { get; set; }

        [JsonProperty("UPDATE_COVERAGE_TERM")]
        public string UPDATECOVERAGETERM { get; set; }

        [JsonProperty("WARANTY_TYPE_ID")]
        public string WARANTYTYPEID { get; set; }
        public string XPOS { get; set; }
        public string YPOS { get; set; }
        public string ZPOS { get; set; }
    }

    public class ViewConfigurationItemResponseCOMMENTASSETType
    {
        public string HREF { get; set; }
    }

    public class ViewConfigurationItemLinksResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewConfigurationItemLinksResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewConfigurationItemLinksResponseRecordsTypeItem
    {
        public string BLOCKING { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string CHILDCIID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string PARENTCIID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewConfigurationItemLinksResponseRecordsTypeItemRELATIONTYPEType RELATIONTYPE { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RELATIONTYPEID { get; set; }
    }

    public class ViewConfigurationItemLinksResponseRecordsTypeItemRELATIONTYPEType
    {
        [JsonProperty("REFERENCE_FR")]
        public string REFERENCEFR { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string REFERENCEID { get; set; }
    }

    public class ViewConfigurationItemLinkResponse
    {
        public string BLOCKING { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string CHILDCIID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string PARENTCIID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewConfigurationItemLinkResponseRELATIONTYPEType RELATIONTYPE { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RELATIONTYPEID { get; set; }
    }

    public class ViewConfigurationItemLinkResponseRELATIONTYPEType
    {
        [JsonProperty("REFERENCE_FR")]
        public string REFERENCEFR { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string REFERENCEID { get; set; }
    }

    public class CreateConfigurationItemLinkResponse
    {
        public string HREF { get; set; }
    }

    public class UpdateConfigurationItemLinkResponse
    {
        public string HREF { get; set; }
    }

    public class ViewEntitiesListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewEntitiesListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewEntitiesListResponseRecordsTypeItem
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public string HREF { get; set; }
    }

    public class ViewEntityResponse
    {
        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("COMMENT_DEPARTMENT")]
        public ViewEntityResponseCOMMENTDEPARTMENTType COMMENTDEPARTMENT { get; set; }

        [JsonProperty("CURRENCY_ID")]
        public string CURRENCYID { get; set; }

        [JsonProperty("DEFAULT_COST_CENTER_ID")]
        public string DEFAULTCOSTCENTERID { get; set; }

        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_EN")]
        public string DEPARTMENTEN { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_GE")]
        public string DEPARTMENTGE { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_IT")]
        public string DEPARTMENTIT { get; set; }

        [JsonProperty("DEPARTMENT_L1")]
        public string DEPARTMENTL1 { get; set; }

        [JsonProperty("DEPARTMENT_L2")]
        public string DEPARTMENTL2 { get; set; }

        [JsonProperty("DEPARTMENT_L3")]
        public string DEPARTMENTL3 { get; set; }

        [JsonProperty("DEPARTMENT_L4")]
        public string DEPARTMENTL4 { get; set; }

        [JsonProperty("DEPARTMENT_L5")]
        public string DEPARTMENTL5 { get; set; }

        [JsonProperty("DEPARTMENT_L6")]
        public string DEPARTMENTL6 { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_PO")]
        public string DEPARTMENTPO { get; set; }

        [JsonProperty("DEPARTMENT_SP")]
        public string DEPARTMENTSP { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }
        public string LEVEL { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string MANAGERID { get; set; }

        [JsonProperty("PARENT_DEPARTMENT_ID")]
        public string PARENTDEPARTMENTID { get; set; }

        [JsonProperty("PARENT_DEPARTMENT_PATH")]
        public string PARENTDEPARTMENTPATH { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }

        [JsonProperty("URL_MAP")]
        public string URLMAP { get; set; }
    }

    public class ViewEntityResponseCOMMENTDEPARTMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewEmployeesListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewEmployeesListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItem
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }
        public ViewEmployeesListResponseRecordsTypeItemDEPARTMENTType DEPARTMENT { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }
        public ViewEmployeesListResponseRecordsTypeItemLOCATIONType LOCATION { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
        public ViewEmployeesListResponseRecordsTypeItemMANAGERType MANAGER { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public string HREF { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class ViewEmployeesListResponseRecordsTypeItemMANAGERType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class CreateEmployeeResponse
    {
        public string HREF { get; set; }
    }

    public class bodyemployeesInputItem
    {
        [JsonProperty("Begin_of_Contract")]
        public string BeginOfContract { get; set; }

        [JsonProperty("Comment_Employee")]
        public string CommentEmployee { get; set; }

        [JsonProperty("E_mail")]
        public string EMail { get; set; }

        [JsonProperty("Last_Name")]
        public string LastName { get; set; }
        public string Login { get; set; }

        [JsonProperty("Phone_Number")]
        public string PhoneNumber { get; set; }
    }

    public class ViewEmployeeResponse
    {
        [JsonProperty("APPROVED_TO_VALIDATE")]
        public string APPROVEDTOVALIDATE { get; set; }

        [JsonProperty("AVAILABILITY_STATUS_ID")]
        public string AVAILABILITYSTATUSID { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("CHAT_LOGIN")]
        public string CHATLOGIN { get; set; }

        [JsonProperty("CIVIL_STATUS_ID")]
        public string CIVILSTATUSID { get; set; }

        [JsonProperty("COMMENT_EMPLOYEE")]
        public ViewEmployeeResponseCOMMENTEMPLOYEEType COMMENTEMPLOYEE { get; set; }

        [JsonProperty("COST_PER_HOUR")]
        public string COSTPERHOUR { get; set; }

        [JsonProperty("COST_PER_HOUR_CUR_ID")]
        public string COSTPERHOURCURID { get; set; }

        [JsonProperty("DEFAULT_COST_CENTER_ID")]
        public string DEFAULTCOSTCENTERID { get; set; }

        [JsonProperty("DELEGATION_FROM")]
        public string DELEGATIONFROM { get; set; }

        [JsonProperty("DELEGATION_ID")]
        public string DELEGATIONID { get; set; }

        [JsonProperty("DELEGATION_TO")]
        public string DELEGATIONTO { get; set; }
        public ViewEmployeeResponseDEPARTMENTType DEPARTMENT { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("END_OF_CONTRACT")]
        public string ENDOFCONTRACT { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("E_PTO")]
        public string EPTO { get; set; }

        [JsonProperty("E_SANDBOX_USER")]
        public string ESANDBOXUSER { get; set; }

        [JsonProperty("FAX_NUMBER")]
        public string FAXNUMBER { get; set; }

        [JsonProperty("FUNCTION_ID")]
        public string FUNCTIONID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("ICQ_NUMBER")]
        public string ICQNUMBER { get; set; }
        public string IDENTIFICATION { get; set; }
        public string IMPACT { get; set; }

        [JsonProperty("IS_AUTOMATIC_STATUS")]
        public string ISAUTOMATICSTATUS { get; set; }

        [JsonProperty("IS_SYSTEM")]
        public string ISSYSTEM { get; set; }

        [JsonProperty("IT_CORRESPONDENT")]
        public string ITCORRESPONDENT { get; set; }

        [JsonProperty("LANGUAGE_ID")]
        public string LANGUAGEID { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }
        public ViewEmployeeResponseLOCATIONType LOCATION { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_TO_CHECK_REQUEST_ID")]
        public string LOCATIONTOCHECKREQUESTID { get; set; }
        public string LOGIN { get; set; }

        [JsonProperty("MAIL_ALERT")]
        public string MAILALERT { get; set; }
        public ViewEmployeeResponseMANAGERType MANAGER { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string MANAGERID { get; set; }

        [JsonProperty("MESSENGER_SIGN_NAME")]
        public string MESSENGERSIGNNAME { get; set; }

        [JsonProperty("NOTIFICATION_TYPE_ID")]
        public string NOTIFICATIONTYPEID { get; set; }

        [JsonProperty("PASSWD_LAST_UPDATE_UT")]
        public string PASSWDLASTUPDATEUT { get; set; }

        [JsonProperty("PERSON_IN_CHARGE")]
        public string PERSONINCHARGE { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }

        [JsonProperty("PICTURE_PATH")]
        public string PICTUREPATH { get; set; }

        [JsonProperty("PLANNING_ID")]
        public string PLANNINGID { get; set; }

        [JsonProperty("STYLE_ID")]
        public string STYLEID { get; set; }

        [JsonProperty("SUPPLIER_ID")]
        public string SUPPLIERID { get; set; }

        [JsonProperty("SUPPLIER_PATH")]
        public string SUPPLIERPATH { get; set; }

        [JsonProperty("TITLE_ID")]
        public string TITLEID { get; set; }

        [JsonProperty("TRIAL_END")]
        public string TRIALEND { get; set; }

        [JsonProperty("VALIDATION_LEVEL")]
        public string VALIDATIONLEVEL { get; set; }

        [JsonProperty("VALIDATOR_ID")]
        public string VALIDATORID { get; set; }
        public string VIP { get; set; }

        [JsonProperty("VIP_LEVEL_ID")]
        public string VIPLEVELID { get; set; }

        [JsonProperty("WAVE_ADDRESS")]
        public string WAVEADDRESS { get; set; }
    }

    public class ViewEmployeeResponseCOMMENTEMPLOYEEType
    {
        public string HREF { get; set; }
    }

    public class ViewEmployeeResponseDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public string HREF { get; set; }
    }

    public class ViewEmployeeResponseLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class ViewEmployeeResponseMANAGERType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class UpdateEmployeeResponse
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewKnownErrorsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewKnownErrorsListResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KNOWNPROBLEMPATH { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KPNUMBER { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }
    }

    public class ViewKnownErrorsResponse
    {
        [JsonProperty("ANSWER_EN")]
        public ViewKnownErrorsResponseANSWERENType ANSWEREN { get; set; }

        [JsonProperty("ANSWER_FR")]
        public ViewKnownErrorsResponseANSWERFRType ANSWERFR { get; set; }

        [JsonProperty("ANSWER_GE")]
        public ViewKnownErrorsResponseANSWERGEType ANSWERGE { get; set; }

        [JsonProperty("ANSWER_IT")]
        public ViewKnownErrorsResponseANSWERITType ANSWERIT { get; set; }

        [JsonProperty("ANSWER_L1")]
        public ViewKnownErrorsResponseANSWERL1Type ANSWERL1 { get; set; }

        [JsonProperty("ANSWER_L2")]
        public ViewKnownErrorsResponseANSWERL2Type ANSWERL2 { get; set; }

        [JsonProperty("ANSWER_L3")]
        public ViewKnownErrorsResponseANSWERL3Type ANSWERL3 { get; set; }

        [JsonProperty("ANSWER_L4")]
        public ViewKnownErrorsResponseANSWERL4Type ANSWERL4 { get; set; }

        [JsonProperty("ANSWER_L5")]
        public ViewKnownErrorsResponseANSWERL5Type ANSWERL5 { get; set; }

        [JsonProperty("ANSWER_L6")]
        public ViewKnownErrorsResponseANSWERL6Type ANSWERL6 { get; set; }

        [JsonProperty("ANSWER_PO")]
        public ViewKnownErrorsResponseANSWERPOType ANSWERPO { get; set; }

        [JsonProperty("ANSWER_SP")]
        public ViewKnownErrorsResponseANSWERSPType ANSWERSP { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("EXPECTED_RESOLUTION_DATE")]
        public string EXPECTEDRESOLUTIONDATE { get; set; }

        [JsonProperty("E_URL")]
        public ViewKnownErrorsResponseEURLType EURL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IMPLEMENTATION_TIME")]
        public string IMPLEMENTATIONTIME { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KNOWNPROBLEMPATH { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KPNUMBER { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LAST_UPDATE_UT")]
        public string LASTUPDATEUT { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_IT")]
        public string QUESTIONIT { get; set; }

        [JsonProperty("QUESTION_L1")]
        public string QUESTIONL1 { get; set; }

        [JsonProperty("QUESTION_L2")]
        public string QUESTIONL2 { get; set; }

        [JsonProperty("QUESTION_L3")]
        public string QUESTIONL3 { get; set; }

        [JsonProperty("QUESTION_L4")]
        public string QUESTIONL4 { get; set; }

        [JsonProperty("QUESTION_L5")]
        public string QUESTIONL5 { get; set; }

        [JsonProperty("QUESTION_L6")]
        public string QUESTIONL6 { get; set; }

        [JsonProperty("QUESTION_PO")]
        public string QUESTIONPO { get; set; }

        [JsonProperty("QUESTION_SP")]
        public string QUESTIONSP { get; set; }

        [JsonProperty("REVISION_DATE")]
        public string REVISIONDATE { get; set; }

        [JsonProperty("REVISION_DATE_UT")]
        public string REVISIONDATEUT { get; set; }
        public string VERSION { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERENType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERFRType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERGEType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERITType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL1Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL2Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL3Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL4Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL5Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERL6Type
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERPOType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseANSWERSPType
    {
        public string HREF { get; set; }
    }

    public class ViewKnownErrorsResponseEURLType
    {
        public string HREF { get; set; }
    }

    public class ViewLocationsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewLocationsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewLocationsListResponseRecordsTypeItem
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class ViewLocationResponse
    {
        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }
        public string CITY { get; set; }

        [JsonProperty("COMMENT_LOCATION")]
        public ViewLocationResponseCOMMENTLOCATIONType COMMENTLOCATION { get; set; }

        [JsonProperty("COUNTRY_ID")]
        public string COUNTRYID { get; set; }

        [JsonProperty("DISCOVERY_NAME")]
        public string DISCOVERYNAME { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("E_CAPACITY")]
        public string ECAPACITY { get; set; }

        [JsonProperty("E_IS_MEETING_ROOM")]
        public string EISMEETINGROOM { get; set; }

        [JsonProperty("E_WIFI_LOGIN")]
        public string EWIFILOGIN { get; set; }
        public string FAX { get; set; }

        [JsonProperty("G_MAP_LAT")]
        public string GMAPLAT { get; set; }

        [JsonProperty("G_MAP_LNG")]
        public string GMAPLNG { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IS_DELIVERY_ADDRESS")]
        public string ISDELIVERYADDRESS { get; set; }

        [JsonProperty("LAST_INTEGRATION")]
        public string LASTINTEGRATION { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }
        public string LEVEL { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_EN")]
        public string LOCATIONEN { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_GE")]
        public string LOCATIONGE { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_IT")]
        public string LOCATIONIT { get; set; }

        [JsonProperty("LOCATION_L1")]
        public string LOCATIONL1 { get; set; }

        [JsonProperty("LOCATION_L2")]
        public string LOCATIONL2 { get; set; }

        [JsonProperty("LOCATION_L3")]
        public string LOCATIONL3 { get; set; }

        [JsonProperty("LOCATION_L4")]
        public string LOCATIONL4 { get; set; }

        [JsonProperty("LOCATION_L5")]
        public string LOCATIONL5 { get; set; }

        [JsonProperty("LOCATION_L6")]
        public string LOCATIONL6 { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_PO")]
        public string LOCATIONPO { get; set; }

        [JsonProperty("LOCATION_SP")]
        public string LOCATIONSP { get; set; }

        [JsonProperty("MANAGER_ID")]
        public string MANAGERID { get; set; }

        [JsonProperty("PARENT_LOCATION_ID")]
        public string PARENTLOCATIONID { get; set; }

        [JsonProperty("PARENT_LOCATION_PATH")]
        public string PARENTLOCATIONPATH { get; set; }
        public string PHONE { get; set; }

        [JsonProperty("REGION_ZONE_ID")]
        public string REGIONZONEID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }

        [JsonProperty("STATE_ID")]
        public string STATEID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("STREET_ADDRESS_1")]
        public string STREETADDRESS1 { get; set; }

        [JsonProperty("STREET_ADDRESS_2")]
        public string STREETADDRESS2 { get; set; }

        [JsonProperty("TIME_ZONE_ID")]
        public string TIMEZONEID { get; set; }

        [JsonProperty("URL_MAP")]
        public string URLMAP { get; set; }

        [JsonProperty("ZIP_CODE")]
        public string ZIPCODE { get; set; }
    }

    public class ViewLocationResponseCOMMENTLOCATIONType
    {
        public string HREF { get; set; }
    }

    public class ViewManufacturerListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewManufacturerListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewManufacturerListResponseRecordsTypeItem
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DISCOVERYNAME { get; set; }
        public string HREF { get; set; }
        public string MANUFACTURER { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string MANUFACTURERID { get; set; }
    }

    public class ViewManufacturerResponse
    {
        [JsonProperty("DISCOVERY_NAME")]
        public string DISCOVERYNAME { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IS_MANUFACTURER")]
        public string ISMANUFACTURER { get; set; }

        [JsonProperty("IS_PUBLISHER")]
        public string ISPUBLISHER { get; set; }
        public string MANUFACTURER { get; set; }

        [JsonProperty("MANUFACTURER_ID")]
        public string MANUFACTURERID { get; set; }

        [JsonProperty("WEB_SITE")]
        public string WEBSITE { get; set; }
    }

    public class ViewRequestsIncidentsListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewRequestsIncidentsListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItem
    {
        [JsonProperty("CATALOG_REQUEST")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemCATALOGREQUESTType CATALOGREQUEST { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemCOMMENTType COMMENT { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemDEPARTMENTType DEPARTMENT { get; set; }
        public string HREF { get; set; }

        [JsonProperty("KNOWN_PROBLEM")]
        public ViewRequestsIncidentsListResponseRecordsTypeItemKNOWNPROBLEMType KNOWNPROBLEM { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemLOCATIONType LOCATION { get; set; }

        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemRECIPIENTType RECIPIENT { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemREQUESTORType REQUESTOR { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }
        public ViewRequestsIncidentsListResponseRecordsTypeItemSTATUSType STATUS { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemCATALOGREQUESTType
    {
        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }
        public string CODE { get; set; }
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public string HREF { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemKNOWNPROBLEMType
    {
        public string HREF { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KNOWNPROBLEMPATH { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KPNUMBER { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemRECIPIENTType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemREQUESTORType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewRequestsIncidentsListResponseRecordsTypeItemSTATUSType
    {
        public string HREF { get; set; }

        [JsonProperty("STATUS_FR")]
        public string STATUSFR { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string STATUSGUID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }
    }

    public class CreateRequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class bodyrequestsInputItem
    {
        [JsonProperty("Asset_ID")]
        public string AssetID { get; set; }

        [JsonProperty("Asset_Label")]
        public string AssetLabel { get; set; }

        [JsonProperty("Asset_Tag")]
        public string AssetTag { get; set; }

        [JsonProperty("CI_Asset_Tag")]
        public string CIAssetTag { get; set; }

        [JsonProperty("CI_ID")]
        public string CIID { get; set; }

        [JsonProperty("CI_Name")]
        public string CIName { get; set; }

        [JsonProperty("Catalog_Code")]
        public string CatalogCode { get; set; }

        [JsonProperty("Department_Code")]
        public string DepartmentCode { get; set; }

        [JsonProperty("Department_ID")]
        public string DepartmentID { get; set; }
        public string Description { get; set; }

        [JsonProperty("External_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("Location_Code")]
        public string LocationCode { get; set; }

        [JsonProperty("Location_ID")]
        public string LocationID { get; set; }
        public string Origin { get; set; }
        public string ParentRequest { get; set; }
        public string Phone { get; set; }

        [JsonProperty("Recipient_ID")]
        public string RecipientID { get; set; }

        [JsonProperty("Recipient_Identification")]
        public string RecipientIdentification { get; set; }

        [JsonProperty("Recipient_Mail")]
        public string RecipientMail { get; set; }

        [JsonProperty("Recipient_Name")]
        public string RecipientName { get; set; }

        [JsonProperty("Requestor_Identification")]
        public string RequestorIdentification { get; set; }

        [JsonProperty("Requestor_Mail")]
        public string RequestorMail { get; set; }

        [JsonProperty("Requestor_Name")]
        public string RequestorName { get; set; }

        [JsonProperty("Severity_ID")]
        public string SeverityID { get; set; }

        [JsonProperty("Urgency_ID")]
        public string UrgencyID { get; set; }
    }

    public class ViewRequestIncidentResponse
    {
        [JsonProperty("ANALYTICAL_CHARGE_ID")]
        public string ANALYTICALCHARGEID { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_PATH")]
        public string ANALYTICALCHARGEPATH { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("AVAILABLE_FIELD_1")]
        public string AVAILABLEFIELD1 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_2")]
        public string AVAILABLEFIELD2 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_3")]
        public string AVAILABLEFIELD3 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_4")]
        public string AVAILABLEFIELD4 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_5")]
        public string AVAILABLEFIELD5 { get; set; }

        [JsonProperty("AVAILABLE_FIELD_6")]
        public string AVAILABLEFIELD6 { get; set; }

        [JsonProperty("BUDGET_EFFECTIVE")]
        public string BUDGETEFFECTIVE { get; set; }

        [JsonProperty("BUDGET_ID")]
        public string BUDGETID { get; set; }

        [JsonProperty("BUDGET_PLANNED")]
        public string BUDGETPLANNED { get; set; }

        [JsonProperty("CAN_BE_DUPLICATED")]
        public string CANBEDUPLICATED { get; set; }

        [JsonProperty("CATALOG_REQUEST")]
        public ViewRequestIncidentResponseCATALOGREQUESTType CATALOGREQUEST { get; set; }

        [JsonProperty("CI_ID")]
        public string CIID { get; set; }

        [JsonProperty("CLICK_2_GET_INSTALL_RESULT")]
        public string CLICK2GETINSTALLRESULT { get; set; }
        public ViewRequestIncidentResponseCOMMENTType COMMENT { get; set; }

        [JsonProperty("CONTINUITY_PLAN_ID")]
        public string CONTINUITYPLANID { get; set; }

        [JsonProperty("COST_CENTER_ID")]
        public string COSTCENTERID { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CREATIONDATEUT { get; set; }
        public string DELAY { get; set; }
        public ViewRequestIncidentResponseDEPARTMENTType DEPARTMENT { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public ViewRequestIncidentResponseDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DYNAMIC_DETAILS")]
        public ViewRequestIncidentResponseDYNAMICDETAILSType DYNAMICDETAILS { get; set; }

        [JsonProperty("EFFECTIVE_CHANGE_DATE_END")]
        public string EFFECTIVECHANGEDATEEND { get; set; }

        [JsonProperty("EFFECTIVE_CHANGE_DATE_START")]
        public string EFFECTIVECHANGEDATESTART { get; set; }

        [JsonProperty("END_DATE_UT")]
        public string ENDDATEUT { get; set; }

        [JsonProperty("ESTIMATED_NET_PRICE")]
        public string ESTIMATEDNETPRICE { get; set; }

        [JsonProperty("ESTIMATED_PERCENT_COMPLETE")]
        public string ESTIMATEDPERCENTCOMPLETE { get; set; }

        [JsonProperty("EXPECTED_DATE_UT")]
        public string EXPECTEDDATEUT { get; set; }

        [JsonProperty("EXPECTED_DURATION")]
        public string EXPECTEDDURATION { get; set; }

        [JsonProperty("EXPECTED_END_DATE_UT")]
        public string EXPECTEDENDDATEUT { get; set; }

        [JsonProperty("EXPECTED_START_DATE_UT")]
        public string EXPECTEDSTARTDATEUT { get; set; }

        [JsonProperty("EXTERNAL_REFERENCE")]
        public string EXTERNALREFERENCE { get; set; }

        [JsonProperty("FIRST_CALL_RESOLUTION")]
        public string FIRSTCALLRESOLUTION { get; set; }

        [JsonProperty("HOUR_PER_DAY")]
        public string HOURPERDAY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("IMPUTATION_DATE")]
        public string IMPUTATIONDATE { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_ID")]
        public string INITIALSDCATALOGID { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_PATH")]
        public string INITIALSDCATALOGPATH { get; set; }

        [JsonProperty("IS_FINANCIAL_COMPTED")]
        public string ISFINANCIALCOMPTED { get; set; }

        [JsonProperty("IS_MAJOR_INCIDENT")]
        public string ISMAJORINCIDENT { get; set; }

        [JsonProperty("IS_TEMPLATE")]
        public string ISTEMPLATE { get; set; }

        [JsonProperty("KBASE_ID")]
        public string KBASEID { get; set; }

        [JsonProperty("KNOWN_PROBLEM")]
        public ViewRequestIncidentResponseKNOWNPROBLEMType KNOWNPROBLEM { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_PATH")]
        public string KNOWNPROBLEMSPATH { get; set; }

        [JsonProperty("LAST_DONE_BY_ID")]
        public string LASTDONEBYID { get; set; }

        [JsonProperty("LAST_GROUP_ID")]
        public string LASTGROUPID { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }
        public ViewRequestIncidentResponseLOCATIONType LOCATION { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("MARK_1")]
        public string MARK1 { get; set; }

        [JsonProperty("MARK_2")]
        public string MARK2 { get; set; }

        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("MS_PROJECT_IMPORT_VALIDATION_WAITING")]
        public string MSPROJECTIMPORTVALIDATIONWAITING { get; set; }

        [JsonProperty("NET_PRICE")]
        public string NETPRICE { get; set; }

        [JsonProperty("NET_PRICE_CUR_ID")]
        public string NETPRICECURID { get; set; }

        [JsonProperty("NEWS_ID")]
        public string NEWSID { get; set; }

        [JsonProperty("NOT_DEDUCED_CALL")]
        public string NOTDEDUCEDCALL { get; set; }

        [JsonProperty("ORDER_ID")]
        public string ORDERID { get; set; }

        [JsonProperty("ORDER_NET_PRICE")]
        public string ORDERNETPRICE { get; set; }

        [JsonProperty("ORIGIN_TOOL_ID")]
        public string ORIGINTOOLID { get; set; }

        [JsonProperty("OWNER_ID")]
        public string OWNERID { get; set; }

        [JsonProperty("OWNING_GROUP_ID")]
        public string OWNINGGROUPID { get; set; }

        [JsonProperty("PARENT_REQUEST_ID")]
        public string PARENTREQUESTID { get; set; }

        [JsonProperty("PLANNED_CHANGE_DATE_END")]
        public string PLANNEDCHANGEDATEEND { get; set; }

        [JsonProperty("PLANNED_CHANGE_DATE_START")]
        public string PLANNEDCHANGEDATESTART { get; set; }

        [JsonProperty("PM_STATUS_ID")]
        public string PMSTATUSID { get; set; }

        [JsonProperty("PROJECT_ID")]
        public string PROJECTID { get; set; }

        [JsonProperty("PROJECT_NAME")]
        public string PROJECTNAME { get; set; }

        [JsonProperty("PROJECT_START_DATE_UT")]
        public string PROJECTSTARTDATEUT { get; set; }
        public string QTY { get; set; }
        public ViewRequestIncidentResponseRECIPIENTType RECIPIENT { get; set; }

        [JsonProperty("RECIPIENT_ID")]
        public string RECIPIENTID { get; set; }

        [JsonProperty("RELEASE_ID")]
        public string RELEASEID { get; set; }

        [JsonProperty("RENTAL_NET_PRICE")]
        public string RENTALNETPRICE { get; set; }

        [JsonProperty("RENTAL_NET_PRICE_CUR_ID")]
        public string RENTALNETPRICECURID { get; set; }

        [JsonProperty("REQUALIFICATION_PROCESSING")]
        public string REQUALIFICATIONPROCESSING { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_END")]
        public string REQUESTEDCHANGEDATEEND { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_START")]
        public string REQUESTEDCHANGEDATESTART { get; set; }
        public ViewRequestIncidentResponseREQUESTORType REQUESTOR { get; set; }

        [JsonProperty("REQUESTOR_FEEDBACK")]
        public string REQUESTORFEEDBACK { get; set; }

        [JsonProperty("REQUESTOR_ID")]
        public string REQUESTORID { get; set; }

        [JsonProperty("REQUESTOR_IP_ADDRESS")]
        public string REQUESTORIPADDRESS { get; set; }

        [JsonProperty("REQUESTOR_PHONE")]
        public string REQUESTORPHONE { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("REQUEST_ORIGIN_ID")]
        public string REQUESTORIGINID { get; set; }

        [JsonProperty("REQUEST_PROJECT_ID")]
        public string REQUESTPROJECTID { get; set; }

        [JsonProperty("REQUIRED_DOWNTIME")]
        public string REQUIREDDOWNTIME { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("RISK_AMOUNT")]
        public string RISKAMOUNT { get; set; }

        [JsonProperty("RISK_DESCRIPTION")]
        public ViewRequestIncidentResponseRISKDESCRIPTIONType RISKDESCRIPTION { get; set; }

        [JsonProperty("RISK_LEVEL_ID")]
        public string RISKLEVELID { get; set; }

        [JsonProperty("ROOT_CAUSE_ID")]
        public string ROOTCAUSEID { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SEVERITY_ID")]
        public string SEVERITYID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }
        public ViewRequestIncidentResponseSTATUSType STATUS { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUBMITTED_BY")]
        public string SUBMITTEDBY { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }

        [JsonProperty("SYSTEM_ID")]
        public string SYSTEMID { get; set; }

        [JsonProperty("TIME_USED_TO_DELIVER_FEEDBACK")]
        public string TIMEUSEDTODELIVERFEEDBACK { get; set; }

        [JsonProperty("TIME_USED_TO_SOLVE_REQUEST")]
        public string TIMEUSEDTOSOLVEREQUEST { get; set; }

        [JsonProperty("URGENCY_ID")]
        public string URGENCYID { get; set; }

        [JsonProperty("VALIDATION_LEVEL_REQUIRED")]
        public string VALIDATIONLEVELREQUIRED { get; set; }

        [JsonProperty("WAVE_ID_TARGET")]
        public string WAVEIDTARGET { get; set; }
    }

    public class ViewRequestIncidentResponseCATALOGREQUESTType
    {
        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }
        public string CODE { get; set; }
        public string HREF { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewRequestIncidentResponseCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentResponseDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentResponseDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentResponseDYNAMICDETAILSType
    {
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentResponseKNOWNPROBLEMType
    {
        public string HREF { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("KNOWN_PROBLEM_PATH")]
        public string KNOWNPROBLEMPATH { get; set; }

        [JsonProperty("KP_NUMBER")]
        public string KPNUMBER { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }
    }

    public class ViewRequestIncidentResponseLOCATIONType
    {
        public string CITY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
    }

    public class ViewRequestIncidentResponseRECIPIENTType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewRequestIncidentResponseREQUESTORType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewRequestIncidentResponseRISKDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentResponseSTATUSType
    {
        public string HREF { get; set; }

        [JsonProperty("STATUS_FR")]
        public string STATUSFR { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string STATUSGUID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }
    }

    public class CloseRequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class bodyclosedInputItem
    {
        [JsonProperty("catalog_GUID")]
        public string CatalogGUID { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("delete_actions")]
        public int DeleteActions { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_GUID")]
        public string StatusGUID { get; set; }
    }

    public class UpdateRequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class ViewRequestIncidentCommentResponse
    {
        public string COMMENT { get; set; }
        public string HREF { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }
    }

    public class GetRequestIncidentDocumentListResponse
    {
        public JToken[] Documents { get; set; }
        public string HREF { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }
    }

    public class UploadAndAttachADocumentToARequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("filedata")]
        public string Filedata { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class RestartRequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class SuspendRequestIncidentResponse
    {
        public string HREF { get; set; }
    }

    public class ViewSlasListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("records")]
        public ViewSlasListResponseRecordsTypeItem[] Records { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }
    }

    public class ViewSlasListResponseRecordsTypeItem
    {
        public string DELAY { get; set; }
        public string HREF { get; set; }

        [JsonProperty("NAME_FR")]
        public string NAMEFR { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }
    }

    public class ViewSlaResponse
    {
        public string DELAY { get; set; }

        [JsonProperty("HOLIDAY_LIST_ID")]
        public string HOLIDAYLISTID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("NAME_EN")]
        public string NAMEEN { get; set; }

        [JsonProperty("NAME_FR")]
        public string NAMEFR { get; set; }

        [JsonProperty("NAME_GE")]
        public string NAMEGE { get; set; }

        [JsonProperty("NAME_IT")]
        public string NAMEIT { get; set; }

        [JsonProperty("NAME_L1")]
        public string NAMEL1 { get; set; }

        [JsonProperty("NAME_L2")]
        public string NAMEL2 { get; set; }

        [JsonProperty("NAME_L3")]
        public string NAMEL3 { get; set; }

        [JsonProperty("NAME_L4")]
        public string NAMEL4 { get; set; }

        [JsonProperty("NAME_L5")]
        public string NAMEL5 { get; set; }

        [JsonProperty("NAME_L6")]
        public string NAMEL6 { get; set; }

        [JsonProperty("NAME_PO")]
        public string NAMEPO { get; set; }

        [JsonProperty("NAME_SP")]
        public string NAMESP { get; set; }

        [JsonProperty("NEXT_BUSINESS_DAY")]
        public string NEXTBUSINESSDAY { get; set; }

        [JsonProperty("SLA_GUID")]
        public string SLAGUID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("TIME_LIMIT")]
        public string TIMELIMIT { get; set; }

        [JsonProperty("TIME_TARGET")]
        public string TIMETARGET { get; set; }

        [JsonProperty("WORKING_HOURS_ID")]
        public string WORKINGHOURSID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyvista;

    public partial class WorkflowManagedActions
    {
        public EasyvistaActions Easyvista(string connectionId) => new EasyvistaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyvistaTriggers Easyvista(string connectionId) => new EasyvistaTriggers(connectionId);
    }
}