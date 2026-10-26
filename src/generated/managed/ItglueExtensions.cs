//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itglue
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItglueActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<PostOrganizationTypeResponse, ApiConnectionActionConfiguration> PostOrganizationType(Expression<Func<PostOrganizationTypeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostOrganizationTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/organization_types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/vnd.api+json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostOrganizationTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<GetOrganizationTypeResponse, ApiConnectionActionConfiguration> GetOrganizationType(Expression<Func<int>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<GetOrganizationTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organization_types/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrganizationTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<PatchOrganizationTypeResponse, ApiConnectionActionConfiguration> PatchOrganizationType(Expression<Func<int>> objectId, Expression<Func<PatchOrganizationTypeInput>> body = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchOrganizationTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organization_types/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/vnd.api+json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchOrganizationTypeResponse>(callPayload);
            });
        }
    }

    public class ItglueTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostOrganizationTypeResponse
    {
        [JsonProperty("data")]
        public OrganizationTypesRead Data { get; set; }
    }

    public class OrganizationTypesRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public OrganizationTypesReadTypeType Type { get; set; }

        [JsonProperty("attributes")]
        public OrganizationTypesReadAttributesType Attributes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrganizationTypesReadTypeType
    {
        [EnumMember(Value = "organization-types")]
        OrganizationTypes
    }

    public class OrganizationTypesReadAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }
    }

    public class PostOrganizationTypeInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public OrganizationTypesCreate Data { get; set; }
    }

    public class OrganizationTypesCreate
    {
        [JsonProperty("type")]
        public OrganizationTypesCreateTypeType Type { get; set; }

        [JsonProperty("attributes")]
        public OrganizationTypesCreateNameType Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrganizationTypesCreateTypeType
    {
        [EnumMember(Value = "organization-types")]
        OrganizationTypes
    }

    public class OrganizationTypesCreateNameType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetOrganizationTypeResponse
    {
        [JsonProperty("data")]
        public GetOrganizationTypeResponseDataType Data { get; set; }
    }

    public class GetOrganizationTypeResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public GetOrganizationTypeResponseDataTypeAttributesType Attributes { get; set; }
    }

    public class GetOrganizationTypeResponseDataTypeAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public class PatchOrganizationTypeResponse
    {
        [JsonProperty("data")]
        public OrganizationTypesRead Data { get; set; }
    }

    public class PatchOrganizationTypeInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public OrganizationTypesCreate Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Itglue;

    public partial class WorkflowManagedActions
    {
        public ItglueActions Itglue(string connectionId) => new ItglueActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ItglueTriggers Itglue(string connectionId) => new ItglueTriggers(connectionId);
    }
}