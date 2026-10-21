//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Postmanip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PostmanipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListWorkspacesResponse> ListWorkspaces(Expression<Func<typeInput>> type = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<ListWorkspacesResponse>(() =>
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<ListWorkspacesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<CreateAWorkspaceResponse> CreateAWorkspace(Expression<Func<string>> bodyworkspacename, Expression<Func<bodyworkspacetypeInput>> bodyworkspacetype, Expression<Func<string>> bodyworkspacedescription = null)
        {
            var __workflow_bodyworkspacename = WorkflowExpression.Compile(bodyworkspacename, nameof(bodyworkspacename), required: true);
            var __workflow_bodyworkspacetype = WorkflowExpression.Compile(bodyworkspacetype, nameof(bodyworkspacetype), required: true);
            var __workflow_bodyworkspacedescription = WorkflowExpression.Compile(bodyworkspacedescription, nameof(bodyworkspacedescription), required: false);
            return new DeferredBodyAction<CreateAWorkspaceResponse>(() =>
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var workspaceObject = new JObject();
                var workspaceObjectpropCount = 0;
                workspaceObjectpropCount++;
                workspaceObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyworkspacename);
                if (__workflow_bodyworkspacedescription != null)
                {
                    workspaceObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyworkspacedescription);
                    workspaceObjectpropCount++;
                }

                workspaceObjectpropCount++;
                workspaceObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyworkspacetype);
                if (workspaceObjectpropCount > 0)
                {
                    body["workspace"] = workspaceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAWorkspaceResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetWorkspaceResponse> GetWorkspace(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<GetWorkspaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWorkspaceResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetAuthenticatedUserResponse> GetAuthenticatedUser()
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAuthenticatedUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListEnvironmentsResponse> ListEnvironments(Expression<Func<string>> workspace = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<ListEnvironmentsResponse>(() =>
            {
                var apiCallPath = "/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionAction<ListEnvironmentsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetEnvironmentResponse> GetEnvironment(Expression<Func<string>> environmentId)
        {
            var __workflow_environmentId = WorkflowExpression.Compile(environmentId, nameof(environmentId), required: true);
            return new DeferredBodyAction<GetEnvironmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/environments/{0}", __workflow_environmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnvironmentResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListCollectionsResponse> ListCollections(Expression<Func<string>> workspace = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<ListCollectionsResponse>(() =>
            {
                var apiCallPath = "/collections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                return new ApiConnectionAction<ListCollectionsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetCollectionResponse> GetCollection(Expression<Func<string>> collectionId, Expression<Func<string>> accessKey = null)
        {
            var __workflow_collectionId = WorkflowExpression.Compile(collectionId, nameof(collectionId), required: true);
            var __workflow_accessKey = WorkflowExpression.Compile(accessKey, nameof(accessKey), required: false);
            return new DeferredBodyAction<GetCollectionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/collections/{0}", __workflow_collectionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_accessKey != null)
                    callPayload.Queries["access_key"] = ExpressionConverter.Convert(__workflow_accessKey);
                return new ApiConnectionAction<GetCollectionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ImportOpenApiResponse> ImportOpenApi(Expression<Func<string>> workspace = null)
        {
            var __workflow_workspace = WorkflowExpression.Compile(workspace, nameof(workspace), required: false);
            return new DeferredBodyAction<ImportOpenApiResponse>(() =>
            {
                var apiCallPath = "/import/openapi";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_workspace != null)
                    callPayload.Queries["workspace"] = ExpressionConverter.Convert(__workflow_workspace);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "json";
                bodypropCount++;
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                if (inputObjectpropCount > 0)
                {
                    body["input"] = inputObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ImportOpenApiResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class PostmanipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListWorkspacesResponse
    {
        [JsonProperty("workspaces")]
        public ListWorkspacesResponseWorkspacesTypeItem[] Workspaces { get; set; }
    }

    public class ListWorkspacesResponseWorkspacesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "partner")]
        Partner,
        [EnumMember(Value = "public")]
        Public
    }

    public class CreateAWorkspaceResponse
    {
        [JsonProperty("workspace")]
        public CreateAWorkspaceResponseWorkspaceType Workspace { get; set; }
    }

    public class CreateAWorkspaceResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyworkspacetypeInput
    {
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "team")]
        Team,
        [EnumMember(Value = "partner")]
        Partner,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetWorkspaceResponse
    {
        [JsonProperty("workspace")]
        public GetWorkspaceResponseWorkspaceType Workspace { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("collections")]
        public GetWorkspaceResponseWorkspaceTypeCollectionsTypeItem[] Collections { get; set; }

        [JsonProperty("environments")]
        public GetWorkspaceResponseWorkspaceTypeEnvironmentsTypeItem[] Environments { get; set; }

        [JsonProperty("mocks")]
        public GetWorkspaceResponseWorkspaceTypeMocksTypeItem[] Mocks { get; set; }

        [JsonProperty("monitors")]
        public GetWorkspaceResponseWorkspaceTypeMonitorsTypeItem[] Monitors { get; set; }

        [JsonProperty("apis")]
        public GetWorkspaceResponseWorkspaceTypeApisTypeItem[] Apis { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceTypeCollectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceTypeEnvironmentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceTypeMocksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceTypeMonitorsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetWorkspaceResponseWorkspaceTypeApisTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class GetAuthenticatedUserResponse
    {
        [JsonProperty("user")]
        public GetAuthenticatedUserResponseUserType User { get; set; }

        [JsonProperty("operations")]
        public GetAuthenticatedUserResponseOperationsTypeItem[] Operations { get; set; }
    }

    public class GetAuthenticatedUserResponseUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
    }

    public class GetAuthenticatedUserResponseOperationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("usage")]
        public int Usage { get; set; }

        [JsonProperty("overage")]
        public int Overage { get; set; }
    }

    public class ListEnvironmentsResponse
    {
        [JsonProperty("environments")]
        public ListEnvironmentsResponseEnvironmentsTypeItem[] Environments { get; set; }
    }

    public class ListEnvironmentsResponseEnvironmentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
    }

    public class GetEnvironmentResponse
    {
        [JsonProperty("environment")]
        public GetEnvironmentResponseEnvironmentType Environment { get; set; }
    }

    public class GetEnvironmentResponseEnvironmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("values")]
        public GetEnvironmentResponseEnvironmentTypeValuesTypeItem[] Values { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
    }

    public class GetEnvironmentResponseEnvironmentTypeValuesTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ListCollectionsResponse
    {
        [JsonProperty("collections")]
        public ListCollectionsResponseCollectionsTypeItem[] Collections { get; set; }
    }

    public class ListCollectionsResponseCollectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
    }

    public class GetCollectionResponse
    {
        [JsonProperty("collection")]
        public JToken Collection { get; set; }
    }

    public class ImportOpenApiResponse
    {
        [JsonProperty("collections")]
        public ImportOpenApiResponseCollectionsTypeItem[] Collections { get; set; }
    }

    public class ImportOpenApiResponseCollectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Postmanip;

    public partial class WorkflowManagedActions
    {
        public PostmanipActions Postmanip(string connectionId) => new PostmanipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PostmanipTriggers Postmanip(string connectionId) => new PostmanipTriggers(connectionId);
    }
}
