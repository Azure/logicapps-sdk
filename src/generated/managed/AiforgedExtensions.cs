//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aiforged
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiforgedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsUserViewModel> AccountGetCurrentUser([WorkflowExpression] Func<string> xApiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Account/GetCurrentUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsUserViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string> AccountGetApiKey([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Account/GetAPIKey";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel> ClassesGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Classes/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[]> ClassesGetByProject([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Classes/GetByProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[]> ClassesGetByUser([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Classes/GetByUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentGetDocument([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentGetHierarchy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetHierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentDelete([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/Delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[]> DocumentGetPreviews([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetPreviews";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[]> DocumentGetImages([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<int> stpdId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetImages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentGetBlobById([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetBlobById";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentDeleteBlob([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/DeleteBlob";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel> DocumentGetClassification([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> docId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetClassification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ParamDef/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGetParentService([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ParamDef/GetParentService";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGetHierachy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> includeCount = null, [WorkflowExpression] Func<bool> includeSettings = null, [WorkflowExpression] Func<bool> includeChildren = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ParamDef/GetHierachy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Queries["includeCount"] = Convert.ToString(false);
                if (includeCount != null)
                    callPayload.Queries["includeCount"] = SourceExpressionConverter.ConvertO(includeCount);
                callPayload.Queries["includeSettings"] = Convert.ToString(true);
                if (includeSettings != null)
                    callPayload.Queries["includeSettings"] = SourceExpressionConverter.ConvertO(includeSettings);
                callPayload.Queries["includeChildren"] = Convert.ToString(false);
                if (includeChildren != null)
                    callPayload.Queries["includeChildren"] = SourceExpressionConverter.ConvertO(includeChildren);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[]> ParametersGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<categoryInput> category = null, [WorkflowExpression] Func<groupingInput> grouping = null, [WorkflowExpression] Func<bool> includeverification = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.Convert(category);
                if (grouping != null)
                    callPayload.Queries["grouping"] = SourceExpressionConverter.Convert(grouping);
                callPayload.Queries["includeverification"] = Convert.ToString(true);
                if (includeverification != null)
                    callPayload.Queries["includeverification"] = SourceExpressionConverter.ConvertO(includeverification);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[]> ParametersGetHierarchy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> includeverification = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/GetHierarchy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Queries["includeverification"] = Convert.ToString(true);
                if (includeverification != null)
                    callPayload.Queries["includeverification"] = SourceExpressionConverter.ConvertO(includeverification);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel> ParametersDelete([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> paramid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/Delete";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (paramid != null)
                    callPayload.Queries["paramid"] = SourceExpressionConverter.ConvertO(paramid);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel> ParametersGetByVerification([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> verificationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/GetByVerification";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (verificationId != null)
                    callPayload.Queries["verificationId"] = SourceExpressionConverter.ConvertO(verificationId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocParamSummary[]> ParametersGetSummary([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/GetSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocParamSummary[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentExtraction[]> ParametersExtract([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Parameters/Extract";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (docid != null)
                    callPayload.Queries["docid"] = SourceExpressionConverter.ConvertO(docid);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentExtraction[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel[]> ProjectGetByUser([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Project/GetByUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel> ProjectGetUserProject([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Project/GetUserProject";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[]> ProjectGetHierachies([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> groupId = null, [WorkflowExpression] Func<bool> includeCount = null, [WorkflowExpression] Func<bool> onlyServices = null, [WorkflowExpression] Func<bool> includeSettings = null, [WorkflowExpression] Func<bool> includeChildren = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Project/GetHierachies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                if (groupId != null)
                    callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                callPayload.Queries["includeCount"] = Convert.ToString(false);
                if (includeCount != null)
                    callPayload.Queries["includeCount"] = SourceExpressionConverter.ConvertO(includeCount);
                callPayload.Queries["onlyServices"] = Convert.ToString(false);
                if (onlyServices != null)
                    callPayload.Queries["onlyServices"] = SourceExpressionConverter.ConvertO(onlyServices);
                callPayload.Queries["includeSettings"] = Convert.ToString(true);
                if (includeSettings != null)
                    callPayload.Queries["includeSettings"] = SourceExpressionConverter.ConvertO(includeSettings);
                callPayload.Queries["includeChildren"] = Convert.ToString(false);
                if (includeChildren != null)
                    callPayload.Queries["includeChildren"] = SourceExpressionConverter.ConvertO(includeChildren);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel> ProjectGetByName([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<string> projectName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Project/GetByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectName != null)
                    callPayload.Queries["projectName"] = SourceExpressionConverter.ConvertO(projectName);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[]> ProjectGetServices([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stlfilter = null, [WorkflowExpression] Func<string> enginefilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Project/GetServices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stlfilter != null)
                    callPayload.Queries["stlfilter"] = SourceExpressionConverter.ConvertO(stlfilter);
                if (enginefilter != null)
                    callPayload.Queries["enginefilter"] = SourceExpressionConverter.ConvertO(enginefilter);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ServicesGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Services/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string> SystemGetSystemDate([WorkflowExpression] Func<string> xApiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/System/GetSystemDate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<JToken> SystemGetSystemInfo([WorkflowExpression] Func<string> xApiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/System/GetSystemInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDataTypeViewModel[]> SystemGetDataTypes([WorkflowExpression] Func<string> xApiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/System/GetDataTypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDataTypeViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsEnumDataViewModel[]> SystemGetEnumData([WorkflowExpression] Func<string> xApiVersion)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/System/GetEnumData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsEnumDataViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel> VerificationGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> verificationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/Get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (verificationId != null)
                    callPayload.Queries["verificationId"] = SourceExpressionConverter.ConvertO(verificationId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel[]> VerificationGetAll([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parameterId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/GetAll";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                if (parameterId != null)
                    callPayload.Queries["parameterId"] = SourceExpressionConverter.ConvertO(parameterId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel> VerificationGetLatest([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parameterId = null, [WorkflowExpression] Func<int> pdId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/GetLatest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                if (parameterId != null)
                    callPayload.Queries["parameterId"] = SourceExpressionConverter.ConvertO(parameterId);
                if (pdId != null)
                    callPayload.Queries["pdId"] = SourceExpressionConverter.ConvertO(pdId);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> VerificationGetShred([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parId = null, [WorkflowExpression] Func<int> verificationId = null, [WorkflowExpression] Func<bool> inline = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/GetShred";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (docId != null)
                    callPayload.Queries["docId"] = SourceExpressionConverter.ConvertO(docId);
                if (parId != null)
                    callPayload.Queries["parId"] = SourceExpressionConverter.ConvertO(parId);
                if (verificationId != null)
                    callPayload.Queries["verificationId"] = SourceExpressionConverter.ConvertO(verificationId);
                callPayload.Queries["inline"] = Convert.ToString(false);
                if (inline != null)
                    callPayload.Queries["inline"] = SourceExpressionConverter.ConvertO(inline);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[]> VerificationGetSummary([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> pdId = null, [WorkflowExpression] Func<bool> latestOnly = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/GetSummary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                if (pdId != null)
                    callPayload.Queries["pdId"] = SourceExpressionConverter.ConvertO(pdId);
                callPayload.Queries["latestOnly"] = Convert.ToString(true);
                if (latestOnly != null)
                    callPayload.Queries["latestOnly"] = SourceExpressionConverter.ConvertO(latestOnly);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[]> VerificationGetHeatmap([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> latestOnly = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Verification/GetHeatmap";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                callPayload.Queries["latestOnly"] = Convert.ToString(true);
                if (latestOnly != null)
                    callPayload.Queries["latestOnly"] = SourceExpressionConverter.ConvertO(latestOnly);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentGetBlob([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<typeInput> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetBlob";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[]> DocumentGetData([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> blobid = null, [WorkflowExpression] Func<int> pageindex = null, [WorkflowExpression] Func<int> imagesCount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetData";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                if (contentType != null)
                    callPayload.Queries["contentType"] = SourceExpressionConverter.ConvertO(contentType);
                if (text != null)
                    callPayload.Queries["text"] = SourceExpressionConverter.ConvertO(text);
                if (blobid != null)
                    callPayload.Queries["blobid"] = SourceExpressionConverter.ConvertO(blobid);
                if (pageindex != null)
                    callPayload.Queries["pageindex"] = SourceExpressionConverter.ConvertO(pageindex);
                if (imagesCount != null)
                    callPayload.Queries["imagesCount"] = SourceExpressionConverter.ConvertO(imagesCount);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[]> DocumentGetExtended([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<usageInput> usage = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> classname = null, [WorkflowExpression] Func<string> filename = null, [WorkflowExpression] Func<string> filetype = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> masterid = null, [WorkflowExpression] Func<int> pageNo = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> result = null, [WorkflowExpression] Func<string> resultId = null, [WorkflowExpression] Func<int> resultIndex = null, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> docGuid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Document/GetExtended";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                if (projectId != null)
                    callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                if (stpdId != null)
                    callPayload.Queries["stpdId"] = SourceExpressionConverter.ConvertO(stpdId);
                if (usage != null)
                    callPayload.Queries["usage"] = SourceExpressionConverter.Convert(usage);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (classname != null)
                    callPayload.Queries["classname"] = SourceExpressionConverter.ConvertO(classname);
                if (filename != null)
                    callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                if (filetype != null)
                    callPayload.Queries["filetype"] = SourceExpressionConverter.ConvertO(filetype);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                if (masterid != null)
                    callPayload.Queries["masterid"] = SourceExpressionConverter.ConvertO(masterid);
                if (pageNo != null)
                    callPayload.Queries["pageNo"] = SourceExpressionConverter.ConvertO(pageNo);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortField != null)
                    callPayload.Queries["sortField"] = SourceExpressionConverter.Convert(sortField);
                if (sortDirection != null)
                    callPayload.Queries["sortDirection"] = SourceExpressionConverter.Convert(sortDirection);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                if (result != null)
                    callPayload.Queries["result"] = SourceExpressionConverter.ConvertO(result);
                if (resultId != null)
                    callPayload.Queries["resultId"] = SourceExpressionConverter.ConvertO(resultId);
                if (resultIndex != null)
                    callPayload.Queries["resultIndex"] = SourceExpressionConverter.ConvertO(resultIndex);
                if (externalId != null)
                    callPayload.Queries["externalId"] = SourceExpressionConverter.ConvertO(externalId);
                if (docGuid != null)
                    callPayload.Queries["docGuid"] = SourceExpressionConverter.ConvertO(docGuid);
                callPayload.Headers["X-Api-Version"] = SourceExpressionConverter.ConvertO(xApiVersion);
                return callPayload;
            }

            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(BuildSourceInput);
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