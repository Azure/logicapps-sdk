//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DocumentdrafterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> GetCreateWorkspace(Expression<Func<string>> siteUrl, Expression<Func<string>> workspaceNameRoute, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> masterWorkSpace = null, Expression<Func<bool>> copyStyling = null, Expression<Func<bool>> copyFolders = null)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_workspaceNameRoute = workspaceNameRoute == null ? null : WorkflowExpression.Compile(workspaceNameRoute);
            WorkflowExpression.Validate(__workflow_workspaceNameRoute, nameof(workspaceNameRoute), required: true);
            var __workflow_createIfNotFound = createIfNotFound == null ? null : WorkflowExpression.Compile(createIfNotFound);
            WorkflowExpression.Validate(__workflow_createIfNotFound, nameof(createIfNotFound), required: true);
            var __workflow_masterWorkSpace = masterWorkSpace == null ? null : WorkflowExpression.Compile(masterWorkSpace);
            WorkflowExpression.Validate(__workflow_masterWorkSpace, nameof(masterWorkSpace), required: false);
            var __workflow_copyStyling = copyStyling == null ? null : WorkflowExpression.Compile(copyStyling);
            WorkflowExpression.Validate(__workflow_copyStyling, nameof(copyStyling), required: false);
            var __workflow_copyFolders = copyFolders == null ? null : WorkflowExpression.Compile(copyFolders);
            WorkflowExpression.Validate(__workflow_copyFolders, nameof(copyFolders), required: false);
            return new DeferredBodyAction<GetCreateWorkspaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateWorkspace/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workspaceNameRoute, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(__workflow_createIfNotFound);
                if (__workflow_masterWorkSpace != null)
                    callPayload.Queries["MasterWorkSpace"] = ExpressionConverter.Convert(__workflow_masterWorkSpace);
                if (__workflow_copyStyling != null)
                    callPayload.Queries["CopyStyling"] = ExpressionConverter.Convert(__workflow_copyStyling);
                if (__workflow_copyFolders != null)
                    callPayload.Queries["CopyFolders"] = ExpressionConverter.Convert(__workflow_copyFolders);
                return new ApiConnectionAction<GetCreateWorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> folderName, Expression<Func<string>> parentId)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_createIfNotFound = createIfNotFound == null ? null : WorkflowExpression.Compile(createIfNotFound);
            WorkflowExpression.Validate(__workflow_createIfNotFound, nameof(createIfNotFound), required: true);
            var __workflow_folderName = folderName == null ? null : WorkflowExpression.Compile(folderName);
            WorkflowExpression.Validate(__workflow_folderName, nameof(folderName), required: true);
            var __workflow_parentId = parentId == null ? null : WorkflowExpression.Compile(parentId);
            WorkflowExpression.Validate(__workflow_parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<GetCreateFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(__workflow_createIfNotFound);
                callPayload.Queries["ParentId"] = ExpressionConverter.Convert(__workflow_parentId);
                return new ApiConnectionAction<GetCreateFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> role = null)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_createIfNotFound = createIfNotFound == null ? null : WorkflowExpression.Compile(createIfNotFound);
            WorkflowExpression.Validate(__workflow_createIfNotFound, nameof(createIfNotFound), required: true);
            var __workflow_groupNamePath = groupNamePath == null ? null : WorkflowExpression.Compile(groupNamePath);
            WorkflowExpression.Validate(__workflow_groupNamePath, nameof(groupNamePath), required: true);
            var __workflow_role = role == null ? null : WorkflowExpression.Compile(role);
            WorkflowExpression.Validate(__workflow_role, nameof(role), required: false);
            return new DeferredBodyAction<GetCreateGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateGroup/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(__workflow_createIfNotFound);
                if (__workflow_role != null)
                    callPayload.Queries["Role"] = ExpressionConverter.Convert(__workflow_role);
                return new ApiConnectionAction<GetCreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> folderId)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_createIfNotFound = createIfNotFound == null ? null : WorkflowExpression.Compile(createIfNotFound);
            WorkflowExpression.Validate(__workflow_createIfNotFound, nameof(createIfNotFound), required: true);
            var __workflow_groupNamePath = groupNamePath == null ? null : WorkflowExpression.Compile(groupNamePath);
            WorkflowExpression.Validate(__workflow_groupNamePath, nameof(groupNamePath), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<GetCreateAccessFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateAccessFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(__workflow_createIfNotFound);
                callPayload.Queries["FolderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<GetCreateAccessFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupName, Expression<Func<string>> email, Expression<Func<bool>> sendInvite)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_createIfNotFound = createIfNotFound == null ? null : WorkflowExpression.Compile(createIfNotFound);
            WorkflowExpression.Validate(__workflow_createIfNotFound, nameof(createIfNotFound), required: true);
            var __workflow_groupName = groupName == null ? null : WorkflowExpression.Compile(groupName);
            WorkflowExpression.Validate(__workflow_groupName, nameof(groupName), required: true);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            var __workflow_sendInvite = sendInvite == null ? null : WorkflowExpression.Compile(sendInvite);
            WorkflowExpression.Validate(__workflow_sendInvite, nameof(sendInvite), required: true);
            return new DeferredBodyAction<GetCreateUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateUser/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_email, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(__workflow_createIfNotFound);
                callPayload.Queries["GroupName"] = ExpressionConverter.Convert(__workflow_groupName);
                callPayload.Queries["sendInvite"] = ExpressionConverter.Convert(__workflow_sendInvite);
                return new ApiConnectionAction<GetCreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder(Expression<Func<string>> siteUrl, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> fileBase64)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_folderId = folderId == null ? null : WorkflowExpression.Compile(folderId);
            WorkflowExpression.Validate(__workflow_folderId, nameof(folderId), required: true);
            var __workflow_fileName = fileName == null ? null : WorkflowExpression.Compile(fileName);
            WorkflowExpression.Validate(__workflow_fileName, nameof(fileName), required: true);
            var __workflow_fileBase64 = fileBase64 == null ? null : WorkflowExpression.Compile(fileBase64);
            WorkflowExpression.Validate(__workflow_fileBase64, nameof(fileBase64), required: true);
            return new DeferredBodyAction<SaveStaticFileToFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateSaveStaticFileToFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<SaveStaticFileToFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLink(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> scope, Expression<Func<int>> expireDays, Expression<Func<string>> createUser)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_scope = scope == null ? null : WorkflowExpression.Compile(scope);
            WorkflowExpression.Validate(__workflow_scope, nameof(scope), required: true);
            var __workflow_expireDays = expireDays == null ? null : WorkflowExpression.Compile(expireDays);
            WorkflowExpression.Validate(__workflow_expireDays, nameof(expireDays), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/PowerAutomateCreateMagicLink";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["Scope"] = ExpressionConverter.Convert(__workflow_scope);
                callPayload.Queries["ExpireDays"] = ExpressionConverter.Convert(__workflow_expireDays);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_workSpace = workSpace == null ? null : WorkflowExpression.Compile(workSpace);
            WorkflowExpression.Validate(__workflow_workSpace, nameof(workSpace), required: true);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<CreateQuestionnaireResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateCreateQuestionnaire/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(__workflow_workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<CreateQuestionnaireResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/DeleteAllShareLinksOnDocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowAddShare(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<string>> groupOrMail, Expression<Func<bool>> selectedQuestions = null)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            var __workflow_groupOrMail = groupOrMail == null ? null : WorkflowExpression.Compile(groupOrMail);
            WorkflowExpression.Validate(__workflow_groupOrMail, nameof(groupOrMail), required: true);
            var __workflow_selectedQuestions = selectedQuestions == null ? null : WorkflowExpression.Compile(selectedQuestions);
            WorkflowExpression.Validate(__workflow_selectedQuestions, nameof(selectedQuestions), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/AddShare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                callPayload.Queries["GroupOrMail"] = ExpressionConverter.Convert(__workflow_groupOrMail);
                callPayload.Queries["SelectedQuestions"] = Convert.ToString(false);
                if (__workflow_selectedQuestions != null)
                    callPayload.Queries["SelectedQuestions"] = ExpressionConverter.Convert(__workflow_selectedQuestions);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowSetState(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> flowKey, Expression<Func<string>> state, Expression<Func<string>> createUser)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_flowKey = flowKey == null ? null : WorkflowExpression.Compile(flowKey);
            WorkflowExpression.Validate(__workflow_flowKey, nameof(flowKey), required: true);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/FlowSetState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                callPayload.Queries["State"] = ExpressionConverter.Convert(__workflow_state);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_workSpace = workSpace == null ? null : WorkflowExpression.Compile(workSpace);
            WorkflowExpression.Validate(__workflow_workSpace, nameof(workSpace), required: true);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetTagsForDocument/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(__workflow_workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> createUser, Expression<Func<string>> documentId = null)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: false);
            return new DeferredBodyAction<GetTagsForQuestionnaireResponse>(() =>
            {
                var apiCallPath = "/PowerAutomateQuestionsWithTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                if (__workflow_documentId != null)
                    callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<GetTagsForQuestionnaireResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser, Expression<Func<string>> jsonData)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_workSpace = workSpace == null ? null : WorkflowExpression.Compile(workSpace);
            WorkflowExpression.Validate(__workflow_workSpace, nameof(workSpace), required: true);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            var __workflow_jsonData = jsonData == null ? null : WorkflowExpression.Compile(jsonData);
            WorkflowExpression.Validate(__workflow_jsonData, nameof(jsonData), required: true);
            return new DeferredBodyAction<ProcessJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateDataModelCreateDoc/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(__workflow_workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                return new ApiConnectionAction<ProcessJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetFlowInformation(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl)
        {
            var __workflow_flowKey = flowKey == null ? null : WorkflowExpression.Compile(flowKey);
            WorkflowExpression.Validate(__workflow_flowKey, nameof(flowKey), required: true);
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/PowerAutomateGetFlowInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<outputFormatInput>> outputFormat)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_createUser = createUser == null ? null : WorkflowExpression.Compile(createUser);
            WorkflowExpression.Validate(__workflow_createUser, nameof(createUser), required: true);
            var __workflow_outputFormat = outputFormat == null ? null : WorkflowExpression.Compile(outputFormat);
            WorkflowExpression.Validate(__workflow_outputFormat, nameof(outputFormat), required: true);
            return new DeferredBodyAction<GetDocumentsResponse>(() =>
            {
                var apiCallPath = "/PowerAutomateGetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(__workflow_documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(__workflow_createUser);
                callPayload.Queries["OutputFormat"] = ExpressionConverter.Convert(__workflow_outputFormat);
                return new ApiConnectionAction<GetDocumentsResponse>(callPayload);
            });
        }
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling(Expression<Func<string>> siteUrl, Expression<Func<string>> scope, FlowRecurrence recurrence = null)
        {
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            var __workflow_scope = scope == null ? null : WorkflowExpression.Compile(scope);
            WorkflowExpression.Validate(__workflow_scope, nameof(scope), required: true);
            return new DeferredBodyTrigger<TriggerSubmitPollingResponse>(() =>
            {
                var apiCallPath = "/FlowWaitForSubmitPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["Scope"] = ExpressionConverter.Convert(__workflow_scope);
                return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl, FlowRecurrence recurrence = null)
        {
            var __workflow_flowKey = flowKey == null ? null : WorkflowExpression.Compile(flowKey);
            WorkflowExpression.Validate(__workflow_flowKey, nameof(flowKey), required: true);
            var __workflow_siteUrl = siteUrl == null ? null : WorkflowExpression.Compile(siteUrl);
            WorkflowExpression.Validate(__workflow_siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<FlowTriggerPollingResponse>(() =>
            {
                var apiCallPath = "/FlowTriggerPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(__workflow_flowKey);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                return new ApiConnectionTrigger<FlowTriggerPollingResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetCreateWorkspaceResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
    }

    public class GetCreateFolderResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
    }

    public class GetCreateGroupResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }

    public class GetCreateAccessFolderResponse
    {
        public string Status { get; set; }
    }

    public class GetCreateUserResponse
    {
        public string Status { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class SaveStaticFileToFolderResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
    }

    public class CreateQuestionnaireResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetTagsForQuestionnaireResponse
    {
        [JsonProperty("items")]
        public GetTagsForQuestionnaireResponseItemsTypeItem[] Items { get; set; }
    }

    public class GetTagsForQuestionnaireResponseItemsTypeItem
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }

    public class ProcessJsonResponse
    {
        [JsonProperty("documentId")]
        public string DocumentID { get; set; }
    }

    public class GetDocumentsResponse
    {
        public string QuestionnaireName { get; set; }

        [JsonProperty("FirstFileName")]
        public string DocumentNameSingleDocument { get; set; }

        [JsonProperty("FirstFileContentBytes")]
        public string DocumentContentSingleDocument { get; set; }
        public GetDocumentsResponseFilesTypeItem[] Files { get; set; }
    }

    public class GetDocumentsResponseFilesTypeItem
    {
        public string Name { get; set; }
        public string ContentBytes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum outputFormatInput
    {
        [EnumMember(Value = "docx")]
        Docx,
        [EnumMember(Value = "pdf")]
        Pdf
    }

    public class TriggerSubmitPollingResponse
    {
        [JsonProperty("items")]
        public TriggerSubmitPollingResponseItemsTypeItem[] Items { get; set; }
    }

    public class TriggerSubmitPollingResponseItemsTypeItem
    {
        [JsonProperty("status")]
        public TriggerSubmitPollingResponseItemsTypeItemStatusType Status { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerSubmitPollingResponseItemsTypeItemStatusType
    {
        Completed,
        Timeout
    }

    public class FlowTriggerPollingResponse
    {
        [JsonProperty("items")]
        public FlowTriggerPollingResponseItemsTypeItem[] Items { get; set; }
    }

    public class FlowTriggerPollingResponseItemsTypeItem
    {
        [JsonProperty("createUser")]
        public string UserSEmail { get; set; }

        [JsonProperty("documentId")]
        public string DocumentID { get; set; }

        [JsonProperty("triggerTime")]
        public string FlowTimestamp { get; set; }

        [JsonProperty("documentName")]
        public string QuestionnaireName { get; set; }

        [JsonProperty("stateKey")]
        public string CurrentStateKey { get; set; }

        [JsonProperty("triggerKey")]
        public string TriggerKey { get; set; }

        [JsonProperty("additionalData")]
        public string DataForEvent { get; set; }

        [JsonProperty("OriginCreateUser")]
        public string OriginEmail { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter;

    public partial class WorkflowManagedActions
    {
        public DocumentdrafterActions Documentdrafter(string connectionId) => new DocumentdrafterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentdrafterTriggers Documentdrafter(string connectionId) => new DocumentdrafterTriggers(connectionId);
    }
}
