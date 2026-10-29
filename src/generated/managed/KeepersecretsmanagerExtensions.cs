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
        public IBodyWorkflowAction<CreateSecretResponse, ApiConnectionActionConfiguration> CreateSecret(Expression<Func<string>> bodyfolderUId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodylogin = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_bodyfolderUId = WorkflowExpression.Compile(bodyfolderUId, nameof(bodyfolderUId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodylogin = WorkflowExpression.Compile(bodylogin, nameof(bodylogin), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<CreateSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folder_uid"] = ExpressionConverter.ConvertO(__workflow_bodyfolderUId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodylogin != null)
                {
                    body["login"] = ExpressionConverter.ConvertO(__workflow_bodylogin);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<UpdateSecretResponse, ApiConnectionActionConfiguration> UpdateSecret(Expression<Func<string>> uid, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodylogin = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodynotes = null)
        {
            var __workflow_uid = WorkflowExpression.Compile(uid, nameof(uid), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodylogin = WorkflowExpression.Compile(bodylogin, nameof(bodylogin), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            return new DeferredBodyAction<UpdateSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/secrets/{0}", __workflow_uid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodylogin != null)
                {
                    body["login"] = ExpressionConverter.ConvertO(__workflow_bodylogin);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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