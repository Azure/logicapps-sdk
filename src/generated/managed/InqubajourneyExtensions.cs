//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InqubajourneyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        [WorkflowExpressionFactory(nameof(__BuildAcquireAccessToken))]
        public IBodyWorkflowAction<AcquireAccessTokenResponse> AcquireAccessToken([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> hostURL, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<string> clientSecret)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AcquireAccessTokenResponse> __BuildAcquireAccessToken(WorkflowExpression<string> tenantName, WorkflowExpression<string> hostURL, WorkflowExpression<string> username, WorkflowExpression<string> password, WorkflowExpression<string> clientId, WorkflowExpression<string> clientSecret)
        {
            WorkflowExpression.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowExpression.Validate(hostURL, nameof(hostURL), required: true);
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(password, nameof(password), required: true);
            WorkflowExpression.Validate(clientId, nameof(clientId), required: true);
            WorkflowExpression.Validate(clientSecret, nameof(clientSecret), required: true);
            return new DeferredBodyAction<AcquireAccessTokenResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/connect/token", ExpressionConverter.ConvertWithUrlEncoding(tenantName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Headers["HostURL"] = ExpressionConverter.Convert(hostURL);
                return new ApiConnectionAction<AcquireAccessTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        [WorkflowExpressionFactory(nameof(__BuildPublishEvent))]
        public IBodyWorkflowAction<string> PublishEvent([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> authorizationToken, [WorkflowExpression] Func<string> bodyeventDefinitionCode = null, [WorkflowExpression] Func<bool> bodyisTest = null, [WorkflowExpression] Func<bodyattributesInputItem[]> bodyattributes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPublishEvent(WorkflowExpression<string> tenantName, WorkflowExpression<string> authorizationToken, WorkflowExpression<string> bodyeventDefinitionCode = null, WorkflowExpression<bool> bodyisTest = null, WorkflowExpression<bodyattributesInputItem[]> bodyattributes = null)
        {
            WorkflowExpression.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowExpression.Validate(authorizationToken, nameof(authorizationToken), required: true);
            WorkflowExpression.Validate(bodyeventDefinitionCode, nameof(bodyeventDefinitionCode), required: false);
            WorkflowExpression.Validate(bodyisTest, nameof(bodyisTest), required: false);
            WorkflowExpression.Validate(bodyattributes, nameof(bodyattributes), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/cems/api/Events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventDefinitionCode != null)
                {
                    body["eventDefinitionCode"] = ExpressionConverter.ConvertO(bodyeventDefinitionCode);
                    bodypropCount++;
                }

                if (bodyisTest != null)
                {
                    body["isTest"] = ExpressionConverter.ConvertO(bodyisTest);
                    bodypropCount++;
                }

                if (bodyattributes != null)
                {
                    body["attributes"] = ExpressionConverter.ConvertO(bodyattributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        [WorkflowExpressionFactory(nameof(__BuildPublishTransaction))]
        public IBodyWorkflowAction<string> PublishTransaction([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> authorizationToken, [WorkflowExpression] Func<string> bodytransactionDefinitionCode = null, [WorkflowExpression] Func<bool> bodyisTest = null, [WorkflowExpression] Func<bodyattributesInputItem[]> bodyattributes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPublishTransaction(WorkflowExpression<string> tenantName, WorkflowExpression<string> authorizationToken, WorkflowExpression<string> bodytransactionDefinitionCode = null, WorkflowExpression<bool> bodyisTest = null, WorkflowExpression<bodyattributesInputItem[]> bodyattributes = null)
        {
            WorkflowExpression.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowExpression.Validate(authorizationToken, nameof(authorizationToken), required: true);
            WorkflowExpression.Validate(bodytransactionDefinitionCode, nameof(bodytransactionDefinitionCode), required: false);
            WorkflowExpression.Validate(bodyisTest, nameof(bodyisTest), required: false);
            WorkflowExpression.Validate(bodyattributes, nameof(bodyattributes), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/cems/api/Transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytransactionDefinitionCode != null)
                {
                    body["transactionDefinitionCode"] = ExpressionConverter.ConvertO(bodytransactionDefinitionCode);
                    bodypropCount++;
                }

                if (bodyisTest != null)
                {
                    body["isTest"] = ExpressionConverter.ConvertO(bodyisTest);
                    bodypropCount++;
                }

                if (bodyattributes != null)
                {
                    body["attributes"] = ExpressionConverter.ConvertO(bodyattributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class InqubajourneyTriggers([ConnectionName] string connectionId)
    {
    }

    public class AcquireAccessTokenResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class bodyattributesInputItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney;

    public partial class WorkflowManagedActions
    {
        public InqubajourneyActions Inqubajourney(string connectionId) => new InqubajourneyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InqubajourneyTriggers Inqubajourney(string connectionId) => new InqubajourneyTriggers(connectionId);
    }
}