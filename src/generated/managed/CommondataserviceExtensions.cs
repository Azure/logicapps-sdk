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
        [WorkflowExpressionFactory(nameof(__BuildListRecords))]
        public IBodyWorkflowAction<EntityItemList> ListRecords([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> fetchXml = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityItemList> __BuildListRecords(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> select = null, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<string> expand = null, WorkflowValue<string> fetchXml = null, WorkflowValue<int> top = null, WorkflowValue<string> skiptoken = null, WorkflowValue<string> partitionId = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(expand, nameof(expand), required: false);
            WorkflowValue.Validate(fetchXml, nameof(fetchXml), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowValue.Validate(partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<EntityItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecord))]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecord(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemCodeless))]
        public IBodyWorkflowAction<JToken> GetItemCodeless([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemCodeless(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> select = null, WorkflowValue<string> expand = null, WorkflowValue<string> partitionId = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(expand, nameof(expand), required: false);
            WorkflowValue.Validate(partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRecord))]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> partitionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRecord(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> partitionId = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(partitionId, nameof(partitionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (partitionId != null)
                    callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRecord))]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateRecord(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEntityFileImageFieldContent))]
        public IWorkflowAction UpdateEntityFileImageFieldContent([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> xMsFileName, [WorkflowExpression] Func<string> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateEntityFileImageFieldContent(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> fileImageFieldName, WorkflowValue<string> xMsFileName, WorkflowValue<string> item = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            WorkflowValue.Validate(xMsFileName, nameof(xMsFileName), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-file-name"] = ExpressionConverter.Convert(xMsFileName);
                callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntityFileImageFieldContent))]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> size = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetEntityFileImageFieldContent(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> fileImageFieldName, WorkflowValue<string> size = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$value", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildPerformUnboundAction))]
        public IBodyWorkflowAction<JToken> PerformUnboundAction([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPerformUnboundAction(WorkflowValue<string> organization, WorkflowValue<string> actionName, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(actionName, nameof(actionName), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildPerformBoundAction))]
        public IBodyWorkflowAction<JToken> PerformBoundAction([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPerformBoundAction(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> actionName, WorkflowValue<string> recordId, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(actionName, nameof(actionName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildAssociateEntities))]
        public IWorkflowAction AssociateEntities([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> itemrelateWith)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssociateEntities(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> associationEntityRelationship, WorkflowValue<string> itemrelateWith)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            WorkflowValue.Validate(itemrelateWith, nameof(itemrelateWith), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildDisassociateEntities))]
        public IWorkflowAction DisassociateEntities([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDisassociateEntities(WorkflowValue<string> organization, WorkflowValue<string> entityName, WorkflowValue<string> recordId, WorkflowValue<string> associationEntityRelationship, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
            WorkflowValue.Validate(recordId, nameof(recordId), required: true);
            WorkflowValue.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$id"] = ExpressionConverter.Convert(id);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [WorkflowExpressionFactory(nameof(__BuildGetRelevantRows))]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> searchRequestsearchTerm, [WorkflowExpression] Func<string> searchRequestsearchType = null, [WorkflowExpression] Func<string> searchRequestsearchMode = null, [WorkflowExpression] Func<int> searchRequestrowCount = null, [WorkflowExpression] Func<string> searchRequestrowFilter = null, [WorkflowExpression] Func<string[]> searchRequesttableFilter = null, [WorkflowExpression] Func<string[]> searchRequestsortBy = null, [WorkflowExpression] Func<string[]> searchRequestfacetQuery = null, [WorkflowExpression] Func<int> searchRequestskipRows = null, [WorkflowExpression] Func<bool> searchRequestreturnRowCount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchOutput> __BuildGetRelevantRows(WorkflowValue<string> organization, WorkflowValue<string> searchRequestsearchTerm, WorkflowValue<string> searchRequestsearchType = null, WorkflowValue<string> searchRequestsearchMode = null, WorkflowValue<int> searchRequestrowCount = null, WorkflowValue<string> searchRequestrowFilter = null, WorkflowValue<string[]> searchRequesttableFilter = null, WorkflowValue<string[]> searchRequestsortBy = null, WorkflowValue<string[]> searchRequestfacetQuery = null, WorkflowValue<int> searchRequestskipRows = null, WorkflowValue<bool> searchRequestreturnRowCount = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(searchRequestsearchTerm, nameof(searchRequestsearchTerm), required: true);
            WorkflowValue.Validate(searchRequestsearchType, nameof(searchRequestsearchType), required: false);
            WorkflowValue.Validate(searchRequestsearchMode, nameof(searchRequestsearchMode), required: false);
            WorkflowValue.Validate(searchRequestrowCount, nameof(searchRequestrowCount), required: false);
            WorkflowValue.Validate(searchRequestrowFilter, nameof(searchRequestrowFilter), required: false);
            WorkflowValue.Validate(searchRequesttableFilter, nameof(searchRequesttableFilter), required: false);
            WorkflowValue.Validate(searchRequestsortBy, nameof(searchRequestsortBy), required: false);
            WorkflowValue.Validate(searchRequestfacetQuery, nameof(searchRequestfacetQuery), required: false);
            WorkflowValue.Validate(searchRequestskipRows, nameof(searchRequestskipRows), required: false);
            WorkflowValue.Validate(searchRequestreturnRowCount, nameof(searchRequestreturnRowCount), required: false);
            return new DeferredBodyAction<SearchOutput>(() =>
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
        [WorkflowExpressionFactory(nameof(__BuildSubscribeWebhookTrigger))]
        public IWorkflowTrigger SubscribeWebhookTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<int> subscriptionRequestchangeType, [WorkflowExpression] Func<int> subscriptionRequestscope, [WorkflowExpression] Func<string> subscriptionRequestselectColumns = null, [WorkflowExpression] Func<string> subscriptionRequestfilterRows = null, [WorkflowExpression] Func<string> subscriptionRequestdelayUntil = null, [WorkflowExpression] Func<int> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSubscribeWebhookTrigger(WorkflowValue<string> organization, WorkflowValue<string> subscriptionRequesttableName, WorkflowValue<int> subscriptionRequestchangeType, WorkflowValue<int> subscriptionRequestscope, WorkflowValue<string> subscriptionRequestselectColumns = null, WorkflowValue<string> subscriptionRequestfilterRows = null, WorkflowValue<string> subscriptionRequestdelayUntil = null, WorkflowValue<int> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            WorkflowValue.Validate(subscriptionRequestchangeType, nameof(subscriptionRequestchangeType), required: true);
            WorkflowValue.Validate(subscriptionRequestscope, nameof(subscriptionRequestscope), required: true);
            WorkflowValue.Validate(subscriptionRequestselectColumns, nameof(subscriptionRequestselectColumns), required: false);
            WorkflowValue.Validate(subscriptionRequestfilterRows, nameof(subscriptionRequestfilterRows), required: false);
            WorkflowValue.Validate(subscriptionRequestdelayUntil, nameof(subscriptionRequestdelayUntil), required: false);
            WorkflowValue.Validate(subscriptionRequestrunAs, nameof(subscriptionRequestrunAs), required: false);
            return new DeferredWorkflowTrigger(() =>
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
                subscriptionRequest["url"] = "#{listCallbackUrl()}";
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildBusinessEventsTrigger))]
        public IWorkflowTrigger BusinessEventsTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> catalog, [WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<string> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBusinessEventsTrigger(WorkflowValue<string> organization, WorkflowValue<string> catalog, WorkflowValue<string> category, WorkflowValue<string> subscriptionRequesttableName, WorkflowValue<string> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(organization, nameof(organization), required: true);
            WorkflowValue.Validate(catalog, nameof(catalog), required: true);
            WorkflowValue.Validate(category, nameof(category), required: true);
            WorkflowValue.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            WorkflowValue.Validate(subscriptionRequestactionName, nameof(subscriptionRequestactionName), required: true);
            return new DeferredWorkflowTrigger(() =>
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
                subscriptionRequest["url"] = "#{listCallbackUrl()}";
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
            }, triggerName);
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
