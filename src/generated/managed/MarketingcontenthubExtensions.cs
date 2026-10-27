//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Marketingcontenthub
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarketingcontenthubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<AddFetchJobResponse, ApiConnectionActionConfiguration> AddFetchJob(Expression<Func<AddFetchJobInput>> items = null)
        {
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<AddFetchJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/fetchjobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_items != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_items);
                return new ApiConnectionAction<AddFetchJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<GetFetchJobByIdResponse, ApiConnectionActionConfiguration> GetFetchJobById(Expression<Func<double>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFetchJobByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/fetchjobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFetchJobByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListEntitiesByDefinition(Expression<Func<string>> typeDynamic, Expression<Func<string>> take = null, Expression<Func<string>> skip = null, Expression<Func<string>> members = null, Expression<Func<string>> renditions = null, Expression<Func<string>> culture = null, Expression<Func<string>> sort = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> sortCulture = null)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_renditions = WorkflowExpression.Compile(renditions, nameof(renditions), required: false);
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_sortCulture = WorkflowExpression.Compile(sortCulture, nameof(sortCulture), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/entitydefinitions/{0}/entities", __workflow_typeDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_renditions != null)
                    callPayload.Queries["renditions"] = ExpressionConverter.Convert(__workflow_renditions);
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_sortCulture != null)
                    callPayload.Queries["sortCulture"] = ExpressionConverter.Convert(__workflow_sortCulture);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<AddEntityByDefinitionResponse, ApiConnectionActionConfiguration> AddEntityByDefinition(Expression<Func<string>> typeDynamic, Expression<Func<object>> dynamicTypeSchema = null)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_dynamicTypeSchema = WorkflowExpression.Compile(dynamicTypeSchema, nameof(dynamicTypeSchema), required: false);
            return new DeferredBodyAction<AddEntityByDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/entities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["type-dynamic"] = ExpressionConverter.Convert(__workflow_typeDynamic);
                if (__workflow_dynamicTypeSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTypeSchema);
                return new ApiConnectionAction<AddEntityByDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEntityByIdentifier(Expression<Func<string>> typeDynamic, Expression<Func<string>> identifier)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/entities/identifier/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["type-dynamic"] = ExpressionConverter.Convert(__workflow_typeDynamic);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateEntityByIdentifier(Expression<Func<string>> typeDynamic, Expression<Func<string>> identifier, Expression<Func<object>> dynamicTypeSchema = null)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            var __workflow_dynamicTypeSchema = WorkflowExpression.Compile(dynamicTypeSchema, nameof(dynamicTypeSchema), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/entities/identifier/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["type-dynamic"] = ExpressionConverter.Convert(__workflow_typeDynamic);
                if (__workflow_dynamicTypeSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTypeSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEntityByIdentifier(Expression<Func<string>> identifier)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/entities/identifier/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> QueryEntitiesByDefinitionSimple(Expression<Func<string>> typeDynamic, Expression<Func<object>> dynamicTypeSchema = null, Expression<Func<string>> take = null, Expression<Func<string>> skip = null, Expression<Func<string>> members = null, Expression<Func<string>> renditions = null, Expression<Func<string>> culture = null, Expression<Func<string>> sort = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> sortCulture = null)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_dynamicTypeSchema = WorkflowExpression.Compile(dynamicTypeSchema, nameof(dynamicTypeSchema), required: false);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_renditions = WorkflowExpression.Compile(renditions, nameof(renditions), required: false);
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_sortCulture = WorkflowExpression.Compile(sortCulture, nameof(sortCulture), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/entities/query/simple";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_renditions != null)
                    callPayload.Queries["renditions"] = ExpressionConverter.Convert(__workflow_renditions);
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_sortCulture != null)
                    callPayload.Queries["sortCulture"] = ExpressionConverter.Convert(__workflow_sortCulture);
                callPayload.Headers["type-dynamic"] = ExpressionConverter.Convert(__workflow_typeDynamic);
                if (__workflow_dynamicTypeSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTypeSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketingcontenthub")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> QueryEntitiesByDefinitionAdvanced(Expression<Func<string>> typeDynamic, Expression<Func<string>> query, Expression<Func<string>> take = null, Expression<Func<string>> skip = null, Expression<Func<string>> members = null, Expression<Func<string>> renditions = null, Expression<Func<string>> culture = null, Expression<Func<string>> sort = null, Expression<Func<orderInput>> order = null, Expression<Func<string>> sortCulture = null)
        {
            var __workflow_typeDynamic = WorkflowExpression.Compile(typeDynamic, nameof(typeDynamic), required: true);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_take = WorkflowExpression.Compile(take, nameof(take), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_renditions = WorkflowExpression.Compile(renditions, nameof(renditions), required: false);
            var __workflow_culture = WorkflowExpression.Compile(culture, nameof(culture), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_sortCulture = WorkflowExpression.Compile(sortCulture, nameof(sortCulture), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/entities/query/advanced";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_take != null)
                    callPayload.Queries["take"] = ExpressionConverter.Convert(__workflow_take);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_renditions != null)
                    callPayload.Queries["renditions"] = ExpressionConverter.Convert(__workflow_renditions);
                if (__workflow_culture != null)
                    callPayload.Queries["culture"] = ExpressionConverter.Convert(__workflow_culture);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_sortCulture != null)
                    callPayload.Queries["sortCulture"] = ExpressionConverter.Convert(__workflow_sortCulture);
                callPayload.Headers["type-dynamic"] = ExpressionConverter.Convert(__workflow_typeDynamic);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class MarketingcontenthubTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> OnEntitySaveTrigger(Expression<Func<OnEntitySaveTriggerInput>> addSaveEntityTriggerSchema, FlowRecurrence recurrence = null)
        {
            var __workflow_addSaveEntityTriggerSchema = WorkflowExpression.Compile(addSaveEntityTriggerSchema, nameof(addSaveEntityTriggerSchema), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/triggers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addSaveEntityTriggerSchema);
                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AddFetchJobResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AddFetchJobInput
    {
        [JsonProperty("assetId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetId { get; set; }

        [JsonProperty("uri", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Uri { get; set; }
    }

    public class GetFetchJobByIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public int FilesCount { get; set; }
        public int FilesCompleted { get; set; }
        public string State { get; set; }
        public string StateDescription { get; set; }
        public string Condition { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        Asc,
        Desc
    }

    public class AddEntityByDefinitionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }

    public class OnEntitySaveTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("entitydefinition")]
        public string EntityDefinition { get; set; }

        [JsonProperty("triggername")]
        public string TriggerName { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Marketingcontenthub;

    public partial class WorkflowManagedActions
    {
        public MarketingcontenthubActions Marketingcontenthub(string connectionId) => new MarketingcontenthubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarketingcontenthubTriggers Marketingcontenthub(string connectionId) => new MarketingcontenthubTriggers(connectionId);
    }
}