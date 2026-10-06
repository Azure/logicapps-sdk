//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sap
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildAddRfcToTransaction))]
        public IBodyWorkflowAction<RfcTransactionDetails> AddRfcToTransaction([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RfcTransactionDetails> __BuildAddRfcToTransaction(WorkflowExpression<string> rfcName, WorkflowExpression<string> rfcGroupFilter = null, WorkflowExpression<bool> autoCommit = null, WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(rfcName, nameof(rfcName), required: true);
            WorkflowExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            WorkflowExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
            {
                var apiCallPath = "/AddRfcToTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(autoCommit);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCallBapi))]
        public IBodyWorkflowAction<CallBapiResponse> CallBapi([WorkflowExpression] Func<string> businessObject, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallBapiResponse> __BuildCallBapi(WorkflowExpression<string> businessObject, WorkflowExpression<string> method, WorkflowExpression<bool> autoCommit = null, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(businessObject, nameof(businessObject), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallBapiResponse>(() =>
            {
                var apiCallPath = "/CallBapi";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessObject"] = ExpressionConverter.Convert(businessObject);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Queries["autoCommit"] = Convert.ToString(true);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<CallBapiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCallRfc))]
        public IBodyWorkflowAction<CallRfcResponse> CallRfc([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallRfcResponse> __BuildCallRfc(WorkflowExpression<string> rfcName, WorkflowExpression<string> rfcGroupFilter = null, WorkflowExpression<bool> autoCommit = null, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(rfcName, nameof(rfcName), required: true);
            WorkflowExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            WorkflowExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallRfcResponse>(() =>
            {
                var apiCallPath = "/CallRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<CallRfcResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCallRfc3))]
        public IBodyWorkflowAction<JToken> CallRfc3([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<object> rfcInputs = null, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<inputFormatInput> inputFormat = null, [WorkflowExpression] Func<returnFormatInput> returnFormat = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCallRfc3(WorkflowExpression<string> rfcName, WorkflowExpression<object> rfcInputs = null, WorkflowExpression<string> rfcGroupFilter = null, WorkflowExpression<bool> autoCommit = null, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null, WorkflowExpression<inputFormatInput> inputFormat = null, WorkflowExpression<returnFormatInput> returnFormat = null)
        {
            WorkflowExpression.Validate(rfcName, nameof(rfcName), required: true);
            WorkflowExpression.Validate(rfcInputs, nameof(rfcInputs), required: false);
            WorkflowExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            WorkflowExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            WorkflowExpression.Validate(inputFormat, nameof(inputFormat), required: false);
            WorkflowExpression.Validate(returnFormat, nameof(returnFormat), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CallRfc3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = ExpressionConverter.Convert(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = ExpressionConverter.Convert(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = ExpressionConverter.Convert(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                callPayload.Queries["inputFormat"] = Convert.ToString("Json");
                if (inputFormat != null)
                    callPayload.Queries["inputFormat"] = ExpressionConverter.Convert(inputFormat);
                callPayload.Queries["returnFormat"] = Convert.ToString("Json");
                if (returnFormat != null)
                    callPayload.Queries["returnFormat"] = ExpressionConverter.Convert(returnFormat);
                callPayload.Body = ExpressionConverter.ConvertO(rfcInputs);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCloseSession))]
        public IBodyWorkflowAction<JToken> CloseSession([WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCloseSession(WorkflowExpression<string> sessionId)
        {
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCommitBapiTransaction))]
        public IBodyWorkflowAction<BapiRet2> CommitBapiTransaction([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> wait = null, [WorkflowExpression] Func<bool> closeSession = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BapiRet2> __BuildCommitBapiTransaction(WorkflowExpression<string> sessionId, WorkflowExpression<bool> wait = null, WorkflowExpression<bool> closeSession = null)
        {
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowExpression.Validate(wait, nameof(wait), required: false);
            WorkflowExpression.Validate(closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2>(() =>
            {
                var apiCallPath = "/CommitBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(wait);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (closeSession != null)
                    callPayload.Queries["closeSession"] = ExpressionConverter.Convert(closeSession);
                return new ApiConnectionAction<BapiRet2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCommitRfcTransaction))]
        public IBodyWorkflowAction<JToken> CommitRfcTransaction([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCommitRfcTransaction(WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null)
        {
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CommitRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildConfirmTid))]
        public IBodyWorkflowAction<JToken> ConfirmTid([WorkflowExpression] Func<string> tid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildConfirmTid(WorkflowExpression<string> tid)
        {
            WorkflowExpression.Validate(tid, nameof(tid), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/ConfirmTid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tid"] = ExpressionConverter.Convert(tid);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRfcTransaction))]
        public IBodyWorkflowAction<RfcTransactionDetails> CreateRfcTransaction([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RfcTransactionDetails> __BuildCreateRfcTransaction(WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null)
        {
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
            {
                var apiCallPath = "/CreateRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession()
        {
            var apiCallPath = "/CreateSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateSchemas))]
        public IBodyWorkflowAction<SapConnectorGenerateSchemasResponse> GenerateSchemas([WorkflowExpression] Func<string[]> sapActionUris = null, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SapConnectorGenerateSchemasResponse> __BuildGenerateSchemas(WorkflowExpression<string[]> sapActionUris = null, WorkflowExpression<string> fileNamePrefix = null)
        {
            WorkflowExpression.Validate(sapActionUris, nameof(sapActionUris), required: false);
            WorkflowExpression.Validate(fileNamePrefix, nameof(fileNamePrefix), required: false);
            return new DeferredBodyAction<SapConnectorGenerateSchemasResponse>(() =>
            {
                var apiCallPath = "/GenerateSchemas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileNamePrefix"] = Convert.ToString("");
                if (fileNamePrefix != null)
                    callPayload.Queries["fileNamePrefix"] = ExpressionConverter.Convert(fileNamePrefix);
                callPayload.Body = ExpressionConverter.ConvertO(sapActionUris);
                return new ApiConnectionAction<SapConnectorGenerateSchemasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetIdocStatus))]
        public IBodyWorkflowAction<IdocStatusResponse> GetIdocStatus([WorkflowExpression] Func<int> idocNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdocStatusResponse> __BuildGetIdocStatus(WorkflowExpression<int> idocNumber)
        {
            WorkflowExpression.Validate(idocNumber, nameof(idocNumber), required: true);
            return new DeferredBodyAction<IdocStatusResponse>(() =>
            {
                var apiCallPath = "/GetIdocStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocNumber"] = ExpressionConverter.Convert(idocNumber);
                return new ApiConnectionAction<IdocStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetTransactionDetails))]
        public IBodyWorkflowAction<RfcTransactionDetails> GetTransactionDetails([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RfcTransactionDetails> __BuildGetTransactionDetails(WorkflowExpression<string> tId = null, WorkflowExpression<string> queueName = null)
        {
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            WorkflowExpression.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
            {
                var apiCallPath = "/GetTransactionDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
                return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetTransactionIdocs))]
        public IBodyWorkflowAction<IdocNumbersList> GetTransactionIdocs([WorkflowExpression] Func<directionInput> direction, [WorkflowExpression] Func<string> tId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdocNumbersList> __BuildGetTransactionIdocs(WorkflowExpression<directionInput> direction, WorkflowExpression<string> tId)
        {
            WorkflowExpression.Validate(direction, nameof(direction), required: true);
            WorkflowExpression.Validate(tId, nameof(tId), required: true);
            return new DeferredBodyAction<IdocNumbersList>(() =>
            {
                var apiCallPath = "/GetTransactionIdocs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["direction"] = ExpressionConverter.Convert(direction);
                callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                return new ApiConnectionAction<IdocNumbersList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildReadTableVersion2))]
        public IBodyWorkflowAction<ReadTableResponse> ReadTableVersion2([WorkflowExpression] Func<string> inputParameterstableName, [WorkflowExpression] Func<string[]> inputParametersfieldsToRead = null, [WorkflowExpression] Func<string[]> inputParameterswhereFilters = null, [WorkflowExpression] Func<int> inputParametersstartingRowIndex = null, [WorkflowExpression] Func<int> inputParameterscountOfRowsToRead = null, [WorkflowExpression] Func<string> inputParametersfieldDelimiter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadTableResponse> __BuildReadTableVersion2(WorkflowExpression<string> inputParameterstableName, WorkflowExpression<string[]> inputParametersfieldsToRead = null, WorkflowExpression<string[]> inputParameterswhereFilters = null, WorkflowExpression<int> inputParametersstartingRowIndex = null, WorkflowExpression<int> inputParameterscountOfRowsToRead = null, WorkflowExpression<string> inputParametersfieldDelimiter = null)
        {
            WorkflowExpression.Validate(inputParameterstableName, nameof(inputParameterstableName), required: true);
            WorkflowExpression.Validate(inputParametersfieldsToRead, nameof(inputParametersfieldsToRead), required: false);
            WorkflowExpression.Validate(inputParameterswhereFilters, nameof(inputParameterswhereFilters), required: false);
            WorkflowExpression.Validate(inputParametersstartingRowIndex, nameof(inputParametersstartingRowIndex), required: false);
            WorkflowExpression.Validate(inputParameterscountOfRowsToRead, nameof(inputParameterscountOfRowsToRead), required: false);
            WorkflowExpression.Validate(inputParametersfieldDelimiter, nameof(inputParametersfieldDelimiter), required: false);
            return new DeferredBodyAction<ReadTableResponse>(() =>
            {
                var apiCallPath = "/ReadTableVersion2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputParameters = new JObject();
                var inputParameterspropCount = 0;
                inputParameterspropCount++;
                inputParameters["tableName"] = ExpressionConverter.ConvertO(inputParameterstableName);
                if (inputParametersfieldsToRead != null)
                {
                    inputParameters["FieldNames"] = ExpressionConverter.ConvertO(inputParametersfieldsToRead);
                    inputParameterspropCount++;
                }

                if (inputParameterswhereFilters != null)
                {
                    inputParameters["WhereFilters"] = ExpressionConverter.ConvertO(inputParameterswhereFilters);
                    inputParameterspropCount++;
                }

                if (inputParametersstartingRowIndex != null)
                {
                    inputParameters["StartIndex"] = ExpressionConverter.ConvertO(inputParametersstartingRowIndex);
                    inputParameterspropCount++;
                }

                if (inputParameterscountOfRowsToRead != null)
                {
                    inputParameters["RowCount"] = ExpressionConverter.ConvertO(inputParameterscountOfRowsToRead);
                    inputParameterspropCount++;
                }

                if (inputParametersfieldDelimiter != null)
                {
                    inputParameters["Delimiter"] = ExpressionConverter.ConvertO(inputParametersfieldDelimiter);
                    inputParameterspropCount++;
                }

                if (inputParameterspropCount > 0)
                {
                    callPayload.Body = inputParameters;
                }

                return new ApiConnectionAction<ReadTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildRollbackBapiTransaction))]
        public IBodyWorkflowAction<BapiRet2> RollbackBapiTransaction([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> closeSession = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BapiRet2> __BuildRollbackBapiTransaction(WorkflowExpression<string> sessionId, WorkflowExpression<bool> closeSession = null)
        {
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowExpression.Validate(closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2>(() =>
            {
                var apiCallPath = "/RollbackBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (closeSession != null)
                    callPayload.Queries["closeSession"] = ExpressionConverter.Convert(closeSession);
                return new ApiConnectionAction<BapiRet2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildSend))]
        public IBodyWorkflowAction<JToken> Send([WorkflowExpression] Func<string> sapAction, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSend(WorkflowExpression<string> sapAction, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(sapAction, nameof(sapAction), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sapAction"] = ExpressionConverter.Convert(sapAction);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildSendIDoc))]
        public IBodyWorkflowAction<SendIdocResponse> SendIDoc([WorkflowExpression] Func<string> idocType, [WorkflowExpression] Func<string> releaseVersion = null, [WorkflowExpression] Func<recordTypesVersionInput> recordTypesVersion = null, [WorkflowExpression] Func<bool> confirmTid = null, [WorkflowExpression] Func<string> tid = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendIdocResponse> __BuildSendIDoc(WorkflowExpression<string> idocType, WorkflowExpression<string> releaseVersion = null, WorkflowExpression<recordTypesVersionInput> recordTypesVersion = null, WorkflowExpression<bool> confirmTid = null, WorkflowExpression<string> tid = null, WorkflowExpression<string> body = null, WorkflowExpression<string> contentType = null)
        {
            WorkflowExpression.Validate(idocType, nameof(idocType), required: true);
            WorkflowExpression.Validate(releaseVersion, nameof(releaseVersion), required: false);
            WorkflowExpression.Validate(recordTypesVersion, nameof(recordTypesVersion), required: false);
            WorkflowExpression.Validate(confirmTid, nameof(confirmTid), required: false);
            WorkflowExpression.Validate(tid, nameof(tid), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<SendIdocResponse>(() =>
            {
                var apiCallPath = "/SendIDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocType"] = ExpressionConverter.Convert(idocType);
                callPayload.Queries["releaseVersion"] = Convert.ToString("");
                if (releaseVersion != null)
                    callPayload.Queries["releaseVersion"] = ExpressionConverter.Convert(releaseVersion);
                callPayload.Queries["recordTypesVersion"] = Convert.ToString("3");
                if (recordTypesVersion != null)
                    callPayload.Queries["recordTypesVersion"] = ExpressionConverter.Convert(recordTypesVersion);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (confirmTid != null)
                    callPayload.Queries["confirmTid"] = ExpressionConverter.Convert(confirmTid);
                if (tid != null)
                    callPayload.Queries["tid"] = ExpressionConverter.Convert(tid);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SendIdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildSendIDocVersion2))]
        public IBodyWorkflowAction<SendIdocResponse> SendIDocVersion2([WorkflowExpression] Func<object> dynamicParameters = null, [WorkflowExpression] Func<idocFormatInput> idocFormat = null, [WorkflowExpression] Func<bool> confirmTid = null, [WorkflowExpression] Func<string> tid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendIdocResponse> __BuildSendIDocVersion2(WorkflowExpression<object> dynamicParameters = null, WorkflowExpression<idocFormatInput> idocFormat = null, WorkflowExpression<bool> confirmTid = null, WorkflowExpression<string> tid = null)
        {
            WorkflowExpression.Validate(dynamicParameters, nameof(dynamicParameters), required: false);
            WorkflowExpression.Validate(idocFormat, nameof(idocFormat), required: false);
            WorkflowExpression.Validate(confirmTid, nameof(confirmTid), required: false);
            WorkflowExpression.Validate(tid, nameof(tid), required: false);
            return new DeferredBodyAction<SendIdocResponse>(() =>
            {
                var apiCallPath = "/SendIDoc/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocFormat"] = Convert.ToString("Xml");
                if (idocFormat != null)
                    callPayload.Queries["idocFormat"] = ExpressionConverter.Convert(idocFormat);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (confirmTid != null)
                    callPayload.Queries["confirmTid"] = ExpressionConverter.Convert(confirmTid);
                if (tid != null)
                    callPayload.Queries["tid"] = ExpressionConverter.Convert(tid);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicParameters);
                return new ApiConnectionAction<SendIdocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildStartLongRunningRfc))]
        public IBodyWorkflowAction<SubscribeResponse> StartLongRunningRfc([WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersrFCName, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersinputRFCParametersInline = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersinputRFCParametersReference = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersrFCGroupFilter = null, [WorkflowExpression] Func<bool> callRfcSubscriptionrfcCallParametersautoCommit = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersqueueName = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscribeResponse> __BuildStartLongRunningRfc(WorkflowExpression<string> callRfcSubscriptionrfcCallParametersrFCName, WorkflowExpression<string> callRfcSubscriptionrfcCallParametersinputRFCParametersInline = null, WorkflowExpression<string> callRfcSubscriptionrfcCallParametersinputRFCParametersReference = null, WorkflowExpression<string> callRfcSubscriptionrfcCallParametersrFCGroupFilter = null, WorkflowExpression<bool> callRfcSubscriptionrfcCallParametersautoCommit = null, WorkflowExpression<string> callRfcSubscriptionrfcCallParametersqueueName = null, WorkflowExpression<string> sessionId = null, WorkflowExpression<string> tId = null)
        {
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersrFCName, nameof(callRfcSubscriptionrfcCallParametersrFCName), required: true);
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersinputRFCParametersInline, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersInline), required: false);
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersinputRFCParametersReference, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersReference), required: false);
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersrFCGroupFilter, nameof(callRfcSubscriptionrfcCallParametersrFCGroupFilter), required: false);
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersautoCommit, nameof(callRfcSubscriptionrfcCallParametersautoCommit), required: false);
            WorkflowExpression.Validate(callRfcSubscriptionrfcCallParametersqueueName, nameof(callRfcSubscriptionrfcCallParametersqueueName), required: false);
            WorkflowExpression.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowExpression.Validate(tId, nameof(tId), required: false);
            return new DeferredBodyAction<SubscribeResponse>(() =>
            {
                var apiCallPath = "/StartLongRunningRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
                var callRfcSubscription = new JObject();
                var callRfcSubscriptionpropCount = 0;
                var rfcCallParametersObject = new JObject();
                var rfcCallParametersObjectpropCount = 0;
                rfcCallParametersObjectpropCount++;
                rfcCallParametersObject["RfcName"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersrFCName);
                if (callRfcSubscriptionrfcCallParametersinputRFCParametersInline != null)
                {
                    rfcCallParametersObject["Payload"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersinputRFCParametersInline);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersinputRFCParametersReference != null)
                {
                    rfcCallParametersObject["PayloadReference"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersinputRFCParametersReference);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersrFCGroupFilter != null)
                {
                    rfcCallParametersObject["RfcGroupFilter"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersrFCGroupFilter);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersautoCommit != null)
                {
                    rfcCallParametersObject["AutoCommit"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersautoCommit);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersqueueName != null)
                {
                    rfcCallParametersObject["QueueName"] = ExpressionConverter.ConvertO(callRfcSubscriptionrfcCallParametersqueueName);
                    rfcCallParametersObjectpropCount++;
                }

                if (rfcCallParametersObjectpropCount > 0)
                {
                    callRfcSubscription["RfcCallParameters"] = rfcCallParametersObject;
                    callRfcSubscriptionpropCount++;
                }

                callRfcSubscription["NotificationUrl"] = "#{listCallbackUrl()}";
                callRfcSubscriptionpropCount++;
                if (callRfcSubscriptionpropCount > 0)
                {
                    callPayload.Body = callRfcSubscription;
                }

                return new ApiConnectionAction<SubscribeResponse>(callPayload);
            });
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildSubscribe))]
        public IBodyWorkflowTrigger<SubscribeResponse> Subscribe([WorkflowExpression] Func<string> gatewayHost,[WorkflowExpression] Func<string> gatewayService,[WorkflowExpression] Func<string> programId,[WorkflowExpression] Func<string[]> subscriptionsapActions = null,[WorkflowExpression] Func<subscriptioniDOCFormatInput> subscriptioniDOCFormat = null,[WorkflowExpression] Func<bool> subscriptionreceiveIDOCsWithUnreleasedSegments = null,[WorkflowExpression] Func<string> sncPartnerNames = null,[WorkflowExpression] Func<int> degreeOfParallelism = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<SubscribeResponse> __BuildSubscribe(WorkflowExpression<string> gatewayHost,WorkflowExpression<string> gatewayService,WorkflowExpression<string> programId,WorkflowExpression<string[]> subscriptionsapActions = null,WorkflowExpression<subscriptioniDOCFormatInput> subscriptioniDOCFormat = null,WorkflowExpression<bool> subscriptionreceiveIDOCsWithUnreleasedSegments = null,WorkflowExpression<string> sncPartnerNames = null,WorkflowExpression<int> degreeOfParallelism = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(gatewayHost, nameof(gatewayHost), required: true);
            WorkflowExpression.Validate(gatewayService, nameof(gatewayService), required: true);
            WorkflowExpression.Validate(programId, nameof(programId), required: true);
            WorkflowExpression.Validate(subscriptionsapActions, nameof(subscriptionsapActions), required: false);
            WorkflowExpression.Validate(subscriptioniDOCFormat, nameof(subscriptioniDOCFormat), required: false);
            WorkflowExpression.Validate(subscriptionreceiveIDOCsWithUnreleasedSegments, nameof(subscriptionreceiveIDOCsWithUnreleasedSegments), required: false);
            WorkflowExpression.Validate(sncPartnerNames, nameof(sncPartnerNames), required: false);
            WorkflowExpression.Validate(degreeOfParallelism, nameof(degreeOfParallelism), required: false);
            return new DeferredBodyTrigger<SubscribeResponse>(() =>
            {
                var apiCallPath = "/api/webhooktrigger/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["gatewayHost"] = ExpressionConverter.Convert(gatewayHost);
                callPayload.Queries["gatewayService"] = ExpressionConverter.Convert(gatewayService);
                callPayload.Queries["programId"] = ExpressionConverter.Convert(programId);
                if (sncPartnerNames != null)
                    callPayload.Queries["sncPartnerNames"] = ExpressionConverter.Convert(sncPartnerNames);
                callPayload.Queries["degreeOfParallelism"] = Convert.ToString(-1);
                if (degreeOfParallelism != null)
                    callPayload.Queries["degreeOfParallelism"] = ExpressionConverter.Convert(degreeOfParallelism);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionsapActions != null)
                {
                    subscription["SapActions"] = ExpressionConverter.ConvertO(subscriptionsapActions);
                    subscriptionpropCount++;
                }

                if (subscriptioniDOCFormat != null)
                {
                    subscription["IdocFormat"] = ExpressionConverter.ConvertO(subscriptioniDOCFormat);
                    subscriptionpropCount++;
                }

                if (subscriptionreceiveIDOCsWithUnreleasedSegments != null)
                {
                    subscription["ReceiveIdocsWithUnreleasedSegments"] = ExpressionConverter.ConvertO(subscriptionreceiveIDOCsWithUnreleasedSegments);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }

                return new ApiConnectionTrigger<SubscribeResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class RfcTransactionDetails
    {
        [JsonProperty("RfcNames")]
        public string[] TheNamesOfTheRFCsInTheTransaction { get; set; }

        [JsonProperty("TId")]
        public string TheTransactionIdentifierTID { get; set; }

        [JsonProperty("Guid")]
        public string TheGUIDFormOfTheTransactionIdentifierTID { get; set; }

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

    public enum inputFormatInput
    {
        Json,
        Xml
    }

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
        public int IDOCStatusCode { get; set; }
    }

    public class IdocNumbersList
    {
        [JsonProperty("IdocNumbers")]
        public int[] IDOCNumbers { get; set; }
    }

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

    public class SendIdocResponse
    {
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
    }

    public enum recordTypesVersionInput
    {
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

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

    public enum subscriptioniDOCFormatInput
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