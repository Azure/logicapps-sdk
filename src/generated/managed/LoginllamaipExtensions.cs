//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loginllamaip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LoginllamaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loginllamaip")]
        public IBodyWorkflowAction<LoginPostResponse> Login(Expression<Func<string>> bodyipAddress, Expression<Func<string>> bodyuserAgent, Expression<Func<string>> bodyidentityKey, Expression<Func<string>> bodygeoCountry = null, Expression<Func<string>> bodygeoCity = null, Expression<Func<string>> bodyuserTimeOfDay = null)
        {
            var __workflow_bodyipAddress = bodyipAddress == null ? null : WorkflowExpression.Compile(bodyipAddress);
            WorkflowExpression.Validate(__workflow_bodyipAddress, nameof(bodyipAddress), required: true);
            var __workflow_bodyuserAgent = bodyuserAgent == null ? null : WorkflowExpression.Compile(bodyuserAgent);
            WorkflowExpression.Validate(__workflow_bodyuserAgent, nameof(bodyuserAgent), required: true);
            var __workflow_bodyidentityKey = bodyidentityKey == null ? null : WorkflowExpression.Compile(bodyidentityKey);
            WorkflowExpression.Validate(__workflow_bodyidentityKey, nameof(bodyidentityKey), required: true);
            var __workflow_bodygeoCountry = bodygeoCountry == null ? null : WorkflowExpression.Compile(bodygeoCountry);
            WorkflowExpression.Validate(__workflow_bodygeoCountry, nameof(bodygeoCountry), required: false);
            var __workflow_bodygeoCity = bodygeoCity == null ? null : WorkflowExpression.Compile(bodygeoCity);
            WorkflowExpression.Validate(__workflow_bodygeoCity, nameof(bodygeoCity), required: false);
            var __workflow_bodyuserTimeOfDay = bodyuserTimeOfDay == null ? null : WorkflowExpression.Compile(bodyuserTimeOfDay);
            WorkflowExpression.Validate(__workflow_bodyuserTimeOfDay, nameof(bodyuserTimeOfDay), required: false);
            return new DeferredBodyAction<LoginPostResponse>(() =>
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
