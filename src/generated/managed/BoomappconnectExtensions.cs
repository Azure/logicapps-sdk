//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boomappconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoomappconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS1Response> SMS1([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sms1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodymessageContent != null)
                {
                    body["message_content"] = SourceExpressionConverter.ConvertToken(bodymessageContent);
                    bodypropCount++;
                }

                if (bodyrecipientAddress != null)
                {
                    body["recipient_address"] = SourceExpressionConverter.ConvertToken(bodyrecipientAddress);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = SourceExpressionConverter.ConvertToken(bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodycustomParameter != null)
                {
                    body["custom_parameter"] = SourceExpressionConverter.ConvertToken(bodycustomParameter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SMS1Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS2Response> SMS2([WorkflowExpression] Func<string> bodyconversationId = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<int> bodyvalidityPeriod = null, [WorkflowExpression] Func<bool> bodyopenTicket = null, [WorkflowExpression] Func<string> bodyemailResponses = null, [WorkflowExpression] Func<string> bodypushResponses = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sms2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconversationId != null)
                {
                    body["conversation_id"] = SourceExpressionConverter.ConvertToken(bodyconversationId);
                    bodypropCount++;
                }

                if (bodymessageContent != null)
                {
                    body["message_content"] = SourceExpressionConverter.ConvertToken(bodymessageContent);
                    bodypropCount++;
                }

                if (bodyrecipientAddress != null)
                {
                    body["recipient_address"] = SourceExpressionConverter.ConvertToken(bodyrecipientAddress);
                    bodypropCount++;
                }

                if (bodyvalidityPeriod != null)
                {
                    body["validity_period"] = SourceExpressionConverter.ConvertToken(bodyvalidityPeriod);
                    bodypropCount++;
                }

                if (bodyopenTicket != null)
                {
                    body["open_ticket"] = SourceExpressionConverter.ConvertToken(bodyopenTicket);
                    bodypropCount++;
                }

                if (bodyemailResponses != null)
                {
                    body["email_responses"] = SourceExpressionConverter.ConvertToken(bodyemailResponses);
                    bodypropCount++;
                }

                if (bodypushResponses != null)
                {
                    body["push_responses"] = SourceExpressionConverter.ConvertToken(bodypushResponses);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = SourceExpressionConverter.ConvertToken(bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodycustomParameter != null)
                {
                    body["custom_parameter"] = SourceExpressionConverter.ConvertToken(bodycustomParameter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SMS2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS3Response> SMS3([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sms3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodymessageContent != null)
                {
                    body["message_content"] = SourceExpressionConverter.ConvertToken(bodymessageContent);
                    bodypropCount++;
                }

                if (bodyrecipientAddress != null)
                {
                    body["recipient_address"] = SourceExpressionConverter.ConvertToken(bodyrecipientAddress);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = SourceExpressionConverter.ConvertToken(bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodycustomParameter != null)
                {
                    body["custom_parameter"] = SourceExpressionConverter.ConvertToken(bodycustomParameter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SMS3Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<VOICEResponse> VOICE([WorkflowExpression] Func<string> bodyvoiceIntro = null, [WorkflowExpression] Func<string> bodyvoiceThankYou = null, [WorkflowExpression] Func<string> bodyvoiceRedirectMessage = null, [WorkflowExpression] Func<string> bodyvoiceRedirectNonumber = null, [WorkflowExpression] Func<int> bodyvoiceRetries = null, [WorkflowExpression] Func<int> bodyvoiceDelay = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/voice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvoiceIntro != null)
                {
                    body["voice_intro"] = SourceExpressionConverter.ConvertToken(bodyvoiceIntro);
                    bodypropCount++;
                }

                if (bodyvoiceThankYou != null)
                {
                    body["voice_thank_you"] = SourceExpressionConverter.ConvertToken(bodyvoiceThankYou);
                    bodypropCount++;
                }

                if (bodyvoiceRedirectMessage != null)
                {
                    body["voice_redirect_message"] = SourceExpressionConverter.ConvertToken(bodyvoiceRedirectMessage);
                    bodypropCount++;
                }

                var voiceRedirectNoObject = new JObject();
                var voiceRedirectNoObjectpropCount = 0;
                if (bodyvoiceRedirectNonumber != null)
                {
                    voiceRedirectNoObject["number"] = SourceExpressionConverter.ConvertToken(bodyvoiceRedirectNonumber);
                    voiceRedirectNoObjectpropCount++;
                }

                if (voiceRedirectNoObjectpropCount > 0)
                {
                    body["voice_redirect_no"] = voiceRedirectNoObject;
                    bodypropCount++;
                }

                if (bodyvoiceRetries != null)
                {
                    body["voice_retries"] = SourceExpressionConverter.ConvertToken(bodyvoiceRetries);
                    bodypropCount++;
                }

                if (bodyvoiceDelay != null)
                {
                    body["voice_delay"] = SourceExpressionConverter.ConvertToken(bodyvoiceDelay);
                    bodypropCount++;
                }

                if (bodymessageContent != null)
                {
                    body["message_content"] = SourceExpressionConverter.ConvertToken(bodymessageContent);
                    bodypropCount++;
                }

                if (bodyrecipientAddress != null)
                {
                    body["recipient_address"] = SourceExpressionConverter.ConvertToken(bodyrecipientAddress);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = SourceExpressionConverter.ConvertToken(bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodycustomParameter != null)
                {
                    body["custom_parameter"] = SourceExpressionConverter.ConvertToken(bodycustomParameter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VOICEResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<EMAILResponse> EMAIL([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyemailSubject = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<string[]> bodyemailAddress = null, [WorkflowExpression] Func<int> bodyvalidityPeriod = null, [WorkflowExpression] Func<bool> bodyopenTicket = null, [WorkflowExpression] Func<string> bodyemailResponses = null, [WorkflowExpression] Func<string> bodypushResponses = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyemailSubject != null)
                {
                    body["email_subject"] = SourceExpressionConverter.ConvertToken(bodyemailSubject);
                    bodypropCount++;
                }

                if (bodymessageContent != null)
                {
                    body["message_content"] = SourceExpressionConverter.ConvertToken(bodymessageContent);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyvalidityPeriod != null)
                {
                    body["validity_period"] = SourceExpressionConverter.ConvertToken(bodyvalidityPeriod);
                    bodypropCount++;
                }

                if (bodyopenTicket != null)
                {
                    body["open_ticket"] = SourceExpressionConverter.ConvertToken(bodyopenTicket);
                    bodypropCount++;
                }

                if (bodyemailResponses != null)
                {
                    body["email_responses"] = SourceExpressionConverter.ConvertToken(bodyemailResponses);
                    bodypropCount++;
                }

                if (bodypushResponses != null)
                {
                    body["push_responses"] = SourceExpressionConverter.ConvertToken(bodypushResponses);
                    bodypropCount++;
                }

                if (bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = SourceExpressionConverter.ConvertToken(bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodycustomParameter != null)
                {
                    body["custom_parameter"] = SourceExpressionConverter.ConvertToken(bodycustomParameter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EMAILResponse>(BuildSourceInput);
        }
    }

    public class BoomappconnectTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GESTRESPONSESTRIGGERResponse> GESTRESPONSESTRIGGER(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get_responses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["mark_as_read"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<GESTRESPONSESTRIGGERResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GETDRSTRIGGERResponse> GETDRSTRIGGER(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/get_all_new_drs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ignore_previous"] = Convert.ToString(true);
                callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
                return callPayload;
            }

            return new ApiConnectionTrigger<GETDRSTRIGGERResponse>(BuildSourceInput, triggerName, recurrence);
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