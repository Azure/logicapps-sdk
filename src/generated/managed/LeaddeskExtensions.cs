//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leaddesk
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeaddeskActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildAgentCampaignAccess))]
        public IBodyWorkflowAction<AgentCampaignAccessResponse> AgentCampaignAccess([WorkflowExpression] Func<int> agentId, [WorkflowExpression] Func<int> campaignId, [WorkflowExpression] Func<typeInput> type)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AgentCampaignAccessResponse> __BuildAgentCampaignAccess(WorkflowExpression<int> agentId, WorkflowExpression<int> campaignId, WorkflowExpression<typeInput> type)
        {
            WorkflowExpression.Validate(agentId, nameof(agentId), required: true);
            WorkflowExpression.Validate(campaignId, nameof(campaignId), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<AgentCampaignAccessResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAgent))]
        public IBodyWorkflowAction<CreateAgentResponse> CreateAgent([WorkflowExpression] Func<string> bodyaccountexternalId = null, [WorkflowExpression] Func<string> bodyaccountinboundNumber = null, [WorkflowExpression] Func<string> bodyaccountlang = null, [WorkflowExpression] Func<string> bodyaccountpassword = null, [WorkflowExpression] Func<string> bodyaccounttimeZone = null, [WorkflowExpression] Func<string> bodyaccountusername = null, [WorkflowExpression] Func<string> bodyaccountvoipUsername = null, [WorkflowExpression] Func<string> bodycontactInformationaddress = null, [WorkflowExpression] Func<string> bodycontactInformationcity = null, [WorkflowExpression] Func<string> bodycontactInformationcountry = null, [WorkflowExpression] Func<string> bodycontactInformationeContacts = null, [WorkflowExpression] Func<string> bodycontactInformationemail = null, [WorkflowExpression] Func<string> bodycontactInformationname = null, [WorkflowExpression] Func<string> bodycontactInformationphone = null, [WorkflowExpression] Func<string> bodycontactInformationpostal = null, [WorkflowExpression] Func<string> bodycontactInformationworkphone = null, [WorkflowExpression] Func<int> bodyemploymentagentGroupId = null, [WorkflowExpression] Func<string> bodyemploymentbankAcc = null, [WorkflowExpression] Func<string> bodyemploymentdescription = null, [WorkflowExpression] Func<bodyemploymentemploymentInput> bodyemploymentemployment = null, [WorkflowExpression] Func<string> bodyemploymentemploymentStart = null, [WorkflowExpression] Func<string> bodyemploymentoffice = null, [WorkflowExpression] Func<string> bodyemploymentssn = null, [WorkflowExpression] Func<string> bodyemploymentworkshift = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAgentResponse> __BuildCreateAgent(WorkflowExpression<string> bodyaccountexternalId = null, WorkflowExpression<string> bodyaccountinboundNumber = null, WorkflowExpression<string> bodyaccountlang = null, WorkflowExpression<string> bodyaccountpassword = null, WorkflowExpression<string> bodyaccounttimeZone = null, WorkflowExpression<string> bodyaccountusername = null, WorkflowExpression<string> bodyaccountvoipUsername = null, WorkflowExpression<string> bodycontactInformationaddress = null, WorkflowExpression<string> bodycontactInformationcity = null, WorkflowExpression<string> bodycontactInformationcountry = null, WorkflowExpression<string> bodycontactInformationeContacts = null, WorkflowExpression<string> bodycontactInformationemail = null, WorkflowExpression<string> bodycontactInformationname = null, WorkflowExpression<string> bodycontactInformationphone = null, WorkflowExpression<string> bodycontactInformationpostal = null, WorkflowExpression<string> bodycontactInformationworkphone = null, WorkflowExpression<int> bodyemploymentagentGroupId = null, WorkflowExpression<string> bodyemploymentbankAcc = null, WorkflowExpression<string> bodyemploymentdescription = null, WorkflowExpression<bodyemploymentemploymentInput> bodyemploymentemployment = null, WorkflowExpression<string> bodyemploymentemploymentStart = null, WorkflowExpression<string> bodyemploymentoffice = null, WorkflowExpression<string> bodyemploymentssn = null, WorkflowExpression<string> bodyemploymentworkshift = null)
        {
            WorkflowExpression.Validate(bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            WorkflowExpression.Validate(bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            WorkflowExpression.Validate(bodyaccountlang, nameof(bodyaccountlang), required: false);
            WorkflowExpression.Validate(bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            WorkflowExpression.Validate(bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            WorkflowExpression.Validate(bodyaccountusername, nameof(bodyaccountusername), required: false);
            WorkflowExpression.Validate(bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            WorkflowExpression.Validate(bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            WorkflowExpression.Validate(bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            WorkflowExpression.Validate(bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            WorkflowExpression.Validate(bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            WorkflowExpression.Validate(bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            WorkflowExpression.Validate(bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            WorkflowExpression.Validate(bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            WorkflowExpression.Validate(bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            WorkflowExpression.Validate(bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            WorkflowExpression.Validate(bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            WorkflowExpression.Validate(bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            WorkflowExpression.Validate(bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            WorkflowExpression.Validate(bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            WorkflowExpression.Validate(bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            WorkflowExpression.Validate(bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            WorkflowExpression.Validate(bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            WorkflowExpression.Validate(bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
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

                accountObject["level"] = "agent";
                accountObjectpropCount++;
                if (bodyaccountpassword != null)
                {
                    accountObject["password"] = ExpressionConverter.ConvertO(bodyaccountpassword);
                    accountObjectpropCount++;
                }

                if (bodyaccounttimeZone != null)
                {
                    if (bodyaccounttimeZone != null)
                    {
                        accountObject["time_zone"] = ExpressionConverter.ConvertO(bodyaccounttimeZone);
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

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (bodycontactInformationaddress != null)
                {
                    contactInformationObject["address"] = ExpressionConverter.ConvertO(bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = ExpressionConverter.ConvertO(bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = ExpressionConverter.ConvertO(bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = ExpressionConverter.ConvertO(bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = ExpressionConverter.ConvertO(bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = ExpressionConverter.ConvertO(bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = ExpressionConverter.ConvertO(bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = ExpressionConverter.ConvertO(bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = ExpressionConverter.ConvertO(bodycontactInformationworkphone);
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
                    if (bodyemploymentemployment != null)
                    {
                        employmentObject["employment"] = ExpressionConverter.ConvertO(bodyemploymentemployment);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCallback))]
        public IBodyWorkflowAction<CreateCallbackResponse> CreateCallback([WorkflowExpression] Func<string> bodycontactaddress = null, [WorkflowExpression] Func<string> bodycontactcity = null, [WorkflowExpression] Func<int> bodycontactcompanyid = null, [WorkflowExpression] Func<string> bodycontactcontactList = null, [WorkflowExpression] Func<string> bodycontactcontactid = null, [WorkflowExpression] Func<string> bodycontactcountry = null, [WorkflowExpression] Func<string> bodycontactfname = null, [WorkflowExpression] Func<string> bodycontactlname = null, [WorkflowExpression] Func<string> bodycontactother1 = null, [WorkflowExpression] Func<string> bodycontactother2 = null, [WorkflowExpression] Func<string> bodycontactother3 = null, [WorkflowExpression] Func<string> bodycontactother4 = null, [WorkflowExpression] Func<string> bodycontactother5 = null, [WorkflowExpression] Func<string> bodycontactother6 = null, [WorkflowExpression] Func<string> bodycontactother7 = null, [WorkflowExpression] Func<string> bodycontactother8 = null, [WorkflowExpression] Func<string> bodycontactother9 = null, [WorkflowExpression] Func<string> bodycontactother10 = null, [WorkflowExpression] Func<string> bodycontactother11 = null, [WorkflowExpression] Func<string> bodycontactother12 = null, [WorkflowExpression] Func<string> bodycontactother13 = null, [WorkflowExpression] Func<string> bodycontactother14 = null, [WorkflowExpression] Func<string> bodycontactother15 = null, [WorkflowExpression] Func<string> bodycontactother16 = null, [WorkflowExpression] Func<string> bodycontactother17 = null, [WorkflowExpression] Func<string> bodycontactother18 = null, [WorkflowExpression] Func<string> bodycontactother19 = null, [WorkflowExpression] Func<string> bodycontactother20 = null, [WorkflowExpression] Func<string> bodycontactother21 = null, [WorkflowExpression] Func<string> bodycontactother22 = null, [WorkflowExpression] Func<string> bodycontactother23 = null, [WorkflowExpression] Func<string> bodycontactother24 = null, [WorkflowExpression] Func<string> bodycontactother25 = null, [WorkflowExpression] Func<string> bodycontactother26 = null, [WorkflowExpression] Func<string> bodycontactother27 = null, [WorkflowExpression] Func<string> bodycontactother28 = null, [WorkflowExpression] Func<string> bodycontactother29 = null, [WorkflowExpression] Func<string> bodycontactother30 = null, [WorkflowExpression] Func<string> bodycontactother31 = null, [WorkflowExpression] Func<string> bodycontactother32 = null, [WorkflowExpression] Func<string> bodycontactother33 = null, [WorkflowExpression] Func<string> bodycontactother34 = null, [WorkflowExpression] Func<string> bodycontactother35 = null, [WorkflowExpression] Func<string> bodycontactpostcode = null, [WorkflowExpression] Func<string> bodypropertiesagent = null, [WorkflowExpression] Func<string> bodypropertiesagentGroup = null, [WorkflowExpression] Func<string> bodypropertiescampaign = null, [WorkflowExpression] Func<string> bodypropertiescomment = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiestimestamp = null, [WorkflowExpression] Func<bodypropertiestypeInput> bodypropertiestype = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCallbackResponse> __BuildCreateCallback(WorkflowExpression<string> bodycontactaddress = null, WorkflowExpression<string> bodycontactcity = null, WorkflowExpression<int> bodycontactcompanyid = null, WorkflowExpression<string> bodycontactcontactList = null, WorkflowExpression<string> bodycontactcontactid = null, WorkflowExpression<string> bodycontactcountry = null, WorkflowExpression<string> bodycontactfname = null, WorkflowExpression<string> bodycontactlname = null, WorkflowExpression<string> bodycontactother1 = null, WorkflowExpression<string> bodycontactother2 = null, WorkflowExpression<string> bodycontactother3 = null, WorkflowExpression<string> bodycontactother4 = null, WorkflowExpression<string> bodycontactother5 = null, WorkflowExpression<string> bodycontactother6 = null, WorkflowExpression<string> bodycontactother7 = null, WorkflowExpression<string> bodycontactother8 = null, WorkflowExpression<string> bodycontactother9 = null, WorkflowExpression<string> bodycontactother10 = null, WorkflowExpression<string> bodycontactother11 = null, WorkflowExpression<string> bodycontactother12 = null, WorkflowExpression<string> bodycontactother13 = null, WorkflowExpression<string> bodycontactother14 = null, WorkflowExpression<string> bodycontactother15 = null, WorkflowExpression<string> bodycontactother16 = null, WorkflowExpression<string> bodycontactother17 = null, WorkflowExpression<string> bodycontactother18 = null, WorkflowExpression<string> bodycontactother19 = null, WorkflowExpression<string> bodycontactother20 = null, WorkflowExpression<string> bodycontactother21 = null, WorkflowExpression<string> bodycontactother22 = null, WorkflowExpression<string> bodycontactother23 = null, WorkflowExpression<string> bodycontactother24 = null, WorkflowExpression<string> bodycontactother25 = null, WorkflowExpression<string> bodycontactother26 = null, WorkflowExpression<string> bodycontactother27 = null, WorkflowExpression<string> bodycontactother28 = null, WorkflowExpression<string> bodycontactother29 = null, WorkflowExpression<string> bodycontactother30 = null, WorkflowExpression<string> bodycontactother31 = null, WorkflowExpression<string> bodycontactother32 = null, WorkflowExpression<string> bodycontactother33 = null, WorkflowExpression<string> bodycontactother34 = null, WorkflowExpression<string> bodycontactother35 = null, WorkflowExpression<string> bodycontactpostcode = null, WorkflowExpression<string> bodypropertiesagent = null, WorkflowExpression<string> bodypropertiesagentGroup = null, WorkflowExpression<string> bodypropertiescampaign = null, WorkflowExpression<string> bodypropertiescomment = null, WorkflowExpression<string> bodypropertiesphone = null, WorkflowExpression<string> bodypropertiestimestamp = null, WorkflowExpression<bodypropertiestypeInput> bodypropertiestype = null)
        {
            WorkflowExpression.Validate(bodycontactaddress, nameof(bodycontactaddress), required: false);
            WorkflowExpression.Validate(bodycontactcity, nameof(bodycontactcity), required: false);
            WorkflowExpression.Validate(bodycontactcompanyid, nameof(bodycontactcompanyid), required: false);
            WorkflowExpression.Validate(bodycontactcontactList, nameof(bodycontactcontactList), required: false);
            WorkflowExpression.Validate(bodycontactcontactid, nameof(bodycontactcontactid), required: false);
            WorkflowExpression.Validate(bodycontactcountry, nameof(bodycontactcountry), required: false);
            WorkflowExpression.Validate(bodycontactfname, nameof(bodycontactfname), required: false);
            WorkflowExpression.Validate(bodycontactlname, nameof(bodycontactlname), required: false);
            WorkflowExpression.Validate(bodycontactother1, nameof(bodycontactother1), required: false);
            WorkflowExpression.Validate(bodycontactother2, nameof(bodycontactother2), required: false);
            WorkflowExpression.Validate(bodycontactother3, nameof(bodycontactother3), required: false);
            WorkflowExpression.Validate(bodycontactother4, nameof(bodycontactother4), required: false);
            WorkflowExpression.Validate(bodycontactother5, nameof(bodycontactother5), required: false);
            WorkflowExpression.Validate(bodycontactother6, nameof(bodycontactother6), required: false);
            WorkflowExpression.Validate(bodycontactother7, nameof(bodycontactother7), required: false);
            WorkflowExpression.Validate(bodycontactother8, nameof(bodycontactother8), required: false);
            WorkflowExpression.Validate(bodycontactother9, nameof(bodycontactother9), required: false);
            WorkflowExpression.Validate(bodycontactother10, nameof(bodycontactother10), required: false);
            WorkflowExpression.Validate(bodycontactother11, nameof(bodycontactother11), required: false);
            WorkflowExpression.Validate(bodycontactother12, nameof(bodycontactother12), required: false);
            WorkflowExpression.Validate(bodycontactother13, nameof(bodycontactother13), required: false);
            WorkflowExpression.Validate(bodycontactother14, nameof(bodycontactother14), required: false);
            WorkflowExpression.Validate(bodycontactother15, nameof(bodycontactother15), required: false);
            WorkflowExpression.Validate(bodycontactother16, nameof(bodycontactother16), required: false);
            WorkflowExpression.Validate(bodycontactother17, nameof(bodycontactother17), required: false);
            WorkflowExpression.Validate(bodycontactother18, nameof(bodycontactother18), required: false);
            WorkflowExpression.Validate(bodycontactother19, nameof(bodycontactother19), required: false);
            WorkflowExpression.Validate(bodycontactother20, nameof(bodycontactother20), required: false);
            WorkflowExpression.Validate(bodycontactother21, nameof(bodycontactother21), required: false);
            WorkflowExpression.Validate(bodycontactother22, nameof(bodycontactother22), required: false);
            WorkflowExpression.Validate(bodycontactother23, nameof(bodycontactother23), required: false);
            WorkflowExpression.Validate(bodycontactother24, nameof(bodycontactother24), required: false);
            WorkflowExpression.Validate(bodycontactother25, nameof(bodycontactother25), required: false);
            WorkflowExpression.Validate(bodycontactother26, nameof(bodycontactother26), required: false);
            WorkflowExpression.Validate(bodycontactother27, nameof(bodycontactother27), required: false);
            WorkflowExpression.Validate(bodycontactother28, nameof(bodycontactother28), required: false);
            WorkflowExpression.Validate(bodycontactother29, nameof(bodycontactother29), required: false);
            WorkflowExpression.Validate(bodycontactother30, nameof(bodycontactother30), required: false);
            WorkflowExpression.Validate(bodycontactother31, nameof(bodycontactother31), required: false);
            WorkflowExpression.Validate(bodycontactother32, nameof(bodycontactother32), required: false);
            WorkflowExpression.Validate(bodycontactother33, nameof(bodycontactother33), required: false);
            WorkflowExpression.Validate(bodycontactother34, nameof(bodycontactother34), required: false);
            WorkflowExpression.Validate(bodycontactother35, nameof(bodycontactother35), required: false);
            WorkflowExpression.Validate(bodycontactpostcode, nameof(bodycontactpostcode), required: false);
            WorkflowExpression.Validate(bodypropertiesagent, nameof(bodypropertiesagent), required: false);
            WorkflowExpression.Validate(bodypropertiesagentGroup, nameof(bodypropertiesagentGroup), required: false);
            WorkflowExpression.Validate(bodypropertiescampaign, nameof(bodypropertiescampaign), required: false);
            WorkflowExpression.Validate(bodypropertiescomment, nameof(bodypropertiescomment), required: false);
            WorkflowExpression.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowExpression.Validate(bodypropertiestimestamp, nameof(bodypropertiestimestamp), required: false);
            WorkflowExpression.Validate(bodypropertiestype, nameof(bodypropertiestype), required: false);
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
                if (bodycontactaddress != null)
                {
                    contactObject["address"] = ExpressionConverter.ConvertO(bodycontactaddress);
                    contactObjectpropCount++;
                }

                if (bodycontactcity != null)
                {
                    contactObject["city"] = ExpressionConverter.ConvertO(bodycontactcity);
                    contactObjectpropCount++;
                }

                if (bodycontactcompanyid != null)
                {
                    contactObject["companyid"] = ExpressionConverter.ConvertO(bodycontactcompanyid);
                    contactObjectpropCount++;
                }

                if (bodycontactcontactList != null)
                {
                    contactObject["contact_list"] = ExpressionConverter.ConvertO(bodycontactcontactList);
                    contactObjectpropCount++;
                }

                if (bodycontactcontactid != null)
                {
                    contactObject["contactid"] = ExpressionConverter.ConvertO(bodycontactcontactid);
                    contactObjectpropCount++;
                }

                if (bodycontactcountry != null)
                {
                    contactObject["country"] = ExpressionConverter.ConvertO(bodycontactcountry);
                    contactObjectpropCount++;
                }

                if (bodycontactfname != null)
                {
                    contactObject["fname"] = ExpressionConverter.ConvertO(bodycontactfname);
                    contactObjectpropCount++;
                }

                if (bodycontactlname != null)
                {
                    contactObject["lname"] = ExpressionConverter.ConvertO(bodycontactlname);
                    contactObjectpropCount++;
                }

                if (bodycontactother1 != null)
                {
                    contactObject["other1"] = ExpressionConverter.ConvertO(bodycontactother1);
                    contactObjectpropCount++;
                }

                if (bodycontactother2 != null)
                {
                    contactObject["other2"] = ExpressionConverter.ConvertO(bodycontactother2);
                    contactObjectpropCount++;
                }

                if (bodycontactother3 != null)
                {
                    contactObject["other3"] = ExpressionConverter.ConvertO(bodycontactother3);
                    contactObjectpropCount++;
                }

                if (bodycontactother4 != null)
                {
                    contactObject["other4"] = ExpressionConverter.ConvertO(bodycontactother4);
                    contactObjectpropCount++;
                }

                if (bodycontactother5 != null)
                {
                    contactObject["other5"] = ExpressionConverter.ConvertO(bodycontactother5);
                    contactObjectpropCount++;
                }

                if (bodycontactother6 != null)
                {
                    contactObject["other6"] = ExpressionConverter.ConvertO(bodycontactother6);
                    contactObjectpropCount++;
                }

                if (bodycontactother7 != null)
                {
                    contactObject["other7"] = ExpressionConverter.ConvertO(bodycontactother7);
                    contactObjectpropCount++;
                }

                if (bodycontactother8 != null)
                {
                    contactObject["other8"] = ExpressionConverter.ConvertO(bodycontactother8);
                    contactObjectpropCount++;
                }

                if (bodycontactother9 != null)
                {
                    contactObject["other9"] = ExpressionConverter.ConvertO(bodycontactother9);
                    contactObjectpropCount++;
                }

                if (bodycontactother10 != null)
                {
                    contactObject["other10"] = ExpressionConverter.ConvertO(bodycontactother10);
                    contactObjectpropCount++;
                }

                if (bodycontactother11 != null)
                {
                    contactObject["other11"] = ExpressionConverter.ConvertO(bodycontactother11);
                    contactObjectpropCount++;
                }

                if (bodycontactother12 != null)
                {
                    contactObject["other12"] = ExpressionConverter.ConvertO(bodycontactother12);
                    contactObjectpropCount++;
                }

                if (bodycontactother13 != null)
                {
                    contactObject["other13"] = ExpressionConverter.ConvertO(bodycontactother13);
                    contactObjectpropCount++;
                }

                if (bodycontactother14 != null)
                {
                    contactObject["other14"] = ExpressionConverter.ConvertO(bodycontactother14);
                    contactObjectpropCount++;
                }

                if (bodycontactother15 != null)
                {
                    contactObject["other15"] = ExpressionConverter.ConvertO(bodycontactother15);
                    contactObjectpropCount++;
                }

                if (bodycontactother16 != null)
                {
                    contactObject["other16"] = ExpressionConverter.ConvertO(bodycontactother16);
                    contactObjectpropCount++;
                }

                if (bodycontactother17 != null)
                {
                    contactObject["other17"] = ExpressionConverter.ConvertO(bodycontactother17);
                    contactObjectpropCount++;
                }

                if (bodycontactother18 != null)
                {
                    contactObject["other18"] = ExpressionConverter.ConvertO(bodycontactother18);
                    contactObjectpropCount++;
                }

                if (bodycontactother19 != null)
                {
                    contactObject["other19"] = ExpressionConverter.ConvertO(bodycontactother19);
                    contactObjectpropCount++;
                }

                if (bodycontactother20 != null)
                {
                    contactObject["other20"] = ExpressionConverter.ConvertO(bodycontactother20);
                    contactObjectpropCount++;
                }

                if (bodycontactother21 != null)
                {
                    contactObject["other21"] = ExpressionConverter.ConvertO(bodycontactother21);
                    contactObjectpropCount++;
                }

                if (bodycontactother22 != null)
                {
                    contactObject["other22"] = ExpressionConverter.ConvertO(bodycontactother22);
                    contactObjectpropCount++;
                }

                if (bodycontactother23 != null)
                {
                    contactObject["other23"] = ExpressionConverter.ConvertO(bodycontactother23);
                    contactObjectpropCount++;
                }

                if (bodycontactother24 != null)
                {
                    contactObject["other24"] = ExpressionConverter.ConvertO(bodycontactother24);
                    contactObjectpropCount++;
                }

                if (bodycontactother25 != null)
                {
                    contactObject["other25"] = ExpressionConverter.ConvertO(bodycontactother25);
                    contactObjectpropCount++;
                }

                if (bodycontactother26 != null)
                {
                    contactObject["other26"] = ExpressionConverter.ConvertO(bodycontactother26);
                    contactObjectpropCount++;
                }

                if (bodycontactother27 != null)
                {
                    contactObject["other27"] = ExpressionConverter.ConvertO(bodycontactother27);
                    contactObjectpropCount++;
                }

                if (bodycontactother28 != null)
                {
                    contactObject["other28"] = ExpressionConverter.ConvertO(bodycontactother28);
                    contactObjectpropCount++;
                }

                if (bodycontactother29 != null)
                {
                    contactObject["other29"] = ExpressionConverter.ConvertO(bodycontactother29);
                    contactObjectpropCount++;
                }

                if (bodycontactother30 != null)
                {
                    contactObject["other30"] = ExpressionConverter.ConvertO(bodycontactother30);
                    contactObjectpropCount++;
                }

                if (bodycontactother31 != null)
                {
                    contactObject["other31"] = ExpressionConverter.ConvertO(bodycontactother31);
                    contactObjectpropCount++;
                }

                if (bodycontactother32 != null)
                {
                    contactObject["other32"] = ExpressionConverter.ConvertO(bodycontactother32);
                    contactObjectpropCount++;
                }

                if (bodycontactother33 != null)
                {
                    contactObject["other33"] = ExpressionConverter.ConvertO(bodycontactother33);
                    contactObjectpropCount++;
                }

                if (bodycontactother34 != null)
                {
                    contactObject["other34"] = ExpressionConverter.ConvertO(bodycontactother34);
                    contactObjectpropCount++;
                }

                if (bodycontactother35 != null)
                {
                    contactObject["other35"] = ExpressionConverter.ConvertO(bodycontactother35);
                    contactObjectpropCount++;
                }

                if (bodycontactpostcode != null)
                {
                    contactObject["postcode"] = ExpressionConverter.ConvertO(bodycontactpostcode);
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
                    propertiesObject["agent"] = ExpressionConverter.ConvertO(bodypropertiesagent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesagentGroup != null)
                {
                    propertiesObject["agent_group"] = ExpressionConverter.ConvertO(bodypropertiesagentGroup);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescampaign != null)
                {
                    propertiesObject["campaign"] = ExpressionConverter.ConvertO(bodypropertiescampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescomment != null)
                {
                    propertiesObject["comment"] = ExpressionConverter.ConvertO(bodypropertiescomment);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimestamp != null)
                {
                    propertiesObject["timestamp"] = ExpressionConverter.ConvertO(bodypropertiestimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestype != null)
                {
                    if (bodypropertiestype != null)
                    {
                        propertiesObject["type"] = ExpressionConverter.ConvertO(bodypropertiestype);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateContact))]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> phone, [WorkflowExpression] Func<string> list, [WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> www = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> postcode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> ssc = null, [WorkflowExpression] Func<string> birthyear = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> companyid = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<string> vatin = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> other1 = null, [WorkflowExpression] Func<string> other2 = null, [WorkflowExpression] Func<string> other3 = null, [WorkflowExpression] Func<string> other4 = null, [WorkflowExpression] Func<string> other5 = null, [WorkflowExpression] Func<string> other6 = null, [WorkflowExpression] Func<string> other7 = null, [WorkflowExpression] Func<string> other8 = null, [WorkflowExpression] Func<string> other9 = null, [WorkflowExpression] Func<string> other10 = null, [WorkflowExpression] Func<string> other11 = null, [WorkflowExpression] Func<string> other12 = null, [WorkflowExpression] Func<string> other13 = null, [WorkflowExpression] Func<string> other14 = null, [WorkflowExpression] Func<string> other15 = null, [WorkflowExpression] Func<string> other16 = null, [WorkflowExpression] Func<string> other17 = null, [WorkflowExpression] Func<string> other18 = null, [WorkflowExpression] Func<string> other19 = null, [WorkflowExpression] Func<string> other20 = null, [WorkflowExpression] Func<string> other21 = null, [WorkflowExpression] Func<string> other22 = null, [WorkflowExpression] Func<string> other23 = null, [WorkflowExpression] Func<string> other24 = null, [WorkflowExpression] Func<string> other25 = null, [WorkflowExpression] Func<string> other26 = null, [WorkflowExpression] Func<string> other27 = null, [WorkflowExpression] Func<string> other28 = null, [WorkflowExpression] Func<string> other29 = null, [WorkflowExpression] Func<string> other30 = null, [WorkflowExpression] Func<string> other31 = null, [WorkflowExpression] Func<string> other32 = null, [WorkflowExpression] Func<string> other33 = null, [WorkflowExpression] Func<string> other34 = null, [WorkflowExpression] Func<string> other35 = null, [WorkflowExpression] Func<string> assignToAgent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowExpression<string> phone, WorkflowExpression<string> list, WorkflowExpression<string> fname = null, WorkflowExpression<string> lname = null, WorkflowExpression<string> email = null, WorkflowExpression<string> www = null, WorkflowExpression<string> address = null, WorkflowExpression<string> postcode = null, WorkflowExpression<string> city = null, WorkflowExpression<string> country = null, WorkflowExpression<string> ssc = null, WorkflowExpression<string> birthyear = null, WorkflowExpression<string> gender = null, WorkflowExpression<string> companyid = null, WorkflowExpression<string> company = null, WorkflowExpression<string> vatin = null, WorkflowExpression<string> title = null, WorkflowExpression<string> comment = null, WorkflowExpression<string> other1 = null, WorkflowExpression<string> other2 = null, WorkflowExpression<string> other3 = null, WorkflowExpression<string> other4 = null, WorkflowExpression<string> other5 = null, WorkflowExpression<string> other6 = null, WorkflowExpression<string> other7 = null, WorkflowExpression<string> other8 = null, WorkflowExpression<string> other9 = null, WorkflowExpression<string> other10 = null, WorkflowExpression<string> other11 = null, WorkflowExpression<string> other12 = null, WorkflowExpression<string> other13 = null, WorkflowExpression<string> other14 = null, WorkflowExpression<string> other15 = null, WorkflowExpression<string> other16 = null, WorkflowExpression<string> other17 = null, WorkflowExpression<string> other18 = null, WorkflowExpression<string> other19 = null, WorkflowExpression<string> other20 = null, WorkflowExpression<string> other21 = null, WorkflowExpression<string> other22 = null, WorkflowExpression<string> other23 = null, WorkflowExpression<string> other24 = null, WorkflowExpression<string> other25 = null, WorkflowExpression<string> other26 = null, WorkflowExpression<string> other27 = null, WorkflowExpression<string> other28 = null, WorkflowExpression<string> other29 = null, WorkflowExpression<string> other30 = null, WorkflowExpression<string> other31 = null, WorkflowExpression<string> other32 = null, WorkflowExpression<string> other33 = null, WorkflowExpression<string> other34 = null, WorkflowExpression<string> other35 = null, WorkflowExpression<string> assignToAgent = null)
        {
            WorkflowExpression.Validate(phone, nameof(phone), required: true);
            WorkflowExpression.Validate(list, nameof(list), required: true);
            WorkflowExpression.Validate(fname, nameof(fname), required: false);
            WorkflowExpression.Validate(lname, nameof(lname), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(www, nameof(www), required: false);
            WorkflowExpression.Validate(address, nameof(address), required: false);
            WorkflowExpression.Validate(postcode, nameof(postcode), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(ssc, nameof(ssc), required: false);
            WorkflowExpression.Validate(birthyear, nameof(birthyear), required: false);
            WorkflowExpression.Validate(gender, nameof(gender), required: false);
            WorkflowExpression.Validate(companyid, nameof(companyid), required: false);
            WorkflowExpression.Validate(company, nameof(company), required: false);
            WorkflowExpression.Validate(vatin, nameof(vatin), required: false);
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(comment, nameof(comment), required: false);
            WorkflowExpression.Validate(other1, nameof(other1), required: false);
            WorkflowExpression.Validate(other2, nameof(other2), required: false);
            WorkflowExpression.Validate(other3, nameof(other3), required: false);
            WorkflowExpression.Validate(other4, nameof(other4), required: false);
            WorkflowExpression.Validate(other5, nameof(other5), required: false);
            WorkflowExpression.Validate(other6, nameof(other6), required: false);
            WorkflowExpression.Validate(other7, nameof(other7), required: false);
            WorkflowExpression.Validate(other8, nameof(other8), required: false);
            WorkflowExpression.Validate(other9, nameof(other9), required: false);
            WorkflowExpression.Validate(other10, nameof(other10), required: false);
            WorkflowExpression.Validate(other11, nameof(other11), required: false);
            WorkflowExpression.Validate(other12, nameof(other12), required: false);
            WorkflowExpression.Validate(other13, nameof(other13), required: false);
            WorkflowExpression.Validate(other14, nameof(other14), required: false);
            WorkflowExpression.Validate(other15, nameof(other15), required: false);
            WorkflowExpression.Validate(other16, nameof(other16), required: false);
            WorkflowExpression.Validate(other17, nameof(other17), required: false);
            WorkflowExpression.Validate(other18, nameof(other18), required: false);
            WorkflowExpression.Validate(other19, nameof(other19), required: false);
            WorkflowExpression.Validate(other20, nameof(other20), required: false);
            WorkflowExpression.Validate(other21, nameof(other21), required: false);
            WorkflowExpression.Validate(other22, nameof(other22), required: false);
            WorkflowExpression.Validate(other23, nameof(other23), required: false);
            WorkflowExpression.Validate(other24, nameof(other24), required: false);
            WorkflowExpression.Validate(other25, nameof(other25), required: false);
            WorkflowExpression.Validate(other26, nameof(other26), required: false);
            WorkflowExpression.Validate(other27, nameof(other27), required: false);
            WorkflowExpression.Validate(other28, nameof(other28), required: false);
            WorkflowExpression.Validate(other29, nameof(other29), required: false);
            WorkflowExpression.Validate(other30, nameof(other30), required: false);
            WorkflowExpression.Validate(other31, nameof(other31), required: false);
            WorkflowExpression.Validate(other32, nameof(other32), required: false);
            WorkflowExpression.Validate(other33, nameof(other33), required: false);
            WorkflowExpression.Validate(other34, nameof(other34), required: false);
            WorkflowExpression.Validate(other35, nameof(other35), required: false);
            WorkflowExpression.Validate(assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildFindAgent))]
        public IBodyWorkflowAction<FindAgentResponse> FindAgent([WorkflowExpression] Func<string> username)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindAgentResponse> __BuildFindAgent(WorkflowExpression<string> username)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            return new DeferredBodyAction<FindAgentResponse>(() =>
            {
                var apiCallPath = "/find_agent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mod"] = Convert.ToString("agent");
                callPayload.Queries["cmd"] = Convert.ToString("find");
                callPayload.Queries["username"] = ExpressionConverter.Convert(username);
                return new ApiConnectionAction<FindAgentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildFindContact))]
        public IBodyWorkflowAction<FindContactResponse> FindContact([WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<int> phone = null, [WorkflowExpression] Func<int> contactListId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindContactResponse> __BuildFindContact(WorkflowExpression<string> fname = null, WorkflowExpression<string> lname = null, WorkflowExpression<int> phone = null, WorkflowExpression<int> contactListId = null)
        {
            WorkflowExpression.Validate(fname, nameof(fname), required: false);
            WorkflowExpression.Validate(lname, nameof(lname), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(contactListId, nameof(contactListId), required: false);
            return new DeferredBodyAction<FindContactResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildModifyAgent))]
        public IBodyWorkflowAction<ModifyAgentResponse> ModifyAgent([WorkflowExpression] Func<int> bodyid, [WorkflowExpression] Func<string> bodyaccountexternalId = null, [WorkflowExpression] Func<string> bodyaccountinboundNumber = null, [WorkflowExpression] Func<int> bodyaccountlang = null, [WorkflowExpression] Func<string> bodyaccountpassword = null, [WorkflowExpression] Func<string> bodyaccounttimeZone = null, [WorkflowExpression] Func<string> bodyaccountusername = null, [WorkflowExpression] Func<string> bodyaccountvoipUsername = null, [WorkflowExpression] Func<string> bodycontactInformationaddress = null, [WorkflowExpression] Func<string> bodycontactInformationcity = null, [WorkflowExpression] Func<string> bodycontactInformationcountry = null, [WorkflowExpression] Func<string> bodycontactInformationeContacts = null, [WorkflowExpression] Func<string> bodycontactInformationemail = null, [WorkflowExpression] Func<string> bodycontactInformationname = null, [WorkflowExpression] Func<string> bodycontactInformationphone = null, [WorkflowExpression] Func<string> bodycontactInformationpostal = null, [WorkflowExpression] Func<string> bodycontactInformationworkphone = null, [WorkflowExpression] Func<bool> bodydisable = null, [WorkflowExpression] Func<int> bodyemploymentagentGroupId = null, [WorkflowExpression] Func<string> bodyemploymentbankAcc = null, [WorkflowExpression] Func<string> bodyemploymentdescription = null, [WorkflowExpression] Func<bodyemploymentemploymentInput> bodyemploymentemployment = null, [WorkflowExpression] Func<string> bodyemploymentemploymentStart = null, [WorkflowExpression] Func<string> bodyemploymentoffice = null, [WorkflowExpression] Func<string> bodyemploymentssn = null, [WorkflowExpression] Func<string> bodyemploymentworkshift = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyAgentResponse> __BuildModifyAgent(WorkflowExpression<int> bodyid, WorkflowExpression<string> bodyaccountexternalId = null, WorkflowExpression<string> bodyaccountinboundNumber = null, WorkflowExpression<int> bodyaccountlang = null, WorkflowExpression<string> bodyaccountpassword = null, WorkflowExpression<string> bodyaccounttimeZone = null, WorkflowExpression<string> bodyaccountusername = null, WorkflowExpression<string> bodyaccountvoipUsername = null, WorkflowExpression<string> bodycontactInformationaddress = null, WorkflowExpression<string> bodycontactInformationcity = null, WorkflowExpression<string> bodycontactInformationcountry = null, WorkflowExpression<string> bodycontactInformationeContacts = null, WorkflowExpression<string> bodycontactInformationemail = null, WorkflowExpression<string> bodycontactInformationname = null, WorkflowExpression<string> bodycontactInformationphone = null, WorkflowExpression<string> bodycontactInformationpostal = null, WorkflowExpression<string> bodycontactInformationworkphone = null, WorkflowExpression<bool> bodydisable = null, WorkflowExpression<int> bodyemploymentagentGroupId = null, WorkflowExpression<string> bodyemploymentbankAcc = null, WorkflowExpression<string> bodyemploymentdescription = null, WorkflowExpression<bodyemploymentemploymentInput> bodyemploymentemployment = null, WorkflowExpression<string> bodyemploymentemploymentStart = null, WorkflowExpression<string> bodyemploymentoffice = null, WorkflowExpression<string> bodyemploymentssn = null, WorkflowExpression<string> bodyemploymentworkshift = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            WorkflowExpression.Validate(bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            WorkflowExpression.Validate(bodyaccountlang, nameof(bodyaccountlang), required: false);
            WorkflowExpression.Validate(bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            WorkflowExpression.Validate(bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            WorkflowExpression.Validate(bodyaccountusername, nameof(bodyaccountusername), required: false);
            WorkflowExpression.Validate(bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            WorkflowExpression.Validate(bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            WorkflowExpression.Validate(bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            WorkflowExpression.Validate(bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            WorkflowExpression.Validate(bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            WorkflowExpression.Validate(bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            WorkflowExpression.Validate(bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            WorkflowExpression.Validate(bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            WorkflowExpression.Validate(bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            WorkflowExpression.Validate(bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            WorkflowExpression.Validate(bodydisable, nameof(bodydisable), required: false);
            WorkflowExpression.Validate(bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            WorkflowExpression.Validate(bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            WorkflowExpression.Validate(bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            WorkflowExpression.Validate(bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            WorkflowExpression.Validate(bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            WorkflowExpression.Validate(bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            WorkflowExpression.Validate(bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            WorkflowExpression.Validate(bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
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

                var contactInformationObject = new JObject();
                var contactInformationObjectpropCount = 0;
                if (bodycontactInformationaddress != null)
                {
                    contactInformationObject["address"] = ExpressionConverter.ConvertO(bodycontactInformationaddress);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcity != null)
                {
                    contactInformationObject["city"] = ExpressionConverter.ConvertO(bodycontactInformationcity);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationcountry != null)
                {
                    contactInformationObject["country"] = ExpressionConverter.ConvertO(bodycontactInformationcountry);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationeContacts != null)
                {
                    contactInformationObject["e_contacts"] = ExpressionConverter.ConvertO(bodycontactInformationeContacts);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationemail != null)
                {
                    contactInformationObject["email"] = ExpressionConverter.ConvertO(bodycontactInformationemail);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationname != null)
                {
                    contactInformationObject["name"] = ExpressionConverter.ConvertO(bodycontactInformationname);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationphone != null)
                {
                    contactInformationObject["phone"] = ExpressionConverter.ConvertO(bodycontactInformationphone);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationpostal != null)
                {
                    contactInformationObject["postal"] = ExpressionConverter.ConvertO(bodycontactInformationpostal);
                    contactInformationObjectpropCount++;
                }

                if (bodycontactInformationworkphone != null)
                {
                    contactInformationObject["workphone"] = ExpressionConverter.ConvertO(bodycontactInformationworkphone);
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
                        body["disable"] = ExpressionConverter.ConvertO(bodydisable);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [WorkflowExpressionFactory(nameof(__BuildModifyContact))]
        public IBodyWorkflowAction<ModifyContactResponse> ModifyContact([WorkflowExpression] Func<int> contactId, [WorkflowExpression] Func<string> fname = null, [WorkflowExpression] Func<string> lname = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> birthyear = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> www = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> postcode = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> ssc = null, [WorkflowExpression] Func<int> companyid = null, [WorkflowExpression] Func<string> company = null, [WorkflowExpression] Func<string> vatin = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> other1 = null, [WorkflowExpression] Func<string> other2 = null, [WorkflowExpression] Func<string> other3 = null, [WorkflowExpression] Func<string> other4 = null, [WorkflowExpression] Func<string> other5 = null, [WorkflowExpression] Func<string> other6 = null, [WorkflowExpression] Func<string> other7 = null, [WorkflowExpression] Func<string> other8 = null, [WorkflowExpression] Func<string> other9 = null, [WorkflowExpression] Func<string> other10 = null, [WorkflowExpression] Func<string> other11 = null, [WorkflowExpression] Func<string> other12 = null, [WorkflowExpression] Func<string> other13 = null, [WorkflowExpression] Func<string> other14 = null, [WorkflowExpression] Func<string> other15 = null, [WorkflowExpression] Func<string> other16 = null, [WorkflowExpression] Func<string> other17 = null, [WorkflowExpression] Func<string> other18 = null, [WorkflowExpression] Func<string> other19 = null, [WorkflowExpression] Func<string> other20 = null, [WorkflowExpression] Func<string> other21 = null, [WorkflowExpression] Func<string> other22 = null, [WorkflowExpression] Func<string> other23 = null, [WorkflowExpression] Func<string> other24 = null, [WorkflowExpression] Func<string> other25 = null, [WorkflowExpression] Func<string> other26 = null, [WorkflowExpression] Func<string> other27 = null, [WorkflowExpression] Func<string> other28 = null, [WorkflowExpression] Func<string> other29 = null, [WorkflowExpression] Func<string> other30 = null, [WorkflowExpression] Func<string> other31 = null, [WorkflowExpression] Func<string> other32 = null, [WorkflowExpression] Func<string> other33 = null, [WorkflowExpression] Func<string> other34 = null, [WorkflowExpression] Func<string> other35 = null, [WorkflowExpression] Func<string> list = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> assignToAgent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leaddesk")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyContactResponse> __BuildModifyContact(WorkflowExpression<int> contactId, WorkflowExpression<string> fname = null, WorkflowExpression<string> lname = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> birthyear = null, WorkflowExpression<string> gender = null, WorkflowExpression<string> email = null, WorkflowExpression<string> www = null, WorkflowExpression<string> address = null, WorkflowExpression<string> postcode = null, WorkflowExpression<string> city = null, WorkflowExpression<string> country = null, WorkflowExpression<string> ssc = null, WorkflowExpression<int> companyid = null, WorkflowExpression<string> company = null, WorkflowExpression<string> vatin = null, WorkflowExpression<string> title = null, WorkflowExpression<string> comment = null, WorkflowExpression<string> other1 = null, WorkflowExpression<string> other2 = null, WorkflowExpression<string> other3 = null, WorkflowExpression<string> other4 = null, WorkflowExpression<string> other5 = null, WorkflowExpression<string> other6 = null, WorkflowExpression<string> other7 = null, WorkflowExpression<string> other8 = null, WorkflowExpression<string> other9 = null, WorkflowExpression<string> other10 = null, WorkflowExpression<string> other11 = null, WorkflowExpression<string> other12 = null, WorkflowExpression<string> other13 = null, WorkflowExpression<string> other14 = null, WorkflowExpression<string> other15 = null, WorkflowExpression<string> other16 = null, WorkflowExpression<string> other17 = null, WorkflowExpression<string> other18 = null, WorkflowExpression<string> other19 = null, WorkflowExpression<string> other20 = null, WorkflowExpression<string> other21 = null, WorkflowExpression<string> other22 = null, WorkflowExpression<string> other23 = null, WorkflowExpression<string> other24 = null, WorkflowExpression<string> other25 = null, WorkflowExpression<string> other26 = null, WorkflowExpression<string> other27 = null, WorkflowExpression<string> other28 = null, WorkflowExpression<string> other29 = null, WorkflowExpression<string> other30 = null, WorkflowExpression<string> other31 = null, WorkflowExpression<string> other32 = null, WorkflowExpression<string> other33 = null, WorkflowExpression<string> other34 = null, WorkflowExpression<string> other35 = null, WorkflowExpression<string> list = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<string> assignToAgent = null)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(fname, nameof(fname), required: false);
            WorkflowExpression.Validate(lname, nameof(lname), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(birthyear, nameof(birthyear), required: false);
            WorkflowExpression.Validate(gender, nameof(gender), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(www, nameof(www), required: false);
            WorkflowExpression.Validate(address, nameof(address), required: false);
            WorkflowExpression.Validate(postcode, nameof(postcode), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(ssc, nameof(ssc), required: false);
            WorkflowExpression.Validate(companyid, nameof(companyid), required: false);
            WorkflowExpression.Validate(company, nameof(company), required: false);
            WorkflowExpression.Validate(vatin, nameof(vatin), required: false);
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(comment, nameof(comment), required: false);
            WorkflowExpression.Validate(other1, nameof(other1), required: false);
            WorkflowExpression.Validate(other2, nameof(other2), required: false);
            WorkflowExpression.Validate(other3, nameof(other3), required: false);
            WorkflowExpression.Validate(other4, nameof(other4), required: false);
            WorkflowExpression.Validate(other5, nameof(other5), required: false);
            WorkflowExpression.Validate(other6, nameof(other6), required: false);
            WorkflowExpression.Validate(other7, nameof(other7), required: false);
            WorkflowExpression.Validate(other8, nameof(other8), required: false);
            WorkflowExpression.Validate(other9, nameof(other9), required: false);
            WorkflowExpression.Validate(other10, nameof(other10), required: false);
            WorkflowExpression.Validate(other11, nameof(other11), required: false);
            WorkflowExpression.Validate(other12, nameof(other12), required: false);
            WorkflowExpression.Validate(other13, nameof(other13), required: false);
            WorkflowExpression.Validate(other14, nameof(other14), required: false);
            WorkflowExpression.Validate(other15, nameof(other15), required: false);
            WorkflowExpression.Validate(other16, nameof(other16), required: false);
            WorkflowExpression.Validate(other17, nameof(other17), required: false);
            WorkflowExpression.Validate(other18, nameof(other18), required: false);
            WorkflowExpression.Validate(other19, nameof(other19), required: false);
            WorkflowExpression.Validate(other20, nameof(other20), required: false);
            WorkflowExpression.Validate(other21, nameof(other21), required: false);
            WorkflowExpression.Validate(other22, nameof(other22), required: false);
            WorkflowExpression.Validate(other23, nameof(other23), required: false);
            WorkflowExpression.Validate(other24, nameof(other24), required: false);
            WorkflowExpression.Validate(other25, nameof(other25), required: false);
            WorkflowExpression.Validate(other26, nameof(other26), required: false);
            WorkflowExpression.Validate(other27, nameof(other27), required: false);
            WorkflowExpression.Validate(other28, nameof(other28), required: false);
            WorkflowExpression.Validate(other29, nameof(other29), required: false);
            WorkflowExpression.Validate(other30, nameof(other30), required: false);
            WorkflowExpression.Validate(other31, nameof(other31), required: false);
            WorkflowExpression.Validate(other32, nameof(other32), required: false);
            WorkflowExpression.Validate(other33, nameof(other33), required: false);
            WorkflowExpression.Validate(other34, nameof(other34), required: false);
            WorkflowExpression.Validate(other35, nameof(other35), required: false);
            WorkflowExpression.Validate(list, nameof(list), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(assignToAgent, nameof(assignToAgent), required: false);
            return new DeferredBodyAction<ModifyContactResponse>(() =>
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