//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trustual
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TrustualActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput, ApiConnectionActionConfiguration> CertifyFile(Expression<Func<CertifyFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CertificationOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/certify_file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CertificationOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput, ApiConnectionActionConfiguration> CertifyHash(Expression<Func<CertifyHashInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CertificationOutput, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/certify_hash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CertificationOutput>(callPayload);
            });
        }
    }

    public class TrustualTriggers([ConnectionName] string connectionId)
    {
    }

    public class CertificationOutput
    {
        [JsonProperty("certificate_base_64")]
        public string CertificateBase64 { get; set; }

        [JsonProperty("features")]
        public ZFeaturesItem[] Features { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public ZLanguage Language { get; set; }

        [JsonProperty("local_timestamp")]
        public string LocalTimestamp { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("status")]
        public ZStatus Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ZFeaturesItem
    {
        [EnumMember(Value = "eu_qualified")]
        EuQualified,
        [EnumMember(Value = "test_mode")]
        TestMode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ZLanguage
    {
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "nl")]
        Nl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ZStatus
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed
    }

    public class CertifyFileInput
    {
        [JsonProperty("file_base_64", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileBase64 { get; set; }

        [JsonProperty("language")]
        public ZLanguage? Language { get; set; }

        [JsonProperty("offset")]
        public double? Offset { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("sandbox")]
        public bool? Sandbox { get; set; }
    }

    public class CertifyHashInput
    {
        [JsonProperty("hash", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Hash { get; set; }

        [JsonProperty("language")]
        public ZLanguage? Language { get; set; }

        [JsonProperty("offset")]
        public double? Offset { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("sandbox")]
        public bool? Sandbox { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Trustual;

    public partial class WorkflowManagedActions
    {
        public TrustualActions Trustual(string connectionId) => new TrustualActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TrustualTriggers Trustual(string connectionId) => new TrustualTriggers(connectionId);
    }
}