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
        public IBodyWorkflowAction<GetCreateWorkspaceResponse> GetCreateWorkspace([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<string> workspaceNameRoute, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> masterWorkSpace = null, [WorkflowExpression] Func<bool> copyStyling = null, [WorkflowExpression] Func<bool> copyFolders = null)
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
        public IBodyWorkflowAction<GetCreateFolderResponse> GetCreateFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> folderName, [WorkflowExpression] Func<string> parentId)
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
        public IBodyWorkflowAction<GetCreateGroupResponse> GetCreateGroup([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> role = null)
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
        public IBodyWorkflowAction<GetCreateAccessFolderResponse> GetCreateAccessFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupNamePath, [WorkflowExpression] Func<string> folderId)
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
        public IBodyWorkflowAction<GetCreateUserResponse> GetCreateUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<bool> createIfNotFound, [WorkflowExpression] Func<string> groupName, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> sendInvite)
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
        public IBodyWorkflowAction<SaveStaticFileToFolderResponse> SaveStaticFileToFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fileBase64)
        {
            var apiCallPath = String.Format("/PowerAutomateSaveStaticFileToFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<SaveStaticFileToFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<string> GetExternalShareLink([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> scope, [WorkflowExpression] Func<int> expireDays, [WorkflowExpression] Func<string> createUser)
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
        public IBodyWorkflowAction<CreateQuestionnaireResponse> CreateQuestionnaire([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
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
        public IBodyWorkflowAction<JToken> DeleteAllShareLinksOnDocument([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser)
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
        public IBodyWorkflowAction<JToken> FlowAddShare([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> groupOrMail, [WorkflowExpression] Func<bool> selectedQuestions = null)
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
        public IBodyWorkflowAction<JToken> FlowSetState([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> createUser)
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
        public IBodyWorkflowAction<JToken> GetVariablesForTemplate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser)
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
        public IBodyWorkflowAction<GetTagsForQuestionnaireResponse> GetTagsForQuestionnaire([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> documentId = null)
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
        public IBodyWorkflowAction<ProcessJsonResponse> ProcessJson([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> siteUrl, [WorkflowExpression] Func<string> workSpace, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<string> jsonData)
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
        public IBodyWorkflowAction<JToken> GetFlowInformation([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl)
        {
            var apiCallPath = "/PowerAutomateGetFlowInformation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "documentdrafter")]
        public IBodyWorkflowAction<GetDocumentsResponse> GetDocuments([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> createUser, [WorkflowExpression] Func<outputFormatInput> outputFormat)
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
        public IBodyWorkflowTrigger<TriggerSubmitPollingResponse> TriggerSubmitPolling([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> scope, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/FlowWaitForSubmitPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["Scope"] = ExpressionConverter.Convert(scope);
            return new ApiConnectionTrigger<TriggerSubmitPollingResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FlowTriggerPollingResponse> FlowTriggerPolling([WorkflowExpression] Func<string> flowKey, [WorkflowExpression] Func<string> siteUrl, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/FlowTriggerPolling";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FlowKey"] = ExpressionConverter.Convert(flowKey);
            callPayload.Queries["SiteUrl"] = ExpressionConverter.Convert(siteUrl);
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