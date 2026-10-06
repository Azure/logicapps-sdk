//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Solosign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SolosignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solosign")]
        [WorkflowExpressionFactory(nameof(__BuildCreateHMAC))]
        public IWorkflowAction CreateHMAC([WorkflowExpression] Func<string> bodyrequestString, [WorkflowExpression] Func<string> bodysecretKey, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyencodeTypeInput> bodyencodeType = null, [WorkflowExpression] Func<bodyhashAlgorithmInput> bodyhashAlgorithm = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solosign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateHMAC(WorkflowExpression<string> bodyrequestString, WorkflowExpression<string> bodysecretKey, WorkflowExpression<bodyoutputFormatInput> bodyoutputFormat = null, WorkflowExpression<bodyencodeTypeInput> bodyencodeType = null, WorkflowExpression<bodyhashAlgorithmInput> bodyhashAlgorithm = null)
        {
            WorkflowExpression.Validate(bodyrequestString, nameof(bodyrequestString), required: true);
            WorkflowExpression.Validate(bodysecretKey, nameof(bodysecretKey), required: true);
            WorkflowExpression.Validate(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            WorkflowExpression.Validate(bodyencodeType, nameof(bodyencodeType), required: false);
            WorkflowExpression.Validate(bodyhashAlgorithm, nameof(bodyhashAlgorithm), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/generate-hmac";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["request_string"] = ExpressionConverter.ConvertO(bodyrequestString);
                bodypropCount++;
                body["secret_key"] = ExpressionConverter.ConvertO(bodysecretKey);
                if (bodyoutputFormat != null)
                {
                    body["output_format"] = ExpressionConverter.ConvertO(bodyoutputFormat);
                    bodypropCount++;
                }

                if (bodyencodeType != null)
                {
                    body["encode_type"] = ExpressionConverter.ConvertO(bodyencodeType);
                    bodypropCount++;
                }

                if (bodyhashAlgorithm != null)
                {
                    body["hash_algorithm"] = ExpressionConverter.ConvertO(bodyhashAlgorithm);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SolosignTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodyoutputFormatInput
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

    public enum bodyencodeTypeInput
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

    public enum bodyhashAlgorithmInput
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