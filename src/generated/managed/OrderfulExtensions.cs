//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orderful
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrderfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction ListTransactions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction CreateTransaction()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction GetTransactionById([WorkflowExpression] Func<int> transactionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/transactions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class OrderfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CommunicationChannelCreationResponse> CommunicationChannel([WorkflowExpression] Func<bool> communicationChannelRequestBodyisActive, [WorkflowExpression] Func<string> communicationChannelRequestBodyname, [WorkflowExpression] Func<int> communicationChannelRequestBodyownerId, [WorkflowExpression] Func<string> communicationChannelRequestBodyconfigdestinationTypeName = null, [WorkflowExpression] Func<bool> communicationChannelRequestBodyconfigguidelineFilter = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/destinations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var communicationChannelRequestBody = new JObject();
                var communicationChannelRequestBodypropCount = 0;
                communicationChannelRequestBodypropCount++;
                communicationChannelRequestBody["isActive"] = SourceExpressionConverter.ConvertToken(communicationChannelRequestBodyisActive);
                communicationChannelRequestBodypropCount++;
                communicationChannelRequestBody["name"] = SourceExpressionConverter.ConvertToken(communicationChannelRequestBodyname);
                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (communicationChannelRequestBodyconfigdestinationTypeName != null)
                {
                    if (communicationChannelRequestBodyconfigdestinationTypeName != null)
                    {
                        configObject["destinationTypeName"] = SourceExpressionConverter.ConvertToken(communicationChannelRequestBodyconfigdestinationTypeName);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["destinationTypeName"] = "http";
                    configObjectpropCount++;
                }

                if (communicationChannelRequestBodyconfigguidelineFilter != null)
                {
                    if (communicationChannelRequestBodyconfigguidelineFilter != null)
                    {
                        configObject["guidelineFilter"] = SourceExpressionConverter.ConvertToken(communicationChannelRequestBodyconfigguidelineFilter);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["guidelineFilter"] = false;
                    configObjectpropCount++;
                }

                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (configObjectpropCount > 0)
                {
                    communicationChannelRequestBody["config"] = configObject;
                    communicationChannelRequestBodypropCount++;
                }

                communicationChannelRequestBodypropCount++;
                communicationChannelRequestBody["ownerId"] = SourceExpressionConverter.ConvertToken(communicationChannelRequestBodyownerId);
                if (communicationChannelRequestBodypropCount > 0)
                {
                    callPayload.Body = communicationChannelRequestBody;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<CommunicationChannelCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class CommunicationChannelCreationResponse
    {
        [JsonProperty("id")]
        public int WebhookCommunicationChannelID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Orderful;

    public partial class WorkflowManagedActions
    {
        public OrderfulActions Orderful(string connectionId) => new OrderfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrderfulTriggers Orderful(string connectionId) => new OrderfulTriggers(connectionId);
    }
}