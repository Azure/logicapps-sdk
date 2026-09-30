//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rainbird
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RainbirdActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<StartResponse> Start([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> kmId)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(kmId, nameof(kmId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/start/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(kmId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                return callPayload;
            }

            return new ApiConnectionAction<StartResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<InjectResponse> Inject([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/inject", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<InjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Query([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> bodyrelationship, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodyObject = null)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(bodyrelationship, nameof(bodyrelationship), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyObject, nameof(bodyObject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/query", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                bodypropCount++;
                body["relationship"] = SourceExpressionConverter.ConvertToken(bodyrelationship);
                if (bodyObject != null)
                {
                    body["object"] = SourceExpressionConverter.ConvertToken(bodyObject);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<bodyanswersInputItem[]> bodyanswers = null)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            SourceExpression.Validate(bodyanswers, nameof(bodyanswers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/response", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyanswers != null)
                {
                    body["answers"] = SourceExpressionConverter.ConvertToken(bodyanswers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Undo([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/undo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<EvidenceResponse> Evidence([WorkflowExpression] Func<environmentInput> environment, [WorkflowExpression] Func<string> factId, [WorkflowExpression] Func<string> sessionId)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            SourceExpression.Validate(factId, nameof(factId), required: true);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/analysis/evidence/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(factId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                return callPayload;
            }

            return new ApiConnectionAction<EvidenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<string> Version([WorkflowExpression] Func<environmentInput> environment)
        {
            SourceExpression.Validate(environment, nameof(environment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/version";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["environment"] = SourceExpressionConverter.Convert(environment);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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