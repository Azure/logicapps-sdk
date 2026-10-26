//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Solosign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SolosignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solosign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateHMAC(Expression<Func<CreateHMACInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/generate-hmac";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SolosignTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateHMACInput
    {
        [JsonProperty("request_string", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestString { get; set; }

        [JsonProperty("secret_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SecretKey { get; set; }

        [JsonProperty("output_format")]
        public CreateHMACInputOutputFormatType? OutputFormat { get; set; }

        [JsonProperty("encode_type")]
        public CreateHMACInputEncodeTypeType? EncodeType { get; set; }

        [JsonProperty("hash_algorithm")]
        public CreateHMACInputHashAlgorithmType? HashAlgorithm { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateHMACInputOutputFormatType
    {
        [EnumMember(Value = "hex")]
        Hex,
        [EnumMember(Value = "base32")]
        Base32,
        [EnumMember(Value = "base64")]
        Base64,
        [EnumMember(Value = "base64url")]
        Base64url,
        [EnumMember(Value = "hash")]
        Hash
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateHMACInputEncodeTypeType
    {
        [EnumMember(Value = "utf-7")]
        Utf7,
        [EnumMember(Value = "utf-8")]
        Utf8,
        [EnumMember(Value = "utf-32")]
        Utf32,
        [EnumMember(Value = "ascii")]
        Ascii,
        [EnumMember(Value = "unicode")]
        Unicode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateHMACInputHashAlgorithmType
    {
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha224")]
        Sha224,
        [EnumMember(Value = "sha256")]
        Sha256,
        [EnumMember(Value = "sha384")]
        Sha384,
        [EnumMember(Value = "sha512")]
        Sha512,
        [EnumMember(Value = "sha3_224")]
        Sha3224,
        [EnumMember(Value = "sha3_256")]
        Sha3256,
        [EnumMember(Value = "sha3_384")]
        Sha3384,
        [EnumMember(Value = "sha3_512")]
        Sha3512,
        [EnumMember(Value = "shake_128")]
        Shake128,
        [EnumMember(Value = "shake_256")]
        Shake256,
        [EnumMember(Value = "blake2b")]
        Blake2b,
        [EnumMember(Value = "blake2s")]
        Blake2s,
        [EnumMember(Value = "md5")]
        Md5
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Solosign;

    public partial class WorkflowManagedActions
    {
        public SolosignActions Solosign(string connectionId) => new SolosignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SolosignTriggers Solosign(string connectionId) => new SolosignTriggers(connectionId);
    }
}