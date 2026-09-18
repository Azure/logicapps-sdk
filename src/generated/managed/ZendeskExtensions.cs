//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zendesk
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZendeskActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<TablesList> GetTables()
        {
            var apiCallPath = "/datasets/default/tables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TablesList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> select = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<ItemsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<Item> PostItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<itemInput> item = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<Item> GetItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IWorkflowAction DeleteItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(table, 2), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zendesk")]
        public IBodyWorkflowAction<SearchResult> SearchArticles([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<int> brandId = null, [WorkflowExpression] Func<int> category = null, [WorkflowExpression] Func<int> section = null, [WorkflowExpression] Func<string> labelNames = null, [WorkflowExpression] Func<bool> multibrand = null)
        {
            var apiCallPath = "/api/v2/help_center/articles/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (locale != null)
                callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
            if (brandId != null)
                callPayload.Queries["brand_id"] = ExpressionConverter.Convert(brandId);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (section != null)
                callPayload.Queries["section"] = ExpressionConverter.Convert(section);
            if (labelNames != null)
                callPayload.Queries["label_names"] = ExpressionConverter.Convert(labelNames);
            if (multibrand != null)
                callPayload.Queries["multibrand"] = ExpressionConverter.Convert(multibrand);
            return new ApiConnectionAction<SearchResult>(callPayload);
        }
    }

    public class ZendeskTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/datasets/default/tables/{0}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(table, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionTrigger<ItemsList>(callPayload, triggerName, recurrence);
        }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class itemInput
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class SearchResult
    {
        [JsonProperty("results")]
        public SearchResultResultsTypeItem[] Results { get; set; }
    }

    public class SearchResultResultsTypeItem
    {
        [JsonProperty("id")]
        public int ArticleId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("author_id")]
        public int AuthorId { get; set; }

        [JsonProperty("comments_disabled")]
        public bool CommentsDisabled { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

        [JsonProperty("promoted")]
        public bool Promoted { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("vote_sum")]
        public int VoteSum { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("section_id")]
        public int SectionId { get; set; }

        [JsonProperty("created_at")]
        public string CreationDate { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source_locale")]
        public string SourceLocale { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("outdated")]
        public bool Outdated { get; set; }

        [JsonProperty("outdated_locales")]
        public string[] OutdatedLocales { get; set; }

        [JsonProperty("edited_at")]
        public string EditedAt { get; set; }

        [JsonProperty("user_segment_id")]
        public int UserSegmentId { get; set; }

        [JsonProperty("permission_group_id")]
        public int PermissionGroupId { get; set; }

        [JsonProperty("content_tag_ids")]
        public string[] ContentTagIds { get; set; }

        [JsonProperty("label_names")]
        public string[] LabelNames { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("result_type")]
        public string ResultType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zendesk;

    public partial class WorkflowManagedActions
    {
        public ZendeskActions Zendesk(string connectionId) => new ZendeskActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZendeskTriggers Zendesk(string connectionId) => new ZendeskTriggers(connectionId);
    }
}