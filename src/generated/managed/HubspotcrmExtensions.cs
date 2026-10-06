//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcrmActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCompaniesList))]
        public IWorkflowAction CompaniesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesList(WorkflowExpression<int> limit = null, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCompaniesCreate))]
        public IWorkflowAction CompaniesCreate([WorkflowExpression] Func<string> bodypropertiesname, [WorkflowExpression] Func<string> bodypropertiesaboutUs = null, [WorkflowExpression] Func<string> bodypropertiesaddress = null, [WorkflowExpression] Func<string> bodypropertiesaddress2 = null, [WorkflowExpression] Func<string> bodypropertiesannualrevenue = null, [WorkflowExpression] Func<string> bodypropertiescity = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescountry = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdaysToClose = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesdomain = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertiesfacebookCompanyPage = null, [WorkflowExpression] Func<string> bodypropertiesfacebookfans = null, [WorkflowExpression] Func<string> bodypropertiesfirstContactCreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> bodypropertiesfoundedYear = null, [WorkflowExpression] Func<string> bodypropertiesgoogleplusPage = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsIdealCustomerProfile = null, [WorkflowExpression] Func<string> bodypropertieshsIsTargetAccount = null, [WorkflowExpression] Func<string> bodypropertieshsLastBookedMeetingDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastLoggedCallDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastOpenTaskDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsLeadStatus = null, [WorkflowExpression] Func<string> bodypropertieshsNumBlockers = null, [WorkflowExpression] Func<string> bodypropertieshsNumChildCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsNumContactsWithBuyingRoles = null, [WorkflowExpression] Func<string> bodypropertieshsNumDecisionMakers = null, [WorkflowExpression] Func<string> bodypropertieshsNumOpenDeals = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsParentCompanyId = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> bodypropertieshsTotalDealValue = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesindustry = null, [WorkflowExpression] Func<string> bodypropertiesisPublic = null, [WorkflowExpression] Func<string> bodypropertieslifecyclestage = null, [WorkflowExpression] Func<string> bodypropertieslinkedinCompanyPage = null, [WorkflowExpression] Func<string> bodypropertieslinkedinbio = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumberofemployees = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> bodypropertiesstate = null, [WorkflowExpression] Func<string> bodypropertiestimezone = null, [WorkflowExpression] Func<string> bodypropertiestotalMoneyRaised = null, [WorkflowExpression] Func<string> bodypropertiestotalRevenue = null, [WorkflowExpression] Func<string> bodypropertiestwitterbio = null, [WorkflowExpression] Func<string> bodypropertiestwitterfollowers = null, [WorkflowExpression] Func<string> bodypropertiestwitterhandle = null, [WorkflowExpression] Func<string> bodypropertiestype = null, [WorkflowExpression] Func<string> bodypropertieswebTechnologies = null, [WorkflowExpression] Func<string> bodypropertieswebsite = null, [WorkflowExpression] Func<string> bodypropertieszip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesCreate(WorkflowExpression<string> bodypropertiesname, WorkflowExpression<string> bodypropertiesaboutUs = null, WorkflowExpression<string> bodypropertiesaddress = null, WorkflowExpression<string> bodypropertiesaddress2 = null, WorkflowExpression<string> bodypropertiesannualrevenue = null, WorkflowExpression<string> bodypropertiescity = null, WorkflowExpression<string> bodypropertiesclosedate = null, WorkflowExpression<string> bodypropertiescountry = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesdaysToClose = null, WorkflowExpression<string> bodypropertiesdescription = null, WorkflowExpression<string> bodypropertiesdomain = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> bodypropertiesfacebookCompanyPage = null, WorkflowExpression<string> bodypropertiesfacebookfans = null, WorkflowExpression<string> bodypropertiesfirstContactCreatedate = null, WorkflowExpression<string> bodypropertiesfirstConversionDate = null, WorkflowExpression<string> bodypropertiesfirstConversionEventName = null, WorkflowExpression<string> bodypropertiesfirstDealCreatedDate = null, WorkflowExpression<string> bodypropertiesfoundedYear = null, WorkflowExpression<string> bodypropertiesgoogleplusPage = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsNumPageViews = null, WorkflowExpression<string> bodypropertieshsAnalyticsNumVisits = null, WorkflowExpression<string> bodypropertieshsAnalyticsSource = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> bodypropertieshsCreatedate = null, WorkflowExpression<string> bodypropertieshsIdealCustomerProfile = null, WorkflowExpression<string> bodypropertieshsIsTargetAccount = null, WorkflowExpression<string> bodypropertieshsLastBookedMeetingDate = null, WorkflowExpression<string> bodypropertieshsLastLoggedCallDate = null, WorkflowExpression<string> bodypropertieshsLastOpenTaskDate = null, WorkflowExpression<string> bodypropertieshsLastSalesActivityTimestamp = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsLeadStatus = null, WorkflowExpression<string> bodypropertieshsNumBlockers = null, WorkflowExpression<string> bodypropertieshsNumChildCompanies = null, WorkflowExpression<string> bodypropertieshsNumContactsWithBuyingRoles = null, WorkflowExpression<string> bodypropertieshsNumDecisionMakers = null, WorkflowExpression<string> bodypropertieshsNumOpenDeals = null, WorkflowExpression<string> bodypropertieshsObjectId = null, WorkflowExpression<string> bodypropertieshsParentCompanyId = null, WorkflowExpression<string> bodypropertieshsPredictivecontactscoreV2 = null, WorkflowExpression<string> bodypropertieshsTotalDealValue = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertiesindustry = null, WorkflowExpression<string> bodypropertiesisPublic = null, WorkflowExpression<string> bodypropertieslifecyclestage = null, WorkflowExpression<string> bodypropertieslinkedinCompanyPage = null, WorkflowExpression<string> bodypropertieslinkedinbio = null, WorkflowExpression<string> bodypropertiesnotesLastContacted = null, WorkflowExpression<string> bodypropertiesnotesLastUpdated = null, WorkflowExpression<string> bodypropertiesnotesNextActivityDate = null, WorkflowExpression<string> bodypropertiesnumAssociatedContacts = null, WorkflowExpression<string> bodypropertiesnumAssociatedDeals = null, WorkflowExpression<string> bodypropertiesnumContactedNotes = null, WorkflowExpression<string> bodypropertiesnumConversionEvents = null, WorkflowExpression<string> bodypropertiesnumberofemployees = null, WorkflowExpression<string> bodypropertiesphone = null, WorkflowExpression<string> bodypropertiesrecentConversionDate = null, WorkflowExpression<string> bodypropertiesrecentConversionEventName = null, WorkflowExpression<string> bodypropertiesrecentDealAmount = null, WorkflowExpression<string> bodypropertiesrecentDealCloseDate = null, WorkflowExpression<string> bodypropertiesstate = null, WorkflowExpression<string> bodypropertiestimezone = null, WorkflowExpression<string> bodypropertiestotalMoneyRaised = null, WorkflowExpression<string> bodypropertiestotalRevenue = null, WorkflowExpression<string> bodypropertiestwitterbio = null, WorkflowExpression<string> bodypropertiestwitterfollowers = null, WorkflowExpression<string> bodypropertiestwitterhandle = null, WorkflowExpression<string> bodypropertiestype = null, WorkflowExpression<string> bodypropertieswebTechnologies = null, WorkflowExpression<string> bodypropertieswebsite = null, WorkflowExpression<string> bodypropertieszip = null)
        {
            WorkflowExpression.Validate(bodypropertiesname, nameof(bodypropertiesname), required: true);
            WorkflowExpression.Validate(bodypropertiesaboutUs, nameof(bodypropertiesaboutUs), required: false);
            WorkflowExpression.Validate(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            WorkflowExpression.Validate(bodypropertiesaddress2, nameof(bodypropertiesaddress2), required: false);
            WorkflowExpression.Validate(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            WorkflowExpression.Validate(bodypropertiescity, nameof(bodypropertiescity), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowExpression.Validate(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            WorkflowExpression.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowExpression.Validate(bodypropertiesdomain, nameof(bodypropertiesdomain), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(bodypropertiesfacebookCompanyPage, nameof(bodypropertiesfacebookCompanyPage), required: false);
            WorkflowExpression.Validate(bodypropertiesfacebookfans, nameof(bodypropertiesfacebookfans), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstContactCreatedate, nameof(bodypropertiesfirstContactCreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            WorkflowExpression.Validate(bodypropertiesfoundedYear, nameof(bodypropertiesfoundedYear), required: false);
            WorkflowExpression.Validate(bodypropertiesgoogleplusPage, nameof(bodypropertiesgoogleplusPage), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(bodypropertieshsIdealCustomerProfile, nameof(bodypropertieshsIdealCustomerProfile), required: false);
            WorkflowExpression.Validate(bodypropertieshsIsTargetAccount, nameof(bodypropertieshsIsTargetAccount), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastBookedMeetingDate, nameof(bodypropertieshsLastBookedMeetingDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastLoggedCallDate, nameof(bodypropertieshsLastLoggedCallDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastOpenTaskDate, nameof(bodypropertieshsLastOpenTaskDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumBlockers, nameof(bodypropertieshsNumBlockers), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumChildCompanies, nameof(bodypropertieshsNumChildCompanies), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumContactsWithBuyingRoles, nameof(bodypropertieshsNumContactsWithBuyingRoles), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumDecisionMakers, nameof(bodypropertieshsNumDecisionMakers), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumOpenDeals, nameof(bodypropertieshsNumOpenDeals), required: false);
            WorkflowExpression.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowExpression.Validate(bodypropertieshsParentCompanyId, nameof(bodypropertieshsParentCompanyId), required: false);
            WorkflowExpression.Validate(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            WorkflowExpression.Validate(bodypropertieshsTotalDealValue, nameof(bodypropertieshsTotalDealValue), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            WorkflowExpression.Validate(bodypropertiesisPublic, nameof(bodypropertiesisPublic), required: false);
            WorkflowExpression.Validate(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            WorkflowExpression.Validate(bodypropertieslinkedinCompanyPage, nameof(bodypropertieslinkedinCompanyPage), required: false);
            WorkflowExpression.Validate(bodypropertieslinkedinbio, nameof(bodypropertieslinkedinbio), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowExpression.Validate(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            WorkflowExpression.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            WorkflowExpression.Validate(bodypropertiesnumberofemployees, nameof(bodypropertiesnumberofemployees), required: false);
            WorkflowExpression.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            WorkflowExpression.Validate(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            WorkflowExpression.Validate(bodypropertiestimezone, nameof(bodypropertiestimezone), required: false);
            WorkflowExpression.Validate(bodypropertiestotalMoneyRaised, nameof(bodypropertiestotalMoneyRaised), required: false);
            WorkflowExpression.Validate(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            WorkflowExpression.Validate(bodypropertiestwitterbio, nameof(bodypropertiestwitterbio), required: false);
            WorkflowExpression.Validate(bodypropertiestwitterfollowers, nameof(bodypropertiestwitterfollowers), required: false);
            WorkflowExpression.Validate(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            WorkflowExpression.Validate(bodypropertiestype, nameof(bodypropertiestype), required: false);
            WorkflowExpression.Validate(bodypropertieswebTechnologies, nameof(bodypropertieswebTechnologies), required: false);
            WorkflowExpression.Validate(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            WorkflowExpression.Validate(bodypropertieszip, nameof(bodypropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesaboutUs != null)
                {
                    propertiesObject["about_us"] = ExpressionConverter.ConvertO(bodypropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = ExpressionConverter.ConvertO(bodypropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdomain != null)
                {
                    propertiesObject["domain"] = ExpressionConverter.ConvertO(bodypropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = ExpressionConverter.ConvertO(bodypropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = ExpressionConverter.ConvertO(bodypropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = ExpressionConverter.ConvertO(bodypropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = ExpressionConverter.ConvertO(bodypropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = ExpressionConverter.ConvertO(bodypropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = ExpressionConverter.ConvertO(bodypropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = ExpressionConverter.ConvertO(bodypropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = ExpressionConverter.ConvertO(bodypropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = ExpressionConverter.ConvertO(bodypropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = ExpressionConverter.ConvertO(bodypropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = ExpressionConverter.ConvertO(bodypropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = ExpressionConverter.ConvertO(bodypropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = ExpressionConverter.ConvertO(bodypropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = ExpressionConverter.ConvertO(bodypropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = ExpressionConverter.ConvertO(bodypropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = ExpressionConverter.ConvertO(bodypropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = ExpressionConverter.ConvertO(bodypropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = ExpressionConverter.ConvertO(bodypropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = ExpressionConverter.ConvertO(bodypropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = ExpressionConverter.ConvertO(bodypropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = ExpressionConverter.ConvertO(bodypropertiesname);
                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = ExpressionConverter.ConvertO(bodypropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimezone != null)
                {
                    propertiesObject["timezone"] = ExpressionConverter.ConvertO(bodypropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = ExpressionConverter.ConvertO(bodypropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = ExpressionConverter.ConvertO(bodypropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = ExpressionConverter.ConvertO(bodypropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestype != null)
                {
                    propertiesObject["type"] = ExpressionConverter.ConvertO(bodypropertiestype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = ExpressionConverter.ConvertO(bodypropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(bodypropertieszip);
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
        [WorkflowExpressionFactory(nameof(__BuildCompaniesRead))]
        public IWorkflowAction CompaniesRead([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesRead(WorkflowExpression<string> companyId, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCompaniesArchive))]
        public IWorkflowAction CompaniesArchive([WorkflowExpression] Func<string> companyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesArchive(WorkflowExpression<string> companyId)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCompaniesUpdate))]
        public IWorkflowAction CompaniesUpdate([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> propertiespropertiesname, [WorkflowExpression] Func<string> propertiespropertiesaboutUs = null, [WorkflowExpression] Func<string> propertiespropertiesaddress = null, [WorkflowExpression] Func<string> propertiespropertiesaddress2 = null, [WorkflowExpression] Func<string> propertiespropertiesannualrevenue = null, [WorkflowExpression] Func<string> propertiespropertiescity = null, [WorkflowExpression] Func<string> propertiespropertiesclosedate = null, [WorkflowExpression] Func<string> propertiespropertiescountry = null, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesdaysToClose = null, [WorkflowExpression] Func<string> propertiespropertiesdescription = null, [WorkflowExpression] Func<string> propertiespropertiesdomain = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> propertiespropertiesfacebookCompanyPage = null, [WorkflowExpression] Func<string> propertiespropertiesfacebookfans = null, [WorkflowExpression] Func<string> propertiespropertiesfirstContactCreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> propertiespropertiesfoundedYear = null, [WorkflowExpression] Func<string> propertiespropertiesgoogleplusPage = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsIdealCustomerProfile = null, [WorkflowExpression] Func<string> propertiespropertieshsIsTargetAccount = null, [WorkflowExpression] Func<string> propertiespropertieshsLastBookedMeetingDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastLoggedCallDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastOpenTaskDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieshsLeadStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsNumBlockers = null, [WorkflowExpression] Func<string> propertiespropertieshsNumChildCompanies = null, [WorkflowExpression] Func<string> propertiespropertieshsNumContactsWithBuyingRoles = null, [WorkflowExpression] Func<string> propertiespropertieshsNumDecisionMakers = null, [WorkflowExpression] Func<string> propertiespropertieshsNumOpenDeals = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsParentCompanyId = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> propertiespropertieshsTotalDealValue = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotTeamId = null, [WorkflowExpression] Func<string> propertiespropertiesindustry = null, [WorkflowExpression] Func<string> propertiespropertiesisPublic = null, [WorkflowExpression] Func<string> propertiespropertieslifecyclestage = null, [WorkflowExpression] Func<string> propertiespropertieslinkedinCompanyPage = null, [WorkflowExpression] Func<string> propertiespropertieslinkedinbio = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> propertiespropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> propertiespropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumberofemployees = null, [WorkflowExpression] Func<string> propertiespropertiesphone = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> propertiespropertiesstate = null, [WorkflowExpression] Func<string> propertiespropertiestimezone = null, [WorkflowExpression] Func<string> propertiespropertiestotalMoneyRaised = null, [WorkflowExpression] Func<string> propertiespropertiestotalRevenue = null, [WorkflowExpression] Func<string> propertiespropertiestwitterbio = null, [WorkflowExpression] Func<string> propertiespropertiestwitterfollowers = null, [WorkflowExpression] Func<string> propertiespropertiestwitterhandle = null, [WorkflowExpression] Func<string> propertiespropertiestype = null, [WorkflowExpression] Func<string> propertiespropertieswebTechnologies = null, [WorkflowExpression] Func<string> propertiespropertieswebsite = null, [WorkflowExpression] Func<string> propertiespropertieszip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesUpdate(WorkflowExpression<string> companyId, WorkflowExpression<string> propertiespropertiesname, WorkflowExpression<string> propertiespropertiesaboutUs = null, WorkflowExpression<string> propertiespropertiesaddress = null, WorkflowExpression<string> propertiespropertiesaddress2 = null, WorkflowExpression<string> propertiespropertiesannualrevenue = null, WorkflowExpression<string> propertiespropertiescity = null, WorkflowExpression<string> propertiespropertiesclosedate = null, WorkflowExpression<string> propertiespropertiescountry = null, WorkflowExpression<string> propertiespropertiescreatedate = null, WorkflowExpression<string> propertiespropertiesdaysToClose = null, WorkflowExpression<string> propertiespropertiesdescription = null, WorkflowExpression<string> propertiespropertiesdomain = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> propertiespropertiesfacebookCompanyPage = null, WorkflowExpression<string> propertiespropertiesfacebookfans = null, WorkflowExpression<string> propertiespropertiesfirstContactCreatedate = null, WorkflowExpression<string> propertiespropertiesfirstConversionDate = null, WorkflowExpression<string> propertiespropertiesfirstConversionEventName = null, WorkflowExpression<string> propertiespropertiesfirstDealCreatedDate = null, WorkflowExpression<string> propertiespropertiesfoundedYear = null, WorkflowExpression<string> propertiespropertiesgoogleplusPage = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsNumPageViews = null, WorkflowExpression<string> propertiespropertieshsAnalyticsNumVisits = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSource = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> propertiespropertieshsCreatedate = null, WorkflowExpression<string> propertiespropertieshsIdealCustomerProfile = null, WorkflowExpression<string> propertiespropertieshsIsTargetAccount = null, WorkflowExpression<string> propertiespropertieshsLastBookedMeetingDate = null, WorkflowExpression<string> propertiespropertieshsLastLoggedCallDate = null, WorkflowExpression<string> propertiespropertieshsLastOpenTaskDate = null, WorkflowExpression<string> propertiespropertieshsLastSalesActivityTimestamp = null, WorkflowExpression<string> propertiespropertieshsLastmodifieddate = null, WorkflowExpression<string> propertiespropertieshsLeadStatus = null, WorkflowExpression<string> propertiespropertieshsNumBlockers = null, WorkflowExpression<string> propertiespropertieshsNumChildCompanies = null, WorkflowExpression<string> propertiespropertieshsNumContactsWithBuyingRoles = null, WorkflowExpression<string> propertiespropertieshsNumDecisionMakers = null, WorkflowExpression<string> propertiespropertieshsNumOpenDeals = null, WorkflowExpression<string> propertiespropertieshsObjectId = null, WorkflowExpression<string> propertiespropertieshsParentCompanyId = null, WorkflowExpression<string> propertiespropertieshsPredictivecontactscoreV2 = null, WorkflowExpression<string> propertiespropertieshsTotalDealValue = null, WorkflowExpression<string> propertiespropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> propertiespropertieshubspotOwnerId = null, WorkflowExpression<string> propertiespropertieshubspotTeamId = null, WorkflowExpression<string> propertiespropertiesindustry = null, WorkflowExpression<string> propertiespropertiesisPublic = null, WorkflowExpression<string> propertiespropertieslifecyclestage = null, WorkflowExpression<string> propertiespropertieslinkedinCompanyPage = null, WorkflowExpression<string> propertiespropertieslinkedinbio = null, WorkflowExpression<string> propertiespropertiesnotesLastContacted = null, WorkflowExpression<string> propertiespropertiesnotesLastUpdated = null, WorkflowExpression<string> propertiespropertiesnotesNextActivityDate = null, WorkflowExpression<string> propertiespropertiesnumAssociatedContacts = null, WorkflowExpression<string> propertiespropertiesnumAssociatedDeals = null, WorkflowExpression<string> propertiespropertiesnumContactedNotes = null, WorkflowExpression<string> propertiespropertiesnumConversionEvents = null, WorkflowExpression<string> propertiespropertiesnumberofemployees = null, WorkflowExpression<string> propertiespropertiesphone = null, WorkflowExpression<string> propertiespropertiesrecentConversionDate = null, WorkflowExpression<string> propertiespropertiesrecentConversionEventName = null, WorkflowExpression<string> propertiespropertiesrecentDealAmount = null, WorkflowExpression<string> propertiespropertiesrecentDealCloseDate = null, WorkflowExpression<string> propertiespropertiesstate = null, WorkflowExpression<string> propertiespropertiestimezone = null, WorkflowExpression<string> propertiespropertiestotalMoneyRaised = null, WorkflowExpression<string> propertiespropertiestotalRevenue = null, WorkflowExpression<string> propertiespropertiestwitterbio = null, WorkflowExpression<string> propertiespropertiestwitterfollowers = null, WorkflowExpression<string> propertiespropertiestwitterhandle = null, WorkflowExpression<string> propertiespropertiestype = null, WorkflowExpression<string> propertiespropertieswebTechnologies = null, WorkflowExpression<string> propertiespropertieswebsite = null, WorkflowExpression<string> propertiespropertieszip = null)
        {
            WorkflowExpression.Validate(companyId, nameof(companyId), required: true);
            WorkflowExpression.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: true);
            WorkflowExpression.Validate(propertiespropertiesaboutUs, nameof(propertiespropertiesaboutUs), required: false);
            WorkflowExpression.Validate(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            WorkflowExpression.Validate(propertiespropertiesaddress2, nameof(propertiespropertiesaddress2), required: false);
            WorkflowExpression.Validate(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            WorkflowExpression.Validate(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            WorkflowExpression.Validate(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            WorkflowExpression.Validate(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            WorkflowExpression.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            WorkflowExpression.Validate(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            WorkflowExpression.Validate(propertiespropertiesdomain, nameof(propertiespropertiesdomain), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(propertiespropertiesfacebookCompanyPage, nameof(propertiespropertiesfacebookCompanyPage), required: false);
            WorkflowExpression.Validate(propertiespropertiesfacebookfans, nameof(propertiespropertiesfacebookfans), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstContactCreatedate, nameof(propertiespropertiesfirstContactCreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesfoundedYear, nameof(propertiespropertiesfoundedYear), required: false);
            WorkflowExpression.Validate(propertiespropertiesgoogleplusPage, nameof(propertiespropertiesgoogleplusPage), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsIdealCustomerProfile, nameof(propertiespropertieshsIdealCustomerProfile), required: false);
            WorkflowExpression.Validate(propertiespropertieshsIsTargetAccount, nameof(propertiespropertieshsIsTargetAccount), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastBookedMeetingDate, nameof(propertiespropertieshsLastBookedMeetingDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastLoggedCallDate, nameof(propertiespropertieshsLastLoggedCallDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastOpenTaskDate, nameof(propertiespropertieshsLastOpenTaskDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            WorkflowExpression.Validate(propertiespropertieshsNumBlockers, nameof(propertiespropertieshsNumBlockers), required: false);
            WorkflowExpression.Validate(propertiespropertieshsNumChildCompanies, nameof(propertiespropertieshsNumChildCompanies), required: false);
            WorkflowExpression.Validate(propertiespropertieshsNumContactsWithBuyingRoles, nameof(propertiespropertieshsNumContactsWithBuyingRoles), required: false);
            WorkflowExpression.Validate(propertiespropertieshsNumDecisionMakers, nameof(propertiespropertieshsNumDecisionMakers), required: false);
            WorkflowExpression.Validate(propertiespropertieshsNumOpenDeals, nameof(propertiespropertieshsNumOpenDeals), required: false);
            WorkflowExpression.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsParentCompanyId, nameof(propertiespropertieshsParentCompanyId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTotalDealValue, nameof(propertiespropertieshsTotalDealValue), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            WorkflowExpression.Validate(propertiespropertiesisPublic, nameof(propertiespropertiesisPublic), required: false);
            WorkflowExpression.Validate(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            WorkflowExpression.Validate(propertiespropertieslinkedinCompanyPage, nameof(propertiespropertieslinkedinCompanyPage), required: false);
            WorkflowExpression.Validate(propertiespropertieslinkedinbio, nameof(propertiespropertieslinkedinbio), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumAssociatedContacts, nameof(propertiespropertiesnumAssociatedContacts), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumberofemployees, nameof(propertiespropertiesnumberofemployees), required: false);
            WorkflowExpression.Validate(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            WorkflowExpression.Validate(propertiespropertiestimezone, nameof(propertiespropertiestimezone), required: false);
            WorkflowExpression.Validate(propertiespropertiestotalMoneyRaised, nameof(propertiespropertiestotalMoneyRaised), required: false);
            WorkflowExpression.Validate(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            WorkflowExpression.Validate(propertiespropertiestwitterbio, nameof(propertiespropertiestwitterbio), required: false);
            WorkflowExpression.Validate(propertiespropertiestwitterfollowers, nameof(propertiespropertiestwitterfollowers), required: false);
            WorkflowExpression.Validate(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            WorkflowExpression.Validate(propertiespropertiestype, nameof(propertiespropertiestype), required: false);
            WorkflowExpression.Validate(propertiespropertieswebTechnologies, nameof(propertiespropertieswebTechnologies), required: false);
            WorkflowExpression.Validate(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            WorkflowExpression.Validate(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiesaboutUs != null)
                {
                    propertiesObject["about_us"] = ExpressionConverter.ConvertO(propertiespropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = ExpressionConverter.ConvertO(propertiespropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdomain != null)
                {
                    propertiesObject["domain"] = ExpressionConverter.ConvertO(propertiespropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = ExpressionConverter.ConvertO(propertiespropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = ExpressionConverter.ConvertO(propertiespropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = ExpressionConverter.ConvertO(propertiespropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = ExpressionConverter.ConvertO(propertiespropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = ExpressionConverter.ConvertO(propertiespropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = ExpressionConverter.ConvertO(propertiespropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = ExpressionConverter.ConvertO(propertiespropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = ExpressionConverter.ConvertO(propertiespropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = ExpressionConverter.ConvertO(propertiespropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = ExpressionConverter.ConvertO(propertiespropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = ExpressionConverter.ConvertO(propertiespropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = ExpressionConverter.ConvertO(propertiespropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = ExpressionConverter.ConvertO(propertiespropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = ExpressionConverter.ConvertO(propertiespropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = ExpressionConverter.ConvertO(propertiespropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = ExpressionConverter.ConvertO(propertiespropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = ExpressionConverter.ConvertO(propertiespropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = ExpressionConverter.ConvertO(propertiespropertiesname);
                if (propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(propertiespropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = ExpressionConverter.ConvertO(propertiespropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestimezone != null)
                {
                    propertiesObject["timezone"] = ExpressionConverter.ConvertO(propertiespropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = ExpressionConverter.ConvertO(propertiespropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = ExpressionConverter.ConvertO(propertiespropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = ExpressionConverter.ConvertO(propertiespropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestype != null)
                {
                    propertiesObject["type"] = ExpressionConverter.ConvertO(propertiespropertiestype);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = ExpressionConverter.ConvertO(propertiespropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(propertiespropertieszip);
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
        [WorkflowExpressionFactory(nameof(__BuildContactsList))]
        public IWorkflowAction ContactsList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<string> properties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsList(WorkflowExpression<int> limit, WorkflowExpression<string> properties = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (properties != null)
                    callPayload.Queries["properties[]"] = ExpressionConverter.Convert(properties);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsCreate))]
        public IWorkflowAction ContactsCreate([WorkflowExpression] Func<string> bodypropertiesaddress = null, [WorkflowExpression] Func<string> bodypropertiesannualrevenue = null, [WorkflowExpression] Func<string> bodypropertiescity = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescompany = null, [WorkflowExpression] Func<string> bodypropertiescompanySize = null, [WorkflowExpression] Func<string> bodypropertiescountry = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiescurrentlyinworkflow = null, [WorkflowExpression] Func<string> bodypropertiesdateOfBirth = null, [WorkflowExpression] Func<string> bodypropertiesdaysToClose = null, [WorkflowExpression] Func<string> bodypropertiesdegree = null, [WorkflowExpression] Func<string> bodypropertiesemail = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertiesfax = null, [WorkflowExpression] Func<string> bodypropertiesfieldOfStudy = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstname = null, [WorkflowExpression] Func<string> bodypropertiesgender = null, [WorkflowExpression] Func<string> bodypropertiesgraduationDate = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsAveragePageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstReferrer = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstUrl = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastReferrer = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastUrl = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumEventCompletions = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsRevenue = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsBuyingRole = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipEmailConfirmed = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipNotes = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegisteredAt = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipStatus = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailBadAddress = null, [WorkflowExpression] Func<string> bodypropertieshsEmailBounce = null, [WorkflowExpression] Func<string> bodypropertieshsEmailClick = null, [WorkflowExpression] Func<string> bodypropertieshsEmailCustomerQuarantinedReason = null, [WorkflowExpression] Func<string> bodypropertieshsEmailDelivered = null, [WorkflowExpression] Func<string> bodypropertieshsEmailDomain = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstClickDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstOpenDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstSendDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailHardBounceReasonEnum = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastClickDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastEmailName = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastOpenDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastSendDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOpen = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOptout = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOptout12592317 = null, [WorkflowExpression] Func<string> bodypropertieshsEmailQuarantined = null, [WorkflowExpression] Func<string> bodypropertieshsEmailQuarantinedReason = null, [WorkflowExpression] Func<string> bodypropertieshsEmailReplied = null, [WorkflowExpression] Func<string> bodypropertieshsEmailSendsSinceLastEngagement = null, [WorkflowExpression] Func<string> bodypropertieshsEmailconfirmationstatus = null, [WorkflowExpression] Func<string> bodypropertieshsFacebookClickId = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastNpsFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastNpsRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsGoogleClickId = null, [WorkflowExpression] Func<string> bodypropertieshsIpTimezone = null, [WorkflowExpression] Func<string> bodypropertieshsIsUnworked = null, [WorkflowExpression] Func<string> bodypropertieshsLanguage = null, [WorkflowExpression] Func<string> bodypropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsLeadStatus = null, [WorkflowExpression] Func<string> bodypropertieshsLegalBasis = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageCustomerDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageEvangelistDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageLeadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageOpportunityDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageOtherDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageSubscriberDate = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableReasonId = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableReasonType = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableStatus = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableUntilRenewal = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPersona = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscore = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscorebucket = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivescoringtier = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastClicked = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastOpened = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastReplied = null, [WorkflowExpression] Func<string> bodypropertieshsSequencesIsEnrolled = null, [WorkflowExpression] Func<string> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, [WorkflowExpression] Func<string> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromLeadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertieshubspotscore = null, [WorkflowExpression] Func<string> bodypropertiesindustry = null, [WorkflowExpression] Func<string> bodypropertiesipCity = null, [WorkflowExpression] Func<string> bodypropertiesipCountry = null, [WorkflowExpression] Func<string> bodypropertiesipCountryCode = null, [WorkflowExpression] Func<string> bodypropertiesipState = null, [WorkflowExpression] Func<string> bodypropertiesipStateCode = null, [WorkflowExpression] Func<string> bodypropertiesjobFunction = null, [WorkflowExpression] Func<string> bodypropertiesjobtitle = null, [WorkflowExpression] Func<string> bodypropertieslastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieslastname = null, [WorkflowExpression] Func<string> bodypropertieslifecyclestage = null, [WorkflowExpression] Func<string> bodypropertiesmaritalStatus = null, [WorkflowExpression] Func<string> bodypropertiesmessage = null, [WorkflowExpression] Func<string> bodypropertiesmilitaryStatus = null, [WorkflowExpression] Func<string> bodypropertiesmobilephone = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumUniqueConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumemployees = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> bodypropertiesrelationshipStatus = null, [WorkflowExpression] Func<string> bodypropertiessalutation = null, [WorkflowExpression] Func<string> bodypropertiesschool = null, [WorkflowExpression] Func<string> bodypropertiesseniority = null, [WorkflowExpression] Func<string> bodypropertiesstartDate = null, [WorkflowExpression] Func<string> bodypropertiesstate = null, [WorkflowExpression] Func<string> bodypropertiestotalRevenue = null, [WorkflowExpression] Func<string> bodypropertiestwitterhandle = null, [WorkflowExpression] Func<string> bodypropertieswebsite = null, [WorkflowExpression] Func<string> bodypropertiesworkEmail = null, [WorkflowExpression] Func<string> bodypropertieszip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsCreate(WorkflowExpression<string> bodypropertiesaddress = null, WorkflowExpression<string> bodypropertiesannualrevenue = null, WorkflowExpression<string> bodypropertiescity = null, WorkflowExpression<string> bodypropertiesclosedate = null, WorkflowExpression<string> bodypropertiescompany = null, WorkflowExpression<string> bodypropertiescompanySize = null, WorkflowExpression<string> bodypropertiescountry = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiescurrentlyinworkflow = null, WorkflowExpression<string> bodypropertiesdateOfBirth = null, WorkflowExpression<string> bodypropertiesdaysToClose = null, WorkflowExpression<string> bodypropertiesdegree = null, WorkflowExpression<string> bodypropertiesemail = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> bodypropertiesfax = null, WorkflowExpression<string> bodypropertiesfieldOfStudy = null, WorkflowExpression<string> bodypropertiesfirstConversionDate = null, WorkflowExpression<string> bodypropertiesfirstConversionEventName = null, WorkflowExpression<string> bodypropertiesfirstDealCreatedDate = null, WorkflowExpression<string> bodypropertiesfirstname = null, WorkflowExpression<string> bodypropertiesgender = null, WorkflowExpression<string> bodypropertiesgraduationDate = null, WorkflowExpression<string> bodypropertieshsAnalyticsAveragePageViews = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstReferrer = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstUrl = null, WorkflowExpression<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastReferrer = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastUrl = null, WorkflowExpression<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, WorkflowExpression<string> bodypropertieshsAnalyticsNumEventCompletions = null, WorkflowExpression<string> bodypropertieshsAnalyticsNumPageViews = null, WorkflowExpression<string> bodypropertieshsAnalyticsNumVisits = null, WorkflowExpression<string> bodypropertieshsAnalyticsRevenue = null, WorkflowExpression<string> bodypropertieshsAnalyticsSource = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> bodypropertieshsBuyingRole = null, WorkflowExpression<string> bodypropertieshsContentMembershipEmailConfirmed = null, WorkflowExpression<string> bodypropertieshsContentMembershipNotes = null, WorkflowExpression<string> bodypropertieshsContentMembershipRegisteredAt = null, WorkflowExpression<string> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, WorkflowExpression<string> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, WorkflowExpression<string> bodypropertieshsContentMembershipStatus = null, WorkflowExpression<string> bodypropertieshsCreatedate = null, WorkflowExpression<string> bodypropertieshsEmailBadAddress = null, WorkflowExpression<string> bodypropertieshsEmailBounce = null, WorkflowExpression<string> bodypropertieshsEmailClick = null, WorkflowExpression<string> bodypropertieshsEmailCustomerQuarantinedReason = null, WorkflowExpression<string> bodypropertieshsEmailDelivered = null, WorkflowExpression<string> bodypropertieshsEmailDomain = null, WorkflowExpression<string> bodypropertieshsEmailFirstClickDate = null, WorkflowExpression<string> bodypropertieshsEmailFirstOpenDate = null, WorkflowExpression<string> bodypropertieshsEmailFirstReplyDate = null, WorkflowExpression<string> bodypropertieshsEmailFirstSendDate = null, WorkflowExpression<string> bodypropertieshsEmailHardBounceReasonEnum = null, WorkflowExpression<string> bodypropertieshsEmailLastClickDate = null, WorkflowExpression<string> bodypropertieshsEmailLastEmailName = null, WorkflowExpression<string> bodypropertieshsEmailLastOpenDate = null, WorkflowExpression<string> bodypropertieshsEmailLastReplyDate = null, WorkflowExpression<string> bodypropertieshsEmailLastSendDate = null, WorkflowExpression<string> bodypropertieshsEmailOpen = null, WorkflowExpression<string> bodypropertieshsEmailOptout = null, WorkflowExpression<string> bodypropertieshsEmailOptout12592317 = null, WorkflowExpression<string> bodypropertieshsEmailQuarantined = null, WorkflowExpression<string> bodypropertieshsEmailQuarantinedReason = null, WorkflowExpression<string> bodypropertieshsEmailReplied = null, WorkflowExpression<string> bodypropertieshsEmailSendsSinceLastEngagement = null, WorkflowExpression<string> bodypropertieshsEmailconfirmationstatus = null, WorkflowExpression<string> bodypropertieshsFacebookClickId = null, WorkflowExpression<string> bodypropertieshsFeedbackLastNpsFollowUp = null, WorkflowExpression<string> bodypropertieshsFeedbackLastNpsRating = null, WorkflowExpression<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowExpression<string> bodypropertieshsGoogleClickId = null, WorkflowExpression<string> bodypropertieshsIpTimezone = null, WorkflowExpression<string> bodypropertieshsIsUnworked = null, WorkflowExpression<string> bodypropertieshsLanguage = null, WorkflowExpression<string> bodypropertieshsLastSalesActivityTimestamp = null, WorkflowExpression<string> bodypropertieshsLeadStatus = null, WorkflowExpression<string> bodypropertieshsLegalBasis = null, WorkflowExpression<string> bodypropertieshsLifecyclestageCustomerDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageEvangelistDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageLeadDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageOpportunityDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageOtherDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, WorkflowExpression<string> bodypropertieshsLifecyclestageSubscriberDate = null, WorkflowExpression<string> bodypropertieshsMarketableReasonId = null, WorkflowExpression<string> bodypropertieshsMarketableReasonType = null, WorkflowExpression<string> bodypropertieshsMarketableStatus = null, WorkflowExpression<string> bodypropertieshsMarketableUntilRenewal = null, WorkflowExpression<string> bodypropertieshsObjectId = null, WorkflowExpression<string> bodypropertieshsPersona = null, WorkflowExpression<string> bodypropertieshsPredictivecontactscore = null, WorkflowExpression<string> bodypropertieshsPredictivecontactscoreV2 = null, WorkflowExpression<string> bodypropertieshsPredictivecontactscorebucket = null, WorkflowExpression<string> bodypropertieshsPredictivescoringtier = null, WorkflowExpression<string> bodypropertieshsSalesEmailLastClicked = null, WorkflowExpression<string> bodypropertieshsSalesEmailLastOpened = null, WorkflowExpression<string> bodypropertieshsSalesEmailLastReplied = null, WorkflowExpression<string> bodypropertieshsSequencesIsEnrolled = null, WorkflowExpression<string> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, WorkflowExpression<string> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, WorkflowExpression<string> bodypropertieshsTimeToMoveFromLeadToCustomer = null, WorkflowExpression<string> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, WorkflowExpression<string> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, WorkflowExpression<string> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, WorkflowExpression<string> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertieshubspotscore = null, WorkflowExpression<string> bodypropertiesindustry = null, WorkflowExpression<string> bodypropertiesipCity = null, WorkflowExpression<string> bodypropertiesipCountry = null, WorkflowExpression<string> bodypropertiesipCountryCode = null, WorkflowExpression<string> bodypropertiesipState = null, WorkflowExpression<string> bodypropertiesipStateCode = null, WorkflowExpression<string> bodypropertiesjobFunction = null, WorkflowExpression<string> bodypropertiesjobtitle = null, WorkflowExpression<string> bodypropertieslastmodifieddate = null, WorkflowExpression<string> bodypropertieslastname = null, WorkflowExpression<string> bodypropertieslifecyclestage = null, WorkflowExpression<string> bodypropertiesmaritalStatus = null, WorkflowExpression<string> bodypropertiesmessage = null, WorkflowExpression<string> bodypropertiesmilitaryStatus = null, WorkflowExpression<string> bodypropertiesmobilephone = null, WorkflowExpression<string> bodypropertiesnotesLastContacted = null, WorkflowExpression<string> bodypropertiesnotesLastUpdated = null, WorkflowExpression<string> bodypropertiesnotesNextActivityDate = null, WorkflowExpression<string> bodypropertiesnumAssociatedDeals = null, WorkflowExpression<string> bodypropertiesnumContactedNotes = null, WorkflowExpression<string> bodypropertiesnumConversionEvents = null, WorkflowExpression<string> bodypropertiesnumNotes = null, WorkflowExpression<string> bodypropertiesnumUniqueConversionEvents = null, WorkflowExpression<string> bodypropertiesnumemployees = null, WorkflowExpression<string> bodypropertiesphone = null, WorkflowExpression<string> bodypropertiesrecentConversionDate = null, WorkflowExpression<string> bodypropertiesrecentConversionEventName = null, WorkflowExpression<string> bodypropertiesrecentDealAmount = null, WorkflowExpression<string> bodypropertiesrecentDealCloseDate = null, WorkflowExpression<string> bodypropertiesrelationshipStatus = null, WorkflowExpression<string> bodypropertiessalutation = null, WorkflowExpression<string> bodypropertiesschool = null, WorkflowExpression<string> bodypropertiesseniority = null, WorkflowExpression<string> bodypropertiesstartDate = null, WorkflowExpression<string> bodypropertiesstate = null, WorkflowExpression<string> bodypropertiestotalRevenue = null, WorkflowExpression<string> bodypropertiestwitterhandle = null, WorkflowExpression<string> bodypropertieswebsite = null, WorkflowExpression<string> bodypropertiesworkEmail = null, WorkflowExpression<string> bodypropertieszip = null)
        {
            WorkflowExpression.Validate(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            WorkflowExpression.Validate(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            WorkflowExpression.Validate(bodypropertiescity, nameof(bodypropertiescity), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowExpression.Validate(bodypropertiescompany, nameof(bodypropertiescompany), required: false);
            WorkflowExpression.Validate(bodypropertiescompanySize, nameof(bodypropertiescompanySize), required: false);
            WorkflowExpression.Validate(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiescurrentlyinworkflow, nameof(bodypropertiescurrentlyinworkflow), required: false);
            WorkflowExpression.Validate(bodypropertiesdateOfBirth, nameof(bodypropertiesdateOfBirth), required: false);
            WorkflowExpression.Validate(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            WorkflowExpression.Validate(bodypropertiesdegree, nameof(bodypropertiesdegree), required: false);
            WorkflowExpression.Validate(bodypropertiesemail, nameof(bodypropertiesemail), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(bodypropertiesfax, nameof(bodypropertiesfax), required: false);
            WorkflowExpression.Validate(bodypropertiesfieldOfStudy, nameof(bodypropertiesfieldOfStudy), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstname, nameof(bodypropertiesfirstname), required: false);
            WorkflowExpression.Validate(bodypropertiesgender, nameof(bodypropertiesgender), required: false);
            WorkflowExpression.Validate(bodypropertiesgraduationDate, nameof(bodypropertiesgraduationDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsAveragePageViews, nameof(bodypropertieshsAnalyticsAveragePageViews), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstReferrer, nameof(bodypropertieshsAnalyticsFirstReferrer), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstUrl, nameof(bodypropertieshsAnalyticsFirstUrl), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastReferrer, nameof(bodypropertieshsAnalyticsLastReferrer), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastUrl, nameof(bodypropertieshsAnalyticsLastUrl), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsNumEventCompletions, nameof(bodypropertieshsAnalyticsNumEventCompletions), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsRevenue, nameof(bodypropertieshsAnalyticsRevenue), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(bodypropertieshsBuyingRole, nameof(bodypropertieshsBuyingRole), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipEmailConfirmed, nameof(bodypropertieshsContentMembershipEmailConfirmed), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipNotes, nameof(bodypropertieshsContentMembershipNotes), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipRegisteredAt, nameof(bodypropertieshsContentMembershipRegisteredAt), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipRegistrationDomainSentTo, nameof(bodypropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipRegistrationEmailSentAt, nameof(bodypropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            WorkflowExpression.Validate(bodypropertieshsContentMembershipStatus, nameof(bodypropertieshsContentMembershipStatus), required: false);
            WorkflowExpression.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailBadAddress, nameof(bodypropertieshsEmailBadAddress), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailBounce, nameof(bodypropertieshsEmailBounce), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailClick, nameof(bodypropertieshsEmailClick), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailCustomerQuarantinedReason, nameof(bodypropertieshsEmailCustomerQuarantinedReason), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailDelivered, nameof(bodypropertieshsEmailDelivered), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailDomain, nameof(bodypropertieshsEmailDomain), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailFirstClickDate, nameof(bodypropertieshsEmailFirstClickDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailFirstOpenDate, nameof(bodypropertieshsEmailFirstOpenDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailFirstReplyDate, nameof(bodypropertieshsEmailFirstReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailFirstSendDate, nameof(bodypropertieshsEmailFirstSendDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailHardBounceReasonEnum, nameof(bodypropertieshsEmailHardBounceReasonEnum), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailLastClickDate, nameof(bodypropertieshsEmailLastClickDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailLastEmailName, nameof(bodypropertieshsEmailLastEmailName), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailLastOpenDate, nameof(bodypropertieshsEmailLastOpenDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailLastReplyDate, nameof(bodypropertieshsEmailLastReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailLastSendDate, nameof(bodypropertieshsEmailLastSendDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailOpen, nameof(bodypropertieshsEmailOpen), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailOptout, nameof(bodypropertieshsEmailOptout), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailOptout12592317, nameof(bodypropertieshsEmailOptout12592317), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailQuarantined, nameof(bodypropertieshsEmailQuarantined), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailQuarantinedReason, nameof(bodypropertieshsEmailQuarantinedReason), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailReplied, nameof(bodypropertieshsEmailReplied), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailSendsSinceLastEngagement, nameof(bodypropertieshsEmailSendsSinceLastEngagement), required: false);
            WorkflowExpression.Validate(bodypropertieshsEmailconfirmationstatus, nameof(bodypropertieshsEmailconfirmationstatus), required: false);
            WorkflowExpression.Validate(bodypropertieshsFacebookClickId, nameof(bodypropertieshsFacebookClickId), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastNpsFollowUp, nameof(bodypropertieshsFeedbackLastNpsFollowUp), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastNpsRating, nameof(bodypropertieshsFeedbackLastNpsRating), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsGoogleClickId, nameof(bodypropertieshsGoogleClickId), required: false);
            WorkflowExpression.Validate(bodypropertieshsIpTimezone, nameof(bodypropertieshsIpTimezone), required: false);
            WorkflowExpression.Validate(bodypropertieshsIsUnworked, nameof(bodypropertieshsIsUnworked), required: false);
            WorkflowExpression.Validate(bodypropertieshsLanguage, nameof(bodypropertieshsLanguage), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowExpression.Validate(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            WorkflowExpression.Validate(bodypropertieshsLegalBasis, nameof(bodypropertieshsLegalBasis), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageCustomerDate, nameof(bodypropertieshsLifecyclestageCustomerDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageEvangelistDate, nameof(bodypropertieshsLifecyclestageEvangelistDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageLeadDate, nameof(bodypropertieshsLifecyclestageLeadDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(bodypropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageOpportunityDate, nameof(bodypropertieshsLifecyclestageOpportunityDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageOtherDate, nameof(bodypropertieshsLifecyclestageOtherDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageSalesqualifiedleadDate, nameof(bodypropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLifecyclestageSubscriberDate, nameof(bodypropertieshsLifecyclestageSubscriberDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsMarketableReasonId, nameof(bodypropertieshsMarketableReasonId), required: false);
            WorkflowExpression.Validate(bodypropertieshsMarketableReasonType, nameof(bodypropertieshsMarketableReasonType), required: false);
            WorkflowExpression.Validate(bodypropertieshsMarketableStatus, nameof(bodypropertieshsMarketableStatus), required: false);
            WorkflowExpression.Validate(bodypropertieshsMarketableUntilRenewal, nameof(bodypropertieshsMarketableUntilRenewal), required: false);
            WorkflowExpression.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowExpression.Validate(bodypropertieshsPersona, nameof(bodypropertieshsPersona), required: false);
            WorkflowExpression.Validate(bodypropertieshsPredictivecontactscore, nameof(bodypropertieshsPredictivecontactscore), required: false);
            WorkflowExpression.Validate(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            WorkflowExpression.Validate(bodypropertieshsPredictivecontactscorebucket, nameof(bodypropertieshsPredictivecontactscorebucket), required: false);
            WorkflowExpression.Validate(bodypropertieshsPredictivescoringtier, nameof(bodypropertieshsPredictivescoringtier), required: false);
            WorkflowExpression.Validate(bodypropertieshsSalesEmailLastClicked, nameof(bodypropertieshsSalesEmailLastClicked), required: false);
            WorkflowExpression.Validate(bodypropertieshsSalesEmailLastOpened, nameof(bodypropertieshsSalesEmailLastOpened), required: false);
            WorkflowExpression.Validate(bodypropertieshsSalesEmailLastReplied, nameof(bodypropertieshsSalesEmailLastReplied), required: false);
            WorkflowExpression.Validate(bodypropertieshsSequencesIsEnrolled, nameof(bodypropertieshsSequencesIsEnrolled), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeBetweenContactCreationAndDealClose, nameof(bodypropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeBetweenContactCreationAndDealCreation, nameof(bodypropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeToMoveFromLeadToCustomer, nameof(bodypropertieshsTimeToMoveFromLeadToCustomer), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeToMoveFromOpportunityToCustomer, nameof(bodypropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            WorkflowExpression.Validate(bodypropertieshsTimeToMoveFromSubscriberToCustomer, nameof(bodypropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotscore, nameof(bodypropertieshubspotscore), required: false);
            WorkflowExpression.Validate(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            WorkflowExpression.Validate(bodypropertiesipCity, nameof(bodypropertiesipCity), required: false);
            WorkflowExpression.Validate(bodypropertiesipCountry, nameof(bodypropertiesipCountry), required: false);
            WorkflowExpression.Validate(bodypropertiesipCountryCode, nameof(bodypropertiesipCountryCode), required: false);
            WorkflowExpression.Validate(bodypropertiesipState, nameof(bodypropertiesipState), required: false);
            WorkflowExpression.Validate(bodypropertiesipStateCode, nameof(bodypropertiesipStateCode), required: false);
            WorkflowExpression.Validate(bodypropertiesjobFunction, nameof(bodypropertiesjobFunction), required: false);
            WorkflowExpression.Validate(bodypropertiesjobtitle, nameof(bodypropertiesjobtitle), required: false);
            WorkflowExpression.Validate(bodypropertieslastmodifieddate, nameof(bodypropertieslastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieslastname, nameof(bodypropertieslastname), required: false);
            WorkflowExpression.Validate(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            WorkflowExpression.Validate(bodypropertiesmaritalStatus, nameof(bodypropertiesmaritalStatus), required: false);
            WorkflowExpression.Validate(bodypropertiesmessage, nameof(bodypropertiesmessage), required: false);
            WorkflowExpression.Validate(bodypropertiesmilitaryStatus, nameof(bodypropertiesmilitaryStatus), required: false);
            WorkflowExpression.Validate(bodypropertiesmobilephone, nameof(bodypropertiesmobilephone), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            WorkflowExpression.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            WorkflowExpression.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowExpression.Validate(bodypropertiesnumUniqueConversionEvents, nameof(bodypropertiesnumUniqueConversionEvents), required: false);
            WorkflowExpression.Validate(bodypropertiesnumemployees, nameof(bodypropertiesnumemployees), required: false);
            WorkflowExpression.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            WorkflowExpression.Validate(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            WorkflowExpression.Validate(bodypropertiesrelationshipStatus, nameof(bodypropertiesrelationshipStatus), required: false);
            WorkflowExpression.Validate(bodypropertiessalutation, nameof(bodypropertiessalutation), required: false);
            WorkflowExpression.Validate(bodypropertiesschool, nameof(bodypropertiesschool), required: false);
            WorkflowExpression.Validate(bodypropertiesseniority, nameof(bodypropertiesseniority), required: false);
            WorkflowExpression.Validate(bodypropertiesstartDate, nameof(bodypropertiesstartDate), required: false);
            WorkflowExpression.Validate(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            WorkflowExpression.Validate(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            WorkflowExpression.Validate(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            WorkflowExpression.Validate(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            WorkflowExpression.Validate(bodypropertiesworkEmail, nameof(bodypropertiesworkEmail), required: false);
            WorkflowExpression.Validate(bodypropertieszip, nameof(bodypropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescompany != null)
                {
                    propertiesObject["company"] = ExpressionConverter.ConvertO(bodypropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = ExpressionConverter.ConvertO(bodypropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = ExpressionConverter.ConvertO(bodypropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = ExpressionConverter.ConvertO(bodypropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdegree != null)
                {
                    propertiesObject["degree"] = ExpressionConverter.ConvertO(bodypropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesemail != null)
                {
                    propertiesObject["email"] = ExpressionConverter.ConvertO(bodypropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfax != null)
                {
                    propertiesObject["fax"] = ExpressionConverter.ConvertO(bodypropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = ExpressionConverter.ConvertO(bodypropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = ExpressionConverter.ConvertO(bodypropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgender != null)
                {
                    propertiesObject["gender"] = ExpressionConverter.ConvertO(bodypropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = ExpressionConverter.ConvertO(bodypropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = ExpressionConverter.ConvertO(bodypropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = ExpressionConverter.ConvertO(bodypropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = ExpressionConverter.ConvertO(bodypropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = ExpressionConverter.ConvertO(bodypropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = ExpressionConverter.ConvertO(bodypropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = ExpressionConverter.ConvertO(bodypropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = ExpressionConverter.ConvertO(bodypropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = ExpressionConverter.ConvertO(bodypropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = ExpressionConverter.ConvertO(bodypropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = ExpressionConverter.ConvertO(bodypropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = ExpressionConverter.ConvertO(bodypropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = ExpressionConverter.ConvertO(bodypropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = ExpressionConverter.ConvertO(bodypropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = ExpressionConverter.ConvertO(bodypropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = ExpressionConverter.ConvertO(bodypropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = ExpressionConverter.ConvertO(bodypropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = ExpressionConverter.ConvertO(bodypropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = ExpressionConverter.ConvertO(bodypropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = ExpressionConverter.ConvertO(bodypropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = ExpressionConverter.ConvertO(bodypropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = ExpressionConverter.ConvertO(bodypropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = ExpressionConverter.ConvertO(bodypropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = ExpressionConverter.ConvertO(bodypropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = ExpressionConverter.ConvertO(bodypropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = ExpressionConverter.ConvertO(bodypropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = ExpressionConverter.ConvertO(bodypropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = ExpressionConverter.ConvertO(bodypropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = ExpressionConverter.ConvertO(bodypropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = ExpressionConverter.ConvertO(bodypropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = ExpressionConverter.ConvertO(bodypropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = ExpressionConverter.ConvertO(bodypropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = ExpressionConverter.ConvertO(bodypropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = ExpressionConverter.ConvertO(bodypropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = ExpressionConverter.ConvertO(bodypropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = ExpressionConverter.ConvertO(bodypropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = ExpressionConverter.ConvertO(bodypropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = ExpressionConverter.ConvertO(bodypropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = ExpressionConverter.ConvertO(bodypropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = ExpressionConverter.ConvertO(bodypropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = ExpressionConverter.ConvertO(bodypropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = ExpressionConverter.ConvertO(bodypropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = ExpressionConverter.ConvertO(bodypropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = ExpressionConverter.ConvertO(bodypropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = ExpressionConverter.ConvertO(bodypropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = ExpressionConverter.ConvertO(bodypropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = ExpressionConverter.ConvertO(bodypropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = ExpressionConverter.ConvertO(bodypropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipState != null)
                {
                    propertiesObject["ip_state"] = ExpressionConverter.ConvertO(bodypropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = ExpressionConverter.ConvertO(bodypropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = ExpressionConverter.ConvertO(bodypropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = ExpressionConverter.ConvertO(bodypropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastname != null)
                {
                    propertiesObject["lastname"] = ExpressionConverter.ConvertO(bodypropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = ExpressionConverter.ConvertO(bodypropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmessage != null)
                {
                    propertiesObject["message"] = ExpressionConverter.ConvertO(bodypropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = ExpressionConverter.ConvertO(bodypropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = ExpressionConverter.ConvertO(bodypropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = ExpressionConverter.ConvertO(bodypropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = ExpressionConverter.ConvertO(bodypropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = ExpressionConverter.ConvertO(bodypropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessalutation != null)
                {
                    propertiesObject["salutation"] = ExpressionConverter.ConvertO(bodypropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesschool != null)
                {
                    propertiesObject["school"] = ExpressionConverter.ConvertO(bodypropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesseniority != null)
                {
                    propertiesObject["seniority"] = ExpressionConverter.ConvertO(bodypropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = ExpressionConverter.ConvertO(bodypropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = ExpressionConverter.ConvertO(bodypropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(bodypropertieszip);
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
        [WorkflowExpressionFactory(nameof(__BuildContactsRead))]
        public IWorkflowAction ContactsRead([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsRead(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsArchive))]
        public IWorkflowAction ContactsArchive([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsArchive(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactsUpdate))]
        public IWorkflowAction ContactsUpdate([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> propertiespropertiesaddress = null, [WorkflowExpression] Func<string> propertiespropertiesannualrevenue = null, [WorkflowExpression] Func<string> propertiespropertiescity = null, [WorkflowExpression] Func<string> propertiespropertiesclosedate = null, [WorkflowExpression] Func<string> propertiespropertiescompany = null, [WorkflowExpression] Func<string> propertiespropertiescompanySize = null, [WorkflowExpression] Func<string> propertiespropertiescountry = null, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiescurrentlyinworkflow = null, [WorkflowExpression] Func<string> propertiespropertiesdateOfBirth = null, [WorkflowExpression] Func<string> propertiespropertiesdaysToClose = null, [WorkflowExpression] Func<string> propertiespropertiesdegree = null, [WorkflowExpression] Func<string> propertiespropertiesemail = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> propertiespropertiesfax = null, [WorkflowExpression] Func<string> propertiespropertiesfieldOfStudy = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstname = null, [WorkflowExpression] Func<string> propertiespropertiesgender = null, [WorkflowExpression] Func<string> propertiespropertiesgraduationDate = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsAveragePageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstReferrer = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstUrl = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastReferrer = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastUrl = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumEventCompletions = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsRevenue = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> propertiespropertieshsBuyingRole = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipEmailConfirmed = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipNotes = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegisteredAt = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailBadAddress = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailBounce = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailClick = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailCustomerQuarantinedReason = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailDelivered = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailDomain = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstClickDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstOpenDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstReplyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstSendDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailHardBounceReasonEnum = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastClickDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastEmailName = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastOpenDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastReplyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastSendDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOpen = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOptout = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOptout12592317 = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailQuarantined = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailQuarantinedReason = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailReplied = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailSendsSinceLastEngagement = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailconfirmationstatus = null, [WorkflowExpression] Func<string> propertiespropertieshsFacebookClickId = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastNpsFollowUp = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastNpsRating = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsGoogleClickId = null, [WorkflowExpression] Func<string> propertiespropertieshsIpTimezone = null, [WorkflowExpression] Func<string> propertiespropertieshsIsUnworked = null, [WorkflowExpression] Func<string> propertiespropertieshsLanguage = null, [WorkflowExpression] Func<string> propertiespropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsLeadStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsLegalBasis = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageCustomerDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageEvangelistDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageLeadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageOpportunityDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageOtherDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageSubscriberDate = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableReasonId = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableReasonType = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableUntilRenewal = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsPersona = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscore = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscorebucket = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivescoringtier = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastClicked = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastOpened = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastReplied = null, [WorkflowExpression] Func<string> propertiespropertieshsSequencesIsEnrolled = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotTeamId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotscore = null, [WorkflowExpression] Func<string> propertiespropertiesindustry = null, [WorkflowExpression] Func<string> propertiespropertiesipCity = null, [WorkflowExpression] Func<string> propertiespropertiesipCountry = null, [WorkflowExpression] Func<string> propertiespropertiesipCountryCode = null, [WorkflowExpression] Func<string> propertiespropertiesipState = null, [WorkflowExpression] Func<string> propertiespropertiesipStateCode = null, [WorkflowExpression] Func<string> propertiespropertiesjobFunction = null, [WorkflowExpression] Func<string> propertiespropertiesjobtitle = null, [WorkflowExpression] Func<string> propertiespropertieslastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieslastname = null, [WorkflowExpression] Func<string> propertiespropertieslifecyclestage = null, [WorkflowExpression] Func<string> propertiespropertiesmaritalStatus = null, [WorkflowExpression] Func<string> propertiespropertiesmessage = null, [WorkflowExpression] Func<string> propertiespropertiesmilitaryStatus = null, [WorkflowExpression] Func<string> propertiespropertiesmobilephone = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> propertiespropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> propertiespropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumUniqueConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumemployees = null, [WorkflowExpression] Func<string> propertiespropertiesphone = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> propertiespropertiesrelationshipStatus = null, [WorkflowExpression] Func<string> propertiespropertiessalutation = null, [WorkflowExpression] Func<string> propertiespropertiesschool = null, [WorkflowExpression] Func<string> propertiespropertiesseniority = null, [WorkflowExpression] Func<string> propertiespropertiesstartDate = null, [WorkflowExpression] Func<string> propertiespropertiesstate = null, [WorkflowExpression] Func<string> propertiespropertiestotalRevenue = null, [WorkflowExpression] Func<string> propertiespropertiestwitterhandle = null, [WorkflowExpression] Func<string> propertiespropertieswebsite = null, [WorkflowExpression] Func<string> propertiespropertiesworkEmail = null, [WorkflowExpression] Func<string> propertiespropertieszip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsUpdate(WorkflowExpression<string> contactId, WorkflowExpression<string> propertiespropertiesaddress = null, WorkflowExpression<string> propertiespropertiesannualrevenue = null, WorkflowExpression<string> propertiespropertiescity = null, WorkflowExpression<string> propertiespropertiesclosedate = null, WorkflowExpression<string> propertiespropertiescompany = null, WorkflowExpression<string> propertiespropertiescompanySize = null, WorkflowExpression<string> propertiespropertiescountry = null, WorkflowExpression<string> propertiespropertiescreatedate = null, WorkflowExpression<string> propertiespropertiescurrentlyinworkflow = null, WorkflowExpression<string> propertiespropertiesdateOfBirth = null, WorkflowExpression<string> propertiespropertiesdaysToClose = null, WorkflowExpression<string> propertiespropertiesdegree = null, WorkflowExpression<string> propertiespropertiesemail = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> propertiespropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> propertiespropertiesfax = null, WorkflowExpression<string> propertiespropertiesfieldOfStudy = null, WorkflowExpression<string> propertiespropertiesfirstConversionDate = null, WorkflowExpression<string> propertiespropertiesfirstConversionEventName = null, WorkflowExpression<string> propertiespropertiesfirstDealCreatedDate = null, WorkflowExpression<string> propertiespropertiesfirstname = null, WorkflowExpression<string> propertiespropertiesgender = null, WorkflowExpression<string> propertiespropertiesgraduationDate = null, WorkflowExpression<string> propertiespropertieshsAnalyticsAveragePageViews = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstReferrer = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstUrl = null, WorkflowExpression<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastReferrer = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastUrl = null, WorkflowExpression<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, WorkflowExpression<string> propertiespropertieshsAnalyticsNumEventCompletions = null, WorkflowExpression<string> propertiespropertieshsAnalyticsNumPageViews = null, WorkflowExpression<string> propertiespropertieshsAnalyticsNumVisits = null, WorkflowExpression<string> propertiespropertieshsAnalyticsRevenue = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSource = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> propertiespropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> propertiespropertieshsBuyingRole = null, WorkflowExpression<string> propertiespropertieshsContentMembershipEmailConfirmed = null, WorkflowExpression<string> propertiespropertieshsContentMembershipNotes = null, WorkflowExpression<string> propertiespropertieshsContentMembershipRegisteredAt = null, WorkflowExpression<string> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, WorkflowExpression<string> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, WorkflowExpression<string> propertiespropertieshsContentMembershipStatus = null, WorkflowExpression<string> propertiespropertieshsCreatedate = null, WorkflowExpression<string> propertiespropertieshsEmailBadAddress = null, WorkflowExpression<string> propertiespropertieshsEmailBounce = null, WorkflowExpression<string> propertiespropertieshsEmailClick = null, WorkflowExpression<string> propertiespropertieshsEmailCustomerQuarantinedReason = null, WorkflowExpression<string> propertiespropertieshsEmailDelivered = null, WorkflowExpression<string> propertiespropertieshsEmailDomain = null, WorkflowExpression<string> propertiespropertieshsEmailFirstClickDate = null, WorkflowExpression<string> propertiespropertieshsEmailFirstOpenDate = null, WorkflowExpression<string> propertiespropertieshsEmailFirstReplyDate = null, WorkflowExpression<string> propertiespropertieshsEmailFirstSendDate = null, WorkflowExpression<string> propertiespropertieshsEmailHardBounceReasonEnum = null, WorkflowExpression<string> propertiespropertieshsEmailLastClickDate = null, WorkflowExpression<string> propertiespropertieshsEmailLastEmailName = null, WorkflowExpression<string> propertiespropertieshsEmailLastOpenDate = null, WorkflowExpression<string> propertiespropertieshsEmailLastReplyDate = null, WorkflowExpression<string> propertiespropertieshsEmailLastSendDate = null, WorkflowExpression<string> propertiespropertieshsEmailOpen = null, WorkflowExpression<string> propertiespropertieshsEmailOptout = null, WorkflowExpression<string> propertiespropertieshsEmailOptout12592317 = null, WorkflowExpression<string> propertiespropertieshsEmailQuarantined = null, WorkflowExpression<string> propertiespropertieshsEmailQuarantinedReason = null, WorkflowExpression<string> propertiespropertieshsEmailReplied = null, WorkflowExpression<string> propertiespropertieshsEmailSendsSinceLastEngagement = null, WorkflowExpression<string> propertiespropertieshsEmailconfirmationstatus = null, WorkflowExpression<string> propertiespropertieshsFacebookClickId = null, WorkflowExpression<string> propertiespropertieshsFeedbackLastNpsFollowUp = null, WorkflowExpression<string> propertiespropertieshsFeedbackLastNpsRating = null, WorkflowExpression<string> propertiespropertieshsFeedbackLastSurveyDate = null, WorkflowExpression<string> propertiespropertieshsGoogleClickId = null, WorkflowExpression<string> propertiespropertieshsIpTimezone = null, WorkflowExpression<string> propertiespropertieshsIsUnworked = null, WorkflowExpression<string> propertiespropertieshsLanguage = null, WorkflowExpression<string> propertiespropertieshsLastSalesActivityTimestamp = null, WorkflowExpression<string> propertiespropertieshsLeadStatus = null, WorkflowExpression<string> propertiespropertieshsLegalBasis = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageCustomerDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageEvangelistDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageLeadDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageOpportunityDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageOtherDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, WorkflowExpression<string> propertiespropertieshsLifecyclestageSubscriberDate = null, WorkflowExpression<string> propertiespropertieshsMarketableReasonId = null, WorkflowExpression<string> propertiespropertieshsMarketableReasonType = null, WorkflowExpression<string> propertiespropertieshsMarketableStatus = null, WorkflowExpression<string> propertiespropertieshsMarketableUntilRenewal = null, WorkflowExpression<string> propertiespropertieshsObjectId = null, WorkflowExpression<string> propertiespropertieshsPersona = null, WorkflowExpression<string> propertiespropertieshsPredictivecontactscore = null, WorkflowExpression<string> propertiespropertieshsPredictivecontactscoreV2 = null, WorkflowExpression<string> propertiespropertieshsPredictivecontactscorebucket = null, WorkflowExpression<string> propertiespropertieshsPredictivescoringtier = null, WorkflowExpression<string> propertiespropertieshsSalesEmailLastClicked = null, WorkflowExpression<string> propertiespropertieshsSalesEmailLastOpened = null, WorkflowExpression<string> propertiespropertieshsSalesEmailLastReplied = null, WorkflowExpression<string> propertiespropertieshsSequencesIsEnrolled = null, WorkflowExpression<string> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, WorkflowExpression<string> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, WorkflowExpression<string> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, WorkflowExpression<string> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, WorkflowExpression<string> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, WorkflowExpression<string> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, WorkflowExpression<string> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, WorkflowExpression<string> propertiespropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> propertiespropertieshubspotOwnerId = null, WorkflowExpression<string> propertiespropertieshubspotTeamId = null, WorkflowExpression<string> propertiespropertieshubspotscore = null, WorkflowExpression<string> propertiespropertiesindustry = null, WorkflowExpression<string> propertiespropertiesipCity = null, WorkflowExpression<string> propertiespropertiesipCountry = null, WorkflowExpression<string> propertiespropertiesipCountryCode = null, WorkflowExpression<string> propertiespropertiesipState = null, WorkflowExpression<string> propertiespropertiesipStateCode = null, WorkflowExpression<string> propertiespropertiesjobFunction = null, WorkflowExpression<string> propertiespropertiesjobtitle = null, WorkflowExpression<string> propertiespropertieslastmodifieddate = null, WorkflowExpression<string> propertiespropertieslastname = null, WorkflowExpression<string> propertiespropertieslifecyclestage = null, WorkflowExpression<string> propertiespropertiesmaritalStatus = null, WorkflowExpression<string> propertiespropertiesmessage = null, WorkflowExpression<string> propertiespropertiesmilitaryStatus = null, WorkflowExpression<string> propertiespropertiesmobilephone = null, WorkflowExpression<string> propertiespropertiesnotesLastContacted = null, WorkflowExpression<string> propertiespropertiesnotesLastUpdated = null, WorkflowExpression<string> propertiespropertiesnotesNextActivityDate = null, WorkflowExpression<string> propertiespropertiesnumAssociatedDeals = null, WorkflowExpression<string> propertiespropertiesnumContactedNotes = null, WorkflowExpression<string> propertiespropertiesnumConversionEvents = null, WorkflowExpression<string> propertiespropertiesnumNotes = null, WorkflowExpression<string> propertiespropertiesnumUniqueConversionEvents = null, WorkflowExpression<string> propertiespropertiesnumemployees = null, WorkflowExpression<string> propertiespropertiesphone = null, WorkflowExpression<string> propertiespropertiesrecentConversionDate = null, WorkflowExpression<string> propertiespropertiesrecentConversionEventName = null, WorkflowExpression<string> propertiespropertiesrecentDealAmount = null, WorkflowExpression<string> propertiespropertiesrecentDealCloseDate = null, WorkflowExpression<string> propertiespropertiesrelationshipStatus = null, WorkflowExpression<string> propertiespropertiessalutation = null, WorkflowExpression<string> propertiespropertiesschool = null, WorkflowExpression<string> propertiespropertiesseniority = null, WorkflowExpression<string> propertiespropertiesstartDate = null, WorkflowExpression<string> propertiespropertiesstate = null, WorkflowExpression<string> propertiespropertiestotalRevenue = null, WorkflowExpression<string> propertiespropertiestwitterhandle = null, WorkflowExpression<string> propertiespropertieswebsite = null, WorkflowExpression<string> propertiespropertiesworkEmail = null, WorkflowExpression<string> propertiespropertieszip = null)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            WorkflowExpression.Validate(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            WorkflowExpression.Validate(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            WorkflowExpression.Validate(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            WorkflowExpression.Validate(propertiespropertiescompany, nameof(propertiespropertiescompany), required: false);
            WorkflowExpression.Validate(propertiespropertiescompanySize, nameof(propertiespropertiescompanySize), required: false);
            WorkflowExpression.Validate(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            WorkflowExpression.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertiescurrentlyinworkflow, nameof(propertiespropertiescurrentlyinworkflow), required: false);
            WorkflowExpression.Validate(propertiespropertiesdateOfBirth, nameof(propertiespropertiesdateOfBirth), required: false);
            WorkflowExpression.Validate(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            WorkflowExpression.Validate(propertiespropertiesdegree, nameof(propertiespropertiesdegree), required: false);
            WorkflowExpression.Validate(propertiespropertiesemail, nameof(propertiespropertiesemail), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(propertiespropertiesfax, nameof(propertiespropertiesfax), required: false);
            WorkflowExpression.Validate(propertiespropertiesfieldOfStudy, nameof(propertiespropertiesfieldOfStudy), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesfirstname, nameof(propertiespropertiesfirstname), required: false);
            WorkflowExpression.Validate(propertiespropertiesgender, nameof(propertiespropertiesgender), required: false);
            WorkflowExpression.Validate(propertiespropertiesgraduationDate, nameof(propertiespropertiesgraduationDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsAveragePageViews, nameof(propertiespropertieshsAnalyticsAveragePageViews), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstReferrer, nameof(propertiespropertieshsAnalyticsFirstReferrer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstUrl, nameof(propertiespropertieshsAnalyticsFirstUrl), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastReferrer, nameof(propertiespropertieshsAnalyticsLastReferrer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastUrl, nameof(propertiespropertieshsAnalyticsLastUrl), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsNumEventCompletions, nameof(propertiespropertieshsAnalyticsNumEventCompletions), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsRevenue, nameof(propertiespropertieshsAnalyticsRevenue), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(propertiespropertieshsBuyingRole, nameof(propertiespropertieshsBuyingRole), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipEmailConfirmed, nameof(propertiespropertieshsContentMembershipEmailConfirmed), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipNotes, nameof(propertiespropertieshsContentMembershipNotes), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipRegisteredAt, nameof(propertiespropertieshsContentMembershipRegisteredAt), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipRegistrationDomainSentTo, nameof(propertiespropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipRegistrationEmailSentAt, nameof(propertiespropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            WorkflowExpression.Validate(propertiespropertieshsContentMembershipStatus, nameof(propertiespropertieshsContentMembershipStatus), required: false);
            WorkflowExpression.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailBadAddress, nameof(propertiespropertieshsEmailBadAddress), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailBounce, nameof(propertiespropertieshsEmailBounce), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailClick, nameof(propertiespropertieshsEmailClick), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailCustomerQuarantinedReason, nameof(propertiespropertieshsEmailCustomerQuarantinedReason), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailDelivered, nameof(propertiespropertieshsEmailDelivered), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailDomain, nameof(propertiespropertieshsEmailDomain), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailFirstClickDate, nameof(propertiespropertieshsEmailFirstClickDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailFirstOpenDate, nameof(propertiespropertieshsEmailFirstOpenDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailFirstReplyDate, nameof(propertiespropertieshsEmailFirstReplyDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailFirstSendDate, nameof(propertiespropertieshsEmailFirstSendDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailHardBounceReasonEnum, nameof(propertiespropertieshsEmailHardBounceReasonEnum), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailLastClickDate, nameof(propertiespropertieshsEmailLastClickDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailLastEmailName, nameof(propertiespropertieshsEmailLastEmailName), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailLastOpenDate, nameof(propertiespropertieshsEmailLastOpenDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailLastReplyDate, nameof(propertiespropertieshsEmailLastReplyDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailLastSendDate, nameof(propertiespropertieshsEmailLastSendDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailOpen, nameof(propertiespropertieshsEmailOpen), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailOptout, nameof(propertiespropertieshsEmailOptout), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailOptout12592317, nameof(propertiespropertieshsEmailOptout12592317), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailQuarantined, nameof(propertiespropertieshsEmailQuarantined), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailQuarantinedReason, nameof(propertiespropertieshsEmailQuarantinedReason), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailReplied, nameof(propertiespropertieshsEmailReplied), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailSendsSinceLastEngagement, nameof(propertiespropertieshsEmailSendsSinceLastEngagement), required: false);
            WorkflowExpression.Validate(propertiespropertieshsEmailconfirmationstatus, nameof(propertiespropertieshsEmailconfirmationstatus), required: false);
            WorkflowExpression.Validate(propertiespropertieshsFacebookClickId, nameof(propertiespropertieshsFacebookClickId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsFeedbackLastNpsFollowUp, nameof(propertiespropertieshsFeedbackLastNpsFollowUp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsFeedbackLastNpsRating, nameof(propertiespropertieshsFeedbackLastNpsRating), required: false);
            WorkflowExpression.Validate(propertiespropertieshsFeedbackLastSurveyDate, nameof(propertiespropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsGoogleClickId, nameof(propertiespropertieshsGoogleClickId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsIpTimezone, nameof(propertiespropertieshsIpTimezone), required: false);
            WorkflowExpression.Validate(propertiespropertieshsIsUnworked, nameof(propertiespropertieshsIsUnworked), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLanguage, nameof(propertiespropertieshsLanguage), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLegalBasis, nameof(propertiespropertieshsLegalBasis), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageCustomerDate, nameof(propertiespropertieshsLifecyclestageCustomerDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageEvangelistDate, nameof(propertiespropertieshsLifecyclestageEvangelistDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageLeadDate, nameof(propertiespropertieshsLifecyclestageLeadDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageOpportunityDate, nameof(propertiespropertieshsLifecyclestageOpportunityDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageOtherDate, nameof(propertiespropertieshsLifecyclestageOtherDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageSalesqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLifecyclestageSubscriberDate, nameof(propertiespropertieshsLifecyclestageSubscriberDate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsMarketableReasonId, nameof(propertiespropertieshsMarketableReasonId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsMarketableReasonType, nameof(propertiespropertieshsMarketableReasonType), required: false);
            WorkflowExpression.Validate(propertiespropertieshsMarketableStatus, nameof(propertiespropertieshsMarketableStatus), required: false);
            WorkflowExpression.Validate(propertiespropertieshsMarketableUntilRenewal, nameof(propertiespropertieshsMarketableUntilRenewal), required: false);
            WorkflowExpression.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPersona, nameof(propertiespropertieshsPersona), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPredictivecontactscore, nameof(propertiespropertieshsPredictivecontactscore), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPredictivecontactscorebucket, nameof(propertiespropertieshsPredictivecontactscorebucket), required: false);
            WorkflowExpression.Validate(propertiespropertieshsPredictivescoringtier, nameof(propertiespropertieshsPredictivescoringtier), required: false);
            WorkflowExpression.Validate(propertiespropertieshsSalesEmailLastClicked, nameof(propertiespropertieshsSalesEmailLastClicked), required: false);
            WorkflowExpression.Validate(propertiespropertieshsSalesEmailLastOpened, nameof(propertiespropertieshsSalesEmailLastOpened), required: false);
            WorkflowExpression.Validate(propertiespropertieshsSalesEmailLastReplied, nameof(propertiespropertieshsSalesEmailLastReplied), required: false);
            WorkflowExpression.Validate(propertiespropertieshsSequencesIsEnrolled, nameof(propertiespropertieshsSequencesIsEnrolled), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeBetweenContactCreationAndDealClose, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeBetweenContactCreationAndDealCreation, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeToMoveFromLeadToCustomer, nameof(propertiespropertieshsTimeToMoveFromLeadToCustomer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeToMoveFromOpportunityToCustomer, nameof(propertiespropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            WorkflowExpression.Validate(propertiespropertieshsTimeToMoveFromSubscriberToCustomer, nameof(propertiespropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(propertiespropertieshubspotscore, nameof(propertiespropertieshubspotscore), required: false);
            WorkflowExpression.Validate(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            WorkflowExpression.Validate(propertiespropertiesipCity, nameof(propertiespropertiesipCity), required: false);
            WorkflowExpression.Validate(propertiespropertiesipCountry, nameof(propertiespropertiesipCountry), required: false);
            WorkflowExpression.Validate(propertiespropertiesipCountryCode, nameof(propertiespropertiesipCountryCode), required: false);
            WorkflowExpression.Validate(propertiespropertiesipState, nameof(propertiespropertiesipState), required: false);
            WorkflowExpression.Validate(propertiespropertiesipStateCode, nameof(propertiespropertiesipStateCode), required: false);
            WorkflowExpression.Validate(propertiespropertiesjobFunction, nameof(propertiespropertiesjobFunction), required: false);
            WorkflowExpression.Validate(propertiespropertiesjobtitle, nameof(propertiespropertiesjobtitle), required: false);
            WorkflowExpression.Validate(propertiespropertieslastmodifieddate, nameof(propertiespropertieslastmodifieddate), required: false);
            WorkflowExpression.Validate(propertiespropertieslastname, nameof(propertiespropertieslastname), required: false);
            WorkflowExpression.Validate(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            WorkflowExpression.Validate(propertiespropertiesmaritalStatus, nameof(propertiespropertiesmaritalStatus), required: false);
            WorkflowExpression.Validate(propertiespropertiesmessage, nameof(propertiespropertiesmessage), required: false);
            WorkflowExpression.Validate(propertiespropertiesmilitaryStatus, nameof(propertiespropertiesmilitaryStatus), required: false);
            WorkflowExpression.Validate(propertiespropertiesmobilephone, nameof(propertiespropertiesmobilephone), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumNotes, nameof(propertiespropertiesnumNotes), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumUniqueConversionEvents, nameof(propertiespropertiesnumUniqueConversionEvents), required: false);
            WorkflowExpression.Validate(propertiespropertiesnumemployees, nameof(propertiespropertiesnumemployees), required: false);
            WorkflowExpression.Validate(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesrelationshipStatus, nameof(propertiespropertiesrelationshipStatus), required: false);
            WorkflowExpression.Validate(propertiespropertiessalutation, nameof(propertiespropertiessalutation), required: false);
            WorkflowExpression.Validate(propertiespropertiesschool, nameof(propertiespropertiesschool), required: false);
            WorkflowExpression.Validate(propertiespropertiesseniority, nameof(propertiespropertiesseniority), required: false);
            WorkflowExpression.Validate(propertiespropertiesstartDate, nameof(propertiespropertiesstartDate), required: false);
            WorkflowExpression.Validate(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            WorkflowExpression.Validate(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            WorkflowExpression.Validate(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            WorkflowExpression.Validate(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            WorkflowExpression.Validate(propertiespropertiesworkEmail, nameof(propertiespropertiesworkEmail), required: false);
            WorkflowExpression.Validate(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = ExpressionConverter.ConvertO(propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = ExpressionConverter.ConvertO(propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescity != null)
                {
                    propertiesObject["city"] = ExpressionConverter.ConvertO(propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescompany != null)
                {
                    propertiesObject["company"] = ExpressionConverter.ConvertO(propertiespropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = ExpressionConverter.ConvertO(propertiespropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = ExpressionConverter.ConvertO(propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = ExpressionConverter.ConvertO(propertiespropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = ExpressionConverter.ConvertO(propertiespropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = ExpressionConverter.ConvertO(propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdegree != null)
                {
                    propertiesObject["degree"] = ExpressionConverter.ConvertO(propertiespropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesemail != null)
                {
                    propertiesObject["email"] = ExpressionConverter.ConvertO(propertiespropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfax != null)
                {
                    propertiesObject["fax"] = ExpressionConverter.ConvertO(propertiespropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = ExpressionConverter.ConvertO(propertiespropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = ExpressionConverter.ConvertO(propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = ExpressionConverter.ConvertO(propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = ExpressionConverter.ConvertO(propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = ExpressionConverter.ConvertO(propertiespropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgender != null)
                {
                    propertiesObject["gender"] = ExpressionConverter.ConvertO(propertiespropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = ExpressionConverter.ConvertO(propertiespropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = ExpressionConverter.ConvertO(propertiespropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = ExpressionConverter.ConvertO(propertiespropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = ExpressionConverter.ConvertO(propertiespropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = ExpressionConverter.ConvertO(propertiespropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = ExpressionConverter.ConvertO(propertiespropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = ExpressionConverter.ConvertO(propertiespropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(propertiespropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = ExpressionConverter.ConvertO(propertiespropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = ExpressionConverter.ConvertO(propertiespropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = ExpressionConverter.ConvertO(propertiespropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = ExpressionConverter.ConvertO(propertiespropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = ExpressionConverter.ConvertO(propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = ExpressionConverter.ConvertO(propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = ExpressionConverter.ConvertO(propertiespropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = ExpressionConverter.ConvertO(propertiespropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = ExpressionConverter.ConvertO(propertiespropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = ExpressionConverter.ConvertO(propertiespropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = ExpressionConverter.ConvertO(propertiespropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = ExpressionConverter.ConvertO(propertiespropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = ExpressionConverter.ConvertO(propertiespropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = ExpressionConverter.ConvertO(propertiespropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = ExpressionConverter.ConvertO(propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = ExpressionConverter.ConvertO(propertiespropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = ExpressionConverter.ConvertO(propertiespropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = ExpressionConverter.ConvertO(propertiespropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = ExpressionConverter.ConvertO(propertiespropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = ExpressionConverter.ConvertO(propertiespropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = ExpressionConverter.ConvertO(propertiespropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = ExpressionConverter.ConvertO(propertiespropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = ExpressionConverter.ConvertO(propertiespropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = ExpressionConverter.ConvertO(propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = ExpressionConverter.ConvertO(propertiespropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = ExpressionConverter.ConvertO(propertiespropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = ExpressionConverter.ConvertO(propertiespropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipState != null)
                {
                    propertiesObject["ip_state"] = ExpressionConverter.ConvertO(propertiespropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = ExpressionConverter.ConvertO(propertiespropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = ExpressionConverter.ConvertO(propertiespropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = ExpressionConverter.ConvertO(propertiespropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = ExpressionConverter.ConvertO(propertiespropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslastname != null)
                {
                    propertiesObject["lastname"] = ExpressionConverter.ConvertO(propertiespropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = ExpressionConverter.ConvertO(propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = ExpressionConverter.ConvertO(propertiespropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmessage != null)
                {
                    propertiesObject["message"] = ExpressionConverter.ConvertO(propertiespropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = ExpressionConverter.ConvertO(propertiespropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = ExpressionConverter.ConvertO(propertiespropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = ExpressionConverter.ConvertO(propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = ExpressionConverter.ConvertO(propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(propertiespropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = ExpressionConverter.ConvertO(propertiespropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = ExpressionConverter.ConvertO(propertiespropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = ExpressionConverter.ConvertO(propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = ExpressionConverter.ConvertO(propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = ExpressionConverter.ConvertO(propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = ExpressionConverter.ConvertO(propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = ExpressionConverter.ConvertO(propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = ExpressionConverter.ConvertO(propertiespropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiessalutation != null)
                {
                    propertiesObject["salutation"] = ExpressionConverter.ConvertO(propertiespropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesschool != null)
                {
                    propertiesObject["school"] = ExpressionConverter.ConvertO(propertiespropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesseniority != null)
                {
                    propertiesObject["seniority"] = ExpressionConverter.ConvertO(propertiespropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = ExpressionConverter.ConvertO(propertiespropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = ExpressionConverter.ConvertO(propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = ExpressionConverter.ConvertO(propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = ExpressionConverter.ConvertO(propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = ExpressionConverter.ConvertO(propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = ExpressionConverter.ConvertO(propertiespropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = ExpressionConverter.ConvertO(propertiespropertieszip);
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
        [WorkflowExpressionFactory(nameof(__BuildDealsList))]
        public IWorkflowAction DealsList([WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsList(WorkflowExpression<string> properties = null, WorkflowExpression<int> limit = null, WorkflowExpression<string> after = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(after, nameof(after), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(after);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildDealsCreate))]
        public IWorkflowAction DealsCreate([WorkflowExpression] Func<string> bodypropertiesamount = null, [WorkflowExpression] Func<string> bodypropertiesamountInHomeCurrency = null, [WorkflowExpression] Func<string> bodypropertiesclosedLostReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedWonReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdealname = null, [WorkflowExpression] Func<string> bodypropertiesdealstage = null, [WorkflowExpression] Func<string> bodypropertiesdealtype = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertieshsAcv = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsArr = null, [WorkflowExpression] Func<string> bodypropertieshsForecastAmount = null, [WorkflowExpression] Func<string> bodypropertieshsForecastProbability = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsManualForecastCategory = null, [WorkflowExpression] Func<string> bodypropertieshsMrr = null, [WorkflowExpression] Func<string> bodypropertieshsNextStep = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPriority = null, [WorkflowExpression] Func<string> bodypropertieshsTcv = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiespipeline = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsCreate(WorkflowExpression<string> bodypropertiesamount = null, WorkflowExpression<string> bodypropertiesamountInHomeCurrency = null, WorkflowExpression<string> bodypropertiesclosedLostReason = null, WorkflowExpression<string> bodypropertiesclosedWonReason = null, WorkflowExpression<string> bodypropertiesclosedate = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesdealname = null, WorkflowExpression<string> bodypropertiesdealstage = null, WorkflowExpression<string> bodypropertiesdealtype = null, WorkflowExpression<string> bodypropertiesdescription = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> bodypropertieshsAcv = null, WorkflowExpression<string> bodypropertieshsAnalyticsSource = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> bodypropertieshsArr = null, WorkflowExpression<string> bodypropertieshsForecastAmount = null, WorkflowExpression<string> bodypropertieshsForecastProbability = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsManualForecastCategory = null, WorkflowExpression<string> bodypropertieshsMrr = null, WorkflowExpression<string> bodypropertieshsNextStep = null, WorkflowExpression<string> bodypropertieshsObjectId = null, WorkflowExpression<string> bodypropertieshsPriority = null, WorkflowExpression<string> bodypropertieshsTcv = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertiesnotesLastContacted = null, WorkflowExpression<string> bodypropertiesnotesLastUpdated = null, WorkflowExpression<string> bodypropertiesnotesNextActivityDate = null, WorkflowExpression<string> bodypropertiesnumAssociatedContacts = null, WorkflowExpression<string> bodypropertiesnumContactedNotes = null, WorkflowExpression<string> bodypropertiesnumNotes = null, WorkflowExpression<string> bodypropertiespipeline = null)
        {
            WorkflowExpression.Validate(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            WorkflowExpression.Validate(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            WorkflowExpression.Validate(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            WorkflowExpression.Validate(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            WorkflowExpression.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            WorkflowExpression.Validate(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            WorkflowExpression.Validate(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            WorkflowExpression.Validate(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            WorkflowExpression.Validate(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            WorkflowExpression.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowExpression.Validate(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            WorkflowExpression.Validate(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowExpression.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowExpression.Validate(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesamount != null)
                {
                    propertiesObject["amount"] = ExpressionConverter.ConvertO(bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = ExpressionConverter.ConvertO(bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = ExpressionConverter.ConvertO(bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = ExpressionConverter.ConvertO(bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = ExpressionConverter.ConvertO(bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = ExpressionConverter.ConvertO(bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = ExpressionConverter.ConvertO(bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = ExpressionConverter.ConvertO(bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = ExpressionConverter.ConvertO(bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = ExpressionConverter.ConvertO(bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = ExpressionConverter.ConvertO(bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = ExpressionConverter.ConvertO(bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = ExpressionConverter.ConvertO(bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = ExpressionConverter.ConvertO(bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = ExpressionConverter.ConvertO(bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = ExpressionConverter.ConvertO(bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = ExpressionConverter.ConvertO(bodypropertiespipeline);
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
        [WorkflowExpressionFactory(nameof(__BuildDealsRead))]
        public IWorkflowAction DealsRead([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsRead(WorkflowExpression<string> dealId, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildDealsArchive))]
        public IWorkflowAction DealsArchive([WorkflowExpression] Func<string> dealId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsArchive(WorkflowExpression<string> dealId)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildDealsUpdate))]
        public IWorkflowAction DealsUpdate([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> bodypropertiesamount = null, [WorkflowExpression] Func<string> bodypropertiesamountInHomeCurrency = null, [WorkflowExpression] Func<string> bodypropertiesclosedLostReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedWonReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdealname = null, [WorkflowExpression] Func<string> bodypropertiesdealstage = null, [WorkflowExpression] Func<string> bodypropertiesdealtype = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertieshsAcv = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsArr = null, [WorkflowExpression] Func<string> bodypropertieshsForecastAmount = null, [WorkflowExpression] Func<string> bodypropertieshsForecastProbability = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsManualForecastCategory = null, [WorkflowExpression] Func<string> bodypropertieshsMrr = null, [WorkflowExpression] Func<string> bodypropertieshsNextStep = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPriority = null, [WorkflowExpression] Func<string> bodypropertieshsTcv = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiespipeline = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsUpdate(WorkflowExpression<string> dealId, WorkflowExpression<string> bodypropertiesamount = null, WorkflowExpression<string> bodypropertiesamountInHomeCurrency = null, WorkflowExpression<string> bodypropertiesclosedLostReason = null, WorkflowExpression<string> bodypropertiesclosedWonReason = null, WorkflowExpression<string> bodypropertiesclosedate = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesdealname = null, WorkflowExpression<string> bodypropertiesdealstage = null, WorkflowExpression<string> bodypropertiesdealtype = null, WorkflowExpression<string> bodypropertiesdescription = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowExpression<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowExpression<string> bodypropertieshsAcv = null, WorkflowExpression<string> bodypropertieshsAnalyticsSource = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowExpression<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowExpression<string> bodypropertieshsArr = null, WorkflowExpression<string> bodypropertieshsForecastAmount = null, WorkflowExpression<string> bodypropertieshsForecastProbability = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsManualForecastCategory = null, WorkflowExpression<string> bodypropertieshsMrr = null, WorkflowExpression<string> bodypropertieshsNextStep = null, WorkflowExpression<string> bodypropertieshsObjectId = null, WorkflowExpression<string> bodypropertieshsPriority = null, WorkflowExpression<string> bodypropertieshsTcv = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertiesnotesLastContacted = null, WorkflowExpression<string> bodypropertiesnotesLastUpdated = null, WorkflowExpression<string> bodypropertiesnotesNextActivityDate = null, WorkflowExpression<string> bodypropertiesnumAssociatedContacts = null, WorkflowExpression<string> bodypropertiesnumContactedNotes = null, WorkflowExpression<string> bodypropertiesnumNotes = null, WorkflowExpression<string> bodypropertiespipeline = null)
        {
            WorkflowExpression.Validate(dealId, nameof(dealId), required: true);
            WorkflowExpression.Validate(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            WorkflowExpression.Validate(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            WorkflowExpression.Validate(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            WorkflowExpression.Validate(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            WorkflowExpression.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowExpression.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowExpression.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowExpression.Validate(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            WorkflowExpression.Validate(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            WorkflowExpression.Validate(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            WorkflowExpression.Validate(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            WorkflowExpression.Validate(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            WorkflowExpression.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowExpression.Validate(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            WorkflowExpression.Validate(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowExpression.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowExpression.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowExpression.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowExpression.Validate(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesamount != null)
                {
                    propertiesObject["amount"] = ExpressionConverter.ConvertO(bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = ExpressionConverter.ConvertO(bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = ExpressionConverter.ConvertO(bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = ExpressionConverter.ConvertO(bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = ExpressionConverter.ConvertO(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = ExpressionConverter.ConvertO(bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = ExpressionConverter.ConvertO(bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = ExpressionConverter.ConvertO(bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = ExpressionConverter.ConvertO(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = ExpressionConverter.ConvertO(bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = ExpressionConverter.ConvertO(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = ExpressionConverter.ConvertO(bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = ExpressionConverter.ConvertO(bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = ExpressionConverter.ConvertO(bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = ExpressionConverter.ConvertO(bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = ExpressionConverter.ConvertO(bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = ExpressionConverter.ConvertO(bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = ExpressionConverter.ConvertO(bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = ExpressionConverter.ConvertO(bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = ExpressionConverter.ConvertO(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = ExpressionConverter.ConvertO(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = ExpressionConverter.ConvertO(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = ExpressionConverter.ConvertO(bodypropertiespipeline);
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
        [WorkflowExpressionFactory(nameof(__BuildProductsList))]
        public IWorkflowAction ProductsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsList(WorkflowExpression<int> limit = null, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildProductsCreate))]
        public IWorkflowAction ProductsCreate([WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertieshsCostOfGoodsSold = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedByUserId = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsImages = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> bodypropertieshsSku = null, [WorkflowExpression] Func<string> bodypropertieshsUpdatedByUserId = null, [WorkflowExpression] Func<string> bodypropertieshsUrl = null, [WorkflowExpression] Func<string> bodypropertiesname = null, [WorkflowExpression] Func<string> bodypropertiesprice = null, [WorkflowExpression] Func<string> bodypropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> bodypropertiestax = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsCreate(WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesdescription = null, WorkflowExpression<string> bodypropertieshsCostOfGoodsSold = null, WorkflowExpression<string> bodypropertieshsCreatedByUserId = null, WorkflowExpression<string> bodypropertieshsCreatedate = null, WorkflowExpression<string> bodypropertieshsImages = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsObjectId = null, WorkflowExpression<string> bodypropertieshsRecurringBillingPeriod = null, WorkflowExpression<string> bodypropertieshsSku = null, WorkflowExpression<string> bodypropertieshsUpdatedByUserId = null, WorkflowExpression<string> bodypropertieshsUrl = null, WorkflowExpression<string> bodypropertiesname = null, WorkflowExpression<string> bodypropertiesprice = null, WorkflowExpression<string> bodypropertiesrecurringbillingfrequency = null, WorkflowExpression<string> bodypropertiestax = null)
        {
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowExpression.Validate(bodypropertieshsCostOfGoodsSold, nameof(bodypropertieshsCostOfGoodsSold), required: false);
            WorkflowExpression.Validate(bodypropertieshsCreatedByUserId, nameof(bodypropertieshsCreatedByUserId), required: false);
            WorkflowExpression.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(bodypropertieshsImages, nameof(bodypropertieshsImages), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowExpression.Validate(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            WorkflowExpression.Validate(bodypropertieshsSku, nameof(bodypropertieshsSku), required: false);
            WorkflowExpression.Validate(bodypropertieshsUpdatedByUserId, nameof(bodypropertieshsUpdatedByUserId), required: false);
            WorkflowExpression.Validate(bodypropertieshsUrl, nameof(bodypropertieshsUrl), required: false);
            WorkflowExpression.Validate(bodypropertiesname, nameof(bodypropertiesname), required: false);
            WorkflowExpression.Validate(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            WorkflowExpression.Validate(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            WorkflowExpression.Validate(bodypropertiestax, nameof(bodypropertiestax), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = ExpressionConverter.ConvertO(bodypropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = ExpressionConverter.ConvertO(bodypropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = ExpressionConverter.ConvertO(bodypropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = ExpressionConverter.ConvertO(bodypropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = ExpressionConverter.ConvertO(bodypropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = ExpressionConverter.ConvertO(bodypropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(bodypropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestax != null)
                {
                    propertiesObject["tax"] = ExpressionConverter.ConvertO(bodypropertiestax);
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
        [WorkflowExpressionFactory(nameof(__BuildProductsRead))]
        public IWorkflowAction ProductsRead([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsRead(WorkflowExpression<string> productId, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildProductsArchive))]
        public IWorkflowAction ProductsArchive([WorkflowExpression] Func<string> productId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsArchive(WorkflowExpression<string> productId)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildProductsUpdate))]
        public IWorkflowAction ProductsUpdate([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesdescription = null, [WorkflowExpression] Func<string> propertiespropertieshsCostOfGoodsSold = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedByUserId = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsImages = null, [WorkflowExpression] Func<string> propertiespropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> propertiespropertieshsSku = null, [WorkflowExpression] Func<string> propertiespropertieshsUpdatedByUserId = null, [WorkflowExpression] Func<string> propertiespropertieshsUrl = null, [WorkflowExpression] Func<string> propertiespropertiesname = null, [WorkflowExpression] Func<string> propertiespropertiesprice = null, [WorkflowExpression] Func<string> propertiespropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> propertiespropertiestax = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsUpdate(WorkflowExpression<string> productId, WorkflowExpression<string> propertiespropertiescreatedate = null, WorkflowExpression<string> propertiespropertiesdescription = null, WorkflowExpression<string> propertiespropertieshsCostOfGoodsSold = null, WorkflowExpression<string> propertiespropertieshsCreatedByUserId = null, WorkflowExpression<string> propertiespropertieshsCreatedate = null, WorkflowExpression<string> propertiespropertieshsImages = null, WorkflowExpression<string> propertiespropertieshsLastmodifieddate = null, WorkflowExpression<string> propertiespropertieshsObjectId = null, WorkflowExpression<string> propertiespropertieshsRecurringBillingPeriod = null, WorkflowExpression<string> propertiespropertieshsSku = null, WorkflowExpression<string> propertiespropertieshsUpdatedByUserId = null, WorkflowExpression<string> propertiespropertieshsUrl = null, WorkflowExpression<string> propertiespropertiesname = null, WorkflowExpression<string> propertiespropertiesprice = null, WorkflowExpression<string> propertiespropertiesrecurringbillingfrequency = null, WorkflowExpression<string> propertiespropertiestax = null)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            WorkflowExpression.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            WorkflowExpression.Validate(propertiespropertieshsCostOfGoodsSold, nameof(propertiespropertieshsCostOfGoodsSold), required: false);
            WorkflowExpression.Validate(propertiespropertieshsCreatedByUserId, nameof(propertiespropertieshsCreatedByUserId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsImages, nameof(propertiespropertieshsImages), required: false);
            WorkflowExpression.Validate(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            WorkflowExpression.Validate(propertiespropertieshsSku, nameof(propertiespropertieshsSku), required: false);
            WorkflowExpression.Validate(propertiespropertieshsUpdatedByUserId, nameof(propertiespropertieshsUpdatedByUserId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsUrl, nameof(propertiespropertieshsUrl), required: false);
            WorkflowExpression.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            WorkflowExpression.Validate(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            WorkflowExpression.Validate(propertiespropertiestax, nameof(propertiespropertiestax), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = ExpressionConverter.ConvertO(propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = ExpressionConverter.ConvertO(propertiespropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = ExpressionConverter.ConvertO(propertiespropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = ExpressionConverter.ConvertO(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = ExpressionConverter.ConvertO(propertiespropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = ExpressionConverter.ConvertO(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = ExpressionConverter.ConvertO(propertiespropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = ExpressionConverter.ConvertO(propertiespropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = ExpressionConverter.ConvertO(propertiespropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(propertiespropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestax != null)
                {
                    propertiesObject["tax"] = ExpressionConverter.ConvertO(propertiespropertiestax);
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
        [WorkflowExpressionFactory(nameof(__BuildLineItemsList))]
        public IWorkflowAction LineItemsList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsList(WorkflowExpression<int> limit, WorkflowExpression<string> properties = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLineItemsCreate))]
        public IWorkflowAction LineItemsCreate([WorkflowExpression] Func<string> propertiespropertiesname = null, [WorkflowExpression] Func<string> propertiespropertieshsProductId = null, [WorkflowExpression] Func<string> propertiespropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> propertiespropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> propertiespropertiesquantity = null, [WorkflowExpression] Func<string> propertiespropertiesprice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsCreate(WorkflowExpression<string> propertiespropertiesname = null, WorkflowExpression<string> propertiespropertieshsProductId = null, WorkflowExpression<string> propertiespropertieshsRecurringBillingPeriod = null, WorkflowExpression<string> propertiespropertiesrecurringbillingfrequency = null, WorkflowExpression<string> propertiespropertiesquantity = null, WorkflowExpression<string> propertiespropertiesprice = null)
        {
            WorkflowExpression.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            WorkflowExpression.Validate(propertiespropertieshsProductId, nameof(propertiespropertieshsProductId), required: false);
            WorkflowExpression.Validate(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            WorkflowExpression.Validate(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            WorkflowExpression.Validate(propertiespropertiesquantity, nameof(propertiespropertiesquantity), required: false);
            WorkflowExpression.Validate(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = ExpressionConverter.ConvertO(propertiespropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesquantity != null)
                {
                    propertiesObject["quantity"] = ExpressionConverter.ConvertO(propertiespropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(propertiespropertiesprice);
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
        [WorkflowExpressionFactory(nameof(__BuildLineItemsRead))]
        public IWorkflowAction LineItemsRead([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsRead(WorkflowExpression<string> lineItemId, WorkflowExpression<string> properties = null, WorkflowExpression<string> associations = null, WorkflowExpression<string> idProperty = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLineItemsArchive))]
        public IWorkflowAction LineItemsArchive([WorkflowExpression] Func<string> lineItemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsArchive(WorkflowExpression<string> lineItemId)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLineItemsUpdate))]
        public IWorkflowAction LineItemsUpdate([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<string> bodypropertiesname = null, [WorkflowExpression] Func<string> bodypropertieshsProductId = null, [WorkflowExpression] Func<string> bodypropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> bodypropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> bodypropertiesquantity = null, [WorkflowExpression] Func<string> bodypropertiesprice = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsUpdate(WorkflowExpression<string> lineItemId, WorkflowExpression<string> idProperty = null, WorkflowExpression<string> bodypropertiesname = null, WorkflowExpression<string> bodypropertieshsProductId = null, WorkflowExpression<string> bodypropertieshsRecurringBillingPeriod = null, WorkflowExpression<string> bodypropertiesrecurringbillingfrequency = null, WorkflowExpression<string> bodypropertiesquantity = null, WorkflowExpression<string> bodypropertiesprice = null)
        {
            WorkflowExpression.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowExpression.Validate(bodypropertiesname, nameof(bodypropertiesname), required: false);
            WorkflowExpression.Validate(bodypropertieshsProductId, nameof(bodypropertieshsProductId), required: false);
            WorkflowExpression.Validate(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            WorkflowExpression.Validate(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            WorkflowExpression.Validate(bodypropertiesquantity, nameof(bodypropertiesquantity), required: false);
            WorkflowExpression.Validate(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesname != null)
                {
                    propertiesObject["name"] = ExpressionConverter.ConvertO(bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = ExpressionConverter.ConvertO(bodypropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = ExpressionConverter.ConvertO(bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = ExpressionConverter.ConvertO(bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesquantity != null)
                {
                    propertiesObject["quantity"] = ExpressionConverter.ConvertO(bodypropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesprice != null)
                {
                    propertiesObject["price"] = ExpressionConverter.ConvertO(bodypropertiesprice);
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
        [WorkflowExpressionFactory(nameof(__BuildTicketsList))]
        public IWorkflowAction TicketsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsList(WorkflowExpression<int> limit = null, WorkflowExpression<string> properties = null, WorkflowExpression<string> associations = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(associations, nameof(associations), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = ExpressionConverter.Convert(associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTicketsCreate))]
        public IWorkflowAction TicketsCreate([WorkflowExpression] Func<string> bodypropertiesclosedDate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstAgentReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsLastcontacted = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsNextactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsNumTimesContacted = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieslastReplyDate = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiestimeToClose = null, [WorkflowExpression] Func<string> bodypropertiestimeToFirstAgentReply = null, [WorkflowExpression] Func<string> bodypropertiescontent = null, [WorkflowExpression] Func<string> bodypropertieshsFileUpload = null, [WorkflowExpression] Func<string> bodypropertieshsNumAssociatedCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsPipeline = null, [WorkflowExpression] Func<string> bodypropertieshsPipelineStage = null, [WorkflowExpression] Func<string> bodypropertieshsResolution = null, [WorkflowExpression] Func<string> bodypropertieshsTicketCategory = null, [WorkflowExpression] Func<string> bodypropertieshsTicketId = null, [WorkflowExpression] Func<string> bodypropertieshsTicketPriority = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiessourceType = null, [WorkflowExpression] Func<string> bodypropertiessubject = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsCreate(WorkflowExpression<string> bodypropertiesclosedDate = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesfirstAgentReplyDate = null, WorkflowExpression<string> bodypropertieshsFeedbackLastCesFollowUp = null, WorkflowExpression<string> bodypropertieshsFeedbackLastCesRating = null, WorkflowExpression<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowExpression<string> bodypropertieshsLastactivitydate = null, WorkflowExpression<string> bodypropertieshsLastcontacted = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsNextactivitydate = null, WorkflowExpression<string> bodypropertieshsNumTimesContacted = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieslastReplyDate = null, WorkflowExpression<string> bodypropertiesnumNotes = null, WorkflowExpression<string> bodypropertiestimeToClose = null, WorkflowExpression<string> bodypropertiestimeToFirstAgentReply = null, WorkflowExpression<string> bodypropertiescontent = null, WorkflowExpression<string> bodypropertieshsFileUpload = null, WorkflowExpression<string> bodypropertieshsNumAssociatedCompanies = null, WorkflowExpression<string> bodypropertieshsPipeline = null, WorkflowExpression<string> bodypropertieshsPipelineStage = null, WorkflowExpression<string> bodypropertieshsResolution = null, WorkflowExpression<string> bodypropertieshsTicketCategory = null, WorkflowExpression<string> bodypropertieshsTicketId = null, WorkflowExpression<string> bodypropertieshsTicketPriority = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertiessourceType = null, WorkflowExpression<string> bodypropertiessubject = null)
        {
            WorkflowExpression.Validate(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowExpression.Validate(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            WorkflowExpression.Validate(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            WorkflowExpression.Validate(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            WorkflowExpression.Validate(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            WorkflowExpression.Validate(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            WorkflowExpression.Validate(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            WorkflowExpression.Validate(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            WorkflowExpression.Validate(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesclosedDate != null)
                {
                    propertiesObject["closed_date"] = ExpressionConverter.ConvertO(bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = ExpressionConverter.ConvertO(bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = ExpressionConverter.ConvertO(bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = ExpressionConverter.ConvertO(bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = ExpressionConverter.ConvertO(bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = ExpressionConverter.ConvertO(bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = ExpressionConverter.ConvertO(bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = ExpressionConverter.ConvertO(bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescontent != null)
                {
                    propertiesObject["content"] = ExpressionConverter.ConvertO(bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = ExpressionConverter.ConvertO(bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = ExpressionConverter.ConvertO(bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = ExpressionConverter.ConvertO(bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = ExpressionConverter.ConvertO(bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = ExpressionConverter.ConvertO(bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = ExpressionConverter.ConvertO(bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = ExpressionConverter.ConvertO(bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = ExpressionConverter.ConvertO(bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = ExpressionConverter.ConvertO(bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = ExpressionConverter.ConvertO(bodypropertiessubject);
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
        [WorkflowExpressionFactory(nameof(__BuildTicketsRead))]
        public IWorkflowAction TicketsRead([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsRead(WorkflowExpression<string> ticketId, WorkflowExpression<string> properties = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> idProperty = null)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowExpression.Validate(properties, nameof(properties), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTicketsArchive))]
        public IWorkflowAction TicketsArchive([WorkflowExpression] Func<string> ticketId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsArchive(WorkflowExpression<string> ticketId)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTicketsUpdate))]
        public IWorkflowAction TicketsUpdate([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<string> bodypropertiesclosedDate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstAgentReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsLastcontacted = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsNextactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsNumTimesContacted = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieslastReplyDate = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiestimeToClose = null, [WorkflowExpression] Func<string> bodypropertiestimeToFirstAgentReply = null, [WorkflowExpression] Func<string> bodypropertiescontent = null, [WorkflowExpression] Func<string> bodypropertieshsFileUpload = null, [WorkflowExpression] Func<string> bodypropertieshsNumAssociatedCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsPipeline = null, [WorkflowExpression] Func<string> bodypropertieshsPipelineStage = null, [WorkflowExpression] Func<string> bodypropertieshsResolution = null, [WorkflowExpression] Func<string> bodypropertieshsTicketCategory = null, [WorkflowExpression] Func<string> bodypropertieshsTicketId = null, [WorkflowExpression] Func<string> bodypropertieshsTicketPriority = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiessourceType = null, [WorkflowExpression] Func<string> bodypropertiessubject = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsUpdate(WorkflowExpression<string> ticketId, WorkflowExpression<string> idProperty = null, WorkflowExpression<string> bodypropertiesclosedDate = null, WorkflowExpression<string> bodypropertiescreatedate = null, WorkflowExpression<string> bodypropertiesfirstAgentReplyDate = null, WorkflowExpression<string> bodypropertieshsFeedbackLastCesFollowUp = null, WorkflowExpression<string> bodypropertieshsFeedbackLastCesRating = null, WorkflowExpression<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowExpression<string> bodypropertieshsLastactivitydate = null, WorkflowExpression<string> bodypropertieshsLastcontacted = null, WorkflowExpression<string> bodypropertieshsLastmodifieddate = null, WorkflowExpression<string> bodypropertieshsNextactivitydate = null, WorkflowExpression<string> bodypropertieshsNumTimesContacted = null, WorkflowExpression<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowExpression<string> bodypropertieslastReplyDate = null, WorkflowExpression<string> bodypropertiesnumNotes = null, WorkflowExpression<string> bodypropertiestimeToClose = null, WorkflowExpression<string> bodypropertiestimeToFirstAgentReply = null, WorkflowExpression<string> bodypropertiescontent = null, WorkflowExpression<string> bodypropertieshsFileUpload = null, WorkflowExpression<string> bodypropertieshsNumAssociatedCompanies = null, WorkflowExpression<string> bodypropertieshsPipeline = null, WorkflowExpression<string> bodypropertieshsPipelineStage = null, WorkflowExpression<string> bodypropertieshsResolution = null, WorkflowExpression<string> bodypropertieshsTicketCategory = null, WorkflowExpression<string> bodypropertieshsTicketId = null, WorkflowExpression<string> bodypropertieshsTicketPriority = null, WorkflowExpression<string> bodypropertieshubspotOwnerId = null, WorkflowExpression<string> bodypropertieshubspotTeamId = null, WorkflowExpression<string> bodypropertiessourceType = null, WorkflowExpression<string> bodypropertiessubject = null)
        {
            WorkflowExpression.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowExpression.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowExpression.Validate(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            WorkflowExpression.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowExpression.Validate(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            WorkflowExpression.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            WorkflowExpression.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowExpression.Validate(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowExpression.Validate(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            WorkflowExpression.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowExpression.Validate(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            WorkflowExpression.Validate(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            WorkflowExpression.Validate(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            WorkflowExpression.Validate(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            WorkflowExpression.Validate(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            WorkflowExpression.Validate(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            WorkflowExpression.Validate(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            WorkflowExpression.Validate(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            WorkflowExpression.Validate(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowExpression.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowExpression.Validate(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            WorkflowExpression.Validate(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = ExpressionConverter.Convert(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesclosedDate != null)
                {
                    propertiesObject["closed_date"] = ExpressionConverter.ConvertO(bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = ExpressionConverter.ConvertO(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = ExpressionConverter.ConvertO(bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = ExpressionConverter.ConvertO(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = ExpressionConverter.ConvertO(bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = ExpressionConverter.ConvertO(bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = ExpressionConverter.ConvertO(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = ExpressionConverter.ConvertO(bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = ExpressionConverter.ConvertO(bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = ExpressionConverter.ConvertO(bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = ExpressionConverter.ConvertO(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = ExpressionConverter.ConvertO(bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = ExpressionConverter.ConvertO(bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescontent != null)
                {
                    propertiesObject["content"] = ExpressionConverter.ConvertO(bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = ExpressionConverter.ConvertO(bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = ExpressionConverter.ConvertO(bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = ExpressionConverter.ConvertO(bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = ExpressionConverter.ConvertO(bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = ExpressionConverter.ConvertO(bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = ExpressionConverter.ConvertO(bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = ExpressionConverter.ConvertO(bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = ExpressionConverter.ConvertO(bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = ExpressionConverter.ConvertO(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = ExpressionConverter.ConvertO(bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = ExpressionConverter.ConvertO(bodypropertiessubject);
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