//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Strategicportfoliomanager
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StrategicportfoliomanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> EntityTypesGetEntityTypes([WorkflowExpression] Func<string> siteUrl)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EntityTypes/GetEntityTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                return callPayload;
            }

            return new ApiConnectionAction<Item[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesCreateEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityTypeUid, [WorkflowExpression] Func<string> entityName)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityTypeUid, nameof(entityTypeUid), required: true);
            SourceExpression.Validate(entityName, nameof(entityName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityTypeUid"] = SourceExpressionConverter.ConvertO(entityTypeUid);
                callPayload.Queries["entityName"] = SourceExpressionConverter.ConvertO(entityName);
                return callPayload;
            }

            return new ApiConnectionAction<CallResultWithData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity[]> FinancialEntitiesGetAllEntities([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetAllEntities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = SourceExpressionConverter.ConvertO(selectColumns);
                return callPayload;
            }

            return new ApiConnectionAction<Entity[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetAllEntitiesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetAllEntitiesNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = SourceExpressionConverter.ConvertO(selectColumns);
                return callPayload;
            }

            return new ApiConnectionAction<CallResultWithData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity> FinancialEntitiesGetEntity([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = SourceExpressionConverter.ConvertO(selectColumns);
                return callPayload;
            }

            return new ApiConnectionAction<Entity>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(selectColumns, nameof(selectColumns), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                if (selectColumns != null)
                    callPayload.Queries["selectColumns"] = SourceExpressionConverter.ConvertO(selectColumns);
                return callPayload;
            }

            return new ApiConnectionAction<CallResultWithData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> FinancialEntitiesGetEntityFields([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityFields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                return callPayload;
            }

            return new ApiConnectionAction<Item[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityFieldValuesODataNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> filter = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                return callPayload;
            }

            return new ApiConnectionAction<CallResultWithData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[]> FinancialEntitiesGetEntityFieldValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                return callPayload;
            }

            return new ApiConnectionAction<FieldValue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue> FinancialEntitiesGetEntityFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["fieldIdentifier"] = SourceExpressionConverter.ConvertO(fieldIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<FieldValue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<bool> FinancialEntitiesExecuteStageValidation([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldValueNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["fieldIdentifier"] = SourceExpressionConverter.ConvertO(fieldIdentifier);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<CallResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldsValuesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<EntityFieldValuePair[]> fieldValues = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(fieldValues, nameof(fieldValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fieldValues);
                return callPayload;
            }

            return new ApiConnectionAction<CallResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> FinancialEntitiesGetFinancialCustomFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(eftId, nameof(eftId), required: true);
            SourceExpression.Validate(fdId, nameof(fdId), required: true);
            SourceExpression.Validate(fnId, nameof(fnId), required: true);
            SourceExpression.Validate(centerId, nameof(centerId), required: true);
            SourceExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetFinancialCustomFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["eftId"] = SourceExpressionConverter.ConvertO(eftId);
                callPayload.Queries["fdId"] = SourceExpressionConverter.ConvertO(fdId);
                callPayload.Queries["fnId"] = SourceExpressionConverter.ConvertO(fnId);
                callPayload.Queries["centerId"] = SourceExpressionConverter.ConvertO(centerId);
                callPayload.Queries["fieldIdentifier"] = SourceExpressionConverter.ConvertO(fieldIdentifier);
                return callPayload;
            }

            return new ApiConnectionAction<CustomFieldValueCreationInformation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(eftId, nameof(eftId), required: true);
            SourceExpression.Validate(fdId, nameof(fdId), required: true);
            SourceExpression.Validate(fnId, nameof(fnId), required: true);
            SourceExpression.Validate(centerId, nameof(centerId), required: true);
            SourceExpression.Validate(fieldIdentifier, nameof(fieldIdentifier), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["eftId"] = SourceExpressionConverter.ConvertO(eftId);
                callPayload.Queries["fdId"] = SourceExpressionConverter.ConvertO(fdId);
                callPayload.Queries["fnId"] = SourceExpressionConverter.ConvertO(fnId);
                callPayload.Queries["centerId"] = SourceExpressionConverter.ConvertO(centerId);
                callPayload.Queries["fieldIdentifier"] = SourceExpressionConverter.ConvertO(fieldIdentifier);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldsValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<FinancialFieldValuePair[]> fieldValues = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(eftId, nameof(eftId), required: true);
            SourceExpression.Validate(fdId, nameof(fdId), required: true);
            SourceExpression.Validate(fnId, nameof(fnId), required: true);
            SourceExpression.Validate(centerId, nameof(centerId), required: true);
            SourceExpression.Validate(fieldValues, nameof(fieldValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldsValues";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["eftId"] = SourceExpressionConverter.ConvertO(eftId);
                callPayload.Queries["fdId"] = SourceExpressionConverter.ConvertO(fdId);
                callPayload.Queries["fnId"] = SourceExpressionConverter.ConvertO(fnId);
                callPayload.Queries["centerId"] = SourceExpressionConverter.ConvertO(centerId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fieldValues);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Resource[]> FinancialEntitiesGetEntityResources([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityUid, nameof(entityUid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityResources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityUid"] = SourceExpressionConverter.ConvertO(entityUid);
                return callPayload;
            }

            return new ApiConnectionAction<Resource[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string> FinancialEntitiesAddEntityResource([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid, [WorkflowExpression] Func<string> resourceUid)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityUid, nameof(entityUid), required: true);
            SourceExpression.Validate(resourceUid, nameof(resourceUid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/AddEntityResource";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityUid"] = SourceExpressionConverter.ConvertO(entityUid);
                callPayload.Queries["resourceUid"] = SourceExpressionConverter.ConvertO(resourceUid);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesExecuteStageTransition([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(stageId, nameof(stageId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                if (stageId != null)
                    callPayload.Queries["stageId"] = SourceExpressionConverter.ConvertO(stageId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityHistoryEntry[]> FinancialEntitiesGetEntityHistoryEntries([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                return callPayload;
            }

            return new ApiConnectionAction<EntityHistoryEntry[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesCreateEntityRelationship([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> relatedEntityId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(relatedEntityId, nameof(relatedEntityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["relatedEntityId"] = SourceExpressionConverter.ConvertO(relatedEntityId);
                return callPayload;
            }

            return new ApiConnectionAction<CallResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesLogEntityHistoryEntry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> activityType, [WorkflowExpression] Func<string> activityTypeIcon, [WorkflowExpression] Func<string> activityDetails, [WorkflowExpression] Func<string> initiator)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(activityType, nameof(activityType), required: true);
            SourceExpression.Validate(activityTypeIcon, nameof(activityTypeIcon), required: true);
            SourceExpression.Validate(activityDetails, nameof(activityDetails), required: true);
            SourceExpression.Validate(initiator, nameof(initiator), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FinancialEntities/LogEntityHistoryEntry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["entityId"] = SourceExpressionConverter.ConvertO(entityId);
                callPayload.Queries["activityType"] = SourceExpressionConverter.ConvertO(activityType);
                callPayload.Queries["activityTypeIcon"] = SourceExpressionConverter.ConvertO(activityTypeIcon);
                callPayload.Queries["activityDetails"] = SourceExpressionConverter.ConvertO(activityDetails);
                callPayload.Queries["initiator"] = SourceExpressionConverter.ConvertO(initiator);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTables([WorkflowExpression] Func<string> siteUrl)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/LookupTable/GetLookupTables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                return callPayload;
            }

            return new ApiConnectionAction<Item[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTableValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> optionSetUid)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(optionSetUid, nameof(optionSetUid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/LookupTable/GetLookupTableValues";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["optionSetUid"] = SourceExpressionConverter.ConvertO(optionSetUid);
                return callPayload;
            }

            return new ApiConnectionAction<Item[]>(BuildSourceInput);
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddFinancialValuesChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddFinancialValuesChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddEntityCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddEntityUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddEntityDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddStageTransitionHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddStageTransitionHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsApprovalWorkflowStartedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsPeriodStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddChangeRequestCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddChangeRequestDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentAddedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentRemovedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddMilestoneCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddMilestoneUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddMilestoneDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddRelationshipCreatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddRelationshipUpdatedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(eventCreationInformationsiteURL, nameof(eventCreationInformationsiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Events/AddRelationshipDeletedHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var eventCreationInformation = new JObject();
                var eventCreationInformationpropCount = 0;
                eventCreationInformationpropCount++;
                eventCreationInformation["SiteURL"] = SourceExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
                eventCreationInformation["ReceiverEndpoint"] = "#{listCallbackUrl()}";
                eventCreationInformationpropCount++;
                if (eventCreationInformationpropCount > 0)
                {
                    callPayload.Body = eventCreationInformation;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(BuildSourceInput, triggerName, recurrence);
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