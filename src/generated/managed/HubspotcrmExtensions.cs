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
        public IWorkflowAction CompaniesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesCreate([WorkflowExpression] Func<string> bodypropertiesname, [WorkflowExpression] Func<string> bodypropertiesaboutUs = null, [WorkflowExpression] Func<string> bodypropertiesaddress = null, [WorkflowExpression] Func<string> bodypropertiesaddress2 = null, [WorkflowExpression] Func<string> bodypropertiesannualrevenue = null, [WorkflowExpression] Func<string> bodypropertiescity = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescountry = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdaysToClose = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesdomain = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertiesfacebookCompanyPage = null, [WorkflowExpression] Func<string> bodypropertiesfacebookfans = null, [WorkflowExpression] Func<string> bodypropertiesfirstContactCreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> bodypropertiesfoundedYear = null, [WorkflowExpression] Func<string> bodypropertiesgoogleplusPage = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsIdealCustomerProfile = null, [WorkflowExpression] Func<string> bodypropertieshsIsTargetAccount = null, [WorkflowExpression] Func<string> bodypropertieshsLastBookedMeetingDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastLoggedCallDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastOpenTaskDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsLeadStatus = null, [WorkflowExpression] Func<string> bodypropertieshsNumBlockers = null, [WorkflowExpression] Func<string> bodypropertieshsNumChildCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsNumContactsWithBuyingRoles = null, [WorkflowExpression] Func<string> bodypropertieshsNumDecisionMakers = null, [WorkflowExpression] Func<string> bodypropertieshsNumOpenDeals = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsParentCompanyId = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> bodypropertieshsTotalDealValue = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesindustry = null, [WorkflowExpression] Func<string> bodypropertiesisPublic = null, [WorkflowExpression] Func<string> bodypropertieslifecyclestage = null, [WorkflowExpression] Func<string> bodypropertieslinkedinCompanyPage = null, [WorkflowExpression] Func<string> bodypropertieslinkedinbio = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumberofemployees = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> bodypropertiesstate = null, [WorkflowExpression] Func<string> bodypropertiestimezone = null, [WorkflowExpression] Func<string> bodypropertiestotalMoneyRaised = null, [WorkflowExpression] Func<string> bodypropertiestotalRevenue = null, [WorkflowExpression] Func<string> bodypropertiestwitterbio = null, [WorkflowExpression] Func<string> bodypropertiestwitterfollowers = null, [WorkflowExpression] Func<string> bodypropertiestwitterhandle = null, [WorkflowExpression] Func<string> bodypropertiestype = null, [WorkflowExpression] Func<string> bodypropertieswebTechnologies = null, [WorkflowExpression] Func<string> bodypropertieswebsite = null, [WorkflowExpression] Func<string> bodypropertieszip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["about_us"] = SourceExpressionConverter.ConvertToken(bodypropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesaddress != null)
                {
                    propertiesObject["address"] = SourceExpressionConverter.ConvertToken(bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = SourceExpressionConverter.ConvertToken(bodypropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = SourceExpressionConverter.ConvertToken(bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescity != null)
                {
                    propertiesObject["city"] = SourceExpressionConverter.ConvertToken(bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescountry != null)
                {
                    propertiesObject["country"] = SourceExpressionConverter.ConvertToken(bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = SourceExpressionConverter.ConvertToken(bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdomain != null)
                {
                    propertiesObject["domain"] = SourceExpressionConverter.ConvertToken(bodypropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = SourceExpressionConverter.ConvertToken(bodypropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = SourceExpressionConverter.ConvertToken(bodypropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = SourceExpressionConverter.ConvertToken(bodypropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = SourceExpressionConverter.ConvertToken(bodypropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = SourceExpressionConverter.ConvertToken(bodypropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = SourceExpressionConverter.ConvertToken(bodypropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = SourceExpressionConverter.ConvertToken(bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = SourceExpressionConverter.ConvertToken(bodypropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = SourceExpressionConverter.ConvertToken(bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = SourceExpressionConverter.ConvertToken(bodypropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = SourceExpressionConverter.ConvertToken(bodypropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodypropertiesname);
                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = SourceExpressionConverter.ConvertToken(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstate != null)
                {
                    propertiesObject["state"] = SourceExpressionConverter.ConvertToken(bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimezone != null)
                {
                    propertiesObject["timezone"] = SourceExpressionConverter.ConvertToken(bodypropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = SourceExpressionConverter.ConvertToken(bodypropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = SourceExpressionConverter.ConvertToken(bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = SourceExpressionConverter.ConvertToken(bodypropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = SourceExpressionConverter.ConvertToken(bodypropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = SourceExpressionConverter.ConvertToken(bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestype != null)
                {
                    propertiesObject["type"] = SourceExpressionConverter.ConvertToken(bodypropertiestype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = SourceExpressionConverter.ConvertToken(bodypropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = SourceExpressionConverter.ConvertToken(bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieszip != null)
                {
                    propertiesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypropertieszip);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesRead([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesArchive([WorkflowExpression] Func<string> companyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction CompaniesUpdate([WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> propertiespropertiesname, [WorkflowExpression] Func<string> propertiespropertiesaboutUs = null, [WorkflowExpression] Func<string> propertiespropertiesaddress = null, [WorkflowExpression] Func<string> propertiespropertiesaddress2 = null, [WorkflowExpression] Func<string> propertiespropertiesannualrevenue = null, [WorkflowExpression] Func<string> propertiespropertiescity = null, [WorkflowExpression] Func<string> propertiespropertiesclosedate = null, [WorkflowExpression] Func<string> propertiespropertiescountry = null, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesdaysToClose = null, [WorkflowExpression] Func<string> propertiespropertiesdescription = null, [WorkflowExpression] Func<string> propertiespropertiesdomain = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> propertiespropertiesfacebookCompanyPage = null, [WorkflowExpression] Func<string> propertiespropertiesfacebookfans = null, [WorkflowExpression] Func<string> propertiespropertiesfirstContactCreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> propertiespropertiesfoundedYear = null, [WorkflowExpression] Func<string> propertiespropertiesgoogleplusPage = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsIdealCustomerProfile = null, [WorkflowExpression] Func<string> propertiespropertieshsIsTargetAccount = null, [WorkflowExpression] Func<string> propertiespropertieshsLastBookedMeetingDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastLoggedCallDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastOpenTaskDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieshsLeadStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsNumBlockers = null, [WorkflowExpression] Func<string> propertiespropertieshsNumChildCompanies = null, [WorkflowExpression] Func<string> propertiespropertieshsNumContactsWithBuyingRoles = null, [WorkflowExpression] Func<string> propertiespropertieshsNumDecisionMakers = null, [WorkflowExpression] Func<string> propertiespropertieshsNumOpenDeals = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsParentCompanyId = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> propertiespropertieshsTotalDealValue = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotTeamId = null, [WorkflowExpression] Func<string> propertiespropertiesindustry = null, [WorkflowExpression] Func<string> propertiespropertiesisPublic = null, [WorkflowExpression] Func<string> propertiespropertieslifecyclestage = null, [WorkflowExpression] Func<string> propertiespropertieslinkedinCompanyPage = null, [WorkflowExpression] Func<string> propertiespropertieslinkedinbio = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> propertiespropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> propertiespropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumberofemployees = null, [WorkflowExpression] Func<string> propertiespropertiesphone = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> propertiespropertiesstate = null, [WorkflowExpression] Func<string> propertiespropertiestimezone = null, [WorkflowExpression] Func<string> propertiespropertiestotalMoneyRaised = null, [WorkflowExpression] Func<string> propertiespropertiestotalRevenue = null, [WorkflowExpression] Func<string> propertiespropertiestwitterbio = null, [WorkflowExpression] Func<string> propertiespropertiestwitterfollowers = null, [WorkflowExpression] Func<string> propertiespropertiestwitterhandle = null, [WorkflowExpression] Func<string> propertiespropertiestype = null, [WorkflowExpression] Func<string> propertiespropertieswebTechnologies = null, [WorkflowExpression] Func<string> propertiespropertieswebsite = null, [WorkflowExpression] Func<string> propertiespropertieszip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiesaboutUs != null)
                {
                    propertiesObject["about_us"] = SourceExpressionConverter.ConvertToken(propertiespropertiesaboutUs);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = SourceExpressionConverter.ConvertToken(propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesaddress2 != null)
                {
                    propertiesObject["address2"] = SourceExpressionConverter.ConvertToken(propertiespropertiesaddress2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = SourceExpressionConverter.ConvertToken(propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescity != null)
                {
                    propertiesObject["city"] = SourceExpressionConverter.ConvertToken(propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = SourceExpressionConverter.ConvertToken(propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdomain != null)
                {
                    propertiesObject["domain"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdomain);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfacebookCompanyPage != null)
                {
                    propertiesObject["facebook_company_page"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfacebookCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfacebookfans != null)
                {
                    propertiesObject["facebookfans"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfacebookfans);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstContactCreatedate != null)
                {
                    propertiesObject["first_contact_createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstContactCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfoundedYear != null)
                {
                    propertiesObject["founded_year"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfoundedYear);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgoogleplusPage != null)
                {
                    propertiesObject["googleplus_page"] = SourceExpressionConverter.ConvertToken(propertiespropertiesgoogleplusPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIdealCustomerProfile != null)
                {
                    propertiesObject["hs_ideal_customer_profile"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsIdealCustomerProfile);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIsTargetAccount != null)
                {
                    propertiesObject["hs_is_target_account"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsIsTargetAccount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastBookedMeetingDate != null)
                {
                    propertiesObject["hs_last_booked_meeting_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastBookedMeetingDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastLoggedCallDate != null)
                {
                    propertiesObject["hs_last_logged_call_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastLoggedCallDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastOpenTaskDate != null)
                {
                    propertiesObject["hs_last_open_task_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastOpenTaskDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumBlockers != null)
                {
                    propertiesObject["hs_num_blockers"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsNumBlockers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumChildCompanies != null)
                {
                    propertiesObject["hs_num_child_companies"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsNumChildCompanies);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumContactsWithBuyingRoles != null)
                {
                    propertiesObject["hs_num_contacts_with_buying_roles"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsNumContactsWithBuyingRoles);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumDecisionMakers != null)
                {
                    propertiesObject["hs_num_decision_makers"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsNumDecisionMakers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsNumOpenDeals != null)
                {
                    propertiesObject["hs_num_open_deals"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsNumOpenDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsParentCompanyId != null)
                {
                    propertiesObject["hs_parent_company_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsParentCompanyId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTotalDealValue != null)
                {
                    propertiesObject["hs_total_deal_value"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTotalDealValue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = SourceExpressionConverter.ConvertToken(propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesisPublic != null)
                {
                    propertiesObject["is_public"] = SourceExpressionConverter.ConvertToken(propertiespropertiesisPublic);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = SourceExpressionConverter.ConvertToken(propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslinkedinCompanyPage != null)
                {
                    propertiesObject["linkedin_company_page"] = SourceExpressionConverter.ConvertToken(propertiespropertieslinkedinCompanyPage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslinkedinbio != null)
                {
                    propertiesObject["linkedinbio"] = SourceExpressionConverter.ConvertToken(propertiespropertieslinkedinbio);
                    propertiesObjectpropCount++;
                }

                propertiesObjectpropCount++;
                propertiesObject["name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesname);
                if (propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumberofemployees != null)
                {
                    propertiesObject["numberofemployees"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumberofemployees);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = SourceExpressionConverter.ConvertToken(propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = SourceExpressionConverter.ConvertToken(propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestimezone != null)
                {
                    propertiesObject["timezone"] = SourceExpressionConverter.ConvertToken(propertiespropertiestimezone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalMoneyRaised != null)
                {
                    propertiesObject["total_money_raised"] = SourceExpressionConverter.ConvertToken(propertiespropertiestotalMoneyRaised);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = SourceExpressionConverter.ConvertToken(propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterbio != null)
                {
                    propertiesObject["twitterbio"] = SourceExpressionConverter.ConvertToken(propertiespropertiestwitterbio);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterfollowers != null)
                {
                    propertiesObject["twitterfollowers"] = SourceExpressionConverter.ConvertToken(propertiespropertiestwitterfollowers);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = SourceExpressionConverter.ConvertToken(propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestype != null)
                {
                    propertiesObject["type"] = SourceExpressionConverter.ConvertToken(propertiespropertiestype);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebTechnologies != null)
                {
                    propertiesObject["web_technologies"] = SourceExpressionConverter.ConvertToken(propertiespropertieswebTechnologies);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = SourceExpressionConverter.ConvertToken(propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = SourceExpressionConverter.ConvertToken(propertiespropertieszip);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<string> properties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties[]"] = SourceExpressionConverter.ConvertO(properties);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsCreate([WorkflowExpression] Func<string> bodypropertiesaddress = null, [WorkflowExpression] Func<string> bodypropertiesannualrevenue = null, [WorkflowExpression] Func<string> bodypropertiescity = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescompany = null, [WorkflowExpression] Func<string> bodypropertiescompanySize = null, [WorkflowExpression] Func<string> bodypropertiescountry = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiescurrentlyinworkflow = null, [WorkflowExpression] Func<string> bodypropertiesdateOfBirth = null, [WorkflowExpression] Func<string> bodypropertiesdaysToClose = null, [WorkflowExpression] Func<string> bodypropertiesdegree = null, [WorkflowExpression] Func<string> bodypropertiesemail = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertiesfax = null, [WorkflowExpression] Func<string> bodypropertiesfieldOfStudy = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> bodypropertiesfirstname = null, [WorkflowExpression] Func<string> bodypropertiesgender = null, [WorkflowExpression] Func<string> bodypropertiesgraduationDate = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsAveragePageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstReferrer = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstUrl = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastReferrer = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastUrl = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumEventCompletions = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsRevenue = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsBuyingRole = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipEmailConfirmed = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipNotes = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegisteredAt = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegistrationDomainSentTo = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipRegistrationEmailSentAt = null, [WorkflowExpression] Func<string> bodypropertieshsContentMembershipStatus = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailBadAddress = null, [WorkflowExpression] Func<string> bodypropertieshsEmailBounce = null, [WorkflowExpression] Func<string> bodypropertieshsEmailClick = null, [WorkflowExpression] Func<string> bodypropertieshsEmailCustomerQuarantinedReason = null, [WorkflowExpression] Func<string> bodypropertieshsEmailDelivered = null, [WorkflowExpression] Func<string> bodypropertieshsEmailDomain = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstClickDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstOpenDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailFirstSendDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailHardBounceReasonEnum = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastClickDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastEmailName = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastOpenDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailLastSendDate = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOpen = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOptout = null, [WorkflowExpression] Func<string> bodypropertieshsEmailOptout12592317 = null, [WorkflowExpression] Func<string> bodypropertieshsEmailQuarantined = null, [WorkflowExpression] Func<string> bodypropertieshsEmailQuarantinedReason = null, [WorkflowExpression] Func<string> bodypropertieshsEmailReplied = null, [WorkflowExpression] Func<string> bodypropertieshsEmailSendsSinceLastEngagement = null, [WorkflowExpression] Func<string> bodypropertieshsEmailconfirmationstatus = null, [WorkflowExpression] Func<string> bodypropertieshsFacebookClickId = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastNpsFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastNpsRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsGoogleClickId = null, [WorkflowExpression] Func<string> bodypropertieshsIpTimezone = null, [WorkflowExpression] Func<string> bodypropertieshsIsUnworked = null, [WorkflowExpression] Func<string> bodypropertieshsLanguage = null, [WorkflowExpression] Func<string> bodypropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> bodypropertieshsLeadStatus = null, [WorkflowExpression] Func<string> bodypropertieshsLegalBasis = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageCustomerDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageEvangelistDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageLeadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageMarketingqualifiedleadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageOpportunityDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageOtherDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageSalesqualifiedleadDate = null, [WorkflowExpression] Func<string> bodypropertieshsLifecyclestageSubscriberDate = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableReasonId = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableReasonType = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableStatus = null, [WorkflowExpression] Func<string> bodypropertieshsMarketableUntilRenewal = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPersona = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscore = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivecontactscorebucket = null, [WorkflowExpression] Func<string> bodypropertieshsPredictivescoringtier = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastClicked = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastOpened = null, [WorkflowExpression] Func<string> bodypropertieshsSalesEmailLastReplied = null, [WorkflowExpression] Func<string> bodypropertieshsSequencesIsEnrolled = null, [WorkflowExpression] Func<string> bodypropertieshsTimeBetweenContactCreationAndDealClose = null, [WorkflowExpression] Func<string> bodypropertieshsTimeBetweenContactCreationAndDealCreation = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromLeadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromOpportunityToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshsTimeToMoveFromSubscriberToCustomer = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertieshubspotscore = null, [WorkflowExpression] Func<string> bodypropertiesindustry = null, [WorkflowExpression] Func<string> bodypropertiesipCity = null, [WorkflowExpression] Func<string> bodypropertiesipCountry = null, [WorkflowExpression] Func<string> bodypropertiesipCountryCode = null, [WorkflowExpression] Func<string> bodypropertiesipState = null, [WorkflowExpression] Func<string> bodypropertiesipStateCode = null, [WorkflowExpression] Func<string> bodypropertiesjobFunction = null, [WorkflowExpression] Func<string> bodypropertiesjobtitle = null, [WorkflowExpression] Func<string> bodypropertieslastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieslastname = null, [WorkflowExpression] Func<string> bodypropertieslifecyclestage = null, [WorkflowExpression] Func<string> bodypropertiesmaritalStatus = null, [WorkflowExpression] Func<string> bodypropertiesmessage = null, [WorkflowExpression] Func<string> bodypropertiesmilitaryStatus = null, [WorkflowExpression] Func<string> bodypropertiesmobilephone = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumUniqueConversionEvents = null, [WorkflowExpression] Func<string> bodypropertiesnumemployees = null, [WorkflowExpression] Func<string> bodypropertiesphone = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> bodypropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> bodypropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> bodypropertiesrelationshipStatus = null, [WorkflowExpression] Func<string> bodypropertiessalutation = null, [WorkflowExpression] Func<string> bodypropertiesschool = null, [WorkflowExpression] Func<string> bodypropertiesseniority = null, [WorkflowExpression] Func<string> bodypropertiesstartDate = null, [WorkflowExpression] Func<string> bodypropertiesstate = null, [WorkflowExpression] Func<string> bodypropertiestotalRevenue = null, [WorkflowExpression] Func<string> bodypropertiestwitterhandle = null, [WorkflowExpression] Func<string> bodypropertieswebsite = null, [WorkflowExpression] Func<string> bodypropertiesworkEmail = null, [WorkflowExpression] Func<string> bodypropertieszip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["address"] = SourceExpressionConverter.ConvertToken(bodypropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = SourceExpressionConverter.ConvertToken(bodypropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescity != null)
                {
                    propertiesObject["city"] = SourceExpressionConverter.ConvertToken(bodypropertiescity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescompany != null)
                {
                    propertiesObject["company"] = SourceExpressionConverter.ConvertToken(bodypropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = SourceExpressionConverter.ConvertToken(bodypropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescountry != null)
                {
                    propertiesObject["country"] = SourceExpressionConverter.ConvertToken(bodypropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = SourceExpressionConverter.ConvertToken(bodypropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = SourceExpressionConverter.ConvertToken(bodypropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = SourceExpressionConverter.ConvertToken(bodypropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdegree != null)
                {
                    propertiesObject["degree"] = SourceExpressionConverter.ConvertToken(bodypropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesemail != null)
                {
                    propertiesObject["email"] = SourceExpressionConverter.ConvertToken(bodypropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfax != null)
                {
                    propertiesObject["fax"] = SourceExpressionConverter.ConvertToken(bodypropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = SourceExpressionConverter.ConvertToken(bodypropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgender != null)
                {
                    propertiesObject["gender"] = SourceExpressionConverter.ConvertToken(bodypropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = SourceExpressionConverter.ConvertToken(bodypropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = SourceExpressionConverter.ConvertToken(bodypropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = SourceExpressionConverter.ConvertToken(bodypropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = SourceExpressionConverter.ConvertToken(bodypropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = SourceExpressionConverter.ConvertToken(bodypropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = SourceExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = SourceExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = SourceExpressionConverter.ConvertToken(bodypropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = SourceExpressionConverter.ConvertToken(bodypropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesindustry != null)
                {
                    propertiesObject["industry"] = SourceExpressionConverter.ConvertToken(bodypropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = SourceExpressionConverter.ConvertToken(bodypropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = SourceExpressionConverter.ConvertToken(bodypropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = SourceExpressionConverter.ConvertToken(bodypropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipState != null)
                {
                    propertiesObject["ip_state"] = SourceExpressionConverter.ConvertToken(bodypropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = SourceExpressionConverter.ConvertToken(bodypropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = SourceExpressionConverter.ConvertToken(bodypropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = SourceExpressionConverter.ConvertToken(bodypropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastname != null)
                {
                    propertiesObject["lastname"] = SourceExpressionConverter.ConvertToken(bodypropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = SourceExpressionConverter.ConvertToken(bodypropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = SourceExpressionConverter.ConvertToken(bodypropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmessage != null)
                {
                    propertiesObject["message"] = SourceExpressionConverter.ConvertToken(bodypropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = SourceExpressionConverter.ConvertToken(bodypropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = SourceExpressionConverter.ConvertToken(bodypropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesphone != null)
                {
                    propertiesObject["phone"] = SourceExpressionConverter.ConvertToken(bodypropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = SourceExpressionConverter.ConvertToken(bodypropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessalutation != null)
                {
                    propertiesObject["salutation"] = SourceExpressionConverter.ConvertToken(bodypropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesschool != null)
                {
                    propertiesObject["school"] = SourceExpressionConverter.ConvertToken(bodypropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesseniority != null)
                {
                    propertiesObject["seniority"] = SourceExpressionConverter.ConvertToken(bodypropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesstate != null)
                {
                    propertiesObject["state"] = SourceExpressionConverter.ConvertToken(bodypropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = SourceExpressionConverter.ConvertToken(bodypropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = SourceExpressionConverter.ConvertToken(bodypropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieswebsite != null)
                {
                    propertiesObject["website"] = SourceExpressionConverter.ConvertToken(bodypropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = SourceExpressionConverter.ConvertToken(bodypropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieszip != null)
                {
                    propertiesObject["zip"] = SourceExpressionConverter.ConvertToken(bodypropertieszip);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsRead([WorkflowExpression] Func<string> contactId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsArchive([WorkflowExpression] Func<string> contactId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ContactsUpdate([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> propertiespropertiesaddress = null, [WorkflowExpression] Func<string> propertiespropertiesannualrevenue = null, [WorkflowExpression] Func<string> propertiespropertiescity = null, [WorkflowExpression] Func<string> propertiespropertiesclosedate = null, [WorkflowExpression] Func<string> propertiespropertiescompany = null, [WorkflowExpression] Func<string> propertiespropertiescompanySize = null, [WorkflowExpression] Func<string> propertiespropertiescountry = null, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiescurrentlyinworkflow = null, [WorkflowExpression] Func<string> propertiespropertiesdateOfBirth = null, [WorkflowExpression] Func<string> propertiespropertiesdaysToClose = null, [WorkflowExpression] Func<string> propertiespropertiesdegree = null, [WorkflowExpression] Func<string> propertiespropertiesemail = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> propertiespropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> propertiespropertiesfax = null, [WorkflowExpression] Func<string> propertiespropertiesfieldOfStudy = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesfirstDealCreatedDate = null, [WorkflowExpression] Func<string> propertiespropertiesfirstname = null, [WorkflowExpression] Func<string> propertiespropertiesgender = null, [WorkflowExpression] Func<string> propertiespropertiesgraduationDate = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsAveragePageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstReferrer = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstUrl = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsFirstVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastReferrer = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastTouchConvertingCampaign = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastUrl = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsLastVisitTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumEventCompletions = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumPageViews = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsNumVisits = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsRevenue = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> propertiespropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> propertiespropertieshsBuyingRole = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipEmailConfirmed = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipNotes = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegisteredAt = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegistrationDomainSentTo = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipRegistrationEmailSentAt = null, [WorkflowExpression] Func<string> propertiespropertieshsContentMembershipStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailBadAddress = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailBounce = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailClick = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailCustomerQuarantinedReason = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailDelivered = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailDomain = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstClickDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstOpenDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstReplyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailFirstSendDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailHardBounceReasonEnum = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastClickDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastEmailName = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastOpenDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastReplyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailLastSendDate = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOpen = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOptout = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailOptout12592317 = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailQuarantined = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailQuarantinedReason = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailReplied = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailSendsSinceLastEngagement = null, [WorkflowExpression] Func<string> propertiespropertieshsEmailconfirmationstatus = null, [WorkflowExpression] Func<string> propertiespropertieshsFacebookClickId = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastNpsFollowUp = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastNpsRating = null, [WorkflowExpression] Func<string> propertiespropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> propertiespropertieshsGoogleClickId = null, [WorkflowExpression] Func<string> propertiespropertieshsIpTimezone = null, [WorkflowExpression] Func<string> propertiespropertieshsIsUnworked = null, [WorkflowExpression] Func<string> propertiespropertieshsLanguage = null, [WorkflowExpression] Func<string> propertiespropertieshsLastSalesActivityTimestamp = null, [WorkflowExpression] Func<string> propertiespropertieshsLeadStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsLegalBasis = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageCustomerDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageEvangelistDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageLeadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageMarketingqualifiedleadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageOpportunityDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageOtherDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageSalesqualifiedleadDate = null, [WorkflowExpression] Func<string> propertiespropertieshsLifecyclestageSubscriberDate = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableReasonId = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableReasonType = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableStatus = null, [WorkflowExpression] Func<string> propertiespropertieshsMarketableUntilRenewal = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsPersona = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscore = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscoreV2 = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivecontactscorebucket = null, [WorkflowExpression] Func<string> propertiespropertieshsPredictivescoringtier = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastClicked = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastOpened = null, [WorkflowExpression] Func<string> propertiespropertieshsSalesEmailLastReplied = null, [WorkflowExpression] Func<string> propertiespropertieshsSequencesIsEnrolled = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeBetweenContactCreationAndDealClose = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeBetweenContactCreationAndDealCreation = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromLeadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromOpportunityToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshsTimeToMoveFromSubscriberToCustomer = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> propertiespropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotTeamId = null, [WorkflowExpression] Func<string> propertiespropertieshubspotscore = null, [WorkflowExpression] Func<string> propertiespropertiesindustry = null, [WorkflowExpression] Func<string> propertiespropertiesipCity = null, [WorkflowExpression] Func<string> propertiespropertiesipCountry = null, [WorkflowExpression] Func<string> propertiespropertiesipCountryCode = null, [WorkflowExpression] Func<string> propertiespropertiesipState = null, [WorkflowExpression] Func<string> propertiespropertiesipStateCode = null, [WorkflowExpression] Func<string> propertiespropertiesjobFunction = null, [WorkflowExpression] Func<string> propertiespropertiesjobtitle = null, [WorkflowExpression] Func<string> propertiespropertieslastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieslastname = null, [WorkflowExpression] Func<string> propertiespropertieslifecyclestage = null, [WorkflowExpression] Func<string> propertiespropertiesmaritalStatus = null, [WorkflowExpression] Func<string> propertiespropertiesmessage = null, [WorkflowExpression] Func<string> propertiespropertiesmilitaryStatus = null, [WorkflowExpression] Func<string> propertiespropertiesmobilephone = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> propertiespropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> propertiespropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> propertiespropertiesnumAssociatedDeals = null, [WorkflowExpression] Func<string> propertiespropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumNotes = null, [WorkflowExpression] Func<string> propertiespropertiesnumUniqueConversionEvents = null, [WorkflowExpression] Func<string> propertiespropertiesnumemployees = null, [WorkflowExpression] Func<string> propertiespropertiesphone = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionDate = null, [WorkflowExpression] Func<string> propertiespropertiesrecentConversionEventName = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealAmount = null, [WorkflowExpression] Func<string> propertiespropertiesrecentDealCloseDate = null, [WorkflowExpression] Func<string> propertiespropertiesrelationshipStatus = null, [WorkflowExpression] Func<string> propertiespropertiessalutation = null, [WorkflowExpression] Func<string> propertiespropertiesschool = null, [WorkflowExpression] Func<string> propertiespropertiesseniority = null, [WorkflowExpression] Func<string> propertiespropertiesstartDate = null, [WorkflowExpression] Func<string> propertiespropertiesstate = null, [WorkflowExpression] Func<string> propertiespropertiestotalRevenue = null, [WorkflowExpression] Func<string> propertiespropertiestwitterhandle = null, [WorkflowExpression] Func<string> propertiespropertieswebsite = null, [WorkflowExpression] Func<string> propertiespropertiesworkEmail = null, [WorkflowExpression] Func<string> propertiespropertieszip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiesaddress != null)
                {
                    propertiesObject["address"] = SourceExpressionConverter.ConvertToken(propertiespropertiesaddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesannualrevenue != null)
                {
                    propertiesObject["annualrevenue"] = SourceExpressionConverter.ConvertToken(propertiespropertiesannualrevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescity != null)
                {
                    propertiesObject["city"] = SourceExpressionConverter.ConvertToken(propertiespropertiescity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(propertiespropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescompany != null)
                {
                    propertiesObject["company"] = SourceExpressionConverter.ConvertToken(propertiespropertiescompany);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescompanySize != null)
                {
                    propertiesObject["company_size"] = SourceExpressionConverter.ConvertToken(propertiespropertiescompanySize);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescountry != null)
                {
                    propertiesObject["country"] = SourceExpressionConverter.ConvertToken(propertiespropertiescountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiescurrentlyinworkflow != null)
                {
                    propertiesObject["currentlyinworkflow"] = SourceExpressionConverter.ConvertToken(propertiespropertiescurrentlyinworkflow);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdateOfBirth != null)
                {
                    propertiesObject["date_of_birth"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdateOfBirth);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdaysToClose != null)
                {
                    propertiesObject["days_to_close"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdaysToClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdegree != null)
                {
                    propertiesObject["degree"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdegree);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesemail != null)
                {
                    propertiesObject["email"] = SourceExpressionConverter.ConvertToken(propertiespropertiesemail);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(propertiespropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfax != null)
                {
                    propertiesObject["fax"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfax);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfieldOfStudy != null)
                {
                    propertiesObject["field_of_study"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfieldOfStudy);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionDate != null)
                {
                    propertiesObject["first_conversion_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstConversionEventName != null)
                {
                    propertiesObject["first_conversion_event_name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstDealCreatedDate != null)
                {
                    propertiesObject["first_deal_created_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstDealCreatedDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesfirstname != null)
                {
                    propertiesObject["firstname"] = SourceExpressionConverter.ConvertToken(propertiespropertiesfirstname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgender != null)
                {
                    propertiesObject["gender"] = SourceExpressionConverter.ConvertToken(propertiespropertiesgender);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesgraduationDate != null)
                {
                    propertiesObject["graduation_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesgraduationDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsAveragePageViews != null)
                {
                    propertiesObject["hs_analytics_average_page_views"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsAveragePageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstReferrer != null)
                {
                    propertiesObject["hs_analytics_first_referrer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstReferrer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_first_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstUrl != null)
                {
                    propertiesObject["hs_analytics_first_url"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsFirstVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_first_visit_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsFirstVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastReferrer != null)
                {
                    propertiesObject["hs_analytics_last_referrer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastReferrer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastTouchConvertingCampaign != null)
                {
                    propertiesObject["hs_analytics_last_touch_converting_campaign"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastTouchConvertingCampaign);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastUrl != null)
                {
                    propertiesObject["hs_analytics_last_url"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsLastVisitTimestamp != null)
                {
                    propertiesObject["hs_analytics_last_visit_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsLastVisitTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumEventCompletions != null)
                {
                    propertiesObject["hs_analytics_num_event_completions"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumEventCompletions);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumPageViews != null)
                {
                    propertiesObject["hs_analytics_num_page_views"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumPageViews);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsNumVisits != null)
                {
                    propertiesObject["hs_analytics_num_visits"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsNumVisits);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsRevenue != null)
                {
                    propertiesObject["hs_analytics_revenue"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsBuyingRole != null)
                {
                    propertiesObject["hs_buying_role"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsBuyingRole);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipEmailConfirmed != null)
                {
                    propertiesObject["hs_content_membership_email_confirmed"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipEmailConfirmed);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipNotes != null)
                {
                    propertiesObject["hs_content_membership_notes"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegisteredAt != null)
                {
                    propertiesObject["hs_content_membership_registered_at"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegisteredAt);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegistrationDomainSentTo != null)
                {
                    propertiesObject["hs_content_membership_registration_domain_sent_to"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegistrationDomainSentTo);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipRegistrationEmailSentAt != null)
                {
                    propertiesObject["hs_content_membership_registration_email_sent_at"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipRegistrationEmailSentAt);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsContentMembershipStatus != null)
                {
                    propertiesObject["hs_content_membership_status"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsContentMembershipStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailBadAddress != null)
                {
                    propertiesObject["hs_email_bad_address"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailBadAddress);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailBounce != null)
                {
                    propertiesObject["hs_email_bounce"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailBounce);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailClick != null)
                {
                    propertiesObject["hs_email_click"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailClick);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailCustomerQuarantinedReason != null)
                {
                    propertiesObject["hs_email_customer_quarantined_reason"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailCustomerQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailDelivered != null)
                {
                    propertiesObject["hs_email_delivered"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailDelivered);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailDomain != null)
                {
                    propertiesObject["hs_email_domain"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailDomain);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstClickDate != null)
                {
                    propertiesObject["hs_email_first_click_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstClickDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstOpenDate != null)
                {
                    propertiesObject["hs_email_first_open_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstOpenDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstReplyDate != null)
                {
                    propertiesObject["hs_email_first_reply_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstReplyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailFirstSendDate != null)
                {
                    propertiesObject["hs_email_first_send_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailFirstSendDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailHardBounceReasonEnum != null)
                {
                    propertiesObject["hs_email_hard_bounce_reason_enum"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailHardBounceReasonEnum);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastClickDate != null)
                {
                    propertiesObject["hs_email_last_click_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailLastClickDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastEmailName != null)
                {
                    propertiesObject["hs_email_last_email_name"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailLastEmailName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastOpenDate != null)
                {
                    propertiesObject["hs_email_last_open_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailLastOpenDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastReplyDate != null)
                {
                    propertiesObject["hs_email_last_reply_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailLastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailLastSendDate != null)
                {
                    propertiesObject["hs_email_last_send_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailLastSendDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOpen != null)
                {
                    propertiesObject["hs_email_open"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailOpen);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOptout != null)
                {
                    propertiesObject["hs_email_optout"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailOptout);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailOptout12592317 != null)
                {
                    propertiesObject["hs_email_optout_12592317"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailOptout12592317);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailQuarantined != null)
                {
                    propertiesObject["hs_email_quarantined"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailQuarantined);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailQuarantinedReason != null)
                {
                    propertiesObject["hs_email_quarantined_reason"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailQuarantinedReason);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailReplied != null)
                {
                    propertiesObject["hs_email_replied"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailReplied);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailSendsSinceLastEngagement != null)
                {
                    propertiesObject["hs_email_sends_since_last_engagement"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailSendsSinceLastEngagement);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsEmailconfirmationstatus != null)
                {
                    propertiesObject["hs_emailconfirmationstatus"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsEmailconfirmationstatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFacebookClickId != null)
                {
                    propertiesObject["hs_facebook_click_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsFacebookClickId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastNpsFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_nps_follow_up"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastNpsFollowUp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastNpsRating != null)
                {
                    propertiesObject["hs_feedback_last_nps_rating"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastNpsRating);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsGoogleClickId != null)
                {
                    propertiesObject["hs_google_click_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsGoogleClickId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIpTimezone != null)
                {
                    propertiesObject["hs_ip_timezone"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsIpTimezone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsIsUnworked != null)
                {
                    propertiesObject["hs_is_unworked"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsIsUnworked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLanguage != null)
                {
                    propertiesObject["hs_language"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLanguage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastSalesActivityTimestamp != null)
                {
                    propertiesObject["hs_last_sales_activity_timestamp"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastSalesActivityTimestamp);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLeadStatus != null)
                {
                    propertiesObject["hs_lead_status"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLeadStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLegalBasis != null)
                {
                    propertiesObject["hs_legal_basis"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLegalBasis);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageCustomerDate != null)
                {
                    propertiesObject["hs_lifecyclestage_customer_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageCustomerDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageEvangelistDate != null)
                {
                    propertiesObject["hs_lifecyclestage_evangelist_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageEvangelistDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageLeadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_lead_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageLeadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageMarketingqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_marketingqualifiedlead_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageMarketingqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageOpportunityDate != null)
                {
                    propertiesObject["hs_lifecyclestage_opportunity_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageOpportunityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageOtherDate != null)
                {
                    propertiesObject["hs_lifecyclestage_other_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageOtherDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageSalesqualifiedleadDate != null)
                {
                    propertiesObject["hs_lifecyclestage_salesqualifiedlead_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageSalesqualifiedleadDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLifecyclestageSubscriberDate != null)
                {
                    propertiesObject["hs_lifecyclestage_subscriber_date"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLifecyclestageSubscriberDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableReasonId != null)
                {
                    propertiesObject["hs_marketable_reason_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsMarketableReasonId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableReasonType != null)
                {
                    propertiesObject["hs_marketable_reason_type"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsMarketableReasonType);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableStatus != null)
                {
                    propertiesObject["hs_marketable_status"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsMarketableStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsMarketableUntilRenewal != null)
                {
                    propertiesObject["hs_marketable_until_renewal"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsMarketableUntilRenewal);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPersona != null)
                {
                    propertiesObject["hs_persona"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPersona);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscore != null)
                {
                    propertiesObject["hs_predictivecontactscore"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscore);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscoreV2 != null)
                {
                    propertiesObject["hs_predictivecontactscore_v2"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscoreV2);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivecontactscorebucket != null)
                {
                    propertiesObject["hs_predictivecontactscorebucket"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPredictivecontactscorebucket);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsPredictivescoringtier != null)
                {
                    propertiesObject["hs_predictivescoringtier"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsPredictivescoringtier);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastClicked != null)
                {
                    propertiesObject["hs_sales_email_last_clicked"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastClicked);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastOpened != null)
                {
                    propertiesObject["hs_sales_email_last_opened"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastOpened);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSalesEmailLastReplied != null)
                {
                    propertiesObject["hs_sales_email_last_replied"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsSalesEmailLastReplied);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSequencesIsEnrolled != null)
                {
                    propertiesObject["hs_sequences_is_enrolled"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsSequencesIsEnrolled);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeBetweenContactCreationAndDealClose != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_close"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeBetweenContactCreationAndDealClose);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeBetweenContactCreationAndDealCreation != null)
                {
                    propertiesObject["hs_time_between_contact_creation_and_deal_creation"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeBetweenContactCreationAndDealCreation);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromLeadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_lead_to_customer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromLeadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_marketingqualifiedlead_to_customer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromMarketingqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromOpportunityToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_opportunity_to_customer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromOpportunityToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_salesqualifiedlead_to_customer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromSalesqualifiedleadToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsTimeToMoveFromSubscriberToCustomer != null)
                {
                    propertiesObject["hs_time_to_move_from_subscriber_to_customer"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsTimeToMoveFromSubscriberToCustomer);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshubspotscore != null)
                {
                    propertiesObject["hubspotscore"] = SourceExpressionConverter.ConvertToken(propertiespropertieshubspotscore);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesindustry != null)
                {
                    propertiesObject["industry"] = SourceExpressionConverter.ConvertToken(propertiespropertiesindustry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCity != null)
                {
                    propertiesObject["ip_city"] = SourceExpressionConverter.ConvertToken(propertiespropertiesipCity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCountry != null)
                {
                    propertiesObject["ip_country"] = SourceExpressionConverter.ConvertToken(propertiespropertiesipCountry);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipCountryCode != null)
                {
                    propertiesObject["ip_country_code"] = SourceExpressionConverter.ConvertToken(propertiespropertiesipCountryCode);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipState != null)
                {
                    propertiesObject["ip_state"] = SourceExpressionConverter.ConvertToken(propertiespropertiesipState);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesipStateCode != null)
                {
                    propertiesObject["ip_state_code"] = SourceExpressionConverter.ConvertToken(propertiespropertiesipStateCode);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesjobFunction != null)
                {
                    propertiesObject["job_function"] = SourceExpressionConverter.ConvertToken(propertiespropertiesjobFunction);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesjobtitle != null)
                {
                    propertiesObject["jobtitle"] = SourceExpressionConverter.ConvertToken(propertiespropertiesjobtitle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslastmodifieddate != null)
                {
                    propertiesObject["lastmodifieddate"] = SourceExpressionConverter.ConvertToken(propertiespropertieslastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslastname != null)
                {
                    propertiesObject["lastname"] = SourceExpressionConverter.ConvertToken(propertiespropertieslastname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieslifecyclestage != null)
                {
                    propertiesObject["lifecyclestage"] = SourceExpressionConverter.ConvertToken(propertiespropertieslifecyclestage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmaritalStatus != null)
                {
                    propertiesObject["marital_status"] = SourceExpressionConverter.ConvertToken(propertiespropertiesmaritalStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmessage != null)
                {
                    propertiesObject["message"] = SourceExpressionConverter.ConvertToken(propertiespropertiesmessage);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmilitaryStatus != null)
                {
                    propertiesObject["military_status"] = SourceExpressionConverter.ConvertToken(propertiespropertiesmilitaryStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesmobilephone != null)
                {
                    propertiesObject["mobilephone"] = SourceExpressionConverter.ConvertToken(propertiespropertiesmobilephone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumAssociatedDeals != null)
                {
                    propertiesObject["num_associated_deals"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumAssociatedDeals);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumConversionEvents != null)
                {
                    propertiesObject["num_conversion_events"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumUniqueConversionEvents != null)
                {
                    propertiesObject["num_unique_conversion_events"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumUniqueConversionEvents);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesnumemployees != null)
                {
                    propertiesObject["numemployees"] = SourceExpressionConverter.ConvertToken(propertiespropertiesnumemployees);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesphone != null)
                {
                    propertiesObject["phone"] = SourceExpressionConverter.ConvertToken(propertiespropertiesphone);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionDate != null)
                {
                    propertiesObject["recent_conversion_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentConversionDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentConversionEventName != null)
                {
                    propertiesObject["recent_conversion_event_name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentConversionEventName);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealAmount != null)
                {
                    propertiesObject["recent_deal_amount"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentDealAmount);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecentDealCloseDate != null)
                {
                    propertiesObject["recent_deal_close_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecentDealCloseDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrelationshipStatus != null)
                {
                    propertiesObject["relationship_status"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrelationshipStatus);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiessalutation != null)
                {
                    propertiesObject["salutation"] = SourceExpressionConverter.ConvertToken(propertiespropertiessalutation);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesschool != null)
                {
                    propertiesObject["school"] = SourceExpressionConverter.ConvertToken(propertiespropertiesschool);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesseniority != null)
                {
                    propertiesObject["seniority"] = SourceExpressionConverter.ConvertToken(propertiespropertiesseniority);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstartDate != null)
                {
                    propertiesObject["start_date"] = SourceExpressionConverter.ConvertToken(propertiespropertiesstartDate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesstate != null)
                {
                    propertiesObject["state"] = SourceExpressionConverter.ConvertToken(propertiespropertiesstate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestotalRevenue != null)
                {
                    propertiesObject["total_revenue"] = SourceExpressionConverter.ConvertToken(propertiespropertiestotalRevenue);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestwitterhandle != null)
                {
                    propertiesObject["twitterhandle"] = SourceExpressionConverter.ConvertToken(propertiespropertiestwitterhandle);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieswebsite != null)
                {
                    propertiesObject["website"] = SourceExpressionConverter.ConvertToken(propertiespropertieswebsite);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesworkEmail != null)
                {
                    propertiesObject["work_email"] = SourceExpressionConverter.ConvertToken(propertiespropertiesworkEmail);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieszip != null)
                {
                    propertiesObject["zip"] = SourceExpressionConverter.ConvertToken(propertiespropertieszip);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsList([WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> after = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/deals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (after != null)
                    callPayload.Queries["after"] = SourceExpressionConverter.ConvertO(after);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsCreate([WorkflowExpression] Func<string> bodypropertiesamount = null, [WorkflowExpression] Func<string> bodypropertiesamountInHomeCurrency = null, [WorkflowExpression] Func<string> bodypropertiesclosedLostReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedWonReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdealname = null, [WorkflowExpression] Func<string> bodypropertiesdealstage = null, [WorkflowExpression] Func<string> bodypropertiesdealtype = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertieshsAcv = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsArr = null, [WorkflowExpression] Func<string> bodypropertieshsForecastAmount = null, [WorkflowExpression] Func<string> bodypropertieshsForecastProbability = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsManualForecastCategory = null, [WorkflowExpression] Func<string> bodypropertieshsMrr = null, [WorkflowExpression] Func<string> bodypropertieshsNextStep = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPriority = null, [WorkflowExpression] Func<string> bodypropertieshsTcv = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiespipeline = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["amount"] = SourceExpressionConverter.ConvertToken(bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = SourceExpressionConverter.ConvertToken(bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = SourceExpressionConverter.ConvertToken(bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = SourceExpressionConverter.ConvertToken(bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = SourceExpressionConverter.ConvertToken(bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = SourceExpressionConverter.ConvertToken(bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = SourceExpressionConverter.ConvertToken(bodypropertiespipeline);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsRead([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsArchive([WorkflowExpression] Func<string> dealId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction DealsUpdate([WorkflowExpression] Func<string> dealId, [WorkflowExpression] Func<string> bodypropertiesamount = null, [WorkflowExpression] Func<string> bodypropertiesamountInHomeCurrency = null, [WorkflowExpression] Func<string> bodypropertiesclosedLostReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedWonReason = null, [WorkflowExpression] Func<string> bodypropertiesclosedate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdealname = null, [WorkflowExpression] Func<string> bodypropertiesdealstage = null, [WorkflowExpression] Func<string> bodypropertiesdealtype = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBooked = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedCampaign = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedMedium = null, [WorkflowExpression] Func<string> bodypropertiesengagementsLastMeetingBookedSource = null, [WorkflowExpression] Func<string> bodypropertieshsAcv = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSource = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData1 = null, [WorkflowExpression] Func<string> bodypropertieshsAnalyticsSourceData2 = null, [WorkflowExpression] Func<string> bodypropertieshsArr = null, [WorkflowExpression] Func<string> bodypropertieshsForecastAmount = null, [WorkflowExpression] Func<string> bodypropertieshsForecastProbability = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsManualForecastCategory = null, [WorkflowExpression] Func<string> bodypropertieshsMrr = null, [WorkflowExpression] Func<string> bodypropertieshsNextStep = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsPriority = null, [WorkflowExpression] Func<string> bodypropertieshsTcv = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastContacted = null, [WorkflowExpression] Func<string> bodypropertiesnotesLastUpdated = null, [WorkflowExpression] Func<string> bodypropertiesnotesNextActivityDate = null, [WorkflowExpression] Func<string> bodypropertiesnumAssociatedContacts = null, [WorkflowExpression] Func<string> bodypropertiesnumContactedNotes = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiespipeline = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/deals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dealId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesamount != null)
                {
                    propertiesObject["amount"] = SourceExpressionConverter.ConvertToken(bodypropertiesamount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesamountInHomeCurrency != null)
                {
                    propertiesObject["amount_in_home_currency"] = SourceExpressionConverter.ConvertToken(bodypropertiesamountInHomeCurrency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedLostReason != null)
                {
                    propertiesObject["closed_lost_reason"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedLostReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedWonReason != null)
                {
                    propertiesObject["closed_won_reason"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedWonReason);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesclosedate != null)
                {
                    propertiesObject["closedate"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealname != null)
                {
                    propertiesObject["dealname"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealstage != null)
                {
                    propertiesObject["dealstage"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealstage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdealtype != null)
                {
                    propertiesObject["dealtype"] = SourceExpressionConverter.ConvertToken(bodypropertiesdealtype);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBooked != null)
                {
                    propertiesObject["engagements_last_meeting_booked"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBooked);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedCampaign != null)
                {
                    propertiesObject["engagements_last_meeting_booked_campaign"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedCampaign);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedMedium != null)
                {
                    propertiesObject["engagements_last_meeting_booked_medium"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedMedium);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesengagementsLastMeetingBookedSource != null)
                {
                    propertiesObject["engagements_last_meeting_booked_source"] = SourceExpressionConverter.ConvertToken(bodypropertiesengagementsLastMeetingBookedSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAcv != null)
                {
                    propertiesObject["hs_acv"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSource != null)
                {
                    propertiesObject["hs_analytics_source"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSource);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData1 != null)
                {
                    propertiesObject["hs_analytics_source_data_1"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData1);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsAnalyticsSourceData2 != null)
                {
                    propertiesObject["hs_analytics_source_data_2"] = SourceExpressionConverter.ConvertToken(bodypropertieshsAnalyticsSourceData2);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsArr != null)
                {
                    propertiesObject["hs_arr"] = SourceExpressionConverter.ConvertToken(bodypropertieshsArr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastAmount != null)
                {
                    propertiesObject["hs_forecast_amount"] = SourceExpressionConverter.ConvertToken(bodypropertieshsForecastAmount);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsForecastProbability != null)
                {
                    propertiesObject["hs_forecast_probability"] = SourceExpressionConverter.ConvertToken(bodypropertieshsForecastProbability);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsManualForecastCategory != null)
                {
                    propertiesObject["hs_manual_forecast_category"] = SourceExpressionConverter.ConvertToken(bodypropertieshsManualForecastCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsMrr != null)
                {
                    propertiesObject["hs_mrr"] = SourceExpressionConverter.ConvertToken(bodypropertieshsMrr);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextStep != null)
                {
                    propertiesObject["hs_next_step"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNextStep);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPriority != null)
                {
                    propertiesObject["hs_priority"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTcv != null)
                {
                    propertiesObject["hs_tcv"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTcv);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastContacted != null)
                {
                    propertiesObject["notes_last_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesLastUpdated != null)
                {
                    propertiesObject["notes_last_updated"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesLastUpdated);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnotesNextActivityDate != null)
                {
                    propertiesObject["notes_next_activity_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesnotesNextActivityDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumAssociatedContacts != null)
                {
                    propertiesObject["num_associated_contacts"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumAssociatedContacts);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumContactedNotes != null)
                {
                    propertiesObject["num_contacted_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumContactedNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiespipeline != null)
                {
                    propertiesObject["pipeline"] = SourceExpressionConverter.ConvertToken(bodypropertiespipeline);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsCreate([WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesdescription = null, [WorkflowExpression] Func<string> bodypropertieshsCostOfGoodsSold = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedByUserId = null, [WorkflowExpression] Func<string> bodypropertieshsCreatedate = null, [WorkflowExpression] Func<string> bodypropertieshsImages = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsObjectId = null, [WorkflowExpression] Func<string> bodypropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> bodypropertieshsSku = null, [WorkflowExpression] Func<string> bodypropertieshsUpdatedByUserId = null, [WorkflowExpression] Func<string> bodypropertieshsUrl = null, [WorkflowExpression] Func<string> bodypropertiesname = null, [WorkflowExpression] Func<string> bodypropertiesprice = null, [WorkflowExpression] Func<string> bodypropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> bodypropertiestax = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(bodypropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = SourceExpressionConverter.ConvertToken(bodypropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = SourceExpressionConverter.ConvertToken(bodypropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = SourceExpressionConverter.ConvertToken(bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = SourceExpressionConverter.ConvertToken(bodypropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = SourceExpressionConverter.ConvertToken(bodypropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesname != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesprice != null)
                {
                    propertiesObject["price"] = SourceExpressionConverter.ConvertToken(bodypropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestax != null)
                {
                    propertiesObject["tax"] = SourceExpressionConverter.ConvertToken(bodypropertiestax);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsRead([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsArchive([WorkflowExpression] Func<string> productId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction ProductsUpdate([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> propertiespropertiescreatedate = null, [WorkflowExpression] Func<string> propertiespropertiesdescription = null, [WorkflowExpression] Func<string> propertiespropertieshsCostOfGoodsSold = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedByUserId = null, [WorkflowExpression] Func<string> propertiespropertieshsCreatedate = null, [WorkflowExpression] Func<string> propertiespropertieshsImages = null, [WorkflowExpression] Func<string> propertiespropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> propertiespropertieshsObjectId = null, [WorkflowExpression] Func<string> propertiespropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> propertiespropertieshsSku = null, [WorkflowExpression] Func<string> propertiespropertieshsUpdatedByUserId = null, [WorkflowExpression] Func<string> propertiespropertieshsUrl = null, [WorkflowExpression] Func<string> propertiespropertiesname = null, [WorkflowExpression] Func<string> propertiespropertiesprice = null, [WorkflowExpression] Func<string> propertiespropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> propertiespropertiestax = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/products/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var properties = new JObject();
                var propertiespropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiespropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(propertiespropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCostOfGoodsSold != null)
                {
                    propertiesObject["hs_cost_of_goods_sold"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsCostOfGoodsSold);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedByUserId != null)
                {
                    propertiesObject["hs_created_by_user_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsCreatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsCreatedate != null)
                {
                    propertiesObject["hs_createdate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsCreatedate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsImages != null)
                {
                    propertiesObject["hs_images"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsImages);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsObjectId != null)
                {
                    propertiesObject["hs_object_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsObjectId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsSku != null)
                {
                    propertiesObject["hs_sku"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsSku);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsUpdatedByUserId != null)
                {
                    propertiesObject["hs_updated_by_user_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsUpdatedByUserId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsUrl != null)
                {
                    propertiesObject["hs_url"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsUrl);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesname != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = SourceExpressionConverter.ConvertToken(propertiespropertiesprice);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiestax != null)
                {
                    propertiesObject["tax"] = SourceExpressionConverter.ConvertToken(propertiespropertiestax);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsList([WorkflowExpression] Func<int> limit, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/line_items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = SourceExpressionConverter.ConvertO(associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsCreate([WorkflowExpression] Func<string> propertiespropertiesname = null, [WorkflowExpression] Func<string> propertiespropertieshsProductId = null, [WorkflowExpression] Func<string> propertiespropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> propertiespropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> propertiespropertiesquantity = null, [WorkflowExpression] Func<string> propertiespropertiesprice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(propertiespropertiesname);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = SourceExpressionConverter.ConvertToken(propertiespropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = SourceExpressionConverter.ConvertToken(propertiespropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesquantity != null)
                {
                    propertiesObject["quantity"] = SourceExpressionConverter.ConvertToken(propertiespropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (propertiespropertiesprice != null)
                {
                    propertiesObject["price"] = SourceExpressionConverter.ConvertToken(propertiespropertiesprice);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsRead([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = SourceExpressionConverter.ConvertO(associations);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = SourceExpressionConverter.ConvertO(idProperty);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsArchive([WorkflowExpression] Func<string> lineItemId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction LineItemsUpdate([WorkflowExpression] Func<string> lineItemId, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<string> bodypropertiesname = null, [WorkflowExpression] Func<string> bodypropertieshsProductId = null, [WorkflowExpression] Func<string> bodypropertieshsRecurringBillingPeriod = null, [WorkflowExpression] Func<string> bodypropertiesrecurringbillingfrequency = null, [WorkflowExpression] Func<string> bodypropertiesquantity = null, [WorkflowExpression] Func<string> bodypropertiesprice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/line_items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(lineItemId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = SourceExpressionConverter.ConvertO(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesname != null)
                {
                    propertiesObject["name"] = SourceExpressionConverter.ConvertToken(bodypropertiesname);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsProductId != null)
                {
                    propertiesObject["hs_product_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsProductId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsRecurringBillingPeriod != null)
                {
                    propertiesObject["hs_recurring_billing_period"] = SourceExpressionConverter.ConvertToken(bodypropertieshsRecurringBillingPeriod);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesrecurringbillingfrequency != null)
                {
                    propertiesObject["recurringbillingfrequency"] = SourceExpressionConverter.ConvertToken(bodypropertiesrecurringbillingfrequency);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesquantity != null)
                {
                    propertiesObject["quantity"] = SourceExpressionConverter.ConvertToken(bodypropertiesquantity);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesprice != null)
                {
                    propertiesObject["price"] = SourceExpressionConverter.ConvertToken(bodypropertiesprice);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<string> associations = null, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm/v3/objects/tickets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                if (associations != null)
                    callPayload.Queries["associations"] = SourceExpressionConverter.ConvertO(associations);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsCreate([WorkflowExpression] Func<string> bodypropertiesclosedDate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstAgentReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsLastcontacted = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsNextactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsNumTimesContacted = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieslastReplyDate = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiestimeToClose = null, [WorkflowExpression] Func<string> bodypropertiestimeToFirstAgentReply = null, [WorkflowExpression] Func<string> bodypropertiescontent = null, [WorkflowExpression] Func<string> bodypropertieshsFileUpload = null, [WorkflowExpression] Func<string> bodypropertieshsNumAssociatedCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsPipeline = null, [WorkflowExpression] Func<string> bodypropertieshsPipelineStage = null, [WorkflowExpression] Func<string> bodypropertieshsResolution = null, [WorkflowExpression] Func<string> bodypropertieshsTicketCategory = null, [WorkflowExpression] Func<string> bodypropertieshsTicketId = null, [WorkflowExpression] Func<string> bodypropertieshsTicketPriority = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiessourceType = null, [WorkflowExpression] Func<string> bodypropertiessubject = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    propertiesObject["closed_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = SourceExpressionConverter.ConvertToken(bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = SourceExpressionConverter.ConvertToken(bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescontent != null)
                {
                    propertiesObject["content"] = SourceExpressionConverter.ConvertToken(bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = SourceExpressionConverter.ConvertToken(bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = SourceExpressionConverter.ConvertToken(bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = SourceExpressionConverter.ConvertToken(bodypropertiessubject);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsRead([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> properties = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> idProperty = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (properties != null)
                    callPayload.Queries["properties"] = SourceExpressionConverter.ConvertO(properties);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = SourceExpressionConverter.ConvertO(idProperty);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsArchive([WorkflowExpression] Func<string> ticketId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcrm")]
        public IWorkflowAction TicketsUpdate([WorkflowExpression] Func<string> ticketId, [WorkflowExpression] Func<string> idProperty = null, [WorkflowExpression] Func<string> bodypropertiesclosedDate = null, [WorkflowExpression] Func<string> bodypropertiescreatedate = null, [WorkflowExpression] Func<string> bodypropertiesfirstAgentReplyDate = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesFollowUp = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastCesRating = null, [WorkflowExpression] Func<string> bodypropertieshsFeedbackLastSurveyDate = null, [WorkflowExpression] Func<string> bodypropertieshsLastactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsLastcontacted = null, [WorkflowExpression] Func<string> bodypropertieshsLastmodifieddate = null, [WorkflowExpression] Func<string> bodypropertieshsNextactivitydate = null, [WorkflowExpression] Func<string> bodypropertieshsNumTimesContacted = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerAssigneddate = null, [WorkflowExpression] Func<string> bodypropertieslastReplyDate = null, [WorkflowExpression] Func<string> bodypropertiesnumNotes = null, [WorkflowExpression] Func<string> bodypropertiestimeToClose = null, [WorkflowExpression] Func<string> bodypropertiestimeToFirstAgentReply = null, [WorkflowExpression] Func<string> bodypropertiescontent = null, [WorkflowExpression] Func<string> bodypropertieshsFileUpload = null, [WorkflowExpression] Func<string> bodypropertieshsNumAssociatedCompanies = null, [WorkflowExpression] Func<string> bodypropertieshsPipeline = null, [WorkflowExpression] Func<string> bodypropertieshsPipelineStage = null, [WorkflowExpression] Func<string> bodypropertieshsResolution = null, [WorkflowExpression] Func<string> bodypropertieshsTicketCategory = null, [WorkflowExpression] Func<string> bodypropertieshsTicketId = null, [WorkflowExpression] Func<string> bodypropertieshsTicketPriority = null, [WorkflowExpression] Func<string> bodypropertieshubspotOwnerId = null, [WorkflowExpression] Func<string> bodypropertieshubspotTeamId = null, [WorkflowExpression] Func<string> bodypropertiessourceType = null, [WorkflowExpression] Func<string> bodypropertiessubject = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm/v3/objects/tickets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ticketId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (idProperty != null)
                    callPayload.Queries["idProperty"] = SourceExpressionConverter.ConvertO(idProperty);
                var body = new JObject();
                var bodypropCount = 0;
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (bodypropertiesclosedDate != null)
                {
                    propertiesObject["closed_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesclosedDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescreatedate != null)
                {
                    propertiesObject["createdate"] = SourceExpressionConverter.ConvertToken(bodypropertiescreatedate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesfirstAgentReplyDate != null)
                {
                    propertiesObject["first_agent_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertiesfirstAgentReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesFollowUp != null)
                {
                    propertiesObject["hs_feedback_last_ces_follow_up"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesFollowUp);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastCesRating != null)
                {
                    propertiesObject["hs_feedback_last_ces_rating"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastCesRating);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFeedbackLastSurveyDate != null)
                {
                    propertiesObject["hs_feedback_last_survey_date"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFeedbackLastSurveyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastactivitydate != null)
                {
                    propertiesObject["hs_lastactivitydate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastcontacted != null)
                {
                    propertiesObject["hs_lastcontacted"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastcontacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsLastmodifieddate != null)
                {
                    propertiesObject["hs_lastmodifieddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsLastmodifieddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNextactivitydate != null)
                {
                    propertiesObject["hs_nextactivitydate"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNextactivitydate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumTimesContacted != null)
                {
                    propertiesObject["hs_num_times_contacted"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumTimesContacted);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerAssigneddate != null)
                {
                    propertiesObject["hubspot_owner_assigneddate"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerAssigneddate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieslastReplyDate != null)
                {
                    propertiesObject["last_reply_date"] = SourceExpressionConverter.ConvertToken(bodypropertieslastReplyDate);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiesnumNotes != null)
                {
                    propertiesObject["num_notes"] = SourceExpressionConverter.ConvertToken(bodypropertiesnumNotes);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToClose != null)
                {
                    propertiesObject["time_to_close"] = SourceExpressionConverter.ConvertToken(bodypropertiestimeToClose);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiestimeToFirstAgentReply != null)
                {
                    propertiesObject["time_to_first_agent_reply"] = SourceExpressionConverter.ConvertToken(bodypropertiestimeToFirstAgentReply);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiescontent != null)
                {
                    propertiesObject["content"] = SourceExpressionConverter.ConvertToken(bodypropertiescontent);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsFileUpload != null)
                {
                    propertiesObject["hs_file_upload"] = SourceExpressionConverter.ConvertToken(bodypropertieshsFileUpload);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsNumAssociatedCompanies != null)
                {
                    propertiesObject["hs_num_associated_companies"] = SourceExpressionConverter.ConvertToken(bodypropertieshsNumAssociatedCompanies);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipeline != null)
                {
                    propertiesObject["hs_pipeline"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPipeline);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsPipelineStage != null)
                {
                    propertiesObject["hs_pipeline_stage"] = SourceExpressionConverter.ConvertToken(bodypropertieshsPipelineStage);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsResolution != null)
                {
                    propertiesObject["hs_resolution"] = SourceExpressionConverter.ConvertToken(bodypropertieshsResolution);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketCategory != null)
                {
                    propertiesObject["hs_ticket_category"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketCategory);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketId != null)
                {
                    propertiesObject["hs_ticket_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshsTicketPriority != null)
                {
                    propertiesObject["hs_ticket_priority"] = SourceExpressionConverter.ConvertToken(bodypropertieshsTicketPriority);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotOwnerId != null)
                {
                    propertiesObject["hubspot_owner_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotOwnerId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertieshubspotTeamId != null)
                {
                    propertiesObject["hubspot_team_id"] = SourceExpressionConverter.ConvertToken(bodypropertieshubspotTeamId);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessourceType != null)
                {
                    propertiesObject["source_type"] = SourceExpressionConverter.ConvertToken(bodypropertiessourceType);
                    propertiesObjectpropCount++;
                }

                if (bodypropertiessubject != null)
                {
                    propertiesObject["subject"] = SourceExpressionConverter.ConvertToken(bodypropertiessubject);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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