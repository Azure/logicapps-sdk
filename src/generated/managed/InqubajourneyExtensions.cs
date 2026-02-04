//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Inqubajourney
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InqubajourneyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<AcquireAccessTokenResponse> AcquireAccessToken(Expression<Func<string>> tenantName, Expression<Func<string>> hostURL, Expression<Func<string>> username, Expression<Func<string>> password, Expression<Func<string>> clientId, Expression<Func<string>> clientSecret)
        {
            var apiCallPath = String.Format("/{0}/connect/token", ExpressionConverter.ConvertWithUrlEncoding(tenantName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
            callPayload.Headers["HostURL"] = ExpressionConverter.Convert(hostURL);
            return new ApiConnectionAction<AcquireAccessTokenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string> PublishEvent(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<string>> bodyeventDefinitionCode = null, Expression<Func<bool>> bodyisTest = null, Expression<Func<bodyattributesInputItem[]>> bodyattributes = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string> PublishTransaction(Expression<Func<string>> tenantName, Expression<Func<string>> authorizationToken, Expression<Func<string>> bodytransactionDefinitionCode = null, Expression<Func<bool>> bodyisTest = null, Expression<Func<bodyattributesInputItem[]>> bodyattributes = null)
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