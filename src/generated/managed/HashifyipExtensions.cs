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
        public IBodyWorkflowAction<MD4GETResponse, ApiConnectionActionConfiguration> MD4GET(Expression<Func<string>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<MD4GETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<MD4GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4POSTResponse, ApiConnectionActionConfiguration> MD4POST(Expression<Func<string>> value, Expression<Func<string>> body = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MD4POSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MD4POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5GETResponse, ApiConnectionActionConfiguration> MD5GET(Expression<Func<string>> value)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<MD5GETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<MD5GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5POSTResponse, ApiConnectionActionConfiguration> MD5POST(Expression<Func<string>> value, Expression<Func<string>> body = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MD5POSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MD5POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256POSTResponse, ApiConnectionActionConfiguration> Highway256POST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway256POSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway/base64url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway256POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomPOSTResponse, ApiConnectionActionConfiguration> Highway256RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway256RandomPOSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway256RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomPOSTResponse, ApiConnectionActionConfiguration> Highway64RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway64RandomPOSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-64/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway64RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128GETResponse, ApiConnectionActionConfiguration> Highway128GET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128GETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway128GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomPOSTResponse, ApiConnectionActionConfiguration> Highway128RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway128RandomPOSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway128RandomPOSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomGETResponse, ApiConnectionActionConfiguration> Highway128RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway128RandomGETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway128";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway128RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomGETResponse, ApiConnectionActionConfiguration> Highway64RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway64RandomGETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway64RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64POSTResponse, ApiConnectionActionConfiguration> Highway64POST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_xHashifyKey = WorkflowExpression.Compile(xHashifyKey, nameof(xHashifyKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Highway64POSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(__workflow_xHashifyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Highway64POSTResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomGETResponse, ApiConnectionActionConfiguration> Highway256RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<Highway256RandomGETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/hash/highway";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Queries["key"] = ExpressionConverter.Convert(__workflow_key);
                return new ApiConnectionAction<Highway256RandomGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA1GETResponse, ApiConnectionActionConfiguration> SHA1GET(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<SHA1GETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha1/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<SHA1GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256GETResponse, ApiConnectionActionConfiguration> SHA256GET(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            return new DeferredBodyAction<SHA256GETResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha256/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<SHA256GETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256BodyPOSTResponse, ApiConnectionActionConfiguration> SHA256BodyPOST(Expression<Func<string>> value, Expression<Func<string>> digestFormat, Expression<Func<string>> body = null)
        {
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_digestFormat = WorkflowExpression.Compile(digestFormat, nameof(digestFormat), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SHA256BodyPOSTResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/hash/sha256/{0}", __workflow_digestFormat.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SHA256BodyPOSTResponse>(callPayload);
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

    public class MD4GETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD4POSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD5GETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class MD5POSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256POSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256RandomPOSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64RandomPOSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128GETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128RandomPOSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway128RandomGETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64RandomGETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway64POSTResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class Highway256RandomGETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class SHA1GETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class SHA256GETResponse
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public string Key { get; set; }
    }

    public class SHA256BodyPOSTResponse
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