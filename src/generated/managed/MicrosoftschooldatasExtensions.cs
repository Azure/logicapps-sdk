//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftschooldatas
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftschooldatasActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IBodyWorkflowAction<GetDelegatedTokenResponse> GetDelegatedToken()
        {
            ApiConnectionActionInput BuildSourceInput()
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
                return callPayload;
            }

            return new ApiConnectionAction<GetDelegatedTokenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction GetInboundFlow([WorkflowExpression] Func<string> inboundFlowId, [WorkflowExpression] Func<string> accessToken = null)
        {
            SourceExpression.Validate(inboundFlowId, nameof(inboundFlowId), required: true);
            SourceExpression.Validate(accessToken, nameof(accessToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/inboundFlows/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inboundFlowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$expand"] = Convert.ToString("dataConnector");
                if (accessToken != null)
                    callPayload.Headers["access-token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction GetDataconnectorList([WorkflowExpression] Func<string> accessToken)
        {
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/external/industryData/dataConnectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CallGetuploadsession([WorkflowExpression] Func<string> createdDataConnectorId, [WorkflowExpression] Func<string> accessToken)
        {
            SourceExpression.Validate(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/dataConnectors('{0}')/microsoft.graph.industryData.azureDataLakeConnector/microsoft.graph.industryData.getUploadSession()", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(createdDataConnectorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CallValidate([WorkflowExpression] Func<string> createdDataConnectorId, [WorkflowExpression] Func<string> accessToken)
        {
            SourceExpression.Validate(createdDataConnectorId, nameof(createdDataConnectorId), required: true);
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/beta/external/industryData/dataConnectors/{0}/validate()", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(createdDataConnectorId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["access-token"] = SourceExpressionConverter.ConvertO(accessToken);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CheckValidationResult([WorkflowExpression] Func<string> validationOperationUri, [WorkflowExpression] Func<string> accessToken)
        {
            SourceExpression.Validate(validationOperationUri, nameof(validationOperationUri), required: true);
            SourceExpression.Validate(accessToken, nameof(accessToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ValidationOperationUri"] = SourceExpressionConverter.ConvertO(validationOperationUri);
                callPayload.Headers["access-token"] = SourceExpressionConverter.ConvertO(accessToken);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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