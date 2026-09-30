//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmprospect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmprospectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedUnplannedContactReport> CreateUnplannedContactReport([WorkflowExpression] Func<string> bodyplanID, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodyactualDate, [WorkflowExpression] Func<string> bodystage, [WorkflowExpression] Func<string> bodycontactMethod, [WorkflowExpression] Func<string> bodycomment, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<PrsmgNewUnplannedContactReportFundraiser[]> bodyfundraisers = null, [WorkflowExpression] Func<PrsmgNewUnplannedContactReportParticipant[]> bodyparticipants = null)
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
            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
        public IWorkflowAction EditProspectContactReport([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> contactReportId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodystage = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodycomment = null)
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

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
        public IBodyWorkflowAction<PrsmgCreatedProspectOpportunity> CreateProspectOpportunity([WorkflowExpression] Func<string> bodyplanID, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<double> bodyexpectedAskAmount = null, [WorkflowExpression] Func<string> bodyexpectedAskDate = null, [WorkflowExpression] Func<string> bodylikelihood = null, [WorkflowExpression] Func<double> bodyaskAmount = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyacceptedAmount = null, [WorkflowExpression] Func<string> bodyresponseDate = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodytransactionCurrency = null)
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
        public IBodyWorkflowAction<PrsmgProspectOpportunitySearchResultCollection> SearchProspectOpportunities([WorkflowExpression] Func<string> keyname = null, [WorkflowExpression] Func<string> firstname = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<bool> exactmatchonly = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> askDate = null, [WorkflowExpression] Func<double> askAmount = null, [WorkflowExpression] Func<string> designationuserid = null, [WorkflowExpression] Func<bool> onlyProspects = null, [WorkflowExpression] Func<bool> onlyFundraisers = null, [WorkflowExpression] Func<bool> onlyStaff = null, [WorkflowExpression] Func<bool> onlyVolunteers = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includedeceased = null, [WorkflowExpression] Func<bool> includeinactive = null, [WorkflowExpression] Func<bool> checknickname = null, [WorkflowExpression] Func<bool> checkaliases = null, [WorkflowExpression] Func<bool> checkalternatelookupids = null, [WorkflowExpression] Func<int> limit = null)
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
        public IBodyWorkflowAction<PrsmgProspectOpportunity> GetProspectOpportunity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> opportunityId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectopportunities/{0}", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgProspectOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectOpportunity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> opportunityId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<double> bodyexpectedAskAmount = null, [WorkflowExpression] Func<string> bodyexpectedAskDate = null, [WorkflowExpression] Func<string> bodylikelihood = null, [WorkflowExpression] Func<double> bodyaskAmount = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyacceptedAmount = null, [WorkflowExpression] Func<string> bodyresponseDate = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodytransactionCurrency = null)
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
        public IBodyWorkflowAction<PrsmgPlanOpportunityCollection> ListPlanOpportunities([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planId, [WorkflowExpression] Func<statusInput> status = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectopportunities/{0}/list", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<PrsmgPlanOpportunityCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlan> CreateMajorGivingPlan([WorkflowExpression] Func<string> bodyprospectID, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodynarrative = null, [WorkflowExpression] Func<string> bodyprimaryManagerID = null, [WorkflowExpression] Func<string> bodyprimaryStartDate = null, [WorkflowExpression] Func<string> bodysecondaryManagerID = null, [WorkflowExpression] Func<string> bodysecondaryStartDate = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanParticipant[]> bodyparticipants = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanSecondaryFundraiser[]> bodyfundraisers = null)
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
        public IBodyWorkflowAction<PrsmgMajorGivingPlan> GetMajorGivingPlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgMajorGivingPlan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSearchResultCollection> SearchProspects([WorkflowExpression] Func<string> keyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> addressBlock = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<bool> exactMatchOnly = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<bool> onlyProspects = null, [WorkflowExpression] Func<bool> onlyFundraisers = null, [WorkflowExpression] Func<bool> onlyStaff = null, [WorkflowExpression] Func<bool> onlyVolunteers = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> fuzzySearchOnName = null, [WorkflowExpression] Func<int> limit = null)
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
        public IWorkflowAction EditProspect([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> constituentId, [WorkflowExpression] Func<string> bodymanagerID = null, [WorkflowExpression] Func<string> bodystatus = null)
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
        public IWorkflowAction DeleteProspectOpportunity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> opportunityId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectopportunities", ExpressionConverter.ConvertWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectPlanCollection> ListProspectPlans([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactivePlans = null)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectplans", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactivePlans != null)
                callPayload.Queries["include_inactive_plans"] = ExpressionConverter.Convert(includeInactivePlans);
            return new ApiConnectionAction<PrsmgProspectPlanCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSummary> GetProspectSummary([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> constituentId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospects/{0}/prospectstatus", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PrsmgProspectSummary>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectConstituency> CreateProspectConstituency([WorkflowExpression] Func<string> bodyconstituentID, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
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
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlanStep> CreateMajorGivingPlanStep([WorkflowExpression] Func<string> bodyplanID, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodyexpectedDate, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyotherLocation = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanStepFundraiser[]> bodyfundraisers = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanStepParticipant[]> bodyparticipants = null)
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

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
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
                expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
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

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
        public IWorkflowAction DeleteMajorGivingPlanStep([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> stepId)
        {
            var apiCallPath = String.Format("/crm-prsmg/prospectsteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditMajorGivingPlanStep([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> vProspectPlanId, [WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodyotherLocation = null)
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

            var expectedStartTimeObject = new JObject();
            var expectedStartTimeObjectpropCount = 0;
            if (bodyexpectedStarthour != null)
            {
                expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedStarthour);
                expectedStartTimeObjectpropCount++;
            }

            if (bodyexpectedStartminute != null)
            {
                expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedStartminute);
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
                expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyexpectedEndhour);
                expectedEndTimeObjectpropCount++;
            }

            if (bodyexpectedEndminute != null)
            {
                expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyexpectedEndminute);
                expectedEndTimeObjectpropCount++;
            }

            if (expectedEndTimeObjectpropCount > 0)
            {
                body["expected_end_time"] = expectedEndTimeObject;
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

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlan> CreateStewardshipPlan([WorkflowExpression] Func<string> bodyprospectID, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysubtype = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodymanagerID = null, [WorkflowExpression] Func<string> bodymanagerStartDate = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanSteward[]> bodystewards = null)
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
        public IWorkflowAction DeleteStewardshipPlan([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> planId)
        {
            var apiCallPath = String.Format("/crm-prsmg/stewardshipplans/{0}", ExpressionConverter.ConvertWithUrlEncoding(planId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlanStep> CreateStewardshipPlanStep([WorkflowExpression] Func<string> bodyplanID, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodytargetDate, [WorkflowExpression] Func<bodyfrequencyInput> bodyfrequency, [WorkflowExpression] Func<bool> bodylocked = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodytargetStarthour = null, [WorkflowExpression] Func<int> bodytargetStartminute = null, [WorkflowExpression] Func<int> bodytargetEndhour = null, [WorkflowExpression] Func<int> bodytargetEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodynextTargetDate = null, [WorkflowExpression] Func<bodyconnectToInput> bodyconnectTo = null, [WorkflowExpression] Func<string> bodybenefitID = null, [WorkflowExpression] Func<string> bodyeventID = null, [WorkflowExpression] Func<string> bodymailingID = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanStepParticipant[]> bodyparticipants = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanStepAssociatedPlan[]> bodyassociatedPlans = null)
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

            var targetStartTimeObject = new JObject();
            var targetStartTimeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                targetStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodytargetStarthour);
                targetStartTimeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                targetStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodytargetStartminute);
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
                targetEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodytargetEndhour);
                targetEndTimeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                targetEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodytargetEndminute);
                targetEndTimeObjectpropCount++;
            }

            if (targetEndTimeObjectpropCount > 0)
            {
                body["target_end_time"] = targetEndTimeObject;
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

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
                actualEndTimeObjectpropCount++;
            }

            if (actualEndTimeObjectpropCount > 0)
            {
                body["actual_end_time"] = actualEndTimeObject;
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
        public IWorkflowAction DeleteStewardshipPlanStep([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> stepId)
        {
            var apiCallPath = String.Format("/crm-prsmg/stewardshipplansteps/{0}", ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditStewardshipPlanStep([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> stepId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodytargetDate = null, [WorkflowExpression] Func<bool> bodylocked = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodytargetStarthour = null, [WorkflowExpression] Func<int> bodytargetStartminute = null, [WorkflowExpression] Func<int> bodytargetEndhour = null, [WorkflowExpression] Func<int> bodytargetEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<bodyfrequencyInput> bodyfrequency = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodynextTargetDate = null, [WorkflowExpression] Func<bodyconnectToInput> bodyconnectTo = null, [WorkflowExpression] Func<string> bodybenefitID = null, [WorkflowExpression] Func<string> bodyeventID = null, [WorkflowExpression] Func<string> bodymailingID = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null)
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

            var targetStartTimeObject = new JObject();
            var targetStartTimeObjectpropCount = 0;
            if (bodytargetStarthour != null)
            {
                targetStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodytargetStarthour);
                targetStartTimeObjectpropCount++;
            }

            if (bodytargetStartminute != null)
            {
                targetStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodytargetStartminute);
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
                targetEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodytargetEndhour);
                targetEndTimeObjectpropCount++;
            }

            if (bodytargetEndminute != null)
            {
                targetEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodytargetEndminute);
                targetEndTimeObjectpropCount++;
            }

            if (targetEndTimeObjectpropCount > 0)
            {
                body["target_end_time"] = targetEndTimeObject;
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

            var actualStartTimeObject = new JObject();
            var actualStartTimeObjectpropCount = 0;
            if (bodyactualStarthour != null)
            {
                actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualStarthour);
                actualStartTimeObjectpropCount++;
            }

            if (bodyactualStartminute != null)
            {
                actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualStartminute);
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
                actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(bodyactualEndhour);
                actualEndTimeObjectpropCount++;
            }

            if (bodyactualEndminute != null)
            {
                actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(bodyactualEndminute);
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