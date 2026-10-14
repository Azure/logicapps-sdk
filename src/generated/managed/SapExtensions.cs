//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sap
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> AddRfcToTransaction(Expression<Func<string>> rfcName, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_rfcName = rfcName == null ? null : WorkflowExpression.Compile(rfcName);
            WorkflowExpression.Validate(__workflow_rfcName, nameof(rfcName), required: true);
            var __workflow_rfcGroupFilter = rfcGroupFilter == null ? null : WorkflowExpression.Compile(rfcGroupFilter);
            WorkflowExpression.Validate(__workflow_rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = autoCommit == null ? null : WorkflowExpression.Compile(autoCommit);
            WorkflowExpression.Validate(__workflow_autoCommit, nameof(autoCommit), required: false);
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
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
        public IBodyWorkflowAction<CallBapiResponse> CallBapi(Expression<Func<string>> businessObject, Expression<Func<string>> method, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_businessObject = businessObject == null ? null : WorkflowExpression.Compile(businessObject);
            WorkflowExpression.Validate(__workflow_businessObject, nameof(businessObject), required: true);
            var __workflow_method = method == null ? null : WorkflowExpression.Compile(method);
            WorkflowExpression.Validate(__workflow_method, nameof(method), required: true);
            var __workflow_autoCommit = autoCommit == null ? null : WorkflowExpression.Compile(autoCommit);
            WorkflowExpression.Validate(__workflow_autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallBapiResponse>(() =>
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
        public IBodyWorkflowAction<CallRfcResponse> CallRfc(Expression<Func<string>> rfcName, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_rfcName = rfcName == null ? null : WorkflowExpression.Compile(rfcName);
            WorkflowExpression.Validate(__workflow_rfcName, nameof(rfcName), required: true);
            var __workflow_rfcGroupFilter = rfcGroupFilter == null ? null : WorkflowExpression.Compile(rfcGroupFilter);
            WorkflowExpression.Validate(__workflow_rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = autoCommit == null ? null : WorkflowExpression.Compile(autoCommit);
            WorkflowExpression.Validate(__workflow_autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<CallRfcResponse>(() =>
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
        public IBodyWorkflowAction<JToken> CallRfc3(Expression<Func<string>> rfcName, Expression<Func<object>> rfcInputs = null, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<inputFormatInput>> inputFormat = null, Expression<Func<returnFormatInput>> returnFormat = null)
        {
            var __workflow_rfcName = rfcName == null ? null : WorkflowExpression.Compile(rfcName);
            WorkflowExpression.Validate(__workflow_rfcName, nameof(rfcName), required: true);
            var __workflow_rfcInputs = rfcInputs == null ? null : WorkflowExpression.Compile(rfcInputs);
            WorkflowExpression.Validate(__workflow_rfcInputs, nameof(rfcInputs), required: false);
            var __workflow_rfcGroupFilter = rfcGroupFilter == null ? null : WorkflowExpression.Compile(rfcGroupFilter);
            WorkflowExpression.Validate(__workflow_rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            var __workflow_autoCommit = autoCommit == null ? null : WorkflowExpression.Compile(autoCommit);
            WorkflowExpression.Validate(__workflow_autoCommit, nameof(autoCommit), required: false);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            var __workflow_inputFormat = inputFormat == null ? null : WorkflowExpression.Compile(inputFormat);
            WorkflowExpression.Validate(__workflow_inputFormat, nameof(inputFormat), required: false);
            var __workflow_returnFormat = returnFormat == null ? null : WorkflowExpression.Compile(returnFormat);
            WorkflowExpression.Validate(__workflow_returnFormat, nameof(returnFormat), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> CloseSession(Expression<Func<string>> sessionId)
        {
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/CloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2> CommitBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> wait = null, Expression<Func<bool>> closeSession = null)
        {
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: true);
            var __workflow_wait = wait == null ? null : WorkflowExpression.Compile(wait);
            WorkflowExpression.Validate(__workflow_wait, nameof(wait), required: false);
            var __workflow_closeSession = closeSession == null ? null : WorkflowExpression.Compile(closeSession);
            WorkflowExpression.Validate(__workflow_closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2>(() =>
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
        public IBodyWorkflowAction<JToken> CommitRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<JToken> ConfirmTid(Expression<Func<string>> tid)
        {
            var __workflow_tid = tid == null ? null : WorkflowExpression.Compile(tid);
            WorkflowExpression.Validate(__workflow_tid, nameof(tid), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/ConfirmTid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tid"] = ExpressionConverter.Convert(__workflow_tid);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> CreateRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
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
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession()
        {
            var apiCallPath = "/CreateSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CreateSessionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SapConnectorGenerateSchemasResponse> GenerateSchemas(Expression<Func<string[]>> sapActionUris = null, Expression<Func<string>> fileNamePrefix = null)
        {
            var __workflow_sapActionUris = sapActionUris == null ? null : WorkflowExpression.Compile(sapActionUris);
            WorkflowExpression.Validate(__workflow_sapActionUris, nameof(sapActionUris), required: false);
            var __workflow_fileNamePrefix = fileNamePrefix == null ? null : WorkflowExpression.Compile(fileNamePrefix);
            WorkflowExpression.Validate(__workflow_fileNamePrefix, nameof(fileNamePrefix), required: false);
            return new DeferredBodyAction<SapConnectorGenerateSchemasResponse>(() =>
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
        public IBodyWorkflowAction<IdocStatusResponse> GetIdocStatus(Expression<Func<int>> idocNumber)
        {
            var __workflow_idocNumber = idocNumber == null ? null : WorkflowExpression.Compile(idocNumber);
            WorkflowExpression.Validate(__workflow_idocNumber, nameof(idocNumber), required: true);
            return new DeferredBodyAction<IdocStatusResponse>(() =>
            {
                var apiCallPath = "/GetIdocStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocNumber"] = ExpressionConverter.Convert(__workflow_idocNumber);
                return new ApiConnectionAction<IdocStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> GetTransactionDetails(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            var __workflow_queueName = queueName == null ? null : WorkflowExpression.Compile(queueName);
            WorkflowExpression.Validate(__workflow_queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<RfcTransactionDetails>(() =>
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
        public IBodyWorkflowAction<IdocNumbersList> GetTransactionIdocs(Expression<Func<directionInput>> direction, Expression<Func<string>> tId)
        {
            var __workflow_direction = direction == null ? null : WorkflowExpression.Compile(direction);
            WorkflowExpression.Validate(__workflow_direction, nameof(direction), required: true);
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: true);
            return new DeferredBodyAction<IdocNumbersList>(() =>
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
        public IBodyWorkflowAction<ReadTableResponse> ReadTableVersion2(Expression<Func<string>> inputParameterstableName, Expression<Func<string[]>> inputParametersfieldsToRead = null, Expression<Func<string[]>> inputParameterswhereFilters = null, Expression<Func<int>> inputParametersstartingRowIndex = null, Expression<Func<int>> inputParameterscountOfRowsToRead = null, Expression<Func<string>> inputParametersfieldDelimiter = null)
        {
            var __workflow_inputParameterstableName = inputParameterstableName == null ? null : WorkflowExpression.Compile(inputParameterstableName);
            WorkflowExpression.Validate(__workflow_inputParameterstableName, nameof(inputParameterstableName), required: true);
            var __workflow_inputParametersfieldsToRead = inputParametersfieldsToRead == null ? null : WorkflowExpression.Compile(inputParametersfieldsToRead);
            WorkflowExpression.Validate(__workflow_inputParametersfieldsToRead, nameof(inputParametersfieldsToRead), required: false);
            var __workflow_inputParameterswhereFilters = inputParameterswhereFilters == null ? null : WorkflowExpression.Compile(inputParameterswhereFilters);
            WorkflowExpression.Validate(__workflow_inputParameterswhereFilters, nameof(inputParameterswhereFilters), required: false);
            var __workflow_inputParametersstartingRowIndex = inputParametersstartingRowIndex == null ? null : WorkflowExpression.Compile(inputParametersstartingRowIndex);
            WorkflowExpression.Validate(__workflow_inputParametersstartingRowIndex, nameof(inputParametersstartingRowIndex), required: false);
            var __workflow_inputParameterscountOfRowsToRead = inputParameterscountOfRowsToRead == null ? null : WorkflowExpression.Compile(inputParameterscountOfRowsToRead);
            WorkflowExpression.Validate(__workflow_inputParameterscountOfRowsToRead, nameof(inputParameterscountOfRowsToRead), required: false);
            var __workflow_inputParametersfieldDelimiter = inputParametersfieldDelimiter == null ? null : WorkflowExpression.Compile(inputParametersfieldDelimiter);
            WorkflowExpression.Validate(__workflow_inputParametersfieldDelimiter, nameof(inputParametersfieldDelimiter), required: false);
            return new DeferredBodyAction<ReadTableResponse>(() =>
            {
                var apiCallPath = "/ReadTableVersion2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputParameters = new JObject();
                var inputParameterspropCount = 0;
                inputParameterspropCount++;
                inputParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_inputParameterstableName);
                if (__workflow_inputParametersfieldsToRead != null)
                {
                    inputParameters["FieldNames"] = ExpressionConverter.ConvertO(__workflow_inputParametersfieldsToRead);
                    inputParameterspropCount++;
                }

                if (__workflow_inputParameterswhereFilters != null)
                {
                    inputParameters["WhereFilters"] = ExpressionConverter.ConvertO(__workflow_inputParameterswhereFilters);
                    inputParameterspropCount++;
                }

                if (__workflow_inputParametersstartingRowIndex != null)
                {
                    inputParameters["StartIndex"] = ExpressionConverter.ConvertO(__workflow_inputParametersstartingRowIndex);
                    inputParameterspropCount++;
                }

                if (__workflow_inputParameterscountOfRowsToRead != null)
                {
                    inputParameters["RowCount"] = ExpressionConverter.ConvertO(__workflow_inputParameterscountOfRowsToRead);
                    inputParameterspropCount++;
                }

                if (__workflow_inputParametersfieldDelimiter != null)
                {
                    inputParameters["Delimiter"] = ExpressionConverter.ConvertO(__workflow_inputParametersfieldDelimiter);
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
        public IBodyWorkflowAction<BapiRet2> RollbackBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> closeSession = null)
        {
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: true);
            var __workflow_closeSession = closeSession == null ? null : WorkflowExpression.Compile(closeSession);
            WorkflowExpression.Validate(__workflow_closeSession, nameof(closeSession), required: false);
            return new DeferredBodyAction<BapiRet2>(() =>
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
        public IBodyWorkflowAction<JToken> Send(Expression<Func<string>> sapAction, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_sapAction = sapAction == null ? null : WorkflowExpression.Compile(sapAction);
            WorkflowExpression.Validate(__workflow_sapAction, nameof(sapAction), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<SendIdocResponse> SendIDoc(Expression<Func<string>> idocType, Expression<Func<string>> releaseVersion = null, Expression<Func<recordTypesVersionInput>> recordTypesVersion = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var __workflow_idocType = idocType == null ? null : WorkflowExpression.Compile(idocType);
            WorkflowExpression.Validate(__workflow_idocType, nameof(idocType), required: true);
            var __workflow_releaseVersion = releaseVersion == null ? null : WorkflowExpression.Compile(releaseVersion);
            WorkflowExpression.Validate(__workflow_releaseVersion, nameof(releaseVersion), required: false);
            var __workflow_recordTypesVersion = recordTypesVersion == null ? null : WorkflowExpression.Compile(recordTypesVersion);
            WorkflowExpression.Validate(__workflow_recordTypesVersion, nameof(recordTypesVersion), required: false);
            var __workflow_confirmTid = confirmTid == null ? null : WorkflowExpression.Compile(confirmTid);
            WorkflowExpression.Validate(__workflow_confirmTid, nameof(confirmTid), required: false);
            var __workflow_tid = tid == null ? null : WorkflowExpression.Compile(tid);
            WorkflowExpression.Validate(__workflow_tid, nameof(tid), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: false);
            return new DeferredBodyAction<SendIdocResponse>(() =>
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
        public IBodyWorkflowAction<SendIdocResponse> SendIDocVersion2(Expression<Func<object>> dynamicParameters = null, Expression<Func<idocFormatInput>> idocFormat = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null)
        {
            var __workflow_dynamicParameters = dynamicParameters == null ? null : WorkflowExpression.Compile(dynamicParameters);
            WorkflowExpression.Validate(__workflow_dynamicParameters, nameof(dynamicParameters), required: false);
            var __workflow_idocFormat = idocFormat == null ? null : WorkflowExpression.Compile(idocFormat);
            WorkflowExpression.Validate(__workflow_idocFormat, nameof(idocFormat), required: false);
            var __workflow_confirmTid = confirmTid == null ? null : WorkflowExpression.Compile(confirmTid);
            WorkflowExpression.Validate(__workflow_confirmTid, nameof(confirmTid), required: false);
            var __workflow_tid = tid == null ? null : WorkflowExpression.Compile(tid);
            WorkflowExpression.Validate(__workflow_tid, nameof(tid), required: false);
            return new DeferredBodyAction<SendIdocResponse>(() =>
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
        public IBodyWorkflowAction<SubscribeResponse> StartLongRunningRfc(Expression<Func<string>> callRfcSubscriptionrfcCallParametersrFCName, Expression<Func<string>> callRfcSubscriptionrfcCallParametersinputRFCParametersInline = null, Expression<Func<string>> callRfcSubscriptionrfcCallParametersinputRFCParametersReference = null, Expression<Func<string>> callRfcSubscriptionrfcCallParametersrFCGroupFilter = null, Expression<Func<bool>> callRfcSubscriptionrfcCallParametersautoCommit = null, Expression<Func<string>> callRfcSubscriptionrfcCallParametersqueueName = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null)
        {
            var __workflow_callRfcSubscriptionrfcCallParametersrFCName = callRfcSubscriptionrfcCallParametersrFCName == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersrFCName);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersrFCName, nameof(callRfcSubscriptionrfcCallParametersrFCName), required: true);
            var __workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersInline = callRfcSubscriptionrfcCallParametersinputRFCParametersInline == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersinputRFCParametersInline);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersInline, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersInline), required: false);
            var __workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersReference = callRfcSubscriptionrfcCallParametersinputRFCParametersReference == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersinputRFCParametersReference);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersReference, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersReference), required: false);
            var __workflow_callRfcSubscriptionrfcCallParametersrFCGroupFilter = callRfcSubscriptionrfcCallParametersrFCGroupFilter == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersrFCGroupFilter);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersrFCGroupFilter, nameof(callRfcSubscriptionrfcCallParametersrFCGroupFilter), required: false);
            var __workflow_callRfcSubscriptionrfcCallParametersautoCommit = callRfcSubscriptionrfcCallParametersautoCommit == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersautoCommit);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersautoCommit, nameof(callRfcSubscriptionrfcCallParametersautoCommit), required: false);
            var __workflow_callRfcSubscriptionrfcCallParametersqueueName = callRfcSubscriptionrfcCallParametersqueueName == null ? null : WorkflowExpression.Compile(callRfcSubscriptionrfcCallParametersqueueName);
            WorkflowExpression.Validate(__workflow_callRfcSubscriptionrfcCallParametersqueueName, nameof(callRfcSubscriptionrfcCallParametersqueueName), required: false);
            var __workflow_sessionId = sessionId == null ? null : WorkflowExpression.Compile(sessionId);
            WorkflowExpression.Validate(__workflow_sessionId, nameof(sessionId), required: false);
            var __workflow_tId = tId == null ? null : WorkflowExpression.Compile(tId);
            WorkflowExpression.Validate(__workflow_tId, nameof(tId), required: false);
            return new DeferredBodyAction<SubscribeResponse>(() =>
            {
                var apiCallPath = "/StartLongRunningRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_tId != null)
                    callPayload.Queries["tId"] = ExpressionConverter.Convert(__workflow_tId);
                var callRfcSubscription = new JObject();
                var callRfcSubscriptionpropCount = 0;
                var rfcCallParametersObject = new JObject();
                var rfcCallParametersObjectpropCount = 0;
                rfcCallParametersObjectpropCount++;
                rfcCallParametersObject["RfcName"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersrFCName);
                if (__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersInline != null)
                {
                    rfcCallParametersObject["Payload"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersInline);
                    rfcCallParametersObjectpropCount++;
                }

                if (__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersReference != null)
                {
                    rfcCallParametersObject["PayloadReference"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersinputRFCParametersReference);
                    rfcCallParametersObjectpropCount++;
                }

                if (__workflow_callRfcSubscriptionrfcCallParametersrFCGroupFilter != null)
                {
                    rfcCallParametersObject["RfcGroupFilter"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersrFCGroupFilter);
                    rfcCallParametersObjectpropCount++;
                }

                if (__workflow_callRfcSubscriptionrfcCallParametersautoCommit != null)
                {
                    rfcCallParametersObject["AutoCommit"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersautoCommit);
                    rfcCallParametersObjectpropCount++;
                }

                if (__workflow_callRfcSubscriptionrfcCallParametersqueueName != null)
                {
                    rfcCallParametersObject["QueueName"] = ExpressionConverter.ConvertO(__workflow_callRfcSubscriptionrfcCallParametersqueueName);
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
        public IBodyWorkflowTrigger<SubscribeResponse> Subscribe(Expression<Func<string>> gatewayHost, Expression<Func<string>> gatewayService, Expression<Func<string>> programId, Expression<Func<string[]>> subscriptionsapActions = null, Expression<Func<subscriptioniDOCFormatInput>> subscriptioniDOCFormat = null, Expression<Func<bool>> subscriptionreceiveIDOCsWithUnreleasedSegments = null, Expression<Func<string>> sncPartnerNames = null, Expression<Func<int>> degreeOfParallelism = null, FlowRecurrence recurrence = null)
        {
            var __workflow_gatewayHost = gatewayHost == null ? null : WorkflowExpression.Compile(gatewayHost);
            WorkflowExpression.Validate(__workflow_gatewayHost, nameof(gatewayHost), required: true);
            var __workflow_gatewayService = gatewayService == null ? null : WorkflowExpression.Compile(gatewayService);
            WorkflowExpression.Validate(__workflow_gatewayService, nameof(gatewayService), required: true);
            var __workflow_programId = programId == null ? null : WorkflowExpression.Compile(programId);
            WorkflowExpression.Validate(__workflow_programId, nameof(programId), required: true);
            var __workflow_subscriptionsapActions = subscriptionsapActions == null ? null : WorkflowExpression.Compile(subscriptionsapActions);
            WorkflowExpression.Validate(__workflow_subscriptionsapActions, nameof(subscriptionsapActions), required: false);
            var __workflow_subscriptioniDOCFormat = subscriptioniDOCFormat == null ? null : WorkflowExpression.Compile(subscriptioniDOCFormat);
            WorkflowExpression.Validate(__workflow_subscriptioniDOCFormat, nameof(subscriptioniDOCFormat), required: false);
            var __workflow_subscriptionreceiveIDOCsWithUnreleasedSegments = subscriptionreceiveIDOCsWithUnreleasedSegments == null ? null : WorkflowExpression.Compile(subscriptionreceiveIDOCsWithUnreleasedSegments);
            WorkflowExpression.Validate(__workflow_subscriptionreceiveIDOCsWithUnreleasedSegments, nameof(subscriptionreceiveIDOCsWithUnreleasedSegments), required: false);
            var __workflow_sncPartnerNames = sncPartnerNames == null ? null : WorkflowExpression.Compile(sncPartnerNames);
            WorkflowExpression.Validate(__workflow_sncPartnerNames, nameof(sncPartnerNames), required: false);
            var __workflow_degreeOfParallelism = degreeOfParallelism == null ? null : WorkflowExpression.Compile(degreeOfParallelism);
            WorkflowExpression.Validate(__workflow_degreeOfParallelism, nameof(degreeOfParallelism), required: false);
            return new DeferredBodyTrigger<SubscribeResponse>(() =>
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
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (__workflow_subscriptionsapActions != null)
                {
                    subscription["SapActions"] = ExpressionConverter.ConvertO(__workflow_subscriptionsapActions);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptioniDOCFormat != null)
                {
                    subscription["IdocFormat"] = ExpressionConverter.ConvertO(__workflow_subscriptioniDOCFormat);
                    subscriptionpropCount++;
                }

                if (__workflow_subscriptionreceiveIDOCsWithUnreleasedSegments != null)
                {
                    subscription["ReceiveIdocsWithUnreleasedSegments"] = ExpressionConverter.ConvertO(__workflow_subscriptionreceiveIDOCsWithUnreleasedSegments);
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
        public int IDOCStatusCode { get; set; }
    }

    public class IdocNumbersList
    {
        [JsonProperty("IdocNumbers")]
        public int[] IDOCNumbers { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
