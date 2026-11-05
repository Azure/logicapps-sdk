//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftacronyms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftacronymsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymSearchResponse, ApiConnectionActionConfiguration> AcronymSearch(Expression<Func<AcronymSearchBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AcronymSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AcronymSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymListGetResponse, ApiConnectionActionConfiguration> AcronymListGet()
        {
            return new DeferredBodyAction<AcronymListGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/acronyms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AcronymListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymResponse, ApiConnectionActionConfiguration> Acronym(Expression<Func<AcronymBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AcronymResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/acronyms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AcronymResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymGetResponse, ApiConnectionActionConfiguration> AcronymGet(Expression<Func<string>> acronymsId)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            return new DeferredBodyAction<AcronymGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AcronymGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AcronymDelete(Expression<Func<string>> acronymsId)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AcronymPatch(Expression<Func<string>> acronymsId, Expression<Func<AcronymPatchBodyInput>> body = null)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MicrosoftacronymsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AcronymSearchResponse
    {
        [JsonProperty("value")]
        public AcronymSearchResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("@odata.context")]
        public string Context { get; set; }
    }

    public class AcronymSearchResponseValueTypeItem
    {
        [JsonProperty("hitsContainers")]
        public AcronymSearchResponseValueTypeItemHitsContainersTypeItem[] HitsContainers { get; set; }
    }

    public class AcronymSearchResponseValueTypeItemHitsContainersTypeItem
    {
        [JsonProperty("hits")]
        public AcronymSearchResponseValueTypeItemHitsContainersTypeItemHitsTypeItem[] Hits { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("moreResultsAvailable")]
        public bool MoreResultsAvailable { get; set; }

        [JsonProperty("aggregations")]
        public string[] Aggregations { get; set; }
    }

    public class AcronymSearchResponseValueTypeItemHitsContainersTypeItemHitsTypeItem
    {
        [JsonProperty("hitId")]
        public string HitId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("resource")]
        public AcronymSearchResponseValueTypeItemHitsContainersTypeItemHitsTypeItemResourceType Resource { get; set; }
    }

    public class AcronymSearchResponseValueTypeItemHitsContainersTypeItemHitsTypeItemResourceType
    {
        [JsonProperty("@odata.type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("standsFor")]
        public string StandsFor { get; set; }
    }

    public class AcronymSearchBodyInput
    {
        [JsonProperty("requests")]
        public BodyInputRequestsTypeItem[] Requests { get; set; }
    }

    public class BodyInputRequestsTypeItem
    {
        [JsonProperty("entityTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] EntityTypes { get; set; } = new string[]
        {
            "acronym"
        };

        [JsonProperty("query")]
        public BodyInputRequestsTypeItemQueryType Query { get; set; }
    }

    public class BodyInputRequestsTypeItemQueryType
    {
        [JsonProperty("queryString")]
        public string QueryString { get; set; }
    }

    public class AcronymListGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public AcronymListGetResponseValueTypeItem[] Value { get; set; }
    }

    public class AcronymListGetResponseValueTypeItem
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("standsFor")]
        public string StandsFor { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("lastModifiedBy")]
        public AcronymListGetResponseValueTypeItemLastModifiedByType LastModifiedBy { get; set; }
    }

    public class AcronymListGetResponseValueTypeItemLastModifiedByType
    {
        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("user")]
        public AcronymListGetResponseValueTypeItemLastModifiedByTypeUserType User { get; set; }
    }

    public class AcronymListGetResponseValueTypeItemLastModifiedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AcronymResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AcronymBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("standsFor", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StandsFor { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputStateType? State { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftacronyms.BodyInputStateType.Published;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStateType
    {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "excluded")]
        Excluded,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue
    }

    public class AcronymGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("standsFor")]
        public string StandsFor { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("lastModifiedBy")]
        public AcronymGetResponseLastModifiedByType LastModifiedBy { get; set; }
    }

    public class AcronymGetResponseLastModifiedByType
    {
        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("user")]
        public AcronymGetResponseLastModifiedByTypeUserType User { get; set; }
    }

    public class AcronymGetResponseLastModifiedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AcronymPatchBodyInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("standsFor")]
        public string StandsFor { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputStateType? State { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftacronyms.BodyInputStateType.Published;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftacronyms;

    public partial class WorkflowManagedActions
    {
        public MicrosoftacronymsActions Microsoftacronyms(string connectionId) => new MicrosoftacronymsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftacronymsTriggers Microsoftacronyms(string connectionId) => new MicrosoftacronymsTriggers(connectionId);
    }
}