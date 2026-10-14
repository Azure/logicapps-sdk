//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvistaservicemana
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EasyvistaservicemanaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<FinishActionResponse> FinishAction(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyendActiondescription = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyendActiondescription = bodyendActiondescription == null ? null : WorkflowExpression.Compile(bodyendActiondescription);
            WorkflowExpression.Validate(__workflow_bodyendActiondescription, nameof(bodyendActiondescription), required: false);
            return new DeferredBodyAction<FinishActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var endActionObject = new JObject();
                var endActionObjectpropCount = 0;
                if (__workflow_bodyendActiondescription != null)
                {
                    endActionObject["Description"] = ExpressionConverter.ConvertO(__workflow_bodyendActiondescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewAssetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset(Expression<Func<string>> account, Expression<Func<bodyassetsInputItem[]>> bodyassets = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_bodyassets = bodyassets == null ? null : WorkflowExpression.Compile(bodyassets);
            WorkflowExpression.Validate(__workflow_bodyassets, nameof(bodyassets), required: false);
            return new DeferredBodyAction<CreateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassets != null)
                {
                    body["assets"] = ExpressionConverter.ConvertO(__workflow_bodyassets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> bodybEFORELOANDEPARTMENTID = null, Expression<Func<string>> bodybEFORELOANEMPLOYEEID = null, Expression<Func<string>> bodybEFORELOANLOCATIONID = null, Expression<Func<string>> bodybILLINGPERIODICITYINMONTH = null, Expression<Func<string>> bodybUYBACKVALUE = null, Expression<Func<string>> bodybUYBACKVALUECURID = null, Expression<Func<string>> bodycATALOGID = null, Expression<Func<string>> bodycHARGEBACK = null, Expression<Func<string>> bodycHARGEBACKCURID = null, Expression<Func<string>> bodycISTATUSID = null, Expression<Func<string>> bodycIVERSION = null, Expression<Func<string>> bodycMDEFAULTCHANGEID = null, Expression<Func<string>> bodycONFIGURATIONID = null, Expression<Func<string>> bodycRITICALLEVELID = null, Expression<Func<string>> bodydELIVERYDATE = null, Expression<Func<string>> bodydELIVERYNUMBER = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodydEPRECIATIONRULEID = null, Expression<Func<string>> bodydHARDWAREGUID = null, Expression<Func<string>> bodyeMPLOYEEID = null, Expression<Func<string>> bodyeNDOFWARANTY = null, Expression<Func<string>> bodyeNTRYDATE = null, Expression<Func<string>> bodyeSTIMATEDPERCENTAGEUSE = null, Expression<Func<string>> bodyeXPECTEDENDLENDDATE = null, Expression<Func<string>> bodyeXPECTEDRETURNDATE = null, Expression<Func<string>> bodyfALLENTERM = null, Expression<Func<string>> bodyfIXEDASSETNUMBER = null, Expression<Func<string>> bodyiNITIALSTART = null, Expression<Func<string>> bodyiNSTALLATIONDATE = null, Expression<Func<string>> bodyiNTERNALDELIVERYDATE = null, Expression<Func<string>> bodyiNVOICENUMBER = null, Expression<Func<string>> bodyiSDML = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTPHYSICALINVENTORY = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylICENSEVERSION = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodymAINTENANCECOST = null, Expression<Func<string>> bodymAINTENANCECOSTCURID = null, Expression<Func<string>> bodymAINUSAGEID = null, Expression<Func<string>> bodymAXINSTALLS = null, Expression<Func<string>> bodymONTHLYFIXEDCOST = null, Expression<Func<string>> bodymONTHLYFIXEDCOSTCURID = null, Expression<Func<string>> bodymONTHLYNETRENTAL = null, Expression<Func<string>> bodymONTHLYNETRENTALCURID = null, Expression<Func<string>> bodymONTHDURATION = null, Expression<Func<string>> bodynETWORKIDENTIFIER = null, Expression<Func<string>> bodynEXTDEPARTMENTID = null, Expression<Func<string>> bodynEXTMAINTENANCEDATE = null, Expression<Func<string>> bodynEXTSTATUSID = null, Expression<Func<string>> bodynEXTUSERAPPLICATIONDATE = null, Expression<Func<string>> bodynEXTUSERID = null, Expression<Func<string>> bodynOTICE = null, Expression<Func<string>> bodyoRDERDETAILSID = null, Expression<Func<string>> bodyoRDERNUMBER = null, Expression<Func<string>> bodypIPELINESTATUSID = null, Expression<Func<string>> bodypOWERCONSUMPTIONWH = null, Expression<Func<string>> bodypROCESSORCOUNT = null, Expression<Func<string>> bodypROCESSORSOCKETCOUNT = null, Expression<Func<string>> bodypURCHASEDATE = null, Expression<Func<string>> bodypURCHASEPRICE = null, Expression<Func<string>> bodypURCHASEPRICECURID = null, Expression<Func<string>> bodypURCHASERATEID = null, Expression<Func<string>> bodyrECYCLEDDATE = null, Expression<Func<string>> bodyrECYCLINGPROVIDERID = null, Expression<Func<string>> bodyrEFORMNUMBER = null, Expression<Func<string>> bodyrEMOVEDDATE = null, Expression<Func<string>> bodyrENEWALDECISIONID = null, Expression<Func<string>> bodyrENEWALVALUE = null, Expression<Func<string>> bodyrENEWALVALUECURID = null, Expression<Func<string>> bodyrEPAIREDBYID = null, Expression<Func<string>> bodyrESALESVALUE = null, Expression<Func<string>> bodysCHEDULEDEND = null, Expression<Func<string>> bodysDCATALOGID = null, Expression<Func<string>> bodysERIALNUMBER = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodysTATUSID = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodytERM = null, Expression<Func<string>> bodyuPDATECOVERAGETERM = null, Expression<Func<string>> bodywARANTYTYPEID = null, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyavailabilitySlaId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_bodybEFORELOANDEPARTMENTID = bodybEFORELOANDEPARTMENTID == null ? null : WorkflowExpression.Compile(bodybEFORELOANDEPARTMENTID);
            WorkflowExpression.Validate(__workflow_bodybEFORELOANDEPARTMENTID, nameof(bodybEFORELOANDEPARTMENTID), required: false);
            var __workflow_bodybEFORELOANEMPLOYEEID = bodybEFORELOANEMPLOYEEID == null ? null : WorkflowExpression.Compile(bodybEFORELOANEMPLOYEEID);
            WorkflowExpression.Validate(__workflow_bodybEFORELOANEMPLOYEEID, nameof(bodybEFORELOANEMPLOYEEID), required: false);
            var __workflow_bodybEFORELOANLOCATIONID = bodybEFORELOANLOCATIONID == null ? null : WorkflowExpression.Compile(bodybEFORELOANLOCATIONID);
            WorkflowExpression.Validate(__workflow_bodybEFORELOANLOCATIONID, nameof(bodybEFORELOANLOCATIONID), required: false);
            var __workflow_bodybILLINGPERIODICITYINMONTH = bodybILLINGPERIODICITYINMONTH == null ? null : WorkflowExpression.Compile(bodybILLINGPERIODICITYINMONTH);
            WorkflowExpression.Validate(__workflow_bodybILLINGPERIODICITYINMONTH, nameof(bodybILLINGPERIODICITYINMONTH), required: false);
            var __workflow_bodybUYBACKVALUE = bodybUYBACKVALUE == null ? null : WorkflowExpression.Compile(bodybUYBACKVALUE);
            WorkflowExpression.Validate(__workflow_bodybUYBACKVALUE, nameof(bodybUYBACKVALUE), required: false);
            var __workflow_bodybUYBACKVALUECURID = bodybUYBACKVALUECURID == null ? null : WorkflowExpression.Compile(bodybUYBACKVALUECURID);
            WorkflowExpression.Validate(__workflow_bodybUYBACKVALUECURID, nameof(bodybUYBACKVALUECURID), required: false);
            var __workflow_bodycATALOGID = bodycATALOGID == null ? null : WorkflowExpression.Compile(bodycATALOGID);
            WorkflowExpression.Validate(__workflow_bodycATALOGID, nameof(bodycATALOGID), required: false);
            var __workflow_bodycHARGEBACK = bodycHARGEBACK == null ? null : WorkflowExpression.Compile(bodycHARGEBACK);
            WorkflowExpression.Validate(__workflow_bodycHARGEBACK, nameof(bodycHARGEBACK), required: false);
            var __workflow_bodycHARGEBACKCURID = bodycHARGEBACKCURID == null ? null : WorkflowExpression.Compile(bodycHARGEBACKCURID);
            WorkflowExpression.Validate(__workflow_bodycHARGEBACKCURID, nameof(bodycHARGEBACKCURID), required: false);
            var __workflow_bodycISTATUSID = bodycISTATUSID == null ? null : WorkflowExpression.Compile(bodycISTATUSID);
            WorkflowExpression.Validate(__workflow_bodycISTATUSID, nameof(bodycISTATUSID), required: false);
            var __workflow_bodycIVERSION = bodycIVERSION == null ? null : WorkflowExpression.Compile(bodycIVERSION);
            WorkflowExpression.Validate(__workflow_bodycIVERSION, nameof(bodycIVERSION), required: false);
            var __workflow_bodycMDEFAULTCHANGEID = bodycMDEFAULTCHANGEID == null ? null : WorkflowExpression.Compile(bodycMDEFAULTCHANGEID);
            WorkflowExpression.Validate(__workflow_bodycMDEFAULTCHANGEID, nameof(bodycMDEFAULTCHANGEID), required: false);
            var __workflow_bodycONFIGURATIONID = bodycONFIGURATIONID == null ? null : WorkflowExpression.Compile(bodycONFIGURATIONID);
            WorkflowExpression.Validate(__workflow_bodycONFIGURATIONID, nameof(bodycONFIGURATIONID), required: false);
            var __workflow_bodycRITICALLEVELID = bodycRITICALLEVELID == null ? null : WorkflowExpression.Compile(bodycRITICALLEVELID);
            WorkflowExpression.Validate(__workflow_bodycRITICALLEVELID, nameof(bodycRITICALLEVELID), required: false);
            var __workflow_bodydELIVERYDATE = bodydELIVERYDATE == null ? null : WorkflowExpression.Compile(bodydELIVERYDATE);
            WorkflowExpression.Validate(__workflow_bodydELIVERYDATE, nameof(bodydELIVERYDATE), required: false);
            var __workflow_bodydELIVERYNUMBER = bodydELIVERYNUMBER == null ? null : WorkflowExpression.Compile(bodydELIVERYNUMBER);
            WorkflowExpression.Validate(__workflow_bodydELIVERYNUMBER, nameof(bodydELIVERYNUMBER), required: false);
            var __workflow_bodydEPARTMENTID = bodydEPARTMENTID == null ? null : WorkflowExpression.Compile(bodydEPARTMENTID);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            var __workflow_bodydEPRECIATIONRULEID = bodydEPRECIATIONRULEID == null ? null : WorkflowExpression.Compile(bodydEPRECIATIONRULEID);
            WorkflowExpression.Validate(__workflow_bodydEPRECIATIONRULEID, nameof(bodydEPRECIATIONRULEID), required: false);
            var __workflow_bodydHARDWAREGUID = bodydHARDWAREGUID == null ? null : WorkflowExpression.Compile(bodydHARDWAREGUID);
            WorkflowExpression.Validate(__workflow_bodydHARDWAREGUID, nameof(bodydHARDWAREGUID), required: false);
            var __workflow_bodyeMPLOYEEID = bodyeMPLOYEEID == null ? null : WorkflowExpression.Compile(bodyeMPLOYEEID);
            WorkflowExpression.Validate(__workflow_bodyeMPLOYEEID, nameof(bodyeMPLOYEEID), required: false);
            var __workflow_bodyeNDOFWARANTY = bodyeNDOFWARANTY == null ? null : WorkflowExpression.Compile(bodyeNDOFWARANTY);
            WorkflowExpression.Validate(__workflow_bodyeNDOFWARANTY, nameof(bodyeNDOFWARANTY), required: false);
            var __workflow_bodyeNTRYDATE = bodyeNTRYDATE == null ? null : WorkflowExpression.Compile(bodyeNTRYDATE);
            WorkflowExpression.Validate(__workflow_bodyeNTRYDATE, nameof(bodyeNTRYDATE), required: false);
            var __workflow_bodyeSTIMATEDPERCENTAGEUSE = bodyeSTIMATEDPERCENTAGEUSE == null ? null : WorkflowExpression.Compile(bodyeSTIMATEDPERCENTAGEUSE);
            WorkflowExpression.Validate(__workflow_bodyeSTIMATEDPERCENTAGEUSE, nameof(bodyeSTIMATEDPERCENTAGEUSE), required: false);
            var __workflow_bodyeXPECTEDENDLENDDATE = bodyeXPECTEDENDLENDDATE == null ? null : WorkflowExpression.Compile(bodyeXPECTEDENDLENDDATE);
            WorkflowExpression.Validate(__workflow_bodyeXPECTEDENDLENDDATE, nameof(bodyeXPECTEDENDLENDDATE), required: false);
            var __workflow_bodyeXPECTEDRETURNDATE = bodyeXPECTEDRETURNDATE == null ? null : WorkflowExpression.Compile(bodyeXPECTEDRETURNDATE);
            WorkflowExpression.Validate(__workflow_bodyeXPECTEDRETURNDATE, nameof(bodyeXPECTEDRETURNDATE), required: false);
            var __workflow_bodyfALLENTERM = bodyfALLENTERM == null ? null : WorkflowExpression.Compile(bodyfALLENTERM);
            WorkflowExpression.Validate(__workflow_bodyfALLENTERM, nameof(bodyfALLENTERM), required: false);
            var __workflow_bodyfIXEDASSETNUMBER = bodyfIXEDASSETNUMBER == null ? null : WorkflowExpression.Compile(bodyfIXEDASSETNUMBER);
            WorkflowExpression.Validate(__workflow_bodyfIXEDASSETNUMBER, nameof(bodyfIXEDASSETNUMBER), required: false);
            var __workflow_bodyiNITIALSTART = bodyiNITIALSTART == null ? null : WorkflowExpression.Compile(bodyiNITIALSTART);
            WorkflowExpression.Validate(__workflow_bodyiNITIALSTART, nameof(bodyiNITIALSTART), required: false);
            var __workflow_bodyiNSTALLATIONDATE = bodyiNSTALLATIONDATE == null ? null : WorkflowExpression.Compile(bodyiNSTALLATIONDATE);
            WorkflowExpression.Validate(__workflow_bodyiNSTALLATIONDATE, nameof(bodyiNSTALLATIONDATE), required: false);
            var __workflow_bodyiNTERNALDELIVERYDATE = bodyiNTERNALDELIVERYDATE == null ? null : WorkflowExpression.Compile(bodyiNTERNALDELIVERYDATE);
            WorkflowExpression.Validate(__workflow_bodyiNTERNALDELIVERYDATE, nameof(bodyiNTERNALDELIVERYDATE), required: false);
            var __workflow_bodyiNVOICENUMBER = bodyiNVOICENUMBER == null ? null : WorkflowExpression.Compile(bodyiNVOICENUMBER);
            WorkflowExpression.Validate(__workflow_bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            var __workflow_bodyiSDML = bodyiSDML == null ? null : WorkflowExpression.Compile(bodyiSDML);
            WorkflowExpression.Validate(__workflow_bodyiSDML, nameof(bodyiSDML), required: false);
            var __workflow_bodylASTINTEGRATION = bodylASTINTEGRATION == null ? null : WorkflowExpression.Compile(bodylASTINTEGRATION);
            WorkflowExpression.Validate(__workflow_bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodylASTPHYSICALINVENTORY = bodylASTPHYSICALINVENTORY == null ? null : WorkflowExpression.Compile(bodylASTPHYSICALINVENTORY);
            WorkflowExpression.Validate(__workflow_bodylASTPHYSICALINVENTORY, nameof(bodylASTPHYSICALINVENTORY), required: false);
            var __workflow_bodylASTUPDATE = bodylASTUPDATE == null ? null : WorkflowExpression.Compile(bodylASTUPDATE);
            WorkflowExpression.Validate(__workflow_bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylICENSEVERSION = bodylICENSEVERSION == null ? null : WorkflowExpression.Compile(bodylICENSEVERSION);
            WorkflowExpression.Validate(__workflow_bodylICENSEVERSION, nameof(bodylICENSEVERSION), required: false);
            var __workflow_bodylOCATIONID = bodylOCATIONID == null ? null : WorkflowExpression.Compile(bodylOCATIONID);
            WorkflowExpression.Validate(__workflow_bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            var __workflow_bodymAINTENANCECOST = bodymAINTENANCECOST == null ? null : WorkflowExpression.Compile(bodymAINTENANCECOST);
            WorkflowExpression.Validate(__workflow_bodymAINTENANCECOST, nameof(bodymAINTENANCECOST), required: false);
            var __workflow_bodymAINTENANCECOSTCURID = bodymAINTENANCECOSTCURID == null ? null : WorkflowExpression.Compile(bodymAINTENANCECOSTCURID);
            WorkflowExpression.Validate(__workflow_bodymAINTENANCECOSTCURID, nameof(bodymAINTENANCECOSTCURID), required: false);
            var __workflow_bodymAINUSAGEID = bodymAINUSAGEID == null ? null : WorkflowExpression.Compile(bodymAINUSAGEID);
            WorkflowExpression.Validate(__workflow_bodymAINUSAGEID, nameof(bodymAINUSAGEID), required: false);
            var __workflow_bodymAXINSTALLS = bodymAXINSTALLS == null ? null : WorkflowExpression.Compile(bodymAXINSTALLS);
            WorkflowExpression.Validate(__workflow_bodymAXINSTALLS, nameof(bodymAXINSTALLS), required: false);
            var __workflow_bodymONTHLYFIXEDCOST = bodymONTHLYFIXEDCOST == null ? null : WorkflowExpression.Compile(bodymONTHLYFIXEDCOST);
            WorkflowExpression.Validate(__workflow_bodymONTHLYFIXEDCOST, nameof(bodymONTHLYFIXEDCOST), required: false);
            var __workflow_bodymONTHLYFIXEDCOSTCURID = bodymONTHLYFIXEDCOSTCURID == null ? null : WorkflowExpression.Compile(bodymONTHLYFIXEDCOSTCURID);
            WorkflowExpression.Validate(__workflow_bodymONTHLYFIXEDCOSTCURID, nameof(bodymONTHLYFIXEDCOSTCURID), required: false);
            var __workflow_bodymONTHLYNETRENTAL = bodymONTHLYNETRENTAL == null ? null : WorkflowExpression.Compile(bodymONTHLYNETRENTAL);
            WorkflowExpression.Validate(__workflow_bodymONTHLYNETRENTAL, nameof(bodymONTHLYNETRENTAL), required: false);
            var __workflow_bodymONTHLYNETRENTALCURID = bodymONTHLYNETRENTALCURID == null ? null : WorkflowExpression.Compile(bodymONTHLYNETRENTALCURID);
            WorkflowExpression.Validate(__workflow_bodymONTHLYNETRENTALCURID, nameof(bodymONTHLYNETRENTALCURID), required: false);
            var __workflow_bodymONTHDURATION = bodymONTHDURATION == null ? null : WorkflowExpression.Compile(bodymONTHDURATION);
            WorkflowExpression.Validate(__workflow_bodymONTHDURATION, nameof(bodymONTHDURATION), required: false);
            var __workflow_bodynETWORKIDENTIFIER = bodynETWORKIDENTIFIER == null ? null : WorkflowExpression.Compile(bodynETWORKIDENTIFIER);
            WorkflowExpression.Validate(__workflow_bodynETWORKIDENTIFIER, nameof(bodynETWORKIDENTIFIER), required: false);
            var __workflow_bodynEXTDEPARTMENTID = bodynEXTDEPARTMENTID == null ? null : WorkflowExpression.Compile(bodynEXTDEPARTMENTID);
            WorkflowExpression.Validate(__workflow_bodynEXTDEPARTMENTID, nameof(bodynEXTDEPARTMENTID), required: false);
            var __workflow_bodynEXTMAINTENANCEDATE = bodynEXTMAINTENANCEDATE == null ? null : WorkflowExpression.Compile(bodynEXTMAINTENANCEDATE);
            WorkflowExpression.Validate(__workflow_bodynEXTMAINTENANCEDATE, nameof(bodynEXTMAINTENANCEDATE), required: false);
            var __workflow_bodynEXTSTATUSID = bodynEXTSTATUSID == null ? null : WorkflowExpression.Compile(bodynEXTSTATUSID);
            WorkflowExpression.Validate(__workflow_bodynEXTSTATUSID, nameof(bodynEXTSTATUSID), required: false);
            var __workflow_bodynEXTUSERAPPLICATIONDATE = bodynEXTUSERAPPLICATIONDATE == null ? null : WorkflowExpression.Compile(bodynEXTUSERAPPLICATIONDATE);
            WorkflowExpression.Validate(__workflow_bodynEXTUSERAPPLICATIONDATE, nameof(bodynEXTUSERAPPLICATIONDATE), required: false);
            var __workflow_bodynEXTUSERID = bodynEXTUSERID == null ? null : WorkflowExpression.Compile(bodynEXTUSERID);
            WorkflowExpression.Validate(__workflow_bodynEXTUSERID, nameof(bodynEXTUSERID), required: false);
            var __workflow_bodynOTICE = bodynOTICE == null ? null : WorkflowExpression.Compile(bodynOTICE);
            WorkflowExpression.Validate(__workflow_bodynOTICE, nameof(bodynOTICE), required: false);
            var __workflow_bodyoRDERDETAILSID = bodyoRDERDETAILSID == null ? null : WorkflowExpression.Compile(bodyoRDERDETAILSID);
            WorkflowExpression.Validate(__workflow_bodyoRDERDETAILSID, nameof(bodyoRDERDETAILSID), required: false);
            var __workflow_bodyoRDERNUMBER = bodyoRDERNUMBER == null ? null : WorkflowExpression.Compile(bodyoRDERNUMBER);
            WorkflowExpression.Validate(__workflow_bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            var __workflow_bodypIPELINESTATUSID = bodypIPELINESTATUSID == null ? null : WorkflowExpression.Compile(bodypIPELINESTATUSID);
            WorkflowExpression.Validate(__workflow_bodypIPELINESTATUSID, nameof(bodypIPELINESTATUSID), required: false);
            var __workflow_bodypOWERCONSUMPTIONWH = bodypOWERCONSUMPTIONWH == null ? null : WorkflowExpression.Compile(bodypOWERCONSUMPTIONWH);
            WorkflowExpression.Validate(__workflow_bodypOWERCONSUMPTIONWH, nameof(bodypOWERCONSUMPTIONWH), required: false);
            var __workflow_bodypROCESSORCOUNT = bodypROCESSORCOUNT == null ? null : WorkflowExpression.Compile(bodypROCESSORCOUNT);
            WorkflowExpression.Validate(__workflow_bodypROCESSORCOUNT, nameof(bodypROCESSORCOUNT), required: false);
            var __workflow_bodypROCESSORSOCKETCOUNT = bodypROCESSORSOCKETCOUNT == null ? null : WorkflowExpression.Compile(bodypROCESSORSOCKETCOUNT);
            WorkflowExpression.Validate(__workflow_bodypROCESSORSOCKETCOUNT, nameof(bodypROCESSORSOCKETCOUNT), required: false);
            var __workflow_bodypURCHASEDATE = bodypURCHASEDATE == null ? null : WorkflowExpression.Compile(bodypURCHASEDATE);
            WorkflowExpression.Validate(__workflow_bodypURCHASEDATE, nameof(bodypURCHASEDATE), required: false);
            var __workflow_bodypURCHASEPRICE = bodypURCHASEPRICE == null ? null : WorkflowExpression.Compile(bodypURCHASEPRICE);
            WorkflowExpression.Validate(__workflow_bodypURCHASEPRICE, nameof(bodypURCHASEPRICE), required: false);
            var __workflow_bodypURCHASEPRICECURID = bodypURCHASEPRICECURID == null ? null : WorkflowExpression.Compile(bodypURCHASEPRICECURID);
            WorkflowExpression.Validate(__workflow_bodypURCHASEPRICECURID, nameof(bodypURCHASEPRICECURID), required: false);
            var __workflow_bodypURCHASERATEID = bodypURCHASERATEID == null ? null : WorkflowExpression.Compile(bodypURCHASERATEID);
            WorkflowExpression.Validate(__workflow_bodypURCHASERATEID, nameof(bodypURCHASERATEID), required: false);
            var __workflow_bodyrECYCLEDDATE = bodyrECYCLEDDATE == null ? null : WorkflowExpression.Compile(bodyrECYCLEDDATE);
            WorkflowExpression.Validate(__workflow_bodyrECYCLEDDATE, nameof(bodyrECYCLEDDATE), required: false);
            var __workflow_bodyrECYCLINGPROVIDERID = bodyrECYCLINGPROVIDERID == null ? null : WorkflowExpression.Compile(bodyrECYCLINGPROVIDERID);
            WorkflowExpression.Validate(__workflow_bodyrECYCLINGPROVIDERID, nameof(bodyrECYCLINGPROVIDERID), required: false);
            var __workflow_bodyrEFORMNUMBER = bodyrEFORMNUMBER == null ? null : WorkflowExpression.Compile(bodyrEFORMNUMBER);
            WorkflowExpression.Validate(__workflow_bodyrEFORMNUMBER, nameof(bodyrEFORMNUMBER), required: false);
            var __workflow_bodyrEMOVEDDATE = bodyrEMOVEDDATE == null ? null : WorkflowExpression.Compile(bodyrEMOVEDDATE);
            WorkflowExpression.Validate(__workflow_bodyrEMOVEDDATE, nameof(bodyrEMOVEDDATE), required: false);
            var __workflow_bodyrENEWALDECISIONID = bodyrENEWALDECISIONID == null ? null : WorkflowExpression.Compile(bodyrENEWALDECISIONID);
            WorkflowExpression.Validate(__workflow_bodyrENEWALDECISIONID, nameof(bodyrENEWALDECISIONID), required: false);
            var __workflow_bodyrENEWALVALUE = bodyrENEWALVALUE == null ? null : WorkflowExpression.Compile(bodyrENEWALVALUE);
            WorkflowExpression.Validate(__workflow_bodyrENEWALVALUE, nameof(bodyrENEWALVALUE), required: false);
            var __workflow_bodyrENEWALVALUECURID = bodyrENEWALVALUECURID == null ? null : WorkflowExpression.Compile(bodyrENEWALVALUECURID);
            WorkflowExpression.Validate(__workflow_bodyrENEWALVALUECURID, nameof(bodyrENEWALVALUECURID), required: false);
            var __workflow_bodyrEPAIREDBYID = bodyrEPAIREDBYID == null ? null : WorkflowExpression.Compile(bodyrEPAIREDBYID);
            WorkflowExpression.Validate(__workflow_bodyrEPAIREDBYID, nameof(bodyrEPAIREDBYID), required: false);
            var __workflow_bodyrESALESVALUE = bodyrESALESVALUE == null ? null : WorkflowExpression.Compile(bodyrESALESVALUE);
            WorkflowExpression.Validate(__workflow_bodyrESALESVALUE, nameof(bodyrESALESVALUE), required: false);
            var __workflow_bodysCHEDULEDEND = bodysCHEDULEDEND == null ? null : WorkflowExpression.Compile(bodysCHEDULEDEND);
            WorkflowExpression.Validate(__workflow_bodysCHEDULEDEND, nameof(bodysCHEDULEDEND), required: false);
            var __workflow_bodysDCATALOGID = bodysDCATALOGID == null ? null : WorkflowExpression.Compile(bodysDCATALOGID);
            WorkflowExpression.Validate(__workflow_bodysDCATALOGID, nameof(bodysDCATALOGID), required: false);
            var __workflow_bodysERIALNUMBER = bodysERIALNUMBER == null ? null : WorkflowExpression.Compile(bodysERIALNUMBER);
            WorkflowExpression.Validate(__workflow_bodysERIALNUMBER, nameof(bodysERIALNUMBER), required: false);
            var __workflow_bodysLAID = bodysLAID == null ? null : WorkflowExpression.Compile(bodysLAID);
            WorkflowExpression.Validate(__workflow_bodysLAID, nameof(bodysLAID), required: false);
            var __workflow_bodysTATUSID = bodysTATUSID == null ? null : WorkflowExpression.Compile(bodysTATUSID);
            WorkflowExpression.Validate(__workflow_bodysTATUSID, nameof(bodysTATUSID), required: false);
            var __workflow_bodysUPPLIERID = bodysUPPLIERID == null ? null : WorkflowExpression.Compile(bodysUPPLIERID);
            WorkflowExpression.Validate(__workflow_bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            var __workflow_bodytERM = bodytERM == null ? null : WorkflowExpression.Compile(bodytERM);
            WorkflowExpression.Validate(__workflow_bodytERM, nameof(bodytERM), required: false);
            var __workflow_bodyuPDATECOVERAGETERM = bodyuPDATECOVERAGETERM == null ? null : WorkflowExpression.Compile(bodyuPDATECOVERAGETERM);
            WorkflowExpression.Validate(__workflow_bodyuPDATECOVERAGETERM, nameof(bodyuPDATECOVERAGETERM), required: false);
            var __workflow_bodywARANTYTYPEID = bodywARANTYTYPEID == null ? null : WorkflowExpression.Compile(bodywARANTYTYPEID);
            WorkflowExpression.Validate(__workflow_bodywARANTYTYPEID, nameof(bodywARANTYTYPEID), required: false);
            var __workflow_bodyassetLabel = bodyassetLabel == null ? null : WorkflowExpression.Compile(bodyassetLabel);
            WorkflowExpression.Validate(__workflow_bodyassetLabel, nameof(bodyassetLabel), required: false);
            var __workflow_bodyassetTag = bodyassetTag == null ? null : WorkflowExpression.Compile(bodyassetTag);
            WorkflowExpression.Validate(__workflow_bodyassetTag, nameof(bodyassetTag), required: false);
            var __workflow_bodyautomaticRenewal = bodyautomaticRenewal == null ? null : WorkflowExpression.Compile(bodyautomaticRenewal);
            WorkflowExpression.Validate(__workflow_bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            var __workflow_bodyavailabilitySlaId = bodyavailabilitySlaId == null ? null : WorkflowExpression.Compile(bodyavailabilitySlaId);
            WorkflowExpression.Validate(__workflow_bodyavailabilitySlaId, nameof(bodyavailabilitySlaId), required: false);
            var __workflow_bodyavailableField1 = bodyavailableField1 == null ? null : WorkflowExpression.Compile(bodyavailableField1);
            WorkflowExpression.Validate(__workflow_bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = bodyavailableField2 == null ? null : WorkflowExpression.Compile(bodyavailableField2);
            WorkflowExpression.Validate(__workflow_bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = bodyavailableField3 == null ? null : WorkflowExpression.Compile(bodyavailableField3);
            WorkflowExpression.Validate(__workflow_bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = bodyavailableField4 == null ? null : WorkflowExpression.Compile(bodyavailableField4);
            WorkflowExpression.Validate(__workflow_bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = bodyavailableField5 == null ? null : WorkflowExpression.Compile(bodyavailableField5);
            WorkflowExpression.Validate(__workflow_bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = bodyavailableField6 == null ? null : WorkflowExpression.Compile(bodyavailableField6);
            WorkflowExpression.Validate(__workflow_bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodycommentAsset = bodycommentAsset == null ? null : WorkflowExpression.Compile(bodycommentAsset);
            WorkflowExpression.Validate(__workflow_bodycommentAsset, nameof(bodycommentAsset), required: false);
            return new DeferredBodyAction<UpdateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybEFORELOANDEPARTMENTID != null)
                {
                    body["BEFORE_LOAN_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodybEFORELOANDEPARTMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodybEFORELOANEMPLOYEEID != null)
                {
                    body["BEFORE_LOAN_EMPLOYEE_ID"] = ExpressionConverter.ConvertO(__workflow_bodybEFORELOANEMPLOYEEID);
                    bodypropCount++;
                }

                if (__workflow_bodybEFORELOANLOCATIONID != null)
                {
                    body["BEFORE_LOAN_LOCATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodybEFORELOANLOCATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodybILLINGPERIODICITYINMONTH != null)
                {
                    body["BILLING_PERIODICITY_IN_MONTH"] = ExpressionConverter.ConvertO(__workflow_bodybILLINGPERIODICITYINMONTH);
                    bodypropCount++;
                }

                if (__workflow_bodybUYBACKVALUE != null)
                {
                    body["BUY_BACK_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodybUYBACKVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodybUYBACKVALUECURID != null)
                {
                    body["BUY_BACK_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodybUYBACKVALUECURID);
                    bodypropCount++;
                }

                if (__workflow_bodycATALOGID != null)
                {
                    body["CATALOG_ID"] = ExpressionConverter.ConvertO(__workflow_bodycATALOGID);
                    bodypropCount++;
                }

                if (__workflow_bodycHARGEBACK != null)
                {
                    body["CHARGE_BACK"] = ExpressionConverter.ConvertO(__workflow_bodycHARGEBACK);
                    bodypropCount++;
                }

                if (__workflow_bodycHARGEBACKCURID != null)
                {
                    body["CHARGE_BACK_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodycHARGEBACKCURID);
                    bodypropCount++;
                }

                if (__workflow_bodycISTATUSID != null)
                {
                    body["CI_STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodycISTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodycIVERSION != null)
                {
                    body["CI_VERSION"] = ExpressionConverter.ConvertO(__workflow_bodycIVERSION);
                    bodypropCount++;
                }

                if (__workflow_bodycMDEFAULTCHANGEID != null)
                {
                    body["CM_DEFAULT_CHANGE_ID"] = ExpressionConverter.ConvertO(__workflow_bodycMDEFAULTCHANGEID);
                    bodypropCount++;
                }

                if (__workflow_bodycONFIGURATIONID != null)
                {
                    body["CONFIGURATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodycONFIGURATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodycRITICALLEVELID != null)
                {
                    body["CRITICAL_LEVEL_ID"] = ExpressionConverter.ConvertO(__workflow_bodycRITICALLEVELID);
                    bodypropCount++;
                }

                if (__workflow_bodydELIVERYDATE != null)
                {
                    body["DELIVERY_DATE"] = ExpressionConverter.ConvertO(__workflow_bodydELIVERYDATE);
                    bodypropCount++;
                }

                if (__workflow_bodydELIVERYNUMBER != null)
                {
                    body["DELIVERY_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodydELIVERYNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTID != null)
                {
                    body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodydEPRECIATIONRULEID != null)
                {
                    body["DEPRECIATION_RULE_ID"] = ExpressionConverter.ConvertO(__workflow_bodydEPRECIATIONRULEID);
                    bodypropCount++;
                }

                if (__workflow_bodydHARDWAREGUID != null)
                {
                    body["D_HARDWARE_GUID"] = ExpressionConverter.ConvertO(__workflow_bodydHARDWAREGUID);
                    bodypropCount++;
                }

                if (__workflow_bodyeMPLOYEEID != null)
                {
                    body["EMPLOYEE_ID"] = ExpressionConverter.ConvertO(__workflow_bodyeMPLOYEEID);
                    bodypropCount++;
                }

                if (__workflow_bodyeNDOFWARANTY != null)
                {
                    body["END_OF_WARANTY"] = ExpressionConverter.ConvertO(__workflow_bodyeNDOFWARANTY);
                    bodypropCount++;
                }

                if (__workflow_bodyeNTRYDATE != null)
                {
                    body["ENTRY_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyeNTRYDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyeSTIMATEDPERCENTAGEUSE != null)
                {
                    body["ESTIMATED_PERCENTAGE_USE"] = ExpressionConverter.ConvertO(__workflow_bodyeSTIMATEDPERCENTAGEUSE);
                    bodypropCount++;
                }

                if (__workflow_bodyeXPECTEDENDLENDDATE != null)
                {
                    body["EXPECTED_END_LEND_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyeXPECTEDENDLENDDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyeXPECTEDRETURNDATE != null)
                {
                    body["EXPECTED_RETURN_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyeXPECTEDRETURNDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyfALLENTERM != null)
                {
                    body["FALLEN_TERM"] = ExpressionConverter.ConvertO(__workflow_bodyfALLENTERM);
                    bodypropCount++;
                }

                if (__workflow_bodyfIXEDASSETNUMBER != null)
                {
                    body["FIXED_ASSET_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyfIXEDASSETNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyiNITIALSTART != null)
                {
                    body["INITIAL_START"] = ExpressionConverter.ConvertO(__workflow_bodyiNITIALSTART);
                    bodypropCount++;
                }

                if (__workflow_bodyiNSTALLATIONDATE != null)
                {
                    body["INSTALLATION_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyiNSTALLATIONDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyiNTERNALDELIVERYDATE != null)
                {
                    body["INTERNAL_DELIVERY_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyiNTERNALDELIVERYDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyiNVOICENUMBER != null)
                {
                    body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyiNVOICENUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyiSDML != null)
                {
                    body["IS_DML"] = ExpressionConverter.ConvertO(__workflow_bodyiSDML);
                    bodypropCount++;
                }

                if (__workflow_bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(__workflow_bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (__workflow_bodylASTPHYSICALINVENTORY != null)
                {
                    body["LAST_PHYSICAL_INVENTORY"] = ExpressionConverter.ConvertO(__workflow_bodylASTPHYSICALINVENTORY);
                    bodypropCount++;
                }

                if (__workflow_bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodylASTUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodylICENSEVERSION != null)
                {
                    body["LICENSE_VERSION"] = ExpressionConverter.ConvertO(__workflow_bodylICENSEVERSION);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodymAINTENANCECOST != null)
                {
                    body["MAINTENANCE_COST"] = ExpressionConverter.ConvertO(__workflow_bodymAINTENANCECOST);
                    bodypropCount++;
                }

                if (__workflow_bodymAINTENANCECOSTCURID != null)
                {
                    body["MAINTENANCE_COST_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodymAINTENANCECOSTCURID);
                    bodypropCount++;
                }

                if (__workflow_bodymAINUSAGEID != null)
                {
                    body["MAIN_USAGE_ID"] = ExpressionConverter.ConvertO(__workflow_bodymAINUSAGEID);
                    bodypropCount++;
                }

                if (__workflow_bodymAXINSTALLS != null)
                {
                    body["MAX_INSTALLS"] = ExpressionConverter.ConvertO(__workflow_bodymAXINSTALLS);
                    bodypropCount++;
                }

                if (__workflow_bodymONTHLYFIXEDCOST != null)
                {
                    body["MONTHLY_FIXED_COST"] = ExpressionConverter.ConvertO(__workflow_bodymONTHLYFIXEDCOST);
                    bodypropCount++;
                }

                if (__workflow_bodymONTHLYFIXEDCOSTCURID != null)
                {
                    body["MONTHLY_FIXED_COST_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodymONTHLYFIXEDCOSTCURID);
                    bodypropCount++;
                }

                if (__workflow_bodymONTHLYNETRENTAL != null)
                {
                    body["MONTHLY_NET_RENTAL"] = ExpressionConverter.ConvertO(__workflow_bodymONTHLYNETRENTAL);
                    bodypropCount++;
                }

                if (__workflow_bodymONTHLYNETRENTALCURID != null)
                {
                    body["MONTHLY_NET_RENTAL_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodymONTHLYNETRENTALCURID);
                    bodypropCount++;
                }

                if (__workflow_bodymONTHDURATION != null)
                {
                    body["MONTH_DURATION"] = ExpressionConverter.ConvertO(__workflow_bodymONTHDURATION);
                    bodypropCount++;
                }

                if (__workflow_bodynETWORKIDENTIFIER != null)
                {
                    body["NETWORK_IDENTIFIER"] = ExpressionConverter.ConvertO(__workflow_bodynETWORKIDENTIFIER);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTDEPARTMENTID != null)
                {
                    body["NEXT_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodynEXTDEPARTMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTMAINTENANCEDATE != null)
                {
                    body["NEXT_MAINTENANCE_DATE"] = ExpressionConverter.ConvertO(__workflow_bodynEXTMAINTENANCEDATE);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTSTATUSID != null)
                {
                    body["NEXT_STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodynEXTSTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTUSERAPPLICATIONDATE != null)
                {
                    body["NEXT_USER_APPLICATION_DATE"] = ExpressionConverter.ConvertO(__workflow_bodynEXTUSERAPPLICATIONDATE);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTUSERID != null)
                {
                    body["NEXT_USER_ID"] = ExpressionConverter.ConvertO(__workflow_bodynEXTUSERID);
                    bodypropCount++;
                }

                if (__workflow_bodynOTICE != null)
                {
                    body["NOTICE"] = ExpressionConverter.ConvertO(__workflow_bodynOTICE);
                    bodypropCount++;
                }

                if (__workflow_bodyoRDERDETAILSID != null)
                {
                    body["ORDER_DETAILS_ID"] = ExpressionConverter.ConvertO(__workflow_bodyoRDERDETAILSID);
                    bodypropCount++;
                }

                if (__workflow_bodyoRDERNUMBER != null)
                {
                    body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyoRDERNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodypIPELINESTATUSID != null)
                {
                    body["PIPELINE_STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodypIPELINESTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodypOWERCONSUMPTIONWH != null)
                {
                    body["POWER_CONSUMPTION_WH"] = ExpressionConverter.ConvertO(__workflow_bodypOWERCONSUMPTIONWH);
                    bodypropCount++;
                }

                if (__workflow_bodypROCESSORCOUNT != null)
                {
                    body["PROCESSOR_COUNT"] = ExpressionConverter.ConvertO(__workflow_bodypROCESSORCOUNT);
                    bodypropCount++;
                }

                if (__workflow_bodypROCESSORSOCKETCOUNT != null)
                {
                    body["PROCESSOR_SOCKET_COUNT"] = ExpressionConverter.ConvertO(__workflow_bodypROCESSORSOCKETCOUNT);
                    bodypropCount++;
                }

                if (__workflow_bodypURCHASEDATE != null)
                {
                    body["PURCHASE_DATE"] = ExpressionConverter.ConvertO(__workflow_bodypURCHASEDATE);
                    bodypropCount++;
                }

                if (__workflow_bodypURCHASEPRICE != null)
                {
                    body["PURCHASE_PRICE"] = ExpressionConverter.ConvertO(__workflow_bodypURCHASEPRICE);
                    bodypropCount++;
                }

                if (__workflow_bodypURCHASEPRICECURID != null)
                {
                    body["PURCHASE_PRICE_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodypURCHASEPRICECURID);
                    bodypropCount++;
                }

                if (__workflow_bodypURCHASERATEID != null)
                {
                    body["PURCHASE_RATE_ID"] = ExpressionConverter.ConvertO(__workflow_bodypURCHASERATEID);
                    bodypropCount++;
                }

                if (__workflow_bodyrECYCLEDDATE != null)
                {
                    body["RECYCLED_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyrECYCLEDDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyrECYCLINGPROVIDERID != null)
                {
                    body["RECYCLING_PROVIDER_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrECYCLINGPROVIDERID);
                    bodypropCount++;
                }

                if (__workflow_bodyrEFORMNUMBER != null)
                {
                    body["REFORM_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyrEFORMNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyrEMOVEDDATE != null)
                {
                    body["REMOVED_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyrEMOVEDDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyrENEWALDECISIONID != null)
                {
                    body["RENEWAL_DECISION_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrENEWALDECISIONID);
                    bodypropCount++;
                }

                if (__workflow_bodyrENEWALVALUE != null)
                {
                    body["RENEWAL_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodyrENEWALVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodyrENEWALVALUECURID != null)
                {
                    body["RENEWAL_VALUE_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrENEWALVALUECURID);
                    bodypropCount++;
                }

                if (__workflow_bodyrEPAIREDBYID != null)
                {
                    body["REPAIRED_BY_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrEPAIREDBYID);
                    bodypropCount++;
                }

                if (__workflow_bodyrESALESVALUE != null)
                {
                    body["RESALES_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodyrESALESVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodysCHEDULEDEND != null)
                {
                    body["SCHEDULED_END"] = ExpressionConverter.ConvertO(__workflow_bodysCHEDULEDEND);
                    bodypropCount++;
                }

                if (__workflow_bodysDCATALOGID != null)
                {
                    body["SD_CATALOG_ID"] = ExpressionConverter.ConvertO(__workflow_bodysDCATALOGID);
                    bodypropCount++;
                }

                if (__workflow_bodysERIALNUMBER != null)
                {
                    body["SERIAL_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodysERIALNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodysLAID != null)
                {
                    body["SLA_ID"] = ExpressionConverter.ConvertO(__workflow_bodysLAID);
                    bodypropCount++;
                }

                if (__workflow_bodysTATUSID != null)
                {
                    body["STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodysTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(__workflow_bodysUPPLIERID);
                    bodypropCount++;
                }

                if (__workflow_bodytERM != null)
                {
                    body["TERM"] = ExpressionConverter.ConvertO(__workflow_bodytERM);
                    bodypropCount++;
                }

                if (__workflow_bodyuPDATECOVERAGETERM != null)
                {
                    body["UPDATE_COVERAGE_TERM"] = ExpressionConverter.ConvertO(__workflow_bodyuPDATECOVERAGETERM);
                    bodypropCount++;
                }

                if (__workflow_bodywARANTYTYPEID != null)
                {
                    body["WARANTY_TYPE_ID"] = ExpressionConverter.ConvertO(__workflow_bodywARANTYTYPEID);
                    bodypropCount++;
                }

                if (__workflow_bodyassetLabel != null)
                {
                    body["asset_label"] = ExpressionConverter.ConvertO(__workflow_bodyassetLabel);
                    bodypropCount++;
                }

                if (__workflow_bodyassetTag != null)
                {
                    body["asset_tag"] = ExpressionConverter.ConvertO(__workflow_bodyassetTag);
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticRenewal != null)
                {
                    body["automatic_renewal"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRenewal);
                    bodypropCount++;
                }

                if (__workflow_bodyavailabilitySlaId != null)
                {
                    body["availability_sla_id"] = ExpressionConverter.ConvertO(__workflow_bodyavailabilitySlaId);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField1 != null)
                {
                    body["available_field_1"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField1);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField2 != null)
                {
                    body["available_field_2"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField2);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField3 != null)
                {
                    body["available_field_3"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField3);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField4 != null)
                {
                    body["available_field_4"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField4);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField5 != null)
                {
                    body["available_field_5"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField5);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField6 != null)
                {
                    body["available_field_6"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField6);
                    bodypropCount++;
                }

                if (__workflow_bodycommentAsset != null)
                {
                    body["comment_asset"] = ExpressionConverter.ConvertO(__workflow_bodycommentAsset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = parentAssetId == null ? null : WorkflowExpression.Compile(parentAssetId);
            WorkflowExpression.Validate(__workflow_parentAssetId, nameof(parentAssetId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentAssetId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = parentAssetId == null ? null : WorkflowExpression.Compile(parentAssetId);
            WorkflowExpression.Validate(__workflow_parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_bodycontractRow = bodycontractRow == null ? null : WorkflowExpression.Compile(bodycontractRow);
            WorkflowExpression.Validate(__workflow_bodycontractRow, nameof(bodycontractRow), required: false);
            var __workflow_bodymonthlyPayment = bodymonthlyPayment == null ? null : WorkflowExpression.Compile(bodymonthlyPayment);
            WorkflowExpression.Validate(__workflow_bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<CreateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentAssetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontractRow != null)
                {
                    body["Contract_Row"] = ExpressionConverter.ConvertO(__workflow_bodycontractRow);
                    bodypropCount++;
                }

                if (__workflow_bodymonthlyPayment != null)
                {
                    body["Monthly_Payment"] = ExpressionConverter.ConvertO(__workflow_bodymonthlyPayment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = parentAssetId == null ? null : WorkflowExpression.Compile(parentAssetId);
            WorkflowExpression.Validate(__workflow_parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_bodycontractRow = bodycontractRow == null ? null : WorkflowExpression.Compile(bodycontractRow);
            WorkflowExpression.Validate(__workflow_bodycontractRow, nameof(bodycontractRow), required: false);
            var __workflow_bodymonthlyPayment = bodymonthlyPayment == null ? null : WorkflowExpression.Compile(bodymonthlyPayment);
            WorkflowExpression.Validate(__workflow_bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<UpdateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentAssetId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontractRow != null)
                {
                    body["Contract_Row"] = ExpressionConverter.ConvertO(__workflow_bodycontractRow);
                    bodypropCount++;
                }

                if (__workflow_bodymonthlyPayment != null)
                {
                    body["Monthly_Payment"] = ExpressionConverter.ConvertO(__workflow_bodymonthlyPayment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink(Expression<Func<string>> account, Expression<Func<string>> parentAssetId, Expression<Func<string>> childAssetId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parentAssetId = parentAssetId == null ? null : WorkflowExpression.Compile(parentAssetId);
            WorkflowExpression.Validate(__workflow_parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_childAssetId = childAssetId == null ? null : WorkflowExpression.Compile(childAssetId);
            WorkflowExpression.Validate(__workflow_childAssetId, nameof(childAssetId), required: true);
            return new DeferredBodyAction<ViewAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentAssetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_childAssetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewCatalogAssetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_catalogId = catalogId == null ? null : WorkflowExpression.Compile(catalogId);
            WorkflowExpression.Validate(__workflow_catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ViewCatalogRequestsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsPathListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewCatalogRequestsPathListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_catalogId = catalogId == null ? null : WorkflowExpression.Compile(catalogId);
            WorkflowExpression.Validate(__workflow_catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestPathResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_catalogId = catalogId == null ? null : WorkflowExpression.Compile(catalogId);
            WorkflowExpression.Validate(__workflow_catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewConfigurationItemsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewConfigurationItemsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parentCiId = parentCiId == null ? null : WorkflowExpression.Compile(parentCiId);
            WorkflowExpression.Validate(__workflow_parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = childCiId == null ? null : WorkflowExpression.Compile(childCiId);
            WorkflowExpression.Validate(__workflow_childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_childCiId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parentCiId = parentCiId == null ? null : WorkflowExpression.Compile(parentCiId);
            WorkflowExpression.Validate(__workflow_parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = childCiId == null ? null : WorkflowExpression.Compile(childCiId);
            WorkflowExpression.Validate(__workflow_childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_childCiId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyrelationTypeID, Expression<Func<string>> bodyblocking = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parentCiId = parentCiId == null ? null : WorkflowExpression.Compile(parentCiId);
            WorkflowExpression.Validate(__workflow_parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = childCiId == null ? null : WorkflowExpression.Compile(childCiId);
            WorkflowExpression.Validate(__workflow_childCiId, nameof(childCiId), required: true);
            var __workflow_bodyrelationTypeID = bodyrelationTypeID == null ? null : WorkflowExpression.Compile(bodyrelationTypeID);
            WorkflowExpression.Validate(__workflow_bodyrelationTypeID, nameof(bodyrelationTypeID), required: true);
            var __workflow_bodyblocking = bodyblocking == null ? null : WorkflowExpression.Compile(bodyblocking);
            WorkflowExpression.Validate(__workflow_bodyblocking, nameof(bodyblocking), required: false);
            return new DeferredBodyAction<CreateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_childCiId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyblocking != null)
                {
                    body["Blocking"] = ExpressionConverter.ConvertO(__workflow_bodyblocking);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Relation_Type_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrelationTypeID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyblocking = null, Expression<Func<string>> bodyrelationTypeID = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_parentCiId = parentCiId == null ? null : WorkflowExpression.Compile(parentCiId);
            WorkflowExpression.Validate(__workflow_parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = childCiId == null ? null : WorkflowExpression.Compile(childCiId);
            WorkflowExpression.Validate(__workflow_childCiId, nameof(childCiId), required: true);
            var __workflow_bodyblocking = bodyblocking == null ? null : WorkflowExpression.Compile(bodyblocking);
            WorkflowExpression.Validate(__workflow_bodyblocking, nameof(bodyblocking), required: false);
            var __workflow_bodyrelationTypeID = bodyrelationTypeID == null ? null : WorkflowExpression.Compile(bodyrelationTypeID);
            WorkflowExpression.Validate(__workflow_bodyrelationTypeID, nameof(bodyrelationTypeID), required: false);
            return new DeferredBodyAction<UpdateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_childCiId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyblocking != null)
                {
                    body["Blocking"] = ExpressionConverter.ConvertO(__workflow_bodyblocking);
                    bodypropCount++;
                }

                if (__workflow_bodyrelationTypeID != null)
                {
                    body["Relation_Type_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrelationTypeID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEntitiesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewEntitiesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity(Expression<Func<string>> account, Expression<Func<string>> departmentId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_departmentId = departmentId == null ? null : WorkflowExpression.Compile(departmentId);
            WorkflowExpression.Validate(__workflow_departmentId, nameof(departmentId), required: true);
            return new DeferredBodyAction<ViewEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_departmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateDepartmentResponse> UpdateDepartment(Expression<Func<string>> account, Expression<Func<string>> departmentId, Expression<Func<string>> bodypARENTDEPARTMENTID = null, Expression<Func<string>> bodydEPARTMENTEN = null, Expression<Func<string>> bodydEPARTMENTFR = null, Expression<Func<string>> bodydEPARTMENTSP = null, Expression<Func<string>> bodydEPARTMENTGE = null, Expression<Func<string>> bodydEPARTMENTIT = null, Expression<Func<string>> bodydEPARTMENTPO = null, Expression<Func<string>> bodydEPARTMENTLABEL = null, Expression<Func<string>> bodycOMMENTDEPARTMENT = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodydEFAULTCOSTCENTERID = null, Expression<Func<string>> bodysTARTDATE = null, Expression<Func<string>> bodyeNDDATE = null, Expression<Func<string>> bodyuRLMAP = null, Expression<Func<string>> bodydEPARTMENTCODE = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodycURRENCYID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodydEPARTMENTL1 = null, Expression<Func<string>> bodydEPARTMENTL2 = null, Expression<Func<string>> bodydEPARTMENTL3 = null, Expression<Func<string>> bodydEPARTMENTL4 = null, Expression<Func<string>> bodydEPARTMENTL5 = null, Expression<Func<string>> bodydEPARTMENTL6 = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_departmentId = departmentId == null ? null : WorkflowExpression.Compile(departmentId);
            WorkflowExpression.Validate(__workflow_departmentId, nameof(departmentId), required: true);
            var __workflow_bodypARENTDEPARTMENTID = bodypARENTDEPARTMENTID == null ? null : WorkflowExpression.Compile(bodypARENTDEPARTMENTID);
            WorkflowExpression.Validate(__workflow_bodypARENTDEPARTMENTID, nameof(bodypARENTDEPARTMENTID), required: false);
            var __workflow_bodydEPARTMENTEN = bodydEPARTMENTEN == null ? null : WorkflowExpression.Compile(bodydEPARTMENTEN);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTEN, nameof(bodydEPARTMENTEN), required: false);
            var __workflow_bodydEPARTMENTFR = bodydEPARTMENTFR == null ? null : WorkflowExpression.Compile(bodydEPARTMENTFR);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTFR, nameof(bodydEPARTMENTFR), required: false);
            var __workflow_bodydEPARTMENTSP = bodydEPARTMENTSP == null ? null : WorkflowExpression.Compile(bodydEPARTMENTSP);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTSP, nameof(bodydEPARTMENTSP), required: false);
            var __workflow_bodydEPARTMENTGE = bodydEPARTMENTGE == null ? null : WorkflowExpression.Compile(bodydEPARTMENTGE);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTGE, nameof(bodydEPARTMENTGE), required: false);
            var __workflow_bodydEPARTMENTIT = bodydEPARTMENTIT == null ? null : WorkflowExpression.Compile(bodydEPARTMENTIT);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTIT, nameof(bodydEPARTMENTIT), required: false);
            var __workflow_bodydEPARTMENTPO = bodydEPARTMENTPO == null ? null : WorkflowExpression.Compile(bodydEPARTMENTPO);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTPO, nameof(bodydEPARTMENTPO), required: false);
            var __workflow_bodydEPARTMENTLABEL = bodydEPARTMENTLABEL == null ? null : WorkflowExpression.Compile(bodydEPARTMENTLABEL);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTLABEL, nameof(bodydEPARTMENTLABEL), required: false);
            var __workflow_bodycOMMENTDEPARTMENT = bodycOMMENTDEPARTMENT == null ? null : WorkflowExpression.Compile(bodycOMMENTDEPARTMENT);
            WorkflowExpression.Validate(__workflow_bodycOMMENTDEPARTMENT, nameof(bodycOMMENTDEPARTMENT), required: false);
            var __workflow_bodymANAGERID = bodymANAGERID == null ? null : WorkflowExpression.Compile(bodymANAGERID);
            WorkflowExpression.Validate(__workflow_bodymANAGERID, nameof(bodymANAGERID), required: false);
            var __workflow_bodydEFAULTCOSTCENTERID = bodydEFAULTCOSTCENTERID == null ? null : WorkflowExpression.Compile(bodydEFAULTCOSTCENTERID);
            WorkflowExpression.Validate(__workflow_bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            var __workflow_bodysTARTDATE = bodysTARTDATE == null ? null : WorkflowExpression.Compile(bodysTARTDATE);
            WorkflowExpression.Validate(__workflow_bodysTARTDATE, nameof(bodysTARTDATE), required: false);
            var __workflow_bodyeNDDATE = bodyeNDDATE == null ? null : WorkflowExpression.Compile(bodyeNDDATE);
            WorkflowExpression.Validate(__workflow_bodyeNDDATE, nameof(bodyeNDDATE), required: false);
            var __workflow_bodyuRLMAP = bodyuRLMAP == null ? null : WorkflowExpression.Compile(bodyuRLMAP);
            WorkflowExpression.Validate(__workflow_bodyuRLMAP, nameof(bodyuRLMAP), required: false);
            var __workflow_bodydEPARTMENTCODE = bodydEPARTMENTCODE == null ? null : WorkflowExpression.Compile(bodydEPARTMENTCODE);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTCODE, nameof(bodydEPARTMENTCODE), required: false);
            var __workflow_bodylASTUPDATE = bodylASTUPDATE == null ? null : WorkflowExpression.Compile(bodylASTUPDATE);
            WorkflowExpression.Validate(__workflow_bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylASTINTEGRATION = bodylASTINTEGRATION == null ? null : WorkflowExpression.Compile(bodylASTINTEGRATION);
            WorkflowExpression.Validate(__workflow_bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodycURRENCYID = bodycURRENCYID == null ? null : WorkflowExpression.Compile(bodycURRENCYID);
            WorkflowExpression.Validate(__workflow_bodycURRENCYID, nameof(bodycURRENCYID), required: false);
            var __workflow_bodyaVAILABLEFIELD1 = bodyaVAILABLEFIELD1 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD1);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            var __workflow_bodyaVAILABLEFIELD2 = bodyaVAILABLEFIELD2 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD2);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            var __workflow_bodyaVAILABLEFIELD3 = bodyaVAILABLEFIELD3 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD3);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            var __workflow_bodyaVAILABLEFIELD4 = bodyaVAILABLEFIELD4 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD4);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            var __workflow_bodyaVAILABLEFIELD5 = bodyaVAILABLEFIELD5 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD5);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            var __workflow_bodyaVAILABLEFIELD6 = bodyaVAILABLEFIELD6 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD6);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            var __workflow_bodysLAID = bodysLAID == null ? null : WorkflowExpression.Compile(bodysLAID);
            WorkflowExpression.Validate(__workflow_bodysLAID, nameof(bodysLAID), required: false);
            var __workflow_bodydEPARTMENTL1 = bodydEPARTMENTL1 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL1);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL1, nameof(bodydEPARTMENTL1), required: false);
            var __workflow_bodydEPARTMENTL2 = bodydEPARTMENTL2 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL2);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL2, nameof(bodydEPARTMENTL2), required: false);
            var __workflow_bodydEPARTMENTL3 = bodydEPARTMENTL3 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL3);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL3, nameof(bodydEPARTMENTL3), required: false);
            var __workflow_bodydEPARTMENTL4 = bodydEPARTMENTL4 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL4);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL4, nameof(bodydEPARTMENTL4), required: false);
            var __workflow_bodydEPARTMENTL5 = bodydEPARTMENTL5 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL5);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL5, nameof(bodydEPARTMENTL5), required: false);
            var __workflow_bodydEPARTMENTL6 = bodydEPARTMENTL6 == null ? null : WorkflowExpression.Compile(bodydEPARTMENTL6);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTL6, nameof(bodydEPARTMENTL6), required: false);
            return new DeferredBodyAction<UpdateDepartmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_departmentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypARENTDEPARTMENTID != null)
                {
                    body["PARENT_DEPARTMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodypARENTDEPARTMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTEN != null)
                {
                    body["DEPARTMENT_EN"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTEN);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTFR != null)
                {
                    body["DEPARTMENT_FR"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTFR);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTSP != null)
                {
                    body["DEPARTMENT_SP"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTSP);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTGE != null)
                {
                    body["DEPARTMENT_GE"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTGE);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTIT != null)
                {
                    body["DEPARTMENT_IT"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTIT);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTPO != null)
                {
                    body["DEPARTMENT_PO"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTPO);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTLABEL != null)
                {
                    body["DEPARTMENT_LABEL"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTLABEL);
                    bodypropCount++;
                }

                if (__workflow_bodycOMMENTDEPARTMENT != null)
                {
                    body["COMMENT_DEPARTMENT"] = ExpressionConverter.ConvertO(__workflow_bodycOMMENTDEPARTMENT);
                    bodypropCount++;
                }

                if (__workflow_bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = ExpressionConverter.ConvertO(__workflow_bodymANAGERID);
                    bodypropCount++;
                }

                if (__workflow_bodydEFAULTCOSTCENTERID != null)
                {
                    body["DEFAULT_COST_CENTER_ID"] = ExpressionConverter.ConvertO(__workflow_bodydEFAULTCOSTCENTERID);
                    bodypropCount++;
                }

                if (__workflow_bodysTARTDATE != null)
                {
                    body["START_DATE"] = ExpressionConverter.ConvertO(__workflow_bodysTARTDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyeNDDATE != null)
                {
                    body["END_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyeNDDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyuRLMAP != null)
                {
                    body["URL_MAP"] = ExpressionConverter.ConvertO(__workflow_bodyuRLMAP);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTCODE != null)
                {
                    body["DEPARTMENT_CODE"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTCODE);
                    bodypropCount++;
                }

                if (__workflow_bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodylASTUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(__workflow_bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (__workflow_bodycURRENCYID != null)
                {
                    body["CURRENCY_ID"] = ExpressionConverter.ConvertO(__workflow_bodycURRENCYID);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (__workflow_bodysLAID != null)
                {
                    body["SLA_ID"] = ExpressionConverter.ConvertO(__workflow_bodysLAID);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL1 != null)
                {
                    body["DEPARTMENT_L1"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL1);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL2 != null)
                {
                    body["DEPARTMENT_L2"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL2);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL3 != null)
                {
                    body["DEPARTMENT_L3"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL3);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL4 != null)
                {
                    body["DEPARTMENT_L4"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL4);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL5 != null)
                {
                    body["DEPARTMENT_L5"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL5);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTL6 != null)
                {
                    body["DEPARTMENT_L6"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTL6);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateDepartmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEmployeesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewEmployeesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee(Expression<Func<string>> account, Expression<Func<bodyemployeesInputItem[]>> bodyemployees = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_bodyemployees = bodyemployees == null ? null : WorkflowExpression.Compile(bodyemployees);
            WorkflowExpression.Validate(__workflow_bodyemployees, nameof(bodyemployees), required: false);
            return new DeferredBodyAction<CreateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemployees != null)
                {
                    body["employees"] = ExpressionConverter.ConvertO(__workflow_bodyemployees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_employeeId = employeeId == null ? null : WorkflowExpression.Compile(employeeId);
            WorkflowExpression.Validate(__workflow_employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ViewEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_employeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId, Expression<Func<string>> bodyaPPROVEDTOVALIDATE = null, Expression<Func<string>> bodyaVAILABILITYSTATUSID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodybEGINOFCONTRACT = null, Expression<Func<string>> bodycELLULARNUMBER = null, Expression<Func<string>> bodycHATLOGIN = null, Expression<Func<string>> bodycIVILSTATUSID = null, Expression<Func<string>> bodycOMMENTEMPLOYEE = null, Expression<Func<string>> bodycOSTPERHOUR = null, Expression<Func<string>> bodycOSTPERHOURCURID = null, Expression<Func<string>> bodydEFAULTCOSTCENTERID = null, Expression<Func<string>> bodydELEGATIONFROM = null, Expression<Func<string>> bodydELEGATIONID = null, Expression<Func<string>> bodydELEGATIONTO = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodyeNDOFCONTRACT = null, Expression<Func<string>> bodyeMAIL = null, Expression<Func<string>> bodyfAXNUMBER = null, Expression<Func<string>> bodyfUNCTIONID = null, Expression<Func<string>> bodyiCQNUMBER = null, Expression<Func<string>> bodyiDENTIFICATION = null, Expression<Func<string>> bodyiSAUTOMATICSTATUS = null, Expression<Func<string>> bodyiTCORRESPONDENT = null, Expression<Func<string>> bodylANGUAGEID = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTNAME = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodylOGIN = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodymESSENGERSIGNNAME = null, Expression<Func<string>> bodynOTIFICATIONTYPEID = null, Expression<Func<string>> bodypASSWDLASTUPDATEUT = null, Expression<Func<string>> bodypHONENUMBER = null, Expression<Func<string>> bodypICTUREPATH = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodyvALIDATORID = null, Expression<Func<string>> bodyvIPLEVELID = null, Expression<Func<string>> bodywAVEADDRESS = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_employeeId = employeeId == null ? null : WorkflowExpression.Compile(employeeId);
            WorkflowExpression.Validate(__workflow_employeeId, nameof(employeeId), required: true);
            var __workflow_bodyaPPROVEDTOVALIDATE = bodyaPPROVEDTOVALIDATE == null ? null : WorkflowExpression.Compile(bodyaPPROVEDTOVALIDATE);
            WorkflowExpression.Validate(__workflow_bodyaPPROVEDTOVALIDATE, nameof(bodyaPPROVEDTOVALIDATE), required: false);
            var __workflow_bodyaVAILABILITYSTATUSID = bodyaVAILABILITYSTATUSID == null ? null : WorkflowExpression.Compile(bodyaVAILABILITYSTATUSID);
            WorkflowExpression.Validate(__workflow_bodyaVAILABILITYSTATUSID, nameof(bodyaVAILABILITYSTATUSID), required: false);
            var __workflow_bodyaVAILABLEFIELD1 = bodyaVAILABLEFIELD1 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD1);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            var __workflow_bodyaVAILABLEFIELD2 = bodyaVAILABLEFIELD2 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD2);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            var __workflow_bodyaVAILABLEFIELD3 = bodyaVAILABLEFIELD3 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD3);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            var __workflow_bodyaVAILABLEFIELD4 = bodyaVAILABLEFIELD4 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD4);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            var __workflow_bodyaVAILABLEFIELD5 = bodyaVAILABLEFIELD5 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD5);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            var __workflow_bodyaVAILABLEFIELD6 = bodyaVAILABLEFIELD6 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD6);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            var __workflow_bodybEGINOFCONTRACT = bodybEGINOFCONTRACT == null ? null : WorkflowExpression.Compile(bodybEGINOFCONTRACT);
            WorkflowExpression.Validate(__workflow_bodybEGINOFCONTRACT, nameof(bodybEGINOFCONTRACT), required: false);
            var __workflow_bodycELLULARNUMBER = bodycELLULARNUMBER == null ? null : WorkflowExpression.Compile(bodycELLULARNUMBER);
            WorkflowExpression.Validate(__workflow_bodycELLULARNUMBER, nameof(bodycELLULARNUMBER), required: false);
            var __workflow_bodycHATLOGIN = bodycHATLOGIN == null ? null : WorkflowExpression.Compile(bodycHATLOGIN);
            WorkflowExpression.Validate(__workflow_bodycHATLOGIN, nameof(bodycHATLOGIN), required: false);
            var __workflow_bodycIVILSTATUSID = bodycIVILSTATUSID == null ? null : WorkflowExpression.Compile(bodycIVILSTATUSID);
            WorkflowExpression.Validate(__workflow_bodycIVILSTATUSID, nameof(bodycIVILSTATUSID), required: false);
            var __workflow_bodycOMMENTEMPLOYEE = bodycOMMENTEMPLOYEE == null ? null : WorkflowExpression.Compile(bodycOMMENTEMPLOYEE);
            WorkflowExpression.Validate(__workflow_bodycOMMENTEMPLOYEE, nameof(bodycOMMENTEMPLOYEE), required: false);
            var __workflow_bodycOSTPERHOUR = bodycOSTPERHOUR == null ? null : WorkflowExpression.Compile(bodycOSTPERHOUR);
            WorkflowExpression.Validate(__workflow_bodycOSTPERHOUR, nameof(bodycOSTPERHOUR), required: false);
            var __workflow_bodycOSTPERHOURCURID = bodycOSTPERHOURCURID == null ? null : WorkflowExpression.Compile(bodycOSTPERHOURCURID);
            WorkflowExpression.Validate(__workflow_bodycOSTPERHOURCURID, nameof(bodycOSTPERHOURCURID), required: false);
            var __workflow_bodydEFAULTCOSTCENTERID = bodydEFAULTCOSTCENTERID == null ? null : WorkflowExpression.Compile(bodydEFAULTCOSTCENTERID);
            WorkflowExpression.Validate(__workflow_bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            var __workflow_bodydELEGATIONFROM = bodydELEGATIONFROM == null ? null : WorkflowExpression.Compile(bodydELEGATIONFROM);
            WorkflowExpression.Validate(__workflow_bodydELEGATIONFROM, nameof(bodydELEGATIONFROM), required: false);
            var __workflow_bodydELEGATIONID = bodydELEGATIONID == null ? null : WorkflowExpression.Compile(bodydELEGATIONID);
            WorkflowExpression.Validate(__workflow_bodydELEGATIONID, nameof(bodydELEGATIONID), required: false);
            var __workflow_bodydELEGATIONTO = bodydELEGATIONTO == null ? null : WorkflowExpression.Compile(bodydELEGATIONTO);
            WorkflowExpression.Validate(__workflow_bodydELEGATIONTO, nameof(bodydELEGATIONTO), required: false);
            var __workflow_bodydEPARTMENTID = bodydEPARTMENTID == null ? null : WorkflowExpression.Compile(bodydEPARTMENTID);
            WorkflowExpression.Validate(__workflow_bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            var __workflow_bodyeNDOFCONTRACT = bodyeNDOFCONTRACT == null ? null : WorkflowExpression.Compile(bodyeNDOFCONTRACT);
            WorkflowExpression.Validate(__workflow_bodyeNDOFCONTRACT, nameof(bodyeNDOFCONTRACT), required: false);
            var __workflow_bodyeMAIL = bodyeMAIL == null ? null : WorkflowExpression.Compile(bodyeMAIL);
            WorkflowExpression.Validate(__workflow_bodyeMAIL, nameof(bodyeMAIL), required: false);
            var __workflow_bodyfAXNUMBER = bodyfAXNUMBER == null ? null : WorkflowExpression.Compile(bodyfAXNUMBER);
            WorkflowExpression.Validate(__workflow_bodyfAXNUMBER, nameof(bodyfAXNUMBER), required: false);
            var __workflow_bodyfUNCTIONID = bodyfUNCTIONID == null ? null : WorkflowExpression.Compile(bodyfUNCTIONID);
            WorkflowExpression.Validate(__workflow_bodyfUNCTIONID, nameof(bodyfUNCTIONID), required: false);
            var __workflow_bodyiCQNUMBER = bodyiCQNUMBER == null ? null : WorkflowExpression.Compile(bodyiCQNUMBER);
            WorkflowExpression.Validate(__workflow_bodyiCQNUMBER, nameof(bodyiCQNUMBER), required: false);
            var __workflow_bodyiDENTIFICATION = bodyiDENTIFICATION == null ? null : WorkflowExpression.Compile(bodyiDENTIFICATION);
            WorkflowExpression.Validate(__workflow_bodyiDENTIFICATION, nameof(bodyiDENTIFICATION), required: false);
            var __workflow_bodyiSAUTOMATICSTATUS = bodyiSAUTOMATICSTATUS == null ? null : WorkflowExpression.Compile(bodyiSAUTOMATICSTATUS);
            WorkflowExpression.Validate(__workflow_bodyiSAUTOMATICSTATUS, nameof(bodyiSAUTOMATICSTATUS), required: false);
            var __workflow_bodyiTCORRESPONDENT = bodyiTCORRESPONDENT == null ? null : WorkflowExpression.Compile(bodyiTCORRESPONDENT);
            WorkflowExpression.Validate(__workflow_bodyiTCORRESPONDENT, nameof(bodyiTCORRESPONDENT), required: false);
            var __workflow_bodylANGUAGEID = bodylANGUAGEID == null ? null : WorkflowExpression.Compile(bodylANGUAGEID);
            WorkflowExpression.Validate(__workflow_bodylANGUAGEID, nameof(bodylANGUAGEID), required: false);
            var __workflow_bodylASTINTEGRATION = bodylASTINTEGRATION == null ? null : WorkflowExpression.Compile(bodylASTINTEGRATION);
            WorkflowExpression.Validate(__workflow_bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodylASTNAME = bodylASTNAME == null ? null : WorkflowExpression.Compile(bodylASTNAME);
            WorkflowExpression.Validate(__workflow_bodylASTNAME, nameof(bodylASTNAME), required: false);
            var __workflow_bodylASTUPDATE = bodylASTUPDATE == null ? null : WorkflowExpression.Compile(bodylASTUPDATE);
            WorkflowExpression.Validate(__workflow_bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylOCATIONID = bodylOCATIONID == null ? null : WorkflowExpression.Compile(bodylOCATIONID);
            WorkflowExpression.Validate(__workflow_bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            var __workflow_bodylOGIN = bodylOGIN == null ? null : WorkflowExpression.Compile(bodylOGIN);
            WorkflowExpression.Validate(__workflow_bodylOGIN, nameof(bodylOGIN), required: false);
            var __workflow_bodymANAGERID = bodymANAGERID == null ? null : WorkflowExpression.Compile(bodymANAGERID);
            WorkflowExpression.Validate(__workflow_bodymANAGERID, nameof(bodymANAGERID), required: false);
            var __workflow_bodymESSENGERSIGNNAME = bodymESSENGERSIGNNAME == null ? null : WorkflowExpression.Compile(bodymESSENGERSIGNNAME);
            WorkflowExpression.Validate(__workflow_bodymESSENGERSIGNNAME, nameof(bodymESSENGERSIGNNAME), required: false);
            var __workflow_bodynOTIFICATIONTYPEID = bodynOTIFICATIONTYPEID == null ? null : WorkflowExpression.Compile(bodynOTIFICATIONTYPEID);
            WorkflowExpression.Validate(__workflow_bodynOTIFICATIONTYPEID, nameof(bodynOTIFICATIONTYPEID), required: false);
            var __workflow_bodypASSWDLASTUPDATEUT = bodypASSWDLASTUPDATEUT == null ? null : WorkflowExpression.Compile(bodypASSWDLASTUPDATEUT);
            WorkflowExpression.Validate(__workflow_bodypASSWDLASTUPDATEUT, nameof(bodypASSWDLASTUPDATEUT), required: false);
            var __workflow_bodypHONENUMBER = bodypHONENUMBER == null ? null : WorkflowExpression.Compile(bodypHONENUMBER);
            WorkflowExpression.Validate(__workflow_bodypHONENUMBER, nameof(bodypHONENUMBER), required: false);
            var __workflow_bodypICTUREPATH = bodypICTUREPATH == null ? null : WorkflowExpression.Compile(bodypICTUREPATH);
            WorkflowExpression.Validate(__workflow_bodypICTUREPATH, nameof(bodypICTUREPATH), required: false);
            var __workflow_bodysUPPLIERID = bodysUPPLIERID == null ? null : WorkflowExpression.Compile(bodysUPPLIERID);
            WorkflowExpression.Validate(__workflow_bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            var __workflow_bodyvALIDATORID = bodyvALIDATORID == null ? null : WorkflowExpression.Compile(bodyvALIDATORID);
            WorkflowExpression.Validate(__workflow_bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            var __workflow_bodyvIPLEVELID = bodyvIPLEVELID == null ? null : WorkflowExpression.Compile(bodyvIPLEVELID);
            WorkflowExpression.Validate(__workflow_bodyvIPLEVELID, nameof(bodyvIPLEVELID), required: false);
            var __workflow_bodywAVEADDRESS = bodywAVEADDRESS == null ? null : WorkflowExpression.Compile(bodywAVEADDRESS);
            WorkflowExpression.Validate(__workflow_bodywAVEADDRESS, nameof(bodywAVEADDRESS), required: false);
            return new DeferredBodyAction<UpdateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_employeeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaPPROVEDTOVALIDATE != null)
                {
                    body["APPROVED_TO_VALIDATE"] = ExpressionConverter.ConvertO(__workflow_bodyaPPROVEDTOVALIDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABILITYSTATUSID != null)
                {
                    body["AVAILABILITY_STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABILITYSTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (__workflow_bodybEGINOFCONTRACT != null)
                {
                    body["BEGIN_OF_CONTRACT"] = ExpressionConverter.ConvertO(__workflow_bodybEGINOFCONTRACT);
                    bodypropCount++;
                }

                if (__workflow_bodycELLULARNUMBER != null)
                {
                    body["CELLULAR_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodycELLULARNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodycHATLOGIN != null)
                {
                    body["CHAT_LOGIN"] = ExpressionConverter.ConvertO(__workflow_bodycHATLOGIN);
                    bodypropCount++;
                }

                if (__workflow_bodycIVILSTATUSID != null)
                {
                    body["CIVIL_STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodycIVILSTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodycOMMENTEMPLOYEE != null)
                {
                    body["COMMENT_EMPLOYEE"] = ExpressionConverter.ConvertO(__workflow_bodycOMMENTEMPLOYEE);
                    bodypropCount++;
                }

                if (__workflow_bodycOSTPERHOUR != null)
                {
                    body["COST_PER_HOUR"] = ExpressionConverter.ConvertO(__workflow_bodycOSTPERHOUR);
                    bodypropCount++;
                }

                if (__workflow_bodycOSTPERHOURCURID != null)
                {
                    body["COST_PER_HOUR_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodycOSTPERHOURCURID);
                    bodypropCount++;
                }

                if (__workflow_bodydEFAULTCOSTCENTERID != null)
                {
                    body["DEFAULT_COST_CENTER_ID"] = ExpressionConverter.ConvertO(__workflow_bodydEFAULTCOSTCENTERID);
                    bodypropCount++;
                }

                if (__workflow_bodydELEGATIONFROM != null)
                {
                    body["DELEGATION_FROM"] = ExpressionConverter.ConvertO(__workflow_bodydELEGATIONFROM);
                    bodypropCount++;
                }

                if (__workflow_bodydELEGATIONID != null)
                {
                    body["DELEGATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodydELEGATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodydELEGATIONTO != null)
                {
                    body["DELEGATION_TO"] = ExpressionConverter.ConvertO(__workflow_bodydELEGATIONTO);
                    bodypropCount++;
                }

                if (__workflow_bodydEPARTMENTID != null)
                {
                    body["DEPARTMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodydEPARTMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodyeNDOFCONTRACT != null)
                {
                    body["END_OF_CONTRACT"] = ExpressionConverter.ConvertO(__workflow_bodyeNDOFCONTRACT);
                    bodypropCount++;
                }

                if (__workflow_bodyeMAIL != null)
                {
                    body["E_MAIL"] = ExpressionConverter.ConvertO(__workflow_bodyeMAIL);
                    bodypropCount++;
                }

                if (__workflow_bodyfAXNUMBER != null)
                {
                    body["FAX_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyfAXNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyfUNCTIONID != null)
                {
                    body["FUNCTION_ID"] = ExpressionConverter.ConvertO(__workflow_bodyfUNCTIONID);
                    bodypropCount++;
                }

                if (__workflow_bodyiCQNUMBER != null)
                {
                    body["ICQ_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyiCQNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyiDENTIFICATION != null)
                {
                    body["IDENTIFICATION"] = ExpressionConverter.ConvertO(__workflow_bodyiDENTIFICATION);
                    bodypropCount++;
                }

                if (__workflow_bodyiSAUTOMATICSTATUS != null)
                {
                    body["IS_AUTOMATIC_STATUS"] = ExpressionConverter.ConvertO(__workflow_bodyiSAUTOMATICSTATUS);
                    bodypropCount++;
                }

                if (__workflow_bodyiTCORRESPONDENT != null)
                {
                    body["IT_CORRESPONDENT"] = ExpressionConverter.ConvertO(__workflow_bodyiTCORRESPONDENT);
                    bodypropCount++;
                }

                if (__workflow_bodylANGUAGEID != null)
                {
                    body["LANGUAGE_ID"] = ExpressionConverter.ConvertO(__workflow_bodylANGUAGEID);
                    bodypropCount++;
                }

                if (__workflow_bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(__workflow_bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (__workflow_bodylASTNAME != null)
                {
                    body["LAST_NAME"] = ExpressionConverter.ConvertO(__workflow_bodylASTNAME);
                    bodypropCount++;
                }

                if (__workflow_bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodylASTUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodylOGIN != null)
                {
                    body["LOGIN"] = ExpressionConverter.ConvertO(__workflow_bodylOGIN);
                    bodypropCount++;
                }

                if (__workflow_bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = ExpressionConverter.ConvertO(__workflow_bodymANAGERID);
                    bodypropCount++;
                }

                if (__workflow_bodymESSENGERSIGNNAME != null)
                {
                    body["MESSENGER_SIGN_NAME"] = ExpressionConverter.ConvertO(__workflow_bodymESSENGERSIGNNAME);
                    bodypropCount++;
                }

                if (__workflow_bodynOTIFICATIONTYPEID != null)
                {
                    body["NOTIFICATION_TYPE_ID"] = ExpressionConverter.ConvertO(__workflow_bodynOTIFICATIONTYPEID);
                    bodypropCount++;
                }

                if (__workflow_bodypASSWDLASTUPDATEUT != null)
                {
                    body["PASSWD_LAST_UPDATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodypASSWDLASTUPDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodypHONENUMBER != null)
                {
                    body["PHONE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodypHONENUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodypICTUREPATH != null)
                {
                    body["PICTURE_PATH"] = ExpressionConverter.ConvertO(__workflow_bodypICTUREPATH);
                    bodypropCount++;
                }

                if (__workflow_bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(__workflow_bodysUPPLIERID);
                    bodypropCount++;
                }

                if (__workflow_bodyvALIDATORID != null)
                {
                    body["VALIDATOR_ID"] = ExpressionConverter.ConvertO(__workflow_bodyvALIDATORID);
                    bodypropCount++;
                }

                if (__workflow_bodyvIPLEVELID != null)
                {
                    body["VIP_LEVEL_ID"] = ExpressionConverter.ConvertO(__workflow_bodyvIPLEVELID);
                    bodypropCount++;
                }

                if (__workflow_bodywAVEADDRESS != null)
                {
                    body["WAVE_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodywAVEADDRESS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewKnownErrorsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewKnownErrorsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors(Expression<Func<string>> account, Expression<Func<string>> kpId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_kpId = kpId == null ? null : WorkflowExpression.Compile(kpId);
            WorkflowExpression.Validate(__workflow_kpId, nameof(kpId), required: true);
            return new DeferredBodyAction<ViewKnownErrorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_kpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewLocationsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewLocationsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation(Expression<Func<string>> account, Expression<Func<string>> locationId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_locationId = locationId == null ? null : WorkflowExpression.Compile(locationId);
            WorkflowExpression.Validate(__workflow_locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<ViewLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateLocationResponse> UpdateLocation(Expression<Func<string>> account, Expression<Func<string>> locationId, Expression<Func<string>> bodypARENTLOCATIONID = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodylOCATIONEN = null, Expression<Func<string>> bodylOCATIONFR = null, Expression<Func<string>> bodylOCATIONGE = null, Expression<Func<string>> bodylOCATIONSP = null, Expression<Func<string>> bodylOCATIONIT = null, Expression<Func<string>> bodylOCATIONPO = null, Expression<Func<string>> bodysTREETADDRESS1 = null, Expression<Func<string>> bodysTREETADDRESS2 = null, Expression<Func<string>> bodycITY = null, Expression<Func<string>> bodypHONE = null, Expression<Func<string>> bodyzIPCODE = null, Expression<Func<string>> bodyfAX = null, Expression<Func<string>> bodycOMMENTLOCATION = null, Expression<Func<string>> bodyrEGIONZONEID = null, Expression<Func<string>> bodycOUNTRYID = null, Expression<Func<string>> bodysTATEID = null, Expression<Func<string>> bodysTARTDATE = null, Expression<Func<string>> bodyeNDDATE = null, Expression<Func<string>> bodyuRLMAP = null, Expression<Func<string>> bodydISCOVERYNAME = null, Expression<Func<string>> bodylOCATIONCODE = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodyiSDELIVERYADDRESS = null, Expression<Func<string>> bodytIMEZONEID = null, Expression<Func<string>> bodysTATUSID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodygMAPLAT = null, Expression<Func<string>> bodygMAPLNG = null, Expression<Func<string>> bodylOCATIONL1 = null, Expression<Func<string>> bodylOCATIONL2 = null, Expression<Func<string>> bodylOCATIONL3 = null, Expression<Func<string>> bodylOCATIONL4 = null, Expression<Func<string>> bodylOCATIONL5 = null, Expression<Func<string>> bodylOCATIONL6 = null, Expression<Func<string>> bodyeISMEETINGROOM = null, Expression<Func<string>> bodyeCAPACITY = null, Expression<Func<string>> bodyeWIFILOGIN = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_locationId = locationId == null ? null : WorkflowExpression.Compile(locationId);
            WorkflowExpression.Validate(__workflow_locationId, nameof(locationId), required: true);
            var __workflow_bodypARENTLOCATIONID = bodypARENTLOCATIONID == null ? null : WorkflowExpression.Compile(bodypARENTLOCATIONID);
            WorkflowExpression.Validate(__workflow_bodypARENTLOCATIONID, nameof(bodypARENTLOCATIONID), required: false);
            var __workflow_bodymANAGERID = bodymANAGERID == null ? null : WorkflowExpression.Compile(bodymANAGERID);
            WorkflowExpression.Validate(__workflow_bodymANAGERID, nameof(bodymANAGERID), required: false);
            var __workflow_bodylOCATIONEN = bodylOCATIONEN == null ? null : WorkflowExpression.Compile(bodylOCATIONEN);
            WorkflowExpression.Validate(__workflow_bodylOCATIONEN, nameof(bodylOCATIONEN), required: false);
            var __workflow_bodylOCATIONFR = bodylOCATIONFR == null ? null : WorkflowExpression.Compile(bodylOCATIONFR);
            WorkflowExpression.Validate(__workflow_bodylOCATIONFR, nameof(bodylOCATIONFR), required: false);
            var __workflow_bodylOCATIONGE = bodylOCATIONGE == null ? null : WorkflowExpression.Compile(bodylOCATIONGE);
            WorkflowExpression.Validate(__workflow_bodylOCATIONGE, nameof(bodylOCATIONGE), required: false);
            var __workflow_bodylOCATIONSP = bodylOCATIONSP == null ? null : WorkflowExpression.Compile(bodylOCATIONSP);
            WorkflowExpression.Validate(__workflow_bodylOCATIONSP, nameof(bodylOCATIONSP), required: false);
            var __workflow_bodylOCATIONIT = bodylOCATIONIT == null ? null : WorkflowExpression.Compile(bodylOCATIONIT);
            WorkflowExpression.Validate(__workflow_bodylOCATIONIT, nameof(bodylOCATIONIT), required: false);
            var __workflow_bodylOCATIONPO = bodylOCATIONPO == null ? null : WorkflowExpression.Compile(bodylOCATIONPO);
            WorkflowExpression.Validate(__workflow_bodylOCATIONPO, nameof(bodylOCATIONPO), required: false);
            var __workflow_bodysTREETADDRESS1 = bodysTREETADDRESS1 == null ? null : WorkflowExpression.Compile(bodysTREETADDRESS1);
            WorkflowExpression.Validate(__workflow_bodysTREETADDRESS1, nameof(bodysTREETADDRESS1), required: false);
            var __workflow_bodysTREETADDRESS2 = bodysTREETADDRESS2 == null ? null : WorkflowExpression.Compile(bodysTREETADDRESS2);
            WorkflowExpression.Validate(__workflow_bodysTREETADDRESS2, nameof(bodysTREETADDRESS2), required: false);
            var __workflow_bodycITY = bodycITY == null ? null : WorkflowExpression.Compile(bodycITY);
            WorkflowExpression.Validate(__workflow_bodycITY, nameof(bodycITY), required: false);
            var __workflow_bodypHONE = bodypHONE == null ? null : WorkflowExpression.Compile(bodypHONE);
            WorkflowExpression.Validate(__workflow_bodypHONE, nameof(bodypHONE), required: false);
            var __workflow_bodyzIPCODE = bodyzIPCODE == null ? null : WorkflowExpression.Compile(bodyzIPCODE);
            WorkflowExpression.Validate(__workflow_bodyzIPCODE, nameof(bodyzIPCODE), required: false);
            var __workflow_bodyfAX = bodyfAX == null ? null : WorkflowExpression.Compile(bodyfAX);
            WorkflowExpression.Validate(__workflow_bodyfAX, nameof(bodyfAX), required: false);
            var __workflow_bodycOMMENTLOCATION = bodycOMMENTLOCATION == null ? null : WorkflowExpression.Compile(bodycOMMENTLOCATION);
            WorkflowExpression.Validate(__workflow_bodycOMMENTLOCATION, nameof(bodycOMMENTLOCATION), required: false);
            var __workflow_bodyrEGIONZONEID = bodyrEGIONZONEID == null ? null : WorkflowExpression.Compile(bodyrEGIONZONEID);
            WorkflowExpression.Validate(__workflow_bodyrEGIONZONEID, nameof(bodyrEGIONZONEID), required: false);
            var __workflow_bodycOUNTRYID = bodycOUNTRYID == null ? null : WorkflowExpression.Compile(bodycOUNTRYID);
            WorkflowExpression.Validate(__workflow_bodycOUNTRYID, nameof(bodycOUNTRYID), required: false);
            var __workflow_bodysTATEID = bodysTATEID == null ? null : WorkflowExpression.Compile(bodysTATEID);
            WorkflowExpression.Validate(__workflow_bodysTATEID, nameof(bodysTATEID), required: false);
            var __workflow_bodysTARTDATE = bodysTARTDATE == null ? null : WorkflowExpression.Compile(bodysTARTDATE);
            WorkflowExpression.Validate(__workflow_bodysTARTDATE, nameof(bodysTARTDATE), required: false);
            var __workflow_bodyeNDDATE = bodyeNDDATE == null ? null : WorkflowExpression.Compile(bodyeNDDATE);
            WorkflowExpression.Validate(__workflow_bodyeNDDATE, nameof(bodyeNDDATE), required: false);
            var __workflow_bodyuRLMAP = bodyuRLMAP == null ? null : WorkflowExpression.Compile(bodyuRLMAP);
            WorkflowExpression.Validate(__workflow_bodyuRLMAP, nameof(bodyuRLMAP), required: false);
            var __workflow_bodydISCOVERYNAME = bodydISCOVERYNAME == null ? null : WorkflowExpression.Compile(bodydISCOVERYNAME);
            WorkflowExpression.Validate(__workflow_bodydISCOVERYNAME, nameof(bodydISCOVERYNAME), required: false);
            var __workflow_bodylOCATIONCODE = bodylOCATIONCODE == null ? null : WorkflowExpression.Compile(bodylOCATIONCODE);
            WorkflowExpression.Validate(__workflow_bodylOCATIONCODE, nameof(bodylOCATIONCODE), required: false);
            var __workflow_bodylASTUPDATE = bodylASTUPDATE == null ? null : WorkflowExpression.Compile(bodylASTUPDATE);
            WorkflowExpression.Validate(__workflow_bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylASTINTEGRATION = bodylASTINTEGRATION == null ? null : WorkflowExpression.Compile(bodylASTINTEGRATION);
            WorkflowExpression.Validate(__workflow_bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodyiSDELIVERYADDRESS = bodyiSDELIVERYADDRESS == null ? null : WorkflowExpression.Compile(bodyiSDELIVERYADDRESS);
            WorkflowExpression.Validate(__workflow_bodyiSDELIVERYADDRESS, nameof(bodyiSDELIVERYADDRESS), required: false);
            var __workflow_bodytIMEZONEID = bodytIMEZONEID == null ? null : WorkflowExpression.Compile(bodytIMEZONEID);
            WorkflowExpression.Validate(__workflow_bodytIMEZONEID, nameof(bodytIMEZONEID), required: false);
            var __workflow_bodysTATUSID = bodysTATUSID == null ? null : WorkflowExpression.Compile(bodysTATUSID);
            WorkflowExpression.Validate(__workflow_bodysTATUSID, nameof(bodysTATUSID), required: false);
            var __workflow_bodyaVAILABLEFIELD1 = bodyaVAILABLEFIELD1 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD1);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            var __workflow_bodyaVAILABLEFIELD2 = bodyaVAILABLEFIELD2 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD2);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            var __workflow_bodyaVAILABLEFIELD3 = bodyaVAILABLEFIELD3 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD3);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            var __workflow_bodyaVAILABLEFIELD4 = bodyaVAILABLEFIELD4 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD4);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            var __workflow_bodyaVAILABLEFIELD5 = bodyaVAILABLEFIELD5 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD5);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            var __workflow_bodyaVAILABLEFIELD6 = bodyaVAILABLEFIELD6 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD6);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            var __workflow_bodysLAID = bodysLAID == null ? null : WorkflowExpression.Compile(bodysLAID);
            WorkflowExpression.Validate(__workflow_bodysLAID, nameof(bodysLAID), required: false);
            var __workflow_bodygMAPLAT = bodygMAPLAT == null ? null : WorkflowExpression.Compile(bodygMAPLAT);
            WorkflowExpression.Validate(__workflow_bodygMAPLAT, nameof(bodygMAPLAT), required: false);
            var __workflow_bodygMAPLNG = bodygMAPLNG == null ? null : WorkflowExpression.Compile(bodygMAPLNG);
            WorkflowExpression.Validate(__workflow_bodygMAPLNG, nameof(bodygMAPLNG), required: false);
            var __workflow_bodylOCATIONL1 = bodylOCATIONL1 == null ? null : WorkflowExpression.Compile(bodylOCATIONL1);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL1, nameof(bodylOCATIONL1), required: false);
            var __workflow_bodylOCATIONL2 = bodylOCATIONL2 == null ? null : WorkflowExpression.Compile(bodylOCATIONL2);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL2, nameof(bodylOCATIONL2), required: false);
            var __workflow_bodylOCATIONL3 = bodylOCATIONL3 == null ? null : WorkflowExpression.Compile(bodylOCATIONL3);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL3, nameof(bodylOCATIONL3), required: false);
            var __workflow_bodylOCATIONL4 = bodylOCATIONL4 == null ? null : WorkflowExpression.Compile(bodylOCATIONL4);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL4, nameof(bodylOCATIONL4), required: false);
            var __workflow_bodylOCATIONL5 = bodylOCATIONL5 == null ? null : WorkflowExpression.Compile(bodylOCATIONL5);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL5, nameof(bodylOCATIONL5), required: false);
            var __workflow_bodylOCATIONL6 = bodylOCATIONL6 == null ? null : WorkflowExpression.Compile(bodylOCATIONL6);
            WorkflowExpression.Validate(__workflow_bodylOCATIONL6, nameof(bodylOCATIONL6), required: false);
            var __workflow_bodyeISMEETINGROOM = bodyeISMEETINGROOM == null ? null : WorkflowExpression.Compile(bodyeISMEETINGROOM);
            WorkflowExpression.Validate(__workflow_bodyeISMEETINGROOM, nameof(bodyeISMEETINGROOM), required: false);
            var __workflow_bodyeCAPACITY = bodyeCAPACITY == null ? null : WorkflowExpression.Compile(bodyeCAPACITY);
            WorkflowExpression.Validate(__workflow_bodyeCAPACITY, nameof(bodyeCAPACITY), required: false);
            var __workflow_bodyeWIFILOGIN = bodyeWIFILOGIN == null ? null : WorkflowExpression.Compile(bodyeWIFILOGIN);
            WorkflowExpression.Validate(__workflow_bodyeWIFILOGIN, nameof(bodyeWIFILOGIN), required: false);
            return new DeferredBodyAction<UpdateLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_locationId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypARENTLOCATIONID != null)
                {
                    body["PARENT_LOCATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodypARENTLOCATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = ExpressionConverter.ConvertO(__workflow_bodymANAGERID);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONEN != null)
                {
                    body["LOCATION_EN"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONEN);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONFR != null)
                {
                    body["LOCATION_FR"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONFR);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONGE != null)
                {
                    body["LOCATION_GE"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONGE);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONSP != null)
                {
                    body["LOCATION_SP"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONSP);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONIT != null)
                {
                    body["LOCATION_IT"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONIT);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONPO != null)
                {
                    body["LOCATION_PO"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONPO);
                    bodypropCount++;
                }

                if (__workflow_bodysTREETADDRESS1 != null)
                {
                    body["STREET_ADDRESS_1"] = ExpressionConverter.ConvertO(__workflow_bodysTREETADDRESS1);
                    bodypropCount++;
                }

                if (__workflow_bodysTREETADDRESS2 != null)
                {
                    body["STREET_ADDRESS_2"] = ExpressionConverter.ConvertO(__workflow_bodysTREETADDRESS2);
                    bodypropCount++;
                }

                if (__workflow_bodycITY != null)
                {
                    body["CITY"] = ExpressionConverter.ConvertO(__workflow_bodycITY);
                    bodypropCount++;
                }

                if (__workflow_bodypHONE != null)
                {
                    body["PHONE"] = ExpressionConverter.ConvertO(__workflow_bodypHONE);
                    bodypropCount++;
                }

                if (__workflow_bodyzIPCODE != null)
                {
                    body["ZIP_CODE"] = ExpressionConverter.ConvertO(__workflow_bodyzIPCODE);
                    bodypropCount++;
                }

                if (__workflow_bodyfAX != null)
                {
                    body["FAX"] = ExpressionConverter.ConvertO(__workflow_bodyfAX);
                    bodypropCount++;
                }

                if (__workflow_bodycOMMENTLOCATION != null)
                {
                    body["COMMENT_LOCATION"] = ExpressionConverter.ConvertO(__workflow_bodycOMMENTLOCATION);
                    bodypropCount++;
                }

                if (__workflow_bodyrEGIONZONEID != null)
                {
                    body["REGION_ZONE_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrEGIONZONEID);
                    bodypropCount++;
                }

                if (__workflow_bodycOUNTRYID != null)
                {
                    body["COUNTRY_ID"] = ExpressionConverter.ConvertO(__workflow_bodycOUNTRYID);
                    bodypropCount++;
                }

                if (__workflow_bodysTATEID != null)
                {
                    body["STATE_ID"] = ExpressionConverter.ConvertO(__workflow_bodysTATEID);
                    bodypropCount++;
                }

                if (__workflow_bodysTARTDATE != null)
                {
                    body["START_DATE"] = ExpressionConverter.ConvertO(__workflow_bodysTARTDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyeNDDATE != null)
                {
                    body["END_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyeNDDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyuRLMAP != null)
                {
                    body["URL_MAP"] = ExpressionConverter.ConvertO(__workflow_bodyuRLMAP);
                    bodypropCount++;
                }

                if (__workflow_bodydISCOVERYNAME != null)
                {
                    body["DISCOVERY_NAME"] = ExpressionConverter.ConvertO(__workflow_bodydISCOVERYNAME);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONCODE != null)
                {
                    body["LOCATION_CODE"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONCODE);
                    bodypropCount++;
                }

                if (__workflow_bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodylASTUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = ExpressionConverter.ConvertO(__workflow_bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (__workflow_bodyiSDELIVERYADDRESS != null)
                {
                    body["IS_DELIVERY_ADDRESS"] = ExpressionConverter.ConvertO(__workflow_bodyiSDELIVERYADDRESS);
                    bodypropCount++;
                }

                if (__workflow_bodytIMEZONEID != null)
                {
                    body["TIME_ZONE_ID"] = ExpressionConverter.ConvertO(__workflow_bodytIMEZONEID);
                    bodypropCount++;
                }

                if (__workflow_bodysTATUSID != null)
                {
                    body["STATUS_ID"] = ExpressionConverter.ConvertO(__workflow_bodysTATUSID);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (__workflow_bodysLAID != null)
                {
                    body["SLA_ID"] = ExpressionConverter.ConvertO(__workflow_bodysLAID);
                    bodypropCount++;
                }

                if (__workflow_bodygMAPLAT != null)
                {
                    body["G_MAP_LAT"] = ExpressionConverter.ConvertO(__workflow_bodygMAPLAT);
                    bodypropCount++;
                }

                if (__workflow_bodygMAPLNG != null)
                {
                    body["G_MAP_LNG"] = ExpressionConverter.ConvertO(__workflow_bodygMAPLNG);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL1 != null)
                {
                    body["LOCATION_L1"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL1);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL2 != null)
                {
                    body["LOCATION_L2"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL2);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL3 != null)
                {
                    body["LOCATION_L3"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL3);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL4 != null)
                {
                    body["LOCATION_L4"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL4);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL5 != null)
                {
                    body["LOCATION_L5"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL5);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONL6 != null)
                {
                    body["LOCATION_L6"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONL6);
                    bodypropCount++;
                }

                if (__workflow_bodyeISMEETINGROOM != null)
                {
                    body["E_IS_MEETING_ROOM"] = ExpressionConverter.ConvertO(__workflow_bodyeISMEETINGROOM);
                    bodypropCount++;
                }

                if (__workflow_bodyeCAPACITY != null)
                {
                    body["E_CAPACITY"] = ExpressionConverter.ConvertO(__workflow_bodyeCAPACITY);
                    bodypropCount++;
                }

                if (__workflow_bodyeWIFILOGIN != null)
                {
                    body["E_WIFI_LOGIN"] = ExpressionConverter.ConvertO(__workflow_bodyeWIFILOGIN);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewManufacturerListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewManufacturerListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer(Expression<Func<string>> account, Expression<Func<string>> manufacturerId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_manufacturerId = manufacturerId == null ? null : WorkflowExpression.Compile(manufacturerId);
            WorkflowExpression.Validate(__workflow_manufacturerId, nameof(manufacturerId), required: true);
            return new DeferredBodyAction<ViewManufacturerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_manufacturerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewRequestsIncidentsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewRequestsIncidentsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident(Expression<Func<string>> account, Expression<Func<bodyrequestsInputItem[]>> bodyrequests = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_bodyrequests = bodyrequests == null ? null : WorkflowExpression.Compile(bodyrequests);
            WorkflowExpression.Validate(__workflow_bodyrequests, nameof(bodyrequests), required: false);
            return new DeferredBodyAction<CreateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequests != null)
                {
                    body["requests"] = ExpressionConverter.ConvertO(__workflow_bodyrequests);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodyclosedInputItem[]>> bodyclosed = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyclosed = bodyclosed == null ? null : WorkflowExpression.Compile(bodyclosed);
            WorkflowExpression.Validate(__workflow_bodyclosed, nameof(bodyclosed), required: false);
            return new DeferredBodyAction<CloseRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyclosed != null)
                {
                    body["closed"] = ExpressionConverter.ConvertO(__workflow_bodyclosed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CloseRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyanalyticalChargeId = null, Expression<Func<string>> bodyassetId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodybudgetPlanned = null, Expression<Func<string>> bodycanBeDuplicated = null, Expression<Func<string>> bodyciId = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontinuityPlanId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydelay = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydynamicDetails = null, Expression<Func<string>> bodyeffectiveChangeDateEnd = null, Expression<Func<string>> bodyeffectiveChangeDateStart = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodyestimatedNetPrice = null, Expression<Func<string>> bodyexpectedDateUt = null, Expression<Func<string>> bodyexpectedDuration = null, Expression<Func<string>> bodyexpectedEndDateUt = null, Expression<Func<string>> bodyexpectedStartDateUt = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyfirstCallResolution = null, Expression<Func<string>> bodyhourPerDay = null, Expression<Func<string>> bodyimpactId = null, Expression<Func<string>> bodyimputationDate = null, Expression<Func<string>> bodyisMajorIncident = null, Expression<Func<string>> bodyisTemplate = null, Expression<Func<string>> bodyknownProblemsId = null, Expression<Func<string>> bodylastUpdate = null, Expression<Func<string>> bodymark1 = null, Expression<Func<string>> bodymark2 = null, Expression<Func<string>> bodymaxResolutionDateUt = null, Expression<Func<string>> bodymsProjectImportValidationWaiting = null, Expression<Func<string>> bodynetPrice = null, Expression<Func<string>> bodynetPriceCurId = null, Expression<Func<string>> bodyoriginToolId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyowningGroupId = null, Expression<Func<string>> bodyplannedChangeDateEnd = null, Expression<Func<string>> bodyplannedChangeDateStart = null, Expression<Func<string>> bodypmStatusId = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectStartDateUt = null, Expression<Func<string>> bodyqty = null, Expression<Func<string>> bodyreleaseId = null, Expression<Func<string>> bodyrentalNetPrice = null, Expression<Func<string>> bodyrentalNetPriceCurId = null, Expression<Func<string>> bodyrequestOriginId = null, Expression<Func<string>> bodyrequestedChangeDateEnd = null, Expression<Func<string>> bodyrequestedChangeDateStart = null, Expression<Func<string>> bodyrequestorId = null, Expression<Func<string>> bodyrequestorIpAddress = null, Expression<Func<string>> bodyrequestorPhone = null, Expression<Func<string>> bodyriskAmount = null, Expression<Func<string>> bodyriskDescription = null, Expression<Func<string>> bodyriskLevelId = null, Expression<Func<string>> bodyrootCauseId = null, Expression<Func<string>> bodysubmitDateUt = null, Expression<Func<string>> bodytimeUsedToSolveRequest = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyanalyticalChargeId = bodyanalyticalChargeId == null ? null : WorkflowExpression.Compile(bodyanalyticalChargeId);
            WorkflowExpression.Validate(__workflow_bodyanalyticalChargeId, nameof(bodyanalyticalChargeId), required: false);
            var __workflow_bodyassetId = bodyassetId == null ? null : WorkflowExpression.Compile(bodyassetId);
            WorkflowExpression.Validate(__workflow_bodyassetId, nameof(bodyassetId), required: false);
            var __workflow_bodyavailableField1 = bodyavailableField1 == null ? null : WorkflowExpression.Compile(bodyavailableField1);
            WorkflowExpression.Validate(__workflow_bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = bodyavailableField2 == null ? null : WorkflowExpression.Compile(bodyavailableField2);
            WorkflowExpression.Validate(__workflow_bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = bodyavailableField3 == null ? null : WorkflowExpression.Compile(bodyavailableField3);
            WorkflowExpression.Validate(__workflow_bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = bodyavailableField4 == null ? null : WorkflowExpression.Compile(bodyavailableField4);
            WorkflowExpression.Validate(__workflow_bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = bodyavailableField5 == null ? null : WorkflowExpression.Compile(bodyavailableField5);
            WorkflowExpression.Validate(__workflow_bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = bodyavailableField6 == null ? null : WorkflowExpression.Compile(bodyavailableField6);
            WorkflowExpression.Validate(__workflow_bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodybudgetPlanned = bodybudgetPlanned == null ? null : WorkflowExpression.Compile(bodybudgetPlanned);
            WorkflowExpression.Validate(__workflow_bodybudgetPlanned, nameof(bodybudgetPlanned), required: false);
            var __workflow_bodycanBeDuplicated = bodycanBeDuplicated == null ? null : WorkflowExpression.Compile(bodycanBeDuplicated);
            WorkflowExpression.Validate(__workflow_bodycanBeDuplicated, nameof(bodycanBeDuplicated), required: false);
            var __workflow_bodyciId = bodyciId == null ? null : WorkflowExpression.Compile(bodyciId);
            WorkflowExpression.Validate(__workflow_bodyciId, nameof(bodyciId), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodycontinuityPlanId = bodycontinuityPlanId == null ? null : WorkflowExpression.Compile(bodycontinuityPlanId);
            WorkflowExpression.Validate(__workflow_bodycontinuityPlanId, nameof(bodycontinuityPlanId), required: false);
            var __workflow_bodycostCenterId = bodycostCenterId == null ? null : WorkflowExpression.Compile(bodycostCenterId);
            WorkflowExpression.Validate(__workflow_bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodycreationDateUt = bodycreationDateUt == null ? null : WorkflowExpression.Compile(bodycreationDateUt);
            WorkflowExpression.Validate(__workflow_bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            var __workflow_bodydelay = bodydelay == null ? null : WorkflowExpression.Compile(bodydelay);
            WorkflowExpression.Validate(__workflow_bodydelay, nameof(bodydelay), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydynamicDetails = bodydynamicDetails == null ? null : WorkflowExpression.Compile(bodydynamicDetails);
            WorkflowExpression.Validate(__workflow_bodydynamicDetails, nameof(bodydynamicDetails), required: false);
            var __workflow_bodyeffectiveChangeDateEnd = bodyeffectiveChangeDateEnd == null ? null : WorkflowExpression.Compile(bodyeffectiveChangeDateEnd);
            WorkflowExpression.Validate(__workflow_bodyeffectiveChangeDateEnd, nameof(bodyeffectiveChangeDateEnd), required: false);
            var __workflow_bodyeffectiveChangeDateStart = bodyeffectiveChangeDateStart == null ? null : WorkflowExpression.Compile(bodyeffectiveChangeDateStart);
            WorkflowExpression.Validate(__workflow_bodyeffectiveChangeDateStart, nameof(bodyeffectiveChangeDateStart), required: false);
            var __workflow_bodyendDateUt = bodyendDateUt == null ? null : WorkflowExpression.Compile(bodyendDateUt);
            WorkflowExpression.Validate(__workflow_bodyendDateUt, nameof(bodyendDateUt), required: false);
            var __workflow_bodyestimatedNetPrice = bodyestimatedNetPrice == null ? null : WorkflowExpression.Compile(bodyestimatedNetPrice);
            WorkflowExpression.Validate(__workflow_bodyestimatedNetPrice, nameof(bodyestimatedNetPrice), required: false);
            var __workflow_bodyexpectedDateUt = bodyexpectedDateUt == null ? null : WorkflowExpression.Compile(bodyexpectedDateUt);
            WorkflowExpression.Validate(__workflow_bodyexpectedDateUt, nameof(bodyexpectedDateUt), required: false);
            var __workflow_bodyexpectedDuration = bodyexpectedDuration == null ? null : WorkflowExpression.Compile(bodyexpectedDuration);
            WorkflowExpression.Validate(__workflow_bodyexpectedDuration, nameof(bodyexpectedDuration), required: false);
            var __workflow_bodyexpectedEndDateUt = bodyexpectedEndDateUt == null ? null : WorkflowExpression.Compile(bodyexpectedEndDateUt);
            WorkflowExpression.Validate(__workflow_bodyexpectedEndDateUt, nameof(bodyexpectedEndDateUt), required: false);
            var __workflow_bodyexpectedStartDateUt = bodyexpectedStartDateUt == null ? null : WorkflowExpression.Compile(bodyexpectedStartDateUt);
            WorkflowExpression.Validate(__workflow_bodyexpectedStartDateUt, nameof(bodyexpectedStartDateUt), required: false);
            var __workflow_bodyexternalReference = bodyexternalReference == null ? null : WorkflowExpression.Compile(bodyexternalReference);
            WorkflowExpression.Validate(__workflow_bodyexternalReference, nameof(bodyexternalReference), required: false);
            var __workflow_bodyfirstCallResolution = bodyfirstCallResolution == null ? null : WorkflowExpression.Compile(bodyfirstCallResolution);
            WorkflowExpression.Validate(__workflow_bodyfirstCallResolution, nameof(bodyfirstCallResolution), required: false);
            var __workflow_bodyhourPerDay = bodyhourPerDay == null ? null : WorkflowExpression.Compile(bodyhourPerDay);
            WorkflowExpression.Validate(__workflow_bodyhourPerDay, nameof(bodyhourPerDay), required: false);
            var __workflow_bodyimpactId = bodyimpactId == null ? null : WorkflowExpression.Compile(bodyimpactId);
            WorkflowExpression.Validate(__workflow_bodyimpactId, nameof(bodyimpactId), required: false);
            var __workflow_bodyimputationDate = bodyimputationDate == null ? null : WorkflowExpression.Compile(bodyimputationDate);
            WorkflowExpression.Validate(__workflow_bodyimputationDate, nameof(bodyimputationDate), required: false);
            var __workflow_bodyisMajorIncident = bodyisMajorIncident == null ? null : WorkflowExpression.Compile(bodyisMajorIncident);
            WorkflowExpression.Validate(__workflow_bodyisMajorIncident, nameof(bodyisMajorIncident), required: false);
            var __workflow_bodyisTemplate = bodyisTemplate == null ? null : WorkflowExpression.Compile(bodyisTemplate);
            WorkflowExpression.Validate(__workflow_bodyisTemplate, nameof(bodyisTemplate), required: false);
            var __workflow_bodyknownProblemsId = bodyknownProblemsId == null ? null : WorkflowExpression.Compile(bodyknownProblemsId);
            WorkflowExpression.Validate(__workflow_bodyknownProblemsId, nameof(bodyknownProblemsId), required: false);
            var __workflow_bodylastUpdate = bodylastUpdate == null ? null : WorkflowExpression.Compile(bodylastUpdate);
            WorkflowExpression.Validate(__workflow_bodylastUpdate, nameof(bodylastUpdate), required: false);
            var __workflow_bodymark1 = bodymark1 == null ? null : WorkflowExpression.Compile(bodymark1);
            WorkflowExpression.Validate(__workflow_bodymark1, nameof(bodymark1), required: false);
            var __workflow_bodymark2 = bodymark2 == null ? null : WorkflowExpression.Compile(bodymark2);
            WorkflowExpression.Validate(__workflow_bodymark2, nameof(bodymark2), required: false);
            var __workflow_bodymaxResolutionDateUt = bodymaxResolutionDateUt == null ? null : WorkflowExpression.Compile(bodymaxResolutionDateUt);
            WorkflowExpression.Validate(__workflow_bodymaxResolutionDateUt, nameof(bodymaxResolutionDateUt), required: false);
            var __workflow_bodymsProjectImportValidationWaiting = bodymsProjectImportValidationWaiting == null ? null : WorkflowExpression.Compile(bodymsProjectImportValidationWaiting);
            WorkflowExpression.Validate(__workflow_bodymsProjectImportValidationWaiting, nameof(bodymsProjectImportValidationWaiting), required: false);
            var __workflow_bodynetPrice = bodynetPrice == null ? null : WorkflowExpression.Compile(bodynetPrice);
            WorkflowExpression.Validate(__workflow_bodynetPrice, nameof(bodynetPrice), required: false);
            var __workflow_bodynetPriceCurId = bodynetPriceCurId == null ? null : WorkflowExpression.Compile(bodynetPriceCurId);
            WorkflowExpression.Validate(__workflow_bodynetPriceCurId, nameof(bodynetPriceCurId), required: false);
            var __workflow_bodyoriginToolId = bodyoriginToolId == null ? null : WorkflowExpression.Compile(bodyoriginToolId);
            WorkflowExpression.Validate(__workflow_bodyoriginToolId, nameof(bodyoriginToolId), required: false);
            var __workflow_bodyownerId = bodyownerId == null ? null : WorkflowExpression.Compile(bodyownerId);
            WorkflowExpression.Validate(__workflow_bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyowningGroupId = bodyowningGroupId == null ? null : WorkflowExpression.Compile(bodyowningGroupId);
            WorkflowExpression.Validate(__workflow_bodyowningGroupId, nameof(bodyowningGroupId), required: false);
            var __workflow_bodyplannedChangeDateEnd = bodyplannedChangeDateEnd == null ? null : WorkflowExpression.Compile(bodyplannedChangeDateEnd);
            WorkflowExpression.Validate(__workflow_bodyplannedChangeDateEnd, nameof(bodyplannedChangeDateEnd), required: false);
            var __workflow_bodyplannedChangeDateStart = bodyplannedChangeDateStart == null ? null : WorkflowExpression.Compile(bodyplannedChangeDateStart);
            WorkflowExpression.Validate(__workflow_bodyplannedChangeDateStart, nameof(bodyplannedChangeDateStart), required: false);
            var __workflow_bodypmStatusId = bodypmStatusId == null ? null : WorkflowExpression.Compile(bodypmStatusId);
            WorkflowExpression.Validate(__workflow_bodypmStatusId, nameof(bodypmStatusId), required: false);
            var __workflow_bodyprojectName = bodyprojectName == null ? null : WorkflowExpression.Compile(bodyprojectName);
            WorkflowExpression.Validate(__workflow_bodyprojectName, nameof(bodyprojectName), required: false);
            var __workflow_bodyprojectStartDateUt = bodyprojectStartDateUt == null ? null : WorkflowExpression.Compile(bodyprojectStartDateUt);
            WorkflowExpression.Validate(__workflow_bodyprojectStartDateUt, nameof(bodyprojectStartDateUt), required: false);
            var __workflow_bodyqty = bodyqty == null ? null : WorkflowExpression.Compile(bodyqty);
            WorkflowExpression.Validate(__workflow_bodyqty, nameof(bodyqty), required: false);
            var __workflow_bodyreleaseId = bodyreleaseId == null ? null : WorkflowExpression.Compile(bodyreleaseId);
            WorkflowExpression.Validate(__workflow_bodyreleaseId, nameof(bodyreleaseId), required: false);
            var __workflow_bodyrentalNetPrice = bodyrentalNetPrice == null ? null : WorkflowExpression.Compile(bodyrentalNetPrice);
            WorkflowExpression.Validate(__workflow_bodyrentalNetPrice, nameof(bodyrentalNetPrice), required: false);
            var __workflow_bodyrentalNetPriceCurId = bodyrentalNetPriceCurId == null ? null : WorkflowExpression.Compile(bodyrentalNetPriceCurId);
            WorkflowExpression.Validate(__workflow_bodyrentalNetPriceCurId, nameof(bodyrentalNetPriceCurId), required: false);
            var __workflow_bodyrequestOriginId = bodyrequestOriginId == null ? null : WorkflowExpression.Compile(bodyrequestOriginId);
            WorkflowExpression.Validate(__workflow_bodyrequestOriginId, nameof(bodyrequestOriginId), required: false);
            var __workflow_bodyrequestedChangeDateEnd = bodyrequestedChangeDateEnd == null ? null : WorkflowExpression.Compile(bodyrequestedChangeDateEnd);
            WorkflowExpression.Validate(__workflow_bodyrequestedChangeDateEnd, nameof(bodyrequestedChangeDateEnd), required: false);
            var __workflow_bodyrequestedChangeDateStart = bodyrequestedChangeDateStart == null ? null : WorkflowExpression.Compile(bodyrequestedChangeDateStart);
            WorkflowExpression.Validate(__workflow_bodyrequestedChangeDateStart, nameof(bodyrequestedChangeDateStart), required: false);
            var __workflow_bodyrequestorId = bodyrequestorId == null ? null : WorkflowExpression.Compile(bodyrequestorId);
            WorkflowExpression.Validate(__workflow_bodyrequestorId, nameof(bodyrequestorId), required: false);
            var __workflow_bodyrequestorIpAddress = bodyrequestorIpAddress == null ? null : WorkflowExpression.Compile(bodyrequestorIpAddress);
            WorkflowExpression.Validate(__workflow_bodyrequestorIpAddress, nameof(bodyrequestorIpAddress), required: false);
            var __workflow_bodyrequestorPhone = bodyrequestorPhone == null ? null : WorkflowExpression.Compile(bodyrequestorPhone);
            WorkflowExpression.Validate(__workflow_bodyrequestorPhone, nameof(bodyrequestorPhone), required: false);
            var __workflow_bodyriskAmount = bodyriskAmount == null ? null : WorkflowExpression.Compile(bodyriskAmount);
            WorkflowExpression.Validate(__workflow_bodyriskAmount, nameof(bodyriskAmount), required: false);
            var __workflow_bodyriskDescription = bodyriskDescription == null ? null : WorkflowExpression.Compile(bodyriskDescription);
            WorkflowExpression.Validate(__workflow_bodyriskDescription, nameof(bodyriskDescription), required: false);
            var __workflow_bodyriskLevelId = bodyriskLevelId == null ? null : WorkflowExpression.Compile(bodyriskLevelId);
            WorkflowExpression.Validate(__workflow_bodyriskLevelId, nameof(bodyriskLevelId), required: false);
            var __workflow_bodyrootCauseId = bodyrootCauseId == null ? null : WorkflowExpression.Compile(bodyrootCauseId);
            WorkflowExpression.Validate(__workflow_bodyrootCauseId, nameof(bodyrootCauseId), required: false);
            var __workflow_bodysubmitDateUt = bodysubmitDateUt == null ? null : WorkflowExpression.Compile(bodysubmitDateUt);
            WorkflowExpression.Validate(__workflow_bodysubmitDateUt, nameof(bodysubmitDateUt), required: false);
            var __workflow_bodytimeUsedToSolveRequest = bodytimeUsedToSolveRequest == null ? null : WorkflowExpression.Compile(bodytimeUsedToSolveRequest);
            WorkflowExpression.Validate(__workflow_bodytimeUsedToSolveRequest, nameof(bodytimeUsedToSolveRequest), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<UpdateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyanalyticalChargeId != null)
                {
                    body["Analytical_Charge_Id"] = ExpressionConverter.ConvertO(__workflow_bodyanalyticalChargeId);
                    bodypropCount++;
                }

                if (__workflow_bodyassetId != null)
                {
                    body["Asset_Id"] = ExpressionConverter.ConvertO(__workflow_bodyassetId);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField1 != null)
                {
                    body["Available_Field_1"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField1);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField2 != null)
                {
                    body["Available_Field_2"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField2);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField3 != null)
                {
                    body["Available_Field_3"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField3);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField4 != null)
                {
                    body["Available_Field_4"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField4);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField5 != null)
                {
                    body["Available_Field_5"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField5);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField6 != null)
                {
                    body["Available_Field_6"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField6);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetPlanned != null)
                {
                    body["Budget_Planned"] = ExpressionConverter.ConvertO(__workflow_bodybudgetPlanned);
                    bodypropCount++;
                }

                if (__workflow_bodycanBeDuplicated != null)
                {
                    body["Can_Be_Duplicated"] = ExpressionConverter.ConvertO(__workflow_bodycanBeDuplicated);
                    bodypropCount++;
                }

                if (__workflow_bodyciId != null)
                {
                    body["Ci_Id"] = ExpressionConverter.ConvertO(__workflow_bodyciId);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodycontinuityPlanId != null)
                {
                    body["Continuity_Plan_Id"] = ExpressionConverter.ConvertO(__workflow_bodycontinuityPlanId);
                    bodypropCount++;
                }

                if (__workflow_bodycostCenterId != null)
                {
                    body["Cost_Center_Id"] = ExpressionConverter.ConvertO(__workflow_bodycostCenterId);
                    bodypropCount++;
                }

                if (__workflow_bodycreationDateUt != null)
                {
                    body["Creation_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodycreationDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodydelay != null)
                {
                    body["Delay"] = ExpressionConverter.ConvertO(__workflow_bodydelay);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydynamicDetails != null)
                {
                    body["Dynamic_Details"] = ExpressionConverter.ConvertO(__workflow_bodydynamicDetails);
                    bodypropCount++;
                }

                if (__workflow_bodyeffectiveChangeDateEnd != null)
                {
                    body["Effective_Change_Date_End"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveChangeDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodyeffectiveChangeDateStart != null)
                {
                    body["Effective_Change_Date_Start"] = ExpressionConverter.ConvertO(__workflow_bodyeffectiveChangeDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodyendDateUt != null)
                {
                    body["End_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodyendDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodyestimatedNetPrice != null)
                {
                    body["Estimated_Net_Price"] = ExpressionConverter.ConvertO(__workflow_bodyestimatedNetPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDateUt != null)
                {
                    body["Expected_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDuration != null)
                {
                    body["Expected_Duration"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDuration);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedEndDateUt != null)
                {
                    body["Expected_End_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedStartDateUt != null)
                {
                    body["Expected_Start_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStartDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalReference != null)
                {
                    body["External_Reference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalReference);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstCallResolution != null)
                {
                    body["First_Call_Resolution"] = ExpressionConverter.ConvertO(__workflow_bodyfirstCallResolution);
                    bodypropCount++;
                }

                if (__workflow_bodyhourPerDay != null)
                {
                    body["Hour_Per_Day"] = ExpressionConverter.ConvertO(__workflow_bodyhourPerDay);
                    bodypropCount++;
                }

                if (__workflow_bodyimpactId != null)
                {
                    body["Impact_Id"] = ExpressionConverter.ConvertO(__workflow_bodyimpactId);
                    bodypropCount++;
                }

                if (__workflow_bodyimputationDate != null)
                {
                    body["Imputation_Date"] = ExpressionConverter.ConvertO(__workflow_bodyimputationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyisMajorIncident != null)
                {
                    body["Is_Major_Incident"] = ExpressionConverter.ConvertO(__workflow_bodyisMajorIncident);
                    bodypropCount++;
                }

                if (__workflow_bodyisTemplate != null)
                {
                    body["Is_Template"] = ExpressionConverter.ConvertO(__workflow_bodyisTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyknownProblemsId != null)
                {
                    body["Known_Problems_Id"] = ExpressionConverter.ConvertO(__workflow_bodyknownProblemsId);
                    bodypropCount++;
                }

                if (__workflow_bodylastUpdate != null)
                {
                    body["Last_Update"] = ExpressionConverter.ConvertO(__workflow_bodylastUpdate);
                    bodypropCount++;
                }

                if (__workflow_bodymark1 != null)
                {
                    body["Mark_1"] = ExpressionConverter.ConvertO(__workflow_bodymark1);
                    bodypropCount++;
                }

                if (__workflow_bodymark2 != null)
                {
                    body["Mark_2"] = ExpressionConverter.ConvertO(__workflow_bodymark2);
                    bodypropCount++;
                }

                if (__workflow_bodymaxResolutionDateUt != null)
                {
                    body["Max_Resolution_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodymaxResolutionDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodymsProjectImportValidationWaiting != null)
                {
                    body["Ms_Project_Import_Validation_Waiting"] = ExpressionConverter.ConvertO(__workflow_bodymsProjectImportValidationWaiting);
                    bodypropCount++;
                }

                if (__workflow_bodynetPrice != null)
                {
                    body["Net_Price"] = ExpressionConverter.ConvertO(__workflow_bodynetPrice);
                    bodypropCount++;
                }

                if (__workflow_bodynetPriceCurId != null)
                {
                    body["Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(__workflow_bodynetPriceCurId);
                    bodypropCount++;
                }

                if (__workflow_bodyoriginToolId != null)
                {
                    body["Origin_Tool_Id"] = ExpressionConverter.ConvertO(__workflow_bodyoriginToolId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["Owner_Id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyowningGroupId != null)
                {
                    body["Owning_Group_Id"] = ExpressionConverter.ConvertO(__workflow_bodyowningGroupId);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedChangeDateEnd != null)
                {
                    body["Planned_Change_Date_End"] = ExpressionConverter.ConvertO(__workflow_bodyplannedChangeDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedChangeDateStart != null)
                {
                    body["Planned_Change_Date_Start"] = ExpressionConverter.ConvertO(__workflow_bodyplannedChangeDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodypmStatusId != null)
                {
                    body["Pm_Status_Id"] = ExpressionConverter.ConvertO(__workflow_bodypmStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectName != null)
                {
                    body["Project_Name"] = ExpressionConverter.ConvertO(__workflow_bodyprojectName);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectStartDateUt != null)
                {
                    body["Project_Start_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodyprojectStartDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodyqty != null)
                {
                    body["Qty"] = ExpressionConverter.ConvertO(__workflow_bodyqty);
                    bodypropCount++;
                }

                if (__workflow_bodyreleaseId != null)
                {
                    body["Release_Id"] = ExpressionConverter.ConvertO(__workflow_bodyreleaseId);
                    bodypropCount++;
                }

                if (__workflow_bodyrentalNetPrice != null)
                {
                    body["Rental_Net_Price"] = ExpressionConverter.ConvertO(__workflow_bodyrentalNetPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyrentalNetPriceCurId != null)
                {
                    body["Rental_Net_Price_Cur_Id"] = ExpressionConverter.ConvertO(__workflow_bodyrentalNetPriceCurId);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestOriginId != null)
                {
                    body["Request_Origin_Id"] = ExpressionConverter.ConvertO(__workflow_bodyrequestOriginId);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestedChangeDateEnd != null)
                {
                    body["Requested_Change_Date_End"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedChangeDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestedChangeDateStart != null)
                {
                    body["Requested_Change_Date_Start"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedChangeDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestorId != null)
                {
                    body["Requestor_Id"] = ExpressionConverter.ConvertO(__workflow_bodyrequestorId);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestorIpAddress != null)
                {
                    body["Requestor_Ip_Address"] = ExpressionConverter.ConvertO(__workflow_bodyrequestorIpAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestorPhone != null)
                {
                    body["Requestor_Phone"] = ExpressionConverter.ConvertO(__workflow_bodyrequestorPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyriskAmount != null)
                {
                    body["Risk_Amount"] = ExpressionConverter.ConvertO(__workflow_bodyriskAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyriskDescription != null)
                {
                    body["Risk_Description"] = ExpressionConverter.ConvertO(__workflow_bodyriskDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyriskLevelId != null)
                {
                    body["Risk_Level_Id"] = ExpressionConverter.ConvertO(__workflow_bodyriskLevelId);
                    bodypropCount++;
                }

                if (__workflow_bodyrootCauseId != null)
                {
                    body["Root_Cause_Id"] = ExpressionConverter.ConvertO(__workflow_bodyrootCauseId);
                    bodypropCount++;
                }

                if (__workflow_bodysubmitDateUt != null)
                {
                    body["Submit_Date_Ut"] = ExpressionConverter.ConvertO(__workflow_bodysubmitDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodytimeUsedToSolveRequest != null)
                {
                    body["Time_Used_To_Solve_Request"] = ExpressionConverter.ConvertO(__workflow_bodytimeUsedToSolveRequest);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/comment", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<GetRequestIncidentDocumentListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodydocumentsInputItem[]>> bodydocuments)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodydocuments = bodydocuments == null ? null : WorkflowExpression.Compile(bodydocuments);
            WorkflowExpression.Validate(__workflow_bodydocuments, nameof(bodydocuments), required: true);
            return new DeferredBodyAction<UploadAndAttachADocumentToARequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadAndAttachADocumentToARequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<int>> bodydoneById = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodydoneById = bodydoneById == null ? null : WorkflowExpression.Compile(bodydoneById);
            WorkflowExpression.Validate(__workflow_bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<RestartRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/restart", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodydoneById != null)
                {
                    body["done_by_id"] = ExpressionConverter.ConvertO(__workflow_bodydoneById);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RestartRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodydoneById = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodydoneById = bodydoneById == null ? null : WorkflowExpression.Compile(bodydoneById);
            WorkflowExpression.Validate(__workflow_bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<SuspendRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/suspend", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodydoneById != null)
                {
                    body["done_by_id"] = ExpressionConverter.ConvertO(__workflow_bodydoneById);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SuspendRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyactionTypeId, Expression<Func<string>> bodyelapsedTime = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycontractualCost = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodygroupMail = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodystartDateUt = null, Expression<Func<string>> bodytimeCost = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyactionTypeId = bodyactionTypeId == null ? null : WorkflowExpression.Compile(bodyactionTypeId);
            WorkflowExpression.Validate(__workflow_bodyactionTypeId, nameof(bodyactionTypeId), required: true);
            var __workflow_bodyelapsedTime = bodyelapsedTime == null ? null : WorkflowExpression.Compile(bodyelapsedTime);
            WorkflowExpression.Validate(__workflow_bodyelapsedTime, nameof(bodyelapsedTime), required: false);
            var __workflow_bodyavailableField1 = bodyavailableField1 == null ? null : WorkflowExpression.Compile(bodyavailableField1);
            WorkflowExpression.Validate(__workflow_bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = bodyavailableField2 == null ? null : WorkflowExpression.Compile(bodyavailableField2);
            WorkflowExpression.Validate(__workflow_bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = bodyavailableField3 == null ? null : WorkflowExpression.Compile(bodyavailableField3);
            WorkflowExpression.Validate(__workflow_bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = bodyavailableField4 == null ? null : WorkflowExpression.Compile(bodyavailableField4);
            WorkflowExpression.Validate(__workflow_bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = bodyavailableField5 == null ? null : WorkflowExpression.Compile(bodyavailableField5);
            WorkflowExpression.Validate(__workflow_bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = bodyavailableField6 == null ? null : WorkflowExpression.Compile(bodyavailableField6);
            WorkflowExpression.Validate(__workflow_bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodycontractualCost = bodycontractualCost == null ? null : WorkflowExpression.Compile(bodycontractualCost);
            WorkflowExpression.Validate(__workflow_bodycontractualCost, nameof(bodycontractualCost), required: false);
            var __workflow_bodycreationDateUt = bodycreationDateUt == null ? null : WorkflowExpression.Compile(bodycreationDateUt);
            WorkflowExpression.Validate(__workflow_bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyendDateUt = bodyendDateUt == null ? null : WorkflowExpression.Compile(bodyendDateUt);
            WorkflowExpression.Validate(__workflow_bodyendDateUt, nameof(bodyendDateUt), required: false);
            var __workflow_bodygroupMail = bodygroupMail == null ? null : WorkflowExpression.Compile(bodygroupMail);
            WorkflowExpression.Validate(__workflow_bodygroupMail, nameof(bodygroupMail), required: false);
            var __workflow_bodygroupName = bodygroupName == null ? null : WorkflowExpression.Compile(bodygroupName);
            WorkflowExpression.Validate(__workflow_bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodystartDateUt = bodystartDateUt == null ? null : WorkflowExpression.Compile(bodystartDateUt);
            WorkflowExpression.Validate(__workflow_bodystartDateUt, nameof(bodystartDateUt), required: false);
            var __workflow_bodytimeCost = bodytimeCost == null ? null : WorkflowExpression.Compile(bodytimeCost);
            WorkflowExpression.Validate(__workflow_bodytimeCost, nameof(bodytimeCost), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyelapsedTime != null)
                {
                    body["Elapsed_Time"] = ExpressionConverter.ConvertO(__workflow_bodyelapsedTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["action_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyactionTypeId);
                if (__workflow_bodyavailableField1 != null)
                {
                    body["available_field_1"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField1);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField2 != null)
                {
                    body["available_field_2"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField2);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField3 != null)
                {
                    body["available_field_3"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField3);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField4 != null)
                {
                    body["available_field_4"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField4);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField5 != null)
                {
                    body["available_field_5"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField5);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField6 != null)
                {
                    body["available_field_6"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField6);
                    bodypropCount++;
                }

                if (__workflow_bodycontractualCost != null)
                {
                    body["contractual_cost"] = ExpressionConverter.ConvertO(__workflow_bodycontractualCost);
                    bodypropCount++;
                }

                if (__workflow_bodycreationDateUt != null)
                {
                    body["creation_date_ut"] = ExpressionConverter.ConvertO(__workflow_bodycreationDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyendDateUt != null)
                {
                    body["end_date_ut"] = ExpressionConverter.ConvertO(__workflow_bodyendDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodygroupMail != null)
                {
                    body["group_mail"] = ExpressionConverter.ConvertO(__workflow_bodygroupMail);
                    bodypropCount++;
                }

                if (__workflow_bodygroupName != null)
                {
                    body["group_name"] = ExpressionConverter.ConvertO(__workflow_bodygroupName);
                    bodypropCount++;
                }

                if (__workflow_bodystartDateUt != null)
                {
                    body["start_date_ut"] = ExpressionConverter.ConvertO(__workflow_bodystartDateUt);
                    bodypropCount++;
                }

                if (__workflow_bodytimeCost != null)
                {
                    body["time_cost"] = ExpressionConverter.ConvertO(__workflow_bodytimeCost);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            var __workflow_maxRows = maxRows == null ? null : WorkflowExpression.Compile(maxRows);
            WorkflowExpression.Validate(__workflow_maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewSlasListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(__workflow_maxRows);
                return new ApiConnectionAction<ViewSlasListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla(Expression<Func<string>> account, Expression<Func<string>> slaId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_slaId = slaId == null ? null : WorkflowExpression.Compile(slaId);
            WorkflowExpression.Validate(__workflow_slaId, nameof(slaId), required: true);
            return new DeferredBodyAction<ViewSlaResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_slaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewSlaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesAssetsResponse> ViewAllAtributesAssets(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewAllAtributesAssetsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAllAtributesAssetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction CreateLinkBetweenAttributandAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_characteristicId = characteristicId == null ? null : WorkflowExpression.Compile(characteristicId);
            WorkflowExpression.Validate(__workflow_characteristicId, nameof(characteristicId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_characteristicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateanAttributeofanAssetResponse> UpdateanAttributeofanAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> characteristicId, Expression<Func<string>> bodydATA1 = null, Expression<Func<string>> bodydATA2 = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            var __workflow_characteristicId = characteristicId == null ? null : WorkflowExpression.Compile(characteristicId);
            WorkflowExpression.Validate(__workflow_characteristicId, nameof(characteristicId), required: true);
            var __workflow_bodydATA1 = bodydATA1 == null ? null : WorkflowExpression.Compile(bodydATA1);
            WorkflowExpression.Validate(__workflow_bodydATA1, nameof(bodydATA1), required: false);
            var __workflow_bodydATA2 = bodydATA2 == null ? null : WorkflowExpression.Compile(bodydATA2);
            WorkflowExpression.Validate(__workflow_bodydATA2, nameof(bodydATA2), required: false);
            return new DeferredBodyAction<UpdateanAttributeofanAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_characteristicId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydATA1 != null)
                {
                    body["DATA_1"] = ExpressionConverter.ConvertO(__workflow_bodydATA1);
                    bodypropCount++;
                }

                if (__workflow_bodydATA2 != null)
                {
                    body["DATA_2"] = ExpressionConverter.ConvertO(__workflow_bodydATA2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateanAttributeofanAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIResponse> CreateCI(Expression<Func<bodyassetsInputItem2[]>> bodyassets = null)
        {
            var __workflow_bodyassets = bodyassets == null ? null : WorkflowExpression.Compile(bodyassets);
            WorkflowExpression.Validate(__workflow_bodyassets, nameof(bodyassets), required: false);
            return new DeferredBodyAction<CreateCIResponse>(() =>
            {
                var apiCallPath = "/api/v1/50006/assets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassets != null)
                {
                    body["assets"] = ExpressionConverter.ConvertO(__workflow_bodyassets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIunavailabilityResponse> CreateCIunavailability(Expression<Func<string>> ciId)
        {
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<CreateCIunavailabilityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateCIunavailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<EndCIunavailabilityResponse> EndCIunavailability(Expression<Func<string>> ciId)
        {
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<EndCIunavailabilityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EndCIunavailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactonCIResponse> ViewlinksimpactonCI(Expression<Func<string>> ciId)
        {
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewlinksimpactonCIResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacting", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewlinksimpactonCIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactbyCIResponse> ViewlinksimpactbyCI(Expression<Func<string>> ciId)
        {
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewlinksimpactbyCIResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacted", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewlinksimpactbyCIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewTicketStatusListResponse> ViewTicketStatusList(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewTicketStatusListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewTicketStatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedTicketsResponse> ViewListProblemsAttachedTickets(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListProblemsAttachedTicketsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problem-links", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListProblemsAttachedTicketsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedATicketsResponse> ViewListProblemsAttachedATickets(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewListProblemsAttachedATicketsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/problems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListProblemsAttachedATicketsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListTicketsAttachedtoaProblemResponse> ViewListTicketsAttachedtoaProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewListTicketsAttachedtoaProblemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}/requests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListTicketsAttachedtoaProblemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsResponse> ViewListQuestions(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListQuestionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListQuestionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsWithResponseResponse> ViewListQuestionsWithResponse(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListQuestionsWithResponseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListQuestionsWithResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewaQuestionResponse> ViewaQuestion(Expression<Func<string>> account, Expression<Func<string>> questionId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_questionId = questionId == null ? null : WorkflowExpression.Compile(questionId);
            WorkflowExpression.Validate(__workflow_questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<ViewaQuestionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewaQuestionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllResponsesListQuestionsofaTicketResponse> ViewAllResponsesListQuestionsofaTicket(Expression<Func<string>> account, Expression<Func<string>> requestId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<ViewAllResponsesListQuestionsofaTicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAllResponsesListQuestionsofaTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewResponseQuestionTicketResponse> ViewResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_questionId = questionId == null ? null : WorkflowExpression.Compile(questionId);
            WorkflowExpression.Validate(__workflow_questionId, nameof(questionId), required: true);
            return new DeferredBodyAction<ViewResponseQuestionTicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewResponseQuestionTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateResponseQuestionTicketResponse> CreateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyrESULT = null, Expression<Func<string>> bodyrESULTSTRINGEN = null, Expression<Func<string>> bodyrESULTSTRINGFR = null, Expression<Func<string>> bodyrESULTSTRINGSP = null, Expression<Func<string>> bodyrESULTSTRINGGE = null, Expression<Func<string>> bodyrESULTSTRINGIT = null, Expression<Func<string>> bodyrESULTSTRINGPO = null, Expression<Func<string>> bodyrESULTDATE = null, Expression<Func<string>> bodyrESULTNUMBER = null, Expression<Func<string>> bodyrESULTBIT = null, Expression<Func<string>> bodyrESULTORDER = null, Expression<Func<string>> bodyrESULTSTRINGL1 = null, Expression<Func<string>> bodyrESULTSTRINGL2 = null, Expression<Func<string>> bodyrESULTSTRINGL3 = null, Expression<Func<string>> bodyrESULTSTRINGL4 = null, Expression<Func<string>> bodyrESULTSTRINGL5 = null, Expression<Func<string>> bodyrESULTSTRINGL6 = null, Expression<Func<string>> bodyqUESTIONDISPLAYED = null, Expression<Func<string>> bodydOCUMENTID = null, Expression<Func<string>> bodyqUESTIONREQUIRED = null, Expression<Func<string>> bodyiSCONDITIONNAL = null, Expression<Func<string>> bodyrESULTDURATION = null, Expression<Func<string>> bodysYSQUESTIONNAIREID = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTQUESTIONNAIRE = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_questionId = questionId == null ? null : WorkflowExpression.Compile(questionId);
            WorkflowExpression.Validate(__workflow_questionId, nameof(questionId), required: true);
            var __workflow_bodyrESULT = bodyrESULT == null ? null : WorkflowExpression.Compile(bodyrESULT);
            WorkflowExpression.Validate(__workflow_bodyrESULT, nameof(bodyrESULT), required: false);
            var __workflow_bodyrESULTSTRINGEN = bodyrESULTSTRINGEN == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGEN);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGEN, nameof(bodyrESULTSTRINGEN), required: false);
            var __workflow_bodyrESULTSTRINGFR = bodyrESULTSTRINGFR == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGFR);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGFR, nameof(bodyrESULTSTRINGFR), required: false);
            var __workflow_bodyrESULTSTRINGSP = bodyrESULTSTRINGSP == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGSP);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGSP, nameof(bodyrESULTSTRINGSP), required: false);
            var __workflow_bodyrESULTSTRINGGE = bodyrESULTSTRINGGE == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGGE);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGGE, nameof(bodyrESULTSTRINGGE), required: false);
            var __workflow_bodyrESULTSTRINGIT = bodyrESULTSTRINGIT == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGIT);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGIT, nameof(bodyrESULTSTRINGIT), required: false);
            var __workflow_bodyrESULTSTRINGPO = bodyrESULTSTRINGPO == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGPO);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGPO, nameof(bodyrESULTSTRINGPO), required: false);
            var __workflow_bodyrESULTDATE = bodyrESULTDATE == null ? null : WorkflowExpression.Compile(bodyrESULTDATE);
            WorkflowExpression.Validate(__workflow_bodyrESULTDATE, nameof(bodyrESULTDATE), required: false);
            var __workflow_bodyrESULTNUMBER = bodyrESULTNUMBER == null ? null : WorkflowExpression.Compile(bodyrESULTNUMBER);
            WorkflowExpression.Validate(__workflow_bodyrESULTNUMBER, nameof(bodyrESULTNUMBER), required: false);
            var __workflow_bodyrESULTBIT = bodyrESULTBIT == null ? null : WorkflowExpression.Compile(bodyrESULTBIT);
            WorkflowExpression.Validate(__workflow_bodyrESULTBIT, nameof(bodyrESULTBIT), required: false);
            var __workflow_bodyrESULTORDER = bodyrESULTORDER == null ? null : WorkflowExpression.Compile(bodyrESULTORDER);
            WorkflowExpression.Validate(__workflow_bodyrESULTORDER, nameof(bodyrESULTORDER), required: false);
            var __workflow_bodyrESULTSTRINGL1 = bodyrESULTSTRINGL1 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL1);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL1, nameof(bodyrESULTSTRINGL1), required: false);
            var __workflow_bodyrESULTSTRINGL2 = bodyrESULTSTRINGL2 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL2);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL2, nameof(bodyrESULTSTRINGL2), required: false);
            var __workflow_bodyrESULTSTRINGL3 = bodyrESULTSTRINGL3 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL3);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL3, nameof(bodyrESULTSTRINGL3), required: false);
            var __workflow_bodyrESULTSTRINGL4 = bodyrESULTSTRINGL4 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL4);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL4, nameof(bodyrESULTSTRINGL4), required: false);
            var __workflow_bodyrESULTSTRINGL5 = bodyrESULTSTRINGL5 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL5);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL5, nameof(bodyrESULTSTRINGL5), required: false);
            var __workflow_bodyrESULTSTRINGL6 = bodyrESULTSTRINGL6 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL6);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL6, nameof(bodyrESULTSTRINGL6), required: false);
            var __workflow_bodyqUESTIONDISPLAYED = bodyqUESTIONDISPLAYED == null ? null : WorkflowExpression.Compile(bodyqUESTIONDISPLAYED);
            WorkflowExpression.Validate(__workflow_bodyqUESTIONDISPLAYED, nameof(bodyqUESTIONDISPLAYED), required: false);
            var __workflow_bodydOCUMENTID = bodydOCUMENTID == null ? null : WorkflowExpression.Compile(bodydOCUMENTID);
            WorkflowExpression.Validate(__workflow_bodydOCUMENTID, nameof(bodydOCUMENTID), required: false);
            var __workflow_bodyqUESTIONREQUIRED = bodyqUESTIONREQUIRED == null ? null : WorkflowExpression.Compile(bodyqUESTIONREQUIRED);
            WorkflowExpression.Validate(__workflow_bodyqUESTIONREQUIRED, nameof(bodyqUESTIONREQUIRED), required: false);
            var __workflow_bodyiSCONDITIONNAL = bodyiSCONDITIONNAL == null ? null : WorkflowExpression.Compile(bodyiSCONDITIONNAL);
            WorkflowExpression.Validate(__workflow_bodyiSCONDITIONNAL, nameof(bodyiSCONDITIONNAL), required: false);
            var __workflow_bodyrESULTDURATION = bodyrESULTDURATION == null ? null : WorkflowExpression.Compile(bodyrESULTDURATION);
            WorkflowExpression.Validate(__workflow_bodyrESULTDURATION, nameof(bodyrESULTDURATION), required: false);
            var __workflow_bodysYSQUESTIONNAIREID = bodysYSQUESTIONNAIREID == null ? null : WorkflowExpression.Compile(bodysYSQUESTIONNAIREID);
            WorkflowExpression.Validate(__workflow_bodysYSQUESTIONNAIREID, nameof(bodysYSQUESTIONNAIREID), required: false);
            var __workflow_bodyoRIGINTOOLID = bodyoRIGINTOOLID == null ? null : WorkflowExpression.Compile(bodyoRIGINTOOLID);
            WorkflowExpression.Validate(__workflow_bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            var __workflow_bodylASTQUESTIONNAIRE = bodylASTQUESTIONNAIRE == null ? null : WorkflowExpression.Compile(bodylASTQUESTIONNAIRE);
            WorkflowExpression.Validate(__workflow_bodylASTQUESTIONNAIRE, nameof(bodylASTQUESTIONNAIRE), required: false);
            return new DeferredBodyAction<CreateResponseQuestionTicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_questionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrESULT != null)
                {
                    body["RESULT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGEN != null)
                {
                    body["RESULT_STRING_EN"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGEN);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGFR != null)
                {
                    body["RESULT_STRING_FR"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGFR);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGSP != null)
                {
                    body["RESULT_STRING_SP"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGSP);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGGE != null)
                {
                    body["RESULT_STRING_GE"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGGE);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGIT != null)
                {
                    body["RESULT_STRING_IT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGIT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGPO != null)
                {
                    body["RESULT_STRING_PO"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGPO);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTDATE != null)
                {
                    body["RESULT_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTNUMBER != null)
                {
                    body["RESULT_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTBIT != null)
                {
                    body["RESULT_BIT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTBIT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTORDER != null)
                {
                    body["RESULT_ORDER"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTORDER);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL1 != null)
                {
                    body["RESULT_STRING_L1"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL1);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL2 != null)
                {
                    body["RESULT_STRING_L2"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL2);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL3 != null)
                {
                    body["RESULT_STRING_L3"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL3);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL4 != null)
                {
                    body["RESULT_STRING_L4"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL4);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL5 != null)
                {
                    body["RESULT_STRING_L5"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL5);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL6 != null)
                {
                    body["RESULT_STRING_L6"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL6);
                    bodypropCount++;
                }

                if (__workflow_bodyqUESTIONDISPLAYED != null)
                {
                    body["QUESTION_DISPLAYED"] = ExpressionConverter.ConvertO(__workflow_bodyqUESTIONDISPLAYED);
                    bodypropCount++;
                }

                if (__workflow_bodydOCUMENTID != null)
                {
                    body["DOCUMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodydOCUMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodyqUESTIONREQUIRED != null)
                {
                    body["QUESTION_REQUIRED"] = ExpressionConverter.ConvertO(__workflow_bodyqUESTIONREQUIRED);
                    bodypropCount++;
                }

                if (__workflow_bodyiSCONDITIONNAL != null)
                {
                    body["IS_CONDITIONNAL"] = ExpressionConverter.ConvertO(__workflow_bodyiSCONDITIONNAL);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTDURATION != null)
                {
                    body["RESULT_DURATION"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTDURATION);
                    bodypropCount++;
                }

                if (__workflow_bodysYSQUESTIONNAIREID != null)
                {
                    body["SYS_QUESTIONNAIRE_ID"] = ExpressionConverter.ConvertO(__workflow_bodysYSQUESTIONNAIREID);
                    bodypropCount++;
                }

                if (__workflow_bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(__workflow_bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (__workflow_bodylASTQUESTIONNAIRE != null)
                {
                    body["LAST_QUESTIONNAIRE"] = ExpressionConverter.ConvertO(__workflow_bodylASTQUESTIONNAIRE);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateResponseQuestionTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateResponseQuestionTicketResponse> UpdateResponseQuestionTicket(Expression<Func<string>> account, Expression<Func<string>> requestId, Expression<Func<string>> questionId, Expression<Func<string>> bodyrESULT = null, Expression<Func<string>> bodyrESULTSTRINGEN = null, Expression<Func<string>> bodyrESULTSTRINGFR = null, Expression<Func<string>> bodyrESULTSTRINGSP = null, Expression<Func<string>> bodyrESULTSTRINGGE = null, Expression<Func<string>> bodyrESULTSTRINGIT = null, Expression<Func<string>> bodyrESULTSTRINGPO = null, Expression<Func<string>> bodyrESULTDATE = null, Expression<Func<string>> bodyrESULTNUMBER = null, Expression<Func<string>> bodyrESULTBIT = null, Expression<Func<string>> bodyrESULTORDER = null, Expression<Func<string>> bodyrESULTSTRINGL1 = null, Expression<Func<string>> bodyrESULTSTRINGL2 = null, Expression<Func<string>> bodyrESULTSTRINGL3 = null, Expression<Func<string>> bodyrESULTSTRINGL4 = null, Expression<Func<string>> bodyrESULTSTRINGL5 = null, Expression<Func<string>> bodyrESULTSTRINGL6 = null, Expression<Func<string>> bodyqUESTIONDISPLAYED = null, Expression<Func<string>> bodydOCUMENTID = null, Expression<Func<string>> bodyqUESTIONREQUIRED = null, Expression<Func<string>> bodyiSCONDITIONNAL = null, Expression<Func<string>> bodyrESULTDURATION = null, Expression<Func<string>> bodysYSQUESTIONNAIREID = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTQUESTIONNAIRE = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            var __workflow_questionId = questionId == null ? null : WorkflowExpression.Compile(questionId);
            WorkflowExpression.Validate(__workflow_questionId, nameof(questionId), required: true);
            var __workflow_bodyrESULT = bodyrESULT == null ? null : WorkflowExpression.Compile(bodyrESULT);
            WorkflowExpression.Validate(__workflow_bodyrESULT, nameof(bodyrESULT), required: false);
            var __workflow_bodyrESULTSTRINGEN = bodyrESULTSTRINGEN == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGEN);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGEN, nameof(bodyrESULTSTRINGEN), required: false);
            var __workflow_bodyrESULTSTRINGFR = bodyrESULTSTRINGFR == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGFR);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGFR, nameof(bodyrESULTSTRINGFR), required: false);
            var __workflow_bodyrESULTSTRINGSP = bodyrESULTSTRINGSP == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGSP);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGSP, nameof(bodyrESULTSTRINGSP), required: false);
            var __workflow_bodyrESULTSTRINGGE = bodyrESULTSTRINGGE == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGGE);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGGE, nameof(bodyrESULTSTRINGGE), required: false);
            var __workflow_bodyrESULTSTRINGIT = bodyrESULTSTRINGIT == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGIT);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGIT, nameof(bodyrESULTSTRINGIT), required: false);
            var __workflow_bodyrESULTSTRINGPO = bodyrESULTSTRINGPO == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGPO);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGPO, nameof(bodyrESULTSTRINGPO), required: false);
            var __workflow_bodyrESULTDATE = bodyrESULTDATE == null ? null : WorkflowExpression.Compile(bodyrESULTDATE);
            WorkflowExpression.Validate(__workflow_bodyrESULTDATE, nameof(bodyrESULTDATE), required: false);
            var __workflow_bodyrESULTNUMBER = bodyrESULTNUMBER == null ? null : WorkflowExpression.Compile(bodyrESULTNUMBER);
            WorkflowExpression.Validate(__workflow_bodyrESULTNUMBER, nameof(bodyrESULTNUMBER), required: false);
            var __workflow_bodyrESULTBIT = bodyrESULTBIT == null ? null : WorkflowExpression.Compile(bodyrESULTBIT);
            WorkflowExpression.Validate(__workflow_bodyrESULTBIT, nameof(bodyrESULTBIT), required: false);
            var __workflow_bodyrESULTORDER = bodyrESULTORDER == null ? null : WorkflowExpression.Compile(bodyrESULTORDER);
            WorkflowExpression.Validate(__workflow_bodyrESULTORDER, nameof(bodyrESULTORDER), required: false);
            var __workflow_bodyrESULTSTRINGL1 = bodyrESULTSTRINGL1 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL1);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL1, nameof(bodyrESULTSTRINGL1), required: false);
            var __workflow_bodyrESULTSTRINGL2 = bodyrESULTSTRINGL2 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL2);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL2, nameof(bodyrESULTSTRINGL2), required: false);
            var __workflow_bodyrESULTSTRINGL3 = bodyrESULTSTRINGL3 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL3);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL3, nameof(bodyrESULTSTRINGL3), required: false);
            var __workflow_bodyrESULTSTRINGL4 = bodyrESULTSTRINGL4 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL4);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL4, nameof(bodyrESULTSTRINGL4), required: false);
            var __workflow_bodyrESULTSTRINGL5 = bodyrESULTSTRINGL5 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL5);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL5, nameof(bodyrESULTSTRINGL5), required: false);
            var __workflow_bodyrESULTSTRINGL6 = bodyrESULTSTRINGL6 == null ? null : WorkflowExpression.Compile(bodyrESULTSTRINGL6);
            WorkflowExpression.Validate(__workflow_bodyrESULTSTRINGL6, nameof(bodyrESULTSTRINGL6), required: false);
            var __workflow_bodyqUESTIONDISPLAYED = bodyqUESTIONDISPLAYED == null ? null : WorkflowExpression.Compile(bodyqUESTIONDISPLAYED);
            WorkflowExpression.Validate(__workflow_bodyqUESTIONDISPLAYED, nameof(bodyqUESTIONDISPLAYED), required: false);
            var __workflow_bodydOCUMENTID = bodydOCUMENTID == null ? null : WorkflowExpression.Compile(bodydOCUMENTID);
            WorkflowExpression.Validate(__workflow_bodydOCUMENTID, nameof(bodydOCUMENTID), required: false);
            var __workflow_bodyqUESTIONREQUIRED = bodyqUESTIONREQUIRED == null ? null : WorkflowExpression.Compile(bodyqUESTIONREQUIRED);
            WorkflowExpression.Validate(__workflow_bodyqUESTIONREQUIRED, nameof(bodyqUESTIONREQUIRED), required: false);
            var __workflow_bodyiSCONDITIONNAL = bodyiSCONDITIONNAL == null ? null : WorkflowExpression.Compile(bodyiSCONDITIONNAL);
            WorkflowExpression.Validate(__workflow_bodyiSCONDITIONNAL, nameof(bodyiSCONDITIONNAL), required: false);
            var __workflow_bodyrESULTDURATION = bodyrESULTDURATION == null ? null : WorkflowExpression.Compile(bodyrESULTDURATION);
            WorkflowExpression.Validate(__workflow_bodyrESULTDURATION, nameof(bodyrESULTDURATION), required: false);
            var __workflow_bodysYSQUESTIONNAIREID = bodysYSQUESTIONNAIREID == null ? null : WorkflowExpression.Compile(bodysYSQUESTIONNAIREID);
            WorkflowExpression.Validate(__workflow_bodysYSQUESTIONNAIREID, nameof(bodysYSQUESTIONNAIREID), required: false);
            var __workflow_bodyoRIGINTOOLID = bodyoRIGINTOOLID == null ? null : WorkflowExpression.Compile(bodyoRIGINTOOLID);
            WorkflowExpression.Validate(__workflow_bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            var __workflow_bodylASTQUESTIONNAIRE = bodylASTQUESTIONNAIRE == null ? null : WorkflowExpression.Compile(bodylASTQUESTIONNAIRE);
            WorkflowExpression.Validate(__workflow_bodylASTQUESTIONNAIRE, nameof(bodylASTQUESTIONNAIRE), required: false);
            return new DeferredBodyAction<UpdateResponseQuestionTicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_questionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrESULT != null)
                {
                    body["RESULT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGEN != null)
                {
                    body["RESULT_STRING_EN"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGEN);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGFR != null)
                {
                    body["RESULT_STRING_FR"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGFR);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGSP != null)
                {
                    body["RESULT_STRING_SP"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGSP);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGGE != null)
                {
                    body["RESULT_STRING_GE"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGGE);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGIT != null)
                {
                    body["RESULT_STRING_IT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGIT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGPO != null)
                {
                    body["RESULT_STRING_PO"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGPO);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTDATE != null)
                {
                    body["RESULT_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTNUMBER != null)
                {
                    body["RESULT_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTBIT != null)
                {
                    body["RESULT_BIT"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTBIT);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTORDER != null)
                {
                    body["RESULT_ORDER"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTORDER);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL1 != null)
                {
                    body["RESULT_STRING_L1"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL1);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL2 != null)
                {
                    body["RESULT_STRING_L2"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL2);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL3 != null)
                {
                    body["RESULT_STRING_L3"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL3);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL4 != null)
                {
                    body["RESULT_STRING_L4"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL4);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL5 != null)
                {
                    body["RESULT_STRING_L5"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL5);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTSTRINGL6 != null)
                {
                    body["RESULT_STRING_L6"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTSTRINGL6);
                    bodypropCount++;
                }

                if (__workflow_bodyqUESTIONDISPLAYED != null)
                {
                    body["QUESTION_DISPLAYED"] = ExpressionConverter.ConvertO(__workflow_bodyqUESTIONDISPLAYED);
                    bodypropCount++;
                }

                if (__workflow_bodydOCUMENTID != null)
                {
                    body["DOCUMENT_ID"] = ExpressionConverter.ConvertO(__workflow_bodydOCUMENTID);
                    bodypropCount++;
                }

                if (__workflow_bodyqUESTIONREQUIRED != null)
                {
                    body["QUESTION_REQUIRED"] = ExpressionConverter.ConvertO(__workflow_bodyqUESTIONREQUIRED);
                    bodypropCount++;
                }

                if (__workflow_bodyiSCONDITIONNAL != null)
                {
                    body["IS_CONDITIONNAL"] = ExpressionConverter.ConvertO(__workflow_bodyiSCONDITIONNAL);
                    bodypropCount++;
                }

                if (__workflow_bodyrESULTDURATION != null)
                {
                    body["RESULT_DURATION"] = ExpressionConverter.ConvertO(__workflow_bodyrESULTDURATION);
                    bodypropCount++;
                }

                if (__workflow_bodysYSQUESTIONNAIREID != null)
                {
                    body["SYS_QUESTIONNAIRE_ID"] = ExpressionConverter.ConvertO(__workflow_bodysYSQUESTIONNAIREID);
                    bodypropCount++;
                }

                if (__workflow_bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(__workflow_bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (__workflow_bodylASTQUESTIONNAIRE != null)
                {
                    body["LAST_QUESTIONNAIRE"] = ExpressionConverter.ConvertO(__workflow_bodylASTQUESTIONNAIRE);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateResponseQuestionTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionnairesResponse> ViewListQuestionnaires(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListQuestionnairesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListQuestionnairesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewQuestionnaireResponse> ViewQuestionnaire(Expression<Func<string>> account, Expression<Func<string>> questionnaireId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_questionnaireId = questionnaireId == null ? null : WorkflowExpression.Compile(questionnaireId);
            WorkflowExpression.Validate(__workflow_questionnaireId, nameof(questionnaireId), required: true);
            return new DeferredBodyAction<ViewQuestionnaireResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_questionnaireId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewQuestionnaireResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsResponse> ViewListProblems(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListProblemsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListProblemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewProblemResponse> ViewProblem(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewProblemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewProblemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListNewsResponse> ViewListNews(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListNewsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListNewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateNewsResponse> CreateNews(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<CreateNewsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateNewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewNewsResponse> ViewNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<ViewNewsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewNewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateNewsResponse> UpdateNews(Expression<Func<string>> account, Expression<Func<string>> documentId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<UpdateNewsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UpdateNewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListActionsResponse> ViewListActions(Expression<Func<string>> account)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            return new DeferredBodyAction<ViewListActionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewListActionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateActionTicketResponse> CreateActionTicket(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyaCTIONNUMBER = null, Expression<Func<string>> bodyaSSETID = null, Expression<Func<string>> bodypARENTACTIONID = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodydONEBYID = null, Expression<Func<string>> bodyvALIDATORID = null, Expression<Func<string>> bodyaCTIONLABELEN = null, Expression<Func<string>> bodytABLENAME = null, Expression<Func<string>> bodyfIELDNAME = null, Expression<Func<string>> bodyoLDVALUE = null, Expression<Func<string>> bodynEWVALUE = null, Expression<Func<string>> bodydELETEACTION = null, Expression<Func<string>> bodyaUTOMATICACTION = null, Expression<Func<string>> bodypROCESSSTEPID = null, Expression<Func<string>> bodyrEQUESTID = null, Expression<Func<string>> bodydESCRIPTION = null, Expression<Func<string>> bodynETCHARGE = null, Expression<Func<string>> bodynETCHARGECURID = null, Expression<Func<string>> bodyrESOLUTION = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodysUPPORTSTAFFID = null, Expression<Func<string>> bodycONTACTID = null, Expression<Func<string>> bodyeXPECTEDENDDATEUT = null, Expression<Func<string>> bodycOMMENT = null, Expression<Func<string>> bodysTARTDATEUT = null, Expression<Func<string>> bodyeNDDATEUT = null, Expression<Func<string>> bodyrENEWALDATEUT = null, Expression<Func<string>> bodyeXPECTEDSTARTDATEUT = null, Expression<Func<string>> bodycREATIONDATEUT = null, Expression<Func<string>> bodyaPPLICATIONDATEUT = null, Expression<Func<string>> bodywIZARDGUID = null, Expression<Func<string>> bodygROUPID = null, Expression<Func<string>> bodyaCTIONLABELFR = null, Expression<Func<string>> bodyaCTIONLABELSP = null, Expression<Func<string>> bodyaCTIONLABELGE = null, Expression<Func<string>> bodyaCTIONLABELIT = null, Expression<Func<string>> bodyaCTIONLABELPO = null, Expression<Func<string>> bodykNOWNPROBLEMID = null, Expression<Func<string>> bodymAXINTERVENTIONDATEUT = null, Expression<Func<string>> bodyeLAPSEDTIME = null, Expression<Func<string>> bodypRIORITYID = null, Expression<Func<string>> bodytAXID = null, Expression<Func<string>> bodysTATUSIDONCREATE = null, Expression<Func<string>> bodysTATUSIDONTERMINATE = null, Expression<Func<string>> bodyaCTIONTYPEID = null, Expression<Func<string>> bodydELAY = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodytIMEUSEDTOCOMPLETEACTION = null, Expression<Func<string>> bodycONTRACTUALCOST = null, Expression<Func<string>> bodycONTRACTUALCOSTCURID = null, Expression<Func<string>> bodytIMECOST = null, Expression<Func<string>> bodytIMECOSTCURID = null, Expression<Func<string>> bodyoRIGINACTIONID = null, Expression<Func<string>> bodywORKFLOWVALUE = null, Expression<Func<string>> bodycONTINUITYPLANID = null, Expression<Func<string>> bodycATEGORYTESTID = null, Expression<Func<string>> bodywORKFLOWID = null, Expression<Func<string>> bodyeXITVALUE = null, Expression<Func<string>> bodymAXRESOLUTIONDATEUT = null, Expression<Func<string>> bodypERCENTCOMPLETE = null, Expression<Func<string>> bodyeXPECTEDDURATION = null, Expression<Func<string>> bodywBSTASK = null, Expression<Func<string>> bodytASKPERSONCOSTPERHOUR = null, Expression<Func<string>> bodytASKPLANNEDBUDGET = null, Expression<Func<string>> bodyeSTIMATEDNETCHARGE = null, Expression<Func<string>> bodypREVIOUSSIBLINGID = null, Expression<Func<string>> bodyaCTIONLABELL1 = null, Expression<Func<string>> bodyaCTIONLABELL2 = null, Expression<Func<string>> bodyaCTIONLABELL3 = null, Expression<Func<string>> bodyaCTIONLABELL4 = null, Expression<Func<string>> bodyaCTIONLABELL5 = null, Expression<Func<string>> bodyaCTIONLABELL6 = null, Expression<Func<string>> bodyhISTORYID = null, Expression<Func<string>> bodytOTRUNC = null, Expression<Func<string>> bodysTAGEID = null, Expression<Func<string>> bodyiSLOCKEDPROGRESSPOINT = null, Expression<Func<string>> bodyoRIGINTOOLID = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodyeLASTDATESUPDATE = null, Expression<Func<string>> bodybILLEDTIME = null, Expression<Func<string>> bodyiSBILLINGREVIEWED = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyaCTIONNUMBER = bodyaCTIONNUMBER == null ? null : WorkflowExpression.Compile(bodyaCTIONNUMBER);
            WorkflowExpression.Validate(__workflow_bodyaCTIONNUMBER, nameof(bodyaCTIONNUMBER), required: false);
            var __workflow_bodyaSSETID = bodyaSSETID == null ? null : WorkflowExpression.Compile(bodyaSSETID);
            WorkflowExpression.Validate(__workflow_bodyaSSETID, nameof(bodyaSSETID), required: false);
            var __workflow_bodypARENTACTIONID = bodypARENTACTIONID == null ? null : WorkflowExpression.Compile(bodypARENTACTIONID);
            WorkflowExpression.Validate(__workflow_bodypARENTACTIONID, nameof(bodypARENTACTIONID), required: false);
            var __workflow_bodysUPPLIERID = bodysUPPLIERID == null ? null : WorkflowExpression.Compile(bodysUPPLIERID);
            WorkflowExpression.Validate(__workflow_bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            var __workflow_bodydONEBYID = bodydONEBYID == null ? null : WorkflowExpression.Compile(bodydONEBYID);
            WorkflowExpression.Validate(__workflow_bodydONEBYID, nameof(bodydONEBYID), required: false);
            var __workflow_bodyvALIDATORID = bodyvALIDATORID == null ? null : WorkflowExpression.Compile(bodyvALIDATORID);
            WorkflowExpression.Validate(__workflow_bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            var __workflow_bodyaCTIONLABELEN = bodyaCTIONLABELEN == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELEN);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELEN, nameof(bodyaCTIONLABELEN), required: false);
            var __workflow_bodytABLENAME = bodytABLENAME == null ? null : WorkflowExpression.Compile(bodytABLENAME);
            WorkflowExpression.Validate(__workflow_bodytABLENAME, nameof(bodytABLENAME), required: false);
            var __workflow_bodyfIELDNAME = bodyfIELDNAME == null ? null : WorkflowExpression.Compile(bodyfIELDNAME);
            WorkflowExpression.Validate(__workflow_bodyfIELDNAME, nameof(bodyfIELDNAME), required: false);
            var __workflow_bodyoLDVALUE = bodyoLDVALUE == null ? null : WorkflowExpression.Compile(bodyoLDVALUE);
            WorkflowExpression.Validate(__workflow_bodyoLDVALUE, nameof(bodyoLDVALUE), required: false);
            var __workflow_bodynEWVALUE = bodynEWVALUE == null ? null : WorkflowExpression.Compile(bodynEWVALUE);
            WorkflowExpression.Validate(__workflow_bodynEWVALUE, nameof(bodynEWVALUE), required: false);
            var __workflow_bodydELETEACTION = bodydELETEACTION == null ? null : WorkflowExpression.Compile(bodydELETEACTION);
            WorkflowExpression.Validate(__workflow_bodydELETEACTION, nameof(bodydELETEACTION), required: false);
            var __workflow_bodyaUTOMATICACTION = bodyaUTOMATICACTION == null ? null : WorkflowExpression.Compile(bodyaUTOMATICACTION);
            WorkflowExpression.Validate(__workflow_bodyaUTOMATICACTION, nameof(bodyaUTOMATICACTION), required: false);
            var __workflow_bodypROCESSSTEPID = bodypROCESSSTEPID == null ? null : WorkflowExpression.Compile(bodypROCESSSTEPID);
            WorkflowExpression.Validate(__workflow_bodypROCESSSTEPID, nameof(bodypROCESSSTEPID), required: false);
            var __workflow_bodyrEQUESTID = bodyrEQUESTID == null ? null : WorkflowExpression.Compile(bodyrEQUESTID);
            WorkflowExpression.Validate(__workflow_bodyrEQUESTID, nameof(bodyrEQUESTID), required: false);
            var __workflow_bodydESCRIPTION = bodydESCRIPTION == null ? null : WorkflowExpression.Compile(bodydESCRIPTION);
            WorkflowExpression.Validate(__workflow_bodydESCRIPTION, nameof(bodydESCRIPTION), required: false);
            var __workflow_bodynETCHARGE = bodynETCHARGE == null ? null : WorkflowExpression.Compile(bodynETCHARGE);
            WorkflowExpression.Validate(__workflow_bodynETCHARGE, nameof(bodynETCHARGE), required: false);
            var __workflow_bodynETCHARGECURID = bodynETCHARGECURID == null ? null : WorkflowExpression.Compile(bodynETCHARGECURID);
            WorkflowExpression.Validate(__workflow_bodynETCHARGECURID, nameof(bodynETCHARGECURID), required: false);
            var __workflow_bodyrESOLUTION = bodyrESOLUTION == null ? null : WorkflowExpression.Compile(bodyrESOLUTION);
            WorkflowExpression.Validate(__workflow_bodyrESOLUTION, nameof(bodyrESOLUTION), required: false);
            var __workflow_bodylOCATIONID = bodylOCATIONID == null ? null : WorkflowExpression.Compile(bodylOCATIONID);
            WorkflowExpression.Validate(__workflow_bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            var __workflow_bodysUPPORTSTAFFID = bodysUPPORTSTAFFID == null ? null : WorkflowExpression.Compile(bodysUPPORTSTAFFID);
            WorkflowExpression.Validate(__workflow_bodysUPPORTSTAFFID, nameof(bodysUPPORTSTAFFID), required: false);
            var __workflow_bodycONTACTID = bodycONTACTID == null ? null : WorkflowExpression.Compile(bodycONTACTID);
            WorkflowExpression.Validate(__workflow_bodycONTACTID, nameof(bodycONTACTID), required: false);
            var __workflow_bodyeXPECTEDENDDATEUT = bodyeXPECTEDENDDATEUT == null ? null : WorkflowExpression.Compile(bodyeXPECTEDENDDATEUT);
            WorkflowExpression.Validate(__workflow_bodyeXPECTEDENDDATEUT, nameof(bodyeXPECTEDENDDATEUT), required: false);
            var __workflow_bodycOMMENT = bodycOMMENT == null ? null : WorkflowExpression.Compile(bodycOMMENT);
            WorkflowExpression.Validate(__workflow_bodycOMMENT, nameof(bodycOMMENT), required: false);
            var __workflow_bodysTARTDATEUT = bodysTARTDATEUT == null ? null : WorkflowExpression.Compile(bodysTARTDATEUT);
            WorkflowExpression.Validate(__workflow_bodysTARTDATEUT, nameof(bodysTARTDATEUT), required: false);
            var __workflow_bodyeNDDATEUT = bodyeNDDATEUT == null ? null : WorkflowExpression.Compile(bodyeNDDATEUT);
            WorkflowExpression.Validate(__workflow_bodyeNDDATEUT, nameof(bodyeNDDATEUT), required: false);
            var __workflow_bodyrENEWALDATEUT = bodyrENEWALDATEUT == null ? null : WorkflowExpression.Compile(bodyrENEWALDATEUT);
            WorkflowExpression.Validate(__workflow_bodyrENEWALDATEUT, nameof(bodyrENEWALDATEUT), required: false);
            var __workflow_bodyeXPECTEDSTARTDATEUT = bodyeXPECTEDSTARTDATEUT == null ? null : WorkflowExpression.Compile(bodyeXPECTEDSTARTDATEUT);
            WorkflowExpression.Validate(__workflow_bodyeXPECTEDSTARTDATEUT, nameof(bodyeXPECTEDSTARTDATEUT), required: false);
            var __workflow_bodycREATIONDATEUT = bodycREATIONDATEUT == null ? null : WorkflowExpression.Compile(bodycREATIONDATEUT);
            WorkflowExpression.Validate(__workflow_bodycREATIONDATEUT, nameof(bodycREATIONDATEUT), required: false);
            var __workflow_bodyaPPLICATIONDATEUT = bodyaPPLICATIONDATEUT == null ? null : WorkflowExpression.Compile(bodyaPPLICATIONDATEUT);
            WorkflowExpression.Validate(__workflow_bodyaPPLICATIONDATEUT, nameof(bodyaPPLICATIONDATEUT), required: false);
            var __workflow_bodywIZARDGUID = bodywIZARDGUID == null ? null : WorkflowExpression.Compile(bodywIZARDGUID);
            WorkflowExpression.Validate(__workflow_bodywIZARDGUID, nameof(bodywIZARDGUID), required: false);
            var __workflow_bodygROUPID = bodygROUPID == null ? null : WorkflowExpression.Compile(bodygROUPID);
            WorkflowExpression.Validate(__workflow_bodygROUPID, nameof(bodygROUPID), required: false);
            var __workflow_bodyaCTIONLABELFR = bodyaCTIONLABELFR == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELFR);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELFR, nameof(bodyaCTIONLABELFR), required: false);
            var __workflow_bodyaCTIONLABELSP = bodyaCTIONLABELSP == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELSP);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELSP, nameof(bodyaCTIONLABELSP), required: false);
            var __workflow_bodyaCTIONLABELGE = bodyaCTIONLABELGE == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELGE);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELGE, nameof(bodyaCTIONLABELGE), required: false);
            var __workflow_bodyaCTIONLABELIT = bodyaCTIONLABELIT == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELIT);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELIT, nameof(bodyaCTIONLABELIT), required: false);
            var __workflow_bodyaCTIONLABELPO = bodyaCTIONLABELPO == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELPO);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELPO, nameof(bodyaCTIONLABELPO), required: false);
            var __workflow_bodykNOWNPROBLEMID = bodykNOWNPROBLEMID == null ? null : WorkflowExpression.Compile(bodykNOWNPROBLEMID);
            WorkflowExpression.Validate(__workflow_bodykNOWNPROBLEMID, nameof(bodykNOWNPROBLEMID), required: false);
            var __workflow_bodymAXINTERVENTIONDATEUT = bodymAXINTERVENTIONDATEUT == null ? null : WorkflowExpression.Compile(bodymAXINTERVENTIONDATEUT);
            WorkflowExpression.Validate(__workflow_bodymAXINTERVENTIONDATEUT, nameof(bodymAXINTERVENTIONDATEUT), required: false);
            var __workflow_bodyeLAPSEDTIME = bodyeLAPSEDTIME == null ? null : WorkflowExpression.Compile(bodyeLAPSEDTIME);
            WorkflowExpression.Validate(__workflow_bodyeLAPSEDTIME, nameof(bodyeLAPSEDTIME), required: false);
            var __workflow_bodypRIORITYID = bodypRIORITYID == null ? null : WorkflowExpression.Compile(bodypRIORITYID);
            WorkflowExpression.Validate(__workflow_bodypRIORITYID, nameof(bodypRIORITYID), required: false);
            var __workflow_bodytAXID = bodytAXID == null ? null : WorkflowExpression.Compile(bodytAXID);
            WorkflowExpression.Validate(__workflow_bodytAXID, nameof(bodytAXID), required: false);
            var __workflow_bodysTATUSIDONCREATE = bodysTATUSIDONCREATE == null ? null : WorkflowExpression.Compile(bodysTATUSIDONCREATE);
            WorkflowExpression.Validate(__workflow_bodysTATUSIDONCREATE, nameof(bodysTATUSIDONCREATE), required: false);
            var __workflow_bodysTATUSIDONTERMINATE = bodysTATUSIDONTERMINATE == null ? null : WorkflowExpression.Compile(bodysTATUSIDONTERMINATE);
            WorkflowExpression.Validate(__workflow_bodysTATUSIDONTERMINATE, nameof(bodysTATUSIDONTERMINATE), required: false);
            var __workflow_bodyaCTIONTYPEID = bodyaCTIONTYPEID == null ? null : WorkflowExpression.Compile(bodyaCTIONTYPEID);
            WorkflowExpression.Validate(__workflow_bodyaCTIONTYPEID, nameof(bodyaCTIONTYPEID), required: false);
            var __workflow_bodydELAY = bodydELAY == null ? null : WorkflowExpression.Compile(bodydELAY);
            WorkflowExpression.Validate(__workflow_bodydELAY, nameof(bodydELAY), required: false);
            var __workflow_bodyaVAILABLEFIELD1 = bodyaVAILABLEFIELD1 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD1);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            var __workflow_bodyaVAILABLEFIELD2 = bodyaVAILABLEFIELD2 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD2);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            var __workflow_bodyaVAILABLEFIELD3 = bodyaVAILABLEFIELD3 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD3);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            var __workflow_bodyaVAILABLEFIELD4 = bodyaVAILABLEFIELD4 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD4);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            var __workflow_bodyaVAILABLEFIELD5 = bodyaVAILABLEFIELD5 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD5);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            var __workflow_bodyaVAILABLEFIELD6 = bodyaVAILABLEFIELD6 == null ? null : WorkflowExpression.Compile(bodyaVAILABLEFIELD6);
            WorkflowExpression.Validate(__workflow_bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            var __workflow_bodytIMEUSEDTOCOMPLETEACTION = bodytIMEUSEDTOCOMPLETEACTION == null ? null : WorkflowExpression.Compile(bodytIMEUSEDTOCOMPLETEACTION);
            WorkflowExpression.Validate(__workflow_bodytIMEUSEDTOCOMPLETEACTION, nameof(bodytIMEUSEDTOCOMPLETEACTION), required: false);
            var __workflow_bodycONTRACTUALCOST = bodycONTRACTUALCOST == null ? null : WorkflowExpression.Compile(bodycONTRACTUALCOST);
            WorkflowExpression.Validate(__workflow_bodycONTRACTUALCOST, nameof(bodycONTRACTUALCOST), required: false);
            var __workflow_bodycONTRACTUALCOSTCURID = bodycONTRACTUALCOSTCURID == null ? null : WorkflowExpression.Compile(bodycONTRACTUALCOSTCURID);
            WorkflowExpression.Validate(__workflow_bodycONTRACTUALCOSTCURID, nameof(bodycONTRACTUALCOSTCURID), required: false);
            var __workflow_bodytIMECOST = bodytIMECOST == null ? null : WorkflowExpression.Compile(bodytIMECOST);
            WorkflowExpression.Validate(__workflow_bodytIMECOST, nameof(bodytIMECOST), required: false);
            var __workflow_bodytIMECOSTCURID = bodytIMECOSTCURID == null ? null : WorkflowExpression.Compile(bodytIMECOSTCURID);
            WorkflowExpression.Validate(__workflow_bodytIMECOSTCURID, nameof(bodytIMECOSTCURID), required: false);
            var __workflow_bodyoRIGINACTIONID = bodyoRIGINACTIONID == null ? null : WorkflowExpression.Compile(bodyoRIGINACTIONID);
            WorkflowExpression.Validate(__workflow_bodyoRIGINACTIONID, nameof(bodyoRIGINACTIONID), required: false);
            var __workflow_bodywORKFLOWVALUE = bodywORKFLOWVALUE == null ? null : WorkflowExpression.Compile(bodywORKFLOWVALUE);
            WorkflowExpression.Validate(__workflow_bodywORKFLOWVALUE, nameof(bodywORKFLOWVALUE), required: false);
            var __workflow_bodycONTINUITYPLANID = bodycONTINUITYPLANID == null ? null : WorkflowExpression.Compile(bodycONTINUITYPLANID);
            WorkflowExpression.Validate(__workflow_bodycONTINUITYPLANID, nameof(bodycONTINUITYPLANID), required: false);
            var __workflow_bodycATEGORYTESTID = bodycATEGORYTESTID == null ? null : WorkflowExpression.Compile(bodycATEGORYTESTID);
            WorkflowExpression.Validate(__workflow_bodycATEGORYTESTID, nameof(bodycATEGORYTESTID), required: false);
            var __workflow_bodywORKFLOWID = bodywORKFLOWID == null ? null : WorkflowExpression.Compile(bodywORKFLOWID);
            WorkflowExpression.Validate(__workflow_bodywORKFLOWID, nameof(bodywORKFLOWID), required: false);
            var __workflow_bodyeXITVALUE = bodyeXITVALUE == null ? null : WorkflowExpression.Compile(bodyeXITVALUE);
            WorkflowExpression.Validate(__workflow_bodyeXITVALUE, nameof(bodyeXITVALUE), required: false);
            var __workflow_bodymAXRESOLUTIONDATEUT = bodymAXRESOLUTIONDATEUT == null ? null : WorkflowExpression.Compile(bodymAXRESOLUTIONDATEUT);
            WorkflowExpression.Validate(__workflow_bodymAXRESOLUTIONDATEUT, nameof(bodymAXRESOLUTIONDATEUT), required: false);
            var __workflow_bodypERCENTCOMPLETE = bodypERCENTCOMPLETE == null ? null : WorkflowExpression.Compile(bodypERCENTCOMPLETE);
            WorkflowExpression.Validate(__workflow_bodypERCENTCOMPLETE, nameof(bodypERCENTCOMPLETE), required: false);
            var __workflow_bodyeXPECTEDDURATION = bodyeXPECTEDDURATION == null ? null : WorkflowExpression.Compile(bodyeXPECTEDDURATION);
            WorkflowExpression.Validate(__workflow_bodyeXPECTEDDURATION, nameof(bodyeXPECTEDDURATION), required: false);
            var __workflow_bodywBSTASK = bodywBSTASK == null ? null : WorkflowExpression.Compile(bodywBSTASK);
            WorkflowExpression.Validate(__workflow_bodywBSTASK, nameof(bodywBSTASK), required: false);
            var __workflow_bodytASKPERSONCOSTPERHOUR = bodytASKPERSONCOSTPERHOUR == null ? null : WorkflowExpression.Compile(bodytASKPERSONCOSTPERHOUR);
            WorkflowExpression.Validate(__workflow_bodytASKPERSONCOSTPERHOUR, nameof(bodytASKPERSONCOSTPERHOUR), required: false);
            var __workflow_bodytASKPLANNEDBUDGET = bodytASKPLANNEDBUDGET == null ? null : WorkflowExpression.Compile(bodytASKPLANNEDBUDGET);
            WorkflowExpression.Validate(__workflow_bodytASKPLANNEDBUDGET, nameof(bodytASKPLANNEDBUDGET), required: false);
            var __workflow_bodyeSTIMATEDNETCHARGE = bodyeSTIMATEDNETCHARGE == null ? null : WorkflowExpression.Compile(bodyeSTIMATEDNETCHARGE);
            WorkflowExpression.Validate(__workflow_bodyeSTIMATEDNETCHARGE, nameof(bodyeSTIMATEDNETCHARGE), required: false);
            var __workflow_bodypREVIOUSSIBLINGID = bodypREVIOUSSIBLINGID == null ? null : WorkflowExpression.Compile(bodypREVIOUSSIBLINGID);
            WorkflowExpression.Validate(__workflow_bodypREVIOUSSIBLINGID, nameof(bodypREVIOUSSIBLINGID), required: false);
            var __workflow_bodyaCTIONLABELL1 = bodyaCTIONLABELL1 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL1);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL1, nameof(bodyaCTIONLABELL1), required: false);
            var __workflow_bodyaCTIONLABELL2 = bodyaCTIONLABELL2 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL2);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL2, nameof(bodyaCTIONLABELL2), required: false);
            var __workflow_bodyaCTIONLABELL3 = bodyaCTIONLABELL3 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL3);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL3, nameof(bodyaCTIONLABELL3), required: false);
            var __workflow_bodyaCTIONLABELL4 = bodyaCTIONLABELL4 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL4);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL4, nameof(bodyaCTIONLABELL4), required: false);
            var __workflow_bodyaCTIONLABELL5 = bodyaCTIONLABELL5 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL5);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL5, nameof(bodyaCTIONLABELL5), required: false);
            var __workflow_bodyaCTIONLABELL6 = bodyaCTIONLABELL6 == null ? null : WorkflowExpression.Compile(bodyaCTIONLABELL6);
            WorkflowExpression.Validate(__workflow_bodyaCTIONLABELL6, nameof(bodyaCTIONLABELL6), required: false);
            var __workflow_bodyhISTORYID = bodyhISTORYID == null ? null : WorkflowExpression.Compile(bodyhISTORYID);
            WorkflowExpression.Validate(__workflow_bodyhISTORYID, nameof(bodyhISTORYID), required: false);
            var __workflow_bodytOTRUNC = bodytOTRUNC == null ? null : WorkflowExpression.Compile(bodytOTRUNC);
            WorkflowExpression.Validate(__workflow_bodytOTRUNC, nameof(bodytOTRUNC), required: false);
            var __workflow_bodysTAGEID = bodysTAGEID == null ? null : WorkflowExpression.Compile(bodysTAGEID);
            WorkflowExpression.Validate(__workflow_bodysTAGEID, nameof(bodysTAGEID), required: false);
            var __workflow_bodyiSLOCKEDPROGRESSPOINT = bodyiSLOCKEDPROGRESSPOINT == null ? null : WorkflowExpression.Compile(bodyiSLOCKEDPROGRESSPOINT);
            WorkflowExpression.Validate(__workflow_bodyiSLOCKEDPROGRESSPOINT, nameof(bodyiSLOCKEDPROGRESSPOINT), required: false);
            var __workflow_bodyoRIGINTOOLID = bodyoRIGINTOOLID == null ? null : WorkflowExpression.Compile(bodyoRIGINTOOLID);
            WorkflowExpression.Validate(__workflow_bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            var __workflow_bodylASTUPDATE = bodylASTUPDATE == null ? null : WorkflowExpression.Compile(bodylASTUPDATE);
            WorkflowExpression.Validate(__workflow_bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodyeLASTDATESUPDATE = bodyeLASTDATESUPDATE == null ? null : WorkflowExpression.Compile(bodyeLASTDATESUPDATE);
            WorkflowExpression.Validate(__workflow_bodyeLASTDATESUPDATE, nameof(bodyeLASTDATESUPDATE), required: false);
            var __workflow_bodybILLEDTIME = bodybILLEDTIME == null ? null : WorkflowExpression.Compile(bodybILLEDTIME);
            WorkflowExpression.Validate(__workflow_bodybILLEDTIME, nameof(bodybILLEDTIME), required: false);
            var __workflow_bodyiSBILLINGREVIEWED = bodyiSBILLINGREVIEWED == null ? null : WorkflowExpression.Compile(bodyiSBILLINGREVIEWED);
            WorkflowExpression.Validate(__workflow_bodyiSBILLINGREVIEWED, nameof(bodyiSBILLINGREVIEWED), required: false);
            return new DeferredBodyAction<CreateActionTicketResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaCTIONNUMBER != null)
                {
                    body["ACTION_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyaSSETID != null)
                {
                    body["ASSET_ID"] = ExpressionConverter.ConvertO(__workflow_bodyaSSETID);
                    bodypropCount++;
                }

                if (__workflow_bodypARENTACTIONID != null)
                {
                    body["PARENT_ACTION_ID"] = ExpressionConverter.ConvertO(__workflow_bodypARENTACTIONID);
                    bodypropCount++;
                }

                if (__workflow_bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = ExpressionConverter.ConvertO(__workflow_bodysUPPLIERID);
                    bodypropCount++;
                }

                if (__workflow_bodydONEBYID != null)
                {
                    body["DONE_BY_ID"] = ExpressionConverter.ConvertO(__workflow_bodydONEBYID);
                    bodypropCount++;
                }

                if (__workflow_bodyvALIDATORID != null)
                {
                    body["VALIDATOR_ID"] = ExpressionConverter.ConvertO(__workflow_bodyvALIDATORID);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELEN != null)
                {
                    body["ACTION_LABEL_EN"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELEN);
                    bodypropCount++;
                }

                if (__workflow_bodytABLENAME != null)
                {
                    body["TABLE_NAME"] = ExpressionConverter.ConvertO(__workflow_bodytABLENAME);
                    bodypropCount++;
                }

                if (__workflow_bodyfIELDNAME != null)
                {
                    body["FIELD_NAME"] = ExpressionConverter.ConvertO(__workflow_bodyfIELDNAME);
                    bodypropCount++;
                }

                if (__workflow_bodyoLDVALUE != null)
                {
                    body["OLD_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodyoLDVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodynEWVALUE != null)
                {
                    body["NEW_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodynEWVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodydELETEACTION != null)
                {
                    body["DELETE_ACTION"] = ExpressionConverter.ConvertO(__workflow_bodydELETEACTION);
                    bodypropCount++;
                }

                if (__workflow_bodyaUTOMATICACTION != null)
                {
                    body["AUTOMATIC_ACTION"] = ExpressionConverter.ConvertO(__workflow_bodyaUTOMATICACTION);
                    bodypropCount++;
                }

                if (__workflow_bodypROCESSSTEPID != null)
                {
                    body["PROCESS_STEP_ID"] = ExpressionConverter.ConvertO(__workflow_bodypROCESSSTEPID);
                    bodypropCount++;
                }

                if (__workflow_bodyrEQUESTID != null)
                {
                    body["REQUEST_ID"] = ExpressionConverter.ConvertO(__workflow_bodyrEQUESTID);
                    bodypropCount++;
                }

                if (__workflow_bodydESCRIPTION != null)
                {
                    body["DESCRIPTION"] = ExpressionConverter.ConvertO(__workflow_bodydESCRIPTION);
                    bodypropCount++;
                }

                if (__workflow_bodynETCHARGE != null)
                {
                    body["NET_CHARGE"] = ExpressionConverter.ConvertO(__workflow_bodynETCHARGE);
                    bodypropCount++;
                }

                if (__workflow_bodynETCHARGECURID != null)
                {
                    body["NET_CHARGE_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodynETCHARGECURID);
                    bodypropCount++;
                }

                if (__workflow_bodyrESOLUTION != null)
                {
                    body["RESOLUTION"] = ExpressionConverter.ConvertO(__workflow_bodyrESOLUTION);
                    bodypropCount++;
                }

                if (__workflow_bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = ExpressionConverter.ConvertO(__workflow_bodylOCATIONID);
                    bodypropCount++;
                }

                if (__workflow_bodysUPPORTSTAFFID != null)
                {
                    body["SUPPORT_STAFF_ID"] = ExpressionConverter.ConvertO(__workflow_bodysUPPORTSTAFFID);
                    bodypropCount++;
                }

                if (__workflow_bodycONTACTID != null)
                {
                    body["CONTACT_ID"] = ExpressionConverter.ConvertO(__workflow_bodycONTACTID);
                    bodypropCount++;
                }

                if (__workflow_bodyeXPECTEDENDDATEUT != null)
                {
                    body["EXPECTED_END_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodyeXPECTEDENDDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodycOMMENT != null)
                {
                    body["COMMENT"] = ExpressionConverter.ConvertO(__workflow_bodycOMMENT);
                    bodypropCount++;
                }

                if (__workflow_bodysTARTDATEUT != null)
                {
                    body["START_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodysTARTDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodyeNDDATEUT != null)
                {
                    body["END_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodyeNDDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodyrENEWALDATEUT != null)
                {
                    body["RENEWAL_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodyrENEWALDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodyeXPECTEDSTARTDATEUT != null)
                {
                    body["EXPECTED_START_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodyeXPECTEDSTARTDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodycREATIONDATEUT != null)
                {
                    body["CREATION_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodycREATIONDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodyaPPLICATIONDATEUT != null)
                {
                    body["APPLICATION_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodyaPPLICATIONDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodywIZARDGUID != null)
                {
                    body["WIZARD_GUID"] = ExpressionConverter.ConvertO(__workflow_bodywIZARDGUID);
                    bodypropCount++;
                }

                if (__workflow_bodygROUPID != null)
                {
                    body["GROUP_ID"] = ExpressionConverter.ConvertO(__workflow_bodygROUPID);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELFR != null)
                {
                    body["ACTION_LABEL_FR"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELFR);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELSP != null)
                {
                    body["ACTION_LABEL_SP"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELSP);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELGE != null)
                {
                    body["ACTION_LABEL_GE"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELGE);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELIT != null)
                {
                    body["ACTION_LABEL_IT"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELIT);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELPO != null)
                {
                    body["ACTION_LABEL_PO"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELPO);
                    bodypropCount++;
                }

                if (__workflow_bodykNOWNPROBLEMID != null)
                {
                    body["KNOWN_PROBLEM_ID"] = ExpressionConverter.ConvertO(__workflow_bodykNOWNPROBLEMID);
                    bodypropCount++;
                }

                if (__workflow_bodymAXINTERVENTIONDATEUT != null)
                {
                    body["MAX_INTERVENTION_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodymAXINTERVENTIONDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodyeLAPSEDTIME != null)
                {
                    body["ELAPSED_TIME"] = ExpressionConverter.ConvertO(__workflow_bodyeLAPSEDTIME);
                    bodypropCount++;
                }

                if (__workflow_bodypRIORITYID != null)
                {
                    body["PRIORITY_ID"] = ExpressionConverter.ConvertO(__workflow_bodypRIORITYID);
                    bodypropCount++;
                }

                if (__workflow_bodytAXID != null)
                {
                    body["TAX_ID"] = ExpressionConverter.ConvertO(__workflow_bodytAXID);
                    bodypropCount++;
                }

                if (__workflow_bodysTATUSIDONCREATE != null)
                {
                    body["STATUS_ID_ON_CREATE"] = ExpressionConverter.ConvertO(__workflow_bodysTATUSIDONCREATE);
                    bodypropCount++;
                }

                if (__workflow_bodysTATUSIDONTERMINATE != null)
                {
                    body["STATUS_ID_ON_TERMINATE"] = ExpressionConverter.ConvertO(__workflow_bodysTATUSIDONTERMINATE);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONTYPEID != null)
                {
                    body["ACTION_TYPE_ID"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONTYPEID);
                    bodypropCount++;
                }

                if (__workflow_bodydELAY != null)
                {
                    body["DELAY"] = ExpressionConverter.ConvertO(__workflow_bodydELAY);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (__workflow_bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = ExpressionConverter.ConvertO(__workflow_bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (__workflow_bodytIMEUSEDTOCOMPLETEACTION != null)
                {
                    body["TIME_USED_TO_COMPLETE_ACTION"] = ExpressionConverter.ConvertO(__workflow_bodytIMEUSEDTOCOMPLETEACTION);
                    bodypropCount++;
                }

                if (__workflow_bodycONTRACTUALCOST != null)
                {
                    body["CONTRACTUAL_COST"] = ExpressionConverter.ConvertO(__workflow_bodycONTRACTUALCOST);
                    bodypropCount++;
                }

                if (__workflow_bodycONTRACTUALCOSTCURID != null)
                {
                    body["CONTRACTUAL_COST_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodycONTRACTUALCOSTCURID);
                    bodypropCount++;
                }

                if (__workflow_bodytIMECOST != null)
                {
                    body["TIME_COST"] = ExpressionConverter.ConvertO(__workflow_bodytIMECOST);
                    bodypropCount++;
                }

                if (__workflow_bodytIMECOSTCURID != null)
                {
                    body["TIME_COST_CUR_ID"] = ExpressionConverter.ConvertO(__workflow_bodytIMECOSTCURID);
                    bodypropCount++;
                }

                if (__workflow_bodyoRIGINACTIONID != null)
                {
                    body["ORIGIN_ACTION_ID"] = ExpressionConverter.ConvertO(__workflow_bodyoRIGINACTIONID);
                    bodypropCount++;
                }

                if (__workflow_bodywORKFLOWVALUE != null)
                {
                    body["WORKFLOW_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodywORKFLOWVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodycONTINUITYPLANID != null)
                {
                    body["CONTINUITY_PLAN_ID"] = ExpressionConverter.ConvertO(__workflow_bodycONTINUITYPLANID);
                    bodypropCount++;
                }

                if (__workflow_bodycATEGORYTESTID != null)
                {
                    body["CATEGORY_TEST_ID"] = ExpressionConverter.ConvertO(__workflow_bodycATEGORYTESTID);
                    bodypropCount++;
                }

                if (__workflow_bodywORKFLOWID != null)
                {
                    body["WORKFLOW_ID"] = ExpressionConverter.ConvertO(__workflow_bodywORKFLOWID);
                    bodypropCount++;
                }

                if (__workflow_bodyeXITVALUE != null)
                {
                    body["EXIT_VALUE"] = ExpressionConverter.ConvertO(__workflow_bodyeXITVALUE);
                    bodypropCount++;
                }

                if (__workflow_bodymAXRESOLUTIONDATEUT != null)
                {
                    body["MAX_RESOLUTION_DATE_UT"] = ExpressionConverter.ConvertO(__workflow_bodymAXRESOLUTIONDATEUT);
                    bodypropCount++;
                }

                if (__workflow_bodypERCENTCOMPLETE != null)
                {
                    body["PERCENT_COMPLETE"] = ExpressionConverter.ConvertO(__workflow_bodypERCENTCOMPLETE);
                    bodypropCount++;
                }

                if (__workflow_bodyeXPECTEDDURATION != null)
                {
                    body["EXPECTED_DURATION"] = ExpressionConverter.ConvertO(__workflow_bodyeXPECTEDDURATION);
                    bodypropCount++;
                }

                if (__workflow_bodywBSTASK != null)
                {
                    body["WBS_TASK"] = ExpressionConverter.ConvertO(__workflow_bodywBSTASK);
                    bodypropCount++;
                }

                if (__workflow_bodytASKPERSONCOSTPERHOUR != null)
                {
                    body["TASK_PERSON_COST_PER_HOUR"] = ExpressionConverter.ConvertO(__workflow_bodytASKPERSONCOSTPERHOUR);
                    bodypropCount++;
                }

                if (__workflow_bodytASKPLANNEDBUDGET != null)
                {
                    body["TASK_PLANNED_BUDGET"] = ExpressionConverter.ConvertO(__workflow_bodytASKPLANNEDBUDGET);
                    bodypropCount++;
                }

                if (__workflow_bodyeSTIMATEDNETCHARGE != null)
                {
                    body["ESTIMATED_NET_CHARGE"] = ExpressionConverter.ConvertO(__workflow_bodyeSTIMATEDNETCHARGE);
                    bodypropCount++;
                }

                if (__workflow_bodypREVIOUSSIBLINGID != null)
                {
                    body["PREVIOUS_SIBLING_ID"] = ExpressionConverter.ConvertO(__workflow_bodypREVIOUSSIBLINGID);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL1 != null)
                {
                    body["ACTION_LABEL_L1"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL1);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL2 != null)
                {
                    body["ACTION_LABEL_L2"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL2);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL3 != null)
                {
                    body["ACTION_LABEL_L3"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL3);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL4 != null)
                {
                    body["ACTION_LABEL_L4"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL4);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL5 != null)
                {
                    body["ACTION_LABEL_L5"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL5);
                    bodypropCount++;
                }

                if (__workflow_bodyaCTIONLABELL6 != null)
                {
                    body["ACTION_LABEL_L6"] = ExpressionConverter.ConvertO(__workflow_bodyaCTIONLABELL6);
                    bodypropCount++;
                }

                if (__workflow_bodyhISTORYID != null)
                {
                    body["HISTORY_ID"] = ExpressionConverter.ConvertO(__workflow_bodyhISTORYID);
                    bodypropCount++;
                }

                if (__workflow_bodytOTRUNC != null)
                {
                    body["TO_TRUNC"] = ExpressionConverter.ConvertO(__workflow_bodytOTRUNC);
                    bodypropCount++;
                }

                if (__workflow_bodysTAGEID != null)
                {
                    body["STAGE_ID"] = ExpressionConverter.ConvertO(__workflow_bodysTAGEID);
                    bodypropCount++;
                }

                if (__workflow_bodyiSLOCKEDPROGRESSPOINT != null)
                {
                    body["IS_LOCKED_PROGRESS_POINT"] = ExpressionConverter.ConvertO(__workflow_bodyiSLOCKEDPROGRESSPOINT);
                    bodypropCount++;
                }

                if (__workflow_bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = ExpressionConverter.ConvertO(__workflow_bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (__workflow_bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodylASTUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyeLASTDATESUPDATE != null)
                {
                    body["E_LAST_DATES_UPDATE"] = ExpressionConverter.ConvertO(__workflow_bodyeLASTDATESUPDATE);
                    bodypropCount++;
                }

                if (__workflow_bodybILLEDTIME != null)
                {
                    body["BILLED_TIME"] = ExpressionConverter.ConvertO(__workflow_bodybILLEDTIME);
                    bodypropCount++;
                }

                if (__workflow_bodyiSBILLINGREVIEWED != null)
                {
                    body["IS_BILLING_REVIEWED"] = ExpressionConverter.ConvertO(__workflow_bodyiSBILLINGREVIEWED);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateActionTicketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesofanAssetsResponse> ViewAllAtributesofanAssets(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_assetId = assetId == null ? null : WorkflowExpression.Compile(assetId);
            WorkflowExpression.Validate(__workflow_assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAllAtributesofanAssetsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAllAtributesofanAssetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> documentId)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_rfcNumber = rfcNumber == null ? null : WorkflowExpression.Compile(rfcNumber);
            WorkflowExpression.Validate(__workflow_rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rfcNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateCIResponse> UpdateCI(Expression<Func<string>> account, Expression<Func<string>> ciId, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodypurchasePrice = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyestimatedPercentageUse = null, Expression<Func<string>> bodyinstallationDate = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var __workflow_account = account == null ? null : WorkflowExpression.Compile(account);
            WorkflowExpression.Validate(__workflow_account, nameof(account), required: true);
            var __workflow_ciId = ciId == null ? null : WorkflowExpression.Compile(ciId);
            WorkflowExpression.Validate(__workflow_ciId, nameof(ciId), required: true);
            var __workflow_bodyassetLabel = bodyassetLabel == null ? null : WorkflowExpression.Compile(bodyassetLabel);
            WorkflowExpression.Validate(__workflow_bodyassetLabel, nameof(bodyassetLabel), required: false);
            var __workflow_bodypurchasePrice = bodypurchasePrice == null ? null : WorkflowExpression.Compile(bodypurchasePrice);
            WorkflowExpression.Validate(__workflow_bodypurchasePrice, nameof(bodypurchasePrice), required: false);
            var __workflow_bodyautomaticRenewal = bodyautomaticRenewal == null ? null : WorkflowExpression.Compile(bodyautomaticRenewal);
            WorkflowExpression.Validate(__workflow_bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            var __workflow_bodyestimatedPercentageUse = bodyestimatedPercentageUse == null ? null : WorkflowExpression.Compile(bodyestimatedPercentageUse);
            WorkflowExpression.Validate(__workflow_bodyestimatedPercentageUse, nameof(bodyestimatedPercentageUse), required: false);
            var __workflow_bodyinstallationDate = bodyinstallationDate == null ? null : WorkflowExpression.Compile(bodyinstallationDate);
            WorkflowExpression.Validate(__workflow_bodyinstallationDate, nameof(bodyinstallationDate), required: false);
            var __workflow_bodyavailableField1 = bodyavailableField1 == null ? null : WorkflowExpression.Compile(bodyavailableField1);
            WorkflowExpression.Validate(__workflow_bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodycommentAsset = bodycommentAsset == null ? null : WorkflowExpression.Compile(bodycommentAsset);
            WorkflowExpression.Validate(__workflow_bodycommentAsset, nameof(bodycommentAsset), required: false);
            return new DeferredBodyAction<UpdateCIResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_account, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_ciId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyassetLabel != null)
                {
                    body["asset_label"] = ExpressionConverter.ConvertO(__workflow_bodyassetLabel);
                    bodypropCount++;
                }

                if (__workflow_bodypurchasePrice != null)
                {
                    body["purchase_price"] = ExpressionConverter.ConvertO(__workflow_bodypurchasePrice);
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticRenewal != null)
                {
                    body["automatic_renewal"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticRenewal);
                    bodypropCount++;
                }

                if (__workflow_bodyestimatedPercentageUse != null)
                {
                    body["estimated_percentage_use"] = ExpressionConverter.ConvertO(__workflow_bodyestimatedPercentageUse);
                    bodypropCount++;
                }

                if (__workflow_bodyinstallationDate != null)
                {
                    body["installation_date"] = ExpressionConverter.ConvertO(__workflow_bodyinstallationDate);
                    bodypropCount++;
                }

                if (__workflow_bodyavailableField1 != null)
                {
                    body["available_field_1"] = ExpressionConverter.ConvertO(__workflow_bodyavailableField1);
                    bodypropCount++;
                }

                if (__workflow_bodycommentAsset != null)
                {
                    body["comment_asset"] = ExpressionConverter.ConvertO(__workflow_bodycommentAsset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateCIResponse>(callPayload);
            });
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
