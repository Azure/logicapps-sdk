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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResultsResponse> __BuildSearchCfrResults(WorkflowExpression<string> query, WorkflowExpression<string> lastModifiedOnOrAfter = null, WorkflowExpression<int> perPage = null, WorkflowExpression<int> page = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<paginateByInput> paginateBy = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(paginateBy, nameof(paginateBy), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HierarchyCountResponse> __BuildGetHierarchyCounts(WorkflowExpression<string> query, WorkflowExpression<string> agencySlugs = null, WorkflowExpression<string> date = null, WorkflowExpression<string> lastModifiedAfter = null, WorkflowExpression<string> lastModifiedOnOrAfter = null, WorkflowExpression<string> lastModifiedBefore = null, WorkflowExpression<string> lastModifiedOnOrBefore = null)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            WorkflowExpression.Validate(agencySlugs, nameof(agencySlugs), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(lastModifiedAfter, nameof(lastModifiedAfter), required: false);
            WorkflowExpression.Validate(lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            WorkflowExpression.Validate(lastModifiedBefore, nameof(lastModifiedBefore), required: false);
            WorkflowExpression.Validate(lastModifiedOnOrBefore, nameof(lastModifiedOnOrBefore), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildGetFullRegulationXML(WorkflowExpression<string> date, WorkflowExpression<string> title, WorkflowExpression<string> subtitle = null, WorkflowExpression<string> chapter = null, WorkflowExpression<string> subchapter = null, WorkflowExpression<string> part = null, WorkflowExpression<string> subpart = null, WorkflowExpression<string> section = null, WorkflowExpression<string> appendix = null)
        {
            WorkflowExpression.Validate(date, nameof(date), required: true);
            WorkflowExpression.Validate(title, nameof(title), required: true);
            WorkflowExpression.Validate(subtitle, nameof(subtitle), required: false);
            WorkflowExpression.Validate(chapter, nameof(chapter), required: false);
            WorkflowExpression.Validate(subchapter, nameof(subchapter), required: false);
            WorkflowExpression.Validate(part, nameof(part), required: false);
            WorkflowExpression.Validate(subpart, nameof(subpart), required: false);
            WorkflowExpression.Validate(section, nameof(section), required: false);
            WorkflowExpression.Validate(appendix, nameof(appendix), required: false);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "relevance")]
        Relevance,
        [EnumMember(Value = "date")]
        Date
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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