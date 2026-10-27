//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workpoint
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkpointActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SiteManagementRegisterSiteCollection(Expression<Func<string>> workPoint365Url, Expression<Func<SiteManagementRegisterSiteCollectionInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/SiteManagement/RegisterSiteCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelAction[], ApiConnectionActionConfiguration> ActionManagementActions(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelAction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Actions", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelAction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelTrigger[], ApiConnectionActionConfiguration> ActionManagementTriggers(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelTrigger[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Triggers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelTrigger[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ActionManagementRunAction(Expression<Func<string>> workPoint365Url, Expression<Func<string>> bmId, Expression<Func<string>> actionId, Expression<Func<int>> entityId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_bmId = WorkflowExpression.Compile(bmId, nameof(bmId), required: true);
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Actions/{1}/Run", __workflow_bmId.WithUrlEncoding(1), __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelBusinessModuleOnline[], ApiConnectionActionConfiguration> BusinessModulesGet(Expression<Func<string>> workPoint365Url)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelBusinessModuleOnline[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/BusinessModules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelBusinessModuleOnline[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DocumentConvertToPdfAndSaveOutput(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPdfAndSaveOutputInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/ConvertToPdfAndSaveOutput";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DocumentDigitalSignatureCreateLogEntryForTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCreateLogEntryForTransactionInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureCreateLogEntryForTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue, ApiConnectionActionConfiguration> DocumentDigitalSignatureAddDocumentToTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureAddDocumentToTransactionInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureAddDocumentToTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebAPIModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration> DocumentDigitalSignatureCompleteDocumentInTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCompleteDocumentInTransactionInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureCompleteDocumentInTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration> DocumentDigitalSignatureBase64CompleteDocumentInTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureBase64CompleteDocumentInTransactionInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureBase64CompleteDocumentInTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebAPIModelDocumentDigitalSignatureError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentDigitalSignatureGenerateXwsseHeader(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureGenerateXwsseHeaderInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureGenerateXwsseHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> DocumentDigitalSignatureUnixTimeMilliseconds(Expression<Func<string>> workPoint365Url)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureUnixTimeMilliseconds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelDocumentLogEntry, ApiConnectionActionConfiguration> DocumentDigitalSignatureLogEntry(Expression<Func<string>> workPoint365Url, Expression<Func<string>> transactionId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelDocumentLogEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Document/DigitalSignatureLogEntry/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelDocumentLogEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelMoveEntityResult, ApiConnectionActionConfiguration> EntityMove(Expression<Func<string>> workPoint365Url, Expression<Func<EntityMoveInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelMoveEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Entity/Move";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebAPIModelMoveEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ListItemChangeStage(Expression<Func<string>> workPoint365Url, Expression<Func<ListItemChangeStageInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ListItem/ChangeStage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelMailMergeHtmlResult, ApiConnectionActionConfiguration> MailMergeGetMailMergedWordDocumentAsHtml(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<int>> templateId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelMailMergeHtmlResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/MailMerge/GetMailMergedWordDocumentAsHtml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessModuleID"] = ExpressionConverter.Convert(__workflow_businessModuleId);
                callPayload.Queries["entityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["templateID"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelMailMergeHtmlResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelMailMergeDocumentResult, ApiConnectionActionConfiguration> MailMergeGetMailMergedWordDocument(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<int>> templateId, Expression<Func<bool>> includeHtml, Expression<Func<bool>> includeBytes, Expression<Func<string>> commonFieldsBusinessModuleId = null, Expression<Func<int>> commonFieldsEntityId = null)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_includeHtml = WorkflowExpression.Compile(includeHtml, nameof(includeHtml), required: true);
            var __workflow_includeBytes = WorkflowExpression.Compile(includeBytes, nameof(includeBytes), required: true);
            var __workflow_commonFieldsBusinessModuleId = WorkflowExpression.Compile(commonFieldsBusinessModuleId, nameof(commonFieldsBusinessModuleId), required: false);
            var __workflow_commonFieldsEntityId = WorkflowExpression.Compile(commonFieldsEntityId, nameof(commonFieldsEntityId), required: false);
            return new DeferredBodyAction<WorkPoint365WebAPIModelMailMergeDocumentResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/MailMerge/GetMailMergedWordDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessModuleID"] = ExpressionConverter.Convert(__workflow_businessModuleId);
                callPayload.Queries["entityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["templateID"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["includeHtml"] = ExpressionConverter.Convert(__workflow_includeHtml);
                callPayload.Queries["includeBytes"] = ExpressionConverter.Convert(__workflow_includeBytes);
                if (__workflow_commonFieldsBusinessModuleId != null)
                    callPayload.Queries["commonFieldsBusinessModuleID"] = ExpressionConverter.Convert(__workflow_commonFieldsBusinessModuleId);
                if (__workflow_commonFieldsEntityId != null)
                    callPayload.Queries["commonFieldsEntityID"] = ExpressionConverter.Convert(__workflow_commonFieldsEntityId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelMailMergeDocumentResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelPowerAppAndFlowParameter, ApiConnectionActionConfiguration> ParameterGetPowerAppAndFlowParameter(Expression<Func<string>> workPoint365Url, Expression<Func<string>> identifier)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelPowerAppAndFlowParameter, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Parameter/GetPowerAppAndFlowParameter/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelPowerAppAndFlowParameter>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RecordManagementDeclare(Expression<Func<string>> workPoint365Url, Expression<Func<string>> siteUrl, Expression<Func<string>> documentUrl)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentUrl = WorkflowExpression.Compile(documentUrl, nameof(documentUrl), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/RecordManagement/Declare";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["documentUrl"] = ExpressionConverter.Convert(__workflow_documentUrl);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RecordManagementUndeclare(Expression<Func<string>> workPoint365Url, Expression<Func<string>> siteUrl, Expression<Func<string>> documentUrl)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentUrl = WorkflowExpression.Compile(documentUrl, nameof(documentUrl), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/RecordManagement/Undeclare";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["documentUrl"] = ExpressionConverter.Convert(__workflow_documentUrl);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> EntityChangeStage(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> stageId, Expression<Func<overrideConstraintsInput>> overrideConstraints, Expression<Func<bool>> overrideRequiredFields, Expression<Func<object>> data)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_stageId = WorkflowExpression.Compile(stageId, nameof(stageId), required: true);
            var __workflow_overrideConstraints = WorkflowExpression.Compile(overrideConstraints, nameof(overrideConstraints), required: true);
            var __workflow_overrideRequiredFields = WorkflowExpression.Compile(overrideRequiredFields, nameof(overrideRequiredFields), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/ChangeStage/{1}/{2}/{3}/{4}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1), __workflow_stageId.WithUrlEncoding(1), __workflow_overrideConstraints.WithUrlEncoding(1), __workflow_overrideRequiredFields.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> EntityCopy(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> sourceEntityId, Expression<Func<object>> data)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_sourceEntityId = WorkflowExpression.Compile(sourceEntityId, nameof(sourceEntityId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Copy/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_sourceEntityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> EntityCreate(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<bool>> createSite, Expression<Func<object>> data)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_createSite = WorkflowExpression.Compile(createSite, nameof(createSite), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Create/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_createSite.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> EntityUpdate(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<object>> data)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Update/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<int>(callPayload);
            });
        }
    }

    public class WorkpointTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MicrosoftAspNetWebHooksWebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<WebHookRegistrationsPostInput>> webHook, FlowRecurrence recurrence = null)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<MicrosoftAspNetWebHooksWebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhooks/registrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionTrigger<MicrosoftAspNetWebHooksWebHook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SiteManagementRegisterSiteCollectionInput
    {
        [JsonProperty("ServerRelativeUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteCollectionServerRelativeUrl { get; set; }

        [JsonProperty("AssignedToBusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BussinessModuleId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SiteManagementRegisterSiteCollectionInputSiteCollectionTypeType SiteCollectionType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SiteManagementRegisterSiteCollectionInputSiteCollectionTypeType
    {
        Bucket,
        Entity
    }

    public class WorkPoint365WebAPIModelAction
    {
        [JsonProperty("Title")]
        public string ActionTitle { get; set; }

        [JsonProperty("Id")]
        public string UniqueActionId { get; set; }
    }

    public class WorkPoint365WebAPIModelTrigger
    {
        [JsonProperty("Title")]
        public string TriggerTitle { get; set; }

        [JsonProperty("Id")]
        public string UniqueTriggerId { get; set; }
    }

    public class WorkPoint365WebAPIModelBusinessModuleOnline
    {
        public string Title { get; set; }
        public string EntityName { get; set; }
        public int Template { get; set; }
        public int Category { get; set; }
        public string Parent { get; set; }
        public string ParentRelationName { get; set; }
        public bool SitesEnabled { get; set; }
        public string IconUrl { get; set; }
        public bool EnableEMMIntegration { get; set; }
        public string Id { get; set; }
    }

    public class DocumentConvertToPdfAndSaveOutputInput
    {
        [JsonProperty("DocumentSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentSiteURL { get; set; }

        [JsonProperty("DocumentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentURL { get; set; }

        [JsonProperty("OutputSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteOutputSiteURL { get; set; }

        [JsonProperty("OutputUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteOutputURL { get; set; }

        [JsonProperty("OutputExistsBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentConvertToPdfAndSaveOutputInputOverrideBehaviourType OverrideBehaviour { get; set; }
        public DocumentConvertToPdfAndSaveOutputInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfAndSaveOutputInputOverrideBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfAndSaveOutputInputPdfFormatType
    {
        [EnumMember(Value = "PDF_A_1A")]
        PDFA1A,
        [EnumMember(Value = "PDF_A_1B")]
        PDFA1B,
        [EnumMember(Value = "PDF_A_2A")]
        PDFA2A,
        [EnumMember(Value = "PDF_A_3A")]
        PDFA3A,
        [EnumMember(Value = "PDF_A_2B")]
        PDFA2B,
        [EnumMember(Value = "PDF_A_2U")]
        PDFA2U,
        [EnumMember(Value = "PDF_A_3B")]
        PDFA3B,
        [EnumMember(Value = "PDF_A_3U")]
        PDFA3U,
        [EnumMember(Value = "PDF_v_1_3")]
        PDFV13,
        [EnumMember(Value = "PDF_v_1_4")]
        PDFV14,
        [EnumMember(Value = "PDF_v_1_5")]
        PDFV15,
        [EnumMember(Value = "PDF_v_1_6")]
        PDFV16,
        [EnumMember(Value = "PDF_v_1_7")]
        PDFV17,
        [EnumMember(Value = "PDF_UA_1")]
        PDFUA1,
        [EnumMember(Value = "PDF_X_1A")]
        PDFX1A,
        [EnumMember(Value = "PDF_X_3")]
        PDFX3
    }

    public class DocumentDigitalSignatureCreateLogEntryForTransactionInput
    {
        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureCreateLogEntryForTransactionInputSigningProviderType SigningProvider { get; set; }
        public string LogTitle { get; set; }
        public string LogDescription { get; set; }

        [JsonProperty("BusinessModuleID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BusinessModuleId { get; set; }

        [JsonProperty("EntityID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntityId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TotalSigningCount { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TotalAppendixCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureCreateLogEntryForTransactionInputSigningProviderType
    {
        Penneo,
        Visma,
        DocuSign,
        AdobeSign,
        Other
    }

    public class WorkPoint365WebAPIModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue
    {
        public string PdfUrl { get; set; }
        public string PdfServerRelativeUrl { get; set; }

        [JsonProperty("Errors")]
        public WorkPoint365WebAPIModelDocumentDigitalSignatureError[] ACollectionOfErrors { get; set; }
    }

    public class WorkPoint365WebAPIModelDocumentDigitalSignatureError
    {
        public WorkPoint365WebAPIModelDocumentDigitalSignatureErrorErrorTypeType ErrorType { get; set; }
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelDocumentDigitalSignatureErrorErrorTypeType
    {
        LogEntryNotFound,
        SetPropertyError,
        DeclareOriginalDocumentAsRecordError,
        DeclarePdfFileAsRecordError,
        DeclareAppendixFileAsRecordError,
        UndeclareOriginalDocumentAsRecordError,
        UndeclarePdfFileAsRecordError,
        UndeclareAppendixFileAsRecordError,
        IllegalSigningStatus,
        FileNotFoundInLog,
        MultipleFilesFoundInLog,
        DocumentHasAlreadyBeenAdded,
        DocumentAlreadySigned,
        DocumentAlreadyApproved,
        PdfFileIsCheckedOut,
        FileDoesNotExistsInSharePoint
    }

    public class DocumentDigitalSignatureAddDocumentToTransactionInput
    {
        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty("DocumentSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentSiteUrl { get; set; }

        [JsonProperty("DocumentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentUrl { get; set; }

        [JsonProperty("SigningSetPropertiesBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureAddDocumentToTransactionInputSigningPropertiesBehaviourType SigningPropertiesBehaviour { get; set; }

        [JsonProperty("SigningDeclareAsRecordBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureAddDocumentToTransactionInputRecordDeclarationSettingType RecordDeclarationSetting { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureAddDocumentToTransactionInputSigningTypeType SigningType { get; set; }
        public DocumentDigitalSignatureAddDocumentToTransactionInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputSigningPropertiesBehaviourType
    {
        IgnoreErrors,
        ReturnOnErrors
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputRecordDeclarationSettingType
    {
        DoNotDeclare,
        DeclareOriginalDocument,
        DeclarePdf,
        DeclareOriginalDocumentAndPdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputPdfFormatType
    {
        [EnumMember(Value = "PDF_A_1A")]
        PDFA1A,
        [EnumMember(Value = "PDF_A_1B")]
        PDFA1B,
        [EnumMember(Value = "PDF_A_2A")]
        PDFA2A,
        [EnumMember(Value = "PDF_A_3A")]
        PDFA3A,
        [EnumMember(Value = "PDF_A_2B")]
        PDFA2B,
        [EnumMember(Value = "PDF_A_2U")]
        PDFA2U,
        [EnumMember(Value = "PDF_A_3B")]
        PDFA3B,
        [EnumMember(Value = "PDF_A_3U")]
        PDFA3U,
        [EnumMember(Value = "PDF_v_1_3")]
        PDFV13,
        [EnumMember(Value = "PDF_v_1_4")]
        PDFV14,
        [EnumMember(Value = "PDF_v_1_5")]
        PDFV15,
        [EnumMember(Value = "PDF_v_1_6")]
        PDFV16,
        [EnumMember(Value = "PDF_v_1_7")]
        PDFV17,
        [EnumMember(Value = "PDF_UA_1")]
        PDFUA1,
        [EnumMember(Value = "PDF_X_1A")]
        PDFX1A,
        [EnumMember(Value = "PDF_X_3")]
        PDFX3
    }

    public class DocumentDigitalSignatureCompleteDocumentInTransactionInput
    {
        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("SignedPdfBytes", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignedPDFBytes { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureCompleteDocumentInTransactionInputSigningStatusType SigningStatus { get; set; }
        public string Message { get; set; }

        [JsonProperty("UndeclareOriginalDocumentOrAppendixFileAsRecord", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DocumentUndeclarationBehaviour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureCompleteDocumentInTransactionInputSigningStatusType
    {
        InProgress,
        Signed,
        Approved,
        Cancelled,
        Rejected,
        Failed
    }

    public class DocumentDigitalSignatureBase64CompleteDocumentInTransactionInput
    {
        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("SignedPdfBase64String", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64PDFDocument { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentDigitalSignatureBase64CompleteDocumentInTransactionInputSigningStatusType SigningStatus { get; set; }
        public string Message { get; set; }

        [JsonProperty("UndeclareOriginalDocumentOrAppendixFileAsRecord", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DocumentUndeclarationBehaviour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureBase64CompleteDocumentInTransactionInputSigningStatusType
    {
        InProgress,
        Signed,
        Approved,
        Cancelled,
        Rejected,
        Failed
    }

    public class DocumentDigitalSignatureGenerateXwsseHeaderInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class WorkPoint365WebAPIModelDocumentLogEntry
    {
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [JsonProperty("BusinessModuleID")]
        public string BusinessModuleId { get; set; }
        public string BusinessModuleTitle { get; set; }

        [JsonProperty("EntityID")]
        public int EntityId { get; set; }
        public string EntityTitle { get; set; }
        public string Links { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntryDetails LogEntryDetails { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntrySigningStatusType SigningStatus { get; set; }
    }

    public class WorkPoint365WebAPIModelDocumentLogEntryDetails
    {
        public int TotalSigningCount { get; set; }
        public int TotalAppendixCount { get; set; }
        public int InProgressCount { get; set; }
        public int SignedCount { get; set; }
        public int ApprovedCount { get; set; }
        public int CancelledCount { get; set; }
        public int RejectedCount { get; set; }
        public int FailedCount { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntryDetailsSigningProviderType SigningProvider { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfo[] DocumentInfos { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelDocumentLogEntryDetailsSigningProviderType
    {
        Penneo,
        Visma,
        DocuSign,
        AdobeSign,
        Other
    }

    public class WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfo
    {
        public string DocumentSiteUrl { get; set; }
        public string DocumentUrl { get; set; }
        public string DocumentLastModified { get; set; }
        public string DocumentVersion { get; set; }
        public string PdfUrl { get; set; }
        public string PdfServerRelativeUrl { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfoSigningStatusType SigningStatus { get; set; }
        public WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfoSigningTypeType SigningType { get; set; }
        public string SetPropertiesInfo { get; set; }
        public bool DeclarePdfFileAsRecordRequired { get; set; }
        public bool DeclareOriginalDocumentAsRecordRequired { get; set; }
        public bool DeclareAppendixFileAsRecordRequired { get; set; }
        public string DeclareAsRecordInfo { get; set; }
        public string LogCreated { get; set; }
        public string LogLastModified { get; set; }
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfoSigningStatusType
    {
        InProgress,
        Signed,
        Approved,
        Cancelled,
        Rejected,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelDocumentLogEntryDetailsDocumentInfoSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelDocumentLogEntrySigningStatusType
    {
        InProgress,
        Signed,
        PartialSigned,
        Cancelled,
        PartialCancelled,
        Rejected,
        PartialRejected,
        Failed,
        PartialFailed
    }

    public class WorkPoint365WebAPIModelMoveEntityResult
    {
        [JsonProperty("Ok")]
        public bool MoveEntityResultOk { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
        public string ProgressLog { get; set; }
    }

    public class EntityMoveInput
    {
        [JsonProperty("SourceEntityListID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TheSourceEntityListId { get; set; }

        [JsonProperty("SourceEntityID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TheSourceEntityId { get; set; }

        [JsonProperty("TargetEntityListID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetEntityListId { get; set; }

        [JsonProperty("TargetEntityContentTypeID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetEntityContentTypeId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ValidateOnly { get; set; }

        [JsonProperty("IncludeProgressLogInResult", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeProgressLog { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RunAsJob { get; set; }
    }

    public class ListItemChangeStageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntityItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string StageId { get; set; }

        [JsonProperty("OverrideConstraints", DefaultValueHandling = DefaultValueHandling.Include)]
        public ListItemChangeStageInputStageContraintsBehaviourType StageContraintsBehaviour { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool OverrideRequiredFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListItemChangeStageInputStageContraintsBehaviourType
    {
        NoOverride,
        OverrideWarnings,
        OverrideErrors,
        OverrideWarningsAndErrors
    }

    public class WorkPoint365WebAPIModelMailMergeHtmlResult
    {
        [JsonProperty("Html")]
        public string HTML { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }

        [JsonProperty("Ok")]
        public bool MailMergeHtmlResultOk { get; set; }
    }

    public class WorkPoint365WebAPIModelMailMergeDocumentResult
    {
        [JsonProperty("Html")]
        public string HTML { get; set; }
        public string Bytes { get; set; }

        [JsonProperty("FileName")]
        public string Filename { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }

        [JsonProperty("Ok")]
        public bool MailMergeDocumentResultOk { get; set; }
    }

    public class WorkPoint365WebAPIModelPowerAppAndFlowParameter
    {
        public WorkPoint365WebAPIModelPowerAppAndFlowParameterEntityInfo Entity { get; set; }
        public WorkPoint365WebAPIModelPowerAppAndFlowParameterLibraryInfo Library { get; set; }
        public WorkPoint365WebAPIModelPowerAppAndFlowParameterDocumentInfo[] Documents { get; set; }
    }

    public class WorkPoint365WebAPIModelPowerAppAndFlowParameterEntityInfo
    {
        [JsonProperty("ListId")]
        public string EntityListId { get; set; }

        [JsonProperty("ListItemId")]
        public int EntityListItemId { get; set; }

        [JsonProperty("Title")]
        public string EntityTitle { get; set; }

        [JsonProperty("ServerRelativeUrl")]
        public string EntityServerRelativeUrl { get; set; }
        public JToken Properties { get; set; }
    }

    public class WorkPoint365WebAPIModelPowerAppAndFlowParameterLibraryInfo
    {
        [JsonProperty("Id")]
        public string LibraryId { get; set; }

        [JsonProperty("ServerRelativeUrl")]
        public string LibraryServerRelativeUrl { get; set; }

        [JsonProperty("Name")]
        public string LibraryName { get; set; }
    }

    public class WorkPoint365WebAPIModelPowerAppAndFlowParameterDocumentInfo
    {
        [JsonProperty("Id")]
        public int DocumentId { get; set; }

        [JsonProperty("Name")]
        public string DocumentName { get; set; }

        [JsonProperty("ServerRelativeUrl")]
        public string DocumentServerRelativeUrl { get; set; }
        public JToken Properties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum overrideConstraintsInput
    {
        NoOverride,
        OverrideWarnings,
        OverrideErrors,
        OverrideWarningsAndErrors
    }

    public class MicrosoftAspNetWebHooksWebHook
    {
        public string Id { get; set; }
        public string Description { get; set; }

        [JsonProperty("IsPaused")]
        public bool ActiveState { get; set; }
        public MicrosoftAspNetWebHooksWebHookPropertiesType Properties { get; set; }
    }

    public class MicrosoftAspNetWebHooksWebHookPropertiesType
    {
        [JsonProperty("WorkPointUrl")]
        public string WorkPoint365URL { get; set; }
        public string BusinessModuleId { get; set; }

        [JsonProperty("WorkPointTrigger")]
        public string TriggerId { get; set; }
    }

    public class WebHookRegistrationsPostInput
    {
        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackURI { get; set; } = "#{listCallbackUrl()}";
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookRegistrationsPostInputPropertiesType Properties { get; set; }
    }

    public class WebHookRegistrationsPostInputPropertiesType
    {
        [JsonProperty("WorkPointUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkPoint365URL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string BusinessModuleId { get; set; }

        [JsonProperty("WorkPointTrigger", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workpoint;

    public partial class WorkflowManagedActions
    {
        public WorkpointActions Workpoint(string connectionId) => new WorkpointActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkpointTriggers Workpoint(string connectionId) => new WorkpointTriggers(connectionId);
    }
}