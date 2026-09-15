//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercenterrefActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<GetAllReferralsResponse> GetAllReferrals(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var apiCallPath = "/referrals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["$skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (count != null)
                callPayload.Queries["$count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            return new ApiConnectionAction<GetAllReferralsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateReferral(Expression<Func<string>> referralcontext = null, Expression<Func<string>> referralcampaignId = null, Expression<Func<bool>> referralconsentconsentToContact = null, Expression<Func<bool>> referralconsentconsentToToShareInfoWithOthers = null, Expression<Func<bool>> referralconsentconsentToShareReferralWithMicrosoftSellers = null, Expression<Func<string>> referralcreatedDateTime = null, Expression<Func<string>> referralcustomerProfileaddressaddressLine1 = null, Expression<Func<string>> referralcustomerProfileaddressaddressLine2 = null, Expression<Func<string>> referralcustomerProfileaddresscity = null, Expression<Func<string>> referralcustomerProfileaddresscountry = null, Expression<Func<string>> referralcustomerProfileaddresspostalCode = null, Expression<Func<string>> referralcustomerProfileaddressregion = null, Expression<Func<string>> referralcustomerProfileaddressstate = null, Expression<Func<JToken[]>> referralcustomerProfileids = null, Expression<Func<string>> referralcustomerProfilename = null, Expression<Func<string>> referralcustomerProfilesize = null, Expression<Func<referralcustomerProfileteamInputItem[]>> referralcustomerProfileteam = null, Expression<Func<string>> referraldetailsclosingDateTime = null, Expression<Func<string>> referraldetailscurrency = null, Expression<Func<string>> referraldetailscustomerAction = null, Expression<Func<bool>> referraldetailscustomerRequestedContact = null, Expression<Func<double>> referraldetailsdealValue = null, Expression<Func<string>> referraldetailsnotes = null, Expression<Func<referraldetailsrequirementsindustriesInputItem[]>> referraldetailsrequirementsindustries = null, Expression<Func<referraldetailsrequirementsproductsInputItem[]>> referraldetailsrequirementsproducts = null, Expression<Func<referraldetailsrequirementsservicesInputItem[]>> referraldetailsrequirementsservices = null, Expression<Func<JToken[]>> referraldetailsrequirementssolutions = null, Expression<Func<JToken[]>> referraldetailsrequirementsoffers = null, Expression<Func<string>> referraleTag = null, Expression<Func<string>> referralengagementId = null, Expression<Func<string>> referralexpirationDateTime = null, Expression<Func<string>> referralexternalReferenceId = null, Expression<Func<bool>> referralfavorite = null, Expression<Func<string>> referralid = null, Expression<Func<referralinviteContextassistanceRequestCodeInput>> referralinviteContextassistanceRequestCode = null, Expression<Func<string>> referralinviteContextinvitedByorganizationId = null, Expression<Func<string>> referralinviteContextinvitedByorganizationName = null, Expression<Func<string>> referralinviteContextnotes = null, Expression<Func<string>> referrallastModifiedVia = null, Expression<Func<string>> referrallastRunId = null, Expression<Func<string>> referrallinksrelatedReferralsmethod = null, Expression<Func<string>> referrallinksrelatedReferralsuri = null, Expression<Func<string>> referrallinksselfmethod = null, Expression<Func<string>> referrallinksselfuri = null, Expression<Func<string>> referralname = null, Expression<Func<string>> referralorganizationId = null, Expression<Func<string>> referralorganizationName = null, Expression<Func<string>> referralqualification = null, Expression<Func<string>> referralreferralProgram = null, Expression<Func<referralsalesStageInput>> referralsalesStage = null, Expression<Func<string>> referralstatus = null, Expression<Func<string>> referralstatusReason = null, Expression<Func<string>> referralsubstatus = null, Expression<Func<referraltargetInputItem[]>> referraltarget = null, Expression<Func<referralteamInputItem[]>> referralteam = null, Expression<Func<string>> referraltrackingInfomicrosoftMsxId = null, Expression<Func<string>> referraltype = null, Expression<Func<string>> referralupdatedDateTime = null, Expression<Func<string>> referralmpnId = null, Expression<Func<referralregistrationsInputItem[]>> referralregistrations = null, Expression<Func<string>> referralregistrationStatus = null, Expression<Func<string>> referralcallToAction = null, Expression<Func<string>> referralreferralSource = null, Expression<Func<string>> referralquality = null, Expression<Func<bool>> referralisSpam = null, Expression<Func<string>> referraldirection = null, Expression<Func<string[]>> referraltags = null, Expression<Func<string>> referralacceptedDateTime = null, Expression<Func<string>> referralclosedDateTime = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var apiCallPath = "/referrals";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            var referral = new JObject();
            var referralpropCount = 0;
            if (referralcontext != null)
            {
                referral["@odata.context"] = CSharpExpressionConverter.ConvertToken(referralcontext);
                referralpropCount++;
            }

            if (referralcampaignId != null)
            {
                referral["campaignId"] = CSharpExpressionConverter.ConvertToken(referralcampaignId);
                referralpropCount++;
            }

            var consentObject = new JObject();
            var consentObjectpropCount = 0;
            if (referralconsentconsentToContact != null)
            {
                consentObject["consentToContact"] = CSharpExpressionConverter.ConvertToken(referralconsentconsentToContact);
                consentObjectpropCount++;
            }

            if (referralconsentconsentToToShareInfoWithOthers != null)
            {
                consentObject["consentToToShareInfoWithOthers"] = CSharpExpressionConverter.ConvertToken(referralconsentconsentToToShareInfoWithOthers);
                consentObjectpropCount++;
            }

            if (referralconsentconsentToShareReferralWithMicrosoftSellers != null)
            {
                consentObject["consentToShareReferralWithMicrosoftSellers"] = CSharpExpressionConverter.ConvertToken(referralconsentconsentToShareReferralWithMicrosoftSellers);
                consentObjectpropCount++;
            }

            if (consentObjectpropCount > 0)
            {
                referral["consent"] = consentObject;
                referralpropCount++;
            }

            if (referralcreatedDateTime != null)
            {
                referral["createdDateTime"] = CSharpExpressionConverter.ConvertToken(referralcreatedDateTime);
                referralpropCount++;
            }

            var customerProfileObject = new JObject();
            var customerProfileObjectpropCount = 0;
            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (referralcustomerProfileaddressaddressLine1 != null)
            {
                addressObject["addressLine1"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddressaddressLine1);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressaddressLine2 != null)
            {
                addressObject["addressLine2"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddressaddressLine2);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddresscity);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddresscountry);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddresspostalCode);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressregion != null)
            {
                addressObject["region"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddressregion);
                addressObjectpropCount++;
            }

            if (referralcustomerProfileaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileaddressstate);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                customerProfileObject["address"] = addressObject;
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfileids != null)
            {
                customerProfileObject["ids"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileids);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfilename != null)
            {
                customerProfileObject["name"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfilename);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfilesize != null)
            {
                customerProfileObject["size"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfilesize);
                customerProfileObjectpropCount++;
            }

            if (referralcustomerProfileteam != null)
            {
                customerProfileObject["team"] = CSharpExpressionConverter.ConvertToken(referralcustomerProfileteam);
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
                detailsObject["closingDateTime"] = CSharpExpressionConverter.ConvertToken(referraldetailsclosingDateTime);
                detailsObjectpropCount++;
            }

            if (referraldetailscurrency != null)
            {
                detailsObject["currency"] = CSharpExpressionConverter.ConvertToken(referraldetailscurrency);
                detailsObjectpropCount++;
            }

            if (referraldetailscustomerAction != null)
            {
                detailsObject["customerAction"] = CSharpExpressionConverter.ConvertToken(referraldetailscustomerAction);
                detailsObjectpropCount++;
            }

            if (referraldetailscustomerRequestedContact != null)
            {
                detailsObject["customerRequestedContact"] = CSharpExpressionConverter.ConvertToken(referraldetailscustomerRequestedContact);
                detailsObjectpropCount++;
            }

            if (referraldetailsdealValue != null)
            {
                detailsObject["dealValue"] = CSharpExpressionConverter.ConvertToken(referraldetailsdealValue);
                detailsObjectpropCount++;
            }

            if (referraldetailsnotes != null)
            {
                detailsObject["notes"] = CSharpExpressionConverter.ConvertToken(referraldetailsnotes);
                detailsObjectpropCount++;
            }

            var requirementsObject = new JObject();
            var requirementsObjectpropCount = 0;
            if (referraldetailsrequirementsindustries != null)
            {
                requirementsObject["industries"] = CSharpExpressionConverter.ConvertToken(referraldetailsrequirementsindustries);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsproducts != null)
            {
                requirementsObject["products"] = CSharpExpressionConverter.ConvertToken(referraldetailsrequirementsproducts);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsservices != null)
            {
                requirementsObject["services"] = CSharpExpressionConverter.ConvertToken(referraldetailsrequirementsservices);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementssolutions != null)
            {
                requirementsObject["solutions"] = CSharpExpressionConverter.ConvertToken(referraldetailsrequirementssolutions);
                requirementsObjectpropCount++;
            }

            if (referraldetailsrequirementsoffers != null)
            {
                requirementsObject["offers"] = CSharpExpressionConverter.ConvertToken(referraldetailsrequirementsoffers);
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
                referral["eTag"] = CSharpExpressionConverter.ConvertToken(referraleTag);
                referralpropCount++;
            }

            if (referralengagementId != null)
            {
                referral["engagementId"] = CSharpExpressionConverter.ConvertToken(referralengagementId);
                referralpropCount++;
            }

            if (referralexpirationDateTime != null)
            {
                referral["expirationDateTime"] = CSharpExpressionConverter.ConvertToken(referralexpirationDateTime);
                referralpropCount++;
            }

            if (referralexternalReferenceId != null)
            {
                referral["externalReferenceId"] = CSharpExpressionConverter.ConvertToken(referralexternalReferenceId);
                referralpropCount++;
            }

            if (referralfavorite != null)
            {
                referral["favorite"] = CSharpExpressionConverter.ConvertToken(referralfavorite);
                referralpropCount++;
            }

            if (referralid != null)
            {
                referral["id"] = CSharpExpressionConverter.ConvertToken(referralid);
                referralpropCount++;
            }

            var inviteContextObject = new JObject();
            var inviteContextObjectpropCount = 0;
            if (referralinviteContextassistanceRequestCode != null)
            {
                inviteContextObject["assistanceRequestCode"] = CSharpExpressionConverter.Convert(referralinviteContextassistanceRequestCode);
                inviteContextObjectpropCount++;
            }

            var invitedByObject = new JObject();
            var invitedByObjectpropCount = 0;
            if (referralinviteContextinvitedByorganizationId != null)
            {
                invitedByObject["organizationId"] = CSharpExpressionConverter.ConvertToken(referralinviteContextinvitedByorganizationId);
                invitedByObjectpropCount++;
            }

            if (referralinviteContextinvitedByorganizationName != null)
            {
                invitedByObject["organizationName"] = CSharpExpressionConverter.ConvertToken(referralinviteContextinvitedByorganizationName);
                invitedByObjectpropCount++;
            }

            if (invitedByObjectpropCount > 0)
            {
                inviteContextObject["invitedBy"] = invitedByObject;
                inviteContextObjectpropCount++;
            }

            if (referralinviteContextnotes != null)
            {
                inviteContextObject["notes"] = CSharpExpressionConverter.ConvertToken(referralinviteContextnotes);
                inviteContextObjectpropCount++;
            }

            if (inviteContextObjectpropCount > 0)
            {
                referral["inviteContext"] = inviteContextObject;
                referralpropCount++;
            }

            if (referrallastModifiedVia != null)
            {
                referral["lastModifiedVia"] = CSharpExpressionConverter.ConvertToken(referrallastModifiedVia);
                referralpropCount++;
            }

            if (referrallastRunId != null)
            {
                referral["lastRunId"] = CSharpExpressionConverter.ConvertToken(referrallastRunId);
                referralpropCount++;
            }

            var linksObject = new JObject();
            var linksObjectpropCount = 0;
            var relatedReferralsObject = new JObject();
            var relatedReferralsObjectpropCount = 0;
            if (referrallinksrelatedReferralsmethod != null)
            {
                relatedReferralsObject["method"] = CSharpExpressionConverter.ConvertToken(referrallinksrelatedReferralsmethod);
                relatedReferralsObjectpropCount++;
            }

            if (referrallinksrelatedReferralsuri != null)
            {
                relatedReferralsObject["uri"] = CSharpExpressionConverter.ConvertToken(referrallinksrelatedReferralsuri);
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
                selfObject["method"] = CSharpExpressionConverter.ConvertToken(referrallinksselfmethod);
                selfObjectpropCount++;
            }

            if (referrallinksselfuri != null)
            {
                selfObject["uri"] = CSharpExpressionConverter.ConvertToken(referrallinksselfuri);
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
                referral["name"] = CSharpExpressionConverter.ConvertToken(referralname);
                referralpropCount++;
            }

            if (referralorganizationId != null)
            {
                referral["organizationId"] = CSharpExpressionConverter.ConvertToken(referralorganizationId);
                referralpropCount++;
            }

            if (referralorganizationName != null)
            {
                referral["organizationName"] = CSharpExpressionConverter.ConvertToken(referralorganizationName);
                referralpropCount++;
            }

            if (referralqualification != null)
            {
                referral["qualification"] = CSharpExpressionConverter.ConvertToken(referralqualification);
                referralpropCount++;
            }

            if (referralreferralProgram != null)
            {
                referral["referralProgram"] = CSharpExpressionConverter.ConvertToken(referralreferralProgram);
                referralpropCount++;
            }

            if (referralsalesStage != null)
            {
                referral["salesStage"] = CSharpExpressionConverter.Convert(referralsalesStage);
                referralpropCount++;
            }

            if (referralstatus != null)
            {
                referral["status"] = CSharpExpressionConverter.ConvertToken(referralstatus);
                referralpropCount++;
            }

            if (referralstatusReason != null)
            {
                referral["statusReason"] = CSharpExpressionConverter.ConvertToken(referralstatusReason);
                referralpropCount++;
            }

            if (referralsubstatus != null)
            {
                referral["substatus"] = CSharpExpressionConverter.ConvertToken(referralsubstatus);
                referralpropCount++;
            }

            if (referraltarget != null)
            {
                referral["target"] = CSharpExpressionConverter.ConvertToken(referraltarget);
                referralpropCount++;
            }

            if (referralteam != null)
            {
                referral["team"] = CSharpExpressionConverter.ConvertToken(referralteam);
                referralpropCount++;
            }

            var trackingInfoObject = new JObject();
            var trackingInfoObjectpropCount = 0;
            if (referraltrackingInfomicrosoftMsxId != null)
            {
                trackingInfoObject["microsoftMsxId"] = CSharpExpressionConverter.ConvertToken(referraltrackingInfomicrosoftMsxId);
                trackingInfoObjectpropCount++;
            }

            if (trackingInfoObjectpropCount > 0)
            {
                referral["trackingInfo"] = trackingInfoObject;
                referralpropCount++;
            }

            if (referraltype != null)
            {
                referral["type"] = CSharpExpressionConverter.ConvertToken(referraltype);
                referralpropCount++;
            }

            if (referralupdatedDateTime != null)
            {
                referral["updatedDateTime"] = CSharpExpressionConverter.ConvertToken(referralupdatedDateTime);
                referralpropCount++;
            }

            if (referralmpnId != null)
            {
                referral["mpnId"] = CSharpExpressionConverter.ConvertToken(referralmpnId);
                referralpropCount++;
            }

            if (referralregistrations != null)
            {
                referral["registrations"] = CSharpExpressionConverter.ConvertToken(referralregistrations);
                referralpropCount++;
            }

            if (referralregistrationStatus != null)
            {
                referral["registrationStatus"] = CSharpExpressionConverter.ConvertToken(referralregistrationStatus);
                referralpropCount++;
            }

            if (referralcallToAction != null)
            {
                referral["callToAction"] = CSharpExpressionConverter.ConvertToken(referralcallToAction);
                referralpropCount++;
            }

            if (referralreferralSource != null)
            {
                referral["referralSource"] = CSharpExpressionConverter.ConvertToken(referralreferralSource);
                referralpropCount++;
            }

            if (referralquality != null)
            {
                referral["quality"] = CSharpExpressionConverter.ConvertToken(referralquality);
                referralpropCount++;
            }

            if (referralisSpam != null)
            {
                referral["isSpam"] = CSharpExpressionConverter.ConvertToken(referralisSpam);
                referralpropCount++;
            }

            if (referraldirection != null)
            {
                referral["direction"] = CSharpExpressionConverter.ConvertToken(referraldirection);
                referralpropCount++;
            }

            if (referraltags != null)
            {
                referral["tags"] = CSharpExpressionConverter.ConvertToken(referraltags);
                referralpropCount++;
            }

            if (referralacceptedDateTime != null)
            {
                referral["acceptedDateTime"] = CSharpExpressionConverter.ConvertToken(referralacceptedDateTime);
                referralpropCount++;
            }

            if (referralclosedDateTime != null)
            {
                referral["closedDateTime"] = CSharpExpressionConverter.ConvertToken(referralclosedDateTime);
                referralpropCount++;
            }

            if (referralpropCount > 0)
            {
                callPayload.Body = referral;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> GetReferralById(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/referrals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> UpdateReferralById(Expression<Func<string>> id, Expression<Func<string>> ifMatch, Expression<Func<string>> odataReferralcontext = null, Expression<Func<string>> odataReferralcampaignId = null, Expression<Func<bool>> odataReferralconsentconsentToContact = null, Expression<Func<bool>> odataReferralconsentconsentToToShareInfoWithOthers = null, Expression<Func<bool>> odataReferralconsentconsentToShareReferralWithMicrosoftSellers = null, Expression<Func<string>> odataReferralcreatedDateTime = null, Expression<Func<string>> odataReferralcustomerProfileaddressaddressLine1 = null, Expression<Func<string>> odataReferralcustomerProfileaddressaddressLine2 = null, Expression<Func<string>> odataReferralcustomerProfileaddresscity = null, Expression<Func<string>> odataReferralcustomerProfileaddresscountry = null, Expression<Func<string>> odataReferralcustomerProfileaddresspostalCode = null, Expression<Func<string>> odataReferralcustomerProfileaddressregion = null, Expression<Func<string>> odataReferralcustomerProfileaddressstate = null, Expression<Func<JToken[]>> odataReferralcustomerProfileids = null, Expression<Func<string>> odataReferralcustomerProfilename = null, Expression<Func<string>> odataReferralcustomerProfilesize = null, Expression<Func<odataReferralcustomerProfileteamInputItem[]>> odataReferralcustomerProfileteam = null, Expression<Func<string>> odataReferraldetailsclosingDateTime = null, Expression<Func<string>> odataReferraldetailscurrency = null, Expression<Func<string>> odataReferraldetailscustomerAction = null, Expression<Func<bool>> odataReferraldetailscustomerRequestedContact = null, Expression<Func<double>> odataReferraldetailsdealValue = null, Expression<Func<string>> odataReferraldetailsnotes = null, Expression<Func<odataReferraldetailsrequirementsindustriesInputItem[]>> odataReferraldetailsrequirementsindustries = null, Expression<Func<odataReferraldetailsrequirementsproductsInputItem[]>> odataReferraldetailsrequirementsproducts = null, Expression<Func<odataReferraldetailsrequirementsservicesInputItem[]>> odataReferraldetailsrequirementsservices = null, Expression<Func<JToken[]>> odataReferraldetailsrequirementssolutions = null, Expression<Func<JToken[]>> odataReferraldetailsrequirementsoffers = null, Expression<Func<string>> odataReferraleTag = null, Expression<Func<string>> odataReferralengagementId = null, Expression<Func<string>> odataReferralexpirationDateTime = null, Expression<Func<string>> odataReferralexternalReferenceId = null, Expression<Func<bool>> odataReferralfavorite = null, Expression<Func<string>> odataReferralid = null, Expression<Func<odataReferralinviteContextassistanceRequestCodeInput>> odataReferralinviteContextassistanceRequestCode = null, Expression<Func<string>> odataReferralinviteContextinvitedByorganizationId = null, Expression<Func<string>> odataReferralinviteContextinvitedByorganizationName = null, Expression<Func<string>> odataReferralinviteContextnotes = null, Expression<Func<string>> odataReferrallastModifiedVia = null, Expression<Func<string>> odataReferrallastRunId = null, Expression<Func<string>> odataReferrallinksrelatedReferralsmethod = null, Expression<Func<string>> odataReferrallinksrelatedReferralsuri = null, Expression<Func<string>> odataReferrallinksselfmethod = null, Expression<Func<string>> odataReferrallinksselfuri = null, Expression<Func<string>> odataReferralname = null, Expression<Func<string>> odataReferralorganizationId = null, Expression<Func<string>> odataReferralorganizationName = null, Expression<Func<string>> odataReferralqualification = null, Expression<Func<string>> odataReferralreferralProgram = null, Expression<Func<odataReferralsalesStageInput>> odataReferralsalesStage = null, Expression<Func<string>> odataReferralstatus = null, Expression<Func<string>> odataReferralstatusReason = null, Expression<Func<string>> odataReferralsubstatus = null, Expression<Func<odataReferraltargetInputItem[]>> odataReferraltarget = null, Expression<Func<odataReferralteamInputItem[]>> odataReferralteam = null, Expression<Func<string>> odataReferraltrackingInfomicrosoftMsxId = null, Expression<Func<string>> odataReferraltype = null, Expression<Func<string>> odataReferralupdatedDateTime = null, Expression<Func<string>> odataReferralmpnId = null, Expression<Func<odataReferralregistrationsInputItem[]>> odataReferralregistrations = null, Expression<Func<string>> odataReferralregistrationStatus = null, Expression<Func<string>> odataReferralcallToAction = null, Expression<Func<string>> odataReferralreferralSource = null, Expression<Func<string>> odataReferralquality = null, Expression<Func<bool>> odataReferralisSpam = null, Expression<Func<string>> odataReferraldirection = null, Expression<Func<string[]>> odataReferraltags = null, Expression<Func<string>> odataReferralacceptedDateTime = null, Expression<Func<string>> odataReferralclosedDateTime = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/referrals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["if-match"] = CSharpExpressionConverter.ConvertO(ifMatch);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            var odataReferral = new JObject();
            var odataReferralpropCount = 0;
            if (odataReferralcontext != null)
            {
                odataReferral["@odata.context"] = CSharpExpressionConverter.ConvertToken(odataReferralcontext);
                odataReferralpropCount++;
            }

            if (odataReferralcampaignId != null)
            {
                odataReferral["campaignId"] = CSharpExpressionConverter.ConvertToken(odataReferralcampaignId);
                odataReferralpropCount++;
            }

            var consentObject = new JObject();
            var consentObjectpropCount = 0;
            if (odataReferralconsentconsentToContact != null)
            {
                consentObject["consentToContact"] = CSharpExpressionConverter.ConvertToken(odataReferralconsentconsentToContact);
                consentObjectpropCount++;
            }

            if (odataReferralconsentconsentToToShareInfoWithOthers != null)
            {
                consentObject["consentToToShareInfoWithOthers"] = CSharpExpressionConverter.ConvertToken(odataReferralconsentconsentToToShareInfoWithOthers);
                consentObjectpropCount++;
            }

            if (odataReferralconsentconsentToShareReferralWithMicrosoftSellers != null)
            {
                consentObject["consentToShareReferralWithMicrosoftSellers"] = CSharpExpressionConverter.ConvertToken(odataReferralconsentconsentToShareReferralWithMicrosoftSellers);
                consentObjectpropCount++;
            }

            if (consentObjectpropCount > 0)
            {
                odataReferral["consent"] = consentObject;
                odataReferralpropCount++;
            }

            if (odataReferralcreatedDateTime != null)
            {
                odataReferral["createdDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferralcreatedDateTime);
                odataReferralpropCount++;
            }

            var customerProfileObject = new JObject();
            var customerProfileObjectpropCount = 0;
            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (odataReferralcustomerProfileaddressaddressLine1 != null)
            {
                addressObject["addressLine1"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressaddressLine1);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressaddressLine2 != null)
            {
                addressObject["addressLine2"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressaddressLine2);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresscity);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresscountry);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresspostalCode);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressregion != null)
            {
                addressObject["region"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressregion);
                addressObjectpropCount++;
            }

            if (odataReferralcustomerProfileaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressstate);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                customerProfileObject["address"] = addressObject;
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfileids != null)
            {
                customerProfileObject["ids"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileids);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfilename != null)
            {
                customerProfileObject["name"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfilename);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfilesize != null)
            {
                customerProfileObject["size"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfilesize);
                customerProfileObjectpropCount++;
            }

            if (odataReferralcustomerProfileteam != null)
            {
                customerProfileObject["team"] = CSharpExpressionConverter.ConvertToken(odataReferralcustomerProfileteam);
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
                detailsObject["closingDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsclosingDateTime);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscurrency != null)
            {
                detailsObject["currency"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailscurrency);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscustomerAction != null)
            {
                detailsObject["customerAction"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailscustomerAction);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailscustomerRequestedContact != null)
            {
                detailsObject["customerRequestedContact"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailscustomerRequestedContact);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailsdealValue != null)
            {
                detailsObject["dealValue"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsdealValue);
                detailsObjectpropCount++;
            }

            if (odataReferraldetailsnotes != null)
            {
                detailsObject["notes"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsnotes);
                detailsObjectpropCount++;
            }

            var requirementsObject = new JObject();
            var requirementsObjectpropCount = 0;
            if (odataReferraldetailsrequirementsindustries != null)
            {
                requirementsObject["industries"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsrequirementsindustries);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsproducts != null)
            {
                requirementsObject["products"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsrequirementsproducts);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsservices != null)
            {
                requirementsObject["services"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsrequirementsservices);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementssolutions != null)
            {
                requirementsObject["solutions"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsrequirementssolutions);
                requirementsObjectpropCount++;
            }

            if (odataReferraldetailsrequirementsoffers != null)
            {
                requirementsObject["offers"] = CSharpExpressionConverter.ConvertToken(odataReferraldetailsrequirementsoffers);
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
                odataReferral["eTag"] = CSharpExpressionConverter.ConvertToken(odataReferraleTag);
                odataReferralpropCount++;
            }

            if (odataReferralengagementId != null)
            {
                odataReferral["engagementId"] = CSharpExpressionConverter.ConvertToken(odataReferralengagementId);
                odataReferralpropCount++;
            }

            if (odataReferralexpirationDateTime != null)
            {
                odataReferral["expirationDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferralexpirationDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralexternalReferenceId != null)
            {
                odataReferral["externalReferenceId"] = CSharpExpressionConverter.ConvertToken(odataReferralexternalReferenceId);
                odataReferralpropCount++;
            }

            if (odataReferralfavorite != null)
            {
                odataReferral["favorite"] = CSharpExpressionConverter.ConvertToken(odataReferralfavorite);
                odataReferralpropCount++;
            }

            if (odataReferralid != null)
            {
                odataReferral["id"] = CSharpExpressionConverter.ConvertToken(odataReferralid);
                odataReferralpropCount++;
            }

            var inviteContextObject = new JObject();
            var inviteContextObjectpropCount = 0;
            if (odataReferralinviteContextassistanceRequestCode != null)
            {
                inviteContextObject["assistanceRequestCode"] = CSharpExpressionConverter.Convert(odataReferralinviteContextassistanceRequestCode);
                inviteContextObjectpropCount++;
            }

            var invitedByObject = new JObject();
            var invitedByObjectpropCount = 0;
            if (odataReferralinviteContextinvitedByorganizationId != null)
            {
                invitedByObject["organizationId"] = CSharpExpressionConverter.ConvertToken(odataReferralinviteContextinvitedByorganizationId);
                invitedByObjectpropCount++;
            }

            if (odataReferralinviteContextinvitedByorganizationName != null)
            {
                invitedByObject["organizationName"] = CSharpExpressionConverter.ConvertToken(odataReferralinviteContextinvitedByorganizationName);
                invitedByObjectpropCount++;
            }

            if (invitedByObjectpropCount > 0)
            {
                inviteContextObject["invitedBy"] = invitedByObject;
                inviteContextObjectpropCount++;
            }

            if (odataReferralinviteContextnotes != null)
            {
                inviteContextObject["notes"] = CSharpExpressionConverter.ConvertToken(odataReferralinviteContextnotes);
                inviteContextObjectpropCount++;
            }

            if (inviteContextObjectpropCount > 0)
            {
                odataReferral["inviteContext"] = inviteContextObject;
                odataReferralpropCount++;
            }

            if (odataReferrallastModifiedVia != null)
            {
                odataReferral["lastModifiedVia"] = CSharpExpressionConverter.ConvertToken(odataReferrallastModifiedVia);
                odataReferralpropCount++;
            }

            if (odataReferrallastRunId != null)
            {
                odataReferral["lastRunId"] = CSharpExpressionConverter.ConvertToken(odataReferrallastRunId);
                odataReferralpropCount++;
            }

            var linksObject = new JObject();
            var linksObjectpropCount = 0;
            var relatedReferralsObject = new JObject();
            var relatedReferralsObjectpropCount = 0;
            if (odataReferrallinksrelatedReferralsmethod != null)
            {
                relatedReferralsObject["method"] = CSharpExpressionConverter.ConvertToken(odataReferrallinksrelatedReferralsmethod);
                relatedReferralsObjectpropCount++;
            }

            if (odataReferrallinksrelatedReferralsuri != null)
            {
                relatedReferralsObject["uri"] = CSharpExpressionConverter.ConvertToken(odataReferrallinksrelatedReferralsuri);
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
                selfObject["method"] = CSharpExpressionConverter.ConvertToken(odataReferrallinksselfmethod);
                selfObjectpropCount++;
            }

            if (odataReferrallinksselfuri != null)
            {
                selfObject["uri"] = CSharpExpressionConverter.ConvertToken(odataReferrallinksselfuri);
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
                odataReferral["name"] = CSharpExpressionConverter.ConvertToken(odataReferralname);
                odataReferralpropCount++;
            }

            if (odataReferralorganizationId != null)
            {
                odataReferral["organizationId"] = CSharpExpressionConverter.ConvertToken(odataReferralorganizationId);
                odataReferralpropCount++;
            }

            if (odataReferralorganizationName != null)
            {
                odataReferral["organizationName"] = CSharpExpressionConverter.ConvertToken(odataReferralorganizationName);
                odataReferralpropCount++;
            }

            if (odataReferralqualification != null)
            {
                odataReferral["qualification"] = CSharpExpressionConverter.ConvertToken(odataReferralqualification);
                odataReferralpropCount++;
            }

            if (odataReferralreferralProgram != null)
            {
                odataReferral["referralProgram"] = CSharpExpressionConverter.ConvertToken(odataReferralreferralProgram);
                odataReferralpropCount++;
            }

            if (odataReferralsalesStage != null)
            {
                odataReferral["salesStage"] = CSharpExpressionConverter.Convert(odataReferralsalesStage);
                odataReferralpropCount++;
            }

            if (odataReferralstatus != null)
            {
                odataReferral["status"] = CSharpExpressionConverter.ConvertToken(odataReferralstatus);
                odataReferralpropCount++;
            }

            if (odataReferralstatusReason != null)
            {
                odataReferral["statusReason"] = CSharpExpressionConverter.ConvertToken(odataReferralstatusReason);
                odataReferralpropCount++;
            }

            if (odataReferralsubstatus != null)
            {
                odataReferral["substatus"] = CSharpExpressionConverter.ConvertToken(odataReferralsubstatus);
                odataReferralpropCount++;
            }

            if (odataReferraltarget != null)
            {
                odataReferral["target"] = CSharpExpressionConverter.ConvertToken(odataReferraltarget);
                odataReferralpropCount++;
            }

            if (odataReferralteam != null)
            {
                odataReferral["team"] = CSharpExpressionConverter.ConvertToken(odataReferralteam);
                odataReferralpropCount++;
            }

            var trackingInfoObject = new JObject();
            var trackingInfoObjectpropCount = 0;
            if (odataReferraltrackingInfomicrosoftMsxId != null)
            {
                trackingInfoObject["microsoftMsxId"] = CSharpExpressionConverter.ConvertToken(odataReferraltrackingInfomicrosoftMsxId);
                trackingInfoObjectpropCount++;
            }

            if (trackingInfoObjectpropCount > 0)
            {
                odataReferral["trackingInfo"] = trackingInfoObject;
                odataReferralpropCount++;
            }

            if (odataReferraltype != null)
            {
                odataReferral["type"] = CSharpExpressionConverter.ConvertToken(odataReferraltype);
                odataReferralpropCount++;
            }

            if (odataReferralupdatedDateTime != null)
            {
                odataReferral["updatedDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferralupdatedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralmpnId != null)
            {
                odataReferral["mpnId"] = CSharpExpressionConverter.ConvertToken(odataReferralmpnId);
                odataReferralpropCount++;
            }

            if (odataReferralregistrations != null)
            {
                odataReferral["registrations"] = CSharpExpressionConverter.ConvertToken(odataReferralregistrations);
                odataReferralpropCount++;
            }

            if (odataReferralregistrationStatus != null)
            {
                odataReferral["registrationStatus"] = CSharpExpressionConverter.ConvertToken(odataReferralregistrationStatus);
                odataReferralpropCount++;
            }

            if (odataReferralcallToAction != null)
            {
                odataReferral["callToAction"] = CSharpExpressionConverter.ConvertToken(odataReferralcallToAction);
                odataReferralpropCount++;
            }

            if (odataReferralreferralSource != null)
            {
                odataReferral["referralSource"] = CSharpExpressionConverter.ConvertToken(odataReferralreferralSource);
                odataReferralpropCount++;
            }

            if (odataReferralquality != null)
            {
                odataReferral["quality"] = CSharpExpressionConverter.ConvertToken(odataReferralquality);
                odataReferralpropCount++;
            }

            if (odataReferralisSpam != null)
            {
                odataReferral["isSpam"] = CSharpExpressionConverter.ConvertToken(odataReferralisSpam);
                odataReferralpropCount++;
            }

            if (odataReferraldirection != null)
            {
                odataReferral["direction"] = CSharpExpressionConverter.ConvertToken(odataReferraldirection);
                odataReferralpropCount++;
            }

            if (odataReferraltags != null)
            {
                odataReferral["tags"] = CSharpExpressionConverter.ConvertToken(odataReferraltags);
                odataReferralpropCount++;
            }

            if (odataReferralacceptedDateTime != null)
            {
                odataReferral["acceptedDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferralacceptedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralclosedDateTime != null)
            {
                odataReferral["closedDateTime"] = CSharpExpressionConverter.ConvertToken(odataReferralclosedDateTime);
                odataReferralpropCount++;
            }

            if (odataReferralpropCount > 0)
            {
                callPayload.Body = odataReferral;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchReferralById(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem[]>> referral = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/referrals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(referral);
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem2[]>> referral = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/referrals/{0}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(referral);
            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem22[]>> referral = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/referrals/{0}//", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-type"] = Convert.ToString("application/json");
            if (mSCorrelationId != null)
                callPayload.Headers["MS-CorrelationId"] = CSharpExpressionConverter.ConvertO(mSCorrelationId);
            callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
            callPayload.Body = CSharpExpressionConverter.ConvertToken(referral);
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