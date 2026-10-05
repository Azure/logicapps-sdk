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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesList(WorkflowValue<int> limit = null, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesCreate(WorkflowValue<string> bodypropertiesname, WorkflowValue<string> bodypropertiesaboutUs = null, WorkflowValue<string> bodypropertiesaddress = null, WorkflowValue<string> bodypropertiesaddress2 = null, WorkflowValue<string> bodypropertiesannualrevenue = null, WorkflowValue<string> bodypropertiescity = null, WorkflowValue<string> bodypropertiesclosedate = null, WorkflowValue<string> bodypropertiescountry = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesdaysToClose = null, WorkflowValue<string> bodypropertiesdescription = null, WorkflowValue<string> bodypropertiesdomain = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> bodypropertiesfacebookCompanyPage = null, WorkflowValue<string> bodypropertiesfacebookfans = null, WorkflowValue<string> bodypropertiesfirstContactCreatedate = null, WorkflowValue<string> bodypropertiesfirstConversionDate = null, WorkflowValue<string> bodypropertiesfirstConversionEventName = null, WorkflowValue<string> bodypropertiesfirstDealCreatedDate = null, WorkflowValue<string> bodypropertiesfoundedYear = null, WorkflowValue<string> bodypropertiesgoogleplusPage = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsLastTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowValue<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsNumPageViews = null, WorkflowValue<string> bodypropertieshsAnalyticsNumVisits = null, WorkflowValue<string> bodypropertieshsAnalyticsSource = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> bodypropertieshsCreatedate = null, WorkflowValue<string> bodypropertieshsIdealCustomerProfile = null, WorkflowValue<string> bodypropertieshsIsTargetAccount = null, WorkflowValue<string> bodypropertieshsLastBookedMeetingDate = null, WorkflowValue<string> bodypropertieshsLastLoggedCallDate = null, WorkflowValue<string> bodypropertieshsLastOpenTaskDate = null, WorkflowValue<string> bodypropertieshsLastSalesActivityTimestamp = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsLeadStatus = null, WorkflowValue<string> bodypropertieshsNumBlockers = null, WorkflowValue<string> bodypropertieshsNumChildCompanies = null, WorkflowValue<string> bodypropertieshsNumContactsWithBuyingRoles = null, WorkflowValue<string> bodypropertieshsNumDecisionMakers = null, WorkflowValue<string> bodypropertieshsNumOpenDeals = null, WorkflowValue<string> bodypropertieshsObjectId = null, WorkflowValue<string> bodypropertieshsParentCompanyId = null, WorkflowValue<string> bodypropertieshsPredictivecontactscoreV2 = null, WorkflowValue<string> bodypropertieshsTotalDealValue = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertiesindustry = null, WorkflowValue<string> bodypropertiesisPublic = null, WorkflowValue<string> bodypropertieslifecyclestage = null, WorkflowValue<string> bodypropertieslinkedinCompanyPage = null, WorkflowValue<string> bodypropertieslinkedinbio = null, WorkflowValue<string> bodypropertiesnotesLastContacted = null, WorkflowValue<string> bodypropertiesnotesLastUpdated = null, WorkflowValue<string> bodypropertiesnotesNextActivityDate = null, WorkflowValue<string> bodypropertiesnumAssociatedContacts = null, WorkflowValue<string> bodypropertiesnumAssociatedDeals = null, WorkflowValue<string> bodypropertiesnumContactedNotes = null, WorkflowValue<string> bodypropertiesnumConversionEvents = null, WorkflowValue<string> bodypropertiesnumberofemployees = null, WorkflowValue<string> bodypropertiesphone = null, WorkflowValue<string> bodypropertiesrecentConversionDate = null, WorkflowValue<string> bodypropertiesrecentConversionEventName = null, WorkflowValue<string> bodypropertiesrecentDealAmount = null, WorkflowValue<string> bodypropertiesrecentDealCloseDate = null, WorkflowValue<string> bodypropertiesstate = null, WorkflowValue<string> bodypropertiestimezone = null, WorkflowValue<string> bodypropertiestotalMoneyRaised = null, WorkflowValue<string> bodypropertiestotalRevenue = null, WorkflowValue<string> bodypropertiestwitterbio = null, WorkflowValue<string> bodypropertiestwitterfollowers = null, WorkflowValue<string> bodypropertiestwitterhandle = null, WorkflowValue<string> bodypropertiestype = null, WorkflowValue<string> bodypropertieswebTechnologies = null, WorkflowValue<string> bodypropertieswebsite = null, WorkflowValue<string> bodypropertieszip = null)
        {
            WorkflowValue.Validate(bodypropertiesname, nameof(bodypropertiesname), required: true);
            WorkflowValue.Validate(bodypropertiesaboutUs, nameof(bodypropertiesaboutUs), required: false);
            WorkflowValue.Validate(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            WorkflowValue.Validate(bodypropertiesaddress2, nameof(bodypropertiesaddress2), required: false);
            WorkflowValue.Validate(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            WorkflowValue.Validate(bodypropertiescity, nameof(bodypropertiescity), required: false);
            WorkflowValue.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowValue.Validate(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            WorkflowValue.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowValue.Validate(bodypropertiesdomain, nameof(bodypropertiesdomain), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(bodypropertiesfacebookCompanyPage, nameof(bodypropertiesfacebookCompanyPage), required: false);
            WorkflowValue.Validate(bodypropertiesfacebookfans, nameof(bodypropertiesfacebookfans), required: false);
            WorkflowValue.Validate(bodypropertiesfirstContactCreatedate, nameof(bodypropertiesfirstContactCreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            WorkflowValue.Validate(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            WorkflowValue.Validate(bodypropertiesfoundedYear, nameof(bodypropertiesfoundedYear), required: false);
            WorkflowValue.Validate(bodypropertiesgoogleplusPage, nameof(bodypropertiesgoogleplusPage), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowValue.Validate(bodypropertieshsIdealCustomerProfile, nameof(bodypropertieshsIdealCustomerProfile), required: false);
            WorkflowValue.Validate(bodypropertieshsIsTargetAccount, nameof(bodypropertieshsIsTargetAccount), required: false);
            WorkflowValue.Validate(bodypropertieshsLastBookedMeetingDate, nameof(bodypropertieshsLastBookedMeetingDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastLoggedCallDate, nameof(bodypropertieshsLastLoggedCallDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastOpenTaskDate, nameof(bodypropertieshsLastOpenTaskDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            WorkflowValue.Validate(bodypropertieshsNumBlockers, nameof(bodypropertieshsNumBlockers), required: false);
            WorkflowValue.Validate(bodypropertieshsNumChildCompanies, nameof(bodypropertieshsNumChildCompanies), required: false);
            WorkflowValue.Validate(bodypropertieshsNumContactsWithBuyingRoles, nameof(bodypropertieshsNumContactsWithBuyingRoles), required: false);
            WorkflowValue.Validate(bodypropertieshsNumDecisionMakers, nameof(bodypropertieshsNumDecisionMakers), required: false);
            WorkflowValue.Validate(bodypropertieshsNumOpenDeals, nameof(bodypropertieshsNumOpenDeals), required: false);
            WorkflowValue.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowValue.Validate(bodypropertieshsParentCompanyId, nameof(bodypropertieshsParentCompanyId), required: false);
            WorkflowValue.Validate(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            WorkflowValue.Validate(bodypropertieshsTotalDealValue, nameof(bodypropertieshsTotalDealValue), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            WorkflowValue.Validate(bodypropertiesisPublic, nameof(bodypropertiesisPublic), required: false);
            WorkflowValue.Validate(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            WorkflowValue.Validate(bodypropertieslinkedinCompanyPage, nameof(bodypropertieslinkedinCompanyPage), required: false);
            WorkflowValue.Validate(bodypropertieslinkedinbio, nameof(bodypropertieslinkedinbio), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowValue.Validate(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            WorkflowValue.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            WorkflowValue.Validate(bodypropertiesnumberofemployees, nameof(bodypropertiesnumberofemployees), required: false);
            WorkflowValue.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowValue.Validate(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            WorkflowValue.Validate(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            WorkflowValue.Validate(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            WorkflowValue.Validate(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            WorkflowValue.Validate(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            WorkflowValue.Validate(bodypropertiestimezone, nameof(bodypropertiestimezone), required: false);
            WorkflowValue.Validate(bodypropertiestotalMoneyRaised, nameof(bodypropertiestotalMoneyRaised), required: false);
            WorkflowValue.Validate(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            WorkflowValue.Validate(bodypropertiestwitterbio, nameof(bodypropertiestwitterbio), required: false);
            WorkflowValue.Validate(bodypropertiestwitterfollowers, nameof(bodypropertiestwitterfollowers), required: false);
            WorkflowValue.Validate(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            WorkflowValue.Validate(bodypropertiestype, nameof(bodypropertiestype), required: false);
            WorkflowValue.Validate(bodypropertieswebTechnologies, nameof(bodypropertieswebTechnologies), required: false);
            WorkflowValue.Validate(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            WorkflowValue.Validate(bodypropertieszip, nameof(bodypropertieszip), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesRead(WorkflowValue<string> companyId, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesArchive(WorkflowValue<string> companyId)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompaniesUpdate(WorkflowValue<string> companyId, WorkflowValue<string> propertiespropertiesname, WorkflowValue<string> propertiespropertiesaboutUs = null, WorkflowValue<string> propertiespropertiesaddress = null, WorkflowValue<string> propertiespropertiesaddress2 = null, WorkflowValue<string> propertiespropertiesannualrevenue = null, WorkflowValue<string> propertiespropertiescity = null, WorkflowValue<string> propertiespropertiesclosedate = null, WorkflowValue<string> propertiespropertiescountry = null, WorkflowValue<string> propertiespropertiescreatedate = null, WorkflowValue<string> propertiespropertiesdaysToClose = null, WorkflowValue<string> propertiespropertiesdescription = null, WorkflowValue<string> propertiespropertiesdomain = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> propertiespropertiesfacebookCompanyPage = null, WorkflowValue<string> propertiespropertiesfacebookfans = null, WorkflowValue<string> propertiespropertiesfirstContactCreatedate = null, WorkflowValue<string> propertiespropertiesfirstConversionDate = null, WorkflowValue<string> propertiespropertiesfirstConversionEventName = null, WorkflowValue<string> propertiespropertiesfirstDealCreatedDate = null, WorkflowValue<string> propertiespropertiesfoundedYear = null, WorkflowValue<string> propertiespropertiesgoogleplusPage = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsNumPageViews = null, WorkflowValue<string> propertiespropertieshsAnalyticsNumVisits = null, WorkflowValue<string> propertiespropertieshsAnalyticsSource = null, WorkflowValue<string> propertiespropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> propertiespropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> propertiespropertieshsCreatedate = null, WorkflowValue<string> propertiespropertieshsIdealCustomerProfile = null, WorkflowValue<string> propertiespropertieshsIsTargetAccount = null, WorkflowValue<string> propertiespropertieshsLastBookedMeetingDate = null, WorkflowValue<string> propertiespropertieshsLastLoggedCallDate = null, WorkflowValue<string> propertiespropertieshsLastOpenTaskDate = null, WorkflowValue<string> propertiespropertieshsLastSalesActivityTimestamp = null, WorkflowValue<string> propertiespropertieshsLastmodifieddate = null, WorkflowValue<string> propertiespropertieshsLeadStatus = null, WorkflowValue<string> propertiespropertieshsNumBlockers = null, WorkflowValue<string> propertiespropertieshsNumChildCompanies = null, WorkflowValue<string> propertiespropertieshsNumContactsWithBuyingRoles = null, WorkflowValue<string> propertiespropertieshsNumDecisionMakers = null, WorkflowValue<string> propertiespropertieshsNumOpenDeals = null, WorkflowValue<string> propertiespropertieshsObjectId = null, WorkflowValue<string> propertiespropertieshsParentCompanyId = null, WorkflowValue<string> propertiespropertieshsPredictivecontactscoreV2 = null, WorkflowValue<string> propertiespropertieshsTotalDealValue = null, WorkflowValue<string> propertiespropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> propertiespropertieshubspotOwnerId = null, WorkflowValue<string> propertiespropertieshubspotTeamId = null, WorkflowValue<string> propertiespropertiesindustry = null, WorkflowValue<string> propertiespropertiesisPublic = null, WorkflowValue<string> propertiespropertieslifecyclestage = null, WorkflowValue<string> propertiespropertieslinkedinCompanyPage = null, WorkflowValue<string> propertiespropertieslinkedinbio = null, WorkflowValue<string> propertiespropertiesnotesLastContacted = null, WorkflowValue<string> propertiespropertiesnotesLastUpdated = null, WorkflowValue<string> propertiespropertiesnotesNextActivityDate = null, WorkflowValue<string> propertiespropertiesnumAssociatedContacts = null, WorkflowValue<string> propertiespropertiesnumAssociatedDeals = null, WorkflowValue<string> propertiespropertiesnumContactedNotes = null, WorkflowValue<string> propertiespropertiesnumConversionEvents = null, WorkflowValue<string> propertiespropertiesnumberofemployees = null, WorkflowValue<string> propertiespropertiesphone = null, WorkflowValue<string> propertiespropertiesrecentConversionDate = null, WorkflowValue<string> propertiespropertiesrecentConversionEventName = null, WorkflowValue<string> propertiespropertiesrecentDealAmount = null, WorkflowValue<string> propertiespropertiesrecentDealCloseDate = null, WorkflowValue<string> propertiespropertiesstate = null, WorkflowValue<string> propertiespropertiestimezone = null, WorkflowValue<string> propertiespropertiestotalMoneyRaised = null, WorkflowValue<string> propertiespropertiestotalRevenue = null, WorkflowValue<string> propertiespropertiestwitterbio = null, WorkflowValue<string> propertiespropertiestwitterfollowers = null, WorkflowValue<string> propertiespropertiestwitterhandle = null, WorkflowValue<string> propertiespropertiestype = null, WorkflowValue<string> propertiespropertieswebTechnologies = null, WorkflowValue<string> propertiespropertieswebsite = null, WorkflowValue<string> propertiespropertieszip = null)
        {
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: true);
            WorkflowValue.Validate(propertiespropertiesaboutUs, nameof(propertiespropertiesaboutUs), required: false);
            WorkflowValue.Validate(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            WorkflowValue.Validate(propertiespropertiesaddress2, nameof(propertiespropertiesaddress2), required: false);
            WorkflowValue.Validate(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            WorkflowValue.Validate(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            WorkflowValue.Validate(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            WorkflowValue.Validate(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            WorkflowValue.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowValue.Validate(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            WorkflowValue.Validate(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            WorkflowValue.Validate(propertiespropertiesdomain, nameof(propertiespropertiesdomain), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(propertiespropertiesfacebookCompanyPage, nameof(propertiespropertiesfacebookCompanyPage), required: false);
            WorkflowValue.Validate(propertiespropertiesfacebookfans, nameof(propertiespropertiesfacebookfans), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstContactCreatedate, nameof(propertiespropertiesfirstContactCreatedate), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            WorkflowValue.Validate(propertiespropertiesfoundedYear, nameof(propertiespropertiesfoundedYear), required: false);
            WorkflowValue.Validate(propertiespropertiesgoogleplusPage, nameof(propertiespropertiesgoogleplusPage), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowValue.Validate(propertiespropertieshsIdealCustomerProfile, nameof(propertiespropertieshsIdealCustomerProfile), required: false);
            WorkflowValue.Validate(propertiespropertieshsIsTargetAccount, nameof(propertiespropertieshsIsTargetAccount), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastBookedMeetingDate, nameof(propertiespropertieshsLastBookedMeetingDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastLoggedCallDate, nameof(propertiespropertieshsLastLoggedCallDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastOpenTaskDate, nameof(propertiespropertieshsLastOpenTaskDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            WorkflowValue.Validate(propertiespropertieshsNumBlockers, nameof(propertiespropertieshsNumBlockers), required: false);
            WorkflowValue.Validate(propertiespropertieshsNumChildCompanies, nameof(propertiespropertieshsNumChildCompanies), required: false);
            WorkflowValue.Validate(propertiespropertieshsNumContactsWithBuyingRoles, nameof(propertiespropertieshsNumContactsWithBuyingRoles), required: false);
            WorkflowValue.Validate(propertiespropertieshsNumDecisionMakers, nameof(propertiespropertieshsNumDecisionMakers), required: false);
            WorkflowValue.Validate(propertiespropertieshsNumOpenDeals, nameof(propertiespropertieshsNumOpenDeals), required: false);
            WorkflowValue.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowValue.Validate(propertiespropertieshsParentCompanyId, nameof(propertiespropertieshsParentCompanyId), required: false);
            WorkflowValue.Validate(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            WorkflowValue.Validate(propertiespropertieshsTotalDealValue, nameof(propertiespropertieshsTotalDealValue), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            WorkflowValue.Validate(propertiespropertiesisPublic, nameof(propertiespropertiesisPublic), required: false);
            WorkflowValue.Validate(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            WorkflowValue.Validate(propertiespropertieslinkedinCompanyPage, nameof(propertiespropertieslinkedinCompanyPage), required: false);
            WorkflowValue.Validate(propertiespropertieslinkedinbio, nameof(propertiespropertieslinkedinbio), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(propertiespropertiesnumAssociatedContacts, nameof(propertiespropertiesnumAssociatedContacts), required: false);
            WorkflowValue.Validate(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            WorkflowValue.Validate(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            WorkflowValue.Validate(propertiespropertiesnumberofemployees, nameof(propertiespropertiesnumberofemployees), required: false);
            WorkflowValue.Validate(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            WorkflowValue.Validate(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            WorkflowValue.Validate(propertiespropertiestimezone, nameof(propertiespropertiestimezone), required: false);
            WorkflowValue.Validate(propertiespropertiestotalMoneyRaised, nameof(propertiespropertiestotalMoneyRaised), required: false);
            WorkflowValue.Validate(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            WorkflowValue.Validate(propertiespropertiestwitterbio, nameof(propertiespropertiestwitterbio), required: false);
            WorkflowValue.Validate(propertiespropertiestwitterfollowers, nameof(propertiespropertiestwitterfollowers), required: false);
            WorkflowValue.Validate(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            WorkflowValue.Validate(propertiespropertiestype, nameof(propertiespropertiestype), required: false);
            WorkflowValue.Validate(propertiespropertieswebTechnologies, nameof(propertiespropertieswebTechnologies), required: false);
            WorkflowValue.Validate(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            WorkflowValue.Validate(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsList(WorkflowValue<int> limit, WorkflowValue<string> properties = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsCreate(WorkflowValue<string> bodypropertiesaddress = null, WorkflowValue<string> bodypropertiesannualrevenue = null, WorkflowValue<string> bodypropertiescity = null, WorkflowValue<string> bodypropertiesclosedate = null, WorkflowValue<string> bodypropertiescompany = null, WorkflowValue<string> bodypropertiescompanySize = null, WorkflowValue<string> bodypropertiescountry = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiescurrentlyinworkflow = null, WorkflowValue<string> bodypropertiesdateOfBirth = null, WorkflowValue<string> bodypropertiesdaysToClose = null, WorkflowValue<string> bodypropertiesdegree = null, WorkflowValue<string> bodypropertiesemail = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> bodypropertiesfax = null, WorkflowValue<string> bodypropertiesfieldOfStudy = null, WorkflowValue<string> bodypropertiesfirstConversionDate = null, WorkflowValue<string> bodypropertiesfirstConversionEventName = null, WorkflowValue<string> bodypropertiesfirstDealCreatedDate = null, WorkflowValue<string> bodypropertiesfirstname = null, WorkflowValue<string> bodypropertiesgender = null, WorkflowValue<string> bodypropertiesgraduationDate = null, WorkflowValue<string> bodypropertieshsAnalyticsAveragePageViews = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstReferrer = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstUrl = null, WorkflowValue<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsLastReferrer = null, WorkflowValue<string> bodypropertieshsAnalyticsLastTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowValue<string> bodypropertieshsAnalyticsLastUrl = null, WorkflowValue<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, WorkflowValue<string> bodypropertieshsAnalyticsNumEventCompletions = null, WorkflowValue<string> bodypropertieshsAnalyticsNumPageViews = null, WorkflowValue<string> bodypropertieshsAnalyticsNumVisits = null, WorkflowValue<string> bodypropertieshsAnalyticsRevenue = null, WorkflowValue<string> bodypropertieshsAnalyticsSource = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> bodypropertieshsBuyingRole = null, WorkflowValue<string> bodypropertieshsContentMembershipEmailConfirmed = null, WorkflowValue<string> bodypropertieshsContentMembershipNotes = null, WorkflowValue<string> bodypropertieshsContentMembershipRegisteredAt = null, WorkflowValue<string> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, WorkflowValue<string> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, WorkflowValue<string> bodypropertieshsContentMembershipStatus = null, WorkflowValue<string> bodypropertieshsCreatedate = null, WorkflowValue<string> bodypropertieshsEmailBadAddress = null, WorkflowValue<string> bodypropertieshsEmailBounce = null, WorkflowValue<string> bodypropertieshsEmailClick = null, WorkflowValue<string> bodypropertieshsEmailCustomerQuarantinedReason = null, WorkflowValue<string> bodypropertieshsEmailDelivered = null, WorkflowValue<string> bodypropertieshsEmailDomain = null, WorkflowValue<string> bodypropertieshsEmailFirstClickDate = null, WorkflowValue<string> bodypropertieshsEmailFirstOpenDate = null, WorkflowValue<string> bodypropertieshsEmailFirstReplyDate = null, WorkflowValue<string> bodypropertieshsEmailFirstSendDate = null, WorkflowValue<string> bodypropertieshsEmailHardBounceReasonEnum = null, WorkflowValue<string> bodypropertieshsEmailLastClickDate = null, WorkflowValue<string> bodypropertieshsEmailLastEmailName = null, WorkflowValue<string> bodypropertieshsEmailLastOpenDate = null, WorkflowValue<string> bodypropertieshsEmailLastReplyDate = null, WorkflowValue<string> bodypropertieshsEmailLastSendDate = null, WorkflowValue<string> bodypropertieshsEmailOpen = null, WorkflowValue<string> bodypropertieshsEmailOptout = null, WorkflowValue<string> bodypropertieshsEmailOptout12592317 = null, WorkflowValue<string> bodypropertieshsEmailQuarantined = null, WorkflowValue<string> bodypropertieshsEmailQuarantinedReason = null, WorkflowValue<string> bodypropertieshsEmailReplied = null, WorkflowValue<string> bodypropertieshsEmailSendsSinceLastEngagement = null, WorkflowValue<string> bodypropertieshsEmailconfirmationstatus = null, WorkflowValue<string> bodypropertieshsFacebookClickId = null, WorkflowValue<string> bodypropertieshsFeedbackLastNpsFollowUp = null, WorkflowValue<string> bodypropertieshsFeedbackLastNpsRating = null, WorkflowValue<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowValue<string> bodypropertieshsGoogleClickId = null, WorkflowValue<string> bodypropertieshsIpTimezone = null, WorkflowValue<string> bodypropertieshsIsUnworked = null, WorkflowValue<string> bodypropertieshsLanguage = null, WorkflowValue<string> bodypropertieshsLastSalesActivityTimestamp = null, WorkflowValue<string> bodypropertieshsLeadStatus = null, WorkflowValue<string> bodypropertieshsLegalBasis = null, WorkflowValue<string> bodypropertieshsLifecyclestageCustomerDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageEvangelistDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageLeadDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageOpportunityDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageOtherDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, WorkflowValue<string> bodypropertieshsLifecyclestageSubscriberDate = null, WorkflowValue<string> bodypropertieshsMarketableReasonId = null, WorkflowValue<string> bodypropertieshsMarketableReasonType = null, WorkflowValue<string> bodypropertieshsMarketableStatus = null, WorkflowValue<string> bodypropertieshsMarketableUntilRenewal = null, WorkflowValue<string> bodypropertieshsObjectId = null, WorkflowValue<string> bodypropertieshsPersona = null, WorkflowValue<string> bodypropertieshsPredictivecontactscore = null, WorkflowValue<string> bodypropertieshsPredictivecontactscoreV2 = null, WorkflowValue<string> bodypropertieshsPredictivecontactscorebucket = null, WorkflowValue<string> bodypropertieshsPredictivescoringtier = null, WorkflowValue<string> bodypropertieshsSalesEmailLastClicked = null, WorkflowValue<string> bodypropertieshsSalesEmailLastOpened = null, WorkflowValue<string> bodypropertieshsSalesEmailLastReplied = null, WorkflowValue<string> bodypropertieshsSequencesIsEnrolled = null, WorkflowValue<string> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, WorkflowValue<string> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, WorkflowValue<string> bodypropertieshsTimeToMoveFromLeadToCustomer = null, WorkflowValue<string> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, WorkflowValue<string> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, WorkflowValue<string> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, WorkflowValue<string> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertieshubspotscore = null, WorkflowValue<string> bodypropertiesindustry = null, WorkflowValue<string> bodypropertiesipCity = null, WorkflowValue<string> bodypropertiesipCountry = null, WorkflowValue<string> bodypropertiesipCountryCode = null, WorkflowValue<string> bodypropertiesipState = null, WorkflowValue<string> bodypropertiesipStateCode = null, WorkflowValue<string> bodypropertiesjobFunction = null, WorkflowValue<string> bodypropertiesjobtitle = null, WorkflowValue<string> bodypropertieslastmodifieddate = null, WorkflowValue<string> bodypropertieslastname = null, WorkflowValue<string> bodypropertieslifecyclestage = null, WorkflowValue<string> bodypropertiesmaritalStatus = null, WorkflowValue<string> bodypropertiesmessage = null, WorkflowValue<string> bodypropertiesmilitaryStatus = null, WorkflowValue<string> bodypropertiesmobilephone = null, WorkflowValue<string> bodypropertiesnotesLastContacted = null, WorkflowValue<string> bodypropertiesnotesLastUpdated = null, WorkflowValue<string> bodypropertiesnotesNextActivityDate = null, WorkflowValue<string> bodypropertiesnumAssociatedDeals = null, WorkflowValue<string> bodypropertiesnumContactedNotes = null, WorkflowValue<string> bodypropertiesnumConversionEvents = null, WorkflowValue<string> bodypropertiesnumNotes = null, WorkflowValue<string> bodypropertiesnumUniqueConversionEvents = null, WorkflowValue<string> bodypropertiesnumemployees = null, WorkflowValue<string> bodypropertiesphone = null, WorkflowValue<string> bodypropertiesrecentConversionDate = null, WorkflowValue<string> bodypropertiesrecentConversionEventName = null, WorkflowValue<string> bodypropertiesrecentDealAmount = null, WorkflowValue<string> bodypropertiesrecentDealCloseDate = null, WorkflowValue<string> bodypropertiesrelationshipStatus = null, WorkflowValue<string> bodypropertiessalutation = null, WorkflowValue<string> bodypropertiesschool = null, WorkflowValue<string> bodypropertiesseniority = null, WorkflowValue<string> bodypropertiesstartDate = null, WorkflowValue<string> bodypropertiesstate = null, WorkflowValue<string> bodypropertiestotalRevenue = null, WorkflowValue<string> bodypropertiestwitterhandle = null, WorkflowValue<string> bodypropertieswebsite = null, WorkflowValue<string> bodypropertiesworkEmail = null, WorkflowValue<string> bodypropertieszip = null)
        {
            WorkflowValue.Validate(bodypropertiesaddress, nameof(bodypropertiesaddress), required: false);
            WorkflowValue.Validate(bodypropertiesannualrevenue, nameof(bodypropertiesannualrevenue), required: false);
            WorkflowValue.Validate(bodypropertiescity, nameof(bodypropertiescity), required: false);
            WorkflowValue.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowValue.Validate(bodypropertiescompany, nameof(bodypropertiescompany), required: false);
            WorkflowValue.Validate(bodypropertiescompanySize, nameof(bodypropertiescompanySize), required: false);
            WorkflowValue.Validate(bodypropertiescountry, nameof(bodypropertiescountry), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiescurrentlyinworkflow, nameof(bodypropertiescurrentlyinworkflow), required: false);
            WorkflowValue.Validate(bodypropertiesdateOfBirth, nameof(bodypropertiesdateOfBirth), required: false);
            WorkflowValue.Validate(bodypropertiesdaysToClose, nameof(bodypropertiesdaysToClose), required: false);
            WorkflowValue.Validate(bodypropertiesdegree, nameof(bodypropertiesdegree), required: false);
            WorkflowValue.Validate(bodypropertiesemail, nameof(bodypropertiesemail), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(bodypropertiesfax, nameof(bodypropertiesfax), required: false);
            WorkflowValue.Validate(bodypropertiesfieldOfStudy, nameof(bodypropertiesfieldOfStudy), required: false);
            WorkflowValue.Validate(bodypropertiesfirstConversionDate, nameof(bodypropertiesfirstConversionDate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstConversionEventName, nameof(bodypropertiesfirstConversionEventName), required: false);
            WorkflowValue.Validate(bodypropertiesfirstDealCreatedDate, nameof(bodypropertiesfirstDealCreatedDate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstname, nameof(bodypropertiesfirstname), required: false);
            WorkflowValue.Validate(bodypropertiesgender, nameof(bodypropertiesgender), required: false);
            WorkflowValue.Validate(bodypropertiesgraduationDate, nameof(bodypropertiesgraduationDate), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsAveragePageViews, nameof(bodypropertieshsAnalyticsAveragePageViews), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstReferrer, nameof(bodypropertieshsAnalyticsFirstReferrer), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstTimestamp, nameof(bodypropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstUrl, nameof(bodypropertieshsAnalyticsFirstUrl), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsFirstVisitTimestamp, nameof(bodypropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastReferrer, nameof(bodypropertieshsAnalyticsLastReferrer), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastTimestamp, nameof(bodypropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastTouchConvertingCampaign, nameof(bodypropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastUrl, nameof(bodypropertieshsAnalyticsLastUrl), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsLastVisitTimestamp, nameof(bodypropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsNumEventCompletions, nameof(bodypropertieshsAnalyticsNumEventCompletions), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsNumPageViews, nameof(bodypropertieshsAnalyticsNumPageViews), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsNumVisits, nameof(bodypropertieshsAnalyticsNumVisits), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsRevenue, nameof(bodypropertieshsAnalyticsRevenue), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(bodypropertieshsBuyingRole, nameof(bodypropertieshsBuyingRole), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipEmailConfirmed, nameof(bodypropertieshsContentMembershipEmailConfirmed), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipNotes, nameof(bodypropertieshsContentMembershipNotes), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipRegisteredAt, nameof(bodypropertieshsContentMembershipRegisteredAt), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipRegistrationDomainSentTo, nameof(bodypropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipRegistrationEmailSentAt, nameof(bodypropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            WorkflowValue.Validate(bodypropertieshsContentMembershipStatus, nameof(bodypropertieshsContentMembershipStatus), required: false);
            WorkflowValue.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailBadAddress, nameof(bodypropertieshsEmailBadAddress), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailBounce, nameof(bodypropertieshsEmailBounce), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailClick, nameof(bodypropertieshsEmailClick), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailCustomerQuarantinedReason, nameof(bodypropertieshsEmailCustomerQuarantinedReason), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailDelivered, nameof(bodypropertieshsEmailDelivered), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailDomain, nameof(bodypropertieshsEmailDomain), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailFirstClickDate, nameof(bodypropertieshsEmailFirstClickDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailFirstOpenDate, nameof(bodypropertieshsEmailFirstOpenDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailFirstReplyDate, nameof(bodypropertieshsEmailFirstReplyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailFirstSendDate, nameof(bodypropertieshsEmailFirstSendDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailHardBounceReasonEnum, nameof(bodypropertieshsEmailHardBounceReasonEnum), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailLastClickDate, nameof(bodypropertieshsEmailLastClickDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailLastEmailName, nameof(bodypropertieshsEmailLastEmailName), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailLastOpenDate, nameof(bodypropertieshsEmailLastOpenDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailLastReplyDate, nameof(bodypropertieshsEmailLastReplyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailLastSendDate, nameof(bodypropertieshsEmailLastSendDate), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailOpen, nameof(bodypropertieshsEmailOpen), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailOptout, nameof(bodypropertieshsEmailOptout), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailOptout12592317, nameof(bodypropertieshsEmailOptout12592317), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailQuarantined, nameof(bodypropertieshsEmailQuarantined), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailQuarantinedReason, nameof(bodypropertieshsEmailQuarantinedReason), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailReplied, nameof(bodypropertieshsEmailReplied), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailSendsSinceLastEngagement, nameof(bodypropertieshsEmailSendsSinceLastEngagement), required: false);
            WorkflowValue.Validate(bodypropertieshsEmailconfirmationstatus, nameof(bodypropertieshsEmailconfirmationstatus), required: false);
            WorkflowValue.Validate(bodypropertieshsFacebookClickId, nameof(bodypropertieshsFacebookClickId), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastNpsFollowUp, nameof(bodypropertieshsFeedbackLastNpsFollowUp), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastNpsRating, nameof(bodypropertieshsFeedbackLastNpsRating), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsGoogleClickId, nameof(bodypropertieshsGoogleClickId), required: false);
            WorkflowValue.Validate(bodypropertieshsIpTimezone, nameof(bodypropertieshsIpTimezone), required: false);
            WorkflowValue.Validate(bodypropertieshsIsUnworked, nameof(bodypropertieshsIsUnworked), required: false);
            WorkflowValue.Validate(bodypropertieshsLanguage, nameof(bodypropertieshsLanguage), required: false);
            WorkflowValue.Validate(bodypropertieshsLastSalesActivityTimestamp, nameof(bodypropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowValue.Validate(bodypropertieshsLeadStatus, nameof(bodypropertieshsLeadStatus), required: false);
            WorkflowValue.Validate(bodypropertieshsLegalBasis, nameof(bodypropertieshsLegalBasis), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageCustomerDate, nameof(bodypropertieshsLifecyclestageCustomerDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageEvangelistDate, nameof(bodypropertieshsLifecyclestageEvangelistDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageLeadDate, nameof(bodypropertieshsLifecyclestageLeadDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(bodypropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageOpportunityDate, nameof(bodypropertieshsLifecyclestageOpportunityDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageOtherDate, nameof(bodypropertieshsLifecyclestageOtherDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageSalesqualifiedleadDate, nameof(bodypropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLifecyclestageSubscriberDate, nameof(bodypropertieshsLifecyclestageSubscriberDate), required: false);
            WorkflowValue.Validate(bodypropertieshsMarketableReasonId, nameof(bodypropertieshsMarketableReasonId), required: false);
            WorkflowValue.Validate(bodypropertieshsMarketableReasonType, nameof(bodypropertieshsMarketableReasonType), required: false);
            WorkflowValue.Validate(bodypropertieshsMarketableStatus, nameof(bodypropertieshsMarketableStatus), required: false);
            WorkflowValue.Validate(bodypropertieshsMarketableUntilRenewal, nameof(bodypropertieshsMarketableUntilRenewal), required: false);
            WorkflowValue.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowValue.Validate(bodypropertieshsPersona, nameof(bodypropertieshsPersona), required: false);
            WorkflowValue.Validate(bodypropertieshsPredictivecontactscore, nameof(bodypropertieshsPredictivecontactscore), required: false);
            WorkflowValue.Validate(bodypropertieshsPredictivecontactscoreV2, nameof(bodypropertieshsPredictivecontactscoreV2), required: false);
            WorkflowValue.Validate(bodypropertieshsPredictivecontactscorebucket, nameof(bodypropertieshsPredictivecontactscorebucket), required: false);
            WorkflowValue.Validate(bodypropertieshsPredictivescoringtier, nameof(bodypropertieshsPredictivescoringtier), required: false);
            WorkflowValue.Validate(bodypropertieshsSalesEmailLastClicked, nameof(bodypropertieshsSalesEmailLastClicked), required: false);
            WorkflowValue.Validate(bodypropertieshsSalesEmailLastOpened, nameof(bodypropertieshsSalesEmailLastOpened), required: false);
            WorkflowValue.Validate(bodypropertieshsSalesEmailLastReplied, nameof(bodypropertieshsSalesEmailLastReplied), required: false);
            WorkflowValue.Validate(bodypropertieshsSequencesIsEnrolled, nameof(bodypropertieshsSequencesIsEnrolled), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeBetweenContactCreationAndDealClose, nameof(bodypropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeBetweenContactCreationAndDealCreation, nameof(bodypropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeToMoveFromLeadToCustomer, nameof(bodypropertieshsTimeToMoveFromLeadToCustomer), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeToMoveFromOpportunityToCustomer, nameof(bodypropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            WorkflowValue.Validate(bodypropertieshsTimeToMoveFromSubscriberToCustomer, nameof(bodypropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotscore, nameof(bodypropertieshubspotscore), required: false);
            WorkflowValue.Validate(bodypropertiesindustry, nameof(bodypropertiesindustry), required: false);
            WorkflowValue.Validate(bodypropertiesipCity, nameof(bodypropertiesipCity), required: false);
            WorkflowValue.Validate(bodypropertiesipCountry, nameof(bodypropertiesipCountry), required: false);
            WorkflowValue.Validate(bodypropertiesipCountryCode, nameof(bodypropertiesipCountryCode), required: false);
            WorkflowValue.Validate(bodypropertiesipState, nameof(bodypropertiesipState), required: false);
            WorkflowValue.Validate(bodypropertiesipStateCode, nameof(bodypropertiesipStateCode), required: false);
            WorkflowValue.Validate(bodypropertiesjobFunction, nameof(bodypropertiesjobFunction), required: false);
            WorkflowValue.Validate(bodypropertiesjobtitle, nameof(bodypropertiesjobtitle), required: false);
            WorkflowValue.Validate(bodypropertieslastmodifieddate, nameof(bodypropertieslastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieslastname, nameof(bodypropertieslastname), required: false);
            WorkflowValue.Validate(bodypropertieslifecyclestage, nameof(bodypropertieslifecyclestage), required: false);
            WorkflowValue.Validate(bodypropertiesmaritalStatus, nameof(bodypropertiesmaritalStatus), required: false);
            WorkflowValue.Validate(bodypropertiesmessage, nameof(bodypropertiesmessage), required: false);
            WorkflowValue.Validate(bodypropertiesmilitaryStatus, nameof(bodypropertiesmilitaryStatus), required: false);
            WorkflowValue.Validate(bodypropertiesmobilephone, nameof(bodypropertiesmobilephone), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumAssociatedDeals, nameof(bodypropertiesnumAssociatedDeals), required: false);
            WorkflowValue.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(bodypropertiesnumConversionEvents, nameof(bodypropertiesnumConversionEvents), required: false);
            WorkflowValue.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowValue.Validate(bodypropertiesnumUniqueConversionEvents, nameof(bodypropertiesnumUniqueConversionEvents), required: false);
            WorkflowValue.Validate(bodypropertiesnumemployees, nameof(bodypropertiesnumemployees), required: false);
            WorkflowValue.Validate(bodypropertiesphone, nameof(bodypropertiesphone), required: false);
            WorkflowValue.Validate(bodypropertiesrecentConversionDate, nameof(bodypropertiesrecentConversionDate), required: false);
            WorkflowValue.Validate(bodypropertiesrecentConversionEventName, nameof(bodypropertiesrecentConversionEventName), required: false);
            WorkflowValue.Validate(bodypropertiesrecentDealAmount, nameof(bodypropertiesrecentDealAmount), required: false);
            WorkflowValue.Validate(bodypropertiesrecentDealCloseDate, nameof(bodypropertiesrecentDealCloseDate), required: false);
            WorkflowValue.Validate(bodypropertiesrelationshipStatus, nameof(bodypropertiesrelationshipStatus), required: false);
            WorkflowValue.Validate(bodypropertiessalutation, nameof(bodypropertiessalutation), required: false);
            WorkflowValue.Validate(bodypropertiesschool, nameof(bodypropertiesschool), required: false);
            WorkflowValue.Validate(bodypropertiesseniority, nameof(bodypropertiesseniority), required: false);
            WorkflowValue.Validate(bodypropertiesstartDate, nameof(bodypropertiesstartDate), required: false);
            WorkflowValue.Validate(bodypropertiesstate, nameof(bodypropertiesstate), required: false);
            WorkflowValue.Validate(bodypropertiestotalRevenue, nameof(bodypropertiestotalRevenue), required: false);
            WorkflowValue.Validate(bodypropertiestwitterhandle, nameof(bodypropertiestwitterhandle), required: false);
            WorkflowValue.Validate(bodypropertieswebsite, nameof(bodypropertieswebsite), required: false);
            WorkflowValue.Validate(bodypropertiesworkEmail, nameof(bodypropertiesworkEmail), required: false);
            WorkflowValue.Validate(bodypropertieszip, nameof(bodypropertieszip), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsRead(WorkflowValue<string> contactId)
        {
            WorkflowValue.Validate(contactId, nameof(contactId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsArchive(WorkflowValue<string> contactId)
        {
            WorkflowValue.Validate(contactId, nameof(contactId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactsUpdate(WorkflowValue<string> contactId, WorkflowValue<string> propertiespropertiesaddress = null, WorkflowValue<string> propertiespropertiesannualrevenue = null, WorkflowValue<string> propertiespropertiescity = null, WorkflowValue<string> propertiespropertiesclosedate = null, WorkflowValue<string> propertiespropertiescompany = null, WorkflowValue<string> propertiespropertiescompanySize = null, WorkflowValue<string> propertiespropertiescountry = null, WorkflowValue<string> propertiespropertiescreatedate = null, WorkflowValue<string> propertiespropertiescurrentlyinworkflow = null, WorkflowValue<string> propertiespropertiesdateOfBirth = null, WorkflowValue<string> propertiespropertiesdaysToClose = null, WorkflowValue<string> propertiespropertiesdegree = null, WorkflowValue<string> propertiespropertiesemail = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> propertiespropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> propertiespropertiesfax = null, WorkflowValue<string> propertiespropertiesfieldOfStudy = null, WorkflowValue<string> propertiespropertiesfirstConversionDate = null, WorkflowValue<string> propertiespropertiesfirstConversionEventName = null, WorkflowValue<string> propertiespropertiesfirstDealCreatedDate = null, WorkflowValue<string> propertiespropertiesfirstname = null, WorkflowValue<string> propertiespropertiesgender = null, WorkflowValue<string> propertiespropertiesgraduationDate = null, WorkflowValue<string> propertiespropertieshsAnalyticsAveragePageViews = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstReferrer = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstUrl = null, WorkflowValue<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastReferrer = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastUrl = null, WorkflowValue<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, WorkflowValue<string> propertiespropertieshsAnalyticsNumEventCompletions = null, WorkflowValue<string> propertiespropertieshsAnalyticsNumPageViews = null, WorkflowValue<string> propertiespropertieshsAnalyticsNumVisits = null, WorkflowValue<string> propertiespropertieshsAnalyticsRevenue = null, WorkflowValue<string> propertiespropertieshsAnalyticsSource = null, WorkflowValue<string> propertiespropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> propertiespropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> propertiespropertieshsBuyingRole = null, WorkflowValue<string> propertiespropertieshsContentMembershipEmailConfirmed = null, WorkflowValue<string> propertiespropertieshsContentMembershipNotes = null, WorkflowValue<string> propertiespropertieshsContentMembershipRegisteredAt = null, WorkflowValue<string> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, WorkflowValue<string> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, WorkflowValue<string> propertiespropertieshsContentMembershipStatus = null, WorkflowValue<string> propertiespropertieshsCreatedate = null, WorkflowValue<string> propertiespropertieshsEmailBadAddress = null, WorkflowValue<string> propertiespropertieshsEmailBounce = null, WorkflowValue<string> propertiespropertieshsEmailClick = null, WorkflowValue<string> propertiespropertieshsEmailCustomerQuarantinedReason = null, WorkflowValue<string> propertiespropertieshsEmailDelivered = null, WorkflowValue<string> propertiespropertieshsEmailDomain = null, WorkflowValue<string> propertiespropertieshsEmailFirstClickDate = null, WorkflowValue<string> propertiespropertieshsEmailFirstOpenDate = null, WorkflowValue<string> propertiespropertieshsEmailFirstReplyDate = null, WorkflowValue<string> propertiespropertieshsEmailFirstSendDate = null, WorkflowValue<string> propertiespropertieshsEmailHardBounceReasonEnum = null, WorkflowValue<string> propertiespropertieshsEmailLastClickDate = null, WorkflowValue<string> propertiespropertieshsEmailLastEmailName = null, WorkflowValue<string> propertiespropertieshsEmailLastOpenDate = null, WorkflowValue<string> propertiespropertieshsEmailLastReplyDate = null, WorkflowValue<string> propertiespropertieshsEmailLastSendDate = null, WorkflowValue<string> propertiespropertieshsEmailOpen = null, WorkflowValue<string> propertiespropertieshsEmailOptout = null, WorkflowValue<string> propertiespropertieshsEmailOptout12592317 = null, WorkflowValue<string> propertiespropertieshsEmailQuarantined = null, WorkflowValue<string> propertiespropertieshsEmailQuarantinedReason = null, WorkflowValue<string> propertiespropertieshsEmailReplied = null, WorkflowValue<string> propertiespropertieshsEmailSendsSinceLastEngagement = null, WorkflowValue<string> propertiespropertieshsEmailconfirmationstatus = null, WorkflowValue<string> propertiespropertieshsFacebookClickId = null, WorkflowValue<string> propertiespropertieshsFeedbackLastNpsFollowUp = null, WorkflowValue<string> propertiespropertieshsFeedbackLastNpsRating = null, WorkflowValue<string> propertiespropertieshsFeedbackLastSurveyDate = null, WorkflowValue<string> propertiespropertieshsGoogleClickId = null, WorkflowValue<string> propertiespropertieshsIpTimezone = null, WorkflowValue<string> propertiespropertieshsIsUnworked = null, WorkflowValue<string> propertiespropertieshsLanguage = null, WorkflowValue<string> propertiespropertieshsLastSalesActivityTimestamp = null, WorkflowValue<string> propertiespropertieshsLeadStatus = null, WorkflowValue<string> propertiespropertieshsLegalBasis = null, WorkflowValue<string> propertiespropertieshsLifecyclestageCustomerDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageEvangelistDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageLeadDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageOpportunityDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageOtherDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, WorkflowValue<string> propertiespropertieshsLifecyclestageSubscriberDate = null, WorkflowValue<string> propertiespropertieshsMarketableReasonId = null, WorkflowValue<string> propertiespropertieshsMarketableReasonType = null, WorkflowValue<string> propertiespropertieshsMarketableStatus = null, WorkflowValue<string> propertiespropertieshsMarketableUntilRenewal = null, WorkflowValue<string> propertiespropertieshsObjectId = null, WorkflowValue<string> propertiespropertieshsPersona = null, WorkflowValue<string> propertiespropertieshsPredictivecontactscore = null, WorkflowValue<string> propertiespropertieshsPredictivecontactscoreV2 = null, WorkflowValue<string> propertiespropertieshsPredictivecontactscorebucket = null, WorkflowValue<string> propertiespropertieshsPredictivescoringtier = null, WorkflowValue<string> propertiespropertieshsSalesEmailLastClicked = null, WorkflowValue<string> propertiespropertieshsSalesEmailLastOpened = null, WorkflowValue<string> propertiespropertieshsSalesEmailLastReplied = null, WorkflowValue<string> propertiespropertieshsSequencesIsEnrolled = null, WorkflowValue<string> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, WorkflowValue<string> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, WorkflowValue<string> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, WorkflowValue<string> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, WorkflowValue<string> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, WorkflowValue<string> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, WorkflowValue<string> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, WorkflowValue<string> propertiespropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> propertiespropertieshubspotOwnerId = null, WorkflowValue<string> propertiespropertieshubspotTeamId = null, WorkflowValue<string> propertiespropertieshubspotscore = null, WorkflowValue<string> propertiespropertiesindustry = null, WorkflowValue<string> propertiespropertiesipCity = null, WorkflowValue<string> propertiespropertiesipCountry = null, WorkflowValue<string> propertiespropertiesipCountryCode = null, WorkflowValue<string> propertiespropertiesipState = null, WorkflowValue<string> propertiespropertiesipStateCode = null, WorkflowValue<string> propertiespropertiesjobFunction = null, WorkflowValue<string> propertiespropertiesjobtitle = null, WorkflowValue<string> propertiespropertieslastmodifieddate = null, WorkflowValue<string> propertiespropertieslastname = null, WorkflowValue<string> propertiespropertieslifecyclestage = null, WorkflowValue<string> propertiespropertiesmaritalStatus = null, WorkflowValue<string> propertiespropertiesmessage = null, WorkflowValue<string> propertiespropertiesmilitaryStatus = null, WorkflowValue<string> propertiespropertiesmobilephone = null, WorkflowValue<string> propertiespropertiesnotesLastContacted = null, WorkflowValue<string> propertiespropertiesnotesLastUpdated = null, WorkflowValue<string> propertiespropertiesnotesNextActivityDate = null, WorkflowValue<string> propertiespropertiesnumAssociatedDeals = null, WorkflowValue<string> propertiespropertiesnumContactedNotes = null, WorkflowValue<string> propertiespropertiesnumConversionEvents = null, WorkflowValue<string> propertiespropertiesnumNotes = null, WorkflowValue<string> propertiespropertiesnumUniqueConversionEvents = null, WorkflowValue<string> propertiespropertiesnumemployees = null, WorkflowValue<string> propertiespropertiesphone = null, WorkflowValue<string> propertiespropertiesrecentConversionDate = null, WorkflowValue<string> propertiespropertiesrecentConversionEventName = null, WorkflowValue<string> propertiespropertiesrecentDealAmount = null, WorkflowValue<string> propertiespropertiesrecentDealCloseDate = null, WorkflowValue<string> propertiespropertiesrelationshipStatus = null, WorkflowValue<string> propertiespropertiessalutation = null, WorkflowValue<string> propertiespropertiesschool = null, WorkflowValue<string> propertiespropertiesseniority = null, WorkflowValue<string> propertiespropertiesstartDate = null, WorkflowValue<string> propertiespropertiesstate = null, WorkflowValue<string> propertiespropertiestotalRevenue = null, WorkflowValue<string> propertiespropertiestwitterhandle = null, WorkflowValue<string> propertiespropertieswebsite = null, WorkflowValue<string> propertiespropertiesworkEmail = null, WorkflowValue<string> propertiespropertieszip = null)
        {
            WorkflowValue.Validate(contactId, nameof(contactId), required: true);
            WorkflowValue.Validate(propertiespropertiesaddress, nameof(propertiespropertiesaddress), required: false);
            WorkflowValue.Validate(propertiespropertiesannualrevenue, nameof(propertiespropertiesannualrevenue), required: false);
            WorkflowValue.Validate(propertiespropertiescity, nameof(propertiespropertiescity), required: false);
            WorkflowValue.Validate(propertiespropertiesclosedate, nameof(propertiespropertiesclosedate), required: false);
            WorkflowValue.Validate(propertiespropertiescompany, nameof(propertiespropertiescompany), required: false);
            WorkflowValue.Validate(propertiespropertiescompanySize, nameof(propertiespropertiescompanySize), required: false);
            WorkflowValue.Validate(propertiespropertiescountry, nameof(propertiespropertiescountry), required: false);
            WorkflowValue.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowValue.Validate(propertiespropertiescurrentlyinworkflow, nameof(propertiespropertiescurrentlyinworkflow), required: false);
            WorkflowValue.Validate(propertiespropertiesdateOfBirth, nameof(propertiespropertiesdateOfBirth), required: false);
            WorkflowValue.Validate(propertiespropertiesdaysToClose, nameof(propertiespropertiesdaysToClose), required: false);
            WorkflowValue.Validate(propertiespropertiesdegree, nameof(propertiespropertiesdegree), required: false);
            WorkflowValue.Validate(propertiespropertiesemail, nameof(propertiespropertiesemail), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBooked, nameof(propertiespropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedCampaign, nameof(propertiespropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedMedium, nameof(propertiespropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(propertiespropertiesengagementsLastMeetingBookedSource, nameof(propertiespropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(propertiespropertiesfax, nameof(propertiespropertiesfax), required: false);
            WorkflowValue.Validate(propertiespropertiesfieldOfStudy, nameof(propertiespropertiesfieldOfStudy), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstConversionDate, nameof(propertiespropertiesfirstConversionDate), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstConversionEventName, nameof(propertiespropertiesfirstConversionEventName), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstDealCreatedDate, nameof(propertiespropertiesfirstDealCreatedDate), required: false);
            WorkflowValue.Validate(propertiespropertiesfirstname, nameof(propertiespropertiesfirstname), required: false);
            WorkflowValue.Validate(propertiespropertiesgender, nameof(propertiespropertiesgender), required: false);
            WorkflowValue.Validate(propertiespropertiesgraduationDate, nameof(propertiespropertiesgraduationDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsAveragePageViews, nameof(propertiespropertieshsAnalyticsAveragePageViews), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstReferrer, nameof(propertiespropertieshsAnalyticsFirstReferrer), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstTimestamp, nameof(propertiespropertieshsAnalyticsFirstTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstUrl, nameof(propertiespropertieshsAnalyticsFirstUrl), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsFirstVisitTimestamp, nameof(propertiespropertieshsAnalyticsFirstVisitTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastReferrer, nameof(propertiespropertieshsAnalyticsLastReferrer), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastTimestamp, nameof(propertiespropertieshsAnalyticsLastTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastTouchConvertingCampaign, nameof(propertiespropertieshsAnalyticsLastTouchConvertingCampaign), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastUrl, nameof(propertiespropertieshsAnalyticsLastUrl), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsLastVisitTimestamp, nameof(propertiespropertieshsAnalyticsLastVisitTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsNumEventCompletions, nameof(propertiespropertieshsAnalyticsNumEventCompletions), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsNumPageViews, nameof(propertiespropertieshsAnalyticsNumPageViews), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsNumVisits, nameof(propertiespropertieshsAnalyticsNumVisits), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsRevenue, nameof(propertiespropertieshsAnalyticsRevenue), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSource, nameof(propertiespropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSourceData1, nameof(propertiespropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(propertiespropertieshsAnalyticsSourceData2, nameof(propertiespropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(propertiespropertieshsBuyingRole, nameof(propertiespropertieshsBuyingRole), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipEmailConfirmed, nameof(propertiespropertieshsContentMembershipEmailConfirmed), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipNotes, nameof(propertiespropertieshsContentMembershipNotes), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipRegisteredAt, nameof(propertiespropertieshsContentMembershipRegisteredAt), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipRegistrationDomainSentTo, nameof(propertiespropertieshsContentMembershipRegistrationDomainSentTo), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipRegistrationEmailSentAt, nameof(propertiespropertieshsContentMembershipRegistrationEmailSentAt), required: false);
            WorkflowValue.Validate(propertiespropertieshsContentMembershipStatus, nameof(propertiespropertieshsContentMembershipStatus), required: false);
            WorkflowValue.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailBadAddress, nameof(propertiespropertieshsEmailBadAddress), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailBounce, nameof(propertiespropertieshsEmailBounce), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailClick, nameof(propertiespropertieshsEmailClick), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailCustomerQuarantinedReason, nameof(propertiespropertieshsEmailCustomerQuarantinedReason), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailDelivered, nameof(propertiespropertieshsEmailDelivered), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailDomain, nameof(propertiespropertieshsEmailDomain), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailFirstClickDate, nameof(propertiespropertieshsEmailFirstClickDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailFirstOpenDate, nameof(propertiespropertieshsEmailFirstOpenDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailFirstReplyDate, nameof(propertiespropertieshsEmailFirstReplyDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailFirstSendDate, nameof(propertiespropertieshsEmailFirstSendDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailHardBounceReasonEnum, nameof(propertiespropertieshsEmailHardBounceReasonEnum), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailLastClickDate, nameof(propertiespropertieshsEmailLastClickDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailLastEmailName, nameof(propertiespropertieshsEmailLastEmailName), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailLastOpenDate, nameof(propertiespropertieshsEmailLastOpenDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailLastReplyDate, nameof(propertiespropertieshsEmailLastReplyDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailLastSendDate, nameof(propertiespropertieshsEmailLastSendDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailOpen, nameof(propertiespropertieshsEmailOpen), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailOptout, nameof(propertiespropertieshsEmailOptout), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailOptout12592317, nameof(propertiespropertieshsEmailOptout12592317), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailQuarantined, nameof(propertiespropertieshsEmailQuarantined), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailQuarantinedReason, nameof(propertiespropertieshsEmailQuarantinedReason), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailReplied, nameof(propertiespropertieshsEmailReplied), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailSendsSinceLastEngagement, nameof(propertiespropertieshsEmailSendsSinceLastEngagement), required: false);
            WorkflowValue.Validate(propertiespropertieshsEmailconfirmationstatus, nameof(propertiespropertieshsEmailconfirmationstatus), required: false);
            WorkflowValue.Validate(propertiespropertieshsFacebookClickId, nameof(propertiespropertieshsFacebookClickId), required: false);
            WorkflowValue.Validate(propertiespropertieshsFeedbackLastNpsFollowUp, nameof(propertiespropertieshsFeedbackLastNpsFollowUp), required: false);
            WorkflowValue.Validate(propertiespropertieshsFeedbackLastNpsRating, nameof(propertiespropertieshsFeedbackLastNpsRating), required: false);
            WorkflowValue.Validate(propertiespropertieshsFeedbackLastSurveyDate, nameof(propertiespropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsGoogleClickId, nameof(propertiespropertieshsGoogleClickId), required: false);
            WorkflowValue.Validate(propertiespropertieshsIpTimezone, nameof(propertiespropertieshsIpTimezone), required: false);
            WorkflowValue.Validate(propertiespropertieshsIsUnworked, nameof(propertiespropertieshsIsUnworked), required: false);
            WorkflowValue.Validate(propertiespropertieshsLanguage, nameof(propertiespropertieshsLanguage), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastSalesActivityTimestamp, nameof(propertiespropertieshsLastSalesActivityTimestamp), required: false);
            WorkflowValue.Validate(propertiespropertieshsLeadStatus, nameof(propertiespropertieshsLeadStatus), required: false);
            WorkflowValue.Validate(propertiespropertieshsLegalBasis, nameof(propertiespropertieshsLegalBasis), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageCustomerDate, nameof(propertiespropertieshsLifecyclestageCustomerDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageEvangelistDate, nameof(propertiespropertieshsLifecyclestageEvangelistDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageLeadDate, nameof(propertiespropertieshsLifecyclestageLeadDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageOpportunityDate, nameof(propertiespropertieshsLifecyclestageOpportunityDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageOtherDate, nameof(propertiespropertieshsLifecyclestageOtherDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageSalesqualifiedleadDate, nameof(propertiespropertieshsLifecyclestageSalesqualifiedleadDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsLifecyclestageSubscriberDate, nameof(propertiespropertieshsLifecyclestageSubscriberDate), required: false);
            WorkflowValue.Validate(propertiespropertieshsMarketableReasonId, nameof(propertiespropertieshsMarketableReasonId), required: false);
            WorkflowValue.Validate(propertiespropertieshsMarketableReasonType, nameof(propertiespropertieshsMarketableReasonType), required: false);
            WorkflowValue.Validate(propertiespropertieshsMarketableStatus, nameof(propertiespropertieshsMarketableStatus), required: false);
            WorkflowValue.Validate(propertiespropertieshsMarketableUntilRenewal, nameof(propertiespropertieshsMarketableUntilRenewal), required: false);
            WorkflowValue.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowValue.Validate(propertiespropertieshsPersona, nameof(propertiespropertieshsPersona), required: false);
            WorkflowValue.Validate(propertiespropertieshsPredictivecontactscore, nameof(propertiespropertieshsPredictivecontactscore), required: false);
            WorkflowValue.Validate(propertiespropertieshsPredictivecontactscoreV2, nameof(propertiespropertieshsPredictivecontactscoreV2), required: false);
            WorkflowValue.Validate(propertiespropertieshsPredictivecontactscorebucket, nameof(propertiespropertieshsPredictivecontactscorebucket), required: false);
            WorkflowValue.Validate(propertiespropertieshsPredictivescoringtier, nameof(propertiespropertieshsPredictivescoringtier), required: false);
            WorkflowValue.Validate(propertiespropertieshsSalesEmailLastClicked, nameof(propertiespropertieshsSalesEmailLastClicked), required: false);
            WorkflowValue.Validate(propertiespropertieshsSalesEmailLastOpened, nameof(propertiespropertieshsSalesEmailLastOpened), required: false);
            WorkflowValue.Validate(propertiespropertieshsSalesEmailLastReplied, nameof(propertiespropertieshsSalesEmailLastReplied), required: false);
            WorkflowValue.Validate(propertiespropertieshsSequencesIsEnrolled, nameof(propertiespropertieshsSequencesIsEnrolled), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeBetweenContactCreationAndDealClose, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealClose), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeBetweenContactCreationAndDealCreation, nameof(propertiespropertieshsTimeBetweenContactCreationAndDealCreation), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeToMoveFromLeadToCustomer, nameof(propertiespropertieshsTimeToMoveFromLeadToCustomer), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeToMoveFromOpportunityToCustomer, nameof(propertiespropertieshsTimeToMoveFromOpportunityToCustomer), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer, nameof(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer), required: false);
            WorkflowValue.Validate(propertiespropertieshsTimeToMoveFromSubscriberToCustomer, nameof(propertiespropertieshsTimeToMoveFromSubscriberToCustomer), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotOwnerAssigneddate, nameof(propertiespropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotOwnerId, nameof(propertiespropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotTeamId, nameof(propertiespropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(propertiespropertieshubspotscore, nameof(propertiespropertieshubspotscore), required: false);
            WorkflowValue.Validate(propertiespropertiesindustry, nameof(propertiespropertiesindustry), required: false);
            WorkflowValue.Validate(propertiespropertiesipCity, nameof(propertiespropertiesipCity), required: false);
            WorkflowValue.Validate(propertiespropertiesipCountry, nameof(propertiespropertiesipCountry), required: false);
            WorkflowValue.Validate(propertiespropertiesipCountryCode, nameof(propertiespropertiesipCountryCode), required: false);
            WorkflowValue.Validate(propertiespropertiesipState, nameof(propertiespropertiesipState), required: false);
            WorkflowValue.Validate(propertiespropertiesipStateCode, nameof(propertiespropertiesipStateCode), required: false);
            WorkflowValue.Validate(propertiespropertiesjobFunction, nameof(propertiespropertiesjobFunction), required: false);
            WorkflowValue.Validate(propertiespropertiesjobtitle, nameof(propertiespropertiesjobtitle), required: false);
            WorkflowValue.Validate(propertiespropertieslastmodifieddate, nameof(propertiespropertieslastmodifieddate), required: false);
            WorkflowValue.Validate(propertiespropertieslastname, nameof(propertiespropertieslastname), required: false);
            WorkflowValue.Validate(propertiespropertieslifecyclestage, nameof(propertiespropertieslifecyclestage), required: false);
            WorkflowValue.Validate(propertiespropertiesmaritalStatus, nameof(propertiespropertiesmaritalStatus), required: false);
            WorkflowValue.Validate(propertiespropertiesmessage, nameof(propertiespropertiesmessage), required: false);
            WorkflowValue.Validate(propertiespropertiesmilitaryStatus, nameof(propertiespropertiesmilitaryStatus), required: false);
            WorkflowValue.Validate(propertiespropertiesmobilephone, nameof(propertiespropertiesmobilephone), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesLastContacted, nameof(propertiespropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesLastUpdated, nameof(propertiespropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(propertiespropertiesnotesNextActivityDate, nameof(propertiespropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(propertiespropertiesnumAssociatedDeals, nameof(propertiespropertiesnumAssociatedDeals), required: false);
            WorkflowValue.Validate(propertiespropertiesnumContactedNotes, nameof(propertiespropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(propertiespropertiesnumConversionEvents, nameof(propertiespropertiesnumConversionEvents), required: false);
            WorkflowValue.Validate(propertiespropertiesnumNotes, nameof(propertiespropertiesnumNotes), required: false);
            WorkflowValue.Validate(propertiespropertiesnumUniqueConversionEvents, nameof(propertiespropertiesnumUniqueConversionEvents), required: false);
            WorkflowValue.Validate(propertiespropertiesnumemployees, nameof(propertiespropertiesnumemployees), required: false);
            WorkflowValue.Validate(propertiespropertiesphone, nameof(propertiespropertiesphone), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentConversionDate, nameof(propertiespropertiesrecentConversionDate), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentConversionEventName, nameof(propertiespropertiesrecentConversionEventName), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentDealAmount, nameof(propertiespropertiesrecentDealAmount), required: false);
            WorkflowValue.Validate(propertiespropertiesrecentDealCloseDate, nameof(propertiespropertiesrecentDealCloseDate), required: false);
            WorkflowValue.Validate(propertiespropertiesrelationshipStatus, nameof(propertiespropertiesrelationshipStatus), required: false);
            WorkflowValue.Validate(propertiespropertiessalutation, nameof(propertiespropertiessalutation), required: false);
            WorkflowValue.Validate(propertiespropertiesschool, nameof(propertiespropertiesschool), required: false);
            WorkflowValue.Validate(propertiespropertiesseniority, nameof(propertiespropertiesseniority), required: false);
            WorkflowValue.Validate(propertiespropertiesstartDate, nameof(propertiespropertiesstartDate), required: false);
            WorkflowValue.Validate(propertiespropertiesstate, nameof(propertiespropertiesstate), required: false);
            WorkflowValue.Validate(propertiespropertiestotalRevenue, nameof(propertiespropertiestotalRevenue), required: false);
            WorkflowValue.Validate(propertiespropertiestwitterhandle, nameof(propertiespropertiestwitterhandle), required: false);
            WorkflowValue.Validate(propertiespropertieswebsite, nameof(propertiespropertieswebsite), required: false);
            WorkflowValue.Validate(propertiespropertiesworkEmail, nameof(propertiespropertiesworkEmail), required: false);
            WorkflowValue.Validate(propertiespropertieszip, nameof(propertiespropertieszip), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsList(WorkflowValue<string> properties = null, WorkflowValue<int> limit = null, WorkflowValue<string> after = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(after, nameof(after), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsCreate(WorkflowValue<string> bodypropertiesamount = null, WorkflowValue<string> bodypropertiesamountInHomeCurrency = null, WorkflowValue<string> bodypropertiesclosedLostReason = null, WorkflowValue<string> bodypropertiesclosedWonReason = null, WorkflowValue<string> bodypropertiesclosedate = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesdealname = null, WorkflowValue<string> bodypropertiesdealstage = null, WorkflowValue<string> bodypropertiesdealtype = null, WorkflowValue<string> bodypropertiesdescription = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> bodypropertieshsAcv = null, WorkflowValue<string> bodypropertieshsAnalyticsSource = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> bodypropertieshsArr = null, WorkflowValue<string> bodypropertieshsForecastAmount = null, WorkflowValue<string> bodypropertieshsForecastProbability = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsManualForecastCategory = null, WorkflowValue<string> bodypropertieshsMrr = null, WorkflowValue<string> bodypropertieshsNextStep = null, WorkflowValue<string> bodypropertieshsObjectId = null, WorkflowValue<string> bodypropertieshsPriority = null, WorkflowValue<string> bodypropertieshsTcv = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertiesnotesLastContacted = null, WorkflowValue<string> bodypropertiesnotesLastUpdated = null, WorkflowValue<string> bodypropertiesnotesNextActivityDate = null, WorkflowValue<string> bodypropertiesnumAssociatedContacts = null, WorkflowValue<string> bodypropertiesnumContactedNotes = null, WorkflowValue<string> bodypropertiesnumNotes = null, WorkflowValue<string> bodypropertiespipeline = null)
        {
            WorkflowValue.Validate(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            WorkflowValue.Validate(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            WorkflowValue.Validate(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            WorkflowValue.Validate(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            WorkflowValue.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            WorkflowValue.Validate(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            WorkflowValue.Validate(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            WorkflowValue.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            WorkflowValue.Validate(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            WorkflowValue.Validate(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            WorkflowValue.Validate(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            WorkflowValue.Validate(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            WorkflowValue.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowValue.Validate(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            WorkflowValue.Validate(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowValue.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowValue.Validate(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsRead(WorkflowValue<string> dealId, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(dealId, nameof(dealId), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsArchive(WorkflowValue<string> dealId)
        {
            WorkflowValue.Validate(dealId, nameof(dealId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDealsUpdate(WorkflowValue<string> dealId, WorkflowValue<string> bodypropertiesamount = null, WorkflowValue<string> bodypropertiesamountInHomeCurrency = null, WorkflowValue<string> bodypropertiesclosedLostReason = null, WorkflowValue<string> bodypropertiesclosedWonReason = null, WorkflowValue<string> bodypropertiesclosedate = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesdealname = null, WorkflowValue<string> bodypropertiesdealstage = null, WorkflowValue<string> bodypropertiesdealtype = null, WorkflowValue<string> bodypropertiesdescription = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBooked = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedMedium = null, WorkflowValue<string> bodypropertiesengagementsLastMeetingBookedSource = null, WorkflowValue<string> bodypropertieshsAcv = null, WorkflowValue<string> bodypropertieshsAnalyticsSource = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData1 = null, WorkflowValue<string> bodypropertieshsAnalyticsSourceData2 = null, WorkflowValue<string> bodypropertieshsArr = null, WorkflowValue<string> bodypropertieshsForecastAmount = null, WorkflowValue<string> bodypropertieshsForecastProbability = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsManualForecastCategory = null, WorkflowValue<string> bodypropertieshsMrr = null, WorkflowValue<string> bodypropertieshsNextStep = null, WorkflowValue<string> bodypropertieshsObjectId = null, WorkflowValue<string> bodypropertieshsPriority = null, WorkflowValue<string> bodypropertieshsTcv = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertiesnotesLastContacted = null, WorkflowValue<string> bodypropertiesnotesLastUpdated = null, WorkflowValue<string> bodypropertiesnotesNextActivityDate = null, WorkflowValue<string> bodypropertiesnumAssociatedContacts = null, WorkflowValue<string> bodypropertiesnumContactedNotes = null, WorkflowValue<string> bodypropertiesnumNotes = null, WorkflowValue<string> bodypropertiespipeline = null)
        {
            WorkflowValue.Validate(dealId, nameof(dealId), required: true);
            WorkflowValue.Validate(bodypropertiesamount, nameof(bodypropertiesamount), required: false);
            WorkflowValue.Validate(bodypropertiesamountInHomeCurrency, nameof(bodypropertiesamountInHomeCurrency), required: false);
            WorkflowValue.Validate(bodypropertiesclosedLostReason, nameof(bodypropertiesclosedLostReason), required: false);
            WorkflowValue.Validate(bodypropertiesclosedWonReason, nameof(bodypropertiesclosedWonReason), required: false);
            WorkflowValue.Validate(bodypropertiesclosedate, nameof(bodypropertiesclosedate), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesdealname, nameof(bodypropertiesdealname), required: false);
            WorkflowValue.Validate(bodypropertiesdealstage, nameof(bodypropertiesdealstage), required: false);
            WorkflowValue.Validate(bodypropertiesdealtype, nameof(bodypropertiesdealtype), required: false);
            WorkflowValue.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBooked, nameof(bodypropertiesengagementsLastMeetingBooked), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedCampaign, nameof(bodypropertiesengagementsLastMeetingBookedCampaign), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedMedium, nameof(bodypropertiesengagementsLastMeetingBookedMedium), required: false);
            WorkflowValue.Validate(bodypropertiesengagementsLastMeetingBookedSource, nameof(bodypropertiesengagementsLastMeetingBookedSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAcv, nameof(bodypropertieshsAcv), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSource, nameof(bodypropertieshsAnalyticsSource), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData1, nameof(bodypropertieshsAnalyticsSourceData1), required: false);
            WorkflowValue.Validate(bodypropertieshsAnalyticsSourceData2, nameof(bodypropertieshsAnalyticsSourceData2), required: false);
            WorkflowValue.Validate(bodypropertieshsArr, nameof(bodypropertieshsArr), required: false);
            WorkflowValue.Validate(bodypropertieshsForecastAmount, nameof(bodypropertieshsForecastAmount), required: false);
            WorkflowValue.Validate(bodypropertieshsForecastProbability, nameof(bodypropertieshsForecastProbability), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsManualForecastCategory, nameof(bodypropertieshsManualForecastCategory), required: false);
            WorkflowValue.Validate(bodypropertieshsMrr, nameof(bodypropertieshsMrr), required: false);
            WorkflowValue.Validate(bodypropertieshsNextStep, nameof(bodypropertieshsNextStep), required: false);
            WorkflowValue.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowValue.Validate(bodypropertieshsPriority, nameof(bodypropertieshsPriority), required: false);
            WorkflowValue.Validate(bodypropertieshsTcv, nameof(bodypropertieshsTcv), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastContacted, nameof(bodypropertiesnotesLastContacted), required: false);
            WorkflowValue.Validate(bodypropertiesnotesLastUpdated, nameof(bodypropertiesnotesLastUpdated), required: false);
            WorkflowValue.Validate(bodypropertiesnotesNextActivityDate, nameof(bodypropertiesnotesNextActivityDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumAssociatedContacts, nameof(bodypropertiesnumAssociatedContacts), required: false);
            WorkflowValue.Validate(bodypropertiesnumContactedNotes, nameof(bodypropertiesnumContactedNotes), required: false);
            WorkflowValue.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowValue.Validate(bodypropertiespipeline, nameof(bodypropertiespipeline), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsList(WorkflowValue<int> limit = null, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsCreate(WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesdescription = null, WorkflowValue<string> bodypropertieshsCostOfGoodsSold = null, WorkflowValue<string> bodypropertieshsCreatedByUserId = null, WorkflowValue<string> bodypropertieshsCreatedate = null, WorkflowValue<string> bodypropertieshsImages = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsObjectId = null, WorkflowValue<string> bodypropertieshsRecurringBillingPeriod = null, WorkflowValue<string> bodypropertieshsSku = null, WorkflowValue<string> bodypropertieshsUpdatedByUserId = null, WorkflowValue<string> bodypropertieshsUrl = null, WorkflowValue<string> bodypropertiesname = null, WorkflowValue<string> bodypropertiesprice = null, WorkflowValue<string> bodypropertiesrecurringbillingfrequency = null, WorkflowValue<string> bodypropertiestax = null)
        {
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesdescription, nameof(bodypropertiesdescription), required: false);
            WorkflowValue.Validate(bodypropertieshsCostOfGoodsSold, nameof(bodypropertieshsCostOfGoodsSold), required: false);
            WorkflowValue.Validate(bodypropertieshsCreatedByUserId, nameof(bodypropertieshsCreatedByUserId), required: false);
            WorkflowValue.Validate(bodypropertieshsCreatedate, nameof(bodypropertieshsCreatedate), required: false);
            WorkflowValue.Validate(bodypropertieshsImages, nameof(bodypropertieshsImages), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsObjectId, nameof(bodypropertieshsObjectId), required: false);
            WorkflowValue.Validate(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            WorkflowValue.Validate(bodypropertieshsSku, nameof(bodypropertieshsSku), required: false);
            WorkflowValue.Validate(bodypropertieshsUpdatedByUserId, nameof(bodypropertieshsUpdatedByUserId), required: false);
            WorkflowValue.Validate(bodypropertieshsUrl, nameof(bodypropertieshsUrl), required: false);
            WorkflowValue.Validate(bodypropertiesname, nameof(bodypropertiesname), required: false);
            WorkflowValue.Validate(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
            WorkflowValue.Validate(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            WorkflowValue.Validate(bodypropertiestax, nameof(bodypropertiestax), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsRead(WorkflowValue<string> productId, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(productId, nameof(productId), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsArchive(WorkflowValue<string> productId)
        {
            WorkflowValue.Validate(productId, nameof(productId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProductsUpdate(WorkflowValue<string> productId, WorkflowValue<string> propertiespropertiescreatedate = null, WorkflowValue<string> propertiespropertiesdescription = null, WorkflowValue<string> propertiespropertieshsCostOfGoodsSold = null, WorkflowValue<string> propertiespropertieshsCreatedByUserId = null, WorkflowValue<string> propertiespropertieshsCreatedate = null, WorkflowValue<string> propertiespropertieshsImages = null, WorkflowValue<string> propertiespropertieshsLastmodifieddate = null, WorkflowValue<string> propertiespropertieshsObjectId = null, WorkflowValue<string> propertiespropertieshsRecurringBillingPeriod = null, WorkflowValue<string> propertiespropertieshsSku = null, WorkflowValue<string> propertiespropertieshsUpdatedByUserId = null, WorkflowValue<string> propertiespropertieshsUrl = null, WorkflowValue<string> propertiespropertiesname = null, WorkflowValue<string> propertiespropertiesprice = null, WorkflowValue<string> propertiespropertiesrecurringbillingfrequency = null, WorkflowValue<string> propertiespropertiestax = null)
        {
            WorkflowValue.Validate(productId, nameof(productId), required: true);
            WorkflowValue.Validate(propertiespropertiescreatedate, nameof(propertiespropertiescreatedate), required: false);
            WorkflowValue.Validate(propertiespropertiesdescription, nameof(propertiespropertiesdescription), required: false);
            WorkflowValue.Validate(propertiespropertieshsCostOfGoodsSold, nameof(propertiespropertieshsCostOfGoodsSold), required: false);
            WorkflowValue.Validate(propertiespropertieshsCreatedByUserId, nameof(propertiespropertieshsCreatedByUserId), required: false);
            WorkflowValue.Validate(propertiespropertieshsCreatedate, nameof(propertiespropertieshsCreatedate), required: false);
            WorkflowValue.Validate(propertiespropertieshsImages, nameof(propertiespropertieshsImages), required: false);
            WorkflowValue.Validate(propertiespropertieshsLastmodifieddate, nameof(propertiespropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(propertiespropertieshsObjectId, nameof(propertiespropertieshsObjectId), required: false);
            WorkflowValue.Validate(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            WorkflowValue.Validate(propertiespropertieshsSku, nameof(propertiespropertieshsSku), required: false);
            WorkflowValue.Validate(propertiespropertieshsUpdatedByUserId, nameof(propertiespropertieshsUpdatedByUserId), required: false);
            WorkflowValue.Validate(propertiespropertieshsUrl, nameof(propertiespropertieshsUrl), required: false);
            WorkflowValue.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            WorkflowValue.Validate(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
            WorkflowValue.Validate(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            WorkflowValue.Validate(propertiespropertiestax, nameof(propertiespropertiestax), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsList(WorkflowValue<int> limit, WorkflowValue<string> properties = null, WorkflowValue<string> associations = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(associations, nameof(associations), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsCreate(WorkflowValue<string> propertiespropertiesname = null, WorkflowValue<string> propertiespropertieshsProductId = null, WorkflowValue<string> propertiespropertieshsRecurringBillingPeriod = null, WorkflowValue<string> propertiespropertiesrecurringbillingfrequency = null, WorkflowValue<string> propertiespropertiesquantity = null, WorkflowValue<string> propertiespropertiesprice = null)
        {
            WorkflowValue.Validate(propertiespropertiesname, nameof(propertiespropertiesname), required: false);
            WorkflowValue.Validate(propertiespropertieshsProductId, nameof(propertiespropertieshsProductId), required: false);
            WorkflowValue.Validate(propertiespropertieshsRecurringBillingPeriod, nameof(propertiespropertieshsRecurringBillingPeriod), required: false);
            WorkflowValue.Validate(propertiespropertiesrecurringbillingfrequency, nameof(propertiespropertiesrecurringbillingfrequency), required: false);
            WorkflowValue.Validate(propertiespropertiesquantity, nameof(propertiespropertiesquantity), required: false);
            WorkflowValue.Validate(propertiespropertiesprice, nameof(propertiespropertiesprice), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsRead(WorkflowValue<string> lineItemId, WorkflowValue<string> properties = null, WorkflowValue<string> associations = null, WorkflowValue<string> idProperty = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(associations, nameof(associations), required: false);
            WorkflowValue.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsArchive(WorkflowValue<string> lineItemId)
        {
            WorkflowValue.Validate(lineItemId, nameof(lineItemId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLineItemsUpdate(WorkflowValue<string> lineItemId, WorkflowValue<string> idProperty = null, WorkflowValue<string> bodypropertiesname = null, WorkflowValue<string> bodypropertieshsProductId = null, WorkflowValue<string> bodypropertieshsRecurringBillingPeriod = null, WorkflowValue<string> bodypropertiesrecurringbillingfrequency = null, WorkflowValue<string> bodypropertiesquantity = null, WorkflowValue<string> bodypropertiesprice = null)
        {
            WorkflowValue.Validate(lineItemId, nameof(lineItemId), required: true);
            WorkflowValue.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowValue.Validate(bodypropertiesname, nameof(bodypropertiesname), required: false);
            WorkflowValue.Validate(bodypropertieshsProductId, nameof(bodypropertieshsProductId), required: false);
            WorkflowValue.Validate(bodypropertieshsRecurringBillingPeriod, nameof(bodypropertieshsRecurringBillingPeriod), required: false);
            WorkflowValue.Validate(bodypropertiesrecurringbillingfrequency, nameof(bodypropertiesrecurringbillingfrequency), required: false);
            WorkflowValue.Validate(bodypropertiesquantity, nameof(bodypropertiesquantity), required: false);
            WorkflowValue.Validate(bodypropertiesprice, nameof(bodypropertiesprice), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsList(WorkflowValue<int> limit = null, WorkflowValue<string> properties = null, WorkflowValue<string> associations = null, WorkflowValue<bool> archived = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(associations, nameof(associations), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsCreate(WorkflowValue<string> bodypropertiesclosedDate = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesfirstAgentReplyDate = null, WorkflowValue<string> bodypropertieshsFeedbackLastCesFollowUp = null, WorkflowValue<string> bodypropertieshsFeedbackLastCesRating = null, WorkflowValue<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowValue<string> bodypropertieshsLastactivitydate = null, WorkflowValue<string> bodypropertieshsLastcontacted = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsNextactivitydate = null, WorkflowValue<string> bodypropertieshsNumTimesContacted = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieslastReplyDate = null, WorkflowValue<string> bodypropertiesnumNotes = null, WorkflowValue<string> bodypropertiestimeToClose = null, WorkflowValue<string> bodypropertiestimeToFirstAgentReply = null, WorkflowValue<string> bodypropertiescontent = null, WorkflowValue<string> bodypropertieshsFileUpload = null, WorkflowValue<string> bodypropertieshsNumAssociatedCompanies = null, WorkflowValue<string> bodypropertieshsPipeline = null, WorkflowValue<string> bodypropertieshsPipelineStage = null, WorkflowValue<string> bodypropertieshsResolution = null, WorkflowValue<string> bodypropertieshsTicketCategory = null, WorkflowValue<string> bodypropertieshsTicketId = null, WorkflowValue<string> bodypropertieshsTicketPriority = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertiessourceType = null, WorkflowValue<string> bodypropertiessubject = null)
        {
            WorkflowValue.Validate(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            WorkflowValue.Validate(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowValue.Validate(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            WorkflowValue.Validate(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            WorkflowValue.Validate(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            WorkflowValue.Validate(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            WorkflowValue.Validate(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            WorkflowValue.Validate(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            WorkflowValue.Validate(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            WorkflowValue.Validate(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            WorkflowValue.Validate(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsRead(WorkflowValue<string> ticketId, WorkflowValue<string> properties = null, WorkflowValue<bool> archived = null, WorkflowValue<string> idProperty = null)
        {
            WorkflowValue.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowValue.Validate(properties, nameof(properties), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
            WorkflowValue.Validate(idProperty, nameof(idProperty), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsArchive(WorkflowValue<string> ticketId)
        {
            WorkflowValue.Validate(ticketId, nameof(ticketId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTicketsUpdate(WorkflowValue<string> ticketId, WorkflowValue<string> idProperty = null, WorkflowValue<string> bodypropertiesclosedDate = null, WorkflowValue<string> bodypropertiescreatedate = null, WorkflowValue<string> bodypropertiesfirstAgentReplyDate = null, WorkflowValue<string> bodypropertieshsFeedbackLastCesFollowUp = null, WorkflowValue<string> bodypropertieshsFeedbackLastCesRating = null, WorkflowValue<string> bodypropertieshsFeedbackLastSurveyDate = null, WorkflowValue<string> bodypropertieshsLastactivitydate = null, WorkflowValue<string> bodypropertieshsLastcontacted = null, WorkflowValue<string> bodypropertieshsLastmodifieddate = null, WorkflowValue<string> bodypropertieshsNextactivitydate = null, WorkflowValue<string> bodypropertieshsNumTimesContacted = null, WorkflowValue<string> bodypropertieshubspotOwnerAssigneddate = null, WorkflowValue<string> bodypropertieslastReplyDate = null, WorkflowValue<string> bodypropertiesnumNotes = null, WorkflowValue<string> bodypropertiestimeToClose = null, WorkflowValue<string> bodypropertiestimeToFirstAgentReply = null, WorkflowValue<string> bodypropertiescontent = null, WorkflowValue<string> bodypropertieshsFileUpload = null, WorkflowValue<string> bodypropertieshsNumAssociatedCompanies = null, WorkflowValue<string> bodypropertieshsPipeline = null, WorkflowValue<string> bodypropertieshsPipelineStage = null, WorkflowValue<string> bodypropertieshsResolution = null, WorkflowValue<string> bodypropertieshsTicketCategory = null, WorkflowValue<string> bodypropertieshsTicketId = null, WorkflowValue<string> bodypropertieshsTicketPriority = null, WorkflowValue<string> bodypropertieshubspotOwnerId = null, WorkflowValue<string> bodypropertieshubspotTeamId = null, WorkflowValue<string> bodypropertiessourceType = null, WorkflowValue<string> bodypropertiessubject = null)
        {
            WorkflowValue.Validate(ticketId, nameof(ticketId), required: true);
            WorkflowValue.Validate(idProperty, nameof(idProperty), required: false);
            WorkflowValue.Validate(bodypropertiesclosedDate, nameof(bodypropertiesclosedDate), required: false);
            WorkflowValue.Validate(bodypropertiescreatedate, nameof(bodypropertiescreatedate), required: false);
            WorkflowValue.Validate(bodypropertiesfirstAgentReplyDate, nameof(bodypropertiesfirstAgentReplyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastCesFollowUp, nameof(bodypropertieshsFeedbackLastCesFollowUp), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastCesRating, nameof(bodypropertieshsFeedbackLastCesRating), required: false);
            WorkflowValue.Validate(bodypropertieshsFeedbackLastSurveyDate, nameof(bodypropertieshsFeedbackLastSurveyDate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastactivitydate, nameof(bodypropertieshsLastactivitydate), required: false);
            WorkflowValue.Validate(bodypropertieshsLastcontacted, nameof(bodypropertieshsLastcontacted), required: false);
            WorkflowValue.Validate(bodypropertieshsLastmodifieddate, nameof(bodypropertieshsLastmodifieddate), required: false);
            WorkflowValue.Validate(bodypropertieshsNextactivitydate, nameof(bodypropertieshsNextactivitydate), required: false);
            WorkflowValue.Validate(bodypropertieshsNumTimesContacted, nameof(bodypropertieshsNumTimesContacted), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerAssigneddate, nameof(bodypropertieshubspotOwnerAssigneddate), required: false);
            WorkflowValue.Validate(bodypropertieslastReplyDate, nameof(bodypropertieslastReplyDate), required: false);
            WorkflowValue.Validate(bodypropertiesnumNotes, nameof(bodypropertiesnumNotes), required: false);
            WorkflowValue.Validate(bodypropertiestimeToClose, nameof(bodypropertiestimeToClose), required: false);
            WorkflowValue.Validate(bodypropertiestimeToFirstAgentReply, nameof(bodypropertiestimeToFirstAgentReply), required: false);
            WorkflowValue.Validate(bodypropertiescontent, nameof(bodypropertiescontent), required: false);
            WorkflowValue.Validate(bodypropertieshsFileUpload, nameof(bodypropertieshsFileUpload), required: false);
            WorkflowValue.Validate(bodypropertieshsNumAssociatedCompanies, nameof(bodypropertieshsNumAssociatedCompanies), required: false);
            WorkflowValue.Validate(bodypropertieshsPipeline, nameof(bodypropertieshsPipeline), required: false);
            WorkflowValue.Validate(bodypropertieshsPipelineStage, nameof(bodypropertieshsPipelineStage), required: false);
            WorkflowValue.Validate(bodypropertieshsResolution, nameof(bodypropertieshsResolution), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketCategory, nameof(bodypropertieshsTicketCategory), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketId, nameof(bodypropertieshsTicketId), required: false);
            WorkflowValue.Validate(bodypropertieshsTicketPriority, nameof(bodypropertieshsTicketPriority), required: false);
            WorkflowValue.Validate(bodypropertieshubspotOwnerId, nameof(bodypropertieshubspotOwnerId), required: false);
            WorkflowValue.Validate(bodypropertieshubspotTeamId, nameof(bodypropertieshubspotTeamId), required: false);
            WorkflowValue.Validate(bodypropertiessourceType, nameof(bodypropertiessourceType), required: false);
            WorkflowValue.Validate(bodypropertiessubject, nameof(bodypropertiessubject), required: false);
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
