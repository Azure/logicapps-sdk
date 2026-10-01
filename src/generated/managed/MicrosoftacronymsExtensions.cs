//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftacronyms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftacronymsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymSearchPostResponse> AcronymSearch([WorkflowExpression] Func<bodyrequestsInputItem[]> bodyrequests = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrequests != null)
                {
                    body["requests"] = SourceExpressionConverter.ConvertToken(bodyrequests);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AcronymSearchPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymListGetResponse> AcronymListGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/acronyms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AcronymListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymPostResponse> Acronym([WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodystandsFor, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodywebUrl = null, [WorkflowExpression] Func<bodystateInput> bodystate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/acronyms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
                body["standsFor"] = SourceExpressionConverter.ConvertToken(bodystandsFor);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodywebUrl != null)
                {
                    body["webUrl"] = SourceExpressionConverter.ConvertToken(bodywebUrl);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    if (bodystate != null)
                    {
                        body["state"] = SourceExpressionConverter.Convert(bodystate);
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
                return callPayload;
            }

            return new ApiConnectionAction<AcronymPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<AcronymGetResponse> AcronymGet([WorkflowExpression] Func<string> acronymsId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/acronyms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(acronymsId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AcronymGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string> AcronymDelete([WorkflowExpression] Func<string> acronymsId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/acronyms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(acronymsId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftacronyms")]
        public IBodyWorkflowAction<string> AcronymPatch([WorkflowExpression] Func<string> acronymsId, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodystandsFor = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodywebUrl = null, [WorkflowExpression] Func<bodystateInput> bodystate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/acronyms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(acronymsId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodystandsFor != null)
                {
                    body["standsFor"] = SourceExpressionConverter.ConvertToken(bodystandsFor);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodywebUrl != null)
                {
                    body["webUrl"] = SourceExpressionConverter.ConvertToken(bodywebUrl);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    if (bodystate != null)
                    {
                        body["state"] = SourceExpressionConverter.Convert(bodystate);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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