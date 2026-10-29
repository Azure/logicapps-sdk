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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SendMail(Expression<Func<string>> workPoint365Url, Expression<Func<SendMailInput>> sendMailAction)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConcatenateFilesToPDF(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<string>> entityId, Expression<Func<ConcatenateFilesToPDFInput>> parameters)
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ChangeWelcomePage(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ChangeWelcomePageInput>> changeWelcomePageAction)
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ConnectToOffice365Group(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ConnectToOffice365GroupInput>> action)
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> LockEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<lockTypeInput>> lockType)
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> UnlockEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<lockTypeInput>> lockType)
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
        public IBodyWorkflowAction<WorkPoint365WebAPIModelMoveEntityResult, ApiConnectionActionConfiguration> MoveEntity(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<MoveEntityInput>> moveAction)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_businessModuleId = WorkflowExpression.Compile(businessModuleId, nameof(businessModuleId), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_moveAction = WorkflowExpression.Compile(moveAction, nameof(moveAction), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelMoveEntityResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}/Entities/{1}/MoveEntity", __workflow_businessModuleId.WithUrlEncoding(1), __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveAction);
                return new ApiConnectionAction<WorkPoint365WebAPIModelMoveEntityResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> SetDefaultView(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<SetDefaultViewInput>> viewAction)
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
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> ActionManagementMarkEntityAsFavorite(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<ActionManagementMarkEntityAsFavoriteInput>> markAsFavoriteAction)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<WorkPoint365WebAPIModelBusinessModuleOnline, ApiConnectionActionConfiguration> BusinessModulesLookup(Expression<Func<string>> workPoint365Url, Expression<Func<string>> id)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelBusinessModuleOnline, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/BusinessModules/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                return new ApiConnectionAction<WorkPoint365WebAPIModelBusinessModuleOnline>(callPayload);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DocumentCopyDocuments(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentCopyDocumentsInput>> copyDocumentModel)
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
        public IBodyWorkflowAction<WorkPoint365WebAPIModelProcessContextItemOutPutResult, ApiConnectionActionConfiguration> DocumentConvertToPDF(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPDFInput>> parameter)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_parameter = WorkflowExpression.Compile(parameter, nameof(parameter), required: true);
            return new DeferredBodyAction<WorkPoint365WebAPIModelProcessContextItemOutPutResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/ConvertToPDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_parameter);
                return new ApiConnectionAction<WorkPoint365WebAPIModelProcessContextItemOutPutResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DocumentConvertToPdfAndSaveOutput(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentConvertToPdfAndSaveOutputInput>> parameter)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DocumentDigitalSignatureCreateLogEntryForTransaction(Expression<Func<string>> workPoint365Url, Expression<Func<DocumentDigitalSignatureCreateLogEntryForTransactionInput>> parameter)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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
        public IWorkflowAction<ApiConnectionActionConfiguration> CompressToZIPFile(Expression<Func<string>> workPoint365Url, Expression<Func<CompressToZIPFileInput>> model)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> EntityActivityLogAdd(Expression<Func<string>> workPoint365Url, Expression<Func<EntityActivityLogAddInput>> model)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateItem(Expression<Func<string>> workPoint365Url, Expression<Func<string>> businessModuleId, Expression<Func<int>> entityId, Expression<Func<string>> listWebRelativeUrl, Expression<Func<object>> body, Expression<Func<outputExistsInput>> outputExists = null, Expression<Func<string>> contentType = null, Expression<Func<string>> templateList = null, Expression<Func<int>> templateItem = null, Expression<Func<string>> folder = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workpoint365")]
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
        public IBodyWorkflowTrigger<WorkPoint365WebAPIModelWorkPointWebHook, ApiConnectionTriggerConfiguration> WebHookRegistrationsPost(Expression<Func<string>> workPoint365Url, Expression<Func<WebHookRegistrationsPostInput>> webHook, FlowRecurrence recurrence = null)
        {
            var __workflow_workPoint365Url = WorkflowExpression.Compile(workPoint365Url, nameof(workPoint365Url), required: true);
            var __workflow_webHook = WorkflowExpression.Compile(webHook, nameof(webHook), required: true);
            return new DeferredBodyTrigger<WorkPoint365WebAPIModelWorkPointWebHook, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookproxy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["WorkPoint365Url"] = ExpressionConverter.Convert(__workflow_workPoint365Url);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_webHook);
                return new ApiConnectionTrigger<WorkPoint365WebAPIModelWorkPointWebHook>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SendMailInput
    {
        public JToken[] To { get; set; }
        public JToken[] CC { get; set; }
        public JToken[] BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class ConcatenateFilesToPDFInput
    {
        [JsonProperty("Items")]
        public JToken[] Documents { get; set; }
        public ConcatenateFilesToPDFInputPdfFormatType? PdfFormat { get; set; }
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

        [JsonProperty("OutputFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFilename { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConcatenateFilesToPDFInputPdfFormatType
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

    public class ChangeWelcomePageInput
    {
        [JsonProperty("WelcomePage")]
        public string WelcomePageSeeComment { get; set; }
    }

    public class ConnectToOffice365GroupInput
    {
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
    public enum lockTypeInput
    {
        Record,
        Permission
    }

    public class WorkPoint365WebAPIModelMoveEntityResult
    {
        public bool Ok { get; set; }
        public string[] Errors { get; set; }
        public string[] Warnings { get; set; }
        public string ProgressLog { get; set; }
    }

    public class MoveEntityInput
    {
        [JsonProperty("BusinessModuleId")]
        public string TargetBusinessModule { get; set; }

        [JsonProperty("StageId")]
        public string TargetStage { get; set; }
    }

    public class SetDefaultViewInput
    {
        [JsonProperty("ServerRelativeViewUrl")]
        public string ViewURLServerRelative { get; set; }

        [JsonProperty("WebRelativeListUrl")]
        public string ListURLWebRelative { get; set; }
    }

    public class ActionManagementMarkEntityAsFavoriteInput
    {
        public bool? MarkAsFavorite { get; set; }

        [JsonProperty("UserLoginNames")]
        public string[] Users { get; set; }
    }

    public class WorkPoint365WebAPIModelBusinessModuleOnline
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
        public bool EnableEMMIntegration { get; set; }
        public string Id { get; set; }
        public WorkPoint365WebAPIModelMasterSiteSettings MasterSiteSettings { get; set; }
        public WorkPoint365WebAPIModelFieldMappingsSettings FieldMappingsSettings { get; set; }
        public WorkPoint365WebAPIModelClientSettings ClientSettings { get; set; }
    }

    public class WorkPoint365WebAPIModelMasterSiteSettings
    {
        public bool Enabled { get; set; }
        public string MasterSiteUrl { get; set; }
        public bool ReplicateLists { get; set; }
        public bool ReplicateAppParts { get; set; }
        public bool ReplicateFeatures { get; set; }
    }

    public class WorkPoint365WebAPIModelFieldMappingsSettings
    {
        public WorkPoint365WebAPIModelActiveSettings ActiveSettings { get; set; }
        public WorkPoint365WebAPIModelCommonFieldMappingsSettings CommonFieldMappingsSettings { get; set; }
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

    public class WorkPoint365WebAPIModelActiveSettings
    {
        public string FieldName { get; set; }
        public string[] ActiveValues { get; set; }
    }

    public class WorkPoint365WebAPIModelCommonFieldMappingsSettings
    {
        public WorkPoint365WebAPIModelCommonFieldMapping[] Mappings { get; set; }
    }

    public class WorkPoint365WebAPIModelCommonFieldMapping
    {
        public string CommonFieldName { get; set; }
        public string MappedFieldName { get; set; }
    }

    public class WorkPoint365WebAPIModelClientSettings
    {
        public bool CachingDisabled { get; set; }
        public string[] FieldsInSearchResult { get; set; }
        public WorkPoint365WebAPIModelClientSettingsSearchableField[] SearchableFields { get; set; }
        public WorkPoint365WebAPIModelClientSettingsSearchableField[] AdvancedSearchableFields { get; set; }
        public WorkPoint365WebAPIModelClientSettingsMobileField[] MobileFields { get; set; }
        public WorkPoint365WebAPIModelClientSettingsCommonFieldName[] CommonFieldNames { get; set; }
        public string[] FieldsInFavoriteName { get; set; }
    }

    public class WorkPoint365WebAPIModelClientSettingsSearchableField
    {
        public string InternalName { get; set; }
        public string Title { get; set; }
        public WorkPoint365WebAPIModelClientSettingsSearchableFieldOperatorType Operator { get; set; }
        public string CommonName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelClientSettingsSearchableFieldOperatorType
    {
        Contains,
        StartsWith,
        Equals
    }

    public class WorkPoint365WebAPIModelClientSettingsMobileField
    {
        public string InternalName { get; set; }
        public string Title { get; set; }
        public WorkPoint365WebAPIModelClientSettingsMobileFieldMobileFieldVisibilityType MobileFieldVisibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkPoint365WebAPIModelClientSettingsMobileFieldMobileFieldVisibilityType
    {
        Hide,
        ShowWithLabel,
        ShowWithoutLabel
    }

    public class WorkPoint365WebAPIModelClientSettingsCommonFieldName
    {
        public string InternalName { get; set; }
        public string CommonName { get; set; }
    }

    public class DocumentCopyDocumentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentCopyDocumentsInputModeType Mode { get; set; }

        [JsonProperty("TargetBusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetBusinessModule { get; set; }

        [JsonProperty("TargetEntityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TargetEntity { get; set; }

        [JsonProperty("TargetWebRelativListUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetList { get; set; }

        [JsonProperty("TargetFolderRelativListUrl")]
        public string TargetFolder { get; set; }

        [JsonProperty("NameConflict", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentCopyDocumentsInputNamingConflictBehaviorType NamingConflictBehavior { get; set; }
        public bool? IgnoreVersionHistory { get; set; }

        [JsonProperty("ContentTypeId")]
        public string ContentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentCopyDocumentsInputModeType
    {
        Copy,
        Move,
        QuickCopy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentCopyDocumentsInputNamingConflictBehaviorType
    {
        Fail,
        Replace,
        Rename
    }

    public class WorkPoint365WebAPIModelProcessContextItemOutPutResult
    {
        public WorkPoint365WebAPIModelProcessContextItemOutPutViewModel[] Result { get; set; }
        public WorkPoint365WebAPIModelProcessContextItemOutPutViewModelWorkPoint365WebAPIModelSerializableExceptionResultEventReference[] Errors { get; set; }
        public WorkPoint365WebAPIModelProcessContextItemOutPutViewModelSystemStringResultEventReference[] Warnings { get; set; }
        public string SignalRIdentifier { get; set; }
        public string SignalRUrl { get; set; }
    }

    public class WorkPoint365WebAPIModelProcessContextItemOutPutViewModel
    {
        public string WebUrl { get; set; }
        public string List { get; set; }

        [JsonProperty("ID")]
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class WorkPoint365WebAPIModelProcessContextItemOutPutViewModelWorkPoint365WebAPIModelSerializableExceptionResultEventReference
    {
        public WorkPoint365WebAPIModelProcessContextItemOutPutViewModel Reference { get; set; }
        public WorkPoint365WebAPIModelSerializableException Event { get; set; }
    }

    public class WorkPoint365WebAPIModelSerializableException
    {
        public string TimeStamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public JToken InnerException { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public JToken ExceptionData { get; set; }
    }

    public class WorkPoint365WebAPIModelProcessContextItemOutPutViewModelSystemStringResultEventReference
    {
        public WorkPoint365WebAPIModelProcessContextItemOutPutViewModel Reference { get; set; }
        public string Event { get; set; }
    }

    public class DocumentConvertToPDFInput
    {
        [JsonProperty("TargetBusinessModule", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationBusinessModule { get; set; }

        [JsonProperty("TargetBusinessModuleEntity", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DestinationEntity { get; set; }

        [JsonProperty("TargetList", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationLibrary { get; set; }

        [JsonProperty("TargetFolder")]
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentConvertToPDFInputOutputExistsBehaviourType OutputExistsBehaviour { get; set; }

        [JsonProperty("PdfFormat", DefaultValueHandling = DefaultValueHandling.Include)]
        public DocumentConvertToPDFInputPDFFormatType PDFFormat { get; set; }

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
        public DocumentConvertToPDFInputVersionType? Version { get; set; }
        public bool? Async { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
        public JToken CallbackHeaders { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPDFInputOutputExistsBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPDFInputPDFFormatType
    {
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
        PDFUA1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPDFInputVersionType
    {
        LatestVersion,
        LatestMajorVersion
    }

    public class DocumentConvertToPdfAndSaveOutputInput
    {
        [JsonProperty("DocumentSiteUrl")]
        public string DocumentSiteURL { get; set; }

        [JsonProperty("DocumentUrl")]
        public string DocumentURL { get; set; }

        [JsonProperty("OutputSiteUrl")]
        public string OutputSiteURL { get; set; }

        [JsonProperty("OutputUrl")]
        public string OutputURL { get; set; }
        public DocumentConvertToPdfAndSaveOutputInputOutputExistsBehaviourType? OutputExistsBehaviour { get; set; }

        [JsonProperty("PdfFormat")]
        public DocumentConvertToPdfAndSaveOutputInputPDFFormatType? PDFFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfAndSaveOutputInputOutputExistsBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentConvertToPdfAndSaveOutputInputPDFFormatType
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
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public DocumentDigitalSignatureCreateLogEntryForTransactionInputSigningProviderType? SigningProvider { get; set; }
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
        public WorkPoint365WebAPIModelDocumentDigitalSignatureError[] Errors { get; set; }
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
        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }

        [JsonProperty("DocumentSiteUrl")]
        public string DocumentSiteURL { get; set; }

        [JsonProperty("DocumentUrl")]
        public string DocumentURL { get; set; }
        public DocumentDigitalSignatureAddDocumentToTransactionInputSigningSetPropertiesBehaviourType? SigningSetPropertiesBehaviour { get; set; }
        public DocumentDigitalSignatureAddDocumentToTransactionInputSigningDeclareAsRecordBehaviourType? SigningDeclareAsRecordBehaviour { get; set; }
        public DocumentDigitalSignatureAddDocumentToTransactionInputSigningTypeType? SigningType { get; set; }

        [JsonProperty("PdfFormat")]
        public DocumentDigitalSignatureAddDocumentToTransactionInputPDFFormatType? PDFFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputSigningSetPropertiesBehaviourType
    {
        IgnoreErrors,
        ReturnOnErrors
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputSigningDeclareAsRecordBehaviourType
    {
        DoNotDeclare,
        DeclareOriginalDocument,
        DeclarePdf,
        DeclareOriginalDocumentAndPdf,
        DeclareAppendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputSigningTypeType
    {
        StandardSigning,
        Appendix
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureAddDocumentToTransactionInputPDFFormatType
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
        [JsonProperty("SignedPdfBytes")]
        public string SignedPDFBytes { get; set; }

        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string FileName { get; set; }

        [JsonProperty("SigningStatus")]
        public DocumentDigitalSignatureCompleteDocumentInTransactionInputSignedStatusType? SignedStatus { get; set; }
        public string Message { get; set; }
        public bool? UndeclareOriginalDocumentOrAppendixFileAsRecord { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureCompleteDocumentInTransactionInputSignedStatusType
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
        [JsonProperty("SignedPdfBase64String")]
        public string SignedPDFBase64String { get; set; }

        [JsonProperty("TransactionID")]
        public string TransactionId { get; set; }
        public string FileName { get; set; }

        [JsonProperty("SigningStatus")]
        public DocumentDigitalSignatureBase64CompleteDocumentInTransactionInputSignedStatusType? SignedStatus { get; set; }
        public string Message { get; set; }
        public bool? UndeclareOriginalDocumentOrAppendixFileAsRecord { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentDigitalSignatureBase64CompleteDocumentInTransactionInputSignedStatusType
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
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CompressToZIPFileInput
    {
        [JsonProperty("BusinessModuleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationBusinessModule { get; set; }

        [JsonProperty("EntityId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DestinationEntity { get; set; }

        [JsonProperty("List", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationLibrary { get; set; }

        [JsonProperty("Folder")]
        public string DestinationFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CompressToZIPFileInputOutputExistsBehaviourType OutputExistsBehaviour { get; set; }
        public bool? AddIndex { get; set; }
        public bool? AddSourceInformation { get; set; }

        [JsonProperty("FieldValues")]
        public JToken Fields { get; set; }
        public bool? Async { get; set; }
        public JToken CallbackHeaders { get; set; }
        public string CallbackUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CompressToZIPFileInputOutputExistsBehaviourType
    {
        Cancel,
        Overwrite,
        Rename
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum overrideConstraintsInput
    {
        NoOverride,
        OverrideWarnings,
        OverrideErrors,
        OverrideWarningsAndErrors
    }

    public class EntityActivityLogAddInput
    {
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
    public enum outputExistsInput
    {
        Cancel,
        Overwrite,
        Rename
    }

    public class WorkPoint365WebAPIModelMailMergeHtmlResult
    {
        public string Html { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }
        public bool Ok { get; set; }
    }

    public class WorkPoint365WebAPIModelMailMergeDocumentResult
    {
        public string Html { get; set; }
        public string Bytes { get; set; }
        public string FileName { get; set; }
        public string Subject { get; set; }
        public string[] ErrorMessages { get; set; }
        public bool Ok { get; set; }
    }

    public class WorkPoint365WebAPIModelWorkPointWebHook
    {
        public string Id { get; set; }
        public string Description { get; set; }

        [JsonProperty("IsPaused")]
        public bool ActiveState { get; set; }
        public WorkPoint365WebAPIModelWorkPointWebHookProperties Properties { get; set; }
    }

    public class WorkPoint365WebAPIModelWorkPointWebHookProperties
    {
        public string BusinessModuleId { get; set; }

        [JsonProperty("WorkPointTrigger")]
        public string TriggerId { get; set; }

        [JsonProperty("WorkPointUrl")]
        public string WorkPoint365URL { get; set; }
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