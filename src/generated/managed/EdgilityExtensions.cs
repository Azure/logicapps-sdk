//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edgility
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdgilityActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<GetAccountResponse, ApiConnectionActionConfiguration> GetAccount()
        {
            return new DeferredBodyAction<GetAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<SendMessageResponse, ApiConnectionActionConfiguration> SendMessage(Expression<Func<string>> messageto = null, Expression<Func<string>> messagefrom = null, Expression<Func<string>> messagebody = null, Expression<Func<string>> messagecampaign = null, Expression<Func<string>> messagereference = null, Expression<Func<string>> messagedate = null)
        {
            var __workflow_messageto = WorkflowExpression.Compile(messageto, nameof(messageto), required: false);
            var __workflow_messagefrom = WorkflowExpression.Compile(messagefrom, nameof(messagefrom), required: false);
            var __workflow_messagebody = WorkflowExpression.Compile(messagebody, nameof(messagebody), required: false);
            var __workflow_messagecampaign = WorkflowExpression.Compile(messagecampaign, nameof(messagecampaign), required: false);
            var __workflow_messagereference = WorkflowExpression.Compile(messagereference, nameof(messagereference), required: false);
            var __workflow_messagedate = WorkflowExpression.Compile(messagedate, nameof(messagedate), required: false);
            return new DeferredBodyAction<SendMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/integrations/power-automate/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                if (__workflow_messageto != null)
                {
                    message["to"] = ExpressionConverter.ConvertO(__workflow_messageto);
                    messagepropCount++;
                }

                if (__workflow_messagefrom != null)
                {
                    message["from"] = ExpressionConverter.ConvertO(__workflow_messagefrom);
                    messagepropCount++;
                }

                if (__workflow_messagebody != null)
                {
                    message["body"] = ExpressionConverter.ConvertO(__workflow_messagebody);
                    messagepropCount++;
                }

                if (__workflow_messagecampaign != null)
                {
                    message["campaign"] = ExpressionConverter.ConvertO(__workflow_messagecampaign);
                    messagepropCount++;
                }

                if (__workflow_messagereference != null)
                {
                    message["reference"] = ExpressionConverter.ConvertO(__workflow_messagereference);
                    messagepropCount++;
                }

                if (__workflow_messagedate != null)
                {
                    message["date"] = ExpressionConverter.ConvertO(__workflow_messagedate);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }

                return new ApiConnectionAction<SendMessageResponse>(callPayload);
            });
        }
    }

    public class EdgilityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> InboundMessage(Expression<Func<string>> configdedicatedNumber = null, FlowRecurrence recurrence = null)
        {
            var __workflow_configdedicatedNumber = WorkflowExpression.Compile(configdedicatedNumber, nameof(configdedicatedNumber), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
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
                if (__workflow_configdedicatedNumber != null)
                {
                    config["dedicated_number"] = ExpressionConverter.ConvertO(__workflow_configdedicatedNumber);
                    configpropCount++;
                }

                config["destination_url"] = "#{listCallbackUrl()}";
                configpropCount++;
                if (configpropCount > 0)
                {
                    callPayload.Body = config;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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