//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HubspotcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
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
            var __workflow_bodypropertiesname = bodypropertiesname == null ? null : WorkflowExpression.Compile(bodypropertiesname);
            WorkflowExpression.Validate(__workflow_bodypropertiesname, nameof(bodypropertiesname), required: true);
            var __workflow_bodypropertiesaboutUs = bodypropertiesaboutUs == null ? null : WorkflowExpression.Compile(bodypropertiesaboutUs);
            WorkflowExpression.Validate(__workflow_bodypropertiesaboutUs, nameof(bodypropertiesaboutUs), required: false);
            var __workflow_bodypropertiesaddress = bodypropertiesaddress == null ? null : WorkflowExpression.Compile(bodypropertiesaddress);
            WorkflowExpression.Validate(__workflow_bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            var __workflow_bodypropertiesaddress2 = bodypropertiesaddress2 == null ? null : WorkflowExpression.Compile(bodypropertiesaddress2);
            WorkflowExpression.Validate(__workflow_bodypropertiesaddress2, nameof(bodypropertiesaddress2), required: false);
            var __workflow_bodypropertiesannualrevenue = bodypropertiesannualrevenue == null ? null : WorkflowExpression.Compile(bodypropertiesannualrevenue);
            WorkflowExpression.Validate(__workflow_bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            var __workflow_bodypropertiescity = bodypropertiescity == null ? null : WorkflowExpression.Compile(bodypropertiescity);
            WorkflowExpression.Validate(__workflow_bodypropertiescity, nameof(bodypropertiescity), required: false);
            var __workflow_bodypropertiesclosedate = bodypropertiesclosedate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescountry = bodypropertiescountry == null ? null : WorkflowExpression.Compile(bodypropertiescountry);
            WorkflowExpression.Validate(__workflow_bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdaysToClose = bodypropertiesdaysToClose == null ? null : WorkflowExpression.Compile(bodypropertiesdaysToClose);
            WorkflowExpression.Validate(__workflow_bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            var __workflow_bodypropertiesdescription = bodypropertiesdescription == null ? null : WorkflowExpression.Compile(bodypropertiesdescription);
            WorkflowExpression.Validate(__workflow_bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesdomain = bodypropertiesdomain == null ? null : WorkflowExpression.Compile(bodypropertiesdomain);
            WorkflowExpression.Validate(__workflow_bodypropertiesdomain, nameof(bodypropertiesdomain), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = bodypropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = bodypropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = bodypropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = bodypropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertiesfacebookCompanyPage = bodypropertiesfacebookCompanyPage == null ? null : WorkflowExpression.Compile(bodypropertiesfacebookCompanyPage);
            WorkflowExpression.Validate(__workflow_bodypropertiesfacebookCompanyPage, nameof(bodypropertiesfacebookCompanyPage), required: false);
            var __workflow_bodypropertiesfacebookfans = bodypropertiesfacebookfans == null ? null : WorkflowExpression.Compile(bodypropertiesfacebookfans);
            WorkflowExpression.Validate(__workflow_bodypropertiesfacebookfans, nameof(bodypropertiesfacebookfans), required: false);
            var __workflow_bodypropertiesfirstContactCreatedate = bodypropertiesfirstContactCreatedate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstContactCreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstContactCreatedate, nameof(bodypropertiesfirstContactCreatedate), required: false);
            var __workflow_bodypropertiesfirstConversionDate = bodypropertiesfirstConversionDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstConversionDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            var __workflow_bodypropertiesfirstConversionEventName = bodypropertiesfirstConversionEventName == null ? null : WorkflowExpression.Compile(bodypropertiesfirstConversionEventName);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            var __workflow_bodypropertiesfirstDealCreatedDate = bodypropertiesfirstDealCreatedDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstDealCreatedDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            var __workflow_bodypropertiesfoundedYear = bodypropertiesfoundedYear == null ? null : WorkflowExpression.Compile(bodypropertiesfoundedYear);
            WorkflowExpression.Validate(__workflow_bodypropertiesfoundedYear, nameof(bodypropertiesfoundedYear), required: false);
            var __workflow_bodypropertiesgoogleplusPage = bodypropertiesgoogleplusPage == null ? null : WorkflowExpression.Compile(bodypropertiesgoogleplusPage);
            WorkflowExpression.Validate(__workflow_bodypropertiesgoogleplusPage, nameof(bodypropertiesgoogleplusPage), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTimestamp = bodypropertieshsAnalyticsFirstTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign = bodypropertieshsAnalyticsFirstTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstVisitTimestamp = bodypropertieshsAnalyticsFirstVisitTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstVisitTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTimestamp = bodypropertieshsAnalyticsLastTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign = bodypropertieshsAnalyticsLastTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsLastVisitTimestamp = bodypropertieshsAnalyticsLastVisitTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastVisitTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsNumPageViews = bodypropertieshsAnalyticsNumPageViews == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsNumPageViews);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsNumVisits = bodypropertieshsAnalyticsNumVisits == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsNumVisits);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = bodypropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = bodypropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = bodypropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsCreatedate = bodypropertieshsCreatedate == null ? null : WorkflowExpression.Compile(bodypropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsIdealCustomerProfile = bodypropertieshsIdealCustomerProfile == null ? null : WorkflowExpression.Compile(bodypropertieshsIdealCustomerProfile);
            WorkflowExpression.Validate(__workflow_bodypropertieshsIdealCustomerProfile, nameof(bodypropertieshsIdealCustomerProfile), required: false);
            var __workflow_bodypropertieshsIsTargetAccount = bodypropertieshsIsTargetAccount == null ? null : WorkflowExpression.Compile(bodypropertieshsIsTargetAccount);
            WorkflowExpression.Validate(__workflow_bodypropertieshsIsTargetAccount, nameof(bodypropertieshsIsTargetAccount), required: false);
            var __workflow_bodypropertieshsLastBookedMeetingDate = bodypropertieshsLastBookedMeetingDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastBookedMeetingDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastBookedMeetingDate, nameof(bodypropertieshsLastBookedMeetingDate), required: false);
            var __workflow_bodypropertieshsLastLoggedCallDate = bodypropertieshsLastLoggedCallDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastLoggedCallDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastLoggedCallDate, nameof(bodypropertieshsLastLoggedCallDate), required: false);
            var __workflow_bodypropertieshsLastOpenTaskDate = bodypropertieshsLastOpenTaskDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastOpenTaskDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastOpenTaskDate, nameof(bodypropertieshsLastOpenTaskDate), required: false);
            var __workflow_bodypropertieshsLastSalesActivityTimestamp = bodypropertieshsLastSalesActivityTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsLastSalesActivityTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsLeadStatus = bodypropertieshsLeadStatus == null ? null : WorkflowExpression.Compile(bodypropertieshsLeadStatus);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            var __workflow_bodypropertieshsNumBlockers = bodypropertieshsNumBlockers == null ? null : WorkflowExpression.Compile(bodypropertieshsNumBlockers);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumBlockers, nameof(bodypropertieshsNumBlockers), required: false);
            var __workflow_bodypropertieshsNumChildCompanies = bodypropertieshsNumChildCompanies == null ? null : WorkflowExpression.Compile(bodypropertieshsNumChildCompanies);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumChildCompanies, nameof(bodypropertieshsNumChildCompanies), required: false);
            var __workflow_bodypropertieshsNumContactsWithBuyingRoles = bodypropertieshsNumContactsWithBuyingRoles == null ? null : WorkflowExpression.Compile(bodypropertieshsNumContactsWithBuyingRoles);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumContactsWithBuyingRoles, nameof(bodypropertieshsNumContactsWithBuyingRoles), required: false);
            var __workflow_bodypropertieshsNumDecisionMakers = bodypropertieshsNumDecisionMakers == null ? null : WorkflowExpression.Compile(bodypropertieshsNumDecisionMakers);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumDecisionMakers, nameof(bodypropertieshsNumDecisionMakers), required: false);
            var __workflow_bodypropertieshsNumOpenDeals = bodypropertieshsNumOpenDeals == null ? null : WorkflowExpression.Compile(bodypropertieshsNumOpenDeals);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumOpenDeals, nameof(bodypropertieshsNumOpenDeals), required: false);
            var __workflow_bodypropertieshsObjectId = bodypropertieshsObjectId == null ? null : WorkflowExpression.Compile(bodypropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsParentCompanyId = bodypropertieshsParentCompanyId == null ? null : WorkflowExpression.Compile(bodypropertieshsParentCompanyId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsParentCompanyId, nameof(bodypropertieshsParentCompanyId), required: false);
            var __workflow_bodypropertieshsPredictivecontactscoreV2 = bodypropertieshsPredictivecontactscoreV2 == null ? null : WorkflowExpression.Compile(bodypropertieshsPredictivecontactscoreV2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_bodypropertieshsTotalDealValue = bodypropertieshsTotalDealValue == null ? null : WorkflowExpression.Compile(bodypropertieshsTotalDealValue);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTotalDealValue, nameof(bodypropertieshsTotalDealValue), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesindustry = bodypropertiesindustry == null ? null : WorkflowExpression.Compile(bodypropertiesindustry);
            WorkflowExpression.Validate(__workflow_bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            var __workflow_bodypropertiesisPublic = bodypropertiesisPublic == null ? null : WorkflowExpression.Compile(bodypropertiesisPublic);
            WorkflowExpression.Validate(__workflow_bodypropertiesisPublic, nameof(bodypropertiesisPublic), required: false);
            var __workflow_bodypropertieslifecyclestage = bodypropertieslifecyclestage == null ? null : WorkflowExpression.Compile(bodypropertieslifecyclestage);
            WorkflowExpression.Validate(__workflow_bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            var __workflow_bodypropertieslinkedinCompanyPage = bodypropertieslinkedinCompanyPage == null ? null : WorkflowExpression.Compile(bodypropertieslinkedinCompanyPage);
            WorkflowExpression.Validate(__workflow_bodypropertieslinkedinCompanyPage, nameof(bodypropertieslinkedinCompanyPage), required: false);
            var __workflow_bodypropertieslinkedinbio = bodypropertieslinkedinbio == null ? null : WorkflowExpression.Compile(bodypropertieslinkedinbio);
            WorkflowExpression.Validate(__workflow_bodypropertieslinkedinbio, nameof(bodypropertieslinkedinbio), required: false);
            var __workflow_bodypropertiesnotesLastContacted = bodypropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = bodypropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = bodypropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = bodypropertiesnumAssociatedContacts == null ? null : WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumAssociatedDeals = bodypropertiesnumAssociatedDeals == null ? null : WorkflowExpression.Compile(bodypropertiesnumAssociatedDeals);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            var __workflow_bodypropertiesnumContactedNotes = bodypropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumConversionEvents = bodypropertiesnumConversionEvents == null ? null : WorkflowExpression.Compile(bodypropertiesnumConversionEvents);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            var __workflow_bodypropertiesnumberofemployees = bodypropertiesnumberofemployees == null ? null : WorkflowExpression.Compile(bodypropertiesnumberofemployees);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumberofemployees, nameof(bodypropertiesnumberofemployees), required: false);
            var __workflow_bodypropertiesphone = bodypropertiesphone == null ? null : WorkflowExpression.Compile(bodypropertiesphone);
            WorkflowExpression.Validate(__workflow_bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            var __workflow_bodypropertiesrecentConversionDate = bodypropertiesrecentConversionDate == null ? null : WorkflowExpression.Compile(bodypropertiesrecentConversionDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            var __workflow_bodypropertiesrecentConversionEventName = bodypropertiesrecentConversionEventName == null ? null : WorkflowExpression.Compile(bodypropertiesrecentConversionEventName);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            var __workflow_bodypropertiesrecentDealAmount = bodypropertiesrecentDealAmount == null ? null : WorkflowExpression.Compile(bodypropertiesrecentDealAmount);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            var __workflow_bodypropertiesrecentDealCloseDate = bodypropertiesrecentDealCloseDate == null ? null : WorkflowExpression.Compile(bodypropertiesrecentDealCloseDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            var __workflow_bodypropertiesstate = bodypropertiesstate == null ? null : WorkflowExpression.Compile(bodypropertiesstate);
            WorkflowExpression.Validate(__workflow_bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            var __workflow_bodypropertiestimezone = bodypropertiestimezone == null ? null : WorkflowExpression.Compile(bodypropertiestimezone);
            WorkflowExpression.Validate(__workflow_bodypropertiestimezone, nameof(bodypropertiestimezone), required: false);
            var __workflow_bodypropertiestotalMoneyRaised = bodypropertiestotalMoneyRaised == null ? null : WorkflowExpression.Compile(bodypropertiestotalMoneyRaised);
            WorkflowExpression.Validate(__workflow_bodypropertiestotalMoneyRaised, nameof(bodypropertiestotalMoneyRaised), required: false);
            var __workflow_bodypropertiestotalRevenue = bodypropertiestotalRevenue == null ? null : WorkflowExpression.Compile(bodypropertiestotalRevenue);
            WorkflowExpression.Validate(__workflow_bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            var __workflow_bodypropertiestwitterbio = bodypropertiestwitterbio == null ? null : WorkflowExpression.Compile(bodypropertiestwitterbio);
            WorkflowExpression.Validate(__workflow_bodypropertiestwitterbio, nameof(bodypropertiestwitterbio), required: false);
            var __workflow_bodypropertiestwitterfollowers = bodypropertiestwitterfollowers == null ? null : WorkflowExpression.Compile(bodypropertiestwitterfollowers);
            WorkflowExpression.Validate(__workflow_bodypropertiestwitterfollowers, nameof(bodypropertiestwitterfollowers), required: false);
            var __workflow_bodypropertiestwitterhandle = bodypropertiestwitterhandle == null ? null : WorkflowExpression.Compile(bodypropertiestwitterhandle);
            WorkflowExpression.Validate(__workflow_bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            var __workflow_bodypropertiestype = bodypropertiestype == null ? null : WorkflowExpression.Compile(bodypropertiestype);
            WorkflowExpression.Validate(__workflow_bodypropertiestype, nameof(bodypropertiestype), required: false);
            var __workflow_bodypropertieswebTechnologies = bodypropertieswebTechnologies == null ? null : WorkflowExpression.Compile(bodypropertieswebTechnologies);
            WorkflowExpression.Validate(__workflow_bodypropertieswebTechnologies, nameof(bodypropertieswebTechnologies), required: false);
            var __workflow_bodypropertieswebsite = bodypropertieswebsite == null ? null : WorkflowExpression.Compile(bodypropertieswebsite);
            WorkflowExpression.Validate(__workflow_bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            var __workflow_bodypropertieszip = bodypropertieszip == null ? null : WorkflowExpression.Compile(bodypropertieszip);
            WorkflowExpression.Validate(__workflow_bodypropertieszip, nameof(bodypropertieszip), required: false);
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
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyId, 1));
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
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesUpdate(Expression<Func<string>> companyId, Expression<Func<string>> propertiespropertiesname, Expression<Func<string>> propertiespropertiesaboutUs = null, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesaddress2 = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertiesdomain = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfacebookCompanyPage = null, Expression<Func<string>> propertiespropertiesfacebookfans = null, Expression<Func<string>> propertiespropertiesfirstContactCreatedate = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfoundedYear = null, Expression<Func<string>> propertiespropertiesgoogleplusPage = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsIdealCustomerProfile = null, Expression<Func<string>> propertiespropertieshsIsTargetAccount = null, Expression<Func<string>> propertiespropertieshsLastBookedMeetingDate = null, Expression<Func<string>> propertiespropertieshsLastLoggedCallDate = null, Expression<Func<string>> propertiespropertieshsLastOpenTaskDate = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsNumBlockers = null, Expression<Func<string>> propertiespropertieshsNumChildCompanies = null, Expression<Func<string>> propertiespropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> propertiespropertieshsNumDecisionMakers = null, Expression<Func<string>> propertiespropertieshsNumOpenDeals = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsParentCompanyId = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsTotalDealValue = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesisPublic = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertieslinkedinCompanyPage = null, Expression<Func<string>> propertiespropertieslinkedinbio = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedContacts = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumberofemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestimezone = null, Expression<Func<string>> propertiespropertiestotalMoneyRaised = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterbio = null, Expression<Func<string>> propertiespropertiestwitterfollowers = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertiestype = null, Expression<Func<string>> propertiespropertieswebTechnologies = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            var __workflow_propertiespropertiesname = propertiespropertiesname == null ? null : WorkflowExpression.Compile(propertiespropertiesname);
            WorkflowExpression.Validate(__workflow_propertiespropertiesname, nameof(propertiespropertiesname), required: true);
            var __workflow_propertiespropertiesaboutUs = propertiespropertiesaboutUs == null ? null : WorkflowExpression.Compile(propertiespropertiesaboutUs);
            WorkflowExpression.Validate(__workflow_propertiespropertiesaboutUs, nameof(propertiespropertiesaboutUs), required: false);
            var __workflow_propertiespropertiesaddress = propertiespropertiesaddress == null ? null : WorkflowExpression.Compile(propertiespropertiesaddress);
            WorkflowExpression.Validate(__workflow_propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            var __workflow_propertiespropertiesaddress2 = propertiespropertiesaddress2 == null ? null : WorkflowExpression.Compile(propertiespropertiesaddress2);
            WorkflowExpression.Validate(__workflow_propertiespropertiesaddress2, nameof(propertiespropertiesaddress2), required: false);
            var __workflow_propertiespropertiesannualrevenue = propertiespropertiesannualrevenue == null ? null : WorkflowExpression.Compile(propertiespropertiesannualrevenue);
            WorkflowExpression.Validate(__workflow_propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            var __workflow_propertiespropertiescity = propertiespropertiescity == null ? null : WorkflowExpression.Compile(propertiespropertiescity);
            WorkflowExpression.Validate(__workflow_propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            var __workflow_propertiespropertiesclosedate = propertiespropertiesclosedate == null ? null : WorkflowExpression.Compile(propertiespropertiesclosedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            var __workflow_propertiespropertiescountry = propertiespropertiescountry == null ? null : WorkflowExpression.Compile(propertiespropertiescountry);
            WorkflowExpression.Validate(__workflow_propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            var __workflow_propertiespropertiescreatedate = propertiespropertiescreatedate == null ? null : WorkflowExpression.Compile(propertiespropertiescreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiesdaysToClose = propertiespropertiesdaysToClose == null ? null : WorkflowExpression.Compile(propertiespropertiesdaysToClose);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            var __workflow_propertiespropertiesdescription = propertiespropertiesdescription == null ? null : WorkflowExpression.Compile(propertiespropertiesdescription);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            var __workflow_propertiespropertiesdomain = propertiespropertiesdomain == null ? null : WorkflowExpression.Compile(propertiespropertiesdomain);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdomain, nameof(propertiespropertiesdomain), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBooked = propertiespropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedCampaign = propertiespropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedMedium = propertiespropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedSource = propertiespropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_propertiespropertiesfacebookCompanyPage = propertiespropertiesfacebookCompanyPage == null ? null : WorkflowExpression.Compile(propertiespropertiesfacebookCompanyPage);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfacebookCompanyPage, nameof(propertiespropertiesfacebookCompanyPage), required: false);
            var __workflow_propertiespropertiesfacebookfans = propertiespropertiesfacebookfans == null ? null : WorkflowExpression.Compile(propertiespropertiesfacebookfans);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfacebookfans, nameof(propertiespropertiesfacebookfans), required: false);
            var __workflow_propertiespropertiesfirstContactCreatedate = propertiespropertiesfirstContactCreatedate == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstContactCreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstContactCreatedate, nameof(propertiespropertiesfirstContactCreatedate), required: false);
            var __workflow_propertiespropertiesfirstConversionDate = propertiespropertiesfirstConversionDate == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstConversionDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            var __workflow_propertiespropertiesfirstConversionEventName = propertiespropertiesfirstConversionEventName == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstConversionEventName);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            var __workflow_propertiespropertiesfirstDealCreatedDate = propertiespropertiesfirstDealCreatedDate == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstDealCreatedDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            var __workflow_propertiespropertiesfoundedYear = propertiespropertiesfoundedYear == null ? null : WorkflowExpression.Compile(propertiespropertiesfoundedYear);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfoundedYear, nameof(propertiespropertiesfoundedYear), required: false);
            var __workflow_propertiespropertiesgoogleplusPage = propertiespropertiesgoogleplusPage == null ? null : WorkflowExpression.Compile(propertiespropertiesgoogleplusPage);
            WorkflowExpression.Validate(__workflow_propertiespropertiesgoogleplusPage, nameof(propertiespropertiesgoogleplusPage), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTimestamp = propertiespropertieshsAnalyticsFirstTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = propertiespropertieshsAnalyticsFirstTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp = propertiespropertieshsAnalyticsFirstVisitTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstVisitTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTimestamp = propertiespropertieshsAnalyticsLastTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign = propertiespropertieshsAnalyticsLastTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastVisitTimestamp = propertiespropertieshsAnalyticsLastVisitTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastVisitTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumPageViews = propertiespropertieshsAnalyticsNumPageViews == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumPageViews);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumVisits = propertiespropertieshsAnalyticsNumVisits == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumVisits);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            var __workflow_propertiespropertieshsAnalyticsSource = propertiespropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData1 = propertiespropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData2 = propertiespropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            var __workflow_propertiespropertieshsCreatedate = propertiespropertieshsCreatedate == null ? null : WorkflowExpression.Compile(propertiespropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsIdealCustomerProfile = propertiespropertieshsIdealCustomerProfile == null ? null : WorkflowExpression.Compile(propertiespropertieshsIdealCustomerProfile);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsIdealCustomerProfile, nameof(propertiespropertieshsIdealCustomerProfile), required: false);
            var __workflow_propertiespropertieshsIsTargetAccount = propertiespropertieshsIsTargetAccount == null ? null : WorkflowExpression.Compile(propertiespropertieshsIsTargetAccount);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsIsTargetAccount, nameof(propertiespropertieshsIsTargetAccount), required: false);
            var __workflow_propertiespropertieshsLastBookedMeetingDate = propertiespropertieshsLastBookedMeetingDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastBookedMeetingDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastBookedMeetingDate, nameof(propertiespropertieshsLastBookedMeetingDate), required: false);
            var __workflow_propertiespropertieshsLastLoggedCallDate = propertiespropertieshsLastLoggedCallDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastLoggedCallDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastLoggedCallDate, nameof(propertiespropertieshsLastLoggedCallDate), required: false);
            var __workflow_propertiespropertieshsLastOpenTaskDate = propertiespropertieshsLastOpenTaskDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastOpenTaskDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastOpenTaskDate, nameof(propertiespropertieshsLastOpenTaskDate), required: false);
            var __workflow_propertiespropertieshsLastSalesActivityTimestamp = propertiespropertieshsLastSalesActivityTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastSalesActivityTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_propertiespropertieshsLastmodifieddate = propertiespropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            var __workflow_propertiespropertieshsLeadStatus = propertiespropertieshsLeadStatus == null ? null : WorkflowExpression.Compile(propertiespropertieshsLeadStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            var __workflow_propertiespropertieshsNumBlockers = propertiespropertieshsNumBlockers == null ? null : WorkflowExpression.Compile(propertiespropertieshsNumBlockers);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsNumBlockers, nameof(propertiespropertieshsNumBlockers), required: false);
            var __workflow_propertiespropertieshsNumChildCompanies = propertiespropertieshsNumChildCompanies == null ? null : WorkflowExpression.Compile(propertiespropertieshsNumChildCompanies);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsNumChildCompanies, nameof(propertiespropertieshsNumChildCompanies), required: false);
            var __workflow_propertiespropertieshsNumContactsWithBuyingRoles = propertiespropertieshsNumContactsWithBuyingRoles == null ? null : WorkflowExpression.Compile(propertiespropertieshsNumContactsWithBuyingRoles);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsNumContactsWithBuyingRoles, nameof(propertiespropertieshsNumContactsWithBuyingRoles), required: false);
            var __workflow_propertiespropertieshsNumDecisionMakers = propertiespropertieshsNumDecisionMakers == null ? null : WorkflowExpression.Compile(propertiespropertieshsNumDecisionMakers);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsNumDecisionMakers, nameof(propertiespropertieshsNumDecisionMakers), required: false);
            var __workflow_propertiespropertieshsNumOpenDeals = propertiespropertieshsNumOpenDeals == null ? null : WorkflowExpression.Compile(propertiespropertieshsNumOpenDeals);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsNumOpenDeals, nameof(propertiespropertieshsNumOpenDeals), required: false);
            var __workflow_propertiespropertieshsObjectId = propertiespropertieshsObjectId == null ? null : WorkflowExpression.Compile(propertiespropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsParentCompanyId = propertiespropertieshsParentCompanyId == null ? null : WorkflowExpression.Compile(propertiespropertieshsParentCompanyId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsParentCompanyId, nameof(propertiespropertieshsParentCompanyId), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscoreV2 = propertiespropertieshsPredictivecontactscoreV2 == null ? null : WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscoreV2);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_propertiespropertieshsTotalDealValue = propertiespropertieshsTotalDealValue == null ? null : WorkflowExpression.Compile(propertiespropertieshsTotalDealValue);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTotalDealValue, nameof(propertiespropertieshsTotalDealValue), required: false);
            var __workflow_propertiespropertieshubspotOwnerAssigneddate = propertiespropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_propertiespropertieshubspotOwnerId = propertiespropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            var __workflow_propertiespropertieshubspotTeamId = propertiespropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            var __workflow_propertiespropertiesindustry = propertiespropertiesindustry == null ? null : WorkflowExpression.Compile(propertiespropertiesindustry);
            WorkflowExpression.Validate(__workflow_propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            var __workflow_propertiespropertiesisPublic = propertiespropertiesisPublic == null ? null : WorkflowExpression.Compile(propertiespropertiesisPublic);
            WorkflowExpression.Validate(__workflow_propertiespropertiesisPublic, nameof(propertiespropertiesisPublic), required: false);
            var __workflow_propertiespropertieslifecyclestage = propertiespropertieslifecyclestage == null ? null : WorkflowExpression.Compile(propertiespropertieslifecyclestage);
            WorkflowExpression.Validate(__workflow_propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            var __workflow_propertiespropertieslinkedinCompanyPage = propertiespropertieslinkedinCompanyPage == null ? null : WorkflowExpression.Compile(propertiespropertieslinkedinCompanyPage);
            WorkflowExpression.Validate(__workflow_propertiespropertieslinkedinCompanyPage, nameof(propertiespropertieslinkedinCompanyPage), required: false);
            var __workflow_propertiespropertieslinkedinbio = propertiespropertieslinkedinbio == null ? null : WorkflowExpression.Compile(propertiespropertieslinkedinbio);
            WorkflowExpression.Validate(__workflow_propertiespropertieslinkedinbio, nameof(propertiespropertieslinkedinbio), required: false);
            var __workflow_propertiespropertiesnotesLastContacted = propertiespropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            var __workflow_propertiespropertiesnotesLastUpdated = propertiespropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            var __workflow_propertiespropertiesnotesNextActivityDate = propertiespropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            var __workflow_propertiespropertiesnumAssociatedContacts = propertiespropertiesnumAssociatedContacts == null ? null : WorkflowExpression.Compile(propertiespropertiesnumAssociatedContacts);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumAssociatedContacts, nameof(propertiespropertiesnumAssociatedContacts), required: false);
            var __workflow_propertiespropertiesnumAssociatedDeals = propertiespropertiesnumAssociatedDeals == null ? null : WorkflowExpression.Compile(propertiespropertiesnumAssociatedDeals);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            var __workflow_propertiespropertiesnumContactedNotes = propertiespropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(propertiespropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            var __workflow_propertiespropertiesnumConversionEvents = propertiespropertiesnumConversionEvents == null ? null : WorkflowExpression.Compile(propertiespropertiesnumConversionEvents);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            var __workflow_propertiespropertiesnumberofemployees = propertiespropertiesnumberofemployees == null ? null : WorkflowExpression.Compile(propertiespropertiesnumberofemployees);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumberofemployees, nameof(propertiespropertiesnumberofemployees), required: false);
            var __workflow_propertiespropertiesphone = propertiespropertiesphone == null ? null : WorkflowExpression.Compile(propertiespropertiesphone);
            WorkflowExpression.Validate(__workflow_propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            var __workflow_propertiespropertiesrecentConversionDate = propertiespropertiesrecentConversionDate == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentConversionDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            var __workflow_propertiespropertiesrecentConversionEventName = propertiespropertiesrecentConversionEventName == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentConversionEventName);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            var __workflow_propertiespropertiesrecentDealAmount = propertiespropertiesrecentDealAmount == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentDealAmount);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            var __workflow_propertiespropertiesrecentDealCloseDate = propertiespropertiesrecentDealCloseDate == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentDealCloseDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            var __workflow_propertiespropertiesstate = propertiespropertiesstate == null ? null : WorkflowExpression.Compile(propertiespropertiesstate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            var __workflow_propertiespropertiestimezone = propertiespropertiestimezone == null ? null : WorkflowExpression.Compile(propertiespropertiestimezone);
            WorkflowExpression.Validate(__workflow_propertiespropertiestimezone, nameof(propertiespropertiestimezone), required: false);
            var __workflow_propertiespropertiestotalMoneyRaised = propertiespropertiestotalMoneyRaised == null ? null : WorkflowExpression.Compile(propertiespropertiestotalMoneyRaised);
            WorkflowExpression.Validate(__workflow_propertiespropertiestotalMoneyRaised, nameof(propertiespropertiestotalMoneyRaised), required: false);
            var __workflow_propertiespropertiestotalRevenue = propertiespropertiestotalRevenue == null ? null : WorkflowExpression.Compile(propertiespropertiestotalRevenue);
            WorkflowExpression.Validate(__workflow_propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            var __workflow_propertiespropertiestwitterbio = propertiespropertiestwitterbio == null ? null : WorkflowExpression.Compile(propertiespropertiestwitterbio);
            WorkflowExpression.Validate(__workflow_propertiespropertiestwitterbio, nameof(propertiespropertiestwitterbio), required: false);
            var __workflow_propertiespropertiestwitterfollowers = propertiespropertiestwitterfollowers == null ? null : WorkflowExpression.Compile(propertiespropertiestwitterfollowers);
            WorkflowExpression.Validate(__workflow_propertiespropertiestwitterfollowers, nameof(propertiespropertiestwitterfollowers), required: false);
            var __workflow_propertiespropertiestwitterhandle = propertiespropertiestwitterhandle == null ? null : WorkflowExpression.Compile(propertiespropertiestwitterhandle);
            WorkflowExpression.Validate(__workflow_propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            var __workflow_propertiespropertiestype = propertiespropertiestype == null ? null : WorkflowExpression.Compile(propertiespropertiestype);
            WorkflowExpression.Validate(__workflow_propertiespropertiestype, nameof(propertiespropertiestype), required: false);
            var __workflow_propertiespropertieswebTechnologies = propertiespropertieswebTechnologies == null ? null : WorkflowExpression.Compile(propertiespropertieswebTechnologies);
            WorkflowExpression.Validate(__workflow_propertiespropertieswebTechnologies, nameof(propertiespropertieswebTechnologies), required: false);
            var __workflow_propertiespropertieswebsite = propertiespropertieswebsite == null ? null : WorkflowExpression.Compile(propertiespropertieswebsite);
            WorkflowExpression.Validate(__workflow_propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            var __workflow_propertiespropertieszip = propertiespropertieszip == null ? null : WorkflowExpression.Compile(propertiespropertieszip);
            WorkflowExpression.Validate(__workflow_propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyId, 1));
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
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
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
            var __workflow_bodypropertiesaddress = bodypropertiesaddress == null ? null : WorkflowExpression.Compile(bodypropertiesaddress);
            WorkflowExpression.Validate(__workflow_bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            var __workflow_bodypropertiesannualrevenue = bodypropertiesannualrevenue == null ? null : WorkflowExpression.Compile(bodypropertiesannualrevenue);
            WorkflowExpression.Validate(__workflow_bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            var __workflow_bodypropertiescity = bodypropertiescity == null ? null : WorkflowExpression.Compile(bodypropertiescity);
            WorkflowExpression.Validate(__workflow_bodypropertiescity, nameof(bodypropertiescity), required: false);
            var __workflow_bodypropertiesclosedate = bodypropertiesclosedate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescompany = bodypropertiescompany == null ? null : WorkflowExpression.Compile(bodypropertiescompany);
            WorkflowExpression.Validate(__workflow_bodypropertiescompany, nameof(bodypropertiescompany), required: false);
            var __workflow_bodypropertiescompanySize = bodypropertiescompanySize == null ? null : WorkflowExpression.Compile(bodypropertiescompanySize);
            WorkflowExpression.Validate(__workflow_bodypropertiescompanySize, nameof(bodypropertiescompanySize), required: false);
            var __workflow_bodypropertiescountry = bodypropertiescountry == null ? null : WorkflowExpression.Compile(bodypropertiescountry);
            WorkflowExpression.Validate(__workflow_bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiescurrentlyinworkflow = bodypropertiescurrentlyinworkflow == null ? null : WorkflowExpression.Compile(bodypropertiescurrentlyinworkflow);
            WorkflowExpression.Validate(__workflow_bodypropertiescurrentlyinworkflow, nameof(bodypropertiescurrentlyinworkflow), required: false);
            var __workflow_bodypropertiesdateOfBirth = bodypropertiesdateOfBirth == null ? null : WorkflowExpression.Compile(bodypropertiesdateOfBirth);
            WorkflowExpression.Validate(__workflow_bodypropertiesdateOfBirth, nameof(bodypropertiesdateOfBirth), required: false);
            var __workflow_bodypropertiesdaysToClose = bodypropertiesdaysToClose == null ? null : WorkflowExpression.Compile(bodypropertiesdaysToClose);
            WorkflowExpression.Validate(__workflow_bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            var __workflow_bodypropertiesdegree = bodypropertiesdegree == null ? null : WorkflowExpression.Compile(bodypropertiesdegree);
            WorkflowExpression.Validate(__workflow_bodypropertiesdegree, nameof(bodypropertiesdegree), required: false);
            var __workflow_bodypropertiesemail = bodypropertiesemail == null ? null : WorkflowExpression.Compile(bodypropertiesemail);
            WorkflowExpression.Validate(__workflow_bodypropertiesemail, nameof(bodypropertiesemail), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = bodypropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = bodypropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = bodypropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = bodypropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertiesfax = bodypropertiesfax == null ? null : WorkflowExpression.Compile(bodypropertiesfax);
            WorkflowExpression.Validate(__workflow_bodypropertiesfax, nameof(bodypropertiesfax), required: false);
            var __workflow_bodypropertiesfieldOfStudy = bodypropertiesfieldOfStudy == null ? null : WorkflowExpression.Compile(bodypropertiesfieldOfStudy);
            WorkflowExpression.Validate(__workflow_bodypropertiesfieldOfStudy, nameof(bodypropertiesfieldOfStudy), required: false);
            var __workflow_bodypropertiesfirstConversionDate = bodypropertiesfirstConversionDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstConversionDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            var __workflow_bodypropertiesfirstConversionEventName = bodypropertiesfirstConversionEventName == null ? null : WorkflowExpression.Compile(bodypropertiesfirstConversionEventName);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            var __workflow_bodypropertiesfirstDealCreatedDate = bodypropertiesfirstDealCreatedDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstDealCreatedDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            var __workflow_bodypropertiesfirstname = bodypropertiesfirstname == null ? null : WorkflowExpression.Compile(bodypropertiesfirstname);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstname, nameof(bodypropertiesfirstname), required: false);
            var __workflow_bodypropertiesgender = bodypropertiesgender == null ? null : WorkflowExpression.Compile(bodypropertiesgender);
            WorkflowExpression.Validate(__workflow_bodypropertiesgender, nameof(bodypropertiesgender), required: false);
            var __workflow_bodypropertiesgraduationDate = bodypropertiesgraduationDate == null ? null : WorkflowExpression.Compile(bodypropertiesgraduationDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesgraduationDate, nameof(bodypropertiesgraduationDate), required: false);
            var __workflow_bodypropertieshsAnalyticsAveragePageViews = bodypropertieshsAnalyticsAveragePageViews == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsAveragePageViews);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsAveragePageViews, nameof(bodypropertieshsAnalyticsAveragePageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstReferrer = bodypropertieshsAnalyticsFirstReferrer == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstReferrer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstReferrer, nameof(bodypropertieshsAnalyticsFirstReferrer), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTimestamp = bodypropertieshsAnalyticsFirstTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign = bodypropertieshsAnalyticsFirstTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstUrl = bodypropertieshsAnalyticsFirstUrl == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstUrl);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstUrl, nameof(bodypropertieshsAnalyticsFirstUrl), required: false);
            var __workflow_bodypropertieshsAnalyticsFirstVisitTimestamp = bodypropertieshsAnalyticsFirstVisitTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsFirstVisitTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastReferrer = bodypropertieshsAnalyticsLastReferrer == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastReferrer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastReferrer, nameof(bodypropertieshsAnalyticsLastReferrer), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTimestamp = bodypropertieshsAnalyticsLastTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign = bodypropertieshsAnalyticsLastTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_bodypropertieshsAnalyticsLastUrl = bodypropertieshsAnalyticsLastUrl == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastUrl);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastUrl, nameof(bodypropertieshsAnalyticsLastUrl), required: false);
            var __workflow_bodypropertieshsAnalyticsLastVisitTimestamp = bodypropertieshsAnalyticsLastVisitTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsLastVisitTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_bodypropertieshsAnalyticsNumEventCompletions = bodypropertieshsAnalyticsNumEventCompletions == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsNumEventCompletions);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsNumEventCompletions, nameof(bodypropertieshsAnalyticsNumEventCompletions), required: false);
            var __workflow_bodypropertieshsAnalyticsNumPageViews = bodypropertieshsAnalyticsNumPageViews == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsNumPageViews);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_bodypropertieshsAnalyticsNumVisits = bodypropertieshsAnalyticsNumVisits == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsNumVisits);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            var __workflow_bodypropertieshsAnalyticsRevenue = bodypropertieshsAnalyticsRevenue == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsRevenue);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsRevenue, nameof(bodypropertieshsAnalyticsRevenue), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = bodypropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = bodypropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = bodypropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsBuyingRole = bodypropertieshsBuyingRole == null ? null : WorkflowExpression.Compile(bodypropertieshsBuyingRole);
            WorkflowExpression.Validate(__workflow_bodypropertieshsBuyingRole, nameof(bodypropertieshsBuyingRole), required: false);
            var __workflow_bodypropertieshsContentMembershipEmailConfirmed = bodypropertieshsContentMembershipEmailConfirmed == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipEmailConfirmed);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipEmailConfirmed, nameof(bodypropertieshsContentMembershipEmailConfirmed), required: false);
            var __workflow_bodypropertieshsContentMembershipNotes = bodypropertieshsContentMembershipNotes == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipNotes);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipNotes, nameof(bodypropertieshsContentMembershipNotes), required: false);
            var __workflow_bodypropertieshsContentMembershipRegisteredAt = bodypropertieshsContentMembershipRegisteredAt == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipRegisteredAt);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipRegisteredAt, nameof(bodypropertieshsContentMembershipRegisteredAt), required: false);
            var __workflow_bodypropertieshsContentMembershipRegistrationDomainSentTo = bodypropertieshsContentMembershipRegistrationDomainSentTo == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipRegistrationDomainSentTo);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipRegistrationDomainSentTo, nameof(bodypropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            var __workflow_bodypropertieshsContentMembershipRegistrationEmailSentAt = bodypropertieshsContentMembershipRegistrationEmailSentAt == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipRegistrationEmailSentAt);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipRegistrationEmailSentAt, nameof(bodypropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            var __workflow_bodypropertieshsContentMembershipStatus = bodypropertieshsContentMembershipStatus == null ? null : WorkflowExpression.Compile(bodypropertieshsContentMembershipStatus);
            WorkflowExpression.Validate(__workflow_bodypropertieshsContentMembershipStatus, nameof(bodypropertieshsContentMembershipStatus), required: false);
            var __workflow_bodypropertieshsCreatedate = bodypropertieshsCreatedate == null ? null : WorkflowExpression.Compile(bodypropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsEmailBadAddress = bodypropertieshsEmailBadAddress == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailBadAddress);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailBadAddress, nameof(bodypropertieshsEmailBadAddress), required: false);
            var __workflow_bodypropertieshsEmailBounce = bodypropertieshsEmailBounce == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailBounce);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailBounce, nameof(bodypropertieshsEmailBounce), required: false);
            var __workflow_bodypropertieshsEmailClick = bodypropertieshsEmailClick == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailClick);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailClick, nameof(bodypropertieshsEmailClick), required: false);
            var __workflow_bodypropertieshsEmailCustomerQuarantinedReason = bodypropertieshsEmailCustomerQuarantinedReason == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailCustomerQuarantinedReason);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailCustomerQuarantinedReason, nameof(bodypropertieshsEmailCustomerQuarantinedReason), required: false);
            var __workflow_bodypropertieshsEmailDelivered = bodypropertieshsEmailDelivered == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailDelivered);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailDelivered, nameof(bodypropertieshsEmailDelivered), required: false);
            var __workflow_bodypropertieshsEmailDomain = bodypropertieshsEmailDomain == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailDomain);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailDomain, nameof(bodypropertieshsEmailDomain), required: false);
            var __workflow_bodypropertieshsEmailFirstClickDate = bodypropertieshsEmailFirstClickDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailFirstClickDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailFirstClickDate, nameof(bodypropertieshsEmailFirstClickDate), required: false);
            var __workflow_bodypropertieshsEmailFirstOpenDate = bodypropertieshsEmailFirstOpenDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailFirstOpenDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailFirstOpenDate, nameof(bodypropertieshsEmailFirstOpenDate), required: false);
            var __workflow_bodypropertieshsEmailFirstReplyDate = bodypropertieshsEmailFirstReplyDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailFirstReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailFirstReplyDate, nameof(bodypropertieshsEmailFirstReplyDate), required: false);
            var __workflow_bodypropertieshsEmailFirstSendDate = bodypropertieshsEmailFirstSendDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailFirstSendDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailFirstSendDate, nameof(bodypropertieshsEmailFirstSendDate), required: false);
            var __workflow_bodypropertieshsEmailHardBounceReasonEnum = bodypropertieshsEmailHardBounceReasonEnum == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailHardBounceReasonEnum);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailHardBounceReasonEnum, nameof(bodypropertieshsEmailHardBounceReasonEnum), required: false);
            var __workflow_bodypropertieshsEmailLastClickDate = bodypropertieshsEmailLastClickDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailLastClickDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailLastClickDate, nameof(bodypropertieshsEmailLastClickDate), required: false);
            var __workflow_bodypropertieshsEmailLastEmailName = bodypropertieshsEmailLastEmailName == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailLastEmailName);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailLastEmailName, nameof(bodypropertieshsEmailLastEmailName), required: false);
            var __workflow_bodypropertieshsEmailLastOpenDate = bodypropertieshsEmailLastOpenDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailLastOpenDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailLastOpenDate, nameof(bodypropertieshsEmailLastOpenDate), required: false);
            var __workflow_bodypropertieshsEmailLastReplyDate = bodypropertieshsEmailLastReplyDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailLastReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailLastReplyDate, nameof(bodypropertieshsEmailLastReplyDate), required: false);
            var __workflow_bodypropertieshsEmailLastSendDate = bodypropertieshsEmailLastSendDate == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailLastSendDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailLastSendDate, nameof(bodypropertieshsEmailLastSendDate), required: false);
            var __workflow_bodypropertieshsEmailOpen = bodypropertieshsEmailOpen == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailOpen);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailOpen, nameof(bodypropertieshsEmailOpen), required: false);
            var __workflow_bodypropertieshsEmailOptout = bodypropertieshsEmailOptout == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailOptout);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailOptout, nameof(bodypropertieshsEmailOptout), required: false);
            var __workflow_bodypropertieshsEmailOptout12592317 = bodypropertieshsEmailOptout12592317 == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailOptout12592317);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailOptout12592317, nameof(bodypropertieshsEmailOptout12592317), required: false);
            var __workflow_bodypropertieshsEmailQuarantined = bodypropertieshsEmailQuarantined == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailQuarantined);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailQuarantined, nameof(bodypropertieshsEmailQuarantined), required: false);
            var __workflow_bodypropertieshsEmailQuarantinedReason = bodypropertieshsEmailQuarantinedReason == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailQuarantinedReason);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailQuarantinedReason, nameof(bodypropertieshsEmailQuarantinedReason), required: false);
            var __workflow_bodypropertieshsEmailReplied = bodypropertieshsEmailReplied == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailReplied);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailReplied, nameof(bodypropertieshsEmailReplied), required: false);
            var __workflow_bodypropertieshsEmailSendsSinceLastEngagement = bodypropertieshsEmailSendsSinceLastEngagement == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailSendsSinceLastEngagement);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailSendsSinceLastEngagement, nameof(bodypropertieshsEmailSendsSinceLastEngagement), required: false);
            var __workflow_bodypropertieshsEmailconfirmationstatus = bodypropertieshsEmailconfirmationstatus == null ? null : WorkflowExpression.Compile(bodypropertieshsEmailconfirmationstatus);
            WorkflowExpression.Validate(__workflow_bodypropertieshsEmailconfirmationstatus, nameof(bodypropertieshsEmailconfirmationstatus), required: false);
            var __workflow_bodypropertieshsFacebookClickId = bodypropertieshsFacebookClickId == null ? null : WorkflowExpression.Compile(bodypropertieshsFacebookClickId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFacebookClickId, nameof(bodypropertieshsFacebookClickId), required: false);
            var __workflow_bodypropertieshsFeedbackLastNpsFollowUp = bodypropertieshsFeedbackLastNpsFollowUp == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastNpsFollowUp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastNpsFollowUp, nameof(bodypropertieshsFeedbackLastNpsFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastNpsRating = bodypropertieshsFeedbackLastNpsRating == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastNpsRating);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastNpsRating, nameof(bodypropertieshsFeedbackLastNpsRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = bodypropertieshsFeedbackLastSurveyDate == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsGoogleClickId = bodypropertieshsGoogleClickId == null ? null : WorkflowExpression.Compile(bodypropertieshsGoogleClickId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsGoogleClickId, nameof(bodypropertieshsGoogleClickId), required: false);
            var __workflow_bodypropertieshsIpTimezone = bodypropertieshsIpTimezone == null ? null : WorkflowExpression.Compile(bodypropertieshsIpTimezone);
            WorkflowExpression.Validate(__workflow_bodypropertieshsIpTimezone, nameof(bodypropertieshsIpTimezone), required: false);
            var __workflow_bodypropertieshsIsUnworked = bodypropertieshsIsUnworked == null ? null : WorkflowExpression.Compile(bodypropertieshsIsUnworked);
            WorkflowExpression.Validate(__workflow_bodypropertieshsIsUnworked, nameof(bodypropertieshsIsUnworked), required: false);
            var __workflow_bodypropertieshsLanguage = bodypropertieshsLanguage == null ? null : WorkflowExpression.Compile(bodypropertieshsLanguage);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLanguage, nameof(bodypropertieshsLanguage), required: false);
            var __workflow_bodypropertieshsLastSalesActivityTimestamp = bodypropertieshsLastSalesActivityTimestamp == null ? null : WorkflowExpression.Compile(bodypropertieshsLastSalesActivityTimestamp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_bodypropertieshsLeadStatus = bodypropertieshsLeadStatus == null ? null : WorkflowExpression.Compile(bodypropertieshsLeadStatus);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            var __workflow_bodypropertieshsLegalBasis = bodypropertieshsLegalBasis == null ? null : WorkflowExpression.Compile(bodypropertieshsLegalBasis);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLegalBasis, nameof(bodypropertieshsLegalBasis), required: false);
            var __workflow_bodypropertieshsLifecyclestageCustomerDate = bodypropertieshsLifecyclestageCustomerDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageCustomerDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageCustomerDate, nameof(bodypropertieshsLifecyclestageCustomerDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageEvangelistDate = bodypropertieshsLifecyclestageEvangelistDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageEvangelistDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageEvangelistDate, nameof(bodypropertieshsLifecyclestageEvangelistDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageLeadDate = bodypropertieshsLifecyclestageLeadDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageLeadDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageLeadDate, nameof(bodypropertieshsLifecyclestageLeadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageMarketingqualifiedleadDate = bodypropertieshsLifecyclestageMarketingqualifiedleadDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageMarketingqualifiedleadDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(bodypropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageOpportunityDate = bodypropertieshsLifecyclestageOpportunityDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageOpportunityDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageOpportunityDate, nameof(bodypropertieshsLifecyclestageOpportunityDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageOtherDate = bodypropertieshsLifecyclestageOtherDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageOtherDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageOtherDate, nameof(bodypropertieshsLifecyclestageOtherDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageSalesqualifiedleadDate = bodypropertieshsLifecyclestageSalesqualifiedleadDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageSalesqualifiedleadDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageSalesqualifiedleadDate, nameof(bodypropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            var __workflow_bodypropertieshsLifecyclestageSubscriberDate = bodypropertieshsLifecyclestageSubscriberDate == null ? null : WorkflowExpression.Compile(bodypropertieshsLifecyclestageSubscriberDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLifecyclestageSubscriberDate, nameof(bodypropertieshsLifecyclestageSubscriberDate), required: false);
            var __workflow_bodypropertieshsMarketableReasonId = bodypropertieshsMarketableReasonId == null ? null : WorkflowExpression.Compile(bodypropertieshsMarketableReasonId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMarketableReasonId, nameof(bodypropertieshsMarketableReasonId), required: false);
            var __workflow_bodypropertieshsMarketableReasonType = bodypropertieshsMarketableReasonType == null ? null : WorkflowExpression.Compile(bodypropertieshsMarketableReasonType);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMarketableReasonType, nameof(bodypropertieshsMarketableReasonType), required: false);
            var __workflow_bodypropertieshsMarketableStatus = bodypropertieshsMarketableStatus == null ? null : WorkflowExpression.Compile(bodypropertieshsMarketableStatus);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMarketableStatus, nameof(bodypropertieshsMarketableStatus), required: false);
            var __workflow_bodypropertieshsMarketableUntilRenewal = bodypropertieshsMarketableUntilRenewal == null ? null : WorkflowExpression.Compile(bodypropertieshsMarketableUntilRenewal);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMarketableUntilRenewal, nameof(bodypropertieshsMarketableUntilRenewal), required: false);
            var __workflow_bodypropertieshsObjectId = bodypropertieshsObjectId == null ? null : WorkflowExpression.Compile(bodypropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPersona = bodypropertieshsPersona == null ? null : WorkflowExpression.Compile(bodypropertieshsPersona);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPersona, nameof(bodypropertieshsPersona), required: false);
            var __workflow_bodypropertieshsPredictivecontactscore = bodypropertieshsPredictivecontactscore == null ? null : WorkflowExpression.Compile(bodypropertieshsPredictivecontactscore);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPredictivecontactscore, nameof(bodypropertieshsPredictivecontactscore), required: false);
            var __workflow_bodypropertieshsPredictivecontactscoreV2 = bodypropertieshsPredictivecontactscoreV2 == null ? null : WorkflowExpression.Compile(bodypropertieshsPredictivecontactscoreV2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_bodypropertieshsPredictivecontactscorebucket = bodypropertieshsPredictivecontactscorebucket == null ? null : WorkflowExpression.Compile(bodypropertieshsPredictivecontactscorebucket);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPredictivecontactscorebucket, nameof(bodypropertieshsPredictivecontactscorebucket), required: false);
            var __workflow_bodypropertieshsPredictivescoringtier = bodypropertieshsPredictivescoringtier == null ? null : WorkflowExpression.Compile(bodypropertieshsPredictivescoringtier);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPredictivescoringtier, nameof(bodypropertieshsPredictivescoringtier), required: false);
            var __workflow_bodypropertieshsSalesEmailLastClicked = bodypropertieshsSalesEmailLastClicked == null ? null : WorkflowExpression.Compile(bodypropertieshsSalesEmailLastClicked);
            WorkflowExpression.Validate(__workflow_bodypropertieshsSalesEmailLastClicked, nameof(bodypropertieshsSalesEmailLastClicked), required: false);
            var __workflow_bodypropertieshsSalesEmailLastOpened = bodypropertieshsSalesEmailLastOpened == null ? null : WorkflowExpression.Compile(bodypropertieshsSalesEmailLastOpened);
            WorkflowExpression.Validate(__workflow_bodypropertieshsSalesEmailLastOpened, nameof(bodypropertieshsSalesEmailLastOpened), required: false);
            var __workflow_bodypropertieshsSalesEmailLastReplied = bodypropertieshsSalesEmailLastReplied == null ? null : WorkflowExpression.Compile(bodypropertieshsSalesEmailLastReplied);
            WorkflowExpression.Validate(__workflow_bodypropertieshsSalesEmailLastReplied, nameof(bodypropertieshsSalesEmailLastReplied), required: false);
            var __workflow_bodypropertieshsSequencesIsEnrolled = bodypropertieshsSequencesIsEnrolled == null ? null : WorkflowExpression.Compile(bodypropertieshsSequencesIsEnrolled);
            WorkflowExpression.Validate(__workflow_bodypropertieshsSequencesIsEnrolled, nameof(bodypropertieshsSequencesIsEnrolled), required: false);
            var __workflow_bodypropertieshsTimeBetweenContactCreationAndDealClose = bodypropertieshsTimeBetweenContactCreationAndDealClose == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeBetweenContactCreationAndDealClose);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeBetweenContactCreationAndDealClose, nameof(bodypropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            var __workflow_bodypropertieshsTimeBetweenContactCreationAndDealCreation = bodypropertieshsTimeBetweenContactCreationAndDealCreation == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeBetweenContactCreationAndDealCreation);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeBetweenContactCreationAndDealCreation, nameof(bodypropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromLeadToCustomer = bodypropertieshsTimeToMoveFromLeadToCustomer == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromLeadToCustomer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeToMoveFromLeadToCustomer, nameof(bodypropertieshsTimeToMoveFromLeadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromOpportunityToCustomer = bodypropertieshsTimeToMoveFromOpportunityToCustomer == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromOpportunityToCustomer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeToMoveFromOpportunityToCustomer, nameof(bodypropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            var __workflow_bodypropertieshsTimeToMoveFromSubscriberToCustomer = bodypropertieshsTimeToMoveFromSubscriberToCustomer == null ? null : WorkflowExpression.Compile(bodypropertieshsTimeToMoveFromSubscriberToCustomer);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTimeToMoveFromSubscriberToCustomer, nameof(bodypropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertieshubspotscore = bodypropertieshubspotscore == null ? null : WorkflowExpression.Compile(bodypropertieshubspotscore);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotscore, nameof(bodypropertieshubspotscore), required: false);
            var __workflow_bodypropertiesindustry = bodypropertiesindustry == null ? null : WorkflowExpression.Compile(bodypropertiesindustry);
            WorkflowExpression.Validate(__workflow_bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            var __workflow_bodypropertiesipCity = bodypropertiesipCity == null ? null : WorkflowExpression.Compile(bodypropertiesipCity);
            WorkflowExpression.Validate(__workflow_bodypropertiesipCity, nameof(bodypropertiesipCity), required: false);
            var __workflow_bodypropertiesipCountry = bodypropertiesipCountry == null ? null : WorkflowExpression.Compile(bodypropertiesipCountry);
            WorkflowExpression.Validate(__workflow_bodypropertiesipCountry, nameof(bodypropertiesipCountry), required: false);
            var __workflow_bodypropertiesipCountryCode = bodypropertiesipCountryCode == null ? null : WorkflowExpression.Compile(bodypropertiesipCountryCode);
            WorkflowExpression.Validate(__workflow_bodypropertiesipCountryCode, nameof(bodypropertiesipCountryCode), required: false);
            var __workflow_bodypropertiesipState = bodypropertiesipState == null ? null : WorkflowExpression.Compile(bodypropertiesipState);
            WorkflowExpression.Validate(__workflow_bodypropertiesipState, nameof(bodypropertiesipState), required: false);
            var __workflow_bodypropertiesipStateCode = bodypropertiesipStateCode == null ? null : WorkflowExpression.Compile(bodypropertiesipStateCode);
            WorkflowExpression.Validate(__workflow_bodypropertiesipStateCode, nameof(bodypropertiesipStateCode), required: false);
            var __workflow_bodypropertiesjobFunction = bodypropertiesjobFunction == null ? null : WorkflowExpression.Compile(bodypropertiesjobFunction);
            WorkflowExpression.Validate(__workflow_bodypropertiesjobFunction, nameof(bodypropertiesjobFunction), required: false);
            var __workflow_bodypropertiesjobtitle = bodypropertiesjobtitle == null ? null : WorkflowExpression.Compile(bodypropertiesjobtitle);
            WorkflowExpression.Validate(__workflow_bodypropertiesjobtitle, nameof(bodypropertiesjobtitle), required: false);
            var __workflow_bodypropertieslastmodifieddate = bodypropertieslastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieslastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieslastmodifieddate, nameof(bodypropertieslastmodifieddate), required: false);
            var __workflow_bodypropertieslastname = bodypropertieslastname == null ? null : WorkflowExpression.Compile(bodypropertieslastname);
            WorkflowExpression.Validate(__workflow_bodypropertieslastname, nameof(bodypropertieslastname), required: false);
            var __workflow_bodypropertieslifecyclestage = bodypropertieslifecyclestage == null ? null : WorkflowExpression.Compile(bodypropertieslifecyclestage);
            WorkflowExpression.Validate(__workflow_bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            var __workflow_bodypropertiesmaritalStatus = bodypropertiesmaritalStatus == null ? null : WorkflowExpression.Compile(bodypropertiesmaritalStatus);
            WorkflowExpression.Validate(__workflow_bodypropertiesmaritalStatus, nameof(bodypropertiesmaritalStatus), required: false);
            var __workflow_bodypropertiesmessage = bodypropertiesmessage == null ? null : WorkflowExpression.Compile(bodypropertiesmessage);
            WorkflowExpression.Validate(__workflow_bodypropertiesmessage, nameof(bodypropertiesmessage), required: false);
            var __workflow_bodypropertiesmilitaryStatus = bodypropertiesmilitaryStatus == null ? null : WorkflowExpression.Compile(bodypropertiesmilitaryStatus);
            WorkflowExpression.Validate(__workflow_bodypropertiesmilitaryStatus, nameof(bodypropertiesmilitaryStatus), required: false);
            var __workflow_bodypropertiesmobilephone = bodypropertiesmobilephone == null ? null : WorkflowExpression.Compile(bodypropertiesmobilephone);
            WorkflowExpression.Validate(__workflow_bodypropertiesmobilephone, nameof(bodypropertiesmobilephone), required: false);
            var __workflow_bodypropertiesnotesLastContacted = bodypropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = bodypropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = bodypropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedDeals = bodypropertiesnumAssociatedDeals == null ? null : WorkflowExpression.Compile(bodypropertiesnumAssociatedDeals);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            var __workflow_bodypropertiesnumContactedNotes = bodypropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumConversionEvents = bodypropertiesnumConversionEvents == null ? null : WorkflowExpression.Compile(bodypropertiesnumConversionEvents);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            var __workflow_bodypropertiesnumNotes = bodypropertiesnumNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiesnumUniqueConversionEvents = bodypropertiesnumUniqueConversionEvents == null ? null : WorkflowExpression.Compile(bodypropertiesnumUniqueConversionEvents);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumUniqueConversionEvents, nameof(bodypropertiesnumUniqueConversionEvents), required: false);
            var __workflow_bodypropertiesnumemployees = bodypropertiesnumemployees == null ? null : WorkflowExpression.Compile(bodypropertiesnumemployees);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumemployees, nameof(bodypropertiesnumemployees), required: false);
            var __workflow_bodypropertiesphone = bodypropertiesphone == null ? null : WorkflowExpression.Compile(bodypropertiesphone);
            WorkflowExpression.Validate(__workflow_bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            var __workflow_bodypropertiesrecentConversionDate = bodypropertiesrecentConversionDate == null ? null : WorkflowExpression.Compile(bodypropertiesrecentConversionDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            var __workflow_bodypropertiesrecentConversionEventName = bodypropertiesrecentConversionEventName == null ? null : WorkflowExpression.Compile(bodypropertiesrecentConversionEventName);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            var __workflow_bodypropertiesrecentDealAmount = bodypropertiesrecentDealAmount == null ? null : WorkflowExpression.Compile(bodypropertiesrecentDealAmount);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            var __workflow_bodypropertiesrecentDealCloseDate = bodypropertiesrecentDealCloseDate == null ? null : WorkflowExpression.Compile(bodypropertiesrecentDealCloseDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            var __workflow_bodypropertiesrelationshipStatus = bodypropertiesrelationshipStatus == null ? null : WorkflowExpression.Compile(bodypropertiesrelationshipStatus);
            WorkflowExpression.Validate(__workflow_bodypropertiesrelationshipStatus, nameof(bodypropertiesrelationshipStatus), required: false);
            var __workflow_bodypropertiessalutation = bodypropertiessalutation == null ? null : WorkflowExpression.Compile(bodypropertiessalutation);
            WorkflowExpression.Validate(__workflow_bodypropertiessalutation, nameof(bodypropertiessalutation), required: false);
            var __workflow_bodypropertiesschool = bodypropertiesschool == null ? null : WorkflowExpression.Compile(bodypropertiesschool);
            WorkflowExpression.Validate(__workflow_bodypropertiesschool, nameof(bodypropertiesschool), required: false);
            var __workflow_bodypropertiesseniority = bodypropertiesseniority == null ? null : WorkflowExpression.Compile(bodypropertiesseniority);
            WorkflowExpression.Validate(__workflow_bodypropertiesseniority, nameof(bodypropertiesseniority), required: false);
            var __workflow_bodypropertiesstartDate = bodypropertiesstartDate == null ? null : WorkflowExpression.Compile(bodypropertiesstartDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesstartDate, nameof(bodypropertiesstartDate), required: false);
            var __workflow_bodypropertiesstate = bodypropertiesstate == null ? null : WorkflowExpression.Compile(bodypropertiesstate);
            WorkflowExpression.Validate(__workflow_bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            var __workflow_bodypropertiestotalRevenue = bodypropertiestotalRevenue == null ? null : WorkflowExpression.Compile(bodypropertiestotalRevenue);
            WorkflowExpression.Validate(__workflow_bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            var __workflow_bodypropertiestwitterhandle = bodypropertiestwitterhandle == null ? null : WorkflowExpression.Compile(bodypropertiestwitterhandle);
            WorkflowExpression.Validate(__workflow_bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            var __workflow_bodypropertieswebsite = bodypropertieswebsite == null ? null : WorkflowExpression.Compile(bodypropertieswebsite);
            WorkflowExpression.Validate(__workflow_bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            var __workflow_bodypropertiesworkEmail = bodypropertiesworkEmail == null ? null : WorkflowExpression.Compile(bodypropertiesworkEmail);
            WorkflowExpression.Validate(__workflow_bodypropertiesworkEmail, nameof(bodypropertiesworkEmail), required: false);
            var __workflow_bodypropertieszip = bodypropertieszip == null ? null : WorkflowExpression.Compile(bodypropertieszip);
            WorkflowExpression.Validate(__workflow_bodypropertieszip, nameof(bodypropertieszip), required: false);
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
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsArchive(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsUpdate(Expression<Func<string>> contactId, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescompany = null, Expression<Func<string>> propertiespropertiescompanySize = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiescurrentlyinworkflow = null, Expression<Func<string>> propertiespropertiesdateOfBirth = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdegree = null, Expression<Func<string>> propertiespropertiesemail = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfax = null, Expression<Func<string>> propertiespropertiesfieldOfStudy = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfirstname = null, Expression<Func<string>> propertiespropertiesgender = null, Expression<Func<string>> propertiespropertiesgraduationDate = null, Expression<Func<string>> propertiespropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsRevenue = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsBuyingRole = null, Expression<Func<string>> propertiespropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> propertiespropertieshsContentMembershipNotes = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipStatus = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsEmailBadAddress = null, Expression<Func<string>> propertiespropertieshsEmailBounce = null, Expression<Func<string>> propertiespropertieshsEmailClick = null, Expression<Func<string>> propertiespropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailDelivered = null, Expression<Func<string>> propertiespropertieshsEmailDomain = null, Expression<Func<string>> propertiespropertieshsEmailFirstClickDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstSendDate = null, Expression<Func<string>> propertiespropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> propertiespropertieshsEmailLastClickDate = null, Expression<Func<string>> propertiespropertieshsEmailLastEmailName = null, Expression<Func<string>> propertiespropertieshsEmailLastOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailLastReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailLastSendDate = null, Expression<Func<string>> propertiespropertieshsEmailOpen = null, Expression<Func<string>> propertiespropertieshsEmailOptout = null, Expression<Func<string>> propertiespropertieshsEmailOptout12592317 = null, Expression<Func<string>> propertiespropertieshsEmailQuarantined = null, Expression<Func<string>> propertiespropertieshsEmailQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailReplied = null, Expression<Func<string>> propertiespropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> propertiespropertieshsEmailconfirmationstatus = null, Expression<Func<string>> propertiespropertieshsFacebookClickId = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> propertiespropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> propertiespropertieshsGoogleClickId = null, Expression<Func<string>> propertiespropertieshsIpTimezone = null, Expression<Func<string>> propertiespropertieshsIsUnworked = null, Expression<Func<string>> propertiespropertieshsLanguage = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsLegalBasis = null, Expression<Func<string>> propertiespropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> propertiespropertieshsMarketableReasonId = null, Expression<Func<string>> propertiespropertieshsMarketableReasonType = null, Expression<Func<string>> propertiespropertieshsMarketableStatus = null, Expression<Func<string>> propertiespropertieshsMarketableUntilRenewal = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsPersona = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscore = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> propertiespropertieshsPredictivescoringtier = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastClicked = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastOpened = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastReplied = null, Expression<Func<string>> propertiespropertieshsSequencesIsEnrolled = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertieshubspotscore = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesipCity = null, Expression<Func<string>> propertiespropertiesipCountry = null, Expression<Func<string>> propertiespropertiesipCountryCode = null, Expression<Func<string>> propertiespropertiesipState = null, Expression<Func<string>> propertiespropertiesipStateCode = null, Expression<Func<string>> propertiespropertiesjobFunction = null, Expression<Func<string>> propertiespropertiesjobtitle = null, Expression<Func<string>> propertiespropertieslastmodifieddate = null, Expression<Func<string>> propertiespropertieslastname = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertiesmaritalStatus = null, Expression<Func<string>> propertiespropertiesmessage = null, Expression<Func<string>> propertiespropertiesmilitaryStatus = null, Expression<Func<string>> propertiespropertiesmobilephone = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumNotes = null, Expression<Func<string>> propertiespropertiesnumUniqueConversionEvents = null, Expression<Func<string>> propertiespropertiesnumemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesrelationshipStatus = null, Expression<Func<string>> propertiespropertiessalutation = null, Expression<Func<string>> propertiespropertiesschool = null, Expression<Func<string>> propertiespropertiesseniority = null, Expression<Func<string>> propertiespropertiesstartDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertiesworkEmail = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            var __workflow_propertiespropertiesaddress = propertiespropertiesaddress == null ? null : WorkflowExpression.Compile(propertiespropertiesaddress);
            WorkflowExpression.Validate(__workflow_propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            var __workflow_propertiespropertiesannualrevenue = propertiespropertiesannualrevenue == null ? null : WorkflowExpression.Compile(propertiespropertiesannualrevenue);
            WorkflowExpression.Validate(__workflow_propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            var __workflow_propertiespropertiescity = propertiespropertiescity == null ? null : WorkflowExpression.Compile(propertiespropertiescity);
            WorkflowExpression.Validate(__workflow_propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            var __workflow_propertiespropertiesclosedate = propertiespropertiesclosedate == null ? null : WorkflowExpression.Compile(propertiespropertiesclosedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            var __workflow_propertiespropertiescompany = propertiespropertiescompany == null ? null : WorkflowExpression.Compile(propertiespropertiescompany);
            WorkflowExpression.Validate(__workflow_propertiespropertiescompany, nameof(propertiespropertiescompany), required: false);
            var __workflow_propertiespropertiescompanySize = propertiespropertiescompanySize == null ? null : WorkflowExpression.Compile(propertiespropertiescompanySize);
            WorkflowExpression.Validate(__workflow_propertiespropertiescompanySize, nameof(propertiespropertiescompanySize), required: false);
            var __workflow_propertiespropertiescountry = propertiespropertiescountry == null ? null : WorkflowExpression.Compile(propertiespropertiescountry);
            WorkflowExpression.Validate(__workflow_propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            var __workflow_propertiespropertiescreatedate = propertiespropertiescreatedate == null ? null : WorkflowExpression.Compile(propertiespropertiescreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiescurrentlyinworkflow = propertiespropertiescurrentlyinworkflow == null ? null : WorkflowExpression.Compile(propertiespropertiescurrentlyinworkflow);
            WorkflowExpression.Validate(__workflow_propertiespropertiescurrentlyinworkflow, nameof(propertiespropertiescurrentlyinworkflow), required: false);
            var __workflow_propertiespropertiesdateOfBirth = propertiespropertiesdateOfBirth == null ? null : WorkflowExpression.Compile(propertiespropertiesdateOfBirth);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdateOfBirth, nameof(propertiespropertiesdateOfBirth), required: false);
            var __workflow_propertiespropertiesdaysToClose = propertiespropertiesdaysToClose == null ? null : WorkflowExpression.Compile(propertiespropertiesdaysToClose);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            var __workflow_propertiespropertiesdegree = propertiespropertiesdegree == null ? null : WorkflowExpression.Compile(propertiespropertiesdegree);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdegree, nameof(propertiespropertiesdegree), required: false);
            var __workflow_propertiespropertiesemail = propertiespropertiesemail == null ? null : WorkflowExpression.Compile(propertiespropertiesemail);
            WorkflowExpression.Validate(__workflow_propertiespropertiesemail, nameof(propertiespropertiesemail), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBooked = propertiespropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedCampaign = propertiespropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedMedium = propertiespropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_propertiespropertiesengagementsLastMeetingBookedSource = propertiespropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(propertiespropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_propertiespropertiesfax = propertiespropertiesfax == null ? null : WorkflowExpression.Compile(propertiespropertiesfax);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfax, nameof(propertiespropertiesfax), required: false);
            var __workflow_propertiespropertiesfieldOfStudy = propertiespropertiesfieldOfStudy == null ? null : WorkflowExpression.Compile(propertiespropertiesfieldOfStudy);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfieldOfStudy, nameof(propertiespropertiesfieldOfStudy), required: false);
            var __workflow_propertiespropertiesfirstConversionDate = propertiespropertiesfirstConversionDate == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstConversionDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            var __workflow_propertiespropertiesfirstConversionEventName = propertiespropertiesfirstConversionEventName == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstConversionEventName);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            var __workflow_propertiespropertiesfirstDealCreatedDate = propertiespropertiesfirstDealCreatedDate == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstDealCreatedDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            var __workflow_propertiespropertiesfirstname = propertiespropertiesfirstname == null ? null : WorkflowExpression.Compile(propertiespropertiesfirstname);
            WorkflowExpression.Validate(__workflow_propertiespropertiesfirstname, nameof(propertiespropertiesfirstname), required: false);
            var __workflow_propertiespropertiesgender = propertiespropertiesgender == null ? null : WorkflowExpression.Compile(propertiespropertiesgender);
            WorkflowExpression.Validate(__workflow_propertiespropertiesgender, nameof(propertiespropertiesgender), required: false);
            var __workflow_propertiespropertiesgraduationDate = propertiespropertiesgraduationDate == null ? null : WorkflowExpression.Compile(propertiespropertiesgraduationDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesgraduationDate, nameof(propertiespropertiesgraduationDate), required: false);
            var __workflow_propertiespropertieshsAnalyticsAveragePageViews = propertiespropertieshsAnalyticsAveragePageViews == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsAveragePageViews);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsAveragePageViews, nameof(propertiespropertieshsAnalyticsAveragePageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstReferrer = propertiespropertieshsAnalyticsFirstReferrer == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstReferrer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstReferrer, nameof(propertiespropertieshsAnalyticsFirstReferrer), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTimestamp = propertiespropertieshsAnalyticsFirstTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = propertiespropertieshsAnalyticsFirstTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstUrl = propertiespropertieshsAnalyticsFirstUrl == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstUrl);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstUrl, nameof(propertiespropertieshsAnalyticsFirstUrl), required: false);
            var __workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp = propertiespropertieshsAnalyticsFirstVisitTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsFirstVisitTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastReferrer = propertiespropertieshsAnalyticsLastReferrer == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastReferrer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastReferrer, nameof(propertiespropertieshsAnalyticsLastReferrer), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTimestamp = propertiespropertieshsAnalyticsLastTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign = propertiespropertieshsAnalyticsLastTouchConvertingCampaign == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastUrl = propertiespropertieshsAnalyticsLastUrl == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastUrl);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastUrl, nameof(propertiespropertieshsAnalyticsLastUrl), required: false);
            var __workflow_propertiespropertieshsAnalyticsLastVisitTimestamp = propertiespropertieshsAnalyticsLastVisitTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsLastVisitTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumEventCompletions = propertiespropertieshsAnalyticsNumEventCompletions == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumEventCompletions);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsNumEventCompletions, nameof(propertiespropertieshsAnalyticsNumEventCompletions), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumPageViews = propertiespropertieshsAnalyticsNumPageViews == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumPageViews);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            var __workflow_propertiespropertieshsAnalyticsNumVisits = propertiespropertieshsAnalyticsNumVisits == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsNumVisits);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            var __workflow_propertiespropertieshsAnalyticsRevenue = propertiespropertieshsAnalyticsRevenue == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsRevenue);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsRevenue, nameof(propertiespropertieshsAnalyticsRevenue), required: false);
            var __workflow_propertiespropertieshsAnalyticsSource = propertiespropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData1 = propertiespropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            var __workflow_propertiespropertieshsAnalyticsSourceData2 = propertiespropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(propertiespropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            var __workflow_propertiespropertieshsBuyingRole = propertiespropertieshsBuyingRole == null ? null : WorkflowExpression.Compile(propertiespropertieshsBuyingRole);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsBuyingRole, nameof(propertiespropertieshsBuyingRole), required: false);
            var __workflow_propertiespropertieshsContentMembershipEmailConfirmed = propertiespropertieshsContentMembershipEmailConfirmed == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipEmailConfirmed);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipEmailConfirmed, nameof(propertiespropertieshsContentMembershipEmailConfirmed), required: false);
            var __workflow_propertiespropertieshsContentMembershipNotes = propertiespropertieshsContentMembershipNotes == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipNotes);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipNotes, nameof(propertiespropertieshsContentMembershipNotes), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegisteredAt = propertiespropertieshsContentMembershipRegisteredAt == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegisteredAt);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipRegisteredAt, nameof(propertiespropertieshsContentMembershipRegisteredAt), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegistrationDomainSentTo = propertiespropertieshsContentMembershipRegistrationDomainSentTo == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegistrationDomainSentTo);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipRegistrationDomainSentTo, nameof(propertiespropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            var __workflow_propertiespropertieshsContentMembershipRegistrationEmailSentAt = propertiespropertieshsContentMembershipRegistrationEmailSentAt == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipRegistrationEmailSentAt);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipRegistrationEmailSentAt, nameof(propertiespropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            var __workflow_propertiespropertieshsContentMembershipStatus = propertiespropertieshsContentMembershipStatus == null ? null : WorkflowExpression.Compile(propertiespropertieshsContentMembershipStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsContentMembershipStatus, nameof(propertiespropertieshsContentMembershipStatus), required: false);
            var __workflow_propertiespropertieshsCreatedate = propertiespropertieshsCreatedate == null ? null : WorkflowExpression.Compile(propertiespropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsEmailBadAddress = propertiespropertieshsEmailBadAddress == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailBadAddress);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailBadAddress, nameof(propertiespropertieshsEmailBadAddress), required: false);
            var __workflow_propertiespropertieshsEmailBounce = propertiespropertieshsEmailBounce == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailBounce);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailBounce, nameof(propertiespropertieshsEmailBounce), required: false);
            var __workflow_propertiespropertieshsEmailClick = propertiespropertieshsEmailClick == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailClick);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailClick, nameof(propertiespropertieshsEmailClick), required: false);
            var __workflow_propertiespropertieshsEmailCustomerQuarantinedReason = propertiespropertieshsEmailCustomerQuarantinedReason == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailCustomerQuarantinedReason);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailCustomerQuarantinedReason, nameof(propertiespropertieshsEmailCustomerQuarantinedReason), required: false);
            var __workflow_propertiespropertieshsEmailDelivered = propertiespropertieshsEmailDelivered == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailDelivered);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailDelivered, nameof(propertiespropertieshsEmailDelivered), required: false);
            var __workflow_propertiespropertieshsEmailDomain = propertiespropertieshsEmailDomain == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailDomain);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailDomain, nameof(propertiespropertieshsEmailDomain), required: false);
            var __workflow_propertiespropertieshsEmailFirstClickDate = propertiespropertieshsEmailFirstClickDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailFirstClickDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailFirstClickDate, nameof(propertiespropertieshsEmailFirstClickDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstOpenDate = propertiespropertieshsEmailFirstOpenDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailFirstOpenDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailFirstOpenDate, nameof(propertiespropertieshsEmailFirstOpenDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstReplyDate = propertiespropertieshsEmailFirstReplyDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailFirstReplyDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailFirstReplyDate, nameof(propertiespropertieshsEmailFirstReplyDate), required: false);
            var __workflow_propertiespropertieshsEmailFirstSendDate = propertiespropertieshsEmailFirstSendDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailFirstSendDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailFirstSendDate, nameof(propertiespropertieshsEmailFirstSendDate), required: false);
            var __workflow_propertiespropertieshsEmailHardBounceReasonEnum = propertiespropertieshsEmailHardBounceReasonEnum == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailHardBounceReasonEnum);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailHardBounceReasonEnum, nameof(propertiespropertieshsEmailHardBounceReasonEnum), required: false);
            var __workflow_propertiespropertieshsEmailLastClickDate = propertiespropertieshsEmailLastClickDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailLastClickDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailLastClickDate, nameof(propertiespropertieshsEmailLastClickDate), required: false);
            var __workflow_propertiespropertieshsEmailLastEmailName = propertiespropertieshsEmailLastEmailName == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailLastEmailName);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailLastEmailName, nameof(propertiespropertieshsEmailLastEmailName), required: false);
            var __workflow_propertiespropertieshsEmailLastOpenDate = propertiespropertieshsEmailLastOpenDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailLastOpenDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailLastOpenDate, nameof(propertiespropertieshsEmailLastOpenDate), required: false);
            var __workflow_propertiespropertieshsEmailLastReplyDate = propertiespropertieshsEmailLastReplyDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailLastReplyDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailLastReplyDate, nameof(propertiespropertieshsEmailLastReplyDate), required: false);
            var __workflow_propertiespropertieshsEmailLastSendDate = propertiespropertieshsEmailLastSendDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailLastSendDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailLastSendDate, nameof(propertiespropertieshsEmailLastSendDate), required: false);
            var __workflow_propertiespropertieshsEmailOpen = propertiespropertieshsEmailOpen == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailOpen);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailOpen, nameof(propertiespropertieshsEmailOpen), required: false);
            var __workflow_propertiespropertieshsEmailOptout = propertiespropertieshsEmailOptout == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailOptout);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailOptout, nameof(propertiespropertieshsEmailOptout), required: false);
            var __workflow_propertiespropertieshsEmailOptout12592317 = propertiespropertieshsEmailOptout12592317 == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailOptout12592317);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailOptout12592317, nameof(propertiespropertieshsEmailOptout12592317), required: false);
            var __workflow_propertiespropertieshsEmailQuarantined = propertiespropertieshsEmailQuarantined == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailQuarantined);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailQuarantined, nameof(propertiespropertieshsEmailQuarantined), required: false);
            var __workflow_propertiespropertieshsEmailQuarantinedReason = propertiespropertieshsEmailQuarantinedReason == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailQuarantinedReason);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailQuarantinedReason, nameof(propertiespropertieshsEmailQuarantinedReason), required: false);
            var __workflow_propertiespropertieshsEmailReplied = propertiespropertieshsEmailReplied == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailReplied);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailReplied, nameof(propertiespropertieshsEmailReplied), required: false);
            var __workflow_propertiespropertieshsEmailSendsSinceLastEngagement = propertiespropertieshsEmailSendsSinceLastEngagement == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailSendsSinceLastEngagement);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailSendsSinceLastEngagement, nameof(propertiespropertieshsEmailSendsSinceLastEngagement), required: false);
            var __workflow_propertiespropertieshsEmailconfirmationstatus = propertiespropertieshsEmailconfirmationstatus == null ? null : WorkflowExpression.Compile(propertiespropertieshsEmailconfirmationstatus);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsEmailconfirmationstatus, nameof(propertiespropertieshsEmailconfirmationstatus), required: false);
            var __workflow_propertiespropertieshsFacebookClickId = propertiespropertieshsFacebookClickId == null ? null : WorkflowExpression.Compile(propertiespropertieshsFacebookClickId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsFacebookClickId, nameof(propertiespropertieshsFacebookClickId), required: false);
            var __workflow_propertiespropertieshsFeedbackLastNpsFollowUp = propertiespropertieshsFeedbackLastNpsFollowUp == null ? null : WorkflowExpression.Compile(propertiespropertieshsFeedbackLastNpsFollowUp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsFeedbackLastNpsFollowUp, nameof(propertiespropertieshsFeedbackLastNpsFollowUp), required: false);
            var __workflow_propertiespropertieshsFeedbackLastNpsRating = propertiespropertieshsFeedbackLastNpsRating == null ? null : WorkflowExpression.Compile(propertiespropertieshsFeedbackLastNpsRating);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsFeedbackLastNpsRating, nameof(propertiespropertieshsFeedbackLastNpsRating), required: false);
            var __workflow_propertiespropertieshsFeedbackLastSurveyDate = propertiespropertieshsFeedbackLastSurveyDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsFeedbackLastSurveyDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsFeedbackLastSurveyDate, nameof(propertiespropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_propertiespropertieshsGoogleClickId = propertiespropertieshsGoogleClickId == null ? null : WorkflowExpression.Compile(propertiespropertieshsGoogleClickId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsGoogleClickId, nameof(propertiespropertieshsGoogleClickId), required: false);
            var __workflow_propertiespropertieshsIpTimezone = propertiespropertieshsIpTimezone == null ? null : WorkflowExpression.Compile(propertiespropertieshsIpTimezone);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsIpTimezone, nameof(propertiespropertieshsIpTimezone), required: false);
            var __workflow_propertiespropertieshsIsUnworked = propertiespropertieshsIsUnworked == null ? null : WorkflowExpression.Compile(propertiespropertieshsIsUnworked);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsIsUnworked, nameof(propertiespropertieshsIsUnworked), required: false);
            var __workflow_propertiespropertieshsLanguage = propertiespropertieshsLanguage == null ? null : WorkflowExpression.Compile(propertiespropertieshsLanguage);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLanguage, nameof(propertiespropertieshsLanguage), required: false);
            var __workflow_propertiespropertieshsLastSalesActivityTimestamp = propertiespropertieshsLastSalesActivityTimestamp == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastSalesActivityTimestamp);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            var __workflow_propertiespropertieshsLeadStatus = propertiespropertieshsLeadStatus == null ? null : WorkflowExpression.Compile(propertiespropertieshsLeadStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            var __workflow_propertiespropertieshsLegalBasis = propertiespropertieshsLegalBasis == null ? null : WorkflowExpression.Compile(propertiespropertieshsLegalBasis);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLegalBasis, nameof(propertiespropertieshsLegalBasis), required: false);
            var __workflow_propertiespropertieshsLifecyclestageCustomerDate = propertiespropertieshsLifecyclestageCustomerDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageCustomerDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageCustomerDate, nameof(propertiespropertieshsLifecyclestageCustomerDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageEvangelistDate = propertiespropertieshsLifecyclestageEvangelistDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageEvangelistDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageEvangelistDate, nameof(propertiespropertieshsLifecyclestageEvangelistDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageLeadDate = propertiespropertieshsLifecyclestageLeadDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageLeadDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageLeadDate, nameof(propertiespropertieshsLifecyclestageLeadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = propertiespropertieshsLifecyclestageMarketingqualifiedleadDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageOpportunityDate = propertiespropertieshsLifecyclestageOpportunityDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageOpportunityDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageOpportunityDate, nameof(propertiespropertieshsLifecyclestageOpportunityDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageOtherDate = propertiespropertieshsLifecyclestageOtherDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageOtherDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageOtherDate, nameof(propertiespropertieshsLifecyclestageOtherDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageSalesqualifiedleadDate = propertiespropertieshsLifecyclestageSalesqualifiedleadDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageSalesqualifiedleadDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageSalesqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            var __workflow_propertiespropertieshsLifecyclestageSubscriberDate = propertiespropertieshsLifecyclestageSubscriberDate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLifecyclestageSubscriberDate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLifecyclestageSubscriberDate, nameof(propertiespropertieshsLifecyclestageSubscriberDate), required: false);
            var __workflow_propertiespropertieshsMarketableReasonId = propertiespropertieshsMarketableReasonId == null ? null : WorkflowExpression.Compile(propertiespropertieshsMarketableReasonId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsMarketableReasonId, nameof(propertiespropertieshsMarketableReasonId), required: false);
            var __workflow_propertiespropertieshsMarketableReasonType = propertiespropertieshsMarketableReasonType == null ? null : WorkflowExpression.Compile(propertiespropertieshsMarketableReasonType);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsMarketableReasonType, nameof(propertiespropertieshsMarketableReasonType), required: false);
            var __workflow_propertiespropertieshsMarketableStatus = propertiespropertieshsMarketableStatus == null ? null : WorkflowExpression.Compile(propertiespropertieshsMarketableStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsMarketableStatus, nameof(propertiespropertieshsMarketableStatus), required: false);
            var __workflow_propertiespropertieshsMarketableUntilRenewal = propertiespropertieshsMarketableUntilRenewal == null ? null : WorkflowExpression.Compile(propertiespropertieshsMarketableUntilRenewal);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsMarketableUntilRenewal, nameof(propertiespropertieshsMarketableUntilRenewal), required: false);
            var __workflow_propertiespropertieshsObjectId = propertiespropertieshsObjectId == null ? null : WorkflowExpression.Compile(propertiespropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsPersona = propertiespropertieshsPersona == null ? null : WorkflowExpression.Compile(propertiespropertieshsPersona);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPersona, nameof(propertiespropertieshsPersona), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscore = propertiespropertieshsPredictivecontactscore == null ? null : WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscore);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPredictivecontactscore, nameof(propertiespropertieshsPredictivecontactscore), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscoreV2 = propertiespropertieshsPredictivecontactscoreV2 == null ? null : WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscoreV2);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            var __workflow_propertiespropertieshsPredictivecontactscorebucket = propertiespropertieshsPredictivecontactscorebucket == null ? null : WorkflowExpression.Compile(propertiespropertieshsPredictivecontactscorebucket);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPredictivecontactscorebucket, nameof(propertiespropertieshsPredictivecontactscorebucket), required: false);
            var __workflow_propertiespropertieshsPredictivescoringtier = propertiespropertieshsPredictivescoringtier == null ? null : WorkflowExpression.Compile(propertiespropertieshsPredictivescoringtier);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsPredictivescoringtier, nameof(propertiespropertieshsPredictivescoringtier), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastClicked = propertiespropertieshsSalesEmailLastClicked == null ? null : WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastClicked);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsSalesEmailLastClicked, nameof(propertiespropertieshsSalesEmailLastClicked), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastOpened = propertiespropertieshsSalesEmailLastOpened == null ? null : WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastOpened);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsSalesEmailLastOpened, nameof(propertiespropertieshsSalesEmailLastOpened), required: false);
            var __workflow_propertiespropertieshsSalesEmailLastReplied = propertiespropertieshsSalesEmailLastReplied == null ? null : WorkflowExpression.Compile(propertiespropertieshsSalesEmailLastReplied);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsSalesEmailLastReplied, nameof(propertiespropertieshsSalesEmailLastReplied), required: false);
            var __workflow_propertiespropertieshsSequencesIsEnrolled = propertiespropertieshsSequencesIsEnrolled == null ? null : WorkflowExpression.Compile(propertiespropertieshsSequencesIsEnrolled);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsSequencesIsEnrolled, nameof(propertiespropertieshsSequencesIsEnrolled), required: false);
            var __workflow_propertiespropertieshsTimeBetweenContactCreationAndDealClose = propertiespropertieshsTimeBetweenContactCreationAndDealClose == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeBetweenContactCreationAndDealClose);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealClose, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            var __workflow_propertiespropertieshsTimeBetweenContactCreationAndDealCreation = propertiespropertieshsTimeBetweenContactCreationAndDealCreation == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeBetweenContactCreationAndDealCreation);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeBetweenContactCreationAndDealCreation, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromLeadToCustomer = propertiespropertieshsTimeToMoveFromLeadToCustomer == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromLeadToCustomer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeToMoveFromLeadToCustomer, nameof(propertiespropertieshsTimeToMoveFromLeadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromOpportunityToCustomer = propertiespropertieshsTimeToMoveFromOpportunityToCustomer == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromOpportunityToCustomer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeToMoveFromOpportunityToCustomer, nameof(propertiespropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            var __workflow_propertiespropertieshsTimeToMoveFromSubscriberToCustomer = propertiespropertieshsTimeToMoveFromSubscriberToCustomer == null ? null : WorkflowExpression.Compile(propertiespropertieshsTimeToMoveFromSubscriberToCustomer);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsTimeToMoveFromSubscriberToCustomer, nameof(propertiespropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            var __workflow_propertiespropertieshubspotOwnerAssigneddate = propertiespropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_propertiespropertieshubspotOwnerId = propertiespropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            var __workflow_propertiespropertieshubspotTeamId = propertiespropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            var __workflow_propertiespropertieshubspotscore = propertiespropertieshubspotscore == null ? null : WorkflowExpression.Compile(propertiespropertieshubspotscore);
            WorkflowExpression.Validate(__workflow_propertiespropertieshubspotscore, nameof(propertiespropertieshubspotscore), required: false);
            var __workflow_propertiespropertiesindustry = propertiespropertiesindustry == null ? null : WorkflowExpression.Compile(propertiespropertiesindustry);
            WorkflowExpression.Validate(__workflow_propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            var __workflow_propertiespropertiesipCity = propertiespropertiesipCity == null ? null : WorkflowExpression.Compile(propertiespropertiesipCity);
            WorkflowExpression.Validate(__workflow_propertiespropertiesipCity, nameof(propertiespropertiesipCity), required: false);
            var __workflow_propertiespropertiesipCountry = propertiespropertiesipCountry == null ? null : WorkflowExpression.Compile(propertiespropertiesipCountry);
            WorkflowExpression.Validate(__workflow_propertiespropertiesipCountry, nameof(propertiespropertiesipCountry), required: false);
            var __workflow_propertiespropertiesipCountryCode = propertiespropertiesipCountryCode == null ? null : WorkflowExpression.Compile(propertiespropertiesipCountryCode);
            WorkflowExpression.Validate(__workflow_propertiespropertiesipCountryCode, nameof(propertiespropertiesipCountryCode), required: false);
            var __workflow_propertiespropertiesipState = propertiespropertiesipState == null ? null : WorkflowExpression.Compile(propertiespropertiesipState);
            WorkflowExpression.Validate(__workflow_propertiespropertiesipState, nameof(propertiespropertiesipState), required: false);
            var __workflow_propertiespropertiesipStateCode = propertiespropertiesipStateCode == null ? null : WorkflowExpression.Compile(propertiespropertiesipStateCode);
            WorkflowExpression.Validate(__workflow_propertiespropertiesipStateCode, nameof(propertiespropertiesipStateCode), required: false);
            var __workflow_propertiespropertiesjobFunction = propertiespropertiesjobFunction == null ? null : WorkflowExpression.Compile(propertiespropertiesjobFunction);
            WorkflowExpression.Validate(__workflow_propertiespropertiesjobFunction, nameof(propertiespropertiesjobFunction), required: false);
            var __workflow_propertiespropertiesjobtitle = propertiespropertiesjobtitle == null ? null : WorkflowExpression.Compile(propertiespropertiesjobtitle);
            WorkflowExpression.Validate(__workflow_propertiespropertiesjobtitle, nameof(propertiespropertiesjobtitle), required: false);
            var __workflow_propertiespropertieslastmodifieddate = propertiespropertieslastmodifieddate == null ? null : WorkflowExpression.Compile(propertiespropertieslastmodifieddate);
            WorkflowExpression.Validate(__workflow_propertiespropertieslastmodifieddate, nameof(propertiespropertieslastmodifieddate), required: false);
            var __workflow_propertiespropertieslastname = propertiespropertieslastname == null ? null : WorkflowExpression.Compile(propertiespropertieslastname);
            WorkflowExpression.Validate(__workflow_propertiespropertieslastname, nameof(propertiespropertieslastname), required: false);
            var __workflow_propertiespropertieslifecyclestage = propertiespropertieslifecyclestage == null ? null : WorkflowExpression.Compile(propertiespropertieslifecyclestage);
            WorkflowExpression.Validate(__workflow_propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            var __workflow_propertiespropertiesmaritalStatus = propertiespropertiesmaritalStatus == null ? null : WorkflowExpression.Compile(propertiespropertiesmaritalStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertiesmaritalStatus, nameof(propertiespropertiesmaritalStatus), required: false);
            var __workflow_propertiespropertiesmessage = propertiespropertiesmessage == null ? null : WorkflowExpression.Compile(propertiespropertiesmessage);
            WorkflowExpression.Validate(__workflow_propertiespropertiesmessage, nameof(propertiespropertiesmessage), required: false);
            var __workflow_propertiespropertiesmilitaryStatus = propertiespropertiesmilitaryStatus == null ? null : WorkflowExpression.Compile(propertiespropertiesmilitaryStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertiesmilitaryStatus, nameof(propertiespropertiesmilitaryStatus), required: false);
            var __workflow_propertiespropertiesmobilephone = propertiespropertiesmobilephone == null ? null : WorkflowExpression.Compile(propertiespropertiesmobilephone);
            WorkflowExpression.Validate(__workflow_propertiespropertiesmobilephone, nameof(propertiespropertiesmobilephone), required: false);
            var __workflow_propertiespropertiesnotesLastContacted = propertiespropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            var __workflow_propertiespropertiesnotesLastUpdated = propertiespropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            var __workflow_propertiespropertiesnotesNextActivityDate = propertiespropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(propertiespropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            var __workflow_propertiespropertiesnumAssociatedDeals = propertiespropertiesnumAssociatedDeals == null ? null : WorkflowExpression.Compile(propertiespropertiesnumAssociatedDeals);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            var __workflow_propertiespropertiesnumContactedNotes = propertiespropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(propertiespropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            var __workflow_propertiespropertiesnumConversionEvents = propertiespropertiesnumConversionEvents == null ? null : WorkflowExpression.Compile(propertiespropertiesnumConversionEvents);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            var __workflow_propertiespropertiesnumNotes = propertiespropertiesnumNotes == null ? null : WorkflowExpression.Compile(propertiespropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumNotes, nameof(propertiespropertiesnumNotes), required: false);
            var __workflow_propertiespropertiesnumUniqueConversionEvents = propertiespropertiesnumUniqueConversionEvents == null ? null : WorkflowExpression.Compile(propertiespropertiesnumUniqueConversionEvents);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumUniqueConversionEvents, nameof(propertiespropertiesnumUniqueConversionEvents), required: false);
            var __workflow_propertiespropertiesnumemployees = propertiespropertiesnumemployees == null ? null : WorkflowExpression.Compile(propertiespropertiesnumemployees);
            WorkflowExpression.Validate(__workflow_propertiespropertiesnumemployees, nameof(propertiespropertiesnumemployees), required: false);
            var __workflow_propertiespropertiesphone = propertiespropertiesphone == null ? null : WorkflowExpression.Compile(propertiespropertiesphone);
            WorkflowExpression.Validate(__workflow_propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            var __workflow_propertiespropertiesrecentConversionDate = propertiespropertiesrecentConversionDate == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentConversionDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            var __workflow_propertiespropertiesrecentConversionEventName = propertiespropertiesrecentConversionEventName == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentConversionEventName);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            var __workflow_propertiespropertiesrecentDealAmount = propertiespropertiesrecentDealAmount == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentDealAmount);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            var __workflow_propertiespropertiesrecentDealCloseDate = propertiespropertiesrecentDealCloseDate == null ? null : WorkflowExpression.Compile(propertiespropertiesrecentDealCloseDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            var __workflow_propertiespropertiesrelationshipStatus = propertiespropertiesrelationshipStatus == null ? null : WorkflowExpression.Compile(propertiespropertiesrelationshipStatus);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrelationshipStatus, nameof(propertiespropertiesrelationshipStatus), required: false);
            var __workflow_propertiespropertiessalutation = propertiespropertiessalutation == null ? null : WorkflowExpression.Compile(propertiespropertiessalutation);
            WorkflowExpression.Validate(__workflow_propertiespropertiessalutation, nameof(propertiespropertiessalutation), required: false);
            var __workflow_propertiespropertiesschool = propertiespropertiesschool == null ? null : WorkflowExpression.Compile(propertiespropertiesschool);
            WorkflowExpression.Validate(__workflow_propertiespropertiesschool, nameof(propertiespropertiesschool), required: false);
            var __workflow_propertiespropertiesseniority = propertiespropertiesseniority == null ? null : WorkflowExpression.Compile(propertiespropertiesseniority);
            WorkflowExpression.Validate(__workflow_propertiespropertiesseniority, nameof(propertiespropertiesseniority), required: false);
            var __workflow_propertiespropertiesstartDate = propertiespropertiesstartDate == null ? null : WorkflowExpression.Compile(propertiespropertiesstartDate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesstartDate, nameof(propertiespropertiesstartDate), required: false);
            var __workflow_propertiespropertiesstate = propertiespropertiesstate == null ? null : WorkflowExpression.Compile(propertiespropertiesstate);
            WorkflowExpression.Validate(__workflow_propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            var __workflow_propertiespropertiestotalRevenue = propertiespropertiestotalRevenue == null ? null : WorkflowExpression.Compile(propertiespropertiestotalRevenue);
            WorkflowExpression.Validate(__workflow_propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            var __workflow_propertiespropertiestwitterhandle = propertiespropertiestwitterhandle == null ? null : WorkflowExpression.Compile(propertiespropertiestwitterhandle);
            WorkflowExpression.Validate(__workflow_propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            var __workflow_propertiespropertieswebsite = propertiespropertieswebsite == null ? null : WorkflowExpression.Compile(propertiespropertieswebsite);
            WorkflowExpression.Validate(__workflow_propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            var __workflow_propertiespropertiesworkEmail = propertiespropertiesworkEmail == null ? null : WorkflowExpression.Compile(propertiespropertiesworkEmail);
            WorkflowExpression.Validate(__workflow_propertiespropertiesworkEmail, nameof(propertiespropertiesworkEmail), required: false);
            var __workflow_propertiespropertieszip = propertiespropertieszip == null ? null : WorkflowExpression.Compile(propertiespropertieszip);
            WorkflowExpression.Validate(__workflow_propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
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
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_after = after == null ? null : WorkflowExpression.Compile(after);
            WorkflowExpression.Validate(__workflow_after, nameof(after), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
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
            var __workflow_bodypropertiesamount = bodypropertiesamount == null ? null : WorkflowExpression.Compile(bodypropertiesamount);
            WorkflowExpression.Validate(__workflow_bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            var __workflow_bodypropertiesamountInHomeCurrency = bodypropertiesamountInHomeCurrency == null ? null : WorkflowExpression.Compile(bodypropertiesamountInHomeCurrency);
            WorkflowExpression.Validate(__workflow_bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            var __workflow_bodypropertiesclosedLostReason = bodypropertiesclosedLostReason == null ? null : WorkflowExpression.Compile(bodypropertiesclosedLostReason);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            var __workflow_bodypropertiesclosedWonReason = bodypropertiesclosedWonReason == null ? null : WorkflowExpression.Compile(bodypropertiesclosedWonReason);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            var __workflow_bodypropertiesclosedate = bodypropertiesclosedate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdealname = bodypropertiesdealname == null ? null : WorkflowExpression.Compile(bodypropertiesdealname);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            var __workflow_bodypropertiesdealstage = bodypropertiesdealstage == null ? null : WorkflowExpression.Compile(bodypropertiesdealstage);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            var __workflow_bodypropertiesdealtype = bodypropertiesdealtype == null ? null : WorkflowExpression.Compile(bodypropertiesdealtype);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            var __workflow_bodypropertiesdescription = bodypropertiesdescription == null ? null : WorkflowExpression.Compile(bodypropertiesdescription);
            WorkflowExpression.Validate(__workflow_bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = bodypropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = bodypropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = bodypropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = bodypropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertieshsAcv = bodypropertieshsAcv == null ? null : WorkflowExpression.Compile(bodypropertieshsAcv);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = bodypropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = bodypropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = bodypropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsArr = bodypropertieshsArr == null ? null : WorkflowExpression.Compile(bodypropertieshsArr);
            WorkflowExpression.Validate(__workflow_bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            var __workflow_bodypropertieshsForecastAmount = bodypropertieshsForecastAmount == null ? null : WorkflowExpression.Compile(bodypropertieshsForecastAmount);
            WorkflowExpression.Validate(__workflow_bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            var __workflow_bodypropertieshsForecastProbability = bodypropertieshsForecastProbability == null ? null : WorkflowExpression.Compile(bodypropertieshsForecastProbability);
            WorkflowExpression.Validate(__workflow_bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsManualForecastCategory = bodypropertieshsManualForecastCategory == null ? null : WorkflowExpression.Compile(bodypropertieshsManualForecastCategory);
            WorkflowExpression.Validate(__workflow_bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            var __workflow_bodypropertieshsMrr = bodypropertieshsMrr == null ? null : WorkflowExpression.Compile(bodypropertieshsMrr);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            var __workflow_bodypropertieshsNextStep = bodypropertieshsNextStep == null ? null : WorkflowExpression.Compile(bodypropertieshsNextStep);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            var __workflow_bodypropertieshsObjectId = bodypropertieshsObjectId == null ? null : WorkflowExpression.Compile(bodypropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPriority = bodypropertieshsPriority == null ? null : WorkflowExpression.Compile(bodypropertieshsPriority);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            var __workflow_bodypropertieshsTcv = bodypropertieshsTcv == null ? null : WorkflowExpression.Compile(bodypropertieshsTcv);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesnotesLastContacted = bodypropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = bodypropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = bodypropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = bodypropertiesnumAssociatedContacts == null ? null : WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumContactedNotes = bodypropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumNotes = bodypropertiesnumNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiespipeline = bodypropertiespipeline == null ? null : WorkflowExpression.Compile(bodypropertiespipeline);
            WorkflowExpression.Validate(__workflow_bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
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
            var __workflow_dealId = dealId == null ? null : WorkflowExpression.Compile(dealId);
            WorkflowExpression.Validate(__workflow_dealId, nameof(dealId), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dealId, 1));
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
            var __workflow_dealId = dealId == null ? null : WorkflowExpression.Compile(dealId);
            WorkflowExpression.Validate(__workflow_dealId, nameof(dealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsUpdate(Expression<Func<string>> dealId, Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
        {
            var __workflow_dealId = dealId == null ? null : WorkflowExpression.Compile(dealId);
            WorkflowExpression.Validate(__workflow_dealId, nameof(dealId), required: true);
            var __workflow_bodypropertiesamount = bodypropertiesamount == null ? null : WorkflowExpression.Compile(bodypropertiesamount);
            WorkflowExpression.Validate(__workflow_bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            var __workflow_bodypropertiesamountInHomeCurrency = bodypropertiesamountInHomeCurrency == null ? null : WorkflowExpression.Compile(bodypropertiesamountInHomeCurrency);
            WorkflowExpression.Validate(__workflow_bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            var __workflow_bodypropertiesclosedLostReason = bodypropertiesclosedLostReason == null ? null : WorkflowExpression.Compile(bodypropertiesclosedLostReason);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            var __workflow_bodypropertiesclosedWonReason = bodypropertiesclosedWonReason == null ? null : WorkflowExpression.Compile(bodypropertiesclosedWonReason);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            var __workflow_bodypropertiesclosedate = bodypropertiesclosedate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdealname = bodypropertiesdealname == null ? null : WorkflowExpression.Compile(bodypropertiesdealname);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            var __workflow_bodypropertiesdealstage = bodypropertiesdealstage == null ? null : WorkflowExpression.Compile(bodypropertiesdealstage);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            var __workflow_bodypropertiesdealtype = bodypropertiesdealtype == null ? null : WorkflowExpression.Compile(bodypropertiesdealtype);
            WorkflowExpression.Validate(__workflow_bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            var __workflow_bodypropertiesdescription = bodypropertiesdescription == null ? null : WorkflowExpression.Compile(bodypropertiesdescription);
            WorkflowExpression.Validate(__workflow_bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBooked = bodypropertiesengagementsLastMeetingBooked == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBooked);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedCampaign = bodypropertiesengagementsLastMeetingBookedCampaign == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedCampaign);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedMedium = bodypropertiesengagementsLastMeetingBookedMedium == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedMedium);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            var __workflow_bodypropertiesengagementsLastMeetingBookedSource = bodypropertiesengagementsLastMeetingBookedSource == null ? null : WorkflowExpression.Compile(bodypropertiesengagementsLastMeetingBookedSource);
            WorkflowExpression.Validate(__workflow_bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            var __workflow_bodypropertieshsAcv = bodypropertieshsAcv == null ? null : WorkflowExpression.Compile(bodypropertieshsAcv);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            var __workflow_bodypropertieshsAnalyticsSource = bodypropertieshsAnalyticsSource == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSource);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData1 = bodypropertieshsAnalyticsSourceData1 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData1);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            var __workflow_bodypropertieshsAnalyticsSourceData2 = bodypropertieshsAnalyticsSourceData2 == null ? null : WorkflowExpression.Compile(bodypropertieshsAnalyticsSourceData2);
            WorkflowExpression.Validate(__workflow_bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            var __workflow_bodypropertieshsArr = bodypropertieshsArr == null ? null : WorkflowExpression.Compile(bodypropertieshsArr);
            WorkflowExpression.Validate(__workflow_bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            var __workflow_bodypropertieshsForecastAmount = bodypropertieshsForecastAmount == null ? null : WorkflowExpression.Compile(bodypropertieshsForecastAmount);
            WorkflowExpression.Validate(__workflow_bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            var __workflow_bodypropertieshsForecastProbability = bodypropertieshsForecastProbability == null ? null : WorkflowExpression.Compile(bodypropertieshsForecastProbability);
            WorkflowExpression.Validate(__workflow_bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsManualForecastCategory = bodypropertieshsManualForecastCategory == null ? null : WorkflowExpression.Compile(bodypropertieshsManualForecastCategory);
            WorkflowExpression.Validate(__workflow_bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            var __workflow_bodypropertieshsMrr = bodypropertieshsMrr == null ? null : WorkflowExpression.Compile(bodypropertieshsMrr);
            WorkflowExpression.Validate(__workflow_bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            var __workflow_bodypropertieshsNextStep = bodypropertieshsNextStep == null ? null : WorkflowExpression.Compile(bodypropertieshsNextStep);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            var __workflow_bodypropertieshsObjectId = bodypropertieshsObjectId == null ? null : WorkflowExpression.Compile(bodypropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsPriority = bodypropertieshsPriority == null ? null : WorkflowExpression.Compile(bodypropertieshsPriority);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            var __workflow_bodypropertieshsTcv = bodypropertieshsTcv == null ? null : WorkflowExpression.Compile(bodypropertieshsTcv);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiesnotesLastContacted = bodypropertiesnotesLastContacted == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastContacted);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            var __workflow_bodypropertiesnotesLastUpdated = bodypropertiesnotesLastUpdated == null ? null : WorkflowExpression.Compile(bodypropertiesnotesLastUpdated);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            var __workflow_bodypropertiesnotesNextActivityDate = bodypropertiesnotesNextActivityDate == null ? null : WorkflowExpression.Compile(bodypropertiesnotesNextActivityDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            var __workflow_bodypropertiesnumAssociatedContacts = bodypropertiesnumAssociatedContacts == null ? null : WorkflowExpression.Compile(bodypropertiesnumAssociatedContacts);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            var __workflow_bodypropertiesnumContactedNotes = bodypropertiesnumContactedNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumContactedNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            var __workflow_bodypropertiesnumNotes = bodypropertiesnumNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiespipeline = bodypropertiespipeline == null ? null : WorkflowExpression.Compile(bodypropertiespipeline);
            WorkflowExpression.Validate(__workflow_bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dealId, 1));
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
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
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
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesdescription = bodypropertiesdescription == null ? null : WorkflowExpression.Compile(bodypropertiesdescription);
            WorkflowExpression.Validate(__workflow_bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            var __workflow_bodypropertieshsCostOfGoodsSold = bodypropertieshsCostOfGoodsSold == null ? null : WorkflowExpression.Compile(bodypropertieshsCostOfGoodsSold);
            WorkflowExpression.Validate(__workflow_bodypropertieshsCostOfGoodsSold, nameof(bodypropertieshsCostOfGoodsSold), required: false);
            var __workflow_bodypropertieshsCreatedByUserId = bodypropertieshsCreatedByUserId == null ? null : WorkflowExpression.Compile(bodypropertieshsCreatedByUserId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsCreatedByUserId, nameof(bodypropertieshsCreatedByUserId), required: false);
            var __workflow_bodypropertieshsCreatedate = bodypropertieshsCreatedate == null ? null : WorkflowExpression.Compile(bodypropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            var __workflow_bodypropertieshsImages = bodypropertieshsImages == null ? null : WorkflowExpression.Compile(bodypropertieshsImages);
            WorkflowExpression.Validate(__workflow_bodypropertieshsImages, nameof(bodypropertieshsImages), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsObjectId = bodypropertieshsObjectId == null ? null : WorkflowExpression.Compile(bodypropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            var __workflow_bodypropertieshsRecurringBillingPeriod = bodypropertieshsRecurringBillingPeriod == null ? null : WorkflowExpression.Compile(bodypropertieshsRecurringBillingPeriod);
            WorkflowExpression.Validate(__workflow_bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            var __workflow_bodypropertieshsSku = bodypropertieshsSku == null ? null : WorkflowExpression.Compile(bodypropertieshsSku);
            WorkflowExpression.Validate(__workflow_bodypropertieshsSku, nameof(bodypropertieshsSku), required: false);
            var __workflow_bodypropertieshsUpdatedByUserId = bodypropertieshsUpdatedByUserId == null ? null : WorkflowExpression.Compile(bodypropertieshsUpdatedByUserId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsUpdatedByUserId, nameof(bodypropertieshsUpdatedByUserId), required: false);
            var __workflow_bodypropertieshsUrl = bodypropertieshsUrl == null ? null : WorkflowExpression.Compile(bodypropertieshsUrl);
            WorkflowExpression.Validate(__workflow_bodypropertieshsUrl, nameof(bodypropertieshsUrl), required: false);
            var __workflow_bodypropertiesname = bodypropertiesname == null ? null : WorkflowExpression.Compile(bodypropertiesname);
            WorkflowExpression.Validate(__workflow_bodypropertiesname, nameof(bodypropertiesname), required: false);
            var __workflow_bodypropertiesprice = bodypropertiesprice == null ? null : WorkflowExpression.Compile(bodypropertiesprice);
            WorkflowExpression.Validate(__workflow_bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            var __workflow_bodypropertiesrecurringbillingfrequency = bodypropertiesrecurringbillingfrequency == null ? null : WorkflowExpression.Compile(bodypropertiesrecurringbillingfrequency);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            var __workflow_bodypropertiestax = bodypropertiestax == null ? null : WorkflowExpression.Compile(bodypropertiestax);
            WorkflowExpression.Validate(__workflow_bodypropertiestax, nameof(bodypropertiestax), required: false);
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
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1));
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
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsUpdate(Expression<Func<string>> productId, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertieshsCostOfGoodsSold = null, Expression<Func<string>> propertiespropertieshsCreatedByUserId = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsImages = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertieshsSku = null, Expression<Func<string>> propertiespropertieshsUpdatedByUserId = null, Expression<Func<string>> propertiespropertieshsUrl = null, Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertiesprice = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiestax = null)
        {
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            var __workflow_propertiespropertiescreatedate = propertiespropertiescreatedate == null ? null : WorkflowExpression.Compile(propertiespropertiescreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            var __workflow_propertiespropertiesdescription = propertiespropertiesdescription == null ? null : WorkflowExpression.Compile(propertiespropertiesdescription);
            WorkflowExpression.Validate(__workflow_propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            var __workflow_propertiespropertieshsCostOfGoodsSold = propertiespropertieshsCostOfGoodsSold == null ? null : WorkflowExpression.Compile(propertiespropertieshsCostOfGoodsSold);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsCostOfGoodsSold, nameof(propertiespropertieshsCostOfGoodsSold), required: false);
            var __workflow_propertiespropertieshsCreatedByUserId = propertiespropertieshsCreatedByUserId == null ? null : WorkflowExpression.Compile(propertiespropertieshsCreatedByUserId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsCreatedByUserId, nameof(propertiespropertieshsCreatedByUserId), required: false);
            var __workflow_propertiespropertieshsCreatedate = propertiespropertieshsCreatedate == null ? null : WorkflowExpression.Compile(propertiespropertieshsCreatedate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            var __workflow_propertiespropertieshsImages = propertiespropertieshsImages == null ? null : WorkflowExpression.Compile(propertiespropertieshsImages);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsImages, nameof(propertiespropertieshsImages), required: false);
            var __workflow_propertiespropertieshsLastmodifieddate = propertiespropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(propertiespropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            var __workflow_propertiespropertieshsObjectId = propertiespropertieshsObjectId == null ? null : WorkflowExpression.Compile(propertiespropertieshsObjectId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            var __workflow_propertiespropertieshsRecurringBillingPeriod = propertiespropertieshsRecurringBillingPeriod == null ? null : WorkflowExpression.Compile(propertiespropertieshsRecurringBillingPeriod);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            var __workflow_propertiespropertieshsSku = propertiespropertieshsSku == null ? null : WorkflowExpression.Compile(propertiespropertieshsSku);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsSku, nameof(propertiespropertieshsSku), required: false);
            var __workflow_propertiespropertieshsUpdatedByUserId = propertiespropertieshsUpdatedByUserId == null ? null : WorkflowExpression.Compile(propertiespropertieshsUpdatedByUserId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsUpdatedByUserId, nameof(propertiespropertieshsUpdatedByUserId), required: false);
            var __workflow_propertiespropertieshsUrl = propertiespropertieshsUrl == null ? null : WorkflowExpression.Compile(propertiespropertieshsUrl);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsUrl, nameof(propertiespropertieshsUrl), required: false);
            var __workflow_propertiespropertiesname = propertiespropertiesname == null ? null : WorkflowExpression.Compile(propertiespropertiesname);
            WorkflowExpression.Validate(__workflow_propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            var __workflow_propertiespropertiesprice = propertiespropertiesprice == null ? null : WorkflowExpression.Compile(propertiespropertiesprice);
            WorkflowExpression.Validate(__workflow_propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            var __workflow_propertiespropertiesrecurringbillingfrequency = propertiespropertiesrecurringbillingfrequency == null ? null : WorkflowExpression.Compile(propertiespropertiesrecurringbillingfrequency);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            var __workflow_propertiespropertiestax = propertiespropertiestax == null ? null : WorkflowExpression.Compile(propertiespropertiestax);
            WorkflowExpression.Validate(__workflow_propertiespropertiestax, nameof(propertiespropertiestax), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1));
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
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_associations = associations == null ? null : WorkflowExpression.Compile(associations);
            WorkflowExpression.Validate(__workflow_associations, nameof(associations), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
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
            var __workflow_propertiespropertiesname = propertiespropertiesname == null ? null : WorkflowExpression.Compile(propertiespropertiesname);
            WorkflowExpression.Validate(__workflow_propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            var __workflow_propertiespropertieshsProductId = propertiespropertieshsProductId == null ? null : WorkflowExpression.Compile(propertiespropertieshsProductId);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsProductId, nameof(propertiespropertieshsProductId), required: false);
            var __workflow_propertiespropertieshsRecurringBillingPeriod = propertiespropertieshsRecurringBillingPeriod == null ? null : WorkflowExpression.Compile(propertiespropertieshsRecurringBillingPeriod);
            WorkflowExpression.Validate(__workflow_propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            var __workflow_propertiespropertiesrecurringbillingfrequency = propertiespropertiesrecurringbillingfrequency == null ? null : WorkflowExpression.Compile(propertiespropertiesrecurringbillingfrequency);
            WorkflowExpression.Validate(__workflow_propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            var __workflow_propertiespropertiesquantity = propertiespropertiesquantity == null ? null : WorkflowExpression.Compile(propertiespropertiesquantity);
            WorkflowExpression.Validate(__workflow_propertiespropertiesquantity, nameof(propertiespropertiesquantity), required: false);
            var __workflow_propertiespropertiesprice = propertiespropertiesprice == null ? null : WorkflowExpression.Compile(propertiespropertiesprice);
            WorkflowExpression.Validate(__workflow_propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
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
            var __workflow_lineItemId = lineItemId == null ? null : WorkflowExpression.Compile(lineItemId);
            WorkflowExpression.Validate(__workflow_lineItemId, nameof(lineItemId), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_associations = associations == null ? null : WorkflowExpression.Compile(associations);
            WorkflowExpression.Validate(__workflow_associations, nameof(associations), required: false);
            var __workflow_idProperty = idProperty == null ? null : WorkflowExpression.Compile(idProperty);
            WorkflowExpression.Validate(__workflow_idProperty, nameof(idProperty), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_lineItemId, 1));
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
            var __workflow_lineItemId = lineItemId == null ? null : WorkflowExpression.Compile(lineItemId);
            WorkflowExpression.Validate(__workflow_lineItemId, nameof(lineItemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_lineItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsUpdate(Expression<Func<string>> lineItemId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertieshsProductId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiesquantity = null, Expression<Func<string>> bodypropertiesprice = null)
        {
            var __workflow_lineItemId = lineItemId == null ? null : WorkflowExpression.Compile(lineItemId);
            WorkflowExpression.Validate(__workflow_lineItemId, nameof(lineItemId), required: true);
            var __workflow_idProperty = idProperty == null ? null : WorkflowExpression.Compile(idProperty);
            WorkflowExpression.Validate(__workflow_idProperty, nameof(idProperty), required: false);
            var __workflow_bodypropertiesname = bodypropertiesname == null ? null : WorkflowExpression.Compile(bodypropertiesname);
            WorkflowExpression.Validate(__workflow_bodypropertiesname, nameof(bodypropertiesname), required: false);
            var __workflow_bodypropertieshsProductId = bodypropertieshsProductId == null ? null : WorkflowExpression.Compile(bodypropertieshsProductId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsProductId, nameof(bodypropertieshsProductId), required: false);
            var __workflow_bodypropertieshsRecurringBillingPeriod = bodypropertieshsRecurringBillingPeriod == null ? null : WorkflowExpression.Compile(bodypropertieshsRecurringBillingPeriod);
            WorkflowExpression.Validate(__workflow_bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            var __workflow_bodypropertiesrecurringbillingfrequency = bodypropertiesrecurringbillingfrequency == null ? null : WorkflowExpression.Compile(bodypropertiesrecurringbillingfrequency);
            WorkflowExpression.Validate(__workflow_bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            var __workflow_bodypropertiesquantity = bodypropertiesquantity == null ? null : WorkflowExpression.Compile(bodypropertiesquantity);
            WorkflowExpression.Validate(__workflow_bodypropertiesquantity, nameof(bodypropertiesquantity), required: false);
            var __workflow_bodypropertiesprice = bodypropertiesprice == null ? null : WorkflowExpression.Compile(bodypropertiesprice);
            WorkflowExpression.Validate(__workflow_bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_lineItemId, 1));
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
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_associations = associations == null ? null : WorkflowExpression.Compile(associations);
            WorkflowExpression.Validate(__workflow_associations, nameof(associations), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
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
            var __workflow_bodypropertiesclosedDate = bodypropertiesclosedDate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesfirstAgentReplyDate = bodypropertiesfirstAgentReplyDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstAgentReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesFollowUp = bodypropertieshsFeedbackLastCesFollowUp == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesFollowUp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesRating = bodypropertieshsFeedbackLastCesRating == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesRating);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = bodypropertieshsFeedbackLastSurveyDate == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsLastactivitydate = bodypropertieshsLastactivitydate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastactivitydate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            var __workflow_bodypropertieshsLastcontacted = bodypropertieshsLastcontacted == null ? null : WorkflowExpression.Compile(bodypropertieshsLastcontacted);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsNextactivitydate = bodypropertieshsNextactivitydate == null ? null : WorkflowExpression.Compile(bodypropertieshsNextactivitydate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            var __workflow_bodypropertieshsNumTimesContacted = bodypropertieshsNumTimesContacted == null ? null : WorkflowExpression.Compile(bodypropertieshsNumTimesContacted);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieslastReplyDate = bodypropertieslastReplyDate == null ? null : WorkflowExpression.Compile(bodypropertieslastReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            var __workflow_bodypropertiesnumNotes = bodypropertiesnumNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiestimeToClose = bodypropertiestimeToClose == null ? null : WorkflowExpression.Compile(bodypropertiestimeToClose);
            WorkflowExpression.Validate(__workflow_bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            var __workflow_bodypropertiestimeToFirstAgentReply = bodypropertiestimeToFirstAgentReply == null ? null : WorkflowExpression.Compile(bodypropertiestimeToFirstAgentReply);
            WorkflowExpression.Validate(__workflow_bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            var __workflow_bodypropertiescontent = bodypropertiescontent == null ? null : WorkflowExpression.Compile(bodypropertiescontent);
            WorkflowExpression.Validate(__workflow_bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            var __workflow_bodypropertieshsFileUpload = bodypropertieshsFileUpload == null ? null : WorkflowExpression.Compile(bodypropertieshsFileUpload);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            var __workflow_bodypropertieshsNumAssociatedCompanies = bodypropertieshsNumAssociatedCompanies == null ? null : WorkflowExpression.Compile(bodypropertieshsNumAssociatedCompanies);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            var __workflow_bodypropertieshsPipeline = bodypropertieshsPipeline == null ? null : WorkflowExpression.Compile(bodypropertieshsPipeline);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            var __workflow_bodypropertieshsPipelineStage = bodypropertieshsPipelineStage == null ? null : WorkflowExpression.Compile(bodypropertieshsPipelineStage);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            var __workflow_bodypropertieshsResolution = bodypropertieshsResolution == null ? null : WorkflowExpression.Compile(bodypropertieshsResolution);
            WorkflowExpression.Validate(__workflow_bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            var __workflow_bodypropertieshsTicketCategory = bodypropertieshsTicketCategory == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketCategory);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            var __workflow_bodypropertieshsTicketId = bodypropertieshsTicketId == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            var __workflow_bodypropertieshsTicketPriority = bodypropertieshsTicketPriority == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketPriority);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiessourceType = bodypropertiessourceType == null ? null : WorkflowExpression.Compile(bodypropertiessourceType);
            WorkflowExpression.Validate(__workflow_bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            var __workflow_bodypropertiessubject = bodypropertiessubject == null ? null : WorkflowExpression.Compile(bodypropertiessubject);
            WorkflowExpression.Validate(__workflow_bodypropertiessubject, nameof(bodypropertiessubject), required: false);
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
            var __workflow_ticketId = ticketId == null ? null : WorkflowExpression.Compile(ticketId);
            WorkflowExpression.Validate(__workflow_ticketId, nameof(ticketId), required: true);
            var __workflow_properties = properties == null ? null : WorkflowExpression.Compile(properties);
            WorkflowExpression.Validate(__workflow_properties, nameof(properties), required: false);
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            var __workflow_idProperty = idProperty == null ? null : WorkflowExpression.Compile(idProperty);
            WorkflowExpression.Validate(__workflow_idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticketId, 1));
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
            var __workflow_ticketId = ticketId == null ? null : WorkflowExpression.Compile(ticketId);
            WorkflowExpression.Validate(__workflow_ticketId, nameof(ticketId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticketId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsUpdate(Expression<Func<string>> ticketId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
        {
            var __workflow_ticketId = ticketId == null ? null : WorkflowExpression.Compile(ticketId);
            WorkflowExpression.Validate(__workflow_ticketId, nameof(ticketId), required: true);
            var __workflow_idProperty = idProperty == null ? null : WorkflowExpression.Compile(idProperty);
            WorkflowExpression.Validate(__workflow_idProperty, nameof(idProperty), required: false);
            var __workflow_bodypropertiesclosedDate = bodypropertiesclosedDate == null ? null : WorkflowExpression.Compile(bodypropertiesclosedDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            var __workflow_bodypropertiescreatedate = bodypropertiescreatedate == null ? null : WorkflowExpression.Compile(bodypropertiescreatedate);
            WorkflowExpression.Validate(__workflow_bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            var __workflow_bodypropertiesfirstAgentReplyDate = bodypropertiesfirstAgentReplyDate == null ? null : WorkflowExpression.Compile(bodypropertiesfirstAgentReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesFollowUp = bodypropertieshsFeedbackLastCesFollowUp == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesFollowUp);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            var __workflow_bodypropertieshsFeedbackLastCesRating = bodypropertieshsFeedbackLastCesRating == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastCesRating);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            var __workflow_bodypropertieshsFeedbackLastSurveyDate = bodypropertieshsFeedbackLastSurveyDate == null ? null : WorkflowExpression.Compile(bodypropertieshsFeedbackLastSurveyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            var __workflow_bodypropertieshsLastactivitydate = bodypropertieshsLastactivitydate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastactivitydate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            var __workflow_bodypropertieshsLastcontacted = bodypropertieshsLastcontacted == null ? null : WorkflowExpression.Compile(bodypropertieshsLastcontacted);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            var __workflow_bodypropertieshsLastmodifieddate = bodypropertieshsLastmodifieddate == null ? null : WorkflowExpression.Compile(bodypropertieshsLastmodifieddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            var __workflow_bodypropertieshsNextactivitydate = bodypropertieshsNextactivitydate == null ? null : WorkflowExpression.Compile(bodypropertieshsNextactivitydate);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            var __workflow_bodypropertieshsNumTimesContacted = bodypropertieshsNumTimesContacted == null ? null : WorkflowExpression.Compile(bodypropertieshsNumTimesContacted);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            var __workflow_bodypropertieshubspotOwnerAssigneddate = bodypropertieshubspotOwnerAssigneddate == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerAssigneddate);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            var __workflow_bodypropertieslastReplyDate = bodypropertieslastReplyDate == null ? null : WorkflowExpression.Compile(bodypropertieslastReplyDate);
            WorkflowExpression.Validate(__workflow_bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            var __workflow_bodypropertiesnumNotes = bodypropertiesnumNotes == null ? null : WorkflowExpression.Compile(bodypropertiesnumNotes);
            WorkflowExpression.Validate(__workflow_bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            var __workflow_bodypropertiestimeToClose = bodypropertiestimeToClose == null ? null : WorkflowExpression.Compile(bodypropertiestimeToClose);
            WorkflowExpression.Validate(__workflow_bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            var __workflow_bodypropertiestimeToFirstAgentReply = bodypropertiestimeToFirstAgentReply == null ? null : WorkflowExpression.Compile(bodypropertiestimeToFirstAgentReply);
            WorkflowExpression.Validate(__workflow_bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            var __workflow_bodypropertiescontent = bodypropertiescontent == null ? null : WorkflowExpression.Compile(bodypropertiescontent);
            WorkflowExpression.Validate(__workflow_bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            var __workflow_bodypropertieshsFileUpload = bodypropertieshsFileUpload == null ? null : WorkflowExpression.Compile(bodypropertieshsFileUpload);
            WorkflowExpression.Validate(__workflow_bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            var __workflow_bodypropertieshsNumAssociatedCompanies = bodypropertieshsNumAssociatedCompanies == null ? null : WorkflowExpression.Compile(bodypropertieshsNumAssociatedCompanies);
            WorkflowExpression.Validate(__workflow_bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            var __workflow_bodypropertieshsPipeline = bodypropertieshsPipeline == null ? null : WorkflowExpression.Compile(bodypropertieshsPipeline);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            var __workflow_bodypropertieshsPipelineStage = bodypropertieshsPipelineStage == null ? null : WorkflowExpression.Compile(bodypropertieshsPipelineStage);
            WorkflowExpression.Validate(__workflow_bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            var __workflow_bodypropertieshsResolution = bodypropertieshsResolution == null ? null : WorkflowExpression.Compile(bodypropertieshsResolution);
            WorkflowExpression.Validate(__workflow_bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            var __workflow_bodypropertieshsTicketCategory = bodypropertieshsTicketCategory == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketCategory);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            var __workflow_bodypropertieshsTicketId = bodypropertieshsTicketId == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketId);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            var __workflow_bodypropertieshsTicketPriority = bodypropertieshsTicketPriority == null ? null : WorkflowExpression.Compile(bodypropertieshsTicketPriority);
            WorkflowExpression.Validate(__workflow_bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            var __workflow_bodypropertieshubspotOwnerId = bodypropertieshubspotOwnerId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotOwnerId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            var __workflow_bodypropertieshubspotTeamId = bodypropertieshubspotTeamId == null ? null : WorkflowExpression.Compile(bodypropertieshubspotTeamId);
            WorkflowExpression.Validate(__workflow_bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            var __workflow_bodypropertiessourceType = bodypropertiessourceType == null ? null : WorkflowExpression.Compile(bodypropertiessourceType);
            WorkflowExpression.Validate(__workflow_bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            var __workflow_bodypropertiessubject = bodypropertiessubject == null ? null : WorkflowExpression.Compile(bodypropertiessubject);
            WorkflowExpression.Validate(__workflow_bodypropertiessubject, nameof(bodypropertiessubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ticketId, 1));
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
