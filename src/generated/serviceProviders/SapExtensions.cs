//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sap
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CallRfc([WorkflowExpression] Func<CallRfcInputInputBodyTypeType> inputBodyType = null, [WorkflowExpression] Func<string> rfcName = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<bool> safeType = null, [WorkflowExpression] Func<CallRfcInputOutputBodyTypeType> outputBodyType = null)
        {
            var serviceProviderParameters = new JObject();
            if (inputBodyType != null)
            {
                serviceProviderParameters["inputBodyType"] = ExpressionConverter.ConvertO(inputBodyType);
            }
            else
            {
                serviceProviderParameters["inputBodyType"] = "XML";
            }

            if (rfcName != null)
            {
                serviceProviderParameters["rfcName"] = ExpressionConverter.ConvertO(rfcName);
            }

            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            if (tId != null)
            {
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            }

            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            }

            if (autoCommit != null)
            {
                serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(autoCommit);
            }

            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(safeType);
            }

            if (outputBodyType != null)
            {
                serviceProviderParameters["outputBodyType"] = ExpressionConverter.ConvertO(outputBodyType);
            }
            else
            {
                serviceProviderParameters["outputBodyType"] = "XML";
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "callRfc", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateRfcTransactionOutput> CreateRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetRfcTransactionOutput> GetRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<AddRfcToTransactionOutput> AddRfcToTransaction([WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            }

            if (autoCommit != null)
            {
                serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(autoCommit);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "addRfcToTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<AddRfcToTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CommitRfcTransactionOutput> CommitRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "commitRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CommitRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ConfirmTransactionId([WorkflowExpression] Func<string> tId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "confirmTransactionId", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIDocOutput> SendIDoc([WorkflowExpression] Func<SendIDocInputIdocFormatType> idocFormat, [WorkflowExpression] Func<bool> confirmTid, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<bool> allowUnreleasedSegmentV2 = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["idocFormat"] = ExpressionConverter.ConvertO(idocFormat);
            if (tId != null)
            {
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            }

            serviceProviderParameters["confirmTid"] = ExpressionConverter.ConvertO(confirmTid);
            if (allowUnreleasedSegmentV2 != null)
            {
                serviceProviderParameters["allowUnreleasedSegmentV2"] = ExpressionConverter.ConvertO(allowUnreleasedSegmentV2);
            }
            else
            {
                serviceProviderParameters["allowUnreleasedSegmentV2"] = false;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendIDoc", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<SendIDocOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCallMethodOutput> BapiCallMethod([WorkflowExpression] Func<string> businessObject, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<bool> autoCommit, [WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> safeType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["businessObject"] = ExpressionConverter.ConvertO(businessObject);
            serviceProviderParameters["method"] = ExpressionConverter.ConvertO(method);
            serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(autoCommit);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(safeType);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCallMethod", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BapiCallMethodOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionOutput> CreateSession()
        {
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createSession", connectionName: connectionId)
            };
            return new ServiceProviderAction<CreateSessionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction CloseSession([WorkflowExpression] Func<string> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "closeSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCommitOutput> BapiCommit([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> wait, [WorkflowExpression] Func<bool> closeSession)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            serviceProviderParameters["wait"] = ExpressionConverter.ConvertO(wait);
            serviceProviderParameters["closeSession"] = ExpressionConverter.ConvertO(closeSession);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCommit", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BapiCommitOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRollbackOutput> BapiRollback([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> closeSession)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            serviceProviderParameters["closeSession"] = ExpressionConverter.ConvertO(closeSession);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiRollback", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BapiRollbackOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableOutput> ReadTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string[]> fieldNames = null, [WorkflowExpression] Func<string[]> whereFilters = null, [WorkflowExpression] Func<int> startIndex = null, [WorkflowExpression] Func<int> numberOfRowsToRead = null, [WorkflowExpression] Func<string> delimiter = null, [WorkflowExpression] Func<ReadTableInputReturnFormatType> returnFormat = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(tableName);
            if (fieldNames != null)
            {
                serviceProviderParameters["fieldNames"] = ExpressionConverter.ConvertO(fieldNames);
            }

            if (whereFilters != null)
            {
                serviceProviderParameters["whereFilters"] = ExpressionConverter.ConvertO(whereFilters);
            }

            if (startIndex != null)
            {
                serviceProviderParameters["startIndex"] = ExpressionConverter.ConvertO(startIndex);
            }

            if (numberOfRowsToRead != null)
            {
                serviceProviderParameters["numberOfRowsToRead"] = ExpressionConverter.ConvertO(numberOfRowsToRead);
            }

            if (delimiter != null)
            {
                serviceProviderParameters["delimiter"] = ExpressionConverter.ConvertO(delimiter);
            }

            if (returnFormat != null)
            {
                serviceProviderParameters["returnFormat"] = ExpressionConverter.ConvertO(returnFormat);
            }
            else
            {
                serviceProviderParameters["returnFormat"] = "Json";
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "readTable", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<ReadTableOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> GetSchemaV2([WorkflowExpression] Func<GetSchemaV2InputOperationTypeType> operationType, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["operationType"] = ExpressionConverter.ConvertO(operationType);
            if (fileNamePrefix != null)
            {
                serviceProviderParameters["fileNamePrefix"] = ExpressionConverter.ConvertO(fileNamePrefix);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocListOutput> GetIDocList([WorkflowExpression] Func<GetIDocListInputDirectionType> direction, [WorkflowExpression] Func<string> tId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["direction"] = ExpressionConverter.ConvertO(direction);
            serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocList", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetIDocListOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocStatusOutput> GetIDocStatus([WorkflowExpression] Func<int> iDocNumber)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["iDocNumber"] = ExpressionConverter.ConvertO(iDocNumber);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocStatus", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetIDocStatusOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction RespondToSapServer([WorkflowExpression] Func<string> body, [WorkflowExpression] Func<bool> safeType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(safeType);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "respondToSapServer", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction SendExceptionToSapServer([WorkflowExpression] Func<string> sendExceptionToSapServerErrorMessage, [WorkflowExpression] Func<string> sendExceptionToSapServerExceptionName = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageType = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageClass = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageNumber = null, [WorkflowExpression] Func<bool> sendExceptionToSapServerIsAbapMessage = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["SendExceptionToSapServerErrorMessage"] = ExpressionConverter.ConvertO(sendExceptionToSapServerErrorMessage);
            if (sendExceptionToSapServerExceptionName != null)
            {
                serviceProviderParameters["SendExceptionToSapServerExceptionName"] = ExpressionConverter.ConvertO(sendExceptionToSapServerExceptionName);
            }

            if (sendExceptionToSapServerMessageType != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageType"] = ExpressionConverter.ConvertO(sendExceptionToSapServerMessageType);
            }

            if (sendExceptionToSapServerMessageClass != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageClass"] = ExpressionConverter.ConvertO(sendExceptionToSapServerMessageClass);
            }

            if (sendExceptionToSapServerMessageNumber != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageNumber"] = ExpressionConverter.ConvertO(sendExceptionToSapServerMessageNumber);
            }

            if (sendExceptionToSapServerIsAbapMessage != null)
            {
                serviceProviderParameters["SendExceptionToSapServerIsAbapMessage"] = ExpressionConverter.ConvertO(sendExceptionToSapServerIsAbapMessage);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendExceptionToSapServer", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> RunDiagnostics([WorkflowExpression] Func<RunDiagnosticsInputOperationTypeType> operationType)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["operationType"] = ExpressionConverter.ConvertO(operationType);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnostics", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SapTriggerOutput> SapTrigger([WorkflowExpression] Func<SapTriggerInputIdocFormatType> idocFormat, [WorkflowExpression] Func<int> degreeOfParallelism, [WorkflowExpression] Func<string> gatewayHost, [WorkflowExpression] Func<string> gatewayService, [WorkflowExpression] Func<string> programId, [WorkflowExpression] Func<string> sncPartnerNames = null, [WorkflowExpression] Func<bool> receiveIDocsWithUnreleasedSegmentsV2 = null, [WorkflowExpression] Func<string> defaultIDocRelease = null, [WorkflowExpression] Func<string> receivedIDocTypeReleaseMapping = null, [WorkflowExpression] Func<bool> gatewayWithoutWorkProcess = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["idocFormat"] = ExpressionConverter.ConvertO(idocFormat);
            if (sncPartnerNames != null)
            {
                serviceProviderParameters["SncPartnerNames"] = ExpressionConverter.ConvertO(sncPartnerNames);
            }

            serviceProviderParameters["DegreeOfParallelism"] = ExpressionConverter.ConvertO(degreeOfParallelism);
            if (receiveIDocsWithUnreleasedSegmentsV2 != null)
            {
                serviceProviderParameters["ReceiveIDocsWithUnreleasedSegmentsV2"] = ExpressionConverter.ConvertO(receiveIDocsWithUnreleasedSegmentsV2);
            }

            serviceProviderParameters["GatewayHost"] = ExpressionConverter.ConvertO(gatewayHost);
            serviceProviderParameters["GatewayService"] = ExpressionConverter.ConvertO(gatewayService);
            serviceProviderParameters["ProgramId"] = ExpressionConverter.ConvertO(programId);
            if (defaultIDocRelease != null)
            {
                serviceProviderParameters["DefaultIDocRelease"] = ExpressionConverter.ConvertO(defaultIDocRelease);
            }

            if (receivedIDocTypeReleaseMapping != null)
            {
                serviceProviderParameters["ReceivedIDocTypeReleaseMapping"] = ExpressionConverter.ConvertO(receivedIDocTypeReleaseMapping);
            }

            if (gatewayWithoutWorkProcess != null)
            {
                serviceProviderParameters["GatewayWithoutWorkProcess"] = ExpressionConverter.ConvertO(gatewayWithoutWorkProcess);
            }
            else
            {
                serviceProviderParameters["GatewayWithoutWorkProcess"] = true;
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "SapTrigger", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderTrigger<SapTriggerOutput>(serviceProviderInput);
        }
    }

    public class SapTriggerOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("rfcServerContext")]
        public SapTriggerOutputRfcServerContextType RfcServerContext { get; set; }
    }

    public class SapTriggerOutputRfcServerContextType
    {
        public string FunctionName { get; set; }
        public SapTriggerOutputRfcServerContextTypeSystemAttributesType SystemAttributes { get; set; }
        public string SessionId { get; set; }
        public SapTriggerOutputRfcServerContextTypeTransactionIdType TransactionId { get; set; }
        public SapTriggerOutputRfcServerContextTypeUnitIdType UnitId { get; set; }
        public SapTriggerOutputRfcServerContextTypeUnitAttributesType UnitAttributes { get; set; }
        public string[] QueueNames { get; set; }
        public bool InTransaction { get; set; }
        public bool Stateful { get; set; }
    }

    public class SapTriggerOutputRfcServerContextTypeSystemAttributesType
    {
        public string SystemId { get; set; }
        public string Client { get; set; }
        public string User { get; set; }
        public string Language { get; set; }
        public string IsoLanguage { get; set; }
        public string PartnerHost { get; set; }
        public string HostName { get; set; }
        public string Destination { get; set; }
        public string SystemNumber { get; set; }
        public int PartnerReleaseNumber { get; set; }
        public string PartnerRelease { get; set; }
        public string KernelRelease { get; set; }
        public string Release { get; set; }
        public int CodePage { get; set; }
        public int PartnerCodePage { get; set; }
        public string PartnerType { get; set; }
        public string RfcRole { get; set; }
    }

    public class SapTriggerOutputRfcServerContextTypeTransactionIdType
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Tid { get; set; }
    }

    public class SapTriggerOutputRfcServerContextTypeUnitIdType
    {
        public SapTriggerOutputRfcServerContextTypeUnitIdTypeUnitTypeType UnitType { get; set; }
        public string Uuid { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SapTriggerOutputRfcServerContextTypeUnitIdTypeUnitTypeType
    {
        Queued,
        Transactional
    }

    public class SapTriggerOutputRfcServerContextTypeUnitAttributesType
    {
        public bool KernelTrace { get; set; }
        public bool SatTrace { get; set; }
        public bool UnitHistory { get; set; }
        public bool Hold { get; set; }
        public bool NoCommitCheck { get; set; }
        public string User { get; set; }
        public string Client { get; set; }
        public string TCode { get; set; }
        public string Program { get; set; }
        public string Hostname { get; set; }
        public string SendingDateTime { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SapTriggerInputIdocFormatType
    {
        MicrosoftLobNamespaceXml,
        SapPlainXml,
        FlatFile
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallRfcInputInputBodyTypeType
    {
        XML,
        JSON
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallRfcInputOutputBodyTypeType
    {
        XML,
        JSON
    }

    public class CreateRfcTransactionOutput
    {
        [JsonProperty("rfcNames")]
        public string[] RfcNames { get; set; }

        [JsonProperty("tId")]
        public string TId { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }
    }

    public class GetRfcTransactionOutput
    {
        [JsonProperty("rfcNames")]
        public string[] RfcNames { get; set; }

        [JsonProperty("tId")]
        public string TId { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }
    }

    public class AddRfcToTransactionOutput
    {
        [JsonProperty("rfcNames")]
        public string[] RfcNames { get; set; }

        [JsonProperty("tId")]
        public string TId { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }
    }

    public class CommitRfcTransactionOutput
    {
        [JsonProperty("rfcNames")]
        public string[] RfcNames { get; set; }

        [JsonProperty("tId")]
        public string TId { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }
    }

    public class SendIDocOutput
    {
        [JsonProperty("rfcNames")]
        public string[] RfcNames { get; set; }

        [JsonProperty("tId")]
        public string TId { get; set; }

        [JsonProperty("guid")]
        public string Id { get; set; }

        [JsonProperty("queueName")]
        public string QueueName { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SendIDocInputIdocFormatType
    {
        MicrosoftLobNamespaceXml,
        SapPlainXml,
        FlatFile
    }

    public class BapiCallMethodOutput
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("autoCommitResponse")]
        public BapiCallMethodOutputAutoCommitResponseType AutoCommitResponse { get; set; }
    }

    public class BapiCallMethodOutputAutoCommitResponseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("logNumber")]
        public string LogNumber { get; set; }

        [JsonProperty("logMessageNumber")]
        public string LogMessageNumber { get; set; }

        [JsonProperty("messageVariable1")]
        public string MessageVariable1 { get; set; }

        [JsonProperty("messageVariable2")]
        public string MessageVariable2 { get; set; }

        [JsonProperty("messageVariable3")]
        public string MessageVariable3 { get; set; }

        [JsonProperty("messageVariable4")]
        public string MessageVariable4 { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("row")]
        public int Row { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }
    }

    public class CreateSessionOutput
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class BapiCommitOutput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("logNumber")]
        public string LogNumber { get; set; }

        [JsonProperty("logMessageNumber")]
        public string LogMessageNumber { get; set; }

        [JsonProperty("messageVariable1")]
        public string MessageVariable1 { get; set; }

        [JsonProperty("messageVariable2")]
        public string MessageVariable2 { get; set; }

        [JsonProperty("messageVariable3")]
        public string MessageVariable3 { get; set; }

        [JsonProperty("messageVariable4")]
        public string MessageVariable4 { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("row")]
        public int Row { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }
    }

    public class BapiRollbackOutput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("logNumber")]
        public string LogNumber { get; set; }

        [JsonProperty("logMessageNumber")]
        public string LogMessageNumber { get; set; }

        [JsonProperty("messageVariable1")]
        public string MessageVariable1 { get; set; }

        [JsonProperty("messageVariable2")]
        public string MessageVariable2 { get; set; }

        [JsonProperty("messageVariable3")]
        public string MessageVariable3 { get; set; }

        [JsonProperty("messageVariable4")]
        public string MessageVariable4 { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("row")]
        public int Row { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }
    }

    public class ReadTableOutput
    {
        [JsonProperty("fieldsMetadata")]
        public ReadTableOutputFieldsMetadataTypeItem[] FieldsMetadata { get; set; }

        [JsonProperty("tableRows")]
        public JToken TableRows { get; set; }
    }

    public class ReadTableOutputFieldsMetadataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("abapDataType")]
        public string AbapDataType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReadTableInputReturnFormatType
    {
        Xml,
        Json,
        ExpandedJson
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetSchemaV2InputOperationTypeType
    {
        BAPI,
        RFC,
        IDoc,
        [EnumMember(Value = "tRFC")]
        TRFC
    }

    public class GetIDocListOutput
    {
        [JsonProperty("iDocNumbers")]
        public int[] IDocNumbers { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetIDocListInputDirectionType
    {
        Send,
        Receive
    }

    public class GetIDocStatusOutput
    {
        [JsonProperty("iDocStatus")]
        public int IDocStatus { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunDiagnosticsInputOperationTypeType
    {
        [EnumMember(Value = "Fetch RFC Metadata")]
        FetchRFCMetadata,
        [EnumMember(Value = "Fetch IDoc Data Record Metadata")]
        FetchIDocDataRecordMetadata,
        [EnumMember(Value = "Check connection")]
        CheckConnection,
        [EnumMember(Value = "Get system information")]
        GetSystemInformation,
        [EnumMember(Value = "Call RFC PING")]
        CallRFCPING,
        [EnumMember(Value = "Check RFC destination")]
        CheckRFCDestination,
        [EnumMember(Value = "Get destination type")]
        GetDestinationType
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sap;

    public partial class WorkflowServiceProviderActions
    {
        public SapActions Sap(string connectionId) => new SapActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SapTriggers Sap(string connectionId) => new SapTriggers(connectionId);
    }
}