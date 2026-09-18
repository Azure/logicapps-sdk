//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredigitaltwins
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredigitaltwinsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<AddModelsResponseItem[]> AddModels([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<AddModelsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListModelsResponse> ListModels([WorkflowExpression] Func<string> dependenciesFor = null, [WorkflowExpression] Func<string> includeModelDefinition = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            SourceExpression.Validate(dependenciesFor, nameof(dependenciesFor), required: false);
            SourceExpression.Validate(includeModelDefinition, nameof(includeModelDefinition), required: false);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dependenciesFor != null)
                    callPayload.Queries["dependenciesFor"] = SourceExpressionConverter.ConvertO(dependenciesFor);
                if (includeModelDefinition != null)
                    callPayload.Queries["includeModelDefinition"] = SourceExpressionConverter.ConvertO(includeModelDefinition);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                return callPayload;
            }

            return new ApiConnectionAction<ListModelsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteModel([WorkflowExpression] Func<string> modelid)
        {
            SourceExpression.Validate(modelid, nameof(modelid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<GetModelByIdResponse> GetModelById([WorkflowExpression] Func<string> modelid, [WorkflowExpression] Func<string> includeModelDefinition = null)
        {
            SourceExpression.Validate(modelid, nameof(modelid), required: true);
            SourceExpression.Validate(includeModelDefinition, nameof(includeModelDefinition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeModelDefinition != null)
                    callPayload.Queries["includeModelDefinition"] = SourceExpressionConverter.ConvertO(includeModelDefinition);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<GetModelByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateModel([WorkflowExpression] Func<string> modelid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(modelid, nameof(modelid), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinResult> GetTwinById([WorkflowExpression] Func<string> twinid)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<TwinResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteTwin([WorkflowExpression] Func<string> twinid)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinResult> AddTwin([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TwinResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateTwin([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<GetComponentResult> GetComponent([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(componentPath, nameof(componentPath), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentPath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<GetComponentResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateComponent([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(componentPath, nameof(componentPath), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentPath, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinRelationship> GetRelationshipById([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<TwinRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction DeleteRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<TwinRelationship> AddRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TwinRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction UpdateRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListIncomingRelationshipsResponse> ListIncomingRelationships([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> continuationToken = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/incomingrelationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<ListIncomingRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction SendTelemetry([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> telemetrySourceTime = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(telemetrySourceTime, nameof(telemetrySourceTime), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/telemetry", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                callPayload.Headers["Message-Id"] = SourceExpressionConverter.ConvertO(messageId);
                if (telemetrySourceTime != null)
                    callPayload.Headers["Telemetry-Source-Time"] = SourceExpressionConverter.ConvertO(telemetrySourceTime);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IWorkflowAction SendComponentTelemetry([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> telemetrySourceTime = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(componentPath, nameof(componentPath), required: true);
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(telemetrySourceTime, nameof(telemetrySourceTime), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}/telemetry", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                callPayload.Headers["Message-Id"] = SourceExpressionConverter.ConvertO(messageId);
                if (telemetrySourceTime != null)
                    callPayload.Headers["Telemetry-Source-Time"] = SourceExpressionConverter.ConvertO(telemetrySourceTime);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<ListRelationshipsResponse> ListRelationships([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> continuationToken = null)
        {
            SourceExpression.Validate(twinid, nameof(twinid), required: true);
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return callPayload;
            }

            return new ApiConnectionAction<ListRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        public IBodyWorkflowAction<QueryResult> QueryTwins([WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            SourceExpression.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodycontinuationToken != null)
                {
                    body["continuationToken"] = SourceExpressionConverter.ConvertToken(bodycontinuationToken);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryResult>(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuredigitaltwins;

    public partial class WorkflowManagedActions
    {
        public AzuredigitaltwinsActions Azuredigitaltwins(string connectionId) => new AzuredigitaltwinsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzuredigitaltwinsTriggers Azuredigitaltwins(string connectionId) => new AzuredigitaltwinsTriggers(connectionId);
    }
}