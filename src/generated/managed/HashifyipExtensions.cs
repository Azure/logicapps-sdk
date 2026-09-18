//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hashifyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HashifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4GETResponse> MD4GET([WorkflowExpression] Func<string> value)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<MD4GETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4POSTResponse> MD4POST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md4/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<MD4POSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD4POSTFileResponse> MD4POSTFile([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md4/base64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<MD4POSTFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5GETResponse> MD5GET([WorkflowExpression] Func<string> value)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<MD5GETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5POSTResponse> MD5POST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md5/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<MD5POSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<MD5POSTFileResponse> MD5POSTFile([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/md5/base64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<MD5POSTFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256POSTResponse> Highway256POST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway/base64url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["X-Hashify-Key"] = SourceExpressionConverter.ConvertO(xHashifyKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<Highway256POSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomPOSTResponse> Highway256RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["X-Hashify-Key"] = SourceExpressionConverter.ConvertO(xHashifyKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<Highway256RandomPOSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomPOSTResponse> Highway64RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway-64/base32";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["X-Hashify-Key"] = SourceExpressionConverter.ConvertO(xHashifyKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<Highway64RandomPOSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128GETResponse> Highway128GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                return callPayload;
            }

            return new ApiConnectionAction<Highway128GETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomPOSTResponse> Highway128RandomPOST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway-128/hex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["X-Hashify-Key"] = SourceExpressionConverter.ConvertO(xHashifyKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<Highway128RandomPOSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway128RandomGETResponse> Highway128RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway128";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                return callPayload;
            }

            return new ApiConnectionAction<Highway128RandomGETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64RandomGETResponse> Highway64RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                return callPayload;
            }

            return new ApiConnectionAction<Highway64RandomGETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway64POSTResponse> Highway64POST([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> xHashifyKey, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(xHashifyKey, nameof(xHashifyKey), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["X-Hashify-Key"] = SourceExpressionConverter.ConvertO(xHashifyKey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<Highway64POSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<Highway256RandomGETResponse> Highway256RandomGET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> key)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hash/highway";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Queries["key"] = SourceExpressionConverter.ConvertO(key);
                return callPayload;
            }

            return new ApiConnectionAction<Highway256RandomGETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA1GETResponse> SHA1GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(digestFormat, nameof(digestFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hash/sha1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<SHA1GETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200> SHA1POSTForm([WorkflowExpression] Func<string> xHashifyProcess, [WorkflowExpression] Func<string> digestFormat, [WorkflowExpression] Func<string> file)
        {
            SourceExpression.Validate(xHashifyProcess, nameof(xHashifyProcess), required: true);
            SourceExpression.Validate(digestFormat, nameof(digestFormat), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hash/sha1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Hashify-Process"] = SourceExpressionConverter.ConvertO(xHashifyProcess);
                return callPayload;
            }

            return new ApiConnectionAction<M200>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256GETResponse> SHA256GET([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(digestFormat, nameof(digestFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hash/sha256/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<SHA256GETResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<SHA256BodyPOSTResponse> SHA256BodyPOST([WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> digestFormat, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(digestFormat, nameof(digestFormat), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/hash/sha256/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(digestFormat, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SHA256BodyPOSTResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<StatusCheckResponse> StatusCheck()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusCheckResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200[]> Methods()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/methods";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<M200[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hashifyip")]
        public IBodyWorkflowAction<M200> Keygen([WorkflowExpression] Func<string> keyLength)
        {
            SourceExpression.Validate(keyLength, nameof(keyLength), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/keygen/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(keyLength, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<M200>(BuildSourceInput);
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