//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecfr
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EcfrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [WorkflowExpressionFactory(nameof(__BuildSearchCfrResults))]
        public IBodyWorkflowAction<SearchResultsResponse> SearchCfrResults([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> lastModifiedOnOrAfter = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<paginateByInput> paginateBy = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResultsResponse> __BuildSearchCfrResults(WorkflowValue<string> query, WorkflowValue<string> lastModifiedOnOrAfter = null, WorkflowValue<int> perPage = null, WorkflowValue<int> page = null, WorkflowValue<orderInput> order = null, WorkflowValue<paginateByInput> paginateBy = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(order, nameof(order), required: false);
            WorkflowValue.Validate(paginateBy, nameof(paginateBy), required: false);
            return new DeferredBodyAction<SearchResultsResponse>(() =>
            {
                var apiCallPath = "/search/v1/results";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = ExpressionConverter.Convert(lastModifiedOnOrAfter);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (paginateBy != null)
                    callPayload.Queries["paginate_by"] = ExpressionConverter.Convert(paginateBy);
                return new ApiConnectionAction<SearchResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [WorkflowExpressionFactory(nameof(__BuildGetHierarchyCounts))]
        public IBodyWorkflowAction<HierarchyCountResponse> GetHierarchyCounts([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> agencySlugs = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> lastModifiedAfter = null, [WorkflowExpression] Func<string> lastModifiedOnOrAfter = null, [WorkflowExpression] Func<string> lastModifiedBefore = null, [WorkflowExpression] Func<string> lastModifiedOnOrBefore = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HierarchyCountResponse> __BuildGetHierarchyCounts(WorkflowValue<string> query, WorkflowValue<string> agencySlugs = null, WorkflowValue<string> date = null, WorkflowValue<string> lastModifiedAfter = null, WorkflowValue<string> lastModifiedOnOrAfter = null, WorkflowValue<string> lastModifiedBefore = null, WorkflowValue<string> lastModifiedOnOrBefore = null)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
            WorkflowValue.Validate(agencySlugs, nameof(agencySlugs), required: false);
            WorkflowValue.Validate(date, nameof(date), required: false);
            WorkflowValue.Validate(lastModifiedAfter, nameof(lastModifiedAfter), required: false);
            WorkflowValue.Validate(lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            WorkflowValue.Validate(lastModifiedBefore, nameof(lastModifiedBefore), required: false);
            WorkflowValue.Validate(lastModifiedOnOrBefore, nameof(lastModifiedOnOrBefore), required: false);
            return new DeferredBodyAction<HierarchyCountResponse>(() =>
            {
                var apiCallPath = "/search/v1/counts/hierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                if (agencySlugs != null)
                    callPayload.Queries["agency_slugs"] = ExpressionConverter.Convert(agencySlugs);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (lastModifiedAfter != null)
                    callPayload.Queries["last_modified_after"] = ExpressionConverter.Convert(lastModifiedAfter);
                if (lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = ExpressionConverter.Convert(lastModifiedOnOrAfter);
                if (lastModifiedBefore != null)
                    callPayload.Queries["last_modified_before"] = ExpressionConverter.Convert(lastModifiedBefore);
                if (lastModifiedOnOrBefore != null)
                    callPayload.Queries["last_modified_on_or_before"] = ExpressionConverter.Convert(lastModifiedOnOrBefore);
                return new ApiConnectionAction<HierarchyCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [WorkflowExpressionFactory(nameof(__BuildGetFullRegulationXML))]
        public IBodyWorkflowAction<object> GetFullRegulationXML([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> subtitle = null, [WorkflowExpression] Func<string> chapter = null, [WorkflowExpression] Func<string> subchapter = null, [WorkflowExpression] Func<string> part = null, [WorkflowExpression] Func<string> subpart = null, [WorkflowExpression] Func<string> section = null, [WorkflowExpression] Func<string> appendix = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildGetFullRegulationXML(WorkflowValue<string> date, WorkflowValue<string> title, WorkflowValue<string> subtitle = null, WorkflowValue<string> chapter = null, WorkflowValue<string> subchapter = null, WorkflowValue<string> part = null, WorkflowValue<string> subpart = null, WorkflowValue<string> section = null, WorkflowValue<string> appendix = null)
        {
            WorkflowValue.Validate(date, nameof(date), required: true);
            WorkflowValue.Validate(title, nameof(title), required: true);
            WorkflowValue.Validate(subtitle, nameof(subtitle), required: false);
            WorkflowValue.Validate(chapter, nameof(chapter), required: false);
            WorkflowValue.Validate(subchapter, nameof(subchapter), required: false);
            WorkflowValue.Validate(part, nameof(part), required: false);
            WorkflowValue.Validate(subpart, nameof(subpart), required: false);
            WorkflowValue.Validate(section, nameof(section), required: false);
            WorkflowValue.Validate(appendix, nameof(appendix), required: false);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/versioner/v1/full/{0}/title-{1}.xml", ExpressionConverter.ConvertWithUrlEncoding(date, 1), ExpressionConverter.ConvertWithUrlEncoding(title, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (subtitle != null)
                    callPayload.Queries["subtitle"] = ExpressionConverter.Convert(subtitle);
                if (chapter != null)
                    callPayload.Queries["chapter"] = ExpressionConverter.Convert(chapter);
                if (subchapter != null)
                    callPayload.Queries["subchapter"] = ExpressionConverter.Convert(subchapter);
                if (part != null)
                    callPayload.Queries["part"] = ExpressionConverter.Convert(part);
                if (subpart != null)
                    callPayload.Queries["subpart"] = ExpressionConverter.Convert(subpart);
                if (section != null)
                    callPayload.Queries["section"] = ExpressionConverter.Convert(section);
                if (appendix != null)
                    callPayload.Queries["appendix"] = ExpressionConverter.Convert(appendix);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class EcfrTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResultsResponse
    {
        [JsonProperty("results")]
        public SearchResultsResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("meta")]
        public SearchResultsResponseMetaType Meta { get; set; }
    }

    public class SearchResultsResponseResultsTypeItem
    {
        [JsonProperty("starts_on")]
        public string StartsOn { get; set; }

        [JsonProperty("ends_on")]
        public string EndsOn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hierarchy")]
        public JToken Hierarchy { get; set; }

        [JsonProperty("hierarchy_headings")]
        public JToken HierarchyHeadings { get; set; }

        [JsonProperty("headings")]
        public JToken Headings { get; set; }

        [JsonProperty("full_text_excerpt")]
        public string FullTextExcerpt { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("structure_index")]
        public double StructureIndex { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }

        [JsonProperty("change_types")]
        public string[] ChangeTypes { get; set; }
    }

    public class SearchResultsResponseMetaType
    {
        [JsonProperty("current_page")]
        public double CurrentPage { get; set; }

        [JsonProperty("total_pages")]
        public double TotalPages { get; set; }

        [JsonProperty("total_count")]
        public double TotalCount { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public enum orderInput
    {
        [EnumMember(Value = "relevance")]
        Relevance,
        [EnumMember(Value = "date")]
        Date
    }

    public enum paginateByInput
    {
        [EnumMember(Value = "results")]
        Results
    }

    public class HierarchyCountResponse
    {
        [JsonProperty("count")]
        public HierarchyCountResponseCountType Count { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("shown_count")]
        public double ShownCount { get; set; }

        [JsonProperty("children")]
        public HierarchyNode[] Children { get; set; }
    }

    public class HierarchyCountResponseCountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }
    }

    public class HierarchyNode
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("hierarchy")]
        public string Hierarchy { get; set; }

        [JsonProperty("hierarchy_heading")]
        public string HierarchyHeading { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("structure_index")]
        public double StructureIndex { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("children")]
        public HierarchyNodeChildrenTypeItem[] Children { get; set; }
    }

    public class HierarchyNodeChildrenTypeItem
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("hierarchy")]
        public string Hierarchy { get; set; }

        [JsonProperty("hierarchy_heading")]
        public string HierarchyHeading { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("structure_index")]
        public double StructureIndex { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }

        [JsonProperty("children")]
        public HierarchyNodeChildrenTypeItemChildrenTypeItem[] Children { get; set; }
    }

    public class HierarchyNodeChildrenTypeItemChildrenTypeItem
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("hierarchy")]
        public string Hierarchy { get; set; }

        [JsonProperty("hierarchy_heading")]
        public string HierarchyHeading { get; set; }

        [JsonProperty("heading")]
        public string Heading { get; set; }

        [JsonProperty("structure_index")]
        public double StructureIndex { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ecfr;

    public partial class WorkflowManagedActions
    {
        public EcfrActions Ecfr(string connectionId) => new EcfrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EcfrTriggers Ecfr(string connectionId) => new EcfrTriggers(connectionId);
    }
}
