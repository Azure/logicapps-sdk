//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leaddesk
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LeaddeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<AgentCampaignAccessResponse> AgentCampaignAccess(Expression<Func<int>> agentId, Expression<Func<int>> campaignId, Expression<Func<typeInput>> type)
        {
            var __workflow_agentId = agentId == null ? null : WorkflowExpression.Compile(agentId);
            WorkflowExpression.Validate(__workflow_agentId, nameof(agentId), required: true);
            var __workflow_campaignId = campaignId == null ? null : WorkflowExpression.Compile(campaignId);
            WorkflowExpression.Validate(__workflow_campaignId, nameof(campaignId), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            return new DeferredBodyAction<AgentCampaignAccessResponse>(() =>
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
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent(Expression<Func<string>> bodyaccountexternalId = null, Expression<Func<string>> bodyaccountinboundNumber = null, Expression<Func<string>> bodyaccountlang = null, Expression<Func<string>> bodyaccountpassword = null, Expression<Func<string>> bodyaccounttimeZone = null, Expression<Func<string>> bodyaccountusername = null, Expression<Func<string>> bodyaccountvoipUsername = null, Expression<Func<string>> bodycontactInformationaddress = null, Expression<Func<string>> bodycontactInformationcity = null, Expression<Func<string>> bodycontactInformationcountry = null, Expression<Func<string>> bodycontactInformationeContacts = null, Expression<Func<string>> bodycontactInformationemail = null, Expression<Func<string>> bodycontactInformationname = null, Expression<Func<string>> bodycontactInformationphone = null, Expression<Func<string>> bodycontactInformationpostal = null, Expression<Func<string>> bodycontactInformationworkphone = null, Expression<Func<int>> bodyemploymentagentGroupId = null, Expression<Func<string>> bodyemploymentbankAcc = null, Expression<Func<string>> bodyemploymentdescription = null, Expression<Func<bodyemploymentemploymentInput>> bodyemploymentemployment = null, Expression<Func<string>> bodyemploymentemploymentStart = null, Expression<Func<string>> bodyemploymentoffice = null, Expression<Func<string>> bodyemploymentssn = null, Expression<Func<string>> bodyemploymentworkshift = null)
        {
            var __workflow_bodyaccountexternalId = bodyaccountexternalId == null ? null : WorkflowExpression.Compile(bodyaccountexternalId);
            WorkflowExpression.Validate(__workflow_bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            var __workflow_bodyaccountinboundNumber = bodyaccountinboundNumber == null ? null : WorkflowExpression.Compile(bodyaccountinboundNumber);
            WorkflowExpression.Validate(__workflow_bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            var __workflow_bodyaccountlang = bodyaccountlang == null ? null : WorkflowExpression.Compile(bodyaccountlang);
            WorkflowExpression.Validate(__workflow_bodyaccountlang, nameof(bodyaccountlang), required: false);
            var __workflow_bodyaccountpassword = bodyaccountpassword == null ? null : WorkflowExpression.Compile(bodyaccountpassword);
            WorkflowExpression.Validate(__workflow_bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            var __workflow_bodyaccounttimeZone = bodyaccounttimeZone == null ? null : WorkflowExpression.Compile(bodyaccounttimeZone);
            WorkflowExpression.Validate(__workflow_bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            var __workflow_bodyaccountusername = bodyaccountusername == null ? null : WorkflowExpression.Compile(bodyaccountusername);
            WorkflowExpression.Validate(__workflow_bodyaccountusername, nameof(bodyaccountusername), required: false);
            var __workflow_bodyaccountvoipUsername = bodyaccountvoipUsername == null ? null : WorkflowExpression.Compile(bodyaccountvoipUsername);
            WorkflowExpression.Validate(__workflow_bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            var __workflow_bodycontactInformationaddress = bodycontactInformationaddress == null ? null : WorkflowExpression.Compile(bodycontactInformationaddress);
            WorkflowExpression.Validate(__workflow_bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            var __workflow_bodycontactInformationcity = bodycontactInformationcity == null ? null : WorkflowExpression.Compile(bodycontactInformationcity);
            WorkflowExpression.Validate(__workflow_bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            var __workflow_bodycontactInformationcountry = bodycontactInformationcountry == null ? null : WorkflowExpression.Compile(bodycontactInformationcountry);
            WorkflowExpression.Validate(__workflow_bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            var __workflow_bodycontactInformationeContacts = bodycontactInformationeContacts == null ? null : WorkflowExpression.Compile(bodycontactInformationeContacts);
            WorkflowExpression.Validate(__workflow_bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            var __workflow_bodycontactInformationemail = bodycontactInformationemail == null ? null : WorkflowExpression.Compile(bodycontactInformationemail);
            WorkflowExpression.Validate(__workflow_bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            var __workflow_bodycontactInformationname = bodycontactInformationname == null ? null : WorkflowExpression.Compile(bodycontactInformationname);
            WorkflowExpression.Validate(__workflow_bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            var __workflow_bodycontactInformationphone = bodycontactInformationphone == null ? null : WorkflowExpression.Compile(bodycontactInformationphone);
            WorkflowExpression.Validate(__workflow_bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            var __workflow_bodycontactInformationpostal = bodycontactInformationpostal == null ? null : WorkflowExpression.Compile(bodycontactInformationpostal);
            WorkflowExpression.Validate(__workflow_bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            var __workflow_bodycontactInformationworkphone = bodycontactInformationworkphone == null ? null : WorkflowExpression.Compile(bodycontactInformationworkphone);
            WorkflowExpression.Validate(__workflow_bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            var __workflow_bodyemploymentagentGroupId = bodyemploymentagentGroupId == null ? null : WorkflowExpression.Compile(bodyemploymentagentGroupId);
            WorkflowExpression.Validate(__workflow_bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            var __workflow_bodyemploymentbankAcc = bodyemploymentbankAcc == null ? null : WorkflowExpression.Compile(bodyemploymentbankAcc);
            WorkflowExpression.Validate(__workflow_bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            var __workflow_bodyemploymentdescription = bodyemploymentdescription == null ? null : WorkflowExpression.Compile(bodyemploymentdescription);
            WorkflowExpression.Validate(__workflow_bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            var __workflow_bodyemploymentemployment = bodyemploymentemployment == null ? null : WorkflowExpression.Compile(bodyemploymentemployment);
            WorkflowExpression.Validate(__workflow_bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            var __workflow_bodyemploymentemploymentStart = bodyemploymentemploymentStart == null ? null : WorkflowExpression.Compile(bodyemploymentemploymentStart);
            WorkflowExpression.Validate(__workflow_bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            var __workflow_bodyemploymentoffice = bodyemploymentoffice == null ? null : WorkflowExpression.Compile(bodyemploymentoffice);
            WorkflowExpression.Validate(__workflow_bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            var __workflow_bodyemploymentssn = bodyemploymentssn == null ? null : WorkflowExpression.Compile(bodyemploymentssn);
            WorkflowExpression.Validate(__workflow_bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            var __workflow_bodyemploymentworkshift = bodyemploymentworkshift == null ? null : WorkflowExpression.Compile(bodyemploymentworkshift);
            WorkflowExpression.Validate(__workflow_bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
            return new DeferredBodyAction<CreateAgentResponse>(() =>
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
                if (__workflow_bodyaccountexternalId != null)
                {
                    accountObject["external_id"] = ExpressionConverter.ConvertO(__workflow_bodyaccountexternalId);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountinboundNumber != null)
                {
                    accountObject["inbound_number"] = ExpressionConverter.ConvertO(__workflow_bodyaccountinboundNumber);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountlang != null)
                {
                    accountObject["lang"] = ExpressionConverter.ConvertO(__workflow_bodyaccountlang);
                    accountObjectpropCount++;
                }

                accountObject["level"] = "agent";
                accountObjectpropCount++;
                if (__workflow_bodyaccountpassword != null)
                {
                    accountObject["password"] = ExpressionConverter.ConvertO(__workflow_bodyaccountpassword);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccounttimeZone != null)
                {
                    if (__workflow_bodyaccounttimeZone != null)
                    {
                        accountObject["time_zone"] = ExpressionConverter.ConvertO(__workflow_bodyaccounttimeZone);
                        accountObjectpropCount++;
                    }

                    accountObjectpropCount++;
                }
                else
                {
                    accountObject["time_zone"] = "Europe/Helsinki";
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountusername != null)
                {
                    accountObject["username"] = ExpressionConverter.ConvertO(__workflow_bodyaccountusername);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountvoipUsername != null)
                {
                    accountObject["voip_username"] = ExpressionConverter.ConvertO(__workflow_bodyaccountvoipUsername);
                    accountObjectpropCount++;
                }

                if (accountObjectpropCount > 0)
                {
                    body["account"] = accountObject;
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (__workflow_bodycontactInformationaddress != null)
                {
                    contactInformationObject["address"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationworkphone);
                    contactInformationObjectpropCount++;
                }

                if (contactInformationObjectpropCount > 0)
                {
                    body["contact_information"] = contactInformationObject;
                    bodypropCount++;
                }

                var employmentObject = new JObject();
                var employmentObjectpropCount = 0;
                if (__workflow_bodyemploymentagentGroupId != null)
                {
                    employmentObject["agent_group_id"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentagentGroupId);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentbankAcc != null)
                {
                    employmentObject["bank_acc"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentbankAcc);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentdescription != null)
                {
                    employmentObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentdescription);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentemployment != null)
                {
                    if (__workflow_bodyemploymentemployment != null)
                    {
                        employmentObject["employment"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentemployment);
                        employmentObjectpropCount++;
                    }

                    employmentObjectpropCount++;
                }
                else
                {
                    employmentObject["employment"] = "active";
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentemploymentStart != null)
                {
                    employmentObject["employment_start"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentemploymentStart);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentoffice != null)
                {
                    employmentObject["office"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentoffice);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentssn != null)
                {
                    employmentObject["ssn"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentssn);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentworkshift != null)
                {
                    employmentObject["workshift"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentworkshift);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateCallbackResponse> CreateCallback(Expression<Func<string>> bodycontactaddress = null, Expression<Func<string>> bodycontactcity = null, Expression<Func<int>> bodycontactcompanyid = null, Expression<Func<string>> bodycontactcontactList = null, Expression<Func<string>> bodycontactcontactid = null, Expression<Func<string>> bodycontactcountry = null, Expression<Func<string>> bodycontactfname = null, Expression<Func<string>> bodycontactlname = null, Expression<Func<string>> bodycontactother1 = null, Expression<Func<string>> bodycontactother2 = null, Expression<Func<string>> bodycontactother3 = null, Expression<Func<string>> bodycontactother4 = null, Expression<Func<string>> bodycontactother5 = null, Expression<Func<string>> bodycontactother6 = null, Expression<Func<string>> bodycontactother7 = null, Expression<Func<string>> bodycontactother8 = null, Expression<Func<string>> bodycontactother9 = null, Expression<Func<string>> bodycontactother10 = null, Expression<Func<string>> bodycontactother11 = null, Expression<Func<string>> bodycontactother12 = null, Expression<Func<string>> bodycontactother13 = null, Expression<Func<string>> bodycontactother14 = null, Expression<Func<string>> bodycontactother15 = null, Expression<Func<string>> bodycontactother16 = null, Expression<Func<string>> bodycontactother17 = null, Expression<Func<string>> bodycontactother18 = null, Expression<Func<string>> bodycontactother19 = null, Expression<Func<string>> bodycontactother20 = null, Expression<Func<string>> bodycontactother21 = null, Expression<Func<string>> bodycontactother22 = null, Expression<Func<string>> bodycontactother23 = null, Expression<Func<string>> bodycontactother24 = null, Expression<Func<string>> bodycontactother25 = null, Expression<Func<string>> bodycontactother26 = null, Expression<Func<string>> bodycontactother27 = null, Expression<Func<string>> bodycontactother28 = null, Expression<Func<string>> bodycontactother29 = null, Expression<Func<string>> bodycontactother30 = null, Expression<Func<string>> bodycontactother31 = null, Expression<Func<string>> bodycontactother32 = null, Expression<Func<string>> bodycontactother33 = null, Expression<Func<string>> bodycontactother34 = null, Expression<Func<string>> bodycontactother35 = null, Expression<Func<string>> bodycontactpostcode = null, Expression<Func<string>> bodypropertiesagent = null, Expression<Func<string>> bodypropertiesagentGroup = null, Expression<Func<string>> bodypropertiescampaign = null, Expression<Func<string>> bodypropertiescomment = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiestimestamp = null, Expression<Func<bodypropertiestypeInput>> bodypropertiestype = null)
        {
            var __workflow_bodycontactaddress = bodycontactaddress == null ? null : WorkflowExpression.Compile(bodycontactaddress);
            WorkflowExpression.Validate(__workflow_bodycontactaddress, nameof(bodycontactaddress), required: false);
            var __workflow_bodycontactcity = bodycontactcity == null ? null : WorkflowExpression.Compile(bodycontactcity);
            WorkflowExpression.Validate(__workflow_bodycontactcity, nameof(bodycontactcity), required: false);
            var __workflow_bodycontactcompanyid = bodycontactcompanyid == null ? null : WorkflowExpression.Compile(bodycontactcompanyid);
            WorkflowExpression.Validate(__workflow_bodycontactcompanyid, nameof(bodycontactcompanyid), required: false);
            var __workflow_bodycontactcontactList = bodycontactcontactList == null ? null : WorkflowExpression.Compile(bodycontactcontactList);
            WorkflowExpression.Validate(__workflow_bodycontactcontactList, nameof(bodycontactcontactList), required: false);
            var __workflow_bodycontactcontactid = bodycontactcontactid == null ? null : WorkflowExpression.Compile(bodycontactcontactid);
            WorkflowExpression.Validate(__workflow_bodycontactcontactid, nameof(bodycontactcontactid), required: false);
            var __workflow_bodycontactcountry = bodycontactcountry == null ? null : WorkflowExpression.Compile(bodycontactcountry);
            WorkflowExpression.Validate(__workflow_bodycontactcountry, nameof(bodycontactcountry), required: false);
            var __workflow_bodycontactfname = bodycontactfname == null ? null : WorkflowExpression.Compile(bodycontactfname);
            WorkflowExpression.Validate(__workflow_bodycontactfname, nameof(bodycontactfname), required: false);
            var __workflow_bodycontactlname = bodycontactlname == null ? null : WorkflowExpression.Compile(bodycontactlname);
            WorkflowExpression.Validate(__workflow_bodycontactlname, nameof(bodycontactlname), required: false);
            var __workflow_bodycontactother1 = bodycontactother1 == null ? null : WorkflowExpression.Compile(bodycontactother1);
            WorkflowExpression.Validate(__workflow_bodycontactother1, nameof(bodycontactother1), required: false);
            var __workflow_bodycontactother2 = bodycontactother2 == null ? null : WorkflowExpression.Compile(bodycontactother2);
            WorkflowExpression.Validate(__workflow_bodycontactother2, nameof(bodycontactother2), required: false);
            var __workflow_bodycontactother3 = bodycontactother3 == null ? null : WorkflowExpression.Compile(bodycontactother3);
            WorkflowExpression.Validate(__workflow_bodycontactother3, nameof(bodycontactother3), required: false);
            var __workflow_bodycontactother4 = bodycontactother4 == null ? null : WorkflowExpression.Compile(bodycontactother4);
            WorkflowExpression.Validate(__workflow_bodycontactother4, nameof(bodycontactother4), required: false);
            var __workflow_bodycontactother5 = bodycontactother5 == null ? null : WorkflowExpression.Compile(bodycontactother5);
            WorkflowExpression.Validate(__workflow_bodycontactother5, nameof(bodycontactother5), required: false);
            var __workflow_bodycontactother6 = bodycontactother6 == null ? null : WorkflowExpression.Compile(bodycontactother6);
            WorkflowExpression.Validate(__workflow_bodycontactother6, nameof(bodycontactother6), required: false);
            var __workflow_bodycontactother7 = bodycontactother7 == null ? null : WorkflowExpression.Compile(bodycontactother7);
            WorkflowExpression.Validate(__workflow_bodycontactother7, nameof(bodycontactother7), required: false);
            var __workflow_bodycontactother8 = bodycontactother8 == null ? null : WorkflowExpression.Compile(bodycontactother8);
            WorkflowExpression.Validate(__workflow_bodycontactother8, nameof(bodycontactother8), required: false);
            var __workflow_bodycontactother9 = bodycontactother9 == null ? null : WorkflowExpression.Compile(bodycontactother9);
            WorkflowExpression.Validate(__workflow_bodycontactother9, nameof(bodycontactother9), required: false);
            var __workflow_bodycontactother10 = bodycontactother10 == null ? null : WorkflowExpression.Compile(bodycontactother10);
            WorkflowExpression.Validate(__workflow_bodycontactother10, nameof(bodycontactother10), required: false);
            var __workflow_bodycontactother11 = bodycontactother11 == null ? null : WorkflowExpression.Compile(bodycontactother11);
            WorkflowExpression.Validate(__workflow_bodycontactother11, nameof(bodycontactother11), required: false);
            var __workflow_bodycontactother12 = bodycontactother12 == null ? null : WorkflowExpression.Compile(bodycontactother12);
            WorkflowExpression.Validate(__workflow_bodycontactother12, nameof(bodycontactother12), required: false);
            var __workflow_bodycontactother13 = bodycontactother13 == null ? null : WorkflowExpression.Compile(bodycontactother13);
            WorkflowExpression.Validate(__workflow_bodycontactother13, nameof(bodycontactother13), required: false);
            var __workflow_bodycontactother14 = bodycontactother14 == null ? null : WorkflowExpression.Compile(bodycontactother14);
            WorkflowExpression.Validate(__workflow_bodycontactother14, nameof(bodycontactother14), required: false);
            var __workflow_bodycontactother15 = bodycontactother15 == null ? null : WorkflowExpression.Compile(bodycontactother15);
            WorkflowExpression.Validate(__workflow_bodycontactother15, nameof(bodycontactother15), required: false);
            var __workflow_bodycontactother16 = bodycontactother16 == null ? null : WorkflowExpression.Compile(bodycontactother16);
            WorkflowExpression.Validate(__workflow_bodycontactother16, nameof(bodycontactother16), required: false);
            var __workflow_bodycontactother17 = bodycontactother17 == null ? null : WorkflowExpression.Compile(bodycontactother17);
            WorkflowExpression.Validate(__workflow_bodycontactother17, nameof(bodycontactother17), required: false);
            var __workflow_bodycontactother18 = bodycontactother18 == null ? null : WorkflowExpression.Compile(bodycontactother18);
            WorkflowExpression.Validate(__workflow_bodycontactother18, nameof(bodycontactother18), required: false);
            var __workflow_bodycontactother19 = bodycontactother19 == null ? null : WorkflowExpression.Compile(bodycontactother19);
            WorkflowExpression.Validate(__workflow_bodycontactother19, nameof(bodycontactother19), required: false);
            var __workflow_bodycontactother20 = bodycontactother20 == null ? null : WorkflowExpression.Compile(bodycontactother20);
            WorkflowExpression.Validate(__workflow_bodycontactother20, nameof(bodycontactother20), required: false);
            var __workflow_bodycontactother21 = bodycontactother21 == null ? null : WorkflowExpression.Compile(bodycontactother21);
            WorkflowExpression.Validate(__workflow_bodycontactother21, nameof(bodycontactother21), required: false);
            var __workflow_bodycontactother22 = bodycontactother22 == null ? null : WorkflowExpression.Compile(bodycontactother22);
            WorkflowExpression.Validate(__workflow_bodycontactother22, nameof(bodycontactother22), required: false);
            var __workflow_bodycontactother23 = bodycontactother23 == null ? null : WorkflowExpression.Compile(bodycontactother23);
            WorkflowExpression.Validate(__workflow_bodycontactother23, nameof(bodycontactother23), required: false);
            var __workflow_bodycontactother24 = bodycontactother24 == null ? null : WorkflowExpression.Compile(bodycontactother24);
            WorkflowExpression.Validate(__workflow_bodycontactother24, nameof(bodycontactother24), required: false);
            var __workflow_bodycontactother25 = bodycontactother25 == null ? null : WorkflowExpression.Compile(bodycontactother25);
            WorkflowExpression.Validate(__workflow_bodycontactother25, nameof(bodycontactother25), required: false);
            var __workflow_bodycontactother26 = bodycontactother26 == null ? null : WorkflowExpression.Compile(bodycontactother26);
            WorkflowExpression.Validate(__workflow_bodycontactother26, nameof(bodycontactother26), required: false);
            var __workflow_bodycontactother27 = bodycontactother27 == null ? null : WorkflowExpression.Compile(bodycontactother27);
            WorkflowExpression.Validate(__workflow_bodycontactother27, nameof(bodycontactother27), required: false);
            var __workflow_bodycontactother28 = bodycontactother28 == null ? null : WorkflowExpression.Compile(bodycontactother28);
            WorkflowExpression.Validate(__workflow_bodycontactother28, nameof(bodycontactother28), required: false);
            var __workflow_bodycontactother29 = bodycontactother29 == null ? null : WorkflowExpression.Compile(bodycontactother29);
            WorkflowExpression.Validate(__workflow_bodycontactother29, nameof(bodycontactother29), required: false);
            var __workflow_bodycontactother30 = bodycontactother30 == null ? null : WorkflowExpression.Compile(bodycontactother30);
            WorkflowExpression.Validate(__workflow_bodycontactother30, nameof(bodycontactother30), required: false);
            var __workflow_bodycontactother31 = bodycontactother31 == null ? null : WorkflowExpression.Compile(bodycontactother31);
            WorkflowExpression.Validate(__workflow_bodycontactother31, nameof(bodycontactother31), required: false);
            var __workflow_bodycontactother32 = bodycontactother32 == null ? null : WorkflowExpression.Compile(bodycontactother32);
            WorkflowExpression.Validate(__workflow_bodycontactother32, nameof(bodycontactother32), required: false);
            var __workflow_bodycontactother33 = bodycontactother33 == null ? null : WorkflowExpression.Compile(bodycontactother33);
            WorkflowExpression.Validate(__workflow_bodycontactother33, nameof(bodycontactother33), required: false);
            var __workflow_bodycontactother34 = bodycontactother34 == null ? null : WorkflowExpression.Compile(bodycontactother34);
            WorkflowExpression.Validate(__workflow_bodycontactother34, nameof(bodycontactother34), required: false);
            var __workflow_bodycontactother35 = bodycontactother35 == null ? null : WorkflowExpression.Compile(bodycontactother35);
            WorkflowExpression.Validate(__workflow_bodycontactother35, nameof(bodycontactother35), required: false);
            var __workflow_bodycontactpostcode = bodycontactpostcode == null ? null : WorkflowExpression.Compile(bodycontactpostcode);
            WorkflowExpression.Validate(__workflow_bodycontactpostcode, nameof(bodycontactpostcode), required: false);
            var __workflow_bodypropertiesagent = bodypropertiesagent == null ? null : WorkflowExpression.Compile(bodypropertiesagent);
            WorkflowExpression.Validate(__workflow_bodypropertiesagent, nameof(bodypropertiesagent), required: false);
            var __workflow_bodypropertiesagentGroup = bodypropertiesagentGroup == null ? null : WorkflowExpression.Compile(bodypropertiesagentGroup);
            WorkflowExpression.Validate(__workflow_bodypropertiesagentGroup, nameof(bodypropertiesagentGroup), required: false);
            var __workflow_bodypropertiescampaign = bodypropertiescampaign == null ? null : WorkflowExpression.Compile(bodypropertiescampaign);
            WorkflowExpression.Validate(__workflow_bodypropertiescampaign, nameof(bodypropertiescampaign), required: false);
            var __workflow_bodypropertiescomment = bodypropertiescomment == null ? null : WorkflowExpression.Compile(bodypropertiescomment);
            WorkflowExpression.Validate(__workflow_bodypropertiescomment, nameof(bodypropertiescomment), required: false);
            var __workflow_bodypropertiesphone = bodypropertiesphone == null ? null : WorkflowExpression.Compile(bodypropertiesphone);
            WorkflowExpression.Validate(__workflow_bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            var __workflow_bodypropertiestimestamp = bodypropertiestimestamp == null ? null : WorkflowExpression.Compile(bodypropertiestimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertiestimestamp, nameof(bodypropertiestimestamp), required: false);
            var __workflow_bodypropertiestype = bodypropertiestype == null ? null : WorkflowExpression.Compile(bodypropertiestype);
            WorkflowExpression.Validate(__workflow_bodypropertiestype, nameof(bodypropertiestype), required: false);
            return new DeferredBodyAction<CreateCallbackResponse>(() =>
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
                if (__workflow_bodycontactaddress != null)
                {
                    contactObject["address"] = ExpressionConverter.ConvertO(__workflow_bodycontactaddress);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcity != null)
                {
                    contactObject["city"] = ExpressionConverter.ConvertO(__workflow_bodycontactcity);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcompanyid != null)
                {
                    contactObject["companyid"] = ExpressionConverter.ConvertO(__workflow_bodycontactcompanyid);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcontactList != null)
                {
                    contactObject["contact_list"] = ExpressionConverter.ConvertO(__workflow_bodycontactcontactList);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcontactid != null)
                {
                    contactObject["contactid"] = ExpressionConverter.ConvertO(__workflow_bodycontactcontactid);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcountry != null)
                {
                    contactObject["country"] = ExpressionConverter.ConvertO(__workflow_bodycontactcountry);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactfname != null)
                {
                    contactObject["fname"] = ExpressionConverter.ConvertO(__workflow_bodycontactfname);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactlname != null)
                {
                    contactObject["lname"] = ExpressionConverter.ConvertO(__workflow_bodycontactlname);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother1 != null)
                {
                    contactObject["other1"] = ExpressionConverter.ConvertO(__workflow_bodycontactother1);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother2 != null)
                {
                    contactObject["other2"] = ExpressionConverter.ConvertO(__workflow_bodycontactother2);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother3 != null)
                {
                    contactObject["other3"] = ExpressionConverter.ConvertO(__workflow_bodycontactother3);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother4 != null)
                {
                    contactObject["other4"] = ExpressionConverter.ConvertO(__workflow_bodycontactother4);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother5 != null)
                {
                    contactObject["other5"] = ExpressionConverter.ConvertO(__workflow_bodycontactother5);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother6 != null)
                {
                    contactObject["other6"] = ExpressionConverter.ConvertO(__workflow_bodycontactother6);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother7 != null)
                {
                    contactObject["other7"] = ExpressionConverter.ConvertO(__workflow_bodycontactother7);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother8 != null)
                {
                    contactObject["other8"] = ExpressionConverter.ConvertO(__workflow_bodycontactother8);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother9 != null)
                {
                    contactObject["other9"] = ExpressionConverter.ConvertO(__workflow_bodycontactother9);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother10 != null)
                {
                    contactObject["other10"] = ExpressionConverter.ConvertO(__workflow_bodycontactother10);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother11 != null)
                {
                    contactObject["other11"] = ExpressionConverter.ConvertO(__workflow_bodycontactother11);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother12 != null)
                {
                    contactObject["other12"] = ExpressionConverter.ConvertO(__workflow_bodycontactother12);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother13 != null)
                {
                    contactObject["other13"] = ExpressionConverter.ConvertO(__workflow_bodycontactother13);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother14 != null)
                {
                    contactObject["other14"] = ExpressionConverter.ConvertO(__workflow_bodycontactother14);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother15 != null)
                {
                    contactObject["other15"] = ExpressionConverter.ConvertO(__workflow_bodycontactother15);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother16 != null)
                {
                    contactObject["other16"] = ExpressionConverter.ConvertO(__workflow_bodycontactother16);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother17 != null)
                {
                    contactObject["other17"] = ExpressionConverter.ConvertO(__workflow_bodycontactother17);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother18 != null)
                {
                    contactObject["other18"] = ExpressionConverter.ConvertO(__workflow_bodycontactother18);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother19 != null)
                {
                    contactObject["other19"] = ExpressionConverter.ConvertO(__workflow_bodycontactother19);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother20 != null)
                {
                    contactObject["other20"] = ExpressionConverter.ConvertO(__workflow_bodycontactother20);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother21 != null)
                {
                    contactObject["other21"] = ExpressionConverter.ConvertO(__workflow_bodycontactother21);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother22 != null)
                {
                    contactObject["other22"] = ExpressionConverter.ConvertO(__workflow_bodycontactother22);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother23 != null)
                {
                    contactObject["other23"] = ExpressionConverter.ConvertO(__workflow_bodycontactother23);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother24 != null)
                {
                    contactObject["other24"] = ExpressionConverter.ConvertO(__workflow_bodycontactother24);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother25 != null)
                {
                    contactObject["other25"] = ExpressionConverter.ConvertO(__workflow_bodycontactother25);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother26 != null)
                {
                    contactObject["other26"] = ExpressionConverter.ConvertO(__workflow_bodycontactother26);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother27 != null)
                {
                    contactObject["other27"] = ExpressionConverter.ConvertO(__workflow_bodycontactother27);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother28 != null)
                {
                    contactObject["other28"] = ExpressionConverter.ConvertO(__workflow_bodycontactother28);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother29 != null)
                {
                    contactObject["other29"] = ExpressionConverter.ConvertO(__workflow_bodycontactother29);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother30 != null)
                {
                    contactObject["other30"] = ExpressionConverter.ConvertO(__workflow_bodycontactother30);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother31 != null)
                {
                    contactObject["other31"] = ExpressionConverter.ConvertO(__workflow_bodycontactother31);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother32 != null)
                {
                    contactObject["other32"] = ExpressionConverter.ConvertO(__workflow_bodycontactother32);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother33 != null)
                {
                    contactObject["other33"] = ExpressionConverter.ConvertO(__workflow_bodycontactother33);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother34 != null)
                {
                    contactObject["other34"] = ExpressionConverter.ConvertO(__workflow_bodycontactother34);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactother35 != null)
                {
                    contactObject["other35"] = ExpressionConverter.ConvertO(__workflow_bodycontactother35);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactpostcode != null)
                {
                    contactObject["postcode"] = ExpressionConverter.ConvertO(__workflow_bodycontactpostcode);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesagent != null)
                {
                    propertiesObject["agent"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesagent);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesagentGroup != null)
                {
                    propertiesObject["agent_group"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesagentGroup);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescampaign != null)
                {
                    propertiesObject["campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescomment != null)
                {
                    propertiesObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescomment);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimestamp != null)
                {
                    propertiesObject["timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestype != null)
                {
                    if (__workflow_bodypropertiestype != null)
                    {
                        propertiesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestype);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> phone, Expression<Func<string>> list, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> assignToAgent = null)
        {
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: true);
            var __workflow_list = list == null ? null : WorkflowExpression.Compile(list);
            WorkflowExpression.Validate(__workflow_list, nameof(list), required: true);
            var __workflow_fname = fname == null ? null : WorkflowExpression.Compile(fname);
            WorkflowExpression.Validate(__workflow_fname, nameof(fname), required: false);
            var __workflow_lname = lname == null ? null : WorkflowExpression.Compile(lname);
            WorkflowExpression.Validate(__workflow_lname, nameof(lname), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_www = www == null ? null : WorkflowExpression.Compile(www);
            WorkflowExpression.Validate(__workflow_www, nameof(www), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_postcode = postcode == null ? null : WorkflowExpression.Compile(postcode);
            WorkflowExpression.Validate(__workflow_postcode, nameof(postcode), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_ssc = ssc == null ? null : WorkflowExpression.Compile(ssc);
            WorkflowExpression.Validate(__workflow_ssc, nameof(ssc), required: false);
            var __workflow_birthyear = birthyear == null ? null : WorkflowExpression.Compile(birthyear);
            WorkflowExpression.Validate(__workflow_birthyear, nameof(birthyear), required: false);
            var __workflow_gender = gender == null ? null : WorkflowExpression.Compile(gender);
            WorkflowExpression.Validate(__workflow_gender, nameof(gender), required: false);
            var __workflow_companyid = companyid == null ? null : WorkflowExpression.Compile(companyid);
            WorkflowExpression.Validate(__workflow_companyid, nameof(companyid), required: false);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: false);
            var __workflow_vatin = vatin == null ? null : WorkflowExpression.Compile(vatin);
            WorkflowExpression.Validate(__workflow_vatin, nameof(vatin), required: false);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_comment = comment == null ? null : WorkflowExpression.Compile(comment);
            WorkflowExpression.Validate(__workflow_comment, nameof(comment), required: false);
            var __workflow_other1 = other1 == null ? null : WorkflowExpression.Compile(other1);
            WorkflowExpression.Validate(__workflow_other1, nameof(other1), required: false);
            var __workflow_other2 = other2 == null ? null : WorkflowExpression.Compile(other2);
            WorkflowExpression.Validate(__workflow_other2, nameof(other2), required: false);
            var __workflow_other3 = other3 == null ? null : WorkflowExpression.Compile(other3);
            WorkflowExpression.Validate(__workflow_other3, nameof(other3), required: false);
            var __workflow_other4 = other4 == null ? null : WorkflowExpression.Compile(other4);
            WorkflowExpression.Validate(__workflow_other4, nameof(other4), required: false);
            var __workflow_other5 = other5 == null ? null : WorkflowExpression.Compile(other5);
            WorkflowExpression.Validate(__workflow_other5, nameof(other5), required: false);
            var __workflow_other6 = other6 == null ? null : WorkflowExpression.Compile(other6);
            WorkflowExpression.Validate(__workflow_other6, nameof(other6), required: false);
            var __workflow_other7 = other7 == null ? null : WorkflowExpression.Compile(other7);
            WorkflowExpression.Validate(__workflow_other7, nameof(other7), required: false);
            var __workflow_other8 = other8 == null ? null : WorkflowExpression.Compile(other8);
            WorkflowExpression.Validate(__workflow_other8, nameof(other8), required: false);
            var __workflow_other9 = other9 == null ? null : WorkflowExpression.Compile(other9);
            WorkflowExpression.Validate(__workflow_other9, nameof(other9), required: false);
            var __workflow_other10 = other10 == null ? null : WorkflowExpression.Compile(other10);
            WorkflowExpression.Validate(__workflow_other10, nameof(other10), required: false);
            var __workflow_other11 = other11 == null ? null : WorkflowExpression.Compile(other11);
            WorkflowExpression.Validate(__workflow_other11, nameof(other11), required: false);
            var __workflow_other12 = other12 == null ? null : WorkflowExpression.Compile(other12);
            WorkflowExpression.Validate(__workflow_other12, nameof(other12), required: false);
            var __workflow_other13 = other13 == null ? null : WorkflowExpression.Compile(other13);
            WorkflowExpression.Validate(__workflow_other13, nameof(other13), required: false);
            var __workflow_other14 = other14 == null ? null : WorkflowExpression.Compile(other14);
            WorkflowExpression.Validate(__workflow_other14, nameof(other14), required: false);
            var __workflow_other15 = other15 == null ? null : WorkflowExpression.Compile(other15);
            WorkflowExpression.Validate(__workflow_other15, nameof(other15), required: false);
            var __workflow_other16 = other16 == null ? null : WorkflowExpression.Compile(other16);
            WorkflowExpression.Validate(__workflow_other16, nameof(other16), required: false);
            var __workflow_other17 = other17 == null ? null : WorkflowExpression.Compile(other17);
            WorkflowExpression.Validate(__workflow_other17, nameof(other17), required: false);
            var __workflow_other18 = other18 == null ? null : WorkflowExpression.Compile(other18);
            WorkflowExpression.Validate(__workflow_other18, nameof(other18), required: false);
            var __workflow_other19 = other19 == null ? null : WorkflowExpression.Compile(other19);
            WorkflowExpression.Validate(__workflow_other19, nameof(other19), required: false);
            var __workflow_other20 = other20 == null ? null : WorkflowExpression.Compile(other20);
            WorkflowExpression.Validate(__workflow_other20, nameof(other20), required: false);
            var __workflow_other21 = other21 == null ? null : WorkflowExpression.Compile(other21);
            WorkflowExpression.Validate(__workflow_other21, nameof(other21), required: false);
            var __workflow_other22 = other22 == null ? null : WorkflowExpression.Compile(other22);
            WorkflowExpression.Validate(__workflow_other22, nameof(other22), required: false);
            var __workflow_other23 = other23 == null ? null : WorkflowExpression.Compile(other23);
            WorkflowExpression.Validate(__workflow_other23, nameof(other23), required: false);
            var __workflow_other24 = other24 == null ? null : WorkflowExpression.Compile(other24);
            WorkflowExpression.Validate(__workflow_other24, nameof(other24), required: false);
            var __workflow_other25 = other25 == null ? null : WorkflowExpression.Compile(other25);
            WorkflowExpression.Validate(__workflow_other25, nameof(other25), required: false);
            var __workflow_other26 = other26 == null ? null : WorkflowExpression.Compile(other26);
            WorkflowExpression.Validate(__workflow_other26, nameof(other26), required: false);
            var __workflow_other27 = other27 == null ? null : WorkflowExpression.Compile(other27);
            WorkflowExpression.Validate(__workflow_other27, nameof(other27), required: false);
            var __workflow_other28 = other28 == null ? null : WorkflowExpression.Compile(other28);
            WorkflowExpression.Validate(__workflow_other28, nameof(other28), required: false);
            var __workflow_other29 = other29 == null ? null : WorkflowExpression.Compile(other29);
            WorkflowExpression.Validate(__workflow_other29, nameof(other29), required: false);
            var __workflow_other30 = other30 == null ? null : WorkflowExpression.Compile(other30);
            WorkflowExpression.Validate(__workflow_other30, nameof(other30), required: false);
            var __workflow_other31 = other31 == null ? null : WorkflowExpression.Compile(other31);
            WorkflowExpression.Validate(__workflow_other31, nameof(other31), required: false);
            var __workflow_other32 = other32 == null ? null : WorkflowExpression.Compile(other32);
            WorkflowExpression.Validate(__workflow_other32, nameof(other32), required: false);
            var __workflow_other33 = other33 == null ? null : WorkflowExpression.Compile(other33);
            WorkflowExpression.Validate(__workflow_other33, nameof(other33), required: false);
            var __workflow_other34 = other34 == null ? null : WorkflowExpression.Compile(other34);
            WorkflowExpression.Validate(__workflow_other34, nameof(other34), required: false);
            var __workflow_other35 = other35 == null ? null : WorkflowExpression.Compile(other35);
            WorkflowExpression.Validate(__workflow_other35, nameof(other35), required: false);
            var __workflow_assignToAgent = assignToAgent == null ? null : WorkflowExpression.Compile(assignToAgent);
            WorkflowExpression.Validate(__workflow_assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
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
        public IBodyWorkflowAction<FindAgentResponse> FindAgent(Expression<Func<string>> username)
        {
            var __workflow_username = username == null ? null : WorkflowExpression.Compile(username);
            WorkflowExpression.Validate(__workflow_username, nameof(username), required: true);
            return new DeferredBodyAction<FindAgentResponse>(() =>
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
        public IBodyWorkflowAction<FindContactResponse> FindContact(Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<int>> phone = null, Expression<Func<int>> contactListId = null)
        {
            var __workflow_fname = fname == null ? null : WorkflowExpression.Compile(fname);
            WorkflowExpression.Validate(__workflow_fname, nameof(fname), required: false);
            var __workflow_lname = lname == null ? null : WorkflowExpression.Compile(lname);
            WorkflowExpression.Validate(__workflow_lname, nameof(lname), required: false);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: false);
            var __workflow_contactListId = contactListId == null ? null : WorkflowExpression.Compile(contactListId);
            WorkflowExpression.Validate(__workflow_contactListId, nameof(contactListId), required: false);
            return new DeferredBodyAction<FindContactResponse>(() =>
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
        public IBodyWorkflowAction<ModifyAgentResponse> ModifyAgent(Expression<Func<int>> bodyid, Expression<Func<string>> bodyaccountexternalId = null, Expression<Func<string>> bodyaccountinboundNumber = null, Expression<Func<int>> bodyaccountlang = null, Expression<Func<string>> bodyaccountpassword = null, Expression<Func<string>> bodyaccounttimeZone = null, Expression<Func<string>> bodyaccountusername = null, Expression<Func<string>> bodyaccountvoipUsername = null, Expression<Func<string>> bodycontactInformationaddress = null, Expression<Func<string>> bodycontactInformationcity = null, Expression<Func<string>> bodycontactInformationcountry = null, Expression<Func<string>> bodycontactInformationeContacts = null, Expression<Func<string>> bodycontactInformationemail = null, Expression<Func<string>> bodycontactInformationname = null, Expression<Func<string>> bodycontactInformationphone = null, Expression<Func<string>> bodycontactInformationpostal = null, Expression<Func<string>> bodycontactInformationworkphone = null, Expression<Func<bool>> bodydisable = null, Expression<Func<int>> bodyemploymentagentGroupId = null, Expression<Func<string>> bodyemploymentbankAcc = null, Expression<Func<string>> bodyemploymentdescription = null, Expression<Func<bodyemploymentemploymentInput>> bodyemploymentemployment = null, Expression<Func<string>> bodyemploymentemploymentStart = null, Expression<Func<string>> bodyemploymentoffice = null, Expression<Func<string>> bodyemploymentssn = null, Expression<Func<string>> bodyemploymentworkshift = null)
        {
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: true);
            var __workflow_bodyaccountexternalId = bodyaccountexternalId == null ? null : WorkflowExpression.Compile(bodyaccountexternalId);
            WorkflowExpression.Validate(__workflow_bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            var __workflow_bodyaccountinboundNumber = bodyaccountinboundNumber == null ? null : WorkflowExpression.Compile(bodyaccountinboundNumber);
            WorkflowExpression.Validate(__workflow_bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            var __workflow_bodyaccountlang = bodyaccountlang == null ? null : WorkflowExpression.Compile(bodyaccountlang);
            WorkflowExpression.Validate(__workflow_bodyaccountlang, nameof(bodyaccountlang), required: false);
            var __workflow_bodyaccountpassword = bodyaccountpassword == null ? null : WorkflowExpression.Compile(bodyaccountpassword);
            WorkflowExpression.Validate(__workflow_bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            var __workflow_bodyaccounttimeZone = bodyaccounttimeZone == null ? null : WorkflowExpression.Compile(bodyaccounttimeZone);
            WorkflowExpression.Validate(__workflow_bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            var __workflow_bodyaccountusername = bodyaccountusername == null ? null : WorkflowExpression.Compile(bodyaccountusername);
            WorkflowExpression.Validate(__workflow_bodyaccountusername, nameof(bodyaccountusername), required: false);
            var __workflow_bodyaccountvoipUsername = bodyaccountvoipUsername == null ? null : WorkflowExpression.Compile(bodyaccountvoipUsername);
            WorkflowExpression.Validate(__workflow_bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            var __workflow_bodycontactInformationaddress = bodycontactInformationaddress == null ? null : WorkflowExpression.Compile(bodycontactInformationaddress);
            WorkflowExpression.Validate(__workflow_bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            var __workflow_bodycontactInformationcity = bodycontactInformationcity == null ? null : WorkflowExpression.Compile(bodycontactInformationcity);
            WorkflowExpression.Validate(__workflow_bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            var __workflow_bodycontactInformationcountry = bodycontactInformationcountry == null ? null : WorkflowExpression.Compile(bodycontactInformationcountry);
            WorkflowExpression.Validate(__workflow_bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            var __workflow_bodycontactInformationeContacts = bodycontactInformationeContacts == null ? null : WorkflowExpression.Compile(bodycontactInformationeContacts);
            WorkflowExpression.Validate(__workflow_bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            var __workflow_bodycontactInformationemail = bodycontactInformationemail == null ? null : WorkflowExpression.Compile(bodycontactInformationemail);
            WorkflowExpression.Validate(__workflow_bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            var __workflow_bodycontactInformationname = bodycontactInformationname == null ? null : WorkflowExpression.Compile(bodycontactInformationname);
            WorkflowExpression.Validate(__workflow_bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            var __workflow_bodycontactInformationphone = bodycontactInformationphone == null ? null : WorkflowExpression.Compile(bodycontactInformationphone);
            WorkflowExpression.Validate(__workflow_bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            var __workflow_bodycontactInformationpostal = bodycontactInformationpostal == null ? null : WorkflowExpression.Compile(bodycontactInformationpostal);
            WorkflowExpression.Validate(__workflow_bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            var __workflow_bodycontactInformationworkphone = bodycontactInformationworkphone == null ? null : WorkflowExpression.Compile(bodycontactInformationworkphone);
            WorkflowExpression.Validate(__workflow_bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            var __workflow_bodydisable = bodydisable == null ? null : WorkflowExpression.Compile(bodydisable);
            WorkflowExpression.Validate(__workflow_bodydisable, nameof(bodydisable), required: false);
            var __workflow_bodyemploymentagentGroupId = bodyemploymentagentGroupId == null ? null : WorkflowExpression.Compile(bodyemploymentagentGroupId);
            WorkflowExpression.Validate(__workflow_bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            var __workflow_bodyemploymentbankAcc = bodyemploymentbankAcc == null ? null : WorkflowExpression.Compile(bodyemploymentbankAcc);
            WorkflowExpression.Validate(__workflow_bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            var __workflow_bodyemploymentdescription = bodyemploymentdescription == null ? null : WorkflowExpression.Compile(bodyemploymentdescription);
            WorkflowExpression.Validate(__workflow_bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            var __workflow_bodyemploymentemployment = bodyemploymentemployment == null ? null : WorkflowExpression.Compile(bodyemploymentemployment);
            WorkflowExpression.Validate(__workflow_bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            var __workflow_bodyemploymentemploymentStart = bodyemploymentemploymentStart == null ? null : WorkflowExpression.Compile(bodyemploymentemploymentStart);
            WorkflowExpression.Validate(__workflow_bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            var __workflow_bodyemploymentoffice = bodyemploymentoffice == null ? null : WorkflowExpression.Compile(bodyemploymentoffice);
            WorkflowExpression.Validate(__workflow_bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            var __workflow_bodyemploymentssn = bodyemploymentssn == null ? null : WorkflowExpression.Compile(bodyemploymentssn);
            WorkflowExpression.Validate(__workflow_bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            var __workflow_bodyemploymentworkshift = bodyemploymentworkshift == null ? null : WorkflowExpression.Compile(bodyemploymentworkshift);
            WorkflowExpression.Validate(__workflow_bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
            return new DeferredBodyAction<ModifyAgentResponse>(() =>
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
                if (__workflow_bodyaccountexternalId != null)
                {
                    accountObject["external_id"] = ExpressionConverter.ConvertO(__workflow_bodyaccountexternalId);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountinboundNumber != null)
                {
                    accountObject["inbound_number"] = ExpressionConverter.ConvertO(__workflow_bodyaccountinboundNumber);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountlang != null)
                {
                    accountObject["lang"] = ExpressionConverter.ConvertO(__workflow_bodyaccountlang);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountpassword != null)
                {
                    accountObject["password"] = ExpressionConverter.ConvertO(__workflow_bodyaccountpassword);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccounttimeZone != null)
                {
                    accountObject["time_zone"] = ExpressionConverter.ConvertO(__workflow_bodyaccounttimeZone);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountusername != null)
                {
                    accountObject["username"] = ExpressionConverter.ConvertO(__workflow_bodyaccountusername);
                    accountObjectpropCount++;
                }

                if (__workflow_bodyaccountvoipUsername != null)
                {
                    accountObject["voip_username"] = ExpressionConverter.ConvertO(__workflow_bodyaccountvoipUsername);
                    accountObjectpropCount++;
                }

                if (accountObjectpropCount > 0)
                {
                    body["account"] = accountObject;
                    bodypropCount++;
                }

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (__workflow_bodycontactInformationaddress != null)
                {
                    contactInformationObject["address"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (__workflow_bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = ExpressionConverter.ConvertO(__workflow_bodycontactInformationworkphone);
                    contactInformationObjectpropCount++;
                }

                if (contactInformationObjectpropCount > 0)
                {
                    body["contact_information"] = contactInformationObject;
                    bodypropCount++;
                }

                if (__workflow_bodydisable != null)
                {
                    if (__workflow_bodydisable != null)
                    {
                        body["disable"] = ExpressionConverter.ConvertO(__workflow_bodydisable);
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
                if (__workflow_bodyemploymentagentGroupId != null)
                {
                    employmentObject["agent_group_id"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentagentGroupId);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentbankAcc != null)
                {
                    employmentObject["bank_acc"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentbankAcc);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentdescription != null)
                {
                    employmentObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentdescription);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentemployment != null)
                {
                    employmentObject["employment"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentemployment);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentemploymentStart != null)
                {
                    employmentObject["employment_start"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentemploymentStart);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentoffice != null)
                {
                    employmentObject["office"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentoffice);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentssn != null)
                {
                    employmentObject["ssn"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentssn);
                    employmentObjectpropCount++;
                }

                if (__workflow_bodyemploymentworkshift != null)
                {
                    employmentObject["workshift"] = ExpressionConverter.ConvertO(__workflow_bodyemploymentworkshift);
                    employmentObjectpropCount++;
                }

                if (employmentObjectpropCount > 0)
                {
                    body["employment"] = employmentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ModifyAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        public IBodyWorkflowAction<ModifyContactResponse> ModifyContact(Expression<Func<int>> contactId, Expression<Func<string>> fname = null, Expression<Func<string>> lname = null, Expression<Func<string>> phone = null, Expression<Func<string>> birthyear = null, Expression<Func<string>> gender = null, Expression<Func<string>> email = null, Expression<Func<string>> www = null, Expression<Func<string>> address = null, Expression<Func<string>> postcode = null, Expression<Func<string>> city = null, Expression<Func<string>> country = null, Expression<Func<string>> ssc = null, Expression<Func<int>> companyid = null, Expression<Func<string>> company = null, Expression<Func<string>> vatin = null, Expression<Func<string>> title = null, Expression<Func<string>> comment = null, Expression<Func<string>> other1 = null, Expression<Func<string>> other2 = null, Expression<Func<string>> other3 = null, Expression<Func<string>> other4 = null, Expression<Func<string>> other5 = null, Expression<Func<string>> other6 = null, Expression<Func<string>> other7 = null, Expression<Func<string>> other8 = null, Expression<Func<string>> other9 = null, Expression<Func<string>> other10 = null, Expression<Func<string>> other11 = null, Expression<Func<string>> other12 = null, Expression<Func<string>> other13 = null, Expression<Func<string>> other14 = null, Expression<Func<string>> other15 = null, Expression<Func<string>> other16 = null, Expression<Func<string>> other17 = null, Expression<Func<string>> other18 = null, Expression<Func<string>> other19 = null, Expression<Func<string>> other20 = null, Expression<Func<string>> other21 = null, Expression<Func<string>> other22 = null, Expression<Func<string>> other23 = null, Expression<Func<string>> other24 = null, Expression<Func<string>> other25 = null, Expression<Func<string>> other26 = null, Expression<Func<string>> other27 = null, Expression<Func<string>> other28 = null, Expression<Func<string>> other29 = null, Expression<Func<string>> other30 = null, Expression<Func<string>> other31 = null, Expression<Func<string>> other32 = null, Expression<Func<string>> other33 = null, Expression<Func<string>> other34 = null, Expression<Func<string>> other35 = null, Expression<Func<string>> list = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> assignToAgent = null)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            var __workflow_fname = fname == null ? null : WorkflowExpression.Compile(fname);
            WorkflowExpression.Validate(__workflow_fname, nameof(fname), required: false);
            var __workflow_lname = lname == null ? null : WorkflowExpression.Compile(lname);
            WorkflowExpression.Validate(__workflow_lname, nameof(lname), required: false);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: false);
            var __workflow_birthyear = birthyear == null ? null : WorkflowExpression.Compile(birthyear);
            WorkflowExpression.Validate(__workflow_birthyear, nameof(birthyear), required: false);
            var __workflow_gender = gender == null ? null : WorkflowExpression.Compile(gender);
            WorkflowExpression.Validate(__workflow_gender, nameof(gender), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_www = www == null ? null : WorkflowExpression.Compile(www);
            WorkflowExpression.Validate(__workflow_www, nameof(www), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_postcode = postcode == null ? null : WorkflowExpression.Compile(postcode);
            WorkflowExpression.Validate(__workflow_postcode, nameof(postcode), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_country = country == null ? null : WorkflowExpression.Compile(country);
            WorkflowExpression.Validate(__workflow_country, nameof(country), required: false);
            var __workflow_ssc = ssc == null ? null : WorkflowExpression.Compile(ssc);
            WorkflowExpression.Validate(__workflow_ssc, nameof(ssc), required: false);
            var __workflow_companyid = companyid == null ? null : WorkflowExpression.Compile(companyid);
            WorkflowExpression.Validate(__workflow_companyid, nameof(companyid), required: false);
            var __workflow_company = company == null ? null : WorkflowExpression.Compile(company);
            WorkflowExpression.Validate(__workflow_company, nameof(company), required: false);
            var __workflow_vatin = vatin == null ? null : WorkflowExpression.Compile(vatin);
            WorkflowExpression.Validate(__workflow_vatin, nameof(vatin), required: false);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_comment = comment == null ? null : WorkflowExpression.Compile(comment);
            WorkflowExpression.Validate(__workflow_comment, nameof(comment), required: false);
            var __workflow_other1 = other1 == null ? null : WorkflowExpression.Compile(other1);
            WorkflowExpression.Validate(__workflow_other1, nameof(other1), required: false);
            var __workflow_other2 = other2 == null ? null : WorkflowExpression.Compile(other2);
            WorkflowExpression.Validate(__workflow_other2, nameof(other2), required: false);
            var __workflow_other3 = other3 == null ? null : WorkflowExpression.Compile(other3);
            WorkflowExpression.Validate(__workflow_other3, nameof(other3), required: false);
            var __workflow_other4 = other4 == null ? null : WorkflowExpression.Compile(other4);
            WorkflowExpression.Validate(__workflow_other4, nameof(other4), required: false);
            var __workflow_other5 = other5 == null ? null : WorkflowExpression.Compile(other5);
            WorkflowExpression.Validate(__workflow_other5, nameof(other5), required: false);
            var __workflow_other6 = other6 == null ? null : WorkflowExpression.Compile(other6);
            WorkflowExpression.Validate(__workflow_other6, nameof(other6), required: false);
            var __workflow_other7 = other7 == null ? null : WorkflowExpression.Compile(other7);
            WorkflowExpression.Validate(__workflow_other7, nameof(other7), required: false);
            var __workflow_other8 = other8 == null ? null : WorkflowExpression.Compile(other8);
            WorkflowExpression.Validate(__workflow_other8, nameof(other8), required: false);
            var __workflow_other9 = other9 == null ? null : WorkflowExpression.Compile(other9);
            WorkflowExpression.Validate(__workflow_other9, nameof(other9), required: false);
            var __workflow_other10 = other10 == null ? null : WorkflowExpression.Compile(other10);
            WorkflowExpression.Validate(__workflow_other10, nameof(other10), required: false);
            var __workflow_other11 = other11 == null ? null : WorkflowExpression.Compile(other11);
            WorkflowExpression.Validate(__workflow_other11, nameof(other11), required: false);
            var __workflow_other12 = other12 == null ? null : WorkflowExpression.Compile(other12);
            WorkflowExpression.Validate(__workflow_other12, nameof(other12), required: false);
            var __workflow_other13 = other13 == null ? null : WorkflowExpression.Compile(other13);
            WorkflowExpression.Validate(__workflow_other13, nameof(other13), required: false);
            var __workflow_other14 = other14 == null ? null : WorkflowExpression.Compile(other14);
            WorkflowExpression.Validate(__workflow_other14, nameof(other14), required: false);
            var __workflow_other15 = other15 == null ? null : WorkflowExpression.Compile(other15);
            WorkflowExpression.Validate(__workflow_other15, nameof(other15), required: false);
            var __workflow_other16 = other16 == null ? null : WorkflowExpression.Compile(other16);
            WorkflowExpression.Validate(__workflow_other16, nameof(other16), required: false);
            var __workflow_other17 = other17 == null ? null : WorkflowExpression.Compile(other17);
            WorkflowExpression.Validate(__workflow_other17, nameof(other17), required: false);
            var __workflow_other18 = other18 == null ? null : WorkflowExpression.Compile(other18);
            WorkflowExpression.Validate(__workflow_other18, nameof(other18), required: false);
            var __workflow_other19 = other19 == null ? null : WorkflowExpression.Compile(other19);
            WorkflowExpression.Validate(__workflow_other19, nameof(other19), required: false);
            var __workflow_other20 = other20 == null ? null : WorkflowExpression.Compile(other20);
            WorkflowExpression.Validate(__workflow_other20, nameof(other20), required: false);
            var __workflow_other21 = other21 == null ? null : WorkflowExpression.Compile(other21);
            WorkflowExpression.Validate(__workflow_other21, nameof(other21), required: false);
            var __workflow_other22 = other22 == null ? null : WorkflowExpression.Compile(other22);
            WorkflowExpression.Validate(__workflow_other22, nameof(other22), required: false);
            var __workflow_other23 = other23 == null ? null : WorkflowExpression.Compile(other23);
            WorkflowExpression.Validate(__workflow_other23, nameof(other23), required: false);
            var __workflow_other24 = other24 == null ? null : WorkflowExpression.Compile(other24);
            WorkflowExpression.Validate(__workflow_other24, nameof(other24), required: false);
            var __workflow_other25 = other25 == null ? null : WorkflowExpression.Compile(other25);
            WorkflowExpression.Validate(__workflow_other25, nameof(other25), required: false);
            var __workflow_other26 = other26 == null ? null : WorkflowExpression.Compile(other26);
            WorkflowExpression.Validate(__workflow_other26, nameof(other26), required: false);
            var __workflow_other27 = other27 == null ? null : WorkflowExpression.Compile(other27);
            WorkflowExpression.Validate(__workflow_other27, nameof(other27), required: false);
            var __workflow_other28 = other28 == null ? null : WorkflowExpression.Compile(other28);
            WorkflowExpression.Validate(__workflow_other28, nameof(other28), required: false);
            var __workflow_other29 = other29 == null ? null : WorkflowExpression.Compile(other29);
            WorkflowExpression.Validate(__workflow_other29, nameof(other29), required: false);
            var __workflow_other30 = other30 == null ? null : WorkflowExpression.Compile(other30);
            WorkflowExpression.Validate(__workflow_other30, nameof(other30), required: false);
            var __workflow_other31 = other31 == null ? null : WorkflowExpression.Compile(other31);
            WorkflowExpression.Validate(__workflow_other31, nameof(other31), required: false);
            var __workflow_other32 = other32 == null ? null : WorkflowExpression.Compile(other32);
            WorkflowExpression.Validate(__workflow_other32, nameof(other32), required: false);
            var __workflow_other33 = other33 == null ? null : WorkflowExpression.Compile(other33);
            WorkflowExpression.Validate(__workflow_other33, nameof(other33), required: false);
            var __workflow_other34 = other34 == null ? null : WorkflowExpression.Compile(other34);
            WorkflowExpression.Validate(__workflow_other34, nameof(other34), required: false);
            var __workflow_other35 = other35 == null ? null : WorkflowExpression.Compile(other35);
            WorkflowExpression.Validate(__workflow_other35, nameof(other35), required: false);
            var __workflow_list = list == null ? null : WorkflowExpression.Compile(list);
            WorkflowExpression.Validate(__workflow_list, nameof(list), required: false);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: false);
            var __workflow_assignToAgent = assignToAgent == null ? null : WorkflowExpression.Compile(assignToAgent);
            WorkflowExpression.Validate(__workflow_assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<ModifyContactResponse>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
