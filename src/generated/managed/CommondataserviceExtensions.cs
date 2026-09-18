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
        public IBodyWorkflowAction<EntityItemList> ListRecords([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> fetchXml = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(fetchXml, nameof(fetchXml), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(partitionId, nameof(partitionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (fetchXml != null)
                    callPayload.Queries["fetchXml"] = SourceExpressionConverter.ConvertO(fetchXml);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (partitionId != null)
                    callPayload.Queries["partitionId"] = SourceExpressionConverter.ConvertO(partitionId);
                callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction<EntityItemList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> CreateRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> GetItemCodeless([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> partitionId = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(partitionId, nameof(partitionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (partitionId != null)
                    callPayload.Queries["partitionId"] = SourceExpressionConverter.ConvertO(partitionId);
                callPayload.Headers["prefer"] = Convert.ToString("odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> partitionId = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(partitionId, nameof(partitionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (partitionId != null)
                    callPayload.Queries["partitionId"] = SourceExpressionConverter.ConvertO(partitionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> UpdateRecord([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString("return=representation,odata.include-annotations=*");
                callPayload.Headers["accept"] = Convert.ToString("application/json;odata.metadata=full");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> xMsFileName, [WorkflowExpression] Func<string> item = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            SourceExpression.Validate(xMsFileName, nameof(xMsFileName), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileImageFieldName, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["x-ms-file-name"] = SourceExpressionConverter.ConvertO(xMsFileName);
                callPayload.Headers["content-type"] = Convert.ToString("application/octet-stream");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<string> GetEntityFileImageFieldContent([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileImageFieldName, [WorkflowExpression] Func<string> size = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(fileImageFieldName, nameof(fileImageFieldName), required: true);
            SourceExpression.Validate(size, nameof(size), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileImageFieldName, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                callPayload.Headers["Range"] = Convert.ToString("bytes=0-4194303");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformUnboundAction([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(actionName, nameof(actionName), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<JToken> PerformBoundAction([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> actionName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<object> item = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(actionName, nameof(actionName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.2/{0}({1})/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionName, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> itemrelateWith)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            SourceExpression.Validate(itemrelateWith, nameof(itemrelateWith), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(associationEntityRelationship, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                var item = new JObject();
                var itempropCount = 0;
                itempropCount++;
                item["@odata.id"] = SourceExpressionConverter.ConvertToken(itemrelateWith);
                if (itempropCount > 0)
                {
                    callPayload.Body = item;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> associationEntityRelationship, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(associationEntityRelationship, nameof(associationEntityRelationship), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/v9.1/{0}({1})/{2}/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(associationEntityRelationship, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IBodyWorkflowAction<SearchOutput> GetRelevantRows([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> searchRequestsearchTerm, [WorkflowExpression] Func<string> searchRequestsearchType = null, [WorkflowExpression] Func<string> searchRequestsearchMode = null, [WorkflowExpression] Func<int> searchRequestrowCount = null, [WorkflowExpression] Func<string> searchRequestrowFilter = null, [WorkflowExpression] Func<string[]> searchRequesttableFilter = null, [WorkflowExpression] Func<string[]> searchRequestsortBy = null, [WorkflowExpression] Func<string[]> searchRequestfacetQuery = null, [WorkflowExpression] Func<int> searchRequestskipRows = null, [WorkflowExpression] Func<bool> searchRequestreturnRowCount = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(searchRequestsearchTerm, nameof(searchRequestsearchTerm), required: true);
            SourceExpression.Validate(searchRequestsearchType, nameof(searchRequestsearchType), required: false);
            SourceExpression.Validate(searchRequestsearchMode, nameof(searchRequestsearchMode), required: false);
            SourceExpression.Validate(searchRequestrowCount, nameof(searchRequestrowCount), required: false);
            SourceExpression.Validate(searchRequestrowFilter, nameof(searchRequestrowFilter), required: false);
            SourceExpression.Validate(searchRequesttableFilter, nameof(searchRequesttableFilter), required: false);
            SourceExpression.Validate(searchRequestsortBy, nameof(searchRequestsortBy), required: false);
            SourceExpression.Validate(searchRequestfacetQuery, nameof(searchRequestfacetQuery), required: false);
            SourceExpression.Validate(searchRequestskipRows, nameof(searchRequestskipRows), required: false);
            SourceExpression.Validate(searchRequestreturnRowCount, nameof(searchRequestreturnRowCount), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/search/v1.0/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                var searchRequest = new JObject();
                var searchRequestpropCount = 0;
                searchRequestpropCount++;
                searchRequest["search"] = SourceExpressionConverter.ConvertToken(searchRequestsearchTerm);
                if (searchRequestsearchType != null)
                {
                    searchRequest["searchtype"] = SourceExpressionConverter.ConvertToken(searchRequestsearchType);
                    searchRequestpropCount++;
                }

                if (searchRequestsearchMode != null)
                {
                    searchRequest["searchmode"] = SourceExpressionConverter.ConvertToken(searchRequestsearchMode);
                    searchRequestpropCount++;
                }

                if (searchRequestrowCount != null)
                {
                    searchRequest["top"] = SourceExpressionConverter.ConvertToken(searchRequestrowCount);
                    searchRequestpropCount++;
                }

                if (searchRequestrowFilter != null)
                {
                    searchRequest["filter"] = SourceExpressionConverter.ConvertToken(searchRequestrowFilter);
                    searchRequestpropCount++;
                }

                if (searchRequesttableFilter != null)
                {
                    searchRequest["entities"] = SourceExpressionConverter.ConvertToken(searchRequesttableFilter);
                    searchRequestpropCount++;
                }

                if (searchRequestsortBy != null)
                {
                    searchRequest["orderby"] = SourceExpressionConverter.ConvertToken(searchRequestsortBy);
                    searchRequestpropCount++;
                }

                if (searchRequestfacetQuery != null)
                {
                    searchRequest["facets"] = SourceExpressionConverter.ConvertToken(searchRequestfacetQuery);
                    searchRequestpropCount++;
                }

                if (searchRequestskipRows != null)
                {
                    searchRequest["skip"] = SourceExpressionConverter.ConvertToken(searchRequestskipRows);
                    searchRequestpropCount++;
                }

                if (searchRequestreturnRowCount != null)
                {
                    searchRequest["returntotalrecordcount"] = SourceExpressionConverter.ConvertToken(searchRequestreturnRowCount);
                    searchRequestpropCount++;
                }

                if (searchRequestpropCount > 0)
                {
                    callPayload.Body = searchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction ExecuteChangeset()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/v9.1/$batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CommondataserviceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SubscribeWebhookTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<int> subscriptionRequestchangeType, [WorkflowExpression] Func<int> subscriptionRequestscope, [WorkflowExpression] Func<string> subscriptionRequestselectColumns = null, [WorkflowExpression] Func<string> subscriptionRequestfilterRows = null, [WorkflowExpression] Func<string> subscriptionRequestdelayUntil = null, [WorkflowExpression] Func<int> subscriptionRequestrunAs = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            SourceExpression.Validate(subscriptionRequestchangeType, nameof(subscriptionRequestchangeType), required: true);
            SourceExpression.Validate(subscriptionRequestscope, nameof(subscriptionRequestscope), required: true);
            SourceExpression.Validate(subscriptionRequestselectColumns, nameof(subscriptionRequestselectColumns), required: false);
            SourceExpression.Validate(subscriptionRequestfilterRows, nameof(subscriptionRequestfilterRows), required: false);
            SourceExpression.Validate(subscriptionRequestdelayUntil, nameof(subscriptionRequestdelayUntil), required: false);
            SourceExpression.Validate(subscriptionRequestrunAs, nameof(subscriptionRequestrunAs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/v9.1/callbackregistrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Consistency"] = Convert.ToString("Strong");
                callPayload.Headers["catalog"] = Convert.ToString("all");
                callPayload.Headers["category"] = Convert.ToString("all");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                var subscriptionRequest = new JObject();
                var subscriptionRequestpropCount = 0;
                subscriptionRequest["version"] = 1;
                subscriptionRequestpropCount++;
                subscriptionRequest["url"] = "@listCallbackUrl()";
                subscriptionRequestpropCount++;
                subscriptionRequestpropCount++;
                subscriptionRequest["entityname"] = SourceExpressionConverter.ConvertToken(subscriptionRequesttableName);
                subscriptionRequestpropCount++;
                subscriptionRequest["message"] = SourceExpressionConverter.ConvertToken(subscriptionRequestchangeType);
                subscriptionRequestpropCount++;
                subscriptionRequest["scope"] = SourceExpressionConverter.ConvertToken(subscriptionRequestscope);
                if (subscriptionRequestselectColumns != null)
                {
                    subscriptionRequest["filteringattributes"] = SourceExpressionConverter.ConvertToken(subscriptionRequestselectColumns);
                    subscriptionRequestpropCount++;
                }

                if (subscriptionRequestfilterRows != null)
                {
                    subscriptionRequest["filterexpression"] = SourceExpressionConverter.ConvertToken(subscriptionRequestfilterRows);
                    subscriptionRequestpropCount++;
                }

                if (subscriptionRequestdelayUntil != null)
                {
                    subscriptionRequest["postponeuntil"] = SourceExpressionConverter.ConvertToken(subscriptionRequestdelayUntil);
                    subscriptionRequestpropCount++;
                }

                if (subscriptionRequestrunAs != null)
                {
                    subscriptionRequest["runas"] = SourceExpressionConverter.ConvertToken(subscriptionRequestrunAs);
                    subscriptionRequestpropCount++;
                }

                if (subscriptionRequestpropCount > 0)
                {
                    callPayload.Body = subscriptionRequest;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BusinessEventsTrigger([WorkflowExpression] Func<string> organization, [WorkflowExpression] Func<string> catalog, [WorkflowExpression] Func<string> category, [WorkflowExpression] Func<string> subscriptionRequesttableName, [WorkflowExpression] Func<string> subscriptionRequestactionName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(organization, nameof(organization), required: true);
            SourceExpression.Validate(catalog, nameof(catalog), required: true);
            SourceExpression.Validate(category, nameof(category), required: true);
            SourceExpression.Validate(subscriptionRequesttableName, nameof(subscriptionRequesttableName), required: true);
            SourceExpression.Validate(subscriptionRequestactionName, nameof(subscriptionRequestactionName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/v9.2/callbackregistrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Consistency"] = Convert.ToString("Strong");
                callPayload.Headers["organization"] = SourceExpressionConverter.ConvertO(organization);
                callPayload.Headers["catalog"] = SourceExpressionConverter.ConvertO(catalog);
                callPayload.Headers["category"] = SourceExpressionConverter.ConvertO(category);
                var subscriptionRequest = new JObject();
                var subscriptionRequestpropCount = 0;
                subscriptionRequest["version"] = 3;
                subscriptionRequestpropCount++;
                subscriptionRequest["url"] = "@listCallbackUrl()";
                subscriptionRequestpropCount++;
                subscriptionRequest["scope"] = 4;
                subscriptionRequestpropCount++;
                subscriptionRequestpropCount++;
                subscriptionRequest["entityname"] = SourceExpressionConverter.ConvertToken(subscriptionRequesttableName);
                subscriptionRequestpropCount++;
                subscriptionRequest["sdkmessagename"] = SourceExpressionConverter.ConvertToken(subscriptionRequestactionName);
                if (subscriptionRequestpropCount > 0)
                {
                    callPayload.Body = subscriptionRequest;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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