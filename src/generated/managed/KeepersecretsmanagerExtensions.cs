//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Keepersecretsmanager
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KeepersecretsmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<SecretSummary[]> ListSecrets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretSummary[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<CreateSecretResponse> CreateSecret([WorkflowExpression] Func<string> bodyfolderUId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodylogin = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/secrets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folder_uid"] = SourceExpressionConverter.ConvertToken(bodyfolderUId);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodylogin != null)
                {
                    body["login"] = SourceExpressionConverter.ConvertToken(bodylogin);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<SecretDetail> GetSecret([WorkflowExpression] Func<string> uid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SecretDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<UpdateSecretResponse> UpdateSecret([WorkflowExpression] Func<string> uid, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodylogin = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secrets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodylogin != null)
                {
                    body["login"] = SourceExpressionConverter.ConvertToken(bodylogin);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "keepersecretsmanager")]
        public IBodyWorkflowAction<Folder[]> ListFolders()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Folder[]>(BuildSourceInput);
        }
    }

    public class KeepersecretsmanagerTriggers([ConnectionName] string connectionId)
    {
    }

    public class SecretSummary
    {
        [JsonProperty("uid")]
        public string SecretUID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string RecordType { get; set; }

        [JsonProperty("folder_uid")]
        public string FolderUID { get; set; }
    }

    public class CreateSecretResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("folder_uid")]
        public string FolderUID { get; set; }

        [JsonProperty("response")]
        public string NewSecretUID { get; set; }
    }

    public class SecretDetail
    {
        [JsonProperty("uid")]
        public string SecretUID { get; set; }

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
        public string FolderUID { get; set; }

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
        public string FolderUID { get; set; }

        [JsonProperty("name")]
        public string FolderName { get; set; }

        [JsonProperty("parent_uid")]
        public string ParentFolderUID { get; set; }
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