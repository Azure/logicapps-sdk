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
        public IBodyWorkflowAction<PrsmgCreatedUnplannedContactReport, ApiConnectionActionConfiguration> CreateUnplannedContactReport(Expression<Func<string>> bodyplanId, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodyactualDate, Expression<Func<string>> bodystage, Expression<Func<string>> bodycontactMethod, Expression<Func<string>> bodycomment, Expression<Func<string>> bodyowner = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<PrsmgNewUnplannedContactReportFundraiser[]>> bodyfundraisers = null, Expression<Func<PrsmgNewUnplannedContactReportParticipant[]>> bodyparticipants = null)
        {
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: true);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: true);
            var __workflow_bodystage = WorkflowExpression.Compile(bodystage, nameof(bodystage), required: true);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: true);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodyfundraisers = WorkflowExpression.Compile(bodyfundraisers, nameof(bodyfundraisers), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<PrsmgCreatedUnplannedContactReport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectcontactreports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                if (__workflow_bodyowner != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                bodypropCount++;
                body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["prospect_plan_status"] = ExpressionConverter.ConvertO(__workflow_bodystage);
                bodypropCount++;
                body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                if (__workflow_bodyfundraisers != null)
                {
                    body["additional_fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraisers);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PrsmgCreatedUnplannedContactReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspectContactReport(Expression<Func<string>> contactReportId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodystage = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_contactReportId = WorkflowExpression.Compile(contactReportId, nameof(contactReportId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodystage = WorkflowExpression.Compile(bodystage, nameof(bodystage), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectcontactreports/{0}", __workflow_contactReportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyobjective != null)
                {
                    body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodystage != null)
                {
                    body["prospect_plan_status"] = ExpressionConverter.ConvertO(__workflow_bodystage);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectOpportunity, ApiConnectionActionConfiguration> CreateProspectOpportunity(Expression<Func<string>> bodyplanId, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodytype = null, Expression<Func<double>> bodyexpectedAskAmount = null, Expression<Func<string>> bodyexpectedAskDate = null, Expression<Func<string>> bodylikelihood = null, Expression<Func<double>> bodyaskAmount = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyacceptedAmount = null, Expression<Func<string>> bodyresponseDate = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodytransactionCurrency = null)
        {
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyexpectedAskAmount = WorkflowExpression.Compile(bodyexpectedAskAmount, nameof(bodyexpectedAskAmount), required: false);
            var __workflow_bodyexpectedAskDate = WorkflowExpression.Compile(bodyexpectedAskDate, nameof(bodyexpectedAskDate), required: false);
            var __workflow_bodylikelihood = WorkflowExpression.Compile(bodylikelihood, nameof(bodylikelihood), required: false);
            var __workflow_bodyaskAmount = WorkflowExpression.Compile(bodyaskAmount, nameof(bodyaskAmount), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyacceptedAmount = WorkflowExpression.Compile(bodyacceptedAmount, nameof(bodyacceptedAmount), required: false);
            var __workflow_bodyresponseDate = WorkflowExpression.Compile(bodyresponseDate, nameof(bodyresponseDate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodytransactionCurrency = WorkflowExpression.Compile(bodytransactionCurrency, nameof(bodytransactionCurrency), required: false);
            return new DeferredBodyAction<PrsmgCreatedProspectOpportunity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectopportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                if (__workflow_bodytype != null)
                {
                    body["opportunity_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAskAmount != null)
                {
                    body["expected_ask_amount"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAskAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAskDate != null)
                {
                    body["expected_ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAskDate);
                    bodypropCount++;
                }

                if (__workflow_bodylikelihood != null)
                {
                    body["likelihood_type_code"] = ExpressionConverter.ConvertO(__workflow_bodylikelihood);
                    bodypropCount++;
                }

                if (__workflow_bodyaskAmount != null)
                {
                    body["ask_amount"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                if (__workflow_bodyacceptedAmount != null)
                {
                    body["accepted_amount"] = ExpressionConverter.ConvertO(__workflow_bodyacceptedAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseDate != null)
                {
                    body["response_date"] = ExpressionConverter.ConvertO(__workflow_bodyresponseDate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionCurrency != null)
                {
                    body["transaction_currency"] = ExpressionConverter.ConvertO(__workflow_bodytransactionCurrency);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspectOpportunity(Expression<Func<string>> opportunityId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodytype = null, Expression<Func<double>> bodyexpectedAskAmount = null, Expression<Func<string>> bodyexpectedAskDate = null, Expression<Func<string>> bodylikelihood = null, Expression<Func<double>> bodyaskAmount = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyacceptedAmount = null, Expression<Func<string>> bodyresponseDate = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodytransactionCurrency = null)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyexpectedAskAmount = WorkflowExpression.Compile(bodyexpectedAskAmount, nameof(bodyexpectedAskAmount), required: false);
            var __workflow_bodyexpectedAskDate = WorkflowExpression.Compile(bodyexpectedAskDate, nameof(bodyexpectedAskDate), required: false);
            var __workflow_bodylikelihood = WorkflowExpression.Compile(bodylikelihood, nameof(bodylikelihood), required: false);
            var __workflow_bodyaskAmount = WorkflowExpression.Compile(bodyaskAmount, nameof(bodyaskAmount), required: false);
            var __workflow_bodyaskDate = WorkflowExpression.Compile(bodyaskDate, nameof(bodyaskDate), required: false);
            var __workflow_bodyacceptedAmount = WorkflowExpression.Compile(bodyacceptedAmount, nameof(bodyacceptedAmount), required: false);
            var __workflow_bodyresponseDate = WorkflowExpression.Compile(bodyresponseDate, nameof(bodyresponseDate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodytransactionCurrency = WorkflowExpression.Compile(bodytransactionCurrency, nameof(bodytransactionCurrency), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectopportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["opportunity_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAskAmount != null)
                {
                    body["expected_ask_amount"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAskAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedAskDate != null)
                {
                    body["expected_ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedAskDate);
                    bodypropCount++;
                }

                if (__workflow_bodylikelihood != null)
                {
                    body["likelihood_type_code"] = ExpressionConverter.ConvertO(__workflow_bodylikelihood);
                    bodypropCount++;
                }

                if (__workflow_bodyaskAmount != null)
                {
                    body["ask_amount"] = ExpressionConverter.ConvertO(__workflow_bodyaskAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyaskDate != null)
                {
                    body["ask_date"] = ExpressionConverter.ConvertO(__workflow_bodyaskDate);
                    bodypropCount++;
                }

                if (__workflow_bodyacceptedAmount != null)
                {
                    body["accepted_amount"] = ExpressionConverter.ConvertO(__workflow_bodyacceptedAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseDate != null)
                {
                    body["response_date"] = ExpressionConverter.ConvertO(__workflow_bodyresponseDate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionCurrency != null)
                {
                    body["transaction_currency"] = ExpressionConverter.ConvertO(__workflow_bodytransactionCurrency);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlan, ApiConnectionActionConfiguration> CreateMajorGivingPlan(Expression<Func<string>> bodyprospectId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodynarrative = null, Expression<Func<string>> bodyprimaryManagerId = null, Expression<Func<string>> bodyprimaryStartDate = null, Expression<Func<string>> bodysecondaryManagerId = null, Expression<Func<string>> bodysecondaryStartDate = null, Expression<Func<PrsmgNewMajorGivingPlanParticipant[]>> bodyparticipants = null, Expression<Func<PrsmgNewMajorGivingPlanSecondaryFundraiser[]>> bodyfundraisers = null)
        {
            var __workflow_bodyprospectId = WorkflowExpression.Compile(bodyprospectId, nameof(bodyprospectId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodynarrative = WorkflowExpression.Compile(bodynarrative, nameof(bodynarrative), required: false);
            var __workflow_bodyprimaryManagerId = WorkflowExpression.Compile(bodyprimaryManagerId, nameof(bodyprimaryManagerId), required: false);
            var __workflow_bodyprimaryStartDate = WorkflowExpression.Compile(bodyprimaryStartDate, nameof(bodyprimaryStartDate), required: false);
            var __workflow_bodysecondaryManagerId = WorkflowExpression.Compile(bodysecondaryManagerId, nameof(bodysecondaryManagerId), required: false);
            var __workflow_bodysecondaryStartDate = WorkflowExpression.Compile(bodysecondaryStartDate, nameof(bodysecondaryStartDate), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            var __workflow_bodyfundraisers = WorkflowExpression.Compile(bodyfundraisers, nameof(bodyfundraisers), required: false);
            return new DeferredBodyAction<PrsmgCreatedMajorGivingPlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_id"] = ExpressionConverter.ConvertO(__workflow_bodyprospectId);
                bodypropCount++;
                body["prospect_plan_name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["prospect_plan_type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodynarrative != null)
                {
                    body["narrative"] = ExpressionConverter.ConvertO(__workflow_bodynarrative);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryManagerId != null)
                {
                    body["primary_manager_fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryManagerId);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryStartDate != null)
                {
                    body["primary_manager_date_from"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodysecondaryManagerId != null)
                {
                    body["secondary_manager_fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryManagerId);
                    bodypropCount++;
                }

                if (__workflow_bodysecondaryStartDate != null)
                {
                    body["secondary_manager_date_from"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["prospect_plan_participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraisers != null)
                {
                    body["secondary_fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraisers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditProspect(Expression<Func<string>> constituentId, Expression<Func<string>> bodymanagerId = null, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospects/{0}", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymanagerId != null)
                {
                    body["prospect_manager_fundraiser_id"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["prospect_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<PrsmgCreatedProspectConstituency, ApiConnectionActionConfiguration> CreateProspectConstituency(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodydateFrom = null, Expression<Func<string>> bodydateTo = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodydateFrom = WorkflowExpression.Compile(bodydateFrom, nameof(bodydateFrom), required: false);
            var __workflow_bodydateTo = WorkflowExpression.Compile(bodydateTo, nameof(bodydateTo), required: false);
            return new DeferredBodyAction<PrsmgCreatedProspectConstituency, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectsconstituency";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                if (__workflow_bodydateFrom != null)
                {
                    body["date_from"] = ExpressionConverter.ConvertO(__workflow_bodydateFrom);
                    bodypropCount++;
                }

                if (__workflow_bodydateTo != null)
                {
                    body["date_to"] = ExpressionConverter.ConvertO(__workflow_bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PrsmgCreatedProspectConstituency>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlanStep, ApiConnectionActionConfiguration> CreateMajorGivingPlanStep(Expression<Func<string>> bodyplanId, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodytype, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodyexpectedDate, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyotherLocation = null, Expression<Func<PrsmgNewMajorGivingPlanStepFundraiser[]>> bodyfundraisers = null, Expression<Func<PrsmgNewMajorGivingPlanStepParticipant[]>> bodyparticipants = null)
        {
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: true);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodyexpectedStarthour = WorkflowExpression.Compile(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            var __workflow_bodyexpectedStartminute = WorkflowExpression.Compile(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            var __workflow_bodyexpectedEndhour = WorkflowExpression.Compile(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            var __workflow_bodyexpectedEndminute = WorkflowExpression.Compile(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodyotherLocation = WorkflowExpression.Compile(bodyotherLocation, nameof(bodyotherLocation), required: false);
            var __workflow_bodyfundraisers = WorkflowExpression.Compile(bodyfundraisers, nameof(bodyfundraisers), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            return new DeferredBodyAction<PrsmgCreatedMajorGivingPlanStep, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/prospectsteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                bodypropCount++;
                body["prospect_plan_status"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                bodypropCount++;
                body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                if (__workflow_bodyowner != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStartminute);
                    expectedStartTimeObjectpropCount++;
                }

                if (expectedStartTimeObjectpropCount > 0)
                {
                    body["expected_start_time"] = expectedStartTimeObject;
                    bodypropCount++;
                }

                var expectedEndTimeObject = new JObject();
                var expectedEndTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedEndhour != null)
                {
                    expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodyotherLocation != null)
                {
                    body["other_location"] = ExpressionConverter.ConvertO(__workflow_bodyotherLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyfundraisers != null)
                {
                    body["additional_fundraisers"] = ExpressionConverter.ConvertO(__workflow_bodyfundraisers);
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditMajorGivingPlanStep(Expression<Func<string>> vProspectPlanId, Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytype = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodyexpectedStarthour = null, Expression<Func<int>> bodyexpectedStartminute = null, Expression<Func<int>> bodyexpectedEndhour = null, Expression<Func<int>> bodyexpectedEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<string>> bodyotherLocation = null)
        {
            var __workflow_vProspectPlanId = WorkflowExpression.Compile(vProspectPlanId, nameof(vProspectPlanId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyexpectedDate = WorkflowExpression.Compile(bodyexpectedDate, nameof(bodyexpectedDate), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodyexpectedStarthour = WorkflowExpression.Compile(bodyexpectedStarthour, nameof(bodyexpectedStarthour), required: false);
            var __workflow_bodyexpectedStartminute = WorkflowExpression.Compile(bodyexpectedStartminute, nameof(bodyexpectedStartminute), required: false);
            var __workflow_bodyexpectedEndhour = WorkflowExpression.Compile(bodyexpectedEndhour, nameof(bodyexpectedEndhour), required: false);
            var __workflow_bodyexpectedEndminute = WorkflowExpression.Compile(bodyexpectedEndminute, nameof(bodyexpectedEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodyotherLocation = WorkflowExpression.Compile(bodyotherLocation, nameof(bodyotherLocation), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/prospectsteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v_prospect_plan_id"] = ExpressionConverter.Convert(__workflow_vProspectPlanId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyobjective != null)
                {
                    body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["prospect_plan_status"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedDate != null)
                {
                    body["expected_date"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedDate);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["interaction_type"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["interaction_category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["interaction_subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedStartminute);
                    expectedStartTimeObjectpropCount++;
                }

                if (expectedStartTimeObjectpropCount > 0)
                {
                    body["expected_start_time"] = expectedStartTimeObject;
                    bodypropCount++;
                }

                var expectedEndTimeObject = new JObject();
                var expectedEndTimeObjectpropCount = 0;
                if (__workflow_bodyexpectedEndhour != null)
                {
                    expectedEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (__workflow_bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyotherLocation != null)
                {
                    body["other_location"] = ExpressionConverter.ConvertO(__workflow_bodyotherLocation);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlan, ApiConnectionActionConfiguration> CreateStewardshipPlan(Expression<Func<string>> bodyprospectId, Expression<Func<string>> bodyname, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysubtype = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodymanagerId = null, Expression<Func<string>> bodymanagerStartDate = null, Expression<Func<PrsmgNewStewardshipPlanSteward[]>> bodystewards = null)
        {
            var __workflow_bodyprospectId = WorkflowExpression.Compile(bodyprospectId, nameof(bodyprospectId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodysubtype = WorkflowExpression.Compile(bodysubtype, nameof(bodysubtype), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodymanagerId = WorkflowExpression.Compile(bodymanagerId, nameof(bodymanagerId), required: false);
            var __workflow_bodymanagerStartDate = WorkflowExpression.Compile(bodymanagerStartDate, nameof(bodymanagerStartDate), required: false);
            var __workflow_bodystewards = WorkflowExpression.Compile(bodystewards, nameof(bodystewards), required: false);
            return new DeferredBodyAction<PrsmgCreatedStewardshipPlan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/stewardshipplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyprospectId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodytype != null)
                {
                    body["plan_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodysubtype != null)
                {
                    body["plan_sub_type_id"] = ExpressionConverter.ConvertO(__workflow_bodysubtype);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerId != null)
                {
                    body["manager_id"] = ExpressionConverter.ConvertO(__workflow_bodymanagerId);
                    bodypropCount++;
                }

                if (__workflow_bodymanagerStartDate != null)
                {
                    body["manager_start_date"] = ExpressionConverter.ConvertO(__workflow_bodymanagerStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystewards != null)
                {
                    body["stewards"] = ExpressionConverter.ConvertO(__workflow_bodystewards);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlanStep, ApiConnectionActionConfiguration> CreateStewardshipPlanStep(Expression<Func<string>> bodyplanId, Expression<Func<string>> bodyobjective, Expression<Func<string>> bodytargetDate, Expression<Func<bodyfrequencyInput>> bodyfrequency, Expression<Func<bool>> bodylocked = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodytargetStarthour = null, Expression<Func<int>> bodytargetStartminute = null, Expression<Func<int>> bodytargetEndhour = null, Expression<Func<int>> bodytargetEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodynextTargetDate = null, Expression<Func<bodyconnectToInput>> bodyconnectTo = null, Expression<Func<string>> bodybenefitId = null, Expression<Func<string>> bodyeventId = null, Expression<Func<string>> bodymailingId = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null, Expression<Func<PrsmgNewStewardshipPlanStepParticipant[]>> bodyparticipants = null, Expression<Func<PrsmgNewStewardshipPlanStepAssociatedPlan[]>> bodyassociatedPlans = null)
        {
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: true);
            var __workflow_bodytargetDate = WorkflowExpression.Compile(bodytargetDate, nameof(bodytargetDate), required: true);
            var __workflow_bodyfrequency = WorkflowExpression.Compile(bodyfrequency, nameof(bodyfrequency), required: true);
            var __workflow_bodylocked = WorkflowExpression.Compile(bodylocked, nameof(bodylocked), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodytargetStarthour = WorkflowExpression.Compile(bodytargetStarthour, nameof(bodytargetStarthour), required: false);
            var __workflow_bodytargetStartminute = WorkflowExpression.Compile(bodytargetStartminute, nameof(bodytargetStartminute), required: false);
            var __workflow_bodytargetEndhour = WorkflowExpression.Compile(bodytargetEndhour, nameof(bodytargetEndhour), required: false);
            var __workflow_bodytargetEndminute = WorkflowExpression.Compile(bodytargetEndminute, nameof(bodytargetEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodynextTargetDate = WorkflowExpression.Compile(bodynextTargetDate, nameof(bodynextTargetDate), required: false);
            var __workflow_bodyconnectTo = WorkflowExpression.Compile(bodyconnectTo, nameof(bodyconnectTo), required: false);
            var __workflow_bodybenefitId = WorkflowExpression.Compile(bodybenefitId, nameof(bodybenefitId), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodymailingId = WorkflowExpression.Compile(bodymailingId, nameof(bodymailingId), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            var __workflow_bodyparticipants = WorkflowExpression.Compile(bodyparticipants, nameof(bodyparticipants), required: false);
            var __workflow_bodyassociatedPlans = WorkflowExpression.Compile(bodyassociatedPlans, nameof(bodyassociatedPlans), required: false);
            return new DeferredBodyAction<PrsmgCreatedStewardshipPlanStep, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crm-prsmg/stewardshipplansteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stewardship_plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                bodypropCount++;
                body["target_date"] = ExpressionConverter.ConvertO(__workflow_bodytargetDate);
                if (__workflow_bodylocked != null)
                {
                    body["date_locked"] = ExpressionConverter.ConvertO(__workflow_bodylocked);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                var targetStartTimeObject = new JObject();
                var targetStartTimeObjectpropCount = 0;
                if (__workflow_bodytargetStarthour != null)
                {
                    targetStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodytargetStarthour);
                    targetStartTimeObjectpropCount++;
                }

                if (__workflow_bodytargetStartminute != null)
                {
                    targetStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodytargetStartminute);
                    targetStartTimeObjectpropCount++;
                }

                if (targetStartTimeObjectpropCount > 0)
                {
                    body["target_start_time"] = targetStartTimeObject;
                    bodypropCount++;
                }

                var targetEndTimeObject = new JObject();
                var targetEndTimeObjectpropCount = 0;
                if (__workflow_bodytargetEndhour != null)
                {
                    targetEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodytargetEndhour);
                    targetEndTimeObjectpropCount++;
                }

                if (__workflow_bodytargetEndminute != null)
                {
                    targetEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodytargetEndminute);
                    targetEndTimeObjectpropCount++;
                }

                if (targetEndTimeObjectpropCount > 0)
                {
                    body["target_end_time"] = targetEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status_code"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["contact_method"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["recurs"] = ExpressionConverter.ConvertO(__workflow_bodyfrequency);
                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodynextTargetDate != null)
                {
                    body["next_target_date"] = ExpressionConverter.ConvertO(__workflow_bodynextTargetDate);
                    bodypropCount++;
                }

                if (__workflow_bodyconnectTo != null)
                {
                    body["link_type_code"] = ExpressionConverter.ConvertO(__workflow_bodyconnectTo);
                    bodypropCount++;
                }

                if (__workflow_bodybenefitId != null)
                {
                    body["benefit_id"] = ExpressionConverter.ConvertO(__workflow_bodybenefitId);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                if (__workflow_bodymailingId != null)
                {
                    body["mailing_id"] = ExpressionConverter.ConvertO(__workflow_bodymailingId);
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyparticipants != null)
                {
                    body["step_participants"] = ExpressionConverter.ConvertO(__workflow_bodyparticipants);
                    bodypropCount++;
                }

                if (__workflow_bodyassociatedPlans != null)
                {
                    body["associated_plans"] = ExpressionConverter.ConvertO(__workflow_bodyassociatedPlans);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditStewardshipPlanStep(Expression<Func<string>> stepId, Expression<Func<string>> bodyobjective = null, Expression<Func<string>> bodytargetDate = null, Expression<Func<bool>> bodylocked = null, Expression<Func<bool>> bodyallDayEvent = null, Expression<Func<int>> bodytargetStarthour = null, Expression<Func<int>> bodytargetStartminute = null, Expression<Func<int>> bodytargetEndhour = null, Expression<Func<int>> bodytargetEndminute = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyassignedTo = null, Expression<Func<string>> bodycontactMethod = null, Expression<Func<bodyfrequencyInput>> bodyfrequency = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodynextTargetDate = null, Expression<Func<bodyconnectToInput>> bodyconnectTo = null, Expression<Func<string>> bodybenefitId = null, Expression<Func<string>> bodyeventId = null, Expression<Func<string>> bodymailingId = null, Expression<Func<string>> bodyactualDate = null, Expression<Func<int>> bodyactualStarthour = null, Expression<Func<int>> bodyactualStartminute = null, Expression<Func<int>> bodyactualEndhour = null, Expression<Func<int>> bodyactualEndminute = null)
        {
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_bodyobjective = WorkflowExpression.Compile(bodyobjective, nameof(bodyobjective), required: false);
            var __workflow_bodytargetDate = WorkflowExpression.Compile(bodytargetDate, nameof(bodytargetDate), required: false);
            var __workflow_bodylocked = WorkflowExpression.Compile(bodylocked, nameof(bodylocked), required: false);
            var __workflow_bodyallDayEvent = WorkflowExpression.Compile(bodyallDayEvent, nameof(bodyallDayEvent), required: false);
            var __workflow_bodytargetStarthour = WorkflowExpression.Compile(bodytargetStarthour, nameof(bodytargetStarthour), required: false);
            var __workflow_bodytargetStartminute = WorkflowExpression.Compile(bodytargetStartminute, nameof(bodytargetStartminute), required: false);
            var __workflow_bodytargetEndhour = WorkflowExpression.Compile(bodytargetEndhour, nameof(bodytargetEndhour), required: false);
            var __workflow_bodytargetEndminute = WorkflowExpression.Compile(bodytargetEndminute, nameof(bodytargetEndminute), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
            var __workflow_bodycontactMethod = WorkflowExpression.Compile(bodycontactMethod, nameof(bodycontactMethod), required: false);
            var __workflow_bodyfrequency = WorkflowExpression.Compile(bodyfrequency, nameof(bodyfrequency), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodynextTargetDate = WorkflowExpression.Compile(bodynextTargetDate, nameof(bodynextTargetDate), required: false);
            var __workflow_bodyconnectTo = WorkflowExpression.Compile(bodyconnectTo, nameof(bodyconnectTo), required: false);
            var __workflow_bodybenefitId = WorkflowExpression.Compile(bodybenefitId, nameof(bodybenefitId), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodymailingId = WorkflowExpression.Compile(bodymailingId, nameof(bodymailingId), required: false);
            var __workflow_bodyactualDate = WorkflowExpression.Compile(bodyactualDate, nameof(bodyactualDate), required: false);
            var __workflow_bodyactualStarthour = WorkflowExpression.Compile(bodyactualStarthour, nameof(bodyactualStarthour), required: false);
            var __workflow_bodyactualStartminute = WorkflowExpression.Compile(bodyactualStartminute, nameof(bodyactualStartminute), required: false);
            var __workflow_bodyactualEndhour = WorkflowExpression.Compile(bodyactualEndhour, nameof(bodyactualEndhour), required: false);
            var __workflow_bodyactualEndminute = WorkflowExpression.Compile(bodyactualEndminute, nameof(bodyactualEndminute), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyobjective != null)
                {
                    body["objective"] = ExpressionConverter.ConvertO(__workflow_bodyobjective);
                    bodypropCount++;
                }

                if (__workflow_bodytargetDate != null)
                {
                    body["target_date"] = ExpressionConverter.ConvertO(__workflow_bodytargetDate);
                    bodypropCount++;
                }

                if (__workflow_bodylocked != null)
                {
                    body["date_locked"] = ExpressionConverter.ConvertO(__workflow_bodylocked);
                    bodypropCount++;
                }

                if (__workflow_bodyallDayEvent != null)
                {
                    body["all_day_event"] = ExpressionConverter.ConvertO(__workflow_bodyallDayEvent);
                    bodypropCount++;
                }

                var targetStartTimeObject = new JObject();
                var targetStartTimeObjectpropCount = 0;
                if (__workflow_bodytargetStarthour != null)
                {
                    targetStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodytargetStarthour);
                    targetStartTimeObjectpropCount++;
                }

                if (__workflow_bodytargetStartminute != null)
                {
                    targetStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodytargetStartminute);
                    targetStartTimeObjectpropCount++;
                }

                if (targetStartTimeObjectpropCount > 0)
                {
                    body["target_start_time"] = targetStartTimeObject;
                    bodypropCount++;
                }

                var targetEndTimeObject = new JObject();
                var targetEndTimeObjectpropCount = 0;
                if (__workflow_bodytargetEndhour != null)
                {
                    targetEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodytargetEndhour);
                    targetEndTimeObjectpropCount++;
                }

                if (__workflow_bodytargetEndminute != null)
                {
                    targetEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodytargetEndminute);
                    targetEndTimeObjectpropCount++;
                }

                if (targetEndTimeObjectpropCount > 0)
                {
                    body["target_end_time"] = targetEndTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone_entry"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTo != null)
                {
                    body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (__workflow_bodycontactMethod != null)
                {
                    body["contact_method"] = ExpressionConverter.ConvertO(__workflow_bodycontactMethod);
                    bodypropCount++;
                }

                if (__workflow_bodyfrequency != null)
                {
                    body["recurs"] = ExpressionConverter.ConvertO(__workflow_bodyfrequency);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodynextTargetDate != null)
                {
                    body["next_target_date"] = ExpressionConverter.ConvertO(__workflow_bodynextTargetDate);
                    bodypropCount++;
                }

                if (__workflow_bodyconnectTo != null)
                {
                    body["link_type"] = ExpressionConverter.ConvertO(__workflow_bodyconnectTo);
                    bodypropCount++;
                }

                if (__workflow_bodybenefitId != null)
                {
                    body["benefit_id"] = ExpressionConverter.ConvertO(__workflow_bodybenefitId);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                if (__workflow_bodymailingId != null)
                {
                    body["mailing_id"] = ExpressionConverter.ConvertO(__workflow_bodymailingId);
                    bodypropCount++;
                }

                if (__workflow_bodyactualDate != null)
                {
                    body["actual_date"] = ExpressionConverter.ConvertO(__workflow_bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (__workflow_bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (__workflow_bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualStartminute);
                    actualStartTimeObjectpropCount++;
                }

                if (actualStartTimeObjectpropCount > 0)
                {
                    body["actual_start_time"] = actualStartTimeObject;
                    bodypropCount++;
                }

                var actualEndTimeObject = new JObject();
                var actualEndTimeObjectpropCount = 0;
                if (__workflow_bodyactualEndhour != null)
                {
                    actualEndTimeObject["hour"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (__workflow_bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = ExpressionConverter.ConvertO(__workflow_bodyactualEndminute);
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

    public class PrsmgCreatedProspectOpportunity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class PrsmgCreatedMajorGivingPlanStep
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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

    public class PrsmgCreatedStewardshipPlan
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyconnectToInput
    {
        Benefit,
        Event,
        Mailing
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