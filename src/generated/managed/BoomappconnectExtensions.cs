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
        public IBodyWorkflowAction<VOICEResponse, ApiConnectionActionConfiguration> VOICE(Expression<Func<VOICEBodyInput>> body = null)
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
        public IBodyWorkflowAction<EMAILResponse, ApiConnectionActionConfiguration> EMAIL(Expression<Func<EMAILBodyInput>> body = null)
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
        public IBodyWorkflowTrigger<GESTRESPONSESTRIGGERResponse, ApiConnectionPollingTriggerConfiguration> GESTRESPONSESTRIGGER()
        {
            return new DeferredBodyTrigger<GESTRESPONSESTRIGGERResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_responses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["mark_as_read"] = Convert.ToString(true);
                return new ApiConnectionPollingTrigger<GESTRESPONSESTRIGGERResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GETDRSTRIGGERResponse, ApiConnectionPollingTriggerConfiguration> GETDRSTRIGGER()
        {
            return new DeferredBodyTrigger<GETDRSTRIGGERResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/get_all_new_drs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
                return new ApiConnectionPollingTrigger<GETDRSTRIGGERResponse>(callPayload);
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

    public class VOICEBodyInput
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

    public class EMAILBodyInput
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