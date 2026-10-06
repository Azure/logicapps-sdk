//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boomappconnect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoomappconnectActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [WorkflowExpressionFactory(nameof(__BuildSMS1))]
        public IBodyWorkflowAction<SMS1Response> SMS1([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMS1Response> __BuildSMS1(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodymessageContent = null, WorkflowExpression<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, WorkflowExpression<bool> bodypriority = null, WorkflowExpression<string> bodyuniqueIdentifier = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodycustomParameter = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodymessageContent, nameof(bodymessageContent), required: false);
            WorkflowExpression.Validate(bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS1Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [WorkflowExpressionFactory(nameof(__BuildSMS2))]
        public IBodyWorkflowAction<SMS2Response> SMS2([WorkflowExpression] Func<string> bodyconversationId = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<int> bodyvalidityPeriod = null, [WorkflowExpression] Func<bool> bodyopenTicket = null, [WorkflowExpression] Func<string> bodyemailResponses = null, [WorkflowExpression] Func<string> bodypushResponses = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMS2Response> __BuildSMS2(WorkflowExpression<string> bodyconversationId = null, WorkflowExpression<string> bodymessageContent = null, WorkflowExpression<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, WorkflowExpression<int> bodyvalidityPeriod = null, WorkflowExpression<bool> bodyopenTicket = null, WorkflowExpression<string> bodyemailResponses = null, WorkflowExpression<string> bodypushResponses = null, WorkflowExpression<bool> bodypriority = null, WorkflowExpression<string> bodyuniqueIdentifier = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodycustomParameter = null)
        {
            WorkflowExpression.Validate(bodyconversationId, nameof(bodyconversationId), required: false);
            WorkflowExpression.Validate(bodymessageContent, nameof(bodymessageContent), required: false);
            WorkflowExpression.Validate(bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            WorkflowExpression.Validate(bodyvalidityPeriod, nameof(bodyvalidityPeriod), required: false);
            WorkflowExpression.Validate(bodyopenTicket, nameof(bodyopenTicket), required: false);
            WorkflowExpression.Validate(bodyemailResponses, nameof(bodyemailResponses), required: false);
            WorkflowExpression.Validate(bodypushResponses, nameof(bodypushResponses), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS2Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [WorkflowExpressionFactory(nameof(__BuildSMS3))]
        public IBodyWorkflowAction<SMS3Response> SMS3([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMS3Response> __BuildSMS3(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodymessageContent = null, WorkflowExpression<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, WorkflowExpression<bool> bodypriority = null, WorkflowExpression<string> bodyuniqueIdentifier = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodycustomParameter = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodymessageContent, nameof(bodymessageContent), required: false);
            WorkflowExpression.Validate(bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS3Response>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [WorkflowExpressionFactory(nameof(__BuildVOICE))]
        public IBodyWorkflowAction<VOICEResponse> VOICE([WorkflowExpression] Func<string> bodyvoiceIntro = null, [WorkflowExpression] Func<string> bodyvoiceThankYou = null, [WorkflowExpression] Func<string> bodyvoiceRedirectMessage = null, [WorkflowExpression] Func<string> bodyvoiceRedirectNonumber = null, [WorkflowExpression] Func<int> bodyvoiceRetries = null, [WorkflowExpression] Func<int> bodyvoiceDelay = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, [WorkflowExpression] Func<bool> bodypriority = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VOICEResponse> __BuildVOICE(WorkflowExpression<string> bodyvoiceIntro = null, WorkflowExpression<string> bodyvoiceThankYou = null, WorkflowExpression<string> bodyvoiceRedirectMessage = null, WorkflowExpression<string> bodyvoiceRedirectNonumber = null, WorkflowExpression<int> bodyvoiceRetries = null, WorkflowExpression<int> bodyvoiceDelay = null, WorkflowExpression<string> bodymessageContent = null, WorkflowExpression<bodyrecipientAddressInputItem[]> bodyrecipientAddress = null, WorkflowExpression<bool> bodypriority = null, WorkflowExpression<string> bodyuniqueIdentifier = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodycustomParameter = null)
        {
            WorkflowExpression.Validate(bodyvoiceIntro, nameof(bodyvoiceIntro), required: false);
            WorkflowExpression.Validate(bodyvoiceThankYou, nameof(bodyvoiceThankYou), required: false);
            WorkflowExpression.Validate(bodyvoiceRedirectMessage, nameof(bodyvoiceRedirectMessage), required: false);
            WorkflowExpression.Validate(bodyvoiceRedirectNonumber, nameof(bodyvoiceRedirectNonumber), required: false);
            WorkflowExpression.Validate(bodyvoiceRetries, nameof(bodyvoiceRetries), required: false);
            WorkflowExpression.Validate(bodyvoiceDelay, nameof(bodyvoiceDelay), required: false);
            WorkflowExpression.Validate(bodymessageContent, nameof(bodymessageContent), required: false);
            WorkflowExpression.Validate(bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<VOICEResponse>(() =>
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

                var voiceRedirectNoObject = new JObject();
                var voiceRedirectNoObjectpropCount = 0;
                if (bodyvoiceRedirectNonumber != null)
                {
                    voiceRedirectNoObject["number"] = ExpressionConverter.ConvertO(bodyvoiceRedirectNonumber);
                    voiceRedirectNoObjectpropCount++;
                }

                if (voiceRedirectNoObjectpropCount > 0)
                {
                    body["voice_redirect_no"] = voiceRedirectNoObject;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [WorkflowExpressionFactory(nameof(__BuildEMAIL))]
        public IBodyWorkflowAction<EMAILResponse> EMAIL([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyemailSubject = null, [WorkflowExpression] Func<string> bodymessageContent = null, [WorkflowExpression] Func<string[]> bodyemailAddress = null, [WorkflowExpression] Func<int> bodyvalidityPeriod = null, [WorkflowExpression] Func<bool> bodyopenTicket = null, [WorkflowExpression] Func<string> bodyemailResponses = null, [WorkflowExpression] Func<string> bodypushResponses = null, [WorkflowExpression] Func<string> bodyuniqueIdentifier = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodycustomParameter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EMAILResponse> __BuildEMAIL(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyemailSubject = null, WorkflowExpression<string> bodymessageContent = null, WorkflowExpression<string[]> bodyemailAddress = null, WorkflowExpression<int> bodyvalidityPeriod = null, WorkflowExpression<bool> bodyopenTicket = null, WorkflowExpression<string> bodyemailResponses = null, WorkflowExpression<string> bodypushResponses = null, WorkflowExpression<string> bodyuniqueIdentifier = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodycustomParameter = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyemailSubject, nameof(bodyemailSubject), required: false);
            WorkflowExpression.Validate(bodymessageContent, nameof(bodymessageContent), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyvalidityPeriod, nameof(bodyvalidityPeriod), required: false);
            WorkflowExpression.Validate(bodyopenTicket, nameof(bodyopenTicket), required: false);
            WorkflowExpression.Validate(bodyemailResponses, nameof(bodyemailResponses), required: false);
            WorkflowExpression.Validate(bodypushResponses, nameof(bodypushResponses), required: false);
            WorkflowExpression.Validate(bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<EMAILResponse>(() =>
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
            });
        }
    }

    public class BoomappconnectTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GESTRESPONSESTRIGGERResponse> GESTRESPONSESTRIGGER(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/get_responses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ignore_previous"] = Convert.ToString(true);
            callPayload.Queries["mark_as_read"] = Convert.ToString(true);
            return new ApiConnectionTrigger<GESTRESPONSESTRIGGERResponse>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<GETDRSTRIGGERResponse> GETDRSTRIGGER(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/get_all_new_drs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ignore_previous"] = Convert.ToString(true);
            callPayload.Queries["drs_after"] = Convert.ToString("1990-01-01 00:00:00");
            return new ApiConnectionTrigger<GETDRSTRIGGERResponse>(callPayload, recurrence: recurrence);
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