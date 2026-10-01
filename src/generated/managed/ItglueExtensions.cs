//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itglue
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ItglueActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<PostOrganizationTypeResponse> PostOrganizationType([WorkflowExpression] Func<string> bodydatanamename = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/organization_types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/vnd.api+json");
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                dataObject["type"] = "organization-types";
                dataObjectpropCount++;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (bodydatanamename != null)
                {
                    attributesObject["name"] = SourceExpressionConverter.ConvertToken(bodydatanamename);
                    attributesObjectpropCount++;
                }

                if (attributesObjectpropCount > 0)
                {
                    dataObject["attributes"] = attributesObject;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostOrganizationTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<GetOrganizationTypeResponse> GetOrganizationType([WorkflowExpression] Func<int> objectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organization_types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itglue")]
        public IBodyWorkflowAction<PatchOrganizationTypeResponse> PatchOrganizationType([WorkflowExpression] Func<int> objectId, [WorkflowExpression] Func<string> bodydatanamename = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organization_types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(objectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/vnd.api+json");
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                dataObject["type"] = "organization-types";
                dataObjectpropCount++;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (bodydatanamename != null)
                {
                    attributesObject["name"] = SourceExpressionConverter.ConvertToken(bodydatanamename);
                    attributesObjectpropCount++;
                }

                if (attributesObjectpropCount > 0)
                {
                    dataObject["attributes"] = attributesObject;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchOrganizationTypeResponse>(BuildSourceInput);
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