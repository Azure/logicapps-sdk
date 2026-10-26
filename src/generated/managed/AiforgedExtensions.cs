//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aiforged
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiforgedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsUserViewModel, ApiConnectionActionConfiguration> AccountGetCurrentUser(Expression<Func<string>> xApiVersion)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            return new DeferredBodyAction<AIForgedViewModelsUserViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Account/GetCurrentUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsUserViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AccountGetApiKey(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Account/GetAPIKey";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel, ApiConnectionActionConfiguration> ClassesGet(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsClassesViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Classes/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[], ApiConnectionActionConfiguration> ClassesGetByProject(Expression<Func<string>> xApiVersion, Expression<Func<int>> projectId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsClassesViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Classes/GetByProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[], ApiConnectionActionConfiguration> ClassesGetByUser(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsClassesViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Classes/GetByUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration> DocumentGetDocument(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration> DocumentGetHierarchy(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetHierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration> DocumentDelete(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/Delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[], ApiConnectionActionConfiguration> DocumentGetPreviews(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetPreviews";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[], ApiConnectionActionConfiguration> DocumentGetImages(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null, Expression<Func<int>> stpdId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentDataViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetImages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DocumentGetBlobById(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetBlobById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DocumentDeleteBlob(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/DeleteBlob";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel, ApiConnectionActionConfiguration> DocumentGetClassification(Expression<Func<string>> xApiVersion, Expression<Func<int>> stpdId = null, Expression<Func<int>> projectId = null, Expression<Func<int>> docId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsClassesViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetClassification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration> ParamDefGet(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ParamDef/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration> ParamDefGetParentService(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ParamDef/GetParentService";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration> ParamDefGetHierachy(Expression<Func<string>> xApiVersion, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null, Expression<Func<bool>> includeCount = null, Expression<Func<bool>> includeSettings = null, Expression<Func<bool>> includeChildren = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_includeCount = WorkflowExpression.Compile(includeCount, nameof(includeCount), required: false);
            var __workflow_includeSettings = WorkflowExpression.Compile(includeSettings, nameof(includeSettings), required: false);
            var __workflow_includeChildren = WorkflowExpression.Compile(includeChildren, nameof(includeChildren), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ParamDef/GetHierachy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Queries["includeCount"] = Convert.ToString(false);
                if (__workflow_includeCount != null)
                    callPayload.Queries["includeCount"] = ExpressionConverter.Convert(__workflow_includeCount);
                callPayload.Queries["includeSettings"] = Convert.ToString(true);
                if (__workflow_includeSettings != null)
                    callPayload.Queries["includeSettings"] = ExpressionConverter.Convert(__workflow_includeSettings);
                callPayload.Queries["includeChildren"] = Convert.ToString(false);
                if (__workflow_includeChildren != null)
                    callPayload.Queries["includeChildren"] = ExpressionConverter.Convert(__workflow_includeChildren);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[], ApiConnectionActionConfiguration> ParametersGet(Expression<Func<string>> xApiVersion, Expression<Func<int>> docId = null, Expression<Func<int>> stpdId = null, Expression<Func<categoryInput>> category = null, Expression<Func<groupingInput>> grouping = null, Expression<Func<bool>> includeverification = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_grouping = WorkflowExpression.Compile(grouping, nameof(grouping), required: false);
            var __workflow_includeverification = WorkflowExpression.Compile(includeverification, nameof(includeverification), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentParameterViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_grouping != null)
                    callPayload.Queries["grouping"] = ExpressionConverter.Convert(__workflow_grouping);
                callPayload.Queries["includeverification"] = Convert.ToString(true);
                if (__workflow_includeverification != null)
                    callPayload.Queries["includeverification"] = ExpressionConverter.Convert(__workflow_includeverification);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[], ApiConnectionActionConfiguration> ParametersGetHierarchy(Expression<Func<string>> xApiVersion, Expression<Func<int>> docId = null, Expression<Func<int>> stpdId = null, Expression<Func<bool>> includeverification = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_includeverification = WorkflowExpression.Compile(includeverification, nameof(includeverification), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentParameterViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/GetHierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Queries["includeverification"] = Convert.ToString(true);
                if (__workflow_includeverification != null)
                    callPayload.Queries["includeverification"] = ExpressionConverter.Convert(__workflow_includeverification);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel, ApiConnectionActionConfiguration> ParametersDelete(Expression<Func<string>> xApiVersion, Expression<Func<int>> paramid = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_paramid = WorkflowExpression.Compile(paramid, nameof(paramid), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentParameterViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/Delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_paramid != null)
                    callPayload.Queries["paramid"] = ExpressionConverter.Convert(__workflow_paramid);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel, ApiConnectionActionConfiguration> ParametersGetByVerification(Expression<Func<string>> xApiVersion, Expression<Func<int>> verificationId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_verificationId = WorkflowExpression.Compile(verificationId, nameof(verificationId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentParameterViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/GetByVerification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_verificationId != null)
                    callPayload.Queries["verificationId"] = ExpressionConverter.Convert(__workflow_verificationId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocParamSummary[], ApiConnectionActionConfiguration> ParametersGetSummary(Expression<Func<string>> xApiVersion, Expression<Func<int>> projectId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocParamSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/GetSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocParamSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentExtraction[], ApiConnectionActionConfiguration> ParametersExtract(Expression<Func<string>> xApiVersion, Expression<Func<int>> docid = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_docid = WorkflowExpression.Compile(docid, nameof(docid), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentExtraction[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Parameters/Extract";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_docid != null)
                    callPayload.Queries["docid"] = ExpressionConverter.Convert(__workflow_docid);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentExtraction[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel[], ApiConnectionActionConfiguration> ProjectGetByUser(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsProjectViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Project/GetByUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsProjectViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel, ApiConnectionActionConfiguration> ProjectGetUserProject(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsProjectViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Project/GetUserProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[], ApiConnectionActionConfiguration> ProjectGetHierachies(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null, Expression<Func<int>> groupId = null, Expression<Func<bool>> includeCount = null, Expression<Func<bool>> onlyServices = null, Expression<Func<bool>> includeSettings = null, Expression<Func<bool>> includeChildren = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            var __workflow_includeCount = WorkflowExpression.Compile(includeCount, nameof(includeCount), required: false);
            var __workflow_onlyServices = WorkflowExpression.Compile(onlyServices, nameof(onlyServices), required: false);
            var __workflow_includeSettings = WorkflowExpression.Compile(includeSettings, nameof(includeSettings), required: false);
            var __workflow_includeChildren = WorkflowExpression.Compile(includeChildren, nameof(includeChildren), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Project/GetHierachies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                if (__workflow_groupId != null)
                    callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["includeCount"] = Convert.ToString(false);
                if (__workflow_includeCount != null)
                    callPayload.Queries["includeCount"] = ExpressionConverter.Convert(__workflow_includeCount);
                callPayload.Queries["onlyServices"] = Convert.ToString(false);
                if (__workflow_onlyServices != null)
                    callPayload.Queries["onlyServices"] = ExpressionConverter.Convert(__workflow_onlyServices);
                callPayload.Queries["includeSettings"] = Convert.ToString(true);
                if (__workflow_includeSettings != null)
                    callPayload.Queries["includeSettings"] = ExpressionConverter.Convert(__workflow_includeSettings);
                callPayload.Queries["includeChildren"] = Convert.ToString(false);
                if (__workflow_includeChildren != null)
                    callPayload.Queries["includeChildren"] = ExpressionConverter.Convert(__workflow_includeChildren);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel, ApiConnectionActionConfiguration> ProjectGetByName(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<string>> projectName = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: false);
            return new DeferredBodyAction<AIForgedViewModelsProjectViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Project/GetByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectName != null)
                    callPayload.Queries["projectName"] = ExpressionConverter.Convert(__workflow_projectName);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[], ApiConnectionActionConfiguration> ProjectGetServices(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null, Expression<Func<int>> stlfilter = null, Expression<Func<string>> enginefilter = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stlfilter = WorkflowExpression.Compile(stlfilter, nameof(stlfilter), required: false);
            var __workflow_enginefilter = WorkflowExpression.Compile(enginefilter, nameof(enginefilter), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Project/GetServices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stlfilter != null)
                    callPayload.Queries["stlfilter"] = ExpressionConverter.Convert(__workflow_stlfilter);
                if (__workflow_enginefilter != null)
                    callPayload.Queries["enginefilter"] = ExpressionConverter.Convert(__workflow_enginefilter);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration> ServicesGet(Expression<Func<string>> xApiVersion, Expression<Func<int>> stpdId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsParameterDefViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Services/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SystemGetSystemDate(Expression<Func<string>> xApiVersion)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/System/GetSystemDate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SystemGetSystemInfo(Expression<Func<string>> xApiVersion)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/System/GetSystemInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDataTypeViewModel[], ApiConnectionActionConfiguration> SystemGetDataTypes(Expression<Func<string>> xApiVersion)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            return new DeferredBodyAction<AIForgedViewModelsDataTypeViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/System/GetDataTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDataTypeViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsEnumDataViewModel[], ApiConnectionActionConfiguration> SystemGetEnumData(Expression<Func<string>> xApiVersion)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            return new DeferredBodyAction<AIForgedViewModelsEnumDataViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/System/GetEnumData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsEnumDataViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel, ApiConnectionActionConfiguration> VerificationGet(Expression<Func<string>> xApiVersion, Expression<Func<int>> verificationId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_verificationId = WorkflowExpression.Compile(verificationId, nameof(verificationId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsVerificationViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_verificationId != null)
                    callPayload.Queries["verificationId"] = ExpressionConverter.Convert(__workflow_verificationId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel[], ApiConnectionActionConfiguration> VerificationGetAll(Expression<Func<string>> xApiVersion, Expression<Func<int>> docId = null, Expression<Func<int>> parameterId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            var __workflow_parameterId = WorkflowExpression.Compile(parameterId, nameof(parameterId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsVerificationViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                if (__workflow_parameterId != null)
                    callPayload.Queries["parameterId"] = ExpressionConverter.Convert(__workflow_parameterId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel, ApiConnectionActionConfiguration> VerificationGetLatest(Expression<Func<string>> xApiVersion, Expression<Func<int>> docId = null, Expression<Func<int>> parameterId = null, Expression<Func<int>> pdId = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            var __workflow_parameterId = WorkflowExpression.Compile(parameterId, nameof(parameterId), required: false);
            var __workflow_pdId = WorkflowExpression.Compile(pdId, nameof(pdId), required: false);
            return new DeferredBodyAction<AIForgedViewModelsVerificationViewModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/GetLatest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                if (__workflow_parameterId != null)
                    callPayload.Queries["parameterId"] = ExpressionConverter.Convert(__workflow_parameterId);
                if (__workflow_pdId != null)
                    callPayload.Queries["pdId"] = ExpressionConverter.Convert(__workflow_pdId);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> VerificationGetShred(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> docId = null, Expression<Func<int>> parId = null, Expression<Func<int>> verificationId = null, Expression<Func<bool>> inline = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: false);
            var __workflow_parId = WorkflowExpression.Compile(parId, nameof(parId), required: false);
            var __workflow_verificationId = WorkflowExpression.Compile(verificationId, nameof(verificationId), required: false);
            var __workflow_inline = WorkflowExpression.Compile(inline, nameof(inline), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/GetShred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_docId != null)
                    callPayload.Queries["docId"] = ExpressionConverter.Convert(__workflow_docId);
                if (__workflow_parId != null)
                    callPayload.Queries["parId"] = ExpressionConverter.Convert(__workflow_parId);
                if (__workflow_verificationId != null)
                    callPayload.Queries["verificationId"] = ExpressionConverter.Convert(__workflow_verificationId);
                callPayload.Queries["inline"] = Convert.ToString(false);
                if (__workflow_inline != null)
                    callPayload.Queries["inline"] = ExpressionConverter.Convert(__workflow_inline);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[], ApiConnectionActionConfiguration> VerificationGetSummary(Expression<Func<string>> xApiVersion, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null, Expression<Func<int>> pdId = null, Expression<Func<bool>> latestOnly = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_pdId = WorkflowExpression.Compile(pdId, nameof(pdId), required: false);
            var __workflow_latestOnly = WorkflowExpression.Compile(latestOnly, nameof(latestOnly), required: false);
            return new DeferredBodyAction<AIForgedViewModelsVerificationSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/GetSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                if (__workflow_pdId != null)
                    callPayload.Queries["pdId"] = ExpressionConverter.Convert(__workflow_pdId);
                callPayload.Queries["latestOnly"] = Convert.ToString(true);
                if (__workflow_latestOnly != null)
                    callPayload.Queries["latestOnly"] = ExpressionConverter.Convert(__workflow_latestOnly);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[], ApiConnectionActionConfiguration> VerificationGetHeatmap(Expression<Func<string>> xApiVersion, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null, Expression<Func<bool>> latestOnly = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_latestOnly = WorkflowExpression.Compile(latestOnly, nameof(latestOnly), required: false);
            return new DeferredBodyAction<AIForgedViewModelsVerificationSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Verification/GetHeatmap";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                callPayload.Queries["latestOnly"] = Convert.ToString(true);
                if (__workflow_latestOnly != null)
                    callPayload.Queries["latestOnly"] = ExpressionConverter.Convert(__workflow_latestOnly);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DocumentGetBlob(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> id = null, Expression<Func<typeInput>> type = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetBlob";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[], ApiConnectionActionConfiguration> DocumentGetData(Expression<Func<string>> xApiVersion, Expression<Func<int>> id = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> contentType = null, Expression<Func<string>> text = null, Expression<Func<int>> blobid = null, Expression<Func<int>> pageindex = null, Expression<Func<int>> imagesCount = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_text = WorkflowExpression.Compile(text, nameof(text), required: false);
            var __workflow_blobid = WorkflowExpression.Compile(blobid, nameof(blobid), required: false);
            var __workflow_pageindex = WorkflowExpression.Compile(pageindex, nameof(pageindex), required: false);
            var __workflow_imagesCount = WorkflowExpression.Compile(imagesCount, nameof(imagesCount), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentDataViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_contentType != null)
                    callPayload.Queries["contentType"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(__workflow_text);
                if (__workflow_blobid != null)
                    callPayload.Queries["blobid"] = ExpressionConverter.Convert(__workflow_blobid);
                if (__workflow_pageindex != null)
                    callPayload.Queries["pageindex"] = ExpressionConverter.Convert(__workflow_pageindex);
                if (__workflow_imagesCount != null)
                    callPayload.Queries["imagesCount"] = ExpressionConverter.Convert(__workflow_imagesCount);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[], ApiConnectionActionConfiguration> DocumentGetExtended(Expression<Func<string>> xApiVersion, Expression<Func<string>> userId = null, Expression<Func<int>> projectId = null, Expression<Func<int>> stpdId = null, Expression<Func<usageInput>> usage = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> classname = null, Expression<Func<string>> filename = null, Expression<Func<string>> filetype = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<int>> masterid = null, Expression<Func<int>> pageNo = null, Expression<Func<int>> pageSize = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortDirectionInput>> sortDirection = null, Expression<Func<string>> comment = null, Expression<Func<string>> result = null, Expression<Func<string>> resultId = null, Expression<Func<int>> resultIndex = null, Expression<Func<string>> externalId = null, Expression<Func<string>> docGuid = null)
        {
            var __workflow_xApiVersion = WorkflowExpression.Compile(xApiVersion, nameof(xApiVersion), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: false);
            var __workflow_stpdId = WorkflowExpression.Compile(stpdId, nameof(stpdId), required: false);
            var __workflow_usage = WorkflowExpression.Compile(usage, nameof(usage), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_classname = WorkflowExpression.Compile(classname, nameof(classname), required: false);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: false);
            var __workflow_filetype = WorkflowExpression.Compile(filetype, nameof(filetype), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_masterid = WorkflowExpression.Compile(masterid, nameof(masterid), required: false);
            var __workflow_pageNo = WorkflowExpression.Compile(pageNo, nameof(pageNo), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortDirection = WorkflowExpression.Compile(sortDirection, nameof(sortDirection), required: false);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            var __workflow_result = WorkflowExpression.Compile(result, nameof(result), required: false);
            var __workflow_resultId = WorkflowExpression.Compile(resultId, nameof(resultId), required: false);
            var __workflow_resultIndex = WorkflowExpression.Compile(resultIndex, nameof(resultIndex), required: false);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            var __workflow_docGuid = WorkflowExpression.Compile(docGuid, nameof(docGuid), required: false);
            return new DeferredBodyAction<AIForgedViewModelsDocumentViewModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Document/GetExtended";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                if (__workflow_projectId != null)
                    callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                if (__workflow_stpdId != null)
                    callPayload.Queries["stpdId"] = ExpressionConverter.Convert(__workflow_stpdId);
                if (__workflow_usage != null)
                    callPayload.Queries["usage"] = ExpressionConverter.Convert(__workflow_usage);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_classname != null)
                    callPayload.Queries["classname"] = ExpressionConverter.Convert(__workflow_classname);
                if (__workflow_filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                if (__workflow_filetype != null)
                    callPayload.Queries["filetype"] = ExpressionConverter.Convert(__workflow_filetype);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_masterid != null)
                    callPayload.Queries["masterid"] = ExpressionConverter.Convert(__workflow_masterid);
                if (__workflow_pageNo != null)
                    callPayload.Queries["pageNo"] = ExpressionConverter.Convert(__workflow_pageNo);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortField != null)
                    callPayload.Queries["sortField"] = ExpressionConverter.Convert(__workflow_sortField);
                if (__workflow_sortDirection != null)
                    callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(__workflow_sortDirection);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                if (__workflow_result != null)
                    callPayload.Queries["result"] = ExpressionConverter.Convert(__workflow_result);
                if (__workflow_resultId != null)
                    callPayload.Queries["resultId"] = ExpressionConverter.Convert(__workflow_resultId);
                if (__workflow_resultIndex != null)
                    callPayload.Queries["resultIndex"] = ExpressionConverter.Convert(__workflow_resultIndex);
                if (__workflow_externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                if (__workflow_docGuid != null)
                    callPayload.Queries["docGuid"] = ExpressionConverter.Convert(__workflow_docGuid);
                callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(__workflow_xApiVersion);
                return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(callPayload);
            });
        }
    }

    public class AiforgedTriggers([ConnectionName] string connectionId)
    {
    }

    public class AIForgedViewModelsUserViewModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("isLockedOut")]
        public bool IsLockedOut { get; set; }

        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public class AIForgedViewModelsClassesViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("dtm")]
        public string Dtm { get; set; }

        [JsonProperty("type")]
        public AIForgedDALClassType Type { get; set; }

        [JsonProperty("related")]
        public int Related { get; set; }
    }

    public enum AIForgedDALClassType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class AIForgedViewModelsDocumentViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("status")]
        public AIForgedDALDocumentStatus Status { get; set; }

        [JsonProperty("usage")]
        public AIForgedDALUsageType Usage { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("dtm")]
        public string Dtm { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("masterId")]
        public int MasterId { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("resultId")]
        public string ResultId { get; set; }

        [JsonProperty("resultIndex")]
        public int ResultIndex { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("availability")]
        public AIForgedDALAvailability Availability { get; set; }

        [JsonProperty("resultParameters")]
        public AIForgedViewModelsDocumentParameterViewModel[] ResultParameters { get; set; }

        [JsonProperty("data")]
        public AIForgedViewModelsDocumentDataViewModel[] Data { get; set; }

        [JsonProperty("documents")]
        public AIForgedViewModelsDocumentViewModel[] Documents { get; set; }

        [JsonProperty("originId")]
        public int OriginId { get; set; }

        [JsonProperty("canVerify")]
        public bool CanVerify { get; set; }

        [JsonProperty("canClassify")]
        public bool CanClassify { get; set; }

        [JsonProperty("canTrain")]
        public bool CanTrain { get; set; }

        [JsonProperty("trained")]
        public bool Trained { get; set; }

        [JsonProperty("linkedDocsCount")]
        public int LinkedDocsCount { get; set; }

        [JsonProperty("trainingFieldCount")]
        public int TrainingFieldCount { get; set; }

        [JsonProperty("trainedParametersCount")]
        public int TrainedParametersCount { get; set; }
    }

    public enum AIForgedDALDocumentStatus
    {
        _0 = 0,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _81 = 81,
        _90 = 90,
        _98 = 98,
        _99 = 99,
        _103 = 103,
        _108 = 108,
        _109 = 109,
        _110 = 110,
        _190 = 190
    }

    public enum AIForgedDALUsageType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _10 = 10,
        _90 = 90,
        _98 = 98,
        _99 = 99
    }

    public enum AIForgedDALAvailability
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _9 = 9,
        _99 = 99
    }

    public class AIForgedViewModelsDocumentParameterViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("paramDefId")]
        public int ParamDefId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("sourceId")]
        public int SourceId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("colIndex")]
        public int ColIndex { get; set; }

        [JsonProperty("colSpan")]
        public int ColSpan { get; set; }

        [JsonProperty("rowIndex")]
        public int RowIndex { get; set; }

        [JsonProperty("rowSpan")]
        public int RowSpan { get; set; }

        [JsonProperty("availability")]
        public AIForgedDALAvailability Availability { get; set; }

        [JsonProperty("paramDef")]
        public JToken ParamDef { get; set; }

        [JsonProperty("children")]
        public AIForgedViewModelsDocumentParameterViewModel[] Children { get; set; }

        [JsonProperty("verifications")]
        public AIForgedViewModelsVerificationViewModel[] Verifications { get; set; }
    }

    public class AIForgedViewModelsVerificationViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parameterId")]
        public int ParameterId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("symbolsConfidence")]
        public string SymbolsConfidence { get; set; }

        [JsonProperty("type")]
        public AIForgedDALVerificationType Type { get; set; }

        [JsonProperty("status")]
        public AIForgedDALVerificationStatus Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("box")]
        public string Box { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("serviceDocId")]
        public int ServiceDocId { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("settingId")]
        public int SettingId { get; set; }

        [JsonProperty("workItem")]
        public int WorkItem { get; set; }

        [JsonProperty("transactionId")]
        public int TransactionId { get; set; }

        [JsonProperty("charge")]
        public double Charge { get; set; }
    }

    public enum AIForgedDALVerificationType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8
    }

    public enum AIForgedDALVerificationStatus
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096,
        _8192 = 8192,
        _16384 = 16384
    }

    public class AIForgedViewModelsDocumentDataViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("blobId")]
        public int BlobId { get; set; }

        [JsonProperty("type")]
        public AIForgedDALDocumentDataType Type { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("resultId")]
        public string ResultId { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("resolution")]
        public double Resolution { get; set; }

        [JsonProperty("availability")]
        public AIForgedDALAvailability Availability { get; set; }
    }

    public enum AIForgedDALDocumentDataType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _10 = 10,
        _11 = 11
    }

    public class AIForgedViewModelsParameterDefViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("serviceTypeId")]
        public int ServiceTypeId { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("dtm")]
        public string Dtm { get; set; }

        [JsonProperty("status")]
        public AIForgedDALParameterDefinitionStatus Status { get; set; }

        [JsonProperty("category")]
        public AIForgedDALParameterDefinitionCategory Category { get; set; }

        [JsonProperty("grouping")]
        public AIForgedDALGroupingType Grouping { get; set; }

        [JsonProperty("valueType")]
        public AIForgedDALValueType ValueType { get; set; }

        [JsonProperty("valueTypeName")]
        public string ValueTypeName { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("required")]
        public AIForgedDALRequiredOption Required { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("availability")]
        public AIForgedDALAvailability Availability { get; set; }

        [JsonProperty("children")]
        public AIForgedViewModelsParameterDefViewModel[] Children { get; set; }

        [JsonProperty("settings")]
        public AIForgedDALModelsParameterDefSettingViewModel[] Settings { get; set; }

        [JsonProperty("totalCharge")]
        public double TotalCharge { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("parameterCount")]
        public int ParameterCount { get; set; }

        [JsonProperty("documentCount")]
        public int DocumentCount { get; set; }

        [JsonProperty("validation")]
        public string Validation { get; set; }
    }

    public enum AIForgedDALParameterDefinitionStatus
    {
        _0 = 0,
        _99 = 99
    }

    public enum AIForgedDALParameterDefinitionCategory
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _20 = 20,
        _21 = 21,
        _22 = 22,
        _40 = 40
    }

    public enum AIForgedDALGroupingType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _99 = 99
    }

    public enum AIForgedDALValueType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _17 = 17,
        _18 = 18,
        _19 = 19,
        _20 = 20,
        _90 = 90,
        _91 = 91,
        _98 = 98,
        _99 = 99
    }

    public enum AIForgedDALRequiredOption
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256
    }

    public class AIForgedDALModelsParameterDefSettingViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parameterDefId")]
        public int ParameterDefId { get; set; }

        [JsonProperty("type")]
        public AIForgedDALSettingType Type { get; set; }

        [JsonProperty("status")]
        public AIForgedDALSettingStatus Status { get; set; }

        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("dtm")]
        public string Dtm { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("minValue")]
        public string MinValue { get; set; }

        [JsonProperty("maxValue")]
        public string MaxValue { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("minConfidence")]
        public double MinConfidence { get; set; }

        [JsonProperty("maxConfidence")]
        public double MaxConfidence { get; set; }

        [JsonProperty("isCaseSensative")]
        public bool IsCaseSensative { get; set; }

        [JsonProperty("invert")]
        public bool Invert { get; set; }

        [JsonProperty("oneLine")]
        public bool OneLine { get; set; }

        [JsonProperty("oneWord")]
        public bool OneWord { get; set; }

        [JsonProperty("isHandwriting")]
        public bool IsHandwriting { get; set; }

        [JsonProperty("orientation")]
        public AIForgedDALOrientation Orientation { get; set; }

        [JsonProperty("marking")]
        public AIForgedDALMarkingType Marking { get; set; }

        [JsonProperty("cells")]
        public int Cells { get; set; }

        [JsonProperty("clearBefore")]
        public AIForgedDALOptionStatusFlags ClearBefore { get; set; }

        [JsonProperty("clearAfter")]
        public AIForgedDALOptionStatusFlags ClearAfter { get; set; }

        [JsonProperty("cleanupValuesBefore")]
        public bool CleanupValuesBefore { get; set; }

        [JsonProperty("cleanupValuesAfter")]
        public bool CleanupValuesAfter { get; set; }

        [JsonProperty("validateValuesBefore")]
        public bool ValidateValuesBefore { get; set; }

        [JsonProperty("validateValuesAfter")]
        public bool ValidateValuesAfter { get; set; }

        [JsonProperty("abortOnValidationError")]
        public bool AbortOnValidationError { get; set; }

        [JsonProperty("isReplacementCaseSensative")]
        public bool IsReplacementCaseSensative { get; set; }

        [JsonProperty("compileResults")]
        public string CompileResults { get; set; }

        [JsonProperty("maxRetry")]
        public int MaxRetry { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public enum AIForgedDALSettingType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _9 = 9,
        _10 = 10
    }

    public enum AIForgedDALSettingStatus
    {
        _0 = 0,
        _1 = 1,
        _99 = 99
    }

    public enum AIForgedDALOrientation
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum AIForgedDALMarkingType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _8 = 8
    }

    public enum AIForgedDALOptionStatusFlags
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512,
        _1024 = 1024
    }

    public enum categoryInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7,
        _20 = 20,
        _21 = 21,
        _22 = 22,
        _40 = 40
    }

    public enum groupingInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _7 = 7,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _99 = 99
    }

    public class AIForgedViewModelsDocParamSummary
    {
        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("serviceType")]
        public int ServiceType { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("usage")]
        public AIForgedDALUsageType Usage { get; set; }

        [JsonProperty("status")]
        public AIForgedDALDocumentStatus Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("labelledCount")]
        public int LabelledCount { get; set; }

        [JsonProperty("pdId")]
        public int PdId { get; set; }

        [JsonProperty("paramDefName")]
        public string ParamDefName { get; set; }

        [JsonProperty("category")]
        public AIForgedDALParameterDefinitionCategory Category { get; set; }

        [JsonProperty("grouping")]
        public AIForgedDALGroupingType Grouping { get; set; }

        [JsonProperty("valueType")]
        public AIForgedDALValueType ValueType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class AIForgedViewModelsDocumentExtraction
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("category")]
        public AIForgedDALParameterDefinitionCategory Category { get; set; }

        [JsonProperty("grouping")]
        public AIForgedDALGroupingType Grouping { get; set; }

        [JsonProperty("valueType")]
        public AIForgedDALValueType ValueType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("paramId")]
        public int ParamId { get; set; }

        [JsonProperty("parentParamId")]
        public int ParentParamId { get; set; }

        [JsonProperty("paramIndex")]
        public int ParamIndex { get; set; }

        [JsonProperty("paramValue")]
        public string ParamValue { get; set; }

        [JsonProperty("verificationId")]
        public int VerificationId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("type")]
        public AIForgedDALVerificationType Type { get; set; }

        [JsonProperty("status")]
        public AIForgedDALVerificationStatus Status { get; set; }

        [JsonProperty("charge")]
        public double Charge { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class AIForgedViewModelsProjectViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("status")]
        public AIForgedDALProjectStatus Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("dtc")]
        public string Dtc { get; set; }

        [JsonProperty("dtm")]
        public string Dtm { get; set; }

        [JsonProperty("balance")]
        public JToken Balance { get; set; }

        [JsonProperty("totalDocsCount")]
        public int TotalDocsCount { get; set; }

        [JsonProperty("services")]
        public AIForgedViewModelsParameterDefViewModel[] Services { get; set; }
    }

    public enum AIForgedDALProjectStatus
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _10 = 10,
        _11 = 11,
        _20 = 20,
        _90 = 90,
        _99 = 99
    }

    public class AIForgedViewModelsDataTypeViewModel
    {
        [JsonProperty("id")]
        public AIForgedDALValueType Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public AIForgedDALDataTypeCategory Category { get; set; }

        [JsonProperty("valueTypeName")]
        public string ValueTypeName { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public enum AIForgedDALDataTypeCategory
    {
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _8 = 8,
        _16 = 16,
        _32 = 32,
        _64 = 64,
        _128 = 128,
        _256 = 256,
        _512 = 512
    }

    public class AIForgedViewModelsEnumDataViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public AIForgedDALEnumType Type { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public enum AIForgedDALEnumType
    {
        _0 = 0,
        _1 = 1,
        _10 = 10,
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _16 = 16,
        _17 = 17,
        _18 = 18,
        _19 = 19,
        _21 = 21,
        _22 = 22,
        _24 = 24,
        _26 = 26,
        _27 = 27,
        _29 = 29,
        _30 = 30,
        _31 = 31,
        _35 = 35,
        _41 = 41,
        _50 = 50,
        _51 = 51,
        _52 = 52,
        _55 = 55,
        _60 = 60,
        _61 = 61,
        _62 = 62,
        _63 = 63,
        _70 = 70,
        _71 = 71,
        _72 = 72,
        _80 = 80,
        _81 = 81,
        _85 = 85,
        _86 = 86,
        _90 = 90,
        _91 = 91,
        _92 = 92,
        _95 = 95,
        _96 = 96,
        _100 = 100,
        _101 = 101,
        _110 = 110,
        _200 = 200,
        _201 = 201,
        _1000 = 1000,
        _1001 = 1001,
        _2000 = 2000,
        _2001 = 2001
    }

    public class AIForgedViewModelsVerificationSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parameterId")]
        public int ParameterId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("symbolsConfidence")]
        public string SymbolsConfidence { get; set; }

        [JsonProperty("type")]
        public AIForgedDALVerificationType Type { get; set; }

        [JsonProperty("status")]
        public AIForgedDALVerificationStatus Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("box")]
        public string Box { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("serviceDocId")]
        public int ServiceDocId { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("settingId")]
        public int SettingId { get; set; }

        [JsonProperty("workItem")]
        public int WorkItem { get; set; }

        [JsonProperty("transactionId")]
        public int TransactionId { get; set; }

        [JsonProperty("charge")]
        public double Charge { get; set; }

        [JsonProperty("paramDefId")]
        public int ParamDefId { get; set; }

        [JsonProperty("paramDefName")]
        public string ParamDefName { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("docId")]
        public int DocId { get; set; }

        [JsonProperty("docFileName")]
        public string DocFileName { get; set; }

        [JsonProperty("docContentType")]
        public string DocContentType { get; set; }

        [JsonProperty("docUsage")]
        public AIForgedDALUsageType DocUsage { get; set; }

        [JsonProperty("docStatus")]
        public AIForgedDALDocumentStatus DocStatus { get; set; }

        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("dayOfWeek")]
        public SystemDayOfWeek DayOfWeek { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("average")]
        public double Average { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }
    }

    public enum SystemDayOfWeek
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public enum typeInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _10 = 10,
        _11 = 11
    }

    public enum usageInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _10 = 10,
        _90 = 90,
        _98 = 98,
        _99 = 99
    }

    public enum statusInput
    {
        _0 = 0,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _8 = 8,
        _9 = 9,
        _10 = 10,
        _81 = 81,
        _90 = 90,
        _98 = 98,
        _99 = 99,
        _103 = 103,
        _108 = 108,
        _109 = 109,
        _110 = 110,
        _190 = 190
    }

    public enum sortFieldInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public enum sortDirectionInput
    {
        _0 = 0,
        _1 = 1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aiforged;

    public partial class WorkflowManagedActions
    {
        public AiforgedActions Aiforged(string connectionId) => new AiforgedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AiforgedTriggers Aiforged(string connectionId) => new AiforgedTriggers(connectionId);
    }
}