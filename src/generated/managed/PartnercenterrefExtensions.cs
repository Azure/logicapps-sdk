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
        public IBodyWorkflowAction<GetAllReferralsResponse> GetAllReferrals([WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(count, nameof(count), required: false);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (count != null)
                    callPayload.Queries["$count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllReferralsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateReferral([WorkflowExpression] Func<string> referralcontext = null, [WorkflowExpression] Func<string> referralcampaignId = null, [WorkflowExpression] Func<bool> referralconsentconsentToContact = null, [WorkflowExpression] Func<bool> referralconsentconsentToToShareInfoWithOthers = null, [WorkflowExpression] Func<bool> referralconsentconsentToShareReferralWithMicrosoftSellers = null, [WorkflowExpression] Func<string> referralcreatedDateTime = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressaddressLine1 = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressaddressLine2 = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresscity = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresscountry = null, [WorkflowExpression] Func<string> referralcustomerProfileaddresspostalCode = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressregion = null, [WorkflowExpression] Func<string> referralcustomerProfileaddressstate = null, [WorkflowExpression] Func<JToken[]> referralcustomerProfileids = null, [WorkflowExpression] Func<string> referralcustomerProfilename = null, [WorkflowExpression] Func<string> referralcustomerProfilesize = null, [WorkflowExpression] Func<referralcustomerProfileteamInputItem[]> referralcustomerProfileteam = null, [WorkflowExpression] Func<string> referraldetailsclosingDateTime = null, [WorkflowExpression] Func<string> referraldetailscurrency = null, [WorkflowExpression] Func<string> referraldetailscustomerAction = null, [WorkflowExpression] Func<bool> referraldetailscustomerRequestedContact = null, [WorkflowExpression] Func<double> referraldetailsdealValue = null, [WorkflowExpression] Func<string> referraldetailsnotes = null, [WorkflowExpression] Func<referraldetailsrequirementsindustriesInputItem[]> referraldetailsrequirementsindustries = null, [WorkflowExpression] Func<referraldetailsrequirementsproductsInputItem[]> referraldetailsrequirementsproducts = null, [WorkflowExpression] Func<referraldetailsrequirementsservicesInputItem[]> referraldetailsrequirementsservices = null, [WorkflowExpression] Func<JToken[]> referraldetailsrequirementssolutions = null, [WorkflowExpression] Func<JToken[]> referraldetailsrequirementsoffers = null, [WorkflowExpression] Func<string> referraleTag = null, [WorkflowExpression] Func<string> referralengagementId = null, [WorkflowExpression] Func<string> referralexpirationDateTime = null, [WorkflowExpression] Func<string> referralexternalReferenceId = null, [WorkflowExpression] Func<bool> referralfavorite = null, [WorkflowExpression] Func<string> referralid = null, [WorkflowExpression] Func<referralinviteContextassistanceRequestCodeInput> referralinviteContextassistanceRequestCode = null, [WorkflowExpression] Func<string> referralinviteContextinvitedByorganizationId = null, [WorkflowExpression] Func<string> referralinviteContextinvitedByorganizationName = null, [WorkflowExpression] Func<string> referralinviteContextnotes = null, [WorkflowExpression] Func<string> referrallastModifiedVia = null, [WorkflowExpression] Func<string> referrallastRunId = null, [WorkflowExpression] Func<string> referrallinksrelatedReferralsmethod = null, [WorkflowExpression] Func<string> referrallinksrelatedReferralsuri = null, [WorkflowExpression] Func<string> referrallinksselfmethod = null, [WorkflowExpression] Func<string> referrallinksselfuri = null, [WorkflowExpression] Func<string> referralname = null, [WorkflowExpression] Func<string> referralorganizationId = null, [WorkflowExpression] Func<string> referralorganizationName = null, [WorkflowExpression] Func<string> referralqualification = null, [WorkflowExpression] Func<string> referralreferralProgram = null, [WorkflowExpression] Func<referralsalesStageInput> referralsalesStage = null, [WorkflowExpression] Func<string> referralstatus = null, [WorkflowExpression] Func<string> referralstatusReason = null, [WorkflowExpression] Func<string> referralsubstatus = null, [WorkflowExpression] Func<referraltargetInputItem[]> referraltarget = null, [WorkflowExpression] Func<referralteamInputItem[]> referralteam = null, [WorkflowExpression] Func<string> referraltrackingInfomicrosoftMsxId = null, [WorkflowExpression] Func<string> referraltype = null, [WorkflowExpression] Func<string> referralupdatedDateTime = null, [WorkflowExpression] Func<string> referralmpnId = null, [WorkflowExpression] Func<referralregistrationsInputItem[]> referralregistrations = null, [WorkflowExpression] Func<string> referralregistrationStatus = null, [WorkflowExpression] Func<string> referralcallToAction = null, [WorkflowExpression] Func<string> referralreferralSource = null, [WorkflowExpression] Func<string> referralquality = null, [WorkflowExpression] Func<bool> referralisSpam = null, [WorkflowExpression] Func<string> referraldirection = null, [WorkflowExpression] Func<string[]> referraltags = null, [WorkflowExpression] Func<string> referralacceptedDateTime = null, [WorkflowExpression] Func<string> referralclosedDateTime = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            SourceExpression.Validate(referralcontext, nameof(referralcontext), required: false);
            SourceExpression.Validate(referralcampaignId, nameof(referralcampaignId), required: false);
            SourceExpression.Validate(referralconsentconsentToContact, nameof(referralconsentconsentToContact), required: false);
            SourceExpression.Validate(referralconsentconsentToToShareInfoWithOthers, nameof(referralconsentconsentToToShareInfoWithOthers), required: false);
            SourceExpression.Validate(referralconsentconsentToShareReferralWithMicrosoftSellers, nameof(referralconsentconsentToShareReferralWithMicrosoftSellers), required: false);
            SourceExpression.Validate(referralcreatedDateTime, nameof(referralcreatedDateTime), required: false);
            SourceExpression.Validate(referralcustomerProfileaddressaddressLine1, nameof(referralcustomerProfileaddressaddressLine1), required: false);
            SourceExpression.Validate(referralcustomerProfileaddressaddressLine2, nameof(referralcustomerProfileaddressaddressLine2), required: false);
            SourceExpression.Validate(referralcustomerProfileaddresscity, nameof(referralcustomerProfileaddresscity), required: false);
            SourceExpression.Validate(referralcustomerProfileaddresscountry, nameof(referralcustomerProfileaddresscountry), required: false);
            SourceExpression.Validate(referralcustomerProfileaddresspostalCode, nameof(referralcustomerProfileaddresspostalCode), required: false);
            SourceExpression.Validate(referralcustomerProfileaddressregion, nameof(referralcustomerProfileaddressregion), required: false);
            SourceExpression.Validate(referralcustomerProfileaddressstate, nameof(referralcustomerProfileaddressstate), required: false);
            SourceExpression.Validate(referralcustomerProfileids, nameof(referralcustomerProfileids), required: false);
            SourceExpression.Validate(referralcustomerProfilename, nameof(referralcustomerProfilename), required: false);
            SourceExpression.Validate(referralcustomerProfilesize, nameof(referralcustomerProfilesize), required: false);
            SourceExpression.Validate(referralcustomerProfileteam, nameof(referralcustomerProfileteam), required: false);
            SourceExpression.Validate(referraldetailsclosingDateTime, nameof(referraldetailsclosingDateTime), required: false);
            SourceExpression.Validate(referraldetailscurrency, nameof(referraldetailscurrency), required: false);
            SourceExpression.Validate(referraldetailscustomerAction, nameof(referraldetailscustomerAction), required: false);
            SourceExpression.Validate(referraldetailscustomerRequestedContact, nameof(referraldetailscustomerRequestedContact), required: false);
            SourceExpression.Validate(referraldetailsdealValue, nameof(referraldetailsdealValue), required: false);
            SourceExpression.Validate(referraldetailsnotes, nameof(referraldetailsnotes), required: false);
            SourceExpression.Validate(referraldetailsrequirementsindustries, nameof(referraldetailsrequirementsindustries), required: false);
            SourceExpression.Validate(referraldetailsrequirementsproducts, nameof(referraldetailsrequirementsproducts), required: false);
            SourceExpression.Validate(referraldetailsrequirementsservices, nameof(referraldetailsrequirementsservices), required: false);
            SourceExpression.Validate(referraldetailsrequirementssolutions, nameof(referraldetailsrequirementssolutions), required: false);
            SourceExpression.Validate(referraldetailsrequirementsoffers, nameof(referraldetailsrequirementsoffers), required: false);
            SourceExpression.Validate(referraleTag, nameof(referraleTag), required: false);
            SourceExpression.Validate(referralengagementId, nameof(referralengagementId), required: false);
            SourceExpression.Validate(referralexpirationDateTime, nameof(referralexpirationDateTime), required: false);
            SourceExpression.Validate(referralexternalReferenceId, nameof(referralexternalReferenceId), required: false);
            SourceExpression.Validate(referralfavorite, nameof(referralfavorite), required: false);
            SourceExpression.Validate(referralid, nameof(referralid), required: false);
            SourceExpression.Validate(referralinviteContextassistanceRequestCode, nameof(referralinviteContextassistanceRequestCode), required: false);
            SourceExpression.Validate(referralinviteContextinvitedByorganizationId, nameof(referralinviteContextinvitedByorganizationId), required: false);
            SourceExpression.Validate(referralinviteContextinvitedByorganizationName, nameof(referralinviteContextinvitedByorganizationName), required: false);
            SourceExpression.Validate(referralinviteContextnotes, nameof(referralinviteContextnotes), required: false);
            SourceExpression.Validate(referrallastModifiedVia, nameof(referrallastModifiedVia), required: false);
            SourceExpression.Validate(referrallastRunId, nameof(referrallastRunId), required: false);
            SourceExpression.Validate(referrallinksrelatedReferralsmethod, nameof(referrallinksrelatedReferralsmethod), required: false);
            SourceExpression.Validate(referrallinksrelatedReferralsuri, nameof(referrallinksrelatedReferralsuri), required: false);
            SourceExpression.Validate(referrallinksselfmethod, nameof(referrallinksselfmethod), required: false);
            SourceExpression.Validate(referrallinksselfuri, nameof(referrallinksselfuri), required: false);
            SourceExpression.Validate(referralname, nameof(referralname), required: false);
            SourceExpression.Validate(referralorganizationId, nameof(referralorganizationId), required: false);
            SourceExpression.Validate(referralorganizationName, nameof(referralorganizationName), required: false);
            SourceExpression.Validate(referralqualification, nameof(referralqualification), required: false);
            SourceExpression.Validate(referralreferralProgram, nameof(referralreferralProgram), required: false);
            SourceExpression.Validate(referralsalesStage, nameof(referralsalesStage), required: false);
            SourceExpression.Validate(referralstatus, nameof(referralstatus), required: false);
            SourceExpression.Validate(referralstatusReason, nameof(referralstatusReason), required: false);
            SourceExpression.Validate(referralsubstatus, nameof(referralsubstatus), required: false);
            SourceExpression.Validate(referraltarget, nameof(referraltarget), required: false);
            SourceExpression.Validate(referralteam, nameof(referralteam), required: false);
            SourceExpression.Validate(referraltrackingInfomicrosoftMsxId, nameof(referraltrackingInfomicrosoftMsxId), required: false);
            SourceExpression.Validate(referraltype, nameof(referraltype), required: false);
            SourceExpression.Validate(referralupdatedDateTime, nameof(referralupdatedDateTime), required: false);
            SourceExpression.Validate(referralmpnId, nameof(referralmpnId), required: false);
            SourceExpression.Validate(referralregistrations, nameof(referralregistrations), required: false);
            SourceExpression.Validate(referralregistrationStatus, nameof(referralregistrationStatus), required: false);
            SourceExpression.Validate(referralcallToAction, nameof(referralcallToAction), required: false);
            SourceExpression.Validate(referralreferralSource, nameof(referralreferralSource), required: false);
            SourceExpression.Validate(referralquality, nameof(referralquality), required: false);
            SourceExpression.Validate(referralisSpam, nameof(referralisSpam), required: false);
            SourceExpression.Validate(referraldirection, nameof(referraldirection), required: false);
            SourceExpression.Validate(referraltags, nameof(referraltags), required: false);
            SourceExpression.Validate(referralacceptedDateTime, nameof(referralacceptedDateTime), required: false);
            SourceExpression.Validate(referralclosedDateTime, nameof(referralclosedDateTime), required: false);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                var referral = new JObject();
                var referralpropCount = 0;
                if (referralcontext != null)
                {
                    referral["@odata.context"] = SourceExpressionConverter.ConvertToken(referralcontext);
                    referralpropCount++;
                }

                if (referralcampaignId != null)
                {
                    referral["campaignId"] = SourceExpressionConverter.ConvertToken(referralcampaignId);
                    referralpropCount++;
                }

                var consentObject = new JObject();
                var consentObjectpropCount = 0;
                if (referralconsentconsentToContact != null)
                {
                    consentObject["consentToContact"] = SourceExpressionConverter.ConvertToken(referralconsentconsentToContact);
                    consentObjectpropCount++;
                }

                if (referralconsentconsentToToShareInfoWithOthers != null)
                {
                    consentObject["consentToToShareInfoWithOthers"] = SourceExpressionConverter.ConvertToken(referralconsentconsentToToShareInfoWithOthers);
                    consentObjectpropCount++;
                }

                if (referralconsentconsentToShareReferralWithMicrosoftSellers != null)
                {
                    consentObject["consentToShareReferralWithMicrosoftSellers"] = SourceExpressionConverter.ConvertToken(referralconsentconsentToShareReferralWithMicrosoftSellers);
                    consentObjectpropCount++;
                }

                if (consentObjectpropCount > 0)
                {
                    referral["consent"] = consentObject;
                    referralpropCount++;
                }

                if (referralcreatedDateTime != null)
                {
                    referral["createdDateTime"] = SourceExpressionConverter.ConvertToken(referralcreatedDateTime);
                    referralpropCount++;
                }

                var customerProfileObject = new JObject();
                var customerProfileObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (referralcustomerProfileaddressaddressLine1 != null)
                {
                    addressObject["addressLine1"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddresscity);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddresscountry);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddressregion != null)
                {
                    addressObject["region"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddressregion);
                    addressObjectpropCount++;
                }

                if (referralcustomerProfileaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileaddressstate);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    customerProfileObject["address"] = addressObject;
                    customerProfileObjectpropCount++;
                }

                if (referralcustomerProfileids != null)
                {
                    customerProfileObject["ids"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileids);
                    customerProfileObjectpropCount++;
                }

                if (referralcustomerProfilename != null)
                {
                    customerProfileObject["name"] = SourceExpressionConverter.ConvertToken(referralcustomerProfilename);
                    customerProfileObjectpropCount++;
                }

                if (referralcustomerProfilesize != null)
                {
                    customerProfileObject["size"] = SourceExpressionConverter.ConvertToken(referralcustomerProfilesize);
                    customerProfileObjectpropCount++;
                }

                if (referralcustomerProfileteam != null)
                {
                    customerProfileObject["team"] = SourceExpressionConverter.ConvertToken(referralcustomerProfileteam);
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
                    detailsObject["closingDateTime"] = SourceExpressionConverter.ConvertToken(referraldetailsclosingDateTime);
                    detailsObjectpropCount++;
                }

                if (referraldetailscurrency != null)
                {
                    detailsObject["currency"] = SourceExpressionConverter.ConvertToken(referraldetailscurrency);
                    detailsObjectpropCount++;
                }

                if (referraldetailscustomerAction != null)
                {
                    detailsObject["customerAction"] = SourceExpressionConverter.ConvertToken(referraldetailscustomerAction);
                    detailsObjectpropCount++;
                }

                if (referraldetailscustomerRequestedContact != null)
                {
                    detailsObject["customerRequestedContact"] = SourceExpressionConverter.ConvertToken(referraldetailscustomerRequestedContact);
                    detailsObjectpropCount++;
                }

                if (referraldetailsdealValue != null)
                {
                    detailsObject["dealValue"] = SourceExpressionConverter.ConvertToken(referraldetailsdealValue);
                    detailsObjectpropCount++;
                }

                if (referraldetailsnotes != null)
                {
                    detailsObject["notes"] = SourceExpressionConverter.ConvertToken(referraldetailsnotes);
                    detailsObjectpropCount++;
                }

                var requirementsObject = new JObject();
                var requirementsObjectpropCount = 0;
                if (referraldetailsrequirementsindustries != null)
                {
                    requirementsObject["industries"] = SourceExpressionConverter.ConvertToken(referraldetailsrequirementsindustries);
                    requirementsObjectpropCount++;
                }

                if (referraldetailsrequirementsproducts != null)
                {
                    requirementsObject["products"] = SourceExpressionConverter.ConvertToken(referraldetailsrequirementsproducts);
                    requirementsObjectpropCount++;
                }

                if (referraldetailsrequirementsservices != null)
                {
                    requirementsObject["services"] = SourceExpressionConverter.ConvertToken(referraldetailsrequirementsservices);
                    requirementsObjectpropCount++;
                }

                if (referraldetailsrequirementssolutions != null)
                {
                    requirementsObject["solutions"] = SourceExpressionConverter.ConvertToken(referraldetailsrequirementssolutions);
                    requirementsObjectpropCount++;
                }

                if (referraldetailsrequirementsoffers != null)
                {
                    requirementsObject["offers"] = SourceExpressionConverter.ConvertToken(referraldetailsrequirementsoffers);
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
                    referral["eTag"] = SourceExpressionConverter.ConvertToken(referraleTag);
                    referralpropCount++;
                }

                if (referralengagementId != null)
                {
                    referral["engagementId"] = SourceExpressionConverter.ConvertToken(referralengagementId);
                    referralpropCount++;
                }

                if (referralexpirationDateTime != null)
                {
                    referral["expirationDateTime"] = SourceExpressionConverter.ConvertToken(referralexpirationDateTime);
                    referralpropCount++;
                }

                if (referralexternalReferenceId != null)
                {
                    referral["externalReferenceId"] = SourceExpressionConverter.ConvertToken(referralexternalReferenceId);
                    referralpropCount++;
                }

                if (referralfavorite != null)
                {
                    referral["favorite"] = SourceExpressionConverter.ConvertToken(referralfavorite);
                    referralpropCount++;
                }

                if (referralid != null)
                {
                    referral["id"] = SourceExpressionConverter.ConvertToken(referralid);
                    referralpropCount++;
                }

                var inviteContextObject = new JObject();
                var inviteContextObjectpropCount = 0;
                if (referralinviteContextassistanceRequestCode != null)
                {
                    inviteContextObject["assistanceRequestCode"] = SourceExpressionConverter.Convert(referralinviteContextassistanceRequestCode);
                    inviteContextObjectpropCount++;
                }

                var invitedByObject = new JObject();
                var invitedByObjectpropCount = 0;
                if (referralinviteContextinvitedByorganizationId != null)
                {
                    invitedByObject["organizationId"] = SourceExpressionConverter.ConvertToken(referralinviteContextinvitedByorganizationId);
                    invitedByObjectpropCount++;
                }

                if (referralinviteContextinvitedByorganizationName != null)
                {
                    invitedByObject["organizationName"] = SourceExpressionConverter.ConvertToken(referralinviteContextinvitedByorganizationName);
                    invitedByObjectpropCount++;
                }

                if (invitedByObjectpropCount > 0)
                {
                    inviteContextObject["invitedBy"] = invitedByObject;
                    inviteContextObjectpropCount++;
                }

                if (referralinviteContextnotes != null)
                {
                    inviteContextObject["notes"] = SourceExpressionConverter.ConvertToken(referralinviteContextnotes);
                    inviteContextObjectpropCount++;
                }

                if (inviteContextObjectpropCount > 0)
                {
                    referral["inviteContext"] = inviteContextObject;
                    referralpropCount++;
                }

                if (referrallastModifiedVia != null)
                {
                    referral["lastModifiedVia"] = SourceExpressionConverter.ConvertToken(referrallastModifiedVia);
                    referralpropCount++;
                }

                if (referrallastRunId != null)
                {
                    referral["lastRunId"] = SourceExpressionConverter.ConvertToken(referrallastRunId);
                    referralpropCount++;
                }

                var linksObject = new JObject();
                var linksObjectpropCount = 0;
                var relatedReferralsObject = new JObject();
                var relatedReferralsObjectpropCount = 0;
                if (referrallinksrelatedReferralsmethod != null)
                {
                    relatedReferralsObject["method"] = SourceExpressionConverter.ConvertToken(referrallinksrelatedReferralsmethod);
                    relatedReferralsObjectpropCount++;
                }

                if (referrallinksrelatedReferralsuri != null)
                {
                    relatedReferralsObject["uri"] = SourceExpressionConverter.ConvertToken(referrallinksrelatedReferralsuri);
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
                    selfObject["method"] = SourceExpressionConverter.ConvertToken(referrallinksselfmethod);
                    selfObjectpropCount++;
                }

                if (referrallinksselfuri != null)
                {
                    selfObject["uri"] = SourceExpressionConverter.ConvertToken(referrallinksselfuri);
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
                    referral["name"] = SourceExpressionConverter.ConvertToken(referralname);
                    referralpropCount++;
                }

                if (referralorganizationId != null)
                {
                    referral["organizationId"] = SourceExpressionConverter.ConvertToken(referralorganizationId);
                    referralpropCount++;
                }

                if (referralorganizationName != null)
                {
                    referral["organizationName"] = SourceExpressionConverter.ConvertToken(referralorganizationName);
                    referralpropCount++;
                }

                if (referralqualification != null)
                {
                    referral["qualification"] = SourceExpressionConverter.ConvertToken(referralqualification);
                    referralpropCount++;
                }

                if (referralreferralProgram != null)
                {
                    referral["referralProgram"] = SourceExpressionConverter.ConvertToken(referralreferralProgram);
                    referralpropCount++;
                }

                if (referralsalesStage != null)
                {
                    referral["salesStage"] = SourceExpressionConverter.Convert(referralsalesStage);
                    referralpropCount++;
                }

                if (referralstatus != null)
                {
                    referral["status"] = SourceExpressionConverter.ConvertToken(referralstatus);
                    referralpropCount++;
                }

                if (referralstatusReason != null)
                {
                    referral["statusReason"] = SourceExpressionConverter.ConvertToken(referralstatusReason);
                    referralpropCount++;
                }

                if (referralsubstatus != null)
                {
                    referral["substatus"] = SourceExpressionConverter.ConvertToken(referralsubstatus);
                    referralpropCount++;
                }

                if (referraltarget != null)
                {
                    referral["target"] = SourceExpressionConverter.ConvertToken(referraltarget);
                    referralpropCount++;
                }

                if (referralteam != null)
                {
                    referral["team"] = SourceExpressionConverter.ConvertToken(referralteam);
                    referralpropCount++;
                }

                var trackingInfoObject = new JObject();
                var trackingInfoObjectpropCount = 0;
                if (referraltrackingInfomicrosoftMsxId != null)
                {
                    trackingInfoObject["microsoftMsxId"] = SourceExpressionConverter.ConvertToken(referraltrackingInfomicrosoftMsxId);
                    trackingInfoObjectpropCount++;
                }

                if (trackingInfoObjectpropCount > 0)
                {
                    referral["trackingInfo"] = trackingInfoObject;
                    referralpropCount++;
                }

                if (referraltype != null)
                {
                    referral["type"] = SourceExpressionConverter.ConvertToken(referraltype);
                    referralpropCount++;
                }

                if (referralupdatedDateTime != null)
                {
                    referral["updatedDateTime"] = SourceExpressionConverter.ConvertToken(referralupdatedDateTime);
                    referralpropCount++;
                }

                if (referralmpnId != null)
                {
                    referral["mpnId"] = SourceExpressionConverter.ConvertToken(referralmpnId);
                    referralpropCount++;
                }

                if (referralregistrations != null)
                {
                    referral["registrations"] = SourceExpressionConverter.ConvertToken(referralregistrations);
                    referralpropCount++;
                }

                if (referralregistrationStatus != null)
                {
                    referral["registrationStatus"] = SourceExpressionConverter.ConvertToken(referralregistrationStatus);
                    referralpropCount++;
                }

                if (referralcallToAction != null)
                {
                    referral["callToAction"] = SourceExpressionConverter.ConvertToken(referralcallToAction);
                    referralpropCount++;
                }

                if (referralreferralSource != null)
                {
                    referral["referralSource"] = SourceExpressionConverter.ConvertToken(referralreferralSource);
                    referralpropCount++;
                }

                if (referralquality != null)
                {
                    referral["quality"] = SourceExpressionConverter.ConvertToken(referralquality);
                    referralpropCount++;
                }

                if (referralisSpam != null)
                {
                    referral["isSpam"] = SourceExpressionConverter.ConvertToken(referralisSpam);
                    referralpropCount++;
                }

                if (referraldirection != null)
                {
                    referral["direction"] = SourceExpressionConverter.ConvertToken(referraldirection);
                    referralpropCount++;
                }

                if (referraltags != null)
                {
                    referral["tags"] = SourceExpressionConverter.ConvertToken(referraltags);
                    referralpropCount++;
                }

                if (referralacceptedDateTime != null)
                {
                    referral["acceptedDateTime"] = SourceExpressionConverter.ConvertToken(referralacceptedDateTime);
                    referralpropCount++;
                }

                if (referralclosedDateTime != null)
                {
                    referral["closedDateTime"] = SourceExpressionConverter.ConvertToken(referralclosedDateTime);
                    referralpropCount++;
                }

                if (referralpropCount > 0)
                {
                    callPayload.Body = referral;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> GetReferralById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/referrals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> UpdateReferralById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> ifMatch, [WorkflowExpression] Func<string> odataReferralcontext = null, [WorkflowExpression] Func<string> odataReferralcampaignId = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToContact = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToToShareInfoWithOthers = null, [WorkflowExpression] Func<bool> odataReferralconsentconsentToShareReferralWithMicrosoftSellers = null, [WorkflowExpression] Func<string> odataReferralcreatedDateTime = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressaddressLine1 = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressaddressLine2 = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresscity = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresscountry = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddresspostalCode = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressregion = null, [WorkflowExpression] Func<string> odataReferralcustomerProfileaddressstate = null, [WorkflowExpression] Func<JToken[]> odataReferralcustomerProfileids = null, [WorkflowExpression] Func<string> odataReferralcustomerProfilename = null, [WorkflowExpression] Func<string> odataReferralcustomerProfilesize = null, [WorkflowExpression] Func<odataReferralcustomerProfileteamInputItem[]> odataReferralcustomerProfileteam = null, [WorkflowExpression] Func<string> odataReferraldetailsclosingDateTime = null, [WorkflowExpression] Func<string> odataReferraldetailscurrency = null, [WorkflowExpression] Func<string> odataReferraldetailscustomerAction = null, [WorkflowExpression] Func<bool> odataReferraldetailscustomerRequestedContact = null, [WorkflowExpression] Func<double> odataReferraldetailsdealValue = null, [WorkflowExpression] Func<string> odataReferraldetailsnotes = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsindustriesInputItem[]> odataReferraldetailsrequirementsindustries = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsproductsInputItem[]> odataReferraldetailsrequirementsproducts = null, [WorkflowExpression] Func<odataReferraldetailsrequirementsservicesInputItem[]> odataReferraldetailsrequirementsservices = null, [WorkflowExpression] Func<JToken[]> odataReferraldetailsrequirementssolutions = null, [WorkflowExpression] Func<JToken[]> odataReferraldetailsrequirementsoffers = null, [WorkflowExpression] Func<string> odataReferraleTag = null, [WorkflowExpression] Func<string> odataReferralengagementId = null, [WorkflowExpression] Func<string> odataReferralexpirationDateTime = null, [WorkflowExpression] Func<string> odataReferralexternalReferenceId = null, [WorkflowExpression] Func<bool> odataReferralfavorite = null, [WorkflowExpression] Func<string> odataReferralid = null, [WorkflowExpression] Func<odataReferralinviteContextassistanceRequestCodeInput> odataReferralinviteContextassistanceRequestCode = null, [WorkflowExpression] Func<string> odataReferralinviteContextinvitedByorganizationId = null, [WorkflowExpression] Func<string> odataReferralinviteContextinvitedByorganizationName = null, [WorkflowExpression] Func<string> odataReferralinviteContextnotes = null, [WorkflowExpression] Func<string> odataReferrallastModifiedVia = null, [WorkflowExpression] Func<string> odataReferrallastRunId = null, [WorkflowExpression] Func<string> odataReferrallinksrelatedReferralsmethod = null, [WorkflowExpression] Func<string> odataReferrallinksrelatedReferralsuri = null, [WorkflowExpression] Func<string> odataReferrallinksselfmethod = null, [WorkflowExpression] Func<string> odataReferrallinksselfuri = null, [WorkflowExpression] Func<string> odataReferralname = null, [WorkflowExpression] Func<string> odataReferralorganizationId = null, [WorkflowExpression] Func<string> odataReferralorganizationName = null, [WorkflowExpression] Func<string> odataReferralqualification = null, [WorkflowExpression] Func<string> odataReferralreferralProgram = null, [WorkflowExpression] Func<odataReferralsalesStageInput> odataReferralsalesStage = null, [WorkflowExpression] Func<string> odataReferralstatus = null, [WorkflowExpression] Func<string> odataReferralstatusReason = null, [WorkflowExpression] Func<string> odataReferralsubstatus = null, [WorkflowExpression] Func<odataReferraltargetInputItem[]> odataReferraltarget = null, [WorkflowExpression] Func<odataReferralteamInputItem[]> odataReferralteam = null, [WorkflowExpression] Func<string> odataReferraltrackingInfomicrosoftMsxId = null, [WorkflowExpression] Func<string> odataReferraltype = null, [WorkflowExpression] Func<string> odataReferralupdatedDateTime = null, [WorkflowExpression] Func<string> odataReferralmpnId = null, [WorkflowExpression] Func<odataReferralregistrationsInputItem[]> odataReferralregistrations = null, [WorkflowExpression] Func<string> odataReferralregistrationStatus = null, [WorkflowExpression] Func<string> odataReferralcallToAction = null, [WorkflowExpression] Func<string> odataReferralreferralSource = null, [WorkflowExpression] Func<string> odataReferralquality = null, [WorkflowExpression] Func<bool> odataReferralisSpam = null, [WorkflowExpression] Func<string> odataReferraldirection = null, [WorkflowExpression] Func<string[]> odataReferraltags = null, [WorkflowExpression] Func<string> odataReferralacceptedDateTime = null, [WorkflowExpression] Func<string> odataReferralclosedDateTime = null, [WorkflowExpression] Func<string> mSCorrelationId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: true);
            SourceExpression.Validate(odataReferralcontext, nameof(odataReferralcontext), required: false);
            SourceExpression.Validate(odataReferralcampaignId, nameof(odataReferralcampaignId), required: false);
            SourceExpression.Validate(odataReferralconsentconsentToContact, nameof(odataReferralconsentconsentToContact), required: false);
            SourceExpression.Validate(odataReferralconsentconsentToToShareInfoWithOthers, nameof(odataReferralconsentconsentToToShareInfoWithOthers), required: false);
            SourceExpression.Validate(odataReferralconsentconsentToShareReferralWithMicrosoftSellers, nameof(odataReferralconsentconsentToShareReferralWithMicrosoftSellers), required: false);
            SourceExpression.Validate(odataReferralcreatedDateTime, nameof(odataReferralcreatedDateTime), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddressaddressLine1, nameof(odataReferralcustomerProfileaddressaddressLine1), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddressaddressLine2, nameof(odataReferralcustomerProfileaddressaddressLine2), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddresscity, nameof(odataReferralcustomerProfileaddresscity), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddresscountry, nameof(odataReferralcustomerProfileaddresscountry), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddresspostalCode, nameof(odataReferralcustomerProfileaddresspostalCode), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddressregion, nameof(odataReferralcustomerProfileaddressregion), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileaddressstate, nameof(odataReferralcustomerProfileaddressstate), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileids, nameof(odataReferralcustomerProfileids), required: false);
            SourceExpression.Validate(odataReferralcustomerProfilename, nameof(odataReferralcustomerProfilename), required: false);
            SourceExpression.Validate(odataReferralcustomerProfilesize, nameof(odataReferralcustomerProfilesize), required: false);
            SourceExpression.Validate(odataReferralcustomerProfileteam, nameof(odataReferralcustomerProfileteam), required: false);
            SourceExpression.Validate(odataReferraldetailsclosingDateTime, nameof(odataReferraldetailsclosingDateTime), required: false);
            SourceExpression.Validate(odataReferraldetailscurrency, nameof(odataReferraldetailscurrency), required: false);
            SourceExpression.Validate(odataReferraldetailscustomerAction, nameof(odataReferraldetailscustomerAction), required: false);
            SourceExpression.Validate(odataReferraldetailscustomerRequestedContact, nameof(odataReferraldetailscustomerRequestedContact), required: false);
            SourceExpression.Validate(odataReferraldetailsdealValue, nameof(odataReferraldetailsdealValue), required: false);
            SourceExpression.Validate(odataReferraldetailsnotes, nameof(odataReferraldetailsnotes), required: false);
            SourceExpression.Validate(odataReferraldetailsrequirementsindustries, nameof(odataReferraldetailsrequirementsindustries), required: false);
            SourceExpression.Validate(odataReferraldetailsrequirementsproducts, nameof(odataReferraldetailsrequirementsproducts), required: false);
            SourceExpression.Validate(odataReferraldetailsrequirementsservices, nameof(odataReferraldetailsrequirementsservices), required: false);
            SourceExpression.Validate(odataReferraldetailsrequirementssolutions, nameof(odataReferraldetailsrequirementssolutions), required: false);
            SourceExpression.Validate(odataReferraldetailsrequirementsoffers, nameof(odataReferraldetailsrequirementsoffers), required: false);
            SourceExpression.Validate(odataReferraleTag, nameof(odataReferraleTag), required: false);
            SourceExpression.Validate(odataReferralengagementId, nameof(odataReferralengagementId), required: false);
            SourceExpression.Validate(odataReferralexpirationDateTime, nameof(odataReferralexpirationDateTime), required: false);
            SourceExpression.Validate(odataReferralexternalReferenceId, nameof(odataReferralexternalReferenceId), required: false);
            SourceExpression.Validate(odataReferralfavorite, nameof(odataReferralfavorite), required: false);
            SourceExpression.Validate(odataReferralid, nameof(odataReferralid), required: false);
            SourceExpression.Validate(odataReferralinviteContextassistanceRequestCode, nameof(odataReferralinviteContextassistanceRequestCode), required: false);
            SourceExpression.Validate(odataReferralinviteContextinvitedByorganizationId, nameof(odataReferralinviteContextinvitedByorganizationId), required: false);
            SourceExpression.Validate(odataReferralinviteContextinvitedByorganizationName, nameof(odataReferralinviteContextinvitedByorganizationName), required: false);
            SourceExpression.Validate(odataReferralinviteContextnotes, nameof(odataReferralinviteContextnotes), required: false);
            SourceExpression.Validate(odataReferrallastModifiedVia, nameof(odataReferrallastModifiedVia), required: false);
            SourceExpression.Validate(odataReferrallastRunId, nameof(odataReferrallastRunId), required: false);
            SourceExpression.Validate(odataReferrallinksrelatedReferralsmethod, nameof(odataReferrallinksrelatedReferralsmethod), required: false);
            SourceExpression.Validate(odataReferrallinksrelatedReferralsuri, nameof(odataReferrallinksrelatedReferralsuri), required: false);
            SourceExpression.Validate(odataReferrallinksselfmethod, nameof(odataReferrallinksselfmethod), required: false);
            SourceExpression.Validate(odataReferrallinksselfuri, nameof(odataReferrallinksselfuri), required: false);
            SourceExpression.Validate(odataReferralname, nameof(odataReferralname), required: false);
            SourceExpression.Validate(odataReferralorganizationId, nameof(odataReferralorganizationId), required: false);
            SourceExpression.Validate(odataReferralorganizationName, nameof(odataReferralorganizationName), required: false);
            SourceExpression.Validate(odataReferralqualification, nameof(odataReferralqualification), required: false);
            SourceExpression.Validate(odataReferralreferralProgram, nameof(odataReferralreferralProgram), required: false);
            SourceExpression.Validate(odataReferralsalesStage, nameof(odataReferralsalesStage), required: false);
            SourceExpression.Validate(odataReferralstatus, nameof(odataReferralstatus), required: false);
            SourceExpression.Validate(odataReferralstatusReason, nameof(odataReferralstatusReason), required: false);
            SourceExpression.Validate(odataReferralsubstatus, nameof(odataReferralsubstatus), required: false);
            SourceExpression.Validate(odataReferraltarget, nameof(odataReferraltarget), required: false);
            SourceExpression.Validate(odataReferralteam, nameof(odataReferralteam), required: false);
            SourceExpression.Validate(odataReferraltrackingInfomicrosoftMsxId, nameof(odataReferraltrackingInfomicrosoftMsxId), required: false);
            SourceExpression.Validate(odataReferraltype, nameof(odataReferraltype), required: false);
            SourceExpression.Validate(odataReferralupdatedDateTime, nameof(odataReferralupdatedDateTime), required: false);
            SourceExpression.Validate(odataReferralmpnId, nameof(odataReferralmpnId), required: false);
            SourceExpression.Validate(odataReferralregistrations, nameof(odataReferralregistrations), required: false);
            SourceExpression.Validate(odataReferralregistrationStatus, nameof(odataReferralregistrationStatus), required: false);
            SourceExpression.Validate(odataReferralcallToAction, nameof(odataReferralcallToAction), required: false);
            SourceExpression.Validate(odataReferralreferralSource, nameof(odataReferralreferralSource), required: false);
            SourceExpression.Validate(odataReferralquality, nameof(odataReferralquality), required: false);
            SourceExpression.Validate(odataReferralisSpam, nameof(odataReferralisSpam), required: false);
            SourceExpression.Validate(odataReferraldirection, nameof(odataReferraldirection), required: false);
            SourceExpression.Validate(odataReferraltags, nameof(odataReferraltags), required: false);
            SourceExpression.Validate(odataReferralacceptedDateTime, nameof(odataReferralacceptedDateTime), required: false);
            SourceExpression.Validate(odataReferralclosedDateTime, nameof(odataReferralclosedDateTime), required: false);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/referrals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["if-match"] = SourceExpressionConverter.ConvertO(ifMatch);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                var odataReferral = new JObject();
                var odataReferralpropCount = 0;
                if (odataReferralcontext != null)
                {
                    odataReferral["@odata.context"] = SourceExpressionConverter.ConvertToken(odataReferralcontext);
                    odataReferralpropCount++;
                }

                if (odataReferralcampaignId != null)
                {
                    odataReferral["campaignId"] = SourceExpressionConverter.ConvertToken(odataReferralcampaignId);
                    odataReferralpropCount++;
                }

                var consentObject = new JObject();
                var consentObjectpropCount = 0;
                if (odataReferralconsentconsentToContact != null)
                {
                    consentObject["consentToContact"] = SourceExpressionConverter.ConvertToken(odataReferralconsentconsentToContact);
                    consentObjectpropCount++;
                }

                if (odataReferralconsentconsentToToShareInfoWithOthers != null)
                {
                    consentObject["consentToToShareInfoWithOthers"] = SourceExpressionConverter.ConvertToken(odataReferralconsentconsentToToShareInfoWithOthers);
                    consentObjectpropCount++;
                }

                if (odataReferralconsentconsentToShareReferralWithMicrosoftSellers != null)
                {
                    consentObject["consentToShareReferralWithMicrosoftSellers"] = SourceExpressionConverter.ConvertToken(odataReferralconsentconsentToShareReferralWithMicrosoftSellers);
                    consentObjectpropCount++;
                }

                if (consentObjectpropCount > 0)
                {
                    odataReferral["consent"] = consentObject;
                    odataReferralpropCount++;
                }

                if (odataReferralcreatedDateTime != null)
                {
                    odataReferral["createdDateTime"] = SourceExpressionConverter.ConvertToken(odataReferralcreatedDateTime);
                    odataReferralpropCount++;
                }

                var customerProfileObject = new JObject();
                var customerProfileObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (odataReferralcustomerProfileaddressaddressLine1 != null)
                {
                    addressObject["addressLine1"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresscity);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresscountry);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddressregion != null)
                {
                    addressObject["region"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressregion);
                    addressObjectpropCount++;
                }

                if (odataReferralcustomerProfileaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileaddressstate);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    customerProfileObject["address"] = addressObject;
                    customerProfileObjectpropCount++;
                }

                if (odataReferralcustomerProfileids != null)
                {
                    customerProfileObject["ids"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileids);
                    customerProfileObjectpropCount++;
                }

                if (odataReferralcustomerProfilename != null)
                {
                    customerProfileObject["name"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfilename);
                    customerProfileObjectpropCount++;
                }

                if (odataReferralcustomerProfilesize != null)
                {
                    customerProfileObject["size"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfilesize);
                    customerProfileObjectpropCount++;
                }

                if (odataReferralcustomerProfileteam != null)
                {
                    customerProfileObject["team"] = SourceExpressionConverter.ConvertToken(odataReferralcustomerProfileteam);
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
                    detailsObject["closingDateTime"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsclosingDateTime);
                    detailsObjectpropCount++;
                }

                if (odataReferraldetailscurrency != null)
                {
                    detailsObject["currency"] = SourceExpressionConverter.ConvertToken(odataReferraldetailscurrency);
                    detailsObjectpropCount++;
                }

                if (odataReferraldetailscustomerAction != null)
                {
                    detailsObject["customerAction"] = SourceExpressionConverter.ConvertToken(odataReferraldetailscustomerAction);
                    detailsObjectpropCount++;
                }

                if (odataReferraldetailscustomerRequestedContact != null)
                {
                    detailsObject["customerRequestedContact"] = SourceExpressionConverter.ConvertToken(odataReferraldetailscustomerRequestedContact);
                    detailsObjectpropCount++;
                }

                if (odataReferraldetailsdealValue != null)
                {
                    detailsObject["dealValue"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsdealValue);
                    detailsObjectpropCount++;
                }

                if (odataReferraldetailsnotes != null)
                {
                    detailsObject["notes"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsnotes);
                    detailsObjectpropCount++;
                }

                var requirementsObject = new JObject();
                var requirementsObjectpropCount = 0;
                if (odataReferraldetailsrequirementsindustries != null)
                {
                    requirementsObject["industries"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsrequirementsindustries);
                    requirementsObjectpropCount++;
                }

                if (odataReferraldetailsrequirementsproducts != null)
                {
                    requirementsObject["products"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsrequirementsproducts);
                    requirementsObjectpropCount++;
                }

                if (odataReferraldetailsrequirementsservices != null)
                {
                    requirementsObject["services"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsrequirementsservices);
                    requirementsObjectpropCount++;
                }

                if (odataReferraldetailsrequirementssolutions != null)
                {
                    requirementsObject["solutions"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsrequirementssolutions);
                    requirementsObjectpropCount++;
                }

                if (odataReferraldetailsrequirementsoffers != null)
                {
                    requirementsObject["offers"] = SourceExpressionConverter.ConvertToken(odataReferraldetailsrequirementsoffers);
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
                    odataReferral["eTag"] = SourceExpressionConverter.ConvertToken(odataReferraleTag);
                    odataReferralpropCount++;
                }

                if (odataReferralengagementId != null)
                {
                    odataReferral["engagementId"] = SourceExpressionConverter.ConvertToken(odataReferralengagementId);
                    odataReferralpropCount++;
                }

                if (odataReferralexpirationDateTime != null)
                {
                    odataReferral["expirationDateTime"] = SourceExpressionConverter.ConvertToken(odataReferralexpirationDateTime);
                    odataReferralpropCount++;
                }

                if (odataReferralexternalReferenceId != null)
                {
                    odataReferral["externalReferenceId"] = SourceExpressionConverter.ConvertToken(odataReferralexternalReferenceId);
                    odataReferralpropCount++;
                }

                if (odataReferralfavorite != null)
                {
                    odataReferral["favorite"] = SourceExpressionConverter.ConvertToken(odataReferralfavorite);
                    odataReferralpropCount++;
                }

                if (odataReferralid != null)
                {
                    odataReferral["id"] = SourceExpressionConverter.ConvertToken(odataReferralid);
                    odataReferralpropCount++;
                }

                var inviteContextObject = new JObject();
                var inviteContextObjectpropCount = 0;
                if (odataReferralinviteContextassistanceRequestCode != null)
                {
                    inviteContextObject["assistanceRequestCode"] = SourceExpressionConverter.Convert(odataReferralinviteContextassistanceRequestCode);
                    inviteContextObjectpropCount++;
                }

                var invitedByObject = new JObject();
                var invitedByObjectpropCount = 0;
                if (odataReferralinviteContextinvitedByorganizationId != null)
                {
                    invitedByObject["organizationId"] = SourceExpressionConverter.ConvertToken(odataReferralinviteContextinvitedByorganizationId);
                    invitedByObjectpropCount++;
                }

                if (odataReferralinviteContextinvitedByorganizationName != null)
                {
                    invitedByObject["organizationName"] = SourceExpressionConverter.ConvertToken(odataReferralinviteContextinvitedByorganizationName);
                    invitedByObjectpropCount++;
                }

                if (invitedByObjectpropCount > 0)
                {
                    inviteContextObject["invitedBy"] = invitedByObject;
                    inviteContextObjectpropCount++;
                }

                if (odataReferralinviteContextnotes != null)
                {
                    inviteContextObject["notes"] = SourceExpressionConverter.ConvertToken(odataReferralinviteContextnotes);
                    inviteContextObjectpropCount++;
                }

                if (inviteContextObjectpropCount > 0)
                {
                    odataReferral["inviteContext"] = inviteContextObject;
                    odataReferralpropCount++;
                }

                if (odataReferrallastModifiedVia != null)
                {
                    odataReferral["lastModifiedVia"] = SourceExpressionConverter.ConvertToken(odataReferrallastModifiedVia);
                    odataReferralpropCount++;
                }

                if (odataReferrallastRunId != null)
                {
                    odataReferral["lastRunId"] = SourceExpressionConverter.ConvertToken(odataReferrallastRunId);
                    odataReferralpropCount++;
                }

                var linksObject = new JObject();
                var linksObjectpropCount = 0;
                var relatedReferralsObject = new JObject();
                var relatedReferralsObjectpropCount = 0;
                if (odataReferrallinksrelatedReferralsmethod != null)
                {
                    relatedReferralsObject["method"] = SourceExpressionConverter.ConvertToken(odataReferrallinksrelatedReferralsmethod);
                    relatedReferralsObjectpropCount++;
                }

                if (odataReferrallinksrelatedReferralsuri != null)
                {
                    relatedReferralsObject["uri"] = SourceExpressionConverter.ConvertToken(odataReferrallinksrelatedReferralsuri);
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
                    selfObject["method"] = SourceExpressionConverter.ConvertToken(odataReferrallinksselfmethod);
                    selfObjectpropCount++;
                }

                if (odataReferrallinksselfuri != null)
                {
                    selfObject["uri"] = SourceExpressionConverter.ConvertToken(odataReferrallinksselfuri);
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
                    odataReferral["name"] = SourceExpressionConverter.ConvertToken(odataReferralname);
                    odataReferralpropCount++;
                }

                if (odataReferralorganizationId != null)
                {
                    odataReferral["organizationId"] = SourceExpressionConverter.ConvertToken(odataReferralorganizationId);
                    odataReferralpropCount++;
                }

                if (odataReferralorganizationName != null)
                {
                    odataReferral["organizationName"] = SourceExpressionConverter.ConvertToken(odataReferralorganizationName);
                    odataReferralpropCount++;
                }

                if (odataReferralqualification != null)
                {
                    odataReferral["qualification"] = SourceExpressionConverter.ConvertToken(odataReferralqualification);
                    odataReferralpropCount++;
                }

                if (odataReferralreferralProgram != null)
                {
                    odataReferral["referralProgram"] = SourceExpressionConverter.ConvertToken(odataReferralreferralProgram);
                    odataReferralpropCount++;
                }

                if (odataReferralsalesStage != null)
                {
                    odataReferral["salesStage"] = SourceExpressionConverter.Convert(odataReferralsalesStage);
                    odataReferralpropCount++;
                }

                if (odataReferralstatus != null)
                {
                    odataReferral["status"] = SourceExpressionConverter.ConvertToken(odataReferralstatus);
                    odataReferralpropCount++;
                }

                if (odataReferralstatusReason != null)
                {
                    odataReferral["statusReason"] = SourceExpressionConverter.ConvertToken(odataReferralstatusReason);
                    odataReferralpropCount++;
                }

                if (odataReferralsubstatus != null)
                {
                    odataReferral["substatus"] = SourceExpressionConverter.ConvertToken(odataReferralsubstatus);
                    odataReferralpropCount++;
                }

                if (odataReferraltarget != null)
                {
                    odataReferral["target"] = SourceExpressionConverter.ConvertToken(odataReferraltarget);
                    odataReferralpropCount++;
                }

                if (odataReferralteam != null)
                {
                    odataReferral["team"] = SourceExpressionConverter.ConvertToken(odataReferralteam);
                    odataReferralpropCount++;
                }

                var trackingInfoObject = new JObject();
                var trackingInfoObjectpropCount = 0;
                if (odataReferraltrackingInfomicrosoftMsxId != null)
                {
                    trackingInfoObject["microsoftMsxId"] = SourceExpressionConverter.ConvertToken(odataReferraltrackingInfomicrosoftMsxId);
                    trackingInfoObjectpropCount++;
                }

                if (trackingInfoObjectpropCount > 0)
                {
                    odataReferral["trackingInfo"] = trackingInfoObject;
                    odataReferralpropCount++;
                }

                if (odataReferraltype != null)
                {
                    odataReferral["type"] = SourceExpressionConverter.ConvertToken(odataReferraltype);
                    odataReferralpropCount++;
                }

                if (odataReferralupdatedDateTime != null)
                {
                    odataReferral["updatedDateTime"] = SourceExpressionConverter.ConvertToken(odataReferralupdatedDateTime);
                    odataReferralpropCount++;
                }

                if (odataReferralmpnId != null)
                {
                    odataReferral["mpnId"] = SourceExpressionConverter.ConvertToken(odataReferralmpnId);
                    odataReferralpropCount++;
                }

                if (odataReferralregistrations != null)
                {
                    odataReferral["registrations"] = SourceExpressionConverter.ConvertToken(odataReferralregistrations);
                    odataReferralpropCount++;
                }

                if (odataReferralregistrationStatus != null)
                {
                    odataReferral["registrationStatus"] = SourceExpressionConverter.ConvertToken(odataReferralregistrationStatus);
                    odataReferralpropCount++;
                }

                if (odataReferralcallToAction != null)
                {
                    odataReferral["callToAction"] = SourceExpressionConverter.ConvertToken(odataReferralcallToAction);
                    odataReferralpropCount++;
                }

                if (odataReferralreferralSource != null)
                {
                    odataReferral["referralSource"] = SourceExpressionConverter.ConvertToken(odataReferralreferralSource);
                    odataReferralpropCount++;
                }

                if (odataReferralquality != null)
                {
                    odataReferral["quality"] = SourceExpressionConverter.ConvertToken(odataReferralquality);
                    odataReferralpropCount++;
                }

                if (odataReferralisSpam != null)
                {
                    odataReferral["isSpam"] = SourceExpressionConverter.ConvertToken(odataReferralisSpam);
                    odataReferralpropCount++;
                }

                if (odataReferraldirection != null)
                {
                    odataReferral["direction"] = SourceExpressionConverter.ConvertToken(odataReferraldirection);
                    odataReferralpropCount++;
                }

                if (odataReferraltags != null)
                {
                    odataReferral["tags"] = SourceExpressionConverter.ConvertToken(odataReferraltags);
                    odataReferralpropCount++;
                }

                if (odataReferralacceptedDateTime != null)
                {
                    odataReferral["acceptedDateTime"] = SourceExpressionConverter.ConvertToken(odataReferralacceptedDateTime);
                    odataReferralpropCount++;
                }

                if (odataReferralclosedDateTime != null)
                {
                    odataReferral["closedDateTime"] = SourceExpressionConverter.ConvertToken(odataReferralclosedDateTime);
                    odataReferralpropCount++;
                }

                if (odataReferralpropCount > 0)
                {
                    callPayload.Body = odataReferral;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchReferralById([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem[]> referral = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            SourceExpression.Validate(referral, nameof(referral), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/referrals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = SourceExpressionConverter.ConvertToken(referral);
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateDealRegistrationByReferralId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem2[]> referral = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            SourceExpression.Validate(referral, nameof(referral), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/referrals/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = SourceExpressionConverter.ConvertToken(referral);
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchDealRegistrationByReferralId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> mSCorrelationId = null, [WorkflowExpression] Func<referralInputItem22[]> referral = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(mSCorrelationId, nameof(mSCorrelationId), required: false);
            SourceExpression.Validate(referral, nameof(referral), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/referrals/{0}//", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = SourceExpressionConverter.ConvertO(mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = SourceExpressionConverter.ConvertToken(referral);
                return callPayload;
            }

            return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(BuildSourceInput);
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