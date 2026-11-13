//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashifyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4GetResponse, ApiConnectionActionConfiguration> MD4Get(Expression<Func<string>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<MD4GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<MD4GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4Response, ApiConnectionActionConfiguration> MD4(Expression<Func<string>> value, Expression<Func<string>> body)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MD4Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MD4Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5GetResponse, ApiConnectionActionConfiguration> MD5Get(Expression<Func<string>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<MD5GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<MD5GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5Response, ApiConnectionActionConfiguration> MD5(Expression<Func<string>> value, Expression<Func<string>> body)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MD5Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MD5Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256Response, ApiConnectionActionConfiguration> Highway256(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Highway256Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway/base64url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway256Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomResponse, ApiConnectionActionConfiguration> Highway256Random(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Highway256RandomResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway256RandomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomResponse, ApiConnectionActionConfiguration> Highway64Random(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Highway64RandomResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-64/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway64RandomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128GetResponse, ApiConnectionActionConfiguration> Highway128Get(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway128GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomResponse, ApiConnectionActionConfiguration> Highway128Random(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Highway128RandomResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway128RandomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomGetResponse, ApiConnectionActionConfiguration> Highway128RandomGet(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128RandomGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway128";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway128RandomGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomGetResponse, ApiConnectionActionConfiguration> Highway64RandomGet(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway64RandomGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway64RandomGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64Response, ApiConnectionActionConfiguration> Highway64(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Highway64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomGetResponse, ApiConnectionActionConfiguration> Highway256RandomGet(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway256RandomGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway256RandomGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Sha1GetResponse, ApiConnectionActionConfiguration> Sha1Get(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<Sha1GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha1/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<Sha1GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Sha256GetResponse, ApiConnectionActionConfiguration> Sha256Get(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<Sha256GetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha256/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<Sha256GetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Sha256BodyResponse, ApiConnectionActionConfiguration> Sha256Body(Expression<Func<string>> value, Expression<Func<string>> digestFormat, Expression<Func<string>> body)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sha256BodyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha256/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sha256BodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<StatusCheckResponse, ApiConnectionActionConfiguration> StatusCheck()
        {
            return new DeferredBodyAction<StatusCheckResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200[], ApiConnectionActionConfiguration> Methods()
        {
            return new DeferredBodyAction<M200[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/methods";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<M200[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200, ApiConnectionActionConfiguration> Keygen(Expression<Func<string>> keyLength)
        {
            var __workflow_keyLength = WorkflowExpression.Compile(keyLength, nameof(keyLength), required: true);
            return new DeferredBodyAction<M200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/keygen/{0}", __workflow_keyLength.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<M200>(callPayload);
            });
        }
    }

    public class HashifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MD4GetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD4Response
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD5GetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD5Response
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256Response
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256RandomResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64RandomResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128GetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128RandomResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128RandomGetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64RandomGetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64Response
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256RandomGetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Sha1GetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Sha256GetResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Sha256BodyResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class StatusCheckResponse
    {
        [JsonProperty("hashesGenerated")]
        public int HashesGenerated { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("keysGenerated")]
        public int KeysGenerated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }
    }

    public class M200
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public JToken Key { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hashifyip;

    public partial class WorkflowManagedActions
    {
        public HashifyipActions Hashifyip(string connectionId) => new HashifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HashifyipTriggers Hashifyip(string connectionId) => new HashifyipTriggers(connectionId);
    }
}