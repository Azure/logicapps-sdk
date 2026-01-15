//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Azuredigitaltwins
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredigitaltwinsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<AddModelsResponseItem[]> AddModels(Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = "/models";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<AddModelsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListModelsResponse> ListModels(Expression<Func<string>> dependenciesFor = null, Expression<Func<string>> includeModelDefinition = null, Expression<Func<string>> continuationToken = null)
        {
            var apiCallPath = "/models";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (dependenciesFor != null)
                callPayload.Queries["dependenciesFor"] = ExpressionConverter.Convert(dependenciesFor);
            if (includeModelDefinition != null)
                callPayload.Queries["includeModelDefinition"] = ExpressionConverter.Convert(includeModelDefinition);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            if (continuationToken != null)
                callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
            return new ApiConnectionAction<ListModelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteModel(Expression<Func<string>> modelid)
        {
            var apiCallPath = String.Format("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<GetModelByIdResponse> GetModelById(Expression<Func<string>> modelid, Expression<Func<string>> includeModelDefinition = null)
        {
            var apiCallPath = String.Format("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeModelDefinition != null)
                callPayload.Queries["includeModelDefinition"] = ExpressionConverter.Convert(includeModelDefinition);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<GetModelByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateModel(Expression<Func<string>> modelid, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinResult> GetTwinById(Expression<Func<string>> twinid)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<TwinResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteTwin(Expression<Func<string>> twinid)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinResult> AddTwin(Expression<Func<string>> twinid, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TwinResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateTwin(Expression<Func<string>> twinid, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<GetComponentResult> GetComponent(Expression<Func<string>> twinid, Expression<Func<string>> componentPath)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<GetComponentResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateComponent(Expression<Func<string>> twinid, Expression<Func<string>> componentPath, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinRelationship> GetRelationshipById(Expression<Func<string>> twinid, Expression<Func<string>> relationshipId)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<TwinRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteRelationship(Expression<Func<string>> twinid, Expression<Func<string>> relationshipId)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinRelationship> AddRelationship(Expression<Func<string>> twinid, Expression<Func<string>> relationshipId, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TwinRelationship>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateRelationship(Expression<Func<string>> twinid, Expression<Func<string>> relationshipId, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListIncomingRelationshipsResponse> ListIncomingRelationships(Expression<Func<string>> twinid, Expression<Func<string>> continuationToken = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/incomingrelationships", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (continuationToken != null)
                callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<ListIncomingRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction SendTelemetry(Expression<Func<string>> twinid, Expression<Func<string>> messageId, Expression<Func<string>> telemetrySourceTime = null, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/telemetry", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            callPayload.Headers["Message-Id"] = ExpressionConverter.Convert(messageId);
            if (telemetrySourceTime != null)
                callPayload.Headers["Telemetry-Source-Time"] = ExpressionConverter.Convert(telemetrySourceTime);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction SendComponentTelemetry(Expression<Func<string>> twinid, Expression<Func<string>> componentPath, Expression<Func<string>> messageId, Expression<Func<string>> telemetrySourceTime = null, Expression<Func<string>> bodyvalue = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/components/{1}/telemetry", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            callPayload.Headers["Message-Id"] = ExpressionConverter.Convert(messageId);
            if (telemetrySourceTime != null)
                callPayload.Headers["Telemetry-Source-Time"] = ExpressionConverter.Convert(telemetrySourceTime);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListRelationshipsResponse> ListRelationships(Expression<Func<string>> twinid, Expression<Func<string>> continuationToken = null)
        {
            var apiCallPath = String.Format("/digitaltwins/{0}/relationships", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (continuationToken != null)
                callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            return new ApiConnectionAction<ListRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<QueryResult> QueryTwins(Expression<Func<string>> bodyquery = null, Expression<Func<string>> bodycontinuationToken = null)
        {
            var apiCallPath = "/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquery != null)
            {
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
            }

            if (bodycontinuationToken != null)
            {
                body["continuationToken"] = ExpressionConverter.ConvertO(bodycontinuationToken);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QueryResult>(callPayload);
        }
    }

    public class AzuredigitaltwinsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddModelsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public AddModelsResponseItemDisplayNameType DisplayName { get; set; }

        [JsonProperty("uploadTime")]
        public string UploadTime { get; set; }

        [JsonProperty("decommissioned")]
        public bool Decommissioned { get; set; }
    }

    public class AddModelsResponseItemDisplayNameType
    {
        [JsonProperty("additionalProperties")]
        public string AdditionalProperties { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("contents")]
        public bodyInputItemContentsTypeItem[] Contents { get; set; }

        [JsonProperty("@context")]
        public string Context { get; set; }
    }

    public class bodyInputItemContentsTypeItem
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class ListModelsResponse
    {
        [JsonProperty("value")]
        public ListModelsResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class ListModelsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uploadTime")]
        public string UploadTime { get; set; }

        [JsonProperty("decommissioned")]
        public bool Decommissioned { get; set; }

        [JsonProperty("model")]
        public ListModelsResponseValueTypeItemModelType Model { get; set; }

        [JsonProperty("displayName")]
        public ListModelsResponseValueTypeItemDisplayNameType DisplayName { get; set; }
    }

    public class ListModelsResponseValueTypeItemModelType
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("contents")]
        public ListModelsResponseValueTypeItemModelTypeContentsTypeItem[] Contents { get; set; }

        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ListModelsResponseValueTypeItemModelTypeContentsTypeItem
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class ListModelsResponseValueTypeItemDisplayNameType
    {
        [JsonProperty("additionalProperties")]
        public string AdditionalProperties { get; set; }
    }

    public class GetModelByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uploadTime")]
        public string UploadTime { get; set; }

        [JsonProperty("decommissioned")]
        public bool Decommissioned { get; set; }

        [JsonProperty("model")]
        public GetModelByIdResponseModelType Model { get; set; }
    }

    public class GetModelByIdResponseModelType
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("contents")]
        public GetModelByIdResponseModelTypeContentsTypeItem[] Contents { get; set; }

        [JsonProperty("@context")]
        public string Context { get; set; }
    }

    public class GetModelByIdResponseModelTypeContentsTypeItem
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("schema")]
        public string Schema { get; set; }
    }

    public class TwinResult
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class GetComponentResult
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class TwinRelationship
    {
        [JsonProperty("$sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("$relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("$targetId")]
        public string TargetId { get; set; }

        [JsonProperty("$relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty("$etag")]
        public string Etag { get; set; }

        [JsonProperty("additionalProperties")]
        public string AdditionalProperties { get; set; }
    }

    public class ListIncomingRelationshipsResponse
    {
        [JsonProperty("value")]
        public IncomingRelationship[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class IncomingRelationship
    {
        [JsonProperty("$sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("$relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("$relationshipName")]
        public string RelationshipName { get; set; }

        [JsonProperty("$relationshipLink")]
        public string RelationshipLink { get; set; }
    }

    public class ListRelationshipsResponse
    {
        [JsonProperty("value")]
        public TwinRelationship[] Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }

    public class QueryResult
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Azuredigitaltwins;

    public partial class WorkflowManagedActions
    {
        public AzuredigitaltwinsActions Azuredigitaltwins(string connectionId) => new AzuredigitaltwinsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredigitaltwinsTriggers Azuredigitaltwins(string connectionId) => new AzuredigitaltwinsTriggers(connectionId);
    }
}