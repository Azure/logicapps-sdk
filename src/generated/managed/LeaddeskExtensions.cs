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
            callPayload.Queries["agent_id"] = CSharpExpressionConverter.ConvertO(agentId);
            callPayload.Queries["campaign_id"] = CSharpExpressionConverter.ConvertO(campaignId);
            callPayload.Queries["type"] = CSharpExpressionConverter.Convert(type);
            return new ApiConnectionAction<AgentCampaignAccessResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent(Expression<Func<string>> bodyaccountexternalId = null, Expression<Func<string>> bodyaccountinboundNumber = null, Expression<Func<string>> bodyaccountlang = null, Expression<Func<string>> bodyaccountpassword = null, Expression<Func<string>> bodyaccounttimeZone = null, Expression<Func<string>> bodyaccountusername = null, Expression<Func<string>> bodyaccountvoipUsername = null, Expression<Func<string>> bodycontactInformationaddress = null, Expression<Func<string>> bodycontactInformationcity = null, Expression<Func<string>> bodycontactInformationcountry = null, Expression<Func<string>> bodycontactInformationeContacts = null, Expression<Func<string>> bodycontactInformationemail = null, Expression<Func<string>> bodycontactInformationname = null, Expression<Func<string>> bodycontactInformationphone = null, Expression<Func<string>> bodycontactInformationpostal = null, Expression<Func<string>> bodycontactInformationworkphone = null, Expression<Func<int>> bodyemploymentagentGroupId = null, Expression<Func<string>> bodyemploymentbankAcc = null, Expression<Func<string>> bodyemploymentdescription = null, Expression<Func<bodyemploymentemploymentInput>> bodyemploymentemployment = null, Expression<Func<string>> bodyemploymentemploymentStart = null, Expression<Func<string>> bodyemploymentoffice = null, Expression<Func<string>> bodyemploymentssn = null, Expression<Func<string>> bodyemploymentworkshift = null)
        {
            var apiCallPath = "/create_agent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("agent");
            callPayload.Queries["cmd"] = Convert.ToString("create");
            var body = new JObject();
            var bodypropCount = 0;
            var accountObject = new JObject();
            var accountObjectpropCount = 0;
            if (bodyaccountexternalId != null)
            {
                accountObject["external_id"] = CSharpExpressionConverter.ConvertToken(bodyaccountexternalId);
                accountObjectpropCount++;
            }

            if (bodyaccountinboundNumber != null)
            {
                accountObject["inbound_number"] = CSharpExpressionConverter.ConvertToken(bodyaccountinboundNumber);
                accountObjectpropCount++;
            }

            if (bodyaccountlang != null)
            {
                accountObject["lang"] = CSharpExpressionConverter.ConvertToken(bodyaccountlang);
                accountObjectpropCount++;
            }

            accountObject["level"] = "agent";
            accountObjectpropCount++;
            if (bodyaccountpassword != null)
            {
                accountObject["password"] = CSharpExpressionConverter.ConvertToken(bodyaccountpassword);
                accountObjectpropCount++;
            }

            if (bodyaccounttimeZone != null)
            {
                if (bodyaccounttimeZone != null)
                {
                    accountObject["time_zone"] = CSharpExpressionConverter.ConvertToken(bodyaccounttimeZone);
                    accountObjectpropCount++;
                }

                accountObjectpropCount++;
            }
            else
            {
                accountObject["time_zone"] = "Europe/Helsinki";
                accountObjectpropCount++;
            }

            if (bodyaccountusername != null)
            {
                accountObject["username"] = CSharpExpressionConverter.ConvertToken(bodyaccountusername);
                accountObjectpropCount++;
            }

            if (bodyaccountvoipUsername != null)
            {
                accountObject["voip_username"] = CSharpExpressionConverter.ConvertToken(bodyaccountvoipUsername);
                accountObjectpropCount++;
            }

            if (accountObjectpropCount > 0)
            {
                body["account"] = accountObject;
                bodypropCount++;
            }

            var contactInformationObject = new JObject();
            var contactInformationObjectpropCount = 0;
            if (bodycontactInformationaddress != null)
            {
                contactInformationObject["address"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationaddress);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationcity != null)
            {
                contactInformationObject["city"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationcity);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationcountry != null)
            {
                contactInformationObject["country"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationcountry);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationeContacts != null)
            {
                contactInformationObject["e_contacts"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationeContacts);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationemail != null)
            {
                contactInformationObject["email"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationemail);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationname != null)
            {
                contactInformationObject["name"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationname);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationphone != null)
            {
                contactInformationObject["phone"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationphone);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationpostal != null)
            {
                contactInformationObject["postal"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationpostal);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationworkphone != null)
            {
                contactInformationObject["workphone"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationworkphone);
                contactInformationObjectpropCount++;
            }

            if (contactInformationObjectpropCount > 0)
            {
                body["contact_information"] = contactInformationObject;
                bodypropCount++;
            }

            var employmentObject = new JObject();
            var employmentObjectpropCount = 0;
            if (bodyemploymentagentGroupId != null)
            {
                employmentObject["agent_group_id"] = CSharpExpressionConverter.ConvertToken(bodyemploymentagentGroupId);
                employmentObjectpropCount++;
            }

            if (bodyemploymentbankAcc != null)
            {
                employmentObject["bank_acc"] = CSharpExpressionConverter.ConvertToken(bodyemploymentbankAcc);
                employmentObjectpropCount++;
            }

            if (bodyemploymentdescription != null)
            {
                employmentObject["description"] = CSharpExpressionConverter.ConvertToken(bodyemploymentdescription);
                employmentObjectpropCount++;
            }

            if (bodyemploymentemployment != null)
            {
                if (bodyemploymentemployment != null)
                {
                    employmentObject["employment"] = CSharpExpressionConverter.Convert(bodyemploymentemployment);
                    employmentObjectpropCount++;
                }

                employmentObjectpropCount++;
            }
            else
            {
                employmentObject["employment"] = "active";
                employmentObjectpropCount++;
            }

            if (bodyemploymentemploymentStart != null)
            {
                employmentObject["employment_start"] = CSharpExpressionConverter.ConvertToken(bodyemploymentemploymentStart);
                employmentObjectpropCount++;
            }

            if (bodyemploymentoffice != null)
            {
                employmentObject["office"] = CSharpExpressionConverter.ConvertToken(bodyemploymentoffice);
                employmentObjectpropCount++;
            }

            if (bodyemploymentssn != null)
            {
                employmentObject["ssn"] = CSharpExpressionConverter.ConvertToken(bodyemploymentssn);
                employmentObjectpropCount++;
            }

            if (bodyemploymentworkshift != null)
            {
                employmentObject["workshift"] = CSharpExpressionConverter.ConvertToken(bodyemploymentworkshift);
                employmentObjectpropCount++;
            }

            if (employmentObjectpropCount > 0)
            {
                body["employment"] = employmentObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAgentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateCallbackResponse> CreateCallback(Expression<Func<string>> bodycontactaddress = null, Expression<Func<string>> bodycontactcity = null, Expression<Func<int>> bodycontactcompanyid = null, Expression<Func<string>> bodycontactcontactList = null, Expression<Func<string>> bodycontactcontactid = null, Expression<Func<string>> bodycontactcountry = null, Expression<Func<string>> bodycontactfname = null, Expression<Func<string>> bodycontactlname = null, Expression<Func<string>> bodycontactother1 = null, Expression<Func<string>> bodycontactother2 = null, Expression<Func<string>> bodycontactother3 = null, Expression<Func<string>> bodycontactother4 = null, Expression<Func<string>> bodycontactother5 = null, Expression<Func<string>> bodycontactother6 = null, Expression<Func<string>> bodycontactother7 = null, Expression<Func<string>> bodycontactother8 = null, Expression<Func<string>> bodycontactother9 = null, Expression<Func<string>> bodycontactother10 = null, Expression<Func<string>> bodycontactother11 = null, Expression<Func<string>> bodycontactother12 = null, Expression<Func<string>> bodycontactother13 = null, Expression<Func<string>> bodycontactother14 = null, Expression<Func<string>> bodycontactother15 = null, Expression<Func<string>> bodycontactother16 = null, Expression<Func<string>> bodycontactother17 = null, Expression<Func<string>> bodycontactother18 = null, Expression<Func<string>> bodycontactother19 = null, Expression<Func<string>> bodycontactother20 = null, Expression<Func<string>> bodycontactother21 = null, Expression<Func<string>> bodycontactother22 = null, Expression<Func<string>> bodycontactother23 = null, Expression<Func<string>> bodycontactother24 = null, Expression<Func<string>> bodycontactother25 = null, Expression<Func<string>> bodycontactother26 = null, Expression<Func<string>> bodycontactother27 = null, Expression<Func<string>> bodycontactother28 = null, Expression<Func<string>> bodycontactother29 = null, Expression<Func<string>> bodycontactother30 = null, Expression<Func<string>> bodycontactother31 = null, Expression<Func<string>> bodycontactother32 = null, Expression<Func<string>> bodycontactother33 = null, Expression<Func<string>> bodycontactother34 = null, Expression<Func<string>> bodycontactother35 = null, Expression<Func<string>> bodycontactpostcode = null, Expression<Func<string>> bodypropertiesagent = null, Expression<Func<string>> bodypropertiesagentGroup = null, Expression<Func<string>> bodypropertiescampaign = null, Expression<Func<string>> bodypropertiescomment = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiestimestamp = null, Expression<Func<bodypropertiestypeInput>> bodypropertiestype = null)
        {
            var apiCallPath = "/create_callback";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mod"] = Convert.ToString("call");
            callPayload.Queries["cmd"] = Convert.ToString("create_callback");
            var body = new JObject();
            var bodypropCount = 0;
            var contactObject = new JObject();
            var contactObjectpropCount = 0;
            if (bodycontactaddress != null)
            {
                contactObject["address"] = CSharpExpressionConverter.ConvertToken(bodycontactaddress);
                contactObjectpropCount++;
            }

            if (bodycontactcity != null)
            {
                contactObject["city"] = CSharpExpressionConverter.ConvertToken(bodycontactcity);
                contactObjectpropCount++;
            }

            if (bodycontactcompanyid != null)
            {
                contactObject["companyid"] = CSharpExpressionConverter.ConvertToken(bodycontactcompanyid);
                contactObjectpropCount++;
            }

            if (bodycontactcontactList != null)
            {
                contactObject["contact_list"] = CSharpExpressionConverter.ConvertToken(bodycontactcontactList);
                contactObjectpropCount++;
            }

            if (bodycontactcontactid != null)
            {
                contactObject["contactid"] = CSharpExpressionConverter.ConvertToken(bodycontactcontactid);
                contactObjectpropCount++;
            }

            if (bodycontactcountry != null)
            {
                contactObject["country"] = CSharpExpressionConverter.ConvertToken(bodycontactcountry);
                contactObjectpropCount++;
            }

            if (bodycontactfname != null)
            {
                contactObject["fname"] = CSharpExpressionConverter.ConvertToken(bodycontactfname);
                contactObjectpropCount++;
            }

            if (bodycontactlname != null)
            {
                contactObject["lname"] = CSharpExpressionConverter.ConvertToken(bodycontactlname);
                contactObjectpropCount++;
            }

            if (bodycontactother1 != null)
            {
                contactObject["other1"] = CSharpExpressionConverter.ConvertToken(bodycontactother1);
                contactObjectpropCount++;
            }

            if (bodycontactother2 != null)
            {
                contactObject["other2"] = CSharpExpressionConverter.ConvertToken(bodycontactother2);
                contactObjectpropCount++;
            }

            if (bodycontactother3 != null)
            {
                contactObject["other3"] = CSharpExpressionConverter.ConvertToken(bodycontactother3);
                contactObjectpropCount++;
            }

            if (bodycontactother4 != null)
            {
                contactObject["other4"] = CSharpExpressionConverter.ConvertToken(bodycontactother4);
                contactObjectpropCount++;
            }

            if (bodycontactother5 != null)
            {
                contactObject["other5"] = CSharpExpressionConverter.ConvertToken(bodycontactother5);
                contactObjectpropCount++;
            }

            if (bodycontactother6 != null)
            {
                contactObject["other6"] = CSharpExpressionConverter.ConvertToken(bodycontactother6);
                contactObjectpropCount++;
            }

            if (bodycontactother7 != null)
            {
                contactObject["other7"] = CSharpExpressionConverter.ConvertToken(bodycontactother7);
                contactObjectpropCount++;
            }

            if (bodycontactother8 != null)
            {
                contactObject["other8"] = CSharpExpressionConverter.ConvertToken(bodycontactother8);
                contactObjectpropCount++;
            }

            if (bodycontactother9 != null)
            {
                contactObject["other9"] = CSharpExpressionConverter.ConvertToken(bodycontactother9);
                contactObjectpropCount++;
            }

            if (bodycontactother10 != null)
            {
                contactObject["other10"] = CSharpExpressionConverter.ConvertToken(bodycontactother10);
                contactObjectpropCount++;
            }

            if (bodycontactother11 != null)
            {
                contactObject["other11"] = CSharpExpressionConverter.ConvertToken(bodycontactother11);
                contactObjectpropCount++;
            }

            if (bodycontactother12 != null)
            {
                contactObject["other12"] = CSharpExpressionConverter.ConvertToken(bodycontactother12);
                contactObjectpropCount++;
            }

            if (bodycontactother13 != null)
            {
                contactObject["other13"] = CSharpExpressionConverter.ConvertToken(bodycontactother13);
                contactObjectpropCount++;
            }

            if (bodycontactother14 != null)
            {
                contactObject["other14"] = CSharpExpressionConverter.ConvertToken(bodycontactother14);
                contactObjectpropCount++;
            }

            if (bodycontactother15 != null)
            {
                contactObject["other15"] = CSharpExpressionConverter.ConvertToken(bodycontactother15);
                contactObjectpropCount++;
            }

            if (bodycontactother16 != null)
            {
                contactObject["other16"] = CSharpExpressionConverter.ConvertToken(bodycontactother16);
                contactObjectpropCount++;
            }

            if (bodycontactother17 != null)
            {
                contactObject["other17"] = CSharpExpressionConverter.ConvertToken(bodycontactother17);
                contactObjectpropCount++;
            }

            if (bodycontactother18 != null)
            {
                contactObject["other18"] = CSharpExpressionConverter.ConvertToken(bodycontactother18);
                contactObjectpropCount++;
            }

            if (bodycontactother19 != null)
            {
                contactObject["other19"] = CSharpExpressionConverter.ConvertToken(bodycontactother19);
                contactObjectpropCount++;
            }

            if (bodycontactother20 != null)
            {
                contactObject["other20"] = CSharpExpressionConverter.ConvertToken(bodycontactother20);
                contactObjectpropCount++;
            }

            if (bodycontactother21 != null)
            {
                contactObject["other21"] = CSharpExpressionConverter.ConvertToken(bodycontactother21);
                contactObjectpropCount++;
            }

            if (bodycontactother22 != null)
            {
                contactObject["other22"] = CSharpExpressionConverter.ConvertToken(bodycontactother22);
                contactObjectpropCount++;
            }

            if (bodycontactother23 != null)
            {
                contactObject["other23"] = CSharpExpressionConverter.ConvertToken(bodycontactother23);
                contactObjectpropCount++;
            }

            if (bodycontactother24 != null)
            {
                contactObject["other24"] = CSharpExpressionConverter.ConvertToken(bodycontactother24);
                contactObjectpropCount++;
            }

            if (bodycontactother25 != null)
            {
                contactObject["other25"] = CSharpExpressionConverter.ConvertToken(bodycontactother25);
                contactObjectpropCount++;
            }

            if (bodycontactother26 != null)
            {
                contactObject["other26"] = CSharpExpressionConverter.ConvertToken(bodycontactother26);
                contactObjectpropCount++;
            }

            if (bodycontactother27 != null)
            {
                contactObject["other27"] = CSharpExpressionConverter.ConvertToken(bodycontactother27);
                contactObjectpropCount++;
            }

            if (bodycontactother28 != null)
            {
                contactObject["other28"] = CSharpExpressionConverter.ConvertToken(bodycontactother28);
                contactObjectpropCount++;
            }

            if (bodycontactother29 != null)
            {
                contactObject["other29"] = CSharpExpressionConverter.ConvertToken(bodycontactother29);
                contactObjectpropCount++;
            }

            if (bodycontactother30 != null)
            {
                contactObject["other30"] = CSharpExpressionConverter.ConvertToken(bodycontactother30);
                contactObjectpropCount++;
            }

            if (bodycontactother31 != null)
            {
                contactObject["other31"] = CSharpExpressionConverter.ConvertToken(bodycontactother31);
                contactObjectpropCount++;
            }

            if (bodycontactother32 != null)
            {
                contactObject["other32"] = CSharpExpressionConverter.ConvertToken(bodycontactother32);
                contactObjectpropCount++;
            }

            if (bodycontactother33 != null)
            {
                contactObject["other33"] = CSharpExpressionConverter.ConvertToken(bodycontactother33);
                contactObjectpropCount++;
            }

            if (bodycontactother34 != null)
            {
                contactObject["other34"] = CSharpExpressionConverter.ConvertToken(bodycontactother34);
                contactObjectpropCount++;
            }

            if (bodycontactother35 != null)
            {
                contactObject["other35"] = CSharpExpressionConverter.ConvertToken(bodycontactother35);
                contactObjectpropCount++;
            }

            if (bodycontactpostcode != null)
            {
                contactObject["postcode"] = CSharpExpressionConverter.ConvertToken(bodycontactpostcode);
                contactObjectpropCount++;
            }

            if (contactObjectpropCount > 0)
            {
                body["contact"] = contactObject;
                bodypropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertiesagent != null)
            {
                propertiesObject["agent"] = CSharpExpressionConverter.ConvertToken(bodypropertiesagent);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesagentGroup != null)
            {
                propertiesObject["agent_group"] = CSharpExpressionConverter.ConvertToken(bodypropertiesagentGroup);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescampaign != null)
            {
                propertiesObject["campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertiescampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescomment != null)
            {
                propertiesObject["comment"] = CSharpExpressionConverter.ConvertToken(bodypropertiescomment);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesphone != null)
            {
                propertiesObject["phone"] = CSharpExpressionConverter.ConvertToken(bodypropertiesphone);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimestamp != null)
            {
                propertiesObject["timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestype != null)
            {
                if (bodypropertiestype != null)
                {
                    propertiesObject["type"] = CSharpExpressionConverter.Convert(bodypropertiestype);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
            }
            else
            {
                propertiesObject["type"] = "private";
                propertiesObjectpropCount++;
            }

            if (propertiesObjectpropCount > 0)
            {
                body["properties"] = propertiesObject;
                bodypropCount++;
            }

            body["return_callback_id"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCallbackResponse>(callPayload);
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
                callPayload.Queries["fname"] = CSharpExpressionConverter.ConvertO(fname);
            if (lname != null)
                callPayload.Queries["lname"] = CSharpExpressionConverter.ConvertO(lname);
            callPayload.Queries["phone"] = CSharpExpressionConverter.ConvertO(phone);
            callPayload.Queries["list"] = CSharpExpressionConverter.ConvertO(list);
            callPayload.Queries["return_value"] = Convert.ToString("1");
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (www != null)
                callPayload.Queries["www"] = CSharpExpressionConverter.ConvertO(www);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (postcode != null)
                callPayload.Queries["postcode"] = CSharpExpressionConverter.ConvertO(postcode);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (ssc != null)
                callPayload.Queries["ssc"] = CSharpExpressionConverter.ConvertO(ssc);
            if (birthyear != null)
                callPayload.Queries["birthyear"] = CSharpExpressionConverter.ConvertO(birthyear);
            if (gender != null)
                callPayload.Queries["gender"] = CSharpExpressionConverter.ConvertO(gender);
            if (companyid != null)
                callPayload.Queries["companyid"] = CSharpExpressionConverter.ConvertO(companyid);
            if (company != null)
                callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            if (vatin != null)
                callPayload.Queries["vatin"] = CSharpExpressionConverter.ConvertO(vatin);
            if (title != null)
                callPayload.Queries["title"] = CSharpExpressionConverter.ConvertO(title);
            if (comment != null)
                callPayload.Queries["comment"] = CSharpExpressionConverter.ConvertO(comment);
            if (other1 != null)
                callPayload.Queries["other1"] = CSharpExpressionConverter.ConvertO(other1);
            if (other2 != null)
                callPayload.Queries["other2"] = CSharpExpressionConverter.ConvertO(other2);
            if (other3 != null)
                callPayload.Queries["other3"] = CSharpExpressionConverter.ConvertO(other3);
            if (other4 != null)
                callPayload.Queries["other4"] = CSharpExpressionConverter.ConvertO(other4);
            if (other5 != null)
                callPayload.Queries["other5"] = CSharpExpressionConverter.ConvertO(other5);
            if (other6 != null)
                callPayload.Queries["other6"] = CSharpExpressionConverter.ConvertO(other6);
            if (other7 != null)
                callPayload.Queries["other7"] = CSharpExpressionConverter.ConvertO(other7);
            if (other8 != null)
                callPayload.Queries["other8"] = CSharpExpressionConverter.ConvertO(other8);
            if (other9 != null)
                callPayload.Queries["other9"] = CSharpExpressionConverter.ConvertO(other9);
            if (other10 != null)
                callPayload.Queries["other10"] = CSharpExpressionConverter.ConvertO(other10);
            if (other11 != null)
                callPayload.Queries["other11"] = CSharpExpressionConverter.ConvertO(other11);
            if (other12 != null)
                callPayload.Queries["other12"] = CSharpExpressionConverter.ConvertO(other12);
            if (other13 != null)
                callPayload.Queries["other13"] = CSharpExpressionConverter.ConvertO(other13);
            if (other14 != null)
                callPayload.Queries["other14"] = CSharpExpressionConverter.ConvertO(other14);
            if (other15 != null)
                callPayload.Queries["other15"] = CSharpExpressionConverter.ConvertO(other15);
            if (other16 != null)
                callPayload.Queries["other16"] = CSharpExpressionConverter.ConvertO(other16);
            if (other17 != null)
                callPayload.Queries["other17"] = CSharpExpressionConverter.ConvertO(other17);
            if (other18 != null)
                callPayload.Queries["other18"] = CSharpExpressionConverter.ConvertO(other18);
            if (other19 != null)
                callPayload.Queries["other19"] = CSharpExpressionConverter.ConvertO(other19);
            if (other20 != null)
                callPayload.Queries["other20"] = CSharpExpressionConverter.ConvertO(other20);
            if (other21 != null)
                callPayload.Queries["other21"] = CSharpExpressionConverter.ConvertO(other21);
            if (other22 != null)
                callPayload.Queries["other22"] = CSharpExpressionConverter.ConvertO(other22);
            if (other23 != null)
                callPayload.Queries["other23"] = CSharpExpressionConverter.ConvertO(other23);
            if (other24 != null)
                callPayload.Queries["other24"] = CSharpExpressionConverter.ConvertO(other24);
            if (other25 != null)
                callPayload.Queries["other25"] = CSharpExpressionConverter.ConvertO(other25);
            if (other26 != null)
                callPayload.Queries["other26"] = CSharpExpressionConverter.ConvertO(other26);
            if (other27 != null)
                callPayload.Queries["other27"] = CSharpExpressionConverter.ConvertO(other27);
            if (other28 != null)
                callPayload.Queries["other28"] = CSharpExpressionConverter.ConvertO(other28);
            if (other29 != null)
                callPayload.Queries["other29"] = CSharpExpressionConverter.ConvertO(other29);
            if (other30 != null)
                callPayload.Queries["other30"] = CSharpExpressionConverter.ConvertO(other30);
            if (other31 != null)
                callPayload.Queries["other31"] = CSharpExpressionConverter.ConvertO(other31);
            if (other32 != null)
                callPayload.Queries["other32"] = CSharpExpressionConverter.ConvertO(other32);
            if (other33 != null)
                callPayload.Queries["other33"] = CSharpExpressionConverter.ConvertO(other33);
            if (other34 != null)
                callPayload.Queries["other34"] = CSharpExpressionConverter.ConvertO(other34);
            if (other35 != null)
                callPayload.Queries["other35"] = CSharpExpressionConverter.ConvertO(other35);
            if (assignToAgent != null)
                callPayload.Queries["assign_to_agent"] = CSharpExpressionConverter.ConvertO(assignToAgent);
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
            callPayload.Queries["username"] = CSharpExpressionConverter.ConvertO(username);
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
                callPayload.Queries["fname"] = CSharpExpressionConverter.ConvertO(fname);
            if (lname != null)
                callPayload.Queries["lname"] = CSharpExpressionConverter.ConvertO(lname);
            if (phone != null)
                callPayload.Queries["phone"] = CSharpExpressionConverter.ConvertO(phone);
            if (contactListId != null)
                callPayload.Queries["contact_list_id"] = CSharpExpressionConverter.ConvertO(contactListId);
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
                accountObject["external_id"] = CSharpExpressionConverter.ConvertToken(bodyaccountexternalId);
                accountObjectpropCount++;
            }

            if (bodyaccountinboundNumber != null)
            {
                accountObject["inbound_number"] = CSharpExpressionConverter.ConvertToken(bodyaccountinboundNumber);
                accountObjectpropCount++;
            }

            if (bodyaccountlang != null)
            {
                accountObject["lang"] = CSharpExpressionConverter.ConvertToken(bodyaccountlang);
                accountObjectpropCount++;
            }

            if (bodyaccountpassword != null)
            {
                accountObject["password"] = CSharpExpressionConverter.ConvertToken(bodyaccountpassword);
                accountObjectpropCount++;
            }

            if (bodyaccounttimeZone != null)
            {
                accountObject["time_zone"] = CSharpExpressionConverter.ConvertToken(bodyaccounttimeZone);
                accountObjectpropCount++;
            }

            if (bodyaccountusername != null)
            {
                accountObject["username"] = CSharpExpressionConverter.ConvertToken(bodyaccountusername);
                accountObjectpropCount++;
            }

            if (bodyaccountvoipUsername != null)
            {
                accountObject["voip_username"] = CSharpExpressionConverter.ConvertToken(bodyaccountvoipUsername);
                accountObjectpropCount++;
            }

            if (accountObjectpropCount > 0)
            {
                body["account"] = accountObject;
                bodypropCount++;
            }

            var contactInformationObject = new JObject();
            var contactInformationObjectpropCount = 0;
            if (bodycontactInformationaddress != null)
            {
                contactInformationObject["address"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationaddress);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationcity != null)
            {
                contactInformationObject["city"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationcity);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationcountry != null)
            {
                contactInformationObject["country"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationcountry);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationeContacts != null)
            {
                contactInformationObject["e_contacts"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationeContacts);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationemail != null)
            {
                contactInformationObject["email"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationemail);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationname != null)
            {
                contactInformationObject["name"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationname);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationphone != null)
            {
                contactInformationObject["phone"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationphone);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationpostal != null)
            {
                contactInformationObject["postal"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationpostal);
                contactInformationObjectpropCount++;
            }

            if (bodycontactInformationworkphone != null)
            {
                contactInformationObject["workphone"] = CSharpExpressionConverter.ConvertToken(bodycontactInformationworkphone);
                contactInformationObjectpropCount++;
            }

            if (contactInformationObjectpropCount > 0)
            {
                body["contact_information"] = contactInformationObject;
                bodypropCount++;
            }

            if (bodydisable != null)
            {
                if (bodydisable != null)
                {
                    body["disable"] = CSharpExpressionConverter.ConvertToken(bodydisable);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["disable"] = false;
                bodypropCount++;
            }

            var employmentObject = new JObject();
            var employmentObjectpropCount = 0;
            if (bodyemploymentagentGroupId != null)
            {
                employmentObject["agent_group_id"] = CSharpExpressionConverter.ConvertToken(bodyemploymentagentGroupId);
                employmentObjectpropCount++;
            }

            if (bodyemploymentbankAcc != null)
            {
                employmentObject["bank_acc"] = CSharpExpressionConverter.ConvertToken(bodyemploymentbankAcc);
                employmentObjectpropCount++;
            }

            if (bodyemploymentdescription != null)
            {
                employmentObject["description"] = CSharpExpressionConverter.ConvertToken(bodyemploymentdescription);
                employmentObjectpropCount++;
            }

            if (bodyemploymentemployment != null)
            {
                employmentObject["employment"] = CSharpExpressionConverter.Convert(bodyemploymentemployment);
                employmentObjectpropCount++;
            }

            if (bodyemploymentemploymentStart != null)
            {
                employmentObject["employment_start"] = CSharpExpressionConverter.ConvertToken(bodyemploymentemploymentStart);
                employmentObjectpropCount++;
            }

            if (bodyemploymentoffice != null)
            {
                employmentObject["office"] = CSharpExpressionConverter.ConvertToken(bodyemploymentoffice);
                employmentObjectpropCount++;
            }

            if (bodyemploymentssn != null)
            {
                employmentObject["ssn"] = CSharpExpressionConverter.ConvertToken(bodyemploymentssn);
                employmentObjectpropCount++;
            }

            if (bodyemploymentworkshift != null)
            {
                employmentObject["workshift"] = CSharpExpressionConverter.ConvertToken(bodyemploymentworkshift);
                employmentObjectpropCount++;
            }

            if (employmentObjectpropCount > 0)
            {
                body["employment"] = employmentObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
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
            callPayload.Queries["contact_id"] = CSharpExpressionConverter.ConvertO(contactId);
            if (fname != null)
                callPayload.Queries["fname"] = CSharpExpressionConverter.ConvertO(fname);
            if (lname != null)
                callPayload.Queries["lname"] = CSharpExpressionConverter.ConvertO(lname);
            if (phone != null)
                callPayload.Queries["phone"] = CSharpExpressionConverter.ConvertO(phone);
            if (birthyear != null)
                callPayload.Queries["birthyear"] = CSharpExpressionConverter.ConvertO(birthyear);
            if (gender != null)
                callPayload.Queries["gender"] = CSharpExpressionConverter.ConvertO(gender);
            if (email != null)
                callPayload.Queries["email"] = CSharpExpressionConverter.ConvertO(email);
            if (www != null)
                callPayload.Queries["www"] = CSharpExpressionConverter.ConvertO(www);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (postcode != null)
                callPayload.Queries["postcode"] = CSharpExpressionConverter.ConvertO(postcode);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (ssc != null)
                callPayload.Queries["ssc"] = CSharpExpressionConverter.ConvertO(ssc);
            if (companyid != null)
                callPayload.Queries["companyid"] = CSharpExpressionConverter.ConvertO(companyid);
            if (company != null)
                callPayload.Queries["company"] = CSharpExpressionConverter.ConvertO(company);
            if (vatin != null)
                callPayload.Queries["vatin"] = CSharpExpressionConverter.ConvertO(vatin);
            if (title != null)
                callPayload.Queries["title"] = CSharpExpressionConverter.ConvertO(title);
            if (comment != null)
                callPayload.Queries["comment"] = CSharpExpressionConverter.ConvertO(comment);
            if (other1 != null)
                callPayload.Queries["other1"] = CSharpExpressionConverter.ConvertO(other1);
            if (other2 != null)
                callPayload.Queries["other2"] = CSharpExpressionConverter.ConvertO(other2);
            if (other3 != null)
                callPayload.Queries["other3"] = CSharpExpressionConverter.ConvertO(other3);
            if (other4 != null)
                callPayload.Queries["other4"] = CSharpExpressionConverter.ConvertO(other4);
            if (other5 != null)
                callPayload.Queries["other5"] = CSharpExpressionConverter.ConvertO(other5);
            if (other6 != null)
                callPayload.Queries["other6"] = CSharpExpressionConverter.ConvertO(other6);
            if (other7 != null)
                callPayload.Queries["other7"] = CSharpExpressionConverter.ConvertO(other7);
            if (other8 != null)
                callPayload.Queries["other8"] = CSharpExpressionConverter.ConvertO(other8);
            if (other9 != null)
                callPayload.Queries["other9"] = CSharpExpressionConverter.ConvertO(other9);
            if (other10 != null)
                callPayload.Queries["other10"] = CSharpExpressionConverter.ConvertO(other10);
            if (other11 != null)
                callPayload.Queries["other11"] = CSharpExpressionConverter.ConvertO(other11);
            if (other12 != null)
                callPayload.Queries["other12"] = CSharpExpressionConverter.ConvertO(other12);
            if (other13 != null)
                callPayload.Queries["other13"] = CSharpExpressionConverter.ConvertO(other13);
            if (other14 != null)
                callPayload.Queries["other14"] = CSharpExpressionConverter.ConvertO(other14);
            if (other15 != null)
                callPayload.Queries["other15"] = CSharpExpressionConverter.ConvertO(other15);
            if (other16 != null)
                callPayload.Queries["other16"] = CSharpExpressionConverter.ConvertO(other16);
            if (other17 != null)
                callPayload.Queries["other17"] = CSharpExpressionConverter.ConvertO(other17);
            if (other18 != null)
                callPayload.Queries["other18"] = CSharpExpressionConverter.ConvertO(other18);
            if (other19 != null)
                callPayload.Queries["other19"] = CSharpExpressionConverter.ConvertO(other19);
            if (other20 != null)
                callPayload.Queries["other20"] = CSharpExpressionConverter.ConvertO(other20);
            if (other21 != null)
                callPayload.Queries["other21"] = CSharpExpressionConverter.ConvertO(other21);
            if (other22 != null)
                callPayload.Queries["other22"] = CSharpExpressionConverter.ConvertO(other22);
            if (other23 != null)
                callPayload.Queries["other23"] = CSharpExpressionConverter.ConvertO(other23);
            if (other24 != null)
                callPayload.Queries["other24"] = CSharpExpressionConverter.ConvertO(other24);
            if (other25 != null)
                callPayload.Queries["other25"] = CSharpExpressionConverter.ConvertO(other25);
            if (other26 != null)
                callPayload.Queries["other26"] = CSharpExpressionConverter.ConvertO(other26);
            if (other27 != null)
                callPayload.Queries["other27"] = CSharpExpressionConverter.ConvertO(other27);
            if (other28 != null)
                callPayload.Queries["other28"] = CSharpExpressionConverter.ConvertO(other28);
            if (other29 != null)
                callPayload.Queries["other29"] = CSharpExpressionConverter.ConvertO(other29);
            if (other30 != null)
                callPayload.Queries["other30"] = CSharpExpressionConverter.ConvertO(other30);
            if (other31 != null)
                callPayload.Queries["other31"] = CSharpExpressionConverter.ConvertO(other31);
            if (other32 != null)
                callPayload.Queries["other32"] = CSharpExpressionConverter.ConvertO(other32);
            if (other33 != null)
                callPayload.Queries["other33"] = CSharpExpressionConverter.ConvertO(other33);
            if (other34 != null)
                callPayload.Queries["other34"] = CSharpExpressionConverter.ConvertO(other34);
            if (other35 != null)
                callPayload.Queries["other35"] = CSharpExpressionConverter.ConvertO(other35);
            if (list != null)
                callPayload.Queries["list"] = CSharpExpressionConverter.ConvertO(list);
            callPayload.Queries["order"] = Convert.ToString("last");
            if (order != null)
                callPayload.Queries["order"] = CSharpExpressionConverter.Convert(order);
            if (assignToAgent != null)
                callPayload.Queries["assign_to_agent"] = CSharpExpressionConverter.ConvertO(assignToAgent);
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

    public class CreateAgentResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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

    public class CreateCallbackResponse
    {
        [JsonProperty("callback_id")]
        public int CallbackId { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public enum bodypropertiestypeInput
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