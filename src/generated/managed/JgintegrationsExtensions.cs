//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jgintegrations
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JgintegrationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<HASHHMACResponse, ApiConnectionActionConfiguration> HASHHMAC(Expression<Func<HASHHMACInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<HASHHMACResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crypto/hash_hmac";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HASHHMACResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<PREGREPLACEResponse, ApiConnectionActionConfiguration> PREGREPLACE(Expression<Func<PREGREPLACEInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PREGREPLACEResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/preg_replace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PREGREPLACEResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<MANUALResponse, ApiConnectionActionConfiguration> MANUAL(Expression<Func<MANUALInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MANUALResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/manual_func";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MANUALResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> HTMLTOPDF(Expression<Func<HTMLTOPDFInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/html_to_pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/pdf");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jgintegrations")]
        public IBodyWorkflowAction<FILESTRINGResponse, ApiConnectionActionConfiguration> FILESTRING(Expression<Func<FILESTRINGInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FILESTRINGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/text/file_string";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FILESTRINGResponse>(callPayload);
            });
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

    public class HASHHMACInput
    {
        [JsonProperty("algo", DefaultValueHandling = DefaultValueHandling.Include)]
        public HASHHMACInputAlgoType Algo { get; set; } = HASHHMACInputAlgoType.Sha256;

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HASHHMACInputAlgoType
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

    public class PREGREPLACEInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("replacement", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Replacement { get; set; } = "";

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }
    }

    public class MANUALResponse
    {
        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public class MANUALInput
    {
        [JsonProperty("function", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Function { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class HTMLTOPDFInput
    {
        [JsonProperty("html", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Html { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Landscape { get; set; } = false;

        [JsonProperty("pagesize", DefaultValueHandling = DefaultValueHandling.Include)]
        public HTMLTOPDFInputPagesizeType Pagesize { get; set; } = HTMLTOPDFInputPagesizeType.A4;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HTMLTOPDFInputPagesizeType
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

    public class FILESTRINGInput
    {
        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Pattern { get; set; } = "/[^a-zA-Z0-9 \\-\\(\\)\\_]+/";

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }
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