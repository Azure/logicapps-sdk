//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Keepersecretsmanager
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KeepersecretsmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<SecretSummary[], ApiConnectionActionConfiguration> ListSecrets()
        {
            return new DeferredBodyAction<SecretSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<CreateSecretResponse, ApiConnectionActionConfiguration> CreateSecret(Expression<Func<CreateSecretInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<SecretDetail, ApiConnectionActionConfiguration> GetSecret(Expression<Func<string>> uid)
        {
            var __workflow_uid = WorkflowExpression.Compile(uid, nameof(uid), required: true);
            return new DeferredBodyAction<SecretDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/secrets/{0}", __workflow_uid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SecretDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<UpdateSecretResponse, ApiConnectionActionConfiguration> UpdateSecret(Expression<Func<string>> uid, Expression<Func<UpdateSecretInput>> body)
        {
            var __workflow_uid = WorkflowExpression.Compile(uid, nameof(uid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/secrets/{0}", __workflow_uid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<Folder[], ApiConnectionActionConfiguration> ListFolders()
        {
            return new DeferredBodyAction<Folder[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Folder[]>(callPayload);
            });
        }
    }

    public class KeepersecretsmanagerTriggers([ConnectionName] string connectionId)
    {
    }

    public class SecretSummary
    {
        [JsonProperty("uid")]
        public string SecretUId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string RecordType { get; set; }

        [JsonProperty("folder_uid")]
        public string FolderUId { get; set; }
    }

    public class CreateSecretResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("folder_uid")]
        public string FolderUId { get; set; }

        [JsonProperty("response")]
        public string NewSecretUId { get; set; }
    }

    public class CreateSecretInput
    {
        [JsonProperty("folder_uid", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderUId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class SecretDetail
    {
        [JsonProperty("uid")]
        public string SecretUId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string RecordType { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("folder_uid")]
        public string FolderUId { get; set; }

        [JsonProperty("is_editable")]
        public bool IsEditable { get; set; }
    }

    public class UpdateSecretResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateSecretInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class Folder
    {
        [JsonProperty("uid")]
        public string FolderUId { get; set; }

        [JsonProperty("name")]
        public string FolderName { get; set; }

        [JsonProperty("parent_uid")]
        public string ParentFolderUId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Keepersecretsmanager;

    public partial class WorkflowManagedActions
    {
        public KeepersecretsmanagerActions Keepersecretsmanager(string connectionId) => new KeepersecretsmanagerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KeepersecretsmanagerTriggers Keepersecretsmanager(string connectionId) => new KeepersecretsmanagerTriggers(connectionId);
    }
}