//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftschooldatas
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftschooldatasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IBodyWorkflowAction<GetDelegatedTokenResponse> GetDelegatedToken()
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
        [WorkflowExpressionFactory(nameof(__BuildGetInboundFlow))]
        public IWorkflowAction GetInboundFlow([WorkflowExpression] Func<string> inboundFlowId, [WorkflowExpression] Func<string> accessToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetInboundFlow(WorkflowExpression<string> inboundFlowId, WorkflowExpression<string> accessToken = null)
        {
            WorkflowExpression.Validate(inboundFlowId, nameof(inboundFlowId), required: true);
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/inboundFlows/{0}", ExpressionConverter.ConvertWithUrlEncoding(inboundFlowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("dataConnector");
                if (accessToken != null)
                    callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        [WorkflowExpressionFactory(nameof(__BuildGetDataconnectorList))]
        public IWorkflowAction GetDataconnectorList([WorkflowExpression] Func<string> accessToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDataconnectorList(WorkflowExpression<string> accessToken)
        {
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/beta/external/industryData/dataConnectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        [WorkflowExpressionFactory(nameof(__BuildCallGetuploadsession))]
        public IWorkflowAction CallGetuploadsession([WorkflowExpression] Func<string> createdDataConnectorId, [WorkflowExpression] Func<string> accessToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallGetuploadsession(WorkflowExpression<string> createdDataConnectorId, WorkflowExpression<string> accessToken)
        {
            WorkflowExpression.Validate(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/dataConnectors('{0}')/microsoft.graph.industryData.azureDataLakeConnector/microsoft.graph.industryData.getUploadSession()", ExpressionConverter.ConvertWithUrlEncoding(createdDataConnectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        [WorkflowExpressionFactory(nameof(__BuildCallValidate))]
        public IWorkflowAction CallValidate([WorkflowExpression] Func<string> createdDataConnectorId, [WorkflowExpression] Func<string> accessToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallValidate(WorkflowExpression<string> createdDataConnectorId, WorkflowExpression<string> accessToken)
        {
            WorkflowExpression.Validate(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/dataConnectors/{0}/validate()", ExpressionConverter.ConvertWithUrlEncoding(createdDataConnectorId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        [WorkflowExpressionFactory(nameof(__BuildCheckValidationResult))]
        public IWorkflowAction CheckValidationResult([WorkflowExpression] Func<string> validationOperationUri, [WorkflowExpression] Func<string> accessToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckValidationResult(WorkflowExpression<string> validationOperationUri, WorkflowExpression<string> accessToken)
        {
            WorkflowExpression.Validate(validationOperationUri, nameof(validationOperationUri), required: true);
            WorkflowExpression.Validate(accessToken, nameof(accessToken), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ValidationOperationUri"] = ExpressionConverter.Convert(validationOperationUri);
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
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