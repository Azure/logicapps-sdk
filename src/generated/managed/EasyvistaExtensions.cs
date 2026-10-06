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
        [WorkflowExpressionFactory(nameof(__BuildFinishAction))]
        public IBodyWorkflowAction<FinishActionResponse> FinishAction([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyendActionchoice = null, [WorkflowExpression] Func<string> bodyendActiondescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FinishActionResponse> __BuildFinishAction(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<string> bodyendActionchoice = null, WorkflowExpression<string> bodyendActiondescription = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodyendActionchoice, nameof(bodyendActionchoice), required: false);
            WorkflowExpression.Validate(bodyendActiondescription, nameof(bodyendActiondescription), required: false);
            return new DeferredBodyAction<FinishActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/actions/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewAssetsList))]
        public IBodyWorkflowAction<ViewAssetsListResponse> ViewAssetsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewAssetsListResponse> __BuildViewAssetsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAsset))]
        public IBodyWorkflowAction<CreateAssetResponse> CreateAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyassetsInputItem[]> bodyassets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAssetResponse> __BuildCreateAsset(WorkflowExpression<string> account, WorkflowExpression<bodyassetsInputItem[]> bodyassets = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(bodyassets, nameof(bodyassets), required: false);
            return new DeferredBodyAction<CreateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewAsset))]
        public IBodyWorkflowAction<ViewAssetResponse> ViewAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewAssetResponse> __BuildViewAsset(WorkflowExpression<string> account, WorkflowExpression<string> assetId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAsset))]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> bodybEFORELOANDEPARTMENTID = null, [WorkflowExpression] Func<string> bodybEFORELOANEMPLOYEEID = null, [WorkflowExpression] Func<string> bodybEFORELOANLOCATIONID = null, [WorkflowExpression] Func<string> bodybILLINGPERIODICITYINMONTH = null, [WorkflowExpression] Func<string> bodybUYBACKVALUE = null, [WorkflowExpression] Func<string> bodybUYBACKVALUECURID = null, [WorkflowExpression] Func<string> bodycATALOGID = null, [WorkflowExpression] Func<string> bodycHARGEBACK = null, [WorkflowExpression] Func<string> bodycHARGEBACKCURID = null, [WorkflowExpression] Func<string> bodycISTATUSID = null, [WorkflowExpression] Func<string> bodycIVERSION = null, [WorkflowExpression] Func<string> bodycMDEFAULTCHANGEID = null, [WorkflowExpression] Func<string> bodycONFIGURATIONID = null, [WorkflowExpression] Func<string> bodycRITICALLEVELID = null, [WorkflowExpression] Func<string> bodydELIVERYDATE = null, [WorkflowExpression] Func<string> bodydELIVERYNUMBER = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodydEPRECIATIONRULEID = null, [WorkflowExpression] Func<string> bodydHARDWAREGUID = null, [WorkflowExpression] Func<string> bodyeMPLOYEEID = null, [WorkflowExpression] Func<string> bodyeNDOFWARANTY = null, [WorkflowExpression] Func<string> bodyeNTRYDATE = null, [WorkflowExpression] Func<string> bodyeSTIMATEDPERCENTAGEUSE = null, [WorkflowExpression] Func<string> bodyeXPECTEDENDLENDDATE = null, [WorkflowExpression] Func<string> bodyeXPECTEDRETURNDATE = null, [WorkflowExpression] Func<string> bodyfALLENTERM = null, [WorkflowExpression] Func<string> bodyfIXEDASSETNUMBER = null, [WorkflowExpression] Func<string> bodyiNITIALSTART = null, [WorkflowExpression] Func<string> bodyiNSTALLATIONDATE = null, [WorkflowExpression] Func<string> bodyiNTERNALDELIVERYDATE = null, [WorkflowExpression] Func<string> bodyiNVOICENUMBER = null, [WorkflowExpression] Func<string> bodyiSDML = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTPHYSICALINVENTORY = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylICENSEVERSION = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodymAINTENANCECOST = null, [WorkflowExpression] Func<string> bodymAINTENANCECOSTCURID = null, [WorkflowExpression] Func<string> bodymAINUSAGEID = null, [WorkflowExpression] Func<string> bodymAXINSTALLS = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOST = null, [WorkflowExpression] Func<string> bodymONTHLYFIXEDCOSTCURID = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTAL = null, [WorkflowExpression] Func<string> bodymONTHLYNETRENTALCURID = null, [WorkflowExpression] Func<string> bodymONTHDURATION = null, [WorkflowExpression] Func<string> bodynETWORKIDENTIFIER = null, [WorkflowExpression] Func<string> bodynEXTDEPARTMENTID = null, [WorkflowExpression] Func<string> bodynEXTMAINTENANCEDATE = null, [WorkflowExpression] Func<string> bodynEXTSTATUSID = null, [WorkflowExpression] Func<string> bodynEXTUSERAPPLICATIONDATE = null, [WorkflowExpression] Func<string> bodynEXTUSERID = null, [WorkflowExpression] Func<string> bodynOTICE = null, [WorkflowExpression] Func<string> bodyoRDERDETAILSID = null, [WorkflowExpression] Func<string> bodyoRDERNUMBER = null, [WorkflowExpression] Func<string> bodypIPELINESTATUSID = null, [WorkflowExpression] Func<string> bodypOWERCONSUMPTIONWH = null, [WorkflowExpression] Func<string> bodypROCESSORCOUNT = null, [WorkflowExpression] Func<string> bodypROCESSORSOCKETCOUNT = null, [WorkflowExpression] Func<string> bodypURCHASEDATE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICE = null, [WorkflowExpression] Func<string> bodypURCHASEPRICECURID = null, [WorkflowExpression] Func<string> bodypURCHASERATEID = null, [WorkflowExpression] Func<string> bodyrECYCLEDDATE = null, [WorkflowExpression] Func<string> bodyrECYCLINGPROVIDERID = null, [WorkflowExpression] Func<string> bodyrEFORMNUMBER = null, [WorkflowExpression] Func<string> bodyrEMOVEDDATE = null, [WorkflowExpression] Func<string> bodyrENEWALDECISIONID = null, [WorkflowExpression] Func<string> bodyrENEWALVALUE = null, [WorkflowExpression] Func<string> bodyrENEWALVALUECURID = null, [WorkflowExpression] Func<string> bodyrEPAIREDBYID = null, [WorkflowExpression] Func<string> bodyrESALESVALUE = null, [WorkflowExpression] Func<string> bodysCHEDULEDEND = null, [WorkflowExpression] Func<string> bodysDCATALOGID = null, [WorkflowExpression] Func<string> bodysERIALNUMBER = null, [WorkflowExpression] Func<string> bodysLAID = null, [WorkflowExpression] Func<string> bodysTATUSID = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodytERM = null, [WorkflowExpression] Func<string> bodyuPDATECOVERAGETERM = null, [WorkflowExpression] Func<string> bodywARANTYTYPEID = null, [WorkflowExpression] Func<string> bodyassetLabel = null, [WorkflowExpression] Func<string> bodyassetTag = null, [WorkflowExpression] Func<string> bodyautomaticRenewal = null, [WorkflowExpression] Func<string> bodyavailabilitySlaId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycommentAsset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAssetResponse> __BuildUpdateAsset(WorkflowExpression<string> account, WorkflowExpression<string> assetId, WorkflowExpression<string> bodybEFORELOANDEPARTMENTID = null, WorkflowExpression<string> bodybEFORELOANEMPLOYEEID = null, WorkflowExpression<string> bodybEFORELOANLOCATIONID = null, WorkflowExpression<string> bodybILLINGPERIODICITYINMONTH = null, WorkflowExpression<string> bodybUYBACKVALUE = null, WorkflowExpression<string> bodybUYBACKVALUECURID = null, WorkflowExpression<string> bodycATALOGID = null, WorkflowExpression<string> bodycHARGEBACK = null, WorkflowExpression<string> bodycHARGEBACKCURID = null, WorkflowExpression<string> bodycISTATUSID = null, WorkflowExpression<string> bodycIVERSION = null, WorkflowExpression<string> bodycMDEFAULTCHANGEID = null, WorkflowExpression<string> bodycONFIGURATIONID = null, WorkflowExpression<string> bodycRITICALLEVELID = null, WorkflowExpression<string> bodydELIVERYDATE = null, WorkflowExpression<string> bodydELIVERYNUMBER = null, WorkflowExpression<string> bodydEPARTMENTID = null, WorkflowExpression<string> bodydEPRECIATIONRULEID = null, WorkflowExpression<string> bodydHARDWAREGUID = null, WorkflowExpression<string> bodyeMPLOYEEID = null, WorkflowExpression<string> bodyeNDOFWARANTY = null, WorkflowExpression<string> bodyeNTRYDATE = null, WorkflowExpression<string> bodyeSTIMATEDPERCENTAGEUSE = null, WorkflowExpression<string> bodyeXPECTEDENDLENDDATE = null, WorkflowExpression<string> bodyeXPECTEDRETURNDATE = null, WorkflowExpression<string> bodyfALLENTERM = null, WorkflowExpression<string> bodyfIXEDASSETNUMBER = null, WorkflowExpression<string> bodyiNITIALSTART = null, WorkflowExpression<string> bodyiNSTALLATIONDATE = null, WorkflowExpression<string> bodyiNTERNALDELIVERYDATE = null, WorkflowExpression<string> bodyiNVOICENUMBER = null, WorkflowExpression<string> bodyiSDML = null, WorkflowExpression<string> bodylASTINTEGRATION = null, WorkflowExpression<string> bodylASTPHYSICALINVENTORY = null, WorkflowExpression<string> bodylASTUPDATE = null, WorkflowExpression<string> bodylICENSEVERSION = null, WorkflowExpression<string> bodylOCATIONID = null, WorkflowExpression<string> bodymAINTENANCECOST = null, WorkflowExpression<string> bodymAINTENANCECOSTCURID = null, WorkflowExpression<string> bodymAINUSAGEID = null, WorkflowExpression<string> bodymAXINSTALLS = null, WorkflowExpression<string> bodymONTHLYFIXEDCOST = null, WorkflowExpression<string> bodymONTHLYFIXEDCOSTCURID = null, WorkflowExpression<string> bodymONTHLYNETRENTAL = null, WorkflowExpression<string> bodymONTHLYNETRENTALCURID = null, WorkflowExpression<string> bodymONTHDURATION = null, WorkflowExpression<string> bodynETWORKIDENTIFIER = null, WorkflowExpression<string> bodynEXTDEPARTMENTID = null, WorkflowExpression<string> bodynEXTMAINTENANCEDATE = null, WorkflowExpression<string> bodynEXTSTATUSID = null, WorkflowExpression<string> bodynEXTUSERAPPLICATIONDATE = null, WorkflowExpression<string> bodynEXTUSERID = null, WorkflowExpression<string> bodynOTICE = null, WorkflowExpression<string> bodyoRDERDETAILSID = null, WorkflowExpression<string> bodyoRDERNUMBER = null, WorkflowExpression<string> bodypIPELINESTATUSID = null, WorkflowExpression<string> bodypOWERCONSUMPTIONWH = null, WorkflowExpression<string> bodypROCESSORCOUNT = null, WorkflowExpression<string> bodypROCESSORSOCKETCOUNT = null, WorkflowExpression<string> bodypURCHASEDATE = null, WorkflowExpression<string> bodypURCHASEPRICE = null, WorkflowExpression<string> bodypURCHASEPRICECURID = null, WorkflowExpression<string> bodypURCHASERATEID = null, WorkflowExpression<string> bodyrECYCLEDDATE = null, WorkflowExpression<string> bodyrECYCLINGPROVIDERID = null, WorkflowExpression<string> bodyrEFORMNUMBER = null, WorkflowExpression<string> bodyrEMOVEDDATE = null, WorkflowExpression<string> bodyrENEWALDECISIONID = null, WorkflowExpression<string> bodyrENEWALVALUE = null, WorkflowExpression<string> bodyrENEWALVALUECURID = null, WorkflowExpression<string> bodyrEPAIREDBYID = null, WorkflowExpression<string> bodyrESALESVALUE = null, WorkflowExpression<string> bodysCHEDULEDEND = null, WorkflowExpression<string> bodysDCATALOGID = null, WorkflowExpression<string> bodysERIALNUMBER = null, WorkflowExpression<string> bodysLAID = null, WorkflowExpression<string> bodysTATUSID = null, WorkflowExpression<string> bodysUPPLIERID = null, WorkflowExpression<string> bodytERM = null, WorkflowExpression<string> bodyuPDATECOVERAGETERM = null, WorkflowExpression<string> bodywARANTYTYPEID = null, WorkflowExpression<string> bodyassetLabel = null, WorkflowExpression<string> bodyassetTag = null, WorkflowExpression<string> bodyautomaticRenewal = null, WorkflowExpression<string> bodyavailabilitySlaId = null, WorkflowExpression<string> bodyavailableField1 = null, WorkflowExpression<string> bodyavailableField2 = null, WorkflowExpression<string> bodyavailableField3 = null, WorkflowExpression<string> bodyavailableField4 = null, WorkflowExpression<string> bodyavailableField5 = null, WorkflowExpression<string> bodyavailableField6 = null, WorkflowExpression<string> bodycommentAsset = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            WorkflowExpression.Validate(bodybEFORELOANDEPARTMENTID, nameof(bodybEFORELOANDEPARTMENTID), required: false);
            WorkflowExpression.Validate(bodybEFORELOANEMPLOYEEID, nameof(bodybEFORELOANEMPLOYEEID), required: false);
            WorkflowExpression.Validate(bodybEFORELOANLOCATIONID, nameof(bodybEFORELOANLOCATIONID), required: false);
            WorkflowExpression.Validate(bodybILLINGPERIODICITYINMONTH, nameof(bodybILLINGPERIODICITYINMONTH), required: false);
            WorkflowExpression.Validate(bodybUYBACKVALUE, nameof(bodybUYBACKVALUE), required: false);
            WorkflowExpression.Validate(bodybUYBACKVALUECURID, nameof(bodybUYBACKVALUECURID), required: false);
            WorkflowExpression.Validate(bodycATALOGID, nameof(bodycATALOGID), required: false);
            WorkflowExpression.Validate(bodycHARGEBACK, nameof(bodycHARGEBACK), required: false);
            WorkflowExpression.Validate(bodycHARGEBACKCURID, nameof(bodycHARGEBACKCURID), required: false);
            WorkflowExpression.Validate(bodycISTATUSID, nameof(bodycISTATUSID), required: false);
            WorkflowExpression.Validate(bodycIVERSION, nameof(bodycIVERSION), required: false);
            WorkflowExpression.Validate(bodycMDEFAULTCHANGEID, nameof(bodycMDEFAULTCHANGEID), required: false);
            WorkflowExpression.Validate(bodycONFIGURATIONID, nameof(bodycONFIGURATIONID), required: false);
            WorkflowExpression.Validate(bodycRITICALLEVELID, nameof(bodycRITICALLEVELID), required: false);
            WorkflowExpression.Validate(bodydELIVERYDATE, nameof(bodydELIVERYDATE), required: false);
            WorkflowExpression.Validate(bodydELIVERYNUMBER, nameof(bodydELIVERYNUMBER), required: false);
            WorkflowExpression.Validate(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            WorkflowExpression.Validate(bodydEPRECIATIONRULEID, nameof(bodydEPRECIATIONRULEID), required: false);
            WorkflowExpression.Validate(bodydHARDWAREGUID, nameof(bodydHARDWAREGUID), required: false);
            WorkflowExpression.Validate(bodyeMPLOYEEID, nameof(bodyeMPLOYEEID), required: false);
            WorkflowExpression.Validate(bodyeNDOFWARANTY, nameof(bodyeNDOFWARANTY), required: false);
            WorkflowExpression.Validate(bodyeNTRYDATE, nameof(bodyeNTRYDATE), required: false);
            WorkflowExpression.Validate(bodyeSTIMATEDPERCENTAGEUSE, nameof(bodyeSTIMATEDPERCENTAGEUSE), required: false);
            WorkflowExpression.Validate(bodyeXPECTEDENDLENDDATE, nameof(bodyeXPECTEDENDLENDDATE), required: false);
            WorkflowExpression.Validate(bodyeXPECTEDRETURNDATE, nameof(bodyeXPECTEDRETURNDATE), required: false);
            WorkflowExpression.Validate(bodyfALLENTERM, nameof(bodyfALLENTERM), required: false);
            WorkflowExpression.Validate(bodyfIXEDASSETNUMBER, nameof(bodyfIXEDASSETNUMBER), required: false);
            WorkflowExpression.Validate(bodyiNITIALSTART, nameof(bodyiNITIALSTART), required: false);
            WorkflowExpression.Validate(bodyiNSTALLATIONDATE, nameof(bodyiNSTALLATIONDATE), required: false);
            WorkflowExpression.Validate(bodyiNTERNALDELIVERYDATE, nameof(bodyiNTERNALDELIVERYDATE), required: false);
            WorkflowExpression.Validate(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            WorkflowExpression.Validate(bodyiSDML, nameof(bodyiSDML), required: false);
            WorkflowExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            WorkflowExpression.Validate(bodylASTPHYSICALINVENTORY, nameof(bodylASTPHYSICALINVENTORY), required: false);
            WorkflowExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            WorkflowExpression.Validate(bodylICENSEVERSION, nameof(bodylICENSEVERSION), required: false);
            WorkflowExpression.Validate(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            WorkflowExpression.Validate(bodymAINTENANCECOST, nameof(bodymAINTENANCECOST), required: false);
            WorkflowExpression.Validate(bodymAINTENANCECOSTCURID, nameof(bodymAINTENANCECOSTCURID), required: false);
            WorkflowExpression.Validate(bodymAINUSAGEID, nameof(bodymAINUSAGEID), required: false);
            WorkflowExpression.Validate(bodymAXINSTALLS, nameof(bodymAXINSTALLS), required: false);
            WorkflowExpression.Validate(bodymONTHLYFIXEDCOST, nameof(bodymONTHLYFIXEDCOST), required: false);
            WorkflowExpression.Validate(bodymONTHLYFIXEDCOSTCURID, nameof(bodymONTHLYFIXEDCOSTCURID), required: false);
            WorkflowExpression.Validate(bodymONTHLYNETRENTAL, nameof(bodymONTHLYNETRENTAL), required: false);
            WorkflowExpression.Validate(bodymONTHLYNETRENTALCURID, nameof(bodymONTHLYNETRENTALCURID), required: false);
            WorkflowExpression.Validate(bodymONTHDURATION, nameof(bodymONTHDURATION), required: false);
            WorkflowExpression.Validate(bodynETWORKIDENTIFIER, nameof(bodynETWORKIDENTIFIER), required: false);
            WorkflowExpression.Validate(bodynEXTDEPARTMENTID, nameof(bodynEXTDEPARTMENTID), required: false);
            WorkflowExpression.Validate(bodynEXTMAINTENANCEDATE, nameof(bodynEXTMAINTENANCEDATE), required: false);
            WorkflowExpression.Validate(bodynEXTSTATUSID, nameof(bodynEXTSTATUSID), required: false);
            WorkflowExpression.Validate(bodynEXTUSERAPPLICATIONDATE, nameof(bodynEXTUSERAPPLICATIONDATE), required: false);
            WorkflowExpression.Validate(bodynEXTUSERID, nameof(bodynEXTUSERID), required: false);
            WorkflowExpression.Validate(bodynOTICE, nameof(bodynOTICE), required: false);
            WorkflowExpression.Validate(bodyoRDERDETAILSID, nameof(bodyoRDERDETAILSID), required: false);
            WorkflowExpression.Validate(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            WorkflowExpression.Validate(bodypIPELINESTATUSID, nameof(bodypIPELINESTATUSID), required: false);
            WorkflowExpression.Validate(bodypOWERCONSUMPTIONWH, nameof(bodypOWERCONSUMPTIONWH), required: false);
            WorkflowExpression.Validate(bodypROCESSORCOUNT, nameof(bodypROCESSORCOUNT), required: false);
            WorkflowExpression.Validate(bodypROCESSORSOCKETCOUNT, nameof(bodypROCESSORSOCKETCOUNT), required: false);
            WorkflowExpression.Validate(bodypURCHASEDATE, nameof(bodypURCHASEDATE), required: false);
            WorkflowExpression.Validate(bodypURCHASEPRICE, nameof(bodypURCHASEPRICE), required: false);
            WorkflowExpression.Validate(bodypURCHASEPRICECURID, nameof(bodypURCHASEPRICECURID), required: false);
            WorkflowExpression.Validate(bodypURCHASERATEID, nameof(bodypURCHASERATEID), required: false);
            WorkflowExpression.Validate(bodyrECYCLEDDATE, nameof(bodyrECYCLEDDATE), required: false);
            WorkflowExpression.Validate(bodyrECYCLINGPROVIDERID, nameof(bodyrECYCLINGPROVIDERID), required: false);
            WorkflowExpression.Validate(bodyrEFORMNUMBER, nameof(bodyrEFORMNUMBER), required: false);
            WorkflowExpression.Validate(bodyrEMOVEDDATE, nameof(bodyrEMOVEDDATE), required: false);
            WorkflowExpression.Validate(bodyrENEWALDECISIONID, nameof(bodyrENEWALDECISIONID), required: false);
            WorkflowExpression.Validate(bodyrENEWALVALUE, nameof(bodyrENEWALVALUE), required: false);
            WorkflowExpression.Validate(bodyrENEWALVALUECURID, nameof(bodyrENEWALVALUECURID), required: false);
            WorkflowExpression.Validate(bodyrEPAIREDBYID, nameof(bodyrEPAIREDBYID), required: false);
            WorkflowExpression.Validate(bodyrESALESVALUE, nameof(bodyrESALESVALUE), required: false);
            WorkflowExpression.Validate(bodysCHEDULEDEND, nameof(bodysCHEDULEDEND), required: false);
            WorkflowExpression.Validate(bodysDCATALOGID, nameof(bodysDCATALOGID), required: false);
            WorkflowExpression.Validate(bodysERIALNUMBER, nameof(bodysERIALNUMBER), required: false);
            WorkflowExpression.Validate(bodysLAID, nameof(bodysLAID), required: false);
            WorkflowExpression.Validate(bodysTATUSID, nameof(bodysTATUSID), required: false);
            WorkflowExpression.Validate(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            WorkflowExpression.Validate(bodytERM, nameof(bodytERM), required: false);
            WorkflowExpression.Validate(bodyuPDATECOVERAGETERM, nameof(bodyuPDATECOVERAGETERM), required: false);
            WorkflowExpression.Validate(bodywARANTYTYPEID, nameof(bodywARANTYTYPEID), required: false);
            WorkflowExpression.Validate(bodyassetLabel, nameof(bodyassetLabel), required: false);
            WorkflowExpression.Validate(bodyassetTag, nameof(bodyassetTag), required: false);
            WorkflowExpression.Validate(bodyautomaticRenewal, nameof(bodyautomaticRenewal), required: false);
            WorkflowExpression.Validate(bodyavailabilitySlaId, nameof(bodyavailabilitySlaId), required: false);
            WorkflowExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            WorkflowExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            WorkflowExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            WorkflowExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            WorkflowExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            WorkflowExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            WorkflowExpression.Validate(bodycommentAsset, nameof(bodycommentAsset), required: false);
            return new DeferredBodyAction<UpdateAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewAssetLinks))]
        public IBodyWorkflowAction<ViewAssetLinksResponse> ViewAssetLinks([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewAssetLinksResponse> __BuildViewAssetLinks(WorkflowExpression<string> account, WorkflowExpression<string> assetId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            return new DeferredBodyAction<ViewAssetLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAssetLink))]
        public IBodyWorkflowAction<string> DeleteAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteAssetLink(WorkflowExpression<string> account, WorkflowExpression<string> assetId, WorkflowExpression<string> parentAssetId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            WorkflowExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAssetLink))]
        public IBodyWorkflowAction<CreateAssetLinkResponse> CreateAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAssetLinkResponse> __BuildCreateAssetLink(WorkflowExpression<string> account, WorkflowExpression<string> assetId, WorkflowExpression<string> parentAssetId, WorkflowExpression<string> bodycontractRow = null, WorkflowExpression<string> bodymonthlyPayment = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            WorkflowExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            WorkflowExpression.Validate(bodycontractRow, nameof(bodycontractRow), required: false);
            WorkflowExpression.Validate(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<CreateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAssetLink))]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> UpdateAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> assetId, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> bodycontractRow = null, [WorkflowExpression] Func<string> bodymonthlyPayment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAssetLinkResponse> __BuildUpdateAssetLink(WorkflowExpression<string> account, WorkflowExpression<string> assetId, WorkflowExpression<string> parentAssetId, WorkflowExpression<string> bodycontractRow = null, WorkflowExpression<string> bodymonthlyPayment = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(assetId, nameof(assetId), required: true);
            WorkflowExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            WorkflowExpression.Validate(bodycontractRow, nameof(bodycontractRow), required: false);
            WorkflowExpression.Validate(bodymonthlyPayment, nameof(bodymonthlyPayment), required: false);
            return new DeferredBodyAction<UpdateAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(assetId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewAssetLink))]
        public IBodyWorkflowAction<ViewAssetLinkResponse> ViewAssetLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentAssetId, [WorkflowExpression] Func<string> childAssetId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewAssetLinkResponse> __BuildViewAssetLink(WorkflowExpression<string> account, WorkflowExpression<string> parentAssetId, WorkflowExpression<string> childAssetId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parentAssetId, nameof(parentAssetId), required: true);
            WorkflowExpression.Validate(childAssetId, nameof(childAssetId), required: true);
            return new DeferredBodyAction<ViewAssetLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/assets/{1}/asset-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentAssetId, 1), ExpressionConverter.ConvertWithUrlEncoding(childAssetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewAssetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogAssetsList))]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> ViewCatalogAssetsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogAssetsListResponse> __BuildViewCatalogAssetsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogAssetsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogAsset))]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> ViewCatalogAsset([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogAssetResponse> __BuildViewCatalogAsset(WorkflowExpression<string> account, WorkflowExpression<string> catalogId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogAssetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-assets/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogRequestsList))]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> ViewCatalogRequestsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogRequestsListResponse> __BuildViewCatalogRequestsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<ViewCatalogRequestsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogRequestsPathList))]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> ViewCatalogRequestsPathList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogRequestsPathListResponse> __BuildViewCatalogRequestsPathList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewCatalogRequestsPathListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogRequestPath))]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> ViewCatalogRequestPath([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogRequestPathResponse> __BuildViewCatalogRequestPath(WorkflowExpression<string> account, WorkflowExpression<string> catalogId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestPathResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests-paths/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewCatalogRequest))]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> ViewCatalogRequest([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> catalogId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewCatalogRequestResponse> __BuildViewCatalogRequest(WorkflowExpression<string> account, WorkflowExpression<string> catalogId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(catalogId, nameof(catalogId), required: true);
            return new DeferredBodyAction<ViewCatalogRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/catalog-requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewCatalogRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewConfigurationItemsList))]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> ViewConfigurationItemsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewConfigurationItemsListResponse> __BuildViewConfigurationItemsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewConfigurationItemsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewConfigurationItem))]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> ViewConfigurationItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewConfigurationItemResponse> __BuildViewConfigurationItem(WorkflowExpression<string> account, WorkflowExpression<string> ciId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewConfigurationItemLinks))]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> ViewConfigurationItemLinks([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> ciId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewConfigurationItemLinksResponse> __BuildViewConfigurationItemLinks(WorkflowExpression<string> account, WorkflowExpression<string> ciId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(ciId, nameof(ciId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(ciId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteConfigurationItemLink))]
        public IBodyWorkflowAction<string> DeleteConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteConfigurationItemLink(WorkflowExpression<string> account, WorkflowExpression<string> parentCiId, WorkflowExpression<string> childCiId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            WorkflowExpression.Validate(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewConfigurationItemLink))]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> ViewConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewConfigurationItemLinkResponse> __BuildViewConfigurationItemLink(WorkflowExpression<string> account, WorkflowExpression<string> parentCiId, WorkflowExpression<string> childCiId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            WorkflowExpression.Validate(childCiId, nameof(childCiId), required: true);
            return new DeferredBodyAction<ViewConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewConfigurationItemLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConfigurationItemLink))]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> CreateConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyrelationTypeID, [WorkflowExpression] Func<string> bodyblocking = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateConfigurationItemLinkResponse> __BuildCreateConfigurationItemLink(WorkflowExpression<string> account, WorkflowExpression<string> parentCiId, WorkflowExpression<string> childCiId, WorkflowExpression<string> bodyrelationTypeID, WorkflowExpression<string> bodyblocking = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            WorkflowExpression.Validate(childCiId, nameof(childCiId), required: true);
            WorkflowExpression.Validate(bodyrelationTypeID, nameof(bodyrelationTypeID), required: true);
            WorkflowExpression.Validate(bodyblocking, nameof(bodyblocking), required: false);
            return new DeferredBodyAction<CreateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateConfigurationItemLink))]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> UpdateConfigurationItemLink([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> parentCiId, [WorkflowExpression] Func<string> childCiId, [WorkflowExpression] Func<string> bodyblocking = null, [WorkflowExpression] Func<string> bodyrelationTypeID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateConfigurationItemLinkResponse> __BuildUpdateConfigurationItemLink(WorkflowExpression<string> account, WorkflowExpression<string> parentCiId, WorkflowExpression<string> childCiId, WorkflowExpression<string> bodyblocking = null, WorkflowExpression<string> bodyrelationTypeID = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(parentCiId, nameof(parentCiId), required: true);
            WorkflowExpression.Validate(childCiId, nameof(childCiId), required: true);
            WorkflowExpression.Validate(bodyblocking, nameof(bodyblocking), required: false);
            WorkflowExpression.Validate(bodyrelationTypeID, nameof(bodyrelationTypeID), required: false);
            return new DeferredBodyAction<UpdateConfigurationItemLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/configuration-items/{1}/item-links/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(parentCiId, 1), ExpressionConverter.ConvertWithUrlEncoding(childCiId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewEntitiesList))]
        public IBodyWorkflowAction<ViewEntitiesListResponse> ViewEntitiesList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewEntitiesListResponse> __BuildViewEntitiesList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEntitiesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewEntity))]
        public IBodyWorkflowAction<ViewEntityResponse> ViewEntity([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> departmentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewEntityResponse> __BuildViewEntity(WorkflowExpression<string> account, WorkflowExpression<string> departmentId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(departmentId, nameof(departmentId), required: true);
            return new DeferredBodyAction<ViewEntityResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/departments/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(departmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEntityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewEmployeesList))]
        public IBodyWorkflowAction<ViewEmployeesListResponse> ViewEmployeesList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewEmployeesListResponse> __BuildViewEmployeesList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewEmployeesListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEmployee))]
        public IBodyWorkflowAction<CreateEmployeeResponse> CreateEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyemployeesInputItem[]> bodyemployees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEmployeeResponse> __BuildCreateEmployee(WorkflowExpression<string> account, WorkflowExpression<bodyemployeesInputItem[]> bodyemployees = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(bodyemployees, nameof(bodyemployees), required: false);
            return new DeferredBodyAction<CreateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewEmployee))]
        public IBodyWorkflowAction<ViewEmployeeResponse> ViewEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> employeeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewEmployeeResponse> __BuildViewEmployee(WorkflowExpression<string> account, WorkflowExpression<string> employeeId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            return new DeferredBodyAction<ViewEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewEmployeeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEmployee))]
        public IBodyWorkflowAction<UpdateEmployeeResponse> UpdateEmployee([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> employeeId, [WorkflowExpression] Func<string> bodyaPPROVEDTOVALIDATE = null, [WorkflowExpression] Func<string> bodyaVAILABILITYSTATUSID = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD1 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD2 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD3 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD4 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD5 = null, [WorkflowExpression] Func<string> bodyaVAILABLEFIELD6 = null, [WorkflowExpression] Func<string> bodybEGINOFCONTRACT = null, [WorkflowExpression] Func<string> bodycELLULARNUMBER = null, [WorkflowExpression] Func<string> bodycHATLOGIN = null, [WorkflowExpression] Func<string> bodycIVILSTATUSID = null, [WorkflowExpression] Func<string> bodycOMMENTEMPLOYEE = null, [WorkflowExpression] Func<string> bodycOSTPERHOUR = null, [WorkflowExpression] Func<string> bodycOSTPERHOURCURID = null, [WorkflowExpression] Func<string> bodydEFAULTCOSTCENTERID = null, [WorkflowExpression] Func<string> bodydELEGATIONFROM = null, [WorkflowExpression] Func<string> bodydELEGATIONID = null, [WorkflowExpression] Func<string> bodydELEGATIONTO = null, [WorkflowExpression] Func<string> bodydEPARTMENTID = null, [WorkflowExpression] Func<string> bodyeNDOFCONTRACT = null, [WorkflowExpression] Func<string> bodyeMAIL = null, [WorkflowExpression] Func<string> bodyfAXNUMBER = null, [WorkflowExpression] Func<string> bodyfUNCTIONID = null, [WorkflowExpression] Func<string> bodyiCQNUMBER = null, [WorkflowExpression] Func<string> bodyiDENTIFICATION = null, [WorkflowExpression] Func<string> bodyiSAUTOMATICSTATUS = null, [WorkflowExpression] Func<string> bodyiTCORRESPONDENT = null, [WorkflowExpression] Func<string> bodylANGUAGEID = null, [WorkflowExpression] Func<string> bodylASTINTEGRATION = null, [WorkflowExpression] Func<string> bodylASTNAME = null, [WorkflowExpression] Func<string> bodylASTUPDATE = null, [WorkflowExpression] Func<string> bodylOCATIONID = null, [WorkflowExpression] Func<string> bodylOGIN = null, [WorkflowExpression] Func<string> bodymANAGERID = null, [WorkflowExpression] Func<string> bodymESSENGERSIGNNAME = null, [WorkflowExpression] Func<string> bodynOTIFICATIONTYPEID = null, [WorkflowExpression] Func<string> bodypASSWDLASTUPDATEUT = null, [WorkflowExpression] Func<string> bodypHONENUMBER = null, [WorkflowExpression] Func<string> bodypICTUREPATH = null, [WorkflowExpression] Func<string> bodysUPPLIERID = null, [WorkflowExpression] Func<string> bodyvALIDATORID = null, [WorkflowExpression] Func<string> bodyvIPLEVELID = null, [WorkflowExpression] Func<string> bodywAVEADDRESS = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateEmployeeResponse> __BuildUpdateEmployee(WorkflowExpression<string> account, WorkflowExpression<string> employeeId, WorkflowExpression<string> bodyaPPROVEDTOVALIDATE = null, WorkflowExpression<string> bodyaVAILABILITYSTATUSID = null, WorkflowExpression<string> bodyaVAILABLEFIELD1 = null, WorkflowExpression<string> bodyaVAILABLEFIELD2 = null, WorkflowExpression<string> bodyaVAILABLEFIELD3 = null, WorkflowExpression<string> bodyaVAILABLEFIELD4 = null, WorkflowExpression<string> bodyaVAILABLEFIELD5 = null, WorkflowExpression<string> bodyaVAILABLEFIELD6 = null, WorkflowExpression<string> bodybEGINOFCONTRACT = null, WorkflowExpression<string> bodycELLULARNUMBER = null, WorkflowExpression<string> bodycHATLOGIN = null, WorkflowExpression<string> bodycIVILSTATUSID = null, WorkflowExpression<string> bodycOMMENTEMPLOYEE = null, WorkflowExpression<string> bodycOSTPERHOUR = null, WorkflowExpression<string> bodycOSTPERHOURCURID = null, WorkflowExpression<string> bodydEFAULTCOSTCENTERID = null, WorkflowExpression<string> bodydELEGATIONFROM = null, WorkflowExpression<string> bodydELEGATIONID = null, WorkflowExpression<string> bodydELEGATIONTO = null, WorkflowExpression<string> bodydEPARTMENTID = null, WorkflowExpression<string> bodyeNDOFCONTRACT = null, WorkflowExpression<string> bodyeMAIL = null, WorkflowExpression<string> bodyfAXNUMBER = null, WorkflowExpression<string> bodyfUNCTIONID = null, WorkflowExpression<string> bodyiCQNUMBER = null, WorkflowExpression<string> bodyiDENTIFICATION = null, WorkflowExpression<string> bodyiSAUTOMATICSTATUS = null, WorkflowExpression<string> bodyiTCORRESPONDENT = null, WorkflowExpression<string> bodylANGUAGEID = null, WorkflowExpression<string> bodylASTINTEGRATION = null, WorkflowExpression<string> bodylASTNAME = null, WorkflowExpression<string> bodylASTUPDATE = null, WorkflowExpression<string> bodylOCATIONID = null, WorkflowExpression<string> bodylOGIN = null, WorkflowExpression<string> bodymANAGERID = null, WorkflowExpression<string> bodymESSENGERSIGNNAME = null, WorkflowExpression<string> bodynOTIFICATIONTYPEID = null, WorkflowExpression<string> bodypASSWDLASTUPDATEUT = null, WorkflowExpression<string> bodypHONENUMBER = null, WorkflowExpression<string> bodypICTUREPATH = null, WorkflowExpression<string> bodysUPPLIERID = null, WorkflowExpression<string> bodyvALIDATORID = null, WorkflowExpression<string> bodyvIPLEVELID = null, WorkflowExpression<string> bodywAVEADDRESS = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(employeeId, nameof(employeeId), required: true);
            WorkflowExpression.Validate(bodyaPPROVEDTOVALIDATE, nameof(bodyaPPROVEDTOVALIDATE), required: false);
            WorkflowExpression.Validate(bodyaVAILABILITYSTATUSID, nameof(bodyaVAILABILITYSTATUSID), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD1, nameof(bodyaVAILABLEFIELD1), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD2, nameof(bodyaVAILABLEFIELD2), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD3, nameof(bodyaVAILABLEFIELD3), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD4, nameof(bodyaVAILABLEFIELD4), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD5, nameof(bodyaVAILABLEFIELD5), required: false);
            WorkflowExpression.Validate(bodyaVAILABLEFIELD6, nameof(bodyaVAILABLEFIELD6), required: false);
            WorkflowExpression.Validate(bodybEGINOFCONTRACT, nameof(bodybEGINOFCONTRACT), required: false);
            WorkflowExpression.Validate(bodycELLULARNUMBER, nameof(bodycELLULARNUMBER), required: false);
            WorkflowExpression.Validate(bodycHATLOGIN, nameof(bodycHATLOGIN), required: false);
            WorkflowExpression.Validate(bodycIVILSTATUSID, nameof(bodycIVILSTATUSID), required: false);
            WorkflowExpression.Validate(bodycOMMENTEMPLOYEE, nameof(bodycOMMENTEMPLOYEE), required: false);
            WorkflowExpression.Validate(bodycOSTPERHOUR, nameof(bodycOSTPERHOUR), required: false);
            WorkflowExpression.Validate(bodycOSTPERHOURCURID, nameof(bodycOSTPERHOURCURID), required: false);
            WorkflowExpression.Validate(bodydEFAULTCOSTCENTERID, nameof(bodydEFAULTCOSTCENTERID), required: false);
            WorkflowExpression.Validate(bodydELEGATIONFROM, nameof(bodydELEGATIONFROM), required: false);
            WorkflowExpression.Validate(bodydELEGATIONID, nameof(bodydELEGATIONID), required: false);
            WorkflowExpression.Validate(bodydELEGATIONTO, nameof(bodydELEGATIONTO), required: false);
            WorkflowExpression.Validate(bodydEPARTMENTID, nameof(bodydEPARTMENTID), required: false);
            WorkflowExpression.Validate(bodyeNDOFCONTRACT, nameof(bodyeNDOFCONTRACT), required: false);
            WorkflowExpression.Validate(bodyeMAIL, nameof(bodyeMAIL), required: false);
            WorkflowExpression.Validate(bodyfAXNUMBER, nameof(bodyfAXNUMBER), required: false);
            WorkflowExpression.Validate(bodyfUNCTIONID, nameof(bodyfUNCTIONID), required: false);
            WorkflowExpression.Validate(bodyiCQNUMBER, nameof(bodyiCQNUMBER), required: false);
            WorkflowExpression.Validate(bodyiDENTIFICATION, nameof(bodyiDENTIFICATION), required: false);
            WorkflowExpression.Validate(bodyiSAUTOMATICSTATUS, nameof(bodyiSAUTOMATICSTATUS), required: false);
            WorkflowExpression.Validate(bodyiTCORRESPONDENT, nameof(bodyiTCORRESPONDENT), required: false);
            WorkflowExpression.Validate(bodylANGUAGEID, nameof(bodylANGUAGEID), required: false);
            WorkflowExpression.Validate(bodylASTINTEGRATION, nameof(bodylASTINTEGRATION), required: false);
            WorkflowExpression.Validate(bodylASTNAME, nameof(bodylASTNAME), required: false);
            WorkflowExpression.Validate(bodylASTUPDATE, nameof(bodylASTUPDATE), required: false);
            WorkflowExpression.Validate(bodylOCATIONID, nameof(bodylOCATIONID), required: false);
            WorkflowExpression.Validate(bodylOGIN, nameof(bodylOGIN), required: false);
            WorkflowExpression.Validate(bodymANAGERID, nameof(bodymANAGERID), required: false);
            WorkflowExpression.Validate(bodymESSENGERSIGNNAME, nameof(bodymESSENGERSIGNNAME), required: false);
            WorkflowExpression.Validate(bodynOTIFICATIONTYPEID, nameof(bodynOTIFICATIONTYPEID), required: false);
            WorkflowExpression.Validate(bodypASSWDLASTUPDATEUT, nameof(bodypASSWDLASTUPDATEUT), required: false);
            WorkflowExpression.Validate(bodypHONENUMBER, nameof(bodypHONENUMBER), required: false);
            WorkflowExpression.Validate(bodypICTUREPATH, nameof(bodypICTUREPATH), required: false);
            WorkflowExpression.Validate(bodysUPPLIERID, nameof(bodysUPPLIERID), required: false);
            WorkflowExpression.Validate(bodyvALIDATORID, nameof(bodyvALIDATORID), required: false);
            WorkflowExpression.Validate(bodyvIPLEVELID, nameof(bodyvIPLEVELID), required: false);
            WorkflowExpression.Validate(bodywAVEADDRESS, nameof(bodywAVEADDRESS), required: false);
            return new DeferredBodyAction<UpdateEmployeeResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/employees/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(employeeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewKnownErrorsList))]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> ViewKnownErrorsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewKnownErrorsListResponse> __BuildViewKnownErrorsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewKnownErrorsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/known-problems", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewKnownErrors))]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> ViewKnownErrors([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> kpId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewKnownErrorsResponse> __BuildViewKnownErrors(WorkflowExpression<string> account, WorkflowExpression<string> kpId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(kpId, nameof(kpId), required: true);
            return new DeferredBodyAction<ViewKnownErrorsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/known-problems/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(kpId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewKnownErrorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewLocationsList))]
        public IBodyWorkflowAction<ViewLocationsListResponse> ViewLocationsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewLocationsListResponse> __BuildViewLocationsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewLocationsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewLocation))]
        public IBodyWorkflowAction<ViewLocationResponse> ViewLocation([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> locationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewLocationResponse> __BuildViewLocation(WorkflowExpression<string> account, WorkflowExpression<string> locationId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<ViewLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/locations/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewManufacturerList))]
        public IBodyWorkflowAction<ViewManufacturerListResponse> ViewManufacturerList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewManufacturerListResponse> __BuildViewManufacturerList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewManufacturerListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                if (maxRows != null)
                    callPayload.Queries["max_rows"] = ExpressionConverter.Convert(maxRows);
                return new ApiConnectionAction<ViewManufacturerListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewManufacturer))]
        public IBodyWorkflowAction<ViewManufacturerResponse> ViewManufacturer([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> manufacturerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewManufacturerResponse> __BuildViewManufacturer(WorkflowExpression<string> account, WorkflowExpression<string> manufacturerId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(manufacturerId, nameof(manufacturerId), required: true);
            return new DeferredBodyAction<ViewManufacturerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/manufacturers/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(manufacturerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewManufacturerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewRequestsIncidentsList))]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> ViewRequestsIncidentsList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewRequestsIncidentsListResponse> __BuildViewRequestsIncidentsList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewRequestsIncidentsListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRequestIncident))]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> CreateRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateRequestIncidentResponse> __BuildCreateRequestIncident(WorkflowExpression<string> account, WorkflowExpression<bodyrequestsInputItem[]> bodyrequests = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(bodyrequests, nameof(bodyrequests), required: false);
            return new DeferredBodyAction<CreateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewRequestIncident))]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> ViewRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewRequestIncidentResponse> __BuildViewRequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCloseRequestIncident))]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> CloseRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodyclosedInputItem[]> bodyclosed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseRequestIncidentResponse> __BuildCloseRequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<bodyclosedInputItem[]> bodyclosed = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodyclosed, nameof(bodyclosed), required: false);
            return new DeferredBodyAction<CloseRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRequestIncident))]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> UpdateRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyanalyticalChargeId = null, [WorkflowExpression] Func<string> bodyassetId = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodybudgetPlanned = null, [WorkflowExpression] Func<string> bodycanBeDuplicated = null, [WorkflowExpression] Func<string> bodyciId = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontinuityPlanId = null, [WorkflowExpression] Func<string> bodycostCenterId = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydelay = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydynamicDetails = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateEnd = null, [WorkflowExpression] Func<string> bodyeffectiveChangeDateStart = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodyestimatedNetPrice = null, [WorkflowExpression] Func<string> bodyexpectedDateUt = null, [WorkflowExpression] Func<string> bodyexpectedDuration = null, [WorkflowExpression] Func<string> bodyexpectedEndDateUt = null, [WorkflowExpression] Func<string> bodyexpectedStartDateUt = null, [WorkflowExpression] Func<string> bodyexternalReference = null, [WorkflowExpression] Func<string> bodyfirstCallResolution = null, [WorkflowExpression] Func<string> bodyhourPerDay = null, [WorkflowExpression] Func<string> bodyimpactId = null, [WorkflowExpression] Func<string> bodyimputationDate = null, [WorkflowExpression] Func<string> bodyisMajorIncident = null, [WorkflowExpression] Func<string> bodyisTemplate = null, [WorkflowExpression] Func<string> bodyknownProblemsId = null, [WorkflowExpression] Func<string> bodylastUpdate = null, [WorkflowExpression] Func<string> bodymark1 = null, [WorkflowExpression] Func<string> bodymark2 = null, [WorkflowExpression] Func<string> bodymaxResolutionDateUt = null, [WorkflowExpression] Func<string> bodymsProjectImportValidationWaiting = null, [WorkflowExpression] Func<string> bodynetPrice = null, [WorkflowExpression] Func<string> bodynetPriceCurId = null, [WorkflowExpression] Func<string> bodyoriginToolId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyowningGroupId = null, [WorkflowExpression] Func<string> bodyplannedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyplannedChangeDateStart = null, [WorkflowExpression] Func<string> bodypmStatusId = null, [WorkflowExpression] Func<string> bodyprojectName = null, [WorkflowExpression] Func<string> bodyprojectStartDateUt = null, [WorkflowExpression] Func<string> bodyqty = null, [WorkflowExpression] Func<string> bodyreleaseId = null, [WorkflowExpression] Func<string> bodyrentalNetPrice = null, [WorkflowExpression] Func<string> bodyrentalNetPriceCurId = null, [WorkflowExpression] Func<string> bodyrequestOriginId = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateEnd = null, [WorkflowExpression] Func<string> bodyrequestedChangeDateStart = null, [WorkflowExpression] Func<string> bodyrequestorId = null, [WorkflowExpression] Func<string> bodyrequestorIpAddress = null, [WorkflowExpression] Func<string> bodyrequestorPhone = null, [WorkflowExpression] Func<string> bodyriskAmount = null, [WorkflowExpression] Func<string> bodyriskDescription = null, [WorkflowExpression] Func<string> bodyriskLevelId = null, [WorkflowExpression] Func<string> bodyrootCauseId = null, [WorkflowExpression] Func<string> bodysubmitDateUt = null, [WorkflowExpression] Func<string> bodytimeUsedToSolveRequest = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateRequestIncidentResponse> __BuildUpdateRequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<string> bodyanalyticalChargeId = null, WorkflowExpression<string> bodyassetId = null, WorkflowExpression<string> bodyavailableField1 = null, WorkflowExpression<string> bodyavailableField2 = null, WorkflowExpression<string> bodyavailableField3 = null, WorkflowExpression<string> bodyavailableField4 = null, WorkflowExpression<string> bodyavailableField5 = null, WorkflowExpression<string> bodyavailableField6 = null, WorkflowExpression<string> bodybudgetPlanned = null, WorkflowExpression<string> bodycanBeDuplicated = null, WorkflowExpression<string> bodyciId = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodycontinuityPlanId = null, WorkflowExpression<string> bodycostCenterId = null, WorkflowExpression<string> bodycreationDateUt = null, WorkflowExpression<string> bodydelay = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodydynamicDetails = null, WorkflowExpression<string> bodyeffectiveChangeDateEnd = null, WorkflowExpression<string> bodyeffectiveChangeDateStart = null, WorkflowExpression<string> bodyendDateUt = null, WorkflowExpression<string> bodyestimatedNetPrice = null, WorkflowExpression<string> bodyexpectedDateUt = null, WorkflowExpression<string> bodyexpectedDuration = null, WorkflowExpression<string> bodyexpectedEndDateUt = null, WorkflowExpression<string> bodyexpectedStartDateUt = null, WorkflowExpression<string> bodyexternalReference = null, WorkflowExpression<string> bodyfirstCallResolution = null, WorkflowExpression<string> bodyhourPerDay = null, WorkflowExpression<string> bodyimpactId = null, WorkflowExpression<string> bodyimputationDate = null, WorkflowExpression<string> bodyisMajorIncident = null, WorkflowExpression<string> bodyisTemplate = null, WorkflowExpression<string> bodyknownProblemsId = null, WorkflowExpression<string> bodylastUpdate = null, WorkflowExpression<string> bodymark1 = null, WorkflowExpression<string> bodymark2 = null, WorkflowExpression<string> bodymaxResolutionDateUt = null, WorkflowExpression<string> bodymsProjectImportValidationWaiting = null, WorkflowExpression<string> bodynetPrice = null, WorkflowExpression<string> bodynetPriceCurId = null, WorkflowExpression<string> bodyoriginToolId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyowningGroupId = null, WorkflowExpression<string> bodyplannedChangeDateEnd = null, WorkflowExpression<string> bodyplannedChangeDateStart = null, WorkflowExpression<string> bodypmStatusId = null, WorkflowExpression<string> bodyprojectName = null, WorkflowExpression<string> bodyprojectStartDateUt = null, WorkflowExpression<string> bodyqty = null, WorkflowExpression<string> bodyreleaseId = null, WorkflowExpression<string> bodyrentalNetPrice = null, WorkflowExpression<string> bodyrentalNetPriceCurId = null, WorkflowExpression<string> bodyrequestOriginId = null, WorkflowExpression<string> bodyrequestedChangeDateEnd = null, WorkflowExpression<string> bodyrequestedChangeDateStart = null, WorkflowExpression<string> bodyrequestorId = null, WorkflowExpression<string> bodyrequestorIpAddress = null, WorkflowExpression<string> bodyrequestorPhone = null, WorkflowExpression<string> bodyriskAmount = null, WorkflowExpression<string> bodyriskDescription = null, WorkflowExpression<string> bodyriskLevelId = null, WorkflowExpression<string> bodyrootCauseId = null, WorkflowExpression<string> bodysubmitDateUt = null, WorkflowExpression<string> bodytimeUsedToSolveRequest = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodyanalyticalChargeId, nameof(bodyanalyticalChargeId), required: false);
            WorkflowExpression.Validate(bodyassetId, nameof(bodyassetId), required: false);
            WorkflowExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            WorkflowExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            WorkflowExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            WorkflowExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            WorkflowExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            WorkflowExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            WorkflowExpression.Validate(bodybudgetPlanned, nameof(bodybudgetPlanned), required: false);
            WorkflowExpression.Validate(bodycanBeDuplicated, nameof(bodycanBeDuplicated), required: false);
            WorkflowExpression.Validate(bodyciId, nameof(bodyciId), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodycontinuityPlanId, nameof(bodycontinuityPlanId), required: false);
            WorkflowExpression.Validate(bodycostCenterId, nameof(bodycostCenterId), required: false);
            WorkflowExpression.Validate(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            WorkflowExpression.Validate(bodydelay, nameof(bodydelay), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodydynamicDetails, nameof(bodydynamicDetails), required: false);
            WorkflowExpression.Validate(bodyeffectiveChangeDateEnd, nameof(bodyeffectiveChangeDateEnd), required: false);
            WorkflowExpression.Validate(bodyeffectiveChangeDateStart, nameof(bodyeffectiveChangeDateStart), required: false);
            WorkflowExpression.Validate(bodyendDateUt, nameof(bodyendDateUt), required: false);
            WorkflowExpression.Validate(bodyestimatedNetPrice, nameof(bodyestimatedNetPrice), required: false);
            WorkflowExpression.Validate(bodyexpectedDateUt, nameof(bodyexpectedDateUt), required: false);
            WorkflowExpression.Validate(bodyexpectedDuration, nameof(bodyexpectedDuration), required: false);
            WorkflowExpression.Validate(bodyexpectedEndDateUt, nameof(bodyexpectedEndDateUt), required: false);
            WorkflowExpression.Validate(bodyexpectedStartDateUt, nameof(bodyexpectedStartDateUt), required: false);
            WorkflowExpression.Validate(bodyexternalReference, nameof(bodyexternalReference), required: false);
            WorkflowExpression.Validate(bodyfirstCallResolution, nameof(bodyfirstCallResolution), required: false);
            WorkflowExpression.Validate(bodyhourPerDay, nameof(bodyhourPerDay), required: false);
            WorkflowExpression.Validate(bodyimpactId, nameof(bodyimpactId), required: false);
            WorkflowExpression.Validate(bodyimputationDate, nameof(bodyimputationDate), required: false);
            WorkflowExpression.Validate(bodyisMajorIncident, nameof(bodyisMajorIncident), required: false);
            WorkflowExpression.Validate(bodyisTemplate, nameof(bodyisTemplate), required: false);
            WorkflowExpression.Validate(bodyknownProblemsId, nameof(bodyknownProblemsId), required: false);
            WorkflowExpression.Validate(bodylastUpdate, nameof(bodylastUpdate), required: false);
            WorkflowExpression.Validate(bodymark1, nameof(bodymark1), required: false);
            WorkflowExpression.Validate(bodymark2, nameof(bodymark2), required: false);
            WorkflowExpression.Validate(bodymaxResolutionDateUt, nameof(bodymaxResolutionDateUt), required: false);
            WorkflowExpression.Validate(bodymsProjectImportValidationWaiting, nameof(bodymsProjectImportValidationWaiting), required: false);
            WorkflowExpression.Validate(bodynetPrice, nameof(bodynetPrice), required: false);
            WorkflowExpression.Validate(bodynetPriceCurId, nameof(bodynetPriceCurId), required: false);
            WorkflowExpression.Validate(bodyoriginToolId, nameof(bodyoriginToolId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyowningGroupId, nameof(bodyowningGroupId), required: false);
            WorkflowExpression.Validate(bodyplannedChangeDateEnd, nameof(bodyplannedChangeDateEnd), required: false);
            WorkflowExpression.Validate(bodyplannedChangeDateStart, nameof(bodyplannedChangeDateStart), required: false);
            WorkflowExpression.Validate(bodypmStatusId, nameof(bodypmStatusId), required: false);
            WorkflowExpression.Validate(bodyprojectName, nameof(bodyprojectName), required: false);
            WorkflowExpression.Validate(bodyprojectStartDateUt, nameof(bodyprojectStartDateUt), required: false);
            WorkflowExpression.Validate(bodyqty, nameof(bodyqty), required: false);
            WorkflowExpression.Validate(bodyreleaseId, nameof(bodyreleaseId), required: false);
            WorkflowExpression.Validate(bodyrentalNetPrice, nameof(bodyrentalNetPrice), required: false);
            WorkflowExpression.Validate(bodyrentalNetPriceCurId, nameof(bodyrentalNetPriceCurId), required: false);
            WorkflowExpression.Validate(bodyrequestOriginId, nameof(bodyrequestOriginId), required: false);
            WorkflowExpression.Validate(bodyrequestedChangeDateEnd, nameof(bodyrequestedChangeDateEnd), required: false);
            WorkflowExpression.Validate(bodyrequestedChangeDateStart, nameof(bodyrequestedChangeDateStart), required: false);
            WorkflowExpression.Validate(bodyrequestorId, nameof(bodyrequestorId), required: false);
            WorkflowExpression.Validate(bodyrequestorIpAddress, nameof(bodyrequestorIpAddress), required: false);
            WorkflowExpression.Validate(bodyrequestorPhone, nameof(bodyrequestorPhone), required: false);
            WorkflowExpression.Validate(bodyriskAmount, nameof(bodyriskAmount), required: false);
            WorkflowExpression.Validate(bodyriskDescription, nameof(bodyriskDescription), required: false);
            WorkflowExpression.Validate(bodyriskLevelId, nameof(bodyriskLevelId), required: false);
            WorkflowExpression.Validate(bodyrootCauseId, nameof(bodyrootCauseId), required: false);
            WorkflowExpression.Validate(bodysubmitDateUt, nameof(bodysubmitDateUt), required: false);
            WorkflowExpression.Validate(bodytimeUsedToSolveRequest, nameof(bodytimeUsedToSolveRequest), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<UpdateRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewRequestIncidentComment))]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> ViewRequestIncidentComment([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewRequestIncidentCommentResponse> __BuildViewRequestIncidentComment(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<ViewRequestIncidentCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/comment", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ViewRequestIncidentCommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildGetRequestIncidentDocumentList))]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> GetRequestIncidentDocumentList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRequestIncidentDocumentListResponse> __BuildGetRequestIncidentDocumentList(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            return new DeferredBodyAction<GetRequestIncidentDocumentListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetRequestIncidentDocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildUploadAndAttachADocumentToARequestIncident))]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> UploadAndAttachADocumentToARequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadAndAttachADocumentToARequestIncidentResponse> __BuildUploadAndAttachADocumentToARequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<bodydocumentsInputItem[]> bodydocuments)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodydocuments, nameof(bodydocuments), required: true);
            return new DeferredBodyAction<UploadAndAttachADocumentToARequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildRestartRequestIncident))]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> RestartRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<int> bodydoneById = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RestartRequestIncidentResponse> __BuildRestartRequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<string> bodycomment = null, WorkflowExpression<int> bodydoneById = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<RestartRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/restart", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildSuspendRequestIncident))]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> SuspendRequestIncident([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodydoneById = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuspendRequestIncidentResponse> __BuildSuspendRequestIncident(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodydoneById = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodydoneById, nameof(bodydoneById), required: false);
            return new DeferredBodyAction<SuspendRequestIncidentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/suspend", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IWorkflowAction CreateTask([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> rfcNumber, [WorkflowExpression] Func<string> bodyactionTypeId, [WorkflowExpression] Func<string> bodyelapsedTime = null, [WorkflowExpression] Func<string> bodyavailableField1 = null, [WorkflowExpression] Func<string> bodyavailableField2 = null, [WorkflowExpression] Func<string> bodyavailableField3 = null, [WorkflowExpression] Func<string> bodyavailableField4 = null, [WorkflowExpression] Func<string> bodyavailableField5 = null, [WorkflowExpression] Func<string> bodyavailableField6 = null, [WorkflowExpression] Func<string> bodycontractualCost = null, [WorkflowExpression] Func<string> bodycreationDateUt = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyendDateUt = null, [WorkflowExpression] Func<string> bodygroupMail = null, [WorkflowExpression] Func<string> bodygroupName = null, [WorkflowExpression] Func<string> bodystartDateUt = null, [WorkflowExpression] Func<string> bodytimeCost = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateTask(WorkflowExpression<string> account, WorkflowExpression<string> rfcNumber, WorkflowExpression<string> bodyactionTypeId, WorkflowExpression<string> bodyelapsedTime = null, WorkflowExpression<string> bodyavailableField1 = null, WorkflowExpression<string> bodyavailableField2 = null, WorkflowExpression<string> bodyavailableField3 = null, WorkflowExpression<string> bodyavailableField4 = null, WorkflowExpression<string> bodyavailableField5 = null, WorkflowExpression<string> bodyavailableField6 = null, WorkflowExpression<string> bodycontractualCost = null, WorkflowExpression<string> bodycreationDateUt = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyendDateUt = null, WorkflowExpression<string> bodygroupMail = null, WorkflowExpression<string> bodygroupName = null, WorkflowExpression<string> bodystartDateUt = null, WorkflowExpression<string> bodytimeCost = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(rfcNumber, nameof(rfcNumber), required: true);
            WorkflowExpression.Validate(bodyactionTypeId, nameof(bodyactionTypeId), required: true);
            WorkflowExpression.Validate(bodyelapsedTime, nameof(bodyelapsedTime), required: false);
            WorkflowExpression.Validate(bodyavailableField1, nameof(bodyavailableField1), required: false);
            WorkflowExpression.Validate(bodyavailableField2, nameof(bodyavailableField2), required: false);
            WorkflowExpression.Validate(bodyavailableField3, nameof(bodyavailableField3), required: false);
            WorkflowExpression.Validate(bodyavailableField4, nameof(bodyavailableField4), required: false);
            WorkflowExpression.Validate(bodyavailableField5, nameof(bodyavailableField5), required: false);
            WorkflowExpression.Validate(bodyavailableField6, nameof(bodyavailableField6), required: false);
            WorkflowExpression.Validate(bodycontractualCost, nameof(bodycontractualCost), required: false);
            WorkflowExpression.Validate(bodycreationDateUt, nameof(bodycreationDateUt), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyendDateUt, nameof(bodyendDateUt), required: false);
            WorkflowExpression.Validate(bodygroupMail, nameof(bodygroupMail), required: false);
            WorkflowExpression.Validate(bodygroupName, nameof(bodygroupName), required: false);
            WorkflowExpression.Validate(bodystartDateUt, nameof(bodystartDateUt), required: false);
            WorkflowExpression.Validate(bodytimeCost, nameof(bodytimeCost), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/requests/{1}/tasks", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(rfcNumber, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewSlasList))]
        public IBodyWorkflowAction<ViewSlasListResponse> ViewSlasList([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> maxRows = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewSlasListResponse> __BuildViewSlasList(WorkflowExpression<string> account, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> maxRows = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(maxRows, nameof(maxRows), required: false);
            return new DeferredBodyAction<ViewSlasListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [WorkflowExpressionFactory(nameof(__BuildViewSla))]
        public IBodyWorkflowAction<ViewSlaResponse> ViewSla([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> slaId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyvista")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ViewSlaResponse> __BuildViewSla(WorkflowExpression<string> account, WorkflowExpression<string> slaId)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(slaId, nameof(slaId), required: true);
            return new DeferredBodyAction<ViewSlaResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/{0}/slas/{1}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(slaId, 1));
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