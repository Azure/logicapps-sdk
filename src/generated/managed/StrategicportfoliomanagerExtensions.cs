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
        public IBodyWorkflowAction<Item[]> EntityTypesGetEntityTypes(Expression<Func<string>> siteUrl)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/EntityTypes/GetEntityTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesCreateEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityTypeUid, Expression<Func<string>> entityName)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityTypeUid = WorkflowExpression.Compile(entityTypeUid, nameof(entityTypeUid), required: true);
            var __workflow_entityName = WorkflowExpression.Compile(entityName, nameof(entityName), required: true);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityTypeUid"] = ExpressionConverter.Convert(__workflow_entityTypeUid);
                callPayload.Queries["entityName"] = ExpressionConverter.Convert(__workflow_entityName);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity[]> FinancialEntitiesGetAllEntities(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity[]>(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetAllEntitiesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity> FinancialEntitiesGetEntity(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<Entity>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<Entity>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_selectColumns = WorkflowExpression.Compile(selectColumns, nameof(selectColumns), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_selectColumns != null)
                    callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(__workflow_selectColumns);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> FinancialEntitiesGetEntityFields(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<Item[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityFieldValuesODataNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> filter = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<CallResultWithData>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<CallResultWithData>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[]> FinancialEntitiesGetEntityFieldValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<FieldValue[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<FieldValue[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue> FinancialEntitiesGetEntityFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<FieldValue>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                return new ApiConnectionAction<FieldValue>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<bool> FinancialEntitiesExecuteStageValidation(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredBodyAction<bool>(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionAction<bool>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldValueNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<CallResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldsValuesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<EntityFieldValuePair[]>> fieldValues = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: false);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValues);
                return new ApiConnectionAction<CallResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> FinancialEntitiesGetFinancialCustomFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            return new DeferredBodyAction<CustomFieldValueCreationInformation>(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredWorkflowAction(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<FinancialFieldValuePair[]>> fieldValues = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: false);
            return new DeferredWorkflowAction(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Resource[]> FinancialEntitiesGetEntityResources(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityUid = WorkflowExpression.Compile(entityUid, nameof(entityUid), required: true);
            return new DeferredBodyAction<Resource[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(__workflow_entityUid);
                return new ApiConnectionAction<Resource[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string> FinancialEntitiesAddEntityResource(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid, Expression<Func<string>> resourceUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityUid = WorkflowExpression.Compile(entityUid, nameof(entityUid), required: true);
            var __workflow_resourceUid = WorkflowExpression.Compile(resourceUid, nameof(resourceUid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/FinancialEntities/AddEntityResource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityUid"] = ExpressionConverter.Convert(__workflow_entityUid);
                callPayload.Queries["resourceUid"] = ExpressionConverter.Convert(__workflow_resourceUid);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesExecuteStageTransition(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_stageId != null)
                    callPayload.Queries["stageId"] = ExpressionConverter.Convert(__workflow_stageId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityHistoryEntry[]> FinancialEntitiesGetEntityHistoryEntries(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<EntityHistoryEntry[]>(() =>
            {
                var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesCreateEntityRelationship(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> relatedEntityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_relatedEntityId = WorkflowExpression.Compile(relatedEntityId, nameof(relatedEntityId), required: true);
            return new DeferredBodyAction<CallResult>(() =>
            {
                var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["relatedEntityId"] = ExpressionConverter.Convert(__workflow_relatedEntityId);
                return new ApiConnectionAction<CallResult>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesLogEntityHistoryEntry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> activityType, Expression<Func<string>> activityTypeIcon, Expression<Func<string>> activityDetails, Expression<Func<string>> initiator)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_activityType = WorkflowExpression.Compile(activityType, nameof(activityType), required: true);
            var __workflow_activityTypeIcon = WorkflowExpression.Compile(activityTypeIcon, nameof(activityTypeIcon), required: true);
            var __workflow_activityDetails = WorkflowExpression.Compile(activityDetails, nameof(activityDetails), required: true);
            var __workflow_initiator = WorkflowExpression.Compile(initiator, nameof(initiator), required: true);
            return new DeferredWorkflowAction(() =>
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTables(Expression<Func<string>> siteUrl)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<Item[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTableValues(Expression<Func<string>> siteUrl, Expression<Func<string>> optionSetUid)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_optionSetUid = WorkflowExpression.Compile(optionSetUid, nameof(optionSetUid), required: true);
            return new DeferredBodyAction<Item[]>(() =>
            {
                var apiCallPath = "/LookupTable/GetLookupTableValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["optionSetUid"] = ExpressionConverter.Convert(__workflow_optionSetUid);
                return new ApiConnectionAction<Item[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddFinancialValuesChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddStageTransitionHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsApprovalWorkflowStartedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsPeriodStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentAddedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentRemovedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformationsiteURL = WorkflowExpression.Compile(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            return new DeferredBodyTrigger<EventCreationResponse>(() =>
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
