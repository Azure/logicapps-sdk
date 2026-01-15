//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Trustual
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TrustualActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput> CertifyFile(Expression<Func<string>> bodyfileContent = null, Expression<Func<bodycertificateLanguageInput>> bodycertificateLanguage = null, Expression<Func<double>> bodytimeZoneOffset = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodysandboxMode = null)
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
                body["language"] = ExpressionConverter.ConvertO(bodycertificateLanguage);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trustual")]
        public IBodyWorkflowAction<CertificationOutput> CertifyHash(Expression<Func<string>> bodyhash = null, Expression<Func<bodycertificateLanguageInput>> bodycertificateLanguage = null, Expression<Func<double>> bodytimeZoneOffset = null, Expression<Func<string>> bodyreference = null, Expression<Func<bool>> bodysandboxMode = null)
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
                body["language"] = ExpressionConverter.ConvertO(bodycertificateLanguage);
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

    public enum ZFeaturesItem
    {
        [EnumMember(Value = "eu_qualified")]
        EuQualified,
        [EnumMember(Value = "test_mode")]
        TestMode
    }

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

    public enum ZStatus
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed
    }

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
    using Microsoft.Azure.Workflows.Sdk.Trustual;

    public partial class WorkflowManagedActions
    {
        public TrustualActions Trustual(string connectionId) => new TrustualActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TrustualTriggers Trustual(string connectionId) => new TrustualTriggers(connectionId);
    }
}