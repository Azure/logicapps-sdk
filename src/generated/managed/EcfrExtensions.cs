//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ecfr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EcfrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<SearchResultsResponse> SearchCfrResults([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> lastModifiedOnOrAfter = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<paginateByInput> paginateBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search/v1/results";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = SourceExpressionConverter.ConvertO(lastModifiedOnOrAfter);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (paginateBy != null)
                    callPayload.Queries["paginate_by"] = SourceExpressionConverter.Convert(paginateBy);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResultsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<HierarchyCountResponse> GetHierarchyCounts([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> agencySlugs = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> lastModifiedAfter = null, [WorkflowExpression] Func<string> lastModifiedOnOrAfter = null, [WorkflowExpression] Func<string> lastModifiedBefore = null, [WorkflowExpression] Func<string> lastModifiedOnOrBefore = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search/v1/counts/hierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (agencySlugs != null)
                    callPayload.Queries["agency_slugs"] = SourceExpressionConverter.ConvertO(agencySlugs);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (lastModifiedAfter != null)
                    callPayload.Queries["last_modified_after"] = SourceExpressionConverter.ConvertO(lastModifiedAfter);
                if (lastModifiedOnOrAfter != null)
                    callPayload.Queries["last_modified_on_or_after"] = SourceExpressionConverter.ConvertO(lastModifiedOnOrAfter);
                if (lastModifiedBefore != null)
                    callPayload.Queries["last_modified_before"] = SourceExpressionConverter.ConvertO(lastModifiedBefore);
                if (lastModifiedOnOrBefore != null)
                    callPayload.Queries["last_modified_on_or_before"] = SourceExpressionConverter.ConvertO(lastModifiedOnOrBefore);
                return callPayload;
            }

            return new ApiConnectionAction<HierarchyCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ecfr")]
        public IBodyWorkflowAction<object> GetFullRegulationXML([WorkflowExpression] Func<string> date, [WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> subtitle = null, [WorkflowExpression] Func<string> chapter = null, [WorkflowExpression] Func<string> subchapter = null, [WorkflowExpression] Func<string> part = null, [WorkflowExpression] Func<string> subpart = null, [WorkflowExpression] Func<string> section = null, [WorkflowExpression] Func<string> appendix = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/versioner/v1/full/{0}/title-{1}.xml", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(date, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(title, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (subtitle != null)
                    callPayload.Queries["subtitle"] = SourceExpressionConverter.ConvertO(subtitle);
                if (chapter != null)
                    callPayload.Queries["chapter"] = SourceExpressionConverter.ConvertO(chapter);
                if (subchapter != null)
                    callPayload.Queries["subchapter"] = SourceExpressionConverter.ConvertO(subchapter);
                if (part != null)
                    callPayload.Queries["part"] = SourceExpressionConverter.ConvertO(part);
                if (subpart != null)
                    callPayload.Queries["subpart"] = SourceExpressionConverter.ConvertO(subpart);
                if (section != null)
                    callPayload.Queries["section"] = SourceExpressionConverter.ConvertO(section);
                if (appendix != null)
                    callPayload.Queries["appendix"] = SourceExpressionConverter.ConvertO(appendix);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
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