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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AcquireAccessTokenResponse> __BuildAcquireAccessToken(WorkflowValue<string> tenantName, WorkflowValue<string> hostURL, WorkflowValue<string> username, WorkflowValue<string> password, WorkflowValue<string> clientId, WorkflowValue<string> clientSecret)
        {
            WorkflowValue.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowValue.Validate(hostURL, nameof(hostURL), required: true);
            WorkflowValue.Validate(username, nameof(username), required: true);
            WorkflowValue.Validate(password, nameof(password), required: true);
            WorkflowValue.Validate(clientId, nameof(clientId), required: true);
            WorkflowValue.Validate(clientSecret, nameof(clientSecret), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPublishEvent(WorkflowValue<string> tenantName, WorkflowValue<string> authorizationToken, WorkflowValue<string> bodyeventDefinitionCode = null, WorkflowValue<bool> bodyisTest = null, WorkflowValue<bodyattributesInputItem[]> bodyattributes = null)
        {
            WorkflowValue.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowValue.Validate(authorizationToken, nameof(authorizationToken), required: true);
            WorkflowValue.Validate(bodyeventDefinitionCode, nameof(bodyeventDefinitionCode), required: false);
            WorkflowValue.Validate(bodyisTest, nameof(bodyisTest), required: false);
            WorkflowValue.Validate(bodyattributes, nameof(bodyattributes), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPublishTransaction(WorkflowValue<string> tenantName, WorkflowValue<string> authorizationToken, WorkflowValue<string> bodytransactionDefinitionCode = null, WorkflowValue<bool> bodyisTest = null, WorkflowValue<bodyattributesInputItem[]> bodyattributes = null)
        {
            WorkflowValue.Validate(tenantName, nameof(tenantName), required: true);
            WorkflowValue.Validate(authorizationToken, nameof(authorizationToken), required: true);
            WorkflowValue.Validate(bodytransactionDefinitionCode, nameof(bodytransactionDefinitionCode), required: false);
            WorkflowValue.Validate(bodyisTest, nameof(bodyisTest), required: false);
            WorkflowValue.Validate(bodyattributes, nameof(bodyattributes), required: false);
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
