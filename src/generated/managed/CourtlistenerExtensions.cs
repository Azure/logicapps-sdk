//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courtlistener
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourtlistenerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<DocketList, ApiConnectionActionConfiguration> SearchDockets(Expression<Func<string>> caseName = null, Expression<Func<string>> docketNumber = null, Expression<Func<string>> court = null, Expression<Func<string>> dateFiledGte = null, Expression<Func<string>> dateFiledLte = null, Expression<Func<string>> ordering = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> cursor = null, Expression<Func<string>> fields = null)
        {
            var __workflow_caseName = WorkflowExpression.Compile(caseName, nameof(caseName), required: false);
            var __workflow_docketNumber = WorkflowExpression.Compile(docketNumber, nameof(docketNumber), required: false);
            var __workflow_court = WorkflowExpression.Compile(court, nameof(court), required: false);
            var __workflow_dateFiledGte = WorkflowExpression.Compile(dateFiledGte, nameof(dateFiledGte), required: false);
            var __workflow_dateFiledLte = WorkflowExpression.Compile(dateFiledLte, nameof(dateFiledLte), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<DocketList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dockets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_caseName != null)
                    callPayload.Queries["case_name"] = ExpressionConverter.Convert(__workflow_caseName);
                if (__workflow_docketNumber != null)
                    callPayload.Queries["docket_number"] = ExpressionConverter.Convert(__workflow_docketNumber);
                if (__workflow_court != null)
                    callPayload.Queries["court"] = ExpressionConverter.Convert(__workflow_court);
                if (__workflow_dateFiledGte != null)
                    callPayload.Queries["date_filed__gte"] = ExpressionConverter.Convert(__workflow_dateFiledGte);
                if (__workflow_dateFiledLte != null)
                    callPayload.Queries["date_filed__lte"] = ExpressionConverter.Convert(__workflow_dateFiledLte);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<DocketList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<Docket, ApiConnectionActionConfiguration> GetDocket(Expression<Func<int>> id, Expression<Func<string>> fields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Docket, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/dockets/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Docket>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<DocketEntryList, ApiConnectionActionConfiguration> GetDocketEntries(Expression<Func<int>> docket, Expression<Func<int>> entryNumber = null, Expression<Func<string>> dateFiledGte = null, Expression<Func<string>> dateFiledLte = null, Expression<Func<string>> ordering = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> cursor = null, Expression<Func<string>> fields = null)
        {
            var __workflow_docket = WorkflowExpression.Compile(docket, nameof(docket), required: true);
            var __workflow_entryNumber = WorkflowExpression.Compile(entryNumber, nameof(entryNumber), required: false);
            var __workflow_dateFiledGte = WorkflowExpression.Compile(dateFiledGte, nameof(dateFiledGte), required: false);
            var __workflow_dateFiledLte = WorkflowExpression.Compile(dateFiledLte, nameof(dateFiledLte), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<DocketEntryList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/docket-entries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["docket"] = ExpressionConverter.Convert(__workflow_docket);
                if (__workflow_entryNumber != null)
                    callPayload.Queries["entry_number"] = ExpressionConverter.Convert(__workflow_entryNumber);
                if (__workflow_dateFiledGte != null)
                    callPayload.Queries["date_filed__gte"] = ExpressionConverter.Convert(__workflow_dateFiledGte);
                if (__workflow_dateFiledLte != null)
                    callPayload.Queries["date_filed__lte"] = ExpressionConverter.Convert(__workflow_dateFiledLte);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<DocketEntryList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<OpinionSearchList, ApiConnectionActionConfiguration> SearchOpinions(Expression<Func<string>> q = null, Expression<Func<string>> court = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> filedAfter = null, Expression<Func<string>> filedBefore = null, Expression<Func<string>> cursor = null, Expression<Func<string>> fields = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_court = WorkflowExpression.Compile(court, nameof(court), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_filedAfter = WorkflowExpression.Compile(filedAfter, nameof(filedAfter), required: false);
            var __workflow_filedBefore = WorkflowExpression.Compile(filedBefore, nameof(filedBefore), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<OpinionSearchList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("o");
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_court != null)
                    callPayload.Queries["court"] = ExpressionConverter.Convert(__workflow_court);
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_filedAfter != null)
                    callPayload.Queries["filed_after"] = ExpressionConverter.Convert(__workflow_filedAfter);
                if (__workflow_filedBefore != null)
                    callPayload.Queries["filed_before"] = ExpressionConverter.Convert(__workflow_filedBefore);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<OpinionSearchList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<CitationResult[], ApiConnectionActionConfiguration> GetCitation(Expression<Func<GetCitationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CitationResult[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/citation-lookup/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CitationResult[]>(callPayload);
            });
        }
    }

    public class CourtlistenerTriggers([ConnectionName] string connectionId)
    {
    }

    public class DocketList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string NextPageURL { get; set; }

        [JsonProperty("previous")]
        public string PreviousPageURL { get; set; }

        [JsonProperty("results")]
        public Docket[] Results { get; set; }
    }

    public class Docket
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceURI { get; set; }

        [JsonProperty("court_id")]
        public string CourtId { get; set; }

        [JsonProperty("case_name")]
        public string CaseName { get; set; }

        [JsonProperty("case_name_full")]
        public string FullCaseName { get; set; }

        [JsonProperty("docket_number")]
        public string DocketNumber { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_terminated")]
        public string DateTerminated { get; set; }

        [JsonProperty("date_argued")]
        public string DateArgued { get; set; }

        [JsonProperty("assigned_to_str")]
        public string AssignedJudge { get; set; }

        [JsonProperty("referred_to_str")]
        public string ReferredTo { get; set; }

        [JsonProperty("nature_of_suit")]
        public string NatureOfSuit { get; set; }

        [JsonProperty("jurisdiction_type")]
        public string JurisdictionType { get; set; }

        [JsonProperty("cause")]
        public string Cause { get; set; }

        [JsonProperty("jury_demand")]
        public string JuryDemand { get; set; }

        [JsonProperty("absolute_url")]
        public string URLPath { get; set; }

        [JsonProperty("pacer_case_id")]
        public string PACERCaseId { get; set; }

        [JsonProperty("source")]
        public int Source { get; set; }

        [JsonProperty("blocked")]
        public bool Blocked { get; set; }
    }

    public class DocketEntryList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string NextPageURL { get; set; }

        [JsonProperty("previous")]
        public string PreviousPageURL { get; set; }

        [JsonProperty("results")]
        public DocketEntry[] Results { get; set; }
    }

    public class DocketEntry
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("docket")]
        public string DocketURI { get; set; }

        [JsonProperty("date_filed")]
        public string DateFiled { get; set; }

        [JsonProperty("date_entered")]
        public string DateEntered { get; set; }

        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("pacer_sequence_number")]
        public int PACERSequenceNumber { get; set; }
    }

    public class OpinionSearchList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string NextPageURL { get; set; }

        [JsonProperty("previous")]
        public string PreviousPageURL { get; set; }

        [JsonProperty("results")]
        public OpinionSearchResult[] Results { get; set; }
    }

    public class OpinionSearchResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cluster_id")]
        public int ClusterId { get; set; }

        [JsonProperty("docket_id")]
        public int DocketId { get; set; }

        [JsonProperty("court_id")]
        public string CourtId { get; set; }

        [JsonProperty("caseName")]
        public string CaseName { get; set; }

        [JsonProperty("docketNumber")]
        public string DocketNumber { get; set; }

        [JsonProperty("dateFiled")]
        public string DateFiled { get; set; }

        [JsonProperty("citation")]
        public string[] Citations { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("citeCount")]
        public int CiteCount { get; set; }

        [JsonProperty("judge")]
        public string Judge { get; set; }

        [JsonProperty("per_curiam")]
        public bool PerCuriam { get; set; }

        [JsonProperty("absolute_url")]
        public string URLPath { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }
    }

    public class CitationResult
    {
        [JsonProperty("citation")]
        public string Citation { get; set; }

        [JsonProperty("normalized_citations")]
        public string[] NormalizedCitations { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("end_index")]
        public int EndIndex { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("clusters")]
        public CitationCluster[] Clusters { get; set; }
    }

    public class CitationCluster
    {
        [JsonProperty("id")]
        public int ClusterId { get; set; }

        [JsonProperty("case_name")]
        public string CaseName { get; set; }

        [JsonProperty("absolute_url")]
        public string URLPath { get; set; }
    }

    public class GetCitationInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("reporter")]
        public string Reporter { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Courtlistener;

    public partial class WorkflowManagedActions
    {
        public CourtlistenerActions Courtlistener(string connectionId) => new CourtlistenerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CourtlistenerTriggers Courtlistener(string connectionId) => new CourtlistenerTriggers(connectionId);
    }
}