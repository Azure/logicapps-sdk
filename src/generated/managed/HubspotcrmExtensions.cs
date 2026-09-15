//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcrm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/companies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesCreate(Expression<Func<string>> bodypropertiesname, Expression<Func<string>> bodypropertiesaboutUs = null, Expression<Func<string>> bodypropertiesaddress = null, Expression<Func<string>> bodypropertiesaddress2 = null, Expression<Func<string>> bodypropertiesannualrevenue = null, Expression<Func<string>> bodypropertiescity = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescountry = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdaysToClose = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesdomain = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertiesfacebookCompanyPage = null, Expression<Func<string>> bodypropertiesfacebookfans = null, Expression<Func<string>> bodypropertiesfirstContactCreatedate = null, Expression<Func<string>> bodypropertiesfirstConversionDate = null, Expression<Func<string>> bodypropertiesfirstConversionEventName = null, Expression<Func<string>> bodypropertiesfirstDealCreatedDate = null, Expression<Func<string>> bodypropertiesfoundedYear = null, Expression<Func<string>> bodypropertiesgoogleplusPage = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsNumVisits = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsIdealCustomerProfile = null, Expression<Func<string>> bodypropertieshsIsTargetAccount = null, Expression<Func<string>> bodypropertieshsLastBookedMeetingDate = null, Expression<Func<string>> bodypropertieshsLastLoggedCallDate = null, Expression<Func<string>> bodypropertieshsLastOpenTaskDate = null, Expression<Func<string>> bodypropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsLeadStatus = null, Expression<Func<string>> bodypropertieshsNumBlockers = null, Expression<Func<string>> bodypropertieshsNumChildCompanies = null, Expression<Func<string>> bodypropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> bodypropertieshsNumDecisionMakers = null, Expression<Func<string>> bodypropertieshsNumOpenDeals = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsParentCompanyId = null, Expression<Func<string>> bodypropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> bodypropertieshsTotalDealValue = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesindustry = null, Expression<Func<string>> bodypropertiesisPublic = null, Expression<Func<string>> bodypropertieslifecyclestage = null, Expression<Func<string>> bodypropertieslinkedinCompanyPage = null, Expression<Func<string>> bodypropertieslinkedinbio = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumAssociatedDeals = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumConversionEvents = null, Expression<Func<string>> bodypropertiesnumberofemployees = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiesrecentConversionDate = null, Expression<Func<string>> bodypropertiesrecentConversionEventName = null, Expression<Func<string>> bodypropertiesrecentDealAmount = null, Expression<Func<string>> bodypropertiesrecentDealCloseDate = null, Expression<Func<string>> bodypropertiesstate = null, Expression<Func<string>> bodypropertiestimezone = null, Expression<Func<string>> bodypropertiestotalMoneyRaised = null, Expression<Func<string>> bodypropertiestotalRevenue = null, Expression<Func<string>> bodypropertiestwitterbio = null, Expression<Func<string>> bodypropertiestwitterfollowers = null, Expression<Func<string>> bodypropertiestwitterhandle = null, Expression<Func<string>> bodypropertiestype = null, Expression<Func<string>> bodypropertieswebTechnologies = null, Expression<Func<string>> bodypropertieswebsite = null, Expression<Func<string>> bodypropertieszip = null)
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
                propertiesObject["about_us"] = CSharpExpressionConverter.ConvertToken(bodypropertiesaboutUs);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesaddress != null)
            {
                propertiesObject["address"] = CSharpExpressionConverter.ConvertToken(bodypropertiesaddress);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesaddress2 != null)
            {
                propertiesObject["address2"] = CSharpExpressionConverter.ConvertToken(bodypropertiesaddress2);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesannualrevenue != null)
            {
                propertiesObject["annualrevenue"] = CSharpExpressionConverter.ConvertToken(bodypropertiesannualrevenue);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescity != null)
            {
                propertiesObject["city"] = CSharpExpressionConverter.ConvertToken(bodypropertiescity);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescountry != null)
            {
                propertiesObject["country"] = CSharpExpressionConverter.ConvertToken(bodypropertiescountry);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdaysToClose != null)
            {
                propertiesObject["days_to_close"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdaysToClose);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdomain != null)
            {
                propertiesObject["domain"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdomain);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfacebookCompanyPage != null)
            {
                propertiesObject["facebook_company_page"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfacebookCompanyPage);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfacebookfans != null)
            {
                propertiesObject["facebookfans"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfacebookfans);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstContactCreatedate != null)
            {
                propertiesObject["first_contact_createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstContactCreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstConversionDate != null)
            {
                propertiesObject["first_conversion_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstConversionDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstConversionEventName != null)
            {
                propertiesObject["first_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstConversionEventName);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstDealCreatedDate != null)
            {
                propertiesObject["first_deal_created_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstDealCreatedDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfoundedYear != null)
            {
                propertiesObject["founded_year"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfoundedYear);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesgoogleplusPage != null)
            {
                propertiesObject["googleplus_page"] = CSharpExpressionConverter.ConvertToken(bodypropertiesgoogleplusPage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstTimestamp != null)
            {
                propertiesObject["hs_analytics_first_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_first_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_first_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastTimestamp != null)
            {
                propertiesObject["hs_analytics_last_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_last_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_last_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsNumPageViews != null)
            {
                propertiesObject["hs_analytics_num_page_views"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumPageViews);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsNumVisits != null)
            {
                propertiesObject["hs_analytics_num_visits"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumVisits);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsIdealCustomerProfile != null)
            {
                propertiesObject["hs_ideal_customer_profile"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsIdealCustomerProfile);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsIsTargetAccount != null)
            {
                propertiesObject["hs_is_target_account"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsIsTargetAccount);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastBookedMeetingDate != null)
            {
                propertiesObject["hs_last_booked_meeting_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastBookedMeetingDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastLoggedCallDate != null)
            {
                propertiesObject["hs_last_logged_call_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastLoggedCallDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastOpenTaskDate != null)
            {
                propertiesObject["hs_last_open_task_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastOpenTaskDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastSalesActivityTimestamp != null)
            {
                propertiesObject["hs_last_sales_activity_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastSalesActivityTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLeadStatus != null)
            {
                propertiesObject["hs_lead_status"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLeadStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumBlockers != null)
            {
                propertiesObject["hs_num_blockers"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumBlockers);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumChildCompanies != null)
            {
                propertiesObject["hs_num_child_companies"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumChildCompanies);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumContactsWithBuyingRoles != null)
            {
                propertiesObject["hs_num_contacts_with_buying_roles"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumContactsWithBuyingRoles);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumDecisionMakers != null)
            {
                propertiesObject["hs_num_decision_makers"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumDecisionMakers);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumOpenDeals != null)
            {
                propertiesObject["hs_num_open_deals"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumOpenDeals);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsParentCompanyId != null)
            {
                propertiesObject["hs_parent_company_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsParentCompanyId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPredictivecontactscoreV2 != null)
            {
                propertiesObject["hs_predictivecontactscore_v2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscoreV2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTotalDealValue != null)
            {
                propertiesObject["hs_total_deal_value"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTotalDealValue);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesindustry != null)
            {
                propertiesObject["industry"] = CSharpExpressionConverter.ConvertToken(bodypropertiesindustry);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesisPublic != null)
            {
                propertiesObject["is_public"] = CSharpExpressionConverter.ConvertToken(bodypropertiesisPublic);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslifecyclestage != null)
            {
                propertiesObject["lifecyclestage"] = CSharpExpressionConverter.ConvertToken(bodypropertieslifecyclestage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslinkedinCompanyPage != null)
            {
                propertiesObject["linkedin_company_page"] = CSharpExpressionConverter.ConvertToken(bodypropertieslinkedinCompanyPage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslinkedinbio != null)
            {
                propertiesObject["linkedinbio"] = CSharpExpressionConverter.ConvertToken(bodypropertieslinkedinbio);
                propertiesObjectpropCount++;
            }

            propertiesObjectpropCount++;
            propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesname);
            if (bodypropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumAssociatedContacts != null)
            {
                propertiesObject["num_associated_contacts"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumAssociatedDeals != null)
            {
                propertiesObject["num_associated_deals"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumAssociatedDeals);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumConversionEvents != null)
            {
                propertiesObject["num_conversion_events"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumConversionEvents);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumberofemployees != null)
            {
                propertiesObject["numberofemployees"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumberofemployees);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesphone != null)
            {
                propertiesObject["phone"] = CSharpExpressionConverter.ConvertToken(bodypropertiesphone);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentConversionDate != null)
            {
                propertiesObject["recent_conversion_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentConversionDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentConversionEventName != null)
            {
                propertiesObject["recent_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentConversionEventName);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentDealAmount != null)
            {
                propertiesObject["recent_deal_amount"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentDealAmount);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentDealCloseDate != null)
            {
                propertiesObject["recent_deal_close_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentDealCloseDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesstate != null)
            {
                propertiesObject["state"] = CSharpExpressionConverter.ConvertToken(bodypropertiesstate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimezone != null)
            {
                propertiesObject["timezone"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimezone);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestotalMoneyRaised != null)
            {
                propertiesObject["total_money_raised"] = CSharpExpressionConverter.ConvertToken(bodypropertiestotalMoneyRaised);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestotalRevenue != null)
            {
                propertiesObject["total_revenue"] = CSharpExpressionConverter.ConvertToken(bodypropertiestotalRevenue);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestwitterbio != null)
            {
                propertiesObject["twitterbio"] = CSharpExpressionConverter.ConvertToken(bodypropertiestwitterbio);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestwitterfollowers != null)
            {
                propertiesObject["twitterfollowers"] = CSharpExpressionConverter.ConvertToken(bodypropertiestwitterfollowers);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestwitterhandle != null)
            {
                propertiesObject["twitterhandle"] = CSharpExpressionConverter.ConvertToken(bodypropertiestwitterhandle);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestype != null)
            {
                propertiesObject["type"] = CSharpExpressionConverter.ConvertToken(bodypropertiestype);
                propertiesObjectpropCount++;
            }

            if (bodypropertieswebTechnologies != null)
            {
                propertiesObject["web_technologies"] = CSharpExpressionConverter.ConvertToken(bodypropertieswebTechnologies);
                propertiesObjectpropCount++;
            }

            if (bodypropertieswebsite != null)
            {
                propertiesObject["website"] = CSharpExpressionConverter.ConvertToken(bodypropertieswebsite);
                propertiesObjectpropCount++;
            }

            if (bodypropertieszip != null)
            {
                propertiesObject["zip"] = CSharpExpressionConverter.ConvertToken(bodypropertieszip);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesRead(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesArchive(Expression<Func<string>> companyId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesUpdate(Expression<Func<string>> companyId, Expression<Func<string>> propertiespropertiesname, Expression<Func<string>> propertiespropertiesaboutUs = null, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesaddress2 = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertiesdomain = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfacebookCompanyPage = null, Expression<Func<string>> propertiespropertiesfacebookfans = null, Expression<Func<string>> propertiespropertiesfirstContactCreatedate = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfoundedYear = null, Expression<Func<string>> propertiespropertiesgoogleplusPage = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsIdealCustomerProfile = null, Expression<Func<string>> propertiespropertieshsIsTargetAccount = null, Expression<Func<string>> propertiespropertieshsLastBookedMeetingDate = null, Expression<Func<string>> propertiespropertieshsLastLoggedCallDate = null, Expression<Func<string>> propertiespropertieshsLastOpenTaskDate = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsNumBlockers = null, Expression<Func<string>> propertiespropertieshsNumChildCompanies = null, Expression<Func<string>> propertiespropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> propertiespropertieshsNumDecisionMakers = null, Expression<Func<string>> propertiespropertieshsNumOpenDeals = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsParentCompanyId = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsTotalDealValue = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesisPublic = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertieslinkedinCompanyPage = null, Expression<Func<string>> propertiespropertieslinkedinbio = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedContacts = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumberofemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestimezone = null, Expression<Func<string>> propertiespropertiestotalMoneyRaised = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterbio = null, Expression<Func<string>> propertiespropertiestwitterfollowers = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertiestype = null, Expression<Func<string>> propertiespropertieswebTechnologies = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var properties = new JObject();
            var propertiespropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiespropertiesaboutUs != null)
            {
                propertiesObject["about_us"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesaboutUs);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesaddress != null)
            {
                propertiesObject["address"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesaddress);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesaddress2 != null)
            {
                propertiesObject["address2"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesaddress2);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesannualrevenue != null)
            {
                propertiesObject["annualrevenue"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesannualrevenue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescity != null)
            {
                propertiesObject["city"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescity);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescountry != null)
            {
                propertiesObject["country"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescountry);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdaysToClose != null)
            {
                propertiesObject["days_to_close"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdaysToClose);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdomain != null)
            {
                propertiesObject["domain"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdomain);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfacebookCompanyPage != null)
            {
                propertiesObject["facebook_company_page"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfacebookCompanyPage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfacebookfans != null)
            {
                propertiesObject["facebookfans"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfacebookfans);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstContactCreatedate != null)
            {
                propertiesObject["first_contact_createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstContactCreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstConversionDate != null)
            {
                propertiesObject["first_conversion_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstConversionDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstConversionEventName != null)
            {
                propertiesObject["first_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstConversionEventName);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstDealCreatedDate != null)
            {
                propertiesObject["first_deal_created_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstDealCreatedDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfoundedYear != null)
            {
                propertiesObject["founded_year"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfoundedYear);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesgoogleplusPage != null)
            {
                propertiesObject["googleplus_page"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesgoogleplusPage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstTimestamp != null)
            {
                propertiesObject["hs_analytics_first_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_first_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_first_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastTimestamp != null)
            {
                propertiesObject["hs_analytics_last_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_last_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_last_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsNumPageViews != null)
            {
                propertiesObject["hs_analytics_num_page_views"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumPageViews);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsNumVisits != null)
            {
                propertiesObject["hs_analytics_num_visits"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumVisits);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsIdealCustomerProfile != null)
            {
                propertiesObject["hs_ideal_customer_profile"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsIdealCustomerProfile);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsIsTargetAccount != null)
            {
                propertiesObject["hs_is_target_account"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsIsTargetAccount);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastBookedMeetingDate != null)
            {
                propertiesObject["hs_last_booked_meeting_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastBookedMeetingDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastLoggedCallDate != null)
            {
                propertiesObject["hs_last_logged_call_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastLoggedCallDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastOpenTaskDate != null)
            {
                propertiesObject["hs_last_open_task_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastOpenTaskDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastSalesActivityTimestamp != null)
            {
                propertiesObject["hs_last_sales_activity_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastSalesActivityTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLeadStatus != null)
            {
                propertiesObject["hs_lead_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLeadStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsNumBlockers != null)
            {
                propertiesObject["hs_num_blockers"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsNumBlockers);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsNumChildCompanies != null)
            {
                propertiesObject["hs_num_child_companies"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsNumChildCompanies);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsNumContactsWithBuyingRoles != null)
            {
                propertiesObject["hs_num_contacts_with_buying_roles"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsNumContactsWithBuyingRoles);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsNumDecisionMakers != null)
            {
                propertiesObject["hs_num_decision_makers"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsNumDecisionMakers);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsNumOpenDeals != null)
            {
                propertiesObject["hs_num_open_deals"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsNumOpenDeals);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsParentCompanyId != null)
            {
                propertiesObject["hs_parent_company_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsParentCompanyId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPredictivecontactscoreV2 != null)
            {
                propertiesObject["hs_predictivecontactscore_v2"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscoreV2);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTotalDealValue != null)
            {
                propertiesObject["hs_total_deal_value"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTotalDealValue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesindustry != null)
            {
                propertiesObject["industry"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesindustry);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesisPublic != null)
            {
                propertiesObject["is_public"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesisPublic);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslifecyclestage != null)
            {
                propertiesObject["lifecyclestage"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslifecyclestage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslinkedinCompanyPage != null)
            {
                propertiesObject["linkedin_company_page"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslinkedinCompanyPage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslinkedinbio != null)
            {
                propertiesObject["linkedinbio"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslinkedinbio);
                propertiesObjectpropCount++;
            }

            propertiesObjectpropCount++;
            propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesname);
            if (propertiespropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumAssociatedContacts != null)
            {
                propertiesObject["num_associated_contacts"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedContacts);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumAssociatedDeals != null)
            {
                propertiesObject["num_associated_deals"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedDeals);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumConversionEvents != null)
            {
                propertiesObject["num_conversion_events"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumConversionEvents);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumberofemployees != null)
            {
                propertiesObject["numberofemployees"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumberofemployees);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesphone != null)
            {
                propertiesObject["phone"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesphone);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentConversionDate != null)
            {
                propertiesObject["recent_conversion_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentConversionDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentConversionEventName != null)
            {
                propertiesObject["recent_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentConversionEventName);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentDealAmount != null)
            {
                propertiesObject["recent_deal_amount"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentDealAmount);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentDealCloseDate != null)
            {
                propertiesObject["recent_deal_close_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentDealCloseDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesstate != null)
            {
                propertiesObject["state"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesstate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestimezone != null)
            {
                propertiesObject["timezone"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestimezone);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestotalMoneyRaised != null)
            {
                propertiesObject["total_money_raised"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestotalMoneyRaised);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestotalRevenue != null)
            {
                propertiesObject["total_revenue"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestotalRevenue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestwitterbio != null)
            {
                propertiesObject["twitterbio"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestwitterbio);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestwitterfollowers != null)
            {
                propertiesObject["twitterfollowers"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestwitterfollowers);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestwitterhandle != null)
            {
                propertiesObject["twitterhandle"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestwitterhandle);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestype != null)
            {
                propertiesObject["type"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestype);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieswebTechnologies != null)
            {
                propertiesObject["web_technologies"] = CSharpExpressionConverter.ConvertToken(propertiespropertieswebTechnologies);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieswebsite != null)
            {
                propertiesObject["website"] = CSharpExpressionConverter.ConvertToken(propertiespropertieswebsite);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieszip != null)
            {
                propertiesObject["zip"] = CSharpExpressionConverter.ConvertToken(propertiespropertieszip);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (properties != null)
                callPayload.Queries["properties[]"] = CSharpExpressionConverter.ConvertO(properties);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsCreate(Expression<Func<string>> bodypropertiesaddress = null, Expression<Func<string>> bodypropertiesannualrevenue = null, Expression<Func<string>> bodypropertiescity = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescompany = null, Expression<Func<string>> bodypropertiescompanySize = null, Expression<Func<string>> bodypropertiescountry = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiescurrentlyinworkflow = null, Expression<Func<string>> bodypropertiesdateOfBirth = null, Expression<Func<string>> bodypropertiesdaysToClose = null, Expression<Func<string>> bodypropertiesdegree = null, Expression<Func<string>> bodypropertiesemail = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertiesfax = null, Expression<Func<string>> bodypropertiesfieldOfStudy = null, Expression<Func<string>> bodypropertiesfirstConversionDate = null, Expression<Func<string>> bodypropertiesfirstConversionEventName = null, Expression<Func<string>> bodypropertiesfirstDealCreatedDate = null, Expression<Func<string>> bodypropertiesfirstname = null, Expression<Func<string>> bodypropertiesgender = null, Expression<Func<string>> bodypropertiesgraduationDate = null, Expression<Func<string>> bodypropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> bodypropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> bodypropertieshsAnalyticsLastUrl = null, Expression<Func<string>> bodypropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> bodypropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> bodypropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> bodypropertieshsAnalyticsNumVisits = null, Expression<Func<string>> bodypropertieshsAnalyticsRevenue = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsBuyingRole = null, Expression<Func<string>> bodypropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> bodypropertieshsContentMembershipNotes = null, Expression<Func<string>> bodypropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> bodypropertieshsContentMembershipStatus = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsEmailBadAddress = null, Expression<Func<string>> bodypropertieshsEmailBounce = null, Expression<Func<string>> bodypropertieshsEmailClick = null, Expression<Func<string>> bodypropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> bodypropertieshsEmailDelivered = null, Expression<Func<string>> bodypropertieshsEmailDomain = null, Expression<Func<string>> bodypropertieshsEmailFirstClickDate = null, Expression<Func<string>> bodypropertieshsEmailFirstOpenDate = null, Expression<Func<string>> bodypropertieshsEmailFirstReplyDate = null, Expression<Func<string>> bodypropertieshsEmailFirstSendDate = null, Expression<Func<string>> bodypropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> bodypropertieshsEmailLastClickDate = null, Expression<Func<string>> bodypropertieshsEmailLastEmailName = null, Expression<Func<string>> bodypropertieshsEmailLastOpenDate = null, Expression<Func<string>> bodypropertieshsEmailLastReplyDate = null, Expression<Func<string>> bodypropertieshsEmailLastSendDate = null, Expression<Func<string>> bodypropertieshsEmailOpen = null, Expression<Func<string>> bodypropertieshsEmailOptout = null, Expression<Func<string>> bodypropertieshsEmailOptout12592317 = null, Expression<Func<string>> bodypropertieshsEmailQuarantined = null, Expression<Func<string>> bodypropertieshsEmailQuarantinedReason = null, Expression<Func<string>> bodypropertieshsEmailReplied = null, Expression<Func<string>> bodypropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> bodypropertieshsEmailconfirmationstatus = null, Expression<Func<string>> bodypropertieshsFacebookClickId = null, Expression<Func<string>> bodypropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsGoogleClickId = null, Expression<Func<string>> bodypropertieshsIpTimezone = null, Expression<Func<string>> bodypropertieshsIsUnworked = null, Expression<Func<string>> bodypropertieshsLanguage = null, Expression<Func<string>> bodypropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> bodypropertieshsLeadStatus = null, Expression<Func<string>> bodypropertieshsLegalBasis = null, Expression<Func<string>> bodypropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> bodypropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> bodypropertieshsMarketableReasonId = null, Expression<Func<string>> bodypropertieshsMarketableReasonType = null, Expression<Func<string>> bodypropertieshsMarketableStatus = null, Expression<Func<string>> bodypropertieshsMarketableUntilRenewal = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPersona = null, Expression<Func<string>> bodypropertieshsPredictivecontactscore = null, Expression<Func<string>> bodypropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> bodypropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> bodypropertieshsPredictivescoringtier = null, Expression<Func<string>> bodypropertieshsSalesEmailLastClicked = null, Expression<Func<string>> bodypropertieshsSalesEmailLastOpened = null, Expression<Func<string>> bodypropertieshsSalesEmailLastReplied = null, Expression<Func<string>> bodypropertieshsSequencesIsEnrolled = null, Expression<Func<string>> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertieshubspotscore = null, Expression<Func<string>> bodypropertiesindustry = null, Expression<Func<string>> bodypropertiesipCity = null, Expression<Func<string>> bodypropertiesipCountry = null, Expression<Func<string>> bodypropertiesipCountryCode = null, Expression<Func<string>> bodypropertiesipState = null, Expression<Func<string>> bodypropertiesipStateCode = null, Expression<Func<string>> bodypropertiesjobFunction = null, Expression<Func<string>> bodypropertiesjobtitle = null, Expression<Func<string>> bodypropertieslastmodifieddate = null, Expression<Func<string>> bodypropertieslastname = null, Expression<Func<string>> bodypropertieslifecyclestage = null, Expression<Func<string>> bodypropertiesmaritalStatus = null, Expression<Func<string>> bodypropertiesmessage = null, Expression<Func<string>> bodypropertiesmilitaryStatus = null, Expression<Func<string>> bodypropertiesmobilephone = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedDeals = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumConversionEvents = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiesnumUniqueConversionEvents = null, Expression<Func<string>> bodypropertiesnumemployees = null, Expression<Func<string>> bodypropertiesphone = null, Expression<Func<string>> bodypropertiesrecentConversionDate = null, Expression<Func<string>> bodypropertiesrecentConversionEventName = null, Expression<Func<string>> bodypropertiesrecentDealAmount = null, Expression<Func<string>> bodypropertiesrecentDealCloseDate = null, Expression<Func<string>> bodypropertiesrelationshipStatus = null, Expression<Func<string>> bodypropertiessalutation = null, Expression<Func<string>> bodypropertiesschool = null, Expression<Func<string>> bodypropertiesseniority = null, Expression<Func<string>> bodypropertiesstartDate = null, Expression<Func<string>> bodypropertiesstate = null, Expression<Func<string>> bodypropertiestotalRevenue = null, Expression<Func<string>> bodypropertiestwitterhandle = null, Expression<Func<string>> bodypropertieswebsite = null, Expression<Func<string>> bodypropertiesworkEmail = null, Expression<Func<string>> bodypropertieszip = null)
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
                propertiesObject["address"] = CSharpExpressionConverter.ConvertToken(bodypropertiesaddress);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesannualrevenue != null)
            {
                propertiesObject["annualrevenue"] = CSharpExpressionConverter.ConvertToken(bodypropertiesannualrevenue);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescity != null)
            {
                propertiesObject["city"] = CSharpExpressionConverter.ConvertToken(bodypropertiescity);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescompany != null)
            {
                propertiesObject["company"] = CSharpExpressionConverter.ConvertToken(bodypropertiescompany);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescompanySize != null)
            {
                propertiesObject["company_size"] = CSharpExpressionConverter.ConvertToken(bodypropertiescompanySize);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescountry != null)
            {
                propertiesObject["country"] = CSharpExpressionConverter.ConvertToken(bodypropertiescountry);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescurrentlyinworkflow != null)
            {
                propertiesObject["currentlyinworkflow"] = CSharpExpressionConverter.ConvertToken(bodypropertiescurrentlyinworkflow);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdateOfBirth != null)
            {
                propertiesObject["date_of_birth"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdateOfBirth);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdaysToClose != null)
            {
                propertiesObject["days_to_close"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdaysToClose);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdegree != null)
            {
                propertiesObject["degree"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdegree);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesemail != null)
            {
                propertiesObject["email"] = CSharpExpressionConverter.ConvertToken(bodypropertiesemail);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfax != null)
            {
                propertiesObject["fax"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfax);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfieldOfStudy != null)
            {
                propertiesObject["field_of_study"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfieldOfStudy);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstConversionDate != null)
            {
                propertiesObject["first_conversion_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstConversionDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstConversionEventName != null)
            {
                propertiesObject["first_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstConversionEventName);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstDealCreatedDate != null)
            {
                propertiesObject["first_deal_created_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstDealCreatedDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstname != null)
            {
                propertiesObject["firstname"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstname);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesgender != null)
            {
                propertiesObject["gender"] = CSharpExpressionConverter.ConvertToken(bodypropertiesgender);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesgraduationDate != null)
            {
                propertiesObject["graduation_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesgraduationDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsAveragePageViews != null)
            {
                propertiesObject["hs_analytics_average_page_views"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsAveragePageViews);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstReferrer != null)
            {
                propertiesObject["hs_analytics_first_referrer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstReferrer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstTimestamp != null)
            {
                propertiesObject["hs_analytics_first_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_first_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstUrl != null)
            {
                propertiesObject["hs_analytics_first_url"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstUrl);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_first_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastReferrer != null)
            {
                propertiesObject["hs_analytics_last_referrer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastReferrer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastTimestamp != null)
            {
                propertiesObject["hs_analytics_last_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_last_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastUrl != null)
            {
                propertiesObject["hs_analytics_last_url"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastUrl);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_last_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsNumEventCompletions != null)
            {
                propertiesObject["hs_analytics_num_event_completions"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumEventCompletions);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsNumPageViews != null)
            {
                propertiesObject["hs_analytics_num_page_views"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumPageViews);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsNumVisits != null)
            {
                propertiesObject["hs_analytics_num_visits"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumVisits);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsRevenue != null)
            {
                propertiesObject["hs_analytics_revenue"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsRevenue);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsBuyingRole != null)
            {
                propertiesObject["hs_buying_role"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsBuyingRole);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipEmailConfirmed != null)
            {
                propertiesObject["hs_content_membership_email_confirmed"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipEmailConfirmed);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipNotes != null)
            {
                propertiesObject["hs_content_membership_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipRegisteredAt != null)
            {
                propertiesObject["hs_content_membership_registered_at"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegisteredAt);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipRegistrationDomainSentTo != null)
            {
                propertiesObject["hs_content_membership_registration_domain_sent_to"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegistrationDomainSentTo);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipRegistrationEmailSentAt != null)
            {
                propertiesObject["hs_content_membership_registration_email_sent_at"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegistrationEmailSentAt);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsContentMembershipStatus != null)
            {
                propertiesObject["hs_content_membership_status"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsContentMembershipStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailBadAddress != null)
            {
                propertiesObject["hs_email_bad_address"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailBadAddress);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailBounce != null)
            {
                propertiesObject["hs_email_bounce"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailBounce);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailClick != null)
            {
                propertiesObject["hs_email_click"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailClick);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailCustomerQuarantinedReason != null)
            {
                propertiesObject["hs_email_customer_quarantined_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailCustomerQuarantinedReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailDelivered != null)
            {
                propertiesObject["hs_email_delivered"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailDelivered);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailDomain != null)
            {
                propertiesObject["hs_email_domain"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailDomain);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailFirstClickDate != null)
            {
                propertiesObject["hs_email_first_click_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailFirstClickDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailFirstOpenDate != null)
            {
                propertiesObject["hs_email_first_open_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailFirstOpenDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailFirstReplyDate != null)
            {
                propertiesObject["hs_email_first_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailFirstReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailFirstSendDate != null)
            {
                propertiesObject["hs_email_first_send_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailFirstSendDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailHardBounceReasonEnum != null)
            {
                propertiesObject["hs_email_hard_bounce_reason_enum"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailHardBounceReasonEnum);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailLastClickDate != null)
            {
                propertiesObject["hs_email_last_click_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailLastClickDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailLastEmailName != null)
            {
                propertiesObject["hs_email_last_email_name"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailLastEmailName);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailLastOpenDate != null)
            {
                propertiesObject["hs_email_last_open_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailLastOpenDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailLastReplyDate != null)
            {
                propertiesObject["hs_email_last_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailLastReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailLastSendDate != null)
            {
                propertiesObject["hs_email_last_send_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailLastSendDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailOpen != null)
            {
                propertiesObject["hs_email_open"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailOpen);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailOptout != null)
            {
                propertiesObject["hs_email_optout"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailOptout);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailOptout12592317 != null)
            {
                propertiesObject["hs_email_optout_12592317"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailOptout12592317);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailQuarantined != null)
            {
                propertiesObject["hs_email_quarantined"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailQuarantined);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailQuarantinedReason != null)
            {
                propertiesObject["hs_email_quarantined_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailQuarantinedReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailReplied != null)
            {
                propertiesObject["hs_email_replied"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailReplied);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailSendsSinceLastEngagement != null)
            {
                propertiesObject["hs_email_sends_since_last_engagement"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailSendsSinceLastEngagement);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsEmailconfirmationstatus != null)
            {
                propertiesObject["hs_emailconfirmationstatus"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsEmailconfirmationstatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFacebookClickId != null)
            {
                propertiesObject["hs_facebook_click_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFacebookClickId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastNpsFollowUp != null)
            {
                propertiesObject["hs_feedback_last_nps_follow_up"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastNpsFollowUp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastNpsRating != null)
            {
                propertiesObject["hs_feedback_last_nps_rating"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastNpsRating);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastSurveyDate != null)
            {
                propertiesObject["hs_feedback_last_survey_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsGoogleClickId != null)
            {
                propertiesObject["hs_google_click_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsGoogleClickId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsIpTimezone != null)
            {
                propertiesObject["hs_ip_timezone"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsIpTimezone);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsIsUnworked != null)
            {
                propertiesObject["hs_is_unworked"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsIsUnworked);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLanguage != null)
            {
                propertiesObject["hs_language"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLanguage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastSalesActivityTimestamp != null)
            {
                propertiesObject["hs_last_sales_activity_timestamp"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastSalesActivityTimestamp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLeadStatus != null)
            {
                propertiesObject["hs_lead_status"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLeadStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLegalBasis != null)
            {
                propertiesObject["hs_legal_basis"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLegalBasis);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageCustomerDate != null)
            {
                propertiesObject["hs_lifecyclestage_customer_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageCustomerDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageEvangelistDate != null)
            {
                propertiesObject["hs_lifecyclestage_evangelist_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageEvangelistDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageLeadDate != null)
            {
                propertiesObject["hs_lifecyclestage_lead_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageLeadDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageMarketingqualifiedleadDate != null)
            {
                propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageMarketingqualifiedleadDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageOpportunityDate != null)
            {
                propertiesObject["hs_lifecyclestage_opportunity_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageOpportunityDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageOtherDate != null)
            {
                propertiesObject["hs_lifecyclestage_other_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageOtherDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageSalesqualifiedleadDate != null)
            {
                propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageSalesqualifiedleadDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLifecyclestageSubscriberDate != null)
            {
                propertiesObject["hs_lifecyclestage_subscriber_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageSubscriberDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMarketableReasonId != null)
            {
                propertiesObject["hs_marketable_reason_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMarketableReasonId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMarketableReasonType != null)
            {
                propertiesObject["hs_marketable_reason_type"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMarketableReasonType);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMarketableStatus != null)
            {
                propertiesObject["hs_marketable_status"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMarketableStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMarketableUntilRenewal != null)
            {
                propertiesObject["hs_marketable_until_renewal"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMarketableUntilRenewal);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPersona != null)
            {
                propertiesObject["hs_persona"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPersona);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPredictivecontactscore != null)
            {
                propertiesObject["hs_predictivecontactscore"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscore);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPredictivecontactscoreV2 != null)
            {
                propertiesObject["hs_predictivecontactscore_v2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscoreV2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPredictivecontactscorebucket != null)
            {
                propertiesObject["hs_predictivecontactscorebucket"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscorebucket);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPredictivescoringtier != null)
            {
                propertiesObject["hs_predictivescoringtier"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPredictivescoringtier);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsSalesEmailLastClicked != null)
            {
                propertiesObject["hs_sales_email_last_clicked"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastClicked);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsSalesEmailLastOpened != null)
            {
                propertiesObject["hs_sales_email_last_opened"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastOpened);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsSalesEmailLastReplied != null)
            {
                propertiesObject["hs_sales_email_last_replied"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastReplied);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsSequencesIsEnrolled != null)
            {
                propertiesObject["hs_sequences_is_enrolled"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsSequencesIsEnrolled);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeBetweenContactCreationAndDealClose != null)
            {
                propertiesObject["hs_time_between_contact_creation_and_deal_close"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeBetweenContactCreationAndDealClose);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeBetweenContactCreationAndDealCreation != null)
            {
                propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeBetweenContactCreationAndDealCreation);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeToMoveFromLeadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_lead_to_customer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromLeadToCustomer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeToMoveFromOpportunityToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromOpportunityToCustomer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTimeToMoveFromSubscriberToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromSubscriberToCustomer);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotscore != null)
            {
                propertiesObject["hubspotscore"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotscore);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesindustry != null)
            {
                propertiesObject["industry"] = CSharpExpressionConverter.ConvertToken(bodypropertiesindustry);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesipCity != null)
            {
                propertiesObject["ip_city"] = CSharpExpressionConverter.ConvertToken(bodypropertiesipCity);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesipCountry != null)
            {
                propertiesObject["ip_country"] = CSharpExpressionConverter.ConvertToken(bodypropertiesipCountry);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesipCountryCode != null)
            {
                propertiesObject["ip_country_code"] = CSharpExpressionConverter.ConvertToken(bodypropertiesipCountryCode);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesipState != null)
            {
                propertiesObject["ip_state"] = CSharpExpressionConverter.ConvertToken(bodypropertiesipState);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesipStateCode != null)
            {
                propertiesObject["ip_state_code"] = CSharpExpressionConverter.ConvertToken(bodypropertiesipStateCode);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesjobFunction != null)
            {
                propertiesObject["job_function"] = CSharpExpressionConverter.ConvertToken(bodypropertiesjobFunction);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesjobtitle != null)
            {
                propertiesObject["jobtitle"] = CSharpExpressionConverter.ConvertToken(bodypropertiesjobtitle);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslastmodifieddate != null)
            {
                propertiesObject["lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieslastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslastname != null)
            {
                propertiesObject["lastname"] = CSharpExpressionConverter.ConvertToken(bodypropertieslastname);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslifecyclestage != null)
            {
                propertiesObject["lifecyclestage"] = CSharpExpressionConverter.ConvertToken(bodypropertieslifecyclestage);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesmaritalStatus != null)
            {
                propertiesObject["marital_status"] = CSharpExpressionConverter.ConvertToken(bodypropertiesmaritalStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesmessage != null)
            {
                propertiesObject["message"] = CSharpExpressionConverter.ConvertToken(bodypropertiesmessage);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesmilitaryStatus != null)
            {
                propertiesObject["military_status"] = CSharpExpressionConverter.ConvertToken(bodypropertiesmilitaryStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesmobilephone != null)
            {
                propertiesObject["mobilephone"] = CSharpExpressionConverter.ConvertToken(bodypropertiesmobilephone);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumAssociatedDeals != null)
            {
                propertiesObject["num_associated_deals"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumAssociatedDeals);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumConversionEvents != null)
            {
                propertiesObject["num_conversion_events"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumConversionEvents);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumUniqueConversionEvents != null)
            {
                propertiesObject["num_unique_conversion_events"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumUniqueConversionEvents);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumemployees != null)
            {
                propertiesObject["numemployees"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumemployees);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesphone != null)
            {
                propertiesObject["phone"] = CSharpExpressionConverter.ConvertToken(bodypropertiesphone);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentConversionDate != null)
            {
                propertiesObject["recent_conversion_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentConversionDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentConversionEventName != null)
            {
                propertiesObject["recent_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentConversionEventName);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentDealAmount != null)
            {
                propertiesObject["recent_deal_amount"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentDealAmount);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecentDealCloseDate != null)
            {
                propertiesObject["recent_deal_close_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecentDealCloseDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrelationshipStatus != null)
            {
                propertiesObject["relationship_status"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrelationshipStatus);
                propertiesObjectpropCount++;
            }

            if (bodypropertiessalutation != null)
            {
                propertiesObject["salutation"] = CSharpExpressionConverter.ConvertToken(bodypropertiessalutation);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesschool != null)
            {
                propertiesObject["school"] = CSharpExpressionConverter.ConvertToken(bodypropertiesschool);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesseniority != null)
            {
                propertiesObject["seniority"] = CSharpExpressionConverter.ConvertToken(bodypropertiesseniority);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesstartDate != null)
            {
                propertiesObject["start_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesstartDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesstate != null)
            {
                propertiesObject["state"] = CSharpExpressionConverter.ConvertToken(bodypropertiesstate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestotalRevenue != null)
            {
                propertiesObject["total_revenue"] = CSharpExpressionConverter.ConvertToken(bodypropertiestotalRevenue);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestwitterhandle != null)
            {
                propertiesObject["twitterhandle"] = CSharpExpressionConverter.ConvertToken(bodypropertiestwitterhandle);
                propertiesObjectpropCount++;
            }

            if (bodypropertieswebsite != null)
            {
                propertiesObject["website"] = CSharpExpressionConverter.ConvertToken(bodypropertieswebsite);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesworkEmail != null)
            {
                propertiesObject["work_email"] = CSharpExpressionConverter.ConvertToken(bodypropertiesworkEmail);
                propertiesObjectpropCount++;
            }

            if (bodypropertieszip != null)
            {
                propertiesObject["zip"] = CSharpExpressionConverter.ConvertToken(bodypropertieszip);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsRead(Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsArchive(Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsUpdate(Expression<Func<string>> contactId, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescompany = null, Expression<Func<string>> propertiespropertiescompanySize = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiescurrentlyinworkflow = null, Expression<Func<string>> propertiespropertiesdateOfBirth = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdegree = null, Expression<Func<string>> propertiespropertiesemail = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfax = null, Expression<Func<string>> propertiespropertiesfieldOfStudy = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfirstname = null, Expression<Func<string>> propertiespropertiesgender = null, Expression<Func<string>> propertiespropertiesgraduationDate = null, Expression<Func<string>> propertiespropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsRevenue = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsBuyingRole = null, Expression<Func<string>> propertiespropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> propertiespropertieshsContentMembershipNotes = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipStatus = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsEmailBadAddress = null, Expression<Func<string>> propertiespropertieshsEmailBounce = null, Expression<Func<string>> propertiespropertieshsEmailClick = null, Expression<Func<string>> propertiespropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailDelivered = null, Expression<Func<string>> propertiespropertieshsEmailDomain = null, Expression<Func<string>> propertiespropertieshsEmailFirstClickDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstSendDate = null, Expression<Func<string>> propertiespropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> propertiespropertieshsEmailLastClickDate = null, Expression<Func<string>> propertiespropertieshsEmailLastEmailName = null, Expression<Func<string>> propertiespropertieshsEmailLastOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailLastReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailLastSendDate = null, Expression<Func<string>> propertiespropertieshsEmailOpen = null, Expression<Func<string>> propertiespropertieshsEmailOptout = null, Expression<Func<string>> propertiespropertieshsEmailOptout12592317 = null, Expression<Func<string>> propertiespropertieshsEmailQuarantined = null, Expression<Func<string>> propertiespropertieshsEmailQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailReplied = null, Expression<Func<string>> propertiespropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> propertiespropertieshsEmailconfirmationstatus = null, Expression<Func<string>> propertiespropertieshsFacebookClickId = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> propertiespropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> propertiespropertieshsGoogleClickId = null, Expression<Func<string>> propertiespropertieshsIpTimezone = null, Expression<Func<string>> propertiespropertieshsIsUnworked = null, Expression<Func<string>> propertiespropertieshsLanguage = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsLegalBasis = null, Expression<Func<string>> propertiespropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> propertiespropertieshsMarketableReasonId = null, Expression<Func<string>> propertiespropertieshsMarketableReasonType = null, Expression<Func<string>> propertiespropertieshsMarketableStatus = null, Expression<Func<string>> propertiespropertieshsMarketableUntilRenewal = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsPersona = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscore = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> propertiespropertieshsPredictivescoringtier = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastClicked = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastOpened = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastReplied = null, Expression<Func<string>> propertiespropertieshsSequencesIsEnrolled = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertieshubspotscore = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesipCity = null, Expression<Func<string>> propertiespropertiesipCountry = null, Expression<Func<string>> propertiespropertiesipCountryCode = null, Expression<Func<string>> propertiespropertiesipState = null, Expression<Func<string>> propertiespropertiesipStateCode = null, Expression<Func<string>> propertiespropertiesjobFunction = null, Expression<Func<string>> propertiespropertiesjobtitle = null, Expression<Func<string>> propertiespropertieslastmodifieddate = null, Expression<Func<string>> propertiespropertieslastname = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertiesmaritalStatus = null, Expression<Func<string>> propertiespropertiesmessage = null, Expression<Func<string>> propertiespropertiesmilitaryStatus = null, Expression<Func<string>> propertiespropertiesmobilephone = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumNotes = null, Expression<Func<string>> propertiespropertiesnumUniqueConversionEvents = null, Expression<Func<string>> propertiespropertiesnumemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesrelationshipStatus = null, Expression<Func<string>> propertiespropertiessalutation = null, Expression<Func<string>> propertiespropertiesschool = null, Expression<Func<string>> propertiespropertiesseniority = null, Expression<Func<string>> propertiespropertiesstartDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertiesworkEmail = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var properties = new JObject();
            var propertiespropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiespropertiesaddress != null)
            {
                propertiesObject["address"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesaddress);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesannualrevenue != null)
            {
                propertiesObject["annualrevenue"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesannualrevenue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescity != null)
            {
                propertiesObject["city"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescity);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescompany != null)
            {
                propertiesObject["company"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescompany);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescompanySize != null)
            {
                propertiesObject["company_size"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescompanySize);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescountry != null)
            {
                propertiesObject["country"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescountry);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiescurrentlyinworkflow != null)
            {
                propertiesObject["currentlyinworkflow"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescurrentlyinworkflow);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdateOfBirth != null)
            {
                propertiesObject["date_of_birth"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdateOfBirth);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdaysToClose != null)
            {
                propertiesObject["days_to_close"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdaysToClose);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdegree != null)
            {
                propertiesObject["degree"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdegree);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesemail != null)
            {
                propertiesObject["email"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesemail);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfax != null)
            {
                propertiesObject["fax"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfax);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfieldOfStudy != null)
            {
                propertiesObject["field_of_study"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfieldOfStudy);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstConversionDate != null)
            {
                propertiesObject["first_conversion_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstConversionDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstConversionEventName != null)
            {
                propertiesObject["first_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstConversionEventName);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstDealCreatedDate != null)
            {
                propertiesObject["first_deal_created_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstDealCreatedDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesfirstname != null)
            {
                propertiesObject["firstname"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesfirstname);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesgender != null)
            {
                propertiesObject["gender"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesgender);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesgraduationDate != null)
            {
                propertiesObject["graduation_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesgraduationDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsAveragePageViews != null)
            {
                propertiesObject["hs_analytics_average_page_views"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsAveragePageViews);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstReferrer != null)
            {
                propertiesObject["hs_analytics_first_referrer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstReferrer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstTimestamp != null)
            {
                propertiesObject["hs_analytics_first_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_first_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstUrl != null)
            {
                propertiesObject["hs_analytics_first_url"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstUrl);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_first_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastReferrer != null)
            {
                propertiesObject["hs_analytics_last_referrer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastReferrer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastTimestamp != null)
            {
                propertiesObject["hs_analytics_last_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
            {
                propertiesObject["hs_analytics_last_touch_converting_campaign"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastUrl != null)
            {
                propertiesObject["hs_analytics_last_url"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastUrl);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
            {
                propertiesObject["hs_analytics_last_visit_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastVisitTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsNumEventCompletions != null)
            {
                propertiesObject["hs_analytics_num_event_completions"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumEventCompletions);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsNumPageViews != null)
            {
                propertiesObject["hs_analytics_num_page_views"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumPageViews);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsNumVisits != null)
            {
                propertiesObject["hs_analytics_num_visits"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumVisits);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsRevenue != null)
            {
                propertiesObject["hs_analytics_revenue"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsRevenue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsBuyingRole != null)
            {
                propertiesObject["hs_buying_role"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsBuyingRole);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipEmailConfirmed != null)
            {
                propertiesObject["hs_content_membership_email_confirmed"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipEmailConfirmed);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipNotes != null)
            {
                propertiesObject["hs_content_membership_notes"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipNotes);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipRegisteredAt != null)
            {
                propertiesObject["hs_content_membership_registered_at"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegisteredAt);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipRegistrationDomainSentTo != null)
            {
                propertiesObject["hs_content_membership_registration_domain_sent_to"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegistrationDomainSentTo);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipRegistrationEmailSentAt != null)
            {
                propertiesObject["hs_content_membership_registration_email_sent_at"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegistrationEmailSentAt);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsContentMembershipStatus != null)
            {
                propertiesObject["hs_content_membership_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailBadAddress != null)
            {
                propertiesObject["hs_email_bad_address"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailBadAddress);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailBounce != null)
            {
                propertiesObject["hs_email_bounce"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailBounce);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailClick != null)
            {
                propertiesObject["hs_email_click"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailClick);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailCustomerQuarantinedReason != null)
            {
                propertiesObject["hs_email_customer_quarantined_reason"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailCustomerQuarantinedReason);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailDelivered != null)
            {
                propertiesObject["hs_email_delivered"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailDelivered);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailDomain != null)
            {
                propertiesObject["hs_email_domain"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailDomain);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailFirstClickDate != null)
            {
                propertiesObject["hs_email_first_click_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstClickDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailFirstOpenDate != null)
            {
                propertiesObject["hs_email_first_open_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstOpenDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailFirstReplyDate != null)
            {
                propertiesObject["hs_email_first_reply_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstReplyDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailFirstSendDate != null)
            {
                propertiesObject["hs_email_first_send_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstSendDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailHardBounceReasonEnum != null)
            {
                propertiesObject["hs_email_hard_bounce_reason_enum"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailHardBounceReasonEnum);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailLastClickDate != null)
            {
                propertiesObject["hs_email_last_click_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailLastClickDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailLastEmailName != null)
            {
                propertiesObject["hs_email_last_email_name"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailLastEmailName);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailLastOpenDate != null)
            {
                propertiesObject["hs_email_last_open_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailLastOpenDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailLastReplyDate != null)
            {
                propertiesObject["hs_email_last_reply_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailLastReplyDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailLastSendDate != null)
            {
                propertiesObject["hs_email_last_send_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailLastSendDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailOpen != null)
            {
                propertiesObject["hs_email_open"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailOpen);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailOptout != null)
            {
                propertiesObject["hs_email_optout"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailOptout);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailOptout12592317 != null)
            {
                propertiesObject["hs_email_optout_12592317"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailOptout12592317);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailQuarantined != null)
            {
                propertiesObject["hs_email_quarantined"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailQuarantined);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailQuarantinedReason != null)
            {
                propertiesObject["hs_email_quarantined_reason"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailQuarantinedReason);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailReplied != null)
            {
                propertiesObject["hs_email_replied"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailReplied);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailSendsSinceLastEngagement != null)
            {
                propertiesObject["hs_email_sends_since_last_engagement"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailSendsSinceLastEngagement);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsEmailconfirmationstatus != null)
            {
                propertiesObject["hs_emailconfirmationstatus"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsEmailconfirmationstatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsFacebookClickId != null)
            {
                propertiesObject["hs_facebook_click_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsFacebookClickId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsFeedbackLastNpsFollowUp != null)
            {
                propertiesObject["hs_feedback_last_nps_follow_up"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastNpsFollowUp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsFeedbackLastNpsRating != null)
            {
                propertiesObject["hs_feedback_last_nps_rating"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastNpsRating);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsFeedbackLastSurveyDate != null)
            {
                propertiesObject["hs_feedback_last_survey_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastSurveyDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsGoogleClickId != null)
            {
                propertiesObject["hs_google_click_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsGoogleClickId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsIpTimezone != null)
            {
                propertiesObject["hs_ip_timezone"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsIpTimezone);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsIsUnworked != null)
            {
                propertiesObject["hs_is_unworked"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsIsUnworked);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLanguage != null)
            {
                propertiesObject["hs_language"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLanguage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastSalesActivityTimestamp != null)
            {
                propertiesObject["hs_last_sales_activity_timestamp"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastSalesActivityTimestamp);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLeadStatus != null)
            {
                propertiesObject["hs_lead_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLeadStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLegalBasis != null)
            {
                propertiesObject["hs_legal_basis"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLegalBasis);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageCustomerDate != null)
            {
                propertiesObject["hs_lifecyclestage_customer_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageCustomerDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageEvangelistDate != null)
            {
                propertiesObject["hs_lifecyclestage_evangelist_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageEvangelistDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageLeadDate != null)
            {
                propertiesObject["hs_lifecyclestage_lead_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageLeadDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageMarketingqualifiedleadDate != null)
            {
                propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageOpportunityDate != null)
            {
                propertiesObject["hs_lifecyclestage_opportunity_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageOpportunityDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageOtherDate != null)
            {
                propertiesObject["hs_lifecyclestage_other_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageOtherDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageSalesqualifiedleadDate != null)
            {
                propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageSalesqualifiedleadDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLifecyclestageSubscriberDate != null)
            {
                propertiesObject["hs_lifecyclestage_subscriber_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageSubscriberDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsMarketableReasonId != null)
            {
                propertiesObject["hs_marketable_reason_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsMarketableReasonId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsMarketableReasonType != null)
            {
                propertiesObject["hs_marketable_reason_type"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsMarketableReasonType);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsMarketableStatus != null)
            {
                propertiesObject["hs_marketable_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsMarketableStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsMarketableUntilRenewal != null)
            {
                propertiesObject["hs_marketable_until_renewal"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsMarketableUntilRenewal);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPersona != null)
            {
                propertiesObject["hs_persona"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPersona);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPredictivecontactscore != null)
            {
                propertiesObject["hs_predictivecontactscore"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscore);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPredictivecontactscoreV2 != null)
            {
                propertiesObject["hs_predictivecontactscore_v2"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscoreV2);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPredictivecontactscorebucket != null)
            {
                propertiesObject["hs_predictivecontactscorebucket"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscorebucket);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsPredictivescoringtier != null)
            {
                propertiesObject["hs_predictivescoringtier"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsPredictivescoringtier);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsSalesEmailLastClicked != null)
            {
                propertiesObject["hs_sales_email_last_clicked"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastClicked);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsSalesEmailLastOpened != null)
            {
                propertiesObject["hs_sales_email_last_opened"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastOpened);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsSalesEmailLastReplied != null)
            {
                propertiesObject["hs_sales_email_last_replied"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastReplied);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsSequencesIsEnrolled != null)
            {
                propertiesObject["hs_sequences_is_enrolled"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsSequencesIsEnrolled);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeBetweenContactCreationAndDealClose != null)
            {
                propertiesObject["hs_time_between_contact_creation_and_deal_close"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeBetweenContactCreationAndDealClose);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeBetweenContactCreationAndDealCreation != null)
            {
                propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeBetweenContactCreationAndDealCreation);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeToMoveFromLeadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_lead_to_customer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromLeadToCustomer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeToMoveFromOpportunityToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromOpportunityToCustomer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsTimeToMoveFromSubscriberToCustomer != null)
            {
                propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromSubscriberToCustomer);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshubspotscore != null)
            {
                propertiesObject["hubspotscore"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshubspotscore);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesindustry != null)
            {
                propertiesObject["industry"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesindustry);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesipCity != null)
            {
                propertiesObject["ip_city"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesipCity);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesipCountry != null)
            {
                propertiesObject["ip_country"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesipCountry);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesipCountryCode != null)
            {
                propertiesObject["ip_country_code"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesipCountryCode);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesipState != null)
            {
                propertiesObject["ip_state"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesipState);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesipStateCode != null)
            {
                propertiesObject["ip_state_code"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesipStateCode);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesjobFunction != null)
            {
                propertiesObject["job_function"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesjobFunction);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesjobtitle != null)
            {
                propertiesObject["jobtitle"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesjobtitle);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslastmodifieddate != null)
            {
                propertiesObject["lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslastname != null)
            {
                propertiesObject["lastname"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslastname);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieslifecyclestage != null)
            {
                propertiesObject["lifecyclestage"] = CSharpExpressionConverter.ConvertToken(propertiespropertieslifecyclestage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesmaritalStatus != null)
            {
                propertiesObject["marital_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesmaritalStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesmessage != null)
            {
                propertiesObject["message"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesmessage);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesmilitaryStatus != null)
            {
                propertiesObject["military_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesmilitaryStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesmobilephone != null)
            {
                propertiesObject["mobilephone"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesmobilephone);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumAssociatedDeals != null)
            {
                propertiesObject["num_associated_deals"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedDeals);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumConversionEvents != null)
            {
                propertiesObject["num_conversion_events"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumConversionEvents);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumUniqueConversionEvents != null)
            {
                propertiesObject["num_unique_conversion_events"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumUniqueConversionEvents);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesnumemployees != null)
            {
                propertiesObject["numemployees"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesnumemployees);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesphone != null)
            {
                propertiesObject["phone"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesphone);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentConversionDate != null)
            {
                propertiesObject["recent_conversion_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentConversionDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentConversionEventName != null)
            {
                propertiesObject["recent_conversion_event_name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentConversionEventName);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentDealAmount != null)
            {
                propertiesObject["recent_deal_amount"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentDealAmount);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecentDealCloseDate != null)
            {
                propertiesObject["recent_deal_close_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecentDealCloseDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrelationshipStatus != null)
            {
                propertiesObject["relationship_status"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrelationshipStatus);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiessalutation != null)
            {
                propertiesObject["salutation"] = CSharpExpressionConverter.ConvertToken(propertiespropertiessalutation);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesschool != null)
            {
                propertiesObject["school"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesschool);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesseniority != null)
            {
                propertiesObject["seniority"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesseniority);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesstartDate != null)
            {
                propertiesObject["start_date"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesstartDate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesstate != null)
            {
                propertiesObject["state"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesstate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestotalRevenue != null)
            {
                propertiesObject["total_revenue"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestotalRevenue);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestwitterhandle != null)
            {
                propertiesObject["twitterhandle"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestwitterhandle);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieswebsite != null)
            {
                propertiesObject["website"] = CSharpExpressionConverter.ConvertToken(propertiespropertieswebsite);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesworkEmail != null)
            {
                propertiesObject["work_email"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesworkEmail);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieszip != null)
            {
                propertiesObject["zip"] = CSharpExpressionConverter.ConvertToken(propertiespropertieszip);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsList(Expression<Func<string>> properties = null, Expression<Func<int>> limit = null, Expression<Func<string>> after = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/deals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (after != null)
                callPayload.Queries["after"] = CSharpExpressionConverter.ConvertO(after);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsCreate(Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
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
                propertiesObject["amount"] = CSharpExpressionConverter.ConvertToken(bodypropertiesamount);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesamountInHomeCurrency != null)
            {
                propertiesObject["amount_in_home_currency"] = CSharpExpressionConverter.ConvertToken(bodypropertiesamountInHomeCurrency);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedLostReason != null)
            {
                propertiesObject["closed_lost_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedLostReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedWonReason != null)
            {
                propertiesObject["closed_won_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedWonReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealname != null)
            {
                propertiesObject["dealname"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealname);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealstage != null)
            {
                propertiesObject["dealstage"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealstage);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealtype != null)
            {
                propertiesObject["dealtype"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealtype);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAcv != null)
            {
                propertiesObject["hs_acv"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAcv);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsArr != null)
            {
                propertiesObject["hs_arr"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsArr);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsForecastAmount != null)
            {
                propertiesObject["hs_forecast_amount"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsForecastAmount);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsForecastProbability != null)
            {
                propertiesObject["hs_forecast_probability"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsForecastProbability);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsManualForecastCategory != null)
            {
                propertiesObject["hs_manual_forecast_category"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsManualForecastCategory);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMrr != null)
            {
                propertiesObject["hs_mrr"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMrr);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNextStep != null)
            {
                propertiesObject["hs_next_step"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNextStep);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPriority != null)
            {
                propertiesObject["hs_priority"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPriority);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTcv != null)
            {
                propertiesObject["hs_tcv"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTcv);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumAssociatedContacts != null)
            {
                propertiesObject["num_associated_contacts"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiespipeline != null)
            {
                propertiesObject["pipeline"] = CSharpExpressionConverter.ConvertToken(bodypropertiespipeline);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsRead(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsArchive(Expression<Func<string>> dealId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsUpdate(Expression<Func<string>> dealId, Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertiesamount != null)
            {
                propertiesObject["amount"] = CSharpExpressionConverter.ConvertToken(bodypropertiesamount);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesamountInHomeCurrency != null)
            {
                propertiesObject["amount_in_home_currency"] = CSharpExpressionConverter.ConvertToken(bodypropertiesamountInHomeCurrency);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedLostReason != null)
            {
                propertiesObject["closed_lost_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedLostReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedWonReason != null)
            {
                propertiesObject["closed_won_reason"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedWonReason);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesclosedate != null)
            {
                propertiesObject["closedate"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealname != null)
            {
                propertiesObject["dealname"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealname);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealstage != null)
            {
                propertiesObject["dealstage"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealstage);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdealtype != null)
            {
                propertiesObject["dealtype"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdealtype);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBooked != null)
            {
                propertiesObject["engagements_last_meeting_booked"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
            {
                propertiesObject["engagements_last_meeting_booked_campaign"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedMedium != null)
            {
                propertiesObject["engagements_last_meeting_booked_medium"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesengagementsLastMeetingBookedSource != null)
            {
                propertiesObject["engagements_last_meeting_booked_source"] = CSharpExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAcv != null)
            {
                propertiesObject["hs_acv"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAcv);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSource != null)
            {
                propertiesObject["hs_analytics_source"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData1 != null)
            {
                propertiesObject["hs_analytics_source_data_1"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsAnalyticsSourceData2 != null)
            {
                propertiesObject["hs_analytics_source_data_2"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsArr != null)
            {
                propertiesObject["hs_arr"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsArr);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsForecastAmount != null)
            {
                propertiesObject["hs_forecast_amount"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsForecastAmount);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsForecastProbability != null)
            {
                propertiesObject["hs_forecast_probability"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsForecastProbability);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsManualForecastCategory != null)
            {
                propertiesObject["hs_manual_forecast_category"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsManualForecastCategory);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsMrr != null)
            {
                propertiesObject["hs_mrr"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsMrr);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNextStep != null)
            {
                propertiesObject["hs_next_step"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNextStep);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPriority != null)
            {
                propertiesObject["hs_priority"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPriority);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTcv != null)
            {
                propertiesObject["hs_tcv"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTcv);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastContacted != null)
            {
                propertiesObject["notes_last_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesLastUpdated != null)
            {
                propertiesObject["notes_last_updated"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnotesNextActivityDate != null)
            {
                propertiesObject["notes_next_activity_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumAssociatedContacts != null)
            {
                propertiesObject["num_associated_contacts"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumContactedNotes != null)
            {
                propertiesObject["num_contacted_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiespipeline != null)
            {
                propertiesObject["pipeline"] = CSharpExpressionConverter.ConvertToken(bodypropertiespipeline);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/products";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsCreate(Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertieshsCostOfGoodsSold = null, Expression<Func<string>> bodypropertieshsCreatedByUserId = null, Expression<Func<string>> bodypropertieshsCreatedate = null, Expression<Func<string>> bodypropertieshsImages = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertieshsSku = null, Expression<Func<string>> bodypropertieshsUpdatedByUserId = null, Expression<Func<string>> bodypropertieshsUrl = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertiesprice = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiestax = null)
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
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(bodypropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsCostOfGoodsSold != null)
            {
                propertiesObject["hs_cost_of_goods_sold"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsCostOfGoodsSold);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsCreatedByUserId != null)
            {
                propertiesObject["hs_created_by_user_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsCreatedByUserId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsImages != null)
            {
                propertiesObject["hs_images"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsImages);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsRecurringBillingPeriod != null)
            {
                propertiesObject["hs_recurring_billing_period"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsRecurringBillingPeriod);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsSku != null)
            {
                propertiesObject["hs_sku"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsSku);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsUpdatedByUserId != null)
            {
                propertiesObject["hs_updated_by_user_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsUpdatedByUserId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsUrl != null)
            {
                propertiesObject["hs_url"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsUrl);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesname != null)
            {
                propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesname);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesprice != null)
            {
                propertiesObject["price"] = CSharpExpressionConverter.ConvertToken(bodypropertiesprice);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecurringbillingfrequency != null)
            {
                propertiesObject["recurringbillingfrequency"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecurringbillingfrequency);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestax != null)
            {
                propertiesObject["tax"] = CSharpExpressionConverter.ConvertToken(bodypropertiestax);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsRead(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsArchive(Expression<Func<string>> productId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsUpdate(Expression<Func<string>> productId, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertieshsCostOfGoodsSold = null, Expression<Func<string>> propertiespropertieshsCreatedByUserId = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsImages = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertieshsSku = null, Expression<Func<string>> propertiespropertieshsUpdatedByUserId = null, Expression<Func<string>> propertiespropertieshsUrl = null, Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertiesprice = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiestax = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var properties = new JObject();
            var propertiespropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiespropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesdescription != null)
            {
                propertiesObject["description"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsCostOfGoodsSold != null)
            {
                propertiesObject["hs_cost_of_goods_sold"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsCostOfGoodsSold);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsCreatedByUserId != null)
            {
                propertiesObject["hs_created_by_user_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsCreatedByUserId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsCreatedate != null)
            {
                propertiesObject["hs_createdate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsImages != null)
            {
                propertiesObject["hs_images"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsImages);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsObjectId != null)
            {
                propertiesObject["hs_object_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsRecurringBillingPeriod != null)
            {
                propertiesObject["hs_recurring_billing_period"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsRecurringBillingPeriod);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsSku != null)
            {
                propertiesObject["hs_sku"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsSku);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsUpdatedByUserId != null)
            {
                propertiesObject["hs_updated_by_user_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsUpdatedByUserId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsUrl != null)
            {
                propertiesObject["hs_url"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsUrl);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesname != null)
            {
                propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesname);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesprice != null)
            {
                propertiesObject["price"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesprice);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecurringbillingfrequency != null)
            {
                propertiesObject["recurringbillingfrequency"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecurringbillingfrequency);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiestax != null)
            {
                propertiesObject["tax"] = CSharpExpressionConverter.ConvertToken(propertiespropertiestax);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/line_items";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsCreate(Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertieshsProductId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiesquantity = null, Expression<Func<string>> propertiespropertiesprice = null)
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
                propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesname);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsProductId != null)
            {
                propertiesObject["hs_product_id"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsProductId);
                propertiesObjectpropCount++;
            }

            if (propertiespropertieshsRecurringBillingPeriod != null)
            {
                propertiesObject["hs_recurring_billing_period"] = CSharpExpressionConverter.ConvertToken(propertiespropertieshsRecurringBillingPeriod);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesrecurringbillingfrequency != null)
            {
                propertiesObject["recurringbillingfrequency"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesrecurringbillingfrequency);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesquantity != null)
            {
                propertiesObject["quantity"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesquantity);
                propertiesObjectpropCount++;
            }

            if (propertiespropertiesprice != null)
            {
                propertiesObject["price"] = CSharpExpressionConverter.ConvertToken(propertiespropertiesprice);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsRead(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsArchive(Expression<Func<string>> lineItemId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsUpdate(Expression<Func<string>> lineItemId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertieshsProductId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiesquantity = null, Expression<Func<string>> bodypropertiesprice = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            var body = new JObject();
            var bodypropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertiesname != null)
            {
                propertiesObject["name"] = CSharpExpressionConverter.ConvertToken(bodypropertiesname);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsProductId != null)
            {
                propertiesObject["hs_product_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsProductId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsRecurringBillingPeriod != null)
            {
                propertiesObject["hs_recurring_billing_period"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsRecurringBillingPeriod);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesrecurringbillingfrequency != null)
            {
                propertiesObject["recurringbillingfrequency"] = CSharpExpressionConverter.ConvertToken(bodypropertiesrecurringbillingfrequency);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesquantity != null)
            {
                propertiesObject["quantity"] = CSharpExpressionConverter.ConvertToken(bodypropertiesquantity);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesprice != null)
            {
                propertiesObject["price"] = CSharpExpressionConverter.ConvertToken(bodypropertiesprice);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/crm/v3/objects/tickets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            if (associations != null)
                callPayload.Queries["associations"] = CSharpExpressionConverter.ConvertO(associations);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsCreate(Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
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
                propertiesObject["closed_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstAgentReplyDate != null)
            {
                propertiesObject["first_agent_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstAgentReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastCesFollowUp != null)
            {
                propertiesObject["hs_feedback_last_ces_follow_up"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesFollowUp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastCesRating != null)
            {
                propertiesObject["hs_feedback_last_ces_rating"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesRating);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastSurveyDate != null)
            {
                propertiesObject["hs_feedback_last_survey_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastactivitydate != null)
            {
                propertiesObject["hs_lastactivitydate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastactivitydate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastcontacted != null)
            {
                propertiesObject["hs_lastcontacted"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastcontacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNextactivitydate != null)
            {
                propertiesObject["hs_nextactivitydate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNextactivitydate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumTimesContacted != null)
            {
                propertiesObject["hs_num_times_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumTimesContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslastReplyDate != null)
            {
                propertiesObject["last_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieslastReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimeToClose != null)
            {
                propertiesObject["time_to_close"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimeToClose);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimeToFirstAgentReply != null)
            {
                propertiesObject["time_to_first_agent_reply"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimeToFirstAgentReply);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescontent != null)
            {
                propertiesObject["content"] = CSharpExpressionConverter.ConvertToken(bodypropertiescontent);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFileUpload != null)
            {
                propertiesObject["hs_file_upload"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFileUpload);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumAssociatedCompanies != null)
            {
                propertiesObject["hs_num_associated_companies"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumAssociatedCompanies);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPipeline != null)
            {
                propertiesObject["hs_pipeline"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPipeline);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPipelineStage != null)
            {
                propertiesObject["hs_pipeline_stage"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPipelineStage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsResolution != null)
            {
                propertiesObject["hs_resolution"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsResolution);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketCategory != null)
            {
                propertiesObject["hs_ticket_category"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketCategory);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketId != null)
            {
                propertiesObject["hs_ticket_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketPriority != null)
            {
                propertiesObject["hs_ticket_priority"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketPriority);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertiessourceType != null)
            {
                propertiesObject["source_type"] = CSharpExpressionConverter.ConvertToken(bodypropertiessourceType);
                propertiesObjectpropCount++;
            }

            if (bodypropertiessubject != null)
            {
                propertiesObject["subject"] = CSharpExpressionConverter.ConvertToken(bodypropertiessubject);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsRead(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = CSharpExpressionConverter.ConvertO(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsArchive(Expression<Func<string>> ticketId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsUpdate(Expression<Func<string>> ticketId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (idProperty != null)
                callPayload.Queries["idProperty"] = CSharpExpressionConverter.ConvertO(idProperty);
            var body = new JObject();
            var bodypropCount = 0;
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (bodypropertiesclosedDate != null)
            {
                propertiesObject["closed_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesclosedDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescreatedate != null)
            {
                propertiesObject["createdate"] = CSharpExpressionConverter.ConvertToken(bodypropertiescreatedate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesfirstAgentReplyDate != null)
            {
                propertiesObject["first_agent_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertiesfirstAgentReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastCesFollowUp != null)
            {
                propertiesObject["hs_feedback_last_ces_follow_up"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesFollowUp);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastCesRating != null)
            {
                propertiesObject["hs_feedback_last_ces_rating"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesRating);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFeedbackLastSurveyDate != null)
            {
                propertiesObject["hs_feedback_last_survey_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastactivitydate != null)
            {
                propertiesObject["hs_lastactivitydate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastactivitydate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastcontacted != null)
            {
                propertiesObject["hs_lastcontacted"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastcontacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsLastmodifieddate != null)
            {
                propertiesObject["hs_lastmodifieddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNextactivitydate != null)
            {
                propertiesObject["hs_nextactivitydate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNextactivitydate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumTimesContacted != null)
            {
                propertiesObject["hs_num_times_contacted"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumTimesContacted);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerAssigneddate != null)
            {
                propertiesObject["hubspot_owner_assigneddate"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                propertiesObjectpropCount++;
            }

            if (bodypropertieslastReplyDate != null)
            {
                propertiesObject["last_reply_date"] = CSharpExpressionConverter.ConvertToken(bodypropertieslastReplyDate);
                propertiesObjectpropCount++;
            }

            if (bodypropertiesnumNotes != null)
            {
                propertiesObject["num_notes"] = CSharpExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimeToClose != null)
            {
                propertiesObject["time_to_close"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimeToClose);
                propertiesObjectpropCount++;
            }

            if (bodypropertiestimeToFirstAgentReply != null)
            {
                propertiesObject["time_to_first_agent_reply"] = CSharpExpressionConverter.ConvertToken(bodypropertiestimeToFirstAgentReply);
                propertiesObjectpropCount++;
            }

            if (bodypropertiescontent != null)
            {
                propertiesObject["content"] = CSharpExpressionConverter.ConvertToken(bodypropertiescontent);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsFileUpload != null)
            {
                propertiesObject["hs_file_upload"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsFileUpload);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsNumAssociatedCompanies != null)
            {
                propertiesObject["hs_num_associated_companies"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsNumAssociatedCompanies);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPipeline != null)
            {
                propertiesObject["hs_pipeline"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPipeline);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsPipelineStage != null)
            {
                propertiesObject["hs_pipeline_stage"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsPipelineStage);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsResolution != null)
            {
                propertiesObject["hs_resolution"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsResolution);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketCategory != null)
            {
                propertiesObject["hs_ticket_category"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketCategory);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketId != null)
            {
                propertiesObject["hs_ticket_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshsTicketPriority != null)
            {
                propertiesObject["hs_ticket_priority"] = CSharpExpressionConverter.ConvertToken(bodypropertieshsTicketPriority);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotOwnerId != null)
            {
                propertiesObject["hubspot_owner_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                propertiesObjectpropCount++;
            }

            if (bodypropertieshubspotTeamId != null)
            {
                propertiesObject["hubspot_team_id"] = CSharpExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                propertiesObjectpropCount++;
            }

            if (bodypropertiessourceType != null)
            {
                propertiesObject["source_type"] = CSharpExpressionConverter.ConvertToken(bodypropertiessourceType);
                propertiesObjectpropCount++;
            }

            if (bodypropertiessubject != null)
            {
                propertiesObject["subject"] = CSharpExpressionConverter.ConvertToken(bodypropertiessubject);
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