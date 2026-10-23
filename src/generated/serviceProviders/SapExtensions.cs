//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Sap
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, CallRfcActionConfiguration> CallRfc(Expression<Func<CallRfcInputInputBodyTypeType>> inputBodyType = null, Expression<Func<string>> rfcName = null, Expression<Func<string>> sessionId = null, Expression<Func<string>> tId = null, Expression<Func<string>> queueName = null, Expression<Func<bool>> autoCommit = null, Expression<Func<bool>> safeType = null, Expression<Func<CallRfcInputOutputBodyTypeType>> outputBodyType = null)
        {
            var __workflow_inputBodyType = WorkflowExpression.Compile(inputBodyType, nameof(inputBodyType), required: false);
            var __workflow_rfcName = WorkflowExpression.Compile(rfcName, nameof(rfcName), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            var __workflow_safeType = WorkflowExpression.Compile(safeType, nameof(safeType), required: false);
            var __workflow_outputBodyType = WorkflowExpression.Compile(outputBodyType, nameof(outputBodyType), required: false);
            return new DeferredBodyAction<JToken, CallRfcActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                if (__workflow_inputBodyType != null)
                {
                    serviceProviderParameters["inputBodyType"] = ExpressionConverter.ConvertO(__workflow_inputBodyType);
                }
                else
                {
                    serviceProviderParameters["inputBodyType"] = "XML";
                }

                if (__workflow_rfcName != null)
                {
                    serviceProviderParameters["rfcName"] = ExpressionConverter.ConvertO(__workflow_rfcName);
                }

                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                if (__workflow_tId != null)
                {
                    serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                }

                if (__workflow_queueName != null)
                {
                    serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                }

                if (__workflow_autoCommit != null)
                {
                    serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(__workflow_autoCommit);
                }

                if (__workflow_safeType != null)
                {
                    serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(__workflow_safeType);
                }

                if (__workflow_outputBodyType != null)
                {
                    serviceProviderParameters["outputBodyType"] = ExpressionConverter.ConvertO(__workflow_outputBodyType);
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
                return new ServiceProviderBodyAction<JToken, CallRfcActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateRfcTransactionOutput, CreateRfcTransactionActionConfiguration> CreateRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<CreateRfcTransactionOutput, CreateRfcTransactionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                if (__workflow_queueName != null)
                {
                    serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<CreateRfcTransactionOutput, CreateRfcTransactionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetRfcTransactionOutput, GetRfcTransactionActionConfiguration> GetRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<GetRfcTransactionOutput, GetRfcTransactionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                if (__workflow_queueName != null)
                {
                    serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetRfcTransactionOutput, GetRfcTransactionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<AddRfcToTransactionOutput, AddRfcToTransactionActionConfiguration> AddRfcToTransaction(Expression<Func<object>> body, Expression<Func<string>> tId, Expression<Func<string>> queueName = null, Expression<Func<bool>> autoCommit = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: false);
            return new DeferredBodyAction<AddRfcToTransactionOutput, AddRfcToTransactionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                if (__workflow_queueName != null)
                {
                    serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                }

                if (__workflow_autoCommit != null)
                {
                    serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(__workflow_autoCommit);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "addRfcToTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<AddRfcToTransactionOutput, AddRfcToTransactionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CommitRfcTransactionOutput, CommitRfcTransactionActionConfiguration> CommitRfcTransaction(Expression<Func<string>> tId, Expression<Func<string>> queueName = null)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            var __workflow_queueName = WorkflowExpression.Compile(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<CommitRfcTransactionOutput, CommitRfcTransactionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                if (__workflow_queueName != null)
                {
                    serviceProviderParameters["queueName"] = ExpressionConverter.ConvertO(__workflow_queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "commitRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<CommitRfcTransactionOutput, CommitRfcTransactionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction<ConfirmTransactionIdActionConfiguration> ConfirmTransactionId(Expression<Func<string>> tId)
        {
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            return new DeferredWorkflowAction<ConfirmTransactionIdActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "confirmTransactionId", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ConfirmTransactionIdActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIDocOutput, SendIDocActionConfiguration> SendIDoc(Expression<Func<SendIDocInputIdocFormatType>> idocFormat, Expression<Func<bool>> confirmTid, Expression<Func<string>> tId = null, Expression<Func<bool>> allowUnreleasedSegmentV2 = null)
        {
            var __workflow_idocFormat = WorkflowExpression.Compile(idocFormat, nameof(idocFormat), required: true);
            var __workflow_confirmTid = WorkflowExpression.Compile(confirmTid, nameof(confirmTid), required: true);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: false);
            var __workflow_allowUnreleasedSegmentV2 = WorkflowExpression.Compile(allowUnreleasedSegmentV2, nameof(allowUnreleasedSegmentV2), required: false);
            return new DeferredBodyAction<SendIDocOutput, SendIDocActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = ExpressionConverter.ConvertO(__workflow_idocFormat);
                if (__workflow_tId != null)
                {
                    serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                }

                serviceProviderParameters["confirmTid"] = ExpressionConverter.ConvertO(__workflow_confirmTid);
                if (__workflow_allowUnreleasedSegmentV2 != null)
                {
                    serviceProviderParameters["allowUnreleasedSegmentV2"] = ExpressionConverter.ConvertO(__workflow_allowUnreleasedSegmentV2);
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
                return new ServiceProviderBodyAction<SendIDocOutput, SendIDocActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCallMethodOutput, BapiCallMethodActionConfiguration> BapiCallMethod(Expression<Func<string>> businessObject, Expression<Func<string>> method, Expression<Func<bool>> autoCommit, Expression<Func<object>> body, Expression<Func<string>> sessionId = null, Expression<Func<bool>> safeType = null)
        {
            var __workflow_businessObject = WorkflowExpression.Compile(businessObject, nameof(businessObject), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_autoCommit = WorkflowExpression.Compile(autoCommit, nameof(autoCommit), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_safeType = WorkflowExpression.Compile(safeType, nameof(safeType), required: false);
            return new DeferredBodyAction<BapiCallMethodOutput, BapiCallMethodActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["businessObject"] = ExpressionConverter.ConvertO(__workflow_businessObject);
                serviceProviderParameters["method"] = ExpressionConverter.ConvertO(__workflow_method);
                serviceProviderParameters["autoCommit"] = ExpressionConverter.ConvertO(__workflow_autoCommit);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                if (__workflow_safeType != null)
                {
                    serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(__workflow_safeType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCallMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<BapiCallMethodOutput, BapiCallMethodActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionOutput, CreateSessionActionConfiguration> CreateSession()
        {
            return new DeferredBodyAction<CreateSessionOutput, CreateSessionActionConfiguration>(() =>
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createSession", connectionName: connectionId)
                };
                return new ServiceProviderBodyAction<CreateSessionOutput, CreateSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction<CloseSessionActionConfiguration> CloseSession(Expression<Func<string>> sessionId)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction<CloseSessionActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "closeSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<CloseSessionActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCommitOutput, BapiCommitActionConfiguration> BapiCommit(Expression<Func<string>> sessionId, Expression<Func<bool>> wait, Expression<Func<bool>> closeSession)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: true);
            var __workflow_closeSession = WorkflowExpression.Compile(closeSession, nameof(closeSession), required: true);
            return new DeferredBodyAction<BapiCommitOutput, BapiCommitActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                serviceProviderParameters["wait"] = ExpressionConverter.ConvertO(__workflow_wait);
                serviceProviderParameters["closeSession"] = ExpressionConverter.ConvertO(__workflow_closeSession);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCommit", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<BapiCommitOutput, BapiCommitActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRollbackOutput, BapiRollbackActionConfiguration> BapiRollback(Expression<Func<string>> sessionId, Expression<Func<bool>> closeSession)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_closeSession = WorkflowExpression.Compile(closeSession, nameof(closeSession), required: true);
            return new DeferredBodyAction<BapiRollbackOutput, BapiRollbackActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                serviceProviderParameters["closeSession"] = ExpressionConverter.ConvertO(__workflow_closeSession);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiRollback", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<BapiRollbackOutput, BapiRollbackActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableOutput, ReadTableActionConfiguration> ReadTable(Expression<Func<string>> tableName, Expression<Func<string[]>> fieldNames = null, Expression<Func<string[]>> whereFilters = null, Expression<Func<int>> startIndex = null, Expression<Func<int>> numberOfRowsToRead = null, Expression<Func<string>> delimiter = null, Expression<Func<ReadTableInputReturnFormatType>> returnFormat = null)
        {
            var __workflow_tableName = WorkflowExpression.Compile(tableName, nameof(tableName), required: true);
            var __workflow_fieldNames = WorkflowExpression.Compile(fieldNames, nameof(fieldNames), required: false);
            var __workflow_whereFilters = WorkflowExpression.Compile(whereFilters, nameof(whereFilters), required: false);
            var __workflow_startIndex = WorkflowExpression.Compile(startIndex, nameof(startIndex), required: false);
            var __workflow_numberOfRowsToRead = WorkflowExpression.Compile(numberOfRowsToRead, nameof(numberOfRowsToRead), required: false);
            var __workflow_delimiter = WorkflowExpression.Compile(delimiter, nameof(delimiter), required: false);
            var __workflow_returnFormat = WorkflowExpression.Compile(returnFormat, nameof(returnFormat), required: false);
            return new DeferredBodyAction<ReadTableOutput, ReadTableActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = ExpressionConverter.ConvertO(__workflow_tableName);
                if (__workflow_fieldNames != null)
                {
                    serviceProviderParameters["fieldNames"] = ExpressionConverter.ConvertO(__workflow_fieldNames);
                }

                if (__workflow_whereFilters != null)
                {
                    serviceProviderParameters["whereFilters"] = ExpressionConverter.ConvertO(__workflow_whereFilters);
                }

                if (__workflow_startIndex != null)
                {
                    serviceProviderParameters["startIndex"] = ExpressionConverter.ConvertO(__workflow_startIndex);
                }

                if (__workflow_numberOfRowsToRead != null)
                {
                    serviceProviderParameters["numberOfRowsToRead"] = ExpressionConverter.ConvertO(__workflow_numberOfRowsToRead);
                }

                if (__workflow_delimiter != null)
                {
                    serviceProviderParameters["delimiter"] = ExpressionConverter.ConvertO(__workflow_delimiter);
                }

                if (__workflow_returnFormat != null)
                {
                    serviceProviderParameters["returnFormat"] = ExpressionConverter.ConvertO(__workflow_returnFormat);
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
                return new ServiceProviderBodyAction<ReadTableOutput, ReadTableActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, GetSchemaV2ActionConfiguration> GetSchemaV2(Expression<Func<GetSchemaV2InputOperationTypeType>> operationType, Expression<Func<string>> fileNamePrefix = null)
        {
            var __workflow_operationType = WorkflowExpression.Compile(operationType, nameof(operationType), required: true);
            var __workflow_fileNamePrefix = WorkflowExpression.Compile(fileNamePrefix, nameof(fileNamePrefix), required: false);
            return new DeferredBodyAction<JToken, GetSchemaV2ActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = ExpressionConverter.ConvertO(__workflow_operationType);
                if (__workflow_fileNamePrefix != null)
                {
                    serviceProviderParameters["fileNamePrefix"] = ExpressionConverter.ConvertO(__workflow_fileNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken, GetSchemaV2ActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocListOutput, GetIDocListActionConfiguration> GetIDocList(Expression<Func<GetIDocListInputDirectionType>> direction, Expression<Func<string>> tId)
        {
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: true);
            var __workflow_tId = WorkflowExpression.Compile(tId, nameof(tId), required: true);
            return new DeferredBodyAction<GetIDocListOutput, GetIDocListActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["direction"] = ExpressionConverter.ConvertO(__workflow_direction);
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(__workflow_tId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocList", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetIDocListOutput, GetIDocListActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocStatusOutput, GetIDocStatusActionConfiguration> GetIDocStatus(Expression<Func<int>> iDocNumber)
        {
            var __workflow_iDocNumber = WorkflowExpression.Compile(iDocNumber, nameof(iDocNumber), required: true);
            return new DeferredBodyAction<GetIDocStatusOutput, GetIDocStatusActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["iDocNumber"] = ExpressionConverter.ConvertO(__workflow_iDocNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocStatus", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<GetIDocStatusOutput, GetIDocStatusActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction<RespondToSapServerActionConfiguration> RespondToSapServer(Expression<Func<string>> body, Expression<Func<bool>> safeType = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_safeType = WorkflowExpression.Compile(safeType, nameof(safeType), required: false);
            return new DeferredWorkflowAction<RespondToSapServerActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                if (__workflow_safeType != null)
                {
                    serviceProviderParameters["safeType"] = ExpressionConverter.ConvertO(__workflow_safeType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "respondToSapServer", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<RespondToSapServerActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction<SendExceptionToSapServerActionConfiguration> SendExceptionToSapServer(Expression<Func<string>> sendExceptionToSapServerErrorMessage, Expression<Func<string>> sendExceptionToSapServerExceptionName = null, Expression<Func<string>> sendExceptionToSapServerMessageType = null, Expression<Func<string>> sendExceptionToSapServerMessageClass = null, Expression<Func<string>> sendExceptionToSapServerMessageNumber = null, Expression<Func<bool>> sendExceptionToSapServerIsAbapMessage = null)
        {
            var __workflow_sendExceptionToSapServerErrorMessage = WorkflowExpression.Compile(sendExceptionToSapServerErrorMessage, nameof(sendExceptionToSapServerErrorMessage), required: true);
            var __workflow_sendExceptionToSapServerExceptionName = WorkflowExpression.Compile(sendExceptionToSapServerExceptionName, nameof(sendExceptionToSapServerExceptionName), required: false);
            var __workflow_sendExceptionToSapServerMessageType = WorkflowExpression.Compile(sendExceptionToSapServerMessageType, nameof(sendExceptionToSapServerMessageType), required: false);
            var __workflow_sendExceptionToSapServerMessageClass = WorkflowExpression.Compile(sendExceptionToSapServerMessageClass, nameof(sendExceptionToSapServerMessageClass), required: false);
            var __workflow_sendExceptionToSapServerMessageNumber = WorkflowExpression.Compile(sendExceptionToSapServerMessageNumber, nameof(sendExceptionToSapServerMessageNumber), required: false);
            var __workflow_sendExceptionToSapServerIsAbapMessage = WorkflowExpression.Compile(sendExceptionToSapServerIsAbapMessage, nameof(sendExceptionToSapServerIsAbapMessage), required: false);
            return new DeferredWorkflowAction<SendExceptionToSapServerActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["SendExceptionToSapServerErrorMessage"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerErrorMessage);
                if (__workflow_sendExceptionToSapServerExceptionName != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerExceptionName"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerExceptionName);
                }

                if (__workflow_sendExceptionToSapServerMessageType != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageType"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerMessageType);
                }

                if (__workflow_sendExceptionToSapServerMessageClass != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageClass"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerMessageClass);
                }

                if (__workflow_sendExceptionToSapServerMessageNumber != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageNumber"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerMessageNumber);
                }

                if (__workflow_sendExceptionToSapServerIsAbapMessage != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerIsAbapMessage"] = ExpressionConverter.ConvertO(__workflow_sendExceptionToSapServerIsAbapMessage);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendExceptionToSapServer", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<SendExceptionToSapServerActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken, RunDiagnosticsActionConfiguration> RunDiagnostics(Expression<Func<RunDiagnosticsInputOperationTypeType>> operationType)
        {
            var __workflow_operationType = WorkflowExpression.Compile(operationType, nameof(operationType), required: true);
            return new DeferredBodyAction<JToken, RunDiagnosticsActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = ExpressionConverter.ConvertO(__workflow_operationType);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnostics", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken, RunDiagnosticsActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class CallRfcActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CreateRfcTransactionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetRfcTransactionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class AddRfcToTransactionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CommitRfcTransactionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ConfirmTransactionIdActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class SendIDocActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class BapiCallMethodActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CreateSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class CloseSessionActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class BapiCommitActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class BapiRollbackActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class ReadTableActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetSchemaV2ActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetIDocListActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class GetIDocStatusActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class RespondToSapServerActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class SendExceptionToSapServerActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public sealed class RunDiagnosticsActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public RetryPolicy RetryPolicy { get; set; }
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SapTriggerOutput, SapTriggerTriggerConfiguration> SapTrigger(Expression<Func<SapTriggerInputIdocFormatType>> idocFormat, Expression<Func<int>> degreeOfParallelism, Expression<Func<string>> gatewayHost, Expression<Func<string>> gatewayService, Expression<Func<string>> programId, Expression<Func<string>> sncPartnerNames = null, Expression<Func<bool>> receiveIDocsWithUnreleasedSegmentsV2 = null, Expression<Func<string>> defaultIDocRelease = null, Expression<Func<string>> receivedIDocTypeReleaseMapping = null, Expression<Func<bool>> gatewayWithoutWorkProcess = null)
        {
            var __workflow_idocFormat = WorkflowExpression.Compile(idocFormat, nameof(idocFormat), required: true);
            var __workflow_degreeOfParallelism = WorkflowExpression.Compile(degreeOfParallelism, nameof(degreeOfParallelism), required: true);
            var __workflow_gatewayHost = WorkflowExpression.Compile(gatewayHost, nameof(gatewayHost), required: true);
            var __workflow_gatewayService = WorkflowExpression.Compile(gatewayService, nameof(gatewayService), required: true);
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            var __workflow_sncPartnerNames = WorkflowExpression.Compile(sncPartnerNames, nameof(sncPartnerNames), required: false);
            var __workflow_receiveIDocsWithUnreleasedSegmentsV2 = WorkflowExpression.Compile(receiveIDocsWithUnreleasedSegmentsV2, nameof(receiveIDocsWithUnreleasedSegmentsV2), required: false);
            var __workflow_defaultIDocRelease = WorkflowExpression.Compile(defaultIDocRelease, nameof(defaultIDocRelease), required: false);
            var __workflow_receivedIDocTypeReleaseMapping = WorkflowExpression.Compile(receivedIDocTypeReleaseMapping, nameof(receivedIDocTypeReleaseMapping), required: false);
            var __workflow_gatewayWithoutWorkProcess = WorkflowExpression.Compile(gatewayWithoutWorkProcess, nameof(gatewayWithoutWorkProcess), required: false);
            return new DeferredBodyTrigger<SapTriggerOutput, SapTriggerTriggerConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = ExpressionConverter.ConvertO(__workflow_idocFormat);
                if (__workflow_sncPartnerNames != null)
                {
                    serviceProviderParameters["SncPartnerNames"] = ExpressionConverter.ConvertO(__workflow_sncPartnerNames);
                }

                serviceProviderParameters["DegreeOfParallelism"] = ExpressionConverter.ConvertO(__workflow_degreeOfParallelism);
                if (__workflow_receiveIDocsWithUnreleasedSegmentsV2 != null)
                {
                    serviceProviderParameters["ReceiveIDocsWithUnreleasedSegmentsV2"] = ExpressionConverter.ConvertO(__workflow_receiveIDocsWithUnreleasedSegmentsV2);
                }

                serviceProviderParameters["GatewayHost"] = ExpressionConverter.ConvertO(__workflow_gatewayHost);
                serviceProviderParameters["GatewayService"] = ExpressionConverter.ConvertO(__workflow_gatewayService);
                serviceProviderParameters["ProgramId"] = ExpressionConverter.ConvertO(__workflow_programId);
                if (__workflow_defaultIDocRelease != null)
                {
                    serviceProviderParameters["DefaultIDocRelease"] = ExpressionConverter.ConvertO(__workflow_defaultIDocRelease);
                }

                if (__workflow_receivedIDocTypeReleaseMapping != null)
                {
                    serviceProviderParameters["ReceivedIDocTypeReleaseMapping"] = ExpressionConverter.ConvertO(__workflow_receivedIDocTypeReleaseMapping);
                }

                if (__workflow_gatewayWithoutWorkProcess != null)
                {
                    serviceProviderParameters["GatewayWithoutWorkProcess"] = ExpressionConverter.ConvertO(__workflow_gatewayWithoutWorkProcess);
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
                return new ServiceProviderBodyTrigger<SapTriggerOutput, SapTriggerTriggerConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SapTriggerTriggerConfiguration : ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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