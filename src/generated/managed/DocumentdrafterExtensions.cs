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
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> GetCreateWorkspace(Expression<Func<string>> siteUrl, Expression<Func<string>> workspaceNameRoute, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> masterWorkSpace = null, Expression<Func<bool>> copyStyling = null, Expression<Func<bool>> copyFolders = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateWorkspace/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceNameRoute, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = CSharpExpressionConverter.ConvertO(createIfNotFound);
            if (masterWorkSpace != null)
                callPayload.Queries["MasterWorkSpace"] = CSharpExpressionConverter.ConvertO(masterWorkSpace);
            if (copyStyling != null)
                callPayload.Queries["CopyStyling"] = CSharpExpressionConverter.ConvertO(copyStyling);
            if (copyFolders != null)
                callPayload.Queries["CopyFolders"] = CSharpExpressionConverter.ConvertO(copyFolders);
            return new ApiConnectionAction<GetCreateWorkspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> folderName, Expression<Func<string>> parentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateFolder/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = CSharpExpressionConverter.ConvertO(createIfNotFound);
            callPayload.Queries["ParentId"] = CSharpExpressionConverter.ConvertO(parentId);
            return new ApiConnectionAction<GetCreateFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> role = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateGroup/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupNamePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = CSharpExpressionConverter.ConvertO(createIfNotFound);
            if (role != null)
                callPayload.Queries["Role"] = CSharpExpressionConverter.ConvertO(role);
            return new ApiConnectionAction<GetCreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> folderId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateAccessFolder/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupNamePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = CSharpExpressionConverter.ConvertO(createIfNotFound);
            callPayload.Queries["FolderId"] = CSharpExpressionConverter.ConvertO(folderId);
            return new ApiConnectionAction<GetCreateAccessFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupName, Expression<Func<string>> email, Expression<Func<bool>> sendInvite)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetCreateUser/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = CSharpExpressionConverter.ConvertO(createIfNotFound);
            callPayload.Queries["GroupName"] = CSharpExpressionConverter.ConvertO(groupName);
            callPayload.Queries["sendInvite"] = CSharpExpressionConverter.ConvertO(sendInvite);
            return new ApiConnectionAction<GetCreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder(Expression<Func<string>> siteUrl, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> fileBase64)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateSaveStaticFileToFolder/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            return new ApiConnectionAction<SaveStaticFileToFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLink(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> scope, Expression<Func<int>> expireDays, Expression<Func<string>> createUser)
        {
            var apiCallPath = "/PowerAutomateCreateMagicLink";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["Scope"] = CSharpExpressionConverter.ConvertO(scope);
            callPayload.Queries["ExpireDays"] = CSharpExpressionConverter.ConvertO(expireDays);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateCreateQuestionnaire/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["WorkSpace"] = CSharpExpressionConverter.ConvertO(workSpace);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<CreateQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser)
        {
            var apiCallPath = "/DeleteAllShareLinksOnDocument";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowAddShare(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<string>> groupOrMail, Expression<Func<bool>> selectedQuestions = null)
        {
            var apiCallPath = "/AddShare";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            callPayload.Queries["GroupOrMail"] = CSharpExpressionConverter.ConvertO(groupOrMail);
            callPayload.Queries["SelectedQuestions"] = Convert.ToString(false);
            if (selectedQuestions != null)
                callPayload.Queries["SelectedQuestions"] = CSharpExpressionConverter.ConvertO(selectedQuestions);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowSetState(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> flowKey, Expression<Func<string>> state, Expression<Func<string>> createUser)
        {
            var apiCallPath = "/FlowSetState";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            callPayload.Queries["State"] = CSharpExpressionConverter.ConvertO(state);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateGetTagsForDocument/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["WorkSpace"] = CSharpExpressionConverter.ConvertO(workSpace);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> createUser, Expression<Func<string>> documentId = null)
        {
            var apiCallPath = "/PowerAutomateQuestionsWithTags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            if (documentId != null)
                callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<GetTagsForQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser, Expression<Func<string>> jsonData)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PowerAutomateDataModelCreateDoc/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["WorkSpace"] = CSharpExpressionConverter.ConvertO(workSpace);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            return new ApiConnectionAction<ProcessJsonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetFlowInformation(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/PowerAutomateGetFlowInformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<outputFormatInput>> outputFormat)
        {
            var apiCallPath = "/PowerAutomateGetDocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["DocumentId"] = CSharpExpressionConverter.ConvertO(documentId);
            callPayload.Queries["CreateUser"] = CSharpExpressionConverter.ConvertO(createUser);
            callPayload.Queries["OutputFormat"] = CSharpExpressionConverter.Convert(outputFormat);
            return new ApiConnectionAction<GetDocumentsResponse>(callPayload);
        }
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling(Expression<Func<string>> siteUrl, Expression<Func<string>> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/FlowWaitForSubmitPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["Scope"] = CSharpExpressionConverter.ConvertO(scope);
            return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/FlowTriggerPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = CSharpExpressionConverter.ConvertO(flowKey);
            callPayload.Queries["SiteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            return new ApiConnectionTrigger<FlowTriggerPollingResponse>(callPayload, triggerName, recurrence);
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