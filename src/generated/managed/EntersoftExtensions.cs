//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntersoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo, ApiConnectionActionConfiguration> ES00DocumentsInfo(Expression<Func<string>> routeid)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsES00DocumentInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/Info/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo[], ApiConnectionActionConfiguration> ES00DocumentsInfoByEntityGid(Expression<Func<string>> routeid)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsES00DocumentInfo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/InfoByEntityGid/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ES00DocumentsBlobDataByGid(Expression<Func<string>> routeid, Expression<Func<string>> webapitoken = null)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/BlobDataByGid/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ES00DocumentsDownloadBlobDataByGid(Expression<Func<string>> routeid, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            var __workflow_partialMode = WorkflowExpression.Compile(partialMode, nameof(partialMode), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/DownloadBlobDataByGID/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                if (__workflow_partialMode != null)
                    callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(__workflow_partialMode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ES00DocumentsGetES00Blob(Expression<Func<string>> routeid, Expression<Func<string>> extType = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            var __workflow_extType = WorkflowExpression.Compile(extType, nameof(extType), required: false);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            var __workflow_partialMode = WorkflowExpression.Compile(partialMode, nameof(partialMode), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/GetES00Blob/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extType != null)
                    callPayload.Queries["extType"] = ExpressionConverter.Convert(__workflow_extType);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                if (__workflow_partialMode != null)
                    callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(__workflow_partialMode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ES00DocumentsGetES00BlobFromObject(Expression<Func<string>> routeid, Expression<Func<string>> keyid, Expression<Func<int>> typeid, Expression<Func<string>> extType = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            var __workflow_keyid = WorkflowExpression.Compile(keyid, nameof(keyid), required: true);
            var __workflow_typeid = WorkflowExpression.Compile(typeid, nameof(typeid), required: true);
            var __workflow_extType = WorkflowExpression.Compile(extType, nameof(extType), required: false);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            var __workflow_partialMode = WorkflowExpression.Compile(partialMode, nameof(partialMode), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/GetES00BlobFromObject/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["keyid"] = ExpressionConverter.Convert(__workflow_keyid);
                callPayload.Queries["typeid"] = ExpressionConverter.Convert(__workflow_typeid);
                if (__workflow_extType != null)
                    callPayload.Queries["extType"] = ExpressionConverter.Convert(__workflow_extType);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                if (__workflow_partialMode != null)
                    callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(__workflow_partialMode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ES00DocumentsPostBodyToES00Blob(Expression<Func<BlobInfoInput>> blobInfo)
        {
            var __workflow_blobInfo = WorkflowExpression.Compile(blobInfo, nameof(blobInfo), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ES00Documents/PostBodyToES00Blob/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_blobInfo);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00BlobInfo, ApiConnectionActionConfiguration> ES00DocumentsGetBodyFromES00Blob(Expression<Func<string>> routeid, Expression<Func<string>> keyid = null, Expression<Func<int>> typeid = null)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            var __workflow_keyid = WorkflowExpression.Compile(keyid, nameof(keyid), required: false);
            var __workflow_typeid = WorkflowExpression.Compile(typeid, nameof(typeid), required: false);
            return new DeferredBodyAction<EntersoftWebApiModelsES00BlobInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ES00Documents/GetBodyFromES00Blob/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyid != null)
                    callPayload.Queries["keyid"] = ExpressionConverter.Convert(__workflow_keyid);
                if (__workflow_typeid != null)
                    callPayload.Queries["typeid"] = ExpressionConverter.Convert(__workflow_typeid);
                return new ApiConnectionAction<EntersoftWebApiModelsES00BlobInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ES00DocumentsDeleteES00Document(Expression<Func<ParamsInput>> @params)
        {
            var __workflow_params = WorkflowExpression.Compile(@params, nameof(@params), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ES00Documents/DeleteES00Document/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_params);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsES00DocumentInfo, ApiConnectionActionConfiguration> ES00DocumentsAddOrUpdateAttachedDocument(Expression<Func<InDocInput>> inDoc)
        {
            var __workflow_inDoc = WorkflowExpression.Compile(inDoc, nameof(inDoc), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsES00DocumentInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ES00Documents/AddOrUpdateAttachedDocument/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inDoc);
                return new ApiConnectionAction<EntersoftWebApiModelsES00DocumentInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESAsset2FetchWebAsset(Expression<Func<string>> routeId, Expression<Func<bool>> base64 = null, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            var __workflow_base64 = WorkflowExpression.Compile(base64, nameof(base64), required: false);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            var __workflow_partialMode = WorkflowExpression.Compile(partialMode, nameof(partialMode), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/asset2/fetchWebAsset/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_base64 != null)
                    callPayload.Queries["base64"] = ExpressionConverter.Convert(__workflow_base64);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                if (__workflow_partialMode != null)
                    callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(__workflow_partialMode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESAsset2DownloadAsset(Expression<Func<string>> routeId, Expression<Func<string>> webapitoken = null, Expression<Func<bool>> partialMode = null)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            var __workflow_webapitoken = WorkflowExpression.Compile(webapitoken, nameof(webapitoken), required: false);
            var __workflow_partialMode = WorkflowExpression.Compile(partialMode, nameof(partialMode), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/asset2/downloadAsset/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webapitoken != null)
                    callPayload.Queries["webapitoken"] = ExpressionConverter.Convert(__workflow_webapitoken);
                if (__workflow_partialMode != null)
                    callPayload.Queries["PartialMode"] = ExpressionConverter.Convert(__workflow_partialMode);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsbgBudgetSheetObj, ApiConnectionActionConfiguration> ESBudgetEsbgBudgetSheet(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsbgBudgetSheetObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESBudget/ESBGBudgetSheet/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsbgBudgetSheetObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESCollaborationBroadcastMessage(Expression<Func<ESCollaborationBroadcastMessageMsgInput>> msg)
        {
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/BroadcastMessage/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msg);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESCollaborationSendEmail(Expression<Func<ESCollaborationSendEmailMsgInput>> msg)
        {
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/SendEmail/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msg);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> ESCollaborationSendSms(Expression<Func<ESCollaborationSendSmsMsgInput>> msg)
        {
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/SendSMS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msg);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiControllersESViberResponse, ApiConnectionActionConfiguration> ESCollaborationSendViberMessage(Expression<Func<ESCollaborationSendViberMessageMsgInput>> msg)
        {
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            return new DeferredBodyAction<EntersoftWebApiControllersESViberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/SendViberMessage/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_msg);
                return new ApiConnectionAction<EntersoftWebApiControllersESViberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESCollaborationCreateRfaRequest(Expression<Func<RfaRequestInput>> rfaRequest)
        {
            var __workflow_rfaRequest = WorkflowExpression.Compile(rfaRequest, nameof(rfaRequest), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/CreateRFARequest/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rfaRequest);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESCollaborationRespondToRfaRequest(Expression<Func<RfaResponseInput>> rfaResponse)
        {
            var __workflow_rfaResponse = WorkflowExpression.Compile(rfaResponse, nameof(rfaResponse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/RespondToRFARequest/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rfaResponse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureEsrfaRequest, ApiConnectionActionConfiguration> ESCollaborationFetchRequest(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureEsrfaRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/collaboration/FetchRequest/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["RequestID"] = ExpressionConverter.Convert(__workflow_requestId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureEsrfaRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EsrpcPingServer(Expression<Func<string>> routeid)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/PingServer/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESTestEbsConnectionTest(Expression<Func<string>> routeid)
        {
            var __workflow_routeid = WorkflowExpression.Compile(routeid, nameof(routeid), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/esapi/estest/EBSConnectionTest/{0}", __workflow_routeid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESEntityDeleteEntityById(Expression<Func<string>> entityId, Expression<Func<string>> pk)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/DeleteEntityByID/";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESEntityDeleteEntityByType(Expression<Func<EntityTypeInput>> entityType, Expression<Func<string>> pk)
        {
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/DeleteEntityByType/";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESEntityUpdateEntityById(Expression<Func<string>> entityId, Expression<Func<string>> pk, Expression<Func<object>> updProperties)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            var __workflow_updProperties = WorkflowExpression.Compile(updProperties, nameof(updProperties), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/UpdateEntityByID/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updProperties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ESEntityUpdateEntityByType(Expression<Func<EntityTypeInput>> entityType, Expression<Func<string>> pk, Expression<Func<object>> updProperties)
        {
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            var __workflow_updProperties = WorkflowExpression.Compile(updProperties, nameof(updProperties), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/UpdateEntityByType/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updProperties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiApiControllersESCreatedEntityInfo, ApiConnectionActionConfiguration> ESEntityCreateEntityById(Expression<Func<string>> entityId, Expression<Func<object>> updProperties)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_updProperties = WorkflowExpression.Compile(updProperties, nameof(updProperties), required: true);
            return new DeferredBodyAction<EntersoftWebApiApiControllersESCreatedEntityInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/CreateEntityByID/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updProperties);
                return new ApiConnectionAction<EntersoftWebApiApiControllersESCreatedEntityInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiApiControllersESCreatedEntityInfo, ApiConnectionActionConfiguration> ESEntityCreateEntityByType(Expression<Func<EntityTypeInput>> entityType, Expression<Func<object>> updProperties)
        {
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_updProperties = WorkflowExpression.Compile(updProperties, nameof(updProperties), required: true);
            return new DeferredBodyAction<EntersoftWebApiApiControllersESCreatedEntityInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/CreateEntityByType/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updProperties);
                return new ApiConnectionAction<EntersoftWebApiApiControllersESCreatedEntityInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsESBaseEntity, ApiConnectionActionConfiguration> ESEntityEntityById(Expression<Func<string>> entityId, Expression<Func<string>> pk)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsESBaseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntityByID/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsESBaseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsESBaseEntity, ApiConnectionActionConfiguration> ESEntityEntityByType(Expression<Func<EntityTypeInput>> entityType, Expression<Func<string>> pk)
        {
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsESBaseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntityByType/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Queries["PK"] = ExpressionConverter.Convert(__workflow_pk);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsESBaseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration> ESEntityEntitiesById(Expression<Func<string>> entityId, Expression<Func<FetchOptionsInput>> fetchOptions)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fetchOptions = WorkflowExpression.Compile(fetchOptions, nameof(fetchOptions), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntitiesByID/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fetchOptions);
                return new ApiConnectionAction<EntersoftWebApiModelsEspqResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration> ESEntityEntitiesByType(Expression<Func<EntityTypeInput>> entityType, Expression<Func<FetchOptionsInput>> fetchOptions)
        {
            var __workflow_entityType = WorkflowExpression.Compile(entityType, nameof(entityType), required: true);
            var __workflow_fetchOptions = WorkflowExpression.Compile(fetchOptions, nameof(fetchOptions), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntitiesByType/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EntityType"] = ExpressionConverter.Convert(__workflow_entityType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fetchOptions);
                return new ApiConnectionAction<EntersoftWebApiModelsEspqResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESEntityEntityAutomationNew(Expression<Func<string>> entity, Expression<Func<string>> operation, Expression<Func<object>> commandParams)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: true);
            var __workflow_commandParams = WorkflowExpression.Compile(commandParams, nameof(commandParams), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntityAutomationNew/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(__workflow_operation);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_commandParams);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESEntityEntityAutomationUpdate(Expression<Func<string>> entity, Expression<Func<string>> field, Expression<Func<string>> id, Expression<Func<string>> operation, Expression<Func<object>> commandParams)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: true);
            var __workflow_commandParams = WorkflowExpression.Compile(commandParams, nameof(commandParams), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntityAutomationUpdate/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["field"] = ExpressionConverter.Convert(__workflow_field);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(__workflow_operation);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_commandParams);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESEntityEntityAutomationUpdateByCode(Expression<Func<string>> entity, Expression<Func<string>> id, Expression<Func<string>> operation, Expression<Func<object>> commandParams)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_operation = WorkflowExpression.Compile(operation, nameof(operation), required: true);
            var __workflow_commandParams = WorkflowExpression.Compile(commandParams, nameof(commandParams), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/esentity/EntityAutomationUpdateByCode/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["operation"] = ExpressionConverter.Convert(__workflow_operation);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_commandParams);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiDocumentTradeObj, ApiConnectionActionConfiguration> ESFinancialsEsfiDocumentTrade(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiDocumentTradeObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIDocumentTrade/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiDocumentTradeObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiItemExpensesObj, ApiConnectionActionConfiguration> ESFinancialsEsfiItemExpenses(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiItemExpensesObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIItemExpenses/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiItemExpensesObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiCreditorObj, ApiConnectionActionConfiguration> ESFinancialsEsfiCreditor(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiCreditorObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFICreditor/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiCreditorObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiDocumentCashObj, ApiConnectionActionConfiguration> ESFinancialsEsfiDocumentCash(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiDocumentCashObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIDocumentCash/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiDocumentCashObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmStockOrderPlanObj, ApiConnectionActionConfiguration> ESFinancialsEsmmStockOrderPlan(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmStockOrderPlanObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESMMStockOrderPlan/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmStockOrderPlanObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiSupplierObj, ApiConnectionActionConfiguration> ESFinancialsEsfiSupplier(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiSupplierObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFISupplier/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiSupplierObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiItemExpenseObj, ApiConnectionActionConfiguration> ESFinancialsEsfiItemExpense(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiItemExpenseObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIItemExpense/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiItemExpenseObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiSalesPersonObj, ApiConnectionActionConfiguration> ESFinancialsEsfiSalesPerson(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiSalesPersonObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFISalesPerson/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiSalesPersonObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiPaymentMethodObj, ApiConnectionActionConfiguration> ESFinancialsEsfiPaymentMethod(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiPaymentMethodObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIPaymentMethod/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiPaymentMethodObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiItemObj, ApiConnectionActionConfiguration> ESFinancialsEsfiItem(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiItemObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIItem/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiItemObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiSpecialAccountObj, ApiConnectionActionConfiguration> ESFinancialsEsfiSpecialAccount(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiSpecialAccountObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFISpecialAccount/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiSpecialAccountObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiDocumentStockObj, ApiConnectionActionConfiguration> ESFinancialsEsfiDocumentStock(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiDocumentStockObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIDocumentStock/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiDocumentStockObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiNoteObj, ApiConnectionActionConfiguration> ESFinancialsEsfiNote(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiNoteObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFINote/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiNoteObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiTradeAccountContractObj, ApiConnectionActionConfiguration> ESFinancialsEsfiTradeAccountContract(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiTradeAccountContractObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFITradeAccountContract/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiTradeAccountContractObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiVoucherObj, ApiConnectionActionConfiguration> ESFinancialsEsfiVoucher(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiVoucherObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIVoucher/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiVoucherObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiCustomerObj, ApiConnectionActionConfiguration> ESFinancialsEsfiCustomer(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiCustomerObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFICustomer/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiCustomerObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiDebtorObj, ApiConnectionActionConfiguration> ESFinancialsEsfiDebtor(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiDebtorObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIDebtor/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiDebtorObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiPricelistObj, ApiConnectionActionConfiguration> ESFinancialsEsfiPricelist(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiPricelistObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIPricelist/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiPricelistObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiItemServiceObj, ApiConnectionActionConfiguration> ESFinancialsEsfiItemService(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiItemServiceObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIItemService/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiItemServiceObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiCashAccountObj, ApiConnectionActionConfiguration> ESFinancialsEsfiCashAccount(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiCashAccountObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFICashAccount/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiCashAccountObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObj, ApiConnectionActionConfiguration> ESFinancialsEsfiDocumentAdjustment(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFIDocumentAdjustment/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfiTradeAccountObj, ApiConnectionActionConfiguration> ESFinancialsEsfiTradeAccount(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfiTradeAccountObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFinancials/ESFITradeAccount/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfiTradeAccountObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsfaFixedAssetObj, ApiConnectionActionConfiguration> ESFixedAssetEsfaFixedAsset(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsfaFixedAssetObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESFixedAsset/ESFAFixedAsset/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsfaFixedAssetObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsgoPersonObj, ApiConnectionActionConfiguration> ESGlobalObjectsEsgoPerson(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsgoPersonObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESGlobalObjects/ESGOPerson/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsgoPersonObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsES00DeviceObj, ApiConnectionActionConfiguration> ESGlobalObjectsES00Device(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsES00DeviceObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESGlobalObjects/ES00Device/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsES00DeviceObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsgoWebUserObj, ApiConnectionActionConfiguration> ESGlobalObjectsEsgoWebUser(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsgoWebUserObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESGlobalObjects/ESGOWebUser/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsgoWebUserObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsgoUserObj, ApiConnectionActionConfiguration> ESGlobalObjectsEsgoUser(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsgoUserObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESGlobalObjects/ESGOUser/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsgoUserObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse, ApiConnectionActionConfiguration> ESBusinessHookGet(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/businesshook/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESPodHookRegistrationResponse, ApiConnectionActionConfiguration> ESPodHookGet(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureESPodHookRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/podhook/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureESPodHookRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse, ApiConnectionActionConfiguration> EsrfaHookGet(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rfahook/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse, ApiConnectionActionConfiguration> ESHookGet(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/hook/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse, ApiConnectionActionConfiguration> ESSystemHookGet(Expression<Func<string>> hookId)
        {
            var __workflow_hookId = WorkflowExpression.Compile(hookId, nameof(hookId), required: true);
            return new DeferredBodyAction<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/systemhook/{0}", __workflow_hookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmlModelObj, ApiConnectionActionConfiguration> ESMachineLearningEsmlModel(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmlModelObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMachineLearning/ESMLModel/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmlModelObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmSerialNumberObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmSerialNumber(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmSerialNumberObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMSerialNumber/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmSerialNumberObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmCatalogueItemObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmCatalogueItem(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmCatalogueItemObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMCatalogueItem/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmCatalogueItemObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmStorageLocationObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmStorageLocation(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmStorageLocationObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMStorageLocation/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmStorageLocationObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmStockItemObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmStockItem(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmStockItemObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMStockItem/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmStockItemObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmCommercialProfileObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmCommercialProfile(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmCommercialProfileObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMCommercialProfile/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmCommercialProfileObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmSortimentObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmSortiment(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmSortimentObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMSortiment/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmSortimentObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmLotObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmLot(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmLotObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMLot/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmLotObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEsmmProductionPlanObj, ApiConnectionActionConfiguration> ESMaterialManagementEsmmProductionPlan(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEsmmProductionPlanObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESMaterialManagement/ESMMProductionPlan/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEsmmProductionPlanObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ESDeviceFetchDeviceInfo(Expression<Func<string>> deviceCode)
        {
            var __workflow_deviceCode = WorkflowExpression.Compile(deviceCode, nameof(deviceCode), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/device/fetchDeviceInfo/{0}", __workflow_deviceCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESPropertySet, ApiConnectionActionConfiguration> EsrpcFetchPropertySet(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsESPropertySet, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/fetchPropertySet/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsESPropertySet>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScale, ApiConnectionActionConfiguration> EsrpcFetchESScale(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsESScale, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/fetchESScale/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsESScale>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsEspqLayout, ApiConnectionActionConfiguration> EsrpcPublicQueryLayout(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsEspqLayout, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/PublicQueryLayout/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsEspqLayout>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration> EsrpcGetPQData(Expression<Func<string>> routeId, Expression<Func<int>> pqOptionsPage = null, Expression<Func<int>> pqOptionsPageSize = null, Expression<Func<bool>> pqOptionsWithCount = null)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            var __workflow_pqOptionsPage = WorkflowExpression.Compile(pqOptionsPage, nameof(pqOptionsPage), required: false);
            var __workflow_pqOptionsPageSize = WorkflowExpression.Compile(pqOptionsPageSize, nameof(pqOptionsPageSize), required: false);
            var __workflow_pqOptionsWithCount = WorkflowExpression.Compile(pqOptionsWithCount, nameof(pqOptionsWithCount), required: false);
            return new DeferredBodyAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/GetPQData/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pqOptionsPage != null)
                    callPayload.Queries["pqOptions.page"] = ExpressionConverter.Convert(__workflow_pqOptionsPage);
                if (__workflow_pqOptionsPageSize != null)
                    callPayload.Queries["pqOptions.pageSize"] = ExpressionConverter.Convert(__workflow_pqOptionsPageSize);
                if (__workflow_pqOptionsWithCount != null)
                    callPayload.Queries["pqOptions.withCount"] = ExpressionConverter.Convert(__workflow_pqOptionsWithCount);
                return new ApiConnectionAction<EntersoftWebApiModelsEspqResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EsrpcFIImportDocument(Expression<Func<string>> inputXmlasString)
        {
            var __workflow_inputXmlasString = WorkflowExpression.Compile(inputXmlasString, nameof(inputXmlasString), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rpc/FIImportDocument/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputXmlasString);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration> EsrpcGetPQData2(Expression<Func<string>> routeId, Expression<Func<object>> @params, Expression<Func<int>> pqOptionsPage = null, Expression<Func<int>> pqOptionsPageSize = null, Expression<Func<bool>> pqOptionsWithCount = null)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            var __workflow_params = WorkflowExpression.Compile(@params, nameof(@params), required: true);
            var __workflow_pqOptionsPage = WorkflowExpression.Compile(pqOptionsPage, nameof(pqOptionsPage), required: false);
            var __workflow_pqOptionsPageSize = WorkflowExpression.Compile(pqOptionsPageSize, nameof(pqOptionsPageSize), required: false);
            var __workflow_pqOptionsWithCount = WorkflowExpression.Compile(pqOptionsWithCount, nameof(pqOptionsWithCount), required: false);
            return new DeferredBodyAction<EntersoftWebApiModelsEspqResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/GetPQData2/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pqOptionsPage != null)
                    callPayload.Queries["pqOptions.page"] = ExpressionConverter.Convert(__workflow_pqOptionsPage);
                if (__workflow_pqOptionsPageSize != null)
                    callPayload.Queries["pqOptions.pageSize"] = ExpressionConverter.Convert(__workflow_pqOptionsPageSize);
                if (__workflow_pqOptionsWithCount != null)
                    callPayload.Queries["pqOptions.withCount"] = ExpressionConverter.Convert(__workflow_pqOptionsWithCount);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_params);
                return new ApiConnectionAction<EntersoftWebApiModelsEspqResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> EsrpcLog(Expression<Func<string>> id, Expression<Func<string>> description = null, Expression<Func<SeverityInput>> severity = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_severity = WorkflowExpression.Compile(severity, nameof(severity), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rpc/Log/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ID"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_description != null)
                    callPayload.Queries["Description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_severity != null)
                    callPayload.Queries["Severity"] = ExpressionConverter.Convert(__workflow_severity);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsCompanyParamEx, ApiConnectionActionConfiguration> EsrpcFetchCompanyParam(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsCompanyParamEx, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/FetchCompanyParam/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsCompanyParamEx>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EsrpcParameterValue(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/ParameterValue/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsCompanyParamEx[], ApiConnectionActionConfiguration> EsrpcFetchCompanyParams(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsCompanyParamEx[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/FetchCompanyParams/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApiModelsCompanyParamEx[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScrollerCommandOut, ApiConnectionActionConfiguration> EsrpcExecuteScrollerCommand(Expression<Func<EsScrollerCommandInput>> esScrollerCommand)
        {
            var __workflow_esScrollerCommand = WorkflowExpression.Compile(esScrollerCommand, nameof(esScrollerCommand), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsESScrollerCommandOut, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rpc/ExecuteScrollerCommand/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_esScrollerCommand);
                return new ApiConnectionAction<EntersoftWebApiModelsESScrollerCommandOut>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESScrollerCommandOut, ApiConnectionActionConfiguration> EsrpcExecuteCommand(Expression<Func<EsCommandInInput>> esCommandIn)
        {
            var __workflow_esCommandIn = WorkflowExpression.Compile(esCommandIn, nameof(esCommandIn), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsESScrollerCommandOut, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rpc/ExecuteCommand/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_esCommandIn);
                return new ApiConnectionAction<EntersoftWebApiModelsESScrollerCommandOut>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApiModelsESFormCommandOut, ApiConnectionActionConfiguration> EsrpcExecuteFormCommand(Expression<Func<FormCommandInput>> formCommand)
        {
            var __workflow_formCommand = WorkflowExpression.Compile(formCommand, nameof(formCommand), required: true);
            return new DeferredBodyAction<EntersoftWebApiModelsESFormCommandOut, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/rpc/ExecuteFormCommand/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_formCommand);
                return new ApiConnectionAction<EntersoftWebApiModelsESFormCommandOut>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEsrpcEbsService2(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/EbsService2/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PostEsrpcEbsService2(Expression<Func<string>> routeId)
        {
            var __workflow_routeId = WorkflowExpression.Compile(routeId, nameof(routeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/rpc/EbsService2/{0}", __workflow_routeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmMobileTaskTypeObj, ApiConnectionActionConfiguration> ESTaskManagementEstmMobileTaskType(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmMobileTaskTypeObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMMobileTaskType/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmMobileTaskTypeObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmServiceRequestObj, ApiConnectionActionConfiguration> ESTaskManagementEstmServiceRequest(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmServiceRequestObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMServiceRequest/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmServiceRequestObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmrfmModelObj, ApiConnectionActionConfiguration> ESTaskManagementEstmrfmModel(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmrfmModelObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMRFMModel/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmrfmModelObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmNewsletterRecipientObj, ApiConnectionActionConfiguration> ESTaskManagementEstmNewsletterRecipient(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmNewsletterRecipientObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMNewsletterRecipient/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmNewsletterRecipientObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmInteractionObj, ApiConnectionActionConfiguration> ESTaskManagementEstmInteraction(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmInteractionObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMInteraction/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmInteractionObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmObjectRatingObj, ApiConnectionActionConfiguration> ESTaskManagementEstmObjectRating(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmObjectRatingObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMObjectRating/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmObjectRatingObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmTaskObj, ApiConnectionActionConfiguration> ESTaskManagementEstmTask(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmTaskObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMTask/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmTaskObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmResourceObj, ApiConnectionActionConfiguration> ESTaskManagementEstmResource(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmResourceObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMResource/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmResourceObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmCampaignObj, ApiConnectionActionConfiguration> ESTaskManagementEstmCampaign(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmCampaignObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMCampaign/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmCampaignObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmsmActivityObj, ApiConnectionActionConfiguration> ESTaskManagementEstmsmActivity(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmsmActivityObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMSMActivity/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmsmActivityObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEstmOpportunityObj, ApiConnectionActionConfiguration> ESTaskManagementEstmOpportunity(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEstmOpportunityObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESTaskManagement/ESTMOpportunity/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEstmOpportunityObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmTransportActionObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmTransportAction(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmTransportActionObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMTransportAction/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmTransportActionObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmActionObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmAction(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmActionObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMAction/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmActionObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmShipmentObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmShipment(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmShipmentObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMShipment/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmShipmentObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmWorkPackageObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmWorkPackage(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmWorkPackageObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMWorkPackage/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmWorkPackageObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmRequestObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmRequest(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmRequestObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMRequest/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmRequestObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswmContainerObj, ApiConnectionActionConfiguration> ESWarehouseManagementEswmContainer(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswmContainerObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWarehouseManagement/ESWMContainer/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswmContainerObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswpTaskRequestObj, ApiConnectionActionConfiguration> ESWorkInProgressEswpTaskRequest(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswpTaskRequestObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWorkInProgress/ESWPTaskRequest/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswpTaskRequestObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswpWorkPackageObj, ApiConnectionActionConfiguration> ESWorkInProgressEswpWorkPackage(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswpWorkPackageObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWorkInProgress/ESWPWorkPackage/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswpWorkPackageObj>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entersoft")]
        public IBodyWorkflowAction<EntersoftWebApi2OdsModelsEswpActualTaskObj, ApiConnectionActionConfiguration> ESWorkInProgressEswpActualTask(Expression<Func<string>> pk)
        {
            var __workflow_pk = WorkflowExpression.Compile(pk, nameof(pk), required: true);
            return new DeferredBodyAction<EntersoftWebApi2OdsModelsEswpActualTaskObj, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/ESWorkInProgress/ESWPActualTask/{0}", __workflow_pk.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EntersoftWebApi2OdsModelsEswpActualTaskObj>(callPayload);
            });
        }
    }

    public class EntersoftTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration> ESBusinessHookPost(Expression<Func<ESBusinessHookPostRegistrationInput>> registration)
        {
            var __workflow_registration = WorkflowExpression.Compile(registration, nameof(registration), required: true);
            return new DeferredBodyTrigger<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/businesshook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_registration);
                return new ApiConnectionPollingTrigger<EntersoftWebApiInfrastructureESBusinessHookRegistrationResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<EntersoftWebApiInfrastructureESPodHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration> ESPodHookPost(Expression<Func<ESPodHookPostRegistrationInput>> registration)
        {
            var __workflow_registration = WorkflowExpression.Compile(registration, nameof(registration), required: true);
            return new DeferredBodyTrigger<EntersoftWebApiInfrastructureESPodHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/podhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_registration);
                return new ApiConnectionPollingTrigger<EntersoftWebApiInfrastructureESPodHookRegistrationResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration> EsrfaHookPost(Expression<Func<EsrfaHookPostRegistrationInput>> registration)
        {
            var __workflow_registration = WorkflowExpression.Compile(registration, nameof(registration), required: true);
            return new DeferredBodyTrigger<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/rfahook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_registration);
                return new ApiConnectionPollingTrigger<EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration> ESHookPost(Expression<Func<ESHookPostRegistrationInput>> registration)
        {
            var __workflow_registration = WorkflowExpression.Compile(registration, nameof(registration), required: true);
            return new DeferredBodyTrigger<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_registration);
                return new ApiConnectionPollingTrigger<EntersoftWebApiInfrastructureESEntityHookRegistrationResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration> ESSystemHookPost(Expression<Func<ESSystemHookPostRegistrationInput>> registration)
        {
            var __workflow_registration = WorkflowExpression.Compile(registration, nameof(registration), required: true);
            return new DeferredBodyTrigger<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/systemhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_registration);
                return new ApiConnectionPollingTrigger<EntersoftWebApiInfrastructureESSystemHookRegistrationResponse>(callPayload);
            });
        }
    }

    public class EntersoftWebApiModelsES00DocumentInfo
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string EDate { get; set; }
        public string FType { get; set; }

        [JsonProperty("TableID")]
        public string TableId { get; set; }
        public string TableName { get; set; }

        [JsonProperty("fGID")]
        public string Fgid { get; set; }

        [JsonProperty("fDetailLineGID")]
        public string FDetailLineGid { get; set; }

        [JsonProperty("UNCPath")]
        public string UncPath { get; set; }
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

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("IsBLOB")]
        public bool IsBlob { get; set; }
        public bool Ingoing { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("BLOBDATALength")]
        public int BlobdataLength { get; set; }

        [JsonProperty("BLOBDATA")]
        public string Blobdata { get; set; }
    }

    public class BlobInfoInput
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }

        [JsonProperty("ObjectID")]
        public string ObjectId { get; set; }

        [JsonProperty("KeyID")]
        public string KeyId { get; set; }

        [JsonProperty("TypeID")]
        public int? TypeId { get; set; }
        public string Ext { get; set; }
        public string TextBody { get; set; }
        public bool? IsNew { get; set; }
    }

    public class EntersoftWebApiModelsES00BlobInfo
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }

        [JsonProperty("ObjectID")]
        public string ObjectId { get; set; }

        [JsonProperty("KeyID")]
        public string KeyId { get; set; }

        [JsonProperty("TypeID")]
        public int TypeId { get; set; }
        public string Ext { get; set; }
        public string TextBody { get; set; }
        public bool IsNew { get; set; }
    }

    public class ParamsInput
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string EDate { get; set; }
        public string FType { get; set; }

        [JsonProperty("TableID")]
        public string TableId { get; set; }
        public string TableName { get; set; }

        [JsonProperty("fGID")]
        public string Fgid { get; set; }

        [JsonProperty("fDetailLineGID")]
        public string FDetailLineGid { get; set; }

        [JsonProperty("UNCPath")]
        public string UncPath { get; set; }
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

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("IsBLOB")]
        public bool? IsBlob { get; set; }
        public bool? Ingoing { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("BLOBDATALength")]
        public int? BlobdataLength { get; set; }

        [JsonProperty("BLOBDATA")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Blobdata { get; set; }
    }

    public class InDocInput
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Caption { get; set; }
        public string EDate { get; set; }
        public string FType { get; set; }

        [JsonProperty("TableID")]
        public string TableId { get; set; }
        public string TableName { get; set; }

        [JsonProperty("fGID")]
        public string Fgid { get; set; }

        [JsonProperty("fDetailLineGID")]
        public string FDetailLineGid { get; set; }

        [JsonProperty("UNCPath")]
        public string UncPath { get; set; }
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

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("IsBLOB")]
        public bool? IsBlob { get; set; }
        public bool? Ingoing { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("BLOBDATALength")]
        public int? BlobdataLength { get; set; }

        [JsonProperty("BLOBDATA")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Blobdata { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsbgBudgetSheetObj
    {
        [JsonProperty("fScenarioCode")]
        public string FScenarioCode { get; set; }

        [JsonProperty("fFiscalYearGID")]
        public string FFiscalYearGid { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fBudgetSheetProfileGID")]
        public string FBudgetSheetProfileGid { get; set; }
        public string RegistrationDate { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fActivityCode")]
        public string FActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

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
        public EntersoftWebApi2OdsModelsEsbgBudgetSheetObjStateType State { get; set; }
        public EntersoftWebApi2OdsModelsEsbgBudgetSheetObjLayoutTypeType LayoutType { get; set; }
        public double DeclinePercentFrom { get; set; }
        public double DeclinePercentTo { get; set; }
        public int RevisionNumber { get; set; }
        public string DateField1 { get; set; }
        public string DateField2 { get; set; }
        public string DateField3 { get; set; }
        public string DateField4 { get; set; }
        public string DateField5 { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsbgBudgetSheetObjProductionStatusType ProductionStatus { get; set; }
        public int Version { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }
        public string PostingDateLimitv { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsbgBudgetSheetObjStateType
    {
        Initial,
        Frozen,
        Approved,
        Final,
        Fixed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsbgBudgetSheetObjLayoutTypeType
    {
        PerDC,
        TotDC,
        PerDD,
        TotDD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsbgBudgetSheetObjProductionStatusType
    {
        Indifferent,
        Valid,
        Investigate
    }

    public class ESCollaborationBroadcastMessageMsgInput
    {
        public string[] Recipients { get; set; }
        public string Message { get; set; }
    }

    public class ESCollaborationSendEmailMsgInput
    {
        public string FromEmailAddr { get; set; }
        public string ToEmailAddr { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class ESCollaborationSendSmsMsgInput
    {
        public string Body { get; set; }
        public string[] Recipients { get; set; }
        public string[] Users { get; set; }
    }

    public class EntersoftWebApiControllersESViberResponse
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public JToken[] Message { get; set; }
    }

    public class ESCollaborationSendViberMessageMsgInput
    {
        public string[] Recipients { get; set; }
        public string DateToSend { get; set; }
        public int? ExpiresInSecs { get; set; }
        public string ExpiryText { get; set; }

        [JsonProperty("fReferenceID")]
        public string FReferenceId { get; set; }
        public bool? Callback { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public string ButtonAction { get; set; }
        public string ButtonCaption { get; set; }
        public JToken ExtraProperties { get; set; }

        [JsonProperty("SMSFallback")]
        public EntersoftWebApiControllersESViberSmsFallBackMessage SmsFallback { get; set; }
    }

    public class EntersoftWebApiControllersESViberSmsFallBackMessage
    {
        [JsonProperty("SMSText")]
        public string SmsText { get; set; }
    }

    public class RfaRequestInput
    {
        public RfaRequestInput(string id, string code, string requestedBy)
        {
            this.Id = id;
            this.Code = code;
            this.RequestedBy = requestedBy;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestedBy { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RfaRequestInputPriorityType? Priority { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft.RfaRequestInputPriorityType.Normal;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsExternal { get; set; } = false;
        public string RequestClass { get; set; }
        public string RequestCategory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? NumericValue { get; set; } = 0;
        public string Title { get; set; }
        public string[] RecipientUsers { get; set; }
        public string[] RecipientGroups { get; set; }
        public string RecipienteMail { get; set; }
        public string RecipientPhone { get; set; }

        [JsonProperty("RequestedOnUTC")]
        public string RequestedOnUtc { get; set; }

        [JsonProperty("ExpiresOnUTC")]
        public string ExpiresOnUtc { get; set; }
        public string TriggeredOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RfaRequestInputPriorityType
    {
        Low,
        Normal,
        High
    }

    public class RfaResponseInput
    {
        public RfaResponseInput(string id, string code, string responseBy, string responseOrigin, string responseOnUtc)
        {
            this.Id = id;
            this.Code = code;
            this.ResponseBy = responseBy;
            this.ResponseOrigin = responseOrigin;
            this.ResponseOnUtc = responseOnUtc;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }
        public string ResponseComments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseBy { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseOrigin { get; set; }

        [JsonProperty("ResponseOnUTC", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseOnUtc { get; set; }
    }

    public class EntersoftWebApiInfrastructureEsrfaRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Code { get; set; }
        public string RequestedBy { get; set; }
        public EntersoftWebApiInfrastructureEsrfaRequestPriorityType Priority { get; set; }
        public bool IsExternal { get; set; }
        public string RequestClass { get; set; }
        public string RequestCategory { get; set; }
        public double NumericValue { get; set; }
        public string Title { get; set; }
        public string[] RecipientUsers { get; set; }
        public string[] RecipientGroups { get; set; }
        public string RecipienteMail { get; set; }
        public string RecipientPhone { get; set; }

        [JsonProperty("RequestedOnUTC")]
        public string RequestedOnUtc { get; set; }

        [JsonProperty("ExpiresOnUTC")]
        public string ExpiresOnUtc { get; set; }
        public string TriggeredOn { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureEsrfaRequestPriorityType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntityTypeInput
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
        [EnumMember(Value = "ES00SSASParameters")]
        ES00SsasParameters,
        ES00WordGroup,
        ES00ZProperty,
        [EnumMember(Value = "ESBGAllocationProfile")]
        EsbgAllocationProfile,
        [EnumMember(Value = "ESBGBudgetDimensionAllocationProfile")]
        EsbgBudgetDimensionAllocationProfile,
        [EnumMember(Value = "ESBGBudgetSheet")]
        EsbgBudgetSheet,
        [EnumMember(Value = "ESBGBudgetSheetProfile")]
        EsbgBudgetSheetProfile,
        [EnumMember(Value = "ESBGZBudgetCashAccountGroup")]
        EsbgzBudgetCashAccountGroup,
        [EnumMember(Value = "ESBGZBudgetItemGroup")]
        EsbgzBudgetItemGroup,
        [EnumMember(Value = "ESBGZBudgetSalespersonGroup")]
        EsbgzBudgetSalespersonGroup,
        [EnumMember(Value = "ESBGZBudgetTradeAccountGroup")]
        EsbgzBudgetTradeAccountGroup,
        [EnumMember(Value = "ESCOCostElementType")]
        EscoCostElementType,
        [EnumMember(Value = "ESCOCostingFolder")]
        EscoCostingFolder,
        [EnumMember(Value = "ESCOLineCostAnalysis")]
        EscoLineCostAnalysis,
        [EnumMember(Value = "ESFACommercialProfile")]
        EsfaCommercialProfile,
        [EnumMember(Value = "ESFADepreciationProfile")]
        EsfaDepreciationProfile,
        [EnumMember(Value = "ESFAFixedAsset")]
        EsfaFixedAsset,
        [EnumMember(Value = "ESFAItemControlPolicy")]
        EsfaItemControlPolicy,
        [EnumMember(Value = "ESFARevaluationProfile")]
        EsfaRevaluationProfile,
        [EnumMember(Value = "ESFIBankImport")]
        EsfiBankImport,
        [EnumMember(Value = "ESFICardRateProfile")]
        EsfiCardRateProfile,
        [EnumMember(Value = "ESFICashAccount")]
        EsfiCashAccount,
        [EnumMember(Value = "ESFICDCommercialProfile")]
        EsficdCommercialProfile,
        [EnumMember(Value = "ESFICheckListProfile")]
        EsfiCheckListProfile,
        [EnumMember(Value = "ESFICommercialProfileItem")]
        EsfiCommercialProfileItem,
        [EnumMember(Value = "ESFICommissionProfile")]
        EsfiCommissionProfile,
        [EnumMember(Value = "ESFICondition")]
        EsfiCondition,
        [EnumMember(Value = "ESFIConditionTemplate")]
        EsfiConditionTemplate,
        [EnumMember(Value = "ESFICreditCardType")]
        EsfiCreditCardType,
        [EnumMember(Value = "ESFICreditControlProfile")]
        EsfiCreditControlProfile,
        [EnumMember(Value = "ESFICreditor")]
        EsfiCreditor,
        [EnumMember(Value = "ESFICreditTurnOverProfile")]
        EsfiCreditTurnOverProfile,
        [EnumMember(Value = "ESFICreditTurnOverProfileEntry")]
        EsfiCreditTurnOverProfileEntry,
        [EnumMember(Value = "ESFICustomer")]
        EsfiCustomer,
        [EnumMember(Value = "ESFIDebtor")]
        EsfiDebtor,
        [EnumMember(Value = "ESFIDeclarationEntry")]
        EsfiDeclarationEntry,
        [EnumMember(Value = "ESFIDeclarationType")]
        EsfiDeclarationType,
        [EnumMember(Value = "ESFIDistributionDispatch")]
        EsfiDistributionDispatch,
        [EnumMember(Value = "ESFIDocSeriesAttributes")]
        EsfiDocSeriesAttributes,
        [EnumMember(Value = "ESFIDocumentAccessRightProfile")]
        EsfiDocumentAccessRightProfile,
        [EnumMember(Value = "ESFIDocumentAdjustment")]
        EsfiDocumentAdjustment,
        [EnumMember(Value = "ESFIDocumentCash")]
        EsfiDocumentCash,
        [EnumMember(Value = "ESFIDocumentSeries")]
        EsfiDocumentSeries,
        [EnumMember(Value = "ESFIDocumentStock")]
        EsfiDocumentStock,
        [EnumMember(Value = "ESFIDocumentTrade")]
        EsfiDocumentTrade,
        [EnumMember(Value = "ESFIDocumentTransition")]
        EsfiDocumentTransition,
        [EnumMember(Value = "ESFIDocumentUpdateProfile")]
        EsfiDocumentUpdateProfile,
        [EnumMember(Value = "ESFIDocumentUpdateProfileGL")]
        EsfiDocumentUpdateProfileGL,
        [EnumMember(Value = "ESFIEInvoiceProfile")]
        EsfieInvoiceProfile,
        [EnumMember(Value = "ESFIFieldPropertiesProfile")]
        EsfiFieldPropertiesProfile,
        [EnumMember(Value = "ESFIFillerProfile")]
        EsfiFillerProfile,
        [EnumMember(Value = "ESFIFinancialAgreement")]
        EsfiFinancialAgreement,
        [EnumMember(Value = "ESFIFinancialDeclaration")]
        EsfiFinancialDeclaration,
        [EnumMember(Value = "ESFIInnerDistributionEntry")]
        EsfiInnerDistributionEntry,
        [EnumMember(Value = "ESFIIntrastatEntry")]
        EsfiIntrastatEntry,
        [EnumMember(Value = "ESFIInvoicePolicy")]
        EsfiInvoicePolicy,
        [EnumMember(Value = "ESFIInvoicePolicyAction")]
        EsfiInvoicePolicyAction,
        [EnumMember(Value = "ESFIItem")]
        EsfiItem,
        [EnumMember(Value = "ESFIItemAllocationProfile")]
        EsfiItemAllocationProfile,
        [EnumMember(Value = "ESFIItemCategories")]
        EsfiItemCategories,
        [EnumMember(Value = "ESFIItemControlPolicy")]
        EsfiItemControlPolicy,
        [EnumMember(Value = "ESFIItemExpense")]
        EsfiItemExpense,
        [EnumMember(Value = "ESFIItemExpenses")]
        EsfiItemExpenses,
        [EnumMember(Value = "ESFIItemFamily")]
        EsfiItemFamily,
        [EnumMember(Value = "ESFIItemPriceHistoryTemplate")]
        EsfiItemPriceHistoryTemplate,
        [EnumMember(Value = "ESFIItemService")]
        EsfiItemService,
        [EnumMember(Value = "ESFIItemSubCategory")]
        EsfiItemSubCategory,
        [EnumMember(Value = "ESFIItemSubfamily")]
        EsfiItemSubfamily,
        [EnumMember(Value = "ESFIKEPYOEntry")]
        EsfikepyoEntry,
        [EnumMember(Value = "ESFIMeasure")]
        EsfiMeasure,
        [EnumMember(Value = "ESFIMobileDocumentType")]
        EsfiMobileDocumentType,
        [EnumMember(Value = "ESFIMyDataInvoice")]
        EsfiMyDataInvoice,
        [EnumMember(Value = "ESFINote")]
        EsfiNote,
        [EnumMember(Value = "ESFIOIMatchingProfile")]
        EsfioiMatchingProfile,
        [EnumMember(Value = "ESFIOpenItemsForDateProposalHeader")]
        EsfiOpenItemsForDateProposalHeader,
        [EnumMember(Value = "ESFIPaymentMethod")]
        EsfiPaymentMethod,
        [EnumMember(Value = "ESFIPricelist")]
        EsfiPricelist,
        [EnumMember(Value = "ESFIPricelistEditor")]
        EsfiPricelistEditor,
        [EnumMember(Value = "ESFISalesPerson")]
        EsfiSalesPerson,
        [EnumMember(Value = "ESFISpecialAccount")]
        EsfiSpecialAccount,
        [EnumMember(Value = "ESFISpecialAccountGroup")]
        EsfiSpecialAccountGroup,
        [EnumMember(Value = "ESFISupplier")]
        EsfiSupplier,
        [EnumMember(Value = "ESFISupplierExpert")]
        EsfiSupplierExpert,
        [EnumMember(Value = "ESFITCourier")]
        EsfitCourier,
        [EnumMember(Value = "ESFITradeAccount")]
        EsfiTradeAccount,
        [EnumMember(Value = "ESFITradeAccountContract")]
        EsfiTradeAccountContract,
        [EnumMember(Value = "ESFITradeAccountContractType")]
        EsfiTradeAccountContractType,
        [EnumMember(Value = "ESFITransitionProfile")]
        EsfiTransitionProfile,
        [EnumMember(Value = "ESFITransportPlan")]
        EsfiTransportPlan,
        [EnumMember(Value = "ESFIVoucher")]
        EsfiVoucher,
        [EnumMember(Value = "ESFIVoucherPromotionProfile")]
        EsfiVoucherPromotionProfile,
        [EnumMember(Value = "ESFIWHAccessList")]
        EsfiwhAccessList,
        [EnumMember(Value = "ESFIZAccountPostingDef")]
        EsfizAccountPostingDef,
        [EnumMember(Value = "ESFIZElectronicTransactionsProfile")]
        EsfizElectronicTransactionsProfile,
        [EnumMember(Value = "ESFIZInterestProfile")]
        EsfizInterestProfile,
        [EnumMember(Value = "ESFIZItemCategory")]
        EsfizItemCategory,
        [EnumMember(Value = "ESFIZItemFamily")]
        EsfizItemFamily,
        [EnumMember(Value = "ESFIZItemSubCategory")]
        EsfizItemSubCategory,
        [EnumMember(Value = "ESFIZItemSubFamily")]
        EsfizItemSubFamily,
        [EnumMember(Value = "ESFIZVATExemptionReasoning")]
        EsfizvatExemptionReasoning,
        [EnumMember(Value = "ESGLAccount")]
        EsglAccount,
        [EnumMember(Value = "ESGLAccountingDocumentTemplate")]
        EsglAccountingDocumentTemplate,
        [EnumMember(Value = "ESGLAccountingDocumentType")]
        EsglAccountingDocumentType,
        [EnumMember(Value = "ESGLAllocationProfile")]
        EsglAllocationProfile,
        [EnumMember(Value = "ESGLJournal")]
        EsglJournal,
        [EnumMember(Value = "ESGLLedgerEntry")]
        EsglLedgerEntry,
        ESGlobalBlueDocument,
        [EnumMember(Value = "ESGOAreaMap")]
        EsgoAreaMap,
        [EnumMember(Value = "ESGOColumnsSeq")]
        EsgoColumnsSeq,
        [EnumMember(Value = "ESGOCompany")]
        EsgoCompany,
        [EnumMember(Value = "ESGOCompanyBusinessActivityCodes")]
        EsgoCompanyBusinessActivityCodes,
        [EnumMember(Value = "ESGOCurrency")]
        EsgoCurrency,
        [EnumMember(Value = "ESGOCurrencyExchangeRate")]
        EsgoCurrencyExchangeRate,
        [EnumMember(Value = "ESGOLegalPerson")]
        EsgoLegalPerson,
        [EnumMember(Value = "ESGOMetric")]
        EsgoMetric,
        [EnumMember(Value = "ESGOMetricActual")]
        EsgoMetricActual,
        [EnumMember(Value = "ESGOMetricSet")]
        EsgoMetricSet,
        [EnumMember(Value = "ESGOOrganizationalUnit")]
        EsgoOrganizationalUnit,
        [EnumMember(Value = "ESGOPerson")]
        EsgoPerson,
        [EnumMember(Value = "ESGOPhysicalPerson")]
        EsgoPhysicalPerson,
        [EnumMember(Value = "ESGOPrinter")]
        EsgoPrinter,
        [EnumMember(Value = "ESGOProject")]
        EsgoProject,
        [EnumMember(Value = "ESGOReport")]
        EsgoReport,
        [EnumMember(Value = "ESGOScale")]
        EsgoScale,
        [EnumMember(Value = "ESGOScheduledJob")]
        EsgoScheduledJob,
        [EnumMember(Value = "ESGOScript")]
        EsgoScript,
        [EnumMember(Value = "ESGOSeasonCalendar")]
        EsgoSeasonCalendar,
        [EnumMember(Value = "ESGOSegmentSequence")]
        EsgoSegmentSequence,
        [EnumMember(Value = "ESGOServiceProfile")]
        EsgoServiceProfile,
        [EnumMember(Value = "ESGOShift")]
        EsgoShift,
        [EnumMember(Value = "ESGOUser")]
        EsgoUser,
        [EnumMember(Value = "ESGOVATCategoryMapping")]
        EsgovatCategoryMapping,
        [EnumMember(Value = "ESGOWebUser")]
        EsgoWebUser,
        [EnumMember(Value = "ESGOWorkingCalendar")]
        EsgoWorkingCalendar,
        [EnumMember(Value = "ESGOWorkingCalendarException")]
        EsgoWorkingCalendarException,
        [EnumMember(Value = "ESGOWorkstation")]
        EsgoWorkstation,
        [EnumMember(Value = "ESGOZBusinessActivity")]
        EsgozBusinessActivity,
        [EnumMember(Value = "ESGOZBusinessUnit")]
        EsgozBusinessUnit,
        [EnumMember(Value = "ESGOZDimension1")]
        EsgozDimension1,
        [EnumMember(Value = "ESGOZDimension2")]
        EsgozDimension2,
        [EnumMember(Value = "ESGOZInteractionProfile")]
        EsgozInteractionProfile,
        [EnumMember(Value = "ESMLModel")]
        EsmlModel,
        [EnumMember(Value = "ESMLModelGroup")]
        EsmlModelGroup,
        [EnumMember(Value = "ESMMBOM")]
        Esmmbom,
        [EnumMember(Value = "ESMMCatalogueItem")]
        EsmmCatalogueItem,
        [EnumMember(Value = "ESMMCommercialProfile")]
        EsmmCommercialProfile,
        [EnumMember(Value = "ESMMDeposition")]
        EsmmDeposition,
        [EnumMember(Value = "ESMMItemControlPolicy")]
        EsmmItemControlPolicy,
        [EnumMember(Value = "ESMMItemSellingPrice")]
        EsmmItemSellingPrice,
        [EnumMember(Value = "ESMMLot")]
        EsmmLot,
        [EnumMember(Value = "ESMMMaterialRequirement")]
        EsmmMaterialRequirement,
        [EnumMember(Value = "ESMMMaterialRequirementPlan")]
        EsmmMaterialRequirementPlan,
        [EnumMember(Value = "ESMMMaterialRequirementPlanWithReqs")]
        EsmmMaterialRequirementPlanWithReqs,
        [EnumMember(Value = "ESMMPersonItem")]
        EsmmPersonItem,
        [EnumMember(Value = "ESMMPhaseRouting")]
        EsmmPhaseRouting,
        [EnumMember(Value = "ESMMProductionLeadTimes")]
        EsmmProductionLeadTimes,
        [EnumMember(Value = "ESMMProductionPlan")]
        EsmmProductionPlan,
        [EnumMember(Value = "ESMMProductionPlanDemand")]
        EsmmProductionPlanDemand,
        [EnumMember(Value = "ESMMProductionPlanItem")]
        EsmmProductionPlanItem,
        [EnumMember(Value = "ESMMProductionPlanWithDemands")]
        EsmmProductionPlanWithDemands,
        [EnumMember(Value = "ESMMSerialNumber")]
        EsmmSerialNumber,
        [EnumMember(Value = "ESMMSIMURelation")]
        EsmmsimuRelation,
        [EnumMember(Value = "ESMMSortiment")]
        EsmmSortiment,
        [EnumMember(Value = "ESMMStockDimSet")]
        EsmmStockDimSet,
        [EnumMember(Value = "ESMMStockDimSetMap")]
        EsmmStockDimSetMap,
        [EnumMember(Value = "ESMMStockItem")]
        EsmmStockItem,
        [EnumMember(Value = "ESMMStockOrderModel")]
        EsmmStockOrderModel,
        [EnumMember(Value = "ESMMStockOrderPlan")]
        EsmmStockOrderPlan,
        [EnumMember(Value = "ESMMStockProposalComposition")]
        EsmmStockProposalComposition,
        [EnumMember(Value = "ESMMStockProposalGroup")]
        EsmmStockProposalGroup,
        [EnumMember(Value = "ESMMStorageLocation")]
        EsmmStorageLocation,
        [EnumMember(Value = "ESMMStorageLocationPrinter")]
        EsmmStorageLocationPrinter,
        [EnumMember(Value = "ESMMStorageLocationProfile")]
        EsmmStorageLocationProfile,
        [EnumMember(Value = "ESMMStorageLocationTree")]
        EsmmStorageLocationTree,
        [EnumMember(Value = "ESMMValidStockDimensionsProfile")]
        EsmmValidStockDimensionsProfile,
        [EnumMember(Value = "ESMMZBCProcessingType")]
        EsmmzbcProcessingType,
        [EnumMember(Value = "ESMMZIntrastatCode")]
        EsmmzIntrastatCode,
        [EnumMember(Value = "ESMMZMeasurementUnit")]
        EsmmzMeasurementUnit,
        ESPlanetDocument,
        [EnumMember(Value = "ESTMABCClassificationModel")]
        EstmabcClassificationModel,
        [EnumMember(Value = "ESTMCampaign")]
        EstmCampaign,
        [EnumMember(Value = "ESTMContractTerm")]
        EstmContractTerm,
        [EnumMember(Value = "ESTMInteraction")]
        EstmInteraction,
        [EnumMember(Value = "ESTMMobileTaskType")]
        EstmMobileTaskType,
        [EnumMember(Value = "ESTMNewsletterRecipient")]
        EstmNewsletterRecipient,
        [EnumMember(Value = "ESTMObjectRating")]
        EstmObjectRating,
        [EnumMember(Value = "ESTMOpportunity")]
        EstmOpportunity,
        [EnumMember(Value = "ESTMResource")]
        EstmResource,
        [EnumMember(Value = "ESTMRFMModel")]
        EstmrfmModel,
        [EnumMember(Value = "ESTMRFMResponseModel")]
        EstmrfmResponseModel,
        [EnumMember(Value = "ESTMServiceDefinition")]
        EstmServiceDefinition,
        [EnumMember(Value = "ESTMServiceRequest")]
        EstmServiceRequest,
        [EnumMember(Value = "ESTMSMAccount")]
        EstmsmAccount,
        [EnumMember(Value = "ESTMSMActivity")]
        EstmsmActivity,
        [EnumMember(Value = "ESTMSMCompanyAccount")]
        EstmsmCompanyAccount,
        [EnumMember(Value = "ESTMSMRawObject")]
        EstmsmRawObject,
        [EnumMember(Value = "ESTMStatusCollection")]
        EstmStatusCollection,
        [EnumMember(Value = "ESTMTask")]
        EstmTask,
        [EnumMember(Value = "ESTMTaskCategory")]
        EstmTaskCategory,
        [EnumMember(Value = "ESTMTaskLite")]
        EstmTaskLite,
        [EnumMember(Value = "ESTMTaskType")]
        EstmTaskType,
        [EnumMember(Value = "ESTRPosition")]
        EstrPosition,
        [EnumMember(Value = "ESTRTerritory")]
        EstrTerritory,
        [EnumMember(Value = "ESTRTerritoryBudget")]
        EstrTerritoryBudget,
        [EnumMember(Value = "ESTRTerritoryBudgetTemplate")]
        EstrTerritoryBudgetTemplate,
        [EnumMember(Value = "ESTRTerritoryHierarchy")]
        EstrTerritoryHierarchy,
        [EnumMember(Value = "ESTRTerritoryRulePeriod")]
        EstrTerritoryRulePeriod,
        [EnumMember(Value = "ESWMAction")]
        EswmAction,
        [EnumMember(Value = "ESWMActionType")]
        EswmActionType,
        [EnumMember(Value = "ESWMActionTypeReport")]
        EswmActionTypeReport,
        [EnumMember(Value = "ESWMCancellationDispositionReasonMap")]
        EswmCancellationDispositionReasonMap,
        [EnumMember(Value = "ESWMCancellationReservationReasonMap")]
        EswmCancellationReservationReasonMap,
        [EnumMember(Value = "ESWMContainer")]
        EswmContainer,
        [EnumMember(Value = "ESWMContainerControlPolicy")]
        EswmContainerControlPolicy,
        [EnumMember(Value = "ESWMContainerType")]
        EswmContainerType,
        [EnumMember(Value = "ESWMDepositor")]
        EswmDepositor,
        [EnumMember(Value = "ESWMItemControlPolicy")]
        EswmItemControlPolicy,
        [EnumMember(Value = "ESWMPhaseZoneMapping")]
        EswmPhaseZoneMapping,
        [EnumMember(Value = "ESWMRequest")]
        EswmRequest,
        [EnumMember(Value = "ESWMRequestStringFieldMap")]
        EswmRequestStringFieldMap,
        [EnumMember(Value = "ESWMRequestType")]
        EswmRequestType,
        [EnumMember(Value = "ESWMReservationReasonWHMap")]
        EswmReservationReasonWHMap,
        [EnumMember(Value = "ESWMShipment")]
        EswmShipment,
        [EnumMember(Value = "ESWMStepOperation")]
        EswmStepOperation,
        [EnumMember(Value = "ESWMTransportAction")]
        EswmTransportAction,
        [EnumMember(Value = "ESWMTransportRequest")]
        EswmTransportRequest,
        [EnumMember(Value = "ESWMWorkPackage")]
        EswmWorkPackage,
        [EnumMember(Value = "ESWMWorkPackageType")]
        EswmWorkPackageType,
        [EnumMember(Value = "ESWPActualTask")]
        EswpActualTask,
        [EnumMember(Value = "ESWPActualTaskEntry")]
        EswpActualTaskEntry,
        [EnumMember(Value = "ESWPTaskRequest")]
        EswpTaskRequest,
        [EnumMember(Value = "ESWPWorkPackage")]
        EswpWorkPackage
    }

    public class EntersoftWebApiApiControllersESCreatedEntityInfo
    {
        public string PK { get; set; }
        public string Code { get; set; }

        [JsonProperty("EntityID")]
        public string EntityId { get; set; }
        public EntersoftWebApiApiControllersESCreatedEntityInfoEntityTypeType EntityType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [EnumMember(Value = "ES00SSASParameters")]
        ES00SsasParameters,
        ES00WordGroup,
        ES00ZProperty,
        [EnumMember(Value = "ESBGAllocationProfile")]
        EsbgAllocationProfile,
        [EnumMember(Value = "ESBGBudgetDimensionAllocationProfile")]
        EsbgBudgetDimensionAllocationProfile,
        [EnumMember(Value = "ESBGBudgetSheet")]
        EsbgBudgetSheet,
        [EnumMember(Value = "ESBGBudgetSheetProfile")]
        EsbgBudgetSheetProfile,
        [EnumMember(Value = "ESBGZBudgetCashAccountGroup")]
        EsbgzBudgetCashAccountGroup,
        [EnumMember(Value = "ESBGZBudgetItemGroup")]
        EsbgzBudgetItemGroup,
        [EnumMember(Value = "ESBGZBudgetSalespersonGroup")]
        EsbgzBudgetSalespersonGroup,
        [EnumMember(Value = "ESBGZBudgetTradeAccountGroup")]
        EsbgzBudgetTradeAccountGroup,
        [EnumMember(Value = "ESCOCostElementType")]
        EscoCostElementType,
        [EnumMember(Value = "ESCOCostingFolder")]
        EscoCostingFolder,
        [EnumMember(Value = "ESCOLineCostAnalysis")]
        EscoLineCostAnalysis,
        [EnumMember(Value = "ESFACommercialProfile")]
        EsfaCommercialProfile,
        [EnumMember(Value = "ESFADepreciationProfile")]
        EsfaDepreciationProfile,
        [EnumMember(Value = "ESFAFixedAsset")]
        EsfaFixedAsset,
        [EnumMember(Value = "ESFAItemControlPolicy")]
        EsfaItemControlPolicy,
        [EnumMember(Value = "ESFARevaluationProfile")]
        EsfaRevaluationProfile,
        [EnumMember(Value = "ESFIBankImport")]
        EsfiBankImport,
        [EnumMember(Value = "ESFICardRateProfile")]
        EsfiCardRateProfile,
        [EnumMember(Value = "ESFICashAccount")]
        EsfiCashAccount,
        [EnumMember(Value = "ESFICDCommercialProfile")]
        EsficdCommercialProfile,
        [EnumMember(Value = "ESFICheckListProfile")]
        EsfiCheckListProfile,
        [EnumMember(Value = "ESFICommercialProfileItem")]
        EsfiCommercialProfileItem,
        [EnumMember(Value = "ESFICommissionProfile")]
        EsfiCommissionProfile,
        [EnumMember(Value = "ESFICondition")]
        EsfiCondition,
        [EnumMember(Value = "ESFIConditionTemplate")]
        EsfiConditionTemplate,
        [EnumMember(Value = "ESFICreditCardType")]
        EsfiCreditCardType,
        [EnumMember(Value = "ESFICreditControlProfile")]
        EsfiCreditControlProfile,
        [EnumMember(Value = "ESFICreditor")]
        EsfiCreditor,
        [EnumMember(Value = "ESFICreditTurnOverProfile")]
        EsfiCreditTurnOverProfile,
        [EnumMember(Value = "ESFICreditTurnOverProfileEntry")]
        EsfiCreditTurnOverProfileEntry,
        [EnumMember(Value = "ESFICustomer")]
        EsfiCustomer,
        [EnumMember(Value = "ESFIDebtor")]
        EsfiDebtor,
        [EnumMember(Value = "ESFIDeclarationEntry")]
        EsfiDeclarationEntry,
        [EnumMember(Value = "ESFIDeclarationType")]
        EsfiDeclarationType,
        [EnumMember(Value = "ESFIDistributionDispatch")]
        EsfiDistributionDispatch,
        [EnumMember(Value = "ESFIDocSeriesAttributes")]
        EsfiDocSeriesAttributes,
        [EnumMember(Value = "ESFIDocumentAccessRightProfile")]
        EsfiDocumentAccessRightProfile,
        [EnumMember(Value = "ESFIDocumentAdjustment")]
        EsfiDocumentAdjustment,
        [EnumMember(Value = "ESFIDocumentCash")]
        EsfiDocumentCash,
        [EnumMember(Value = "ESFIDocumentSeries")]
        EsfiDocumentSeries,
        [EnumMember(Value = "ESFIDocumentStock")]
        EsfiDocumentStock,
        [EnumMember(Value = "ESFIDocumentTrade")]
        EsfiDocumentTrade,
        [EnumMember(Value = "ESFIDocumentTransition")]
        EsfiDocumentTransition,
        [EnumMember(Value = "ESFIDocumentUpdateProfile")]
        EsfiDocumentUpdateProfile,
        [EnumMember(Value = "ESFIDocumentUpdateProfileGL")]
        EsfiDocumentUpdateProfileGL,
        [EnumMember(Value = "ESFIEInvoiceProfile")]
        EsfieInvoiceProfile,
        [EnumMember(Value = "ESFIFieldPropertiesProfile")]
        EsfiFieldPropertiesProfile,
        [EnumMember(Value = "ESFIFillerProfile")]
        EsfiFillerProfile,
        [EnumMember(Value = "ESFIFinancialAgreement")]
        EsfiFinancialAgreement,
        [EnumMember(Value = "ESFIFinancialDeclaration")]
        EsfiFinancialDeclaration,
        [EnumMember(Value = "ESFIInnerDistributionEntry")]
        EsfiInnerDistributionEntry,
        [EnumMember(Value = "ESFIIntrastatEntry")]
        EsfiIntrastatEntry,
        [EnumMember(Value = "ESFIInvoicePolicy")]
        EsfiInvoicePolicy,
        [EnumMember(Value = "ESFIInvoicePolicyAction")]
        EsfiInvoicePolicyAction,
        [EnumMember(Value = "ESFIItem")]
        EsfiItem,
        [EnumMember(Value = "ESFIItemAllocationProfile")]
        EsfiItemAllocationProfile,
        [EnumMember(Value = "ESFIItemCategories")]
        EsfiItemCategories,
        [EnumMember(Value = "ESFIItemControlPolicy")]
        EsfiItemControlPolicy,
        [EnumMember(Value = "ESFIItemExpense")]
        EsfiItemExpense,
        [EnumMember(Value = "ESFIItemExpenses")]
        EsfiItemExpenses,
        [EnumMember(Value = "ESFIItemFamily")]
        EsfiItemFamily,
        [EnumMember(Value = "ESFIItemPriceHistoryTemplate")]
        EsfiItemPriceHistoryTemplate,
        [EnumMember(Value = "ESFIItemService")]
        EsfiItemService,
        [EnumMember(Value = "ESFIItemSubCategory")]
        EsfiItemSubCategory,
        [EnumMember(Value = "ESFIItemSubfamily")]
        EsfiItemSubfamily,
        [EnumMember(Value = "ESFIKEPYOEntry")]
        EsfikepyoEntry,
        [EnumMember(Value = "ESFIMeasure")]
        EsfiMeasure,
        [EnumMember(Value = "ESFIMobileDocumentType")]
        EsfiMobileDocumentType,
        [EnumMember(Value = "ESFIMyDataInvoice")]
        EsfiMyDataInvoice,
        [EnumMember(Value = "ESFINote")]
        EsfiNote,
        [EnumMember(Value = "ESFIOIMatchingProfile")]
        EsfioiMatchingProfile,
        [EnumMember(Value = "ESFIOpenItemsForDateProposalHeader")]
        EsfiOpenItemsForDateProposalHeader,
        [EnumMember(Value = "ESFIPaymentMethod")]
        EsfiPaymentMethod,
        [EnumMember(Value = "ESFIPricelist")]
        EsfiPricelist,
        [EnumMember(Value = "ESFIPricelistEditor")]
        EsfiPricelistEditor,
        [EnumMember(Value = "ESFISalesPerson")]
        EsfiSalesPerson,
        [EnumMember(Value = "ESFISpecialAccount")]
        EsfiSpecialAccount,
        [EnumMember(Value = "ESFISpecialAccountGroup")]
        EsfiSpecialAccountGroup,
        [EnumMember(Value = "ESFISupplier")]
        EsfiSupplier,
        [EnumMember(Value = "ESFISupplierExpert")]
        EsfiSupplierExpert,
        [EnumMember(Value = "ESFITCourier")]
        EsfitCourier,
        [EnumMember(Value = "ESFITradeAccount")]
        EsfiTradeAccount,
        [EnumMember(Value = "ESFITradeAccountContract")]
        EsfiTradeAccountContract,
        [EnumMember(Value = "ESFITradeAccountContractType")]
        EsfiTradeAccountContractType,
        [EnumMember(Value = "ESFITransitionProfile")]
        EsfiTransitionProfile,
        [EnumMember(Value = "ESFITransportPlan")]
        EsfiTransportPlan,
        [EnumMember(Value = "ESFIVoucher")]
        EsfiVoucher,
        [EnumMember(Value = "ESFIVoucherPromotionProfile")]
        EsfiVoucherPromotionProfile,
        [EnumMember(Value = "ESFIWHAccessList")]
        EsfiwhAccessList,
        [EnumMember(Value = "ESFIZAccountPostingDef")]
        EsfizAccountPostingDef,
        [EnumMember(Value = "ESFIZElectronicTransactionsProfile")]
        EsfizElectronicTransactionsProfile,
        [EnumMember(Value = "ESFIZInterestProfile")]
        EsfizInterestProfile,
        [EnumMember(Value = "ESFIZItemCategory")]
        EsfizItemCategory,
        [EnumMember(Value = "ESFIZItemFamily")]
        EsfizItemFamily,
        [EnumMember(Value = "ESFIZItemSubCategory")]
        EsfizItemSubCategory,
        [EnumMember(Value = "ESFIZItemSubFamily")]
        EsfizItemSubFamily,
        [EnumMember(Value = "ESFIZVATExemptionReasoning")]
        EsfizvatExemptionReasoning,
        [EnumMember(Value = "ESGLAccount")]
        EsglAccount,
        [EnumMember(Value = "ESGLAccountingDocumentTemplate")]
        EsglAccountingDocumentTemplate,
        [EnumMember(Value = "ESGLAccountingDocumentType")]
        EsglAccountingDocumentType,
        [EnumMember(Value = "ESGLAllocationProfile")]
        EsglAllocationProfile,
        [EnumMember(Value = "ESGLJournal")]
        EsglJournal,
        [EnumMember(Value = "ESGLLedgerEntry")]
        EsglLedgerEntry,
        ESGlobalBlueDocument,
        [EnumMember(Value = "ESGOAreaMap")]
        EsgoAreaMap,
        [EnumMember(Value = "ESGOColumnsSeq")]
        EsgoColumnsSeq,
        [EnumMember(Value = "ESGOCompany")]
        EsgoCompany,
        [EnumMember(Value = "ESGOCompanyBusinessActivityCodes")]
        EsgoCompanyBusinessActivityCodes,
        [EnumMember(Value = "ESGOCurrency")]
        EsgoCurrency,
        [EnumMember(Value = "ESGOCurrencyExchangeRate")]
        EsgoCurrencyExchangeRate,
        [EnumMember(Value = "ESGOLegalPerson")]
        EsgoLegalPerson,
        [EnumMember(Value = "ESGOMetric")]
        EsgoMetric,
        [EnumMember(Value = "ESGOMetricActual")]
        EsgoMetricActual,
        [EnumMember(Value = "ESGOMetricSet")]
        EsgoMetricSet,
        [EnumMember(Value = "ESGOOrganizationalUnit")]
        EsgoOrganizationalUnit,
        [EnumMember(Value = "ESGOPerson")]
        EsgoPerson,
        [EnumMember(Value = "ESGOPhysicalPerson")]
        EsgoPhysicalPerson,
        [EnumMember(Value = "ESGOPrinter")]
        EsgoPrinter,
        [EnumMember(Value = "ESGOProject")]
        EsgoProject,
        [EnumMember(Value = "ESGOReport")]
        EsgoReport,
        [EnumMember(Value = "ESGOScale")]
        EsgoScale,
        [EnumMember(Value = "ESGOScheduledJob")]
        EsgoScheduledJob,
        [EnumMember(Value = "ESGOScript")]
        EsgoScript,
        [EnumMember(Value = "ESGOSeasonCalendar")]
        EsgoSeasonCalendar,
        [EnumMember(Value = "ESGOSegmentSequence")]
        EsgoSegmentSequence,
        [EnumMember(Value = "ESGOServiceProfile")]
        EsgoServiceProfile,
        [EnumMember(Value = "ESGOShift")]
        EsgoShift,
        [EnumMember(Value = "ESGOUser")]
        EsgoUser,
        [EnumMember(Value = "ESGOVATCategoryMapping")]
        EsgovatCategoryMapping,
        [EnumMember(Value = "ESGOWebUser")]
        EsgoWebUser,
        [EnumMember(Value = "ESGOWorkingCalendar")]
        EsgoWorkingCalendar,
        [EnumMember(Value = "ESGOWorkingCalendarException")]
        EsgoWorkingCalendarException,
        [EnumMember(Value = "ESGOWorkstation")]
        EsgoWorkstation,
        [EnumMember(Value = "ESGOZBusinessActivity")]
        EsgozBusinessActivity,
        [EnumMember(Value = "ESGOZBusinessUnit")]
        EsgozBusinessUnit,
        [EnumMember(Value = "ESGOZDimension1")]
        EsgozDimension1,
        [EnumMember(Value = "ESGOZDimension2")]
        EsgozDimension2,
        [EnumMember(Value = "ESGOZInteractionProfile")]
        EsgozInteractionProfile,
        [EnumMember(Value = "ESMLModel")]
        EsmlModel,
        [EnumMember(Value = "ESMLModelGroup")]
        EsmlModelGroup,
        [EnumMember(Value = "ESMMBOM")]
        Esmmbom,
        [EnumMember(Value = "ESMMCatalogueItem")]
        EsmmCatalogueItem,
        [EnumMember(Value = "ESMMCommercialProfile")]
        EsmmCommercialProfile,
        [EnumMember(Value = "ESMMDeposition")]
        EsmmDeposition,
        [EnumMember(Value = "ESMMItemControlPolicy")]
        EsmmItemControlPolicy,
        [EnumMember(Value = "ESMMItemSellingPrice")]
        EsmmItemSellingPrice,
        [EnumMember(Value = "ESMMLot")]
        EsmmLot,
        [EnumMember(Value = "ESMMMaterialRequirement")]
        EsmmMaterialRequirement,
        [EnumMember(Value = "ESMMMaterialRequirementPlan")]
        EsmmMaterialRequirementPlan,
        [EnumMember(Value = "ESMMMaterialRequirementPlanWithReqs")]
        EsmmMaterialRequirementPlanWithReqs,
        [EnumMember(Value = "ESMMPersonItem")]
        EsmmPersonItem,
        [EnumMember(Value = "ESMMPhaseRouting")]
        EsmmPhaseRouting,
        [EnumMember(Value = "ESMMProductionLeadTimes")]
        EsmmProductionLeadTimes,
        [EnumMember(Value = "ESMMProductionPlan")]
        EsmmProductionPlan,
        [EnumMember(Value = "ESMMProductionPlanDemand")]
        EsmmProductionPlanDemand,
        [EnumMember(Value = "ESMMProductionPlanItem")]
        EsmmProductionPlanItem,
        [EnumMember(Value = "ESMMProductionPlanWithDemands")]
        EsmmProductionPlanWithDemands,
        [EnumMember(Value = "ESMMSerialNumber")]
        EsmmSerialNumber,
        [EnumMember(Value = "ESMMSIMURelation")]
        EsmmsimuRelation,
        [EnumMember(Value = "ESMMSortiment")]
        EsmmSortiment,
        [EnumMember(Value = "ESMMStockDimSet")]
        EsmmStockDimSet,
        [EnumMember(Value = "ESMMStockDimSetMap")]
        EsmmStockDimSetMap,
        [EnumMember(Value = "ESMMStockItem")]
        EsmmStockItem,
        [EnumMember(Value = "ESMMStockOrderModel")]
        EsmmStockOrderModel,
        [EnumMember(Value = "ESMMStockOrderPlan")]
        EsmmStockOrderPlan,
        [EnumMember(Value = "ESMMStockProposalComposition")]
        EsmmStockProposalComposition,
        [EnumMember(Value = "ESMMStockProposalGroup")]
        EsmmStockProposalGroup,
        [EnumMember(Value = "ESMMStorageLocation")]
        EsmmStorageLocation,
        [EnumMember(Value = "ESMMStorageLocationPrinter")]
        EsmmStorageLocationPrinter,
        [EnumMember(Value = "ESMMStorageLocationProfile")]
        EsmmStorageLocationProfile,
        [EnumMember(Value = "ESMMStorageLocationTree")]
        EsmmStorageLocationTree,
        [EnumMember(Value = "ESMMValidStockDimensionsProfile")]
        EsmmValidStockDimensionsProfile,
        [EnumMember(Value = "ESMMZBCProcessingType")]
        EsmmzbcProcessingType,
        [EnumMember(Value = "ESMMZIntrastatCode")]
        EsmmzIntrastatCode,
        [EnumMember(Value = "ESMMZMeasurementUnit")]
        EsmmzMeasurementUnit,
        ESPlanetDocument,
        [EnumMember(Value = "ESTMABCClassificationModel")]
        EstmabcClassificationModel,
        [EnumMember(Value = "ESTMCampaign")]
        EstmCampaign,
        [EnumMember(Value = "ESTMContractTerm")]
        EstmContractTerm,
        [EnumMember(Value = "ESTMInteraction")]
        EstmInteraction,
        [EnumMember(Value = "ESTMMobileTaskType")]
        EstmMobileTaskType,
        [EnumMember(Value = "ESTMNewsletterRecipient")]
        EstmNewsletterRecipient,
        [EnumMember(Value = "ESTMObjectRating")]
        EstmObjectRating,
        [EnumMember(Value = "ESTMOpportunity")]
        EstmOpportunity,
        [EnumMember(Value = "ESTMResource")]
        EstmResource,
        [EnumMember(Value = "ESTMRFMModel")]
        EstmrfmModel,
        [EnumMember(Value = "ESTMRFMResponseModel")]
        EstmrfmResponseModel,
        [EnumMember(Value = "ESTMServiceDefinition")]
        EstmServiceDefinition,
        [EnumMember(Value = "ESTMServiceRequest")]
        EstmServiceRequest,
        [EnumMember(Value = "ESTMSMAccount")]
        EstmsmAccount,
        [EnumMember(Value = "ESTMSMActivity")]
        EstmsmActivity,
        [EnumMember(Value = "ESTMSMCompanyAccount")]
        EstmsmCompanyAccount,
        [EnumMember(Value = "ESTMSMRawObject")]
        EstmsmRawObject,
        [EnumMember(Value = "ESTMStatusCollection")]
        EstmStatusCollection,
        [EnumMember(Value = "ESTMTask")]
        EstmTask,
        [EnumMember(Value = "ESTMTaskCategory")]
        EstmTaskCategory,
        [EnumMember(Value = "ESTMTaskLite")]
        EstmTaskLite,
        [EnumMember(Value = "ESTMTaskType")]
        EstmTaskType,
        [EnumMember(Value = "ESTRPosition")]
        EstrPosition,
        [EnumMember(Value = "ESTRTerritory")]
        EstrTerritory,
        [EnumMember(Value = "ESTRTerritoryBudget")]
        EstrTerritoryBudget,
        [EnumMember(Value = "ESTRTerritoryBudgetTemplate")]
        EstrTerritoryBudgetTemplate,
        [EnumMember(Value = "ESTRTerritoryHierarchy")]
        EstrTerritoryHierarchy,
        [EnumMember(Value = "ESTRTerritoryRulePeriod")]
        EstrTerritoryRulePeriod,
        [EnumMember(Value = "ESWMAction")]
        EswmAction,
        [EnumMember(Value = "ESWMActionType")]
        EswmActionType,
        [EnumMember(Value = "ESWMActionTypeReport")]
        EswmActionTypeReport,
        [EnumMember(Value = "ESWMCancellationDispositionReasonMap")]
        EswmCancellationDispositionReasonMap,
        [EnumMember(Value = "ESWMCancellationReservationReasonMap")]
        EswmCancellationReservationReasonMap,
        [EnumMember(Value = "ESWMContainer")]
        EswmContainer,
        [EnumMember(Value = "ESWMContainerControlPolicy")]
        EswmContainerControlPolicy,
        [EnumMember(Value = "ESWMContainerType")]
        EswmContainerType,
        [EnumMember(Value = "ESWMDepositor")]
        EswmDepositor,
        [EnumMember(Value = "ESWMItemControlPolicy")]
        EswmItemControlPolicy,
        [EnumMember(Value = "ESWMPhaseZoneMapping")]
        EswmPhaseZoneMapping,
        [EnumMember(Value = "ESWMRequest")]
        EswmRequest,
        [EnumMember(Value = "ESWMRequestStringFieldMap")]
        EswmRequestStringFieldMap,
        [EnumMember(Value = "ESWMRequestType")]
        EswmRequestType,
        [EnumMember(Value = "ESWMReservationReasonWHMap")]
        EswmReservationReasonWHMap,
        [EnumMember(Value = "ESWMShipment")]
        EswmShipment,
        [EnumMember(Value = "ESWMStepOperation")]
        EswmStepOperation,
        [EnumMember(Value = "ESWMTransportAction")]
        EswmTransportAction,
        [EnumMember(Value = "ESWMTransportRequest")]
        EswmTransportRequest,
        [EnumMember(Value = "ESWMWorkPackage")]
        EswmWorkPackage,
        [EnumMember(Value = "ESWMWorkPackageType")]
        EswmWorkPackageType,
        [EnumMember(Value = "ESWPActualTask")]
        EswpActualTask,
        [EnumMember(Value = "ESWPActualTaskEntry")]
        EswpActualTaskEntry,
        [EnumMember(Value = "ESWPTaskRequest")]
        EswpTaskRequest,
        [EnumMember(Value = "ESWPWorkPackage")]
        EswpWorkPackage
    }

    public class EntersoftWebApi2OdsModelsESBaseEntity
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApiModelsEspqResult
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public string Table { get; set; }
        public JToken[] Rows { get; set; }
    }

    public class FetchOptionsInput
    {
        public string[] SelectFields { get; set; }
        public string[] OrderByFields { get; set; }
        public JToken Params { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Page { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PageSize { get; set; } = 500;
    }

    public class EntersoftWebApi2OdsModelsEsfiDocumentTradeObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FadDocumentUpdateProfileGid { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FadDocumentTypeGid { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FadDocumentSeriesGid { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjTradeAccountTypeType TradeAccountType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjTradeAccountNatureType TradeAccountNature { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADDocumentStateType ADDocumentState { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }
        public double Discount { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjVatStatusType VatStatus { get; set; }
        public string DeliveryDueDate { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGid { get; set; }

        [JsonProperty("fCompanyWHGID")]
        public string FCompanyWhgid { get; set; }

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
        public string FTransporterGid { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADOriginType ADOrigin { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FadCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double NetValue { get; set; }
        public double ADTotalValue { get; set; }
        public double ChargesValue { get; set; }
        public double TaxesValue { get; set; }
        public double DeductionsValue { get; set; }
        public double DiscountValue { get; set; }

        [JsonProperty("VATValue")]
        public double VatValue { get; set; }
        public double PayableAmount { get; set; }
        public double CurrencyNetValue { get; set; }
        public double CurrencyTotalValue { get; set; }
        public double CurrencyChargesValue { get; set; }
        public double CurrencyTaxesValue { get; set; }
        public double CurrencyDeductionsValue { get; set; }
        public double CurrencyDiscountValue { get; set; }

        [JsonProperty("CurrencyVATValue")]
        public double CurrencyVatValue { get; set; }
        public double CurrencyPayableAmount { get; set; }
        public double CostValue { get; set; }
        public double CommissionValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGid { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FadTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FadTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FadTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FadTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FadTableField5Code { get; set; }
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
        public string FadProjectGid { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FadActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FadBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FadDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FadDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FadSiteGid { get; set; }
        public double PaymentAmount { get; set; }
        public double CurrencyPaymentAmount { get; set; }

        [JsonProperty("TransitionBatchID")]
        public int TransitionBatchId { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public bool HopFromTemporaryFails { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FadNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FsnStateCode { get; set; }
        public double TradeAccountPreviousBalance { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public double CommissionValue2 { get; set; }

        [JsonProperty("fSNPostStateCode")]
        public string FsnPostStateCode { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGid { get; set; }
        public string ConcerningDocCode { get; set; }
        public bool ADTransitionAvailability { get; set; }
        public int ConcerningDocClass { get; set; }
        public string ConcerningBeginDate { get; set; }
        public string ConcerningEndDate { get; set; }

        [JsonProperty("StockValuationBatchID")]
        public int StockValuationBatchId { get; set; }
        public bool Allocated { get; set; }
        public double CustomsRate { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FadAccountManagerGid { get; set; }
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
        public string FSenderPersonGid { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGid { get; set; }
        public double TradeAccountPreviousBonusBalance { get; set; }
        public double TotalBonusValue { get; set; }
        public double CurrencyTotalBonusValue { get; set; }

        [JsonProperty("KEPYOUpdate")]
        public bool KepyoUpdate { get; set; }

        [JsonProperty("fOrderPersonGID")]
        public string FOrderPersonGid { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FadTaskGid { get; set; }
        public double SponsionNetValue { get; set; }
        public double CurrencySponsionNetValue { get; set; }
        public double SponsionTotalValue { get; set; }
        public double CurrencySponsionTotalValue { get; set; }
        public double SponsionTotalQtyBaseMU { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FadDocumentUpdateProfileGlgid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGid { get; set; }
        public string ADReportingDate { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjCalculatedCashFlowTypeType CalculatedCashFlowType { get; set; }

        [JsonProperty("fBudgetSheetGID")]
        public string FBudgetSheetGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public double TransportCost { get; set; }
        public double CurrencyTransportCost { get; set; }

        [JsonProperty("fTradeTypeCode")]
        public string FTradeTypeCode { get; set; }
        public int NumValeurDays { get; set; }

        [JsonProperty("PaymentVATRequired")]
        public bool PaymentVatRequired { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FwfStepCode { get; set; }
        public bool MandatoryBankMediation { get; set; }

        [JsonProperty("fProductProposalTaskGID")]
        public string FProductProposalTaskGid { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGid { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGid { get; set; }
        public bool ZeroTransportCost { get; set; }

        [JsonProperty("fTransportPlanGID")]
        public string FTransportPlanGid { get; set; }
        public string CouponCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGid { get; set; }

        [JsonProperty("PurchaseVATDeductible")]
        public bool PurchaseVatDeductible { get; set; }

        [JsonProperty("ReasonForVATExemption")]
        public string ReasonForVatExemption { get; set; }
        public bool TaxFree { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("SplitOnVATRequired")]
        public bool SplitOnVatRequired { get; set; }
        public string CommercialDate { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FadShiftGid { get; set; }
        public string FiscalCode { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FadMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }
        public int ApplyCommercialPolicy { get; set; }

        [JsonProperty("BOMExecution")]
        public int BomExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("VATAnalysis_Netvalue1")]
        public double VatAnalysisNetvalue1 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent1")]
        public double VatAnalysisVatPercent1 { get; set; }

        [JsonProperty("VATAnalysis_VATValue1")]
        public double VatAnalysisVatValue1 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue1")]
        public double VatAnalysisTotalValue1 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue2")]
        public double VatAnalysisNetvalue2 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent2")]
        public double VatAnalysisVatPercent2 { get; set; }

        [JsonProperty("VATAnalysis_VATValue2")]
        public double VatAnalysisVatValue2 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue2")]
        public double VatAnalysisTotalValue2 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue3")]
        public double VatAnalysisNetvalue3 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent3")]
        public double VatAnalysisVatPercent3 { get; set; }

        [JsonProperty("VATAnalysis_VATValue3")]
        public double VatAnalysisVatValue3 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue3")]
        public double VatAnalysisTotalValue3 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue4")]
        public double VatAnalysisNetvalue4 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent4")]
        public double VatAnalysisVatPercent4 { get; set; }

        [JsonProperty("VATAnalysis_VATValue4")]
        public double VatAnalysisVatValue4 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue4")]
        public double VatAnalysisTotalValue4 { get; set; }

        [JsonProperty("VATAnalysis_Netvalue5")]
        public double VatAnalysisNetvalue5 { get; set; }

        [JsonProperty("VATAnalysis_VATPercent5")]
        public double VatAnalysisVatPercent5 { get; set; }

        [JsonProperty("VATAnalysis_VATValue5")]
        public double VatAnalysisVatValue5 { get; set; }

        [JsonProperty("VATAnalysis_TotalValue5")]
        public double VatAnalysisTotalValue5 { get; set; }

        [JsonProperty("EInvoice_RelatedDocs")]
        public string EInvoiceRelatedDocs { get; set; }

        [JsonProperty("EInvoice_BusinessActivity")]
        public string EInvoiceBusinessActivity { get; set; }

        [JsonProperty("EInvoice_BIC_Code")]
        public string EInvoiceBicCode { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TdslEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TdslEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TdslEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TdslEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TdslEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TdslEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TdslEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TdslEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TdslEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TdslEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TdslEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TdslEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TdslEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TdslEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TdslEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TdslEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TdslEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TdslEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TdslEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TdslEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TdslEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TdslEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TdslEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TdslEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TdslEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TdslEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TdslEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CancelAfterSaveFCancellingSeriesGid { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CancelAfterSaveADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CancelAfterSaveReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CancelAfterSaveADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CancelAfterSaveADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CancelAfterSaveEsuCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public double CustomsReversedRate { get; set; }
        public int CreditControl { get; set; }
        public int CalculateTransportCost { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NstCourierTrackingId { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NstCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NstCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NstCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NstCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NstCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NstCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NstCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NstCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NstCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NstCourierJobId { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NsfDeliveryPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NsfDeliveryPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NsfDeliverySiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NsfSenderPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NsfSenderPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NsfSenderSiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }
        public int AllowPaymentMethodApply { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int NumValeurDaysPrev { get; set; }
        public string DeliveryDueDatePrev { get; set; }
        public double TotalQtyBaseMU { get; set; }
        public double TotalQtyVariable1 { get; set; }

        [JsonProperty("UndoTaxationVATStatus")]
        public int UndoTaxationVatStatus { get; set; }
        public int ADSiteKindWH { get; set; }
        public int WareHouseProposed { get; set; }
        public int CompactLineItemsOnSave { get; set; }

        [JsonProperty("AddLIAFromDomainOnRetailMode")]
        public int AddLiaFromDomainOnRetailMode { get; set; }

        [JsonProperty("VATCalcOnTotals")]
        public int VatCalcOnTotals { get; set; }
        public double CurrencyBaseValue { get; set; }

        [JsonProperty("CurrencyVATValueNotPayed")]
        public double CurrencyVatValueNotPayed { get; set; }
        public double CurrencyPayableMinusPaymentAmount { get; set; }
        public double CurrencyPayableAmountNotPayed { get; set; }
        public double CurrencyNetPayableAmountNotPayed { get; set; }
        public double CurrencyTotalRest { get; set; }
        public double CurrencyValueUnderTaxes { get; set; }

        [JsonProperty("SAL_CurrencyDiscountVatValue")]
        public double SalCurrencyDiscountVatValue { get; set; }
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

        [JsonProperty("VATValueNotPayed")]
        public double VatValueNotPayed { get; set; }
        public double PayableAmountNotPayed { get; set; }
        public double NetPayableAmountNotPayed { get; set; }
        public double TotalRest { get; set; }
        public double ValueUnderTaxes { get; set; }

        [JsonProperty("SAL_VatValue")]
        public double SalVatValue { get; set; }

        [JsonProperty("SAL_DiscountVatValue")]
        public double SalDiscountVatValue { get; set; }
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

        [JsonProperty("CurrencyCashPaymentAmountFTM")]
        public double CurrencyCashPaymentAmountFtm { get; set; }

        [JsonProperty("CurrencyGiftCardPaymentAmountFTM")]
        public double CurrencyGiftCardPaymentAmountFtm { get; set; }

        [JsonProperty("CurrencyCardPaymentAmountFTM")]
        public double CurrencyCardPaymentAmountFtm { get; set; }

        [JsonProperty("CurrencyNotePaymentAmountFTM")]
        public double CurrencyNotePaymentAmountFtm { get; set; }

        [JsonProperty("CurrencyTotalRestFTM")]
        public double CurrencyTotalRestFtm { get; set; }

        [JsonProperty("SAL_CurrencyVatValue")]
        public double SalCurrencyVatValue { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public int CurrencyExchangePriceType { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("Ref_SALList_DocTyp_TAcc")]
        public string RefSalListDocTypTAcc { get; set; }

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
        public double BTotalVatValue { get; set; }

        [JsonProperty("bTotalCurrencyVATValue")]
        public double BTotalCurrencyVatValue { get; set; }

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

        [JsonProperty("HasLinesVATExempt")]
        public int HasLinesVatExempt { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }
        public string ADReferenceCodeList { get; set; }
        public int InvokeInvoicePolicy { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_Description")]
        public string EInvoiceAdditionalInterchangeableExpense1Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense1NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense1VatStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense1VatValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense1_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense1TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_Description")]
        public string EInvoiceAdditionalInterchangeableExpense2Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense2NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense2VatStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense2VatValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense2_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense2TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_Description")]
        public string EInvoiceAdditionalInterchangeableExpense3Description { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_NetValue")]
        public double EInvoiceAdditionalInterchangeableExpense3NetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_VATStatus")]
        public double EInvoiceAdditionalInterchangeableExpense3VatStatus { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_VATValue")]
        public double EInvoiceAdditionalInterchangeableExpense3VatValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense3_TotalValue")]
        public double EInvoiceAdditionalInterchangeableExpense3TotalValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallNetValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallNetValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallVATValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallVatValue { get; set; }

        [JsonProperty("EInvoice_AdditionalInterchangeableExpense_OverallTotalValue")]
        public double EInvoiceAdditionalInterchangeableExpenseOverallTotalValue { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjTradeAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjTradeAccountNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjCalculatedCashFlowTypeType
    {
        No,
        Inflows,
        Outflows,
        UndoInflows,
        UndoOutflows
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentTradeObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2OdsModelsEsfiItemExpensesObj
    {
        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

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
        public string FCostElementTypeGid { get; set; }

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
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGid { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpensesObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMugid { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NsisSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjSubTypeType
    {
        Service,
        Expense
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjExpenseTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpensesObjElementExportCategoryType
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

    public class EntersoftWebApi2OdsModelsEsfiCreditorObj
    {
        public EntersoftWebApi2OdsModelsEsfiCreditorObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("KEPYOStatus")]
        public EntersoftWebApi2OdsModelsEsfiCreditorObjKepyoStatusType KepyoStatus { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiCreditorObjVatStatusType VatStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGid { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGid { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGid { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

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
        public string FglSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }
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
        public string FBonusGroupGid { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGid { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCreditorObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("MainAddressVATStatus")]
        public int MainAddressVatStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjKepyoStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCreditorObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2OdsModelsEsfiDocumentCashObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FadDocumentUpdateProfileGid { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FadDocumentTypeGid { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FadDocumentSeriesGid { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADDocumentStateType ADDocumentState { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADOriginType ADOrigin { get; set; }
        public double TotalValue { get; set; }
        public double DeductionsValue { get; set; }
        public double ChargesValue { get; set; }
        public double TaxesValue { get; set; }
        public double PayableAmount { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FadCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double ADCurrencyValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FadTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FadTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FadTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FadTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FadTableField5Code { get; set; }
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
        public string FadProjectGid { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FadActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FadBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FadDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FadDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FadSiteGid { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjVatStatusType VatStatus { get; set; }
        public double CurrencyDeductionsValue { get; set; }
        public double CurrencyChargesValue { get; set; }
        public double CurrencyTaxesValue { get; set; }
        public double CurrencyPayableAmount { get; set; }

        [JsonProperty("TransitionBatchID")]
        public int TransitionBatchId { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public int TradeAccountNature { get; set; }
        public int TradeAccountType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FadNoteStateCode { get; set; }
        public double TradeAccountPreviousBalance { get; set; }
        public bool ADTransitionAvailability { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FadAccountManagerGid { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGid { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGid { get; set; }
        public double TradeAccountPreviousBonusBalance { get; set; }
        public double TotalBonusValue { get; set; }
        public double CurrencyTotalBonusValue { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FadTaskGid { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FadDocumentUpdateProfileGlgid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADLockModeType ADLockMode { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fBudgetSheetGID")]
        public string FBudgetSheetGid { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("PaymentVATRequired")]
        public bool PaymentVatRequired { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentCashObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }

        [JsonProperty("fPersonBankAccountGID")]
        public string FPersonBankAccountGid { get; set; }

        [JsonProperty("SplitOnVATRequired")]
        public bool SplitOnVatRequired { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FadShiftGid { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FadMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TdslEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TdslEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TdslEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TdslEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TdslEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TdslEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TdslEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TdslEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TdslEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TdslEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TdslEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TdslEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TdslEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TdslEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TdslEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TdslEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TdslEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TdslEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TdslEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TdslEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TdslEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TdslEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TdslEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TdslEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TdslEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TdslEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TdslEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CancelAfterSaveFCancellingSeriesGid { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CancelAfterSaveADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CancelAfterSaveReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CancelAfterSaveADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CancelAfterSaveADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CancelAfterSaveEsuCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public int CreditControl { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int CurrencyExchangePriceType { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public double CurrencyClearAmount { get; set; }

        [JsonProperty("CurrencyChargesVATValue")]
        public double CurrencyChargesVatValue { get; set; }

        [JsonProperty("CurrencyTaxesVATValue")]
        public double CurrencyTaxesVatValue { get; set; }

        [JsonProperty("CurrencyVATValue")]
        public double CurrencyVatValue { get; set; }
        public double ClearAmount { get; set; }

        [JsonProperty("ChargesVATValue")]
        public double ChargesVatValue { get; set; }

        [JsonProperty("TaxesVATValue")]
        public double TaxesVatValue { get; set; }

        [JsonProperty("VATValue")]
        public double VatValue { get; set; }
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
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }
        public string ADReferenceCodeList { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentCashObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2OdsModelsEsmmStockOrderPlanObj
    {
        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }

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

        [JsonProperty("CrossCompanyID")]
        public string CrossCompanyId { get; set; }
        public double BottomLevel { get; set; }
        public double UpperLevel { get; set; }
        public double NumericField1 { get; set; }
        public double NumericField2 { get; set; }
        public double NumericField3 { get; set; }
        public double NumericField4 { get; set; }
        public double NumericField5 { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsfiSupplierObj
    {
        public EntersoftWebApi2OdsModelsEsfiSupplierObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("KEPYOStatus")]
        public EntersoftWebApi2OdsModelsEsfiSupplierObjKepyoStatusType KepyoStatus { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiSupplierObjVatStatusType VatStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGid { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGid { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGid { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

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
        public string FglSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }
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
        public string FBonusGroupGid { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGid { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSupplierObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("MainAddressVATStatus")]
        public int MainAddressVatStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjKepyoStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSupplierObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2OdsModelsEsfiItemExpenseObj
    {
        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

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
        public string FCostElementTypeGid { get; set; }

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
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGid { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemExpenseObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMugid { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NsisSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjSubTypeType
    {
        Service,
        Expense
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjExpenseTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemExpenseObjElementExportCategoryType
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

    public class EntersoftWebApi2OdsModelsEsfiSalesPersonObj
    {
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fCommercialUnitCode")]
        public string FCommercialUnitCode { get; set; }
        public string AlternativeCode { get; set; }
        public string Objective { get; set; }
        public string AccountStartDate { get; set; }
        public string GLAccountCode { get; set; }
        public double BaseCommission { get; set; }

        [JsonProperty("fCommissionProfileGID")]
        public string FCommissionProfileGid { get; set; }
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
        public string FglSegCode { get; set; }

        [JsonProperty("fBudgetSalespersonGroupCode")]
        public string FBudgetSalespersonGroupCode { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("NS_InitSalesPersons_Replacement")]
        public bool NSInitSalesPersonsReplacement { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsfiPaymentMethodObj
    {
        public bool AutoShow { get; set; }

        [JsonProperty("fCalendarCode")]
        public string FCalendarCode { get; set; }
        public double LimitAmount { get; set; }

        [JsonProperty("fNewPaymentMethodGID")]
        public string FNewPaymentMethodGid { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }
        public int GroupType { get; set; }
        public bool Mobile { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsfiItemObj
    {
        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

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
        public string FCostElementTypeGid { get; set; }

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
        public EntersoftWebApi2OdsModelsEsfiItemObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGid { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMugid { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NsisSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjSubTypeType
    {
        Service,
        Expense
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjExpenseTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemObjElementExportCategoryType
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

    public class EntersoftWebApi2OdsModelsEsfiSpecialAccountObj
    {
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjAccountTypeType AccountType { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public string CustomCondition { get; set; }

        [JsonProperty("fAccountGID")]
        public string FAccountGid { get; set; }
        public bool StandAloneLine { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }

        [JsonProperty("fDistributionKeyCode")]
        public string FDistributionKeyCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjDiscountLineUpdateType DiscountLineUpdate { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjAmountTypeType AmountType { get; set; }
        public double Amount { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjPriceRelatedFieldType PriceRelatedField { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjPercentageRelatedFieldType PercentageRelatedField { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjRoundingTypeType RoundingType { get; set; }
        public string Comments { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjOriginType Origin { get; set; }
        public bool AutoApply { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("IsKEPYO")]
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjIsKepyoType IsKepyo { get; set; }
        public string ReferenceField { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjCalcFromPrevLineType CalcFromPrevLine { get; set; }
        public bool IncludedInItemsGrossPrice { get; set; }

        [JsonProperty("fRelativeCarrierGID")]
        public string FRelativeCarrierGid { get; set; }
        public bool GiftCard { get; set; }
        public bool AutoSplit { get; set; }
        public bool IsTaxDeduction { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjElementExportCategoryType ElementExportCategory { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiSpecialAccountObjTypeType Type { get; set; }
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

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjAccountTypeType
    {
        Charge,
        Tax,
        Discount,
        Deduction,
        Bonus
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjDiscountLineUpdateType
    {
        Discount1,
        Discount2,
        Discount3,
        Discount4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjAmountTypeType
    {
        Price,
        Value,
        Percent,
        Round
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjPriceRelatedFieldType
    {
        Quantity,
        AlternativeQuantity,
        BaseQuantity,
        Weight,
        Volume
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjPercentageRelatedFieldType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjRoundingTypeType
    {
        NoDecimal,
        _0,
        _00,
        _000
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjOriginType
    {
        DocumentType,
        TradeAccount,
        Item,
        [EnumMember(Value = "Item_TradeAccount")]
        ItemTradeAccount,
        ShippingMethod
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjIsKepyoType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjCalcFromPrevLineType
    {
        No,
        LineValue,
        RunningTotal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjElementExportCategoryType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiSpecialAccountObjTypeType
    {
        Revenue,
        Expense
    }

    public class EntersoftWebApi2OdsModelsEsfiDocumentStockObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FadDocumentUpdateProfileGid { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FadDocumentTypeGid { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FadDocumentSeriesGid { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjSourceTypeType SourceType { get; set; }

        [JsonProperty("fSourceGID")]
        public string FSourceGid { get; set; }
        public string SourceName { get; set; }

        [JsonProperty("fSourceSiteGID")]
        public string FSourceSiteGid { get; set; }
        public string SourceSiteName { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjTargetTypeType TargetType { get; set; }

        [JsonProperty("fTargetGID")]
        public string FTargetGid { get; set; }
        public string TargetName { get; set; }

        [JsonProperty("fTargetSiteGID")]
        public string FTargetSiteGid { get; set; }
        public string TargetSiteName { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADDocumentStateType ADDocumentState { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADOriginType ADOrigin { get; set; }
        public int TotalQuantity { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FadTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FadTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FadTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FadTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FadTableField5Code { get; set; }
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
        public string FadProjectGid { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FadActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FadBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FadDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FadDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FadSiteGid { get; set; }

        [JsonProperty("TransitionBatchID")]
        public int TransitionBatchId { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FadNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FsnStateCode { get; set; }
        public bool ADTransitionAvailability { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FadAccountManagerGid { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGid { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }
        public bool SortimentHandling { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGid { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGid { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fSenderPersonGID")]
        public string FSenderPersonGid { get; set; }

        [JsonProperty("fShippingPurposeCode")]
        public string FShippingPurposeCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGid { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FadTaskGid { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FadDocumentUpdateProfileGlgid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGid { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FwfStepCode { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGid { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentStockObjADProcessStateType ADProcessState { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGid { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FadShiftGid { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FadMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FadCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }

        [JsonProperty("VATStatus")]
        public int VatStatus { get; set; }
        public int ApplyCommercialPolicy { get; set; }

        [JsonProperty("BOMExecution")]
        public int BomExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TdslEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TdslEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TdslEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TdslEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TdslEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TdslEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TdslEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TdslEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TdslEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TdslEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TdslEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TdslEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TdslEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TdslEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TdslEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TdslEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TdslEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TdslEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TdslEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TdslEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TdslEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TdslEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TdslEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TdslEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TdslEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TdslEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TdslEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CancelAfterSaveFCancellingSeriesGid { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CancelAfterSaveADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CancelAfterSaveReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CancelAfterSaveADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CancelAfterSaveADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CancelAfterSaveEsuCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NstCourierTrackingId { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NstCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NstCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NstCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NstCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NstCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NstCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NstCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NstCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NstCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NstCourierJobId { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("fSourcePersonCodeGID")]
        public string FSourcePersonCodeGid { get; set; }

        [JsonProperty("fTargetPersonCodeGID")]
        public string FTargetPersonCodeGid { get; set; }
        public int CompactLineItemsOnSave { get; set; }

        [JsonProperty("AddLIAFromDomainOnRetailMode")]
        public int AddLiaFromDomainOnRetailMode { get; set; }
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
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }
        public string ADReferenceCodeList { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NsfDeliveryPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NsfDeliveryPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NsfDeliverySiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NsfSenderPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NsfSenderPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NsfSenderSiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjSourceTypeType
    {
        CompanySite,
        TradeAccount,
        Bank,
        Collector,
        Transporter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjTargetTypeType
    {
        CompanySite,
        TradeAccount,
        Bank,
        Collector,
        Transporter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentStockObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2OdsModelsEsfiNoteObj
    {
        public string ReferenceNumber { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjNatureType Nature { get; set; }

        [JsonProperty("fNoteTypeCode")]
        public string FNoteTypeCode { get; set; }

        [JsonProperty("fNoteStateCode")]
        public string FNoteStateCode { get; set; }
        public bool IsOpen { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }

        [JsonProperty("fPaymentAccountGID")]
        public string FPaymentAccountGid { get; set; }

        [JsonProperty("fPersonBankGID")]
        public string FPersonBankGid { get; set; }
        public string Bank { get; set; }

        [JsonProperty("fRegistrationDocumentGID")]
        public string FRegistrationDocumentGid { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public double NoteValue { get; set; }
        public double CurrencyValue { get; set; }
        public double ClosedValue { get; set; }
        public double ClosedCurrencyValue { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjSourceAccountTypeType SourceAccountType { get; set; }

        [JsonProperty("fSourceAccountGID")]
        public string FSourceAccountGid { get; set; }

        [JsonProperty("fSourceAccountSiteGID")]
        public string FSourceAccountSiteGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjTargetAccountTypeType TargetAccountType { get; set; }

        [JsonProperty("fTargetAccountGID")]
        public string FTargetAccountGid { get; set; }

        [JsonProperty("fTargetAccountSiteGID")]
        public string FTargetAccountSiteGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjHolderTypeType HolderType { get; set; }

        [JsonProperty("fHolderGID")]
        public string FHolderGid { get; set; }
        public string HolderName { get; set; }

        [JsonProperty("fHolderAddressGID")]
        public string FHolderAddressGid { get; set; }
        public string HolderAddress { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjIssuedByTypeType IssuedByType { get; set; }

        [JsonProperty("fIssuedByGID")]
        public string FIssuedByGid { get; set; }
        public string IssuedByName { get; set; }

        [JsonProperty("fIssuedByAddressGID")]
        public string FIssuedByAddressGid { get; set; }
        public string IssuedByAddress { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjUnderwriterTypeType UnderwriterType { get; set; }

        [JsonProperty("fUnderwriterGID")]
        public string FUnderwriterGid { get; set; }
        public string UnderwriterName { get; set; }

        [JsonProperty("fUnderwriterAddressGID")]
        public string FUnderwriterAddressGid { get; set; }
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
        public string FNoteDepositBankAccountGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiNoteObjConcernsType Concerns { get; set; }
        public double OpenValue { get; set; }
        public double OpenCurrencyValue { get; set; }
        public bool Computerized { get; set; }
        public double CurrencyReversedRate { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjNatureType
    {
        Receivable,
        Payable
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjSourceAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjTargetAccountTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor,
        Other
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjHolderTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjIssuedByTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjUnderwriterTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiNoteObjConcernsType
    {
        All,
        NetValue,
        VatValue
    }

    public class EntersoftWebApi2OdsModelsEsfiTradeAccountContractObj
    {
        public string AlternativeCode { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fBlanketOrderGID")]
        public string FBlanketOrderGid { get; set; }
        public bool CheckItems { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }
        public double GlobalDiscount { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string RenewalDate { get; set; }
        public string SignDate { get; set; }

        [JsonProperty("fResponsibleGID")]
        public string FResponsibleGid { get; set; }

        [JsonProperty("fResponsibleContactGID")]
        public string FResponsibleContactGid { get; set; }

        [JsonProperty("fRepresentativeGID")]
        public string FRepresentativeGid { get; set; }

        [JsonProperty("fReferenceGID")]
        public string FReferenceGid { get; set; }

        [JsonProperty("fReferenceOrganizationGID")]
        public string FReferenceOrganizationGid { get; set; }
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
        public string FProjectGid { get; set; }

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
        public string FContractTypeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }
        public bool IsServiceContract { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountContractObjPeriodLengthType PeriodLength { get; set; }

        [JsonProperty("fSupersededContractGID")]
        public string FSupersededContractGid { get; set; }
        public int CreditDays { get; set; }

        [JsonProperty("fFinancialAgreementGID")]
        public string FFinancialAgreementGid { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGid { get; set; }

        [JsonProperty("fCategoryCode")]
        public string FCategoryCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("nsComments_RTF")]
        public string NsCommentsRtf { get; set; }

        [JsonProperty("nsComments_Blob")]
        public string NsCommentsBlob { get; set; }

        [JsonProperty("NS_InvoicedValue")]
        public double NSInvoicedValue { get; set; }

        [JsonProperty("NS_RemainedValue")]
        public double NSRemainedValue { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountContractObjPeriodLengthType
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

    public class EntersoftWebApi2OdsModelsEsfiVoucherObj
    {
        public string Barcode { get; set; }

        [JsonProperty("fVoucherPromotionProfileGID")]
        public string FVoucherPromotionProfileGid { get; set; }
        public double DiscVoucherValue { get; set; }
        public double DiscVoucherPercentage { get; set; }
        public double GiftVoucherValue { get; set; }
        public double GiftVoucherClosedValue { get; set; }
        public EntersoftWebApi2OdsModelsEsfiVoucherObjTypeType Type { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }
        public string RegistrationDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Notes { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fDocumentGID")]
        public string FDocumentGid { get; set; }
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
        public string FProjectGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }

        [JsonProperty("fCashAccountGID")]
        public string FCashAccountGid { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fTaskItemGID")]
        public string FTaskItemGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiVoucherObjTypeType
    {
        DiscVoucherValue,
        DiscVoucherPercentage,
        GiftVoucherValue
    }

    public class EntersoftWebApi2OdsModelsEsfiCustomerObj
    {
        public EntersoftWebApi2OdsModelsEsfiCustomerObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("KEPYOStatus")]
        public EntersoftWebApi2OdsModelsEsfiCustomerObjKepyoStatusType KepyoStatus { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiCustomerObjVatStatusType VatStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGid { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGid { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGid { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

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
        public string FglSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }
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
        public string FBonusGroupGid { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGid { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCustomerObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("MainAddressVATStatus")]
        public int MainAddressVatStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjKepyoStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCustomerObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2OdsModelsEsfiDebtorObj
    {
        public EntersoftWebApi2OdsModelsEsfiDebtorObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("KEPYOStatus")]
        public EntersoftWebApi2OdsModelsEsfiDebtorObjKepyoStatusType KepyoStatus { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiDebtorObjVatStatusType VatStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGid { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGid { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGid { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

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
        public string FglSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }
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
        public string FBonusGroupGid { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGid { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDebtorObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("MainAddressVATStatus")]
        public int MainAddressVatStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjKepyoStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDebtorObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2OdsModelsEsfiPricelistObj
    {
        public EntersoftWebApi2OdsModelsEsfiPricelistObjKindType Kind { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }

        [JsonProperty("fReferencedPricelistGID")]
        public string FReferencedPricelistGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiPricelistObjDiscountAssignmentType DiscountAssignment { get; set; }

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
        public string FDeliveryPersonGid { get; set; }
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
        public string FTransportPlanGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiPricelistObjTypeType Type { get; set; }
        public bool ApplyAnyCurrencyPrice { get; set; }
        public EntersoftWebApi2OdsModelsEsfiPricelistObjDiscountSelectionType DiscountSelection { get; set; }
        public int ActiveDimensions { get; set; }

        [JsonProperty("fDiscountKindCode")]
        public string FDiscountKindCode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiPricelistObjKindType
    {
        Sales,
        Purchases
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiPricelistObjDiscountAssignmentType
    {
        DirectlyOnPrice,
        Discount1Field,
        Discount2Field,
        Discount3Field
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiPricelistObjTypeType
    {
        Simple,
        Synthesis,
        Prioritized,
        InvoicePolicyReference
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiPricelistObjDiscountSelectionType
    {
        All,
        Maximum,
        FirstCrossField,
        FirstPerField
    }

    public class EntersoftWebApi2OdsModelsEsfiItemServiceObj
    {
        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjItemClassType ItemClass { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }
        public double Price { get; set; }
        public double RetailPrice { get; set; }

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

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
        public string FCostElementTypeGid { get; set; }

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
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjSubTypeType SubType { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGid { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjExpenseTypeType ExpenseType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjServiceTypeType ServiceType { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiItemServiceObjElementExportCategoryType ElementExportCategory { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMugid { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }

        [JsonProperty("NS_IsSet")]
        public int NsisSet { get; set; }

        [JsonProperty("NS_MainSupplier_Col")]
        public string NSMainSupplierCol { get; set; }

        [JsonProperty("NS_MainSupplierName_Col")]
        public string NSMainSupplierNameCol { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjSubTypeType
    {
        Service,
        Expense
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjExpenseTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjServiceTypeType
    {
        ServicesProvision,
        Rents,
        Grants,
        Interest,
        AncillaryRevenues,
        VariousCapitalIncome,
        VariousSalesRevenues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiItemServiceObjElementExportCategoryType
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

    public class EntersoftWebApi2OdsModelsEsfiCashAccountObj
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }

        [JsonProperty("fPersonBankGID")]
        public string FPersonBankGid { get; set; }
        public string SpecialCode { get; set; }

        [JsonProperty("fCashAccountTypeCode")]
        public string FCashAccountTypeCode { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }
        public string AlternativeName { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("fBankSiteGID")]
        public string FBankSiteGid { get; set; }
        public string Remarks { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }
        public double BalanceLimit { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }
        public bool AutoForecast { get; set; }
        public bool EnforceCurrency { get; set; }
        public int NumValeurDays { get; set; }
        public bool ConcernsCard { get; set; }

        [JsonProperty("fCashRequirementsAccountGID")]
        public string FCashRequirementsAccountGid { get; set; }

        [JsonProperty("fCardRateProfileGID")]
        public string FCardRateProfileGid { get; set; }
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

        [JsonProperty("IBANCode")]
        public string IbanCode { get; set; }
        public string SwiftCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCashAccountObjExportTransferLayoutTypeType ExportTransferLayoutType { get; set; }

        [JsonProperty("fClearingBankCode")]
        public string FClearingBankCode { get; set; }
        public int MaximumNumberOfInstallments { get; set; }
        public string OutputDevice { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCashAccountObjNotesNumberingModeType NotesNumberingMode { get; set; }
        public bool ConcernsThirdCashOnDelivery { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }

        [JsonProperty("fElectronicTransactionsProfileCode")]
        public string FElectronicTransactionsProfileCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiCashAccountObjConcernsType Concerns { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public bool ConcernsGiftCards { get; set; }

        [JsonProperty("fMyDataPaymentMethodsCode")]
        public string FMyDataPaymentMethodsCode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCashAccountObjExportTransferLayoutTypeType
    {
        None,
        Alpha,
        WinBank,
        Eurobank,
        Ethniki
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCashAccountObjNotesNumberingModeType
    {
        BasedOnIntervals,
        BasedOnSpecifiedValues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiCashAccountObjConcernsType
    {
        All,
        NetValue,
        VatValue
    }

    public class EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObj
    {
        [JsonProperty("fADDocumentUpdateProfileGID")]
        public string FadDocumentUpdateProfileGid { get; set; }

        [JsonProperty("fADDocumentTypeGID")]
        public string FadDocumentTypeGid { get; set; }

        [JsonProperty("fADDocumentSeriesGID")]
        public string FadDocumentSeriesGid { get; set; }
        public double ADNumber { get; set; }
        public string ADCode { get; set; }
        public string ADRegistrationDate { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjAccountTypeType AccountType { get; set; }

        [JsonProperty("fAccountGID")]
        public string FAccountGid { get; set; }

        [JsonProperty("fAccountSiteGID")]
        public string FAccountSiteGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADDocumentStateType ADDocumentState { get; set; }
        public string ADAlternativeCode { get; set; }
        public string ADAlternativeDate { get; set; }
        public string ADReferenceCode { get; set; }
        public bool ADInterCompany { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADCancelStateType ADCancelState { get; set; }
        public string ADApprovalCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADOriginType ADOrigin { get; set; }
        public double TotalValue { get; set; }

        [JsonProperty("fADCurrencyCode")]
        public string FadCurrencyCode { get; set; }
        public double ADCurrencyRate { get; set; }
        public double ADCurrencyValue { get; set; }
        public string ADReasoning { get; set; }
        public string ADAlternativeReasoning { get; set; }
        public string ADComments { get; set; }

        [JsonProperty("fADTableField1Code")]
        public string FadTableField1Code { get; set; }

        [JsonProperty("fADTableField2Code")]
        public string FadTableField2Code { get; set; }

        [JsonProperty("fADTableField3Code")]
        public string FadTableField3Code { get; set; }

        [JsonProperty("fADTableField4Code")]
        public string FadTableField4Code { get; set; }

        [JsonProperty("fADTableField5Code")]
        public string FadTableField5Code { get; set; }
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
        public string FadProjectGid { get; set; }

        [JsonProperty("fADActivityCode")]
        public string FadActivityCode { get; set; }

        [JsonProperty("fADBusinessUnitCode")]
        public string FadBusinessUnitCode { get; set; }

        [JsonProperty("fADDimension1Code")]
        public string FadDimension1Code { get; set; }

        [JsonProperty("fADDimension2Code")]
        public string FadDimension2Code { get; set; }

        [JsonProperty("fADSiteGID")]
        public string FadSiteGid { get; set; }

        [JsonProperty("TransitionBatchID")]
        public int TransitionBatchId { get; set; }

        [JsonProperty("fTransitionStepCode")]
        public string FTransitionStepCode { get; set; }
        public int TradeAccountNature { get; set; }
        public int TradeAccountType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADPrintedType ADPrinted { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADFiscalPeriodTypeType ADFiscalPeriodType { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }

        [JsonProperty("fADNoteStateCode")]
        public string FadNoteStateCode { get; set; }

        [JsonProperty("fSNStateCode")]
        public string FsnStateCode { get; set; }

        [JsonProperty("fSNPostStateCode")]
        public string FsnPostStateCode { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fCostingFolderGID")]
        public string FCostingFolderGid { get; set; }
        public string ConcerningDocCode { get; set; }
        public bool ADTransitionAvailability { get; set; }
        public int ConcerningDocClass { get; set; }
        public string ConcerningBeginDate { get; set; }
        public string ConcerningEndDate { get; set; }

        [JsonProperty("StockValuationBatchID")]
        public int StockValuationBatchId { get; set; }
        public bool Allocated { get; set; }

        [JsonProperty("fADAccountManagerGID")]
        public string FadAccountManagerGid { get; set; }
        public int ADPriority { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }
        public double ADValueField1 { get; set; }
        public double ADValueField2 { get; set; }
        public double ADValueField3 { get; set; }
        public double ADValueField4 { get; set; }
        public double ADValueField5 { get; set; }

        [JsonProperty("DepreciationBatchID")]
        public int DepreciationBatchId { get; set; }

        [JsonProperty("AssetRevaluationBatchID")]
        public int AssetRevaluationBatchId { get; set; }
        public bool SortimentHandling { get; set; }

        [JsonProperty("fDeliveryPersonGID")]
        public string FDeliveryPersonGid { get; set; }

        [JsonProperty("fDeliverySiteGID")]
        public string FDeliverySiteGid { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fSenderPersonGID")]
        public string FSenderPersonGid { get; set; }

        [JsonProperty("fShippingPurposeCode")]
        public string FShippingPurposeCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("KEPYOUpdate")]
        public bool KepyoUpdate { get; set; }
        public int IncludedLines { get; set; }
        public bool ADFlag1 { get; set; }
        public bool ADFlag2 { get; set; }
        public bool ADFlag3 { get; set; }
        public bool ADFlag4 { get; set; }
        public bool ADFlag5 { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADTransitionStateType ADTransitionState { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjVatStatusType VatStatus { get; set; }

        [JsonProperty("fContactGID")]
        public string FContactGid { get; set; }

        [JsonProperty("fADTaskGID")]
        public string FadTaskGid { get; set; }

        [JsonProperty("fADDocumentUpdateProfileGLGID")]
        public string FadDocumentUpdateProfileGlgid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADLockModeType ADLockMode { get; set; }

        [JsonProperty("fTransporterSiteGID")]
        public string FTransporterSiteGid { get; set; }
        public string ADReportingDate { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }

        [JsonProperty("PaymentVATRequired")]
        public bool PaymentVatRequired { get; set; }

        [JsonProperty("fWFStepCode")]
        public string FwfStepCode { get; set; }

        [JsonProperty("fSenderSiteGID")]
        public string FSenderSiteGid { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADProcessStateType ADProcessState { get; set; }
        public string ADBarcode { get; set; }
        public int NumberOfContainers { get; set; }

        [JsonProperty("fDepositionGID")]
        public string FDepositionGid { get; set; }

        [JsonProperty("SplitOnVATRequired")]
        public bool SplitOnVatRequired { get; set; }

        [JsonProperty("fTradeTypeCode")]
        public string FTradeTypeCode { get; set; }

        [JsonProperty("fVoucherStateCode")]
        public string FVoucherStateCode { get; set; }

        [JsonProperty("fADShiftGID")]
        public string FadShiftGid { get; set; }

        [JsonProperty("fADMyDataDocumentTypeCode")]
        public string FadMyDataDocumentTypeCode { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }
        public int ApplyCommercialPolicy { get; set; }

        [JsonProperty("BOMExecution")]
        public int BomExecution { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }
        public int CheckStockLevel { get; set; }

        [JsonProperty("Ref_DocumentsList")]
        public string RefDocumentsList { get; set; }

        [JsonProperty("Ref_DocumentsList_Compact")]
        public string RefDocumentsListCompact { get; set; }

        [JsonProperty("TDSL_eField")]
        public string TdslEField { get; set; }

        [JsonProperty("TDSL_eField_AutoApply")]
        public int TdslEFieldAutoApply { get; set; }

        [JsonProperty("TDSL_eField_PublisherTaxRegistrationNumber")]
        public string TdslEFieldPublisherTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_RecipientTaxRegistrationNumber")]
        public string TdslEFieldRecipientTaxRegistrationNumber { get; set; }

        [JsonProperty("TDSL_eField_CustomerReceiptsCardNumber")]
        public string TdslEFieldCustomerReceiptsCardNumber { get; set; }

        [JsonProperty("TDSL_eField_DateAndTime")]
        public string TdslEFieldDateAndTime { get; set; }

        [JsonProperty("TDSL_eField_DocumentKind")]
        public string TdslEFieldDocumentKind { get; set; }

        [JsonProperty("TDSL_eField_DocumentKindCancelled")]
        public string TdslEFieldDocumentKindCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeries")]
        public string TdslEFieldDocumentSeries { get; set; }

        [JsonProperty("TDSL_eField_DocumentSeriesCancelled")]
        public string TdslEFieldDocumentSeriesCancelled { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumber")]
        public string TdslEFieldDocumentNumber { get; set; }

        [JsonProperty("TDSL_eField_DocumentNumberCancelled")]
        public string TdslEFieldDocumentNumberCancelled { get; set; }

        [JsonProperty("TDSL_eField_NetAmountA")]
        public string TdslEFieldNetAmountA { get; set; }

        [JsonProperty("TDSL_eField_NetAmountB")]
        public string TdslEFieldNetAmountB { get; set; }

        [JsonProperty("TDSL_eField_NetAmountC")]
        public string TdslEFieldNetAmountC { get; set; }

        [JsonProperty("TDSL_eField_NetAmountD")]
        public string TdslEFieldNetAmountD { get; set; }

        [JsonProperty("TDSL_eField_NetAmountE")]
        public string TdslEFieldNetAmountE { get; set; }

        [JsonProperty("TDSL_eField_VatAmountA")]
        public string TdslEFieldVatAmountA { get; set; }

        [JsonProperty("TDSL_eField_VatAmountB")]
        public string TdslEFieldVatAmountB { get; set; }

        [JsonProperty("TDSL_eField_VatAmountC")]
        public string TdslEFieldVatAmountC { get; set; }

        [JsonProperty("TDSL_eField_VatAmountD")]
        public string TdslEFieldVatAmountD { get; set; }

        [JsonProperty("TDSL_eField_TotalAmount")]
        public string TdslEFieldTotalAmount { get; set; }

        [JsonProperty("TDSL_eField_CurrencyCode")]
        public string TdslEFieldCurrencyCode { get; set; }

        [JsonProperty("TDSL_eField_ExemptionVatArticle")]
        public string TdslEFieldExemptionVatArticle { get; set; }

        [JsonProperty("TDSL_eField_TaxDeductionAmount")]
        public string TdslEFieldTaxDeductionAmount { get; set; }

        [JsonProperty("TDSL_eField_RecipientMail")]
        public string TdslEFieldRecipientMail { get; set; }

        [JsonProperty("TDSL_eField_RelativeDocument")]
        public string TdslEFieldRelativeDocument { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_fCancellingSeriesGID")]
        public string CancelAfterSaveFCancellingSeriesGid { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADNumber")]
        public double CancelAfterSaveADNumber { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_Reasoning")]
        public string CancelAfterSaveReasoning { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADRegistrationDate")]
        public string CancelAfterSaveADRegistrationDate { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ADOrigin")]
        public int CancelAfterSaveADOrigin { get; set; }

        [JsonProperty("CANCEL_AFTER_SAVE_ESUCreated")]
        public string CancelAfterSaveEsuCreated { get; set; }
        public double ADCurrencyReversedRate { get; set; }
        public int CreditControl { get; set; }

        [JsonProperty("NS_TCourier_TrackingID")]
        public string NstCourierTrackingId { get; set; }

        [JsonProperty("NS_TCourier_DeliveryDate")]
        public string NstCourierDeliveryDate { get; set; }

        [JsonProperty("NS_TCourier_ReceiveDate")]
        public string NstCourierReceiveDate { get; set; }

        [JsonProperty("NS_TCourier_Price")]
        public double NstCourierPrice { get; set; }

        [JsonProperty("NS_TCourier_LatestState")]
        public string NstCourierLatestState { get; set; }

        [JsonProperty("NS_TCourier_LatestStateDate")]
        public string NstCourierLatestStateDate { get; set; }

        [JsonProperty("NS_TCourier_PickupListCode")]
        public string NstCourierPickupListCode { get; set; }

        [JsonProperty("NS_TCourier_PickupListDescription")]
        public string NstCourierPickupListDescription { get; set; }

        [JsonProperty("NS_TCourier_ProviderCode")]
        public int NstCourierProviderCode { get; set; }

        [JsonProperty("NS_TCourier_ShippingStatus")]
        public int NstCourierShippingStatus { get; set; }

        [JsonProperty("NS_TCourier_JobID")]
        public string NstCourierJobId { get; set; }

        [JsonProperty("fCurrencyRateGroupCode")]
        public string FCurrencyRateGroupCode { get; set; }
        public int CurrencyExchangePriceType { get; set; }
        public string ADRegistrationDatePrev { get; set; }
        public int CompactLineItemsOnSave { get; set; }

        [JsonProperty("AddLIAFromDomainOnRetailMode")]
        public int AddLiaFromDomainOnRetailMode { get; set; }
        public double TotalQtyBaseMU { get; set; }
        public double TotalQtyVariable1 { get; set; }
        public int ForceRelatedItemGeneration { get; set; }
        public string BannerColumn { get; set; }

        [JsonProperty("fPaymentAccountGID")]
        public string FPaymentAccountGid { get; set; }

        [JsonProperty("IGNORE_fPaymentAccountGID")]
        public int IgnoreFPaymentAccountGid { get; set; }

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
        public double BTotalVatValue { get; set; }

        [JsonProperty("bTotalCurrencyVATValue")]
        public double BTotalCurrencyVatValue { get; set; }

        [JsonProperty("bTotalTotalValue")]
        public double BTotalTotalValue { get; set; }

        [JsonProperty("bTotalCurrencyTotalValue")]
        public double BTotalCurrencyTotalValue { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }
        public string ADReferenceCodeList { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fCategoryCode")]
        public string NsfDeliveryPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fDeliveryPersonGID_fGroupCode")]
        public string NsfDeliveryPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fSiteTypeCode")]
        public string NsfDeliverySiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fGroupRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFGroupRegionGroupCode { get; set; }

        [JsonProperty("NS_fDeliverySiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfDeliverySiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fCategoryCode")]
        public string NsfSenderPersonGidfCategoryCode { get; set; }

        [JsonProperty("NS_fSenderPersonGID_fGroupCode")]
        public string NsfSenderPersonGidfGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fSiteTypeCode")]
        public string NsfSenderSiteGidfSiteTypeCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCode { get; set; }

        [JsonProperty("NS_fSenderSiteGID_fRegionGroupCode_fCategoryRegionGroupCode")]
        public string NsfSenderSiteGidfRegionGroupCodeFCategoryRegionGroupCode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjAccountTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADDocumentStateType
    {
        Temporary,
        Commited,
        Posted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADCancelStateType
    {
        Normal,
        Canceling,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADOriginType
    {
        Manual,
        Automatic,
        External
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADPrintedType
    {
        NoPrinting,
        NormalPrinting
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADFiscalPeriodTypeType
    {
        Normal,
        Opening,
        Closing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADTransitionStateType
    {
        None,
        Partial,
        Full
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADLockModeType
    {
        NoLock,
        ReadOnly,
        ByPassFIChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiDocumentAdjustmentObjADProcessStateType
    {
        Initial,
        ToBeProcessed,
        UnderProcess,
        Processed,
        Failed
    }

    public class EntersoftWebApi2OdsModelsEsfiTradeAccountObj
    {
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjTypeType Type { get; set; }
        public string Name { get; set; }
        public string AlternativeName { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fBusinessUnitCode")]
        public string FBusinessUnitCode { get; set; }

        [JsonProperty("fBusinessActivityCode")]
        public string FBusinessActivityCode { get; set; }

        [JsonProperty("fDimension1Code")]
        public string FDimension1Code { get; set; }

        [JsonProperty("fDimension2Code")]
        public string FDimension2Code { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjNatureType Nature { get; set; }
        public string AlternativeCode { get; set; }

        [JsonProperty("KEPYOStatus")]
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjKepyoStatusType KepyoStatus { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjVatStatusType VatStatus { get; set; }
        public string Remarks { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }

        [JsonProperty("fInvoicePolicyGID")]
        public string FInvoicePolicyGid { get; set; }

        [JsonProperty("fTradeAccountPricingCategoryCode")]
        public string FTradeAccountPricingCategoryCode { get; set; }
        public double TradeDiscount { get; set; }

        [JsonProperty("fFamilyCode")]
        public string FFamilyCode { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fAccountManagerGID")]
        public string FAccountManagerGid { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fFixedSupplierGID")]
        public string FFixedSupplierGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fPaymentMethodGID")]
        public string FPaymentMethodGid { get; set; }
        public int OrderPriority { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fUsualRouteCode")]
        public string FUsualRouteCode { get; set; }
        public string AccountStartDate { get; set; }

        [JsonProperty("fGLAccountGID")]
        public string FglAccountGid { get; set; }

        [JsonProperty("fTradeCurrencyCode")]
        public string FTradeCurrencyCode { get; set; }

        [JsonProperty("fCreditControlProfileGID")]
        public string FCreditControlProfileGid { get; set; }
        public double BalanceLimit { get; set; }
        public double OpenBalanceNotesLimit { get; set; }
        public double OpenBalanceTotalNotesLimit { get; set; }

        [JsonProperty("fInterestProfileCode")]
        public string FInterestProfileCode { get; set; }

        [JsonProperty("fCollectorGID")]
        public string FCollectorGid { get; set; }
        public string PaymentDay { get; set; }
        public string FromHours { get; set; }
        public string ToHours { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjMatchingCriteriaType MatchingCriteria { get; set; }

        [JsonProperty("fMatchingFieldGID")]
        public string FMatchingFieldGid { get; set; }

        [JsonProperty("fWareHouseGID")]
        public string FWareHouseGid { get; set; }

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
        public string FglSegCode { get; set; }

        [JsonProperty("fPriceListGID")]
        public string FPriceListGid { get; set; }
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
        public string FBonusGroupGid { get; set; }
        public bool ConsignmentParticipation { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjProposedPaymentTypeType ProposedPaymentType { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjIncludeTaxDocsType IncludeTaxDocs { get; set; }
        public string PrintFormPostfix { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjSolvencyTypeType SolvencyType { get; set; }
        public string SolvencyDate { get; set; }
        public bool PrintHardCopy { get; set; }
        public string InvoiceEMailAddress { get; set; }

        [JsonProperty("fEInvoiceProfileGID")]
        public string FEInvoiceProfileGid { get; set; }

        [JsonProperty("eInvoice")]
        public bool EInvoice { get; set; }
        public string FacebookAccount { get; set; }
        public string TwitterAccount { get; set; }

        [JsonProperty("fIntercessorGID")]
        public string FIntercessorGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfiTradeAccountObjConcernsType Concerns { get; set; }
        public int BarcodeStack { get; set; }
        public bool SubjectToTax { get; set; }
        public bool AllowBackOrders { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("fTradeAccountContractGID")]
        public string FTradeAccountContractGid { get; set; }
        public int HasPerson { get; set; }

        [JsonProperty("MainAddressVATStatus")]
        public int MainAddressVatStatus { get; set; }

        [JsonProperty("NS_Matching")]
        public int NSMatching { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjTypeType
    {
        Customer,
        Supplier,
        Debtor,
        Creditor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjNatureType
    {
        Requirements,
        Obligations
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjKepyoStatusType
    {
        Obligated,
        NotObligated,
        Exemption,
        PublicSector
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjMatchingCriteriaType
    {
        ByAmountLeft,
        ByField,
        NoAutoMatching
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjProposedPaymentTypeType
    {
        ByCheck,
        ByTransfer,
        ByCash,
        ByCreditCard,
        ByPortfolioChecks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjIncludeTaxDocsType
    {
        All,
        OnlyText,
        No,
        OnlyFiscal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjSolvencyTypeType
    {
        Approved,
        BasedOnDate,
        Rejected
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfiTradeAccountObjConcernsType
    {
        Items,
        FixedAssets,
        Services,
        Expenses
    }

    public class EntersoftWebApi2OdsModelsEsfaFixedAssetObj
    {
        public string DetailDescription { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }
        public string InternationalCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }
        public string AlternativeCode { get; set; }
        public string BarCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjItemTypeType ItemType { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGid { get; set; }
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

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fAltMUGID")]
        public string FAltMugid { get; set; }

        [JsonProperty("fWeightMUGID")]
        public string FWeightMugid { get; set; }

        [JsonProperty("fVolumeMUGID")]
        public string FVolumeMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGid { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGid { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGid { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGid { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

        [JsonProperty("fCatalogueItemGID")]
        public string FCatalogueItemGid { get; set; }

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
        public string FCostElementTypeGid { get; set; }

        [JsonProperty("BOMLevel")]
        public int BomLevel { get; set; }
        public EntersoftWebApi2OdsModelsEsfaFixedAssetObjAssetTypeType AssetType { get; set; }
        public bool MainCode { get; set; }

        [JsonProperty("fDepreciationProfileGID")]
        public string FDepreciationProfileGid { get; set; }

        [JsonProperty("fAlternativeDepreciationProfileGID")]
        public string FAlternativeDepreciationProfileGid { get; set; }

        [JsonProperty("fInformativeDepreciationProfileGID")]
        public string FInformativeDepreciationProfileGid { get; set; }
        public bool OutOfUsage { get; set; }

        [JsonProperty("fMainAssetGID")]
        public string FMainAssetGid { get; set; }

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

        [JsonProperty("VATCalculationValue")]
        public int VatCalculationValue { get; set; }

        [JsonProperty("CostIncludedVAT")]
        public bool CostIncludedVat { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fItemAllocationProfileGIDPrev")]
        public string FItemAllocationProfileGidPrev { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("NS_fMainMUCode")]
        public string NsfMainMUCode { get; set; }

        [JsonProperty("NS_fMainMUDescription")]
        public string NsfMainMUDescription { get; set; }

        [JsonProperty("NS_fWeightMUCode")]
        public string NsfWeightMUCode { get; set; }

        [JsonProperty("NS_fWeightMUDescription")]
        public string NsfWeightMUDescription { get; set; }

        [JsonProperty("NS_fAltMUCode")]
        public string NsfAltMUCode { get; set; }

        [JsonProperty("NS_fAltMUDescription")]
        public string NsfAltMUDescription { get; set; }

        [JsonProperty("NS_fVolumeMUCode")]
        public string NsfVolumeMUCode { get; set; }

        [JsonProperty("NS_fVolumeMUDescription")]
        public string NsfVolumeMUDescription { get; set; }

        [JsonProperty("NS_fSupplierGID")]
        public string NsfSupplierGid { get; set; }

        [JsonProperty("NS_fSupplierGID_SupplierItemCode")]
        public string NsfSupplierGidSupplierItemCode { get; set; }

        [JsonProperty("NS_fSupplierGID_SupplierItemDescription")]
        public string NsfSupplierGidSupplierItemDescription { get; set; }

        [JsonProperty("NS_IsAssembly")]
        public int NsisAssembly { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjItemTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsfaFixedAssetObjAssetTypeType
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

    public class EntersoftWebApi2OdsModelsEsgoPersonObj
    {
        public string Name { get; set; }
        public string MultilingualName { get; set; }
        public string FullName { get; set; }
        public string CommonName { get; set; }
        public bool GroupPerson { get; set; }

        [JsonProperty("fParentGID")]
        public string FParentGid { get; set; }

        [JsonProperty("fCompanyKindCode")]
        public string FCompanyKindCode { get; set; }

        [JsonProperty("fActivityCode")]
        public string FActivityCode { get; set; }
        public string ActivityDescription { get; set; }
        public string TaxRegistrationNumber { get; set; }

        [JsonProperty("fTaxOfficeCode")]
        public string FTaxOfficeCode { get; set; }

        [JsonProperty("VATStatus")]
        public EntersoftWebApi2OdsModelsEsgoPersonObjVatStatusType VatStatus { get; set; }

        [JsonProperty("fMainAddressGID")]
        public string FMainAddressGid { get; set; }

        [JsonProperty("fGroupCode")]
        public string FGroupCode { get; set; }

        [JsonProperty("fCategoryCode")]
        public string FCategoryCode { get; set; }

        [JsonProperty("fLanguageCode")]
        public string FLanguageCode { get; set; }
        public string EMailAddress { get; set; }

        [JsonProperty("WEBSite")]
        public string WebSite { get; set; }
        public string Remarks { get; set; }
        public int AccessGroup { get; set; }
        public EntersoftWebApi2OdsModelsEsgoPersonObjPersonKindType PersonKind { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [JsonProperty("fTitleCode")]
        public string FTitleCode { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public EntersoftWebApi2OdsModelsEsgoPersonObjSexType Sex { get; set; }

        [JsonProperty("IDCode")]
        public string IdCode { get; set; }
        public EntersoftWebApi2OdsModelsEsgoPersonObjFamilyStatusType FamilyStatus { get; set; }
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
        public string FCalendarItemGid { get; set; }

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
        public string FReferredPersonGid { get; set; }
        public EntersoftWebApi2OdsModelsEsgoPersonObjPreferredWayOfContractType PreferredWayOfContract { get; set; }
        public string BulStat { get; set; }
        public string TradeRegistrationNumber { get; set; }
        public string PersonalNumericCode { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }

        [JsonProperty("PaymentVATRequired")]
        public bool PaymentVatRequired { get; set; }

        [JsonProperty("EORINumber")]
        public string EoriNumber { get; set; }

        [JsonProperty("SplitOnVATRequired")]
        public bool SplitOnVatRequired { get; set; }

        [JsonProperty("GCP")]
        public string Gcp { get; set; }
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
        public int NSMainAddressVatStatus { get; set; }

        [JsonProperty("DuplicateIBANChecked")]
        public int DuplicateIbanChecked { get; set; }

        [JsonProperty("NS_MainAddress_fManagerNameGID")]
        public string NSMainAddressFManagerNameGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoPersonObjVatStatusType
    {
        Normal,
        Special,
        ForeignEU,
        Foreign,
        Remised
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoPersonObjPersonKindType
    {
        LegalPerson,
        ActualPerson
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoPersonObjSexType
    {
        Unknown,
        Male,
        Female
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoPersonObjFamilyStatusType
    {
        Unmarried,
        Married,
        Divorced,
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoPersonObjPreferredWayOfContractType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unknown,
        [EnumMember(Value = "EMAIL")]
        Email,
        [EnumMember(Value = "FAX")]
        Fax,
        [EnumMember(Value = "PHONE")]
        Phone,
        [EnumMember(Value = "LETTER")]
        Letter
    }

    public class EntersoftWebApi2OdsModelsES00DeviceObj
    {
        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGid { get; set; }

        [JsonProperty("fUserGID")]
        public string FUserGid { get; set; }

        [JsonProperty("fSalesPersonGID")]
        public string FSalesPersonGid { get; set; }

        [JsonProperty("fResourceGID")]
        public string FResourceGid { get; set; }
        public EntersoftWebApi2OdsModelsES00DeviceObjLogTypeType LogType { get; set; }
        public string LastKnownVersion { get; set; }
        public EntersoftWebApi2OdsModelsES00DeviceObjStateType State { get; set; }

        [JsonProperty("fCountryCode")]
        public string FCountryCode { get; set; }

        [JsonProperty("fMobileNetworkGID")]
        public string FMobileNetworkGid { get; set; }
        public string LastSyncDate { get; set; }
        public string LastUpLoadDate { get; set; }
        public string LastDownLoadDate { get; set; }
        public EntersoftWebApi2OdsModelsES00DeviceObjMobileApplicationType MobileApplication { get; set; }
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
        public EntersoftWebApi2OdsModelsES00DeviceObjOperatingSystemType OperatingSystem { get; set; }

        [JsonProperty("fColorCode")]
        public string FColorCode { get; set; }

        [JsonProperty("fCurrentBackupUserGID")]
        public string FCurrentBackupUserGid { get; set; }
        public string NotificationToken { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsES00DeviceObjLogTypeType
    {
        Full,
        Limited,
        Phantom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsES00DeviceObjStateType
    {
        Normal,
        Broken,
        Lost,
        Locked,
        Panic,
        Init
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsES00DeviceObjMobileApplicationType
    {
        SalesForceAutomation,
        ServiceOnSite,
        ESMaster,
        Merchandising,
        [EnumMember(Value = "MIS360")]
        Mis360,
        [EnumMember(Value = "xVan")]
        XVan,
        [EnumMember(Value = "MIS360iPad")]
        Mis360iPad,
        SalesAssistant,
        RequestForApproval,
        [EnumMember(Value = "WMSMobile")]
        WmsMobile,
        MedRep,
        ESAnalyzer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsES00DeviceObjOperatingSystemType
    {
        WindowsMobile,
        WindowsPhone,
        [EnumMember(Value = "iOS")]
        Ios,
        Android,
        [EnumMember(Value = "UWP")]
        Uwp
    }

    public class EntersoftWebApi2OdsModelsEsgoWebUserObj
    {
        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }
        public string Password { get; set; }
        public EntersoftWebApi2OdsModelsEsgoWebUserObjStatusType Status { get; set; }
        public string ActivationToken { get; set; }
        public string TokenExpirationDate { get; set; }

        [JsonProperty("FacebookAuthID")]
        public string FacebookAuthId { get; set; }

        [JsonProperty("TwitterAuthID")]
        public string TwitterAuthId { get; set; }

        [JsonProperty("WindowsLiveAuthID")]
        public string WindowsLiveAuthId { get; set; }

        [JsonProperty("GoogleAuthID")]
        public string GoogleAuthId { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoWebUserObjStatusType
    {
        PendingActivation,
        Active,
        Inactive
    }

    public class EntersoftWebApi2OdsModelsEsgoUserObj
    {
        [JsonProperty("UserID")]
        public string UserId { get; set; }
        public string Name { get; set; }
        public string NTLoginName { get; set; }

        [JsonProperty("fProfileCode")]
        public string FProfileCode { get; set; }
        public string PasswdKey { get; set; }
        public int PasswdKeyExpirationDay { get; set; }
        public EntersoftWebApi2OdsModelsEsgoUserObjSecurityLevelType SecurityLevel { get; set; }
        public bool IsReadOnly { get; set; }

        [JsonProperty("fLanguageCode")]
        public string FLanguageCode { get; set; }

        [JsonProperty("fPersonLinkGID")]
        public string FPersonLinkGid { get; set; }
        public bool Administrator { get; set; }

        [JsonProperty("fCompanySiteGID")]
        public string FCompanySiteGid { get; set; }
        public bool EnableKeyOnSave { get; set; }
        public string KeyOnSave { get; set; }

        [JsonProperty("fInteractionProfileCode")]
        public string FInteractionProfileCode { get; set; }
        public EntersoftWebApi2OdsModelsEsgoUserObjUserTypeType UserType { get; set; }

        [JsonProperty("fB2BAdminGID")]
        public string FB2BAdminGid { get; set; }
        public string InternalPhone { get; set; }
        public bool ChgPwdFlag { get; set; }
        public string ChgPwdDate { get; set; }
        public bool FaultLogins { get; set; }
        public EntersoftWebApi2OdsModelsEsgoUserObjValidAuthMethodsType ValidAuthMethods { get; set; }

        [JsonProperty("LDAPUserID")]
        public string LdapUserId { get; set; }

        [JsonProperty("LDAPUserName")]
        public string LdapUserName { get; set; }
        public EntersoftWebApi2OdsModelsEsgoUserObjAllowAccessFromSourceType AllowAccessFromSource { get; set; }
        public string FiscalCode { get; set; }
        public EntersoftWebApi2OdsModelsEsgoUserObjRequest2FAFromSourceType Request2FAFromSource { get; set; }
        public string AccessDBList { get; set; }

        [JsonProperty("nsPassword")]
        public string NsPassword { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoUserObjSecurityLevelType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoUserObjUserTypeType
    {
        Normal,
        B2BAdmin,
        B2BUser
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoUserObjValidAuthMethodsType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LDAP")]
        Ldap
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoUserObjAllowAccessFromSourceType
    {
        Desktop,
        [EnumMember(Value = "WEBAPI")]
        Webapi,
        [EnumMember(Value = "eCommerce")]
        ECommerce,
        Service
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsgoUserObjRequest2FAFromSourceType
    {
        Desktop,
        [EnumMember(Value = "WEBAPI")]
        Webapi,
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

        [JsonProperty("ESSubscriptionID")]
        public string ESSubscriptionId { get; set; }

        [JsonProperty("ESSubscriptionGID")]
        public string ESSubscriptionGid { get; set; }

        [JsonProperty("ESDatabaseID")]
        public string ESDatabaseId { get; set; }

        [JsonProperty("ESCompanyID")]
        public string ESCompanyId { get; set; }

        [JsonProperty("ESApplicationID")]
        public string ESApplicationId { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [JsonProperty("CallbackURL")]
        public string CallbackUrl { get; set; }
        public EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }

        [JsonProperty("WebAPIToken")]
        public string WebApiToken { get; set; }

        [JsonProperty("RequestURI")]
        public string RequestUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [EnumMember(Value = "NewCRMTaskOfType")]
        NewCrmTaskOfType,
        [EnumMember(Value = "CRMTaskExpired")]
        CrmTaskExpired,
        HighValuePayment,
        HighValuePaymentWithCheck,
        HighValuePaymentTaxes,
        HighValueCollection,
        HighValueCollectionWithCheque,
        StockFallingBelowThreshold,
        RequestToApprove,
        RequestHasBeenApproved
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESBusinessHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        [EnumMember(Value = "RFA")]
        Rfa
    }

    public class EntersoftWebApiInfrastructureESPodHookRegistrationResponse
    {
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponseStateType State { get; set; }
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponsePackageTypeType PackageType { get; set; }
        public string ConveyanceLicencePlate { get; set; }

        [JsonProperty("BranchID")]
        public string BranchId { get; set; }
        public string TradeAccountName { get; set; }
        public string DriverCode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string Location { get; set; }
        public string ModifiedOn { get; set; }
        public string Owner { get; set; }

        [JsonProperty("ESSubscriptionID")]
        public string ESSubscriptionId { get; set; }

        [JsonProperty("ESSubscriptionGID")]
        public string ESSubscriptionGid { get; set; }

        [JsonProperty("ESDatabaseID")]
        public string ESDatabaseId { get; set; }

        [JsonProperty("ESCompanyID")]
        public string ESCompanyId { get; set; }

        [JsonProperty("ESApplicationID")]
        public string ESApplicationId { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [JsonProperty("CallbackURL")]
        public string CallbackUrl { get; set; }
        public EntersoftWebApiInfrastructureESPodHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }

        [JsonProperty("WebAPIToken")]
        public string WebApiToken { get; set; }

        [JsonProperty("RequestURI")]
        public string RequestUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponseStateType
    {
        Initial,
        Arrived,
        Started,
        Delivered,
        Cancelled,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponsePackageTypeType
    {
        MasterPackage,
        Package,
        Pallet,
        Sorting,
        Transport,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESPodHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        [EnumMember(Value = "RFA")]
        Rfa
    }

    public class EntersoftWebApiInfrastructureEsrfaHookRegistrationResponse
    {
        public string RequestedBy { get; set; }
        public EntersoftWebApiInfrastructureEsrfaHookRegistrationResponsePriorityType Priority { get; set; }
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

        [JsonProperty("ESSubscriptionID")]
        public string ESSubscriptionId { get; set; }

        [JsonProperty("ESSubscriptionGID")]
        public string ESSubscriptionGid { get; set; }

        [JsonProperty("ESDatabaseID")]
        public string ESDatabaseId { get; set; }

        [JsonProperty("ESCompanyID")]
        public string ESCompanyId { get; set; }

        [JsonProperty("ESApplicationID")]
        public string ESApplicationId { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [JsonProperty("CallbackURL")]
        public string CallbackUrl { get; set; }
        public EntersoftWebApiInfrastructureEsrfaHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }

        [JsonProperty("WebAPIToken")]
        public string WebApiToken { get; set; }

        [JsonProperty("RequestURI")]
        public string RequestUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureEsrfaHookRegistrationResponsePriorityType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureEsrfaHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        [EnumMember(Value = "RFA")]
        Rfa
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

        [JsonProperty("ESSubscriptionID")]
        public string ESSubscriptionId { get; set; }

        [JsonProperty("ESSubscriptionGID")]
        public string ESSubscriptionGid { get; set; }

        [JsonProperty("ESDatabaseID")]
        public string ESDatabaseId { get; set; }

        [JsonProperty("ESCompanyID")]
        public string ESCompanyId { get; set; }

        [JsonProperty("ESApplicationID")]
        public string ESApplicationId { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [JsonProperty("CallbackURL")]
        public string CallbackUrl { get; set; }
        public EntersoftWebApiInfrastructureESEntityHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }

        [JsonProperty("WebAPIToken")]
        public string WebApiToken { get; set; }

        [JsonProperty("RequestURI")]
        public string RequestUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        [EnumMember(Value = "ES00SSASParameters")]
        ES00SsasParameters,
        ES00WordGroup,
        ES00ZProperty,
        [EnumMember(Value = "ESBGAllocationProfile")]
        EsbgAllocationProfile,
        [EnumMember(Value = "ESBGBudgetDimensionAllocationProfile")]
        EsbgBudgetDimensionAllocationProfile,
        [EnumMember(Value = "ESBGBudgetSheet")]
        EsbgBudgetSheet,
        [EnumMember(Value = "ESBGBudgetSheetProfile")]
        EsbgBudgetSheetProfile,
        [EnumMember(Value = "ESBGZBudgetCashAccountGroup")]
        EsbgzBudgetCashAccountGroup,
        [EnumMember(Value = "ESBGZBudgetItemGroup")]
        EsbgzBudgetItemGroup,
        [EnumMember(Value = "ESBGZBudgetSalespersonGroup")]
        EsbgzBudgetSalespersonGroup,
        [EnumMember(Value = "ESBGZBudgetTradeAccountGroup")]
        EsbgzBudgetTradeAccountGroup,
        [EnumMember(Value = "ESCOCostElementType")]
        EscoCostElementType,
        [EnumMember(Value = "ESCOCostingFolder")]
        EscoCostingFolder,
        [EnumMember(Value = "ESCOLineCostAnalysis")]
        EscoLineCostAnalysis,
        [EnumMember(Value = "ESFACommercialProfile")]
        EsfaCommercialProfile,
        [EnumMember(Value = "ESFADepreciationProfile")]
        EsfaDepreciationProfile,
        [EnumMember(Value = "ESFAFixedAsset")]
        EsfaFixedAsset,
        [EnumMember(Value = "ESFAItemControlPolicy")]
        EsfaItemControlPolicy,
        [EnumMember(Value = "ESFARevaluationProfile")]
        EsfaRevaluationProfile,
        [EnumMember(Value = "ESFIBankImport")]
        EsfiBankImport,
        [EnumMember(Value = "ESFICardRateProfile")]
        EsfiCardRateProfile,
        [EnumMember(Value = "ESFICashAccount")]
        EsfiCashAccount,
        [EnumMember(Value = "ESFICDCommercialProfile")]
        EsficdCommercialProfile,
        [EnumMember(Value = "ESFICheckListProfile")]
        EsfiCheckListProfile,
        [EnumMember(Value = "ESFICommercialProfileItem")]
        EsfiCommercialProfileItem,
        [EnumMember(Value = "ESFICommissionProfile")]
        EsfiCommissionProfile,
        [EnumMember(Value = "ESFICondition")]
        EsfiCondition,
        [EnumMember(Value = "ESFIConditionTemplate")]
        EsfiConditionTemplate,
        [EnumMember(Value = "ESFICreditCardType")]
        EsfiCreditCardType,
        [EnumMember(Value = "ESFICreditControlProfile")]
        EsfiCreditControlProfile,
        [EnumMember(Value = "ESFICreditor")]
        EsfiCreditor,
        [EnumMember(Value = "ESFICreditTurnOverProfile")]
        EsfiCreditTurnOverProfile,
        [EnumMember(Value = "ESFICreditTurnOverProfileEntry")]
        EsfiCreditTurnOverProfileEntry,
        [EnumMember(Value = "ESFICustomer")]
        EsfiCustomer,
        [EnumMember(Value = "ESFIDebtor")]
        EsfiDebtor,
        [EnumMember(Value = "ESFIDeclarationEntry")]
        EsfiDeclarationEntry,
        [EnumMember(Value = "ESFIDeclarationType")]
        EsfiDeclarationType,
        [EnumMember(Value = "ESFIDistributionDispatch")]
        EsfiDistributionDispatch,
        [EnumMember(Value = "ESFIDocSeriesAttributes")]
        EsfiDocSeriesAttributes,
        [EnumMember(Value = "ESFIDocumentAccessRightProfile")]
        EsfiDocumentAccessRightProfile,
        [EnumMember(Value = "ESFIDocumentAdjustment")]
        EsfiDocumentAdjustment,
        [EnumMember(Value = "ESFIDocumentCash")]
        EsfiDocumentCash,
        [EnumMember(Value = "ESFIDocumentSeries")]
        EsfiDocumentSeries,
        [EnumMember(Value = "ESFIDocumentStock")]
        EsfiDocumentStock,
        [EnumMember(Value = "ESFIDocumentTrade")]
        EsfiDocumentTrade,
        [EnumMember(Value = "ESFIDocumentTransition")]
        EsfiDocumentTransition,
        [EnumMember(Value = "ESFIDocumentUpdateProfile")]
        EsfiDocumentUpdateProfile,
        [EnumMember(Value = "ESFIDocumentUpdateProfileGL")]
        EsfiDocumentUpdateProfileGL,
        [EnumMember(Value = "ESFIEInvoiceProfile")]
        EsfieInvoiceProfile,
        [EnumMember(Value = "ESFIFieldPropertiesProfile")]
        EsfiFieldPropertiesProfile,
        [EnumMember(Value = "ESFIFillerProfile")]
        EsfiFillerProfile,
        [EnumMember(Value = "ESFIFinancialAgreement")]
        EsfiFinancialAgreement,
        [EnumMember(Value = "ESFIFinancialDeclaration")]
        EsfiFinancialDeclaration,
        [EnumMember(Value = "ESFIInnerDistributionEntry")]
        EsfiInnerDistributionEntry,
        [EnumMember(Value = "ESFIIntrastatEntry")]
        EsfiIntrastatEntry,
        [EnumMember(Value = "ESFIInvoicePolicy")]
        EsfiInvoicePolicy,
        [EnumMember(Value = "ESFIInvoicePolicyAction")]
        EsfiInvoicePolicyAction,
        [EnumMember(Value = "ESFIItem")]
        EsfiItem,
        [EnumMember(Value = "ESFIItemAllocationProfile")]
        EsfiItemAllocationProfile,
        [EnumMember(Value = "ESFIItemCategories")]
        EsfiItemCategories,
        [EnumMember(Value = "ESFIItemControlPolicy")]
        EsfiItemControlPolicy,
        [EnumMember(Value = "ESFIItemExpense")]
        EsfiItemExpense,
        [EnumMember(Value = "ESFIItemExpenses")]
        EsfiItemExpenses,
        [EnumMember(Value = "ESFIItemFamily")]
        EsfiItemFamily,
        [EnumMember(Value = "ESFIItemPriceHistoryTemplate")]
        EsfiItemPriceHistoryTemplate,
        [EnumMember(Value = "ESFIItemService")]
        EsfiItemService,
        [EnumMember(Value = "ESFIItemSubCategory")]
        EsfiItemSubCategory,
        [EnumMember(Value = "ESFIItemSubfamily")]
        EsfiItemSubfamily,
        [EnumMember(Value = "ESFIKEPYOEntry")]
        EsfikepyoEntry,
        [EnumMember(Value = "ESFIMeasure")]
        EsfiMeasure,
        [EnumMember(Value = "ESFIMobileDocumentType")]
        EsfiMobileDocumentType,
        [EnumMember(Value = "ESFIMyDataInvoice")]
        EsfiMyDataInvoice,
        [EnumMember(Value = "ESFINote")]
        EsfiNote,
        [EnumMember(Value = "ESFIOIMatchingProfile")]
        EsfioiMatchingProfile,
        [EnumMember(Value = "ESFIOpenItemsForDateProposalHeader")]
        EsfiOpenItemsForDateProposalHeader,
        [EnumMember(Value = "ESFIPaymentMethod")]
        EsfiPaymentMethod,
        [EnumMember(Value = "ESFIPricelist")]
        EsfiPricelist,
        [EnumMember(Value = "ESFIPricelistEditor")]
        EsfiPricelistEditor,
        [EnumMember(Value = "ESFISalesPerson")]
        EsfiSalesPerson,
        [EnumMember(Value = "ESFISpecialAccount")]
        EsfiSpecialAccount,
        [EnumMember(Value = "ESFISpecialAccountGroup")]
        EsfiSpecialAccountGroup,
        [EnumMember(Value = "ESFISupplier")]
        EsfiSupplier,
        [EnumMember(Value = "ESFISupplierExpert")]
        EsfiSupplierExpert,
        [EnumMember(Value = "ESFITCourier")]
        EsfitCourier,
        [EnumMember(Value = "ESFITradeAccount")]
        EsfiTradeAccount,
        [EnumMember(Value = "ESFITradeAccountContract")]
        EsfiTradeAccountContract,
        [EnumMember(Value = "ESFITradeAccountContractType")]
        EsfiTradeAccountContractType,
        [EnumMember(Value = "ESFITransitionProfile")]
        EsfiTransitionProfile,
        [EnumMember(Value = "ESFITransportPlan")]
        EsfiTransportPlan,
        [EnumMember(Value = "ESFIVoucher")]
        EsfiVoucher,
        [EnumMember(Value = "ESFIVoucherPromotionProfile")]
        EsfiVoucherPromotionProfile,
        [EnumMember(Value = "ESFIWHAccessList")]
        EsfiwhAccessList,
        [EnumMember(Value = "ESFIZAccountPostingDef")]
        EsfizAccountPostingDef,
        [EnumMember(Value = "ESFIZElectronicTransactionsProfile")]
        EsfizElectronicTransactionsProfile,
        [EnumMember(Value = "ESFIZInterestProfile")]
        EsfizInterestProfile,
        [EnumMember(Value = "ESFIZItemCategory")]
        EsfizItemCategory,
        [EnumMember(Value = "ESFIZItemFamily")]
        EsfizItemFamily,
        [EnumMember(Value = "ESFIZItemSubCategory")]
        EsfizItemSubCategory,
        [EnumMember(Value = "ESFIZItemSubFamily")]
        EsfizItemSubFamily,
        [EnumMember(Value = "ESFIZVATExemptionReasoning")]
        EsfizvatExemptionReasoning,
        [EnumMember(Value = "ESGLAccount")]
        EsglAccount,
        [EnumMember(Value = "ESGLAccountingDocumentTemplate")]
        EsglAccountingDocumentTemplate,
        [EnumMember(Value = "ESGLAccountingDocumentType")]
        EsglAccountingDocumentType,
        [EnumMember(Value = "ESGLAllocationProfile")]
        EsglAllocationProfile,
        [EnumMember(Value = "ESGLJournal")]
        EsglJournal,
        [EnumMember(Value = "ESGLLedgerEntry")]
        EsglLedgerEntry,
        ESGlobalBlueDocument,
        [EnumMember(Value = "ESGOAreaMap")]
        EsgoAreaMap,
        [EnumMember(Value = "ESGOColumnsSeq")]
        EsgoColumnsSeq,
        [EnumMember(Value = "ESGOCompany")]
        EsgoCompany,
        [EnumMember(Value = "ESGOCompanyBusinessActivityCodes")]
        EsgoCompanyBusinessActivityCodes,
        [EnumMember(Value = "ESGOCurrency")]
        EsgoCurrency,
        [EnumMember(Value = "ESGOCurrencyExchangeRate")]
        EsgoCurrencyExchangeRate,
        [EnumMember(Value = "ESGOLegalPerson")]
        EsgoLegalPerson,
        [EnumMember(Value = "ESGOMetric")]
        EsgoMetric,
        [EnumMember(Value = "ESGOMetricActual")]
        EsgoMetricActual,
        [EnumMember(Value = "ESGOMetricSet")]
        EsgoMetricSet,
        [EnumMember(Value = "ESGOOrganizationalUnit")]
        EsgoOrganizationalUnit,
        [EnumMember(Value = "ESGOPerson")]
        EsgoPerson,
        [EnumMember(Value = "ESGOPhysicalPerson")]
        EsgoPhysicalPerson,
        [EnumMember(Value = "ESGOPrinter")]
        EsgoPrinter,
        [EnumMember(Value = "ESGOProject")]
        EsgoProject,
        [EnumMember(Value = "ESGOReport")]
        EsgoReport,
        [EnumMember(Value = "ESGOScale")]
        EsgoScale,
        [EnumMember(Value = "ESGOScheduledJob")]
        EsgoScheduledJob,
        [EnumMember(Value = "ESGOScript")]
        EsgoScript,
        [EnumMember(Value = "ESGOSeasonCalendar")]
        EsgoSeasonCalendar,
        [EnumMember(Value = "ESGOSegmentSequence")]
        EsgoSegmentSequence,
        [EnumMember(Value = "ESGOServiceProfile")]
        EsgoServiceProfile,
        [EnumMember(Value = "ESGOShift")]
        EsgoShift,
        [EnumMember(Value = "ESGOUser")]
        EsgoUser,
        [EnumMember(Value = "ESGOVATCategoryMapping")]
        EsgovatCategoryMapping,
        [EnumMember(Value = "ESGOWebUser")]
        EsgoWebUser,
        [EnumMember(Value = "ESGOWorkingCalendar")]
        EsgoWorkingCalendar,
        [EnumMember(Value = "ESGOWorkingCalendarException")]
        EsgoWorkingCalendarException,
        [EnumMember(Value = "ESGOWorkstation")]
        EsgoWorkstation,
        [EnumMember(Value = "ESGOZBusinessActivity")]
        EsgozBusinessActivity,
        [EnumMember(Value = "ESGOZBusinessUnit")]
        EsgozBusinessUnit,
        [EnumMember(Value = "ESGOZDimension1")]
        EsgozDimension1,
        [EnumMember(Value = "ESGOZDimension2")]
        EsgozDimension2,
        [EnumMember(Value = "ESGOZInteractionProfile")]
        EsgozInteractionProfile,
        [EnumMember(Value = "ESMLModel")]
        EsmlModel,
        [EnumMember(Value = "ESMLModelGroup")]
        EsmlModelGroup,
        [EnumMember(Value = "ESMMBOM")]
        Esmmbom,
        [EnumMember(Value = "ESMMCatalogueItem")]
        EsmmCatalogueItem,
        [EnumMember(Value = "ESMMCommercialProfile")]
        EsmmCommercialProfile,
        [EnumMember(Value = "ESMMDeposition")]
        EsmmDeposition,
        [EnumMember(Value = "ESMMItemControlPolicy")]
        EsmmItemControlPolicy,
        [EnumMember(Value = "ESMMItemSellingPrice")]
        EsmmItemSellingPrice,
        [EnumMember(Value = "ESMMLot")]
        EsmmLot,
        [EnumMember(Value = "ESMMMaterialRequirement")]
        EsmmMaterialRequirement,
        [EnumMember(Value = "ESMMMaterialRequirementPlan")]
        EsmmMaterialRequirementPlan,
        [EnumMember(Value = "ESMMMaterialRequirementPlanWithReqs")]
        EsmmMaterialRequirementPlanWithReqs,
        [EnumMember(Value = "ESMMPersonItem")]
        EsmmPersonItem,
        [EnumMember(Value = "ESMMPhaseRouting")]
        EsmmPhaseRouting,
        [EnumMember(Value = "ESMMProductionLeadTimes")]
        EsmmProductionLeadTimes,
        [EnumMember(Value = "ESMMProductionPlan")]
        EsmmProductionPlan,
        [EnumMember(Value = "ESMMProductionPlanDemand")]
        EsmmProductionPlanDemand,
        [EnumMember(Value = "ESMMProductionPlanItem")]
        EsmmProductionPlanItem,
        [EnumMember(Value = "ESMMProductionPlanWithDemands")]
        EsmmProductionPlanWithDemands,
        [EnumMember(Value = "ESMMSerialNumber")]
        EsmmSerialNumber,
        [EnumMember(Value = "ESMMSIMURelation")]
        EsmmsimuRelation,
        [EnumMember(Value = "ESMMSortiment")]
        EsmmSortiment,
        [EnumMember(Value = "ESMMStockDimSet")]
        EsmmStockDimSet,
        [EnumMember(Value = "ESMMStockDimSetMap")]
        EsmmStockDimSetMap,
        [EnumMember(Value = "ESMMStockItem")]
        EsmmStockItem,
        [EnumMember(Value = "ESMMStockOrderModel")]
        EsmmStockOrderModel,
        [EnumMember(Value = "ESMMStockOrderPlan")]
        EsmmStockOrderPlan,
        [EnumMember(Value = "ESMMStockProposalComposition")]
        EsmmStockProposalComposition,
        [EnumMember(Value = "ESMMStockProposalGroup")]
        EsmmStockProposalGroup,
        [EnumMember(Value = "ESMMStorageLocation")]
        EsmmStorageLocation,
        [EnumMember(Value = "ESMMStorageLocationPrinter")]
        EsmmStorageLocationPrinter,
        [EnumMember(Value = "ESMMStorageLocationProfile")]
        EsmmStorageLocationProfile,
        [EnumMember(Value = "ESMMStorageLocationTree")]
        EsmmStorageLocationTree,
        [EnumMember(Value = "ESMMValidStockDimensionsProfile")]
        EsmmValidStockDimensionsProfile,
        [EnumMember(Value = "ESMMZBCProcessingType")]
        EsmmzbcProcessingType,
        [EnumMember(Value = "ESMMZIntrastatCode")]
        EsmmzIntrastatCode,
        [EnumMember(Value = "ESMMZMeasurementUnit")]
        EsmmzMeasurementUnit,
        ESPlanetDocument,
        [EnumMember(Value = "ESTMABCClassificationModel")]
        EstmabcClassificationModel,
        [EnumMember(Value = "ESTMCampaign")]
        EstmCampaign,
        [EnumMember(Value = "ESTMContractTerm")]
        EstmContractTerm,
        [EnumMember(Value = "ESTMInteraction")]
        EstmInteraction,
        [EnumMember(Value = "ESTMMobileTaskType")]
        EstmMobileTaskType,
        [EnumMember(Value = "ESTMNewsletterRecipient")]
        EstmNewsletterRecipient,
        [EnumMember(Value = "ESTMObjectRating")]
        EstmObjectRating,
        [EnumMember(Value = "ESTMOpportunity")]
        EstmOpportunity,
        [EnumMember(Value = "ESTMResource")]
        EstmResource,
        [EnumMember(Value = "ESTMRFMModel")]
        EstmrfmModel,
        [EnumMember(Value = "ESTMRFMResponseModel")]
        EstmrfmResponseModel,
        [EnumMember(Value = "ESTMServiceDefinition")]
        EstmServiceDefinition,
        [EnumMember(Value = "ESTMServiceRequest")]
        EstmServiceRequest,
        [EnumMember(Value = "ESTMSMAccount")]
        EstmsmAccount,
        [EnumMember(Value = "ESTMSMActivity")]
        EstmsmActivity,
        [EnumMember(Value = "ESTMSMCompanyAccount")]
        EstmsmCompanyAccount,
        [EnumMember(Value = "ESTMSMRawObject")]
        EstmsmRawObject,
        [EnumMember(Value = "ESTMStatusCollection")]
        EstmStatusCollection,
        [EnumMember(Value = "ESTMTask")]
        EstmTask,
        [EnumMember(Value = "ESTMTaskCategory")]
        EstmTaskCategory,
        [EnumMember(Value = "ESTMTaskLite")]
        EstmTaskLite,
        [EnumMember(Value = "ESTMTaskType")]
        EstmTaskType,
        [EnumMember(Value = "ESTRPosition")]
        EstrPosition,
        [EnumMember(Value = "ESTRTerritory")]
        EstrTerritory,
        [EnumMember(Value = "ESTRTerritoryBudget")]
        EstrTerritoryBudget,
        [EnumMember(Value = "ESTRTerritoryBudgetTemplate")]
        EstrTerritoryBudgetTemplate,
        [EnumMember(Value = "ESTRTerritoryHierarchy")]
        EstrTerritoryHierarchy,
        [EnumMember(Value = "ESTRTerritoryRulePeriod")]
        EstrTerritoryRulePeriod,
        [EnumMember(Value = "ESWMAction")]
        EswmAction,
        [EnumMember(Value = "ESWMActionType")]
        EswmActionType,
        [EnumMember(Value = "ESWMActionTypeReport")]
        EswmActionTypeReport,
        [EnumMember(Value = "ESWMCancellationDispositionReasonMap")]
        EswmCancellationDispositionReasonMap,
        [EnumMember(Value = "ESWMCancellationReservationReasonMap")]
        EswmCancellationReservationReasonMap,
        [EnumMember(Value = "ESWMContainer")]
        EswmContainer,
        [EnumMember(Value = "ESWMContainerControlPolicy")]
        EswmContainerControlPolicy,
        [EnumMember(Value = "ESWMContainerType")]
        EswmContainerType,
        [EnumMember(Value = "ESWMDepositor")]
        EswmDepositor,
        [EnumMember(Value = "ESWMItemControlPolicy")]
        EswmItemControlPolicy,
        [EnumMember(Value = "ESWMPhaseZoneMapping")]
        EswmPhaseZoneMapping,
        [EnumMember(Value = "ESWMRequest")]
        EswmRequest,
        [EnumMember(Value = "ESWMRequestStringFieldMap")]
        EswmRequestStringFieldMap,
        [EnumMember(Value = "ESWMRequestType")]
        EswmRequestType,
        [EnumMember(Value = "ESWMReservationReasonWHMap")]
        EswmReservationReasonWHMap,
        [EnumMember(Value = "ESWMShipment")]
        EswmShipment,
        [EnumMember(Value = "ESWMStepOperation")]
        EswmStepOperation,
        [EnumMember(Value = "ESWMTransportAction")]
        EswmTransportAction,
        [EnumMember(Value = "ESWMTransportRequest")]
        EswmTransportRequest,
        [EnumMember(Value = "ESWMWorkPackage")]
        EswmWorkPackage,
        [EnumMember(Value = "ESWMWorkPackageType")]
        EswmWorkPackageType,
        [EnumMember(Value = "ESWPActualTask")]
        EswpActualTask,
        [EnumMember(Value = "ESWPActualTaskEntry")]
        EswpActualTaskEntry,
        [EnumMember(Value = "ESWPTaskRequest")]
        EswpTaskRequest,
        [EnumMember(Value = "ESWPWorkPackage")]
        EswpWorkPackage
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESEntityHookRegistrationResponseEventTypeType
    {
        Create,
        Update,
        Delete,
        CreateOrUpdate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESEntityHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        [EnumMember(Value = "RFA")]
        Rfa
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

        [JsonProperty("ESSubscriptionID")]
        public string ESSubscriptionId { get; set; }

        [JsonProperty("ESSubscriptionGID")]
        public string ESSubscriptionGid { get; set; }

        [JsonProperty("ESDatabaseID")]
        public string ESDatabaseId { get; set; }

        [JsonProperty("ESCompanyID")]
        public string ESCompanyId { get; set; }

        [JsonProperty("ESApplicationID")]
        public string ESApplicationId { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [JsonProperty("CallbackURL")]
        public string CallbackUrl { get; set; }
        public EntersoftWebApiInfrastructureESSystemHookRegistrationResponseHClassType HClass { get; set; }

        [JsonProperty("dType")]
        public string DType { get; set; }

        [JsonProperty("WebAPIToken")]
        public string WebApiToken { get; set; }

        [JsonProperty("RequestURI")]
        public string RequestUri { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiInfrastructureESSystemHookRegistrationResponseHClassType
    {
        Entity,
        Custom,
        System,
        Business,
        Pod,
        [EnumMember(Value = "RFA")]
        Rfa
    }

    public class EntersoftWebApi2OdsModelsEsmlModelObj
    {
        public EntersoftWebApi2OdsModelsEsmlModelObjModelClassType ModelClass { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjRegressionType Regression { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjStatusType Status { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjSubSystemType SubSystem { get; set; }

        [JsonProperty("fRuleSetGID")]
        public string FRuleSetGid { get; set; }

        [JsonProperty("fForecastRuleSetGID")]
        public string FForecastRuleSetGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjAlgorithmType Algorithm { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjMeasureType Measure { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjAggregateType Aggregate { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjTransactionGroupsType TransactionGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjCalendarGroupsType CalendarGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjCompanyGroupsType CompanyGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjBranchGroupsType BranchGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountGroupsType TradeAccountGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjItemGroupsType ItemGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjCalendarFeaturesType CalendarFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjCompanyFeaturesType CompanyFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjBranchFeaturesType BranchFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountFeaturesType TradeAccountFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjItemFeaturesType ItemFeatures { get; set; }
        public double TrainingPercentage { get; set; }
        public int LagWindowSize { get; set; }
        public int ForecastingFutureSteps { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjPersonGroupsType PersonGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjPersonFeaturesType PersonFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjSiteGroupsType SiteGroups { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjSiteFeaturesType SiteFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjOpportunityFeaturesType OpportunityFeatures { get; set; }

        [JsonProperty("TransactionKPIFeatures")]
        public EntersoftWebApi2OdsModelsEsmlModelObjTransactionKpiFeaturesType TransactionKpiFeatures { get; set; }

        [JsonProperty("fLabel1ScaleGID")]
        public string FLabel1ScaleGid { get; set; }

        [JsonProperty("fLabel2ScaleGID")]
        public string FLabel2ScaleGid { get; set; }

        [JsonProperty("fLabel3ScaleGID")]
        public string FLabel3ScaleGid { get; set; }
        public double FeatureImportancePercentage { get; set; }
        public string PositiveLabel1 { get; set; }
        public double ClassificationPercentage { get; set; }
        public bool BalanceClassWeights { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjBinningStrategyType BinningStrategy { get; set; }
        public int NumberOfBins { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjCompanyFeaturesGenerationType CompanyFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjBranchFeaturesGenerationType BranchFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjPersonFeaturesGenerationType PersonFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjPersonSiteFeaturesGenerationType PersonSiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjPersonPropertyFeaturesGenerationType PersonPropertyFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountFeaturesGenerationType TradeAccountFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountSiteFeaturesGenerationType TradeAccountSiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjSiteFeaturesGenerationType SiteFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjOpportunityFeaturesGenerationType OpportunityFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjNumericFeaturesType NumericFeatures { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjItemFeaturesGenerationType ItemFeaturesGeneration { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjFeatureImportanceAlgorithmType FeatureImportanceAlgorithm { get; set; }
        public double RareFeatureValueThreshold { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjHyperParamOptType HyperParamOpt { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjBinningNumStrategyType BinningNumStrategy { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjFeatureCorrelationNumAlgortithmType FeatureCorrelationNumAlgortithm { get; set; }
        public EntersoftWebApi2OdsModelsEsmlModelObjFeatureCorrelationCatAlgortithmType FeatureCorrelationCatAlgortithm { get; set; }
        public double FeatureCorrelationDropThreshold { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjModelClassType
    {
        NotSpecified,
        Regression,
        BinaryClassification,
        Classification,
        Clustering,
        Recommendation
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjRegressionType
    {
        NotSpecified,
        TimeSeries,
        Casual
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjStatusType
    {
        Initial,
        DataLoaded,
        Trained,
        Published,
        Training
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjSubSystemType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjAlgorithmType
    {
        NotSpecified,
        [EnumMember(Value = "B_Persistence")]
        BPersistence,
        [EnumMember(Value = "S_SES")]
        SSes,
        [EnumMember(Value = "S_HWES")]
        SHwes,
        [EnumMember(Value = "S_ARIMA")]
        SArima,
        [EnumMember(Value = "ML_LINREG")]
        MlLinreg,
        [EnumMember(Value = "ML_RF")]
        MlRf,
        [EnumMember(Value = "ML_SVR")]
        MlSvr,
        [EnumMember(Value = "ML_Prophet")]
        MLProphet,
        [EnumMember(Value = "NN_LSTM")]
        NnLstm,
        [EnumMember(Value = "ML_SVM")]
        MlSvm,
        [EnumMember(Value = "ML_LOGREGSGD")]
        MlLogregsgd,
        [EnumMember(Value = "ML_XGBOOST")]
        MlXgboost,
        [EnumMember(Value = "ML_LIGHTGBM")]
        MlLightgbm,
        [EnumMember(Value = "ML_CATBOOST")]
        MlCatboost
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjMeasureType
    {
        NotSpecified,
        Turnover,
        Quantity,
        Transactions
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjAggregateType
    {
        NotSpecified,
        Sum,
        Min,
        Max,
        Avg,
        Count
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTransactionGroupsType
    {
        Date,
        [EnumMember(Value = "TransactionID")]
        TransactionId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjCalendarGroupsType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjCompanyGroupsType
    {
        Company,
        Project,
        Activity,
        BusinessUnit,
        Dimension1,
        Dimension2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjBranchGroupsType
    {
        Branch,
        Country,
        District,
        City,
        Region,
        Area
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountGroupsType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjItemGroupsType
    {
        Item,
        Family,
        Group,
        Category,
        SubCategory
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjCalendarFeaturesType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjCompanyFeaturesType
    {
        Company,
        Project,
        Activity,
        BusinessUnit,
        Dimension1,
        Dimension2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjBranchFeaturesType
    {
        Branch,
        Country,
        District,
        City,
        Region,
        Area
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountFeaturesType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjItemFeaturesType
    {
        Item,
        Family,
        Group,
        Category,
        SubCategory
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjPersonGroupsType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjPersonFeaturesType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjSiteGroupsType
    {
        Site,
        Country,
        District,
        City,
        Region,
        Area
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjSiteFeaturesType
    {
        Site,
        Country,
        District,
        City,
        Region,
        Area
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjOpportunityFeaturesType
    {
        Lead,
        LeadSource,
        Revenue,
        Resource,
        SalesPhase,
        Competitor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTransactionKpiFeaturesType
    {
        Turnover,
        Amount,
        Transactions,
        NumberOfItems,
        NumberOfItemHierarchyCategories
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjBinningStrategyType
    {
        NoBinning,
        EqualWidth,
        EqualFrequency,
        KMeans,
        DecisionTree
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjCompanyFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjBranchFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjPersonFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjPersonSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjPersonPropertyFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjTradeAccountSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjSiteFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjOpportunityFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjNumericFeaturesType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjItemFeaturesGenerationType
    {
        SelectedFeatures,
        DerivedFeature,
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjFeatureImportanceAlgorithmType
    {
        RandomForest,
        PearsonCorrCoef,
        PearsonChiSquareCoef,
        RecursiveFeatureElimination
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjHyperParamOptType
    {
        Default,
        GridSearch,
        RandomSearch,
        Bayesian
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjBinningNumStrategyType
    {
        None,
        Dougherty,
        Silhouette,
        BayesianBlocks
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjFeatureCorrelationNumAlgortithmType
    {
        PearsonCorrCoef,
        Spearman
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmlModelObjFeatureCorrelationCatAlgortithmType
    {
        CramersV
    }

    public class EntersoftWebApi2OdsModelsEsmmSerialNumberObj
    {
        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }
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
        public EntersoftWebApi2OdsModelsEsmmSerialNumberObjPositionTypeType PositionType { get; set; }

        [JsonProperty("fPositionGID")]
        public string FPositionGid { get; set; }
        public string PositionName { get; set; }

        [JsonProperty("fPositionSiteGID")]
        public string FPositionSiteGid { get; set; }
        public string PositionSiteName { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fLotGID")]
        public string FLotGid { get; set; }

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
        public string FItemMugid { get; set; }
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
        public string FContactPersonGid { get; set; }
        public string PhysicalLocation { get; set; }

        [JsonProperty("fRootSerialNumberGID")]
        public string FRootSerialNumberGid { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGid { get; set; }

        [JsonProperty("fContainerGID")]
        public string FContainerGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fTradeAccountSiteGID")]
        public string FTradeAccountSiteGid { get; set; }

        [JsonProperty("fPackageGID")]
        public string FPackageGid { get; set; }

        [JsonProperty("fMasterPackageGID")]
        public string FMasterPackageGid { get; set; }

        [JsonProperty("fPalletGID")]
        public string FPalletGid { get; set; }

        [JsonProperty("fTransportGID")]
        public string FTransportGid { get; set; }

        [JsonProperty("fSortingGID")]
        public string FSortingGid { get; set; }
        public bool LocationInWH { get; set; }

        [JsonProperty("vPositionName")]
        public string VPositionName { get; set; }

        [JsonProperty("vPositionSiteName")]
        public string VPositionSiteName { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmSerialNumberObjPositionTypeType
    {
        TradeAccount,
        CompanySite,
        Person,
        OneTime,
        SerialNumber,
        ThirdWH
    }

    public class EntersoftWebApi2OdsModelsEsmmCatalogueItemObj
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
        public string FGeneralCatalogueItemGid { get; set; }
        public double SalesRetailPrice { get; set; }

        [JsonProperty("SalesRetailPriceIncludedVAT")]
        public bool SalesRetailPriceIncludedVat { get; set; }
        public double PurchasesPrice { get; set; }

        [JsonProperty("PurchasesPriceIncludedVAT")]
        public bool PurchasesPriceIncludedVat { get; set; }

        [JsonProperty("fCatalogueItemGroupCode")]
        public string FCatalogueItemGroupCode { get; set; }

        [JsonProperty("SalesPriceIncludedVAT")]
        public bool SalesPriceIncludedVat { get; set; }
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

        [JsonProperty("CurrencySalesPriceIncludedVAT")]
        public bool CurrencySalesPriceIncludedVat { get; set; }

        [JsonProperty("CurrencySalesRetailPriceIncludedVAT")]
        public bool CurrencySalesRetailPriceIncludedVat { get; set; }

        [JsonProperty("CurrencyPurchasesPriceIncludedVAT")]
        public bool CurrencyPurchasesPriceIncludedVat { get; set; }

        [JsonProperty("fCurrencyCode")]
        public string FCurrencyCode { get; set; }

        [JsonProperty("fRelatedPerson1GID")]
        public string FRelatedPerson1Gid { get; set; }

        [JsonProperty("fRelatedPerson2GID")]
        public string FRelatedPerson2Gid { get; set; }

        [JsonProperty("fRelatedPerson3GID")]
        public string FRelatedPerson3Gid { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }
        public string Notes { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCatalogueItemObjNotesTextTypeType NotesTextType { get; set; }

        [JsonProperty("SEOURL")]
        public string Seourl { get; set; }

        [JsonProperty("SEOURLEN")]
        public string Seourlen { get; set; }

        [JsonProperty("SEOTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("SEOTitleEN")]
        public string SeoTitleEN { get; set; }

        [JsonProperty("SEODescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("SEODescriptionEN")]
        public string SeoDescriptionEN { get; set; }

        [JsonProperty("SEOKeywords")]
        public string SeoKeywords { get; set; }

        [JsonProperty("SEOKeywordsEN")]
        public string SeoKeywordsEN { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCatalogueItemObjProductTypeType ProductType { get; set; }

        [JsonProperty("fCompetitorCategoryValueGID")]
        public string FCompetitorCategoryValueGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCatalogueItemObjNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCatalogueItemObjProductTypeType
    {
        CompanyProduct,
        CompetitorProduct,
        CompanyAndCompetitorProduct
    }

    public class EntersoftWebApi2OdsModelsEsmmStorageLocationObj
    {
        [JsonProperty("fParentLocationGID")]
        public string FParentLocationGid { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

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
        public string FStorageLocationProfileGid { get; set; }
        public bool IsTransit { get; set; }

        [JsonProperty("fAisleCode")]
        public string FAisleCode { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }
        public string LocColumnCode { get; set; }
        public string LocLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStorageLocationObjAisleSideTypeType AisleSideType { get; set; }
        public string BarCode { get; set; }
        public bool IsBeam { get; set; }

        [JsonProperty("fSortingGID")]
        public string FSortingGid { get; set; }

        [JsonProperty("fLockReasonContextGID")]
        public string FLockReasonContextGid { get; set; }
        public bool PhisicalDimensionsMonitoring { get; set; }
        public int Number { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStorageLocationObjAisleSideTypeType
    {
        Unknown,
        Left,
        Right
    }

    public class EntersoftWebApi2OdsModelsEsmmStockItemObj
    {
        public string DetailDescription { get; set; }

        [JsonProperty("fSITaxCode")]
        public string FsiTaxCode { get; set; }
        public string InternationalCode { get; set; }

        [JsonProperty("fIntrastatCode")]
        public string FIntrastatCode { get; set; }
        public string AlternativeCode { get; set; }
        public string BarCode { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjAssemblyTypeType AssemblyType { get; set; }

        [JsonProperty("fCommercialProfileGID")]
        public string FCommercialProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjItemTypeType ItemType { get; set; }

        [JsonProperty("fMainSupplierGID")]
        public string FMainSupplierGid { get; set; }

        [JsonProperty("fManufacturerPersonGID")]
        public string FManufacturerPersonGid { get; set; }
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

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fMainMUGID")]
        public string FMainMugid { get; set; }

        [JsonProperty("fAltMUGID")]
        public string FAltMugid { get; set; }

        [JsonProperty("fWeightMUGID")]
        public string FWeightMugid { get; set; }

        [JsonProperty("fVolumeMUGID")]
        public string FVolumeMugid { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
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
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }

        [JsonProperty("fBaseBOMGID")]
        public string FBaseBomgid { get; set; }
        public double StandardCost { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjValuationMethodType ValuationMethod { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjIncludedTaxReportsType IncludedTaxReports { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGid { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGid { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGid { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGid { get; set; }
        public string Comment { get; set; }
        public string GLAccountCode { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }

        [JsonProperty("fCatalogueItemGID")]
        public string FCatalogueItemGid { get; set; }

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
        public string FCostElementTypeGid { get; set; }
        public bool MainCode { get; set; }

        [JsonProperty("fMainAssetGID")]
        public string FMainAssetGid { get; set; }

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

        [JsonProperty("Price1IncludedVAT")]
        public bool Price1IncludedVat { get; set; }

        [JsonProperty("Price2IncludedVAT")]
        public bool Price2IncludedVat { get; set; }

        [JsonProperty("Price3IncludedVAT")]
        public bool Price3IncludedVat { get; set; }
        public string StorageLocationCodes { get; set; }

        [JsonProperty("fSeasonCode")]
        public string FSeasonCode { get; set; }

        [JsonProperty("VATCalculationValue")]
        public int VatCalculationValue { get; set; }

        [JsonProperty("fItemNetProfitCodesGID")]
        public string FItemNetProfitCodesGid { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }

        [JsonProperty("WEB")]
        public bool Web { get; set; }

        [JsonProperty("fDeductionGroupGID")]
        public string FDeductionGroupGid { get; set; }

        [JsonProperty("fBonusGroupGID")]
        public string FBonusGroupGid { get; set; }
        public int ValuationMethodAnalysis { get; set; }

        [JsonProperty("fWarrantyTermGID")]
        public string FWarrantyTermGid { get; set; }
        public bool ValuationPerPeriod { get; set; }
        public string DocumentMessage { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjServiceMUTypeType ServiceMUType { get; set; }

        [JsonProperty("fAllocationProfileGID")]
        public string FAllocationProfileGid { get; set; }

        [JsonProperty("fItemAllocationProfileGID")]
        public string FItemAllocationProfileGid { get; set; }
        public bool Mobile { get; set; }
        public bool SelectInMobileOrder { get; set; }
        public double PerCentOfTaxExclusion { get; set; }

        [JsonProperty("fTaxDifferencesAccountGID")]
        public string FTaxDifferencesAccountGid { get; set; }
        public double MarkupOnPrice1 { get; set; }
        public double MarkupOnPrice2 { get; set; }
        public double MarkupOnPrice3 { get; set; }
        public bool OpeningPerFiscalYear { get; set; }

        [JsonProperty("fItemControlPolicyGID")]
        public string FItemControlPolicyGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmmStockItemObjLotCharacteristicsMgmtType LotCharacteristicsMgmt { get; set; }

        [JsonProperty("fValidStockDimensionsProfileGID")]
        public string FValidStockDimensionsProfileGid { get; set; }

        [JsonProperty("fBCSNValidationTypeCode")]
        public string FbcsnValidationTypeCode { get; set; }

        [JsonProperty("fReportingMUGID")]
        public string FReportingMugid { get; set; }

        [JsonProperty("fLockReasonCode")]
        public string FLockReasonCode { get; set; }
        public bool Locked { get; set; }

        [JsonProperty("fLockReasonContextGID")]
        public string FLockReasonContextGid { get; set; }

        [JsonProperty("fMUServiceCode")]
        public string FmuServiceCode { get; set; }

        [JsonProperty("fMUMainCode")]
        public string FmuMainCode { get; set; }

        [JsonProperty("fMUAltCode")]
        public string FmuAltCode { get; set; }

        [JsonProperty("fMUWeightCode")]
        public string FmuWeightCode { get; set; }

        [JsonProperty("fMUVolumeCode")]
        public string FmuVolumeCode { get; set; }
        public string MainSupplier { get; set; }

        [JsonProperty("fMUReportingCode")]
        public string FmuReportingCode { get; set; }
        public int CatalogueItemBehaviour { get; set; }

        [JsonProperty("fCreateLikeItemGID")]
        public string FCreateLikeItemGid { get; set; }

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

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjAssemblyTypeType
    {
        [EnumMember(Value = "_Simple")]
        Simple,
        [EnumMember(Value = "_Set")]
        Set,
        [EnumMember(Value = "_Assembly")]
        Assembly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjItemTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjServiceMUTypeType
    {
        BaseMU,
        AltMU
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmStockItemObjLotCharacteristicsMgmtType
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

    public class EntersoftWebApi2OdsModelsEsmmCommercialProfileObj
    {
        [JsonProperty("fItemPricingCategoryCode")]
        public string FItemPricingCategoryCode { get; set; }

        [JsonProperty("fTariffCode")]
        public string FTariffCode { get; set; }

        [JsonProperty("fVATCategoryCode")]
        public string FvatCategoryCode { get; set; }
        public double MarkupOnPrice { get; set; }
        public double MarkupOnRetailPrice { get; set; }

        [JsonProperty("PriceIncludedVAT")]
        public bool PriceIncludedVat { get; set; }

        [JsonProperty("RetailPriceIncludedVAT")]
        public bool RetailPriceIncludedVat { get; set; }

        [JsonProperty("fTaxesGroupGID")]
        public string FTaxesGroupGid { get; set; }

        [JsonProperty("fChargesGroupGID")]
        public string FChargesGroupGid { get; set; }

        [JsonProperty("fDiscountGroupGID")]
        public string FDiscountGroupGid { get; set; }
        public double Discount { get; set; }
        public double MaxDiscount { get; set; }
        public double MinProfitMargin { get; set; }
        public double MinSalesOrderQty { get; set; }

        [JsonProperty("fCommissionLevelCode")]
        public string FCommissionLevelCode { get; set; }

        [JsonProperty("fItemControlProfileGID")]
        public string FItemControlProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjIncludedTaxReportsType IncludedTaxReports { get; set; }

        [JsonProperty("fMainMUCode")]
        public string FMainMUCode { get; set; }

        [JsonProperty("fAltMUCode")]
        public string FAltMUCode { get; set; }

        [JsonProperty("fWeightMUCode")]
        public string FWeightMUCode { get; set; }

        [JsonProperty("fVolumeMUCode")]
        public string FVolumeMUCode { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjValuationMethodType ValuationMethod { get; set; }
        public string GLAccountCode { get; set; }
        public bool SerialNumberMgmt { get; set; }
        public bool LotMgmt { get; set; }
        public bool ColorMgmt { get; set; }
        public bool SizeMgmt { get; set; }
        public bool StockDim1Mgmt { get; set; }
        public bool StockDim2Mgmt { get; set; }

        [JsonProperty("fColorSetGID")]
        public string FColorSetGid { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGid { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGid { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGid { get; set; }

        [JsonProperty("fGLSegCode")]
        public string FglSegCode { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjItemTypeType ItemType { get; set; }

        [JsonProperty("fItemCategoryCode")]
        public string FItemCategoryCode { get; set; }

        [JsonProperty("fItemGroupCode")]
        public string FItemGroupCode { get; set; }

        [JsonProperty("fItemFamilyCode")]
        public string FItemFamilyCode { get; set; }

        [JsonProperty("fItemSubcategoryCode")]
        public string FItemSubcategoryCode { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjItemClassType ItemClass { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjAssetTypeType AssetType { get; set; }

        [JsonProperty("fDepreciatedGLSegCode")]
        public string FDepreciatedGLSegCode { get; set; }

        [JsonProperty("fAssetGLSegCode")]
        public string FAssetGLSegCode { get; set; }

        [JsonProperty("fDepreciationGLSegCode")]
        public string FDepreciationGLSegCode { get; set; }

        [JsonProperty("fDepreciationProfileGID")]
        public string FDepreciationProfileGid { get; set; }

        [JsonProperty("fAlternativeDepreciationProfileGID")]
        public string FAlternativeDepreciationProfileGid { get; set; }

        [JsonProperty("fInformativeDepreciationProfileGID")]
        public string FInformativeDepreciationProfileGid { get; set; }
        public EntersoftWebApi2OdsModelsEsmmCommercialProfileObjLotCharacteristicsMgmtType LotCharacteristicsMgmt { get; set; }

        [JsonProperty("fItemControlPolicyGID")]
        public string FItemControlPolicyGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjIncludedTaxReportsType
    {
        Annually,
        Periodically
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjValuationMethodType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjItemTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjItemClassType
    {
        Item,
        StockItem,
        FixedAsset
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjAssetTypeType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmCommercialProfileObjLotCharacteristicsMgmtType
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

    public class EntersoftWebApi2OdsModelsEsmmSortimentObj
    {
        [JsonProperty("fColorSetGID")]
        public string FColorSetGid { get; set; }

        [JsonProperty("fSizeSetGID")]
        public string FSizeSetGid { get; set; }

        [JsonProperty("fStockDim1SetGID")]
        public string FStockDim1SetGid { get; set; }

        [JsonProperty("fStockDim2SetGID")]
        public string FStockDim2SetGid { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsmmLotObj
    {
        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }
        public string ExpirationDate { get; set; }
        public string ProductionDate { get; set; }
        public string DeliveryDate { get; set; }
        public string LimitOrderDate { get; set; }

        [JsonProperty("fLotQualifierCode")]
        public string FLotQualifierCode { get; set; }

        [JsonProperty("fItemMUGID")]
        public string FItemMugid { get; set; }

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
        public string FDepositionGid { get; set; }
        public string DepositionLine { get; set; }
        public string CustomsRegime { get; set; }

        [JsonProperty("StockBookID")]
        public string StockBookId { get; set; }

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
        public string FDepositionDocumentLineItemAnalysisGid { get; set; }
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

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEsmmProductionPlanObj
    {
        public EntersoftWebApi2OdsModelsEsmmProductionPlanObjStatusType Status { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        [JsonProperty("fProductionUnitGID")]
        public string FProductionUnitGid { get; set; }
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
        public EntersoftWebApi2OdsModelsEsmmProductionPlanObjDatesCalculationBasedOnType DatesCalculationBasedOn { get; set; }
        public bool EnableBatchQuantity { get; set; }
        public bool EnableMinQuantity { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmProductionPlanObjStatusType
    {
        Initial,
        DemandSelection,
        ProductionSchedule,
        CostEstimation,
        ProductionOrders,
        CostEstimationAndProductionOrders,
        Cancelled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEsmmProductionPlanObjDatesCalculationBasedOnType
    {
        ResourceDateAnalysis,
        ResourceWorkingCalendar
    }

    public class EntersoftWebApiModelsESPropertySet
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }
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
        [JsonProperty("GID")]
        public string Gid { get; set; }

        [JsonProperty("fPropertySetGID")]
        public string FPropertySetGid { get; set; }
        public int SeqNum { get; set; }

        [JsonProperty("Category_Code")]
        public string CategoryCode { get; set; }

        [JsonProperty("Category_Description")]
        public string CategoryDescription { get; set; }

        [JsonProperty("Category_AlternativeDescription")]
        public string CategoryAlternativeDescription { get; set; }

        [JsonProperty("Category_OrderPriority")]
        public int CategoryOrderPriority { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }
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
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Description { get; set; }
        public string TaskNotes { get; set; }
    }

    public class EntersoftWebApiModelsESScale
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }

        [JsonProperty("InternationalID")]
        public string InternationalId { get; set; }
        public bool Inactive { get; set; }
        public bool ESSystem { get; set; }
        public EntersoftWebApiModelsESScaleRange[] Ranges { get; set; }
    }

    public class EntersoftWebApiModelsESScaleRange
    {
        [JsonProperty("GID")]
        public string Gid { get; set; }

        [JsonProperty("fScaleGID")]
        public string FScaleGid { get; set; }
        public int SeqNum { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public int ImageIndex { get; set; }

        [JsonProperty("ColorARGB")]
        public int ColorArgb { get; set; }
    }

    public class EntersoftWebApiModelsEspqLayout
    {
        public EntersoftWebApiModelsEspqLayoutFilter[] Filter { get; set; }
        public EntersoftWebApiModelsEspqLayoutParam[] Param { get; set; }
        public EntersoftWebApiModelsEspqLayoutDefaultValue[] DefaultValue { get; set; }
        public EntersoftWebApiModelsEspqLayoutEnumItem[] EnumItem { get; set; }
        public EntersoftWebApiModelsEspqLayoutColumn[] LayoutColumn { get; set; }
        public JToken[] FormatingCondition { get; set; }
        public JToken[] FormatStyle { get; set; }
    }

    public class EntersoftWebApiModelsEspqLayoutFilter
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Caption { get; set; }

        [JsonProperty("QueryID")]
        public string QueryId { get; set; }
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

    public class EntersoftWebApiModelsEspqLayoutParam
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string AA { get; set; }
        public string Caption { get; set; }
        public string Tooltip { get; set; }
        public string ControlType { get; set; }
        public string ParameterType { get; set; }
        public string Precision { get; set; }
        public string MultiValued { get; set; }
        public string Visible { get; set; }
        public string Required { get; set; }

        [JsonProperty("ODSTag")]
        public string OdsTag { get; set; }
        public string Tags { get; set; }
        public string Visibility { get; set; }

        [JsonProperty("InvQueryID")]
        public string InvQueryId { get; set; }
        public string InvSelectedMasterTable { get; set; }
        public string InvSelectedMasterField { get; set; }
        public string InvTableMappings { get; set; }
    }

    public class EntersoftWebApiModelsEspqLayoutDefaultValue
    {
        [JsonProperty("fParamID")]
        public string FParamId { get; set; }
        public string Value { get; set; }
    }

    public class EntersoftWebApiModelsEspqLayoutEnumItem
    {
        [JsonProperty("fParamID")]
        public string FParamId { get; set; }

        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Caption { get; set; }
    }

    public class EntersoftWebApiModelsEspqLayoutColumn
    {
        [JsonProperty("fFilterID")]
        public string FFilterId { get; set; }
        public string ColName { get; set; }
        public string AA { get; set; }
        public string Caption { get; set; }
        public string FormatString { get; set; }
        public string Width { get; set; }

        [JsonProperty("ODSTag")]
        public string OdsTag { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeverityInput
    {
        Information,
        Warning,
        Error,
        FatalError
    }

    public class EntersoftWebApiModelsCompanyParamEx
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public JToken Value { get; set; }
        public string Description { get; set; }
        public string Help { get; set; }
        public EntersoftWebApiModelsCompanyParamExESTypeType ESType { get; set; }
        public string CompileType { get; set; }
        public string EnumName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApiModelsCompanyParamExESTypeType
    {
        [EnumMember(Value = "STRING_TYPE")]
        StringType,
        [EnumMember(Value = "NUMERIC_TYPE")]
        NumericType,
        [EnumMember(Value = "DATE_TYPE")]
        DateType,
        [EnumMember(Value = "BOOLEAN_TYPE")]
        BooleanType
    }

    public class EntersoftWebApiModelsESScrollerCommandOut
    {
        public JToken ScrollerDataset { get; set; }
        public JToken[] TargetDatasets { get; set; }
        public JToken Variables { get; set; }
    }

    public class EsScrollerCommandInput
    {
        public EsScrollerCommandInput(string scrollerId, string commandId)
        {
            this.ScrollerId = scrollerId;
            this.CommandId = commandId;
        }

        public JToken ScrollerParams { get; set; }
        public JToken ScrollerDataset { get; set; }
        public string ScrollerDatasetJson { get; set; }
        public bool? RequiresTransaction { get; set; }
        public bool? OnlyPrepareTargetDatasets { get; set; }
        public bool? ReturnTargetDatasets { get; set; }
        public bool? ReturnScrollerDataset { get; set; }
        public bool? ReturnEntersoftDatasets { get; set; }

        [JsonProperty("ScrollerID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScrollerId { get; set; }

        [JsonProperty("CommandID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommandId { get; set; }
        public JToken CommandParams { get; set; }
        public JToken UnboundVariables { get; set; }
    }

    public class EsCommandInInput
    {
        public EsCommandInInput(string scrollerId, string commandId)
        {
            this.ScrollerId = scrollerId;
            this.CommandId = commandId;
        }

        [JsonProperty("ScrollerID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ScrollerId { get; set; }

        [JsonProperty("CommandID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommandId { get; set; }
        public JToken CommandParams { get; set; }
        public JToken UnboundVariables { get; set; }
    }

    public class EntersoftWebApiModelsESFormCommandOut
    {
        public JToken[] SourceDatasets { get; set; }
        public JToken[] TargetDatasets { get; set; }
        public JToken Variables { get; set; }
    }

    public class FormCommandInput
    {
        [JsonProperty("EntityID")]
        public string EntityId { get; set; }

        [JsonProperty("CommandID")]
        public string CommandId { get; set; }
        public JToken EntityDataset { get; set; }
        public string EntityDatasetJson { get; set; }

        [JsonProperty("EntityGID")]
        public string EntityGid { get; set; }

        [JsonProperty("EntityGIDs")]
        public string[] EntityGids { get; set; }
        public string EntityCode { get; set; }
        public string[] EntityCodes { get; set; }
        public JToken EntityParams { get; set; }

        [JsonProperty("EntityScrollerID")]
        public string EntityScrollerId { get; set; }
        public JToken EntityScrollerParams { get; set; }
        public bool? RequiresTransaction { get; set; }
        public JToken CommandParams { get; set; }
        public JToken UnboundVariables { get; set; }
        public bool? CreateNewEmptySourceEntity { get; set; }
        public bool? OnlyPrepareTargetDatasets { get; set; }
        public bool? ReturnSourceDatasets { get; set; }
        public bool? ReturnTargetDatasets { get; set; }
        public bool? ReturnMap { get; set; }
        public bool? ReturnEntersoftDatasets { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEstmMobileTaskTypeObj
    {
        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmMobileTaskTypeObjSignatureType Signature { get; set; }
        public int DaysForFutureMobileTasks { get; set; }
        public int DaysForClosedMobileTasks { get; set; }
        public int DefaultMinutesToEnd { get; set; }
        public int DefaultMinutesToPrepare { get; set; }
        public string GroupField { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmMobileTaskTypeObjSignatureType
    {
        None,
        Optional,
        Required
    }

    public class EntersoftWebApi2OdsModelsEstmServiceRequestObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmServiceRequestObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmServiceRequestObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmServiceRequestObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmServiceRequestObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmServiceRequestObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmServiceRequestObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEstmrfmModelObj
    {
        public string TransactionRefDate { get; set; }
        public int TransactionPeriod { get; set; }
        public EntersoftWebApi2OdsModelsEstmrfmModelObjTradeAccountSelectionModeType TradeAccountSelectionMode { get; set; }
        public string ScrollerParams { get; set; }
        public int RSegments { get; set; }
        public int FSegments { get; set; }
        public int MSegments { get; set; }

        [JsonProperty("AssignTradeAccountWithNoTransactionToNULLSegment")]
        public bool AssignTradeAccountWithNoTransactionToNullSegment { get; set; }
        public EntersoftWebApi2OdsModelsEstmrfmModelObjStateType State { get; set; }
        public string CalculationDate { get; set; }
        public EntersoftWebApi2OdsModelsEstmrfmModelObjCalculationSourceType CalculationSource { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmrfmModelObjTradeAccountSelectionModeType
    {
        AllCustomers,
        BasedOnFilter
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmrfmModelObjStateType
    {
        InProgress,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmrfmModelObjCalculationSourceType
    {
        TradeAccountEntries,
        ExternalSource
    }

    public class EntersoftWebApi2OdsModelsEstmNewsletterRecipientObj
    {
        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public EntersoftWebApi2OdsModelsEstmNewsletterRecipientObjStateType State { get; set; }

        [JsonProperty("fStateReasoningCategoryValueGID")]
        public string FStateReasoningCategoryValueGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmNewsletterRecipientObjStateType
    {
        Subscribed,
        Verified,
        Unsubscribed,
        Removed
    }

    public class EntersoftWebApi2OdsModelsEstmInteractionObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmInteractionObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmInteractionObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmInteractionObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmInteractionObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmInteractionObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmInteractionObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEstmObjectRatingObj
    {
        [JsonProperty("fWebUserGID")]
        public string FWebUserGid { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGid { get; set; }
        public string Date { get; set; }
        public int Rating { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEstmTaskObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmTaskObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmTaskObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmTaskObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmTaskObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmTaskObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmTaskObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEstmResourceObj
    {
        public EntersoftWebApi2OdsModelsEstmResourceObjResourceTypeType ResourceType { get; set; }
        public bool InterCompany { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }

        [JsonProperty("fMUCode")]
        public string FmuCode { get; set; }
        public bool TimeInterval { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("fSeasonCalendarGID")]
        public string FSeasonCalendarGid { get; set; }
        public bool Production { get; set; }

        [JsonProperty("fProductionUnitGID")]
        public string FProductionUnitGid { get; set; }
        public int LockResource { get; set; }

        [JsonProperty("fUserGID")]
        public string FUserGid { get; set; }
        public int InvalidEmailAddress { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmResourceObjResourceTypeType
    {
        Person,
        Asset,
        ResourceGroup,
        GeneralResource
    }

    public class EntersoftWebApi2OdsModelsEstmCampaignObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmCampaignObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmCampaignObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmCampaignObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmCampaignObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmCampaignObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmCampaignObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEstmsmActivityObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmsmActivityObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmsmActivityObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmsmActivityObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmsmActivityObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmsmActivityObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmsmActivityObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEstmOpportunityObj
    {
        public int SeqNum { get; set; }

        [JsonProperty("fTaskTypeGID")]
        public string FTaskTypeGid { get; set; }

        [JsonProperty("fOwnerGID")]
        public string FOwnerGid { get; set; }
        public string TaskNotes { get; set; }

        [JsonProperty("fStatusGID")]
        public string FStatusGid { get; set; }

        [JsonProperty("fAssignedToGID")]
        public string FAssignedToGid { get; set; }

        [JsonProperty("fResourceGroupGID")]
        public string FResourceGroupGid { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentTaskGID")]
        public string FParentTaskGid { get; set; }

        [JsonProperty("fRootTaskGID")]
        public string FRootTaskGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fAddressGID")]
        public string FAddressGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fTaskMediaCode")]
        public string FTaskMediaCode { get; set; }

        [JsonProperty("fPriorityCode")]
        public string FPriorityCode { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FAccessLevelGid { get; set; }
        public bool CalendarItem { get; set; }

        [JsonProperty("fRecurrentDataGID")]
        public string FRecurrentDataGid { get; set; }
        public bool AllDay { get; set; }

        [JsonProperty("fCampaignGID")]
        public string FCampaignGid { get; set; }
        public bool IsCampaignExecutionTask { get; set; }
        public string SharedNotes { get; set; }

        [JsonProperty("fCategoryValue1GID")]
        public string FCategoryValue1Gid { get; set; }

        [JsonProperty("fCategoryValue2GID")]
        public string FCategoryValue2Gid { get; set; }

        [JsonProperty("fCategoryValue3GID")]
        public string FCategoryValue3Gid { get; set; }

        [JsonProperty("fCategoryValue4GID")]
        public string FCategoryValue4Gid { get; set; }

        [JsonProperty("fCategoryValue5GID")]
        public string FCategoryValue5Gid { get; set; }

        [JsonProperty("fCategoryValue6GID")]
        public string FCategoryValue6Gid { get; set; }

        [JsonProperty("fCategoryValue7GID")]
        public string FCategoryValue7Gid { get; set; }

        [JsonProperty("fCategoryValue8GID")]
        public string FCategoryValue8Gid { get; set; }

        [JsonProperty("fCategoryValue9GID")]
        public string FCategoryValue9Gid { get; set; }

        [JsonProperty("fCategoryValue10GID")]
        public string FCategoryValue10Gid { get; set; }
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
        public string FPropertySetGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("ExtCallID")]
        public int ExtCallId { get; set; }

        [JsonProperty("fMetricSetGID")]
        public string FMetricSetGid { get; set; }
        public int DefaultVisitTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmOpportunityObjDefaultVisitTimeUnitType DefaultVisitTimeUnit { get; set; }
        public int DefaultPreparationTime { get; set; }
        public EntersoftWebApi2OdsModelsEstmOpportunityObjDefaultPreparationTimeUnitType DefaultPreparationTimeUnit { get; set; }

        [JsonProperty("fTaskTemplateGID")]
        public string FTaskTemplateGid { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }

        [JsonProperty("fCancellationReasonGID")]
        public string FCancellationReasonGid { get; set; }
        public EntersoftWebApi2OdsModelsEstmOpportunityObjTaskNotesTextTypeType TaskNotesTextType { get; set; }

        [JsonProperty("fRequestGID")]
        public string FRequestGid { get; set; }

        [JsonProperty("fActionGID")]
        public string FActionGid { get; set; }

        [JsonProperty("fWMWorkPackageGID")]
        public string FwmWorkPackageGid { get; set; }

        [JsonProperty("fTerritoryGID")]
        public string FTerritoryGid { get; set; }

        [JsonProperty("fRLSNodeGID")]
        public string FrlsNodeGid { get; set; }

        [JsonProperty("ns_Caption")]
        public string NsCaption { get; set; }

        [JsonProperty("ns_fParentTaskGID")]
        public string NsFParentTaskGid { get; set; }

        [JsonProperty("ns_TimerSeconds")]
        public int NsTimerSeconds { get; set; }

        [JsonProperty("ns_TemplateTaskGID")]
        public string NsTemplateTaskGid { get; set; }

        [JsonProperty("ns_fResponseValueGID")]
        public string NsFResponseValueGid { get; set; }

        [JsonProperty("ns_RecurrentData")]
        public string NsRecurrentData { get; set; }

        [JsonProperty("fRLSTreeGID")]
        public string FrlsTreeGid { get; set; }

        [JsonProperty("fPrevRLSNodeGID")]
        public string FPrevRlsNodeGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmOpportunityObjDefaultVisitTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmOpportunityObjDefaultPreparationTimeUnitType
    {
        Minutes,
        Hours
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEstmOpportunityObjTaskNotesTextTypeType
    {
        RichText,
        PlainText,
        HtmlText
    }

    public class EntersoftWebApi2OdsModelsEswmTransportActionObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fActionTypeGID")]
        public string FActionTypeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGid { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGid { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public double QtyPackMU { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGid { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
        public EntersoftWebApi2OdsModelsEswmTransportActionObjBalancePostingType BalancePosting { get; set; }
        public string StringField1 { get; set; }
        public string StringField2 { get; set; }
        public string StringField3 { get; set; }
        public string StringField4 { get; set; }
        public string StringField5 { get; set; }

        [JsonProperty("fFromStorageLocationGID")]
        public string FFromStorageLocationGid { get; set; }

        [JsonProperty("fFromWarehouseGID")]
        public string FFromWarehouseGid { get; set; }

        [JsonProperty("fFromSiteGID")]
        public string FFromSiteGid { get; set; }

        [JsonProperty("fToStorageLocationGID")]
        public string FToStorageLocationGid { get; set; }

        [JsonProperty("fToWarehouseGID")]
        public string FToWarehouseGid { get; set; }

        [JsonProperty("fToSiteGID")]
        public string FToSiteGid { get; set; }

        [JsonProperty("fFromReservationReasonCode")]
        public string FFromReservationReasonCode { get; set; }

        [JsonProperty("fFromDispositionReasonCode")]
        public string FFromDispositionReasonCode { get; set; }

        [JsonProperty("fToReservationReasonCode")]
        public string FToReservationReasonCode { get; set; }

        [JsonProperty("fToDispositionReasonCode")]
        public string FToDispositionReasonCode { get; set; }

        [JsonProperty("fSelectedDepositorGID")]
        public string FSelectedDepositorGid { get; set; }
        public string SelectedDepositorCode { get; set; }

        [JsonProperty("fSelectedTradeAccountGID")]
        public string FSelectedTradeAccountGid { get; set; }
        public string SelectedTradeAccountCode { get; set; }

        [JsonProperty("fSelectedDocumentGID")]
        public string FSelectedDocumentGid { get; set; }
        public string SelectedDocumentCode { get; set; }

        [JsonProperty("fSelectedContainerTypeGID")]
        public string FSelectedContainerTypeGid { get; set; }

        [JsonProperty("fSelectedPackageContainerTypeGID")]
        public string FSelectedPackageContainerTypeGid { get; set; }

        [JsonProperty("fSelectedPalletContainerTypeGID")]
        public string FSelectedPalletContainerTypeGid { get; set; }

        [JsonProperty("fSelectedMasterPackageContainerTypeGID")]
        public string FSelectedMasterPackageContainerTypeGid { get; set; }

        [JsonProperty("fSelectedTransportContainerTypeGID")]
        public string FSelectedTransportContainerTypeGid { get; set; }
        public string SelectedContainerTypeCode { get; set; }
        public string SelectedPackageContainerTypeCode { get; set; }
        public string SelectedPalletContainerTypeCode { get; set; }
        public string SelectedMasterPackageContainerTypeCode { get; set; }
        public string SelectedTransportContainerTypeCode { get; set; }

        [JsonProperty("fSelectedContainerGID")]
        public string FSelectedContainerGid { get; set; }
        public string SelectedContainerCode { get; set; }

        [JsonProperty("fSelectedPackageContainerGID")]
        public string FSelectedPackageContainerGid { get; set; }
        public string SelectedPackageContainerCode { get; set; }

        [JsonProperty("fSelectedPalletContainerGID")]
        public string FSelectedPalletContainerGid { get; set; }
        public string SelectedPalletContainerCode { get; set; }

        [JsonProperty("fSelectedMasterPackageContainerGID")]
        public string FSelectedMasterPackageContainerGid { get; set; }
        public string SelectedMasterPackageContainerCode { get; set; }

        [JsonProperty("fSelectedTransportContainerGID")]
        public string FSelectedTransportContainerGid { get; set; }
        public string SelectedTransportContainerCode { get; set; }

        [JsonProperty("fSelectedStorageLocationGID")]
        public string FSelectedStorageLocationGid { get; set; }
        public string SelectedStorageLocationCode { get; set; }

        [JsonProperty("fSelectedItemGID")]
        public string FSelectedItemGid { get; set; }
        public string SelectedItemCode { get; set; }

        [JsonProperty("fSelectedDeliveryPersonGID")]
        public string FSelectedDeliveryPersonGid { get; set; }
        public string SelectedDeliveryPersonCode { get; set; }

        [JsonProperty("fSelectedEntityGID")]
        public string FSelectedEntityGid { get; set; }
        public string SelectedEntityCode { get; set; }

        [JsonProperty("fInputItemGID")]
        public string FInputItemGid { get; set; }
        public string InputItemCode { get; set; }
        public double InputQuantity { get; set; }

        [JsonProperty("fInputContainerGID")]
        public string FInputContainerGid { get; set; }
        public string InputContainerCode { get; set; }

        [JsonProperty("fInputPackageContainerGID")]
        public string FInputPackageContainerGid { get; set; }
        public string InputPackageContainerCode { get; set; }

        [JsonProperty("fInputPalletContainerGID")]
        public string FInputPalletContainerGid { get; set; }
        public string InputPalletContainerCode { get; set; }

        [JsonProperty("fInputMasterPackageContainerGID")]
        public string FInputMasterPackageContainerGid { get; set; }
        public string InputMasterPackageContainerCode { get; set; }

        [JsonProperty("fInputTransportContainerGID")]
        public string FInputTransportContainerGid { get; set; }
        public string InputTransportContainerCode { get; set; }

        [JsonProperty("fInputStorageLocationGID")]
        public string FInputStorageLocationGid { get; set; }
        public string InputStorageLocationCode { get; set; }

        [JsonProperty("fSelectedDeliverySiteGID")]
        public string FSelectedDeliverySiteGid { get; set; }
        public string SelectedDeliverySiteCode { get; set; }
        public string SelectedDate { get; set; }

        [JsonProperty("fSelectedRequestItemGID")]
        public string FSelectedRequestItemGid { get; set; }

        [JsonProperty("fSelectedItemContainmentGID")]
        public string FSelectedItemContainmentGid { get; set; }

        [JsonProperty("fSelectedItemContainerTypeGID")]
        public string FSelectedItemContainerTypeGid { get; set; }
        public string SelectedItemContainerTypeCode { get; set; }

        [JsonProperty("fSelectedItemMUGID")]
        public string FSelectedItemMugid { get; set; }
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
        public string FSelectedItemContainerGid { get; set; }

        [JsonProperty("fInputItemContainerGID")]
        public string FInputItemContainerGid { get; set; }
        public string InputItemContainerCode { get; set; }
        public string InputPackageComment { get; set; }
        public string InputMasterPackageComment { get; set; }
        public string InputPalletComment { get; set; }
        public string InputTransportComment { get; set; }
        public double InputItemWeight { get; set; }
        public string InputItemVolume { get; set; }
        public string SelectedContainerStorageLocationCode { get; set; }

        [JsonProperty("fSelectedContainerStorageLocationGID")]
        public string FSelectedContainerStorageLocationGid { get; set; }
        public string DerivedShipmentCode { get; set; }
        public string SpareField1 { get; set; }
        public string SpareField2 { get; set; }

        [JsonProperty("fSelectedSortingContainerGID")]
        public string FSelectedSortingContainerGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEswmTransportActionObjBalancePostingType
    {
        ActionItem,
        RequestActionFulfillment
    }

    public class EntersoftWebApi2OdsModelsEswmActionObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fActionTypeGID")]
        public string FActionTypeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGid { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGid { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public double QtyPackMU { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGid { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
        public int MUInvgType { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswmShipmentObj
    {
        public string DeliveryDueDate { get; set; }

        [JsonProperty("fTransporterGID")]
        public string FTransporterGid { get; set; }

        [JsonProperty("fConveyanceCode")]
        public string FConveyanceCode { get; set; }

        [JsonProperty("fDriverGID")]
        public string FDriverGid { get; set; }

        [JsonProperty("fRouteCode")]
        public string FRouteCode { get; set; }

        [JsonProperty("fDeliveryTermsCode")]
        public string FDeliveryTermsCode { get; set; }

        [JsonProperty("fShippingMethodCode")]
        public string FShippingMethodCode { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }
        public string Barcode { get; set; }
        public EntersoftWebApi2OdsModelsEswmShipmentObjOriginType Origin { get; set; }
        public bool ResolveOnActivation { get; set; }
        public bool BOSelection { get; set; }
        public bool BOResolving { get; set; }
        public bool RFResolving { get; set; }
        public bool RFSelection { get; set; }
        public string ShippingDate { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("GoogleMapsRouteURL")]
        public string GoogleMapsRouteUrl { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntersoftWebApi2OdsModelsEswmShipmentObjOriginType
    {
        User,
        Routing,
        Action
    }

    public class EntersoftWebApi2OdsModelsEswmWorkPackageObj
    {
        [JsonProperty("fWorkPackageTypeGID")]
        public string FWorkPackageTypeGid { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGid { get; set; }
        public string Barcode { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswmRequestObj
    {
        public string RegistrationDate { get; set; }

        [JsonProperty("fRequestTypeGID")]
        public string FRequestTypeGid { get; set; }

        [JsonProperty("fSiteGID")]
        public string FSiteGid { get; set; }

        [JsonProperty("fWarehouseGID")]
        public string FWarehouseGid { get; set; }

        [JsonProperty("fStorageLocationGID")]
        public string FStorageLocationGid { get; set; }

        [JsonProperty("fTaskGID")]
        public string FTaskGid { get; set; }

        [JsonProperty("fStepCode")]
        public string FStepCode { get; set; }

        [JsonProperty("fDeviceGID")]
        public string FDeviceGid { get; set; }
        public string Barcode { get; set; }
        public bool Printed { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswmContainerObj
    {
        [JsonProperty("fContainerTypeGID")]
        public string FContainerTypeGid { get; set; }

        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGid { get; set; }

        [JsonProperty("fSortimentGID")]
        public string FSortimentGid { get; set; }

        [JsonProperty("fContainerControlPolicyGID")]
        public string FContainerControlPolicyGid { get; set; }
        public bool Printed { get; set; }
        public string Comment { get; set; }
        public bool UseInStockAllocation { get; set; }
        public bool PhisicalDimensionsMonitoring { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswpTaskRequestObj
    {
        [JsonProperty("fTaskStatusCode")]
        public string FTaskStatusCode { get; set; }

        [JsonProperty("fRequestTypesCode")]
        public string FRequestTypesCode { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fParentRequestGID")]
        public string FParentRequestGid { get; set; }
        public string DateIssued { get; set; }
        public string DeadLine { get; set; }
        public string DatePlanned { get; set; }
        public string DeliveryDate { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

        [JsonProperty("fProjectPersonGID")]
        public string FProjectPersonGid { get; set; }

        [JsonProperty("fWorkPackageGID")]
        public string FWorkPackageGid { get; set; }
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
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

        [JsonProperty("fPersonCodeGID")]
        public string FPersonCodeGid { get; set; }
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
        public string RtfCtx { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswpWorkPackageObj
    {
        public double Timeplanned { get; set; }
        public int Chargeable { get; set; }
        public string DateModified { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class EntersoftWebApi2OdsModelsEswpActualTaskObj
    {
        [JsonProperty("fTaskRequestGID")]
        public string FTaskRequestGid { get; set; }

        [JsonProperty("fPersonGID")]
        public string FPersonGid { get; set; }

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

        [JsonProperty("WorkNoteID")]
        public string WorkNoteId { get; set; }

        [JsonProperty("fAssignToGID")]
        public string FAssignToGid { get; set; }
        public string Comments { get; set; }

        [JsonProperty("fProjectGID")]
        public string FProjectGid { get; set; }

        [JsonProperty("fTradeAccountGID")]
        public string FTradeAccountGid { get; set; }

        [JsonProperty("fContactPersonGID")]
        public string FContactPersonGid { get; set; }

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
        public string FPersonCodeGid { get; set; }
        public string Comments2 { get; set; }
        public string EntryTime { get; set; }

        [JsonProperty("fItemGID")]
        public string FItemGid { get; set; }

        [JsonProperty("fSerialNumberGID")]
        public string FSerialNumberGid { get; set; }
        public string TimerColumn { get; set; }

        [JsonProperty("___RTF_CTX___")]
        public string RtfCtx { get; set; }

        [JsonProperty("GID")]
        public string Gid { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public bool Inactive { get; set; }

        [JsonProperty("fCompanyCode")]
        public string FCompanyCode { get; set; }

        [JsonProperty("ESUCreated")]
        public string EsuCreated { get; set; }

        [JsonProperty("ESDCreated")]
        public string EsdCreated { get; set; }

        [JsonProperty("ESUModified")]
        public string EsuModified { get; set; }

        [JsonProperty("ESDModified")]
        public string EsdModified { get; set; }
        public string TS { get; set; }
    }

    public class ESBusinessHookPostRegistrationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputBusinessEventTypeType BusinessEventType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft.RegistrationInputBusinessEventTypeType.HighValueSalesOrder;
        public string Context { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Value { get; set; } = 0;

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsActive { get; set; } = true;

        [JsonProperty("CallbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputBusinessEventTypeType
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
        [EnumMember(Value = "NewCRMTaskOfType")]
        NewCrmTaskOfType,
        [EnumMember(Value = "CRMTaskExpired")]
        CrmTaskExpired,
        HighValuePayment,
        HighValuePaymentWithCheck,
        HighValuePaymentTaxes,
        HighValueCollection,
        HighValueCollectionWithCheque,
        StockFallingBelowThreshold,
        RequestToApprove,
        RequestHasBeenApproved
    }

    public class ESPodHookPostRegistrationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputStateType? State { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft.RegistrationInputStateType.All;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputPackageTypeType? PackageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Entersoft.RegistrationInputPackageTypeType.All;
        public string ConveyanceLicencePlate { get; set; }

        [JsonProperty("BranchID")]
        public string BranchId { get; set; }
        public string TradeAccountName { get; set; }
        public string DriverCode { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsActive { get; set; } = true;

        [JsonProperty("CallbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputStateType
    {
        Initial,
        Arrived,
        Started,
        Delivered,
        Cancelled,
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputPackageTypeType
    {
        MasterPackage,
        Package,
        Pallet,
        Sorting,
        Transport,
        All
    }

    public class EsrfaHookPostRegistrationInput
    {
        public string RequestedBy { get; set; }
        public RegistrationInputPriorityType? Priority { get; set; }
        public string RequestClass { get; set; }
        public string RequestCategory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? NumericValue { get; set; } = 0;

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsActive { get; set; } = true;

        [JsonProperty("CallbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputPriorityType
    {
        Low,
        Normal,
        High
    }

    public class ESHookPostRegistrationInput
    {
        public ESHookPostRegistrationInput(RegistrationInputEntityTypeType entityType, RegistrationInputEventTypeType eventType)
        {
            this.EntityType = entityType;
            this.EventType = eventType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputEntityTypeType EntityType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputEventTypeType EventType { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsActive { get; set; } = true;

        [JsonProperty("CallbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputEntityTypeType
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
        [EnumMember(Value = "ES00SSASParameters")]
        ES00SsasParameters,
        ES00WordGroup,
        ES00ZProperty,
        [EnumMember(Value = "ESBGAllocationProfile")]
        EsbgAllocationProfile,
        [EnumMember(Value = "ESBGBudgetDimensionAllocationProfile")]
        EsbgBudgetDimensionAllocationProfile,
        [EnumMember(Value = "ESBGBudgetSheet")]
        EsbgBudgetSheet,
        [EnumMember(Value = "ESBGBudgetSheetProfile")]
        EsbgBudgetSheetProfile,
        [EnumMember(Value = "ESBGZBudgetCashAccountGroup")]
        EsbgzBudgetCashAccountGroup,
        [EnumMember(Value = "ESBGZBudgetItemGroup")]
        EsbgzBudgetItemGroup,
        [EnumMember(Value = "ESBGZBudgetSalespersonGroup")]
        EsbgzBudgetSalespersonGroup,
        [EnumMember(Value = "ESBGZBudgetTradeAccountGroup")]
        EsbgzBudgetTradeAccountGroup,
        [EnumMember(Value = "ESCOCostElementType")]
        EscoCostElementType,
        [EnumMember(Value = "ESCOCostingFolder")]
        EscoCostingFolder,
        [EnumMember(Value = "ESCOLineCostAnalysis")]
        EscoLineCostAnalysis,
        [EnumMember(Value = "ESFACommercialProfile")]
        EsfaCommercialProfile,
        [EnumMember(Value = "ESFADepreciationProfile")]
        EsfaDepreciationProfile,
        [EnumMember(Value = "ESFAFixedAsset")]
        EsfaFixedAsset,
        [EnumMember(Value = "ESFAItemControlPolicy")]
        EsfaItemControlPolicy,
        [EnumMember(Value = "ESFARevaluationProfile")]
        EsfaRevaluationProfile,
        [EnumMember(Value = "ESFIBankImport")]
        EsfiBankImport,
        [EnumMember(Value = "ESFICardRateProfile")]
        EsfiCardRateProfile,
        [EnumMember(Value = "ESFICashAccount")]
        EsfiCashAccount,
        [EnumMember(Value = "ESFICDCommercialProfile")]
        EsficdCommercialProfile,
        [EnumMember(Value = "ESFICheckListProfile")]
        EsfiCheckListProfile,
        [EnumMember(Value = "ESFICommercialProfileItem")]
        EsfiCommercialProfileItem,
        [EnumMember(Value = "ESFICommissionProfile")]
        EsfiCommissionProfile,
        [EnumMember(Value = "ESFICondition")]
        EsfiCondition,
        [EnumMember(Value = "ESFIConditionTemplate")]
        EsfiConditionTemplate,
        [EnumMember(Value = "ESFICreditCardType")]
        EsfiCreditCardType,
        [EnumMember(Value = "ESFICreditControlProfile")]
        EsfiCreditControlProfile,
        [EnumMember(Value = "ESFICreditor")]
        EsfiCreditor,
        [EnumMember(Value = "ESFICreditTurnOverProfile")]
        EsfiCreditTurnOverProfile,
        [EnumMember(Value = "ESFICreditTurnOverProfileEntry")]
        EsfiCreditTurnOverProfileEntry,
        [EnumMember(Value = "ESFICustomer")]
        EsfiCustomer,
        [EnumMember(Value = "ESFIDebtor")]
        EsfiDebtor,
        [EnumMember(Value = "ESFIDeclarationEntry")]
        EsfiDeclarationEntry,
        [EnumMember(Value = "ESFIDeclarationType")]
        EsfiDeclarationType,
        [EnumMember(Value = "ESFIDistributionDispatch")]
        EsfiDistributionDispatch,
        [EnumMember(Value = "ESFIDocSeriesAttributes")]
        EsfiDocSeriesAttributes,
        [EnumMember(Value = "ESFIDocumentAccessRightProfile")]
        EsfiDocumentAccessRightProfile,
        [EnumMember(Value = "ESFIDocumentAdjustment")]
        EsfiDocumentAdjustment,
        [EnumMember(Value = "ESFIDocumentCash")]
        EsfiDocumentCash,
        [EnumMember(Value = "ESFIDocumentSeries")]
        EsfiDocumentSeries,
        [EnumMember(Value = "ESFIDocumentStock")]
        EsfiDocumentStock,
        [EnumMember(Value = "ESFIDocumentTrade")]
        EsfiDocumentTrade,
        [EnumMember(Value = "ESFIDocumentTransition")]
        EsfiDocumentTransition,
        [EnumMember(Value = "ESFIDocumentUpdateProfile")]
        EsfiDocumentUpdateProfile,
        [EnumMember(Value = "ESFIDocumentUpdateProfileGL")]
        EsfiDocumentUpdateProfileGL,
        [EnumMember(Value = "ESFIEInvoiceProfile")]
        EsfieInvoiceProfile,
        [EnumMember(Value = "ESFIFieldPropertiesProfile")]
        EsfiFieldPropertiesProfile,
        [EnumMember(Value = "ESFIFillerProfile")]
        EsfiFillerProfile,
        [EnumMember(Value = "ESFIFinancialAgreement")]
        EsfiFinancialAgreement,
        [EnumMember(Value = "ESFIFinancialDeclaration")]
        EsfiFinancialDeclaration,
        [EnumMember(Value = "ESFIInnerDistributionEntry")]
        EsfiInnerDistributionEntry,
        [EnumMember(Value = "ESFIIntrastatEntry")]
        EsfiIntrastatEntry,
        [EnumMember(Value = "ESFIInvoicePolicy")]
        EsfiInvoicePolicy,
        [EnumMember(Value = "ESFIInvoicePolicyAction")]
        EsfiInvoicePolicyAction,
        [EnumMember(Value = "ESFIItem")]
        EsfiItem,
        [EnumMember(Value = "ESFIItemAllocationProfile")]
        EsfiItemAllocationProfile,
        [EnumMember(Value = "ESFIItemCategories")]
        EsfiItemCategories,
        [EnumMember(Value = "ESFIItemControlPolicy")]
        EsfiItemControlPolicy,
        [EnumMember(Value = "ESFIItemExpense")]
        EsfiItemExpense,
        [EnumMember(Value = "ESFIItemExpenses")]
        EsfiItemExpenses,
        [EnumMember(Value = "ESFIItemFamily")]
        EsfiItemFamily,
        [EnumMember(Value = "ESFIItemPriceHistoryTemplate")]
        EsfiItemPriceHistoryTemplate,
        [EnumMember(Value = "ESFIItemService")]
        EsfiItemService,
        [EnumMember(Value = "ESFIItemSubCategory")]
        EsfiItemSubCategory,
        [EnumMember(Value = "ESFIItemSubfamily")]
        EsfiItemSubfamily,
        [EnumMember(Value = "ESFIKEPYOEntry")]
        EsfikepyoEntry,
        [EnumMember(Value = "ESFIMeasure")]
        EsfiMeasure,
        [EnumMember(Value = "ESFIMobileDocumentType")]
        EsfiMobileDocumentType,
        [EnumMember(Value = "ESFIMyDataInvoice")]
        EsfiMyDataInvoice,
        [EnumMember(Value = "ESFINote")]
        EsfiNote,
        [EnumMember(Value = "ESFIOIMatchingProfile")]
        EsfioiMatchingProfile,
        [EnumMember(Value = "ESFIOpenItemsForDateProposalHeader")]
        EsfiOpenItemsForDateProposalHeader,
        [EnumMember(Value = "ESFIPaymentMethod")]
        EsfiPaymentMethod,
        [EnumMember(Value = "ESFIPricelist")]
        EsfiPricelist,
        [EnumMember(Value = "ESFIPricelistEditor")]
        EsfiPricelistEditor,
        [EnumMember(Value = "ESFISalesPerson")]
        EsfiSalesPerson,
        [EnumMember(Value = "ESFISpecialAccount")]
        EsfiSpecialAccount,
        [EnumMember(Value = "ESFISpecialAccountGroup")]
        EsfiSpecialAccountGroup,
        [EnumMember(Value = "ESFISupplier")]
        EsfiSupplier,
        [EnumMember(Value = "ESFISupplierExpert")]
        EsfiSupplierExpert,
        [EnumMember(Value = "ESFITCourier")]
        EsfitCourier,
        [EnumMember(Value = "ESFITradeAccount")]
        EsfiTradeAccount,
        [EnumMember(Value = "ESFITradeAccountContract")]
        EsfiTradeAccountContract,
        [EnumMember(Value = "ESFITradeAccountContractType")]
        EsfiTradeAccountContractType,
        [EnumMember(Value = "ESFITransitionProfile")]
        EsfiTransitionProfile,
        [EnumMember(Value = "ESFITransportPlan")]
        EsfiTransportPlan,
        [EnumMember(Value = "ESFIVoucher")]
        EsfiVoucher,
        [EnumMember(Value = "ESFIVoucherPromotionProfile")]
        EsfiVoucherPromotionProfile,
        [EnumMember(Value = "ESFIWHAccessList")]
        EsfiwhAccessList,
        [EnumMember(Value = "ESFIZAccountPostingDef")]
        EsfizAccountPostingDef,
        [EnumMember(Value = "ESFIZElectronicTransactionsProfile")]
        EsfizElectronicTransactionsProfile,
        [EnumMember(Value = "ESFIZInterestProfile")]
        EsfizInterestProfile,
        [EnumMember(Value = "ESFIZItemCategory")]
        EsfizItemCategory,
        [EnumMember(Value = "ESFIZItemFamily")]
        EsfizItemFamily,
        [EnumMember(Value = "ESFIZItemSubCategory")]
        EsfizItemSubCategory,
        [EnumMember(Value = "ESFIZItemSubFamily")]
        EsfizItemSubFamily,
        [EnumMember(Value = "ESFIZVATExemptionReasoning")]
        EsfizvatExemptionReasoning,
        [EnumMember(Value = "ESGLAccount")]
        EsglAccount,
        [EnumMember(Value = "ESGLAccountingDocumentTemplate")]
        EsglAccountingDocumentTemplate,
        [EnumMember(Value = "ESGLAccountingDocumentType")]
        EsglAccountingDocumentType,
        [EnumMember(Value = "ESGLAllocationProfile")]
        EsglAllocationProfile,
        [EnumMember(Value = "ESGLJournal")]
        EsglJournal,
        [EnumMember(Value = "ESGLLedgerEntry")]
        EsglLedgerEntry,
        ESGlobalBlueDocument,
        [EnumMember(Value = "ESGOAreaMap")]
        EsgoAreaMap,
        [EnumMember(Value = "ESGOColumnsSeq")]
        EsgoColumnsSeq,
        [EnumMember(Value = "ESGOCompany")]
        EsgoCompany,
        [EnumMember(Value = "ESGOCompanyBusinessActivityCodes")]
        EsgoCompanyBusinessActivityCodes,
        [EnumMember(Value = "ESGOCurrency")]
        EsgoCurrency,
        [EnumMember(Value = "ESGOCurrencyExchangeRate")]
        EsgoCurrencyExchangeRate,
        [EnumMember(Value = "ESGOLegalPerson")]
        EsgoLegalPerson,
        [EnumMember(Value = "ESGOMetric")]
        EsgoMetric,
        [EnumMember(Value = "ESGOMetricActual")]
        EsgoMetricActual,
        [EnumMember(Value = "ESGOMetricSet")]
        EsgoMetricSet,
        [EnumMember(Value = "ESGOOrganizationalUnit")]
        EsgoOrganizationalUnit,
        [EnumMember(Value = "ESGOPerson")]
        EsgoPerson,
        [EnumMember(Value = "ESGOPhysicalPerson")]
        EsgoPhysicalPerson,
        [EnumMember(Value = "ESGOPrinter")]
        EsgoPrinter,
        [EnumMember(Value = "ESGOProject")]
        EsgoProject,
        [EnumMember(Value = "ESGOReport")]
        EsgoReport,
        [EnumMember(Value = "ESGOScale")]
        EsgoScale,
        [EnumMember(Value = "ESGOScheduledJob")]
        EsgoScheduledJob,
        [EnumMember(Value = "ESGOScript")]
        EsgoScript,
        [EnumMember(Value = "ESGOSeasonCalendar")]
        EsgoSeasonCalendar,
        [EnumMember(Value = "ESGOSegmentSequence")]
        EsgoSegmentSequence,
        [EnumMember(Value = "ESGOServiceProfile")]
        EsgoServiceProfile,
        [EnumMember(Value = "ESGOShift")]
        EsgoShift,
        [EnumMember(Value = "ESGOUser")]
        EsgoUser,
        [EnumMember(Value = "ESGOVATCategoryMapping")]
        EsgovatCategoryMapping,
        [EnumMember(Value = "ESGOWebUser")]
        EsgoWebUser,
        [EnumMember(Value = "ESGOWorkingCalendar")]
        EsgoWorkingCalendar,
        [EnumMember(Value = "ESGOWorkingCalendarException")]
        EsgoWorkingCalendarException,
        [EnumMember(Value = "ESGOWorkstation")]
        EsgoWorkstation,
        [EnumMember(Value = "ESGOZBusinessActivity")]
        EsgozBusinessActivity,
        [EnumMember(Value = "ESGOZBusinessUnit")]
        EsgozBusinessUnit,
        [EnumMember(Value = "ESGOZDimension1")]
        EsgozDimension1,
        [EnumMember(Value = "ESGOZDimension2")]
        EsgozDimension2,
        [EnumMember(Value = "ESGOZInteractionProfile")]
        EsgozInteractionProfile,
        [EnumMember(Value = "ESMLModel")]
        EsmlModel,
        [EnumMember(Value = "ESMLModelGroup")]
        EsmlModelGroup,
        [EnumMember(Value = "ESMMBOM")]
        Esmmbom,
        [EnumMember(Value = "ESMMCatalogueItem")]
        EsmmCatalogueItem,
        [EnumMember(Value = "ESMMCommercialProfile")]
        EsmmCommercialProfile,
        [EnumMember(Value = "ESMMDeposition")]
        EsmmDeposition,
        [EnumMember(Value = "ESMMItemControlPolicy")]
        EsmmItemControlPolicy,
        [EnumMember(Value = "ESMMItemSellingPrice")]
        EsmmItemSellingPrice,
        [EnumMember(Value = "ESMMLot")]
        EsmmLot,
        [EnumMember(Value = "ESMMMaterialRequirement")]
        EsmmMaterialRequirement,
        [EnumMember(Value = "ESMMMaterialRequirementPlan")]
        EsmmMaterialRequirementPlan,
        [EnumMember(Value = "ESMMMaterialRequirementPlanWithReqs")]
        EsmmMaterialRequirementPlanWithReqs,
        [EnumMember(Value = "ESMMPersonItem")]
        EsmmPersonItem,
        [EnumMember(Value = "ESMMPhaseRouting")]
        EsmmPhaseRouting,
        [EnumMember(Value = "ESMMProductionLeadTimes")]
        EsmmProductionLeadTimes,
        [EnumMember(Value = "ESMMProductionPlan")]
        EsmmProductionPlan,
        [EnumMember(Value = "ESMMProductionPlanDemand")]
        EsmmProductionPlanDemand,
        [EnumMember(Value = "ESMMProductionPlanItem")]
        EsmmProductionPlanItem,
        [EnumMember(Value = "ESMMProductionPlanWithDemands")]
        EsmmProductionPlanWithDemands,
        [EnumMember(Value = "ESMMSerialNumber")]
        EsmmSerialNumber,
        [EnumMember(Value = "ESMMSIMURelation")]
        EsmmsimuRelation,
        [EnumMember(Value = "ESMMSortiment")]
        EsmmSortiment,
        [EnumMember(Value = "ESMMStockDimSet")]
        EsmmStockDimSet,
        [EnumMember(Value = "ESMMStockDimSetMap")]
        EsmmStockDimSetMap,
        [EnumMember(Value = "ESMMStockItem")]
        EsmmStockItem,
        [EnumMember(Value = "ESMMStockOrderModel")]
        EsmmStockOrderModel,
        [EnumMember(Value = "ESMMStockOrderPlan")]
        EsmmStockOrderPlan,
        [EnumMember(Value = "ESMMStockProposalComposition")]
        EsmmStockProposalComposition,
        [EnumMember(Value = "ESMMStockProposalGroup")]
        EsmmStockProposalGroup,
        [EnumMember(Value = "ESMMStorageLocation")]
        EsmmStorageLocation,
        [EnumMember(Value = "ESMMStorageLocationPrinter")]
        EsmmStorageLocationPrinter,
        [EnumMember(Value = "ESMMStorageLocationProfile")]
        EsmmStorageLocationProfile,
        [EnumMember(Value = "ESMMStorageLocationTree")]
        EsmmStorageLocationTree,
        [EnumMember(Value = "ESMMValidStockDimensionsProfile")]
        EsmmValidStockDimensionsProfile,
        [EnumMember(Value = "ESMMZBCProcessingType")]
        EsmmzbcProcessingType,
        [EnumMember(Value = "ESMMZIntrastatCode")]
        EsmmzIntrastatCode,
        [EnumMember(Value = "ESMMZMeasurementUnit")]
        EsmmzMeasurementUnit,
        ESPlanetDocument,
        [EnumMember(Value = "ESTMABCClassificationModel")]
        EstmabcClassificationModel,
        [EnumMember(Value = "ESTMCampaign")]
        EstmCampaign,
        [EnumMember(Value = "ESTMContractTerm")]
        EstmContractTerm,
        [EnumMember(Value = "ESTMInteraction")]
        EstmInteraction,
        [EnumMember(Value = "ESTMMobileTaskType")]
        EstmMobileTaskType,
        [EnumMember(Value = "ESTMNewsletterRecipient")]
        EstmNewsletterRecipient,
        [EnumMember(Value = "ESTMObjectRating")]
        EstmObjectRating,
        [EnumMember(Value = "ESTMOpportunity")]
        EstmOpportunity,
        [EnumMember(Value = "ESTMResource")]
        EstmResource,
        [EnumMember(Value = "ESTMRFMModel")]
        EstmrfmModel,
        [EnumMember(Value = "ESTMRFMResponseModel")]
        EstmrfmResponseModel,
        [EnumMember(Value = "ESTMServiceDefinition")]
        EstmServiceDefinition,
        [EnumMember(Value = "ESTMServiceRequest")]
        EstmServiceRequest,
        [EnumMember(Value = "ESTMSMAccount")]
        EstmsmAccount,
        [EnumMember(Value = "ESTMSMActivity")]
        EstmsmActivity,
        [EnumMember(Value = "ESTMSMCompanyAccount")]
        EstmsmCompanyAccount,
        [EnumMember(Value = "ESTMSMRawObject")]
        EstmsmRawObject,
        [EnumMember(Value = "ESTMStatusCollection")]
        EstmStatusCollection,
        [EnumMember(Value = "ESTMTask")]
        EstmTask,
        [EnumMember(Value = "ESTMTaskCategory")]
        EstmTaskCategory,
        [EnumMember(Value = "ESTMTaskLite")]
        EstmTaskLite,
        [EnumMember(Value = "ESTMTaskType")]
        EstmTaskType,
        [EnumMember(Value = "ESTRPosition")]
        EstrPosition,
        [EnumMember(Value = "ESTRTerritory")]
        EstrTerritory,
        [EnumMember(Value = "ESTRTerritoryBudget")]
        EstrTerritoryBudget,
        [EnumMember(Value = "ESTRTerritoryBudgetTemplate")]
        EstrTerritoryBudgetTemplate,
        [EnumMember(Value = "ESTRTerritoryHierarchy")]
        EstrTerritoryHierarchy,
        [EnumMember(Value = "ESTRTerritoryRulePeriod")]
        EstrTerritoryRulePeriod,
        [EnumMember(Value = "ESWMAction")]
        EswmAction,
        [EnumMember(Value = "ESWMActionType")]
        EswmActionType,
        [EnumMember(Value = "ESWMActionTypeReport")]
        EswmActionTypeReport,
        [EnumMember(Value = "ESWMCancellationDispositionReasonMap")]
        EswmCancellationDispositionReasonMap,
        [EnumMember(Value = "ESWMCancellationReservationReasonMap")]
        EswmCancellationReservationReasonMap,
        [EnumMember(Value = "ESWMContainer")]
        EswmContainer,
        [EnumMember(Value = "ESWMContainerControlPolicy")]
        EswmContainerControlPolicy,
        [EnumMember(Value = "ESWMContainerType")]
        EswmContainerType,
        [EnumMember(Value = "ESWMDepositor")]
        EswmDepositor,
        [EnumMember(Value = "ESWMItemControlPolicy")]
        EswmItemControlPolicy,
        [EnumMember(Value = "ESWMPhaseZoneMapping")]
        EswmPhaseZoneMapping,
        [EnumMember(Value = "ESWMRequest")]
        EswmRequest,
        [EnumMember(Value = "ESWMRequestStringFieldMap")]
        EswmRequestStringFieldMap,
        [EnumMember(Value = "ESWMRequestType")]
        EswmRequestType,
        [EnumMember(Value = "ESWMReservationReasonWHMap")]
        EswmReservationReasonWHMap,
        [EnumMember(Value = "ESWMShipment")]
        EswmShipment,
        [EnumMember(Value = "ESWMStepOperation")]
        EswmStepOperation,
        [EnumMember(Value = "ESWMTransportAction")]
        EswmTransportAction,
        [EnumMember(Value = "ESWMTransportRequest")]
        EswmTransportRequest,
        [EnumMember(Value = "ESWMWorkPackage")]
        EswmWorkPackage,
        [EnumMember(Value = "ESWMWorkPackageType")]
        EswmWorkPackageType,
        [EnumMember(Value = "ESWPActualTask")]
        EswpActualTask,
        [EnumMember(Value = "ESWPActualTaskEntry")]
        EswpActualTaskEntry,
        [EnumMember(Value = "ESWPTaskRequest")]
        EswpTaskRequest,
        [EnumMember(Value = "ESWPWorkPackage")]
        EswpWorkPackage
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputEventTypeType
    {
        Create,
        Update,
        Delete,
        CreateOrUpdate
    }

    public class ESSystemHookPostRegistrationInput
    {
        public ESSystemHookPostRegistrationInput(RegistrationInputSystemEventTypeTypeItem[] systemEventType)
        {
            this.SystemEventType = systemEventType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RegistrationInputSystemEventTypeTypeItem[] SystemEventType { get; set; }
        public string OtherEvent { get; set; }

        [JsonProperty("ExternalID")]
        public string ExternalId { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsActive { get; set; } = true;

        [JsonProperty("CallbackURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegistrationInputSystemEventTypeTypeItem
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

namespace Microsoft.Azure.Workflows.Sdk
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