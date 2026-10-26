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
        public IBodyWorkflowAction<SMS1Response, ApiConnectionActionConfiguration> SMS1(Expression<Func<SMS1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SMS1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SMS1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS2Response, ApiConnectionActionConfiguration> SMS2(Expression<Func<SMS2Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SMS2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SMS2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS3Response, ApiConnectionActionConfiguration> SMS3(Expression<Func<SMS3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SMS3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sms3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SMS3Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<VOICEResponse, ApiConnectionActionConfiguration> VOICE(Expression<Func<VOICEInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<VOICEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/voice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<VOICEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<EMAILResponse, ApiConnectionActionConfiguration> EMAIL(Expression<Func<EMAILInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EMAILResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EMAILResponse>(callPayload);
            });
        }
    }

    public class BoomappconnectTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GESTRESPONSESTRIGGERResponse, ApiConnectionTriggerConfiguration> GESTRESPONSESTRIGGER(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<GESTRESPONSESTRIGGERResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_responses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["mark_as_read"] = Convert.ToString(true);
                return new ApiConnectionTrigger<GESTRESPONSESTRIGGERResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GETDRSTRIGGERResponse, ApiConnectionTriggerConfiguration> GETDRSTRIGGER(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<GETDRSTRIGGERResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_all_new_drs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
                return new ApiConnectionTrigger<GETDRSTRIGGERResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SMS1Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public SMS1ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class SMS1ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class SMS1Input
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public SMS1InputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class SMS1InputRecipientAddressTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class SMS2Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public SMS2ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class SMS2ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class SMS2Input
    {
        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public SMS2InputRecipientAddressTypeItem[] RecipientAddress { get; set; }

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

    public class SMS2InputRecipientAddressTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class SMS3Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public SMS3ResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class SMS3ResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class SMS3Input
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public SMS3InputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class SMS3InputRecipientAddressTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class VOICEResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public VOICEResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class VOICEResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("telephone_number")]
        public string TelephoneNumber { get; set; }
    }

    public class VOICEInput
    {
        [JsonProperty("voice_intro")]
        public string VoiceIntro { get; set; }

        [JsonProperty("voice_thank_you")]
        public string VoiceThankYou { get; set; }

        [JsonProperty("voice_redirect_message")]
        public string VoiceRedirectMessage { get; set; }

        [JsonProperty("voice_redirect_no")]
        public VOICEInputVoiceRedirectNoType VoiceRedirectNo { get; set; }

        [JsonProperty("voice_retries")]
        public int? VoiceRetries { get; set; }

        [JsonProperty("voice_delay")]
        public int? VoiceDelay { get; set; }

        [JsonProperty("message_content")]
        public string MessageContent { get; set; }

        [JsonProperty("recipient_address")]
        public VOICEInputRecipientAddressTypeItem[] RecipientAddress { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("custom_parameter")]
        public string CustomParameter { get; set; }
    }

    public class VOICEInputVoiceRedirectNoType
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class VOICEInputRecipientAddressTypeItem
    {
        [JsonProperty("number")]
        public string Number { get; set; }
    }

    public class EMAILResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("transactions")]
        public EMAILResponseTransactionsTypeItem[] Transactions { get; set; }
    }

    public class EMAILResponseTransactionsTypeItem
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("parts_per_message")]
        public int PartsPerMessage { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public class EMAILInput
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

    public class GESTRESPONSESTRIGGERResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("replies")]
        public GESTRESPONSESTRIGGERResponseRepliesTypeItem[] Replies { get; set; }
    }

    public class GESTRESPONSESTRIGGERResponseRepliesTypeItem
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

    public class GETDRSTRIGGERResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("drs")]
        public GETDRSTRIGGERResponseDrsTypeItem[] Drs { get; set; }
    }

    public class GETDRSTRIGGERResponseDrsTypeItem
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