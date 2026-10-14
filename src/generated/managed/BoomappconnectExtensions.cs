//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boomappconnect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class BoomappconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boomappconnect")]
        public IBodyWorkflowAction<SMS1Response> SMS1(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodymessageContent = bodymessageContent == null ? null : WorkflowExpression.Compile(bodymessageContent);
            WorkflowExpression.Validate(__workflow_bodymessageContent, nameof(bodymessageContent), required: false);
            var __workflow_bodyrecipientAddress = bodyrecipientAddress == null ? null : WorkflowExpression.Compile(bodyrecipientAddress);
            WorkflowExpression.Validate(__workflow_bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyuniqueIdentifier = bodyuniqueIdentifier == null ? null : WorkflowExpression.Compile(bodyuniqueIdentifier);
            WorkflowExpression.Validate(__workflow_bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            var __workflow_bodycampaignName = bodycampaignName == null ? null : WorkflowExpression.Compile(bodycampaignName);
            WorkflowExpression.Validate(__workflow_bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodycustomParameter = bodycustomParameter == null ? null : WorkflowExpression.Compile(bodycustomParameter);
            WorkflowExpression.Validate(__workflow_bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS1Response>(() =>
            {
                var apiCallPath = "/sms1";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodymessageContent != null)
                {
                    body["message_content"] = ExpressionConverter.ConvertO(__workflow_bodymessageContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientAddress != null)
                {
                    body["recipient_address"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientAddress);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = ExpressionConverter.ConvertO(__workflow_bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomParameter != null)
                {
                    body["custom_parameter"] = ExpressionConverter.ConvertO(__workflow_bodycustomParameter);
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
        public IBodyWorkflowAction<SMS2Response> SMS2(Expression<Func<string>> bodyconversationId = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<int>> bodyvalidityPeriod = null, Expression<Func<bool>> bodyopenTicket = null, Expression<Func<string>> bodyemailResponses = null, Expression<Func<string>> bodypushResponses = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var __workflow_bodyconversationId = bodyconversationId == null ? null : WorkflowExpression.Compile(bodyconversationId);
            WorkflowExpression.Validate(__workflow_bodyconversationId, nameof(bodyconversationId), required: false);
            var __workflow_bodymessageContent = bodymessageContent == null ? null : WorkflowExpression.Compile(bodymessageContent);
            WorkflowExpression.Validate(__workflow_bodymessageContent, nameof(bodymessageContent), required: false);
            var __workflow_bodyrecipientAddress = bodyrecipientAddress == null ? null : WorkflowExpression.Compile(bodyrecipientAddress);
            WorkflowExpression.Validate(__workflow_bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            var __workflow_bodyvalidityPeriod = bodyvalidityPeriod == null ? null : WorkflowExpression.Compile(bodyvalidityPeriod);
            WorkflowExpression.Validate(__workflow_bodyvalidityPeriod, nameof(bodyvalidityPeriod), required: false);
            var __workflow_bodyopenTicket = bodyopenTicket == null ? null : WorkflowExpression.Compile(bodyopenTicket);
            WorkflowExpression.Validate(__workflow_bodyopenTicket, nameof(bodyopenTicket), required: false);
            var __workflow_bodyemailResponses = bodyemailResponses == null ? null : WorkflowExpression.Compile(bodyemailResponses);
            WorkflowExpression.Validate(__workflow_bodyemailResponses, nameof(bodyemailResponses), required: false);
            var __workflow_bodypushResponses = bodypushResponses == null ? null : WorkflowExpression.Compile(bodypushResponses);
            WorkflowExpression.Validate(__workflow_bodypushResponses, nameof(bodypushResponses), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyuniqueIdentifier = bodyuniqueIdentifier == null ? null : WorkflowExpression.Compile(bodyuniqueIdentifier);
            WorkflowExpression.Validate(__workflow_bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            var __workflow_bodycampaignName = bodycampaignName == null ? null : WorkflowExpression.Compile(bodycampaignName);
            WorkflowExpression.Validate(__workflow_bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodycustomParameter = bodycustomParameter == null ? null : WorkflowExpression.Compile(bodycustomParameter);
            WorkflowExpression.Validate(__workflow_bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS2Response>(() =>
            {
                var apiCallPath = "/sms2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconversationId != null)
                {
                    body["conversation_id"] = ExpressionConverter.ConvertO(__workflow_bodyconversationId);
                    bodypropCount++;
                }

                if (__workflow_bodymessageContent != null)
                {
                    body["message_content"] = ExpressionConverter.ConvertO(__workflow_bodymessageContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientAddress != null)
                {
                    body["recipient_address"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidityPeriod != null)
                {
                    body["validity_period"] = ExpressionConverter.ConvertO(__workflow_bodyvalidityPeriod);
                    bodypropCount++;
                }

                if (__workflow_bodyopenTicket != null)
                {
                    body["open_ticket"] = ExpressionConverter.ConvertO(__workflow_bodyopenTicket);
                    bodypropCount++;
                }

                if (__workflow_bodyemailResponses != null)
                {
                    body["email_responses"] = ExpressionConverter.ConvertO(__workflow_bodyemailResponses);
                    bodypropCount++;
                }

                if (__workflow_bodypushResponses != null)
                {
                    body["push_responses"] = ExpressionConverter.ConvertO(__workflow_bodypushResponses);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = ExpressionConverter.ConvertO(__workflow_bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomParameter != null)
                {
                    body["custom_parameter"] = ExpressionConverter.ConvertO(__workflow_bodycustomParameter);
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
        public IBodyWorkflowAction<SMS3Response> SMS3(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodymessageContent = bodymessageContent == null ? null : WorkflowExpression.Compile(bodymessageContent);
            WorkflowExpression.Validate(__workflow_bodymessageContent, nameof(bodymessageContent), required: false);
            var __workflow_bodyrecipientAddress = bodyrecipientAddress == null ? null : WorkflowExpression.Compile(bodyrecipientAddress);
            WorkflowExpression.Validate(__workflow_bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyuniqueIdentifier = bodyuniqueIdentifier == null ? null : WorkflowExpression.Compile(bodyuniqueIdentifier);
            WorkflowExpression.Validate(__workflow_bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            var __workflow_bodycampaignName = bodycampaignName == null ? null : WorkflowExpression.Compile(bodycampaignName);
            WorkflowExpression.Validate(__workflow_bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodycustomParameter = bodycustomParameter == null ? null : WorkflowExpression.Compile(bodycustomParameter);
            WorkflowExpression.Validate(__workflow_bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<SMS3Response>(() =>
            {
                var apiCallPath = "/sms3";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodymessageContent != null)
                {
                    body["message_content"] = ExpressionConverter.ConvertO(__workflow_bodymessageContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientAddress != null)
                {
                    body["recipient_address"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientAddress);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = ExpressionConverter.ConvertO(__workflow_bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomParameter != null)
                {
                    body["custom_parameter"] = ExpressionConverter.ConvertO(__workflow_bodycustomParameter);
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
        public IBodyWorkflowAction<VOICEResponse> VOICE(Expression<Func<string>> bodyvoiceIntro = null, Expression<Func<string>> bodyvoiceThankYou = null, Expression<Func<string>> bodyvoiceRedirectMessage = null, Expression<Func<string>> bodyvoiceRedirectNonumber = null, Expression<Func<int>> bodyvoiceRetries = null, Expression<Func<int>> bodyvoiceDelay = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<bodyrecipientAddressInputItem[]>> bodyrecipientAddress = null, Expression<Func<bool>> bodypriority = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var __workflow_bodyvoiceIntro = bodyvoiceIntro == null ? null : WorkflowExpression.Compile(bodyvoiceIntro);
            WorkflowExpression.Validate(__workflow_bodyvoiceIntro, nameof(bodyvoiceIntro), required: false);
            var __workflow_bodyvoiceThankYou = bodyvoiceThankYou == null ? null : WorkflowExpression.Compile(bodyvoiceThankYou);
            WorkflowExpression.Validate(__workflow_bodyvoiceThankYou, nameof(bodyvoiceThankYou), required: false);
            var __workflow_bodyvoiceRedirectMessage = bodyvoiceRedirectMessage == null ? null : WorkflowExpression.Compile(bodyvoiceRedirectMessage);
            WorkflowExpression.Validate(__workflow_bodyvoiceRedirectMessage, nameof(bodyvoiceRedirectMessage), required: false);
            var __workflow_bodyvoiceRedirectNonumber = bodyvoiceRedirectNonumber == null ? null : WorkflowExpression.Compile(bodyvoiceRedirectNonumber);
            WorkflowExpression.Validate(__workflow_bodyvoiceRedirectNonumber, nameof(bodyvoiceRedirectNonumber), required: false);
            var __workflow_bodyvoiceRetries = bodyvoiceRetries == null ? null : WorkflowExpression.Compile(bodyvoiceRetries);
            WorkflowExpression.Validate(__workflow_bodyvoiceRetries, nameof(bodyvoiceRetries), required: false);
            var __workflow_bodyvoiceDelay = bodyvoiceDelay == null ? null : WorkflowExpression.Compile(bodyvoiceDelay);
            WorkflowExpression.Validate(__workflow_bodyvoiceDelay, nameof(bodyvoiceDelay), required: false);
            var __workflow_bodymessageContent = bodymessageContent == null ? null : WorkflowExpression.Compile(bodymessageContent);
            WorkflowExpression.Validate(__workflow_bodymessageContent, nameof(bodymessageContent), required: false);
            var __workflow_bodyrecipientAddress = bodyrecipientAddress == null ? null : WorkflowExpression.Compile(bodyrecipientAddress);
            WorkflowExpression.Validate(__workflow_bodyrecipientAddress, nameof(bodyrecipientAddress), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyuniqueIdentifier = bodyuniqueIdentifier == null ? null : WorkflowExpression.Compile(bodyuniqueIdentifier);
            WorkflowExpression.Validate(__workflow_bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            var __workflow_bodycampaignName = bodycampaignName == null ? null : WorkflowExpression.Compile(bodycampaignName);
            WorkflowExpression.Validate(__workflow_bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodycustomParameter = bodycustomParameter == null ? null : WorkflowExpression.Compile(bodycustomParameter);
            WorkflowExpression.Validate(__workflow_bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<VOICEResponse>(() =>
            {
                var apiCallPath = "/voice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyvoiceIntro != null)
                {
                    body["voice_intro"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceIntro);
                    bodypropCount++;
                }

                if (__workflow_bodyvoiceThankYou != null)
                {
                    body["voice_thank_you"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceThankYou);
                    bodypropCount++;
                }

                if (__workflow_bodyvoiceRedirectMessage != null)
                {
                    body["voice_redirect_message"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceRedirectMessage);
                    bodypropCount++;
                }

                var voiceRedirectNoObject = new JObject();
                var voiceRedirectNoObjectpropCount = 0;
                if (__workflow_bodyvoiceRedirectNonumber != null)
                {
                    voiceRedirectNoObject["number"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceRedirectNonumber);
                    voiceRedirectNoObjectpropCount++;
                }

                if (voiceRedirectNoObjectpropCount > 0)
                {
                    body["voice_redirect_no"] = voiceRedirectNoObject;
                    bodypropCount++;
                }

                if (__workflow_bodyvoiceRetries != null)
                {
                    body["voice_retries"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceRetries);
                    bodypropCount++;
                }

                if (__workflow_bodyvoiceDelay != null)
                {
                    body["voice_delay"] = ExpressionConverter.ConvertO(__workflow_bodyvoiceDelay);
                    bodypropCount++;
                }

                if (__workflow_bodymessageContent != null)
                {
                    body["message_content"] = ExpressionConverter.ConvertO(__workflow_bodymessageContent);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientAddress != null)
                {
                    body["recipient_address"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientAddress);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = ExpressionConverter.ConvertO(__workflow_bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomParameter != null)
                {
                    body["custom_parameter"] = ExpressionConverter.ConvertO(__workflow_bodycustomParameter);
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
        public IBodyWorkflowAction<EMAILResponse> EMAIL(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyemailSubject = null, Expression<Func<string>> bodymessageContent = null, Expression<Func<string[]>> bodyemailAddress = null, Expression<Func<int>> bodyvalidityPeriod = null, Expression<Func<bool>> bodyopenTicket = null, Expression<Func<string>> bodyemailResponses = null, Expression<Func<string>> bodypushResponses = null, Expression<Func<string>> bodyuniqueIdentifier = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodycustomParameter = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyemailSubject = bodyemailSubject == null ? null : WorkflowExpression.Compile(bodyemailSubject);
            WorkflowExpression.Validate(__workflow_bodyemailSubject, nameof(bodyemailSubject), required: false);
            var __workflow_bodymessageContent = bodymessageContent == null ? null : WorkflowExpression.Compile(bodymessageContent);
            WorkflowExpression.Validate(__workflow_bodymessageContent, nameof(bodymessageContent), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyvalidityPeriod = bodyvalidityPeriod == null ? null : WorkflowExpression.Compile(bodyvalidityPeriod);
            WorkflowExpression.Validate(__workflow_bodyvalidityPeriod, nameof(bodyvalidityPeriod), required: false);
            var __workflow_bodyopenTicket = bodyopenTicket == null ? null : WorkflowExpression.Compile(bodyopenTicket);
            WorkflowExpression.Validate(__workflow_bodyopenTicket, nameof(bodyopenTicket), required: false);
            var __workflow_bodyemailResponses = bodyemailResponses == null ? null : WorkflowExpression.Compile(bodyemailResponses);
            WorkflowExpression.Validate(__workflow_bodyemailResponses, nameof(bodyemailResponses), required: false);
            var __workflow_bodypushResponses = bodypushResponses == null ? null : WorkflowExpression.Compile(bodypushResponses);
            WorkflowExpression.Validate(__workflow_bodypushResponses, nameof(bodypushResponses), required: false);
            var __workflow_bodyuniqueIdentifier = bodyuniqueIdentifier == null ? null : WorkflowExpression.Compile(bodyuniqueIdentifier);
            WorkflowExpression.Validate(__workflow_bodyuniqueIdentifier, nameof(bodyuniqueIdentifier), required: false);
            var __workflow_bodycampaignName = bodycampaignName == null ? null : WorkflowExpression.Compile(bodycampaignName);
            WorkflowExpression.Validate(__workflow_bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodycustomParameter = bodycustomParameter == null ? null : WorkflowExpression.Compile(bodycustomParameter);
            WorkflowExpression.Validate(__workflow_bodycustomParameter, nameof(bodycustomParameter), required: false);
            return new DeferredBodyAction<EMAILResponse>(() =>
            {
                var apiCallPath = "/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyemailSubject != null)
                {
                    body["email_subject"] = ExpressionConverter.ConvertO(__workflow_bodyemailSubject);
                    bodypropCount++;
                }

                if (__workflow_bodymessageContent != null)
                {
                    body["message_content"] = ExpressionConverter.ConvertO(__workflow_bodymessageContent);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidityPeriod != null)
                {
                    body["validity_period"] = ExpressionConverter.ConvertO(__workflow_bodyvalidityPeriod);
                    bodypropCount++;
                }

                if (__workflow_bodyopenTicket != null)
                {
                    body["open_ticket"] = ExpressionConverter.ConvertO(__workflow_bodyopenTicket);
                    bodypropCount++;
                }

                if (__workflow_bodyemailResponses != null)
                {
                    body["email_responses"] = ExpressionConverter.ConvertO(__workflow_bodyemailResponses);
                    bodypropCount++;
                }

                if (__workflow_bodypushResponses != null)
                {
                    body["push_responses"] = ExpressionConverter.ConvertO(__workflow_bodypushResponses);
                    bodypropCount++;
                }

                if (__workflow_bodyuniqueIdentifier != null)
                {
                    body["unique_identifier"] = ExpressionConverter.ConvertO(__workflow_bodyuniqueIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomParameter != null)
                {
                    body["custom_parameter"] = ExpressionConverter.ConvertO(__workflow_bodycustomParameter);
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
