//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Strategicportfoliomanager
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StrategicportfoliomanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> EntityTypesGetEntityTypes(Expression<Func<string>> siteUrl)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityTypes/GetEntityTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData, ApiConnectionActionConfiguration> FinancialEntitiesCreateEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityTypeUid, Expression<Func<string>> entityName)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityTypeUid = WorkflowExpression.Compile(entityTypeUid, nameof(entityTypeUid), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            return new DeferredBodyAction<CallResultWithData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityTypeUid"] = ExpressionConverter.Convert(__workflow_entityTypeUid);
                callPayload.Queries["entityName"] = ExpressionConverter.Convert(__workflow_entityName);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity[], ApiConnectionActionConfiguration> FinancialEntitiesGetAllEntities(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetAllEntities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<Entity[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData, ApiConnectionActionConfiguration> FinancialEntitiesGetAllEntitiesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetAllEntitiesNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity, ApiConnectionActionConfiguration> FinancialEntitiesGetEntity(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<Entity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData, ApiConnectionActionConfiguration> FinancialEntitiesGetEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> FinancialEntitiesGetEntityFields(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData, ApiConnectionActionConfiguration> FinancialEntitiesGetEntityFieldValuesODataNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> filter = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CallResultWithData, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[], ApiConnectionActionConfiguration> FinancialEntitiesGetEntityFieldValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<FieldValue[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<FieldValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue, ApiConnectionActionConfiguration> FinancialEntitiesGetEntityFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<FieldValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                return new ApiConnectionAction<FieldValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> FinancialEntitiesExecuteStageValidation(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult, ApiConnectionActionConfiguration> FinancialEntitiesSetEntityFieldValueNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<CallResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult, ApiConnectionActionConfiguration> FinancialEntitiesSetEntityFieldsValuesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<EntityFieldValuePair[]>> fieldValues = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: false);
            return new DeferredBodyAction<CallResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValues);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation, ApiConnectionActionConfiguration> FinancialEntitiesGetFinancialCustomFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<CustomFieldValueCreationInformation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetFinancialCustomFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(__workflow_eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(__workflow_fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(__workflow_fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(__workflow_centerId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                return new ApiConnectionAction<CustomFieldValueCreationInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesSetCustomFinancialFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(__workflow_eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(__workflow_fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(__workflow_fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(__workflow_centerId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesSetCustomFinancialFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<FinancialFieldValuePair[]>> fieldValues = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldsValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(__workflow_eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(__workflow_fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(__workflow_fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(__workflow_centerId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValues);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Resource[], ApiConnectionActionConfiguration> FinancialEntitiesGetEntityResources(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityUid = WorkflowExpression.Compile(entityUid, nameof(entityUid), required: true);
            return new DeferredBodyAction<Resource[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(__workflow_entityUid);
                return new ApiConnectionAction<Resource[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FinancialEntitiesAddEntityResource(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid, Expression<Func<string>> resourceUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityUid = WorkflowExpression.Compile(entityUid, nameof(entityUid), required: true);
            var __workflow_resourceUid = WorkflowExpression.Compile(resourceUid, nameof(resourceUid), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/AddEntityResource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(__workflow_entityUid);
                callPayload.Queries["resourceUid"] = ExpressionConverter.Convert(__workflow_resourceUid);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesExecuteStageTransition(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityHistoryEntry[], ApiConnectionActionConfiguration> FinancialEntitiesGetEntityHistoryEntries(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<EntityHistoryEntry[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult, ApiConnectionActionConfiguration> FinancialEntitiesCreateEntityRelationship(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> relatedEntityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_relatedEntityId = WorkflowExpression.Compile(relatedEntityId, nameof(relatedEntityId), required: true);
            return new DeferredBodyAction<CallResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["relatedEntityId"] = ExpressionConverter.Convert(__workflow_relatedEntityId);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesLogEntityHistoryEntry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> activityType, Expression<Func<string>> activityTypeIcon, Expression<Func<string>> activityDetails, Expression<Func<string>> initiator)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_activityType = WorkflowExpression.Compile(activityType, nameof(activityType), required: true);
            var __workflow_activityTypeIcon = WorkflowExpression.Compile(activityTypeIcon, nameof(activityTypeIcon), required: true);
            var __workflow_activityDetails = WorkflowExpression.Compile(activityDetails, nameof(activityDetails), required: true);
            var __workflow_initiator = WorkflowExpression.Compile(initiator, nameof(initiator), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/LogEntityHistoryEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["activityType"] = ExpressionConverter.Convert(__workflow_activityType);
                callPayload.Queries["activityTypeIcon"] = ExpressionConverter.Convert(__workflow_activityTypeIcon);
                callPayload.Queries["activityDetails"] = ExpressionConverter.Convert(__workflow_activityDetails);
                callPayload.Queries["initiator"] = ExpressionConverter.Convert(__workflow_initiator);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> LookupTableGetLookupTables(Expression<Func<string>> siteUrl)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> LookupTableGetLookupTableValues(Expression<Func<string>> siteUrl, Expression<Func<string>> optionSetUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_optionSetUid = WorkflowExpression.Compile(optionSetUid, nameof(optionSetUid), required: true);
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTableValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["optionSetUid"] = ExpressionConverter.Convert(__workflow_optionSetUid);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddFinancialValuesChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddFinancialValuesChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddStageTransitionHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddStageTransitionHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddActualsApprovalWorkflowStartedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddActualsPeriodStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentAddedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentRemovedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(__workflow_eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class CallResultWithData
    {
        public JToken Data { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
    }

    public class Entity
    {
        public string EntityGUID { get; set; }
        public string EntityName { get; set; }
        public string EntityDescription { get; set; }
        public bool AllowPartialAggregation { get; set; }
        public bool IsChangeRequestEnabled { get; set; }
        public int ProviderCurrencyDigits { get; set; }
        public string ProviderCurrencyCode { get; set; }
        public string WorkflowStageGUID { get; set; }
        public string WorkflowStageName { get; set; }
        public string CalendarTypeGUID { get; set; }
        public string WorkflowInstanceGUID { get; set; }
        public string CalendarGUID { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyCodeDescription { get; set; }
        public string CurrencyCodeSymbol { get; set; }
        public bool IsCustomRate { get; set; }
        public string GTGUID { get; set; }
        public string GTName { get; set; }
        public string EntityTypeGUID { get; set; }
        public string EntityTypeName { get; set; }
        public string EntityTypeDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class FieldValue
    {
        public string FieldName { get; set; }
        public string FieldUid { get; set; }
        public JToken Value { get; set; }
    }

    public class CallResult
    {
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
    }

    public class EntityFieldValuePair
    {
        public string Uid { get; set; }
        public string Value { get; set; }
    }

    public class CustomFieldValueCreationInformation
    {
        public string FinancialTypeId { get; set; }
        public string FinancialDimensionId { get; set; }
        public string FinancialNodeId { get; set; }
        public string AllocationCenterId { get; set; }
        public JToken Value { get; set; }
        public string CustomFieldName { get; set; }
        public string URL { get; set; }
        public string FinancialEntityId { get; set; }
    }

    public class FinancialFieldValuePair
    {
        public string Uid { get; set; }
        public string Value { get; set; }
    }

    public class Resource
    {
        public string Email { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class EntityHistoryEntry
    {
        public string Id { get; set; }
        public string EntityId { get; set; }
        public string Date { get; set; }
        public string DateString { get; set; }
        public string Claim { get; set; }
        public string Initiator { get; set; }
        public string ActivityType { get; set; }
        public string ActivityTypeIcon { get; set; }
        public string ActivityDetails { get; set; }
    }

    public class EventCreationResponse
    {
        public bool Succeeded { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Strategicportfoliomanager;

    public partial class WorkflowManagedActions
    {
        public StrategicportfoliomanagerActions Strategicportfoliomanager(string connectionId) => new StrategicportfoliomanagerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StrategicportfoliomanagerTriggers Strategicportfoliomanager(string connectionId) => new StrategicportfoliomanagerTriggers(connectionId);
    }
}
