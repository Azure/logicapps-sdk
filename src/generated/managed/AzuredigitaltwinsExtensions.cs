//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuredigitaltwins
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzuredigitaltwinsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildAddModels))]
        public IBodyWorkflowAction<AddModelsResponseItem[]> AddModels([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddModelsResponseItem[]> __BuildAddModels(WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AddModelsResponseItem[]>(() =>
            {
                var apiCallPath = "/models";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AddModelsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildListModels))]
        public IBodyWorkflowAction<ListModelsResponse> ListModels([WorkflowExpression] Func<string> dependenciesFor = null, [WorkflowExpression] Func<string> includeModelDefinition = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListModelsResponse> __BuildListModels(WorkflowExpression<string> dependenciesFor = null, WorkflowExpression<string> includeModelDefinition = null, WorkflowExpression<string> continuationToken = null)
        {
            WorkflowExpression.Validate(dependenciesFor, nameof(dependenciesFor), required: false);
            WorkflowExpression.Validate(includeModelDefinition, nameof(includeModelDefinition), required: false);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ListModelsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteModel))]
        public IWorkflowAction DeleteModel([WorkflowExpression] Func<string> modelid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteModel(WorkflowExpression<string> modelid)
        {
            WorkflowExpression.Validate(modelid, nameof(modelid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildGetModelById))]
        public IBodyWorkflowAction<GetModelByIdResponse> GetModelById([WorkflowExpression] Func<string> modelid, [WorkflowExpression] Func<string> includeModelDefinition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetModelByIdResponse> __BuildGetModelById(WorkflowExpression<string> modelid, WorkflowExpression<string> includeModelDefinition = null)
        {
            WorkflowExpression.Validate(modelid, nameof(modelid), required: true);
            WorkflowExpression.Validate(includeModelDefinition, nameof(includeModelDefinition), required: false);
            return new DeferredBodyAction<GetModelByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeModelDefinition != null)
                    callPayload.Queries["includeModelDefinition"] = ExpressionConverter.Convert(includeModelDefinition);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<GetModelByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateModel))]
        public IWorkflowAction UpdateModel([WorkflowExpression] Func<string> modelid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateModel(WorkflowExpression<string> modelid, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(modelid, nameof(modelid), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}", ExpressionConverter.ConvertWithUrlEncoding(modelid, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildGetTwinById))]
        public IBodyWorkflowAction<TwinResult> GetTwinById([WorkflowExpression] Func<string> twinid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TwinResult> __BuildGetTwinById(WorkflowExpression<string> twinid)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            return new DeferredBodyAction<TwinResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<TwinResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTwin))]
        public IWorkflowAction DeleteTwin([WorkflowExpression] Func<string> twinid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTwin(WorkflowExpression<string> twinid)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildAddTwin))]
        public IBodyWorkflowAction<TwinResult> AddTwin([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TwinResult> __BuildAddTwin(WorkflowExpression<string> twinid, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredBodyAction<TwinResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTwin))]
        public IWorkflowAction UpdateTwin([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateTwin(WorkflowExpression<string> twinid, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildGetComponent))]
        public IBodyWorkflowAction<GetComponentResult> GetComponent([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetComponentResult> __BuildGetComponent(WorkflowExpression<string> twinid, WorkflowExpression<string> componentPath)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(componentPath, nameof(componentPath), required: true);
            return new DeferredBodyAction<GetComponentResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<GetComponentResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateComponent))]
        public IWorkflowAction UpdateComponent([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateComponent(WorkflowExpression<string> twinid, WorkflowExpression<string> componentPath, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(componentPath, nameof(componentPath), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildGetRelationshipById))]
        public IBodyWorkflowAction<TwinRelationship> GetRelationshipById([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TwinRelationship> __BuildGetRelationshipById(WorkflowExpression<string> twinid, WorkflowExpression<string> relationshipId)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            return new DeferredBodyAction<TwinRelationship>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<TwinRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRelationship))]
        public IWorkflowAction DeleteRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRelationship(WorkflowExpression<string> twinid, WorkflowExpression<string> relationshipId)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildAddRelationship))]
        public IBodyWorkflowAction<TwinRelationship> AddRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TwinRelationship> __BuildAddRelationship(WorkflowExpression<string> twinid, WorkflowExpression<string> relationshipId, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredBodyAction<TwinRelationship>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateRelationship))]
        public IWorkflowAction UpdateRelationship([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateRelationship(WorkflowExpression<string> twinid, WorkflowExpression<string> relationshipId, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(relationshipId, nameof(relationshipId), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships/{1}", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(relationshipId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildListIncomingRelationships))]
        public IBodyWorkflowAction<ListIncomingRelationshipsResponse> ListIncomingRelationships([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> continuationToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListIncomingRelationshipsResponse> __BuildListIncomingRelationships(WorkflowExpression<string> twinid, WorkflowExpression<string> continuationToken = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ListIncomingRelationshipsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/incomingrelationships", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<ListIncomingRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildSendTelemetry))]
        public IWorkflowAction SendTelemetry([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> telemetrySourceTime = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendTelemetry(WorkflowExpression<string> twinid, WorkflowExpression<string> messageId, WorkflowExpression<string> telemetrySourceTime = null, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(telemetrySourceTime, nameof(telemetrySourceTime), required: false);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/telemetry", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildSendComponentTelemetry))]
        public IWorkflowAction SendComponentTelemetry([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> componentPath, [WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> telemetrySourceTime = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendComponentTelemetry(WorkflowExpression<string> twinid, WorkflowExpression<string> componentPath, WorkflowExpression<string> messageId, WorkflowExpression<string> telemetrySourceTime = null, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(componentPath, nameof(componentPath), required: true);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(telemetrySourceTime, nameof(telemetrySourceTime), required: false);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/components/{1}/telemetry", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1), ExpressionConverter.ConvertWithUrlEncoding(componentPath, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildListRelationships))]
        public IBodyWorkflowAction<ListRelationshipsResponse> ListRelationships([WorkflowExpression] Func<string> twinid, [WorkflowExpression] Func<string> continuationToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListRelationshipsResponse> __BuildListRelationships(WorkflowExpression<string> twinid, WorkflowExpression<string> continuationToken = null)
        {
            WorkflowExpression.Validate(twinid, nameof(twinid), required: true);
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<ListRelationshipsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/digitaltwins/{0}/relationships", ExpressionConverter.ConvertWithUrlEncoding(twinid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(continuationToken);
                callPayload.Queries["api-version"] = Convert.ToString("2020-10-31");
                return new ApiConnectionAction<ListRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuredigitaltwins")]
        [WorkflowExpressionFactory(nameof(__BuildQueryTwins))]
        public IBodyWorkflowAction<QueryResult> QueryTwins([WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryResult> __BuildQueryTwins(WorkflowExpression<string> bodyquery = null, WorkflowExpression<string> bodycontinuationToken = null)
        {
            WorkflowExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            WorkflowExpression.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            return new DeferredBodyAction<QueryResult>(() =>
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
            });
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