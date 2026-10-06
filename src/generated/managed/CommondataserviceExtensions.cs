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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityItemList> __BuildListRecords(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> select = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> fetchXml = null, WorkflowExpression<int> top = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<string> partitionId = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(fetchXml, nameof(fetchXml), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(partitionId, nameof(partitionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateRecord(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemCodeless(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> partitionId = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(partitionId, nameof(partitionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRecord(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> partitionId = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(partitionId, nameof(partitionId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateRecord(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateEntityFileImageFieldContent(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> fileImageFieldName, WorkflowExpression<string> xMsFileName, WorkflowExpression<string> item = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            WorkflowExpression.Validate(xMsFileName, nameof(xMsFileName), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetEntityFileImageFieldContent(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> fileImageFieldName, WorkflowExpression<string> size = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            WorkflowExpression.Validate(size, nameof(size), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPerformUnboundAction(WorkflowExpression<string> organization, WorkflowExpression<string> actionName, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(actionName, nameof(actionName), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildPerformBoundAction(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> actionName, WorkflowExpression<string> recordId, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(actionName, nameof(actionName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssociateEntities(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> associationEntityRelationship, WorkflowExpression<string> itemrelateWith)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            WorkflowExpression.Validate(itemrelateWith, nameof(itemrelateWith), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDisassociateEntities(WorkflowExpression<string> organization, WorkflowExpression<string> entityName, WorkflowExpression<string> recordId, WorkflowExpression<string> associationEntityRelationship, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchOutput> __BuildGetRelevantRows(WorkflowExpression<string> organization, WorkflowExpression<string> searchRequestsearchTerm, WorkflowExpression<string> searchRequestsearchType = null, WorkflowExpression<string> searchRequestsearchMode = null, WorkflowExpression<int> searchRequestrowCount = null, WorkflowExpression<string> searchRequestrowFilter = null, WorkflowExpression<string[]> searchRequesttableFilter = null, WorkflowExpression<string[]> searchRequestsortBy = null, WorkflowExpression<string[]> searchRequestfacetQuery = null, WorkflowExpression<int> searchRequestskipRows = null, WorkflowExpression<bool> searchRequestreturnRowCount = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(searchRequestsearchTerm, nameof(searchRequestsearchTerm), required: true);
            WorkflowExpression.Validate(searchRequestsearchType, nameof(searchRequestsearchType), required: false);
            WorkflowExpression.Validate(searchRequestsearchMode, nameof(searchRequestsearchMode), required: false);
            WorkflowExpression.Validate(searchRequestrowCount, nameof(searchRequestrowCount), required: false);
            WorkflowExpression.Validate(searchRequestrowFilter, nameof(searchRequestrowFilter), required: false);
            WorkflowExpression.Validate(searchRequesttableFilter, nameof(searchRequesttableFilter), required: false);
            WorkflowExpression.Validate(searchRequestsortBy, nameof(searchRequestsortBy), required: false);
            WorkflowExpression.Validate(searchRequestfacetQuery, nameof(searchRequestfacetQuery), required: false);
            WorkflowExpression.Validate(searchRequestskipRows, nameof(searchRequestskipRows), required: false);
            WorkflowExpression.Validate(searchRequestreturnRowCount, nameof(searchRequestreturnRowCount), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSubscribeWebhookTrigger(WorkflowExpression<string> organization, WorkflowExpression<string> subscriptionRequesttableName, WorkflowExpression<int> subscriptionRequestchangeType, WorkflowExpression<int> subscriptionRequestscope, WorkflowExpression<string> subscriptionRequestselectColumns = null, WorkflowExpression<string> subscriptionRequestfilterRows = null, WorkflowExpression<string> subscriptionRequestdelayUntil = null, WorkflowExpression<int> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            WorkflowExpression.Validate(subscriptionRequestchangeType, nameof(subscriptionRequestchangeType), required: true);
            WorkflowExpression.Validate(subscriptionRequestscope, nameof(subscriptionRequestscope), required: true);
            WorkflowExpression.Validate(subscriptionRequestselectColumns, nameof(subscriptionRequestselectColumns), required: false);
            WorkflowExpression.Validate(subscriptionRequestfilterRows, nameof(subscriptionRequestfilterRows), required: false);
            WorkflowExpression.Validate(subscriptionRequestdelayUntil, nameof(subscriptionRequestdelayUntil), required: false);
            WorkflowExpression.Validate(subscriptionRequestrunAs, nameof(subscriptionRequestrunAs), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBusinessEventsTrigger(WorkflowExpression<string> organization, WorkflowExpression<string> catalog, WorkflowExpression<string> category, WorkflowExpression<string> subscriptionRequesttableName, WorkflowExpression<string> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(organization, nameof(organization), required: true);
            WorkflowExpression.Validate(catalog, nameof(catalog), required: true);
            WorkflowExpression.Validate(category, nameof(category), required: true);
            WorkflowExpression.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            WorkflowExpression.Validate(subscriptionRequestactionName, nameof(subscriptionRequestactionName), required: true);
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