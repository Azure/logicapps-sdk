//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sap
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> CallRfc(Expression<Func<CallRfcInputInputBodyTypeType>> inputBodyType = null, Expression<Func<string>> rfcName = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<bool>> autoCommit = null, Expression<Func<bool>> safeType = null, Expression<Func<CallRfcInputOutputBodyTypeType>> outputBodyType = null)
        {
            var serviceProviderParameters = new JObject();
            if (inputBodyType != null)
            {
                serviceProviderParameters["inputBodyType"] = CSharpExpressionConverter.ConvertToken(inputBodyType);
            }
            else
            {
                serviceProviderParameters["inputBodyType"] = "XML";
            }

            if (rfcName != null)
            {
                serviceProviderParameters["rfcName"] = CSharpExpressionConverter.ConvertToken(rfcName);
            }

            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = CSharpExpressionConverter.ConvertToken(sessionId);
            }

            if (tId != null)
            {
                serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            }

            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            }

            if (autoCommit != null)
            {
                serviceProviderParameters["autoCommit"] = CSharpExpressionConverter.ConvertToken(autoCommit);
            }

            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = CSharpExpressionConverter.ConvertToken(safeType);
            }

            if (outputBodyType != null)
            {
                serviceProviderParameters["outputBodyType"] = CSharpExpressionConverter.ConvertToken(outputBodyType);
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
        public IBodyWorkflowAction<CreateRfcTransactionOutput> CreateRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CreateRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetRfcTransactionOutput> GetRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<AddRfcToTransactionOutput> AddRfcToTransaction(Expression<Func<object>> body, Expression<Func<string>> tId, Expression<Func<string>> queueName = null, Expression<Func<bool>> autoCommit = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["body"] = CSharpExpressionConverter.ConvertToken(body);
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            }

            if (autoCommit != null)
            {
                serviceProviderParameters["autoCommit"] = CSharpExpressionConverter.ConvertToken(autoCommit);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "addRfcToTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<AddRfcToTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CommitRfcTransactionOutput> CommitRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            if (queueName != null)
            {
                serviceProviderParameters["queueName"] = CSharpExpressionConverter.ConvertToken(queueName);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "commitRfcTransaction", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<CommitRfcTransactionOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ConfirmTransactionId(Expression<Func<string>> tId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "confirmTransactionId", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIDocOutput> SendIDoc(Expression<Func<SendIDocInputIdocFormatType>> idocFormat, Expression<Func<bool>> confirmTid, Expression<Func<string>> tId = null, Expression<Func<bool>> allowUnreleasedSegmentV2 = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["idocFormat"] = CSharpExpressionConverter.ConvertToken(idocFormat);
            if (tId != null)
            {
                serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            }

            serviceProviderParameters["confirmTid"] = CSharpExpressionConverter.ConvertToken(confirmTid);
            if (allowUnreleasedSegmentV2 != null)
            {
                serviceProviderParameters["allowUnreleasedSegmentV2"] = CSharpExpressionConverter.ConvertToken(allowUnreleasedSegmentV2);
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
        public IBodyWorkflowAction<BapiCallMethodOutput> BapiCallMethod(Expression<Func<string>> businessObject, Expression<Func<string>> method, Expression<Func<bool>> autoCommit, Expression<Func<object>> body, Expression<Func<string>> sessionId = null, Expression<Func<bool>> safeType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["businessObject"] = CSharpExpressionConverter.ConvertToken(businessObject);
            serviceProviderParameters["method"] = CSharpExpressionConverter.ConvertToken(method);
            serviceProviderParameters["autoCommit"] = CSharpExpressionConverter.ConvertToken(autoCommit);
            if (sessionId != null)
            {
                serviceProviderParameters["sessionId"] = CSharpExpressionConverter.ConvertToken(sessionId);
            }

            serviceProviderParameters["body"] = CSharpExpressionConverter.ConvertToken(body);
            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = CSharpExpressionConverter.ConvertToken(safeType);
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
        public IWorkflowAction CloseSession(Expression<Func<string>> sessionId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = CSharpExpressionConverter.ConvertToken(sessionId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "closeSession", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCommitOutput> BapiCommit(Expression<Func<string>> sessionId, Expression<Func<bool>> wait, Expression<Func<bool>> closeSession)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = CSharpExpressionConverter.ConvertToken(sessionId);
            serviceProviderParameters["wait"] = CSharpExpressionConverter.ConvertToken(wait);
            serviceProviderParameters["closeSession"] = CSharpExpressionConverter.ConvertToken(closeSession);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCommit", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BapiCommitOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRollbackOutput> BapiRollback(Expression<Func<string>> sessionId, Expression<Func<bool>> closeSession)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["sessionId"] = CSharpExpressionConverter.ConvertToken(sessionId);
            serviceProviderParameters["closeSession"] = CSharpExpressionConverter.ConvertToken(closeSession);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiRollback", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<BapiRollbackOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableOutput> ReadTable(Expression<Func<string>> tableName, Expression<Func<string[]>> fieldNames = null, Expression<Func<string[]>> whereFilters = null, Expression<Func<int>> startIndex = null, Expression<Func<int>> numberOfRowsToRead = null, Expression<Func<string>> delimiter = null, Expression<Func<ReadTableInputReturnFormatType>> returnFormat = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["tableName"] = CSharpExpressionConverter.ConvertToken(tableName);
            if (fieldNames != null)
            {
                serviceProviderParameters["fieldNames"] = CSharpExpressionConverter.ConvertToken(fieldNames);
            }

            if (whereFilters != null)
            {
                serviceProviderParameters["whereFilters"] = CSharpExpressionConverter.ConvertToken(whereFilters);
            }

            if (startIndex != null)
            {
                serviceProviderParameters["startIndex"] = CSharpExpressionConverter.ConvertToken(startIndex);
            }

            if (numberOfRowsToRead != null)
            {
                serviceProviderParameters["numberOfRowsToRead"] = CSharpExpressionConverter.ConvertToken(numberOfRowsToRead);
            }

            if (delimiter != null)
            {
                serviceProviderParameters["delimiter"] = CSharpExpressionConverter.ConvertToken(delimiter);
            }

            if (returnFormat != null)
            {
                serviceProviderParameters["returnFormat"] = CSharpExpressionConverter.ConvertToken(returnFormat);
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
        public IBodyWorkflowAction<JToken> GetSchemaV2(Expression<Func<GetSchemaV2InputOperationTypeType>> operationType, Expression<Func<string>> fileNamePrefix = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["operationType"] = CSharpExpressionConverter.ConvertToken(operationType);
            if (fileNamePrefix != null)
            {
                serviceProviderParameters["fileNamePrefix"] = CSharpExpressionConverter.ConvertToken(fileNamePrefix);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaV2", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<JToken>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocListOutput> GetIDocList(Expression<Func<GetIDocListInputDirectionType>> direction, Expression<Func<string>> tId)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["direction"] = CSharpExpressionConverter.ConvertToken(direction);
            serviceProviderParameters["tId"] = CSharpExpressionConverter.ConvertToken(tId);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocList", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetIDocListOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocStatusOutput> GetIDocStatus(Expression<Func<int>> iDocNumber)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["iDocNumber"] = CSharpExpressionConverter.ConvertToken(iDocNumber);
            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocStatus", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<GetIDocStatusOutput>(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction RespondToSapServer(Expression<Func<string>> body, Expression<Func<bool>> safeType = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["body"] = CSharpExpressionConverter.ConvertToken(body);
            if (safeType != null)
            {
                serviceProviderParameters["safeType"] = CSharpExpressionConverter.ConvertToken(safeType);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "respondToSapServer", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction SendExceptionToSapServer(Expression<Func<string>> sendExceptionToSapServerErrorMessage, Expression<Func<string>> sendExceptionToSapServerExceptionName = null, Expression<Func<string>> sendExceptionToSapServerMessageType = null, Expression<Func<string>> sendExceptionToSapServerMessageClass = null, Expression<Func<string>> sendExceptionToSapServerMessageNumber = null, Expression<Func<bool>> sendExceptionToSapServerIsAbapMessage = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["SendExceptionToSapServerErrorMessage"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerErrorMessage);
            if (sendExceptionToSapServerExceptionName != null)
            {
                serviceProviderParameters["SendExceptionToSapServerExceptionName"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerExceptionName);
            }

            if (sendExceptionToSapServerMessageType != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageType"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerMessageType);
            }

            if (sendExceptionToSapServerMessageClass != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageClass"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerMessageClass);
            }

            if (sendExceptionToSapServerMessageNumber != null)
            {
                serviceProviderParameters["SendExceptionToSapServerMessageNumber"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerMessageNumber);
            }

            if (sendExceptionToSapServerIsAbapMessage != null)
            {
                serviceProviderParameters["SendExceptionToSapServerIsAbapMessage"] = CSharpExpressionConverter.ConvertToken(sendExceptionToSapServerIsAbapMessage);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendExceptionToSapServer", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction(serviceProviderInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> RunDiagnostics(Expression<Func<RunDiagnosticsInputOperationTypeType>> operationType)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["operationType"] = CSharpExpressionConverter.ConvertToken(operationType);
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
        public IBodyWorkflowTrigger<SapTriggerOutput> SapTrigger(Expression<Func<SapTriggerInputIdocFormatType>> idocFormat, Expression<Func<int>> degreeOfParallelism, Expression<Func<string>> gatewayHost, Expression<Func<string>> gatewayService, Expression<Func<string>> programId, Expression<Func<string>> sncPartnerNames = null, Expression<Func<bool>> receiveIDocsWithUnreleasedSegmentsV2 = null, Expression<Func<string>> defaultIDocRelease = null, Expression<Func<string>> receivedIDocTypeReleaseMapping = null, Expression<Func<bool>> gatewayWithoutWorkProcess = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["idocFormat"] = CSharpExpressionConverter.ConvertToken(idocFormat);
            if (sncPartnerNames != null)
            {
                serviceProviderParameters["SncPartnerNames"] = CSharpExpressionConverter.ConvertToken(sncPartnerNames);
            }

            serviceProviderParameters["DegreeOfParallelism"] = CSharpExpressionConverter.ConvertToken(degreeOfParallelism);
            if (receiveIDocsWithUnreleasedSegmentsV2 != null)
            {
                serviceProviderParameters["ReceiveIDocsWithUnreleasedSegmentsV2"] = CSharpExpressionConverter.ConvertToken(receiveIDocsWithUnreleasedSegmentsV2);
            }

            serviceProviderParameters["GatewayHost"] = CSharpExpressionConverter.ConvertToken(gatewayHost);
            serviceProviderParameters["GatewayService"] = CSharpExpressionConverter.ConvertToken(gatewayService);
            serviceProviderParameters["ProgramId"] = CSharpExpressionConverter.ConvertToken(programId);
            if (defaultIDocRelease != null)
            {
                serviceProviderParameters["DefaultIDocRelease"] = CSharpExpressionConverter.ConvertToken(defaultIDocRelease);
            }

            if (receivedIDocTypeReleaseMapping != null)
            {
                serviceProviderParameters["ReceivedIDocTypeReleaseMapping"] = CSharpExpressionConverter.ConvertToken(receivedIDocTypeReleaseMapping);
            }

            if (gatewayWithoutWorkProcess != null)
            {
                serviceProviderParameters["GatewayWithoutWorkProcess"] = CSharpExpressionConverter.ConvertToken(gatewayWithoutWorkProcess);
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