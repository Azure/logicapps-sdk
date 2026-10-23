//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InqubajourneyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<AcquireAccessTokenResponse, ApiConnectionActionConfiguration> AcquireAccessToken(Expression<Func<string>> tenantName, Expression<Func<string>> hostURL, Expression<Func<string>> username, Expression<Func<string>> password, Expression<Func<string>> clientId, Expression<Func<string>> clientSecret)
        {
            var __workflow_tenantName = WorkflowExpression.Compile(tenantName, nameof(tenantName), required: true);
            var __workflow_hostURL = WorkflowExpression.Compile(hostURL, nameof(hostURL), required: true);
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: true);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            var __workflow_clientSecret = WorkflowExpression.Compile(clientSecret, nameof(clientSecret), required: true);
            return new DeferredBodyAction<AcquireAccessTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/connect/token", __workflow_tenantName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Headers["HostURL"] = ExpressionConverter.Convert(__workflow_hostURL);
                return new ApiConnectionAction<AcquireAccessTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PublishEvent(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<string>> bodyeventDefinitionCode = null, Expression<Func<bool>> bodyisTest = null, Expression<Func<bodyattributesInputItem[]>> bodyattributes = null)
        {
            var __workflow_tenantName = WorkflowExpression.Compile(tenantName, nameof(tenantName), required: true);
            var __workflow_authorizationToken = WorkflowExpression.Compile(authorizationToken, nameof(authorizationToken), required: true);
            var __workflow_bodyeventDefinitionCode = WorkflowExpression.Compile(bodyeventDefinitionCode, nameof(bodyeventDefinitionCode), required: false);
            var __workflow_bodyisTest = WorkflowExpression.Compile(bodyisTest, nameof(bodyisTest), required: false);
            var __workflow_bodyattributes = WorkflowExpression.Compile(bodyattributes, nameof(bodyattributes), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cems/api/Events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(__workflow_tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(__workflow_authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventDefinitionCode != null)
                {
                    body["eventDefinitionCode"] = ExpressionConverter.ConvertO(__workflow_bodyeventDefinitionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyisTest != null)
                {
                    body["isTest"] = ExpressionConverter.ConvertO(__workflow_bodyisTest);
                    bodypropCount++;
                }

                if (__workflow_bodyattributes != null)
                {
                    body["attributes"] = ExpressionConverter.ConvertO(__workflow_bodyattributes);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PublishTransaction(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<string>> bodytransactionDefinitionCode = null, Expression<Func<bool>> bodyisTest = null, Expression<Func<bodyattributesInputItem[]>> bodyattributes = null)
        {
            var __workflow_tenantName = WorkflowExpression.Compile(tenantName, nameof(tenantName), required: true);
            var __workflow_authorizationToken = WorkflowExpression.Compile(authorizationToken, nameof(authorizationToken), required: true);
            var __workflow_bodytransactionDefinitionCode = WorkflowExpression.Compile(bodytransactionDefinitionCode, nameof(bodytransactionDefinitionCode), required: false);
            var __workflow_bodyisTest = WorkflowExpression.Compile(bodyisTest, nameof(bodyisTest), required: false);
            var __workflow_bodyattributes = WorkflowExpression.Compile(bodyattributes, nameof(bodyattributes), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cems/api/Transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = ExpressionConverter.Convert(__workflow_tenantName);
                callPayload.Headers["AuthorizationToken"] = ExpressionConverter.Convert(__workflow_authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytransactionDefinitionCode != null)
                {
                    body["transactionDefinitionCode"] = ExpressionConverter.ConvertO(__workflow_bodytransactionDefinitionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyisTest != null)
                {
                    body["isTest"] = ExpressionConverter.ConvertO(__workflow_bodyisTest);
                    bodypropCount++;
                }

                if (__workflow_bodyattributes != null)
                {
                    body["attributes"] = ExpressionConverter.ConvertO(__workflow_bodyattributes);
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
