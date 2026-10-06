//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skypointcloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkypointcloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntities))]
        public IBodyWorkflowAction<GetEntitiesResponseItem[]> GetEntities([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntitiesResponseItem[]> __BuildGetEntities(WorkflowExpression<string> tenantId, WorkflowExpression<string> instanceId)
        {
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            return new DeferredBodyAction<GetEntitiesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/dataflows/entities", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
                callPayload.Queries["$select"] = Convert.ToString("id,name");
                return new ApiConnectionAction<GetEntitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IWorkflowAction GetItems([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> skip = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetItems(WorkflowExpression<string> tenantId, WorkflowExpression<string> instanceId, WorkflowExpression<string> entityName, WorkflowExpression<string> select = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> top = null, WorkflowExpression<string> skip = null)
        {
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["top"] = Convert.ToString("100");
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["skip"] = Convert.ToString("0");
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IWorkflowAction GetItem([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> itemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetItem(WorkflowExpression<string> tenantId, WorkflowExpression<string> instanceId, WorkflowExpression<string> entityName, WorkflowExpression<string> itemId)
        {
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            WorkflowExpression.Validate(itemId, nameof(itemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SkypointcloudTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnDataflowRefreshComplete))]
        public IWorkflowTrigger OnDataflowRefreshComplete([WorkflowExpression] Func<string> tenantId,[WorkflowExpression] Func<string> instanceId,[WorkflowExpression] Func<string[]> bodyevents,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOnDataflowRefreshComplete(WorkflowExpression<string> tenantId,WorkflowExpression<string> instanceId,WorkflowExpression<string[]> bodyevents,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            WorkflowExpression.Validate(bodyevents, nameof(bodyevents), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_complete", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = ExpressionConverter.ConvertO(bodyevents);
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDataflowRefreshFail))]
        public IWorkflowTrigger OnDataflowRefreshFail([WorkflowExpression] Func<string> tenantId,[WorkflowExpression] Func<string> instanceId,[WorkflowExpression] Func<string[]> bodyevents,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOnDataflowRefreshFail(WorkflowExpression<string> tenantId,WorkflowExpression<string> instanceId,WorkflowExpression<string[]> bodyevents,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(instanceId, nameof(instanceId), required: true);
            WorkflowExpression.Validate(bodyevents, nameof(bodyevents), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_fail", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = ExpressionConverter.ConvertO(bodyevents);
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