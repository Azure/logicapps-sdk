//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sap
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails, ApiConnectionActionConfiguration> AddRfcToTransaction(Expression<Func<string>> rfcName, Expression<Func<string>> body, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_rfcName = WorkflowExpression.Compile(rfcName, nameof(rfcName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_rfcGroupFilter = WorkflowExpression.Compile(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<RfcTransactionDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddRfcToTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(__workflow_rfcName);
                if (__workflow_rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(__workflow_rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (__workflow_autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(__workflow_autoCommit);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallBapiResponse, ApiConnectionActionConfiguration> CallBapi(Expression<Func<string>> businessObject, Expression<Func<string>> method, Expression<Func<string>> body, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_businessObject = WorkflowExpression.Compile(businessObject, nameof(businessObject), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallBapiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CallBapi";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessObject"] = ExpressionConverter.Convert(__workflow_businessObject);
                callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Queries["autoCommit"] = Convert.ToString(true);
                if (__workflow_autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(__workflow_autoCommit);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CallBapiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallRfcResponse, ApiConnectionActionConfiguration> CallRfc(Expression<Func<string>> rfcName, Expression<Func<string>> body, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_rfcName = WorkflowExpression.Compile(rfcName, nameof(rfcName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_rfcGroupFilter = WorkflowExpression.Compile(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallRfcResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CallRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(__workflow_rfcName);
                if (__workflow_rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(__workflow_rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (__workflow_autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(__workflow_autoCommit);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CallRfcResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CallRfc3(Expression<Func<string>> rfcName, Expression<Func<object>> rfcInputs, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<inputFormatInput>> inputFormat = null, Expression<Func<returnFormatInput>> returnFormat = null)
        {
            var __workflow_rfcName = WorkflowExpression.Compile(rfcName, nameof(rfcName), required: true);
            var __workflow_rfcInputs = WorkflowExpression.Compile(rfcInputs, nameof(rfcInputs), required: true);
            var __workflow_rfcGroupFilter = WorkflowExpression.Compile(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            var __workflow_inputFormat = WorkflowExpression.Compile(inputFormat, nameof(inputFormat), required: false);
            var __workflow_returnFormat = WorkflowExpression.Compile(returnFormat, nameof(returnFormat), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CallRfc3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(__workflow_rfcName);
                if (__workflow_rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(__workflow_rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (__workflow_autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(__workflow_autoCommit);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                callPayload.Queries["inputFormat"] = Convert.ToString("Json");
                if (__workflow_inputFormat != null)
                    callPayload.Queries["inputFormat"] = ExpressionConverter.Convert(__workflow_inputFormat);
                callPayload.Queries["returnFormat"] = Convert.ToString("Json");
                if (__workflow_returnFormat != null)
                    callPayload.Queries["returnFormat"] = ExpressionConverter.Convert(__workflow_returnFormat);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rfcInputs);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CloseSession(Expression<Func<string>> sessionId)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2, ApiConnectionActionConfiguration> CommitBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> wait = null, Expression<Func<bool>> closeSession = null)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_closeSession = WorkflowExpression.Compile(closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CommitBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (__workflow_closeSession != null)
                    callPayload.Queries["closeSession"] = ExpressionConverter.Convert(__workflow_closeSession);
                return new ApiConnectionAction<BapiRet2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CommitRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CommitRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ConfirmTid(Expression<Func<string>> tid)
        {
            var __workflow_tid = WorkflowExpression.Compile(tid, nameof(tid), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ConfirmTid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tid"] = ExpressionConverter.Convert(__workflow_tid);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails, ApiConnectionActionConfiguration> CreateRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionResponse, ApiConnectionActionConfiguration> CreateSession()
        {
            return new DeferredBodyAction<CreateSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CreateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SapConnectorGenerateSchemasResponse, ApiConnectionActionConfiguration> GenerateSchemas(Expression<Func<string[]>> sapActionUris, Expression<Func<string>> fileNamePrefix = null)
        {
            var __workflow_sapActionUris = WorkflowExpression.Compile(sapActionUris, nameof(sapActionUris), required: true);
            var __workflow_fileNamePrefix = WorkflowExpression.Compile(fileNamePrefix, nameof(fileNamePrefix), required: false);
            return new DeferredBodyAction<SapConnectorGenerateSchemasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GenerateSchemas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileNamePrefix"] = Convert.ToString("");
                if (__workflow_fileNamePrefix != null)
                    callPayload.Queries["fileNamePrefix"] = ExpressionConverter.Convert(__workflow_fileNamePrefix);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapActionUris);
                return new ApiConnectionAction<SapConnectorGenerateSchemasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocStatusResponse, ApiConnectionActionConfiguration> GetIdocStatus(Expression<Func<int>> idocNumber)
        {
            var __workflow_idocNumber = WorkflowExpression.Compile(idocNumber, nameof(idocNumber), required: true);
            return new DeferredBodyAction<IdocStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetIdocStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocNumber"] = ExpressionConverter.Convert(__workflow_idocNumber);
                return new ApiConnectionAction<IdocStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails, ApiConnectionActionConfiguration> GetTransactionDetails(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTransactionDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                if (__workflow_queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(__workflow_queueName);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocNumbersList, ApiConnectionActionConfiguration> GetTransactionIdocs(Expression<Func<directionInput>> direction, Expression<Func<string>> tId)
        {
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: true);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            return new DeferredBodyAction<IdocNumbersList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTransactionIdocs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                return new ApiConnectionAction<IdocNumbersList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableResponse, ApiConnectionActionConfiguration> ReadTableVersion2(Expression<Func<ReadTableVersion2Input>> inputParameters)
        {
            var __workflow_inputParameters = WorkflowExpression.Compile(inputParameters, nameof(inputParameters), required: true);
            return new DeferredBodyAction<ReadTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ReadTableVersion2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inputParameters);
                return new ApiConnectionAction<ReadTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2, ApiConnectionActionConfiguration> RollbackBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> closeSession = null)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_closeSession = WorkflowExpression.Compile(closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RollbackBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (__workflow_closeSession != null)
                    callPayload.Queries["closeSession"] = ExpressionConverter.Convert(__workflow_closeSession);
                return new ApiConnectionAction<BapiRet2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Send(Expression<Func<string>> sapAction, Expression<Func<string>> body, Expression<Func<string>> contentType = null)
        {
            var __workflow_sapAction = WorkflowExpression.Compile(sapAction, nameof(sapAction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sapAction"] = ExpressionConverter.Convert(__workflow_sapAction);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse, ApiConnectionActionConfiguration> SendIDoc(Expression<Func<string>> idocType, Expression<Func<string>> body, Expression<Func<string>> releaseVersion = null, Expression<Func<recordTypesVersionInput>> recordTypesVersion = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_idocType = WorkflowExpression.Compile(idocType, nameof(idocType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_releaseVersion = WorkflowExpression.Compile(releaseVersion, nameof(releaseVersion), required: false);
            var __workflow_recordTypesVersion = WorkflowExpression.Compile(recordTypesVersion, nameof(recordTypesVersion), required: false);
            var __workflow_confirmTid = WorkflowExpression.Compile(confirmTid, nameof(confirmTid), required: false);
            var __workflow_tid = WorkflowExpression.Compile(tid, nameof(tid), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<SendIdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SendIDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocType"] = ExpressionConverter.Convert(__workflow_idocType);
                callPayload.Queries["releaseVersion"] = Convert.ToString("");
                if (__workflow_releaseVersion != null)
                    callPayload.Queries["releaseVersion"] = ExpressionConverter.Convert(__workflow_releaseVersion);
                callPayload.Queries["recordTypesVersion"] = Convert.ToString("3");
                if (__workflow_recordTypesVersion != null)
                    callPayload.Queries["recordTypesVersion"] = ExpressionConverter.Convert(__workflow_recordTypesVersion);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (__workflow_confirmTid != null)
                    callPayload.Queries["confirmTid"] = ExpressionConverter.Convert(__workflow_confirmTid);
                if (__workflow_tid != null)
                    callPayload.Queries["tid"] = ExpressionConverter.Convert(__workflow_tid);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendIdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse, ApiConnectionActionConfiguration> SendIDocVersion2(Expression<Func<object>> dynamicParameters, Expression<Func<idocFormatInput>> idocFormat = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null)
        {
            var __workflow_dynamicParameters = WorkflowExpression.Compile(dynamicParameters, nameof(dynamicParameters), required: true);
            var __workflow_idocFormat = WorkflowExpression.Compile(idocFormat, nameof(idocFormat), required: false);
            var __workflow_confirmTid = WorkflowExpression.Compile(confirmTid, nameof(confirmTid), required: false);
            var __workflow_tid = WorkflowExpression.Compile(tid, nameof(tid), required: false);
            return new DeferredBodyAction<SendIdocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SendIDoc/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocFormat"] = Convert.ToString("Xml");
                if (__workflow_idocFormat != null)
                    callPayload.Queries["idocFormat"] = ExpressionConverter.Convert(__workflow_idocFormat);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (__workflow_confirmTid != null)
                    callPayload.Queries["confirmTid"] = ExpressionConverter.Convert(__workflow_confirmTid);
                if (__workflow_tid != null)
                    callPayload.Queries["tid"] = ExpressionConverter.Convert(__workflow_tid);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicParameters);
                return new ApiConnectionAction<SendIdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SubscribeResponse, ApiConnectionActionConfiguration> StartLongRunningRfc(Expression<Func<StartLongRunningRfcInput>> callRfcSubscription, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null)
        {
            var __workflow_callRfcSubscription = WorkflowExpression.Compile(callRfcSubscription, nameof(callRfcSubscription), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            return new DeferredBodyAction<SubscribeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/StartLongRunningRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_callRfcSubscription);
                return new ApiConnectionAction<SubscribeResponse>(callPayload);
            });
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SubscribeResponse, ApiConnectionTriggerConfiguration> Subscribe(Expression<Func<string>> gatewayHost, Expression<Func<string>> gatewayService, Expression<Func<string>> programId, Expression<Func<SubscribeInput>> subscription, Expression<Func<string>> sncPartnerNames = null, Expression<Func<int>> degreeOfParallelism = null, FlowRecurrence recurrence = null)
        {
            var __workflow_gatewayHost = WorkflowExpression.Compile(gatewayHost, nameof(gatewayHost), required: true);
            var __workflow_gatewayService = WorkflowExpression.Compile(gatewayService, nameof(gatewayService), required: true);
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            var __workflow_subscription = WorkflowExpression.Compile(subscription, nameof(subscription), required: true);
            var __workflow_sncPartnerNames = WorkflowExpression.Compile(sncPartnerNames, nameof(sncPartnerNames), required: false);
            var __workflow_degreeOfParallelism = WorkflowExpression.Compile(degreeOfParallelism, nameof(degreeOfParallelism), required: false);
            return new DeferredBodyTrigger<SubscribeResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhooktrigger/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["gatewayHost"] = ExpressionConverter.Convert(__workflow_gatewayHost);
                callPayload.Queries["gatewayService"] = ExpressionConverter.Convert(__workflow_gatewayService);
                callPayload.Queries["programId"] = ExpressionConverter.Convert(__workflow_programId);
                if (__workflow_sncPartnerNames != null)
                    callPayload.Queries["sncPartnerNames"] = ExpressionConverter.Convert(__workflow_sncPartnerNames);
                callPayload.Queries["degreeOfParallelism"] = Convert.ToString(-1);
                if (__workflow_degreeOfParallelism != null)
                    callPayload.Queries["degreeOfParallelism"] = ExpressionConverter.Convert(__workflow_degreeOfParallelism);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscription);
                return new ApiConnectionTrigger<SubscribeResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class RfcTransactionDetails
    {
        [JsonProperty("RfcNames")]
        public string[] TheNamesOfTheRFCsInTheTransaction { get; set; }

        [JsonProperty("TId")]
        public string TheTransactionIdentifierTId { get; set; }

        [JsonProperty("Guid")]
        public string TheGUIdFormOfTheTransactionIdentifierTId { get; set; }

        [JsonProperty("QueueName")]
        public string TheQueueName { get; set; }
    }

    public class CallBapiResponse
    {
        public BapiRet2 BapiReturn { get; set; }

        [JsonProperty("BapiReturns")]
        public BapiRet2[] BAPIReturns { get; set; }

        [JsonProperty("XmlResponse")]
        public string XMLResponse { get; set; }
        public JToken JsonResponse { get; set; }
    }

    public class BapiRet2
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public string Number { get; set; }
        public string Message { get; set; }
        public string LogNumber { get; set; }
        public string LogMessageNumber { get; set; }
        public string MessageVariable1 { get; set; }
        public string MessageVariable2 { get; set; }
        public string MessageVariable3 { get; set; }
        public string MessageVariable4 { get; set; }
        public string Parameter { get; set; }
        public int Row { get; set; }
        public string Field { get; set; }
        public string System { get; set; }
    }

    public class CallRfcResponse
    {
        [JsonProperty("XmlResponse")]
        public string XMLResponse { get; set; }
        public JToken JsonResponse { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inputFormatInput
    {
        Json,
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum returnFormatInput
    {
        Json,
        Xml
    }

    public class CreateSessionResponse
    {
        public string SessionId { get; set; }
    }

    public class SapConnectorGenerateSchemasResponse
    {
        public SapConnectorSchema[] Schemas { get; set; }
    }

    public class SapConnectorSchema
    {
        public string Name { get; set; }
        public string Content { get; set; }
    }

    public class IdocStatusResponse
    {
        [JsonProperty("IdocStatus")]
        public int IdOCStatusCode { get; set; }
    }

    public class IdocNumbersList
    {
        [JsonProperty("IdocNumbers")]
        public int[] IdOCNumbers { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum directionInput
    {
        Send,
        Receive
    }

    public class ReadTableResponse
    {
        [JsonProperty("XmlResponse")]
        public string XMLResponse { get; set; }
        public FieldMetadata[] FieldsMetadata { get; set; }
        public string[] Rows { get; set; }
    }

    public class FieldMetadata
    {
        [JsonProperty("Name")]
        public string FieldName { get; set; }

        [JsonProperty("Offset")]
        public int FieldOffset { get; set; }

        [JsonProperty("Length")]
        public int FieldLength { get; set; }

        [JsonProperty("AbapDataType")]
        public string ABAPDataType { get; set; }

        [JsonProperty("Description")]
        public string FieldDescription { get; set; }
    }

    public class ReadTableVersion2Input
    {
        [JsonProperty("tableName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TableName { get; set; }

        [JsonProperty("FieldNames")]
        public string[] FieldsToRead { get; set; }
        public string[] WhereFilters { get; set; }

        [JsonProperty("StartIndex")]
        public int? StartingRowIndex { get; set; }

        [JsonProperty("RowCount")]
        public int? CountOfRowsToRead { get; set; }

        [JsonProperty("Delimiter")]
        public string FieldDelimiter { get; set; }
    }

    public class SendIdocResponse
    {
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordTypesVersionInput
    {
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum idocFormatInput
    {
        Xml,
        FlatFile
    }

    public class SubscribeResponse
    {
        public SubscribeResponseCodeType Code { get; set; }
        public string WebhookUriHash { get; set; }
        public string RenewInterval { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscribeResponseCodeType
    {
        Continue,
        SwitchingProtocols,
        OK,
        Created,
        Accepted,
        NonAuthoritativeInformation,
        NoContent,
        ResetContent,
        PartialContent,
        MultipleChoices,
        Ambiguous,
        MovedPermanently,
        Moved,
        Found,
        Redirect,
        SeeOther,
        RedirectMethod,
        NotModified,
        UseProxy,
        Unused,
        TemporaryRedirect,
        RedirectKeepVerb,
        BadRequest,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        MethodNotAllowed,
        NotAcceptable,
        ProxyAuthenticationRequired,
        RequestTimeout,
        Conflict,
        Gone,
        LengthRequired,
        PreconditionFailed,
        RequestEntityTooLarge,
        RequestUriTooLong,
        UnsupportedMediaType,
        RequestedRangeNotSatisfiable,
        ExpectationFailed,
        UpgradeRequired,
        InternalServerError,
        NotImplemented,
        BadGateway,
        ServiceUnavailable,
        GatewayTimeout,
        HttpVersionNotSupported
    }

    public class StartLongRunningRfcInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RfcCallParameters RfcCallParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class RfcCallParameters
    {
        [JsonProperty("RfcName")]
        public string RFCName { get; set; }

        [JsonProperty("Payload")]
        public string InputRFCParametersInline { get; set; }

        [JsonProperty("PayloadReference")]
        public string InputRFCParametersReference { get; set; }

        [JsonProperty("RfcGroupFilter")]
        public string RFCGroupFilter { get; set; }
        public bool AutoCommit { get; set; }
        public string QueueName { get; set; }
    }

    public class SubscribeInput
    {
        public string[] SapActions { get; set; }

        [JsonProperty("IdocFormat")]
        public SubscribeInputIdOCFormatType? IdOCFormat { get; set; }

        [JsonProperty("ReceiveIdocsWithUnreleasedSegments")]
        public bool? ReceiveIdOCsWithUnreleasedSegments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscribeInputIdOCFormatType
    {
        MicrosoftLobNamespaceXml,
        SapPlainXml,
        FlatFile
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sap;

    public partial class WorkflowManagedActions
    {
        public SapActions Sap(string connectionId) => new SapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SapTriggers Sap(string connectionId) => new SapTriggers(connectionId);
    }
}