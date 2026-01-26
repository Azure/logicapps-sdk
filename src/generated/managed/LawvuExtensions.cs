//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lawvu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LawvuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<int> ContractsUploadFile(Expression<Func<int>> contractId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodyconflictResolutionInput>> bodyconflictResolution, Expression<Func<int>> bodysubFolder = null)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/contracts-power-platform/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysubFolder != null)
            {
                body["folderId"] = ExpressionConverter.ConvertO(bodysubFolder);
                bodypropCount++;
            }

            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["fileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            bodypropCount++;
            body["conflictResolution"] = ExpressionConverter.ConvertO(bodyconflictResolution);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiContractsV1InternalModelsContractKeyDateModel[]> ContractsGetKeyDates(Expression<Func<int>> contractId)
        {
            var apiCallPath = String.Format("/contract-apis/v1/contracts/{0}/keyDates", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPublicApiContractsV1InternalModelsContractKeyDateModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<int> ContractsCreateByWizard(Expression<Func<int>> bodycontractTemplate, Expression<Func<object>> bodycontractTemplate, Expression<Func<string>> bodyname, Expression<Func<int>> bodymatter = null, Expression<Func<int>> bodyparentContract = null, Expression<Func<string>> bodyexternalIdentifier = null, Expression<Func<int>> bodyteams = null)
        {
            var apiCallPath = "/power-platform-apis/v1/contracts-power-platform/wizard";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contractTemplateId"] = ExpressionConverter.ConvertO(bodycontractTemplate);
            if (bodymatter != null)
            {
                body["matterId"] = ExpressionConverter.ConvertO(bodymatter);
                bodypropCount++;
            }

            if (bodyparentContract != null)
            {
                body["parentContractId"] = ExpressionConverter.ConvertO(bodyparentContract);
                bodypropCount++;
            }

            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodycontractTemplate);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyexternalIdentifier != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalIdentifier);
                bodypropCount++;
            }

            if (bodyteams != null)
            {
                body["teamId"] = ExpressionConverter.ConvertO(bodyteams);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<int> ContractsCreateByUpload(Expression<Func<int>> bodycontractTemplate, Expression<Func<object>> bodycontractTemplate, Expression<Func<string>> bodyname, Expression<Func<string>> bodycontractFile, Expression<Func<string>> bodycontractFileName, Expression<Func<int>> bodymatter = null, Expression<Func<int>> bodyparentContract = null, Expression<Func<string>> bodyexternalIdentifier = null, Expression<Func<int>> bodyteams = null)
        {
            var apiCallPath = "/power-platform-apis/v1/contracts-power-platform";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contractTemplateId"] = ExpressionConverter.ConvertO(bodycontractTemplate);
            if (bodymatter != null)
            {
                body["matterId"] = ExpressionConverter.ConvertO(bodymatter);
                bodypropCount++;
            }

            if (bodyparentContract != null)
            {
                body["parentContractId"] = ExpressionConverter.ConvertO(bodyparentContract);
                bodypropCount++;
            }

            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodycontractTemplate);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodyexternalIdentifier != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalIdentifier);
                bodypropCount++;
            }

            if (bodyteams != null)
            {
                body["teamId"] = ExpressionConverter.ConvertO(bodyteams);
                bodypropCount++;
            }

            bodypropCount++;
            body["contractFile"] = ExpressionConverter.ConvertO(bodycontractFile);
            bodypropCount++;
            body["contractFileName"] = ExpressionConverter.ConvertO(bodycontractFileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPowerPlatformMiddlewareApiModelClientModelsContract> ContractsGetContract(Expression<Func<int>> contractId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/contracts-power-platform/{0}", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPowerPlatformMiddlewareApiModelClientModelsContract>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction PowerPlatformContractFieldsUpdate(Expression<Func<int>> contractId, Expression<Func<string>> bodyfield, Expression<Func<object>> bodynewValue)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/contracts-power-platform/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fieldId"] = ExpressionConverter.ConvertO(bodyfield);
            bodypropCount++;
            body["newValue"] = ExpressionConverter.ConvertO(bodynewValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction ContractsAddStatusMessage(Expression<Func<int>> contractId, Expression<Func<string>> bodystatusMessage)
        {
            var apiCallPath = String.Format("/contract-apis/v1/contracts/{0}/statusMessages", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["statusMessage"] = ExpressionConverter.ConvertO(bodystatusMessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiContractsV1ClientModelsContractUser[]> PowerPlatformContractsGetContractUsers(Expression<Func<int>> contractId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/contracts-power-platform/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPublicApiContractsV1ClientModelsContractUser[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction ContractsAddContractUser(Expression<Func<int>> contractId, Expression<Func<string>> bodyuser)
        {
            var apiCallPath = String.Format("/contract-apis/v1/contracts/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(contractId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userId"] = ExpressionConverter.ConvertO(bodyuser);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<string> PowerPlatformFilesGetFileContent(Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/files-power-platform/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPowerPlatformMiddlewareApiModelClientModelsFileDetail> PowerPlatformFilesGetFile(Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/files-power-platform/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPowerPlatformMiddlewareApiModelClientModelsFileDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiFilesV1ClientModelsFileListItem[]> PowerPlatformFilesGetFiles(Expression<Func<getfilesFilesparentrecordtypeInput>> getfilesFilesparentrecordtype, Expression<Func<int>> getfilesRecordid, Expression<Func<bool>> getfilesRecursive, Expression<Func<int>> getfilesParentfolderid = null)
        {
            var apiCallPath = "/power-platform-apis/v1/files-power-platform";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["getfiles.filesparentrecordtype"] = ExpressionConverter.Convert(getfilesFilesparentrecordtype);
            callPayload.Queries["getfiles.recordid"] = ExpressionConverter.Convert(getfilesRecordid);
            callPayload.Queries["getfiles.recursive"] = ExpressionConverter.Convert(getfilesRecursive);
            if (getfilesParentfolderid != null)
                callPayload.Queries["getfiles.parentfolderid"] = ExpressionConverter.Convert(getfilesParentfolderid);
            return new ApiConnectionAction<LawVuPublicApiFilesV1ClientModelsFileListItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPowerPlatformMiddlewareApiModelClientModelsDownloadFile> PowerPlatformFilesGetFileDownload(Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/files-power-platform/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPowerPlatformMiddlewareApiModelClientModelsDownloadFile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiFilesV1ClientModelsFolderModel[]> PowerPlatformFilesGetFolders(Expression<Func<int>> recordId, Expression<Func<recordTypeInput>> recordType, Expression<Func<int>> parentFolderId = null)
        {
            var apiCallPath = "/file-apis/v1/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            callPayload.Queries["recordType"] = ExpressionConverter.Convert(recordType);
            if (parentFolderId != null)
                callPayload.Queries["parentFolderId"] = ExpressionConverter.Convert(parentFolderId);
            return new ApiConnectionAction<LawVuPublicApiFilesV1ClientModelsFolderModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<int> MattersUploadFile(Expression<Func<int>> matterId, Expression<Func<string>> bodyfileName, Expression<Func<string>> bodyfileContent, Expression<Func<bodyconflictResolutionInput>> bodyconflictResolution, Expression<Func<int>> bodysubFolder = null)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/matters-power-platform/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysubFolder != null)
            {
                body["folderId"] = ExpressionConverter.ConvertO(bodysubFolder);
                bodypropCount++;
            }

            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["fileContent"] = ExpressionConverter.ConvertO(bodyfileContent);
            bodypropCount++;
            body["conflictResolution"] = ExpressionConverter.ConvertO(bodyconflictResolution);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPowerPlatformMiddlewareApiModelClientModelsMatter> PowerPlatformMattersGetMatter(Expression<Func<int>> matterId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/matters-power-platform/{0}", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPowerPlatformMiddlewareApiModelClientModelsMatter>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<int> MattersCreateMatter(Expression<Func<int>> bodymatterType, Expression<Func<object>> bodymatterType, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyrestricted = null, Expression<Func<bool>> bodyurgent = null, Expression<Func<int>> bodyparentMatterID = null, Expression<Func<string>> bodymanager = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyexternalID = null, Expression<Func<int>> bodyteam = null)
        {
            var apiCallPath = "/power-platform-apis/v1/matters-power-platform";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            bodypropCount++;
            body["categoryId"] = ExpressionConverter.ConvertO(bodymatterType);
            bodypropCount++;
            body["fields"] = ExpressionConverter.ConvertO(bodymatterType);
            if (bodyrestricted != null)
            {
                body["restricted"] = ExpressionConverter.ConvertO(bodyrestricted);
                bodypropCount++;
            }

            if (bodyurgent != null)
            {
                body["urgent"] = ExpressionConverter.ConvertO(bodyurgent);
                bodypropCount++;
            }

            if (bodyparentMatterID != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentMatterID);
                bodypropCount++;
            }

            if (bodymanager != null)
            {
                body["managerId"] = ExpressionConverter.ConvertO(bodymanager);
                bodypropCount++;
            }

            if (bodyowner != null)
            {
                body["ownerId"] = ExpressionConverter.ConvertO(bodyowner);
                bodypropCount++;
            }

            if (bodyexternalID != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalID);
                bodypropCount++;
            }

            if (bodyteam != null)
            {
                body["teamId"] = ExpressionConverter.ConvertO(bodyteam);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<int>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiMattersV1ClientModelsMatterUser[]> PowerPlatformMattersGetMatterUsers(Expression<Func<int>> matterId)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/matters-power-platform/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPublicApiMattersV1ClientModelsMatterUser[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction PowerPlatformMatterFieldsUpdate(Expression<Func<int>> matterId, Expression<Func<string>> bodyfield, Expression<Func<object>> bodynewValue)
        {
            var apiCallPath = String.Format("/power-platform-apis/v1/matters-power-platform/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fieldId"] = ExpressionConverter.ConvertO(bodyfield);
            bodypropCount++;
            body["newValue"] = ExpressionConverter.ConvertO(bodynewValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction MattersAddMatterUser(Expression<Func<int>> matterId, Expression<Func<string>> bodyuser, Expression<Func<bodyassignmentInput>> bodyassignment)
        {
            var apiCallPath = String.Format("/matter-apis/v1/matters/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userId"] = ExpressionConverter.ConvertO(bodyuser);
            bodypropCount++;
            body["target"] = ExpressionConverter.ConvertO(bodyassignment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction MattersAddStatusMessage(Expression<Func<int>> matterId, Expression<Func<string>> bodystatusMessage)
        {
            var apiCallPath = String.Format("/matter-apis/v1/matters/{0}/statusMessages", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["statusMessage"] = ExpressionConverter.ConvertO(bodystatusMessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiMattersV1ClientModelsTaskTemplates[]> MattersGetTaskTemplates()
        {
            var apiCallPath = "/matter-apis/v1/matters/tasktemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPublicApiMattersV1ClientModelsTaskTemplates[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IWorkflowAction MattersAddTaskTemplate(Expression<Func<int>> matterId, Expression<Func<int>> bodytaskTemplate)
        {
            var apiCallPath = String.Format("/matter-apis/v1/matters/{0}/taskTemplates", ExpressionConverter.ConvertWithUrlEncoding(matterId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["templateId"] = ExpressionConverter.ConvertO(bodytaskTemplate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiAccountsV1ClientModelsTeam[]> TeamsGet()
        {
            var apiCallPath = "/account-apis/v1/teams";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["allowAssigment"] = Convert.ToString(false);
            return new ApiConnectionAction<LawVuPublicApiAccountsV1ClientModelsTeam[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiAccountsV1ClientModelsUser[]> UsersGet(Expression<Func<string>> filterSearch = null)
        {
            var apiCallPath = "/account-apis/v1/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filterSearch != null)
                callPayload.Queries["filter.search"] = ExpressionConverter.Convert(filterSearch);
            return new ApiConnectionAction<LawVuPublicApiAccountsV1ClientModelsUser[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lawvu")]
        public IBodyWorkflowAction<LawVuPublicApiAccountsV1ClientModelsUserProfile> UsersGetProfile(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/account-apis/v1/users/{0}/profile", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LawVuPublicApiAccountsV1ClientModelsUserProfile>(callPayload);
        }
    }

    public class LawvuTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterStatusUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-status-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractStatusUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-status-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterFileCreatedOrUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-file-created-or-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractFileCreatedOrUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-file-created-or-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractDocumentUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-document-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterTagCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-tag-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionMatterStatusMessageCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/matter-status-message-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractStatusMessageCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-status-message-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractKeyDateCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-key-date-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<int> TriggersCreateSubscriptionContractKeyDateUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/account-apis/v1/webhooks/subscriptions/contract-key-date-updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["subscriptionUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<int>(callPayload, triggerName, recurrence);
        }
    }

    public enum bodyconflictResolutionInput
    {
        Replace,
        KeepBoth,
        SaveVersion,
        Skip
    }

    public class LawVuPublicApiContractsV1InternalModelsContractKeyDateModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsContract
    {
        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsContractStatusType Status { get; set; }

        [JsonProperty("category")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsContractCategoryType Category { get; set; }

        [JsonProperty("templateId")]
        public int TemplateID { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdByUserId")]
        public string CreatedByUserID { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerID { get; set; }

        [JsonProperty("matterId")]
        public int MatterID { get; set; }

        [JsonProperty("matterName")]
        public string MatterName { get; set; }

        [JsonProperty("matterNumber")]
        public string MatterNumber { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUtc { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("hasSow")]
        public bool HasSow { get; set; }

        [JsonProperty("parentContractId")]
        public int ParentContractID { get; set; }

        [JsonProperty("documentFileId")]
        public int DocumentFileID { get; set; }

        [JsonProperty("parentIsRestricted")]
        public bool ParentIsRestricted { get; set; }

        [JsonProperty("onContract")]
        public bool OnContract { get; set; }

        [JsonProperty("onMatter")]
        public bool OnMatter { get; set; }

        [JsonProperty("contractSpecificEmail")]
        public string ContractSpecificEmail { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("teamId")]
        public int TeamID { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

        [JsonProperty("lastStatusMessage")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsContractLastStatusMessage LastStatusMessage { get; set; }

        [JsonProperty("owner")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsContractOwner Owner { get; set; }

        [JsonProperty("executedDateUtc")]
        public string ExecutedDateUtc { get; set; }
    }

    public enum LawVuPowerPlatformMiddlewareApiModelClientModelsContractStatusType
    {
        Draft,
        Negotiating,
        Approval,
        Signing,
        Executed,
        Expired,
        Void
    }

    public enum LawVuPowerPlatformMiddlewareApiModelClientModelsContractCategoryType
    {
        Sales,
        Purchasing,
        Commercial
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsContractLastStatusMessage
    {
        [JsonProperty("message")]
        public string LastStatusMessageMessage { get; set; }

        [JsonProperty("createdDateUtc")]
        public string LastStatusMessageCreatedDateUtc { get; set; }

        [JsonProperty("userId")]
        public string LastStatusMessageUserID { get; set; }

        [JsonProperty("userFirstname")]
        public string LastStatusMessageUserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string LastStatusMessageUserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int LastStatusMessageUserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string LastStatusMessageUserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string LastStatusMessageUserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string LastStatusMessageUserInitials { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsContractOwner
    {
        [JsonProperty("userId")]
        public string OwnerUserID { get; set; }

        [JsonProperty("userFirstname")]
        public string OwnerUserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string OwnerUserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int OwnerUserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string OwnerUserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string OwnerUserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string OwnerUserInitials { get; set; }
    }

    public class LawVuPublicApiContractsV1ClientModelsContractUser
    {
        [JsonProperty("userId")]
        public string UserID { get; set; }

        [JsonProperty("userFirstname")]
        public string UserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string UserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int UserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string UserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string UserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string UserInitials { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsFileDetail
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUTC { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("uploadedBy")]
        public string UploadedBy { get; set; }

        [JsonProperty("documentId")]
        public string DocumentID { get; set; }
    }

    public class LawVuPublicApiFilesV1ClientModelsFileListItem
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("type")]
        public LawVuPublicApiFilesV1ClientModelsFileListItemTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("uploadedDateUtc")]
        public string UploadedDateUTC { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("uploadedBy")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploadedByOrganisation")]
        public string UploadedByOrganisation { get; set; }

        [JsonProperty("fileModifiedDateUtc")]
        public string FileModifiedDateUtc { get; set; }

        [JsonProperty("documentId")]
        public string DocumentID { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public enum LawVuPublicApiFilesV1ClientModelsFileListItemTypeType
    {
        Folder,
        File
    }

    public enum getfilesFilesparentrecordtypeInput
    {
        Matter,
        Contract
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsDownloadFile
    {
        [JsonProperty("downloadLink")]
        public string DownloadLink { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }
    }

    public class LawVuPublicApiFilesV1ClientModelsFolderModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum recordTypeInput
    {
        Matter,
        Milestone,
        [EnumMember(Value = "Task")]
        TaskObject,
        Organisation,
        Contract,
        File,
        InvoiceBatch,
        KnowledgeArticle,
        Folder,
        FolderTemplate,
        KnowledgeLibrary,
        InboundEmail,
        User,
        MessageThread,
        TimelineEntry,
        MatterStatus,
        ContractStatus,
        Message,
        Comment
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsMatter
    {
        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("matterTypeName")]
        public string MatterType { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("statusId")]
        public int StatusID { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("matterNumber")]
        public string MatterNumber { get; set; }

        [JsonProperty("matterUrl")]
        public string MatterUrl { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUtc { get; set; }

        [JsonProperty("managerOrganisationId")]
        public int ManagerOrganisationID { get; set; }

        [JsonProperty("owner")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsMatterOwner Owner { get; set; }

        [JsonProperty("manager")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsMatterManager Manager { get; set; }

        [JsonProperty("organisationId")]
        public int OrganisationID { get; set; }

        [JsonProperty("organisationName")]
        public string OrganisationName { get; set; }

        [JsonProperty("lastStatusMessage")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsMatterLastStatusMessage LastStatusMessage { get; set; }

        [JsonProperty("terms")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsMatterTerms Terms { get; set; }

        [JsonProperty("matterSpecificEmail")]
        public string MatterSpecificEmail { get; set; }

        [JsonProperty("tags")]
        public LawVuPublicApiMattersV1InternalModelsMatterTagModel[] Tags { get; set; }

        [JsonProperty("categoryId")]
        public int MatterTypeID { get; set; }

        [JsonProperty("externalId")]
        public string ExternalID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentId")]
        public int ParentID { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("teamId")]
        public int TeamID { get; set; }

        [JsonProperty("urgent")]
        public bool Urgent { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsMatterOwner
    {
        [JsonProperty("userId")]
        public string OwnerUserID { get; set; }

        [JsonProperty("userFirstname")]
        public string OwnerUserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string OwnerUserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int OwnerUserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string OwnerUserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string OwnerUserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string OwnerUserInitials { get; set; }

        [JsonProperty("permissions")]
        public int[] OwnerPermissions { get; set; }

        [JsonProperty("isDelegateOwner")]
        public bool OwnerIsDelegateOwner { get; set; }

        [JsonProperty("isDelegateManager")]
        public bool OwnerIsDelegateManager { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsMatterManager
    {
        [JsonProperty("userId")]
        public string ManagerUserID { get; set; }

        [JsonProperty("userFirstname")]
        public string ManagerUserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string ManagerUserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int ManagerUserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string ManagerUserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string ManagerUserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string ManagerUserInitials { get; set; }

        [JsonProperty("permissions")]
        public int[] ManagerPermissions { get; set; }

        [JsonProperty("isDelegateOwner")]
        public bool ManagerIsDelegateOwner { get; set; }

        [JsonProperty("isDelegateManager")]
        public bool ManagerIsDelegateManager { get; set; }
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsMatterLastStatusMessage
    {
        [JsonProperty("message")]
        public string LastStatusMessageMessage { get; set; }

        [JsonProperty("createdDateUtc")]
        public string LastStatusMessageCreatedDateUtc { get; set; }

        [JsonProperty("id")]
        public int LastStatusMessageID { get; set; }

        [JsonProperty("userId")]
        public string LastStatusMessageUserID { get; set; }

        [JsonProperty("userFirstname")]
        public string LastStatusMessageUserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string LastStatusMessageUserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int LastStatusMessageUserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string LastStatusMessageUserOrganisationName { get; set; }

        [JsonProperty("role")]
        public LawVuPowerPlatformMiddlewareApiModelClientModelsMatterLastStatusMessageLastStatusMessageRoleType LastStatusMessageRole { get; set; }

        [JsonProperty("userFullName")]
        public string LastStatusMessageUserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string LastStatusMessageUserInitials { get; set; }
    }

    public enum LawVuPowerPlatformMiddlewareApiModelClientModelsMatterLastStatusMessageLastStatusMessageRoleType
    {
        Administrator,
        InhouseLegal,
        Contributor,
        Standard,
        External,
        MatterManager
    }

    public class LawVuPowerPlatformMiddlewareApiModelClientModelsMatterTerms
    {
        [JsonProperty("fileId")]
        public int TermsFileID { get; set; }

        [JsonProperty("code")]
        public string TermsCode { get; set; }

        [JsonProperty("fileName")]
        public string TermsFileName { get; set; }
    }

    public class LawVuPublicApiMattersV1InternalModelsMatterTagModel
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LawVuPublicApiMattersV1ClientModelsMatterUser
    {
        [JsonProperty("userId")]
        public string UserID { get; set; }

        [JsonProperty("userFirstname")]
        public string UserFirstname { get; set; }

        [JsonProperty("userLastname")]
        public string UserLastname { get; set; }

        [JsonProperty("userOrganisationId")]
        public int UserOrganisationID { get; set; }

        [JsonProperty("userOrganisationName")]
        public string UserOrganisationName { get; set; }

        [JsonProperty("userFullName")]
        public string UserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string UserInitials { get; set; }

        [JsonProperty("permissions")]
        public int[] Permissions { get; set; }

        [JsonProperty("isDelegateOwner")]
        public bool IsDelegateOwner { get; set; }

        [JsonProperty("isDelegateManager")]
        public bool IsDelegateManager { get; set; }
    }

    public enum bodyassignmentInput
    {
        [EnumMember(Value = "Matter")]
        Member,
        [EnumMember(Value = "MatterOwner")]
        Owner,
        [EnumMember(Value = "MatterManager")]
        Manager
    }

    public class LawVuPublicApiMattersV1ClientModelsTaskTemplates
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUTC { get; set; }
    }

    public class LawVuPublicApiAccountsV1ClientModelsTeam
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LawVuPublicApiAccountsV1ClientModelsUser
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisationName")]
        public string OrganisationName { get; set; }

        [JsonProperty("directPhone")]
        public string DirectPhone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hasPicture")]
        public bool HasPicture { get; set; }

        [JsonProperty("invitationSentUtc")]
        public string InvitationSentUtc { get; set; }

        [JsonProperty("userFullName")]
        public string UserFullName { get; set; }

        [JsonProperty("userInitials")]
        public string UserInitials { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("hourlyRate")]
        public double HourlyRate { get; set; }
    }

    public class LawVuPublicApiAccountsV1ClientModelsUserProfile
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("directPhone")]
        public string DirectPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("departmentId")]
        public int DepartmentID { get; set; }

        [JsonProperty("specialityIds")]
        public int[] SpecialityIds { get; set; }

        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("linkedInUrl")]
        public string LinkedInUrl { get; set; }

        [JsonProperty("organisationId")]
        public int OrganisationID { get; set; }

        [JsonProperty("organisationName")]
        public string OrganisationName { get; set; }

        [JsonProperty("organisationType")]
        public LawVuPublicApiAccountsV1ClientModelsUserProfileOrganisationTypeType OrganisationType { get; set; }

        [JsonProperty("role")]
        public LawVuPublicApiAccountsV1ClientModelsUserProfileRoleType Role { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("invitationSentUtc")]
        public string InvitationSentUtc { get; set; }

        [JsonProperty("status")]
        public LawVuPublicApiAccountsV1ClientModelsUserProfileStatusType Status { get; set; }
    }

    public enum LawVuPublicApiAccountsV1ClientModelsUserProfileOrganisationTypeType
    {
        ServiceProvider,
        Customer
    }

    public enum LawVuPublicApiAccountsV1ClientModelsUserProfileRoleType
    {
        Administrator,
        InhouseLegal,
        Contributor,
        Standard,
        External,
        MatterManager
    }

    public enum LawVuPublicApiAccountsV1ClientModelsUserProfileStatusType
    {
        Pending,
        Active,
        Invited,
        LockedOut,
        Disabled
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lawvu;

    public partial class WorkflowManagedActions
    {
        public LawvuActions Lawvu(string connectionId) => new LawvuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LawvuTriggers Lawvu(string connectionId) => new LawvuTriggers(connectionId);
    }
}