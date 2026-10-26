//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudcrmprospect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudcrmprospectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedUnplannedContactReport, ApiConnectionActionConfiguration> CreateUnplannedContactReport(Expression<Func<CreateUnplannedContactReportInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedUnplannedContactReport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectcontactreports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedUnplannedContactReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspectContactReport(Expression<Func<string>> contactReportId, Expression<Func<EditProspectContactReportInput>> body)
        {
            var __workflow_contactReportId = WorkflowExpression.Compile(contactReportId, nameof(contactReportId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectcontactreports/{0}", __workflow_contactReportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectOpportunity, ApiConnectionActionConfiguration> CreateProspectOpportunity(Expression<Func<CreateProspectOpportunityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedProspectOpportunity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectopportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedProspectOpportunity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunitySearchResultCollection, ApiConnectionActionConfiguration> SearchProspectOpportunities(Expression<Func<string>> keyname = null, Expression<Func<string>> firstname = null, Expression<Func<string>> lookupId = null, Expression<Func<bool>> exactmatchonly = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> askDate = null, Expression<Func<double>> askAmount = null, Expression<Func<string>> designationuserid = null, Expression<Func<bool>> onlyProspects = null, Expression<Func<bool>> onlyFundraisers = null, Expression<Func<bool>> onlyStaff = null, Expression<Func<bool>> onlyVolunteers = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includedeceased = null, Expression<Func<bool>> includeinactive = null, Expression<Func<bool>> checknickname = null, Expression<Func<bool>> checkaliases = null, Expression<Func<bool>> checkalternatelookupids = null, Expression<Func<int>> limit = null)
        {
            var __workflow_keyname = WorkflowExpression.Compile(keyname, nameof(keyname), required: false);
            var __workflow_firstname = WorkflowExpression.Compile(firstname, nameof(firstname), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_exactmatchonly = WorkflowExpression.Compile(exactmatchonly, nameof(exactmatchonly), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_askDate = WorkflowExpression.Compile(askDate, nameof(askDate), required: false);
            var __workflow_askAmount = WorkflowExpression.Compile(askAmount, nameof(askAmount), required: false);
            var __workflow_designationuserid = WorkflowExpression.Compile(designationuserid, nameof(designationuserid), required: false);
            var __workflow_onlyProspects = WorkflowExpression.Compile(onlyProspects, nameof(onlyProspects), required: false);
            var __workflow_onlyFundraisers = WorkflowExpression.Compile(onlyFundraisers, nameof(onlyFundraisers), required: false);
            var __workflow_onlyStaff = WorkflowExpression.Compile(onlyStaff, nameof(onlyStaff), required: false);
            var __workflow_onlyVolunteers = WorkflowExpression.Compile(onlyVolunteers, nameof(onlyVolunteers), required: false);
            var __workflow_onlyPrimaryAddress = WorkflowExpression.Compile(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            var __workflow_includedeceased = WorkflowExpression.Compile(includedeceased, nameof(includedeceased), required: false);
            var __workflow_includeinactive = WorkflowExpression.Compile(includeinactive, nameof(includeinactive), required: false);
            var __workflow_checknickname = WorkflowExpression.Compile(checknickname, nameof(checknickname), required: false);
            var __workflow_checkaliases = WorkflowExpression.Compile(checkaliases, nameof(checkaliases), required: false);
            var __workflow_checkalternatelookupids = WorkflowExpression.Compile(checkalternatelookupids, nameof(checkalternatelookupids), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PrsmgProspectOpportunitySearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectopportunities/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyname != null)
                    callPayload.Queries["keyname"] = ExpressionConverter.Convert(__workflow_keyname);
                if (__workflow_firstname != null)
                    callPayload.Queries["firstname"] = ExpressionConverter.Convert(__workflow_firstname);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_exactmatchonly != null)
                    callPayload.Queries["exactmatchonly"] = ExpressionConverter.Convert(__workflow_exactmatchonly);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_askDate != null)
                    callPayload.Queries["ask_date"] = ExpressionConverter.Convert(__workflow_askDate);
                if (__workflow_askAmount != null)
                    callPayload.Queries["ask_amount"] = ExpressionConverter.Convert(__workflow_askAmount);
                if (__workflow_designationuserid != null)
                    callPayload.Queries["designationuserid"] = ExpressionConverter.Convert(__workflow_designationuserid);
                if (__workflow_onlyProspects != null)
                    callPayload.Queries["only_prospects"] = ExpressionConverter.Convert(__workflow_onlyProspects);
                if (__workflow_onlyFundraisers != null)
                    callPayload.Queries["only_fundraisers"] = ExpressionConverter.Convert(__workflow_onlyFundraisers);
                if (__workflow_onlyStaff != null)
                    callPayload.Queries["only_staff"] = ExpressionConverter.Convert(__workflow_onlyStaff);
                if (__workflow_onlyVolunteers != null)
                    callPayload.Queries["only_volunteers"] = ExpressionConverter.Convert(__workflow_onlyVolunteers);
                if (__workflow_onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(__workflow_onlyPrimaryAddress);
                if (__workflow_includedeceased != null)
                    callPayload.Queries["includedeceased"] = ExpressionConverter.Convert(__workflow_includedeceased);
                if (__workflow_includeinactive != null)
                    callPayload.Queries["includeinactive"] = ExpressionConverter.Convert(__workflow_includeinactive);
                if (__workflow_checknickname != null)
                    callPayload.Queries["checknickname"] = ExpressionConverter.Convert(__workflow_checknickname);
                if (__workflow_checkaliases != null)
                    callPayload.Queries["checkaliases"] = ExpressionConverter.Convert(__workflow_checkaliases);
                if (__workflow_checkalternatelookupids != null)
                    callPayload.Queries["checkalternatelookupids"] = ExpressionConverter.Convert(__workflow_checkalternatelookupids);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PrsmgProspectOpportunitySearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunity, ApiConnectionActionConfiguration> GetProspectOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<PrsmgProspectOpportunity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectopportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PrsmgProspectOpportunity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspectOpportunity(Expression<Func<string>> opportunityId, Expression<Func<EditProspectOpportunityInput>> body)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectopportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgPlanOpportunityCollection, ApiConnectionActionConfiguration> ListPlanOpportunities(Expression<Func<string>> planId, Expression<Func<statusInput>> status = null)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<PrsmgPlanOpportunityCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectopportunities/{0}/list", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<PrsmgPlanOpportunityCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlan, ApiConnectionActionConfiguration> CreateMajorGivingPlan(Expression<Func<CreateMajorGivingPlanInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedMajorGivingPlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedMajorGivingPlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgMajorGivingPlan, ApiConnectionActionConfiguration> GetMajorGivingPlan(Expression<Func<string>> planId)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            return new DeferredBodyAction<PrsmgMajorGivingPlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectplans/{0}", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PrsmgMajorGivingPlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMajorGivingPlan(Expression<Func<string>> planId)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectplans/{0}", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSearchResultCollection, ApiConnectionActionConfiguration> SearchProspects(Expression<Func<string>> keyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lookupId = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null, Expression<Func<string>> addressBlock = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postCode = null, Expression<Func<bool>> exactMatchOnly = null, Expression<Func<string>> constituency = null, Expression<Func<bool>> onlyProspects = null, Expression<Func<bool>> onlyFundraisers = null, Expression<Func<bool>> onlyStaff = null, Expression<Func<bool>> onlyVolunteers = null, Expression<Func<bool>> onlyPrimaryAddress = null, Expression<Func<bool>> includeDeceased = null, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> fuzzySearchOnName = null, Expression<Func<int>> limit = null)
        {
            var __workflow_keyName = WorkflowExpression.Compile(keyName, nameof(keyName), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lookupId = WorkflowExpression.Compile(lookupId, nameof(lookupId), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_addressBlock = WorkflowExpression.Compile(addressBlock, nameof(addressBlock), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postCode = WorkflowExpression.Compile(postCode, nameof(postCode), required: false);
            var __workflow_exactMatchOnly = WorkflowExpression.Compile(exactMatchOnly, nameof(exactMatchOnly), required: false);
            var __workflow_constituency = WorkflowExpression.Compile(constituency, nameof(constituency), required: false);
            var __workflow_onlyProspects = WorkflowExpression.Compile(onlyProspects, nameof(onlyProspects), required: false);
            var __workflow_onlyFundraisers = WorkflowExpression.Compile(onlyFundraisers, nameof(onlyFundraisers), required: false);
            var __workflow_onlyStaff = WorkflowExpression.Compile(onlyStaff, nameof(onlyStaff), required: false);
            var __workflow_onlyVolunteers = WorkflowExpression.Compile(onlyVolunteers, nameof(onlyVolunteers), required: false);
            var __workflow_onlyPrimaryAddress = WorkflowExpression.Compile(onlyPrimaryAddress, nameof(onlyPrimaryAddress), required: false);
            var __workflow_includeDeceased = WorkflowExpression.Compile(includeDeceased, nameof(includeDeceased), required: false);
            var __workflow_includeInactive = WorkflowExpression.Compile(includeInactive, nameof(includeInactive), required: false);
            var __workflow_fuzzySearchOnName = WorkflowExpression.Compile(fuzzySearchOnName, nameof(fuzzySearchOnName), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PrsmgProspectSearchResultCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospects/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_keyName != null)
                    callPayload.Queries["key_name"] = ExpressionConverter.Convert(__workflow_keyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lookupId != null)
                    callPayload.Queries["lookup_id"] = ExpressionConverter.Convert(__workflow_lookupId);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phone_number"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_addressBlock != null)
                    callPayload.Queries["address_block"] = ExpressionConverter.Convert(__workflow_addressBlock);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postCode != null)
                    callPayload.Queries["post_code"] = ExpressionConverter.Convert(__workflow_postCode);
                if (__workflow_exactMatchOnly != null)
                    callPayload.Queries["exact_match_only"] = ExpressionConverter.Convert(__workflow_exactMatchOnly);
                if (__workflow_constituency != null)
                    callPayload.Queries["constituency"] = ExpressionConverter.Convert(__workflow_constituency);
                if (__workflow_onlyProspects != null)
                    callPayload.Queries["only_prospects"] = ExpressionConverter.Convert(__workflow_onlyProspects);
                if (__workflow_onlyFundraisers != null)
                    callPayload.Queries["only_fundraisers"] = ExpressionConverter.Convert(__workflow_onlyFundraisers);
                if (__workflow_onlyStaff != null)
                    callPayload.Queries["only_staff"] = ExpressionConverter.Convert(__workflow_onlyStaff);
                if (__workflow_onlyVolunteers != null)
                    callPayload.Queries["only_volunteers"] = ExpressionConverter.Convert(__workflow_onlyVolunteers);
                if (__workflow_onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = ExpressionConverter.Convert(__workflow_onlyPrimaryAddress);
                if (__workflow_includeDeceased != null)
                    callPayload.Queries["include_deceased"] = ExpressionConverter.Convert(__workflow_includeDeceased);
                if (__workflow_includeInactive != null)
                    callPayload.Queries["include_inactive"] = ExpressionConverter.Convert(__workflow_includeInactive);
                if (__workflow_fuzzySearchOnName != null)
                    callPayload.Queries["fuzzy_search_on_name"] = ExpressionConverter.Convert(__workflow_fuzzySearchOnName);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PrsmgProspectSearchResultCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspect(Expression<Func<string>> constituentId, Expression<Func<EditProspectInput>> body)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospects/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProspectOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospects/{0}/prospectopportunities", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectPlanCollection, ApiConnectionActionConfiguration> ListProspectPlans(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactivePlans = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_includeInactivePlans = WorkflowExpression.Compile(includeInactivePlans, nameof(includeInactivePlans), required: false);
            return new DeferredBodyAction<PrsmgProspectPlanCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospects/{0}/prospectplans", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeInactivePlans != null)
                    callPayload.Queries["include_inactive_plans"] = ExpressionConverter.Convert(__workflow_includeInactivePlans);
                return new ApiConnectionAction<PrsmgProspectPlanCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSummary, ApiConnectionActionConfiguration> GetProspectSummary(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<PrsmgProspectSummary, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospects/{0}/prospectstatus", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PrsmgProspectSummary>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectConstituency, ApiConnectionActionConfiguration> CreateProspectConstituency(Expression<Func<CreateProspectConstituencyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedProspectConstituency, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectsconstituency";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedProspectConstituency>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlanStep, ApiConnectionActionConfiguration> CreateMajorGivingPlanStep(Expression<Func<CreateMajorGivingPlanStepInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedMajorGivingPlanStep, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectsteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedMajorGivingPlanStep>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMajorGivingPlanStep(Expression<Func<string>> stepId)
        {
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectsteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditMajorGivingPlanStep(Expression<Func<string>> vProspectPlanId, Expression<Func<string>> stepId, Expression<Func<EditMajorGivingPlanStepInput>> body)
        {
            var __workflow_vProspectPlanId = WorkflowExpression.Compile(vProspectPlanId, nameof(vProspectPlanId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectsteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v_prospect_plan_id"] = ExpressionConverter.Convert(__workflow_vProspectPlanId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlan, ApiConnectionActionConfiguration> CreateStewardshipPlan(Expression<Func<CreateStewardshipPlanInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedStewardshipPlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/stewardshipplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedStewardshipPlan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteStewardshipPlan(Expression<Func<string>> planId)
        {
            var __workflow_planId = WorkflowExpression.Compile(planId, nameof(planId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/stewardshipplans/{0}", __workflow_planId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlanStep, ApiConnectionActionConfiguration> CreateStewardshipPlanStep(Expression<Func<CreateStewardshipPlanStepInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PrsmgCreatedStewardshipPlanStep, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/stewardshipplansteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PrsmgCreatedStewardshipPlanStep>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteStewardshipPlanStep(Expression<Func<string>> stepId)
        {
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditStewardshipPlanStep(Expression<Func<string>> stepId, Expression<Func<EditStewardshipPlanStepInput>> body)
        {
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudcrmprospectTriggers([ConnectionName] string connectionId)
    {
    }

    public class PrsmgCreatedUnplannedContactReport
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateUnplannedContactReportInput
    {
        [JsonProperty("prospect_plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("objective", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Objective { get; set; }

        [JsonProperty("owner_id")]
        public string Owner { get; set; }

        [JsonProperty("actual_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public CreateUnplannedContactReportInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public CreateUnplannedContactReportInputActualEndType ActualEnd { get; set; }

        [JsonProperty("prospect_plan_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Stage { get; set; }

        [JsonProperty("interaction_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactMethod { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }

        [JsonProperty("additional_fundraisers")]
        public PrsmgNewUnplannedContactReportFundraiser[] Fundraisers { get; set; }

        [JsonProperty("participants")]
        public PrsmgNewUnplannedContactReportParticipant[] Participants { get; set; }
    }

    public class CreateUnplannedContactReportInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateUnplannedContactReportInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class PrsmgNewUnplannedContactReportFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string Id { get; set; }
    }

    public class PrsmgNewUnplannedContactReportParticipant
    {
        [JsonProperty("constituent_id")]
        public string Id { get; set; }
    }

    public class EditProspectContactReportInput
    {
        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("owner_id")]
        public string Owner { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public EditProspectContactReportInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public EditProspectContactReportInputActualEndType ActualEnd { get; set; }

        [JsonProperty("prospect_plan_status")]
        public string Stage { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class EditProspectContactReportInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditProspectContactReportInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class PrsmgCreatedProspectOpportunity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateProspectOpportunityInput
    {
        [JsonProperty("prospect_plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateProspectOpportunityInputStatusType Status { get; set; }

        [JsonProperty("opportunity_type")]
        public string Type { get; set; }

        [JsonProperty("expected_ask_amount")]
        public double? ExpectedAskAmount { get; set; }

        [JsonProperty("expected_ask_date")]
        public string ExpectedAskDate { get; set; }

        [JsonProperty("likelihood_type_code")]
        public string Likelihood { get; set; }

        [JsonProperty("ask_amount")]
        public double? AskAmount { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("accepted_amount")]
        public double? AcceptedAmount { get; set; }

        [JsonProperty("response_date")]
        public string ResponseDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("transaction_currency")]
        public string TransactionCurrency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateProspectOpportunityInputStatusType
    {
        Unqualified,
        Qualified,
        [EnumMember(Value = "Response pending")]
        ResponsePending,
        Accepted,
        Rejected,
        Canceled
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
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ask_amount")]
        public double AskAmount { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("transaction_currency_id")]
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("prospect_plan_type")]
        public string PlanType { get; set; }

        [JsonProperty("prospect_plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("name")]
        public string ProspectName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("prospect_id")]
        public string ProspectId { get; set; }

        [JsonProperty("prospect_plan")]
        public string ProspectPlanName { get; set; }

        [JsonProperty("designation")]
        public PrsmgProspectOpportunityDesignation[] Designations { get; set; }
    }

    public class PrsmgProspectOpportunityDesignation
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("designation_id")]
        public string DesignationId { get; set; }

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
        public string TransactionCurrencyId { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class EditProspectOpportunityInput
    {
        [JsonProperty("status")]
        public EditProspectOpportunityInputStatusType? Status { get; set; }

        [JsonProperty("opportunity_type")]
        public string Type { get; set; }

        [JsonProperty("expected_ask_amount")]
        public double? ExpectedAskAmount { get; set; }

        [JsonProperty("expected_ask_date")]
        public string ExpectedAskDate { get; set; }

        [JsonProperty("likelihood_type_code")]
        public string Likelihood { get; set; }

        [JsonProperty("ask_amount")]
        public double? AskAmount { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("accepted_amount")]
        public double? AcceptedAmount { get; set; }

        [JsonProperty("response_date")]
        public string ResponseDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("transaction_currency")]
        public string TransactionCurrency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditProspectOpportunityInputStatusType
    {
        Unqualified,
        Qualified,
        [EnumMember(Value = "Response pending")]
        ResponsePending,
        Accepted,
        Rejected,
        Canceled
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
        public string Id { get; set; }

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
        public string BaseCurrencyId { get; set; }
    }

    public class PrsmgCreatedMajorGivingPlan
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateMajorGivingPlanInput
    {
        [JsonProperty("prospect_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProspectId { get; set; }

        [JsonProperty("prospect_plan_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("prospect_plan_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("primary_manager_fundraiser_id")]
        public string PrimaryManagerId { get; set; }

        [JsonProperty("primary_manager_date_from")]
        public string PrimaryStartDate { get; set; }

        [JsonProperty("secondary_manager_fundraiser_id")]
        public string SecondaryManagerId { get; set; }

        [JsonProperty("secondary_manager_date_from")]
        public string SecondaryStartDate { get; set; }

        [JsonProperty("prospect_plan_participants")]
        public PrsmgNewMajorGivingPlanParticipant[] Participants { get; set; }

        [JsonProperty("secondary_fundraisers")]
        public PrsmgNewMajorGivingPlanSecondaryFundraiser[] Fundraisers { get; set; }
    }

    public class PrsmgNewMajorGivingPlanParticipant
    {
        [JsonProperty("constituent_id")]
        public string Id { get; set; }

        [JsonProperty("plan_participant_role")]
        public string Role { get; set; }
    }

    public class PrsmgNewMajorGivingPlanSecondaryFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string Id { get; set; }

        [JsonProperty("solicitor_role")]
        public string Role { get; set; }

        [JsonProperty("date_from")]
        public string Start { get; set; }
    }

    public class PrsmgMajorGivingPlan
    {
        [JsonProperty("prospect_id")]
        public string ProspectId { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("plan_outline_step_id")]
        public string PlanOutlineStepId { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserId { get; set; }
    }

    public class PrsmgMajorGivingPlanStepParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ParticipantId { get; set; }
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
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prospect_manager")]
        public string ProspectManager { get; set; }

        [JsonProperty("primary_managers")]
        public string PrimaryManagerS { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

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

    public class EditProspectInput
    {
        [JsonProperty("prospect_manager_fundraiser_id")]
        public string ManagerId { get; set; }

        [JsonProperty("prospect_status")]
        public string Status { get; set; }
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
        public string Id { get; set; }

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
        public string NextInteractionId { get; set; }

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
        public string ManagerId { get; set; }

        [JsonProperty("prospect_manager_start_date")]
        public string StartDate { get; set; }
    }

    public class PrsmgCreatedProspectConstituency
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateProspectConstituencyInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        [JsonProperty("date_to")]
        public string DateTo { get; set; }
    }

    public class PrsmgCreatedMajorGivingPlanStep
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateMajorGivingPlanStepInput
    {
        [JsonProperty("prospect_plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("objective", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Objective { get; set; }

        [JsonProperty("prospect_plan_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateMajorGivingPlanStepInputStatusType Status { get; set; }

        [JsonProperty("expected_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExpectedDate { get; set; }

        [JsonProperty("owner_id")]
        public string Owner { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("is_all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("expected_start_time")]
        public CreateMajorGivingPlanStepInputExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public CreateMajorGivingPlanStepInputExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public CreateMajorGivingPlanStepInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public CreateMajorGivingPlanStepInputActualEndType ActualEnd { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("other_location")]
        public string OtherLocation { get; set; }

        [JsonProperty("additional_fundraisers")]
        public PrsmgNewMajorGivingPlanStepFundraiser[] Fundraisers { get; set; }

        [JsonProperty("participants")]
        public PrsmgNewMajorGivingPlanStepParticipant[] Participants { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateMajorGivingPlanStepInputStatusType
    {
        Planned,
        Pending,
        Completed,
        Cancelled,
        Declined
    }

    public class CreateMajorGivingPlanStepInputExpectedStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateMajorGivingPlanStepInputExpectedEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateMajorGivingPlanStepInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateMajorGivingPlanStepInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class PrsmgNewMajorGivingPlanStepFundraiser
    {
        [JsonProperty("fundraiser_id")]
        public string Id { get; set; }
    }

    public class PrsmgNewMajorGivingPlanStepParticipant
    {
        [JsonProperty("constituent_id")]
        public string Id { get; set; }
    }

    public class EditMajorGivingPlanStepInput
    {
        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("prospect_plan_status")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public EditMajorGivingPlanStepInputStatusType? Status { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("owner_id")]
        public string Owner { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("interaction_type")]
        public string ContactMethod { get; set; }

        [JsonProperty("interaction_category")]
        public string Category { get; set; }

        [JsonProperty("interaction_subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("is_all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("expected_start_time")]
        public EditMajorGivingPlanStepInputExpectedStartType ExpectedStart { get; set; }

        [JsonProperty("expected_end_time")]
        public EditMajorGivingPlanStepInputExpectedEndType ExpectedEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public EditMajorGivingPlanStepInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public EditMajorGivingPlanStepInputActualEndType ActualEnd { get; set; }

        [JsonProperty("other_location")]
        public string OtherLocation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditMajorGivingPlanStepInputStatusType
    {
        Planned,
        Pending,
        Completed,
        Cancelled,
        Declined
    }

    public class EditMajorGivingPlanStepInputExpectedStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditMajorGivingPlanStepInputExpectedEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditMajorGivingPlanStepInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditMajorGivingPlanStepInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class PrsmgCreatedStewardshipPlan
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateStewardshipPlanInput
    {
        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProspectId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("plan_type_id")]
        public string Type { get; set; }

        [JsonProperty("plan_sub_type_id")]
        public string Subtype { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("manager_id")]
        public string ManagerId { get; set; }

        [JsonProperty("manager_start_date")]
        public string ManagerStartDate { get; set; }

        [JsonProperty("stewards")]
        public PrsmgNewStewardshipPlanSteward[] Stewards { get; set; }
    }

    public class PrsmgNewStewardshipPlanSteward
    {
        [JsonProperty("constituent_id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }

    public class PrsmgCreatedStewardshipPlanStep
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateStewardshipPlanStepInput
    {
        [JsonProperty("stewardship_plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("objective", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Objective { get; set; }

        [JsonProperty("target_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetDate { get; set; }

        [JsonProperty("date_locked")]
        public bool? Locked { get; set; }

        [JsonProperty("all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("target_start_time")]
        public CreateStewardshipPlanStepInputTargetStartType TargetStart { get; set; }

        [JsonProperty("target_end_time")]
        public CreateStewardshipPlanStepInputTargetEndType TargetEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("status_code")]
        public CreateStewardshipPlanStepInputStatusType? Status { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("constituent_id")]
        public string AssignedTo { get; set; }

        [JsonProperty("contact_method")]
        public string ContactMethod { get; set; }

        [JsonProperty("recurs", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateStewardshipPlanStepInputFrequencyType Frequency { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("next_target_date")]
        public string NextTargetDate { get; set; }

        [JsonProperty("link_type_code")]
        public CreateStewardshipPlanStepInputConnectToType? ConnectTo { get; set; }

        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("mailing_id")]
        public string MailingId { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public CreateStewardshipPlanStepInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public CreateStewardshipPlanStepInputActualEndType ActualEnd { get; set; }

        [JsonProperty("step_participants")]
        public PrsmgNewStewardshipPlanStepParticipant[] Participants { get; set; }

        [JsonProperty("associated_plans")]
        public PrsmgNewStewardshipPlanStepAssociatedPlan[] AssociatedPlans { get; set; }
    }

    public class CreateStewardshipPlanStepInputTargetStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateStewardshipPlanStepInputTargetEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateStewardshipPlanStepInputStatusType
    {
        Pending,
        Completed,
        Cancelled,
        Declined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateStewardshipPlanStepInputFrequencyType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateStewardshipPlanStepInputConnectToType
    {
        Benefit,
        Event,
        Mailing
    }

    public class CreateStewardshipPlanStepInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class CreateStewardshipPlanStepInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class PrsmgNewStewardshipPlanStepParticipant
    {
        [JsonProperty("constituent_id")]
        public string Id { get; set; }
    }

    public class PrsmgNewStewardshipPlanStepAssociatedPlan
    {
        [JsonProperty("prospect_plan_id")]
        public string PlanId { get; set; }
    }

    public class EditStewardshipPlanStepInput
    {
        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("target_date")]
        public string TargetDate { get; set; }

        [JsonProperty("date_locked")]
        public bool? Locked { get; set; }

        [JsonProperty("all_day_event")]
        public bool? AllDayEvent { get; set; }

        [JsonProperty("target_start_time")]
        public EditStewardshipPlanStepInputTargetStartType TargetStart { get; set; }

        [JsonProperty("target_end_time")]
        public EditStewardshipPlanStepInputTargetEndType TargetEnd { get; set; }

        [JsonProperty("time_zone_entry")]
        public string TimeZone { get; set; }

        [JsonProperty("status")]
        public EditStewardshipPlanStepInputStatusType? Status { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("constituent_id")]
        public string AssignedTo { get; set; }

        [JsonProperty("contact_method")]
        public string ContactMethod { get; set; }

        [JsonProperty("recurs")]
        public EditStewardshipPlanStepInputFrequencyType? Frequency { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("next_target_date")]
        public string NextTargetDate { get; set; }

        [JsonProperty("link_type")]
        public EditStewardshipPlanStepInputConnectToType? ConnectTo { get; set; }

        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("mailing_id")]
        public string MailingId { get; set; }

        [JsonProperty("actual_date")]
        public string ActualDate { get; set; }

        [JsonProperty("actual_start_time")]
        public EditStewardshipPlanStepInputActualStartType ActualStart { get; set; }

        [JsonProperty("actual_end_time")]
        public EditStewardshipPlanStepInputActualEndType ActualEnd { get; set; }
    }

    public class EditStewardshipPlanStepInputTargetStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditStewardshipPlanStepInputTargetEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditStewardshipPlanStepInputStatusType
    {
        Pending,
        Completed,
        Cancelled,
        Declined
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditStewardshipPlanStepInputFrequencyType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditStewardshipPlanStepInputConnectToType
    {
        Benefit,
        Event,
        Mailing
    }

    public class EditStewardshipPlanStepInputActualStartType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
    }

    public class EditStewardshipPlanStepInputActualEndType
    {
        [JsonProperty("hour")]
        public int? Hour { get; set; }

        [JsonProperty("minute")]
        public int? Minute { get; set; }
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