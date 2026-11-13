//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Akeylesssecretsmanag
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AkeylesssecretsmanagActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<ListItemsResponse, ApiConnectionActionConfiguration> ListItems(Expression<Func<ListItemsBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ListItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-items";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new ListItemsBodyInput().ToJToken();
                return new ApiConnectionAction<ListItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DescribeItem(Expression<Func<DescribeItemBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/describe-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListAuthMethods(Expression<Func<ListAuthMethodsBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-auth-methods";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListRoles(Expression<Func<ListGroupsBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-roles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListGateways(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-gateways";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListTargets(Expression<Func<ListAuthMethodsBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-targets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UscList(Expression<Func<UscListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/usc-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TargetGet(Expression<Func<TargetGetBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/target-get";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetTags(Expression<Func<GetAuthMethodBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/get-tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetRole(Expression<Func<GetAuthMethodBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/get-role";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAuthMethod(Expression<Func<GetAuthMethodBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/get-auth-method";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAnalyticsData(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/get-analytics-data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListGroups(Expression<Func<ListGroupsBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/list-groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateSecret(Expression<Func<CreateSecretBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/create-secret";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateItem(Expression<Func<UpdateItemBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/update-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteItem(Expression<Func<DeleteItemBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/delete-item";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MoveObjects(Expression<Func<MoveObjectsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/move-objects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<GetSecretResponse, ApiConnectionActionConfiguration> GetSecret(Expression<Func<GetPasswordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-secret-value/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "akeylesssecretsmanag")]
        public IBodyWorkflowAction<GetPasswordResponse, ApiConnectionActionConfiguration> GetPassword(Expression<Func<GetPasswordBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/get-secret-value/json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetPasswordResponse>(callPayload);
            });
        }
    }

    public class AkeylesssecretsmanagTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListItemsResponse
    {
        [JsonProperty("items")]
        public ListItemsResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("has_next")]
        public bool HasNext { get; set; }
    }

    public class ListItemsResponseItemsTypeItem
    {
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("display_id")]
        public string DisplayId { get; set; }
    }

    public class ListItemsBodyInput
    {
        [JsonProperty("path")]
        public string FolderPath { get; set; }

        [JsonProperty("filter")]
        public string NameFilter { get; set; }

        [JsonProperty("pagination_token")]
        public string PaginationToken { get; set; }

        [JsonProperty("current_folder", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CurrentFolderOnly { get; set; } = false;
    }

    public class DescribeItemBodyInput
    {
        public DescribeItemBodyInput(string itemPath)
        {
            this.ItemPath = itemPath;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemPath { get; set; }

        [JsonProperty("show_versions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowVersions { get; set; } = false;
    }

    public class ListAuthMethodsBodyInput
    {
        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("pagination_token")]
        public string PaginationToken { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }
    }

    public class ListGroupsBodyInput
    {
        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("pagination_token")]
        public string PaginationToken { get; set; }
    }

    public class UscListBodyInput
    {
        public UscListBodyInput(string uscName)
        {
            this.UscName = uscName;
        }

        [JsonProperty("usc_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UscName { get; set; }
    }

    public class TargetGetBodyInput
    {
        public TargetGetBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("show_versions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowVersions { get; set; } = false;
    }

    public class GetAuthMethodBodyInput
    {
        public GetAuthMethodBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class CreateSecretBodyInput
    {
        public CreateSecretBodyInput(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("protection_key")]
        public string ProtectionKey { get; set; }

        [JsonProperty("multiline", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Multiline { get; set; } = false;

        [JsonProperty("secret_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSecretTypeType? SecretType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Akeylesssecretsmanag.BodyInputSecretTypeType.Generic;

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFormatType? Format { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Akeylesssecretsmanag.BodyInputFormatType.Text;

        [JsonProperty("max_versions")]
        public string MaxVersions { get; set; }

        [JsonProperty("delete_protection", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteProtection { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSecretTypeType
    {
        [EnumMember(Value = "generic")]
        Generic,
        [EnumMember(Value = "password")]
        Password
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFormatType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "key-value")]
        KeyValue
    }

    public class UpdateItemBodyInput
    {
        public UpdateItemBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("new_value")]
        public string NewValue { get; set; }

        [JsonProperty("keep_prev_version", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepPrevVersion { get; set; } = false;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("new_name")]
        public string NewName { get; set; }

        [JsonProperty("add_tags")]
        public string[] AddTags { get; set; }

        [JsonProperty("remove_tags")]
        public string[] RemoveTags { get; set; }

        [JsonProperty("max_versions")]
        public string MaxVersions { get; set; }

        [JsonProperty("delete_protection")]
        public bool? DeleteProtection { get; set; }
    }

    public class DeleteItemBodyInput
    {
        public DeleteItemBodyInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("delete_immediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteImmediately { get; set; } = false;

        [JsonProperty("delete_in_days")]
        public int? DeleteInDays { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }
    }

    public class MoveObjectsBodyInput
    {
        public MoveObjectsBodyInput(string sourcePath, string targetPath)
        {
            this.SourcePath = sourcePath;
            this.TargetPath = targetPath;
        }

        [JsonProperty("source_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourcePath { get; set; }

        [JsonProperty("target_path", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetPath { get; set; }

        [JsonProperty("objects_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectsTypeType? ObjectsType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Akeylesssecretsmanag.BodyInputObjectsTypeType.Item;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputObjectsTypeType
    {
        [EnumMember(Value = "item")]
        Item,
        [EnumMember(Value = "auth_method")]
        AuthMethod,
        [EnumMember(Value = "role")]
        Role
    }

    public class GetSecretResponse
    {
        public string SecretValue { get; set; }
    }

    public class GetPasswordBodyInput
    {
        public GetPasswordBodyInput(string secretName)
        {
            this.SecretName = secretName;
        }

        [JsonProperty("secret_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecretName { get; set; }
    }

    public class GetPasswordResponse
    {
        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Akeylesssecretsmanag;

    public partial class WorkflowManagedActions
    {
        public AkeylesssecretsmanagActions Akeylesssecretsmanag(string connectionId) => new AkeylesssecretsmanagActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AkeylesssecretsmanagTriggers Akeylesssecretsmanag(string connectionId) => new AkeylesssecretsmanagTriggers(connectionId);
    }
}