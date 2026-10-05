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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildEntityTypesGetEntityTypes(WorkflowValue<string> siteUrl)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesCreateEntityNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityTypeUid, WorkflowValue<string> entityName)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityTypeUid, nameof(entityTypeUid), required: true);
            WorkflowValue.Validate(entityName, nameof(entityName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Entity[]> __BuildFinancialEntitiesGetAllEntities(WorkflowValue<string> siteUrl, WorkflowValue<string> filter = null, WorkflowValue<string> selectColumns = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(selectColumns, nameof(selectColumns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetAllEntitiesNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> filter = null, WorkflowValue<string> selectColumns = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(selectColumns, nameof(selectColumns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Entity> __BuildFinancialEntitiesGetEntity(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> selectColumns = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(selectColumns, nameof(selectColumns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetEntityNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> selectColumns = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(selectColumns, nameof(selectColumns), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildFinancialEntitiesGetEntityFields(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResultWithData> __BuildFinancialEntitiesGetEntityFieldValuesODataNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> filter = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FieldValue[]> __BuildFinancialEntitiesGetEntityFieldValues(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FieldValue> __BuildFinancialEntitiesGetEntityFieldValue(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> fieldIdentifier)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<bool> __BuildFinancialEntitiesExecuteStageValidation(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> stageId = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(stageId, nameof(stageId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesSetEntityFieldValueNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> fieldIdentifier, WorkflowValue<string> value)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesSetEntityFieldsValuesNoRetry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<EntityFieldValuePair[]> fieldValues = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(fieldValues, nameof(fieldValues), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> __BuildFinancialEntitiesGetFinancialCustomFieldValue(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> eftId, WorkflowValue<string> fdId, WorkflowValue<string> fnId, WorkflowValue<string> centerId, WorkflowValue<string> fieldIdentifier)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(eftId, nameof(eftId), required: true);
            WorkflowValue.Validate(fdId, nameof(fdId), required: true);
            WorkflowValue.Validate(fnId, nameof(fnId), required: true);
            WorkflowValue.Validate(centerId, nameof(centerId), required: true);
            WorkflowValue.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesSetCustomFinancialFieldValue(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> eftId, WorkflowValue<string> fdId, WorkflowValue<string> fnId, WorkflowValue<string> centerId, WorkflowValue<string> fieldIdentifier, WorkflowValue<string> value)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(eftId, nameof(eftId), required: true);
            WorkflowValue.Validate(fdId, nameof(fdId), required: true);
            WorkflowValue.Validate(fnId, nameof(fnId), required: true);
            WorkflowValue.Validate(centerId, nameof(centerId), required: true);
            WorkflowValue.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesSetCustomFinancialFieldsValues(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> eftId, WorkflowValue<string> fdId, WorkflowValue<string> fnId, WorkflowValue<string> centerId, WorkflowValue<FinancialFieldValuePair[]> fieldValues = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(eftId, nameof(eftId), required: true);
            WorkflowValue.Validate(fdId, nameof(fdId), required: true);
            WorkflowValue.Validate(fnId, nameof(fnId), required: true);
            WorkflowValue.Validate(centerId, nameof(centerId), required: true);
            WorkflowValue.Validate(fieldValues, nameof(fieldValues), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Resource[]> __BuildFinancialEntitiesGetEntityResources(WorkflowValue<string> siteUrl, WorkflowValue<string> entityUid)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityUid, nameof(entityUid), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFinancialEntitiesAddEntityResource(WorkflowValue<string> siteUrl, WorkflowValue<string> entityUid, WorkflowValue<string> resourceUid)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityUid, nameof(entityUid), required: true);
            WorkflowValue.Validate(resourceUid, nameof(resourceUid), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesExecuteStageTransition(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> stageId = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(stageId, nameof(stageId), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EntityHistoryEntry[]> __BuildFinancialEntitiesGetEntityHistoryEntries(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CallResult> __BuildFinancialEntitiesCreateEntityRelationship(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> relatedEntityId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(relatedEntityId, nameof(relatedEntityId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFinancialEntitiesLogEntityHistoryEntry(WorkflowValue<string> siteUrl, WorkflowValue<string> entityId, WorkflowValue<string> activityType, WorkflowValue<string> activityTypeIcon, WorkflowValue<string> activityDetails, WorkflowValue<string> initiator)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(entityId, nameof(entityId), required: true);
            WorkflowValue.Validate(activityType, nameof(activityType), required: true);
            WorkflowValue.Validate(activityTypeIcon, nameof(activityTypeIcon), required: true);
            WorkflowValue.Validate(activityDetails, nameof(activityDetails), required: true);
            WorkflowValue.Validate(initiator, nameof(initiator), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildLookupTableGetLookupTables(WorkflowValue<string> siteUrl)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item[]> __BuildLookupTableGetLookupTableValues(WorkflowValue<string> siteUrl, WorkflowValue<string> optionSetUid)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(optionSetUid, nameof(optionSetUid), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddFinancialValuesChangedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityCreatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityUpdatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddEntityDeletedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddStageTransitionHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddActualsApprovalWorkflowStartedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddActualsPeriodStatusChangedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestCreatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestUpdatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestDeletedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddChangeRequestStatusChangedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentAddedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentRemovedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddResourceAssignmentUpdatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneCreatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneUpdatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddMilestoneDeletedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipCreatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipUpdatedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<EventCreationResponse> __BuildEventsAddRelationshipDeletedHook(WorkflowValue<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
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
