//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesCreate(Expression<Func<string>> bodypropertiesname, Expression<Func<string>> bodypropertiesaboutUs = null, Expression<Func<string>> bodypropertiesaddress = null, Expression<Func<string>> bodypropertiesaddress2 = null, Expression<Func<string>> bodypropertiesannualrevenue = null, Expression<Func<string>> bodypropertiescity = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescountry = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdaysToClose = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesdomain = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertiesfacebookCompanyPage = null, Expression<Func<string>> bodypropertiesfacebookfans = null, Expression<Func<string>> bodypropertiesfirstContactCreatedate = null, Expression<Func<string>> bodypropertiesfirstConversionDate = null, Expression<Func<string>> bodypropertiesfirstConversionEventName = null, Expression<Func<string>> bodypropertiesfirstDealCreatedDate = null, Expression<Func<string>> bodypropertiesfoundedYear = null, Expression<Func<string>> bodypropertiesgoogleplusPage = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsNumVisits = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsIdealCustomerProfile = null, Expression<Func<string>> bodypropertieshsIsTargetAccount = null, Expression<Func<string>> bodypropertieshsLastBookedMeetingDate = null, Expression<Func<string>> bodypropertieshsLastLoggedCallDate = null, Expression<Func<string>> bodypropertieshsLastOpenTaskDate = null, Expression<Func<string>> bodypropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsLeadStatus = null, Expression<Func<string>> bodypropertieshsNumBlockers = null, Expression<Func<string>> bodypropertieshsNumChildCompanies = null, Expression<Func<string>> bodypropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> bodypropertieshsNumDecisionMakers = null, Expression<Func<string>> bodypropertieshsNumOpenDeals = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsParentCompanyId = null, Expression<Func<string>> bodypropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> bodypropertieshsTotalDealValue = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesindustry = null, Expression<Func<string>> bodypropertiesisPublic = null, Expression<Func<string>> bodypropertieslifecyclestage = null, Expression<Func<string>> bodypropertieslinkedinCompanyPage = null, Expression<Func<string>> bodypropertieslinkedinbio = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumAssociatedDeals = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumConversionEvents = null, Expression<Func<string>> bodypropertiesnumberofemployees = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiesrecentConversionDate = null, Expression<Func<string>> bodypropertiesrecentConversionEventName = null, Expression<Func<string>> bodypropertiesrecentDealAmount = null, Expression<Func<string>> bodypropertiesrecentDealCloseDate = null, Expression<Func<string>> bodypropertiesstate = null, Expression<Func<string>> bodypropertiestimezone = null, Expression<Func<string>> bodypropertiestotalMoneyRaised = null, Expression<Func<string>> bodypropertiestotalRevenue = null, Expression<Func<string>> bodypropertiestwitterbio = null, Expression<Func<string>> bodypropertiestwitterfollowers = null, Expression<Func<string>> bodypropertiestwitterhandle = null, Expression<Func<string>> bodypropertiestype = null, Expression<Func<string>> bodypropertieswebTechnologies = null, Expression<Func<string>> bodypropertieswebsite = null, Expression<Func<string>> bodypropertieszip = null)
        {
            var __workflow_bodypropertiesname = WorkflowExpression.Compile(bodypropertiesname, nameof(bodypropertiesname), required: true);
            var __workflow_bodypropertiesaboutUs = WorkflowExpression.Compile(bodypropertiesaboutUs, nameof(bodypropertiesaboutUs), required: false);
            var __workflow_bodypropertiesaddress = WorkflowExpression.Compile(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            var __workflow_bodypropertiesaddress2 = WorkflowExpression.Compile(bodypropertiesaddress2, nameof(bodypropertiesaddress2), required: false);
            var __workflow_bodypropertiesannualrevenue = WorkflowExpression.Compile(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            var __workflow_bodypropertiescity = WorkflowExpression.Compile(bodypropertiescity, nameof(bodypropertiescity), required: false);
            var __workflow_bodypropertiesclosedate = WorkflowExpression.Compile(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescountry = WorkflowExpression.Compile(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdaysToClose = WorkflowExpression.Compile(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            var __workflow_bodypropertiesdescription = WorkflowExpression.Compile(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesdomain = WorkflowExpression.Compile(bodypropertiesdomain, nameof(bodypropertiesdomain), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertiesfacebookCompanyPage = WorkflowExpression.Compile(bodypropertiesfacebookCompanyPage, nameof(bodypropertiesfacebookCompanyPage), required: false);
            var __workflow_bodypropertiesfacebookfans = WorkflowExpression.Compile(bodypropertiesfacebookfans, nameof(bodypropertiesfacebookfans), required: false);
            var __workflow_bodypropertiesfirstContactCreatedate = WorkflowExpression.Compile(bodypropertiesfirstContactCreatedate, nameof(bodypropertiesfirstContactCreatedate), required: false);
            var __workflow_bodypropertiesfirstConversionDate = WorkflowExpression.Compile(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            var __workflow_bodypropertiesfirstConversionEventName = WorkflowExpression.Compile(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            var __workflow_bodypropertiesfirstDealCreatedDate = WorkflowExpression.Compile(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            var __workflow_bodypropertiesfoundedYear = WorkflowExpression.Compile(bodypropertiesfoundedYear, nameof(bodypropertiesfoundedYear), required: false);
            var __workflow_bodypropertiesgoogleplusPage = WorkflowExpression.Compile(bodypropertiesgoogleplusPage, nameof(bodypropertiesgoogleplusPage), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstVisitTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsLastVisitTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsNumPageViews = WorkflowExpression.Compile(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsNumVisits = WorkflowExpression.Compile(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = WorkflowExpression.Compile(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsCreatedate = WorkflowExpression.Compile(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsIdealCustomerProfile = WorkflowExpression.Compile(bodypropertieshsIdealCustomerProfile, nameof(bodypropertieshsIdealCustomerProfile), required: false);
            var __workflow_bodypropertieshsIsTargetAccount = WorkflowExpression.Compile(bodypropertieshsIsTargetAccount, nameof(bodypropertieshsIsTargetAccount), required: false);
            var __workflow_bodypropertieshsLastBookedMeetingDate = WorkflowExpression.Compile(bodypropertieshsLastBookedMeetingDate, nameof(bodypropertieshsLastBookedMeetingDate), required: false);
            var __workflow_bodypropertieshsLastLoggedCallDate = WorkflowExpression.Compile(bodypropertieshsLastLoggedCallDate, nameof(bodypropertieshsLastLoggedCallDate), required: false);
            var __workflow_bodypropertieshsLastOpenTaskDate = WorkflowExpression.Compile(bodypropertieshsLastOpenTaskDate, nameof(bodypropertieshsLastOpenTaskDate), required: false);
            var __workflow_bodypropertieshsLastSalesActivityTimestamp = WorkflowExpression.Compile(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsLeadStatus = WorkflowExpression.Compile(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            var __workflow_bodypropertieshsNumBlockers = WorkflowExpression.Compile(bodypropertieshsNumBlockers, nameof(bodypropertieshsNumBlockers), required: false);
            var __workflow_bodypropertieshsNumChildCompanies = WorkflowExpression.Compile(bodypropertieshsNumChildCompanies, nameof(bodypropertieshsNumChildCompanies), required: false);
            var __workflow_bodypropertieshsNumContactsWithBuyingRoles = WorkflowExpression.Compile(bodypropertieshsNumContactsWithBuyingRoles, nameof(bodypropertieshsNumContactsWithBuyingRoles), required: false);
            var __workflow_bodypropertieshsNumDecisionMakers = WorkflowExpression.Compile(bodypropertieshsNumDecisionMakers, nameof(bodypropertieshsNumDecisionMakers), required: false);
            var __workflow_bodypropertieshsNumOpenDeals = WorkflowExpression.Compile(bodypropertieshsNumOpenDeals, nameof(bodypropertieshsNumOpenDeals), required: false);
            var __workflow_bodypropertieshsObjectId = WorkflowExpression.Compile(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsParentCompanyId = WorkflowExpression.Compile(bodypropertieshsParentCompanyId, nameof(bodypropertieshsParentCompanyId), required: false);
            var __workflow_bodypropertieshsPredictivecontactscoreV2 = WorkflowExpression.Compile(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_bodypropertieshsTotalDealValue = WorkflowExpression.Compile(bodypropertieshsTotalDealValue, nameof(bodypropertieshsTotalDealValue), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesindustry = WorkflowExpression.Compile(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            var __workflow_bodypropertiesisPublic = WorkflowExpression.Compile(bodypropertiesisPublic, nameof(bodypropertiesisPublic), required: false);
            var __workflow_bodypropertieslifecyclestage = WorkflowExpression.Compile(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            var __workflow_bodypropertieslinkedinCompanyPage = WorkflowExpression.Compile(bodypropertieslinkedinCompanyPage, nameof(bodypropertieslinkedinCompanyPage), required: false);
            var __workflow_bodypropertieslinkedinbio = WorkflowExpression.Compile(bodypropertieslinkedinbio, nameof(bodypropertieslinkedinbio), required: false);
            var __workflow_bodypropertiesnotesLastContacted = WorkflowExpression.Compile(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = WorkflowExpression.Compile(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumAssociatedDeals = WorkflowExpression.Compile(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            var __workflow_bodypropertiesnumContactedNotes = WorkflowExpression.Compile(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumConversionEvents = WorkflowExpression.Compile(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            var __workflow_bodypropertiesnumberofemployees = WorkflowExpression.Compile(bodypropertiesnumberofemployees, nameof(bodypropertiesnumberofemployees), required: false);
            var __workflow_bodypropertiesphone = WorkflowExpression.Compile(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            var __workflow_bodypropertiesrecentConversionDate = WorkflowExpression.Compile(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            var __workflow_bodypropertiesrecentConversionEventName = WorkflowExpression.Compile(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            var __workflow_bodypropertiesrecentDealAmount = WorkflowExpression.Compile(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            var __workflow_bodypropertiesrecentDealCloseDate = WorkflowExpression.Compile(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            var __workflow_bodypropertiesstate = WorkflowExpression.Compile(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            var __workflow_bodypropertiestimezone = WorkflowExpression.Compile(bodypropertiestimezone, nameof(bodypropertiestimezone), required: false);
            var __workflow_bodypropertiestotalMoneyRaised = WorkflowExpression.Compile(bodypropertiestotalMoneyRaised, nameof(bodypropertiestotalMoneyRaised), required: false);
            var __workflow_bodypropertiestotalRevenue = WorkflowExpression.Compile(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            var __workflow_bodypropertiestwitterbio = WorkflowExpression.Compile(bodypropertiestwitterbio, nameof(bodypropertiestwitterbio), required: false);
            var __workflow_bodypropertiestwitterfollowers = WorkflowExpression.Compile(bodypropertiestwitterfollowers, nameof(bodypropertiestwitterfollowers), required: false);
            var __workflow_bodypropertiestwitterhandle = WorkflowExpression.Compile(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            var __workflow_bodypropertiestype = WorkflowExpression.Compile(bodypropertiestype, nameof(bodypropertiestype), required: false);
            var __workflow_bodypropertieswebTechnologies = WorkflowExpression.Compile(bodypropertieswebTechnologies, nameof(bodypropertieswebTechnologies), required: false);
            var __workflow_bodypropertieswebsite = WorkflowExpression.Compile(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            var __workflow_bodypropertieszip = WorkflowExpression.Compile(bodypropertieszip, nameof(bodypropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesaboutUs != null)
                {
                    propertiesObject["about_us"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdomain != null)
                {
                    propertiesObject["domain"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesname);
                if (__workflow_bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimezone != null)
                {
                    propertiesObject["timezone"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestype != null)
                {
                    propertiesObject["type"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestype);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = ExpressionConverter.ConvertO(__workflow_bodypropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(__workflow_bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypropertieszip);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesRead(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesArchive(Expression<Func<string>> companyId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesUpdate(Expression<Func<string>> companyId, Expression<Func<string>> propertiespropertiesname, Expression<Func<string>> propertiespropertiesaboutUs = null, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesaddress2 = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertiesdomain = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfacebookCompanyPage = null, Expression<Func<string>> propertiespropertiesfacebookfans = null, Expression<Func<string>> propertiespropertiesfirstContactCreatedate = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfoundedYear = null, Expression<Func<string>> propertiespropertiesgoogleplusPage = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsIdealCustomerProfile = null, Expression<Func<string>> propertiespropertieshsIsTargetAccount = null, Expression<Func<string>> propertiespropertieshsLastBookedMeetingDate = null, Expression<Func<string>> propertiespropertieshsLastLoggedCallDate = null, Expression<Func<string>> propertiespropertieshsLastOpenTaskDate = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsNumBlockers = null, Expression<Func<string>> propertiespropertieshsNumChildCompanies = null, Expression<Func<string>> propertiespropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> propertiespropertieshsNumDecisionMakers = null, Expression<Func<string>> propertiespropertieshsNumOpenDeals = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsParentCompanyId = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsTotalDealValue = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesisPublic = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertieslinkedinCompanyPage = null, Expression<Func<string>> propertiespropertieslinkedinbio = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedContacts = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumberofemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestimezone = null, Expression<Func<string>> propertiespropertiestotalMoneyRaised = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterbio = null, Expression<Func<string>> propertiespropertiestwitterfollowers = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertiestype = null, Expression<Func<string>> propertiespropertieswebTechnologies = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_propertiespropertiesname = WorkflowExpression.Compile(propertiespropertiesname, nameof(propertiespropertiesname), required: true);
            var __workflow_propertiespropertiesaboutUs = WorkflowExpression.Compile(propertiespropertiesaboutUs, nameof(propertiespropertiesaboutUs), required: false);
            var __workflow_propertiespropertiesaddress = WorkflowExpression.Compile(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            var __workflow_propertiespropertiesaddress2 = WorkflowExpression.Compile(propertiespropertiesaddress2, nameof(propertiespropertiesaddress2), required: false);
            var __workflow_propertiespropertiesannualrevenue = WorkflowExpression.Compile(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            var __workflow_propertiespropertiescity = WorkflowExpression.Compile(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            var __workflow_propertiespropertiesclosedate = WorkflowExpression.Compile(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            var __workflow_propertiespropertiescountry = WorkflowExpression.Compile(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            var __workflow_propertiespropertiescreatedate = WorkflowExpression.Compile(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiesdaysToClose = WorkflowExpression.Compile(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            var __workflow_propertiespropertiesdescription = WorkflowExpression.Compile(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            var __workflow_propertiespropertiesdomain = WorkflowExpression.Compile(propertiespropertiesdomain, nameof(propertiespropertiesdomain), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_propertiespropertiesfacebookCompanyPage = WorkflowExpression.Compile(propertiespropertiesfacebookCompanyPage, nameof(propertiespropertiesfacebookCompanyPage), required: false);
            var __workflow_propertiespropertiesfacebookfans = WorkflowExpression.Compile(propertiespropertiesfacebookfans, nameof(propertiespropertiesfacebookfans), required: false);
            var __workflow_propertiespropertiesfirstContactCreatedate = WorkflowExpression.Compile(propertiespropertiesfirstContactCreatedate, nameof(propertiespropertiesfirstContactCreatedate), required: false);
            var __workflow_propertiespropertiesfirstConversionDate = WorkflowExpression.Compile(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            var __workflow_propertiespropertiesfirstConversionEventName = WorkflowExpression.Compile(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            var __workflow_propertiespropertiesfirstDealCreatedDate = WorkflowExpression.Compile(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            var __workflow_propertiespropertiesfoundedYear = WorkflowExpression.Compile(propertiespropertiesfoundedYear, nameof(propertiespropertiesfoundedYear), required: false);
            var __workflow_propertiespropertiesgoogleplusPage = WorkflowExpression.Compile(propertiespropertiesgoogleplusPage, nameof(propertiespropertiesgoogleplusPage), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastVisitTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumPageViews = WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumVisits = WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            var __workflow_propertiespropertieshsAnalyticsSource = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            var __workflow_propertiespropertieshsCreatedate = WorkflowExpression.Compile(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsIdealCustomerProfile = WorkflowExpression.Compile(propertiespropertieshsIdealCustomerProfile, nameof(propertiespropertieshsIdealCustomerProfile), required: false);
            var __workflow_propertiespropertieshsIsTargetAccount = WorkflowExpression.Compile(propertiespropertieshsIsTargetAccount, nameof(propertiespropertieshsIsTargetAccount), required: false);
            var __workflow_propertiespropertieshsLastBookedMeetingDate = WorkflowExpression.Compile(propertiespropertieshsLastBookedMeetingDate, nameof(propertiespropertieshsLastBookedMeetingDate), required: false);
            var __workflow_propertiespropertieshsLastLoggedCallDate = WorkflowExpression.Compile(propertiespropertieshsLastLoggedCallDate, nameof(propertiespropertieshsLastLoggedCallDate), required: false);
            var __workflow_propertiespropertieshsLastOpenTaskDate = WorkflowExpression.Compile(propertiespropertieshsLastOpenTaskDate, nameof(propertiespropertieshsLastOpenTaskDate), required: false);
            var __workflow_propertiespropertieshsLastSalesActivityTimestamp = WorkflowExpression.Compile(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_propertiespropertieshsLastmodifieddate = WorkflowExpression.Compile(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            var __workflow_propertiespropertieshsLeadStatus = WorkflowExpression.Compile(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            var __workflow_propertiespropertieshsNumBlockers = WorkflowExpression.Compile(propertiespropertieshsNumBlockers, nameof(propertiespropertieshsNumBlockers), required: false);
            var __workflow_propertiespropertieshsNumChildCompanies = WorkflowExpression.Compile(propertiespropertieshsNumChildCompanies, nameof(propertiespropertieshsNumChildCompanies), required: false);
            var __workflow_propertiespropertieshsNumContactsWithBuyingRoles = WorkflowExpression.Compile(propertiespropertieshsNumContactsWithBuyingRoles, nameof(propertiespropertieshsNumContactsWithBuyingRoles), required: false);
            var __workflow_propertiespropertieshsNumDecisionMakers = WorkflowExpression.Compile(propertiespropertieshsNumDecisionMakers, nameof(propertiespropertieshsNumDecisionMakers), required: false);
            var __workflow_propertiespropertieshsNumOpenDeals = WorkflowExpression.Compile(propertiespropertieshsNumOpenDeals, nameof(propertiespropertieshsNumOpenDeals), required: false);
            var __workflow_propertiespropertieshsObjectId = WorkflowExpression.Compile(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsParentCompanyId = WorkflowExpression.Compile(propertiespropertieshsParentCompanyId, nameof(propertiespropertieshsParentCompanyId), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscoreV2 = WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_propertiespropertieshsTotalDealValue = WorkflowExpression.Compile(propertiespropertieshsTotalDealValue, nameof(propertiespropertieshsTotalDealValue), required: false);
            var __workflow_propertiespropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_propertiespropertieshubspotOwnerId = WorkflowExpression.Compile(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            var __workflow_propertiespropertieshubspotTeamId = WorkflowExpression.Compile(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            var __workflow_propertiespropertiesindustry = WorkflowExpression.Compile(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            var __workflow_propertiespropertiesisPublic = WorkflowExpression.Compile(propertiespropertiesisPublic, nameof(propertiespropertiesisPublic), required: false);
            var __workflow_propertiespropertieslifecyclestage = WorkflowExpression.Compile(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            var __workflow_propertiespropertieslinkedinCompanyPage = WorkflowExpression.Compile(propertiespropertieslinkedinCompanyPage, nameof(propertiespropertieslinkedinCompanyPage), required: false);
            var __workflow_propertiespropertieslinkedinbio = WorkflowExpression.Compile(propertiespropertieslinkedinbio, nameof(propertiespropertieslinkedinbio), required: false);
            var __workflow_propertiespropertiesnotesLastContacted = WorkflowExpression.Compile(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            var __workflow_propertiespropertiesnotesLastUpdated = WorkflowExpression.Compile(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            var __workflow_propertiespropertiesnotesNextActivityDate = WorkflowExpression.Compile(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            var __workflow_propertiespropertiesnumAssociatedContacts = WorkflowExpression.Compile(propertiespropertiesnumAssociatedContacts, nameof(propertiespropertiesnumAssociatedContacts), required: false);
            var __workflow_propertiespropertiesnumAssociatedDeals = WorkflowExpression.Compile(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            var __workflow_propertiespropertiesnumContactedNotes = WorkflowExpression.Compile(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            var __workflow_propertiespropertiesnumConversionEvents = WorkflowExpression.Compile(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            var __workflow_propertiespropertiesnumberofemployees = WorkflowExpression.Compile(propertiespropertiesnumberofemployees, nameof(propertiespropertiesnumberofemployees), required: false);
            var __workflow_propertiespropertiesphone = WorkflowExpression.Compile(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            var __workflow_propertiespropertiesrecentConversionDate = WorkflowExpression.Compile(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            var __workflow_propertiespropertiesrecentConversionEventName = WorkflowExpression.Compile(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            var __workflow_propertiespropertiesrecentDealAmount = WorkflowExpression.Compile(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            var __workflow_propertiespropertiesrecentDealCloseDate = WorkflowExpression.Compile(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            var __workflow_propertiespropertiesstate = WorkflowExpression.Compile(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            var __workflow_propertiespropertiestimezone = WorkflowExpression.Compile(propertiespropertiestimezone, nameof(propertiespropertiestimezone), required: false);
            var __workflow_propertiespropertiestotalMoneyRaised = WorkflowExpression.Compile(propertiespropertiestotalMoneyRaised, nameof(propertiespropertiestotalMoneyRaised), required: false);
            var __workflow_propertiespropertiestotalRevenue = WorkflowExpression.Compile(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            var __workflow_propertiespropertiestwitterbio = WorkflowExpression.Compile(propertiespropertiestwitterbio, nameof(propertiespropertiestwitterbio), required: false);
            var __workflow_propertiespropertiestwitterfollowers = WorkflowExpression.Compile(propertiespropertiestwitterfollowers, nameof(propertiespropertiestwitterfollowers), required: false);
            var __workflow_propertiespropertiestwitterhandle = WorkflowExpression.Compile(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            var __workflow_propertiespropertiestype = WorkflowExpression.Compile(propertiespropertiestype, nameof(propertiespropertiestype), required: false);
            var __workflow_propertiespropertieswebTechnologies = WorkflowExpression.Compile(propertiespropertieswebTechnologies, nameof(propertiespropertieswebTechnologies), required: false);
            var __workflow_propertiespropertieswebsite = WorkflowExpression.Compile(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            var __workflow_propertiespropertieszip = WorkflowExpression.Compile(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_propertiespropertiesaboutUs != null)
                {
                    propertiesObject["about_us"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdomain != null)
                {
                    propertiesObject["domain"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesname);
                if (__workflow_propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestimezone != null)
                {
                    propertiesObject["timezone"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestype != null)
                {
                    propertiesObject["type"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestype);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieszip);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    properties["properties"] = propertiesObject;
                    propertiespropCount++;
                }

                if (propertiespropCount > 0)
                {
                    callPayload.Body = properties;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties[]"] = ExpressionConverter.Convert(__workflow_properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsCreate(Expression<Func<string>> bodypropertiesaddress = null, Expression<Func<string>> bodypropertiesannualrevenue = null, Expression<Func<string>> bodypropertiescity = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescompany = null, Expression<Func<string>> bodypropertiescompanySize = null, Expression<Func<string>> bodypropertiescountry = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiescurrentlyinworkflow = null, Expression<Func<string>> bodypropertiesdateOfBirth = null, Expression<Func<string>> bodypropertiesdaysToClose = null, Expression<Func<string>> bodypropertiesdegree = null, Expression<Func<string>> bodypropertiesemail = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertiesfax = null, Expression<Func<string>> bodypropertiesfieldOfStudy = null, Expression<Func<string>> bodypropertiesfirstConversionDate = null, Expression<Func<string>> bodypropertiesfirstConversionEventName = null, Expression<Func<string>> bodypropertiesfirstDealCreatedDate = null, Expression<Func<string>> bodypropertiesfirstname = null, Expression<Func<string>> bodypropertiesgender = null, Expression<Func<string>> bodypropertiesgraduationDate = null, Expression<Func<string>> bodypropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsLastUrl = null, Expression<Func<string>> bodypropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> bodypropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsNumVisits = null, Expression<Func<string>> bodypropertieshsAnalyticsRevenue = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsBuyingRole = null, Expression<Func<string>> bodypropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> bodypropertieshsContentMembershipNotes = null, Expression<Func<string>> bodypropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> bodypropertieshsContentMembershipStatus = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsEmailBadAddress = null, Expression<Func<string>> bodypropertieshsEmailBounce = null, Expression<Func<string>> bodypropertieshsEmailClick = null, Expression<Func<string>> bodypropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> bodypropertieshsEmailDelivered = null, Expression<Func<string>> bodypropertieshsEmailDomain = null, Expression<Func<string>> bodypropertieshsEmailFirstClickDate = null, Expression<Func<string>> bodypropertieshsEmailFirstOpenDate = null, Expression<Func<string>> bodypropertieshsEmailFirstReplyDate = null, Expression<Func<string>> bodypropertieshsEmailFirstSendDate = null, Expression<Func<string>> bodypropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> bodypropertieshsEmailLastClickDate = null, Expression<Func<string>> bodypropertieshsEmailLastEmailName = null, Expression<Func<string>> bodypropertieshsEmailLastOpenDate = null, Expression<Func<string>> bodypropertieshsEmailLastReplyDate = null, Expression<Func<string>> bodypropertieshsEmailLastSendDate = null, Expression<Func<string>> bodypropertieshsEmailOpen = null, Expression<Func<string>> bodypropertieshsEmailOptout = null, Expression<Func<string>> bodypropertieshsEmailOptout12592317 = null, Expression<Func<string>> bodypropertieshsEmailQuarantined = null, Expression<Func<string>> bodypropertieshsEmailQuarantinedReason = null, Expression<Func<string>> bodypropertieshsEmailReplied = null, Expression<Func<string>> bodypropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> bodypropertieshsEmailconfirmationstatus = null, Expression<Func<string>> bodypropertieshsFacebookClickId = null, Expression<Func<string>> bodypropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsGoogleClickId = null, Expression<Func<string>> bodypropertieshsIpTimezone = null, Expression<Func<string>> bodypropertieshsIsUnworked = null, Expression<Func<string>> bodypropertieshsLanguage = null, Expression<Func<string>> bodypropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> bodypropertieshsLeadStatus = null, Expression<Func<string>> bodypropertieshsLegalBasis = null, Expression<Func<string>> bodypropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> bodypropertieshsMarketableReasonId = null, Expression<Func<string>> bodypropertieshsMarketableReasonType = null, Expression<Func<string>> bodypropertieshsMarketableStatus = null, Expression<Func<string>> bodypropertieshsMarketableUntilRenewal = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPersona = null, Expression<Func<string>> bodypropertieshsPredictivecontactscore = null, Expression<Func<string>> bodypropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> bodypropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> bodypropertieshsPredictivescoringtier = null, Expression<Func<string>> bodypropertieshsSalesEmailLastClicked = null, Expression<Func<string>> bodypropertieshsSalesEmailLastOpened = null, Expression<Func<string>> bodypropertieshsSalesEmailLastReplied = null, Expression<Func<string>> bodypropertieshsSequencesIsEnrolled = null, Expression<Func<string>> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertieshubspotscore = null, Expression<Func<string>> bodypropertiesindustry = null, Expression<Func<string>> bodypropertiesipCity = null, Expression<Func<string>> bodypropertiesipCountry = null, Expression<Func<string>> bodypropertiesipCountryCode = null, Expression<Func<string>> bodypropertiesipState = null, Expression<Func<string>> bodypropertiesipStateCode = null, Expression<Func<string>> bodypropertiesjobFunction = null, Expression<Func<string>> bodypropertiesjobtitle = null, Expression<Func<string>> bodypropertieslastmodifieddate = null, Expression<Func<string>> bodypropertieslastname = null, Expression<Func<string>> bodypropertieslifecyclestage = null, Expression<Func<string>> bodypropertiesmaritalStatus = null, Expression<Func<string>> bodypropertiesmessage = null, Expression<Func<string>> bodypropertiesmilitaryStatus = null, Expression<Func<string>> bodypropertiesmobilephone = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedDeals = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumConversionEvents = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiesnumUniqueConversionEvents = null, Expression<Func<string>> bodypropertiesnumemployees = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiesrecentConversionDate = null, Expression<Func<string>> bodypropertiesrecentConversionEventName = null, Expression<Func<string>> bodypropertiesrecentDealAmount = null, Expression<Func<string>> bodypropertiesrecentDealCloseDate = null, Expression<Func<string>> bodypropertiesrelationshipStatus = null, Expression<Func<string>> bodypropertiessalutation = null, Expression<Func<string>> bodypropertiesschool = null, Expression<Func<string>> bodypropertiesseniority = null, Expression<Func<string>> bodypropertiesstartDate = null, Expression<Func<string>> bodypropertiesstate = null, Expression<Func<string>> bodypropertiestotalRevenue = null, Expression<Func<string>> bodypropertiestwitterhandle = null, Expression<Func<string>> bodypropertieswebsite = null, Expression<Func<string>> bodypropertiesworkEmail = null, Expression<Func<string>> bodypropertieszip = null)
        {
            var __workflow_bodypropertiesaddress = WorkflowExpression.Compile(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            var __workflow_bodypropertiesannualrevenue = WorkflowExpression.Compile(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            var __workflow_bodypropertiescity = WorkflowExpression.Compile(bodypropertiescity, nameof(bodypropertiescity), required: false);
            var __workflow_bodypropertiesclosedate = WorkflowExpression.Compile(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescompany = WorkflowExpression.Compile(bodypropertiescompany, nameof(bodypropertiescompany), required: false);
            var __workflow_bodypropertiescompanySize = WorkflowExpression.Compile(bodypropertiescompanySize, nameof(bodypropertiescompanySize), required: false);
            var __workflow_bodypropertiescountry = WorkflowExpression.Compile(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiescurrentlyinworkflow = WorkflowExpression.Compile(bodypropertiescurrentlyinworkflow, nameof(bodypropertiescurrentlyinworkflow), required: false);
            var __workflow_bodypropertiesdateOfBirth = WorkflowExpression.Compile(bodypropertiesdateOfBirth, nameof(bodypropertiesdateOfBirth), required: false);
            var __workflow_bodypropertiesdaysToClose = WorkflowExpression.Compile(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            var __workflow_bodypropertiesdegree = WorkflowExpression.Compile(bodypropertiesdegree, nameof(bodypropertiesdegree), required: false);
            var __workflow_bodypropertiesemail = WorkflowExpression.Compile(bodypropertiesemail, nameof(bodypropertiesemail), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertiesfax = WorkflowExpression.Compile(bodypropertiesfax, nameof(bodypropertiesfax), required: false);
            var __workflow_bodypropertiesfieldOfStudy = WorkflowExpression.Compile(bodypropertiesfieldOfStudy, nameof(bodypropertiesfieldOfStudy), required: false);
            var __workflow_bodypropertiesfirstConversionDate = WorkflowExpression.Compile(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            var __workflow_bodypropertiesfirstConversionEventName = WorkflowExpression.Compile(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            var __workflow_bodypropertiesfirstDealCreatedDate = WorkflowExpression.Compile(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            var __workflow_bodypropertiesfirstname = WorkflowExpression.Compile(bodypropertiesfirstname, nameof(bodypropertiesfirstname), required: false);
            var __workflow_bodypropertiesgender = WorkflowExpression.Compile(bodypropertiesgender, nameof(bodypropertiesgender), required: false);
            var __workflow_bodypropertiesgraduationDate = WorkflowExpression.Compile(bodypropertiesgraduationDate, nameof(bodypropertiesgraduationDate), required: false);
            var __workflow_bodypropertieshsAnalyticsAveragePageViews = WorkflowExpression.Compile(bodypropertieshsAnalyticsAveragePageViews, nameof(bodypropertieshsAnalyticsAveragePageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstReferrer = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstReferrer, nameof(bodypropertieshsAnalyticsFirstReferrer), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstUrl = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstUrl, nameof(bodypropertieshsAnalyticsFirstUrl), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstVisitTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastReferrer = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastReferrer, nameof(bodypropertieshsAnalyticsLastReferrer), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsLastUrl = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastUrl, nameof(bodypropertieshsAnalyticsLastUrl), required: false);
            var __workflow_bodypropertieshsAnalyticsLastVisitTimestamp = WorkflowExpression.Compile(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsNumEventCompletions = WorkflowExpression.Compile(bodypropertieshsAnalyticsNumEventCompletions, nameof(bodypropertieshsAnalyticsNumEventCompletions), required: false);
            var __workflow_bodypropertieshsAnalyticsNumPageViews = WorkflowExpression.Compile(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsNumVisits = WorkflowExpression.Compile(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            var __workflow_bodypropertieshsAnalyticsRevenue = WorkflowExpression.Compile(bodypropertieshsAnalyticsRevenue, nameof(bodypropertieshsAnalyticsRevenue), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = WorkflowExpression.Compile(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsBuyingRole = WorkflowExpression.Compile(bodypropertieshsBuyingRole, nameof(bodypropertieshsBuyingRole), required: false);
            var __workflow_bodypropertieshsContentMembershipEmailConfirmed = WorkflowExpression.Compile(bodypropertieshsContentMembershipEmailConfirmed, nameof(bodypropertieshsContentMembershipEmailConfirmed), required: false);
            var __workflow_bodypropertieshsContentMembershipNotes = WorkflowExpression.Compile(bodypropertieshsContentMembershipNotes, nameof(bodypropertieshsContentMembershipNotes), required: false);
            var __workflow_bodypropertieshsContentMembershipRegisteredAt = WorkflowExpression.Compile(bodypropertieshsContentMembershipRegisteredAt, nameof(bodypropertieshsContentMembershipRegisteredAt), required: false);
            var __workflow_bodypropertieshsContentMembershipRegistrationDomainSentTo = WorkflowExpression.Compile(bodypropertieshsContentMembershipRegistrationDomainSentTo, nameof(bodypropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            var __workflow_bodypropertieshsContentMembershipRegistrationEmailSentAt = WorkflowExpression.Compile(bodypropertieshsContentMembershipRegistrationEmailSentAt, nameof(bodypropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            var __workflow_bodypropertieshsContentMembershipStatus = WorkflowExpression.Compile(bodypropertieshsContentMembershipStatus, nameof(bodypropertieshsContentMembershipStatus), required: false);
            var __workflow_bodypropertieshsCreatedate = WorkflowExpression.Compile(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsEmailBadAddress = WorkflowExpression.Compile(bodypropertieshsEmailBadAddress, nameof(bodypropertieshsEmailBadAddress), required: false);
            var __workflow_bodypropertieshsEmailBounce = WorkflowExpression.Compile(bodypropertieshsEmailBounce, nameof(bodypropertieshsEmailBounce), required: false);
            var __workflow_bodypropertieshsEmailClick = WorkflowExpression.Compile(bodypropertieshsEmailClick, nameof(bodypropertieshsEmailClick), required: false);
            var __workflow_bodypropertieshsEmailCustomerQuarantinedReason = WorkflowExpression.Compile(bodypropertieshsEmailCustomerQuarantinedReason, nameof(bodypropertieshsEmailCustomerQuarantinedReason), required: false);
            var __workflow_bodypropertieshsEmailDelivered = WorkflowExpression.Compile(bodypropertieshsEmailDelivered, nameof(bodypropertieshsEmailDelivered), required: false);
            var __workflow_bodypropertieshsEmailDomain = WorkflowExpression.Compile(bodypropertieshsEmailDomain, nameof(bodypropertieshsEmailDomain), required: false);
            var __workflow_bodypropertieshsEmailFirstClickDate = WorkflowExpression.Compile(bodypropertieshsEmailFirstClickDate, nameof(bodypropertieshsEmailFirstClickDate), required: false);
            var __workflow_bodypropertieshsEmailFirstOpenDate = WorkflowExpression.Compile(bodypropertieshsEmailFirstOpenDate, nameof(bodypropertieshsEmailFirstOpenDate), required: false);
            var __workflow_bodypropertieshsEmailFirstReplyDate = WorkflowExpression.Compile(bodypropertieshsEmailFirstReplyDate, nameof(bodypropertieshsEmailFirstReplyDate), required: false);
            var __workflow_bodypropertieshsEmailFirstSendDate = WorkflowExpression.Compile(bodypropertieshsEmailFirstSendDate, nameof(bodypropertieshsEmailFirstSendDate), required: false);
            var __workflow_bodypropertieshsEmailHardBounceReasonEnum = WorkflowExpression.Compile(bodypropertieshsEmailHardBounceReasonEnum, nameof(bodypropertieshsEmailHardBounceReasonEnum), required: false);
            var __workflow_bodypropertieshsEmailLastClickDate = WorkflowExpression.Compile(bodypropertieshsEmailLastClickDate, nameof(bodypropertieshsEmailLastClickDate), required: false);
            var __workflow_bodypropertieshsEmailLastEmailName = WorkflowExpression.Compile(bodypropertieshsEmailLastEmailName, nameof(bodypropertieshsEmailLastEmailName), required: false);
            var __workflow_bodypropertieshsEmailLastOpenDate = WorkflowExpression.Compile(bodypropertieshsEmailLastOpenDate, nameof(bodypropertieshsEmailLastOpenDate), required: false);
            var __workflow_bodypropertieshsEmailLastReplyDate = WorkflowExpression.Compile(bodypropertieshsEmailLastReplyDate, nameof(bodypropertieshsEmailLastReplyDate), required: false);
            var __workflow_bodypropertieshsEmailLastSendDate = WorkflowExpression.Compile(bodypropertieshsEmailLastSendDate, nameof(bodypropertieshsEmailLastSendDate), required: false);
            var __workflow_bodypropertieshsEmailOpen = WorkflowExpression.Compile(bodypropertieshsEmailOpen, nameof(bodypropertieshsEmailOpen), required: false);
            var __workflow_bodypropertieshsEmailOptout = WorkflowExpression.Compile(bodypropertieshsEmailOptout, nameof(bodypropertieshsEmailOptout), required: false);
            var __workflow_bodypropertieshsEmailOptout12592317 = WorkflowExpression.Compile(bodypropertieshsEmailOptout12592317, nameof(bodypropertieshsEmailOptout12592317), required: false);
            var __workflow_bodypropertieshsEmailQuarantined = WorkflowExpression.Compile(bodypropertieshsEmailQuarantined, nameof(bodypropertieshsEmailQuarantined), required: false);
            var __workflow_bodypropertieshsEmailQuarantinedReason = WorkflowExpression.Compile(bodypropertieshsEmailQuarantinedReason, nameof(bodypropertieshsEmailQuarantinedReason), required: false);
            var __workflow_bodypropertieshsEmailReplied = WorkflowExpression.Compile(bodypropertieshsEmailReplied, nameof(bodypropertieshsEmailReplied), required: false);
            var __workflow_bodypropertieshsEmailSendsSinceLastEngagement = WorkflowExpression.Compile(bodypropertieshsEmailSendsSinceLastEngagement, nameof(bodypropertieshsEmailSendsSinceLastEngagement), required: false);
            var __workflow_bodypropertieshsEmailconfirmationstatus = WorkflowExpression.Compile(bodypropertieshsEmailconfirmationstatus, nameof(bodypropertieshsEmailconfirmationstatus), required: false);
            var __workflow_bodypropertieshsFacebookClickId = WorkflowExpression.Compile(bodypropertieshsFacebookClickId, nameof(bodypropertieshsFacebookClickId), required: false);
            var __workflow_bodypropertieshsFeedbackLastNpsFollowUp = WorkflowExpression.Compile(bodypropertieshsFeedbackLastNpsFollowUp, nameof(bodypropertieshsFeedbackLastNpsFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastNpsRating = WorkflowExpression.Compile(bodypropertieshsFeedbackLastNpsRating, nameof(bodypropertieshsFeedbackLastNpsRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsGoogleClickId = WorkflowExpression.Compile(bodypropertieshsGoogleClickId, nameof(bodypropertieshsGoogleClickId), required: false);
            var __workflow_bodypropertieshsIpTimezone = WorkflowExpression.Compile(bodypropertieshsIpTimezone, nameof(bodypropertieshsIpTimezone), required: false);
            var __workflow_bodypropertieshsIsUnworked = WorkflowExpression.Compile(bodypropertieshsIsUnworked, nameof(bodypropertieshsIsUnworked), required: false);
            var __workflow_bodypropertieshsLanguage = WorkflowExpression.Compile(bodypropertieshsLanguage, nameof(bodypropertieshsLanguage), required: false);
            var __workflow_bodypropertieshsLastSalesActivityTimestamp = WorkflowExpression.Compile(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_bodypropertieshsLeadStatus = WorkflowExpression.Compile(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            var __workflow_bodypropertieshsLegalBasis = WorkflowExpression.Compile(bodypropertieshsLegalBasis, nameof(bodypropertieshsLegalBasis), required: false);
            var __workflow_bodypropertieshsLifecyclestageCustomerDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageCustomerDate, nameof(bodypropertieshsLifecyclestageCustomerDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageEvangelistDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageEvangelistDate, nameof(bodypropertieshsLifecyclestageEvangelistDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageLeadDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageLeadDate, nameof(bodypropertieshsLifecyclestageLeadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageMarketingqualifiedleadDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(bodypropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageOpportunityDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageOpportunityDate, nameof(bodypropertieshsLifecyclestageOpportunityDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageOtherDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageOtherDate, nameof(bodypropertieshsLifecyclestageOtherDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageSalesqualifiedleadDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageSalesqualifiedleadDate, nameof(bodypropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageSubscriberDate = WorkflowExpression.Compile(bodypropertieshsLifecyclestageSubscriberDate, nameof(bodypropertieshsLifecyclestageSubscriberDate), required: false);
            var __workflow_bodypropertieshsMarketableReasonId = WorkflowExpression.Compile(bodypropertieshsMarketableReasonId, nameof(bodypropertieshsMarketableReasonId), required: false);
            var __workflow_bodypropertieshsMarketableReasonType = WorkflowExpression.Compile(bodypropertieshsMarketableReasonType, nameof(bodypropertieshsMarketableReasonType), required: false);
            var __workflow_bodypropertieshsMarketableStatus = WorkflowExpression.Compile(bodypropertieshsMarketableStatus, nameof(bodypropertieshsMarketableStatus), required: false);
            var __workflow_bodypropertieshsMarketableUntilRenewal = WorkflowExpression.Compile(bodypropertieshsMarketableUntilRenewal, nameof(bodypropertieshsMarketableUntilRenewal), required: false);
            var __workflow_bodypropertieshsObjectId = WorkflowExpression.Compile(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPersona = WorkflowExpression.Compile(bodypropertieshsPersona, nameof(bodypropertieshsPersona), required: false);
            var __workflow_bodypropertieshsPredictivecontactscore = WorkflowExpression.Compile(bodypropertieshsPredictivecontactscore, nameof(bodypropertieshsPredictivecontactscore), required: false);
            var __workflow_bodypropertieshsPredictivecontactscoreV2 = WorkflowExpression.Compile(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_bodypropertieshsPredictivecontactscorebucket = WorkflowExpression.Compile(bodypropertieshsPredictivecontactscorebucket, nameof(bodypropertieshsPredictivecontactscorebucket), required: false);
            var __workflow_bodypropertieshsPredictivescoringtier = WorkflowExpression.Compile(bodypropertieshsPredictivescoringtier, nameof(bodypropertieshsPredictivescoringtier), required: false);
            var __workflow_bodypropertieshsSalesEmailLastClicked = WorkflowExpression.Compile(bodypropertieshsSalesEmailLastClicked, nameof(bodypropertieshsSalesEmailLastClicked), required: false);
            var __workflow_bodypropertieshsSalesEmailLastOpened = WorkflowExpression.Compile(bodypropertieshsSalesEmailLastOpened, nameof(bodypropertieshsSalesEmailLastOpened), required: false);
            var __workflow_bodypropertieshsSalesEmailLastReplied = WorkflowExpression.Compile(bodypropertieshsSalesEmailLastReplied, nameof(bodypropertieshsSalesEmailLastReplied), required: false);
            var __workflow_bodypropertieshsSequencesIsEnrolled = WorkflowExpression.Compile(bodypropertieshsSequencesIsEnrolled, nameof(bodypropertieshsSequencesIsEnrolled), required: false);
            var __workflow_bodypropertieshsTimeBetweenContactCreationAndDealClose = WorkflowExpression.Compile(bodypropertieshsTimeBetweenContactCreationAndDealClose, nameof(bodypropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            var __workflow_bodypropertieshsTimeBetweenContactCreationAndDealCreation = WorkflowExpression.Compile(bodypropertieshsTimeBetweenContactCreationAndDealCreation, nameof(bodypropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromLeadToCustomer = WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromLeadToCustomer, nameof(bodypropertieshsTimeToMoveFromLeadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromOpportunityToCustomer = WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromOpportunityToCustomer, nameof(bodypropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromSubscriberToCustomer = WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromSubscriberToCustomer, nameof(bodypropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertieshubspotscore = WorkflowExpression.Compile(bodypropertieshubspotscore, nameof(bodypropertieshubspotscore), required: false);
            var __workflow_bodypropertiesindustry = WorkflowExpression.Compile(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            var __workflow_bodypropertiesipCity = WorkflowExpression.Compile(bodypropertiesipCity, nameof(bodypropertiesipCity), required: false);
            var __workflow_bodypropertiesipCountry = WorkflowExpression.Compile(bodypropertiesipCountry, nameof(bodypropertiesipCountry), required: false);
            var __workflow_bodypropertiesipCountryCode = WorkflowExpression.Compile(bodypropertiesipCountryCode, nameof(bodypropertiesipCountryCode), required: false);
            var __workflow_bodypropertiesipState = WorkflowExpression.Compile(bodypropertiesipState, nameof(bodypropertiesipState), required: false);
            var __workflow_bodypropertiesipStateCode = WorkflowExpression.Compile(bodypropertiesipStateCode, nameof(bodypropertiesipStateCode), required: false);
            var __workflow_bodypropertiesjobFunction = WorkflowExpression.Compile(bodypropertiesjobFunction, nameof(bodypropertiesjobFunction), required: false);
            var __workflow_bodypropertiesjobtitle = WorkflowExpression.Compile(bodypropertiesjobtitle, nameof(bodypropertiesjobtitle), required: false);
            var __workflow_bodypropertieslastmodifieddate = WorkflowExpression.Compile(bodypropertieslastmodifieddate, nameof(bodypropertieslastmodifieddate), required: false);
            var __workflow_bodypropertieslastname = WorkflowExpression.Compile(bodypropertieslastname, nameof(bodypropertieslastname), required: false);
            var __workflow_bodypropertieslifecyclestage = WorkflowExpression.Compile(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            var __workflow_bodypropertiesmaritalStatus = WorkflowExpression.Compile(bodypropertiesmaritalStatus, nameof(bodypropertiesmaritalStatus), required: false);
            var __workflow_bodypropertiesmessage = WorkflowExpression.Compile(bodypropertiesmessage, nameof(bodypropertiesmessage), required: false);
            var __workflow_bodypropertiesmilitaryStatus = WorkflowExpression.Compile(bodypropertiesmilitaryStatus, nameof(bodypropertiesmilitaryStatus), required: false);
            var __workflow_bodypropertiesmobilephone = WorkflowExpression.Compile(bodypropertiesmobilephone, nameof(bodypropertiesmobilephone), required: false);
            var __workflow_bodypropertiesnotesLastContacted = WorkflowExpression.Compile(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = WorkflowExpression.Compile(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedDeals = WorkflowExpression.Compile(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            var __workflow_bodypropertiesnumContactedNotes = WorkflowExpression.Compile(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumConversionEvents = WorkflowExpression.Compile(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            var __workflow_bodypropertiesnumNotes = WorkflowExpression.Compile(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiesnumUniqueConversionEvents = WorkflowExpression.Compile(bodypropertiesnumUniqueConversionEvents, nameof(bodypropertiesnumUniqueConversionEvents), required: false);
            var __workflow_bodypropertiesnumemployees = WorkflowExpression.Compile(bodypropertiesnumemployees, nameof(bodypropertiesnumemployees), required: false);
            var __workflow_bodypropertiesphone = WorkflowExpression.Compile(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            var __workflow_bodypropertiesrecentConversionDate = WorkflowExpression.Compile(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            var __workflow_bodypropertiesrecentConversionEventName = WorkflowExpression.Compile(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            var __workflow_bodypropertiesrecentDealAmount = WorkflowExpression.Compile(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            var __workflow_bodypropertiesrecentDealCloseDate = WorkflowExpression.Compile(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            var __workflow_bodypropertiesrelationshipStatus = WorkflowExpression.Compile(bodypropertiesrelationshipStatus, nameof(bodypropertiesrelationshipStatus), required: false);
            var __workflow_bodypropertiessalutation = WorkflowExpression.Compile(bodypropertiessalutation, nameof(bodypropertiessalutation), required: false);
            var __workflow_bodypropertiesschool = WorkflowExpression.Compile(bodypropertiesschool, nameof(bodypropertiesschool), required: false);
            var __workflow_bodypropertiesseniority = WorkflowExpression.Compile(bodypropertiesseniority, nameof(bodypropertiesseniority), required: false);
            var __workflow_bodypropertiesstartDate = WorkflowExpression.Compile(bodypropertiesstartDate, nameof(bodypropertiesstartDate), required: false);
            var __workflow_bodypropertiesstate = WorkflowExpression.Compile(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            var __workflow_bodypropertiestotalRevenue = WorkflowExpression.Compile(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            var __workflow_bodypropertiestwitterhandle = WorkflowExpression.Compile(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            var __workflow_bodypropertieswebsite = WorkflowExpression.Compile(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            var __workflow_bodypropertiesworkEmail = WorkflowExpression.Compile(bodypropertiesworkEmail, nameof(bodypropertiesworkEmail), required: false);
            var __workflow_bodypropertieszip = WorkflowExpression.Compile(bodypropertieszip, nameof(bodypropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescompany != null)
                {
                    propertiesObject["company"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdegree != null)
                {
                    propertiesObject["degree"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesemail != null)
                {
                    propertiesObject["email"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfax != null)
                {
                    propertiesObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesgender != null)
                {
                    propertiesObject["gender"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesipState != null)
                {
                    propertiesObject["ip_state"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslastname != null)
                {
                    propertiesObject["lastname"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesmessage != null)
                {
                    propertiesObject["message"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiessalutation != null)
                {
                    propertiesObject["salutation"] = ExpressionConverter.ConvertO(__workflow_bodypropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesschool != null)
                {
                    propertiesObject["school"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesseniority != null)
                {
                    propertiesObject["seniority"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(__workflow_bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodypropertieszip);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsRead(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsArchive(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsUpdate(Expression<Func<string>> contactId, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescompany = null, Expression<Func<string>> propertiespropertiescompanySize = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiescurrentlyinworkflow = null, Expression<Func<string>> propertiespropertiesdateOfBirth = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdegree = null, Expression<Func<string>> propertiespropertiesemail = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfax = null, Expression<Func<string>> propertiespropertiesfieldOfStudy = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfirstname = null, Expression<Func<string>> propertiespropertiesgender = null, Expression<Func<string>> propertiespropertiesgraduationDate = null, Expression<Func<string>> propertiespropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsRevenue = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsBuyingRole = null, Expression<Func<string>> propertiespropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> propertiespropertieshsContentMembershipNotes = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipStatus = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsEmailBadAddress = null, Expression<Func<string>> propertiespropertieshsEmailBounce = null, Expression<Func<string>> propertiespropertieshsEmailClick = null, Expression<Func<string>> propertiespropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailDelivered = null, Expression<Func<string>> propertiespropertieshsEmailDomain = null, Expression<Func<string>> propertiespropertieshsEmailFirstClickDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstSendDate = null, Expression<Func<string>> propertiespropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> propertiespropertieshsEmailLastClickDate = null, Expression<Func<string>> propertiespropertieshsEmailLastEmailName = null, Expression<Func<string>> propertiespropertieshsEmailLastOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailLastReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailLastSendDate = null, Expression<Func<string>> propertiespropertieshsEmailOpen = null, Expression<Func<string>> propertiespropertieshsEmailOptout = null, Expression<Func<string>> propertiespropertieshsEmailOptout12592317 = null, Expression<Func<string>> propertiespropertieshsEmailQuarantined = null, Expression<Func<string>> propertiespropertieshsEmailQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailReplied = null, Expression<Func<string>> propertiespropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> propertiespropertieshsEmailconfirmationstatus = null, Expression<Func<string>> propertiespropertieshsFacebookClickId = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> propertiespropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> propertiespropertieshsGoogleClickId = null, Expression<Func<string>> propertiespropertieshsIpTimezone = null, Expression<Func<string>> propertiespropertieshsIsUnworked = null, Expression<Func<string>> propertiespropertieshsLanguage = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsLegalBasis = null, Expression<Func<string>> propertiespropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> propertiespropertieshsMarketableReasonId = null, Expression<Func<string>> propertiespropertieshsMarketableReasonType = null, Expression<Func<string>> propertiespropertieshsMarketableStatus = null, Expression<Func<string>> propertiespropertieshsMarketableUntilRenewal = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsPersona = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscore = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> propertiespropertieshsPredictivescoringtier = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastClicked = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastOpened = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastReplied = null, Expression<Func<string>> propertiespropertieshsSequencesIsEnrolled = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertieshubspotscore = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesipCity = null, Expression<Func<string>> propertiespropertiesipCountry = null, Expression<Func<string>> propertiespropertiesipCountryCode = null, Expression<Func<string>> propertiespropertiesipState = null, Expression<Func<string>> propertiespropertiesipStateCode = null, Expression<Func<string>> propertiespropertiesjobFunction = null, Expression<Func<string>> propertiespropertiesjobtitle = null, Expression<Func<string>> propertiespropertieslastmodifieddate = null, Expression<Func<string>> propertiespropertieslastname = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertiesmaritalStatus = null, Expression<Func<string>> propertiespropertiesmessage = null, Expression<Func<string>> propertiespropertiesmilitaryStatus = null, Expression<Func<string>> propertiespropertiesmobilephone = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumNotes = null, Expression<Func<string>> propertiespropertiesnumUniqueConversionEvents = null, Expression<Func<string>> propertiespropertiesnumemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesrelationshipStatus = null, Expression<Func<string>> propertiespropertiessalutation = null, Expression<Func<string>> propertiespropertiesschool = null, Expression<Func<string>> propertiespropertiesseniority = null, Expression<Func<string>> propertiespropertiesstartDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertiesworkEmail = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_propertiespropertiesaddress = WorkflowExpression.Compile(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            var __workflow_propertiespropertiesannualrevenue = WorkflowExpression.Compile(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            var __workflow_propertiespropertiescity = WorkflowExpression.Compile(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            var __workflow_propertiespropertiesclosedate = WorkflowExpression.Compile(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            var __workflow_propertiespropertiescompany = WorkflowExpression.Compile(propertiespropertiescompany, nameof(propertiespropertiescompany), required: false);
            var __workflow_propertiespropertiescompanySize = WorkflowExpression.Compile(propertiespropertiescompanySize, nameof(propertiespropertiescompanySize), required: false);
            var __workflow_propertiespropertiescountry = WorkflowExpression.Compile(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            var __workflow_propertiespropertiescreatedate = WorkflowExpression.Compile(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiescurrentlyinworkflow = WorkflowExpression.Compile(propertiespropertiescurrentlyinworkflow, nameof(propertiespropertiescurrentlyinworkflow), required: false);
            var __workflow_propertiespropertiesdateOfBirth = WorkflowExpression.Compile(propertiespropertiesdateOfBirth, nameof(propertiespropertiesdateOfBirth), required: false);
            var __workflow_propertiespropertiesdaysToClose = WorkflowExpression.Compile(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            var __workflow_propertiespropertiesdegree = WorkflowExpression.Compile(propertiespropertiesdegree, nameof(propertiespropertiesdegree), required: false);
            var __workflow_propertiespropertiesemail = WorkflowExpression.Compile(propertiespropertiesemail, nameof(propertiespropertiesemail), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_propertiespropertiesfax = WorkflowExpression.Compile(propertiespropertiesfax, nameof(propertiespropertiesfax), required: false);
            var __workflow_propertiespropertiesfieldOfStudy = WorkflowExpression.Compile(propertiespropertiesfieldOfStudy, nameof(propertiespropertiesfieldOfStudy), required: false);
            var __workflow_propertiespropertiesfirstConversionDate = WorkflowExpression.Compile(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            var __workflow_propertiespropertiesfirstConversionEventName = WorkflowExpression.Compile(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            var __workflow_propertiespropertiesfirstDealCreatedDate = WorkflowExpression.Compile(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            var __workflow_propertiespropertiesfirstname = WorkflowExpression.Compile(propertiespropertiesfirstname, nameof(propertiespropertiesfirstname), required: false);
            var __workflow_propertiespropertiesgender = WorkflowExpression.Compile(propertiespropertiesgender, nameof(propertiespropertiesgender), required: false);
            var __workflow_propertiespropertiesgraduationDate = WorkflowExpression.Compile(propertiespropertiesgraduationDate, nameof(propertiespropertiesgraduationDate), required: false);
            var __workflow_propertiespropertieshsAnalyticsAveragePageViews = WorkflowExpression.Compile(propertiespropertieshsAnalyticsAveragePageViews, nameof(propertiespropertieshsAnalyticsAveragePageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstReferrer = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstReferrer, nameof(propertiespropertieshsAnalyticsFirstReferrer), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstUrl = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstUrl, nameof(propertiespropertieshsAnalyticsFirstUrl), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastReferrer = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastReferrer, nameof(propertiespropertieshsAnalyticsLastReferrer), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastUrl = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastUrl, nameof(propertiespropertieshsAnalyticsLastUrl), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastVisitTimestamp = WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumEventCompletions = WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumEventCompletions, nameof(propertiespropertieshsAnalyticsNumEventCompletions), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumPageViews = WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumVisits = WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            var __workflow_propertiespropertieshsAnalyticsRevenue = WorkflowExpression.Compile(propertiespropertieshsAnalyticsRevenue, nameof(propertiespropertieshsAnalyticsRevenue), required: false);
            var __workflow_propertiespropertieshsAnalyticsSource = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            var __workflow_propertiespropertieshsBuyingRole = WorkflowExpression.Compile(propertiespropertieshsBuyingRole, nameof(propertiespropertieshsBuyingRole), required: false);
            var __workflow_propertiespropertieshsContentMembershipEmailConfirmed = WorkflowExpression.Compile(propertiespropertieshsContentMembershipEmailConfirmed, nameof(propertiespropertieshsContentMembershipEmailConfirmed), required: false);
            var __workflow_propertiespropertieshsContentMembershipNotes = WorkflowExpression.Compile(propertiespropertieshsContentMembershipNotes, nameof(propertiespropertieshsContentMembershipNotes), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegisteredAt = WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegisteredAt, nameof(propertiespropertieshsContentMembershipRegisteredAt), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegistrationDomainSentTo = WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegistrationDomainSentTo, nameof(propertiespropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegistrationEmailSentAt = WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegistrationEmailSentAt, nameof(propertiespropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            var __workflow_propertiespropertieshsContentMembershipStatus = WorkflowExpression.Compile(propertiespropertieshsContentMembershipStatus, nameof(propertiespropertieshsContentMembershipStatus), required: false);
            var __workflow_propertiespropertieshsCreatedate = WorkflowExpression.Compile(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsEmailBadAddress = WorkflowExpression.Compile(propertiespropertieshsEmailBadAddress, nameof(propertiespropertieshsEmailBadAddress), required: false);
            var __workflow_propertiespropertieshsEmailBounce = WorkflowExpression.Compile(propertiespropertieshsEmailBounce, nameof(propertiespropertieshsEmailBounce), required: false);
            var __workflow_propertiespropertieshsEmailClick = WorkflowExpression.Compile(propertiespropertieshsEmailClick, nameof(propertiespropertieshsEmailClick), required: false);
            var __workflow_propertiespropertieshsEmailCustomerQuarantinedReason = WorkflowExpression.Compile(propertiespropertieshsEmailCustomerQuarantinedReason, nameof(propertiespropertieshsEmailCustomerQuarantinedReason), required: false);
            var __workflow_propertiespropertieshsEmailDelivered = WorkflowExpression.Compile(propertiespropertieshsEmailDelivered, nameof(propertiespropertieshsEmailDelivered), required: false);
            var __workflow_propertiespropertieshsEmailDomain = WorkflowExpression.Compile(propertiespropertieshsEmailDomain, nameof(propertiespropertieshsEmailDomain), required: false);
            var __workflow_propertiespropertieshsEmailFirstClickDate = WorkflowExpression.Compile(propertiespropertieshsEmailFirstClickDate, nameof(propertiespropertieshsEmailFirstClickDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstOpenDate = WorkflowExpression.Compile(propertiespropertieshsEmailFirstOpenDate, nameof(propertiespropertieshsEmailFirstOpenDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstReplyDate = WorkflowExpression.Compile(propertiespropertieshsEmailFirstReplyDate, nameof(propertiespropertieshsEmailFirstReplyDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstSendDate = WorkflowExpression.Compile(propertiespropertieshsEmailFirstSendDate, nameof(propertiespropertieshsEmailFirstSendDate), required: false);
            var __workflow_propertiespropertieshsEmailHardBounceReasonEnum = WorkflowExpression.Compile(propertiespropertieshsEmailHardBounceReasonEnum, nameof(propertiespropertieshsEmailHardBounceReasonEnum), required: false);
            var __workflow_propertiespropertieshsEmailLastClickDate = WorkflowExpression.Compile(propertiespropertieshsEmailLastClickDate, nameof(propertiespropertieshsEmailLastClickDate), required: false);
            var __workflow_propertiespropertieshsEmailLastEmailName = WorkflowExpression.Compile(propertiespropertieshsEmailLastEmailName, nameof(propertiespropertieshsEmailLastEmailName), required: false);
            var __workflow_propertiespropertieshsEmailLastOpenDate = WorkflowExpression.Compile(propertiespropertieshsEmailLastOpenDate, nameof(propertiespropertieshsEmailLastOpenDate), required: false);
            var __workflow_propertiespropertieshsEmailLastReplyDate = WorkflowExpression.Compile(propertiespropertieshsEmailLastReplyDate, nameof(propertiespropertieshsEmailLastReplyDate), required: false);
            var __workflow_propertiespropertieshsEmailLastSendDate = WorkflowExpression.Compile(propertiespropertieshsEmailLastSendDate, nameof(propertiespropertieshsEmailLastSendDate), required: false);
            var __workflow_propertiespropertieshsEmailOpen = WorkflowExpression.Compile(propertiespropertieshsEmailOpen, nameof(propertiespropertieshsEmailOpen), required: false);
            var __workflow_propertiespropertieshsEmailOptout = WorkflowExpression.Compile(propertiespropertieshsEmailOptout, nameof(propertiespropertieshsEmailOptout), required: false);
            var __workflow_propertiespropertieshsEmailOptout12592317 = WorkflowExpression.Compile(propertiespropertieshsEmailOptout12592317, nameof(propertiespropertieshsEmailOptout12592317), required: false);
            var __workflow_propertiespropertieshsEmailQuarantined = WorkflowExpression.Compile(propertiespropertieshsEmailQuarantined, nameof(propertiespropertieshsEmailQuarantined), required: false);
            var __workflow_propertiespropertieshsEmailQuarantinedReason = WorkflowExpression.Compile(propertiespropertieshsEmailQuarantinedReason, nameof(propertiespropertieshsEmailQuarantinedReason), required: false);
            var __workflow_propertiespropertieshsEmailReplied = WorkflowExpression.Compile(propertiespropertieshsEmailReplied, nameof(propertiespropertieshsEmailReplied), required: false);
            var __workflow_propertiespropertieshsEmailSendsSinceLastEngagement = WorkflowExpression.Compile(propertiespropertieshsEmailSendsSinceLastEngagement, nameof(propertiespropertieshsEmailSendsSinceLastEngagement), required: false);
            var __workflow_propertiespropertieshsEmailconfirmationstatus = WorkflowExpression.Compile(propertiespropertieshsEmailconfirmationstatus, nameof(propertiespropertieshsEmailconfirmationstatus), required: false);
            var __workflow_propertiespropertieshsFacebookClickId = WorkflowExpression.Compile(propertiespropertieshsFacebookClickId, nameof(propertiespropertieshsFacebookClickId), required: false);
            var __workflow_propertiespropertieshsFeedbackLastNpsFollowUp = WorkflowExpression.Compile(propertiespropertieshsFeedbackLastNpsFollowUp, nameof(propertiespropertieshsFeedbackLastNpsFollowUp), required: false);
            var __workflow_propertiespropertieshsFeedbackLastNpsRating = WorkflowExpression.Compile(propertiespropertieshsFeedbackLastNpsRating, nameof(propertiespropertieshsFeedbackLastNpsRating), required: false);
            var __workflow_propertiespropertieshsFeedbackLastSurveyDate = WorkflowExpression.Compile(propertiespropertieshsFeedbackLastSurveyDate, nameof(propertiespropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_propertiespropertieshsGoogleClickId = WorkflowExpression.Compile(propertiespropertieshsGoogleClickId, nameof(propertiespropertieshsGoogleClickId), required: false);
            var __workflow_propertiespropertieshsIpTimezone = WorkflowExpression.Compile(propertiespropertieshsIpTimezone, nameof(propertiespropertieshsIpTimezone), required: false);
            var __workflow_propertiespropertieshsIsUnworked = WorkflowExpression.Compile(propertiespropertieshsIsUnworked, nameof(propertiespropertieshsIsUnworked), required: false);
            var __workflow_propertiespropertieshsLanguage = WorkflowExpression.Compile(propertiespropertieshsLanguage, nameof(propertiespropertieshsLanguage), required: false);
            var __workflow_propertiespropertieshsLastSalesActivityTimestamp = WorkflowExpression.Compile(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_propertiespropertieshsLeadStatus = WorkflowExpression.Compile(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            var __workflow_propertiespropertieshsLegalBasis = WorkflowExpression.Compile(propertiespropertieshsLegalBasis, nameof(propertiespropertieshsLegalBasis), required: false);
            var __workflow_propertiespropertieshsLifecyclestageCustomerDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageCustomerDate, nameof(propertiespropertieshsLifecyclestageCustomerDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageEvangelistDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageEvangelistDate, nameof(propertiespropertieshsLifecyclestageEvangelistDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageLeadDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageLeadDate, nameof(propertiespropertieshsLifecyclestageLeadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageOpportunityDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageOpportunityDate, nameof(propertiespropertieshsLifecyclestageOpportunityDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageOtherDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageOtherDate, nameof(propertiespropertieshsLifecyclestageOtherDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageSalesqualifiedleadDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageSalesqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageSubscriberDate = WorkflowExpression.Compile(propertiespropertieshsLifecyclestageSubscriberDate, nameof(propertiespropertieshsLifecyclestageSubscriberDate), required: false);
            var __workflow_propertiespropertieshsMarketableReasonId = WorkflowExpression.Compile(propertiespropertieshsMarketableReasonId, nameof(propertiespropertieshsMarketableReasonId), required: false);
            var __workflow_propertiespropertieshsMarketableReasonType = WorkflowExpression.Compile(propertiespropertieshsMarketableReasonType, nameof(propertiespropertieshsMarketableReasonType), required: false);
            var __workflow_propertiespropertieshsMarketableStatus = WorkflowExpression.Compile(propertiespropertieshsMarketableStatus, nameof(propertiespropertieshsMarketableStatus), required: false);
            var __workflow_propertiespropertieshsMarketableUntilRenewal = WorkflowExpression.Compile(propertiespropertieshsMarketableUntilRenewal, nameof(propertiespropertieshsMarketableUntilRenewal), required: false);
            var __workflow_propertiespropertieshsObjectId = WorkflowExpression.Compile(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsPersona = WorkflowExpression.Compile(propertiespropertieshsPersona, nameof(propertiespropertieshsPersona), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscore = WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscore, nameof(propertiespropertieshsPredictivecontactscore), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscoreV2 = WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscorebucket = WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscorebucket, nameof(propertiespropertieshsPredictivecontactscorebucket), required: false);
            var __workflow_propertiespropertieshsPredictivescoringtier = WorkflowExpression.Compile(propertiespropertieshsPredictivescoringtier, nameof(propertiespropertieshsPredictivescoringtier), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastClicked = WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastClicked, nameof(propertiespropertieshsSalesEmailLastClicked), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastOpened = WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastOpened, nameof(propertiespropertieshsSalesEmailLastOpened), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastReplied = WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastReplied, nameof(propertiespropertieshsSalesEmailLastReplied), required: false);
            var __workflow_propertiespropertieshsSequencesIsEnrolled = WorkflowExpression.Compile(propertiespropertieshsSequencesIsEnrolled, nameof(propertiespropertieshsSequencesIsEnrolled), required: false);
            var __workflow_propertiespropertieshsTimeBetweenContactCreationAndDealClose = WorkflowExpression.Compile(propertiespropertieshsTimeBetweenContactCreationAndDealClose, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            var __workflow_propertiespropertieshsTimeBetweenContactCreationAndDealCreation = WorkflowExpression.Compile(propertiespropertieshsTimeBetweenContactCreationAndDealCreation, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromLeadToCustomer = WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromLeadToCustomer, nameof(propertiespropertieshsTimeToMoveFromLeadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromOpportunityToCustomer = WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromOpportunityToCustomer, nameof(propertiespropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromSubscriberToCustomer = WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromSubscriberToCustomer, nameof(propertiespropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            var __workflow_propertiespropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_propertiespropertieshubspotOwnerId = WorkflowExpression.Compile(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            var __workflow_propertiespropertieshubspotTeamId = WorkflowExpression.Compile(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            var __workflow_propertiespropertieshubspotscore = WorkflowExpression.Compile(propertiespropertieshubspotscore, nameof(propertiespropertieshubspotscore), required: false);
            var __workflow_propertiespropertiesindustry = WorkflowExpression.Compile(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            var __workflow_propertiespropertiesipCity = WorkflowExpression.Compile(propertiespropertiesipCity, nameof(propertiespropertiesipCity), required: false);
            var __workflow_propertiespropertiesipCountry = WorkflowExpression.Compile(propertiespropertiesipCountry, nameof(propertiespropertiesipCountry), required: false);
            var __workflow_propertiespropertiesipCountryCode = WorkflowExpression.Compile(propertiespropertiesipCountryCode, nameof(propertiespropertiesipCountryCode), required: false);
            var __workflow_propertiespropertiesipState = WorkflowExpression.Compile(propertiespropertiesipState, nameof(propertiespropertiesipState), required: false);
            var __workflow_propertiespropertiesipStateCode = WorkflowExpression.Compile(propertiespropertiesipStateCode, nameof(propertiespropertiesipStateCode), required: false);
            var __workflow_propertiespropertiesjobFunction = WorkflowExpression.Compile(propertiespropertiesjobFunction, nameof(propertiespropertiesjobFunction), required: false);
            var __workflow_propertiespropertiesjobtitle = WorkflowExpression.Compile(propertiespropertiesjobtitle, nameof(propertiespropertiesjobtitle), required: false);
            var __workflow_propertiespropertieslastmodifieddate = WorkflowExpression.Compile(propertiespropertieslastmodifieddate, nameof(propertiespropertieslastmodifieddate), required: false);
            var __workflow_propertiespropertieslastname = WorkflowExpression.Compile(propertiespropertieslastname, nameof(propertiespropertieslastname), required: false);
            var __workflow_propertiespropertieslifecyclestage = WorkflowExpression.Compile(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            var __workflow_propertiespropertiesmaritalStatus = WorkflowExpression.Compile(propertiespropertiesmaritalStatus, nameof(propertiespropertiesmaritalStatus), required: false);
            var __workflow_propertiespropertiesmessage = WorkflowExpression.Compile(propertiespropertiesmessage, nameof(propertiespropertiesmessage), required: false);
            var __workflow_propertiespropertiesmilitaryStatus = WorkflowExpression.Compile(propertiespropertiesmilitaryStatus, nameof(propertiespropertiesmilitaryStatus), required: false);
            var __workflow_propertiespropertiesmobilephone = WorkflowExpression.Compile(propertiespropertiesmobilephone, nameof(propertiespropertiesmobilephone), required: false);
            var __workflow_propertiespropertiesnotesLastContacted = WorkflowExpression.Compile(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            var __workflow_propertiespropertiesnotesLastUpdated = WorkflowExpression.Compile(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            var __workflow_propertiespropertiesnotesNextActivityDate = WorkflowExpression.Compile(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            var __workflow_propertiespropertiesnumAssociatedDeals = WorkflowExpression.Compile(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            var __workflow_propertiespropertiesnumContactedNotes = WorkflowExpression.Compile(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            var __workflow_propertiespropertiesnumConversionEvents = WorkflowExpression.Compile(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            var __workflow_propertiespropertiesnumNotes = WorkflowExpression.Compile(propertiespropertiesnumNotes, nameof(propertiespropertiesnumNotes), required: false);
            var __workflow_propertiespropertiesnumUniqueConversionEvents = WorkflowExpression.Compile(propertiespropertiesnumUniqueConversionEvents, nameof(propertiespropertiesnumUniqueConversionEvents), required: false);
            var __workflow_propertiespropertiesnumemployees = WorkflowExpression.Compile(propertiespropertiesnumemployees, nameof(propertiespropertiesnumemployees), required: false);
            var __workflow_propertiespropertiesphone = WorkflowExpression.Compile(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            var __workflow_propertiespropertiesrecentConversionDate = WorkflowExpression.Compile(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            var __workflow_propertiespropertiesrecentConversionEventName = WorkflowExpression.Compile(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            var __workflow_propertiespropertiesrecentDealAmount = WorkflowExpression.Compile(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            var __workflow_propertiespropertiesrecentDealCloseDate = WorkflowExpression.Compile(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            var __workflow_propertiespropertiesrelationshipStatus = WorkflowExpression.Compile(propertiespropertiesrelationshipStatus, nameof(propertiespropertiesrelationshipStatus), required: false);
            var __workflow_propertiespropertiessalutation = WorkflowExpression.Compile(propertiespropertiessalutation, nameof(propertiespropertiessalutation), required: false);
            var __workflow_propertiespropertiesschool = WorkflowExpression.Compile(propertiespropertiesschool, nameof(propertiespropertiesschool), required: false);
            var __workflow_propertiespropertiesseniority = WorkflowExpression.Compile(propertiespropertiesseniority, nameof(propertiespropertiesseniority), required: false);
            var __workflow_propertiespropertiesstartDate = WorkflowExpression.Compile(propertiespropertiesstartDate, nameof(propertiespropertiesstartDate), required: false);
            var __workflow_propertiespropertiesstate = WorkflowExpression.Compile(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            var __workflow_propertiespropertiestotalRevenue = WorkflowExpression.Compile(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            var __workflow_propertiespropertiestwitterhandle = WorkflowExpression.Compile(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            var __workflow_propertiespropertieswebsite = WorkflowExpression.Compile(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            var __workflow_propertiespropertiesworkEmail = WorkflowExpression.Compile(propertiespropertiesworkEmail, nameof(propertiespropertiesworkEmail), required: false);
            var __workflow_propertiespropertieszip = WorkflowExpression.Compile(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescompany != null)
                {
                    propertiesObject["company"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdegree != null)
                {
                    propertiesObject["degree"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesemail != null)
                {
                    propertiesObject["email"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfax != null)
                {
                    propertiesObject["fax"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesgender != null)
                {
                    propertiesObject["gender"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesipState != null)
                {
                    propertiesObject["ip_state"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslastname != null)
                {
                    propertiesObject["lastname"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesmessage != null)
                {
                    propertiesObject["message"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiessalutation != null)
                {
                    propertiesObject["salutation"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesschool != null)
                {
                    propertiesObject["school"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesseniority != null)
                {
                    propertiesObject["seniority"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieszip);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    properties["properties"] = propertiesObject;
                    propertiespropCount++;
                }

                if (propertiespropCount > 0)
                {
                    callPayload.Body = properties;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsList(Expression<Func<string>> properties = null, Expression<Func<int>> limit = null, Expression<Func<string>> after = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsCreate(Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
        {
            var __workflow_bodypropertiesamount = WorkflowExpression.Compile(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            var __workflow_bodypropertiesamountInHomeCurrency = WorkflowExpression.Compile(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            var __workflow_bodypropertiesclosedLostReason = WorkflowExpression.Compile(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            var __workflow_bodypropertiesclosedWonReason = WorkflowExpression.Compile(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            var __workflow_bodypropertiesclosedate = WorkflowExpression.Compile(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdealname = WorkflowExpression.Compile(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            var __workflow_bodypropertiesdealstage = WorkflowExpression.Compile(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            var __workflow_bodypropertiesdealtype = WorkflowExpression.Compile(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            var __workflow_bodypropertiesdescription = WorkflowExpression.Compile(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertieshsAcv = WorkflowExpression.Compile(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = WorkflowExpression.Compile(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsArr = WorkflowExpression.Compile(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            var __workflow_bodypropertieshsForecastAmount = WorkflowExpression.Compile(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            var __workflow_bodypropertieshsForecastProbability = WorkflowExpression.Compile(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsManualForecastCategory = WorkflowExpression.Compile(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            var __workflow_bodypropertieshsMrr = WorkflowExpression.Compile(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            var __workflow_bodypropertieshsNextStep = WorkflowExpression.Compile(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            var __workflow_bodypropertieshsObjectId = WorkflowExpression.Compile(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPriority = WorkflowExpression.Compile(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            var __workflow_bodypropertieshsTcv = WorkflowExpression.Compile(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesnotesLastContacted = WorkflowExpression.Compile(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = WorkflowExpression.Compile(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumContactedNotes = WorkflowExpression.Compile(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumNotes = WorkflowExpression.Compile(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiespipeline = WorkflowExpression.Compile(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesamount != null)
                {
                    propertiesObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = ExpressionConverter.ConvertO(__workflow_bodypropertiespipeline);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsRead(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsArchive(Expression<Func<string>> dealId)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsUpdate(Expression<Func<string>> dealId, Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
        {
            var __workflow_dealId = WorkflowExpression.Compile(dealId, nameof(dealId), required: true);
            var __workflow_bodypropertiesamount = WorkflowExpression.Compile(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            var __workflow_bodypropertiesamountInHomeCurrency = WorkflowExpression.Compile(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            var __workflow_bodypropertiesclosedLostReason = WorkflowExpression.Compile(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            var __workflow_bodypropertiesclosedWonReason = WorkflowExpression.Compile(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            var __workflow_bodypropertiesclosedate = WorkflowExpression.Compile(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdealname = WorkflowExpression.Compile(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            var __workflow_bodypropertiesdealstage = WorkflowExpression.Compile(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            var __workflow_bodypropertiesdealtype = WorkflowExpression.Compile(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            var __workflow_bodypropertiesdescription = WorkflowExpression.Compile(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertieshsAcv = WorkflowExpression.Compile(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = WorkflowExpression.Compile(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsArr = WorkflowExpression.Compile(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            var __workflow_bodypropertieshsForecastAmount = WorkflowExpression.Compile(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            var __workflow_bodypropertieshsForecastProbability = WorkflowExpression.Compile(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsManualForecastCategory = WorkflowExpression.Compile(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            var __workflow_bodypropertieshsMrr = WorkflowExpression.Compile(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            var __workflow_bodypropertieshsNextStep = WorkflowExpression.Compile(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            var __workflow_bodypropertieshsObjectId = WorkflowExpression.Compile(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPriority = WorkflowExpression.Compile(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            var __workflow_bodypropertieshsTcv = WorkflowExpression.Compile(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesnotesLastContacted = WorkflowExpression.Compile(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = WorkflowExpression.Compile(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumContactedNotes = WorkflowExpression.Compile(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumNotes = WorkflowExpression.Compile(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiespipeline = WorkflowExpression.Compile(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/deals/{0}", __workflow_dealId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesamount != null)
                {
                    propertiesObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = ExpressionConverter.ConvertO(__workflow_bodypropertiespipeline);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsCreate(Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertieshsCostOfGoodsSold = null, Expression<Func<string>> bodypropertieshsCreatedByUserId = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsImages = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertieshsSku = null, Expression<Func<string>> bodypropertieshsUpdatedByUserId = null, Expression<Func<string>> bodypropertieshsUrl = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertiesprice = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiestax = null)
        {
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdescription = WorkflowExpression.Compile(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertieshsCostOfGoodsSold = WorkflowExpression.Compile(bodypropertieshsCostOfGoodsSold, nameof(bodypropertieshsCostOfGoodsSold), required: false);
            var __workflow_bodypropertieshsCreatedByUserId = WorkflowExpression.Compile(bodypropertieshsCreatedByUserId, nameof(bodypropertieshsCreatedByUserId), required: false);
            var __workflow_bodypropertieshsCreatedate = WorkflowExpression.Compile(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsImages = WorkflowExpression.Compile(bodypropertieshsImages, nameof(bodypropertieshsImages), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsObjectId = WorkflowExpression.Compile(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsRecurringBillingPeriod = WorkflowExpression.Compile(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            var __workflow_bodypropertieshsSku = WorkflowExpression.Compile(bodypropertieshsSku, nameof(bodypropertieshsSku), required: false);
            var __workflow_bodypropertieshsUpdatedByUserId = WorkflowExpression.Compile(bodypropertieshsUpdatedByUserId, nameof(bodypropertieshsUpdatedByUserId), required: false);
            var __workflow_bodypropertieshsUrl = WorkflowExpression.Compile(bodypropertieshsUrl, nameof(bodypropertieshsUrl), required: false);
            var __workflow_bodypropertiesname = WorkflowExpression.Compile(bodypropertiesname, nameof(bodypropertiesname), required: false);
            var __workflow_bodypropertiesprice = WorkflowExpression.Compile(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            var __workflow_bodypropertiesrecurringbillingfrequency = WorkflowExpression.Compile(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            var __workflow_bodypropertiestax = WorkflowExpression.Compile(bodypropertiestax, nameof(bodypropertiestax), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestax != null)
                {
                    propertiesObject["tax"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestax);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsRead(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsArchive(Expression<Func<string>> productId)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsUpdate(Expression<Func<string>> productId, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertieshsCostOfGoodsSold = null, Expression<Func<string>> propertiespropertieshsCreatedByUserId = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsImages = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertieshsSku = null, Expression<Func<string>> propertiespropertieshsUpdatedByUserId = null, Expression<Func<string>> propertiespropertieshsUrl = null, Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertiesprice = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiestax = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_propertiespropertiescreatedate = WorkflowExpression.Compile(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiesdescription = WorkflowExpression.Compile(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            var __workflow_propertiespropertieshsCostOfGoodsSold = WorkflowExpression.Compile(propertiespropertieshsCostOfGoodsSold, nameof(propertiespropertieshsCostOfGoodsSold), required: false);
            var __workflow_propertiespropertieshsCreatedByUserId = WorkflowExpression.Compile(propertiespropertieshsCreatedByUserId, nameof(propertiespropertieshsCreatedByUserId), required: false);
            var __workflow_propertiespropertieshsCreatedate = WorkflowExpression.Compile(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsImages = WorkflowExpression.Compile(propertiespropertieshsImages, nameof(propertiespropertieshsImages), required: false);
            var __workflow_propertiespropertieshsLastmodifieddate = WorkflowExpression.Compile(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            var __workflow_propertiespropertieshsObjectId = WorkflowExpression.Compile(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsRecurringBillingPeriod = WorkflowExpression.Compile(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            var __workflow_propertiespropertieshsSku = WorkflowExpression.Compile(propertiespropertieshsSku, nameof(propertiespropertieshsSku), required: false);
            var __workflow_propertiespropertieshsUpdatedByUserId = WorkflowExpression.Compile(propertiespropertieshsUpdatedByUserId, nameof(propertiespropertieshsUpdatedByUserId), required: false);
            var __workflow_propertiespropertieshsUrl = WorkflowExpression.Compile(propertiespropertieshsUrl, nameof(propertiespropertieshsUrl), required: false);
            var __workflow_propertiespropertiesname = WorkflowExpression.Compile(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            var __workflow_propertiespropertiesprice = WorkflowExpression.Compile(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            var __workflow_propertiespropertiesrecurringbillingfrequency = WorkflowExpression.Compile(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            var __workflow_propertiespropertiestax = WorkflowExpression.Compile(propertiespropertiestax, nameof(propertiespropertiestax), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/products/{0}", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiestax != null)
                {
                    propertiesObject["tax"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiestax);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    properties["properties"] = propertiesObject;
                    propertiespropCount++;
                }

                if (propertiespropCount > 0)
                {
                    callPayload.Body = properties;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsCreate(Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertieshsProductId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiesquantity = null, Expression<Func<string>> propertiespropertiesprice = null)
        {
            var __workflow_propertiespropertiesname = WorkflowExpression.Compile(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            var __workflow_propertiespropertieshsProductId = WorkflowExpression.Compile(propertiespropertieshsProductId, nameof(propertiespropertieshsProductId), required: false);
            var __workflow_propertiespropertieshsRecurringBillingPeriod = WorkflowExpression.Compile(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            var __workflow_propertiespropertiesrecurringbillingfrequency = WorkflowExpression.Compile(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            var __workflow_propertiespropertiesquantity = WorkflowExpression.Compile(propertiespropertiesquantity, nameof(propertiespropertiesquantity), required: false);
            var __workflow_propertiespropertiesprice = WorkflowExpression.Compile(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_propertiespropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(__workflow_propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesquantity != null)
                {
                    propertiesObject["quantity"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(__workflow_propertiespropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    properties["properties"] = propertiesObject;
                    propertiespropCount++;
                }

                if (propertiespropCount > 0)
                {
                    callPayload.Body = properties;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsRead(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsArchive(Expression<Func<string>> lineItemId)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsUpdate(Expression<Func<string>> lineItemId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertieshsProductId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiesquantity = null, Expression<Func<string>> bodypropertiesprice = null)
        {
            var __workflow_lineItemId = WorkflowExpression.Compile(lineItemId, nameof(lineItemId), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            var __workflow_bodypropertiesname = WorkflowExpression.Compile(bodypropertiesname, nameof(bodypropertiesname), required: false);
            var __workflow_bodypropertieshsProductId = WorkflowExpression.Compile(bodypropertieshsProductId, nameof(bodypropertieshsProductId), required: false);
            var __workflow_bodypropertieshsRecurringBillingPeriod = WorkflowExpression.Compile(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            var __workflow_bodypropertiesrecurringbillingfrequency = WorkflowExpression.Compile(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            var __workflow_bodypropertiesquantity = WorkflowExpression.Compile(bodypropertiesquantity, nameof(bodypropertiesquantity), required: false);
            var __workflow_bodypropertiesprice = WorkflowExpression.Compile(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/line_items/{0}", __workflow_lineItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesquantity != null)
                {
                    propertiesObject["quantity"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_associations = WorkflowExpression.Compile(associations, nameof(associations), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                if (__workflow_associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(__workflow_associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsCreate(Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
        {
            var __workflow_bodypropertiesclosedDate = WorkflowExpression.Compile(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesfirstAgentReplyDate = WorkflowExpression.Compile(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesFollowUp = WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesRating = WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsLastactivitydate = WorkflowExpression.Compile(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            var __workflow_bodypropertieshsLastcontacted = WorkflowExpression.Compile(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsNextactivitydate = WorkflowExpression.Compile(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            var __workflow_bodypropertieshsNumTimesContacted = WorkflowExpression.Compile(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieslastReplyDate = WorkflowExpression.Compile(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            var __workflow_bodypropertiesnumNotes = WorkflowExpression.Compile(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiestimeToClose = WorkflowExpression.Compile(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            var __workflow_bodypropertiestimeToFirstAgentReply = WorkflowExpression.Compile(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            var __workflow_bodypropertiescontent = WorkflowExpression.Compile(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            var __workflow_bodypropertieshsFileUpload = WorkflowExpression.Compile(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            var __workflow_bodypropertieshsNumAssociatedCompanies = WorkflowExpression.Compile(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            var __workflow_bodypropertieshsPipeline = WorkflowExpression.Compile(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            var __workflow_bodypropertieshsPipelineStage = WorkflowExpression.Compile(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            var __workflow_bodypropertieshsResolution = WorkflowExpression.Compile(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            var __workflow_bodypropertieshsTicketCategory = WorkflowExpression.Compile(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            var __workflow_bodypropertieshsTicketId = WorkflowExpression.Compile(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            var __workflow_bodypropertieshsTicketPriority = WorkflowExpression.Compile(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiessourceType = WorkflowExpression.Compile(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            var __workflow_bodypropertiessubject = WorkflowExpression.Compile(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesclosedDate != null)
                {
                    propertiesObject["closed_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescontent != null)
                {
                    propertiesObject["content"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = ExpressionConverter.ConvertO(__workflow_bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = ExpressionConverter.ConvertO(__workflow_bodypropertiessubject);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsRead(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_properties = WorkflowExpression.Compile(properties, nameof(properties), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(__workflow_properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsArchive(Expression<Func<string>> ticketId)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsUpdate(Expression<Func<string>> ticketId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
        {
            var __workflow_ticketId = WorkflowExpression.Compile(ticketId, nameof(ticketId), required: true);
            var __workflow_idProperty = WorkflowExpression.Compile(idProperty, nameof(idProperty), required: false);
            var __workflow_bodypropertiesclosedDate = WorkflowExpression.Compile(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            var __workflow_bodypropertiescreatedate = WorkflowExpression.Compile(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesfirstAgentReplyDate = WorkflowExpression.Compile(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesFollowUp = WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesRating = WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsLastactivitydate = WorkflowExpression.Compile(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            var __workflow_bodypropertieshsLastcontacted = WorkflowExpression.Compile(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = WorkflowExpression.Compile(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsNextactivitydate = WorkflowExpression.Compile(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            var __workflow_bodypropertieshsNumTimesContacted = WorkflowExpression.Compile(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieslastReplyDate = WorkflowExpression.Compile(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            var __workflow_bodypropertiesnumNotes = WorkflowExpression.Compile(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiestimeToClose = WorkflowExpression.Compile(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            var __workflow_bodypropertiestimeToFirstAgentReply = WorkflowExpression.Compile(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            var __workflow_bodypropertiescontent = WorkflowExpression.Compile(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            var __workflow_bodypropertieshsFileUpload = WorkflowExpression.Compile(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            var __workflow_bodypropertieshsNumAssociatedCompanies = WorkflowExpression.Compile(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            var __workflow_bodypropertieshsPipeline = WorkflowExpression.Compile(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            var __workflow_bodypropertieshsPipelineStage = WorkflowExpression.Compile(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            var __workflow_bodypropertieshsResolution = WorkflowExpression.Compile(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            var __workflow_bodypropertieshsTicketCategory = WorkflowExpression.Compile(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            var __workflow_bodypropertieshsTicketId = WorkflowExpression.Compile(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            var __workflow_bodypropertieshsTicketPriority = WorkflowExpression.Compile(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            var __workflow_bodypropertieshubspotOwnerId = WorkflowExpression.Compile(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = WorkflowExpression.Compile(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiessourceType = WorkflowExpression.Compile(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            var __workflow_bodypropertiessubject = WorkflowExpression.Compile(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm/v3/objects/tickets/{0}", __workflow_ticketId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(__workflow_idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (__workflow_bodypropertiesclosedDate != null)
                {
                    propertiesObject["closed_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = ExpressionConverter.ConvertO(__workflow_bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(__workflow_bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = ExpressionConverter.ConvertO(__workflow_bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiescontent != null)
                {
                    propertiesObject["content"] = ExpressionConverter.ConvertO(__workflow_bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(__workflow_bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = ExpressionConverter.ConvertO(__workflow_bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (__workflow_bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = ExpressionConverter.ConvertO(__workflow_bodypropertiessubject);
                    propertiesObjectpropCount++;
                }

                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HubspotcrmTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm;

    public partial class WorkflowManagedActions
    {
        public HubspotcrmActions Hubspotcrm(string connectionId) => new HubspotcrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotcrmTriggers Hubspotcrm(string connectionId) => new HubspotcrmTriggers(connectionId);
    }
}
