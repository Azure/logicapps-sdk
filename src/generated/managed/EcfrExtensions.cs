//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecfr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EcfrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<SearchResultsResponse> SearchCfrResults(Expression<Func<string>> query, Expression<Func<string>> lastModifiedOnOrAfter = null, Expression<Func<int>> perPage = null, Expression<Func<int>> page = null, Expression<Func<orderInput>> order = null, Expression<Func<paginateByInput>> paginateBy = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_lastModifiedOnOrAfter = lastModifiedOnOrAfter == null ? null : WorkflowExpression.Compile(lastModifiedOnOrAfter);
            WorkflowExpression.Validate(__workflow_lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_order = order == null ? null : WorkflowExpression.Compile(order);
            WorkflowExpression.Validate(__workflow_order, nameof(order), required: false);
            var __workflow_paginateBy = paginateBy == null ? null : WorkflowExpression.Compile(paginateBy);
            WorkflowExpression.Validate(__workflow_paginateBy, nameof(paginateBy), required: false);
            return new DeferredBodyAction<SearchResultsResponse>(() =>
            {
                var apiCallPath = "/search/v1/results";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = ExpressionConverter.Convert(__workflow_lastModifiedOnOrAfter);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_paginateBy != null)
                    callPayload.Queries["paginate_by"] = ExpressionConverter.Convert(__workflow_paginateBy);
                return new ApiConnectionAction<SearchResultsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<HierarchyCountResponse> GetHierarchyCounts(Expression<Func<string>> query, Expression<Func<string>> agencySlugs = null, Expression<Func<string>> date = null, Expression<Func<string>> lastModifiedAfter = null, Expression<Func<string>> lastModifiedOnOrAfter = null, Expression<Func<string>> lastModifiedBefore = null, Expression<Func<string>> lastModifiedOnOrBefore = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: true);
            var __workflow_agencySlugs = agencySlugs == null ? null : WorkflowExpression.Compile(agencySlugs);
            WorkflowExpression.Validate(__workflow_agencySlugs, nameof(agencySlugs), required: false);
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: false);
            var __workflow_lastModifiedAfter = lastModifiedAfter == null ? null : WorkflowExpression.Compile(lastModifiedAfter);
            WorkflowExpression.Validate(__workflow_lastModifiedAfter, nameof(lastModifiedAfter), required: false);
            var __workflow_lastModifiedOnOrAfter = lastModifiedOnOrAfter == null ? null : WorkflowExpression.Compile(lastModifiedOnOrAfter);
            WorkflowExpression.Validate(__workflow_lastModifiedOnOrAfter, nameof(lastModifiedOnOrAfter), required: false);
            var __workflow_lastModifiedBefore = lastModifiedBefore == null ? null : WorkflowExpression.Compile(lastModifiedBefore);
            WorkflowExpression.Validate(__workflow_lastModifiedBefore, nameof(lastModifiedBefore), required: false);
            var __workflow_lastModifiedOnOrBefore = lastModifiedOnOrBefore == null ? null : WorkflowExpression.Compile(lastModifiedOnOrBefore);
            WorkflowExpression.Validate(__workflow_lastModifiedOnOrBefore, nameof(lastModifiedOnOrBefore), required: false);
            return new DeferredBodyAction<HierarchyCountResponse>(() =>
            {
                var apiCallPath = "/search/v1/counts/hierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_agencySlugs != null)
                    callPayload.Queries["agency_slugs"] = ExpressionConverter.Convert(__workflow_agencySlugs);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_lastModifiedAfter != null)
                    callPayload.Queries["last_modified_after"] = ExpressionConverter.Convert(__workflow_lastModifiedAfter);
                if (__workflow_lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = ExpressionConverter.Convert(__workflow_lastModifiedOnOrAfter);
                if (__workflow_lastModifiedBefore != null)
                    callPayload.Queries["last_modified_before"] = ExpressionConverter.Convert(__workflow_lastModifiedBefore);
                if (__workflow_lastModifiedOnOrBefore != null)
                    callPayload.Queries["last_modified_on_or_before"] = ExpressionConverter.Convert(__workflow_lastModifiedOnOrBefore);
                return new ApiConnectionAction<HierarchyCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<object> GetFullRegulationXML(Expression<Func<string>> date, Expression<Func<string>> title, Expression<Func<string>> subtitle = null, Expression<Func<string>> chapter = null, Expression<Func<string>> subchapter = null, Expression<Func<string>> part = null, Expression<Func<string>> subpart = null, Expression<Func<string>> section = null, Expression<Func<string>> appendix = null)
        {
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: true);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: true);
            var __workflow_subtitle = subtitle == null ? null : WorkflowExpression.Compile(subtitle);
            WorkflowExpression.Validate(__workflow_subtitle, nameof(subtitle), required: false);
            var __workflow_chapter = chapter == null ? null : WorkflowExpression.Compile(chapter);
            WorkflowExpression.Validate(__workflow_chapter, nameof(chapter), required: false);
            var __workflow_subchapter = subchapter == null ? null : WorkflowExpression.Compile(subchapter);
            WorkflowExpression.Validate(__workflow_subchapter, nameof(subchapter), required: false);
            var __workflow_part = part == null ? null : WorkflowExpression.Compile(part);
            WorkflowExpression.Validate(__workflow_part, nameof(part), required: false);
            var __workflow_subpart = subpart == null ? null : WorkflowExpression.Compile(subpart);
            WorkflowExpression.Validate(__workflow_subpart, nameof(subpart), required: false);
            var __workflow_section = section == null ? null : WorkflowExpression.Compile(section);
            WorkflowExpression.Validate(__workflow_section, nameof(section), required: false);
            var __workflow_appendix = appendix == null ? null : WorkflowExpression.Compile(appendix);
            WorkflowExpression.Validate(__workflow_appendix, nameof(appendix), required: false);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/versioner/v1/full/{0}/title-{1}.xml", ExpressionConverter.ConvertWithUrlEncoding(__workflow_date, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_title, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_subtitle != null)
                    callPayload.Queries["subtitle"] = ExpressionConverter.Convert(__workflow_subtitle);
                if (__workflow_chapter != null)
                    callPayload.Queries["chapter"] = ExpressionConverter.Convert(__workflow_chapter);
                if (__workflow_subchapter != null)
                    callPayload.Queries["subchapter"] = ExpressionConverter.Convert(__workflow_subchapter);
                if (__workflow_part != null)
                    callPayload.Queries["part"] = ExpressionConverter.Convert(__workflow_part);
                if (__workflow_subpart != null)
                    callPayload.Queries["subpart"] = ExpressionConverter.Convert(__workflow_subpart);
                if (__workflow_section != null)
                    callPayload.Queries["section"] = ExpressionConverter.Convert(__workflow_section);
                if (__workflow_appendix != null)
                    callPayload.Queries["appendix"] = ExpressionConverter.Convert(__workflow_appendix);
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
