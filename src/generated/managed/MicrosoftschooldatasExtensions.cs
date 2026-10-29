//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftschooldatas
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftschooldatasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IBodyWorkflowAction<GetDelegatedTokenResponse, ApiConnectionActionConfiguration> GetDelegatedToken()
        {
            var apiCallPath = "/common/oauth2/token";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetDelegatedTokenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetInboundFlow(Expression<Func<string>> inboundFlowId, Expression<Func<string>> accessToken = null)
        {
            var __workflow_inboundFlowId = WorkflowExpression.Compile(inboundFlowId, nameof(inboundFlowId), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/external/industryData/inboundFlows/{0}", __workflow_inboundFlowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("dataConnector");
                if (__workflow_accessToken != null)
                    callPayload.Headers["access-token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDataconnectorList(Expression<Func<string>> accessToken)
        {
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/external/industryData/dataConnectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CallGetuploadsession(Expression<Func<string>> createdDataConnectorId, Expression<Func<string>> accessToken)
        {
            var __workflow_createdDataConnectorId = WorkflowExpression.Compile(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/external/industryData/dataConnectors('{0}')/microsoft.graph.industryData.azureDataLakeConnector/microsoft.graph.industryData.getUploadSession()", __workflow_createdDataConnectorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CallValidate(Expression<Func<string>> createdDataConnectorId, Expression<Func<string>> accessToken)
        {
            var __workflow_createdDataConnectorId = WorkflowExpression.Compile(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/beta/external/industryData/dataConnectors/{0}/validate()", __workflow_createdDataConnectorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(__workflow_accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckValidationResult(Expression<Func<string>> validationOperationUri, Expression<Func<string>> accessToken)
        {
            var __workflow_validationOperationUri = WorkflowExpression.Compile(validationOperationUri, nameof(validationOperationUri), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ValidationOperationUri"] = ExpressionConverter.Convert(__workflow_validationOperationUri);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class MicrosoftschooldatasTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDelegatedTokenResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftschooldatas;

    public partial class WorkflowManagedActions
    {
        public MicrosoftschooldatasActions Microsoftschooldatas(string connectionId) => new MicrosoftschooldatasActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftschooldatasTriggers Microsoftschooldatas(string connectionId) => new MicrosoftschooldatasTriggers(connectionId);
    }
}
