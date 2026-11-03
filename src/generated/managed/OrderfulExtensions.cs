//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orderful
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrderfulActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ListTransactions()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/transactions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTransaction()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orderful")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTransactionById(Expression<Func<int>> transactionId)
        {
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/transactions/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class OrderfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CommunicationChannelCreationResponse, ApiConnectionTriggerConfiguration> CommunicationChannel(Expression<Func<bool>> communicationChannelRequestBodyisActive, Expression<Func<string>> communicationChannelRequestBodyname, Expression<Func<int>> communicationChannelRequestBodyownerId, Expression<Func<string>> communicationChannelRequestBodyconfigdestinationTypeName = null, Expression<Func<bool>> communicationChannelRequestBodyconfigguidelineFilter = null, FlowRecurrence recurrence = null)
        {
            var __workflow_communicationChannelRequestBodyisActive = WorkflowExpression.Compile(communicationChannelRequestBodyisActive, nameof(communicationChannelRequestBodyisActive), required: true);
            var __workflow_communicationChannelRequestBodyname = WorkflowExpression.Compile(communicationChannelRequestBodyname, nameof(communicationChannelRequestBodyname), required: true);
            var __workflow_communicationChannelRequestBodyownerId = WorkflowExpression.Compile(communicationChannelRequestBodyownerId, nameof(communicationChannelRequestBodyownerId), required: true);
            var __workflow_communicationChannelRequestBodyconfigdestinationTypeName = WorkflowExpression.Compile(communicationChannelRequestBodyconfigdestinationTypeName, nameof(communicationChannelRequestBodyconfigdestinationTypeName), required: false);
            var __workflow_communicationChannelRequestBodyconfigguidelineFilter = WorkflowExpression.Compile(communicationChannelRequestBodyconfigguidelineFilter, nameof(communicationChannelRequestBodyconfigguidelineFilter), required: false);
            return new DeferredBodyTrigger<CommunicationChannelCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/destinations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var communicationChannelRequestBody = new JObject();
                var communicationChannelRequestBodypropCount = 0;
                communicationChannelRequestBodypropCount++;
                communicationChannelRequestBody["isActive"] = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBodyisActive);
                communicationChannelRequestBodypropCount++;
                communicationChannelRequestBody["name"] = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBodyname);
                var configObject = new JObject();
                var configObjectpropCount = 0;
                if (__workflow_communicationChannelRequestBodyconfigdestinationTypeName != null)
                {
                    if (__workflow_communicationChannelRequestBodyconfigdestinationTypeName != null)
                    {
                        configObject["destinationTypeName"] = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBodyconfigdestinationTypeName);
                        configObjectpropCount++;
                    }

                    configObjectpropCount++;
                }
                else
                {
                    configObject["destinationTypeName"] = "http";
                    configObjectpropCount++;
                }

                if (__workflow_communicationChannelRequestBodyconfigguidelineFilter != null)
                {
                    if (__workflow_communicationChannelRequestBodyconfigguidelineFilter != null)
                    {
                        configObject["guidelineFilter"] = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBodyconfigguidelineFilter);
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
                communicationChannelRequestBody["ownerId"] = ExpressionConverter.ConvertO(__workflow_communicationChannelRequestBodyownerId);
                if (communicationChannelRequestBodypropCount > 0)
                {
                    callPayload.Body = communicationChannelRequestBody;
                }

                return new ApiConnectionTrigger<CommunicationChannelCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CommunicationChannelCreationResponse
    {
        [JsonProperty("id")]
        public int WebhookCommunicationChannelId { get; set; }
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