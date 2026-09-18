//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommondataserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<EntityItemList> ListRecords([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> fetchXml = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (fetchXml != null)
                callPayload.Queries["fetchXml"] = ExpressionConverter.Convert(fetchXml);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction<EntityItemList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> GetItemCodeless([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> xMsFileName, [WorkflowExpression] Func<string> item = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-file-name"] = ExpressionConverter.Convert(xMsFileName);
            callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> size = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$value", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformUnboundAction([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/api/data/v9.2/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformBoundAction([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            var apiCallPath = String.Format("/api/data/v9.2/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> itemrelateWith)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["@odata.id"] = ExpressionConverter.ConvertO(itemrelateWith);
            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organization, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> searchRequestsearchTerm, [WorkflowExpression] Func<string> searchRequestsearchType = null, [WorkflowExpression] Func<string> searchRequestsearchMode = null, [WorkflowExpression] Func<int> searchRequestrowCount = null, [WorkflowExpression] Func<string> searchRequestrowFilter = null, [WorkflowExpression] Func<string[]> searchRequesttableFilter = null, [WorkflowExpression] Func<string[]> searchRequestsortBy = null, [WorkflowExpression] Func<string[]> searchRequestfacetQuery = null, [WorkflowExpression] Func<int> searchRequestskipRows = null, [WorkflowExpression] Func<bool> searchRequestreturnRowCount = null)
        {
            var apiCallPath = "/api/search/v1.0/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            var searchRequest = new JObject();
            var searchRequestpropCount = 0;
            searchRequestpropCount++;
            searchRequest["search"] = ExpressionConverter.ConvertO(searchRequestsearchTerm);
            if (searchRequestsearchType != null)
            {
                searchRequest["searchtype"] = ExpressionConverter.ConvertO(searchRequestsearchType);
                searchRequestpropCount++;
            }

            if (searchRequestsearchMode != null)
            {
                searchRequest["searchmode"] = ExpressionConverter.ConvertO(searchRequestsearchMode);
                searchRequestpropCount++;
            }

            if (searchRequestrowCount != null)
            {
                searchRequest["top"] = ExpressionConverter.ConvertO(searchRequestrowCount);
                searchRequestpropCount++;
            }

            if (searchRequestrowFilter != null)
            {
                searchRequest["filter"] = ExpressionConverter.ConvertO(searchRequestrowFilter);
                searchRequestpropCount++;
            }

            if (searchRequesttableFilter != null)
            {
                searchRequest["entities"] = ExpressionConverter.ConvertO(searchRequesttableFilter);
                searchRequestpropCount++;
            }

            if (searchRequestsortBy != null)
            {
                searchRequest["orderby"] = ExpressionConverter.ConvertO(searchRequestsortBy);
                searchRequestpropCount++;
            }

            if (searchRequestfacetQuery != null)
            {
                searchRequest["facets"] = ExpressionConverter.ConvertO(searchRequestfacetQuery);
                searchRequestpropCount++;
            }

            if (searchRequestskipRows != null)
            {
                searchRequest["skip"] = ExpressionConverter.ConvertO(searchRequestskipRows);
                searchRequestpropCount++;
            }

            if (searchRequestreturnRowCount != null)
            {
                searchRequest["returntotalrecordcount"] = ExpressionConverter.ConvertO(searchRequestreturnRowCount);
                searchRequestpropCount++;
            }

            if (searchRequestpropCount > 0)
            {
                callPayload.Body = searchRequest;
            }

            return new ApiConnectionAction<SearchOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction ExecuteChangeset()
        {
            var apiCallPath = "/api/data/v9.1/$batch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class CommondataserviceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SubscribeWebhookTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<int> subscriptionRequestchangeType, [WorkflowExpression] Func<int> subscriptionRequestscope, [WorkflowExpression] Func<string> subscriptionRequestselectColumns = null, [WorkflowExpression] Func<string> subscriptionRequestfilterRows = null, [WorkflowExpression] Func<string> subscriptionRequestdelayUntil = null, [WorkflowExpression] Func<int> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/data/v9.1/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Consistency"] = Convert.ToString("Strong");
            callPayload.Headers["catalog"] = Convert.ToString("all");
            callPayload.Headers["category"] = Convert.ToString("all");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            var subscriptionRequest = new JObject();
            var subscriptionRequestpropCount = 0;
            subscriptionRequest["version"] = 1;
            subscriptionRequestpropCount++;
            subscriptionRequest["url"] = "@listCallbackUrl()";
            subscriptionRequestpropCount++;
            subscriptionRequestpropCount++;
            subscriptionRequest["entityname"] = ExpressionConverter.ConvertO(subscriptionRequesttableName);
            subscriptionRequestpropCount++;
            subscriptionRequest["message"] = ExpressionConverter.ConvertO(subscriptionRequestchangeType);
            subscriptionRequestpropCount++;
            subscriptionRequest["scope"] = ExpressionConverter.ConvertO(subscriptionRequestscope);
            if (subscriptionRequestselectColumns != null)
            {
                subscriptionRequest["filteringattributes"] = ExpressionConverter.ConvertO(subscriptionRequestselectColumns);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestfilterRows != null)
            {
                subscriptionRequest["filterexpression"] = ExpressionConverter.ConvertO(subscriptionRequestfilterRows);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestdelayUntil != null)
            {
                subscriptionRequest["postponeuntil"] = ExpressionConverter.ConvertO(subscriptionRequestdelayUntil);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestrunAs != null)
            {
                subscriptionRequest["runas"] = ExpressionConverter.ConvertO(subscriptionRequestrunAs);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestpropCount > 0)
            {
                callPayload.Body = subscriptionRequest;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessEventsTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> catalog, [WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<string> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/data/v9.2/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Consistency"] = Convert.ToString("Strong");
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["catalog"] = ExpressionConverter.Convert(catalog);
            callPayload.Headers["category"] = ExpressionConverter.Convert(category);
            var subscriptionRequest = new JObject();
            var subscriptionRequestpropCount = 0;
            subscriptionRequest["version"] = 3;
            subscriptionRequestpropCount++;
            subscriptionRequest["url"] = "@listCallbackUrl()";
            subscriptionRequestpropCount++;
            subscriptionRequest["scope"] = 4;
            subscriptionRequestpropCount++;
            subscriptionRequestpropCount++;
            subscriptionRequest["entityname"] = ExpressionConverter.ConvertO(subscriptionRequesttableName);
            subscriptionRequestpropCount++;
            subscriptionRequest["sdkmessagename"] = ExpressionConverter.ConvertO(subscriptionRequestactionName);
            if (subscriptionRequestpropCount > 0)
            {
                callPayload.Body = subscriptionRequest;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class EntityItemList
    {
        [JsonProperty("value")]
        public EntityItem[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class EntityItem
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class SearchOutput
    {
        [JsonProperty("value")]
        public SearchOutputListOfRowsTypeItem[] ListOfRows { get; set; }

        [JsonProperty("totalrecordcount")]
        public int TotalRowCount { get; set; }

        [JsonProperty("facets")]
        public JToken FacetResults { get; set; }
    }

    public class SearchOutputListOfRowsTypeItem
    {
        [JsonProperty("@search.score")]
        public double RowSearchScore { get; set; }

        [JsonProperty("@search.highlights")]
        public JToken RowSearchHighlights { get; set; }

        [JsonProperty("@search.entityname")]
        public string RowTableName { get; set; }

        [JsonProperty("@search.objectid")]
        public string RowObjectId { get; set; }

        [JsonProperty("@search.objecttypecode")]
        public int RowObjectTypeCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice;

    public partial class WorkflowManagedActions
    {
        public CommondataserviceActions Commondataservice(string connectionId) => new CommondataserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CommondataserviceTriggers Commondataservice(string connectionId) => new CommondataserviceTriggers(connectionId);
    }
}