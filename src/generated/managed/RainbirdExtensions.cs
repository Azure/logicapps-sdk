//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rainbird
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RainbirdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildStart))]
        public IBodyWorkflowAction<StartResponse> Start([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> kmID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartResponse> __BuildStart(WorkflowValue<environmentInput> environment, WorkflowValue<string> kmID)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(kmID, nameof(kmID), required: true);
            return new DeferredBodyAction<StartResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/start/{0}", ExpressionConverter.ConvertWithUrlEncoding(kmID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                return new ApiConnectionAction<StartResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildInject))]
        public IBodyWorkflowAction<InjectResponse> Inject([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionID, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InjectResponse> __BuildInject(WorkflowValue<environmentInput> environment, WorkflowValue<string> sessionID, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(sessionID, nameof(sessionID), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<InjectResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/inject", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<InjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildQuery))]
        public IBodyWorkflowAction<JToken> Query([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionID, [WorkflowExpression] Func<string> bodyrelationship, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyObject = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildQuery(WorkflowValue<environmentInput> environment, WorkflowValue<string> sessionID, WorkflowValue<string> bodyrelationship, WorkflowValue<string> bodysubject = null, WorkflowValue<string> bodyObject = null)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(sessionID, nameof(sessionID), required: true);
            WorkflowValue.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            WorkflowValue.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowValue.Validate(bodyObject, nameof(bodyObject), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relationship"] = ExpressionConverter.ConvertO(bodyrelationship);
                if (bodyObject != null)
                {
                    body["object"] = ExpressionConverter.ConvertO(bodyObject);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildResponse))]
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionID, [WorkflowExpression] Func<bodyanswersInputItem[]> bodyanswers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildResponse(WorkflowValue<environmentInput> environment, WorkflowValue<string> sessionID, WorkflowValue<bodyanswersInputItem[]> bodyanswers = null)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(sessionID, nameof(sessionID), required: true);
            WorkflowValue.Validate(bodyanswers, nameof(bodyanswers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/response", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyanswers != null)
                {
                    body["answers"] = ExpressionConverter.ConvertO(bodyanswers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildUndo))]
        public IBodyWorkflowAction<JToken> Undo([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUndo(WorkflowValue<environmentInput> environment, WorkflowValue<string> sessionID)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(sessionID, nameof(sessionID), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/undo", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildEvidence))]
        public IBodyWorkflowAction<EvidenceResponse> Evidence([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> factID, [WorkflowExpression] Func<string> sessionID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EvidenceResponse> __BuildEvidence(WorkflowValue<environmentInput> environment, WorkflowValue<string> factID, WorkflowValue<string> sessionID)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            WorkflowValue.Validate(factID, nameof(factID), required: true);
            WorkflowValue.Validate(sessionID, nameof(sessionID), required: true);
            return new DeferredBodyAction<EvidenceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/analysis/evidence/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(factID, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
                return new ApiConnectionAction<EvidenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        [WorkflowExpressionFactory(nameof(__BuildVersion))]
        public IBodyWorkflowAction<string> Version([WorkflowExpression] Func<environmentInput> environment)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildVersion(WorkflowValue<environmentInput> environment)
        {
            WorkflowValue.Validate(environment, nameof(environment), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
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

    public class bodyanswersInputItem
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

    public class EvidenceResponse
    {
        [JsonProperty("fact")]
        public EvidenceResponseFactType Fact { get; set; }

        [JsonProperty("factID")]
        public string FactID { get; set; }

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
        public string FactID { get; set; }

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
