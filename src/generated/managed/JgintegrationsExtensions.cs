//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jgintegrations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JgintegrationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<HASHHMACResponse> HASHHMAC(Expression<Func<bodyalgoInput>> bodyalgo, Expression<Func<string>> bodycontent, Expression<Func<string>> bodykey)
        {
            var apiCallPath = "/crypto/hash_hmac";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["algo"] = CSharpExpressionConverter.Convert(bodyalgo);
            bodypropCount++;
            body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
            bodypropCount++;
            body["key"] = CSharpExpressionConverter.ConvertToken(bodykey);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<HASHHMACResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<PREGREPLACEResponse> PREGREPLACE(Expression<Func<string>> bodypattern, Expression<Func<string>> bodysubject, Expression<Func<string>> bodyreplacement = null)
        {
            var apiCallPath = "/text/preg_replace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pattern"] = CSharpExpressionConverter.ConvertToken(bodypattern);
            if (bodyreplacement != null)
            {
                if (bodyreplacement != null)
                {
                    body["replacement"] = CSharpExpressionConverter.ConvertToken(bodyreplacement);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["replacement"] = "";
                bodypropCount++;
            }

            bodypropCount++;
            body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PREGREPLACEResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<MANUALResponse> MANUAL(Expression<Func<string>> bodyfunction, Expression<Func<string>> bodydata)
        {
            var apiCallPath = "/manual_func";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["function"] = CSharpExpressionConverter.ConvertToken(bodyfunction);
            bodypropCount++;
            body["data"] = CSharpExpressionConverter.ConvertToken(bodydata);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MANUALResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<JToken> HTMLTOPDF(Expression<Func<string>> bodyhtml, Expression<Func<string>> bodyname, Expression<Func<bool>> bodylandscape, Expression<Func<bodypagesizeInput>> bodypagesize)
        {
            var apiCallPath = "/text/html_to_pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/pdf");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["html"] = CSharpExpressionConverter.ConvertToken(bodyhtml);
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["landscape"] = CSharpExpressionConverter.ConvertToken(bodylandscape);
            bodypropCount++;
            body["pagesize"] = CSharpExpressionConverter.Convert(bodypagesize);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<FILESTRINGResponse> FILESTRING(Expression<Func<string>> bodysubject)
        {
            var apiCallPath = "/text/file_string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["pattern"] = "/[^a-zA-Z0-9 \\-\\(\\)\\_]+/";
            bodypropCount++;
            bodypropCount++;
            body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FILESTRINGResponse>(callPayload);
        }
    }

    public class JgintegrationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class HASHHMACResponse
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public enum bodyalgoInput
    {
        [EnumMember(Value = "md2")]
        Md2,
        [EnumMember(Value = "md4")]
        Md4,
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha224")]
        Sha224,
        [EnumMember(Value = "sha256")]
        Sha256,
        [EnumMember(Value = "sha384")]
        Sha384,
        [EnumMember(Value = "sha512/224")]
        Sha512224,
        [EnumMember(Value = "sha512/256")]
        Sha512256,
        [EnumMember(Value = "sha512")]
        Sha512,
        [EnumMember(Value = "sha3-224")]
        Sha3224,
        [EnumMember(Value = "sha3-256")]
        Sha3256,
        [EnumMember(Value = "sha3-384")]
        Sha3384,
        [EnumMember(Value = "sha3-512")]
        Sha3512,
        [EnumMember(Value = "ripemd128")]
        Ripemd128,
        [EnumMember(Value = "ripemd160")]
        Ripemd160,
        [EnumMember(Value = "ripemd256")]
        Ripemd256,
        [EnumMember(Value = "ripemd320")]
        Ripemd320,
        [EnumMember(Value = "whirlpool")]
        Whirlpool,
        [EnumMember(Value = "snefru")]
        Snefru,
        [EnumMember(Value = "snefru256")]
        Snefru256,
        [EnumMember(Value = "gost")]
        Gost,
        [EnumMember(Value = "gost-crypto")]
        GostCrypto
    }

    public class PREGREPLACEResponse
    {
        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public class MANUALResponse
    {
        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public enum bodypagesizeInput
    {
        [EnumMember(Value = "[4a0")]
        _4a0,
        [EnumMember(Value = "2a0")]
        _2a0,
        [EnumMember(Value = "a0")]
        A0,
        [EnumMember(Value = "a1")]
        A1,
        [EnumMember(Value = "a2")]
        A2,
        [EnumMember(Value = "a3")]
        A3,
        [EnumMember(Value = "a4")]
        A4,
        [EnumMember(Value = "a5")]
        A5,
        [EnumMember(Value = "a6")]
        A6,
        [EnumMember(Value = "a7")]
        A7,
        [EnumMember(Value = "a8")]
        A8,
        [EnumMember(Value = "a9")]
        A9,
        [EnumMember(Value = "a10")]
        A10,
        [EnumMember(Value = "b0")]
        B0,
        [EnumMember(Value = "b1")]
        B1,
        [EnumMember(Value = "b2")]
        B2,
        [EnumMember(Value = "b3")]
        B3,
        [EnumMember(Value = "b4")]
        B4,
        [EnumMember(Value = "b5")]
        B5,
        [EnumMember(Value = "b6")]
        B6,
        [EnumMember(Value = "b7")]
        B7,
        [EnumMember(Value = "b8")]
        B8,
        [EnumMember(Value = "b9")]
        B9,
        [EnumMember(Value = "b10")]
        B10,
        [EnumMember(Value = "c0")]
        C0,
        [EnumMember(Value = "c1")]
        C1,
        [EnumMember(Value = "c2")]
        C2,
        [EnumMember(Value = "c3")]
        C3,
        [EnumMember(Value = "c4")]
        C4,
        [EnumMember(Value = "c5")]
        C5,
        [EnumMember(Value = "c6")]
        C6,
        [EnumMember(Value = "c7")]
        C7,
        [EnumMember(Value = "c8")]
        C8,
        [EnumMember(Value = "c9")]
        C9,
        [EnumMember(Value = "c10")]
        C10,
        [EnumMember(Value = "ra0")]
        Ra0,
        [EnumMember(Value = "ra1")]
        Ra1,
        [EnumMember(Value = "ra2")]
        Ra2,
        [EnumMember(Value = "ra3")]
        Ra3,
        [EnumMember(Value = "ra4")]
        Ra4,
        [EnumMember(Value = "sra0")]
        Sra0,
        [EnumMember(Value = "sra1")]
        Sra1,
        [EnumMember(Value = "sra2")]
        Sra2,
        [EnumMember(Value = "sra3")]
        Sra3,
        [EnumMember(Value = "sra4")]
        Sra4,
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "half-letter")]
        HalfLetter,
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "ledger")]
        Ledger,
        [EnumMember(Value = "tabloid")]
        Tabloid,
        [EnumMember(Value = "executive")]
        Executive,
        [EnumMember(Value = "folio")]
        Folio,
        [EnumMember(Value = "commercial #10 envelope")]
        Commercial10Envelope,
        [EnumMember(Value = "catalog #10 1/2 envelope")]
        Catalog1012Envelope,
        [EnumMember(Value = "8.5x11")]
        _85x11,
        [EnumMember(Value = "8.5x14")]
        _85x14,
        [EnumMember(Value = "11x17")]
        _11x17,
        [EnumMember(Value = "]")]
        Unnamed
    }

    public class FILESTRINGResponse
    {
        [JsonProperty("output")]
        public string Output { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jgintegrations;

    public partial class WorkflowManagedActions
    {
        public JgintegrationsActions Jgintegrations(string connectionId) => new JgintegrationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JgintegrationsTriggers Jgintegrations(string connectionId) => new JgintegrationsTriggers(connectionId);
    }
}