//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edgility
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdgilityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<GetAccountResponse> GetAccount()
        {
            var apiCallPath = "/v2/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage(Expression<Func<string>> messageto = null, Expression<Func<string>> messagefrom = null, Expression<Func<string>> messagebody = null, Expression<Func<string>> messagecampaign = null, Expression<Func<string>> messagereference = null, Expression<Func<string>> messagedate = null)
        {
            var apiCallPath = "/v2/integrations/power-automate/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var message = new JObject();
            var messagepropCount = 0;
            if (messageto != null)
            {
                message["to"] = ExpressionConverter.ConvertO(messageto);
                messagepropCount++;
            }

            if (messagefrom != null)
            {
                message["from"] = ExpressionConverter.ConvertO(messagefrom);
                messagepropCount++;
            }

            if (messagebody != null)
            {
                message["body"] = ExpressionConverter.ConvertO(messagebody);
                messagepropCount++;
            }

            if (messagecampaign != null)
            {
                message["campaign"] = ExpressionConverter.ConvertO(messagecampaign);
                messagepropCount++;
            }

            if (messagereference != null)
            {
                message["reference"] = ExpressionConverter.ConvertO(messagereference);
                messagepropCount++;
            }

            if (messagedate != null)
            {
                message["date"] = ExpressionConverter.ConvertO(messagedate);
                messagepropCount++;
            }

            if (messagepropCount > 0)
            {
                callPayload.Body = message;
            }

            return new ApiConnectionAction<SendMessageResponse>(callPayload);
        }
    }

    public class EdgilityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InboundMessage(Expression<Func<string>> configdedicatedNumber = null, string triggerName = null)
        {
            var apiCallPath = "/v2/integrations/power-automate/subscribe";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var config = new JObject();
            var configpropCount = 0;
            config["event"] = "message_received";
            configpropCount++;
            if (configdedicatedNumber != null)
            {
                config["dedicated_number"] = ExpressionConverter.ConvertO(configdedicatedNumber);
                configpropCount++;
            }

            config["destination_url"] = "@listcallbackurl()";
            configpropCount++;
            if (configpropCount > 0)
            {
                callPayload.Body = config;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class GetAccountResponse
    {
        [JsonProperty("data")]
        public AccountInformation Data { get; set; }
    }

    public class AccountInformation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("credits")]
        public double Credits { get; set; }

        [JsonProperty("settings")]
        public JToken Settings { get; set; }
    }

    public class SendMessageResponse
    {
        [JsonProperty("success_count")]
        public int SuccessCount { get; set; }

        [JsonProperty("failed_count")]
        public int FailedCount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Edgility;

    public partial class WorkflowManagedActions
    {
        public EdgilityActions Edgility(string connectionId) => new EdgilityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EdgilityTriggers Edgility(string connectionId) => new EdgilityTriggers(connectionId);
    }
}