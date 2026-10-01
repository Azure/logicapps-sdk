//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courtlistener
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourtlistenerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<DocketList> SearchDockets([WorkflowExpression] Func<string> caseName = null, [WorkflowExpression] Func<string> docketNumber = null, [WorkflowExpression] Func<string> court = null, [WorkflowExpression] Func<string> dateFiledGte = null, [WorkflowExpression] Func<string> dateFiledLte = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dockets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (caseName != null)
                    callPayload.Queries["case_name"] = SourceExpressionConverter.ConvertO(caseName);
                if (docketNumber != null)
                    callPayload.Queries["docket_number"] = SourceExpressionConverter.ConvertO(docketNumber);
                if (court != null)
                    callPayload.Queries["court"] = SourceExpressionConverter.ConvertO(court);
                if (dateFiledGte != null)
                    callPayload.Queries["date_filed__gte"] = SourceExpressionConverter.ConvertO(dateFiledGte);
                if (dateFiledLte != null)
                    callPayload.Queries["date_filed__lte"] = SourceExpressionConverter.ConvertO(dateFiledLte);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<DocketList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<Docket> GetDocket([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dockets/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<Docket>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<DocketEntryList> GetDocketEntries([WorkflowExpression] Func<int> docket, [WorkflowExpression] Func<int> entryNumber = null, [WorkflowExpression] Func<string> dateFiledGte = null, [WorkflowExpression] Func<string> dateFiledLte = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/docket-entries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["docket"] = SourceExpressionConverter.ConvertO(docket);
                if (entryNumber != null)
                    callPayload.Queries["entry_number"] = SourceExpressionConverter.ConvertO(entryNumber);
                if (dateFiledGte != null)
                    callPayload.Queries["date_filed__gte"] = SourceExpressionConverter.ConvertO(dateFiledGte);
                if (dateFiledLte != null)
                    callPayload.Queries["date_filed__lte"] = SourceExpressionConverter.ConvertO(dateFiledLte);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<DocketEntryList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<OpinionSearchList> SearchOpinions([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> court = null, [WorkflowExpression] Func<string> orderBy = null, [WorkflowExpression] Func<string> filedAfter = null, [WorkflowExpression] Func<string> filedBefore = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("o");
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (court != null)
                    callPayload.Queries["court"] = SourceExpressionConverter.ConvertO(court);
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.ConvertO(orderBy);
                if (filedAfter != null)
                    callPayload.Queries["filed_after"] = SourceExpressionConverter.ConvertO(filedAfter);
                if (filedBefore != null)
                    callPayload.Queries["filed_before"] = SourceExpressionConverter.ConvertO(filedBefore);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<OpinionSearchList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courtlistener")]
        public IBodyWorkflowAction<CitationResult[]> GetCitation([WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyvolume = null, [WorkflowExpression] Func<string> bodyreporter = null, [WorkflowExpression] Func<string> bodypage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/citation-lookup/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyvolume != null)
                {
                    body["volume"] = SourceExpressionConverter.ConvertToken(bodyvolume);
                    bodypropCount++;
                }

                if (bodyreporter != null)
                {
                    body["reporter"] = SourceExpressionConverter.ConvertToken(bodyreporter);
                    bodypropCount++;
                }

                if (bodypage != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CitationResult[]>(BuildSourceInput);
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
        public int ID { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceURI { get; set; }

        [JsonProperty("court_id")]
        public string CourtID { get; set; }

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
        public string PACERCaseID { get; set; }

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
        public int ID { get; set; }

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
        public int ID { get; set; }

        [JsonProperty("cluster_id")]
        public int ClusterID { get; set; }

        [JsonProperty("docket_id")]
        public int DocketID { get; set; }

        [JsonProperty("court_id")]
        public string CourtID { get; set; }

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
        public int ClusterID { get; set; }

        [JsonProperty("case_name")]
        public string CaseName { get; set; }

        [JsonProperty("absolute_url")]
        public string URLPath { get; set; }
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