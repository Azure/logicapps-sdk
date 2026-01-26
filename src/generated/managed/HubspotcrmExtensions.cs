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
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesRead(Expression<Func<string>> companyId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesArchive(Expression<Func<string>> companyId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesUpdate(Expression<Func<string>> companyId, Expression<Func<string>> propertiespropertiesname, Expression<Func<string>> propertiespropertiesaboutUs = null, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesaddress2 = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertiesdomain = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfacebookCompanyPage = null, Expression<Func<string>> propertiespropertiesfacebookfans = null, Expression<Func<string>> propertiespropertiesfirstContactCreatedate = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfoundedYear = null, Expression<Func<string>> propertiespropertiesgoogleplusPage = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsIdealCustomerProfile = null, Expression<Func<string>> propertiespropertieshsIsTargetAccount = null, Expression<Func<string>> propertiespropertieshsLastBookedMeetingDate = null, Expression<Func<string>> propertiespropertieshsLastLoggedCallDate = null, Expression<Func<string>> propertiespropertieshsLastOpenTaskDate = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsNumBlockers = null, Expression<Func<string>> propertiespropertieshsNumChildCompanies = null, Expression<Func<string>> propertiespropertieshsNumContactsWithBuyingRoles = null, Expression<Func<string>> propertiespropertieshsNumDecisionMakers = null, Expression<Func<string>> propertiespropertieshsNumOpenDeals = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsParentCompanyId = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsTotalDealValue = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesisPublic = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertieslinkedinCompanyPage = null, Expression<Func<string>> propertiespropertieslinkedinbio = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedContacts = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumberofemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestimezone = null, Expression<Func<string>> propertiespropertiestotalMoneyRaised = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterbio = null, Expression<Func<string>> propertiespropertiestwitterfollowers = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertiestype = null, Expression<Func<string>> propertiespropertieswebTechnologies = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null)
        {
            var apiCallPath = "/crm/v3/objects/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (properties != null)
                callPayload.Queries["properties[]"] = ExpressionConverter.Convert(properties);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsRead(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsArchive(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsUpdate(Expression<Func<string>> contactId, Expression<Func<string>> propertiespropertiesaddress = null, Expression<Func<string>> propertiespropertiesannualrevenue = null, Expression<Func<string>> propertiespropertiescity = null, Expression<Func<string>> propertiespropertiesclosedate = null, Expression<Func<string>> propertiespropertiescompany = null, Expression<Func<string>> propertiespropertiescompanySize = null, Expression<Func<string>> propertiespropertiescountry = null, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiescurrentlyinworkflow = null, Expression<Func<string>> propertiespropertiesdateOfBirth = null, Expression<Func<string>> propertiespropertiesdaysToClose = null, Expression<Func<string>> propertiespropertiesdegree = null, Expression<Func<string>> propertiespropertiesemail = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> propertiespropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> propertiespropertiesfax = null, Expression<Func<string>> propertiespropertiesfieldOfStudy = null, Expression<Func<string>> propertiespropertiesfirstConversionDate = null, Expression<Func<string>> propertiespropertiesfirstConversionEventName = null, Expression<Func<string>> propertiespropertiesfirstDealCreatedDate = null, Expression<Func<string>> propertiespropertiesfirstname = null, Expression<Func<string>> propertiespropertiesgender = null, Expression<Func<string>> propertiespropertiesgraduationDate = null, Expression<Func<string>> propertiespropertieshsAnalyticsAveragePageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastReferrer = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastUrl = null, Expression<Func<string>> propertiespropertieshsAnalyticsLastVisitTimestamp = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumEventCompletions = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumPageViews = null, Expression<Func<string>> propertiespropertieshsAnalyticsNumVisits = null, Expression<Func<string>> propertiespropertieshsAnalyticsRevenue = null, Expression<Func<string>> propertiespropertieshsAnalyticsSource = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> propertiespropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> propertiespropertieshsBuyingRole = null, Expression<Func<string>> propertiespropertieshsContentMembershipEmailConfirmed = null, Expression<Func<string>> propertiespropertieshsContentMembershipNotes = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegisteredAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, Expression<Func<string>> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, Expression<Func<string>> propertiespropertieshsContentMembershipStatus = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsEmailBadAddress = null, Expression<Func<string>> propertiespropertieshsEmailBounce = null, Expression<Func<string>> propertiespropertieshsEmailClick = null, Expression<Func<string>> propertiespropertieshsEmailCustomerQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailDelivered = null, Expression<Func<string>> propertiespropertieshsEmailDomain = null, Expression<Func<string>> propertiespropertieshsEmailFirstClickDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailFirstSendDate = null, Expression<Func<string>> propertiespropertieshsEmailHardBounceReasonEnum = null, Expression<Func<string>> propertiespropertieshsEmailLastClickDate = null, Expression<Func<string>> propertiespropertieshsEmailLastEmailName = null, Expression<Func<string>> propertiespropertieshsEmailLastOpenDate = null, Expression<Func<string>> propertiespropertieshsEmailLastReplyDate = null, Expression<Func<string>> propertiespropertieshsEmailLastSendDate = null, Expression<Func<string>> propertiespropertieshsEmailOpen = null, Expression<Func<string>> propertiespropertieshsEmailOptout = null, Expression<Func<string>> propertiespropertieshsEmailOptout12592317 = null, Expression<Func<string>> propertiespropertieshsEmailQuarantined = null, Expression<Func<string>> propertiespropertieshsEmailQuarantinedReason = null, Expression<Func<string>> propertiespropertieshsEmailReplied = null, Expression<Func<string>> propertiespropertieshsEmailSendsSinceLastEngagement = null, Expression<Func<string>> propertiespropertieshsEmailconfirmationstatus = null, Expression<Func<string>> propertiespropertieshsFacebookClickId = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsFollowUp = null, Expression<Func<string>> propertiespropertieshsFeedbackLastNpsRating = null, Expression<Func<string>> propertiespropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> propertiespropertieshsGoogleClickId = null, Expression<Func<string>> propertiespropertieshsIpTimezone = null, Expression<Func<string>> propertiespropertieshsIsUnworked = null, Expression<Func<string>> propertiespropertieshsLanguage = null, Expression<Func<string>> propertiespropertieshsLastSalesActivityTimestamp = null, Expression<Func<string>> propertiespropertieshsLeadStatus = null, Expression<Func<string>> propertiespropertieshsLegalBasis = null, Expression<Func<string>> propertiespropertieshsLifecyclestageCustomerDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageEvangelistDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageLeadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOpportunityDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageOtherDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, Expression<Func<string>> propertiespropertieshsLifecyclestageSubscriberDate = null, Expression<Func<string>> propertiespropertieshsMarketableReasonId = null, Expression<Func<string>> propertiespropertieshsMarketableReasonType = null, Expression<Func<string>> propertiespropertieshsMarketableStatus = null, Expression<Func<string>> propertiespropertieshsMarketableUntilRenewal = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsPersona = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscore = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscoreV2 = null, Expression<Func<string>> propertiespropertieshsPredictivecontactscorebucket = null, Expression<Func<string>> propertiespropertieshsPredictivescoringtier = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastClicked = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastOpened = null, Expression<Func<string>> propertiespropertieshsSalesEmailLastReplied = null, Expression<Func<string>> propertiespropertieshsSequencesIsEnrolled = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, Expression<Func<string>> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, Expression<Func<string>> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, Expression<Func<string>> propertiespropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> propertiespropertieshubspotOwnerId = null, Expression<Func<string>> propertiespropertieshubspotTeamId = null, Expression<Func<string>> propertiespropertieshubspotscore = null, Expression<Func<string>> propertiespropertiesindustry = null, Expression<Func<string>> propertiespropertiesipCity = null, Expression<Func<string>> propertiespropertiesipCountry = null, Expression<Func<string>> propertiespropertiesipCountryCode = null, Expression<Func<string>> propertiespropertiesipState = null, Expression<Func<string>> propertiespropertiesipStateCode = null, Expression<Func<string>> propertiespropertiesjobFunction = null, Expression<Func<string>> propertiespropertiesjobtitle = null, Expression<Func<string>> propertiespropertieslastmodifieddate = null, Expression<Func<string>> propertiespropertieslastname = null, Expression<Func<string>> propertiespropertieslifecyclestage = null, Expression<Func<string>> propertiespropertiesmaritalStatus = null, Expression<Func<string>> propertiespropertiesmessage = null, Expression<Func<string>> propertiespropertiesmilitaryStatus = null, Expression<Func<string>> propertiespropertiesmobilephone = null, Expression<Func<string>> propertiespropertiesnotesLastContacted = null, Expression<Func<string>> propertiespropertiesnotesLastUpdated = null, Expression<Func<string>> propertiespropertiesnotesNextActivityDate = null, Expression<Func<string>> propertiespropertiesnumAssociatedDeals = null, Expression<Func<string>> propertiespropertiesnumContactedNotes = null, Expression<Func<string>> propertiespropertiesnumConversionEvents = null, Expression<Func<string>> propertiespropertiesnumNotes = null, Expression<Func<string>> propertiespropertiesnumUniqueConversionEvents = null, Expression<Func<string>> propertiespropertiesnumemployees = null, Expression<Func<string>> propertiespropertiesphone = null, Expression<Func<string>> propertiespropertiesrecentConversionDate = null, Expression<Func<string>> propertiespropertiesrecentConversionEventName = null, Expression<Func<string>> propertiespropertiesrecentDealAmount = null, Expression<Func<string>> propertiespropertiesrecentDealCloseDate = null, Expression<Func<string>> propertiespropertiesrelationshipStatus = null, Expression<Func<string>> propertiespropertiessalutation = null, Expression<Func<string>> propertiespropertiesschool = null, Expression<Func<string>> propertiespropertiesseniority = null, Expression<Func<string>> propertiespropertiesstartDate = null, Expression<Func<string>> propertiespropertiesstate = null, Expression<Func<string>> propertiespropertiestotalRevenue = null, Expression<Func<string>> propertiespropertiestwitterhandle = null, Expression<Func<string>> propertiespropertieswebsite = null, Expression<Func<string>> propertiespropertiesworkEmail = null, Expression<Func<string>> propertiespropertieszip = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsList(Expression<Func<string>> properties = null, Expression<Func<int>> limit = null, Expression<Func<string>> after = null, Expression<Func<bool>> archived = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsRead(Expression<Func<string>> dealId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsArchive(Expression<Func<string>> dealId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsUpdate(Expression<Func<string>> dealId, Expression<Func<string>> bodypropertiesamount = null, Expression<Func<string>> bodypropertiesamountInHomeCurrency = null, Expression<Func<string>> bodypropertiesclosedLostReason = null, Expression<Func<string>> bodypropertiesclosedWonReason = null, Expression<Func<string>> bodypropertiesclosedate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesdealname = null, Expression<Func<string>> bodypropertiesdealstage = null, Expression<Func<string>> bodypropertiesdealtype = null, Expression<Func<string>> bodypropertiesdescription = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBooked = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedCampaign = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedMedium = null, Expression<Func<string>> bodypropertiesengagementsLastMeetingBookedSource = null, Expression<Func<string>> bodypropertieshsAcv = null, Expression<Func<string>> bodypropertieshsAnalyticsSource = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData1 = null, Expression<Func<string>> bodypropertieshsAnalyticsSourceData2 = null, Expression<Func<string>> bodypropertieshsArr = null, Expression<Func<string>> bodypropertieshsForecastAmount = null, Expression<Func<string>> bodypropertieshsForecastProbability = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsManualForecastCategory = null, Expression<Func<string>> bodypropertieshsMrr = null, Expression<Func<string>> bodypropertieshsNextStep = null, Expression<Func<string>> bodypropertieshsObjectId = null, Expression<Func<string>> bodypropertieshsPriority = null, Expression<Func<string>> bodypropertieshsTcv = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiesnotesLastContacted = null, Expression<Func<string>> bodypropertiesnotesLastUpdated = null, Expression<Func<string>> bodypropertiesnotesNextActivityDate = null, Expression<Func<string>> bodypropertiesnumAssociatedContacts = null, Expression<Func<string>> bodypropertiesnumContactedNotes = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiespipeline = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/deals/{0}", ExpressionConverter.ConvertWithUrlEncoding(dealId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsRead(Expression<Func<string>> productId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (properties != null)
                callPayload.Queries["properties"] = ExpressionConverter.Convert(properties);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsArchive(Expression<Func<string>> productId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsUpdate(Expression<Func<string>> productId, Expression<Func<string>> propertiespropertiescreatedate = null, Expression<Func<string>> propertiespropertiesdescription = null, Expression<Func<string>> propertiespropertieshsCostOfGoodsSold = null, Expression<Func<string>> propertiespropertieshsCreatedByUserId = null, Expression<Func<string>> propertiespropertieshsCreatedate = null, Expression<Func<string>> propertiespropertieshsImages = null, Expression<Func<string>> propertiespropertieshsLastmodifieddate = null, Expression<Func<string>> propertiespropertieshsObjectId = null, Expression<Func<string>> propertiespropertieshsRecurringBillingPeriod = null, Expression<Func<string>> propertiespropertieshsSku = null, Expression<Func<string>> propertiespropertieshsUpdatedByUserId = null, Expression<Func<string>> propertiespropertieshsUrl = null, Expression<Func<string>> propertiespropertiesname = null, Expression<Func<string>> propertiespropertiesprice = null, Expression<Func<string>> propertiespropertiesrecurringbillingfrequency = null, Expression<Func<string>> propertiespropertiestax = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/products/{0}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsList(Expression<Func<int>> limit, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsRead(Expression<Func<string>> lineItemId, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<string>> idProperty = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsArchive(Expression<Func<string>> lineItemId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsUpdate(Expression<Func<string>> lineItemId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesname = null, Expression<Func<string>> bodypropertieshsProductId = null, Expression<Func<string>> bodypropertieshsRecurringBillingPeriod = null, Expression<Func<string>> bodypropertiesrecurringbillingfrequency = null, Expression<Func<string>> bodypropertiesquantity = null, Expression<Func<string>> bodypropertiesprice = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/line_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsList(Expression<Func<int>> limit = null, Expression<Func<string>> properties = null, Expression<Func<string>> associations = null, Expression<Func<bool>> archived = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsRead(Expression<Func<string>> ticketId, Expression<Func<string>> properties = null, Expression<Func<bool>> archived = null, Expression<Func<string>> idProperty = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsArchive(Expression<Func<string>> ticketId)
        {
            var apiCallPath = String.Format("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsUpdate(Expression<Func<string>> ticketId, Expression<Func<string>> idProperty = null, Expression<Func<string>> bodypropertiesclosedDate = null, Expression<Func<string>> bodypropertiescreatedate = null, Expression<Func<string>> bodypropertiesfirstAgentReplyDate = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesFollowUp = null, Expression<Func<string>> bodypropertieshsFeedbackLastCesRating = null, Expression<Func<string>> bodypropertieshsFeedbackLastSurveyDate = null, Expression<Func<string>> bodypropertieshsLastactivitydate = null, Expression<Func<string>> bodypropertieshsLastcontacted = null, Expression<Func<string>> bodypropertieshsLastmodifieddate = null, Expression<Func<string>> bodypropertieshsNextactivitydate = null, Expression<Func<string>> bodypropertieshsNumTimesContacted = null, Expression<Func<string>> bodypropertieshubspotOwnerAssigneddate = null, Expression<Func<string>> bodypropertieslastReplyDate = null, Expression<Func<string>> bodypropertiesnumNotes = null, Expression<Func<string>> bodypropertiestimeToClose = null, Expression<Func<string>> bodypropertiestimeToFirstAgentReply = null, Expression<Func<string>> bodypropertiescontent = null, Expression<Func<string>> bodypropertieshsFileUpload = null, Expression<Func<string>> bodypropertieshsNumAssociatedCompanies = null, Expression<Func<string>> bodypropertieshsPipeline = null, Expression<Func<string>> bodypropertieshsPipelineStage = null, Expression<Func<string>> bodypropertieshsResolution = null, Expression<Func<string>> bodypropertieshsTicketCategory = null, Expression<Func<string>> bodypropertieshsTicketId = null, Expression<Func<string>> bodypropertieshsTicketPriority = null, Expression<Func<string>> bodypropertieshubspotOwnerId = null, Expression<Func<string>> bodypropertieshubspotTeamId = null, Expression<Func<string>> bodypropertiessourceType = null, Expression<Func<string>> bodypropertiessubject = null)
        {
            var apiCallPath = String.Format("/crm/v3/objects/tickets/{0}", ExpressionConverter.ConvertWithUrlEncoding(ticketId, 1));
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