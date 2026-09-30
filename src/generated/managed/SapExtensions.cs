//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> AddRfcToTransaction([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(rfcName, nameof(rfcName), required: true);
            SourceExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            SourceExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddRfcToTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = SourceExpressionConverter.ConvertO(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = SourceExpressionConverter.ConvertO(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = SourceExpressionConverter.ConvertO(autoCommit);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<RfcTransactionDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallBapiResponse> CallBapi([WorkflowExpression] Func<string> businessObject, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(businessObject, nameof(businessObject), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CallBapi";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessObject"] = SourceExpressionConverter.ConvertO(businessObject);
                callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Queries["autoCommit"] = Convert.ToString(true);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = SourceExpressionConverter.ConvertO(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CallBapiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallRfcResponse> CallRfc([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(rfcName, nameof(rfcName), required: true);
            SourceExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            SourceExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CallRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = SourceExpressionConverter.ConvertO(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = SourceExpressionConverter.ConvertO(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = SourceExpressionConverter.ConvertO(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CallRfcResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CallRfc3([WorkflowExpression] Func<string> rfcName, [WorkflowExpression] Func<object> rfcInputs = null, [WorkflowExpression] Func<string> rfcGroupFilter = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<inputFormatInput> inputFormat = null, [WorkflowExpression] Func<returnFormatInput> returnFormat = null)
        {
            SourceExpression.Validate(rfcName, nameof(rfcName), required: true);
            SourceExpression.Validate(rfcInputs, nameof(rfcInputs), required: false);
            SourceExpression.Validate(rfcGroupFilter, nameof(rfcGroupFilter), required: false);
            SourceExpression.Validate(autoCommit, nameof(autoCommit), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            SourceExpression.Validate(inputFormat, nameof(inputFormat), required: false);
            SourceExpression.Validate(returnFormat, nameof(returnFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CallRfc3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rfcName"] = SourceExpressionConverter.ConvertO(rfcName);
                if (rfcGroupFilter != null)
                    callPayload.Queries["rfcGroupFilter"] = SourceExpressionConverter.ConvertO(rfcGroupFilter);
                callPayload.Queries["autoCommit"] = Convert.ToString(false);
                if (autoCommit != null)
                    callPayload.Queries["autoCommit"] = SourceExpressionConverter.ConvertO(autoCommit);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                callPayload.Queries["inputFormat"] = Convert.ToString("Json");
                if (inputFormat != null)
                    callPayload.Queries["inputFormat"] = SourceExpressionConverter.Convert(inputFormat);
                callPayload.Queries["returnFormat"] = Convert.ToString("Json");
                if (returnFormat != null)
                    callPayload.Queries["returnFormat"] = SourceExpressionConverter.Convert(returnFormat);
                callPayload.Body = SourceExpressionConverter.ConvertToken(rfcInputs);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CloseSession([WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2> CommitBapiTransaction([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> wait = null, [WorkflowExpression] Func<bool> closeSession = null)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(wait, nameof(wait), required: false);
            SourceExpression.Validate(closeSession, nameof(closeSession), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CommitBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["wait"] = Convert.ToString(false);
                if (wait != null)
                    callPayload.Queries["wait"] = SourceExpressionConverter.ConvertO(wait);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (closeSession != null)
                    callPayload.Queries["closeSession"] = SourceExpressionConverter.ConvertO(closeSession);
                return callPayload;
            }

            return new ApiConnectionAction<BapiRet2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CommitRfcTransaction([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CommitRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> ConfirmTid([WorkflowExpression] Func<string> tid)
        {
            SourceExpression.Validate(tid, nameof(tid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ConfirmTid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tid"] = SourceExpressionConverter.ConvertO(tid);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> CreateRfcTransaction([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateRfcTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                return callPayload;
            }

            return new ApiConnectionAction<RfcTransactionDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CreateSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CreateSessionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SapConnectorGenerateSchemasResponse> GenerateSchemas([WorkflowExpression] Func<string[]> sapActionUris = null, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            SourceExpression.Validate(sapActionUris, nameof(sapActionUris), required: false);
            SourceExpression.Validate(fileNamePrefix, nameof(fileNamePrefix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GenerateSchemas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileNamePrefix"] = Convert.ToString("");
                if (fileNamePrefix != null)
                    callPayload.Queries["fileNamePrefix"] = SourceExpressionConverter.ConvertO(fileNamePrefix);
                callPayload.Body = SourceExpressionConverter.ConvertToken(sapActionUris);
                return callPayload;
            }

            return new ApiConnectionAction<SapConnectorGenerateSchemasResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocStatusResponse> GetIdocStatus([WorkflowExpression] Func<int> idocNumber)
        {
            SourceExpression.Validate(idocNumber, nameof(idocNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetIdocStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocNumber"] = SourceExpressionConverter.ConvertO(idocNumber);
                return callPayload;
            }

            return new ApiConnectionAction<IdocStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> GetTransactionDetails([WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null)
        {
            SourceExpression.Validate(tId, nameof(tId), required: false);
            SourceExpression.Validate(queueName, nameof(queueName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTransactionDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                if (queueName != null)
                    callPayload.Queries["queueName"] = SourceExpressionConverter.ConvertO(queueName);
                return callPayload;
            }

            return new ApiConnectionAction<RfcTransactionDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocNumbersList> GetTransactionIdocs([WorkflowExpression] Func<directionInput> direction, [WorkflowExpression] Func<string> tId)
        {
            SourceExpression.Validate(direction, nameof(direction), required: true);
            SourceExpression.Validate(tId, nameof(tId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTransactionIdocs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["direction"] = SourceExpressionConverter.Convert(direction);
                callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                return callPayload;
            }

            return new ApiConnectionAction<IdocNumbersList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableResponse> ReadTableVersion2([WorkflowExpression] Func<string> inputParameterstableName, [WorkflowExpression] Func<string[]> inputParametersfieldsToRead = null, [WorkflowExpression] Func<string[]> inputParameterswhereFilters = null, [WorkflowExpression] Func<int> inputParametersstartingRowIndex = null, [WorkflowExpression] Func<int> inputParameterscountOfRowsToRead = null, [WorkflowExpression] Func<string> inputParametersfieldDelimiter = null)
        {
            SourceExpression.Validate(inputParameterstableName, nameof(inputParameterstableName), required: true);
            SourceExpression.Validate(inputParametersfieldsToRead, nameof(inputParametersfieldsToRead), required: false);
            SourceExpression.Validate(inputParameterswhereFilters, nameof(inputParameterswhereFilters), required: false);
            SourceExpression.Validate(inputParametersstartingRowIndex, nameof(inputParametersstartingRowIndex), required: false);
            SourceExpression.Validate(inputParameterscountOfRowsToRead, nameof(inputParameterscountOfRowsToRead), required: false);
            SourceExpression.Validate(inputParametersfieldDelimiter, nameof(inputParametersfieldDelimiter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ReadTableVersion2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputParameters = new JObject();
                var inputParameterspropCount = 0;
                inputParameterspropCount++;
                inputParameters["tableName"] = SourceExpressionConverter.ConvertToken(inputParameterstableName);
                if (inputParametersfieldsToRead != null)
                {
                    inputParameters["FieldNames"] = SourceExpressionConverter.ConvertToken(inputParametersfieldsToRead);
                    inputParameterspropCount++;
                }

                if (inputParameterswhereFilters != null)
                {
                    inputParameters["WhereFilters"] = SourceExpressionConverter.ConvertToken(inputParameterswhereFilters);
                    inputParameterspropCount++;
                }

                if (inputParametersstartingRowIndex != null)
                {
                    inputParameters["StartIndex"] = SourceExpressionConverter.ConvertToken(inputParametersstartingRowIndex);
                    inputParameterspropCount++;
                }

                if (inputParameterscountOfRowsToRead != null)
                {
                    inputParameters["RowCount"] = SourceExpressionConverter.ConvertToken(inputParameterscountOfRowsToRead);
                    inputParameterspropCount++;
                }

                if (inputParametersfieldDelimiter != null)
                {
                    inputParameters["Delimiter"] = SourceExpressionConverter.ConvertToken(inputParametersfieldDelimiter);
                    inputParameterspropCount++;
                }

                if (inputParameterspropCount > 0)
                {
                    callPayload.Body = inputParameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2> RollbackBapiTransaction([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> closeSession = null)
        {
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(closeSession, nameof(closeSession), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RollbackBapiTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                callPayload.Queries["closeSession"] = Convert.ToString(true);
                if (closeSession != null)
                    callPayload.Queries["closeSession"] = SourceExpressionConverter.ConvertO(closeSession);
                return callPayload;
            }

            return new ApiConnectionAction<BapiRet2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> Send([WorkflowExpression] Func<string> sapAction, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(sapAction, nameof(sapAction), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sapAction"] = SourceExpressionConverter.ConvertO(sapAction);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse> SendIDoc([WorkflowExpression] Func<string> idocType, [WorkflowExpression] Func<string> releaseVersion = null, [WorkflowExpression] Func<recordTypesVersionInput> recordTypesVersion = null, [WorkflowExpression] Func<bool> confirmTid = null, [WorkflowExpression] Func<string> tid = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> contentType = null)
        {
            SourceExpression.Validate(idocType, nameof(idocType), required: true);
            SourceExpression.Validate(releaseVersion, nameof(releaseVersion), required: false);
            SourceExpression.Validate(recordTypesVersion, nameof(recordTypesVersion), required: false);
            SourceExpression.Validate(confirmTid, nameof(confirmTid), required: false);
            SourceExpression.Validate(tid, nameof(tid), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SendIDoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocType"] = SourceExpressionConverter.ConvertO(idocType);
                callPayload.Queries["releaseVersion"] = Convert.ToString("");
                if (releaseVersion != null)
                    callPayload.Queries["releaseVersion"] = SourceExpressionConverter.ConvertO(releaseVersion);
                callPayload.Queries["recordTypesVersion"] = Convert.ToString("3");
                if (recordTypesVersion != null)
                    callPayload.Queries["recordTypesVersion"] = SourceExpressionConverter.Convert(recordTypesVersion);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (confirmTid != null)
                    callPayload.Queries["confirmTid"] = SourceExpressionConverter.ConvertO(confirmTid);
                if (tid != null)
                    callPayload.Queries["tid"] = SourceExpressionConverter.ConvertO(tid);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SendIdocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse> SendIDocVersion2([WorkflowExpression] Func<object> dynamicParameters = null, [WorkflowExpression] Func<idocFormatInput> idocFormat = null, [WorkflowExpression] Func<bool> confirmTid = null, [WorkflowExpression] Func<string> tid = null)
        {
            SourceExpression.Validate(dynamicParameters, nameof(dynamicParameters), required: false);
            SourceExpression.Validate(idocFormat, nameof(idocFormat), required: false);
            SourceExpression.Validate(confirmTid, nameof(confirmTid), required: false);
            SourceExpression.Validate(tid, nameof(tid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/SendIDoc/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idocFormat"] = Convert.ToString("Xml");
                if (idocFormat != null)
                    callPayload.Queries["idocFormat"] = SourceExpressionConverter.Convert(idocFormat);
                callPayload.Queries["confirmTid"] = Convert.ToString(false);
                if (confirmTid != null)
                    callPayload.Queries["confirmTid"] = SourceExpressionConverter.ConvertO(confirmTid);
                if (tid != null)
                    callPayload.Queries["tid"] = SourceExpressionConverter.ConvertO(tid);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicParameters);
                return callPayload;
            }

            return new ApiConnectionAction<SendIdocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SubscribeResponse> StartLongRunningRfc([WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersrFCName, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersinputRFCParametersInline = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersinputRFCParametersReference = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersrFCGroupFilter = null, [WorkflowExpression] Func<bool> callRfcSubscriptionrfcCallParametersautoCommit = null, [WorkflowExpression] Func<string> callRfcSubscriptionrfcCallParametersqueueName = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null)
        {
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersrFCName, nameof(callRfcSubscriptionrfcCallParametersrFCName), required: true);
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersinputRFCParametersInline, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersInline), required: false);
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersinputRFCParametersReference, nameof(callRfcSubscriptionrfcCallParametersinputRFCParametersReference), required: false);
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersrFCGroupFilter, nameof(callRfcSubscriptionrfcCallParametersrFCGroupFilter), required: false);
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersautoCommit, nameof(callRfcSubscriptionrfcCallParametersautoCommit), required: false);
            SourceExpression.Validate(callRfcSubscriptionrfcCallParametersqueueName, nameof(callRfcSubscriptionrfcCallParametersqueueName), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(tId, nameof(tId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/StartLongRunningRfc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                if (tId != null)
                    callPayload.Queries["tId"] = SourceExpressionConverter.ConvertO(tId);
                var callRfcSubscription = new JObject();
                var callRfcSubscriptionpropCount = 0;
                var rfcCallParametersObject = new JObject();
                var rfcCallParametersObjectpropCount = 0;
                rfcCallParametersObjectpropCount++;
                rfcCallParametersObject["RfcName"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersrFCName);
                if (callRfcSubscriptionrfcCallParametersinputRFCParametersInline != null)
                {
                    rfcCallParametersObject["Payload"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersinputRFCParametersInline);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersinputRFCParametersReference != null)
                {
                    rfcCallParametersObject["PayloadReference"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersinputRFCParametersReference);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersrFCGroupFilter != null)
                {
                    rfcCallParametersObject["RfcGroupFilter"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersrFCGroupFilter);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersautoCommit != null)
                {
                    rfcCallParametersObject["AutoCommit"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersautoCommit);
                    rfcCallParametersObjectpropCount++;
                }

                if (callRfcSubscriptionrfcCallParametersqueueName != null)
                {
                    rfcCallParametersObject["QueueName"] = SourceExpressionConverter.ConvertToken(callRfcSubscriptionrfcCallParametersqueueName);
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
                return callPayload;
            }

            return new ApiConnectionAction<SubscribeResponse>(BuildSourceInput);
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SubscribeResponse> Subscribe([WorkflowExpression] Func<string> gatewayHost, [WorkflowExpression] Func<string> gatewayService, [WorkflowExpression] Func<string> programId, [WorkflowExpression] Func<string[]> subscriptionsapActions = null, [WorkflowExpression] Func<subscriptionidOCFormatInput> subscriptionidOCFormat = null, [WorkflowExpression] Func<bool> subscriptionreceiveIdOCsWithUnreleasedSegments = null, [WorkflowExpression] Func<string> sncPartnerNames = null, [WorkflowExpression] Func<int> degreeOfParallelism = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(gatewayHost, nameof(gatewayHost), required: true);
            SourceExpression.Validate(gatewayService, nameof(gatewayService), required: true);
            SourceExpression.Validate(programId, nameof(programId), required: true);
            SourceExpression.Validate(subscriptionsapActions, nameof(subscriptionsapActions), required: false);
            SourceExpression.Validate(subscriptionidOCFormat, nameof(subscriptionidOCFormat), required: false);
            SourceExpression.Validate(subscriptionreceiveIdOCsWithUnreleasedSegments, nameof(subscriptionreceiveIdOCsWithUnreleasedSegments), required: false);
            SourceExpression.Validate(sncPartnerNames, nameof(sncPartnerNames), required: false);
            SourceExpression.Validate(degreeOfParallelism, nameof(degreeOfParallelism), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhooktrigger/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["gatewayHost"] = SourceExpressionConverter.ConvertO(gatewayHost);
                callPayload.Queries["gatewayService"] = SourceExpressionConverter.ConvertO(gatewayService);
                callPayload.Queries["programId"] = SourceExpressionConverter.ConvertO(programId);
                if (sncPartnerNames != null)
                    callPayload.Queries["sncPartnerNames"] = SourceExpressionConverter.ConvertO(sncPartnerNames);
                callPayload.Queries["degreeOfParallelism"] = Convert.ToString(-1);
                if (degreeOfParallelism != null)
                    callPayload.Queries["degreeOfParallelism"] = SourceExpressionConverter.ConvertO(degreeOfParallelism);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                if (subscriptionsapActions != null)
                {
                    subscription["SapActions"] = SourceExpressionConverter.ConvertToken(subscriptionsapActions);
                    subscriptionpropCount++;
                }

                if (subscriptionidOCFormat != null)
                {
                    subscription["IdocFormat"] = SourceExpressionConverter.Convert(subscriptionidOCFormat);
                    subscriptionpropCount++;
                }

                if (subscriptionreceiveIdOCsWithUnreleasedSegments != null)
                {
                    subscription["ReceiveIdocsWithUnreleasedSegments"] = SourceExpressionConverter.ConvertToken(subscriptionreceiveIdOCsWithUnreleasedSegments);
                    subscriptionpropCount++;
                }

                subscription["NotificationUrl"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    callPayload.Body = subscription;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<SubscribeResponse>(BuildSourceInput, triggerName, recurrence);
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

    public enum subscriptionidOCFormatInput
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