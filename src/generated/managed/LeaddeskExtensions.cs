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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AgentCampaignAccessResponse> __BuildAgentCampaignAccess(WorkflowValue<int> agentId, WorkflowValue<int> campaignId, WorkflowValue<typeInput> type)
        {
            WorkflowValue.Validate(agentId, nameof(agentId), required: true);
            WorkflowValue.Validate(campaignId, nameof(campaignId), required: true);
            WorkflowValue.Validate(type, nameof(type), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAgentResponse> __BuildCreateAgent(WorkflowValue<string> bodyaccountexternalId = null, WorkflowValue<string> bodyaccountinboundNumber = null, WorkflowValue<string> bodyaccountlang = null, WorkflowValue<string> bodyaccountpassword = null, WorkflowValue<string> bodyaccounttimeZone = null, WorkflowValue<string> bodyaccountusername = null, WorkflowValue<string> bodyaccountvoipUsername = null, WorkflowValue<string> bodycontactInformationaddress = null, WorkflowValue<string> bodycontactInformationcity = null, WorkflowValue<string> bodycontactInformationcountry = null, WorkflowValue<string> bodycontactInformationeContacts = null, WorkflowValue<string> bodycontactInformationemail = null, WorkflowValue<string> bodycontactInformationname = null, WorkflowValue<string> bodycontactInformationphone = null, WorkflowValue<string> bodycontactInformationpostal = null, WorkflowValue<string> bodycontactInformationworkphone = null, WorkflowValue<int> bodyemploymentagentGroupId = null, WorkflowValue<string> bodyemploymentbankAcc = null, WorkflowValue<string> bodyemploymentdescription = null, WorkflowValue<bodyemploymentemploymentInput> bodyemploymentemployment = null, WorkflowValue<string> bodyemploymentemploymentStart = null, WorkflowValue<string> bodyemploymentoffice = null, WorkflowValue<string> bodyemploymentssn = null, WorkflowValue<string> bodyemploymentworkshift = null)
        {
            WorkflowValue.Validate(bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            WorkflowValue.Validate(bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            WorkflowValue.Validate(bodyaccountlang, nameof(bodyaccountlang), required: false);
            WorkflowValue.Validate(bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            WorkflowValue.Validate(bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            WorkflowValue.Validate(bodyaccountusername, nameof(bodyaccountusername), required: false);
            WorkflowValue.Validate(bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            WorkflowValue.Validate(bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            WorkflowValue.Validate(bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            WorkflowValue.Validate(bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            WorkflowValue.Validate(bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            WorkflowValue.Validate(bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            WorkflowValue.Validate(bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            WorkflowValue.Validate(bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            WorkflowValue.Validate(bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            WorkflowValue.Validate(bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            WorkflowValue.Validate(bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            WorkflowValue.Validate(bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            WorkflowValue.Validate(bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            WorkflowValue.Validate(bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            WorkflowValue.Validate(bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            WorkflowValue.Validate(bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            WorkflowValue.Validate(bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            WorkflowValue.Validate(bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCallbackResponse> __BuildCreateCallback(WorkflowValue<string> bodycontactaddress = null, WorkflowValue<string> bodycontactcity = null, WorkflowValue<int> bodycontactcompanyid = null, WorkflowValue<string> bodycontactcontactList = null, WorkflowValue<string> bodycontactcontactid = null, WorkflowValue<string> bodycontactcountry = null, WorkflowValue<string> bodycontactfname = null, WorkflowValue<string> bodycontactlname = null, WorkflowValue<string> bodycontactother1 = null, WorkflowValue<string> bodycontactother2 = null, WorkflowValue<string> bodycontactother3 = null, WorkflowValue<string> bodycontactother4 = null, WorkflowValue<string> bodycontactother5 = null, WorkflowValue<string> bodycontactother6 = null, WorkflowValue<string> bodycontactother7 = null, WorkflowValue<string> bodycontactother8 = null, WorkflowValue<string> bodycontactother9 = null, WorkflowValue<string> bodycontactother10 = null, WorkflowValue<string> bodycontactother11 = null, WorkflowValue<string> bodycontactother12 = null, WorkflowValue<string> bodycontactother13 = null, WorkflowValue<string> bodycontactother14 = null, WorkflowValue<string> bodycontactother15 = null, WorkflowValue<string> bodycontactother16 = null, WorkflowValue<string> bodycontactother17 = null, WorkflowValue<string> bodycontactother18 = null, WorkflowValue<string> bodycontactother19 = null, WorkflowValue<string> bodycontactother20 = null, WorkflowValue<string> bodycontactother21 = null, WorkflowValue<string> bodycontactother22 = null, WorkflowValue<string> bodycontactother23 = null, WorkflowValue<string> bodycontactother24 = null, WorkflowValue<string> bodycontactother25 = null, WorkflowValue<string> bodycontactother26 = null, WorkflowValue<string> bodycontactother27 = null, WorkflowValue<string> bodycontactother28 = null, WorkflowValue<string> bodycontactother29 = null, WorkflowValue<string> bodycontactother30 = null, WorkflowValue<string> bodycontactother31 = null, WorkflowValue<string> bodycontactother32 = null, WorkflowValue<string> bodycontactother33 = null, WorkflowValue<string> bodycontactother34 = null, WorkflowValue<string> bodycontactother35 = null, WorkflowValue<string> bodycontactpostcode = null, WorkflowValue<string> bodypropertiesagent = null, WorkflowValue<string> bodypropertiesagentGroup = null, WorkflowValue<string> bodypropertiescampaign = null, WorkflowValue<string> bodypropertiescomment = null, WorkflowValue<string> bodypropertiesphone = null, WorkflowValue<string> bodypropertiestimestamp = null, WorkflowValue<bodypropertiestypeInput> bodypropertiestype = null)
        {
            WorkflowValue.Validate(bodycontactaddress, nameof(bodycontactaddress), required: false);
            WorkflowValue.Validate(bodycontactcity, nameof(bodycontactcity), required: false);
            WorkflowValue.Validate(bodycontactcompanyid, nameof(bodycontactcompanyid), required: false);
            WorkflowValue.Validate(bodycontactcontactList, nameof(bodycontactcontactList), required: false);
            WorkflowValue.Validate(bodycontactcontactid, nameof(bodycontactcontactid), required: false);
            WorkflowValue.Validate(bodycontactcountry, nameof(bodycontactcountry), required: false);
            WorkflowValue.Validate(bodycontactfname, nameof(bodycontactfname), required: false);
            WorkflowValue.Validate(bodycontactlname, nameof(bodycontactlname), required: false);
            WorkflowValue.Validate(bodycontactother1, nameof(bodycontactother1), required: false);
            WorkflowValue.Validate(bodycontactother2, nameof(bodycontactother2), required: false);
            WorkflowValue.Validate(bodycontactother3, nameof(bodycontactother3), required: false);
            WorkflowValue.Validate(bodycontactother4, nameof(bodycontactother4), required: false);
            WorkflowValue.Validate(bodycontactother5, nameof(bodycontactother5), required: false);
            WorkflowValue.Validate(bodycontactother6, nameof(bodycontactother6), required: false);
            WorkflowValue.Validate(bodycontactother7, nameof(bodycontactother7), required: false);
            WorkflowValue.Validate(bodycontactother8, nameof(bodycontactother8), required: false);
            WorkflowValue.Validate(bodycontactother9, nameof(bodycontactother9), required: false);
            WorkflowValue.Validate(bodycontactother10, nameof(bodycontactother10), required: false);
            WorkflowValue.Validate(bodycontactother11, nameof(bodycontactother11), required: false);
            WorkflowValue.Validate(bodycontactother12, nameof(bodycontactother12), required: false);
            WorkflowValue.Validate(bodycontactother13, nameof(bodycontactother13), required: false);
            WorkflowValue.Validate(bodycontactother14, nameof(bodycontactother14), required: false);
            WorkflowValue.Validate(bodycontactother15, nameof(bodycontactother15), required: false);
            WorkflowValue.Validate(bodycontactother16, nameof(bodycontactother16), required: false);
            WorkflowValue.Validate(bodycontactother17, nameof(bodycontactother17), required: false);
            WorkflowValue.Validate(bodycontactother18, nameof(bodycontactother18), required: false);
            WorkflowValue.Validate(bodycontactother19, nameof(bodycontactother19), required: false);
            WorkflowValue.Validate(bodycontactother20, nameof(bodycontactother20), required: false);
            WorkflowValue.Validate(bodycontactother21, nameof(bodycontactother21), required: false);
            WorkflowValue.Validate(bodycontactother22, nameof(bodycontactother22), required: false);
            WorkflowValue.Validate(bodycontactother23, nameof(bodycontactother23), required: false);
            WorkflowValue.Validate(bodycontactother24, nameof(bodycontactother24), required: false);
            WorkflowValue.Validate(bodycontactother25, nameof(bodycontactother25), required: false);
            WorkflowValue.Validate(bodycontactother26, nameof(bodycontactother26), required: false);
            WorkflowValue.Validate(bodycontactother27, nameof(bodycontactother27), required: false);
            WorkflowValue.Validate(bodycontactother28, nameof(bodycontactother28), required: false);
            WorkflowValue.Validate(bodycontactother29, nameof(bodycontactother29), required: false);
            WorkflowValue.Validate(bodycontactother30, nameof(bodycontactother30), required: false);
            WorkflowValue.Validate(bodycontactother31, nameof(bodycontactother31), required: false);
            WorkflowValue.Validate(bodycontactother32, nameof(bodycontactother32), required: false);
            WorkflowValue.Validate(bodycontactother33, nameof(bodycontactother33), required: false);
            WorkflowValue.Validate(bodycontactother34, nameof(bodycontactother34), required: false);
            WorkflowValue.Validate(bodycontactother35, nameof(bodycontactother35), required: false);
            WorkflowValue.Validate(bodycontactpostcode, nameof(bodycontactpostcode), required: false);
            WorkflowValue.Validate(bodypropertiesagent, nameof(bodypropertiesagent), required: false);
            WorkflowValue.Validate(bodypropertiesagentGroup, nameof(bodypropertiesagentGroup), required: false);
            WorkflowValue.Validate(bodypropertiescampaign, nameof(bodypropertiescampaign), required: false);
            WorkflowValue.Validate(bodypropertiescomment, nameof(bodypropertiescomment), required: false);
            WorkflowValue.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowValue.Validate(bodypropertiestimestamp, nameof(bodypropertiestimestamp), required: false);
            WorkflowValue.Validate(bodypropertiestype, nameof(bodypropertiestype), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateContactResponse> __BuildCreateContact(WorkflowValue<string> phone, WorkflowValue<string> list, WorkflowValue<string> fname = null, WorkflowValue<string> lname = null, WorkflowValue<string> email = null, WorkflowValue<string> www = null, WorkflowValue<string> address = null, WorkflowValue<string> postcode = null, WorkflowValue<string> city = null, WorkflowValue<string> country = null, WorkflowValue<string> ssc = null, WorkflowValue<string> birthyear = null, WorkflowValue<string> gender = null, WorkflowValue<string> companyid = null, WorkflowValue<string> company = null, WorkflowValue<string> vatin = null, WorkflowValue<string> title = null, WorkflowValue<string> comment = null, WorkflowValue<string> other1 = null, WorkflowValue<string> other2 = null, WorkflowValue<string> other3 = null, WorkflowValue<string> other4 = null, WorkflowValue<string> other5 = null, WorkflowValue<string> other6 = null, WorkflowValue<string> other7 = null, WorkflowValue<string> other8 = null, WorkflowValue<string> other9 = null, WorkflowValue<string> other10 = null, WorkflowValue<string> other11 = null, WorkflowValue<string> other12 = null, WorkflowValue<string> other13 = null, WorkflowValue<string> other14 = null, WorkflowValue<string> other15 = null, WorkflowValue<string> other16 = null, WorkflowValue<string> other17 = null, WorkflowValue<string> other18 = null, WorkflowValue<string> other19 = null, WorkflowValue<string> other20 = null, WorkflowValue<string> other21 = null, WorkflowValue<string> other22 = null, WorkflowValue<string> other23 = null, WorkflowValue<string> other24 = null, WorkflowValue<string> other25 = null, WorkflowValue<string> other26 = null, WorkflowValue<string> other27 = null, WorkflowValue<string> other28 = null, WorkflowValue<string> other29 = null, WorkflowValue<string> other30 = null, WorkflowValue<string> other31 = null, WorkflowValue<string> other32 = null, WorkflowValue<string> other33 = null, WorkflowValue<string> other34 = null, WorkflowValue<string> other35 = null, WorkflowValue<string> assignToAgent = null)
        {
            WorkflowValue.Validate(phone, nameof(phone), required: true);
            WorkflowValue.Validate(list, nameof(list), required: true);
            WorkflowValue.Validate(fname, nameof(fname), required: false);
            WorkflowValue.Validate(lname, nameof(lname), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(www, nameof(www), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(postcode, nameof(postcode), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(ssc, nameof(ssc), required: false);
            WorkflowValue.Validate(birthyear, nameof(birthyear), required: false);
            WorkflowValue.Validate(gender, nameof(gender), required: false);
            WorkflowValue.Validate(companyid, nameof(companyid), required: false);
            WorkflowValue.Validate(company, nameof(company), required: false);
            WorkflowValue.Validate(vatin, nameof(vatin), required: false);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
            WorkflowValue.Validate(other1, nameof(other1), required: false);
            WorkflowValue.Validate(other2, nameof(other2), required: false);
            WorkflowValue.Validate(other3, nameof(other3), required: false);
            WorkflowValue.Validate(other4, nameof(other4), required: false);
            WorkflowValue.Validate(other5, nameof(other5), required: false);
            WorkflowValue.Validate(other6, nameof(other6), required: false);
            WorkflowValue.Validate(other7, nameof(other7), required: false);
            WorkflowValue.Validate(other8, nameof(other8), required: false);
            WorkflowValue.Validate(other9, nameof(other9), required: false);
            WorkflowValue.Validate(other10, nameof(other10), required: false);
            WorkflowValue.Validate(other11, nameof(other11), required: false);
            WorkflowValue.Validate(other12, nameof(other12), required: false);
            WorkflowValue.Validate(other13, nameof(other13), required: false);
            WorkflowValue.Validate(other14, nameof(other14), required: false);
            WorkflowValue.Validate(other15, nameof(other15), required: false);
            WorkflowValue.Validate(other16, nameof(other16), required: false);
            WorkflowValue.Validate(other17, nameof(other17), required: false);
            WorkflowValue.Validate(other18, nameof(other18), required: false);
            WorkflowValue.Validate(other19, nameof(other19), required: false);
            WorkflowValue.Validate(other20, nameof(other20), required: false);
            WorkflowValue.Validate(other21, nameof(other21), required: false);
            WorkflowValue.Validate(other22, nameof(other22), required: false);
            WorkflowValue.Validate(other23, nameof(other23), required: false);
            WorkflowValue.Validate(other24, nameof(other24), required: false);
            WorkflowValue.Validate(other25, nameof(other25), required: false);
            WorkflowValue.Validate(other26, nameof(other26), required: false);
            WorkflowValue.Validate(other27, nameof(other27), required: false);
            WorkflowValue.Validate(other28, nameof(other28), required: false);
            WorkflowValue.Validate(other29, nameof(other29), required: false);
            WorkflowValue.Validate(other30, nameof(other30), required: false);
            WorkflowValue.Validate(other31, nameof(other31), required: false);
            WorkflowValue.Validate(other32, nameof(other32), required: false);
            WorkflowValue.Validate(other33, nameof(other33), required: false);
            WorkflowValue.Validate(other34, nameof(other34), required: false);
            WorkflowValue.Validate(other35, nameof(other35), required: false);
            WorkflowValue.Validate(assignToAgent, nameof(assignToAgent), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindAgentResponse> __BuildFindAgent(WorkflowValue<string> username)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindContactResponse> __BuildFindContact(WorkflowValue<string> fname = null, WorkflowValue<string> lname = null, WorkflowValue<int> phone = null, WorkflowValue<int> contactListId = null)
        {
            WorkflowValue.Validate(fname, nameof(fname), required: false);
            WorkflowValue.Validate(lname, nameof(lname), required: false);
            WorkflowValue.Validate(phone, nameof(phone), required: false);
            WorkflowValue.Validate(contactListId, nameof(contactListId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyAgentResponse> __BuildModifyAgent(WorkflowValue<int> bodyid, WorkflowValue<string> bodyaccountexternalId = null, WorkflowValue<string> bodyaccountinboundNumber = null, WorkflowValue<int> bodyaccountlang = null, WorkflowValue<string> bodyaccountpassword = null, WorkflowValue<string> bodyaccounttimeZone = null, WorkflowValue<string> bodyaccountusername = null, WorkflowValue<string> bodyaccountvoipUsername = null, WorkflowValue<string> bodycontactInformationaddress = null, WorkflowValue<string> bodycontactInformationcity = null, WorkflowValue<string> bodycontactInformationcountry = null, WorkflowValue<string> bodycontactInformationeContacts = null, WorkflowValue<string> bodycontactInformationemail = null, WorkflowValue<string> bodycontactInformationname = null, WorkflowValue<string> bodycontactInformationphone = null, WorkflowValue<string> bodycontactInformationpostal = null, WorkflowValue<string> bodycontactInformationworkphone = null, WorkflowValue<bool> bodydisable = null, WorkflowValue<int> bodyemploymentagentGroupId = null, WorkflowValue<string> bodyemploymentbankAcc = null, WorkflowValue<string> bodyemploymentdescription = null, WorkflowValue<bodyemploymentemploymentInput> bodyemploymentemployment = null, WorkflowValue<string> bodyemploymentemploymentStart = null, WorkflowValue<string> bodyemploymentoffice = null, WorkflowValue<string> bodyemploymentssn = null, WorkflowValue<string> bodyemploymentworkshift = null)
        {
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowValue.Validate(bodyaccountexternalId, nameof(bodyaccountexternalId), required: false);
            WorkflowValue.Validate(bodyaccountinboundNumber, nameof(bodyaccountinboundNumber), required: false);
            WorkflowValue.Validate(bodyaccountlang, nameof(bodyaccountlang), required: false);
            WorkflowValue.Validate(bodyaccountpassword, nameof(bodyaccountpassword), required: false);
            WorkflowValue.Validate(bodyaccounttimeZone, nameof(bodyaccounttimeZone), required: false);
            WorkflowValue.Validate(bodyaccountusername, nameof(bodyaccountusername), required: false);
            WorkflowValue.Validate(bodyaccountvoipUsername, nameof(bodyaccountvoipUsername), required: false);
            WorkflowValue.Validate(bodycontactInformationaddress, nameof(bodycontactInformationaddress), required: false);
            WorkflowValue.Validate(bodycontactInformationcity, nameof(bodycontactInformationcity), required: false);
            WorkflowValue.Validate(bodycontactInformationcountry, nameof(bodycontactInformationcountry), required: false);
            WorkflowValue.Validate(bodycontactInformationeContacts, nameof(bodycontactInformationeContacts), required: false);
            WorkflowValue.Validate(bodycontactInformationemail, nameof(bodycontactInformationemail), required: false);
            WorkflowValue.Validate(bodycontactInformationname, nameof(bodycontactInformationname), required: false);
            WorkflowValue.Validate(bodycontactInformationphone, nameof(bodycontactInformationphone), required: false);
            WorkflowValue.Validate(bodycontactInformationpostal, nameof(bodycontactInformationpostal), required: false);
            WorkflowValue.Validate(bodycontactInformationworkphone, nameof(bodycontactInformationworkphone), required: false);
            WorkflowValue.Validate(bodydisable, nameof(bodydisable), required: false);
            WorkflowValue.Validate(bodyemploymentagentGroupId, nameof(bodyemploymentagentGroupId), required: false);
            WorkflowValue.Validate(bodyemploymentbankAcc, nameof(bodyemploymentbankAcc), required: false);
            WorkflowValue.Validate(bodyemploymentdescription, nameof(bodyemploymentdescription), required: false);
            WorkflowValue.Validate(bodyemploymentemployment, nameof(bodyemploymentemployment), required: false);
            WorkflowValue.Validate(bodyemploymentemploymentStart, nameof(bodyemploymentemploymentStart), required: false);
            WorkflowValue.Validate(bodyemploymentoffice, nameof(bodyemploymentoffice), required: false);
            WorkflowValue.Validate(bodyemploymentssn, nameof(bodyemploymentssn), required: false);
            WorkflowValue.Validate(bodyemploymentworkshift, nameof(bodyemploymentworkshift), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ModifyContactResponse> __BuildModifyContact(WorkflowValue<int> contactId, WorkflowValue<string> fname = null, WorkflowValue<string> lname = null, WorkflowValue<string> phone = null, WorkflowValue<string> birthyear = null, WorkflowValue<string> gender = null, WorkflowValue<string> email = null, WorkflowValue<string> www = null, WorkflowValue<string> address = null, WorkflowValue<string> postcode = null, WorkflowValue<string> city = null, WorkflowValue<string> country = null, WorkflowValue<string> ssc = null, WorkflowValue<int> companyid = null, WorkflowValue<string> company = null, WorkflowValue<string> vatin = null, WorkflowValue<string> title = null, WorkflowValue<string> comment = null, WorkflowValue<string> other1 = null, WorkflowValue<string> other2 = null, WorkflowValue<string> other3 = null, WorkflowValue<string> other4 = null, WorkflowValue<string> other5 = null, WorkflowValue<string> other6 = null, WorkflowValue<string> other7 = null, WorkflowValue<string> other8 = null, WorkflowValue<string> other9 = null, WorkflowValue<string> other10 = null, WorkflowValue<string> other11 = null, WorkflowValue<string> other12 = null, WorkflowValue<string> other13 = null, WorkflowValue<string> other14 = null, WorkflowValue<string> other15 = null, WorkflowValue<string> other16 = null, WorkflowValue<string> other17 = null, WorkflowValue<string> other18 = null, WorkflowValue<string> other19 = null, WorkflowValue<string> other20 = null, WorkflowValue<string> other21 = null, WorkflowValue<string> other22 = null, WorkflowValue<string> other23 = null, WorkflowValue<string> other24 = null, WorkflowValue<string> other25 = null, WorkflowValue<string> other26 = null, WorkflowValue<string> other27 = null, WorkflowValue<string> other28 = null, WorkflowValue<string> other29 = null, WorkflowValue<string> other30 = null, WorkflowValue<string> other31 = null, WorkflowValue<string> other32 = null, WorkflowValue<string> other33 = null, WorkflowValue<string> other34 = null, WorkflowValue<string> other35 = null, WorkflowValue<string> list = null, WorkflowValue<orderInput> order = null, WorkflowValue<string> assignToAgent = null)
        {
            WorkflowValue.Validate(contactId, nameof(contactId), required: true);
            WorkflowValue.Validate(fname, nameof(fname), required: false);
            WorkflowValue.Validate(lname, nameof(lname), required: false);
            WorkflowValue.Validate(phone, nameof(phone), required: false);
            WorkflowValue.Validate(birthyear, nameof(birthyear), required: false);
            WorkflowValue.Validate(gender, nameof(gender), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(www, nameof(www), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(postcode, nameof(postcode), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(ssc, nameof(ssc), required: false);
            WorkflowValue.Validate(companyid, nameof(companyid), required: false);
            WorkflowValue.Validate(company, nameof(company), required: false);
            WorkflowValue.Validate(vatin, nameof(vatin), required: false);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
            WorkflowValue.Validate(other1, nameof(other1), required: false);
            WorkflowValue.Validate(other2, nameof(other2), required: false);
            WorkflowValue.Validate(other3, nameof(other3), required: false);
            WorkflowValue.Validate(other4, nameof(other4), required: false);
            WorkflowValue.Validate(other5, nameof(other5), required: false);
            WorkflowValue.Validate(other6, nameof(other6), required: false);
            WorkflowValue.Validate(other7, nameof(other7), required: false);
            WorkflowValue.Validate(other8, nameof(other8), required: false);
            WorkflowValue.Validate(other9, nameof(other9), required: false);
            WorkflowValue.Validate(other10, nameof(other10), required: false);
            WorkflowValue.Validate(other11, nameof(other11), required: false);
            WorkflowValue.Validate(other12, nameof(other12), required: false);
            WorkflowValue.Validate(other13, nameof(other13), required: false);
            WorkflowValue.Validate(other14, nameof(other14), required: false);
            WorkflowValue.Validate(other15, nameof(other15), required: false);
            WorkflowValue.Validate(other16, nameof(other16), required: false);
            WorkflowValue.Validate(other17, nameof(other17), required: false);
            WorkflowValue.Validate(other18, nameof(other18), required: false);
            WorkflowValue.Validate(other19, nameof(other19), required: false);
            WorkflowValue.Validate(other20, nameof(other20), required: false);
            WorkflowValue.Validate(other21, nameof(other21), required: false);
            WorkflowValue.Validate(other22, nameof(other22), required: false);
            WorkflowValue.Validate(other23, nameof(other23), required: false);
            WorkflowValue.Validate(other24, nameof(other24), required: false);
            WorkflowValue.Validate(other25, nameof(other25), required: false);
            WorkflowValue.Validate(other26, nameof(other26), required: false);
            WorkflowValue.Validate(other27, nameof(other27), required: false);
            WorkflowValue.Validate(other28, nameof(other28), required: false);
            WorkflowValue.Validate(other29, nameof(other29), required: false);
            WorkflowValue.Validate(other30, nameof(other30), required: false);
            WorkflowValue.Validate(other31, nameof(other31), required: false);
            WorkflowValue.Validate(other32, nameof(other32), required: false);
            WorkflowValue.Validate(other33, nameof(other33), required: false);
            WorkflowValue.Validate(other34, nameof(other34), required: false);
            WorkflowValue.Validate(other35, nameof(other35), required: false);
            WorkflowValue.Validate(list, nameof(list), required: false);
            WorkflowValue.Validate(order, nameof(order), required: false);
            WorkflowValue.Validate(assignToAgent, nameof(assignToAgent), required: false);
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
