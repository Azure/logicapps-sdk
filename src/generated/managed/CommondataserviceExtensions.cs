//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class CommondataserviceExtensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowTrigger WhenSubscribeWebhookTrigger([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, Expression<Func<CallbackRegistration>> subscriptionRequest)
        {
            var apiCallPath = "/api/data/v9.1/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(subscriptionRequest);
            callPayload.Headers["Consistency"] = "Strong";
            callPayload.Headers["catalog"] = "all";
            callPayload.Headers["category"] = "all";
            return new ApiConnectionTrigger(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<EntityItemList> ListRecords([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> expand = null, Expression<Func<string>> fetchXml = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
            {
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            }

            if (filter != null)
            {
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            }

            if (orderby != null)
            {
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            }

            if (expand != null)
            {
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            }

            if (fetchXml != null)
            {
                callPayload.Queries["fetchXml"] = ExpressionConverter.Convert(fetchXml);
            }

            if (top != null)
            {
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            }

            if (skiptoken != null)
            {
                callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
            }

            if (partitionId != null)
            {
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            }

            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["prefer"] = "odata.include-annotations=*";
            callPayload.Headers["accept"] = "application/json;odata.metadata=full";
            return new ApiConnectionAction<EntityItemList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<JToken> CreateRecord([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<JToken>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            callPayload.Headers["prefer"] = "return=representation,odata.include-annotations=*";
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<JToken> GetItemCodeless([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
            {
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            }

            if (expand != null)
            {
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            }

            if (partitionId != null)
            {
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            }

            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["prefer"] = "odata.include-annotations=*";
            callPayload.Headers["accept"] = "application/json;odata.metadata=full";
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowAction DeleteRecord([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> partitionId = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (partitionId != null)
            {
                callPayload.Queries["partitionId"] = ExpressionConverter.Convert(partitionId);
            }

            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<JToken> UpdateRecord([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<JToken>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            callPayload.Headers["prefer"] = "return=representation,odata.include-annotations=*";
            callPayload.Headers["accept"] = "application/json;odata.metadata=full";
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowAction UpdateEntityFileImageFieldContent([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetAttributeFiltersCodeless")] Expression<Func<string>> fileImageFieldName, Expression<Func<string>> xMsFileName, Expression<Func<string>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["x-ms-file-name"] = ExpressionConverter.Convert(xMsFileName);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            callPayload.Headers["content-type"] = "application/octet-stream";
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<string> GetEntityFileImageFieldContent([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetAttributeFiltersCodeless")] Expression<Func<string>> fileImageFieldName, Expression<Func<string>> size = null)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$value", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(fileImageFieldName, 2));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
            {
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            }

            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["Range"] = "bytes=0-4194303";
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<JToken> PerformUnboundAction([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetUnboundActions")] Expression<Func<string>> actionName, Expression<Func<JToken>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.2/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<JToken> PerformBoundAction([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, [DynamicValues("GetBoundActions")] Expression<Func<string>> actionName, Expression<Func<string>> recordId, Expression<Func<JToken>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.2/{0}({1})/{2}", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(actionName, 2));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowAction AssociateEntities([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetEntityRelationships")] Expression<Func<string>> associationEntityRelationship, Expression<Func<AssociateEntityRequest>> item)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(item);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowAction DisassociateEntities([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetEntityRelationships")] Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/data/v9.1/{0}({1})/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(entityName, 2), ExpressionConverter.ConvertWithUrlEncoding(recordId, 2), ExpressionConverter.ConvertWithUrlEncoding(associationEntityRelationship, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IOutputWorkflowAction<SearchOutput> GetRelevantRows([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, Expression<Func<SearchRequestBody>> searchRequest)
        {
            var apiCallPath = "/api/search/v1.0/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Body = ExpressionConverter.ConvertObject(searchRequest);
            return new ApiConnectionAction<SearchOutput>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowAction ExecuteChangeset([ConnectionName] string connectionId)
        {
            var apiCallPath = "/api/data/v9.1/$batch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public static IWorkflowTrigger WhenBusinessEventsTrigger([ConnectionName] string connectionId, [DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetCatalogs")] Expression<Func<string>> catalog, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> category, Expression<Func<WhenAnActionIsPerformedSubscriptionRequest>> subscriptionRequest)
        {
            var apiCallPath = "/api/data/v9.2/callbackregistrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["organization"] = ExpressionConverter.Convert(organization);
            callPayload.Headers["catalog"] = ExpressionConverter.Convert(catalog);
            callPayload.Headers["category"] = ExpressionConverter.Convert(category);
            callPayload.Body = ExpressionConverter.ConvertObject(subscriptionRequest);
            callPayload.Headers["Consistency"] = "Strong";
            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class CommondataserviceInstance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<EntityItemList> ListRecords([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<string>> expand = null, Expression<Func<string>> fetchXml = null, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> partitionId = null) => CommondataserviceExtensions.ListRecords(connectionId, organization, entityName, select, filter, orderby, expand, fetchXml, top, skiptoken, partitionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<JToken> CreateRecord([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<JToken>> item) => CommondataserviceExtensions.CreateRecord(connectionId, organization, entityName, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<JToken> GetItemCodeless([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<string>> partitionId = null) => CommondataserviceExtensions.GetItemCodeless(connectionId, organization, entityName, recordId, select, expand, partitionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DeleteRecord([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<string>> partitionId = null) => CommondataserviceExtensions.DeleteRecord(connectionId, organization, entityName, recordId, partitionId);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<JToken> UpdateRecord([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, Expression<Func<JToken>> item) => CommondataserviceExtensions.UpdateRecord(connectionId, organization, entityName, recordId, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction UpdateEntityFileImageFieldContent([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetAttributeFiltersCodeless")] Expression<Func<string>> fileImageFieldName, Expression<Func<string>> xMsFileName, Expression<Func<string>> item) => CommondataserviceExtensions.UpdateEntityFileImageFieldContent(connectionId, organization, entityName, recordId, fileImageFieldName, xMsFileName, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<string> GetEntityFileImageFieldContent([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetAttributeFiltersCodeless")] Expression<Func<string>> fileImageFieldName, Expression<Func<string>> size = null) => CommondataserviceExtensions.GetEntityFileImageFieldContent(connectionId, organization, entityName, recordId, fileImageFieldName, size);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<JToken> PerformUnboundAction([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetUnboundActions")] Expression<Func<string>> actionName, Expression<Func<JToken>> item) => CommondataserviceExtensions.PerformUnboundAction(connectionId, organization, actionName, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<JToken> PerformBoundAction([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, [DynamicValues("GetBoundActions")] Expression<Func<string>> actionName, Expression<Func<string>> recordId, Expression<Func<JToken>> item) => CommondataserviceExtensions.PerformBoundAction(connectionId, organization, entityName, actionName, recordId, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction AssociateEntities([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetEntityRelationships")] Expression<Func<string>> associationEntityRelationship, Expression<Func<AssociateEntityRequest>> item) => CommondataserviceExtensions.AssociateEntities(connectionId, organization, entityName, recordId, associationEntityRelationship, item);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction DisassociateEntities([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> entityName, Expression<Func<string>> recordId, [DynamicValues("GetEntityRelationships")] Expression<Func<string>> associationEntityRelationship, Expression<Func<string>> id) => CommondataserviceExtensions.DisassociateEntities(connectionId, organization, entityName, recordId, associationEntityRelationship, id);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IOutputWorkflowAction<SearchOutput> GetRelevantRows([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, Expression<Func<SearchRequestBody>> searchRequest) => CommondataserviceExtensions.GetRelevantRows(connectionId, organization, searchRequest);
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commondataservice")]
        public IWorkflowAction ExecuteChangeset() => CommondataserviceExtensions.ExecuteChangeset(connectionId);
    }

    public class CommondataserviceInstanceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenSubscribeWebhookTrigger([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, Expression<Func<CallbackRegistration>> subscriptionRequest) => CommondataserviceExtensions.WhenSubscribeWebhookTrigger(connectionId, organization, subscriptionRequest);
        public IWorkflowTrigger WhenBusinessEventsTrigger([DynamicValues("GetOrganizations")] Expression<Func<string>> organization, [DynamicValues("GetCatalogs")] Expression<Func<string>> catalog, [DynamicValues("GetEntityListEnum")] Expression<Func<string>> category, Expression<Func<WhenAnActionIsPerformedSubscriptionRequest>> subscriptionRequest) => CommondataserviceExtensions.WhenBusinessEventsTrigger(connectionId, organization, catalog, category, subscriptionRequest);
    }

    public class TabularDataSetsMetadata
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("urlEncoding")]
        public string UrlEncoding { get; set; }

        [JsonProperty("tableDisplayName")]
        public string TableDisplayName { get; set; }

        [JsonProperty("tablePluralName")]
        public string TablePluralName { get; set; }
    }

    public class BlobDataSetsMetadata
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("urlEncoding")]
        public string UrlEncoding { get; set; }
    }

    public class DataSetsMetadata
    {
        [JsonProperty("tabular")]
        public TabularDataSetsMetadata Tabular { get; set; }

        [JsonProperty("blob")]
        public BlobDataSetsMetadata Blob { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class TableSortRestrictionsMetadata
    {
        [JsonProperty("sortable")]
        public bool Sortable { get; set; }

        [JsonProperty("unsortableProperties")]
        public string[] UnsortableProperties { get; set; }

        [JsonProperty("ascendingOnlyProperties")]
        public string[] AscendingOnlyProperties { get; set; }
    }

    public class TableFilterRestrictionsMetadata
    {
        [JsonProperty("filterable")]
        public bool Filterable { get; set; }

        [JsonProperty("nonFilterableProperties")]
        public string[] NonFilterableProperties { get; set; }

        [JsonProperty("requiredProperties")]
        public string[] RequiredProperties { get; set; }
    }

    public class TableSelectRestrictionsMetadata
    {
        [JsonProperty("selectable")]
        public bool Selectable { get; set; }
    }

    public class TableCapabilitiesMetadata
    {
        [JsonProperty("sortRestrictions")]
        public TableSortRestrictionsMetadata SortRestrictions { get; set; }

        [JsonProperty("filterRestrictions")]
        public TableFilterRestrictionsMetadata FilterRestrictions { get; set; }

        [JsonProperty("selectRestrictions")]
        public TableSelectRestrictionsMetadata SelectRestrictions { get; set; }

        [JsonProperty("isOnlyServerPagable")]
        public bool IsOnlyServerPagable { get; set; }

        [JsonProperty("filterFunctionSupport")]
        public TableCapabilitiesMetadataFilterFunctionSupportTypeItem[] FilterFunctionSupport { get; set; }

        [JsonProperty("serverPagingOptions")]
        public TableCapabilitiesMetadataServerPagingOptionsTypeItem[] ServerPagingOptions { get; set; }
    }

    public class TableMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("x-ms-permission")]
        public string XMsPermission { get; set; }

        [JsonProperty("x-ms-capabilities")]
        public TableCapabilitiesMetadata XMsCapabilities { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("referencedEntities")]
        public JToken ReferencedEntities { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }
    }

    public class EntityMetadata
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class EntityRelationshipsDynamicValuesListValueTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EntityRelationshipsDynamicValuesList
    {
        [JsonProperty("value")]
        public EntityRelationshipsDynamicValuesListValueTypeItem[] Value { get; set; }
    }

    public class OrganizationsDynamicValuesListItem
    {
        public string Id { get; set; }
        public string FriendlyName { get; set; }
        public string Url { get; set; }
    }

    public class OrganizationsDynamicValuesList
    {
        [JsonProperty("value")]
        public OrganizationsDynamicValuesListItem[] Value { get; set; }
    }

    public class UserLocalizedLabel
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class DisplayCollectionName
    {
        [JsonProperty("userLocalizedLabel")]
        public UserLocalizedLabel UserLocalizedLabel { get; set; }
    }

    public class EntitiesDynamicValuesListItem
    {
        [JsonProperty("metadataId")]
        public string MetadataId { get; set; }

        [JsonProperty("entitySetName")]
        public string EntitySetName { get; set; }

        [JsonProperty("logicalName")]
        public string LogicalName { get; set; }

        [JsonProperty("displayCollectionName")]
        public DisplayCollectionName DisplayCollectionName { get; set; }
    }

    public class EntitiesDynamicValuesList
    {
        [JsonProperty("value")]
        public EntitiesDynamicValuesListItem[] Value { get; set; }
    }

    public class CallbackRegistration
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("entityname")]
        public string Entityname { get; set; }

        [JsonProperty("message")]
        public int Message { get; set; }

        [JsonProperty("sdkmessagename")]
        public string Sdkmessagename { get; set; }

        [JsonProperty("scope")]
        public int Scope { get; set; }

        [JsonProperty("filteringattributes")]
        public string Filteringattributes { get; set; }

        [JsonProperty("filterexpression")]
        public string Filterexpression { get; set; }

        [JsonProperty("postponeuntil")]
        public string Postponeuntil { get; set; }

        [JsonProperty("runas")]
        public int Runas { get; set; }
    }

    public class EntityItem
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class EntityItemList
    {
        [JsonProperty("value")]
        public EntityItem[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class ActionsDynamicValuesListValueTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ActionsDynamicValuesList
    {
        [JsonProperty("value")]
        public ActionsDynamicValuesListValueTypeItem[] Value { get; set; }
    }

    public class AssociateEntityRequest
    {
        [JsonProperty("@odata.id")]
        public string Id { get; set; }
    }

    public class SearchRequestBody
    {
        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("searchtype")]
        public string Searchtype { get; set; }

        [JsonProperty("searchmode")]
        public string Searchmode { get; set; }

        [JsonProperty("top")]
        public int Top { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("entities")]
        public string[] Entities { get; set; }

        [JsonProperty("orderby")]
        public string[] Orderby { get; set; }

        [JsonProperty("facets")]
        public string[] Facets { get; set; }

        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("returntotalrecordcount")]
        public bool Returntotalrecordcount { get; set; }
    }

    public class SearchOutputValueTypeItem
    {
        [JsonProperty("@search.score")]
        public double SearchScore { get; set; }

        [JsonProperty("@search.highlights")]
        public JToken SearchHighlights { get; set; }

        [JsonProperty("@search.entityname")]
        public string SearchEntityname { get; set; }

        [JsonProperty("@search.objectid")]
        public string SearchObjectid { get; set; }

        [JsonProperty("@search.objecttypecode")]
        public int SearchObjecttypecode { get; set; }
    }

    public class SearchOutput
    {
        [JsonProperty("value")]
        public SearchOutputValueTypeItem[] Value { get; set; }

        [JsonProperty("totalrecordcount")]
        public int Totalrecordcount { get; set; }

        [JsonProperty("facets")]
        public JToken Facets { get; set; }
    }

    public class GetMetadataForActionInputAndResponseForWhenAnActionIsPerformedTriggerResponse
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class WhenAnActionIsPerformedSubscriptionRequest
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scope")]
        public int Scope { get; set; }

        [JsonProperty("entityname")]
        public string Entityname { get; set; }

        [JsonProperty("sdkmessagename")]
        public string Sdkmessagename { get; set; }
    }

    public class GetMetadataForUnboundActionInputResponse
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class GetMetadataForUnboundActionResponseResponse
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class GetMetadataForBoundActionInputResponse
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public class GetMetadataForBoundActionResponseResponse
    {
        [JsonProperty("schema")]
        public JToken Schema { get; set; }
    }

    public enum TableCapabilitiesMetadataFilterFunctionSupportTypeItem
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "ne")]
        Ne,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "ge")]
        Ge,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "le")]
        Le,
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "startswith")]
        Startswith,
        [EnumMember(Value = "endswith")]
        Endswith,
        [EnumMember(Value = "length")]
        Length,
        [EnumMember(Value = "indexof")]
        Indexof,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "substring")]
        Substring,
        [EnumMember(Value = "substringof")]
        Substringof,
        [EnumMember(Value = "tolower")]
        Tolower,
        [EnumMember(Value = "toupper")]
        Toupper,
        [EnumMember(Value = "trim")]
        Trim,
        [EnumMember(Value = "concat")]
        Concat,
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "minute")]
        Minute,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "time")]
        Time,
        [EnumMember(Value = "now")]
        Now,
        [EnumMember(Value = "totaloffsetminutes")]
        Totaloffsetminutes,
        [EnumMember(Value = "totalseconds")]
        Totalseconds,
        [EnumMember(Value = "floor")]
        Floor,
        [EnumMember(Value = "ceiling")]
        Ceiling,
        [EnumMember(Value = "round")]
        Round,
        [EnumMember(Value = "not")]
        Not,
        [EnumMember(Value = "negate")]
        Negate,
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "sub")]
        Sub,
        [EnumMember(Value = "mul")]
        Mul,
        [EnumMember(Value = "div")]
        Div,
        [EnumMember(Value = "mod")]
        Mod,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "average")]
        Average,
        [EnumMember(Value = "countdistinct")]
        Countdistinct,
        [EnumMember(Value = "null")]
        Null
    }

    public enum TableCapabilitiesMetadataServerPagingOptionsTypeItem
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "skiptoken")]
        Skiptoken
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Commondataservice;

    public static class CommondataserviceTriggerInstanceExtensions
    {
        public static CommondataserviceInstanceTriggers Commondataservice(this WorkflowManagedTriggers t, string connectionId) => new CommondataserviceInstanceTriggers(connectionId);
        public static CommondataserviceInstance Commondataservice(this WorkflowManagedActions t, string connectionId) => new CommondataserviceInstance(connectionId);
    }
}