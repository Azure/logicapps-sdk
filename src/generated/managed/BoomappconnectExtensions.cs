//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boomappconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoomappconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<Sms1Response, ApiConnectionActionConfiguration> Sms1(Expression<Func<Sms1BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sms1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sms1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<Sms2Response, ApiConnectionActionConfiguration> Sms2(Expression<Func<Sms2BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sms2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sms2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<Sms3Response, ApiConnectionActionConfiguration> Sms3(Expression<Func<Sms1BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sms3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sms3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<VoiceResponse, ApiConnectionActionConfiguration> Voice(Expression<Func<VoiceBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<VoiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/voice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<EmailResponse, ApiConnectionActionConfiguration> Email(Expression<Func<EmailBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailResponse>(callPayload);
            });
        }
    }

    public class BoomappconnectTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GestresponsestriggerResponse, ApiConnectionPollingTriggerConfiguration> Gestresponsestrigger()
        {
            return new DeferredBodyTrigger<GestresponsestriggerResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_responses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["mark_as_read"] = Convert.ToString(true);
                return new ApiConnectionPollingTrigger<GestresponsestriggerResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetdrstriggerResponse, ApiConnectionPollingTriggerConfiguration> Getdrstrigger()
        {
            return new DeferredBodyTrigger<GetdrstriggerResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_all_new_drs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
                return new ApiConnectionPollingTrigger<GetdrstriggerResponse>(callPayload);
            });
        }
    }

    public class Sms1Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public Sms1ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class Sms1ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class Sms1BodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public BodyInputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class BodyInputRecipientAddressTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class Sms2Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public Sms2ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class Sms2ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class Sms2BodyInput
    {
        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public BodyInputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("validity_period")]
        public int? ValidityPeriod { get; set; }

        [JsonProperty("open_ticket")]
        public bool? OpenTicket { get; set; }

        [JsonProperty("email_responses")]
        public string EmailResponses { get; set; }

        [JsonProperty("push_responses")]
        public string PushResponses { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class Sms3Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public Sms3ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class Sms3ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class VoiceResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public VoiceResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class VoiceResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class VoiceBodyInput
    {
        [JsonProperty("voice_intro")]
        public string VoiceIntro { get; set; }

        [JsonProperty("voice_thank_you")]
        public string VoiceThankYou { get; set; }

        [JsonProperty("voice_redirect_message")]
        public string VoiceRedirectMessage { get; set; }

        [JsonProperty("voice_redirect_no")]
        public BodyInputVoiceRedirectNoType VoiceRedirectNo { get; set; }

        [JsonProperty("voice_retries")]
        public int? VoiceRetries { get; set; }

        [JsonProperty("voice_delay")]
        public int? VoiceDelay { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public BodyInputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class BodyInputVoiceRedirectNoType
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class EmailResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public EmailResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class EmailResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public class EmailBodyInput
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("email_subject")]
        public string EmailSubject { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("email_address")]
        public string[] EmailAddress { get; set; }

        [JsonProperty("validity_period")]
        public int? ValidityPeriod { get; set; }

        [JsonProperty("open_ticket")]
        public bool? OpenTicket { get; set; }

        [JsonProperty("email_responses")]
        public string EmailResponses { get; set; }

        [JsonProperty("push_responses")]
        public string PushResponses { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class GestresponsestriggerResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("replies")]
        public GestresponsestriggerResponseRepliesTypeItem[] Replies { get; set; }
    }

    public class GestresponsestriggerResponseRepliesTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }

        [JsonProperty("response_id")]
        public string ResponseId { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("response_content")]
        public string ResponseContent { get; set; }

        [JsonProperty("is_new")]
        public bool IsNew { get; set; }

        [JsonProperty("transaction_date")]
        public string TransactionDate { get; set; }

        [JsonProperty("response_date")]
        public string ResponseDate { get; set; }
    }

    public class GetdrstriggerResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("drs")]
        public GetdrstriggerResponseDrsTypeItem[] Drs { get; set; }
    }

    public class GetdrstriggerResponseDrsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_date")]
        public string StatusDate { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Boomappconnect;

    public partial class WorkflowManagedActions
    {
        public BoomappconnectActions Boomappconnect(string connectionId) => new BoomappconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BoomappconnectTriggers Boomappconnect(string connectionId) => new BoomappconnectTriggers(connectionId);
    }
}