//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Documentdrafter
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
            var apiCallPath = String.Format("/PowerAutomateGetCreateWorkspace/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceNameRoute, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> folderName, Expression<Func<string>> parentId)
        {
            var apiCallPath = String.Format("/PowerAutomateGetCreateFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
            callPayload.Queries["ParentId"] = ExpressionConverter.Convert(parentId);
            return new ApiConnectionAction<GetCreateFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> role = null)
        {
            var apiCallPath = String.Format("/PowerAutomateGetCreateGroup/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupNamePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
            if (role != null)
                callPayload.Queries["Role"] = ExpressionConverter.Convert(role);
            return new ApiConnectionAction<GetCreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupNamePath, Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/PowerAutomateGetCreateAccessFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupNamePath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
            callPayload.Queries["FolderId"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionAction<GetCreateAccessFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser(Expression<Func<string>> siteUrl, Expression<Func<bool>> createIfNotFound, Expression<Func<string>> groupName, Expression<Func<string>> email, Expression<Func<bool>> sendInvite)
        {
            var apiCallPath = String.Format("/PowerAutomateGetCreateUser/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["CreateIfNotFound"] = ExpressionConverter.Convert(createIfNotFound);
            callPayload.Queries["GroupName"] = ExpressionConverter.Convert(groupName);
            callPayload.Queries["sendInvite"] = ExpressionConverter.Convert(sendInvite);
            return new ApiConnectionAction<GetCreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder(Expression<Func<string>> siteUrl, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> fileBase64)
        {
            var apiCallPath = String.Format("/PowerAutomateSaveStaticFileToFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<SaveStaticFileToFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLink(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> scope, Expression<Func<int>> expireDays, Expression<Func<string>> createUser)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLinkV2(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> email, Expression<Func<string>> createUser)
        {
            var apiCallPath = "/PowerAutomateCreateMagicLinkV2";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
            callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var apiCallPath = String.Format("/PowerAutomateCreateQuestionnaire/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<CreateQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser)
        {
            var apiCallPath = "/DeleteAllShareLinksOnDocument";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowAddShare(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<string>> groupOrMail, Expression<Func<bool>> selectedQuestions = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> FlowSetState(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> flowKey, Expression<Func<string>> state, Expression<Func<string>> createUser)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser)
        {
            var apiCallPath = String.Format("/PowerAutomateGetTagsForDocument/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
            callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire(Expression<Func<string>> siteUrl, Expression<Func<string>> createUser, Expression<Func<string>> documentId = null)
        {
            var apiCallPath = "/PowerAutomateQuestionsWithTags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            if (documentId != null)
                callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<GetTagsForQuestionnaireResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson(Expression<Func<string>> siteUrl, Expression<Func<string>> workSpace, Expression<Func<string>> templateId, Expression<Func<string>> createUser, Expression<Func<string>> jsonData)
        {
            var apiCallPath = String.Format("/PowerAutomateDataModelCreateDoc/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["WorkSpace"] = ExpressionConverter.Convert(workSpace);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            return new ApiConnectionAction<ProcessJsonResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<JToken> GetFlowInformation(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/PowerAutomateGetFlowInformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments(Expression<Func<string>> siteUrl, Expression<Func<string>> documentId, Expression<Func<string>> createUser, Expression<Func<outputFormatInput>> outputFormat)
        {
            var apiCallPath = "/PowerAutomateGetDocument";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["DocumentId"] = ExpressionConverter.Convert(documentId);
            callPayload.Queries["CreateUser"] = ExpressionConverter.Convert(createUser);
            callPayload.Queries["OutputFormat"] = ExpressionConverter.Convert(outputFormat);
            return new ApiConnectionAction<GetDocumentsResponse>(callPayload);
        }
    }

    public class DocumentdrafterTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling(Expression<Func<string>> siteUrl, Expression<Func<string>> scope)
        {
            var apiCallPath = "/FlowWaitForSubmitPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["Scope"] = ExpressionConverter.Convert(scope);
            return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling(Expression<Func<string>> flowKey, Expression<Func<string>> siteUrl)
        {
            var apiCallPath = "/FlowTriggerPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionTrigger<FlowTriggerPollingResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Documentdrafter;

    public partial class WorkflowManagedActions
    {
        public DocumentdrafterActions Documentdrafter(string connectionId) => new DocumentdrafterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocumentdrafterTriggers Documentdrafter(string connectionId) => new DocumentdrafterTriggers(connectionId);
    }
}