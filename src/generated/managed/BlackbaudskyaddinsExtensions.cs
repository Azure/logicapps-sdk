//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudskyaddins
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudskyaddinsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IBodyWorkflowAction<PowerAutomateUIApiValidateUserIdentityTokenResponse> ValidateUserIdentityToken([WorkflowExpression] Func<string> bodyuserIdentityToken, [WorkflowExpression] Func<string> bodyapplicationID)
        {
            var apiCallPath = "/powerautomateui/v1/useridentitytoken/validate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["uit"] = ExpressionConverter.ConvertO(bodyuserIdentityToken);
            bodypropCount++;
            body["application_id"] = ExpressionConverter.ConvertO(bodyapplicationID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PowerAutomateUIApiValidateUserIdentityTokenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudskyaddins")]
        public IWorkflowAction SendHttpRequest([WorkflowExpression] Func<bodymethodInput> bodymethod, [WorkflowExpression] Func<string> bodyrelativePath, [WorkflowExpression] Func<string> bodybody = null)
        {
            var apiCallPath = "/virtual/httprequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["method"] = ExpressionConverter.ConvertO(bodymethod);
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodyrelativePath);
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

            if (bodybody != null)
            {
                body["body"] = ExpressionConverter.ConvertO(bodybody);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudskyaddinsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PowerAutomateUIApiValidateUserIdentityTokenResponse
    {
        [JsonProperty("user_id")]
        public string UserID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("family_name")]
        public string LastName { get; set; }

        [JsonProperty("given_name")]
        public string FirstName { get; set; }

        [JsonProperty("application_id")]
        public string SKYApplicationID { get; set; }

        [JsonProperty("environment_id")]
        public string EnvironmentID { get; set; }
    }

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