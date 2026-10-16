//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trustual
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TrustualActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput> CertifyFile(Expression<Func<string>> bodyfileContent = null, Expression<Func<bodycertificateLanguageInput>> bodycertificateLanguage = null, Expression<Func<double>> bodytimeZoneOffset = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodysandboxMode = null)
        {
            var __workflow_bodyfileContent = WorkflowExpression.Compile(bodyfileContent, nameof(bodyfileContent), required: false);
            var __workflow_bodycertificateLanguage = WorkflowExpression.Compile(bodycertificateLanguage, nameof(bodycertificateLanguage), required: false);
            var __workflow_bodytimeZoneOffset = WorkflowExpression.Compile(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodysandboxMode = WorkflowExpression.Compile(bodysandboxMode, nameof(bodysandboxMode), required: false);
            return new DeferredBodyAction<CertificationOutput>(() =>
            {
                var apiCallPath = "/certify_file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileContent != null)
                {
                    body["file_base_64"] = ExpressionConverter.ConvertO(__workflow_bodyfileContent);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateLanguage != null)
                {
                    if (__workflow_bodycertificateLanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(__workflow_bodycertificateLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (__workflow_bodytimeZoneOffset != null)
                {
                    body["offset"] = ExpressionConverter.ConvertO(__workflow_bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodysandboxMode != null)
                {
                    body["sandbox"] = ExpressionConverter.ConvertO(__workflow_bodysandboxMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CertificationOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput> CertifyHash(Expression<Func<string>> bodyhash = null, Expression<Func<bodycertificateLanguageInput>> bodycertificateLanguage = null, Expression<Func<double>> bodytimeZoneOffset = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodysandboxMode = null)
        {
            var __workflow_bodyhash = WorkflowExpression.Compile(bodyhash, nameof(bodyhash), required: false);
            var __workflow_bodycertificateLanguage = WorkflowExpression.Compile(bodycertificateLanguage, nameof(bodycertificateLanguage), required: false);
            var __workflow_bodytimeZoneOffset = WorkflowExpression.Compile(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodysandboxMode = WorkflowExpression.Compile(bodysandboxMode, nameof(bodysandboxMode), required: false);
            return new DeferredBodyAction<CertificationOutput>(() =>
            {
                var apiCallPath = "/certify_hash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyhash != null)
                {
                    body["hash"] = ExpressionConverter.ConvertO(__workflow_bodyhash);
                    bodypropCount++;
                }

                if (__workflow_bodycertificateLanguage != null)
                {
                    if (__workflow_bodycertificateLanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(__workflow_bodycertificateLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (__workflow_bodytimeZoneOffset != null)
                {
                    body["offset"] = ExpressionConverter.ConvertO(__workflow_bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodysandboxMode != null)
                {
                    body["sandbox"] = ExpressionConverter.ConvertO(__workflow_bodysandboxMode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycertificateLanguageInput
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
