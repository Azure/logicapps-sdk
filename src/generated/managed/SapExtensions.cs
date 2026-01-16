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
        public IBodyWorkflowAction<RfcTransactionDetails> AddRfcToTransaction(Expression<Func<string>> rfcName, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallBapiResponse> CallBapi(Expression<Func<string>> businessObject, Expression<Func<string>> method, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<CallRfcResponse> CallRfc(Expression<Func<string>> rfcName, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CallRfc3(Expression<Func<string>> rfcName, Expression<Func<object>> rfcInputs = null, Expression<Func<string>> rfcGroupFilter = null, Expression<Func<bool>> autoCommit = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<inputFormatInput>> inputFormat = null, Expression<Func<returnFormatInput>> returnFormat = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CloseSession(Expression<Func<string>> sessionId)
        {
            var apiCallPath = "/CloseSession";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2> CommitBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> wait = null, Expression<Func<bool>> closeSession = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CommitRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var apiCallPath = "/CommitRfcTransaction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tId != null)
                callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
            if (queueName != null)
                callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> ConfirmTid(Expression<Func<string>> tid)
        {
            var apiCallPath = "/ConfirmTid";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tid"] = ExpressionConverter.Convert(tid);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> CreateRfcTransaction(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var apiCallPath = "/CreateRfcTransaction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tId != null)
                callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
            if (queueName != null)
                callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
            return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
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
            var apiCallPath = "/GenerateSchemas";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileNamePrefix"] = Convert.ToString("");
            if (fileNamePrefix != null)
                callPayload.Queries["fileNamePrefix"] = ExpressionConverter.Convert(fileNamePrefix);
            callPayload.Body = ExpressionConverter.ConvertO(sapActionUris);
            return new ApiConnectionAction<SapConnectorGenerateSchemasResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocStatusResponse> GetIdocStatus(Expression<Func<int>> idocNumber)
        {
            var apiCallPath = "/GetIdocStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["idocNumber"] = ExpressionConverter.Convert(idocNumber);
            return new ApiConnectionAction<IdocStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<RfcTransactionDetails> GetTransactionDetails(Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null)
        {
            var apiCallPath = "/GetTransactionDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tId != null)
                callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
            if (queueName != null)
                callPayload.Queries["queueName"] = ExpressionConverter.Convert(queueName);
            return new ApiConnectionAction<RfcTransactionDetails>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<IdocNumbersList> GetTransactionIdocs(Expression<Func<directionInput>> direction, Expression<Func<string>> tId)
        {
            var apiCallPath = "/GetTransactionIdocs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["direction"] = ExpressionConverter.Convert(direction);
            callPayload.Queries["tId"] = ExpressionConverter.Convert(tId);
            return new ApiConnectionAction<IdocNumbersList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableResponse> ReadTableVersion2(Expression<Func<string>> inputParameterstableName, Expression<Func<string[]>> inputParametersfieldsToRead = null, Expression<Func<string[]>> inputParameterswhereFilters = null, Expression<Func<int>> inputParametersstartingRowIndex = null, Expression<Func<int>> inputParameterscountOfRowsToRead = null, Expression<Func<string>> inputParametersfieldDelimiter = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRet2> RollbackBapiTransaction(Expression<Func<string>> sessionId, Expression<Func<bool>> closeSession = null)
        {
            var apiCallPath = "/RollbackBapiTransaction";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            callPayload.Queries["closeSession"] = Convert.ToString(true);
            if (closeSession != null)
                callPayload.Queries["closeSession"] = ExpressionConverter.Convert(closeSession);
            return new ApiConnectionAction<BapiRet2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> Send(Expression<Func<string>> sapAction, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
        {
            var apiCallPath = "/Send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sapAction"] = ExpressionConverter.Convert(sapAction);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse> SendIDoc(Expression<Func<string>> idocType, Expression<Func<string>> releaseVersion = null, Expression<Func<recordTypesVersionInput>> recordTypesVersion = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null, Expression<Func<string>> body = null, Expression<Func<string>> contentType = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIdocResponse> SendIDocVersion2(Expression<Func<object>> dynamicParameters = null, Expression<Func<idocFormatInput>> idocFormat = null, Expression<Func<bool>> confirmTid = null, Expression<Func<string>> tid = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sap")]
        public IBodyWorkflowAction<SubscribeResponse> StartLongRunningRfc(Expression<Func<string>> callRfcSubscriptionRfcCallParametersrFCName, Expression<Func<string>> callRfcSubscriptionRfcCallParametersinputRFCParametersInline = null, Expression<Func<string>> callRfcSubscriptionRfcCallParametersinputRFCParametersReference = null, Expression<Func<string>> callRfcSubscriptionRfcCallParametersrFCGroupFilter = null, Expression<Func<bool>> callRfcSubscriptionRfcCallParametersautoCommit = null, Expression<Func<string>> callRfcSubscriptionRfcCallParametersqueueName = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null)
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
            var RfcCallParametersObject = new JObject();
            var RfcCallParametersObjectpropCount = 0;
            RfcCallParametersObjectpropCount++;
            RfcCallParametersObject["RfcName"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersrFCName);
            if (callRfcSubscriptionRfcCallParametersinputRFCParametersInline != null)
            {
                RfcCallParametersObject["Payload"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersinputRFCParametersInline);
                RfcCallParametersObjectpropCount++;
            }

            if (callRfcSubscriptionRfcCallParametersinputRFCParametersReference != null)
            {
                RfcCallParametersObject["PayloadReference"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersinputRFCParametersReference);
                RfcCallParametersObjectpropCount++;
            }

            if (callRfcSubscriptionRfcCallParametersrFCGroupFilter != null)
            {
                RfcCallParametersObject["RfcGroupFilter"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersrFCGroupFilter);
                RfcCallParametersObjectpropCount++;
            }

            if (callRfcSubscriptionRfcCallParametersautoCommit != null)
            {
                RfcCallParametersObject["AutoCommit"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersautoCommit);
                RfcCallParametersObjectpropCount++;
            }

            if (callRfcSubscriptionRfcCallParametersqueueName != null)
            {
                RfcCallParametersObject["QueueName"] = ExpressionConverter.ConvertO(callRfcSubscriptionRfcCallParametersqueueName);
                RfcCallParametersObjectpropCount++;
            }

            if (RfcCallParametersObjectpropCount > 0)
            {
                callRfcSubscription["RfcCallParameters"] = RfcCallParametersObject;
                callRfcSubscriptionpropCount++;
            }

            callRfcSubscription["NotificationUrl"] = "@listcallbackurl()";
            callRfcSubscriptionpropCount++;
            if (callRfcSubscriptionpropCount > 0)
            {
                callPayload.Body = callRfcSubscription;
            }

            return new ApiConnectionAction<SubscribeResponse>(callPayload);
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<SubscribeResponse> Subscribe(Expression<Func<string>> gatewayHost, Expression<Func<string>> gatewayService, Expression<Func<string>> programId, Expression<Func<string[]>> subscriptionSapActions = null, Expression<Func<subscriptioniDOCFormatInput>> subscriptioniDOCFormat = null, Expression<Func<bool>> subscriptionreceiveIDOCsWithUnreleasedSegments = null, Expression<Func<string>> sncPartnerNames = null, Expression<Func<int>> degreeOfParallelism = null)
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
            if (subscriptionSapActions != null)
            {
                subscription["SapActions"] = ExpressionConverter.ConvertO(subscriptionSapActions);
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

            subscription["NotificationUrl"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                callPayload.Body = subscription;
            }

            return new ApiConnectionTrigger<SubscribeResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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