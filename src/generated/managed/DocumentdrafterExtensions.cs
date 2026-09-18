//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Documentdrafter
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentdrafterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> GetCreateWorkspace([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workspaceNameRoute, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> masterWorkSpace = null, [WorkflowExpression] Func<bool> copyStyling = null, [WorkflowExpression] Func<bool> copyFolders = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(workspaceNameRoute, nameof(workspaceNameRoute), required: true);
            SourceExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            SourceExpression.Validate(masterWorkSpace, nameof(masterWorkSpace), required: false);
            SourceExpression.Validate(copyStyling, nameof(copyStyling), required: false);
            SourceExpression.Validate(copyFolders, nameof(copyFolders), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateWorkspace/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceNameRoute, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = SourceExpressionConverter.ConvertO(createIfNotFound);
                if (masterWorkSpace != null)
                    callPayload.Queries["MasterWorkSpace"] = SourceExpressionConverter.ConvertO(masterWorkSpace);
                if (copyStyling != null)
                    callPayload.Queries["CopyStyling"] = SourceExpressionConverter.ConvertO(copyStyling);
                if (copyFolders != null)
                    callPayload.Queries["CopyFolders"] = SourceExpressionConverter.ConvertO(copyFolders);
                return callPayload;
            }

            return new ApiConnectionAction<GetCreateWorkspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> folderName, [WorkflowExpression] Func<string> parentId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            SourceExpression.Validate(folderName, nameof(folderName), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateFolder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderName, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = SourceExpressionConverter.ConvertO(createIfNotFound);
                callPayload.Queries["ParentId"] = SourceExpressionConverter.ConvertO(parentId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCreateFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> role = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            SourceExpression.Validate(groupNamePath, nameof(groupNamePath), required: true);
            SourceExpression.Validate(role, nameof(role), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateGroup/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = SourceExpressionConverter.ConvertO(createIfNotFound);
                if (role != null)
                    callPayload.Queries["Role"] = SourceExpressionConverter.ConvertO(role);
                return callPayload;
            }

            return new ApiConnectionAction<GetCreateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            SourceExpression.Validate(groupNamePath, nameof(groupNamePath), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateAccessFolder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupNamePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = SourceExpressionConverter.ConvertO(createIfNotFound);
                callPayload.Queries["FolderId"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCreateAccessFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> sendInvite)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(createIfNotFound, nameof(createIfNotFound), required: true);
            SourceExpression.Validate(groupName, nameof(groupName), required: true);
            SourceExpression.Validate(email, nameof(email), required: true);
            SourceExpression.Validate(sendInvite, nameof(sendInvite), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateUser/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["CreateIfNotFound"] = SourceExpressionConverter.ConvertO(createIfNotFound);
                callPayload.Queries["GroupName"] = SourceExpressionConverter.ConvertO(groupName);
                callPayload.Queries["sendInvite"] = SourceExpressionConverter.ConvertO(sendInvite);
                return callPayload;
            }

            return new ApiConnectionAction<GetCreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fileBase64)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(fileBase64, nameof(fileBase64), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateSaveStaticFileToFolder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                return callPayload;
            }

            return new ApiConnectionAction<SaveStaticFileToFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLink([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> scope, [WorkflowExpression] Func<int> expireDays, [WorkflowExpression] Func<string> createUser)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(scope, nameof(scope), required: true);
            SourceExpression.Validate(expireDays, nameof(expireDays), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerAutomateCreateMagicLink";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["Scope"] = SourceExpressionConverter.ConvertO(scope);
                callPayload.Queries["ExpireDays"] = SourceExpressionConverter.ConvertO(expireDays);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(workSpace, nameof(workSpace), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateCreateQuestionnaire/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["WorkSpace"] = SourceExpressionConverter.ConvertO(workSpace);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<CreateQuestionnaireResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/DeleteAllShareLinksOnDocument";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowAddShare([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> groupOrMail, [WorkflowExpression] Func<bool> selectedQuestions = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            SourceExpression.Validate(groupOrMail, nameof(groupOrMail), required: true);
            SourceExpression.Validate(selectedQuestions, nameof(selectedQuestions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddShare";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                callPayload.Queries["GroupOrMail"] = SourceExpressionConverter.ConvertO(groupOrMail);
                callPayload.Queries["SelectedQuestions"] = Convert.ToString(false);
                if (selectedQuestions != null)
                    callPayload.Queries["SelectedQuestions"] = SourceExpressionConverter.ConvertO(selectedQuestions);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowSetState([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> createUser)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(flowKey, nameof(flowKey), required: true);
            SourceExpression.Validate(state, nameof(state), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FlowSetState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                callPayload.Queries["State"] = SourceExpressionConverter.ConvertO(state);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(workSpace, nameof(workSpace), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetTagsForDocument/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["WorkSpace"] = SourceExpressionConverter.ConvertO(workSpace);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> documentId = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerAutomateQuestionsWithTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                if (documentId != null)
                    callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagsForQuestionnaireResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> jsonData)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(workSpace, nameof(workSpace), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            SourceExpression.Validate(jsonData, nameof(jsonData), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/PowerAutomateDataModelCreateDoc/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["WorkSpace"] = SourceExpressionConverter.ConvertO(workSpace);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                return callPayload;
            }

            return new ApiConnectionAction<ProcessJsonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetFlowInformation([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl)
        {
            SourceExpression.Validate(flowKey, nameof(flowKey), required: true);
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerAutomateGetFlowInformation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<outputFormatInput> outputFormat)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(createUser, nameof(createUser), required: true);
            SourceExpression.Validate(outputFormat, nameof(outputFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerAutomateGetDocument";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["DocumentId"] = SourceExpressionConverter.ConvertO(documentId);
                callPayload.Queries["CreateUser"] = SourceExpressionConverter.ConvertO(createUser);
                callPayload.Queries["OutputFormat"] = SourceExpressionConverter.Convert(outputFormat);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentsResponse>(BuildSourceInput);
        }
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(scope, nameof(scope), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FlowWaitForSubmitPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["Scope"] = SourceExpressionConverter.ConvertO(scope);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(flowKey, nameof(flowKey), required: true);
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FlowTriggerPolling";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FlowKey"] = SourceExpressionConverter.ConvertO(flowKey);
                callPayload.Queries["SiteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                return callPayload;
            }

            return new ApiConnectionTrigger<FlowTriggerPollingResponse>(BuildSourceInput, triggerName, recurrence);
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