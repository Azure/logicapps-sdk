//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Axtensioncontentgate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AxtensioncontentgateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityRequirementsResponseItem[], ApiConnectionActionConfiguration> ListContentEntityRequirements(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId)
        {
            var __workflow_providerReferenceId = WorkflowExpression.Compile(providerReferenceId, nameof(providerReferenceId), required: true);
            var __workflow_externalType = WorkflowExpression.Compile(externalType, nameof(externalType), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            return new DeferredBodyAction<ListContentEntityRequirementsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/businessentities/{0}/{1}/{2}/Requirements", __workflow_providerReferenceId.WithUrlEncoding(1), __workflow_externalType.WithUrlEncoding(1), __workflow_externalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContentEntityRequirementsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateContentEntityRequirements(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId, Expression<Func<CreateContentEntityRequirementsInput>> body = null)
        {
            var __workflow_providerReferenceId = WorkflowExpression.Compile(providerReferenceId, nameof(providerReferenceId), required: true);
            var __workflow_externalType = WorkflowExpression.Compile(externalType, nameof(externalType), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/businessentities/{0}/{1}/{2}/Requirements", __workflow_providerReferenceId.WithUrlEncoding(1), __workflow_externalType.WithUrlEncoding(1), __workflow_externalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityTypesResponseItem[], ApiConnectionActionConfiguration> ListBusinessEntityTypes()
        {
            return new DeferredBodyAction<ListBusinessEntityTypesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/businessentitymodel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListBusinessEntityTypesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListViewsResponseItem[], ApiConnectionActionConfiguration> ListViews(Expression<Func<string>> businessEntityType)
        {
            var __workflow_businessEntityType = WorkflowExpression.Compile(businessEntityType, nameof(businessEntityType), required: true);
            return new DeferredBodyAction<ListViewsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessEntityModel/{0}/views", __workflow_businessEntityType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListViewsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityConnectorsResponseItem[], ApiConnectionActionConfiguration> ListBusinessEntityConnectors()
        {
            return new DeferredBodyAction<ListBusinessEntityConnectorsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/BusinessEntityProviders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeLinked"] = Convert.ToString(true);
                return new ApiConnectionAction<ListBusinessEntityConnectorsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<GetSharedContentLinkResponse, ApiConnectionActionConfiguration> GetSharedContentLink(Expression<Func<string>> contentEntityId)
        {
            var __workflow_contentEntityId = WorkflowExpression.Compile(contentEntityId, nameof(contentEntityId), required: true);
            return new DeferredBodyAction<GetSharedContentLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/content/{0}/sharedContent", __workflow_contentEntityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSharedContentLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentCategoriesResponseItem[], ApiConnectionActionConfiguration> ListContentCategories()
        {
            return new DeferredBodyAction<ListContentCategoriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ContentCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContentCategoriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityUserPropertiesResponseItem[], ApiConnectionActionConfiguration> ListContentEntityUserProperties(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ListContentEntityUserPropertiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}/properties", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContentEntityUserPropertiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateContentEntityUserProperty(Expression<Func<int>> contentEntityId, Expression<Func<int>> propertyId, Expression<Func<object>> body = null)
        {
            var __workflow_contentEntityId = WorkflowExpression.Compile(contentEntityId, nameof(contentEntityId), required: true);
            var __workflow_propertyId = WorkflowExpression.Compile(propertyId, nameof(propertyId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}/properties/{1}", __workflow_contentEntityId.WithUrlEncoding(1), __workflow_propertyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplatesResponseItem[], ApiConnectionActionConfiguration> ListContentEntityTemplates()
        {
            return new DeferredBodyAction<ListContentEntityTemplatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contententitytemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContentEntityTemplatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplateGroupsResponseItem[], ApiConnectionActionConfiguration> ListContentEntityTemplateGroups()
        {
            return new DeferredBodyAction<ListContentEntityTemplateGroupsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contententitytemplategroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListContentEntityTemplateGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExecuteQueryResponse, ApiConnectionActionConfiguration> ExecuteQuery(Expression<Func<string>> providerReferenceId, Expression<Func<string>> externalType, Expression<Func<string>> externalId, Expression<Func<int>> view = null)
        {
            var __workflow_providerReferenceId = WorkflowExpression.Compile(providerReferenceId, nameof(providerReferenceId), required: true);
            var __workflow_externalType = WorkflowExpression.Compile(externalType, nameof(externalType), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<ExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/query/{0}/{1}/{2}", __workflow_providerReferenceId.WithUrlEncoding(1), __workflow_externalType.WithUrlEncoding(1), __workflow_externalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<ExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListStorageConnectorsResponseItem[], ApiConnectionActionConfiguration> ListStorageConnectors()
        {
            return new DeferredBodyAction<ListStorageConnectorsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/StorageProviders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListStorageConnectorsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<SearchContentEntitiesResponse, ApiConnectionActionConfiguration> SearchContentEntities(Expression<Func<SearchContentEntitiesInput>> searchRequest)
        {
            var __workflow_searchRequest = WorkflowExpression.Compile(searchRequest, nameof(searchRequest), required: true);
            return new DeferredBodyAction<SearchContentEntitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/contententities/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchRequest);
                return new ApiConnectionAction<SearchContentEntitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<QueryResultContentEntityItem, ApiConnectionActionConfiguration> GetContentEntity(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QueryResultContentEntityItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QueryResultContentEntityItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse, ApiConnectionActionConfiguration> AddBusinessEntityReference(Expression<Func<int>> contentEntityId, Expression<Func<AddBusinessEntityReferenceInput>> body = null)
        {
            var __workflow_contentEntityId = WorkflowExpression.Compile(contentEntityId, nameof(contentEntityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExceptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}/references", __workflow_contentEntityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExceptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse, ApiConnectionActionConfiguration> RemoveBusinessEntityReferenceById(Expression<Func<int>> contentEntityId, Expression<Func<int>> referenceId)
        {
            var __workflow_contentEntityId = WorkflowExpression.Compile(contentEntityId, nameof(contentEntityId), required: true);
            var __workflow_referenceId = WorkflowExpression.Compile(referenceId, nameof(referenceId), required: true);
            return new DeferredBodyAction<ExceptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}/references/{1}", __workflow_contentEntityId.WithUrlEncoding(1), __workflow_referenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExceptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse, ApiConnectionActionConfiguration> RemoveBusinessEntityReferenceByExternalId(Expression<Func<int>> contentEntityId, Expression<Func<string>> providerReference, Expression<Func<string>> externalType, Expression<Func<string>> externalId)
        {
            var __workflow_contentEntityId = WorkflowExpression.Compile(contentEntityId, nameof(contentEntityId), required: true);
            var __workflow_providerReference = WorkflowExpression.Compile(providerReference, nameof(providerReference), required: true);
            var __workflow_externalType = WorkflowExpression.Compile(externalType, nameof(externalType), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: true);
            return new DeferredBodyAction<ExceptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/contententities/{0}/references/{1}/{2}/{3}", __workflow_contentEntityId.WithUrlEncoding(1), __workflow_providerReference.WithUrlEncoding(1), __workflow_externalType.WithUrlEncoding(1), __workflow_externalId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExceptionResponse>(callPayload);
            });
        }
    }

    public class AxtensioncontentgateTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentAdded(Expression<Func<WhenContentAddedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentcreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentUpdated(Expression<Func<WhenContentUpdatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentDeleted(Expression<Func<WhenContentDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentdeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentRequirementAdded(Expression<Func<WhenContentRequirementAddedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentrequirementcreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentRequirementUpdated(Expression<Func<WhenContentRequirementUpdatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentrequirementupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenContentRequirementDeleted(Expression<Func<WhenContentRequirementDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/contentrequirementdeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenTemplateNotificationTriggered(Expression<Func<WhenTemplateNotificationTriggeredInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/subscriptions/templatenotificationtriggered";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
        public string Status { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CreateContentEntityRequirementsInput
    {
        public int? ContentEntityTemplateId { get; set; }
        public int? ContentEntityTemplateGroupId { get; set; }
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
        public QueryResultData Data { get; set; }

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

    public class QueryResultData
    {
        [JsonProperty("context")]
        public QueryResultDataContextType Context { get; set; }

        [JsonProperty("businessEntities")]
        public QueryResultDataBusinessEntitiesTypeItem[] BusinessEntities { get; set; }

        [JsonProperty("contentEntities")]
        public QueryResultContentEntityItem[] ContentEntities { get; set; }
    }

    public class QueryResultDataContextType
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
        public QueryResultDataContextTypeFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("links")]
        public QueryResultDataContextTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class QueryResultDataContextTypeFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QueryResultDataContextTypeLinksTypeItem
    {
        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("directLink")]
        public string DirectLink { get; set; }
    }

    public class QueryResultDataBusinessEntitiesTypeItem
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
        public QueryResultDataBusinessEntitiesTypeItemReferencesTypeItem[] References { get; set; }

        [JsonProperty("retrievalPath")]
        public JToken[] RetrievalPath { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class QueryResultDataBusinessEntitiesTypeItemReferencesTypeItem
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

    public class SearchContentEntitiesInput
    {
        public int[] Templates { get; set; }
        public int[] StorageProviders { get; set; }
        public int[] BusinessEntities { get; set; }
        public int[] BusinessEntityTypes { get; set; }
        public SearchContentEntitiesInputPropertiesTypeItem[] Properties { get; set; }
        public SearchContentEntitiesInputPagingType Paging { get; set; }
    }

    public class SearchContentEntitiesInputPropertiesTypeItem
    {
        public string Property { get; set; }
        public string Operator { get; set; }
        public bool? Negate { get; set; }
        public JToken Value { get; set; }
    }

    public class SearchContentEntitiesInputPagingType
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
    }

    public class ExceptionResponse
    {
        [JsonProperty("error")]
        public ExceptionResponseErrorType Error { get; set; }
    }

    public class ExceptionResponseErrorType
    {
        [JsonProperty("status")]
        public double Status { get; set; }

        [JsonProperty("errorId")]
        public string ErrorId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userTitle")]
        public string UserTitle { get; set; }

        [JsonProperty("userMessage")]
        public string UserMessage { get; set; }

        [JsonProperty("contextInfo")]
        public JToken ContextInfo { get; set; }
    }

    public class AddBusinessEntityReferenceInput
    {
        [JsonProperty("businessEntityId")]
        public int? BusinessEntityId { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class WhenContentAddedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Created";

        [JsonProperty("contentCategories")]
        public string[] ContentCategories { get; set; }

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Content";
    }

    public class WhenContentUpdatedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Updated";

        [JsonProperty("contentCategories")]
        public string[] ContentCategories { get; set; }

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Content";
    }

    public class WhenContentDeletedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Deleted";

        [JsonProperty("contentCategories")]
        public string[] ContentCategories { get; set; }

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "Content";
    }

    public class WhenContentRequirementAddedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Created";

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "ContentRequirement";
    }

    public class WhenContentRequirementUpdatedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Updated";

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "ContentRequirement";
    }

    public class WhenContentRequirementDeletedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Deleted";

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "ContentRequirement";
    }

    public class WhenTemplateNotificationTriggeredInput
    {
        [JsonProperty("templateId")]
        public int? TemplateId { get; set; }

        [JsonProperty("notificationIds")]
        public int[] NotificationIds { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate Trigger";

        [JsonProperty("changeType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ChangeType { get; set; } = "Triggered";

        [JsonProperty("latestSupportedTlsVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string LatestSupportedTlsVersion { get; set; } = "v1_2";

        [JsonProperty("notificationContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationContentType { get; set; } = "application/json";

        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("resource", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Resource { get; set; } = "TemplateNotification";
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