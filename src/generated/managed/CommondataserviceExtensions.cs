//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommondataserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<EntityItemList> ListRecords(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> expand = null, Expression<Func<string>> fetchXml = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_fetchXml = WorkflowExpression.Compile(fetchXml, nameof(fetchXml), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_partitionId = WorkflowExpression.Compile(partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<EntityItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}", __workflow_entityName.WithUrlEncoding(2)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> CreateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<object>> item = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}", __workflow_entityName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> GetItemCodeless(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_partitionId = WorkflowExpression.Compile(partitionId, nameof(partitionId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> partitionId = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_partitionId = WorkflowExpression.Compile(partitionId, nameof(partitionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_partitionId != null)
                    callPayload.Queries["partitionId"] = ExpressionConverter.Convert(__workflow_partitionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> UpdateRecord(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> xMsFileName, Expression<Func<string>> item = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_fileImageFieldName = WorkflowExpression.Compile(fileImageFieldName, nameof(fileImageFieldName), required: true);
            var __workflow_xMsFileName = WorkflowExpression.Compile(xMsFileName, nameof(xMsFileName), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})/{2}", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2), __workflow_fileImageFieldName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-file-name"] = ExpressionConverter.Convert(__workflow_xMsFileName);
                callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> fileImageFieldName, Expression<Func<string>> size = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_fileImageFieldName = WorkflowExpression.Compile(fileImageFieldName, nameof(fileImageFieldName), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})/{2}/$value", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2), __workflow_fileImageFieldName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformUnboundAction(Expression<Func<string>> organization, Expression<Func<string>> actionName, Expression<Func<object>> item = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_actionName = WorkflowExpression.Compile(actionName, nameof(actionName), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.2/{0}", __workflow_actionName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformBoundAction(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> actionName, Expression<Func<string>> recordId, Expression<Func<object>> item = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_actionName = WorkflowExpression.Compile(actionName, nameof(actionName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.2/{0}({1})/{2}", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2), __workflow_actionName.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> itemrelateWith)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_associationEntityRelationship = WorkflowExpression.Compile(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            var __workflow_itemrelateWith = WorkflowExpression.Compile(itemrelateWith, nameof(itemrelateWith), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2), __workflow_associationEntityRelationship.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities(Expression<Func<string>> organization, Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> id)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_associationEntityRelationship = WorkflowExpression.Compile(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", __workflow_entityName.WithUrlEncoding(2), __workflow_recordId.WithUrlEncoding(2), __workflow_associationEntityRelationship.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["organization"] = ExpressionConverter.Convert(__workflow_organization);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows(Expression<Func<string>> organization, Expression<Func<string>> searchRequestsearchTerm, Expression<Func<string>> searchRequestsearchType = null, Expression<Func<string>> searchRequestsearchMode = null, Expression<Func<int>> searchRequestrowCount = null, Expression<Func<string>> searchRequestrowFilter = null, Expression<Func<string[]>> searchRequesttableFilter = null, Expression<Func<string[]>> searchRequestsortBy = null, Expression<Func<string[]>> searchRequestfacetQuery = null, Expression<Func<int>> searchRequestskipRows = null, Expression<Func<bool>> searchRequestreturnRowCount = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_searchRequestsearchTerm = WorkflowExpression.Compile(searchRequestsearchTerm, nameof(searchRequestsearchTerm), required: true);
            var __workflow_searchRequestsearchType = WorkflowExpression.Compile(searchRequestsearchType, nameof(searchRequestsearchType), required: false);
            var __workflow_searchRequestsearchMode = WorkflowExpression.Compile(searchRequestsearchMode, nameof(searchRequestsearchMode), required: false);
            var __workflow_searchRequestrowCount = WorkflowExpression.Compile(searchRequestrowCount, nameof(searchRequestrowCount), required: false);
            var __workflow_searchRequestrowFilter = WorkflowExpression.Compile(searchRequestrowFilter, nameof(searchRequestrowFilter), required: false);
            var __workflow_searchRequesttableFilter = WorkflowExpression.Compile(searchRequesttableFilter, nameof(searchRequesttableFilter), required: false);
            var __workflow_searchRequestsortBy = WorkflowExpression.Compile(searchRequestsortBy, nameof(searchRequestsortBy), required: false);
            var __workflow_searchRequestfacetQuery = WorkflowExpression.Compile(searchRequestfacetQuery, nameof(searchRequestfacetQuery), required: false);
            var __workflow_searchRequestskipRows = WorkflowExpression.Compile(searchRequestskipRows, nameof(searchRequestskipRows), required: false);
            var __workflow_searchRequestreturnRowCount = WorkflowExpression.Compile(searchRequestreturnRowCount, nameof(searchRequestreturnRowCount), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_subscriptionRequesttableName = WorkflowExpression.Compile(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            var __workflow_subscriptionRequestchangeType = WorkflowExpression.Compile(subscriptionRequestchangeType, nameof(subscriptionRequestchangeType), required: true);
            var __workflow_subscriptionRequestscope = WorkflowExpression.Compile(subscriptionRequestscope, nameof(subscriptionRequestscope), required: true);
            var __workflow_subscriptionRequestselectColumns = WorkflowExpression.Compile(subscriptionRequestselectColumns, nameof(subscriptionRequestselectColumns), required: false);
            var __workflow_subscriptionRequestfilterRows = WorkflowExpression.Compile(subscriptionRequestfilterRows, nameof(subscriptionRequestfilterRows), required: false);
            var __workflow_subscriptionRequestdelayUntil = WorkflowExpression.Compile(subscriptionRequestdelayUntil, nameof(subscriptionRequestdelayUntil), required: false);
            var __workflow_subscriptionRequestrunAs = WorkflowExpression.Compile(subscriptionRequestrunAs, nameof(subscriptionRequestrunAs), required: false);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IWorkflowTrigger BusinessEventsTrigger(Expression<Func<string>> organization, Expression<Func<string>> catalog, Expression<Func<string>> category, Expression<Func<string>> subscriptionRequesttableName, Expression<Func<string>> subscriptionRequestactionName, FlowRecurrence recurrence = null)
        {
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: true);
            var __workflow_catalog = WorkflowExpression.Compile(catalog, nameof(catalog), required: true);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: true);
            var __workflow_subscriptionRequesttableName = WorkflowExpression.Compile(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            var __workflow_subscriptionRequestactionName = WorkflowExpression.Compile(subscriptionRequestactionName, nameof(subscriptionRequestactionName), required: true);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
