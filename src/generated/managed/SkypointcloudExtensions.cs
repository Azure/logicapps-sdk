//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Skypointcloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SkypointcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IBodyWorkflowAction<GetEntitiesResponseItem[]> GetEntities(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId)
        {
            var apiCallPath = String.Format("/instances/{0}/manage/dataflows/entities", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            callPayload.Queries["$select"] = Convert.ToString("id,name");
            return new ApiConnectionAction<GetEntitiesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItems(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string>> entityName, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var apiCallPath = String.Format("/instances/{0}/data/{1}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(entityName, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "skypointcloud")]
        public IWorkflowAction GetItem(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string>> entityName, Expression<Func<string>> itemId)
        {
            var apiCallPath = String.Format("/instances/{0}/data/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(entityName, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class SkypointcloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger GetOnDataflowRefreshComplete(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string[]>> bodyEvents)
        {
            var apiCallPath = String.Format("/instances/{0}/manage/hooks/dataflow_refresh_complete", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Events"] = ExpressionConverter.ConvertO(bodyEvents);
            body["Url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GetOnDataflowRefreshFail(Expression<Func<string>> tenantId, Expression<Func<string>> instanceId, Expression<Func<string[]>> bodyEvents)
        {
            var apiCallPath = String.Format("/instances/{0}/manage/hooks/dataflow_refresh_fail", ExpressionConverter.ConvertWithUrlEncoding(instanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Events"] = ExpressionConverter.ConvertO(bodyEvents);
            body["Url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Skypointcloud;

    public partial class WorkflowManagedActions
    {
        public SkypointcloudActions Skypointcloud(string connectionId) => new SkypointcloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SkypointcloudTriggers Skypointcloud(string connectionId) => new SkypointcloudTriggers(connectionId);
    }
}