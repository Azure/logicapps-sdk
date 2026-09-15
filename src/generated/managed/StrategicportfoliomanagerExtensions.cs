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
        public IBodyWorkflowAction<Item[]> EntityTypesGetEntityTypes(Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/EntityTypes/GetEntityTypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesCreateEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityTypeUid, Expression<Func<string>> entityName)
        {
            var apiCallPath = "/FinancialEntities/CreateEntityNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityTypeUid"] = CSharpExpressionConverter.ConvertO(entityTypeUid);
            callPayload.Queries["entityName"] = CSharpExpressionConverter.ConvertO(entityName);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity[]> FinancialEntitiesGetAllEntities(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetAllEntities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = CSharpExpressionConverter.ConvertO(selectColumns);
            return new ApiConnectionAction<Entity[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetAllEntitiesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> filter = null, Expression<Func<string>> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetAllEntitiesNoRetry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = CSharpExpressionConverter.ConvertO(selectColumns);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Entity> FinancialEntitiesGetEntity(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntity";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = CSharpExpressionConverter.ConvertO(selectColumns);
            return new ApiConnectionAction<Entity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> selectColumns = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntityNoRetry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            if (selectColumns != null)
                callPayload.Queries["selectColumns"] = CSharpExpressionConverter.ConvertO(selectColumns);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> FinancialEntitiesGetEntityFields(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFields";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResultWithData> FinancialEntitiesGetEntityFieldValuesODataNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValuesODataNoRetry";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            return new ApiConnectionAction<CallResultWithData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue[]> FinancialEntitiesGetEntityFieldValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValues";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            return new ApiConnectionAction<FieldValue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<FieldValue> FinancialEntitiesGetEntityFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier)
        {
            var apiCallPath = "/FinancialEntities/GetEntityFieldValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["fieldIdentifier"] = CSharpExpressionConverter.ConvertO(fieldIdentifier);
            return new ApiConnectionAction<FieldValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<bool> FinancialEntitiesExecuteStageValidation(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var apiCallPath = "/FinancialEntities/ExecuteStageValidation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            if (stageId != null)
                callPayload.Queries["stageId"] = CSharpExpressionConverter.ConvertO(stageId);
            return new ApiConnectionAction<bool>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldValueNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var apiCallPath = "/FinancialEntities/SetEntityFieldValueNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["fieldIdentifier"] = CSharpExpressionConverter.ConvertO(fieldIdentifier);
            callPayload.Queries["value"] = CSharpExpressionConverter.ConvertO(value);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesSetEntityFieldsValuesNoRetry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<EntityFieldValuePair[]>> fieldValues = null)
        {
            var apiCallPath = "/FinancialEntities/SetEntityFieldsValuesNoRetry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fieldValues);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CustomFieldValueCreationInformation> FinancialEntitiesGetFinancialCustomFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier)
        {
            var apiCallPath = "/FinancialEntities/GetFinancialCustomFieldValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["eftId"] = CSharpExpressionConverter.ConvertO(eftId);
            callPayload.Queries["fdId"] = CSharpExpressionConverter.ConvertO(fdId);
            callPayload.Queries["fnId"] = CSharpExpressionConverter.ConvertO(fnId);
            callPayload.Queries["centerId"] = CSharpExpressionConverter.ConvertO(centerId);
            callPayload.Queries["fieldIdentifier"] = CSharpExpressionConverter.ConvertO(fieldIdentifier);
            return new ApiConnectionAction<CustomFieldValueCreationInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldValue(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<string>> fieldIdentifier, Expression<Func<string>> value)
        {
            var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["eftId"] = CSharpExpressionConverter.ConvertO(eftId);
            callPayload.Queries["fdId"] = CSharpExpressionConverter.ConvertO(fdId);
            callPayload.Queries["fnId"] = CSharpExpressionConverter.ConvertO(fnId);
            callPayload.Queries["centerId"] = CSharpExpressionConverter.ConvertO(centerId);
            callPayload.Queries["fieldIdentifier"] = CSharpExpressionConverter.ConvertO(fieldIdentifier);
            callPayload.Queries["value"] = CSharpExpressionConverter.ConvertO(value);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesSetCustomFinancialFieldsValues(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> eftId, Expression<Func<string>> fdId, Expression<Func<string>> fnId, Expression<Func<string>> centerId, Expression<Func<FinancialFieldValuePair[]>> fieldValues = null)
        {
            var apiCallPath = "/FinancialEntities/SetCustomFinancialFieldsValues";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["eftId"] = CSharpExpressionConverter.ConvertO(eftId);
            callPayload.Queries["fdId"] = CSharpExpressionConverter.ConvertO(fdId);
            callPayload.Queries["fnId"] = CSharpExpressionConverter.ConvertO(fnId);
            callPayload.Queries["centerId"] = CSharpExpressionConverter.ConvertO(centerId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fieldValues);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Resource[]> FinancialEntitiesGetEntityResources(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid)
        {
            var apiCallPath = "/FinancialEntities/GetEntityResources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityUid"] = CSharpExpressionConverter.ConvertO(entityUid);
            return new ApiConnectionAction<Resource[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<string> FinancialEntitiesAddEntityResource(Expression<Func<string>> siteUrl, Expression<Func<string>> entityUid, Expression<Func<string>> resourceUid)
        {
            var apiCallPath = "/FinancialEntities/AddEntityResource";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityUid"] = CSharpExpressionConverter.ConvertO(entityUid);
            callPayload.Queries["resourceUid"] = CSharpExpressionConverter.ConvertO(resourceUid);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesExecuteStageTransition(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> stageId = null)
        {
            var apiCallPath = "/FinancialEntities/ExecuteStageTransition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            if (stageId != null)
                callPayload.Queries["stageId"] = CSharpExpressionConverter.ConvertO(stageId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<EntityHistoryEntry[]> FinancialEntitiesGetEntityHistoryEntries(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId)
        {
            var apiCallPath = "/FinancialEntities/GetEntityHistoryEntries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            return new ApiConnectionAction<EntityHistoryEntry[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<CallResult> FinancialEntitiesCreateEntityRelationship(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> relatedEntityId)
        {
            var apiCallPath = "/FinancialEntities/CreateEntityRelationship";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["relatedEntityId"] = CSharpExpressionConverter.ConvertO(relatedEntityId);
            return new ApiConnectionAction<CallResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IWorkflowAction FinancialEntitiesLogEntityHistoryEntry(Expression<Func<string>> siteUrl, Expression<Func<string>> entityId, Expression<Func<string>> activityType, Expression<Func<string>> activityTypeIcon, Expression<Func<string>> activityDetails, Expression<Func<string>> initiator)
        {
            var apiCallPath = "/FinancialEntities/LogEntityHistoryEntry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["entityId"] = CSharpExpressionConverter.ConvertO(entityId);
            callPayload.Queries["activityType"] = CSharpExpressionConverter.ConvertO(activityType);
            callPayload.Queries["activityTypeIcon"] = CSharpExpressionConverter.ConvertO(activityTypeIcon);
            callPayload.Queries["activityDetails"] = CSharpExpressionConverter.ConvertO(activityDetails);
            callPayload.Queries["initiator"] = CSharpExpressionConverter.ConvertO(initiator);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTables(Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/LookupTable/GetLookupTables";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "strategicportfoliomanager")]
        public IBodyWorkflowAction<Item[]> LookupTableGetLookupTableValues(Expression<Func<string>> siteUrl, Expression<Func<string>> optionSetUid)
        {
            var apiCallPath = "/LookupTable/GetLookupTableValues";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["optionSetUid"] = CSharpExpressionConverter.ConvertO(optionSetUid);
            return new ApiConnectionAction<Item[]>(callPayload);
        }
    }

    public class StrategicportfoliomanagerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddFinancialValuesChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddFinancialValuesChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddEntityDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddEntityDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddStageTransitionHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddStageTransitionHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsApprovalWorkflowStartedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddActualsApprovalWorkflowStartedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddActualsPeriodStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddActualsPeriodStatusChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddChangeRequestStatusChangedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddChangeRequestStatusChangedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentAddedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentAddedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentRemovedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentRemovedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddResourceAssignmentUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddResourceAssignmentUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddMilestoneDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddMilestoneDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipCreatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipCreatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipUpdatedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipUpdatedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
            eventCreationInformation["ReceiverEndpoint"] = "@listCallbackUrl()";
            eventCreationInformationpropCount++;
            if (eventCreationInformationpropCount > 0)
            {
                callPayload.Body = eventCreationInformation;
            }

            return new ApiConnectionTrigger<EventCreationResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<EventCreationResponse> EventsAddRelationshipDeletedHook(Expression<Func<string>> eventCreationInformationsiteURL, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Events/AddRelationshipDeletedHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var eventCreationInformation = new JObject();
            var eventCreationInformationpropCount = 0;
            eventCreationInformationpropCount++;
            eventCreationInformation["SiteURL"] = CSharpExpressionConverter.ConvertToken(eventCreationInformationsiteURL);
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