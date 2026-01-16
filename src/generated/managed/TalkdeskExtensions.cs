//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Talkdesk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TalkdeskActions([ConnectionName] string connectionId)
    {
    }

    public class TalkdeskTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ContactCreated(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/contactCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "@listcallbackurl()";
            bodypropCount++;
            body["title"] = "When a contact is created";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"contact_name\",\"contact_email\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"contact_id\":{\"title\":\"Contact ID\",\"type\":\"string\",\"default\":\"{{contact_id}}\"},\"account_id\":{\"title\":\"Account ID\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ContactUpdated(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/contactUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"contact_name\",\"contact_email\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"contact_id\":{\"title\":\"Contact ID\",\"type\":\"string\",\"default\":\"{{contact_id}}\"},\"account_id\":{\"title\":\"Account ID\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When a contact is updated";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger NoteCreated(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/noteCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"contact_name\",\"contact_email\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"contact_id\":{\"title\":\"Contact ID\",\"type\":\"string\",\"default\":\"{{contact_id}}\"},\"account_id\":{\"title\":\"Account ID\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"title\":{\"title\":\"Note title\",\"type\":\"string\",\"default\":\"{{title}}\"},\"content\":{\"title\":\"Note content\",\"type\":\"string\",\"default\":\"{{content}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When a note is created";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AgentLogIn(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/agentLogIn";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"agent_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"agent_email\":{\"title\":\"Agent email\",\"type\":\"string\",\"default\":\"{{agent.email}}\"},\"agent_id\":{\"title\":\"Agent ID\",\"type\":\"string\",\"default\":\"{{agent_id}}\"},\"agent_name\":{\"title\":\"Agent name\",\"type\":\"string\",\"default\":\"{{agent.name}}\"},\"agent_tags\":{\"title\":\"Agent ringing groups\",\"type\":\"string\",\"default\":\"{{agent.tags_list}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When agent logs in";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger AgentLogOut(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/agentLogOut";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"agent_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"agent_email\":{\"title\":\"Agent email\",\"type\":\"string\",\"default\":\"{{agent.email}}\"},\"agent_id\":{\"title\":\"Agent ID\",\"type\":\"string\",\"default\":\"{{agent_id}}\"},\"agent_name\":{\"title\":\"Agent name\",\"type\":\"string\",\"default\":\"{{agent.name}}\"},\"agent_tags\":{\"title\":\"Agent ringing groups\",\"type\":\"string\",\"default\":\"{{agent.tags_list}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When agent logs out";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger OutboundCallEnds(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/outboundCallEnds";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"account_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"call_id\":{\"title\":\"Callid\",\"type\":\"string\",\"default\":\"{{call_id}}\"},\"interaction_id\":{\"title\":\"Interaction id\",\"type\":\"string\",\"default\":\"{{interaction_id}}\"},\"contact_id\":{\"title\":\"Contact id\",\"type\":\"string\",\"default\":\"{{contact.id}}\"},\"account_id\":{\"title\":\"Account id\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"agent_id\":{\"title\":\"Agent id\",\"type\":\"string\",\"default\":\"{{agent_id}}\"},\"total_duration\":{\"title\":\"Total duration\",\"type\":\"string\",\"default\":\"{{total_duration}}\"},\"duration\":{\"title\":\"Call duration\",\"type\":\"string\",\"default\":\"{{duration}}\"},\"waiting_time\":{\"title\":\"Waiting time\",\"type\":\"string\",\"default\":\"{{waiting_time}}\"},\"hold_time\":{\"title\":\"Hold time\",\"type\":\"string\",\"default\":\"{{hold_time}}\"},\"hangup\":{\"title\":\"Hangup reason\",\"type\":\"string\",\"default\":\"{{hangup}}\"},\"proactive_outbound\":{\"title\":\"Launched by Outbound Dialer\",\"type\":\"string\",\"default\":\"{{proactive_outbound}}\"},\"tags\":{\"title\":\"Call ringing groups\",\"type\":\"string\",\"default\":\"{{tags}}\"},\"talkdesk_phone_number\":{\"title\":\"Contact Center number\",\"type\":\"string\",\"default\":\"{{talkdesk_phone_number}}\"},\"contact_phone_number\":{\"title\":\"Called number\",\"type\":\"string\",\"default\":\"{{contact_phone_number}}\"},\"agent_name\":{\"title\":\"Agent name\",\"type\":\"string\",\"default\":\"{{agent.name}}\"},\"agent_email\":{\"title\":\"Agent email\",\"type\":\"string\",\"default\":\"{{agent.email}}\"},\"agent_tags\":{\"title\":\"Agent ringing groups\",\"type\":\"string\",\"default\":\"{{agent.tags_list}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"phone_vip\":{\"title\":\"VIP phone number\",\"type\":\"string\",\"default\":\"{{phone.vip}}\"},\"phone_ivr\":{\"title\":\"Using IVR\",\"type\":\"string\",\"default\":\"{{phone.ivr}}\"},\"interaction_type\":{\"title\":\"Interaction type\",\"type\":\"string\",\"default\":\"{{interaction.type}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When outbound call ends";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger InboundCallReachesContactCenter(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/inboundCallReachesContactCenter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"account_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"call_id\":{\"title\":\"Callid\",\"type\":\"string\",\"default\":\"{{call_id}}\"},\"interaction_id\":{\"title\":\"Interaction id\",\"type\":\"string\",\"default\":\"{{interaction_id}}\"},\"contact_id\":{\"title\":\"Contact id\",\"type\":\"string\",\"default\":\"{{contact.id}}\"},\"account_id\":{\"title\":\"Account id\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"contact_phone_number\":{\"title\":\"Caller's number\",\"type\":\"string\",\"default\":\"{{contact_phone_number}}\"},\"interaction_context_id\":{\"title\":\"Interaction context ID\",\"type\":\"string\",\"default\":\"{{interaction_context_id}}\"},\"talkdesk_phone_number\":{\"title\":\"Contact Center number\",\"type\":\"string\",\"default\":\"{{talkdesk_phone_number}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"phone_vip\":{\"title\":\"VIP phone number\",\"type\":\"string\",\"default\":\"{{phone.vip}}\"},\"phone_ivr\":{\"title\":\"Using IVR\",\"type\":\"string\",\"default\":\"{{phone.ivr}}\"},\"interaction_type\":{\"title\":\"Interaction type\",\"type\":\"string\",\"default\":\"{{interaction.type}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When inbound call reaches contact center";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger InboundCallEnds(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/inboundCallEnds";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"account_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"call_id\":{\"title\":\"Callid\",\"type\":\"string\",\"default\":\"{{call_id}}\"},\"interaction_id\":{\"title\":\"Interaction id\",\"type\":\"string\",\"default\":\"{{interaction_id}}\"},\"contact_id\":{\"title\":\"Contact id\",\"type\":\"string\",\"default\":\"{{contact.id}}\"},\"account_id\":{\"title\":\"Account id\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"agent_id\":{\"title\":\"Agent id\",\"type\":\"string\",\"default\":\"{{agent_id}}\"},\"contact_phone_number\":{\"title\":\"Called number\",\"type\":\"string\",\"default\":\"{{contact_phone_number}}\"},\"total_duration\":{\"title\":\"Total duration\",\"type\":\"string\",\"default\":\"{{total_duration}}\"},\"duration\":{\"title\":\"Call duration\",\"type\":\"string\",\"default\":\"{{duration}}\"},\"waiting_time\":{\"title\":\"Waiting time\",\"type\":\"string\",\"default\":\"{{waiting_time}}\"},\"hold_time\":{\"title\":\"Hold time\",\"type\":\"string\",\"default\":\"{{hold_time}}\"},\"in_business_hours\":{\"title\":\"In business hours\",\"type\":\"string\",\"default\":\"{{in_business_hours}}\"},\"recording_url\":{\"title\":\"Recording URL\",\"type\":\"string\",\"default\":\"{{recording_url}}\"},\"hangup\":{\"title\":\"Hangup reason\",\"type\":\"string\",\"default\":\"{{hangup}}\"},\"start_time\":{\"title\":\"Call start time\",\"type\":\"string\",\"default\":\"{{start_time}}\"},\"timestamp\":{\"title\":\"Call end time\",\"type\":\"string\",\"default\":\"{{timestamp}}\"},\"interaction_context_id\":{\"title\":\"Interaction context ID\",\"type\":\"string\",\"default\":\"{{interaction_context_id}}\"},\"proactive_outbound\":{\"title\":\"Launched by Outbound Dialer\",\"type\":\"string\",\"default\":\"{{proactive_outbound}}\"},\"tags\":{\"title\":\"Call ringing groups\",\"type\":\"string\",\"default\":\"{{tags}}\"},\"talkdesk_phone_number\":{\"title\":\"Contact Center number\",\"type\":\"string\",\"default\":\"{{talkdesk_phone_number}}\"},\"agent_name\":{\"title\":\"Agent name\",\"type\":\"string\",\"default\":\"{{agent.name}}\"},\"agent_email\":{\"title\":\"Agent email\",\"type\":\"string\",\"default\":\"{{agent.email}}\"},\"agent_tags\":{\"title\":\"Agent ringing groups\",\"type\":\"string\",\"default\":\"{{agent.tags_list}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"phone_vip\":{\"title\":\"VIP phone number\",\"type\":\"string\",\"default\":\"{{phone.vip}}\"},\"phone_ivr\":{\"title\":\"Using IVR\",\"type\":\"string\",\"default\":\"{{phone.ivr}}\"},\"interaction_type\":{\"title\":\"Interaction type\",\"type\":\"string\",\"default\":\"{{interaction.type}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When inbound call ends";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger InboundCallStarts(string triggerName = null)
        {
            var apiCallPath = "/webhooks/triggers/inboundCallStarts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackurl"] = "@listcallbackurl()";
            bodypropCount++;
            body["message"] = "{\"$schema\":\"http://json-schema.org/draft-07/schema#\",\"title\":\"Root\",\"type\":\"object\",\"required\":[\"account_id\"],\"properties\":{\"event\":{\"title\":\"Event\",\"type\":\"string\",\"default\":\"{{event}}\"},\"call_id\":{\"title\":\"Callid\",\"type\":\"string\",\"default\":\"{{call_id}}\"},\"interaction_id\":{\"title\":\"Interaction id\",\"type\":\"string\",\"default\":\"{{interaction_id}}\"},\"contact_id\":{\"title\":\"Contact id\",\"type\":\"string\",\"default\":\"{{contact.id}}\"},\"account_id\":{\"title\":\"Account id\",\"type\":\"string\",\"default\":\"{{account_id}}\"},\"agent_id\":{\"title\":\"Agent id\",\"type\":\"string\",\"default\":\"{{agent_id}}\"},\"contact_phone_number\":{\"title\":\"Called number\",\"type\":\"string\",\"default\":\"{{contact_phone_number}}\"},\"waiting_time\":{\"title\":\"Waiting time\",\"type\":\"string\",\"default\":\"{{waiting_time}}\"},\"interaction_context_id\":{\"title\":\"Interaction context ID\",\"type\":\"string\",\"default\":\"{{interaction_context_id}}\"},\"proactive_outbound\":{\"title\":\"Launched by Outbound Dialer\",\"type\":\"string\",\"default\":\"{{proactive_outbound}}\"},\"tags\":{\"title\":\"Call ringing groups\",\"type\":\"string\",\"default\":\"{{tags}}\"},\"talkdesk_phone_number\":{\"title\":\"Contact Center number\",\"type\":\"string\",\"default\":\"{{talkdesk_phone_number}}\"},\"is_transfer\":{\"title\":\"Is transfer\",\"type\":\"string\",\"default\":\"{{is_transfer}}\"},\"agent_name\":{\"title\":\"Agent name\",\"type\":\"string\",\"default\":\"{{agent.name}}\"},\"agent_email\":{\"title\":\"Agent email\",\"type\":\"string\",\"default\":\"{{agent.email}}\"},\"agent_tags\":{\"title\":\"Agent ringing groups\",\"type\":\"string\",\"default\":\"{{agent.tags_list}}\"},\"contact_first_name\":{\"title\":\"Contact first name\",\"type\":\"string\",\"default\":\"{{contact.first_name}}\"},\"contact_last_name\":{\"title\":\"Contact last name\",\"type\":\"string\",\"default\":\"{{contact.last_name}}\"},\"contact_name\":{\"title\":\"Contact name\",\"type\":\"string\",\"default\":\"{{contact.name}}\"},\"contact_email\":{\"title\":\"Contact email\",\"type\":\"string\",\"default\":\"{{contact.email}}\"},\"contact_phone\":{\"title\":\"Contact phone\",\"type\":\"string\",\"default\":\"{{contact.phone}}\"},\"contact_company\":{\"title\":\"Contact company\",\"type\":\"string\",\"default\":\"{{contact.company}}\"},\"contact_title\":{\"title\":\"Contact title\",\"type\":\"string\",\"default\":\"{{contact.title}}\"},\"contact_address\":{\"title\":\"Contact address\",\"type\":\"string\",\"default\":\"{{contact.address}}\"},\"contact_website\":{\"title\":\"Contact website\",\"type\":\"string\",\"default\":\"{{contact.website}}\"},\"phone_vip\":{\"title\":\"VIP phone number\",\"type\":\"string\",\"default\":\"{{phone.vip}}\"},\"phone_ivr\":{\"title\":\"Using IVR\",\"type\":\"string\",\"default\":\"{{phone.ivr}}\"},\"interaction_type\":{\"title\":\"Interaction type\",\"type\":\"string\",\"default\":\"{{interaction.type}}\"},\"account_email\":{\"title\":\"Account email\",\"type\":\"string\",\"default\":\"{{account.email}}\"},\"account_name\":{\"title\":\"Account name\",\"type\":\"string\",\"default\":\"{{account.name}}\"}},\"additionalProperties\":false}";
            bodypropCount++;
            body["title"] = "When inbound call starts";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Talkdesk;

    public partial class WorkflowManagedActions
    {
        public TalkdeskActions Talkdesk(string connectionId) => new TalkdeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TalkdeskTriggers Talkdesk(string connectionId) => new TalkdeskTriggers(connectionId);
    }
}