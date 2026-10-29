//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rainbird
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RainbirdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<StartResponse, ApiConnectionActionConfiguration> Start(Expression<Func<environmentInput>> environment, Expression<Func<string>> kmId)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_kmId = WorkflowExpression.Compile(kmId, nameof(kmId), required: true);
            return new DeferredBodyAction<StartResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/start/{0}", __workflow_kmId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                return new ApiConnectionAction<StartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<InjectResponse, ApiConnectionActionConfiguration> Inject(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionId, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/inject", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Query(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionId, Expression<Func<QueryInput>> body)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/query", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Response(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionId, Expression<Func<ResponseInput>> body)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/response", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Undo(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionId, Expression<Func<object>> body = null)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/undo", __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<EvidenceResponse, ApiConnectionActionConfiguration> Evidence(Expression<Func<environmentInput>> environment, Expression<Func<string>> factId, Expression<Func<string>> sessionId)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            var __workflow_factId = WorkflowExpression.Compile(factId, nameof(factId), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<EvidenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/analysis/evidence/{0}/{1}", __workflow_factId.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                return new ApiConnectionAction<EvidenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Version(Expression<Func<environmentInput>> environment)
        {
            var __workflow_environment = WorkflowExpression.Compile(environment, nameof(environment), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(__workflow_environment);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class RainbirdTriggers([ConnectionName] string connectionId)
    {
    }

    public class StartResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kmVersion")]
        public StartResponseKmVersionType KmVersion { get; set; }
    }

    public class StartResponseKmVersionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum environmentInput
    {
        [EnumMember(Value = "enterprise-api.rainbird.ai")]
        EnterpriseApiRainbirdAi,
        [EnumMember(Value = "api.rainbird.ai")]
        ApiRainbirdAi
    }

    public class InjectResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("subject")]
        public JToken Subject { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("object")]
        public JToken ObjectEntity { get; set; }

        [JsonProperty("certainty")]
        public double Certainty { get; set; }
    }

    public class QueryInput
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Relationship { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }
    }

    public class ResponseInput
    {
        [JsonProperty("answers")]
        public ResponseInputAnswersTypeItem[] Answers { get; set; }
    }

    public class ResponseInputAnswersTypeItem
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Subject { get; set; }

        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Relationship { get; set; }

        [JsonProperty("object", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ObjectEntity { get; set; }

        [JsonProperty("certainty", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Certainty { get; set; }
    }

    public class EvidenceResponse
    {
        [JsonProperty("fact")]
        public EvidenceResponseFactType Fact { get; set; }

        [JsonProperty("factID")]
        public string FactId { get; set; }

        [JsonProperty("rule")]
        public EvidenceResponseRuleType Rule { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }
    }

    public class EvidenceResponseFactType
    {
        [JsonProperty("certainty")]
        public double Certainty { get; set; }

        [JsonProperty("object")]
        public EvidenceResponseFactTypeObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("relationship")]
        public EvidenceResponseFactTypeRelationshipType Relationship { get; set; }

        [JsonProperty("subject")]
        public EvidenceResponseFactTypeSubjectType Subject { get; set; }
    }

    public class EvidenceResponseFactTypeObjectEntityType
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class EvidenceResponseFactTypeRelationshipType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class EvidenceResponseFactTypeSubjectType
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EvidenceResponseRuleType
    {
        [JsonProperty("bindings")]
        public EvidenceResponseRuleTypeBindingsType Bindings { get; set; }
    }

    public class EvidenceResponseRuleTypeBindingsType
    {
        [JsonProperty("conditions")]
        public EvidenceResponseRuleTypeBindingsTypeConditionsTypeItem[] Conditions { get; set; }
    }

    public class EvidenceResponseRuleTypeBindingsTypeConditionsTypeItem
    {
        [JsonProperty("certainty")]
        public double Certainty { get; set; }

        [JsonProperty("factID")]
        public string FactId { get; set; }

        [JsonProperty("object")]
        public JToken ObjectEntity { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("salience")]
        public double Salience { get; set; }

        [JsonProperty("subject")]
        public JToken Subject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rainbird;

    public partial class WorkflowManagedActions
    {
        public RainbirdActions Rainbird(string connectionId) => new RainbirdActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RainbirdTriggers Rainbird(string connectionId) => new RainbirdTriggers(connectionId);
    }
}