//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leaddesk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeaddeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<AgentCampaignAccessResponse, ApiConnectionActionConfiguration> AgentCampaignAccess(Expression<Func<int>> agentId, Expression<Func<int>> campaignId, Expression<Func<typeInput>> type)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            return new DeferredBodyAction<AgentCampaignAccessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agent_campaign_access";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("modify_campaign_access");
                callPayload.Queries["agent_id"] = ExpressionConverter.Convert(__workflow_agentId);
                callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(__workflow_campaignId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<AgentCampaignAccessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateAgentResponse, ApiConnectionActionConfiguration> CreateAgent(Expression<Func<CreateAgentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("create");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateCallbackResponse, ApiConnectionActionConfiguration> CreateCallback(Expression<Func<CreateCallbackInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCallbackResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create_callback";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("call");
                callPayload.Queries["cmd"] = Convert.ToString("create_callback");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCallbackResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateContactResponse, ApiConnectionActionConfiguration> CreateContact(Expression<Func<string>> phone, Expression<Func<string>> list, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> assignToAgent = null)
        {
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: true);
            var __workflow_fname = WorkflowExpression.Compile(fname, nameof(fname), required: false);
            var __workflow_lname = WorkflowExpression.Compile(lname, nameof(lname), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_www = WorkflowExpression.Compile(www, nameof(www), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_ssc = WorkflowExpression.Compile(ssc, nameof(ssc), required: false);
            var __workflow_birthyear = WorkflowExpression.Compile(birthyear, nameof(birthyear), required: false);
            var __workflow_gender = WorkflowExpression.Compile(gender, nameof(gender), required: false);
            var __workflow_companyid = WorkflowExpression.Compile(companyid, nameof(companyid), required: false);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_vatin = WorkflowExpression.Compile(vatin, nameof(vatin), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            var __workflow_other1 = WorkflowExpression.Compile(other1, nameof(other1), required: false);
            var __workflow_other2 = WorkflowExpression.Compile(other2, nameof(other2), required: false);
            var __workflow_other3 = WorkflowExpression.Compile(other3, nameof(other3), required: false);
            var __workflow_other4 = WorkflowExpression.Compile(other4, nameof(other4), required: false);
            var __workflow_other5 = WorkflowExpression.Compile(other5, nameof(other5), required: false);
            var __workflow_other6 = WorkflowExpression.Compile(other6, nameof(other6), required: false);
            var __workflow_other7 = WorkflowExpression.Compile(other7, nameof(other7), required: false);
            var __workflow_other8 = WorkflowExpression.Compile(other8, nameof(other8), required: false);
            var __workflow_other9 = WorkflowExpression.Compile(other9, nameof(other9), required: false);
            var __workflow_other10 = WorkflowExpression.Compile(other10, nameof(other10), required: false);
            var __workflow_other11 = WorkflowExpression.Compile(other11, nameof(other11), required: false);
            var __workflow_other12 = WorkflowExpression.Compile(other12, nameof(other12), required: false);
            var __workflow_other13 = WorkflowExpression.Compile(other13, nameof(other13), required: false);
            var __workflow_other14 = WorkflowExpression.Compile(other14, nameof(other14), required: false);
            var __workflow_other15 = WorkflowExpression.Compile(other15, nameof(other15), required: false);
            var __workflow_other16 = WorkflowExpression.Compile(other16, nameof(other16), required: false);
            var __workflow_other17 = WorkflowExpression.Compile(other17, nameof(other17), required: false);
            var __workflow_other18 = WorkflowExpression.Compile(other18, nameof(other18), required: false);
            var __workflow_other19 = WorkflowExpression.Compile(other19, nameof(other19), required: false);
            var __workflow_other20 = WorkflowExpression.Compile(other20, nameof(other20), required: false);
            var __workflow_other21 = WorkflowExpression.Compile(other21, nameof(other21), required: false);
            var __workflow_other22 = WorkflowExpression.Compile(other22, nameof(other22), required: false);
            var __workflow_other23 = WorkflowExpression.Compile(other23, nameof(other23), required: false);
            var __workflow_other24 = WorkflowExpression.Compile(other24, nameof(other24), required: false);
            var __workflow_other25 = WorkflowExpression.Compile(other25, nameof(other25), required: false);
            var __workflow_other26 = WorkflowExpression.Compile(other26, nameof(other26), required: false);
            var __workflow_other27 = WorkflowExpression.Compile(other27, nameof(other27), required: false);
            var __workflow_other28 = WorkflowExpression.Compile(other28, nameof(other28), required: false);
            var __workflow_other29 = WorkflowExpression.Compile(other29, nameof(other29), required: false);
            var __workflow_other30 = WorkflowExpression.Compile(other30, nameof(other30), required: false);
            var __workflow_other31 = WorkflowExpression.Compile(other31, nameof(other31), required: false);
            var __workflow_other32 = WorkflowExpression.Compile(other32, nameof(other32), required: false);
            var __workflow_other33 = WorkflowExpression.Compile(other33, nameof(other33), required: false);
            var __workflow_other34 = WorkflowExpression.Compile(other34, nameof(other34), required: false);
            var __workflow_other35 = WorkflowExpression.Compile(other35, nameof(other35), required: false);
            var __workflow_assignToAgent = WorkflowExpression.Compile(assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<CreateContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/create_contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("add");
                if (__workflow_fname != null)
                    callPayload.Queries["fname"] = ExpressionConverter.Convert(__workflow_fname);
                if (__workflow_lname != null)
                    callPayload.Queries["lname"] = ExpressionConverter.Convert(__workflow_lname);
                callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                callPayload.Queries["list"] = ExpressionConverter.Convert(__workflow_list);
                callPayload.Queries["return_value"] = Convert.ToString("1");
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_www != null)
                    callPayload.Queries["www"] = ExpressionConverter.Convert(__workflow_www);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_postcode != null)
                    callPayload.Queries["postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_ssc != null)
                    callPayload.Queries["ssc"] = ExpressionConverter.Convert(__workflow_ssc);
                if (__workflow_birthyear != null)
                    callPayload.Queries["birthyear"] = ExpressionConverter.Convert(__workflow_birthyear);
                if (__workflow_gender != null)
                    callPayload.Queries["gender"] = ExpressionConverter.Convert(__workflow_gender);
                if (__workflow_companyid != null)
                    callPayload.Queries["companyid"] = ExpressionConverter.Convert(__workflow_companyid);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_vatin != null)
                    callPayload.Queries["vatin"] = ExpressionConverter.Convert(__workflow_vatin);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                if (__workflow_other1 != null)
                    callPayload.Queries["other1"] = ExpressionConverter.Convert(__workflow_other1);
                if (__workflow_other2 != null)
                    callPayload.Queries["other2"] = ExpressionConverter.Convert(__workflow_other2);
                if (__workflow_other3 != null)
                    callPayload.Queries["other3"] = ExpressionConverter.Convert(__workflow_other3);
                if (__workflow_other4 != null)
                    callPayload.Queries["other4"] = ExpressionConverter.Convert(__workflow_other4);
                if (__workflow_other5 != null)
                    callPayload.Queries["other5"] = ExpressionConverter.Convert(__workflow_other5);
                if (__workflow_other6 != null)
                    callPayload.Queries["other6"] = ExpressionConverter.Convert(__workflow_other6);
                if (__workflow_other7 != null)
                    callPayload.Queries["other7"] = ExpressionConverter.Convert(__workflow_other7);
                if (__workflow_other8 != null)
                    callPayload.Queries["other8"] = ExpressionConverter.Convert(__workflow_other8);
                if (__workflow_other9 != null)
                    callPayload.Queries["other9"] = ExpressionConverter.Convert(__workflow_other9);
                if (__workflow_other10 != null)
                    callPayload.Queries["other10"] = ExpressionConverter.Convert(__workflow_other10);
                if (__workflow_other11 != null)
                    callPayload.Queries["other11"] = ExpressionConverter.Convert(__workflow_other11);
                if (__workflow_other12 != null)
                    callPayload.Queries["other12"] = ExpressionConverter.Convert(__workflow_other12);
                if (__workflow_other13 != null)
                    callPayload.Queries["other13"] = ExpressionConverter.Convert(__workflow_other13);
                if (__workflow_other14 != null)
                    callPayload.Queries["other14"] = ExpressionConverter.Convert(__workflow_other14);
                if (__workflow_other15 != null)
                    callPayload.Queries["other15"] = ExpressionConverter.Convert(__workflow_other15);
                if (__workflow_other16 != null)
                    callPayload.Queries["other16"] = ExpressionConverter.Convert(__workflow_other16);
                if (__workflow_other17 != null)
                    callPayload.Queries["other17"] = ExpressionConverter.Convert(__workflow_other17);
                if (__workflow_other18 != null)
                    callPayload.Queries["other18"] = ExpressionConverter.Convert(__workflow_other18);
                if (__workflow_other19 != null)
                    callPayload.Queries["other19"] = ExpressionConverter.Convert(__workflow_other19);
                if (__workflow_other20 != null)
                    callPayload.Queries["other20"] = ExpressionConverter.Convert(__workflow_other20);
                if (__workflow_other21 != null)
                    callPayload.Queries["other21"] = ExpressionConverter.Convert(__workflow_other21);
                if (__workflow_other22 != null)
                    callPayload.Queries["other22"] = ExpressionConverter.Convert(__workflow_other22);
                if (__workflow_other23 != null)
                    callPayload.Queries["other23"] = ExpressionConverter.Convert(__workflow_other23);
                if (__workflow_other24 != null)
                    callPayload.Queries["other24"] = ExpressionConverter.Convert(__workflow_other24);
                if (__workflow_other25 != null)
                    callPayload.Queries["other25"] = ExpressionConverter.Convert(__workflow_other25);
                if (__workflow_other26 != null)
                    callPayload.Queries["other26"] = ExpressionConverter.Convert(__workflow_other26);
                if (__workflow_other27 != null)
                    callPayload.Queries["other27"] = ExpressionConverter.Convert(__workflow_other27);
                if (__workflow_other28 != null)
                    callPayload.Queries["other28"] = ExpressionConverter.Convert(__workflow_other28);
                if (__workflow_other29 != null)
                    callPayload.Queries["other29"] = ExpressionConverter.Convert(__workflow_other29);
                if (__workflow_other30 != null)
                    callPayload.Queries["other30"] = ExpressionConverter.Convert(__workflow_other30);
                if (__workflow_other31 != null)
                    callPayload.Queries["other31"] = ExpressionConverter.Convert(__workflow_other31);
                if (__workflow_other32 != null)
                    callPayload.Queries["other32"] = ExpressionConverter.Convert(__workflow_other32);
                if (__workflow_other33 != null)
                    callPayload.Queries["other33"] = ExpressionConverter.Convert(__workflow_other33);
                if (__workflow_other34 != null)
                    callPayload.Queries["other34"] = ExpressionConverter.Convert(__workflow_other34);
                if (__workflow_other35 != null)
                    callPayload.Queries["other35"] = ExpressionConverter.Convert(__workflow_other35);
                if (__workflow_assignToAgent != null)
                    callPayload.Queries["assign_to_agent"] = ExpressionConverter.Convert(__workflow_assignToAgent);
                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindAgentResponse, ApiConnectionActionConfiguration> FindAgent(Expression<Func<string>> username)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            return new DeferredBodyAction<FindAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/find_agent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("find");
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                return new ApiConnectionAction<FindAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindContactResponse, ApiConnectionActionConfiguration> FindContact(Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<int>> phone = null, Expression<Func<int>> contactListId = null)
        {
            var __workflow_fname = WorkflowExpression.Compile(fname, nameof(fname), required: false);
            var __workflow_lname = WorkflowExpression.Compile(lname, nameof(lname), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_contactListId = WorkflowExpression.Compile(contactListId, nameof(contactListId), required: false);
            return new DeferredBodyAction<FindContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/find_contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("find");
                if (__workflow_fname != null)
                    callPayload.Queries["fname"] = ExpressionConverter.Convert(__workflow_fname);
                if (__workflow_lname != null)
                    callPayload.Queries["lname"] = ExpressionConverter.Convert(__workflow_lname);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_contactListId != null)
                    callPayload.Queries["contact_list_id"] = ExpressionConverter.Convert(__workflow_contactListId);
                return new ApiConnectionAction<FindContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyAgentResponse, ApiConnectionActionConfiguration> ModifyAgent(Expression<Func<ModifyAgentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ModifyAgentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/modify_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("modify");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ModifyAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyContactResponse, ApiConnectionActionConfiguration> ModifyContact(Expression<Func<int>> contactId, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> phone = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<int>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> list = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> assignToAgent = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_fname = WorkflowExpression.Compile(fname, nameof(fname), required: false);
            var __workflow_lname = WorkflowExpression.Compile(lname, nameof(lname), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_birthyear = WorkflowExpression.Compile(birthyear, nameof(birthyear), required: false);
            var __workflow_gender = WorkflowExpression.Compile(gender, nameof(gender), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_www = WorkflowExpression.Compile(www, nameof(www), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_ssc = WorkflowExpression.Compile(ssc, nameof(ssc), required: false);
            var __workflow_companyid = WorkflowExpression.Compile(companyid, nameof(companyid), required: false);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: false);
            var __workflow_vatin = WorkflowExpression.Compile(vatin, nameof(vatin), required: false);
            var __workflow_title = WorkflowExpression.Compile(title, nameof(title), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            var __workflow_other1 = WorkflowExpression.Compile(other1, nameof(other1), required: false);
            var __workflow_other2 = WorkflowExpression.Compile(other2, nameof(other2), required: false);
            var __workflow_other3 = WorkflowExpression.Compile(other3, nameof(other3), required: false);
            var __workflow_other4 = WorkflowExpression.Compile(other4, nameof(other4), required: false);
            var __workflow_other5 = WorkflowExpression.Compile(other5, nameof(other5), required: false);
            var __workflow_other6 = WorkflowExpression.Compile(other6, nameof(other6), required: false);
            var __workflow_other7 = WorkflowExpression.Compile(other7, nameof(other7), required: false);
            var __workflow_other8 = WorkflowExpression.Compile(other8, nameof(other8), required: false);
            var __workflow_other9 = WorkflowExpression.Compile(other9, nameof(other9), required: false);
            var __workflow_other10 = WorkflowExpression.Compile(other10, nameof(other10), required: false);
            var __workflow_other11 = WorkflowExpression.Compile(other11, nameof(other11), required: false);
            var __workflow_other12 = WorkflowExpression.Compile(other12, nameof(other12), required: false);
            var __workflow_other13 = WorkflowExpression.Compile(other13, nameof(other13), required: false);
            var __workflow_other14 = WorkflowExpression.Compile(other14, nameof(other14), required: false);
            var __workflow_other15 = WorkflowExpression.Compile(other15, nameof(other15), required: false);
            var __workflow_other16 = WorkflowExpression.Compile(other16, nameof(other16), required: false);
            var __workflow_other17 = WorkflowExpression.Compile(other17, nameof(other17), required: false);
            var __workflow_other18 = WorkflowExpression.Compile(other18, nameof(other18), required: false);
            var __workflow_other19 = WorkflowExpression.Compile(other19, nameof(other19), required: false);
            var __workflow_other20 = WorkflowExpression.Compile(other20, nameof(other20), required: false);
            var __workflow_other21 = WorkflowExpression.Compile(other21, nameof(other21), required: false);
            var __workflow_other22 = WorkflowExpression.Compile(other22, nameof(other22), required: false);
            var __workflow_other23 = WorkflowExpression.Compile(other23, nameof(other23), required: false);
            var __workflow_other24 = WorkflowExpression.Compile(other24, nameof(other24), required: false);
            var __workflow_other25 = WorkflowExpression.Compile(other25, nameof(other25), required: false);
            var __workflow_other26 = WorkflowExpression.Compile(other26, nameof(other26), required: false);
            var __workflow_other27 = WorkflowExpression.Compile(other27, nameof(other27), required: false);
            var __workflow_other28 = WorkflowExpression.Compile(other28, nameof(other28), required: false);
            var __workflow_other29 = WorkflowExpression.Compile(other29, nameof(other29), required: false);
            var __workflow_other30 = WorkflowExpression.Compile(other30, nameof(other30), required: false);
            var __workflow_other31 = WorkflowExpression.Compile(other31, nameof(other31), required: false);
            var __workflow_other32 = WorkflowExpression.Compile(other32, nameof(other32), required: false);
            var __workflow_other33 = WorkflowExpression.Compile(other33, nameof(other33), required: false);
            var __workflow_other34 = WorkflowExpression.Compile(other34, nameof(other34), required: false);
            var __workflow_other35 = WorkflowExpression.Compile(other35, nameof(other35), required: false);
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_assignToAgent = WorkflowExpression.Compile(assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<ModifyContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/modify_contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("modify");
                callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_fname != null)
                    callPayload.Queries["fname"] = ExpressionConverter.Convert(__workflow_fname);
                if (__workflow_lname != null)
                    callPayload.Queries["lname"] = ExpressionConverter.Convert(__workflow_lname);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_birthyear != null)
                    callPayload.Queries["birthyear"] = ExpressionConverter.Convert(__workflow_birthyear);
                if (__workflow_gender != null)
                    callPayload.Queries["gender"] = ExpressionConverter.Convert(__workflow_gender);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_www != null)
                    callPayload.Queries["www"] = ExpressionConverter.Convert(__workflow_www);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_postcode != null)
                    callPayload.Queries["postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_ssc != null)
                    callPayload.Queries["ssc"] = ExpressionConverter.Convert(__workflow_ssc);
                if (__workflow_companyid != null)
                    callPayload.Queries["companyid"] = ExpressionConverter.Convert(__workflow_companyid);
                if (__workflow_company != null)
                    callPayload.Queries["company"] = ExpressionConverter.Convert(__workflow_company);
                if (__workflow_vatin != null)
                    callPayload.Queries["vatin"] = ExpressionConverter.Convert(__workflow_vatin);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                if (__workflow_other1 != null)
                    callPayload.Queries["other1"] = ExpressionConverter.Convert(__workflow_other1);
                if (__workflow_other2 != null)
                    callPayload.Queries["other2"] = ExpressionConverter.Convert(__workflow_other2);
                if (__workflow_other3 != null)
                    callPayload.Queries["other3"] = ExpressionConverter.Convert(__workflow_other3);
                if (__workflow_other4 != null)
                    callPayload.Queries["other4"] = ExpressionConverter.Convert(__workflow_other4);
                if (__workflow_other5 != null)
                    callPayload.Queries["other5"] = ExpressionConverter.Convert(__workflow_other5);
                if (__workflow_other6 != null)
                    callPayload.Queries["other6"] = ExpressionConverter.Convert(__workflow_other6);
                if (__workflow_other7 != null)
                    callPayload.Queries["other7"] = ExpressionConverter.Convert(__workflow_other7);
                if (__workflow_other8 != null)
                    callPayload.Queries["other8"] = ExpressionConverter.Convert(__workflow_other8);
                if (__workflow_other9 != null)
                    callPayload.Queries["other9"] = ExpressionConverter.Convert(__workflow_other9);
                if (__workflow_other10 != null)
                    callPayload.Queries["other10"] = ExpressionConverter.Convert(__workflow_other10);
                if (__workflow_other11 != null)
                    callPayload.Queries["other11"] = ExpressionConverter.Convert(__workflow_other11);
                if (__workflow_other12 != null)
                    callPayload.Queries["other12"] = ExpressionConverter.Convert(__workflow_other12);
                if (__workflow_other13 != null)
                    callPayload.Queries["other13"] = ExpressionConverter.Convert(__workflow_other13);
                if (__workflow_other14 != null)
                    callPayload.Queries["other14"] = ExpressionConverter.Convert(__workflow_other14);
                if (__workflow_other15 != null)
                    callPayload.Queries["other15"] = ExpressionConverter.Convert(__workflow_other15);
                if (__workflow_other16 != null)
                    callPayload.Queries["other16"] = ExpressionConverter.Convert(__workflow_other16);
                if (__workflow_other17 != null)
                    callPayload.Queries["other17"] = ExpressionConverter.Convert(__workflow_other17);
                if (__workflow_other18 != null)
                    callPayload.Queries["other18"] = ExpressionConverter.Convert(__workflow_other18);
                if (__workflow_other19 != null)
                    callPayload.Queries["other19"] = ExpressionConverter.Convert(__workflow_other19);
                if (__workflow_other20 != null)
                    callPayload.Queries["other20"] = ExpressionConverter.Convert(__workflow_other20);
                if (__workflow_other21 != null)
                    callPayload.Queries["other21"] = ExpressionConverter.Convert(__workflow_other21);
                if (__workflow_other22 != null)
                    callPayload.Queries["other22"] = ExpressionConverter.Convert(__workflow_other22);
                if (__workflow_other23 != null)
                    callPayload.Queries["other23"] = ExpressionConverter.Convert(__workflow_other23);
                if (__workflow_other24 != null)
                    callPayload.Queries["other24"] = ExpressionConverter.Convert(__workflow_other24);
                if (__workflow_other25 != null)
                    callPayload.Queries["other25"] = ExpressionConverter.Convert(__workflow_other25);
                if (__workflow_other26 != null)
                    callPayload.Queries["other26"] = ExpressionConverter.Convert(__workflow_other26);
                if (__workflow_other27 != null)
                    callPayload.Queries["other27"] = ExpressionConverter.Convert(__workflow_other27);
                if (__workflow_other28 != null)
                    callPayload.Queries["other28"] = ExpressionConverter.Convert(__workflow_other28);
                if (__workflow_other29 != null)
                    callPayload.Queries["other29"] = ExpressionConverter.Convert(__workflow_other29);
                if (__workflow_other30 != null)
                    callPayload.Queries["other30"] = ExpressionConverter.Convert(__workflow_other30);
                if (__workflow_other31 != null)
                    callPayload.Queries["other31"] = ExpressionConverter.Convert(__workflow_other31);
                if (__workflow_other32 != null)
                    callPayload.Queries["other32"] = ExpressionConverter.Convert(__workflow_other32);
                if (__workflow_other33 != null)
                    callPayload.Queries["other33"] = ExpressionConverter.Convert(__workflow_other33);
                if (__workflow_other34 != null)
                    callPayload.Queries["other34"] = ExpressionConverter.Convert(__workflow_other34);
                if (__workflow_other35 != null)
                    callPayload.Queries["other35"] = ExpressionConverter.Convert(__workflow_other35);
                if (__workflow_list != null)
                    callPayload.Queries["list"] = ExpressionConverter.Convert(__workflow_list);
                callPayload.Queries["order"] = Convert.ToString("last");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_assignToAgent != null)
                    callPayload.Queries["assign_to_agent"] = ExpressionConverter.Convert(__workflow_assignToAgent);
                return new ApiConnectionAction<ModifyContactResponse>(callPayload);
            });
        }
    }

    public class LeaddeskTriggers([ConnectionName] string connectionId)
    {
    }

    public class AgentCampaignAccessResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove
    }

    public class CreateAgentResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CreateAgentInput
    {
        [JsonProperty("account", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentInputAccountType Account { get; set; }

        [JsonProperty("contact_information", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentInputContactInformationType ContactInformation { get; set; }

        [JsonProperty("employment")]
        public CreateAgentInputEmploymentType Employment { get; set; }
    }

    public class CreateAgentInputAccountType
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("inbound_number")]
        public string InboundNumber { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Level { get; set; } = "agent";

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("time_zone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeZone { get; set; } = "Europe/Helsinki";

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty("voip_username")]
        public string VoipUsername { get; set; }
    }

    public class CreateAgentInputContactInformationType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("e_contacts")]
        public string EContacts { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("workphone")]
        public string Workphone { get; set; }
    }

    public class CreateAgentInputEmploymentType
    {
        [JsonProperty("agent_group_id")]
        public int? AgentGroupId { get; set; }

        [JsonProperty("bank_acc")]
        public string BankAcc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("employment", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentInputEmploymentTypeEmploymentType? Employment { get; set; } = CreateAgentInputEmploymentTypeEmploymentType.Active;

        [JsonProperty("employment_start")]
        public string EmploymentStart { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("workshift")]
        public string Workshift { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgentInputEmploymentTypeEmploymentType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class CreateCallbackResponse
    {
        [JsonProperty("callback_id")]
        public int CallbackId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CreateCallbackInput
    {
        [JsonProperty("contact")]
        public CreateCallbackInputContactType Contact { get; set; }

        [JsonProperty("properties", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCallbackInputPropertiesType Properties { get; set; }

        [JsonProperty("return_callback_id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ReturnCallbackId { get; set; } = true;
    }

    public class CreateCallbackInputContactType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyid")]
        public int? Companyid { get; set; }

        [JsonProperty("contact_list")]
        public string ContactList { get; set; }

        [JsonProperty("contactid")]
        public string Contactid { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("lname")]
        public string Lname { get; set; }

        [JsonProperty("other1")]
        public string Other1 { get; set; }

        [JsonProperty("other2")]
        public string Other2 { get; set; }

        [JsonProperty("other3")]
        public string Other3 { get; set; }

        [JsonProperty("other4")]
        public string Other4 { get; set; }

        [JsonProperty("other5")]
        public string Other5 { get; set; }

        [JsonProperty("other6")]
        public string Other6 { get; set; }

        [JsonProperty("other7")]
        public string Other7 { get; set; }

        [JsonProperty("other8")]
        public string Other8 { get; set; }

        [JsonProperty("other9")]
        public string Other9 { get; set; }

        [JsonProperty("other10")]
        public string Other10 { get; set; }

        [JsonProperty("other11")]
        public string Other11 { get; set; }

        [JsonProperty("other12")]
        public string Other12 { get; set; }

        [JsonProperty("other13")]
        public string Other13 { get; set; }

        [JsonProperty("other14")]
        public string Other14 { get; set; }

        [JsonProperty("other15")]
        public string Other15 { get; set; }

        [JsonProperty("other16")]
        public string Other16 { get; set; }

        [JsonProperty("other17")]
        public string Other17 { get; set; }

        [JsonProperty("other18")]
        public string Other18 { get; set; }

        [JsonProperty("other19")]
        public string Other19 { get; set; }

        [JsonProperty("other20")]
        public string Other20 { get; set; }

        [JsonProperty("other21")]
        public string Other21 { get; set; }

        [JsonProperty("other22")]
        public string Other22 { get; set; }

        [JsonProperty("other23")]
        public string Other23 { get; set; }

        [JsonProperty("other24")]
        public string Other24 { get; set; }

        [JsonProperty("other25")]
        public string Other25 { get; set; }

        [JsonProperty("other26")]
        public string Other26 { get; set; }

        [JsonProperty("other27")]
        public string Other27 { get; set; }

        [JsonProperty("other28")]
        public string Other28 { get; set; }

        [JsonProperty("other29")]
        public string Other29 { get; set; }

        [JsonProperty("other30")]
        public string Other30 { get; set; }

        [JsonProperty("other31")]
        public string Other31 { get; set; }

        [JsonProperty("other32")]
        public string Other32 { get; set; }

        [JsonProperty("other33")]
        public string Other33 { get; set; }

        [JsonProperty("other34")]
        public string Other34 { get; set; }

        [JsonProperty("other35")]
        public string Other35 { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }
    }

    public class CreateCallbackInputPropertiesType
    {
        [JsonProperty("agent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Agent { get; set; }

        [JsonProperty("agent_group")]
        public string AgentGroup { get; set; }

        [JsonProperty("campaign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Campaign { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }

        [JsonProperty("timestamp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timestamp { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateCallbackInputPropertiesTypeTypeType Type { get; set; } = CreateCallbackInputPropertiesTypeTypeType.Private;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateCallbackInputPropertiesTypeTypeType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public
    }

    public class CreateContactResponse
    {
        [JsonProperty("contact_id")]
        public int ContactId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class FindAgentResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FindContactResponse
    {
        [JsonProperty("contact_ids")]
        public int[] ContactIds { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class ModifyAgentResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ModifyAgentInput
    {
        [JsonProperty("account")]
        public ModifyAgentInputAccountType Account { get; set; }

        [JsonProperty("contact_information")]
        public ModifyAgentInputContactInformationType ContactInformation { get; set; }

        [JsonProperty("disable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Disable { get; set; } = false;

        [JsonProperty("employment")]
        public ModifyAgentInputEmploymentType Employment { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    public class ModifyAgentInputAccountType
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("inbound_number")]
        public string InboundNumber { get; set; }

        [JsonProperty("lang")]
        public int? Lang { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("voip_username")]
        public string VoipUsername { get; set; }
    }

    public class ModifyAgentInputContactInformationType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("e_contacts")]
        public string EContacts { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("postal")]
        public string Postal { get; set; }

        [JsonProperty("workphone")]
        public string Workphone { get; set; }
    }

    public class ModifyAgentInputEmploymentType
    {
        [JsonProperty("agent_group_id")]
        public int? AgentGroupId { get; set; }

        [JsonProperty("bank_acc")]
        public string BankAcc { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("employment")]
        public ModifyAgentInputEmploymentTypeEmploymentType? Employment { get; set; }

        [JsonProperty("employment_start")]
        public string EmploymentStart { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("workshift")]
        public string Workshift { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ModifyAgentInputEmploymentTypeEmploymentType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class ModifyContactResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "last")]
        Last
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leaddesk;

    public partial class WorkflowManagedActions
    {
        public LeaddeskActions Leaddesk(string connectionId) => new LeaddeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeaddeskTriggers Leaddesk(string connectionId) => new LeaddeskTriggers(connectionId);
    }
}