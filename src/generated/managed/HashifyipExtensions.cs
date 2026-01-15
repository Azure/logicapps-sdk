//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Hashifyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4GETResponse> MD4GET(Expression<Func<string>> value)
        {
            var apiCallPath = "/hash/md4/hex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<MD4GETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4POSTResponse> MD4POST(Expression<Func<string>> value, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/md4/hex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<MD4POSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4POSTFileResponse> MD4POSTFile(Expression<Func<string>> value, Expression<Func<string>> file)
        {
            var apiCallPath = "/hash/md4/base64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<MD4POSTFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5GETResponse> MD5GET(Expression<Func<string>> value)
        {
            var apiCallPath = "/hash/md5/hex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<MD5GETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5POSTResponse> MD5POST(Expression<Func<string>> value, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/md5/hex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<MD5POSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5POSTFileResponse> MD5POSTFile(Expression<Func<string>> value, Expression<Func<string>> file)
        {
            var apiCallPath = "/hash/md5/base64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<MD5POSTFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256POSTResponse> Highway256POST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/highway/base64url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Highway256POSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomPOSTResponse> Highway256RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/highway/base32";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Highway256RandomPOSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomPOSTResponse> Highway64RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/highway-64/base32";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Highway64RandomPOSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128GETResponse> Highway128GET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var apiCallPath = "/hash/highway-128/hex";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            return new ApiConnectionAction<Highway128GETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomPOSTResponse> Highway128RandomPOST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/highway-128/hex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Highway128RandomPOSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomGETResponse> Highway128RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var apiCallPath = "/hash/highway128";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            return new ApiConnectionAction<Highway128RandomGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomGETResponse> Highway64RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var apiCallPath = "/hash/highway64";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            return new ApiConnectionAction<Highway64RandomGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64POSTResponse> Highway64POST(Expression<Func<string>> key, Expression<Func<string>> contentType, Expression<Func<string>> xHashifyKey, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/hash/highway64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Headers["X-Hashify-Key"] = ExpressionConverter.Convert(xHashifyKey);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Highway64POSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomGETResponse> Highway256RandomGET(Expression<Func<string>> value, Expression<Func<string>> key)
        {
            var apiCallPath = "/hash/highway";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Queries["key"] = ExpressionConverter.Convert(key);
            return new ApiConnectionAction<Highway256RandomGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA1GETResponse> SHA1GET(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var apiCallPath = String.Format("/hash/sha1/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<SHA1GETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200> SHA1POSTForm(Expression<Func<string>> xHashifyProcess, Expression<Func<string>> digestFormat, Expression<Func<string>> file)
        {
            var apiCallPath = String.Format("/hash/sha1/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Hashify-Process"] = ExpressionConverter.Convert(xHashifyProcess);
            return new ApiConnectionAction<M200>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256GETResponse> SHA256GET(Expression<Func<string>> value, Expression<Func<string>> digestFormat)
        {
            var apiCallPath = String.Format("/hash/sha256/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<SHA256GETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256BodyPOSTResponse> SHA256BodyPOST(Expression<Func<string>> value, Expression<Func<string>> digestFormat, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/hash/sha256/{0}", ExpressionConverter.ConvertWithUrlEncoding(digestFormat, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<SHA256BodyPOSTResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<StatusCheckResponse> StatusCheck()
        {
            var apiCallPath = "/status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200[]> Methods()
        {
            var apiCallPath = "/methods";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<M200[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200> Keygen(Expression<Func<string>> keyLength)
        {
            var apiCallPath = String.Format("/keygen/{0}", ExpressionConverter.ConvertWithUrlEncoding(keyLength, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<M200>(callPayload);
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

    public class MD4POSTFileResponse
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

    public class MD5POSTFileResponse
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

    public class M200
    {
        public string Digest { get; set; }
        public string DigestEnc { get; set; }
        public string Type { get; set; }
        public JToken Key { get; set; }
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Hashifyip;

    public partial class WorkflowManagedActions
    {
        public HashifyipActions Hashifyip(string connectionId) => new HashifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HashifyipTriggers Hashifyip(string connectionId) => new HashifyipTriggers(connectionId);
    }
}