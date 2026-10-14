//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CommondataserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<EntityItemList> ListRecords(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> expand = null, Expression<Func<string>> fetchXml = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_orderby = orderby == null ? null : WorkflowExpression.Compile(orderby);
            WorkflowExpression.Validate(__workflow_orderby, nameof(orderby), required: false);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            var __workflow_fetchXml = fetchXml == null ? null : WorkflowExpression.Compile(fetchXml);
            WorkflowExpression.Validate(__workflow_fetchXml, nameof(fetchXml), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skiptoken = skiptoken == null ? null : WorkflowExpression.Compile(skiptoken);
            WorkflowExpression.Validate(__workflow_skiptoken, nameof(skiptoken), required: false);
            var __workflow_partitionId = partitionId == null ? null : WorkflowExpression.Compile(partitionId);
            WorkflowExpression.Validate(__workflow_partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<EntityItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_fetchXml != null)
                    callPayload.Queries["fetchXml"] = ExpressionConverter.Convert(__workflow_fetchXml);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_partitionId != null)
                    callPayload.Queries["partitionId"] = ExpressionConverter.Convert(__workflow_partitionId);
                callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction<EntityItemList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<object>> item = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> GetItemCodeless(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_select = select == null ? null : WorkflowExpression.Compile(select);
            WorkflowExpression.Validate(__workflow_select, nameof(select), required: false);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            var __workflow_partitionId = partitionId == null ? null : WorkflowExpression.Compile(partitionId);
            WorkflowExpression.Validate(__workflow_partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_partitionId != null)
                    callPayload.Queries["partitionId"] = ExpressionConverter.Convert(__workflow_partitionId);
                callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_partitionId = partitionId == null ? null : WorkflowExpression.Compile(partitionId);
            WorkflowExpression.Validate(__workflow_partitionId, nameof(partitionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_partitionId != null)
                    callPayload.Queries["partitionId"] = ExpressionConverter.Convert(__workflow_partitionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> xMsFileName, Expression<Func<string>> item = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_fileImageFieldName = fileImageFieldName == null ? null : WorkflowExpression.Compile(fileImageFieldName);
            WorkflowExpression.Validate(__workflow_fileImageFieldName, nameof(fileImageFieldName), required: true);
            var __workflow_xMsFileName = xMsFileName == null ? null : WorkflowExpression.Compile(xMsFileName);
            WorkflowExpression.Validate(__workflow_xMsFileName, nameof(xMsFileName), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileImageFieldName, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-file-name"] = ExpressionConverter.Convert(__workflow_xMsFileName);
                callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> size = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_fileImageFieldName = fileImageFieldName == null ? null : WorkflowExpression.Compile(fileImageFieldName);
            WorkflowExpression.Validate(__workflow_fileImageFieldName, nameof(fileImageFieldName), required: true);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileImageFieldName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformUnboundAction(Expression<Func<string>> organization, Expression<Func<string>> actionName, Expression<Func<object>> item = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_actionName = actionName == null ? null : WorkflowExpression.Compile(actionName);
            WorkflowExpression.Validate(__workflow_actionName, nameof(actionName), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformBoundAction(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> actionName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_actionName = actionName == null ? null : WorkflowExpression.Compile(actionName);
            WorkflowExpression.Validate(__workflow_actionName, nameof(actionName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> itemrelateWith)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_associationEntityRelationship = associationEntityRelationship == null ? null : WorkflowExpression.Compile(associationEntityRelationship);
            WorkflowExpression.Validate(__workflow_associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            var __workflow_itemrelateWith = itemrelateWith == null ? null : WorkflowExpression.Compile(itemrelateWith);
            WorkflowExpression.Validate(__workflow_itemrelateWith, nameof(itemrelateWith), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_associationEntityRelationship, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["@odata.id"] = ExpressionConverter.ConvertO(__workflow_itemrelateWith);
                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> id)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_entityName = entityName == null ? null : WorkflowExpression.Compile(entityName);
            WorkflowExpression.Validate(__workflow_entityName, nameof(entityName), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_associationEntityRelationship = associationEntityRelationship == null ? null : WorkflowExpression.Compile(associationEntityRelationship);
            WorkflowExpression.Validate(__workflow_associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_associationEntityRelationship, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows(Expression<Func<string>> organization, Expression<Func<string>> searchRequestsearchTerm, Expression<Func<string>> searchRequestsearchType = null, Expression<Func<string>> searchRequestsearchMode = null, Expression<Func<int>> searchRequestrowCount = null, Expression<Func<string>> searchRequestrowFilter = null, Expression<Func<string[]>> searchRequesttableFilter = null, Expression<Func<string[]>> searchRequestsortBy = null, Expression<Func<string[]>> searchRequestfacetQuery = null, Expression<Func<int>> searchRequestskipRows = null, Expression<Func<bool>> searchRequestreturnRowCount = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_searchRequestsearchTerm = searchRequestsearchTerm == null ? null : WorkflowExpression.Compile(searchRequestsearchTerm);
            WorkflowExpression.Validate(__workflow_searchRequestsearchTerm, nameof(searchRequestsearchTerm), required: true);
            var __workflow_searchRequestsearchType = searchRequestsearchType == null ? null : WorkflowExpression.Compile(searchRequestsearchType);
            WorkflowExpression.Validate(__workflow_searchRequestsearchType, nameof(searchRequestsearchType), required: false);
            var __workflow_searchRequestsearchMode = searchRequestsearchMode == null ? null : WorkflowExpression.Compile(searchRequestsearchMode);
            WorkflowExpression.Validate(__workflow_searchRequestsearchMode, nameof(searchRequestsearchMode), required: false);
            var __workflow_searchRequestrowCount = searchRequestrowCount == null ? null : WorkflowExpression.Compile(searchRequestrowCount);
            WorkflowExpression.Validate(__workflow_searchRequestrowCount, nameof(searchRequestrowCount), required: false);
            var __workflow_searchRequestrowFilter = searchRequestrowFilter == null ? null : WorkflowExpression.Compile(searchRequestrowFilter);
            WorkflowExpression.Validate(__workflow_searchRequestrowFilter, nameof(searchRequestrowFilter), required: false);
            var __workflow_searchRequesttableFilter = searchRequesttableFilter == null ? null : WorkflowExpression.Compile(searchRequesttableFilter);
            WorkflowExpression.Validate(__workflow_searchRequesttableFilter, nameof(searchRequesttableFilter), required: false);
            var __workflow_searchRequestsortBy = searchRequestsortBy == null ? null : WorkflowExpression.Compile(searchRequestsortBy);
            WorkflowExpression.Validate(__workflow_searchRequestsortBy, nameof(searchRequestsortBy), required: false);
            var __workflow_searchRequestfacetQuery = searchRequestfacetQuery == null ? null : WorkflowExpression.Compile(searchRequestfacetQuery);
            WorkflowExpression.Validate(__workflow_searchRequestfacetQuery, nameof(searchRequestfacetQuery), required: false);
            var __workflow_searchRequestskipRows = searchRequestskipRows == null ? null : WorkflowExpression.Compile(searchRequestskipRows);
            WorkflowExpression.Validate(__workflow_searchRequestskipRows, nameof(searchRequestskipRows), required: false);
            var __workflow_searchRequestreturnRowCount = searchRequestreturnRowCount == null ? null : WorkflowExpression.Compile(searchRequestreturnRowCount);
            WorkflowExpression.Validate(__workflow_searchRequestreturnRowCount, nameof(searchRequestreturnRowCount), required: false);
            return new DeferredBodyAction<SearchOutput>(() =>
            {
                var apiCallPath = "/api/search/v1.0/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                var searchRequest = new JObject();
                var searchRequestpropCount = 0;
                searchRequestpropCount++;
                searchRequest["search"] = ExpressionConverter.ConvertO(__workflow_searchRequestsearchTerm);
                if (__workflow_searchRequestsearchType != null)
                {
                    searchRequest["searchtype"] = ExpressionConverter.ConvertO(__workflow_searchRequestsearchType);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestsearchMode != null)
                {
                    searchRequest["searchmode"] = ExpressionConverter.ConvertO(__workflow_searchRequestsearchMode);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestrowCount != null)
                {
                    searchRequest["top"] = ExpressionConverter.ConvertO(__workflow_searchRequestrowCount);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestrowFilter != null)
                {
                    searchRequest["filter"] = ExpressionConverter.ConvertO(__workflow_searchRequestrowFilter);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequesttableFilter != null)
                {
                    searchRequest["entities"] = ExpressionConverter.ConvertO(__workflow_searchRequesttableFilter);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestsortBy != null)
                {
                    searchRequest["orderby"] = ExpressionConverter.ConvertO(__workflow_searchRequestsortBy);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestfacetQuery != null)
                {
                    searchRequest["facets"] = ExpressionConverter.ConvertO(__workflow_searchRequestfacetQuery);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestskipRows != null)
                {
                    searchRequest["skip"] = ExpressionConverter.ConvertO(__workflow_searchRequestskipRows);
                    searchRequestpropCount++;
                }

                if (__workflow_searchRequestreturnRowCount != null)
                {
                    searchRequest["returntotalrecordcount"] = ExpressionConverter.ConvertO(__workflow_searchRequestreturnRowCount);
                    searchRequestpropCount++;
                }

                if (searchRequestpropCount > 0)
                {
                    callPayload.Body = searchRequest;
                }

                return new ApiConnectionAction<SearchOutput>(callPayload);
            });
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
        public IWorkflowTrigger SubscribeWebhookTrigger(Expression<Func<string>> organization, Expression<Func<string>> subscriptionRequesttableName, Expression<Func<int>> subscriptionRequestchangeType, Expression<Func<int>> subscriptionRequestscope, Expression<Func<string>> subscriptionRequestselectColumns = null, Expression<Func<string>> subscriptionRequestfilterRows = null, Expression<Func<string>> subscriptionRequestdelayUntil = null, Expression<Func<int>> subscriptionRequestrunAs = null, FlowRecurrence recurrence = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_subscriptionRequesttableName = subscriptionRequesttableName == null ? null : WorkflowExpression.Compile(subscriptionRequesttableName);
            WorkflowExpression.Validate(__workflow_subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            var __workflow_subscriptionRequestchangeType = subscriptionRequestchangeType == null ? null : WorkflowExpression.Compile(subscriptionRequestchangeType);
            WorkflowExpression.Validate(__workflow_subscriptionRequestchangeType, nameof(subscriptionRequestchangeType), required: true);
            var __workflow_subscriptionRequestscope = subscriptionRequestscope == null ? null : WorkflowExpression.Compile(subscriptionRequestscope);
            WorkflowExpression.Validate(__workflow_subscriptionRequestscope, nameof(subscriptionRequestscope), required: true);
            var __workflow_subscriptionRequestselectColumns = subscriptionRequestselectColumns == null ? null : WorkflowExpression.Compile(subscriptionRequestselectColumns);
            WorkflowExpression.Validate(__workflow_subscriptionRequestselectColumns, nameof(subscriptionRequestselectColumns), required: false);
            var __workflow_subscriptionRequestfilterRows = subscriptionRequestfilterRows == null ? null : WorkflowExpression.Compile(subscriptionRequestfilterRows);
            WorkflowExpression.Validate(__workflow_subscriptionRequestfilterRows, nameof(subscriptionRequestfilterRows), required: false);
            var __workflow_subscriptionRequestdelayUntil = subscriptionRequestdelayUntil == null ? null : WorkflowExpression.Compile(subscriptionRequestdelayUntil);
            WorkflowExpression.Validate(__workflow_subscriptionRequestdelayUntil, nameof(subscriptionRequestdelayUntil), required: false);
            var __workflow_subscriptionRequestrunAs = subscriptionRequestrunAs == null ? null : WorkflowExpression.Compile(subscriptionRequestrunAs);
            WorkflowExpression.Validate(__workflow_subscriptionRequestrunAs, nameof(subscriptionRequestrunAs), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/data/v9.1/callbackregistrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Consistency"] = Convert.ToString("Strong");
                callPayload.Headers["catalog"] = Convert.ToString("all");
                callPayload.Headers["category"] = Convert.ToString("all");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                var subscriptionRequest = new JObject();
                var subscriptionRequestpropCount = 0;
                subscriptionRequest["version"] = 1;
                subscriptionRequestpropCount++;
                subscriptionRequest["url"] = "#{listCallbackUrl()}";
                subscriptionRequestpropCount++;
                subscriptionRequestpropCount++;
                subscriptionRequest["entityname"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequesttableName);
                subscriptionRequestpropCount++;
                subscriptionRequest["message"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestchangeType);
                subscriptionRequestpropCount++;
                subscriptionRequest["scope"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestscope);
                if (__workflow_subscriptionRequestselectColumns != null)
                {
                    subscriptionRequest["filteringattributes"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestselectColumns);
                    subscriptionRequestpropCount++;
                }

                if (__workflow_subscriptionRequestfilterRows != null)
                {
                    subscriptionRequest["filterexpression"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestfilterRows);
                    subscriptionRequestpropCount++;
                }

                if (__workflow_subscriptionRequestdelayUntil != null)
                {
                    subscriptionRequest["postponeuntil"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestdelayUntil);
                    subscriptionRequestpropCount++;
                }

                if (__workflow_subscriptionRequestrunAs != null)
                {
                    subscriptionRequest["runas"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestrunAs);
                    subscriptionRequestpropCount++;
                }

                if (subscriptionRequestpropCount > 0)
                {
                    callPayload.Body = subscriptionRequest;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BusinessEventsTrigger(Expression<Func<string>> organization, Expression<Func<string>> catalog, Expression<Func<string>> category, Expression<Func<string>> subscriptionRequesttableName, Expression<Func<string>> subscriptionRequestactionName, FlowRecurrence recurrence = null)
        {
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: true);
            var __workflow_catalog = catalog == null ? null : WorkflowExpression.Compile(catalog);
            WorkflowExpression.Validate(__workflow_catalog, nameof(catalog), required: true);
            var __workflow_category = category == null ? null : WorkflowExpression.Compile(category);
            WorkflowExpression.Validate(__workflow_category, nameof(category), required: true);
            var __workflow_subscriptionRequesttableName = subscriptionRequesttableName == null ? null : WorkflowExpression.Compile(subscriptionRequesttableName);
            WorkflowExpression.Validate(__workflow_subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            var __workflow_subscriptionRequestactionName = subscriptionRequestactionName == null ? null : WorkflowExpression.Compile(subscriptionRequestactionName);
            WorkflowExpression.Validate(__workflow_subscriptionRequestactionName, nameof(subscriptionRequestactionName), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/data/v9.2/callbackregistrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Consistency"] = Convert.ToString("Strong");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Headers["catalog"] = ExpressionConverter.Convert(__workflow_catalog);
                callPayload.Headers["category"] = ExpressionConverter.Convert(__workflow_category);
                var subscriptionRequest = new JObject();
                var subscriptionRequestpropCount = 0;
                subscriptionRequest["version"] = 3;
                subscriptionRequestpropCount++;
                subscriptionRequest["url"] = "#{listCallbackUrl()}";
                subscriptionRequestpropCount++;
                subscriptionRequest["scope"] = 4;
                subscriptionRequestpropCount++;
                subscriptionRequestpropCount++;
                subscriptionRequest["entityname"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequesttableName);
                subscriptionRequestpropCount++;
                subscriptionRequest["sdkmessagename"] = ExpressionConverter.ConvertO(__workflow_subscriptionRequestactionName);
                if (subscriptionRequestpropCount > 0)
                {
                    callPayload.Body = subscriptionRequest;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
