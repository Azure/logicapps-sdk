//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Motimate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MotimateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<UserGetAllResponse> UserGetAll([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<UserGetAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<UserDeleteByIdResponse> UserDeleteById([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public_api/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<UserDeleteByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionGetAllResponse> PositionGetAll([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/positions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<PositionGetAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionCreateResponse> PositionCreate([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/positions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<PositionCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionDeleteByIdResponse> PositionDeleteById([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<string> positionId)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(positionId, nameof(positionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public_api/positions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(positionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<PositionDeleteByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<PositionUpdateByIdResponse> PositionUpdateById([WorkflowExpression] Func<string> positionId, [WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<string> bodyimportId = null, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(positionId, nameof(positionId), required: true);
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(bodyimportId, nameof(bodyimportId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public_api/positions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(positionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyimportId != null)
                {
                    body["import_id"] = SourceExpressionConverter.ConvertToken(bodyimportId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PositionUpdateByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupGetAllResponse> GroupGetAll([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<GroupGetAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupCreateResponse> GroupCreate([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<GroupCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<GroupDeleteByIdResponse> GroupDeleteById([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/public_api/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<GroupDeleteByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<TokenGetResponse> TokenGet([WorkflowExpression] Func<string> subdomain, [WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> password, [WorkflowExpression] Func<string> clientId)
        {
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(password, nameof(password), required: true);
            SourceExpression.Validate(clientId, nameof(clientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/oauth/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["grant_type"] = Convert.ToString("password");
                callPayload.Queries["username"] = SourceExpressionConverter.ConvertO(username);
                callPayload.Queries["password"] = SourceExpressionConverter.ConvertO(password);
                callPayload.Queries["client_id"] = SourceExpressionConverter.ConvertO(clientId);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<TokenGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motimate")]
        public IBodyWorkflowAction<MeResponse> Me([WorkflowExpression] Func<string> auth, [WorkflowExpression] Func<string> subdomain)
        {
            SourceExpression.Validate(auth, nameof(auth), required: true);
            SourceExpression.Validate(subdomain, nameof(subdomain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/public_api/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Auth"] = SourceExpressionConverter.ConvertO(auth);
                callPayload.Headers["subdomain"] = SourceExpressionConverter.ConvertO(subdomain);
                return callPayload;
            }

            return new ApiConnectionAction<MeResponse>(BuildSourceInput);
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