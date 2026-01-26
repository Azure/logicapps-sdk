//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leaddesk
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeaddeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<AgentCampaignAccessResponse> AgentCampaignAccess(Expression<Func<int>> agentId, Expression<Func<int>> campaignId, Expression<Func<typeInput>> type)
        {
            var apiCallPath = "/agent_campaign_access";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("agent");
            callPayload.Queries["cmd"] = Convert.ToString("modify_campaign_access");
            callPayload.Queries["agent_id"] = ExpressionConverter.Convert(agentId);
            callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(campaignId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<AgentCampaignAccessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> phone, Expression<Func<string>> list, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> assignToAgent = null)
        {
            var apiCallPath = "/create_contact";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("contact");
            callPayload.Queries["cmd"] = Convert.ToString("add");
            if (fname != null)
                callPayload.Queries["fname"] = ExpressionConverter.Convert(fname);
            if (lname != null)
                callPayload.Queries["lname"] = ExpressionConverter.Convert(lname);
            callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            callPayload.Queries["list"] = ExpressionConverter.Convert(list);
            callPayload.Queries["return_value"] = Convert.ToString("1");
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (www != null)
                callPayload.Queries["www"] = ExpressionConverter.Convert(www);
            if (address != null)
                callPayload.Queries["address"] = ExpressionConverter.Convert(address);
            if (postcode != null)
                callPayload.Queries["postcode"] = ExpressionConverter.Convert(postcode);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (ssc != null)
                callPayload.Queries["ssc"] = ExpressionConverter.Convert(ssc);
            if (birthyear != null)
                callPayload.Queries["birthyear"] = ExpressionConverter.Convert(birthyear);
            if (gender != null)
                callPayload.Queries["gender"] = ExpressionConverter.Convert(gender);
            if (companyid != null)
                callPayload.Queries["companyid"] = ExpressionConverter.Convert(companyid);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (vatin != null)
                callPayload.Queries["vatin"] = ExpressionConverter.Convert(vatin);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            if (other1 != null)
                callPayload.Queries["other1"] = ExpressionConverter.Convert(other1);
            if (other2 != null)
                callPayload.Queries["other2"] = ExpressionConverter.Convert(other2);
            if (other3 != null)
                callPayload.Queries["other3"] = ExpressionConverter.Convert(other3);
            if (other4 != null)
                callPayload.Queries["other4"] = ExpressionConverter.Convert(other4);
            if (other5 != null)
                callPayload.Queries["other5"] = ExpressionConverter.Convert(other5);
            if (other6 != null)
                callPayload.Queries["other6"] = ExpressionConverter.Convert(other6);
            if (other7 != null)
                callPayload.Queries["other7"] = ExpressionConverter.Convert(other7);
            if (other8 != null)
                callPayload.Queries["other8"] = ExpressionConverter.Convert(other8);
            if (other9 != null)
                callPayload.Queries["other9"] = ExpressionConverter.Convert(other9);
            if (other10 != null)
                callPayload.Queries["other10"] = ExpressionConverter.Convert(other10);
            if (other11 != null)
                callPayload.Queries["other11"] = ExpressionConverter.Convert(other11);
            if (other12 != null)
                callPayload.Queries["other12"] = ExpressionConverter.Convert(other12);
            if (other13 != null)
                callPayload.Queries["other13"] = ExpressionConverter.Convert(other13);
            if (other14 != null)
                callPayload.Queries["other14"] = ExpressionConverter.Convert(other14);
            if (other15 != null)
                callPayload.Queries["other15"] = ExpressionConverter.Convert(other15);
            if (other16 != null)
                callPayload.Queries["other16"] = ExpressionConverter.Convert(other16);
            if (other17 != null)
                callPayload.Queries["other17"] = ExpressionConverter.Convert(other17);
            if (other18 != null)
                callPayload.Queries["other18"] = ExpressionConverter.Convert(other18);
            if (other19 != null)
                callPayload.Queries["other19"] = ExpressionConverter.Convert(other19);
            if (other20 != null)
                callPayload.Queries["other20"] = ExpressionConverter.Convert(other20);
            if (other21 != null)
                callPayload.Queries["other21"] = ExpressionConverter.Convert(other21);
            if (other22 != null)
                callPayload.Queries["other22"] = ExpressionConverter.Convert(other22);
            if (other23 != null)
                callPayload.Queries["other23"] = ExpressionConverter.Convert(other23);
            if (other24 != null)
                callPayload.Queries["other24"] = ExpressionConverter.Convert(other24);
            if (other25 != null)
                callPayload.Queries["other25"] = ExpressionConverter.Convert(other25);
            if (other26 != null)
                callPayload.Queries["other26"] = ExpressionConverter.Convert(other26);
            if (other27 != null)
                callPayload.Queries["other27"] = ExpressionConverter.Convert(other27);
            if (other28 != null)
                callPayload.Queries["other28"] = ExpressionConverter.Convert(other28);
            if (other29 != null)
                callPayload.Queries["other29"] = ExpressionConverter.Convert(other29);
            if (other30 != null)
                callPayload.Queries["other30"] = ExpressionConverter.Convert(other30);
            if (other31 != null)
                callPayload.Queries["other31"] = ExpressionConverter.Convert(other31);
            if (other32 != null)
                callPayload.Queries["other32"] = ExpressionConverter.Convert(other32);
            if (other33 != null)
                callPayload.Queries["other33"] = ExpressionConverter.Convert(other33);
            if (other34 != null)
                callPayload.Queries["other34"] = ExpressionConverter.Convert(other34);
            if (other35 != null)
                callPayload.Queries["other35"] = ExpressionConverter.Convert(other35);
            if (assignToAgent != null)
                callPayload.Queries["assign_to_agent"] = ExpressionConverter.Convert(assignToAgent);
            return new ApiConnectionAction<CreateContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindAgentResponse> FindAgent(Expression<Func<string>> username)
        {
            var apiCallPath = "/find_agent";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("agent");
            callPayload.Queries["cmd"] = Convert.ToString("find");
            callPayload.Queries["username"] = ExpressionConverter.Convert(username);
            return new ApiConnectionAction<FindAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindContactResponse> FindContact(Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<int>> phone = null, Expression<Func<int>> contactListId = null)
        {
            var apiCallPath = "/find_contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("contact");
            callPayload.Queries["cmd"] = Convert.ToString("find");
            if (fname != null)
                callPayload.Queries["fname"] = ExpressionConverter.Convert(fname);
            if (lname != null)
                callPayload.Queries["lname"] = ExpressionConverter.Convert(lname);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (contactListId != null)
                callPayload.Queries["contact_list_id"] = ExpressionConverter.Convert(contactListId);
            return new ApiConnectionAction<FindContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyAgentResponse> ModifyAgent(Expression<Func<int>> bodyid, Expression<Func<string>> bodyaccountexternalId = null, Expression<Func<string>> bodyaccountinboundNumber = null, Expression<Func<int>> bodyaccountlang = null, Expression<Func<string>> bodyaccountpassword = null, Expression<Func<string>> bodyaccounttimeZone = null, Expression<Func<string>> bodyaccountusername = null, Expression<Func<string>> bodyaccountvoipUsername = null, Expression<Func<string>> bodycontactInformationaddress = null, Expression<Func<string>> bodycontactInformationcity = null, Expression<Func<string>> bodycontactInformationcountry = null, Expression<Func<string>> bodycontactInformationeContacts = null, Expression<Func<string>> bodycontactInformationemail = null, Expression<Func<string>> bodycontactInformationname = null, Expression<Func<string>> bodycontactInformationphone = null, Expression<Func<string>> bodycontactInformationpostal = null, Expression<Func<string>> bodycontactInformationworkphone = null, Expression<Func<bool>> bodydisable = null, Expression<Func<int>> bodyemploymentagentGroupId = null, Expression<Func<string>> bodyemploymentbankAcc = null, Expression<Func<string>> bodyemploymentdescription = null, Expression<Func<bodyemploymentemploymentInput>> bodyemploymentemployment = null, Expression<Func<string>> bodyemploymentemploymentStart = null, Expression<Func<string>> bodyemploymentoffice = null, Expression<Func<string>> bodyemploymentssn = null, Expression<Func<string>> bodyemploymentworkshift = null)
        {
            var apiCallPath = "/modify_agent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("agent");
            callPayload.Queries["cmd"] = Convert.ToString("modify");
            var body = new JObject();
            var bodypropCount = 0;
            var accountObject = new JObject();
            var accountObjectpropCount = 0;
            if (bodyaccountexternalId != null)
            {
                accountObject["external_id"] = ExpressionConverter.ConvertO(bodyaccountexternalId);
                accountObjectpropCount++;
            }

            if (bodyaccountinboundNumber != null)
            {
                accountObject["inbound_number"] = ExpressionConverter.ConvertO(bodyaccountinboundNumber);
                accountObjectpropCount++;
            }

            if (bodyaccountlang != null)
            {
                accountObject["lang"] = ExpressionConverter.ConvertO(bodyaccountlang);
                accountObjectpropCount++;
            }

            if (bodyaccountpassword != null)
            {
                accountObject["password"] = ExpressionConverter.ConvertO(bodyaccountpassword);
                accountObjectpropCount++;
            }

            if (bodyaccounttimeZone != null)
            {
                accountObject["time_zone"] = ExpressionConverter.ConvertO(bodyaccounttimeZone);
                accountObjectpropCount++;
            }

            if (bodyaccountusername != null)
            {
                accountObject["username"] = ExpressionConverter.ConvertO(bodyaccountusername);
                accountObjectpropCount++;
            }

            if (bodyaccountvoipUsername != null)
            {
                accountObject["voip_username"] = ExpressionConverter.ConvertO(bodyaccountvoipUsername);
                accountObjectpropCount++;
            }

            if (accountObjectpropCount > 0)
            {
                body["account"] = accountObject;
                bodypropCount++;
            }

            var contact_informationObject = new JObject();
            var contact_informationObjectpropCount = 0;
            if (bodycontactInformationaddress != null)
            {
                contact_informationObject["address"] = ExpressionConverter.ConvertO(bodycontactInformationaddress);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationcity != null)
            {
                contact_informationObject["city"] = ExpressionConverter.ConvertO(bodycontactInformationcity);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationcountry != null)
            {
                contact_informationObject["country"] = ExpressionConverter.ConvertO(bodycontactInformationcountry);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationeContacts != null)
            {
                contact_informationObject["e_contacts"] = ExpressionConverter.ConvertO(bodycontactInformationeContacts);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationemail != null)
            {
                contact_informationObject["email"] = ExpressionConverter.ConvertO(bodycontactInformationemail);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationname != null)
            {
                contact_informationObject["name"] = ExpressionConverter.ConvertO(bodycontactInformationname);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationphone != null)
            {
                contact_informationObject["phone"] = ExpressionConverter.ConvertO(bodycontactInformationphone);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationpostal != null)
            {
                contact_informationObject["postal"] = ExpressionConverter.ConvertO(bodycontactInformationpostal);
                contact_informationObjectpropCount++;
            }

            if (bodycontactInformationworkphone != null)
            {
                contact_informationObject["workphone"] = ExpressionConverter.ConvertO(bodycontactInformationworkphone);
                contact_informationObjectpropCount++;
            }

            if (contact_informationObjectpropCount > 0)
            {
                body["contact_information"] = contact_informationObject;
                bodypropCount++;
            }

            if (bodydisable != null)
            {
                body["disable"] = ExpressionConverter.ConvertO(bodydisable);
                bodypropCount++;
            }

            var employmentObject = new JObject();
            var employmentObjectpropCount = 0;
            if (bodyemploymentagentGroupId != null)
            {
                employmentObject["agent_group_id"] = ExpressionConverter.ConvertO(bodyemploymentagentGroupId);
                employmentObjectpropCount++;
            }

            if (bodyemploymentbankAcc != null)
            {
                employmentObject["bank_acc"] = ExpressionConverter.ConvertO(bodyemploymentbankAcc);
                employmentObjectpropCount++;
            }

            if (bodyemploymentdescription != null)
            {
                employmentObject["description"] = ExpressionConverter.ConvertO(bodyemploymentdescription);
                employmentObjectpropCount++;
            }

            if (bodyemploymentemployment != null)
            {
                employmentObject["employment"] = ExpressionConverter.ConvertO(bodyemploymentemployment);
                employmentObjectpropCount++;
            }

            if (bodyemploymentemploymentStart != null)
            {
                employmentObject["employment_start"] = ExpressionConverter.ConvertO(bodyemploymentemploymentStart);
                employmentObjectpropCount++;
            }

            if (bodyemploymentoffice != null)
            {
                employmentObject["office"] = ExpressionConverter.ConvertO(bodyemploymentoffice);
                employmentObjectpropCount++;
            }

            if (bodyemploymentssn != null)
            {
                employmentObject["ssn"] = ExpressionConverter.ConvertO(bodyemploymentssn);
                employmentObjectpropCount++;
            }

            if (bodyemploymentworkshift != null)
            {
                employmentObject["workshift"] = ExpressionConverter.ConvertO(bodyemploymentworkshift);
                employmentObjectpropCount++;
            }

            if (employmentObjectpropCount > 0)
            {
                body["employment"] = employmentObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ModifyAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyContactResponse> ModifyContact(Expression<Func<int>> contactId, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> phone = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<int>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> list = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> assignToAgent = null)
        {
            var apiCallPath = "/modify_contact";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("contact");
            callPayload.Queries["cmd"] = Convert.ToString("modify");
            callPayload.Queries["contact_id"] = ExpressionConverter.Convert(contactId);
            if (fname != null)
                callPayload.Queries["fname"] = ExpressionConverter.Convert(fname);
            if (lname != null)
                callPayload.Queries["lname"] = ExpressionConverter.Convert(lname);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (birthyear != null)
                callPayload.Queries["birthyear"] = ExpressionConverter.Convert(birthyear);
            if (gender != null)
                callPayload.Queries["gender"] = ExpressionConverter.Convert(gender);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (www != null)
                callPayload.Queries["www"] = ExpressionConverter.Convert(www);
            if (address != null)
                callPayload.Queries["address"] = ExpressionConverter.Convert(address);
            if (postcode != null)
                callPayload.Queries["postcode"] = ExpressionConverter.Convert(postcode);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (ssc != null)
                callPayload.Queries["ssc"] = ExpressionConverter.Convert(ssc);
            if (companyid != null)
                callPayload.Queries["companyid"] = ExpressionConverter.Convert(companyid);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (vatin != null)
                callPayload.Queries["vatin"] = ExpressionConverter.Convert(vatin);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            if (other1 != null)
                callPayload.Queries["other1"] = ExpressionConverter.Convert(other1);
            if (other2 != null)
                callPayload.Queries["other2"] = ExpressionConverter.Convert(other2);
            if (other3 != null)
                callPayload.Queries["other3"] = ExpressionConverter.Convert(other3);
            if (other4 != null)
                callPayload.Queries["other4"] = ExpressionConverter.Convert(other4);
            if (other5 != null)
                callPayload.Queries["other5"] = ExpressionConverter.Convert(other5);
            if (other6 != null)
                callPayload.Queries["other6"] = ExpressionConverter.Convert(other6);
            if (other7 != null)
                callPayload.Queries["other7"] = ExpressionConverter.Convert(other7);
            if (other8 != null)
                callPayload.Queries["other8"] = ExpressionConverter.Convert(other8);
            if (other9 != null)
                callPayload.Queries["other9"] = ExpressionConverter.Convert(other9);
            if (other10 != null)
                callPayload.Queries["other10"] = ExpressionConverter.Convert(other10);
            if (other11 != null)
                callPayload.Queries["other11"] = ExpressionConverter.Convert(other11);
            if (other12 != null)
                callPayload.Queries["other12"] = ExpressionConverter.Convert(other12);
            if (other13 != null)
                callPayload.Queries["other13"] = ExpressionConverter.Convert(other13);
            if (other14 != null)
                callPayload.Queries["other14"] = ExpressionConverter.Convert(other14);
            if (other15 != null)
                callPayload.Queries["other15"] = ExpressionConverter.Convert(other15);
            if (other16 != null)
                callPayload.Queries["other16"] = ExpressionConverter.Convert(other16);
            if (other17 != null)
                callPayload.Queries["other17"] = ExpressionConverter.Convert(other17);
            if (other18 != null)
                callPayload.Queries["other18"] = ExpressionConverter.Convert(other18);
            if (other19 != null)
                callPayload.Queries["other19"] = ExpressionConverter.Convert(other19);
            if (other20 != null)
                callPayload.Queries["other20"] = ExpressionConverter.Convert(other20);
            if (other21 != null)
                callPayload.Queries["other21"] = ExpressionConverter.Convert(other21);
            if (other22 != null)
                callPayload.Queries["other22"] = ExpressionConverter.Convert(other22);
            if (other23 != null)
                callPayload.Queries["other23"] = ExpressionConverter.Convert(other23);
            if (other24 != null)
                callPayload.Queries["other24"] = ExpressionConverter.Convert(other24);
            if (other25 != null)
                callPayload.Queries["other25"] = ExpressionConverter.Convert(other25);
            if (other26 != null)
                callPayload.Queries["other26"] = ExpressionConverter.Convert(other26);
            if (other27 != null)
                callPayload.Queries["other27"] = ExpressionConverter.Convert(other27);
            if (other28 != null)
                callPayload.Queries["other28"] = ExpressionConverter.Convert(other28);
            if (other29 != null)
                callPayload.Queries["other29"] = ExpressionConverter.Convert(other29);
            if (other30 != null)
                callPayload.Queries["other30"] = ExpressionConverter.Convert(other30);
            if (other31 != null)
                callPayload.Queries["other31"] = ExpressionConverter.Convert(other31);
            if (other32 != null)
                callPayload.Queries["other32"] = ExpressionConverter.Convert(other32);
            if (other33 != null)
                callPayload.Queries["other33"] = ExpressionConverter.Convert(other33);
            if (other34 != null)
                callPayload.Queries["other34"] = ExpressionConverter.Convert(other34);
            if (other35 != null)
                callPayload.Queries["other35"] = ExpressionConverter.Convert(other35);
            if (list != null)
                callPayload.Queries["list"] = ExpressionConverter.Convert(list);
            callPayload.Queries["order"] = Convert.ToString("last");
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            if (assignToAgent != null)
                callPayload.Queries["assign_to_agent"] = ExpressionConverter.Convert(assignToAgent);
            return new ApiConnectionAction<ModifyContactResponse>(callPayload);
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

    public enum typeInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove
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

    public enum bodyemploymentemploymentInput
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