//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Touchsmsv2documentat
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Touchsmsv2documentatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "touchsmsv2documentat")]
        public IBodyWorkflowAction<GetAccountResponse> GetAccount()
        {
            var apiCallPath = "/v2/account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "touchsmsv2documentat")]
        [WorkflowExpressionFactory(nameof(__BuildSendMessage))]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> messageto = null, [WorkflowExpression] Func<string> messagefrom = null, [WorkflowExpression] Func<string> messagebody = null, [WorkflowExpression] Func<string> messagecampaign = null, [WorkflowExpression] Func<string> messagereference = null, [WorkflowExpression] Func<string> messagedate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendMessageResponse> __BuildSendMessage(WorkflowExpression<string> messageto = null, WorkflowExpression<string> messagefrom = null, WorkflowExpression<string> messagebody = null, WorkflowExpression<string> messagecampaign = null, WorkflowExpression<string> messagereference = null, WorkflowExpression<string> messagedate = null)
        {
            WorkflowExpression.Validate(messageto, nameof(messageto), required: false);
            WorkflowExpression.Validate(messagefrom, nameof(messagefrom), required: false);
            WorkflowExpression.Validate(messagebody, nameof(messagebody), required: false);
            WorkflowExpression.Validate(messagecampaign, nameof(messagecampaign), required: false);
            WorkflowExpression.Validate(messagereference, nameof(messagereference), required: false);
            WorkflowExpression.Validate(messagedate, nameof(messagedate), required: false);
            return new DeferredBodyAction<SendMessageResponse>(() =>
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
            });
        }
    }

    public class Touchsmsv2documentatTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildInboundMessage))]
        public IWorkflowTrigger InboundMessage([WorkflowExpression] Func<string> configdedicatedNumber = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInboundMessage(WorkflowExpression<string> configdedicatedNumber = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(configdedicatedNumber, nameof(configdedicatedNumber), required: false);
            return new DeferredWorkflowTrigger(() =>
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Touchsmsv2documentat;

    public partial class WorkflowManagedActions
    {
        public Touchsmsv2documentatActions Touchsmsv2documentat(string connectionId) => new Touchsmsv2documentatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Touchsmsv2documentatTriggers Touchsmsv2documentat(string connectionId) => new Touchsmsv2documentatTriggers(connectionId);
    }
}