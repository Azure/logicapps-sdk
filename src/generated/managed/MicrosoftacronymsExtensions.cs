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
        public IBodyWorkflowAction<AcronymSearchPostResponse> AcronymSearch(Expression<Func<bodyrequestsInputItem[]>> bodyrequests = null)
        {
            var __workflow_bodyrequests = WorkflowExpression.Compile(bodyrequests, nameof(bodyrequests), required: false);
            return new DeferredBodyAction<AcronymSearchPostResponse>(() =>
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrequests != null)
                {
                    body["requests"] = ExpressionConverter.ConvertO(__workflow_bodyrequests);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AcronymSearchPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymListGetResponse> AcronymListGet()
        {
            var apiCallPath = "/acronyms";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AcronymListGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymPostResponse> Acronym(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodystandsFor, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodywebUrl = null, Expression<Func<bodystateInput>> bodystate = null)
        {
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodystandsFor = WorkflowExpression.Compile(bodystandsFor, nameof(bodystandsFor), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodywebUrl = WorkflowExpression.Compile(bodywebUrl, nameof(bodywebUrl), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            return new DeferredBodyAction<AcronymPostResponse>(() =>
            {
                var apiCallPath = "/acronyms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["standsFor"] = ExpressionConverter.ConvertO(__workflow_bodystandsFor);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodywebUrl != null)
                {
                    body["webUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebUrl);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    if (__workflow_bodystate != null)
                    {
                        body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["state"] = "published";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AcronymPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymGetResponse> AcronymGet(Expression<Func<string>> acronymsId)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            return new DeferredBodyAction<AcronymGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AcronymGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string> AcronymDelete(Expression<Func<string>> acronymsId)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string> AcronymPatch(Expression<Func<string>> acronymsId, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodystandsFor = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodywebUrl = null, Expression<Func<bodystateInput>> bodystate = null)
        {
            var __workflow_acronymsId = WorkflowExpression.Compile(acronymsId, nameof(acronymsId), required: true);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodystandsFor = WorkflowExpression.Compile(bodystandsFor, nameof(bodystandsFor), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodywebUrl = WorkflowExpression.Compile(bodywebUrl, nameof(bodywebUrl), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/acronyms/{0}", __workflow_acronymsId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodystandsFor != null)
                {
                    body["standsFor"] = ExpressionConverter.ConvertO(__workflow_bodystandsFor);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodywebUrl != null)
                {
                    body["webUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebUrl);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    if (__workflow_bodystate != null)
                    {
                        body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["state"] = "published";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class MicrosoftacronymsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AcronymSearchPostResponse
    {
        [JsonProperty("value")]
        public AcronymSearchPostResponseValueTypeItem[] Value { get; set; }

        [JsonProperty("@odata.context")]
        public string Context { get; set; }
    }

    public class AcronymSearchPostResponseValueTypeItem
    {
        [JsonProperty("hitsContainers")]
        public AcronymSearchPostResponseValueTypeItemHitsContainersTypeItem[] HitsContainers { get; set; }
    }

    public class AcronymSearchPostResponseValueTypeItemHitsContainersTypeItem
    {
        [JsonProperty("hits")]
        public AcronymSearchPostResponseValueTypeItemHitsContainersTypeItemHitsTypeItem[] Hits { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("moreResultsAvailable")]
        public bool MoreResultsAvailable { get; set; }

        [JsonProperty("aggregations")]
        public string[] Aggregations { get; set; }
    }

    public class AcronymSearchPostResponseValueTypeItemHitsContainersTypeItemHitsTypeItem
    {
        [JsonProperty("hitId")]
        public string HitId { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("resource")]
        public AcronymSearchPostResponseValueTypeItemHitsContainersTypeItemHitsTypeItemResourceType Resource { get; set; }
    }

    public class AcronymSearchPostResponseValueTypeItemHitsContainersTypeItemHitsTypeItemResourceType
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

    public class bodyrequestsInputItem
    {
        [JsonProperty("entityTypes")]
        public string[] EntityTypes { get; set; }

        [JsonProperty("query")]
        public bodyrequestsInputItemQueryType Query { get; set; }
    }

    public class bodyrequestsInputItemQueryType
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

    public class AcronymPostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystateInput
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
