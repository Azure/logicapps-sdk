//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudskyaddins
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudskyaddinsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IBodyWorkflowAction<PowerAutomateUIApiValidateUserIdentityTokenResponse, ApiConnectionActionConfiguration> ValidateUserIdentityToken(Expression<Func<string>> bodyuserIdentityToken, Expression<Func<string>> bodyapplicationId)
        {
            var __workflow_bodyuserIdentityToken = WorkflowExpression.Compile(bodyuserIdentityToken, nameof(bodyuserIdentityToken), required: true);
            var __workflow_bodyapplicationId = WorkflowExpression.Compile(bodyapplicationId, nameof(bodyapplicationId), required: true);
            return new DeferredBodyAction<PowerAutomateUIApiValidateUserIdentityTokenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/powerautomateui/v1/useridentitytoken/validate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["uit"] = ExpressionConverter.ConvertO(__workflow_bodyuserIdentityToken);
                bodypropCount++;
                body["application_id"] = ExpressionConverter.ConvertO(__workflow_bodyapplicationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PowerAutomateUIApiValidateUserIdentityTokenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendHttpRequest(Expression<Func<bodymethodInput>> bodymethod, Expression<Func<string>> bodyrelativePath, Expression<Func<string>> bodybody = null)
        {
            var __workflow_bodymethod = WorkflowExpression.Compile(bodymethod, nameof(bodymethod), required: true);
            var __workflow_bodyrelativePath = WorkflowExpression.Compile(bodyrelativePath, nameof(bodyrelativePath), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/virtual/httprequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["method"] = ExpressionConverter.ConvertO(__workflow_bodymethod);
                bodypropCount++;
                body["path"] = ExpressionConverter.ConvertO(__workflow_bodyrelativePath);
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    body["headers"] = headersObject;
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudskyaddinsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PowerAutomateUIApiValidateUserIdentityTokenResponse
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("family_name")]
        public string LastName { get; set; }

        [JsonProperty("given_name")]
        public string FirstName { get; set; }

        [JsonProperty("application_id")]
        public string SKYApplicationId { get; set; }

        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodymethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudskyaddins;

    public partial class WorkflowManagedActions
    {
        public BlackbaudskyaddinsActions Blackbaudskyaddins(string connectionId) => new BlackbaudskyaddinsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudskyaddinsTriggers Blackbaudskyaddins(string connectionId) => new BlackbaudskyaddinsTriggers(connectionId);
    }
}