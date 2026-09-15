//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmprospect
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
            body["prospect_plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanID);
            bodypropCount++;
            body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
            if (bodyowner != null)
            {
                body["owner_id"] = CSharpExpressionConverter.ConvertToken(bodyowner);
                bodypropCount++;
            }

            bodypropCount++;
            body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["prospect_plan_status"] = CSharpExpressionConverter.ConvertToken(bodystage);
            bodypropCount++;
            body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            bodypropCount++;
            body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
            if (bodyfundraisers != null)
            {
                body["additional_fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraisers);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectcontactreports/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactReportId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner_id"] = CSharpExpressionConverter.ConvertToken(bodyowner);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodystage != null)
            {
                body["prospect_plan_status"] = CSharpExpressionConverter.ConvertToken(bodystage);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
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
            body["prospect_plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanID);
            bodypropCount++;
            body["status"] = CSharpExpressionConverter.Convert(bodystatus);
            if (bodytype != null)
            {
                body["opportunity_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyexpectedAskAmount != null)
            {
                body["expected_ask_amount"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAskAmount);
                bodypropCount++;
            }

            if (bodyexpectedAskDate != null)
            {
                body["expected_ask_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAskDate);
                bodypropCount++;
            }

            if (bodylikelihood != null)
            {
                body["likelihood_type_code"] = CSharpExpressionConverter.ConvertToken(bodylikelihood);
                bodypropCount++;
            }

            if (bodyaskAmount != null)
            {
                body["ask_amount"] = CSharpExpressionConverter.ConvertToken(bodyaskAmount);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = CSharpExpressionConverter.ConvertToken(bodyaskDate);
                bodypropCount++;
            }

            if (bodyacceptedAmount != null)
            {
                body["accepted_amount"] = CSharpExpressionConverter.ConvertToken(bodyacceptedAmount);
                bodypropCount++;
            }

            if (bodyresponseDate != null)
            {
                body["response_date"] = CSharpExpressionConverter.ConvertToken(bodyresponseDate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodytransactionCurrency != null)
            {
                body["transaction_currency"] = CSharpExpressionConverter.ConvertToken(bodytransactionCurrency);
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
                callPayload.Queries["keyname"] = CSharpExpressionConverter.ConvertO(keyname);
            if (firstname != null)
                callPayload.Queries["firstname"] = CSharpExpressionConverter.ConvertO(firstname);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = CSharpExpressionConverter.ConvertO(lookupId);
            if (exactmatchonly != null)
                callPayload.Queries["exactmatchonly"] = CSharpExpressionConverter.ConvertO(exactmatchonly);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.Convert(status);
            if (askDate != null)
                callPayload.Queries["ask_date"] = CSharpExpressionConverter.ConvertO(askDate);
            if (askAmount != null)
                callPayload.Queries["ask_amount"] = CSharpExpressionConverter.ConvertO(askAmount);
            if (designationuserid != null)
                callPayload.Queries["designationuserid"] = CSharpExpressionConverter.ConvertO(designationuserid);
            if (onlyProspects != null)
                callPayload.Queries["only_prospects"] = CSharpExpressionConverter.ConvertO(onlyProspects);
            if (onlyFundraisers != null)
                callPayload.Queries["only_fundraisers"] = CSharpExpressionConverter.ConvertO(onlyFundraisers);
            if (onlyStaff != null)
                callPayload.Queries["only_staff"] = CSharpExpressionConverter.ConvertO(onlyStaff);
            if (onlyVolunteers != null)
                callPayload.Queries["only_volunteers"] = CSharpExpressionConverter.ConvertO(onlyVolunteers);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = CSharpExpressionConverter.ConvertO(onlyPrimaryAddress);
            if (includedeceased != null)
                callPayload.Queries["includedeceased"] = CSharpExpressionConverter.ConvertO(includedeceased);
            if (includeinactive != null)
                callPayload.Queries["includeinactive"] = CSharpExpressionConverter.ConvertO(includeinactive);
            if (checknickname != null)
                callPayload.Queries["checknickname"] = CSharpExpressionConverter.ConvertO(checknickname);
            if (checkaliases != null)
                callPayload.Queries["checkaliases"] = CSharpExpressionConverter.ConvertO(checkaliases);
            if (checkalternatelookupids != null)
                callPayload.Queries["checkalternatelookupids"] = CSharpExpressionConverter.ConvertO(checkalternatelookupids);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<PrsmgProspectOpportunitySearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunity> GetProspectOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgProspectOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectOpportunity(Expression<Func<string>> opportunityId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodytype = null, Expression<Func<double>> bodyexpectedAskAmount = null, Expression<Func<string>> bodyexpectedAskDate = null, Expression<Func<string>> bodylikelihood = null, Expression<Func<double>> bodyaskAmount = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyacceptedAmount = null, Expression<Func<string>> bodyresponseDate = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodytransactionCurrency = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["opportunity_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodyexpectedAskAmount != null)
            {
                body["expected_ask_amount"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAskAmount);
                bodypropCount++;
            }

            if (bodyexpectedAskDate != null)
            {
                body["expected_ask_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAskDate);
                bodypropCount++;
            }

            if (bodylikelihood != null)
            {
                body["likelihood_type_code"] = CSharpExpressionConverter.ConvertToken(bodylikelihood);
                bodypropCount++;
            }

            if (bodyaskAmount != null)
            {
                body["ask_amount"] = CSharpExpressionConverter.ConvertToken(bodyaskAmount);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = CSharpExpressionConverter.ConvertToken(bodyaskDate);
                bodypropCount++;
            }

            if (bodyacceptedAmount != null)
            {
                body["accepted_amount"] = CSharpExpressionConverter.ConvertToken(bodyacceptedAmount);
                bodypropCount++;
            }

            if (bodyresponseDate != null)
            {
                body["response_date"] = CSharpExpressionConverter.ConvertToken(bodyresponseDate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodytransactionCurrency != null)
            {
                body["transaction_currency"] = CSharpExpressionConverter.ConvertToken(bodytransactionCurrency);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}/list", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.Convert(status);
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
            body["prospect_id"] = CSharpExpressionConverter.ConvertToken(bodyprospectID);
            bodypropCount++;
            body["prospect_plan_name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["prospect_plan_type"] = CSharpExpressionConverter.ConvertToken(bodytype);
            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodynarrative != null)
            {
                body["narrative"] = CSharpExpressionConverter.ConvertToken(bodynarrative);
                bodypropCount++;
            }

            if (bodyprimaryManagerID != null)
            {
                body["primary_manager_fundraiser_id"] = CSharpExpressionConverter.ConvertToken(bodyprimaryManagerID);
                bodypropCount++;
            }

            if (bodyprimaryStartDate != null)
            {
                body["primary_manager_date_from"] = CSharpExpressionConverter.ConvertToken(bodyprimaryStartDate);
                bodypropCount++;
            }

            if (bodysecondaryManagerID != null)
            {
                body["secondary_manager_fundraiser_id"] = CSharpExpressionConverter.ConvertToken(bodysecondaryManagerID);
                bodypropCount++;
            }

            if (bodysecondaryStartDate != null)
            {
                body["secondary_manager_date_from"] = CSharpExpressionConverter.ConvertToken(bodysecondaryStartDate);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["prospect_plan_participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
                bodypropCount++;
            }

            if (bodyfundraisers != null)
            {
                body["secondary_fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraisers);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectplans/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgMajorGivingPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlan(Expression<Func<string>> planId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectplans/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
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
                callPayload.Queries["key_name"] = CSharpExpressionConverter.ConvertO(keyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lookupId != null)
                callPayload.Queries["lookup_id"] = CSharpExpressionConverter.ConvertO(lookupId);
            if (phoneNumber != null)
                callPayload.Queries["phone_number"] = CSharpExpressionConverter.ConvertO(phoneNumber);
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.ConvertO(country);
            if (addressBlock != null)
                callPayload.Queries["address_block"] = CSharpExpressionConverter.ConvertO(addressBlock);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (state != null)
                callPayload.Queries["state"] = CSharpExpressionConverter.ConvertO(state);
            if (postCode != null)
                callPayload.Queries["post_code"] = CSharpExpressionConverter.ConvertO(postCode);
            if (exactMatchOnly != null)
                callPayload.Queries["exact_match_only"] = CSharpExpressionConverter.ConvertO(exactMatchOnly);
            if (constituency != null)
                callPayload.Queries["constituency"] = CSharpExpressionConverter.ConvertO(constituency);
            if (onlyProspects != null)
                callPayload.Queries["only_prospects"] = CSharpExpressionConverter.ConvertO(onlyProspects);
            if (onlyFundraisers != null)
                callPayload.Queries["only_fundraisers"] = CSharpExpressionConverter.ConvertO(onlyFundraisers);
            if (onlyStaff != null)
                callPayload.Queries["only_staff"] = CSharpExpressionConverter.ConvertO(onlyStaff);
            if (onlyVolunteers != null)
                callPayload.Queries["only_volunteers"] = CSharpExpressionConverter.ConvertO(onlyVolunteers);
            if (onlyPrimaryAddress != null)
                callPayload.Queries["only_primary_address"] = CSharpExpressionConverter.ConvertO(onlyPrimaryAddress);
            if (includeDeceased != null)
                callPayload.Queries["include_deceased"] = CSharpExpressionConverter.ConvertO(includeDeceased);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            if (fuzzySearchOnName != null)
                callPayload.Queries["fuzzy_search_on_name"] = CSharpExpressionConverter.ConvertO(fuzzySearchOnName);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            return new ApiConnectionAction<PrsmgProspectSearchResultCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspect(Expression<Func<string>> constituentId, Expression<Func<string>> bodymanagerID = null, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymanagerID != null)
            {
                body["prospect_manager_fundraiser_id"] = CSharpExpressionConverter.ConvertToken(bodymanagerID);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["prospect_status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectopportunities", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectPlanCollection> ListProspectPlans(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactivePlans = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectplans", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactivePlans != null)
                callPayload.Queries["include_inactive_plans"] = CSharpExpressionConverter.ConvertO(includeInactivePlans);
            return new ApiConnectionAction<PrsmgProspectPlanCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSummary> GetProspectSummary(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectstatus", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
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
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            if (bodydateFrom != null)
            {
                body["date_from"] = CSharpExpressionConverter.ConvertToken(bodydateFrom);
                bodypropCount++;
            }

            if (bodydateTo != null)
            {
                body["date_to"] = CSharpExpressionConverter.ConvertToken(bodydateTo);
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
            body["prospect_plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanID);
            bodypropCount++;
            body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
            bodypropCount++;
            body["prospect_plan_status"] = CSharpExpressionConverter.ConvertToken(bodytype);
            bodypropCount++;
            body["status"] = CSharpExpressionConverter.Convert(bodystatus);
            bodypropCount++;
            body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
            if (bodyowner != null)
            {
                body["owner_id"] = CSharpExpressionConverter.ConvertToken(bodyowner);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStartminute);
                expectedStartTimeObjectpropCount++;
            }

            if (expectedStartTimeObjectpropCount > 0)
            {
                body["expected_start_time"] = expectedStartTimeObject;
                bodypropCount++;
            }

            var expectedEndTimeObject = new JObject();
            var expectedEndTimeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expectedEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodyotherLocation != null)
            {
                body["other_location"] = CSharpExpressionConverter.ConvertToken(bodyotherLocation);
                bodypropCount++;
            }

            if (bodyfundraisers != null)
            {
                body["additional_fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraisers);
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectsteps/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditMajorGivingPlanStep(Expression<Func<string>> vProspectPlanId, Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytype = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodyotherLocation = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectsteps/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["v_prospect_plan_id"] = CSharpExpressionConverter.ConvertO(vProspectPlanId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["prospect_plan_status"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["owner_id"] = CSharpExpressionConverter.ConvertToken(bodyowner);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["interaction_type"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["interaction_category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["interaction_subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["is_all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedStartminute);
                expectedStartTimeObjectpropCount++;
            }

            if (expectedStartTimeObjectpropCount > 0)
            {
                body["expected_start_time"] = expectedStartTimeObject;
                bodypropCount++;
            }

            var expectedEndTimeObject = new JObject();
            var expectedEndTimeObjectpropCount = 0;
            if (bodyexpectedEndhour != null)
            {
                expectedEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodyotherLocation != null)
            {
                body["other_location"] = CSharpExpressionConverter.ConvertToken(bodyotherLocation);
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
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyprospectID);
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodytype != null)
            {
                body["plan_type_id"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodysubtype != null)
            {
                body["plan_sub_type_id"] = CSharpExpressionConverter.ConvertToken(bodysubtype);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodymanagerID != null)
            {
                body["manager_id"] = CSharpExpressionConverter.ConvertToken(bodymanagerID);
                bodypropCount++;
            }

            if (bodymanagerStartDate != null)
            {
                body["manager_start_date"] = CSharpExpressionConverter.ConvertToken(bodymanagerStartDate);
                bodypropCount++;
            }

            if (bodystewards != null)
            {
                body["stewards"] = CSharpExpressionConverter.ConvertToken(bodystewards);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplans/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
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
            body["stewardship_plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanID);
            bodypropCount++;
            body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
            bodypropCount++;
            body["target_date"] = CSharpExpressionConverter.ConvertToken(bodytargetDate);
            if (bodylocked != null)
            {
                body["date_locked"] = CSharpExpressionConverter.ConvertToken(bodylocked);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            var targetStartTimeObject = new JObject();
            var targetStartTimeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                targetStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodytargetStarthour);
                targetStartTimeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                targetStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodytargetStartminute);
                targetStartTimeObjectpropCount++;
            }

            if (targetStartTimeObjectpropCount > 0)
            {
                body["target_start_time"] = targetStartTimeObject;
                bodypropCount++;
            }

            var targetEndTimeObject = new JObject();
            var targetEndTimeObjectpropCount = 0;
            if (bodytargetEndhour != null)
            {
                targetEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodytargetEndhour);
                targetEndTimeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                targetEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodytargetEndminute);
                targetEndTimeObjectpropCount++;
            }

            if (targetEndTimeObjectpropCount > 0)
            {
                body["target_end_time"] = targetEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status_code"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyassignedTo);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["contact_method"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            bodypropCount++;
            body["recurs"] = CSharpExpressionConverter.Convert(bodyfrequency);
            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodynextTargetDate != null)
            {
                body["next_target_date"] = CSharpExpressionConverter.ConvertToken(bodynextTargetDate);
                bodypropCount++;
            }

            if (bodyconnectTo != null)
            {
                body["link_type_code"] = CSharpExpressionConverter.Convert(bodyconnectTo);
                bodypropCount++;
            }

            if (bodybenefitID != null)
            {
                body["benefit_id"] = CSharpExpressionConverter.ConvertToken(bodybenefitID);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = CSharpExpressionConverter.ConvertToken(bodymailingID);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
                bodypropCount++;
            }

            if (bodyparticipants != null)
            {
                body["step_participants"] = CSharpExpressionConverter.ConvertToken(bodyparticipants);
                bodypropCount++;
            }

            if (bodyassociatedPlans != null)
            {
                body["associated_plans"] = CSharpExpressionConverter.ConvertToken(bodyassociatedPlans);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditStewardshipPlanStep(Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytargetDate = null, Expression<Func<bool>> bodylocked = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodytargetStarthour = null, Expression<Func<int>> bodytargetStartminute = null, Expression<Func<int>> bodytargetEndhour = null, Expression<Func<int>> bodytargetEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<bodyfrequencyInput>> bodyfrequency = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodynextTargetDate = null, Expression<Func<bodyconnectToInput>> bodyconnectTo = null, Expression<Func<string>> bodybenefitID = null, Expression<Func<string>> bodyeventID = null, Expression<Func<string>> bodymailingID = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyobjective != null)
            {
                body["objective"] = CSharpExpressionConverter.ConvertToken(bodyobjective);
                bodypropCount++;
            }

            if (bodytargetDate != null)
            {
                body["target_date"] = CSharpExpressionConverter.ConvertToken(bodytargetDate);
                bodypropCount++;
            }

            if (bodylocked != null)
            {
                body["date_locked"] = CSharpExpressionConverter.ConvertToken(bodylocked);
                bodypropCount++;
            }

            if (bodyallDayEvent != null)
            {
                body["all_day_event"] = CSharpExpressionConverter.ConvertToken(bodyallDayEvent);
                bodypropCount++;
            }

            var targetStartTimeObject = new JObject();
            var targetStartTimeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                targetStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodytargetStarthour);
                targetStartTimeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                targetStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodytargetStartminute);
                targetStartTimeObjectpropCount++;
            }

            if (targetStartTimeObjectpropCount > 0)
            {
                body["target_start_time"] = targetStartTimeObject;
                bodypropCount++;
            }

            var targetEndTimeObject = new JObject();
            var targetEndTimeObjectpropCount = 0;
            if (bodytargetEndhour != null)
            {
                targetEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodytargetEndhour);
                targetEndTimeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                targetEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodytargetEndminute);
                targetEndTimeObjectpropCount++;
            }

            if (targetEndTimeObjectpropCount > 0)
            {
                body["target_end_time"] = targetEndTimeObject;
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone_entry"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyassignedTo != null)
            {
                body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyassignedTo);
                bodypropCount++;
            }

            if (bodycontactMethod != null)
            {
                body["contact_method"] = CSharpExpressionConverter.ConvertToken(bodycontactMethod);
                bodypropCount++;
            }

            if (bodyfrequency != null)
            {
                body["recurs"] = CSharpExpressionConverter.Convert(bodyfrequency);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodynextTargetDate != null)
            {
                body["next_target_date"] = CSharpExpressionConverter.ConvertToken(bodynextTargetDate);
                bodypropCount++;
            }

            if (bodyconnectTo != null)
            {
                body["link_type"] = CSharpExpressionConverter.Convert(bodyconnectTo);
                bodypropCount++;
            }

            if (bodybenefitID != null)
            {
                body["benefit_id"] = CSharpExpressionConverter.ConvertToken(bodybenefitID);
                bodypropCount++;
            }

            if (bodyeventID != null)
            {
                body["event_id"] = CSharpExpressionConverter.ConvertToken(bodyeventID);
                bodypropCount++;
            }

            if (bodymailingID != null)
            {
                body["mailing_id"] = CSharpExpressionConverter.ConvertToken(bodymailingID);
                bodypropCount++;
            }

            if (bodyactualDate != null)
            {
                body["actual_date"] = CSharpExpressionConverter.ConvertToken(bodyactualDate);
                bodypropCount++;
            }

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualStartminute);
                actualStartTimeObjectpropCount++;
            }

            if (actualStartTimeObjectpropCount > 0)
            {
                body["actual_start_time"] = actualStartTimeObject;
                bodypropCount++;
            }

            var actualEndTimeObject = new JObject();
            var actualEndTimeObjectpropCount = 0;
            if (bodyactualEndhour != null)
            {
                actualEndTimeObject["hour"] = CSharpExpressionConverter.ConvertToken(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = CSharpExpressionConverter.ConvertToken(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmprospect;

    public partial class WorkflowManagedActions
    {
        public BlackbaudcrmprospectActions Blackbaudcrmprospect(string connectionId) => new BlackbaudcrmprospectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudcrmprospectTriggers Blackbaudcrmprospect(string connectionId) => new BlackbaudcrmprospectTriggers(connectionId);
    }
}