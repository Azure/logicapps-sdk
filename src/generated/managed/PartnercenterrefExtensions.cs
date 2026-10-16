//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Partnercenterref
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PartnercenterrefActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<GetAllReferralsResponse> GetAllReferrals(Expression<Func<string>> expand = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<bool>> count = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<GetAllReferralsResponse>(() =>
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<GetAllReferralsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateReferral(Expression<Func<string>> referralcontext = null, Expression<Func<string>> referralcampaignId = null, Expression<Func<bool>> referralconsentconsentToContact = null, Expression<Func<bool>> referralconsentconsentToToShareInfoWithOthers = null, Expression<Func<bool>> referralconsentconsentToShareReferralWithMicrosoftSellers = null, Expression<Func<string>> referralcreatedDateTime = null, Expression<Func<string>> referralcustomerProfileaddressaddressLine1 = null, Expression<Func<string>> referralcustomerProfileaddressaddressLine2 = null, Expression<Func<string>> referralcustomerProfileaddresscity = null, Expression<Func<string>> referralcustomerProfileaddresscountry = null, Expression<Func<string>> referralcustomerProfileaddresspostalCode = null, Expression<Func<string>> referralcustomerProfileaddressregion = null, Expression<Func<string>> referralcustomerProfileaddressstate = null, Expression<Func<JToken[]>> referralcustomerProfileids = null, Expression<Func<string>> referralcustomerProfilename = null, Expression<Func<string>> referralcustomerProfilesize = null, Expression<Func<referralcustomerProfileteamInputItem[]>> referralcustomerProfileteam = null, Expression<Func<string>> referraldetailsclosingDateTime = null, Expression<Func<string>> referraldetailscurrency = null, Expression<Func<string>> referraldetailscustomerAction = null, Expression<Func<bool>> referraldetailscustomerRequestedContact = null, Expression<Func<double>> referraldetailsdealValue = null, Expression<Func<string>> referraldetailsnotes = null, Expression<Func<referraldetailsrequirementsindustriesInputItem[]>> referraldetailsrequirementsindustries = null, Expression<Func<referraldetailsrequirementsproductsInputItem[]>> referraldetailsrequirementsproducts = null, Expression<Func<referraldetailsrequirementsservicesInputItem[]>> referraldetailsrequirementsservices = null, Expression<Func<JToken[]>> referraldetailsrequirementssolutions = null, Expression<Func<JToken[]>> referraldetailsrequirementsoffers = null, Expression<Func<string>> referraleTag = null, Expression<Func<string>> referralengagementId = null, Expression<Func<string>> referralexpirationDateTime = null, Expression<Func<string>> referralexternalReferenceId = null, Expression<Func<bool>> referralfavorite = null, Expression<Func<string>> referralid = null, Expression<Func<referralinviteContextassistanceRequestCodeInput>> referralinviteContextassistanceRequestCode = null, Expression<Func<string>> referralinviteContextinvitedByorganizationId = null, Expression<Func<string>> referralinviteContextinvitedByorganizationName = null, Expression<Func<string>> referralinviteContextnotes = null, Expression<Func<string>> referrallastModifiedVia = null, Expression<Func<string>> referrallastRunId = null, Expression<Func<string>> referrallinksrelatedReferralsmethod = null, Expression<Func<string>> referrallinksrelatedReferralsuri = null, Expression<Func<string>> referrallinksselfmethod = null, Expression<Func<string>> referrallinksselfuri = null, Expression<Func<string>> referralname = null, Expression<Func<string>> referralorganizationId = null, Expression<Func<string>> referralorganizationName = null, Expression<Func<string>> referralqualification = null, Expression<Func<string>> referralreferralProgram = null, Expression<Func<referralsalesStageInput>> referralsalesStage = null, Expression<Func<string>> referralstatus = null, Expression<Func<string>> referralstatusReason = null, Expression<Func<string>> referralsubstatus = null, Expression<Func<referraltargetInputItem[]>> referraltarget = null, Expression<Func<referralteamInputItem[]>> referralteam = null, Expression<Func<string>> referraltrackingInfomicrosoftMsxId = null, Expression<Func<string>> referraltype = null, Expression<Func<string>> referralupdatedDateTime = null, Expression<Func<string>> referralmpnId = null, Expression<Func<referralregistrationsInputItem[]>> referralregistrations = null, Expression<Func<string>> referralregistrationStatus = null, Expression<Func<string>> referralcallToAction = null, Expression<Func<string>> referralreferralSource = null, Expression<Func<string>> referralquality = null, Expression<Func<bool>> referralisSpam = null, Expression<Func<string>> referraldirection = null, Expression<Func<string[]>> referraltags = null, Expression<Func<string>> referralacceptedDateTime = null, Expression<Func<string>> referralclosedDateTime = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_referralcontext = WorkflowExpression.Compile(referralcontext, nameof(referralcontext), required: false);
            var __workflow_referralcampaignId = WorkflowExpression.Compile(referralcampaignId, nameof(referralcampaignId), required: false);
            var __workflow_referralconsentconsentToContact = WorkflowExpression.Compile(referralconsentconsentToContact, nameof(referralconsentconsentToContact), required: false);
            var __workflow_referralconsentconsentToToShareInfoWithOthers = WorkflowExpression.Compile(referralconsentconsentToToShareInfoWithOthers, nameof(referralconsentconsentToToShareInfoWithOthers), required: false);
            var __workflow_referralconsentconsentToShareReferralWithMicrosoftSellers = WorkflowExpression.Compile(referralconsentconsentToShareReferralWithMicrosoftSellers, nameof(referralconsentconsentToShareReferralWithMicrosoftSellers), required: false);
            var __workflow_referralcreatedDateTime = WorkflowExpression.Compile(referralcreatedDateTime, nameof(referralcreatedDateTime), required: false);
            var __workflow_referralcustomerProfileaddressaddressLine1 = WorkflowExpression.Compile(referralcustomerProfileaddressaddressLine1, nameof(referralcustomerProfileaddressaddressLine1), required: false);
            var __workflow_referralcustomerProfileaddressaddressLine2 = WorkflowExpression.Compile(referralcustomerProfileaddressaddressLine2, nameof(referralcustomerProfileaddressaddressLine2), required: false);
            var __workflow_referralcustomerProfileaddresscity = WorkflowExpression.Compile(referralcustomerProfileaddresscity, nameof(referralcustomerProfileaddresscity), required: false);
            var __workflow_referralcustomerProfileaddresscountry = WorkflowExpression.Compile(referralcustomerProfileaddresscountry, nameof(referralcustomerProfileaddresscountry), required: false);
            var __workflow_referralcustomerProfileaddresspostalCode = WorkflowExpression.Compile(referralcustomerProfileaddresspostalCode, nameof(referralcustomerProfileaddresspostalCode), required: false);
            var __workflow_referralcustomerProfileaddressregion = WorkflowExpression.Compile(referralcustomerProfileaddressregion, nameof(referralcustomerProfileaddressregion), required: false);
            var __workflow_referralcustomerProfileaddressstate = WorkflowExpression.Compile(referralcustomerProfileaddressstate, nameof(referralcustomerProfileaddressstate), required: false);
            var __workflow_referralcustomerProfileids = WorkflowExpression.Compile(referralcustomerProfileids, nameof(referralcustomerProfileids), required: false);
            var __workflow_referralcustomerProfilename = WorkflowExpression.Compile(referralcustomerProfilename, nameof(referralcustomerProfilename), required: false);
            var __workflow_referralcustomerProfilesize = WorkflowExpression.Compile(referralcustomerProfilesize, nameof(referralcustomerProfilesize), required: false);
            var __workflow_referralcustomerProfileteam = WorkflowExpression.Compile(referralcustomerProfileteam, nameof(referralcustomerProfileteam), required: false);
            var __workflow_referraldetailsclosingDateTime = WorkflowExpression.Compile(referraldetailsclosingDateTime, nameof(referraldetailsclosingDateTime), required: false);
            var __workflow_referraldetailscurrency = WorkflowExpression.Compile(referraldetailscurrency, nameof(referraldetailscurrency), required: false);
            var __workflow_referraldetailscustomerAction = WorkflowExpression.Compile(referraldetailscustomerAction, nameof(referraldetailscustomerAction), required: false);
            var __workflow_referraldetailscustomerRequestedContact = WorkflowExpression.Compile(referraldetailscustomerRequestedContact, nameof(referraldetailscustomerRequestedContact), required: false);
            var __workflow_referraldetailsdealValue = WorkflowExpression.Compile(referraldetailsdealValue, nameof(referraldetailsdealValue), required: false);
            var __workflow_referraldetailsnotes = WorkflowExpression.Compile(referraldetailsnotes, nameof(referraldetailsnotes), required: false);
            var __workflow_referraldetailsrequirementsindustries = WorkflowExpression.Compile(referraldetailsrequirementsindustries, nameof(referraldetailsrequirementsindustries), required: false);
            var __workflow_referraldetailsrequirementsproducts = WorkflowExpression.Compile(referraldetailsrequirementsproducts, nameof(referraldetailsrequirementsproducts), required: false);
            var __workflow_referraldetailsrequirementsservices = WorkflowExpression.Compile(referraldetailsrequirementsservices, nameof(referraldetailsrequirementsservices), required: false);
            var __workflow_referraldetailsrequirementssolutions = WorkflowExpression.Compile(referraldetailsrequirementssolutions, nameof(referraldetailsrequirementssolutions), required: false);
            var __workflow_referraldetailsrequirementsoffers = WorkflowExpression.Compile(referraldetailsrequirementsoffers, nameof(referraldetailsrequirementsoffers), required: false);
            var __workflow_referraleTag = WorkflowExpression.Compile(referraleTag, nameof(referraleTag), required: false);
            var __workflow_referralengagementId = WorkflowExpression.Compile(referralengagementId, nameof(referralengagementId), required: false);
            var __workflow_referralexpirationDateTime = WorkflowExpression.Compile(referralexpirationDateTime, nameof(referralexpirationDateTime), required: false);
            var __workflow_referralexternalReferenceId = WorkflowExpression.Compile(referralexternalReferenceId, nameof(referralexternalReferenceId), required: false);
            var __workflow_referralfavorite = WorkflowExpression.Compile(referralfavorite, nameof(referralfavorite), required: false);
            var __workflow_referralid = WorkflowExpression.Compile(referralid, nameof(referralid), required: false);
            var __workflow_referralinviteContextassistanceRequestCode = WorkflowExpression.Compile(referralinviteContextassistanceRequestCode, nameof(referralinviteContextassistanceRequestCode), required: false);
            var __workflow_referralinviteContextinvitedByorganizationId = WorkflowExpression.Compile(referralinviteContextinvitedByorganizationId, nameof(referralinviteContextinvitedByorganizationId), required: false);
            var __workflow_referralinviteContextinvitedByorganizationName = WorkflowExpression.Compile(referralinviteContextinvitedByorganizationName, nameof(referralinviteContextinvitedByorganizationName), required: false);
            var __workflow_referralinviteContextnotes = WorkflowExpression.Compile(referralinviteContextnotes, nameof(referralinviteContextnotes), required: false);
            var __workflow_referrallastModifiedVia = WorkflowExpression.Compile(referrallastModifiedVia, nameof(referrallastModifiedVia), required: false);
            var __workflow_referrallastRunId = WorkflowExpression.Compile(referrallastRunId, nameof(referrallastRunId), required: false);
            var __workflow_referrallinksrelatedReferralsmethod = WorkflowExpression.Compile(referrallinksrelatedReferralsmethod, nameof(referrallinksrelatedReferralsmethod), required: false);
            var __workflow_referrallinksrelatedReferralsuri = WorkflowExpression.Compile(referrallinksrelatedReferralsuri, nameof(referrallinksrelatedReferralsuri), required: false);
            var __workflow_referrallinksselfmethod = WorkflowExpression.Compile(referrallinksselfmethod, nameof(referrallinksselfmethod), required: false);
            var __workflow_referrallinksselfuri = WorkflowExpression.Compile(referrallinksselfuri, nameof(referrallinksselfuri), required: false);
            var __workflow_referralname = WorkflowExpression.Compile(referralname, nameof(referralname), required: false);
            var __workflow_referralorganizationId = WorkflowExpression.Compile(referralorganizationId, nameof(referralorganizationId), required: false);
            var __workflow_referralorganizationName = WorkflowExpression.Compile(referralorganizationName, nameof(referralorganizationName), required: false);
            var __workflow_referralqualification = WorkflowExpression.Compile(referralqualification, nameof(referralqualification), required: false);
            var __workflow_referralreferralProgram = WorkflowExpression.Compile(referralreferralProgram, nameof(referralreferralProgram), required: false);
            var __workflow_referralsalesStage = WorkflowExpression.Compile(referralsalesStage, nameof(referralsalesStage), required: false);
            var __workflow_referralstatus = WorkflowExpression.Compile(referralstatus, nameof(referralstatus), required: false);
            var __workflow_referralstatusReason = WorkflowExpression.Compile(referralstatusReason, nameof(referralstatusReason), required: false);
            var __workflow_referralsubstatus = WorkflowExpression.Compile(referralsubstatus, nameof(referralsubstatus), required: false);
            var __workflow_referraltarget = WorkflowExpression.Compile(referraltarget, nameof(referraltarget), required: false);
            var __workflow_referralteam = WorkflowExpression.Compile(referralteam, nameof(referralteam), required: false);
            var __workflow_referraltrackingInfomicrosoftMsxId = WorkflowExpression.Compile(referraltrackingInfomicrosoftMsxId, nameof(referraltrackingInfomicrosoftMsxId), required: false);
            var __workflow_referraltype = WorkflowExpression.Compile(referraltype, nameof(referraltype), required: false);
            var __workflow_referralupdatedDateTime = WorkflowExpression.Compile(referralupdatedDateTime, nameof(referralupdatedDateTime), required: false);
            var __workflow_referralmpnId = WorkflowExpression.Compile(referralmpnId, nameof(referralmpnId), required: false);
            var __workflow_referralregistrations = WorkflowExpression.Compile(referralregistrations, nameof(referralregistrations), required: false);
            var __workflow_referralregistrationStatus = WorkflowExpression.Compile(referralregistrationStatus, nameof(referralregistrationStatus), required: false);
            var __workflow_referralcallToAction = WorkflowExpression.Compile(referralcallToAction, nameof(referralcallToAction), required: false);
            var __workflow_referralreferralSource = WorkflowExpression.Compile(referralreferralSource, nameof(referralreferralSource), required: false);
            var __workflow_referralquality = WorkflowExpression.Compile(referralquality, nameof(referralquality), required: false);
            var __workflow_referralisSpam = WorkflowExpression.Compile(referralisSpam, nameof(referralisSpam), required: false);
            var __workflow_referraldirection = WorkflowExpression.Compile(referraldirection, nameof(referraldirection), required: false);
            var __workflow_referraltags = WorkflowExpression.Compile(referraltags, nameof(referraltags), required: false);
            var __workflow_referralacceptedDateTime = WorkflowExpression.Compile(referralacceptedDateTime, nameof(referralacceptedDateTime), required: false);
            var __workflow_referralclosedDateTime = WorkflowExpression.Compile(referralclosedDateTime, nameof(referralclosedDateTime), required: false);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = "/referrals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                var referral = new JObject();
                var referralpropCount = 0;
                if (__workflow_referralcontext != null)
                {
                    referral["@odata.context"] = ExpressionConverter.ConvertO(__workflow_referralcontext);
                    referralpropCount++;
                }

                if (__workflow_referralcampaignId != null)
                {
                    referral["campaignId"] = ExpressionConverter.ConvertO(__workflow_referralcampaignId);
                    referralpropCount++;
                }

                var consentObject = new JObject();
                var consentObjectpropCount = 0;
                if (__workflow_referralconsentconsentToContact != null)
                {
                    consentObject["consentToContact"] = ExpressionConverter.ConvertO(__workflow_referralconsentconsentToContact);
                    consentObjectpropCount++;
                }

                if (__workflow_referralconsentconsentToToShareInfoWithOthers != null)
                {
                    consentObject["consentToToShareInfoWithOthers"] = ExpressionConverter.ConvertO(__workflow_referralconsentconsentToToShareInfoWithOthers);
                    consentObjectpropCount++;
                }

                if (__workflow_referralconsentconsentToShareReferralWithMicrosoftSellers != null)
                {
                    consentObject["consentToShareReferralWithMicrosoftSellers"] = ExpressionConverter.ConvertO(__workflow_referralconsentconsentToShareReferralWithMicrosoftSellers);
                    consentObjectpropCount++;
                }

                if (consentObjectpropCount > 0)
                {
                    referral["consent"] = consentObject;
                    referralpropCount++;
                }

                if (__workflow_referralcreatedDateTime != null)
                {
                    referral["createdDateTime"] = ExpressionConverter.ConvertO(__workflow_referralcreatedDateTime);
                    referralpropCount++;
                }

                var customerProfileObject = new JObject();
                var customerProfileObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_referralcustomerProfileaddressaddressLine1 != null)
                {
                    addressObject["addressLine1"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddressregion != null)
                {
                    addressObject["region"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddressregion);
                    addressObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileaddressstate);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    customerProfileObject["address"] = addressObject;
                    customerProfileObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileids != null)
                {
                    customerProfileObject["ids"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileids);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_referralcustomerProfilename != null)
                {
                    customerProfileObject["name"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfilename);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_referralcustomerProfilesize != null)
                {
                    customerProfileObject["size"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfilesize);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_referralcustomerProfileteam != null)
                {
                    customerProfileObject["team"] = ExpressionConverter.ConvertO(__workflow_referralcustomerProfileteam);
                    customerProfileObjectpropCount++;
                }

                if (customerProfileObjectpropCount > 0)
                {
                    referral["customerProfile"] = customerProfileObject;
                    referralpropCount++;
                }

                var detailsObject = new JObject();
                var detailsObjectpropCount = 0;
                if (__workflow_referraldetailsclosingDateTime != null)
                {
                    detailsObject["closingDateTime"] = ExpressionConverter.ConvertO(__workflow_referraldetailsclosingDateTime);
                    detailsObjectpropCount++;
                }

                if (__workflow_referraldetailscurrency != null)
                {
                    detailsObject["currency"] = ExpressionConverter.ConvertO(__workflow_referraldetailscurrency);
                    detailsObjectpropCount++;
                }

                if (__workflow_referraldetailscustomerAction != null)
                {
                    detailsObject["customerAction"] = ExpressionConverter.ConvertO(__workflow_referraldetailscustomerAction);
                    detailsObjectpropCount++;
                }

                if (__workflow_referraldetailscustomerRequestedContact != null)
                {
                    detailsObject["customerRequestedContact"] = ExpressionConverter.ConvertO(__workflow_referraldetailscustomerRequestedContact);
                    detailsObjectpropCount++;
                }

                if (__workflow_referraldetailsdealValue != null)
                {
                    detailsObject["dealValue"] = ExpressionConverter.ConvertO(__workflow_referraldetailsdealValue);
                    detailsObjectpropCount++;
                }

                if (__workflow_referraldetailsnotes != null)
                {
                    detailsObject["notes"] = ExpressionConverter.ConvertO(__workflow_referraldetailsnotes);
                    detailsObjectpropCount++;
                }

                var requirementsObject = new JObject();
                var requirementsObjectpropCount = 0;
                if (__workflow_referraldetailsrequirementsindustries != null)
                {
                    requirementsObject["industries"] = ExpressionConverter.ConvertO(__workflow_referraldetailsrequirementsindustries);
                    requirementsObjectpropCount++;
                }

                if (__workflow_referraldetailsrequirementsproducts != null)
                {
                    requirementsObject["products"] = ExpressionConverter.ConvertO(__workflow_referraldetailsrequirementsproducts);
                    requirementsObjectpropCount++;
                }

                if (__workflow_referraldetailsrequirementsservices != null)
                {
                    requirementsObject["services"] = ExpressionConverter.ConvertO(__workflow_referraldetailsrequirementsservices);
                    requirementsObjectpropCount++;
                }

                if (__workflow_referraldetailsrequirementssolutions != null)
                {
                    requirementsObject["solutions"] = ExpressionConverter.ConvertO(__workflow_referraldetailsrequirementssolutions);
                    requirementsObjectpropCount++;
                }

                if (__workflow_referraldetailsrequirementsoffers != null)
                {
                    requirementsObject["offers"] = ExpressionConverter.ConvertO(__workflow_referraldetailsrequirementsoffers);
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

                if (__workflow_referraleTag != null)
                {
                    referral["eTag"] = ExpressionConverter.ConvertO(__workflow_referraleTag);
                    referralpropCount++;
                }

                if (__workflow_referralengagementId != null)
                {
                    referral["engagementId"] = ExpressionConverter.ConvertO(__workflow_referralengagementId);
                    referralpropCount++;
                }

                if (__workflow_referralexpirationDateTime != null)
                {
                    referral["expirationDateTime"] = ExpressionConverter.ConvertO(__workflow_referralexpirationDateTime);
                    referralpropCount++;
                }

                if (__workflow_referralexternalReferenceId != null)
                {
                    referral["externalReferenceId"] = ExpressionConverter.ConvertO(__workflow_referralexternalReferenceId);
                    referralpropCount++;
                }

                if (__workflow_referralfavorite != null)
                {
                    referral["favorite"] = ExpressionConverter.ConvertO(__workflow_referralfavorite);
                    referralpropCount++;
                }

                if (__workflow_referralid != null)
                {
                    referral["id"] = ExpressionConverter.ConvertO(__workflow_referralid);
                    referralpropCount++;
                }

                var inviteContextObject = new JObject();
                var inviteContextObjectpropCount = 0;
                if (__workflow_referralinviteContextassistanceRequestCode != null)
                {
                    inviteContextObject["assistanceRequestCode"] = ExpressionConverter.ConvertO(__workflow_referralinviteContextassistanceRequestCode);
                    inviteContextObjectpropCount++;
                }

                var invitedByObject = new JObject();
                var invitedByObjectpropCount = 0;
                if (__workflow_referralinviteContextinvitedByorganizationId != null)
                {
                    invitedByObject["organizationId"] = ExpressionConverter.ConvertO(__workflow_referralinviteContextinvitedByorganizationId);
                    invitedByObjectpropCount++;
                }

                if (__workflow_referralinviteContextinvitedByorganizationName != null)
                {
                    invitedByObject["organizationName"] = ExpressionConverter.ConvertO(__workflow_referralinviteContextinvitedByorganizationName);
                    invitedByObjectpropCount++;
                }

                if (invitedByObjectpropCount > 0)
                {
                    inviteContextObject["invitedBy"] = invitedByObject;
                    inviteContextObjectpropCount++;
                }

                if (__workflow_referralinviteContextnotes != null)
                {
                    inviteContextObject["notes"] = ExpressionConverter.ConvertO(__workflow_referralinviteContextnotes);
                    inviteContextObjectpropCount++;
                }

                if (inviteContextObjectpropCount > 0)
                {
                    referral["inviteContext"] = inviteContextObject;
                    referralpropCount++;
                }

                if (__workflow_referrallastModifiedVia != null)
                {
                    referral["lastModifiedVia"] = ExpressionConverter.ConvertO(__workflow_referrallastModifiedVia);
                    referralpropCount++;
                }

                if (__workflow_referrallastRunId != null)
                {
                    referral["lastRunId"] = ExpressionConverter.ConvertO(__workflow_referrallastRunId);
                    referralpropCount++;
                }

                var linksObject = new JObject();
                var linksObjectpropCount = 0;
                var relatedReferralsObject = new JObject();
                var relatedReferralsObjectpropCount = 0;
                if (__workflow_referrallinksrelatedReferralsmethod != null)
                {
                    relatedReferralsObject["method"] = ExpressionConverter.ConvertO(__workflow_referrallinksrelatedReferralsmethod);
                    relatedReferralsObjectpropCount++;
                }

                if (__workflow_referrallinksrelatedReferralsuri != null)
                {
                    relatedReferralsObject["uri"] = ExpressionConverter.ConvertO(__workflow_referrallinksrelatedReferralsuri);
                    relatedReferralsObjectpropCount++;
                }

                if (relatedReferralsObjectpropCount > 0)
                {
                    linksObject["relatedReferrals"] = relatedReferralsObject;
                    linksObjectpropCount++;
                }

                var selfObject = new JObject();
                var selfObjectpropCount = 0;
                if (__workflow_referrallinksselfmethod != null)
                {
                    selfObject["method"] = ExpressionConverter.ConvertO(__workflow_referrallinksselfmethod);
                    selfObjectpropCount++;
                }

                if (__workflow_referrallinksselfuri != null)
                {
                    selfObject["uri"] = ExpressionConverter.ConvertO(__workflow_referrallinksselfuri);
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

                if (__workflow_referralname != null)
                {
                    referral["name"] = ExpressionConverter.ConvertO(__workflow_referralname);
                    referralpropCount++;
                }

                if (__workflow_referralorganizationId != null)
                {
                    referral["organizationId"] = ExpressionConverter.ConvertO(__workflow_referralorganizationId);
                    referralpropCount++;
                }

                if (__workflow_referralorganizationName != null)
                {
                    referral["organizationName"] = ExpressionConverter.ConvertO(__workflow_referralorganizationName);
                    referralpropCount++;
                }

                if (__workflow_referralqualification != null)
                {
                    referral["qualification"] = ExpressionConverter.ConvertO(__workflow_referralqualification);
                    referralpropCount++;
                }

                if (__workflow_referralreferralProgram != null)
                {
                    referral["referralProgram"] = ExpressionConverter.ConvertO(__workflow_referralreferralProgram);
                    referralpropCount++;
                }

                if (__workflow_referralsalesStage != null)
                {
                    referral["salesStage"] = ExpressionConverter.ConvertO(__workflow_referralsalesStage);
                    referralpropCount++;
                }

                if (__workflow_referralstatus != null)
                {
                    referral["status"] = ExpressionConverter.ConvertO(__workflow_referralstatus);
                    referralpropCount++;
                }

                if (__workflow_referralstatusReason != null)
                {
                    referral["statusReason"] = ExpressionConverter.ConvertO(__workflow_referralstatusReason);
                    referralpropCount++;
                }

                if (__workflow_referralsubstatus != null)
                {
                    referral["substatus"] = ExpressionConverter.ConvertO(__workflow_referralsubstatus);
                    referralpropCount++;
                }

                if (__workflow_referraltarget != null)
                {
                    referral["target"] = ExpressionConverter.ConvertO(__workflow_referraltarget);
                    referralpropCount++;
                }

                if (__workflow_referralteam != null)
                {
                    referral["team"] = ExpressionConverter.ConvertO(__workflow_referralteam);
                    referralpropCount++;
                }

                var trackingInfoObject = new JObject();
                var trackingInfoObjectpropCount = 0;
                if (__workflow_referraltrackingInfomicrosoftMsxId != null)
                {
                    trackingInfoObject["microsoftMsxId"] = ExpressionConverter.ConvertO(__workflow_referraltrackingInfomicrosoftMsxId);
                    trackingInfoObjectpropCount++;
                }

                if (trackingInfoObjectpropCount > 0)
                {
                    referral["trackingInfo"] = trackingInfoObject;
                    referralpropCount++;
                }

                if (__workflow_referraltype != null)
                {
                    referral["type"] = ExpressionConverter.ConvertO(__workflow_referraltype);
                    referralpropCount++;
                }

                if (__workflow_referralupdatedDateTime != null)
                {
                    referral["updatedDateTime"] = ExpressionConverter.ConvertO(__workflow_referralupdatedDateTime);
                    referralpropCount++;
                }

                if (__workflow_referralmpnId != null)
                {
                    referral["mpnId"] = ExpressionConverter.ConvertO(__workflow_referralmpnId);
                    referralpropCount++;
                }

                if (__workflow_referralregistrations != null)
                {
                    referral["registrations"] = ExpressionConverter.ConvertO(__workflow_referralregistrations);
                    referralpropCount++;
                }

                if (__workflow_referralregistrationStatus != null)
                {
                    referral["registrationStatus"] = ExpressionConverter.ConvertO(__workflow_referralregistrationStatus);
                    referralpropCount++;
                }

                if (__workflow_referralcallToAction != null)
                {
                    referral["callToAction"] = ExpressionConverter.ConvertO(__workflow_referralcallToAction);
                    referralpropCount++;
                }

                if (__workflow_referralreferralSource != null)
                {
                    referral["referralSource"] = ExpressionConverter.ConvertO(__workflow_referralreferralSource);
                    referralpropCount++;
                }

                if (__workflow_referralquality != null)
                {
                    referral["quality"] = ExpressionConverter.ConvertO(__workflow_referralquality);
                    referralpropCount++;
                }

                if (__workflow_referralisSpam != null)
                {
                    referral["isSpam"] = ExpressionConverter.ConvertO(__workflow_referralisSpam);
                    referralpropCount++;
                }

                if (__workflow_referraldirection != null)
                {
                    referral["direction"] = ExpressionConverter.ConvertO(__workflow_referraldirection);
                    referralpropCount++;
                }

                if (__workflow_referraltags != null)
                {
                    referral["tags"] = ExpressionConverter.ConvertO(__workflow_referraltags);
                    referralpropCount++;
                }

                if (__workflow_referralacceptedDateTime != null)
                {
                    referral["acceptedDateTime"] = ExpressionConverter.ConvertO(__workflow_referralacceptedDateTime);
                    referralpropCount++;
                }

                if (__workflow_referralclosedDateTime != null)
                {
                    referral["closedDateTime"] = ExpressionConverter.ConvertO(__workflow_referralclosedDateTime);
                    referralpropCount++;
                }

                if (referralpropCount > 0)
                {
                    callPayload.Body = referral;
                }

                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> GetReferralById(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> UpdateReferralById(Expression<Func<string>> id, Expression<Func<string>> ifMatch, Expression<Func<string>> odataReferralcontext = null, Expression<Func<string>> odataReferralcampaignId = null, Expression<Func<bool>> odataReferralconsentconsentToContact = null, Expression<Func<bool>> odataReferralconsentconsentToToShareInfoWithOthers = null, Expression<Func<bool>> odataReferralconsentconsentToShareReferralWithMicrosoftSellers = null, Expression<Func<string>> odataReferralcreatedDateTime = null, Expression<Func<string>> odataReferralcustomerProfileaddressaddressLine1 = null, Expression<Func<string>> odataReferralcustomerProfileaddressaddressLine2 = null, Expression<Func<string>> odataReferralcustomerProfileaddresscity = null, Expression<Func<string>> odataReferralcustomerProfileaddresscountry = null, Expression<Func<string>> odataReferralcustomerProfileaddresspostalCode = null, Expression<Func<string>> odataReferralcustomerProfileaddressregion = null, Expression<Func<string>> odataReferralcustomerProfileaddressstate = null, Expression<Func<JToken[]>> odataReferralcustomerProfileids = null, Expression<Func<string>> odataReferralcustomerProfilename = null, Expression<Func<string>> odataReferralcustomerProfilesize = null, Expression<Func<odataReferralcustomerProfileteamInputItem[]>> odataReferralcustomerProfileteam = null, Expression<Func<string>> odataReferraldetailsclosingDateTime = null, Expression<Func<string>> odataReferraldetailscurrency = null, Expression<Func<string>> odataReferraldetailscustomerAction = null, Expression<Func<bool>> odataReferraldetailscustomerRequestedContact = null, Expression<Func<double>> odataReferraldetailsdealValue = null, Expression<Func<string>> odataReferraldetailsnotes = null, Expression<Func<odataReferraldetailsrequirementsindustriesInputItem[]>> odataReferraldetailsrequirementsindustries = null, Expression<Func<odataReferraldetailsrequirementsproductsInputItem[]>> odataReferraldetailsrequirementsproducts = null, Expression<Func<odataReferraldetailsrequirementsservicesInputItem[]>> odataReferraldetailsrequirementsservices = null, Expression<Func<JToken[]>> odataReferraldetailsrequirementssolutions = null, Expression<Func<JToken[]>> odataReferraldetailsrequirementsoffers = null, Expression<Func<string>> odataReferraleTag = null, Expression<Func<string>> odataReferralengagementId = null, Expression<Func<string>> odataReferralexpirationDateTime = null, Expression<Func<string>> odataReferralexternalReferenceId = null, Expression<Func<bool>> odataReferralfavorite = null, Expression<Func<string>> odataReferralid = null, Expression<Func<odataReferralinviteContextassistanceRequestCodeInput>> odataReferralinviteContextassistanceRequestCode = null, Expression<Func<string>> odataReferralinviteContextinvitedByorganizationId = null, Expression<Func<string>> odataReferralinviteContextinvitedByorganizationName = null, Expression<Func<string>> odataReferralinviteContextnotes = null, Expression<Func<string>> odataReferrallastModifiedVia = null, Expression<Func<string>> odataReferrallastRunId = null, Expression<Func<string>> odataReferrallinksrelatedReferralsmethod = null, Expression<Func<string>> odataReferrallinksrelatedReferralsuri = null, Expression<Func<string>> odataReferrallinksselfmethod = null, Expression<Func<string>> odataReferrallinksselfuri = null, Expression<Func<string>> odataReferralname = null, Expression<Func<string>> odataReferralorganizationId = null, Expression<Func<string>> odataReferralorganizationName = null, Expression<Func<string>> odataReferralqualification = null, Expression<Func<string>> odataReferralreferralProgram = null, Expression<Func<odataReferralsalesStageInput>> odataReferralsalesStage = null, Expression<Func<string>> odataReferralstatus = null, Expression<Func<string>> odataReferralstatusReason = null, Expression<Func<string>> odataReferralsubstatus = null, Expression<Func<odataReferraltargetInputItem[]>> odataReferraltarget = null, Expression<Func<odataReferralteamInputItem[]>> odataReferralteam = null, Expression<Func<string>> odataReferraltrackingInfomicrosoftMsxId = null, Expression<Func<string>> odataReferraltype = null, Expression<Func<string>> odataReferralupdatedDateTime = null, Expression<Func<string>> odataReferralmpnId = null, Expression<Func<odataReferralregistrationsInputItem[]>> odataReferralregistrations = null, Expression<Func<string>> odataReferralregistrationStatus = null, Expression<Func<string>> odataReferralcallToAction = null, Expression<Func<string>> odataReferralreferralSource = null, Expression<Func<string>> odataReferralquality = null, Expression<Func<bool>> odataReferralisSpam = null, Expression<Func<string>> odataReferraldirection = null, Expression<Func<string[]>> odataReferraltags = null, Expression<Func<string>> odataReferralacceptedDateTime = null, Expression<Func<string>> odataReferralclosedDateTime = null, Expression<Func<string>> mSCorrelationId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: true);
            var __workflow_odataReferralcontext = WorkflowExpression.Compile(odataReferralcontext, nameof(odataReferralcontext), required: false);
            var __workflow_odataReferralcampaignId = WorkflowExpression.Compile(odataReferralcampaignId, nameof(odataReferralcampaignId), required: false);
            var __workflow_odataReferralconsentconsentToContact = WorkflowExpression.Compile(odataReferralconsentconsentToContact, nameof(odataReferralconsentconsentToContact), required: false);
            var __workflow_odataReferralconsentconsentToToShareInfoWithOthers = WorkflowExpression.Compile(odataReferralconsentconsentToToShareInfoWithOthers, nameof(odataReferralconsentconsentToToShareInfoWithOthers), required: false);
            var __workflow_odataReferralconsentconsentToShareReferralWithMicrosoftSellers = WorkflowExpression.Compile(odataReferralconsentconsentToShareReferralWithMicrosoftSellers, nameof(odataReferralconsentconsentToShareReferralWithMicrosoftSellers), required: false);
            var __workflow_odataReferralcreatedDateTime = WorkflowExpression.Compile(odataReferralcreatedDateTime, nameof(odataReferralcreatedDateTime), required: false);
            var __workflow_odataReferralcustomerProfileaddressaddressLine1 = WorkflowExpression.Compile(odataReferralcustomerProfileaddressaddressLine1, nameof(odataReferralcustomerProfileaddressaddressLine1), required: false);
            var __workflow_odataReferralcustomerProfileaddressaddressLine2 = WorkflowExpression.Compile(odataReferralcustomerProfileaddressaddressLine2, nameof(odataReferralcustomerProfileaddressaddressLine2), required: false);
            var __workflow_odataReferralcustomerProfileaddresscity = WorkflowExpression.Compile(odataReferralcustomerProfileaddresscity, nameof(odataReferralcustomerProfileaddresscity), required: false);
            var __workflow_odataReferralcustomerProfileaddresscountry = WorkflowExpression.Compile(odataReferralcustomerProfileaddresscountry, nameof(odataReferralcustomerProfileaddresscountry), required: false);
            var __workflow_odataReferralcustomerProfileaddresspostalCode = WorkflowExpression.Compile(odataReferralcustomerProfileaddresspostalCode, nameof(odataReferralcustomerProfileaddresspostalCode), required: false);
            var __workflow_odataReferralcustomerProfileaddressregion = WorkflowExpression.Compile(odataReferralcustomerProfileaddressregion, nameof(odataReferralcustomerProfileaddressregion), required: false);
            var __workflow_odataReferralcustomerProfileaddressstate = WorkflowExpression.Compile(odataReferralcustomerProfileaddressstate, nameof(odataReferralcustomerProfileaddressstate), required: false);
            var __workflow_odataReferralcustomerProfileids = WorkflowExpression.Compile(odataReferralcustomerProfileids, nameof(odataReferralcustomerProfileids), required: false);
            var __workflow_odataReferralcustomerProfilename = WorkflowExpression.Compile(odataReferralcustomerProfilename, nameof(odataReferralcustomerProfilename), required: false);
            var __workflow_odataReferralcustomerProfilesize = WorkflowExpression.Compile(odataReferralcustomerProfilesize, nameof(odataReferralcustomerProfilesize), required: false);
            var __workflow_odataReferralcustomerProfileteam = WorkflowExpression.Compile(odataReferralcustomerProfileteam, nameof(odataReferralcustomerProfileteam), required: false);
            var __workflow_odataReferraldetailsclosingDateTime = WorkflowExpression.Compile(odataReferraldetailsclosingDateTime, nameof(odataReferraldetailsclosingDateTime), required: false);
            var __workflow_odataReferraldetailscurrency = WorkflowExpression.Compile(odataReferraldetailscurrency, nameof(odataReferraldetailscurrency), required: false);
            var __workflow_odataReferraldetailscustomerAction = WorkflowExpression.Compile(odataReferraldetailscustomerAction, nameof(odataReferraldetailscustomerAction), required: false);
            var __workflow_odataReferraldetailscustomerRequestedContact = WorkflowExpression.Compile(odataReferraldetailscustomerRequestedContact, nameof(odataReferraldetailscustomerRequestedContact), required: false);
            var __workflow_odataReferraldetailsdealValue = WorkflowExpression.Compile(odataReferraldetailsdealValue, nameof(odataReferraldetailsdealValue), required: false);
            var __workflow_odataReferraldetailsnotes = WorkflowExpression.Compile(odataReferraldetailsnotes, nameof(odataReferraldetailsnotes), required: false);
            var __workflow_odataReferraldetailsrequirementsindustries = WorkflowExpression.Compile(odataReferraldetailsrequirementsindustries, nameof(odataReferraldetailsrequirementsindustries), required: false);
            var __workflow_odataReferraldetailsrequirementsproducts = WorkflowExpression.Compile(odataReferraldetailsrequirementsproducts, nameof(odataReferraldetailsrequirementsproducts), required: false);
            var __workflow_odataReferraldetailsrequirementsservices = WorkflowExpression.Compile(odataReferraldetailsrequirementsservices, nameof(odataReferraldetailsrequirementsservices), required: false);
            var __workflow_odataReferraldetailsrequirementssolutions = WorkflowExpression.Compile(odataReferraldetailsrequirementssolutions, nameof(odataReferraldetailsrequirementssolutions), required: false);
            var __workflow_odataReferraldetailsrequirementsoffers = WorkflowExpression.Compile(odataReferraldetailsrequirementsoffers, nameof(odataReferraldetailsrequirementsoffers), required: false);
            var __workflow_odataReferraleTag = WorkflowExpression.Compile(odataReferraleTag, nameof(odataReferraleTag), required: false);
            var __workflow_odataReferralengagementId = WorkflowExpression.Compile(odataReferralengagementId, nameof(odataReferralengagementId), required: false);
            var __workflow_odataReferralexpirationDateTime = WorkflowExpression.Compile(odataReferralexpirationDateTime, nameof(odataReferralexpirationDateTime), required: false);
            var __workflow_odataReferralexternalReferenceId = WorkflowExpression.Compile(odataReferralexternalReferenceId, nameof(odataReferralexternalReferenceId), required: false);
            var __workflow_odataReferralfavorite = WorkflowExpression.Compile(odataReferralfavorite, nameof(odataReferralfavorite), required: false);
            var __workflow_odataReferralid = WorkflowExpression.Compile(odataReferralid, nameof(odataReferralid), required: false);
            var __workflow_odataReferralinviteContextassistanceRequestCode = WorkflowExpression.Compile(odataReferralinviteContextassistanceRequestCode, nameof(odataReferralinviteContextassistanceRequestCode), required: false);
            var __workflow_odataReferralinviteContextinvitedByorganizationId = WorkflowExpression.Compile(odataReferralinviteContextinvitedByorganizationId, nameof(odataReferralinviteContextinvitedByorganizationId), required: false);
            var __workflow_odataReferralinviteContextinvitedByorganizationName = WorkflowExpression.Compile(odataReferralinviteContextinvitedByorganizationName, nameof(odataReferralinviteContextinvitedByorganizationName), required: false);
            var __workflow_odataReferralinviteContextnotes = WorkflowExpression.Compile(odataReferralinviteContextnotes, nameof(odataReferralinviteContextnotes), required: false);
            var __workflow_odataReferrallastModifiedVia = WorkflowExpression.Compile(odataReferrallastModifiedVia, nameof(odataReferrallastModifiedVia), required: false);
            var __workflow_odataReferrallastRunId = WorkflowExpression.Compile(odataReferrallastRunId, nameof(odataReferrallastRunId), required: false);
            var __workflow_odataReferrallinksrelatedReferralsmethod = WorkflowExpression.Compile(odataReferrallinksrelatedReferralsmethod, nameof(odataReferrallinksrelatedReferralsmethod), required: false);
            var __workflow_odataReferrallinksrelatedReferralsuri = WorkflowExpression.Compile(odataReferrallinksrelatedReferralsuri, nameof(odataReferrallinksrelatedReferralsuri), required: false);
            var __workflow_odataReferrallinksselfmethod = WorkflowExpression.Compile(odataReferrallinksselfmethod, nameof(odataReferrallinksselfmethod), required: false);
            var __workflow_odataReferrallinksselfuri = WorkflowExpression.Compile(odataReferrallinksselfuri, nameof(odataReferrallinksselfuri), required: false);
            var __workflow_odataReferralname = WorkflowExpression.Compile(odataReferralname, nameof(odataReferralname), required: false);
            var __workflow_odataReferralorganizationId = WorkflowExpression.Compile(odataReferralorganizationId, nameof(odataReferralorganizationId), required: false);
            var __workflow_odataReferralorganizationName = WorkflowExpression.Compile(odataReferralorganizationName, nameof(odataReferralorganizationName), required: false);
            var __workflow_odataReferralqualification = WorkflowExpression.Compile(odataReferralqualification, nameof(odataReferralqualification), required: false);
            var __workflow_odataReferralreferralProgram = WorkflowExpression.Compile(odataReferralreferralProgram, nameof(odataReferralreferralProgram), required: false);
            var __workflow_odataReferralsalesStage = WorkflowExpression.Compile(odataReferralsalesStage, nameof(odataReferralsalesStage), required: false);
            var __workflow_odataReferralstatus = WorkflowExpression.Compile(odataReferralstatus, nameof(odataReferralstatus), required: false);
            var __workflow_odataReferralstatusReason = WorkflowExpression.Compile(odataReferralstatusReason, nameof(odataReferralstatusReason), required: false);
            var __workflow_odataReferralsubstatus = WorkflowExpression.Compile(odataReferralsubstatus, nameof(odataReferralsubstatus), required: false);
            var __workflow_odataReferraltarget = WorkflowExpression.Compile(odataReferraltarget, nameof(odataReferraltarget), required: false);
            var __workflow_odataReferralteam = WorkflowExpression.Compile(odataReferralteam, nameof(odataReferralteam), required: false);
            var __workflow_odataReferraltrackingInfomicrosoftMsxId = WorkflowExpression.Compile(odataReferraltrackingInfomicrosoftMsxId, nameof(odataReferraltrackingInfomicrosoftMsxId), required: false);
            var __workflow_odataReferraltype = WorkflowExpression.Compile(odataReferraltype, nameof(odataReferraltype), required: false);
            var __workflow_odataReferralupdatedDateTime = WorkflowExpression.Compile(odataReferralupdatedDateTime, nameof(odataReferralupdatedDateTime), required: false);
            var __workflow_odataReferralmpnId = WorkflowExpression.Compile(odataReferralmpnId, nameof(odataReferralmpnId), required: false);
            var __workflow_odataReferralregistrations = WorkflowExpression.Compile(odataReferralregistrations, nameof(odataReferralregistrations), required: false);
            var __workflow_odataReferralregistrationStatus = WorkflowExpression.Compile(odataReferralregistrationStatus, nameof(odataReferralregistrationStatus), required: false);
            var __workflow_odataReferralcallToAction = WorkflowExpression.Compile(odataReferralcallToAction, nameof(odataReferralcallToAction), required: false);
            var __workflow_odataReferralreferralSource = WorkflowExpression.Compile(odataReferralreferralSource, nameof(odataReferralreferralSource), required: false);
            var __workflow_odataReferralquality = WorkflowExpression.Compile(odataReferralquality, nameof(odataReferralquality), required: false);
            var __workflow_odataReferralisSpam = WorkflowExpression.Compile(odataReferralisSpam, nameof(odataReferralisSpam), required: false);
            var __workflow_odataReferraldirection = WorkflowExpression.Compile(odataReferraldirection, nameof(odataReferraldirection), required: false);
            var __workflow_odataReferraltags = WorkflowExpression.Compile(odataReferraltags, nameof(odataReferraltags), required: false);
            var __workflow_odataReferralacceptedDateTime = WorkflowExpression.Compile(odataReferralacceptedDateTime, nameof(odataReferralacceptedDateTime), required: false);
            var __workflow_odataReferralclosedDateTime = WorkflowExpression.Compile(odataReferralclosedDateTime, nameof(odataReferralclosedDateTime), required: false);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["if-match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                var odataReferral = new JObject();
                var odataReferralpropCount = 0;
                if (__workflow_odataReferralcontext != null)
                {
                    odataReferral["@odata.context"] = ExpressionConverter.ConvertO(__workflow_odataReferralcontext);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralcampaignId != null)
                {
                    odataReferral["campaignId"] = ExpressionConverter.ConvertO(__workflow_odataReferralcampaignId);
                    odataReferralpropCount++;
                }

                var consentObject = new JObject();
                var consentObjectpropCount = 0;
                if (__workflow_odataReferralconsentconsentToContact != null)
                {
                    consentObject["consentToContact"] = ExpressionConverter.ConvertO(__workflow_odataReferralconsentconsentToContact);
                    consentObjectpropCount++;
                }

                if (__workflow_odataReferralconsentconsentToToShareInfoWithOthers != null)
                {
                    consentObject["consentToToShareInfoWithOthers"] = ExpressionConverter.ConvertO(__workflow_odataReferralconsentconsentToToShareInfoWithOthers);
                    consentObjectpropCount++;
                }

                if (__workflow_odataReferralconsentconsentToShareReferralWithMicrosoftSellers != null)
                {
                    consentObject["consentToShareReferralWithMicrosoftSellers"] = ExpressionConverter.ConvertO(__workflow_odataReferralconsentconsentToShareReferralWithMicrosoftSellers);
                    consentObjectpropCount++;
                }

                if (consentObjectpropCount > 0)
                {
                    odataReferral["consent"] = consentObject;
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralcreatedDateTime != null)
                {
                    odataReferral["createdDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferralcreatedDateTime);
                    odataReferralpropCount++;
                }

                var customerProfileObject = new JObject();
                var customerProfileObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_odataReferralcustomerProfileaddressaddressLine1 != null)
                {
                    addressObject["addressLine1"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddressregion != null)
                {
                    addressObject["region"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddressregion);
                    addressObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileaddressstate);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    customerProfileObject["address"] = addressObject;
                    customerProfileObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileids != null)
                {
                    customerProfileObject["ids"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileids);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfilename != null)
                {
                    customerProfileObject["name"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfilename);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfilesize != null)
                {
                    customerProfileObject["size"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfilesize);
                    customerProfileObjectpropCount++;
                }

                if (__workflow_odataReferralcustomerProfileteam != null)
                {
                    customerProfileObject["team"] = ExpressionConverter.ConvertO(__workflow_odataReferralcustomerProfileteam);
                    customerProfileObjectpropCount++;
                }

                if (customerProfileObjectpropCount > 0)
                {
                    odataReferral["customerProfile"] = customerProfileObject;
                    odataReferralpropCount++;
                }

                var detailsObject = new JObject();
                var detailsObjectpropCount = 0;
                if (__workflow_odataReferraldetailsclosingDateTime != null)
                {
                    detailsObject["closingDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsclosingDateTime);
                    detailsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailscurrency != null)
                {
                    detailsObject["currency"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailscurrency);
                    detailsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailscustomerAction != null)
                {
                    detailsObject["customerAction"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailscustomerAction);
                    detailsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailscustomerRequestedContact != null)
                {
                    detailsObject["customerRequestedContact"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailscustomerRequestedContact);
                    detailsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsdealValue != null)
                {
                    detailsObject["dealValue"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsdealValue);
                    detailsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsnotes != null)
                {
                    detailsObject["notes"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsnotes);
                    detailsObjectpropCount++;
                }

                var requirementsObject = new JObject();
                var requirementsObjectpropCount = 0;
                if (__workflow_odataReferraldetailsrequirementsindustries != null)
                {
                    requirementsObject["industries"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsrequirementsindustries);
                    requirementsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsrequirementsproducts != null)
                {
                    requirementsObject["products"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsrequirementsproducts);
                    requirementsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsrequirementsservices != null)
                {
                    requirementsObject["services"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsrequirementsservices);
                    requirementsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsrequirementssolutions != null)
                {
                    requirementsObject["solutions"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsrequirementssolutions);
                    requirementsObjectpropCount++;
                }

                if (__workflow_odataReferraldetailsrequirementsoffers != null)
                {
                    requirementsObject["offers"] = ExpressionConverter.ConvertO(__workflow_odataReferraldetailsrequirementsoffers);
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

                if (__workflow_odataReferraleTag != null)
                {
                    odataReferral["eTag"] = ExpressionConverter.ConvertO(__workflow_odataReferraleTag);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralengagementId != null)
                {
                    odataReferral["engagementId"] = ExpressionConverter.ConvertO(__workflow_odataReferralengagementId);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralexpirationDateTime != null)
                {
                    odataReferral["expirationDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferralexpirationDateTime);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralexternalReferenceId != null)
                {
                    odataReferral["externalReferenceId"] = ExpressionConverter.ConvertO(__workflow_odataReferralexternalReferenceId);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralfavorite != null)
                {
                    odataReferral["favorite"] = ExpressionConverter.ConvertO(__workflow_odataReferralfavorite);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralid != null)
                {
                    odataReferral["id"] = ExpressionConverter.ConvertO(__workflow_odataReferralid);
                    odataReferralpropCount++;
                }

                var inviteContextObject = new JObject();
                var inviteContextObjectpropCount = 0;
                if (__workflow_odataReferralinviteContextassistanceRequestCode != null)
                {
                    inviteContextObject["assistanceRequestCode"] = ExpressionConverter.ConvertO(__workflow_odataReferralinviteContextassistanceRequestCode);
                    inviteContextObjectpropCount++;
                }

                var invitedByObject = new JObject();
                var invitedByObjectpropCount = 0;
                if (__workflow_odataReferralinviteContextinvitedByorganizationId != null)
                {
                    invitedByObject["organizationId"] = ExpressionConverter.ConvertO(__workflow_odataReferralinviteContextinvitedByorganizationId);
                    invitedByObjectpropCount++;
                }

                if (__workflow_odataReferralinviteContextinvitedByorganizationName != null)
                {
                    invitedByObject["organizationName"] = ExpressionConverter.ConvertO(__workflow_odataReferralinviteContextinvitedByorganizationName);
                    invitedByObjectpropCount++;
                }

                if (invitedByObjectpropCount > 0)
                {
                    inviteContextObject["invitedBy"] = invitedByObject;
                    inviteContextObjectpropCount++;
                }

                if (__workflow_odataReferralinviteContextnotes != null)
                {
                    inviteContextObject["notes"] = ExpressionConverter.ConvertO(__workflow_odataReferralinviteContextnotes);
                    inviteContextObjectpropCount++;
                }

                if (inviteContextObjectpropCount > 0)
                {
                    odataReferral["inviteContext"] = inviteContextObject;
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferrallastModifiedVia != null)
                {
                    odataReferral["lastModifiedVia"] = ExpressionConverter.ConvertO(__workflow_odataReferrallastModifiedVia);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferrallastRunId != null)
                {
                    odataReferral["lastRunId"] = ExpressionConverter.ConvertO(__workflow_odataReferrallastRunId);
                    odataReferralpropCount++;
                }

                var linksObject = new JObject();
                var linksObjectpropCount = 0;
                var relatedReferralsObject = new JObject();
                var relatedReferralsObjectpropCount = 0;
                if (__workflow_odataReferrallinksrelatedReferralsmethod != null)
                {
                    relatedReferralsObject["method"] = ExpressionConverter.ConvertO(__workflow_odataReferrallinksrelatedReferralsmethod);
                    relatedReferralsObjectpropCount++;
                }

                if (__workflow_odataReferrallinksrelatedReferralsuri != null)
                {
                    relatedReferralsObject["uri"] = ExpressionConverter.ConvertO(__workflow_odataReferrallinksrelatedReferralsuri);
                    relatedReferralsObjectpropCount++;
                }

                if (relatedReferralsObjectpropCount > 0)
                {
                    linksObject["relatedReferrals"] = relatedReferralsObject;
                    linksObjectpropCount++;
                }

                var selfObject = new JObject();
                var selfObjectpropCount = 0;
                if (__workflow_odataReferrallinksselfmethod != null)
                {
                    selfObject["method"] = ExpressionConverter.ConvertO(__workflow_odataReferrallinksselfmethod);
                    selfObjectpropCount++;
                }

                if (__workflow_odataReferrallinksselfuri != null)
                {
                    selfObject["uri"] = ExpressionConverter.ConvertO(__workflow_odataReferrallinksselfuri);
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

                if (__workflow_odataReferralname != null)
                {
                    odataReferral["name"] = ExpressionConverter.ConvertO(__workflow_odataReferralname);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralorganizationId != null)
                {
                    odataReferral["organizationId"] = ExpressionConverter.ConvertO(__workflow_odataReferralorganizationId);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralorganizationName != null)
                {
                    odataReferral["organizationName"] = ExpressionConverter.ConvertO(__workflow_odataReferralorganizationName);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralqualification != null)
                {
                    odataReferral["qualification"] = ExpressionConverter.ConvertO(__workflow_odataReferralqualification);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralreferralProgram != null)
                {
                    odataReferral["referralProgram"] = ExpressionConverter.ConvertO(__workflow_odataReferralreferralProgram);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralsalesStage != null)
                {
                    odataReferral["salesStage"] = ExpressionConverter.ConvertO(__workflow_odataReferralsalesStage);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralstatus != null)
                {
                    odataReferral["status"] = ExpressionConverter.ConvertO(__workflow_odataReferralstatus);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralstatusReason != null)
                {
                    odataReferral["statusReason"] = ExpressionConverter.ConvertO(__workflow_odataReferralstatusReason);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralsubstatus != null)
                {
                    odataReferral["substatus"] = ExpressionConverter.ConvertO(__workflow_odataReferralsubstatus);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferraltarget != null)
                {
                    odataReferral["target"] = ExpressionConverter.ConvertO(__workflow_odataReferraltarget);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralteam != null)
                {
                    odataReferral["team"] = ExpressionConverter.ConvertO(__workflow_odataReferralteam);
                    odataReferralpropCount++;
                }

                var trackingInfoObject = new JObject();
                var trackingInfoObjectpropCount = 0;
                if (__workflow_odataReferraltrackingInfomicrosoftMsxId != null)
                {
                    trackingInfoObject["microsoftMsxId"] = ExpressionConverter.ConvertO(__workflow_odataReferraltrackingInfomicrosoftMsxId);
                    trackingInfoObjectpropCount++;
                }

                if (trackingInfoObjectpropCount > 0)
                {
                    odataReferral["trackingInfo"] = trackingInfoObject;
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferraltype != null)
                {
                    odataReferral["type"] = ExpressionConverter.ConvertO(__workflow_odataReferraltype);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralupdatedDateTime != null)
                {
                    odataReferral["updatedDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferralupdatedDateTime);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralmpnId != null)
                {
                    odataReferral["mpnId"] = ExpressionConverter.ConvertO(__workflow_odataReferralmpnId);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralregistrations != null)
                {
                    odataReferral["registrations"] = ExpressionConverter.ConvertO(__workflow_odataReferralregistrations);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralregistrationStatus != null)
                {
                    odataReferral["registrationStatus"] = ExpressionConverter.ConvertO(__workflow_odataReferralregistrationStatus);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralcallToAction != null)
                {
                    odataReferral["callToAction"] = ExpressionConverter.ConvertO(__workflow_odataReferralcallToAction);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralreferralSource != null)
                {
                    odataReferral["referralSource"] = ExpressionConverter.ConvertO(__workflow_odataReferralreferralSource);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralquality != null)
                {
                    odataReferral["quality"] = ExpressionConverter.ConvertO(__workflow_odataReferralquality);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralisSpam != null)
                {
                    odataReferral["isSpam"] = ExpressionConverter.ConvertO(__workflow_odataReferralisSpam);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferraldirection != null)
                {
                    odataReferral["direction"] = ExpressionConverter.ConvertO(__workflow_odataReferraldirection);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferraltags != null)
                {
                    odataReferral["tags"] = ExpressionConverter.ConvertO(__workflow_odataReferraltags);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralacceptedDateTime != null)
                {
                    odataReferral["acceptedDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferralacceptedDateTime);
                    odataReferralpropCount++;
                }

                if (__workflow_odataReferralclosedDateTime != null)
                {
                    odataReferral["closedDateTime"] = ExpressionConverter.ConvertO(__workflow_odataReferralclosedDateTime);
                    odataReferralpropCount++;
                }

                if (odataReferralpropCount > 0)
                {
                    callPayload.Body = odataReferral;
                }

                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchReferralById(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem[]>> referral = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/referrals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> CreateDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem2[]>> referral = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/referrals/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "partnercenterref")]
        public IBodyWorkflowAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral> PatchDealRegistrationByReferralId(Expression<Func<string>> id, Expression<Func<string>> mSCorrelationId = null, Expression<Func<referralInputItem22[]>> referral = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_mSCorrelationId = WorkflowExpression.Compile(mSCorrelationId, nameof(mSCorrelationId), required: false);
            var __workflow_referral = WorkflowExpression.Compile(referral, nameof(referral), required: false);
            return new DeferredBodyAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/referrals/{0}//", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["content-type"] = Convert.ToString("application/json");
                if (__workflow_mSCorrelationId != null)
                    callPayload.Headers["MS-CorrelationId"] = ExpressionConverter.Convert(__workflow_mSCorrelationId);
                callPayload.Headers["X-Caller-Id"] = Convert.ToString("60858c1b-2062-40ad-b42c-996b6b5b047d");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_referral);
                return new ApiConnectionAction<MicrosoftPartnerServicePartnerReferralsContractsV3Referral>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemUpdateOperationType
    {
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum referralInputItemValueTypeSolutionDetailsTypeItemPrimaryDeploymentOnType
    {
        Customer,
        Partner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
