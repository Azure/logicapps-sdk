//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Motimate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MotimateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<UserGetAllResponse, ApiConnectionActionConfiguration> UserGetAll(Expression<Func<string>> auth, Expression<Func<string>> subdomain)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            return new DeferredBodyAction<UserGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<UserGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<UserDeleteByIdResponse, ApiConnectionActionConfiguration> UserDeleteById(Expression<Func<string>> userId, Expression<Func<string>> auth, Expression<Func<string>> subdomain)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            return new DeferredBodyAction<UserDeleteByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public_api/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<UserDeleteByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionGetAllResponse, ApiConnectionActionConfiguration> PositionGetAll(Expression<Func<string>> auth, Expression<Func<string>> subdomain)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            return new DeferredBodyAction<PositionGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/positions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<PositionGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionCreateResponse, ApiConnectionActionConfiguration> PositionCreate(Expression<Func<string>> auth, Expression<Func<string>> subdomain, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PositionCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/positions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PositionCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionDeleteByIdResponse, ApiConnectionActionConfiguration> PositionDeleteById(Expression<Func<string>> auth, Expression<Func<string>> subdomain, Expression<Func<string>> positionId)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: true);
            return new DeferredBodyAction<PositionDeleteByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public_api/positions/{0}", __workflow_positionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<PositionDeleteByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionUpdateByIdResponse, ApiConnectionActionConfiguration> PositionUpdateById(Expression<Func<string>> positionId, Expression<Func<string>> auth, Expression<Func<string>> subdomain, Expression<Func<string>> bodyimportId = null, Expression<Func<string>> bodyname = null)
        {
            var __workflow_positionId = WorkflowExpression.Compile(positionId, nameof(positionId), required: true);
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_bodyimportId = WorkflowExpression.Compile(bodyimportId, nameof(bodyimportId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<PositionUpdateByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public_api/positions/{0}", __workflow_positionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyimportId != null)
                {
                    body["import_id"] = ExpressionConverter.ConvertO(__workflow_bodyimportId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PositionUpdateByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupGetAllResponse, ApiConnectionActionConfiguration> GroupGetAll(Expression<Func<string>> auth, Expression<Func<string>> subdomain)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            return new DeferredBodyAction<GroupGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<GroupGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupCreateResponse, ApiConnectionActionConfiguration> GroupCreate(Expression<Func<string>> auth, Expression<Func<string>> subdomain, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GroupCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupDeleteByIdResponse, ApiConnectionActionConfiguration> GroupDeleteById(Expression<Func<string>> auth, Expression<Func<string>> subdomain, Expression<Func<string>> groupId)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GroupDeleteByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/public_api/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<GroupDeleteByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<TokenGetResponse, ApiConnectionActionConfiguration> TokenGet(Expression<Func<string>> subdomain, Expression<Func<string>> username, Expression<Func<string>> password, Expression<Func<string>> clientId)
        {
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: true);
            var __workflow_clientId = WorkflowExpression.Compile(clientId, nameof(clientId), required: true);
            return new DeferredBodyAction<TokenGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/oauth/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["grant_type"] = Convert.ToString("password");
                callPayload.Queries["username"] = ExpressionConverter.Convert(__workflow_username);
                callPayload.Queries["password"] = ExpressionConverter.Convert(__workflow_password);
                callPayload.Queries["client_id"] = ExpressionConverter.Convert(__workflow_clientId);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<TokenGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<MeResponse, ApiConnectionActionConfiguration> Me(Expression<Func<string>> auth, Expression<Func<string>> subdomain)
        {
            var __workflow_auth = WorkflowExpression.Compile(auth, nameof(auth), required: true);
            var __workflow_subdomain = WorkflowExpression.Compile(subdomain, nameof(subdomain), required: true);
            return new DeferredBodyAction<MeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/public_api/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = ExpressionConverter.Convert(__workflow_auth);
                callPayload.Headers["subdomain"] = ExpressionConverter.Convert(__workflow_subdomain);
                return new ApiConnectionAction<MeResponse>(callPayload);
            });
        }
    }

    public class MotimateTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserGetAllResponse
    {
        [JsonProperty("data")]
        public UserGetAllResponseDataTypeItem[] Data { get; set; }
    }

    public class UserGetAllResponseDataTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("employee_number")]
        public string EmployeeNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("organization_role")]
        public string OrganizationRole { get; set; }
    }

    public class UserDeleteByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class PositionGetAllResponse
    {
        [JsonProperty("data")]
        public PositionGetAllResponseDataTypeItem[] Data { get; set; }
    }

    public class PositionGetAllResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("import_id")]
        public string ImportId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PositionCreateResponse
    {
        [JsonProperty("data")]
        public PositionCreateResponseDataType Data { get; set; }
    }

    public class PositionCreateResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("import_id")]
        public string ImportId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class PositionDeleteByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class PositionUpdateByIdResponse
    {
        [JsonProperty("data")]
        public PositionUpdateByIdResponseDataType Data { get; set; }
    }

    public class PositionUpdateByIdResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("import_id")]
        public string ImportId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GroupGetAllResponse
    {
        [JsonProperty("data")]
        public GroupGetAllResponseDataTypeItem[] Data { get; set; }
    }

    public class GroupGetAllResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class GroupCreateResponse
    {
        [JsonProperty("data")]
        public GroupCreateResponseDataType Data { get; set; }
    }

    public class GroupCreateResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class GroupDeleteByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class TokenGetResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }

    public class MeResponse
    {
        [JsonProperty("data")]
        public MeResponseDataType Data { get; set; }
    }

    public class MeResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("employee_number")]
        public string EmployeeNumber { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("organization_role")]
        public string OrganizationRole { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Motimate;

    public partial class WorkflowManagedActions
    {
        public MotimateActions Motimate(string connectionId) => new MotimateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MotimateTriggers Motimate(string connectionId) => new MotimateTriggers(connectionId);
    }
}
