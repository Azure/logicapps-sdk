//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Consumercomplaints
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConsumercomplaintsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<SearchResult> SearchConsumerComplaints(Expression<Func<string>> searchTerm, Expression<Func<fieldInput>> field = null, Expression<Func<int>> frm = null, Expression<Func<int>> size = null, Expression<Func<sortInput>> sort = null, Expression<Func<bool>> noAggs = null, Expression<Func<bool>> noHighlight = null, Expression<Func<string>> company = null, Expression<Func<companyPublicResponseInput>> companyPublicResponse = null, Expression<Func<string>> companyReceivedMax = null, Expression<Func<string>> companyReceivedMin = null, Expression<Func<string>> companyResponse = null, Expression<Func<consumerConsentProvidedInput>> consumerConsentProvided = null, Expression<Func<string>> consumerDisputed = null, Expression<Func<string>> dateReceivedMax = null, Expression<Func<string>> dateReceivedMin = null, Expression<Func<hasNarrativeInput>> hasNarrative = null, Expression<Func<issueInput>> issue = null, Expression<Func<productInput>> product = null, Expression<Func<string>> state = null, Expression<Func<submittedViaInput>> submittedVia = null, Expression<Func<tagsInput>> tags = null, Expression<Func<timelyInput>> timely = null, Expression<Func<string>> zipCode = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["search_term"] = ExpressionConverter.Convert(searchTerm);
            callPayload.Queries["field"] = Convert.ToString("complaint_what_happened");
            if (field != null)
                callPayload.Queries["field"] = ExpressionConverter.Convert(field);
            if (frm != null)
                callPayload.Queries["frm"] = ExpressionConverter.Convert(frm);
            callPayload.Queries["size"] = Convert.ToString(10);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["sort"] = Convert.ToString("relevance_desc");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Queries["no_aggs"] = Convert.ToString(false);
            if (noAggs != null)
                callPayload.Queries["no_aggs"] = ExpressionConverter.Convert(noAggs);
            callPayload.Queries["no_highlight"] = Convert.ToString(false);
            if (noHighlight != null)
                callPayload.Queries["no_highlight"] = ExpressionConverter.Convert(noHighlight);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (companyPublicResponse != null)
                callPayload.Queries["company_public_response"] = ExpressionConverter.Convert(companyPublicResponse);
            if (companyReceivedMax != null)
                callPayload.Queries["company_received_max"] = ExpressionConverter.Convert(companyReceivedMax);
            if (companyReceivedMin != null)
                callPayload.Queries["company_received_min"] = ExpressionConverter.Convert(companyReceivedMin);
            if (companyResponse != null)
                callPayload.Queries["company_response"] = ExpressionConverter.Convert(companyResponse);
            if (consumerConsentProvided != null)
                callPayload.Queries["consumer_consent_provided"] = ExpressionConverter.Convert(consumerConsentProvided);
            if (consumerDisputed != null)
                callPayload.Queries["consumer_disputed"] = ExpressionConverter.Convert(consumerDisputed);
            if (dateReceivedMax != null)
                callPayload.Queries["date_received_max"] = ExpressionConverter.Convert(dateReceivedMax);
            if (dateReceivedMin != null)
                callPayload.Queries["date_received_min"] = ExpressionConverter.Convert(dateReceivedMin);
            if (hasNarrative != null)
                callPayload.Queries["has_narrative"] = ExpressionConverter.Convert(hasNarrative);
            if (issue != null)
                callPayload.Queries["issue"] = ExpressionConverter.Convert(issue);
            if (product != null)
                callPayload.Queries["product"] = ExpressionConverter.Convert(product);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (submittedVia != null)
                callPayload.Queries["submitted_via"] = ExpressionConverter.Convert(submittedVia);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (timely != null)
                callPayload.Queries["timely"] = ExpressionConverter.Convert(timely);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            return new ApiConnectionAction<SearchResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<string[]> SuggestSearches(Expression<Func<string>> text, Expression<Func<int>> size = null)
        {
            var apiCallPath = "/_suggest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["size"] = Convert.ToString(10);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<string[]> SuggestCompanies(Expression<Func<string>> text, Expression<Func<int>> size = null, Expression<Func<companyPublicResponseInput>> companyPublicResponse = null, Expression<Func<string>> companyReceivedMax = null, Expression<Func<string>> companyReceivedMin = null, Expression<Func<string>> companyResponse = null, Expression<Func<consumerConsentProvidedInput>> consumerConsentProvided = null, Expression<Func<string>> consumerDisputed = null, Expression<Func<string>> dateReceivedMax = null, Expression<Func<string>> dateReceivedMin = null, Expression<Func<hasNarrativeInput>> hasNarrative = null, Expression<Func<issueInput>> issue = null, Expression<Func<productInput>> product = null, Expression<Func<string>> state = null, Expression<Func<submittedViaInput>> submittedVia = null, Expression<Func<tagsInput>> tags = null, Expression<Func<timelyInput>> timely = null, Expression<Func<string>> zipCode = null)
        {
            var apiCallPath = "/_suggest_company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            callPayload.Queries["size"] = Convert.ToString(10);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (companyPublicResponse != null)
                callPayload.Queries["company_public_response"] = ExpressionConverter.Convert(companyPublicResponse);
            if (companyReceivedMax != null)
                callPayload.Queries["company_received_max"] = ExpressionConverter.Convert(companyReceivedMax);
            if (companyReceivedMin != null)
                callPayload.Queries["company_received_min"] = ExpressionConverter.Convert(companyReceivedMin);
            if (companyResponse != null)
                callPayload.Queries["company_response"] = ExpressionConverter.Convert(companyResponse);
            if (consumerConsentProvided != null)
                callPayload.Queries["consumer_consent_provided"] = ExpressionConverter.Convert(consumerConsentProvided);
            if (consumerDisputed != null)
                callPayload.Queries["consumer_disputed"] = ExpressionConverter.Convert(consumerDisputed);
            if (dateReceivedMax != null)
                callPayload.Queries["date_received_max"] = ExpressionConverter.Convert(dateReceivedMax);
            if (dateReceivedMin != null)
                callPayload.Queries["date_received_min"] = ExpressionConverter.Convert(dateReceivedMin);
            if (hasNarrative != null)
                callPayload.Queries["has_narrative"] = ExpressionConverter.Convert(hasNarrative);
            if (issue != null)
                callPayload.Queries["issue"] = ExpressionConverter.Convert(issue);
            if (product != null)
                callPayload.Queries["product"] = ExpressionConverter.Convert(product);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (submittedVia != null)
                callPayload.Queries["submitted_via"] = ExpressionConverter.Convert(submittedVia);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (timely != null)
                callPayload.Queries["timely"] = ExpressionConverter.Convert(timely);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<string[]> SuggestZipCodes(Expression<Func<string>> text, Expression<Func<int>> size = null, Expression<Func<companyPublicResponseInput>> companyPublicResponse = null, Expression<Func<string>> companyReceivedMax = null, Expression<Func<string>> companyReceivedMin = null, Expression<Func<string>> companyResponse = null, Expression<Func<consumerConsentProvidedInput>> consumerConsentProvided = null, Expression<Func<string>> consumerDisputed = null, Expression<Func<string>> dateReceivedMax = null, Expression<Func<string>> dateReceivedMin = null, Expression<Func<hasNarrativeInput>> hasNarrative = null, Expression<Func<issueInput>> issue = null, Expression<Func<productInput>> product = null, Expression<Func<string>> state = null, Expression<Func<submittedViaInput>> submittedVia = null, Expression<Func<tagsInput>> tags = null, Expression<Func<timelyInput>> timely = null, Expression<Func<string>> zipCode = null)
        {
            var apiCallPath = "/_suggest_zip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            callPayload.Queries["size"] = Convert.ToString(10);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (companyPublicResponse != null)
                callPayload.Queries["company_public_response"] = ExpressionConverter.Convert(companyPublicResponse);
            if (companyReceivedMax != null)
                callPayload.Queries["company_received_max"] = ExpressionConverter.Convert(companyReceivedMax);
            if (companyReceivedMin != null)
                callPayload.Queries["company_received_min"] = ExpressionConverter.Convert(companyReceivedMin);
            if (companyResponse != null)
                callPayload.Queries["company_response"] = ExpressionConverter.Convert(companyResponse);
            if (consumerConsentProvided != null)
                callPayload.Queries["consumer_consent_provided"] = ExpressionConverter.Convert(consumerConsentProvided);
            if (consumerDisputed != null)
                callPayload.Queries["consumer_disputed"] = ExpressionConverter.Convert(consumerDisputed);
            if (dateReceivedMax != null)
                callPayload.Queries["date_received_max"] = ExpressionConverter.Convert(dateReceivedMax);
            if (dateReceivedMin != null)
                callPayload.Queries["date_received_min"] = ExpressionConverter.Convert(dateReceivedMin);
            if (hasNarrative != null)
                callPayload.Queries["has_narrative"] = ExpressionConverter.Convert(hasNarrative);
            if (issue != null)
                callPayload.Queries["issue"] = ExpressionConverter.Convert(issue);
            if (product != null)
                callPayload.Queries["product"] = ExpressionConverter.Convert(product);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (submittedVia != null)
                callPayload.Queries["submitted_via"] = ExpressionConverter.Convert(submittedVia);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (timely != null)
                callPayload.Queries["timely"] = ExpressionConverter.Convert(timely);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<StatesResult> ListStateComplaints(Expression<Func<string>> searchTerm = null, Expression<Func<fieldInput>> field = null, Expression<Func<string>> company = null, Expression<Func<companyPublicResponseInput>> companyPublicResponse = null, Expression<Func<string>> companyReceivedMax = null, Expression<Func<string>> companyReceivedMin = null, Expression<Func<string>> companyResponse = null, Expression<Func<consumerConsentProvidedInput>> consumerConsentProvided = null, Expression<Func<string>> consumerDisputed = null, Expression<Func<string>> dateReceivedMax = null, Expression<Func<string>> dateReceivedMin = null, Expression<Func<hasNarrativeInput>> hasNarrative = null, Expression<Func<issueInput>> issue = null, Expression<Func<productInput>> product = null, Expression<Func<string>> state = null, Expression<Func<submittedViaInput>> submittedVia = null, Expression<Func<tagsInput>> tags = null, Expression<Func<timelyInput>> timely = null, Expression<Func<string>> zipCode = null)
        {
            var apiCallPath = "/geo/states";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (searchTerm != null)
                callPayload.Queries["search_term"] = ExpressionConverter.Convert(searchTerm);
            callPayload.Queries["field"] = Convert.ToString("complaint_what_happened");
            if (field != null)
                callPayload.Queries["field"] = ExpressionConverter.Convert(field);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (companyPublicResponse != null)
                callPayload.Queries["company_public_response"] = ExpressionConverter.Convert(companyPublicResponse);
            if (companyReceivedMax != null)
                callPayload.Queries["company_received_max"] = ExpressionConverter.Convert(companyReceivedMax);
            if (companyReceivedMin != null)
                callPayload.Queries["company_received_min"] = ExpressionConverter.Convert(companyReceivedMin);
            if (companyResponse != null)
                callPayload.Queries["company_response"] = ExpressionConverter.Convert(companyResponse);
            if (consumerConsentProvided != null)
                callPayload.Queries["consumer_consent_provided"] = ExpressionConverter.Convert(consumerConsentProvided);
            if (consumerDisputed != null)
                callPayload.Queries["consumer_disputed"] = ExpressionConverter.Convert(consumerDisputed);
            if (dateReceivedMax != null)
                callPayload.Queries["date_received_max"] = ExpressionConverter.Convert(dateReceivedMax);
            if (dateReceivedMin != null)
                callPayload.Queries["date_received_min"] = ExpressionConverter.Convert(dateReceivedMin);
            if (hasNarrative != null)
                callPayload.Queries["has_narrative"] = ExpressionConverter.Convert(hasNarrative);
            if (issue != null)
                callPayload.Queries["issue"] = ExpressionConverter.Convert(issue);
            if (product != null)
                callPayload.Queries["product"] = ExpressionConverter.Convert(product);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (submittedVia != null)
                callPayload.Queries["submitted_via"] = ExpressionConverter.Convert(submittedVia);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (timely != null)
                callPayload.Queries["timely"] = ExpressionConverter.Convert(timely);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            return new ApiConnectionAction<StatesResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<TrendsResult> ListComplaintTrends(Expression<Func<lensInput>> lens, Expression<Func<trendIntervalInput>> trendInterval, Expression<Func<string>> searchTerm = null, Expression<Func<fieldInput>> field = null, Expression<Func<string>> company = null, Expression<Func<companyPublicResponseInput>> companyPublicResponse = null, Expression<Func<string>> companyReceivedMax = null, Expression<Func<string>> companyReceivedMin = null, Expression<Func<string>> companyResponse = null, Expression<Func<consumerConsentProvidedInput>> consumerConsentProvided = null, Expression<Func<string>> consumerDisputed = null, Expression<Func<string>> dateReceivedMax = null, Expression<Func<string>> dateReceivedMin = null, Expression<Func<string>> focus = null, Expression<Func<hasNarrativeInput>> hasNarrative = null, Expression<Func<issueInput>> issue = null, Expression<Func<productInput>> product = null, Expression<Func<string>> state = null, Expression<Func<submittedViaInput>> submittedVia = null, Expression<Func<subLensInput>> subLens = null, Expression<Func<int>> subLensDepth = null, Expression<Func<tagsInput>> tags = null, Expression<Func<timelyInput>> timely = null, Expression<Func<int>> trendDepth = null, Expression<Func<string>> zipCode = null)
        {
            var apiCallPath = "/trends";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (searchTerm != null)
                callPayload.Queries["search_term"] = ExpressionConverter.Convert(searchTerm);
            callPayload.Queries["field"] = Convert.ToString("complaint_what_happened");
            if (field != null)
                callPayload.Queries["field"] = ExpressionConverter.Convert(field);
            if (company != null)
                callPayload.Queries["company"] = ExpressionConverter.Convert(company);
            if (companyPublicResponse != null)
                callPayload.Queries["company_public_response"] = ExpressionConverter.Convert(companyPublicResponse);
            if (companyReceivedMax != null)
                callPayload.Queries["company_received_max"] = ExpressionConverter.Convert(companyReceivedMax);
            if (companyReceivedMin != null)
                callPayload.Queries["company_received_min"] = ExpressionConverter.Convert(companyReceivedMin);
            if (companyResponse != null)
                callPayload.Queries["company_response"] = ExpressionConverter.Convert(companyResponse);
            if (consumerConsentProvided != null)
                callPayload.Queries["consumer_consent_provided"] = ExpressionConverter.Convert(consumerConsentProvided);
            if (consumerDisputed != null)
                callPayload.Queries["consumer_disputed"] = ExpressionConverter.Convert(consumerDisputed);
            if (dateReceivedMax != null)
                callPayload.Queries["date_received_max"] = ExpressionConverter.Convert(dateReceivedMax);
            if (dateReceivedMin != null)
                callPayload.Queries["date_received_min"] = ExpressionConverter.Convert(dateReceivedMin);
            if (focus != null)
                callPayload.Queries["focus"] = ExpressionConverter.Convert(focus);
            if (hasNarrative != null)
                callPayload.Queries["has_narrative"] = ExpressionConverter.Convert(hasNarrative);
            if (issue != null)
                callPayload.Queries["issue"] = ExpressionConverter.Convert(issue);
            callPayload.Queries["lens"] = ExpressionConverter.Convert(lens);
            if (product != null)
                callPayload.Queries["product"] = ExpressionConverter.Convert(product);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            if (submittedVia != null)
                callPayload.Queries["submitted_via"] = ExpressionConverter.Convert(submittedVia);
            if (subLens != null)
                callPayload.Queries["sub_lens"] = ExpressionConverter.Convert(subLens);
            callPayload.Queries["sub_lens_depth"] = Convert.ToString(10);
            if (subLensDepth != null)
                callPayload.Queries["sub_lens_depth"] = ExpressionConverter.Convert(subLensDepth);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (timely != null)
                callPayload.Queries["timely"] = ExpressionConverter.Convert(timely);
            callPayload.Queries["trend_depth"] = Convert.ToString(10);
            if (trendDepth != null)
                callPayload.Queries["trend_depth"] = ExpressionConverter.Convert(trendDepth);
            callPayload.Queries["trend_interval"] = ExpressionConverter.Convert(trendInterval);
            if (zipCode != null)
                callPayload.Queries["zip_code"] = ExpressionConverter.Convert(zipCode);
            return new ApiConnectionAction<TrendsResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "consumercomplaints")]
        public IBodyWorkflowAction<Complaint> GetComplaintById(Expression<Func<int>> complaintId)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(complaintId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Complaint>(callPayload);
        }
    }

    public class ConsumercomplaintsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResult
    {
        [JsonProperty("_meta")]
        public Meta Meta { get; set; }

        [JsonProperty("aggregations")]
        public SearchResultAggregationsType Aggregations { get; set; }

        [JsonProperty("hits")]
        public HitsInfo Hits { get; set; }
    }

    public class Meta
    {
        [JsonProperty("has_data_issue")]
        public bool HasDataIssue { get; set; }

        [JsonProperty("is_data_stale")]
        public bool IsDataStale { get; set; }

        [JsonProperty("is_narrative_stale")]
        public bool IsNarrativeStale { get; set; }

        [JsonProperty("last_indexed")]
        public string LastIndexed { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("total_record_count")]
        public int TotalRecordCount { get; set; }
    }

    public class SearchResultAggregationsType
    {
        [JsonProperty("tags")]
        public Aggregation Tags { get; set; }

        [JsonProperty("company_public_response")]
        public Aggregation CompanyPublicResponse { get; set; }

        [JsonProperty("company_response")]
        public Aggregation CompanyResponse { get; set; }

        [JsonProperty("consumer_consent_provided")]
        public Aggregation ConsumerConsentProvided { get; set; }

        [JsonProperty("consumer_disputed")]
        public Aggregation ConsumerDisputed { get; set; }

        [JsonProperty("has_narrative")]
        public Aggregation HasNarrative { get; set; }

        [JsonProperty("issue")]
        public MultiLevelAggregation Issue { get; set; }

        [JsonProperty("product")]
        public MultiLevelAggregation Product { get; set; }

        [JsonProperty("state")]
        public Aggregation State { get; set; }

        [JsonProperty("submitted_via")]
        public Aggregation SubmittedVia { get; set; }

        [JsonProperty("timely")]
        public Aggregation Timely { get; set; }

        [JsonProperty("zip_code")]
        public Aggregation ZipCode { get; set; }
    }

    public class Aggregation
    {
        [JsonProperty("doc_count")]
        public int DocCount { get; set; }

        [JsonProperty("field")]
        public AggregationFieldType Field { get; set; }
    }

    public class AggregationFieldType
    {
        [JsonProperty("buckets")]
        public Bucket[] Buckets { get; set; }

        [JsonProperty("doc_count_error_upper_bound")]
        public int DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public int SumOtherDocCount { get; set; }
    }

    public class Bucket
    {
        [JsonProperty("doc_count")]
        public int DocCount { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class MultiLevelAggregation
    {
        [JsonProperty("doc_count")]
        public int DocCount { get; set; }

        [JsonProperty("field")]
        public MultiLevelAggregationFieldType Field { get; set; }
    }

    public class MultiLevelAggregationFieldType
    {
        [JsonProperty("buckets")]
        public MultiLevelBucket[] Buckets { get; set; }

        [JsonProperty("doc_count_error_upper_bound")]
        public int DocCountErrorUpperBound { get; set; }

        [JsonProperty("sum_other_doc_count")]
        public int SumOtherDocCount { get; set; }
    }

    public class MultiLevelBucket
    {
        [JsonProperty("doc_count")]
        public int DocCount { get; set; }

        [JsonProperty("field.raw")]
        public MultiLevelBucketFieldRawType FieldRaw { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class MultiLevelBucketFieldRawType
    {
        [JsonProperty("buckets")]
        public Aggregation[] Buckets { get; set; }
    }

    public class HitsInfo
    {
        [JsonProperty("hits")]
        public Hit[] Hits { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("total")]
        public HitsTotalType Total { get; set; }
    }

    public class Hit
    {
        [JsonProperty("_source")]
        public Complaint Source { get; set; }
    }

    public class Complaint
    {
        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company_public_response")]
        public string CompanyPublicResponse { get; set; }

        [JsonProperty("company_response")]
        public string CompanyResponse { get; set; }

        [JsonProperty("complaint_id")]
        public string ComplaintID { get; set; }

        [JsonProperty("complaint_what_happened")]
        public string ComplaintWhatHappened { get; set; }

        [JsonProperty("consumer_consent_provided")]
        public string ConsumerConsentProvided { get; set; }

        [JsonProperty("consumer_disputed")]
        public string ConsumerDisputed { get; set; }

        [JsonProperty("date_received")]
        public string DateReceived { get; set; }

        [JsonProperty("date_sent_to_company")]
        public string DateSentToCompany { get; set; }

        [JsonProperty("has_narrative")]
        public bool HasNarrative { get; set; }

        [JsonProperty("issue")]
        public string Issue { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("sub_issue")]
        public string SubIssue { get; set; }

        [JsonProperty("sub_product")]
        public string SubProduct { get; set; }

        [JsonProperty("submitted_via")]
        public string SubmittedVia { get; set; }

        [JsonProperty("timely")]
        public string Timely { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }
    }

    public class HitsTotalType
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public enum fieldInput
    {
        [EnumMember(Value = "complaint_what_happened")]
        ComplaintWhatHappened,
        [EnumMember(Value = "company_public_response")]
        CompanyPublicResponse,
        [EnumMember(Value = "all")]
        All
    }

    public enum sortInput
    {
        [EnumMember(Value = "relevance_desc")]
        RelevanceDescending,
        [EnumMember(Value = "relevance_asc")]
        RelevanceAscending,
        [EnumMember(Value = "created_date_desc")]
        CreatedDateDescending,
        [EnumMember(Value = "created_date_asc")]
        CreatedDateAscending
    }

    public enum companyPublicResponseInput
    {
        [EnumMember(Value = "Company has responded to the consumer and the CFPB and chooses not to provide a public response")]
        CompanyHasRespondedToTheConsumerAndTheCFPBAndChoosesNotToProvideAPublicResponse,
        [EnumMember(Value = "Company believes it acted appropriately as authorized by contract or law")]
        CompanyBelievesItActedAppropriatelyAsAuthorizedByContractOrLaw,
        [EnumMember(Value = "Company believes complaint caused principally by actions of third party outside the control or direction of the company")]
        CompanyBelievesComplaintCausedPrincipallyByActionsOfThirdPartyOutsideTheControlOrDirectionOfTheCompany,
        [EnumMember(Value = "Company believes the complaint is the result of a misunderstanding")]
        CompanyBelievesTheComplaintIsTheResultOfAMisunderstanding,
        [EnumMember(Value = "Company disputes the facts presented in the complaint")]
        CompanyDisputesTheFactsPresentedInTheComplaint,
        [EnumMember(Value = "Company can't verify or dispute the facts in the complaint")]
        CompanyCanTVerifyOrDisputeTheFactsInTheComplaint,
        [EnumMember(Value = "Company believes the complaint provided an opportunity to answer consumer's questions")]
        CompanyBelievesTheComplaintProvidedAnOpportunityToAnswerConsumerSQuestions,
        [EnumMember(Value = "Company believes complaint is the result of an isolated error")]
        CompanyBelievesComplaintIsTheResultOfAnIsolatedError,
        [EnumMember(Value = "Company believes complaint represents an opportunity for improvement to better serve consumers")]
        CompanyBelievesComplaintRepresentsAnOpportunityForImprovementToBetterServeConsumers,
        [EnumMember(Value = "Company believes complaint relates to a discontinued policy or procedure")]
        CompanyBelievesComplaintRelatesToADiscontinuedPolicyOrProcedure
    }

    public enum consumerConsentProvidedInput
    {
        [EnumMember(Value = "Consent not provided")]
        ConsentNotProvided,
        [EnumMember(Value = "Consent provided")]
        ConsentProvided,
        Other,
        [EnumMember(Value = "N/A")]
        NA,
        [EnumMember(Value = "Consent withdrawn")]
        ConsentWithdrawn
    }

    public enum hasNarrativeInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum issueInput
    {
        Advertising,
        [EnumMember(Value = "Advertising and marketing, including promotional offers")]
        AdvertisingAndMarketingIncludingPromotionalOffers,
        [EnumMember(Value = "Advertising and marketing, including promotional offers Confusing or misleading advertising about the credit card")]
        AdvertisingAndMarketingIncludingPromotionalOffersConfusingOrMisleadingAdvertisingAboutTheCreditCard,
        [EnumMember(Value = "Advertising and marketing, including promotional offers Didn't receive advertised or promotional terms")]
        AdvertisingAndMarketingIncludingPromotionalOffersDidnTReceiveAdvertisedOrPromotionalTerms,
        [EnumMember(Value = "Advertising Changes in terms from what was offered or advertised")]
        AdvertisingChangesInTermsFromWhatWasOfferedOrAdvertised,
        [EnumMember(Value = "Advertising Confusing or misleading advertising about the card")]
        AdvertisingConfusingOrMisleadingAdvertisingAboutTheCard,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgage,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Application denials")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageApplicationDenials,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Changes in loan terms during the application process")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageChangesInLoanTermsDuringTheApplicationProcess,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Confusing or misleading advertising or marketing")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageConfusingOrMisleadingAdvertisingOrMarketing,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Delays in the application process")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageDelaysInTheApplicationProcess,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Fees or costs during the application process")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageFeesOrCostsDuringTheApplicationProcess,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Loan estimate or other related disclosures")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageLoanEstimateOrOtherRelatedDisclosures,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Negative impact of inaccurate appraisal")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageNegativeImpactOfInaccurateAppraisal,
        [EnumMember(Value = "Applying for a mortgage or refinancing an existing mortgage Trying to communicate with the company to fix an issue with the application process")]
        ApplyingForAMortgageOrRefinancingAnExistingMortgageTryingToCommunicateWithTheCompanyToFixAnIssueWithTheApplicationProcess,
        [EnumMember(Value = "Attempts to collect debt not owed")]
        AttemptsToCollectDebtNotOwed,
        [EnumMember(Value = "Attempts to collect debt not owed Debt is not yours")]
        AttemptsToCollectDebtNotOwedDebtIsNotYours,
        [EnumMember(Value = "Attempts to collect debt not owed Debt was already discharged in bankruptcy and is no longer owed")]
        AttemptsToCollectDebtNotOwedDebtWasAlreadyDischargedInBankruptcyAndIsNoLongerOwed,
        [EnumMember(Value = "Attempts to collect debt not owed Debt was paid")]
        AttemptsToCollectDebtNotOwedDebtWasPaid,
        [EnumMember(Value = "Attempts to collect debt not owed Debt was result of identity theft")]
        AttemptsToCollectDebtNotOwedDebtWasResultOfIdentityTheft,
        [EnumMember(Value = "Can't contact lender or servicer")]
        CanTContactLenderOrServicer,
        [EnumMember(Value = "Can't stop withdrawals from your bank account")]
        CanTStopWithdrawalsFromYourBankAccount,
        [EnumMember(Value = "Charged fees or interest you didn't expect")]
        ChargedFeesOrInterestYouDidnTExpect,
        [EnumMember(Value = "Charged upfront or unexpected fees")]
        ChargedUpfrontOrUnexpectedFees,
        [EnumMember(Value = "Closing an account")]
        ClosingAnAccount,
        [EnumMember(Value = "Closing an account Can't close your account")]
        ClosingAnAccountCanTCloseYourAccount,
        [EnumMember(Value = "Closing an account Company closed your account")]
        ClosingAnAccountCompanyClosedYourAccount,
        [EnumMember(Value = "Closing an account Fees charged for closing account")]
        ClosingAnAccountFeesChargedForClosingAccount,
        [EnumMember(Value = "Closing an account Funds not received from closed account")]
        ClosingAnAccountFundsNotReceivedFromClosedAccount,
        [EnumMember(Value = "Closing on a mortgage")]
        ClosingOnAMortgage,
        [EnumMember(Value = "Closing on a mortgage Changes in loan terms during or after closing")]
        ClosingOnAMortgageChangesInLoanTermsDuringOrAfterClosing,
        [EnumMember(Value = "Closing on a mortgage Closing disclosure or other related disclosures")]
        ClosingOnAMortgageClosingDisclosureOrOtherRelatedDisclosures,
        [EnumMember(Value = "Closing on a mortgage Delays with the closing process")]
        ClosingOnAMortgageDelaysWithTheClosingProcess,
        [EnumMember(Value = "Closing on a mortgage Fees or costs after closing")]
        ClosingOnAMortgageFeesOrCostsAfterClosing,
        [EnumMember(Value = "Closing on a mortgage Setting up an escrow account for taxes and insurance")]
        ClosingOnAMortgageSettingUpAnEscrowAccountForTaxesAndInsurance,
        [EnumMember(Value = "Closing on a mortgage Trying to communicate with the company to fix an issue with the loan closing")]
        ClosingOnAMortgageTryingToCommunicateWithTheCompanyToFixAnIssueWithTheLoanClosing,
        [EnumMember(Value = "Closing your account")]
        ClosingYourAccount,
        [EnumMember(Value = "Closing your account Can't close your account")]
        ClosingYourAccountCanTCloseYourAccount,
        [EnumMember(Value = "Closing your account Company closed your account")]
        ClosingYourAccountCompanyClosedYourAccount,
        [EnumMember(Value = "Communication tactics")]
        CommunicationTactics,
        [EnumMember(Value = "Communication tactics Called before 8am or after 9pm")]
        CommunicationTacticsCalledBefore8amOrAfter9pm,
        [EnumMember(Value = "Communication tactics Contacted before 8am or after 9pm")]
        CommunicationTacticsContactedBefore8amOrAfter9pm,
        [EnumMember(Value = "Communication tactics Frequent or repeated calls")]
        CommunicationTacticsFrequentOrRepeatedCalls,
        [EnumMember(Value = "Communication tactics Frequent or repeated messages")]
        CommunicationTacticsFrequentOrRepeatedMessages,
        [EnumMember(Value = "Communication tactics Used obscene, profane, or other abusive language")]
        CommunicationTacticsUsedObsceneProfaneOrOtherAbusiveLanguage,
        [EnumMember(Value = "Communication tactics You told them to stop contacting you, but they keep trying")]
        CommunicationTacticsYouToldThemToStopContactingYouButTheyKeepTrying,
        [EnumMember(Value = "Confusing or misleading advertising or marketing")]
        ConfusingOrMisleadingAdvertisingOrMarketing,
        [EnumMember(Value = "Confusing or missing disclosures")]
        ConfusingOrMissingDisclosures,
        [EnumMember(Value = "Credit limit changed")]
        CreditLimitChanged,
        [EnumMember(Value = "Credit monitoring or identity theft protection services")]
        CreditMonitoringOrIdentityTheftProtectionServices,
        [EnumMember(Value = "Credit monitoring or identity theft protection services Billing dispute for services")]
        CreditMonitoringOrIdentityTheftProtectionServicesBillingDisputeForServices,
        [EnumMember(Value = "Credit monitoring or identity theft protection services Didn't receive services that were advertised")]
        CreditMonitoringOrIdentityTheftProtectionServicesDidnTReceiveServicesThatWereAdvertised,
        [EnumMember(Value = "Credit monitoring or identity theft protection services Problem canceling credit monitoring or identify theft protection service")]
        CreditMonitoringOrIdentityTheftProtectionServicesProblemCancelingCreditMonitoringOrIdentifyTheftProtectionService,
        [EnumMember(Value = "Credit monitoring or identity theft protection services Problem with product or service terms changing")]
        CreditMonitoringOrIdentityTheftProtectionServicesProblemWithProductOrServiceTermsChanging,
        [EnumMember(Value = "Credit monitoring or identity theft protection services Received unwanted marketing or advertising")]
        CreditMonitoringOrIdentityTheftProtectionServicesReceivedUnwantedMarketingOrAdvertising,
        [EnumMember(Value = "Dealing with your lender or servicer")]
        DealingWithYourLenderOrServicer,
        [EnumMember(Value = "Dealing with your lender or servicer Co-signer")]
        DealingWithYourLenderOrServicerCoSigner,
        [EnumMember(Value = "Dealing with your lender or servicer Don't agree with the fees charged")]
        DealingWithYourLenderOrServicerDonTAgreeWithTheFeesCharged,
        [EnumMember(Value = "Dealing with your lender or servicer Keep getting calls about your loan")]
        DealingWithYourLenderOrServicerKeepGettingCallsAboutYourLoan,
        [EnumMember(Value = "Dealing with your lender or servicer Need information about your loan balance or loan terms")]
        DealingWithYourLenderOrServicerNeedInformationAboutYourLoanBalanceOrLoanTerms,
        [EnumMember(Value = "Dealing with your lender or servicer Problem with customer service")]
        DealingWithYourLenderOrServicerProblemWithCustomerService,
        [EnumMember(Value = "Dealing with your lender or servicer Received bad information about your loan")]
        DealingWithYourLenderOrServicerReceivedBadInformationAboutYourLoan,
        [EnumMember(Value = "Dealing with your lender or servicer Trouble with how payments are being handled")]
        DealingWithYourLenderOrServicerTroubleWithHowPaymentsAreBeingHandled,
        [EnumMember(Value = "Didn't provide services promised")]
        DidnTProvideServicesPromised,
        [EnumMember(Value = "Electronic communications")]
        ElectronicCommunications,
        [EnumMember(Value = "Electronic communications Contacted before 8am or after 9pm")]
        ElectronicCommunicationsContactedBefore8amOrAfter9pm,
        [EnumMember(Value = "Electronic communications Frequent or repeated messages")]
        ElectronicCommunicationsFrequentOrRepeatedMessages,
        [EnumMember(Value = "Electronic communications Used obscene, profane, or other abusive language")]
        ElectronicCommunicationsUsedObsceneProfaneOrOtherAbusiveLanguage,
        [EnumMember(Value = "Electronic communications You told them to stop contacting you, but they keep trying")]
        ElectronicCommunicationsYouToldThemToStopContactingYouButTheyKeepTrying,
        [EnumMember(Value = "Excessive fees")]
        ExcessiveFees,
        [EnumMember(Value = "False statements or representation")]
        FalseStatementsOrRepresentation,
        [EnumMember(Value = "False statements or representation Attempted to collect wrong amount")]
        FalseStatementsOrRepresentationAttemptedToCollectWrongAmount,
        [EnumMember(Value = "False statements or representation Impersonated attorney, law enforcement, or government official")]
        FalseStatementsOrRepresentationImpersonatedAttorneyLawEnforcementOrGovernmentOfficial,
        [EnumMember(Value = "False statements or representation Indicated you were committing crime by not paying debt")]
        FalseStatementsOrRepresentationIndicatedYouWereCommittingCrimeByNotPayingDebt,
        [EnumMember(Value = "False statements or representation Told you not to respond to a lawsuit they filed against you")]
        FalseStatementsOrRepresentationToldYouNotToRespondToALawsuitTheyFiledAgainstYou,
        [EnumMember(Value = "Fees or interest")]
        FeesOrInterest,
        [EnumMember(Value = "Fees or interest Charged too much interest")]
        FeesOrInterestChargedTooMuchInterest,
        [EnumMember(Value = "Fees or interest Problem with fees")]
        FeesOrInterestProblemWithFees,
        [EnumMember(Value = "Fees or interest Unexpected increase in interest rate")]
        FeesOrInterestUnexpectedIncreaseInInterestRate,
        [EnumMember(Value = "Fraud or scam")]
        FraudOrScam,
        [EnumMember(Value = "Getting a credit card")]
        GettingACreditCard,
        [EnumMember(Value = "Getting a credit card Application denied")]
        GettingACreditCardApplicationDenied,
        [EnumMember(Value = "Getting a credit card Card opened as result of identity theft or fraud")]
        GettingACreditCardCardOpenedAsResultOfIdentityTheftOrFraud,
        [EnumMember(Value = "Getting a credit card Card opened without my consent or knowledge")]
        GettingACreditCardCardOpenedWithoutMyConsentOrKnowledge,
        [EnumMember(Value = "Getting a credit card Delay in processing application")]
        GettingACreditCardDelayInProcessingApplication,
        [EnumMember(Value = "Getting a credit card Problem getting a working replacement card")]
        GettingACreditCardProblemGettingAWorkingReplacementCard,
        [EnumMember(Value = "Getting a credit card Sent card you never applied for")]
        GettingACreditCardSentCardYouNeverAppliedFor,
        [EnumMember(Value = "Getting a line of credit")]
        GettingALineOfCredit,
        [EnumMember(Value = "Getting a loan")]
        GettingALoan,
        [EnumMember(Value = "Getting a loan or lease")]
        GettingALoanOrLease,
        [EnumMember(Value = "Getting a loan or lease Changes in terms mid-deal or after closing")]
        GettingALoanOrLeaseChangesInTermsMidDealOrAfterClosing,
        [EnumMember(Value = "Getting a loan or lease Confusing or misleading advertising")]
        GettingALoanOrLeaseConfusingOrMisleadingAdvertising,
        [EnumMember(Value = "Getting a loan or lease Confusing or misleading advertising or marketing")]
        GettingALoanOrLeaseConfusingOrMisleadingAdvertisingOrMarketing,
        [EnumMember(Value = "Getting a loan or lease Credit denial")]
        GettingALoanOrLeaseCreditDenial,
        [EnumMember(Value = "Getting a loan or lease Did not receive car title")]
        GettingALoanOrLeaseDidNotReceiveCarTitle,
        [EnumMember(Value = "Getting a loan or lease Fraudulent loan")]
        GettingALoanOrLeaseFraudulentLoan,
        [EnumMember(Value = "Getting a loan or lease High-pressure sales tactics")]
        GettingALoanOrLeaseHighPressureSalesTactics,
        [EnumMember(Value = "Getting a loan or lease Loan opened without my consent or knowledge")]
        GettingALoanOrLeaseLoanOpenedWithoutMyConsentOrKnowledge,
        [EnumMember(Value = "Getting a loan or lease Problem with a trade-in")]
        GettingALoanOrLeaseProblemWithATradeIn,
        [EnumMember(Value = "Getting a loan or lease Problem with additional add-on products or services purchased with the loan")]
        GettingALoanOrLeaseProblemWithAdditionalAddOnProductsOrServicesPurchasedWithTheLoan,
        [EnumMember(Value = "Getting a loan or lease Problem with signing the paperwork")]
        GettingALoanOrLeaseProblemWithSigningThePaperwork,
        [EnumMember(Value = "Getting a loan Changes in terms mid-deal or after closing")]
        GettingALoanChangesInTermsMidDealOrAfterClosing,
        [EnumMember(Value = "Getting a loan Confusing or misleading advertising")]
        GettingALoanConfusingOrMisleadingAdvertising,
        [EnumMember(Value = "Getting a loan Denied loan")]
        GettingALoanDeniedLoan,
        [EnumMember(Value = "Getting a loan Fraudulent loan")]
        GettingALoanFraudulentLoan,
        [EnumMember(Value = "Getting a loan High pressure sales tactics or recruiting")]
        GettingALoanHighPressureSalesTacticsOrRecruiting,
        [EnumMember(Value = "Getting a loan Issues with financial aid services")]
        GettingALoanIssuesWithFinancialAidServices,
        [EnumMember(Value = "Getting a loan Loan opened without my consent or knowledge")]
        GettingALoanLoanOpenedWithoutMyConsentOrKnowledge,
        [EnumMember(Value = "Getting a loan Problem with signing the paperwork")]
        GettingALoanProblemWithSigningThePaperwork,
        [EnumMember(Value = "Getting a loan Problem with the interest rate")]
        GettingALoanProblemWithTheInterestRate,
        [EnumMember(Value = "Getting a loan Qualified for a better loan than the one offered")]
        GettingALoanQualifiedForABetterLoanThanTheOneOffered,
        [EnumMember(Value = "Getting the loan")]
        GettingTheLoan,
        [EnumMember(Value = "Identity theft protection or other monitoring services")]
        IdentityTheftProtectionOrOtherMonitoringServices,
        [EnumMember(Value = "Identity theft protection or other monitoring services Billing dispute for services")]
        IdentityTheftProtectionOrOtherMonitoringServicesBillingDisputeForServices,
        [EnumMember(Value = "Identity theft protection or other monitoring services Didn't receive services that were advertised")]
        IdentityTheftProtectionOrOtherMonitoringServicesDidnTReceiveServicesThatWereAdvertised,
        [EnumMember(Value = "Identity theft protection or other monitoring services Problem canceling credit monitoring or identify theft protection service")]
        IdentityTheftProtectionOrOtherMonitoringServicesProblemCancelingCreditMonitoringOrIdentifyTheftProtectionService,
        [EnumMember(Value = "Identity theft protection or other monitoring services Problem with product or service terms changing")]
        IdentityTheftProtectionOrOtherMonitoringServicesProblemWithProductOrServiceTermsChanging,
        [EnumMember(Value = "Identity theft protection or other monitoring services Received unwanted marketing or advertising")]
        IdentityTheftProtectionOrOtherMonitoringServicesReceivedUnwantedMarketingOrAdvertising,
        [EnumMember(Value = "Improper use of your report")]
        ImproperUseOfYourReport,
        [EnumMember(Value = "Improper use of your report Credit inquiries on your report that you don't recognize")]
        ImproperUseOfYourReportCreditInquiriesOnYourReportThatYouDonTRecognize,
        [EnumMember(Value = "Improper use of your report Received unsolicited financial product or insurance offers after opting out")]
        ImproperUseOfYourReportReceivedUnsolicitedFinancialProductOrInsuranceOffersAfterOptingOut,
        [EnumMember(Value = "Improper use of your report Report provided to employer without your written authorization")]
        ImproperUseOfYourReportReportProvidedToEmployerWithoutYourWrittenAuthorization,
        [EnumMember(Value = "Improper use of your report Reporting company used your report improperly")]
        ImproperUseOfYourReportReportingCompanyUsedYourReportImproperly,
        [EnumMember(Value = "Incorrect exchange rate")]
        IncorrectExchangeRate,
        [EnumMember(Value = "Incorrect information on your report")]
        IncorrectInformationOnYourReport,
        [EnumMember(Value = "Incorrect information on your report Account information incorrect")]
        IncorrectInformationOnYourReportAccountInformationIncorrect,
        [EnumMember(Value = "Incorrect information on your report Account status incorrect")]
        IncorrectInformationOnYourReportAccountStatusIncorrect,
        [EnumMember(Value = "Incorrect information on your report Information belongs to someone else")]
        IncorrectInformationOnYourReportInformationBelongsToSomeoneElse,
        [EnumMember(Value = "Incorrect information on your report Information is incorrect")]
        IncorrectInformationOnYourReportInformationIsIncorrect,
        [EnumMember(Value = "Incorrect information on your report Information is missing that should be on the report")]
        IncorrectInformationOnYourReportInformationIsMissingThatShouldBeOnTheReport,
        [EnumMember(Value = "Incorrect information on your report Information that should be on the report is missing")]
        IncorrectInformationOnYourReportInformationThatShouldBeOnTheReportIsMissing,
        [EnumMember(Value = "Incorrect information on your report Old information reappears or never goes away")]
        IncorrectInformationOnYourReportOldInformationReappearsOrNeverGoesAway,
        [EnumMember(Value = "Incorrect information on your report Personal information incorrect")]
        IncorrectInformationOnYourReportPersonalInformationIncorrect,
        [EnumMember(Value = "Incorrect information on your report Public record information inaccurate")]
        IncorrectInformationOnYourReportPublicRecordInformationInaccurate,
        [EnumMember(Value = "Issue where my lender is my school")]
        IssueWhereMyLenderIsMySchool,
        [EnumMember(Value = "Issue where my lender is my school Cannot graduate, receive diploma, or get transcript due to money owed")]
        IssueWhereMyLenderIsMySchoolCannotGraduateReceiveDiplomaOrGetTranscriptDueToMoneyOwed,
        [EnumMember(Value = "Issue where my lender is my school Issues with fees connected to the loan")]
        IssueWhereMyLenderIsMySchoolIssuesWithFeesConnectedToTheLoan,
        [EnumMember(Value = "Issue with income share agreement")]
        IssueWithIncomeShareAgreement,
        [EnumMember(Value = "Issue with income share agreement Billing or statement issues")]
        IssueWithIncomeShareAgreementBillingOrStatementIssues,
        [EnumMember(Value = "Issue with income share agreement Dealing with provider of income share agreement")]
        IssueWithIncomeShareAgreementDealingWithProviderOfIncomeShareAgreement,
        [EnumMember(Value = "Issue with income share agreement Marketing or disclosure issues")]
        IssueWithIncomeShareAgreementMarketingOrDisclosureIssues,
        [EnumMember(Value = "Issue with income share agreement Payment issues")]
        IssueWithIncomeShareAgreementPaymentIssues,
        [EnumMember(Value = "Issues with repayment")]
        IssuesWithRepayment,
        [EnumMember(Value = "Loan payment wasn't credited to your account")]
        LoanPaymentWasnTCreditedToYourAccount,
        [EnumMember(Value = "Lost or stolen check")]
        LostOrStolenCheck,
        [EnumMember(Value = "Lost or stolen money order")]
        LostOrStolenMoneyOrder,
        [EnumMember(Value = "Lost or stolen refund")]
        LostOrStolenRefund,
        [EnumMember(Value = "Managing an account")]
        ManagingAnAccount,
        [EnumMember(Value = "Managing an account Banking errors")]
        ManagingAnAccountBankingErrors,
        [EnumMember(Value = "Managing an account Cashing a check")]
        ManagingAnAccountCashingACheck,
        [EnumMember(Value = "Managing an account Deposits and withdrawals")]
        ManagingAnAccountDepositsAndWithdrawals,
        [EnumMember(Value = "Managing an account Deposits or withdrawals")]
        ManagingAnAccountDepositsOrWithdrawals,
        [EnumMember(Value = "Managing an account Fee problem")]
        ManagingAnAccountFeeProblem,
        [EnumMember(Value = "Managing an account Funds not handled or disbursed as instructed")]
        ManagingAnAccountFundsNotHandledOrDisbursedAsInstructed,
        [EnumMember(Value = "Managing an account Problem accessing account")]
        ManagingAnAccountProblemAccessingAccount,
        [EnumMember(Value = "Managing an account Problem making or receiving payments")]
        ManagingAnAccountProblemMakingOrReceivingPayments,
        [EnumMember(Value = "Managing an account Problem using a debit or ATM card")]
        ManagingAnAccountProblemUsingADebitOrATMCard,
        [EnumMember(Value = "Managing an account Problem with fees or penalties")]
        ManagingAnAccountProblemWithFeesOrPenalties,
        [EnumMember(Value = "Managing an account Problem with renewal")]
        ManagingAnAccountProblemWithRenewal,
        [EnumMember(Value = "Managing the loan or lease")]
        ManagingTheLoanOrLease,
        [EnumMember(Value = "Managing the loan or lease Billing problem")]
        ManagingTheLoanOrLeaseBillingProblem,
        [EnumMember(Value = "Managing the loan or lease Loan sold or transferred to another company")]
        ManagingTheLoanOrLeaseLoanSoldOrTransferredToAnotherCompany,
        [EnumMember(Value = "Managing the loan or lease Problem with additional products or services purchased with the loan")]
        ManagingTheLoanOrLeaseProblemWithAdditionalProductsOrServicesPurchasedWithTheLoan,
        [EnumMember(Value = "Managing the loan or lease Problem with fees charged")]
        ManagingTheLoanOrLeaseProblemWithFeesCharged,
        [EnumMember(Value = "Managing the loan or lease Problem with the interest rate")]
        ManagingTheLoanOrLeaseProblemWithTheInterestRate,
        [EnumMember(Value = "Managing, opening, or closing your mobile wallet account")]
        ManagingOpeningOrClosingYourMobileWalletAccount,
        [EnumMember(Value = "Money was not available when promised")]
        MoneyWasNotAvailableWhenPromised,
        [EnumMember(Value = "Money was taken from your bank account on the wrong day or for the wrong amount")]
        MoneyWasTakenFromYourBankAccountOnTheWrongDayOrForTheWrongAmount,
        [EnumMember(Value = "Opening an account")]
        OpeningAnAccount,
        [EnumMember(Value = "Opening an account Account opened as a result of fraud")]
        OpeningAnAccountAccountOpenedAsAResultOfFraud,
        [EnumMember(Value = "Opening an account Account opened without my consent or knowledge")]
        OpeningAnAccountAccountOpenedWithoutMyConsentOrKnowledge,
        [EnumMember(Value = "Opening an account Confusing or missing disclosures")]
        OpeningAnAccountConfusingOrMissingDisclosures,
        [EnumMember(Value = "Opening an account Didn't receive terms that were advertised")]
        OpeningAnAccountDidnTReceiveTermsThatWereAdvertised,
        [EnumMember(Value = "Opening an account Unable to open an account")]
        OpeningAnAccountUnableToOpenAnAccount,
        [EnumMember(Value = "Other features, terms, or problems")]
        OtherFeaturesTermsOrProblems,
        [EnumMember(Value = "Other features, terms, or problems Add-on products and services")]
        OtherFeaturesTermsOrProblemsAddOnProductsAndServices,
        [EnumMember(Value = "Other features, terms, or problems Credit card company forcing arbitration")]
        OtherFeaturesTermsOrProblemsCreditCardCompanyForcingArbitration,
        [EnumMember(Value = "Other features, terms, or problems Other problem")]
        OtherFeaturesTermsOrProblemsOtherProblem,
        [EnumMember(Value = "Other features, terms, or problems Privacy issues")]
        OtherFeaturesTermsOrProblemsPrivacyIssues,
        [EnumMember(Value = "Other features, terms, or problems Problem with balance transfer")]
        OtherFeaturesTermsOrProblemsProblemWithBalanceTransfer,
        [EnumMember(Value = "Other features, terms, or problems Problem with cash advances")]
        OtherFeaturesTermsOrProblemsProblemWithCashAdvances,
        [EnumMember(Value = "Other features, terms, or problems Problem with convenience check")]
        OtherFeaturesTermsOrProblemsProblemWithConvenienceCheck,
        [EnumMember(Value = "Other features, terms, or problems Problem with customer service")]
        OtherFeaturesTermsOrProblemsProblemWithCustomerService,
        [EnumMember(Value = "Other features, terms, or problems Problem with rewards from credit card")]
        OtherFeaturesTermsOrProblemsProblemWithRewardsFromCreditCard,
        [EnumMember(Value = "Other service problem")]
        OtherServiceProblem,
        [EnumMember(Value = "Other transaction problem")]
        OtherTransactionProblem,
        [EnumMember(Value = "Overdraft, savings, or rewards features")]
        OverdraftSavingsOrRewardsFeatures,
        [EnumMember(Value = "Problem adding money")]
        ProblemAddingMoney,
        [EnumMember(Value = "Problem caused by your funds being low")]
        ProblemCausedByYourFundsBeingLow,
        [EnumMember(Value = "Problem caused by your funds being low Bounced checks or returned payments")]
        ProblemCausedByYourFundsBeingLowBouncedChecksOrReturnedPayments,
        [EnumMember(Value = "Problem caused by your funds being low Late or other fees")]
        ProblemCausedByYourFundsBeingLowLateOrOtherFees,
        [EnumMember(Value = "Problem caused by your funds being low Non-sufficient funds and associated fees")]
        ProblemCausedByYourFundsBeingLowNonSufficientFundsAndAssociatedFees,
        [EnumMember(Value = "Problem caused by your funds being low Overdrafts and overdraft fees")]
        ProblemCausedByYourFundsBeingLowOverdraftsAndOverdraftFees,
        [EnumMember(Value = "Problem getting a card or closing an account")]
        ProblemGettingACardOrClosingAnAccount,
        [EnumMember(Value = "Problem getting a card or closing an account Don't want a card provided by your employer or the government")]
        ProblemGettingACardOrClosingAnAccountDonTWantACardProvidedByYourEmployerOrTheGovernment,
        [EnumMember(Value = "Problem getting a card or closing an account Trouble closing card")]
        ProblemGettingACardOrClosingAnAccountTroubleClosingCard,
        [EnumMember(Value = "Problem getting a card or closing an account Trouble getting a working replacement card")]
        ProblemGettingACardOrClosingAnAccountTroubleGettingAWorkingReplacementCard,
        [EnumMember(Value = "Problem getting a card or closing an account Trouble getting, activating, or registering a card")]
        ProblemGettingACardOrClosingAnAccountTroubleGettingActivatingOrRegisteringACard,
        [EnumMember(Value = "Problem when making payments")]
        ProblemWhenMakingPayments,
        [EnumMember(Value = "Problem when making payments Problem during payment process")]
        ProblemWhenMakingPaymentsProblemDuringPaymentProcess,
        [EnumMember(Value = "Problem when making payments You never received your bill or did not know a payment was due")]
        ProblemWhenMakingPaymentsYouNeverReceivedYourBillOrDidNotKnowAPaymentWasDue,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue")]
        ProblemWithACompanySInvestigationIntoAnExistingIssue,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue Difficulty submitting a dispute or getting information about a dispute over the phone")]
        ProblemWithACompanySInvestigationIntoAnExistingIssueDifficultySubmittingADisputeOrGettingInformationAboutADisputeOverThePhone,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue Investigation took more than 30 days")]
        ProblemWithACompanySInvestigationIntoAnExistingIssueInvestigationTookMoreThan30Days,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue Problem with personal statement of dispute")]
        ProblemWithACompanySInvestigationIntoAnExistingIssueProblemWithPersonalStatementOfDispute,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue Their investigation did not fix an error on your report")]
        ProblemWithACompanySInvestigationIntoAnExistingIssueTheirInvestigationDidNotFixAnErrorOnYourReport,
        [EnumMember(Value = "Problem with a company's investigation into an existing issue Was not notified of investigation status or results")]
        ProblemWithACompanySInvestigationIntoAnExistingIssueWasNotNotifiedOfInvestigationStatusOrResults,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem")]
        ProblemWithACompanySInvestigationIntoAnExistingProblem,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem Difficulty submitting a dispute or getting information about a dispute over the phone")]
        ProblemWithACompanySInvestigationIntoAnExistingProblemDifficultySubmittingADisputeOrGettingInformationAboutADisputeOverThePhone,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem Investigation took more than 30 days")]
        ProblemWithACompanySInvestigationIntoAnExistingProblemInvestigationTookMoreThan30Days,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem Problem with personal statement of dispute")]
        ProblemWithACompanySInvestigationIntoAnExistingProblemProblemWithPersonalStatementOfDispute,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem Their investigation did not fix an error on your report")]
        ProblemWithACompanySInvestigationIntoAnExistingProblemTheirInvestigationDidNotFixAnErrorOnYourReport,
        [EnumMember(Value = "Problem with a company's investigation into an existing problem Was not notified of investigation status or results")]
        ProblemWithACompanySInvestigationIntoAnExistingProblemWasNotNotifiedOfInvestigationStatusOrResults,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblem,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem Difficulty submitting a dispute or getting information about a dispute over the phone")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblemDifficultySubmittingADisputeOrGettingInformationAboutADisputeOverThePhone,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem Investigation took more than 30 days")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblemInvestigationTookMoreThan30Days,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem Problem with personal statement of dispute")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblemProblemWithPersonalStatementOfDispute,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem Their investigation did not fix an error on your report")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblemTheirInvestigationDidNotFixAnErrorOnYourReport,
        [EnumMember(Value = "Problem with a credit reporting company's investigation into an existing problem Was not notified of investigation status or results")]
        ProblemWithACreditReportingCompanySInvestigationIntoAnExistingProblemWasNotNotifiedOfInvestigationStatusOrResults,
        [EnumMember(Value = "Problem with a lender or other company charging your account")]
        ProblemWithALenderOrOtherCompanyChargingYourAccount,
        [EnumMember(Value = "Problem with a lender or other company charging your account Can't stop withdrawals from your account")]
        ProblemWithALenderOrOtherCompanyChargingYourAccountCanTStopWithdrawalsFromYourAccount,
        [EnumMember(Value = "Problem with a lender or other company charging your account Money was taken from your account on the wrong day or for the wrong amount")]
        ProblemWithALenderOrOtherCompanyChargingYourAccountMoneyWasTakenFromYourAccountOnTheWrongDayOrForTheWrongAmount,
        [EnumMember(Value = "Problem with a lender or other company charging your account Transaction was not authorized")]
        ProblemWithALenderOrOtherCompanyChargingYourAccountTransactionWasNotAuthorized,
        [EnumMember(Value = "Problem with a purchase or transfer")]
        ProblemWithAPurchaseOrTransfer,
        [EnumMember(Value = "Problem with a purchase or transfer Card company isn't resolving a dispute about a purchase or transfer")]
        ProblemWithAPurchaseOrTransferCardCompanyIsnTResolvingADisputeAboutAPurchaseOrTransfer,
        [EnumMember(Value = "Problem with a purchase or transfer Charged for a purchase or transfer you did not make with the card")]
        ProblemWithAPurchaseOrTransferChargedForAPurchaseOrTransferYouDidNotMakeWithTheCard,
        [EnumMember(Value = "Problem with a purchase or transfer Overcharged for a purchase or transfer you did make with the card")]
        ProblemWithAPurchaseOrTransferOverchargedForAPurchaseOrTransferYouDidMakeWithTheCard,
        [EnumMember(Value = "Problem with a purchase shown on your statement")]
        ProblemWithAPurchaseShownOnYourStatement,
        [EnumMember(Value = "Problem with a purchase shown on your statement Card was charged for something you did not purchase with the card")]
        ProblemWithAPurchaseShownOnYourStatementCardWasChargedForSomethingYouDidNotPurchaseWithTheCard,
        [EnumMember(Value = "Problem with a purchase shown on your statement Credit card company isn't resolving a dispute about a purchase on your statement")]
        ProblemWithAPurchaseShownOnYourStatementCreditCardCompanyIsnTResolvingADisputeAboutAPurchaseOnYourStatement,
        [EnumMember(Value = "Problem with a purchase shown on your statement Overcharged for something you did purchase with the card")]
        ProblemWithAPurchaseShownOnYourStatementOverchargedForSomethingYouDidPurchaseWithTheCard,
        [EnumMember(Value = "Problem with additional add-on products or services")]
        ProblemWithAdditionalAddOnProductsOrServices,
        [EnumMember(Value = "Problem with an overdraft")]
        ProblemWithAnOverdraft,
        [EnumMember(Value = "Problem with an overdraft Overdraft charges")]
        ProblemWithAnOverdraftOverdraftCharges,
        [EnumMember(Value = "Problem with cash advance")]
        ProblemWithCashAdvance,
        [EnumMember(Value = "Problem with customer service")]
        ProblemWithCustomerService,
        [EnumMember(Value = "Problem with fraud alerts or security freezes")]
        ProblemWithFraudAlertsOrSecurityFreezes,
        [EnumMember(Value = "Problem with overdraft")]
        ProblemWithOverdraft,
        [EnumMember(Value = "Problem with overdraft Overdraft charges")]
        ProblemWithOverdraftOverdraftCharges,
        [EnumMember(Value = "Problem with overdraft Was signed up for overdraft on card, but don't want to be")]
        ProblemWithOverdraftWasSignedUpForOverdraftOnCardButDonTWantToBe,
        [EnumMember(Value = "Problem with the payoff process at the end of the loan")]
        ProblemWithThePayoffProcessAtTheEndOfTheLoan,
        [EnumMember(Value = "Problems at the end of the loan or lease")]
        ProblemsAtTheEndOfTheLoanOrLease,
        [EnumMember(Value = "Problems at the end of the loan or lease Excess mileage, damage, or wear fees, or other problem after the lease is finished")]
        ProblemsAtTheEndOfTheLoanOrLeaseExcessMileageDamageOrWearFeesOrOtherProblemAfterTheLeaseIsFinished,
        [EnumMember(Value = "Problems at the end of the loan or lease Problem extending the lease")]
        ProblemsAtTheEndOfTheLoanOrLeaseProblemExtendingTheLease,
        [EnumMember(Value = "Problems at the end of the loan or lease Problem related to refinancing")]
        ProblemsAtTheEndOfTheLoanOrLeaseProblemRelatedToRefinancing,
        [EnumMember(Value = "Problems at the end of the loan or lease Problem when attempting to purchase vehicle at the end of the lease")]
        ProblemsAtTheEndOfTheLoanOrLeaseProblemWhenAttemptingToPurchaseVehicleAtTheEndOfTheLease,
        [EnumMember(Value = "Problems at the end of the loan or lease Problem while selling or giving up the vehicle")]
        ProblemsAtTheEndOfTheLoanOrLeaseProblemWhileSellingOrGivingUpTheVehicle,
        [EnumMember(Value = "Problems at the end of the loan or lease Problem with paying off the loan")]
        ProblemsAtTheEndOfTheLoanOrLeaseProblemWithPayingOffTheLoan,
        [EnumMember(Value = "Problems at the end of the loan or lease Termination fees or other problem when ending the lease early")]
        ProblemsAtTheEndOfTheLoanOrLeaseTerminationFeesOrOtherProblemWhenEndingTheLeaseEarly,
        [EnumMember(Value = "Problems at the end of the loan or lease Unable to receive car title or other problem after the loan is paid off")]
        ProblemsAtTheEndOfTheLoanOrLeaseUnableToReceiveCarTitleOrOtherProblemAfterTheLoanIsPaidOff,
        [EnumMember(Value = "Problems receiving the advance")]
        ProblemsReceivingTheAdvance,
        [EnumMember(Value = "Property was damaged or destroyed property")]
        PropertyWasDamagedOrDestroyedProperty,
        [EnumMember(Value = "Property was sold")]
        PropertyWasSold,
        [EnumMember(Value = "Received a loan you didn't apply for")]
        ReceivedALoanYouDidnTApplyFor,
        Repossession,
        [EnumMember(Value = "Repossession Account reinstatement or redemption after repossession")]
        RepossessionAccountReinstatementOrRedemptionAfterRepossession,
        [EnumMember(Value = "Repossession Company communicating payment assistance or payment extension options")]
        RepossessionCompanyCommunicatingPaymentAssistanceOrPaymentExtensionOptions,
        [EnumMember(Value = "Repossession Company explaining amount owed")]
        RepossessionCompanyExplainingAmountOwed,
        [EnumMember(Value = "Repossession Damage caused or loss of personal items in vehicle during the actual repossession")]
        RepossessionDamageCausedOrLossOfPersonalItemsInVehicleDuringTheActualRepossession,
        [EnumMember(Value = "Repossession Deficiency balance after repossession")]
        RepossessionDeficiencyBalanceAfterRepossession,
        [EnumMember(Value = "Repossession Lender trying to repossess or disable the vehicle")]
        RepossessionLenderTryingToRepossessOrDisableTheVehicle,
        [EnumMember(Value = "Repossession Loan balance remaining after the vehicle is repossessed and sold")]
        RepossessionLoanBalanceRemainingAfterTheVehicleIsRepossessedAndSold,
        [EnumMember(Value = "Repossession Notice to repossess")]
        RepossessionNoticeToRepossess,
        [EnumMember(Value = "Repossession Voluntary repossession")]
        RepossessionVoluntaryRepossession,
        [EnumMember(Value = "Struggling to pay mortgage")]
        StrugglingToPayMortgage,
        [EnumMember(Value = "Struggling to pay mortgage An existing modification, forbearance plan, short sale, or other loss mitigation relief")]
        StrugglingToPayMortgageAnExistingModificationForbearancePlanShortSaleOrOtherLossMitigationRelief,
        [EnumMember(Value = "Struggling to pay mortgage Applying for or obtaining a modification, forbearance plan, short sale, or deed-in-lieu")]
        StrugglingToPayMortgageApplyingForOrObtainingAModificationForbearancePlanShortSaleOrDeedInLieu,
        [EnumMember(Value = "Struggling to pay mortgage Foreclosure")]
        StrugglingToPayMortgageForeclosure,
        [EnumMember(Value = "Struggling to pay mortgage Trying to communicate with the company to fix an issue related to modification, forbearance, short sale, deed-in-lieu, bankruptcy, or foreclosure")]
        StrugglingToPayMortgageTryingToCommunicateWithTheCompanyToFixAnIssueRelatedToModificationForbearanceShortSaleDeedInLieuBankruptcyOrForeclosure,
        [EnumMember(Value = "Struggling to pay your bill")]
        StrugglingToPayYourBill,
        [EnumMember(Value = "Struggling to pay your bill Credit card company won't work with you while you're going through financial hardship")]
        StrugglingToPayYourBillCreditCardCompanyWonTWorkWithYouWhileYouReGoingThroughFinancialHardship,
        [EnumMember(Value = "Struggling to pay your bill Filed for bankruptcy")]
        StrugglingToPayYourBillFiledForBankruptcy,
        [EnumMember(Value = "Struggling to pay your bill Problem lowering your monthly payments")]
        StrugglingToPayYourBillProblemLoweringYourMonthlyPayments,
        [EnumMember(Value = "Struggling to pay your loan")]
        StrugglingToPayYourLoan,
        [EnumMember(Value = "Struggling to pay your loan Denied request to lower payments")]
        StrugglingToPayYourLoanDeniedRequestToLowerPayments,
        [EnumMember(Value = "Struggling to pay your loan Lender trying to repossess or disable the vehicle")]
        StrugglingToPayYourLoanLenderTryingToRepossessOrDisableTheVehicle,
        [EnumMember(Value = "Struggling to pay your loan Loan balance remaining after the vehicle is repossessed and sold")]
        StrugglingToPayYourLoanLoanBalanceRemainingAfterTheVehicleIsRepossessedAndSold,
        [EnumMember(Value = "Struggling to pay your loan Problem after you declared or threatened to declare bankruptcy")]
        StrugglingToPayYourLoanProblemAfterYouDeclaredOrThreatenedToDeclareBankruptcy,
        [EnumMember(Value = "Struggling to repay your loan")]
        StrugglingToRepayYourLoan,
        [EnumMember(Value = "Struggling to repay your loan Bankruptcy")]
        StrugglingToRepayYourLoanBankruptcy,
        [EnumMember(Value = "Struggling to repay your loan Can't get other flexible options for repaying your loan")]
        StrugglingToRepayYourLoanCanTGetOtherFlexibleOptionsForRepayingYourLoan,
        [EnumMember(Value = "Struggling to repay your loan Can't temporarily delay making payments")]
        StrugglingToRepayYourLoanCanTTemporarilyDelayMakingPayments,
        [EnumMember(Value = "Struggling to repay your loan Problem lowering your monthly payments")]
        StrugglingToRepayYourLoanProblemLoweringYourMonthlyPayments,
        [EnumMember(Value = "Struggling to repay your loan Problem with forgiveness, cancellation, or discharge")]
        StrugglingToRepayYourLoanProblemWithForgivenessCancellationOrDischarge,
        [EnumMember(Value = "Struggling to repay your loan Problem with your payment plan")]
        StrugglingToRepayYourLoanProblemWithYourPaymentPlan,
        [EnumMember(Value = "Threatened to contact someone or share information improperly")]
        ThreatenedToContactSomeoneOrShareInformationImproperly,
        [EnumMember(Value = "Threatened to contact someone or share information improperly Contacted you after you asked them to stop")]
        ThreatenedToContactSomeoneOrShareInformationImproperlyContactedYouAfterYouAskedThemToStop,
        [EnumMember(Value = "Threatened to contact someone or share information improperly Contacted you instead of your attorney")]
        ThreatenedToContactSomeoneOrShareInformationImproperlyContactedYouInsteadOfYourAttorney,
        [EnumMember(Value = "Threatened to contact someone or share information improperly Contacted your employer")]
        ThreatenedToContactSomeoneOrShareInformationImproperlyContactedYourEmployer,
        [EnumMember(Value = "Threatened to contact someone or share information improperly Talked to a third-party about your debt")]
        ThreatenedToContactSomeoneOrShareInformationImproperlyTalkedToAThirdPartyAboutYourDebt,
        [EnumMember(Value = "Took or threatened to take negative or legal action")]
        TookOrThreatenedToTakeNegativeOrLegalAction,
        [EnumMember(Value = "Took or threatened to take negative or legal action Collected or attempted to collect exempt funds")]
        TookOrThreatenedToTakeNegativeOrLegalActionCollectedOrAttemptedToCollectExemptFunds,
        [EnumMember(Value = "Took or threatened to take negative or legal action Seized or attempted to seize your property")]
        TookOrThreatenedToTakeNegativeOrLegalActionSeizedOrAttemptedToSeizeYourProperty,
        [EnumMember(Value = "Took or threatened to take negative or legal action Sued you in a state where you do not live or did not sign for the debt")]
        TookOrThreatenedToTakeNegativeOrLegalActionSuedYouInAStateWhereYouDoNotLiveOrDidNotSignForTheDebt,
        [EnumMember(Value = "Took or threatened to take negative or legal action Sued you without properly notifying you of lawsuit")]
        TookOrThreatenedToTakeNegativeOrLegalActionSuedYouWithoutProperlyNotifyingYouOfLawsuit,
        [EnumMember(Value = "Took or threatened to take negative or legal action Threatened or suggested your credit would be damaged")]
        TookOrThreatenedToTakeNegativeOrLegalActionThreatenedOrSuggestedYourCreditWouldBeDamaged,
        [EnumMember(Value = "Took or threatened to take negative or legal action Threatened to arrest you or take you to jail if you do not pay")]
        TookOrThreatenedToTakeNegativeOrLegalActionThreatenedToArrestYouOrTakeYouToJailIfYouDoNotPay,
        [EnumMember(Value = "Took or threatened to take negative or legal action Threatened to sue you for very old debt")]
        TookOrThreatenedToTakeNegativeOrLegalActionThreatenedToSueYouForVeryOldDebt,
        [EnumMember(Value = "Took or threatened to take negative or legal action Threatened to turn you in to immigration or deport you")]
        TookOrThreatenedToTakeNegativeOrLegalActionThreatenedToTurnYouInToImmigrationOrDeportYou,
        [EnumMember(Value = "Trouble accessing funds in your mobile or digital wallet")]
        TroubleAccessingFundsInYourMobileOrDigitalWallet,
        [EnumMember(Value = "Trouble during payment process")]
        TroubleDuringPaymentProcess,
        [EnumMember(Value = "Trouble during payment process Escrow, taxes, or insurance")]
        TroubleDuringPaymentProcessEscrowTaxesOrInsurance,
        [EnumMember(Value = "Trouble during payment process Fees charged")]
        TroubleDuringPaymentProcessFeesCharged,
        [EnumMember(Value = "Trouble during payment process Interest rate")]
        TroubleDuringPaymentProcessInterestRate,
        [EnumMember(Value = "Trouble during payment process Lien release")]
        TroubleDuringPaymentProcessLienRelease,
        [EnumMember(Value = "Trouble during payment process Loan sold or transferred to another company")]
        TroubleDuringPaymentProcessLoanSoldOrTransferredToAnotherCompany,
        [EnumMember(Value = "Trouble during payment process Paying off the loan")]
        TroubleDuringPaymentProcessPayingOffTheLoan,
        [EnumMember(Value = "Trouble during payment process Payment process")]
        TroubleDuringPaymentProcessPaymentProcess,
        [EnumMember(Value = "Trouble during payment process Private mortgage insurance (PMI)")]
        TroubleDuringPaymentProcessPrivateMortgageInsurancePMI,
        [EnumMember(Value = "Trouble during payment process Trying to communicate with the company to fix an issue while managing or servicing your loan")]
        TroubleDuringPaymentProcessTryingToCommunicateWithTheCompanyToFixAnIssueWhileManagingOrServicingYourLoan,
        [EnumMember(Value = "Trouble using the card")]
        TroubleUsingTheCard,
        [EnumMember(Value = "Trouble using the card Problem adding money")]
        TroubleUsingTheCardProblemAddingMoney,
        [EnumMember(Value = "Trouble using the card Problem using the card to withdraw money from an ATM")]
        TroubleUsingTheCardProblemUsingTheCardToWithdrawMoneyFromAnATM,
        [EnumMember(Value = "Trouble using the card Problem with a check written from your prepaid card account")]
        TroubleUsingTheCardProblemWithACheckWrittenFromYourPrepaidCardAccount,
        [EnumMember(Value = "Trouble using the card Problem with direct deposit")]
        TroubleUsingTheCardProblemWithDirectDeposit,
        [EnumMember(Value = "Trouble using the card Trouble getting information about the card")]
        TroubleUsingTheCardTroubleGettingInformationAboutTheCard,
        [EnumMember(Value = "Trouble using the card Trouble using the card to pay a bill")]
        TroubleUsingTheCardTroubleUsingTheCardToPayABill,
        [EnumMember(Value = "Trouble using the card Trouble using the card to send money to another person")]
        TroubleUsingTheCardTroubleUsingTheCardToSendMoneyToAnotherPerson,
        [EnumMember(Value = "Trouble using the card Trouble using the card to spend money in a store or online")]
        TroubleUsingTheCardTroubleUsingTheCardToSpendMoneyInAStoreOrOnline,
        [EnumMember(Value = "Trouble using your card")]
        TroubleUsingYourCard,
        [EnumMember(Value = "Trouble using your card Account sold or transferred to another company")]
        TroubleUsingYourCardAccountSoldOrTransferredToAnotherCompany,
        [EnumMember(Value = "Trouble using your card Can't use card to make purchases")]
        TroubleUsingYourCardCanTUseCardToMakePurchases,
        [EnumMember(Value = "Trouble using your card Credit card company won't increase or decrease your credit limit")]
        TroubleUsingYourCardCreditCardCompanyWonTIncreaseOrDecreaseYourCreditLimit,
        [EnumMember(Value = "Unable to get your credit report or credit score")]
        UnableToGetYourCreditReportOrCreditScore,
        [EnumMember(Value = "Unable to get your credit report or credit score Other problem getting your report or credit score")]
        UnableToGetYourCreditReportOrCreditScoreOtherProblemGettingYourReportOrCreditScore,
        [EnumMember(Value = "Unable to get your credit report or credit score Problem getting your free annual credit report")]
        UnableToGetYourCreditReportOrCreditScoreProblemGettingYourFreeAnnualCreditReport,
        [EnumMember(Value = "Unauthorized transactions or other transaction problem")]
        UnauthorizedTransactionsOrOtherTransactionProblem,
        [EnumMember(Value = "Unauthorized withdrawals or charges")]
        UnauthorizedWithdrawalsOrCharges,
        [EnumMember(Value = "Unexpected fees")]
        UnexpectedFees,
        [EnumMember(Value = "Unexpected or other fees")]
        UnexpectedOrOtherFees,
        [EnumMember(Value = "Vehicle was damaged or destroyed the vehicle")]
        VehicleWasDamagedOrDestroyedTheVehicle,
        [EnumMember(Value = "Vehicle was repossessed or sold the vehicle")]
        VehicleWasRepossessedOrSoldTheVehicle,
        [EnumMember(Value = "Was approved for a loan, but didn't receive money")]
        WasApprovedForALoanButDidnTReceiveMoney,
        [EnumMember(Value = "Was approved for a loan, but didn't receive the money")]
        WasApprovedForALoanButDidnTReceiveTheMoney,
        [EnumMember(Value = "Written notification about debt")]
        WrittenNotificationAboutDebt,
        [EnumMember(Value = "Written notification about debt Didn't receive enough information to verify debt")]
        WrittenNotificationAboutDebtDidnTReceiveEnoughInformationToVerifyDebt,
        [EnumMember(Value = "Written notification about debt Didn't receive notice of right to dispute")]
        WrittenNotificationAboutDebtDidnTReceiveNoticeOfRightToDispute,
        [EnumMember(Value = "Written notification about debt Notification didn't disclose it was an attempt to collect a debt")]
        WrittenNotificationAboutDebtNotificationDidnTDiscloseItWasAnAttemptToCollectADebt,
        [EnumMember(Value = "Wrong amount charged or received")]
        WrongAmountChargedOrReceived
    }

    public enum productInput
    {
        [EnumMember(Value = "Checking or savings account")]
        CheckingOrSavingsAccount,
        [EnumMember(Value = "Checking or savings account CD (Certificate of Deposit)")]
        CheckingOrSavingsAccountCDCertificateOfDeposit,
        [EnumMember(Value = "Checking or savings account Checking account")]
        CheckingOrSavingsAccountCheckingAccount,
        [EnumMember(Value = "Checking or savings account Other banking product or service")]
        CheckingOrSavingsAccountOtherBankingProductOrService,
        [EnumMember(Value = "Checking or savings account Savings account")]
        CheckingOrSavingsAccountSavingsAccount,
        [EnumMember(Value = "Credit card")]
        CreditCard,
        [EnumMember(Value = "Credit card or prepaid card")]
        CreditCardOrPrepaidCard,
        [EnumMember(Value = "Credit card or prepaid card General-purpose credit card or charge card")]
        CreditCardOrPrepaidCardGeneralPurposeCreditCardOrChargeCard,
        [EnumMember(Value = "Credit card or prepaid card General-purpose prepaid card")]
        CreditCardOrPrepaidCardGeneralPurposePrepaidCard,
        [EnumMember(Value = "Credit card or prepaid card Gift card")]
        CreditCardOrPrepaidCardGiftCard,
        [EnumMember(Value = "Credit card or prepaid card Government benefit card")]
        CreditCardOrPrepaidCardGovernmentBenefitCard,
        [EnumMember(Value = "Credit card or prepaid card Payroll card")]
        CreditCardOrPrepaidCardPayrollCard,
        [EnumMember(Value = "Credit card or prepaid card Store credit card")]
        CreditCardOrPrepaidCardStoreCreditCard,
        [EnumMember(Value = "Credit card or prepaid card Student prepaid card")]
        CreditCardOrPrepaidCardStudentPrepaidCard,
        [EnumMember(Value = "Credit card General-purpose credit card or charge card")]
        CreditCardGeneralPurposeCreditCardOrChargeCard,
        [EnumMember(Value = "Credit card Store credit card")]
        CreditCardStoreCreditCard,
        [EnumMember(Value = "Credit reporting or other personal consumer reports")]
        CreditReportingOrOtherPersonalConsumerReports,
        [EnumMember(Value = "Credit reporting or other personal consumer reports Credit reporting")]
        CreditReportingOrOtherPersonalConsumerReportsCreditReporting,
        [EnumMember(Value = "Credit reporting or other personal consumer reports Other personal consumer report")]
        CreditReportingOrOtherPersonalConsumerReportsOtherPersonalConsumerReport,
        [EnumMember(Value = "Credit reporting, credit repair services, or other personal consumer reports")]
        CreditReportingCreditRepairServicesOrOtherPersonalConsumerReports,
        [EnumMember(Value = "Credit reporting, credit repair services, or other personal consumer reports Credit repair services")]
        CreditReportingCreditRepairServicesOrOtherPersonalConsumerReportsCreditRepairServices,
        [EnumMember(Value = "Credit reporting, credit repair services, or other personal consumer reports Credit reporting")]
        CreditReportingCreditRepairServicesOrOtherPersonalConsumerReportsCreditReporting,
        [EnumMember(Value = "Credit reporting, credit repair services, or other personal consumer reports Other personal consumer report")]
        CreditReportingCreditRepairServicesOrOtherPersonalConsumerReportsOtherPersonalConsumerReport,
        [EnumMember(Value = "Debt collection")]
        DebtCollection,
        [EnumMember(Value = "Debt collection Auto debt")]
        DebtCollectionAutoDebt,
        [EnumMember(Value = "Debt collection Credit card debt")]
        DebtCollectionCreditCardDebt,
        [EnumMember(Value = "Debt collection Federal student loan debt")]
        DebtCollectionFederalStudentLoanDebt,
        [EnumMember(Value = "Debt collection I do not know")]
        DebtCollectionIDoNotKnow,
        [EnumMember(Value = "Debt collection Medical debt")]
        DebtCollectionMedicalDebt,
        [EnumMember(Value = "Debt collection Mortgage debt")]
        DebtCollectionMortgageDebt,
        [EnumMember(Value = "Debt collection Other debt")]
        DebtCollectionOtherDebt,
        [EnumMember(Value = "Debt collection Payday loan debt")]
        DebtCollectionPaydayLoanDebt,
        [EnumMember(Value = "Debt collection Private student loan debt")]
        DebtCollectionPrivateStudentLoanDebt,
        [EnumMember(Value = "Debt collection Rental debt")]
        DebtCollectionRentalDebt,
        [EnumMember(Value = "Debt collection Telecommunications debt")]
        DebtCollectionTelecommunicationsDebt,
        [EnumMember(Value = "Debt or credit management")]
        DebtOrCreditManagement,
        [EnumMember(Value = "Debt or credit management Credit repair services")]
        DebtOrCreditManagementCreditRepairServices,
        [EnumMember(Value = "Debt or credit management Debt settlement")]
        DebtOrCreditManagementDebtSettlement,
        [EnumMember(Value = "Debt or credit management Mortgage modification or foreclosure avoidance")]
        DebtOrCreditManagementMortgageModificationOrForeclosureAvoidance,
        [EnumMember(Value = "Debt or credit management Student loan debt relief")]
        DebtOrCreditManagementStudentLoanDebtRelief,
        [EnumMember(Value = "Money transfer, virtual currency, or money service")]
        MoneyTransferVirtualCurrencyOrMoneyService,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Check cashing service")]
        MoneyTransferVirtualCurrencyOrMoneyServiceCheckCashingService,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Debt settlement")]
        MoneyTransferVirtualCurrencyOrMoneyServiceDebtSettlement,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Domestic (US) money transfer")]
        MoneyTransferVirtualCurrencyOrMoneyServiceDomesticUSMoneyTransfer,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Foreign currency exchange")]
        MoneyTransferVirtualCurrencyOrMoneyServiceForeignCurrencyExchange,
        [EnumMember(Value = "Money transfer, virtual currency, or money service International money transfer")]
        MoneyTransferVirtualCurrencyOrMoneyServiceInternationalMoneyTransfer,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Mobile or digital wallet")]
        MoneyTransferVirtualCurrencyOrMoneyServiceMobileOrDigitalWallet,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Money order")]
        MoneyTransferVirtualCurrencyOrMoneyServiceMoneyOrder,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Money order, traveler's check or cashier's check")]
        MoneyTransferVirtualCurrencyOrMoneyServiceMoneyOrderTravelerSCheckOrCashierSCheck,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Refund anticipation check")]
        MoneyTransferVirtualCurrencyOrMoneyServiceRefundAnticipationCheck,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Traveler's check or cashier's check")]
        MoneyTransferVirtualCurrencyOrMoneyServiceTravelerSCheckOrCashierSCheck,
        [EnumMember(Value = "Money transfer, virtual currency, or money service Virtual currency")]
        MoneyTransferVirtualCurrencyOrMoneyServiceVirtualCurrency,
        Mortgage,
        [EnumMember(Value = "Mortgage Conventional home mortgage")]
        MortgageConventionalHomeMortgage,
        [EnumMember(Value = "Mortgage FHA mortgage")]
        MortgageFHAMortgage,
        [EnumMember(Value = "Mortgage Home equity loan or line of credit (HELOC)")]
        MortgageHomeEquityLoanOrLineOfCreditHELOC,
        [EnumMember(Value = "Mortgage Manufactured home loan")]
        MortgageManufacturedHomeLoan,
        [EnumMember(Value = "Mortgage Other type of mortgage")]
        MortgageOtherTypeOfMortgage,
        [EnumMember(Value = "Mortgage Reverse mortgage")]
        MortgageReverseMortgage,
        [EnumMember(Value = "Mortgage USDA mortgage")]
        MortgageUSDAMortgage,
        [EnumMember(Value = "Mortgage VA mortgage")]
        MortgageVAMortgage,
        [EnumMember(Value = "Payday loan, title loan, or personal loan")]
        PaydayLoanTitleLoanOrPersonalLoan,
        [EnumMember(Value = "Payday loan, title loan, or personal loan Installment loan")]
        PaydayLoanTitleLoanOrPersonalLoanInstallmentLoan,
        [EnumMember(Value = "Payday loan, title loan, or personal loan Pawn loan")]
        PaydayLoanTitleLoanOrPersonalLoanPawnLoan,
        [EnumMember(Value = "Payday loan, title loan, or personal loan Payday loan")]
        PaydayLoanTitleLoanOrPersonalLoanPaydayLoan,
        [EnumMember(Value = "Payday loan, title loan, or personal loan Personal line of credit")]
        PaydayLoanTitleLoanOrPersonalLoanPersonalLineOfCredit,
        [EnumMember(Value = "Payday loan, title loan, or personal loan Title loan")]
        PaydayLoanTitleLoanOrPersonalLoanTitleLoan,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoan,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Earned wage access")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanEarnedWageAccess,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Installment loan")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanInstallmentLoan,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Other advances of future income")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanOtherAdvancesOfFutureIncome,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Pawn loan")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanPawnLoan,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Payday loan")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanPaydayLoan,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Personal line of credit")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanPersonalLineOfCredit,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Tax refund anticipation loan or check")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanTaxRefundAnticipationLoanOrCheck,
        [EnumMember(Value = "Payday loan, title loan, personal loan, or advance loan Title loan")]
        PaydayLoanTitleLoanPersonalLoanOrAdvanceLoanTitleLoan,
        [EnumMember(Value = "Prepaid card")]
        PrepaidCard,
        [EnumMember(Value = "Prepaid card General-purpose prepaid card")]
        PrepaidCardGeneralPurposePrepaidCard,
        [EnumMember(Value = "Prepaid card Gift card")]
        PrepaidCardGiftCard,
        [EnumMember(Value = "Prepaid card Government benefit card")]
        PrepaidCardGovernmentBenefitCard,
        [EnumMember(Value = "Prepaid card Payroll card")]
        PrepaidCardPayrollCard,
        [EnumMember(Value = "Prepaid card Student prepaid card")]
        PrepaidCardStudentPrepaidCard,
        [EnumMember(Value = "Student loan")]
        StudentLoan,
        [EnumMember(Value = "Student loan Federal student loan servicing")]
        StudentLoanFederalStudentLoanServicing,
        [EnumMember(Value = "Student loan Private student loan")]
        StudentLoanPrivateStudentLoan,
        [EnumMember(Value = "Vehicle loan or lease")]
        VehicleLoanOrLease,
        [EnumMember(Value = "Vehicle loan or lease Lease")]
        VehicleLoanOrLeaseLease,
        [EnumMember(Value = "Vehicle loan or lease Loan")]
        VehicleLoanOrLeaseLoan,
        [EnumMember(Value = "Vehicle loan or lease Title loan")]
        VehicleLoanOrLeaseTitleLoan
    }

    public enum submittedViaInput
    {
        Web,
        Referral,
        Phone,
        [EnumMember(Value = "Postal mail")]
        PostalMail,
        Fax,
        [EnumMember(Value = "Web Referral")]
        WebReferral,
        Email
    }

    public enum tagsInput
    {
        Servicemember,
        [EnumMember(Value = "Older American")]
        OlderAmerican,
        [EnumMember(Value = "Older American, Servicemember")]
        OlderAmericanServicemember
    }

    public enum timelyInput
    {
        Yes,
        No
    }

    public class StatesResult
    {
        [JsonProperty("aggregations")]
        public StatesResultAggregationsType Aggregations { get; set; }
    }

    public class StatesResultAggregationsType
    {
        [JsonProperty("issue")]
        public MultiLevelAggregation Issue { get; set; }

        [JsonProperty("product")]
        public MultiLevelAggregation Product { get; set; }

        [JsonProperty("state")]
        public MultiLevelAggregation State { get; set; }
    }

    public class TrendsResult
    {
        [JsonProperty("aggregations")]
        public TrendsResultAggregationsType Aggregations { get; set; }
    }

    public class TrendsResultAggregationsType
    {
        [JsonProperty("tags")]
        public MultiLevelAggregation Tags { get; set; }

        [JsonProperty("company")]
        public MultiLevelAggregation Company { get; set; }

        [JsonProperty("issue")]
        public MultiLevelAggregation Issue { get; set; }

        [JsonProperty("product")]
        public MultiLevelAggregation Product { get; set; }

        [JsonProperty("sub_issue")]
        public MultiLevelAggregation SubIssue { get; set; }

        [JsonProperty("sub_product")]
        public MultiLevelAggregation SubProduct { get; set; }
    }

    public enum lensInput
    {
        [EnumMember(Value = "overview")]
        Overview,
        [EnumMember(Value = "issue")]
        Issue,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "tags")]
        Tags
    }

    public enum trendIntervalInput
    {
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "quarter")]
        Quarter,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "day")]
        Day
    }

    public enum subLensInput
    {
        [EnumMember(Value = "issue")]
        Issue,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "sub_product")]
        SubProduct,
        [EnumMember(Value = "sub_issue")]
        SubIssue,
        [EnumMember(Value = "tags")]
        Tags
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Consumercomplaints;

    public partial class WorkflowManagedActions
    {
        public ConsumercomplaintsActions Consumercomplaints(string connectionId) => new ConsumercomplaintsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConsumercomplaintsTriggers Consumercomplaints(string connectionId) => new ConsumercomplaintsTriggers(connectionId);
    }
}