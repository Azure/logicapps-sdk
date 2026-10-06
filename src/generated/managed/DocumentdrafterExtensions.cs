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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> __BuildGetCreateWorkspace(WorkflowExpression<string> siteUrl, WorkflowExpression<string> workspaceNameRoute, WorkflowExpression<bool> createIfNotFound, WorkflowExpression<string> masterWorkSpace = null, WorkflowExpression<bool> copyStyling = null, WorkflowExpression<bool> copyFolders = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(workspaceNameRoute, nameof(workspaceNameRoute), required: true);
            WorkflowExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowExpression.Validate(masterWorkSpace, nameof(masterWorkSpace), required: false);
            WorkflowExpression.Validate(copyStyling, nameof(copyStyling), required: false);
            WorkflowExpression.Validate(copyFolders, nameof(copyFolders), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateFolderResponse> __BuildGetCreateFolder(WorkflowExpression<string> siteUrl, WorkflowExpression<bool> createIfNotFound, WorkflowExpression<string> folderName, WorkflowExpression<string> parentId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowExpression.Validate(folderName, nameof(folderName), required: true);
            WorkflowExpression.Validate(parentId, nameof(parentId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateGroupResponse> __BuildGetCreateGroup(WorkflowExpression<string> siteUrl, WorkflowExpression<bool> createIfNotFound, WorkflowExpression<string> groupNamePath, WorkflowExpression<string> role = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowExpression.Validate(groupNamePath, nameof(groupNamePath), required: true);
            WorkflowExpression.Validate(role, nameof(role), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> __BuildGetCreateAccessFolder(WorkflowExpression<string> siteUrl, WorkflowExpression<bool> createIfNotFound, WorkflowExpression<string> groupNamePath, WorkflowExpression<string> folderId)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowExpression.Validate(groupNamePath, nameof(groupNamePath), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCreateUserResponse> __BuildGetCreateUser(WorkflowExpression<string> siteUrl, WorkflowExpression<bool> createIfNotFound, WorkflowExpression<string> groupName, WorkflowExpression<string> email, WorkflowExpression<bool> sendInvite)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            WorkflowExpression.Validate(groupName, nameof(groupName), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: true);
            WorkflowExpression.Validate(sendInvite, nameof(sendInvite), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> __BuildSaveStaticFileToFolder(WorkflowExpression<string> siteUrl, WorkflowExpression<string> folderId, WorkflowExpression<string> fileName, WorkflowExpression<string> fileBase64)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(fileBase64, nameof(fileBase64), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetExternalShareLink(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> scope, WorkflowExpression<int> expireDays, WorkflowExpression<string> createUser)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(scope, nameof(scope), required: true);
            WorkflowExpression.Validate(expireDays, nameof(expireDays), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> __BuildCreateQuestionnaire(WorkflowExpression<string> siteUrl, WorkflowExpression<string> workSpace, WorkflowExpression<string> templateId, WorkflowExpression<string> createUser)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteAllShareLinksOnDocument(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> createUser)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowAddShare(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> createUser, WorkflowExpression<string> groupOrMail, WorkflowExpression<bool> selectedQuestions = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
            WorkflowExpression.Validate(groupOrMail, nameof(groupOrMail), required: true);
            WorkflowExpression.Validate(selectedQuestions, nameof(selectedQuestions), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowSetState(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> flowKey, WorkflowExpression<string> state, WorkflowExpression<string> createUser)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowExpression.Validate(state, nameof(state), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetVariablesForTemplate(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> workSpace, WorkflowExpression<string> templateId, WorkflowExpression<string> createUser)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> __BuildGetTagsForQuestionnaire(WorkflowExpression<string> siteUrl, WorkflowExpression<string> createUser, WorkflowExpression<string> documentId = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProcessJsonResponse> __BuildProcessJson(WorkflowExpression<string> siteUrl, WorkflowExpression<string> workSpace, WorkflowExpression<string> templateId, WorkflowExpression<string> createUser, WorkflowExpression<string> jsonData)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(workSpace, nameof(workSpace), required: true);
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
            WorkflowExpression.Validate(jsonData, nameof(jsonData), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetFlowInformation(WorkflowExpression<string> flowKey, WorkflowExpression<string> siteUrl)
        {
            WorkflowExpression.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentsResponse> __BuildGetDocuments(WorkflowExpression<string> siteUrl, WorkflowExpression<string> documentId, WorkflowExpression<string> createUser, WorkflowExpression<outputFormatInput> outputFormat)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(createUser, nameof(createUser), required: true);
            WorkflowExpression.Validate(outputFormat, nameof(outputFormat), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> __BuildTriggerSubmitPolling(WorkflowExpression<string> siteUrl, WorkflowExpression<string> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowExpression.Validate(scope, nameof(scope), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> __BuildFlowTriggerPolling(WorkflowExpression<string> flowKey, WorkflowExpression<string> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(flowKey, nameof(flowKey), required: true);
            WorkflowExpression.Validate(siteUrl, nameof(siteUrl), required: true);
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