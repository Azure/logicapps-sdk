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
        public IBodyWorkflowAction<PrsmgCreatedUnplannedContactReport> CreateUnplannedContactReport([WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodyactualDate, [WorkflowExpression] Func<string> bodystage, [WorkflowExpression] Func<string> bodycontactMethod, [WorkflowExpression] Func<string> bodycomment, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<PrsmgNewUnplannedContactReportFundraiser[]> bodyfundraisers = null, [WorkflowExpression] Func<PrsmgNewUnplannedContactReportParticipant[]> bodyparticipants = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectcontactreports";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                if (bodyowner != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                bodypropCount++;
                body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["prospect_plan_status"] = SourceExpressionConverter.ConvertToken(bodystage);
                bodypropCount++;
                body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                bodypropCount++;
                body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodyfundraisers != null)
                {
                    body["additional_fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraisers);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedUnplannedContactReport>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectContactReport([WorkflowExpression] Func<string> contactReportId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodystage = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectcontactreports/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactReportId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjective != null)
                {
                    body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodystage != null)
                {
                    body["prospect_plan_status"] = SourceExpressionConverter.ConvertToken(bodystage);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectOpportunity> CreateProspectOpportunity([WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<double> bodyexpectedAskAmount = null, [WorkflowExpression] Func<string> bodyexpectedAskDate = null, [WorkflowExpression] Func<string> bodylikelihood = null, [WorkflowExpression] Func<double> bodyaskAmount = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyacceptedAmount = null, [WorkflowExpression] Func<string> bodyresponseDate = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodytransactionCurrency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectopportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodytype != null)
                {
                    body["opportunity_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyexpectedAskAmount != null)
                {
                    body["expected_ask_amount"] = SourceExpressionConverter.ConvertToken(bodyexpectedAskAmount);
                    bodypropCount++;
                }

                if (bodyexpectedAskDate != null)
                {
                    body["expected_ask_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedAskDate);
                    bodypropCount++;
                }

                if (bodylikelihood != null)
                {
                    body["likelihood_type_code"] = SourceExpressionConverter.ConvertToken(bodylikelihood);
                    bodypropCount++;
                }

                if (bodyaskAmount != null)
                {
                    body["ask_amount"] = SourceExpressionConverter.ConvertToken(bodyaskAmount);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                if (bodyacceptedAmount != null)
                {
                    body["accepted_amount"] = SourceExpressionConverter.ConvertToken(bodyacceptedAmount);
                    bodypropCount++;
                }

                if (bodyresponseDate != null)
                {
                    body["response_date"] = SourceExpressionConverter.ConvertToken(bodyresponseDate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodytransactionCurrency != null)
                {
                    body["transaction_currency"] = SourceExpressionConverter.ConvertToken(bodytransactionCurrency);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedProspectOpportunity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunitySearchResultCollection> SearchProspectOpportunities([WorkflowExpression] Func<string> keyname = null, [WorkflowExpression] Func<string> firstname = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<bool> exactmatchonly = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> askDate = null, [WorkflowExpression] Func<double> askAmount = null, [WorkflowExpression] Func<string> designationuserid = null, [WorkflowExpression] Func<bool> onlyProspects = null, [WorkflowExpression] Func<bool> onlyFundraisers = null, [WorkflowExpression] Func<bool> onlyStaff = null, [WorkflowExpression] Func<bool> onlyVolunteers = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includedeceased = null, [WorkflowExpression] Func<bool> includeinactive = null, [WorkflowExpression] Func<bool> checknickname = null, [WorkflowExpression] Func<bool> checkaliases = null, [WorkflowExpression] Func<bool> checkalternatelookupids = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectopportunities/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (keyname != null)
                    callPayload.Queries["keyname"] = SourceExpressionConverter.ConvertO(keyname);
                if (firstname != null)
                    callPayload.Queries["firstname"] = SourceExpressionConverter.ConvertO(firstname);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = SourceExpressionConverter.ConvertO(lookupId);
                if (exactmatchonly != null)
                    callPayload.Queries["exactmatchonly"] = SourceExpressionConverter.ConvertO(exactmatchonly);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (askDate != null)
                    callPayload.Queries["ask_date"] = SourceExpressionConverter.ConvertO(askDate);
                if (askAmount != null)
                    callPayload.Queries["ask_amount"] = SourceExpressionConverter.ConvertO(askAmount);
                if (designationuserid != null)
                    callPayload.Queries["designationuserid"] = SourceExpressionConverter.ConvertO(designationuserid);
                if (onlyProspects != null)
                    callPayload.Queries["only_prospects"] = SourceExpressionConverter.ConvertO(onlyProspects);
                if (onlyFundraisers != null)
                    callPayload.Queries["only_fundraisers"] = SourceExpressionConverter.ConvertO(onlyFundraisers);
                if (onlyStaff != null)
                    callPayload.Queries["only_staff"] = SourceExpressionConverter.ConvertO(onlyStaff);
                if (onlyVolunteers != null)
                    callPayload.Queries["only_volunteers"] = SourceExpressionConverter.ConvertO(onlyVolunteers);
                if (onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = SourceExpressionConverter.ConvertO(onlyPrimaryAddress);
                if (includedeceased != null)
                    callPayload.Queries["includedeceased"] = SourceExpressionConverter.ConvertO(includedeceased);
                if (includeinactive != null)
                    callPayload.Queries["includeinactive"] = SourceExpressionConverter.ConvertO(includeinactive);
                if (checknickname != null)
                    callPayload.Queries["checknickname"] = SourceExpressionConverter.ConvertO(checknickname);
                if (checkaliases != null)
                    callPayload.Queries["checkaliases"] = SourceExpressionConverter.ConvertO(checkaliases);
                if (checkalternatelookupids != null)
                    callPayload.Queries["checkalternatelookupids"] = SourceExpressionConverter.ConvertO(checkalternatelookupids);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgProspectOpportunitySearchResultCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectOpportunity> GetProspectOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgProspectOpportunity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspectOpportunity([WorkflowExpression] Func<string> opportunityId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<double> bodyexpectedAskAmount = null, [WorkflowExpression] Func<string> bodyexpectedAskDate = null, [WorkflowExpression] Func<string> bodylikelihood = null, [WorkflowExpression] Func<double> bodyaskAmount = null, [WorkflowExpression] Func<string> bodyaskDate = null, [WorkflowExpression] Func<double> bodyacceptedAmount = null, [WorkflowExpression] Func<string> bodyresponseDate = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodytransactionCurrency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["opportunity_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyexpectedAskAmount != null)
                {
                    body["expected_ask_amount"] = SourceExpressionConverter.ConvertToken(bodyexpectedAskAmount);
                    bodypropCount++;
                }

                if (bodyexpectedAskDate != null)
                {
                    body["expected_ask_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedAskDate);
                    bodypropCount++;
                }

                if (bodylikelihood != null)
                {
                    body["likelihood_type_code"] = SourceExpressionConverter.ConvertToken(bodylikelihood);
                    bodypropCount++;
                }

                if (bodyaskAmount != null)
                {
                    body["ask_amount"] = SourceExpressionConverter.ConvertToken(bodyaskAmount);
                    bodypropCount++;
                }

                if (bodyaskDate != null)
                {
                    body["ask_date"] = SourceExpressionConverter.ConvertToken(bodyaskDate);
                    bodypropCount++;
                }

                if (bodyacceptedAmount != null)
                {
                    body["accepted_amount"] = SourceExpressionConverter.ConvertToken(bodyacceptedAmount);
                    bodypropCount++;
                }

                if (bodyresponseDate != null)
                {
                    body["response_date"] = SourceExpressionConverter.ConvertToken(bodyresponseDate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodytransactionCurrency != null)
                {
                    body["transaction_currency"] = SourceExpressionConverter.ConvertToken(bodytransactionCurrency);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgPlanOpportunityCollection> ListPlanOpportunities([WorkflowExpression] Func<string> planId, [WorkflowExpression] Func<statusInput> status = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectopportunities/{0}/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgPlanOpportunityCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlan> CreateMajorGivingPlan([WorkflowExpression] Func<string> bodyprospectId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodynarrative = null, [WorkflowExpression] Func<string> bodyprimaryManagerId = null, [WorkflowExpression] Func<string> bodyprimaryStartDate = null, [WorkflowExpression] Func<string> bodysecondaryManagerId = null, [WorkflowExpression] Func<string> bodysecondaryStartDate = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanParticipant[]> bodyparticipants = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanSecondaryFundraiser[]> bodyfundraisers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_id"] = SourceExpressionConverter.ConvertToken(bodyprospectId);
                bodypropCount++;
                body["prospect_plan_name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["prospect_plan_type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodynarrative != null)
                {
                    body["narrative"] = SourceExpressionConverter.ConvertToken(bodynarrative);
                    bodypropCount++;
                }

                if (bodyprimaryManagerId != null)
                {
                    body["primary_manager_fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodyprimaryManagerId);
                    bodypropCount++;
                }

                if (bodyprimaryStartDate != null)
                {
                    body["primary_manager_date_from"] = SourceExpressionConverter.ConvertToken(bodyprimaryStartDate);
                    bodypropCount++;
                }

                if (bodysecondaryManagerId != null)
                {
                    body["secondary_manager_fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodysecondaryManagerId);
                    bodypropCount++;
                }

                if (bodysecondaryStartDate != null)
                {
                    body["secondary_manager_date_from"] = SourceExpressionConverter.ConvertToken(bodysecondaryStartDate);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["prospect_plan_participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodyfundraisers != null)
                {
                    body["secondary_fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraisers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedMajorGivingPlan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgMajorGivingPlan> GetMajorGivingPlan([WorkflowExpression] Func<string> planId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectplans/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgMajorGivingPlan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlan([WorkflowExpression] Func<string> planId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectplans/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSearchResultCollection> SearchProspects([WorkflowExpression] Func<string> keyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> addressBlock = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<bool> exactMatchOnly = null, [WorkflowExpression] Func<string> constituency = null, [WorkflowExpression] Func<bool> onlyProspects = null, [WorkflowExpression] Func<bool> onlyFundraisers = null, [WorkflowExpression] Func<bool> onlyStaff = null, [WorkflowExpression] Func<bool> onlyVolunteers = null, [WorkflowExpression] Func<bool> onlyPrimaryAddress = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<bool> fuzzySearchOnName = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospects/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (keyName != null)
                    callPayload.Queries["key_name"] = SourceExpressionConverter.ConvertO(keyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = SourceExpressionConverter.ConvertO(lookupId);
                if (phoneNumber != null)
                    callPayload.Queries["phone_number"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (addressBlock != null)
                    callPayload.Queries["address_block"] = SourceExpressionConverter.ConvertO(addressBlock);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (postCode != null)
                    callPayload.Queries["post_code"] = SourceExpressionConverter.ConvertO(postCode);
                if (exactMatchOnly != null)
                    callPayload.Queries["exact_match_only"] = SourceExpressionConverter.ConvertO(exactMatchOnly);
                if (constituency != null)
                    callPayload.Queries["constituency"] = SourceExpressionConverter.ConvertO(constituency);
                if (onlyProspects != null)
                    callPayload.Queries["only_prospects"] = SourceExpressionConverter.ConvertO(onlyProspects);
                if (onlyFundraisers != null)
                    callPayload.Queries["only_fundraisers"] = SourceExpressionConverter.ConvertO(onlyFundraisers);
                if (onlyStaff != null)
                    callPayload.Queries["only_staff"] = SourceExpressionConverter.ConvertO(onlyStaff);
                if (onlyVolunteers != null)
                    callPayload.Queries["only_volunteers"] = SourceExpressionConverter.ConvertO(onlyVolunteers);
                if (onlyPrimaryAddress != null)
                    callPayload.Queries["only_primary_address"] = SourceExpressionConverter.ConvertO(onlyPrimaryAddress);
                if (includeDeceased != null)
                    callPayload.Queries["include_deceased"] = SourceExpressionConverter.ConvertO(includeDeceased);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (fuzzySearchOnName != null)
                    callPayload.Queries["fuzzy_search_on_name"] = SourceExpressionConverter.ConvertO(fuzzySearchOnName);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgProspectSearchResultCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditProspect([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<string> bodystatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymanagerId != null)
                {
                    body["prospect_manager_fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["prospect_status"] = SourceExpressionConverter.ConvertToken(bodystatus);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteProspectOpportunity([WorkflowExpression] Func<string> opportunityId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectopportunities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectPlanCollection> ListProspectPlans([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactivePlans = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectplans", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactivePlans != null)
                    callPayload.Queries["include_inactive_plans"] = SourceExpressionConverter.ConvertO(includeInactivePlans);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgProspectPlanCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgProspectSummary> GetProspectSummary([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospects/{0}/prospectstatus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgProspectSummary>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedProspectConstituency> CreateProspectConstituency([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydateFrom = null, [WorkflowExpression] Func<string> bodydateTo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectsconstituency";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodydateFrom != null)
                {
                    body["date_from"] = SourceExpressionConverter.ConvertToken(bodydateFrom);
                    bodypropCount++;
                }

                if (bodydateTo != null)
                {
                    body["date_to"] = SourceExpressionConverter.ConvertToken(bodydateTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedProspectConstituency>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedMajorGivingPlanStep> CreateMajorGivingPlanStep([WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodyexpectedDate, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyotherLocation = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanStepFundraiser[]> bodyfundraisers = null, [WorkflowExpression] Func<PrsmgNewMajorGivingPlanStepParticipant[]> bodyparticipants = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/prospectsteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["prospect_plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                bodypropCount++;
                body["prospect_plan_status"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                bodypropCount++;
                body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                if (bodyowner != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedStartminute);
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
                    expectedEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyotherLocation != null)
                {
                    body["other_location"] = SourceExpressionConverter.ConvertToken(bodyotherLocation);
                    bodypropCount++;
                }

                if (bodyfundraisers != null)
                {
                    body["additional_fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraisers);
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedMajorGivingPlanStep>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteMajorGivingPlanStep([WorkflowExpression] Func<string> stepId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectsteps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditMajorGivingPlanStep([WorkflowExpression] Func<string> vProspectPlanId, [WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyexpectedDate = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodyexpectedStarthour = null, [WorkflowExpression] Func<int> bodyexpectedStartminute = null, [WorkflowExpression] Func<int> bodyexpectedEndhour = null, [WorkflowExpression] Func<int> bodyexpectedEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<string> bodyotherLocation = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/prospectsteps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v_prospect_plan_id"] = SourceExpressionConverter.ConvertO(vProspectPlanId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjective != null)
                {
                    body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["prospect_plan_status"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyexpectedDate != null)
                {
                    body["expected_date"] = SourceExpressionConverter.ConvertToken(bodyexpectedDate);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["interaction_type"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["interaction_category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["interaction_subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["is_all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                var expectedStartTimeObject = new JObject();
                var expectedStartTimeObjectpropCount = 0;
                if (bodyexpectedStarthour != null)
                {
                    expectedStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedStarthour);
                    expectedStartTimeObjectpropCount++;
                }

                if (bodyexpectedStartminute != null)
                {
                    expectedStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedStartminute);
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
                    expectedEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndhour);
                    expectedEndTimeObjectpropCount++;
                }

                if (bodyexpectedEndminute != null)
                {
                    expectedEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyexpectedEndminute);
                    expectedEndTimeObjectpropCount++;
                }

                if (expectedEndTimeObjectpropCount > 0)
                {
                    body["expected_end_time"] = expectedEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodyotherLocation != null)
                {
                    body["other_location"] = SourceExpressionConverter.ConvertToken(bodyotherLocation);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlan> CreateStewardshipPlan([WorkflowExpression] Func<string> bodyprospectId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysubtype = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodymanagerId = null, [WorkflowExpression] Func<string> bodymanagerStartDate = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanSteward[]> bodystewards = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/stewardshipplans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyprospectId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodytype != null)
                {
                    body["plan_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodysubtype != null)
                {
                    body["plan_sub_type_id"] = SourceExpressionConverter.ConvertToken(bodysubtype);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodymanagerId != null)
                {
                    body["manager_id"] = SourceExpressionConverter.ConvertToken(bodymanagerId);
                    bodypropCount++;
                }

                if (bodymanagerStartDate != null)
                {
                    body["manager_start_date"] = SourceExpressionConverter.ConvertToken(bodymanagerStartDate);
                    bodypropCount++;
                }

                if (bodystewards != null)
                {
                    body["stewards"] = SourceExpressionConverter.ConvertToken(bodystewards);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedStewardshipPlan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteStewardshipPlan([WorkflowExpression] Func<string> planId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplans/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(planId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IBodyWorkflowAction<PrsmgCreatedStewardshipPlanStep> CreateStewardshipPlanStep([WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> bodyobjective, [WorkflowExpression] Func<string> bodytargetDate, [WorkflowExpression] Func<bodyfrequencyInput> bodyfrequency, [WorkflowExpression] Func<bool> bodylocked = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodytargetStarthour = null, [WorkflowExpression] Func<int> bodytargetStartminute = null, [WorkflowExpression] Func<int> bodytargetEndhour = null, [WorkflowExpression] Func<int> bodytargetEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodynextTargetDate = null, [WorkflowExpression] Func<bodyconnectToInput> bodyconnectTo = null, [WorkflowExpression] Func<string> bodybenefitId = null, [WorkflowExpression] Func<string> bodyeventId = null, [WorkflowExpression] Func<string> bodymailingId = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanStepParticipant[]> bodyparticipants = null, [WorkflowExpression] Func<PrsmgNewStewardshipPlanStepAssociatedPlan[]> bodyassociatedPlans = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crm-prsmg/stewardshipplansteps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stewardship_plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                bodypropCount++;
                body["target_date"] = SourceExpressionConverter.ConvertToken(bodytargetDate);
                if (bodylocked != null)
                {
                    body["date_locked"] = SourceExpressionConverter.ConvertToken(bodylocked);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                var targetStartTimeObject = new JObject();
                var targetStartTimeObjectpropCount = 0;
                if (bodytargetStarthour != null)
                {
                    targetStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodytargetStarthour);
                    targetStartTimeObjectpropCount++;
                }

                if (bodytargetStartminute != null)
                {
                    targetStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodytargetStartminute);
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
                    targetEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodytargetEndhour);
                    targetEndTimeObjectpropCount++;
                }

                if (bodytargetEndminute != null)
                {
                    targetEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodytargetEndminute);
                    targetEndTimeObjectpropCount++;
                }

                if (targetEndTimeObjectpropCount > 0)
                {
                    body["target_end_time"] = targetEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status_code"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["contact_method"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["recurs"] = SourceExpressionConverter.Convert(bodyfrequency);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodynextTargetDate != null)
                {
                    body["next_target_date"] = SourceExpressionConverter.ConvertToken(bodynextTargetDate);
                    bodypropCount++;
                }

                if (bodyconnectTo != null)
                {
                    body["link_type_code"] = SourceExpressionConverter.Convert(bodyconnectTo);
                    bodypropCount++;
                }

                if (bodybenefitId != null)
                {
                    body["benefit_id"] = SourceExpressionConverter.ConvertToken(bodybenefitId);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodymailingId != null)
                {
                    body["mailing_id"] = SourceExpressionConverter.ConvertToken(bodymailingId);
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
                    actualEndTimeObjectpropCount++;
                }

                if (actualEndTimeObjectpropCount > 0)
                {
                    body["actual_end_time"] = actualEndTimeObject;
                    bodypropCount++;
                }

                if (bodyparticipants != null)
                {
                    body["step_participants"] = SourceExpressionConverter.ConvertToken(bodyparticipants);
                    bodypropCount++;
                }

                if (bodyassociatedPlans != null)
                {
                    body["associated_plans"] = SourceExpressionConverter.ConvertToken(bodyassociatedPlans);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PrsmgCreatedStewardshipPlanStep>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction DeleteStewardshipPlanStep([WorkflowExpression] Func<string> stepId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudcrmprospect")]
        public IWorkflowAction EditStewardshipPlanStep([WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<string> bodyobjective = null, [WorkflowExpression] Func<string> bodytargetDate = null, [WorkflowExpression] Func<bool> bodylocked = null, [WorkflowExpression] Func<bool> bodyallDayEvent = null, [WorkflowExpression] Func<int> bodytargetStarthour = null, [WorkflowExpression] Func<int> bodytargetStartminute = null, [WorkflowExpression] Func<int> bodytargetEndhour = null, [WorkflowExpression] Func<int> bodytargetEndminute = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyassignedTo = null, [WorkflowExpression] Func<string> bodycontactMethod = null, [WorkflowExpression] Func<bodyfrequencyInput> bodyfrequency = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodynextTargetDate = null, [WorkflowExpression] Func<bodyconnectToInput> bodyconnectTo = null, [WorkflowExpression] Func<string> bodybenefitId = null, [WorkflowExpression] Func<string> bodyeventId = null, [WorkflowExpression] Func<string> bodymailingId = null, [WorkflowExpression] Func<string> bodyactualDate = null, [WorkflowExpression] Func<int> bodyactualStarthour = null, [WorkflowExpression] Func<int> bodyactualStartminute = null, [WorkflowExpression] Func<int> bodyactualEndhour = null, [WorkflowExpression] Func<int> bodyactualEndminute = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/crm-prsmg/stewardshipplansteps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjective != null)
                {
                    body["objective"] = SourceExpressionConverter.ConvertToken(bodyobjective);
                    bodypropCount++;
                }

                if (bodytargetDate != null)
                {
                    body["target_date"] = SourceExpressionConverter.ConvertToken(bodytargetDate);
                    bodypropCount++;
                }

                if (bodylocked != null)
                {
                    body["date_locked"] = SourceExpressionConverter.ConvertToken(bodylocked);
                    bodypropCount++;
                }

                if (bodyallDayEvent != null)
                {
                    body["all_day_event"] = SourceExpressionConverter.ConvertToken(bodyallDayEvent);
                    bodypropCount++;
                }

                var targetStartTimeObject = new JObject();
                var targetStartTimeObjectpropCount = 0;
                if (bodytargetStarthour != null)
                {
                    targetStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodytargetStarthour);
                    targetStartTimeObjectpropCount++;
                }

                if (bodytargetStartminute != null)
                {
                    targetStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodytargetStartminute);
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
                    targetEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodytargetEndhour);
                    targetEndTimeObjectpropCount++;
                }

                if (bodytargetEndminute != null)
                {
                    targetEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodytargetEndminute);
                    targetEndTimeObjectpropCount++;
                }

                if (targetEndTimeObjectpropCount > 0)
                {
                    body["target_end_time"] = targetEndTimeObject;
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone_entry"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyassignedTo != null)
                {
                    body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodycontactMethod != null)
                {
                    body["contact_method"] = SourceExpressionConverter.ConvertToken(bodycontactMethod);
                    bodypropCount++;
                }

                if (bodyfrequency != null)
                {
                    body["recurs"] = SourceExpressionConverter.Convert(bodyfrequency);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodynextTargetDate != null)
                {
                    body["next_target_date"] = SourceExpressionConverter.ConvertToken(bodynextTargetDate);
                    bodypropCount++;
                }

                if (bodyconnectTo != null)
                {
                    body["link_type"] = SourceExpressionConverter.Convert(bodyconnectTo);
                    bodypropCount++;
                }

                if (bodybenefitId != null)
                {
                    body["benefit_id"] = SourceExpressionConverter.ConvertToken(bodybenefitId);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                if (bodymailingId != null)
                {
                    body["mailing_id"] = SourceExpressionConverter.ConvertToken(bodymailingId);
                    bodypropCount++;
                }

                if (bodyactualDate != null)
                {
                    body["actual_date"] = SourceExpressionConverter.ConvertToken(bodyactualDate);
                    bodypropCount++;
                }

                var actualStartTimeObject = new JObject();
                var actualStartTimeObjectpropCount = 0;
                if (bodyactualStarthour != null)
                {
                    actualStartTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualStarthour);
                    actualStartTimeObjectpropCount++;
                }

                if (bodyactualStartminute != null)
                {
                    actualStartTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualStartminute);
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
                    actualEndTimeObject["hour"] = SourceExpressionConverter.ConvertToken(bodyactualEndhour);
                    actualEndTimeObjectpropCount++;
                }

                if (bodyactualEndminute != null)
                {
                    actualEndTimeObject["minute"] = SourceExpressionConverter.ConvertToken(bodyactualEndminute);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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