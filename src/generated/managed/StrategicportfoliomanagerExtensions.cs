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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> FinancialEntitiesExecuteStageValidation(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/ExecuteStageValidation";
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesExecuteStageTransition(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/ExecuteStageTransition";
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
                var apiCallPath = "/EntityLifecycle/GetEntityHistoryEntries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
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
                var apiCallPath = "/EntityLifecycle/LogEntityHistoryEntry";
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
        public IBodyWorkflowAction<LifecycleApprovalRequest[], ApiConnectionActionConfiguration> EntityLifecycleGetLifecycleApprovalRequestsByUser(Expression<Func<string>> siteUrl, Expression<Func<string>> approver, Expression<Func<int>> status = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_approver = WorkflowExpression.Compile(approver, nameof(approver), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<LifecycleApprovalRequest[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/GetLifecycleApprovalRequestsByUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["approver"] = ExpressionConverter.Convert(__workflow_approver);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<LifecycleApprovalRequest[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<LifecycleApprovalRequest[], ApiConnectionActionConfiguration> EntityLifecycleGetLifecycleApprovalRequestsByEntity(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<int>> status = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<LifecycleApprovalRequest[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/GetLifecycleApprovalRequestsByEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<LifecycleApprovalRequest[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<LifecycleApprovalRequest, ApiConnectionActionConfiguration> EntityLifecycleGetLifecycleApprovalRequestDetails(Expression<Func<string>> siteUrl, Expression<Func<string>> requestInstanceId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_requestInstanceId = WorkflowExpression.Compile(requestInstanceId, nameof(requestInstanceId), required: true);
            return new DeferredBodyAction<LifecycleApprovalRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/GetLifecycleApprovalRequestDetails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["requestInstanceId"] = ExpressionConverter.Convert(__workflow_requestInstanceId);
                return new ApiConnectionAction<LifecycleApprovalRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EntityLifecycleSetLifecycleApprovalResponse(Expression<Func<string>> siteUrl, Expression<Func<string>> requestUid, Expression<Func<int>> response, Expression<Func<string>> comment = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_requestUid = WorkflowExpression.Compile(requestUid, nameof(requestUid), required: true);
            var __workflow_response = WorkflowExpression.Compile(response, nameof(response), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/EntityLifecycle/SetLifecycleApprovalResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["requestUid"] = ExpressionConverter.Convert(__workflow_requestUid);
                callPayload.Queries["response"] = ExpressionConverter.Convert(__workflow_response);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                return new ApiConnectionAction(callPayload);
            });
        }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesDeleteEntity(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/DeleteEntity";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction(callPayload);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesSetEntityFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldIdentifier = WorkflowExpression.Compile(fieldIdentifier, nameof(fieldIdentifier), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(__workflow_fieldIdentifier);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction(callPayload);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesSetEntityFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<EntityFieldValuePair[]>> fieldValues)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldsValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValues);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult, ApiConnectionActionConfiguration> FinancialEntitiesSetEntityFieldsValuesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<EntityFieldValuePair[]>> fieldValues)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: true);
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
        public IWorkflowAction<ApiConnectionActionConfiguration> FinancialEntitiesSetCustomFinancialFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<FinancialFieldValuePair[]>> fieldValues)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_eftId = WorkflowExpression.Compile(eftId, nameof(eftId), required: true);
            var __workflow_fdId = WorkflowExpression.Compile(fdId, nameof(fdId), required: true);
            var __workflow_fnId = WorkflowExpression.Compile(fnId, nameof(fnId), required: true);
            var __workflow_centerId = WorkflowExpression.Compile(centerId, nameof(centerId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: true);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[], ApiConnectionActionConfiguration> MilestonesGetMilestones(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<Item[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/GetMilestones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                return new ApiConnectionAction<Item[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MilestonesCreateMilestone(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> name, Expression<Func<string>> plannedDate, Expression<Func<string>> description = null, Expression<Func<bool>> showInRoadmaps = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_plannedDate = WorkflowExpression.Compile(plannedDate, nameof(plannedDate), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_showInRoadmaps = WorkflowExpression.Compile(showInRoadmaps, nameof(showInRoadmaps), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/CreateMilestone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["plannedDate"] = ExpressionConverter.Convert(__workflow_plannedDate);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_showInRoadmaps != null)
                    callPayload.Queries["showInRoadmaps"] = ExpressionConverter.Convert(__workflow_showInRoadmaps);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityMilestone, ApiConnectionActionConfiguration> MilestonesGetMilestone(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            return new DeferredBodyAction<EntityMilestone, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/GetMilestone";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                return new ApiConnectionAction<EntityMilestone>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MilestonesUpdateMilestone(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId, Expression<Func<string>> name = null, Expression<Func<string>> description = null, Expression<Func<string>> plannedDate = null, Expression<Func<string>> actualDate = null, Expression<Func<string>> transitionalActualDate = null, Expression<Func<bool>> showInRoadmaps = null, Expression<Func<string>> status = null)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_plannedDate = WorkflowExpression.Compile(plannedDate, nameof(plannedDate), required: false);
            var __workflow_actualDate = WorkflowExpression.Compile(actualDate, nameof(actualDate), required: false);
            var __workflow_transitionalActualDate = WorkflowExpression.Compile(transitionalActualDate, nameof(transitionalActualDate), required: false);
            var __workflow_showInRoadmaps = WorkflowExpression.Compile(showInRoadmaps, nameof(showInRoadmaps), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/UpdateMilestone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_plannedDate != null)
                    callPayload.Queries["plannedDate"] = ExpressionConverter.Convert(__workflow_plannedDate);
                if (__workflow_actualDate != null)
                    callPayload.Queries["actualDate"] = ExpressionConverter.Convert(__workflow_actualDate);
                if (__workflow_transitionalActualDate != null)
                    callPayload.Queries["transitionalActualDate"] = ExpressionConverter.Convert(__workflow_transitionalActualDate);
                if (__workflow_showInRoadmaps != null)
                    callPayload.Queries["showInRoadmaps"] = ExpressionConverter.Convert(__workflow_showInRoadmaps);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[], ApiConnectionActionConfiguration> MilestonesGetMilestoneFieldValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            return new DeferredBodyAction<FieldValue[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/GetMilestoneFieldValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                return new ApiConnectionAction<FieldValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue, ApiConnectionActionConfiguration> MilestonesGetMilestoneFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId, Expression<Func<string>> fieldName)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            var __workflow_fieldName = WorkflowExpression.Compile(fieldName, nameof(fieldName), required: true);
            return new DeferredBodyAction<FieldValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/GetMilestoneFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                callPayload.Queries["fieldName"] = ExpressionConverter.Convert(__workflow_fieldName);
                return new ApiConnectionAction<FieldValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MilestonesSetMilestoneFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId, Expression<Func<string>> fieldName, Expression<Func<string>> value)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            var __workflow_fieldName = WorkflowExpression.Compile(fieldName, nameof(fieldName), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/SetMilestoneFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                callPayload.Queries["fieldName"] = ExpressionConverter.Convert(__workflow_fieldName);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MilestonesSetMilestoneFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> milestoneId, Expression<Func<MilestoneFieldValuePair[]>> fieldValues)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_milestoneId = WorkflowExpression.Compile(milestoneId, nameof(milestoneId), required: true);
            var __workflow_fieldValues = WorkflowExpression.Compile(fieldValues, nameof(fieldValues), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Milestones/SetMilestoneFieldsValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["milestoneId"] = ExpressionConverter.Convert(__workflow_milestoneId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldValues);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddFinancialValuesChangedHook(Expression<Func<EventsAddFinancialValuesChangedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddFinancialValuesChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityCreatedHook(Expression<Func<EventsAddEntityCreatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityUpdatedHook(Expression<Func<EventsAddEntityUpdatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddEntityDeletedHook(Expression<Func<EventsAddEntityDeletedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddEntityDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddStageTransitionHook(Expression<Func<EventsAddStageTransitionHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddStageTransitionHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddActualsApprovalWorkflowStartedHook(Expression<Func<EventsAddActualsApprovalWorkflowStartedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddActualsPeriodStatusChangedHook(Expression<Func<EventsAddActualsPeriodStatusChangedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestCreatedHook(Expression<Func<EventsAddChangeRequestCreatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestUpdatedHook(Expression<Func<EventsAddChangeRequestUpdatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestDeletedHook(Expression<Func<EventsAddChangeRequestDeletedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddChangeRequestStatusChangedHook(Expression<Func<EventsAddChangeRequestStatusChangedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentAddedHook(Expression<Func<EventsAddResourceAssignmentAddedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentRemovedHook(Expression<Func<EventsAddResourceAssignmentRemovedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddResourceAssignmentUpdatedHook(Expression<Func<EventsAddResourceAssignmentUpdatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneCreatedHook(Expression<Func<EventsAddMilestoneCreatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneUpdatedHook(Expression<Func<EventsAddMilestoneUpdatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddMilestoneDeletedHook(Expression<Func<EventsAddMilestoneDeletedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddMilestoneDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipCreatedHook(Expression<Func<EventsAddRelationshipCreatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipUpdatedHook(Expression<Func<EventsAddRelationshipUpdatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddRelationshipDeletedHook(Expression<Func<EventsAddRelationshipDeletedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddRelationshipDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddApprovalRequestCreatedHook(Expression<Func<EventsAddApprovalRequestCreatedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddApprovalRequestCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration> EventsAddApprovalRequestChangedHook(Expression<Func<EventsAddApprovalRequestChangedHookInput>> eventCreationInformation, FlowRecurrence recurrence = null)
        {
            var __workflow_eventCreationInformation = WorkflowExpression.Compile(eventCreationInformation, nameof(eventCreationInformation), required: true);
            return new DeferredBodyTrigger<EventCreationResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Events/AddApprovalRequestChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_eventCreationInformation);
                return new ApiConnectionTrigger<EventCreationResponse>(callPayload, recurrence: recurrence);
            });
        }
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

    public class LifecycleApprovalRequest
    {
        public string Id { get; set; }
        public string RequestId { get; set; }
        public string EntityId { get; set; }
        public string EntityName { get; set; }
        public string RequestName { get; set; }
        public string ApproverName { get; set; }
        public string ApproverEmail { get; set; }
        public string StageId { get; set; }
        public string StageName { get; set; }
        public string Status { get; set; }
        public string RequestedDate { get; set; }
        public string CompletedDate { get; set; }
        public string Comment { get; set; }
        public string EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
        public string RequestedByName { get; set; }
        public string RequestedByEmail { get; set; }
        public string ResponseType { get; set; }
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
        public JToken NormalizedValue { get; set; }
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

    public class EntityMilestone
    {
        public string MilestoneId { get; set; }
        public string ActualDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string PlannedDate { get; set; }
        public int Status { get; set; }
        public string TransitionalActualDate { get; set; }
    }

    public class MilestoneFieldValuePair
    {
        public string Uid { get; set; }
        public string Value { get; set; }
    }

    public class EventCreationResponse
    {
        public bool Succeeded { get; set; }
    }

    public class EventsAddFinancialValuesChangedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddEntityCreatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddEntityUpdatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddEntityDeletedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddStageTransitionHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddActualsApprovalWorkflowStartedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddActualsPeriodStatusChangedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddChangeRequestCreatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddChangeRequestUpdatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddChangeRequestDeletedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddChangeRequestStatusChangedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddResourceAssignmentAddedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddResourceAssignmentRemovedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddResourceAssignmentUpdatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddMilestoneCreatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddMilestoneUpdatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddMilestoneDeletedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddRelationshipCreatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddRelationshipUpdatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddRelationshipDeletedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddApprovalRequestCreatedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class EventsAddApprovalRequestChangedHookInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReceiverEndpoint { get; set; } = "#{listCallbackUrl()}";
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