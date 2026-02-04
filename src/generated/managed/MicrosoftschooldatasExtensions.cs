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
        public IWorkflowAction GetInboundFlow(Expression<Func<string>> inboundFlowId, Expression<Func<string>> accessToken = null)
        {
            var apiCallPath = String.Format("/beta/external/industryData/inboundFlows/{0}", ExpressionConverter.ConvertWithUrlEncoding(inboundFlowId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$expand"] = Convert.ToString("dataConnector");
            if (accessToken != null)
                callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction GetDataconnectorList(Expression<Func<string>> accessToken)
        {
            var apiCallPath = "/beta/external/industryData/dataConnectors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CallGetuploadsession(Expression<Func<string>> createdDataConnectorId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/beta/external/industryData/dataConnectors('{0}')/microsoft.graph.industryData.azureDataLakeConnector/microsoft.graph.industryData.getUploadSession()", ExpressionConverter.ConvertWithUrlEncoding(createdDataConnectorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CallValidate(Expression<Func<string>> createdDataConnectorId, Expression<Func<string>> accessToken)
        {
            var apiCallPath = String.Format("/beta/external/industryData/dataConnectors/{0}/validate()", ExpressionConverter.ConvertWithUrlEncoding(createdDataConnectorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftschooldatas")]
        public IWorkflowAction CheckValidationResult(Expression<Func<string>> validationOperationUri, Expression<Func<string>> accessToken)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ValidationOperationUri"] = ExpressionConverter.Convert(validationOperationUri);
            callPayload.Headers["access-token"] = ExpressionConverter.Convert(accessToken);
            return new ApiConnectionAction(callPayload);
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