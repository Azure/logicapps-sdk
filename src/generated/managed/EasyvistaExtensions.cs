//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyvista
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyvistaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<FinishActionResponse> FinishAction(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyendActionchoice = null, Expression<Func<string>> bodyendActiondescription = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyendActionchoice = WorkflowExpression.Compile(bodyendActionchoice, nameof(bodyendActionchoice), required: false);
            var __workflow_bodyendActiondescription = WorkflowExpression.Compile(bodyendActiondescription, nameof(bodyendActiondescription), required: false);
            return new DeferredBodyAction<FinishActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/actions/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var endActionObject = new JObject();
                var endActionObjectpropCount = 0;
                if (__workflow_bodyendActionchoice != null)
                {
                    endActionObject["Choice"] = ExpressionConverter.ConvertO(__workflow_bodyendActionchoice);
                    endActionObjectpropCount++;
                }

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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset(Expression<Func<string>> account, Expression<Func<bodyassetsInputItem[]>> bodyassets = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_bodyassets = WorkflowExpression.Compile(bodyassets, nameof(bodyassets), required: false);
            return new DeferredBodyAction<CreateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> bodybEFORELOANDEPARTMENTID = null, Expression<Func<string>> bodybEFORELOANEMPLOYEEID = null, Expression<Func<string>> bodybEFORELOANLOCATIONID = null, Expression<Func<string>> bodybILLINGPERIODICITYINMONTH = null, Expression<Func<string>> bodybUYBACKVALUE = null, Expression<Func<string>> bodybUYBACKVALUECURID = null, Expression<Func<string>> bodycATALOGID = null, Expression<Func<string>> bodycHARGEBACK = null, Expression<Func<string>> bodycHARGEBACKCURID = null, Expression<Func<string>> bodycISTATUSID = null, Expression<Func<string>> bodycIVERSION = null, Expression<Func<string>> bodycMDEFAULTCHANGEID = null, Expression<Func<string>> bodycONFIGURATIONID = null, Expression<Func<string>> bodycRITICALLEVELID = null, Expression<Func<string>> bodydELIVERYDATE = null, Expression<Func<string>> bodydELIVERYNUMBER = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodydEPRECIATIONRULEID = null, Expression<Func<string>> bodydHARDWAREGUID = null, Expression<Func<string>> bodyeMPLOYEEID = null, Expression<Func<string>> bodyeNDOFWARANTY = null, Expression<Func<string>> bodyeNTRYDATE = null, Expression<Func<string>> bodyeSTIMATEDPERCENTAGEUSE = null, Expression<Func<string>> bodyeXPECTEDENDLENDDATE = null, Expression<Func<string>> bodyeXPECTEDRETURNDATE = null, Expression<Func<string>> bodyfALLENTERM = null, Expression<Func<string>> bodyfIXEDASSETNUMBER = null, Expression<Func<string>> bodyiNITIALSTART = null, Expression<Func<string>> bodyiNSTALLATIONDATE = null, Expression<Func<string>> bodyiNTERNALDELIVERYDATE = null, Expression<Func<string>> bodyiNVOICENUMBER = null, Expression<Func<string>> bodyiSDML = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTPHYSICALINVENTORY = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylICENSEVERSION = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodymAINTENANCECOST = null, Expression<Func<string>> bodymAINTENANCECOSTCURID = null, Expression<Func<string>> bodymAINUSAGEID = null, Expression<Func<string>> bodymAXINSTALLS = null, Expression<Func<string>> bodymONTHLYFIXEDCOST = null, Expression<Func<string>> bodymONTHLYFIXEDCOSTCURID = null, Expression<Func<string>> bodymONTHLYNETRENTAL = null, Expression<Func<string>> bodymONTHLYNETRENTALCURID = null, Expression<Func<string>> bodymONTHDURATION = null, Expression<Func<string>> bodynETWORKIDENTIFIER = null, Expression<Func<string>> bodynEXTDEPARTMENTID = null, Expression<Func<string>> bodynEXTMAINTENANCEDATE = null, Expression<Func<string>> bodynEXTSTATUSID = null, Expression<Func<string>> bodynEXTUSERAPPLICATIONDATE = null, Expression<Func<string>> bodynEXTUSERID = null, Expression<Func<string>> bodynOTICE = null, Expression<Func<string>> bodyoRDERDETAILSID = null, Expression<Func<string>> bodyoRDERNUMBER = null, Expression<Func<string>> bodypIPELINESTATUSID = null, Expression<Func<string>> bodypOWERCONSUMPTIONWH = null, Expression<Func<string>> bodypROCESSORCOUNT = null, Expression<Func<string>> bodypROCESSORSOCKETCOUNT = null, Expression<Func<string>> bodypURCHASEDATE = null, Expression<Func<string>> bodypURCHASEPRICE = null, Expression<Func<string>> bodypURCHASEPRICECURID = null, Expression<Func<string>> bodypURCHASERATEID = null, Expression<Func<string>> bodyrECYCLEDDATE = null, Expression<Func<string>> bodyrECYCLINGPROVIDERID = null, Expression<Func<string>> bodyrEFORMNUMBER = null, Expression<Func<string>> bodyrEMOVEDDATE = null, Expression<Func<string>> bodyrENEWALDECISIONID = null, Expression<Func<string>> bodyrENEWALVALUE = null, Expression<Func<string>> bodyrENEWALVALUECURID = null, Expression<Func<string>> bodyrEPAIREDBYID = null, Expression<Func<string>> bodyrESALESVALUE = null, Expression<Func<string>> bodysCHEDULEDEND = null, Expression<Func<string>> bodysDCATALOGID = null, Expression<Func<string>> bodysERIALNUMBER = null, Expression<Func<string>> bodysLAID = null, Expression<Func<string>> bodysTATUSID = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodytERM = null, Expression<Func<string>> bodyuPDATECOVERAGETERM = null, Expression<Func<string>> bodywARANTYTYPEID = null, Expression<Func<string>> bodyassetLabel = null, Expression<Func<string>> bodyassetTag = null, Expression<Func<string>> bodyautomaticRenewal = null, Expression<Func<string>> bodyavailabilitySlaId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycommentAsset = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_bodybEFORELOANDEPARTMENTID = WorkflowExpression.Compile(bodybEFORELOANDEPARTMENTID, nameof(bodybEFORELOANDEPARTMENTID), required: false);
            var __workflow_bodybEFORELOANEMPLOYEEID = WorkflowExpression.Compile(bodybEFORELOANEMPLOYEEID, nameof(bodybEFORELOANEMPLOYEEID), required: false);
            var __workflow_bodybEFORELOANLOCATIONID = WorkflowExpression.Compile(bodybEFORELOANLOCATIONID, nameof(bodybEFORELOANLOCATIONID), required: false);
            var __workflow_bodybILLINGPERIODICITYINMONTH = WorkflowExpression.Compile(bodybILLINGPERIODICITYINMONTH, nameof(bodybILLINGPERIODICITYINMONTH), required: false);
            var __workflow_bodybUYBACKVALUE = WorkflowExpression.Compile(bodybUYBACKVALUE, nameof(bodybUYBACKVALUE), required: false);
            var __workflow_bodybUYBACKVALUECURID = WorkflowExpression.Compile(bodybUYBACKVALUECURID, nameof(bodybUYBACKVALUECURID), required: false);
            var __workflow_bodycATALOGID = WorkflowExpression.Compile(bodycATALOGID, nameof(bodycATALOGID), required: false);
            var __workflow_bodycHARGEBACK = WorkflowExpression.Compile(bodycHARGEBACK, nameof(bodycHARGEBACK), required: false);
            var __workflow_bodycHARGEBACKCURID = WorkflowExpression.Compile(bodycHARGEBACKCURID, nameof(bodycHARGEBACKCURID), required: false);
            var __workflow_bodycISTATUSID = WorkflowExpression.Compile(bodycISTATUSID, nameof(bodycISTATUSID), required: false);
            var __workflow_bodycIVERSION = WorkflowExpression.Compile(bodycIVERSION, nameof(bodycIVERSION), required: false);
            var __workflow_bodycMDEFAULTCHANGEID = WorkflowExpression.Compile(bodycMDEFAULTCHANGEID, nameof(bodycMDEFAULTCHANGEID), required: false);
            var __workflow_bodycONFIGURATIONID = WorkflowExpression.Compile(bodycONFIGURATIONID, nameof(bodycONFIGURATIONID), required: false);
            var __workflow_bodycRITICALLEVELID = WorkflowExpression.Compile(bodycRITICALLEVELID, nameof(bodycRITICALLEVELID), required: false);
            var __workflow_bodydELIVERYDATE = WorkflowExpression.Compile(bodydELIVERYDATE, nameof(bodydELIVERYDATE), required: false);
            var __workflow_bodydELIVERYNUMBER = WorkflowExpression.Compile(bodydELIVERYNUMBER, nameof(bodydELIVERYNUMBER), required: false);
            var __workflow_bodydEPARTMENTID = WorkflowExpression.Compile(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            var __workflow_bodydEPRECIATIONRULEID = WorkflowExpression.Compile(bodydEPRECIATIONRULEID, nameof(bodydEPRECIATIONRULEID), required: false);
            var __workflow_bodydHARDWAREGUID = WorkflowExpression.Compile(bodydHARDWAREGUID, nameof(bodydHARDWAREGUID), required: false);
            var __workflow_bodyeMPLOYEEID = WorkflowExpression.Compile(bodyeMPLOYEEID, nameof(bodyeMPLOYEEID), required: false);
            var __workflow_bodyeNDOFWARANTY = WorkflowExpression.Compile(bodyeNDOFWARANTY, nameof(bodyeNDOFWARANTY), required: false);
            var __workflow_bodyeNTRYDATE = WorkflowExpression.Compile(bodyeNTRYDATE, nameof(bodyeNTRYDATE), required: false);
            var __workflow_bodyeSTIMATEDPERCENTAGEUSE = WorkflowExpression.Compile(bodyeSTIMATEDPERCENTAGEUSE, nameof(bodyeSTIMATEDPERCENTAGEUSE), required: false);
            var __workflow_bodyeXPECTEDENDLENDDATE = WorkflowExpression.Compile(bodyeXPECTEDENDLENDDATE, nameof(bodyeXPECTEDENDLENDDATE), required: false);
            var __workflow_bodyeXPECTEDRETURNDATE = WorkflowExpression.Compile(bodyeXPECTEDRETURNDATE, nameof(bodyeXPECTEDRETURNDATE), required: false);
            var __workflow_bodyfALLENTERM = WorkflowExpression.Compile(bodyfALLENTERM, nameof(bodyfALLENTERM), required: false);
            var __workflow_bodyfIXEDASSETNUMBER = WorkflowExpression.Compile(bodyfIXEDASSETNUMBER, nameof(bodyfIXEDASSETNUMBER), required: false);
            var __workflow_bodyiNITIALSTART = WorkflowExpression.Compile(bodyiNITIALSTART, nameof(bodyiNITIALSTART), required: false);
            var __workflow_bodyiNSTALLATIONDATE = WorkflowExpression.Compile(bodyiNSTALLATIONDATE, nameof(bodyiNSTALLATIONDATE), required: false);
            var __workflow_bodyiNTERNALDELIVERYDATE = WorkflowExpression.Compile(bodyiNTERNALDELIVERYDATE, nameof(bodyiNTERNALDELIVERYDATE), required: false);
            var __workflow_bodyiNVOICENUMBER = WorkflowExpression.Compile(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            var __workflow_bodyiSDML = WorkflowExpression.Compile(bodyiSDML, nameof(bodyiSDML), required: false);
            var __workflow_bodylASTINTEGRATION = WorkflowExpression.Compile(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodylASTPHYSICALINVENTORY = WorkflowExpression.Compile(bodylASTPHYSICALINVENTORY, nameof(bodylASTPHYSICALINVENTORY), required: false);
            var __workflow_bodylASTUPDATE = WorkflowExpression.Compile(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylICENSEVERSION = WorkflowExpression.Compile(bodylICENSEVERSION, nameof(bodylICENSEVERSION), required: false);
            var __workflow_bodylOCATIONID = WorkflowExpression.Compile(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            var __workflow_bodymAINTENANCECOST = WorkflowExpression.Compile(bodymAINTENANCECOST, nameof(bodymAINTENANCECOST), required: false);
            var __workflow_bodymAINTENANCECOSTCURID = WorkflowExpression.Compile(bodymAINTENANCECOSTCURID, nameof(bodymAINTENANCECOSTCURID), required: false);
            var __workflow_bodymAINUSAGEID = WorkflowExpression.Compile(bodymAINUSAGEID, nameof(bodymAINUSAGEID), required: false);
            var __workflow_bodymAXINSTALLS = WorkflowExpression.Compile(bodymAXINSTALLS, nameof(bodymAXINSTALLS), required: false);
            var __workflow_bodymONTHLYFIXEDCOST = WorkflowExpression.Compile(bodymONTHLYFIXEDCOST, nameof(bodymONTHLYFIXEDCOST), required: false);
            var __workflow_bodymONTHLYFIXEDCOSTCURID = WorkflowExpression.Compile(bodymONTHLYFIXEDCOSTCURID, nameof(bodymONTHLYFIXEDCOSTCURID), required: false);
            var __workflow_bodymONTHLYNETRENTAL = WorkflowExpression.Compile(bodymONTHLYNETRENTAL, nameof(bodymONTHLYNETRENTAL), required: false);
            var __workflow_bodymONTHLYNETRENTALCURID = WorkflowExpression.Compile(bodymONTHLYNETRENTALCURID, nameof(bodymONTHLYNETRENTALCURID), required: false);
            var __workflow_bodymONTHDURATION = WorkflowExpression.Compile(bodymONTHDURATION, nameof(bodymONTHDURATION), required: false);
            var __workflow_bodynETWORKIDENTIFIER = WorkflowExpression.Compile(bodynETWORKIDENTIFIER, nameof(bodynETWORKIDENTIFIER), required: false);
            var __workflow_bodynEXTDEPARTMENTID = WorkflowExpression.Compile(bodynEXTDEPARTMENTID, nameof(bodynEXTDEPARTMENTID), required: false);
            var __workflow_bodynEXTMAINTENANCEDATE = WorkflowExpression.Compile(bodynEXTMAINTENANCEDATE, nameof(bodynEXTMAINTENANCEDATE), required: false);
            var __workflow_bodynEXTSTATUSID = WorkflowExpression.Compile(bodynEXTSTATUSID, nameof(bodynEXTSTATUSID), required: false);
            var __workflow_bodynEXTUSERAPPLICATIONDATE = WorkflowExpression.Compile(bodynEXTUSERAPPLICATIONDATE, nameof(bodynEXTUSERAPPLICATIONDATE), required: false);
            var __workflow_bodynEXTUSERID = WorkflowExpression.Compile(bodynEXTUSERID, nameof(bodynEXTUSERID), required: false);
            var __workflow_bodynOTICE = WorkflowExpression.Compile(bodynOTICE, nameof(bodynOTICE), required: false);
            var __workflow_bodyoRDERDETAILSID = WorkflowExpression.Compile(bodyoRDERDETAILSID, nameof(bodyoRDERDETAILSID), required: false);
            var __workflow_bodyoRDERNUMBER = WorkflowExpression.Compile(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            var __workflow_bodypIPELINESTATUSID = WorkflowExpression.Compile(bodypIPELINESTATUSID, nameof(bodypIPELINESTATUSID), required: false);
            var __workflow_bodypOWERCONSUMPTIONWH = WorkflowExpression.Compile(bodypOWERCONSUMPTIONWH, nameof(bodypOWERCONSUMPTIONWH), required: false);
            var __workflow_bodypROCESSORCOUNT = WorkflowExpression.Compile(bodypROCESSORCOUNT, nameof(bodypROCESSORCOUNT), required: false);
            var __workflow_bodypROCESSORSOCKETCOUNT = WorkflowExpression.Compile(bodypROCESSORSOCKETCOUNT, nameof(bodypROCESSORSOCKETCOUNT), required: false);
            var __workflow_bodypURCHASEDATE = WorkflowExpression.Compile(bodypURCHASEDATE, nameof(bodypURCHASEDATE), required: false);
            var __workflow_bodypURCHASEPRICE = WorkflowExpression.Compile(bodypURCHASEPRICE, nameof(bodypURCHASEPRICE), required: false);
            var __workflow_bodypURCHASEPRICECURID = WorkflowExpression.Compile(bodypURCHASEPRICECURID, nameof(bodypURCHASEPRICECURID), required: false);
            var __workflow_bodypURCHASERATEID = WorkflowExpression.Compile(bodypURCHASERATEID, nameof(bodypURCHASERATEID), required: false);
            var __workflow_bodyrECYCLEDDATE = WorkflowExpression.Compile(bodyrECYCLEDDATE, nameof(bodyrECYCLEDDATE), required: false);
            var __workflow_bodyrECYCLINGPROVIDERID = WorkflowExpression.Compile(bodyrECYCLINGPROVIDERID, nameof(bodyrECYCLINGPROVIDERID), required: false);
            var __workflow_bodyrEFORMNUMBER = WorkflowExpression.Compile(bodyrEFORMNUMBER, nameof(bodyrEFORMNUMBER), required: false);
            var __workflow_bodyrEMOVEDDATE = WorkflowExpression.Compile(bodyrEMOVEDDATE, nameof(bodyrEMOVEDDATE), required: false);
            var __workflow_bodyrENEWALDECISIONID = WorkflowExpression.Compile(bodyrENEWALDECISIONID, nameof(bodyrENEWALDECISIONID), required: false);
            var __workflow_bodyrENEWALVALUE = WorkflowExpression.Compile(bodyrENEWALVALUE, nameof(bodyrENEWALVALUE), required: false);
            var __workflow_bodyrENEWALVALUECURID = WorkflowExpression.Compile(bodyrENEWALVALUECURID, nameof(bodyrENEWALVALUECURID), required: false);
            var __workflow_bodyrEPAIREDBYID = WorkflowExpression.Compile(bodyrEPAIREDBYID, nameof(bodyrEPAIREDBYID), required: false);
            var __workflow_bodyrESALESVALUE = WorkflowExpression.Compile(bodyrESALESVALUE, nameof(bodyrESALESVALUE), required: false);
            var __workflow_bodysCHEDULEDEND = WorkflowExpression.Compile(bodysCHEDULEDEND, nameof(bodysCHEDULEDEND), required: false);
            var __workflow_bodysDCATALOGID = WorkflowExpression.Compile(bodysDCATALOGID, nameof(bodysDCATALOGID), required: false);
            var __workflow_bodysERIALNUMBER = WorkflowExpression.Compile(bodysERIALNUMBER, nameof(bodysERIALNUMBER), required: false);
            var __workflow_bodysLAID = WorkflowExpression.Compile(bodysLAID, nameof(bodysLAID), required: false);
            var __workflow_bodysTATUSID = WorkflowExpression.Compile(bodysTATUSID, nameof(bodysTATUSID), required: false);
            var __workflow_bodysUPPLIERID = WorkflowExpression.Compile(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            var __workflow_bodytERM = WorkflowExpression.Compile(bodytERM, nameof(bodytERM), required: false);
            var __workflow_bodyuPDATECOVERAGETERM = WorkflowExpression.Compile(bodyuPDATECOVERAGETERM, nameof(bodyuPDATECOVERAGETERM), required: false);
            var __workflow_bodywARANTYTYPEID = WorkflowExpression.Compile(bodywARANTYTYPEID, nameof(bodywARANTYTYPEID), required: false);
            var __workflow_bodyassetLabel = WorkflowExpression.Compile(bodyassetLabel, nameof(bodyassetLabel), required: false);
            var __workflow_bodyassetTag = WorkflowExpression.Compile(bodyassetTag, nameof(bodyassetTag), required: false);
            var __workflow_bodyautomaticRenewal = WorkflowExpression.Compile(bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            var __workflow_bodyavailabilitySlaId = WorkflowExpression.Compile(bodyavailabilitySlaId, nameof(bodyavailabilitySlaId), required: false);
            var __workflow_bodyavailableField1 = WorkflowExpression.Compile(bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = WorkflowExpression.Compile(bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = WorkflowExpression.Compile(bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = WorkflowExpression.Compile(bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = WorkflowExpression.Compile(bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = WorkflowExpression.Compile(bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodycommentAsset = WorkflowExpression.Compile(bodycommentAsset, nameof(bodycommentAsset), required: false);
            return new DeferredBodyAction<UpdateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks(Expression<Func<string>> account, Expression<Func<string>> assetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string> DeleteAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_bodycontractRow = WorkflowExpression.Compile(bodycontractRow, nameof(bodycontractRow), required: false);
            var __workflow_bodymonthlyPayment = WorkflowExpression.Compile(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<CreateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink(Expression<Func<string>> account, Expression<Func<string>> assetId, Expression<Func<string>> parentAssetId, Expression<Func<string>> bodycontractRow = null, Expression<Func<string>> bodymonthlyPayment = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_assetId = WorkflowExpression.Compile(assetId, nameof(assetId), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_bodycontractRow = WorkflowExpression.Compile(bodycontractRow, nameof(bodycontractRow), required: false);
            var __workflow_bodymonthlyPayment = WorkflowExpression.Compile(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<UpdateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_assetId.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink(Expression<Func<string>> account, Expression<Func<string>> parentAssetId, Expression<Func<string>> childAssetId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentAssetId = WorkflowExpression.Compile(parentAssetId, nameof(parentAssetId), required: true);
            var __workflow_childAssetId = WorkflowExpression.Compile(childAssetId, nameof(childAssetId), required: true);
            return new DeferredBodyAction<ViewAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentAssetId.WithUrlEncoding(1), __workflow_childAssetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-assets", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-assets/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsPathListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests-paths", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestPathResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest(Expression<Func<string>> account, Expression<Func<string>> catalogId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_catalogId = WorkflowExpression.Compile(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/catalog-requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_catalogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewConfigurationItemsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_ciId = WorkflowExpression.Compile(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}", __workflow_account.WithUrlEncoding(1), __workflow_ciId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks(Expression<Func<string>> account, Expression<Func<string>> ciId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_ciId = WorkflowExpression.Compile(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", __workflow_account.WithUrlEncoding(1), __workflow_ciId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyrelationTypeID, Expression<Func<string>> bodyblocking = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            var __workflow_bodyrelationTypeID = WorkflowExpression.Compile(bodyrelationTypeID, nameof(bodyrelationTypeID), required: true);
            var __workflow_bodyblocking = WorkflowExpression.Compile(bodyblocking, nameof(bodyblocking), required: false);
            return new DeferredBodyAction<CreateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink(Expression<Func<string>> account, Expression<Func<string>> parentCiId, Expression<Func<string>> childCiId, Expression<Func<string>> bodyblocking = null, Expression<Func<string>> bodyrelationTypeID = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_parentCiId = WorkflowExpression.Compile(parentCiId, nameof(parentCiId), required: true);
            var __workflow_childCiId = WorkflowExpression.Compile(childCiId, nameof(childCiId), required: true);
            var __workflow_bodyblocking = WorkflowExpression.Compile(bodyblocking, nameof(bodyblocking), required: false);
            var __workflow_bodyrelationTypeID = WorkflowExpression.Compile(bodyrelationTypeID, nameof(bodyrelationTypeID), required: false);
            return new DeferredBodyAction<UpdateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", __workflow_account.WithUrlEncoding(1), __workflow_parentCiId.WithUrlEncoding(1), __workflow_childCiId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEntitiesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/departments", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity(Expression<Func<string>> account, Expression<Func<string>> departmentId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_departmentId = WorkflowExpression.Compile(departmentId, nameof(departmentId), required: true);
            return new DeferredBodyAction<ViewEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/departments/{1}", __workflow_account.WithUrlEncoding(1), __workflow_departmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEmployeesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee(Expression<Func<string>> account, Expression<Func<bodyemployeesInputItem[]>> bodyemployees = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_bodyemployees = WorkflowExpression.Compile(bodyemployees, nameof(bodyemployees), required: false);
            return new DeferredBodyAction<CreateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ViewEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees/{1}", __workflow_account.WithUrlEncoding(1), __workflow_employeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee(Expression<Func<string>> account, Expression<Func<string>> employeeId, Expression<Func<string>> bodyaPPROVEDTOVALIDATE = null, Expression<Func<string>> bodyaVAILABILITYSTATUSID = null, Expression<Func<string>> bodyaVAILABLEFIELD1 = null, Expression<Func<string>> bodyaVAILABLEFIELD2 = null, Expression<Func<string>> bodyaVAILABLEFIELD3 = null, Expression<Func<string>> bodyaVAILABLEFIELD4 = null, Expression<Func<string>> bodyaVAILABLEFIELD5 = null, Expression<Func<string>> bodyaVAILABLEFIELD6 = null, Expression<Func<string>> bodybEGINOFCONTRACT = null, Expression<Func<string>> bodycELLULARNUMBER = null, Expression<Func<string>> bodycHATLOGIN = null, Expression<Func<string>> bodycIVILSTATUSID = null, Expression<Func<string>> bodycOMMENTEMPLOYEE = null, Expression<Func<string>> bodycOSTPERHOUR = null, Expression<Func<string>> bodycOSTPERHOURCURID = null, Expression<Func<string>> bodydEFAULTCOSTCENTERID = null, Expression<Func<string>> bodydELEGATIONFROM = null, Expression<Func<string>> bodydELEGATIONID = null, Expression<Func<string>> bodydELEGATIONTO = null, Expression<Func<string>> bodydEPARTMENTID = null, Expression<Func<string>> bodyeNDOFCONTRACT = null, Expression<Func<string>> bodyeMAIL = null, Expression<Func<string>> bodyfAXNUMBER = null, Expression<Func<string>> bodyfUNCTIONID = null, Expression<Func<string>> bodyiCQNUMBER = null, Expression<Func<string>> bodyiDENTIFICATION = null, Expression<Func<string>> bodyiSAUTOMATICSTATUS = null, Expression<Func<string>> bodyiTCORRESPONDENT = null, Expression<Func<string>> bodylANGUAGEID = null, Expression<Func<string>> bodylASTINTEGRATION = null, Expression<Func<string>> bodylASTNAME = null, Expression<Func<string>> bodylASTUPDATE = null, Expression<Func<string>> bodylOCATIONID = null, Expression<Func<string>> bodylOGIN = null, Expression<Func<string>> bodymANAGERID = null, Expression<Func<string>> bodymESSENGERSIGNNAME = null, Expression<Func<string>> bodynOTIFICATIONTYPEID = null, Expression<Func<string>> bodypASSWDLASTUPDATEUT = null, Expression<Func<string>> bodypHONENUMBER = null, Expression<Func<string>> bodypICTUREPATH = null, Expression<Func<string>> bodysUPPLIERID = null, Expression<Func<string>> bodyvALIDATORID = null, Expression<Func<string>> bodyvIPLEVELID = null, Expression<Func<string>> bodywAVEADDRESS = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_employeeId = WorkflowExpression.Compile(employeeId, nameof(employeeId), required: true);
            var __workflow_bodyaPPROVEDTOVALIDATE = WorkflowExpression.Compile(bodyaPPROVEDTOVALIDATE, nameof(bodyaPPROVEDTOVALIDATE), required: false);
            var __workflow_bodyaVAILABILITYSTATUSID = WorkflowExpression.Compile(bodyaVAILABILITYSTATUSID, nameof(bodyaVAILABILITYSTATUSID), required: false);
            var __workflow_bodyaVAILABLEFIELD1 = WorkflowExpression.Compile(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            var __workflow_bodyaVAILABLEFIELD2 = WorkflowExpression.Compile(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            var __workflow_bodyaVAILABLEFIELD3 = WorkflowExpression.Compile(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            var __workflow_bodyaVAILABLEFIELD4 = WorkflowExpression.Compile(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            var __workflow_bodyaVAILABLEFIELD5 = WorkflowExpression.Compile(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            var __workflow_bodyaVAILABLEFIELD6 = WorkflowExpression.Compile(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            var __workflow_bodybEGINOFCONTRACT = WorkflowExpression.Compile(bodybEGINOFCONTRACT, nameof(bodybEGINOFCONTRACT), required: false);
            var __workflow_bodycELLULARNUMBER = WorkflowExpression.Compile(bodycELLULARNUMBER, nameof(bodycELLULARNUMBER), required: false);
            var __workflow_bodycHATLOGIN = WorkflowExpression.Compile(bodycHATLOGIN, nameof(bodycHATLOGIN), required: false);
            var __workflow_bodycIVILSTATUSID = WorkflowExpression.Compile(bodycIVILSTATUSID, nameof(bodycIVILSTATUSID), required: false);
            var __workflow_bodycOMMENTEMPLOYEE = WorkflowExpression.Compile(bodycOMMENTEMPLOYEE, nameof(bodycOMMENTEMPLOYEE), required: false);
            var __workflow_bodycOSTPERHOUR = WorkflowExpression.Compile(bodycOSTPERHOUR, nameof(bodycOSTPERHOUR), required: false);
            var __workflow_bodycOSTPERHOURCURID = WorkflowExpression.Compile(bodycOSTPERHOURCURID, nameof(bodycOSTPERHOURCURID), required: false);
            var __workflow_bodydEFAULTCOSTCENTERID = WorkflowExpression.Compile(bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            var __workflow_bodydELEGATIONFROM = WorkflowExpression.Compile(bodydELEGATIONFROM, nameof(bodydELEGATIONFROM), required: false);
            var __workflow_bodydELEGATIONID = WorkflowExpression.Compile(bodydELEGATIONID, nameof(bodydELEGATIONID), required: false);
            var __workflow_bodydELEGATIONTO = WorkflowExpression.Compile(bodydELEGATIONTO, nameof(bodydELEGATIONTO), required: false);
            var __workflow_bodydEPARTMENTID = WorkflowExpression.Compile(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            var __workflow_bodyeNDOFCONTRACT = WorkflowExpression.Compile(bodyeNDOFCONTRACT, nameof(bodyeNDOFCONTRACT), required: false);
            var __workflow_bodyeMAIL = WorkflowExpression.Compile(bodyeMAIL, nameof(bodyeMAIL), required: false);
            var __workflow_bodyfAXNUMBER = WorkflowExpression.Compile(bodyfAXNUMBER, nameof(bodyfAXNUMBER), required: false);
            var __workflow_bodyfUNCTIONID = WorkflowExpression.Compile(bodyfUNCTIONID, nameof(bodyfUNCTIONID), required: false);
            var __workflow_bodyiCQNUMBER = WorkflowExpression.Compile(bodyiCQNUMBER, nameof(bodyiCQNUMBER), required: false);
            var __workflow_bodyiDENTIFICATION = WorkflowExpression.Compile(bodyiDENTIFICATION, nameof(bodyiDENTIFICATION), required: false);
            var __workflow_bodyiSAUTOMATICSTATUS = WorkflowExpression.Compile(bodyiSAUTOMATICSTATUS, nameof(bodyiSAUTOMATICSTATUS), required: false);
            var __workflow_bodyiTCORRESPONDENT = WorkflowExpression.Compile(bodyiTCORRESPONDENT, nameof(bodyiTCORRESPONDENT), required: false);
            var __workflow_bodylANGUAGEID = WorkflowExpression.Compile(bodylANGUAGEID, nameof(bodylANGUAGEID), required: false);
            var __workflow_bodylASTINTEGRATION = WorkflowExpression.Compile(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            var __workflow_bodylASTNAME = WorkflowExpression.Compile(bodylASTNAME, nameof(bodylASTNAME), required: false);
            var __workflow_bodylASTUPDATE = WorkflowExpression.Compile(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            var __workflow_bodylOCATIONID = WorkflowExpression.Compile(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            var __workflow_bodylOGIN = WorkflowExpression.Compile(bodylOGIN, nameof(bodylOGIN), required: false);
            var __workflow_bodymANAGERID = WorkflowExpression.Compile(bodymANAGERID, nameof(bodymANAGERID), required: false);
            var __workflow_bodymESSENGERSIGNNAME = WorkflowExpression.Compile(bodymESSENGERSIGNNAME, nameof(bodymESSENGERSIGNNAME), required: false);
            var __workflow_bodynOTIFICATIONTYPEID = WorkflowExpression.Compile(bodynOTIFICATIONTYPEID, nameof(bodynOTIFICATIONTYPEID), required: false);
            var __workflow_bodypASSWDLASTUPDATEUT = WorkflowExpression.Compile(bodypASSWDLASTUPDATEUT, nameof(bodypASSWDLASTUPDATEUT), required: false);
            var __workflow_bodypHONENUMBER = WorkflowExpression.Compile(bodypHONENUMBER, nameof(bodypHONENUMBER), required: false);
            var __workflow_bodypICTUREPATH = WorkflowExpression.Compile(bodypICTUREPATH, nameof(bodypICTUREPATH), required: false);
            var __workflow_bodysUPPLIERID = WorkflowExpression.Compile(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            var __workflow_bodyvALIDATORID = WorkflowExpression.Compile(bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            var __workflow_bodyvIPLEVELID = WorkflowExpression.Compile(bodyvIPLEVELID, nameof(bodyvIPLEVELID), required: false);
            var __workflow_bodywAVEADDRESS = WorkflowExpression.Compile(bodywAVEADDRESS, nameof(bodywAVEADDRESS), required: false);
            return new DeferredBodyAction<UpdateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/employees/{1}", __workflow_account.WithUrlEncoding(1), __workflow_employeeId.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewKnownErrorsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/known-problems", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors(Expression<Func<string>> account, Expression<Func<string>> kpId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_kpId = WorkflowExpression.Compile(kpId, nameof(kpId), required: true);
            return new DeferredBodyAction<ViewKnownErrorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/known-problems/{1}", __workflow_account.WithUrlEncoding(1), __workflow_kpId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewLocationsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/locations", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation(Expression<Func<string>> account, Expression<Func<string>> locationId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<ViewLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/locations/{1}", __workflow_account.WithUrlEncoding(1), __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewManufacturerListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/manufacturers", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer(Expression<Func<string>> account, Expression<Func<string>> manufacturerId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_manufacturerId = WorkflowExpression.Compile(manufacturerId, nameof(manufacturerId), required: true);
            return new DeferredBodyAction<ViewManufacturerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/manufacturers/{1}", __workflow_account.WithUrlEncoding(1), __workflow_manufacturerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewRequestsIncidentsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident(Expression<Func<string>> account, Expression<Func<bodyrequestsInputItem[]>> bodyrequests = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_bodyrequests = WorkflowExpression.Compile(bodyrequests, nameof(bodyrequests), required: false);
            return new DeferredBodyAction<CreateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodyclosedInputItem[]>> bodyclosed = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyclosed = WorkflowExpression.Compile(bodyclosed, nameof(bodyclosed), required: false);
            return new DeferredBodyAction<CloseRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyanalyticalChargeId = null, Expression<Func<string>> bodyassetId = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodybudgetPlanned = null, Expression<Func<string>> bodycanBeDuplicated = null, Expression<Func<string>> bodyciId = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontinuityPlanId = null, Expression<Func<string>> bodycostCenterId = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydelay = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydynamicDetails = null, Expression<Func<string>> bodyeffectiveChangeDateEnd = null, Expression<Func<string>> bodyeffectiveChangeDateStart = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodyestimatedNetPrice = null, Expression<Func<string>> bodyexpectedDateUt = null, Expression<Func<string>> bodyexpectedDuration = null, Expression<Func<string>> bodyexpectedEndDateUt = null, Expression<Func<string>> bodyexpectedStartDateUt = null, Expression<Func<string>> bodyexternalReference = null, Expression<Func<string>> bodyfirstCallResolution = null, Expression<Func<string>> bodyhourPerDay = null, Expression<Func<string>> bodyimpactId = null, Expression<Func<string>> bodyimputationDate = null, Expression<Func<string>> bodyisMajorIncident = null, Expression<Func<string>> bodyisTemplate = null, Expression<Func<string>> bodyknownProblemsId = null, Expression<Func<string>> bodylastUpdate = null, Expression<Func<string>> bodymark1 = null, Expression<Func<string>> bodymark2 = null, Expression<Func<string>> bodymaxResolutionDateUt = null, Expression<Func<string>> bodymsProjectImportValidationWaiting = null, Expression<Func<string>> bodynetPrice = null, Expression<Func<string>> bodynetPriceCurId = null, Expression<Func<string>> bodyoriginToolId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyowningGroupId = null, Expression<Func<string>> bodyplannedChangeDateEnd = null, Expression<Func<string>> bodyplannedChangeDateStart = null, Expression<Func<string>> bodypmStatusId = null, Expression<Func<string>> bodyprojectName = null, Expression<Func<string>> bodyprojectStartDateUt = null, Expression<Func<string>> bodyqty = null, Expression<Func<string>> bodyreleaseId = null, Expression<Func<string>> bodyrentalNetPrice = null, Expression<Func<string>> bodyrentalNetPriceCurId = null, Expression<Func<string>> bodyrequestOriginId = null, Expression<Func<string>> bodyrequestedChangeDateEnd = null, Expression<Func<string>> bodyrequestedChangeDateStart = null, Expression<Func<string>> bodyrequestorId = null, Expression<Func<string>> bodyrequestorIpAddress = null, Expression<Func<string>> bodyrequestorPhone = null, Expression<Func<string>> bodyriskAmount = null, Expression<Func<string>> bodyriskDescription = null, Expression<Func<string>> bodyriskLevelId = null, Expression<Func<string>> bodyrootCauseId = null, Expression<Func<string>> bodysubmitDateUt = null, Expression<Func<string>> bodytimeUsedToSolveRequest = null, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyanalyticalChargeId = WorkflowExpression.Compile(bodyanalyticalChargeId, nameof(bodyanalyticalChargeId), required: false);
            var __workflow_bodyassetId = WorkflowExpression.Compile(bodyassetId, nameof(bodyassetId), required: false);
            var __workflow_bodyavailableField1 = WorkflowExpression.Compile(bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = WorkflowExpression.Compile(bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = WorkflowExpression.Compile(bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = WorkflowExpression.Compile(bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = WorkflowExpression.Compile(bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = WorkflowExpression.Compile(bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodybudgetPlanned = WorkflowExpression.Compile(bodybudgetPlanned, nameof(bodybudgetPlanned), required: false);
            var __workflow_bodycanBeDuplicated = WorkflowExpression.Compile(bodycanBeDuplicated, nameof(bodycanBeDuplicated), required: false);
            var __workflow_bodyciId = WorkflowExpression.Compile(bodyciId, nameof(bodyciId), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodycontinuityPlanId = WorkflowExpression.Compile(bodycontinuityPlanId, nameof(bodycontinuityPlanId), required: false);
            var __workflow_bodycostCenterId = WorkflowExpression.Compile(bodycostCenterId, nameof(bodycostCenterId), required: false);
            var __workflow_bodycreationDateUt = WorkflowExpression.Compile(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            var __workflow_bodydelay = WorkflowExpression.Compile(bodydelay, nameof(bodydelay), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydynamicDetails = WorkflowExpression.Compile(bodydynamicDetails, nameof(bodydynamicDetails), required: false);
            var __workflow_bodyeffectiveChangeDateEnd = WorkflowExpression.Compile(bodyeffectiveChangeDateEnd, nameof(bodyeffectiveChangeDateEnd), required: false);
            var __workflow_bodyeffectiveChangeDateStart = WorkflowExpression.Compile(bodyeffectiveChangeDateStart, nameof(bodyeffectiveChangeDateStart), required: false);
            var __workflow_bodyendDateUt = WorkflowExpression.Compile(bodyendDateUt, nameof(bodyendDateUt), required: false);
            var __workflow_bodyestimatedNetPrice = WorkflowExpression.Compile(bodyestimatedNetPrice, nameof(bodyestimatedNetPrice), required: false);
            var __workflow_bodyexpectedDateUt = WorkflowExpression.Compile(bodyexpectedDateUt, nameof(bodyexpectedDateUt), required: false);
            var __workflow_bodyexpectedDuration = WorkflowExpression.Compile(bodyexpectedDuration, nameof(bodyexpectedDuration), required: false);
            var __workflow_bodyexpectedEndDateUt = WorkflowExpression.Compile(bodyexpectedEndDateUt, nameof(bodyexpectedEndDateUt), required: false);
            var __workflow_bodyexpectedStartDateUt = WorkflowExpression.Compile(bodyexpectedStartDateUt, nameof(bodyexpectedStartDateUt), required: false);
            var __workflow_bodyexternalReference = WorkflowExpression.Compile(bodyexternalReference, nameof(bodyexternalReference), required: false);
            var __workflow_bodyfirstCallResolution = WorkflowExpression.Compile(bodyfirstCallResolution, nameof(bodyfirstCallResolution), required: false);
            var __workflow_bodyhourPerDay = WorkflowExpression.Compile(bodyhourPerDay, nameof(bodyhourPerDay), required: false);
            var __workflow_bodyimpactId = WorkflowExpression.Compile(bodyimpactId, nameof(bodyimpactId), required: false);
            var __workflow_bodyimputationDate = WorkflowExpression.Compile(bodyimputationDate, nameof(bodyimputationDate), required: false);
            var __workflow_bodyisMajorIncident = WorkflowExpression.Compile(bodyisMajorIncident, nameof(bodyisMajorIncident), required: false);
            var __workflow_bodyisTemplate = WorkflowExpression.Compile(bodyisTemplate, nameof(bodyisTemplate), required: false);
            var __workflow_bodyknownProblemsId = WorkflowExpression.Compile(bodyknownProblemsId, nameof(bodyknownProblemsId), required: false);
            var __workflow_bodylastUpdate = WorkflowExpression.Compile(bodylastUpdate, nameof(bodylastUpdate), required: false);
            var __workflow_bodymark1 = WorkflowExpression.Compile(bodymark1, nameof(bodymark1), required: false);
            var __workflow_bodymark2 = WorkflowExpression.Compile(bodymark2, nameof(bodymark2), required: false);
            var __workflow_bodymaxResolutionDateUt = WorkflowExpression.Compile(bodymaxResolutionDateUt, nameof(bodymaxResolutionDateUt), required: false);
            var __workflow_bodymsProjectImportValidationWaiting = WorkflowExpression.Compile(bodymsProjectImportValidationWaiting, nameof(bodymsProjectImportValidationWaiting), required: false);
            var __workflow_bodynetPrice = WorkflowExpression.Compile(bodynetPrice, nameof(bodynetPrice), required: false);
            var __workflow_bodynetPriceCurId = WorkflowExpression.Compile(bodynetPriceCurId, nameof(bodynetPriceCurId), required: false);
            var __workflow_bodyoriginToolId = WorkflowExpression.Compile(bodyoriginToolId, nameof(bodyoriginToolId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyowningGroupId = WorkflowExpression.Compile(bodyowningGroupId, nameof(bodyowningGroupId), required: false);
            var __workflow_bodyplannedChangeDateEnd = WorkflowExpression.Compile(bodyplannedChangeDateEnd, nameof(bodyplannedChangeDateEnd), required: false);
            var __workflow_bodyplannedChangeDateStart = WorkflowExpression.Compile(bodyplannedChangeDateStart, nameof(bodyplannedChangeDateStart), required: false);
            var __workflow_bodypmStatusId = WorkflowExpression.Compile(bodypmStatusId, nameof(bodypmStatusId), required: false);
            var __workflow_bodyprojectName = WorkflowExpression.Compile(bodyprojectName, nameof(bodyprojectName), required: false);
            var __workflow_bodyprojectStartDateUt = WorkflowExpression.Compile(bodyprojectStartDateUt, nameof(bodyprojectStartDateUt), required: false);
            var __workflow_bodyqty = WorkflowExpression.Compile(bodyqty, nameof(bodyqty), required: false);
            var __workflow_bodyreleaseId = WorkflowExpression.Compile(bodyreleaseId, nameof(bodyreleaseId), required: false);
            var __workflow_bodyrentalNetPrice = WorkflowExpression.Compile(bodyrentalNetPrice, nameof(bodyrentalNetPrice), required: false);
            var __workflow_bodyrentalNetPriceCurId = WorkflowExpression.Compile(bodyrentalNetPriceCurId, nameof(bodyrentalNetPriceCurId), required: false);
            var __workflow_bodyrequestOriginId = WorkflowExpression.Compile(bodyrequestOriginId, nameof(bodyrequestOriginId), required: false);
            var __workflow_bodyrequestedChangeDateEnd = WorkflowExpression.Compile(bodyrequestedChangeDateEnd, nameof(bodyrequestedChangeDateEnd), required: false);
            var __workflow_bodyrequestedChangeDateStart = WorkflowExpression.Compile(bodyrequestedChangeDateStart, nameof(bodyrequestedChangeDateStart), required: false);
            var __workflow_bodyrequestorId = WorkflowExpression.Compile(bodyrequestorId, nameof(bodyrequestorId), required: false);
            var __workflow_bodyrequestorIpAddress = WorkflowExpression.Compile(bodyrequestorIpAddress, nameof(bodyrequestorIpAddress), required: false);
            var __workflow_bodyrequestorPhone = WorkflowExpression.Compile(bodyrequestorPhone, nameof(bodyrequestorPhone), required: false);
            var __workflow_bodyriskAmount = WorkflowExpression.Compile(bodyriskAmount, nameof(bodyriskAmount), required: false);
            var __workflow_bodyriskDescription = WorkflowExpression.Compile(bodyriskDescription, nameof(bodyriskDescription), required: false);
            var __workflow_bodyriskLevelId = WorkflowExpression.Compile(bodyriskLevelId, nameof(bodyriskLevelId), required: false);
            var __workflow_bodyrootCauseId = WorkflowExpression.Compile(bodyrootCauseId, nameof(bodyrootCauseId), required: false);
            var __workflow_bodysubmitDateUt = WorkflowExpression.Compile(bodysubmitDateUt, nameof(bodysubmitDateUt), required: false);
            var __workflow_bodytimeUsedToSolveRequest = WorkflowExpression.Compile(bodytimeUsedToSolveRequest, nameof(bodytimeUsedToSolveRequest), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<UpdateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/comment", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList(Expression<Func<string>> account, Expression<Func<string>> rfcNumber)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<GetRequestIncidentDocumentListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/documents", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<bodydocumentsInputItem[]>> bodydocuments)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: true);
            return new DeferredBodyAction<UploadAndAttachADocumentToARequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/documents", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<int>> bodydoneById = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodydoneById = WorkflowExpression.Compile(bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<RestartRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/restart", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodydoneById = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodydoneById = WorkflowExpression.Compile(bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<SuspendRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/suspend", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IWorkflowAction CreateTask(Expression<Func<string>> account, Expression<Func<string>> rfcNumber, Expression<Func<string>> bodyactionTypeId, Expression<Func<string>> bodyelapsedTime = null, Expression<Func<string>> bodyavailableField1 = null, Expression<Func<string>> bodyavailableField2 = null, Expression<Func<string>> bodyavailableField3 = null, Expression<Func<string>> bodyavailableField4 = null, Expression<Func<string>> bodyavailableField5 = null, Expression<Func<string>> bodyavailableField6 = null, Expression<Func<string>> bodycontractualCost = null, Expression<Func<string>> bodycreationDateUt = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyendDateUt = null, Expression<Func<string>> bodygroupMail = null, Expression<Func<string>> bodygroupName = null, Expression<Func<string>> bodystartDateUt = null, Expression<Func<string>> bodytimeCost = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_rfcNumber = WorkflowExpression.Compile(rfcNumber, nameof(rfcNumber), required: true);
            var __workflow_bodyactionTypeId = WorkflowExpression.Compile(bodyactionTypeId, nameof(bodyactionTypeId), required: true);
            var __workflow_bodyelapsedTime = WorkflowExpression.Compile(bodyelapsedTime, nameof(bodyelapsedTime), required: false);
            var __workflow_bodyavailableField1 = WorkflowExpression.Compile(bodyavailableField1, nameof(bodyavailableField1), required: false);
            var __workflow_bodyavailableField2 = WorkflowExpression.Compile(bodyavailableField2, nameof(bodyavailableField2), required: false);
            var __workflow_bodyavailableField3 = WorkflowExpression.Compile(bodyavailableField3, nameof(bodyavailableField3), required: false);
            var __workflow_bodyavailableField4 = WorkflowExpression.Compile(bodyavailableField4, nameof(bodyavailableField4), required: false);
            var __workflow_bodyavailableField5 = WorkflowExpression.Compile(bodyavailableField5, nameof(bodyavailableField5), required: false);
            var __workflow_bodyavailableField6 = WorkflowExpression.Compile(bodyavailableField6, nameof(bodyavailableField6), required: false);
            var __workflow_bodycontractualCost = WorkflowExpression.Compile(bodycontractualCost, nameof(bodycontractualCost), required: false);
            var __workflow_bodycreationDateUt = WorkflowExpression.Compile(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyendDateUt = WorkflowExpression.Compile(bodyendDateUt, nameof(bodyendDateUt), required: false);
            var __workflow_bodygroupMail = WorkflowExpression.Compile(bodygroupMail, nameof(bodygroupMail), required: false);
            var __workflow_bodygroupName = WorkflowExpression.Compile(bodygroupName, nameof(bodygroupName), required: false);
            var __workflow_bodystartDateUt = WorkflowExpression.Compile(bodystartDateUt, nameof(bodystartDateUt), required: false);
            var __workflow_bodytimeCost = WorkflowExpression.Compile(bodytimeCost, nameof(bodytimeCost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/requests/{1}/tasks", __workflow_account.WithUrlEncoding(1), __workflow_rfcNumber.WithUrlEncoding(1)));
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList(Expression<Func<string>> account, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sort = null, Expression<Func<string>> maxRows = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_maxRows = WorkflowExpression.Compile(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewSlasListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/slas", __workflow_account.WithUrlEncoding(1)));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla(Expression<Func<string>> account, Expression<Func<string>> slaId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_slaId = WorkflowExpression.Compile(slaId, nameof(slaId), required: true);
            return new DeferredBodyAction<ViewSlaResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/{0}/slas/{1}", __workflow_account.WithUrlEncoding(1), __workflow_slaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewSlaResponse>(callPayload);
            });
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
