//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Strategicportfoliomanager
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StrategicportfoliomanagerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildEntityTypesGetEntityTypes))]
        public IBodyWorkflowAction<Item[]> EntityTypesGetEntityTypes([WorkflowExpression] Func<string> siteUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildEntityTypesGetEntityTypes(WorkflowExpression<string> siteUrl)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/EntityTypes/GetEntityTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesCreateEntityNoRetry))]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesCreateEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityTypeUid, [WorkflowExpression] Func<string> entityName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesCreateEntityNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityTypeUid, WorkflowExpression<string> entityName)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityTypeUid, nameof(entityTypeUid), required: true);
            WorkflowExpression.Validate(entityName, nameof(entityName), required: true);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityTypeUid"] = ExpressionConverter.Convert(entityTypeUid);
                callPayload.Queries["entityName"] = ExpressionConverter.Convert(entityName);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetAllEntities))]
        public IBodyWorkflowAction<Entity[]> FinancialEntitiesGetAllEntities([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Entity[]> __BuildFinancialEntitiesGetAllEntities(WorkflowExpression<string> siteUrl, WorkflowExpression<string> filter = null, WorkflowExpression<string> selectColumns = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetAllEntities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
                return new ApiConnectionAction<Entity[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetAllEntitiesNoRetry))]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetAllEntitiesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetAllEntitiesNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> filter = null, WorkflowExpression<string> selectColumns = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetAllEntitiesNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntity))]
        public IBodyWorkflowAction<Entity> FinancialEntitiesGetEntity([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Entity> __BuildFinancialEntitiesGetEntity(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> selectColumns = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
                return new ApiConnectionAction<Entity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityNoRetry))]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetEntityNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> selectColumns = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityFields))]
        public IBodyWorkflowAction<Item[]> FinancialEntitiesGetEntityFields([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildFinancialEntitiesGetEntityFields(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityFieldValuesODataNoRetry))]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityFieldValuesODataNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetEntityFieldValuesODataNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityFieldValues))]
        public IBodyWorkflowAction<FieldValue[]> FinancialEntitiesGetEntityFieldValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FieldValue[]> __BuildFinancialEntitiesGetEntityFieldValues(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<FieldValue[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                return new ApiConnectionAction<FieldValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityFieldValue))]
        public IBodyWorkflowAction<FieldValue> FinancialEntitiesGetEntityFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FieldValue> __BuildFinancialEntitiesGetEntityFieldValue(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> fieldIdentifier)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<FieldValue>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
                return new ApiConnectionAction<FieldValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesExecuteStageValidation))]
        public IBodyWorkflowAction<bool> FinancialEntitiesExecuteStageValidation([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildFinancialEntitiesExecuteStageValidation(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> stageId = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesSetEntityFieldValueNoRetry))]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldValueNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesSetEntityFieldValueNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> fieldIdentifier, WorkflowExpression<string> value)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesSetEntityFieldsValuesNoRetry))]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldsValuesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<EntityFieldValuePair[]> fieldValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesSetEntityFieldsValuesNoRetry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<EntityFieldValuePair[]> fieldValues = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(fieldValues, nameof(fieldValues), required: false);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Body = ExpressionConverter.ConvertO(fieldValues);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetFinancialCustomFieldValue))]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> FinancialEntitiesGetFinancialCustomFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> __BuildFinancialEntitiesGetFinancialCustomFieldValue(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> eftId, WorkflowExpression<string> fdId, WorkflowExpression<string> fnId, WorkflowExpression<string> centerId, WorkflowExpression<string> fieldIdentifier)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(eftId, nameof(eftId), required: true);
            WorkflowExpression.Validate(fdId, nameof(fdId), required: true);
            WorkflowExpression.Validate(fnId, nameof(fnId), required: true);
            WorkflowExpression.Validate(centerId, nameof(centerId), required: true);
            WorkflowExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<CustomFieldValueCreationInformation>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetFinancialCustomFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(centerId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
                return new ApiConnectionAction<CustomFieldValueCreationInformation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesSetCustomFinancialFieldValue))]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesSetCustomFinancialFieldValue(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> eftId, WorkflowExpression<string> fdId, WorkflowExpression<string> fnId, WorkflowExpression<string> centerId, WorkflowExpression<string> fieldIdentifier, WorkflowExpression<string> value)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(eftId, nameof(eftId), required: true);
            WorkflowExpression.Validate(fdId, nameof(fdId), required: true);
            WorkflowExpression.Validate(fnId, nameof(fnId), required: true);
            WorkflowExpression.Validate(centerId, nameof(centerId), required: true);
            WorkflowExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(centerId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(value);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesSetCustomFinancialFieldsValues))]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldsValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<FinancialFieldValuePair[]> fieldValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesSetCustomFinancialFieldsValues(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> eftId, WorkflowExpression<string> fdId, WorkflowExpression<string> fnId, WorkflowExpression<string> centerId, WorkflowExpression<FinancialFieldValuePair[]> fieldValues = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(eftId, nameof(eftId), required: true);
            WorkflowExpression.Validate(fdId, nameof(fdId), required: true);
            WorkflowExpression.Validate(fnId, nameof(fnId), required: true);
            WorkflowExpression.Validate(centerId, nameof(centerId), required: true);
            WorkflowExpression.Validate(fieldValues, nameof(fieldValues), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldsValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["eftId"] = ExpressionConverter.Convert(eftId);
                callPayload.Queries["fdId"] = ExpressionConverter.Convert(fdId);
                callPayload.Queries["fnId"] = ExpressionConverter.Convert(fnId);
                callPayload.Queries["centerId"] = ExpressionConverter.Convert(centerId);
                callPayload.Body = ExpressionConverter.ConvertO(fieldValues);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityResources))]
        public IBodyWorkflowAction<Resource[]> FinancialEntitiesGetEntityResources([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resource[]> __BuildFinancialEntitiesGetEntityResources(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityUid)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityUid, nameof(entityUid), required: true);
            return new DeferredBodyAction<Resource[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(entityUid);
                return new ApiConnectionAction<Resource[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesAddEntityResource))]
        public IBodyWorkflowAction<string> FinancialEntitiesAddEntityResource([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid, [WorkflowExpression] Func<string> resourceUid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFinancialEntitiesAddEntityResource(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityUid, WorkflowExpression<string> resourceUid)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityUid, nameof(entityUid), required: true);
            WorkflowExpression.Validate(resourceUid, nameof(resourceUid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/FinancialEntities/AddEntityResource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(entityUid);
                callPayload.Queries["resourceUid"] = ExpressionConverter.Convert(resourceUid);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesExecuteStageTransition))]
        public IWorkflowAction FinancialEntitiesExecuteStageTransition([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesExecuteStageTransition(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> stageId = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(stageId, nameof(stageId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesGetEntityHistoryEntries))]
        public IBodyWorkflowAction<EntityHistoryEntry[]> FinancialEntitiesGetEntityHistoryEntries([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityHistoryEntry[]> __BuildFinancialEntitiesGetEntityHistoryEntries(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<EntityHistoryEntry[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesCreateEntityRelationship))]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesCreateEntityRelationship([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> relatedEntityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesCreateEntityRelationship(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> relatedEntityId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(relatedEntityId, nameof(relatedEntityId), required: true);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["relatedEntityId"] = ExpressionConverter.Convert(relatedEntityId);
                return new ApiConnectionAction<CallResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildFinancialEntitiesLogEntityHistoryEntry))]
        public IWorkflowAction FinancialEntitiesLogEntityHistoryEntry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> activityType, [WorkflowExpression] Func<string> activityTypeIcon, [WorkflowExpression] Func<string> activityDetails, [WorkflowExpression] Func<string> initiator)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesLogEntityHistoryEntry(WorkflowExpression<string> siteUrl, WorkflowExpression<string> entityId, WorkflowExpression<string> activityType, WorkflowExpression<string> activityTypeIcon, WorkflowExpression<string> activityDetails, WorkflowExpression<string> initiator)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(entityId, nameof(entityId), required: true);
            WorkflowExpression.Validate(activityType, nameof(activityType), required: true);
            WorkflowExpression.Validate(activityTypeIcon, nameof(activityTypeIcon), required: true);
            WorkflowExpression.Validate(activityDetails, nameof(activityDetails), required: true);
            WorkflowExpression.Validate(initiator, nameof(initiator), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FinancialEntities/LogEntityHistoryEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
                callPayload.Queries["activityType"] = ExpressionConverter.Convert(activityType);
                callPayload.Queries["activityTypeIcon"] = ExpressionConverter.Convert(activityTypeIcon);
                callPayload.Queries["activityDetails"] = ExpressionConverter.Convert(activityDetails);
                callPayload.Queries["initiator"] = ExpressionConverter.Convert(initiator);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildLookupTableGetLookupTables))]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTables([WorkflowExpression] Func<string> siteUrl)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildLookupTableGetLookupTables(WorkflowExpression<string> siteUrl)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [WorkflowExpressionFactory(nameof(__BuildLookupTableGetLookupTableValues))]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTableValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> optionSetUid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildLookupTableGetLookupTableValues(WorkflowExpression<string> siteUrl, WorkflowExpression<string> optionSetUid)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(optionSetUid, nameof(optionSetUid), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTableValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["optionSetUid"] = ExpressionConverter.Convert(optionSetUid);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildEventsAddFinancialValuesChangedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddFinancialValuesChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddFinancialValuesChangedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddFinancialValuesChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddEntityCreatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityCreatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddEntityCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddEntityUpdatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityUpdatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddEntityUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddEntityDeletedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityDeletedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddEntityDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddStageTransitionHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddStageTransitionHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddStageTransitionHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddStageTransitionHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddActualsApprovalWorkflowStartedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsApprovalWorkflowStartedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddActualsApprovalWorkflowStartedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddActualsPeriodStatusChangedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsPeriodStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddActualsPeriodStatusChangedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddChangeRequestCreatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestCreatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddChangeRequestUpdatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestUpdatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddChangeRequestDeletedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestDeletedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddChangeRequestStatusChangedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestStatusChangedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddResourceAssignmentAddedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentAddedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentAddedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddResourceAssignmentRemovedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentRemovedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentRemovedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddResourceAssignmentUpdatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentUpdatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddMilestoneCreatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneCreatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddMilestoneUpdatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneUpdatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddMilestoneDeletedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneDeletedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddRelationshipCreatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipCreatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddRelationshipUpdatedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipUpdatedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildEventsAddRelationshipDeletedHook))]
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipDeletedHook(WorkflowExpression<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }

                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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