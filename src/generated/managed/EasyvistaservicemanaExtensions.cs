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
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset(Expression<Func<string>> account, Expression<Func<bodyassetsInputItem[]>> bodyassets = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> bodyBEFORELOANDEPARTMENTID = null, Expression<Func<string>> bodyBEFORELOANEMPLOYEEID = null, Expression<Func<string>> bodyBEFORELOANLOCATIONID = null, Expression<Func<string>> bodyBILLINGPERIODICITYINMONTH = null, Expression<Func<string>> bodyBUYBACKVALUE = null, Expression<Func<string>> bodyBUYBACKVALUECURID = null, Expression<Func<string>> bodyCATALOGID = null, Expression<Func<string>> bodyCHARGEBACK = null, Expression<Func<string>> bodyCHARGEBACKCURID = null, Expression<Func<string>> bodyCISTATUSID = null, Expression<Func<string>> bodyCIVERSION = null, Expression<Func<string>> bodyCMDEFAULTCHANGEID = null, Expression<Func<string>> bodyCONFIGURATIONID = null, Expression<Func<string>> bodyCRITICALLEVELID = null, Expression<Func<string>> bodyDELIVERYDATE = null, Expression<Func<string>> bodyDELIVERYNUMBER = null, Expression<Func<string>> bodyDEPARTMENTID = null, Expression<Func<string>> bodyDEPRECIATIONRULEID = null, Expression<Func<string>> bodyDHARDWAREGUID = null, Expression<Func<string>> bodyEMPLOYEEID = null, Expression<Func<string>> bodyENDOFWARANTY = null, Expression<Func<string>> bodyENTRYDATE = null, Expression<Func<string>> bodyESTIMATEDPERCENTAGEUSE = null, Expression<Func<string>> bodyEXPECTEDENDLENDDATE = null, Expression<Func<string>> bodyEXPECTEDRETURNDATE = null, Expression<Func<string>> bodyFALLENTERM = null, Expression<Func<string>> bodyFIXEDASSETNUMBER = null, Expression<Func<string>> bodyINITIALSTART = null, Expression<Func<string>> bodyINSTALLATIONDATE = null, Expression<Func<string>> bodyINTERNALDELIVERYDATE = null, Expression<Func<string>> bodyINVOICENUMBER = null, Expression<Func<string>> bodyISDML = null, Expression<Func<string>> bodyLASTINTEGRATION = null, Expression<Func<string>> bodyLASTPHYSICALINVENTORY = null, Expression<Func<string>> bodyLASTUPDATE = null, Expression<Func<string>> bodyLICENSEVERSION = null, Expression<Func<string>> bodyLOCATIONID = null, Expression<Func<string>> bodyMAINTENANCECOST = null, Expression<Func<string>> bodyMAINTENANCECOSTCURID = null, Expression<Func<string>> bodyMAINUSAGEID = null, Expression<Func<string>> bodyMAXINSTALLS = null, Expression<Func<string>> bodyMONTHLYFIXEDCOST = null, Expression<Func<string>> bodyMONTHLYFIXEDCOSTCURID = null, Expression<Func<string>> bodyMONTHLYNETRENTAL = null, Expression<Func<string>> bodyMONTHLYNETRENTALCURID = null, Expression<Func<string>> bodyMONTHDURATION = null, Expression<Func<string>> bodyNETWORKIDENTIFIER = null, Expression<Func<string>> bodyNEXTDEPARTMENTID = null, Expression<Func<string>> bodyNEXTMAINTENANCEDATE = null, Expression<Func<string>> bodyNEXTSTATUSID = null, Expression<Func<string>> bodyNEXTUSERAPPLICATIONDATE = null, Expression<Func<string>> bodyNEXTUSERID = null, Expression<Func<string>> bodyNOTICE = null, Expression<Func<string>> bodyORDERDETAILSID = null, Expression<Func<string>> bodyORDERNUMBER = null, Expression<Func<string>> bodyPIPELINESTATUSID = null, Expression<Func<string>> bodyPOWERCONSUMPTIONWH = null, Expression<Func<string>> bodyPROCESSORCOUNT = null, Expression<Func<string>> bodyPROCESSORSOCKETCOUNT = null, Expression<Func<string>> bodyPURCHASEDATE = null, Expression<Func<string>> bodyPURCHASEPRICE = null, Expression<Func<string>> bodyPURCHASEPRICECURID = null, Expression<Func<string>> bodyPURCHASERATEID = null, Expression<Func<string>> bodyRECYCLEDDATE = null, Expression<Func<string>> bodyRECYCLINGPROVIDERID = null, Expression<Func<string>> bodyREFORMNUMBER = null, Expression<Func<string>> bodyREMOVEDDATE = null, Expression<Func<string>> bodyRENEWALDECISIONID = null, Expression<Func<string>> bodyRENEWALVALUE = null, Expression<Func<string>> bodyRENEWALVALUECURID = null, Expression<Func<string>> bodyREPAIREDBYID = null, Expression<Func<string>> bodyRESALESVALUE = null, Expression<Func<string>> bodySCHEDULEDEND = null, Expression<Func<string>> bodySDCATALOGID = null, Expression<Func<string>> bodySERIALNUMBER = null, Expression<Func<string>> bodySLAID = null, Expression<Func<string>> bodySTATUSID = null, Expression<Func<string>> bodySUPPLIERID = null, Expression<Func<string>> bodyTERM = null, Expression<Func<string>> bodyUPDATECOVERAGETERM = null, Expression<Func<string>> bodyWARANTYTYPEID = null, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyavailabilitySlaId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBEFORELOANDEPARTMENTID != null)
            {
                body["BEFORE_LOAN_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodyBEFORELOANDEPARTMENTID);
                bodypropCount++;
            }

            if (bodyBEFORELOANEMPLOYEEID != null)
            {
                body["BEFORE_LOAN_EMPLOYEE_ID"] = ExpressionConverter.ConvertO(bodyBEFORELOANEMPLOYEEID);
                bodypropCount++;
            }

            if (bodyBEFORELOANLOCATIONID != null)
            {
                body["BEFORE_LOAN_LOCATION_ID"] = ExpressionConverter.ConvertO(bodyBEFORELOANLOCATIONID);
                bodypropCount++;
            }

            if (bodyBILLINGPERIODICITYINMONTH != null)
            {
                body["BILLING_PERIODICITY_IN_MONTH"] = ExpressionConverter.ConvertO(bodyBILLINGPERIODICITYINMONTH);
                bodypropCount++;
            }

            if (bodyBUYBACKVALUE != null)
            {
                body["BUY_BACK_VALUE"] = ExpressionConverter.ConvertO(bodyBUYBACKVALUE);
                bodypropCount++;
            }

            if (bodyBUYBACKVALUECURID != null)
            {
                body["BUY_BACK_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(bodyBUYBACKVALUECURID);
                bodypropCount++;
            }

            if (bodyCATALOGID != null)
            {
                body["CATALOG_ID"] = ExpressionConverter.ConvertO(bodyCATALOGID);
                bodypropCount++;
            }

            if (bodyCHARGEBACK != null)
            {
                body["CHARGE_BACK"] = ExpressionConverter.ConvertO(bodyCHARGEBACK);
                bodypropCount++;
            }

            if (bodyCHARGEBACKCURID != null)
            {
                body["CHARGE_BACK_CUR_ID"] = ExpressionConverter.ConvertO(bodyCHARGEBACKCURID);
                bodypropCount++;
            }

            if (bodyCISTATUSID != null)
            {
                body["CI_STATUS_ID"] = ExpressionConverter.ConvertO(bodyCISTATUSID);
                bodypropCount++;
            }

            if (bodyCIVERSION != null)
            {
                body["CI_VERSION"] = ExpressionConverter.ConvertO(bodyCIVERSION);
                bodypropCount++;
            }

            if (bodyCMDEFAULTCHANGEID != null)
            {
                body["CM_DEFAULT_CHANGE_ID"] = ExpressionConverter.ConvertO(bodyCMDEFAULTCHANGEID);
                bodypropCount++;
            }

            if (bodyCONFIGURATIONID != null)
            {
                body["CONFIGURATION_ID"] = ExpressionConverter.ConvertO(bodyCONFIGURATIONID);
                bodypropCount++;
            }

            if (bodyCRITICALLEVELID != null)
            {
                body["CRITICAL_LEVEL_ID"] = ExpressionConverter.ConvertO(bodyCRITICALLEVELID);
                bodypropCount++;
            }

            if (bodyDELIVERYDATE != null)
            {
                body["DELIVERY_DATE"] = ExpressionConverter.ConvertO(bodyDELIVERYDATE);
                bodypropCount++;
            }

            if (bodyDELIVERYNUMBER != null)
            {
                body["DELIVERY_NUMBER"] = ExpressionConverter.ConvertO(bodyDELIVERYNUMBER);
                bodypropCount++;
            }

            if (bodyDEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodyDEPARTMENTID);
                bodypropCount++;
            }

            if (bodyDEPRECIATIONRULEID != null)
            {
                body["DEPRECIATION_RULE_ID"] = ExpressionConverter.ConvertO(bodyDEPRECIATIONRULEID);
                bodypropCount++;
            }

            if (bodyDHARDWAREGUID != null)
            {
                body["D_HARDWARE_GUID"] = ExpressionConverter.ConvertO(bodyDHARDWAREGUID);
                bodypropCount++;
            }

            if (bodyEMPLOYEEID != null)
            {
                body["EMPLOYEE_ID"] = ExpressionConverter.ConvertO(bodyEMPLOYEEID);
                bodypropCount++;
            }

            if (bodyENDOFWARANTY != null)
            {
                body["END_OF_WARANTY"] = ExpressionConverter.ConvertO(bodyENDOFWARANTY);
                bodypropCount++;
            }

            if (bodyENTRYDATE != null)
            {
                body["ENTRY_DATE"] = ExpressionConverter.ConvertO(bodyENTRYDATE);
                bodypropCount++;
            }

            if (bodyESTIMATEDPERCENTAGEUSE != null)
            {
                body["ESTIMATED_PERCENTAGE_USE"] = ExpressionConverter.ConvertO(bodyESTIMATEDPERCENTAGEUSE);
                bodypropCount++;
            }

            if (bodyEXPECTEDENDLENDDATE != null)
            {
                body["EXPECTED_END_LEND_DATE"] = ExpressionConverter.ConvertO(bodyEXPECTEDENDLENDDATE);
                bodypropCount++;
            }

            if (bodyEXPECTEDRETURNDATE != null)
            {
                body["EXPECTED_RETURN_DATE"] = ExpressionConverter.ConvertO(bodyEXPECTEDRETURNDATE);
                bodypropCount++;
            }

            if (bodyFALLENTERM != null)
            {
                body["FALLEN_TERM"] = ExpressionConverter.ConvertO(bodyFALLENTERM);
                bodypropCount++;
            }

            if (bodyFIXEDASSETNUMBER != null)
            {
                body["FIXED_ASSET_NUMBER"] = ExpressionConverter.ConvertO(bodyFIXEDASSETNUMBER);
                bodypropCount++;
            }

            if (bodyINITIALSTART != null)
            {
                body["INITIAL_START"] = ExpressionConverter.ConvertO(bodyINITIALSTART);
                bodypropCount++;
            }

            if (bodyINSTALLATIONDATE != null)
            {
                body["INSTALLATION_DATE"] = ExpressionConverter.ConvertO(bodyINSTALLATIONDATE);
                bodypropCount++;
            }

            if (bodyINTERNALDELIVERYDATE != null)
            {
                body["INTERNAL_DELIVERY_DATE"] = ExpressionConverter.ConvertO(bodyINTERNALDELIVERYDATE);
                bodypropCount++;
            }

            if (bodyINVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(bodyINVOICENUMBER);
                bodypropCount++;
            }

            if (bodyISDML != null)
            {
                body["IS_DML"] = ExpressionConverter.ConvertO(bodyISDML);
                bodypropCount++;
            }

            if (bodyLASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodyLASTINTEGRATION);
                bodypropCount++;
            }

            if (bodyLASTPHYSICALINVENTORY != null)
            {
                body["LAST_PHYSICAL_INVENTORY"] = ExpressionConverter.ConvertO(bodyLASTPHYSICALINVENTORY);
                bodypropCount++;
            }

            if (bodyLASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodyLASTUPDATE);
                bodypropCount++;
            }

            if (bodyLICENSEVERSION != null)
            {
                body["LICENSE_VERSION"] = ExpressionConverter.ConvertO(bodyLICENSEVERSION);
                bodypropCount++;
            }

            if (bodyLOCATIONID != null)
            {
                body["LOCATION_ID"] = ExpressionConverter.ConvertO(bodyLOCATIONID);
                bodypropCount++;
            }

            if (bodyMAINTENANCECOST != null)
            {
                body["MAINTENANCE_COST"] = ExpressionConverter.ConvertO(bodyMAINTENANCECOST);
                bodypropCount++;
            }

            if (bodyMAINTENANCECOSTCURID != null)
            {
                body["MAINTENANCE_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodyMAINTENANCECOSTCURID);
                bodypropCount++;
            }

            if (bodyMAINUSAGEID != null)
            {
                body["MAIN_USAGE_ID"] = ExpressionConverter.ConvertO(bodyMAINUSAGEID);
                bodypropCount++;
            }

            if (bodyMAXINSTALLS != null)
            {
                body["MAX_INSTALLS"] = ExpressionConverter.ConvertO(bodyMAXINSTALLS);
                bodypropCount++;
            }

            if (bodyMONTHLYFIXEDCOST != null)
            {
                body["MONTHLY_FIXED_COST"] = ExpressionConverter.ConvertO(bodyMONTHLYFIXEDCOST);
                bodypropCount++;
            }

            if (bodyMONTHLYFIXEDCOSTCURID != null)
            {
                body["MONTHLY_FIXED_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodyMONTHLYFIXEDCOSTCURID);
                bodypropCount++;
            }

            if (bodyMONTHLYNETRENTAL != null)
            {
                body["MONTHLY_NET_RENTAL"] = ExpressionConverter.ConvertO(bodyMONTHLYNETRENTAL);
                bodypropCount++;
            }

            if (bodyMONTHLYNETRENTALCURID != null)
            {
                body["MONTHLY_NET_RENTAL_CUR_ID"] = ExpressionConverter.ConvertO(bodyMONTHLYNETRENTALCURID);
                bodypropCount++;
            }

            if (bodyMONTHDURATION != null)
            {
                body["MONTH_DURATION"] = ExpressionConverter.ConvertO(bodyMONTHDURATION);
                bodypropCount++;
            }

            if (bodyNETWORKIDENTIFIER != null)
            {
                body["NETWORK_IDENTIFIER"] = ExpressionConverter.ConvertO(bodyNETWORKIDENTIFIER);
                bodypropCount++;
            }

            if (bodyNEXTDEPARTMENTID != null)
            {
                body["NEXT_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodyNEXTDEPARTMENTID);
                bodypropCount++;
            }

            if (bodyNEXTMAINTENANCEDATE != null)
            {
                body["NEXT_MAINTENANCE_DATE"] = ExpressionConverter.ConvertO(bodyNEXTMAINTENANCEDATE);
                bodypropCount++;
            }

            if (bodyNEXTSTATUSID != null)
            {
                body["NEXT_STATUS_ID"] = ExpressionConverter.ConvertO(bodyNEXTSTATUSID);
                bodypropCount++;
            }

            if (bodyNEXTUSERAPPLICATIONDATE != null)
            {
                body["NEXT_USER_APPLICATION_DATE"] = ExpressionConverter.ConvertO(bodyNEXTUSERAPPLICATIONDATE);
                bodypropCount++;
            }

            if (bodyNEXTUSERID != null)
            {
                body["NEXT_USER_ID"] = ExpressionConverter.ConvertO(bodyNEXTUSERID);
                bodypropCount++;
            }

            if (bodyNOTICE != null)
            {
                body["NOTICE"] = ExpressionConverter.ConvertO(bodyNOTICE);
                bodypropCount++;
            }

            if (bodyORDERDETAILSID != null)
            {
                body["ORDER_DETAILS_ID"] = ExpressionConverter.ConvertO(bodyORDERDETAILSID);
                bodypropCount++;
            }

            if (bodyORDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodyORDERNUMBER);
                bodypropCount++;
            }

            if (bodyPIPELINESTATUSID != null)
            {
                body["PIPELINE_STATUS_ID"] = ExpressionConverter.ConvertO(bodyPIPELINESTATUSID);
                bodypropCount++;
            }

            if (bodyPOWERCONSUMPTIONWH != null)
            {
                body["POWER_CONSUMPTION_WH"] = ExpressionConverter.ConvertO(bodyPOWERCONSUMPTIONWH);
                bodypropCount++;
            }

            if (bodyPROCESSORCOUNT != null)
            {
                body["PROCESSOR_COUNT"] = ExpressionConverter.ConvertO(bodyPROCESSORCOUNT);
                bodypropCount++;
            }

            if (bodyPROCESSORSOCKETCOUNT != null)
            {
                body["PROCESSOR_SOCKET_COUNT"] = ExpressionConverter.ConvertO(bodyPROCESSORSOCKETCOUNT);
                bodypropCount++;
            }

            if (bodyPURCHASEDATE != null)
            {
                body["PURCHASE_DATE"] = ExpressionConverter.ConvertO(bodyPURCHASEDATE);
                bodypropCount++;
            }

            if (bodyPURCHASEPRICE != null)
            {
                body["PURCHASE_PRICE"] = ExpressionConverter.ConvertO(bodyPURCHASEPRICE);
                bodypropCount++;
            }

            if (bodyPURCHASEPRICECURID != null)
            {
                body["PURCHASE_PRICE_CUR_ID"] = ExpressionConverter.ConvertO(bodyPURCHASEPRICECURID);
                bodypropCount++;
            }

            if (bodyPURCHASERATEID != null)
            {
                body["PURCHASE_RATE_ID"] = ExpressionConverter.ConvertO(bodyPURCHASERATEID);
                bodypropCount++;
            }

            if (bodyRECYCLEDDATE != null)
            {
                body["RECYCLED_DATE"] = ExpressionConverter.ConvertO(bodyRECYCLEDDATE);
                bodypropCount++;
            }

            if (bodyRECYCLINGPROVIDERID != null)
            {
                body["RECYCLING_PROVIDER_ID"] = ExpressionConverter.ConvertO(bodyRECYCLINGPROVIDERID);
                bodypropCount++;
            }

            if (bodyREFORMNUMBER != null)
            {
                body["REFORM_NUMBER"] = ExpressionConverter.ConvertO(bodyREFORMNUMBER);
                bodypropCount++;
            }

            if (bodyREMOVEDDATE != null)
            {
                body["REMOVED_DATE"] = ExpressionConverter.ConvertO(bodyREMOVEDDATE);
                bodypropCount++;
            }

            if (bodyRENEWALDECISIONID != null)
            {
                body["RENEWAL_DECISION_ID"] = ExpressionConverter.ConvertO(bodyRENEWALDECISIONID);
                bodypropCount++;
            }

            if (bodyRENEWALVALUE != null)
            {
                body["RENEWAL_VALUE"] = ExpressionConverter.ConvertO(bodyRENEWALVALUE);
                bodypropCount++;
            }

            if (bodyRENEWALVALUECURID != null)
            {
                body["RENEWAL_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(bodyRENEWALVALUECURID);
                bodypropCount++;
            }

            if (bodyREPAIREDBYID != null)
            {
                body["REPAIRED_BY_ID"] = ExpressionConverter.ConvertO(bodyREPAIREDBYID);
                bodypropCount++;
            }

            if (bodyRESALESVALUE != null)
            {
                body["RESALES_VALUE"] = ExpressionConverter.ConvertO(bodyRESALESVALUE);
                bodypropCount++;
            }

            if (bodySCHEDULEDEND != null)
            {
                body["SCHEDULED_END"] = ExpressionConverter.ConvertO(bodySCHEDULEDEND);
                bodypropCount++;
            }

            if (bodySDCATALOGID != null)
            {
                body["SD_CATALOG_ID"] = ExpressionConverter.ConvertO(bodySDCATALOGID);
                bodypropCount++;
            }

            if (bodySERIALNUMBER != null)
            {
                body["SERIAL_NUMBER"] = ExpressionConverter.ConvertO(bodySERIALNUMBER);
                bodypropCount++;
            }

            if (bodySLAID != null)
            {
                body["SLA_ID"] = ExpressionConverter.ConvertO(bodySLAID);
                bodypropCount++;
            }

            if (bodySTATUSID != null)
            {
                body["STATUS_ID"] = ExpressionConverter.ConvertO(bodySTATUSID);
                bodypropCount++;
            }

            if (bodySUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(bodySUPPLIERID);
                bodypropCount++;
            }

            if (bodyTERM != null)
            {
                body["TERM"] = ExpressionConverter.ConvertO(bodyTERM);
                bodypropCount++;
            }

            if (bodyUPDATECOVERAGETERM != null)
            {
                body["UPDATE_COVERAGE_TERM"] = ExpressionConverter.ConvertO(bodyUPDATECOVERAGETERM);
                bodypropCount++;
            }

            if (bodyWARANTYTYPEID != null)
            {
                body["WARANTY_TYPE_ID"] = ExpressionConverter.ConvertO(bodyWARANTYTYPEID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodyContractRow = null, Expression<Func<string>> bodyMonthlyPayment = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContractRow != null)
            {
                body["Contract_Row"] = ExpressionConverter.ConvertO(bodyContractRow);
                bodypropCount++;
            }

            if (bodyMonthlyPayment != null)
            {
                body["Monthly_Payment"] = ExpressionConverter.ConvertO(bodyMonthlyPayment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodyContractRow = null, Expression<Func<string>> bodyMonthlyPayment = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContractRow != null)
            {
                body["Contract_Row"] = ExpressionConverter.ConvertO(bodyContractRow);
                bodypropCount++;
            }

            if (bodyMonthlyPayment != null)
            {
                body["Monthly_Payment"] = ExpressionConverter.ConvertO(bodyMonthlyPayment);
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
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1), ExpressionConverter.ConvertWithUrlEncoding(childAssetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests-paths/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/catalog-requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyRelationTypeID, Expression<Func<string>> bodyBlocking = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBlocking != null)
            {
                body["Blocking"] = ExpressionConverter.ConvertO(bodyBlocking);
                bodypropCount++;
            }

            bodypropCount++;
            body["Relation_Type_ID"] = ExpressionConverter.ConvertO(bodyRelationTypeID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyBlocking = null, Expression<Func<string>> bodyRelationTypeID = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBlocking != null)
            {
                body["Blocking"] = ExpressionConverter.ConvertO(bodyBlocking);
                bodypropCount++;
            }

            if (bodyRelationTypeID != null)
            {
                body["Relation_Type_ID"] = ExpressionConverter.ConvertO(bodyRelationTypeID);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity(Expression<Func<string>> account, Expression<Func<string>> departmentId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(departmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEntityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateDepartmentResponse> UpdateDepartment(Expression<Func<string>> account, Expression<Func<string>> departmentId, Expression<Func<string>> bodyPARENTDEPARTMENTID = null, Expression<Func<string>> bodyDEPARTMENTEN = null, Expression<Func<string>> bodyDEPARTMENTFR = null, Expression<Func<string>> bodyDEPARTMENTSP = null, Expression<Func<string>> bodyDEPARTMENTGE = null, Expression<Func<string>> bodyDEPARTMENTIT = null, Expression<Func<string>> bodyDEPARTMENTPO = null, Expression<Func<string>> bodyDEPARTMENTLABEL = null, Expression<Func<string>> bodyCOMMENTDEPARTMENT = null, Expression<Func<string>> bodyMANAGERID = null, Expression<Func<string>> bodyDEFAULTCOSTCENTERID = null, Expression<Func<string>> bodySTARTDATE = null, Expression<Func<string>> bodyENDDATE = null, Expression<Func<string>> bodyURLMAP = null, Expression<Func<string>> bodyDEPARTMENTCODE = null, Expression<Func<string>> bodyLASTUPDATE = null, Expression<Func<string>> bodyLASTINTEGRATION = null, Expression<Func<string>> bodyCURRENCYID = null, Expression<Func<string>> bodyAVAILABLEFIELD1 = null, Expression<Func<string>> bodyAVAILABLEFIELD2 = null, Expression<Func<string>> bodyAVAILABLEFIELD3 = null, Expression<Func<string>> bodyAVAILABLEFIELD4 = null, Expression<Func<string>> bodyAVAILABLEFIELD5 = null, Expression<Func<string>> bodyAVAILABLEFIELD6 = null, Expression<Func<string>> bodySLAID = null, Expression<Func<string>> bodyDEPARTMENTL1 = null, Expression<Func<string>> bodyDEPARTMENTL2 = null, Expression<Func<string>> bodyDEPARTMENTL3 = null, Expression<Func<string>> bodyDEPARTMENTL4 = null, Expression<Func<string>> bodyDEPARTMENTL5 = null, Expression<Func<string>> bodyDEPARTMENTL6 = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(departmentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPARENTDEPARTMENTID != null)
            {
                body["PARENT_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodyPARENTDEPARTMENTID);
                bodypropCount++;
            }

            if (bodyDEPARTMENTEN != null)
            {
                body["DEPARTMENT_EN"] = ExpressionConverter.ConvertO(bodyDEPARTMENTEN);
                bodypropCount++;
            }

            if (bodyDEPARTMENTFR != null)
            {
                body["DEPARTMENT_FR"] = ExpressionConverter.ConvertO(bodyDEPARTMENTFR);
                bodypropCount++;
            }

            if (bodyDEPARTMENTSP != null)
            {
                body["DEPARTMENT_SP"] = ExpressionConverter.ConvertO(bodyDEPARTMENTSP);
                bodypropCount++;
            }

            if (bodyDEPARTMENTGE != null)
            {
                body["DEPARTMENT_GE"] = ExpressionConverter.ConvertO(bodyDEPARTMENTGE);
                bodypropCount++;
            }

            if (bodyDEPARTMENTIT != null)
            {
                body["DEPARTMENT_IT"] = ExpressionConverter.ConvertO(bodyDEPARTMENTIT);
                bodypropCount++;
            }

            if (bodyDEPARTMENTPO != null)
            {
                body["DEPARTMENT_PO"] = ExpressionConverter.ConvertO(bodyDEPARTMENTPO);
                bodypropCount++;
            }

            if (bodyDEPARTMENTLABEL != null)
            {
                body["DEPARTMENT_LABEL"] = ExpressionConverter.ConvertO(bodyDEPARTMENTLABEL);
                bodypropCount++;
            }

            if (bodyCOMMENTDEPARTMENT != null)
            {
                body["COMMENT_DEPARTMENT"] = ExpressionConverter.ConvertO(bodyCOMMENTDEPARTMENT);
                bodypropCount++;
            }

            if (bodyMANAGERID != null)
            {
                body["MANAGER_ID"] = ExpressionConverter.ConvertO(bodyMANAGERID);
                bodypropCount++;
            }

            if (bodyDEFAULTCOSTCENTERID != null)
            {
                body["DEFAULT_COST_CENTER_ID"] = ExpressionConverter.ConvertO(bodyDEFAULTCOSTCENTERID);
                bodypropCount++;
            }

            if (bodySTARTDATE != null)
            {
                body["START_DATE"] = ExpressionConverter.ConvertO(bodySTARTDATE);
                bodypropCount++;
            }

            if (bodyENDDATE != null)
            {
                body["END_DATE"] = ExpressionConverter.ConvertO(bodyENDDATE);
                bodypropCount++;
            }

            if (bodyURLMAP != null)
            {
                body["URL_MAP"] = ExpressionConverter.ConvertO(bodyURLMAP);
                bodypropCount++;
            }

            if (bodyDEPARTMENTCODE != null)
            {
                body["DEPARTMENT_CODE"] = ExpressionConverter.ConvertO(bodyDEPARTMENTCODE);
                bodypropCount++;
            }

            if (bodyLASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodyLASTUPDATE);
                bodypropCount++;
            }

            if (bodyLASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodyLASTINTEGRATION);
                bodypropCount++;
            }

            if (bodyCURRENCYID != null)
            {
                body["CURRENCY_ID"] = ExpressionConverter.ConvertO(bodyCURRENCYID);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodySLAID != null)
            {
                body["SLA_ID"] = ExpressionConverter.ConvertO(bodySLAID);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL1 != null)
            {
                body["DEPARTMENT_L1"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL1);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL2 != null)
            {
                body["DEPARTMENT_L2"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL2);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL3 != null)
            {
                body["DEPARTMENT_L3"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL3);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL4 != null)
            {
                body["DEPARTMENT_L4"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL4);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL5 != null)
            {
                body["DEPARTMENT_L5"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL5);
                bodypropCount++;
            }

            if (bodyDEPARTMENTL6 != null)
            {
                body["DEPARTMENT_L6"] = ExpressionConverter.ConvertO(bodyDEPARTMENTL6);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee(Expression<Func<string>> account, Expression<Func<bodyemployeesInputItem[]>> bodyemployees = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId, Expression<Func<string>> bodyAPPROVEDTOVALIDATE = null, Expression<Func<string>> bodyAVAILABILITYSTATUSID = null, Expression<Func<string>> bodyAVAILABLEFIELD1 = null, Expression<Func<string>> bodyAVAILABLEFIELD2 = null, Expression<Func<string>> bodyAVAILABLEFIELD3 = null, Expression<Func<string>> bodyAVAILABLEFIELD4 = null, Expression<Func<string>> bodyAVAILABLEFIELD5 = null, Expression<Func<string>> bodyAVAILABLEFIELD6 = null, Expression<Func<string>> bodyBEGINOFCONTRACT = null, Expression<Func<string>> bodyCELLULARNUMBER = null, Expression<Func<string>> bodyCHATLOGIN = null, Expression<Func<string>> bodyCIVILSTATUSID = null, Expression<Func<string>> bodyCOMMENTEMPLOYEE = null, Expression<Func<string>> bodyCOSTPERHOUR = null, Expression<Func<string>> bodyCOSTPERHOURCURID = null, Expression<Func<string>> bodyDEFAULTCOSTCENTERID = null, Expression<Func<string>> bodyDELEGATIONFROM = null, Expression<Func<string>> bodyDELEGATIONID = null, Expression<Func<string>> bodyDELEGATIONTO = null, Expression<Func<string>> bodyDEPARTMENTID = null, Expression<Func<string>> bodyENDOFCONTRACT = null, Expression<Func<string>> bodyEMAIL = null, Expression<Func<string>> bodyFAXNUMBER = null, Expression<Func<string>> bodyFUNCTIONID = null, Expression<Func<string>> bodyICQNUMBER = null, Expression<Func<string>> bodyIDENTIFICATION = null, Expression<Func<string>> bodyISAUTOMATICSTATUS = null, Expression<Func<string>> bodyITCORRESPONDENT = null, Expression<Func<string>> bodyLANGUAGEID = null, Expression<Func<string>> bodyLASTINTEGRATION = null, Expression<Func<string>> bodyLASTNAME = null, Expression<Func<string>> bodyLASTUPDATE = null, Expression<Func<string>> bodyLOCATIONID = null, Expression<Func<string>> bodyLOGIN = null, Expression<Func<string>> bodyMANAGERID = null, Expression<Func<string>> bodyMESSENGERSIGNNAME = null, Expression<Func<string>> bodyNOTIFICATIONTYPEID = null, Expression<Func<string>> bodyPASSWDLASTUPDATEUT = null, Expression<Func<string>> bodyPHONENUMBER = null, Expression<Func<string>> bodyPICTUREPATH = null, Expression<Func<string>> bodySUPPLIERID = null, Expression<Func<string>> bodyVALIDATORID = null, Expression<Func<string>> bodyVIPLEVELID = null, Expression<Func<string>> bodyWAVEADDRESS = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAPPROVEDTOVALIDATE != null)
            {
                body["APPROVED_TO_VALIDATE"] = ExpressionConverter.ConvertO(bodyAPPROVEDTOVALIDATE);
                bodypropCount++;
            }

            if (bodyAVAILABILITYSTATUSID != null)
            {
                body["AVAILABILITY_STATUS_ID"] = ExpressionConverter.ConvertO(bodyAVAILABILITYSTATUSID);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodyBEGINOFCONTRACT != null)
            {
                body["BEGIN_OF_CONTRACT"] = ExpressionConverter.ConvertO(bodyBEGINOFCONTRACT);
                bodypropCount++;
            }

            if (bodyCELLULARNUMBER != null)
            {
                body["CELLULAR_NUMBER"] = ExpressionConverter.ConvertO(bodyCELLULARNUMBER);
                bodypropCount++;
            }

            if (bodyCHATLOGIN != null)
            {
                body["CHAT_LOGIN"] = ExpressionConverter.ConvertO(bodyCHATLOGIN);
                bodypropCount++;
            }

            if (bodyCIVILSTATUSID != null)
            {
                body["CIVIL_STATUS_ID"] = ExpressionConverter.ConvertO(bodyCIVILSTATUSID);
                bodypropCount++;
            }

            if (bodyCOMMENTEMPLOYEE != null)
            {
                body["COMMENT_EMPLOYEE"] = ExpressionConverter.ConvertO(bodyCOMMENTEMPLOYEE);
                bodypropCount++;
            }

            if (bodyCOSTPERHOUR != null)
            {
                body["COST_PER_HOUR"] = ExpressionConverter.ConvertO(bodyCOSTPERHOUR);
                bodypropCount++;
            }

            if (bodyCOSTPERHOURCURID != null)
            {
                body["COST_PER_HOUR_CUR_ID"] = ExpressionConverter.ConvertO(bodyCOSTPERHOURCURID);
                bodypropCount++;
            }

            if (bodyDEFAULTCOSTCENTERID != null)
            {
                body["DEFAULT_COST_CENTER_ID"] = ExpressionConverter.ConvertO(bodyDEFAULTCOSTCENTERID);
                bodypropCount++;
            }

            if (bodyDELEGATIONFROM != null)
            {
                body["DELEGATION_FROM"] = ExpressionConverter.ConvertO(bodyDELEGATIONFROM);
                bodypropCount++;
            }

            if (bodyDELEGATIONID != null)
            {
                body["DELEGATION_ID"] = ExpressionConverter.ConvertO(bodyDELEGATIONID);
                bodypropCount++;
            }

            if (bodyDELEGATIONTO != null)
            {
                body["DELEGATION_TO"] = ExpressionConverter.ConvertO(bodyDELEGATIONTO);
                bodypropCount++;
            }

            if (bodyDEPARTMENTID != null)
            {
                body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(bodyDEPARTMENTID);
                bodypropCount++;
            }

            if (bodyENDOFCONTRACT != null)
            {
                body["END_OF_CONTRACT"] = ExpressionConverter.ConvertO(bodyENDOFCONTRACT);
                bodypropCount++;
            }

            if (bodyEMAIL != null)
            {
                body["E_MAIL"] = ExpressionConverter.ConvertO(bodyEMAIL);
                bodypropCount++;
            }

            if (bodyFAXNUMBER != null)
            {
                body["FAX_NUMBER"] = ExpressionConverter.ConvertO(bodyFAXNUMBER);
                bodypropCount++;
            }

            if (bodyFUNCTIONID != null)
            {
                body["FUNCTION_ID"] = ExpressionConverter.ConvertO(bodyFUNCTIONID);
                bodypropCount++;
            }

            if (bodyICQNUMBER != null)
            {
                body["ICQ_NUMBER"] = ExpressionConverter.ConvertO(bodyICQNUMBER);
                bodypropCount++;
            }

            if (bodyIDENTIFICATION != null)
            {
                body["IDENTIFICATION"] = ExpressionConverter.ConvertO(bodyIDENTIFICATION);
                bodypropCount++;
            }

            if (bodyISAUTOMATICSTATUS != null)
            {
                body["IS_AUTOMATIC_STATUS"] = ExpressionConverter.ConvertO(bodyISAUTOMATICSTATUS);
                bodypropCount++;
            }

            if (bodyITCORRESPONDENT != null)
            {
                body["IT_CORRESPONDENT"] = ExpressionConverter.ConvertO(bodyITCORRESPONDENT);
                bodypropCount++;
            }

            if (bodyLANGUAGEID != null)
            {
                body["LANGUAGE_ID"] = ExpressionConverter.ConvertO(bodyLANGUAGEID);
                bodypropCount++;
            }

            if (bodyLASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodyLASTINTEGRATION);
                bodypropCount++;
            }

            if (bodyLASTNAME != null)
            {
                body["LAST_NAME"] = ExpressionConverter.ConvertO(bodyLASTNAME);
                bodypropCount++;
            }

            if (bodyLASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodyLASTUPDATE);
                bodypropCount++;
            }

            if (bodyLOCATIONID != null)
            {
                body["LOCATION_ID"] = ExpressionConverter.ConvertO(bodyLOCATIONID);
                bodypropCount++;
            }

            if (bodyLOGIN != null)
            {
                body["LOGIN"] = ExpressionConverter.ConvertO(bodyLOGIN);
                bodypropCount++;
            }

            if (bodyMANAGERID != null)
            {
                body["MANAGER_ID"] = ExpressionConverter.ConvertO(bodyMANAGERID);
                bodypropCount++;
            }

            if (bodyMESSENGERSIGNNAME != null)
            {
                body["MESSENGER_SIGN_NAME"] = ExpressionConverter.ConvertO(bodyMESSENGERSIGNNAME);
                bodypropCount++;
            }

            if (bodyNOTIFICATIONTYPEID != null)
            {
                body["NOTIFICATION_TYPE_ID"] = ExpressionConverter.ConvertO(bodyNOTIFICATIONTYPEID);
                bodypropCount++;
            }

            if (bodyPASSWDLASTUPDATEUT != null)
            {
                body["PASSWD_LAST_UPDATE_UT"] = ExpressionConverter.ConvertO(bodyPASSWDLASTUPDATEUT);
                bodypropCount++;
            }

            if (bodyPHONENUMBER != null)
            {
                body["PHONE_NUMBER"] = ExpressionConverter.ConvertO(bodyPHONENUMBER);
                bodypropCount++;
            }

            if (bodyPICTUREPATH != null)
            {
                body["PICTURE_PATH"] = ExpressionConverter.ConvertO(bodyPICTUREPATH);
                bodypropCount++;
            }

            if (bodySUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(bodySUPPLIERID);
                bodypropCount++;
            }

            if (bodyVALIDATORID != null)
            {
                body["VALIDATOR_ID"] = ExpressionConverter.ConvertO(bodyVALIDATORID);
                bodypropCount++;
            }

            if (bodyVIPLEVELID != null)
            {
                body["VIP_LEVEL_ID"] = ExpressionConverter.ConvertO(bodyVIPLEVELID);
                bodypropCount++;
            }

            if (bodyWAVEADDRESS != null)
            {
                body["WAVE_ADDRESS"] = ExpressionConverter.ConvertO(bodyWAVEADDRESS);
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
            var apiCallPath = String.Format("/api/v1/{0}/knownerrors", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors(Expression<Func<string>> account, Expression<Func<string>> kpId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/knownerrors/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(kpId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation(Expression<Func<string>> account, Expression<Func<string>> locationId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateLocationResponse> UpdateLocation(Expression<Func<string>> account, Expression<Func<string>> locationId, Expression<Func<string>> bodyPARENTLOCATIONID = null, Expression<Func<string>> bodyMANAGERID = null, Expression<Func<string>> bodyLOCATIONEN = null, Expression<Func<string>> bodyLOCATIONFR = null, Expression<Func<string>> bodyLOCATIONGE = null, Expression<Func<string>> bodyLOCATIONSP = null, Expression<Func<string>> bodyLOCATIONIT = null, Expression<Func<string>> bodyLOCATIONPO = null, Expression<Func<string>> bodySTREETADDRESS1 = null, Expression<Func<string>> bodySTREETADDRESS2 = null, Expression<Func<string>> bodyCITY = null, Expression<Func<string>> bodyPHONE = null, Expression<Func<string>> bodyZIPCODE = null, Expression<Func<string>> bodyFAX = null, Expression<Func<string>> bodyCOMMENTLOCATION = null, Expression<Func<string>> bodyREGIONZONEID = null, Expression<Func<string>> bodyCOUNTRYID = null, Expression<Func<string>> bodySTATEID = null, Expression<Func<string>> bodySTARTDATE = null, Expression<Func<string>> bodyENDDATE = null, Expression<Func<string>> bodyURLMAP = null, Expression<Func<string>> bodyDISCOVERYNAME = null, Expression<Func<string>> bodyLOCATIONCODE = null, Expression<Func<string>> bodyLASTUPDATE = null, Expression<Func<string>> bodyLASTINTEGRATION = null, Expression<Func<string>> bodyISDELIVERYADDRESS = null, Expression<Func<string>> bodyTIMEZONEID = null, Expression<Func<string>> bodySTATUSID = null, Expression<Func<string>> bodyAVAILABLEFIELD1 = null, Expression<Func<string>> bodyAVAILABLEFIELD2 = null, Expression<Func<string>> bodyAVAILABLEFIELD3 = null, Expression<Func<string>> bodyAVAILABLEFIELD4 = null, Expression<Func<string>> bodyAVAILABLEFIELD5 = null, Expression<Func<string>> bodyAVAILABLEFIELD6 = null, Expression<Func<string>> bodySLAID = null, Expression<Func<string>> bodyGMAPLAT = null, Expression<Func<string>> bodyGMAPLNG = null, Expression<Func<string>> bodyLOCATIONL1 = null, Expression<Func<string>> bodyLOCATIONL2 = null, Expression<Func<string>> bodyLOCATIONL3 = null, Expression<Func<string>> bodyLOCATIONL4 = null, Expression<Func<string>> bodyLOCATIONL5 = null, Expression<Func<string>> bodyLOCATIONL6 = null, Expression<Func<string>> bodyEISMEETINGROOM = null, Expression<Func<string>> bodyECAPACITY = null, Expression<Func<string>> bodyEWIFILOGIN = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPARENTLOCATIONID != null)
            {
                body["PARENT_LOCATION_ID"] = ExpressionConverter.ConvertO(bodyPARENTLOCATIONID);
                bodypropCount++;
            }

            if (bodyMANAGERID != null)
            {
                body["MANAGER_ID"] = ExpressionConverter.ConvertO(bodyMANAGERID);
                bodypropCount++;
            }

            if (bodyLOCATIONEN != null)
            {
                body["LOCATION_EN"] = ExpressionConverter.ConvertO(bodyLOCATIONEN);
                bodypropCount++;
            }

            if (bodyLOCATIONFR != null)
            {
                body["LOCATION_FR"] = ExpressionConverter.ConvertO(bodyLOCATIONFR);
                bodypropCount++;
            }

            if (bodyLOCATIONGE != null)
            {
                body["LOCATION_GE"] = ExpressionConverter.ConvertO(bodyLOCATIONGE);
                bodypropCount++;
            }

            if (bodyLOCATIONSP != null)
            {
                body["LOCATION_SP"] = ExpressionConverter.ConvertO(bodyLOCATIONSP);
                bodypropCount++;
            }

            if (bodyLOCATIONIT != null)
            {
                body["LOCATION_IT"] = ExpressionConverter.ConvertO(bodyLOCATIONIT);
                bodypropCount++;
            }

            if (bodyLOCATIONPO != null)
            {
                body["LOCATION_PO"] = ExpressionConverter.ConvertO(bodyLOCATIONPO);
                bodypropCount++;
            }

            if (bodySTREETADDRESS1 != null)
            {
                body["STREET_ADDRESS_1"] = ExpressionConverter.ConvertO(bodySTREETADDRESS1);
                bodypropCount++;
            }

            if (bodySTREETADDRESS2 != null)
            {
                body["STREET_ADDRESS_2"] = ExpressionConverter.ConvertO(bodySTREETADDRESS2);
                bodypropCount++;
            }

            if (bodyCITY != null)
            {
                body["CITY"] = ExpressionConverter.ConvertO(bodyCITY);
                bodypropCount++;
            }

            if (bodyPHONE != null)
            {
                body["PHONE"] = ExpressionConverter.ConvertO(bodyPHONE);
                bodypropCount++;
            }

            if (bodyZIPCODE != null)
            {
                body["ZIP_CODE"] = ExpressionConverter.ConvertO(bodyZIPCODE);
                bodypropCount++;
            }

            if (bodyFAX != null)
            {
                body["FAX"] = ExpressionConverter.ConvertO(bodyFAX);
                bodypropCount++;
            }

            if (bodyCOMMENTLOCATION != null)
            {
                body["COMMENT_LOCATION"] = ExpressionConverter.ConvertO(bodyCOMMENTLOCATION);
                bodypropCount++;
            }

            if (bodyREGIONZONEID != null)
            {
                body["REGION_ZONE_ID"] = ExpressionConverter.ConvertO(bodyREGIONZONEID);
                bodypropCount++;
            }

            if (bodyCOUNTRYID != null)
            {
                body["COUNTRY_ID"] = ExpressionConverter.ConvertO(bodyCOUNTRYID);
                bodypropCount++;
            }

            if (bodySTATEID != null)
            {
                body["STATE_ID"] = ExpressionConverter.ConvertO(bodySTATEID);
                bodypropCount++;
            }

            if (bodySTARTDATE != null)
            {
                body["START_DATE"] = ExpressionConverter.ConvertO(bodySTARTDATE);
                bodypropCount++;
            }

            if (bodyENDDATE != null)
            {
                body["END_DATE"] = ExpressionConverter.ConvertO(bodyENDDATE);
                bodypropCount++;
            }

            if (bodyURLMAP != null)
            {
                body["URL_MAP"] = ExpressionConverter.ConvertO(bodyURLMAP);
                bodypropCount++;
            }

            if (bodyDISCOVERYNAME != null)
            {
                body["DISCOVERY_NAME"] = ExpressionConverter.ConvertO(bodyDISCOVERYNAME);
                bodypropCount++;
            }

            if (bodyLOCATIONCODE != null)
            {
                body["LOCATION_CODE"] = ExpressionConverter.ConvertO(bodyLOCATIONCODE);
                bodypropCount++;
            }

            if (bodyLASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodyLASTUPDATE);
                bodypropCount++;
            }

            if (bodyLASTINTEGRATION != null)
            {
                body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(bodyLASTINTEGRATION);
                bodypropCount++;
            }

            if (bodyISDELIVERYADDRESS != null)
            {
                body["IS_DELIVERY_ADDRESS"] = ExpressionConverter.ConvertO(bodyISDELIVERYADDRESS);
                bodypropCount++;
            }

            if (bodyTIMEZONEID != null)
            {
                body["TIME_ZONE_ID"] = ExpressionConverter.ConvertO(bodyTIMEZONEID);
                bodypropCount++;
            }

            if (bodySTATUSID != null)
            {
                body["STATUS_ID"] = ExpressionConverter.ConvertO(bodySTATUSID);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodySLAID != null)
            {
                body["SLA_ID"] = ExpressionConverter.ConvertO(bodySLAID);
                bodypropCount++;
            }

            if (bodyGMAPLAT != null)
            {
                body["G_MAP_LAT"] = ExpressionConverter.ConvertO(bodyGMAPLAT);
                bodypropCount++;
            }

            if (bodyGMAPLNG != null)
            {
                body["G_MAP_LNG"] = ExpressionConverter.ConvertO(bodyGMAPLNG);
                bodypropCount++;
            }

            if (bodyLOCATIONL1 != null)
            {
                body["LOCATION_L1"] = ExpressionConverter.ConvertO(bodyLOCATIONL1);
                bodypropCount++;
            }

            if (bodyLOCATIONL2 != null)
            {
                body["LOCATION_L2"] = ExpressionConverter.ConvertO(bodyLOCATIONL2);
                bodypropCount++;
            }

            if (bodyLOCATIONL3 != null)
            {
                body["LOCATION_L3"] = ExpressionConverter.ConvertO(bodyLOCATIONL3);
                bodypropCount++;
            }

            if (bodyLOCATIONL4 != null)
            {
                body["LOCATION_L4"] = ExpressionConverter.ConvertO(bodyLOCATIONL4);
                bodypropCount++;
            }

            if (bodyLOCATIONL5 != null)
            {
                body["LOCATION_L5"] = ExpressionConverter.ConvertO(bodyLOCATIONL5);
                bodypropCount++;
            }

            if (bodyLOCATIONL6 != null)
            {
                body["LOCATION_L6"] = ExpressionConverter.ConvertO(bodyLOCATIONL6);
                bodypropCount++;
            }

            if (bodyEISMEETINGROOM != null)
            {
                body["E_IS_MEETING_ROOM"] = ExpressionConverter.ConvertO(bodyEISMEETINGROOM);
                bodypropCount++;
            }

            if (bodyECAPACITY != null)
            {
                body["E_CAPACITY"] = ExpressionConverter.ConvertO(bodyECAPACITY);
                bodypropCount++;
            }

            if (bodyEWIFILOGIN != null)
            {
                body["E_WIFI_LOGIN"] = ExpressionConverter.ConvertO(bodyEWIFILOGIN);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer(Expression<Func<string>> account, Expression<Func<string>> manufacturerId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/manufacturers/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(manufacturerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident(Expression<Func<string>> account, Expression<Func<bodyrequestsInputItem[]>> bodyrequests = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodyclosedInputItem[]>> bodyclosed = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyAnalyticalChargeId = null, Expression<Func<string>> bodyAssetId = null, Expression<Func<string>> bodyAvailableField1 = null, Expression<Func<string>> bodyAvailableField2 = null, Expression<Func<string>> bodyAvailableField3 = null, Expression<Func<string>> bodyAvailableField4 = null, Expression<Func<string>> bodyAvailableField5 = null, Expression<Func<string>> bodyAvailableField6 = null, Expression<Func<string>> bodyBudgetPlanned = null, Expression<Func<string>> bodyCanBeDuplicated = null, Expression<Func<string>> bodyCiId = null, Expression<Func<string>> bodyComment = null, Expression<Func<string>> bodyContinuityPlanId = null, Expression<Func<string>> bodyCostCenterId = null, Expression<Func<string>> bodyCreationDateUt = null, Expression<Func<string>> bodyDelay = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyDynamicDetails = null, Expression<Func<string>> bodyEffectiveChangeDateEnd = null, Expression<Func<string>> bodyEffectiveChangeDateStart = null, Expression<Func<string>> bodyEndDateUt = null, Expression<Func<string>> bodyEstimatedNetPrice = null, Expression<Func<string>> bodyExpectedDateUt = null, Expression<Func<string>> bodyExpectedDuration = null, Expression<Func<string>> bodyExpectedEndDateUt = null, Expression<Func<string>> bodyExpectedStartDateUt = null, Expression<Func<string>> bodyExternalReference = null, Expression<Func<string>> bodyFirstCallResolution = null, Expression<Func<string>> bodyHourPerDay = null, Expression<Func<string>> bodyImpactId = null, Expression<Func<string>> bodyImputationDate = null, Expression<Func<string>> bodyIsMajorIncident = null, Expression<Func<string>> bodyIsTemplate = null, Expression<Func<string>> bodyKnownProblemsId = null, Expression<Func<string>> bodyLastUpdate = null, Expression<Func<string>> bodyMark1 = null, Expression<Func<string>> bodyMark2 = null, Expression<Func<string>> bodyMaxResolutionDateUt = null, Expression<Func<string>> bodyMsProjectImportValidationWaiting = null, Expression<Func<string>> bodyNetPrice = null, Expression<Func<string>> bodyNetPriceCurId = null, Expression<Func<string>> bodyOriginToolId = null, Expression<Func<string>> bodyOwnerId = null, Expression<Func<string>> bodyOwningGroupId = null, Expression<Func<string>> bodyPlannedChangeDateEnd = null, Expression<Func<string>> bodyPlannedChangeDateStart = null, Expression<Func<string>> bodyPmStatusId = null, Expression<Func<string>> bodyProjectName = null, Expression<Func<string>> bodyProjectStartDateUt = null, Expression<Func<string>> bodyQty = null, Expression<Func<string>> bodyReleaseId = null, Expression<Func<string>> bodyRentalNetPrice = null, Expression<Func<string>> bodyRentalNetPriceCurId = null, Expression<Func<string>> bodyRequestOriginId = null, Expression<Func<string>> bodyRequestedChangeDateEnd = null, Expression<Func<string>> bodyRequestedChangeDateStart = null, Expression<Func<string>> bodyRequestorId = null, Expression<Func<string>> bodyRequestorIpAddress = null, Expression<Func<string>> bodyRequestorPhone = null, Expression<Func<string>> bodyRiskAmount = null, Expression<Func<string>> bodyRiskDescription = null, Expression<Func<string>> bodyRiskLevelId = null, Expression<Func<string>> bodyRootCauseId = null, Expression<Func<string>> bodySubmitDateUt = null, Expression<Func<string>> bodyTimeUsedToSolveRequest = null, Expression<Func<string>> bodyTitle = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAnalyticalChargeId != null)
            {
                body["Analytical_Charge_Id"] = ExpressionConverter.ConvertO(bodyAnalyticalChargeId);
                bodypropCount++;
            }

            if (bodyAssetId != null)
            {
                body["Asset_Id"] = ExpressionConverter.ConvertO(bodyAssetId);
                bodypropCount++;
            }

            if (bodyAvailableField1 != null)
            {
                body["Available_Field_1"] = ExpressionConverter.ConvertO(bodyAvailableField1);
                bodypropCount++;
            }

            if (bodyAvailableField2 != null)
            {
                body["Available_Field_2"] = ExpressionConverter.ConvertO(bodyAvailableField2);
                bodypropCount++;
            }

            if (bodyAvailableField3 != null)
            {
                body["Available_Field_3"] = ExpressionConverter.ConvertO(bodyAvailableField3);
                bodypropCount++;
            }

            if (bodyAvailableField4 != null)
            {
                body["Available_Field_4"] = ExpressionConverter.ConvertO(bodyAvailableField4);
                bodypropCount++;
            }

            if (bodyAvailableField5 != null)
            {
                body["Available_Field_5"] = ExpressionConverter.ConvertO(bodyAvailableField5);
                bodypropCount++;
            }

            if (bodyAvailableField6 != null)
            {
                body["Available_Field_6"] = ExpressionConverter.ConvertO(bodyAvailableField6);
                bodypropCount++;
            }

            if (bodyBudgetPlanned != null)
            {
                body["Budget_Planned"] = ExpressionConverter.ConvertO(bodyBudgetPlanned);
                bodypropCount++;
            }

            if (bodyCanBeDuplicated != null)
            {
                body["Can_Be_Duplicated"] = ExpressionConverter.ConvertO(bodyCanBeDuplicated);
                bodypropCount++;
            }

            if (bodyCiId != null)
            {
                body["Ci_Id"] = ExpressionConverter.ConvertO(bodyCiId);
                bodypropCount++;
            }

            if (bodyComment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
                bodypropCount++;
            }

            if (bodyContinuityPlanId != null)
            {
                body["Continuity_Plan_Id"] = ExpressionConverter.ConvertO(bodyContinuityPlanId);
                bodypropCount++;
            }

            if (bodyCostCenterId != null)
            {
                body["Cost_Center_Id"] = ExpressionConverter.ConvertO(bodyCostCenterId);
                bodypropCount++;
            }

            if (bodyCreationDateUt != null)
            {
                body["Creation_Date_Ut"] = ExpressionConverter.ConvertO(bodyCreationDateUt);
                bodypropCount++;
            }

            if (bodyDelay != null)
            {
                body["Delay"] = ExpressionConverter.ConvertO(bodyDelay);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyDynamicDetails != null)
            {
                body["Dynamic_Details"] = ExpressionConverter.ConvertO(bodyDynamicDetails);
                bodypropCount++;
            }

            if (bodyEffectiveChangeDateEnd != null)
            {
                body["Effective_Change_Date_End"] = ExpressionConverter.ConvertO(bodyEffectiveChangeDateEnd);
                bodypropCount++;
            }

            if (bodyEffectiveChangeDateStart != null)
            {
                body["Effective_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyEffectiveChangeDateStart);
                bodypropCount++;
            }

            if (bodyEndDateUt != null)
            {
                body["End_Date_Ut"] = ExpressionConverter.ConvertO(bodyEndDateUt);
                bodypropCount++;
            }

            if (bodyEstimatedNetPrice != null)
            {
                body["Estimated_Net_Price"] = ExpressionConverter.ConvertO(bodyEstimatedNetPrice);
                bodypropCount++;
            }

            if (bodyExpectedDateUt != null)
            {
                body["Expected_Date_Ut"] = ExpressionConverter.ConvertO(bodyExpectedDateUt);
                bodypropCount++;
            }

            if (bodyExpectedDuration != null)
            {
                body["Expected_Duration"] = ExpressionConverter.ConvertO(bodyExpectedDuration);
                bodypropCount++;
            }

            if (bodyExpectedEndDateUt != null)
            {
                body["Expected_End_Date_Ut"] = ExpressionConverter.ConvertO(bodyExpectedEndDateUt);
                bodypropCount++;
            }

            if (bodyExpectedStartDateUt != null)
            {
                body["Expected_Start_Date_Ut"] = ExpressionConverter.ConvertO(bodyExpectedStartDateUt);
                bodypropCount++;
            }

            if (bodyExternalReference != null)
            {
                body["External_Reference"] = ExpressionConverter.ConvertO(bodyExternalReference);
                bodypropCount++;
            }

            if (bodyFirstCallResolution != null)
            {
                body["First_Call_Resolution"] = ExpressionConverter.ConvertO(bodyFirstCallResolution);
                bodypropCount++;
            }

            if (bodyHourPerDay != null)
            {
                body["Hour_Per_Day"] = ExpressionConverter.ConvertO(bodyHourPerDay);
                bodypropCount++;
            }

            if (bodyImpactId != null)
            {
                body["Impact_Id"] = ExpressionConverter.ConvertO(bodyImpactId);
                bodypropCount++;
            }

            if (bodyImputationDate != null)
            {
                body["Imputation_Date"] = ExpressionConverter.ConvertO(bodyImputationDate);
                bodypropCount++;
            }

            if (bodyIsMajorIncident != null)
            {
                body["Is_Major_Incident"] = ExpressionConverter.ConvertO(bodyIsMajorIncident);
                bodypropCount++;
            }

            if (bodyIsTemplate != null)
            {
                body["Is_Template"] = ExpressionConverter.ConvertO(bodyIsTemplate);
                bodypropCount++;
            }

            if (bodyKnownProblemsId != null)
            {
                body["Known_Problems_Id"] = ExpressionConverter.ConvertO(bodyKnownProblemsId);
                bodypropCount++;
            }

            if (bodyLastUpdate != null)
            {
                body["Last_Update"] = ExpressionConverter.ConvertO(bodyLastUpdate);
                bodypropCount++;
            }

            if (bodyMark1 != null)
            {
                body["Mark_1"] = ExpressionConverter.ConvertO(bodyMark1);
                bodypropCount++;
            }

            if (bodyMark2 != null)
            {
                body["Mark_2"] = ExpressionConverter.ConvertO(bodyMark2);
                bodypropCount++;
            }

            if (bodyMaxResolutionDateUt != null)
            {
                body["Max_Resolution_Date_Ut"] = ExpressionConverter.ConvertO(bodyMaxResolutionDateUt);
                bodypropCount++;
            }

            if (bodyMsProjectImportValidationWaiting != null)
            {
                body["Ms_Project_Import_Validation_Waiting"] = ExpressionConverter.ConvertO(bodyMsProjectImportValidationWaiting);
                bodypropCount++;
            }

            if (bodyNetPrice != null)
            {
                body["Net_Price"] = ExpressionConverter.ConvertO(bodyNetPrice);
                bodypropCount++;
            }

            if (bodyNetPriceCurId != null)
            {
                body["Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(bodyNetPriceCurId);
                bodypropCount++;
            }

            if (bodyOriginToolId != null)
            {
                body["Origin_Tool_Id"] = ExpressionConverter.ConvertO(bodyOriginToolId);
                bodypropCount++;
            }

            if (bodyOwnerId != null)
            {
                body["Owner_Id"] = ExpressionConverter.ConvertO(bodyOwnerId);
                bodypropCount++;
            }

            if (bodyOwningGroupId != null)
            {
                body["Owning_Group_Id"] = ExpressionConverter.ConvertO(bodyOwningGroupId);
                bodypropCount++;
            }

            if (bodyPlannedChangeDateEnd != null)
            {
                body["Planned_Change_Date_End"] = ExpressionConverter.ConvertO(bodyPlannedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyPlannedChangeDateStart != null)
            {
                body["Planned_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyPlannedChangeDateStart);
                bodypropCount++;
            }

            if (bodyPmStatusId != null)
            {
                body["Pm_Status_Id"] = ExpressionConverter.ConvertO(bodyPmStatusId);
                bodypropCount++;
            }

            if (bodyProjectName != null)
            {
                body["Project_Name"] = ExpressionConverter.ConvertO(bodyProjectName);
                bodypropCount++;
            }

            if (bodyProjectStartDateUt != null)
            {
                body["Project_Start_Date_Ut"] = ExpressionConverter.ConvertO(bodyProjectStartDateUt);
                bodypropCount++;
            }

            if (bodyQty != null)
            {
                body["Qty"] = ExpressionConverter.ConvertO(bodyQty);
                bodypropCount++;
            }

            if (bodyReleaseId != null)
            {
                body["Release_Id"] = ExpressionConverter.ConvertO(bodyReleaseId);
                bodypropCount++;
            }

            if (bodyRentalNetPrice != null)
            {
                body["Rental_Net_Price"] = ExpressionConverter.ConvertO(bodyRentalNetPrice);
                bodypropCount++;
            }

            if (bodyRentalNetPriceCurId != null)
            {
                body["Rental_Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(bodyRentalNetPriceCurId);
                bodypropCount++;
            }

            if (bodyRequestOriginId != null)
            {
                body["Request_Origin_Id"] = ExpressionConverter.ConvertO(bodyRequestOriginId);
                bodypropCount++;
            }

            if (bodyRequestedChangeDateEnd != null)
            {
                body["Requested_Change_Date_End"] = ExpressionConverter.ConvertO(bodyRequestedChangeDateEnd);
                bodypropCount++;
            }

            if (bodyRequestedChangeDateStart != null)
            {
                body["Requested_Change_Date_Start"] = ExpressionConverter.ConvertO(bodyRequestedChangeDateStart);
                bodypropCount++;
            }

            if (bodyRequestorId != null)
            {
                body["Requestor_Id"] = ExpressionConverter.ConvertO(bodyRequestorId);
                bodypropCount++;
            }

            if (bodyRequestorIpAddress != null)
            {
                body["Requestor_Ip_Address"] = ExpressionConverter.ConvertO(bodyRequestorIpAddress);
                bodypropCount++;
            }

            if (bodyRequestorPhone != null)
            {
                body["Requestor_Phone"] = ExpressionConverter.ConvertO(bodyRequestorPhone);
                bodypropCount++;
            }

            if (bodyRiskAmount != null)
            {
                body["Risk_Amount"] = ExpressionConverter.ConvertO(bodyRiskAmount);
                bodypropCount++;
            }

            if (bodyRiskDescription != null)
            {
                body["Risk_Description"] = ExpressionConverter.ConvertO(bodyRiskDescription);
                bodypropCount++;
            }

            if (bodyRiskLevelId != null)
            {
                body["Risk_Level_Id"] = ExpressionConverter.ConvertO(bodyRiskLevelId);
                bodypropCount++;
            }

            if (bodyRootCauseId != null)
            {
                body["Root_Cause_Id"] = ExpressionConverter.ConvertO(bodyRootCauseId);
                bodypropCount++;
            }

            if (bodySubmitDateUt != null)
            {
                body["Submit_Date_Ut"] = ExpressionConverter.ConvertO(bodySubmitDateUt);
                bodypropCount++;
            }

            if (bodyTimeUsedToSolveRequest != null)
            {
                body["Time_Used_To_Solve_Request"] = ExpressionConverter.ConvertO(bodyTimeUsedToSolveRequest);
                bodypropCount++;
            }

            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
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
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/comment", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodydocumentsInputItem[]>> bodydocuments)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyComment = null, Expression<Func<int>> bodydoneById = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/restart", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyComment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyComment = null, Expression<Func<string>> bodydoneById = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/suspend", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyComment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyactionTypeId, Expression<Func<string>> bodyElapsedTime = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycontractualCost = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodygroupMail = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodystartDateUt = null, Expression<Func<string>> bodytimeCost = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/tasks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyElapsedTime != null)
            {
                body["Elapsed_Time"] = ExpressionConverter.ConvertO(bodyElapsedTime);
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

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla(Expression<Func<string>> account, Expression<Func<string>> slaId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/slas/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewSlaResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesAssetsResponse> ViewAllAtributesAssets(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/asset-characteristics", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllAtributesAssetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction CreateLinkBetweenAttributandAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/characteristics/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(characteristicId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateanAttributeofanAssetResponse> UpdateanAttributeofanAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId, Expression<Func<string>> bodyDATA1 = null, Expression<Func<string>> bodyDATA2 = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/characteristics/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(characteristicId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDATA1 != null)
            {
                body["DATA_1"] = ExpressionConverter.ConvertO(bodyDATA1);
                bodypropCount++;
            }

            if (bodyDATA2 != null)
            {
                body["DATA_2"] = ExpressionConverter.ConvertO(bodyDATA2);
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
                body["assets"] = ExpressionConverter.ConvertO(bodyassets);
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
            var apiCallPath = String.Format("/api/v1/50006/configuration-items/{0}", ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateCIunavailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<EndCIunavailabilityResponse> EndCIunavailability(Expression<Func<string>> ciId)
        {
            var apiCallPath = String.Format("/api/v1/50006/configuration-items/{0}", ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EndCIunavailabilityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactonCIResponse> ViewlinksimpactonCI(Expression<Func<string>> ciId)
        {
            var apiCallPath = String.Format("/api/v1/50006/configuration-items/{0}/item-links/impacting", ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewlinksimpactonCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactbyCIResponse> ViewlinksimpactbyCI(Expression<Func<string>> ciId)
        {
            var apiCallPath = String.Format("/api/v1/50006/configuration-items/{0}/item-links/impacted", ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewlinksimpactbyCIResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewTicketStatusListResponse> ViewTicketStatusList(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewTicketStatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedTicketsResponse> ViewListProblemsAttachedTickets(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/problem-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsAttachedTicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedATicketsResponse> ViewListProblemsAttachedATickets(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/problems", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsAttachedATicketsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListTicketsAttachedtoaProblemResponse> ViewListTicketsAttachedtoaProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/problems/{1}/requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListTicketsAttachedtoaProblemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsResponse> ViewListQuestions(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsWithResponseResponse> ViewListQuestionsWithResponse(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions-result", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionsWithResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewaQuestionResponse> ViewaQuestion(Expression<Func<string>> account, Expression<Func<string>> questionId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewaQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllResponsesListQuestionsofaTicketResponse> ViewAllResponsesListQuestionsofaTicket(Expression<Func<string>> account, Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions-result/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllResponsesListQuestionsofaTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewResponseQuestionTicketResponse> ViewResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewResponseQuestionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateResponseQuestionTicketResponse> CreateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyRESULT = null, Expression<Func<string>> bodyRESULTSTRINGEN = null, Expression<Func<string>> bodyRESULTSTRINGFR = null, Expression<Func<string>> bodyRESULTSTRINGSP = null, Expression<Func<string>> bodyRESULTSTRINGGE = null, Expression<Func<string>> bodyRESULTSTRINGIT = null, Expression<Func<string>> bodyRESULTSTRINGPO = null, Expression<Func<string>> bodyRESULTDATE = null, Expression<Func<string>> bodyRESULTNUMBER = null, Expression<Func<string>> bodyRESULTBIT = null, Expression<Func<string>> bodyRESULTORDER = null, Expression<Func<string>> bodyRESULTSTRINGL1 = null, Expression<Func<string>> bodyRESULTSTRINGL2 = null, Expression<Func<string>> bodyRESULTSTRINGL3 = null, Expression<Func<string>> bodyRESULTSTRINGL4 = null, Expression<Func<string>> bodyRESULTSTRINGL5 = null, Expression<Func<string>> bodyRESULTSTRINGL6 = null, Expression<Func<string>> bodyQUESTIONDISPLAYED = null, Expression<Func<string>> bodyDOCUMENTID = null, Expression<Func<string>> bodyQUESTIONREQUIRED = null, Expression<Func<string>> bodyISCONDITIONNAL = null, Expression<Func<string>> bodyRESULTDURATION = null, Expression<Func<string>> bodySYSQUESTIONNAIREID = null, Expression<Func<string>> bodyORIGINTOOLID = null, Expression<Func<string>> bodyLASTQUESTIONNAIRE = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyRESULT != null)
            {
                body["RESULT"] = ExpressionConverter.ConvertO(bodyRESULT);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGEN != null)
            {
                body["RESULT_STRING_EN"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGEN);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGFR != null)
            {
                body["RESULT_STRING_FR"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGFR);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGSP != null)
            {
                body["RESULT_STRING_SP"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGSP);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGGE != null)
            {
                body["RESULT_STRING_GE"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGGE);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGIT != null)
            {
                body["RESULT_STRING_IT"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGIT);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGPO != null)
            {
                body["RESULT_STRING_PO"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGPO);
                bodypropCount++;
            }

            if (bodyRESULTDATE != null)
            {
                body["RESULT_DATE"] = ExpressionConverter.ConvertO(bodyRESULTDATE);
                bodypropCount++;
            }

            if (bodyRESULTNUMBER != null)
            {
                body["RESULT_NUMBER"] = ExpressionConverter.ConvertO(bodyRESULTNUMBER);
                bodypropCount++;
            }

            if (bodyRESULTBIT != null)
            {
                body["RESULT_BIT"] = ExpressionConverter.ConvertO(bodyRESULTBIT);
                bodypropCount++;
            }

            if (bodyRESULTORDER != null)
            {
                body["RESULT_ORDER"] = ExpressionConverter.ConvertO(bodyRESULTORDER);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL1 != null)
            {
                body["RESULT_STRING_L1"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL1);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL2 != null)
            {
                body["RESULT_STRING_L2"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL2);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL3 != null)
            {
                body["RESULT_STRING_L3"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL3);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL4 != null)
            {
                body["RESULT_STRING_L4"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL4);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL5 != null)
            {
                body["RESULT_STRING_L5"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL5);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL6 != null)
            {
                body["RESULT_STRING_L6"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL6);
                bodypropCount++;
            }

            if (bodyQUESTIONDISPLAYED != null)
            {
                body["QUESTION_DISPLAYED"] = ExpressionConverter.ConvertO(bodyQUESTIONDISPLAYED);
                bodypropCount++;
            }

            if (bodyDOCUMENTID != null)
            {
                body["DOCUMENT_ID"] = ExpressionConverter.ConvertO(bodyDOCUMENTID);
                bodypropCount++;
            }

            if (bodyQUESTIONREQUIRED != null)
            {
                body["QUESTION_REQUIRED"] = ExpressionConverter.ConvertO(bodyQUESTIONREQUIRED);
                bodypropCount++;
            }

            if (bodyISCONDITIONNAL != null)
            {
                body["IS_CONDITIONNAL"] = ExpressionConverter.ConvertO(bodyISCONDITIONNAL);
                bodypropCount++;
            }

            if (bodyRESULTDURATION != null)
            {
                body["RESULT_DURATION"] = ExpressionConverter.ConvertO(bodyRESULTDURATION);
                bodypropCount++;
            }

            if (bodySYSQUESTIONNAIREID != null)
            {
                body["SYS_QUESTIONNAIRE_ID"] = ExpressionConverter.ConvertO(bodySYSQUESTIONNAIREID);
                bodypropCount++;
            }

            if (bodyORIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(bodyORIGINTOOLID);
                bodypropCount++;
            }

            if (bodyLASTQUESTIONNAIRE != null)
            {
                body["LAST_QUESTIONNAIRE"] = ExpressionConverter.ConvertO(bodyLASTQUESTIONNAIRE);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateResponseQuestionTicketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateResponseQuestionTicketResponse> UpdateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyRESULT = null, Expression<Func<string>> bodyRESULTSTRINGEN = null, Expression<Func<string>> bodyRESULTSTRINGFR = null, Expression<Func<string>> bodyRESULTSTRINGSP = null, Expression<Func<string>> bodyRESULTSTRINGGE = null, Expression<Func<string>> bodyRESULTSTRINGIT = null, Expression<Func<string>> bodyRESULTSTRINGPO = null, Expression<Func<string>> bodyRESULTDATE = null, Expression<Func<string>> bodyRESULTNUMBER = null, Expression<Func<string>> bodyRESULTBIT = null, Expression<Func<string>> bodyRESULTORDER = null, Expression<Func<string>> bodyRESULTSTRINGL1 = null, Expression<Func<string>> bodyRESULTSTRINGL2 = null, Expression<Func<string>> bodyRESULTSTRINGL3 = null, Expression<Func<string>> bodyRESULTSTRINGL4 = null, Expression<Func<string>> bodyRESULTSTRINGL5 = null, Expression<Func<string>> bodyRESULTSTRINGL6 = null, Expression<Func<string>> bodyQUESTIONDISPLAYED = null, Expression<Func<string>> bodyDOCUMENTID = null, Expression<Func<string>> bodyQUESTIONREQUIRED = null, Expression<Func<string>> bodyISCONDITIONNAL = null, Expression<Func<string>> bodyRESULTDURATION = null, Expression<Func<string>> bodySYSQUESTIONNAIREID = null, Expression<Func<string>> bodyORIGINTOOLID = null, Expression<Func<string>> bodyLASTQUESTIONNAIRE = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(questionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyRESULT != null)
            {
                body["RESULT"] = ExpressionConverter.ConvertO(bodyRESULT);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGEN != null)
            {
                body["RESULT_STRING_EN"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGEN);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGFR != null)
            {
                body["RESULT_STRING_FR"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGFR);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGSP != null)
            {
                body["RESULT_STRING_SP"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGSP);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGGE != null)
            {
                body["RESULT_STRING_GE"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGGE);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGIT != null)
            {
                body["RESULT_STRING_IT"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGIT);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGPO != null)
            {
                body["RESULT_STRING_PO"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGPO);
                bodypropCount++;
            }

            if (bodyRESULTDATE != null)
            {
                body["RESULT_DATE"] = ExpressionConverter.ConvertO(bodyRESULTDATE);
                bodypropCount++;
            }

            if (bodyRESULTNUMBER != null)
            {
                body["RESULT_NUMBER"] = ExpressionConverter.ConvertO(bodyRESULTNUMBER);
                bodypropCount++;
            }

            if (bodyRESULTBIT != null)
            {
                body["RESULT_BIT"] = ExpressionConverter.ConvertO(bodyRESULTBIT);
                bodypropCount++;
            }

            if (bodyRESULTORDER != null)
            {
                body["RESULT_ORDER"] = ExpressionConverter.ConvertO(bodyRESULTORDER);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL1 != null)
            {
                body["RESULT_STRING_L1"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL1);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL2 != null)
            {
                body["RESULT_STRING_L2"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL2);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL3 != null)
            {
                body["RESULT_STRING_L3"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL3);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL4 != null)
            {
                body["RESULT_STRING_L4"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL4);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL5 != null)
            {
                body["RESULT_STRING_L5"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL5);
                bodypropCount++;
            }

            if (bodyRESULTSTRINGL6 != null)
            {
                body["RESULT_STRING_L6"] = ExpressionConverter.ConvertO(bodyRESULTSTRINGL6);
                bodypropCount++;
            }

            if (bodyQUESTIONDISPLAYED != null)
            {
                body["QUESTION_DISPLAYED"] = ExpressionConverter.ConvertO(bodyQUESTIONDISPLAYED);
                bodypropCount++;
            }

            if (bodyDOCUMENTID != null)
            {
                body["DOCUMENT_ID"] = ExpressionConverter.ConvertO(bodyDOCUMENTID);
                bodypropCount++;
            }

            if (bodyQUESTIONREQUIRED != null)
            {
                body["QUESTION_REQUIRED"] = ExpressionConverter.ConvertO(bodyQUESTIONREQUIRED);
                bodypropCount++;
            }

            if (bodyISCONDITIONNAL != null)
            {
                body["IS_CONDITIONNAL"] = ExpressionConverter.ConvertO(bodyISCONDITIONNAL);
                bodypropCount++;
            }

            if (bodyRESULTDURATION != null)
            {
                body["RESULT_DURATION"] = ExpressionConverter.ConvertO(bodyRESULTDURATION);
                bodypropCount++;
            }

            if (bodySYSQUESTIONNAIREID != null)
            {
                body["SYS_QUESTIONNAIRE_ID"] = ExpressionConverter.ConvertO(bodySYSQUESTIONNAIREID);
                bodypropCount++;
            }

            if (bodyORIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(bodyORIGINTOOLID);
                bodypropCount++;
            }

            if (bodyLASTQUESTIONNAIRE != null)
            {
                body["LAST_QUESTIONNAIRE"] = ExpressionConverter.ConvertO(bodyLASTQUESTIONNAIRE);
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
            var apiCallPath = String.Format("/api/v1/{0}/questionnaires", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListQuestionnairesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewQuestionnaireResponse> ViewQuestionnaire(Expression<Func<string>> account, Expression<Func<string>> questionnaireId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/questionnaires/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(questionnaireId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsResponse> ViewListProblems(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/problems", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListProblemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewProblemResponse> ViewProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var apiCallPath = String.Format("/api/v1/{0}/problems/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewProblemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListNewsResponse> ViewListNews(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/news", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateNewsResponse> CreateNews(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/news", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewNewsResponse> ViewNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/news/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateNewsResponse> UpdateNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/news/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UpdateNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListActionsResponse> ViewListActions(Expression<Func<string>> account)
        {
            var apiCallPath = String.Format("/api/v1/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewListActionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateActionTicketResponse> CreateActionTicket(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyACTIONNUMBER = null, Expression<Func<string>> bodyASSETID = null, Expression<Func<string>> bodyPARENTACTIONID = null, Expression<Func<string>> bodySUPPLIERID = null, Expression<Func<string>> bodyDONEBYID = null, Expression<Func<string>> bodyVALIDATORID = null, Expression<Func<string>> bodyACTIONLABELEN = null, Expression<Func<string>> bodyTABLENAME = null, Expression<Func<string>> bodyFIELDNAME = null, Expression<Func<string>> bodyOLDVALUE = null, Expression<Func<string>> bodyNEWVALUE = null, Expression<Func<string>> bodyDELETEACTION = null, Expression<Func<string>> bodyAUTOMATICACTION = null, Expression<Func<string>> bodyPROCESSSTEPID = null, Expression<Func<string>> bodyREQUESTID = null, Expression<Func<string>> bodyDESCRIPTION = null, Expression<Func<string>> bodyNETCHARGE = null, Expression<Func<string>> bodyNETCHARGECURID = null, Expression<Func<string>> bodyRESOLUTION = null, Expression<Func<string>> bodyLOCATIONID = null, Expression<Func<string>> bodySUPPORTSTAFFID = null, Expression<Func<string>> bodyCONTACTID = null, Expression<Func<string>> bodyEXPECTEDENDDATEUT = null, Expression<Func<string>> bodyCOMMENT = null, Expression<Func<string>> bodySTARTDATEUT = null, Expression<Func<string>> bodyENDDATEUT = null, Expression<Func<string>> bodyRENEWALDATEUT = null, Expression<Func<string>> bodyEXPECTEDSTARTDATEUT = null, Expression<Func<string>> bodyCREATIONDATEUT = null, Expression<Func<string>> bodyAPPLICATIONDATEUT = null, Expression<Func<string>> bodyWIZARDGUID = null, Expression<Func<string>> bodyGROUPID = null, Expression<Func<string>> bodyACTIONLABELFR = null, Expression<Func<string>> bodyACTIONLABELSP = null, Expression<Func<string>> bodyACTIONLABELGE = null, Expression<Func<string>> bodyACTIONLABELIT = null, Expression<Func<string>> bodyACTIONLABELPO = null, Expression<Func<string>> bodyKNOWNPROBLEMID = null, Expression<Func<string>> bodyMAXINTERVENTIONDATEUT = null, Expression<Func<string>> bodyELAPSEDTIME = null, Expression<Func<string>> bodyPRIORITYID = null, Expression<Func<string>> bodyTAXID = null, Expression<Func<string>> bodySTATUSIDONCREATE = null, Expression<Func<string>> bodySTATUSIDONTERMINATE = null, Expression<Func<string>> bodyACTIONTYPEID = null, Expression<Func<string>> bodyDELAY = null, Expression<Func<string>> bodyAVAILABLEFIELD1 = null, Expression<Func<string>> bodyAVAILABLEFIELD2 = null, Expression<Func<string>> bodyAVAILABLEFIELD3 = null, Expression<Func<string>> bodyAVAILABLEFIELD4 = null, Expression<Func<string>> bodyAVAILABLEFIELD5 = null, Expression<Func<string>> bodyAVAILABLEFIELD6 = null, Expression<Func<string>> bodyTIMEUSEDTOCOMPLETEACTION = null, Expression<Func<string>> bodyCONTRACTUALCOST = null, Expression<Func<string>> bodyCONTRACTUALCOSTCURID = null, Expression<Func<string>> bodyTIMECOST = null, Expression<Func<string>> bodyTIMECOSTCURID = null, Expression<Func<string>> bodyORIGINACTIONID = null, Expression<Func<string>> bodyWORKFLOWVALUE = null, Expression<Func<string>> bodyCONTINUITYPLANID = null, Expression<Func<string>> bodyCATEGORYTESTID = null, Expression<Func<string>> bodyWORKFLOWID = null, Expression<Func<string>> bodyEXITVALUE = null, Expression<Func<string>> bodyMAXRESOLUTIONDATEUT = null, Expression<Func<string>> bodyPERCENTCOMPLETE = null, Expression<Func<string>> bodyEXPECTEDDURATION = null, Expression<Func<string>> bodyWBSTASK = null, Expression<Func<string>> bodyTASKPERSONCOSTPERHOUR = null, Expression<Func<string>> bodyTASKPLANNEDBUDGET = null, Expression<Func<string>> bodyESTIMATEDNETCHARGE = null, Expression<Func<string>> bodyPREVIOUSSIBLINGID = null, Expression<Func<string>> bodyACTIONLABELL1 = null, Expression<Func<string>> bodyACTIONLABELL2 = null, Expression<Func<string>> bodyACTIONLABELL3 = null, Expression<Func<string>> bodyACTIONLABELL4 = null, Expression<Func<string>> bodyACTIONLABELL5 = null, Expression<Func<string>> bodyACTIONLABELL6 = null, Expression<Func<string>> bodyHISTORYID = null, Expression<Func<string>> bodyTOTRUNC = null, Expression<Func<string>> bodySTAGEID = null, Expression<Func<string>> bodyISLOCKEDPROGRESSPOINT = null, Expression<Func<string>> bodyORIGINTOOLID = null, Expression<Func<string>> bodyLASTUPDATE = null, Expression<Func<string>> bodyELASTDATESUPDATE = null, Expression<Func<string>> bodyBILLEDTIME = null, Expression<Func<string>> bodyISBILLINGREVIEWED = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/actions", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyACTIONNUMBER != null)
            {
                body["ACTION_NUMBER"] = ExpressionConverter.ConvertO(bodyACTIONNUMBER);
                bodypropCount++;
            }

            if (bodyASSETID != null)
            {
                body["ASSET_ID"] = ExpressionConverter.ConvertO(bodyASSETID);
                bodypropCount++;
            }

            if (bodyPARENTACTIONID != null)
            {
                body["PARENT_ACTION_ID"] = ExpressionConverter.ConvertO(bodyPARENTACTIONID);
                bodypropCount++;
            }

            if (bodySUPPLIERID != null)
            {
                body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(bodySUPPLIERID);
                bodypropCount++;
            }

            if (bodyDONEBYID != null)
            {
                body["DONE_BY_ID"] = ExpressionConverter.ConvertO(bodyDONEBYID);
                bodypropCount++;
            }

            if (bodyVALIDATORID != null)
            {
                body["VALIDATOR_ID"] = ExpressionConverter.ConvertO(bodyVALIDATORID);
                bodypropCount++;
            }

            if (bodyACTIONLABELEN != null)
            {
                body["ACTION_LABEL_EN"] = ExpressionConverter.ConvertO(bodyACTIONLABELEN);
                bodypropCount++;
            }

            if (bodyTABLENAME != null)
            {
                body["TABLE_NAME"] = ExpressionConverter.ConvertO(bodyTABLENAME);
                bodypropCount++;
            }

            if (bodyFIELDNAME != null)
            {
                body["FIELD_NAME"] = ExpressionConverter.ConvertO(bodyFIELDNAME);
                bodypropCount++;
            }

            if (bodyOLDVALUE != null)
            {
                body["OLD_VALUE"] = ExpressionConverter.ConvertO(bodyOLDVALUE);
                bodypropCount++;
            }

            if (bodyNEWVALUE != null)
            {
                body["NEW_VALUE"] = ExpressionConverter.ConvertO(bodyNEWVALUE);
                bodypropCount++;
            }

            if (bodyDELETEACTION != null)
            {
                body["DELETE_ACTION"] = ExpressionConverter.ConvertO(bodyDELETEACTION);
                bodypropCount++;
            }

            if (bodyAUTOMATICACTION != null)
            {
                body["AUTOMATIC_ACTION"] = ExpressionConverter.ConvertO(bodyAUTOMATICACTION);
                bodypropCount++;
            }

            if (bodyPROCESSSTEPID != null)
            {
                body["PROCESS_STEP_ID"] = ExpressionConverter.ConvertO(bodyPROCESSSTEPID);
                bodypropCount++;
            }

            if (bodyREQUESTID != null)
            {
                body["REQUEST_ID"] = ExpressionConverter.ConvertO(bodyREQUESTID);
                bodypropCount++;
            }

            if (bodyDESCRIPTION != null)
            {
                body["DESCRIPTION"] = ExpressionConverter.ConvertO(bodyDESCRIPTION);
                bodypropCount++;
            }

            if (bodyNETCHARGE != null)
            {
                body["NET_CHARGE"] = ExpressionConverter.ConvertO(bodyNETCHARGE);
                bodypropCount++;
            }

            if (bodyNETCHARGECURID != null)
            {
                body["NET_CHARGE_CUR_ID"] = ExpressionConverter.ConvertO(bodyNETCHARGECURID);
                bodypropCount++;
            }

            if (bodyRESOLUTION != null)
            {
                body["RESOLUTION"] = ExpressionConverter.ConvertO(bodyRESOLUTION);
                bodypropCount++;
            }

            if (bodyLOCATIONID != null)
            {
                body["LOCATION_ID"] = ExpressionConverter.ConvertO(bodyLOCATIONID);
                bodypropCount++;
            }

            if (bodySUPPORTSTAFFID != null)
            {
                body["SUPPORT_STAFF_ID"] = ExpressionConverter.ConvertO(bodySUPPORTSTAFFID);
                bodypropCount++;
            }

            if (bodyCONTACTID != null)
            {
                body["CONTACT_ID"] = ExpressionConverter.ConvertO(bodyCONTACTID);
                bodypropCount++;
            }

            if (bodyEXPECTEDENDDATEUT != null)
            {
                body["EXPECTED_END_DATE_UT"] = ExpressionConverter.ConvertO(bodyEXPECTEDENDDATEUT);
                bodypropCount++;
            }

            if (bodyCOMMENT != null)
            {
                body["COMMENT"] = ExpressionConverter.ConvertO(bodyCOMMENT);
                bodypropCount++;
            }

            if (bodySTARTDATEUT != null)
            {
                body["START_DATE_UT"] = ExpressionConverter.ConvertO(bodySTARTDATEUT);
                bodypropCount++;
            }

            if (bodyENDDATEUT != null)
            {
                body["END_DATE_UT"] = ExpressionConverter.ConvertO(bodyENDDATEUT);
                bodypropCount++;
            }

            if (bodyRENEWALDATEUT != null)
            {
                body["RENEWAL_DATE_UT"] = ExpressionConverter.ConvertO(bodyRENEWALDATEUT);
                bodypropCount++;
            }

            if (bodyEXPECTEDSTARTDATEUT != null)
            {
                body["EXPECTED_START_DATE_UT"] = ExpressionConverter.ConvertO(bodyEXPECTEDSTARTDATEUT);
                bodypropCount++;
            }

            if (bodyCREATIONDATEUT != null)
            {
                body["CREATION_DATE_UT"] = ExpressionConverter.ConvertO(bodyCREATIONDATEUT);
                bodypropCount++;
            }

            if (bodyAPPLICATIONDATEUT != null)
            {
                body["APPLICATION_DATE_UT"] = ExpressionConverter.ConvertO(bodyAPPLICATIONDATEUT);
                bodypropCount++;
            }

            if (bodyWIZARDGUID != null)
            {
                body["WIZARD_GUID"] = ExpressionConverter.ConvertO(bodyWIZARDGUID);
                bodypropCount++;
            }

            if (bodyGROUPID != null)
            {
                body["GROUP_ID"] = ExpressionConverter.ConvertO(bodyGROUPID);
                bodypropCount++;
            }

            if (bodyACTIONLABELFR != null)
            {
                body["ACTION_LABEL_FR"] = ExpressionConverter.ConvertO(bodyACTIONLABELFR);
                bodypropCount++;
            }

            if (bodyACTIONLABELSP != null)
            {
                body["ACTION_LABEL_SP"] = ExpressionConverter.ConvertO(bodyACTIONLABELSP);
                bodypropCount++;
            }

            if (bodyACTIONLABELGE != null)
            {
                body["ACTION_LABEL_GE"] = ExpressionConverter.ConvertO(bodyACTIONLABELGE);
                bodypropCount++;
            }

            if (bodyACTIONLABELIT != null)
            {
                body["ACTION_LABEL_IT"] = ExpressionConverter.ConvertO(bodyACTIONLABELIT);
                bodypropCount++;
            }

            if (bodyACTIONLABELPO != null)
            {
                body["ACTION_LABEL_PO"] = ExpressionConverter.ConvertO(bodyACTIONLABELPO);
                bodypropCount++;
            }

            if (bodyKNOWNPROBLEMID != null)
            {
                body["KNOWN_PROBLEM_ID"] = ExpressionConverter.ConvertO(bodyKNOWNPROBLEMID);
                bodypropCount++;
            }

            if (bodyMAXINTERVENTIONDATEUT != null)
            {
                body["MAX_INTERVENTION_DATE_UT"] = ExpressionConverter.ConvertO(bodyMAXINTERVENTIONDATEUT);
                bodypropCount++;
            }

            if (bodyELAPSEDTIME != null)
            {
                body["ELAPSED_TIME"] = ExpressionConverter.ConvertO(bodyELAPSEDTIME);
                bodypropCount++;
            }

            if (bodyPRIORITYID != null)
            {
                body["PRIORITY_ID"] = ExpressionConverter.ConvertO(bodyPRIORITYID);
                bodypropCount++;
            }

            if (bodyTAXID != null)
            {
                body["TAX_ID"] = ExpressionConverter.ConvertO(bodyTAXID);
                bodypropCount++;
            }

            if (bodySTATUSIDONCREATE != null)
            {
                body["STATUS_ID_ON_CREATE"] = ExpressionConverter.ConvertO(bodySTATUSIDONCREATE);
                bodypropCount++;
            }

            if (bodySTATUSIDONTERMINATE != null)
            {
                body["STATUS_ID_ON_TERMINATE"] = ExpressionConverter.ConvertO(bodySTATUSIDONTERMINATE);
                bodypropCount++;
            }

            if (bodyACTIONTYPEID != null)
            {
                body["ACTION_TYPE_ID"] = ExpressionConverter.ConvertO(bodyACTIONTYPEID);
                bodypropCount++;
            }

            if (bodyDELAY != null)
            {
                body["DELAY"] = ExpressionConverter.ConvertO(bodyDELAY);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD1 != null)
            {
                body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD1);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD2 != null)
            {
                body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD2);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD3 != null)
            {
                body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD3);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD4 != null)
            {
                body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD4);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD5 != null)
            {
                body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD5);
                bodypropCount++;
            }

            if (bodyAVAILABLEFIELD6 != null)
            {
                body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(bodyAVAILABLEFIELD6);
                bodypropCount++;
            }

            if (bodyTIMEUSEDTOCOMPLETEACTION != null)
            {
                body["TIME_USED_TO_COMPLETE_ACTION"] = ExpressionConverter.ConvertO(bodyTIMEUSEDTOCOMPLETEACTION);
                bodypropCount++;
            }

            if (bodyCONTRACTUALCOST != null)
            {
                body["CONTRACTUAL_COST"] = ExpressionConverter.ConvertO(bodyCONTRACTUALCOST);
                bodypropCount++;
            }

            if (bodyCONTRACTUALCOSTCURID != null)
            {
                body["CONTRACTUAL_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodyCONTRACTUALCOSTCURID);
                bodypropCount++;
            }

            if (bodyTIMECOST != null)
            {
                body["TIME_COST"] = ExpressionConverter.ConvertO(bodyTIMECOST);
                bodypropCount++;
            }

            if (bodyTIMECOSTCURID != null)
            {
                body["TIME_COST_CUR_ID"] = ExpressionConverter.ConvertO(bodyTIMECOSTCURID);
                bodypropCount++;
            }

            if (bodyORIGINACTIONID != null)
            {
                body["ORIGIN_ACTION_ID"] = ExpressionConverter.ConvertO(bodyORIGINACTIONID);
                bodypropCount++;
            }

            if (bodyWORKFLOWVALUE != null)
            {
                body["WORKFLOW_VALUE"] = ExpressionConverter.ConvertO(bodyWORKFLOWVALUE);
                bodypropCount++;
            }

            if (bodyCONTINUITYPLANID != null)
            {
                body["CONTINUITY_PLAN_ID"] = ExpressionConverter.ConvertO(bodyCONTINUITYPLANID);
                bodypropCount++;
            }

            if (bodyCATEGORYTESTID != null)
            {
                body["CATEGORY_TEST_ID"] = ExpressionConverter.ConvertO(bodyCATEGORYTESTID);
                bodypropCount++;
            }

            if (bodyWORKFLOWID != null)
            {
                body["WORKFLOW_ID"] = ExpressionConverter.ConvertO(bodyWORKFLOWID);
                bodypropCount++;
            }

            if (bodyEXITVALUE != null)
            {
                body["EXIT_VALUE"] = ExpressionConverter.ConvertO(bodyEXITVALUE);
                bodypropCount++;
            }

            if (bodyMAXRESOLUTIONDATEUT != null)
            {
                body["MAX_RESOLUTION_DATE_UT"] = ExpressionConverter.ConvertO(bodyMAXRESOLUTIONDATEUT);
                bodypropCount++;
            }

            if (bodyPERCENTCOMPLETE != null)
            {
                body["PERCENT_COMPLETE"] = ExpressionConverter.ConvertO(bodyPERCENTCOMPLETE);
                bodypropCount++;
            }

            if (bodyEXPECTEDDURATION != null)
            {
                body["EXPECTED_DURATION"] = ExpressionConverter.ConvertO(bodyEXPECTEDDURATION);
                bodypropCount++;
            }

            if (bodyWBSTASK != null)
            {
                body["WBS_TASK"] = ExpressionConverter.ConvertO(bodyWBSTASK);
                bodypropCount++;
            }

            if (bodyTASKPERSONCOSTPERHOUR != null)
            {
                body["TASK_PERSON_COST_PER_HOUR"] = ExpressionConverter.ConvertO(bodyTASKPERSONCOSTPERHOUR);
                bodypropCount++;
            }

            if (bodyTASKPLANNEDBUDGET != null)
            {
                body["TASK_PLANNED_BUDGET"] = ExpressionConverter.ConvertO(bodyTASKPLANNEDBUDGET);
                bodypropCount++;
            }

            if (bodyESTIMATEDNETCHARGE != null)
            {
                body["ESTIMATED_NET_CHARGE"] = ExpressionConverter.ConvertO(bodyESTIMATEDNETCHARGE);
                bodypropCount++;
            }

            if (bodyPREVIOUSSIBLINGID != null)
            {
                body["PREVIOUS_SIBLING_ID"] = ExpressionConverter.ConvertO(bodyPREVIOUSSIBLINGID);
                bodypropCount++;
            }

            if (bodyACTIONLABELL1 != null)
            {
                body["ACTION_LABEL_L1"] = ExpressionConverter.ConvertO(bodyACTIONLABELL1);
                bodypropCount++;
            }

            if (bodyACTIONLABELL2 != null)
            {
                body["ACTION_LABEL_L2"] = ExpressionConverter.ConvertO(bodyACTIONLABELL2);
                bodypropCount++;
            }

            if (bodyACTIONLABELL3 != null)
            {
                body["ACTION_LABEL_L3"] = ExpressionConverter.ConvertO(bodyACTIONLABELL3);
                bodypropCount++;
            }

            if (bodyACTIONLABELL4 != null)
            {
                body["ACTION_LABEL_L4"] = ExpressionConverter.ConvertO(bodyACTIONLABELL4);
                bodypropCount++;
            }

            if (bodyACTIONLABELL5 != null)
            {
                body["ACTION_LABEL_L5"] = ExpressionConverter.ConvertO(bodyACTIONLABELL5);
                bodypropCount++;
            }

            if (bodyACTIONLABELL6 != null)
            {
                body["ACTION_LABEL_L6"] = ExpressionConverter.ConvertO(bodyACTIONLABELL6);
                bodypropCount++;
            }

            if (bodyHISTORYID != null)
            {
                body["HISTORY_ID"] = ExpressionConverter.ConvertO(bodyHISTORYID);
                bodypropCount++;
            }

            if (bodyTOTRUNC != null)
            {
                body["TO_TRUNC"] = ExpressionConverter.ConvertO(bodyTOTRUNC);
                bodypropCount++;
            }

            if (bodySTAGEID != null)
            {
                body["STAGE_ID"] = ExpressionConverter.ConvertO(bodySTAGEID);
                bodypropCount++;
            }

            if (bodyISLOCKEDPROGRESSPOINT != null)
            {
                body["IS_LOCKED_PROGRESS_POINT"] = ExpressionConverter.ConvertO(bodyISLOCKEDPROGRESSPOINT);
                bodypropCount++;
            }

            if (bodyORIGINTOOLID != null)
            {
                body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(bodyORIGINTOOLID);
                bodypropCount++;
            }

            if (bodyLASTUPDATE != null)
            {
                body["LAST_UPDATE"] = ExpressionConverter.ConvertO(bodyLASTUPDATE);
                bodypropCount++;
            }

            if (bodyELASTDATESUPDATE != null)
            {
                body["E_LAST_DATES_UPDATE"] = ExpressionConverter.ConvertO(bodyELASTDATESUPDATE);
                bodypropCount++;
            }

            if (bodyBILLEDTIME != null)
            {
                body["BILLED_TIME"] = ExpressionConverter.ConvertO(bodyBILLEDTIME);
                bodypropCount++;
            }

            if (bodyISBILLINGREVIEWED != null)
            {
                body["IS_BILLING_REVIEWED"] = ExpressionConverter.ConvertO(bodyISBILLINGREVIEWED);
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
            var apiCallPath = String.Format("/api/v1/{0}/asset-characteristics/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ViewAllAtributesofanAssetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/{0}/requests/{1}/documents/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateCIResponse> UpdateCI(Expression<Func<string>> account, Expression<Func<string>> ciId, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodypurchasePrice = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyestimatedPercentageUse = null, Expression<Func<string>> bodyinstallationDate = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var apiCallPath = String.Format("/api/v1/{0}/assets/{1}/", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyassetLabel != null)
            {
                body["asset_label"] = ExpressionConverter.ConvertO(bodyassetLabel);
                bodypropCount++;
            }

            if (bodypurchasePrice != null)
            {
                body["purchase_price"] = ExpressionConverter.ConvertO(bodypurchasePrice);
                bodypropCount++;
            }

            if (bodyautomaticRenewal != null)
            {
                body["automatic_renewal"] = ExpressionConverter.ConvertO(bodyautomaticRenewal);
                bodypropCount++;
            }

            if (bodyestimatedPercentageUse != null)
            {
                body["estimated_percentage_use"] = ExpressionConverter.ConvertO(bodyestimatedPercentageUse);
                bodypropCount++;
            }

            if (bodyinstallationDate != null)
            {
                body["installation_date"] = ExpressionConverter.ConvertO(bodyinstallationDate);
                bodypropCount++;
            }

            if (bodyavailableField1 != null)
            {
                body["available_field_1"] = ExpressionConverter.ConvertO(bodyavailableField1);
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

            return new ApiConnectionAction<UpdateCIResponse>(callPayload);
        }
    }

    public class EasyvistaservicemanaTriggers([ConnectionName] string connectionId)
    {
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