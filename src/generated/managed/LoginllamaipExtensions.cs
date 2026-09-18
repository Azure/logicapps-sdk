//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loginllamaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoginllamaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loginllamaip")]
        public IBodyWorkflowAction<LoginPostResponse> Login([WorkflowExpression] Func<string> bodyipAddress, [WorkflowExpression] Func<string> bodyuserAgent, [WorkflowExpression] Func<string> bodyidentityKey, [WorkflowExpression] Func<string> bodygeoCountry = null, [WorkflowExpression] Func<string> bodygeoCity = null, [WorkflowExpression] Func<string> bodyuserTimeOfDay = null)
        {
            SourceExpression.Validate(bodyipAddress, nameof(bodyipAddress), required: true);
            SourceExpression.Validate(bodyuserAgent, nameof(bodyuserAgent), required: true);
            SourceExpression.Validate(bodyidentityKey, nameof(bodyidentityKey), required: true);
            SourceExpression.Validate(bodygeoCountry, nameof(bodygeoCountry), required: false);
            SourceExpression.Validate(bodygeoCity, nameof(bodygeoCity), required: false);
            SourceExpression.Validate(bodyuserTimeOfDay, nameof(bodyuserTimeOfDay), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/login/check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ip_address"] = SourceExpressionConverter.ConvertToken(bodyipAddress);
                bodypropCount++;
                body["user_agent"] = SourceExpressionConverter.ConvertToken(bodyuserAgent);
                bodypropCount++;
                body["identity_key"] = SourceExpressionConverter.ConvertToken(bodyidentityKey);
                if (bodygeoCountry != null)
                {
                    body["geo_country"] = SourceExpressionConverter.ConvertToken(bodygeoCountry);
                    bodypropCount++;
                }

                if (bodygeoCity != null)
                {
                    body["geo_city"] = SourceExpressionConverter.ConvertToken(bodygeoCity);
                    bodypropCount++;
                }

                if (bodyuserTimeOfDay != null)
                {
                    body["user_time_of_day"] = SourceExpressionConverter.ConvertToken(bodyuserTimeOfDay);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoginPostResponse>(BuildSourceInput);
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