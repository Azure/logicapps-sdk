//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Postmanip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PostmanipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListWorkspacesResponse> ListWorkspaces([WorkflowExpression] Func<typeInput> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<ListWorkspacesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<CreateAWorkspaceResponse> CreateAWorkspace([WorkflowExpression] Func<string> bodyworkspacename, [WorkflowExpression] Func<bodyworkspacetypeInput> bodyworkspacetype, [WorkflowExpression] Func<string> bodyworkspacedescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                workspaceObject["name"] = SourceExpressionConverter.ConvertToken(bodyworkspacename);
                if (bodyworkspacedescription != null)
                {
                    workspaceObject["description"] = SourceExpressionConverter.ConvertToken(bodyworkspacedescription);
                    workspaceObjectpropCount++;
                }

                workspaceObjectpropCount++;
                workspaceObject["type"] = SourceExpressionConverter.Convert(bodyworkspacetype);
                if (workspaceObjectpropCount > 0)
                {
                    body["workspace"] = workspaceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAWorkspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetWorkspaceResponse> GetWorkspace([WorkflowExpression] Func<string> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWorkspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetAuthenticatedUserResponse> GetAuthenticatedUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAuthenticatedUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListEnvironmentsResponse> ListEnvironments([WorkflowExpression] Func<string> workspace = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/environments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionAction<ListEnvironmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetEnvironmentResponse> GetEnvironment([WorkflowExpression] Func<string> environmentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/environments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(environmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEnvironmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ListCollectionsResponse> ListCollections([WorkflowExpression] Func<string> workspace = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/collections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
                return callPayload;
            }

            return new ApiConnectionAction<ListCollectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<GetCollectionResponse> GetCollection([WorkflowExpression] Func<string> collectionId, [WorkflowExpression] Func<string> accessKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/collections/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(collectionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (accessKey != null)
                    callPayload.Queries["access_key"] = SourceExpressionConverter.ConvertO(accessKey);
                return callPayload;
            }

            return new ApiConnectionAction<GetCollectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "postmanip")]
        public IBodyWorkflowAction<ImportOpenApiResponse> ImportOpenApi([WorkflowExpression] Func<string> workspace = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/import/openapi";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (workspace != null)
                    callPayload.Queries["workspace"] = SourceExpressionConverter.ConvertO(workspace);
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
                return callPayload;
            }

            return new ApiConnectionAction<ImportOpenApiResponse>(BuildSourceInput);
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