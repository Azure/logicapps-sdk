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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SiteManagementRegisterSiteCollection(Expression<Func<string>> workPoint365Url, Expression<Func<SiteManagementRegisterSiteCollectionParameterInput>> parameter)
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
        public IBodyWorkflowAction<WorkPoint365WebApiModelAction[], ApiConnectionActionConfiguration> ActionManagementActions(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelAction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Actions", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelAction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelTrigger[], ApiConnectionActionConfiguration> ActionManagementTriggers(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelTrigger[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Triggers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelTrigger[]>(callPayload);
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
        public IBodyWorkflowAction<WorkPoint365WebApiModelBusinessModuleOnline[], ApiConnectionActionConfiguration> BusinessModulesGet(Expression<Func<string>> workPoint365Url)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelBusinessModuleOnline[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/BusinessModules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelBusinessModuleOnline[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DocumentConvertToPdfAndSaveOutput(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPdfAndSaveOutputParameterInput>> parameter)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DocumentDigitalSignatureCreateLogEntryForTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCreateLogEntryForTransactionParameterInput>> parameter)
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
        public IBodyWorkflowAction<WorkPoint365WebApiModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue, ApiConnectionActionConfiguration> DocumentDigitalSignatureAddDocumentToTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureAddDocumentToTransactionParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureAddDocumentToTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebApiModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration> DocumentDigitalSignatureCompleteDocumentInTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCompleteDocumentInTransactionParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureCompleteDocumentInTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration> DocumentDigitalSignatureBase64CompleteDocumentInTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureBase64CompleteDocumentInTransactionParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureBase64CompleteDocumentInTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebApiModelDocumentDigitalSignatureError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentDigitalSignatureGenerateXwsseHeader(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureGenerateXwsseHeaderParameterInput>> parameter)
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
        public IBodyWorkflowAction<WorkPoint365WebApiModelDocumentLogEntry, ApiConnectionActionConfiguration> DocumentDigitalSignatureLogEntry(Expression<Func<string>> workPoint365Url, Expression<Func<string>> transactionId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_transactionId = WorkflowExpression.Compile(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelDocumentLogEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Document/DigitalSignatureLogEntry/{0}", __workflow_transactionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelDocumentLogEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelMoveEntityResult, ApiConnectionActionConfiguration> EntityMove(Expression<Func<string>> workPoint365Url, Expression<Func<EntityMoveParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelMoveEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Entity/Move";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebApiModelMoveEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ListItemChangeStage(Expression<Func<string>> workPoint365Url, Expression<Func<ListItemChangeStageParameterInput>> parameter)
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
        public IBodyWorkflowAction<WorkPoint365WebApiModelMailMergeHtmlResult, ApiConnectionActionConfiguration> MailMergeGetMailMergedWordDocumentAsHtml(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<int>> templateId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelMailMergeHtmlResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/MailMerge/GetMailMergedWordDocumentAsHtml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["businessModuleID"] = ExpressionConverter.Convert(__workflow_businessModuleId);
                callPayload.Queries["entityID"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Queries["templateID"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelMailMergeHtmlResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelMailMergeDocumentResult, ApiConnectionActionConfiguration> MailMergeGetMailMergedWordDocument(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<int>> templateId, Expression<Func<bool>> includeHtml, Expression<Func<bool>> includeBytes, Expression<Func<string>> commonFieldsBusinessModuleId = null, Expression<Func<int>> commonFieldsEntityId = null)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_includeHtml = WorkflowExpression.Compile(includeHtml, nameof(includeHtml), required: true);
            var __workflow_includeBytes = WorkflowExpression.Compile(includeBytes, nameof(includeBytes), required: true);
            var __workflow_commonFieldsBusinessModuleId = WorkflowExpression.Compile(commonFieldsBusinessModuleId, nameof(commonFieldsBusinessModuleId), required: false);
            var __workflow_commonFieldsEntityId = WorkflowExpression.Compile(commonFieldsEntityId, nameof(commonFieldsEntityId), required: false);
            return new DeferredBodyAction<WorkPoint365WebApiModelMailMergeDocumentResult, ApiConnectionActionConfiguration>(() =>
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
                return new ApiConnectionAction<WorkPoint365WebApiModelMailMergeDocumentResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelPowerAppAndFlowParameter, ApiConnectionActionConfiguration> ParameterGetPowerAppAndFlowParameter(Expression<Func<string>> workPoint365Url, Expression<Func<string>> identifier)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelPowerAppAndFlowParameter, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Parameter/GetPowerAppAndFlowParameter/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelPowerAppAndFlowParameter>(callPayload);
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> EntityChangeStage(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> stageId, Expression<Func<OverrideConstraintsInput>> overrideConstraints, Expression<Func<bool>> overrideRequiredFields, Expression<Func<object>> data)
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
        public IBodyWorkflowTrigger<MicrosoftAspNetWebHooksWebHook, ApiConnectionPollingTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<WebHookInput>> webHook)
        {
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<MicrosoftAspNetWebHooksWebHook, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhooks/registrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionPollingTrigger<MicrosoftAspNetWebHooksWebHook>(callPayload);
            });
        }
    }

    public class SiteManagementRegisterSiteCollectionParameterInput
    {
        public SiteManagementRegisterSiteCollectionParameterInput(string siteCollectionServerRelativeUrl, string bussinessModuleId, ParameterInputSiteCollectionTypeType siteCollectionType)
        {
            this.SiteCollectionServerRelativeUrl = siteCollectionServerRelativeUrl;
            this.BussinessModuleId = bussinessModuleId;
            this.SiteCollectionType = siteCollectionType;
        }

        [JsonProperty("ServerRelativeUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SiteCollectionServerRelativeUrl { get; set; }

        [JsonProperty("AssignedToBusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BussinessModuleId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSiteCollectionTypeType SiteCollectionType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSiteCollectionTypeType
    {
        Bucket,
        Entity
    }

    public class WorkPoint365WebApiModelAction
    {
        [JsonProperty("Title")]
        public string ActionTitle { get; set; }

        [JsonProperty("Id")]
        public string UniqueActionId { get; set; }
    }

    public class WorkPoint365WebApiModelTrigger
    {
        [JsonProperty("Title")]
        public string TriggerTitle { get; set; }

        [JsonProperty("Id")]
        public string UniqueTriggerId { get; set; }
    }

    public class WorkPoint365WebApiModelBusinessModuleOnline
    {
        public string Title { get; set; }
        public string EntityName { get; set; }
        public int Template { get; set; }
        public int Category { get; set; }
        public string Parent { get; set; }
        public string ParentRelationName { get; set; }
        public bool SitesEnabled { get; set; }
        public string IconUrl { get; set; }

        [JsonProperty("EnableEMMIntegration")]
        public bool EnableEmmIntegration { get; set; }
        public string Id { get; set; }
    }

    public class DocumentConvertToPdfAndSaveOutputParameterInput
    {
        public DocumentConvertToPdfAndSaveOutputParameterInput(string absoluteDocumentSiteUrl, string absoluteDocumentUrl, string absoluteOutputSiteUrl, string absoluteOutputUrl, ParameterInputOverrideBehaviourType overrideBehaviour)
        {
            this.AbsoluteDocumentSiteUrl = absoluteDocumentSiteUrl;
            this.AbsoluteDocumentUrl = absoluteDocumentUrl;
            this.AbsoluteOutputSiteUrl = absoluteOutputSiteUrl;
            this.AbsoluteOutputUrl = absoluteOutputUrl;
            this.OverrideBehaviour = overrideBehaviour;
        }

        [JsonProperty("DocumentSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentSiteUrl { get; set; }

        [JsonProperty("DocumentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentUrl { get; set; }

        [JsonProperty("OutputSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteOutputSiteUrl { get; set; }

        [JsonProperty("OutputUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteOutputUrl { get; set; }

        [JsonProperty("OutputExistsBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputOverrideBehaviourType OverrideBehaviour { get; set; }
        public ParameterInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputOverrideBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputPdfFormatType
    {
        [EnumMember(Value = "PDF_A_1A")]
        PdfA1A,
        [EnumMember(Value = "PDF_A_1B")]
        PdfA1B,
        [EnumMember(Value = "PDF_A_2A")]
        PdfA2A,
        [EnumMember(Value = "PDF_A_3A")]
        PdfA3A,
        [EnumMember(Value = "PDF_A_2B")]
        PdfA2B,
        [EnumMember(Value = "PDF_A_2U")]
        PdfA2U,
        [EnumMember(Value = "PDF_A_3B")]
        PdfA3B,
        [EnumMember(Value = "PDF_A_3U")]
        PdfA3U,
        [EnumMember(Value = "PDF_v_1_3")]
        PdfV13,
        [EnumMember(Value = "PDF_v_1_4")]
        PdfV14,
        [EnumMember(Value = "PDF_v_1_5")]
        PdfV15,
        [EnumMember(Value = "PDF_v_1_6")]
        PdfV16,
        [EnumMember(Value = "PDF_v_1_7")]
        PdfV17,
        [EnumMember(Value = "PDF_UA_1")]
        PdfUa1,
        [EnumMember(Value = "PDF_X_1A")]
        PdfX1A,
        [EnumMember(Value = "PDF_X_3")]
        PdfX3
    }

    public class DocumentDigitalSignatureCreateLogEntryForTransactionParameterInput
    {
        public DocumentDigitalSignatureCreateLogEntryForTransactionParameterInput(string transactionId, ParameterInputSigningProviderType signingProvider, string businessModuleId, int entityId, int totalSigningCount, int totalAppendixCount)
        {
            this.TransactionId = transactionId;
            this.SigningProvider = signingProvider;
            this.BusinessModuleId = businessModuleId;
            this.EntityId = entityId;
            this.TotalSigningCount = totalSigningCount;
            this.TotalAppendixCount = totalAppendixCount;
        }

        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSigningProviderType SigningProvider { get; set; }
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
    public enum ParameterInputSigningProviderType
    {
        Penneo,
        Visma,
        [EnumMember(Value = "DocuSign")]
        Docusign,
        AdobeSign,
        Other
    }

    public class WorkPoint365WebApiModelDocumentDigitalSignatureAddDocumentToTransactionReturnValue
    {
        public string PdfUrl { get; set; }
        public string PdfServerRelativeUrl { get; set; }

        [JsonProperty("Errors")]
        public WorkPoint365WebApiModelDocumentDigitalSignatureError[] ACollectionOfErrors { get; set; }
    }

    public class WorkPoint365WebApiModelDocumentDigitalSignatureError
    {
        public WorkPoint365WebApiModelDocumentDigitalSignatureErrorErrorTypeType ErrorType { get; set; }
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelDocumentDigitalSignatureErrorErrorTypeType
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

    public class DocumentDigitalSignatureAddDocumentToTransactionParameterInput
    {
        public DocumentDigitalSignatureAddDocumentToTransactionParameterInput(string transactionId, string absoluteDocumentSiteUrl, string absoluteDocumentUrl, ParameterInputSigningPropertiesBehaviourType signingPropertiesBehaviour, ParameterInputRecordDeclarationSettingType recordDeclarationSetting, ParameterInputSigningTypeType signingType)
        {
            this.TransactionId = transactionId;
            this.AbsoluteDocumentSiteUrl = absoluteDocumentSiteUrl;
            this.AbsoluteDocumentUrl = absoluteDocumentUrl;
            this.SigningPropertiesBehaviour = signingPropertiesBehaviour;
            this.RecordDeclarationSetting = recordDeclarationSetting;
            this.SigningType = signingType;
        }

        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty("DocumentSiteUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentSiteUrl { get; set; }

        [JsonProperty("DocumentUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AbsoluteDocumentUrl { get; set; }

        [JsonProperty("SigningSetPropertiesBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSigningPropertiesBehaviourType SigningPropertiesBehaviour { get; set; }

        [JsonProperty("SigningDeclareAsRecordBehaviour", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputRecordDeclarationSettingType RecordDeclarationSetting { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSigningTypeType SigningType { get; set; }
        public ParameterInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningPropertiesBehaviourType
    {
        IgnoreErrors,
        ReturnOnErrors
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputRecordDeclarationSettingType
    {
        DoNotDeclare,
        DeclareOriginalDocument,
        DeclarePdf,
        DeclareOriginalDocumentAndPdf
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    public class DocumentDigitalSignatureCompleteDocumentInTransactionParameterInput
    {
        public DocumentDigitalSignatureCompleteDocumentInTransactionParameterInput(string transactionId, string fileName, string signedPdfBytes, ParameterInputSigningStatusType signingStatus, bool documentUndeclarationBehaviour)
        {
            this.TransactionId = transactionId;
            this.FileName = fileName;
            this.SignedPdfBytes = signedPdfBytes;
            this.SigningStatus = signingStatus;
            this.DocumentUndeclarationBehaviour = documentUndeclarationBehaviour;
        }

        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignedPdfBytes { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSigningStatusType SigningStatus { get; set; }
        public string Message { get; set; }

        [JsonProperty("UndeclareOriginalDocumentOrAppendixFileAsRecord", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DocumentUndeclarationBehaviour { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningStatusType
    {
        InProgress,
        Signed,
        Approved,
        Cancelled,
        Rejected,
        Failed
    }

    public class DocumentDigitalSignatureBase64CompleteDocumentInTransactionParameterInput
    {
        public DocumentDigitalSignatureBase64CompleteDocumentInTransactionParameterInput(string transactionId, string fileName, string base64PdfDocument, ParameterInputSigningStatusType signingStatus, bool documentUndeclarationBehaviour)
        {
            this.TransactionId = transactionId;
            this.FileName = fileName;
            this.Base64PdfDocument = base64PdfDocument;
            this.SigningStatus = signingStatus;
            this.DocumentUndeclarationBehaviour = documentUndeclarationBehaviour;
        }

        [JsonProperty("TransactionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("SignedPdfBase64String", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64PdfDocument { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputSigningStatusType SigningStatus { get; set; }
        public string Message { get; set; }

        [JsonProperty("UndeclareOriginalDocumentOrAppendixFileAsRecord", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DocumentUndeclarationBehaviour { get; set; }
    }

    public class DocumentDigitalSignatureGenerateXwsseHeaderParameterInput
    {
        public DocumentDigitalSignatureGenerateXwsseHeaderParameterInput(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class WorkPoint365WebApiModelDocumentLogEntry
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
        public WorkPoint365WebApiModelDocumentLogEntryDetails LogEntryDetails { get; set; }
        public WorkPoint365WebApiModelDocumentLogEntrySigningStatusType SigningStatus { get; set; }
    }

    public class WorkPoint365WebApiModelDocumentLogEntryDetails
    {
        public int TotalSigningCount { get; set; }
        public int TotalAppendixCount { get; set; }
        public int InProgressCount { get; set; }
        public int SignedCount { get; set; }
        public int ApprovedCount { get; set; }
        public int CancelledCount { get; set; }
        public int RejectedCount { get; set; }
        public int FailedCount { get; set; }
        public WorkPoint365WebApiModelDocumentLogEntryDetailsSigningProviderType SigningProvider { get; set; }
        public WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfo[] DocumentInfos { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelDocumentLogEntryDetailsSigningProviderType
    {
        Penneo,
        Visma,
        [EnumMember(Value = "DocuSign")]
        Docusign,
        AdobeSign,
        Other
    }

    public class WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfo
    {
        public string DocumentSiteUrl { get; set; }
        public string DocumentUrl { get; set; }
        public string DocumentLastModified { get; set; }
        public string DocumentVersion { get; set; }
        public string PdfUrl { get; set; }
        public string PdfServerRelativeUrl { get; set; }
        public WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfoSigningStatusType SigningStatus { get; set; }
        public WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfoSigningTypeType SigningType { get; set; }
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
    public enum WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfoSigningStatusType
    {
        InProgress,
        Signed,
        Approved,
        Cancelled,
        Rejected,
        Failed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelDocumentLogEntryDetailsDocumentInfoSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelDocumentLogEntrySigningStatusType
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

    public class WorkPoint365WebApiModelMoveEntityResult
    {
        [JsonProperty("Ok")]
        public bool MoveEntityResultOk { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
        public string ProgressLog { get; set; }
    }

    public class EntityMoveParameterInput
    {
        public EntityMoveParameterInput(string theSourceEntityListId, int theSourceEntityId, string targetEntityListId, string targetEntityContentTypeId, bool validateOnly, bool includeProgressLog, bool runAsJob)
        {
            this.TheSourceEntityListId = theSourceEntityListId;
            this.TheSourceEntityId = theSourceEntityId;
            this.TargetEntityListId = targetEntityListId;
            this.TargetEntityContentTypeId = targetEntityContentTypeId;
            this.ValidateOnly = validateOnly;
            this.IncludeProgressLog = includeProgressLog;
            this.RunAsJob = runAsJob;
        }

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

    public class ListItemChangeStageParameterInput
    {
        public ListItemChangeStageParameterInput(string entityListId, int entityItemId, string stageId, ParameterInputStageContraintsBehaviourType stageContraintsBehaviour, bool overrideRequiredFields)
        {
            this.EntityListId = entityListId;
            this.EntityItemId = entityItemId;
            this.StageId = stageId;
            this.StageContraintsBehaviour = stageContraintsBehaviour;
            this.OverrideRequiredFields = overrideRequiredFields;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string EntityListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EntityItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string StageId { get; set; }

        [JsonProperty("OverrideConstraints", DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputStageContraintsBehaviourType StageContraintsBehaviour { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool OverrideRequiredFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputStageContraintsBehaviourType
    {
        NoOverride,
        OverrideWarnings,
        OverrideErrors,
        OverrideWarningsAndErrors
    }

    public class WorkPoint365WebApiModelMailMergeHtmlResult
    {
        public string Html { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }

        [JsonProperty("Ok")]
        public bool MailMergeHtmlResultOk { get; set; }
    }

    public class WorkPoint365WebApiModelMailMergeDocumentResult
    {
        public string Html { get; set; }
        public string Bytes { get; set; }
        public string FileName { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }

        [JsonProperty("Ok")]
        public bool MailMergeDocumentResultOk { get; set; }
    }

    public class WorkPoint365WebApiModelPowerAppAndFlowParameter
    {
        public WorkPoint365WebApiModelPowerAppAndFlowParameterEntityInfo Entity { get; set; }
        public WorkPoint365WebApiModelPowerAppAndFlowParameterLibraryInfo Library { get; set; }
        public WorkPoint365WebApiModelPowerAppAndFlowParameterDocumentInfo[] Documents { get; set; }
    }

    public class WorkPoint365WebApiModelPowerAppAndFlowParameterEntityInfo
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

    public class WorkPoint365WebApiModelPowerAppAndFlowParameterLibraryInfo
    {
        [JsonProperty("Id")]
        public string LibraryId { get; set; }

        [JsonProperty("ServerRelativeUrl")]
        public string LibraryServerRelativeUrl { get; set; }

        [JsonProperty("Name")]
        public string LibraryName { get; set; }
    }

    public class WorkPoint365WebApiModelPowerAppAndFlowParameterDocumentInfo
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
    public enum OverrideConstraintsInput
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
        public string WorkPoint365Url { get; set; }
        public string BusinessModuleId { get; set; }

        [JsonProperty("WorkPointTrigger")]
        public string TriggerId { get; set; }
    }

    public class WebHookInput
    {
        public WebHookInput(WebHookInputPropertiesType properties)
        {
            this.Properties = properties;
        }

        [JsonProperty("WebHookUri", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUri { get; set; } = "#{listCallbackUrl()}";
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public WebHookInputPropertiesType Properties { get; set; }
    }

    public class WebHookInputPropertiesType
    {
        public WebHookInputPropertiesType(string workPoint365Url, string businessModuleId, string triggerId)
        {
            this.WorkPoint365Url = workPoint365Url;
            this.BusinessModuleId = businessModuleId;
            this.TriggerId = triggerId;
        }

        [JsonProperty("WorkPointUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkPoint365Url { get; set; }

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