//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Axtensioncontentgate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AxtensioncontentgateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityRequirementsResponseItem[]> ListContentEntityRequirements(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId)
        {
            var apiCallPath = String.Format("/api/businessentities/{0}/{1}/{2}/Requirements", ExpressionConverter.ConvertWithUrlEncoding(providerReferenceId, 1), ExpressionConverter.ConvertWithUrlEncoding(externalType, 1), ExpressionConverter.ConvertWithUrlEncoding(externalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContentEntityRequirementsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IWorkflowAction CreateContentEntityRequirements(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId, Expression<Func<int>> bodyContentEntityTemplateId = null, Expression<Func<int>> bodyContentEntityTemplateGroupId = null)
        {
            var apiCallPath = String.Format("/api/businessentities/{0}/{1}/{2}/Requirements", ExpressionConverter.ConvertWithUrlEncoding(providerReferenceId, 1), ExpressionConverter.ConvertWithUrlEncoding(externalType, 1), ExpressionConverter.ConvertWithUrlEncoding(externalId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContentEntityTemplateId != null)
            {
                body["ContentEntityTemplateId"] = ExpressionConverter.ConvertO(bodyContentEntityTemplateId);
                bodypropCount++;
            }

            if (bodyContentEntityTemplateGroupId != null)
            {
                body["ContentEntityTemplateGroupId"] = ExpressionConverter.ConvertO(bodyContentEntityTemplateGroupId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityTypesResponseItem[]> ListBusinessEntityTypes()
        {
            var apiCallPath = "/api/businessentitymodel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListBusinessEntityTypesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListViewsResponseItem[]> ListViews(Expression<Func<string>> businessEntityType)
        {
            var apiCallPath = String.Format("/api/BusinessEntityModel/{0}/views", ExpressionConverter.ConvertWithUrlEncoding(businessEntityType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListViewsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityConnectorsResponseItem[]> ListBusinessEntityConnectors()
        {
            var apiCallPath = "/api/BusinessEntityProviders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListBusinessEntityConnectorsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<GetSharedContentLinkResponse> GetSharedContentLink(Expression<Func<string>> contentEntityId)
        {
            var apiCallPath = String.Format("/api/content/{0}/sharedContent", ExpressionConverter.ConvertWithUrlEncoding(contentEntityId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSharedContentLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentCategoriesResponseItem[]> ListContentCategories()
        {
            var apiCallPath = "/api/ContentCategories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContentCategoriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityUserPropertiesResponseItem[]> ListContentEntityUserProperties(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/api/contententities/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContentEntityUserPropertiesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<string> UpdateContentEntityUserProperty(Expression<Func<int>> contentEntityId, Expression<Func<int>> propertyId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/contententities/{0}/properties/{1}", ExpressionConverter.ConvertWithUrlEncoding(contentEntityId, 1), ExpressionConverter.ConvertWithUrlEncoding(propertyId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplatesResponseItem[]> ListContentEntityTemplates()
        {
            var apiCallPath = "/api/contententitytemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContentEntityTemplatesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplateGroupsResponseItem[]> ListContentEntityTemplateGroups()
        {
            var apiCallPath = "/api/contententitytemplategroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListContentEntityTemplateGroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExecuteQueryResponse> ExecuteQuery(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId, Expression<Func<int>> view = null)
        {
            var apiCallPath = String.Format("/api/query/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(providerReferenceId, 1), ExpressionConverter.ConvertWithUrlEncoding(externalType, 1), ExpressionConverter.ConvertWithUrlEncoding(externalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (view != null)
                callPayload.Queries["view"] = ExpressionConverter.Convert(view);
            return new ApiConnectionAction<ExecuteQueryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListStorageConnectorsResponseItem[]> ListStorageConnectors()
        {
            var apiCallPath = "/api/StorageProviders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListStorageConnectorsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<GetLinkedBusinessEntitiesResponseItem[]> GetLinkedBusinessEntities(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/api/ContentEntities/{0}/Connections", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLinkedBusinessEntitiesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<SearchContentEntitiesResponse> SearchContentEntities(Expression<Func<int[]>> searchRequestTemplates = null, Expression<Func<int[]>> searchRequestStorageProviders = null, Expression<Func<int[]>> searchRequestBusinessEntities = null, Expression<Func<int[]>> searchRequestBusinessEntityTypes = null, Expression<Func<searchRequestPropertiesInputItem[]>> searchRequestProperties = null, Expression<Func<int>> searchRequestPagingPage = null, Expression<Func<int>> searchRequestPagingPageSize = null, Expression<Func<string>> searchRequestPagingSortBy = null, Expression<Func<string>> searchRequestPagingSortOrder = null)
        {
            var apiCallPath = "/api/contententities/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var searchRequest = new JObject();
            var searchRequestpropCount = 0;
            if (searchRequestTemplates != null)
            {
                searchRequest["Templates"] = ExpressionConverter.ConvertO(searchRequestTemplates);
                searchRequestpropCount++;
            }

            if (searchRequestStorageProviders != null)
            {
                searchRequest["StorageProviders"] = ExpressionConverter.ConvertO(searchRequestStorageProviders);
                searchRequestpropCount++;
            }

            if (searchRequestBusinessEntities != null)
            {
                searchRequest["BusinessEntities"] = ExpressionConverter.ConvertO(searchRequestBusinessEntities);
                searchRequestpropCount++;
            }

            if (searchRequestBusinessEntityTypes != null)
            {
                searchRequest["BusinessEntityTypes"] = ExpressionConverter.ConvertO(searchRequestBusinessEntityTypes);
                searchRequestpropCount++;
            }

            if (searchRequestProperties != null)
            {
                searchRequest["Properties"] = ExpressionConverter.ConvertO(searchRequestProperties);
                searchRequestpropCount++;
            }

            var PagingObject = new JObject();
            var PagingObjectpropCount = 0;
            if (searchRequestPagingPage != null)
            {
                PagingObject["Page"] = ExpressionConverter.ConvertO(searchRequestPagingPage);
                PagingObjectpropCount++;
            }

            if (searchRequestPagingPageSize != null)
            {
                PagingObject["PageSize"] = ExpressionConverter.ConvertO(searchRequestPagingPageSize);
                PagingObjectpropCount++;
            }

            if (searchRequestPagingSortBy != null)
            {
                PagingObject["SortBy"] = ExpressionConverter.ConvertO(searchRequestPagingSortBy);
                PagingObjectpropCount++;
            }

            if (searchRequestPagingSortOrder != null)
            {
                PagingObject["SortOrder"] = ExpressionConverter.ConvertO(searchRequestPagingSortOrder);
                PagingObjectpropCount++;
            }

            if (PagingObjectpropCount > 0)
            {
                searchRequest["Paging"] = PagingObject;
                searchRequestpropCount++;
            }

            if (searchRequestpropCount > 0)
            {
                callPayload.Body = searchRequest;
            }

            return new ApiConnectionAction<SearchContentEntitiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<QueryResultContentEntityItem> GetContentEntity(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/api/contententities/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<QueryResultContentEntityItem>(callPayload);
        }
    }

    public class AxtensioncontentgateTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenContentAdded(Expression<Func<string[]>> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentcreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Created";
            bodypropCount++;
            if (bodycontentCategories != null)
            {
                body["contentCategories"] = ExpressionConverter.ConvertO(bodycontentCategories);
                bodypropCount++;
            }

            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "Content";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentUpdated(Expression<Func<string[]>> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentupdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Updated";
            bodypropCount++;
            if (bodycontentCategories != null)
            {
                body["contentCategories"] = ExpressionConverter.ConvertO(bodycontentCategories);
                bodypropCount++;
            }

            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "Content";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentDeleted(Expression<Func<string[]>> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentdeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Deleted";
            bodypropCount++;
            if (bodycontentCategories != null)
            {
                body["contentCategories"] = ExpressionConverter.ConvertO(bodycontentCategories);
                bodypropCount++;
            }

            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "Content";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementAdded(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentrequirementcreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Created";
            bodypropCount++;
            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "ContentRequirement";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentrequirementupdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Updated";
            bodypropCount++;
            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "ContentRequirement";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/contentrequirementdeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Deleted";
            bodypropCount++;
            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "ContentRequirement";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTemplateNotificationTriggered(Expression<Func<int>> bodytemplateId = null, Expression<Func<int[]>> bodynotificationIds = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/subscriptions/templatenotificationtriggered";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytemplateId != null)
            {
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodynotificationIds != null)
            {
                body["notificationIds"] = ExpressionConverter.ConvertO(bodynotificationIds);
                bodypropCount++;
            }

            body["name"] = "Power Automate Trigger";
            bodypropCount++;
            body["changeType"] = "Triggered";
            bodypropCount++;
            body["latestSupportedTlsVersion"] = "v1_2";
            bodypropCount++;
            body["notificationContentType"] = "application/json";
            bodypropCount++;
            body["notificationUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["resource"] = "TemplateNotification";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class ListContentEntityRequirementsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("contentEntityTemplateId")]
        public int ContentEntityTemplateId { get; set; }

        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class ListBusinessEntityTypesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public ListBusinessEntityTypesResponseItemTitleType Title { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class ListBusinessEntityTypesResponseItemTitleType
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }
    }

    public class ListViewsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListBusinessEntityConnectorsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class GetSharedContentLinkResponse
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ListContentCategoriesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListContentEntityUserPropertiesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class ListContentEntityTemplatesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }
    }

    public class ListContentEntityTemplateGroupsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }
    }

    public class ExecuteQueryResponse
    {
        [JsonProperty("info")]
        public ExecuteQueryResponseInfoType Info { get; set; }

        [JsonProperty("data")]
        public ExecuteQueryResponseDataType Data { get; set; }

        [JsonProperty("projection")]
        public ExecuteQueryResponseProjectionType Projection { get; set; }
    }

    public class ExecuteQueryResponseInfoType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ExecuteQueryResponseDataType
    {
        [JsonProperty("context")]
        public ExecuteQueryResponseDataTypeContextType Context { get; set; }

        [JsonProperty("businessEntities")]
        public ExecuteQueryResponseDataTypeBusinessEntitiesTypeItem[] BusinessEntities { get; set; }

        [JsonProperty("contentEntities")]
        public QueryResultContentEntityItem[] ContentEntities { get; set; }
    }

    public class ExecuteQueryResponseDataTypeContextType
    {
        [JsonProperty("businessEntityTypeId")]
        public int BusinessEntityTypeId { get; set; }

        [JsonProperty("businessEntityTypeLabel")]
        public string BusinessEntityTypeLabel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("fields")]
        public ExecuteQueryResponseDataTypeContextTypeFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("links")]
        public ExecuteQueryResponseDataTypeContextTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class ExecuteQueryResponseDataTypeContextTypeFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ExecuteQueryResponseDataTypeContextTypeLinksTypeItem
    {
        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("directLink")]
        public string DirectLink { get; set; }
    }

    public class ExecuteQueryResponseDataTypeBusinessEntitiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("commonId")]
        public JToken[] CommonId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("references")]
        public ExecuteQueryResponseDataTypeBusinessEntitiesTypeItemReferencesTypeItem[] References { get; set; }

        [JsonProperty("retrievalPath")]
        public JToken[] RetrievalPath { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class ExecuteQueryResponseDataTypeBusinessEntitiesTypeItemReferencesTypeItem
    {
        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }
    }

    public class QueryResultContentEntityItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("fileTypeDisplayName")]
        public string FileTypeDisplayName { get; set; }

        [JsonProperty("fileUrl")]
        public string FileUrl { get; set; }

        [JsonProperty("fileVersion")]
        public string FileVersion { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("storageProviderId")]
        public int StorageProviderId { get; set; }

        [JsonProperty("storageProviderName")]
        public string StorageProviderName { get; set; }

        [JsonProperty("storageProviderReferenceId")]
        public string StorageProviderReferenceId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("permissions")]
        public QueryResultContentEntityItemPermissionsType Permissions { get; set; }

        [JsonProperty("templatePermissions")]
        public QueryResultContentEntityItemTemplatePermissionsType TemplatePermissions { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("requirementId")]
        public int RequirementId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("detailsUrl")]
        public string DetailsUrl { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("activeContentRequestId")]
        public int ActiveContentRequestId { get; set; }

        [JsonProperty("request")]
        public QueryResultContentEntityItemRequestType Request { get; set; }

        [JsonProperty("openIn")]
        public QueryResultContentEntityItemOpenInType OpenIn { get; set; }

        [JsonProperty("providerIdentifiers")]
        public QueryResultContentEntityItemProviderIdentifiersTypeItem[] ProviderIdentifiers { get; set; }
    }

    public class QueryResultContentEntityItemPermissionsType
    {
        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("create")]
        public bool Create { get; set; }

        [JsonProperty("update")]
        public bool Update { get; set; }

        [JsonProperty("updateContent")]
        public bool UpdateContent { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("download")]
        public bool Download { get; set; }
    }

    public class QueryResultContentEntityItemTemplatePermissionsType
    {
        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("fulfill")]
        public bool Fulfill { get; set; }

        [JsonProperty("request")]
        public bool Request { get; set; }

        [JsonProperty("requestExternal")]
        public bool RequestExternal { get; set; }
    }

    public class QueryResultContentEntityItemRequestType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("reviewAllowed")]
        public bool ReviewAllowed { get; set; }

        [JsonProperty("fulfillmentAllowed")]
        public bool FulfillmentAllowed { get; set; }

        [JsonProperty("declineAllowed")]
        public bool DeclineAllowed { get; set; }
    }

    public class QueryResultContentEntityItemOpenInType
    {
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("editorApps")]
        public QueryResultContentEntityItemOpenInTypeEditorAppsTypeItem[] EditorApps { get; set; }
    }

    public class QueryResultContentEntityItemOpenInTypeEditorAppsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("launchUrl")]
        public string LaunchUrl { get; set; }
    }

    public class QueryResultContentEntityItemProviderIdentifiersTypeItem
    {
        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
    }

    public class ExecuteQueryResponseProjectionType
    {
        [JsonProperty("fields")]
        public ExecuteQueryResponseProjectionTypeFieldsTypeItem[] Fields { get; set; }
    }

    public class ExecuteQueryResponseProjectionTypeFieldsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("referenceTypeId")]
        public int ReferenceTypeId { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class ListStorageConnectorsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class GetLinkedBusinessEntitiesResponseItem
    {
        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }
    }

    public class SearchContentEntitiesResponse
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("items")]
        public QueryResultContentEntityItem[] Items { get; set; }
    }

    public class searchRequestPropertiesInputItem
    {
        public string Property { get; set; }
        public string Operator { get; set; }
        public bool Negate { get; set; }
        public JToken Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Axtensioncontentgate;

    public partial class WorkflowManagedActions
    {
        public AxtensioncontentgateActions Axtensioncontentgate(string connectionId) => new AxtensioncontentgateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AxtensioncontentgateTriggers Axtensioncontentgate(string connectionId) => new AxtensioncontentgateTriggers(connectionId);
    }
}