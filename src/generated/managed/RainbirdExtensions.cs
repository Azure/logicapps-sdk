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
        public IBodyWorkflowAction<StartResponse> Start(Expression<Func<environmentInput>> environment, Expression<Func<string>> kmID)
        {
            var apiCallPath = String.Format("/start/{0}", ExpressionConverter.ConvertWithUrlEncoding(kmID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
            return new ApiConnectionAction<StartResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<InjectResponse> Inject(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionID, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/{0}/inject", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<InjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Query(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionID, Expression<Func<string>> bodyrelationship, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodyObject = null)
        {
            var apiCallPath = String.Format("/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Response(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionID, Expression<Func<bodyanswersInputItem[]>> bodyanswers = null)
        {
            var apiCallPath = String.Format("/{0}/response", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<JToken> Undo(Expression<Func<environmentInput>> environment, Expression<Func<string>> sessionID)
        {
            var apiCallPath = String.Format("/{0}/undo", ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<EvidenceResponse> Evidence(Expression<Func<environmentInput>> environment, Expression<Func<string>> factID, Expression<Func<string>> sessionID)
        {
            var apiCallPath = String.Format("/analysis/evidence/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(factID, 1), ExpressionConverter.ConvertWithUrlEncoding(sessionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
            return new ApiConnectionAction<EvidenceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rainbird")]
        public IBodyWorkflowAction<string> Version(Expression<Func<environmentInput>> environment)
        {
            var apiCallPath = "/version";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["environment"] = ExpressionConverter.Convert(environment);
            return new ApiConnectionAction<string>(callPayload);
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
        public JToken Object { get; set; }

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
        public JToken Object { get; set; }

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
        public EvidenceResponseFactTypeObjectType Object { get; set; }

        [JsonProperty("relationship")]
        public EvidenceResponseFactTypeRelationshipType Relationship { get; set; }

        [JsonProperty("subject")]
        public EvidenceResponseFactTypeSubjectType Subject { get; set; }
    }

    public class EvidenceResponseFactTypeObjectType
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
        public JToken Object { get; set; }

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