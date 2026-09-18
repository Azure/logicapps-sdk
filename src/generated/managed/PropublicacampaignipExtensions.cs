//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Propublicacampaignip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PropublicacampaignipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CandidateSearchResponse> CandidateSearch([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/search.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<CandidateSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CandidateGetResponse> CandidateGet([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CandidateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CandidateTopFinancialResponse> CandidateTopFinancial([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<categoryInput> category)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(category, nameof(category), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/leaders/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(category, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CandidateTopFinancialResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CandidateStateResponse> CandidateState([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> state)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(state, nameof(state), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/races/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(state, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CandidateStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CandidateRecentResponse> CandidateRecent([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/new.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CandidateRecentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ContributionLateRecentResponse> ContributionLateRecent([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contributions/48hour.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContributionLateRecentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ContributionLateCandidateResponse> ContributionLateCandidate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/{1}/48hour.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContributionLateCandidateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ContributionLateCommitteeResponse> ContributionLateCommittee([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/48hour.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContributionLateCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ContributionLateDateResponse> ContributionLateDate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(month, nameof(month), required: true);
            SourceExpression.Validate(day, nameof(day), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/contributions/48hour/{1}/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContributionLateDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeSearchResponse> CommitteeSearch([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> query = null)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(query, nameof(query), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/search.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeGetResponse> CommitteeGet([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeRecentResponse> CommitteeRecent([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/new.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeRecentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeRecentPACsResponse> CommitteeRecentPACs([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/superpacs.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeRecentPACsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeFilingResponse> CommitteeFiling([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/filings.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeFilingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommitteeLeadershipResponse> CommitteeLeadership([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/leadership.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommitteeLeadershipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<FilingSearchResponse> FilingSearch([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/filings/search.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilingSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<FilingDateResponse> FilingDate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(month, nameof(month), required: true);
            SourceExpression.Validate(day, nameof(day), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/filings/{1}/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilingDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<FilingFormTypeResponse> FilingFormType([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/filings/types.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilingFormTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<FilingTypeResponse> FilingType([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> formTypeId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(formTypeId, nameof(formTypeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/filings/types/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formTypeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilingTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<FilingSummaryResponse> FilingSummary([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> filingId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(filingId, nameof(filingId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/filings/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filingId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilingSummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureRecentResponse> ExpenditureRecent([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/independent_expenditures.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureRecentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureDateResponse> ExpenditureDate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(month, nameof(month), required: true);
            SourceExpression.Validate(day, nameof(day), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/independent_expenditures/{1}/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureCommitteeResponse> ExpenditureCommittee([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/independent_expenditures.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureCandidateResponse> ExpenditureCandidate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/candidates/{1}/independent_expenditures.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureCandidateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditurePresResponse> ExpenditurePres([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/president/independent_expenditures.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditurePresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureOfficeResponse> ExpenditureOffice([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> office)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(office, nameof(office), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/independent_expenditures/race_totals/{1}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(office, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureOfficeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<ExpenditureRaceCommitteeResponse> ExpenditureRaceCommittee([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/independent_expenditures/races.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpenditureRaceCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommunicationRecentResponse> CommunicationRecent([WorkflowExpression] Func<string> cycle)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/electioneering_communications.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommunicationRecentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommunicationCommitteeResponse> CommunicationCommittee([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/electioneering_communications.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommunicationCommitteeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<CommunicationDateResponse> CommunicationDate([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> year, [WorkflowExpression] Func<string> month, [WorkflowExpression] Func<string> day)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(year, nameof(year), required: true);
            SourceExpression.Validate(month, nameof(month), required: true);
            SourceExpression.Validate(day, nameof(day), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/electioneering_communications/{1}/{2}/{3}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(year, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(month, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(day, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommunicationDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "propublicacampaignip")]
        public IBodyWorkflowAction<BundlerCommitteeResponse> BundlerCommittee([WorkflowExpression] Func<string> cycle, [WorkflowExpression] Func<string> fecId)
        {
            SourceExpression.Validate(cycle, nameof(cycle), required: true);
            SourceExpression.Validate(fecId, nameof(fecId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/committees/{1}/lobbyist_bundlers.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cycle, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fecId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BundlerCommitteeResponse>(BuildSourceInput);
        }
    }

    public class PropublicacampaignipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CandidateSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public CandidateSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CandidateSearchResponseResultsTypeItem
    {
        [JsonProperty("candidate")]
        public CandidateSearchResponseResultsTypeItemCandidateType Candidate { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }
    }

    public class CandidateSearchResponseResultsTypeItemCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }
    }

    public class CandidateGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public CandidateGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class CandidateGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("mailing_address")]
        public string MailingAddress { get; set; }

        [JsonProperty("mailing_city")]
        public string MailingCity { get; set; }

        [JsonProperty("mailing_state")]
        public string MailingState { get; set; }

        [JsonProperty("mailing_zip")]
        public string MailingZip { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_receipts")]
        public double TotalReceipts { get; set; }

        [JsonProperty("total_from_individuals")]
        public double TotalFromIndividuals { get; set; }

        [JsonProperty("total_from_individuals_itemized")]
        public int TotalFromIndividualsItemized { get; set; }

        [JsonProperty("total_from_individuals_unitemized")]
        public int TotalFromIndividualsUnitemized { get; set; }

        [JsonProperty("percent_unitemized")]
        public double PercentUnitemized { get; set; }

        [JsonProperty("total_from_pacs")]
        public double TotalFromPacs { get; set; }

        [JsonProperty("total_contributions")]
        public double TotalContributions { get; set; }

        [JsonProperty("candidate_loans")]
        public int CandidateLoans { get; set; }

        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        [JsonProperty("total_disbursements")]
        public double TotalDisbursements { get; set; }

        [JsonProperty("begin_cash")]
        public double BeginCash { get; set; }

        [JsonProperty("end_cash")]
        public double EndCash { get; set; }

        [JsonProperty("total_refunds")]
        public double TotalRefunds { get; set; }

        [JsonProperty("individual_refunds")]
        public double IndividualRefunds { get; set; }

        [JsonProperty("pac_refunds")]
        public int PacRefunds { get; set; }

        [JsonProperty("debts_owed")]
        public int DebtsOwed { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("independent_expenditures")]
        public int IndependentExpenditures { get; set; }

        [JsonProperty("coordinated_expenditures")]
        public int CoordinatedExpenditures { get; set; }

        [JsonProperty("other_cycles")]
        public int[] OtherCycles { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("google_id")]
        public string GoogleId { get; set; }

        [JsonProperty("twitter_user")]
        public string TwitterUser { get; set; }
    }

    public class CandidateTopFinancialResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("results")]
        public CandidateTopFinancialResponseResultsTypeItem[] Results { get; set; }
    }

    public class CandidateTopFinancialResponseResultsTypeItem
    {
        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total_from_individuals")]
        public double TotalFromIndividuals { get; set; }

        [JsonProperty("total_from_pacs")]
        public int TotalFromPacs { get; set; }

        [JsonProperty("total_contributions")]
        public double TotalContributions { get; set; }

        [JsonProperty("candidate_loans")]
        public double CandidateLoans { get; set; }

        [JsonProperty("total_disbursements")]
        public double TotalDisbursements { get; set; }

        [JsonProperty("begin_cash")]
        public double BeginCash { get; set; }

        [JsonProperty("end_cash")]
        public double EndCash { get; set; }

        [JsonProperty("total_refunds")]
        public int TotalRefunds { get; set; }

        [JsonProperty("debts_owed")]
        public int DebtsOwed { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }
    }

    public enum categoryInput
    {
        [EnumMember(Value = "candidate-loan")]
        CandidateLoan,
        [EnumMember(Value = "contribution-total")]
        ContributionTotal,
        [EnumMember(Value = "debts-owed")]
        DebtsOwed,
        [EnumMember(Value = "disbursements-total")]
        DisbursementsTotal,
        [EnumMember(Value = "end-card")]
        EndCard,
        [EnumMember(Value = "individual-total")]
        IndividualTotal,
        [EnumMember(Value = "pac-total")]
        PacTotal,
        [EnumMember(Value = "receipts-total")]
        ReceiptsTotal,
        [EnumMember(Value = "refund-total")]
        RefundTotal
    }

    public class CandidateStateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("results")]
        public CandidateStateResponseResultsTypeItem[] Results { get; set; }
    }

    public class CandidateStateResponseResultsTypeItem
    {
        [JsonProperty("candidate")]
        public CandidateStateResponseResultsTypeItemCandidateType Candidate { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }
    }

    public class CandidateStateResponseResultsTypeItemCandidateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }
    }

    public class CandidateRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("results")]
        public CandidateRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class CandidateRecentResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("mailing_city")]
        public string MailingCity { get; set; }

        [JsonProperty("mailing_state")]
        public string MailingState { get; set; }

        [JsonProperty("mailing_zip")]
        public string MailingZip { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }
    }

    public class ContributionLateRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ContributionLateRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class ContributionLateRecentResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_filing_id")]
        public int FecFilingId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("contributor_fec_id")]
        public string ContributorFecId { get; set; }

        [JsonProperty("contributor_organization_name")]
        public string ContributorOrganizationName { get; set; }

        [JsonProperty("contributor_prefix")]
        public string ContributorPrefix { get; set; }

        [JsonProperty("contributor_first_name")]
        public string ContributorFirstName { get; set; }

        [JsonProperty("contributor_middle_name")]
        public string ContributorMiddleName { get; set; }

        [JsonProperty("contributor_last_name")]
        public string ContributorLastName { get; set; }

        [JsonProperty("contributor_suffix")]
        public string ContributorSuffix { get; set; }

        [JsonProperty("contributor_street_1")]
        public string ContributorStreet1 { get; set; }

        [JsonProperty("contributor_street_2")]
        public string ContributorStreet2 { get; set; }

        [JsonProperty("contributor_city")]
        public string ContributorCity { get; set; }

        [JsonProperty("contributor_state")]
        public string ContributorState { get; set; }

        [JsonProperty("contributor_zip")]
        public string ContributorZip { get; set; }

        [JsonProperty("contributor_employer")]
        public string ContributorEmployer { get; set; }

        [JsonProperty("contributor_occupation")]
        public string ContributorOccupation { get; set; }

        [JsonProperty("contribution_date")]
        public string ContributionDate { get; set; }

        [JsonProperty("contribution_amount")]
        public string ContributionAmount { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("office_state")]
        public string OfficeState { get; set; }
    }

    public class ContributionLateCandidateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ContributionLateCandidateResponseResultsTypeItem[] Results { get; set; }
    }

    public class ContributionLateCandidateResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_filing_id")]
        public int FecFilingId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("contributor_fec_id")]
        public string ContributorFecId { get; set; }

        [JsonProperty("contributor_organization_name")]
        public string ContributorOrganizationName { get; set; }

        [JsonProperty("contributor_prefix")]
        public string ContributorPrefix { get; set; }

        [JsonProperty("contributor_first_name")]
        public string ContributorFirstName { get; set; }

        [JsonProperty("contributor_middle_name")]
        public string ContributorMiddleName { get; set; }

        [JsonProperty("contributor_last_name")]
        public string ContributorLastName { get; set; }

        [JsonProperty("contributor_suffix")]
        public string ContributorSuffix { get; set; }

        [JsonProperty("contributor_street_1")]
        public string ContributorStreet1 { get; set; }

        [JsonProperty("contributor_street_2")]
        public string ContributorStreet2 { get; set; }

        [JsonProperty("contributor_city")]
        public string ContributorCity { get; set; }

        [JsonProperty("contributor_state")]
        public string ContributorState { get; set; }

        [JsonProperty("contributor_zip")]
        public string ContributorZip { get; set; }

        [JsonProperty("contributor_employer")]
        public string ContributorEmployer { get; set; }

        [JsonProperty("contributor_occupation")]
        public string ContributorOccupation { get; set; }

        [JsonProperty("contribution_date")]
        public string ContributionDate { get; set; }

        [JsonProperty("contribution_amount")]
        public string ContributionAmount { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("office_state")]
        public string OfficeState { get; set; }
    }

    public class ContributionLateCommitteeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ContributionLateCommitteeResponseResultsTypeItem[] Results { get; set; }
    }

    public class ContributionLateCommitteeResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_filing_id")]
        public int FecFilingId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("contributor_fec_id")]
        public string ContributorFecId { get; set; }

        [JsonProperty("contributor_organization_name")]
        public string ContributorOrganizationName { get; set; }

        [JsonProperty("contributor_prefix")]
        public string ContributorPrefix { get; set; }

        [JsonProperty("contributor_first_name")]
        public string ContributorFirstName { get; set; }

        [JsonProperty("contributor_middle_name")]
        public string ContributorMiddleName { get; set; }

        [JsonProperty("contributor_last_name")]
        public string ContributorLastName { get; set; }

        [JsonProperty("contributor_suffix")]
        public string ContributorSuffix { get; set; }

        [JsonProperty("contributor_street_1")]
        public string ContributorStreet1 { get; set; }

        [JsonProperty("contributor_street_2")]
        public string ContributorStreet2 { get; set; }

        [JsonProperty("contributor_city")]
        public string ContributorCity { get; set; }

        [JsonProperty("contributor_state")]
        public string ContributorState { get; set; }

        [JsonProperty("contributor_zip")]
        public string ContributorZip { get; set; }

        [JsonProperty("contributor_employer")]
        public string ContributorEmployer { get; set; }

        [JsonProperty("contributor_occupation")]
        public string ContributorOccupation { get; set; }

        [JsonProperty("contribution_date")]
        public string ContributionDate { get; set; }

        [JsonProperty("contribution_amount")]
        public string ContributionAmount { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("office_state")]
        public string OfficeState { get; set; }
    }

    public class ContributionLateDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ContributionLateDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class ContributionLateDateResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_filing_id")]
        public int FecFilingId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("contributor_fec_id")]
        public string ContributorFecId { get; set; }

        [JsonProperty("contributor_organization_name")]
        public string ContributorOrganizationName { get; set; }

        [JsonProperty("contributor_prefix")]
        public string ContributorPrefix { get; set; }

        [JsonProperty("contributor_first_name")]
        public string ContributorFirstName { get; set; }

        [JsonProperty("contributor_middle_name")]
        public string ContributorMiddleName { get; set; }

        [JsonProperty("contributor_last_name")]
        public string ContributorLastName { get; set; }

        [JsonProperty("contributor_suffix")]
        public string ContributorSuffix { get; set; }

        [JsonProperty("contributor_street_1")]
        public string ContributorStreet1 { get; set; }

        [JsonProperty("contributor_street_2")]
        public string ContributorStreet2 { get; set; }

        [JsonProperty("contributor_city")]
        public string ContributorCity { get; set; }

        [JsonProperty("contributor_state")]
        public string ContributorState { get; set; }

        [JsonProperty("contributor_zip")]
        public string ContributorZip { get; set; }

        [JsonProperty("contributor_employer")]
        public string ContributorEmployer { get; set; }

        [JsonProperty("contributor_occupation")]
        public string ContributorOccupation { get; set; }

        [JsonProperty("contribution_date")]
        public string ContributionDate { get; set; }

        [JsonProperty("contribution_amount")]
        public string ContributionAmount { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("office_state")]
        public string OfficeState { get; set; }
    }

    public class CommitteeSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public CommitteeSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeSearchResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("treasurer")]
        public string Treasurer { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("leadership")]
        public bool Leadership { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }
    }

    public class CommitteeGetResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("results")]
        public CommitteeGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("treasurer")]
        public string Treasurer { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("total_receipts")]
        public double TotalReceipts { get; set; }

        [JsonProperty("total_from_individuals")]
        public double TotalFromIndividuals { get; set; }

        [JsonProperty("total_from_pacs")]
        public int TotalFromPacs { get; set; }

        [JsonProperty("total_contributions")]
        public double TotalContributions { get; set; }

        [JsonProperty("total_disbursements")]
        public double TotalDisbursements { get; set; }

        [JsonProperty("begin_cash")]
        public double BeginCash { get; set; }

        [JsonProperty("end_cash")]
        public double EndCash { get; set; }

        [JsonProperty("total_refunds")]
        public int TotalRefunds { get; set; }

        [JsonProperty("display_type")]
        public string DisplayType { get; set; }

        [JsonProperty("debts_owed")]
        public double DebtsOwed { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("total_independent_expenditures")]
        public int TotalIndependentExpenditures { get; set; }

        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("leadership")]
        public bool Leadership { get; set; }

        [JsonProperty("super_pac")]
        public bool SuperPac { get; set; }

        [JsonProperty("total_candidate_contributions")]
        public int TotalCandidateContributions { get; set; }

        [JsonProperty("transfers_in")]
        public int TransfersIn { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("filing_frequency")]
        public string FilingFrequency { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("interest_group")]
        public string InterestGroup { get; set; }

        [JsonProperty("total_coordinated_expenditures")]
        public string TotalCoordinatedExpenditures { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("next_filing_date")]
        public string NextFilingDate { get; set; }

        [JsonProperty("other_cycles")]
        public int[] OtherCycles { get; set; }
    }

    public class CommitteeRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("results")]
        public CommitteeRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeRecentResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("treasurer")]
        public string Treasurer { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("leadership")]
        public bool Leadership { get; set; }

        [JsonProperty("super_pac")]
        public bool SuperPac { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("filing_frequency")]
        public string FilingFrequency { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("interest_group")]
        public string InterestGroup { get; set; }

        [JsonProperty("receipt_date")]
        public string ReceiptDate { get; set; }
    }

    public class CommitteeRecentPACsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public CommitteeRecentPACsResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeRecentPACsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("treasurer")]
        public string Treasurer { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("leadership")]
        public bool Leadership { get; set; }

        [JsonProperty("super_pac")]
        public bool SuperPac { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("filing_frequency")]
        public string FilingFrequency { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("interest_group")]
        public string InterestGroup { get; set; }
    }

    public class CommitteeFilingResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public CommitteeFilingResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeFilingResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("report_title")]
        public string ReportTitle { get; set; }

        [JsonProperty("report_period")]
        public string ReportPeriod { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("paper")]
        public bool Paper { get; set; }

        [JsonProperty("amended")]
        public bool Amended { get; set; }

        [JsonProperty("amended_uri")]
        public string AmendedUri { get; set; }

        [JsonProperty("is_amendment")]
        public string IsAmendment { get; set; }

        [JsonProperty("original_filing")]
        public string OriginalFiling { get; set; }

        [JsonProperty("original_uri")]
        public string OriginalUri { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("contributions_total")]
        public double ContributionsTotal { get; set; }

        [JsonProperty("cash_on_hand")]
        public double CashOnHand { get; set; }

        [JsonProperty("disbursements_total")]
        public double DisbursementsTotal { get; set; }

        [JsonProperty("receipts_total")]
        public double ReceiptsTotal { get; set; }
    }

    public class CommitteeLeadershipResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public CommitteeLeadershipResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeLeadershipResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("relative_uri")]
        public string RelativeUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("treasurer")]
        public string Treasurer { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("candidate")]
        public string Candidate { get; set; }

        [JsonProperty("leadership")]
        public bool Leadership { get; set; }

        [JsonProperty("super_pac")]
        public bool SuperPac { get; set; }

        [JsonProperty("sponsor_name")]
        public string SponsorName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("filing_frequency")]
        public string FilingFrequency { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("interest_group")]
        public string InterestGroup { get; set; }
    }

    public class FilingSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public FilingSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class FilingSearchResponseResultsTypeItem
    {
        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("report_title")]
        public string ReportTitle { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amended")]
        public bool Amended { get; set; }

        [JsonProperty("amended_uri")]
        public string AmendedUri { get; set; }

        [JsonProperty("is_amendment")]
        public string IsAmendment { get; set; }

        [JsonProperty("report_period")]
        public string ReportPeriod { get; set; }

        [JsonProperty("original_filing")]
        public string OriginalFiling { get; set; }

        [JsonProperty("original_uri")]
        public string OriginalUri { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("contributions_total")]
        public string ContributionsTotal { get; set; }

        [JsonProperty("cash_on_hand")]
        public string CashOnHand { get; set; }

        [JsonProperty("disbursements_total")]
        public string DisbursementsTotal { get; set; }

        [JsonProperty("receipts_total")]
        public string ReceiptsTotal { get; set; }

        [JsonProperty("loans_total")]
        public string LoansTotal { get; set; }

        [JsonProperty("debts_total")]
        public string DebtsTotal { get; set; }
    }

    public class FilingDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public FilingDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class FilingDateResponseResultsTypeItem
    {
        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("report_title")]
        public string ReportTitle { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amended")]
        public bool Amended { get; set; }

        [JsonProperty("amended_uri")]
        public string AmendedUri { get; set; }

        [JsonProperty("is_amendment")]
        public string IsAmendment { get; set; }

        [JsonProperty("report_period")]
        public string ReportPeriod { get; set; }

        [JsonProperty("original_filing")]
        public string OriginalFiling { get; set; }

        [JsonProperty("original_uri")]
        public string OriginalUri { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("contributions_total")]
        public int ContributionsTotal { get; set; }

        [JsonProperty("cash_on_hand")]
        public double CashOnHand { get; set; }

        [JsonProperty("disbursements_total")]
        public int DisbursementsTotal { get; set; }

        [JsonProperty("receipts_total")]
        public int ReceiptsTotal { get; set; }

        [JsonProperty("loans_total")]
        public string LoansTotal { get; set; }

        [JsonProperty("debts_total")]
        public string DebtsTotal { get; set; }
    }

    public class FilingFormTypeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public FilingFormTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class FilingFormTypeResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FilingTypeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public FilingTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class FilingTypeResponseResultsTypeItem
    {
        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee")]
        public string Committee { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("report_title")]
        public string ReportTitle { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amended")]
        public bool Amended { get; set; }

        [JsonProperty("amended_uri")]
        public string AmendedUri { get; set; }

        [JsonProperty("is_amendment")]
        public string IsAmendment { get; set; }

        [JsonProperty("report_period")]
        public string ReportPeriod { get; set; }

        [JsonProperty("original_filing")]
        public string OriginalFiling { get; set; }

        [JsonProperty("original_uri")]
        public string OriginalUri { get; set; }

        [JsonProperty("committee_type")]
        public string CommitteeType { get; set; }

        [JsonProperty("contributions_total")]
        public string ContributionsTotal { get; set; }

        [JsonProperty("cash_on_hand")]
        public string CashOnHand { get; set; }

        [JsonProperty("disbursements_total")]
        public int DisbursementsTotal { get; set; }

        [JsonProperty("receipts_total")]
        public string ReceiptsTotal { get; set; }

        [JsonProperty("loans_total")]
        public string LoansTotal { get; set; }

        [JsonProperty("debts_total")]
        public string DebtsTotal { get; set; }
    }

    public class FilingSummaryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public FilingSummaryResponseResultsTypeItem[] Results { get; set; }
    }

    public class FilingSummaryResponseResultsTypeItem
    {
        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("fec_form_type")]
        public string FecFormType { get; set; }

        [JsonProperty("report")]
        public string Report { get; set; }

        [JsonProperty("primary_general")]
        public string PrimaryGeneral { get; set; }

        [JsonProperty("date_coverage_from")]
        public string DateCoverageFrom { get; set; }

        [JsonProperty("date_coverage_to")]
        public string DateCoverageTo { get; set; }

        [JsonProperty("cash_on_hand_beginning")]
        public string CashOnHandBeginning { get; set; }

        [JsonProperty("cash_on_hand_close")]
        public string CashOnHandClose { get; set; }

        [JsonProperty("total_receipts_period")]
        public string TotalReceiptsPeriod { get; set; }

        [JsonProperty("total_disbursements_period")]
        public string TotalDisbursementsPeriod { get; set; }

        [JsonProperty("total_receipts_cycle")]
        public string TotalReceiptsCycle { get; set; }

        [JsonProperty("total_disbursements_cycle")]
        public string TotalDisbursementsCycle { get; set; }

        [JsonProperty("total_debts_owed")]
        public string TotalDebtsOwed { get; set; }

        [JsonProperty("individual_contributions_period")]
        public string IndividualContributionsPeriod { get; set; }

        [JsonProperty("party_contributions_period")]
        public string PartyContributionsPeriod { get; set; }

        [JsonProperty("pac_contributions_period")]
        public string PacContributionsPeriod { get; set; }

        [JsonProperty("candidate_contributions_period")]
        public string CandidateContributionsPeriod { get; set; }

        [JsonProperty("total_contributions_period")]
        public string TotalContributionsPeriod { get; set; }

        [JsonProperty("individual_contributions_cycle")]
        public string IndividualContributionsCycle { get; set; }

        [JsonProperty("party_contributions_cycle")]
        public string PartyContributionsCycle { get; set; }

        [JsonProperty("pac_contributions_cycle")]
        public string PacContributionsCycle { get; set; }

        [JsonProperty("candidate_contributions_cycle")]
        public string CandidateContributionsCycle { get; set; }

        [JsonProperty("total_contributions_cycle")]
        public string TotalContributionsCycle { get; set; }

        [JsonProperty("federal_funds_period")]
        public string FederalFundsPeriod { get; set; }

        [JsonProperty("transfers_in_period")]
        public string TransfersInPeriod { get; set; }

        [JsonProperty("candidate_loans_period")]
        public string CandidateLoansPeriod { get; set; }

        [JsonProperty("other_loans_period")]
        public string OtherLoansPeriod { get; set; }

        [JsonProperty("total_loans_period")]
        public string TotalLoansPeriod { get; set; }

        [JsonProperty("federal_funds_cycle")]
        public string FederalFundsCycle { get; set; }

        [JsonProperty("transfers_in_cycle")]
        public string TransfersInCycle { get; set; }

        [JsonProperty("candidate_loans_cycle")]
        public string CandidateLoansCycle { get; set; }

        [JsonProperty("other_loans_cycle")]
        public string OtherLoansCycle { get; set; }

        [JsonProperty("total_loans_cycle")]
        public string TotalLoansCycle { get; set; }

        [JsonProperty("operating_offsets_period")]
        public string OperatingOffsetsPeriod { get; set; }

        [JsonProperty("fundraising_offsets_period")]
        public string FundraisingOffsetsPeriod { get; set; }

        [JsonProperty("legal_offsets_period")]
        public string LegalOffsetsPeriod { get; set; }

        [JsonProperty("total_offsets_period")]
        public string TotalOffsetsPeriod { get; set; }

        [JsonProperty("operating_offsets_cycle")]
        public string OperatingOffsetsCycle { get; set; }

        [JsonProperty("fundraising_offsets_cycle")]
        public string FundraisingOffsetsCycle { get; set; }

        [JsonProperty("legal_offsets_cycle")]
        public string LegalOffsetsCycle { get; set; }

        [JsonProperty("total_offsets_cycle")]
        public string TotalOffsetsCycle { get; set; }

        [JsonProperty("operating_expenditures_period")]
        public string OperatingExpendituresPeriod { get; set; }

        [JsonProperty("transfers_out_period")]
        public string TransfersOutPeriod { get; set; }

        [JsonProperty("fundraising_expenses_period")]
        public string FundraisingExpensesPeriod { get; set; }

        [JsonProperty("legal_expenses_period")]
        public string LegalExpensesPeriod { get; set; }

        [JsonProperty("operating_expenditures_cycle")]
        public string OperatingExpendituresCycle { get; set; }

        [JsonProperty("transfers_out_cycle")]
        public string TransfersOutCycle { get; set; }

        [JsonProperty("fundraising_expenses_cycle")]
        public string FundraisingExpensesCycle { get; set; }

        [JsonProperty("legal_expenses_cycle")]
        public string LegalExpensesCycle { get; set; }

        [JsonProperty("candidate_loan_repayments_period")]
        public string CandidateLoanRepaymentsPeriod { get; set; }

        [JsonProperty("other_loan_repayments_period")]
        public string OtherLoanRepaymentsPeriod { get; set; }

        [JsonProperty("total_loan_repayments_period")]
        public string TotalLoanRepaymentsPeriod { get; set; }

        [JsonProperty("candidate_loan_repayments_cycle")]
        public string CandidateLoanRepaymentsCycle { get; set; }

        [JsonProperty("other_loan_repayments_cycle")]
        public string OtherLoanRepaymentsCycle { get; set; }

        [JsonProperty("total_loan_repayments_cycle")]
        public string TotalLoanRepaymentsCycle { get; set; }

        [JsonProperty("individual_refunds_period")]
        public string IndividualRefundsPeriod { get; set; }

        [JsonProperty("party_refunds_period")]
        public string PartyRefundsPeriod { get; set; }

        [JsonProperty("pac_refunds_period")]
        public string PacRefundsPeriod { get; set; }

        [JsonProperty("total_refunds_period")]
        public string TotalRefundsPeriod { get; set; }

        [JsonProperty("individual_refunds_cycle")]
        public string IndividualRefundsCycle { get; set; }

        [JsonProperty("party_refunds_cycle")]
        public string PartyRefundsCycle { get; set; }

        [JsonProperty("pac_refunds_cycle")]
        public string PacRefundsCycle { get; set; }

        [JsonProperty("total_refunds_cycle")]
        public string TotalRefundsCycle { get; set; }

        [JsonProperty("other_disbursements_period")]
        public string OtherDisbursementsPeriod { get; set; }

        [JsonProperty("other_disbursements_cycle")]
        public string OtherDisbursementsCycle { get; set; }

        [JsonProperty("liquidate_period")]
        public string LiquidatePeriod { get; set; }

        [JsonProperty("net_individual_contributions")]
        public string NetIndividualContributions { get; set; }

        [JsonProperty("net_party_contributions")]
        public string NetPartyContributions { get; set; }

        [JsonProperty("net_pac_contributions")]
        public string NetPacContributions { get; set; }

        [JsonProperty("net_candidate_contributions")]
        public string NetCandidateContributions { get; set; }

        [JsonProperty("net_transfers_in")]
        public string NetTransfersIn { get; set; }

        [JsonProperty("net_total_contributions")]
        public string NetTotalContributions { get; set; }

        [JsonProperty("net_operating_expenses")]
        public string NetOperatingExpenses { get; set; }

        [JsonProperty("net_fundraising_expenses")]
        public string NetFundraisingExpenses { get; set; }

        [JsonProperty("net_legal_expenses")]
        public string NetLegalExpenses { get; set; }

        [JsonProperty("net_disbursements")]
        public string NetDisbursements { get; set; }

        [JsonProperty("contributions_less_than_200")]
        public string ContributionsLessThan200 { get; set; }

        [JsonProperty("num_contributions_less_than_200")]
        public int NumContributionsLessThan200 { get; set; }

        [JsonProperty("contributions_200_499")]
        public string Contributions200499 { get; set; }

        [JsonProperty("num_contributions_200_499")]
        public int NumContributions200499 { get; set; }

        [JsonProperty("contributions_500_1499")]
        public string Contributions5001499 { get; set; }

        [JsonProperty("num_contributions_500_1499")]
        public int NumContributions5001499 { get; set; }

        [JsonProperty("net_primary")]
        public string NetPrimary { get; set; }

        [JsonProperty("net_general")]
        public string NetGeneral { get; set; }

        [JsonProperty("flag_most_current_report")]
        public string FlagMostCurrentReport { get; set; }

        [JsonProperty("flag_valid_report")]
        public string FlagValidReport { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("refunds_less_than_200")]
        public string RefundsLessThan200 { get; set; }

        [JsonProperty("refunds_200_499")]
        public string Refunds200499 { get; set; }

        [JsonProperty("refunds_500_1499")]
        public string Refunds5001499 { get; set; }

        [JsonProperty("num_refunds_less_than_200")]
        public int NumRefundsLessThan200 { get; set; }

        [JsonProperty("num_refunds_200_499")]
        public int NumRefunds200499 { get; set; }

        [JsonProperty("num_refunds_500_1499")]
        public int NumRefunds5001499 { get; set; }

        [JsonProperty("committee_uri")]
        public string CommitteeUri { get; set; }

        [JsonProperty("candidate_uri")]
        public string CandidateUri { get; set; }

        [JsonProperty("num_refunds_2500")]
        public int NumRefunds2500 { get; set; }

        [JsonProperty("refunds_2500")]
        public string Refunds2500 { get; set; }

        [JsonProperty("num_refunds_1500_2499")]
        public int NumRefunds15002499 { get; set; }

        [JsonProperty("refunds_1500_2499")]
        public string Refunds15002499 { get; set; }

        [JsonProperty("num_contributions_1500_2499")]
        public int NumContributions15002499 { get; set; }

        [JsonProperty("contributions_1500_2499")]
        public string Contributions15002499 { get; set; }

        [JsonProperty("num_contributions_2500")]
        public int NumContributions2500 { get; set; }

        [JsonProperty("contributions_2500")]
        public string Contributions2500 { get; set; }
    }

    public class ExpenditureRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public ExpenditureRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureRecentResponseResultsTypeItem
    {
        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonProperty("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public int District { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amendment")]
        public string Amendment { get; set; }

        [JsonProperty("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }
    }

    public class ExpenditureDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("results")]
        public ExpenditureDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureDateResponseResultsTypeItem
    {
        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonProperty("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amendment")]
        public string Amendment { get; set; }

        [JsonProperty("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }
    }

    public class ExpenditureCommitteeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ExpenditureCommitteeResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureCommitteeResponseResultsTypeItem
    {
        [JsonProperty("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonProperty("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amendment")]
        public string Amendment { get; set; }

        [JsonProperty("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("amended_from")]
        public int AmendedFrom { get; set; }

        [JsonProperty("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }
    }

    public class ExpenditureCandidateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonProperty("support_total")]
        public double SupportTotal { get; set; }

        [JsonProperty("oppose_total")]
        public double OpposeTotal { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ExpenditureCandidateResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureCandidateResponseResultsTypeItem
    {
        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amendment")]
        public string Amendment { get; set; }

        [JsonProperty("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }
    }

    public class ExpenditurePresResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public ExpenditurePresResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditurePresResponseResultsTypeItem
    {
        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_committee_name")]
        public string FecCommitteeName { get; set; }

        [JsonProperty("fec_candidate")]
        public string FecCandidate { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("payee")]
        public string Payee { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("fec_uri")]
        public string FecUri { get; set; }

        [JsonProperty("amendment")]
        public string Amendment { get; set; }

        [JsonProperty("support_or_oppose")]
        public string SupportOrOppose { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("dissemination_date")]
        public string DisseminationDate { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }
    }

    public class ExpenditureOfficeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public ExpenditureOfficeResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureOfficeResponseResultsTypeItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }

    public class ExpenditureRaceCommitteeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee")]
        public string FecCommittee { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; }

        [JsonProperty("house_total")]
        public int HouseTotal { get; set; }

        [JsonProperty("senate_total")]
        public int SenateTotal { get; set; }

        [JsonProperty("president_total")]
        public double PresidentTotal { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("results")]
        public ExpenditureRaceCommitteeResponseResultsTypeItem[] Results { get; set; }
    }

    public class ExpenditureRaceCommitteeResponseResultsTypeItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("district")]
        public int District { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }

    public class CommunicationRecentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public CommunicationRecentResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationRecentResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("payee_organization")]
        public string PayeeOrganization { get; set; }

        [JsonProperty("payee_last_name")]
        public string PayeeLastName { get; set; }

        [JsonProperty("payee_first_name")]
        public string PayeeFirstName { get; set; }

        [JsonProperty("payee_middle_name")]
        public string PayeeMiddleName { get; set; }

        [JsonProperty("payee_suffix")]
        public string PayeeSuffix { get; set; }

        [JsonProperty("payee_address_1")]
        public string PayeeAddress1 { get; set; }

        [JsonProperty("payee_address_2")]
        public string PayeeAddress2 { get; set; }

        [JsonProperty("payee_city")]
        public string PayeeCity { get; set; }

        [JsonProperty("payee_state")]
        public string PayeeState { get; set; }

        [JsonProperty("payee_zip")]
        public string PayeeZip { get; set; }

        [JsonProperty("expenditure_date")]
        public string ExpenditureDate { get; set; }

        [JsonProperty("communication_date")]
        public string CommunicationDate { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("election_code")]
        public string ElectionCode { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("back_reference_sched_name")]
        public string BackReferenceSchedName { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("filed_date")]
        public string FiledDate { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("electioneering_communication_candidates")]
        public CommunicationRecentResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem[] ElectioneeringCommunicationCandidates { get; set; }
    }

    public class CommunicationRecentResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("electioneering_communication_id")]
        public int ElectioneeringCommunicationId { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("candidate_state")]
        public string CandidateState { get; set; }

        [JsonProperty("candidate_district")]
        public string CandidateDistrict { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CommunicationCommitteeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public CommunicationCommitteeResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationCommitteeResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("payee_organization")]
        public string PayeeOrganization { get; set; }

        [JsonProperty("payee_last_name")]
        public string PayeeLastName { get; set; }

        [JsonProperty("payee_first_name")]
        public string PayeeFirstName { get; set; }

        [JsonProperty("payee_middle_name")]
        public string PayeeMiddleName { get; set; }

        [JsonProperty("payee_suffix")]
        public string PayeeSuffix { get; set; }

        [JsonProperty("payee_address_1")]
        public string PayeeAddress1 { get; set; }

        [JsonProperty("payee_address_2")]
        public string PayeeAddress2 { get; set; }

        [JsonProperty("payee_city")]
        public string PayeeCity { get; set; }

        [JsonProperty("payee_state")]
        public string PayeeState { get; set; }

        [JsonProperty("payee_zip")]
        public string PayeeZip { get; set; }

        [JsonProperty("expenditure_date")]
        public string ExpenditureDate { get; set; }

        [JsonProperty("communication_date")]
        public string CommunicationDate { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("election_code")]
        public string ElectionCode { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("back_reference_sched_name")]
        public string BackReferenceSchedName { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("filed_date")]
        public string FiledDate { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("electioneering_communication_candidates")]
        public CommunicationCommitteeResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem[] ElectioneeringCommunicationCandidates { get; set; }
    }

    public class CommunicationCommitteeResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("electioneering_communication_id")]
        public int ElectioneeringCommunicationId { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("candidate_state")]
        public string CandidateState { get; set; }

        [JsonProperty("candidate_district")]
        public string CandidateDistrict { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CommunicationDateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public CommunicationDateResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommunicationDateResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("committee_name")]
        public string CommitteeName { get; set; }

        [JsonProperty("payee_organization")]
        public string PayeeOrganization { get; set; }

        [JsonProperty("payee_last_name")]
        public string PayeeLastName { get; set; }

        [JsonProperty("payee_first_name")]
        public string PayeeFirstName { get; set; }

        [JsonProperty("payee_middle_name")]
        public string PayeeMiddleName { get; set; }

        [JsonProperty("payee_suffix")]
        public string PayeeSuffix { get; set; }

        [JsonProperty("payee_address_1")]
        public string PayeeAddress1 { get; set; }

        [JsonProperty("payee_address_2")]
        public string PayeeAddress2 { get; set; }

        [JsonProperty("payee_city")]
        public string PayeeCity { get; set; }

        [JsonProperty("payee_state")]
        public string PayeeState { get; set; }

        [JsonProperty("payee_zip")]
        public string PayeeZip { get; set; }

        [JsonProperty("expenditure_date")]
        public string ExpenditureDate { get; set; }

        [JsonProperty("communication_date")]
        public string CommunicationDate { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("election_code")]
        public string ElectionCode { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("back_reference_sched_name")]
        public string BackReferenceSchedName { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("filed_date")]
        public string FiledDate { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("electioneering_communication_candidates")]
        public CommunicationDateResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem[] ElectioneeringCommunicationCandidates { get; set; }
    }

    public class CommunicationDateResponseResultsTypeItemElectioneeringCommunicationCandidatesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("electioneering_communication_id")]
        public int ElectioneeringCommunicationId { get; set; }

        [JsonProperty("fec_candidate_id")]
        public string FecCandidateId { get; set; }

        [JsonProperty("candidate_name")]
        public string CandidateName { get; set; }

        [JsonProperty("back_reference_tran_id_number")]
        public string BackReferenceTranIdNumber { get; set; }

        [JsonProperty("filing_id")]
        public int FilingId { get; set; }

        [JsonProperty("candidate_state")]
        public string CandidateState { get; set; }

        [JsonProperty("candidate_district")]
        public string CandidateDistrict { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("amended_from")]
        public string AmendedFrom { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class BundlerCommitteeResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("base_uri")]
        public string BaseUri { get; set; }

        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("results")]
        public BundlerCommitteeResponseResultsTypeItem[] Results { get; set; }
    }

    public class BundlerCommitteeResponseResultsTypeItem
    {
        [JsonProperty("cycle")]
        public int Cycle { get; set; }

        [JsonProperty("fec_committee_id")]
        public string FecCommitteeId { get; set; }

        [JsonProperty("fec_filing_id")]
        public int FecFilingId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("entity_type")]
        public string EntityType { get; set; }

        [JsonProperty("bundler_fec_id")]
        public string BundlerFecId { get; set; }

        [JsonProperty("bundler_organization_name")]
        public string BundlerOrganizationName { get; set; }

        [JsonProperty("bundler_prefix")]
        public string BundlerPrefix { get; set; }

        [JsonProperty("bundler_first_name")]
        public string BundlerFirstName { get; set; }

        [JsonProperty("bundler_middle_name")]
        public string BundlerMiddleName { get; set; }

        [JsonProperty("bundler_last_name")]
        public string BundlerLastName { get; set; }

        [JsonProperty("bundler_suffix")]
        public string BundlerSuffix { get; set; }

        [JsonProperty("bundler_street_1")]
        public string BundlerStreet1 { get; set; }

        [JsonProperty("bundler_street_2")]
        public string BundlerStreet2 { get; set; }

        [JsonProperty("bundler_city")]
        public string BundlerCity { get; set; }

        [JsonProperty("bundler_state")]
        public string BundlerState { get; set; }

        [JsonProperty("bundler_zip")]
        public string BundlerZip { get; set; }

        [JsonProperty("bundler_employer")]
        public string BundlerEmployer { get; set; }

        [JsonProperty("bundler_occupation")]
        public string BundlerOccupation { get; set; }

        [JsonProperty("bundled_amount")]
        public string BundledAmount { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Propublicacampaignip;

    public partial class WorkflowManagedActions
    {
        public PropublicacampaignipActions Propublicacampaignip(string connectionId) => new PropublicacampaignipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PropublicacampaignipTriggers Propublicacampaignip(string connectionId) => new PropublicacampaignipTriggers(connectionId);
    }
}