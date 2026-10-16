//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skypointcloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkypointcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IBodyWorkflowAction<GetEntitiesResponseItem[]> GetEntities(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<GetEntitiesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/dataflows/entities", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                callPayload.Queries["$select"] = Convert.ToString("id,name");
                return new ApiConnectionAction<GetEntitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItems(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["top"] = Convert.ToString("100");
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["skip"] = Convert.ToString("0");
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItem(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string>> entityName, Expression<Func<string>> itemId)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_itemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SkypointcloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnDataflowRefreshComplete(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string[]>> bodyevents, FlowRecurrence recurrence = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_bodyevents = WorkflowExpression.Compile(bodyevents, nameof(bodyevents), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_complete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger OnDataflowRefreshFail(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string[]>> bodyevents, FlowRecurrence recurrence = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_instanceId = WorkflowExpression.Compile(instanceId, nameof(instanceId), required: true);
            var __workflow_bodyevents = WorkflowExpression.Compile(bodyevents, nameof(bodyevents), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_fail", ExpressionConverter.ConvertWithUrlEncoding(__workflow_instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetEntitiesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceName")]
        public string SourceName { get; set; }

        [JsonProperty("attributes")]
        public GetEntitiesResponseItemAttributesTypeItem[] Attributes { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("annotations")]
        public GetEntitiesResponseItemAnnotationsTypeItem[] Annotations { get; set; }

        [JsonProperty("partitions")]
        public GetEntitiesResponseItemPartitionsTypeItem[] Partitions { get; set; }

        [JsonProperty("schemaDescription")]
        public string SchemaDescription { get; set; }

        [JsonProperty("modifiedTime")]
        public string ModifiedTime { get; set; }
    }

    public class GetEntitiesResponseItemAttributesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datatype")]
        public string Datatype { get; set; }
    }

    public class GetEntitiesResponseItemAnnotationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetEntitiesResponseItemPartitionsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refreshtime")]
        public string Refreshtime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Skypointcloud;

    public partial class WorkflowManagedActions
    {
        public SkypointcloudActions Skypointcloud(string connectionId) => new SkypointcloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SkypointcloudTriggers Skypointcloud(string connectionId) => new SkypointcloudTriggers(connectionId);
    }
}
