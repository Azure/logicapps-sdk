//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openfec
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenfecActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfec")]
        [WorkflowExpressionFactory(nameof(__BuildCommitteeCommitteeIdCandidatesHistory))]
        public IBodyWorkflowAction<CommitteeCandidateHistoryResponse> CommitteeCommitteeIdCandidatesHistory([WorkflowExpression] Func<string> committeeId, [WorkflowExpression] Func<string> sortHideNull = null, [WorkflowExpression] Func<string> page = null, [WorkflowExpression] Func<string> sortNullsLast = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> sortNullOnly = null, [WorkflowExpression] Func<string> perPage = null, [WorkflowExpression] Func<string> electionFull = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommitteeCandidateHistoryResponse> __BuildCommitteeCommitteeIdCandidatesHistory(WorkflowValue<string> committeeId, WorkflowValue<string> sortHideNull = null, WorkflowValue<string> page = null, WorkflowValue<string> sortNullsLast = null, WorkflowValue<string> sort = null, WorkflowValue<string> sortNullOnly = null, WorkflowValue<string> perPage = null, WorkflowValue<string> electionFull = null)
        {
            WorkflowValue.Validate(committeeId, nameof(committeeId), required: true);
            WorkflowValue.Validate(sortHideNull, nameof(sortHideNull), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(sortNullsLast, nameof(sortNullsLast), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            WorkflowValue.Validate(sortNullOnly, nameof(sortNullOnly), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            WorkflowValue.Validate(electionFull, nameof(electionFull), required: false);
            return new DeferredBodyAction<CommitteeCandidateHistoryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/committee/{0}/candidates/history/", ExpressionConverter.ConvertWithUrlEncoding(committeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_hide_null"] = Convert.ToString("false");
                if (sortHideNull != null)
                    callPayload.Queries["sort_hide_null"] = ExpressionConverter.Convert(sortHideNull);
                callPayload.Queries["page"] = Convert.ToString("1");
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["sort_nulls_last"] = Convert.ToString("false");
                if (sortNullsLast != null)
                    callPayload.Queries["sort_nulls_last"] = ExpressionConverter.Convert(sortNullsLast);
                callPayload.Queries["sort"] = Convert.ToString("");
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Queries["sort_null_only"] = Convert.ToString("false");
                if (sortNullOnly != null)
                    callPayload.Queries["sort_null_only"] = ExpressionConverter.Convert(sortNullOnly);
                callPayload.Queries["per_page"] = Convert.ToString("20");
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                callPayload.Queries["election_full"] = Convert.ToString("true");
                if (electionFull != null)
                    callPayload.Queries["election_full"] = ExpressionConverter.Convert(electionFull);
                return new ApiConnectionAction<CommitteeCandidateHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openfec")]
        [WorkflowExpressionFactory(nameof(__BuildOperationsLog))]
        public IBodyWorkflowAction<OperationsLogResponse> OperationsLog([WorkflowExpression] Func<string> formType, [WorkflowExpression] Func<string> reportYear, [WorkflowExpression] Func<string> sort, [WorkflowExpression] Func<string> maxReceiptDate, [WorkflowExpression] Func<string> reportType, [WorkflowExpression] Func<string> perPage, [WorkflowExpression] Func<string> candidateCommitteeId, [WorkflowExpression] Func<string> minReceiptDate, [WorkflowExpression] Func<string> minCoverageEndDate, [WorkflowExpression] Func<string> page, [WorkflowExpression] Func<string> statusNum, [WorkflowExpression] Func<string> minTransactionDataCompleteDate, [WorkflowExpression] Func<string> maxCoverageEndDate, [WorkflowExpression] Func<string> maxTransactionDataCompleteDate, [WorkflowExpression] Func<string> beginningImageNumber, [WorkflowExpression] Func<string> sortNullsLast = null, [WorkflowExpression] Func<string> sortNullOnly = null, [WorkflowExpression] Func<string> sortHideNull = null, [WorkflowExpression] Func<string> amendmentIndicator = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OperationsLogResponse> __BuildOperationsLog(WorkflowValue<string> formType, WorkflowValue<string> reportYear, WorkflowValue<string> sort, WorkflowValue<string> maxReceiptDate, WorkflowValue<string> reportType, WorkflowValue<string> perPage, WorkflowValue<string> candidateCommitteeId, WorkflowValue<string> minReceiptDate, WorkflowValue<string> minCoverageEndDate, WorkflowValue<string> page, WorkflowValue<string> statusNum, WorkflowValue<string> minTransactionDataCompleteDate, WorkflowValue<string> maxCoverageEndDate, WorkflowValue<string> maxTransactionDataCompleteDate, WorkflowValue<string> beginningImageNumber, WorkflowValue<string> sortNullsLast = null, WorkflowValue<string> sortNullOnly = null, WorkflowValue<string> sortHideNull = null, WorkflowValue<string> amendmentIndicator = null)
        {
            WorkflowValue.Validate(formType, nameof(formType), required: true);
            WorkflowValue.Validate(reportYear, nameof(reportYear), required: true);
            WorkflowValue.Validate(sort, nameof(sort), required: true);
            WorkflowValue.Validate(maxReceiptDate, nameof(maxReceiptDate), required: true);
            WorkflowValue.Validate(reportType, nameof(reportType), required: true);
            WorkflowValue.Validate(perPage, nameof(perPage), required: true);
            WorkflowValue.Validate(candidateCommitteeId, nameof(candidateCommitteeId), required: true);
            WorkflowValue.Validate(minReceiptDate, nameof(minReceiptDate), required: true);
            WorkflowValue.Validate(minCoverageEndDate, nameof(minCoverageEndDate), required: true);
            WorkflowValue.Validate(page, nameof(page), required: true);
            WorkflowValue.Validate(statusNum, nameof(statusNum), required: true);
            WorkflowValue.Validate(minTransactionDataCompleteDate, nameof(minTransactionDataCompleteDate), required: true);
            WorkflowValue.Validate(maxCoverageEndDate, nameof(maxCoverageEndDate), required: true);
            WorkflowValue.Validate(maxTransactionDataCompleteDate, nameof(maxTransactionDataCompleteDate), required: true);
            WorkflowValue.Validate(beginningImageNumber, nameof(beginningImageNumber), required: true);
            WorkflowValue.Validate(sortNullsLast, nameof(sortNullsLast), required: false);
            WorkflowValue.Validate(sortNullOnly, nameof(sortNullOnly), required: false);
            WorkflowValue.Validate(sortHideNull, nameof(sortHideNull), required: false);
            WorkflowValue.Validate(amendmentIndicator, nameof(amendmentIndicator), required: false);
            return new DeferredBodyAction<OperationsLogResponse>(() =>
            {
                var apiCallPath = "/operations-log/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_type"] = ExpressionConverter.Convert(formType);
                callPayload.Queries["report_year"] = ExpressionConverter.Convert(reportYear);
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Queries["max_receipt_date"] = ExpressionConverter.Convert(maxReceiptDate);
                callPayload.Queries["report_type"] = ExpressionConverter.Convert(reportType);
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                callPayload.Queries["candidate_committee_id"] = ExpressionConverter.Convert(candidateCommitteeId);
                callPayload.Queries["min_receipt_date"] = ExpressionConverter.Convert(minReceiptDate);
                callPayload.Queries["min_coverage_end_date"] = ExpressionConverter.Convert(minCoverageEndDate);
                callPayload.Queries["sort_nulls_last"] = Convert.ToString("false");
                if (sortNullsLast != null)
                    callPayload.Queries["sort_nulls_last"] = ExpressionConverter.Convert(sortNullsLast);
                callPayload.Queries["sort_null_only"] = Convert.ToString("false");
                if (sortNullOnly != null)
                    callPayload.Queries["sort_null_only"] = ExpressionConverter.Convert(sortNullOnly);
                callPayload.Queries["sort_hide_null"] = Convert.ToString("false");
                if (sortHideNull != null)
                    callPayload.Queries["sort_hide_null"] = ExpressionConverter.Convert(sortHideNull);
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["amendment_indicator"] = Convert.ToString("N");
                if (amendmentIndicator != null)
                    callPayload.Queries["amendment_indicator"] = ExpressionConverter.Convert(amendmentIndicator);
                callPayload.Queries["status_num"] = ExpressionConverter.Convert(statusNum);
                callPayload.Queries["min_transaction_data_complete_date"] = ExpressionConverter.Convert(minTransactionDataCompleteDate);
                callPayload.Queries["max_coverage_end_date"] = ExpressionConverter.Convert(maxCoverageEndDate);
                callPayload.Queries["max_transaction_data_complete_date"] = ExpressionConverter.Convert(maxTransactionDataCompleteDate);
                callPayload.Queries["beginning_image_number"] = ExpressionConverter.Convert(beginningImageNumber);
                return new ApiConnectionAction<OperationsLogResponse>(callPayload);
            });
        }
    }

    public class OpenfecTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommitteeCandidateHistoryResponse
    {
        [JsonProperty("pagination")]
        public CommitteeCandidateHistoryResponsePaginationType Pagination { get; set; }

        [JsonProperty("results")]
        public CommitteeCandidateHistoryResponseResultsTypeItem[] Results { get; set; }
    }

    public class CommitteeCandidateHistoryResponsePaginationType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }
    }

    public class CommitteeCandidateHistoryResponseResultsTypeItem
    {
        [JsonProperty("candidate_id")]
        public string CandidateId { get; set; }

        [JsonProperty("two_year_period")]
        public int TwoYearPeriod { get; set; }

        [JsonProperty("active_through")]
        public int ActiveThrough { get; set; }

        [JsonProperty("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_street_1")]
        public string AddressStreet1 { get; set; }

        [JsonProperty("address_street_2")]
        public string AddressStreet2 { get; set; }

        [JsonProperty("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("candidate_election_year")]
        public int CandidateElectionYear { get; set; }

        [JsonProperty("candidate_inactive")]
        public bool CandidateInactive { get; set; }

        [JsonProperty("candidate_status")]
        public string CandidateStatus { get; set; }

        [JsonProperty("cycles")]
        public int[] Cycles { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("district_number")]
        public int DistrictNumber { get; set; }

        [JsonProperty("election_districts")]
        public string[] ElectionDistricts { get; set; }

        [JsonProperty("election_years")]
        public int[] ElectionYears { get; set; }

        [JsonProperty("fec_cycles_in_election")]
        public int[] FecCyclesInElection { get; set; }

        [JsonProperty("first_file_date")]
        public string FirstFileDate { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("incumbent_challenge")]
        public string IncumbentChallenge { get; set; }

        [JsonProperty("incumbent_challenge_full")]
        public string IncumbentChallengeFull { get; set; }

        [JsonProperty("last_f2_date")]
        public string LastF2Date { get; set; }

        [JsonProperty("last_file_date")]
        public string LastFileDate { get; set; }

        [JsonProperty("load_date")]
        public string LoadDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("office")]
        public string Office { get; set; }

        [JsonProperty("office_full")]
        public string OfficeFull { get; set; }

        [JsonProperty("party")]
        public string Party { get; set; }

        [JsonProperty("party_full")]
        public string PartyFull { get; set; }

        [JsonProperty("rounded_election_years")]
        public int[] RoundedElectionYears { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class OperationsLogResponse
    {
        [JsonProperty("pagination")]
        public OperationsLogResponsePaginationType Pagination { get; set; }

        [JsonProperty("results")]
        public OperationsLogResponseResultsTypeItem[] Results { get; set; }
    }

    public class OperationsLogResponsePaginationType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }
    }

    public class OperationsLogResponseResultsTypeItem
    {
        [JsonProperty("amendment_indicator")]
        public string AmendmentIndicator { get; set; }

        [JsonProperty("beginning_image_number")]
        public string BeginningImageNumber { get; set; }

        [JsonProperty("candidate_committee_id")]
        public string CandidateCommitteeId { get; set; }

        [JsonProperty("coverage_end_date")]
        public string CoverageEndDate { get; set; }

        [JsonProperty("coverage_start_date")]
        public string CoverageStartDate { get; set; }

        [JsonProperty("ending_image_number")]
        public string EndingImageNumber { get; set; }

        [JsonProperty("form_type")]
        public string FormType { get; set; }

        [JsonProperty("receipt_date")]
        public string ReceiptDate { get; set; }

        [JsonProperty("report_type")]
        public string ReportType { get; set; }

        [JsonProperty("report_year")]
        public int ReportYear { get; set; }

        [JsonProperty("status_num")]
        public int StatusNum { get; set; }

        [JsonProperty("sub_id")]
        public int SubId { get; set; }

        [JsonProperty("summary_data_complete_date")]
        public string SummaryDataCompleteDate { get; set; }

        [JsonProperty("summary_data_verification_date")]
        public string SummaryDataVerificationDate { get; set; }

        [JsonProperty("transaction_data_complete_date")]
        public string TransactionDataCompleteDate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openfec;

    public partial class WorkflowManagedActions
    {
        public OpenfecActions Openfec(string connectionId) => new OpenfecActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenfecTriggers Openfec(string connectionId) => new OpenfecTriggers(connectionId);
    }
}
