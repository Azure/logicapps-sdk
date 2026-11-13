//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Updownip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UpdownipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<ListChecksResponseItem[], ApiConnectionActionConfiguration> ListChecks()
        {
            return new DeferredBodyAction<ListChecksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/checks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListChecksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListApiNodes()
        {
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nodes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<RecipientRef[], ApiConnectionActionConfiguration> ListRecipients()
        {
            return new DeferredBodyAction<RecipientRef[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/recipients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecipientRef[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<RecipientRef, ApiConnectionActionConfiguration> CreateRecipient(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RecipientRef, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/recipients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RecipientRef>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<DeleteRecipientResponse, ApiConnectionActionConfiguration> DeleteRecipient(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<DeleteRecipientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recipients/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteRecipientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<GetCheckResponse, ApiConnectionActionConfiguration> GetCheck(Expression<Func<string>> checkId, Expression<Func<bool>> metrics = null)
        {
            var __workflow_checkId = WorkflowExpression.Compile(checkId, nameof(checkId), required: true);
            var __workflow_metrics = WorkflowExpression.Compile(metrics, nameof(metrics), required: false);
            return new DeferredBodyAction<GetCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/checks/{0}", __workflow_checkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_metrics != null)
                    callPayload.Queries["metrics"] = ExpressionConverter.Convert(__workflow_metrics);
                return new ApiConnectionAction<GetCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<DeleteCheckResponse, ApiConnectionActionConfiguration> DeleteCheck(Expression<Func<string>> checkId)
        {
            var __workflow_checkId = WorkflowExpression.Compile(checkId, nameof(checkId), required: true);
            return new DeferredBodyAction<DeleteCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/checks/{0}", __workflow_checkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "updownip")]
        public IBodyWorkflowAction<GetCheckMetricsResponse, ApiConnectionActionConfiguration> GetCheckMetrics(Expression<Func<string>> checkId, Expression<Func<string>> from = null, Expression<Func<string>> to = null)
        {
            var __workflow_checkId = WorkflowExpression.Compile(checkId, nameof(checkId), required: true);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            return new DeferredBodyAction<GetCheckMetricsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/checks/{0}/metrics", __workflow_checkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                return new ApiConnectionAction<GetCheckMetricsResponse>(callPayload);
            });
        }
    }

    public class UpdownipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListChecksResponseItem
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("last_status")]
        public int LastStatus { get; set; }

        [JsonProperty("uptime")]
        public double Uptime { get; set; }

        [JsonProperty("down")]
        public bool Down { get; set; }

        [JsonProperty("down_since")]
        public string DownSince { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("apdex_t")]
        public double ApdexT { get; set; }

        [JsonProperty("string_match")]
        public string StringMatch { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("last_check_at")]
        public string LastCheckAt { get; set; }

        [JsonProperty("next_check_at")]
        public string NextCheckAt { get; set; }

        [JsonProperty("http_verb")]
        public string HttpVerb { get; set; }

        [JsonProperty("http_body")]
        public string HttpBody { get; set; }

        [JsonProperty("ssl")]
        public ListChecksResponseItemSslType Ssl { get; set; }
    }

    public class ListChecksResponseItemSslType
    {
        [JsonProperty("tested_at")]
        public string TestedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class RecipientRef
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(BodyInputTypeType type, string value)
        {
            this.Type = type;
            this.Value = value;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("selected")]
        public bool? Selected { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "slack_compatible")]
        SlackCompatible,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "webhook")]
        Webhook
    }

    public class DeleteRecipientResponse
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class GetCheckResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("last_status")]
        public int LastStatus { get; set; }

        [JsonProperty("uptime")]
        public double Uptime { get; set; }

        [JsonProperty("down")]
        public bool Down { get; set; }

        [JsonProperty("down_since")]
        public string DownSince { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("apdex_t")]
        public double ApdexT { get; set; }

        [JsonProperty("string_match")]
        public string StringMatch { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("last_check_at")]
        public string LastCheckAt { get; set; }

        [JsonProperty("next_check_at")]
        public string NextCheckAt { get; set; }

        [JsonProperty("http_verb")]
        public string HttpVerb { get; set; }

        [JsonProperty("http_body")]
        public string HttpBody { get; set; }

        [JsonProperty("ssl")]
        public GetCheckResponseSslType Ssl { get; set; }

        [JsonProperty("metrics")]
        public GetCheckResponseMetricsType Metrics { get; set; }
    }

    public class GetCheckResponseSslType
    {
        [JsonProperty("tested_at")]
        public string TestedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class GetCheckResponseMetricsType
    {
        [JsonProperty("apdex")]
        public double Apdex { get; set; }

        [JsonProperty("timings")]
        public GetCheckResponseMetricsTypeTimingsType Timings { get; set; }
    }

    public class GetCheckResponseMetricsTypeTimingsType
    {
        [JsonProperty("redirect")]
        public int Redirect { get; set; }

        [JsonProperty("namelookup")]
        public int Namelookup { get; set; }

        [JsonProperty("connection")]
        public int Connection { get; set; }

        [JsonProperty("handshake")]
        public int Handshake { get; set; }

        [JsonProperty("response")]
        public int Response { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class DeleteCheckResponse
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class GetCheckMetricsResponse
    {
        [JsonProperty("apdex")]
        public double Apdex { get; set; }

        [JsonProperty("timings")]
        public GetCheckMetricsResponseTimingsType Timings { get; set; }

        [JsonProperty("requests")]
        public GetCheckMetricsResponseRequestsType Requests { get; set; }
    }

    public class GetCheckMetricsResponseTimingsType
    {
        [JsonProperty("redirect")]
        public int Redirect { get; set; }

        [JsonProperty("namelookup")]
        public int Namelookup { get; set; }

        [JsonProperty("connection")]
        public int Connection { get; set; }

        [JsonProperty("handshake")]
        public int Handshake { get; set; }

        [JsonProperty("response")]
        public int Response { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetCheckMetricsResponseRequestsType
    {
        [JsonProperty("samples")]
        public int Samples { get; set; }

        [JsonProperty("failures")]
        public int Failures { get; set; }

        [JsonProperty("satisfied")]
        public int Satisfied { get; set; }

        [JsonProperty("tolerated")]
        public int Tolerated { get; set; }

        [JsonProperty("by_response_time")]
        public GetCheckMetricsResponseRequestsTypeByResponseTimeType ByResponseTime { get; set; }
    }

    public class GetCheckMetricsResponseRequestsTypeByResponseTimeType
    {
        [JsonProperty("under125")]
        public int Under125 { get; set; }

        [JsonProperty("under250")]
        public int Under250 { get; set; }

        [JsonProperty("under500")]
        public int Under500 { get; set; }

        [JsonProperty("under1000")]
        public int Under1000 { get; set; }

        [JsonProperty("under2000")]
        public int Under2000 { get; set; }

        [JsonProperty("under4000")]
        public int Under4000 { get; set; }

        [JsonProperty("under8000")]
        public int Under8000 { get; set; }

        [JsonProperty("under16000")]
        public int Under16000 { get; set; }

        [JsonProperty("under32000")]
        public int Under32000 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Updownip;

    public partial class WorkflowManagedActions
    {
        public UpdownipActions Updownip(string connectionId) => new UpdownipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UpdownipTriggers Updownip(string connectionId) => new UpdownipTriggers(connectionId);
    }
}