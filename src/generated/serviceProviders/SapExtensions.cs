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
        public IBodyWorkflowAction<JToken> CallRfc([WorkflowExpression] Func<CallRfcInputInputBodyTypeType> inputBodyType = null, [WorkflowExpression] Func<string> rfcName = null, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null, [WorkflowExpression] Func<bool> safeType = null, [WorkflowExpression] Func<CallRfcInputOutputBodyTypeType> outputBodyType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (inputBodyType != null)
                {
                    serviceProviderParameters["inputBodyType"] = SourceExpressionConverter.ConvertToken(inputBodyType);
                }
                else
                {
                    serviceProviderParameters["inputBodyType"] = "XML";
                }

                if (rfcName != null)
                {
                    serviceProviderParameters["rfcName"] = SourceExpressionConverter.ConvertToken(rfcName);
                }

                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                if (tId != null)
                {
                    serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                }

                if (queueName != null)
                {
                    serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                }

                if (autoCommit != null)
                {
                    serviceProviderParameters["autoCommit"] = SourceExpressionConverter.ConvertToken(autoCommit);
                }

                if (safeType != null)
                {
                    serviceProviderParameters["safeType"] = SourceExpressionConverter.ConvertToken(safeType);
                }

                if (outputBodyType != null)
                {
                    serviceProviderParameters["outputBodyType"] = SourceExpressionConverter.ConvertToken(outputBodyType);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> GetCallRfcInputVariantSchemaSwagger([WorkflowExpression] Func<string> inputBodyType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (inputBodyType != null)
                {
                    serviceProviderParameters["inputBodyType"] = SourceExpressionConverter.ConvertToken(inputBodyType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getCallRfcInputVariantSchemaSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> GetCallRfcOutputVariantSchemaSwagger([WorkflowExpression] Func<string> outputBodyType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (outputBodyType != null)
                {
                    serviceProviderParameters["outputBodyType"] = SourceExpressionConverter.ConvertToken(outputBodyType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getCallRfcOutputVariantSchemaSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateRfcTransactionOutput> CreateRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                if (queueName != null)
                {
                    serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateRfcTransactionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetRfcTransactionOutput> GetRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                if (queueName != null)
                {
                    serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetRfcTransactionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<AddRfcToTransactionOutput> AddRfcToTransaction([WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null, [WorkflowExpression] Func<bool> autoCommit = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                if (queueName != null)
                {
                    serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                }

                if (autoCommit != null)
                {
                    serviceProviderParameters["autoCommit"] = SourceExpressionConverter.ConvertToken(autoCommit);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "addRfcToTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<AddRfcToTransactionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CommitRfcTransactionOutput> CommitRfcTransaction([WorkflowExpression] Func<string> tId, [WorkflowExpression] Func<string> queueName = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                if (queueName != null)
                {
                    serviceProviderParameters["queueName"] = SourceExpressionConverter.ConvertToken(queueName);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "commitRfcTransaction", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CommitRfcTransactionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ConfirmTransactionId([WorkflowExpression] Func<string> tId)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "confirmTransactionId", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<SendIDocOutput> SendIDoc([WorkflowExpression] Func<SendIDocInputIdocFormatType> idocFormat, [WorkflowExpression] Func<bool> confirmTid, [WorkflowExpression] Func<string> tId = null, [WorkflowExpression] Func<bool> allowUnreleasedSegmentV2 = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = SourceExpressionConverter.ConvertToken(idocFormat);
                if (tId != null)
                {
                    serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                }

                serviceProviderParameters["confirmTid"] = SourceExpressionConverter.ConvertToken(confirmTid);
                if (allowUnreleasedSegmentV2 != null)
                {
                    serviceProviderParameters["allowUnreleasedSegmentV2"] = SourceExpressionConverter.ConvertToken(allowUnreleasedSegmentV2);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<SendIDocOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> GetSendIDocInputSwagger([WorkflowExpression] Func<string> idocFormat)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = SourceExpressionConverter.ConvertToken(idocFormat);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSendIDocInputSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCallMethodOutput> BapiCallMethod([WorkflowExpression] Func<string> businessObject, [WorkflowExpression] Func<string> method, [WorkflowExpression] Func<bool> autoCommit, [WorkflowExpression] Func<object> body, [WorkflowExpression] Func<string> sessionId = null, [WorkflowExpression] Func<bool> safeType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["businessObject"] = SourceExpressionConverter.ConvertToken(businessObject);
                serviceProviderParameters["method"] = SourceExpressionConverter.ConvertToken(method);
                serviceProviderParameters["autoCommit"] = SourceExpressionConverter.ConvertToken(autoCommit);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                }

                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                if (safeType != null)
                {
                    serviceProviderParameters["safeType"] = SourceExpressionConverter.ConvertToken(safeType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCallMethod", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<BapiCallMethodOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<string[]> GetBusinessObjects()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getBusinessObjects", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<string[]> GetMethodsForBusinessObject([WorkflowExpression] Func<string> businessObject = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (businessObject != null)
                {
                    serviceProviderParameters["businessObject"] = SourceExpressionConverter.ConvertToken(businessObject);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getMethodsForBusinessObject", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<CreateSessionOutput> CreateSession()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "createSession", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<CreateSessionOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction CloseSession([WorkflowExpression] Func<string> sessionId)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "closeSession", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiCommitOutput> BapiCommit([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> wait, [WorkflowExpression] Func<bool> closeSession)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                serviceProviderParameters["wait"] = SourceExpressionConverter.ConvertToken(wait);
                serviceProviderParameters["closeSession"] = SourceExpressionConverter.ConvertToken(closeSession);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiCommit", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<BapiCommitOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<BapiRollbackOutput> BapiRollback([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bool> closeSession)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sessionId"] = SourceExpressionConverter.ConvertToken(sessionId);
                serviceProviderParameters["closeSession"] = SourceExpressionConverter.ConvertToken(closeSession);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "bapiRollback", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<BapiRollbackOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<ReadTableOutput> ReadTable([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string[]> fieldNames = null, [WorkflowExpression] Func<string[]> whereFilters = null, [WorkflowExpression] Func<int> startIndex = null, [WorkflowExpression] Func<int> numberOfRowsToRead = null, [WorkflowExpression] Func<string> delimiter = null, [WorkflowExpression] Func<ReadTableInputReturnFormatType> returnFormat = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (fieldNames != null)
                {
                    serviceProviderParameters["fieldNames"] = SourceExpressionConverter.ConvertToken(fieldNames);
                }

                if (whereFilters != null)
                {
                    serviceProviderParameters["whereFilters"] = SourceExpressionConverter.ConvertToken(whereFilters);
                }

                if (startIndex != null)
                {
                    serviceProviderParameters["startIndex"] = SourceExpressionConverter.ConvertToken(startIndex);
                }

                if (numberOfRowsToRead != null)
                {
                    serviceProviderParameters["numberOfRowsToRead"] = SourceExpressionConverter.ConvertToken(numberOfRowsToRead);
                }

                if (delimiter != null)
                {
                    serviceProviderParameters["delimiter"] = SourceExpressionConverter.ConvertToken(delimiter);
                }

                if (returnFormat != null)
                {
                    serviceProviderParameters["returnFormat"] = SourceExpressionConverter.ConvertToken(returnFormat);
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
                return serviceProviderInput;
            }

            return new ServiceProviderAction<ReadTableOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> ReadTableResponseDyanmicSchema([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string[]> fieldNames = null, [WorkflowExpression] Func<ReadTableResponseDyanmicSchemaInputReturnFormatType> returnFormat = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["tableName"] = SourceExpressionConverter.ConvertToken(tableName);
                if (fieldNames != null)
                {
                    serviceProviderParameters["fieldNames"] = SourceExpressionConverter.ConvertToken(fieldNames);
                }

                if (returnFormat != null)
                {
                    serviceProviderParameters["returnFormat"] = SourceExpressionConverter.ConvertToken(returnFormat);
                }
                else
                {
                    serviceProviderParameters["returnFormat"] = "Json";
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "readTableResponseDyanmicSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> GetSchema([WorkflowExpression] Func<GetSchemaInputOperationTypeType> operationType, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                if (fileNamePrefix != null)
                {
                    serviceProviderParameters["fileNamePrefix"] = SourceExpressionConverter.ConvertToken(fileNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> GetSchemaV2([WorkflowExpression] Func<GetSchemaV2InputOperationTypeType> operationType, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                if (fileNamePrefix != null)
                {
                    serviceProviderParameters["fileNamePrefix"] = SourceExpressionConverter.ConvertToken(fileNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaV2", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> GetSchemaInputSwagger([WorkflowExpression] Func<string> operationType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (operationType != null)
                {
                    serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaInputSwagger", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> GetSchemaResponseDyanmicSchema([WorkflowExpression] Func<GetSchemaResponseDyanmicSchemaInputOperationTypeType> operationType, [WorkflowExpression] Func<string> fileNamePrefix = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                if (fileNamePrefix != null)
                {
                    serviceProviderParameters["fileNamePrefix"] = SourceExpressionConverter.ConvertToken(fileNamePrefix);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getSchemaResponseDyanmicSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocListOutput> GetIDocList([WorkflowExpression] Func<GetIDocListInputDirectionType> direction, [WorkflowExpression] Func<string> tId)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["direction"] = SourceExpressionConverter.ConvertToken(direction);
                serviceProviderParameters["tId"] = SourceExpressionConverter.ConvertToken(tId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocList", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetIDocListOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<GetIDocStatusOutput> GetIDocStatus([WorkflowExpression] Func<int> iDocNumber)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["iDocNumber"] = SourceExpressionConverter.ConvertToken(iDocNumber);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "getIDocStatus", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<GetIDocStatusOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ListRfcs()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "listRfcs", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ListRfcGroups()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "listRfcGroups", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ListIDocTypes()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "listIDocTypes", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ListIDocReleases()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "listIDocReleases", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction ListIDocExtensions()
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "listIDocExtensions", connectionName: connectionId)
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction RespondToSapServer([WorkflowExpression] Func<string> body, [WorkflowExpression] Func<bool> safeType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                if (safeType != null)
                {
                    serviceProviderParameters["safeType"] = SourceExpressionConverter.ConvertToken(safeType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "respondToSapServer", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IWorkflowAction SendExceptionToSapServer([WorkflowExpression] Func<string> sendExceptionToSapServerErrorMessage, [WorkflowExpression] Func<string> sendExceptionToSapServerExceptionName = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageType = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageClass = null, [WorkflowExpression] Func<string> sendExceptionToSapServerMessageNumber = null, [WorkflowExpression] Func<bool> sendExceptionToSapServerIsAbapMessage = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["SendExceptionToSapServerErrorMessage"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerErrorMessage);
                if (sendExceptionToSapServerExceptionName != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerExceptionName"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerExceptionName);
                }

                if (sendExceptionToSapServerMessageType != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageType"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerMessageType);
                }

                if (sendExceptionToSapServerMessageClass != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageClass"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerMessageClass);
                }

                if (sendExceptionToSapServerMessageNumber != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerMessageNumber"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerMessageNumber);
                }

                if (sendExceptionToSapServerIsAbapMessage != null)
                {
                    serviceProviderParameters["SendExceptionToSapServerIsAbapMessage"] = SourceExpressionConverter.ConvertToken(sendExceptionToSapServerIsAbapMessage);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendExceptionToSapServer", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> SendMessage([WorkflowExpression] Func<string> sapAction, [WorkflowExpression] Func<string> body)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["sapAction"] = SourceExpressionConverter.ConvertToken(sapAction);
                serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sendMessage", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IBodyWorkflowAction<JToken> RunDiagnostics([WorkflowExpression] Func<RunDiagnosticsInputOperationTypeType> operationType)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnostics", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> RunDiagnosticsInputSchema([WorkflowExpression] Func<string> operationType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (operationType != null)
                {
                    serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnosticsInputSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> RunDiagnosticsOutputSchema([WorkflowExpression] Func<string> operationType = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                if (operationType != null)
                {
                    serviceProviderParameters["operationType"] = SourceExpressionConverter.ConvertToken(operationType);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "runDiagnosticsOutputSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "sap")]
        public IOutputWorkflowAction<JToken> SapTriggerInputSchema([WorkflowExpression] Func<SapTriggerInputSchemaInputIdocFormatType> idocFormat)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = SourceExpressionConverter.ConvertToken(idocFormat);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/sap", operationId: "sapTriggerInputSchema", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<JToken>(BuildSourceInput);
        }
    }

    public class SapTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<SapTriggerOutput> SapTrigger([WorkflowExpression] Func<SapTriggerInputIdocFormatType> idocFormat, [WorkflowExpression] Func<int> degreeOfParallelism, [WorkflowExpression] Func<string> gatewayHost, [WorkflowExpression] Func<string> gatewayService, [WorkflowExpression] Func<string> programId, [WorkflowExpression] Func<string> sncPartnerNames = null, [WorkflowExpression] Func<bool> receiveIDocsWithUnreleasedSegmentsV2 = null, [WorkflowExpression] Func<string> defaultIDocRelease = null, [WorkflowExpression] Func<string> receivedIDocTypeReleaseMapping = null, [WorkflowExpression] Func<bool> gatewayWithoutWorkProcess = null)
        {
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["idocFormat"] = SourceExpressionConverter.ConvertToken(idocFormat);
                if (sncPartnerNames != null)
                {
                    serviceProviderParameters["SncPartnerNames"] = SourceExpressionConverter.ConvertToken(sncPartnerNames);
                }

                serviceProviderParameters["DegreeOfParallelism"] = SourceExpressionConverter.ConvertToken(degreeOfParallelism);
                if (receiveIDocsWithUnreleasedSegmentsV2 != null)
                {
                    serviceProviderParameters["ReceiveIDocsWithUnreleasedSegmentsV2"] = SourceExpressionConverter.ConvertToken(receiveIDocsWithUnreleasedSegmentsV2);
                }

                serviceProviderParameters["GatewayHost"] = SourceExpressionConverter.ConvertToken(gatewayHost);
                serviceProviderParameters["GatewayService"] = SourceExpressionConverter.ConvertToken(gatewayService);
                serviceProviderParameters["ProgramId"] = SourceExpressionConverter.ConvertToken(programId);
                if (defaultIDocRelease != null)
                {
                    serviceProviderParameters["DefaultIDocRelease"] = SourceExpressionConverter.ConvertToken(defaultIDocRelease);
                }

                if (receivedIDocTypeReleaseMapping != null)
                {
                    serviceProviderParameters["ReceivedIDocTypeReleaseMapping"] = SourceExpressionConverter.ConvertToken(receivedIDocTypeReleaseMapping);
                }

                if (gatewayWithoutWorkProcess != null)
                {
                    serviceProviderParameters["GatewayWithoutWorkProcess"] = SourceExpressionConverter.ConvertToken(gatewayWithoutWorkProcess);
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
                return serviceProviderInput;
            }

            return new ServiceProviderTrigger<SapTriggerOutput>(BuildSourceInput);
        }
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
    public enum ReadTableResponseDyanmicSchemaInputReturnFormatType
    {
        Xml,
        Json,
        ExpandedJson
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetSchemaInputOperationTypeType
    {
        BAPI,
        RFC,
        IDoc,
        [EnumMember(Value = "tRFC")]
        TRFC
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GetSchemaResponseDyanmicSchemaInputOperationTypeType
    {
        Bapi,
        Rfc,
        IDoc,
        Trfc,
        RFC
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

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SapTriggerInputSchemaInputIdocFormatType
    {
        MicrosoftLobNamespaceXml,
        SapPlainXml,
        FlatFile
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