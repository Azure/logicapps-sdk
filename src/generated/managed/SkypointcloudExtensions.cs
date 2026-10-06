//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Skypointcloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkypointcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IBodyWorkflowAction<GetEntitiesResponseItem[]> GetEntities([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/dataflows/entities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                callPayload.Queries["$select"] = Convert.ToString("id,name");
                return callPayload;
            }

            return new ApiConnectionAction<GetEntitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItems([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> skip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["top"] = Convert.ToString("100");
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["skip"] = Convert.ToString("0");
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItem([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string> entityName, [WorkflowExpression] Func<string> itemId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/instances/{0}/data/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityName, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(itemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class SkypointcloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnDataflowRefreshComplete([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string[]> bodyevents, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OnDataflowRefreshFail([WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> instanceId, [WorkflowExpression] Func<string[]> bodyevents, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/instances/{0}/manage/hooks/dataflow_refresh_fail", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenantId"] = SourceExpressionConverter.ConvertO(tenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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