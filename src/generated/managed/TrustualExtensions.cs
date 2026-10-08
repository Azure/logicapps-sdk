//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trustual
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TrustualActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        [WorkflowExpressionFactory(nameof(__BuildCertifyFile))]
        public IBodyWorkflowAction<CertificationOutput> CertifyFile([WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<bodycertificateLanguageInput> bodycertificateLanguage = null, [WorkflowExpression] Func<double> bodytimeZoneOffset = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bool> bodysandboxMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CertificationOutput> __BuildCertifyFile(WorkflowExpression<string> bodyfileContent = null, WorkflowExpression<bodycertificateLanguageInput> bodycertificateLanguage = null, WorkflowExpression<double> bodytimeZoneOffset = null, WorkflowExpression<string> bodyreference = null, WorkflowExpression<bool> bodysandboxMode = null)
        {
            WorkflowExpression.Validate(bodyfileContent, nameof(bodyfileContent), required: false);
            WorkflowExpression.Validate(bodycertificateLanguage, nameof(bodycertificateLanguage), required: false);
            WorkflowExpression.Validate(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            WorkflowExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            WorkflowExpression.Validate(bodysandboxMode, nameof(bodysandboxMode), required: false);
            return new DeferredBodyAction<CertificationOutput>(() =>
            {
                var apiCallPath = "/certify_file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileContent != null)
                {
                    body["file_base_64"] = ExpressionConverter.ConvertO(bodyfileContent);
                    bodypropCount++;
                }

                if (bodycertificateLanguage != null)
                {
                    if (bodycertificateLanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(bodycertificateLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytimeZoneOffset != null)
                {
                    body["offset"] = ExpressionConverter.ConvertO(bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(bodyreference);
                    bodypropCount++;
                }

                if (bodysandboxMode != null)
                {
                    body["sandbox"] = ExpressionConverter.ConvertO(bodysandboxMode);
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
        [WorkflowExpressionFactory(nameof(__BuildCertifyHash))]
        public IBodyWorkflowAction<CertificationOutput> CertifyHash([WorkflowExpression] Func<string> bodyhash = null, [WorkflowExpression] Func<bodycertificateLanguageInput> bodycertificateLanguage = null, [WorkflowExpression] Func<double> bodytimeZoneOffset = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<bool> bodysandboxMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CertificationOutput> __BuildCertifyHash(WorkflowExpression<string> bodyhash = null, WorkflowExpression<bodycertificateLanguageInput> bodycertificateLanguage = null, WorkflowExpression<double> bodytimeZoneOffset = null, WorkflowExpression<string> bodyreference = null, WorkflowExpression<bool> bodysandboxMode = null)
        {
            WorkflowExpression.Validate(bodyhash, nameof(bodyhash), required: false);
            WorkflowExpression.Validate(bodycertificateLanguage, nameof(bodycertificateLanguage), required: false);
            WorkflowExpression.Validate(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            WorkflowExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            WorkflowExpression.Validate(bodysandboxMode, nameof(bodysandboxMode), required: false);
            return new DeferredBodyAction<CertificationOutput>(() =>
            {
                var apiCallPath = "/certify_hash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyhash != null)
                {
                    body["hash"] = ExpressionConverter.ConvertO(bodyhash);
                    bodypropCount++;
                }

                if (bodycertificateLanguage != null)
                {
                    if (bodycertificateLanguage != null)
                    {
                        body["language"] = ExpressionConverter.ConvertO(bodycertificateLanguage);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["language"] = "en";
                    bodypropCount++;
                }

                if (bodytimeZoneOffset != null)
                {
                    body["offset"] = ExpressionConverter.ConvertO(bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(bodyreference);
                    bodypropCount++;
                }

                if (bodysandboxMode != null)
                {
                    body["sandbox"] = ExpressionConverter.ConvertO(bodysandboxMode);
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