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
        public IBodyWorkflowAction<AcquireAccessTokenResponse> AcquireAccessToken([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> hostURL, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<string> clientId, [WorkflowExpression] Func<string> clientSecret)
        {
            SourceExpression.Validate(tenantName, nameof(tenantName), required: true);
            SourceExpression.Validate(hostURL, nameof(hostURL), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(password, nameof(password), required: true);
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            SourceExpression.Validate(clientSecret, nameof(clientSecret), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/connect/token", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tenantName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Headers["HostURL"] = SourceExpressionConverter.ConvertO(hostURL);
                return callPayload;
            }

            return new ApiConnectionAction<AcquireAccessTokenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string> PublishEvent([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> authorizationToken, [WorkflowExpression] Func<string> bodyeventDefinitionCode = null, [WorkflowExpression] Func<bool> bodyisTest = null, [WorkflowExpression] Func<bodyattributesInputItem[]> bodyattributes = null)
        {
            SourceExpression.Validate(tenantName, nameof(tenantName), required: true);
            SourceExpression.Validate(authorizationToken, nameof(authorizationToken), required: true);
            SourceExpression.Validate(bodyeventDefinitionCode, nameof(bodyeventDefinitionCode), required: false);
            SourceExpression.Validate(bodyisTest, nameof(bodyisTest), required: false);
            SourceExpression.Validate(bodyattributes, nameof(bodyattributes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cems/api/Events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = SourceExpressionConverter.ConvertO(tenantName);
                callPayload.Headers["AuthorizationToken"] = SourceExpressionConverter.ConvertO(authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventDefinitionCode != null)
                {
                    body["eventDefinitionCode"] = SourceExpressionConverter.ConvertToken(bodyeventDefinitionCode);
                    bodypropCount++;
                }

                if (bodyisTest != null)
                {
                    body["isTest"] = SourceExpressionConverter.ConvertToken(bodyisTest);
                    bodypropCount++;
                }

                if (bodyattributes != null)
                {
                    body["attributes"] = SourceExpressionConverter.ConvertToken(bodyattributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "inqubajourney")]
        public IBodyWorkflowAction<string> PublishTransaction([WorkflowExpression] Func<string> tenantName, [WorkflowExpression] Func<string> authorizationToken, [WorkflowExpression] Func<string> bodytransactionDefinitionCode = null, [WorkflowExpression] Func<bool> bodyisTest = null, [WorkflowExpression] Func<bodyattributesInputItem[]> bodyattributes = null)
        {
            SourceExpression.Validate(tenantName, nameof(tenantName), required: true);
            SourceExpression.Validate(authorizationToken, nameof(authorizationToken), required: true);
            SourceExpression.Validate(bodytransactionDefinitionCode, nameof(bodytransactionDefinitionCode), required: false);
            SourceExpression.Validate(bodyisTest, nameof(bodyisTest), required: false);
            SourceExpression.Validate(bodyattributes, nameof(bodyattributes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cems/api/Transactions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["TenantName"] = SourceExpressionConverter.ConvertO(tenantName);
                callPayload.Headers["AuthorizationToken"] = SourceExpressionConverter.ConvertO(authorizationToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytransactionDefinitionCode != null)
                {
                    body["transactionDefinitionCode"] = SourceExpressionConverter.ConvertToken(bodytransactionDefinitionCode);
                    bodypropCount++;
                }

                if (bodyisTest != null)
                {
                    body["isTest"] = SourceExpressionConverter.ConvertToken(bodyisTest);
                    bodypropCount++;
                }

                if (bodyattributes != null)
                {
                    body["attributes"] = SourceExpressionConverter.ConvertToken(bodyattributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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