//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Blackbaudcrmprospect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmprospectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedUnplannedContactReport> CreateUnplannedContactReport(Expression<Func<string>> bodyplanID, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodyactualDate, Expression<Func<string>> bodystage, Expression<Func<string>> bodycontactMethod, Expression<Func<string>> bodycomment, Expression<Func<string>> bodyowner = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<PrsmgNewUnplannedContactReportFundraiser[]>> bodyfundraisers = null, Expression<Func<PrsmgNewUnplannedContactReportParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = "/crm-prsmg/prospectcontactreports";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prospect_plan_id"] = ExpressionConverter.ConvertO(bodyplanID);
            bodypropCount++;
            body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
            if (bodyowner != null)
            {
                body["owner_id"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            bodypropCount++;
            body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["prospect_plan_status"] = ExpressionConverter.ConvertO(bodystage);
            bodypropCount++;
            body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["comment"] = ExpressionConverter.ConvertO(bodycomment);
            if (bodyfundraisers != null)
            {
                body["additional_fundraisers"] = ExpressionConverter.ConvertO(bodyfundraisers);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedUnplannedContactReport>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectContactReport(Expression<Func<string>> contactReportId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodystage = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectcontactreports/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactReportId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner_id"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            if (bodystage != null)
            {
                body["prospect_plan_status"] = ExpressionConverter.ConvertO(bodystage);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectOpportunity> CreateProspectOpportunity(Expression<Func<string>> bodyplanID, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodytype = null, Expression<Func<double>> bodyexpectedAskAmount = null, Expression<Func<string>> bodyexpectedAskDate = null, Expression<Func<string>> bodylikelihood = null, Expression<Func<double>> bodyaskAmount = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyacceptedAmount = null, Expression<Func<string>> bodyresponseDate = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodytransactionCurrency = null)
        {
            var apiCallPath = "/crm-prsmg/prospectopportunities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prospect_plan_id"] = ExpressionConverter.ConvertO(bodyplanID);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodytype != null)
            {
                body["opportunity_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyexpectedAskAmount != null)
            {
                body["expected_ask_amount"] = ExpressionConverter.ConvertO(bodyexpectedAskAmount);
                bodypropCount++;
            }

            if (bodyexpectedAskDate != null)
            {
                body["expected_ask_date"] = ExpressionConverter.ConvertO(bodyexpectedAskDate);
                bodypropCount++;
            }

            if (bodylikelihood != null)
            {
                body["likelihood_type_code"] = ExpressionConverter.ConvertO(bodylikelihood);
                bodypropCount++;
            }

            if (bodyaskAmount != null)
            {
                body["ask_amount"] = ExpressionConverter.ConvertO(bodyaskAmount);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = ExpressionConverter.ConvertO(bodyaskDate);
                bodypropCount++;
            }

            if (bodyacceptedAmount != null)
            {
                body["accepted_amount"] = ExpressionConverter.ConvertO(bodyacceptedAmount);
                bodypropCount++;
            }

            if (bodyresponseDate != null)
            {
                body["response_date"] = ExpressionConverter.ConvertO(bodyresponseDate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodytransactionCurrency != null)
            {
                body["transaction_currency"] = ExpressionConverter.ConvertO(bodytransactionCurrency);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedProspectOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunitySearchResultCollection> SearchProspectOpportunities(Expression<Func<string>> keyname = null, Expression<Func<string>> firstname = null, Expression<Func<string>> lookupId = null, Expression<Func<bool>> exactmatchonly = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> askDate = null, Expression<Func<double>> askAmount = null, Expression<Func<string>> designationuserid = null, Expression<Func<bool>> onlyProspects = null, Expression<Func<bool>> onlyFundraisers = null, Expression<Func<bool>> onlyStaff = null, Expression<Func<bool>> onlyVolunteers = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includedeceased = null, Expression<Func<bool>> includeinactive = null, Expression<Func<bool>> checknickname = null, Expression<Func<bool>> checkaliases = null, Expression<Func<bool>> checkalternatelookupids = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/crm-prsmg/prospectopportunities/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyname != null)
                callPayload.Queries["keyname"] = ExpressionConverter.Convert(keyname);
            if (firstname != null)
                callPayload.Queries["firstname"] = ExpressionConverter.Convert(firstname);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(lookupId);
            if (exactmatchonly != null)
                callPayload.Queries["exactmatchonly"] = ExpressionConverter.Convert(exactmatchonly);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (askDate != null)
                callPayload.Queries["ask_date"] = ExpressionConverter.Convert(askDate);
            if (askAmount != null)
                callPayload.Queries["ask_amount"] = ExpressionConverter.Convert(askAmount);
            if (designationuserid != null)
                callPayload.Queries["designationuserid"] = ExpressionConverter.Convert(designationuserid);
            if (onlyProspects != null)
                callPayload.Queries["only_prospects"] = ExpressionConverter.Convert(onlyProspects);
            if (onlyFundraisers != null)
                callPayload.Queries["only_fundraisers"] = ExpressionConverter.Convert(onlyFundraisers);
            if (onlyStaff != null)
                callPayload.Queries["only_staff"] = ExpressionConverter.Convert(onlyStaff);
            if (onlyVolunteers != null)
                callPayload.Queries["only_volunteers"] = ExpressionConverter.Convert(onlyVolunteers);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(onlyPrimaryAddress);
            if (includedeceased != null)
                callPayload.Queries["includedeceased"] = ExpressionConverter.Convert(includedeceased);
            if (includeinactive != null)
                callPayload.Queries["includeinactive"] = ExpressionConverter.Convert(includeinactive);
            if (checknickname != null)
                callPayload.Queries["checknickname"] = ExpressionConverter.Convert(checknickname);
            if (checkaliases != null)
                callPayload.Queries["checkaliases"] = ExpressionConverter.Convert(checkaliases);
            if (checkalternatelookupids != null)
                callPayload.Queries["checkalternatelookupids"] = ExpressionConverter.Convert(checkalternatelookupids);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PrsmgProspectOpportunitySearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunity> GetProspectOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectopportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgProspectOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectOpportunity(Expression<Func<string>> opportunityId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodytype = null, Expression<Func<double>> bodyexpectedAskAmount = null, Expression<Func<string>> bodyexpectedAskDate = null, Expression<Func<string>> bodylikelihood = null, Expression<Func<double>> bodyaskAmount = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyacceptedAmount = null, Expression<Func<string>> bodyresponseDate = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodytransactionCurrency = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectopportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["opportunity_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyexpectedAskAmount != null)
            {
                body["expected_ask_amount"] = ExpressionConverter.ConvertO(bodyexpectedAskAmount);
                bodypropCount++;
            }

            if (bodyexpectedAskDate != null)
            {
                body["expected_ask_date"] = ExpressionConverter.ConvertO(bodyexpectedAskDate);
                bodypropCount++;
            }

            if (bodylikelihood != null)
            {
                body["likelihood_type_code"] = ExpressionConverter.ConvertO(bodylikelihood);
                bodypropCount++;
            }

            if (bodyaskAmount != null)
            {
                body["ask_amount"] = ExpressionConverter.ConvertO(bodyaskAmount);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = ExpressionConverter.ConvertO(bodyaskDate);
                bodypropCount++;
            }

            if (bodyacceptedAmount != null)
            {
                body["accepted_amount"] = ExpressionConverter.ConvertO(bodyacceptedAmount);
                bodypropCount++;
            }

            if (bodyresponseDate != null)
            {
                body["response_date"] = ExpressionConverter.ConvertO(bodyresponseDate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodytransactionCurrency != null)
            {
                body["transaction_currency"] = ExpressionConverter.ConvertO(bodytransactionCurrency);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgPlanOpportunityCollection> ListPlanOpportunities(Expression<Func<string>> planId, Expression<Func<statusInput>> status = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectopportunities/{0}/list", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<PrsmgPlanOpportunityCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlan> CreateMajorGivingPlan(Expression<Func<string>> bodyprospectID, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodynarrative = null, Expression<Func<string>> bodyprimaryManagerID = null, Expression<Func<string>> bodyprimaryStartDate = null, Expression<Func<string>> bodysecondaryManagerID = null, Expression<Func<string>> bodysecondaryStartDate = null, Expression<Func<PrsmgNewMajorGivingPlanParticipant[]>> bodyparticipants = null, Expression<Func<PrsmgNewMajorGivingPlanSecondaryFundraiser[]>> bodyfundraisers = null)
        {
            var apiCallPath = "/crm-prsmg/prospectplans";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prospect_id"] = ExpressionConverter.ConvertO(bodyprospectID);
            bodypropCount++;
            body["prospect_plan_name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["prospect_plan_type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = ExpressionConverter.ConvertO(bodynarrative);
                bodypropCount++;
            }

            if (bodyprimaryManagerID != null)
            {
                body["primary_manager_fundraiser_id"] = ExpressionConverter.ConvertO(bodyprimaryManagerID);
                bodypropCount++;
            }

            if (bodyprimaryStartDate != null)
            {
                body["primary_manager_date_from"] = ExpressionConverter.ConvertO(bodyprimaryStartDate);
                bodypropCount++;
            }

            if (bodysecondaryManagerID != null)
            {
                body["secondary_manager_fundraiser_id"] = ExpressionConverter.ConvertO(bodysecondaryManagerID);
                bodypropCount++;
            }

            if (bodysecondaryStartDate != null)
            {
                body["secondary_manager_date_from"] = ExpressionConverter.ConvertO(bodysecondaryStartDate);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["prospect_plan_participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodyfundraisers != null)
            {
                body["secondary_fundraisers"] = ExpressionConverter.ConvertO(bodyfundraisers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedMajorGivingPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgMajorGivingPlan> GetMajorGivingPlan(Expression<Func<string>> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgMajorGivingPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlan(Expression<Func<string>> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSearchResultCollection> SearchProspects(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> constituency = null, Expression<Func<bool>> onlyProspects = null, Expression<Func<bool>> onlyFundraisers = null, Expression<Func<bool>> onlyStaff = null, Expression<Func<bool>> onlyVolunteers = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/crm-prsmg/prospects/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (keyName != null)
                callPayload.Queries["key_name"] = ExpressionConverter.Convert(keyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(lookupId);
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = ExpressionConverter.Convert(phoneNumber);
            if (country != null)
                callPayload.Queries["country"] = ExpressionConverter.Convert(country);
            if (addressBlock != null)
                callPayload.Queries["address_block"] = ExpressionConverter.Convert(addressBlock);
            if (city != null)
                callPayload.Queries["city"] = ExpressionConverter.Convert(city);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = ExpressionConverter.Convert(postCode);
            if (exactMatchOnly != null)
                callPayload.Queries["exact_match_only"] = ExpressionConverter.Convert(exactMatchOnly);
            if (constituency != null)
                callPayload.Queries["constituency"] = ExpressionConverter.Convert(constituency);
            if (onlyProspects != null)
                callPayload.Queries["only_prospects"] = ExpressionConverter.Convert(onlyProspects);
            if (onlyFundraisers != null)
                callPayload.Queries["only_fundraisers"] = ExpressionConverter.Convert(onlyFundraisers);
            if (onlyStaff != null)
                callPayload.Queries["only_staff"] = ExpressionConverter.Convert(onlyStaff);
            if (onlyVolunteers != null)
                callPayload.Queries["only_volunteers"] = ExpressionConverter.Convert(onlyVolunteers);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(onlyPrimaryAddress);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(includeInactive);
            if (fuzzySearchOnName != null)
                callPayload.Queries["fuzzy_search_on_name"] = ExpressionConverter.Convert(fuzzySearchOnName);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PrsmgProspectSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspect(Expression<Func<string>> constituentId, Expression<Func<string>> bodymanagerID = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymanagerID != null)
            {
                body["prospect_manager_fundraiser_id"] = ExpressionConverter.ConvertO(bodymanagerID);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["prospect_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteProspectOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectopportunities", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectPlanCollection> ListProspectPlans(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactivePlans = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectplans", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactivePlans != null)
                callPayload.Queries["include_inactive_plans"] = ExpressionConverter.Convert(includeInactivePlans);
            return new ApiConnectionAction<PrsmgProspectPlanCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSummary> GetProspectSummary(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectstatus", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgProspectSummary>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectConstituency> CreateProspectConstituency(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var apiCallPath = "/crm-prsmg/prospectsconstituency";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            if (bodydateFrom != null)
            {
                body["date_from"] = ExpressionConverter.ConvertO(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = ExpressionConverter.ConvertO(bodydateTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedProspectConstituency>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlanStep> CreateMajorGivingPlanStep(Expression<Func<string>> bodyplanID, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodytype, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyexpectedDate, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyotherLocation = null, Expression<Func<PrsmgNewMajorGivingPlanStepFundraiser[]>> bodyfundraisers = null, Expression<Func<PrsmgNewMajorGivingPlanStepParticipant[]>> bodyparticipants = null)
        {
            var apiCallPath = "/crm-prsmg/prospectsteps";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["prospect_plan_id"] = ExpressionConverter.ConvertO(bodyplanID);
            bodypropCount++;
            body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
            bodypropCount++;
            body["prospect_plan_status"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
            if (bodyowner != null)
            {
                body["owner_id"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            var expected_start_timeObject = new JObject();
            var expected_start_timeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expected_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expected_start_timeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expected_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
                expected_start_timeObjectpropCount++;
            }

            if (expected_start_timeObjectpropCount > 0)
            {
                body["expected_start_time"] = expected_start_timeObject;
                bodypropCount++;
            }

            var expected_end_timeObject = new JObject();
            var expected_end_timeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expected_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expected_end_timeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expected_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expected_end_timeObjectpropCount++;
            }

            if (expected_end_timeObjectpropCount > 0)
            {
                body["expected_end_time"] = expected_end_timeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = ExpressionConverter.ConvertO(bodylocation);
                bodypropCount++;
            }

            if (bodyotherLocation != null)
            {
                body["other_location"] = ExpressionConverter.ConvertO(bodyotherLocation);
                bodypropCount++;
            }

            if (bodyfundraisers != null)
            {
                body["additional_fundraisers"] = ExpressionConverter.ConvertO(bodyfundraisers);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedMajorGivingPlanStep>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlanStep(Expression<Func<string>> stepId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectsteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditMajorGivingPlanStep(Expression<Func<string>> vProspectPlanId, Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytype = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodyotherLocation = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectsteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["v_prospect_plan_id"] = ExpressionConverter.Convert(vProspectPlanId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["prospect_plan_status"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = ExpressionConverter.ConvertO(bodyexpectedDate);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner_id"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            var expected_start_timeObject = new JObject();
            var expected_start_timeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expected_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expected_start_timeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expected_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
                expected_start_timeObjectpropCount++;
            }

            if (expected_start_timeObjectpropCount > 0)
            {
                body["expected_start_time"] = expected_start_timeObject;
                bodypropCount++;
            }

            var expected_end_timeObject = new JObject();
            var expected_end_timeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expected_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expected_end_timeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expected_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expected_end_timeObjectpropCount++;
            }

            if (expected_end_timeObjectpropCount > 0)
            {
                body["expected_end_time"] = expected_end_timeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            if (bodyotherLocation != null)
            {
                body["other_location"] = ExpressionConverter.ConvertO(bodyotherLocation);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlan> CreateStewardshipPlan(Expression<Func<string>> bodyprospectID, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysubtype = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodymanagerID = null, Expression<Func<string>> bodymanagerStartDate = null, Expression<Func<PrsmgNewStewardshipPlanSteward[]>> bodystewards = null)
        {
            var apiCallPath = "/crm-prsmg/stewardshipplans";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyprospectID);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodytype != null)
            {
                body["plan_type_id"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodysubtype != null)
            {
                body["plan_sub_type_id"] = ExpressionConverter.ConvertO(bodysubtype);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodymanagerID != null)
            {
                body["manager_id"] = ExpressionConverter.ConvertO(bodymanagerID);
                bodypropCount++;
            }

            if (bodymanagerStartDate != null)
            {
                body["manager_start_date"] = ExpressionConverter.ConvertO(bodymanagerStartDate);
                bodypropCount++;
            }

            if (bodystewards != null)
            {
                body["stewards"] = ExpressionConverter.ConvertO(bodystewards);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedStewardshipPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteStewardshipPlan(Expression<Func<string>> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/stewardshipplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlanStep> CreateStewardshipPlanStep(Expression<Func<string>> bodyplanID, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodytargetDate, Expression<Func<bodyfrequencyInput>> bodyfrequency, Expression<Func<bool>> bodylocked = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodytargetStarthour = null, Expression<Func<int>> bodytargetStartminute = null, Expression<Func<int>> bodytargetEndhour = null, Expression<Func<int>> bodytargetEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodynextTargetDate = null, Expression<Func<bodyconnectToInput>> bodyconnectTo = null, Expression<Func<string>> bodybenefitID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodymailingID = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<PrsmgNewStewardshipPlanStepParticipant[]>> bodyparticipants = null, Expression<Func<PrsmgNewStewardshipPlanStepAssociatedPlan[]>> bodyassociatedPlans = null)
        {
            var apiCallPath = "/crm-prsmg/stewardshipplansteps";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["stewardship_plan_id"] = ExpressionConverter.ConvertO(bodyplanID);
            bodypropCount++;
            body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
            bodypropCount++;
            body["target_date"] = ExpressionConverter.ConvertO(bodytargetDate);
            if (bodylocked != null)
            {
                body["date_locked"] = ExpressionConverter.ConvertO(bodylocked);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            var target_start_timeObject = new JObject();
            var target_start_timeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                target_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodytargetStarthour);
                target_start_timeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                target_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodytargetStartminute);
                target_start_timeObjectpropCount++;
            }

            if (target_start_timeObjectpropCount > 0)
            {
                body["target_start_time"] = target_start_timeObject;
                bodypropCount++;
            }

            var target_end_timeObject = new JObject();
            var target_end_timeObjectpropCount = 0;
            if (bodytargetEndhour != null)
            {
                target_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodytargetEndhour);
                target_end_timeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                target_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodytargetEndminute);
                target_end_timeObjectpropCount++;
            }

            if (target_end_timeObjectpropCount > 0)
            {
                body["target_end_time"] = target_end_timeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status_code"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["constituent_id"] = ExpressionConverter.ConvertO(bodyassignedTo);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["contact_method"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            bodypropCount++;
            body["recurs"] = ExpressionConverter.ConvertO(bodyfrequency);
            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodynextTargetDate != null)
            {
                body["next_target_date"] = ExpressionConverter.ConvertO(bodynextTargetDate);
                bodypropCount++;
            }

            if (bodyconnectTo != null)
            {
                body["link_type_code"] = ExpressionConverter.ConvertO(bodyconnectTo);
                bodypropCount++;
            }

            if (bodybenefitID != null)
            {
                body["benefit_id"] = ExpressionConverter.ConvertO(bodybenefitID);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = ExpressionConverter.ConvertO(bodymailingID);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["step_participants"] = ExpressionConverter.ConvertO(bodyparticipants);
                bodypropCount++;
            }

            if (bodyassociatedPlans != null)
            {
                body["associated_plans"] = ExpressionConverter.ConvertO(bodyassociatedPlans);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PrsmgCreatedStewardshipPlanStep>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteStewardshipPlanStep(Expression<Func<string>> stepId)
        {
            var apiCallPath = String.Format("/crm-prsmg/stewardshipplansteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditStewardshipPlanStep(Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytargetDate = null, Expression<Func<bool>> bodylocked = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodytargetStarthour = null, Expression<Func<int>> bodytargetStartminute = null, Expression<Func<int>> bodytargetEndhour = null, Expression<Func<int>> bodytargetEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<bodyfrequencyInput>> bodyfrequency = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodynextTargetDate = null, Expression<Func<bodyconnectToInput>> bodyconnectTo = null, Expression<Func<string>> bodybenefitID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodymailingID = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/stewardshipplansteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = ExpressionConverter.ConvertO(bodyobjective);
                bodypropCount++;
            }

            if (bodytargetDate != null)
            {
                body["target_date"] = ExpressionConverter.ConvertO(bodytargetDate);
                bodypropCount++;
            }

            if (bodylocked != null)
            {
                body["date_locked"] = ExpressionConverter.ConvertO(bodylocked);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = ExpressionConverter.ConvertO(bodyallDayEvent);
                bodypropCount++;
            }

            var target_start_timeObject = new JObject();
            var target_start_timeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                target_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodytargetStarthour);
                target_start_timeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                target_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodytargetStartminute);
                target_start_timeObjectpropCount++;
            }

            if (target_start_timeObjectpropCount > 0)
            {
                body["target_start_time"] = target_start_timeObject;
                bodypropCount++;
            }

            var target_end_timeObject = new JObject();
            var target_end_timeObjectpropCount = 0;
            if (bodytargetEndhour != null)
            {
                target_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodytargetEndhour);
                target_end_timeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                target_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodytargetEndminute);
                target_end_timeObjectpropCount++;
            }

            if (target_end_timeObjectpropCount > 0)
            {
                body["target_end_time"] = target_end_timeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = ExpressionConverter.ConvertO(bodytimeZone);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["constituent_id"] = ExpressionConverter.ConvertO(bodyassignedTo);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["contact_method"] = ExpressionConverter.ConvertO(bodycontactMethod);
                bodypropCount++;
            }

            if (bodyfrequency != null)
            {
                body["recurs"] = ExpressionConverter.ConvertO(bodyfrequency);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodynextTargetDate != null)
            {
                body["next_target_date"] = ExpressionConverter.ConvertO(bodynextTargetDate);
                bodypropCount++;
            }

            if (bodyconnectTo != null)
            {
                body["link_type"] = ExpressionConverter.ConvertO(bodyconnectTo);
                bodypropCount++;
            }

            if (bodybenefitID != null)
            {
                body["benefit_id"] = ExpressionConverter.ConvertO(bodybenefitID);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = ExpressionConverter.ConvertO(bodyeventID);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = ExpressionConverter.ConvertO(bodymailingID);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = ExpressionConverter.ConvertO(bodyactualDate);
                bodypropCount++;
            }

            var actual_start_timeObject = new JObject();
            var actual_start_timeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actual_start_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actual_start_timeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actual_start_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
                actual_start_timeObjectpropCount++;
            }

            if (actual_start_timeObjectpropCount > 0)
            {
                body["actual_start_time"] = actual_start_timeObject;
                bodypropCount++;
            }

            var actual_end_timeObject = new JObject();
            var actual_end_timeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actual_end_timeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actual_end_timeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actual_end_timeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actual_end_timeObjectpropCount++;
            }

            if (actual_end_timeObjectpropCount > 0)
            {
                body["actual_end_time"] = actual_end_timeObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudcrmprospectTriggers([ConnectionName] string connectionId)
    {
    }

    public class PrsmgCreatedUnplannedContactReport
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class PrsmgNewUnplannedContactReportFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string ID { get; set; }
    }

    public class PrsmgNewUnplannedContactReportParticipant
    {
        [JsonProperty("constituent_id")]
        public string ID { get; set; }
    }

    public class PrsmgCreatedProspectOpportunity
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodystatusInput
    {
        Pending,
        Completed,
        Cancelled,
        Declined
    }

    public class PrsmgProspectOpportunitySearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PrsmgProspectOpportunitySearchResult[] Value { get; set; }
    }

    public class PrsmgProspectOpportunitySearchResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ask_amount")]
        public double AskAmount { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("transaction_currency_id")]
        public string TransactionCurrencyID { get; set; }

        [JsonProperty("prospect_plan_type")]
        public string PlanType { get; set; }

        [JsonProperty("prospect_plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("name")]
        public string ProspectName { get; set; }
    }

    public enum statusInput
    {
        Unqualified,
        Qualified,
        [EnumMember(Value = "Response pending")]
        ResponsePending,
        Accepted,
        Rejected,
        Canceled
    }

    public class PrsmgProspectOpportunity
    {
        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("opportunity_type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expected_ask_amount")]
        public double ExpectedAskAmount { get; set; }

        [JsonProperty("expected_ask_date")]
        public string ExpectedAskDate { get; set; }

        [JsonProperty("likelihood_type_code")]
        public string Likelihood { get; set; }

        [JsonProperty("ask_amount")]
        public double AskAmount { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("accepted_amount")]
        public double AcceptedAmount { get; set; }

        [JsonProperty("response_date")]
        public string ResponseDate { get; set; }

        [JsonProperty("transaction_currency")]
        public string TransactionCurrencyID { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("prospect_id")]
        public string ProspectID { get; set; }

        [JsonProperty("prospect_plan")]
        public string ProspectPlanName { get; set; }

        [JsonProperty("designation")]
        public PrsmgProspectOpportunityDesignation[] Designations { get; set; }
    }

    public class PrsmgProspectOpportunityDesignation
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("designation_id")]
        public string DesignationID { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("funding_method")]
        public string FundingMethod { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("use")]
        public string UseCode { get; set; }

        [JsonProperty("constituent_name")]
        public string Constituent { get; set; }

        [JsonProperty("transaction_currency_id")]
        public string TransactionCurrencyID { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class PrsmgPlanOpportunityCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PrsmgPlanOpportunity[] Value { get; set; }
    }

    public class PrsmgPlanOpportunity
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("opportunity_type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("expected_ask_date")]
        public string ExpectedAskDate { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("response_date")]
        public string ResponseDate { get; set; }

        [JsonProperty("base_currency_id")]
        public string BaseCurrencyID { get; set; }
    }

    public class PrsmgCreatedMajorGivingPlan
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class PrsmgNewMajorGivingPlanParticipant
    {
        [JsonProperty("constituent_id")]
        public string ID { get; set; }

        [JsonProperty("plan_participant_role")]
        public string Role { get; set; }
    }

    public class PrsmgNewMajorGivingPlanSecondaryFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string ID { get; set; }

        [JsonProperty("solicitor_role")]
        public string Role { get; set; }

        [JsonProperty("date_from")]
        public string Start { get; set; }
    }

    public class PrsmgMajorGivingPlan
    {
        [JsonProperty("prospect_id")]
        public string ProspectID { get; set; }

        [JsonProperty("prospect")]
        public string ProspectName { get; set; }

        [JsonProperty("prospect_plan_name")]
        public string Name { get; set; }

        [JsonProperty("prospect_plan_type")]
        public string Type { get; set; }

        [JsonProperty("fiscal_year_start_date")]
        public string FiscalYearStartDate { get; set; }

        [JsonProperty("fiscal_year_end_date")]
        public string FiscalYearEndDate { get; set; }

        [JsonProperty("steps")]
        public PrsmgMajorGivingPlanStep[] Steps { get; set; }
    }

    public class PrsmgMajorGivingPlanStep
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("plan_outline_step_id")]
        public string PlanOutlineStepID { get; set; }

        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("prospect_plan_status")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("fundraiser_id")]
        public string Owner { get; set; }

        [JsonProperty("all_day_event")]
        public bool AllDayEvent { get; set; }

        [JsonProperty("expected_start_time")]
        public PrsmgMajorGivingPlanStepExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public PrsmgMajorGivingPlanStepExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public PrsmgMajorGivingPlanStepActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public PrsmgMajorGivingPlanStepActualEndType ActualEnd { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("other_location")]
        public string OtherLocation { get; set; }

        [JsonProperty("additional_fundraisers")]
        public PrsmgMajorGivingPlanStepAdditionalFundraiser[] AdditionalFundraisers { get; set; }

        [JsonProperty("participants")]
        public PrsmgMajorGivingPlanStepParticipant[] Participants { get; set; }
    }

    public class PrsmgMajorGivingPlanStepExpectedStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class PrsmgMajorGivingPlanStepExpectedEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class PrsmgMajorGivingPlanStepActualStartType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class PrsmgMajorGivingPlanStepActualEndType
    {
        [JsonProperty("hour")]
        public int Hour { get; set; }

        [JsonProperty("minute")]
        public int Minute { get; set; }
    }

    public class PrsmgMajorGivingPlanStepAdditionalFundraiser
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserID { get; set; }
    }

    public class PrsmgMajorGivingPlanStepParticipant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ParticipantID { get; set; }
    }

    public class PrsmgProspectSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PrsmgProspectSearchResult[] Value { get; set; }
    }

    public class PrsmgProspectSearchResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prospect_manager")]
        public string ProspectManager { get; set; }

        [JsonProperty("primary_managers")]
        public string PrimaryManagerS { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("sort_constituent_name")]
        public string SortName { get; set; }

        [JsonProperty("constituent_type")]
        public string ConstituentType { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("post_code")]
        public string Postcode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class PrsmgProspectPlanCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public PrsmgProspectPlan[] Value { get; set; }
    }

    public class PrsmgProspectPlan
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("plan_name")]
        public string Name { get; set; }

        [JsonProperty("plan_type")]
        public string Type { get; set; }

        [JsonProperty("stewardship_plan")]
        public bool IsStewardship { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("next_interaction_id")]
        public string NextInteractionID { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }
    }

    public class PrsmgProspectSummary
    {
        [JsonProperty("prospect")]
        public bool IsProspect { get; set; }

        [JsonProperty("flagged")]
        public bool IsFlagged { get; set; }

        [JsonProperty("prospect_status")]
        public string Status { get; set; }

        [JsonProperty("prospect_manager_name")]
        public string ManagerName { get; set; }

        [JsonProperty("prospect_manager_fundraiser_id")]
        public string ManagerID { get; set; }

        [JsonProperty("prospect_manager_start_date")]
        public string StartDate { get; set; }
    }

    public class PrsmgCreatedProspectConstituency
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class PrsmgCreatedMajorGivingPlanStep
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class PrsmgNewMajorGivingPlanStepFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string ID { get; set; }
    }

    public class PrsmgNewMajorGivingPlanStepParticipant
    {
        [JsonProperty("constituent_id")]
        public string ID { get; set; }
    }

    public class PrsmgCreatedStewardshipPlan
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class PrsmgNewStewardshipPlanSteward
    {
        [JsonProperty("constituent_id")]
        public string ID { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class PrsmgCreatedStewardshipPlanStep
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyfrequencyInput
    {
        [EnumMember(Value = "Single Occurrence")]
        SingleOccurrence,
        Annually,
        [EnumMember(Value = "Semi-Annually")]
        SemiAnnually,
        Quarterly,
        [EnumMember(Value = "Bi-Monthly")]
        BiMonthly,
        Monthly,
        [EnumMember(Value = "Semi-Monthly")]
        SemiMonthly,
        [EnumMember(Value = "Bi-Weekly")]
        BiWeekly,
        Weekly
    }

    public enum bodyconnectToInput
    {
        Benefit,
        Event,
        Mailing
    }

    public class PrsmgNewStewardshipPlanStepParticipant
    {
        [JsonProperty("constituent_id")]
        public string ID { get; set; }
    }

    public class PrsmgNewStewardshipPlanStepAssociatedPlan
    {
        [JsonProperty("prospect_plan_id")]
        public string PlanID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Blackbaudcrmprospect;

    public partial class WorkflowManagedActions
    {
        public BlackbaudcrmprospectActions Blackbaudcrmprospect(string connectionId) => new BlackbaudcrmprospectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudcrmprospectTriggers Blackbaudcrmprospect(string connectionId) => new BlackbaudcrmprospectTriggers(connectionId);
    }
}