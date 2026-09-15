//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvistaservicemana
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyvistaservicemanaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<FinishActionResponse> FinishAction(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyendActiondescription = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var endActionObject = new JObject();
            var endActionObjectpropCount = 0;
            if (bodyendActiondescription != null)
            {
                endActionObject["Description"] = CSharpExpressionConverter.ConvertToken(bodyendActiondescription);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewAssetsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset(Expression<Func<string>> account, Expression<Func<bodyassetsInputItem[]>> bodyassets = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassets != null)
            {
                body["assets"] = CSharpExpressionConverter.ConvertToken(bodyassets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> bodybEFORELOANDEPARTMENTID = null, Expression<Func<string>> bodybEFORELOANEMPLOYEEID = null, Expression<Func<string>> bodybEFORELOANLOCATIONID = null, Expression<Func<string>> bodybILLINGPERIODICITYINMONTH = null, Expression<Func<string>> bodybUYBACKVALUE = null, Expression<Func<string>> bodybUYBACKVALUECURID = null, Expression<Func<string>> bodycATALOGID = null, Expression<Func<string>> bodycHARGEBACK = null, Expression<Func<string>> bodycHARGEBACKCURID = null, Expression<Func<string>> bodycISTATUSID = null, Expression<Func<string>> bodycIVERSION = null, Expression<Func<string>> bodycMDEFAULTCHANGEID = null, Expression<Func<string>> bodycONFIGURATIONID = null, Expression<Func<string>> bodycRITICALLEVELID = null, Expression<Func<string>> bodydELIVERYDATE = null, Expression<Func<string>> bodydELIVERYNUMBER = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodydEPRECIATIONRULEID = null, Expression<Func<string>> bodydHARDWAREGUID = null, Expression<Func<string>> bodyeMPLOYEEID = null, Expression<Func<string>> bodyeNDOFWARANTY = null, Expression<Func<string>> bodyeNTRYDATE = null, Expression<Func<string>> bodyeSTIMATEDPERCENTAGEUSE = null, Expression<Func<string>> bodyeXPECTEDENDLENDDATE = null, Expression<Func<string>> bodyeXPECTEDRETURNDATE = null, Expression<Func<string>> bodyfALLENTERM = null, Expression<Func<string>> bodyfIXEDASSETNUMBER = null, Expression<Func<string>> bodyiNITIALSTART = null, Expression<Func<string>> bodyiNSTALLATIONDATE = null, Expression<Func<string>> bodyiNTERNALDELIVERYDATE = null, Expression<Func<string>> bodyiNVOICENUMBER = null, Expression<Func<string>> bodyiSDML = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTPHYSICALINVENTORY = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylICENSEVERSION = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodymAINTENANCECOST = null, Expression<Func<string>> bodymAINTENANCECOSTCURID = null, Expression<Func<string>> bodymAINUSAGEID = null, Expression<Func<string>> bodymAXINSTALLS = null, Expression<Func<string>> bodymONTHLYFIXEDCOST = null, Expression<Func<string>> bodymONTHLYFIXEDCOSTCURID = null, Expression<Func<string>> bodymONTHLYNETRENTAL = null, Expression<Func<string>> bodymONTHLYNETRENTALCURID = null, Expression<Func<string>> bodymONTHDURATION = null, Expression<Func<string>> bodynETWORKIDENTIFIER = null, Expression<Func<string>> bodynEXTDEPARTMENTID = null, Expression<Func<string>> bodynEXTMAINTENANCEDATE = null, Expression<Func<string>> bodynEXTSTATUSID = null, Expression<Func<string>> bodynEXTUSERAPPLICATIONDATE = null, Expression<Func<string>> bodynEXTUSERID = null, Expression<Func<string>> bodynOTICE = null, Expression<Func<string>> bodyoRDERDETAILSID = null, Expression<Func<string>> bodyoRDERNUMBER = null, Expression<Func<string>> bodypIPELINESTATUSID = null, Expression<Func<string>> bodypOWERCONSUMPTIONWH = null, Expression<Func<string>> bodypROCESSORCOUNT = null, Expression<Func<string>> bodypROCESSORSOCKETCOUNT = null, Expression<Func<string>> bodypURCHASEDATE = null, Expression<Func<string>> bodypURCHASEPRICE = null, Expression<Func<string>> bodypURCHASEPRICECURID = null, Expression<Func<string>> bodypURCHASERATEID = null, Expression<Func<string>> bodyrECYCLEDDATE = null, Expression<Func<string>> bodyrECYCLINGPROVIDERID = null, Expression<Func<string>> bodyrEFORMNUMBER = null, Expression<Func<string>> bodyrEMOVEDDATE = null, Expression<Func<string>> bodyrENEWALDECISIONID = null, Expression<Func<string>> bodyrENEWALVALUE = null, Expression<Func<string>> bodyrENEWALVALUECURID = null, Expression<Func<string>> bodyrEPAIREDBYID = null, Expression<Func<string>> bodyrESALESVALUE = null, Expression<Func<string>> bodysCHEDULEDEND = null, Expression<Func<string>> bodysDCATALOGID = null, Expression<Func<string>> bodysERIALNUMBER = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodysTATUSID = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodytERM = null, Expression<Func<string>> bodyuPDATECOVERAGETERM = null, Expression<Func<string>> bodywARANTYTYPEID = null, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyavailabilitySlaId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybEFORELOANDEPARTMENTID != null)
            {
                body["BEFORE_LOAN_DEPARTMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodybEFORELOANDEPARTMENTID);
                bodypropCount++;
            }

            if (bodybEFORELOANEMPLOYEEID != null)
            {
                body["BEFORE_LOAN_EMPLOYEE_ID"] = CSharpExpressionConverter.ConvertToken(bodybEFORELOANEMPLOYEEID);
                bodypropCount++;
            }

            if (bodybEFORELOANLOCATIONID != null)
            {
                body["BEFORE_LOAN_LOCATION_ID"] = CSharpExpressionConverter.ConvertToken(bodybEFORELOANLOCATIONID);
                bodypropCount++;
            }

            if (bodybILLINGPERIODICITYINMONTH != null)
            {
                body["BILLING_PERIODICITY_IN_MONTH"] = CSharpExpressionConverter.ConvertToken(bodybILLINGPERIODICITYINMONTH);
                bodypropCount++;
            }

            if (bodybUYBACKVALUE != null)
            {
                body["BUY_BACK_VALUE"] = CSharpExpressionConverter.ConvertToken(bodybUYBACKVALUE);
                bodypropCount++;
            }

            if (bodybUYBACKVALUECURID != null)
            {
                body["BUY_BACK_VALUE_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodybUYBACKVALUECURID);
                bodypropCount++;
            }

            if (bodycATALOGID != null)
            {
                body["CATALOG_ID"] = CSharpExpressionConverter.ConvertToken(bodycATALOGID);
                bodypropCount++;
            }

            if (bodycHARGEBACK != null)
            {
                body["CHARGE_BACK"] = CSharpExpressionConverter.ConvertToken(bodycHARGEBACK);
                bodypropCount++;
            }

            if (bodycHARGEBACKCURID != null)
            {
                body["CHARGE_BACK_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodycHARGEBACKCURID);
                bodypropCount++;
            }

            if (bodycISTATUSID != null)
            {
                body["CI_STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodycISTATUSID);
                bodypropCount++;
            }

            if (bodycIVERSION != null)
            {
                body["CI_VERSION"] = CSharpExpressionConverter.ConvertToken(bodycIVERSION);
                bodypropCount++;
            }

            if (bodycMDEFAULTCHANGEID != null)
            {
                body["CM_DEFAULT_CHANGE_ID"] = CSharpExpressionConverter.ConvertToken(bodycMDEFAULTCHANGEID);
                bodypropCount++;
            }

            if (bodycONFIGURATIONID != null)
            {
                body["CONFIGURATION_ID"] = CSharpExpressionConverter.ConvertToken(bodycONFIGURATIONID);
                bodypropCount++;
            }

            if (bodycRITICALLEVELID != null)
            {
                body["CRITICAL_LEVEL_ID"] = CSharpExpressionConverter.ConvertToken(bodycRITICALLEVELID);
                bodypropCount++;
            }

            if (bodydELIVERYDATE != null)
            {
                body["DELIVERY_DATE"] = CSharpExpressionConverter.ConvertToken(bodydELIVERYDATE);
                bodypropCount++;
            }

            if (bodydELIVERYNUMBER != null)
            {
                body["DELIVERY_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodydELIVERYNUMBER);
                bodypropCount++;
            }

            if (bodydEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTID);
                bodypropCount++;
            }

            if (bodydEPRECIATIONRULEID != null)
            {
                body["DEPRECIATION_RULE_ID"] = CSharpExpressionConverter.ConvertToken(bodydEPRECIATIONRULEID);
                bodypropCount++;
            }

            if (bodydHARDWAREGUID != null)
            {
                body["D_HARDWARE_GUID"] = CSharpExpressionConverter.ConvertToken(bodydHARDWAREGUID);
                bodypropCount++;
            }

            if (bodyeMPLOYEEID != null)
            {
                body["EMPLOYEE_ID"] = CSharpExpressionConverter.ConvertToken(bodyeMPLOYEEID);
                bodypropCount++;
            }

            if (bodyeNDOFWARANTY != null)
            {
                body["END_OF_WARANTY"] = CSharpExpressionConverter.ConvertToken(bodyeNDOFWARANTY);
                bodypropCount++;
            }

            if (bodyeNTRYDATE != null)
            {
                body["ENTRY_DATE"] = CSharpExpressionConverter.ConvertToken(bodyeNTRYDATE);
                bodypropCount++;
            }

            if (bodyeSTIMATEDPERCENTAGEUSE != null)
            {
                body["ESTIMATED_PERCENTAGE_USE"] = CSharpExpressionConverter.ConvertToken(bodyeSTIMATEDPERCENTAGEUSE);
                bodypropCount++;
            }

            if (bodyeXPECTEDENDLENDDATE != null)
            {
                body["EXPECTED_END_LEND_DATE"] = CSharpExpressionConverter.ConvertToken(bodyeXPECTEDENDLENDDATE);
                bodypropCount++;
            }

            if (bodyeXPECTEDRETURNDATE != null)
            {
                body["EXPECTED_RETURN_DATE"] = CSharpExpressionConverter.ConvertToken(bodyeXPECTEDRETURNDATE);
                bodypropCount++;
            }

            if (bodyfALLENTERM != null)
            {
                body["FALLEN_TERM"] = CSharpExpressionConverter.ConvertToken(bodyfALLENTERM);
                bodypropCount++;
            }

            if (bodyfIXEDASSETNUMBER != null)
            {
                body["FIXED_ASSET_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyfIXEDASSETNUMBER);
                bodypropCount++;
            }

            if (bodyiNITIALSTART != null)
            {
                body["INITIAL_START"] = CSharpExpressionConverter.ConvertToken(bodyiNITIALSTART);
                bodypropCount++;
            }

            if (bodyiNSTALLATIONDATE != null)
            {
                body["INSTALLATION_DATE"] = CSharpExpressionConverter.ConvertToken(bodyiNSTALLATIONDATE);
                bodypropCount++;
            }

            if (bodyiNTERNALDELIVERYDATE != null)
            {
                body["INTERNAL_DELIVERY_DATE"] = CSharpExpressionConverter.ConvertToken(bodyiNTERNALDELIVERYDATE);
                bodypropCount++;
            }

            if (bodyiNVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyiNVOICENUMBER);
                bodypropCount++;
            }

            if (bodyiSDML != null)
            {
                body["IS_DML"] = CSharpExpressionConverter.ConvertToken(bodyiSDML);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = CSharpExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodylASTPHYSICALINVENTORY != null)
            {
                body["LAST_PHYSICAL_INVENTORY"] = CSharpExpressionConverter.ConvertToken(bodylASTPHYSICALINVENTORY);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylICENSEVERSION != null)
            {
                body["LICENSE_VERSION"] = CSharpExpressionConverter.ConvertToken(bodylICENSEVERSION);
                bodypropCount++;
            }

            if (bodylOCATIONID != null)
            {
                body["LOCATION_ID"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONID);
                bodypropCount++;
            }

            if (bodymAINTENANCECOST != null)
            {
                body["MAINTENANCE_COST"] = CSharpExpressionConverter.ConvertToken(bodymAINTENANCECOST);
                bodypropCount++;
            }

            if (bodymAINTENANCECOSTCURID != null)
            {
                body["MAINTENANCE_COST_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodymAINTENANCECOSTCURID);
                bodypropCount++;
            }

            if (bodymAINUSAGEID != null)
            {
                body["MAIN_USAGE_ID"] = CSharpExpressionConverter.ConvertToken(bodymAINUSAGEID);
                bodypropCount++;
            }

            if (bodymAXINSTALLS != null)
            {
                body["MAX_INSTALLS"] = CSharpExpressionConverter.ConvertToken(bodymAXINSTALLS);
                bodypropCount++;
            }

            if (bodymONTHLYFIXEDCOST != null)
            {
                body["MONTHLY_FIXED_COST"] = CSharpExpressionConverter.ConvertToken(bodymONTHLYFIXEDCOST);
                bodypropCount++;
            }

            if (bodymONTHLYFIXEDCOSTCURID != null)
            {
                body["MONTHLY_FIXED_COST_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodymONTHLYFIXEDCOSTCURID);
                bodypropCount++;
            }

            if (bodymONTHLYNETRENTAL != null)
            {
                body["MONTHLY_NET_RENTAL"] = CSharpExpressionConverter.ConvertToken(bodymONTHLYNETRENTAL);
                bodypropCount++;
            }

            if (bodymONTHLYNETRENTALCURID != null)
            {
                body["MONTHLY_NET_RENTAL_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodymONTHLYNETRENTALCURID);
                bodypropCount++;
            }

            if (bodymONTHDURATION != null)
            {
                body["MONTH_DURATION"] = CSharpExpressionConverter.ConvertToken(bodymONTHDURATION);
                bodypropCount++;
            }

            if (bodynETWORKIDENTIFIER != null)
            {
                body["NETWORK_IDENTIFIER"] = CSharpExpressionConverter.ConvertToken(bodynETWORKIDENTIFIER);
                bodypropCount++;
            }

            if (bodynEXTDEPARTMENTID != null)
            {
                body["NEXT_DEPARTMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodynEXTDEPARTMENTID);
                bodypropCount++;
            }

            if (bodynEXTMAINTENANCEDATE != null)
            {
                body["NEXT_MAINTENANCE_DATE"] = CSharpExpressionConverter.ConvertToken(bodynEXTMAINTENANCEDATE);
                bodypropCount++;
            }

            if (bodynEXTSTATUSID != null)
            {
                body["NEXT_STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodynEXTSTATUSID);
                bodypropCount++;
            }

            if (bodynEXTUSERAPPLICATIONDATE != null)
            {
                body["NEXT_USER_APPLICATION_DATE"] = CSharpExpressionConverter.ConvertToken(bodynEXTUSERAPPLICATIONDATE);
                bodypropCount++;
            }

            if (bodynEXTUSERID != null)
            {
                body["NEXT_USER_ID"] = CSharpExpressionConverter.ConvertToken(bodynEXTUSERID);
                bodypropCount++;
            }

            if (bodynOTICE != null)
            {
                body["NOTICE"] = CSharpExpressionConverter.ConvertToken(bodynOTICE);
                bodypropCount++;
            }

            if (bodyoRDERDETAILSID != null)
            {
                body["ORDER_DETAILS_ID"] = CSharpExpressionConverter.ConvertToken(bodyoRDERDETAILSID);
                bodypropCount++;
            }

            if (bodyoRDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyoRDERNUMBER);
                bodypropCount++;
            }

            if (bodypIPELINESTATUSID != null)
            {
                body["PIPELINE_STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodypIPELINESTATUSID);
                bodypropCount++;
            }

            if (bodypOWERCONSUMPTIONWH != null)
            {
                body["POWER_CONSUMPTION_WH"] = CSharpExpressionConverter.ConvertToken(bodypOWERCONSUMPTIONWH);
                bodypropCount++;
            }

            if (bodypROCESSORCOUNT != null)
            {
                body["PROCESSOR_COUNT"] = CSharpExpressionConverter.ConvertToken(bodypROCESSORCOUNT);
                bodypropCount++;
            }

            if (bodypROCESSORSOCKETCOUNT != null)
            {
                body["PROCESSOR_SOCKET_COUNT"] = CSharpExpressionConverter.ConvertToken(bodypROCESSORSOCKETCOUNT);
                bodypropCount++;
            }

            if (bodypURCHASEDATE != null)
            {
                body["PURCHASE_DATE"] = CSharpExpressionConverter.ConvertToken(bodypURCHASEDATE);
                bodypropCount++;
            }

            if (bodypURCHASEPRICE != null)
            {
                body["PURCHASE_PRICE"] = CSharpExpressionConverter.ConvertToken(bodypURCHASEPRICE);
                bodypropCount++;
            }

            if (bodypURCHASEPRICECURID != null)
            {
                body["PURCHASE_PRICE_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodypURCHASEPRICECURID);
                bodypropCount++;
            }

            if (bodypURCHASERATEID != null)
            {
                body["PURCHASE_RATE_ID"] = CSharpExpressionConverter.ConvertToken(bodypURCHASERATEID);
                bodypropCount++;
            }

            if (bodyrECYCLEDDATE != null)
            {
                body["RECYCLED_DATE"] = CSharpExpressionConverter.ConvertToken(bodyrECYCLEDDATE);
                bodypropCount++;
            }

            if (bodyrECYCLINGPROVIDERID != null)
            {
                body["RECYCLING_PROVIDER_ID"] = CSharpExpressionConverter.ConvertToken(bodyrECYCLINGPROVIDERID);
                bodypropCount++;
            }

            if (bodyrEFORMNUMBER != null)
            {
                body["REFORM_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyrEFORMNUMBER);
                bodypropCount++;
            }

            if (bodyrEMOVEDDATE != null)
            {
                body["REMOVED_DATE"] = CSharpExpressionConverter.ConvertToken(bodyrEMOVEDDATE);
                bodypropCount++;
            }

            if (bodyrENEWALDECISIONID != null)
            {
                body["RENEWAL_DECISION_ID"] = CSharpExpressionConverter.ConvertToken(bodyrENEWALDECISIONID);
                bodypropCount++;
            }

            if (bodyrENEWALVALUE != null)
            {
                body["RENEWAL_VALUE"] = CSharpExpressionConverter.ConvertToken(bodyrENEWALVALUE);
                bodypropCount++;
            }

            if (bodyrENEWALVALUECURID != null)
            {
                body["RENEWAL_VALUE_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodyrENEWALVALUECURID);
                bodypropCount++;
            }

            if (bodyrEPAIREDBYID != null)
            {
                body["REPAIRED_BY_ID"] = CSharpExpressionConverter.ConvertToken(bodyrEPAIREDBYID);
                bodypropCount++;
            }

            if (bodyrESALESVALUE != null)
            {
                body["RESALES_VALUE"] = CSharpExpressionConverter.ConvertToken(bodyrESALESVALUE);
                bodypropCount++;
            }

            if (bodysCHEDULEDEND != null)
            {
                body["SCHEDULED_END"] = CSharpExpressionConverter.ConvertToken(bodysCHEDULEDEND);
                bodypropCount++;
            }

            if (bodysDCATALOGID != null)
            {
                body["SD_CATALOG_ID"] = CSharpExpressionConverter.ConvertToken(bodysDCATALOGID);
                bodypropCount++;
            }

            if (bodysERIALNUMBER != null)
            {
                body["SERIAL_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodysERIALNUMBER);
                bodypropCount++;
            }

            if (bodysLAID != null)
            {
                body["SLA_ID"] = CSharpExpressionConverter.ConvertToken(bodysLAID);
                bodypropCount++;
            }

            if (bodysTATUSID != null)
            {
                body["STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodysTATUSID);
                bodypropCount++;
            }

            if (bodysUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = CSharpExpressionConverter.ConvertToken(bodysUPPLIERID);
                bodypropCount++;
            }

            if (bodytERM != null)
            {
                body["TERM"] = CSharpExpressionConverter.ConvertToken(bodytERM);
                bodypropCount++;
            }

            if (bodyuPDATECOVERAGETERM != null)
            {
                body["UPDATE_COVERAGE_TERM"] = CSharpExpressionConverter.ConvertToken(bodyuPDATECOVERAGETERM);
                bodypropCount++;
            }

            if (bodywARANTYTYPEID != null)
            {
                body["WARANTY_TYPE_ID"] = CSharpExpressionConverter.ConvertToken(bodywARANTYTYPEID);
                bodypropCount++;
            }

            if (bodyassetLabel != null)
            {
                body["asset_label"] = CSharpExpressionConverter.ConvertToken(bodyassetLabel);
                bodypropCount++;
            }

            if (bodyassetTag != null)
            {
                body["asset_tag"] = CSharpExpressionConverter.ConvertToken(bodyassetTag);
                bodypropCount++;
            }

            if (bodyautomaticRenewal != null)
            {
                body["automatic_renewal"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRenewal);
                bodypropCount++;
            }

            if (bodyavailabilitySlaId != null)
            {
                body["availability_sla_id"] = CSharpExpressionConverter.ConvertToken(bodyavailabilitySlaId);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = CSharpExpressionConverter.ConvertToken(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["available_field_2"] = CSharpExpressionConverter.ConvertToken(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["available_field_3"] = CSharpExpressionConverter.ConvertToken(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["available_field_4"] = CSharpExpressionConverter.ConvertToken(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["available_field_5"] = CSharpExpressionConverter.ConvertToken(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["available_field_6"] = CSharpExpressionConverter.ConvertToken(bodyavailableField6);
                bodypropCount++;
            }

            if (bodycommentAsset != null)
            {
                body["comment_asset"] = CSharpExpressionConverter.ConvertToken(bodycommentAsset);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractRow != null)
            {
                body["Contract_Row"] = CSharpExpressionConverter.ConvertToken(bodycontractRow);
                bodypropCount++;
            }

            if (bodymonthlyPayment != null)
            {
                body["Monthly_Payment"] = CSharpExpressionConverter.ConvertToken(bodymonthlyPayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractRow != null)
            {
                body["Contract_Row"] = CSharpExpressionConverter.ConvertToken(bodycontractRow);
                bodypropCount++;
            }

            if (bodymonthlyPayment != null)
            {
                body["Monthly_Payment"] = CSharpExpressionConverter.ConvertToken(bodymonthlyPayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink(Expression<Func<string>> account, Expression<Func<string>> parentAssetId, Expression<Func<string>> childAssetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAssetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewCatalogAssetsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            return new ApiConnectionAction<ViewCatalogRequestsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewCatalogRequestsPathListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewConfigurationItemsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyrelationTypeID, Expression<Func<string>> bodyblocking = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyblocking != null)
            {
                body["Blocking"] = CSharpExpressionConverter.ConvertToken(bodyblocking);
                bodypropCount++;
            }

            bodypropCount++;
            body["Relation_Type_ID"] = CSharpExpressionConverter.ConvertToken(bodyrelationTypeID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyblocking = null, Expression<Func<string>> bodyrelationTypeID = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyblocking != null)
            {
                body["Blocking"] = CSharpExpressionConverter.ConvertToken(bodyblocking);
                bodypropCount++;
            }

            if (bodyrelationTypeID != null)
            {
                body["Relation_Type_ID"] = CSharpExpressionConverter.ConvertToken(bodyrelationTypeID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewEntitiesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity(Expression<Func<string>> account, Expression<Func<string>> departmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(departmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEntityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateDepartmentResponse> UpdateDepartment(Expression<Func<string>> account, Expression<Func<string>> departmentId, Expression<Func<string>> bodypARENTDEPARTMENTID = null, Expression<Func<string>> bodydEPARTMENTEN = null, Expression<Func<string>> bodydEPARTMENTFR = null, Expression<Func<string>> bodydEPARTMENTSP = null, Expression<Func<string>> bodydEPARTMENTGE = null, Expression<Func<string>> bodydEPARTMENTIT = null, Expression<Func<string>> bodydEPARTMENTPO = null, Expression<Func<string>> bodydEPARTMENTLABEL = null, Expression<Func<string>> bodycOMMENTDEPARTMENT = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodydEFAULTCOSTCENTERID = null, Expression<Func<string>> bodysTARTDATE = null, Expression<Func<string>> bodyeNDDATE = null, Expression<Func<string>> bodyuRLMAP = null, Expression<Func<string>> bodydEPARTMENTCODE = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodycURRENCYID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodydEPARTMENTL1 = null, Expression<Func<string>> bodydEPARTMENTL2 = null, Expression<Func<string>> bodydEPARTMENTL3 = null, Expression<Func<string>> bodydEPARTMENTL4 = null, Expression<Func<string>> bodydEPARTMENTL5 = null, Expression<Func<string>> bodydEPARTMENTL6 = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(departmentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypARENTDEPARTMENTID != null)
            {
                body["PARENT_DEPARTMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodypARENTDEPARTMENTID);
                bodypropCount++;
            }

            if (bodydEPARTMENTEN != null)
            {
                body["DEPARTMENT_EN"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTEN);
                bodypropCount++;
            }

            if (bodydEPARTMENTFR != null)
            {
                body["DEPARTMENT_FR"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTFR);
                bodypropCount++;
            }

            if (bodydEPARTMENTSP != null)
            {
                body["DEPARTMENT_SP"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTSP);
                bodypropCount++;
            }

            if (bodydEPARTMENTGE != null)
            {
                body["DEPARTMENT_GE"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTGE);
                bodypropCount++;
            }

            if (bodydEPARTMENTIT != null)
            {
                body["DEPARTMENT_IT"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTIT);
                bodypropCount++;
            }

            if (bodydEPARTMENTPO != null)
            {
                body["DEPARTMENT_PO"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTPO);
                bodypropCount++;
            }

            if (bodydEPARTMENTLABEL != null)
            {
                body["DEPARTMENT_LABEL"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTLABEL);
                bodypropCount++;
            }

            if (bodycOMMENTDEPARTMENT != null)
            {
                body["COMMENT_DEPARTMENT"] = CSharpExpressionConverter.ConvertToken(bodycOMMENTDEPARTMENT);
                bodypropCount++;
            }

            if (bodymANAGERID != null)
            {
                body["MANAGER_ID"] = CSharpExpressionConverter.ConvertToken(bodymANAGERID);
                bodypropCount++;
            }

            if (bodydEFAULTCOSTCENTERID != null)
            {
                body["DEFAULT_COST_CENTER_ID"] = CSharpExpressionConverter.ConvertToken(bodydEFAULTCOSTCENTERID);
                bodypropCount++;
            }

            if (bodysTARTDATE != null)
            {
                body["START_DATE"] = CSharpExpressionConverter.ConvertToken(bodysTARTDATE);
                bodypropCount++;
            }

            if (bodyeNDDATE != null)
            {
                body["END_DATE"] = CSharpExpressionConverter.ConvertToken(bodyeNDDATE);
                bodypropCount++;
            }

            if (bodyuRLMAP != null)
            {
                body["URL_MAP"] = CSharpExpressionConverter.ConvertToken(bodyuRLMAP);
                bodypropCount++;
            }

            if (bodydEPARTMENTCODE != null)
            {
                body["DEPARTMENT_CODE"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTCODE);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = CSharpExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodycURRENCYID != null)
            {
                body["CURRENCY_ID"] = CSharpExpressionConverter.ConvertToken(bodycURRENCYID);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodysLAID != null)
            {
                body["SLA_ID"] = CSharpExpressionConverter.ConvertToken(bodysLAID);
                bodypropCount++;
            }

            if (bodydEPARTMENTL1 != null)
            {
                body["DEPARTMENT_L1"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL1);
                bodypropCount++;
            }

            if (bodydEPARTMENTL2 != null)
            {
                body["DEPARTMENT_L2"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL2);
                bodypropCount++;
            }

            if (bodydEPARTMENTL3 != null)
            {
                body["DEPARTMENT_L3"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL3);
                bodypropCount++;
            }

            if (bodydEPARTMENTL4 != null)
            {
                body["DEPARTMENT_L4"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL4);
                bodypropCount++;
            }

            if (bodydEPARTMENTL5 != null)
            {
                body["DEPARTMENT_L5"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL5);
                bodypropCount++;
            }

            if (bodydEPARTMENTL6 != null)
            {
                body["DEPARTMENT_L6"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTL6);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateDepartmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewEmployeesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee(Expression<Func<string>> account, Expression<Func<bodyemployeesInputItem[]>> bodyemployees = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemployees != null)
            {
                body["employees"] = CSharpExpressionConverter.ConvertToken(bodyemployees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId, Expression<Func<string>> bodyaPPROVEDTOVALIDATE = null, Expression<Func<string>> bodyaVAILABILITYSTATUSID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodybEGINOFCONTRACT = null, Expression<Func<string>> bodycELLULARNUMBER = null, Expression<Func<string>> bodycHATLOGIN = null, Expression<Func<string>> bodycIVILSTATUSID = null, Expression<Func<string>> bodycOMMENTEMPLOYEE = null, Expression<Func<string>> bodycOSTPERHOUR = null, Expression<Func<string>> bodycOSTPERHOURCURID = null, Expression<Func<string>> bodydEFAULTCOSTCENTERID = null, Expression<Func<string>> bodydELEGATIONFROM = null, Expression<Func<string>> bodydELEGATIONID = null, Expression<Func<string>> bodydELEGATIONTO = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodyeNDOFCONTRACT = null, Expression<Func<string>> bodyeMAIL = null, Expression<Func<string>> bodyfAXNUMBER = null, Expression<Func<string>> bodyfUNCTIONID = null, Expression<Func<string>> bodyiCQNUMBER = null, Expression<Func<string>> bodyiDENTIFICATION = null, Expression<Func<string>> bodyiSAUTOMATICSTATUS = null, Expression<Func<string>> bodyiTCORRESPONDENT = null, Expression<Func<string>> bodylANGUAGEID = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTNAME = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodylOGIN = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodymESSENGERSIGNNAME = null, Expression<Func<string>> bodynOTIFICATIONTYPEID = null, Expression<Func<string>> bodypASSWDLASTUPDATEUT = null, Expression<Func<string>> bodypHONENUMBER = null, Expression<Func<string>> bodypICTUREPATH = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodyvALIDATORID = null, Expression<Func<string>> bodyvIPLEVELID = null, Expression<Func<string>> bodywAVEADDRESS = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaPPROVEDTOVALIDATE != null)
            {
                body["APPROVED_TO_VALIDATE"] = CSharpExpressionConverter.ConvertToken(bodyaPPROVEDTOVALIDATE);
                bodypropCount++;
            }

            if (bodyaVAILABILITYSTATUSID != null)
            {
                body["AVAILABILITY_STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABILITYSTATUSID);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodybEGINOFCONTRACT != null)
            {
                body["BEGIN_OF_CONTRACT"] = CSharpExpressionConverter.ConvertToken(bodybEGINOFCONTRACT);
                bodypropCount++;
            }

            if (bodycELLULARNUMBER != null)
            {
                body["CELLULAR_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodycELLULARNUMBER);
                bodypropCount++;
            }

            if (bodycHATLOGIN != null)
            {
                body["CHAT_LOGIN"] = CSharpExpressionConverter.ConvertToken(bodycHATLOGIN);
                bodypropCount++;
            }

            if (bodycIVILSTATUSID != null)
            {
                body["CIVIL_STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodycIVILSTATUSID);
                bodypropCount++;
            }

            if (bodycOMMENTEMPLOYEE != null)
            {
                body["COMMENT_EMPLOYEE"] = CSharpExpressionConverter.ConvertToken(bodycOMMENTEMPLOYEE);
                bodypropCount++;
            }

            if (bodycOSTPERHOUR != null)
            {
                body["COST_PER_HOUR"] = CSharpExpressionConverter.ConvertToken(bodycOSTPERHOUR);
                bodypropCount++;
            }

            if (bodycOSTPERHOURCURID != null)
            {
                body["COST_PER_HOUR_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodycOSTPERHOURCURID);
                bodypropCount++;
            }

            if (bodydEFAULTCOSTCENTERID != null)
            {
                body["DEFAULT_COST_CENTER_ID"] = CSharpExpressionConverter.ConvertToken(bodydEFAULTCOSTCENTERID);
                bodypropCount++;
            }

            if (bodydELEGATIONFROM != null)
            {
                body["DELEGATION_FROM"] = CSharpExpressionConverter.ConvertToken(bodydELEGATIONFROM);
                bodypropCount++;
            }

            if (bodydELEGATIONID != null)
            {
                body["DELEGATION_ID"] = CSharpExpressionConverter.ConvertToken(bodydELEGATIONID);
                bodypropCount++;
            }

            if (bodydELEGATIONTO != null)
            {
                body["DELEGATION_TO"] = CSharpExpressionConverter.ConvertToken(bodydELEGATIONTO);
                bodypropCount++;
            }

            if (bodydEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodydEPARTMENTID);
                bodypropCount++;
            }

            if (bodyeNDOFCONTRACT != null)
            {
                body["END_OF_CONTRACT"] = CSharpExpressionConverter.ConvertToken(bodyeNDOFCONTRACT);
                bodypropCount++;
            }

            if (bodyeMAIL != null)
            {
                body["E_MAIL"] = CSharpExpressionConverter.ConvertToken(bodyeMAIL);
                bodypropCount++;
            }

            if (bodyfAXNUMBER != null)
            {
                body["FAX_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyfAXNUMBER);
                bodypropCount++;
            }

            if (bodyfUNCTIONID != null)
            {
                body["FUNCTION_ID"] = CSharpExpressionConverter.ConvertToken(bodyfUNCTIONID);
                bodypropCount++;
            }

            if (bodyiCQNUMBER != null)
            {
                body["ICQ_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyiCQNUMBER);
                bodypropCount++;
            }

            if (bodyiDENTIFICATION != null)
            {
                body["IDENTIFICATION"] = CSharpExpressionConverter.ConvertToken(bodyiDENTIFICATION);
                bodypropCount++;
            }

            if (bodyiSAUTOMATICSTATUS != null)
            {
                body["IS_AUTOMATIC_STATUS"] = CSharpExpressionConverter.ConvertToken(bodyiSAUTOMATICSTATUS);
                bodypropCount++;
            }

            if (bodyiTCORRESPONDENT != null)
            {
                body["IT_CORRESPONDENT"] = CSharpExpressionConverter.ConvertToken(bodyiTCORRESPONDENT);
                bodypropCount++;
            }

            if (bodylANGUAGEID != null)
            {
                body["LANGUAGE_ID"] = CSharpExpressionConverter.ConvertToken(bodylANGUAGEID);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = CSharpExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodylASTNAME != null)
            {
                body["LAST_NAME"] = CSharpExpressionConverter.ConvertToken(bodylASTNAME);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylOCATIONID != null)
            {
                body["LOCATION_ID"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONID);
                bodypropCount++;
            }

            if (bodylOGIN != null)
            {
                body["LOGIN"] = CSharpExpressionConverter.ConvertToken(bodylOGIN);
                bodypropCount++;
            }

            if (bodymANAGERID != null)
            {
                body["MANAGER_ID"] = CSharpExpressionConverter.ConvertToken(bodymANAGERID);
                bodypropCount++;
            }

            if (bodymESSENGERSIGNNAME != null)
            {
                body["MESSENGER_SIGN_NAME"] = CSharpExpressionConverter.ConvertToken(bodymESSENGERSIGNNAME);
                bodypropCount++;
            }

            if (bodynOTIFICATIONTYPEID != null)
            {
                body["NOTIFICATION_TYPE_ID"] = CSharpExpressionConverter.ConvertToken(bodynOTIFICATIONTYPEID);
                bodypropCount++;
            }

            if (bodypASSWDLASTUPDATEUT != null)
            {
                body["PASSWD_LAST_UPDATE_UT"] = CSharpExpressionConverter.ConvertToken(bodypASSWDLASTUPDATEUT);
                bodypropCount++;
            }

            if (bodypHONENUMBER != null)
            {
                body["PHONE_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodypHONENUMBER);
                bodypropCount++;
            }

            if (bodypICTUREPATH != null)
            {
                body["PICTURE_PATH"] = CSharpExpressionConverter.ConvertToken(bodypICTUREPATH);
                bodypropCount++;
            }

            if (bodysUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = CSharpExpressionConverter.ConvertToken(bodysUPPLIERID);
                bodypropCount++;
            }

            if (bodyvALIDATORID != null)
            {
                body["VALIDATOR_ID"] = CSharpExpressionConverter.ConvertToken(bodyvALIDATORID);
                bodypropCount++;
            }

            if (bodyvIPLEVELID != null)
            {
                body["VIP_LEVEL_ID"] = CSharpExpressionConverter.ConvertToken(bodyvIPLEVELID);
                bodypropCount++;
            }

            if (bodywAVEADDRESS != null)
            {
                body["WAVE_ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodywAVEADDRESS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewKnownErrorsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors(Expression<Func<string>> account, Expression<Func<string>> kpId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(kpId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewLocationsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation(Expression<Func<string>> account, Expression<Func<string>> locationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateLocationResponse> UpdateLocation(Expression<Func<string>> account, Expression<Func<string>> locationId, Expression<Func<string>> bodypARENTLOCATIONID = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodylOCATIONEN = null, Expression<Func<string>> bodylOCATIONFR = null, Expression<Func<string>> bodylOCATIONGE = null, Expression<Func<string>> bodylOCATIONSP = null, Expression<Func<string>> bodylOCATIONIT = null, Expression<Func<string>> bodylOCATIONPO = null, Expression<Func<string>> bodysTREETADDRESS1 = null, Expression<Func<string>> bodysTREETADDRESS2 = null, Expression<Func<string>> bodycITY = null, Expression<Func<string>> bodypHONE = null, Expression<Func<string>> bodyzIPCODE = null, Expression<Func<string>> bodyfAX = null, Expression<Func<string>> bodycOMMENTLOCATION = null, Expression<Func<string>> bodyrEGIONZONEID = null, Expression<Func<string>> bodycOUNTRYID = null, Expression<Func<string>> bodysTATEID = null, Expression<Func<string>> bodysTARTDATE = null, Expression<Func<string>> bodyeNDDATE = null, Expression<Func<string>> bodyuRLMAP = null, Expression<Func<string>> bodydISCOVERYNAME = null, Expression<Func<string>> bodylOCATIONCODE = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodyiSDELIVERYADDRESS = null, Expression<Func<string>> bodytIMEZONEID = null, Expression<Func<string>> bodysTATUSID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodygMAPLAT = null, Expression<Func<string>> bodygMAPLNG = null, Expression<Func<string>> bodylOCATIONL1 = null, Expression<Func<string>> bodylOCATIONL2 = null, Expression<Func<string>> bodylOCATIONL3 = null, Expression<Func<string>> bodylOCATIONL4 = null, Expression<Func<string>> bodylOCATIONL5 = null, Expression<Func<string>> bodylOCATIONL6 = null, Expression<Func<string>> bodyeISMEETINGROOM = null, Expression<Func<string>> bodyeCAPACITY = null, Expression<Func<string>> bodyeWIFILOGIN = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypARENTLOCATIONID != null)
            {
                body["PARENT_LOCATION_ID"] = CSharpExpressionConverter.ConvertToken(bodypARENTLOCATIONID);
                bodypropCount++;
            }

            if (bodymANAGERID != null)
            {
                body["MANAGER_ID"] = CSharpExpressionConverter.ConvertToken(bodymANAGERID);
                bodypropCount++;
            }

            if (bodylOCATIONEN != null)
            {
                body["LOCATION_EN"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONEN);
                bodypropCount++;
            }

            if (bodylOCATIONFR != null)
            {
                body["LOCATION_FR"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONFR);
                bodypropCount++;
            }

            if (bodylOCATIONGE != null)
            {
                body["LOCATION_GE"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONGE);
                bodypropCount++;
            }

            if (bodylOCATIONSP != null)
            {
                body["LOCATION_SP"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONSP);
                bodypropCount++;
            }

            if (bodylOCATIONIT != null)
            {
                body["LOCATION_IT"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONIT);
                bodypropCount++;
            }

            if (bodylOCATIONPO != null)
            {
                body["LOCATION_PO"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONPO);
                bodypropCount++;
            }

            if (bodysTREETADDRESS1 != null)
            {
                body["STREET_ADDRESS_1"] = CSharpExpressionConverter.ConvertToken(bodysTREETADDRESS1);
                bodypropCount++;
            }

            if (bodysTREETADDRESS2 != null)
            {
                body["STREET_ADDRESS_2"] = CSharpExpressionConverter.ConvertToken(bodysTREETADDRESS2);
                bodypropCount++;
            }

            if (bodycITY != null)
            {
                body["CITY"] = CSharpExpressionConverter.ConvertToken(bodycITY);
                bodypropCount++;
            }

            if (bodypHONE != null)
            {
                body["PHONE"] = CSharpExpressionConverter.ConvertToken(bodypHONE);
                bodypropCount++;
            }

            if (bodyzIPCODE != null)
            {
                body["ZIP_CODE"] = CSharpExpressionConverter.ConvertToken(bodyzIPCODE);
                bodypropCount++;
            }

            if (bodyfAX != null)
            {
                body["FAX"] = CSharpExpressionConverter.ConvertToken(bodyfAX);
                bodypropCount++;
            }

            if (bodycOMMENTLOCATION != null)
            {
                body["COMMENT_LOCATION"] = CSharpExpressionConverter.ConvertToken(bodycOMMENTLOCATION);
                bodypropCount++;
            }

            if (bodyrEGIONZONEID != null)
            {
                body["REGION_ZONE_ID"] = CSharpExpressionConverter.ConvertToken(bodyrEGIONZONEID);
                bodypropCount++;
            }

            if (bodycOUNTRYID != null)
            {
                body["COUNTRY_ID"] = CSharpExpressionConverter.ConvertToken(bodycOUNTRYID);
                bodypropCount++;
            }

            if (bodysTATEID != null)
            {
                body["STATE_ID"] = CSharpExpressionConverter.ConvertToken(bodysTATEID);
                bodypropCount++;
            }

            if (bodysTARTDATE != null)
            {
                body["START_DATE"] = CSharpExpressionConverter.ConvertToken(bodysTARTDATE);
                bodypropCount++;
            }

            if (bodyeNDDATE != null)
            {
                body["END_DATE"] = CSharpExpressionConverter.ConvertToken(bodyeNDDATE);
                bodypropCount++;
            }

            if (bodyuRLMAP != null)
            {
                body["URL_MAP"] = CSharpExpressionConverter.ConvertToken(bodyuRLMAP);
                bodypropCount++;
            }

            if (bodydISCOVERYNAME != null)
            {
                body["DISCOVERY_NAME"] = CSharpExpressionConverter.ConvertToken(bodydISCOVERYNAME);
                bodypropCount++;
            }

            if (bodylOCATIONCODE != null)
            {
                body["LOCATION_CODE"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONCODE);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodylASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = CSharpExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                bodypropCount++;
            }

            if (bodyiSDELIVERYADDRESS != null)
            {
                body["IS_DELIVERY_ADDRESS"] = CSharpExpressionConverter.ConvertToken(bodyiSDELIVERYADDRESS);
                bodypropCount++;
            }

            if (bodytIMEZONEID != null)
            {
                body["TIME_ZONE_ID"] = CSharpExpressionConverter.ConvertToken(bodytIMEZONEID);
                bodypropCount++;
            }

            if (bodysTATUSID != null)
            {
                body["STATUS_ID"] = CSharpExpressionConverter.ConvertToken(bodysTATUSID);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodysLAID != null)
            {
                body["SLA_ID"] = CSharpExpressionConverter.ConvertToken(bodysLAID);
                bodypropCount++;
            }

            if (bodygMAPLAT != null)
            {
                body["G_MAP_LAT"] = CSharpExpressionConverter.ConvertToken(bodygMAPLAT);
                bodypropCount++;
            }

            if (bodygMAPLNG != null)
            {
                body["G_MAP_LNG"] = CSharpExpressionConverter.ConvertToken(bodygMAPLNG);
                bodypropCount++;
            }

            if (bodylOCATIONL1 != null)
            {
                body["LOCATION_L1"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL1);
                bodypropCount++;
            }

            if (bodylOCATIONL2 != null)
            {
                body["LOCATION_L2"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL2);
                bodypropCount++;
            }

            if (bodylOCATIONL3 != null)
            {
                body["LOCATION_L3"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL3);
                bodypropCount++;
            }

            if (bodylOCATIONL4 != null)
            {
                body["LOCATION_L4"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL4);
                bodypropCount++;
            }

            if (bodylOCATIONL5 != null)
            {
                body["LOCATION_L5"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL5);
                bodypropCount++;
            }

            if (bodylOCATIONL6 != null)
            {
                body["LOCATION_L6"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONL6);
                bodypropCount++;
            }

            if (bodyeISMEETINGROOM != null)
            {
                body["E_IS_MEETING_ROOM"] = CSharpExpressionConverter.ConvertToken(bodyeISMEETINGROOM);
                bodypropCount++;
            }

            if (bodyeCAPACITY != null)
            {
                body["E_CAPACITY"] = CSharpExpressionConverter.ConvertToken(bodyeCAPACITY);
                bodypropCount++;
            }

            if (bodyeWIFILOGIN != null)
            {
                body["E_WIFI_LOGIN"] = CSharpExpressionConverter.ConvertToken(bodyeWIFILOGIN);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewManufacturerListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer(Expression<Func<string>> account, Expression<Func<string>> manufacturerId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(manufacturerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewRequestsIncidentsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident(Expression<Func<string>> account, Expression<Func<bodyrequestsInputItem[]>> bodyrequests = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrequests != null)
            {
                body["requests"] = CSharpExpressionConverter.ConvertToken(bodyrequests);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodyclosedInputItem[]>> bodyclosed = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyclosed != null)
            {
                body["closed"] = CSharpExpressionConverter.ConvertToken(bodyclosed);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CloseRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyanalyticalChargeId = null, Expression<Func<string>> bodyassetId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodybudgetPlanned = null, Expression<Func<string>> bodycanBeDuplicated = null, Expression<Func<string>> bodyciId = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontinuityPlanId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydelay = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydynamicDetails = null, Expression<Func<string>> bodyeffectiveChangeDateEnd = null, Expression<Func<string>> bodyeffectiveChangeDateStart = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodyestimatedNetPrice = null, Expression<Func<string>> bodyexpectedDateUt = null, Expression<Func<string>> bodyexpectedDuration = null, Expression<Func<string>> bodyexpectedEndDateUt = null, Expression<Func<string>> bodyexpectedStartDateUt = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyfirstCallResolution = null, Expression<Func<string>> bodyhourPerDay = null, Expression<Func<string>> bodyimpactId = null, Expression<Func<string>> bodyimputationDate = null, Expression<Func<string>> bodyisMajorIncident = null, Expression<Func<string>> bodyisTemplate = null, Expression<Func<string>> bodyknownProblemsId = null, Expression<Func<string>> bodylastUpdate = null, Expression<Func<string>> bodymark1 = null, Expression<Func<string>> bodymark2 = null, Expression<Func<string>> bodymaxResolutionDateUt = null, Expression<Func<string>> bodymsProjectImportValidationWaiting = null, Expression<Func<string>> bodynetPrice = null, Expression<Func<string>> bodynetPriceCurId = null, Expression<Func<string>> bodyoriginToolId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyowningGroupId = null, Expression<Func<string>> bodyplannedChangeDateEnd = null, Expression<Func<string>> bodyplannedChangeDateStart = null, Expression<Func<string>> bodypmStatusId = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectStartDateUt = null, Expression<Func<string>> bodyqty = null, Expression<Func<string>> bodyreleaseId = null, Expression<Func<string>> bodyrentalNetPrice = null, Expression<Func<string>> bodyrentalNetPriceCurId = null, Expression<Func<string>> bodyrequestOriginId = null, Expression<Func<string>> bodyrequestedChangeDateEnd = null, Expression<Func<string>> bodyrequestedChangeDateStart = null, Expression<Func<string>> bodyrequestorId = null, Expression<Func<string>> bodyrequestorIpAddress = null, Expression<Func<string>> bodyrequestorPhone = null, Expression<Func<string>> bodyriskAmount = null, Expression<Func<string>> bodyriskDescription = null, Expression<Func<string>> bodyriskLevelId = null, Expression<Func<string>> bodyrootCauseId = null, Expression<Func<string>> bodysubmitDateUt = null, Expression<Func<string>> bodytimeUsedToSolveRequest = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyanalyticalChargeId != null)
            {
                body["Analytical_Charge_Id"] = CSharpExpressionConverter.ConvertToken(bodyanalyticalChargeId);
                bodypropCount++;
            }

            if (bodyassetId != null)
            {
                body["Asset_Id"] = CSharpExpressionConverter.ConvertToken(bodyassetId);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["Available_Field_1"] = CSharpExpressionConverter.ConvertToken(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["Available_Field_2"] = CSharpExpressionConverter.ConvertToken(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["Available_Field_3"] = CSharpExpressionConverter.ConvertToken(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["Available_Field_4"] = CSharpExpressionConverter.ConvertToken(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["Available_Field_5"] = CSharpExpressionConverter.ConvertToken(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["Available_Field_6"] = CSharpExpressionConverter.ConvertToken(bodyavailableField6);
                bodypropCount++;
            }

            if (bodybudgetPlanned != null)
            {
                body["Budget_Planned"] = CSharpExpressionConverter.ConvertToken(bodybudgetPlanned);
                bodypropCount++;
            }

            if (bodycanBeDuplicated != null)
            {
                body["Can_Be_Duplicated"] = CSharpExpressionConverter.ConvertToken(bodycanBeDuplicated);
                bodypropCount++;
            }

            if (bodyciId != null)
            {
                body["Ci_Id"] = CSharpExpressionConverter.ConvertToken(bodyciId);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodycontinuityPlanId != null)
            {
                body["Continuity_Plan_Id"] = CSharpExpressionConverter.ConvertToken(bodycontinuityPlanId);
                bodypropCount++;
            }

            if (bodycostCenterId != null)
            {
                body["Cost_Center_Id"] = CSharpExpressionConverter.ConvertToken(bodycostCenterId);
                bodypropCount++;
            }

            if (bodycreationDateUt != null)
            {
                body["Creation_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodycreationDateUt);
                bodypropCount++;
            }

            if (bodydelay != null)
            {
                body["Delay"] = CSharpExpressionConverter.ConvertToken(bodydelay);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodydynamicDetails != null)
            {
                body["Dynamic_Details"] = CSharpExpressionConverter.ConvertToken(bodydynamicDetails);
                bodypropCount++;
            }

            if (bodyeffectiveChangeDateEnd != null)
            {
                body["Effective_Change_Date_End"] = CSharpExpressionConverter.ConvertToken(bodyeffectiveChangeDateEnd);
                bodypropCount++;
            }

            if (bodyeffectiveChangeDateStart != null)
            {
                body["Effective_Change_Date_Start"] = CSharpExpressionConverter.ConvertToken(bodyeffectiveChangeDateStart);
                bodypropCount++;
            }

            if (bodyendDateUt != null)
            {
                body["End_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodyendDateUt);
                bodypropCount++;
            }

            if (bodyestimatedNetPrice != null)
            {
                body["Estimated_Net_Price"] = CSharpExpressionConverter.ConvertToken(bodyestimatedNetPrice);
                bodypropCount++;
            }

            if (bodyexpectedDateUt != null)
            {
                body["Expected_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDateUt);
                bodypropCount++;
            }

            if (bodyexpectedDuration != null)
            {
                body["Expected_Duration"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDuration);
                bodypropCount++;
            }

            if (bodyexpectedEndDateUt != null)
            {
                body["Expected_End_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndDateUt);
                bodypropCount++;
            }

            if (bodyexpectedStartDateUt != null)
            {
                body["Expected_Start_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStartDateUt);
                bodypropCount++;
            }

            if (bodyexternalReference != null)
            {
                body["External_Reference"] = CSharpExpressionConverter.ConvertToken(bodyexternalReference);
                bodypropCount++;
            }

            if (bodyfirstCallResolution != null)
            {
                body["First_Call_Resolution"] = CSharpExpressionConverter.ConvertToken(bodyfirstCallResolution);
                bodypropCount++;
            }

            if (bodyhourPerDay != null)
            {
                body["Hour_Per_Day"] = CSharpExpressionConverter.ConvertToken(bodyhourPerDay);
                bodypropCount++;
            }

            if (bodyimpactId != null)
            {
                body["Impact_Id"] = CSharpExpressionConverter.ConvertToken(bodyimpactId);
                bodypropCount++;
            }

            if (bodyimputationDate != null)
            {
                body["Imputation_Date"] = CSharpExpressionConverter.ConvertToken(bodyimputationDate);
                bodypropCount++;
            }

            if (bodyisMajorIncident != null)
            {
                body["Is_Major_Incident"] = CSharpExpressionConverter.ConvertToken(bodyisMajorIncident);
                bodypropCount++;
            }

            if (bodyisTemplate != null)
            {
                body["Is_Template"] = CSharpExpressionConverter.ConvertToken(bodyisTemplate);
                bodypropCount++;
            }

            if (bodyknownProblemsId != null)
            {
                body["Known_Problems_Id"] = CSharpExpressionConverter.ConvertToken(bodyknownProblemsId);
                bodypropCount++;
            }

            if (bodylastUpdate != null)
            {
                body["Last_Update"] = CSharpExpressionConverter.ConvertToken(bodylastUpdate);
                bodypropCount++;
            }

            if (bodymark1 != null)
            {
                body["Mark_1"] = CSharpExpressionConverter.ConvertToken(bodymark1);
                bodypropCount++;
            }

            if (bodymark2 != null)
            {
                body["Mark_2"] = CSharpExpressionConverter.ConvertToken(bodymark2);
                bodypropCount++;
            }

            if (bodymaxResolutionDateUt != null)
            {
                body["Max_Resolution_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodymaxResolutionDateUt);
                bodypropCount++;
            }

            if (bodymsProjectImportValidationWaiting != null)
            {
                body["Ms_Project_Import_Validation_Waiting"] = CSharpExpressionConverter.ConvertToken(bodymsProjectImportValidationWaiting);
                bodypropCount++;
            }

            if (bodynetPrice != null)
            {
                body["Net_Price"] = CSharpExpressionConverter.ConvertToken(bodynetPrice);
                bodypropCount++;
            }

            if (bodynetPriceCurId != null)
            {
                body["Net_Price_Cur_Id"] = CSharpExpressionConverter.ConvertToken(bodynetPriceCurId);
                bodypropCount++;
            }

            if (bodyoriginToolId != null)
            {
                body["Origin_Tool_Id"] = CSharpExpressionConverter.ConvertToken(bodyoriginToolId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["Owner_Id"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyowningGroupId != null)
            {
                body["Owning_Group_Id"] = CSharpExpressionConverter.ConvertToken(bodyowningGroupId);
                bodypropCount++;
            }

            if (bodyplannedChangeDateEnd != null)
            {
                body["Planned_Change_Date_End"] = CSharpExpressionConverter.ConvertToken(bodyplannedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyplannedChangeDateStart != null)
            {
                body["Planned_Change_Date_Start"] = CSharpExpressionConverter.ConvertToken(bodyplannedChangeDateStart);
                bodypropCount++;
            }

            if (bodypmStatusId != null)
            {
                body["Pm_Status_Id"] = CSharpExpressionConverter.ConvertToken(bodypmStatusId);
                bodypropCount++;
            }

            if (bodyprojectName != null)
            {
                body["Project_Name"] = CSharpExpressionConverter.ConvertToken(bodyprojectName);
                bodypropCount++;
            }

            if (bodyprojectStartDateUt != null)
            {
                body["Project_Start_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodyprojectStartDateUt);
                bodypropCount++;
            }

            if (bodyqty != null)
            {
                body["Qty"] = CSharpExpressionConverter.ConvertToken(bodyqty);
                bodypropCount++;
            }

            if (bodyreleaseId != null)
            {
                body["Release_Id"] = CSharpExpressionConverter.ConvertToken(bodyreleaseId);
                bodypropCount++;
            }

            if (bodyrentalNetPrice != null)
            {
                body["Rental_Net_Price"] = CSharpExpressionConverter.ConvertToken(bodyrentalNetPrice);
                bodypropCount++;
            }

            if (bodyrentalNetPriceCurId != null)
            {
                body["Rental_Net_Price_Cur_Id"] = CSharpExpressionConverter.ConvertToken(bodyrentalNetPriceCurId);
                bodypropCount++;
            }

            if (bodyrequestOriginId != null)
            {
                body["Request_Origin_Id"] = CSharpExpressionConverter.ConvertToken(bodyrequestOriginId);
                bodypropCount++;
            }

            if (bodyrequestedChangeDateEnd != null)
            {
                body["Requested_Change_Date_End"] = CSharpExpressionConverter.ConvertToken(bodyrequestedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyrequestedChangeDateStart != null)
            {
                body["Requested_Change_Date_Start"] = CSharpExpressionConverter.ConvertToken(bodyrequestedChangeDateStart);
                bodypropCount++;
            }

            if (bodyrequestorId != null)
            {
                body["Requestor_Id"] = CSharpExpressionConverter.ConvertToken(bodyrequestorId);
                bodypropCount++;
            }

            if (bodyrequestorIpAddress != null)
            {
                body["Requestor_Ip_Address"] = CSharpExpressionConverter.ConvertToken(bodyrequestorIpAddress);
                bodypropCount++;
            }

            if (bodyrequestorPhone != null)
            {
                body["Requestor_Phone"] = CSharpExpressionConverter.ConvertToken(bodyrequestorPhone);
                bodypropCount++;
            }

            if (bodyriskAmount != null)
            {
                body["Risk_Amount"] = CSharpExpressionConverter.ConvertToken(bodyriskAmount);
                bodypropCount++;
            }

            if (bodyriskDescription != null)
            {
                body["Risk_Description"] = CSharpExpressionConverter.ConvertToken(bodyriskDescription);
                bodypropCount++;
            }

            if (bodyriskLevelId != null)
            {
                body["Risk_Level_Id"] = CSharpExpressionConverter.ConvertToken(bodyriskLevelId);
                bodypropCount++;
            }

            if (bodyrootCauseId != null)
            {
                body["Root_Cause_Id"] = CSharpExpressionConverter.ConvertToken(bodyrootCauseId);
                bodypropCount++;
            }

            if (bodysubmitDateUt != null)
            {
                body["Submit_Date_Ut"] = CSharpExpressionConverter.ConvertToken(bodysubmitDateUt);
                bodypropCount++;
            }

            if (bodytimeUsedToSolveRequest != null)
            {
                body["Time_Used_To_Solve_Request"] = CSharpExpressionConverter.ConvertToken(bodytimeUsedToSolveRequest);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/comment", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodydocumentsInputItem[]>> bodydocuments)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documents"] = CSharpExpressionConverter.ConvertToken(bodydocuments);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadAndAttachADocumentToARequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<int>> bodydoneById = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/restart", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodydoneById != null)
            {
                body["done_by_id"] = CSharpExpressionConverter.ConvertToken(bodydoneById);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RestartRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodydoneById = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/suspend", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodydoneById != null)
            {
                body["done_by_id"] = CSharpExpressionConverter.ConvertToken(bodydoneById);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SuspendRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyactionTypeId, Expression<Func<string>> bodyelapsedTime = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycontractualCost = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodygroupMail = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodystartDateUt = null, Expression<Func<string>> bodytimeCost = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/tasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyelapsedTime != null)
            {
                body["Elapsed_Time"] = CSharpExpressionConverter.ConvertToken(bodyelapsedTime);
                bodypropCount++;
            }

            bodypropCount++;
            body["action_type_id"] = CSharpExpressionConverter.ConvertToken(bodyactionTypeId);
            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = CSharpExpressionConverter.ConvertToken(bodyavailableField1);
                bodypropCount++;
            }

            if (bodyavailableField2 != null)
            {
                body["available_field_2"] = CSharpExpressionConverter.ConvertToken(bodyavailableField2);
                bodypropCount++;
            }

            if (bodyavailableField3 != null)
            {
                body["available_field_3"] = CSharpExpressionConverter.ConvertToken(bodyavailableField3);
                bodypropCount++;
            }

            if (bodyavailableField4 != null)
            {
                body["available_field_4"] = CSharpExpressionConverter.ConvertToken(bodyavailableField4);
                bodypropCount++;
            }

            if (bodyavailableField5 != null)
            {
                body["available_field_5"] = CSharpExpressionConverter.ConvertToken(bodyavailableField5);
                bodypropCount++;
            }

            if (bodyavailableField6 != null)
            {
                body["available_field_6"] = CSharpExpressionConverter.ConvertToken(bodyavailableField6);
                bodypropCount++;
            }

            if (bodycontractualCost != null)
            {
                body["contractual_cost"] = CSharpExpressionConverter.ConvertToken(bodycontractualCost);
                bodypropCount++;
            }

            if (bodycreationDateUt != null)
            {
                body["creation_date_ut"] = CSharpExpressionConverter.ConvertToken(bodycreationDateUt);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyendDateUt != null)
            {
                body["end_date_ut"] = CSharpExpressionConverter.ConvertToken(bodyendDateUt);
                bodypropCount++;
            }

            if (bodygroupMail != null)
            {
                body["group_mail"] = CSharpExpressionConverter.ConvertToken(bodygroupMail);
                bodypropCount++;
            }

            if (bodygroupName != null)
            {
                body["group_name"] = CSharpExpressionConverter.ConvertToken(bodygroupName);
                bodypropCount++;
            }

            if (bodystartDateUt != null)
            {
                body["start_date_ut"] = CSharpExpressionConverter.ConvertToken(bodystartDateUt);
                bodypropCount++;
            }

            if (bodytimeCost != null)
            {
                body["time_cost"] = CSharpExpressionConverter.ConvertToken(bodytimeCost);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.ConvertO(sort);
            if (maxRows != null)
                callPayload.Queries["max_rows"] = CSharpExpressionConverter.ConvertO(maxRows);
            return new ApiConnectionAction<ViewSlasListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla(Expression<Func<string>> account, Expression<Func<string>> slaId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(slaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewSlaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesAssetsResponse> ViewAllAtributesAssets(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllAtributesAssetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction CreateLinkBetweenAttributandAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(characteristicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateanAttributeofanAssetResponse> UpdateanAttributeofanAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId, Expression<Func<string>> bodydATA1 = null, Expression<Func<string>> bodydATA2 = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(characteristicId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydATA1 != null)
            {
                body["DATA_1"] = CSharpExpressionConverter.ConvertToken(bodydATA1);
                bodypropCount++;
            }

            if (bodydATA2 != null)
            {
                body["DATA_2"] = CSharpExpressionConverter.ConvertToken(bodydATA2);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateanAttributeofanAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIResponse> CreateCI(Expression<Func<bodyassetsInputItem2[]>> bodyassets = null)
        {
            var apiCallPath = "/api/v1/50006/assets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassets != null)
            {
                body["assets"] = CSharpExpressionConverter.ConvertToken(bodyassets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIunavailabilityResponse> CreateCIunavailability(Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateCIunavailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<EndCIunavailabilityResponse> EndCIunavailability(Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EndCIunavailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactonCIResponse> ViewlinksimpactonCI(Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacting", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewlinksimpactonCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactbyCIResponse> ViewlinksimpactbyCI(Expression<Func<string>> ciId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacted", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewlinksimpactbyCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewTicketStatusListResponse> ViewTicketStatusList(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewTicketStatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedTicketsResponse> ViewListProblemsAttachedTickets(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problem-links", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsAttachedTicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedATicketsResponse> ViewListProblemsAttachedATickets(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/problems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsAttachedATicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListTicketsAttachedtoaProblemResponse> ViewListTicketsAttachedtoaProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}/requests", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListTicketsAttachedtoaProblemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsResponse> ViewListQuestions(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsWithResponseResponse> ViewListQuestionsWithResponse(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionsWithResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewaQuestionResponse> ViewaQuestion(Expression<Func<string>> account, Expression<Func<string>> questionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewaQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllResponsesListQuestionsofaTicketResponse> ViewAllResponsesListQuestionsofaTicket(Expression<Func<string>> account, Expression<Func<string>> requestId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllResponsesListQuestionsofaTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewResponseQuestionTicketResponse> ViewResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewResponseQuestionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateResponseQuestionTicketResponse> CreateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyrESULT = null, Expression<Func<string>> bodyrESULTSTRINGEN = null, Expression<Func<string>> bodyrESULTSTRINGFR = null, Expression<Func<string>> bodyrESULTSTRINGSP = null, Expression<Func<string>> bodyrESULTSTRINGGE = null, Expression<Func<string>> bodyrESULTSTRINGIT = null, Expression<Func<string>> bodyrESULTSTRINGPO = null, Expression<Func<string>> bodyrESULTDATE = null, Expression<Func<string>> bodyrESULTNUMBER = null, Expression<Func<string>> bodyrESULTBIT = null, Expression<Func<string>> bodyrESULTORDER = null, Expression<Func<string>> bodyrESULTSTRINGL1 = null, Expression<Func<string>> bodyrESULTSTRINGL2 = null, Expression<Func<string>> bodyrESULTSTRINGL3 = null, Expression<Func<string>> bodyrESULTSTRINGL4 = null, Expression<Func<string>> bodyrESULTSTRINGL5 = null, Expression<Func<string>> bodyrESULTSTRINGL6 = null, Expression<Func<string>> bodyqUESTIONDISPLAYED = null, Expression<Func<string>> bodydOCUMENTID = null, Expression<Func<string>> bodyqUESTIONREQUIRED = null, Expression<Func<string>> bodyiSCONDITIONNAL = null, Expression<Func<string>> bodyrESULTDURATION = null, Expression<Func<string>> bodysYSQUESTIONNAIREID = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTQUESTIONNAIRE = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrESULT != null)
            {
                body["RESULT"] = CSharpExpressionConverter.ConvertToken(bodyrESULT);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGEN != null)
            {
                body["RESULT_STRING_EN"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGEN);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGFR != null)
            {
                body["RESULT_STRING_FR"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGFR);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGSP != null)
            {
                body["RESULT_STRING_SP"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGSP);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGGE != null)
            {
                body["RESULT_STRING_GE"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGGE);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGIT != null)
            {
                body["RESULT_STRING_IT"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGIT);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGPO != null)
            {
                body["RESULT_STRING_PO"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGPO);
                bodypropCount++;
            }

            if (bodyrESULTDATE != null)
            {
                body["RESULT_DATE"] = CSharpExpressionConverter.ConvertToken(bodyrESULTDATE);
                bodypropCount++;
            }

            if (bodyrESULTNUMBER != null)
            {
                body["RESULT_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyrESULTNUMBER);
                bodypropCount++;
            }

            if (bodyrESULTBIT != null)
            {
                body["RESULT_BIT"] = CSharpExpressionConverter.ConvertToken(bodyrESULTBIT);
                bodypropCount++;
            }

            if (bodyrESULTORDER != null)
            {
                body["RESULT_ORDER"] = CSharpExpressionConverter.ConvertToken(bodyrESULTORDER);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL1 != null)
            {
                body["RESULT_STRING_L1"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL1);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL2 != null)
            {
                body["RESULT_STRING_L2"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL2);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL3 != null)
            {
                body["RESULT_STRING_L3"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL3);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL4 != null)
            {
                body["RESULT_STRING_L4"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL4);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL5 != null)
            {
                body["RESULT_STRING_L5"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL5);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL6 != null)
            {
                body["RESULT_STRING_L6"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL6);
                bodypropCount++;
            }

            if (bodyqUESTIONDISPLAYED != null)
            {
                body["QUESTION_DISPLAYED"] = CSharpExpressionConverter.ConvertToken(bodyqUESTIONDISPLAYED);
                bodypropCount++;
            }

            if (bodydOCUMENTID != null)
            {
                body["DOCUMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodydOCUMENTID);
                bodypropCount++;
            }

            if (bodyqUESTIONREQUIRED != null)
            {
                body["QUESTION_REQUIRED"] = CSharpExpressionConverter.ConvertToken(bodyqUESTIONREQUIRED);
                bodypropCount++;
            }

            if (bodyiSCONDITIONNAL != null)
            {
                body["IS_CONDITIONNAL"] = CSharpExpressionConverter.ConvertToken(bodyiSCONDITIONNAL);
                bodypropCount++;
            }

            if (bodyrESULTDURATION != null)
            {
                body["RESULT_DURATION"] = CSharpExpressionConverter.ConvertToken(bodyrESULTDURATION);
                bodypropCount++;
            }

            if (bodysYSQUESTIONNAIREID != null)
            {
                body["SYS_QUESTIONNAIRE_ID"] = CSharpExpressionConverter.ConvertToken(bodysYSQUESTIONNAIREID);
                bodypropCount++;
            }

            if (bodyoRIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = CSharpExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                bodypropCount++;
            }

            if (bodylASTQUESTIONNAIRE != null)
            {
                body["LAST_QUESTIONNAIRE"] = CSharpExpressionConverter.ConvertToken(bodylASTQUESTIONNAIRE);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateResponseQuestionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateResponseQuestionTicketResponse> UpdateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyrESULT = null, Expression<Func<string>> bodyrESULTSTRINGEN = null, Expression<Func<string>> bodyrESULTSTRINGFR = null, Expression<Func<string>> bodyrESULTSTRINGSP = null, Expression<Func<string>> bodyrESULTSTRINGGE = null, Expression<Func<string>> bodyrESULTSTRINGIT = null, Expression<Func<string>> bodyrESULTSTRINGPO = null, Expression<Func<string>> bodyrESULTDATE = null, Expression<Func<string>> bodyrESULTNUMBER = null, Expression<Func<string>> bodyrESULTBIT = null, Expression<Func<string>> bodyrESULTORDER = null, Expression<Func<string>> bodyrESULTSTRINGL1 = null, Expression<Func<string>> bodyrESULTSTRINGL2 = null, Expression<Func<string>> bodyrESULTSTRINGL3 = null, Expression<Func<string>> bodyrESULTSTRINGL4 = null, Expression<Func<string>> bodyrESULTSTRINGL5 = null, Expression<Func<string>> bodyrESULTSTRINGL6 = null, Expression<Func<string>> bodyqUESTIONDISPLAYED = null, Expression<Func<string>> bodydOCUMENTID = null, Expression<Func<string>> bodyqUESTIONREQUIRED = null, Expression<Func<string>> bodyiSCONDITIONNAL = null, Expression<Func<string>> bodyrESULTDURATION = null, Expression<Func<string>> bodysYSQUESTIONNAIREID = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTQUESTIONNAIRE = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrESULT != null)
            {
                body["RESULT"] = CSharpExpressionConverter.ConvertToken(bodyrESULT);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGEN != null)
            {
                body["RESULT_STRING_EN"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGEN);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGFR != null)
            {
                body["RESULT_STRING_FR"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGFR);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGSP != null)
            {
                body["RESULT_STRING_SP"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGSP);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGGE != null)
            {
                body["RESULT_STRING_GE"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGGE);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGIT != null)
            {
                body["RESULT_STRING_IT"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGIT);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGPO != null)
            {
                body["RESULT_STRING_PO"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGPO);
                bodypropCount++;
            }

            if (bodyrESULTDATE != null)
            {
                body["RESULT_DATE"] = CSharpExpressionConverter.ConvertToken(bodyrESULTDATE);
                bodypropCount++;
            }

            if (bodyrESULTNUMBER != null)
            {
                body["RESULT_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyrESULTNUMBER);
                bodypropCount++;
            }

            if (bodyrESULTBIT != null)
            {
                body["RESULT_BIT"] = CSharpExpressionConverter.ConvertToken(bodyrESULTBIT);
                bodypropCount++;
            }

            if (bodyrESULTORDER != null)
            {
                body["RESULT_ORDER"] = CSharpExpressionConverter.ConvertToken(bodyrESULTORDER);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL1 != null)
            {
                body["RESULT_STRING_L1"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL1);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL2 != null)
            {
                body["RESULT_STRING_L2"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL2);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL3 != null)
            {
                body["RESULT_STRING_L3"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL3);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL4 != null)
            {
                body["RESULT_STRING_L4"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL4);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL5 != null)
            {
                body["RESULT_STRING_L5"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL5);
                bodypropCount++;
            }

            if (bodyrESULTSTRINGL6 != null)
            {
                body["RESULT_STRING_L6"] = CSharpExpressionConverter.ConvertToken(bodyrESULTSTRINGL6);
                bodypropCount++;
            }

            if (bodyqUESTIONDISPLAYED != null)
            {
                body["QUESTION_DISPLAYED"] = CSharpExpressionConverter.ConvertToken(bodyqUESTIONDISPLAYED);
                bodypropCount++;
            }

            if (bodydOCUMENTID != null)
            {
                body["DOCUMENT_ID"] = CSharpExpressionConverter.ConvertToken(bodydOCUMENTID);
                bodypropCount++;
            }

            if (bodyqUESTIONREQUIRED != null)
            {
                body["QUESTION_REQUIRED"] = CSharpExpressionConverter.ConvertToken(bodyqUESTIONREQUIRED);
                bodypropCount++;
            }

            if (bodyiSCONDITIONNAL != null)
            {
                body["IS_CONDITIONNAL"] = CSharpExpressionConverter.ConvertToken(bodyiSCONDITIONNAL);
                bodypropCount++;
            }

            if (bodyrESULTDURATION != null)
            {
                body["RESULT_DURATION"] = CSharpExpressionConverter.ConvertToken(bodyrESULTDURATION);
                bodypropCount++;
            }

            if (bodysYSQUESTIONNAIREID != null)
            {
                body["SYS_QUESTIONNAIRE_ID"] = CSharpExpressionConverter.ConvertToken(bodysYSQUESTIONNAIREID);
                bodypropCount++;
            }

            if (bodyoRIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = CSharpExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                bodypropCount++;
            }

            if (bodylASTQUESTIONNAIRE != null)
            {
                body["LAST_QUESTIONNAIRE"] = CSharpExpressionConverter.ConvertToken(bodylASTQUESTIONNAIRE);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateResponseQuestionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionnairesResponse> ViewListQuestionnaires(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionnairesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewQuestionnaireResponse> ViewQuestionnaire(Expression<Func<string>> account, Expression<Func<string>> questionnaireId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionnaireId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsResponse> ViewListProblems(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewProblemResponse> ViewProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewProblemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListNewsResponse> ViewListNews(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateNewsResponse> CreateNews(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewNewsResponse> ViewNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateNewsResponse> UpdateNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UpdateNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListActionsResponse> ViewListActions(Expression<Func<string>> account)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListActionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateActionTicketResponse> CreateActionTicket(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyaCTIONNUMBER = null, Expression<Func<string>> bodyaSSETID = null, Expression<Func<string>> bodypARENTACTIONID = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodydONEBYID = null, Expression<Func<string>> bodyvALIDATORID = null, Expression<Func<string>> bodyaCTIONLABELEN = null, Expression<Func<string>> bodytABLENAME = null, Expression<Func<string>> bodyfIELDNAME = null, Expression<Func<string>> bodyoLDVALUE = null, Expression<Func<string>> bodynEWVALUE = null, Expression<Func<string>> bodydELETEACTION = null, Expression<Func<string>> bodyaUTOMATICACTION = null, Expression<Func<string>> bodypROCESSSTEPID = null, Expression<Func<string>> bodyrEQUESTID = null, Expression<Func<string>> bodydESCRIPTION = null, Expression<Func<string>> bodynETCHARGE = null, Expression<Func<string>> bodynETCHARGECURID = null, Expression<Func<string>> bodyrESOLUTION = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodysUPPORTSTAFFID = null, Expression<Func<string>> bodycONTACTID = null, Expression<Func<string>> bodyeXPECTEDENDDATEUT = null, Expression<Func<string>> bodycOMMENT = null, Expression<Func<string>> bodysTARTDATEUT = null, Expression<Func<string>> bodyeNDDATEUT = null, Expression<Func<string>> bodyrENEWALDATEUT = null, Expression<Func<string>> bodyeXPECTEDSTARTDATEUT = null, Expression<Func<string>> bodycREATIONDATEUT = null, Expression<Func<string>> bodyaPPLICATIONDATEUT = null, Expression<Func<string>> bodywIZARDGUID = null, Expression<Func<string>> bodygROUPID = null, Expression<Func<string>> bodyaCTIONLABELFR = null, Expression<Func<string>> bodyaCTIONLABELSP = null, Expression<Func<string>> bodyaCTIONLABELGE = null, Expression<Func<string>> bodyaCTIONLABELIT = null, Expression<Func<string>> bodyaCTIONLABELPO = null, Expression<Func<string>> bodykNOWNPROBLEMID = null, Expression<Func<string>> bodymAXINTERVENTIONDATEUT = null, Expression<Func<string>> bodyeLAPSEDTIME = null, Expression<Func<string>> bodypRIORITYID = null, Expression<Func<string>> bodytAXID = null, Expression<Func<string>> bodysTATUSIDONCREATE = null, Expression<Func<string>> bodysTATUSIDONTERMINATE = null, Expression<Func<string>> bodyaCTIONTYPEID = null, Expression<Func<string>> bodydELAY = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodytIMEUSEDTOCOMPLETEACTION = null, Expression<Func<string>> bodycONTRACTUALCOST = null, Expression<Func<string>> bodycONTRACTUALCOSTCURID = null, Expression<Func<string>> bodytIMECOST = null, Expression<Func<string>> bodytIMECOSTCURID = null, Expression<Func<string>> bodyoRIGINACTIONID = null, Expression<Func<string>> bodywORKFLOWVALUE = null, Expression<Func<string>> bodycONTINUITYPLANID = null, Expression<Func<string>> bodycATEGORYTESTID = null, Expression<Func<string>> bodywORKFLOWID = null, Expression<Func<string>> bodyeXITVALUE = null, Expression<Func<string>> bodymAXRESOLUTIONDATEUT = null, Expression<Func<string>> bodypERCENTCOMPLETE = null, Expression<Func<string>> bodyeXPECTEDDURATION = null, Expression<Func<string>> bodywBSTASK = null, Expression<Func<string>> bodytASKPERSONCOSTPERHOUR = null, Expression<Func<string>> bodytASKPLANNEDBUDGET = null, Expression<Func<string>> bodyeSTIMATEDNETCHARGE = null, Expression<Func<string>> bodypREVIOUSSIBLINGID = null, Expression<Func<string>> bodyaCTIONLABELL1 = null, Expression<Func<string>> bodyaCTIONLABELL2 = null, Expression<Func<string>> bodyaCTIONLABELL3 = null, Expression<Func<string>> bodyaCTIONLABELL4 = null, Expression<Func<string>> bodyaCTIONLABELL5 = null, Expression<Func<string>> bodyaCTIONLABELL6 = null, Expression<Func<string>> bodyhISTORYID = null, Expression<Func<string>> bodytOTRUNC = null, Expression<Func<string>> bodysTAGEID = null, Expression<Func<string>> bodyiSLOCKEDPROGRESSPOINT = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodyeLASTDATESUPDATE = null, Expression<Func<string>> bodybILLEDTIME = null, Expression<Func<string>> bodyiSBILLINGREVIEWED = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaCTIONNUMBER != null)
            {
                body["ACTION_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONNUMBER);
                bodypropCount++;
            }

            if (bodyaSSETID != null)
            {
                body["ASSET_ID"] = CSharpExpressionConverter.ConvertToken(bodyaSSETID);
                bodypropCount++;
            }

            if (bodypARENTACTIONID != null)
            {
                body["PARENT_ACTION_ID"] = CSharpExpressionConverter.ConvertToken(bodypARENTACTIONID);
                bodypropCount++;
            }

            if (bodysUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = CSharpExpressionConverter.ConvertToken(bodysUPPLIERID);
                bodypropCount++;
            }

            if (bodydONEBYID != null)
            {
                body["DONE_BY_ID"] = CSharpExpressionConverter.ConvertToken(bodydONEBYID);
                bodypropCount++;
            }

            if (bodyvALIDATORID != null)
            {
                body["VALIDATOR_ID"] = CSharpExpressionConverter.ConvertToken(bodyvALIDATORID);
                bodypropCount++;
            }

            if (bodyaCTIONLABELEN != null)
            {
                body["ACTION_LABEL_EN"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELEN);
                bodypropCount++;
            }

            if (bodytABLENAME != null)
            {
                body["TABLE_NAME"] = CSharpExpressionConverter.ConvertToken(bodytABLENAME);
                bodypropCount++;
            }

            if (bodyfIELDNAME != null)
            {
                body["FIELD_NAME"] = CSharpExpressionConverter.ConvertToken(bodyfIELDNAME);
                bodypropCount++;
            }

            if (bodyoLDVALUE != null)
            {
                body["OLD_VALUE"] = CSharpExpressionConverter.ConvertToken(bodyoLDVALUE);
                bodypropCount++;
            }

            if (bodynEWVALUE != null)
            {
                body["NEW_VALUE"] = CSharpExpressionConverter.ConvertToken(bodynEWVALUE);
                bodypropCount++;
            }

            if (bodydELETEACTION != null)
            {
                body["DELETE_ACTION"] = CSharpExpressionConverter.ConvertToken(bodydELETEACTION);
                bodypropCount++;
            }

            if (bodyaUTOMATICACTION != null)
            {
                body["AUTOMATIC_ACTION"] = CSharpExpressionConverter.ConvertToken(bodyaUTOMATICACTION);
                bodypropCount++;
            }

            if (bodypROCESSSTEPID != null)
            {
                body["PROCESS_STEP_ID"] = CSharpExpressionConverter.ConvertToken(bodypROCESSSTEPID);
                bodypropCount++;
            }

            if (bodyrEQUESTID != null)
            {
                body["REQUEST_ID"] = CSharpExpressionConverter.ConvertToken(bodyrEQUESTID);
                bodypropCount++;
            }

            if (bodydESCRIPTION != null)
            {
                body["DESCRIPTION"] = CSharpExpressionConverter.ConvertToken(bodydESCRIPTION);
                bodypropCount++;
            }

            if (bodynETCHARGE != null)
            {
                body["NET_CHARGE"] = CSharpExpressionConverter.ConvertToken(bodynETCHARGE);
                bodypropCount++;
            }

            if (bodynETCHARGECURID != null)
            {
                body["NET_CHARGE_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodynETCHARGECURID);
                bodypropCount++;
            }

            if (bodyrESOLUTION != null)
            {
                body["RESOLUTION"] = CSharpExpressionConverter.ConvertToken(bodyrESOLUTION);
                bodypropCount++;
            }

            if (bodylOCATIONID != null)
            {
                body["LOCATION_ID"] = CSharpExpressionConverter.ConvertToken(bodylOCATIONID);
                bodypropCount++;
            }

            if (bodysUPPORTSTAFFID != null)
            {
                body["SUPPORT_STAFF_ID"] = CSharpExpressionConverter.ConvertToken(bodysUPPORTSTAFFID);
                bodypropCount++;
            }

            if (bodycONTACTID != null)
            {
                body["CONTACT_ID"] = CSharpExpressionConverter.ConvertToken(bodycONTACTID);
                bodypropCount++;
            }

            if (bodyeXPECTEDENDDATEUT != null)
            {
                body["EXPECTED_END_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodyeXPECTEDENDDATEUT);
                bodypropCount++;
            }

            if (bodycOMMENT != null)
            {
                body["COMMENT"] = CSharpExpressionConverter.ConvertToken(bodycOMMENT);
                bodypropCount++;
            }

            if (bodysTARTDATEUT != null)
            {
                body["START_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodysTARTDATEUT);
                bodypropCount++;
            }

            if (bodyeNDDATEUT != null)
            {
                body["END_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodyeNDDATEUT);
                bodypropCount++;
            }

            if (bodyrENEWALDATEUT != null)
            {
                body["RENEWAL_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodyrENEWALDATEUT);
                bodypropCount++;
            }

            if (bodyeXPECTEDSTARTDATEUT != null)
            {
                body["EXPECTED_START_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodyeXPECTEDSTARTDATEUT);
                bodypropCount++;
            }

            if (bodycREATIONDATEUT != null)
            {
                body["CREATION_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodycREATIONDATEUT);
                bodypropCount++;
            }

            if (bodyaPPLICATIONDATEUT != null)
            {
                body["APPLICATION_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodyaPPLICATIONDATEUT);
                bodypropCount++;
            }

            if (bodywIZARDGUID != null)
            {
                body["WIZARD_GUID"] = CSharpExpressionConverter.ConvertToken(bodywIZARDGUID);
                bodypropCount++;
            }

            if (bodygROUPID != null)
            {
                body["GROUP_ID"] = CSharpExpressionConverter.ConvertToken(bodygROUPID);
                bodypropCount++;
            }

            if (bodyaCTIONLABELFR != null)
            {
                body["ACTION_LABEL_FR"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELFR);
                bodypropCount++;
            }

            if (bodyaCTIONLABELSP != null)
            {
                body["ACTION_LABEL_SP"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELSP);
                bodypropCount++;
            }

            if (bodyaCTIONLABELGE != null)
            {
                body["ACTION_LABEL_GE"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELGE);
                bodypropCount++;
            }

            if (bodyaCTIONLABELIT != null)
            {
                body["ACTION_LABEL_IT"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELIT);
                bodypropCount++;
            }

            if (bodyaCTIONLABELPO != null)
            {
                body["ACTION_LABEL_PO"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELPO);
                bodypropCount++;
            }

            if (bodykNOWNPROBLEMID != null)
            {
                body["KNOWN_PROBLEM_ID"] = CSharpExpressionConverter.ConvertToken(bodykNOWNPROBLEMID);
                bodypropCount++;
            }

            if (bodymAXINTERVENTIONDATEUT != null)
            {
                body["MAX_INTERVENTION_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodymAXINTERVENTIONDATEUT);
                bodypropCount++;
            }

            if (bodyeLAPSEDTIME != null)
            {
                body["ELAPSED_TIME"] = CSharpExpressionConverter.ConvertToken(bodyeLAPSEDTIME);
                bodypropCount++;
            }

            if (bodypRIORITYID != null)
            {
                body["PRIORITY_ID"] = CSharpExpressionConverter.ConvertToken(bodypRIORITYID);
                bodypropCount++;
            }

            if (bodytAXID != null)
            {
                body["TAX_ID"] = CSharpExpressionConverter.ConvertToken(bodytAXID);
                bodypropCount++;
            }

            if (bodysTATUSIDONCREATE != null)
            {
                body["STATUS_ID_ON_CREATE"] = CSharpExpressionConverter.ConvertToken(bodysTATUSIDONCREATE);
                bodypropCount++;
            }

            if (bodysTATUSIDONTERMINATE != null)
            {
                body["STATUS_ID_ON_TERMINATE"] = CSharpExpressionConverter.ConvertToken(bodysTATUSIDONTERMINATE);
                bodypropCount++;
            }

            if (bodyaCTIONTYPEID != null)
            {
                body["ACTION_TYPE_ID"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONTYPEID);
                bodypropCount++;
            }

            if (bodydELAY != null)
            {
                body["DELAY"] = CSharpExpressionConverter.ConvertToken(bodydELAY);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyaVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = CSharpExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodytIMEUSEDTOCOMPLETEACTION != null)
            {
                body["TIME_USED_TO_COMPLETE_ACTION"] = CSharpExpressionConverter.ConvertToken(bodytIMEUSEDTOCOMPLETEACTION);
                bodypropCount++;
            }

            if (bodycONTRACTUALCOST != null)
            {
                body["CONTRACTUAL_COST"] = CSharpExpressionConverter.ConvertToken(bodycONTRACTUALCOST);
                bodypropCount++;
            }

            if (bodycONTRACTUALCOSTCURID != null)
            {
                body["CONTRACTUAL_COST_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodycONTRACTUALCOSTCURID);
                bodypropCount++;
            }

            if (bodytIMECOST != null)
            {
                body["TIME_COST"] = CSharpExpressionConverter.ConvertToken(bodytIMECOST);
                bodypropCount++;
            }

            if (bodytIMECOSTCURID != null)
            {
                body["TIME_COST_CUR_ID"] = CSharpExpressionConverter.ConvertToken(bodytIMECOSTCURID);
                bodypropCount++;
            }

            if (bodyoRIGINACTIONID != null)
            {
                body["ORIGIN_ACTION_ID"] = CSharpExpressionConverter.ConvertToken(bodyoRIGINACTIONID);
                bodypropCount++;
            }

            if (bodywORKFLOWVALUE != null)
            {
                body["WORKFLOW_VALUE"] = CSharpExpressionConverter.ConvertToken(bodywORKFLOWVALUE);
                bodypropCount++;
            }

            if (bodycONTINUITYPLANID != null)
            {
                body["CONTINUITY_PLAN_ID"] = CSharpExpressionConverter.ConvertToken(bodycONTINUITYPLANID);
                bodypropCount++;
            }

            if (bodycATEGORYTESTID != null)
            {
                body["CATEGORY_TEST_ID"] = CSharpExpressionConverter.ConvertToken(bodycATEGORYTESTID);
                bodypropCount++;
            }

            if (bodywORKFLOWID != null)
            {
                body["WORKFLOW_ID"] = CSharpExpressionConverter.ConvertToken(bodywORKFLOWID);
                bodypropCount++;
            }

            if (bodyeXITVALUE != null)
            {
                body["EXIT_VALUE"] = CSharpExpressionConverter.ConvertToken(bodyeXITVALUE);
                bodypropCount++;
            }

            if (bodymAXRESOLUTIONDATEUT != null)
            {
                body["MAX_RESOLUTION_DATE_UT"] = CSharpExpressionConverter.ConvertToken(bodymAXRESOLUTIONDATEUT);
                bodypropCount++;
            }

            if (bodypERCENTCOMPLETE != null)
            {
                body["PERCENT_COMPLETE"] = CSharpExpressionConverter.ConvertToken(bodypERCENTCOMPLETE);
                bodypropCount++;
            }

            if (bodyeXPECTEDDURATION != null)
            {
                body["EXPECTED_DURATION"] = CSharpExpressionConverter.ConvertToken(bodyeXPECTEDDURATION);
                bodypropCount++;
            }

            if (bodywBSTASK != null)
            {
                body["WBS_TASK"] = CSharpExpressionConverter.ConvertToken(bodywBSTASK);
                bodypropCount++;
            }

            if (bodytASKPERSONCOSTPERHOUR != null)
            {
                body["TASK_PERSON_COST_PER_HOUR"] = CSharpExpressionConverter.ConvertToken(bodytASKPERSONCOSTPERHOUR);
                bodypropCount++;
            }

            if (bodytASKPLANNEDBUDGET != null)
            {
                body["TASK_PLANNED_BUDGET"] = CSharpExpressionConverter.ConvertToken(bodytASKPLANNEDBUDGET);
                bodypropCount++;
            }

            if (bodyeSTIMATEDNETCHARGE != null)
            {
                body["ESTIMATED_NET_CHARGE"] = CSharpExpressionConverter.ConvertToken(bodyeSTIMATEDNETCHARGE);
                bodypropCount++;
            }

            if (bodypREVIOUSSIBLINGID != null)
            {
                body["PREVIOUS_SIBLING_ID"] = CSharpExpressionConverter.ConvertToken(bodypREVIOUSSIBLINGID);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL1 != null)
            {
                body["ACTION_LABEL_L1"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL1);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL2 != null)
            {
                body["ACTION_LABEL_L2"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL2);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL3 != null)
            {
                body["ACTION_LABEL_L3"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL3);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL4 != null)
            {
                body["ACTION_LABEL_L4"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL4);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL5 != null)
            {
                body["ACTION_LABEL_L5"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL5);
                bodypropCount++;
            }

            if (bodyaCTIONLABELL6 != null)
            {
                body["ACTION_LABEL_L6"] = CSharpExpressionConverter.ConvertToken(bodyaCTIONLABELL6);
                bodypropCount++;
            }

            if (bodyhISTORYID != null)
            {
                body["HISTORY_ID"] = CSharpExpressionConverter.ConvertToken(bodyhISTORYID);
                bodypropCount++;
            }

            if (bodytOTRUNC != null)
            {
                body["TO_TRUNC"] = CSharpExpressionConverter.ConvertToken(bodytOTRUNC);
                bodypropCount++;
            }

            if (bodysTAGEID != null)
            {
                body["STAGE_ID"] = CSharpExpressionConverter.ConvertToken(bodysTAGEID);
                bodypropCount++;
            }

            if (bodyiSLOCKEDPROGRESSPOINT != null)
            {
                body["IS_LOCKED_PROGRESS_POINT"] = CSharpExpressionConverter.ConvertToken(bodyiSLOCKEDPROGRESSPOINT);
                bodypropCount++;
            }

            if (bodyoRIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = CSharpExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                bodypropCount++;
            }

            if (bodylASTUPDATE != null)
            {
                body["LAST_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodylASTUPDATE);
                bodypropCount++;
            }

            if (bodyeLASTDATESUPDATE != null)
            {
                body["E_LAST_DATES_UPDATE"] = CSharpExpressionConverter.ConvertToken(bodyeLASTDATESUPDATE);
                bodypropCount++;
            }

            if (bodybILLEDTIME != null)
            {
                body["BILLED_TIME"] = CSharpExpressionConverter.ConvertToken(bodybILLEDTIME);
                bodypropCount++;
            }

            if (bodyiSBILLINGREVIEWED != null)
            {
                body["IS_BILLING_REVIEWED"] = CSharpExpressionConverter.ConvertToken(bodyiSBILLINGREVIEWED);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateActionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesofanAssetsResponse> ViewAllAtributesofanAssets(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllAtributesofanAssetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> documentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateCIResponse> UpdateCI(Expression<Func<string>> account, Expression<Func<string>> ciId, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodypurchasePrice = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyestimatedPercentageUse = null, Expression<Func<string>> bodyinstallationDate = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassetLabel != null)
            {
                body["asset_label"] = CSharpExpressionConverter.ConvertToken(bodyassetLabel);
                bodypropCount++;
            }

            if (bodypurchasePrice != null)
            {
                body["purchase_price"] = CSharpExpressionConverter.ConvertToken(bodypurchasePrice);
                bodypropCount++;
            }

            if (bodyautomaticRenewal != null)
            {
                body["automatic_renewal"] = CSharpExpressionConverter.ConvertToken(bodyautomaticRenewal);
                bodypropCount++;
            }

            if (bodyestimatedPercentageUse != null)
            {
                body["estimated_percentage_use"] = CSharpExpressionConverter.ConvertToken(bodyestimatedPercentageUse);
                bodypropCount++;
            }

            if (bodyinstallationDate != null)
            {
                body["installation_date"] = CSharpExpressionConverter.ConvertToken(bodyinstallationDate);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = CSharpExpressionConverter.ConvertToken(bodyavailableField1);
                bodypropCount++;
            }

            if (bodycommentAsset != null)
            {
                body["comment_asset"] = CSharpExpressionConverter.ConvertToken(bodycommentAsset);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateCIResponse>(callPayload);
        }
    }

    public class EasyvistaservicemanaTriggers([ConnectionName] string connectionId)
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

    public class UpdateDepartmentResponse
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

    public class UpdateLocationResponse
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
        public string[] Documents { get; set; }
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

    public class CreateTaskResponse
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

    public class ViewAllAtributesAssetsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAllAtributesAssetsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewAllAtributesAssetsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("CHARACTERISTIC_ID")]
        public string CHARACTERISTICID { get; set; }

        [JsonProperty("DATA_1")]
        public string DATA1 { get; set; }

        [JsonProperty("LAST_INVENTORY_DATE")]
        public string LASTINVENTORYDATE { get; set; }
        public ViewAllAtributesAssetsResponseRecordsTypeItemCHARACTERISTICType CHARACTERISTIC { get; set; }
        public ViewAllAtributesAssetsResponseRecordsTypeItemASSETType ASSET { get; set; }
    }

    public class ViewAllAtributesAssetsResponseRecordsTypeItemCHARACTERISTICType
    {
        [JsonProperty("CHARACTERISTIC_EN")]
        public string CHARACTERISTICEN { get; set; }

        [JsonProperty("CHARACTERISTIC_FR")]
        public string CHARACTERISTICFR { get; set; }
        public string HREF { get; set; }

        [JsonProperty("CHARACTERISTIC_ID")]
        public string CHARACTERISTICID { get; set; }
    }

    public class ViewAllAtributesAssetsResponseRecordsTypeItemASSETType
    {
        public string HREF { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string ASSETLABEL { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string ENDOFWARANTY { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string INSTALLATIONDATE { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PURCHASEDATE { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SERIALNUMBER { get; set; }
    }

    public class UpdateanAttributeofanAssetResponse
    {
        public string HREF { get; set; }
    }

    public class CreateCIResponse
    {
        public string HREF { get; set; }
    }

    public class bodyassetsInputItem2
    {
        [JsonProperty("catalog_id")]
        public int CatalogId { get; set; }

        [JsonProperty("asset_tag")]
        public string AssetTag { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("charge_back")]
        public string ChargeBack { get; set; }

        [JsonProperty("installation_date")]
        public string InstallationDate { get; set; }

        [JsonProperty("IS_CI")]
        public int ISCI { get; set; }

        [JsonProperty("CI_STATUS_ID")]
        public int CISTATUSID { get; set; }

        [JsonProperty("comment_asset")]
        public string CommentAsset { get; set; }
    }

    public class CreateCIunavailabilityResponse
    {
        public string HREF { get; set; }

        [JsonProperty("impacted")]
        public CreateCIunavailabilityResponseImpactedTypeItem[] Impacted { get; set; }
    }

    public class CreateCIunavailabilityResponseImpactedTypeItem
    {
        public string HREF { get; set; }
    }

    public class EndCIunavailabilityResponse
    {
        public string HREF { get; set; }

        [JsonProperty("impacted")]
        public EndCIunavailabilityResponseImpactedTypeItem[] Impacted { get; set; }
    }

    public class EndCIunavailabilityResponseImpactedTypeItem
    {
        public string HREF { get; set; }
    }

    public class ViewlinksimpactonCIResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewlinksimpactonCIResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewlinksimpactonCIResponseRecordsTypeItem
    {
        public string HREF { get; set; }
        public string BLOCKING { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string CHILDCIID { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string PARENTCIID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RELATIONTYPEID { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewlinksimpactonCIResponseRecordsTypeItemRELATIONTYPEType RELATIONTYPE { get; set; }
    }

    public class ViewlinksimpactonCIResponseRecordsTypeItemRELATIONTYPEType
    {
        [JsonProperty("REFERENCE_FR")]
        public string REFERENCEFR { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string REFERENCEID { get; set; }
    }

    public class ViewlinksimpactbyCIResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewlinksimpactbyCIResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewlinksimpactbyCIResponseRecordsTypeItem
    {
        public string HREF { get; set; }
        public string BLOCKING { get; set; }

        [JsonProperty("CHILD_CI_ID")]
        public string CHILDCIID { get; set; }

        [JsonProperty("PARENT_CI_ID")]
        public string PARENTCIID { get; set; }

        [JsonProperty("PARENT_HREF")]
        public string PARENTHREF { get; set; }

        [JsonProperty("RELATION_TYPE_ID")]
        public string RELATIONTYPEID { get; set; }

        [JsonProperty("RELATION_TYPE")]
        public ViewlinksimpactbyCIResponseRecordsTypeItemRELATIONTYPEType RELATIONTYPE { get; set; }
    }

    public class ViewlinksimpactbyCIResponseRecordsTypeItemRELATIONTYPEType
    {
        [JsonProperty("REFERENCE_FR")]
        public string REFERENCEFR { get; set; }

        [JsonProperty("REFERENCE_ID")]
        public string REFERENCEID { get; set; }
    }

    public class ViewTicketStatusListResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewTicketStatusListResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewTicketStatusListResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("STATUS_EN")]
        public string STATUSEN { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string STATUSGUID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }
    }

    public class ViewListProblemsAttachedTicketsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListProblemsAttachedTicketsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListProblemsAttachedTicketsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public ViewListProblemsAttachedTicketsResponseRecordsTypeItemPROBLEMType PROBLEM { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }
    }

    public class ViewListProblemsAttachedTicketsResponseRecordsTypeItemPROBLEMType
    {
        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_PATH")]
        public string ANALYTICALCHARGEPATH { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_ID")]
        public string ANALYTICALCHARGEID { get; set; }

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

        [JsonProperty("CI_ID")]
        public string CIID { get; set; }

        [JsonProperty("CLICK_2_GET_INSTALL_RESULT")]
        public string CLICK2GETINSTALLRESULT { get; set; }
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemCOMMENTType COMMENT { get; set; }

        [JsonProperty("CONTINUITY_PLAN_ID")]
        public string CONTINUITYPLANID { get; set; }

        [JsonProperty("COST_CENTER_ID")]
        public string COSTCENTERID { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CREATIONDATEUT { get; set; }
        public string DELAY { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DYNAMIC_DETAILS")]
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemDYNAMICDETAILSType DYNAMICDETAILS { get; set; }

        [JsonProperty("E_ALERT_CODE")]
        public string EALERTCODE { get; set; }

        [JsonProperty("E_COST")]
        public string ECOST { get; set; }

        [JsonProperty("E_DELAY")]
        public string EDELAY { get; set; }

        [JsonProperty("E_LAST_DATES_UPDATE")]
        public string ELASTDATESUPDATE { get; set; }

        [JsonProperty("E_SENTIMENT_ANALYSIS")]
        public string ESENTIMENTANALYSIS { get; set; }

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

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("IMPUTATION_DATE")]
        public string IMPUTATIONDATE { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_PATH")]
        public string INITIALSDCATALOGPATH { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_ID")]
        public string INITIALSDCATALOGID { get; set; }

        [JsonProperty("IS_FINANCIAL_COMPTED")]
        public string ISFINANCIALCOMPTED { get; set; }

        [JsonProperty("IS_MAJOR_INCIDENT")]
        public string ISMAJORINCIDENT { get; set; }

        [JsonProperty("IS_TEMPLATE")]
        public string ISTEMPLATE { get; set; }

        [JsonProperty("KBASE_ID")]
        public string KBASEID { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_PATH")]
        public string KNOWNPROBLEMSPATH { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("LAST_DONE_BY_ID")]
        public string LASTDONEBYID { get; set; }

        [JsonProperty("LAST_GROUP_ID")]
        public string LASTGROUPID { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

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

        [JsonProperty("RECIPIENT_ID")]
        public string RECIPIENTID { get; set; }

        [JsonProperty("RELEASE_ID")]
        public string RELEASEID { get; set; }

        [JsonProperty("RENTAL_NET_PRICE")]
        public string RENTALNETPRICE { get; set; }

        [JsonProperty("RENTAL_NET_PRICE_CUR_ID")]
        public string RENTALNETPRICECURID { get; set; }

        [JsonProperty("REOPEN_PROCESSING")]
        public string REOPENPROCESSING { get; set; }

        [JsonProperty("REQUALIFICATION_PROCESSING")]
        public string REQUALIFICATIONPROCESSING { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("REQUEST_ORIGIN_ID")]
        public string REQUESTORIGINID { get; set; }

        [JsonProperty("REQUEST_PROJECT_ID")]
        public string REQUESTPROJECTID { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_END")]
        public string REQUESTEDCHANGEDATEEND { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_START")]
        public string REQUESTEDCHANGEDATESTART { get; set; }

        [JsonProperty("REQUESTOR_FEEDBACK")]
        public string REQUESTORFEEDBACK { get; set; }

        [JsonProperty("REQUESTOR_ID")]
        public string REQUESTORID { get; set; }

        [JsonProperty("REQUESTOR_IP_ADDRESS")]
        public string REQUESTORIPADDRESS { get; set; }

        [JsonProperty("REQUESTOR_PHONE")]
        public string REQUESTORPHONE { get; set; }

        [JsonProperty("REQUIRED_DOWNTIME")]
        public string REQUIREDDOWNTIME { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("RISK_AMOUNT")]
        public string RISKAMOUNT { get; set; }

        [JsonProperty("RISK_DESCRIPTION")]
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemRISKDESCRIPTIONType RISKDESCRIPTION { get; set; }

        [JsonProperty("RISK_LEVEL_ID")]
        public string RISKLEVELID { get; set; }

        [JsonProperty("ROOT_CAUSE_ID")]
        public string ROOTCAUSEID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SEVERITY_ID")]
        public string SEVERITYID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }

        [JsonProperty("SUBMITTED_BY")]
        public string SUBMITTEDBY { get; set; }

        [JsonProperty("SYSTEM_AFFECTED")]
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemSYSTEMAFFECTEDType SYSTEMAFFECTED { get; set; }

        [JsonProperty("SYSTEM_ID")]
        public string SYSTEMID { get; set; }

        [JsonProperty("TIME_USED_TO_DELIVER_FEEDBACK")]
        public string TIMEUSEDTODELIVERFEEDBACK { get; set; }

        [JsonProperty("TIME_USED_TO_SOLVE_REQUEST")]
        public string TIMEUSEDTOSOLVEREQUEST { get; set; }
        public string TITLE { get; set; }

        [JsonProperty("URGENCY_ID")]
        public string URGENCYID { get; set; }

        [JsonProperty("VALIDATION_LEVEL_REQUIRED")]
        public string VALIDATIONLEVELREQUIRED { get; set; }

        [JsonProperty("WAVE_ID_TARGET")]
        public string WAVEIDTARGET { get; set; }
        public ViewListProblemsAttachedATicketsResponseRecordsTypeItemREQUESTType REQUEST { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemDYNAMICDETAILSType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemRISKDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemSYSTEMAFFECTEDType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsAttachedATicketsResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponse
    {
        public string HREF { get; set; }

        [JsonProperty("recordcount")]
        public int Recordcount { get; set; }

        [JsonProperty("previouspage")]
        public int Previouspage { get; set; }

        [JsonProperty("nextpage")]
        public int Nextpage { get; set; }

        [JsonProperty("records")]
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_PATH")]
        public string ANALYTICALCHARGEPATH { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_ID")]
        public string ANALYTICALCHARGEID { get; set; }

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

        [JsonProperty("CI_ID")]
        public string CIID { get; set; }

        [JsonProperty("CLICK_2_GET_INSTALL_RESULT")]
        public string CLICK2GETINSTALLRESULT { get; set; }
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemCOMMENTType COMMENT { get; set; }

        [JsonProperty("CONTINUITY_PLAN_ID")]
        public string CONTINUITYPLANID { get; set; }

        [JsonProperty("COST_CENTER_ID")]
        public string COSTCENTERID { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CREATIONDATEUT { get; set; }
        public string DELAY { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DYNAMIC_DETAILS")]
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemDYNAMICDETAILSType DYNAMICDETAILS { get; set; }

        [JsonProperty("E_ALERT_CODE")]
        public string EALERTCODE { get; set; }

        [JsonProperty("E_COST")]
        public string ECOST { get; set; }

        [JsonProperty("E_DELAY")]
        public string EDELAY { get; set; }

        [JsonProperty("E_LAST_DATES_UPDATE")]
        public string ELASTDATESUPDATE { get; set; }

        [JsonProperty("E_SENTIMENT_ANALYSIS")]
        public string ESENTIMENTANALYSIS { get; set; }

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

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("IMPUTATION_DATE")]
        public string IMPUTATIONDATE { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_PATH")]
        public string INITIALSDCATALOGPATH { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_ID")]
        public string INITIALSDCATALOGID { get; set; }

        [JsonProperty("IS_FINANCIAL_COMPTED")]
        public string ISFINANCIALCOMPTED { get; set; }

        [JsonProperty("IS_MAJOR_INCIDENT")]
        public string ISMAJORINCIDENT { get; set; }

        [JsonProperty("IS_TEMPLATE")]
        public string ISTEMPLATE { get; set; }

        [JsonProperty("KBASE_ID")]
        public string KBASEID { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_PATH")]
        public string KNOWNPROBLEMSPATH { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("LAST_DONE_BY_ID")]
        public string LASTDONEBYID { get; set; }

        [JsonProperty("LAST_GROUP_ID")]
        public string LASTGROUPID { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

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

        [JsonProperty("RECIPIENT_ID")]
        public string RECIPIENTID { get; set; }

        [JsonProperty("RELEASE_ID")]
        public string RELEASEID { get; set; }

        [JsonProperty("RENTAL_NET_PRICE")]
        public string RENTALNETPRICE { get; set; }

        [JsonProperty("RENTAL_NET_PRICE_CUR_ID")]
        public string RENTALNETPRICECURID { get; set; }

        [JsonProperty("REOPEN_PROCESSING")]
        public string REOPENPROCESSING { get; set; }

        [JsonProperty("REQUALIFICATION_PROCESSING")]
        public string REQUALIFICATIONPROCESSING { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("REQUEST_ORIGIN_ID")]
        public string REQUESTORIGINID { get; set; }

        [JsonProperty("REQUEST_PROJECT_ID")]
        public string REQUESTPROJECTID { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_END")]
        public string REQUESTEDCHANGEDATEEND { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_START")]
        public string REQUESTEDCHANGEDATESTART { get; set; }

        [JsonProperty("REQUESTOR_FEEDBACK")]
        public string REQUESTORFEEDBACK { get; set; }

        [JsonProperty("REQUESTOR_ID")]
        public string REQUESTORID { get; set; }

        [JsonProperty("REQUESTOR_IP_ADDRESS")]
        public string REQUESTORIPADDRESS { get; set; }

        [JsonProperty("REQUESTOR_PHONE")]
        public string REQUESTORPHONE { get; set; }

        [JsonProperty("REQUIRED_DOWNTIME")]
        public string REQUIREDDOWNTIME { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("RISK_AMOUNT")]
        public string RISKAMOUNT { get; set; }

        [JsonProperty("RISK_DESCRIPTION")]
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemRISKDESCRIPTIONType RISKDESCRIPTION { get; set; }

        [JsonProperty("RISK_LEVEL_ID")]
        public string RISKLEVELID { get; set; }

        [JsonProperty("ROOT_CAUSE_ID")]
        public string ROOTCAUSEID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SEVERITY_ID")]
        public string SEVERITYID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }

        [JsonProperty("SUBMITTED_BY")]
        public string SUBMITTEDBY { get; set; }

        [JsonProperty("SYSTEM_AFFECTED")]
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemSYSTEMAFFECTEDType SYSTEMAFFECTED { get; set; }

        [JsonProperty("SYSTEM_ID")]
        public string SYSTEMID { get; set; }

        [JsonProperty("TIME_USED_TO_DELIVER_FEEDBACK")]
        public string TIMEUSEDTODELIVERFEEDBACK { get; set; }

        [JsonProperty("TIME_USED_TO_SOLVE_REQUEST")]
        public string TIMEUSEDTOSOLVEREQUEST { get; set; }
        public string TITLE { get; set; }

        [JsonProperty("URGENCY_ID")]
        public string URGENCYID { get; set; }

        [JsonProperty("VALIDATION_LEVEL_REQUIRED")]
        public string VALIDATIONLEVELREQUIRED { get; set; }

        [JsonProperty("WAVE_ID_TARGET")]
        public string WAVEIDTARGET { get; set; }
        public ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemREQUESTType REQUEST { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemDYNAMICDETAILSType
    {
        public string HREF { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemRISKDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemSYSTEMAFFECTEDType
    {
        public string HREF { get; set; }
    }

    public class ViewListTicketsAttachedtoaProblemResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewListQuestionsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListQuestionsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListQuestionsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class ViewListQuestionsWithResponseResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListQuestionsWithResponseResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListQuestionsWithResponseResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public ViewListQuestionsWithResponseResponseRecordsTypeItemREQUESTType REQUEST { get; set; }
        public ViewListQuestionsWithResponseResponseRecordsTypeItemQUESTIONType QUESTION { get; set; }
    }

    public class ViewListQuestionsWithResponseResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }
        public string HREF { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewListQuestionsWithResponseResponseRecordsTypeItemQUESTIONType
    {
        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class ViewaQuestionResponse
    {
        public string HREF { get; set; }

        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_LIST")]
        public ViewaQuestionResponseVALUELISTType VALUELIST { get; set; }

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class ViewaQuestionResponseVALUELISTType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("DYNAMIC_KEY")]
        public string DYNAMICKEY { get; set; }

        [JsonProperty("IS_CONDITIONNAL")]
        public string ISCONDITIONNAL { get; set; }

        [JsonProperty("QUESTION_DISPLAYED")]
        public string QUESTIONDISPLAYED { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

        [JsonProperty("QUESTION_REQUIRED")]
        public string QUESTIONREQUIRED { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTType RESULT { get; set; }

        [JsonProperty("RESULT_BIT")]
        public string RESULTBIT { get; set; }

        [JsonProperty("RESULT_DATE")]
        public string RESULTDATE { get; set; }

        [JsonProperty("RESULT_DURATION")]
        public string RESULTDURATION { get; set; }

        [JsonProperty("RESULT_NUMBER")]
        public string RESULTNUMBER { get; set; }

        [JsonProperty("RESULT_ORDER")]
        public string RESULTORDER { get; set; }

        [JsonProperty("RESULT_STRING_EN")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGENType RESULTSTRINGEN { get; set; }

        [JsonProperty("RESULT_STRING_FR")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGFRType RESULTSTRINGFR { get; set; }

        [JsonProperty("RESULT_STRING_GE")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGGEType RESULTSTRINGGE { get; set; }

        [JsonProperty("RESULT_STRING_IT")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGITType RESULTSTRINGIT { get; set; }

        [JsonProperty("RESULT_STRING_L1")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL1Type RESULTSTRINGL1 { get; set; }

        [JsonProperty("RESULT_STRING_L2")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL2Type RESULTSTRINGL2 { get; set; }

        [JsonProperty("RESULT_STRING_L3")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL3Type RESULTSTRINGL3 { get; set; }

        [JsonProperty("RESULT_STRING_L4")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL4Type RESULTSTRINGL4 { get; set; }

        [JsonProperty("RESULT_STRING_L5")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL5Type RESULTSTRINGL5 { get; set; }

        [JsonProperty("RESULT_STRING_L6")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL6Type RESULTSTRINGL6 { get; set; }

        [JsonProperty("RESULT_STRING_PO")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGPOType RESULTSTRINGPO { get; set; }

        [JsonProperty("RESULT_STRING_SP")]
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGSPType RESULTSTRINGSP { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }
        public string TABLENAME { get; set; }
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemREQUESTType REQUEST { get; set; }
        public ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemQUESTIONType QUESTION { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGENType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGFRType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGGEType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGITType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL1Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL2Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL3Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL4Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL5Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGL6Type
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGPOType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemRESULTSTRINGSPType
    {
        public string HREF { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }
        public string HREF { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewAllResponsesListQuestionsofaTicketResponseRecordsTypeItemQUESTIONType
    {
        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class ViewResponseQuestionTicketResponse
    {
        public string HREF { get; set; }

        [JsonProperty("DYNAMIC_KEY")]
        public string DYNAMICKEY { get; set; }

        [JsonProperty("IS_CONDITIONNAL")]
        public string ISCONDITIONNAL { get; set; }

        [JsonProperty("QUESTION_DISPLAYED")]
        public string QUESTIONDISPLAYED { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

        [JsonProperty("QUESTION_REQUIRED")]
        public string QUESTIONREQUIRED { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public ViewResponseQuestionTicketResponseRESULTType RESULT { get; set; }

        [JsonProperty("RESULT_BIT")]
        public string RESULTBIT { get; set; }

        [JsonProperty("RESULT_DATE")]
        public string RESULTDATE { get; set; }

        [JsonProperty("RESULT_DURATION")]
        public string RESULTDURATION { get; set; }

        [JsonProperty("RESULT_NUMBER")]
        public string RESULTNUMBER { get; set; }

        [JsonProperty("RESULT_ORDER")]
        public string RESULTORDER { get; set; }

        [JsonProperty("RESULT_STRING_EN")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGENType RESULTSTRINGEN { get; set; }

        [JsonProperty("RESULT_STRING_FR")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGFRType RESULTSTRINGFR { get; set; }

        [JsonProperty("RESULT_STRING_GE")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGGEType RESULTSTRINGGE { get; set; }

        [JsonProperty("RESULT_STRING_IT")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGITType RESULTSTRINGIT { get; set; }

        [JsonProperty("RESULT_STRING_L1")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL1Type RESULTSTRINGL1 { get; set; }

        [JsonProperty("RESULT_STRING_L2")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL2Type RESULTSTRINGL2 { get; set; }

        [JsonProperty("RESULT_STRING_L3")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL3Type RESULTSTRINGL3 { get; set; }

        [JsonProperty("RESULT_STRING_L4")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL4Type RESULTSTRINGL4 { get; set; }

        [JsonProperty("RESULT_STRING_L5")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL5Type RESULTSTRINGL5 { get; set; }

        [JsonProperty("RESULT_STRING_L6")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGL6Type RESULTSTRINGL6 { get; set; }

        [JsonProperty("RESULT_STRING_PO")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGPOType RESULTSTRINGPO { get; set; }

        [JsonProperty("RESULT_STRING_SP")]
        public ViewResponseQuestionTicketResponseRESULTSTRINGSPType RESULTSTRINGSP { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }
        public string TABLENAME { get; set; }
        public ViewResponseQuestionTicketResponseREQUESTType REQUEST { get; set; }
        public ViewResponseQuestionTicketResponseQUESTIONType QUESTION { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGENType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGFRType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGGEType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGITType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL1Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL2Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL3Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL4Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL5Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGL6Type
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGPOType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseRESULTSTRINGSPType
    {
        public string HREF { get; set; }
    }

    public class ViewResponseQuestionTicketResponseREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }
        public string HREF { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewResponseQuestionTicketResponseQUESTIONType
    {
        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class CreateResponseQuestionTicketResponse
    {
        public string HREF { get; set; }
    }

    public class UpdateResponseQuestionTicketResponse
    {
        public string HREF { get; set; }
    }

    public class ViewListQuestionnairesResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListQuestionnairesResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListQuestionnairesResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("QUESTION_LIST_EN")]
        public string QUESTIONLISTEN { get; set; }

        [JsonProperty("QUESTION_LIST_FR")]
        public string QUESTIONLISTFR { get; set; }

        [JsonProperty("QUESTION_LIST_GE")]
        public string QUESTIONLISTGE { get; set; }

        [JsonProperty("QUESTION_LIST_GUID")]
        public string QUESTIONLISTGUID { get; set; }

        [JsonProperty("QUESTION_LIST_ID")]
        public string QUESTIONLISTID { get; set; }

        [JsonProperty("QUESTION_LIST_IT")]
        public string QUESTIONLISTIT { get; set; }

        [JsonProperty("QUESTION_LIST_L1")]
        public string QUESTIONLISTL1 { get; set; }

        [JsonProperty("QUESTION_LIST_L2")]
        public string QUESTIONLISTL2 { get; set; }

        [JsonProperty("QUESTION_LIST_L3")]
        public string QUESTIONLISTL3 { get; set; }

        [JsonProperty("QUESTION_LIST_L4")]
        public string QUESTIONLISTL4 { get; set; }

        [JsonProperty("QUESTION_LIST_L5")]
        public string QUESTIONLISTL5 { get; set; }

        [JsonProperty("QUESTION_LIST_L6")]
        public string QUESTIONLISTL6 { get; set; }

        [JsonProperty("QUESTION_LIST_PO")]
        public string QUESTIONLISTPO { get; set; }

        [JsonProperty("QUESTION_LIST_SP")]
        public string QUESTIONLISTSP { get; set; }
    }

    public class ViewQuestionnaireResponse
    {
        public string HREF { get; set; }
        public string ALONE { get; set; }

        [JsonProperty("ANSWER_CANNOT_BE_MODIFIED")]
        public string ANSWERCANNOTBEMODIFIED { get; set; }
        public ViewQuestionnaireResponseCONDITIONType CONDITION { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_EN")]
        public string CONSTRAINTMESSAGEEN { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_FR")]
        public string CONSTRAINTMESSAGEFR { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_GE")]
        public string CONSTRAINTMESSAGEGE { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_IT")]
        public string CONSTRAINTMESSAGEIT { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L1")]
        public string CONSTRAINTMESSAGEL1 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L2")]
        public string CONSTRAINTMESSAGEL2 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L3")]
        public string CONSTRAINTMESSAGEL3 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L4")]
        public string CONSTRAINTMESSAGEL4 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L5")]
        public string CONSTRAINTMESSAGEL5 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_L6")]
        public string CONSTRAINTMESSAGEL6 { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_PO")]
        public string CONSTRAINTMESSAGEPO { get; set; }

        [JsonProperty("CONSTRAINT_MESSAGE_SP")]
        public string CONSTRAINTMESSAGESP { get; set; }

        [JsonProperty("CONSTRAINT_VALIDATION")]
        public ViewQuestionnaireResponseCONSTRAINTVALIDATIONType CONSTRAINTVALIDATION { get; set; }
        public string DISABLED { get; set; }

        [JsonProperty("DISPLAY_ORDER")]
        public string DISPLAYORDER { get; set; }
        public string MANDATORY { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

        [JsonProperty("QUESTION_LIST_ID")]
        public string QUESTIONLISTID { get; set; }

        [JsonProperty("TARGET_FIELD_1")]
        public string TARGETFIELD1 { get; set; }

        [JsonProperty("TARGET_FIELD_1_APPEND")]
        public string TARGETFIELD1APPEND { get; set; }

        [JsonProperty("TARGET_FIELD_2")]
        public string TARGETFIELD2 { get; set; }

        [JsonProperty("TARGET_FIELD_2_APPEND")]
        public string TARGETFIELD2APPEND { get; set; }
        public ViewQuestionnaireResponseXMLType XML { get; set; }
        public ViewQuestionnaireResponseQUESTIONType QUESTION { get; set; }
    }

    public class ViewQuestionnaireResponseCONDITIONType
    {
        public string HREF { get; set; }
    }

    public class ViewQuestionnaireResponseCONSTRAINTVALIDATIONType
    {
        public string HREF { get; set; }
    }

    public class ViewQuestionnaireResponseXMLType
    {
        public string HREF { get; set; }
    }

    public class ViewQuestionnaireResponseQUESTIONType
    {
        [JsonProperty("DEPENDS_ON_ANOTHER_QUESTION")]
        public string DEPENDSONANOTHERQUESTION { get; set; }

        [JsonProperty("IS_REST_SUPPORTED")]
        public string ISRESTSUPPORTED { get; set; }

        [JsonProperty("IS_VARIABLE")]
        public string ISVARIABLE { get; set; }

        [JsonProperty("QUESTION_CODE")]
        public string QUESTIONCODE { get; set; }

        [JsonProperty("QUESTION_EN")]
        public string QUESTIONEN { get; set; }

        [JsonProperty("QUESTION_FR")]
        public string QUESTIONFR { get; set; }

        [JsonProperty("QUESTION_GE")]
        public string QUESTIONGE { get; set; }

        [JsonProperty("QUESTION_GUID")]
        public string QUESTIONGUID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("QUESTION_ID")]
        public string QUESTIONID { get; set; }

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

        [JsonProperty("VALUE_TYPE")]
        public string VALUETYPE { get; set; }
    }

    public class ViewListProblemsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListProblemsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItem
    {
        public string HREF { get; set; }
        public ViewListProblemsResponseRecordsTypeItemCOMMENTType COMMENT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }

        [JsonProperty("CATALOG_REQUEST")]
        public ViewListProblemsResponseRecordsTypeItemCATALOGREQUESTType CATALOGREQUEST { get; set; }
        public ViewListProblemsResponseRecordsTypeItemSTATUSType STATUS { get; set; }
        public ViewListProblemsResponseRecordsTypeItemRECIPIENTType RECIPIENT { get; set; }
        public ViewListProblemsResponseRecordsTypeItemREQUESTORType REQUESTOR { get; set; }
        public ViewListProblemsResponseRecordsTypeItemLOCATIONType LOCATION { get; set; }
        public ViewListProblemsResponseRecordsTypeItemDEPARTMENTType DEPARTMENT { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemCATALOGREQUESTType
    {
        public string CODE { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemSTATUSType
    {
        [JsonProperty("IS_HELP_DESK")]
        public string ISHELPDESK { get; set; }

        [JsonProperty("IS_PROCUREMENT")]
        public string ISPROCUREMENT { get; set; }

        [JsonProperty("STATUS_FR")]
        public string STATUSFR { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string STATUSGUID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemRECIPIENTType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemREQUESTORType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemLOCATIONType
    {
        public string CITY { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }
    }

    public class ViewListProblemsResponseRecordsTypeItemDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }
    }

    public class ViewProblemResponse
    {
        public string HREF { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_PATH")]
        public string ANALYTICALCHARGEPATH { get; set; }

        [JsonProperty("ANALYTICAL_CHARGE_ID")]
        public string ANALYTICALCHARGEID { get; set; }

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

        [JsonProperty("CI_ID")]
        public string CIID { get; set; }

        [JsonProperty("CLICK_2_GET_INSTALL_RESULT")]
        public string CLICK2GETINSTALLRESULT { get; set; }
        public ViewProblemResponseCOMMENTType COMMENT { get; set; }

        [JsonProperty("CONTINUITY_PLAN_ID")]
        public string CONTINUITYPLANID { get; set; }

        [JsonProperty("COST_CENTER_ID")]
        public string COSTCENTERID { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CREATIONDATEUT { get; set; }
        public string DELAY { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }
        public ViewProblemResponseDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DYNAMIC_DETAILS")]
        public ViewProblemResponseDYNAMICDETAILSType DYNAMICDETAILS { get; set; }

        [JsonProperty("E_ALERT_CODE")]
        public string EALERTCODE { get; set; }

        [JsonProperty("E_COST")]
        public string ECOST { get; set; }

        [JsonProperty("E_DELAY")]
        public string EDELAY { get; set; }

        [JsonProperty("E_LAST_DATES_UPDATE")]
        public string ELASTDATESUPDATE { get; set; }

        [JsonProperty("E_SENTIMENT_ANALYSIS")]
        public string ESENTIMENTANALYSIS { get; set; }

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

        [JsonProperty("IMPACT_ID")]
        public string IMPACTID { get; set; }

        [JsonProperty("IMPUTATION_DATE")]
        public string IMPUTATIONDATE { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_PATH")]
        public string INITIALSDCATALOGPATH { get; set; }

        [JsonProperty("INITIAL_SD_CATALOG_ID")]
        public string INITIALSDCATALOGID { get; set; }

        [JsonProperty("IS_FINANCIAL_COMPTED")]
        public string ISFINANCIALCOMPTED { get; set; }

        [JsonProperty("IS_MAJOR_INCIDENT")]
        public string ISMAJORINCIDENT { get; set; }

        [JsonProperty("IS_TEMPLATE")]
        public string ISTEMPLATE { get; set; }

        [JsonProperty("KBASE_ID")]
        public string KBASEID { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_PATH")]
        public string KNOWNPROBLEMSPATH { get; set; }

        [JsonProperty("KNOWN_PROBLEMS_ID")]
        public string KNOWNPROBLEMSID { get; set; }

        [JsonProperty("LAST_DONE_BY_ID")]
        public string LASTDONEBYID { get; set; }

        [JsonProperty("LAST_GROUP_ID")]
        public string LASTGROUPID { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

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

        [JsonProperty("RECIPIENT_ID")]
        public string RECIPIENTID { get; set; }

        [JsonProperty("RELEASE_ID")]
        public string RELEASEID { get; set; }

        [JsonProperty("RENTAL_NET_PRICE")]
        public string RENTALNETPRICE { get; set; }

        [JsonProperty("RENTAL_NET_PRICE_CUR_ID")]
        public string RENTALNETPRICECURID { get; set; }

        [JsonProperty("REOPEN_PROCESSING")]
        public string REOPENPROCESSING { get; set; }

        [JsonProperty("REQUALIFICATION_PROCESSING")]
        public string REQUALIFICATIONPROCESSING { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("REQUEST_ORIGIN_ID")]
        public string REQUESTORIGINID { get; set; }

        [JsonProperty("REQUEST_PROJECT_ID")]
        public string REQUESTPROJECTID { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_END")]
        public string REQUESTEDCHANGEDATEEND { get; set; }

        [JsonProperty("REQUESTED_CHANGE_DATE_START")]
        public string REQUESTEDCHANGEDATESTART { get; set; }

        [JsonProperty("REQUESTOR_FEEDBACK")]
        public string REQUESTORFEEDBACK { get; set; }

        [JsonProperty("REQUESTOR_ID")]
        public string REQUESTORID { get; set; }

        [JsonProperty("REQUESTOR_IP_ADDRESS")]
        public string REQUESTORIPADDRESS { get; set; }

        [JsonProperty("REQUESTOR_PHONE")]
        public string REQUESTORPHONE { get; set; }

        [JsonProperty("REQUIRED_DOWNTIME")]
        public string REQUIREDDOWNTIME { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("RISK_AMOUNT")]
        public string RISKAMOUNT { get; set; }

        [JsonProperty("RISK_DESCRIPTION")]
        public ViewProblemResponseRISKDESCRIPTIONType RISKDESCRIPTION { get; set; }

        [JsonProperty("RISK_LEVEL_ID")]
        public string RISKLEVELID { get; set; }

        [JsonProperty("ROOT_CAUSE_ID")]
        public string ROOTCAUSEID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("SEVERITY_ID")]
        public string SEVERITYID { get; set; }

        [JsonProperty("SLA_ID")]
        public string SLAID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }

        [JsonProperty("SUBMITTED_BY")]
        public string SUBMITTEDBY { get; set; }

        [JsonProperty("SYSTEM_AFFECTED")]
        public ViewProblemResponseSYSTEMAFFECTEDType SYSTEMAFFECTED { get; set; }

        [JsonProperty("SYSTEM_ID")]
        public string SYSTEMID { get; set; }

        [JsonProperty("TIME_USED_TO_DELIVER_FEEDBACK")]
        public string TIMEUSEDTODELIVERFEEDBACK { get; set; }

        [JsonProperty("TIME_USED_TO_SOLVE_REQUEST")]
        public string TIMEUSEDTOSOLVEREQUEST { get; set; }
        public string TITLE { get; set; }

        [JsonProperty("URGENCY_ID")]
        public string URGENCYID { get; set; }

        [JsonProperty("VALIDATION_LEVEL_REQUIRED")]
        public string VALIDATIONLEVELREQUIRED { get; set; }

        [JsonProperty("WAVE_ID_TARGET")]
        public string WAVEIDTARGET { get; set; }

        [JsonProperty("CATALOG_REQUEST")]
        public ViewProblemResponseCATALOGREQUESTType CATALOGREQUEST { get; set; }
        public ViewProblemResponseSTATUSType STATUS { get; set; }
        public ViewProblemResponseRECIPIENTType RECIPIENT { get; set; }
        public ViewProblemResponseREQUESTORType REQUESTOR { get; set; }
        public ViewProblemResponseLOCATIONType LOCATION { get; set; }
        public ViewProblemResponseDEPARTMENTType DEPARTMENT { get; set; }
    }

    public class ViewProblemResponseCOMMENTType
    {
        public string HREF { get; set; }
    }

    public class ViewProblemResponseDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewProblemResponseDYNAMICDETAILSType
    {
        public string HREF { get; set; }
    }

    public class ViewProblemResponseRISKDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewProblemResponseSYSTEMAFFECTEDType
    {
        public string HREF { get; set; }
    }

    public class ViewProblemResponseCATALOGREQUESTType
    {
        public string CODE { get; set; }

        [JsonProperty("CATALOG_REQUEST_PATH")]
        public string CATALOGREQUESTPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("TITLE_FR")]
        public string TITLEFR { get; set; }
    }

    public class ViewProblemResponseSTATUSType
    {
        [JsonProperty("IS_HELP_DESK")]
        public string ISHELPDESK { get; set; }

        [JsonProperty("IS_PROCUREMENT")]
        public string ISPROCUREMENT { get; set; }

        [JsonProperty("STATUS_FR")]
        public string STATUSFR { get; set; }

        [JsonProperty("STATUS_GUID")]
        public string STATUSGUID { get; set; }

        [JsonProperty("STATUS_ID")]
        public string STATUSID { get; set; }
    }

    public class ViewProblemResponseRECIPIENTType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewProblemResponseREQUESTORType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewProblemResponseLOCATIONType
    {
        public string CITY { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }
    }

    public class ViewProblemResponseDEPARTMENTType
    {
        [JsonProperty("DEPARTMENT_CODE")]
        public string DEPARTMENTCODE { get; set; }

        [JsonProperty("DEPARTMENT_FR")]
        public string DEPARTMENTFR { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }

        [JsonProperty("DEPARTMENT_LABEL")]
        public string DEPARTMENTLABEL { get; set; }
    }

    public class ViewListNewsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListNewsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListNewsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }
        public ViewListNewsResponseRecordsTypeItemDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DOCUMENT_ID")]
        public string DOCUMENTID { get; set; }

        [JsonProperty("DOCUMENT_NAME")]
        public string DOCUMENTNAME { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("FRONT_OFFICE")]
        public string FRONTOFFICE { get; set; }

        [JsonProperty("L_EN")]
        public string LEN { get; set; }

        [JsonProperty("L_FR")]
        public string LFR { get; set; }

        [JsonProperty("L_GE")]
        public string LGE { get; set; }

        [JsonProperty("L_IT")]
        public string LIT { get; set; }

        [JsonProperty("L_PO")]
        public string LPO { get; set; }

        [JsonProperty("L_SP")]
        public string LSP { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }
        public ViewListNewsResponseRecordsTypeItemREQUESTType REQUEST { get; set; }
    }

    public class ViewListNewsResponseRecordsTypeItemDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewListNewsResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class CreateNewsResponse
    {
        public string HREF { get; set; }
    }

    public class ViewNewsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("CREATION_DATE")]
        public string CREATIONDATE { get; set; }

        [JsonProperty("CREATION_DATE_UT")]
        public string CREATIONDATEUT { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("DEPARTMENT_ID")]
        public string DEPARTMENTID { get; set; }
        public ViewNewsResponseDESCRIPTIONType DESCRIPTION { get; set; }

        [JsonProperty("DISPLAY_LAST_UPDATE")]
        public string DISPLAYLASTUPDATE { get; set; }

        [JsonProperty("DOCUMENT_ID")]
        public string DOCUMENTID { get; set; }

        [JsonProperty("DOCUMENT_NAME")]
        public string DOCUMENTNAME { get; set; }

        [JsonProperty("DOCUMENT_TYPE")]
        public string DOCUMENTTYPE { get; set; }

        [JsonProperty("E_KEYWORDS")]
        public string EKEYWORDS { get; set; }

        [JsonProperty("E_PICTURE")]
        public string EPICTURE { get; set; }

        [JsonProperty("END_DATE")]
        public string ENDDATE { get; set; }

        [JsonProperty("FRONT_OFFICE")]
        public string FRONTOFFICE { get; set; }
        public string GUID { get; set; }
        public string ID { get; set; }
        public string INSTALL { get; set; }

        [JsonProperty("IS_EMBEDDED")]
        public string ISEMBEDDED { get; set; }

        [JsonProperty("IS_NEWS")]
        public string ISNEWS { get; set; }

        [JsonProperty("IS_NOTIFICATION")]
        public string ISNOTIFICATION { get; set; }

        [JsonProperty("L_EN")]
        public string LEN { get; set; }

        [JsonProperty("L_FR")]
        public string LFR { get; set; }

        [JsonProperty("L_GE")]
        public string LGE { get; set; }

        [JsonProperty("L_IT")]
        public string LIT { get; set; }

        [JsonProperty("L_L1")]
        public string LL1 { get; set; }

        [JsonProperty("L_L2")]
        public string LL2 { get; set; }

        [JsonProperty("L_L3")]
        public string LL3 { get; set; }

        [JsonProperty("L_L4")]
        public string LL4 { get; set; }

        [JsonProperty("L_L5")]
        public string LL5 { get; set; }

        [JsonProperty("L_L6")]
        public string LL6 { get; set; }

        [JsonProperty("L_PO")]
        public string LPO { get; set; }

        [JsonProperty("L_SP")]
        public string LSP { get; set; }

        [JsonProperty("LAST_UPDATE")]
        public string LASTUPDATE { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }

        [JsonProperty("MAJOR_INCIDENT_ID")]
        public string MAJORINCIDENTID { get; set; }
        public string MODULE { get; set; }

        [JsonProperty("ORIGIN_TOOL_ID")]
        public string ORIGINTOOLID { get; set; }

        [JsonProperty("PHYSICAL_NAME")]
        public string PHYSICALNAME { get; set; }

        [JsonProperty("PICTURE_PATH")]
        public string PICTUREPATH { get; set; }
        public string PRIORITY { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("SD_CATALOG_PATH")]
        public string SDCATALOGPATH { get; set; }

        [JsonProperty("SD_CATALOG_ID")]
        public string SDCATALOGID { get; set; }

        [JsonProperty("START_DATE")]
        public string STARTDATE { get; set; }

        [JsonProperty("TABLE_NAME")]
        public string TABLENAME { get; set; }

        [JsonProperty("UPLOADED_BY_ID")]
        public string UPLOADEDBYID { get; set; }
        public ViewNewsResponseREQUESTType REQUEST { get; set; }
    }

    public class ViewNewsResponseDESCRIPTIONType
    {
        public string HREF { get; set; }
    }

    public class ViewNewsResponseREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class UpdateNewsResponse
    {
        public string HREF { get; set; }
    }

    public class ViewListActionsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewListActionsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewListActionsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("ACTION_ID")]
        public string ACTIONID { get; set; }

        [JsonProperty("ACTION_LABEL_FR")]
        public string ACTIONLABELFR { get; set; }

        [JsonProperty("ACTION_NUMBER")]
        public string ACTIONNUMBER { get; set; }

        [JsonProperty("DONE_BY_ID")]
        public string DONEBYID { get; set; }

        [JsonProperty("EXPECTED_START_DATE_UT")]
        public string EXPECTEDSTARTDATEUT { get; set; }
        public ViewListActionsResponseRecordsTypeItemLOCATIONType LOCATION { get; set; }

        [JsonProperty("DONE_BY")]
        public ViewListActionsResponseRecordsTypeItemDONEBYType DONEBY { get; set; }
        public ViewListActionsResponseRecordsTypeItemREQUESTType REQUEST { get; set; }

        [JsonProperty("ACTION_TYPE")]
        public ViewListActionsResponseRecordsTypeItemACTIONTYPEType ACTIONTYPE { get; set; }
    }

    public class ViewListActionsResponseRecordsTypeItemLOCATIONType
    {
        public string CITY { get; set; }

        [JsonProperty("LOCATION_CODE")]
        public string LOCATIONCODE { get; set; }

        [JsonProperty("LOCATION_FR")]
        public string LOCATIONFR { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }
        public string HREF { get; set; }

        [JsonProperty("LOCATION_ID")]
        public string LOCATIONID { get; set; }
    }

    public class ViewListActionsResponseRecordsTypeItemDONEBYType
    {
        [JsonProperty("BEGIN_OF_CONTRACT")]
        public string BEGINOFCONTRACT { get; set; }

        [JsonProperty("CELLULAR_NUMBER")]
        public string CELLULARNUMBER { get; set; }

        [JsonProperty("DEPARTMENT_PATH")]
        public string DEPARTMENTPATH { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_ID")]
        public string EMPLOYEEID { get; set; }

        [JsonProperty("LAST_NAME")]
        public string LASTNAME { get; set; }

        [JsonProperty("LOCATION_PATH")]
        public string LOCATIONPATH { get; set; }

        [JsonProperty("PHONE_NUMBER")]
        public string PHONENUMBER { get; set; }
    }

    public class ViewListActionsResponseRecordsTypeItemREQUESTType
    {
        [JsonProperty("MAX_RESOLUTION_DATE_UT")]
        public string MAXRESOLUTIONDATEUT { get; set; }

        [JsonProperty("REQUEST_ID")]
        public string REQUESTID { get; set; }
        public string HREF { get; set; }

        [JsonProperty("RFC_NUMBER")]
        public string RFCNUMBER { get; set; }

        [JsonProperty("SUBMIT_DATE_UT")]
        public string SUBMITDATEUT { get; set; }
    }

    public class ViewListActionsResponseRecordsTypeItemACTIONTYPEType
    {
        [JsonProperty("ACTION_TYPE_ID")]
        public string ACTIONTYPEID { get; set; }

        [JsonProperty("NAME_FR")]
        public string NAMEFR { get; set; }
    }

    public class CreateActionTicketResponse
    {
        public string HREF { get; set; }
    }

    public class ViewAllAtributesofanAssetsResponse
    {
        public string HREF { get; set; }

        [JsonProperty("record_count")]
        public string RecordCount { get; set; }

        [JsonProperty("total_record_count")]
        public string TotalRecordCount { get; set; }

        [JsonProperty("records")]
        public ViewAllAtributesofanAssetsResponseRecordsTypeItem[] Records { get; set; }
    }

    public class ViewAllAtributesofanAssetsResponseRecordsTypeItem
    {
        public string HREF { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("CAPACITY_VALUE")]
        public string CAPACITYVALUE { get; set; }

        [JsonProperty("CHARACTERISTIC_ID")]
        public string CHARACTERISTICID { get; set; }

        [JsonProperty("DATA_1")]
        public string DATA1 { get; set; }

        [JsonProperty("LAST_INVENTORY_DATE")]
        public string LASTINVENTORYDATE { get; set; }

        [JsonProperty("MAX_TARGET")]
        public string MAXTARGET { get; set; }

        [JsonProperty("MIN_TARGET")]
        public string MINTARGET { get; set; }
        public ViewAllAtributesofanAssetsResponseRecordsTypeItemCHARACTERISTICType CHARACTERISTIC { get; set; }
        public ViewAllAtributesofanAssetsResponseRecordsTypeItemASSETType ASSET { get; set; }
    }

    public class ViewAllAtributesofanAssetsResponseRecordsTypeItemCHARACTERISTICType
    {
        [JsonProperty("CHARACTERISTIC_EN")]
        public string CHARACTERISTICEN { get; set; }

        [JsonProperty("CHARACTERISTIC_FR")]
        public string CHARACTERISTICFR { get; set; }
        public string HREF { get; set; }

        [JsonProperty("CHARACTERISTIC_ID")]
        public string CHARACTERISTICID { get; set; }
    }

    public class ViewAllAtributesofanAssetsResponseRecordsTypeItemASSETType
    {
        public string HREF { get; set; }

        [JsonProperty("ASSET_ID")]
        public string ASSETID { get; set; }

        [JsonProperty("ASSET_LABEL")]
        public string ASSETLABEL { get; set; }

        [JsonProperty("ASSET_TAG")]
        public string ASSETTAG { get; set; }

        [JsonProperty("END_OF_WARANTY")]
        public string ENDOFWARANTY { get; set; }

        [JsonProperty("ENTRY_DATE")]
        public string ENTRYDATE { get; set; }

        [JsonProperty("INSTALLATION_DATE")]
        public string INSTALLATIONDATE { get; set; }

        [JsonProperty("PURCHASE_DATE")]
        public string PURCHASEDATE { get; set; }

        [JsonProperty("SERIAL_NUMBER")]
        public string SERIALNUMBER { get; set; }
    }

    public class UpdateCIResponse
    {
        public string HREF { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyvistaservicemana;

    public partial class WorkflowManagedActions
    {
        public EasyvistaservicemanaActions Easyvistaservicemana(string connectionId) => new EasyvistaservicemanaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyvistaservicemanaTriggers Easyvistaservicemana(string connectionId) => new EasyvistaservicemanaTriggers(connectionId);
    }
}