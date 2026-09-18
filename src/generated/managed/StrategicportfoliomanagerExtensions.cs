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
        public IBodyWorkflowAction<Item[]> EntityTypesGetEntityTypes([WorkflowExpression] Func<string> siteUrl)
        {
            var apiCallPath = "/EntityTypes/GetEntityTypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesCreateEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityTypeUid, [WorkflowExpression] Func<string> entityName)
        {
            var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityTypeUid"] = ExpressionConverter.Convert(entityTypeUid);
            callPayload.Queries["entityName"] = ExpressionConverter.Convert(entityName);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity[]> FinancialEntitiesGetAllEntities([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetAllEntitiesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> selectColumns = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity> FinancialEntitiesGetEntity([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
            return new ApiConnectionAction<Entity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = ExpressionConverter.Convert(selectColumns);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> FinancialEntitiesGetEntityFields([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFields";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityFieldValuesODataNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> filter = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[]> FinancialEntitiesGetEntityFieldValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            return new ApiConnectionAction<FieldValue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue> FinancialEntitiesGetEntityFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
            return new ApiConnectionAction<FieldValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<bool> FinancialEntitiesExecuteStageValidation([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            if (stageId != null)
                callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldValueNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
        {
            var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            callPayload.Queries["fieldIdentifier"] = ExpressionConverter.Convert(fieldIdentifier);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldsValuesNoRetry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<EntityFieldValuePair[]> fieldValues = null)
        {
            var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            callPayload.Body = ExpressionConverter.ConvertO(fieldValues);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> FinancialEntitiesGetFinancialCustomFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldValue([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<string> fieldIdentifier, [WorkflowExpression] Func<string> value)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldsValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> eftId, [WorkflowExpression] Func<string> fdId, [WorkflowExpression] Func<string> fnId, [WorkflowExpression] Func<string> centerId, [WorkflowExpression] Func<FinancialFieldValuePair[]> fieldValues = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Resource[]> FinancialEntitiesGetEntityResources([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid)
        {
            var apiCallPath = "/FinancialEntities/GetEntityResources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityUid"] = ExpressionConverter.Convert(entityUid);
            return new ApiConnectionAction<Resource[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string> FinancialEntitiesAddEntityResource([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityUid, [WorkflowExpression] Func<string> resourceUid)
        {
            var apiCallPath = "/FinancialEntities/AddEntityResource";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityUid"] = ExpressionConverter.Convert(entityUid);
            callPayload.Queries["resourceUid"] = ExpressionConverter.Convert(resourceUid);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesExecuteStageTransition([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> stageId = null)
        {
            var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            if (stageId != null)
                callPayload.Queries["stageId"] = ExpressionConverter.Convert(stageId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityHistoryEntry[]> FinancialEntitiesGetEntityHistoryEntries([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesCreateEntityRelationship([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> relatedEntityId)
        {
            var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["entityId"] = ExpressionConverter.Convert(entityId);
            callPayload.Queries["relatedEntityId"] = ExpressionConverter.Convert(relatedEntityId);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesLogEntityHistoryEntry([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> activityType, [WorkflowExpression] Func<string> activityTypeIcon, [WorkflowExpression] Func<string> activityDetails, [WorkflowExpression] Func<string> initiator)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTables([WorkflowExpression] Func<string> siteUrl)
        {
            var apiCallPath = "/LookupTable/GetLookupTables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTableValues([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> optionSetUid)
        {
            var apiCallPath = "/LookupTable/GetLookupTableValues";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["optionSetUid"] = ExpressionConverter.Convert(optionSetUid);
            return new ApiConnectionAction<Item[]>(callPayload);
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddFinancialValuesChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddFinancialValuesChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddStageTransitionHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddStageTransitionHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsApprovalWorkflowStartedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsPeriodStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestStatusChangedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentAddedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentRemovedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipCreatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipUpdatedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipDeletedHook([WorkflowExpression] Func<string> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = ExpressionConverter.ConvertO(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
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