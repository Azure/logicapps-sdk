//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loginllamaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoginllamaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loginllamaip")]
        public IBodyWorkflowAction<LoginPostResponse, ApiConnectionActionConfiguration> Login(Expression<Func<string>> bodyipAddress, Expression<Func<string>> bodyuserAgent, Expression<Func<string>> bodyidentityKey, Expression<Func<string>> bodygeoCountry = null, Expression<Func<string>> bodygeoCity = null, Expression<Func<string>> bodyuserTimeOfDay = null)
        {
            var __workflow_bodyipAddress = WorkflowExpression.Compile(bodyipAddress, nameof(bodyipAddress), required: true);
            var __workflow_bodyuserAgent = WorkflowExpression.Compile(bodyuserAgent, nameof(bodyuserAgent), required: true);
            var __workflow_bodyidentityKey = WorkflowExpression.Compile(bodyidentityKey, nameof(bodyidentityKey), required: true);
            var __workflow_bodygeoCountry = WorkflowExpression.Compile(bodygeoCountry, nameof(bodygeoCountry), required: false);
            var __workflow_bodygeoCity = WorkflowExpression.Compile(bodygeoCity, nameof(bodygeoCity), required: false);
            var __workflow_bodyuserTimeOfDay = WorkflowExpression.Compile(bodyuserTimeOfDay, nameof(bodyuserTimeOfDay), required: false);
            return new DeferredBodyAction<LoginPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/login/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ip_address"] = ExpressionConverter.ConvertO(__workflow_bodyipAddress);
                bodypropCount++;
                body["user_agent"] = ExpressionConverter.ConvertO(__workflow_bodyuserAgent);
                bodypropCount++;
                body["identity_key"] = ExpressionConverter.ConvertO(__workflow_bodyidentityKey);
                if (__workflow_bodygeoCountry != null)
                {
                    body["geo_country"] = ExpressionConverter.ConvertO(__workflow_bodygeoCountry);
                    bodypropCount++;
                }

                if (__workflow_bodygeoCity != null)
                {
                    body["geo_city"] = ExpressionConverter.ConvertO(__workflow_bodygeoCity);
                    bodypropCount++;
                }

                if (__workflow_bodyuserTimeOfDay != null)
                {
                    body["user_time_of_day"] = ExpressionConverter.ConvertO(__workflow_bodyuserTimeOfDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoginPostResponse>(callPayload);
            });
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
