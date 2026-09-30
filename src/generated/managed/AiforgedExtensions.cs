//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aiforged
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AiforgedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsUserViewModel> AccountGetCurrentUser([WorkflowExpression] Func<string> xApiVersion)
        {
            var apiCallPath = "/api/Account/GetCurrentUser";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsUserViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string> AccountGetApiKey([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null)
        {
            var apiCallPath = "/api/Account/GetAPIKey";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel> ClassesGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Classes/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[]> ClassesGetByProject([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null)
        {
            var apiCallPath = "/api/Classes/GetByProject";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel[]> ClassesGetByUser([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null)
        {
            var apiCallPath = "/api/Classes/GetByUser";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentGetDocument([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Document/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentGetHierarchy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Document/GetHierarchy";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentDelete([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Document/Delete";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[]> DocumentGetPreviews([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null)
        {
            var apiCallPath = "/api/Document/GetPreviews";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[]> DocumentGetImages([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<int> stpdId = null)
        {
            var apiCallPath = "/api/Document/GetImages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentGetBlobById([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Document/GetBlobById";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentDeleteBlob([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/Document/DeleteBlob";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentClassify([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<object> file = null)
        {
            var apiCallPath = "/api/Document/Classify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel> DocumentExtractAndVerify([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<object> file = null)
        {
            var apiCallPath = "/api/Document/ExtractAndVerify";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsClassesViewModel> DocumentGetClassification([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> docId = null)
        {
            var apiCallPath = "/api/Document/GetClassification";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsClassesViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/ParamDef/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGetParentService([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null)
        {
            var apiCallPath = "/api/ParamDef/GetParentService";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ParamDefGetHierachy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> includeCount = null, [WorkflowExpression] Func<bool> includeSettings = null, [WorkflowExpression] Func<bool> includeChildren = null)
        {
            var apiCallPath = "/api/ParamDef/GetHierachy";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Queries["includeCount"] = Convert.ToString(false);
            if (includeCount != null)
                callPayload.Queries["includeCount"] = ExpressionConverter.Convert(includeCount);
            callPayload.Queries["includeSettings"] = Convert.ToString(true);
            if (includeSettings != null)
                callPayload.Queries["includeSettings"] = ExpressionConverter.Convert(includeSettings);
            callPayload.Queries["includeChildren"] = Convert.ToString(false);
            if (includeChildren != null)
                callPayload.Queries["includeChildren"] = ExpressionConverter.Convert(includeChildren);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[]> ParametersGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<categoryInput> category = null, [WorkflowExpression] Func<groupingInput> grouping = null, [WorkflowExpression] Func<bool> includeverification = null)
        {
            var apiCallPath = "/api/Parameters/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (category != null)
                callPayload.Queries["category"] = ExpressionConverter.Convert(category);
            if (grouping != null)
                callPayload.Queries["grouping"] = ExpressionConverter.Convert(grouping);
            callPayload.Queries["includeverification"] = Convert.ToString(true);
            if (includeverification != null)
                callPayload.Queries["includeverification"] = ExpressionConverter.Convert(includeverification);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel[]> ParametersGetHierarchy([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> includeverification = null)
        {
            var apiCallPath = "/api/Parameters/GetHierarchy";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Queries["includeverification"] = Convert.ToString(true);
            if (includeverification != null)
                callPayload.Queries["includeverification"] = ExpressionConverter.Convert(includeverification);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel> ParametersDelete([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> paramid = null)
        {
            var apiCallPath = "/api/Parameters/Delete";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (paramid != null)
                callPayload.Queries["paramid"] = ExpressionConverter.Convert(paramid);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentParameterViewModel> ParametersGetByVerification([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> verificationId = null)
        {
            var apiCallPath = "/api/Parameters/GetByVerification";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (verificationId != null)
                callPayload.Queries["verificationId"] = ExpressionConverter.Convert(verificationId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentParameterViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocParamSummary[]> ParametersGetSummary([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null)
        {
            var apiCallPath = "/api/Parameters/GetSummary";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocParamSummary[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentExtraction[]> ParametersExtract([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docid = null)
        {
            var apiCallPath = "/api/Parameters/Extract";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (docid != null)
                callPayload.Queries["docid"] = ExpressionConverter.Convert(docid);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentExtraction[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel[]> ProjectGetByUser([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null)
        {
            var apiCallPath = "/api/Project/GetByUser";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel> ProjectGetUserProject([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null)
        {
            var apiCallPath = "/api/Project/GetUserProject";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[]> ProjectGetHierachies([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> groupId = null, [WorkflowExpression] Func<bool> includeCount = null, [WorkflowExpression] Func<bool> onlyServices = null, [WorkflowExpression] Func<bool> includeSettings = null, [WorkflowExpression] Func<bool> includeChildren = null)
        {
            var apiCallPath = "/api/Project/GetHierachies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (groupId != null)
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
            callPayload.Queries["includeCount"] = Convert.ToString(false);
            if (includeCount != null)
                callPayload.Queries["includeCount"] = ExpressionConverter.Convert(includeCount);
            callPayload.Queries["onlyServices"] = Convert.ToString(false);
            if (onlyServices != null)
                callPayload.Queries["onlyServices"] = ExpressionConverter.Convert(onlyServices);
            callPayload.Queries["includeSettings"] = Convert.ToString(true);
            if (includeSettings != null)
                callPayload.Queries["includeSettings"] = ExpressionConverter.Convert(includeSettings);
            callPayload.Queries["includeChildren"] = Convert.ToString(false);
            if (includeChildren != null)
                callPayload.Queries["includeChildren"] = ExpressionConverter.Convert(includeChildren);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsProjectViewModel> ProjectGetByName([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<string> projectName = null)
        {
            var apiCallPath = "/api/Project/GetByName";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectName != null)
                callPayload.Queries["projectName"] = ExpressionConverter.Convert(projectName);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsProjectViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel[]> ProjectGetServices([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stlfilter = null, [WorkflowExpression] Func<string> enginefilter = null)
        {
            var apiCallPath = "/api/Project/GetServices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stlfilter != null)
                callPayload.Queries["stlfilter"] = ExpressionConverter.Convert(stlfilter);
            if (enginefilter != null)
                callPayload.Queries["enginefilter"] = ExpressionConverter.Convert(enginefilter);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsParameterDefViewModel> ServicesGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> stpdId = null)
        {
            var apiCallPath = "/api/Services/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsParameterDefViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<string> SystemGetSystemDate([WorkflowExpression] Func<string> xApiVersion)
        {
            var apiCallPath = "/api/System/GetSystemDate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<JToken> SystemGetSystemInfo([WorkflowExpression] Func<string> xApiVersion)
        {
            var apiCallPath = "/api/System/GetSystemInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDataTypeViewModel[]> SystemGetDataTypes([WorkflowExpression] Func<string> xApiVersion)
        {
            var apiCallPath = "/api/System/GetDataTypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDataTypeViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsEnumDataViewModel[]> SystemGetEnumData([WorkflowExpression] Func<string> xApiVersion)
        {
            var apiCallPath = "/api/System/GetEnumData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsEnumDataViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel> VerificationGet([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> verificationId = null)
        {
            var apiCallPath = "/api/Verification/Get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (verificationId != null)
                callPayload.Queries["verificationId"] = ExpressionConverter.Convert(verificationId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel[]> VerificationGetAll([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parameterId = null)
        {
            var apiCallPath = "/api/Verification/GetAll";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            if (parameterId != null)
                callPayload.Queries["parameterId"] = ExpressionConverter.Convert(parameterId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationViewModel> VerificationGetLatest([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parameterId = null, [WorkflowExpression] Func<int> pdId = null)
        {
            var apiCallPath = "/api/Verification/GetLatest";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            if (parameterId != null)
                callPayload.Queries["parameterId"] = ExpressionConverter.Convert(parameterId);
            if (pdId != null)
                callPayload.Queries["pdId"] = ExpressionConverter.Convert(pdId);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsVerificationViewModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> VerificationGetShred([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> docId = null, [WorkflowExpression] Func<int> parId = null, [WorkflowExpression] Func<int> verificationId = null, [WorkflowExpression] Func<bool> inline = null)
        {
            var apiCallPath = "/api/Verification/GetShred";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (docId != null)
                callPayload.Queries["docId"] = ExpressionConverter.Convert(docId);
            if (parId != null)
                callPayload.Queries["parId"] = ExpressionConverter.Convert(parId);
            if (verificationId != null)
                callPayload.Queries["verificationId"] = ExpressionConverter.Convert(verificationId);
            callPayload.Queries["inline"] = Convert.ToString(false);
            if (inline != null)
                callPayload.Queries["inline"] = ExpressionConverter.Convert(inline);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[]> VerificationGetSummary([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<int> pdId = null, [WorkflowExpression] Func<bool> latestOnly = null)
        {
            var apiCallPath = "/api/Verification/GetSummary";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (pdId != null)
                callPayload.Queries["pdId"] = ExpressionConverter.Convert(pdId);
            callPayload.Queries["latestOnly"] = Convert.ToString(true);
            if (latestOnly != null)
                callPayload.Queries["latestOnly"] = ExpressionConverter.Convert(latestOnly);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsVerificationSummary[]> VerificationGetHeatmap([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<bool> latestOnly = null)
        {
            var apiCallPath = "/api/Verification/GetHeatmap";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            callPayload.Queries["latestOnly"] = Convert.ToString(true);
            if (latestOnly != null)
                callPayload.Queries["latestOnly"] = ExpressionConverter.Convert(latestOnly);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsVerificationSummary[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<object> DocumentGetBlob([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<typeInput> type = null)
        {
            var apiCallPath = "/api/Document/GetBlob";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentDataViewModel[]> DocumentGetData([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<int> id = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<int> blobid = null, [WorkflowExpression] Func<int> pageindex = null, [WorkflowExpression] Func<int> imagesCount = null)
        {
            var apiCallPath = "/api/Document/GetData";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (contentType != null)
                callPayload.Queries["contentType"] = ExpressionConverter.Convert(contentType);
            if (text != null)
                callPayload.Queries["text"] = ExpressionConverter.Convert(text);
            if (blobid != null)
                callPayload.Queries["blobid"] = ExpressionConverter.Convert(blobid);
            if (pageindex != null)
                callPayload.Queries["pageindex"] = ExpressionConverter.Convert(pageindex);
            if (imagesCount != null)
                callPayload.Queries["imagesCount"] = ExpressionConverter.Convert(imagesCount);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentDataViewModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aiforged")]
        public IBodyWorkflowAction<AIForgedViewModelsDocumentViewModel[]> DocumentGetExtended([WorkflowExpression] Func<string> xApiVersion, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<int> projectId = null, [WorkflowExpression] Func<int> stpdId = null, [WorkflowExpression] Func<usageInput> usage = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> classname = null, [WorkflowExpression] Func<string> filename = null, [WorkflowExpression] Func<string> filetype = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<int> masterid = null, [WorkflowExpression] Func<int> pageNo = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortDirectionInput> sortDirection = null, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<string> result = null, [WorkflowExpression] Func<string> resultId = null, [WorkflowExpression] Func<int> resultIndex = null, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> docGuid = null)
        {
            var apiCallPath = "/api/Document/GetExtended";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            if (projectId != null)
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            if (stpdId != null)
                callPayload.Queries["stpdId"] = ExpressionConverter.Convert(stpdId);
            if (usage != null)
                callPayload.Queries["usage"] = ExpressionConverter.Convert(usage);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (classname != null)
                callPayload.Queries["classname"] = ExpressionConverter.Convert(classname);
            if (filename != null)
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
            if (filetype != null)
                callPayload.Queries["filetype"] = ExpressionConverter.Convert(filetype);
            if (start != null)
                callPayload.Queries["start"] = ExpressionConverter.Convert(start);
            if (end != null)
                callPayload.Queries["end"] = ExpressionConverter.Convert(end);
            if (masterid != null)
                callPayload.Queries["masterid"] = ExpressionConverter.Convert(masterid);
            if (pageNo != null)
                callPayload.Queries["pageNo"] = ExpressionConverter.Convert(pageNo);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            if (sortField != null)
                callPayload.Queries["sortField"] = ExpressionConverter.Convert(sortField);
            if (sortDirection != null)
                callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(sortDirection);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            if (result != null)
                callPayload.Queries["result"] = ExpressionConverter.Convert(result);
            if (resultId != null)
                callPayload.Queries["resultId"] = ExpressionConverter.Convert(resultId);
            if (resultIndex != null)
                callPayload.Queries["resultIndex"] = ExpressionConverter.Convert(resultIndex);
            if (externalId != null)
                callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
            if (docGuid != null)
                callPayload.Queries["docGuid"] = ExpressionConverter.Convert(docGuid);
            callPayload.Headers["X-Api-Version"] = ExpressionConverter.Convert(xApiVersion);
            return new ApiConnectionAction<AIForgedViewModelsDocumentViewModel[]>(callPayload);
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "81")]
        _81,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "108")]
        _108,
        [EnumMember(Value = "109")]
        _109,
        [EnumMember(Value = "110")]
        _110,
        [EnumMember(Value = "190")]
        _190
    }

    public enum AIForgedDALUsageType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99
    }

    public enum AIForgedDALAvailability
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "99")]
        _99
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8
    }

    public enum AIForgedDALVerificationStatus
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024,
        [EnumMember(Value = "2048")]
        _2048,
        [EnumMember(Value = "4096")]
        _4096,
        [EnumMember(Value = "8192")]
        _8192,
        [EnumMember(Value = "16384")]
        _16384
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "99")]
        _99
    }

    public enum AIForgedDALParameterDefinitionCategory
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "21")]
        _21,
        [EnumMember(Value = "22")]
        _22,
        [EnumMember(Value = "40")]
        _40
    }

    public enum AIForgedDALGroupingType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "99")]
        _99
    }

    public enum AIForgedDALValueType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "17")]
        _17,
        [EnumMember(Value = "18")]
        _18,
        [EnumMember(Value = "19")]
        _19,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99
    }

    public enum AIForgedDALRequiredOption
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10
    }

    public enum AIForgedDALSettingStatus
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "99")]
        _99
    }

    public enum AIForgedDALOrientation
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public enum AIForgedDALMarkingType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8
    }

    public enum AIForgedDALOptionStatusFlags
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512,
        [EnumMember(Value = "1024")]
        _1024
    }

    public enum categoryInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "21")]
        _21,
        [EnumMember(Value = "22")]
        _22,
        [EnumMember(Value = "40")]
        _40
    }

    public enum groupingInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "99")]
        _99
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "99")]
        _99
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
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "32")]
        _32,
        [EnumMember(Value = "64")]
        _64,
        [EnumMember(Value = "128")]
        _128,
        [EnumMember(Value = "256")]
        _256,
        [EnumMember(Value = "512")]
        _512
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "17")]
        _17,
        [EnumMember(Value = "18")]
        _18,
        [EnumMember(Value = "19")]
        _19,
        [EnumMember(Value = "21")]
        _21,
        [EnumMember(Value = "22")]
        _22,
        [EnumMember(Value = "24")]
        _24,
        [EnumMember(Value = "26")]
        _26,
        [EnumMember(Value = "27")]
        _27,
        [EnumMember(Value = "29")]
        _29,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "31")]
        _31,
        [EnumMember(Value = "35")]
        _35,
        [EnumMember(Value = "41")]
        _41,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "51")]
        _51,
        [EnumMember(Value = "52")]
        _52,
        [EnumMember(Value = "55")]
        _55,
        [EnumMember(Value = "60")]
        _60,
        [EnumMember(Value = "61")]
        _61,
        [EnumMember(Value = "62")]
        _62,
        [EnumMember(Value = "63")]
        _63,
        [EnumMember(Value = "70")]
        _70,
        [EnumMember(Value = "71")]
        _71,
        [EnumMember(Value = "72")]
        _72,
        [EnumMember(Value = "80")]
        _80,
        [EnumMember(Value = "81")]
        _81,
        [EnumMember(Value = "85")]
        _85,
        [EnumMember(Value = "86")]
        _86,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "91")]
        _91,
        [EnumMember(Value = "92")]
        _92,
        [EnumMember(Value = "95")]
        _95,
        [EnumMember(Value = "96")]
        _96,
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "110")]
        _110,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "1000")]
        _1000,
        [EnumMember(Value = "1001")]
        _1001,
        [EnumMember(Value = "2000")]
        _2000,
        [EnumMember(Value = "2001")]
        _2001
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
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public enum typeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "11")]
        _11
    }

    public enum usageInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99
    }

    public enum statusInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "8")]
        _8,
        [EnumMember(Value = "9")]
        _9,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "81")]
        _81,
        [EnumMember(Value = "90")]
        _90,
        [EnumMember(Value = "98")]
        _98,
        [EnumMember(Value = "99")]
        _99,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "108")]
        _108,
        [EnumMember(Value = "109")]
        _109,
        [EnumMember(Value = "110")]
        _110,
        [EnumMember(Value = "190")]
        _190
    }

    public enum sortFieldInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public enum sortDirectionInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
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