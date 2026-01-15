//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Boomappconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoomappconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS1Response> SMS1(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var apiCallPath = "/sms1";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            if (bodymessageContent != null)
            {
                body["message_content"] = ExpressionConverter.ConvertO(bodymessageContent);
                bodypropCount++;
            }

            if (bodyrecipientAddress != null)
            {
                body["recipient_address"] = ExpressionConverter.ConvertO(bodyrecipientAddress);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyuniqueIdentifier != null)
            {
                body["unique_identifier"] = ExpressionConverter.ConvertO(bodyuniqueIdentifier);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodycustomParameter != null)
            {
                body["custom_parameter"] = ExpressionConverter.ConvertO(bodycustomParameter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS1Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS2Response> SMS2(Expression<Func<string>> bodyconversationId = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<int>> bodyvalidityPeriod = null, Expression<Func<bool>> bodyopenTicket = null, Expression<Func<string>> bodyemailResponses = null, Expression<Func<string>> bodypushResponses = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var apiCallPath = "/sms2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyconversationId != null)
            {
                body["conversation_id"] = ExpressionConverter.ConvertO(bodyconversationId);
                bodypropCount++;
            }

            if (bodymessageContent != null)
            {
                body["message_content"] = ExpressionConverter.ConvertO(bodymessageContent);
                bodypropCount++;
            }

            if (bodyrecipientAddress != null)
            {
                body["recipient_address"] = ExpressionConverter.ConvertO(bodyrecipientAddress);
                bodypropCount++;
            }

            if (bodyvalidityPeriod != null)
            {
                body["validity_period"] = ExpressionConverter.ConvertO(bodyvalidityPeriod);
                bodypropCount++;
            }

            if (bodyopenTicket != null)
            {
                body["open_ticket"] = ExpressionConverter.ConvertO(bodyopenTicket);
                bodypropCount++;
            }

            if (bodyemailResponses != null)
            {
                body["email_responses"] = ExpressionConverter.ConvertO(bodyemailResponses);
                bodypropCount++;
            }

            if (bodypushResponses != null)
            {
                body["push_responses"] = ExpressionConverter.ConvertO(bodypushResponses);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyuniqueIdentifier != null)
            {
                body["unique_identifier"] = ExpressionConverter.ConvertO(bodyuniqueIdentifier);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodycustomParameter != null)
            {
                body["custom_parameter"] = ExpressionConverter.ConvertO(bodycustomParameter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS3Response> SMS3(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var apiCallPath = "/sms3";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            if (bodymessageContent != null)
            {
                body["message_content"] = ExpressionConverter.ConvertO(bodymessageContent);
                bodypropCount++;
            }

            if (bodyrecipientAddress != null)
            {
                body["recipient_address"] = ExpressionConverter.ConvertO(bodyrecipientAddress);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyuniqueIdentifier != null)
            {
                body["unique_identifier"] = ExpressionConverter.ConvertO(bodyuniqueIdentifier);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodycustomParameter != null)
            {
                body["custom_parameter"] = ExpressionConverter.ConvertO(bodycustomParameter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SMS3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<VOICEResponse> VOICE(Expression<Func<string>> bodyvoiceIntro = null, Expression<Func<string>> bodyvoiceThankYou = null, Expression<Func<string>> bodyvoiceRedirectMessage = null, Expression<Func<string>> bodyvoiceRedirectNonumber = null, Expression<Func<int>> bodyvoiceRetries = null, Expression<Func<int>> bodyvoiceDelay = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var apiCallPath = "/voice";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvoiceIntro != null)
            {
                body["voice_intro"] = ExpressionConverter.ConvertO(bodyvoiceIntro);
                bodypropCount++;
            }

            if (bodyvoiceThankYou != null)
            {
                body["voice_thank_you"] = ExpressionConverter.ConvertO(bodyvoiceThankYou);
                bodypropCount++;
            }

            if (bodyvoiceRedirectMessage != null)
            {
                body["voice_redirect_message"] = ExpressionConverter.ConvertO(bodyvoiceRedirectMessage);
                bodypropCount++;
            }

            var voice_redirect_noObject = new JObject();
            var voice_redirect_noObjectpropCount = 0;
            if (bodyvoiceRedirectNonumber != null)
            {
                voice_redirect_noObject["number"] = ExpressionConverter.ConvertO(bodyvoiceRedirectNonumber);
                voice_redirect_noObjectpropCount++;
            }

            if (voice_redirect_noObjectpropCount > 0)
            {
                body["voice_redirect_no"] = voice_redirect_noObject;
                bodypropCount++;
            }

            if (bodyvoiceRetries != null)
            {
                body["voice_retries"] = ExpressionConverter.ConvertO(bodyvoiceRetries);
                bodypropCount++;
            }

            if (bodyvoiceDelay != null)
            {
                body["voice_delay"] = ExpressionConverter.ConvertO(bodyvoiceDelay);
                bodypropCount++;
            }

            if (bodymessageContent != null)
            {
                body["message_content"] = ExpressionConverter.ConvertO(bodymessageContent);
                bodypropCount++;
            }

            if (bodyrecipientAddress != null)
            {
                body["recipient_address"] = ExpressionConverter.ConvertO(bodyrecipientAddress);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyuniqueIdentifier != null)
            {
                body["unique_identifier"] = ExpressionConverter.ConvertO(bodyuniqueIdentifier);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodycustomParameter != null)
            {
                body["custom_parameter"] = ExpressionConverter.ConvertO(bodycustomParameter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<VOICEResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<EMAILResponse> EMAIL(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyemailSubject = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<string[]>> bodyemailAddress = null, Expression<Func<int>> bodyvalidityPeriod = null, Expression<Func<bool>> bodyopenTicket = null, Expression<Func<string>> bodyemailResponses = null, Expression<Func<string>> bodypushResponses = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var apiCallPath = "/email";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfrom != null)
            {
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
            }

            if (bodyemailSubject != null)
            {
                body["email_subject"] = ExpressionConverter.ConvertO(bodyemailSubject);
                bodypropCount++;
            }

            if (bodymessageContent != null)
            {
                body["message_content"] = ExpressionConverter.ConvertO(bodymessageContent);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["email_address"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyvalidityPeriod != null)
            {
                body["validity_period"] = ExpressionConverter.ConvertO(bodyvalidityPeriod);
                bodypropCount++;
            }

            if (bodyopenTicket != null)
            {
                body["open_ticket"] = ExpressionConverter.ConvertO(bodyopenTicket);
                bodypropCount++;
            }

            if (bodyemailResponses != null)
            {
                body["email_responses"] = ExpressionConverter.ConvertO(bodyemailResponses);
                bodypropCount++;
            }

            if (bodypushResponses != null)
            {
                body["push_responses"] = ExpressionConverter.ConvertO(bodypushResponses);
                bodypropCount++;
            }

            if (bodyuniqueIdentifier != null)
            {
                body["unique_identifier"] = ExpressionConverter.ConvertO(bodyuniqueIdentifier);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodycustomParameter != null)
            {
                body["custom_parameter"] = ExpressionConverter.ConvertO(bodycustomParameter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<EMAILResponse>(callPayload);
        }
    }

    public class BoomappconnectTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<GESTRESPONSESTRIGGERResponse> GESTRESPONSESTRIGGER()
        {
            var apiCallPath = "/get_responses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ignore_previous"] = Convert.ToString(true);
            callPayload.Queries["mark_as_read"] = Convert.ToString(true);
            return new ApiConnectionTrigger<GESTRESPONSESTRIGGERResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<GETDRSTRIGGERResponse> GETDRSTRIGGER()
        {
            var apiCallPath = "/get_all_new_drs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ignore_previous"] = Convert.ToString(true);
            callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
            return new ApiConnectionTrigger<GETDRSTRIGGERResponse>(callPayload);
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

    public class bodyrecipientAddressInputItem
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
    using Microsoft.Azure.Workflows.Sdk.Boomappconnect;

    public partial class WorkflowManagedActions
    {
        public BoomappconnectActions Boomappconnect(string connectionId) => new BoomappconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BoomappconnectTriggers Boomappconnect(string connectionId) => new BoomappconnectTriggers(connectionId);
    }
}