//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfoshareActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogonResponse, ApiConnectionActionConfiguration> Logon(Expression<Func<LogonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LogonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Logon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LogonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseTaskAndAssignToUsersResponse, ApiConnectionActionConfiguration> CloseTaskAndAssignToUsers(Expression<Func<CloseTaskAndAssignToUsersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CloseTaskAndAssignToUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CloseTaskAndAssignToUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CloseTaskAndAssignToUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogoffResponse, ApiConnectionActionConfiguration> Logoff(Expression<Func<LogoffBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LogoffResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Logoff";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LogoffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponseItem[], ApiConnectionActionConfiguration> GetDocumentProperties(Expression<Func<GetDocumentPropertiesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetDocumentPropertiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GetDocumentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetDocumentPropertiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetProcessPropertiesResponseItem[], ApiConnectionActionConfiguration> GetProcessProperties(Expression<Func<GetProcessPropertiesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetProcessPropertiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GetProcessProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetProcessPropertiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFileContent(Expression<Func<GetFileContentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GetFileContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseProcessResponse, ApiConnectionActionConfiguration> CloseProcess(Expression<Func<string>> archiveUrl, Expression<Func<CloseProcessBodyInput>> body)
        {
            var __workflow_archiveUrl = WorkflowExpression.Compile(archiveUrl, nameof(archiveUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CloseProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Process/CloseProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = ExpressionConverter.Convert(__workflow_archiveUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CloseProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogonWithHashedPasswordResponse, ApiConnectionActionConfiguration> LogonWithHashedPassword(Expression<Func<string>> archiveUrl, Expression<Func<LogonWithHashedPasswordBodyInput>> body)
        {
            var __workflow_archiveUrl = WorkflowExpression.Compile(archiveUrl, nameof(archiveUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LogonWithHashedPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Authentication/Logon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = ExpressionConverter.Convert(__workflow_archiveUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LogonWithHashedPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseTaskResponse, ApiConnectionActionConfiguration> CloseTask(Expression<Func<string>> archiveUrl, Expression<Func<CloseTaskBodyInput>> body)
        {
            var __workflow_archiveUrl = WorkflowExpression.Compile(archiveUrl, nameof(archiveUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CloseTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Process/CloseTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = ExpressionConverter.Convert(__workflow_archiveUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CloseTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> archiveUrl, Expression<Func<GetDocumentBodyInput>> body)
        {
            var __workflow_archiveUrl = WorkflowExpression.Compile(archiveUrl, nameof(archiveUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Document/GetDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = ExpressionConverter.Convert(__workflow_archiveUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetProcessResponse, ApiConnectionActionConfiguration> GetProcess(Expression<Func<string>> archiveUrl, Expression<Func<GetProcessBodyInput>> body)
        {
            var __workflow_archiveUrl = WorkflowExpression.Compile(archiveUrl, nameof(archiveUrl), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Process/GetProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = ExpressionConverter.Convert(__workflow_archiveUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFileContentConverted(Expression<Func<GetFileContentConvertedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GetFileContentConverted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CreateProcessResponse, ApiConnectionActionConfiguration> CreateProcess(Expression<Func<CreateProcessBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableGetRecordsResponse, ApiConnectionActionConfiguration> UserTableGetRecords(Expression<Func<UserTableGetRecordsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserTableGetRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UserTableGetRecords";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserTableGetRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableImportDataResponse, ApiConnectionActionConfiguration> UserTableImportData(Expression<Func<UserTableImportDataBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserTableImportDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UserTableImportData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserTableImportDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableCreateTableResponse, ApiConnectionActionConfiguration> UserTableCreateTable(Expression<Func<UserTableCreateTableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserTableCreateTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UserTableCreateTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserTableCreateTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableDeleteRecordsResponse, ApiConnectionActionConfiguration> UserTableDeleteRecords(Expression<Func<UserTableDeleteRecordsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserTableDeleteRecordsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UserTableDeleteRecords";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserTableDeleteRecordsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<MergePdfDocumentsToVersionResponse, ApiConnectionActionConfiguration> MergePdfDocumentsToVersion(Expression<Func<MergePdfDocumentsToVersionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MergePdfDocumentsToVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/MergePDFDocumentsToVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MergePdfDocumentsToVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<ProcessSearchResponse, ApiConnectionActionConfiguration> ProcessSearch(Expression<Func<ProcessSearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ProcessSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ProcessSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProcessSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableUpdateRowResponse, ApiConnectionActionConfiguration> UserTableUpdateRow(Expression<Func<UserTableUpdateRowBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UserTableUpdateRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UserTableUpdateRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserTableUpdateRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetSelectionResponse, ApiConnectionActionConfiguration> GetSelection(Expression<Func<GetSelectionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSelectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GetSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSelectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CreateDocumentResponse, ApiConnectionActionConfiguration> CreateDocument(Expression<Func<CreateDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CreateDocumentV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<DocumentSearchResponse, ApiConnectionActionConfiguration> DocumentSearch(Expression<Func<DocumentSearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DocumentSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/DocumentSearchV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DocumentSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UpdateDocumentResponse, ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<UpdateDocumentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateDocumentV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UpdateProcessResponse, ApiConnectionActionConfiguration> UpdateProcess(Expression<Func<UpdateProcessBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/UpdateProcessV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateProcessResponse>(callPayload);
            });
        }
    }

    public class InfoshareTriggers([ConnectionName] string connectionId)
    {
    }

    public class LogonResponse
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("connectionTimeoutSeconds")]
        public int ConnectionTimeoutSeconds { get; set; }

        [JsonProperty("isApplicationLicence")]
        public string IsApplicationLicence { get; set; }

        [JsonProperty("isConcurrentLicence")]
        public string IsConcurrentLicence { get; set; }

        [JsonProperty("isNamedLicence")]
        public string IsNamedLicence { get; set; }

        [JsonProperty("isVerificationCodeNeeded")]
        public string IsVerificationCodeNeeded { get; set; }

        [JsonProperty("possibleTwoWayAuthenticationType")]
        public string PossibleTwoWayAuthenticationType { get; set; }

        [JsonProperty("twoWayAuthenticationTargetMail")]
        public string TwoWayAuthenticationTargetMail { get; set; }
    }

    public class LogonBodyInput
    {
        public LogonBodyInput(string archiveUrl, string userName, string password)
        {
            this.ArchiveUrl = archiveUrl;
            this.UserName = userName;
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty("Username", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
        public string Tenantname { get; set; }
    }

    public class CloseTaskAndAssignToUsersResponse
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public CloseTaskAndAssignToUsersResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string[] IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CloseTaskAndAssignToUsersResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CloseTaskAndAssignToUsersBodyInput
    {
        public CloseTaskAndAssignToUsersBodyInput(string archiveUrl, string connectionId, string processId, string assignUserLoginNames)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
            this.AssignUserLoginNames = assignUserLoginNames;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
        public string TaskId { get; set; }
        public string Comment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssignUserLoginNames { get; set; }
    }

    public class LogoffResponse
    {
        public string LogoffResult { get; set; }
    }

    public class LogoffBodyInput
    {
        public LogoffBodyInput(string archiveUrl, string connectionId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }
    }

    public class GetDocumentPropertiesResponseItem
    {
        [JsonProperty("globalValues")]
        public GetDocumentPropertiesResponseItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetDocumentPropertiesResponseItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public GetDocumentPropertiesResponseItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetDocumentPropertiesResponseItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetDocumentPropertiesBodyInput
    {
        public GetDocumentPropertiesBodyInput(string archiveUrl, string connectionId, string documentId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public string Culture { get; set; }
    }

    public class GetProcessPropertiesResponseItem
    {
        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetProcessPropertiesBodyInput
    {
        public GetProcessPropertiesBodyInput(string archiveUrl, string connectionId, string processId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
        public string Culture { get; set; }
    }

    public class GetFileContentBodyInput
    {
        public GetFileContentBodyInput(string archiveUrl, string connectionId, string documentId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public string VersionId { get; set; }
        public string DocumentDataId { get; set; }
        public string RenditionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreHashValidation { get; set; } = true;
    }

    public class CloseProcessResponse
    {
        public CloseProcessResponseCloseProcessResultType CloseProcessResult { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultType
    {
        public string[] AccessRightsEnumList { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItem[] CompletedTasks { get; set; }
        public string CreatedDate { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCurrentTaskType CurrentTask { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public string[] DocumentIds { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public CloseProcessResponseCloseProcessResultTypeNameType Name { get; set; }
        public JToken[] PluginStream { get; set; }
        public string PriorityEnum { get; set; }
        public string ProcessTemplateId { get; set; }
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public int SessionCount { get; set; }
        public string StatusEnum { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItem
    {
        public string Action { get; set; }
        public JToken[] AssignedUserIds { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItemCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public JToken[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItemCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCurrentTaskType
    {
        public string Action { get; set; }
        public string[] AssignedUserIds { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCurrentTaskTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public string[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCurrentTaskTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCustomPropertiesTypeItem
    {
        public string CustomPropertyTypeEnum { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeNameType
    {
        public CloseProcessResponseCloseProcessResultTypeNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeNameTypeValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItem
    {
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class CloseProcessBodyInput
    {
        public CloseProcessBodyInput(string connectionId, string processId)
        {
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
        }

        [JsonProperty("connectionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty("processId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class LogonWithHashedPasswordResponse
    {
        public LogonWithHashedPasswordResponseLogonResultType LogonResult { get; set; }
    }

    public class LogonWithHashedPasswordResponseLogonResultType
    {
        public string ConnectionId { get; set; }
        public int ConnectionTimeoutSeconds { get; set; }
        public bool IsApplicationLicence { get; set; }
        public bool IsConcurrentLicence { get; set; }
        public bool IsNamedLicence { get; set; }
        public bool IsVerificationCodeNeeded { get; set; }

        [JsonProperty("JWTToken")]
        public string JwtToken { get; set; }
        public string PossibleTwoWayAuthenticationType { get; set; }
        public string TwoWayAuthenticationTargetMail { get; set; }
    }

    public class LogonWithHashedPasswordBodyInput
    {
        public LogonWithHashedPasswordBodyInput(string userName, string passwordHashed)
        {
            this.UserName = userName;
            this.PasswordHashed = passwordHashed;
        }

        [JsonProperty("userName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty("passwordHashed", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordHashed { get; set; }

        [JsonProperty("tenantName")]
        public string TenantName { get; set; }
    }

    public class CloseTaskResponse
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public CloseTaskResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedUserIds")]
        public string CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CloseTaskResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CloseTaskBodyInput
    {
        public CloseTaskBodyInput(string connectionId, string processId)
        {
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
        }

        [JsonProperty("connectionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty("processId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("assignUsers", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AssignUsers { get; set; } = true;
    }

    public class GetDocumentResponse
    {
        public GetDocumentResponseGetDocumentResultType GetDocumentResult { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultType
    {
        public GetDocumentResponseGetDocumentResultTypeAbonnementsTypeItem[] Abonnements { get; set; }
        public string[] AccessRightsEnumList { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerType AnnotationManager { get; set; }
        public GetDocumentResponseGetDocumentResultTypeBlogsTypeItem[] Blogs { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItem[] DocumentData { get; set; }
        public bool HasOverlay { get; set; }
        public string Id { get; set; }
        public string ImportTemplateId { get; set; }
        public string InfoStoreId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeLifeCycleManagerType LifeCycleManager { get; set; }
        public int MainFileLength { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeRemindersTypeItem[] Reminders { get; set; }
        public int SessionCount { get; set; }
        public string SigningProfileId { get; set; }
        public string VersionId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAbonnementsTypeItem
    {
        public bool OnContentChange { get; set; }
        public bool OnDelete { get; set; }
        public bool OnMetadataChange { get; set; }
        public string UserId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerType
    {
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItem[] PostItAnnotations { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeRectangleAnnotationsTypeItem[] RectangleAnnotations { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItem[] TextAnnotations { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItem
    {
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType FontInfo { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public string Text { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType
    {
        public bool IsItalic { get; set; }
        public bool IsStrikeOut { get; set; }
        public bool IsUnderline { get; set; }
        public string Name { get; set; }
        public int Pitch { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeRectangleAnnotationsTypeItem
    {
        public int Color { get; set; }
        public string ColorHexCode { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public int Height { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public bool Transparent { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItem
    {
        public int BackgroundColor { get; set; }
        public string BackgroundColorHexCode { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType FontInfo { get; set; }
        public int ForegroundColor { get; set; }
        public string ForegroundColorHexCode { get; set; }
        public int Height { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public int Rotation { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public string Text { get; set; }
        public bool Transparent { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType
    {
        public bool IsItalic { get; set; }
        public bool IsStrikeOut { get; set; }
        public bool IsUnderline { get; set; }
        public string Name { get; set; }
        public int Pitch { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeBlogsTypeItem
    {
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItem
    {
        public JToken[] ContentProtections { get; set; }
        public string Extension { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }
        public int[] HashValue { get; set; }
        public string Id { get; set; }
        public int PageCount { get; set; }
        public int Size { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        public string BlobPath { get; set; }
        public string BlobStoreId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeLifeCycleManagerType
    {
        public string CheckOutLifeCycleStateId { get; set; }
        public string LifeCycleEndDate { get; set; }
        public string LifeCycleStartDate { get; set; }
        public string LifeCycleStateId { get; set; }
        public string NextAutomaticLifeCycleStateId { get; set; }
        public string[] NextLifeCycleStates { get; set; }
        public GetDocumentResponseGetDocumentResultTypeLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
        public string LifeCycleId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        public bool DeleteAfterExpiration { get; set; }
        public string Id { get; set; }
        public bool ProtectAnnotationChange { get; set; }
        public bool ProtectCheckOut { get; set; }
        public bool ProtectContentChange { get; set; }
        public bool ProtectDelete { get; set; }
        public bool ProtectPropertyChange { get; set; }
        public bool ProtectProtectionDomainChange { get; set; }
        public int ProtectionDurationTicks { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItem
    {
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeRemindersTypeItem
    {
        public string Description { get; set; }
        public int Interval { get; set; }
        public string ProcessTemplateId { get; set; }
        public string ReminderDate { get; set; }
        public string ReminderId { get; set; }
        public JToken[] SubjectIds { get; set; }
        public bool UseUserFromProcessTemplate { get; set; }
    }

    public class GetDocumentBodyInput
    {
        public GetDocumentBodyInput(string connectionId, string documentId)
        {
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
        }

        [JsonProperty("connectionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class GetProcessResponse
    {
        public GetProcessResponseGetProcessResultType GetProcessResult { get; set; }
    }

    public class GetProcessResponseGetProcessResultType
    {
        public string[] AccessRightsEnumList { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public GetProcessResponseGetProcessResultTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public GetProcessResponseGetProcessResultTypeCompletedTasksTypeItem[] CompletedTasks { get; set; }
        public string CreatedDate { get; set; }
        public GetProcessResponseGetProcessResultTypeCurrentTaskType CurrentTask { get; set; }
        public GetProcessResponseGetProcessResultTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public string[] DocumentIds { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public GetProcessResponseGetProcessResultTypeNameType Name { get; set; }
        public JToken[] PluginStream { get; set; }
        public string PriorityEnum { get; set; }
        public string ProcessTemplateId { get; set; }
        public GetProcessResponseGetProcessResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public int SessionCount { get; set; }
        public string StatusEnum { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCompletedTasksTypeItem
    {
        public string Action { get; set; }
        public JToken[] AssignedUserIds { get; set; }
        public GetProcessResponseGetProcessResultTypeCompletedTasksTypeItemCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public JToken[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCompletedTasksTypeItemCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCurrentTaskType
    {
        public string Action { get; set; }
        public string[] AssignedUserIds { get; set; }
        public string[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public string[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCustomPropertiesTypeItem
    {
        public string CustomPropertyTypeEnum { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeNameType
    {
        public GetProcessResponseGetProcessResultTypeNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeNameTypeValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItem
    {
        public GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class GetProcessBodyInput
    {
        public GetProcessBodyInput(string connectionId, string processId)
        {
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
        }

        [JsonProperty("connectionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty("processId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
    }

    public class GetFileContentConvertedBodyInput
    {
        public GetFileContentConvertedBodyInput(string archiveUrl, string connectionId, string documentId, string targetFormat)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
            this.TargetFormat = targetFormat;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public string VersionId { get; set; }
        public string DocumentDataId { get; set; }
        public string RenditionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddAnnotatins { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddOverlay { get; set; } = true;
    }

    public class CreateProcessResponse
    {
        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("comments")]
        public CreateProcessResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedTasks")]
        public string[] CompletedTasks { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currentTask")]
        public CreateProcessResponseCurrentTaskType CurrentTask { get; set; }

        [JsonProperty("customProperties")]
        public CreateProcessResponseCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public CreateProcessResponseNameType Name { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("pluginStream")]
        public string PluginStream { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("properties")]
        public CreateProcessResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }
    }

    public class CreateProcessResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CreateProcessResponseCurrentTaskType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string[] IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CreateProcessResponseCustomPropertiesTypeItem
    {
        [JsonProperty("customPropertyTypeEnum")]
        public string CustomPropertyTypeEnum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateProcessResponseNameType
    {
        [JsonProperty("values")]
        public CreateProcessResponseNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class CreateProcessResponseNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItem
    {
        [JsonProperty("globalValues")]
        public CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateProcessBodyInput
    {
        public CreateProcessBodyInput(string archiveUrl, string connectionId, string processTemplateName)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.ProcessTemplateName = processTemplateName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }
        public string ProcessProperties { get; set; }
        public string CustomProperties { get; set; }
        public string DocumentIds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessTemplateName { get; set; }
        public string DueDate { get; set; }
        public BodyInputPriorityType? Priority { get; set; }
        public string Comment { get; set; }
        public string Culture { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPriorityType
    {
        Low,
        Normal,
        High
    }

    public class UserTableGetRecordsResponse
    {
        public string[][] UserTableGetRecordsResult { get; set; }
    }

    public class UserTableGetRecordsBodyInput
    {
        public UserTableGetRecordsBodyInput(string archiveUrl, string connectionId, string userTable)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.UserTable = userTable;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserTable { get; set; }
        public string WhereClause { get; set; }
        public string OrderByClause { get; set; }
        public bool? AddColumnHeaders { get; set; }
    }

    public class UserTableImportDataResponse
    {
        [JsonProperty("userTable")]
        public string UserTable { get; set; }

        [JsonProperty("insertedRows")]
        public int InsertedRows { get; set; }
    }

    public class UserTableImportDataBodyInput
    {
        public UserTableImportDataBodyInput(string archiveUrl, string connectionId, string userTable, string values)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.UserTable = userTable;
            this.Values = values;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Values { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteAllValues { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FirstRowContainsColumnHeaders { get; set; } = false;
    }

    public class UserTableCreateTableResponse
    {
        [JsonProperty("userTable")]
        public string UserTable { get; set; }
    }

    public class UserTableCreateTableBodyInput
    {
        public UserTableCreateTableBodyInput(string archiveUrl, string connectionId, string userTable, string columnHeaders)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.UserTable = userTable;
            this.ColumnHeaders = columnHeaders;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnHeaders { get; set; }
    }

    public class UserTableDeleteRecordsResponse
    {
        [JsonProperty("userTableDeleteRecordsResult")]
        public int UserTableDeleteRecordsResult { get; set; }
    }

    public class UserTableDeleteRecordsBodyInput
    {
        public UserTableDeleteRecordsBodyInput(string archiveUrl, string connectionId, string userTable)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.UserTable = userTable;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserTable { get; set; }
        public string WhereClause { get; set; }
    }

    public class MergePdfDocumentsToVersionResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("currentVersionId")]
        public string CurrentVersionId { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("properties")]
        public MergePdfDocumentsToVersionResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("blogs")]
        public MergePdfDocumentsToVersionResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("reminders")]
        public JToken[] Reminders { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("abonnements")]
        public JToken[] Abonnements { get; set; }

        [JsonProperty("annotationManager")]
        public MergePdfDocumentsToVersionResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("documentData")]
        public MergePdfDocumentsToVersionResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public MergePdfDocumentsToVersionResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }
    }

    public class MergePdfDocumentsToVersionResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public MergePdfDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class MergePdfDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public MergePdfDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class MergePdfDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseAnnotationManagerType
    {
        [JsonProperty("textAnnotations")]
        public JToken[] TextAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public JToken[] RectangleAnnotations { get; set; }

        [JsonProperty("postItAnnotations")]
        public JToken[] PostItAnnotations { get; set; }

        [JsonProperty("stampAnnotations")]
        public JToken[] StampAnnotations { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public MergePdfDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("files")]
        public MergePdfDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }

        [JsonProperty("pageCount")]
        public string PageCount { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("hashValue")]
        public int[] HashValue { get; set; }

        [JsonProperty("contentProtections")]
        public JToken[] ContentProtections { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        [JsonProperty("blobStoreId")]
        public string BlobStoreId { get; set; }

        [JsonProperty("blobPath")]
        public string BlobPath { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseLifeCycleManagerType
    {
        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public JToken[] NextLifeCycleStates { get; set; }

        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public MergePdfDocumentsToVersionResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
    }

    public class MergePdfDocumentsToVersionResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }
    }

    public class MergePdfDocumentsToVersionBodyInput
    {
        public MergePdfDocumentsToVersionBodyInput(string archiveUrl, string connectionId, string documentId, string documentIdToAppend)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
            this.DocumentIdToAppend = documentIdToAppend;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentIdToAppend { get; set; }
        public bool? ForceUndoCheckout { get; set; }
    }

    public class ProcessSearchResponse
    {
        [JsonProperty("processes")]
        public ProcessSearchResponseProcessesTypeItem[] Processes { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("resumePoint")]
        public string ResumePoint { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItem
    {
        [JsonProperty("name")]
        public ProcessSearchResponseProcessesTypeItemNameType Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("properties")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemNameType
    {
        [JsonProperty("values")]
        public ProcessSearchResponseProcessesTypeItemNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ProcessSearchBodyInput
    {
        public ProcessSearchBodyInput(string archiveUrl, string connectionId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }
        public string Conditions { get; set; }
        public string ResultProperties { get; set; }
        public string MaxSerchResults { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; } = "de";
    }

    public class UserTableUpdateRowResponse
    {
        [JsonProperty("userTableUpdateRowResult")]
        public int UserTableUpdateRowResult { get; set; }
    }

    public class UserTableUpdateRowBodyInput
    {
        public UserTableUpdateRowBodyInput(string archiveUrl, string connectionId, string userTable, string rowData)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.UserTable = userTable;
            this.RowData = rowData;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserTable { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RowData { get; set; }
    }

    public class GetSelectionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentObjectId")]
        public GetSelectionResponseParentObjectIdType ParentObjectId { get; set; }

        [JsonProperty("objectIds")]
        public GetSelectionResponseObjectIdsTypeItem[] ObjectIds { get; set; }

        [JsonProperty("allObjectIds")]
        public GetSelectionResponseAllObjectIdsTypeItem[] AllObjectIds { get; set; }
    }

    public class GetSelectionResponseParentObjectIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class GetSelectionResponseObjectIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class GetSelectionResponseAllObjectIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class GetSelectionBodyInput
    {
        public GetSelectionBodyInput(string archiveUrl, string connectionId, string selectionId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.SelectionId = selectionId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SelectionId { get; set; }
    }

    public class CreateDocumentResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("currentVersionId")]
        public string CurrentVersionId { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("properties")]
        public CreateDocumentResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("blogs")]
        public CreateDocumentResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("reminders")]
        public JToken[] Reminders { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("abonnements")]
        public JToken[] Abonnements { get; set; }

        [JsonProperty("annotationManager")]
        public CreateDocumentResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("documentData")]
        public CreateDocumentResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public CreateDocumentResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }
    }

    public class CreateDocumentResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public CreateDocumentResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class CreateDocumentResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public CreateDocumentResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CreateDocumentResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateDocumentResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDocumentResponseAnnotationManagerType
    {
        [JsonProperty("textAnnotations")]
        public JToken[] TextAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public JToken[] RectangleAnnotations { get; set; }

        [JsonProperty("postItAnnotations")]
        public JToken[] PostItAnnotations { get; set; }

        [JsonProperty("stampAnnotations")]
        public JToken[] StampAnnotations { get; set; }
    }

    public class CreateDocumentResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public CreateDocumentResponseDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class CreateDocumentResponseDocumentDataTypeItemRenditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("files")]
        public CreateDocumentResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }

        [JsonProperty("pageCount")]
        public string PageCount { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("hashValue")]
        public int[] HashValue { get; set; }

        [JsonProperty("contentProtections")]
        public JToken[] ContentProtections { get; set; }
    }

    public class CreateDocumentResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        [JsonProperty("blobStoreId")]
        public string BlobStoreId { get; set; }

        [JsonProperty("blobPath")]
        public string BlobPath { get; set; }
    }

    public class CreateDocumentResponseLifeCycleManagerType
    {
        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public JToken[] NextLifeCycleStates { get; set; }

        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public CreateDocumentResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
    }

    public class CreateDocumentResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }
    }

    public class CreateDocumentBodyInput
    {
        public CreateDocumentBodyInput(string archiveUrl, string connectionId, string documentTitle, string fileContent)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentTitle = documentTitle;
            this.FileContent = fileContent;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentTitle { get; set; }
        public string ImportTemplate { get; set; }
        public string DocumentProperties { get; set; }
        public string Blog { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; } = "de";
        public string InfoStore { get; set; }
        public string LifeCycle { get; set; }
        public string ProtectionDomain { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputUploadMethodType? UploadMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare.BodyInputUploadMethodType.UploadFileBytesLarge;
        public string OriginalFileFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ChunkSize { get; set; } = 262144;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputUploadMethodType
    {
        UploadFileBytesLarge,
        UploadStreamChunks,
        UploadStreamDirect,
        UploadFileBase64
    }

    public class DocumentSearchResponse
    {
        [JsonProperty("documents")]
        public DocumentSearchResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("resumePoint")]
        public string ResumePoint { get; set; }
    }

    public class DocumentSearchResponseDocumentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("properties")]
        public DocumentSearchResponseDocumentsTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }
    }

    public class DocumentSearchResponseDocumentsTypeItemPropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public DocumentSearchResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class DocumentSearchResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public DocumentSearchResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class DocumentSearchResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DocumentSearchBodyInput
    {
        public DocumentSearchBodyInput(string archiveUrl, string connectionId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }
        public string Conditions { get; set; }
        public string MaxSerchResults { get; set; }
        public string ResultProperties { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; } = "de";
        public string Stores { get; set; }
    }

    public class UpdateDocumentResponse
    {
        [JsonProperty("abonnements")]
        public UpdateDocumentResponseAbonnementsTypeItem[] Abonnements { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("annotationManager")]
        public UpdateDocumentResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("blogs")]
        public UpdateDocumentResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("documentData")]
        public UpdateDocumentResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public UpdateDocumentResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("properties")]
        public UpdateDocumentResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("reminders")]
        public UpdateDocumentResponseRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class UpdateDocumentResponseAbonnementsTypeItem
    {
        [JsonProperty("onContentChange")]
        public bool OnContentChange { get; set; }

        [JsonProperty("onDelete")]
        public bool OnDelete { get; set; }

        [JsonProperty("onMetadataChange")]
        public bool OnMetadataChange { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerType
    {
        [JsonProperty("postItAnnotations")]
        public UpdateDocumentResponseAnnotationManagerTypePostItAnnotationsTypeItem[] PostItAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public UpdateDocumentResponseAnnotationManagerTypeRectangleAnnotationsTypeItem[] RectangleAnnotations { get; set; }

        [JsonProperty("textAnnotations")]
        public UpdateDocumentResponseAnnotationManagerTypeTextAnnotationsTypeItem[] TextAnnotations { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerTypePostItAnnotationsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("fontInfo")]
        public UpdateDocumentResponseAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType FontInfo { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType
    {
        [JsonProperty("isItalic")]
        public bool IsItalic { get; set; }

        [JsonProperty("isStrikeOut")]
        public bool IsStrikeOut { get; set; }

        [JsonProperty("isUnderline")]
        public bool IsUnderline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pitch")]
        public int Pitch { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerTypeRectangleAnnotationsTypeItem
    {
        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("colorHexCode")]
        public string ColorHexCode { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("transparent")]
        public bool Transparent { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerTypeTextAnnotationsTypeItem
    {
        [JsonProperty("backgroundColor")]
        public int BackgroundColor { get; set; }

        [JsonProperty("backgroundColorHexCode")]
        public string BackgroundColorHexCode { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("fontInfo")]
        public UpdateDocumentResponseAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType FontInfo { get; set; }

        [JsonProperty("foregroundColor")]
        public int ForegroundColor { get; set; }

        [JsonProperty("foregroundColorHexCode")]
        public string ForegroundColorHexCode { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("transparent")]
        public bool Transparent { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentResponseAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType
    {
        [JsonProperty("isItalic")]
        public bool IsItalic { get; set; }

        [JsonProperty("isStrikeOut")]
        public bool IsStrikeOut { get; set; }

        [JsonProperty("isUnderline")]
        public bool IsUnderline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pitch")]
        public int Pitch { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class UpdateDocumentResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateDocumentResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public JToken[] Renditions { get; set; }
    }

    public class UpdateDocumentResponseLifeCycleManagerType
    {
        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public string[] NextLifeCycleStates { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public UpdateDocumentResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }

        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }
    }

    public class UpdateDocumentResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }
    }

    public class UpdateDocumentResponsePropertiesTypeItem
    {
        [JsonProperty("globalValues")]
        public UpdateDocumentResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class UpdateDocumentResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public UpdateDocumentResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class UpdateDocumentResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateDocumentResponseRemindersTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("reminderId")]
        public string ReminderId { get; set; }

        [JsonProperty("subjectIds")]
        public JToken[] SubjectIds { get; set; }

        [JsonProperty("useUserFromProcessTemplate")]
        public bool UseUserFromProcessTemplate { get; set; }
    }

    public class UpdateDocumentBodyInput
    {
        public UpdateDocumentBodyInput(string archiveUrl, string connectionId, string documentId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.DocumentId = documentId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentProperties { get; set; }
        public string RemoveDocumentProperties { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; } = "de";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public string ProtectionDomain { get; set; }
        public string Blog { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputUploadMethodType? UploadMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare.BodyInputUploadMethodType.UploadFileBytesLarge;
        public string FileContent { get; set; }
        public bool? ForceUndoCheckout { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ChunkSize { get; set; } = 262144;
    }

    public class UpdateProcessResponse
    {
        [JsonProperty("name")]
        public UpdateProcessResponseNameType Name { get; set; }

        [JsonProperty("description")]
        public UpdateProcessResponseDescriptionType Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("properties")]
        public UpdateProcessResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("pluginStream")]
        public string PluginStream { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("comments")]
        public UpdateProcessResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("customProperties")]
        public UpdateProcessResponseCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("currentTask")]
        public UpdateProcessResponseCurrentTaskType CurrentTask { get; set; }

        [JsonProperty("completedTasks")]
        public UpdateProcessResponseCompletedTasksTypeItem[] CompletedTasks { get; set; }

        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }
    }

    public class UpdateProcessResponseNameType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseDescriptionType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseDescriptionTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseDescriptionTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public UpdateProcessResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class UpdateProcessResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public UpdateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseCommentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseCustomPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("customPropertyTypeEnum")]
        public string CustomPropertyTypeEnum { get; set; }
    }

    public class UpdateProcessResponseCurrentTaskType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }

        [JsonProperty("comments")]
        public JToken[] Comments { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("intendedUserIds")]
        public JToken[] IntendedUserIds { get; set; }

        [JsonProperty("nameGlobal")]
        public UpdateProcessResponseCurrentTaskTypeNameGlobalType NameGlobal { get; set; }

        [JsonProperty("descriptionGlobal")]
        public UpdateProcessResponseCurrentTaskTypeDescriptionGlobalType DescriptionGlobal { get; set; }

        [JsonProperty("assignedUserCCIds")]
        public JToken[] AssignedUserCCIds { get; set; }

        [JsonProperty("deputyRepresentations")]
        public JToken[] DeputyRepresentations { get; set; }

        [JsonProperty("taskActionEnum")]
        public string TaskActionEnum { get; set; }
    }

    public class UpdateProcessResponseCurrentTaskTypeNameGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseCurrentTaskTypeNameGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseCurrentTaskTypeNameGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseCurrentTaskTypeDescriptionGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseCurrentTaskTypeDescriptionGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseCurrentTaskTypeDescriptionGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseCompletedTasksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }

        [JsonProperty("comments")]
        public JToken[] Comments { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("intendedUserIds")]
        public JToken[] IntendedUserIds { get; set; }

        [JsonProperty("nameGlobal")]
        public UpdateProcessResponseCompletedTasksTypeItemNameGlobalType NameGlobal { get; set; }

        [JsonProperty("descriptionGlobal")]
        public UpdateProcessResponseCompletedTasksTypeItemDescriptionGlobalType DescriptionGlobal { get; set; }

        [JsonProperty("assignedUserCCIds")]
        public JToken[] AssignedUserCCIds { get; set; }

        [JsonProperty("deputyRepresentations")]
        public JToken[] DeputyRepresentations { get; set; }

        [JsonProperty("taskActionEnum")]
        public string TaskActionEnum { get; set; }
    }

    public class UpdateProcessResponseCompletedTasksTypeItemNameGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseCompletedTasksTypeItemNameGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseCompletedTasksTypeItemNameGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessResponseCompletedTasksTypeItemDescriptionGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessResponseCompletedTasksTypeItemDescriptionGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessResponseCompletedTasksTypeItemDescriptionGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessBodyInput
    {
        public UpdateProcessBodyInput(string archiveUrl, string connectionId, string processId)
        {
            this.ArchiveUrl = archiveUrl;
            this.ConnectionId = connectionId;
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArchiveUrl { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConnectionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }
        public string ProcessProperties { get; set; }
        public string RemoveProcessProperties { get; set; }
        public string CustomProperties { get; set; }
        public string Comment { get; set; }
        public string AssignUserLoginNames { get; set; }
        public string AddDocumentIds { get; set; }
        public string RemoveDocumentIds { get; set; }
        public string DueDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPriorityType? Priority { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare.BodyInputPriorityType.Normal;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Culture { get; set; } = "de";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceUndoCheckout { get; set; } = true;
        public string ProtectionDomain { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare;

    public partial class WorkflowManagedActions
    {
        public InfoshareActions Infoshare(string connectionId) => new InfoshareActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfoshareTriggers Infoshare(string connectionId) => new InfoshareTriggers(connectionId);
    }
}