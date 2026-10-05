//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdrafterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetCreateWorkspace))]
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> GetCreateWorkspace([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workspaceNameRoute, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> masterWorkSpace = null, [WorkflowExpression] Func<bool> copyStyling = null, [WorkflowExpression] Func<bool> copyFolders = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> __BuildGetCreateWorkspace(WorkflowValue<string> siteUrl, WorkflowValue<string> workspaceNameRoute, WorkflowValue<bool> createIfNotFound, WorkflowValue<string> masterWorkSpace = null, WorkflowValue<bool> copyStyling = null, WorkflowValue<bool> copyFolders = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(workspaceNameRoute, nameof(workspaceNameRoute), required: true);
            WorkflowValue.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowValue.Validate(masterWorkSpace, nameof(masterWorkSpace), required: false);
            WorkflowValue.Validate(copyStyling, nameof(copyStyling), required: false);
            WorkflowValue.Validate(copyFolders, nameof(copyFolders), required: false);
            return new DeferredBodyAction<GetCreateWorkspaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateWorkspace/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceNameRoute, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
                if (masterWorkSpace != null)
                    callPayload.Queries["MasterWorkSpace"] = ExpressionConverter.Convert(masterWorkSpace);
                if (copyStyling != null)
                    callPayload.Queries["CopyStyling"] = ExpressionConverter.Convert(copyStyling);
                if (copyFolders != null)
                    callPayload.Queries["CopyFolders"] = ExpressionConverter.Convert(copyFolders);
                return new ApiConnectionAction<GetCreateWorkspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetCreateFolder))]
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> folderName, [WorkflowExpression] Func<string> parentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateFolderResponse> __BuildGetCreateFolder(WorkflowValue<string> siteUrl, WorkflowValue<bool> createIfNotFound, WorkflowValue<string> folderName, WorkflowValue<string> parentId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowValue.Validate(folderName, nameof(folderName), required: true);
            WorkflowValue.Validate(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<GetCreateFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
                callPayload.Queries["ParentId"] = ExpressionConverter.Convert(parentId);
                return new ApiConnectionAction<GetCreateFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetCreateGroup))]
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> role = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateGroupResponse> __BuildGetCreateGroup(WorkflowValue<string> siteUrl, WorkflowValue<bool> createIfNotFound, WorkflowValue<string> groupNamePath, WorkflowValue<string> role = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowValue.Validate(groupNamePath, nameof(groupNamePath), required: true);
            WorkflowValue.Validate(role, nameof(role), required: false);
            return new DeferredBodyAction<GetCreateGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateGroup/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
                if (role != null)
                    callPayload.Queries["Role"] = ExpressionConverter.Convert(role);
                return new ApiConnectionAction<GetCreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetCreateAccessFolder))]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> __BuildGetCreateAccessFolder(WorkflowValue<string> siteUrl, WorkflowValue<bool> createIfNotFound, WorkflowValue<string> groupNamePath, WorkflowValue<string> folderId)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowValue.Validate(groupNamePath, nameof(groupNamePath), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<GetCreateAccessFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateAccessFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
                callPayload.Queries["FolderId"] = ExpressionConverter.Convert(folderId);
                return new ApiConnectionAction<GetCreateAccessFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetCreateUser))]
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> sendInvite)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateUserResponse> __BuildGetCreateUser(WorkflowValue<string> siteUrl, WorkflowValue<bool> createIfNotFound, WorkflowValue<string> groupName, WorkflowValue<string> email, WorkflowValue<bool> sendInvite)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowValue.Validate(groupName, nameof(groupName), required: true);
            WorkflowValue.Validate(email, nameof(email), required: true);
            WorkflowValue.Validate(sendInvite, nameof(sendInvite), required: true);
            return new DeferredBodyAction<GetCreateUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateUser/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
                callPayload.Queries["GroupName"] = ExpressionConverter.Convert(groupName);
                callPayload.Queries["sendInvite"] = ExpressionConverter.Convert(sendInvite);
                return new ApiConnectionAction<GetCreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildSaveStaticFileToFolder))]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fileBase64)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> __BuildSaveStaticFileToFolder(WorkflowValue<string> siteUrl, WorkflowValue<string> folderId, WorkflowValue<string> fileName, WorkflowValue<string> fileBase64)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(folderId, nameof(folderId), required: true);
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(fileBase64, nameof(fileBase64), required: true);
            return new DeferredBodyAction<SaveStaticFileToFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateSaveStaticFileToFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<SaveStaticFileToFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetExternalShareLink))]
        public IBodyWorkflowAction<string> GetExternalShareLink([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> scope, [WorkflowExpression] Func<int> expireDays, [WorkflowExpression] Func<string> createUser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetExternalShareLink(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> scope, WorkflowValue<int> expireDays, WorkflowValue<string> createUser)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(scope, nameof(scope), required: true);
            WorkflowValue.Validate(expireDays, nameof(expireDays), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/PowerAutomateCreateMagicLink";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["Scope"] = ExpressionConverter.Convert(scope);
                callPayload.Queries["ExpireDays"] = ExpressionConverter.Convert(expireDays);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildCreateQuestionnaire))]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> __BuildCreateQuestionnaire(WorkflowValue<string> siteUrl, WorkflowValue<string> workSpace, WorkflowValue<string> templateId, WorkflowValue<string> createUser)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<CreateQuestionnaireResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateCreateQuestionnaire/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<CreateQuestionnaireResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAllShareLinksOnDocument))]
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteAllShareLinksOnDocument(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> createUser)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/DeleteAllShareLinksOnDocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildFlowAddShare))]
        public IBodyWorkflowAction<JToken> FlowAddShare([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> groupOrMail, [WorkflowExpression] Func<bool> selectedQuestions = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowAddShare(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> createUser, WorkflowValue<string> groupOrMail, WorkflowValue<bool> selectedQuestions = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            WorkflowValue.Validate(groupOrMail, nameof(groupOrMail), required: true);
            WorkflowValue.Validate(selectedQuestions, nameof(selectedQuestions), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/AddShare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                callPayload.Queries["GroupOrMail"] = ExpressionConverter.Convert(groupOrMail);
                callPayload.Queries["SelectedQuestions"] = Convert.ToString(false);
                if (selectedQuestions != null)
                    callPayload.Queries["SelectedQuestions"] = ExpressionConverter.Convert(selectedQuestions);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildFlowSetState))]
        public IBodyWorkflowAction<JToken> FlowSetState([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> createUser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowSetState(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> flowKey, WorkflowValue<string> state, WorkflowValue<string> createUser)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowValue.Validate(state, nameof(state), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/FlowSetState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
                callPayload.Queries["State"] = ExpressionConverter.Convert(state);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetVariablesForTemplate))]
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetVariablesForTemplate(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> workSpace, WorkflowValue<string> templateId, WorkflowValue<string> createUser)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetTagsForDocument/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetTagsForQuestionnaire))]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> documentId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> __BuildGetTagsForQuestionnaire(WorkflowValue<string> siteUrl, WorkflowValue<string> createUser, WorkflowValue<string> documentId = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: false);
            return new DeferredBodyAction<GetTagsForQuestionnaireResponse>(() =>
            {
                var apiCallPath = "/PowerAutomateQuestionsWithTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                if (documentId != null)
                    callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<GetTagsForQuestionnaireResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildProcessJson))]
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> jsonData)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProcessJsonResponse> __BuildProcessJson(WorkflowValue<string> siteUrl, WorkflowValue<string> workSpace, WorkflowValue<string> templateId, WorkflowValue<string> createUser, WorkflowValue<string> jsonData)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            WorkflowValue.Validate(jsonData, nameof(jsonData), required: true);
            return new DeferredBodyAction<ProcessJsonResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/PowerAutomateDataModelCreateDoc/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                return new ApiConnectionAction<ProcessJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetFlowInformation))]
        public IBodyWorkflowAction<JToken> GetFlowInformation([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFlowInformation(WorkflowValue<string> flowKey, WorkflowValue<string> siteUrl)
        {
            WorkflowValue.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/PowerAutomateGetFlowInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocuments))]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<outputFormatInput> outputFormat)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentsResponse> __BuildGetDocuments(WorkflowValue<string> siteUrl, WorkflowValue<string> documentId, WorkflowValue<string> createUser, WorkflowValue<outputFormatInput> outputFormat)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(createUser, nameof(createUser), required: true);
            WorkflowValue.Validate(outputFormat, nameof(outputFormat), required: true);
            return new DeferredBodyAction<GetDocumentsResponse>(() =>
            {
                var apiCallPath = "/PowerAutomateGetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
                callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
                callPayload.Queries["OutputFormat"] = ExpressionConverter.Convert(outputFormat);
                return new ApiConnectionAction<GetDocumentsResponse>(callPayload);
            });
        }
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildTriggerSubmitPolling))]
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> __BuildTriggerSubmitPolling(WorkflowValue<string> siteUrl, WorkflowValue<string> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(scope, nameof(scope), required: true);
            return new DeferredBodyTrigger<TriggerSubmitPollingResponse>(() =>
            {
                var apiCallPath = "/FlowWaitForSubmitPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["Scope"] = ExpressionConverter.Convert(scope);
                return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildFlowTriggerPolling))]
        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> __BuildFlowTriggerPolling(WorkflowValue<string> flowKey, WorkflowValue<string> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            return new DeferredBodyTrigger<FlowTriggerPollingResponse>(() =>
            {
                var apiCallPath = "/FlowTriggerPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
                callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
                return new ApiConnectionTrigger<FlowTriggerPollingResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
