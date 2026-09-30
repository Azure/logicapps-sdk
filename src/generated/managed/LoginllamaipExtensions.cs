//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loginllamaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoginllamaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loginllamaip")]
        public IBodyWorkflowAction<LoginPostResponse> Login([WorkflowExpression] Func<string> bodyipAddress, [WorkflowExpression] Func<string> bodyuserAgent, [WorkflowExpression] Func<string> bodyidentityKey, [WorkflowExpression] Func<string> bodygeoCountry = null, [WorkflowExpression] Func<string> bodygeoCity = null, [WorkflowExpression] Func<string> bodyuserTimeOfDay = null)
        {
            var apiCallPath = "/login/check";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ip_address"] = ExpressionConverter.ConvertO(bodyipAddress);
            bodypropCount++;
            body["user_agent"] = ExpressionConverter.ConvertO(bodyuserAgent);
            bodypropCount++;
            body["identity_key"] = ExpressionConverter.ConvertO(bodyidentityKey);
            if (bodygeoCountry != null)
            {
                body["geo_country"] = ExpressionConverter.ConvertO(bodygeoCountry);
                bodypropCount++;
            }

            if (bodygeoCity != null)
            {
                body["geo_city"] = ExpressionConverter.ConvertO(bodygeoCity);
                bodypropCount++;
            }

            if (bodyuserTimeOfDay != null)
            {
                body["user_time_of_day"] = ExpressionConverter.ConvertO(bodyuserTimeOfDay);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LoginPostResponse>(callPayload);
        }
    }

    public class LoginllamaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class LoginPostResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("codes")]
        public string[] Codes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Loginllamaip;

    public partial class WorkflowManagedActions
    {
        public LoginllamaipActions Loginllamaip(string connectionId) => new LoginllamaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LoginllamaipTriggers Loginllamaip(string connectionId) => new LoginllamaipTriggers(connectionId);
    }
}