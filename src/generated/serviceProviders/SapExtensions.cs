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
        [WorkflowExpressionFactory(nameof(__BuildCallRfc))]
        public IBodyWorkflowAction<JToken> CallRfc([WorkflowExpression] Func<CallRfcInputInputBodyTypeType> inputBodyType = null, [WorkflowExpression] Func<string> rfcName = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<bool> safeType = null, [WorkflowExpression] Func<CallRfcInputOutputBodyTypeType> outputBodyType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCallRfc(WorkflowValue<CallRfcInputInputBodyTypeType> inputBodyType = null, WorkflowValue<string> rfcName = null, WorkflowValue<string> sessionId = null, WorkflowValue<string> tId = null, WorkflowValue<string> queueName = null, WorkflowValue<bool> autoCommit = null, WorkflowValue<bool> safeType = null, WorkflowValue<CallRfcInputOutputBodyTypeType> outputBodyType = null)
        {
            WorkflowValue.Validate(inputBodyType, nameof(inputBodyType), required: false);
            WorkflowValue.Validate(rfcName, nameof(rfcName), required: false);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(tId, nameof(tId), required: false);
            WorkflowValue.Validate(queueName, nameof(queueName), required: false);
            WorkflowValue.Validate(autoCommit, nameof(autoCommit), required: false);
            WorkflowValue.Validate(safeType, nameof(safeType), required: false);
            WorkflowValue.Validate(outputBodyType, nameof(outputBodyType), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRfcTransaction))]
        public IBodyWorkflowAction<CreateRfcTransactionOutput> CreateRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateRfcTransactionOutput> __BuildCreateRfcTransaction(WorkflowValue<string> tId, WorkflowValue<string> queueName = null)
        {
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            WorkflowValue.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<CreateRfcTransactionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetRfcTransaction))]
        public IBodyWorkflowAction<GetRfcTransactionOutput> GetRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRfcTransactionOutput> __BuildGetRfcTransaction(WorkflowValue<string> tId, WorkflowValue<string> queueName = null)
        {
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            WorkflowValue.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<GetRfcTransactionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildAddRfcToTransaction))]
        public IBodyWorkflowAction<AddRfcToTransactionOutput> AddRfcToTransaction([WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddRfcToTransactionOutput> __BuildAddRfcToTransaction(WorkflowValue<object> body, WorkflowValue<string> tId, WorkflowValue<string> queueName = null, WorkflowValue<bool> autoCommit = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: true);
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            WorkflowValue.Validate(queueName, nameof(queueName), required: false);
            WorkflowValue.Validate(autoCommit, nameof(autoCommit), required: false);
            return new DeferredBodyAction<AddRfcToTransactionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildCommitRfcTransaction))]
        public IBodyWorkflowAction<CommitRfcTransactionOutput> CommitRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommitRfcTransactionOutput> __BuildCommitRfcTransaction(WorkflowValue<string> tId, WorkflowValue<string> queueName = null)
        {
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            WorkflowValue.Validate(queueName, nameof(queueName), required: false);
            return new DeferredBodyAction<CommitRfcTransactionOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildConfirmTransactionId))]
        public IWorkflowAction ConfirmTransactionId([WorkflowExpression] Func<string> tId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConfirmTransactionId(WorkflowValue<string> tId)
        {
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = ExpressionConverter.ConvertO(tId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "confirmTransactionId", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildSendIDoc))]
        public IBodyWorkflowAction<SendIDocOutput> SendIDoc([WorkflowExpression] Func<SendIDocInputIdocFormatType> idocFormat, [WorkflowExpression] Func<bool> confirmTid, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<bool> allowUnreleasedSegmentV2 = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendIDocOutput> __BuildSendIDoc(WorkflowValue<SendIDocInputIdocFormatType> idocFormat, WorkflowValue<bool> confirmTid, WorkflowValue<string> tId = null, WorkflowValue<bool> allowUnreleasedSegmentV2 = null)
        {
            WorkflowValue.Validate(idocFormat, nameof(idocFormat), required: true);
            WorkflowValue.Validate(confirmTid, nameof(confirmTid), required: true);
            WorkflowValue.Validate(tId, nameof(tId), required: false);
            WorkflowValue.Validate(allowUnreleasedSegmentV2, nameof(allowUnreleasedSegmentV2), required: false);
            return new DeferredBodyAction<SendIDocOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildBapiCallMethod))]
        public IBodyWorkflowAction<BapiCallMethodOutput> BapiCallMethod([WorkflowExpression] Func<string> businessObject, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<bool> autoCommit, [WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> safeType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BapiCallMethodOutput> __BuildBapiCallMethod(WorkflowValue<string> businessObject, WorkflowValue<string> method, WorkflowValue<bool> autoCommit, WorkflowValue<object> body, WorkflowValue<string> sessionId = null, WorkflowValue<bool> safeType = null)
        {
            WorkflowValue.Validate(businessObject, nameof(businessObject), required: true);
            WorkflowValue.Validate(method, nameof(method), required: true);
            WorkflowValue.Validate(autoCommit, nameof(autoCommit), required: true);
            WorkflowValue.Validate(body, nameof(body), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            WorkflowValue.Validate(safeType, nameof(safeType), required: false);
            return new DeferredBodyAction<BapiCallMethodOutput>(() =>
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildCloseSession))]
        public IWorkflowAction CloseSession([WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCloseSession(WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "closeSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildBapiCommit))]
        public IBodyWorkflowAction<BapiCommitOutput> BapiCommit([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> wait, [WorkflowExpression] Func<bool> closeSession)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BapiCommitOutput> __BuildBapiCommit(WorkflowValue<string> sessionId, WorkflowValue<bool> wait, WorkflowValue<bool> closeSession)
        {
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowValue.Validate(wait, nameof(wait), required: true);
            WorkflowValue.Validate(closeSession, nameof(closeSession), required: true);
            return new DeferredBodyAction<BapiCommitOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildBapiRollback))]
        public IBodyWorkflowAction<BapiRollbackOutput> BapiRollback([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> closeSession)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BapiRollbackOutput> __BuildBapiRollback(WorkflowValue<string> sessionId, WorkflowValue<bool> closeSession)
        {
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowValue.Validate(closeSession, nameof(closeSession), required: true);
            return new DeferredBodyAction<BapiRollbackOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildReadTable))]
        public IBodyWorkflowAction<ReadTableOutput> ReadTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string[]> fieldNames = null, [WorkflowExpression] Func<string[]> whereFilters = null, [WorkflowExpression] Func<int> startIndex = null, [WorkflowExpression] Func<int> numberOfRowsToRead = null, [WorkflowExpression] Func<string> delimiter = null, [WorkflowExpression] Func<ReadTableInputReturnFormatType> returnFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadTableOutput> __BuildReadTable(WorkflowValue<string> tableName, WorkflowValue<string[]> fieldNames = null, WorkflowValue<string[]> whereFilters = null, WorkflowValue<int> startIndex = null, WorkflowValue<int> numberOfRowsToRead = null, WorkflowValue<string> delimiter = null, WorkflowValue<ReadTableInputReturnFormatType> returnFormat = null)
        {
            WorkflowValue.Validate(tableName, nameof(tableName), required: true);
            WorkflowValue.Validate(fieldNames, nameof(fieldNames), required: false);
            WorkflowValue.Validate(whereFilters, nameof(whereFilters), required: false);
            WorkflowValue.Validate(startIndex, nameof(startIndex), required: false);
            WorkflowValue.Validate(numberOfRowsToRead, nameof(numberOfRowsToRead), required: false);
            WorkflowValue.Validate(delimiter, nameof(delimiter), required: false);
            WorkflowValue.Validate(returnFormat, nameof(returnFormat), required: false);
            return new DeferredBodyAction<ReadTableOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetSchemaV2))]
        public IBodyWorkflowAction<JToken> GetSchemaV2([WorkflowExpression] Func<GetSchemaV2InputOperationTypeType> operationType, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetSchemaV2(WorkflowValue<GetSchemaV2InputOperationTypeType> operationType, WorkflowValue<string> fileNamePrefix = null)
        {
            WorkflowValue.Validate(operationType, nameof(operationType), required: true);
            WorkflowValue.Validate(fileNamePrefix, nameof(fileNamePrefix), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetIDocList))]
        public IBodyWorkflowAction<GetIDocListOutput> GetIDocList([WorkflowExpression] Func<GetIDocListInputDirectionType> direction, [WorkflowExpression] Func<string> tId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIDocListOutput> __BuildGetIDocList(WorkflowValue<GetIDocListInputDirectionType> direction, WorkflowValue<string> tId)
        {
            WorkflowValue.Validate(direction, nameof(direction), required: true);
            WorkflowValue.Validate(tId, nameof(tId), required: true);
            return new DeferredBodyAction<GetIDocListOutput>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildGetIDocStatus))]
        public IBodyWorkflowAction<GetIDocStatusOutput> GetIDocStatus([WorkflowExpression] Func<int> iDocNumber)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIDocStatusOutput> __BuildGetIDocStatus(WorkflowValue<int> iDocNumber)
        {
            WorkflowValue.Validate(iDocNumber, nameof(iDocNumber), required: true);
            return new DeferredBodyAction<GetIDocStatusOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["iDocNumber"] = ExpressionConverter.ConvertO(iDocNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocStatus", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<GetIDocStatusOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildRespondToSapServer))]
        public IWorkflowAction RespondToSapServer([WorkflowExpression] Func<string> body, [WorkflowExpression] Func<bool> safeType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRespondToSapServer(WorkflowValue<string> body, WorkflowValue<bool> safeType = null)
        {
            WorkflowValue.Validate(body, nameof(body), required: true);
            WorkflowValue.Validate(safeType, nameof(safeType), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildSendExceptionToSapServer))]
        public IWorkflowAction SendExceptionToSapServer([WorkflowExpression] Func<string> sendExceptionToSapServerErrorMessage, [WorkflowExpression] Func<string> sendExceptionToSapServerExceptionName = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageType = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageClass = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageNumber = null, [WorkflowExpression] Func<bool> sendExceptionToSapServerIsAbapMessage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendExceptionToSapServer(WorkflowValue<string> sendExceptionToSapServerErrorMessage, WorkflowValue<string> sendExceptionToSapServerExceptionName = null, WorkflowValue<string> sendExceptionToSapServerMessageType = null, WorkflowValue<string> sendExceptionToSapServerMessageClass = null, WorkflowValue<string> sendExceptionToSapServerMessageNumber = null, WorkflowValue<bool> sendExceptionToSapServerIsAbapMessage = null)
        {
            WorkflowValue.Validate(sendExceptionToSapServerErrorMessage, nameof(sendExceptionToSapServerErrorMessage), required: true);
            WorkflowValue.Validate(sendExceptionToSapServerExceptionName, nameof(sendExceptionToSapServerExceptionName), required: false);
            WorkflowValue.Validate(sendExceptionToSapServerMessageType, nameof(sendExceptionToSapServerMessageType), required: false);
            WorkflowValue.Validate(sendExceptionToSapServerMessageClass, nameof(sendExceptionToSapServerMessageClass), required: false);
            WorkflowValue.Validate(sendExceptionToSapServerMessageNumber, nameof(sendExceptionToSapServerMessageNumber), required: false);
            WorkflowValue.Validate(sendExceptionToSapServerIsAbapMessage, nameof(sendExceptionToSapServerIsAbapMessage), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        [WorkflowExpressionFactory(nameof(__BuildRunDiagnostics))]
        public IBodyWorkflowAction<JToken> RunDiagnostics([WorkflowExpression] Func<RunDiagnosticsInputOperationTypeType> operationType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildRunDiagnostics(WorkflowValue<RunDiagnosticsInputOperationTypeType> operationType)
        {
            WorkflowValue.Validate(operationType, nameof(operationType), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = ExpressionConverter.ConvertO(operationType);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnostics", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildSapTrigger))]
        public IBodyWorkflowTrigger<SapTriggerOutput> SapTrigger([WorkflowExpression] Func<SapTriggerInputIdocFormatType> idocFormat, [WorkflowExpression] Func<int> degreeOfParallelism, [WorkflowExpression] Func<string> gatewayHost, [WorkflowExpression] Func<string> gatewayService, [WorkflowExpression] Func<string> programId, [WorkflowExpression] Func<string> sncPartnerNames = null, [WorkflowExpression] Func<bool> receiveIDocsWithUnreleasedSegmentsV2 = null, [WorkflowExpression] Func<string> defaultIDocRelease = null, [WorkflowExpression] Func<string> receivedIDocTypeReleaseMapping = null, [WorkflowExpression] Func<bool> gatewayWithoutWorkProcess = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<SapTriggerOutput> __BuildSapTrigger(WorkflowValue<SapTriggerInputIdocFormatType> idocFormat, WorkflowValue<int> degreeOfParallelism, WorkflowValue<string> gatewayHost, WorkflowValue<string> gatewayService, WorkflowValue<string> programId, WorkflowValue<string> sncPartnerNames = null, WorkflowValue<bool> receiveIDocsWithUnreleasedSegmentsV2 = null, WorkflowValue<string> defaultIDocRelease = null, WorkflowValue<string> receivedIDocTypeReleaseMapping = null, WorkflowValue<bool> gatewayWithoutWorkProcess = null)
        {
            WorkflowValue.Validate(idocFormat, nameof(idocFormat), required: true);
            WorkflowValue.Validate(degreeOfParallelism, nameof(degreeOfParallelism), required: true);
            WorkflowValue.Validate(gatewayHost, nameof(gatewayHost), required: true);
            WorkflowValue.Validate(gatewayService, nameof(gatewayService), required: true);
            WorkflowValue.Validate(programId, nameof(programId), required: true);
            WorkflowValue.Validate(sncPartnerNames, nameof(sncPartnerNames), required: false);
            WorkflowValue.Validate(receiveIDocsWithUnreleasedSegmentsV2, nameof(receiveIDocsWithUnreleasedSegmentsV2), required: false);
            WorkflowValue.Validate(defaultIDocRelease, nameof(defaultIDocRelease), required: false);
            WorkflowValue.Validate(receivedIDocTypeReleaseMapping, nameof(receivedIDocTypeReleaseMapping), required: false);
            WorkflowValue.Validate(gatewayWithoutWorkProcess, nameof(gatewayWithoutWorkProcess), required: false);
            return new DeferredBodyTrigger<SapTriggerOutput>(() =>
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
            }, "ServiceProviderTrigger");
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
