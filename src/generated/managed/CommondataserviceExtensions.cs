//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommondataserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<EntityItemList> ListRecords(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> expand = null, Expression<Func<string>> fetchXml = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (filter != null)
                callPayload.Queries["$filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (orderby != null)
                callPayload.Queries["$orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (fetchXml != null)
                callPayload.Queries["fetchXml"] = CSharpExpressionConverter.ConvertO(fetchXml);
            if (top != null)
                callPayload.Queries["$top"] = CSharpExpressionConverter.ConvertO(top);
            if (skiptoken != null)
                callPayload.Queries["$skiptoken"] = CSharpExpressionConverter.ConvertO(skiptoken);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = CSharpExpressionConverter.ConvertO(partitionId);
            callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            return new ApiConnectionAction<EntityItemList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> GetItemCodeless(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = CSharpExpressionConverter.ConvertO(select);
            if (expand != null)
                callPayload.Queries["$expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = CSharpExpressionConverter.ConvertO(partitionId);
            callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (partitionId != null)
                callPayload.Queries["partitionId"] = CSharpExpressionConverter.ConvertO(partitionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
            callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> xMsFileName, Expression<Func<string>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-file-name"] = CSharpExpressionConverter.ConvertO(xMsFileName);
            callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> size = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$value", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = CSharpExpressionConverter.ConvertO(size);
            callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformUnboundAction(Expression<Func<string>> organization, Expression<Func<string>> actionName, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformBoundAction(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> actionName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}({1})/{2}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> itemrelateWith)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            var item = new JObject();
            var itempropCount = 0;
            itempropCount++;
            item["@odata.id"] = CSharpExpressionConverter.ConvertToken(itemrelateWith);
            if (itempropCount > 0)
            {
                callPayload.Body = item;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$id"] = CSharpExpressionConverter.ConvertO(id);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows(Expression<Func<string>> organization, Expression<Func<string>> searchRequestsearchTerm, Expression<Func<string>> searchRequestsearchType = null, Expression<Func<string>> searchRequestsearchMode = null, Expression<Func<int>> searchRequestrowCount = null, Expression<Func<string>> searchRequestrowFilter = null, Expression<Func<string[]>> searchRequesttableFilter = null, Expression<Func<string[]>> searchRequestsortBy = null, Expression<Func<string[]>> searchRequestfacetQuery = null, Expression<Func<int>> searchRequestskipRows = null, Expression<Func<bool>> searchRequestreturnRowCount = null)
        {
            var apiCallPath = "/api/search/v1.0/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            var searchRequest = new JObject();
            var searchRequestpropCount = 0;
            searchRequestpropCount++;
            searchRequest["search"] = CSharpExpressionConverter.ConvertToken(searchRequestsearchTerm);
            if (searchRequestsearchType != null)
            {
                searchRequest["searchtype"] = CSharpExpressionConverter.ConvertToken(searchRequestsearchType);
                searchRequestpropCount++;
            }

            if (searchRequestsearchMode != null)
            {
                searchRequest["searchmode"] = CSharpExpressionConverter.ConvertToken(searchRequestsearchMode);
                searchRequestpropCount++;
            }

            if (searchRequestrowCount != null)
            {
                searchRequest["top"] = CSharpExpressionConverter.ConvertToken(searchRequestrowCount);
                searchRequestpropCount++;
            }

            if (searchRequestrowFilter != null)
            {
                searchRequest["filter"] = CSharpExpressionConverter.ConvertToken(searchRequestrowFilter);
                searchRequestpropCount++;
            }

            if (searchRequesttableFilter != null)
            {
                searchRequest["entities"] = CSharpExpressionConverter.ConvertToken(searchRequesttableFilter);
                searchRequestpropCount++;
            }

            if (searchRequestsortBy != null)
            {
                searchRequest["orderby"] = CSharpExpressionConverter.ConvertToken(searchRequestsortBy);
                searchRequestpropCount++;
            }

            if (searchRequestfacetQuery != null)
            {
                searchRequest["facets"] = CSharpExpressionConverter.ConvertToken(searchRequestfacetQuery);
                searchRequestpropCount++;
            }

            if (searchRequestskipRows != null)
            {
                searchRequest["skip"] = CSharpExpressionConverter.ConvertToken(searchRequestskipRows);
                searchRequestpropCount++;
            }

            if (searchRequestreturnRowCount != null)
            {
                searchRequest["returntotalrecordcount"] = CSharpExpressionConverter.ConvertToken(searchRequestreturnRowCount);
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
        public IWorkflowTrigger SubscribeWebhookTrigger(Expression<Func<string>> organization, Expression<Func<string>> subscriptionRequesttableName, Expression<Func<int>> subscriptionRequestchangeType, Expression<Func<int>> subscriptionRequestscope, Expression<Func<string>> subscriptionRequestselectColumns = null, Expression<Func<string>> subscriptionRequestfilterRows = null, Expression<Func<string>> subscriptionRequestdelayUntil = null, Expression<Func<int>> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/data/v9.1/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Consistency"] = Convert.ToString("Strong");
            callPayload.Headers["catalog"] = Convert.ToString("all");
            callPayload.Headers["category"] = Convert.ToString("all");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            var subscriptionRequest = new JObject();
            var subscriptionRequestpropCount = 0;
            subscriptionRequest["version"] = 1;
            subscriptionRequestpropCount++;
            subscriptionRequest["url"] = "@listCallbackUrl()";
            subscriptionRequestpropCount++;
            subscriptionRequestpropCount++;
            subscriptionRequest["entityname"] = CSharpExpressionConverter.ConvertToken(subscriptionRequesttableName);
            subscriptionRequestpropCount++;
            subscriptionRequest["message"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestchangeType);
            subscriptionRequestpropCount++;
            subscriptionRequest["scope"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestscope);
            if (subscriptionRequestselectColumns != null)
            {
                subscriptionRequest["filteringattributes"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestselectColumns);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestfilterRows != null)
            {
                subscriptionRequest["filterexpression"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestfilterRows);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestdelayUntil != null)
            {
                subscriptionRequest["postponeuntil"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestdelayUntil);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestrunAs != null)
            {
                subscriptionRequest["runas"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestrunAs);
                subscriptionRequestpropCount++;
            }

            if (subscriptionRequestpropCount > 0)
            {
                callPayload.Body = subscriptionRequest;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessEventsTrigger(Expression<Func<string>> organization, Expression<Func<string>> catalog, Expression<Func<string>> category, Expression<Func<string>> subscriptionRequesttableName, Expression<Func<string>> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/data/v9.2/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Consistency"] = Convert.ToString("Strong");
            callPayload.Headers["organization"] = CSharpExpressionConverter.ConvertO(organization);
            callPayload.Headers["catalog"] = CSharpExpressionConverter.ConvertO(catalog);
            callPayload.Headers["category"] = CSharpExpressionConverter.ConvertO(category);
            var subscriptionRequest = new JObject();
            var subscriptionRequestpropCount = 0;
            subscriptionRequest["version"] = 3;
            subscriptionRequestpropCount++;
            subscriptionRequest["url"] = "@listCallbackUrl()";
            subscriptionRequestpropCount++;
            subscriptionRequest["scope"] = 4;
            subscriptionRequestpropCount++;
            subscriptionRequestpropCount++;
            subscriptionRequest["entityname"] = CSharpExpressionConverter.ConvertToken(subscriptionRequesttableName);
            subscriptionRequestpropCount++;
            subscriptionRequest["sdkmessagename"] = CSharpExpressionConverter.ConvertToken(subscriptionRequestactionName);
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