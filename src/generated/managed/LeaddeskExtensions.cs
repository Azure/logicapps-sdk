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
        public IBodyWorkflowAction<AgentCampaignAccessResponse> AgentCampaignAccess([WorkflowExpression] Func<int> agentId, [WorkflowExpression] Func<int> campaignId, [WorkflowExpression] Func<typeInput> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/agent_campaign_access";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("modify_campaign_access");
                callPayload.Queries["agent_id"] = SourceExpressionConverter.ConvertO(agentId);
                callPayload.Queries["campaign_id"] = SourceExpressionConverter.ConvertO(campaignId);
                callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<AgentCampaignAccessResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent([WorkflowExpression] Func<string> bodyaccountexternalId = null, [WorkflowExpression] Func<string> bodyaccountinboundNumber = null, [WorkflowExpression] Func<string> bodyaccountlang = null, [WorkflowExpression] Func<string> bodyaccountpassword = null, [WorkflowExpression] Func<string> bodyaccounttimeZone = null, [WorkflowExpression] Func<string> bodyaccountusername = null, [WorkflowExpression] Func<string> bodyaccountvoipUsername = null, [WorkflowExpression] Func<string> bodycontactInformationaddress = null, [WorkflowExpression] Func<string> bodycontactInformationcity = null, [WorkflowExpression] Func<string> bodycontactInformationcountry = null, [WorkflowExpression] Func<string> bodycontactInformationeContacts = null, [WorkflowExpression] Func<string> bodycontactInformationemail = null, [WorkflowExpression] Func<string> bodycontactInformationname = null, [WorkflowExpression] Func<string> bodycontactInformationphone = null, [WorkflowExpression] Func<string> bodycontactInformationpostal = null, [WorkflowExpression] Func<string> bodycontactInformationworkphone = null, [WorkflowExpression] Func<int> bodyemploymentagentGroupId = null, [WorkflowExpression] Func<string> bodyemploymentbankAcc = null, [WorkflowExpression] Func<string> bodyemploymentdescription = null, [WorkflowExpression] Func<bodyemploymentemploymentInput> bodyemploymentemployment = null, [WorkflowExpression] Func<string> bodyemploymentemploymentStart = null, [WorkflowExpression] Func<string> bodyemploymentoffice = null, [WorkflowExpression] Func<string> bodyemploymentssn = null, [WorkflowExpression] Func<string> bodyemploymentworkshift = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    accountObject["external_id"] = SourceExpressionConverter.ConvertToken(bodyaccountexternalId);
                    accountObjectpropCount++;
                }

                if (bodyaccountinboundNumber != null)
                {
                    accountObject["inbound_number"] = SourceExpressionConverter.ConvertToken(bodyaccountinboundNumber);
                    accountObjectpropCount++;
                }

                if (bodyaccountlang != null)
                {
                    accountObject["lang"] = SourceExpressionConverter.ConvertToken(bodyaccountlang);
                    accountObjectpropCount++;
                }

                accountObject["level"] = "agent";
                accountObjectpropCount++;
                if (bodyaccountpassword != null)
                {
                    accountObject["password"] = SourceExpressionConverter.ConvertToken(bodyaccountpassword);
                    accountObjectpropCount++;
                }

                if (bodyaccounttimeZone != null)
                {
                    if (bodyaccounttimeZone != null)
                    {
                        accountObject["time_zone"] = SourceExpressionConverter.ConvertToken(bodyaccounttimeZone);
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
                    accountObject["username"] = SourceExpressionConverter.ConvertToken(bodyaccountusername);
                    accountObjectpropCount++;
                }

                if (bodyaccountvoipUsername != null)
                {
                    accountObject["voip_username"] = SourceExpressionConverter.ConvertToken(bodyaccountvoipUsername);
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
                    contactInformationObject["address"] = SourceExpressionConverter.ConvertToken(bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = SourceExpressionConverter.ConvertToken(bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = SourceExpressionConverter.ConvertToken(bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = SourceExpressionConverter.ConvertToken(bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = SourceExpressionConverter.ConvertToken(bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = SourceExpressionConverter.ConvertToken(bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = SourceExpressionConverter.ConvertToken(bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = SourceExpressionConverter.ConvertToken(bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = SourceExpressionConverter.ConvertToken(bodycontactInformationworkphone);
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
                    employmentObject["agent_group_id"] = SourceExpressionConverter.ConvertToken(bodyemploymentagentGroupId);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentbankAcc != null)
                {
                    employmentObject["bank_acc"] = SourceExpressionConverter.ConvertToken(bodyemploymentbankAcc);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentdescription != null)
                {
                    employmentObject["description"] = SourceExpressionConverter.ConvertToken(bodyemploymentdescription);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentemployment != null)
                {
                    if (bodyemploymentemployment != null)
                    {
                        employmentObject["employment"] = SourceExpressionConverter.Convert(bodyemploymentemployment);
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
                    employmentObject["employment_start"] = SourceExpressionConverter.ConvertToken(bodyemploymentemploymentStart);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentoffice != null)
                {
                    employmentObject["office"] = SourceExpressionConverter.ConvertToken(bodyemploymentoffice);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentssn != null)
                {
                    employmentObject["ssn"] = SourceExpressionConverter.ConvertToken(bodyemploymentssn);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentworkshift != null)
                {
                    employmentObject["workshift"] = SourceExpressionConverter.ConvertToken(bodyemploymentworkshift);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateAgentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateCallbackResponse> CreateCallback([WorkflowExpression] Func<string> bodycontactaddress = null, [WorkflowExpression] Func<string> bodycontactcity = null, [WorkflowExpression] Func<int> bodycontactcompanyid = null, [WorkflowExpression] Func<string> bodycontactcontactList = null, [WorkflowExpression] Func<string> bodycontactcontactid = null, [WorkflowExpression] Func<string> bodycontactcountry = null, [WorkflowExpression] Func<string> bodycontactfname = null, [WorkflowExpression] Func<string> bodycontactlname = null, [WorkflowExpression] Func<string> bodycontactother1 = null, [WorkflowExpression] Func<string> bodycontactother2 = null, [WorkflowExpression] Func<string> bodycontactother3 = null, [WorkflowExpression] Func<string> bodycontactother4 = null, [WorkflowExpression] Func<string> bodycontactother5 = null, [WorkflowExpression] Func<string> bodycontactother6 = null, [WorkflowExpression] Func<string> bodycontactother7 = null, [WorkflowExpression] Func<string> bodycontactother8 = null, [WorkflowExpression] Func<string> bodycontactother9 = null, [WorkflowExpression] Func<string> bodycontactother10 = null, [WorkflowExpression] Func<string> bodycontactother11 = null, [WorkflowExpression] Func<string> bodycontactother12 = null, [WorkflowExpression] Func<string> bodycontactother13 = null, [WorkflowExpression] Func<string> bodycontactother14 = null, [WorkflowExpression] Func<string> bodycontactother15 = null, [WorkflowExpression] Func<string> bodycontactother16 = null, [WorkflowExpression] Func<string> bodycontactother17 = null, [WorkflowExpression] Func<string> bodycontactother18 = null, [WorkflowExpression] Func<string> bodycontactother19 = null, [WorkflowExpression] Func<string> bodycontactother20 = null, [WorkflowExpression] Func<string> bodycontactother21 = null, [WorkflowExpression] Func<string> bodycontactother22 = null, [WorkflowExpression] Func<string> bodycontactother23 = null, [WorkflowExpression] Func<string> bodycontactother24 = null, [WorkflowExpression] Func<string> bodycontactother25 = null, [WorkflowExpression] Func<string> bodycontactother26 = null, [WorkflowExpression] Func<string> bodycontactother27 = null, [WorkflowExpression] Func<string> bodycontactother28 = null, [WorkflowExpression] Func<string> bodycontactother29 = null, [WorkflowExpression] Func<string> bodycontactother30 = null, [WorkflowExpression] Func<string> bodycontactother31 = null, [WorkflowExpression] Func<string> bodycontactother32 = null, [WorkflowExpression] Func<string> bodycontactother33 = null, [WorkflowExpression] Func<string> bodycontactother34 = null, [WorkflowExpression] Func<string> bodycontactother35 = null, [WorkflowExpression] Func<string> bodycontactpostcode = null, [WorkflowExpression] Func<string> bodypropertiesagent = null, [WorkflowExpression] Func<string> bodypropertiesagentGroup = null, [WorkflowExpression] Func<string> bodypropertiescampaign = null, [WorkflowExpression] Func<string> bodypropertiescomment = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiestimestamp = null, [WorkflowExpression] Func<bodypropertiestypeInput> bodypropertiestype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    contactObject["address"] = SourceExpressionConverter.ConvertToken(bodycontactaddress);
                    contactObjectpropCount++;
                }

                if (bodycontactcity != null)
                {
                    contactObject["city"] = SourceExpressionConverter.ConvertToken(bodycontactcity);
                    contactObjectpropCount++;
                }

                if (bodycontactcompanyid != null)
                {
                    contactObject["companyid"] = SourceExpressionConverter.ConvertToken(bodycontactcompanyid);
                    contactObjectpropCount++;
                }

                if (bodycontactcontactList != null)
                {
                    contactObject["contact_list"] = SourceExpressionConverter.ConvertToken(bodycontactcontactList);
                    contactObjectpropCount++;
                }

                if (bodycontactcontactid != null)
                {
                    contactObject["contactid"] = SourceExpressionConverter.ConvertToken(bodycontactcontactid);
                    contactObjectpropCount++;
                }

                if (bodycontactcountry != null)
                {
                    contactObject["country"] = SourceExpressionConverter.ConvertToken(bodycontactcountry);
                    contactObjectpropCount++;
                }

                if (bodycontactfname != null)
                {
                    contactObject["fname"] = SourceExpressionConverter.ConvertToken(bodycontactfname);
                    contactObjectpropCount++;
                }

                if (bodycontactlname != null)
                {
                    contactObject["lname"] = SourceExpressionConverter.ConvertToken(bodycontactlname);
                    contactObjectpropCount++;
                }

                if (bodycontactother1 != null)
                {
                    contactObject["other1"] = SourceExpressionConverter.ConvertToken(bodycontactother1);
                    contactObjectpropCount++;
                }

                if (bodycontactother2 != null)
                {
                    contactObject["other2"] = SourceExpressionConverter.ConvertToken(bodycontactother2);
                    contactObjectpropCount++;
                }

                if (bodycontactother3 != null)
                {
                    contactObject["other3"] = SourceExpressionConverter.ConvertToken(bodycontactother3);
                    contactObjectpropCount++;
                }

                if (bodycontactother4 != null)
                {
                    contactObject["other4"] = SourceExpressionConverter.ConvertToken(bodycontactother4);
                    contactObjectpropCount++;
                }

                if (bodycontactother5 != null)
                {
                    contactObject["other5"] = SourceExpressionConverter.ConvertToken(bodycontactother5);
                    contactObjectpropCount++;
                }

                if (bodycontactother6 != null)
                {
                    contactObject["other6"] = SourceExpressionConverter.ConvertToken(bodycontactother6);
                    contactObjectpropCount++;
                }

                if (bodycontactother7 != null)
                {
                    contactObject["other7"] = SourceExpressionConverter.ConvertToken(bodycontactother7);
                    contactObjectpropCount++;
                }

                if (bodycontactother8 != null)
                {
                    contactObject["other8"] = SourceExpressionConverter.ConvertToken(bodycontactother8);
                    contactObjectpropCount++;
                }

                if (bodycontactother9 != null)
                {
                    contactObject["other9"] = SourceExpressionConverter.ConvertToken(bodycontactother9);
                    contactObjectpropCount++;
                }

                if (bodycontactother10 != null)
                {
                    contactObject["other10"] = SourceExpressionConverter.ConvertToken(bodycontactother10);
                    contactObjectpropCount++;
                }

                if (bodycontactother11 != null)
                {
                    contactObject["other11"] = SourceExpressionConverter.ConvertToken(bodycontactother11);
                    contactObjectpropCount++;
                }

                if (bodycontactother12 != null)
                {
                    contactObject["other12"] = SourceExpressionConverter.ConvertToken(bodycontactother12);
                    contactObjectpropCount++;
                }

                if (bodycontactother13 != null)
                {
                    contactObject["other13"] = SourceExpressionConverter.ConvertToken(bodycontactother13);
                    contactObjectpropCount++;
                }

                if (bodycontactother14 != null)
                {
                    contactObject["other14"] = SourceExpressionConverter.ConvertToken(bodycontactother14);
                    contactObjectpropCount++;
                }

                if (bodycontactother15 != null)
                {
                    contactObject["other15"] = SourceExpressionConverter.ConvertToken(bodycontactother15);
                    contactObjectpropCount++;
                }

                if (bodycontactother16 != null)
                {
                    contactObject["other16"] = SourceExpressionConverter.ConvertToken(bodycontactother16);
                    contactObjectpropCount++;
                }

                if (bodycontactother17 != null)
                {
                    contactObject["other17"] = SourceExpressionConverter.ConvertToken(bodycontactother17);
                    contactObjectpropCount++;
                }

                if (bodycontactother18 != null)
                {
                    contactObject["other18"] = SourceExpressionConverter.ConvertToken(bodycontactother18);
                    contactObjectpropCount++;
                }

                if (bodycontactother19 != null)
                {
                    contactObject["other19"] = SourceExpressionConverter.ConvertToken(bodycontactother19);
                    contactObjectpropCount++;
                }

                if (bodycontactother20 != null)
                {
                    contactObject["other20"] = SourceExpressionConverter.ConvertToken(bodycontactother20);
                    contactObjectpropCount++;
                }

                if (bodycontactother21 != null)
                {
                    contactObject["other21"] = SourceExpressionConverter.ConvertToken(bodycontactother21);
                    contactObjectpropCount++;
                }

                if (bodycontactother22 != null)
                {
                    contactObject["other22"] = SourceExpressionConverter.ConvertToken(bodycontactother22);
                    contactObjectpropCount++;
                }

                if (bodycontactother23 != null)
                {
                    contactObject["other23"] = SourceExpressionConverter.ConvertToken(bodycontactother23);
                    contactObjectpropCount++;
                }

                if (bodycontactother24 != null)
                {
                    contactObject["other24"] = SourceExpressionConverter.ConvertToken(bodycontactother24);
                    contactObjectpropCount++;
                }

                if (bodycontactother25 != null)
                {
                    contactObject["other25"] = SourceExpressionConverter.ConvertToken(bodycontactother25);
                    contactObjectpropCount++;
                }

                if (bodycontactother26 != null)
                {
                    contactObject["other26"] = SourceExpressionConverter.ConvertToken(bodycontactother26);
                    contactObjectpropCount++;
                }

                if (bodycontactother27 != null)
                {
                    contactObject["other27"] = SourceExpressionConverter.ConvertToken(bodycontactother27);
                    contactObjectpropCount++;
                }

                if (bodycontactother28 != null)
                {
                    contactObject["other28"] = SourceExpressionConverter.ConvertToken(bodycontactother28);
                    contactObjectpropCount++;
                }

                if (bodycontactother29 != null)
                {
                    contactObject["other29"] = SourceExpressionConverter.ConvertToken(bodycontactother29);
                    contactObjectpropCount++;
                }

                if (bodycontactother30 != null)
                {
                    contactObject["other30"] = SourceExpressionConverter.ConvertToken(bodycontactother30);
                    contactObjectpropCount++;
                }

                if (bodycontactother31 != null)
                {
                    contactObject["other31"] = SourceExpressionConverter.ConvertToken(bodycontactother31);
                    contactObjectpropCount++;
                }

                if (bodycontactother32 != null)
                {
                    contactObject["other32"] = SourceExpressionConverter.ConvertToken(bodycontactother32);
                    contactObjectpropCount++;
                }

                if (bodycontactother33 != null)
                {
                    contactObject["other33"] = SourceExpressionConverter.ConvertToken(bodycontactother33);
                    contactObjectpropCount++;
                }

                if (bodycontactother34 != null)
                {
                    contactObject["other34"] = SourceExpressionConverter.ConvertToken(bodycontactother34);
                    contactObjectpropCount++;
                }

                if (bodycontactother35 != null)
                {
                    contactObject["other35"] = SourceExpressionConverter.ConvertToken(bodycontactother35);
                    contactObjectpropCount++;
                }

                if (bodycontactpostcode != null)
                {
                    contactObject["postcode"] = SourceExpressionConverter.ConvertToken(bodycontactpostcode);
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
                    propertiesObject["agent"] = SourceExpressionConverter.ConvertToken(bodypropertiesagent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesagentGroup != null)
                {
                    propertiesObject["agent_group"] = SourceExpressionConverter.ConvertToken(bodypropertiesagentGroup);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescampaign != null)
                {
                    propertiesObject["campaign"] = SourceExpressionConverter.ConvertToken(bodypropertiescampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescomment != null)
                {
                    propertiesObject["comment"] = SourceExpressionConverter.ConvertToken(bodypropertiescomment);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = SourceExpressionConverter.ConvertToken(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimestamp != null)
                {
                    propertiesObject["timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertiestimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestype != null)
                {
                    if (bodypropertiestype != null)
                    {
                        propertiesObject["type"] = SourceExpressionConverter.Convert(bodypropertiestype);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateCallbackResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> list, [WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> www = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> postcode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> ssc = null, [WorkflowExpression] Func<string> birthyear = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> companyid = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<string> vatin = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> other1 = null, [WorkflowExpression] Func<string> other2 = null, [WorkflowExpression] Func<string> other3 = null, [WorkflowExpression] Func<string> other4 = null, [WorkflowExpression] Func<string> other5 = null, [WorkflowExpression] Func<string> other6 = null, [WorkflowExpression] Func<string> other7 = null, [WorkflowExpression] Func<string> other8 = null, [WorkflowExpression] Func<string> other9 = null, [WorkflowExpression] Func<string> other10 = null, [WorkflowExpression] Func<string> other11 = null, [WorkflowExpression] Func<string> other12 = null, [WorkflowExpression] Func<string> other13 = null, [WorkflowExpression] Func<string> other14 = null, [WorkflowExpression] Func<string> other15 = null, [WorkflowExpression] Func<string> other16 = null, [WorkflowExpression] Func<string> other17 = null, [WorkflowExpression] Func<string> other18 = null, [WorkflowExpression] Func<string> other19 = null, [WorkflowExpression] Func<string> other20 = null, [WorkflowExpression] Func<string> other21 = null, [WorkflowExpression] Func<string> other22 = null, [WorkflowExpression] Func<string> other23 = null, [WorkflowExpression] Func<string> other24 = null, [WorkflowExpression] Func<string> other25 = null, [WorkflowExpression] Func<string> other26 = null, [WorkflowExpression] Func<string> other27 = null, [WorkflowExpression] Func<string> other28 = null, [WorkflowExpression] Func<string> other29 = null, [WorkflowExpression] Func<string> other30 = null, [WorkflowExpression] Func<string> other31 = null, [WorkflowExpression] Func<string> other32 = null, [WorkflowExpression] Func<string> other33 = null, [WorkflowExpression] Func<string> other34 = null, [WorkflowExpression] Func<string> other35 = null, [WorkflowExpression] Func<string> assignToAgent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/create_contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("add");
                if (fname != null)
                    callPayload.Queries["fname"] = SourceExpressionConverter.ConvertO(fname);
                if (lname != null)
                    callPayload.Queries["lname"] = SourceExpressionConverter.ConvertO(lname);
                callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                callPayload.Queries["list"] = SourceExpressionConverter.ConvertO(list);
                callPayload.Queries["return_value"] = Convert.ToString("1");
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (www != null)
                    callPayload.Queries["www"] = SourceExpressionConverter.ConvertO(www);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (postcode != null)
                    callPayload.Queries["postcode"] = SourceExpressionConverter.ConvertO(postcode);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (ssc != null)
                    callPayload.Queries["ssc"] = SourceExpressionConverter.ConvertO(ssc);
                if (birthyear != null)
                    callPayload.Queries["birthyear"] = SourceExpressionConverter.ConvertO(birthyear);
                if (gender != null)
                    callPayload.Queries["gender"] = SourceExpressionConverter.ConvertO(gender);
                if (companyid != null)
                    callPayload.Queries["companyid"] = SourceExpressionConverter.ConvertO(companyid);
                if (company != null)
                    callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                if (vatin != null)
                    callPayload.Queries["vatin"] = SourceExpressionConverter.ConvertO(vatin);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                if (other1 != null)
                    callPayload.Queries["other1"] = SourceExpressionConverter.ConvertO(other1);
                if (other2 != null)
                    callPayload.Queries["other2"] = SourceExpressionConverter.ConvertO(other2);
                if (other3 != null)
                    callPayload.Queries["other3"] = SourceExpressionConverter.ConvertO(other3);
                if (other4 != null)
                    callPayload.Queries["other4"] = SourceExpressionConverter.ConvertO(other4);
                if (other5 != null)
                    callPayload.Queries["other5"] = SourceExpressionConverter.ConvertO(other5);
                if (other6 != null)
                    callPayload.Queries["other6"] = SourceExpressionConverter.ConvertO(other6);
                if (other7 != null)
                    callPayload.Queries["other7"] = SourceExpressionConverter.ConvertO(other7);
                if (other8 != null)
                    callPayload.Queries["other8"] = SourceExpressionConverter.ConvertO(other8);
                if (other9 != null)
                    callPayload.Queries["other9"] = SourceExpressionConverter.ConvertO(other9);
                if (other10 != null)
                    callPayload.Queries["other10"] = SourceExpressionConverter.ConvertO(other10);
                if (other11 != null)
                    callPayload.Queries["other11"] = SourceExpressionConverter.ConvertO(other11);
                if (other12 != null)
                    callPayload.Queries["other12"] = SourceExpressionConverter.ConvertO(other12);
                if (other13 != null)
                    callPayload.Queries["other13"] = SourceExpressionConverter.ConvertO(other13);
                if (other14 != null)
                    callPayload.Queries["other14"] = SourceExpressionConverter.ConvertO(other14);
                if (other15 != null)
                    callPayload.Queries["other15"] = SourceExpressionConverter.ConvertO(other15);
                if (other16 != null)
                    callPayload.Queries["other16"] = SourceExpressionConverter.ConvertO(other16);
                if (other17 != null)
                    callPayload.Queries["other17"] = SourceExpressionConverter.ConvertO(other17);
                if (other18 != null)
                    callPayload.Queries["other18"] = SourceExpressionConverter.ConvertO(other18);
                if (other19 != null)
                    callPayload.Queries["other19"] = SourceExpressionConverter.ConvertO(other19);
                if (other20 != null)
                    callPayload.Queries["other20"] = SourceExpressionConverter.ConvertO(other20);
                if (other21 != null)
                    callPayload.Queries["other21"] = SourceExpressionConverter.ConvertO(other21);
                if (other22 != null)
                    callPayload.Queries["other22"] = SourceExpressionConverter.ConvertO(other22);
                if (other23 != null)
                    callPayload.Queries["other23"] = SourceExpressionConverter.ConvertO(other23);
                if (other24 != null)
                    callPayload.Queries["other24"] = SourceExpressionConverter.ConvertO(other24);
                if (other25 != null)
                    callPayload.Queries["other25"] = SourceExpressionConverter.ConvertO(other25);
                if (other26 != null)
                    callPayload.Queries["other26"] = SourceExpressionConverter.ConvertO(other26);
                if (other27 != null)
                    callPayload.Queries["other27"] = SourceExpressionConverter.ConvertO(other27);
                if (other28 != null)
                    callPayload.Queries["other28"] = SourceExpressionConverter.ConvertO(other28);
                if (other29 != null)
                    callPayload.Queries["other29"] = SourceExpressionConverter.ConvertO(other29);
                if (other30 != null)
                    callPayload.Queries["other30"] = SourceExpressionConverter.ConvertO(other30);
                if (other31 != null)
                    callPayload.Queries["other31"] = SourceExpressionConverter.ConvertO(other31);
                if (other32 != null)
                    callPayload.Queries["other32"] = SourceExpressionConverter.ConvertO(other32);
                if (other33 != null)
                    callPayload.Queries["other33"] = SourceExpressionConverter.ConvertO(other33);
                if (other34 != null)
                    callPayload.Queries["other34"] = SourceExpressionConverter.ConvertO(other34);
                if (other35 != null)
                    callPayload.Queries["other35"] = SourceExpressionConverter.ConvertO(other35);
                if (assignToAgent != null)
                    callPayload.Queries["assign_to_agent"] = SourceExpressionConverter.ConvertO(assignToAgent);
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindAgentResponse> FindAgent([WorkflowExpression] Func<string> username)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/find_agent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("find");
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                return callPayload;
            }

            return new ApiConnectionAction<FindAgentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<FindContactResponse> FindContact([WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<int> phone = null, [WorkflowExpression] Func<int> contactListId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/find_contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("find");
                if (fname != null)
                    callPayload.Queries["fname"] = SourceExpressionConverter.ConvertO(fname);
                if (lname != null)
                    callPayload.Queries["lname"] = SourceExpressionConverter.ConvertO(lname);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (contactListId != null)
                    callPayload.Queries["contact_list_id"] = SourceExpressionConverter.ConvertO(contactListId);
                return callPayload;
            }

            return new ApiConnectionAction<FindContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyAgentResponse> ModifyAgent([WorkflowExpression] Func<int> bodyid, [WorkflowExpression] Func<string> bodyaccountexternalId = null, [WorkflowExpression] Func<string> bodyaccountinboundNumber = null, [WorkflowExpression] Func<int> bodyaccountlang = null, [WorkflowExpression] Func<string> bodyaccountpassword = null, [WorkflowExpression] Func<string> bodyaccounttimeZone = null, [WorkflowExpression] Func<string> bodyaccountusername = null, [WorkflowExpression] Func<string> bodyaccountvoipUsername = null, [WorkflowExpression] Func<string> bodycontactInformationaddress = null, [WorkflowExpression] Func<string> bodycontactInformationcity = null, [WorkflowExpression] Func<string> bodycontactInformationcountry = null, [WorkflowExpression] Func<string> bodycontactInformationeContacts = null, [WorkflowExpression] Func<string> bodycontactInformationemail = null, [WorkflowExpression] Func<string> bodycontactInformationname = null, [WorkflowExpression] Func<string> bodycontactInformationphone = null, [WorkflowExpression] Func<string> bodycontactInformationpostal = null, [WorkflowExpression] Func<string> bodycontactInformationworkphone = null, [WorkflowExpression] Func<bool> bodydisable = null, [WorkflowExpression] Func<int> bodyemploymentagentGroupId = null, [WorkflowExpression] Func<string> bodyemploymentbankAcc = null, [WorkflowExpression] Func<string> bodyemploymentdescription = null, [WorkflowExpression] Func<bodyemploymentemploymentInput> bodyemploymentemployment = null, [WorkflowExpression] Func<string> bodyemploymentemploymentStart = null, [WorkflowExpression] Func<string> bodyemploymentoffice = null, [WorkflowExpression] Func<string> bodyemploymentssn = null, [WorkflowExpression] Func<string> bodyemploymentworkshift = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    accountObject["external_id"] = SourceExpressionConverter.ConvertToken(bodyaccountexternalId);
                    accountObjectpropCount++;
                }

                if (bodyaccountinboundNumber != null)
                {
                    accountObject["inbound_number"] = SourceExpressionConverter.ConvertToken(bodyaccountinboundNumber);
                    accountObjectpropCount++;
                }

                if (bodyaccountlang != null)
                {
                    accountObject["lang"] = SourceExpressionConverter.ConvertToken(bodyaccountlang);
                    accountObjectpropCount++;
                }

                if (bodyaccountpassword != null)
                {
                    accountObject["password"] = SourceExpressionConverter.ConvertToken(bodyaccountpassword);
                    accountObjectpropCount++;
                }

                if (bodyaccounttimeZone != null)
                {
                    accountObject["time_zone"] = SourceExpressionConverter.ConvertToken(bodyaccounttimeZone);
                    accountObjectpropCount++;
                }

                if (bodyaccountusername != null)
                {
                    accountObject["username"] = SourceExpressionConverter.ConvertToken(bodyaccountusername);
                    accountObjectpropCount++;
                }

                if (bodyaccountvoipUsername != null)
                {
                    accountObject["voip_username"] = SourceExpressionConverter.ConvertToken(bodyaccountvoipUsername);
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
                    contactInformationObject["address"] = SourceExpressionConverter.ConvertToken(bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = SourceExpressionConverter.ConvertToken(bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = SourceExpressionConverter.ConvertToken(bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = SourceExpressionConverter.ConvertToken(bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = SourceExpressionConverter.ConvertToken(bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = SourceExpressionConverter.ConvertToken(bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = SourceExpressionConverter.ConvertToken(bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = SourceExpressionConverter.ConvertToken(bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = SourceExpressionConverter.ConvertToken(bodycontactInformationworkphone);
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
                        body["disable"] = SourceExpressionConverter.ConvertToken(bodydisable);
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
                    employmentObject["agent_group_id"] = SourceExpressionConverter.ConvertToken(bodyemploymentagentGroupId);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentbankAcc != null)
                {
                    employmentObject["bank_acc"] = SourceExpressionConverter.ConvertToken(bodyemploymentbankAcc);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentdescription != null)
                {
                    employmentObject["description"] = SourceExpressionConverter.ConvertToken(bodyemploymentdescription);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentemployment != null)
                {
                    employmentObject["employment"] = SourceExpressionConverter.Convert(bodyemploymentemployment);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentemploymentStart != null)
                {
                    employmentObject["employment_start"] = SourceExpressionConverter.ConvertToken(bodyemploymentemploymentStart);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentoffice != null)
                {
                    employmentObject["office"] = SourceExpressionConverter.ConvertToken(bodyemploymentoffice);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentssn != null)
                {
                    employmentObject["ssn"] = SourceExpressionConverter.ConvertToken(bodyemploymentssn);
                    employmentObjectpropCount++;
                }

                if (bodyemploymentworkshift != null)
                {
                    employmentObject["workshift"] = SourceExpressionConverter.ConvertToken(bodyemploymentworkshift);
                    employmentObjectpropCount++;
                }

                if (employmentObjectpropCount > 0)
                {
                    body["employment"] = employmentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ModifyAgentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyContactResponse> ModifyContact([WorkflowExpression] Func<int> contactId, [WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> birthyear = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> www = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> postcode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> ssc = null, [WorkflowExpression] Func<int> companyid = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<string> vatin = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> other1 = null, [WorkflowExpression] Func<string> other2 = null, [WorkflowExpression] Func<string> other3 = null, [WorkflowExpression] Func<string> other4 = null, [WorkflowExpression] Func<string> other5 = null, [WorkflowExpression] Func<string> other6 = null, [WorkflowExpression] Func<string> other7 = null, [WorkflowExpression] Func<string> other8 = null, [WorkflowExpression] Func<string> other9 = null, [WorkflowExpression] Func<string> other10 = null, [WorkflowExpression] Func<string> other11 = null, [WorkflowExpression] Func<string> other12 = null, [WorkflowExpression] Func<string> other13 = null, [WorkflowExpression] Func<string> other14 = null, [WorkflowExpression] Func<string> other15 = null, [WorkflowExpression] Func<string> other16 = null, [WorkflowExpression] Func<string> other17 = null, [WorkflowExpression] Func<string> other18 = null, [WorkflowExpression] Func<string> other19 = null, [WorkflowExpression] Func<string> other20 = null, [WorkflowExpression] Func<string> other21 = null, [WorkflowExpression] Func<string> other22 = null, [WorkflowExpression] Func<string> other23 = null, [WorkflowExpression] Func<string> other24 = null, [WorkflowExpression] Func<string> other25 = null, [WorkflowExpression] Func<string> other26 = null, [WorkflowExpression] Func<string> other27 = null, [WorkflowExpression] Func<string> other28 = null, [WorkflowExpression] Func<string> other29 = null, [WorkflowExpression] Func<string> other30 = null, [WorkflowExpression] Func<string> other31 = null, [WorkflowExpression] Func<string> other32 = null, [WorkflowExpression] Func<string> other33 = null, [WorkflowExpression] Func<string> other34 = null, [WorkflowExpression] Func<string> other35 = null, [WorkflowExpression] Func<string> list = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> assignToAgent = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/modify_contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("contact");
                callPayload.Queries["cmd"] = Convert.ToString("modify");
                callPayload.Queries["contact_id"] = SourceExpressionConverter.ConvertO(contactId);
                if (fname != null)
                    callPayload.Queries["fname"] = SourceExpressionConverter.ConvertO(fname);
                if (lname != null)
                    callPayload.Queries["lname"] = SourceExpressionConverter.ConvertO(lname);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (birthyear != null)
                    callPayload.Queries["birthyear"] = SourceExpressionConverter.ConvertO(birthyear);
                if (gender != null)
                    callPayload.Queries["gender"] = SourceExpressionConverter.ConvertO(gender);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (www != null)
                    callPayload.Queries["www"] = SourceExpressionConverter.ConvertO(www);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (postcode != null)
                    callPayload.Queries["postcode"] = SourceExpressionConverter.ConvertO(postcode);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (ssc != null)
                    callPayload.Queries["ssc"] = SourceExpressionConverter.ConvertO(ssc);
                if (companyid != null)
                    callPayload.Queries["companyid"] = SourceExpressionConverter.ConvertO(companyid);
                if (company != null)
                    callPayload.Queries["company"] = SourceExpressionConverter.ConvertO(company);
                if (vatin != null)
                    callPayload.Queries["vatin"] = SourceExpressionConverter.ConvertO(vatin);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                if (other1 != null)
                    callPayload.Queries["other1"] = SourceExpressionConverter.ConvertO(other1);
                if (other2 != null)
                    callPayload.Queries["other2"] = SourceExpressionConverter.ConvertO(other2);
                if (other3 != null)
                    callPayload.Queries["other3"] = SourceExpressionConverter.ConvertO(other3);
                if (other4 != null)
                    callPayload.Queries["other4"] = SourceExpressionConverter.ConvertO(other4);
                if (other5 != null)
                    callPayload.Queries["other5"] = SourceExpressionConverter.ConvertO(other5);
                if (other6 != null)
                    callPayload.Queries["other6"] = SourceExpressionConverter.ConvertO(other6);
                if (other7 != null)
                    callPayload.Queries["other7"] = SourceExpressionConverter.ConvertO(other7);
                if (other8 != null)
                    callPayload.Queries["other8"] = SourceExpressionConverter.ConvertO(other8);
                if (other9 != null)
                    callPayload.Queries["other9"] = SourceExpressionConverter.ConvertO(other9);
                if (other10 != null)
                    callPayload.Queries["other10"] = SourceExpressionConverter.ConvertO(other10);
                if (other11 != null)
                    callPayload.Queries["other11"] = SourceExpressionConverter.ConvertO(other11);
                if (other12 != null)
                    callPayload.Queries["other12"] = SourceExpressionConverter.ConvertO(other12);
                if (other13 != null)
                    callPayload.Queries["other13"] = SourceExpressionConverter.ConvertO(other13);
                if (other14 != null)
                    callPayload.Queries["other14"] = SourceExpressionConverter.ConvertO(other14);
                if (other15 != null)
                    callPayload.Queries["other15"] = SourceExpressionConverter.ConvertO(other15);
                if (other16 != null)
                    callPayload.Queries["other16"] = SourceExpressionConverter.ConvertO(other16);
                if (other17 != null)
                    callPayload.Queries["other17"] = SourceExpressionConverter.ConvertO(other17);
                if (other18 != null)
                    callPayload.Queries["other18"] = SourceExpressionConverter.ConvertO(other18);
                if (other19 != null)
                    callPayload.Queries["other19"] = SourceExpressionConverter.ConvertO(other19);
                if (other20 != null)
                    callPayload.Queries["other20"] = SourceExpressionConverter.ConvertO(other20);
                if (other21 != null)
                    callPayload.Queries["other21"] = SourceExpressionConverter.ConvertO(other21);
                if (other22 != null)
                    callPayload.Queries["other22"] = SourceExpressionConverter.ConvertO(other22);
                if (other23 != null)
                    callPayload.Queries["other23"] = SourceExpressionConverter.ConvertO(other23);
                if (other24 != null)
                    callPayload.Queries["other24"] = SourceExpressionConverter.ConvertO(other24);
                if (other25 != null)
                    callPayload.Queries["other25"] = SourceExpressionConverter.ConvertO(other25);
                if (other26 != null)
                    callPayload.Queries["other26"] = SourceExpressionConverter.ConvertO(other26);
                if (other27 != null)
                    callPayload.Queries["other27"] = SourceExpressionConverter.ConvertO(other27);
                if (other28 != null)
                    callPayload.Queries["other28"] = SourceExpressionConverter.ConvertO(other28);
                if (other29 != null)
                    callPayload.Queries["other29"] = SourceExpressionConverter.ConvertO(other29);
                if (other30 != null)
                    callPayload.Queries["other30"] = SourceExpressionConverter.ConvertO(other30);
                if (other31 != null)
                    callPayload.Queries["other31"] = SourceExpressionConverter.ConvertO(other31);
                if (other32 != null)
                    callPayload.Queries["other32"] = SourceExpressionConverter.ConvertO(other32);
                if (other33 != null)
                    callPayload.Queries["other33"] = SourceExpressionConverter.ConvertO(other33);
                if (other34 != null)
                    callPayload.Queries["other34"] = SourceExpressionConverter.ConvertO(other34);
                if (other35 != null)
                    callPayload.Queries["other35"] = SourceExpressionConverter.ConvertO(other35);
                if (list != null)
                    callPayload.Queries["list"] = SourceExpressionConverter.ConvertO(list);
                callPayload.Queries["order"] = Convert.ToString("last");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (assignToAgent != null)
                    callPayload.Queries["assign_to_agent"] = SourceExpressionConverter.ConvertO(assignToAgent);
                return callPayload;
            }

            return new ApiConnectionAction<ModifyContactResponse>(BuildSourceInput);
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