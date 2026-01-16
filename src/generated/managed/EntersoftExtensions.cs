//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntersoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo> ES00DocumentsInfo(Expression<Func<string>> routeid)
        {
            var apiCallPath = String.Format("/api/ES00Documents/Info/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo[]> ES00DocumentsInfoByEntityGid(Expression<Func<string>> routeid)
        {
            var apiCallPath = String.Format("/api/ES00Documents/InfoByEntityGid/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ES00DocumentsBlobDataByGid(Expression<Func<string>> routeid, Expression<Func<string>> webapitoken = null)
        {
            var apiCallPath = String.Format("/api/ES00Documents/BlobDataByGid/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ES00DocumentsDownloadBlobDataByGID(Expression<Func<string>> routeid, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var apiCallPath = String.Format("/api/ES00Documents/DownloadBlobDataByGID/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            if (partialMode != null)
                callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(partialMode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ES00DocumentsGetES00Blob(Expression<Func<string>> routeid, Expression<Func<string>> extType = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var apiCallPath = String.Format("/api/ES00Documents/GetES00Blob/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (extType != null)
                callPayload.Queries["extType"] = ExpressionConverter.Convert(extType);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            if (partialMode != null)
                callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(partialMode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ES00DocumentsGetES00BlobFromObject(Expression<Func<string>> routeid, Expression<Func<string>> keyid, Expression<Func<int>> typeid, Expression<Func<string>> extType = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var apiCallPath = String.Format("/api/ES00Documents/GetES00BlobFromObject/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["keyid"] = ExpressionConverter.Convert(keyid);
            callPayload.Queries["typeid"] = ExpressionConverter.Convert(typeid);
            if (extType != null)
                callPayload.Queries["extType"] = ExpressionConverter.Convert(extType);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            if (partialMode != null)
                callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(partialMode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string> ES00DocumentsPostBodyToES00Blob(Expression<Func<string>> blobInfoGID = null, Expression<Func<string>> blobInfoObjectID = null, Expression<Func<string>> blobInfoKeyID = null, Expression<Func<int>> blobInfoTypeID = null, Expression<Func<string>> blobInfoExt = null, Expression<Func<string>> blobInfoTextBody = null, Expression<Func<bool>> blobInfoIsNew = null)
        {
            var apiCallPath = "/api/ES00Documents/PostBodyToES00Blob/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var blobInfo = new JObject();
            var blobInfopropCount = 0;
            if (blobInfoGID != null)
            {
                blobInfo["GID"] = ExpressionConverter.ConvertO(blobInfoGID);
                blobInfopropCount++;
            }

            if (blobInfoObjectID != null)
            {
                blobInfo["ObjectID"] = ExpressionConverter.ConvertO(blobInfoObjectID);
                blobInfopropCount++;
            }

            if (blobInfoKeyID != null)
            {
                blobInfo["KeyID"] = ExpressionConverter.ConvertO(blobInfoKeyID);
                blobInfopropCount++;
            }

            if (blobInfoTypeID != null)
            {
                blobInfo["TypeID"] = ExpressionConverter.ConvertO(blobInfoTypeID);
                blobInfopropCount++;
            }

            if (blobInfoExt != null)
            {
                blobInfo["Ext"] = ExpressionConverter.ConvertO(blobInfoExt);
                blobInfopropCount++;
            }

            if (blobInfoTextBody != null)
            {
                blobInfo["TextBody"] = ExpressionConverter.ConvertO(blobInfoTextBody);
                blobInfopropCount++;
            }

            if (blobInfoIsNew != null)
            {
                blobInfo["IsNew"] = ExpressionConverter.ConvertO(blobInfoIsNew);
                blobInfopropCount++;
            }

            if (blobInfopropCount > 0)
            {
                callPayload.Body = blobInfo;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00BlobInfo> ES00DocumentsGetBodyFromES00Blob(Expression<Func<string>> routeid, Expression<Func<string>> keyid = null, Expression<Func<int>> typeid = null)
        {
            var apiCallPath = String.Format("/api/ES00Documents/GetBodyFromES00Blob/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyid != null)
                callPayload.Queries["keyid"] = ExpressionConverter.Convert(keyid);
            if (typeid != null)
                callPayload.Queries["typeid"] = ExpressionConverter.Convert(typeid);
            return new ApiConnectionAction<EntersoftWebApiModelsES00BlobInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ES00DocumentsDeleteES00Document(Expression<Func<string>> paramsGID = null, Expression<Func<string>> paramsCode = null, Expression<Func<string>> paramsTitle = null, Expression<Func<string>> paramsDescription = null, Expression<Func<string>> paramsCaption = null, Expression<Func<string>> paramsEDate = null, Expression<Func<string>> paramsFType = null, Expression<Func<string>> paramsTableID = null, Expression<Func<string>> paramsTableName = null, Expression<Func<string>> paramsfGID = null, Expression<Func<string>> paramsfDetailLineGID = null, Expression<Func<string>> paramsUNCPath = null, Expression<Func<string>> paramsOriginalPath = null, Expression<Func<string>> paramsOriginalFN = null, Expression<Func<string>> paramsfDocCategoryCode = null, Expression<Func<string>> paramsfDocGroupCode = null, Expression<Func<string>> paramsfCompanyCode = null, Expression<Func<string>> paramsfDocumentCategoryCode = null, Expression<Func<string>> paramsfDocumentLocationCode = null, Expression<Func<string>> paramsESDModified = null, Expression<Func<string>> paramsESUModified = null, Expression<Func<string>> paramsESDCreated = null, Expression<Func<string>> paramsESUCreated = null, Expression<Func<bool>> paramsIsBLOB = null, Expression<Func<bool>> paramsIngoing = null, Expression<Func<string>> paramsfRLSNodeGID = null, Expression<Func<int>> paramsBLOBDATALength = null, Expression<Func<string>> paramsBLOBDATA = null)
        {
            var apiCallPath = "/api/ES00Documents/DeleteES00Document/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var @params = new JObject();
            var @paramspropCount = 0;
            if (paramsGID != null)
            {
                @params["GID"] = ExpressionConverter.ConvertO(paramsGID);
                @paramspropCount++;
            }

            if (paramsCode != null)
            {
                @params["Code"] = ExpressionConverter.ConvertO(paramsCode);
                @paramspropCount++;
            }

            if (paramsTitle != null)
            {
                @params["Title"] = ExpressionConverter.ConvertO(paramsTitle);
                @paramspropCount++;
            }

            if (paramsDescription != null)
            {
                @params["Description"] = ExpressionConverter.ConvertO(paramsDescription);
                @paramspropCount++;
            }

            if (paramsCaption != null)
            {
                @params["Caption"] = ExpressionConverter.ConvertO(paramsCaption);
                @paramspropCount++;
            }

            if (paramsEDate != null)
            {
                @params["EDate"] = ExpressionConverter.ConvertO(paramsEDate);
                @paramspropCount++;
            }

            if (paramsFType != null)
            {
                @params["FType"] = ExpressionConverter.ConvertO(paramsFType);
                @paramspropCount++;
            }

            if (paramsTableID != null)
            {
                @params["TableID"] = ExpressionConverter.ConvertO(paramsTableID);
                @paramspropCount++;
            }

            if (paramsTableName != null)
            {
                @params["TableName"] = ExpressionConverter.ConvertO(paramsTableName);
                @paramspropCount++;
            }

            if (paramsfGID != null)
            {
                @params["fGID"] = ExpressionConverter.ConvertO(paramsfGID);
                @paramspropCount++;
            }

            if (paramsfDetailLineGID != null)
            {
                @params["fDetailLineGID"] = ExpressionConverter.ConvertO(paramsfDetailLineGID);
                @paramspropCount++;
            }

            if (paramsUNCPath != null)
            {
                @params["UNCPath"] = ExpressionConverter.ConvertO(paramsUNCPath);
                @paramspropCount++;
            }

            if (paramsOriginalPath != null)
            {
                @params["OriginalPath"] = ExpressionConverter.ConvertO(paramsOriginalPath);
                @paramspropCount++;
            }

            if (paramsOriginalFN != null)
            {
                @params["OriginalFN"] = ExpressionConverter.ConvertO(paramsOriginalFN);
                @paramspropCount++;
            }

            if (paramsfDocCategoryCode != null)
            {
                @params["fDocCategoryCode"] = ExpressionConverter.ConvertO(paramsfDocCategoryCode);
                @paramspropCount++;
            }

            if (paramsfDocGroupCode != null)
            {
                @params["fDocGroupCode"] = ExpressionConverter.ConvertO(paramsfDocGroupCode);
                @paramspropCount++;
            }

            if (paramsfCompanyCode != null)
            {
                @params["fCompanyCode"] = ExpressionConverter.ConvertO(paramsfCompanyCode);
                @paramspropCount++;
            }

            if (paramsfDocumentCategoryCode != null)
            {
                @params["fDocumentCategoryCode"] = ExpressionConverter.ConvertO(paramsfDocumentCategoryCode);
                @paramspropCount++;
            }

            if (paramsfDocumentLocationCode != null)
            {
                @params["fDocumentLocationCode"] = ExpressionConverter.ConvertO(paramsfDocumentLocationCode);
                @paramspropCount++;
            }

            if (paramsESDModified != null)
            {
                @params["ESDModified"] = ExpressionConverter.ConvertO(paramsESDModified);
                @paramspropCount++;
            }

            if (paramsESUModified != null)
            {
                @params["ESUModified"] = ExpressionConverter.ConvertO(paramsESUModified);
                @paramspropCount++;
            }

            if (paramsESDCreated != null)
            {
                @params["ESDCreated"] = ExpressionConverter.ConvertO(paramsESDCreated);
                @paramspropCount++;
            }

            if (paramsESUCreated != null)
            {
                @params["ESUCreated"] = ExpressionConverter.ConvertO(paramsESUCreated);
                @paramspropCount++;
            }

            if (paramsIsBLOB != null)
            {
                @params["IsBLOB"] = ExpressionConverter.ConvertO(paramsIsBLOB);
                @paramspropCount++;
            }

            if (paramsIngoing != null)
            {
                @params["Ingoing"] = ExpressionConverter.ConvertO(paramsIngoing);
                @paramspropCount++;
            }

            if (paramsfRLSNodeGID != null)
            {
                @params["fRLSNodeGID"] = ExpressionConverter.ConvertO(paramsfRLSNodeGID);
                @paramspropCount++;
            }

            if (paramsBLOBDATALength != null)
            {
                @params["BLOBDATALength"] = ExpressionConverter.ConvertO(paramsBLOBDATALength);
                @paramspropCount++;
            }

            if (paramsBLOBDATA != null)
            {
                @params["BLOBDATA"] = ExpressionConverter.ConvertO(paramsBLOBDATA);
                @paramspropCount++;
            }

            if (@paramspropCount > 0)
            {
                callPayload.Body = @params;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo> ES00DocumentsAddOrUpdateAttachedDocument(Expression<Func<string>> inDocGID = null, Expression<Func<string>> inDocCode = null, Expression<Func<string>> inDocTitle = null, Expression<Func<string>> inDocDescription = null, Expression<Func<string>> inDocCaption = null, Expression<Func<string>> inDocEDate = null, Expression<Func<string>> inDocFType = null, Expression<Func<string>> inDocTableID = null, Expression<Func<string>> inDocTableName = null, Expression<Func<string>> inDocfGID = null, Expression<Func<string>> inDocfDetailLineGID = null, Expression<Func<string>> inDocUNCPath = null, Expression<Func<string>> inDocOriginalPath = null, Expression<Func<string>> inDocOriginalFN = null, Expression<Func<string>> inDocfDocCategoryCode = null, Expression<Func<string>> inDocfDocGroupCode = null, Expression<Func<string>> inDocfCompanyCode = null, Expression<Func<string>> inDocfDocumentCategoryCode = null, Expression<Func<string>> inDocfDocumentLocationCode = null, Expression<Func<string>> inDocESDModified = null, Expression<Func<string>> inDocESUModified = null, Expression<Func<string>> inDocESDCreated = null, Expression<Func<string>> inDocESUCreated = null, Expression<Func<bool>> inDocIsBLOB = null, Expression<Func<bool>> inDocIngoing = null, Expression<Func<string>> inDocfRLSNodeGID = null, Expression<Func<int>> inDocBLOBDATALength = null, Expression<Func<string>> inDocBLOBDATA = null)
        {
            var apiCallPath = "/api/ES00Documents/AddOrUpdateAttachedDocument/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inDoc = new JObject();
            var inDocpropCount = 0;
            if (inDocGID != null)
            {
                inDoc["GID"] = ExpressionConverter.ConvertO(inDocGID);
                inDocpropCount++;
            }

            if (inDocCode != null)
            {
                inDoc["Code"] = ExpressionConverter.ConvertO(inDocCode);
                inDocpropCount++;
            }

            if (inDocTitle != null)
            {
                inDoc["Title"] = ExpressionConverter.ConvertO(inDocTitle);
                inDocpropCount++;
            }

            if (inDocDescription != null)
            {
                inDoc["Description"] = ExpressionConverter.ConvertO(inDocDescription);
                inDocpropCount++;
            }

            if (inDocCaption != null)
            {
                inDoc["Caption"] = ExpressionConverter.ConvertO(inDocCaption);
                inDocpropCount++;
            }

            if (inDocEDate != null)
            {
                inDoc["EDate"] = ExpressionConverter.ConvertO(inDocEDate);
                inDocpropCount++;
            }

            if (inDocFType != null)
            {
                inDoc["FType"] = ExpressionConverter.ConvertO(inDocFType);
                inDocpropCount++;
            }

            if (inDocTableID != null)
            {
                inDoc["TableID"] = ExpressionConverter.ConvertO(inDocTableID);
                inDocpropCount++;
            }

            if (inDocTableName != null)
            {
                inDoc["TableName"] = ExpressionConverter.ConvertO(inDocTableName);
                inDocpropCount++;
            }

            if (inDocfGID != null)
            {
                inDoc["fGID"] = ExpressionConverter.ConvertO(inDocfGID);
                inDocpropCount++;
            }

            if (inDocfDetailLineGID != null)
            {
                inDoc["fDetailLineGID"] = ExpressionConverter.ConvertO(inDocfDetailLineGID);
                inDocpropCount++;
            }

            if (inDocUNCPath != null)
            {
                inDoc["UNCPath"] = ExpressionConverter.ConvertO(inDocUNCPath);
                inDocpropCount++;
            }

            if (inDocOriginalPath != null)
            {
                inDoc["OriginalPath"] = ExpressionConverter.ConvertO(inDocOriginalPath);
                inDocpropCount++;
            }

            if (inDocOriginalFN != null)
            {
                inDoc["OriginalFN"] = ExpressionConverter.ConvertO(inDocOriginalFN);
                inDocpropCount++;
            }

            if (inDocfDocCategoryCode != null)
            {
                inDoc["fDocCategoryCode"] = ExpressionConverter.ConvertO(inDocfDocCategoryCode);
                inDocpropCount++;
            }

            if (inDocfDocGroupCode != null)
            {
                inDoc["fDocGroupCode"] = ExpressionConverter.ConvertO(inDocfDocGroupCode);
                inDocpropCount++;
            }

            if (inDocfCompanyCode != null)
            {
                inDoc["fCompanyCode"] = ExpressionConverter.ConvertO(inDocfCompanyCode);
                inDocpropCount++;
            }

            if (inDocfDocumentCategoryCode != null)
            {
                inDoc["fDocumentCategoryCode"] = ExpressionConverter.ConvertO(inDocfDocumentCategoryCode);
                inDocpropCount++;
            }

            if (inDocfDocumentLocationCode != null)
            {
                inDoc["fDocumentLocationCode"] = ExpressionConverter.ConvertO(inDocfDocumentLocationCode);
                inDocpropCount++;
            }

            if (inDocESDModified != null)
            {
                inDoc["ESDModified"] = ExpressionConverter.ConvertO(inDocESDModified);
                inDocpropCount++;
            }

            if (inDocESUModified != null)
            {
                inDoc["ESUModified"] = ExpressionConverter.ConvertO(inDocESUModified);
                inDocpropCount++;
            }

            if (inDocESDCreated != null)
            {
                inDoc["ESDCreated"] = ExpressionConverter.ConvertO(inDocESDCreated);
                inDocpropCount++;
            }

            if (inDocESUCreated != null)
            {
                inDoc["ESUCreated"] = ExpressionConverter.ConvertO(inDocESUCreated);
                inDocpropCount++;
            }

            if (inDocIsBLOB != null)
            {
                inDoc["IsBLOB"] = ExpressionConverter.ConvertO(inDocIsBLOB);
                inDocpropCount++;
            }

            if (inDocIngoing != null)
            {
                inDoc["Ingoing"] = ExpressionConverter.ConvertO(inDocIngoing);
                inDocpropCount++;
            }

            if (inDocfRLSNodeGID != null)
            {
                inDoc["fRLSNodeGID"] = ExpressionConverter.ConvertO(inDocfRLSNodeGID);
                inDocpropCount++;
            }

            if (inDocBLOBDATALength != null)
            {
                inDoc["BLOBDATALength"] = ExpressionConverter.ConvertO(inDocBLOBDATALength);
                inDocpropCount++;
            }

            if (inDocBLOBDATA != null)
            {
                inDoc["BLOBDATA"] = ExpressionConverter.ConvertO(inDocBLOBDATA);
                inDocpropCount++;
            }

            if (inDocpropCount > 0)
            {
                callPayload.Body = inDoc;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESAsset2FetchWebAsset(Expression<Func<string>> routeId, Expression<Func<bool>> base64 = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var apiCallPath = String.Format("/api/asset2/fetchWebAsset/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (base64 != null)
                callPayload.Queries["base64"] = ExpressionConverter.Convert(base64);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            if (partialMode != null)
                callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(partialMode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESAsset2DownloadAsset(Expression<Func<string>> routeId, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var apiCallPath = String.Format("/api/asset2/downloadAsset/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webapitoken != null)
                callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(webapitoken);
            if (partialMode != null)
                callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(partialMode);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESBGBudgetSheetObj> ESBudgetESBGBudgetSheet(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESBudget/ESBGBudgetSheet/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESBGBudgetSheetObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESCollaborationBroadcastMessage(Expression<Func<string[]>> msgRecipients = null, Expression<Func<string>> msgMessage = null)
        {
            var apiCallPath = "/api/collaboration/BroadcastMessage/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var msg = new JObject();
            var msgpropCount = 0;
            if (msgRecipients != null)
            {
                msg["Recipients"] = ExpressionConverter.ConvertO(msgRecipients);
                msgpropCount++;
            }

            if (msgMessage != null)
            {
                msg["Message"] = ExpressionConverter.ConvertO(msgMessage);
                msgpropCount++;
            }

            if (msgpropCount > 0)
            {
                callPayload.Body = msg;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESCollaborationSendEmail(Expression<Func<string>> msgFromEmailAddr = null, Expression<Func<string>> msgToEmailAddr = null, Expression<Func<string>> msgSubject = null, Expression<Func<string>> msgBody = null)
        {
            var apiCallPath = "/api/collaboration/SendEmail/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var msg = new JObject();
            var msgpropCount = 0;
            if (msgFromEmailAddr != null)
            {
                msg["FromEmailAddr"] = ExpressionConverter.ConvertO(msgFromEmailAddr);
                msgpropCount++;
            }

            if (msgToEmailAddr != null)
            {
                msg["ToEmailAddr"] = ExpressionConverter.ConvertO(msgToEmailAddr);
                msgpropCount++;
            }

            if (msgSubject != null)
            {
                msg["Subject"] = ExpressionConverter.ConvertO(msgSubject);
                msgpropCount++;
            }

            if (msgBody != null)
            {
                msg["Body"] = ExpressionConverter.ConvertO(msgBody);
                msgpropCount++;
            }

            if (msgpropCount > 0)
            {
                callPayload.Body = msg;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string[]> ESCollaborationSendSMS(Expression<Func<string>> msgBody = null, Expression<Func<string[]>> msgRecipients = null, Expression<Func<string[]>> msgUsers = null)
        {
            var apiCallPath = "/api/collaboration/SendSMS/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var msg = new JObject();
            var msgpropCount = 0;
            if (msgBody != null)
            {
                msg["Body"] = ExpressionConverter.ConvertO(msgBody);
                msgpropCount++;
            }

            if (msgRecipients != null)
            {
                msg["Recipients"] = ExpressionConverter.ConvertO(msgRecipients);
                msgpropCount++;
            }

            if (msgUsers != null)
            {
                msg["Users"] = ExpressionConverter.ConvertO(msgUsers);
                msgpropCount++;
            }

            if (msgpropCount > 0)
            {
                callPayload.Body = msg;
            }

            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiControllersESViberResponse> ESCollaborationSendViberMessage(Expression<Func<string[]>> msgRecipients = null, Expression<Func<string>> msgDateToSend = null, Expression<Func<int>> msgExpiresInSecs = null, Expression<Func<string>> msgExpiryText = null, Expression<Func<string>> msgfReferenceID = null, Expression<Func<bool>> msgCallback = null, Expression<Func<string>> msgBody = null, Expression<Func<string>> msgImage = null, Expression<Func<string>> msgButtonAction = null, Expression<Func<string>> msgButtonCaption = null, Expression<Func<string>> msgSMSFallbackSMSText = null)
        {
            var apiCallPath = "/api/collaboration/SendViberMessage/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var msg = new JObject();
            var msgpropCount = 0;
            if (msgRecipients != null)
            {
                msg["Recipients"] = ExpressionConverter.ConvertO(msgRecipients);
                msgpropCount++;
            }

            if (msgDateToSend != null)
            {
                msg["DateToSend"] = ExpressionConverter.ConvertO(msgDateToSend);
                msgpropCount++;
            }

            if (msgExpiresInSecs != null)
            {
                msg["ExpiresInSecs"] = ExpressionConverter.ConvertO(msgExpiresInSecs);
                msgpropCount++;
            }

            if (msgExpiryText != null)
            {
                msg["ExpiryText"] = ExpressionConverter.ConvertO(msgExpiryText);
                msgpropCount++;
            }

            if (msgfReferenceID != null)
            {
                msg["fReferenceID"] = ExpressionConverter.ConvertO(msgfReferenceID);
                msgpropCount++;
            }

            if (msgCallback != null)
            {
                msg["Callback"] = ExpressionConverter.ConvertO(msgCallback);
                msgpropCount++;
            }

            if (msgBody != null)
            {
                msg["Body"] = ExpressionConverter.ConvertO(msgBody);
                msgpropCount++;
            }

            if (msgImage != null)
            {
                msg["Image"] = ExpressionConverter.ConvertO(msgImage);
                msgpropCount++;
            }

            if (msgButtonAction != null)
            {
                msg["ButtonAction"] = ExpressionConverter.ConvertO(msgButtonAction);
                msgpropCount++;
            }

            if (msgButtonCaption != null)
            {
                msg["ButtonCaption"] = ExpressionConverter.ConvertO(msgButtonCaption);
                msgpropCount++;
            }

            var ExtraPropertiesObject = new JObject();
            var ExtraPropertiesObjectpropCount = 0;
            if (ExtraPropertiesObjectpropCount > 0)
            {
                msg["ExtraProperties"] = ExtraPropertiesObject;
                msgpropCount++;
            }

            var SMSFallbackObject = new JObject();
            var SMSFallbackObjectpropCount = 0;
            if (msgSMSFallbackSMSText != null)
            {
                SMSFallbackObject["SMSText"] = ExpressionConverter.ConvertO(msgSMSFallbackSMSText);
                SMSFallbackObjectpropCount++;
            }

            if (SMSFallbackObjectpropCount > 0)
            {
                msg["SMSFallback"] = SMSFallbackObject;
                msgpropCount++;
            }

            if (msgpropCount > 0)
            {
                callPayload.Body = msg;
            }

            return new ApiConnectionAction<EntersoftWebApiControllersESViberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESCollaborationCreateRFARequest(Expression<Func<string>> rFARequestid, Expression<Func<string>> rFARequestCode, Expression<Func<string>> rFARequestRequestedBy, Expression<Func<bool>> rFARequestIsExternal, Expression<Func<rFARequestPriorityInput>> rFARequestPriority = null, Expression<Func<string>> rFARequestRequestClass = null, Expression<Func<string>> rFARequestRequestCategory = null, Expression<Func<double>> rFARequestNumericValue = null, Expression<Func<string>> rFARequestTitle = null, Expression<Func<string[]>> rFARequestRecipientUsers = null, Expression<Func<string[]>> rFARequestRecipientGroups = null, Expression<Func<string>> rFARequestRecipienteMail = null, Expression<Func<string>> rFARequestRecipientPhone = null, Expression<Func<string>> rFARequestRequestedOnUTC = null, Expression<Func<string>> rFARequestExpiresOnUTC = null, Expression<Func<string>> rFARequestTriggeredOn = null)
        {
            var apiCallPath = "/api/collaboration/CreateRFARequest/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rFARequest = new JObject();
            var rFARequestpropCount = 0;
            rFARequestpropCount++;
            rFARequest["id"] = ExpressionConverter.ConvertO(rFARequestid);
            rFARequestpropCount++;
            rFARequest["Code"] = ExpressionConverter.ConvertO(rFARequestCode);
            rFARequestpropCount++;
            rFARequest["RequestedBy"] = ExpressionConverter.ConvertO(rFARequestRequestedBy);
            if (rFARequestPriority != null)
            {
                rFARequest["Priority"] = ExpressionConverter.ConvertO(rFARequestPriority);
                rFARequestpropCount++;
            }

            rFARequestpropCount++;
            rFARequest["IsExternal"] = ExpressionConverter.ConvertO(rFARequestIsExternal);
            if (rFARequestRequestClass != null)
            {
                rFARequest["RequestClass"] = ExpressionConverter.ConvertO(rFARequestRequestClass);
                rFARequestpropCount++;
            }

            if (rFARequestRequestCategory != null)
            {
                rFARequest["RequestCategory"] = ExpressionConverter.ConvertO(rFARequestRequestCategory);
                rFARequestpropCount++;
            }

            if (rFARequestNumericValue != null)
            {
                rFARequest["NumericValue"] = ExpressionConverter.ConvertO(rFARequestNumericValue);
                rFARequestpropCount++;
            }

            if (rFARequestTitle != null)
            {
                rFARequest["Title"] = ExpressionConverter.ConvertO(rFARequestTitle);
                rFARequestpropCount++;
            }

            if (rFARequestRecipientUsers != null)
            {
                rFARequest["RecipientUsers"] = ExpressionConverter.ConvertO(rFARequestRecipientUsers);
                rFARequestpropCount++;
            }

            if (rFARequestRecipientGroups != null)
            {
                rFARequest["RecipientGroups"] = ExpressionConverter.ConvertO(rFARequestRecipientGroups);
                rFARequestpropCount++;
            }

            if (rFARequestRecipienteMail != null)
            {
                rFARequest["RecipienteMail"] = ExpressionConverter.ConvertO(rFARequestRecipienteMail);
                rFARequestpropCount++;
            }

            if (rFARequestRecipientPhone != null)
            {
                rFARequest["RecipientPhone"] = ExpressionConverter.ConvertO(rFARequestRecipientPhone);
                rFARequestpropCount++;
            }

            if (rFARequestRequestedOnUTC != null)
            {
                rFARequest["RequestedOnUTC"] = ExpressionConverter.ConvertO(rFARequestRequestedOnUTC);
                rFARequestpropCount++;
            }

            if (rFARequestExpiresOnUTC != null)
            {
                rFARequest["ExpiresOnUTC"] = ExpressionConverter.ConvertO(rFARequestExpiresOnUTC);
                rFARequestpropCount++;
            }

            if (rFARequestTriggeredOn != null)
            {
                rFARequest["TriggeredOn"] = ExpressionConverter.ConvertO(rFARequestTriggeredOn);
                rFARequestpropCount++;
            }

            if (rFARequestpropCount > 0)
            {
                callPayload.Body = rFARequest;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESCollaborationRespondToRFARequest(Expression<Func<string>> rFAResponseid, Expression<Func<string>> rFAResponseCode, Expression<Func<string>> rFAResponseResponseBy, Expression<Func<string>> rFAResponseResponseOrigin, Expression<Func<string>> rFAResponseResponseOnUTC, Expression<Func<string>> rFAResponseResponseComments = null)
        {
            var apiCallPath = "/api/collaboration/RespondToRFARequest/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var rFAResponse = new JObject();
            var rFAResponsepropCount = 0;
            rFAResponsepropCount++;
            rFAResponse["id"] = ExpressionConverter.ConvertO(rFAResponseid);
            rFAResponsepropCount++;
            rFAResponse["Code"] = ExpressionConverter.ConvertO(rFAResponseCode);
            if (rFAResponseResponseComments != null)
            {
                rFAResponse["ResponseComments"] = ExpressionConverter.ConvertO(rFAResponseResponseComments);
                rFAResponsepropCount++;
            }

            rFAResponsepropCount++;
            rFAResponse["ResponseBy"] = ExpressionConverter.ConvertO(rFAResponseResponseBy);
            rFAResponsepropCount++;
            rFAResponse["ResponseOrigin"] = ExpressionConverter.ConvertO(rFAResponseResponseOrigin);
            rFAResponsepropCount++;
            rFAResponse["ResponseOnUTC"] = ExpressionConverter.ConvertO(rFAResponseResponseOnUTC);
            if (rFAResponsepropCount > 0)
            {
                callPayload.Body = rFAResponse;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESRFARequest> ESCollaborationFetchRequest(Expression<Func<string>> requestID)
        {
            var apiCallPath = "/api/collaboration/FetchRequest/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["RequestID"] = ExpressionConverter.Convert(requestID);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESRFARequest>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string> ESRPCPingServer(Expression<Func<string>> routeid)
        {
            var apiCallPath = String.Format("/api/rpc/PingServer/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESTestEBSConnectionTest(Expression<Func<string>> routeid)
        {
            var apiCallPath = String.Format("/esapi/estest/EBSConnectionTest/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESEntityDeleteEntityByID(Expression<Func<string>> entityID, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/DeleteEntityByID/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityID"] = ExpressionConverter.Convert(entityID);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESEntityDeleteEntityByType(Expression<Func<entityTypeInput>> entityType, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/DeleteEntityByType/";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESEntityUpdateEntityByID(Expression<Func<string>> entityID, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/UpdateEntityByID/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityID"] = ExpressionConverter.Convert(entityID);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            var updProperties = new JObject();
            var updPropertiespropCount = 0;
            if (updPropertiespropCount > 0)
            {
                callPayload.Body = updProperties;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction ESEntityUpdateEntityByType(Expression<Func<entityTypeInput>> entityType, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/UpdateEntityByType/";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            var updProperties = new JObject();
            var updPropertiespropCount = 0;
            if (updPropertiespropCount > 0)
            {
                callPayload.Body = updProperties;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiApiControllersESCreatedEntityInfo> ESEntityCreateEntityByID(Expression<Func<string>> entityID)
        {
            var apiCallPath = "/api/esentity/CreateEntityByID/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityID"] = ExpressionConverter.Convert(entityID);
            var updProperties = new JObject();
            var updPropertiespropCount = 0;
            if (updPropertiespropCount > 0)
            {
                callPayload.Body = updProperties;
            }

            return new ApiConnectionAction<EntersoftWebApiApiControllersESCreatedEntityInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiApiControllersESCreatedEntityInfo> ESEntityCreateEntityByType(Expression<Func<entityTypeInput>> entityType)
        {
            var apiCallPath = "/api/esentity/CreateEntityByType/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            var updProperties = new JObject();
            var updPropertiespropCount = 0;
            if (updPropertiespropCount > 0)
            {
                callPayload.Body = updProperties;
            }

            return new ApiConnectionAction<EntersoftWebApiApiControllersESCreatedEntityInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESBaseEntity> ESEntityEntityByID(Expression<Func<string>> entityID, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/EntityByID/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityID"] = ExpressionConverter.Convert(entityID);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESBaseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESBaseEntity> ESEntityEntityByType(Expression<Func<entityTypeInput>> entityType, Expression<Func<string>> pK)
        {
            var apiCallPath = "/api/esentity/EntityByType/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            callPayload.Queries["PK"] = ExpressionConverter.Convert(pK);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESBaseEntity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPQResult> ESEntityEntitiesByID(Expression<Func<string>> entityID, Expression<Func<string[]>> fetchOptionsSelectFields = null, Expression<Func<string[]>> fetchOptionsOrderByFields = null, Expression<Func<int>> fetchOptionsPage = null, Expression<Func<int>> fetchOptionsPageSize = null)
        {
            var apiCallPath = "/api/esentity/EntitiesByID/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityID"] = ExpressionConverter.Convert(entityID);
            var fetchOptions = new JObject();
            var fetchOptionspropCount = 0;
            if (fetchOptionsSelectFields != null)
            {
                fetchOptions["SelectFields"] = ExpressionConverter.ConvertO(fetchOptionsSelectFields);
                fetchOptionspropCount++;
            }

            if (fetchOptionsOrderByFields != null)
            {
                fetchOptions["OrderByFields"] = ExpressionConverter.ConvertO(fetchOptionsOrderByFields);
                fetchOptionspropCount++;
            }

            var ParamsObject = new JObject();
            var ParamsObjectpropCount = 0;
            if (ParamsObjectpropCount > 0)
            {
                fetchOptions["Params"] = ParamsObject;
                fetchOptionspropCount++;
            }

            if (fetchOptionsPage != null)
            {
                fetchOptions["Page"] = ExpressionConverter.ConvertO(fetchOptionsPage);
                fetchOptionspropCount++;
            }

            if (fetchOptionsPageSize != null)
            {
                fetchOptions["PageSize"] = ExpressionConverter.ConvertO(fetchOptionsPageSize);
                fetchOptionspropCount++;
            }

            if (fetchOptionspropCount > 0)
            {
                callPayload.Body = fetchOptions;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESPQResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPQResult> ESEntityEntitiesByType(Expression<Func<entityTypeInput>> entityType, Expression<Func<string[]>> fetchOptionsSelectFields = null, Expression<Func<string[]>> fetchOptionsOrderByFields = null, Expression<Func<int>> fetchOptionsPage = null, Expression<Func<int>> fetchOptionsPageSize = null)
        {
            var apiCallPath = "/api/esentity/EntitiesByType/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EntityType"] = ExpressionConverter.Convert(entityType);
            var fetchOptions = new JObject();
            var fetchOptionspropCount = 0;
            if (fetchOptionsSelectFields != null)
            {
                fetchOptions["SelectFields"] = ExpressionConverter.ConvertO(fetchOptionsSelectFields);
                fetchOptionspropCount++;
            }

            if (fetchOptionsOrderByFields != null)
            {
                fetchOptions["OrderByFields"] = ExpressionConverter.ConvertO(fetchOptionsOrderByFields);
                fetchOptionspropCount++;
            }

            var ParamsObject = new JObject();
            var ParamsObjectpropCount = 0;
            if (ParamsObjectpropCount > 0)
            {
                fetchOptions["Params"] = ParamsObject;
                fetchOptionspropCount++;
            }

            if (fetchOptionsPage != null)
            {
                fetchOptions["Page"] = ExpressionConverter.ConvertO(fetchOptionsPage);
                fetchOptionspropCount++;
            }

            if (fetchOptionsPageSize != null)
            {
                fetchOptions["PageSize"] = ExpressionConverter.ConvertO(fetchOptionsPageSize);
                fetchOptionspropCount++;
            }

            if (fetchOptionspropCount > 0)
            {
                callPayload.Body = fetchOptions;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESPQResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESEntityEntityAutomationNew(Expression<Func<string>> entity, Expression<Func<string>> operation)
        {
            var apiCallPath = "/api/esentity/EntityAutomationNew/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Queries["operation"] = ExpressionConverter.Convert(operation);
            var commandParams = new JObject();
            var commandParamspropCount = 0;
            if (commandParamspropCount > 0)
            {
                callPayload.Body = commandParams;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESEntityEntityAutomationUpdate(Expression<Func<string>> entity, Expression<Func<string>> field, Expression<Func<string>> id, Expression<Func<string>> operation)
        {
            var apiCallPath = "/api/esentity/EntityAutomationUpdate/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Queries["field"] = ExpressionConverter.Convert(field);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["operation"] = ExpressionConverter.Convert(operation);
            var commandParams = new JObject();
            var commandParamspropCount = 0;
            if (commandParamspropCount > 0)
            {
                callPayload.Body = commandParams;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESEntityEntityAutomationUpdateByCode(Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> operation)
        {
            var apiCallPath = "/api/esentity/EntityAutomationUpdateByCode/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["operation"] = ExpressionConverter.Convert(operation);
            var commandParams = new JObject();
            var commandParamspropCount = 0;
            if (commandParamspropCount > 0)
            {
                callPayload.Body = commandParams;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIDocumentTradeObj> ESFinancialsESFIDocumentTrade(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIDocumentTrade/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIDocumentTradeObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIItemExpensesObj> ESFinancialsESFIItemExpenses(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIItemExpenses/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIItemExpensesObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFICreditorObj> ESFinancialsESFICreditor(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFICreditor/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFICreditorObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIDocumentCashObj> ESFinancialsESFIDocumentCash(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIDocumentCash/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIDocumentCashObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMStockOrderPlanObj> ESFinancialsESMMStockOrderPlan(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESMMStockOrderPlan/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMStockOrderPlanObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFISupplierObj> ESFinancialsESFISupplier(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFISupplier/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFISupplierObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIItemExpenseObj> ESFinancialsESFIItemExpense(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIItemExpense/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIItemExpenseObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFISalesPersonObj> ESFinancialsESFISalesPerson(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFISalesPerson/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFISalesPersonObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIPaymentMethodObj> ESFinancialsESFIPaymentMethod(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIPaymentMethod/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIPaymentMethodObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIItemObj> ESFinancialsESFIItem(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIItem/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIItemObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFISpecialAccountObj> ESFinancialsESFISpecialAccount(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFISpecialAccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFISpecialAccountObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIDocumentStockObj> ESFinancialsESFIDocumentStock(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIDocumentStock/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIDocumentStockObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFINoteObj> ESFinancialsESFINote(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFINote/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFINoteObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFITradeAccountContractObj> ESFinancialsESFITradeAccountContract(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFITradeAccountContract/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFITradeAccountContractObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIVoucherObj> ESFinancialsESFIVoucher(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIVoucher/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIVoucherObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFICustomerObj> ESFinancialsESFICustomer(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFICustomer/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFICustomerObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIDebtorObj> ESFinancialsESFIDebtor(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIDebtor/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIDebtorObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIPricelistObj> ESFinancialsESFIPricelist(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIPricelist/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIPricelistObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIItemServiceObj> ESFinancialsESFIItemService(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIItemService/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIItemServiceObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFICashAccountObj> ESFinancialsESFICashAccount(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFICashAccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFICashAccountObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObj> ESFinancialsESFIDocumentAdjustment(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFIDocumentAdjustment/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFITradeAccountObj> ESFinancialsESFITradeAccount(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFinancials/ESFITradeAccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFITradeAccountObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESFAFixedAssetObj> ESFixedAssetESFAFixedAsset(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESFixedAsset/ESFAFixedAsset/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESFAFixedAssetObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESGOPersonObj> ESGlobalObjectsESGOPerson(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESGlobalObjects/ESGOPerson/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESGOPersonObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsES00DeviceObj> ESGlobalObjectsES00Device(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESGlobalObjects/ES00Device/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsES00DeviceObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESGOWebUserObj> ESGlobalObjectsESGOWebUser(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESGlobalObjects/ESGOWebUser/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESGOWebUserObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESGOUserObj> ESGlobalObjectsESGOUser(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESGlobalObjects/ESGOUser/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESGOUserObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse> ESBusinessHookGet(Expression<Func<string>> hookID)
        {
            var apiCallPath = String.Format("/api/businesshook/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESPodHookRegistrationResponse> ESPodHookGet(Expression<Func<string>> hookID)
        {
            var apiCallPath = String.Format("/api/podhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESPodHookRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESRFAHookRegistrationResponse> ESRFAHookGet(Expression<Func<string>> hookID)
        {
            var apiCallPath = String.Format("/api/rfahook/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESRFAHookRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse> ESHookGet(Expression<Func<string>> hookID)
        {
            var apiCallPath = String.Format("/api/hook/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse> ESSystemHookGet(Expression<Func<string>> hookID)
        {
            var apiCallPath = String.Format("/api/systemhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(hookID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMLModelObj> ESMachineLearningESMLModel(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMachineLearning/ESMLModel/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMLModelObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMSerialNumberObj> ESMaterialManagementESMMSerialNumber(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMSerialNumber/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMSerialNumberObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMCatalogueItemObj> ESMaterialManagementESMMCatalogueItem(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMCatalogueItem/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMCatalogueItemObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMStorageLocationObj> ESMaterialManagementESMMStorageLocation(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMStorageLocation/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMStorageLocationObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMStockItemObj> ESMaterialManagementESMMStockItem(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMStockItem/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMStockItemObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMCommercialProfileObj> ESMaterialManagementESMMCommercialProfile(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMCommercialProfile/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMCommercialProfileObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMSortimentObj> ESMaterialManagementESMMSortiment(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMSortiment/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMSortimentObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMLotObj> ESMaterialManagementESMMLot(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMLot/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMLotObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESMMProductionPlanObj> ESMaterialManagementESMMProductionPlan(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESMaterialManagement/ESMMProductionPlan/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESMMProductionPlanObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESDeviceFetchDeviceInfo(Expression<Func<string>> deviceCode)
        {
            var apiCallPath = String.Format("/api/device/fetchDeviceInfo/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceCode, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPropertySet> ESRPCFetchPropertySet(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/fetchPropertySet/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsESPropertySet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScale> ESRPCFetchESScale(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/fetchESScale/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsESScale>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPQLayout> ESRPCPublicQueryLayout(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/PublicQueryLayout/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsESPQLayout>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPQResult> ESRPCGetPQData(Expression<Func<string>> routeId, Expression<Func<int>> pqOptionsPage = null, Expression<Func<int>> pqOptionsPageSize = null, Expression<Func<bool>> pqOptionsWithCount = null)
        {
            var apiCallPath = String.Format("/api/rpc/GetPQData/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pqOptionsPage != null)
                callPayload.Queries["pqOptions.page"] = ExpressionConverter.Convert(pqOptionsPage);
            if (pqOptionsPageSize != null)
                callPayload.Queries["pqOptions.pageSize"] = ExpressionConverter.Convert(pqOptionsPageSize);
            if (pqOptionsWithCount != null)
                callPayload.Queries["pqOptions.withCount"] = ExpressionConverter.Convert(pqOptionsWithCount);
            return new ApiConnectionAction<EntersoftWebApiModelsESPQResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string> ESRPCFIImportDocument(Expression<Func<string>> inputXMLAsString = null)
        {
            var apiCallPath = "/api/rpc/FIImportDocument/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(inputXMLAsString);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPQResult> ESRPCGetPQData2(Expression<Func<string>> routeId, Expression<Func<int>> pqOptionsPage = null, Expression<Func<int>> pqOptionsPageSize = null, Expression<Func<bool>> pqOptionsWithCount = null)
        {
            var apiCallPath = String.Format("/api/rpc/GetPQData2/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (pqOptionsPage != null)
                callPayload.Queries["pqOptions.page"] = ExpressionConverter.Convert(pqOptionsPage);
            if (pqOptionsPageSize != null)
                callPayload.Queries["pqOptions.pageSize"] = ExpressionConverter.Convert(pqOptionsPageSize);
            if (pqOptionsWithCount != null)
                callPayload.Queries["pqOptions.withCount"] = ExpressionConverter.Convert(pqOptionsWithCount);
            var @params = new JObject();
            var @paramspropCount = 0;
            if (@paramspropCount > 0)
            {
                callPayload.Body = @params;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESPQResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<bool> ESRPCLog(Expression<Func<string>> iD, Expression<Func<string>> description = null, Expression<Func<severityInput>> severity = null)
        {
            var apiCallPath = "/api/rpc/Log/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ID"] = ExpressionConverter.Convert(iD);
            if (description != null)
                callPayload.Queries["Description"] = ExpressionConverter.Convert(description);
            if (severity != null)
                callPayload.Queries["Severity"] = ExpressionConverter.Convert(severity);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsCompanyParamEx> ESRPCFetchCompanyParam(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/FetchCompanyParam/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsCompanyParamEx>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> ESRPCParameterValue(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/ParameterValue/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsCompanyParamEx[]> ESRPCFetchCompanyParams(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/FetchCompanyParams/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApiModelsCompanyParamEx[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScrollerCommandOut> ESRPCExecuteScrollerCommand(Expression<Func<string>> eSScrollerCommandScrollerID, Expression<Func<string>> eSScrollerCommandCommandID, Expression<Func<string>> eSScrollerCommandScrollerDatasetJson = null, Expression<Func<bool>> eSScrollerCommandRequiresTransaction = null, Expression<Func<bool>> eSScrollerCommandOnlyPrepareTargetDatasets = null, Expression<Func<bool>> eSScrollerCommandReturnTargetDatasets = null, Expression<Func<bool>> eSScrollerCommandReturnScrollerDataset = null, Expression<Func<bool>> eSScrollerCommandReturnEntersoftDatasets = null)
        {
            var apiCallPath = "/api/rpc/ExecuteScrollerCommand/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eSScrollerCommand = new JObject();
            var eSScrollerCommandpropCount = 0;
            var ScrollerParamsObject = new JObject();
            var ScrollerParamsObjectpropCount = 0;
            if (ScrollerParamsObjectpropCount > 0)
            {
                eSScrollerCommand["ScrollerParams"] = ScrollerParamsObject;
                eSScrollerCommandpropCount++;
            }

            var ScrollerDatasetObject = new JObject();
            var ScrollerDatasetObjectpropCount = 0;
            if (ScrollerDatasetObjectpropCount > 0)
            {
                eSScrollerCommand["ScrollerDataset"] = ScrollerDatasetObject;
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandScrollerDatasetJson != null)
            {
                eSScrollerCommand["ScrollerDatasetJson"] = ExpressionConverter.ConvertO(eSScrollerCommandScrollerDatasetJson);
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandRequiresTransaction != null)
            {
                eSScrollerCommand["RequiresTransaction"] = ExpressionConverter.ConvertO(eSScrollerCommandRequiresTransaction);
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandOnlyPrepareTargetDatasets != null)
            {
                eSScrollerCommand["OnlyPrepareTargetDatasets"] = ExpressionConverter.ConvertO(eSScrollerCommandOnlyPrepareTargetDatasets);
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandReturnTargetDatasets != null)
            {
                eSScrollerCommand["ReturnTargetDatasets"] = ExpressionConverter.ConvertO(eSScrollerCommandReturnTargetDatasets);
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandReturnScrollerDataset != null)
            {
                eSScrollerCommand["ReturnScrollerDataset"] = ExpressionConverter.ConvertO(eSScrollerCommandReturnScrollerDataset);
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandReturnEntersoftDatasets != null)
            {
                eSScrollerCommand["ReturnEntersoftDatasets"] = ExpressionConverter.ConvertO(eSScrollerCommandReturnEntersoftDatasets);
                eSScrollerCommandpropCount++;
            }

            eSScrollerCommandpropCount++;
            eSScrollerCommand["ScrollerID"] = ExpressionConverter.ConvertO(eSScrollerCommandScrollerID);
            eSScrollerCommandpropCount++;
            eSScrollerCommand["CommandID"] = ExpressionConverter.ConvertO(eSScrollerCommandCommandID);
            var CommandParamsObject = new JObject();
            var CommandParamsObjectpropCount = 0;
            if (CommandParamsObjectpropCount > 0)
            {
                eSScrollerCommand["CommandParams"] = CommandParamsObject;
                eSScrollerCommandpropCount++;
            }

            var UnboundVariablesObject = new JObject();
            var UnboundVariablesObjectpropCount = 0;
            if (UnboundVariablesObjectpropCount > 0)
            {
                eSScrollerCommand["UnboundVariables"] = UnboundVariablesObject;
                eSScrollerCommandpropCount++;
            }

            if (eSScrollerCommandpropCount > 0)
            {
                callPayload.Body = eSScrollerCommand;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESScrollerCommandOut>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScrollerCommandOut> ESRPCExecuteCommand(Expression<Func<string>> eSCommandInScrollerID, Expression<Func<string>> eSCommandInCommandID)
        {
            var apiCallPath = "/api/rpc/ExecuteCommand/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eSCommandIn = new JObject();
            var eSCommandInpropCount = 0;
            eSCommandInpropCount++;
            eSCommandIn["ScrollerID"] = ExpressionConverter.ConvertO(eSCommandInScrollerID);
            eSCommandInpropCount++;
            eSCommandIn["CommandID"] = ExpressionConverter.ConvertO(eSCommandInCommandID);
            var CommandParamsObject = new JObject();
            var CommandParamsObjectpropCount = 0;
            if (CommandParamsObjectpropCount > 0)
            {
                eSCommandIn["CommandParams"] = CommandParamsObject;
                eSCommandInpropCount++;
            }

            var UnboundVariablesObject = new JObject();
            var UnboundVariablesObjectpropCount = 0;
            if (UnboundVariablesObjectpropCount > 0)
            {
                eSCommandIn["UnboundVariables"] = UnboundVariablesObject;
                eSCommandInpropCount++;
            }

            if (eSCommandInpropCount > 0)
            {
                callPayload.Body = eSCommandIn;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESScrollerCommandOut>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESFormCommandOut> ESRPCExecuteFormCommand(Expression<Func<string>> formCommandEntityID = null, Expression<Func<string>> formCommandCommandID = null, Expression<Func<string>> formCommandEntityDatasetJson = null, Expression<Func<string>> formCommandEntityGID = null, Expression<Func<string[]>> formCommandEntityGIDs = null, Expression<Func<string>> formCommandEntityCode = null, Expression<Func<string[]>> formCommandEntityCodes = null, Expression<Func<string>> formCommandEntityScrollerID = null, Expression<Func<bool>> formCommandRequiresTransaction = null, Expression<Func<bool>> formCommandCreateNewEmptySourceEntity = null, Expression<Func<bool>> formCommandOnlyPrepareTargetDatasets = null, Expression<Func<bool>> formCommandReturnSourceDatasets = null, Expression<Func<bool>> formCommandReturnTargetDatasets = null, Expression<Func<bool>> formCommandReturnMap = null, Expression<Func<bool>> formCommandReturnEntersoftDatasets = null)
        {
            var apiCallPath = "/api/rpc/ExecuteFormCommand/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var formCommand = new JObject();
            var formCommandpropCount = 0;
            if (formCommandEntityID != null)
            {
                formCommand["EntityID"] = ExpressionConverter.ConvertO(formCommandEntityID);
                formCommandpropCount++;
            }

            if (formCommandCommandID != null)
            {
                formCommand["CommandID"] = ExpressionConverter.ConvertO(formCommandCommandID);
                formCommandpropCount++;
            }

            var EntityDatasetObject = new JObject();
            var EntityDatasetObjectpropCount = 0;
            if (EntityDatasetObjectpropCount > 0)
            {
                formCommand["EntityDataset"] = EntityDatasetObject;
                formCommandpropCount++;
            }

            if (formCommandEntityDatasetJson != null)
            {
                formCommand["EntityDatasetJson"] = ExpressionConverter.ConvertO(formCommandEntityDatasetJson);
                formCommandpropCount++;
            }

            if (formCommandEntityGID != null)
            {
                formCommand["EntityGID"] = ExpressionConverter.ConvertO(formCommandEntityGID);
                formCommandpropCount++;
            }

            if (formCommandEntityGIDs != null)
            {
                formCommand["EntityGIDs"] = ExpressionConverter.ConvertO(formCommandEntityGIDs);
                formCommandpropCount++;
            }

            if (formCommandEntityCode != null)
            {
                formCommand["EntityCode"] = ExpressionConverter.ConvertO(formCommandEntityCode);
                formCommandpropCount++;
            }

            if (formCommandEntityCodes != null)
            {
                formCommand["EntityCodes"] = ExpressionConverter.ConvertO(formCommandEntityCodes);
                formCommandpropCount++;
            }

            var EntityParamsObject = new JObject();
            var EntityParamsObjectpropCount = 0;
            if (EntityParamsObjectpropCount > 0)
            {
                formCommand["EntityParams"] = EntityParamsObject;
                formCommandpropCount++;
            }

            if (formCommandEntityScrollerID != null)
            {
                formCommand["EntityScrollerID"] = ExpressionConverter.ConvertO(formCommandEntityScrollerID);
                formCommandpropCount++;
            }

            var EntityScrollerParamsObject = new JObject();
            var EntityScrollerParamsObjectpropCount = 0;
            if (EntityScrollerParamsObjectpropCount > 0)
            {
                formCommand["EntityScrollerParams"] = EntityScrollerParamsObject;
                formCommandpropCount++;
            }

            if (formCommandRequiresTransaction != null)
            {
                formCommand["RequiresTransaction"] = ExpressionConverter.ConvertO(formCommandRequiresTransaction);
                formCommandpropCount++;
            }

            var CommandParamsObject = new JObject();
            var CommandParamsObjectpropCount = 0;
            if (CommandParamsObjectpropCount > 0)
            {
                formCommand["CommandParams"] = CommandParamsObject;
                formCommandpropCount++;
            }

            var UnboundVariablesObject = new JObject();
            var UnboundVariablesObjectpropCount = 0;
            if (UnboundVariablesObjectpropCount > 0)
            {
                formCommand["UnboundVariables"] = UnboundVariablesObject;
                formCommandpropCount++;
            }

            if (formCommandCreateNewEmptySourceEntity != null)
            {
                formCommand["CreateNewEmptySourceEntity"] = ExpressionConverter.ConvertO(formCommandCreateNewEmptySourceEntity);
                formCommandpropCount++;
            }

            if (formCommandOnlyPrepareTargetDatasets != null)
            {
                formCommand["OnlyPrepareTargetDatasets"] = ExpressionConverter.ConvertO(formCommandOnlyPrepareTargetDatasets);
                formCommandpropCount++;
            }

            if (formCommandReturnSourceDatasets != null)
            {
                formCommand["ReturnSourceDatasets"] = ExpressionConverter.ConvertO(formCommandReturnSourceDatasets);
                formCommandpropCount++;
            }

            if (formCommandReturnTargetDatasets != null)
            {
                formCommand["ReturnTargetDatasets"] = ExpressionConverter.ConvertO(formCommandReturnTargetDatasets);
                formCommandpropCount++;
            }

            if (formCommandReturnMap != null)
            {
                formCommand["ReturnMap"] = ExpressionConverter.ConvertO(formCommandReturnMap);
                formCommandpropCount++;
            }

            if (formCommandReturnEntersoftDatasets != null)
            {
                formCommand["ReturnEntersoftDatasets"] = ExpressionConverter.ConvertO(formCommandReturnEntersoftDatasets);
                formCommandpropCount++;
            }

            if (formCommandpropCount > 0)
            {
                callPayload.Body = formCommand;
            }

            return new ApiConnectionAction<EntersoftWebApiModelsESFormCommandOut>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> GETESRPCEbsService2(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/EbsService2/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken> POSTESRPCEbsService2(Expression<Func<string>> routeId)
        {
            var apiCallPath = String.Format("/api/rpc/EbsService2/{0}", ExpressionConverter.ConvertWithUrlEncoding(routeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMMobileTaskTypeObj> ESTaskManagementESTMMobileTaskType(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMMobileTaskType/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMMobileTaskTypeObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMServiceRequestObj> ESTaskManagementESTMServiceRequest(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMServiceRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMServiceRequestObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMRFMModelObj> ESTaskManagementESTMRFMModel(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMRFMModel/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMRFMModelObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMNewsletterRecipientObj> ESTaskManagementESTMNewsletterRecipient(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMNewsletterRecipient/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMNewsletterRecipientObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMInteractionObj> ESTaskManagementESTMInteraction(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMInteraction/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMInteractionObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMObjectRatingObj> ESTaskManagementESTMObjectRating(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMObjectRating/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMObjectRatingObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMTaskObj> ESTaskManagementESTMTask(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMTask/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMTaskObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMResourceObj> ESTaskManagementESTMResource(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMResource/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMResourceObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMCampaignObj> ESTaskManagementESTMCampaign(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMCampaign/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMCampaignObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMSMActivityObj> ESTaskManagementESTMSMActivity(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMSMActivity/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMSMActivityObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESTMOpportunityObj> ESTaskManagementESTMOpportunity(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESTaskManagement/ESTMOpportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESTMOpportunityObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMTransportActionObj> ESWarehouseManagementESWMTransportAction(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMTransportAction/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMTransportActionObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMActionObj> ESWarehouseManagementESWMAction(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMAction/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMActionObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMShipmentObj> ESWarehouseManagementESWMShipment(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMShipment/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMShipmentObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMWorkPackageObj> ESWarehouseManagementESWMWorkPackage(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMWorkPackage/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMWorkPackageObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMRequestObj> ESWarehouseManagementESWMRequest(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMRequestObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWMContainerObj> ESWarehouseManagementESWMContainer(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWarehouseManagement/ESWMContainer/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWMContainerObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWPTaskRequestObj> ESWorkInProgressESWPTaskRequest(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWorkInProgress/ESWPTaskRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWPTaskRequestObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWPWorkPackageObj> ESWorkInProgressESWPWorkPackage(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWorkInProgress/ESWPWorkPackage/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWPWorkPackageObj>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2ODSModelsESWPActualTaskObj> ESWorkInProgressESWPActualTask(Expression<Func<string>> pK)
        {
            var apiCallPath = String.Format("/api/ESWorkInProgress/ESWPActualTask/{0}", ExpressionConverter.ConvertWithUrlEncoding(pK, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EntersoftWebApi2ODSModelsESWPActualTaskObj>(callPayload);
        }
    }

    public class EntersoftTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse> ESBusinessHookPost(Expression<Func<registrationBusinessEventTypeInput>> registrationBusinessEventType, Expression<Func<string>> registrationContext = null, Expression<Func<double>> registrationValue = null, Expression<Func<string>> registrationExternalID = null, Expression<Func<string>> registrationDescription = null, Expression<Func<bool>> registrationIsActive = null)
        {
            var apiCallPath = "/api/businesshook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var registration = new JObject();
            var registrationpropCount = 0;
            registrationpropCount++;
            registration["BusinessEventType"] = ExpressionConverter.ConvertO(registrationBusinessEventType);
            if (registrationContext != null)
            {
                registration["Context"] = ExpressionConverter.ConvertO(registrationContext);
                registrationpropCount++;
            }

            if (registrationValue != null)
            {
                registration["Value"] = ExpressionConverter.ConvertO(registrationValue);
                registrationpropCount++;
            }

            if (registrationExternalID != null)
            {
                registration["ExternalID"] = ExpressionConverter.ConvertO(registrationExternalID);
                registrationpropCount++;
            }

            if (registrationDescription != null)
            {
                registration["Description"] = ExpressionConverter.ConvertO(registrationDescription);
                registrationpropCount++;
            }

            if (registrationIsActive != null)
            {
                registration["IsActive"] = ExpressionConverter.ConvertO(registrationIsActive);
                registrationpropCount++;
            }

            registration["CallbackURL"] = "@listcallbackurl()";
            registrationpropCount++;
            if (registrationpropCount > 0)
            {
                callPayload.Body = registration;
            }

            return new ApiConnectionTrigger<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<EntersoftWebApiInfrastructureESPodHookRegistrationResponse> ESPodHookPost(Expression<Func<registrationStateInput>> registrationState = null, Expression<Func<registrationPackageTypeInput>> registrationPackageType = null, Expression<Func<string>> registrationConveyanceLicencePlate = null, Expression<Func<string>> registrationBranchID = null, Expression<Func<string>> registrationTradeAccountName = null, Expression<Func<string>> registrationDriverCode = null, Expression<Func<string>> registrationExternalID = null, Expression<Func<string>> registrationDescription = null, Expression<Func<bool>> registrationIsActive = null)
        {
            var apiCallPath = "/api/podhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var registration = new JObject();
            var registrationpropCount = 0;
            if (registrationState != null)
            {
                registration["State"] = ExpressionConverter.ConvertO(registrationState);
                registrationpropCount++;
            }

            if (registrationPackageType != null)
            {
                registration["PackageType"] = ExpressionConverter.ConvertO(registrationPackageType);
                registrationpropCount++;
            }

            if (registrationConveyanceLicencePlate != null)
            {
                registration["ConveyanceLicencePlate"] = ExpressionConverter.ConvertO(registrationConveyanceLicencePlate);
                registrationpropCount++;
            }

            if (registrationBranchID != null)
            {
                registration["BranchID"] = ExpressionConverter.ConvertO(registrationBranchID);
                registrationpropCount++;
            }

            if (registrationTradeAccountName != null)
            {
                registration["TradeAccountName"] = ExpressionConverter.ConvertO(registrationTradeAccountName);
                registrationpropCount++;
            }

            if (registrationDriverCode != null)
            {
                registration["DriverCode"] = ExpressionConverter.ConvertO(registrationDriverCode);
                registrationpropCount++;
            }

            if (registrationExternalID != null)
            {
                registration["ExternalID"] = ExpressionConverter.ConvertO(registrationExternalID);
                registrationpropCount++;
            }

            if (registrationDescription != null)
            {
                registration["Description"] = ExpressionConverter.ConvertO(registrationDescription);
                registrationpropCount++;
            }

            if (registrationIsActive != null)
            {
                registration["IsActive"] = ExpressionConverter.ConvertO(registrationIsActive);
                registrationpropCount++;
            }

            registration["CallbackURL"] = "@listcallbackurl()";
            registrationpropCount++;
            if (registrationpropCount > 0)
            {
                callPayload.Body = registration;
            }

            return new ApiConnectionTrigger<EntersoftWebApiInfrastructureESPodHookRegistrationResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<EntersoftWebApiInfrastructureESRFAHookRegistrationResponse> ESRFAHookPost(Expression<Func<string>> registrationRequestedBy = null, Expression<Func<registrationPriorityInput>> registrationPriority = null, Expression<Func<string>> registrationRequestClass = null, Expression<Func<string>> registrationRequestCategory = null, Expression<Func<double>> registrationNumericValue = null, Expression<Func<string>> registrationExternalID = null, Expression<Func<string>> registrationDescription = null, Expression<Func<bool>> registrationIsActive = null)
        {
            var apiCallPath = "/api/rfahook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var registration = new JObject();
            var registrationpropCount = 0;
            if (registrationRequestedBy != null)
            {
                registration["RequestedBy"] = ExpressionConverter.ConvertO(registrationRequestedBy);
                registrationpropCount++;
            }

            if (registrationPriority != null)
            {
                registration["Priority"] = ExpressionConverter.ConvertO(registrationPriority);
                registrationpropCount++;
            }

            if (registrationRequestClass != null)
            {
                registration["RequestClass"] = ExpressionConverter.ConvertO(registrationRequestClass);
                registrationpropCount++;
            }

            if (registrationRequestCategory != null)
            {
                registration["RequestCategory"] = ExpressionConverter.ConvertO(registrationRequestCategory);
                registrationpropCount++;
            }

            if (registrationNumericValue != null)
            {
                registration["NumericValue"] = ExpressionConverter.ConvertO(registrationNumericValue);
                registrationpropCount++;
            }

            if (registrationExternalID != null)
            {
                registration["ExternalID"] = ExpressionConverter.ConvertO(registrationExternalID);
                registrationpropCount++;
            }

            if (registrationDescription != null)
            {
                registration["Description"] = ExpressionConverter.ConvertO(registrationDescription);
                registrationpropCount++;
            }

            if (registrationIsActive != null)
            {
                registration["IsActive"] = ExpressionConverter.ConvertO(registrationIsActive);
                registrationpropCount++;
            }

            registration["CallbackURL"] = "@listcallbackurl()";
            registrationpropCount++;
            if (registrationpropCount > 0)
            {
                callPayload.Body = registration;
            }

            return new ApiConnectionTrigger<EntersoftWebApiInfrastructureESRFAHookRegistrationResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse> ESHookPost(Expression<Func<registrationEntityTypeInput>> registrationEntityType, Expression<Func<registrationEventTypeInput>> registrationEventType, Expression<Func<string>> registrationExternalID = null, Expression<Func<string>> registrationDescription = null, Expression<Func<bool>> registrationIsActive = null)
        {
            var apiCallPath = "/api/hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var registration = new JObject();
            var registrationpropCount = 0;
            registrationpropCount++;
            registration["EntityType"] = ExpressionConverter.ConvertO(registrationEntityType);
            registrationpropCount++;
            registration["EventType"] = ExpressionConverter.ConvertO(registrationEventType);
            if (registrationExternalID != null)
            {
                registration["ExternalID"] = ExpressionConverter.ConvertO(registrationExternalID);
                registrationpropCount++;
            }

            if (registrationDescription != null)
            {
                registration["Description"] = ExpressionConverter.ConvertO(registrationDescription);
                registrationpropCount++;
            }

            if (registrationIsActive != null)
            {
                registration["IsActive"] = ExpressionConverter.ConvertO(registrationIsActive);
                registrationpropCount++;
            }

            registration["CallbackURL"] = "@listcallbackurl()";
            registrationpropCount++;
            if (registrationpropCount > 0)
            {
                callPayload.Body = registration;
            }

            return new ApiConnectionTrigger<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse> ESSystemHookPost(Expression<Func<registrationSystemEventTypeInputItem[]>> registrationSystemEventType, Expression<Func<string>> registrationOtherEvent = null, Expression<Func<string>> registrationExternalID = null, Expression<Func<string>> registrationDescription = null, Expression<Func<bool>> registrationIsActive = null)
        {
            var apiCallPath = "/api/systemhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var registration = new JObject();
            var registrationpropCount = 0;
            registrationpropCount++;
            registration["SystemEventType"] = ExpressionConverter.ConvertO(registrationSystemEventType);
            if (registrationOtherEvent != null)
            {
                registration["OtherEvent"] = ExpressionConverter.ConvertO(registrationOtherEvent);
                registrationpropCount++;
            }

            if (registrationExternalID != null)
            {
                registration["ExternalID"] = ExpressionConverter.ConvertO(registrationExternalID);
                registrationpropCount++;
            }

            if (registrationDescription != null)
            {
                registration["Description"] = ExpressionConverter.ConvertO(registrationDescription);
                registrationpropCount++;
            }

            if (registrationIsActive != null)
            {
                registration["IsActive"] = ExpressionConverter.ConvertO(registrationIsActive);
                registrationpropCount++;
            }

            registration["CallbackURL"] = "@listcallbackurl()";
            registrationpropCount++;
            if (registrationpropCount > 0)
            {
                callPayload.Body = registration;
            }

            return new ApiConnectionTrigger<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse>(callPayload);
        }
    }

    public class EntersoftWebApiModelsES00DocumentInfo
    {
        public string GID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string EDate { get; set; }
        public string FType { get; set; }
        public string TableID { get; set; }
        public string TableName { get; set; }

        [JsonProperty("fGID")]
        public string FGID { get; set; }

        [JsonProperty("fDetailLineGID")]
        public string FDetailLineGID { get; set; }
        public string UNCPath { get; set; }
        public string OriginalPath { get; set; }
        public string OriginalFN { get; set; }

        [JsonProperty("fDocCategoryCode")]
        public string FDocCategoryCode { get; set; }

        [JsonProperty("fDocGroupCode")]
        public string FDocGroupCode { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("fDocumentCategoryCode")]
        public string FDocumentCategoryCode { get; set; }

        [JsonProperty("fDocumentLocationCode")]
        public string FDocumentLocationCode { get; set; }
        public string ESDModified { get; set; }
        public string ESUModified { get; set; }
        public string ESDCreated { get; set; }
        public string ESUCreated { get; set; }
        public bool IsBLOB { get; set; }
        public bool Ingoing { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }
        public int BLOBDATALength { get; set; }
        public string BLOBDATA { get; set; }
    }

    public class EntersoftWebApiModelsES00BlobInfo
    {
        public string GID { get; set; }
        public string ObjectID { get; set; }
        public string KeyID { get; set; }
        public int TypeID { get; set; }
        public string Ext { get; set; }
        public string TextBody { get; set; }
        public bool IsNew { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESBGBudgetSheetObj
    {
        [JsonProperty("fScenarioCode")]
        public string FScenarioCode { get; set; }

        [JsonProperty("fFiscalYearGID")]
        public string FFiscalYearGID { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fBudgetSheetProfileGID")]
        public string FBudgetSheetProfileGID { get; set; }
        public string RegistrationDate { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fActivityCode")]
        public string FActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBudgetCategoryCode")]
        public string FBudgetCategoryCode { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public EntersoftWebApi2ODSModelsESBGBudgetSheetObjStateType State { get; set; }
        public EntersoftWebApi2ODSModelsESBGBudgetSheetObjLayoutTypeType LayoutType { get; set; }
        public double DeclinePercentFrom { get; set; }
        public double DeclinePercentTo { get; set; }
        public int RevisionNumber { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESBGBudgetSheetObjProductionStatusType ProductionStatus { get; set; }
        public int Version { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }
        public string PostingDateLimitv { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESBGBudgetSheetObjStateType
    {
        Initial,
        Frozen,
        Approved,
        Final,
        Fixed
    }

    public enum EntersoftWebApi2ODSModelsESBGBudgetSheetObjLayoutTypeType
    {
        PerDC,
        TotDC,
        PerDD,
        TotDD
    }

    public enum EntersoftWebApi2ODSModelsESBGBudgetSheetObjProductionStatusType
    {
        Indifferent,
        Valid,
        Investigate
    }

    public class EntersoftWebApiControllersESViberResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public JToken[] Message { get; set; }
    }

    public enum rFARequestPriorityInput
    {
        Low,
        Normal,
        High
    }

    public class EntersoftWebApiInfrastructureESRFARequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Code { get; set; }
        public string RequestedBy { get; set; }
        public EntersoftWebApiInfrastructureESRFARequestPriorityType Priority { get; set; }
        public bool IsExternal { get; set; }
        public string RequestClass { get; set; }
        public string RequestCategory { get; set; }
        public double NumericValue { get; set; }
        public string Title { get; set; }
        public string[] RecipientUsers { get; set; }
        public string[] RecipientGroups { get; set; }
        public string RecipienteMail { get; set; }
        public string RecipientPhone { get; set; }
        public string RequestedOnUTC { get; set; }
        public string ExpiresOnUTC { get; set; }
        public string TriggeredOn { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESRFARequestPriorityType
    {
        Low,
        Normal,
        High
    }

    public enum entityTypeInput
    {
        ES00Device,
        ES00List,
        ES00MobileParams,
        ES00PropertySet,
        ES00PropertySetCompact,
        ES00RuleSet,
        ES00RuleSetType,
        ES00SegmentationModel,
        ES00SegmentationTemplate,
        ES00SemanticsCustomization,
        ES00SSASParameters,
        ES00WordGroup,
        ES00ZProperty,
        ESBGAllocationProfile,
        ESBGBudgetDimensionAllocationProfile,
        ESBGBudgetSheet,
        ESBGBudgetSheetProfile,
        ESBGZBudgetCashAccountGroup,
        ESBGZBudgetItemGroup,
        ESBGZBudgetSalespersonGroup,
        ESBGZBudgetTradeAccountGroup,
        ESCOCostElementType,
        ESCOCostingFolder,
        ESCOLineCostAnalysis,
        ESFACommercialProfile,
        ESFADepreciationProfile,
        ESFAFixedAsset,
        ESFAItemControlPolicy,
        ESFARevaluationProfile,
        ESFIBankImport,
        ESFICardRateProfile,
        ESFICashAccount,
        ESFICDCommercialProfile,
        ESFICheckListProfile,
        ESFICommercialProfileItem,
        ESFICommissionProfile,
        ESFICondition,
        ESFIConditionTemplate,
        ESFICreditCardType,
        ESFICreditControlProfile,
        ESFICreditor,
        ESFICreditTurnOverProfile,
        ESFICreditTurnOverProfileEntry,
        ESFICustomer,
        ESFIDebtor,
        ESFIDeclarationEntry,
        ESFIDeclarationType,
        ESFIDistributionDispatch,
        ESFIDocSeriesAttributes,
        ESFIDocumentAccessRightProfile,
        ESFIDocumentAdjustment,
        ESFIDocumentCash,
        ESFIDocumentSeries,
        ESFIDocumentStock,
        ESFIDocumentTrade,
        ESFIDocumentTransition,
        ESFIDocumentUpdateProfile,
        ESFIDocumentUpdateProfileGL,
        ESFIEInvoiceProfile,
        ESFIFieldPropertiesProfile,
        ESFIFillerProfile,
        ESFIFinancialAgreement,
        ESFIFinancialDeclaration,
        ESFIInnerDistributionEntry,
        ESFIIntrastatEntry,
        ESFIInvoicePolicy,
        ESFIInvoicePolicyAction,
        ESFIItem,
        ESFIItemAllocationProfile,
        ESFIItemCategories,
        ESFIItemControlPolicy,
        ESFIItemExpense,
        ESFIItemExpenses,
        ESFIItemFamily,
        ESFIItemPriceHistoryTemplate,
        ESFIItemService,
        ESFIItemSubCategory,
        ESFIItemSubfamily,
        ESFIKEPYOEntry,
        ESFIMeasure,
        ESFIMobileDocumentType,
        ESFIMyDataInvoice,
        ESFINote,
        ESFIOIMatchingProfile,
        ESFIOpenItemsForDateProposalHeader,
        ESFIPaymentMethod,
        ESFIPricelist,
        ESFIPricelistEditor,
        ESFISalesPerson,
        ESFISpecialAccount,
        ESFISpecialAccountGroup,
        ESFISupplier,
        ESFISupplierExpert,
        ESFITCourier,
        ESFITradeAccount,
        ESFITradeAccountContract,
        ESFITradeAccountContractType,
        ESFITransitionProfile,
        ESFITransportPlan,
        ESFIVoucher,
        ESFIVoucherPromotionProfile,
        ESFIWHAccessList,
        ESFIZAccountPostingDef,
        ESFIZElectronicTransactionsProfile,
        ESFIZInterestProfile,
        ESFIZItemCategory,
        ESFIZItemFamily,
        ESFIZItemSubCategory,
        ESFIZItemSubFamily,
        ESFIZVATExemptionReasoning,
        ESGLAccount,
        ESGLAccountingDocumentTemplate,
        ESGLAccountingDocumentType,
        ESGLAllocationProfile,
        ESGLJournal,
        ESGLLedgerEntry,
        ESGlobalBlueDocument,
        ESGOAreaMap,
        ESGOColumnsSeq,
        ESGOCompany,
        ESGOCompanyBusinessActivityCodes,
        ESGOCurrency,
        ESGOCurrencyExchangeRate,
        ESGOLegalPerson,
        ESGOMetric,
        ESGOMetricActual,
        ESGOMetricSet,
        ESGOOrganizationalUnit,
        ESGOPerson,
        ESGOPhysicalPerson,
        ESGOPrinter,
        ESGOProject,
        ESGOReport,
        ESGOScale,
        ESGOScheduledJob,
        ESGOScript,
        ESGOSeasonCalendar,
        ESGOSegmentSequence,
        ESGOServiceProfile,
        ESGOShift,
        ESGOUser,
        ESGOVATCategoryMapping,
        ESGOWebUser,
        ESGOWorkingCalendar,
        ESGOWorkingCalendarException,
        ESGOWorkstation,
        ESGOZBusinessActivity,
        ESGOZBusinessUnit,
        ESGOZDimension1,
        ESGOZDimension2,
        ESGOZInteractionProfile,
        ESMLModel,
        ESMLModelGroup,
        ESMMBOM,
        ESMMCatalogueItem,
        ESMMCommercialProfile,
        ESMMDeposition,
        ESMMItemControlPolicy,
        ESMMItemSellingPrice,
        ESMMLot,
        ESMMMaterialRequirement,
        ESMMMaterialRequirementPlan,
        ESMMMaterialRequirementPlanWithReqs,
        ESMMPersonItem,
        ESMMPhaseRouting,
        ESMMProductionLeadTimes,
        ESMMProductionPlan,
        ESMMProductionPlanDemand,
        ESMMProductionPlanItem,
        ESMMProductionPlanWithDemands,
        ESMMSerialNumber,
        ESMMSIMURelation,
        ESMMSortiment,
        ESMMStockDimSet,
        ESMMStockDimSetMap,
        ESMMStockItem,
        ESMMStockOrderModel,
        ESMMStockOrderPlan,
        ESMMStockProposalComposition,
        ESMMStockProposalGroup,
        ESMMStorageLocation,
        ESMMStorageLocationPrinter,
        ESMMStorageLocationProfile,
        ESMMStorageLocationTree,
        ESMMValidStockDimensionsProfile,
        ESMMZBCProcessingType,
        ESMMZIntrastatCode,
        ESMMZMeasurementUnit,
        ESPlanetDocument,
        ESTMABCClassificationModel,
        ESTMCampaign,
        ESTMContractTerm,
        ESTMInteraction,
        ESTMMobileTaskType,
        ESTMNewsletterRecipient,
        ESTMObjectRating,
        ESTMOpportunity,
        ESTMResource,
        ESTMRFMModel,
        ESTMRFMResponseModel,
        ESTMServiceDefinition,
        ESTMServiceRequest,
        ESTMSMAccount,
        ESTMSMActivity,
        ESTMSMCompanyAccount,
        ESTMSMRawObject,
        ESTMStatusCollection,
        ESTMTask,
        ESTMTaskCategory,
        ESTMTaskLite,
        ESTMTaskType,
        ESTRPosition,
        ESTRTerritory,
        ESTRTerritoryBudget,
        ESTRTerritoryBudgetTemplate,
        ESTRTerritoryHierarchy,
        ESTRTerritoryRulePeriod,
        ESWMAction,
        ESWMActionType,
        ESWMActionTypeReport,
        ESWMCancellationDispositionReasonMap,
        ESWMCancellationReservationReasonMap,
        ESWMContainer,
        ESWMContainerControlPolicy,
        ESWMContainerType,
        ESWMDepositor,
        ESWMItemControlPolicy,
        ESWMPhaseZoneMapping,
        ESWMRequest,
        ESWMRequestStringFieldMap,
        ESWMRequestType,
        ESWMReservationReasonWHMap,
        ESWMShipment,
        ESWMStepOperation,
        ESWMTransportAction,
        ESWMTransportRequest,
        ESWMWorkPackage,
        ESWMWorkPackageType,
        ESWPActualTask,
        ESWPActualTaskEntry,
        ESWPTaskRequest,
        ESWPWorkPackage
    }

    public class EntersoftWebApiApiControllersESCreatedEntityInfo
    {
        public string PK { get; set; }
        public string Code { get; set; }
        public string EntityID { get; set; }
        public EntersoftWebApiApiControllersESCreatedEntityInfoEntityTypeType EntityType { get; set; }
    }

    public enum EntersoftWebApiApiControllersESCreatedEntityInfoEntityTypeType
    {
        ES00Device,
        ES00List,
        ES00MobileParams,
        ES00PropertySet,
        ES00PropertySetCompact,
        ES00RuleSet,
        ES00RuleSetType,
        ES00SegmentationModel,
        ES00SegmentationTemplate,
        ES00SemanticsCustomization,
        ES00SSASParameters,
        ES00WordGroup,
        ES00ZProperty,
        ESBGAllocationProfile,
        ESBGBudgetDimensionAllocationProfile,
        ESBGBudgetSheet,
        ESBGBudgetSheetProfile,
        ESBGZBudgetCashAccountGroup,
        ESBGZBudgetItemGroup,
        ESBGZBudgetSalespersonGroup,
        ESBGZBudgetTradeAccountGroup,
        ESCOCostElementType,
        ESCOCostingFolder,
        ESCOLineCostAnalysis,
        ESFACommercialProfile,
        ESFADepreciationProfile,
        ESFAFixedAsset,
        ESFAItemControlPolicy,
        ESFARevaluationProfile,
        ESFIBankImport,
        ESFICardRateProfile,
        ESFICashAccount,
        ESFICDCommercialProfile,
        ESFICheckListProfile,
        ESFICommercialProfileItem,
        ESFICommissionProfile,
        ESFICondition,
        ESFIConditionTemplate,
        ESFICreditCardType,
        ESFICreditControlProfile,
        ESFICreditor,
        ESFICreditTurnOverProfile,
        ESFICreditTurnOverProfileEntry,
        ESFICustomer,
        ESFIDebtor,
        ESFIDeclarationEntry,
        ESFIDeclarationType,
        ESFIDistributionDispatch,
        ESFIDocSeriesAttributes,
        ESFIDocumentAccessRightProfile,
        ESFIDocumentAdjustment,
        ESFIDocumentCash,
        ESFIDocumentSeries,
        ESFIDocumentStock,
        ESFIDocumentTrade,
        ESFIDocumentTransition,
        ESFIDocumentUpdateProfile,
        ESFIDocumentUpdateProfileGL,
        ESFIEInvoiceProfile,
        ESFIFieldPropertiesProfile,
        ESFIFillerProfile,
        ESFIFinancialAgreement,
        ESFIFinancialDeclaration,
        ESFIInnerDistributionEntry,
        ESFIIntrastatEntry,
        ESFIInvoicePolicy,
        ESFIInvoicePolicyAction,
        ESFIItem,
        ESFIItemAllocationProfile,
        ESFIItemCategories,
        ESFIItemControlPolicy,
        ESFIItemExpense,
        ESFIItemExpenses,
        ESFIItemFamily,
        ESFIItemPriceHistoryTemplate,
        ESFIItemService,
        ESFIItemSubCategory,
        ESFIItemSubfamily,
        ESFIKEPYOEntry,
        ESFIMeasure,
        ESFIMobileDocumentType,
        ESFIMyDataInvoice,
        ESFINote,
        ESFIOIMatchingProfile,
        ESFIOpenItemsForDateProposalHeader,
        ESFIPaymentMethod,
        ESFIPricelist,
        ESFIPricelistEditor,
        ESFISalesPerson,
        ESFISpecialAccount,
        ESFISpecialAccountGroup,
        ESFISupplier,
        ESFISupplierExpert,
        ESFITCourier,
        ESFITradeAccount,
        ESFITradeAccountContract,
        ESFITradeAccountContractType,
        ESFITransitionProfile,
        ESFITransportPlan,
        ESFIVoucher,
        ESFIVoucherPromotionProfile,
        ESFIWHAccessList,
        ESFIZAccountPostingDef,
        ESFIZElectronicTransactionsProfile,
        ESFIZInterestProfile,
        ESFIZItemCategory,
        ESFIZItemFamily,
        ESFIZItemSubCategory,
        ESFIZItemSubFamily,
        ESFIZVATExemptionReasoning,
        ESGLAccount,
        ESGLAccountingDocumentTemplate,
        ESGLAccountingDocumentType,
        ESGLAllocationProfile,
        ESGLJournal,
        ESGLLedgerEntry,
        ESGlobalBlueDocument,
        ESGOAreaMap,
        ESGOColumnsSeq,
        ESGOCompany,
        ESGOCompanyBusinessActivityCodes,
        ESGOCurrency,
        ESGOCurrencyExchangeRate,
        ESGOLegalPerson,
        ESGOMetric,
        ESGOMetricActual,
        ESGOMetricSet,
        ESGOOrganizationalUnit,
        ESGOPerson,
        ESGOPhysicalPerson,
        ESGOPrinter,
        ESGOProject,
        ESGOReport,
        ESGOScale,
        ESGOScheduledJob,
        ESGOScript,
        ESGOSeasonCalendar,
        ESGOSegmentSequence,
        ESGOServiceProfile,
        ESGOShift,
        ESGOUser,
        ESGOVATCategoryMapping,
        ESGOWebUser,
        ESGOWorkingCalendar,
        ESGOWorkingCalendarException,
        ESGOWorkstation,
        ESGOZBusinessActivity,
        ESGOZBusinessUnit,
        ESGOZDimension1,
        ESGOZDimension2,
        ESGOZInteractionProfile,
        ESMLModel,
        ESMLModelGroup,
        ESMMBOM,
        ESMMCatalogueItem,
        ESMMCommercialProfile,
        ESMMDeposition,
        ESMMItemControlPolicy,
        ESMMItemSellingPrice,
        ESMMLot,
        ESMMMaterialRequirement,
        ESMMMaterialRequirementPlan,
        ESMMMaterialRequirementPlanWithReqs,
        ESMMPersonItem,
        ESMMPhaseRouting,
        ESMMProductionLeadTimes,
        ESMMProductionPlan,
        ESMMProductionPlanDemand,
        ESMMProductionPlanItem,
        ESMMProductionPlanWithDemands,
        ESMMSerialNumber,
        ESMMSIMURelation,
        ESMMSortiment,
        ESMMStockDimSet,
        ESMMStockDimSetMap,
        ESMMStockItem,
        ESMMStockOrderModel,
        ESMMStockOrderPlan,
        ESMMStockProposalComposition,
        ESMMStockProposalGroup,
        ESMMStorageLocation,
        ESMMStorageLocationPrinter,
        ESMMStorageLocationProfile,
        ESMMStorageLocationTree,
        ESMMValidStockDimensionsProfile,
        ESMMZBCProcessingType,
        ESMMZIntrastatCode,
        ESMMZMeasurementUnit,
        ESPlanetDocument,
        ESTMABCClassificationModel,
        ESTMCampaign,
        ESTMContractTerm,
        ESTMInteraction,
        ESTMMobileTaskType,
        ESTMNewsletterRecipient,
        ESTMObjectRating,
        ESTMOpportunity,
        ESTMResource,
        ESTMRFMModel,
        ESTMRFMResponseModel,
        ESTMServiceDefinition,
        ESTMServiceRequest,
        ESTMSMAccount,
        ESTMSMActivity,
        ESTMSMCompanyAccount,
        ESTMSMRawObject,
        ESTMStatusCollection,
        ESTMTask,
        ESTMTaskCategory,
        ESTMTaskLite,
        ESTMTaskType,
        ESTRPosition,
        ESTRTerritory,
        ESTRTerritoryBudget,
        ESTRTerritoryBudgetTemplate,
        ESTRTerritoryHierarchy,
        ESTRTerritoryRulePeriod,
        ESWMAction,
        ESWMActionType,
        ESWMActionTypeReport,
        ESWMCancellationDispositionReasonMap,
        ESWMCancellationReservationReasonMap,
        ESWMContainer,
        ESWMContainerControlPolicy,
        ESWMContainerType,
        ESWMDepositor,
        ESWMItemControlPolicy,
        ESWMPhaseZoneMapping,
        ESWMRequest,
        ESWMRequestStringFieldMap,
        ESWMRequestType,
        ESWMReservationReasonWHMap,
        ESWMShipment,
        ESWMStepOperation,
        ESWMTransportAction,
        ESWMTransportRequest,
        ESWMWorkPackage,
        ESWMWorkPackageType,
        ESWPActualTask,
        ESWPActualTaskEntry,
        ESWPTaskRequest,
        ESWPWorkPackage
    }

    public class EntersoftWebApi2ODSModelsESBaseEntity
    {
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApiModelsESPQResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public string Table { get; set; }
        public JToken[] Rows { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESFIDocumentTradeObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FADDocumentUpdateProfileGID { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FADDocumentTypeGID { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FADDocumentSeriesGID { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjTradeAccountTypeType TradeAccountType { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjTradeAccountNatureType TradeAccountNature { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADDocumentStateType ADDocumentState { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }
        public double Discount { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjVATStatusType VATStatus { get; set; }
        public string DeliveryDueDate { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGID { get; set; }

        [JsonProperty("fCompanyWHGID")]
        public string FCompanyWHGID { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fShippingPurposeCode")]
        public string FShippingPurposeCode { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fDeliveryTermsCode")]
        public string FDeliveryTermsCode { get; set; }

        [JsonProperty("fTradeNatureCode")]
        public string FTradeNatureCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADOriginType ADOrigin { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FADCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double NetValue { get; set; }
        public double ADTotalValue { get; set; }
        public double ChargesValue { get; set; }
        public double TaxesValue { get; set; }
        public double DeductionsValue { get; set; }
        public double DiscountValue { get; set; }
        public double VATValue { get; set; }
        public double PayableAmount { get; set; }
        public double CurrencyNetValue { get; set; }
        public double CurrencyTotalValue { get; set; }
        public double CurrencyChargesValue { get; set; }
        public double CurrencyTaxesValue { get; set; }
        public double CurrencyDeductionsValue { get; set; }
        public double CurrencyDiscountValue { get; set; }
        public double CurrencyVATValue { get; set; }
        public double CurrencyPayableAmount { get; set; }
        public double CostValue { get; set; }
        public double CommissionValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGID { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FADTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FADTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FADTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FADTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FADTableField5Code { get; set; }
        public string ADDateField1 { get; set; }
        public string ADDateField2 { get; set; }
        public string ADDateField3 { get; set; }
        public string ADDateField4 { get; set; }
        public string ADDateField5 { get; set; }
        public string ADStringField1 { get; set; }
        public string ADStringField2 { get; set; }
        public string ADStringField3 { get; set; }
        public string ADStringField4 { get; set; }
        public string ADStringField5 { get; set; }

        [JsonProperty("fADProjectGID")]
        public string FADProjectGID { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FADActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FADBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FADDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FADDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FADSiteGID { get; set; }
        public double PaymentAmount { get; set; }
        public double CurrencyPaymentAmount { get; set; }
        public int TransitionBatchID { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public bool HopFromTemporaryFails { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FADNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FSNStateCode { get; set; }
        public double TradeAccountPreviousBalance { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public double CommissionValue2 { get; set; }

        [JsonProperty("fSNPostStateCode")]
        public string FSNPostStateCode { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGID { get; set; }
        public string ConcerningDocCode { get; set; }
        public bool ADTransitionAvailability { get; set; }
        public int ConcerningDocClass { get; set; }
        public string ConcerningBeginDate { get; set; }
        public string ConcerningEndDate { get; set; }
        public int StockValuationBatchID { get; set; }
        public bool Allocated { get; set; }
        public double CustomsRate { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FADAccountManagerGID { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }
        public bool SortimentHandling { get; set; }

        [JsonProperty("fSenderPersonGID")]
        public string FSenderPersonGID { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGID { get; set; }
        public double TradeAccountPreviousBonusBalance { get; set; }
        public double TotalBonusValue { get; set; }
        public double CurrencyTotalBonusValue { get; set; }
        public bool KEPYOUpdate { get; set; }

        [JsonProperty("fOrderPersonGID")]
        public string FOrderPersonGID { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FADTaskGID { get; set; }
        public double SponsionNetValue { get; set; }
        public double CurrencySponsionNetValue { get; set; }
        public double SponsionTotalValue { get; set; }
        public double CurrencySponsionTotalValue { get; set; }
        public double SponsionTotalQtyBaseMU { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FADDocumentUpdateProfileGLGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGID { get; set; }
        public string ADReportingDate { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjCalculatedCashFlowTypeType CalculatedCashFlowType { get; set; }

        [JsonProperty("fBudgetSheetGID")]
        public string FBudgetSheetGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public double TransportCost { get; set; }
        public double CurrencyTransportCost { get; set; }

        [JsonProperty("fTradeTypeCode")]
        public string FTradeTypeCode { get; set; }
        public int NumValeurDays { get; set; }
        public bool PaymentVATRequired { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FWFStepCode { get; set; }
        public bool MandatoryBankMediation { get; set; }

        [JsonProperty("fProductProposalTaskGID")]
        public string FProductProposalTaskGID { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGID { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGID { get; set; }
        public bool ZeroTransportCost { get; set; }

        [JsonProperty("fTransportPlanGID")]
        public string FTransportPlanGID { get; set; }
        public string CouponCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentTradeObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGID { get; set; }
        public bool PurchaseVATDeductible { get; set; }
        public string ReasonForVATExemption { get; set; }
        public bool TaxFree { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }
        public bool SplitOnVATRequired { get; set; }
        public string CommercialDate { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FADShiftGID { get; set; }
        public string FiscalCode { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FADMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }
        public int ApplyCommercialPolicy { get; set; }
        public int BOMExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("VATAnalysis_Netvalue1")]
        public double VATAnalysisNetvalue1 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent1")]
        public double VATAnalysisVATPercent1 { get; set; }

        [JsonProperty("VATAnalysis_VATValue1")]
        public double VATAnalysisVATValue1 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue1")]
        public double VATAnalysisTotalValue1 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue2")]
        public double VATAnalysisNetvalue2 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent2")]
        public double VATAnalysisVATPercent2 { get; set; }

        [JsonProperty("VATAnalysis_VATValue2")]
        public double VATAnalysisVATValue2 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue2")]
        public double VATAnalysisTotalValue2 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue3")]
        public double VATAnalysisNetvalue3 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent3")]
        public double VATAnalysisVATPercent3 { get; set; }

        [JsonProperty("VATAnalysis_VATValue3")]
        public double VATAnalysisVATValue3 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue3")]
        public double VATAnalysisTotalValue3 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue4")]
        public double VATAnalysisNetvalue4 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent4")]
        public double VATAnalysisVATPercent4 { get; set; }

        [JsonProperty("VATAnalysis_VATValue4")]
        public double VATAnalysisVATValue4 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue4")]
        public double VATAnalysisTotalValue4 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue5")]
        public double VATAnalysisNetvalue5 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent5")]
        public double VATAnalysisVATPercent5 { get; set; }

        [JsonProperty("VATAnalysis_VATValue5")]
        public double VATAnalysisVATValue5 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue5")]
        public double VATAnalysisTotalValue5 { get; set; }

        [JsonProperty("EInvoice_RelatedDocs")]
        public string EInvoiceRelatedDocs { get; set; }

        [JsonProperty("EInvoice_BusinessActivity")]
        public string EInvoiceBusinessActivity { get; set; }

        [JsonProperty("EInvoice_BIC_Code")]
        public string EInvoiceBICCode { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TDSLEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TDSLEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TDSLEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TDSLEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TDSLEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TDSLEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TDSLEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TDSLEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TDSLEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TDSLEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TDSLEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TDSLEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TDSLEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TDSLEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TDSLEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TDSLEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TDSLEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TDSLEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TDSLEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TDSLEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TDSLEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TDSLEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TDSLEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TDSLEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TDSLEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TDSLEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TDSLEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CANCELAFTERSAVEFCancellingSeriesGID { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CANCELAFTERSAVEADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CANCELAFTERSAVEReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CANCELAFTERSAVEADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CANCELAFTERSAVEADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CANCELAFTERSAVEESUCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public double CustomsReversedRate { get; set; }
        public int CreditControl { get; set; }
        public int CalculateTransportCost { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NSTCourierTrackingID { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NSTCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NSTCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NSTCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NSTCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NSTCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NSTCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NSTCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NSTCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NSTCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NSTCourierJobID { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NSFDeliveryPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NSFDeliveryPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NSFDeliverySiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NSFSenderPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NSFSenderPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NSFSenderSiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }
        public int AllowPaymentMethodApply { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int NumValeurDaysPrev { get; set; }
        public string DeliveryDueDatePrev { get; set; }
        public double TotalQtyBaseMU { get; set; }
        public double TotalQtyVariable1 { get; set; }
        public int UndoTaxationVATStatus { get; set; }
        public int ADSiteKindWH { get; set; }
        public int WareHouseProposed { get; set; }
        public int CompactLineItemsOnSave { get; set; }
        public int AddLIAFromDomainOnRetailMode { get; set; }
        public int VATCalcOnTotals { get; set; }
        public double CurrencyBaseValue { get; set; }
        public double CurrencyVATValueNotPayed { get; set; }
        public double CurrencyPayableMinusPaymentAmount { get; set; }
        public double CurrencyPayableAmountNotPayed { get; set; }
        public double CurrencyNetPayableAmountNotPayed { get; set; }
        public double CurrencyTotalRest { get; set; }
        public double CurrencyValueUnderTaxes { get; set; }

        [JsonProperty("SAL_CurrencyDiscountVatValue")]
        public double SALCurrencyDiscountVatValue { get; set; }
        public double CurrencyPaymentTermAmount { get; set; }
        public double CurrencyCashPaymentTermAmount { get; set; }
        public double CurrencyCardPaymentTermAmount { get; set; }
        public double CurrencyAdvancePaymentTermAmount { get; set; }
        public double CurrencyAmountInHandTermAmount { get; set; }
        public double CurrencyCashAmountInHandTermAmount { get; set; }
        public double CurrencyCardAmountInHandTermAmount { get; set; }
        public double CurrencyAdvanceAmountInHandTermAmount { get; set; }
        public double CurrencyGiftCardValue { get; set; }
        public double CurrencyPayableAmountBalance { get; set; }
        public double CurrencyTotalPayableAmount { get; set; }
        public double BaseValue { get; set; }
        public double CashPaymentAmount { get; set; }
        public double GiftCardPaymentAmount { get; set; }
        public double CardPaymentAmount { get; set; }
        public double NotePaymentAmount { get; set; }
        public double PayableMinusPaymentAmount { get; set; }
        public double VATValueNotPayed { get; set; }
        public double PayableAmountNotPayed { get; set; }
        public double NetPayableAmountNotPayed { get; set; }
        public double TotalRest { get; set; }
        public double ValueUnderTaxes { get; set; }

        [JsonProperty("SAL_VatValue")]
        public double SALVatValue { get; set; }

        [JsonProperty("SAL_DiscountVatValue")]
        public double SALDiscountVatValue { get; set; }
        public double PaymentTermAmount { get; set; }
        public double CashPaymentTermAmount { get; set; }
        public double CardPaymentTermAmount { get; set; }
        public double AdvancePaymentTermAmount { get; set; }
        public double AmountInHandTermAmount { get; set; }
        public double CashAmountInHandTermAmount { get; set; }
        public double CardAmountInHandTermAmount { get; set; }
        public double AdvanceAmountInHandTermAmount { get; set; }
        public double GiftCardValue { get; set; }
        public double PayableAmountBalance { get; set; }
        public double TotalPayableAmount { get; set; }
        public double CoveredAmount { get; set; }
        public double CurrencyCoveredAmount { get; set; }
        public double UncoveredPayableAmountBalance { get; set; }
        public double CurrencyUncoveredPayableAmountBalance { get; set; }
        public double TotalGiftVoucherValue { get; set; }
        public double CurrencyTotalGiftVoucherValue { get; set; }
        public double IssueGiftVoucherValue { get; set; }
        public double CurrencyIssueGiftVoucherValue { get; set; }
        public double RedeemGiftVoucherValue { get; set; }
        public double CurrencyRedeemGiftVoucherValue { get; set; }
        public double TotalDiscountVoucherValue { get; set; }
        public double CurrencyTotalDiscountVoucherValue { get; set; }
        public double IssueDiscountVoucherValue { get; set; }
        public double CurrencyIssueDiscountVoucherValue { get; set; }
        public double RedeemDiscountVoucherValue { get; set; }
        public double CurrencyRedeemDiscountVoucherValue { get; set; }
        public double IssueGiftVoucherPayableValue { get; set; }
        public double CurrencyIssueGiftVoucherPayableValue { get; set; }
        public double RedeemGiftVoucherPaymentValue { get; set; }
        public double CurrencyRedeemGiftVoucherPaymentValue { get; set; }
        public double CurrencyAdditionalDiscountValue { get; set; }
        public double CurrencyAdditionalDiscount { get; set; }
        public int ForceRelatedItemGeneration { get; set; }
        public double CurrencyCashPaymentAmount { get; set; }
        public double CurrencyGiftCardPaymentAmount { get; set; }
        public double CurrencyCardPaymentAmount { get; set; }
        public double CurrencyNotePaymentAmount { get; set; }
        public double CurrencyCashPaymentAmountFTM { get; set; }
        public double CurrencyGiftCardPaymentAmountFTM { get; set; }
        public double CurrencyCardPaymentAmountFTM { get; set; }
        public double CurrencyNotePaymentAmountFTM { get; set; }
        public double CurrencyTotalRestFTM { get; set; }

        [JsonProperty("SAL_CurrencyVatValue")]
        public double SALCurrencyVatValue { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public int CurrencyExchangePriceType { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("Ref_SALList_DocTyp_TAcc")]
        public string RefSALListDocTypTAcc { get; set; }

        [JsonProperty("vTotalQuantity")]
        public string VTotalQuantity { get; set; }

        [JsonProperty("vTotalQuantityBaseMU")]
        public string VTotalQuantityBaseMU { get; set; }

        [JsonProperty("vTotalAlternativeQuantity")]
        public string VTotalAlternativeQuantity { get; set; }

        [JsonProperty("vTotalVolume")]
        public string VTotalVolume { get; set; }

        [JsonProperty("vTotalWeight")]
        public string VTotalWeight { get; set; }

        [JsonProperty("bTotalNetValue")]
        public double BTotalNetValue { get; set; }

        [JsonProperty("bTotalCurrencyNetValue")]
        public double BTotalCurrencyNetValue { get; set; }

        [JsonProperty("bTotalDiscountValue")]
        public double BTotalDiscountValue { get; set; }

        [JsonProperty("bTotalCurrencyDiscountValue")]
        public double BTotalCurrencyDiscountValue { get; set; }

        [JsonProperty("bTotalValueBeforeDiscounts")]
        public double BTotalValueBeforeDiscounts { get; set; }

        [JsonProperty("bTotalCurrencyValueBeforeDiscounts")]
        public double BTotalCurrencyValueBeforeDiscounts { get; set; }

        [JsonProperty("bTotalVATValue")]
        public double BTotalVATValue { get; set; }

        [JsonProperty("bTotalCurrencyVATValue")]
        public double BTotalCurrencyVATValue { get; set; }

        [JsonProperty("bTotalTotalValue")]
        public double BTotalTotalValue { get; set; }

        [JsonProperty("bTotalCurrencyTotalValue")]
        public double BTotalCurrencyTotalValue { get; set; }
        public double TradeAccountNewBalance { get; set; }
        public double TradeAccountCurrentBalance { get; set; }
        public double TradeAccountCurrentBalanceBySite { get; set; }
        public double TradeAccountCurrentSiteBalance { get; set; }
        public int EntrySign { get; set; }
        public double LinesTradeDiscounts { get; set; }
        public int HasLinesVATExempt { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string ADReferenceCodeList { get; set; }
        public int InvokeInvoicePolicy { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_Description")]
        public string EInvoiceAdditionalInterchangeableExpense1Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense1NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense1VATStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense1VATValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense1TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_Description")]
        public string EInvoiceAdditionalInterchangeableExpense2Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense2NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense2VATStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense2VATValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense2TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_Description")]
        public string EInvoiceAdditionalInterchangeableExpense3Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense3NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense3VATStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense3VATValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense3TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallNetValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallNetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallVATValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallVATValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallTotalValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallTotalValue { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjTradeAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjTradeAccountNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjCalculatedCashFlowTypeType
    {
        No,
        Inflows,
        Outflows,
        UndoInflows,
        UndoOutflows
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentTradeObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2ODSModelsESFIItemExpensesObj
    {
        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGID { get; set; }
        public bool WEB { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpensesObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMUGID { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NSIsSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjSubTypeType
    {
        Service,
        Expense
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjExpenseTypeType
    {
        VariousExpenses,
        Paycheck,
        ThirdPartyFees,
        Electricity,
        Telecommunications,
        Rents,
        Watering,
        Insurance,
        Transportation,
        Travel,
        Markerting,
        Subscriptions,
        Stationery,
        Taxes,
        Interest,
        OtherPersonelExpenses,
        OtherThirdPartyBenefits,
        EmployerContributions,
        ExpendituresForInformationDayEvents,
        ReceptionAndHospitalityExpenses,
        SelfEmployedSocialSecurityContributions,
        OtherFees
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpensesObjElementExportCategoryType
    {
        None,
        AdditionalInterchangeableExpense1,
        AdditionalInterchangeableExpense2,
        AdditionalInterchangeableExpense3,
        AdditionalInterchangeableCharge1,
        AdditionalInterchangeableCharge2,
        AdditionalInterchangeableCharge3,
        ClearanceSupply
    }

    public class EntersoftWebApi2ODSModelsESFICreditorObj
    {
        public EntersoftWebApi2ODSModelsESFICreditorObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjKEPYOStatusType KEPYOStatus { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjVATStatusType VATStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGID { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGID { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGID { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }
        public string GLAccountCode { get; set; }
        public string DayOfMonth { get; set; }
        public string DocumentMessage { get; set; }

        [JsonProperty("fBudgetTradeAccountGroupCode")]
        public string FBudgetTradeAccountGroupCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public int PriceZone { get; set; }
        public int NumValeurDays { get; set; }
        public bool GroupDocuments { get; set; }
        public string ClubCardNumber { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGID { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public EntersoftWebApi2ODSModelsESFICreditorObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }
        public int HasPerson { get; set; }
        public int MainAddressVATStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjKEPYOStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    public enum EntersoftWebApi2ODSModelsESFICreditorObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2ODSModelsESFIDocumentCashObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FADDocumentUpdateProfileGID { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FADDocumentTypeGID { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FADDocumentSeriesGID { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADDocumentStateType ADDocumentState { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADOriginType ADOrigin { get; set; }
        public double TotalValue { get; set; }
        public double DeductionsValue { get; set; }
        public double ChargesValue { get; set; }
        public double TaxesValue { get; set; }
        public double PayableAmount { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FADCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double ADCurrencyValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FADTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FADTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FADTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FADTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FADTableField5Code { get; set; }
        public string ADDateField1 { get; set; }
        public string ADDateField2 { get; set; }
        public string ADDateField3 { get; set; }
        public string ADDateField4 { get; set; }
        public string ADDateField5 { get; set; }
        public string ADStringField1 { get; set; }
        public string ADStringField2 { get; set; }
        public string ADStringField3 { get; set; }
        public string ADStringField4 { get; set; }
        public string ADStringField5 { get; set; }

        [JsonProperty("fADProjectGID")]
        public string FADProjectGID { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FADActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FADBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FADDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FADDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FADSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjVATStatusType VATStatus { get; set; }
        public double CurrencyDeductionsValue { get; set; }
        public double CurrencyChargesValue { get; set; }
        public double CurrencyTaxesValue { get; set; }
        public double CurrencyPayableAmount { get; set; }
        public int TransitionBatchID { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public int TradeAccountNature { get; set; }
        public int TradeAccountType { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FADNoteStateCode { get; set; }
        public double TradeAccountPreviousBalance { get; set; }
        public bool ADTransitionAvailability { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FADAccountManagerGID { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGID { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGID { get; set; }
        public double TradeAccountPreviousBonusBalance { get; set; }
        public double TotalBonusValue { get; set; }
        public double CurrencyTotalBonusValue { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FADTaskGID { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FADDocumentUpdateProfileGLGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADLockModeType ADLockMode { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fBudgetSheetGID")]
        public string FBudgetSheetGID { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }
        public bool PaymentVATRequired { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentCashObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }

        [JsonProperty("fPersonBankAccountGID")]
        public string FPersonBankAccountGID { get; set; }
        public bool SplitOnVATRequired { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FADShiftGID { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FADMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TDSLEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TDSLEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TDSLEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TDSLEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TDSLEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TDSLEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TDSLEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TDSLEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TDSLEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TDSLEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TDSLEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TDSLEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TDSLEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TDSLEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TDSLEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TDSLEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TDSLEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TDSLEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TDSLEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TDSLEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TDSLEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TDSLEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TDSLEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TDSLEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TDSLEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TDSLEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TDSLEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CANCELAFTERSAVEFCancellingSeriesGID { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CANCELAFTERSAVEADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CANCELAFTERSAVEReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CANCELAFTERSAVEADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CANCELAFTERSAVEADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CANCELAFTERSAVEESUCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public int CreditControl { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int CurrencyExchangePriceType { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public double CurrencyClearAmount { get; set; }
        public double CurrencyChargesVATValue { get; set; }
        public double CurrencyTaxesVATValue { get; set; }
        public double CurrencyVATValue { get; set; }
        public double ClearAmount { get; set; }
        public double ChargesVATValue { get; set; }
        public double TaxesVATValue { get; set; }
        public double VATValue { get; set; }
        public string BannerColumn { get; set; }
        public double CashPayableAmount { get; set; }
        public double CurrencyCashPayableAmount { get; set; }
        public double CardPayableAmount { get; set; }
        public double CurrencyCardPayableAmount { get; set; }
        public double NotePayableAmount { get; set; }
        public double CurrencyNotePayableAmount { get; set; }
        public double TotalGiftVoucherValue { get; set; }
        public double CurrencyTotalGiftVoucherValue { get; set; }
        public double IssueGiftVoucherValue { get; set; }
        public double CurrencyIssueGiftVoucherValue { get; set; }
        public double RedeemGiftVoucherValue { get; set; }
        public double CurrencyRedeemGiftVoucherValue { get; set; }
        public double TotalDiscountVoucherValue { get; set; }
        public double CurrencyTotalDiscountVoucherValue { get; set; }
        public double IssueDiscountVoucherValue { get; set; }
        public double CurrencyIssueDiscountVoucherValue { get; set; }
        public double RedeemDiscountVoucherValue { get; set; }
        public double CurrencyRedeemDiscountVoucherValue { get; set; }
        public double RedeemGiftVoucherPayableValue { get; set; }
        public double CurrencyRedeemGiftVoucherPayableValue { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string ADReferenceCodeList { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentCashObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2ODSModelsESMMStockOrderPlanObj
    {
        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }

        [JsonProperty("fColorCode")]
        public string FColorCode { get; set; }

        [JsonProperty("fSizeCode")]
        public string FSizeCode { get; set; }

        [JsonProperty("fStockDim1Code")]
        public string FStockDim1Code { get; set; }

        [JsonProperty("fStockDim2Code")]
        public string FStockDim2Code { get; set; }

        [JsonProperty("fStockCategoryCode")]
        public string FStockCategoryCode { get; set; }
        public string CrossCompanyID { get; set; }
        public double BottomLevel { get; set; }
        public double UpperLevel { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESFISupplierObj
    {
        public EntersoftWebApi2ODSModelsESFISupplierObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjKEPYOStatusType KEPYOStatus { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjVATStatusType VATStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGID { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGID { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGID { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }
        public string GLAccountCode { get; set; }
        public string DayOfMonth { get; set; }
        public string DocumentMessage { get; set; }

        [JsonProperty("fBudgetTradeAccountGroupCode")]
        public string FBudgetTradeAccountGroupCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public int PriceZone { get; set; }
        public int NumValeurDays { get; set; }
        public bool GroupDocuments { get; set; }
        public string ClubCardNumber { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGID { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public EntersoftWebApi2ODSModelsESFISupplierObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }
        public int HasPerson { get; set; }
        public int MainAddressVATStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjKEPYOStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    public enum EntersoftWebApi2ODSModelsESFISupplierObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2ODSModelsESFIItemExpenseObj
    {
        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGID { get; set; }
        public bool WEB { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemExpenseObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMUGID { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NSIsSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjSubTypeType
    {
        Service,
        Expense
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjExpenseTypeType
    {
        VariousExpenses,
        Paycheck,
        ThirdPartyFees,
        Electricity,
        Telecommunications,
        Rents,
        Watering,
        Insurance,
        Transportation,
        Travel,
        Markerting,
        Subscriptions,
        Stationery,
        Taxes,
        Interest,
        OtherPersonelExpenses,
        OtherThirdPartyBenefits,
        EmployerContributions,
        ExpendituresForInformationDayEvents,
        ReceptionAndHospitalityExpenses,
        SelfEmployedSocialSecurityContributions,
        OtherFees
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    public enum EntersoftWebApi2ODSModelsESFIItemExpenseObjElementExportCategoryType
    {
        None,
        AdditionalInterchangeableExpense1,
        AdditionalInterchangeableExpense2,
        AdditionalInterchangeableExpense3,
        AdditionalInterchangeableCharge1,
        AdditionalInterchangeableCharge2,
        AdditionalInterchangeableCharge3,
        ClearanceSupply
    }

    public class EntersoftWebApi2ODSModelsESFISalesPersonObj
    {
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fCommercialUnitCode")]
        public string FCommercialUnitCode { get; set; }
        public string AlternativeCode { get; set; }
        public string Objective { get; set; }
        public string AccountStartDate { get; set; }
        public string GLAccountCode { get; set; }
        public double BaseCommission { get; set; }

        [JsonProperty("fCommissionProfileGID")]
        public string FCommissionProfileGID { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fBudgetSalespersonGroupCode")]
        public string FBudgetSalespersonGroupCode { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("NS_InitSalesPersons_Replacement")]
        public bool NSInitSalesPersonsReplacement { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESFIPaymentMethodObj
    {
        public bool AutoShow { get; set; }

        [JsonProperty("fCalendarCode")]
        public string FCalendarCode { get; set; }
        public double LimitAmount { get; set; }

        [JsonProperty("fNewPaymentMethodGID")]
        public string FNewPaymentMethodGID { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }
        public int GroupType { get; set; }
        public bool Mobile { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESFIItemObj
    {
        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGID { get; set; }
        public bool WEB { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMUGID { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NSIsSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjSubTypeType
    {
        Service,
        Expense
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjExpenseTypeType
    {
        VariousExpenses,
        Paycheck,
        ThirdPartyFees,
        Electricity,
        Telecommunications,
        Rents,
        Watering,
        Insurance,
        Transportation,
        Travel,
        Markerting,
        Subscriptions,
        Stationery,
        Taxes,
        Interest,
        OtherPersonelExpenses,
        OtherThirdPartyBenefits,
        EmployerContributions,
        ExpendituresForInformationDayEvents,
        ReceptionAndHospitalityExpenses,
        SelfEmployedSocialSecurityContributions,
        OtherFees
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    public enum EntersoftWebApi2ODSModelsESFIItemObjElementExportCategoryType
    {
        None,
        AdditionalInterchangeableExpense1,
        AdditionalInterchangeableExpense2,
        AdditionalInterchangeableExpense3,
        AdditionalInterchangeableCharge1,
        AdditionalInterchangeableCharge2,
        AdditionalInterchangeableCharge3,
        ClearanceSupply
    }

    public class EntersoftWebApi2ODSModelsESFISpecialAccountObj
    {
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjAccountTypeType AccountType { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public string CustomCondition { get; set; }

        [JsonProperty("fAccountGID")]
        public string FAccountGID { get; set; }
        public bool StandAloneLine { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }

        [JsonProperty("fDistributionKeyCode")]
        public string FDistributionKeyCode { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjDiscountLineUpdateType DiscountLineUpdate { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjAmountTypeType AmountType { get; set; }
        public double Amount { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjPriceRelatedFieldType PriceRelatedField { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjPercentageRelatedFieldType PercentageRelatedField { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjRoundingTypeType RoundingType { get; set; }
        public string Comments { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjOriginType Origin { get; set; }
        public bool AutoApply { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }
        public string GLAccountCode { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjIsKEPYOType IsKEPYO { get; set; }
        public string ReferenceField { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjCalcFromPrevLineType CalcFromPrevLine { get; set; }
        public bool IncludedInItemsGrossPrice { get; set; }

        [JsonProperty("fRelativeCarrierGID")]
        public string FRelativeCarrierGID { get; set; }
        public bool GiftCard { get; set; }
        public bool AutoSplit { get; set; }
        public bool IsTaxDeduction { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjElementExportCategoryType ElementExportCategory { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }
        public EntersoftWebApi2ODSModelsESFISpecialAccountObjTypeType Type { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fMyDataChargeCategoryCode")]
        public string FMyDataChargeCategoryCode { get; set; }

        [JsonProperty("fDiscountKindCode")]
        public string FDiscountKindCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjAccountTypeType
    {
        Charge,
        Tax,
        Discount,
        Deduction,
        Bonus
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjDiscountLineUpdateType
    {
        Discount1,
        Discount2,
        Discount3,
        Discount4
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjAmountTypeType
    {
        Price,
        Value,
        Percent,
        Round
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjPriceRelatedFieldType
    {
        Quantity,
        AlternativeQuantity,
        BaseQuantity,
        Weight,
        Volume
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjPercentageRelatedFieldType
    {
        [EnumMember(Value = "HP_BaseValue")]
        HPBaseValue,
        [EnumMember(Value = "HP_ValueUnderTaxes")]
        HPValueUnderTaxes,
        [EnumMember(Value = "HP_NetValue")]
        HPNetValue,
        [EnumMember(Value = "HP_TotalValue")]
        HPTotalValue,
        [EnumMember(Value = "HP_TotalValueAfterDiscounts")]
        HPTotalValueAfterDiscounts,
        [EnumMember(Value = "HP_CardPaymentAmount")]
        HPCardPaymentAmount,
        [EnumMember(Value = "HP_ValueAfter3Discounts")]
        HPValueAfter3Discounts,
        [EnumMember(Value = "HP_QuantityAndGrossPriceProduct")]
        HPQuantityAndGrossPriceProduct,
        [EnumMember(Value = "LP_BaseValue")]
        LPBaseValue,
        [EnumMember(Value = "LP_ValueUnderTaxes")]
        LPValueUnderTaxes,
        [EnumMember(Value = "LP_NetValue")]
        LPNetValue,
        [EnumMember(Value = "LP_TotalValue")]
        LPTotalValue,
        [EnumMember(Value = "LP_ValueAfter3Discounts")]
        LPValueAfter3Discounts,
        [EnumMember(Value = "LP_QuantityAndGrossPriceProduct")]
        LPQuantityAndGrossPriceProduct
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjRoundingTypeType
    {
        NoDecimal,
        _0,
        _00,
        _000
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjOriginType
    {
        DocumentType,
        TradeAccount,
        Item,
        [EnumMember(Value = "Item_TradeAccount")]
        ItemTradeAccount,
        ShippingMethod
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjIsKEPYOType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjCalcFromPrevLineType
    {
        No,
        LineValue,
        RunningTotal
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjElementExportCategoryType
    {
        None,
        AdditionalInterchangeableExpense1,
        AdditionalInterchangeableExpense2,
        AdditionalInterchangeableExpense3,
        AdditionalInterchangeableCharge1,
        AdditionalInterchangeableCharge2,
        AdditionalInterchangeableCharge3,
        ClearanceSupply
    }

    public enum EntersoftWebApi2ODSModelsESFISpecialAccountObjTypeType
    {
        Revenue,
        Expense
    }

    public class EntersoftWebApi2ODSModelsESFIDocumentStockObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FADDocumentUpdateProfileGID { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FADDocumentTypeGID { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FADDocumentSeriesGID { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjSourceTypeType SourceType { get; set; }

        [JsonProperty("fSourceGID")]
        public string FSourceGID { get; set; }
        public string SourceName { get; set; }

        [JsonProperty("fSourceSiteGID")]
        public string FSourceSiteGID { get; set; }
        public string SourceSiteName { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjTargetTypeType TargetType { get; set; }

        [JsonProperty("fTargetGID")]
        public string FTargetGID { get; set; }
        public string TargetName { get; set; }

        [JsonProperty("fTargetSiteGID")]
        public string FTargetSiteGID { get; set; }
        public string TargetSiteName { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADDocumentStateType ADDocumentState { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADOriginType ADOrigin { get; set; }
        public int TotalQuantity { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FADTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FADTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FADTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FADTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FADTableField5Code { get; set; }
        public string ADDateField1 { get; set; }
        public string ADDateField2 { get; set; }
        public string ADDateField3 { get; set; }
        public string ADDateField4 { get; set; }
        public string ADDateField5 { get; set; }
        public string ADStringField1 { get; set; }
        public string ADStringField2 { get; set; }
        public string ADStringField3 { get; set; }
        public string ADStringField4 { get; set; }
        public string ADStringField5 { get; set; }

        [JsonProperty("fADProjectGID")]
        public string FADProjectGID { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FADActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FADBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FADDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FADDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FADSiteGID { get; set; }
        public int TransitionBatchID { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FADNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FSNStateCode { get; set; }
        public bool ADTransitionAvailability { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FADAccountManagerGID { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGID { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }
        public bool SortimentHandling { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGID { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGID { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fSenderPersonGID")]
        public string FSenderPersonGID { get; set; }

        [JsonProperty("fShippingPurposeCode")]
        public string FShippingPurposeCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGID { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FADTaskGID { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FADDocumentUpdateProfileGLGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGID { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FWFStepCode { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGID { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentStockObjADProcessStateType ADProcessState { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGID { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FADShiftGID { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FADMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FADCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public int VATStatus { get; set; }
        public int ApplyCommercialPolicy { get; set; }
        public int BOMExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TDSLEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TDSLEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TDSLEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TDSLEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TDSLEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TDSLEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TDSLEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TDSLEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TDSLEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TDSLEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TDSLEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TDSLEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TDSLEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TDSLEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TDSLEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TDSLEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TDSLEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TDSLEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TDSLEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TDSLEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TDSLEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TDSLEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TDSLEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TDSLEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TDSLEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TDSLEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TDSLEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CANCELAFTERSAVEFCancellingSeriesGID { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CANCELAFTERSAVEADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CANCELAFTERSAVEReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CANCELAFTERSAVEADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CANCELAFTERSAVEADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CANCELAFTERSAVEESUCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NSTCourierTrackingID { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NSTCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NSTCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NSTCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NSTCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NSTCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NSTCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NSTCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NSTCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NSTCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NSTCourierJobID { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("fSourcePersonCodeGID")]
        public string FSourcePersonCodeGID { get; set; }

        [JsonProperty("fTargetPersonCodeGID")]
        public string FTargetPersonCodeGID { get; set; }
        public int CompactLineItemsOnSave { get; set; }
        public int AddLIAFromDomainOnRetailMode { get; set; }
        public double TotalQtyBaseMU { get; set; }
        public double TotalQtyVariable1 { get; set; }
        public int ForceRelatedItemGeneration { get; set; }

        [JsonProperty("vTotalQuantity")]
        public string VTotalQuantity { get; set; }

        [JsonProperty("vTotalQuantityBaseMU")]
        public string VTotalQuantityBaseMU { get; set; }

        [JsonProperty("vTotalAlternativeQuantity")]
        public string VTotalAlternativeQuantity { get; set; }

        [JsonProperty("vTotalVolume")]
        public string VTotalVolume { get; set; }

        [JsonProperty("vTotalWeight")]
        public string VTotalWeight { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string ADReferenceCodeList { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NSFDeliveryPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NSFDeliveryPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NSFDeliverySiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NSFSenderPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NSFSenderPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NSFSenderSiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjSourceTypeType
    {
        CompanySite,
        TradeAccount,
        Bank,
        Collector,
        Transporter
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjTargetTypeType
    {
        CompanySite,
        TradeAccount,
        Bank,
        Collector,
        Transporter
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentStockObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2ODSModelsESFINoteObj
    {
        public string ReferenceNumber { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjNatureType Nature { get; set; }

        [JsonProperty("fNoteTypeCode")]
        public string FNoteTypeCode { get; set; }

        [JsonProperty("fNoteStateCode")]
        public string FNoteStateCode { get; set; }
        public bool IsOpen { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }

        [JsonProperty("fPaymentAccountGID")]
        public string FPaymentAccountGID { get; set; }

        [JsonProperty("fPersonBankGID")]
        public string FPersonBankGID { get; set; }
        public string Bank { get; set; }

        [JsonProperty("fRegistrationDocumentGID")]
        public string FRegistrationDocumentGID { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public double NoteValue { get; set; }
        public double CurrencyValue { get; set; }
        public double ClosedValue { get; set; }
        public double ClosedCurrencyValue { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjSourceAccountTypeType SourceAccountType { get; set; }

        [JsonProperty("fSourceAccountGID")]
        public string FSourceAccountGID { get; set; }

        [JsonProperty("fSourceAccountSiteGID")]
        public string FSourceAccountSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjTargetAccountTypeType TargetAccountType { get; set; }

        [JsonProperty("fTargetAccountGID")]
        public string FTargetAccountGID { get; set; }

        [JsonProperty("fTargetAccountSiteGID")]
        public string FTargetAccountSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjHolderTypeType HolderType { get; set; }

        [JsonProperty("fHolderGID")]
        public string FHolderGID { get; set; }
        public string HolderName { get; set; }

        [JsonProperty("fHolderAddressGID")]
        public string FHolderAddressGID { get; set; }
        public string HolderAddress { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjIssuedByTypeType IssuedByType { get; set; }

        [JsonProperty("fIssuedByGID")]
        public string FIssuedByGID { get; set; }
        public string IssuedByName { get; set; }

        [JsonProperty("fIssuedByAddressGID")]
        public string FIssuedByAddressGID { get; set; }
        public string IssuedByAddress { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjUnderwriterTypeType UnderwriterType { get; set; }

        [JsonProperty("fUnderwriterGID")]
        public string FUnderwriterGID { get; set; }
        public string UnderwriterName { get; set; }

        [JsonProperty("fUnderwriterAddressGID")]
        public string FUnderwriterAddressGID { get; set; }
        public string UnderwriterAddress { get; set; }
        public string Comments { get; set; }
        public double CurrencyRate { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool Printed { get; set; }

        [JsonProperty("fNoteDepositBankAccountGID")]
        public string FNoteDepositBankAccountGID { get; set; }
        public EntersoftWebApi2ODSModelsESFINoteObjConcernsType Concerns { get; set; }
        public double OpenValue { get; set; }
        public double OpenCurrencyValue { get; set; }
        public bool Computerized { get; set; }
        public double CurrencyReversedRate { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjNatureType
    {
        Receivable,
        Payable
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjSourceAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor,
        Other
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjTargetAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor,
        Other
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjHolderTypeType
    {
        [EnumMember(Value = "One_Off")]
        OneOff,
        Customer,
        Supplier,
        [EnumMember(Value = "Debtor_Creditor")]
        DebtorCreditor,
        CompanySite,
        Person,
        Bank,
        GLAccount
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjIssuedByTypeType
    {
        [EnumMember(Value = "One_Off")]
        OneOff,
        Customer,
        Supplier,
        [EnumMember(Value = "Debtor_Creditor")]
        DebtorCreditor,
        CompanySite,
        Person,
        Bank,
        GLAccount
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjUnderwriterTypeType
    {
        [EnumMember(Value = "One_Off")]
        OneOff,
        Customer,
        Supplier,
        [EnumMember(Value = "Debtor_Creditor")]
        DebtorCreditor,
        CompanySite,
        Person,
        Bank,
        GLAccount
    }

    public enum EntersoftWebApi2ODSModelsESFINoteObjConcernsType
    {
        All,
        NetValue,
        VatValue
    }

    public class EntersoftWebApi2ODSModelsESFITradeAccountContractObj
    {
        public string AlternativeCode { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fBlanketOrderGID")]
        public string FBlanketOrderGID { get; set; }
        public bool CheckItems { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public double GlobalDiscount { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string RenewalDate { get; set; }
        public string SignDate { get; set; }

        [JsonProperty("fResponsibleGID")]
        public string FResponsibleGID { get; set; }

        [JsonProperty("fResponsibleContactGID")]
        public string FResponsibleContactGID { get; set; }

        [JsonProperty("fRepresentativeGID")]
        public string FRepresentativeGID { get; set; }

        [JsonProperty("fReferenceGID")]
        public string FReferenceGID { get; set; }

        [JsonProperty("fReferenceOrganizationGID")]
        public string FReferenceOrganizationGID { get; set; }
        public double TotalValue { get; set; }
        public double TotalCost { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public string TextField1 { get; set; }
        public string TextField2 { get; set; }
        public string TextField3 { get; set; }
        public string TextField4 { get; set; }
        public string TextField5 { get; set; }
        public string Comments { get; set; }
        public string Attachment { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public bool Flag11 { get; set; }
        public bool Flag12 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TextField6 { get; set; }
        public string TextField7 { get; set; }
        public string TextField8 { get; set; }
        public string TextField9 { get; set; }
        public string TextField10 { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }

        [JsonProperty("fContractTypeGID")]
        public string FContractTypeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }
        public bool IsServiceContract { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountContractObjPeriodLengthType PeriodLength { get; set; }

        [JsonProperty("fSupersededContractGID")]
        public string FSupersededContractGID { get; set; }
        public int CreditDays { get; set; }

        [JsonProperty("fFinancialAgreementGID")]
        public string FFinancialAgreementGID { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGID { get; set; }

        [JsonProperty("fCategoryCode")]
        public string FCategoryCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("nsComments_RTF")]
        public string NsCommentsRTF { get; set; }

        [JsonProperty("nsComments_Blob")]
        public string NsCommentsBlob { get; set; }

        [JsonProperty("NS_InvoicedValue")]
        public double NSInvoicedValue { get; set; }

        [JsonProperty("NS_RemainedValue")]
        public double NSRemainedValue { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountContractObjPeriodLengthType
    {
        OneMonthPeriod,
        TwoMonthsPeriod,
        ThreeMonthsPeriod,
        FourMonthsPeriod,
        SixMonthsPeriod,
        WeekPeriod,
        FifteenDaysPeriod,
        YearPeriod,
        AllDaysPeriod,
        SpecificInvoiceDate
    }

    public class EntersoftWebApi2ODSModelsESFIVoucherObj
    {
        public string Barcode { get; set; }

        [JsonProperty("fVoucherPromotionProfileGID")]
        public string FVoucherPromotionProfileGID { get; set; }
        public double DiscVoucherValue { get; set; }
        public double DiscVoucherPercentage { get; set; }
        public double GiftVoucherValue { get; set; }
        public double GiftVoucherClosedValue { get; set; }
        public EntersoftWebApi2ODSModelsESFIVoucherObjTypeType Type { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }
        public string RegistrationDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Notes { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fDocumentGID")]
        public string FDocumentGID { get; set; }
        public bool Printed { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCashAccountGID")]
        public string FCashAccountGID { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fTaskItemGID")]
        public string FTaskItemGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIVoucherObjTypeType
    {
        DiscVoucherValue,
        DiscVoucherPercentage,
        GiftVoucherValue
    }

    public class EntersoftWebApi2ODSModelsESFICustomerObj
    {
        public EntersoftWebApi2ODSModelsESFICustomerObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjKEPYOStatusType KEPYOStatus { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjVATStatusType VATStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGID { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGID { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGID { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }
        public string GLAccountCode { get; set; }
        public string DayOfMonth { get; set; }
        public string DocumentMessage { get; set; }

        [JsonProperty("fBudgetTradeAccountGroupCode")]
        public string FBudgetTradeAccountGroupCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public int PriceZone { get; set; }
        public int NumValeurDays { get; set; }
        public bool GroupDocuments { get; set; }
        public string ClubCardNumber { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGID { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public EntersoftWebApi2ODSModelsESFICustomerObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }
        public int HasPerson { get; set; }
        public int MainAddressVATStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjKEPYOStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    public enum EntersoftWebApi2ODSModelsESFICustomerObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2ODSModelsESFIDebtorObj
    {
        public EntersoftWebApi2ODSModelsESFIDebtorObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjKEPYOStatusType KEPYOStatus { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjVATStatusType VATStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGID { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGID { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGID { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }
        public string GLAccountCode { get; set; }
        public string DayOfMonth { get; set; }
        public string DocumentMessage { get; set; }

        [JsonProperty("fBudgetTradeAccountGroupCode")]
        public string FBudgetTradeAccountGroupCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public int PriceZone { get; set; }
        public int NumValeurDays { get; set; }
        public bool GroupDocuments { get; set; }
        public string ClubCardNumber { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGID { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDebtorObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }
        public int HasPerson { get; set; }
        public int MainAddressVATStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjKEPYOStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    public enum EntersoftWebApi2ODSModelsESFIDebtorObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2ODSModelsESFIPricelistObj
    {
        public EntersoftWebApi2ODSModelsESFIPricelistObjKindType Kind { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }

        [JsonProperty("fReferencedPricelistGID")]
        public string FReferencedPricelistGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIPricelistObjDiscountAssignmentType DiscountAssignment { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGID { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTransportPlanGID")]
        public string FTransportPlanGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIPricelistObjTypeType Type { get; set; }
        public bool ApplyAnyCurrencyPrice { get; set; }
        public EntersoftWebApi2ODSModelsESFIPricelistObjDiscountSelectionType DiscountSelection { get; set; }
        public int ActiveDimensions { get; set; }

        [JsonProperty("fDiscountKindCode")]
        public string FDiscountKindCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIPricelistObjKindType
    {
        Sales,
        Purchases
    }

    public enum EntersoftWebApi2ODSModelsESFIPricelistObjDiscountAssignmentType
    {
        DirectlyOnPrice,
        Discount1Field,
        Discount2Field,
        Discount3Field
    }

    public enum EntersoftWebApi2ODSModelsESFIPricelistObjTypeType
    {
        Simple,
        Synthesis,
        Prioritized,
        InvoicePolicyReference
    }

    public enum EntersoftWebApi2ODSModelsESFIPricelistObjDiscountSelectionType
    {
        All,
        Maximum,
        FirstCrossField,
        FirstPerField
    }

    public class EntersoftWebApi2ODSModelsESFIItemServiceObj
    {
        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGID { get; set; }
        public bool WEB { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIItemServiceObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMUGID { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NSIsSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjSubTypeType
    {
        Service,
        Expense
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjExpenseTypeType
    {
        VariousExpenses,
        Paycheck,
        ThirdPartyFees,
        Electricity,
        Telecommunications,
        Rents,
        Watering,
        Insurance,
        Transportation,
        Travel,
        Markerting,
        Subscriptions,
        Stationery,
        Taxes,
        Interest,
        OtherPersonelExpenses,
        OtherThirdPartyBenefits,
        EmployerContributions,
        ExpendituresForInformationDayEvents,
        ReceptionAndHospitalityExpenses,
        SelfEmployedSocialSecurityContributions,
        OtherFees
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    public enum EntersoftWebApi2ODSModelsESFIItemServiceObjElementExportCategoryType
    {
        None,
        AdditionalInterchangeableExpense1,
        AdditionalInterchangeableExpense2,
        AdditionalInterchangeableExpense3,
        AdditionalInterchangeableCharge1,
        AdditionalInterchangeableCharge2,
        AdditionalInterchangeableCharge3,
        ClearanceSupply
    }

    public class EntersoftWebApi2ODSModelsESFICashAccountObj
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }

        [JsonProperty("fPersonBankGID")]
        public string FPersonBankGID { get; set; }
        public string SpecialCode { get; set; }

        [JsonProperty("fCashAccountTypeCode")]
        public string FCashAccountTypeCode { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public string AlternativeName { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("fBankSiteGID")]
        public string FBankSiteGID { get; set; }
        public string Remarks { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }
        public double BalanceLimit { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }
        public bool AutoForecast { get; set; }
        public bool EnforceCurrency { get; set; }
        public int NumValeurDays { get; set; }
        public bool ConcernsCard { get; set; }

        [JsonProperty("fCashRequirementsAccountGID")]
        public string FCashRequirementsAccountGID { get; set; }

        [JsonProperty("fCardRateProfileGID")]
        public string FCardRateProfileGID { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string GLAccountCode { get; set; }
        public bool AutoPayableNote { get; set; }

        [JsonProperty("fBudgetCashAccountGroupCode")]
        public string FBudgetCashAccountGroupCode { get; set; }
        public bool AutoPayment { get; set; }
        public string NoteNumberingPolicy { get; set; }
        public string NoteCheckDigitEvalType { get; set; }
        public string NotePrintingForm { get; set; }
        public bool HasNoteNumbering { get; set; }
        public bool CheckDigitEvaluation { get; set; }
        public string IBANCode { get; set; }
        public string SwiftCode { get; set; }
        public EntersoftWebApi2ODSModelsESFICashAccountObjExportTransferLayoutTypeType ExportTransferLayoutType { get; set; }

        [JsonProperty("fClearingBankCode")]
        public string FClearingBankCode { get; set; }
        public int MaximumNumberOfInstallments { get; set; }
        public string OutputDevice { get; set; }
        public EntersoftWebApi2ODSModelsESFICashAccountObjNotesNumberingModeType NotesNumberingMode { get; set; }
        public bool ConcernsThirdCashOnDelivery { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }

        [JsonProperty("fElectronicTransactionsProfileCode")]
        public string FElectronicTransactionsProfileCode { get; set; }
        public EntersoftWebApi2ODSModelsESFICashAccountObjConcernsType Concerns { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public bool ConcernsGiftCards { get; set; }

        [JsonProperty("fMyDataPaymentMethodsCode")]
        public string FMyDataPaymentMethodsCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFICashAccountObjExportTransferLayoutTypeType
    {
        None,
        Alpha,
        WinBank,
        Eurobank,
        Ethniki
    }

    public enum EntersoftWebApi2ODSModelsESFICashAccountObjNotesNumberingModeType
    {
        BasedOnIntervals,
        BasedOnSpecifiedValues
    }

    public enum EntersoftWebApi2ODSModelsESFICashAccountObjConcernsType
    {
        All,
        NetValue,
        VatValue
    }

    public class EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FADDocumentUpdateProfileGID { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FADDocumentTypeGID { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FADDocumentSeriesGID { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjAccountTypeType AccountType { get; set; }

        [JsonProperty("fAccountGID")]
        public string FAccountGID { get; set; }

        [JsonProperty("fAccountSiteGID")]
        public string FAccountSiteGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADDocumentStateType ADDocumentState { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADOriginType ADOrigin { get; set; }
        public double TotalValue { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FADCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double ADCurrencyValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FADTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FADTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FADTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FADTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FADTableField5Code { get; set; }
        public string ADDateField1 { get; set; }
        public string ADDateField2 { get; set; }
        public string ADDateField3 { get; set; }
        public string ADDateField4 { get; set; }
        public string ADDateField5 { get; set; }
        public string ADStringField1 { get; set; }
        public string ADStringField2 { get; set; }
        public string ADStringField3 { get; set; }
        public string ADStringField4 { get; set; }
        public string ADStringField5 { get; set; }

        [JsonProperty("fADProjectGID")]
        public string FADProjectGID { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FADActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FADBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FADDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FADDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FADSiteGID { get; set; }
        public int TransitionBatchID { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public int TradeAccountNature { get; set; }
        public int TradeAccountType { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FADNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FSNStateCode { get; set; }

        [JsonProperty("fSNPostStateCode")]
        public string FSNPostStateCode { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGID { get; set; }
        public string ConcerningDocCode { get; set; }
        public bool ADTransitionAvailability { get; set; }
        public int ConcerningDocClass { get; set; }
        public string ConcerningBeginDate { get; set; }
        public string ConcerningEndDate { get; set; }
        public int StockValuationBatchID { get; set; }
        public bool Allocated { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FADAccountManagerGID { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }
        public int DepreciationBatchID { get; set; }
        public int AssetRevaluationBatchID { get; set; }
        public bool SortimentHandling { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGID { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGID { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fSenderPersonGID")]
        public string FSenderPersonGID { get; set; }

        [JsonProperty("fShippingPurposeCode")]
        public string FShippingPurposeCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }
        public bool KEPYOUpdate { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADTransitionStateType ADTransitionState { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjVATStatusType VATStatus { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGID { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FADTaskGID { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FADDocumentUpdateProfileGLGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGID { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool PaymentVATRequired { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FWFStepCode { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGID { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGID { get; set; }
        public EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGID { get; set; }
        public bool SplitOnVATRequired { get; set; }

        [JsonProperty("fTradeTypeCode")]
        public string FTradeTypeCode { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FADShiftGID { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FADMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }
        public int ApplyCommercialPolicy { get; set; }
        public int BOMExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TDSLEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TDSLEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TDSLEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TDSLEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TDSLEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TDSLEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TDSLEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TDSLEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TDSLEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TDSLEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TDSLEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TDSLEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TDSLEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TDSLEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TDSLEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TDSLEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TDSLEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TDSLEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TDSLEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TDSLEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TDSLEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TDSLEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TDSLEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TDSLEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TDSLEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TDSLEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TDSLEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CANCELAFTERSAVEFCancellingSeriesGID { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CANCELAFTERSAVEADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CANCELAFTERSAVEReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CANCELAFTERSAVEADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CANCELAFTERSAVEADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CANCELAFTERSAVEESUCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public int CreditControl { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NSTCourierTrackingID { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NSTCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NSTCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NSTCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NSTCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NSTCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NSTCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NSTCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NSTCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NSTCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NSTCourierJobID { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public int CurrencyExchangePriceType { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int CompactLineItemsOnSave { get; set; }
        public int AddLIAFromDomainOnRetailMode { get; set; }
        public double TotalQtyBaseMU { get; set; }
        public double TotalQtyVariable1 { get; set; }
        public int ForceRelatedItemGeneration { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("fPaymentAccountGID")]
        public string FPaymentAccountGID { get; set; }

        [JsonProperty("IGNORE_fPaymentAccountGID")]
        public int IGNOREFPaymentAccountGID { get; set; }

        [JsonProperty("vTotalQuantity")]
        public string VTotalQuantity { get; set; }

        [JsonProperty("vTotalQuantityBaseMU")]
        public string VTotalQuantityBaseMU { get; set; }

        [JsonProperty("vTotalAlternativeQuantity")]
        public string VTotalAlternativeQuantity { get; set; }

        [JsonProperty("vTotalVolume")]
        public string VTotalVolume { get; set; }

        [JsonProperty("vTotalWeight")]
        public string VTotalWeight { get; set; }

        [JsonProperty("bTotalNetValue")]
        public double BTotalNetValue { get; set; }

        [JsonProperty("bTotalCurrencyNetValue")]
        public double BTotalCurrencyNetValue { get; set; }

        [JsonProperty("bTotalDiscountValue")]
        public double BTotalDiscountValue { get; set; }

        [JsonProperty("bTotalCurrencyDiscountValue")]
        public double BTotalCurrencyDiscountValue { get; set; }

        [JsonProperty("bTotalValueBeforeDiscounts")]
        public double BTotalValueBeforeDiscounts { get; set; }

        [JsonProperty("bTotalCurrencyValueBeforeDiscounts")]
        public double BTotalCurrencyValueBeforeDiscounts { get; set; }

        [JsonProperty("bTotalVATValue")]
        public double BTotalVATValue { get; set; }

        [JsonProperty("bTotalCurrencyVATValue")]
        public double BTotalCurrencyVATValue { get; set; }

        [JsonProperty("bTotalTotalValue")]
        public double BTotalTotalValue { get; set; }

        [JsonProperty("bTotalCurrencyTotalValue")]
        public double BTotalCurrencyTotalValue { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string ADReferenceCodeList { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NSFDeliveryPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NSFDeliveryPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NSFDeliverySiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFDeliverySiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NSFSenderPersonGIDFCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NSFSenderPersonGIDFGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NSFSenderSiteGIDFSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NSFSenderSiteGIDFRegionGroupCodeFCategoryRegionGroupCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjAccountTypeType
    {
        GeneralLedgerAccount,
        TradeAccount,
        CashAccount,
        SpecialAccount,
        CompanySite,
        StockItem,
        AssetItem,
        SalesPerson
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    public enum EntersoftWebApi2ODSModelsESFIDocumentAdjustmentObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2ODSModelsESFITradeAccountObj
    {
        public EntersoftWebApi2ODSModelsESFITradeAccountObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjKEPYOStatusType KEPYOStatus { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjVATStatusType VATStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGID { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGID { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGID { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FGLAccountGID { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGID { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGID { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGID { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGID { get; set; }
        public string GLAccountCode { get; set; }
        public string DayOfMonth { get; set; }
        public string DocumentMessage { get; set; }

        [JsonProperty("fBudgetTradeAccountGroupCode")]
        public string FBudgetTradeAccountGroupCode { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public int PriceZone { get; set; }
        public int NumValeurDays { get; set; }
        public bool GroupDocuments { get; set; }
        public string ClubCardNumber { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGID { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGID { get; set; }
        public EntersoftWebApi2ODSModelsESFITradeAccountObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGID { get; set; }
        public int HasPerson { get; set; }
        public int MainAddressVATStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjNatureType
    {
        Requirements,
        Obligations
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjKEPYOStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    public enum EntersoftWebApi2ODSModelsESFITradeAccountObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2ODSModelsESFAFixedAssetObj
    {
        public string DetailDescription { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }
        public string InternationalCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }
        public string AlternativeCode { get; set; }
        public string BarCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjItemTypeType ItemType { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGID { get; set; }
        public string Manufacturer { get; set; }

        [JsonProperty("fCountryOriginCode")]
        public string FCountryOriginCode { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public double MarkupOnPrice { get; set; }
        public double MarkupOnRetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fAltMUGID")]
        public string FAltMUGID { get; set; }

        [JsonProperty("fWeightMUGID")]
        public string FWeightMUGID { get; set; }

        [JsonProperty("fVolumeMUGID")]
        public string FVolumeMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }
        public double MinProfitMargin { get; set; }
        public double MinSalesOrderQty { get; set; }
        public double UsualPurchaseOrderQty { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGID { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGID { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGID { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGID { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fCatalogueItemGID")]
        public string FCatalogueItemGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public bool Flag11 { get; set; }
        public bool Flag12 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }
        public int BOMLevel { get; set; }
        public EntersoftWebApi2ODSModelsESFAFixedAssetObjAssetTypeType AssetType { get; set; }
        public bool MainCode { get; set; }

        [JsonProperty("fDepreciationProfileGID")]
        public string FDepreciationProfileGID { get; set; }

        [JsonProperty("fAlternativeDepreciationProfileGID")]
        public string FAlternativeDepreciationProfileGID { get; set; }

        [JsonProperty("fInformativeDepreciationProfileGID")]
        public string FInformativeDepreciationProfileGID { get; set; }
        public bool OutOfUsage { get; set; }

        [JsonProperty("fMainAssetGID")]
        public string FMainAssetGID { get; set; }

        [JsonProperty("fAssetGLSegCode")]
        public string FAssetGLSegCode { get; set; }

        [JsonProperty("fDepreciationGLSegCode")]
        public string FDepreciationGLSegCode { get; set; }

        [JsonProperty("fDepreciatedGLSegCode")]
        public string FDepreciatedGLSegCode { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public int VATCalculationValue { get; set; }
        public bool CostIncludedVAT { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fItemAllocationProfileGIDPrev")]
        public string FItemAllocationProfileGIDPrev { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("NS_fMainMUCode")]
        public string NSFMainMUCode { get; set; }

        [JsonProperty("NS_fMainMUDescription")]
        public string NSFMainMUDescription { get; set; }

        [JsonProperty("NS_fWeightMUCode")]
        public string NSFWeightMUCode { get; set; }

        [JsonProperty("NS_fWeightMUDescription")]
        public string NSFWeightMUDescription { get; set; }

        [JsonProperty("NS_fAltMUCode")]
        public string NSFAltMUCode { get; set; }

        [JsonProperty("NS_fAltMUDescription")]
        public string NSFAltMUDescription { get; set; }

        [JsonProperty("NS_fVolumeMUCode")]
        public string NSFVolumeMUCode { get; set; }

        [JsonProperty("NS_fVolumeMUDescription")]
        public string NSFVolumeMUDescription { get; set; }

        [JsonProperty("NS_fSupplierGID")]
        public string NSFSupplierGID { get; set; }

        [JsonProperty("NS_fSupplierGID_SupplierItemCode")]
        public string NSFSupplierGIDSupplierItemCode { get; set; }

        [JsonProperty("NS_fSupplierGID_SupplierItemDescription")]
        public string NSFSupplierGIDSupplierItemDescription { get; set; }

        [JsonProperty("NS_IsAssembly")]
        public int NSIsAssembly { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjItemTypeType
    {
        Good,
        Product,
        FeedStock,
        SparePart,
        Consumable,
        Packing,
        Sponsion,
        Other,
        HalfReady,
        FeedStockB,
        BudgetRevenues,
        BudgetExpenses,
        PackingMaterial
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESFAFixedAssetObjAssetTypeType
    {
        Land,
        Building,
        Machine,
        Automobile,
        Furniture,
        SelfProducted,
        Intangible,
        Bonds,
        Other
    }

    public class EntersoftWebApi2ODSModelsESGOPersonObj
    {
        public string Name { get; set; }
        public string MultilingualName { get; set; }
        public string FullName { get; set; }
        public string CommonName { get; set; }
        public bool GroupPerson { get; set; }

        [JsonProperty("fParentGID")]
        public string FParentGID { get; set; }

        [JsonProperty("fCompanyKindCode")]
        public string FCompanyKindCode { get; set; }

        [JsonProperty("fActivityCode")]
        public string FActivityCode { get; set; }
        public string ActivityDescription { get; set; }
        public string TaxRegistrationNumber { get; set; }

        [JsonProperty("fTaxOfficeCode")]
        public string FTaxOfficeCode { get; set; }
        public EntersoftWebApi2ODSModelsESGOPersonObjVATStatusType VATStatus { get; set; }

        [JsonProperty("fMainAddressGID")]
        public string FMainAddressGID { get; set; }

        [JsonProperty("fGroupCode")]
        public string FGroupCode { get; set; }

        [JsonProperty("fCategoryCode")]
        public string FCategoryCode { get; set; }

        [JsonProperty("fLanguageCode")]
        public string FLanguageCode { get; set; }
        public string EMailAddress { get; set; }
        public string WEBSite { get; set; }
        public string Remarks { get; set; }
        public int AccessGroup { get; set; }
        public EntersoftWebApi2ODSModelsESGOPersonObjPersonKindType PersonKind { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [JsonProperty("fTitleCode")]
        public string FTitleCode { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public EntersoftWebApi2ODSModelsESGOPersonObjSexType Sex { get; set; }
        public string IDCode { get; set; }
        public EntersoftWebApi2ODSModelsESGOPersonObjFamilyStatusType FamilyStatus { get; set; }
        public string Birthday { get; set; }
        public string Anniversary { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string Stringfield1 { get; set; }
        public string Stringfield2 { get; set; }
        public string Stringfield3 { get; set; }
        public string Stringfield4 { get; set; }
        public string Stringfield5 { get; set; }
        public string Stringfield6 { get; set; }
        public string Stringfield7 { get; set; }
        public string Stringfield8 { get; set; }
        public string Stringfield9 { get; set; }
        public string Stringfield10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }

        [JsonProperty("fCalendarItemGID")]
        public string FCalendarItemGID { get; set; }

        [JsonProperty("fEducationLevelCode")]
        public string FEducationLevelCode { get; set; }

        [JsonProperty("fNationalityCountryCode")]
        public string FNationalityCountryCode { get; set; }

        [JsonProperty("fResidenceCountryCode")]
        public string FResidenceCountryCode { get; set; }

        [JsonProperty("fBirthCountryCode")]
        public string FBirthCountryCode { get; set; }
        public string DateOfBirth { get; set; }

        [JsonProperty("fReferredPersonGID")]
        public string FReferredPersonGID { get; set; }
        public EntersoftWebApi2ODSModelsESGOPersonObjPreferredWayOfContractType PreferredWayOfContract { get; set; }
        public string BulStat { get; set; }
        public string TradeRegistrationNumber { get; set; }
        public string PersonalNumericCode { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public bool PaymentVATRequired { get; set; }
        public string EORINumber { get; set; }
        public bool SplitOnVATRequired { get; set; }
        public string GCP { get; set; }
        public string TaxRegistrationDate { get; set; }
        public string TaxStopDate { get; set; }

        [JsonProperty("fIdentityTypeCode")]
        public string FIdentityTypeCode { get; set; }
        public string LinkedCompany { get; set; }

        [JsonProperty("NS_FirstName_Nominative")]
        public string NSFirstNameNominative { get; set; }

        [JsonProperty("NS_FirstName_Genitive")]
        public string NSFirstNameGenitive { get; set; }

        [JsonProperty("NS_FirstName_Accusative")]
        public string NSFirstNameAccusative { get; set; }

        [JsonProperty("NS_FirstName_Vocative")]
        public string NSFirstNameVocative { get; set; }

        [JsonProperty("NS_FirstName_Dative")]
        public string NSFirstNameDative { get; set; }

        [JsonProperty("NS_LastName_Nominative")]
        public string NSLastNameNominative { get; set; }

        [JsonProperty("NS_LastName_Genitive")]
        public string NSLastNameGenitive { get; set; }

        [JsonProperty("NS_LastName_Accusative")]
        public string NSLastNameAccusative { get; set; }

        [JsonProperty("NS_LastName_Vocative")]
        public string NSLastNameVocative { get; set; }

        [JsonProperty("NS_LastName_Dative")]
        public string NSLastNameDative { get; set; }

        [JsonProperty("NS_MainAddress_Description")]
        public string NSMainAddressDescription { get; set; }

        [JsonProperty("NS_MainAddress_Address1")]
        public string NSMainAddressAddress1 { get; set; }

        [JsonProperty("NS_MainAddress_Latitude")]
        public double NSMainAddressLatitude { get; set; }

        [JsonProperty("NS_MainAddress_Longitude")]
        public double NSMainAddressLongitude { get; set; }

        [JsonProperty("NS_MainAddress_GeoArea")]
        public string NSMainAddressGeoArea { get; set; }

        [JsonProperty("NS_MainAddress_AddressConfirmed")]
        public bool NSMainAddressAddressConfirmed { get; set; }

        [JsonProperty("NS_MainAddress_Status")]
        public bool NSMainAddressStatus { get; set; }

        [JsonProperty("NS_MainAddress_KindSite")]
        public bool NSMainAddressKindSite { get; set; }

        [JsonProperty("NS_MainAddress_KindWH")]
        public bool NSMainAddressKindWH { get; set; }

        [JsonProperty("NS_MainAddress_AutoActivation")]
        public bool NSMainAddressAutoActivation { get; set; }

        [JsonProperty("NS_MainAddress_Address2")]
        public string NSMainAddressAddress2 { get; set; }

        [JsonProperty("NS_MainAddress_fDistrictCode")]
        public string NSMainAddressFDistrictCode { get; set; }

        [JsonProperty("NS_MainAddress_fSiteTypeCode")]
        public string NSMainAddressFSiteTypeCode { get; set; }

        [JsonProperty("NS_MainAddress_fPostalCode")]
        public string NSMainAddressFPostalCode { get; set; }

        [JsonProperty("NS_MainAddress_fCityCode")]
        public string NSMainAddressFCityCode { get; set; }

        [JsonProperty("NS_MainAddress_fRegionGroupCode")]
        public string NSMainAddressFRegionGroupCode { get; set; }

        [JsonProperty("NS_MainAddress_fCountryCode")]
        public string NSMainAddressFCountryCode { get; set; }

        [JsonProperty("NS_MainAddress_Tel1")]
        public string NSMainAddressTel1 { get; set; }

        [JsonProperty("NS_MainAddress_Tel2")]
        public string NSMainAddressTel2 { get; set; }

        [JsonProperty("NS_MainAddress_Fax1")]
        public string NSMainAddressFax1 { get; set; }

        [JsonProperty("NS_MainAddress_Fax2")]
        public string NSMainAddressFax2 { get; set; }

        [JsonProperty("NS_MainAddress_ManagerName")]
        public string NSMainAddressManagerName { get; set; }

        [JsonProperty("NS_MainAddress_Area")]
        public string NSMainAddressArea { get; set; }

        [JsonProperty("NS_MainAddress_VATStatus")]
        public int NSMainAddressVATStatus { get; set; }
        public int DuplicateIBANChecked { get; set; }

        [JsonProperty("NS_MainAddress_fManagerNameGID")]
        public string NSMainAddressFManagerNameGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESGOPersonObjVATStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    public enum EntersoftWebApi2ODSModelsESGOPersonObjPersonKindType
    {
        LegalPerson,
        ActualPerson
    }

    public enum EntersoftWebApi2ODSModelsESGOPersonObjSexType
    {
        Unknown,
        Male,
        Female
    }

    public enum EntersoftWebApi2ODSModelsESGOPersonObjFamilyStatusType
    {
        Unmarried,
        Married,
        Divorced,
        Unknown
    }

    public enum EntersoftWebApi2ODSModelsESGOPersonObjPreferredWayOfContractType
    {
        UNKNOWN,
        EMAIL,
        FAX,
        PHONE,
        LETTER
    }

    public class EntersoftWebApi2ODSModelsES00DeviceObj
    {
        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGID { get; set; }

        [JsonProperty("fUserGID")]
        public string FUserGID { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGID { get; set; }

        [JsonProperty("fResourceGID")]
        public string FResourceGID { get; set; }
        public EntersoftWebApi2ODSModelsES00DeviceObjLogTypeType LogType { get; set; }
        public string LastKnownVersion { get; set; }
        public EntersoftWebApi2ODSModelsES00DeviceObjStateType State { get; set; }

        [JsonProperty("fCountryCode")]
        public string FCountryCode { get; set; }

        [JsonProperty("fMobileNetworkGID")]
        public string FMobileNetworkGID { get; set; }
        public string LastSyncDate { get; set; }
        public string LastUpLoadDate { get; set; }
        public string LastDownLoadDate { get; set; }
        public EntersoftWebApi2ODSModelsES00DeviceObjMobileApplicationType MobileApplication { get; set; }
        public string LastFailedDownloadDate { get; set; }
        public string LastFailedUploadDate { get; set; }
        public int CommPermissions { get; set; }
        public bool EnforceOnlineLogin { get; set; }
        public string MobilePhone { get; set; }
        public double LastLatitude { get; set; }
        public double LastLongitude { get; set; }
        public string LastLocationDate { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public EntersoftWebApi2ODSModelsES00DeviceObjOperatingSystemType OperatingSystem { get; set; }

        [JsonProperty("fColorCode")]
        public string FColorCode { get; set; }

        [JsonProperty("fCurrentBackupUserGID")]
        public string FCurrentBackupUserGID { get; set; }
        public string NotificationToken { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsES00DeviceObjLogTypeType
    {
        Full,
        Limited,
        Phantom
    }

    public enum EntersoftWebApi2ODSModelsES00DeviceObjStateType
    {
        Normal,
        Broken,
        Lost,
        Locked,
        Panic,
        Init
    }

    public enum EntersoftWebApi2ODSModelsES00DeviceObjMobileApplicationType
    {
        SalesForceAutomation,
        ServiceOnSite,
        ESMaster,
        Merchandising,
        MIS360,
        [EnumMember(Value = "xVan")]
        XVan,
        MIS360iPad,
        SalesAssistant,
        RequestForApproval,
        WMSMobile,
        MedRep,
        ESAnalyzer
    }

    public enum EntersoftWebApi2ODSModelsES00DeviceObjOperatingSystemType
    {
        WindowsMobile,
        WindowsPhone,
        [EnumMember(Value = "iOS")]
        IOS,
        Android,
        UWP
    }

    public class EntersoftWebApi2ODSModelsESGOWebUserObj
    {
        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }
        public string Password { get; set; }
        public EntersoftWebApi2ODSModelsESGOWebUserObjStatusType Status { get; set; }
        public string ActivationToken { get; set; }
        public string TokenExpirationDate { get; set; }
        public string FacebookAuthID { get; set; }
        public string TwitterAuthID { get; set; }
        public string WindowsLiveAuthID { get; set; }
        public string GoogleAuthID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESGOWebUserObjStatusType
    {
        PendingActivation,
        Active,
        Inactive
    }

    public class EntersoftWebApi2ODSModelsESGOUserObj
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string NTLoginName { get; set; }

        [JsonProperty("fProfileCode")]
        public string FProfileCode { get; set; }
        public string PasswdKey { get; set; }
        public int PasswdKeyExpirationDay { get; set; }
        public EntersoftWebApi2ODSModelsESGOUserObjSecurityLevelType SecurityLevel { get; set; }
        public bool IsReadOnly { get; set; }

        [JsonProperty("fLanguageCode")]
        public string FLanguageCode { get; set; }

        [JsonProperty("fPersonLinkGID")]
        public string FPersonLinkGID { get; set; }
        public bool Administrator { get; set; }

        [JsonProperty("fCompanySiteGID")]
        public string FCompanySiteGID { get; set; }
        public bool EnableKeyOnSave { get; set; }
        public string KeyOnSave { get; set; }

        [JsonProperty("fInteractionProfileCode")]
        public string FInteractionProfileCode { get; set; }
        public EntersoftWebApi2ODSModelsESGOUserObjUserTypeType UserType { get; set; }

        [JsonProperty("fB2BAdminGID")]
        public string FB2BAdminGID { get; set; }
        public string InternalPhone { get; set; }
        public bool ChgPwdFlag { get; set; }
        public string ChgPwdDate { get; set; }
        public bool FaultLogins { get; set; }
        public EntersoftWebApi2ODSModelsESGOUserObjValidAuthMethodsType ValidAuthMethods { get; set; }
        public string LDAPUserID { get; set; }
        public string LDAPUserName { get; set; }
        public EntersoftWebApi2ODSModelsESGOUserObjAllowAccessFromSourceType AllowAccessFromSource { get; set; }
        public string FiscalCode { get; set; }
        public EntersoftWebApi2ODSModelsESGOUserObjRequest2FAFromSourceType Request2FAFromSource { get; set; }
        public string AccessDBList { get; set; }

        [JsonProperty("nsPassword")]
        public string NsPassword { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESGOUserObjSecurityLevelType
    {
        IPRestricted,
        DelModTracing,
        WorkStationRestricted,
        AllowedToUpgrade,
        ForbidToRelogin,
        RestartServer,
        LoginAsService,
        ForbidEditShortcuts
    }

    public enum EntersoftWebApi2ODSModelsESGOUserObjUserTypeType
    {
        Normal,
        B2BAdmin,
        B2BUser
    }

    public enum EntersoftWebApi2ODSModelsESGOUserObjValidAuthMethodsType
    {
        BASIC,
        LDAP
    }

    public enum EntersoftWebApi2ODSModelsESGOUserObjAllowAccessFromSourceType
    {
        Desktop,
        WEBAPI,
        [EnumMember(Value = "eCommerce")]
        ECommerce,
        Service
    }

    public enum EntersoftWebApi2ODSModelsESGOUserObjRequest2FAFromSourceType
    {
        Desktop,
        WEBAPI,
        [EnumMember(Value = "eCommerce")]
        ECommerce,
        Service
    }

    public class EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse
    {
        public EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseBusinessEventTypeType BusinessEventType { get; set; }
        public string Context { get; set; }
        public double Value { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }
        public string ESSubscriptionID { get; set; }
        public string ESSubscriptionGID { get; set; }
        public string ESDatabaseID { get; set; }
        public string ESCompanyID { get; set; }
        public string ESApplicationID { get; set; }
        public string ExternalID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CallbackURL { get; set; }
        public EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }
        public string WebAPIToken { get; set; }
        public string RequestURI { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseBusinessEventTypeType
    {
        HighValueSalesOrder,
        HighValuePurchaseOrder,
        OrderReadyToShip,
        SaleOrderOnHold,
        OrderSaleCanceled,
        PartiallyCanceledOrder,
        SaleOrderDelete,
        HighValueCustomerCreditNote,
        NewDocumentOfType,
        NewCRMTaskOfType,
        CRMTaskExpired,
        HighValuePayment,
        HighValuePaymentWithCheck,
        HighValuePaymentTaxes,
        HighValueCollection,
        HighValueCollectionWithCheque,
        StockFallingBelowThreshold,
        RequestToApprove,
        RequestHasBeenApproved
    }

    public enum EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        RFA
    }

    public class EntersoftWebApiInfrastructureESPodHookRegistrationResponse
    {
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponseStateType State { get; set; }
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponsePackageTypeType PackageType { get; set; }
        public string ConveyanceLicencePlate { get; set; }
        public string BranchID { get; set; }
        public string TradeAccountName { get; set; }
        public string DriverCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }
        public string ESSubscriptionID { get; set; }
        public string ESSubscriptionGID { get; set; }
        public string ESDatabaseID { get; set; }
        public string ESCompanyID { get; set; }
        public string ESApplicationID { get; set; }
        public string ExternalID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CallbackURL { get; set; }
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }
        public string WebAPIToken { get; set; }
        public string RequestURI { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponseStateType
    {
        Initial,
        Arrived,
        Started,
        Delivered,
        Cancelled,
        All
    }

    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponsePackageTypeType
    {
        MasterPackage,
        Package,
        Pallet,
        Sorting,
        Transport,
        All
    }

    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        RFA
    }

    public class EntersoftWebApiInfrastructureESRFAHookRegistrationResponse
    {
        public string RequestedBy { get; set; }
        public EntersoftWebApiInfrastructureESRFAHookRegistrationResponsePriorityType Priority { get; set; }
        public string RequestClass { get; set; }
        public string RequestCategory { get; set; }
        public double NumericValue { get; set; }
        public string RecipientUser { get; set; }
        public string[] RecipientGroups { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }
        public string ESSubscriptionID { get; set; }
        public string ESSubscriptionGID { get; set; }
        public string ESDatabaseID { get; set; }
        public string ESCompanyID { get; set; }
        public string ESApplicationID { get; set; }
        public string ExternalID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CallbackURL { get; set; }
        public EntersoftWebApiInfrastructureESRFAHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }
        public string WebAPIToken { get; set; }
        public string RequestURI { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESRFAHookRegistrationResponsePriorityType
    {
        Low,
        Normal,
        High
    }

    public enum EntersoftWebApiInfrastructureESRFAHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        RFA
    }

    public class EntersoftWebApiInfrastructureESEntityHookRegistrationResponse
    {
        public EntersoftWebApiInfrastructureESEntityHookRegistrationResponseEntityTypeType EntityType { get; set; }
        public EntersoftWebApiInfrastructureESEntityHookRegistrationResponseEventTypeType EventType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }
        public string ESSubscriptionID { get; set; }
        public string ESSubscriptionGID { get; set; }
        public string ESDatabaseID { get; set; }
        public string ESCompanyID { get; set; }
        public string ESApplicationID { get; set; }
        public string ExternalID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CallbackURL { get; set; }
        public EntersoftWebApiInfrastructureESEntityHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }
        public string WebAPIToken { get; set; }
        public string RequestURI { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESEntityHookRegistrationResponseEntityTypeType
    {
        ES00Device,
        ES00List,
        ES00MobileParams,
        ES00PropertySet,
        ES00PropertySetCompact,
        ES00RuleSet,
        ES00RuleSetType,
        ES00SegmentationModel,
        ES00SegmentationTemplate,
        ES00SemanticsCustomization,
        ES00SSASParameters,
        ES00WordGroup,
        ES00ZProperty,
        ESBGAllocationProfile,
        ESBGBudgetDimensionAllocationProfile,
        ESBGBudgetSheet,
        ESBGBudgetSheetProfile,
        ESBGZBudgetCashAccountGroup,
        ESBGZBudgetItemGroup,
        ESBGZBudgetSalespersonGroup,
        ESBGZBudgetTradeAccountGroup,
        ESCOCostElementType,
        ESCOCostingFolder,
        ESCOLineCostAnalysis,
        ESFACommercialProfile,
        ESFADepreciationProfile,
        ESFAFixedAsset,
        ESFAItemControlPolicy,
        ESFARevaluationProfile,
        ESFIBankImport,
        ESFICardRateProfile,
        ESFICashAccount,
        ESFICDCommercialProfile,
        ESFICheckListProfile,
        ESFICommercialProfileItem,
        ESFICommissionProfile,
        ESFICondition,
        ESFIConditionTemplate,
        ESFICreditCardType,
        ESFICreditControlProfile,
        ESFICreditor,
        ESFICreditTurnOverProfile,
        ESFICreditTurnOverProfileEntry,
        ESFICustomer,
        ESFIDebtor,
        ESFIDeclarationEntry,
        ESFIDeclarationType,
        ESFIDistributionDispatch,
        ESFIDocSeriesAttributes,
        ESFIDocumentAccessRightProfile,
        ESFIDocumentAdjustment,
        ESFIDocumentCash,
        ESFIDocumentSeries,
        ESFIDocumentStock,
        ESFIDocumentTrade,
        ESFIDocumentTransition,
        ESFIDocumentUpdateProfile,
        ESFIDocumentUpdateProfileGL,
        ESFIEInvoiceProfile,
        ESFIFieldPropertiesProfile,
        ESFIFillerProfile,
        ESFIFinancialAgreement,
        ESFIFinancialDeclaration,
        ESFIInnerDistributionEntry,
        ESFIIntrastatEntry,
        ESFIInvoicePolicy,
        ESFIInvoicePolicyAction,
        ESFIItem,
        ESFIItemAllocationProfile,
        ESFIItemCategories,
        ESFIItemControlPolicy,
        ESFIItemExpense,
        ESFIItemExpenses,
        ESFIItemFamily,
        ESFIItemPriceHistoryTemplate,
        ESFIItemService,
        ESFIItemSubCategory,
        ESFIItemSubfamily,
        ESFIKEPYOEntry,
        ESFIMeasure,
        ESFIMobileDocumentType,
        ESFIMyDataInvoice,
        ESFINote,
        ESFIOIMatchingProfile,
        ESFIOpenItemsForDateProposalHeader,
        ESFIPaymentMethod,
        ESFIPricelist,
        ESFIPricelistEditor,
        ESFISalesPerson,
        ESFISpecialAccount,
        ESFISpecialAccountGroup,
        ESFISupplier,
        ESFISupplierExpert,
        ESFITCourier,
        ESFITradeAccount,
        ESFITradeAccountContract,
        ESFITradeAccountContractType,
        ESFITransitionProfile,
        ESFITransportPlan,
        ESFIVoucher,
        ESFIVoucherPromotionProfile,
        ESFIWHAccessList,
        ESFIZAccountPostingDef,
        ESFIZElectronicTransactionsProfile,
        ESFIZInterestProfile,
        ESFIZItemCategory,
        ESFIZItemFamily,
        ESFIZItemSubCategory,
        ESFIZItemSubFamily,
        ESFIZVATExemptionReasoning,
        ESGLAccount,
        ESGLAccountingDocumentTemplate,
        ESGLAccountingDocumentType,
        ESGLAllocationProfile,
        ESGLJournal,
        ESGLLedgerEntry,
        ESGlobalBlueDocument,
        ESGOAreaMap,
        ESGOColumnsSeq,
        ESGOCompany,
        ESGOCompanyBusinessActivityCodes,
        ESGOCurrency,
        ESGOCurrencyExchangeRate,
        ESGOLegalPerson,
        ESGOMetric,
        ESGOMetricActual,
        ESGOMetricSet,
        ESGOOrganizationalUnit,
        ESGOPerson,
        ESGOPhysicalPerson,
        ESGOPrinter,
        ESGOProject,
        ESGOReport,
        ESGOScale,
        ESGOScheduledJob,
        ESGOScript,
        ESGOSeasonCalendar,
        ESGOSegmentSequence,
        ESGOServiceProfile,
        ESGOShift,
        ESGOUser,
        ESGOVATCategoryMapping,
        ESGOWebUser,
        ESGOWorkingCalendar,
        ESGOWorkingCalendarException,
        ESGOWorkstation,
        ESGOZBusinessActivity,
        ESGOZBusinessUnit,
        ESGOZDimension1,
        ESGOZDimension2,
        ESGOZInteractionProfile,
        ESMLModel,
        ESMLModelGroup,
        ESMMBOM,
        ESMMCatalogueItem,
        ESMMCommercialProfile,
        ESMMDeposition,
        ESMMItemControlPolicy,
        ESMMItemSellingPrice,
        ESMMLot,
        ESMMMaterialRequirement,
        ESMMMaterialRequirementPlan,
        ESMMMaterialRequirementPlanWithReqs,
        ESMMPersonItem,
        ESMMPhaseRouting,
        ESMMProductionLeadTimes,
        ESMMProductionPlan,
        ESMMProductionPlanDemand,
        ESMMProductionPlanItem,
        ESMMProductionPlanWithDemands,
        ESMMSerialNumber,
        ESMMSIMURelation,
        ESMMSortiment,
        ESMMStockDimSet,
        ESMMStockDimSetMap,
        ESMMStockItem,
        ESMMStockOrderModel,
        ESMMStockOrderPlan,
        ESMMStockProposalComposition,
        ESMMStockProposalGroup,
        ESMMStorageLocation,
        ESMMStorageLocationPrinter,
        ESMMStorageLocationProfile,
        ESMMStorageLocationTree,
        ESMMValidStockDimensionsProfile,
        ESMMZBCProcessingType,
        ESMMZIntrastatCode,
        ESMMZMeasurementUnit,
        ESPlanetDocument,
        ESTMABCClassificationModel,
        ESTMCampaign,
        ESTMContractTerm,
        ESTMInteraction,
        ESTMMobileTaskType,
        ESTMNewsletterRecipient,
        ESTMObjectRating,
        ESTMOpportunity,
        ESTMResource,
        ESTMRFMModel,
        ESTMRFMResponseModel,
        ESTMServiceDefinition,
        ESTMServiceRequest,
        ESTMSMAccount,
        ESTMSMActivity,
        ESTMSMCompanyAccount,
        ESTMSMRawObject,
        ESTMStatusCollection,
        ESTMTask,
        ESTMTaskCategory,
        ESTMTaskLite,
        ESTMTaskType,
        ESTRPosition,
        ESTRTerritory,
        ESTRTerritoryBudget,
        ESTRTerritoryBudgetTemplate,
        ESTRTerritoryHierarchy,
        ESTRTerritoryRulePeriod,
        ESWMAction,
        ESWMActionType,
        ESWMActionTypeReport,
        ESWMCancellationDispositionReasonMap,
        ESWMCancellationReservationReasonMap,
        ESWMContainer,
        ESWMContainerControlPolicy,
        ESWMContainerType,
        ESWMDepositor,
        ESWMItemControlPolicy,
        ESWMPhaseZoneMapping,
        ESWMRequest,
        ESWMRequestStringFieldMap,
        ESWMRequestType,
        ESWMReservationReasonWHMap,
        ESWMShipment,
        ESWMStepOperation,
        ESWMTransportAction,
        ESWMTransportRequest,
        ESWMWorkPackage,
        ESWMWorkPackageType,
        ESWPActualTask,
        ESWPActualTaskEntry,
        ESWPTaskRequest,
        ESWPWorkPackage
    }

    public enum EntersoftWebApiInfrastructureESEntityHookRegistrationResponseEventTypeType
    {
        Create,
        Update,
        Delete,
        CreateOrUpdate
    }

    public enum EntersoftWebApiInfrastructureESEntityHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        RFA
    }

    public class EntersoftWebApiInfrastructureESSystemHookRegistrationResponse
    {
        public EntersoftWebApiInfrastructureESSystemHookRegistrationResponseSystemEventTypeTypeItem[] SystemEventType { get; set; }
        public string OtherEvent { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }
        public string ESSubscriptionID { get; set; }
        public string ESSubscriptionGID { get; set; }
        public string ESDatabaseID { get; set; }
        public string ESCompanyID { get; set; }
        public string ESApplicationID { get; set; }
        public string ExternalID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string CallbackURL { get; set; }
        public EntersoftWebApiInfrastructureESSystemHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }
        public string WebAPIToken { get; set; }
        public string RequestURI { get; set; }
    }

    public enum EntersoftWebApiInfrastructureESSystemHookRegistrationResponseSystemEventTypeTypeItem
    {
        RestartAppServer,
        UpgradeStart,
        UpgradeEnd,
        UpgradeErr,
        CustomVerChanged,
        ReCache,
        NoAvailableLicense,
        AppServerStart,
        AppServerStop,
        RFRequestAssistance,
        UserLockedOut,
        DBCheckStart,
        DBCheckEnd,
        DBCheckSErr,
        Other
    }

    public enum EntersoftWebApiInfrastructureESSystemHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        RFA
    }

    public class EntersoftWebApi2ODSModelsESMLModelObj
    {
        public EntersoftWebApi2ODSModelsESMLModelObjModelClassType ModelClass { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjRegressionType Regression { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjStatusType Status { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjSubSystemType SubSystem { get; set; }

        [JsonProperty("fRuleSetGID")]
        public string FRuleSetGID { get; set; }

        [JsonProperty("fForecastRuleSetGID")]
        public string FForecastRuleSetGID { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjAlgorithmType Algorithm { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjMeasureType Measure { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjAggregateType Aggregate { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTransactionGroupsType TransactionGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjCalendarGroupsType CalendarGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjCompanyGroupsType CompanyGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjBranchGroupsType BranchGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTradeAccountGroupsType TradeAccountGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjItemGroupsType ItemGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjCalendarFeaturesType CalendarFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjCompanyFeaturesType CompanyFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjBranchFeaturesType BranchFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTradeAccountFeaturesType TradeAccountFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjItemFeaturesType ItemFeatures { get; set; }
        public double TrainingPercentage { get; set; }
        public int LagWindowSize { get; set; }
        public int ForecastingFutureSteps { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjPersonGroupsType PersonGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjPersonFeaturesType PersonFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjSiteGroupsType SiteGroups { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjSiteFeaturesType SiteFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjOpportunityFeaturesType OpportunityFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTransactionKPIFeaturesType TransactionKPIFeatures { get; set; }

        [JsonProperty("fLabel1ScaleGID")]
        public string FLabel1ScaleGID { get; set; }

        [JsonProperty("fLabel2ScaleGID")]
        public string FLabel2ScaleGID { get; set; }

        [JsonProperty("fLabel3ScaleGID")]
        public string FLabel3ScaleGID { get; set; }
        public double FeatureImportancePercentage { get; set; }
        public string PositiveLabel1 { get; set; }
        public double ClassificationPercentage { get; set; }
        public bool BalanceClassWeights { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjBinningStrategyType BinningStrategy { get; set; }
        public int NumberOfBins { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjCompanyFeaturesGenerationType CompanyFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjBranchFeaturesGenerationType BranchFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjPersonFeaturesGenerationType PersonFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjPersonSiteFeaturesGenerationType PersonSiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjPersonPropertyFeaturesGenerationType PersonPropertyFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTradeAccountFeaturesGenerationType TradeAccountFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjTradeAccountSiteFeaturesGenerationType TradeAccountSiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjSiteFeaturesGenerationType SiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjOpportunityFeaturesGenerationType OpportunityFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjNumericFeaturesType NumericFeatures { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjItemFeaturesGenerationType ItemFeaturesGeneration { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjFeatureImportanceAlgorithmType FeatureImportanceAlgorithm { get; set; }
        public double RareFeatureValueThreshold { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjHyperParamOptType HyperParamOpt { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjBinningNumStrategyType BinningNumStrategy { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjFeatureCorrelationNumAlgortithmType FeatureCorrelationNumAlgortithm { get; set; }
        public EntersoftWebApi2ODSModelsESMLModelObjFeatureCorrelationCatAlgortithmType FeatureCorrelationCatAlgortithm { get; set; }
        public double FeatureCorrelationDropThreshold { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjModelClassType
    {
        NotSpecified,
        Regression,
        BinaryClassification,
        Classification,
        Clustering,
        Recommendation
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjRegressionType
    {
        NotSpecified,
        TimeSeries,
        Casual
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjStatusType
    {
        Initial,
        DataLoaded,
        Trained,
        Published,
        Training
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjSubSystemType
    {
        NotSpecified,
        Sales,
        Purchases,
        LeadLikelihoodToWin,
        OpportunityLikelihoodToWin,
        ProspectLikelihoodToBuy,
        CustomerLikelihoodToBuy,
        RequirementOpenItemLikelihoodToClose,
        ItemLikelihoodToDeliver
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjAlgorithmType
    {
        NotSpecified,
        [EnumMember(Value = "B_Persistence")]
        BPersistence,
        [EnumMember(Value = "S_SES")]
        SSES,
        [EnumMember(Value = "S_HWES")]
        SHWES,
        [EnumMember(Value = "S_ARIMA")]
        SARIMA,
        [EnumMember(Value = "ML_LINREG")]
        MLLINREG,
        [EnumMember(Value = "ML_RF")]
        MLRF,
        [EnumMember(Value = "ML_SVR")]
        MLSVR,
        [EnumMember(Value = "ML_Prophet")]
        MLProphet,
        [EnumMember(Value = "NN_LSTM")]
        NNLSTM,
        [EnumMember(Value = "ML_SVM")]
        MLSVM,
        [EnumMember(Value = "ML_LOGREGSGD")]
        MLLOGREGSGD,
        [EnumMember(Value = "ML_XGBOOST")]
        MLXGBOOST,
        [EnumMember(Value = "ML_LIGHTGBM")]
        MLLIGHTGBM,
        [EnumMember(Value = "ML_CATBOOST")]
        MLCATBOOST
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjMeasureType
    {
        NotSpecified,
        Turnover,
        Quantity,
        Transactions
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjAggregateType
    {
        NotSpecified,
        Sum,
        Min,
        Max,
        Avg,
        Count
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTransactionGroupsType
    {
        Date,
        TransactionID
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjCalendarGroupsType
    {
        Year,
        Semester,
        Quarter,
        Month,
        Week,
        DayOfYear,
        Day15,
        Day10,
        DayOfMonth,
        DayOfWeek,
        WorkingDay
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjCompanyGroupsType
    {
        Company,
        Project,
        Activity,
        BusinessUnit,
        Dimension1,
        Dimension2
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjBranchGroupsType
    {
        Branch,
        Country,
        District,
        City,
        Region,
        Area
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTradeAccountGroupsType
    {
        TradeAccount,
        Group,
        Category,
        Family,
        Sex,
        Age,
        Country,
        District,
        City,
        Region,
        Area,
        Kind,
        Industry,
        Marital,
        Education
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjItemGroupsType
    {
        Item,
        Family,
        Group,
        Category,
        SubCategory
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjCalendarFeaturesType
    {
        Year,
        Semester,
        Quarter,
        Month,
        Week,
        DayOfYear,
        Day15,
        Day10,
        DayOfMonth,
        DayOfWeek,
        WorkingDay
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjCompanyFeaturesType
    {
        Company,
        Project,
        Activity,
        BusinessUnit,
        Dimension1,
        Dimension2
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjBranchFeaturesType
    {
        Branch,
        Country,
        District,
        City,
        Region,
        Area
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTradeAccountFeaturesType
    {
        TradeAccount,
        Group,
        Category,
        Family,
        Sex,
        Age,
        Country,
        District,
        City,
        Region,
        Area,
        Kind,
        Industry,
        Marital,
        Education
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjItemFeaturesType
    {
        Item,
        Family,
        Group,
        Category,
        SubCategory
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjPersonGroupsType
    {
        Person,
        Group,
        Category,
        Sex,
        Age,
        Country,
        District,
        City,
        Region,
        Area,
        Kind,
        Industry,
        Marital,
        Education,
        Property1,
        Property2,
        Property3,
        Property4,
        Property5,
        Property6,
        Property7,
        Property8,
        Property9,
        Property10
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjPersonFeaturesType
    {
        Person,
        Group,
        Category,
        Sex,
        Age,
        Country,
        District,
        City,
        Region,
        Area,
        Kind,
        Industry,
        Marital,
        Education,
        Property1,
        Property2,
        Property3,
        Property4,
        Property5,
        Property6,
        Property7,
        Property8,
        Property9,
        Property10
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjSiteGroupsType
    {
        Site,
        Country,
        District,
        City,
        Region,
        Area
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjSiteFeaturesType
    {
        Site,
        Country,
        District,
        City,
        Region,
        Area
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjOpportunityFeaturesType
    {
        Lead,
        LeadSource,
        Revenue,
        Resource,
        SalesPhase,
        Competitor
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTransactionKPIFeaturesType
    {
        Turnover,
        Amount,
        Transactions,
        NumberOfItems,
        NumberOfItemHierarchyCategories
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjBinningStrategyType
    {
        NoBinning,
        EqualWidth,
        EqualFrequency,
        KMeans,
        DecisionTree
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjCompanyFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjBranchFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjPersonFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjPersonSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjPersonPropertyFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTradeAccountFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjTradeAccountSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjOpportunityFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjNumericFeaturesType
    {
        Numeric1,
        Numeric2,
        Numeric3,
        Numeric4,
        Numeric5,
        Numeric6,
        Numeric7,
        Numeric8,
        Numeric9,
        Numeric10,
        Numeric11,
        Numeric12,
        Numeric13,
        Numeric14,
        Numeric15,
        Numeric16,
        Numeric17,
        Numeric18,
        Numeric19,
        Numeric20,
        Numeric21,
        Numeric22,
        Numeric23,
        Numeric24,
        Numeric25
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjItemFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjFeatureImportanceAlgorithmType
    {
        RandomForest,
        PearsonCorrCoef,
        PearsonChiSquareCoef,
        RecursiveFeatureElimination
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjHyperParamOptType
    {
        Default,
        GridSearch,
        RandomSearch,
        Bayesian
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjBinningNumStrategyType
    {
        None,
        Dougherty,
        Silhouette,
        BayesianBlocks
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjFeatureCorrelationNumAlgortithmType
    {
        PearsonCorrCoef,
        Spearman
    }

    public enum EntersoftWebApi2ODSModelsESMLModelObjFeatureCorrelationCatAlgortithmType
    {
        CramersV
    }

    public class EntersoftWebApi2ODSModelsESMMSerialNumberObj
    {
        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }
        public string SerialNumberCode { get; set; }
        public string TechnicalDescription { get; set; }

        [JsonProperty("fStateCode")]
        public string FStateCode { get; set; }

        [JsonProperty("fOriginCode")]
        public string FOriginCode { get; set; }

        [JsonProperty("fTypeCode")]
        public string FTypeCode { get; set; }
        public bool Available { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public double Qty3 { get; set; }
        public double Qty4 { get; set; }
        public EntersoftWebApi2ODSModelsESMMSerialNumberObjPositionTypeType PositionType { get; set; }

        [JsonProperty("fPositionGID")]
        public string FPositionGID { get; set; }
        public string PositionName { get; set; }

        [JsonProperty("fPositionSiteGID")]
        public string FPositionSiteGID { get; set; }
        public string PositionSiteName { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fLotGID")]
        public string FLotGID { get; set; }

        [JsonProperty("fColorCode")]
        public string FColorCode { get; set; }

        [JsonProperty("fSizeCode")]
        public string FSizeCode { get; set; }

        [JsonProperty("fStockDim1Code")]
        public string FStockDim1Code { get; set; }

        [JsonProperty("fStockDim2Code")]
        public string FStockDim2Code { get; set; }
        public double Quantity { get; set; }
        public double QtyVariable1 { get; set; }
        public double QtyVariable2 { get; set; }
        public double QtyVariable3 { get; set; }
        public double QtyVariable4 { get; set; }
        public double QtyBaseMU { get; set; }
        public double QtyAlternateMU { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }

        [JsonProperty("fItemMUGID")]
        public string FItemMUGID { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }

        [JsonProperty("fTableField1")]
        public string FTableField1 { get; set; }

        [JsonProperty("fTableField2")]
        public string FTableField2 { get; set; }

        [JsonProperty("fTableField3")]
        public string FTableField3 { get; set; }

        [JsonProperty("fTableField4")]
        public string FTableField4 { get; set; }

        [JsonProperty("fTableField5")]
        public string FTableField5 { get; set; }

        [JsonProperty("fTableField6")]
        public string FTableField6 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public double NumericField11 { get; set; }
        public double NumericField12 { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public string BarCode { get; set; }
        public string WarrantyStart { get; set; }
        public string WarrantyEnd { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }
        public string PhysicalLocation { get; set; }

        [JsonProperty("fRootSerialNumberGID")]
        public string FRootSerialNumberGID { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGID { get; set; }

        [JsonProperty("fContainerGID")]
        public string FContainerGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGID { get; set; }

        [JsonProperty("fPackageGID")]
        public string FPackageGID { get; set; }

        [JsonProperty("fMasterPackageGID")]
        public string FMasterPackageGID { get; set; }

        [JsonProperty("fPalletGID")]
        public string FPalletGID { get; set; }

        [JsonProperty("fTransportGID")]
        public string FTransportGID { get; set; }

        [JsonProperty("fSortingGID")]
        public string FSortingGID { get; set; }
        public bool LocationInWH { get; set; }

        [JsonProperty("vPositionName")]
        public string VPositionName { get; set; }

        [JsonProperty("vPositionSiteName")]
        public string VPositionSiteName { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMSerialNumberObjPositionTypeType
    {
        TradeAccount,
        CompanySite,
        Person,
        OneTime,
        SerialNumber,
        ThirdWH
    }

    public class EntersoftWebApi2ODSModelsESMMCatalogueItemObj
    {
        public double SalesPrice { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fTableField1")]
        public string FTableField1 { get; set; }

        [JsonProperty("fTableField2")]
        public string FTableField2 { get; set; }

        [JsonProperty("fTableField3")]
        public string FTableField3 { get; set; }

        [JsonProperty("fTableField4")]
        public string FTableField4 { get; set; }

        [JsonProperty("fTableField5")]
        public string FTableField5 { get; set; }

        [JsonProperty("fTableField6")]
        public string FTableField6 { get; set; }

        [JsonProperty("fTableField7")]
        public string FTableField7 { get; set; }

        [JsonProperty("fTableField8")]
        public string FTableField8 { get; set; }

        [JsonProperty("fTableField9")]
        public string FTableField9 { get; set; }

        [JsonProperty("fTableField10")]
        public string FTableField10 { get; set; }

        [JsonProperty("fGeneralCatalogueItemGID")]
        public string FGeneralCatalogueItemGID { get; set; }
        public double SalesRetailPrice { get; set; }
        public bool SalesRetailPriceIncludedVAT { get; set; }
        public double PurchasesPrice { get; set; }
        public bool PurchasesPriceIncludedVAT { get; set; }

        [JsonProperty("fCatalogueItemGroupCode")]
        public string FCatalogueItemGroupCode { get; set; }
        public bool SalesPriceIncludedVAT { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double CurrencySalesPrice { get; set; }
        public double CurrencySalesRetailPrice { get; set; }
        public double CurrencyPurchasesPrice { get; set; }
        public bool CurrencySalesPriceIncludedVAT { get; set; }
        public bool CurrencySalesRetailPriceIncludedVAT { get; set; }
        public bool CurrencyPurchasesPriceIncludedVAT { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }

        [JsonProperty("fRelatedPerson1GID")]
        public string FRelatedPerson1GID { get; set; }

        [JsonProperty("fRelatedPerson2GID")]
        public string FRelatedPerson2GID { get; set; }

        [JsonProperty("fRelatedPerson3GID")]
        public string FRelatedPerson3GID { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGID { get; set; }
        public bool WEB { get; set; }
        public string Notes { get; set; }
        public EntersoftWebApi2ODSModelsESMMCatalogueItemObjNotesTextTypeType NotesTextType { get; set; }
        public string SEOURL { get; set; }
        public string SEOURLEN { get; set; }
        public string SEOTitle { get; set; }
        public string SEOTitleEN { get; set; }
        public string SEODescription { get; set; }
        public string SEODescriptionEN { get; set; }
        public string SEOKeywords { get; set; }
        public string SEOKeywordsEN { get; set; }
        public EntersoftWebApi2ODSModelsESMMCatalogueItemObjProductTypeType ProductType { get; set; }

        [JsonProperty("fCompetitorCategoryValueGID")]
        public string FCompetitorCategoryValueGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMCatalogueItemObjNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public enum EntersoftWebApi2ODSModelsESMMCatalogueItemObjProductTypeType
    {
        CompanyProduct,
        CompetitorProduct,
        CompanyAndCompetitorProduct
    }

    public class EntersoftWebApi2ODSModelsESMMStorageLocationObj
    {
        [JsonProperty("fParentLocationGID")]
        public string FParentLocationGID { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fStorageSystemCode")]
        public string FStorageSystemCode { get; set; }

        [JsonProperty("fBuildingCode")]
        public string FBuildingCode { get; set; }

        [JsonProperty("fStorageAreaCode")]
        public string FStorageAreaCode { get; set; }

        [JsonProperty("fSectorCode")]
        public string FSectorCode { get; set; }
        public bool Locked { get; set; }

        [JsonProperty("fLocationLockReasonCode")]
        public string FLocationLockReasonCode { get; set; }
        public int LocColumn { get; set; }
        public int LocLevel { get; set; }
        public int LocSubColumn { get; set; }
        public int LocSubLevel { get; set; }
        public int LocDepth { get; set; }

        [JsonProperty("fStorageLocationProfileGID")]
        public string FStorageLocationProfileGID { get; set; }
        public bool IsTransit { get; set; }

        [JsonProperty("fAisleCode")]
        public string FAisleCode { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public string LocColumnCode { get; set; }
        public string LocLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESMMStorageLocationObjAisleSideTypeType AisleSideType { get; set; }
        public string BarCode { get; set; }
        public bool IsBeam { get; set; }

        [JsonProperty("fSortingGID")]
        public string FSortingGID { get; set; }

        [JsonProperty("fLockReasonContextGID")]
        public string FLockReasonContextGID { get; set; }
        public bool PhisicalDimensionsMonitoring { get; set; }
        public int Number { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMStorageLocationObjAisleSideTypeType
    {
        Unknown,
        Left,
        Right
    }

    public class EntersoftWebApi2ODSModelsESMMStockItemObj
    {
        public string DetailDescription { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FSITaxCode { get; set; }
        public string InternationalCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }
        public string AlternativeCode { get; set; }
        public string BarCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjItemTypeType ItemType { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGID { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGID { get; set; }
        public string Manufacturer { get; set; }

        [JsonProperty("fCountryOriginCode")]
        public string FCountryOriginCode { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }
        public double MarkupOnPrice { get; set; }
        public double MarkupOnRetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMUGID { get; set; }

        [JsonProperty("fAltMUGID")]
        public string FAltMUGID { get; set; }

        [JsonProperty("fWeightMUGID")]
        public string FWeightMUGID { get; set; }

        [JsonProperty("fVolumeMUGID")]
        public string FVolumeMUGID { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }
        public double MinProfitMargin { get; set; }
        public double MinSalesOrderQty { get; set; }
        public double UsualPurchaseOrderQty { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBOMGID { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGID { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGID { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGID { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGID { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }

        [JsonProperty("fCatalogueItemGID")]
        public string FCatalogueItemGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public bool Flag11 { get; set; }
        public bool Flag12 { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCostElementTypeGID")]
        public string FCostElementTypeGID { get; set; }
        public bool MainCode { get; set; }

        [JsonProperty("fMainAssetGID")]
        public string FMainAssetGID { get; set; }

        [JsonProperty("fBudgetItemGroupCode")]
        public string FBudgetItemGroupCode { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public double Price3 { get; set; }
        public bool Price1IncludedVAT { get; set; }
        public bool Price2IncludedVAT { get; set; }
        public bool Price3IncludedVAT { get; set; }
        public string StorageLocationCodes { get; set; }

        [JsonProperty("fSeasonCode")]
        public string FSeasonCode { get; set; }
        public int VATCalculationValue { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGID { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public bool WEB { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGID { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGID { get; set; }
        public int ValuationMethodAnalysis { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGID { get; set; }
        public bool ValuationPerPeriod { get; set; }
        public string DocumentMessage { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjServiceMUTypeType ServiceMUType { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGID { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGID { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGID { get; set; }
        public double MarkupOnPrice1 { get; set; }
        public double MarkupOnPrice2 { get; set; }
        public double MarkupOnPrice3 { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fItemControlPolicyGID")]
        public string FItemControlPolicyGID { get; set; }
        public EntersoftWebApi2ODSModelsESMMStockItemObjLotCharacteristicsMgmtType LotCharacteristicsMgmt { get; set; }

        [JsonProperty("fValidStockDimensionsProfileGID")]
        public string FValidStockDimensionsProfileGID { get; set; }

        [JsonProperty("fBCSNValidationTypeCode")]
        public string FBCSNValidationTypeCode { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMUGID { get; set; }

        [JsonProperty("fLockReasonCode")]
        public string FLockReasonCode { get; set; }
        public bool Locked { get; set; }

        [JsonProperty("fLockReasonContextGID")]
        public string FLockReasonContextGID { get; set; }

        [JsonProperty("fMUServiceCode")]
        public string FMUServiceCode { get; set; }

        [JsonProperty("fMUMainCode")]
        public string FMUMainCode { get; set; }

        [JsonProperty("fMUAltCode")]
        public string FMUAltCode { get; set; }

        [JsonProperty("fMUWeightCode")]
        public string FMUWeightCode { get; set; }

        [JsonProperty("fMUVolumeCode")]
        public string FMUVolumeCode { get; set; }
        public string MainSupplier { get; set; }

        [JsonProperty("fMUReportingCode")]
        public string FMUReportingCode { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fCreateLikeItemGID")]
        public string FCreateLikeItemGID { get; set; }

        [JsonProperty("NS_MainSupplierDescription_Col")]
        public string NSMainSupplierDescriptionCol { get; set; }

        [JsonProperty("NS_MainMUDescription_Col")]
        public string NSMainMUDescriptionCol { get; set; }

        [JsonProperty("NS_MainSupplierItemCode_Col")]
        public string NSMainSupplierItemCodeCol { get; set; }

        [JsonProperty("NS_MainSupplierCurrency_Col")]
        public string NSMainSupplierCurrencyCol { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public string SetDate { get; set; }
        public int CurrencyExchangePriceType { get; set; }
        public double CurrencyRate { get; set; }

        [JsonProperty("NS_MainSupplierPrice_Col")]
        public double NSMainSupplierPriceCol { get; set; }

        [JsonProperty("NS_MainSupplierMUCode_Col")]
        public string NSMainSupplierMUCodeCol { get; set; }

        [JsonProperty("NS_MainSupplierBasePrice_Col")]
        public double NSMainSupplierBasePriceCol { get; set; }

        [JsonProperty("NS_MainSupplierDeliveryDays_Col")]
        public string NSMainSupplierDeliveryDaysCol { get; set; }

        [JsonProperty("NS_MainSupplierComment_Col")]
        public string NSMainSupplierCommentCol { get; set; }

        [JsonProperty("NS_MainSupplierOfferPrice_Col")]
        public double NSMainSupplierOfferPriceCol { get; set; }

        [JsonProperty("NS_MainSupplierPurchaseNetPrice_Col")]
        public double NSMainSupplierPurchaseNetPriceCol { get; set; }

        [JsonProperty("NS_MainSupplierCurrencyPurchaseNetPrice_Col")]
        public double NSMainSupplierCurrencyPurchaseNetPriceCol { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjItemTypeType
    {
        Good,
        Product,
        FeedStock,
        SparePart,
        Consumable,
        Packing,
        Sponsion,
        Other,
        HalfReady,
        FeedStockB,
        BudgetRevenues,
        BudgetExpenses,
        PackingMaterial
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjServiceMUTypeType
    {
        BaseMU,
        AltMU
    }

    public enum EntersoftWebApi2ODSModelsESMMStockItemObjLotCharacteristicsMgmtType
    {
        ExpirationDate,
        ProductionDate,
        [EnumMember(Value = "fTableField1Code")]
        FTableField1Code,
        [EnumMember(Value = "fTableField2Code")]
        FTableField2Code,
        [EnumMember(Value = "fTableField3Code")]
        FTableField3Code,
        [EnumMember(Value = "fTableField4Code")]
        FTableField4Code,
        [EnumMember(Value = "fTableField5Code")]
        FTableField5Code,
        [EnumMember(Value = "fTableField6Code")]
        FTableField6Code,
        StringField1,
        StringField2,
        StringField3,
        StringField4,
        StringField5,
        StringField6,
        NumericField1,
        NumericField2,
        NumericField3,
        NumericField4,
        NumericField5,
        NumericField6,
        NumericField7,
        NumericField8,
        NumericField9,
        NumericField10,
        NumericField11,
        NumericField12,
        LotCode,
        LimitOrderDate
    }

    public class EntersoftWebApi2ODSModelsESMMCommercialProfileObj
    {
        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FVATCategoryCode { get; set; }
        public double MarkupOnPrice { get; set; }
        public double MarkupOnRetailPrice { get; set; }
        public bool PriceIncludedVAT { get; set; }
        public bool RetailPriceIncludedVAT { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGID { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGID { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGID { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }
        public double MinProfitMargin { get; set; }
        public double MinSalesOrderQty { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjIncludedTaxReportsType IncludedTaxReports { get; set; }

        [JsonProperty("fMainMUCode")]
        public string FMainMUCode { get; set; }

        [JsonProperty("fAltMUCode")]
        public string FAltMUCode { get; set; }

        [JsonProperty("fWeightMUCode")]
        public string FWeightMUCode { get; set; }

        [JsonProperty("fVolumeMUCode")]
        public string FVolumeMUCode { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjValuationMethodType ValuationMethod { get; set; }
        public string GLAccountCode { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGID { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGID { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGID { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGID { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FGLSegCode { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjItemTypeType ItemType { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjAssetTypeType AssetType { get; set; }

        [JsonProperty("fDepreciatedGLSegCode")]
        public string FDepreciatedGLSegCode { get; set; }

        [JsonProperty("fAssetGLSegCode")]
        public string FAssetGLSegCode { get; set; }

        [JsonProperty("fDepreciationGLSegCode")]
        public string FDepreciationGLSegCode { get; set; }

        [JsonProperty("fDepreciationProfileGID")]
        public string FDepreciationProfileGID { get; set; }

        [JsonProperty("fAlternativeDepreciationProfileGID")]
        public string FAlternativeDepreciationProfileGID { get; set; }

        [JsonProperty("fInformativeDepreciationProfileGID")]
        public string FInformativeDepreciationProfileGID { get; set; }
        public EntersoftWebApi2ODSModelsESMMCommercialProfileObjLotCharacteristicsMgmtType LotCharacteristicsMgmt { get; set; }

        [JsonProperty("fItemControlPolicyGID")]
        public string FItemControlPolicyGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjValuationMethodType
    {
        Average,
        LastPrice,
        FloatingAverage,
        FiFo,
        LiFo,
        SellOut,
        StandardCost,
        None
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjItemTypeType
    {
        Good,
        Product,
        FeedStock,
        SparePart,
        Consumable,
        Packing,
        Sponsion,
        Other,
        HalfReady,
        FeedStockB,
        BudgetRevenues,
        BudgetExpenses,
        PackingMaterial
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjAssetTypeType
    {
        Land,
        Building,
        Machine,
        Automobile,
        Furniture,
        SelfProducted,
        Intangible,
        Bonds,
        Other
    }

    public enum EntersoftWebApi2ODSModelsESMMCommercialProfileObjLotCharacteristicsMgmtType
    {
        ExpirationDate,
        ProductionDate,
        [EnumMember(Value = "fTableField1Code")]
        FTableField1Code,
        [EnumMember(Value = "fTableField2Code")]
        FTableField2Code,
        [EnumMember(Value = "fTableField3Code")]
        FTableField3Code,
        [EnumMember(Value = "fTableField4Code")]
        FTableField4Code,
        [EnumMember(Value = "fTableField5Code")]
        FTableField5Code,
        [EnumMember(Value = "fTableField6Code")]
        FTableField6Code,
        StringField1,
        StringField2,
        StringField3,
        StringField4,
        StringField5,
        StringField6,
        NumericField1,
        NumericField2,
        NumericField3,
        NumericField4,
        NumericField5,
        NumericField6,
        NumericField7,
        NumericField8,
        NumericField9,
        NumericField10,
        NumericField11,
        NumericField12,
        LotCode,
        LimitOrderDate
    }

    public class EntersoftWebApi2ODSModelsESMMSortimentObj
    {
        [JsonProperty("fColorSetGID")]
        public string FColorSetGID { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGID { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGID { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGID { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESMMLotObj
    {
        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }
        public string ExpirationDate { get; set; }
        public string ProductionDate { get; set; }
        public string DeliveryDate { get; set; }
        public string LimitOrderDate { get; set; }

        [JsonProperty("fLotQualifierCode")]
        public string FLotQualifierCode { get; set; }

        [JsonProperty("fItemMUGID")]
        public string FItemMUGID { get; set; }

        [JsonProperty("fColorCode")]
        public string FColorCode { get; set; }

        [JsonProperty("fSizeCode")]
        public string FSizeCode { get; set; }

        [JsonProperty("fStockDim1")]
        public string FStockDim1 { get; set; }

        [JsonProperty("fStockDim2")]
        public string FStockDim2 { get; set; }

        [JsonProperty("fTablefield1")]
        public string FTablefield1 { get; set; }

        [JsonProperty("fTablefield2")]
        public string FTablefield2 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public string Comment { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public double NumericField11 { get; set; }
        public double NumericField12 { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }

        [JsonProperty("fTablefield3")]
        public string FTablefield3 { get; set; }

        [JsonProperty("fTablefield4")]
        public string FTablefield4 { get; set; }

        [JsonProperty("fTablefield5")]
        public string FTablefield5 { get; set; }

        [JsonProperty("fTablefield6")]
        public string FTablefield6 { get; set; }
        public string AlternativeCode { get; set; }
        public string BarCode { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGID { get; set; }
        public string DepositionLine { get; set; }
        public string CustomsRegime { get; set; }
        public string StockBookID { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public string Certificate { get; set; }
        public string MUOfficialCode { get; set; }
        public double GrossWeight { get; set; }

        [JsonProperty("fCountryCode")]
        public string FCountryCode { get; set; }
        public string PreviousControlDate { get; set; }
        public string LastControlDate { get; set; }

        [JsonProperty("fDepositionDocumentLineItemAnalysisGID")]
        public string FDepositionDocumentLineItemAnalysisGID { get; set; }
        public string EndofMaintenanceLimit { get; set; }
        public string DepositionDocumentReferenceNumber { get; set; }

        [JsonProperty("NS_DepositionDocument_TarePerPack")]
        public double NSDepositionDocumentTarePerPack { get; set; }

        [JsonProperty("NS_DepositionDocument_MidweightBasedOnNetWeight")]
        public double NSDepositionDocumentMidweightBasedOnNetWeight { get; set; }

        [JsonProperty("NS_DepositionDocument_MidweightBasedOnGrossWeight")]
        public double NSDepositionDocumentMidweightBasedOnGrossWeight { get; set; }

        [JsonProperty("NS_DepositionDocument_VolumePerPack")]
        public double NSDepositionDocumentVolumePerPack { get; set; }

        [JsonProperty("NS_DepositionDocument_NetCurrencyValue")]
        public double NSDepositionDocumentNetCurrencyValue { get; set; }

        [JsonProperty("NS_DepositionDocument_NetCurrencyValuePerPack")]
        public double NSDepositionDocumentNetCurrencyValuePerPack { get; set; }

        [JsonProperty("NS_SupplementaryMUCode")]
        public string NSSupplementaryMUCode { get; set; }

        [JsonProperty("NS_Qty_SupplementaryMU")]
        public double NSQtySupplementaryMU { get; set; }

        [JsonProperty("NS_ExciseDutyMUCode")]
        public string NSExciseDutyMUCode { get; set; }

        [JsonProperty("NS_Qty_ExciseDutyMU")]
        public double NSQtyExciseDutyMU { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESMMProductionPlanObj
    {
        public EntersoftWebApi2ODSModelsESMMProductionPlanObjStatusType Status { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        [JsonProperty("fProductionUnitGID")]
        public string FProductionUnitGID { get; set; }
        public string DemandForecastFilter { get; set; }
        public string DemandForecastFilterParams { get; set; }
        public string InOrderFilter { get; set; }
        public string InOrderFilterParams { get; set; }
        public string StockingFilter { get; set; }
        public string StockingFilterParams { get; set; }
        public string OnHandFilter { get; set; }
        public string OnHandFilterParams { get; set; }
        public string DemandsCreationUser { get; set; }
        public string DemandsCreationDate { get; set; }
        public string ItemsCreationUser { get; set; }
        public string ItemsCreationDate { get; set; }
        public bool HalfReadyProductsAutoManagement { get; set; }
        public EntersoftWebApi2ODSModelsESMMProductionPlanObjDatesCalculationBasedOnType DatesCalculationBasedOn { get; set; }
        public bool EnableBatchQuantity { get; set; }
        public bool EnableMinQuantity { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESMMProductionPlanObjStatusType
    {
        Initial,
        DemandSelection,
        ProductionSchedule,
        CostEstimation,
        ProductionOrders,
        CostEstimationAndProductionOrders,
        Cancelled
    }

    public enum EntersoftWebApi2ODSModelsESMMProductionPlanObjDatesCalculationBasedOnType
    {
        ResourceDateAnalysis,
        ResourceWorkingCalendar
    }

    public class EntersoftWebApiModelsESPropertySet
    {
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public string ESDCreated { get; set; }
        public string ESUCreated { get; set; }
        public string ESDModified { get; set; }
        public string ESUModified { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("Category_Code")]
        public string CategoryCode { get; set; }

        [JsonProperty("Category_Description")]
        public string CategoryDescription { get; set; }

        [JsonProperty("Category_AlternativeDescription")]
        public string CategoryAlternativeDescription { get; set; }
        public int Type { get; set; }
        public bool MobileSurvey { get; set; }
        public EntersoftWebApiModelsESPropertySetLine[] Lines { get; set; }
        public EntersoftWebApiModelsESPropertyChoice[] Choices { get; set; }
        public EntersoftWebApiModelsESPropertyCategory[] Sections { get; set; }
        public EntersoftWebApiModelsESSurveyCampaign Campaign { get; set; }
    }

    public class EntersoftWebApiModelsESPropertySetLine
    {
        public string GID { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }
        public int SeqNum { get; set; }

        [JsonProperty("Category_Code")]
        public string CategoryCode { get; set; }

        [JsonProperty("Category_Description")]
        public string CategoryDescription { get; set; }

        [JsonProperty("Category_AlternativeDescription")]
        public string CategoryAlternativeDescription { get; set; }

        [JsonProperty("Category_OrderPriority")]
        public int CategoryOrderPriority { get; set; }
        public string ESDModified { get; set; }
        public string ESUModified { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public JToken DefaultValue { get; set; }
        public string DefaultDisplayValue { get; set; }
        public bool Mandatory { get; set; }
        public int VisualizationStyle { get; set; }
        public bool Inactive { get; set; }
        public bool PhotoRelated { get; set; }
        public bool NotApplicable { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public string PArg { get; set; }
        public int PType { get; set; }
    }

    public class EntersoftWebApiModelsESPropertyChoice
    {
        public string ChoiceCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public JToken Value { get; set; }
        public string AlternativeDescription { get; set; }
        public int OrderPriority { get; set; }
    }

    public class EntersoftWebApiModelsESPropertyCategory
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }
        public int OrderPriority { get; set; }
    }

    public class EntersoftWebApiModelsESSurveyCampaign
    {
        public string GID { get; set; }
        public string Description { get; set; }
        public string TaskNotes { get; set; }
    }

    public class EntersoftWebApiModelsESScale
    {
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public string InternationalID { get; set; }
        public bool Inactive { get; set; }
        public bool ESSystem { get; set; }
        public EntersoftWebApiModelsESScaleRange[] Ranges { get; set; }
    }

    public class EntersoftWebApiModelsESScaleRange
    {
        public string GID { get; set; }

        [JsonProperty("fScaleGID")]
        public string FScaleGID { get; set; }
        public int SeqNum { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public int ImageIndex { get; set; }
        public int ColorARGB { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayout
    {
        public EntersoftWebApiModelsESPQLayoutFilter[] Filter { get; set; }
        public EntersoftWebApiModelsESPQLayoutParam[] Param { get; set; }
        public EntersoftWebApiModelsESPQLayoutDefaultValue[] DefaultValue { get; set; }
        public EntersoftWebApiModelsESPQLayoutEnumItem[] EnumItem { get; set; }
        public EntersoftWebApiModelsESPQLayoutColumn[] LayoutColumn { get; set; }
        public JToken[] FormatingCondition { get; set; }
        public JToken[] FormatStyle { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayoutFilter
    {
        public string ID { get; set; }
        public string Caption { get; set; }
        public string QueryID { get; set; }
        public string RootTable { get; set; }
        public string SelectedMasterTable { get; set; }
        public string SelectedMasterField { get; set; }
        public string TotalRow { get; set; }
        public string ColumnHeaders { get; set; }
        public string ColumnSetHeaders { get; set; }
        public string ColumnSetRowCount { get; set; }
        public string ColumnSetHeaderLines { get; set; }
        public string HeaderLines { get; set; }
        public string GroupByBoxVisible { get; set; }
        public string FilterLineVisible { get; set; }
        public string PreviewRow { get; set; }
        public string PreviewRowMember { get; set; }
        public string PreviewRowLines { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayoutParam
    {
        public string ID { get; set; }
        public string AA { get; set; }
        public string Caption { get; set; }
        public string Tooltip { get; set; }
        public string ControlType { get; set; }
        public string ParameterType { get; set; }
        public string Precision { get; set; }
        public string MultiValued { get; set; }
        public string Visible { get; set; }
        public string Required { get; set; }
        public string ODSTag { get; set; }
        public string Tags { get; set; }
        public string Visibility { get; set; }
        public string InvQueryID { get; set; }
        public string InvSelectedMasterTable { get; set; }
        public string InvSelectedMasterField { get; set; }
        public string InvTableMappings { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayoutDefaultValue
    {
        [JsonProperty("fParamID")]
        public string FParamID { get; set; }
        public string Value { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayoutEnumItem
    {
        [JsonProperty("fParamID")]
        public string FParamID { get; set; }
        public string ID { get; set; }
        public string Caption { get; set; }
    }

    public class EntersoftWebApiModelsESPQLayoutColumn
    {
        [JsonProperty("fFilterID")]
        public string FFilterID { get; set; }
        public string ColName { get; set; }
        public string AA { get; set; }
        public string Caption { get; set; }
        public string FormatString { get; set; }
        public string Width { get; set; }
        public string ODSTag { get; set; }
        public string Visible { get; set; }
        public string ColumnSetRow { get; set; }
        public string ColumnSetColumn { get; set; }
        public string RowSpan { get; set; }
        public string ColSpan { get; set; }
        public string AggregateFunction { get; set; }
        public string TextAlignment { get; set; }
        public string EditType { get; set; }
        public string DataTypeName { get; set; }
    }

    public enum severityInput
    {
        Information,
        Warning,
        Error,
        FatalError
    }

    public class EntersoftWebApiModelsCompanyParamEx
    {
        public string ID { get; set; }
        public JToken Value { get; set; }
        public string Description { get; set; }
        public string Help { get; set; }
        public EntersoftWebApiModelsCompanyParamExESTypeType ESType { get; set; }
        public string CompileType { get; set; }
        public string EnumName { get; set; }
    }

    public enum EntersoftWebApiModelsCompanyParamExESTypeType
    {
        [EnumMember(Value = "STRING_TYPE")]
        STRINGTYPE,
        [EnumMember(Value = "NUMERIC_TYPE")]
        NUMERICTYPE,
        [EnumMember(Value = "DATE_TYPE")]
        DATETYPE,
        [EnumMember(Value = "BOOLEAN_TYPE")]
        BOOLEANTYPE
    }

    public class EntersoftWebApiModelsESScrollerCommandOut
    {
        public JToken ScrollerDataset { get; set; }
        public JToken[] TargetDatasets { get; set; }
        public JToken Variables { get; set; }
    }

    public class EntersoftWebApiModelsESFormCommandOut
    {
        public JToken[] SourceDatasets { get; set; }
        public JToken[] TargetDatasets { get; set; }
        public JToken Variables { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESTMMobileTaskTypeObj
    {
        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMMobileTaskTypeObjSignatureType Signature { get; set; }
        public int DaysForFutureMobileTasks { get; set; }
        public int DaysForClosedMobileTasks { get; set; }
        public int DefaultMinutesToEnd { get; set; }
        public int DefaultMinutesToPrepare { get; set; }
        public string GroupField { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMMobileTaskTypeObjSignatureType
    {
        None,
        Optional,
        Required
    }

    public class EntersoftWebApi2ODSModelsESTMServiceRequestObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMServiceRequestObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMServiceRequestObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMServiceRequestObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMServiceRequestObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMServiceRequestObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMServiceRequestObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESTMRFMModelObj
    {
        public string TransactionRefDate { get; set; }
        public int TransactionPeriod { get; set; }
        public EntersoftWebApi2ODSModelsESTMRFMModelObjTradeAccountSelectionModeType TradeAccountSelectionMode { get; set; }
        public string ScrollerParams { get; set; }
        public int RSegments { get; set; }
        public int FSegments { get; set; }
        public int MSegments { get; set; }
        public bool AssignTradeAccountWithNoTransactionToNULLSegment { get; set; }
        public EntersoftWebApi2ODSModelsESTMRFMModelObjStateType State { get; set; }
        public string CalculationDate { get; set; }
        public EntersoftWebApi2ODSModelsESTMRFMModelObjCalculationSourceType CalculationSource { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMRFMModelObjTradeAccountSelectionModeType
    {
        AllCustomers,
        BasedOnFilter
    }

    public enum EntersoftWebApi2ODSModelsESTMRFMModelObjStateType
    {
        InProgress,
        Completed
    }

    public enum EntersoftWebApi2ODSModelsESTMRFMModelObjCalculationSourceType
    {
        TradeAccountEntries,
        ExternalSource
    }

    public class EntersoftWebApi2ODSModelsESTMNewsletterRecipientObj
    {
        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public EntersoftWebApi2ODSModelsESTMNewsletterRecipientObjStateType State { get; set; }

        [JsonProperty("fStateReasoningCategoryValueGID")]
        public string FStateReasoningCategoryValueGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMNewsletterRecipientObjStateType
    {
        Subscribed,
        Verified,
        Unsubscribed,
        Removed
    }

    public class EntersoftWebApi2ODSModelsESTMInteractionObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMInteractionObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMInteractionObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMInteractionObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMInteractionObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMInteractionObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMInteractionObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESTMObjectRatingObj
    {
        [JsonProperty("fWebUserGID")]
        public string FWebUserGID { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGID { get; set; }
        public string Date { get; set; }
        public int Rating { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESTMTaskObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMTaskObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMTaskObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMTaskObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMTaskObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMTaskObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMTaskObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESTMResourceObj
    {
        public EntersoftWebApi2ODSModelsESTMResourceObjResourceTypeType ResourceType { get; set; }
        public bool InterCompany { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }

        [JsonProperty("fMUCode")]
        public string FMUCode { get; set; }
        public bool TimeInterval { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("fSeasonCalendarGID")]
        public string FSeasonCalendarGID { get; set; }
        public bool Production { get; set; }

        [JsonProperty("fProductionUnitGID")]
        public string FProductionUnitGID { get; set; }
        public int LockResource { get; set; }

        [JsonProperty("fUserGID")]
        public string FUserGID { get; set; }
        public int InvalidEmailAddress { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMResourceObjResourceTypeType
    {
        Person,
        Asset,
        ResourceGroup,
        GeneralResource
    }

    public class EntersoftWebApi2ODSModelsESTMCampaignObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMCampaignObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMCampaignObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMCampaignObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMCampaignObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMCampaignObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMCampaignObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESTMSMActivityObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMSMActivityObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMSMActivityObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMSMActivityObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMSMActivityObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMSMActivityObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMSMActivityObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESTMOpportunityObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGID { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGID { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGID { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGID { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGID { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGID { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string RegistrationDate { get; set; }
        public string PlannedStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
        public string PlannedClosedDate { get; set; }
        public string ActualClosedDate { get; set; }
        public bool Alarm { get; set; }
        public string AlarmDate { get; set; }
        public double Completeness { get; set; }
        public bool ActivateNotification { get; set; }

        [JsonProperty("fAccessLevelGID")]
        public string FAccessLevelGID { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGID { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGID { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1GID { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2GID { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3GID { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4GID { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5GID { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6GID { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7GID { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8GID { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9GID { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10GID { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool FlagField1 { get; set; }
        public bool FlagField2 { get; set; }
        public bool FlagField3 { get; set; }
        public bool FlagField4 { get; set; }
        public bool FlagField5 { get; set; }
        public bool FlagField6 { get; set; }
        public bool FlagField7 { get; set; }
        public bool FlagField8 { get; set; }
        public bool FlagField9 { get; set; }
        public bool FlagField10 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }
        public string TaskTemplateCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public int ExtCallID { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGID { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMOpportunityObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2ODSModelsESTMOpportunityObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGID { get; set; }
        public int ID { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGID { get; set; }
        public EntersoftWebApi2ODSModelsESTMOpportunityObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGID { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGID { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FWMWorkPackageGID { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGID { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FRLSNodeGID { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGID { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGID { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGID { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FRLSTreeGID { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRLSNodeGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESTMOpportunityObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMOpportunityObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    public enum EntersoftWebApi2ODSModelsESTMOpportunityObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2ODSModelsESWMTransportActionObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fActionTypeGID")]
        public string FActionTypeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGID { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGID { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public double QtyPackMU { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGID { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public EntersoftWebApi2ODSModelsESWMTransportActionObjBalancePostingType BalancePosting { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }

        [JsonProperty("fFromStorageLocationGID")]
        public string FFromStorageLocationGID { get; set; }

        [JsonProperty("fFromWarehouseGID")]
        public string FFromWarehouseGID { get; set; }

        [JsonProperty("fFromSiteGID")]
        public string FFromSiteGID { get; set; }

        [JsonProperty("fToStorageLocationGID")]
        public string FToStorageLocationGID { get; set; }

        [JsonProperty("fToWarehouseGID")]
        public string FToWarehouseGID { get; set; }

        [JsonProperty("fToSiteGID")]
        public string FToSiteGID { get; set; }

        [JsonProperty("fFromReservationReasonCode")]
        public string FFromReservationReasonCode { get; set; }

        [JsonProperty("fFromDispositionReasonCode")]
        public string FFromDispositionReasonCode { get; set; }

        [JsonProperty("fToReservationReasonCode")]
        public string FToReservationReasonCode { get; set; }

        [JsonProperty("fToDispositionReasonCode")]
        public string FToDispositionReasonCode { get; set; }

        [JsonProperty("fSelectedDepositorGID")]
        public string FSelectedDepositorGID { get; set; }
        public string SelectedDepositorCode { get; set; }

        [JsonProperty("fSelectedTradeAccountGID")]
        public string FSelectedTradeAccountGID { get; set; }
        public string SelectedTradeAccountCode { get; set; }

        [JsonProperty("fSelectedDocumentGID")]
        public string FSelectedDocumentGID { get; set; }
        public string SelectedDocumentCode { get; set; }

        [JsonProperty("fSelectedContainerTypeGID")]
        public string FSelectedContainerTypeGID { get; set; }

        [JsonProperty("fSelectedPackageContainerTypeGID")]
        public string FSelectedPackageContainerTypeGID { get; set; }

        [JsonProperty("fSelectedPalletContainerTypeGID")]
        public string FSelectedPalletContainerTypeGID { get; set; }

        [JsonProperty("fSelectedMasterPackageContainerTypeGID")]
        public string FSelectedMasterPackageContainerTypeGID { get; set; }

        [JsonProperty("fSelectedTransportContainerTypeGID")]
        public string FSelectedTransportContainerTypeGID { get; set; }
        public string SelectedContainerTypeCode { get; set; }
        public string SelectedPackageContainerTypeCode { get; set; }
        public string SelectedPalletContainerTypeCode { get; set; }
        public string SelectedMasterPackageContainerTypeCode { get; set; }
        public string SelectedTransportContainerTypeCode { get; set; }

        [JsonProperty("fSelectedContainerGID")]
        public string FSelectedContainerGID { get; set; }
        public string SelectedContainerCode { get; set; }

        [JsonProperty("fSelectedPackageContainerGID")]
        public string FSelectedPackageContainerGID { get; set; }
        public string SelectedPackageContainerCode { get; set; }

        [JsonProperty("fSelectedPalletContainerGID")]
        public string FSelectedPalletContainerGID { get; set; }
        public string SelectedPalletContainerCode { get; set; }

        [JsonProperty("fSelectedMasterPackageContainerGID")]
        public string FSelectedMasterPackageContainerGID { get; set; }
        public string SelectedMasterPackageContainerCode { get; set; }

        [JsonProperty("fSelectedTransportContainerGID")]
        public string FSelectedTransportContainerGID { get; set; }
        public string SelectedTransportContainerCode { get; set; }

        [JsonProperty("fSelectedStorageLocationGID")]
        public string FSelectedStorageLocationGID { get; set; }
        public string SelectedStorageLocationCode { get; set; }

        [JsonProperty("fSelectedItemGID")]
        public string FSelectedItemGID { get; set; }
        public string SelectedItemCode { get; set; }

        [JsonProperty("fSelectedDeliveryPersonGID")]
        public string FSelectedDeliveryPersonGID { get; set; }
        public string SelectedDeliveryPersonCode { get; set; }

        [JsonProperty("fSelectedEntityGID")]
        public string FSelectedEntityGID { get; set; }
        public string SelectedEntityCode { get; set; }

        [JsonProperty("fInputItemGID")]
        public string FInputItemGID { get; set; }
        public string InputItemCode { get; set; }
        public double InputQuantity { get; set; }

        [JsonProperty("fInputContainerGID")]
        public string FInputContainerGID { get; set; }
        public string InputContainerCode { get; set; }

        [JsonProperty("fInputPackageContainerGID")]
        public string FInputPackageContainerGID { get; set; }
        public string InputPackageContainerCode { get; set; }

        [JsonProperty("fInputPalletContainerGID")]
        public string FInputPalletContainerGID { get; set; }
        public string InputPalletContainerCode { get; set; }

        [JsonProperty("fInputMasterPackageContainerGID")]
        public string FInputMasterPackageContainerGID { get; set; }
        public string InputMasterPackageContainerCode { get; set; }

        [JsonProperty("fInputTransportContainerGID")]
        public string FInputTransportContainerGID { get; set; }
        public string InputTransportContainerCode { get; set; }

        [JsonProperty("fInputStorageLocationGID")]
        public string FInputStorageLocationGID { get; set; }
        public string InputStorageLocationCode { get; set; }

        [JsonProperty("fSelectedDeliverySiteGID")]
        public string FSelectedDeliverySiteGID { get; set; }
        public string SelectedDeliverySiteCode { get; set; }
        public string SelectedDate { get; set; }

        [JsonProperty("fSelectedRequestItemGID")]
        public string FSelectedRequestItemGID { get; set; }

        [JsonProperty("fSelectedItemContainmentGID")]
        public string FSelectedItemContainmentGID { get; set; }

        [JsonProperty("fSelectedItemContainerTypeGID")]
        public string FSelectedItemContainerTypeGID { get; set; }
        public string SelectedItemContainerTypeCode { get; set; }

        [JsonProperty("fSelectedItemMUGID")]
        public string FSelectedItemMUGID { get; set; }
        public string SelectedItemMUCode { get; set; }
        public int SelectedContainmentType { get; set; }
        public double InputRelationToBaseMU { get; set; }
        public double InputGrossWeight { get; set; }

        [JsonProperty("fSelectedWeightMUCode")]
        public string FSelectedWeightMUCode { get; set; }
        public double InputVolume { get; set; }

        [JsonProperty("fSelectedVolumeMUCode")]
        public string FSelectedVolumeMUCode { get; set; }
        public int SelectedActiveContainerClass { get; set; }
        public string SelectedItemContainerCode { get; set; }

        [JsonProperty("fSelectedItemContainerGID")]
        public string FSelectedItemContainerGID { get; set; }

        [JsonProperty("fInputItemContainerGID")]
        public string FInputItemContainerGID { get; set; }
        public string InputItemContainerCode { get; set; }
        public string InputPackageComment { get; set; }
        public string InputMasterPackageComment { get; set; }
        public string InputPalletComment { get; set; }
        public string InputTransportComment { get; set; }
        public double InputItemWeight { get; set; }
        public string InputItemVolume { get; set; }
        public string SelectedContainerStorageLocationCode { get; set; }

        [JsonProperty("fSelectedContainerStorageLocationGID")]
        public string FSelectedContainerStorageLocationGID { get; set; }
        public string DerivedShipmentCode { get; set; }
        public string SpareField1 { get; set; }
        public string SpareField2 { get; set; }

        [JsonProperty("fSelectedSortingContainerGID")]
        public string FSelectedSortingContainerGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESWMTransportActionObjBalancePostingType
    {
        ActionItem,
        RequestActionFulfillment
    }

    public class EntersoftWebApi2ODSModelsESWMActionObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fActionTypeGID")]
        public string FActionTypeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGID { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGID { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public double QtyPackMU { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGID { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public int MUInvgType { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWMShipmentObj
    {
        public string DeliveryDueDate { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGID { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGID { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fDeliveryTermsCode")]
        public string FDeliveryTermsCode { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public string Barcode { get; set; }
        public EntersoftWebApi2ODSModelsESWMShipmentObjOriginType Origin { get; set; }
        public bool ResolveOnActivation { get; set; }
        public bool BOSelection { get; set; }
        public bool BOResolving { get; set; }
        public bool RFResolving { get; set; }
        public bool RFSelection { get; set; }
        public string ShippingDate { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }
        public string GoogleMapsRouteURL { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum EntersoftWebApi2ODSModelsESWMShipmentObjOriginType
    {
        User,
        Routing,
        Action
    }

    public class EntersoftWebApi2ODSModelsESWMWorkPackageObj
    {
        [JsonProperty("fWorkPackageTypeGID")]
        public string FWorkPackageTypeGID { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGID { get; set; }
        public string Barcode { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWMRequestObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fRequestTypeGID")]
        public string FRequestTypeGID { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGID { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGID { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGID { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGID { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGID { get; set; }
        public string Barcode { get; set; }
        public bool Printed { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWMContainerObj
    {
        [JsonProperty("fContainerTypeGID")]
        public string FContainerTypeGID { get; set; }

        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGID { get; set; }

        [JsonProperty("fSortimentGID")]
        public string FSortimentGID { get; set; }

        [JsonProperty("fContainerControlPolicyGID")]
        public string FContainerControlPolicyGID { get; set; }
        public bool Printed { get; set; }
        public string Comment { get; set; }
        public bool UseInStockAllocation { get; set; }
        public bool PhisicalDimensionsMonitoring { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWPTaskRequestObj
    {
        [JsonProperty("fTaskStatusCode")]
        public string FTaskStatusCode { get; set; }

        [JsonProperty("fRequestTypesCode")]
        public string FRequestTypesCode { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fParentRequestGID")]
        public string FParentRequestGID { get; set; }
        public string DateIssued { get; set; }
        public string DeadLine { get; set; }
        public string DatePlanned { get; set; }
        public string DeliveryDate { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fProjectPersonGID")]
        public string FProjectPersonGID { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGID { get; set; }
        public double BudgetedEffort { get; set; }
        public double BudgetedCost { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }
        public string ReqDocument { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }
        public bool IsComplain { get; set; }
        public string StringField6 { get; set; }
        public string StringField7 { get; set; }
        public string StringField8 { get; set; }
        public string StringField9 { get; set; }
        public string StringField10 { get; set; }
        public double NumericField6 { get; set; }
        public double NumericField7 { get; set; }
        public double NumericField8 { get; set; }
        public double NumericField9 { get; set; }
        public double NumericField10 { get; set; }
        public bool Flag6 { get; set; }
        public bool Flag7 { get; set; }
        public bool Flag8 { get; set; }
        public bool Flag9 { get; set; }
        public bool Flag10 { get; set; }
        public string DateField6 { get; set; }
        public string DateField7 { get; set; }
        public string DateField8 { get; set; }
        public string DateField9 { get; set; }
        public string DateField10 { get; set; }

        [JsonProperty("fTableField6Code")]
        public string FTableField6Code { get; set; }

        [JsonProperty("fTableField7Code")]
        public string FTableField7Code { get; set; }

        [JsonProperty("fTableField8Code")]
        public string FTableField8Code { get; set; }

        [JsonProperty("fTableField9Code")]
        public string FTableField9Code { get; set; }

        [JsonProperty("fTableField10Code")]
        public string FTableField10Code { get; set; }

        [JsonProperty("___RTF_CTX___")]
        public string RTFCTX { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWPWorkPackageObj
    {
        public double Timeplanned { get; set; }
        public int Chargeable { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2ODSModelsESWPActualTaskObj
    {
        [JsonProperty("fTaskRequestGID")]
        public string FTaskRequestGID { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGID { get; set; }

        [JsonProperty("fActivityTypeCode")]
        public string FActivityTypeCode { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("fSwitchToStateCode")]
        public string FSwitchToStateCode { get; set; }
        public double Hours { get; set; }
        public int Chargeable { get; set; }
        public int TaskInvoiced { get; set; }

        [JsonProperty("fExpenseType1Code")]
        public string FExpenseType1Code { get; set; }
        public double ExpenseAmount1 { get; set; }

        [JsonProperty("fExpenseType2Code")]
        public string FExpenseType2Code { get; set; }
        public double ExpenseAmount2 { get; set; }
        public string ExpenseComment { get; set; }
        public string WorkNoteID { get; set; }

        [JsonProperty("fAssignToGID")]
        public string FAssignToGID { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGID { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGID { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGID { get; set; }

        [JsonProperty("fTableField1Code")]
        public string FTableField1Code { get; set; }

        [JsonProperty("fTableField2Code")]
        public string FTableField2Code { get; set; }

        [JsonProperty("fTableField3Code")]
        public string FTableField3Code { get; set; }

        [JsonProperty("fTableField4Code")]
        public string FTableField4Code { get; set; }

        [JsonProperty("fTableField5Code")]
        public string FTableField5Code { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }
        public string DateField1 { get; set; }
        public double NumericField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }
        public bool Flag1 { get; set; }
        public bool Flag2 { get; set; }
        public bool Flag3 { get; set; }
        public bool Flag4 { get; set; }
        public bool Flag5 { get; set; }

        [JsonProperty("fTaskRequestTableField1")]
        public string FTaskRequestTableField1 { get; set; }

        [JsonProperty("fTaskRequestTableField2")]
        public string FTaskRequestTableField2 { get; set; }

        [JsonProperty("fTaskRequestTableField3")]
        public string FTaskRequestTableField3 { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGID { get; set; }
        public string Comments2 { get; set; }
        public string EntryTime { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGID { get; set; }

        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGID { get; set; }
        public string TimerColumn { get; set; }

        [JsonProperty("___RTF_CTX___")]
        public string RTFCTX { get; set; }
        public string GID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }
        public string ESUCreated { get; set; }
        public string ESDCreated { get; set; }
        public string ESUModified { get; set; }
        public string ESDModified { get; set; }
        public string TS { get; set; }
    }

    public enum registrationBusinessEventTypeInput
    {
        HighValueSalesOrder,
        HighValuePurchaseOrder,
        OrderReadyToShip,
        SaleOrderOnHold,
        OrderSaleCanceled,
        PartiallyCanceledOrder,
        SaleOrderDelete,
        HighValueCustomerCreditNote,
        NewDocumentOfType,
        NewCRMTaskOfType,
        CRMTaskExpired,
        HighValuePayment,
        HighValuePaymentWithCheck,
        HighValuePaymentTaxes,
        HighValueCollection,
        HighValueCollectionWithCheque,
        StockFallingBelowThreshold,
        RequestToApprove,
        RequestHasBeenApproved
    }

    public enum registrationStateInput
    {
        Initial,
        Arrived,
        Started,
        Delivered,
        Cancelled,
        All
    }

    public enum registrationPackageTypeInput
    {
        MasterPackage,
        Package,
        Pallet,
        Sorting,
        Transport,
        All
    }

    public enum registrationPriorityInput
    {
        Low,
        Normal,
        High
    }

    public enum registrationEntityTypeInput
    {
        ES00Device,
        ES00List,
        ES00MobileParams,
        ES00PropertySet,
        ES00PropertySetCompact,
        ES00RuleSet,
        ES00RuleSetType,
        ES00SegmentationModel,
        ES00SegmentationTemplate,
        ES00SemanticsCustomization,
        ES00SSASParameters,
        ES00WordGroup,
        ES00ZProperty,
        ESBGAllocationProfile,
        ESBGBudgetDimensionAllocationProfile,
        ESBGBudgetSheet,
        ESBGBudgetSheetProfile,
        ESBGZBudgetCashAccountGroup,
        ESBGZBudgetItemGroup,
        ESBGZBudgetSalespersonGroup,
        ESBGZBudgetTradeAccountGroup,
        ESCOCostElementType,
        ESCOCostingFolder,
        ESCOLineCostAnalysis,
        ESFACommercialProfile,
        ESFADepreciationProfile,
        ESFAFixedAsset,
        ESFAItemControlPolicy,
        ESFARevaluationProfile,
        ESFIBankImport,
        ESFICardRateProfile,
        ESFICashAccount,
        ESFICDCommercialProfile,
        ESFICheckListProfile,
        ESFICommercialProfileItem,
        ESFICommissionProfile,
        ESFICondition,
        ESFIConditionTemplate,
        ESFICreditCardType,
        ESFICreditControlProfile,
        ESFICreditor,
        ESFICreditTurnOverProfile,
        ESFICreditTurnOverProfileEntry,
        ESFICustomer,
        ESFIDebtor,
        ESFIDeclarationEntry,
        ESFIDeclarationType,
        ESFIDistributionDispatch,
        ESFIDocSeriesAttributes,
        ESFIDocumentAccessRightProfile,
        ESFIDocumentAdjustment,
        ESFIDocumentCash,
        ESFIDocumentSeries,
        ESFIDocumentStock,
        ESFIDocumentTrade,
        ESFIDocumentTransition,
        ESFIDocumentUpdateProfile,
        ESFIDocumentUpdateProfileGL,
        ESFIEInvoiceProfile,
        ESFIFieldPropertiesProfile,
        ESFIFillerProfile,
        ESFIFinancialAgreement,
        ESFIFinancialDeclaration,
        ESFIInnerDistributionEntry,
        ESFIIntrastatEntry,
        ESFIInvoicePolicy,
        ESFIInvoicePolicyAction,
        ESFIItem,
        ESFIItemAllocationProfile,
        ESFIItemCategories,
        ESFIItemControlPolicy,
        ESFIItemExpense,
        ESFIItemExpenses,
        ESFIItemFamily,
        ESFIItemPriceHistoryTemplate,
        ESFIItemService,
        ESFIItemSubCategory,
        ESFIItemSubfamily,
        ESFIKEPYOEntry,
        ESFIMeasure,
        ESFIMobileDocumentType,
        ESFIMyDataInvoice,
        ESFINote,
        ESFIOIMatchingProfile,
        ESFIOpenItemsForDateProposalHeader,
        ESFIPaymentMethod,
        ESFIPricelist,
        ESFIPricelistEditor,
        ESFISalesPerson,
        ESFISpecialAccount,
        ESFISpecialAccountGroup,
        ESFISupplier,
        ESFISupplierExpert,
        ESFITCourier,
        ESFITradeAccount,
        ESFITradeAccountContract,
        ESFITradeAccountContractType,
        ESFITransitionProfile,
        ESFITransportPlan,
        ESFIVoucher,
        ESFIVoucherPromotionProfile,
        ESFIWHAccessList,
        ESFIZAccountPostingDef,
        ESFIZElectronicTransactionsProfile,
        ESFIZInterestProfile,
        ESFIZItemCategory,
        ESFIZItemFamily,
        ESFIZItemSubCategory,
        ESFIZItemSubFamily,
        ESFIZVATExemptionReasoning,
        ESGLAccount,
        ESGLAccountingDocumentTemplate,
        ESGLAccountingDocumentType,
        ESGLAllocationProfile,
        ESGLJournal,
        ESGLLedgerEntry,
        ESGlobalBlueDocument,
        ESGOAreaMap,
        ESGOColumnsSeq,
        ESGOCompany,
        ESGOCompanyBusinessActivityCodes,
        ESGOCurrency,
        ESGOCurrencyExchangeRate,
        ESGOLegalPerson,
        ESGOMetric,
        ESGOMetricActual,
        ESGOMetricSet,
        ESGOOrganizationalUnit,
        ESGOPerson,
        ESGOPhysicalPerson,
        ESGOPrinter,
        ESGOProject,
        ESGOReport,
        ESGOScale,
        ESGOScheduledJob,
        ESGOScript,
        ESGOSeasonCalendar,
        ESGOSegmentSequence,
        ESGOServiceProfile,
        ESGOShift,
        ESGOUser,
        ESGOVATCategoryMapping,
        ESGOWebUser,
        ESGOWorkingCalendar,
        ESGOWorkingCalendarException,
        ESGOWorkstation,
        ESGOZBusinessActivity,
        ESGOZBusinessUnit,
        ESGOZDimension1,
        ESGOZDimension2,
        ESGOZInteractionProfile,
        ESMLModel,
        ESMLModelGroup,
        ESMMBOM,
        ESMMCatalogueItem,
        ESMMCommercialProfile,
        ESMMDeposition,
        ESMMItemControlPolicy,
        ESMMItemSellingPrice,
        ESMMLot,
        ESMMMaterialRequirement,
        ESMMMaterialRequirementPlan,
        ESMMMaterialRequirementPlanWithReqs,
        ESMMPersonItem,
        ESMMPhaseRouting,
        ESMMProductionLeadTimes,
        ESMMProductionPlan,
        ESMMProductionPlanDemand,
        ESMMProductionPlanItem,
        ESMMProductionPlanWithDemands,
        ESMMSerialNumber,
        ESMMSIMURelation,
        ESMMSortiment,
        ESMMStockDimSet,
        ESMMStockDimSetMap,
        ESMMStockItem,
        ESMMStockOrderModel,
        ESMMStockOrderPlan,
        ESMMStockProposalComposition,
        ESMMStockProposalGroup,
        ESMMStorageLocation,
        ESMMStorageLocationPrinter,
        ESMMStorageLocationProfile,
        ESMMStorageLocationTree,
        ESMMValidStockDimensionsProfile,
        ESMMZBCProcessingType,
        ESMMZIntrastatCode,
        ESMMZMeasurementUnit,
        ESPlanetDocument,
        ESTMABCClassificationModel,
        ESTMCampaign,
        ESTMContractTerm,
        ESTMInteraction,
        ESTMMobileTaskType,
        ESTMNewsletterRecipient,
        ESTMObjectRating,
        ESTMOpportunity,
        ESTMResource,
        ESTMRFMModel,
        ESTMRFMResponseModel,
        ESTMServiceDefinition,
        ESTMServiceRequest,
        ESTMSMAccount,
        ESTMSMActivity,
        ESTMSMCompanyAccount,
        ESTMSMRawObject,
        ESTMStatusCollection,
        ESTMTask,
        ESTMTaskCategory,
        ESTMTaskLite,
        ESTMTaskType,
        ESTRPosition,
        ESTRTerritory,
        ESTRTerritoryBudget,
        ESTRTerritoryBudgetTemplate,
        ESTRTerritoryHierarchy,
        ESTRTerritoryRulePeriod,
        ESWMAction,
        ESWMActionType,
        ESWMActionTypeReport,
        ESWMCancellationDispositionReasonMap,
        ESWMCancellationReservationReasonMap,
        ESWMContainer,
        ESWMContainerControlPolicy,
        ESWMContainerType,
        ESWMDepositor,
        ESWMItemControlPolicy,
        ESWMPhaseZoneMapping,
        ESWMRequest,
        ESWMRequestStringFieldMap,
        ESWMRequestType,
        ESWMReservationReasonWHMap,
        ESWMShipment,
        ESWMStepOperation,
        ESWMTransportAction,
        ESWMTransportRequest,
        ESWMWorkPackage,
        ESWMWorkPackageType,
        ESWPActualTask,
        ESWPActualTaskEntry,
        ESWPTaskRequest,
        ESWPWorkPackage
    }

    public enum registrationEventTypeInput
    {
        Create,
        Update,
        Delete,
        CreateOrUpdate
    }

    public enum registrationSystemEventTypeInputItem
    {
        RestartAppServer,
        UpgradeStart,
        UpgradeEnd,
        UpgradeErr,
        CustomVerChanged,
        ReCache,
        NoAvailableLicense,
        AppServerStart,
        AppServerStop,
        RFRequestAssistance,
        UserLockedOut,
        DBCheckStart,
        DBCheckEnd,
        DBCheckSErr,
        Other
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft;

    public partial class WorkflowManagedActions
    {
        public EntersoftActions Entersoft(string connectionId) => new EntersoftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EntersoftTriggers Entersoft(string connectionId) => new EntersoftTriggers(connectionId);
    }
}