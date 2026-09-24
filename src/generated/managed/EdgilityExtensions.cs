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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edgility")]
        public IBodyWorkflowAction<SendMessageResponse> SendMessage([WorkflowExpression] Func<string> messageto = null, [WorkflowExpression] Func<string> messagefrom = null, [WorkflowExpression] Func<string> messagebody = null, [WorkflowExpression] Func<string> messagecampaign = null, [WorkflowExpression] Func<string> messagereference = null, [WorkflowExpression] Func<string> messagedate = null)
        {
            SourceExpression.Validate(messageto, nameof(messageto), required: false);
            SourceExpression.Validate(messagefrom, nameof(messagefrom), required: false);
            SourceExpression.Validate(messagebody, nameof(messagebody), required: false);
            SourceExpression.Validate(messagecampaign, nameof(messagecampaign), required: false);
            SourceExpression.Validate(messagereference, nameof(messagereference), required: false);
            SourceExpression.Validate(messagedate, nameof(messagedate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/integrations/power-automate/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var message = new JObject();
                var messagepropCount = 0;
                if (messageto != null)
                {
                    message["to"] = SourceExpressionConverter.ConvertToken(messageto);
                    messagepropCount++;
                }

                if (messagefrom != null)
                {
                    message["from"] = SourceExpressionConverter.ConvertToken(messagefrom);
                    messagepropCount++;
                }

                if (messagebody != null)
                {
                    message["body"] = SourceExpressionConverter.ConvertToken(messagebody);
                    messagepropCount++;
                }

                if (messagecampaign != null)
                {
                    message["campaign"] = SourceExpressionConverter.ConvertToken(messagecampaign);
                    messagepropCount++;
                }

                if (messagereference != null)
                {
                    message["reference"] = SourceExpressionConverter.ConvertToken(messagereference);
                    messagepropCount++;
                }

                if (messagedate != null)
                {
                    message["date"] = SourceExpressionConverter.ConvertToken(messagedate);
                    messagepropCount++;
                }

                if (messagepropCount > 0)
                {
                    callPayload.Body = message;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendMessageResponse>(BuildSourceInput);
        }
    }

    public class EdgilityTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InboundMessage([WorkflowExpression] Func<string> configdedicatedNumber = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(configdedicatedNumber, nameof(configdedicatedNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    config["dedicated_number"] = SourceExpressionConverter.ConvertToken(configdedicatedNumber);
                    configpropCount++;
                }

                config["destination_url"] = "#{listCallbackUrl()}";
                configpropCount++;
                if (configpropCount > 0)
                {
                    callPayload.Body = config;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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