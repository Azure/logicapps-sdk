//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workpoint365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Workpoint365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ArchiveTeam(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entity/{1}/ArchiveTeam", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> UnarchiveTeam(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entity/{1}/UnarchiveTeam", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SendMail(Expression<Func<string>> workPoint365Url, Expression<Func<SendMailActionInput>> sendMailAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_sendMailAction = WorkflowExpression.Compile(sendMailAction, nameof(sendMailAction), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Mail/Send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendMailAction);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConcatenateFilesToPdf(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<string>> entityId, Expression<Func<ParametersInput>> parameters)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_parameters = WorkflowExpression.Compile(parameters, nameof(parameters), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entity/{1}/ConcatenateFiles", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameters);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ChangeWelcomePage(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ChangeWelcomePageActionInput>> changeWelcomePageAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_changeWelcomePageAction = WorkflowExpression.Compile(changeWelcomePageAction, nameof(changeWelcomePageAction), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/WelcomePage", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_changeWelcomePageAction);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ConnectToOffice365Group(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ActionInput>> action)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/ConnectToOfficeGroup", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_action);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> LockEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<LockTypeInput>> lockType)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_lockType = WorkflowExpression.Compile(lockType, nameof(lockType), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/Lock", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockType"] = ExpressionConverter.Convert(__workflow_lockType);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> UnlockEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<LockTypeInput>> lockType)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_lockType = WorkflowExpression.Compile(lockType, nameof(lockType), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/Unlock", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lockType"] = ExpressionConverter.Convert(__workflow_lockType);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelMoveEntityResult, ApiConnectionActionConfiguration> MoveEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<MoveActionInput>> moveAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_moveAction = WorkflowExpression.Compile(moveAction, nameof(moveAction), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelMoveEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/MoveEntity", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveAction);
                return new ApiConnectionAction<WorkPoint365WebApiModelMoveEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SetDefaultView(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ViewActionInput>> viewAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_viewAction = WorkflowExpression.Compile(viewAction, nameof(viewAction), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/SetDefaultView", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_viewAction);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ActionManagementMarkEntityAsFavorite(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<MarkAsFavoriteActionInput>> markAsFavoriteAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_markAsFavoriteAction = WorkflowExpression.Compile(markAsFavoriteAction, nameof(markAsFavoriteAction), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/MarkFavorite", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_markAsFavoriteAction);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelBusinessModuleOnline, ApiConnectionActionConfiguration> BusinessModulesLookup(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelBusinessModuleOnline, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebApiModelBusinessModuleOnline>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ConsentSetSelectedSiteFullControl(Expression<Func<string>> workPoint365Url, Expression<Func<string>> siteUrl)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Consent/WorkPoint/Permissions/SelectedSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentCopyDocuments(Expression<Func<string>> workPoint365Url, Expression<Func<CopyDocumentModelInput>> copyDocumentModel)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_copyDocumentModel = WorkflowExpression.Compile(copyDocumentModel, nameof(copyDocumentModel), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/CopyDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_copyDocumentModel);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<WorkPoint365WebApiModelProcessContextItemOutPutResult, ApiConnectionActionConfiguration> DocumentConvertToPdf(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPdfParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebApiModelProcessContextItemOutPutResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/ConvertToPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebApiModelProcessContextItemOutPutResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DocumentConvertToPdfAndSaveOutput(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPdfAndSaveOutputParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/ConvertToPdfAndSaveOutput";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DocumentDigitalSignatureCreateLogEntryForTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCreateLogEntryForTransactionParameterInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DigitalSignatureCreateLogEntryForTransaction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompressToZipFile(Expression<Func<string>> workPoint365Url, Expression<Func<CompressToZipFileModelInput>> model)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/CompressToZip";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EntityCreate(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<bool>> createSite, Expression<Func<object>> body)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_createSite = WorkflowExpression.Compile(createSite, nameof(createSite), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Create/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_createSite.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<object>> data)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Update/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EntityGet(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Entity/{0}/Get/{1}", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> EntityActivityLogAdd(Expression<Func<string>> workPoint365Url, Expression<Func<EntityActivityLogAddModelInput>> model)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_model = WorkflowExpression.Compile(model, nameof(model), required: true);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EntityActivityLog/Add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_model);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateItem(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> listWebRelativeUrl, Expression<Func<object>> body, Expression<Func<OutputExistsInput>> outputExists = null, Expression<Func<string>> contentType = null, Expression<Func<string>> templateList = null, Expression<Func<int>> templateItem = null, Expression<Func<string>> folder = null)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_listWebRelativeUrl = WorkflowExpression.Compile(listWebRelativeUrl, nameof(listWebRelativeUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_outputExists = WorkflowExpression.Compile(outputExists, nameof(outputExists), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_templateList = WorkflowExpression.Compile(templateList, nameof(templateList), required: false);
            var __workflow_templateItem = WorkflowExpression.Compile(templateItem, nameof(templateItem), required: false);
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/Lists/ListItems/Create", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listWebRelativeUrl"] = ExpressionConverter.Convert(__workflow_listWebRelativeUrl);
                if (__workflow_outputExists != null)
                    callPayload.Queries["outputExists"] = ExpressionConverter.Convert(__workflow_outputExists);
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_templateList != null)
                    callPayload.Queries["templateList"] = ExpressionConverter.Convert(__workflow_templateList);
                if (__workflow_templateItem != null)
                    callPayload.Queries["templateItem"] = ExpressionConverter.Convert(__workflow_templateItem);
                if (__workflow_folder != null)
                    callPayload.Queries["folder"] = ExpressionConverter.Convert(__workflow_folder);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateItem(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> listWebRelativeUrl, Expression<Func<int>> listItemId, Expression<Func<string>> contentType, Expression<Func<object>> body)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_listWebRelativeUrl = WorkflowExpression.Compile(listWebRelativeUrl, nameof(listWebRelativeUrl), required: true);
            var __workflow_listItemId = WorkflowExpression.Compile(listItemId, nameof(listItemId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/Lists/ListItems/Update", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listWebRelativeUrl"] = ExpressionConverter.Convert(__workflow_listWebRelativeUrl);
                callPayload.Queries["listItemId"] = ExpressionConverter.Convert(__workflow_listItemId);
                callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateAListItem(Expression<Func<string>> workPoint365Url, Expression<Func<string>> listId, Expression<Func<object>> fieldsDictionary)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_fieldsDictionary = WorkflowExpression.Compile(fieldsDictionary, nameof(fieldsDictionary), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/List/{0}/ListItem", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fieldsDictionary);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAListItem(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> listWebRelativeUrl, Expression<Func<int>> listItemId)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_listWebRelativeUrl = WorkflowExpression.Compile(listWebRelativeUrl, nameof(listWebRelativeUrl), required: true);
            var __workflow_listItemId = WorkflowExpression.Compile(listItemId, nameof(listItemId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/Lists/ListItems", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["listWebRelativeUrl"] = ExpressionConverter.Convert(__workflow_listWebRelativeUrl);
                callPayload.Queries["listItemId"] = ExpressionConverter.Convert(__workflow_listItemId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> NumeratorServiceGetNextSequenceNumber(Expression<Func<string>> workPoint365Url, Expression<Func<int>> id, Expression<Func<string>> bmId = null, Expression<Func<int>> entityId = null)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bmId = WorkflowExpression.Compile(bmId, nameof(bmId), required: false);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/NumeratorService/NextSequenceNumber/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_bmId != null)
                    callPayload.Queries["bmId"] = ExpressionConverter.Convert(__workflow_bmId);
                if (__workflow_entityId != null)
                    callPayload.Queries["entityId"] = ExpressionConverter.Convert(__workflow_entityId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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
    }

    public class Workpoint365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WorkPoint365WebApiModelWorkPointWebHook, ApiConnectionPollingTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<string>> workPoint365Url, Expression<Func<WebHookInput>> webHook)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WorkPoint365WebApiModelWorkPointWebHook, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookproxy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionPollingTrigger<WorkPoint365WebApiModelWorkPointWebHook>(callPayload);
            });
        }
    }

    public class SendMailActionInput
    {
        public JToken[] To { get; set; }
        public JToken[] CC { get; set; }

        [JsonProperty("BCC")]
        public JToken[] Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class ParametersInput
    {
        public ParametersInput(string sourceList, string targetBusinessModule, int targetBusinessModuleItem, string targetList, string outputFileName)
        {
            this.SourceList = sourceList;
            this.TargetBusinessModule = targetBusinessModule;
            this.TargetBusinessModuleItem = targetBusinessModuleItem;
            this.TargetList = targetList;
            this.OutputFileName = outputFileName;
        }

        [JsonProperty("Items")]
        public JToken[] Documents { get; set; }
        public ParametersInputPdfFormatType? PdfFormat { get; set; }
        public bool? IncludePageNumbers { get; set; }
        public bool? IncludeSourceInformation { get; set; }
        public bool? IncludeTableOfContents { get; set; }
        public bool? UseLatestMinorVersion { get; set; }
        public bool? OverwriteExistingFiles { get; set; }
        public string SourceFolderPath { get; set; }

        [JsonProperty("SourceListRelativWebPath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceList { get; set; }

        [JsonProperty("TargetBusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBusinessModule { get; set; }

        [JsonProperty("TargetBusinessModuleItemId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TargetBusinessModuleItem { get; set; }
        public string TargetFolderPath { get; set; }

        [JsonProperty("TargetListRelativWebPath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFileName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParametersInputPdfFormatType
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

    public class ChangeWelcomePageActionInput
    {
        [JsonProperty("WelcomePage")]
        public string WelcomePageSeeComment { get; set; }
    }

    public class ActionInput
    {
        public ActionInput(bool isPublic, string groupAlias, string groupDisplayName)
        {
            this.IsPublic = isPublic;
            this.GroupAlias = groupAlias;
            this.GroupDisplayName = groupDisplayName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPublic { get; set; }

        [JsonProperty("DescriptionField")]
        public string Description { get; set; }

        [JsonProperty("GroupAliasField", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupAlias { get; set; }

        [JsonProperty("GroupDisplayNameField", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupDisplayName { get; set; }
        public string CallbackUrl { get; set; }
        public JToken CallbackHeaders { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LockTypeInput
    {
        Record,
        Permission
    }

    public class WorkPoint365WebApiModelMoveEntityResult
    {
        public bool Ok { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
        public string ProgressLog { get; set; }
    }

    public class MoveActionInput
    {
        [JsonProperty("BusinessModuleId")]
        public string TargetBusinessModule { get; set; }

        [JsonProperty("StageId")]
        public string TargetStage { get; set; }
    }

    public class ViewActionInput
    {
        [JsonProperty("ServerRelativeViewUrl")]
        public string ViewUrlServerRelative { get; set; }

        [JsonProperty("WebRelativeListUrl")]
        public string ListUrlWebRelative { get; set; }
    }

    public class MarkAsFavoriteActionInput
    {
        public bool? MarkAsFavorite { get; set; }

        [JsonProperty("UserLoginNames")]
        public string[] Users { get; set; }
    }

    public class WorkPoint365WebApiModelBusinessModuleOnline
    {
        public string Title { get; set; }
        public string ListUrl { get; set; }
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
        public WorkPoint365WebApiModelMasterSiteSettings MasterSiteSettings { get; set; }
        public WorkPoint365WebApiModelFieldMappingsSettings FieldMappingsSettings { get; set; }
        public WorkPoint365WebApiModelClientSettings ClientSettings { get; set; }
    }

    public class WorkPoint365WebApiModelMasterSiteSettings
    {
        public bool Enabled { get; set; }
        public string MasterSiteUrl { get; set; }
        public bool ReplicateLists { get; set; }
        public bool ReplicateAppParts { get; set; }
        public bool ReplicateFeatures { get; set; }
    }

    public class WorkPoint365WebApiModelFieldMappingsSettings
    {
        public WorkPoint365WebApiModelActiveSettings ActiveSettings { get; set; }
        public WorkPoint365WebApiModelCommonFieldMappingsSettings CommonFieldMappingsSettings { get; set; }
        public string[] MyEntitiesFieldNames { get; set; }
        public string CurrentUserMappingField { get; set; }
        public string AddressField { get; set; }
        public string CityField { get; set; }
        public string ZipcodeField { get; set; }
        public string CountryField { get; set; }
        public string[] PhoneFieldNames { get; set; }
        public string[] EmailFieldNames { get; set; }
        public string[] UrlFieldNames { get; set; }
    }

    public class WorkPoint365WebApiModelActiveSettings
    {
        public string FieldName { get; set; }
        public string[] ActiveValues { get; set; }
    }

    public class WorkPoint365WebApiModelCommonFieldMappingsSettings
    {
        public WorkPoint365WebApiModelCommonFieldMapping[] Mappings { get; set; }
    }

    public class WorkPoint365WebApiModelCommonFieldMapping
    {
        public string CommonFieldName { get; set; }
        public string MappedFieldName { get; set; }
    }

    public class WorkPoint365WebApiModelClientSettings
    {
        public bool CachingDisabled { get; set; }
        public string[] FieldsInSearchResult { get; set; }
        public WorkPoint365WebApiModelClientSettingsSearchableField[] SearchableFields { get; set; }
        public WorkPoint365WebApiModelClientSettingsSearchableField[] AdvancedSearchableFields { get; set; }
        public WorkPoint365WebApiModelClientSettingsMobileField[] MobileFields { get; set; }
        public WorkPoint365WebApiModelClientSettingsCommonFieldName[] CommonFieldNames { get; set; }
        public string[] FieldsInFavoriteName { get; set; }
    }

    public class WorkPoint365WebApiModelClientSettingsSearchableField
    {
        public string InternalName { get; set; }
        public string Title { get; set; }
        public WorkPoint365WebApiModelClientSettingsSearchableFieldOperatorType Operator { get; set; }
        public string CommonName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelClientSettingsSearchableFieldOperatorType
    {
        Contains,
        StartsWith,
        Equals
    }

    public class WorkPoint365WebApiModelClientSettingsMobileField
    {
        public string InternalName { get; set; }
        public string Title { get; set; }
        public WorkPoint365WebApiModelClientSettingsMobileFieldMobileFieldVisibilityType MobileFieldVisibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebApiModelClientSettingsMobileFieldMobileFieldVisibilityType
    {
        Hide,
        ShowWithLabel,
        ShowWithoutLabel
    }

    public class WorkPoint365WebApiModelClientSettingsCommonFieldName
    {
        public string InternalName { get; set; }
        public string CommonName { get; set; }
    }

    public class CopyDocumentModelInput
    {
        public CopyDocumentModelInput(CopyDocumentModelInputModeType mode, string targetBusinessModule, int targetEntity, string targetList, CopyDocumentModelInputNamingConflictBehaviorType namingConflictBehavior)
        {
            this.Mode = mode;
            this.TargetBusinessModule = targetBusinessModule;
            this.TargetEntity = targetEntity;
            this.TargetList = targetList;
            this.NamingConflictBehavior = namingConflictBehavior;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CopyDocumentModelInputModeType Mode { get; set; }

        [JsonProperty("TargetBusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBusinessModule { get; set; }

        [JsonProperty("TargetEntityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TargetEntity { get; set; }

        [JsonProperty("TargetWebRelativListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetList { get; set; }

        [JsonProperty("TargetFolderRelativListUrl")]
        public string TargetFolder { get; set; }

        [JsonProperty("NameConflict", DefaultValueHandling = DefaultValueHandling.Include)]
        public CopyDocumentModelInputNamingConflictBehaviorType NamingConflictBehavior { get; set; }
        public bool? IgnoreVersionHistory { get; set; }

        [JsonProperty("ContentTypeId")]
        public string ContentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopyDocumentModelInputModeType
    {
        Copy,
        Move,
        QuickCopy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CopyDocumentModelInputNamingConflictBehaviorType
    {
        Fail,
        Replace,
        Rename
    }

    public class WorkPoint365WebApiModelProcessContextItemOutPutResult
    {
        public WorkPoint365WebApiModelProcessContextItemOutPutViewModel[] Result { get; set; }
        public WorkPoint365WebApiModelProcessContextItemOutPutViewModelWorkPoint365WebApiModelSerializableExceptionResultEventReference[] Errors { get; set; }
        public WorkPoint365WebApiModelProcessContextItemOutPutViewModelSystemStringResultEventReference[] Warnings { get; set; }
        public string SignalRIdentifier { get; set; }
        public string SignalRUrl { get; set; }
    }

    public class WorkPoint365WebApiModelProcessContextItemOutPutViewModel
    {
        public string WebUrl { get; set; }
        public string List { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class WorkPoint365WebApiModelProcessContextItemOutPutViewModelWorkPoint365WebApiModelSerializableExceptionResultEventReference
    {
        public WorkPoint365WebApiModelProcessContextItemOutPutViewModel Reference { get; set; }
        public WorkPoint365WebApiModelSerializableException Event { get; set; }
    }

    public class WorkPoint365WebApiModelSerializableException
    {
        public string TimeStamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public JToken InnerException { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public JToken ExceptionData { get; set; }
    }

    public class WorkPoint365WebApiModelProcessContextItemOutPutViewModelSystemStringResultEventReference
    {
        public WorkPoint365WebApiModelProcessContextItemOutPutViewModel Reference { get; set; }
        public string Event { get; set; }
    }

    public class DocumentConvertToPdfParameterInput
    {
        public DocumentConvertToPdfParameterInput(string destinationBusinessModule, int destinationEntity, string destinationLibrary, ParameterInputOutputExistsBehaviourType outputExistsBehaviour, DocumentConvertToPdfParameterInputPdfFormatType pdfFormat)
        {
            this.DestinationBusinessModule = destinationBusinessModule;
            this.DestinationEntity = destinationEntity;
            this.DestinationLibrary = destinationLibrary;
            this.OutputExistsBehaviour = outputExistsBehaviour;
            this.PdfFormat = pdfFormat;
        }

        [JsonProperty("TargetBusinessModule", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationBusinessModule { get; set; }

        [JsonProperty("TargetBusinessModuleEntity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DestinationEntity { get; set; }

        [JsonProperty("TargetList", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationLibrary { get; set; }

        [JsonProperty("TargetFolder")]
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ParameterInputOutputExistsBehaviourType OutputExistsBehaviour { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentConvertToPdfParameterInputPdfFormatType PdfFormat { get; set; }

        [JsonProperty("UseStepInputValues")]
        public bool? LoadSourcePropertyValues { get; set; }
        public string[] SourceItemFieldsToCopyToPdfItem { get; set; }
        public bool? CombineFiles { get; set; }

        [JsonProperty("FieldValues")]
        public JToken CombinedFileProperties { get; set; }
        public bool? AddPageNumbers { get; set; }
        public bool? AddIndex { get; set; }
        public bool? AddSourceInformation { get; set; }

        [JsonProperty("DocumentVersion")]
        public ParameterInputVersionType? Version { get; set; }
        public bool? Async { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
        public JToken CallbackHeaders { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputOutputExistsBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfParameterInputPdfFormatType
    {
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
        PdfUa1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputVersionType
    {
        LatestVersion,
        LatestMajorVersion
    }

    public class DocumentConvertToPdfAndSaveOutputParameterInput
    {
        public string DocumentSiteUrl { get; set; }
        public string DocumentUrl { get; set; }
        public string OutputSiteUrl { get; set; }
        public string OutputUrl { get; set; }
        public ParameterInputOutputExistsBehaviourType? OutputExistsBehaviour { get; set; }
        public DocumentConvertToPdfAndSaveOutputParameterInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfAndSaveOutputParameterInputPdfFormatType
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
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public ParameterInputSigningProviderType? SigningProvider { get; set; }
        public string LogTitle { get; set; }
        public string LogDescription { get; set; }

        [JsonProperty("BusinessModuleID")]
        public string BusinessModule { get; set; }

        [JsonProperty("EntityID")]
        public int? Entity { get; set; }
        public int? TotalSigningCount { get; set; }
        public int? TotalAppendixCount { get; set; }
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
        public WorkPoint365WebApiModelDocumentDigitalSignatureError[] Errors { get; set; }
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
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string DocumentSiteUrl { get; set; }
        public string DocumentUrl { get; set; }
        public ParameterInputSigningSetPropertiesBehaviourType? SigningSetPropertiesBehaviour { get; set; }
        public ParameterInputSigningDeclareAsRecordBehaviourType? SigningDeclareAsRecordBehaviour { get; set; }
        public ParameterInputSigningTypeType? SigningType { get; set; }
        public DocumentConvertToPdfAndSaveOutputParameterInputPdfFormatType? PdfFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningSetPropertiesBehaviourType
    {
        IgnoreErrors,
        ReturnOnErrors
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningDeclareAsRecordBehaviourType
    {
        DoNotDeclare,
        DeclareOriginalDocument,
        DeclarePdf,
        DeclareOriginalDocumentAndPdf,
        DeclareAppendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    public class DocumentDigitalSignatureCompleteDocumentInTransactionParameterInput
    {
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent SignedPdfBytes { get; set; }

        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string FileName { get; set; }

        [JsonProperty("SigningStatus")]
        public ParameterInputSignedStatusType? SignedStatus { get; set; }
        public string Message { get; set; }
        public bool? UndeclareOriginalDocumentOrAppendixFileAsRecord { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ParameterInputSignedStatusType
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
        public string SignedPdfBase64String { get; set; }

        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string FileName { get; set; }

        [JsonProperty("SigningStatus")]
        public ParameterInputSignedStatusType? SignedStatus { get; set; }
        public string Message { get; set; }
        public bool? UndeclareOriginalDocumentOrAppendixFileAsRecord { get; set; }
    }

    public class DocumentDigitalSignatureGenerateXwsseHeaderParameterInput
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CompressToZipFileModelInput
    {
        public CompressToZipFileModelInput(string destinationBusinessModule, int destinationEntity, string destinationLibrary, ModelInputOutputExistsBehaviourType outputExistsBehaviour)
        {
            this.DestinationBusinessModule = destinationBusinessModule;
            this.DestinationEntity = destinationEntity;
            this.DestinationLibrary = destinationLibrary;
            this.OutputExistsBehaviour = outputExistsBehaviour;
        }

        [JsonProperty("BusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationBusinessModule { get; set; }

        [JsonProperty("EntityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DestinationEntity { get; set; }

        [JsonProperty("List", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationLibrary { get; set; }

        [JsonProperty("Folder")]
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ModelInputOutputExistsBehaviourType OutputExistsBehaviour { get; set; }
        public bool? AddIndex { get; set; }
        public bool? AddSourceInformation { get; set; }

        [JsonProperty("FieldValues")]
        public JToken Fields { get; set; }
        public bool? Async { get; set; }
        public JToken CallbackHeaders { get; set; }
        public string CallbackUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ModelInputOutputExistsBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OverrideConstraintsInput
    {
        NoOverride,
        OverrideWarnings,
        OverrideErrors,
        OverrideWarningsAndErrors
    }

    public class EntityActivityLogAddModelInput
    {
        public EntityActivityLogAddModelInput(string title, string type, string typeId, string sourceType, string date, string businessModule, int entity)
        {
            this.Title = title;
            this.Type = type;
            this.TypeId = typeId;
            this.SourceType = sourceType;
            this.Date = date;
            this.BusinessModule = businessModule;
            this.Entity = entity;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("EventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("EventTypeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TypeId { get; set; }

        [JsonProperty("EventSourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceType { get; set; }

        [JsonProperty("EventDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("EventUser")]
        public string User { get; set; }

        [JsonProperty("EventSystem")]
        public string System { get; set; }

        [JsonProperty("BusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BusinessModule { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Entity { get; set; }
        public string List { get; set; }
        public JToken[] Item { get; set; }
        public string ItemData { get; set; }
        public string Details { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OutputExistsInput
    {
        Cancel,
        Overwrite,
        Rename
    }

    public class WorkPoint365WebApiModelMailMergeHtmlResult
    {
        public string Html { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }
        public bool Ok { get; set; }
    }

    public class WorkPoint365WebApiModelMailMergeDocumentResult
    {
        public string Html { get; set; }
        public string Bytes { get; set; }
        public string FileName { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }
        public bool Ok { get; set; }
    }

    public class WorkPoint365WebApiModelWorkPointWebHook
    {
        public string Id { get; set; }
        public string Description { get; set; }

        [JsonProperty("IsPaused")]
        public bool ActiveState { get; set; }
        public WorkPoint365WebApiModelWorkPointWebHookProperties Properties { get; set; }
    }

    public class WorkPoint365WebApiModelWorkPointWebHookProperties
    {
        public string BusinessModuleId { get; set; }

        [JsonProperty("WorkPointTrigger")]
        public string TriggerId { get; set; }

        [JsonProperty("WorkPointUrl")]
        public string WorkPoint365Url { get; set; }
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
        public WebHookInputPropertiesType(string businessModule, string triggerId)
        {
            this.BusinessModule = businessModule;
            this.TriggerId = triggerId;
        }

        [JsonProperty("BusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BusinessModule { get; set; }

        [JsonProperty("WorkPointTrigger", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TriggerId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workpoint365;

    public partial class WorkflowManagedActions
    {
        public Workpoint365Actions Workpoint365(string connectionId) => new Workpoint365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Workpoint365Triggers Workpoint365(string connectionId) => new Workpoint365Triggers(connectionId);
    }
}