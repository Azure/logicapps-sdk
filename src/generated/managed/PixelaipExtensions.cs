//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserDeleteResponse, ApiConnectionActionConfiguration> UserDelete()
        {
            return new DeferredBodyAction<UserDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<UserPostResponse, ApiConnectionActionConfiguration> User(Expression<Func<UserPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<TokenPutResponse, ApiConnectionActionConfiguration> TokenPut(Expression<Func<TokenPutInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TokenPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TokenPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<ProfilePutResponse, ApiConnectionActionConfiguration> ProfilePut(Expression<Func<ProfilePutInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ProfilePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/@";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProfilePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphsGetResponse, ApiConnectionActionConfiguration> GraphsGet()
        {
            return new DeferredBodyAction<GraphsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GraphsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphDeleteResponse, ApiConnectionActionConfiguration> GraphDelete(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<GraphDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<GraphDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPostResponse, ApiConnectionActionConfiguration> Graph(Expression<Func<GraphPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GraphPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GraphPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphPutResponse, ApiConnectionActionConfiguration> GraphPut(Expression<Func<string>> graphId, Expression<Func<GraphPutInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GraphPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GraphPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphGetResponse, ApiConnectionActionConfiguration> GraphGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<GraphGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graph-def";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<GraphGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<GraphSVGGetResponse, ApiConnectionActionConfiguration> GraphSVGGet(Expression<Func<string>> graphId, Expression<Func<string>> date = null, Expression<Func<modeInput>> mode = null, Expression<Func<appearanceInput>> appearance = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: false);
            var __workflow_appearance = WorkflowExpression.Compile(appearance, nameof(appearance), required: false);
            return new DeferredBodyAction<GraphSVGGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/graphSVG";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(__workflow_mode);
                if (__workflow_appearance != null)
                    callPayload.Queries["appearance"] = ExpressionConverter.Convert(__workflow_appearance);
                return new ApiConnectionAction<GraphSVGGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelsGetResponse, ApiConnectionActionConfiguration> PixelsGet(Expression<Func<string>> graphId, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<bool>> withBody = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_withBody = WorkflowExpression.Compile(withBody, nameof(withBody), required: false);
            return new DeferredBodyAction<PixelsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_withBody != null)
                    callPayload.Queries["withBody"] = ExpressionConverter.Convert(__workflow_withBody);
                return new ApiConnectionAction<PixelsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<StatsGetResponse, ApiConnectionActionConfiguration> StatsGet(Expression<Func<string>> graphId)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            return new DeferredBodyAction<StatsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                return new ApiConnectionAction<StatsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPostResponse, ApiConnectionActionConfiguration> Pixel(Expression<Func<string>> graphId, Expression<Func<PixelPostInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PixelPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PixelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelGetResponse, ApiConnectionActionConfiguration> PixelGet(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDeleteResponse, ApiConnectionActionConfiguration> PixelDelete(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelPutResponse, ApiConnectionActionConfiguration> PixelPut(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelRetinaGetResponse, ApiConnectionActionConfiguration> PixelRetinaGet(Expression<Func<string>> graphId, Expression<Func<string>> yyyyMMdd)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_yyyyMMdd = WorkflowExpression.Compile(yyyyMMdd, nameof(yyyyMMdd), required: true);
            return new DeferredBodyAction<PixelRetinaGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/pixel/retina";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Queries["yyyyMMdd"] = ExpressionConverter.Convert(__workflow_yyyyMMdd);
                return new ApiConnectionAction<PixelRetinaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelIncrementPutResponse, ApiConnectionActionConfiguration> PixelIncrementPut(Expression<Func<string>> graphId = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: false);
            return new DeferredBodyAction<PixelIncrementPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/increment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphId != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelIncrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelDecrementPutResponse, ApiConnectionActionConfiguration> PixelDecrementPut(Expression<Func<string>> graphId = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: false);
            return new DeferredBodyAction<PixelDecrementPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/decrement";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_graphId != null)
                    callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                callPayload.Headers["Content-Length"] = Convert.ToString(0);
                return new ApiConnectionAction<PixelDecrementPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelAddPutResponse, ApiConnectionActionConfiguration> PixelAddPut(Expression<Func<string>> graphId, Expression<Func<PixelAddPutInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PixelAddPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/add";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PixelAddPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelaip")]
        public IBodyWorkflowAction<PixelSubtractPutResponse, ApiConnectionActionConfiguration> PixelSubtractPut(Expression<Func<string>> graphId, Expression<Func<PixelSubtractPutInput>> body = null)
        {
            var __workflow_graphId = WorkflowExpression.Compile(graphId, nameof(graphId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PixelSubtractPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/graphs/subtract";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["graphID"] = ExpressionConverter.Convert(__workflow_graphId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PixelSubtractPutResponse>(callPayload);
            });
        }
    }

    public class PixelaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class UserPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class UserPostInput
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("agreeTermsOfService", DefaultValueHandling = DefaultValueHandling.Include)]
        public UserPostInputAgreeTermsOfServiceType? AgreeTermsOfService { get; set; } = UserPostInputAgreeTermsOfServiceType.Yes;

        [JsonProperty("notMinor", DefaultValueHandling = DefaultValueHandling.Include)]
        public UserPostInputNotMinorType? NotMinor { get; set; } = UserPostInputNotMinorType.Yes;

        [JsonProperty("thanksCode")]
        public string ThanksCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserPostInputAgreeTermsOfServiceType
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserPostInputNotMinorType
    {
        [EnumMember(Value = "yes")]
        Yes,
        [EnumMember(Value = "no")]
        No
    }

    public class TokenPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class TokenPutInput
    {
        [JsonProperty("newToken", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewToken { get; set; }

        [JsonProperty("thanksCode")]
        public string ThanksCode { get; set; }
    }

    public class ProfilePutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class ProfilePutInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("gravatarIconEmail")]
        public string GravatarIconEmail { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("aboutURL")]
        public string AboutURL { get; set; }

        [JsonProperty("contributeURLs")]
        public string[] ContributeURLs { get; set; }

        [JsonProperty("pinnedGraphID")]
        public string PinnedGraphId { get; set; }
    }

    public class GraphsGetResponse
    {
        [JsonProperty("graphs")]
        public GraphsGetResponseGraphsTypeItem[] Graphs { get; set; }
    }

    public class GraphsGetResponseGraphsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPostInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Unit { get; set; } = "commit";

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public GraphPostInputTypeType Type { get; set; } = GraphPostInputTypeType.Int;

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public GraphPostInputColorType Color { get; set; } = GraphPostInputColorType.Shibafu;

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool? IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool? PublishOptionalData { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphPostInputTypeType
    {
        [EnumMember(Value = "int")]
        Int,
        [EnumMember(Value = "float")]
        Float
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphPostInputColorType
    {
        [EnumMember(Value = "shibafu")]
        Shibafu,
        [EnumMember(Value = "momiji")]
        Momiji,
        [EnumMember(Value = "sora")]
        Sora,
        [EnumMember(Value = "ichou")]
        Ichou,
        [EnumMember(Value = "ajisai")]
        Ajisai,
        [EnumMember(Value = "kuro")]
        Kuro
    }

    public class GraphPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class GraphPutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Unit { get; set; } = "commit";

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public GraphPutInputColorType? Color { get; set; } = GraphPutInputColorType.Shibafu;

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool? IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool? PublishOptionalData { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GraphPutInputColorType
    {
        [EnumMember(Value = "shibafu")]
        Shibafu,
        [EnumMember(Value = "momiji")]
        Momiji,
        [EnumMember(Value = "sora")]
        Sora,
        [EnumMember(Value = "ichou")]
        Ichou,
        [EnumMember(Value = "ajisai")]
        Ajisai,
        [EnumMember(Value = "kuro")]
        Kuro
    }

    public class GraphGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("purgeCacheURLs")]
        public string[] PurgeCacheURLs { get; set; }

        [JsonProperty("selfSufficient")]
        public string SelfSufficient { get; set; }

        [JsonProperty("isSecret")]
        public bool IsSecret { get; set; }

        [JsonProperty("publishOptionalData")]
        public bool PublishOptionalData { get; set; }
    }

    public class GraphSVGGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modeInput
    {
        [EnumMember(Value = "short")]
        Short,
        [EnumMember(Value = "badge")]
        Badge,
        [EnumMember(Value = "line")]
        Line
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum appearanceInput
    {
        [EnumMember(Value = "dark")]
        Dark
    }

    public class PixelsGetResponse
    {
        [JsonProperty("pixels")]
        public PixelsGetResponsePixelsTypeItem[] Pixels { get; set; }
    }

    public class PixelsGetResponsePixelsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("optionalData")]
        public JToken OptionalData { get; set; }
    }

    public class StatsGetResponse
    {
        [JsonProperty("totalPixelsCount")]
        public int TotalPixelsCount { get; set; }

        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }

        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        [JsonProperty("totalQuantity")]
        public int TotalQuantity { get; set; }

        [JsonProperty("avgQuantity")]
        public double AvgQuantity { get; set; }

        [JsonProperty("todaysQuantity")]
        public int TodaysQuantity { get; set; }
    }

    public class PixelPostResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelPostInput
    {
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Quantity { get; set; }

        [JsonProperty("optionalData")]
        public JToken OptionalData { get; set; }
    }

    public class PixelGetResponse
    {
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class PixelDeleteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelRetinaGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class PixelIncrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelDecrementPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelAddPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelAddPutInput
    {
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }

    public class PixelSubtractPutResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }

    public class PixelSubtractPutInput
    {
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pixelaip;

    public partial class WorkflowManagedActions
    {
        public PixelaipActions Pixelaip(string connectionId) => new PixelaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelaipTriggers Pixelaip(string connectionId) => new PixelaipTriggers(connectionId);
    }
}