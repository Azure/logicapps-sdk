//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercenterrefActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<GetAllReferralsResponse> GetAllReferrals([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            var apiCallPath = "/referrals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            return new ApiConnectionAction<GetAllReferralsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateReferral([WorkflowExpression] Func<string> referralcontext = null, [WorkflowExpression] Func<string> referralcampaignId = null, [WorkflowExpression] Func<bool> referralconsentconsentToContact = null, [WorkflowExpression] Func<bool> referralconsentconsentToToShareInfoWithOthers = null, [WorkflowExpression] Func<bool> referralconsentconsentToShareReferralWithMicrosoftSellers = null, [WorkflowExpression] Func<string> referralcreatedDateTime = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressaddressLine1 = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressaddressLine2 = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresscity = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresscountry = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresspostalCode = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressregion = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressstate = null, [WorkflowExpression] Func<JToken[]> referralcustomerProfileids = null, [WorkflowExpression] Func<string> referralcustomerProfilename = null, [WorkflowExpression] Func<string> referralcustomerProfilesize = null, [WorkflowExpression] Func<referralcustomerProfileteamInputItem[]> referralcustomerProfileteam = null, [WorkflowExpression] Func<string> referraldetailsclosingDateTime = null, [WorkflowExpression] Func<string> referraldetailscurrency = null, [WorkflowExpression] Func<string> referraldetailscustomerAction = null, [WorkflowExpression] Func<bool> referraldetailscustomerRequestedContact = null, [WorkflowExpression] Func<double> referraldetailsdealValue = null, [WorkflowExpression] Func<string> referraldetailsnotes = null, [WorkflowExpression] Func<referraldetailsrequirementsindustriesInputItem[]> referraldetailsrequirementsindustries = null, [WorkflowExpression] Func<referraldetailsrequirementsproductsInputItem[]> referraldetailsrequirementsproducts = null, [WorkflowExpression] Func<referraldetailsrequirementsservicesInputItem[]> referraldetailsrequirementsservices = null, [WorkflowExpression] Func<JToken[]> referraldetailsrequirementssolutions = null, [WorkflowExpression] Func<JToken[]> referraldetailsrequirementsoffers = null, [WorkflowExpression] Func<string> referraleTag = null, [WorkflowExpression] Func<string> referralengagementId = null, [WorkflowExpression] Func<string> referralexpirationDateTime = null, [WorkflowExpression] Func<string> referralexternalReferenceId = null, [WorkflowExpression] Func<bool> referralfavorite = null, [WorkflowExpression] Func<string> referralid = null, [WorkflowExpression] Func<referralinviteContextassistanceRequestCodeInput> referralinviteContextassistanceRequestCode = null, [WorkflowExpression] Func<string> referralinviteContextinvitedByorganizationId = null, [WorkflowExpression] Func<string> referralinviteContextinvitedByorganizationName = null, [WorkflowExpression] Func<string> referralinviteContextnotes = null, [WorkflowExpression] Func<string> referrallastModifiedVia = null, [WorkflowExpression] Func<string> referrallastRunId = null, [WorkflowExpression] Func<string> referrallinksrelatedReferralsmethod = null, [WorkflowExpression] Func<string> referrallinksrelatedReferralsuri = null, [WorkflowExpression] Func<string> referrallinksselfmethod = null, [WorkflowExpression] Func<string> referrallinksselfuri = null, [WorkflowExpression] Func<string> referralname = null, [WorkflowExpression] Func<string> referralorganizationId = null, [WorkflowExpression] Func<string> referralorganizationName = null, [WorkflowExpression] Func<string> referralqualification = null, [WorkflowExpression] Func<string> referralreferralProgram = null, [WorkflowExpression] Func<referralsalesStageInput> referralsalesStage = null, [WorkflowExpression] Func<string> referralstatus = null, [WorkflowExpression] Func<string> referralstatusReason = null, [WorkflowExpression] Func<string> referralsubstatus = null, [WorkflowExpression] Func<referraltargetInputItem[]> referraltarget = null, [WorkflowExpression] Func<referralteamInputItem[]> referralteam = null, [WorkflowExpression] Func<string> referraltrackingInfomicrosoftMsxId = null, [WorkflowExpression] Func<string> referraltype = null, [WorkflowExpression] Func<string> referralupdatedDateTime = null, [WorkflowExpression] Func<string> referralmpnId = null, [WorkflowExpression] Func<referralregistrationsInputItem[]> referralregistrations = null, [WorkflowExpression] Func<string> referralregistrationStatus = null, [WorkflowExpression] Func<string> referralcallToAction = null, [WorkflowExpression] Func<string> referralreferralSource = null, [WorkflowExpression] Func<string> referralquality = null, [WorkflowExpression] Func<bool> referralisSpam = null, [WorkflowExpression] Func<string> referraldirection = null, [WorkflowExpression] Func<string[]> referraltags = null, [WorkflowExpression] Func<string> referralacceptedDateTime = null, [WorkflowExpression] Func<string> referralclosedDateTime = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            var apiCallPath = "/referrals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            var referral = new JObject();
            var referralpropCount = 0;
            if (referralcontext != null)
            {
                referral["@odata.context"] = ExpressionConverter.ConvertO(referralcontext);
                referralpropCount++;
            }

            if (referralcampaignId != null)
            {
                referral["campaignId"] = ExpressionConverter.ConvertO(referralcampaignId);
                referralpropCount++;
            }

            var consentObject = new JObject();
            var consentObjectpropCount = 0;
            if (referralconsentconsentToContact != null)
            {
                consentObject["consentToContact"] = ExpressionConverter.ConvertO(referralconsentconsentToContact);
                consentObjectpropCount++;
            }

            if (referralconsentconsentToToShareInfoWithOthers != null)
            {
                consentObject["consentToToShareInfoWithOthers"] = ExpressionConverter.ConvertO(referralconsentconsentToToShareInfoWithOthers);
                consentObjectpropCount++;
            }

            if (referralconsentconsentToShareReferralWithMicrosoftSellers != null)
            {
                consentObject["consentToShareReferralWithMicrosoftSellers"] = ExpressionConverter.ConvertO(referralconsentconsentToShareReferralWithMicrosoftSellers);
                consentObjectpropCount++;
            }

            if (consentObjectpropCount > 0)
            {
                referral["consent"] = consentObject;
                referralpropCount++;
            }

            if (referralcreatedDateTime != null)
            {
                referral["createdDateTime"] = ExpressionConverter.ConvertO(referralcreatedDateTime);
                referralpropCount++;
            }

            var customerProfileObject = new JObject();
            var customerProfileObjectpropCount = 0;
            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (referralcustomerProfileaddressaddressLine1 != null)
            {
                addressObject["addressLine1"] = ExpressionConverter.ConvertO(referralcustomerProfileaddressaddressLine1);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressaddressLine2 != null)
            {
                addressObject["addressLine2"] = ExpressionConverter.ConvertO(referralcustomerProfileaddressaddressLine2);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(referralcustomerProfileaddresscity);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(referralcustomerProfileaddresscountry);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresspostalCode != null)
            {
                addressObject["postalCode"] = ExpressionConverter.ConvertO(referralcustomerProfileaddresspostalCode);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressregion != null)
            {
                addressObject["region"] = ExpressionConverter.ConvertO(referralcustomerProfileaddressregion);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(referralcustomerProfileaddressstate);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                customerProfileObject["address"] = addressObject;
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfileids != null)
            {
                customerProfileObject["ids"] = ExpressionConverter.ConvertO(referralcustomerProfileids);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfilename != null)
            {
                customerProfileObject["name"] = ExpressionConverter.ConvertO(referralcustomerProfilename);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfilesize != null)
            {
                customerProfileObject["size"] = ExpressionConverter.ConvertO(referralcustomerProfilesize);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfileteam != null)
            {
                customerProfileObject["team"] = ExpressionConverter.ConvertO(referralcustomerProfileteam);
                customerProfileObjectpropCount++;
            }

            if (customerProfileObjectpropCount > 0)
            {
                referral["customerProfile"] = customerProfileObject;
                referralpropCount++;
            }

            var detailsObject = new JObject();
            var detailsObjectpropCount = 0;
            if (referraldetailsclosingDateTime != null)
            {
                detailsObject["closingDateTime"] = ExpressionConverter.ConvertO(referraldetailsclosingDateTime);
                detailsObjectpropCount++;
            }

            if (referraldetailscurrency != null)
            {
                detailsObject["currency"] = ExpressionConverter.ConvertO(referraldetailscurrency);
                detailsObjectpropCount++;
            }

            if (referraldetailscustomerAction != null)
            {
                detailsObject["customerAction"] = ExpressionConverter.ConvertO(referraldetailscustomerAction);
                detailsObjectpropCount++;
            }

            if (referraldetailscustomerRequestedContact != null)
            {
                detailsObject["customerRequestedContact"] = ExpressionConverter.ConvertO(referraldetailscustomerRequestedContact);
                detailsObjectpropCount++;
            }

            if (referraldetailsdealValue != null)
            {
                detailsObject["dealValue"] = ExpressionConverter.ConvertO(referraldetailsdealValue);
                detailsObjectpropCount++;
            }

            if (referraldetailsnotes != null)
            {
                detailsObject["notes"] = ExpressionConverter.ConvertO(referraldetailsnotes);
                detailsObjectpropCount++;
            }

            var requirementsObject = new JObject();
            var requirementsObjectpropCount = 0;
            if (referraldetailsrequirementsindustries != null)
            {
                requirementsObject["industries"] = ExpressionConverter.ConvertO(referraldetailsrequirementsindustries);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsproducts != null)
            {
                requirementsObject["products"] = ExpressionConverter.ConvertO(referraldetailsrequirementsproducts);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsservices != null)
            {
                requirementsObject["services"] = ExpressionConverter.ConvertO(referraldetailsrequirementsservices);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementssolutions != null)
            {
                requirementsObject["solutions"] = ExpressionConverter.ConvertO(referraldetailsrequirementssolutions);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsoffers != null)
            {
                requirementsObject["offers"] = ExpressionConverter.ConvertO(referraldetailsrequirementsoffers);
                requirementsObjectpropCount++;
            }

            var additionalRequirementsObject = new JObject();
            var additionalRequirementsObjectpropCount = 0;
            if (additionalRequirementsObjectpropCount > 0)
            {
                requirementsObject["additionalRequirements"] = additionalRequirementsObject;
                requirementsObjectpropCount++;
            }

            if (requirementsObjectpropCount > 0)
            {
                detailsObject["requirements"] = requirementsObject;
                detailsObjectpropCount++;
            }

            if (detailsObjectpropCount > 0)
            {
                referral["details"] = detailsObject;
                referralpropCount++;
            }

            if (referraleTag != null)
            {
                referral["eTag"] = ExpressionConverter.ConvertO(referraleTag);
                referralpropCount++;
            }

            if (referralengagementId != null)
            {
                referral["engagementId"] = ExpressionConverter.ConvertO(referralengagementId);
                referralpropCount++;
            }

            if (referralexpirationDateTime != null)
            {
                referral["expirationDateTime"] = ExpressionConverter.ConvertO(referralexpirationDateTime);
                referralpropCount++;
            }

            if (referralexternalReferenceId != null)
            {
                referral["externalReferenceId"] = ExpressionConverter.ConvertO(referralexternalReferenceId);
                referralpropCount++;
            }

            if (referralfavorite != null)
            {
                referral["favorite"] = ExpressionConverter.ConvertO(referralfavorite);
                referralpropCount++;
            }

            if (referralid != null)
            {
                referral["id"] = ExpressionConverter.ConvertO(referralid);
                referralpropCount++;
            }

            var inviteContextObject = new JObject();
            var inviteContextObjectpropCount = 0;
            if (referralinviteContextassistanceRequestCode != null)
            {
                inviteContextObject["assistanceRequestCode"] = ExpressionConverter.ConvertO(referralinviteContextassistanceRequestCode);
                inviteContextObjectpropCount++;
            }

            var invitedByObject = new JObject();
            var invitedByObjectpropCount = 0;
            if (referralinviteContextinvitedByorganizationId != null)
            {
                invitedByObject["organizationId"] = ExpressionConverter.ConvertO(referralinviteContextinvitedByorganizationId);
                invitedByObjectpropCount++;
            }

            if (referralinviteContextinvitedByorganizationName != null)
            {
                invitedByObject["organizationName"] = ExpressionConverter.ConvertO(referralinviteContextinvitedByorganizationName);
                invitedByObjectpropCount++;
            }

            if (invitedByObjectpropCount > 0)
            {
                inviteContextObject["invitedBy"] = invitedByObject;
                inviteContextObjectpropCount++;
            }

            if (referralinviteContextnotes != null)
            {
                inviteContextObject["notes"] = ExpressionConverter.ConvertO(referralinviteContextnotes);
                inviteContextObjectpropCount++;
            }

            if (inviteContextObjectpropCount > 0)
            {
                referral["inviteContext"] = inviteContextObject;
                referralpropCount++;
            }

            if (referrallastModifiedVia != null)
            {
                referral["lastModifiedVia"] = ExpressionConverter.ConvertO(referrallastModifiedVia);
                referralpropCount++;
            }

            if (referrallastRunId != null)
            {
                referral["lastRunId"] = ExpressionConverter.ConvertO(referrallastRunId);
                referralpropCount++;
            }

            var linksObject = new JObject();
            var linksObjectpropCount = 0;
            var relatedReferralsObject = new JObject();
            var relatedReferralsObjectpropCount = 0;
            if (referrallinksrelatedReferralsmethod != null)
            {
                relatedReferralsObject["method"] = ExpressionConverter.ConvertO(referrallinksrelatedReferralsmethod);
                relatedReferralsObjectpropCount++;
            }

            if (referrallinksrelatedReferralsuri != null)
            {
                relatedReferralsObject["uri"] = ExpressionConverter.ConvertO(referrallinksrelatedReferralsuri);
                relatedReferralsObjectpropCount++;
            }

            if (relatedReferralsObjectpropCount > 0)
            {
                linksObject["relatedReferrals"] = relatedReferralsObject;
                linksObjectpropCount++;
            }

            var selfObject = new JObject();
            var selfObjectpropCount = 0;
            if (referrallinksselfmethod != null)
            {
                selfObject["method"] = ExpressionConverter.ConvertO(referrallinksselfmethod);
                selfObjectpropCount++;
            }

            if (referrallinksselfuri != null)
            {
                selfObject["uri"] = ExpressionConverter.ConvertO(referrallinksselfuri);
                selfObjectpropCount++;
            }

            if (selfObjectpropCount > 0)
            {
                linksObject["self"] = selfObject;
                linksObjectpropCount++;
            }

            if (linksObjectpropCount > 0)
            {
                referral["links"] = linksObject;
                referralpropCount++;
            }

            if (referralname != null)
            {
                referral["name"] = ExpressionConverter.ConvertO(referralname);
                referralpropCount++;
            }

            if (referralorganizationId != null)
            {
                referral["organizationId"] = ExpressionConverter.ConvertO(referralorganizationId);
                referralpropCount++;
            }

            if (referralorganizationName != null)
            {
                referral["organizationName"] = ExpressionConverter.ConvertO(referralorganizationName);
                referralpropCount++;
            }

            if (referralqualification != null)
            {
                referral["qualification"] = ExpressionConverter.ConvertO(referralqualification);
                referralpropCount++;
            }

            if (referralreferralProgram != null)
            {
                referral["referralProgram"] = ExpressionConverter.ConvertO(referralreferralProgram);
                referralpropCount++;
            }

            if (referralsalesStage != null)
            {
                referral["salesStage"] = ExpressionConverter.ConvertO(referralsalesStage);
                referralpropCount++;
            }

            if (referralstatus != null)
            {
                referral["status"] = ExpressionConverter.ConvertO(referralstatus);
                referralpropCount++;
            }

            if (referralstatusReason != null)
            {
                referral["statusReason"] = ExpressionConverter.ConvertO(referralstatusReason);
                referralpropCount++;
            }

            if (referralsubstatus != null)
            {
                referral["substatus"] = ExpressionConverter.ConvertO(referralsubstatus);
                referralpropCount++;
            }

            if (referraltarget != null)
            {
                referral["target"] = ExpressionConverter.ConvertO(referraltarget);
                referralpropCount++;
            }

            if (referralteam != null)
            {
                referral["team"] = ExpressionConverter.ConvertO(referralteam);
                referralpropCount++;
            }

            var trackingInfoObject = new JObject();
            var trackingInfoObjectpropCount = 0;
            if (referraltrackingInfomicrosoftMsxId != null)
            {
                trackingInfoObject["microsoftMsxId"] = ExpressionConverter.ConvertO(referraltrackingInfomicrosoftMsxId);
                trackingInfoObjectpropCount++;
            }

            if (trackingInfoObjectpropCount > 0)
            {
                referral["trackingInfo"] = trackingInfoObject;
                referralpropCount++;
            }

            if (referraltype != null)
            {
                referral["type"] = ExpressionConverter.ConvertO(referraltype);
                referralpropCount++;
            }

            if (referralupdatedDateTime != null)
            {
                referral["updatedDateTime"] = ExpressionConverter.ConvertO(referralupdatedDateTime);
                referralpropCount++;
            }

            if (referralmpnId != null)
            {
                referral["mpnId"] = ExpressionConverter.ConvertO(referralmpnId);
                referralpropCount++;
            }

            if (referralregistrations != null)
            {
                referral["registrations"] = ExpressionConverter.ConvertO(referralregistrations);
                referralpropCount++;
            }

            if (referralregistrationStatus != null)
            {
                referral["registrationStatus"] = ExpressionConverter.ConvertO(referralregistrationStatus);
                referralpropCount++;
            }

            if (referralcallToAction != null)
            {
                referral["callToAction"] = ExpressionConverter.ConvertO(referralcallToAction);
                referralpropCount++;
            }

            if (referralreferralSource != null)
            {
                referral["referralSource"] = ExpressionConverter.ConvertO(referralreferralSource);
                referralpropCount++;
            }

            if (referralquality != null)
            {
                referral["quality"] = ExpressionConverter.ConvertO(referralquality);
                referralpropCount++;
            }

            if (referralisSpam != null)
            {
                referral["isSpam"] = ExpressionConverter.ConvertO(referralisSpam);
                referralpropCount++;
            }

            if (referraldirection != null)
            {
                referral["direction"] = ExpressionConverter.ConvertO(referraldirection);
                referralpropCount++;
            }

            if (referraltags != null)
            {
                referral["tags"] = ExpressionConverter.ConvertO(referraltags);
                referralpropCount++;
            }

            if (referralacceptedDateTime != null)
            {
                referral["acceptedDateTime"] = ExpressionConverter.ConvertO(referralacceptedDateTime);
                referralpropCount++;
            }

            if (referralclosedDateTime != null)
            {
                referral["closedDateTime"] = ExpressionConverter.ConvertO(referralclosedDateTime);
                referralpropCount++;
            }

            if (referralpropCount > 0)
            {
                callPayload.Body = referral;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> GetReferralById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            var apiCallPath = String.Format("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> UpdateReferralById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> odataReferralcontext = null, [WorkflowExpression] Func<string> odataReferralcampaignId = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToContact = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToToShareInfoWithOthers = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToShareReferralWithMicrosoftSellers = null, [WorkflowExpression] Func<string> odataReferralcreatedDateTime = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressaddressLine1 = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressaddressLine2 = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresscity = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresscountry = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresspostalCode = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressregion = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressstate = null, [WorkflowExpression] Func<JToken[]> odataReferralcustomerProfileids = null, [WorkflowExpression] Func<string> odataReferralcustomerProfilename = null, [WorkflowExpression] Func<string> odataReferralcustomerProfilesize = null, [WorkflowExpression] Func<odataReferralcustomerProfileteamInputItem[]> odataReferralcustomerProfileteam = null, [WorkflowExpression] Func<string> odataReferraldetailsclosingDateTime = null, [WorkflowExpression] Func<string> odataReferraldetailscurrency = null, [WorkflowExpression] Func<string> odataReferraldetailscustomerAction = null, [WorkflowExpression] Func<bool> odataReferraldetailscustomerRequestedContact = null, [WorkflowExpression] Func<double> odataReferraldetailsdealValue = null, [WorkflowExpression] Func<string> odataReferraldetailsnotes = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsindustriesInputItem[]> odataReferraldetailsrequirementsindustries = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsproductsInputItem[]> odataReferraldetailsrequirementsproducts = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsservicesInputItem[]> odataReferraldetailsrequirementsservices = null, [WorkflowExpression] Func<JToken[]> odataReferraldetailsrequirementssolutions = null, [WorkflowExpression] Func<JToken[]> odataReferraldetailsrequirementsoffers = null, [WorkflowExpression] Func<string> odataReferraleTag = null, [WorkflowExpression] Func<string> odataReferralengagementId = null, [WorkflowExpression] Func<string> odataReferralexpirationDateTime = null, [WorkflowExpression] Func<string> odataReferralexternalReferenceId = null, [WorkflowExpression] Func<bool> odataReferralfavorite = null, [WorkflowExpression] Func<string> odataReferralid = null, [WorkflowExpression] Func<odataReferralinviteContextassistanceRequestCodeInput> odataReferralinviteContextassistanceRequestCode = null, [WorkflowExpression] Func<string> odataReferralinviteContextinvitedByorganizationId = null, [WorkflowExpression] Func<string> odataReferralinviteContextinvitedByorganizationName = null, [WorkflowExpression] Func<string> odataReferralinviteContextnotes = null, [WorkflowExpression] Func<string> odataReferrallastModifiedVia = null, [WorkflowExpression] Func<string> odataReferrallastRunId = null, [WorkflowExpression] Func<string> odataReferrallinksrelatedReferralsmethod = null, [WorkflowExpression] Func<string> odataReferrallinksrelatedReferralsuri = null, [WorkflowExpression] Func<string> odataReferrallinksselfmethod = null, [WorkflowExpression] Func<string> odataReferrallinksselfuri = null, [WorkflowExpression] Func<string> odataReferralname = null, [WorkflowExpression] Func<string> odataReferralorganizationId = null, [WorkflowExpression] Func<string> odataReferralorganizationName = null, [WorkflowExpression] Func<string> odataReferralqualification = null, [WorkflowExpression] Func<string> odataReferralreferralProgram = null, [WorkflowExpression] Func<odataReferralsalesStageInput> odataReferralsalesStage = null, [WorkflowExpression] Func<string> odataReferralstatus = null, [WorkflowExpression] Func<string> odataReferralstatusReason = null, [WorkflowExpression] Func<string> odataReferralsubstatus = null, [WorkflowExpression] Func<odataReferraltargetInputItem[]> odataReferraltarget = null, [WorkflowExpression] Func<odataReferralteamInputItem[]> odataReferralteam = null, [WorkflowExpression] Func<string> odataReferraltrackingInfomicrosoftMsxId = null, [WorkflowExpression] Func<string> odataReferraltype = null, [WorkflowExpression] Func<string> odataReferralupdatedDateTime = null, [WorkflowExpression] Func<string> odataReferralmpnId = null, [WorkflowExpression] Func<odataReferralregistrationsInputItem[]> odataReferralregistrations = null, [WorkflowExpression] Func<string> odataReferralregistrationStatus = null, [WorkflowExpression] Func<string> odataReferralcallToAction = null, [WorkflowExpression] Func<string> odataReferralreferralSource = null, [WorkflowExpression] Func<string> odataReferralquality = null, [WorkflowExpression] Func<bool> odataReferralisSpam = null, [WorkflowExpression] Func<string> odataReferraldirection = null, [WorkflowExpression] Func<string[]> odataReferraltags = null, [WorkflowExpression] Func<string> odataReferralacceptedDateTime = null, [WorkflowExpression] Func<string> odataReferralclosedDateTime = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            var apiCallPath = String.Format("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["if-match"] = ExpressionConverter.Convert(ifMatch);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            var odataReferral = new JObject();
            var odataReferralpropCount = 0;
            if (odataReferralcontext != null)
            {
                odataReferral["@odata.context"] = ExpressionConverter.ConvertO(odataReferralcontext);
                odataReferralpropCount++;
            }

            if (odataReferralcampaignId != null)
            {
                odataReferral["campaignId"] = ExpressionConverter.ConvertO(odataReferralcampaignId);
                odataReferralpropCount++;
            }

            var consentObject = new JObject();
            var consentObjectpropCount = 0;
            if (odataReferralconsentconsentToContact != null)
            {
                consentObject["consentToContact"] = ExpressionConverter.ConvertO(odataReferralconsentconsentToContact);
                consentObjectpropCount++;
            }

            if (odataReferralconsentconsentToToShareInfoWithOthers != null)
            {
                consentObject["consentToToShareInfoWithOthers"] = ExpressionConverter.ConvertO(odataReferralconsentconsentToToShareInfoWithOthers);
                consentObjectpropCount++;
            }

            if (odataReferralconsentconsentToShareReferralWithMicrosoftSellers != null)
            {
                consentObject["consentToShareReferralWithMicrosoftSellers"] = ExpressionConverter.ConvertO(odataReferralconsentconsentToShareReferralWithMicrosoftSellers);
                consentObjectpropCount++;
            }

            if (consentObjectpropCount > 0)
            {
                odataReferral["consent"] = consentObject;
                odataReferralpropCount++;
            }

            if (odataReferralcreatedDateTime != null)
            {
                odataReferral["createdDateTime"] = ExpressionConverter.ConvertO(odataReferralcreatedDateTime);
                odataReferralpropCount++;
            }

            var customerProfileObject = new JObject();
            var customerProfileObjectpropCount = 0;
            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (odataReferralcustomerProfileaddressaddressLine1 != null)
            {
                addressObject["addressLine1"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddressaddressLine1);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressaddressLine2 != null)
            {
                addressObject["addressLine2"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddressaddressLine2);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresscity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddresscity);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresscountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddresscountry);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresspostalCode != null)
            {
                addressObject["postalCode"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddresspostalCode);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressregion != null)
            {
                addressObject["region"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddressregion);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressstate != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileaddressstate);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                customerProfileObject["address"] = addressObject;
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfileids != null)
            {
                customerProfileObject["ids"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileids);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfilename != null)
            {
                customerProfileObject["name"] = ExpressionConverter.ConvertO(odataReferralcustomerProfilename);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfilesize != null)
            {
                customerProfileObject["size"] = ExpressionConverter.ConvertO(odataReferralcustomerProfilesize);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfileteam != null)
            {
                customerProfileObject["team"] = ExpressionConverter.ConvertO(odataReferralcustomerProfileteam);
                customerProfileObjectpropCount++;
            }

            if (customerProfileObjectpropCount > 0)
            {
                odataReferral["customerProfile"] = customerProfileObject;
                odataReferralpropCount++;
            }

            var detailsObject = new JObject();
            var detailsObjectpropCount = 0;
            if (odataReferraldetailsclosingDateTime != null)
            {
                detailsObject["closingDateTime"] = ExpressionConverter.ConvertO(odataReferraldetailsclosingDateTime);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscurrency != null)
            {
                detailsObject["currency"] = ExpressionConverter.ConvertO(odataReferraldetailscurrency);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscustomerAction != null)
            {
                detailsObject["customerAction"] = ExpressionConverter.ConvertO(odataReferraldetailscustomerAction);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscustomerRequestedContact != null)
            {
                detailsObject["customerRequestedContact"] = ExpressionConverter.ConvertO(odataReferraldetailscustomerRequestedContact);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailsdealValue != null)
            {
                detailsObject["dealValue"] = ExpressionConverter.ConvertO(odataReferraldetailsdealValue);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailsnotes != null)
            {
                detailsObject["notes"] = ExpressionConverter.ConvertO(odataReferraldetailsnotes);
                detailsObjectpropCount++;
            }

            var requirementsObject = new JObject();
            var requirementsObjectpropCount = 0;
            if (odataReferraldetailsrequirementsindustries != null)
            {
                requirementsObject["industries"] = ExpressionConverter.ConvertO(odataReferraldetailsrequirementsindustries);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsproducts != null)
            {
                requirementsObject["products"] = ExpressionConverter.ConvertO(odataReferraldetailsrequirementsproducts);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsservices != null)
            {
                requirementsObject["services"] = ExpressionConverter.ConvertO(odataReferraldetailsrequirementsservices);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementssolutions != null)
            {
                requirementsObject["solutions"] = ExpressionConverter.ConvertO(odataReferraldetailsrequirementssolutions);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsoffers != null)
            {
                requirementsObject["offers"] = ExpressionConverter.ConvertO(odataReferraldetailsrequirementsoffers);
                requirementsObjectpropCount++;
            }

            var additionalRequirementsObject = new JObject();
            var additionalRequirementsObjectpropCount = 0;
            if (additionalRequirementsObjectpropCount > 0)
            {
                requirementsObject["additionalRequirements"] = additionalRequirementsObject;
                requirementsObjectpropCount++;
            }

            if (requirementsObjectpropCount > 0)
            {
                detailsObject["requirements"] = requirementsObject;
                detailsObjectpropCount++;
            }

            if (detailsObjectpropCount > 0)
            {
                odataReferral["details"] = detailsObject;
                odataReferralpropCount++;
            }

            if (odataReferraleTag != null)
            {
                odataReferral["eTag"] = ExpressionConverter.ConvertO(odataReferraleTag);
                odataReferralpropCount++;
            }

            if (odataReferralengagementId != null)
            {
                odataReferral["engagementId"] = ExpressionConverter.ConvertO(odataReferralengagementId);
                odataReferralpropCount++;
            }

            if (odataReferralexpirationDateTime != null)
            {
                odataReferral["expirationDateTime"] = ExpressionConverter.ConvertO(odataReferralexpirationDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralexternalReferenceId != null)
            {
                odataReferral["externalReferenceId"] = ExpressionConverter.ConvertO(odataReferralexternalReferenceId);
                odataReferralpropCount++;
            }

            if (odataReferralfavorite != null)
            {
                odataReferral["favorite"] = ExpressionConverter.ConvertO(odataReferralfavorite);
                odataReferralpropCount++;
            }

            if (odataReferralid != null)
            {
                odataReferral["id"] = ExpressionConverter.ConvertO(odataReferralid);
                odataReferralpropCount++;
            }

            var inviteContextObject = new JObject();
            var inviteContextObjectpropCount = 0;
            if (odataReferralinviteContextassistanceRequestCode != null)
            {
                inviteContextObject["assistanceRequestCode"] = ExpressionConverter.ConvertO(odataReferralinviteContextassistanceRequestCode);
                inviteContextObjectpropCount++;
            }

            var invitedByObject = new JObject();
            var invitedByObjectpropCount = 0;
            if (odataReferralinviteContextinvitedByorganizationId != null)
            {
                invitedByObject["organizationId"] = ExpressionConverter.ConvertO(odataReferralinviteContextinvitedByorganizationId);
                invitedByObjectpropCount++;
            }

            if (odataReferralinviteContextinvitedByorganizationName != null)
            {
                invitedByObject["organizationName"] = ExpressionConverter.ConvertO(odataReferralinviteContextinvitedByorganizationName);
                invitedByObjectpropCount++;
            }

            if (invitedByObjectpropCount > 0)
            {
                inviteContextObject["invitedBy"] = invitedByObject;
                inviteContextObjectpropCount++;
            }

            if (odataReferralinviteContextnotes != null)
            {
                inviteContextObject["notes"] = ExpressionConverter.ConvertO(odataReferralinviteContextnotes);
                inviteContextObjectpropCount++;
            }

            if (inviteContextObjectpropCount > 0)
            {
                odataReferral["inviteContext"] = inviteContextObject;
                odataReferralpropCount++;
            }

            if (odataReferrallastModifiedVia != null)
            {
                odataReferral["lastModifiedVia"] = ExpressionConverter.ConvertO(odataReferrallastModifiedVia);
                odataReferralpropCount++;
            }

            if (odataReferrallastRunId != null)
            {
                odataReferral["lastRunId"] = ExpressionConverter.ConvertO(odataReferrallastRunId);
                odataReferralpropCount++;
            }

            var linksObject = new JObject();
            var linksObjectpropCount = 0;
            var relatedReferralsObject = new JObject();
            var relatedReferralsObjectpropCount = 0;
            if (odataReferrallinksrelatedReferralsmethod != null)
            {
                relatedReferralsObject["method"] = ExpressionConverter.ConvertO(odataReferrallinksrelatedReferralsmethod);
                relatedReferralsObjectpropCount++;
            }

            if (odataReferrallinksrelatedReferralsuri != null)
            {
                relatedReferralsObject["uri"] = ExpressionConverter.ConvertO(odataReferrallinksrelatedReferralsuri);
                relatedReferralsObjectpropCount++;
            }

            if (relatedReferralsObjectpropCount > 0)
            {
                linksObject["relatedReferrals"] = relatedReferralsObject;
                linksObjectpropCount++;
            }

            var selfObject = new JObject();
            var selfObjectpropCount = 0;
            if (odataReferrallinksselfmethod != null)
            {
                selfObject["method"] = ExpressionConverter.ConvertO(odataReferrallinksselfmethod);
                selfObjectpropCount++;
            }

            if (odataReferrallinksselfuri != null)
            {
                selfObject["uri"] = ExpressionConverter.ConvertO(odataReferrallinksselfuri);
                selfObjectpropCount++;
            }

            if (selfObjectpropCount > 0)
            {
                linksObject["self"] = selfObject;
                linksObjectpropCount++;
            }

            if (linksObjectpropCount > 0)
            {
                odataReferral["links"] = linksObject;
                odataReferralpropCount++;
            }

            if (odataReferralname != null)
            {
                odataReferral["name"] = ExpressionConverter.ConvertO(odataReferralname);
                odataReferralpropCount++;
            }

            if (odataReferralorganizationId != null)
            {
                odataReferral["organizationId"] = ExpressionConverter.ConvertO(odataReferralorganizationId);
                odataReferralpropCount++;
            }

            if (odataReferralorganizationName != null)
            {
                odataReferral["organizationName"] = ExpressionConverter.ConvertO(odataReferralorganizationName);
                odataReferralpropCount++;
            }

            if (odataReferralqualification != null)
            {
                odataReferral["qualification"] = ExpressionConverter.ConvertO(odataReferralqualification);
                odataReferralpropCount++;
            }

            if (odataReferralreferralProgram != null)
            {
                odataReferral["referralProgram"] = ExpressionConverter.ConvertO(odataReferralreferralProgram);
                odataReferralpropCount++;
            }

            if (odataReferralsalesStage != null)
            {
                odataReferral["salesStage"] = ExpressionConverter.ConvertO(odataReferralsalesStage);
                odataReferralpropCount++;
            }

            if (odataReferralstatus != null)
            {
                odataReferral["status"] = ExpressionConverter.ConvertO(odataReferralstatus);
                odataReferralpropCount++;
            }

            if (odataReferralstatusReason != null)
            {
                odataReferral["statusReason"] = ExpressionConverter.ConvertO(odataReferralstatusReason);
                odataReferralpropCount++;
            }

            if (odataReferralsubstatus != null)
            {
                odataReferral["substatus"] = ExpressionConverter.ConvertO(odataReferralsubstatus);
                odataReferralpropCount++;
            }

            if (odataReferraltarget != null)
            {
                odataReferral["target"] = ExpressionConverter.ConvertO(odataReferraltarget);
                odataReferralpropCount++;
            }

            if (odataReferralteam != null)
            {
                odataReferral["team"] = ExpressionConverter.ConvertO(odataReferralteam);
                odataReferralpropCount++;
            }

            var trackingInfoObject = new JObject();
            var trackingInfoObjectpropCount = 0;
            if (odataReferraltrackingInfomicrosoftMsxId != null)
            {
                trackingInfoObject["microsoftMsxId"] = ExpressionConverter.ConvertO(odataReferraltrackingInfomicrosoftMsxId);
                trackingInfoObjectpropCount++;
            }

            if (trackingInfoObjectpropCount > 0)
            {
                odataReferral["trackingInfo"] = trackingInfoObject;
                odataReferralpropCount++;
            }

            if (odataReferraltype != null)
            {
                odataReferral["type"] = ExpressionConverter.ConvertO(odataReferraltype);
                odataReferralpropCount++;
            }

            if (odataReferralupdatedDateTime != null)
            {
                odataReferral["updatedDateTime"] = ExpressionConverter.ConvertO(odataReferralupdatedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralmpnId != null)
            {
                odataReferral["mpnId"] = ExpressionConverter.ConvertO(odataReferralmpnId);
                odataReferralpropCount++;
            }

            if (odataReferralregistrations != null)
            {
                odataReferral["registrations"] = ExpressionConverter.ConvertO(odataReferralregistrations);
                odataReferralpropCount++;
            }

            if (odataReferralregistrationStatus != null)
            {
                odataReferral["registrationStatus"] = ExpressionConverter.ConvertO(odataReferralregistrationStatus);
                odataReferralpropCount++;
            }

            if (odataReferralcallToAction != null)
            {
                odataReferral["callToAction"] = ExpressionConverter.ConvertO(odataReferralcallToAction);
                odataReferralpropCount++;
            }

            if (odataReferralreferralSource != null)
            {
                odataReferral["referralSource"] = ExpressionConverter.ConvertO(odataReferralreferralSource);
                odataReferralpropCount++;
            }

            if (odataReferralquality != null)
            {
                odataReferral["quality"] = ExpressionConverter.ConvertO(odataReferralquality);
                odataReferralpropCount++;
            }

            if (odataReferralisSpam != null)
            {
                odataReferral["isSpam"] = ExpressionConverter.ConvertO(odataReferralisSpam);
                odataReferralpropCount++;
            }

            if (odataReferraldirection != null)
            {
                odataReferral["direction"] = ExpressionConverter.ConvertO(odataReferraldirection);
                odataReferralpropCount++;
            }

            if (odataReferraltags != null)
            {
                odataReferral["tags"] = ExpressionConverter.ConvertO(odataReferraltags);
                odataReferralpropCount++;
            }

            if (odataReferralacceptedDateTime != null)
            {
                odataReferral["acceptedDateTime"] = ExpressionConverter.ConvertO(odataReferralacceptedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralclosedDateTime != null)
            {
                odataReferral["closedDateTime"] = ExpressionConverter.ConvertO(odataReferralclosedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralpropCount > 0)
            {
                callPayload.Body = odataReferral;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchReferralById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem[]> referral = null)
        {
            var apiCallPath = String.Format("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = ExpressionConverter.ConvertO(referral);
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateDealRegistrationByReferralId([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem2[]> referral = null)
        {
            var apiCallPath = String.Format("/referrals/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = ExpressionConverter.ConvertO(referral);
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchDealRegistrationByReferralId([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem22[]> referral = null)
        {
            var apiCallPath = String.Format("/referrals/{0}//", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = ExpressionConverter.ConvertO(referral);
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }
    }

    public class PartnercenterrefTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAllReferralsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3Referral[] Value { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3Referral
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }

        [JsonProperty("consent")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralConsentType Consent { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("customerProfile")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileType CustomerProfile { get; set; }

        [JsonProperty("details")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsType Details { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("engagementId")]
        public string EngagementId { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("externalReferenceId")]
        public string ExternalReferenceId { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inviteContext")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextType InviteContext { get; set; }

        [JsonProperty("lastModifiedVia")]
        public string LastModifiedVia { get; set; }

        [JsonProperty("lastRunId")]
        public string LastRunId { get; set; }

        [JsonProperty("links")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("qualification")]
        public string Qualification { get; set; }

        [JsonProperty("referralProgram")]
        public string ReferralProgram { get; set; }

        [JsonProperty("salesStage")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralSalesStageType SalesStage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("substatus")]
        public string Substatus { get; set; }

        [JsonProperty("target")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTargetTypeItem[] Target { get; set; }

        [JsonProperty("team")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItem[] Team { get; set; }

        [JsonProperty("trackingInfo")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTrackingInfoType TrackingInfo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("mpnId")]
        public string MpnId { get; set; }

        [JsonProperty("registrations")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItem[] Registrations { get; set; }

        [JsonProperty("registrationStatus")]
        public string RegistrationStatus { get; set; }

        [JsonProperty("callToAction")]
        public string CallToAction { get; set; }

        [JsonProperty("referralSource")]
        public string ReferralSource { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("isSpam")]
        public bool IsSpam { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("acceptedDateTime")]
        public string AcceptedDateTime { get; set; }

        [JsonProperty("closedDateTime")]
        public string ClosedDateTime { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralConsentType
    {
        [JsonProperty("consentToContact")]
        public bool ConsentToContact { get; set; }

        [JsonProperty("consentToToShareInfoWithOthers")]
        public bool ConsentToToShareInfoWithOthers { get; set; }

        [JsonProperty("consentToShareReferralWithMicrosoftSellers")]
        public bool ConsentToShareReferralWithMicrosoftSellers { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileType
    {
        [JsonProperty("address")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeAddressType Address { get; set; }

        [JsonProperty("ids")]
        public JToken[] Ids { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("team")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItem[] Team { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralCustomerProfileTypeTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsType
    {
        [JsonProperty("closingDateTime")]
        public string ClosingDateTime { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customerAction")]
        public string CustomerAction { get; set; }

        [JsonProperty("customerRequestedContact")]
        public bool CustomerRequestedContact { get; set; }

        [JsonProperty("dealValue")]
        public double DealValue { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("requirements")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsType Requirements { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsType
    {
        [JsonProperty("industries")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeIndustriesTypeItem[] Industries { get; set; }

        [JsonProperty("products")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeProductsTypeItem[] Products { get; set; }

        [JsonProperty("services")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeServicesTypeItem[] Services { get; set; }

        [JsonProperty("solutions")]
        public JToken[] Solutions { get; set; }

        [JsonProperty("offers")]
        public JToken[] Offers { get; set; }

        [JsonProperty("additionalRequirements")]
        public JToken AdditionalRequirements { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeIndustriesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralDetailsTypeRequirementsTypeServicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextType
    {
        [JsonProperty("assistanceRequestCode")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeAssistanceRequestCodeType AssistanceRequestCode { get; set; }

        [JsonProperty("invitedBy")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeInvitedByType InvitedBy { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public enum MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeAssistanceRequestCodeType
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralInviteContextTypeInvitedByType
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksType
    {
        [JsonProperty("relatedReferrals")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeRelatedReferralsType RelatedReferrals { get; set; }

        [JsonProperty("self")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeSelfType Self { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeRelatedReferralsType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralLinksTypeSelfType
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public enum MicrosoftPartnerServicePartnerReferralsContractsV3ReferralSalesStageType
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTargetTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItem
    {
        [JsonProperty("contactPreference")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTeamTypeItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralTrackingInfoType
    {
        [JsonProperty("microsoftMsxId")]
        public string MicrosoftMsxId { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemStatusHistoryType StatusHistory { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemContractType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class MicrosoftPartnerServicePartnerReferralsContractsV3ReferralRegistrationsTypeItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class referralcustomerProfileteamInputItem
    {
        [JsonProperty("contactPreference")]
        public referralcustomerProfileteamInputItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class referralcustomerProfileteamInputItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class referraldetailsrequirementsindustriesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class referraldetailsrequirementsproductsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class referraldetailsrequirementsservicesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum referralinviteContextassistanceRequestCodeInput
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public enum referralsalesStageInput
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class referraltargetInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class referralteamInputItem
    {
        [JsonProperty("contactPreference")]
        public referralteamInputItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class referralteamInputItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class referralregistrationsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public referralregistrationsInputItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public referralregistrationsInputItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public referralregistrationsInputItemStatusHistoryType StatusHistory { get; set; }
    }

    public class referralregistrationsInputItemContractType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class referralregistrationsInputItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public referralregistrationsInputItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class referralregistrationsInputItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class referralregistrationsInputItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class odataReferralcustomerProfileteamInputItem
    {
        [JsonProperty("contactPreference")]
        public odataReferralcustomerProfileteamInputItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class odataReferralcustomerProfileteamInputItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class odataReferraldetailsrequirementsindustriesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class odataReferraldetailsrequirementsproductsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class odataReferraldetailsrequirementsservicesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum odataReferralinviteContextassistanceRequestCodeInput
    {
        Unknown,
        GeneralOrOther,
        CustomerTechnicalArchitecture,
        ProofOfConceptOrDemo,
        QuotesOrLicensing,
        PostSalesCustomerSuccess,
        WorkloadSpecificValueProposition
    }

    public enum odataReferralsalesStageInput
    {
        Qualify,
        Develop,
        Propose,
        Close
    }

    public class odataReferraltargetInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class odataReferralteamInputItem
    {
        [JsonProperty("contactPreference")]
        public odataReferralteamInputItemContactPreferenceType ContactPreference { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
    }

    public class odataReferralteamInputItemContactPreferenceType
    {
        [JsonProperty("disableNotifications")]
        public bool DisableNotifications { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class odataReferralregistrationsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("registrationDateTime")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusReason")]
        public string StatusReason { get; set; }

        [JsonProperty("contract")]
        public odataReferralregistrationsInputItemContractType Contract { get; set; }

        [JsonProperty("solutionDetails")]
        public odataReferralregistrationsInputItemSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("statusHistory")]
        public odataReferralregistrationsInputItemStatusHistoryType StatusHistory { get; set; }
    }

    public class odataReferralregistrationsInputItemContractType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class odataReferralregistrationsInputItemSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public string PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public string PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public odataReferralregistrationsInputItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public class odataReferralregistrationsInputItemSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class odataReferralregistrationsInputItemStatusHistoryType
    {
        [JsonProperty("reviewPendingDateTime")]
        public string ReviewPendingDateTime { get; set; }

        [JsonProperty("actionRequiredDateTime")]
        public string ActionRequiredDateTime { get; set; }

        [JsonProperty("passedDateTime")]
        public string PassedDateTime { get; set; }

        [JsonProperty("failedDateTime")]
        public string FailedDateTime { get; set; }

        [JsonProperty("approvedDateTime")]
        public string ApprovedDateTime { get; set; }
    }

    public class referralInputItem
    {
        [JsonProperty("op")]
        public referralInputItemUpdateOperationType UpdateOperation { get; set; }

        [JsonProperty("path")]
        public referralInputItemFieldPathType FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public enum referralInputItemUpdateOperationType
    {
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "add")]
        Add
    }

    public enum referralInputItemFieldPathType
    {
        [EnumMember(Value = "/registrations/0/contract/startDateTime")]
        Registrations0ContractStartDateTime,
        [EnumMember(Value = "/registrations/0/contract/endDateTime")]
        Registrations0ContractEndDateTime,
        [EnumMember(Value = "/registrations/0/contract/signDateTime")]
        Registrations0ContractSignDateTime,
        [EnumMember(Value = "/registrations/0/contract/term")]
        Registrations0ContractTerm,
        [EnumMember(Value = "/registrations/0/contract/value")]
        Registrations0ContractValue,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/value")]
        Registrations0SolutionDetails0Value,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/currency")]
        Registrations0SolutionDetails0Currency,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/isDeployedOnAzure")]
        Registrations0SolutionDetails0IsDeployedOnAzure,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/primaryDeploymentOn")]
        Registrations0SolutionDetails0PrimaryDeploymentOn,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/pricingModel")]
        Registrations0SolutionDetails0PricingModel,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/marketplaceTransactionDetails/isMarketplaceTransacted")]
        Registrations0SolutionDetails0MarketplaceTransactionDetailsIsMarketplaceTransacted,
        [EnumMember(Value = "/registrations/0/solutionDetails/0/marketplaceTransactionDetails/marketplaceTransactionDateTime")]
        Registrations0SolutionDetails0MarketplaceTransactionDetailsMarketplaceTransactionDateTime
    }

    public class referralInputItem2
    {
        [JsonProperty("op")]
        public referralInputItemOpType Op { get; set; }

        [JsonProperty("path")]
        public referralInputItemPathType Path { get; set; }

        [JsonProperty("value")]
        public referralInputItemValueType Value { get; set; }
    }

    public enum referralInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add
    }

    public enum referralInputItemPathType
    {
        [EnumMember(Value = "/registrations/-")]
        Registrations
    }

    public class referralInputItemValueType
    {
        [JsonProperty("type")]
        public referralInputItemValueTypeTypeType Type { get; set; }

        [JsonProperty("solutionDetails")]
        public referralInputItemValueTypeSolutionDetailsTypeItem[] SolutionDetails { get; set; }

        [JsonProperty("contract")]
        public referralInputItemValueTypeContractType Contract { get; set; }
    }

    public enum referralInputItemValueTypeTypeType
    {
        AzureIPCoSell
    }

    public class referralInputItemValueTypeSolutionDetailsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("isDeployedOnAzure")]
        public bool IsDeployedOnAzure { get; set; }

        [JsonProperty("primaryDeploymentOn")]
        public referralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType PrimaryDeploymentOn { get; set; }

        [JsonProperty("pricingModel")]
        public referralInputItemValueTypeSolutionDetailsTypeItemPricingModelType PricingModel { get; set; }

        [JsonProperty("marketplaceTransactionDetails")]
        public referralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType MarketplaceTransactionDetails { get; set; }
    }

    public enum referralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType
    {
        Customer,
        Partner
    }

    public enum referralInputItemValueTypeSolutionDetailsTypeItemPricingModelType
    {
        PayAsYouGo,
        Other
    }

    public class referralInputItemValueTypeSolutionDetailsTypeItemMarketplaceTransactionDetailsType
    {
        [JsonProperty("isMarketplaceTransacted")]
        public bool IsMarketplaceTransacted { get; set; }

        [JsonProperty("marketplaceTransactionDateTime")]
        public string MarketplaceTransactionDateTime { get; set; }
    }

    public class referralInputItemValueTypeContractType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("term")]
        public referralInputItemValueTypeContractTypeTermType Term { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("signDateTime")]
        public string SignDateTime { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }
    }

    public enum referralInputItemValueTypeContractTypeTermType
    {
        Perpetual,
        Finite
    }

    public class referralInputItem22
    {
        [JsonProperty("op")]
        public referralInputItemUpdateOperationType UpdateOperation { get; set; }

        [JsonProperty("path")]
        public referralInputItemFieldPathType FieldPath { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref;

    public partial class WorkflowManagedActions
    {
        public PartnercenterrefActions Partnercenterref(string connectionId) => new PartnercenterrefActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PartnercenterrefTriggers Partnercenterref(string connectionId) => new PartnercenterrefTriggers(connectionId);
    }
}