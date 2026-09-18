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
        public IBodyWorkflowAction<FinishActionResponse> FinishAction([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyendActiondescription = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodyendActiondescription, nameof(bodyendActiondescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var endActionObject = new JObject();
                var endActionObjectpropCount = 0;
                if (bodyendActiondescription != null)
                {
                    endActionObject["Description"] = SourceExpressionConverter.ConvertToken(bodyendActiondescription);
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
                return callPayload;
            }

            return new ApiConnectionAction<FinishActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAssetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyassetsInputItem[]> bodyassets = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(bodyassets, nameof(bodyassets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassets != null)
                {
                    body["assets"] = SourceExpressionConverter.ConvertToken(bodyassets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAssetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAssetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> bodybEFORELOANDEPARTMENTID = null, [WorkflowExpression] Func<string> bodybEFORELOANEMPLOYEEID = null, [WorkflowExpression] Func<string> bodybEFORELOANLOCATIONID = null, [WorkflowExpression] Func<string> bodybILLINGPERIODICITYINMONTH = null, [WorkflowExpression] Func<string> bodybUYBACKVALUE = null, [WorkflowExpression] Func<string> bodybUYBACKVALUECURID = null, [WorkflowExpression] Func<string> bodycATALOGID = null, [WorkflowExpression] Func<string> bodycHARGEBACK = null, [WorkflowExpression] Func<string> bodycHARGEBACKCURID = null, [WorkflowExpression] Func<string> bodycISTATUSID = null, [WorkflowExpression] Func<string> bodycIVERSION = null, [WorkflowExpression] Func<string> bodycMDEFAULTCHANGEID = null, [WorkflowExpression] Func<string> bodycONFIGURATIONID = null, [WorkflowExpression] Func<string> bodycRITICALLEVELID = null, [WorkflowExpression] Func<string> bodydELIVERYDATE = null, [WorkflowExpression] Func<string> bodydELIVERYNUMBER = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodydEPRECIATIONRULEID = null, [WorkflowExpression] Func<string> bodydHARDWAREGUID = null, [WorkflowExpression] Func<string> bodyeMPLOYEEID = null, [WorkflowExpression] Func<string> bodyeNDOFWARANTY = null, [WorkflowExpression] Func<string> bodyeNTRYDATE = null, [WorkflowExpression] Func<string> bodyeSTIMATEDPERCENTAGEUSE = null, [WorkflowExpression] Func<string> bodyeXPECTEDENDLENDDATE = null, [WorkflowExpression] Func<string> bodyeXPECTEDRETURNDATE = null, [WorkflowExpression] Func<string> bodyfALLENTERM = null, [WorkflowExpression] Func<string> bodyfIXEDASSETNUMBER = null, [WorkflowExpression] Func<string> bodyiNITIALSTART = null, [WorkflowExpression] Func<string> bodyiNSTALLATIONDATE = null, [WorkflowExpression] Func<string> bodyiNTERNALDELIVERYDATE = null, [WorkflowExpression] Func<string> bodyiNVOICENUMBER = null, [WorkflowExpression] Func<string> bodyiSDML = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTPHYSICALINVENTORY = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylICENSEVERSION = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodymAINTENANCECOST = null, [WorkflowExpression] Func<string> bodymAINTENANCECOSTCURID = null, [WorkflowExpression] Func<string> bodymAINUSAGEID = null, [WorkflowExpression] Func<string> bodymAXINSTALLS = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOST = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOSTCURID = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTAL = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTALCURID = null, [WorkflowExpression] Func<string> bodymONTHDURATION = null, [WorkflowExpression] Func<string> bodynETWORKIDENTIFIER = null, [WorkflowExpression] Func<string> bodynEXTDEPARTMENTID = null, [WorkflowExpression] Func<string> bodynEXTMAINTENANCEDATE = null, [WorkflowExpression] Func<string> bodynEXTSTATUSID = null, [WorkflowExpression] Func<string> bodynEXTUSERAPPLICATIONDATE = null, [WorkflowExpression] Func<string> bodynEXTUSERID = null, [WorkflowExpression] Func<string> bodynOTICE = null, [WorkflowExpression] Func<string> bodyoRDERDETAILSID = null, [WorkflowExpression] Func<string> bodyoRDERNUMBER = null, [WorkflowExpression] Func<string> bodypIPELINESTATUSID = null, [WorkflowExpression] Func<string> bodypOWERCONSUMPTIONWH = null, [WorkflowExpression] Func<string> bodypROCESSORCOUNT = null, [WorkflowExpression] Func<string> bodypROCESSORSOCKETCOUNT = null, [WorkflowExpression] Func<string> bodypURCHASEDATE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICECURID = null, [WorkflowExpression] Func<string> bodypURCHASERATEID = null, [WorkflowExpression] Func<string> bodyrECYCLEDDATE = null, [WorkflowExpression] Func<string> bodyrECYCLINGPROVIDERID = null, [WorkflowExpression] Func<string> bodyrEFORMNUMBER = null, [WorkflowExpression] Func<string> bodyrEMOVEDDATE = null, [WorkflowExpression] Func<string> bodyrENEWALDECISIONID = null, [WorkflowExpression] Func<string> bodyrENEWALVALUE = null, [WorkflowExpression] Func<string> bodyrENEWALVALUECURID = null, [WorkflowExpression] Func<string> bodyrEPAIREDBYID = null, [WorkflowExpression] Func<string> bodyrESALESVALUE = null, [WorkflowExpression] Func<string> bodysCHEDULEDEND = null, [WorkflowExpression] Func<string> bodysDCATALOGID = null, [WorkflowExpression] Func<string> bodysERIALNUMBER = null, [WorkflowExpression] Func<string> bodysLAID = null, [WorkflowExpression] Func<string> bodysTATUSID = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodytERM = null, [WorkflowExpression] Func<string> bodyuPDATECOVERAGETERM = null, [WorkflowExpression] Func<string> bodywARANTYTYPEID = null, [WorkflowExpression] Func<string> bodyassetLabel = null, [WorkflowExpression] Func<string> bodyassetTag = null, [WorkflowExpression] Func<string> bodyautomaticRenewal = null, [WorkflowExpression] Func<string> bodyavailabilitySlaId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycommentAsset = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(bodybEFORELOANDEPARTMENTID, nameof(bodybEFORELOANDEPARTMENTID), required: false);
            SourceExpression.Validate(bodybEFORELOANEMPLOYEEID, nameof(bodybEFORELOANEMPLOYEEID), required: false);
            SourceExpression.Validate(bodybEFORELOANLOCATIONID, nameof(bodybEFORELOANLOCATIONID), required: false);
            SourceExpression.Validate(bodybILLINGPERIODICITYINMONTH, nameof(bodybILLINGPERIODICITYINMONTH), required: false);
            SourceExpression.Validate(bodybUYBACKVALUE, nameof(bodybUYBACKVALUE), required: false);
            SourceExpression.Validate(bodybUYBACKVALUECURID, nameof(bodybUYBACKVALUECURID), required: false);
            SourceExpression.Validate(bodycATALOGID, nameof(bodycATALOGID), required: false);
            SourceExpression.Validate(bodycHARGEBACK, nameof(bodycHARGEBACK), required: false);
            SourceExpression.Validate(bodycHARGEBACKCURID, nameof(bodycHARGEBACKCURID), required: false);
            SourceExpression.Validate(bodycISTATUSID, nameof(bodycISTATUSID), required: false);
            SourceExpression.Validate(bodycIVERSION, nameof(bodycIVERSION), required: false);
            SourceExpression.Validate(bodycMDEFAULTCHANGEID, nameof(bodycMDEFAULTCHANGEID), required: false);
            SourceExpression.Validate(bodycONFIGURATIONID, nameof(bodycONFIGURATIONID), required: false);
            SourceExpression.Validate(bodycRITICALLEVELID, nameof(bodycRITICALLEVELID), required: false);
            SourceExpression.Validate(bodydELIVERYDATE, nameof(bodydELIVERYDATE), required: false);
            SourceExpression.Validate(bodydELIVERYNUMBER, nameof(bodydELIVERYNUMBER), required: false);
            SourceExpression.Validate(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            SourceExpression.Validate(bodydEPRECIATIONRULEID, nameof(bodydEPRECIATIONRULEID), required: false);
            SourceExpression.Validate(bodydHARDWAREGUID, nameof(bodydHARDWAREGUID), required: false);
            SourceExpression.Validate(bodyeMPLOYEEID, nameof(bodyeMPLOYEEID), required: false);
            SourceExpression.Validate(bodyeNDOFWARANTY, nameof(bodyeNDOFWARANTY), required: false);
            SourceExpression.Validate(bodyeNTRYDATE, nameof(bodyeNTRYDATE), required: false);
            SourceExpression.Validate(bodyeSTIMATEDPERCENTAGEUSE, nameof(bodyeSTIMATEDPERCENTAGEUSE), required: false);
            SourceExpression.Validate(bodyeXPECTEDENDLENDDATE, nameof(bodyeXPECTEDENDLENDDATE), required: false);
            SourceExpression.Validate(bodyeXPECTEDRETURNDATE, nameof(bodyeXPECTEDRETURNDATE), required: false);
            SourceExpression.Validate(bodyfALLENTERM, nameof(bodyfALLENTERM), required: false);
            SourceExpression.Validate(bodyfIXEDASSETNUMBER, nameof(bodyfIXEDASSETNUMBER), required: false);
            SourceExpression.Validate(bodyiNITIALSTART, nameof(bodyiNITIALSTART), required: false);
            SourceExpression.Validate(bodyiNSTALLATIONDATE, nameof(bodyiNSTALLATIONDATE), required: false);
            SourceExpression.Validate(bodyiNTERNALDELIVERYDATE, nameof(bodyiNTERNALDELIVERYDATE), required: false);
            SourceExpression.Validate(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            SourceExpression.Validate(bodyiSDML, nameof(bodyiSDML), required: false);
            SourceExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            SourceExpression.Validate(bodylASTPHYSICALINVENTORY, nameof(bodylASTPHYSICALINVENTORY), required: false);
            SourceExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            SourceExpression.Validate(bodylICENSEVERSION, nameof(bodylICENSEVERSION), required: false);
            SourceExpression.Validate(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            SourceExpression.Validate(bodymAINTENANCECOST, nameof(bodymAINTENANCECOST), required: false);
            SourceExpression.Validate(bodymAINTENANCECOSTCURID, nameof(bodymAINTENANCECOSTCURID), required: false);
            SourceExpression.Validate(bodymAINUSAGEID, nameof(bodymAINUSAGEID), required: false);
            SourceExpression.Validate(bodymAXINSTALLS, nameof(bodymAXINSTALLS), required: false);
            SourceExpression.Validate(bodymONTHLYFIXEDCOST, nameof(bodymONTHLYFIXEDCOST), required: false);
            SourceExpression.Validate(bodymONTHLYFIXEDCOSTCURID, nameof(bodymONTHLYFIXEDCOSTCURID), required: false);
            SourceExpression.Validate(bodymONTHLYNETRENTAL, nameof(bodymONTHLYNETRENTAL), required: false);
            SourceExpression.Validate(bodymONTHLYNETRENTALCURID, nameof(bodymONTHLYNETRENTALCURID), required: false);
            SourceExpression.Validate(bodymONTHDURATION, nameof(bodymONTHDURATION), required: false);
            SourceExpression.Validate(bodynETWORKIDENTIFIER, nameof(bodynETWORKIDENTIFIER), required: false);
            SourceExpression.Validate(bodynEXTDEPARTMENTID, nameof(bodynEXTDEPARTMENTID), required: false);
            SourceExpression.Validate(bodynEXTMAINTENANCEDATE, nameof(bodynEXTMAINTENANCEDATE), required: false);
            SourceExpression.Validate(bodynEXTSTATUSID, nameof(bodynEXTSTATUSID), required: false);
            SourceExpression.Validate(bodynEXTUSERAPPLICATIONDATE, nameof(bodynEXTUSERAPPLICATIONDATE), required: false);
            SourceExpression.Validate(bodynEXTUSERID, nameof(bodynEXTUSERID), required: false);
            SourceExpression.Validate(bodynOTICE, nameof(bodynOTICE), required: false);
            SourceExpression.Validate(bodyoRDERDETAILSID, nameof(bodyoRDERDETAILSID), required: false);
            SourceExpression.Validate(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            SourceExpression.Validate(bodypIPELINESTATUSID, nameof(bodypIPELINESTATUSID), required: false);
            SourceExpression.Validate(bodypOWERCONSUMPTIONWH, nameof(bodypOWERCONSUMPTIONWH), required: false);
            SourceExpression.Validate(bodypROCESSORCOUNT, nameof(bodypROCESSORCOUNT), required: false);
            SourceExpression.Validate(bodypROCESSORSOCKETCOUNT, nameof(bodypROCESSORSOCKETCOUNT), required: false);
            SourceExpression.Validate(bodypURCHASEDATE, nameof(bodypURCHASEDATE), required: false);
            SourceExpression.Validate(bodypURCHASEPRICE, nameof(bodypURCHASEPRICE), required: false);
            SourceExpression.Validate(bodypURCHASEPRICECURID, nameof(bodypURCHASEPRICECURID), required: false);
            SourceExpression.Validate(bodypURCHASERATEID, nameof(bodypURCHASERATEID), required: false);
            SourceExpression.Validate(bodyrECYCLEDDATE, nameof(bodyrECYCLEDDATE), required: false);
            SourceExpression.Validate(bodyrECYCLINGPROVIDERID, nameof(bodyrECYCLINGPROVIDERID), required: false);
            SourceExpression.Validate(bodyrEFORMNUMBER, nameof(bodyrEFORMNUMBER), required: false);
            SourceExpression.Validate(bodyrEMOVEDDATE, nameof(bodyrEMOVEDDATE), required: false);
            SourceExpression.Validate(bodyrENEWALDECISIONID, nameof(bodyrENEWALDECISIONID), required: false);
            SourceExpression.Validate(bodyrENEWALVALUE, nameof(bodyrENEWALVALUE), required: false);
            SourceExpression.Validate(bodyrENEWALVALUECURID, nameof(bodyrENEWALVALUECURID), required: false);
            SourceExpression.Validate(bodyrEPAIREDBYID, nameof(bodyrEPAIREDBYID), required: false);
            SourceExpression.Validate(bodyrESALESVALUE, nameof(bodyrESALESVALUE), required: false);
            SourceExpression.Validate(bodysCHEDULEDEND, nameof(bodysCHEDULEDEND), required: false);
            SourceExpression.Validate(bodysDCATALOGID, nameof(bodysDCATALOGID), required: false);
            SourceExpression.Validate(bodysERIALNUMBER, nameof(bodysERIALNUMBER), required: false);
            SourceExpression.Validate(bodysLAID, nameof(bodysLAID), required: false);
            SourceExpression.Validate(bodysTATUSID, nameof(bodysTATUSID), required: false);
            SourceExpression.Validate(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            SourceExpression.Validate(bodytERM, nameof(bodytERM), required: false);
            SourceExpression.Validate(bodyuPDATECOVERAGETERM, nameof(bodyuPDATECOVERAGETERM), required: false);
            SourceExpression.Validate(bodywARANTYTYPEID, nameof(bodywARANTYTYPEID), required: false);
            SourceExpression.Validate(bodyassetLabel, nameof(bodyassetLabel), required: false);
            SourceExpression.Validate(bodyassetTag, nameof(bodyassetTag), required: false);
            SourceExpression.Validate(bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            SourceExpression.Validate(bodyavailabilitySlaId, nameof(bodyavailabilitySlaId), required: false);
            SourceExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            SourceExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            SourceExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            SourceExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            SourceExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            SourceExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            SourceExpression.Validate(bodycommentAsset, nameof(bodycommentAsset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybEFORELOANDEPARTMENTID != null)
                {
                    body["BEFORE_LOAN_DEPARTMENT_ID"] = SourceExpressionConverter.ConvertToken(bodybEFORELOANDEPARTMENTID);
                    bodypropCount++;
                }

                if (bodybEFORELOANEMPLOYEEID != null)
                {
                    body["BEFORE_LOAN_EMPLOYEE_ID"] = SourceExpressionConverter.ConvertToken(bodybEFORELOANEMPLOYEEID);
                    bodypropCount++;
                }

                if (bodybEFORELOANLOCATIONID != null)
                {
                    body["BEFORE_LOAN_LOCATION_ID"] = SourceExpressionConverter.ConvertToken(bodybEFORELOANLOCATIONID);
                    bodypropCount++;
                }

                if (bodybILLINGPERIODICITYINMONTH != null)
                {
                    body["BILLING_PERIODICITY_IN_MONTH"] = SourceExpressionConverter.ConvertToken(bodybILLINGPERIODICITYINMONTH);
                    bodypropCount++;
                }

                if (bodybUYBACKVALUE != null)
                {
                    body["BUY_BACK_VALUE"] = SourceExpressionConverter.ConvertToken(bodybUYBACKVALUE);
                    bodypropCount++;
                }

                if (bodybUYBACKVALUECURID != null)
                {
                    body["BUY_BACK_VALUE_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodybUYBACKVALUECURID);
                    bodypropCount++;
                }

                if (bodycATALOGID != null)
                {
                    body["CATALOG_ID"] = SourceExpressionConverter.ConvertToken(bodycATALOGID);
                    bodypropCount++;
                }

                if (bodycHARGEBACK != null)
                {
                    body["CHARGE_BACK"] = SourceExpressionConverter.ConvertToken(bodycHARGEBACK);
                    bodypropCount++;
                }

                if (bodycHARGEBACKCURID != null)
                {
                    body["CHARGE_BACK_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodycHARGEBACKCURID);
                    bodypropCount++;
                }

                if (bodycISTATUSID != null)
                {
                    body["CI_STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodycISTATUSID);
                    bodypropCount++;
                }

                if (bodycIVERSION != null)
                {
                    body["CI_VERSION"] = SourceExpressionConverter.ConvertToken(bodycIVERSION);
                    bodypropCount++;
                }

                if (bodycMDEFAULTCHANGEID != null)
                {
                    body["CM_DEFAULT_CHANGE_ID"] = SourceExpressionConverter.ConvertToken(bodycMDEFAULTCHANGEID);
                    bodypropCount++;
                }

                if (bodycONFIGURATIONID != null)
                {
                    body["CONFIGURATION_ID"] = SourceExpressionConverter.ConvertToken(bodycONFIGURATIONID);
                    bodypropCount++;
                }

                if (bodycRITICALLEVELID != null)
                {
                    body["CRITICAL_LEVEL_ID"] = SourceExpressionConverter.ConvertToken(bodycRITICALLEVELID);
                    bodypropCount++;
                }

                if (bodydELIVERYDATE != null)
                {
                    body["DELIVERY_DATE"] = SourceExpressionConverter.ConvertToken(bodydELIVERYDATE);
                    bodypropCount++;
                }

                if (bodydELIVERYNUMBER != null)
                {
                    body["DELIVERY_NUMBER"] = SourceExpressionConverter.ConvertToken(bodydELIVERYNUMBER);
                    bodypropCount++;
                }

                if (bodydEPARTMENTID != null)
                {
                    body["DEPARTMENT_ID"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTID);
                    bodypropCount++;
                }

                if (bodydEPRECIATIONRULEID != null)
                {
                    body["DEPRECIATION_RULE_ID"] = SourceExpressionConverter.ConvertToken(bodydEPRECIATIONRULEID);
                    bodypropCount++;
                }

                if (bodydHARDWAREGUID != null)
                {
                    body["D_HARDWARE_GUID"] = SourceExpressionConverter.ConvertToken(bodydHARDWAREGUID);
                    bodypropCount++;
                }

                if (bodyeMPLOYEEID != null)
                {
                    body["EMPLOYEE_ID"] = SourceExpressionConverter.ConvertToken(bodyeMPLOYEEID);
                    bodypropCount++;
                }

                if (bodyeNDOFWARANTY != null)
                {
                    body["END_OF_WARANTY"] = SourceExpressionConverter.ConvertToken(bodyeNDOFWARANTY);
                    bodypropCount++;
                }

                if (bodyeNTRYDATE != null)
                {
                    body["ENTRY_DATE"] = SourceExpressionConverter.ConvertToken(bodyeNTRYDATE);
                    bodypropCount++;
                }

                if (bodyeSTIMATEDPERCENTAGEUSE != null)
                {
                    body["ESTIMATED_PERCENTAGE_USE"] = SourceExpressionConverter.ConvertToken(bodyeSTIMATEDPERCENTAGEUSE);
                    bodypropCount++;
                }

                if (bodyeXPECTEDENDLENDDATE != null)
                {
                    body["EXPECTED_END_LEND_DATE"] = SourceExpressionConverter.ConvertToken(bodyeXPECTEDENDLENDDATE);
                    bodypropCount++;
                }

                if (bodyeXPECTEDRETURNDATE != null)
                {
                    body["EXPECTED_RETURN_DATE"] = SourceExpressionConverter.ConvertToken(bodyeXPECTEDRETURNDATE);
                    bodypropCount++;
                }

                if (bodyfALLENTERM != null)
                {
                    body["FALLEN_TERM"] = SourceExpressionConverter.ConvertToken(bodyfALLENTERM);
                    bodypropCount++;
                }

                if (bodyfIXEDASSETNUMBER != null)
                {
                    body["FIXED_ASSET_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyfIXEDASSETNUMBER);
                    bodypropCount++;
                }

                if (bodyiNITIALSTART != null)
                {
                    body["INITIAL_START"] = SourceExpressionConverter.ConvertToken(bodyiNITIALSTART);
                    bodypropCount++;
                }

                if (bodyiNSTALLATIONDATE != null)
                {
                    body["INSTALLATION_DATE"] = SourceExpressionConverter.ConvertToken(bodyiNSTALLATIONDATE);
                    bodypropCount++;
                }

                if (bodyiNTERNALDELIVERYDATE != null)
                {
                    body["INTERNAL_DELIVERY_DATE"] = SourceExpressionConverter.ConvertToken(bodyiNTERNALDELIVERYDATE);
                    bodypropCount++;
                }

                if (bodyiNVOICENUMBER != null)
                {
                    body["INVOICE_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyiNVOICENUMBER);
                    bodypropCount++;
                }

                if (bodyiSDML != null)
                {
                    body["IS_DML"] = SourceExpressionConverter.ConvertToken(bodyiSDML);
                    bodypropCount++;
                }

                if (bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = SourceExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (bodylASTPHYSICALINVENTORY != null)
                {
                    body["LAST_PHYSICAL_INVENTORY"] = SourceExpressionConverter.ConvertToken(bodylASTPHYSICALINVENTORY);
                    bodypropCount++;
                }

                if (bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = SourceExpressionConverter.ConvertToken(bodylASTUPDATE);
                    bodypropCount++;
                }

                if (bodylICENSEVERSION != null)
                {
                    body["LICENSE_VERSION"] = SourceExpressionConverter.ConvertToken(bodylICENSEVERSION);
                    bodypropCount++;
                }

                if (bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = SourceExpressionConverter.ConvertToken(bodylOCATIONID);
                    bodypropCount++;
                }

                if (bodymAINTENANCECOST != null)
                {
                    body["MAINTENANCE_COST"] = SourceExpressionConverter.ConvertToken(bodymAINTENANCECOST);
                    bodypropCount++;
                }

                if (bodymAINTENANCECOSTCURID != null)
                {
                    body["MAINTENANCE_COST_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodymAINTENANCECOSTCURID);
                    bodypropCount++;
                }

                if (bodymAINUSAGEID != null)
                {
                    body["MAIN_USAGE_ID"] = SourceExpressionConverter.ConvertToken(bodymAINUSAGEID);
                    bodypropCount++;
                }

                if (bodymAXINSTALLS != null)
                {
                    body["MAX_INSTALLS"] = SourceExpressionConverter.ConvertToken(bodymAXINSTALLS);
                    bodypropCount++;
                }

                if (bodymONTHLYFIXEDCOST != null)
                {
                    body["MONTHLY_FIXED_COST"] = SourceExpressionConverter.ConvertToken(bodymONTHLYFIXEDCOST);
                    bodypropCount++;
                }

                if (bodymONTHLYFIXEDCOSTCURID != null)
                {
                    body["MONTHLY_FIXED_COST_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodymONTHLYFIXEDCOSTCURID);
                    bodypropCount++;
                }

                if (bodymONTHLYNETRENTAL != null)
                {
                    body["MONTHLY_NET_RENTAL"] = SourceExpressionConverter.ConvertToken(bodymONTHLYNETRENTAL);
                    bodypropCount++;
                }

                if (bodymONTHLYNETRENTALCURID != null)
                {
                    body["MONTHLY_NET_RENTAL_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodymONTHLYNETRENTALCURID);
                    bodypropCount++;
                }

                if (bodymONTHDURATION != null)
                {
                    body["MONTH_DURATION"] = SourceExpressionConverter.ConvertToken(bodymONTHDURATION);
                    bodypropCount++;
                }

                if (bodynETWORKIDENTIFIER != null)
                {
                    body["NETWORK_IDENTIFIER"] = SourceExpressionConverter.ConvertToken(bodynETWORKIDENTIFIER);
                    bodypropCount++;
                }

                if (bodynEXTDEPARTMENTID != null)
                {
                    body["NEXT_DEPARTMENT_ID"] = SourceExpressionConverter.ConvertToken(bodynEXTDEPARTMENTID);
                    bodypropCount++;
                }

                if (bodynEXTMAINTENANCEDATE != null)
                {
                    body["NEXT_MAINTENANCE_DATE"] = SourceExpressionConverter.ConvertToken(bodynEXTMAINTENANCEDATE);
                    bodypropCount++;
                }

                if (bodynEXTSTATUSID != null)
                {
                    body["NEXT_STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodynEXTSTATUSID);
                    bodypropCount++;
                }

                if (bodynEXTUSERAPPLICATIONDATE != null)
                {
                    body["NEXT_USER_APPLICATION_DATE"] = SourceExpressionConverter.ConvertToken(bodynEXTUSERAPPLICATIONDATE);
                    bodypropCount++;
                }

                if (bodynEXTUSERID != null)
                {
                    body["NEXT_USER_ID"] = SourceExpressionConverter.ConvertToken(bodynEXTUSERID);
                    bodypropCount++;
                }

                if (bodynOTICE != null)
                {
                    body["NOTICE"] = SourceExpressionConverter.ConvertToken(bodynOTICE);
                    bodypropCount++;
                }

                if (bodyoRDERDETAILSID != null)
                {
                    body["ORDER_DETAILS_ID"] = SourceExpressionConverter.ConvertToken(bodyoRDERDETAILSID);
                    bodypropCount++;
                }

                if (bodyoRDERNUMBER != null)
                {
                    body["ORDER_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyoRDERNUMBER);
                    bodypropCount++;
                }

                if (bodypIPELINESTATUSID != null)
                {
                    body["PIPELINE_STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodypIPELINESTATUSID);
                    bodypropCount++;
                }

                if (bodypOWERCONSUMPTIONWH != null)
                {
                    body["POWER_CONSUMPTION_WH"] = SourceExpressionConverter.ConvertToken(bodypOWERCONSUMPTIONWH);
                    bodypropCount++;
                }

                if (bodypROCESSORCOUNT != null)
                {
                    body["PROCESSOR_COUNT"] = SourceExpressionConverter.ConvertToken(bodypROCESSORCOUNT);
                    bodypropCount++;
                }

                if (bodypROCESSORSOCKETCOUNT != null)
                {
                    body["PROCESSOR_SOCKET_COUNT"] = SourceExpressionConverter.ConvertToken(bodypROCESSORSOCKETCOUNT);
                    bodypropCount++;
                }

                if (bodypURCHASEDATE != null)
                {
                    body["PURCHASE_DATE"] = SourceExpressionConverter.ConvertToken(bodypURCHASEDATE);
                    bodypropCount++;
                }

                if (bodypURCHASEPRICE != null)
                {
                    body["PURCHASE_PRICE"] = SourceExpressionConverter.ConvertToken(bodypURCHASEPRICE);
                    bodypropCount++;
                }

                if (bodypURCHASEPRICECURID != null)
                {
                    body["PURCHASE_PRICE_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodypURCHASEPRICECURID);
                    bodypropCount++;
                }

                if (bodypURCHASERATEID != null)
                {
                    body["PURCHASE_RATE_ID"] = SourceExpressionConverter.ConvertToken(bodypURCHASERATEID);
                    bodypropCount++;
                }

                if (bodyrECYCLEDDATE != null)
                {
                    body["RECYCLED_DATE"] = SourceExpressionConverter.ConvertToken(bodyrECYCLEDDATE);
                    bodypropCount++;
                }

                if (bodyrECYCLINGPROVIDERID != null)
                {
                    body["RECYCLING_PROVIDER_ID"] = SourceExpressionConverter.ConvertToken(bodyrECYCLINGPROVIDERID);
                    bodypropCount++;
                }

                if (bodyrEFORMNUMBER != null)
                {
                    body["REFORM_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyrEFORMNUMBER);
                    bodypropCount++;
                }

                if (bodyrEMOVEDDATE != null)
                {
                    body["REMOVED_DATE"] = SourceExpressionConverter.ConvertToken(bodyrEMOVEDDATE);
                    bodypropCount++;
                }

                if (bodyrENEWALDECISIONID != null)
                {
                    body["RENEWAL_DECISION_ID"] = SourceExpressionConverter.ConvertToken(bodyrENEWALDECISIONID);
                    bodypropCount++;
                }

                if (bodyrENEWALVALUE != null)
                {
                    body["RENEWAL_VALUE"] = SourceExpressionConverter.ConvertToken(bodyrENEWALVALUE);
                    bodypropCount++;
                }

                if (bodyrENEWALVALUECURID != null)
                {
                    body["RENEWAL_VALUE_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodyrENEWALVALUECURID);
                    bodypropCount++;
                }

                if (bodyrEPAIREDBYID != null)
                {
                    body["REPAIRED_BY_ID"] = SourceExpressionConverter.ConvertToken(bodyrEPAIREDBYID);
                    bodypropCount++;
                }

                if (bodyrESALESVALUE != null)
                {
                    body["RESALES_VALUE"] = SourceExpressionConverter.ConvertToken(bodyrESALESVALUE);
                    bodypropCount++;
                }

                if (bodysCHEDULEDEND != null)
                {
                    body["SCHEDULED_END"] = SourceExpressionConverter.ConvertToken(bodysCHEDULEDEND);
                    bodypropCount++;
                }

                if (bodysDCATALOGID != null)
                {
                    body["SD_CATALOG_ID"] = SourceExpressionConverter.ConvertToken(bodysDCATALOGID);
                    bodypropCount++;
                }

                if (bodysERIALNUMBER != null)
                {
                    body["SERIAL_NUMBER"] = SourceExpressionConverter.ConvertToken(bodysERIALNUMBER);
                    bodypropCount++;
                }

                if (bodysLAID != null)
                {
                    body["SLA_ID"] = SourceExpressionConverter.ConvertToken(bodysLAID);
                    bodypropCount++;
                }

                if (bodysTATUSID != null)
                {
                    body["STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodysTATUSID);
                    bodypropCount++;
                }

                if (bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = SourceExpressionConverter.ConvertToken(bodysUPPLIERID);
                    bodypropCount++;
                }

                if (bodytERM != null)
                {
                    body["TERM"] = SourceExpressionConverter.ConvertToken(bodytERM);
                    bodypropCount++;
                }

                if (bodyuPDATECOVERAGETERM != null)
                {
                    body["UPDATE_COVERAGE_TERM"] = SourceExpressionConverter.ConvertToken(bodyuPDATECOVERAGETERM);
                    bodypropCount++;
                }

                if (bodywARANTYTYPEID != null)
                {
                    body["WARANTY_TYPE_ID"] = SourceExpressionConverter.ConvertToken(bodywARANTYTYPEID);
                    bodypropCount++;
                }

                if (bodyassetLabel != null)
                {
                    body["asset_label"] = SourceExpressionConverter.ConvertToken(bodyassetLabel);
                    bodypropCount++;
                }

                if (bodyassetTag != null)
                {
                    body["asset_tag"] = SourceExpressionConverter.ConvertToken(bodyassetTag);
                    bodypropCount++;
                }

                if (bodyautomaticRenewal != null)
                {
                    body["automatic_renewal"] = SourceExpressionConverter.ConvertToken(bodyautomaticRenewal);
                    bodypropCount++;
                }

                if (bodyavailabilitySlaId != null)
                {
                    body["availability_sla_id"] = SourceExpressionConverter.ConvertToken(bodyavailabilitySlaId);
                    bodypropCount++;
                }

                if (bodyavailableField1 != null)
                {
                    body["available_field_1"] = SourceExpressionConverter.ConvertToken(bodyavailableField1);
                    bodypropCount++;
                }

                if (bodyavailableField2 != null)
                {
                    body["available_field_2"] = SourceExpressionConverter.ConvertToken(bodyavailableField2);
                    bodypropCount++;
                }

                if (bodyavailableField3 != null)
                {
                    body["available_field_3"] = SourceExpressionConverter.ConvertToken(bodyavailableField3);
                    bodypropCount++;
                }

                if (bodyavailableField4 != null)
                {
                    body["available_field_4"] = SourceExpressionConverter.ConvertToken(bodyavailableField4);
                    bodypropCount++;
                }

                if (bodyavailableField5 != null)
                {
                    body["available_field_5"] = SourceExpressionConverter.ConvertToken(bodyavailableField5);
                    bodypropCount++;
                }

                if (bodyavailableField6 != null)
                {
                    body["available_field_6"] = SourceExpressionConverter.ConvertToken(bodyavailableField6);
                    bodypropCount++;
                }

                if (bodycommentAsset != null)
                {
                    body["comment_asset"] = SourceExpressionConverter.ConvertToken(bodycommentAsset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAssetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAssetLinksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            SourceExpression.Validate(bodycontractRow, nameof(bodycontractRow), required: false);
            SourceExpression.Validate(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontractRow != null)
                {
                    body["Contract_Row"] = SourceExpressionConverter.ConvertToken(bodycontractRow);
                    bodypropCount++;
                }

                if (bodymonthlyPayment != null)
                {
                    body["Monthly_Payment"] = SourceExpressionConverter.ConvertToken(bodymonthlyPayment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAssetLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            SourceExpression.Validate(bodycontractRow, nameof(bodycontractRow), required: false);
            SourceExpression.Validate(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontractRow != null)
                {
                    body["Contract_Row"] = SourceExpressionConverter.ConvertToken(bodycontractRow);
                    bodypropCount++;
                }

                if (bodymonthlyPayment != null)
                {
                    body["Monthly_Payment"] = SourceExpressionConverter.ConvertToken(bodymonthlyPayment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAssetLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> childAssetId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            SourceExpression.Validate(childAssetId, nameof(childAssetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentAssetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAssetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAssetLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogAssetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(catalogId, nameof(catalogId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogAssetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogRequestsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogRequestsPathListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(catalogId, nameof(catalogId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogRequestPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(catalogId, nameof(catalogId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewCatalogRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewConfigurationItemsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewConfigurationItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            SourceExpression.Validate(childCiId, nameof(childCiId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            SourceExpression.Validate(childCiId, nameof(childCiId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyrelationTypeID, [WorkflowExpression] Func<string> bodyblocking = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            SourceExpression.Validate(childCiId, nameof(childCiId), required: true);
            SourceExpression.Validate(bodyrelationTypeID, nameof(bodyrelationTypeID), required: true);
            SourceExpression.Validate(bodyblocking, nameof(bodyblocking), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyblocking != null)
                {
                    body["Blocking"] = SourceExpressionConverter.ConvertToken(bodyblocking);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Relation_Type_ID"] = SourceExpressionConverter.ConvertToken(bodyrelationTypeID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateConfigurationItemLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyblocking = null, [WorkflowExpression] Func<string> bodyrelationTypeID = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            SourceExpression.Validate(childCiId, nameof(childCiId), required: true);
            SourceExpression.Validate(bodyblocking, nameof(bodyblocking), required: false);
            SourceExpression.Validate(bodyrelationTypeID, nameof(bodyrelationTypeID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentCiId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyblocking != null)
                {
                    body["Blocking"] = SourceExpressionConverter.ConvertToken(bodyblocking);
                    bodypropCount++;
                }

                if (bodyrelationTypeID != null)
                {
                    body["Relation_Type_ID"] = SourceExpressionConverter.ConvertToken(bodyrelationTypeID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateConfigurationItemLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewEntitiesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> departmentId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(departmentId, nameof(departmentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(departmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewEntityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateDepartmentResponse> UpdateDepartment([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> departmentId, [WorkflowExpression] Func<string> bodypARENTDEPARTMENTID = null, [WorkflowExpression] Func<string> bodydEPARTMENTEN = null, [WorkflowExpression] Func<string> bodydEPARTMENTFR = null, [WorkflowExpression] Func<string> bodydEPARTMENTSP = null, [WorkflowExpression] Func<string> bodydEPARTMENTGE = null, [WorkflowExpression] Func<string> bodydEPARTMENTIT = null, [WorkflowExpression] Func<string> bodydEPARTMENTPO = null, [WorkflowExpression] Func<string> bodydEPARTMENTLABEL = null, [WorkflowExpression] Func<string> bodycOMMENTDEPARTMENT = null, [WorkflowExpression] Func<string> bodymANAGERID = null, [WorkflowExpression] Func<string> bodydEFAULTCOSTCENTERID = null, [WorkflowExpression] Func<string> bodysTARTDATE = null, [WorkflowExpression] Func<string> bodyeNDDATE = null, [WorkflowExpression] Func<string> bodyuRLMAP = null, [WorkflowExpression] Func<string> bodydEPARTMENTCODE = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodycURRENCYID = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodysLAID = null, [WorkflowExpression] Func<string> bodydEPARTMENTL1 = null, [WorkflowExpression] Func<string> bodydEPARTMENTL2 = null, [WorkflowExpression] Func<string> bodydEPARTMENTL3 = null, [WorkflowExpression] Func<string> bodydEPARTMENTL4 = null, [WorkflowExpression] Func<string> bodydEPARTMENTL5 = null, [WorkflowExpression] Func<string> bodydEPARTMENTL6 = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(departmentId, nameof(departmentId), required: true);
            SourceExpression.Validate(bodypARENTDEPARTMENTID, nameof(bodypARENTDEPARTMENTID), required: false);
            SourceExpression.Validate(bodydEPARTMENTEN, nameof(bodydEPARTMENTEN), required: false);
            SourceExpression.Validate(bodydEPARTMENTFR, nameof(bodydEPARTMENTFR), required: false);
            SourceExpression.Validate(bodydEPARTMENTSP, nameof(bodydEPARTMENTSP), required: false);
            SourceExpression.Validate(bodydEPARTMENTGE, nameof(bodydEPARTMENTGE), required: false);
            SourceExpression.Validate(bodydEPARTMENTIT, nameof(bodydEPARTMENTIT), required: false);
            SourceExpression.Validate(bodydEPARTMENTPO, nameof(bodydEPARTMENTPO), required: false);
            SourceExpression.Validate(bodydEPARTMENTLABEL, nameof(bodydEPARTMENTLABEL), required: false);
            SourceExpression.Validate(bodycOMMENTDEPARTMENT, nameof(bodycOMMENTDEPARTMENT), required: false);
            SourceExpression.Validate(bodymANAGERID, nameof(bodymANAGERID), required: false);
            SourceExpression.Validate(bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            SourceExpression.Validate(bodysTARTDATE, nameof(bodysTARTDATE), required: false);
            SourceExpression.Validate(bodyeNDDATE, nameof(bodyeNDDATE), required: false);
            SourceExpression.Validate(bodyuRLMAP, nameof(bodyuRLMAP), required: false);
            SourceExpression.Validate(bodydEPARTMENTCODE, nameof(bodydEPARTMENTCODE), required: false);
            SourceExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            SourceExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            SourceExpression.Validate(bodycURRENCYID, nameof(bodycURRENCYID), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            SourceExpression.Validate(bodysLAID, nameof(bodysLAID), required: false);
            SourceExpression.Validate(bodydEPARTMENTL1, nameof(bodydEPARTMENTL1), required: false);
            SourceExpression.Validate(bodydEPARTMENTL2, nameof(bodydEPARTMENTL2), required: false);
            SourceExpression.Validate(bodydEPARTMENTL3, nameof(bodydEPARTMENTL3), required: false);
            SourceExpression.Validate(bodydEPARTMENTL4, nameof(bodydEPARTMENTL4), required: false);
            SourceExpression.Validate(bodydEPARTMENTL5, nameof(bodydEPARTMENTL5), required: false);
            SourceExpression.Validate(bodydEPARTMENTL6, nameof(bodydEPARTMENTL6), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(departmentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypARENTDEPARTMENTID != null)
                {
                    body["PARENT_DEPARTMENT_ID"] = SourceExpressionConverter.ConvertToken(bodypARENTDEPARTMENTID);
                    bodypropCount++;
                }

                if (bodydEPARTMENTEN != null)
                {
                    body["DEPARTMENT_EN"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTEN);
                    bodypropCount++;
                }

                if (bodydEPARTMENTFR != null)
                {
                    body["DEPARTMENT_FR"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTFR);
                    bodypropCount++;
                }

                if (bodydEPARTMENTSP != null)
                {
                    body["DEPARTMENT_SP"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTSP);
                    bodypropCount++;
                }

                if (bodydEPARTMENTGE != null)
                {
                    body["DEPARTMENT_GE"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTGE);
                    bodypropCount++;
                }

                if (bodydEPARTMENTIT != null)
                {
                    body["DEPARTMENT_IT"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTIT);
                    bodypropCount++;
                }

                if (bodydEPARTMENTPO != null)
                {
                    body["DEPARTMENT_PO"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTPO);
                    bodypropCount++;
                }

                if (bodydEPARTMENTLABEL != null)
                {
                    body["DEPARTMENT_LABEL"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTLABEL);
                    bodypropCount++;
                }

                if (bodycOMMENTDEPARTMENT != null)
                {
                    body["COMMENT_DEPARTMENT"] = SourceExpressionConverter.ConvertToken(bodycOMMENTDEPARTMENT);
                    bodypropCount++;
                }

                if (bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = SourceExpressionConverter.ConvertToken(bodymANAGERID);
                    bodypropCount++;
                }

                if (bodydEFAULTCOSTCENTERID != null)
                {
                    body["DEFAULT_COST_CENTER_ID"] = SourceExpressionConverter.ConvertToken(bodydEFAULTCOSTCENTERID);
                    bodypropCount++;
                }

                if (bodysTARTDATE != null)
                {
                    body["START_DATE"] = SourceExpressionConverter.ConvertToken(bodysTARTDATE);
                    bodypropCount++;
                }

                if (bodyeNDDATE != null)
                {
                    body["END_DATE"] = SourceExpressionConverter.ConvertToken(bodyeNDDATE);
                    bodypropCount++;
                }

                if (bodyuRLMAP != null)
                {
                    body["URL_MAP"] = SourceExpressionConverter.ConvertToken(bodyuRLMAP);
                    bodypropCount++;
                }

                if (bodydEPARTMENTCODE != null)
                {
                    body["DEPARTMENT_CODE"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTCODE);
                    bodypropCount++;
                }

                if (bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = SourceExpressionConverter.ConvertToken(bodylASTUPDATE);
                    bodypropCount++;
                }

                if (bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = SourceExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (bodycURRENCYID != null)
                {
                    body["CURRENCY_ID"] = SourceExpressionConverter.ConvertToken(bodycURRENCYID);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (bodysLAID != null)
                {
                    body["SLA_ID"] = SourceExpressionConverter.ConvertToken(bodysLAID);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL1 != null)
                {
                    body["DEPARTMENT_L1"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL1);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL2 != null)
                {
                    body["DEPARTMENT_L2"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL2);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL3 != null)
                {
                    body["DEPARTMENT_L3"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL3);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL4 != null)
                {
                    body["DEPARTMENT_L4"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL4);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL5 != null)
                {
                    body["DEPARTMENT_L5"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL5);
                    bodypropCount++;
                }

                if (bodydEPARTMENTL6 != null)
                {
                    body["DEPARTMENT_L6"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTL6);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDepartmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewEmployeesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyemployeesInputItem[]> bodyemployees = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(bodyemployees, nameof(bodyemployees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemployees != null)
                {
                    body["employees"] = SourceExpressionConverter.ConvertToken(bodyemployees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEmployeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> employeeId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(employeeId, nameof(employeeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(employeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewEmployeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> bodyaPPROVEDTOVALIDATE = null, [WorkflowExpression] Func<string> bodyaVAILABILITYSTATUSID = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodybEGINOFCONTRACT = null, [WorkflowExpression] Func<string> bodycELLULARNUMBER = null, [WorkflowExpression] Func<string> bodycHATLOGIN = null, [WorkflowExpression] Func<string> bodycIVILSTATUSID = null, [WorkflowExpression] Func<string> bodycOMMENTEMPLOYEE = null, [WorkflowExpression] Func<string> bodycOSTPERHOUR = null, [WorkflowExpression] Func<string> bodycOSTPERHOURCURID = null, [WorkflowExpression] Func<string> bodydEFAULTCOSTCENTERID = null, [WorkflowExpression] Func<string> bodydELEGATIONFROM = null, [WorkflowExpression] Func<string> bodydELEGATIONID = null, [WorkflowExpression] Func<string> bodydELEGATIONTO = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodyeNDOFCONTRACT = null, [WorkflowExpression] Func<string> bodyeMAIL = null, [WorkflowExpression] Func<string> bodyfAXNUMBER = null, [WorkflowExpression] Func<string> bodyfUNCTIONID = null, [WorkflowExpression] Func<string> bodyiCQNUMBER = null, [WorkflowExpression] Func<string> bodyiDENTIFICATION = null, [WorkflowExpression] Func<string> bodyiSAUTOMATICSTATUS = null, [WorkflowExpression] Func<string> bodyiTCORRESPONDENT = null, [WorkflowExpression] Func<string> bodylANGUAGEID = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTNAME = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodylOGIN = null, [WorkflowExpression] Func<string> bodymANAGERID = null, [WorkflowExpression] Func<string> bodymESSENGERSIGNNAME = null, [WorkflowExpression] Func<string> bodynOTIFICATIONTYPEID = null, [WorkflowExpression] Func<string> bodypASSWDLASTUPDATEUT = null, [WorkflowExpression] Func<string> bodypHONENUMBER = null, [WorkflowExpression] Func<string> bodypICTUREPATH = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodyvALIDATORID = null, [WorkflowExpression] Func<string> bodyvIPLEVELID = null, [WorkflowExpression] Func<string> bodywAVEADDRESS = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(employeeId, nameof(employeeId), required: true);
            SourceExpression.Validate(bodyaPPROVEDTOVALIDATE, nameof(bodyaPPROVEDTOVALIDATE), required: false);
            SourceExpression.Validate(bodyaVAILABILITYSTATUSID, nameof(bodyaVAILABILITYSTATUSID), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            SourceExpression.Validate(bodybEGINOFCONTRACT, nameof(bodybEGINOFCONTRACT), required: false);
            SourceExpression.Validate(bodycELLULARNUMBER, nameof(bodycELLULARNUMBER), required: false);
            SourceExpression.Validate(bodycHATLOGIN, nameof(bodycHATLOGIN), required: false);
            SourceExpression.Validate(bodycIVILSTATUSID, nameof(bodycIVILSTATUSID), required: false);
            SourceExpression.Validate(bodycOMMENTEMPLOYEE, nameof(bodycOMMENTEMPLOYEE), required: false);
            SourceExpression.Validate(bodycOSTPERHOUR, nameof(bodycOSTPERHOUR), required: false);
            SourceExpression.Validate(bodycOSTPERHOURCURID, nameof(bodycOSTPERHOURCURID), required: false);
            SourceExpression.Validate(bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            SourceExpression.Validate(bodydELEGATIONFROM, nameof(bodydELEGATIONFROM), required: false);
            SourceExpression.Validate(bodydELEGATIONID, nameof(bodydELEGATIONID), required: false);
            SourceExpression.Validate(bodydELEGATIONTO, nameof(bodydELEGATIONTO), required: false);
            SourceExpression.Validate(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            SourceExpression.Validate(bodyeNDOFCONTRACT, nameof(bodyeNDOFCONTRACT), required: false);
            SourceExpression.Validate(bodyeMAIL, nameof(bodyeMAIL), required: false);
            SourceExpression.Validate(bodyfAXNUMBER, nameof(bodyfAXNUMBER), required: false);
            SourceExpression.Validate(bodyfUNCTIONID, nameof(bodyfUNCTIONID), required: false);
            SourceExpression.Validate(bodyiCQNUMBER, nameof(bodyiCQNUMBER), required: false);
            SourceExpression.Validate(bodyiDENTIFICATION, nameof(bodyiDENTIFICATION), required: false);
            SourceExpression.Validate(bodyiSAUTOMATICSTATUS, nameof(bodyiSAUTOMATICSTATUS), required: false);
            SourceExpression.Validate(bodyiTCORRESPONDENT, nameof(bodyiTCORRESPONDENT), required: false);
            SourceExpression.Validate(bodylANGUAGEID, nameof(bodylANGUAGEID), required: false);
            SourceExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            SourceExpression.Validate(bodylASTNAME, nameof(bodylASTNAME), required: false);
            SourceExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            SourceExpression.Validate(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            SourceExpression.Validate(bodylOGIN, nameof(bodylOGIN), required: false);
            SourceExpression.Validate(bodymANAGERID, nameof(bodymANAGERID), required: false);
            SourceExpression.Validate(bodymESSENGERSIGNNAME, nameof(bodymESSENGERSIGNNAME), required: false);
            SourceExpression.Validate(bodynOTIFICATIONTYPEID, nameof(bodynOTIFICATIONTYPEID), required: false);
            SourceExpression.Validate(bodypASSWDLASTUPDATEUT, nameof(bodypASSWDLASTUPDATEUT), required: false);
            SourceExpression.Validate(bodypHONENUMBER, nameof(bodypHONENUMBER), required: false);
            SourceExpression.Validate(bodypICTUREPATH, nameof(bodypICTUREPATH), required: false);
            SourceExpression.Validate(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            SourceExpression.Validate(bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            SourceExpression.Validate(bodyvIPLEVELID, nameof(bodyvIPLEVELID), required: false);
            SourceExpression.Validate(bodywAVEADDRESS, nameof(bodywAVEADDRESS), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(employeeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaPPROVEDTOVALIDATE != null)
                {
                    body["APPROVED_TO_VALIDATE"] = SourceExpressionConverter.ConvertToken(bodyaPPROVEDTOVALIDATE);
                    bodypropCount++;
                }

                if (bodyaVAILABILITYSTATUSID != null)
                {
                    body["AVAILABILITY_STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodyaVAILABILITYSTATUSID);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (bodybEGINOFCONTRACT != null)
                {
                    body["BEGIN_OF_CONTRACT"] = SourceExpressionConverter.ConvertToken(bodybEGINOFCONTRACT);
                    bodypropCount++;
                }

                if (bodycELLULARNUMBER != null)
                {
                    body["CELLULAR_NUMBER"] = SourceExpressionConverter.ConvertToken(bodycELLULARNUMBER);
                    bodypropCount++;
                }

                if (bodycHATLOGIN != null)
                {
                    body["CHAT_LOGIN"] = SourceExpressionConverter.ConvertToken(bodycHATLOGIN);
                    bodypropCount++;
                }

                if (bodycIVILSTATUSID != null)
                {
                    body["CIVIL_STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodycIVILSTATUSID);
                    bodypropCount++;
                }

                if (bodycOMMENTEMPLOYEE != null)
                {
                    body["COMMENT_EMPLOYEE"] = SourceExpressionConverter.ConvertToken(bodycOMMENTEMPLOYEE);
                    bodypropCount++;
                }

                if (bodycOSTPERHOUR != null)
                {
                    body["COST_PER_HOUR"] = SourceExpressionConverter.ConvertToken(bodycOSTPERHOUR);
                    bodypropCount++;
                }

                if (bodycOSTPERHOURCURID != null)
                {
                    body["COST_PER_HOUR_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodycOSTPERHOURCURID);
                    bodypropCount++;
                }

                if (bodydEFAULTCOSTCENTERID != null)
                {
                    body["DEFAULT_COST_CENTER_ID"] = SourceExpressionConverter.ConvertToken(bodydEFAULTCOSTCENTERID);
                    bodypropCount++;
                }

                if (bodydELEGATIONFROM != null)
                {
                    body["DELEGATION_FROM"] = SourceExpressionConverter.ConvertToken(bodydELEGATIONFROM);
                    bodypropCount++;
                }

                if (bodydELEGATIONID != null)
                {
                    body["DELEGATION_ID"] = SourceExpressionConverter.ConvertToken(bodydELEGATIONID);
                    bodypropCount++;
                }

                if (bodydELEGATIONTO != null)
                {
                    body["DELEGATION_TO"] = SourceExpressionConverter.ConvertToken(bodydELEGATIONTO);
                    bodypropCount++;
                }

                if (bodydEPARTMENTID != null)
                {
                    body["DEPARTMENT_ID"] = SourceExpressionConverter.ConvertToken(bodydEPARTMENTID);
                    bodypropCount++;
                }

                if (bodyeNDOFCONTRACT != null)
                {
                    body["END_OF_CONTRACT"] = SourceExpressionConverter.ConvertToken(bodyeNDOFCONTRACT);
                    bodypropCount++;
                }

                if (bodyeMAIL != null)
                {
                    body["E_MAIL"] = SourceExpressionConverter.ConvertToken(bodyeMAIL);
                    bodypropCount++;
                }

                if (bodyfAXNUMBER != null)
                {
                    body["FAX_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyfAXNUMBER);
                    bodypropCount++;
                }

                if (bodyfUNCTIONID != null)
                {
                    body["FUNCTION_ID"] = SourceExpressionConverter.ConvertToken(bodyfUNCTIONID);
                    bodypropCount++;
                }

                if (bodyiCQNUMBER != null)
                {
                    body["ICQ_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyiCQNUMBER);
                    bodypropCount++;
                }

                if (bodyiDENTIFICATION != null)
                {
                    body["IDENTIFICATION"] = SourceExpressionConverter.ConvertToken(bodyiDENTIFICATION);
                    bodypropCount++;
                }

                if (bodyiSAUTOMATICSTATUS != null)
                {
                    body["IS_AUTOMATIC_STATUS"] = SourceExpressionConverter.ConvertToken(bodyiSAUTOMATICSTATUS);
                    bodypropCount++;
                }

                if (bodyiTCORRESPONDENT != null)
                {
                    body["IT_CORRESPONDENT"] = SourceExpressionConverter.ConvertToken(bodyiTCORRESPONDENT);
                    bodypropCount++;
                }

                if (bodylANGUAGEID != null)
                {
                    body["LANGUAGE_ID"] = SourceExpressionConverter.ConvertToken(bodylANGUAGEID);
                    bodypropCount++;
                }

                if (bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = SourceExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (bodylASTNAME != null)
                {
                    body["LAST_NAME"] = SourceExpressionConverter.ConvertToken(bodylASTNAME);
                    bodypropCount++;
                }

                if (bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = SourceExpressionConverter.ConvertToken(bodylASTUPDATE);
                    bodypropCount++;
                }

                if (bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = SourceExpressionConverter.ConvertToken(bodylOCATIONID);
                    bodypropCount++;
                }

                if (bodylOGIN != null)
                {
                    body["LOGIN"] = SourceExpressionConverter.ConvertToken(bodylOGIN);
                    bodypropCount++;
                }

                if (bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = SourceExpressionConverter.ConvertToken(bodymANAGERID);
                    bodypropCount++;
                }

                if (bodymESSENGERSIGNNAME != null)
                {
                    body["MESSENGER_SIGN_NAME"] = SourceExpressionConverter.ConvertToken(bodymESSENGERSIGNNAME);
                    bodypropCount++;
                }

                if (bodynOTIFICATIONTYPEID != null)
                {
                    body["NOTIFICATION_TYPE_ID"] = SourceExpressionConverter.ConvertToken(bodynOTIFICATIONTYPEID);
                    bodypropCount++;
                }

                if (bodypASSWDLASTUPDATEUT != null)
                {
                    body["PASSWD_LAST_UPDATE_UT"] = SourceExpressionConverter.ConvertToken(bodypASSWDLASTUPDATEUT);
                    bodypropCount++;
                }

                if (bodypHONENUMBER != null)
                {
                    body["PHONE_NUMBER"] = SourceExpressionConverter.ConvertToken(bodypHONENUMBER);
                    bodypropCount++;
                }

                if (bodypICTUREPATH != null)
                {
                    body["PICTURE_PATH"] = SourceExpressionConverter.ConvertToken(bodypICTUREPATH);
                    bodypropCount++;
                }

                if (bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = SourceExpressionConverter.ConvertToken(bodysUPPLIERID);
                    bodypropCount++;
                }

                if (bodyvALIDATORID != null)
                {
                    body["VALIDATOR_ID"] = SourceExpressionConverter.ConvertToken(bodyvALIDATORID);
                    bodypropCount++;
                }

                if (bodyvIPLEVELID != null)
                {
                    body["VIP_LEVEL_ID"] = SourceExpressionConverter.ConvertToken(bodyvIPLEVELID);
                    bodypropCount++;
                }

                if (bodywAVEADDRESS != null)
                {
                    body["WAVE_ADDRESS"] = SourceExpressionConverter.ConvertToken(bodywAVEADDRESS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEmployeeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewKnownErrorsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> kpId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(kpId, nameof(kpId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/knownerrors/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(kpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewKnownErrorsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewLocationsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> locationId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateLocationResponse> UpdateLocation([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> locationId, [WorkflowExpression] Func<string> bodypARENTLOCATIONID = null, [WorkflowExpression] Func<string> bodymANAGERID = null, [WorkflowExpression] Func<string> bodylOCATIONEN = null, [WorkflowExpression] Func<string> bodylOCATIONFR = null, [WorkflowExpression] Func<string> bodylOCATIONGE = null, [WorkflowExpression] Func<string> bodylOCATIONSP = null, [WorkflowExpression] Func<string> bodylOCATIONIT = null, [WorkflowExpression] Func<string> bodylOCATIONPO = null, [WorkflowExpression] Func<string> bodysTREETADDRESS1 = null, [WorkflowExpression] Func<string> bodysTREETADDRESS2 = null, [WorkflowExpression] Func<string> bodycITY = null, [WorkflowExpression] Func<string> bodypHONE = null, [WorkflowExpression] Func<string> bodyzIPCODE = null, [WorkflowExpression] Func<string> bodyfAX = null, [WorkflowExpression] Func<string> bodycOMMENTLOCATION = null, [WorkflowExpression] Func<string> bodyrEGIONZONEID = null, [WorkflowExpression] Func<string> bodycOUNTRYID = null, [WorkflowExpression] Func<string> bodysTATEID = null, [WorkflowExpression] Func<string> bodysTARTDATE = null, [WorkflowExpression] Func<string> bodyeNDDATE = null, [WorkflowExpression] Func<string> bodyuRLMAP = null, [WorkflowExpression] Func<string> bodydISCOVERYNAME = null, [WorkflowExpression] Func<string> bodylOCATIONCODE = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodyiSDELIVERYADDRESS = null, [WorkflowExpression] Func<string> bodytIMEZONEID = null, [WorkflowExpression] Func<string> bodysTATUSID = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodysLAID = null, [WorkflowExpression] Func<string> bodygMAPLAT = null, [WorkflowExpression] Func<string> bodygMAPLNG = null, [WorkflowExpression] Func<string> bodylOCATIONL1 = null, [WorkflowExpression] Func<string> bodylOCATIONL2 = null, [WorkflowExpression] Func<string> bodylOCATIONL3 = null, [WorkflowExpression] Func<string> bodylOCATIONL4 = null, [WorkflowExpression] Func<string> bodylOCATIONL5 = null, [WorkflowExpression] Func<string> bodylOCATIONL6 = null, [WorkflowExpression] Func<string> bodyeISMEETINGROOM = null, [WorkflowExpression] Func<string> bodyeCAPACITY = null, [WorkflowExpression] Func<string> bodyeWIFILOGIN = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            SourceExpression.Validate(bodypARENTLOCATIONID, nameof(bodypARENTLOCATIONID), required: false);
            SourceExpression.Validate(bodymANAGERID, nameof(bodymANAGERID), required: false);
            SourceExpression.Validate(bodylOCATIONEN, nameof(bodylOCATIONEN), required: false);
            SourceExpression.Validate(bodylOCATIONFR, nameof(bodylOCATIONFR), required: false);
            SourceExpression.Validate(bodylOCATIONGE, nameof(bodylOCATIONGE), required: false);
            SourceExpression.Validate(bodylOCATIONSP, nameof(bodylOCATIONSP), required: false);
            SourceExpression.Validate(bodylOCATIONIT, nameof(bodylOCATIONIT), required: false);
            SourceExpression.Validate(bodylOCATIONPO, nameof(bodylOCATIONPO), required: false);
            SourceExpression.Validate(bodysTREETADDRESS1, nameof(bodysTREETADDRESS1), required: false);
            SourceExpression.Validate(bodysTREETADDRESS2, nameof(bodysTREETADDRESS2), required: false);
            SourceExpression.Validate(bodycITY, nameof(bodycITY), required: false);
            SourceExpression.Validate(bodypHONE, nameof(bodypHONE), required: false);
            SourceExpression.Validate(bodyzIPCODE, nameof(bodyzIPCODE), required: false);
            SourceExpression.Validate(bodyfAX, nameof(bodyfAX), required: false);
            SourceExpression.Validate(bodycOMMENTLOCATION, nameof(bodycOMMENTLOCATION), required: false);
            SourceExpression.Validate(bodyrEGIONZONEID, nameof(bodyrEGIONZONEID), required: false);
            SourceExpression.Validate(bodycOUNTRYID, nameof(bodycOUNTRYID), required: false);
            SourceExpression.Validate(bodysTATEID, nameof(bodysTATEID), required: false);
            SourceExpression.Validate(bodysTARTDATE, nameof(bodysTARTDATE), required: false);
            SourceExpression.Validate(bodyeNDDATE, nameof(bodyeNDDATE), required: false);
            SourceExpression.Validate(bodyuRLMAP, nameof(bodyuRLMAP), required: false);
            SourceExpression.Validate(bodydISCOVERYNAME, nameof(bodydISCOVERYNAME), required: false);
            SourceExpression.Validate(bodylOCATIONCODE, nameof(bodylOCATIONCODE), required: false);
            SourceExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            SourceExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            SourceExpression.Validate(bodyiSDELIVERYADDRESS, nameof(bodyiSDELIVERYADDRESS), required: false);
            SourceExpression.Validate(bodytIMEZONEID, nameof(bodytIMEZONEID), required: false);
            SourceExpression.Validate(bodysTATUSID, nameof(bodysTATUSID), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            SourceExpression.Validate(bodysLAID, nameof(bodysLAID), required: false);
            SourceExpression.Validate(bodygMAPLAT, nameof(bodygMAPLAT), required: false);
            SourceExpression.Validate(bodygMAPLNG, nameof(bodygMAPLNG), required: false);
            SourceExpression.Validate(bodylOCATIONL1, nameof(bodylOCATIONL1), required: false);
            SourceExpression.Validate(bodylOCATIONL2, nameof(bodylOCATIONL2), required: false);
            SourceExpression.Validate(bodylOCATIONL3, nameof(bodylOCATIONL3), required: false);
            SourceExpression.Validate(bodylOCATIONL4, nameof(bodylOCATIONL4), required: false);
            SourceExpression.Validate(bodylOCATIONL5, nameof(bodylOCATIONL5), required: false);
            SourceExpression.Validate(bodylOCATIONL6, nameof(bodylOCATIONL6), required: false);
            SourceExpression.Validate(bodyeISMEETINGROOM, nameof(bodyeISMEETINGROOM), required: false);
            SourceExpression.Validate(bodyeCAPACITY, nameof(bodyeCAPACITY), required: false);
            SourceExpression.Validate(bodyeWIFILOGIN, nameof(bodyeWIFILOGIN), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypARENTLOCATIONID != null)
                {
                    body["PARENT_LOCATION_ID"] = SourceExpressionConverter.ConvertToken(bodypARENTLOCATIONID);
                    bodypropCount++;
                }

                if (bodymANAGERID != null)
                {
                    body["MANAGER_ID"] = SourceExpressionConverter.ConvertToken(bodymANAGERID);
                    bodypropCount++;
                }

                if (bodylOCATIONEN != null)
                {
                    body["LOCATION_EN"] = SourceExpressionConverter.ConvertToken(bodylOCATIONEN);
                    bodypropCount++;
                }

                if (bodylOCATIONFR != null)
                {
                    body["LOCATION_FR"] = SourceExpressionConverter.ConvertToken(bodylOCATIONFR);
                    bodypropCount++;
                }

                if (bodylOCATIONGE != null)
                {
                    body["LOCATION_GE"] = SourceExpressionConverter.ConvertToken(bodylOCATIONGE);
                    bodypropCount++;
                }

                if (bodylOCATIONSP != null)
                {
                    body["LOCATION_SP"] = SourceExpressionConverter.ConvertToken(bodylOCATIONSP);
                    bodypropCount++;
                }

                if (bodylOCATIONIT != null)
                {
                    body["LOCATION_IT"] = SourceExpressionConverter.ConvertToken(bodylOCATIONIT);
                    bodypropCount++;
                }

                if (bodylOCATIONPO != null)
                {
                    body["LOCATION_PO"] = SourceExpressionConverter.ConvertToken(bodylOCATIONPO);
                    bodypropCount++;
                }

                if (bodysTREETADDRESS1 != null)
                {
                    body["STREET_ADDRESS_1"] = SourceExpressionConverter.ConvertToken(bodysTREETADDRESS1);
                    bodypropCount++;
                }

                if (bodysTREETADDRESS2 != null)
                {
                    body["STREET_ADDRESS_2"] = SourceExpressionConverter.ConvertToken(bodysTREETADDRESS2);
                    bodypropCount++;
                }

                if (bodycITY != null)
                {
                    body["CITY"] = SourceExpressionConverter.ConvertToken(bodycITY);
                    bodypropCount++;
                }

                if (bodypHONE != null)
                {
                    body["PHONE"] = SourceExpressionConverter.ConvertToken(bodypHONE);
                    bodypropCount++;
                }

                if (bodyzIPCODE != null)
                {
                    body["ZIP_CODE"] = SourceExpressionConverter.ConvertToken(bodyzIPCODE);
                    bodypropCount++;
                }

                if (bodyfAX != null)
                {
                    body["FAX"] = SourceExpressionConverter.ConvertToken(bodyfAX);
                    bodypropCount++;
                }

                if (bodycOMMENTLOCATION != null)
                {
                    body["COMMENT_LOCATION"] = SourceExpressionConverter.ConvertToken(bodycOMMENTLOCATION);
                    bodypropCount++;
                }

                if (bodyrEGIONZONEID != null)
                {
                    body["REGION_ZONE_ID"] = SourceExpressionConverter.ConvertToken(bodyrEGIONZONEID);
                    bodypropCount++;
                }

                if (bodycOUNTRYID != null)
                {
                    body["COUNTRY_ID"] = SourceExpressionConverter.ConvertToken(bodycOUNTRYID);
                    bodypropCount++;
                }

                if (bodysTATEID != null)
                {
                    body["STATE_ID"] = SourceExpressionConverter.ConvertToken(bodysTATEID);
                    bodypropCount++;
                }

                if (bodysTARTDATE != null)
                {
                    body["START_DATE"] = SourceExpressionConverter.ConvertToken(bodysTARTDATE);
                    bodypropCount++;
                }

                if (bodyeNDDATE != null)
                {
                    body["END_DATE"] = SourceExpressionConverter.ConvertToken(bodyeNDDATE);
                    bodypropCount++;
                }

                if (bodyuRLMAP != null)
                {
                    body["URL_MAP"] = SourceExpressionConverter.ConvertToken(bodyuRLMAP);
                    bodypropCount++;
                }

                if (bodydISCOVERYNAME != null)
                {
                    body["DISCOVERY_NAME"] = SourceExpressionConverter.ConvertToken(bodydISCOVERYNAME);
                    bodypropCount++;
                }

                if (bodylOCATIONCODE != null)
                {
                    body["LOCATION_CODE"] = SourceExpressionConverter.ConvertToken(bodylOCATIONCODE);
                    bodypropCount++;
                }

                if (bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = SourceExpressionConverter.ConvertToken(bodylASTUPDATE);
                    bodypropCount++;
                }

                if (bodylASTINTEGRATION != null)
                {
                    body["LAST_INTEGRATION"] = SourceExpressionConverter.ConvertToken(bodylASTINTEGRATION);
                    bodypropCount++;
                }

                if (bodyiSDELIVERYADDRESS != null)
                {
                    body["IS_DELIVERY_ADDRESS"] = SourceExpressionConverter.ConvertToken(bodyiSDELIVERYADDRESS);
                    bodypropCount++;
                }

                if (bodytIMEZONEID != null)
                {
                    body["TIME_ZONE_ID"] = SourceExpressionConverter.ConvertToken(bodytIMEZONEID);
                    bodypropCount++;
                }

                if (bodysTATUSID != null)
                {
                    body["STATUS_ID"] = SourceExpressionConverter.ConvertToken(bodysTATUSID);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (bodysLAID != null)
                {
                    body["SLA_ID"] = SourceExpressionConverter.ConvertToken(bodysLAID);
                    bodypropCount++;
                }

                if (bodygMAPLAT != null)
                {
                    body["G_MAP_LAT"] = SourceExpressionConverter.ConvertToken(bodygMAPLAT);
                    bodypropCount++;
                }

                if (bodygMAPLNG != null)
                {
                    body["G_MAP_LNG"] = SourceExpressionConverter.ConvertToken(bodygMAPLNG);
                    bodypropCount++;
                }

                if (bodylOCATIONL1 != null)
                {
                    body["LOCATION_L1"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL1);
                    bodypropCount++;
                }

                if (bodylOCATIONL2 != null)
                {
                    body["LOCATION_L2"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL2);
                    bodypropCount++;
                }

                if (bodylOCATIONL3 != null)
                {
                    body["LOCATION_L3"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL3);
                    bodypropCount++;
                }

                if (bodylOCATIONL4 != null)
                {
                    body["LOCATION_L4"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL4);
                    bodypropCount++;
                }

                if (bodylOCATIONL5 != null)
                {
                    body["LOCATION_L5"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL5);
                    bodypropCount++;
                }

                if (bodylOCATIONL6 != null)
                {
                    body["LOCATION_L6"] = SourceExpressionConverter.ConvertToken(bodylOCATIONL6);
                    bodypropCount++;
                }

                if (bodyeISMEETINGROOM != null)
                {
                    body["E_IS_MEETING_ROOM"] = SourceExpressionConverter.ConvertToken(bodyeISMEETINGROOM);
                    bodypropCount++;
                }

                if (bodyeCAPACITY != null)
                {
                    body["E_CAPACITY"] = SourceExpressionConverter.ConvertToken(bodyeCAPACITY);
                    bodypropCount++;
                }

                if (bodyeWIFILOGIN != null)
                {
                    body["E_WIFI_LOGIN"] = SourceExpressionConverter.ConvertToken(bodyeWIFILOGIN);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewManufacturerListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> manufacturerId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(manufacturerId, nameof(manufacturerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(manufacturerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewManufacturerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewRequestsIncidentsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(bodyrequests, nameof(bodyrequests), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequests != null)
                {
                    body["requests"] = SourceExpressionConverter.ConvertToken(bodyrequests);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodyclosedInputItem[]> bodyclosed = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodyclosed, nameof(bodyclosed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclosed != null)
                {
                    body["closed"] = SourceExpressionConverter.ConvertToken(bodyclosed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyanalyticalChargeId = null, [WorkflowExpression] Func<string> bodyassetId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodybudgetPlanned = null, [WorkflowExpression] Func<string> bodycanBeDuplicated = null, [WorkflowExpression] Func<string> bodyciId = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontinuityPlanId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydelay = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydynamicDetails = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateEnd = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateStart = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodyestimatedNetPrice = null, [WorkflowExpression] Func<string> bodyexpectedDateUt = null, [WorkflowExpression] Func<string> bodyexpectedDuration = null, [WorkflowExpression] Func<string> bodyexpectedEndDateUt = null, [WorkflowExpression] Func<string> bodyexpectedStartDateUt = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyfirstCallResolution = null, [WorkflowExpression] Func<string> bodyhourPerDay = null, [WorkflowExpression] Func<string> bodyimpactId = null, [WorkflowExpression] Func<string> bodyimputationDate = null, [WorkflowExpression] Func<string> bodyisMajorIncident = null, [WorkflowExpression] Func<string> bodyisTemplate = null, [WorkflowExpression] Func<string> bodyknownProblemsId = null, [WorkflowExpression] Func<string> bodylastUpdate = null, [WorkflowExpression] Func<string> bodymark1 = null, [WorkflowExpression] Func<string> bodymark2 = null, [WorkflowExpression] Func<string> bodymaxResolutionDateUt = null, [WorkflowExpression] Func<string> bodymsProjectImportValidationWaiting = null, [WorkflowExpression] Func<string> bodynetPrice = null, [WorkflowExpression] Func<string> bodynetPriceCurId = null, [WorkflowExpression] Func<string> bodyoriginToolId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyowningGroupId = null, [WorkflowExpression] Func<string> bodyplannedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyplannedChangeDateStart = null, [WorkflowExpression] Func<string> bodypmStatusId = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectStartDateUt = null, [WorkflowExpression] Func<string> bodyqty = null, [WorkflowExpression] Func<string> bodyreleaseId = null, [WorkflowExpression] Func<string> bodyrentalNetPrice = null, [WorkflowExpression] Func<string> bodyrentalNetPriceCurId = null, [WorkflowExpression] Func<string> bodyrequestOriginId = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateStart = null, [WorkflowExpression] Func<string> bodyrequestorId = null, [WorkflowExpression] Func<string> bodyrequestorIpAddress = null, [WorkflowExpression] Func<string> bodyrequestorPhone = null, [WorkflowExpression] Func<string> bodyriskAmount = null, [WorkflowExpression] Func<string> bodyriskDescription = null, [WorkflowExpression] Func<string> bodyriskLevelId = null, [WorkflowExpression] Func<string> bodyrootCauseId = null, [WorkflowExpression] Func<string> bodysubmitDateUt = null, [WorkflowExpression] Func<string> bodytimeUsedToSolveRequest = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodyanalyticalChargeId, nameof(bodyanalyticalChargeId), required: false);
            SourceExpression.Validate(bodyassetId, nameof(bodyassetId), required: false);
            SourceExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            SourceExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            SourceExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            SourceExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            SourceExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            SourceExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            SourceExpression.Validate(bodybudgetPlanned, nameof(bodybudgetPlanned), required: false);
            SourceExpression.Validate(bodycanBeDuplicated, nameof(bodycanBeDuplicated), required: false);
            SourceExpression.Validate(bodyciId, nameof(bodyciId), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodycontinuityPlanId, nameof(bodycontinuityPlanId), required: false);
            SourceExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            SourceExpression.Validate(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            SourceExpression.Validate(bodydelay, nameof(bodydelay), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodydynamicDetails, nameof(bodydynamicDetails), required: false);
            SourceExpression.Validate(bodyeffectiveChangeDateEnd, nameof(bodyeffectiveChangeDateEnd), required: false);
            SourceExpression.Validate(bodyeffectiveChangeDateStart, nameof(bodyeffectiveChangeDateStart), required: false);
            SourceExpression.Validate(bodyendDateUt, nameof(bodyendDateUt), required: false);
            SourceExpression.Validate(bodyestimatedNetPrice, nameof(bodyestimatedNetPrice), required: false);
            SourceExpression.Validate(bodyexpectedDateUt, nameof(bodyexpectedDateUt), required: false);
            SourceExpression.Validate(bodyexpectedDuration, nameof(bodyexpectedDuration), required: false);
            SourceExpression.Validate(bodyexpectedEndDateUt, nameof(bodyexpectedEndDateUt), required: false);
            SourceExpression.Validate(bodyexpectedStartDateUt, nameof(bodyexpectedStartDateUt), required: false);
            SourceExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            SourceExpression.Validate(bodyfirstCallResolution, nameof(bodyfirstCallResolution), required: false);
            SourceExpression.Validate(bodyhourPerDay, nameof(bodyhourPerDay), required: false);
            SourceExpression.Validate(bodyimpactId, nameof(bodyimpactId), required: false);
            SourceExpression.Validate(bodyimputationDate, nameof(bodyimputationDate), required: false);
            SourceExpression.Validate(bodyisMajorIncident, nameof(bodyisMajorIncident), required: false);
            SourceExpression.Validate(bodyisTemplate, nameof(bodyisTemplate), required: false);
            SourceExpression.Validate(bodyknownProblemsId, nameof(bodyknownProblemsId), required: false);
            SourceExpression.Validate(bodylastUpdate, nameof(bodylastUpdate), required: false);
            SourceExpression.Validate(bodymark1, nameof(bodymark1), required: false);
            SourceExpression.Validate(bodymark2, nameof(bodymark2), required: false);
            SourceExpression.Validate(bodymaxResolutionDateUt, nameof(bodymaxResolutionDateUt), required: false);
            SourceExpression.Validate(bodymsProjectImportValidationWaiting, nameof(bodymsProjectImportValidationWaiting), required: false);
            SourceExpression.Validate(bodynetPrice, nameof(bodynetPrice), required: false);
            SourceExpression.Validate(bodynetPriceCurId, nameof(bodynetPriceCurId), required: false);
            SourceExpression.Validate(bodyoriginToolId, nameof(bodyoriginToolId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyowningGroupId, nameof(bodyowningGroupId), required: false);
            SourceExpression.Validate(bodyplannedChangeDateEnd, nameof(bodyplannedChangeDateEnd), required: false);
            SourceExpression.Validate(bodyplannedChangeDateStart, nameof(bodyplannedChangeDateStart), required: false);
            SourceExpression.Validate(bodypmStatusId, nameof(bodypmStatusId), required: false);
            SourceExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            SourceExpression.Validate(bodyprojectStartDateUt, nameof(bodyprojectStartDateUt), required: false);
            SourceExpression.Validate(bodyqty, nameof(bodyqty), required: false);
            SourceExpression.Validate(bodyreleaseId, nameof(bodyreleaseId), required: false);
            SourceExpression.Validate(bodyrentalNetPrice, nameof(bodyrentalNetPrice), required: false);
            SourceExpression.Validate(bodyrentalNetPriceCurId, nameof(bodyrentalNetPriceCurId), required: false);
            SourceExpression.Validate(bodyrequestOriginId, nameof(bodyrequestOriginId), required: false);
            SourceExpression.Validate(bodyrequestedChangeDateEnd, nameof(bodyrequestedChangeDateEnd), required: false);
            SourceExpression.Validate(bodyrequestedChangeDateStart, nameof(bodyrequestedChangeDateStart), required: false);
            SourceExpression.Validate(bodyrequestorId, nameof(bodyrequestorId), required: false);
            SourceExpression.Validate(bodyrequestorIpAddress, nameof(bodyrequestorIpAddress), required: false);
            SourceExpression.Validate(bodyrequestorPhone, nameof(bodyrequestorPhone), required: false);
            SourceExpression.Validate(bodyriskAmount, nameof(bodyriskAmount), required: false);
            SourceExpression.Validate(bodyriskDescription, nameof(bodyriskDescription), required: false);
            SourceExpression.Validate(bodyriskLevelId, nameof(bodyriskLevelId), required: false);
            SourceExpression.Validate(bodyrootCauseId, nameof(bodyrootCauseId), required: false);
            SourceExpression.Validate(bodysubmitDateUt, nameof(bodysubmitDateUt), required: false);
            SourceExpression.Validate(bodytimeUsedToSolveRequest, nameof(bodytimeUsedToSolveRequest), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyanalyticalChargeId != null)
                {
                    body["Analytical_Charge_Id"] = SourceExpressionConverter.ConvertToken(bodyanalyticalChargeId);
                    bodypropCount++;
                }

                if (bodyassetId != null)
                {
                    body["Asset_Id"] = SourceExpressionConverter.ConvertToken(bodyassetId);
                    bodypropCount++;
                }

                if (bodyavailableField1 != null)
                {
                    body["Available_Field_1"] = SourceExpressionConverter.ConvertToken(bodyavailableField1);
                    bodypropCount++;
                }

                if (bodyavailableField2 != null)
                {
                    body["Available_Field_2"] = SourceExpressionConverter.ConvertToken(bodyavailableField2);
                    bodypropCount++;
                }

                if (bodyavailableField3 != null)
                {
                    body["Available_Field_3"] = SourceExpressionConverter.ConvertToken(bodyavailableField3);
                    bodypropCount++;
                }

                if (bodyavailableField4 != null)
                {
                    body["Available_Field_4"] = SourceExpressionConverter.ConvertToken(bodyavailableField4);
                    bodypropCount++;
                }

                if (bodyavailableField5 != null)
                {
                    body["Available_Field_5"] = SourceExpressionConverter.ConvertToken(bodyavailableField5);
                    bodypropCount++;
                }

                if (bodyavailableField6 != null)
                {
                    body["Available_Field_6"] = SourceExpressionConverter.ConvertToken(bodyavailableField6);
                    bodypropCount++;
                }

                if (bodybudgetPlanned != null)
                {
                    body["Budget_Planned"] = SourceExpressionConverter.ConvertToken(bodybudgetPlanned);
                    bodypropCount++;
                }

                if (bodycanBeDuplicated != null)
                {
                    body["Can_Be_Duplicated"] = SourceExpressionConverter.ConvertToken(bodycanBeDuplicated);
                    bodypropCount++;
                }

                if (bodyciId != null)
                {
                    body["Ci_Id"] = SourceExpressionConverter.ConvertToken(bodyciId);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodycontinuityPlanId != null)
                {
                    body["Continuity_Plan_Id"] = SourceExpressionConverter.ConvertToken(bodycontinuityPlanId);
                    bodypropCount++;
                }

                if (bodycostCenterId != null)
                {
                    body["Cost_Center_Id"] = SourceExpressionConverter.ConvertToken(bodycostCenterId);
                    bodypropCount++;
                }

                if (bodycreationDateUt != null)
                {
                    body["Creation_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodycreationDateUt);
                    bodypropCount++;
                }

                if (bodydelay != null)
                {
                    body["Delay"] = SourceExpressionConverter.ConvertToken(bodydelay);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydynamicDetails != null)
                {
                    body["Dynamic_Details"] = SourceExpressionConverter.ConvertToken(bodydynamicDetails);
                    bodypropCount++;
                }

                if (bodyeffectiveChangeDateEnd != null)
                {
                    body["Effective_Change_Date_End"] = SourceExpressionConverter.ConvertToken(bodyeffectiveChangeDateEnd);
                    bodypropCount++;
                }

                if (bodyeffectiveChangeDateStart != null)
                {
                    body["Effective_Change_Date_Start"] = SourceExpressionConverter.ConvertToken(bodyeffectiveChangeDateStart);
                    bodypropCount++;
                }

                if (bodyendDateUt != null)
                {
                    body["End_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodyendDateUt);
                    bodypropCount++;
                }

                if (bodyestimatedNetPrice != null)
                {
                    body["Estimated_Net_Price"] = SourceExpressionConverter.ConvertToken(bodyestimatedNetPrice);
                    bodypropCount++;
                }

                if (bodyexpectedDateUt != null)
                {
                    body["Expected_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodyexpectedDateUt);
                    bodypropCount++;
                }

                if (bodyexpectedDuration != null)
                {
                    body["Expected_Duration"] = SourceExpressionConverter.ConvertToken(bodyexpectedDuration);
                    bodypropCount++;
                }

                if (bodyexpectedEndDateUt != null)
                {
                    body["Expected_End_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndDateUt);
                    bodypropCount++;
                }

                if (bodyexpectedStartDateUt != null)
                {
                    body["Expected_Start_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodyexpectedStartDateUt);
                    bodypropCount++;
                }

                if (bodyexternalReference != null)
                {
                    body["External_Reference"] = SourceExpressionConverter.ConvertToken(bodyexternalReference);
                    bodypropCount++;
                }

                if (bodyfirstCallResolution != null)
                {
                    body["First_Call_Resolution"] = SourceExpressionConverter.ConvertToken(bodyfirstCallResolution);
                    bodypropCount++;
                }

                if (bodyhourPerDay != null)
                {
                    body["Hour_Per_Day"] = SourceExpressionConverter.ConvertToken(bodyhourPerDay);
                    bodypropCount++;
                }

                if (bodyimpactId != null)
                {
                    body["Impact_Id"] = SourceExpressionConverter.ConvertToken(bodyimpactId);
                    bodypropCount++;
                }

                if (bodyimputationDate != null)
                {
                    body["Imputation_Date"] = SourceExpressionConverter.ConvertToken(bodyimputationDate);
                    bodypropCount++;
                }

                if (bodyisMajorIncident != null)
                {
                    body["Is_Major_Incident"] = SourceExpressionConverter.ConvertToken(bodyisMajorIncident);
                    bodypropCount++;
                }

                if (bodyisTemplate != null)
                {
                    body["Is_Template"] = SourceExpressionConverter.ConvertToken(bodyisTemplate);
                    bodypropCount++;
                }

                if (bodyknownProblemsId != null)
                {
                    body["Known_Problems_Id"] = SourceExpressionConverter.ConvertToken(bodyknownProblemsId);
                    bodypropCount++;
                }

                if (bodylastUpdate != null)
                {
                    body["Last_Update"] = SourceExpressionConverter.ConvertToken(bodylastUpdate);
                    bodypropCount++;
                }

                if (bodymark1 != null)
                {
                    body["Mark_1"] = SourceExpressionConverter.ConvertToken(bodymark1);
                    bodypropCount++;
                }

                if (bodymark2 != null)
                {
                    body["Mark_2"] = SourceExpressionConverter.ConvertToken(bodymark2);
                    bodypropCount++;
                }

                if (bodymaxResolutionDateUt != null)
                {
                    body["Max_Resolution_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodymaxResolutionDateUt);
                    bodypropCount++;
                }

                if (bodymsProjectImportValidationWaiting != null)
                {
                    body["Ms_Project_Import_Validation_Waiting"] = SourceExpressionConverter.ConvertToken(bodymsProjectImportValidationWaiting);
                    bodypropCount++;
                }

                if (bodynetPrice != null)
                {
                    body["Net_Price"] = SourceExpressionConverter.ConvertToken(bodynetPrice);
                    bodypropCount++;
                }

                if (bodynetPriceCurId != null)
                {
                    body["Net_Price_Cur_Id"] = SourceExpressionConverter.ConvertToken(bodynetPriceCurId);
                    bodypropCount++;
                }

                if (bodyoriginToolId != null)
                {
                    body["Origin_Tool_Id"] = SourceExpressionConverter.ConvertToken(bodyoriginToolId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["Owner_Id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyowningGroupId != null)
                {
                    body["Owning_Group_Id"] = SourceExpressionConverter.ConvertToken(bodyowningGroupId);
                    bodypropCount++;
                }

                if (bodyplannedChangeDateEnd != null)
                {
                    body["Planned_Change_Date_End"] = SourceExpressionConverter.ConvertToken(bodyplannedChangeDateEnd);
                    bodypropCount++;
                }

                if (bodyplannedChangeDateStart != null)
                {
                    body["Planned_Change_Date_Start"] = SourceExpressionConverter.ConvertToken(bodyplannedChangeDateStart);
                    bodypropCount++;
                }

                if (bodypmStatusId != null)
                {
                    body["Pm_Status_Id"] = SourceExpressionConverter.ConvertToken(bodypmStatusId);
                    bodypropCount++;
                }

                if (bodyprojectName != null)
                {
                    body["Project_Name"] = SourceExpressionConverter.ConvertToken(bodyprojectName);
                    bodypropCount++;
                }

                if (bodyprojectStartDateUt != null)
                {
                    body["Project_Start_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodyprojectStartDateUt);
                    bodypropCount++;
                }

                if (bodyqty != null)
                {
                    body["Qty"] = SourceExpressionConverter.ConvertToken(bodyqty);
                    bodypropCount++;
                }

                if (bodyreleaseId != null)
                {
                    body["Release_Id"] = SourceExpressionConverter.ConvertToken(bodyreleaseId);
                    bodypropCount++;
                }

                if (bodyrentalNetPrice != null)
                {
                    body["Rental_Net_Price"] = SourceExpressionConverter.ConvertToken(bodyrentalNetPrice);
                    bodypropCount++;
                }

                if (bodyrentalNetPriceCurId != null)
                {
                    body["Rental_Net_Price_Cur_Id"] = SourceExpressionConverter.ConvertToken(bodyrentalNetPriceCurId);
                    bodypropCount++;
                }

                if (bodyrequestOriginId != null)
                {
                    body["Request_Origin_Id"] = SourceExpressionConverter.ConvertToken(bodyrequestOriginId);
                    bodypropCount++;
                }

                if (bodyrequestedChangeDateEnd != null)
                {
                    body["Requested_Change_Date_End"] = SourceExpressionConverter.ConvertToken(bodyrequestedChangeDateEnd);
                    bodypropCount++;
                }

                if (bodyrequestedChangeDateStart != null)
                {
                    body["Requested_Change_Date_Start"] = SourceExpressionConverter.ConvertToken(bodyrequestedChangeDateStart);
                    bodypropCount++;
                }

                if (bodyrequestorId != null)
                {
                    body["Requestor_Id"] = SourceExpressionConverter.ConvertToken(bodyrequestorId);
                    bodypropCount++;
                }

                if (bodyrequestorIpAddress != null)
                {
                    body["Requestor_Ip_Address"] = SourceExpressionConverter.ConvertToken(bodyrequestorIpAddress);
                    bodypropCount++;
                }

                if (bodyrequestorPhone != null)
                {
                    body["Requestor_Phone"] = SourceExpressionConverter.ConvertToken(bodyrequestorPhone);
                    bodypropCount++;
                }

                if (bodyriskAmount != null)
                {
                    body["Risk_Amount"] = SourceExpressionConverter.ConvertToken(bodyriskAmount);
                    bodypropCount++;
                }

                if (bodyriskDescription != null)
                {
                    body["Risk_Description"] = SourceExpressionConverter.ConvertToken(bodyriskDescription);
                    bodypropCount++;
                }

                if (bodyriskLevelId != null)
                {
                    body["Risk_Level_Id"] = SourceExpressionConverter.ConvertToken(bodyriskLevelId);
                    bodypropCount++;
                }

                if (bodyrootCauseId != null)
                {
                    body["Root_Cause_Id"] = SourceExpressionConverter.ConvertToken(bodyrootCauseId);
                    bodypropCount++;
                }

                if (bodysubmitDateUt != null)
                {
                    body["Submit_Date_Ut"] = SourceExpressionConverter.ConvertToken(bodysubmitDateUt);
                    bodypropCount++;
                }

                if (bodytimeUsedToSolveRequest != null)
                {
                    body["Time_Used_To_Solve_Request"] = SourceExpressionConverter.ConvertToken(bodytimeUsedToSolveRequest);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/comment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadAndAttachADocumentToARequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<int> bodydoneById = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodydoneById, nameof(bodydoneById), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/restart", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodydoneById != null)
                {
                    body["done_by_id"] = SourceExpressionConverter.ConvertToken(bodydoneById);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RestartRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodydoneById = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodydoneById, nameof(bodydoneById), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/suspend", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodydoneById != null)
                {
                    body["done_by_id"] = SourceExpressionConverter.ConvertToken(bodydoneById);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SuspendRequestIncidentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyactionTypeId, [WorkflowExpression] Func<string> bodyelapsedTime = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycontractualCost = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodygroupMail = null, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodystartDateUt = null, [WorkflowExpression] Func<string> bodytimeCost = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodyactionTypeId, nameof(bodyactionTypeId), required: true);
            SourceExpression.Validate(bodyelapsedTime, nameof(bodyelapsedTime), required: false);
            SourceExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            SourceExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            SourceExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            SourceExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            SourceExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            SourceExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            SourceExpression.Validate(bodycontractualCost, nameof(bodycontractualCost), required: false);
            SourceExpression.Validate(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyendDateUt, nameof(bodyendDateUt), required: false);
            SourceExpression.Validate(bodygroupMail, nameof(bodygroupMail), required: false);
            SourceExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            SourceExpression.Validate(bodystartDateUt, nameof(bodystartDateUt), required: false);
            SourceExpression.Validate(bodytimeCost, nameof(bodytimeCost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyelapsedTime != null)
                {
                    body["Elapsed_Time"] = SourceExpressionConverter.ConvertToken(bodyelapsedTime);
                    bodypropCount++;
                }

                bodypropCount++;
                body["action_type_id"] = SourceExpressionConverter.ConvertToken(bodyactionTypeId);
                if (bodyavailableField1 != null)
                {
                    body["available_field_1"] = SourceExpressionConverter.ConvertToken(bodyavailableField1);
                    bodypropCount++;
                }

                if (bodyavailableField2 != null)
                {
                    body["available_field_2"] = SourceExpressionConverter.ConvertToken(bodyavailableField2);
                    bodypropCount++;
                }

                if (bodyavailableField3 != null)
                {
                    body["available_field_3"] = SourceExpressionConverter.ConvertToken(bodyavailableField3);
                    bodypropCount++;
                }

                if (bodyavailableField4 != null)
                {
                    body["available_field_4"] = SourceExpressionConverter.ConvertToken(bodyavailableField4);
                    bodypropCount++;
                }

                if (bodyavailableField5 != null)
                {
                    body["available_field_5"] = SourceExpressionConverter.ConvertToken(bodyavailableField5);
                    bodypropCount++;
                }

                if (bodyavailableField6 != null)
                {
                    body["available_field_6"] = SourceExpressionConverter.ConvertToken(bodyavailableField6);
                    bodypropCount++;
                }

                if (bodycontractualCost != null)
                {
                    body["contractual_cost"] = SourceExpressionConverter.ConvertToken(bodycontractualCost);
                    bodypropCount++;
                }

                if (bodycreationDateUt != null)
                {
                    body["creation_date_ut"] = SourceExpressionConverter.ConvertToken(bodycreationDateUt);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyendDateUt != null)
                {
                    body["end_date_ut"] = SourceExpressionConverter.ConvertToken(bodyendDateUt);
                    bodypropCount++;
                }

                if (bodygroupMail != null)
                {
                    body["group_mail"] = SourceExpressionConverter.ConvertToken(bodygroupMail);
                    bodypropCount++;
                }

                if (bodygroupName != null)
                {
                    body["group_name"] = SourceExpressionConverter.ConvertToken(bodygroupName);
                    bodypropCount++;
                }

                if (bodystartDateUt != null)
                {
                    body["start_date_ut"] = SourceExpressionConverter.ConvertToken(bodystartDateUt);
                    bodypropCount++;
                }

                if (bodytimeCost != null)
                {
                    body["time_cost"] = SourceExpressionConverter.ConvertToken(bodytimeCost);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(maxRows, nameof(maxRows), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = SourceExpressionConverter.ConvertO(maxRows);
                return callPayload;
            }

            return new ApiConnectionAction<ViewSlasListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slaId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(slaId, nameof(slaId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewSlaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesAssetsResponse> ViewAllAtributesAssets([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAllAtributesAssetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction CreateLinkBetweenAttributandAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> characteristicId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(characteristicId, nameof(characteristicId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(characteristicId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateanAttributeofanAssetResponse> UpdateanAttributeofanAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> characteristicId, [WorkflowExpression] Func<string> bodydATA1 = null, [WorkflowExpression] Func<string> bodydATA2 = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            SourceExpression.Validate(characteristicId, nameof(characteristicId), required: true);
            SourceExpression.Validate(bodydATA1, nameof(bodydATA1), required: false);
            SourceExpression.Validate(bodydATA2, nameof(bodydATA2), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/characteristics/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(characteristicId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydATA1 != null)
                {
                    body["DATA_1"] = SourceExpressionConverter.ConvertToken(bodydATA1);
                    bodypropCount++;
                }

                if (bodydATA2 != null)
                {
                    body["DATA_2"] = SourceExpressionConverter.ConvertToken(bodydATA2);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateanAttributeofanAssetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIResponse> CreateCI([WorkflowExpression] Func<bodyassetsInputItem2[]> bodyassets = null)
        {
            SourceExpression.Validate(bodyassets, nameof(bodyassets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/50006/assets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassets != null)
                {
                    body["assets"] = SourceExpressionConverter.ConvertToken(bodyassets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateCIunavailabilityResponse> CreateCIunavailability([WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CreateCIunavailabilityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<EndCIunavailabilityResponse> EndCIunavailability([WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EndCIunavailabilityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactonCIResponse> ViewlinksimpactonCI([WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacting", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewlinksimpactonCIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewlinksimpactbyCIResponse> ViewlinksimpactbyCI([WorkflowExpression] Func<string> ciId)
        {
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/50006/configuration-items/{0}/item-links/impacted", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewlinksimpactbyCIResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewTicketStatusListResponse> ViewTicketStatusList([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewTicketStatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedTicketsResponse> ViewListProblemsAttachedTickets([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problem-links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListProblemsAttachedTicketsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsAttachedATicketsResponse> ViewListProblemsAttachedATickets([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/problems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListProblemsAttachedATicketsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListTicketsAttachedtoaProblemResponse> ViewListTicketsAttachedtoaProblem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}/requests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListTicketsAttachedtoaProblemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsResponse> ViewListQuestions([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListQuestionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionsWithResponseResponse> ViewListQuestionsWithResponse([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListQuestionsWithResponseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewaQuestionResponse> ViewaQuestion([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewaQuestionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllResponsesListQuestionsofaTicketResponse> ViewAllResponsesListQuestionsofaTicket([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAllResponsesListQuestionsofaTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewResponseQuestionTicketResponse> ViewResponseQuestionTicket([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> questionId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewResponseQuestionTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateResponseQuestionTicketResponse> CreateResponseQuestionTicket([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> questionId, [WorkflowExpression] Func<string> bodyrESULT = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGEN = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGFR = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGSP = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGGE = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGIT = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGPO = null, [WorkflowExpression] Func<string> bodyrESULTDATE = null, [WorkflowExpression] Func<string> bodyrESULTNUMBER = null, [WorkflowExpression] Func<string> bodyrESULTBIT = null, [WorkflowExpression] Func<string> bodyrESULTORDER = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL1 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL2 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL3 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL4 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL5 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL6 = null, [WorkflowExpression] Func<string> bodyqUESTIONDISPLAYED = null, [WorkflowExpression] Func<string> bodydOCUMENTID = null, [WorkflowExpression] Func<string> bodyqUESTIONREQUIRED = null, [WorkflowExpression] Func<string> bodyiSCONDITIONNAL = null, [WorkflowExpression] Func<string> bodyrESULTDURATION = null, [WorkflowExpression] Func<string> bodysYSQUESTIONNAIREID = null, [WorkflowExpression] Func<string> bodyoRIGINTOOLID = null, [WorkflowExpression] Func<string> bodylASTQUESTIONNAIRE = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            SourceExpression.Validate(bodyrESULT, nameof(bodyrESULT), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGEN, nameof(bodyrESULTSTRINGEN), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGFR, nameof(bodyrESULTSTRINGFR), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGSP, nameof(bodyrESULTSTRINGSP), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGGE, nameof(bodyrESULTSTRINGGE), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGIT, nameof(bodyrESULTSTRINGIT), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGPO, nameof(bodyrESULTSTRINGPO), required: false);
            SourceExpression.Validate(bodyrESULTDATE, nameof(bodyrESULTDATE), required: false);
            SourceExpression.Validate(bodyrESULTNUMBER, nameof(bodyrESULTNUMBER), required: false);
            SourceExpression.Validate(bodyrESULTBIT, nameof(bodyrESULTBIT), required: false);
            SourceExpression.Validate(bodyrESULTORDER, nameof(bodyrESULTORDER), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL1, nameof(bodyrESULTSTRINGL1), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL2, nameof(bodyrESULTSTRINGL2), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL3, nameof(bodyrESULTSTRINGL3), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL4, nameof(bodyrESULTSTRINGL4), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL5, nameof(bodyrESULTSTRINGL5), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL6, nameof(bodyrESULTSTRINGL6), required: false);
            SourceExpression.Validate(bodyqUESTIONDISPLAYED, nameof(bodyqUESTIONDISPLAYED), required: false);
            SourceExpression.Validate(bodydOCUMENTID, nameof(bodydOCUMENTID), required: false);
            SourceExpression.Validate(bodyqUESTIONREQUIRED, nameof(bodyqUESTIONREQUIRED), required: false);
            SourceExpression.Validate(bodyiSCONDITIONNAL, nameof(bodyiSCONDITIONNAL), required: false);
            SourceExpression.Validate(bodyrESULTDURATION, nameof(bodyrESULTDURATION), required: false);
            SourceExpression.Validate(bodysYSQUESTIONNAIREID, nameof(bodysYSQUESTIONNAIREID), required: false);
            SourceExpression.Validate(bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            SourceExpression.Validate(bodylASTQUESTIONNAIRE, nameof(bodylASTQUESTIONNAIRE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrESULT != null)
                {
                    body["RESULT"] = SourceExpressionConverter.ConvertToken(bodyrESULT);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGEN != null)
                {
                    body["RESULT_STRING_EN"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGEN);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGFR != null)
                {
                    body["RESULT_STRING_FR"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGFR);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGSP != null)
                {
                    body["RESULT_STRING_SP"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGSP);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGGE != null)
                {
                    body["RESULT_STRING_GE"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGGE);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGIT != null)
                {
                    body["RESULT_STRING_IT"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGIT);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGPO != null)
                {
                    body["RESULT_STRING_PO"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGPO);
                    bodypropCount++;
                }

                if (bodyrESULTDATE != null)
                {
                    body["RESULT_DATE"] = SourceExpressionConverter.ConvertToken(bodyrESULTDATE);
                    bodypropCount++;
                }

                if (bodyrESULTNUMBER != null)
                {
                    body["RESULT_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyrESULTNUMBER);
                    bodypropCount++;
                }

                if (bodyrESULTBIT != null)
                {
                    body["RESULT_BIT"] = SourceExpressionConverter.ConvertToken(bodyrESULTBIT);
                    bodypropCount++;
                }

                if (bodyrESULTORDER != null)
                {
                    body["RESULT_ORDER"] = SourceExpressionConverter.ConvertToken(bodyrESULTORDER);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL1 != null)
                {
                    body["RESULT_STRING_L1"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL1);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL2 != null)
                {
                    body["RESULT_STRING_L2"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL2);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL3 != null)
                {
                    body["RESULT_STRING_L3"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL3);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL4 != null)
                {
                    body["RESULT_STRING_L4"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL4);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL5 != null)
                {
                    body["RESULT_STRING_L5"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL5);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL6 != null)
                {
                    body["RESULT_STRING_L6"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL6);
                    bodypropCount++;
                }

                if (bodyqUESTIONDISPLAYED != null)
                {
                    body["QUESTION_DISPLAYED"] = SourceExpressionConverter.ConvertToken(bodyqUESTIONDISPLAYED);
                    bodypropCount++;
                }

                if (bodydOCUMENTID != null)
                {
                    body["DOCUMENT_ID"] = SourceExpressionConverter.ConvertToken(bodydOCUMENTID);
                    bodypropCount++;
                }

                if (bodyqUESTIONREQUIRED != null)
                {
                    body["QUESTION_REQUIRED"] = SourceExpressionConverter.ConvertToken(bodyqUESTIONREQUIRED);
                    bodypropCount++;
                }

                if (bodyiSCONDITIONNAL != null)
                {
                    body["IS_CONDITIONNAL"] = SourceExpressionConverter.ConvertToken(bodyiSCONDITIONNAL);
                    bodypropCount++;
                }

                if (bodyrESULTDURATION != null)
                {
                    body["RESULT_DURATION"] = SourceExpressionConverter.ConvertToken(bodyrESULTDURATION);
                    bodypropCount++;
                }

                if (bodysYSQUESTIONNAIREID != null)
                {
                    body["SYS_QUESTIONNAIRE_ID"] = SourceExpressionConverter.ConvertToken(bodysYSQUESTIONNAIREID);
                    bodypropCount++;
                }

                if (bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = SourceExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (bodylASTQUESTIONNAIRE != null)
                {
                    body["LAST_QUESTIONNAIRE"] = SourceExpressionConverter.ConvertToken(bodylASTQUESTIONNAIRE);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateResponseQuestionTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateResponseQuestionTicketResponse> UpdateResponseQuestionTicket([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> requestId, [WorkflowExpression] Func<string> questionId, [WorkflowExpression] Func<string> bodyrESULT = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGEN = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGFR = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGSP = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGGE = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGIT = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGPO = null, [WorkflowExpression] Func<string> bodyrESULTDATE = null, [WorkflowExpression] Func<string> bodyrESULTNUMBER = null, [WorkflowExpression] Func<string> bodyrESULTBIT = null, [WorkflowExpression] Func<string> bodyrESULTORDER = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL1 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL2 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL3 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL4 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL5 = null, [WorkflowExpression] Func<string> bodyrESULTSTRINGL6 = null, [WorkflowExpression] Func<string> bodyqUESTIONDISPLAYED = null, [WorkflowExpression] Func<string> bodydOCUMENTID = null, [WorkflowExpression] Func<string> bodyqUESTIONREQUIRED = null, [WorkflowExpression] Func<string> bodyiSCONDITIONNAL = null, [WorkflowExpression] Func<string> bodyrESULTDURATION = null, [WorkflowExpression] Func<string> bodysYSQUESTIONNAIREID = null, [WorkflowExpression] Func<string> bodyoRIGINTOOLID = null, [WorkflowExpression] Func<string> bodylASTQUESTIONNAIRE = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            SourceExpression.Validate(questionId, nameof(questionId), required: true);
            SourceExpression.Validate(bodyrESULT, nameof(bodyrESULT), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGEN, nameof(bodyrESULTSTRINGEN), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGFR, nameof(bodyrESULTSTRINGFR), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGSP, nameof(bodyrESULTSTRINGSP), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGGE, nameof(bodyrESULTSTRINGGE), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGIT, nameof(bodyrESULTSTRINGIT), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGPO, nameof(bodyrESULTSTRINGPO), required: false);
            SourceExpression.Validate(bodyrESULTDATE, nameof(bodyrESULTDATE), required: false);
            SourceExpression.Validate(bodyrESULTNUMBER, nameof(bodyrESULTNUMBER), required: false);
            SourceExpression.Validate(bodyrESULTBIT, nameof(bodyrESULTBIT), required: false);
            SourceExpression.Validate(bodyrESULTORDER, nameof(bodyrESULTORDER), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL1, nameof(bodyrESULTSTRINGL1), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL2, nameof(bodyrESULTSTRINGL2), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL3, nameof(bodyrESULTSTRINGL3), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL4, nameof(bodyrESULTSTRINGL4), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL5, nameof(bodyrESULTSTRINGL5), required: false);
            SourceExpression.Validate(bodyrESULTSTRINGL6, nameof(bodyrESULTSTRINGL6), required: false);
            SourceExpression.Validate(bodyqUESTIONDISPLAYED, nameof(bodyqUESTIONDISPLAYED), required: false);
            SourceExpression.Validate(bodydOCUMENTID, nameof(bodydOCUMENTID), required: false);
            SourceExpression.Validate(bodyqUESTIONREQUIRED, nameof(bodyqUESTIONREQUIRED), required: false);
            SourceExpression.Validate(bodyiSCONDITIONNAL, nameof(bodyiSCONDITIONNAL), required: false);
            SourceExpression.Validate(bodyrESULTDURATION, nameof(bodyrESULTDURATION), required: false);
            SourceExpression.Validate(bodysYSQUESTIONNAIREID, nameof(bodysYSQUESTIONNAIREID), required: false);
            SourceExpression.Validate(bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            SourceExpression.Validate(bodylASTQUESTIONNAIRE, nameof(bodylASTQUESTIONNAIRE), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questions-result/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrESULT != null)
                {
                    body["RESULT"] = SourceExpressionConverter.ConvertToken(bodyrESULT);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGEN != null)
                {
                    body["RESULT_STRING_EN"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGEN);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGFR != null)
                {
                    body["RESULT_STRING_FR"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGFR);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGSP != null)
                {
                    body["RESULT_STRING_SP"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGSP);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGGE != null)
                {
                    body["RESULT_STRING_GE"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGGE);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGIT != null)
                {
                    body["RESULT_STRING_IT"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGIT);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGPO != null)
                {
                    body["RESULT_STRING_PO"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGPO);
                    bodypropCount++;
                }

                if (bodyrESULTDATE != null)
                {
                    body["RESULT_DATE"] = SourceExpressionConverter.ConvertToken(bodyrESULTDATE);
                    bodypropCount++;
                }

                if (bodyrESULTNUMBER != null)
                {
                    body["RESULT_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyrESULTNUMBER);
                    bodypropCount++;
                }

                if (bodyrESULTBIT != null)
                {
                    body["RESULT_BIT"] = SourceExpressionConverter.ConvertToken(bodyrESULTBIT);
                    bodypropCount++;
                }

                if (bodyrESULTORDER != null)
                {
                    body["RESULT_ORDER"] = SourceExpressionConverter.ConvertToken(bodyrESULTORDER);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL1 != null)
                {
                    body["RESULT_STRING_L1"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL1);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL2 != null)
                {
                    body["RESULT_STRING_L2"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL2);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL3 != null)
                {
                    body["RESULT_STRING_L3"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL3);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL4 != null)
                {
                    body["RESULT_STRING_L4"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL4);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL5 != null)
                {
                    body["RESULT_STRING_L5"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL5);
                    bodypropCount++;
                }

                if (bodyrESULTSTRINGL6 != null)
                {
                    body["RESULT_STRING_L6"] = SourceExpressionConverter.ConvertToken(bodyrESULTSTRINGL6);
                    bodypropCount++;
                }

                if (bodyqUESTIONDISPLAYED != null)
                {
                    body["QUESTION_DISPLAYED"] = SourceExpressionConverter.ConvertToken(bodyqUESTIONDISPLAYED);
                    bodypropCount++;
                }

                if (bodydOCUMENTID != null)
                {
                    body["DOCUMENT_ID"] = SourceExpressionConverter.ConvertToken(bodydOCUMENTID);
                    bodypropCount++;
                }

                if (bodyqUESTIONREQUIRED != null)
                {
                    body["QUESTION_REQUIRED"] = SourceExpressionConverter.ConvertToken(bodyqUESTIONREQUIRED);
                    bodypropCount++;
                }

                if (bodyiSCONDITIONNAL != null)
                {
                    body["IS_CONDITIONNAL"] = SourceExpressionConverter.ConvertToken(bodyiSCONDITIONNAL);
                    bodypropCount++;
                }

                if (bodyrESULTDURATION != null)
                {
                    body["RESULT_DURATION"] = SourceExpressionConverter.ConvertToken(bodyrESULTDURATION);
                    bodypropCount++;
                }

                if (bodysYSQUESTIONNAIREID != null)
                {
                    body["SYS_QUESTIONNAIRE_ID"] = SourceExpressionConverter.ConvertToken(bodysYSQUESTIONNAIREID);
                    bodypropCount++;
                }

                if (bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = SourceExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (bodylASTQUESTIONNAIRE != null)
                {
                    body["LAST_QUESTIONNAIRE"] = SourceExpressionConverter.ConvertToken(bodylASTQUESTIONNAIRE);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateResponseQuestionTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListQuestionnairesResponse> ViewListQuestionnaires([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListQuestionnairesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewQuestionnaireResponse> ViewQuestionnaire([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> questionnaireId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(questionnaireId, nameof(questionnaireId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/questionnaires/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(questionnaireId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewQuestionnaireResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListProblemsResponse> ViewListProblems([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListProblemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewProblemResponse> ViewProblem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/problems/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewProblemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListNewsResponse> ViewListNews([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListNewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateNewsResponse> CreateNews([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CreateNewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewNewsResponse> ViewNews([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewNewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateNewsResponse> UpdateNews([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/news/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateNewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewListActionsResponse> ViewListActions([WorkflowExpression] Func<string> account)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewListActionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<CreateActionTicketResponse> CreateActionTicket([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyaCTIONNUMBER = null, [WorkflowExpression] Func<string> bodyaSSETID = null, [WorkflowExpression] Func<string> bodypARENTACTIONID = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodydONEBYID = null, [WorkflowExpression] Func<string> bodyvALIDATORID = null, [WorkflowExpression] Func<string> bodyaCTIONLABELEN = null, [WorkflowExpression] Func<string> bodytABLENAME = null, [WorkflowExpression] Func<string> bodyfIELDNAME = null, [WorkflowExpression] Func<string> bodyoLDVALUE = null, [WorkflowExpression] Func<string> bodynEWVALUE = null, [WorkflowExpression] Func<string> bodydELETEACTION = null, [WorkflowExpression] Func<string> bodyaUTOMATICACTION = null, [WorkflowExpression] Func<string> bodypROCESSSTEPID = null, [WorkflowExpression] Func<string> bodyrEQUESTID = null, [WorkflowExpression] Func<string> bodydESCRIPTION = null, [WorkflowExpression] Func<string> bodynETCHARGE = null, [WorkflowExpression] Func<string> bodynETCHARGECURID = null, [WorkflowExpression] Func<string> bodyrESOLUTION = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodysUPPORTSTAFFID = null, [WorkflowExpression] Func<string> bodycONTACTID = null, [WorkflowExpression] Func<string> bodyeXPECTEDENDDATEUT = null, [WorkflowExpression] Func<string> bodycOMMENT = null, [WorkflowExpression] Func<string> bodysTARTDATEUT = null, [WorkflowExpression] Func<string> bodyeNDDATEUT = null, [WorkflowExpression] Func<string> bodyrENEWALDATEUT = null, [WorkflowExpression] Func<string> bodyeXPECTEDSTARTDATEUT = null, [WorkflowExpression] Func<string> bodycREATIONDATEUT = null, [WorkflowExpression] Func<string> bodyaPPLICATIONDATEUT = null, [WorkflowExpression] Func<string> bodywIZARDGUID = null, [WorkflowExpression] Func<string> bodygROUPID = null, [WorkflowExpression] Func<string> bodyaCTIONLABELFR = null, [WorkflowExpression] Func<string> bodyaCTIONLABELSP = null, [WorkflowExpression] Func<string> bodyaCTIONLABELGE = null, [WorkflowExpression] Func<string> bodyaCTIONLABELIT = null, [WorkflowExpression] Func<string> bodyaCTIONLABELPO = null, [WorkflowExpression] Func<string> bodykNOWNPROBLEMID = null, [WorkflowExpression] Func<string> bodymAXINTERVENTIONDATEUT = null, [WorkflowExpression] Func<string> bodyeLAPSEDTIME = null, [WorkflowExpression] Func<string> bodypRIORITYID = null, [WorkflowExpression] Func<string> bodytAXID = null, [WorkflowExpression] Func<string> bodysTATUSIDONCREATE = null, [WorkflowExpression] Func<string> bodysTATUSIDONTERMINATE = null, [WorkflowExpression] Func<string> bodyaCTIONTYPEID = null, [WorkflowExpression] Func<string> bodydELAY = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodytIMEUSEDTOCOMPLETEACTION = null, [WorkflowExpression] Func<string> bodycONTRACTUALCOST = null, [WorkflowExpression] Func<string> bodycONTRACTUALCOSTCURID = null, [WorkflowExpression] Func<string> bodytIMECOST = null, [WorkflowExpression] Func<string> bodytIMECOSTCURID = null, [WorkflowExpression] Func<string> bodyoRIGINACTIONID = null, [WorkflowExpression] Func<string> bodywORKFLOWVALUE = null, [WorkflowExpression] Func<string> bodycONTINUITYPLANID = null, [WorkflowExpression] Func<string> bodycATEGORYTESTID = null, [WorkflowExpression] Func<string> bodywORKFLOWID = null, [WorkflowExpression] Func<string> bodyeXITVALUE = null, [WorkflowExpression] Func<string> bodymAXRESOLUTIONDATEUT = null, [WorkflowExpression] Func<string> bodypERCENTCOMPLETE = null, [WorkflowExpression] Func<string> bodyeXPECTEDDURATION = null, [WorkflowExpression] Func<string> bodywBSTASK = null, [WorkflowExpression] Func<string> bodytASKPERSONCOSTPERHOUR = null, [WorkflowExpression] Func<string> bodytASKPLANNEDBUDGET = null, [WorkflowExpression] Func<string> bodyeSTIMATEDNETCHARGE = null, [WorkflowExpression] Func<string> bodypREVIOUSSIBLINGID = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL1 = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL2 = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL3 = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL4 = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL5 = null, [WorkflowExpression] Func<string> bodyaCTIONLABELL6 = null, [WorkflowExpression] Func<string> bodyhISTORYID = null, [WorkflowExpression] Func<string> bodytOTRUNC = null, [WorkflowExpression] Func<string> bodysTAGEID = null, [WorkflowExpression] Func<string> bodyiSLOCKEDPROGRESSPOINT = null, [WorkflowExpression] Func<string> bodyoRIGINTOOLID = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodyeLASTDATESUPDATE = null, [WorkflowExpression] Func<string> bodybILLEDTIME = null, [WorkflowExpression] Func<string> bodyiSBILLINGREVIEWED = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(bodyaCTIONNUMBER, nameof(bodyaCTIONNUMBER), required: false);
            SourceExpression.Validate(bodyaSSETID, nameof(bodyaSSETID), required: false);
            SourceExpression.Validate(bodypARENTACTIONID, nameof(bodypARENTACTIONID), required: false);
            SourceExpression.Validate(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            SourceExpression.Validate(bodydONEBYID, nameof(bodydONEBYID), required: false);
            SourceExpression.Validate(bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            SourceExpression.Validate(bodyaCTIONLABELEN, nameof(bodyaCTIONLABELEN), required: false);
            SourceExpression.Validate(bodytABLENAME, nameof(bodytABLENAME), required: false);
            SourceExpression.Validate(bodyfIELDNAME, nameof(bodyfIELDNAME), required: false);
            SourceExpression.Validate(bodyoLDVALUE, nameof(bodyoLDVALUE), required: false);
            SourceExpression.Validate(bodynEWVALUE, nameof(bodynEWVALUE), required: false);
            SourceExpression.Validate(bodydELETEACTION, nameof(bodydELETEACTION), required: false);
            SourceExpression.Validate(bodyaUTOMATICACTION, nameof(bodyaUTOMATICACTION), required: false);
            SourceExpression.Validate(bodypROCESSSTEPID, nameof(bodypROCESSSTEPID), required: false);
            SourceExpression.Validate(bodyrEQUESTID, nameof(bodyrEQUESTID), required: false);
            SourceExpression.Validate(bodydESCRIPTION, nameof(bodydESCRIPTION), required: false);
            SourceExpression.Validate(bodynETCHARGE, nameof(bodynETCHARGE), required: false);
            SourceExpression.Validate(bodynETCHARGECURID, nameof(bodynETCHARGECURID), required: false);
            SourceExpression.Validate(bodyrESOLUTION, nameof(bodyrESOLUTION), required: false);
            SourceExpression.Validate(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            SourceExpression.Validate(bodysUPPORTSTAFFID, nameof(bodysUPPORTSTAFFID), required: false);
            SourceExpression.Validate(bodycONTACTID, nameof(bodycONTACTID), required: false);
            SourceExpression.Validate(bodyeXPECTEDENDDATEUT, nameof(bodyeXPECTEDENDDATEUT), required: false);
            SourceExpression.Validate(bodycOMMENT, nameof(bodycOMMENT), required: false);
            SourceExpression.Validate(bodysTARTDATEUT, nameof(bodysTARTDATEUT), required: false);
            SourceExpression.Validate(bodyeNDDATEUT, nameof(bodyeNDDATEUT), required: false);
            SourceExpression.Validate(bodyrENEWALDATEUT, nameof(bodyrENEWALDATEUT), required: false);
            SourceExpression.Validate(bodyeXPECTEDSTARTDATEUT, nameof(bodyeXPECTEDSTARTDATEUT), required: false);
            SourceExpression.Validate(bodycREATIONDATEUT, nameof(bodycREATIONDATEUT), required: false);
            SourceExpression.Validate(bodyaPPLICATIONDATEUT, nameof(bodyaPPLICATIONDATEUT), required: false);
            SourceExpression.Validate(bodywIZARDGUID, nameof(bodywIZARDGUID), required: false);
            SourceExpression.Validate(bodygROUPID, nameof(bodygROUPID), required: false);
            SourceExpression.Validate(bodyaCTIONLABELFR, nameof(bodyaCTIONLABELFR), required: false);
            SourceExpression.Validate(bodyaCTIONLABELSP, nameof(bodyaCTIONLABELSP), required: false);
            SourceExpression.Validate(bodyaCTIONLABELGE, nameof(bodyaCTIONLABELGE), required: false);
            SourceExpression.Validate(bodyaCTIONLABELIT, nameof(bodyaCTIONLABELIT), required: false);
            SourceExpression.Validate(bodyaCTIONLABELPO, nameof(bodyaCTIONLABELPO), required: false);
            SourceExpression.Validate(bodykNOWNPROBLEMID, nameof(bodykNOWNPROBLEMID), required: false);
            SourceExpression.Validate(bodymAXINTERVENTIONDATEUT, nameof(bodymAXINTERVENTIONDATEUT), required: false);
            SourceExpression.Validate(bodyeLAPSEDTIME, nameof(bodyeLAPSEDTIME), required: false);
            SourceExpression.Validate(bodypRIORITYID, nameof(bodypRIORITYID), required: false);
            SourceExpression.Validate(bodytAXID, nameof(bodytAXID), required: false);
            SourceExpression.Validate(bodysTATUSIDONCREATE, nameof(bodysTATUSIDONCREATE), required: false);
            SourceExpression.Validate(bodysTATUSIDONTERMINATE, nameof(bodysTATUSIDONTERMINATE), required: false);
            SourceExpression.Validate(bodyaCTIONTYPEID, nameof(bodyaCTIONTYPEID), required: false);
            SourceExpression.Validate(bodydELAY, nameof(bodydELAY), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            SourceExpression.Validate(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            SourceExpression.Validate(bodytIMEUSEDTOCOMPLETEACTION, nameof(bodytIMEUSEDTOCOMPLETEACTION), required: false);
            SourceExpression.Validate(bodycONTRACTUALCOST, nameof(bodycONTRACTUALCOST), required: false);
            SourceExpression.Validate(bodycONTRACTUALCOSTCURID, nameof(bodycONTRACTUALCOSTCURID), required: false);
            SourceExpression.Validate(bodytIMECOST, nameof(bodytIMECOST), required: false);
            SourceExpression.Validate(bodytIMECOSTCURID, nameof(bodytIMECOSTCURID), required: false);
            SourceExpression.Validate(bodyoRIGINACTIONID, nameof(bodyoRIGINACTIONID), required: false);
            SourceExpression.Validate(bodywORKFLOWVALUE, nameof(bodywORKFLOWVALUE), required: false);
            SourceExpression.Validate(bodycONTINUITYPLANID, nameof(bodycONTINUITYPLANID), required: false);
            SourceExpression.Validate(bodycATEGORYTESTID, nameof(bodycATEGORYTESTID), required: false);
            SourceExpression.Validate(bodywORKFLOWID, nameof(bodywORKFLOWID), required: false);
            SourceExpression.Validate(bodyeXITVALUE, nameof(bodyeXITVALUE), required: false);
            SourceExpression.Validate(bodymAXRESOLUTIONDATEUT, nameof(bodymAXRESOLUTIONDATEUT), required: false);
            SourceExpression.Validate(bodypERCENTCOMPLETE, nameof(bodypERCENTCOMPLETE), required: false);
            SourceExpression.Validate(bodyeXPECTEDDURATION, nameof(bodyeXPECTEDDURATION), required: false);
            SourceExpression.Validate(bodywBSTASK, nameof(bodywBSTASK), required: false);
            SourceExpression.Validate(bodytASKPERSONCOSTPERHOUR, nameof(bodytASKPERSONCOSTPERHOUR), required: false);
            SourceExpression.Validate(bodytASKPLANNEDBUDGET, nameof(bodytASKPLANNEDBUDGET), required: false);
            SourceExpression.Validate(bodyeSTIMATEDNETCHARGE, nameof(bodyeSTIMATEDNETCHARGE), required: false);
            SourceExpression.Validate(bodypREVIOUSSIBLINGID, nameof(bodypREVIOUSSIBLINGID), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL1, nameof(bodyaCTIONLABELL1), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL2, nameof(bodyaCTIONLABELL2), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL3, nameof(bodyaCTIONLABELL3), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL4, nameof(bodyaCTIONLABELL4), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL5, nameof(bodyaCTIONLABELL5), required: false);
            SourceExpression.Validate(bodyaCTIONLABELL6, nameof(bodyaCTIONLABELL6), required: false);
            SourceExpression.Validate(bodyhISTORYID, nameof(bodyhISTORYID), required: false);
            SourceExpression.Validate(bodytOTRUNC, nameof(bodytOTRUNC), required: false);
            SourceExpression.Validate(bodysTAGEID, nameof(bodysTAGEID), required: false);
            SourceExpression.Validate(bodyiSLOCKEDPROGRESSPOINT, nameof(bodyiSLOCKEDPROGRESSPOINT), required: false);
            SourceExpression.Validate(bodyoRIGINTOOLID, nameof(bodyoRIGINTOOLID), required: false);
            SourceExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            SourceExpression.Validate(bodyeLASTDATESUPDATE, nameof(bodyeLASTDATESUPDATE), required: false);
            SourceExpression.Validate(bodybILLEDTIME, nameof(bodybILLEDTIME), required: false);
            SourceExpression.Validate(bodyiSBILLINGREVIEWED, nameof(bodyiSBILLINGREVIEWED), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaCTIONNUMBER != null)
                {
                    body["ACTION_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyaCTIONNUMBER);
                    bodypropCount++;
                }

                if (bodyaSSETID != null)
                {
                    body["ASSET_ID"] = SourceExpressionConverter.ConvertToken(bodyaSSETID);
                    bodypropCount++;
                }

                if (bodypARENTACTIONID != null)
                {
                    body["PARENT_ACTION_ID"] = SourceExpressionConverter.ConvertToken(bodypARENTACTIONID);
                    bodypropCount++;
                }

                if (bodysUPPLIERID != null)
                {
                    body["SUPPLIER_ID"] = SourceExpressionConverter.ConvertToken(bodysUPPLIERID);
                    bodypropCount++;
                }

                if (bodydONEBYID != null)
                {
                    body["DONE_BY_ID"] = SourceExpressionConverter.ConvertToken(bodydONEBYID);
                    bodypropCount++;
                }

                if (bodyvALIDATORID != null)
                {
                    body["VALIDATOR_ID"] = SourceExpressionConverter.ConvertToken(bodyvALIDATORID);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELEN != null)
                {
                    body["ACTION_LABEL_EN"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELEN);
                    bodypropCount++;
                }

                if (bodytABLENAME != null)
                {
                    body["TABLE_NAME"] = SourceExpressionConverter.ConvertToken(bodytABLENAME);
                    bodypropCount++;
                }

                if (bodyfIELDNAME != null)
                {
                    body["FIELD_NAME"] = SourceExpressionConverter.ConvertToken(bodyfIELDNAME);
                    bodypropCount++;
                }

                if (bodyoLDVALUE != null)
                {
                    body["OLD_VALUE"] = SourceExpressionConverter.ConvertToken(bodyoLDVALUE);
                    bodypropCount++;
                }

                if (bodynEWVALUE != null)
                {
                    body["NEW_VALUE"] = SourceExpressionConverter.ConvertToken(bodynEWVALUE);
                    bodypropCount++;
                }

                if (bodydELETEACTION != null)
                {
                    body["DELETE_ACTION"] = SourceExpressionConverter.ConvertToken(bodydELETEACTION);
                    bodypropCount++;
                }

                if (bodyaUTOMATICACTION != null)
                {
                    body["AUTOMATIC_ACTION"] = SourceExpressionConverter.ConvertToken(bodyaUTOMATICACTION);
                    bodypropCount++;
                }

                if (bodypROCESSSTEPID != null)
                {
                    body["PROCESS_STEP_ID"] = SourceExpressionConverter.ConvertToken(bodypROCESSSTEPID);
                    bodypropCount++;
                }

                if (bodyrEQUESTID != null)
                {
                    body["REQUEST_ID"] = SourceExpressionConverter.ConvertToken(bodyrEQUESTID);
                    bodypropCount++;
                }

                if (bodydESCRIPTION != null)
                {
                    body["DESCRIPTION"] = SourceExpressionConverter.ConvertToken(bodydESCRIPTION);
                    bodypropCount++;
                }

                if (bodynETCHARGE != null)
                {
                    body["NET_CHARGE"] = SourceExpressionConverter.ConvertToken(bodynETCHARGE);
                    bodypropCount++;
                }

                if (bodynETCHARGECURID != null)
                {
                    body["NET_CHARGE_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodynETCHARGECURID);
                    bodypropCount++;
                }

                if (bodyrESOLUTION != null)
                {
                    body["RESOLUTION"] = SourceExpressionConverter.ConvertToken(bodyrESOLUTION);
                    bodypropCount++;
                }

                if (bodylOCATIONID != null)
                {
                    body["LOCATION_ID"] = SourceExpressionConverter.ConvertToken(bodylOCATIONID);
                    bodypropCount++;
                }

                if (bodysUPPORTSTAFFID != null)
                {
                    body["SUPPORT_STAFF_ID"] = SourceExpressionConverter.ConvertToken(bodysUPPORTSTAFFID);
                    bodypropCount++;
                }

                if (bodycONTACTID != null)
                {
                    body["CONTACT_ID"] = SourceExpressionConverter.ConvertToken(bodycONTACTID);
                    bodypropCount++;
                }

                if (bodyeXPECTEDENDDATEUT != null)
                {
                    body["EXPECTED_END_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodyeXPECTEDENDDATEUT);
                    bodypropCount++;
                }

                if (bodycOMMENT != null)
                {
                    body["COMMENT"] = SourceExpressionConverter.ConvertToken(bodycOMMENT);
                    bodypropCount++;
                }

                if (bodysTARTDATEUT != null)
                {
                    body["START_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodysTARTDATEUT);
                    bodypropCount++;
                }

                if (bodyeNDDATEUT != null)
                {
                    body["END_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodyeNDDATEUT);
                    bodypropCount++;
                }

                if (bodyrENEWALDATEUT != null)
                {
                    body["RENEWAL_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodyrENEWALDATEUT);
                    bodypropCount++;
                }

                if (bodyeXPECTEDSTARTDATEUT != null)
                {
                    body["EXPECTED_START_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodyeXPECTEDSTARTDATEUT);
                    bodypropCount++;
                }

                if (bodycREATIONDATEUT != null)
                {
                    body["CREATION_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodycREATIONDATEUT);
                    bodypropCount++;
                }

                if (bodyaPPLICATIONDATEUT != null)
                {
                    body["APPLICATION_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodyaPPLICATIONDATEUT);
                    bodypropCount++;
                }

                if (bodywIZARDGUID != null)
                {
                    body["WIZARD_GUID"] = SourceExpressionConverter.ConvertToken(bodywIZARDGUID);
                    bodypropCount++;
                }

                if (bodygROUPID != null)
                {
                    body["GROUP_ID"] = SourceExpressionConverter.ConvertToken(bodygROUPID);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELFR != null)
                {
                    body["ACTION_LABEL_FR"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELFR);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELSP != null)
                {
                    body["ACTION_LABEL_SP"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELSP);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELGE != null)
                {
                    body["ACTION_LABEL_GE"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELGE);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELIT != null)
                {
                    body["ACTION_LABEL_IT"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELIT);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELPO != null)
                {
                    body["ACTION_LABEL_PO"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELPO);
                    bodypropCount++;
                }

                if (bodykNOWNPROBLEMID != null)
                {
                    body["KNOWN_PROBLEM_ID"] = SourceExpressionConverter.ConvertToken(bodykNOWNPROBLEMID);
                    bodypropCount++;
                }

                if (bodymAXINTERVENTIONDATEUT != null)
                {
                    body["MAX_INTERVENTION_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodymAXINTERVENTIONDATEUT);
                    bodypropCount++;
                }

                if (bodyeLAPSEDTIME != null)
                {
                    body["ELAPSED_TIME"] = SourceExpressionConverter.ConvertToken(bodyeLAPSEDTIME);
                    bodypropCount++;
                }

                if (bodypRIORITYID != null)
                {
                    body["PRIORITY_ID"] = SourceExpressionConverter.ConvertToken(bodypRIORITYID);
                    bodypropCount++;
                }

                if (bodytAXID != null)
                {
                    body["TAX_ID"] = SourceExpressionConverter.ConvertToken(bodytAXID);
                    bodypropCount++;
                }

                if (bodysTATUSIDONCREATE != null)
                {
                    body["STATUS_ID_ON_CREATE"] = SourceExpressionConverter.ConvertToken(bodysTATUSIDONCREATE);
                    bodypropCount++;
                }

                if (bodysTATUSIDONTERMINATE != null)
                {
                    body["STATUS_ID_ON_TERMINATE"] = SourceExpressionConverter.ConvertToken(bodysTATUSIDONTERMINATE);
                    bodypropCount++;
                }

                if (bodyaCTIONTYPEID != null)
                {
                    body["ACTION_TYPE_ID"] = SourceExpressionConverter.ConvertToken(bodyaCTIONTYPEID);
                    bodypropCount++;
                }

                if (bodydELAY != null)
                {
                    body["DELAY"] = SourceExpressionConverter.ConvertToken(bodydELAY);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD1 != null)
                {
                    body["AVAILABLE_FIELD_1"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD1);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD2 != null)
                {
                    body["AVAILABLE_FIELD_2"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD2);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD3 != null)
                {
                    body["AVAILABLE_FIELD_3"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD3);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD4 != null)
                {
                    body["AVAILABLE_FIELD_4"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD4);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD5 != null)
                {
                    body["AVAILABLE_FIELD_5"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD5);
                    bodypropCount++;
                }

                if (bodyaVAILABLEFIELD6 != null)
                {
                    body["AVAILABLE_FIELD_6"] = SourceExpressionConverter.ConvertToken(bodyaVAILABLEFIELD6);
                    bodypropCount++;
                }

                if (bodytIMEUSEDTOCOMPLETEACTION != null)
                {
                    body["TIME_USED_TO_COMPLETE_ACTION"] = SourceExpressionConverter.ConvertToken(bodytIMEUSEDTOCOMPLETEACTION);
                    bodypropCount++;
                }

                if (bodycONTRACTUALCOST != null)
                {
                    body["CONTRACTUAL_COST"] = SourceExpressionConverter.ConvertToken(bodycONTRACTUALCOST);
                    bodypropCount++;
                }

                if (bodycONTRACTUALCOSTCURID != null)
                {
                    body["CONTRACTUAL_COST_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodycONTRACTUALCOSTCURID);
                    bodypropCount++;
                }

                if (bodytIMECOST != null)
                {
                    body["TIME_COST"] = SourceExpressionConverter.ConvertToken(bodytIMECOST);
                    bodypropCount++;
                }

                if (bodytIMECOSTCURID != null)
                {
                    body["TIME_COST_CUR_ID"] = SourceExpressionConverter.ConvertToken(bodytIMECOSTCURID);
                    bodypropCount++;
                }

                if (bodyoRIGINACTIONID != null)
                {
                    body["ORIGIN_ACTION_ID"] = SourceExpressionConverter.ConvertToken(bodyoRIGINACTIONID);
                    bodypropCount++;
                }

                if (bodywORKFLOWVALUE != null)
                {
                    body["WORKFLOW_VALUE"] = SourceExpressionConverter.ConvertToken(bodywORKFLOWVALUE);
                    bodypropCount++;
                }

                if (bodycONTINUITYPLANID != null)
                {
                    body["CONTINUITY_PLAN_ID"] = SourceExpressionConverter.ConvertToken(bodycONTINUITYPLANID);
                    bodypropCount++;
                }

                if (bodycATEGORYTESTID != null)
                {
                    body["CATEGORY_TEST_ID"] = SourceExpressionConverter.ConvertToken(bodycATEGORYTESTID);
                    bodypropCount++;
                }

                if (bodywORKFLOWID != null)
                {
                    body["WORKFLOW_ID"] = SourceExpressionConverter.ConvertToken(bodywORKFLOWID);
                    bodypropCount++;
                }

                if (bodyeXITVALUE != null)
                {
                    body["EXIT_VALUE"] = SourceExpressionConverter.ConvertToken(bodyeXITVALUE);
                    bodypropCount++;
                }

                if (bodymAXRESOLUTIONDATEUT != null)
                {
                    body["MAX_RESOLUTION_DATE_UT"] = SourceExpressionConverter.ConvertToken(bodymAXRESOLUTIONDATEUT);
                    bodypropCount++;
                }

                if (bodypERCENTCOMPLETE != null)
                {
                    body["PERCENT_COMPLETE"] = SourceExpressionConverter.ConvertToken(bodypERCENTCOMPLETE);
                    bodypropCount++;
                }

                if (bodyeXPECTEDDURATION != null)
                {
                    body["EXPECTED_DURATION"] = SourceExpressionConverter.ConvertToken(bodyeXPECTEDDURATION);
                    bodypropCount++;
                }

                if (bodywBSTASK != null)
                {
                    body["WBS_TASK"] = SourceExpressionConverter.ConvertToken(bodywBSTASK);
                    bodypropCount++;
                }

                if (bodytASKPERSONCOSTPERHOUR != null)
                {
                    body["TASK_PERSON_COST_PER_HOUR"] = SourceExpressionConverter.ConvertToken(bodytASKPERSONCOSTPERHOUR);
                    bodypropCount++;
                }

                if (bodytASKPLANNEDBUDGET != null)
                {
                    body["TASK_PLANNED_BUDGET"] = SourceExpressionConverter.ConvertToken(bodytASKPLANNEDBUDGET);
                    bodypropCount++;
                }

                if (bodyeSTIMATEDNETCHARGE != null)
                {
                    body["ESTIMATED_NET_CHARGE"] = SourceExpressionConverter.ConvertToken(bodyeSTIMATEDNETCHARGE);
                    bodypropCount++;
                }

                if (bodypREVIOUSSIBLINGID != null)
                {
                    body["PREVIOUS_SIBLING_ID"] = SourceExpressionConverter.ConvertToken(bodypREVIOUSSIBLINGID);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL1 != null)
                {
                    body["ACTION_LABEL_L1"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL1);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL2 != null)
                {
                    body["ACTION_LABEL_L2"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL2);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL3 != null)
                {
                    body["ACTION_LABEL_L3"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL3);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL4 != null)
                {
                    body["ACTION_LABEL_L4"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL4);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL5 != null)
                {
                    body["ACTION_LABEL_L5"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL5);
                    bodypropCount++;
                }

                if (bodyaCTIONLABELL6 != null)
                {
                    body["ACTION_LABEL_L6"] = SourceExpressionConverter.ConvertToken(bodyaCTIONLABELL6);
                    bodypropCount++;
                }

                if (bodyhISTORYID != null)
                {
                    body["HISTORY_ID"] = SourceExpressionConverter.ConvertToken(bodyhISTORYID);
                    bodypropCount++;
                }

                if (bodytOTRUNC != null)
                {
                    body["TO_TRUNC"] = SourceExpressionConverter.ConvertToken(bodytOTRUNC);
                    bodypropCount++;
                }

                if (bodysTAGEID != null)
                {
                    body["STAGE_ID"] = SourceExpressionConverter.ConvertToken(bodysTAGEID);
                    bodypropCount++;
                }

                if (bodyiSLOCKEDPROGRESSPOINT != null)
                {
                    body["IS_LOCKED_PROGRESS_POINT"] = SourceExpressionConverter.ConvertToken(bodyiSLOCKEDPROGRESSPOINT);
                    bodypropCount++;
                }

                if (bodyoRIGINTOOLID != null)
                {
                    body["ORIGIN_TOOL_ID"] = SourceExpressionConverter.ConvertToken(bodyoRIGINTOOLID);
                    bodypropCount++;
                }

                if (bodylASTUPDATE != null)
                {
                    body["LAST_UPDATE"] = SourceExpressionConverter.ConvertToken(bodylASTUPDATE);
                    bodypropCount++;
                }

                if (bodyeLASTDATESUPDATE != null)
                {
                    body["E_LAST_DATES_UPDATE"] = SourceExpressionConverter.ConvertToken(bodyeLASTDATESUPDATE);
                    bodypropCount++;
                }

                if (bodybILLEDTIME != null)
                {
                    body["BILLED_TIME"] = SourceExpressionConverter.ConvertToken(bodybILLEDTIME);
                    bodypropCount++;
                }

                if (bodyiSBILLINGREVIEWED != null)
                {
                    body["IS_BILLING_REVIEWED"] = SourceExpressionConverter.ConvertToken(bodyiSBILLINGREVIEWED);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateActionTicketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<ViewAllAtributesofanAssetsResponse> ViewAllAtributesofanAssets([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(assetId, nameof(assetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/asset-characteristics/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ViewAllAtributesofanAssetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rfcNumber, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvistaservicemana")]
        public IBodyWorkflowAction<UpdateCIResponse> UpdateCI([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> ciId, [WorkflowExpression] Func<string> bodyassetLabel = null, [WorkflowExpression] Func<string> bodypurchasePrice = null, [WorkflowExpression] Func<string> bodyautomaticRenewal = null, [WorkflowExpression] Func<string> bodyestimatedPercentageUse = null, [WorkflowExpression] Func<string> bodyinstallationDate = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodycommentAsset = null)
        {
            SourceExpression.Validate(account, nameof(account), required: true);
            SourceExpression.Validate(ciId, nameof(ciId), required: true);
            SourceExpression.Validate(bodyassetLabel, nameof(bodyassetLabel), required: false);
            SourceExpression.Validate(bodypurchasePrice, nameof(bodypurchasePrice), required: false);
            SourceExpression.Validate(bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            SourceExpression.Validate(bodyestimatedPercentageUse, nameof(bodyestimatedPercentageUse), required: false);
            SourceExpression.Validate(bodyinstallationDate, nameof(bodyinstallationDate), required: false);
            SourceExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            SourceExpression.Validate(bodycommentAsset, nameof(bodycommentAsset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassetLabel != null)
                {
                    body["asset_label"] = SourceExpressionConverter.ConvertToken(bodyassetLabel);
                    bodypropCount++;
                }

                if (bodypurchasePrice != null)
                {
                    body["purchase_price"] = SourceExpressionConverter.ConvertToken(bodypurchasePrice);
                    bodypropCount++;
                }

                if (bodyautomaticRenewal != null)
                {
                    body["automatic_renewal"] = SourceExpressionConverter.ConvertToken(bodyautomaticRenewal);
                    bodypropCount++;
                }

                if (bodyestimatedPercentageUse != null)
                {
                    body["estimated_percentage_use"] = SourceExpressionConverter.ConvertToken(bodyestimatedPercentageUse);
                    bodypropCount++;
                }

                if (bodyinstallationDate != null)
                {
                    body["installation_date"] = SourceExpressionConverter.ConvertToken(bodyinstallationDate);
                    bodypropCount++;
                }

                if (bodyavailableField1 != null)
                {
                    body["available_field_1"] = SourceExpressionConverter.ConvertToken(bodyavailableField1);
                    bodypropCount++;
                }

                if (bodycommentAsset != null)
                {
                    body["comment_asset"] = SourceExpressionConverter.ConvertToken(bodycommentAsset);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateCIResponse>(BuildSourceInput);
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